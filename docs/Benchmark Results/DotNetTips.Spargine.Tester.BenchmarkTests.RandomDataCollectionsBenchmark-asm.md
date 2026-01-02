## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonRefCollection()
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       call      qword ptr [7FFEFFCFC6D8]; DotNetTips.Spargine.Benchmarking.LargeCollectionBenchmark.get_Count()
       mov       ecx,eax
       call      qword ptr [7FFEFFDA6B80]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection(Int32)
       mov       [rbp-8],rax
       mov       rcx,[rbp+10]
       mov       r8,[rbp-8]
       mov       rdx,7FFF000EA618
       call      qword ptr [7FFF0005DEC0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 73
```
```assembly
; DotNetTips.Spargine.Benchmarking.LargeCollectionBenchmark.get_Count()
       push      rbp
       mov       rbp,rsp
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       eax,[rax+268]
       pop       rbp
       ret
; Total bytes of code 20
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection(Int32)
; 		count = count.ArgumentInRange(min: 1, defaultValue: 2);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var people = new List<Person>(count);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		for (var index = 0; index < count; index++)
; 		     ^^^^^^^^^^^^^
; 			people.Add(GeneratePersonRef());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return people.ToReadOnlyCollection();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rbp
       sub       rsp,0A0
       lea       rbp,[rsp+0A0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-70],ymm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       xor       eax,eax
       mov       [rbp-40],rax
       mov       [rbp+10],ecx
       mov       dword ptr [rbp-68],3E8
       xor       eax,eax
       mov       [rbp-58],rax
       lea       rcx,[rbp-58]
       mov       edx,2
       call      qword ptr [7FFEFFBC6748]; System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       rax,[rbp-58]
       mov       [rbp-48],rax
       lea       rax,[rbp-48]
       mov       [rsp+20],rax
       mov       rax,214AEB00008
       mov       [rsp+28],rax
       mov       ecx,[rbp+10]
       mov       edx,1
       mov       r8,214AEB03620
       mov       r9d,7FFFFFFF
       call      qword ptr [7FFEFFCFE250]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32> ByRef, System.String)
       mov       [rbp+10],eax
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-60],rax
       mov       rcx,[rbp-60]
       mov       edx,[rbp+10]
       call      qword ptr [7FFEFF96EC70]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       mov       rax,[rbp-60]
       mov       [rbp-40],rax
       xor       eax,eax
       mov       [rbp-4C],eax
       jmp       short M02_L01
M02_L00:
       mov       rcx,7FFF00043A88
       call      CORINFO_HELP_COUNTPROFILE32
       mov       ecx,2
       mov       edx,19
       mov       r8d,14
       call      qword ptr [7FFEFFCFE190]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRef(Int32, Int32, Int32)
       mov       [rbp-70],rax
       mov       rdx,[rbp-70]
       mov       rcx,[rbp-40]
       cmp       [rcx],ecx
       call      qword ptr [7FFEFF8017D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       mov       eax,[rbp-4C]
       add       eax,1
       jo        short M02_L03
       mov       [rbp-4C],eax
M02_L01:
       mov       eax,[rbp-68]
       dec       eax
       mov       [rbp-68],eax
       cmp       dword ptr [rbp-68],0
       jg        short M02_L02
       lea       rcx,[rbp-68]
       mov       edx,40
       call      CORINFO_HELP_PATCHPOINT
M02_L02:
       mov       eax,[rbp-4C]
       cmp       eax,[rbp+10]
       jl        short M02_L00
       mov       rcx,7FFF00043A8C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rdx,[rbp-40]
       mov       rcx,7FFF00043A18
       call      qword ptr [7FFEFFCFD3E0]; DotNetTips.Spargine.Extensions.EnumerableExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       nop
       add       rsp,0A0
       pop       rbp
       ret
M02_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
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
       mov       rdx,7FFF0019EFA8
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M03_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFF001D48B8]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFF001D4870]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 129
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.PersonRecordOrderBy()
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
       xor       eax,eax
       mov       [rbp-58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp-40],rax
       mov       rbx,rcx
       lea       rcx,[rbp-90]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rcx,rsp
       mov       [rbp-78],rcx
       mov       rcx,rbp
       mov       [rbp-68],rcx
       mov       [rbp+10],rbx
       mov       rdi,[rbx+280]
       mov       rcx,19472400E68
       mov       r14,[rcx]
       test      r14,r14
       je        near ptr M00_L60
M00_L00:
       mov       rcx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [r15+10],eax
       lea       rcx,[r15+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        near ptr M00_L58
       xor       ecx,ecx
       mov       [r15+20],rcx
       lea       rcx,[r15+28]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,19449400A08
       mov       rdx,[rcx]
       lea       rcx,[r15+30]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [r15+48],0
       mov       rcx,[r15+18]
       mov       rax,offset MT_System.Collections.ObjectModel.Collection<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord>
       cmp       [rcx],rax
       jne       near ptr M00_L63
       mov       rdi,[rcx+8]
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord[]
       cmp       [rdi],rcx
       jne       near ptr M00_L62
       mov       r14d,[rdi+8]
       test      r14d,r14d
       jne       near ptr M00_L59
       mov       r13,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord>
       mov       rcx,r13
       test      byte ptr [7FFEFFFFD3F8],1
       je        near ptr M00_L61
M00_L01:
       mov       rcx,19472400E98
       mov       r12,[rcx]
M00_L02:
       mov       [rbp-98],r12
       mov       r13,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord>
       cmp       [r12],r13
       jne       near ptr M00_L30
       mov       ecx,[r12+8]
       inc       ecx
       cmp       ecx,[r12+0C]
       jae       near ptr M00_L29
       mov       [r12+8],ecx
M00_L03:
       mov       rdi,[r15+30]
       mov       [rbp-0A0],rdi
       mov       r14,[r15+28]
       mov       [rbp-0A8],r14
       cmp       [r12],r13
       jne       near ptr M00_L32
       mov       ecx,[r12+8]
       cmp       ecx,[r12+0C]
       jae       near ptr M00_L31
       mov       rax,[r12+10]
       cmp       ecx,[rax+8]
       jae       near ptr M00_L54
       mov       r12,[rax+rcx*8+10]
       mov       rcx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonRecordOrderBy>b__13_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       cmp       [r14+18],rcx
       jne       near ptr M00_L33
       mov       rax,[r12+30]
M00_L04:
       cmp       byte ptr [r15+48],0
       jne       near ptr M00_L34
       test      r14,r14
       je        near ptr M00_L20
       test      rdi,rdi
       je        near ptr M00_L20
       mov       r15,[rbp-98]
       cmp       [r15],r13
       jne       near ptr M00_L20
       mov       rcx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonRecordOrderBy>b__13_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       cmp       [r14+18],rcx
       jne       near ptr M00_L20
       mov       rcx,offset MT_System.Collections.Generic.GenericComparer<System.String>
       cmp       [rdi],rcx
       jne       near ptr M00_L20
       jmp       short M00_L09
M00_L05:
       mov       rdi,[rbp-0C0]
       mov       rax,r14
       mov       [rbp-0B0],rdi
       mov       r12,[rbp-0B0]
       jmp       short M00_L09
M00_L06:
       cmp       rdx,r9
       je        near ptr M00_L38
       mov       [rbp-0B0],r12
       jmp       near ptr M00_L12
M00_L07:
       xor       ecx,ecx
M00_L08:
       test      ecx,ecx
       mov       rax,[rbp-0B8]
       mov       r15,[rbp-98]
       jge       short M00_L05
M00_L09:
       mov       edx,[r15+8]
       inc       edx
       cmp       edx,[r15+0C]
       jae       near ptr M00_L27
       mov       [r15+8],edx
       mov       r8d,[r15+8]
       cmp       r8d,[r15+0C]
       jae       near ptr M00_L53
       mov       r14,[r15+10]
       cmp       r8d,[r14+8]
       jae       near ptr M00_L54
       mov       ecx,r8d
       mov       rdi,[r14+rcx*8+10]
       mov       [rbp-0C0],rdi
       mov       r14,[rdi+30]
       test      r14,r14
       je        near ptr M00_L40
       test      rax,rax
       je        near ptr M00_L39
       mov       [rbp-0B8],rax
       cmp       r14,rax
       je        short M00_L07
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],2
       jle       near ptr M00_L36
       mov       rcx,[rcx+240]
       mov       rdx,[rcx+10]
       test      rdx,rdx
       je        near ptr M00_L36
M00_L10:
       mov       rcx,[rdx+10]
       test      rcx,rcx
       jne       short M00_L11
       mov       rcx,19449400110
       mov       rcx,[rcx]
       test      rcx,rcx
       jne       short M00_L11
       mov       rcx,194494000F0
       mov       rcx,[rcx]
       test      rcx,rcx
       je        near ptr M00_L37
M00_L11:
       mov       rdx,[rcx]
       mov       rdx,[rdx+48]
       call      qword ptr [rdx+30]
       cmp       [rax],al
       lea       rdx,[r14+0C]
       mov       [rbp-0C8],r14
       mov       r8d,[r14+8]
       mov       r10,[rbp-0B8]
       lea       r9,[r10+0C]
       mov       [rbp-0B8],r10
       mov       r11d,[r10+8]
       cmp       r8d,r11d
       je        near ptr M00_L06
       mov       [rbp-0B0],r12
M00_L12:
       mov       [rbp-48],rdx
       mov       [rbp-50],r9
       mov       rcx,[rax+20]
       mov       [rsp+20],r11d
       xor       eax,eax
       mov       [rsp+28],eax
       mov       rax,7FFEFF95B650
       mov       [rbp-80],rax
       lea       rax,[M00_L13]
       mov       [rbp-70],rax
       lea       rax,[rbp-90]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFF5F2F93A0
       call      rax
M00_L13:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFF5F64F778],0
       je        short M00_L14
       call      qword ptr [7FFF5F63D608]; CORINFO_HELP_STOP_FOR_GC
M00_L14:
       mov       rcx,[rbp-88]
       mov       [rsi+8],rcx
       xor       ecx,ecx
       mov       [rbp-48],rcx
       mov       [rbp-50],rcx
M00_L15:
       mov       ecx,eax
       mov       r12,[rbp-0B0]
       mov       r14,[rbp-0C8]
       jmp       near ptr M00_L08
M00_L16:
       mov       rdx,[rbp-0C0]
       mov       r10,[rbp-0C8]
       mov       r11,r10
       mov       r12,rdx
       mov       rax,r11
       jmp       short M00_L20
M00_L17:
       cmp       rdx,r9
       je        near ptr M00_L52
       mov       [rbp-0B0],r12
       jmp       near ptr M00_L23
M00_L18:
       xor       ecx,ecx
       mov       [rbp-0B0],r12
M00_L19:
       test      ecx,ecx
       mov       rax,[rbp-0B8]
       mov       r12,[rbp-0B0]
       mov       r14,[rbp-0A8]
       jge       short M00_L16
M00_L20:
       mov       r15,[rbp-98]
       cmp       [r15],r13
       jne       near ptr M00_L42
       mov       edx,[r15+8]
       inc       edx
       cmp       edx,[r15+0C]
       jae       near ptr M00_L27
       mov       [r15+8],edx
       mov       ecx,[r15+8]
       cmp       ecx,[r15+0C]
       jae       near ptr M00_L53
       mov       rcx,[r15+10]
       mov       r8d,[r15+8]
       cmp       r8d,[rcx+8]
       jae       near ptr M00_L54
       mov       edx,r8d
       mov       rcx,[rcx+rdx*8+10]
       mov       rdx,rcx
       mov       rcx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonRecordOrderBy>b__13_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       cmp       [r14+18],rcx
       jne       near ptr M00_L43
       mov       r15,[rbp-98]
       mov       [rbp-0C0],rdx
       mov       rcx,[rdx+30]
       mov       r8,rcx
       mov       rcx,offset MT_System.Collections.Generic.GenericComparer<System.String>
       cmp       [rdi],rcx
       mov       rdi,[rbp-0A0]
       jne       near ptr M00_L45
       test      r8,r8
       je        near ptr M00_L47
       test      rax,rax
       je        near ptr M00_L49
       mov       [rbp-0C8],r8
       mov       [rbp-0B8],rax
       cmp       r8,rax
       je        near ptr M00_L18
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],2
       jle       near ptr M00_L50
       mov       rcx,[rcx+240]
       mov       r10,[rcx+10]
       test      r10,r10
       je        near ptr M00_L50
M00_L21:
       mov       rcx,[r10+10]
       test      rcx,rcx
       jne       short M00_L22
       mov       rcx,19449400110
       mov       rcx,[rcx]
       test      rcx,rcx
       jne       short M00_L22
       mov       rcx,194494000F0
       mov       rcx,[rcx]
       test      rcx,rcx
       je        near ptr M00_L51
M00_L22:
       mov       r10,[rcx]
       mov       r10,[r10+48]
       call      qword ptr [r10+30]
       cmp       [rax],al
       mov       r10,[rbp-0C8]
       lea       rdx,[r10+0C]
       mov       [rbp-0C8],r10
       mov       r8d,[r10+8]
       mov       r11,[rbp-0B8]
       lea       r9,[r11+0C]
       mov       [rbp-0B8],r11
       mov       ecx,[r11+8]
       cmp       r8d,ecx
       je        near ptr M00_L17
       mov       [rbp-0B0],r12
M00_L23:
       mov       [rbp-48],rdx
       mov       [rbp-50],r9
       mov       rax,[rax+20]
       mov       [rsp+20],ecx
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rax
       mov       rax,7FFEFF95B650
       mov       [rbp-80],rax
       lea       rax,[M00_L24]
       mov       [rbp-70],rax
       lea       rax,[rbp-90]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFF5F2F93A0
       call      rax
M00_L24:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFF5F64F778],0
       je        short M00_L25
       call      qword ptr [7FFF5F63D608]; CORINFO_HELP_STOP_FOR_GC
M00_L25:
       mov       rcx,[rbp-88]
       mov       [rsi+8],rcx
       xor       ecx,ecx
       mov       [rbp-48],rcx
       mov       [rbp-50],rcx
       mov       rdi,[rbp-0A0]
       mov       r15,[rbp-98]
M00_L26:
       mov       ecx,eax
       jmp       near ptr M00_L19
M00_L27:
       mov       ecx,[r15+0C]
       mov       [r15+8],ecx
M00_L28:
       mov       dword ptr [rbp-40],1
       jmp       near ptr M00_L56
M00_L29:
       mov       ecx,[r12+0C]
       mov       [r12+8],ecx
       jmp       near ptr M00_L55
M00_L30:
       mov       rcx,r12
       mov       r11,7FFEFF630DE8
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M00_L55
       jmp       near ptr M00_L03
M00_L31:
       call      qword ptr [7FFF000376C0]
       int       3
M00_L32:
       mov       rcx,r12
       mov       r11,7FFEFF630DF0
       call      qword ptr [r11]
       mov       r12,rax
M00_L33:
       mov       [rbp-0B0],r12
       mov       rdx,r12
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       mov       r12,[rbp-0B0]
       jmp       near ptr M00_L04
M00_L34:
       mov       [rbp-0B8],rax
       mov       r15,[rbp-98]
M00_L35:
       mov       rcx,r15
       mov       r11,7FFEFF630E10
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M00_L28
       mov       rcx,r15
       mov       r11,7FFEFF630E18
       call      qword ptr [r11]
       mov       rsi,rax
       mov       rdx,rsi
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       mov       rcx,rdi
       mov       r8,[rbp-0B8]
       mov       [rbp-0D0],rax
       mov       rdx,rax
       mov       r11,7FFEFF630E20
       call      qword ptr [r11]
       test      eax,eax
       jg        short M00_L35
       mov       r12,[rbp-0D0]
       mov       [rbp-0B8],r12
       mov       r12,rsi
       mov       r15,[rbp-98]
       jmp       short M00_L35
M00_L36:
       mov       ecx,2
       call      qword ptr [7FFF00037738]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       rdx,rax
       jmp       near ptr M00_L10
M00_L37:
       call      qword ptr [7FFEFF965DA0]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rcx,rax
       jmp       near ptr M00_L11
M00_L38:
       xor       eax,eax
       mov       [rbp-0B0],r12
       jmp       near ptr M00_L15
M00_L39:
       mov       ecx,1
       mov       [rbp-0B8],rax
       jmp       near ptr M00_L08
M00_L40:
       test      rax,rax
       je        short M00_L41
       mov       ecx,0FFFFFFFF
       mov       [rbp-0B8],rax
       jmp       near ptr M00_L08
M00_L41:
       xor       ecx,ecx
       mov       [rbp-0B8],rax
       jmp       near ptr M00_L08
M00_L42:
       mov       [rbp-0B8],rax
       mov       rcx,r15
       mov       r11,7FFEFF630DF8
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M00_L28
       mov       rcx,r15
       mov       r11,7FFEFF630E00
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       short M00_L44
M00_L43:
       mov       [rbp-0B8],rax
M00_L44:
       mov       [rbp-0C0],rdx
       mov       r14,[rbp-0A8]
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       mov       [rbp-0C8],rax
       mov       rax,[rbp-0B8]
       mov       r15,[rbp-98]
       jmp       short M00_L46
M00_L45:
       mov       [rbp-0C8],r8
M00_L46:
       mov       rcx,rdi
       mov       [rbp-0B8],rax
       mov       r8,rax
       mov       rdx,[rbp-0C8]
       mov       r11,7FFEFF630E08
       call      qword ptr [r11]
       mov       ecx,eax
       mov       [rbp-0B0],r12
       jmp       near ptr M00_L19
M00_L47:
       mov       [rbp-0B8],rax
       test      rax,rax
       jne       short M00_L48
       mov       rax,[rbp-0B8]
       xor       ecx,ecx
       mov       [rbp-0C8],r8
       mov       [rbp-0B8],rax
       mov       [rbp-0B0],r12
       jmp       near ptr M00_L19
M00_L48:
       mov       rax,[rbp-0B8]
       mov       ecx,0FFFFFFFF
       mov       [rbp-0C8],r8
       mov       [rbp-0B8],rax
       mov       [rbp-0B0],r12
       jmp       near ptr M00_L19
M00_L49:
       mov       ecx,1
       mov       [rbp-0C8],r8
       mov       [rbp-0B8],rax
       mov       [rbp-0B0],r12
       jmp       near ptr M00_L19
M00_L50:
       mov       ecx,2
       call      qword ptr [7FFF00037738]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       r10,rax
       jmp       near ptr M00_L21
M00_L51:
       call      qword ptr [7FFEFF965DA0]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rcx,rax
       jmp       near ptr M00_L22
M00_L52:
       xor       eax,eax
       mov       [rbp-0B0],r12
       jmp       near ptr M00_L26
M00_L53:
       mov       ecx,[r15+8]
       call      qword ptr [7FFF000376C0]
       int       3
M00_L54:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L55:
       xor       ecx,ecx
       mov       [rbp-40],ecx
       xor       r12d,r12d
       mov       r15,[rbp-98]
M00_L56:
       cmp       [r15],r13
       jne       near ptr M00_L64
M00_L57:
       cmp       byte ptr [rbp-40],0
       je        near ptr M00_L65
       mov       [rbp-58],r12
       mov       rbx,[rbp+10]
       mov       r15,[rbx+60]
       mov       rdx,[rbp-58]
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [r15+8],rax
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
M00_L58:
       mov       ecx,11
       call      qword ptr [7FFEFF967DF8]
       int       3
M00_L59:
       mov       r13,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord>
       mov       rcx,r13
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       dword ptr [r12+8],0FFFFFFFF
       mov       [r12+0C],r14d
       lea       rcx,[r12+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L02
M00_L60:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdx,19472400E58
       mov       rdx,[rdx]
       mov       rcx,r14
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonRecordOrderBy>b__13_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       call      qword ptr [7FFEFF6E6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,19472400E68
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L61:
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L01
M00_L62:
       mov       rcx,rdi
       mov       r11,7FFEFF630E30
       call      qword ptr [r11]
       mov       r12,rax
       jmp       near ptr M00_L02
M00_L63:
       mov       r11,7FFEFF630DE0
       call      qword ptr [r11]
       mov       r12,rax
       jmp       near ptr M00_L02
M00_L64:
       mov       rcx,r15
       mov       r11,7FFEFF630E28
       call      qword ptr [r11]
       jmp       near ptr M00_L57
M00_L65:
       call      qword ptr [7FFEFFE6FCF0]
       int       3
       sub       rsp,38
       vzeroupper
       cmp       qword ptr [rbp-98],0
       je        short M00_L66
       mov       r13,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord>
       mov       r15,[rbp-98]
       cmp       [r15],r13
       je        short M00_L66
       mov       rcx,r15
       mov       r11,7FFEFF630E28
       call      qword ptr [r11]
M00_L66:
       nop
       add       rsp,38
       ret
; Total bytes of code 2622
```
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonRecordOrderBy>b__13_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       mov       rax,[rdx+30]
       ret
; Total bytes of code 5
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FFF51600D78]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       ecx,ebx
       and       ecx,0FFFFFF
       mov       edx,ecx
       mov       r8d,ebx
       sar       r8d,18
       jne       short M02_L01
       cmp       [rax],ecx
       jle       short M02_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M02_L03
M02_L00:
       add       rsp,20
       pop       rbx
       ret
M02_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M02_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M02_L00
M02_L02:
       cmp       [rax+4],edx
       jle       short M02_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M02_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M02_L03
       jmp       short M02_L00
M02_L03:
       mov       ecx,ebx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax]
; Total bytes of code 130
```
```assembly
; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       push      rsi
       push      rbx
       sub       rsp,28
       call      qword ptr [7FFF515E87D0]
       mov       rbx,rax
       mov       rsi,rbx
       call      qword ptr [7FFF515FFA88]
       mov       rdx,rax
       test      rsi,rsi
       je        short M03_L00
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFF51600C28]
       mov       rax,[rbx]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M03_L00:
       call      qword ptr [7FFF515FE468]
       int       3
; Total bytes of code 61
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M04_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L00:
       call      qword ptr [7FFF0003E568]
       int       3
; Total bytes of code 44
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M05_L00
       ret
M05_L00:
       jmp       qword ptr [7FFEFF6E5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.PersonRecordOrderBy()
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
       xor       eax,eax
       mov       [rbp-58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp-40],rax
       mov       rbx,rcx
       lea       rcx,[rbp-90]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rcx,rsp
       mov       [rbp-78],rcx
       mov       rcx,rbp
       mov       [rbp-68],rcx
       mov       [rbp+10],rbx
       mov       rdi,[rbx+280]
       mov       rcx,1DD81800E68
       mov       r14,[rcx]
       test      r14,r14
       je        near ptr M00_L59
M00_L00:
       mov       rcx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [r15+10],eax
       lea       rcx,[r15+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        near ptr M00_L57
       xor       ecx,ecx
       mov       [r15+20],rcx
       lea       rcx,[r15+28]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,1DD58800A08
       mov       rdx,[rcx]
       lea       rcx,[r15+30]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [r15+48],0
       mov       rcx,[r15+18]
       mov       rax,offset MT_System.Collections.ObjectModel.Collection<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord>
       cmp       [rcx],rax
       jne       near ptr M00_L62
       mov       rdi,[rcx+8]
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord[]
       cmp       [rdi],rcx
       jne       near ptr M00_L61
       mov       r14d,[rdi+8]
       test      r14d,r14d
       jne       near ptr M00_L58
       mov       r13,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord>
       mov       rcx,r13
       test      byte ptr [7FFF0001D3F8],1
       je        near ptr M00_L60
M00_L01:
       mov       rcx,1DD81800E98
       mov       r12,[rcx]
M00_L02:
       mov       [rbp-98],r12
       mov       r13,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord>
       cmp       [r12],r13
       jne       near ptr M00_L30
       mov       ecx,[r12+8]
       inc       ecx
       cmp       ecx,[r12+0C]
       jae       near ptr M00_L29
       mov       [r12+8],ecx
M00_L03:
       mov       rdi,[r15+30]
       mov       [rbp-0A0],rdi
       mov       r14,[r15+28]
       mov       [rbp-0A8],r14
       cmp       [r12],r13
       jne       near ptr M00_L32
       mov       ecx,[r12+8]
       cmp       ecx,[r12+0C]
       jae       near ptr M00_L31
       mov       rax,[r12+10]
       cmp       ecx,[rax+8]
       jae       near ptr M00_L53
       mov       r12,[rax+rcx*8+10]
       mov       rcx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonRecordOrderBy>b__13_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       cmp       [r14+18],rcx
       jne       near ptr M00_L33
       mov       rax,[r12+30]
M00_L04:
       cmp       byte ptr [r15+48],0
       jne       near ptr M00_L34
       test      r14,r14
       je        near ptr M00_L19
       test      rdi,rdi
       je        near ptr M00_L19
       mov       r15,[rbp-98]
       cmp       [r15],r13
       jne       near ptr M00_L19
       mov       rcx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonRecordOrderBy>b__13_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       cmp       [r14+18],rcx
       jne       near ptr M00_L19
       mov       rcx,offset MT_System.Collections.Generic.GenericComparer<System.String>
       cmp       [rdi],rcx
       jne       near ptr M00_L19
       jmp       short M00_L08
M00_L05:
       mov       rax,r14
       mov       rdi,[rbp-0C0]
       mov       [rbp-0B0],rdi
       mov       r12,[rbp-0B0]
       jmp       short M00_L08
M00_L06:
       xor       ecx,ecx
M00_L07:
       test      ecx,ecx
       mov       rax,[rbp-0B8]
       jge       short M00_L05
M00_L08:
       mov       r15,[rbp-98]
       mov       edx,[r15+8]
       inc       edx
       cmp       edx,[r15+0C]
       jae       near ptr M00_L27
       mov       [r15+8],edx
       mov       r8d,[r15+8]
       cmp       r8d,[r15+0C]
       jae       near ptr M00_L52
       mov       r14,[r15+10]
       cmp       r8d,[r14+8]
       jae       near ptr M00_L53
       mov       ecx,r8d
       mov       rdi,[r14+rcx*8+10]
       mov       [rbp-0C0],rdi
       mov       r14,[rdi+30]
       test      r14,r14
       je        near ptr M00_L40
       test      rax,rax
       je        near ptr M00_L39
       mov       [rbp-0B8],rax
       cmp       r14,rax
       je        short M00_L06
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],2
       jle       near ptr M00_L36
       mov       rcx,[rcx+240]
       mov       rdx,[rcx+10]
       test      rdx,rdx
       je        near ptr M00_L36
M00_L09:
       mov       rcx,[rdx+10]
       test      rcx,rcx
       jne       short M00_L10
       mov       rcx,1DD58800110
       mov       rcx,[rcx]
       test      rcx,rcx
       jne       short M00_L10
       mov       rcx,1DD588000F0
       mov       rcx,[rcx]
       test      rcx,rcx
       je        near ptr M00_L37
M00_L10:
       mov       rdx,[rcx]
       mov       rdx,[rdx+48]
       call      qword ptr [rdx+30]
       cmp       [rax],al
       lea       rdx,[r14+0C]
       mov       [rbp-0C8],r14
       mov       r8d,[r14+8]
       mov       r10,[rbp-0B8]
       lea       r9,[r10+0C]
       mov       [rbp-0B8],r10
       mov       r11d,[r10+8]
       cmp       r8d,r11d
       je        near ptr M00_L15
       mov       [rbp-0B0],r12
M00_L11:
       mov       [rbp-48],rdx
       mov       [rbp-50],r9
       mov       rcx,[rax+20]
       mov       [rsp+20],r11d
       xor       eax,eax
       mov       [rsp+28],eax
       mov       rax,7FFEFF97B650
       mov       [rbp-80],rax
       lea       rax,[M00_L12]
       mov       [rbp-70],rax
       lea       rax,[rbp-90]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFF5F2F93A0
       call      rax
M00_L12:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFF5F64F778],0
       je        short M00_L13
       call      qword ptr [7FFF5F63D608]; CORINFO_HELP_STOP_FOR_GC
M00_L13:
       mov       rcx,[rbp-88]
       mov       [rsi+8],rcx
       xor       ecx,ecx
       mov       [rbp-48],rcx
       mov       [rbp-50],rcx
M00_L14:
       mov       ecx,eax
       mov       r12,[rbp-0B0]
       mov       r14,[rbp-0C8]
       jmp       near ptr M00_L07
M00_L15:
       cmp       rdx,r9
       je        near ptr M00_L38
       mov       [rbp-0B0],r12
       jmp       near ptr M00_L11
M00_L16:
       cmp       rdx,r9
       je        near ptr M00_L51
       mov       [rbp-0B0],r12
       jmp       near ptr M00_L22
M00_L17:
       xor       ecx,ecx
       mov       [rbp-0B0],r12
M00_L18:
       test      ecx,ecx
       mov       rax,[rbp-0B8]
       mov       r12,[rbp-0B0]
       jge       near ptr M00_L26
       mov       r14,[rbp-0A8]
M00_L19:
       mov       r15,[rbp-98]
       cmp       [r15],r13
       jne       near ptr M00_L41
       mov       edx,[r15+8]
       inc       edx
       cmp       edx,[r15+0C]
       jae       near ptr M00_L27
       mov       [r15+8],edx
       mov       ecx,[r15+8]
       cmp       ecx,[r15+0C]
       jae       near ptr M00_L52
       mov       rcx,[r15+10]
       mov       r8d,[r15+8]
       cmp       r8d,[rcx+8]
       jae       near ptr M00_L53
       mov       edx,r8d
       mov       rcx,[rcx+rdx*8+10]
       mov       rdx,rcx
       mov       rcx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonRecordOrderBy>b__13_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       cmp       [r14+18],rcx
       jne       near ptr M00_L42
       mov       r15,[rbp-98]
       mov       [rbp-0C0],rdx
       mov       rcx,[rdx+30]
       mov       r8,rcx
       mov       rcx,offset MT_System.Collections.Generic.GenericComparer<System.String>
       cmp       [rdi],rcx
       mov       rdi,[rbp-0A0]
       jne       near ptr M00_L44
       test      r8,r8
       je        near ptr M00_L46
       test      rax,rax
       je        near ptr M00_L48
       mov       [rbp-0C8],r8
       mov       [rbp-0B8],rax
       cmp       r8,rax
       je        near ptr M00_L17
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],2
       jle       near ptr M00_L49
       mov       rcx,[rcx+240]
       mov       r10,[rcx+10]
       test      r10,r10
       je        near ptr M00_L49
M00_L20:
       mov       rcx,[r10+10]
       test      rcx,rcx
       jne       short M00_L21
       mov       rcx,1DD58800110
       mov       rcx,[rcx]
       test      rcx,rcx
       jne       short M00_L21
       mov       rcx,1DD588000F0
       mov       rcx,[rcx]
       test      rcx,rcx
       je        near ptr M00_L50
M00_L21:
       mov       r10,[rcx]
       mov       r10,[r10+48]
       call      qword ptr [r10+30]
       cmp       [rax],al
       mov       r10,[rbp-0C8]
       lea       rdx,[r10+0C]
       mov       [rbp-0C8],r10
       mov       r8d,[r10+8]
       mov       r11,[rbp-0B8]
       lea       r9,[r11+0C]
       mov       [rbp-0B8],r11
       mov       ecx,[r11+8]
       cmp       r8d,ecx
       je        near ptr M00_L16
       mov       [rbp-0B0],r12
M00_L22:
       mov       [rbp-48],rdx
       mov       [rbp-50],r9
       mov       rax,[rax+20]
       mov       [rsp+20],ecx
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rax
       mov       rax,7FFEFF97B650
       mov       [rbp-80],rax
       lea       rax,[M00_L23]
       mov       [rbp-70],rax
       lea       rax,[rbp-90]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFF5F2F93A0
       call      rax
M00_L23:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFF5F64F778],0
       je        short M00_L24
       call      qword ptr [7FFF5F63D608]; CORINFO_HELP_STOP_FOR_GC
M00_L24:
       mov       rcx,[rbp-88]
       mov       [rsi+8],rcx
       xor       ecx,ecx
       mov       [rbp-48],rcx
       mov       [rbp-50],rcx
       mov       rdi,[rbp-0A0]
       mov       r15,[rbp-98]
M00_L25:
       mov       ecx,eax
       jmp       near ptr M00_L18
M00_L26:
       mov       r10,[rbp-0C8]
       mov       r11,r10
       mov       rdx,[rbp-0C0]
       mov       r12,rdx
       mov       rax,r11
       mov       r14,[rbp-0A8]
       jmp       near ptr M00_L19
M00_L27:
       mov       ecx,[r15+0C]
       mov       [r15+8],ecx
M00_L28:
       mov       dword ptr [rbp-40],1
       jmp       near ptr M00_L55
M00_L29:
       mov       ecx,[r12+0C]
       mov       [r12+8],ecx
       jmp       near ptr M00_L54
M00_L30:
       mov       rcx,r12
       mov       r11,7FFEFF650DE8
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M00_L54
       jmp       near ptr M00_L03
M00_L31:
       call      qword ptr [7FFF000576C0]
       int       3
M00_L32:
       mov       rcx,r12
       mov       r11,7FFEFF650DF0
       call      qword ptr [r11]
       mov       r12,rax
M00_L33:
       mov       [rbp-0B0],r12
       mov       rdx,r12
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       mov       r12,[rbp-0B0]
       jmp       near ptr M00_L04
M00_L34:
       mov       [rbp-0B8],rax
       mov       r15,[rbp-98]
M00_L35:
       mov       rcx,r15
       mov       r11,7FFEFF650E10
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M00_L28
       mov       rcx,r15
       mov       r11,7FFEFF650E18
       call      qword ptr [r11]
       mov       rsi,rax
       mov       rdx,rsi
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       mov       rcx,rdi
       mov       r8,[rbp-0B8]
       mov       [rbp-0D0],rax
       mov       rdx,rax
       mov       r11,7FFEFF650E20
       call      qword ptr [r11]
       test      eax,eax
       jg        short M00_L35
       mov       r12,[rbp-0D0]
       mov       [rbp-0B8],r12
       mov       r12,rsi
       mov       r15,[rbp-98]
       jmp       short M00_L35
M00_L36:
       mov       ecx,2
       call      qword ptr [7FFF00057738]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       rdx,rax
       jmp       near ptr M00_L09
M00_L37:
       call      qword ptr [7FFEFF985DA0]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rcx,rax
       jmp       near ptr M00_L10
M00_L38:
       xor       eax,eax
       mov       [rbp-0B0],r12
       jmp       near ptr M00_L14
M00_L39:
       mov       ecx,1
       mov       [rbp-0B8],rax
       jmp       near ptr M00_L07
M00_L40:
       test      rax,rax
       je        near ptr M00_L05
       mov       ecx,0FFFFFFFF
       mov       [rbp-0B8],rax
       jmp       near ptr M00_L07
M00_L41:
       mov       [rbp-0B8],rax
       mov       rcx,r15
       mov       r11,7FFEFF650DF8
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M00_L28
       mov       rcx,r15
       mov       r11,7FFEFF650E00
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       short M00_L43
M00_L42:
       mov       [rbp-0B8],rax
M00_L43:
       mov       [rbp-0C0],rdx
       mov       r14,[rbp-0A8]
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       mov       [rbp-0C8],rax
       mov       rax,[rbp-0B8]
       mov       r15,[rbp-98]
       jmp       short M00_L45
M00_L44:
       mov       [rbp-0C8],r8
M00_L45:
       mov       rcx,rdi
       mov       [rbp-0B8],rax
       mov       r8,rax
       mov       rdx,[rbp-0C8]
       mov       r11,7FFEFF650E08
       call      qword ptr [r11]
       mov       ecx,eax
       mov       [rbp-0B0],r12
       jmp       near ptr M00_L18
M00_L46:
       mov       [rbp-0B8],rax
       test      rax,rax
       jne       short M00_L47
       mov       [rbp-0C8],r8
       jmp       near ptr M00_L26
M00_L47:
       mov       rax,[rbp-0B8]
       mov       ecx,0FFFFFFFF
       mov       [rbp-0C8],r8
       mov       [rbp-0B8],rax
       mov       [rbp-0B0],r12
       jmp       near ptr M00_L18
M00_L48:
       mov       ecx,1
       mov       [rbp-0C8],r8
       mov       [rbp-0B8],rax
       mov       [rbp-0B0],r12
       jmp       near ptr M00_L18
M00_L49:
       mov       ecx,2
       call      qword ptr [7FFF00057738]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       r10,rax
       jmp       near ptr M00_L20
M00_L50:
       call      qword ptr [7FFEFF985DA0]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rcx,rax
       jmp       near ptr M00_L21
M00_L51:
       xor       eax,eax
       mov       [rbp-0B0],r12
       jmp       near ptr M00_L25
M00_L52:
       mov       ecx,[r15+8]
       call      qword ptr [7FFF000576C0]
       int       3
M00_L53:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L54:
       xor       ecx,ecx
       mov       [rbp-40],ecx
       xor       r12d,r12d
       mov       r15,[rbp-98]
M00_L55:
       cmp       [r15],r13
       jne       near ptr M00_L63
M00_L56:
       cmp       byte ptr [rbp-40],0
       je        near ptr M00_L64
       mov       [rbp-58],r12
       mov       rbx,[rbp+10]
       mov       r15,[rbx+60]
       mov       rdx,[rbp-58]
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [r15+8],rax
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
M00_L57:
       mov       ecx,11
       call      qword ptr [7FFEFF987DF8]
       int       3
M00_L58:
       mov       r13,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord>
       mov       rcx,r13
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       dword ptr [r12+8],0FFFFFFFF
       mov       [r12+0C],r14d
       lea       rcx,[r12+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L02
M00_L59:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdx,1DD81800E58
       mov       rdx,[rdx]
       mov       rcx,r14
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonRecordOrderBy>b__13_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       call      qword ptr [7FFEFF706BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1DD81800E68
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L60:
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L01
M00_L61:
       mov       rcx,rdi
       mov       r11,7FFEFF650E30
       call      qword ptr [r11]
       mov       r12,rax
       jmp       near ptr M00_L02
M00_L62:
       mov       r11,7FFEFF650DE0
       call      qword ptr [r11]
       mov       r12,rax
       jmp       near ptr M00_L02
M00_L63:
       mov       rcx,r15
       mov       r11,7FFEFF650E28
       call      qword ptr [r11]
       jmp       near ptr M00_L56
M00_L64:
       call      qword ptr [7FFEFFE8FD38]
       int       3
       sub       rsp,38
       vzeroupper
       cmp       qword ptr [rbp-98],0
       je        short M00_L65
       mov       r13,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord>
       mov       r15,[rbp-98]
       cmp       [r15],r13
       je        short M00_L65
       mov       rcx,r15
       mov       r11,7FFEFF650E28
       call      qword ptr [r11]
M00_L65:
       nop
       add       rsp,38
       ret
; Total bytes of code 2603
```
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonRecordOrderBy>b__13_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       mov       rax,[rdx+30]
       ret
; Total bytes of code 5
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FFF51600D78]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       ecx,ebx
       and       ecx,0FFFFFF
       mov       edx,ecx
       mov       r8d,ebx
       sar       r8d,18
       jne       short M02_L01
       cmp       [rax],ecx
       jle       short M02_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M02_L03
M02_L00:
       add       rsp,20
       pop       rbx
       ret
M02_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M02_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M02_L00
M02_L02:
       cmp       [rax+4],edx
       jle       short M02_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M02_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M02_L03
       jmp       short M02_L00
M02_L03:
       mov       ecx,ebx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax]
; Total bytes of code 130
```
```assembly
; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       push      rsi
       push      rbx
       sub       rsp,28
       call      qword ptr [7FFF515E87D0]
       mov       rbx,rax
       mov       rsi,rbx
       call      qword ptr [7FFF515FFA88]
       mov       rdx,rax
       test      rsi,rsi
       je        short M03_L00
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFF51600C28]
       mov       rax,[rbx]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M03_L00:
       call      qword ptr [7FFF515FE468]
       int       3
; Total bytes of code 61
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M04_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L00:
       call      qword ptr [7FFF0005E5F8]
       int       3
; Total bytes of code 44
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M05_L00
       ret
M05_L00:
       jmp       qword ptr [7FFEFF705C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.PersonRecordOrderBy()
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
       xor       eax,eax
       mov       [rbp-58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp-40],rax
       mov       rbx,rcx
       lea       rcx,[rbp-90]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rcx,rsp
       mov       [rbp-78],rcx
       mov       rcx,rbp
       mov       [rbp-68],rcx
       mov       [rbp+10],rbx
       mov       rdi,[rbx+280]
       mov       rcx,1EB4E800E68
       mov       r14,[rcx]
       test      r14,r14
       je        near ptr M00_L60
M00_L00:
       mov       rcx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [r15+10],eax
       lea       rcx,[r15+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        near ptr M00_L58
       xor       ecx,ecx
       mov       [r15+20],rcx
       lea       rcx,[r15+28]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,1EB21800A08
       mov       rdx,[rcx]
       lea       rcx,[r15+30]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [r15+48],0
       mov       rcx,[r15+18]
       mov       rax,offset MT_System.Collections.ObjectModel.Collection<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord>
       cmp       [rcx],rax
       jne       near ptr M00_L63
       mov       rdi,[rcx+8]
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord[]
       cmp       [rdi],rcx
       jne       near ptr M00_L62
       mov       r14d,[rdi+8]
       test      r14d,r14d
       jne       near ptr M00_L59
       mov       r13,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord>
       mov       rcx,r13
       test      byte ptr [7FFF0003D3F8],1
       je        near ptr M00_L61
M00_L01:
       mov       rcx,1EB4E800E98
       mov       r12,[rcx]
M00_L02:
       mov       [rbp-98],r12
       mov       r13,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord>
       cmp       [r12],r13
       jne       near ptr M00_L30
       mov       ecx,[r12+8]
       inc       ecx
       cmp       ecx,[r12+0C]
       jae       near ptr M00_L29
       mov       [r12+8],ecx
M00_L03:
       mov       rdi,[r15+30]
       mov       [rbp-0A0],rdi
       mov       r14,[r15+28]
       mov       [rbp-0A8],r14
       cmp       [r12],r13
       jne       near ptr M00_L32
       mov       ecx,[r12+8]
       cmp       ecx,[r12+0C]
       jae       near ptr M00_L31
       mov       rax,[r12+10]
       cmp       ecx,[rax+8]
       jae       near ptr M00_L54
       mov       r12,[rax+rcx*8+10]
       mov       rcx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonRecordOrderBy>b__13_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       cmp       [r14+18],rcx
       jne       near ptr M00_L33
       mov       rax,[r12+30]
M00_L04:
       cmp       byte ptr [r15+48],0
       jne       near ptr M00_L34
       test      r14,r14
       je        near ptr M00_L20
       test      rdi,rdi
       je        near ptr M00_L20
       mov       r15,[rbp-98]
       cmp       [r15],r13
       jne       near ptr M00_L20
       mov       rcx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonRecordOrderBy>b__13_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       cmp       [r14+18],rcx
       jne       near ptr M00_L20
       mov       rcx,offset MT_System.Collections.Generic.GenericComparer<System.String>
       cmp       [rdi],rcx
       jne       near ptr M00_L20
       jmp       short M00_L08
M00_L05:
       mov       rdi,[rbp-0C0]
       mov       rax,r14
       mov       [rbp-0B0],rdi
       mov       r12,[rbp-0B0]
       jmp       short M00_L08
M00_L06:
       xor       ecx,ecx
M00_L07:
       test      ecx,ecx
       mov       rax,[rbp-0B8]
       mov       r15,[rbp-98]
       jge       short M00_L05
M00_L08:
       mov       edx,[r15+8]
       inc       edx
       cmp       edx,[r15+0C]
       jae       near ptr M00_L27
       mov       [r15+8],edx
       mov       r8d,[r15+8]
       cmp       r8d,[r15+0C]
       jae       near ptr M00_L53
       mov       r14,[r15+10]
       cmp       r8d,[r14+8]
       jae       near ptr M00_L54
       mov       ecx,r8d
       mov       rdi,[r14+rcx*8+10]
       mov       [rbp-0C0],rdi
       mov       r14,[rdi+30]
       test      r14,r14
       je        near ptr M00_L40
       test      rax,rax
       je        near ptr M00_L39
       mov       [rbp-0B8],rax
       cmp       r14,rax
       je        short M00_L06
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],2
       jle       near ptr M00_L36
       mov       rcx,[rcx+240]
       mov       rdx,[rcx+10]
       test      rdx,rdx
       je        near ptr M00_L36
M00_L09:
       mov       rcx,[rdx+10]
       test      rcx,rcx
       jne       short M00_L10
       mov       rcx,1EB21800110
       mov       rcx,[rcx]
       test      rcx,rcx
       jne       short M00_L10
       mov       rcx,1EB218000F0
       mov       rcx,[rcx]
       test      rcx,rcx
       je        near ptr M00_L37
M00_L10:
       mov       rdx,[rcx]
       mov       rdx,[rdx+48]
       call      qword ptr [rdx+30]
       cmp       [rax],al
       lea       rdx,[r14+0C]
       mov       [rbp-0C8],r14
       mov       r8d,[r14+8]
       mov       r10,[rbp-0B8]
       lea       r9,[r10+0C]
       mov       [rbp-0B8],r10
       mov       r11d,[r10+8]
       cmp       r8d,r11d
       je        near ptr M00_L15
       mov       [rbp-0B0],r12
M00_L11:
       mov       [rbp-48],rdx
       mov       [rbp-50],r9
       mov       rcx,[rax+20]
       mov       [rsp+20],r11d
       xor       eax,eax
       mov       [rsp+28],eax
       mov       rax,7FFEFF99B650
       mov       [rbp-80],rax
       lea       rax,[M00_L12]
       mov       [rbp-70],rax
       lea       rax,[rbp-90]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFF5F2F93A0
       call      rax
M00_L12:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFF5F64F778],0
       je        short M00_L13
       call      qword ptr [7FFF5F63D608]; CORINFO_HELP_STOP_FOR_GC
M00_L13:
       mov       rcx,[rbp-88]
       mov       [rsi+8],rcx
       xor       ecx,ecx
       mov       [rbp-48],rcx
       mov       [rbp-50],rcx
M00_L14:
       mov       ecx,eax
       mov       r12,[rbp-0B0]
       mov       r14,[rbp-0C8]
       jmp       near ptr M00_L07
M00_L15:
       cmp       rdx,r9
       je        near ptr M00_L38
       mov       [rbp-0B0],r12
       jmp       near ptr M00_L11
M00_L16:
       mov       rdx,[rbp-0C0]
       mov       r8,[rbp-0C8]
       mov       rax,r8
       mov       r12,rdx
       jmp       short M00_L20
M00_L17:
       cmp       rdx,r9
       je        near ptr M00_L52
       mov       [rbp-0B0],r12
       jmp       near ptr M00_L23
M00_L18:
       xor       ecx,ecx
M00_L19:
       test      ecx,ecx
       mov       rax,[rbp-0B8]
       mov       r14,[rbp-0A8]
       jge       short M00_L16
M00_L20:
       mov       r15,[rbp-98]
       cmp       [r15],r13
       jne       near ptr M00_L42
       mov       edx,[r15+8]
       inc       edx
       cmp       edx,[r15+0C]
       jae       near ptr M00_L27
       mov       [r15+8],edx
       mov       ecx,[r15+8]
       cmp       ecx,[r15+0C]
       jae       near ptr M00_L53
       mov       rcx,[r15+10]
       mov       r8d,[r15+8]
       cmp       r8d,[rcx+8]
       jae       near ptr M00_L54
       mov       edx,r8d
       mov       rcx,[rcx+rdx*8+10]
       mov       rdx,rcx
       mov       rcx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonRecordOrderBy>b__13_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       cmp       [r14+18],rcx
       jne       near ptr M00_L43
       mov       r15,[rbp-98]
       mov       [rbp-0C0],rdx
       mov       rcx,[rdx+30]
       mov       r8,rcx
       mov       rcx,offset MT_System.Collections.Generic.GenericComparer<System.String>
       cmp       [rdi],rcx
       mov       rdi,[rbp-0A0]
       jne       near ptr M00_L45
       test      r8,r8
       je        near ptr M00_L47
       test      rax,rax
       je        near ptr M00_L49
       mov       [rbp-0C8],r8
       mov       [rbp-0B8],rax
       cmp       r8,rax
       je        near ptr M00_L18
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],2
       jle       near ptr M00_L50
       mov       rcx,[rcx+240]
       mov       r10,[rcx+10]
       test      r10,r10
       je        near ptr M00_L50
M00_L21:
       mov       rcx,[r10+10]
       test      rcx,rcx
       jne       short M00_L22
       mov       rcx,1EB21800110
       mov       rcx,[rcx]
       test      rcx,rcx
       jne       short M00_L22
       mov       rcx,1EB218000F0
       mov       rcx,[rcx]
       test      rcx,rcx
       je        near ptr M00_L51
M00_L22:
       mov       r10,[rcx]
       mov       r10,[r10+48]
       call      qword ptr [r10+30]
       cmp       [rax],al
       mov       r10,[rbp-0C8]
       lea       rdx,[r10+0C]
       mov       [rbp-0C8],r10
       mov       r8d,[r10+8]
       mov       r11,[rbp-0B8]
       lea       r9,[r11+0C]
       mov       [rbp-0B8],r11
       mov       ecx,[r11+8]
       cmp       r8d,ecx
       je        near ptr M00_L17
       mov       [rbp-0B0],r12
M00_L23:
       mov       [rbp-48],rdx
       mov       [rbp-50],r9
       mov       rax,[rax+20]
       mov       [rsp+20],ecx
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rax
       mov       rax,7FFEFF99B650
       mov       [rbp-80],rax
       lea       rax,[M00_L24]
       mov       [rbp-70],rax
       lea       rax,[rbp-90]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFF5F2F93A0
       call      rax
M00_L24:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFF5F64F778],0
       je        short M00_L25
       call      qword ptr [7FFF5F63D608]; CORINFO_HELP_STOP_FOR_GC
M00_L25:
       mov       rcx,[rbp-88]
       mov       [rsi+8],rcx
       xor       ecx,ecx
       mov       [rbp-48],rcx
       mov       [rbp-50],rcx
       mov       rdi,[rbp-0A0]
       mov       r15,[rbp-98]
M00_L26:
       mov       ecx,eax
       mov       r12,[rbp-0B0]
       jmp       near ptr M00_L19
M00_L27:
       mov       ecx,[r15+0C]
       mov       [r15+8],ecx
M00_L28:
       mov       dword ptr [rbp-40],1
       jmp       near ptr M00_L56
M00_L29:
       mov       ecx,[r12+0C]
       mov       [r12+8],ecx
       jmp       near ptr M00_L55
M00_L30:
       mov       rcx,r12
       mov       r11,7FFEFF670DE8
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M00_L55
       jmp       near ptr M00_L03
M00_L31:
       call      qword ptr [7FFF00077708]
       int       3
M00_L32:
       mov       rcx,r12
       mov       r11,7FFEFF670DF0
       call      qword ptr [r11]
       mov       r12,rax
M00_L33:
       mov       [rbp-0B0],r12
       mov       rdx,r12
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       mov       r12,[rbp-0B0]
       jmp       near ptr M00_L04
M00_L34:
       mov       [rbp-0B8],rax
       mov       r15,[rbp-98]
M00_L35:
       mov       rcx,r15
       mov       r11,7FFEFF670E10
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M00_L28
       mov       rcx,r15
       mov       r11,7FFEFF670E18
       call      qword ptr [r11]
       mov       rsi,rax
       mov       rdx,rsi
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       mov       rcx,rdi
       mov       r8,[rbp-0B8]
       mov       [rbp-0D0],rax
       mov       rdx,rax
       mov       r11,7FFEFF670E20
       call      qword ptr [r11]
       test      eax,eax
       jg        short M00_L35
       mov       r12,[rbp-0D0]
       mov       [rbp-0B8],r12
       mov       r12,rsi
       mov       r15,[rbp-98]
       jmp       short M00_L35
M00_L36:
       mov       ecx,2
       call      qword ptr [7FFF00077780]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       rdx,rax
       jmp       near ptr M00_L09
M00_L37:
       call      qword ptr [7FFEFF9A5DA0]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rcx,rax
       jmp       near ptr M00_L10
M00_L38:
       xor       eax,eax
       mov       [rbp-0B0],r12
       jmp       near ptr M00_L14
M00_L39:
       mov       ecx,1
       mov       [rbp-0B8],rax
       jmp       near ptr M00_L07
M00_L40:
       test      rax,rax
       je        short M00_L41
       mov       ecx,0FFFFFFFF
       mov       [rbp-0B8],rax
       jmp       near ptr M00_L07
M00_L41:
       xor       ecx,ecx
       mov       [rbp-0B8],rax
       jmp       near ptr M00_L07
M00_L42:
       mov       [rbp-0B8],rax
       mov       rcx,r15
       mov       r11,7FFEFF670DF8
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M00_L28
       mov       rcx,r15
       mov       r11,7FFEFF670E00
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       short M00_L44
M00_L43:
       mov       [rbp-0B8],rax
M00_L44:
       mov       [rbp-0C0],rdx
       mov       r14,[rbp-0A8]
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       mov       [rbp-0C8],rax
       mov       rax,[rbp-0B8]
       mov       r15,[rbp-98]
       jmp       short M00_L46
M00_L45:
       mov       [rbp-0C8],r8
M00_L46:
       mov       rcx,rdi
       mov       [rbp-0B8],rax
       mov       r8,rax
       mov       rdx,[rbp-0C8]
       mov       r11,7FFEFF670E08
       call      qword ptr [r11]
       mov       ecx,eax
       jmp       near ptr M00_L19
M00_L47:
       mov       [rbp-0B8],rax
       test      rax,rax
       jne       short M00_L48
       mov       rax,[rbp-0B8]
       xor       ecx,ecx
       mov       [rbp-0C8],r8
       mov       [rbp-0B8],rax
       jmp       near ptr M00_L19
M00_L48:
       mov       rax,[rbp-0B8]
       mov       ecx,0FFFFFFFF
       mov       [rbp-0C8],r8
       mov       [rbp-0B8],rax
       jmp       near ptr M00_L19
M00_L49:
       mov       ecx,1
       mov       [rbp-0C8],r8
       mov       [rbp-0B8],rax
       jmp       near ptr M00_L19
M00_L50:
       mov       ecx,2
       call      qword ptr [7FFF00077780]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       r10,rax
       jmp       near ptr M00_L21
M00_L51:
       call      qword ptr [7FFEFF9A5DA0]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rcx,rax
       jmp       near ptr M00_L22
M00_L52:
       xor       eax,eax
       mov       [rbp-0B0],r12
       jmp       near ptr M00_L26
M00_L53:
       mov       ecx,[r15+8]
       call      qword ptr [7FFF00077708]
       int       3
M00_L54:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L55:
       xor       ecx,ecx
       mov       [rbp-40],ecx
       xor       r12d,r12d
       mov       r15,[rbp-98]
M00_L56:
       cmp       [r15],r13
       jne       near ptr M00_L64
M00_L57:
       cmp       byte ptr [rbp-40],0
       je        near ptr M00_L65
       mov       [rbp-58],r12
       mov       rbx,[rbp+10]
       mov       r15,[rbx+60]
       mov       rdx,[rbp-58]
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [r15+8],rax
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
M00_L58:
       mov       ecx,11
       call      qword ptr [7FFEFF9A7DF8]
       int       3
M00_L59:
       mov       r13,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord>
       mov       rcx,r13
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       dword ptr [r12+8],0FFFFFFFF
       mov       [r12+0C],r14d
       lea       rcx,[r12+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L02
M00_L60:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdx,1EB4E800E58
       mov       rdx,[rdx]
       mov       rcx,r14
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonRecordOrderBy>b__13_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       call      qword ptr [7FFEFF726BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1EB4E800E68
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L61:
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L01
M00_L62:
       mov       rcx,rdi
       mov       r11,7FFEFF670E30
       call      qword ptr [r11]
       mov       r12,rax
       jmp       near ptr M00_L02
M00_L63:
       mov       r11,7FFEFF670DE0
       call      qword ptr [r11]
       mov       r12,rax
       jmp       near ptr M00_L02
M00_L64:
       mov       rcx,r15
       mov       r11,7FFEFF670E28
       call      qword ptr [r11]
       jmp       near ptr M00_L57
M00_L65:
       call      qword ptr [7FFEFFEAFD38]
       int       3
       sub       rsp,38
       vzeroupper
       cmp       qword ptr [rbp-98],0
       je        short M00_L66
       mov       r13,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord>
       mov       r15,[rbp-98]
       cmp       [r15],r13
       je        short M00_L66
       mov       rcx,r15
       mov       r11,7FFEFF670E28
       call      qword ptr [r11]
M00_L66:
       nop
       add       rsp,38
       ret
; Total bytes of code 2584
```
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonRecordOrderBy>b__13_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       mov       rax,[rdx+30]
       ret
; Total bytes of code 5
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FFF51600D78]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       ecx,ebx
       and       ecx,0FFFFFF
       mov       edx,ecx
       mov       r8d,ebx
       sar       r8d,18
       jne       short M02_L01
       cmp       [rax],ecx
       jle       short M02_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M02_L03
M02_L00:
       add       rsp,20
       pop       rbx
       ret
M02_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M02_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M02_L00
M02_L02:
       cmp       [rax+4],edx
       jle       short M02_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M02_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M02_L03
       jmp       short M02_L00
M02_L03:
       mov       ecx,ebx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax]
; Total bytes of code 130
```
```assembly
; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       push      rsi
       push      rbx
       sub       rsp,28
       call      qword ptr [7FFF515E87D0]
       mov       rbx,rax
       mov       rsi,rbx
       call      qword ptr [7FFF515FFA88]
       mov       rdx,rax
       test      rsi,rsi
       je        short M03_L00
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFF51600C28]
       mov       rax,[rbx]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M03_L00:
       call      qword ptr [7FFF515FE468]
       int       3
; Total bytes of code 61
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M04_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L00:
       call      qword ptr [7FFF0007E640]
       int       3
; Total bytes of code 44
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M05_L00
       ret
M05_L00:
       jmp       qword ptr [7FFEFF725C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.PersonRecordOrderBy()
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
       xor       eax,eax
       mov       [rbp-58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp-40],rax
       mov       rbx,rcx
       lea       rcx,[rbp-90]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rcx,rsp
       mov       [rbp-78],rcx
       mov       rcx,rbp
       mov       [rbp-68],rcx
       mov       [rbp+10],rbx
       mov       rdi,[rbx+280]
       mov       rcx,1A741400E68
       mov       r14,[rcx]
       test      r14,r14
       je        near ptr M00_L60
M00_L00:
       mov       rcx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [r15+10],eax
       lea       rcx,[r15+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        near ptr M00_L58
       xor       ecx,ecx
       mov       [r15+20],rcx
       lea       rcx,[r15+28]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,1A714400A08
       mov       rdx,[rcx]
       lea       rcx,[r15+30]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [r15+48],0
       mov       rcx,[r15+18]
       mov       rax,offset MT_System.Collections.ObjectModel.Collection<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord>
       cmp       [rcx],rax
       jne       near ptr M00_L63
       mov       rdi,[rcx+8]
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord[]
       cmp       [rdi],rcx
       jne       near ptr M00_L62
       mov       r14d,[rdi+8]
       test      r14d,r14d
       jne       near ptr M00_L59
       mov       r13,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord>
       mov       rcx,r13
       test      byte ptr [7FFF0003D3F8],1
       je        near ptr M00_L61
M00_L01:
       mov       rcx,1A741400E98
       mov       r12,[rcx]
M00_L02:
       mov       [rbp-98],r12
       mov       r13,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord>
       cmp       [r12],r13
       jne       near ptr M00_L30
       mov       ecx,[r12+8]
       inc       ecx
       cmp       ecx,[r12+0C]
       jae       near ptr M00_L29
       mov       [r12+8],ecx
M00_L03:
       mov       rdi,[r15+30]
       mov       [rbp-0A0],rdi
       mov       r14,[r15+28]
       mov       [rbp-0A8],r14
       cmp       [r12],r13
       jne       near ptr M00_L32
       mov       ecx,[r12+8]
       cmp       ecx,[r12+0C]
       jae       near ptr M00_L31
       mov       rax,[r12+10]
       cmp       ecx,[rax+8]
       jae       near ptr M00_L54
       mov       r12,[rax+rcx*8+10]
       mov       rcx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonRecordOrderBy>b__13_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       cmp       [r14+18],rcx
       jne       near ptr M00_L33
       mov       rax,[r12+30]
M00_L04:
       cmp       byte ptr [r15+48],0
       jne       near ptr M00_L34
       test      r14,r14
       je        near ptr M00_L19
       test      rdi,rdi
       je        near ptr M00_L19
       mov       r15,[rbp-98]
       cmp       [r15],r13
       jne       near ptr M00_L19
       mov       rcx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonRecordOrderBy>b__13_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       cmp       [r14+18],rcx
       jne       near ptr M00_L19
       mov       rcx,offset MT_System.Collections.Generic.GenericComparer<System.String>
       cmp       [rdi],rcx
       jne       near ptr M00_L19
       jmp       short M00_L08
M00_L05:
       mov       rdi,[rbp-0C0]
       mov       rax,r14
       mov       [rbp-0B0],rdi
       mov       r12,[rbp-0B0]
       jmp       short M00_L08
M00_L06:
       xor       ecx,ecx
M00_L07:
       test      ecx,ecx
       mov       rax,[rbp-0B8]
       mov       r15,[rbp-98]
       jge       short M00_L05
M00_L08:
       mov       edx,[r15+8]
       inc       edx
       cmp       edx,[r15+0C]
       jae       near ptr M00_L27
       mov       [r15+8],edx
       mov       r8d,[r15+8]
       cmp       r8d,[r15+0C]
       jae       near ptr M00_L53
       mov       r14,[r15+10]
       cmp       r8d,[r14+8]
       jae       near ptr M00_L54
       mov       ecx,r8d
       mov       rdi,[r14+rcx*8+10]
       mov       [rbp-0C0],rdi
       mov       r14,[rdi+30]
       test      r14,r14
       je        near ptr M00_L40
       test      rax,rax
       je        near ptr M00_L39
       mov       [rbp-0B8],rax
       cmp       r14,rax
       je        short M00_L06
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+238],2
       jle       near ptr M00_L36
       mov       rcx,[rcx+240]
       mov       rdx,[rcx+10]
       test      rdx,rdx
       je        near ptr M00_L36
M00_L09:
       mov       rcx,[rdx+10]
       test      rcx,rcx
       jne       short M00_L10
       mov       rcx,1A714400110
       mov       rcx,[rcx]
       test      rcx,rcx
       jne       short M00_L10
       mov       rcx,1A7144000F0
       mov       rcx,[rcx]
       test      rcx,rcx
       je        near ptr M00_L37
M00_L10:
       mov       rdx,[rcx]
       mov       rdx,[rdx+48]
       call      qword ptr [rdx+30]
       cmp       [rax],al
       lea       rdx,[r14+0C]
       mov       [rbp-0C8],r14
       mov       r8d,[r14+8]
       mov       r10,[rbp-0B8]
       lea       r9,[r10+0C]
       mov       [rbp-0B8],r10
       mov       r11d,[r10+8]
       cmp       r8d,r11d
       je        near ptr M00_L15
       mov       [rbp-0B0],r12
M00_L11:
       mov       [rbp-48],rdx
       mov       [rbp-50],r9
       mov       rcx,[rax+20]
       mov       [rsp+20],r11d
       xor       eax,eax
       mov       [rsp+28],eax
       mov       rax,7FFEFF99B650
       mov       [rbp-80],rax
       lea       rax,[M00_L12]
       mov       [rbp-70],rax
       lea       rax,[rbp-90]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFF5F2F93A0
       call      rax
M00_L12:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFF5F64F778],0
       je        short M00_L13
       call      qword ptr [7FFF5F63D608]; CORINFO_HELP_STOP_FOR_GC
M00_L13:
       mov       rcx,[rbp-88]
       mov       [rsi+8],rcx
       xor       ecx,ecx
       mov       [rbp-48],rcx
       mov       [rbp-50],rcx
M00_L14:
       mov       ecx,eax
       mov       r12,[rbp-0B0]
       mov       r14,[rbp-0C8]
       jmp       near ptr M00_L07
M00_L15:
       cmp       rdx,r9
       je        near ptr M00_L38
       mov       [rbp-0B0],r12
       jmp       near ptr M00_L11
M00_L16:
       mov       rdx,[rbp-0C0]
       mov       r10,[rbp-0C8]
       mov       r11,r10
       mov       r12,rdx
       mov       rax,r11
       jmp       short M00_L19
M00_L17:
       xor       ecx,ecx
       mov       [rbp-0B0],r12
M00_L18:
       test      ecx,ecx
       mov       rax,[rbp-0B8]
       mov       r12,[rbp-0B0]
       mov       r14,[rbp-0A8]
       jge       short M00_L16
M00_L19:
       mov       r15,[rbp-98]
       cmp       [r15],r13
       jne       near ptr M00_L42
       mov       edx,[r15+8]
       inc       edx
       cmp       edx,[r15+0C]
       jae       near ptr M00_L27
       mov       [r15+8],edx
       mov       ecx,[r15+8]
       cmp       ecx,[r15+0C]
       jae       near ptr M00_L53
       mov       rcx,[r15+10]
       mov       r8d,[r15+8]
       cmp       r8d,[rcx+8]
       jae       near ptr M00_L54
       mov       edx,r8d
       mov       rcx,[rcx+rdx*8+10]
       mov       rdx,rcx
       mov       rcx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonRecordOrderBy>b__13_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       cmp       [r14+18],rcx
       jne       near ptr M00_L43
       mov       r15,[rbp-98]
       mov       [rbp-0C0],rdx
       mov       rcx,[rdx+30]
       mov       r8,rcx
       mov       rcx,offset MT_System.Collections.Generic.GenericComparer<System.String>
       cmp       [rdi],rcx
       mov       rdi,[rbp-0A0]
       jne       near ptr M00_L45
       test      r8,r8
       je        near ptr M00_L47
       test      rax,rax
       je        near ptr M00_L49
       mov       [rbp-0C8],r8
       mov       [rbp-0B8],rax
       cmp       r8,rax
       je        near ptr M00_L17
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+238],2
       jle       near ptr M00_L50
       mov       rcx,[rcx+240]
       mov       r10,[rcx+10]
       test      r10,r10
       je        near ptr M00_L50
M00_L20:
       mov       rcx,[r10+10]
       test      rcx,rcx
       jne       short M00_L21
       mov       rcx,1A714400110
       mov       rcx,[rcx]
       test      rcx,rcx
       jne       short M00_L21
       mov       rcx,1A7144000F0
       mov       rcx,[rcx]
       test      rcx,rcx
       je        near ptr M00_L51
M00_L21:
       mov       r10,[rcx]
       mov       r10,[r10+48]
       call      qword ptr [r10+30]
       cmp       [rax],al
       mov       r10,[rbp-0C8]
       lea       rdx,[r10+0C]
       mov       [rbp-0C8],r10
       mov       r8d,[r10+8]
       mov       r11,[rbp-0B8]
       lea       r9,[r11+0C]
       mov       [rbp-0B8],r11
       mov       ecx,[r11+8]
       cmp       r8d,ecx
       je        near ptr M00_L26
       mov       [rbp-0B0],r12
M00_L22:
       mov       [rbp-48],rdx
       mov       [rbp-50],r9
       mov       rax,[rax+20]
       mov       [rsp+20],ecx
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rax
       mov       rax,7FFEFF99B650
       mov       [rbp-80],rax
       lea       rax,[M00_L23]
       mov       [rbp-70],rax
       lea       rax,[rbp-90]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFF5F2F93A0
       call      rax
M00_L23:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFF5F64F778],0
       je        short M00_L24
       call      qword ptr [7FFF5F63D608]; CORINFO_HELP_STOP_FOR_GC
M00_L24:
       mov       rcx,[rbp-88]
       mov       [rsi+8],rcx
       xor       ecx,ecx
       mov       [rbp-48],rcx
       mov       [rbp-50],rcx
       mov       rdi,[rbp-0A0]
       mov       r15,[rbp-98]
M00_L25:
       mov       ecx,eax
       jmp       near ptr M00_L18
M00_L26:
       cmp       rdx,r9
       je        near ptr M00_L52
       mov       [rbp-0B0],r12
       jmp       near ptr M00_L22
M00_L27:
       mov       ecx,[r15+0C]
       mov       [r15+8],ecx
M00_L28:
       mov       dword ptr [rbp-40],1
       jmp       near ptr M00_L56
M00_L29:
       mov       ecx,[r12+0C]
       mov       [r12+8],ecx
       jmp       near ptr M00_L55
M00_L30:
       mov       rcx,r12
       mov       r11,7FFEFF670DE8
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M00_L55
       jmp       near ptr M00_L03
M00_L31:
       call      qword ptr [7FFF00077540]
       int       3
M00_L32:
       mov       rcx,r12
       mov       r11,7FFEFF670DF0
       call      qword ptr [r11]
       mov       r12,rax
M00_L33:
       mov       [rbp-0B0],r12
       mov       rdx,r12
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       mov       r12,[rbp-0B0]
       jmp       near ptr M00_L04
M00_L34:
       mov       [rbp-0B8],rax
       mov       r15,[rbp-98]
M00_L35:
       mov       rcx,r15
       mov       r11,7FFEFF670E10
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M00_L28
       mov       rcx,r15
       mov       r11,7FFEFF670E18
       call      qword ptr [r11]
       mov       rsi,rax
       mov       rdx,rsi
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       mov       rcx,rdi
       mov       r8,[rbp-0B8]
       mov       [rbp-0D0],rax
       mov       rdx,rax
       mov       r11,7FFEFF670E20
       call      qword ptr [r11]
       test      eax,eax
       jg        short M00_L35
       mov       r12,[rbp-0D0]
       mov       [rbp-0B8],r12
       mov       r12,rsi
       mov       r15,[rbp-98]
       jmp       short M00_L35
M00_L36:
       mov       ecx,2
       call      qword ptr [7FFF000776A8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       rdx,rax
       jmp       near ptr M00_L09
M00_L37:
       call      qword ptr [7FFEFF9A5DA0]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rcx,rax
       jmp       near ptr M00_L10
M00_L38:
       xor       eax,eax
       mov       [rbp-0B0],r12
       jmp       near ptr M00_L14
M00_L39:
       mov       ecx,1
       mov       [rbp-0B8],rax
       jmp       near ptr M00_L07
M00_L40:
       test      rax,rax
       je        short M00_L41
       mov       ecx,0FFFFFFFF
       mov       [rbp-0B8],rax
       jmp       near ptr M00_L07
M00_L41:
       xor       ecx,ecx
       mov       [rbp-0B8],rax
       jmp       near ptr M00_L07
M00_L42:
       mov       [rbp-0B8],rax
       mov       rcx,r15
       mov       r11,7FFEFF670DF8
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M00_L28
       mov       rcx,r15
       mov       r11,7FFEFF670E00
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       short M00_L44
M00_L43:
       mov       [rbp-0B8],rax
M00_L44:
       mov       [rbp-0C0],rdx
       mov       r14,[rbp-0A8]
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       mov       [rbp-0C8],rax
       mov       rax,[rbp-0B8]
       mov       r15,[rbp-98]
       jmp       short M00_L46
M00_L45:
       mov       [rbp-0C8],r8
M00_L46:
       mov       rcx,rdi
       mov       [rbp-0B8],rax
       mov       r8,rax
       mov       rdx,[rbp-0C8]
       mov       r11,7FFEFF670E08
       call      qword ptr [r11]
       mov       ecx,eax
       mov       [rbp-0B0],r12
       jmp       near ptr M00_L18
M00_L47:
       mov       [rbp-0B8],rax
       test      rax,rax
       jne       short M00_L48
       mov       rax,[rbp-0B8]
       xor       ecx,ecx
       mov       [rbp-0C8],r8
       mov       [rbp-0B8],rax
       mov       [rbp-0B0],r12
       jmp       near ptr M00_L18
M00_L48:
       mov       rax,[rbp-0B8]
       mov       ecx,0FFFFFFFF
       mov       [rbp-0C8],r8
       mov       [rbp-0B8],rax
       mov       [rbp-0B0],r12
       jmp       near ptr M00_L18
M00_L49:
       mov       ecx,1
       mov       [rbp-0C8],r8
       mov       [rbp-0B8],rax
       mov       [rbp-0B0],r12
       jmp       near ptr M00_L18
M00_L50:
       mov       ecx,2
       call      qword ptr [7FFF000776A8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       r10,rax
       jmp       near ptr M00_L20
M00_L51:
       call      qword ptr [7FFEFF9A5DA0]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rcx,rax
       jmp       near ptr M00_L21
M00_L52:
       xor       eax,eax
       mov       [rbp-0B0],r12
       jmp       near ptr M00_L25
M00_L53:
       mov       ecx,[r15+8]
       call      qword ptr [7FFF00077540]
       int       3
M00_L54:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L55:
       xor       ecx,ecx
       mov       [rbp-40],ecx
       xor       r12d,r12d
       mov       r15,[rbp-98]
M00_L56:
       cmp       [r15],r13
       jne       near ptr M00_L64
M00_L57:
       cmp       byte ptr [rbp-40],0
       je        near ptr M00_L65
       mov       [rbp-58],r12
       mov       rbx,[rbp+10]
       mov       r15,[rbx+60]
       mov       rdx,[rbp-58]
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [r15+8],rax
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
M00_L58:
       mov       ecx,11
       call      qword ptr [7FFEFF9A7DF8]
       int       3
M00_L59:
       mov       r13,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord>
       mov       rcx,r13
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       dword ptr [r12+8],0FFFFFFFF
       mov       [r12+0C],r14d
       lea       rcx,[r12+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L02
M00_L60:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdx,1A741400E58
       mov       rdx,[rdx]
       mov       rcx,r14
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonRecordOrderBy>b__13_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       call      qword ptr [7FFEFF726BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1A741400E68
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L61:
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L01
M00_L62:
       mov       rcx,rdi
       mov       r11,7FFEFF670E30
       call      qword ptr [r11]
       mov       r12,rax
       jmp       near ptr M00_L02
M00_L63:
       mov       r11,7FFEFF670DE0
       call      qword ptr [r11]
       mov       r12,rax
       jmp       near ptr M00_L02
M00_L64:
       mov       rcx,r15
       mov       r11,7FFEFF670E28
       call      qword ptr [r11]
       jmp       near ptr M00_L57
M00_L65:
       call      qword ptr [7FFEFFEAFD38]
       int       3
       sub       rsp,38
       vzeroupper
       cmp       qword ptr [rbp-98],0
       je        short M00_L66
       mov       r13,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord>
       mov       r15,[rbp-98]
       cmp       [r15],r13
       je        short M00_L66
       mov       rcx,r15
       mov       r11,7FFEFF670E28
       call      qword ptr [r11]
M00_L66:
       nop
       add       rsp,38
       ret
; Total bytes of code 2622
```
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonRecordOrderBy>b__13_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       mov       rax,[rdx+30]
       ret
; Total bytes of code 5
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FFF51600D78]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       ecx,ebx
       and       ecx,0FFFFFF
       mov       edx,ecx
       mov       r8d,ebx
       sar       r8d,18
       jne       short M02_L01
       cmp       [rax],ecx
       jle       short M02_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M02_L03
M02_L00:
       add       rsp,20
       pop       rbx
       ret
M02_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M02_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M02_L00
M02_L02:
       cmp       [rax+4],edx
       jle       short M02_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M02_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M02_L03
       jmp       short M02_L00
M02_L03:
       mov       ecx,ebx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax]
; Total bytes of code 130
```
```assembly
; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       push      rsi
       push      rbx
       sub       rsp,28
       call      qword ptr [7FFF515E87D0]
       mov       rbx,rax
       mov       rsi,rbx
       call      qword ptr [7FFF515FFA88]
       mov       rdx,rax
       test      rsi,rsi
       je        short M03_L00
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFF51600C28]
       mov       rax,[rbx]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M03_L00:
       call      qword ptr [7FFF515FE468]
       int       3
; Total bytes of code 61
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M04_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L00:
       call      qword ptr [7FFF0007E580]
       int       3
; Total bytes of code 44
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M05_L00
       ret
M05_L00:
       jmp       qword ptr [7FFEFF725C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.PersonRecordOrderBy()
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
       xor       eax,eax
       mov       [rbp-58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp-40],rax
       mov       rbx,rcx
       lea       rcx,[rbp-90]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rcx,rsp
       mov       [rbp-78],rcx
       mov       rcx,rbp
       mov       [rbp-68],rcx
       mov       [rbp+10],rbx
       mov       rdi,[rbx+280]
       mov       rcx,27270C02E60
       mov       r14,[rcx]
       test      r14,r14
       je        near ptr M00_L66
M00_L00:
       mov       rcx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [r15+10],eax
       lea       rcx,[r15+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        near ptr M00_L64
       xor       ecx,ecx
       mov       [r15+20],rcx
       lea       rcx,[r15+28]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,27270C00A08
       mov       rdx,[rcx]
       lea       rcx,[r15+30]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [r15+48],0
       mov       rcx,[r15+18]
       mov       rax,offset MT_System.Collections.ObjectModel.Collection<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord>
       cmp       [rcx],rax
       jne       near ptr M00_L69
       mov       rdi,[rcx+8]
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord[]
       cmp       [rdi],rcx
       jne       near ptr M00_L68
       mov       r14d,[rdi+8]
       test      r14d,r14d
       jne       near ptr M00_L65
       mov       r13,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord>
       mov       rcx,r13
       test      byte ptr [7FFEFFFFD680],1
       je        near ptr M00_L67
M00_L01:
       mov       rcx,27270C02E90
       mov       r12,[rcx]
M00_L02:
       mov       [rbp-98],r12
       mov       r13,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord>
       cmp       [r12],r13
       jne       near ptr M00_L36
       mov       ecx,[r12+8]
       inc       ecx
       cmp       ecx,[r12+0C]
       jae       near ptr M00_L35
       mov       [r12+8],ecx
M00_L03:
       mov       rdi,[r15+30]
       mov       [rbp-0A0],rdi
       mov       r14,[r15+28]
       mov       [rbp-0A8],r14
       cmp       [r12],r13
       jne       near ptr M00_L38
       mov       ecx,[r12+8]
       cmp       ecx,[r12+0C]
       jae       near ptr M00_L37
       mov       rax,[r12+10]
       cmp       ecx,[rax+8]
       jae       near ptr M00_L60
       mov       r12,[rax+rcx*8+10]
       mov       rcx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonRecordOrderBy>b__13_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       cmp       [r14+18],rcx
       jne       near ptr M00_L39
       mov       rax,[r12+30]
M00_L04:
       cmp       byte ptr [r15+48],0
       jne       near ptr M00_L29
       test      r14,r14
       je        near ptr M00_L20
       test      rdi,rdi
       je        near ptr M00_L20
       mov       r15,[rbp-98]
       cmp       [r15],r13
       jne       near ptr M00_L20
       mov       rcx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonRecordOrderBy>b__13_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       cmp       [r14+18],rcx
       jne       near ptr M00_L20
       mov       rcx,offset MT_System.Collections.Generic.GenericComparer<System.String>
       cmp       [rdi],rcx
       jne       near ptr M00_L20
       jmp       short M00_L09
M00_L05:
       mov       rdi,[rbp-0C0]
       mov       rax,r14
       mov       [rbp-0B0],rdi
       mov       r12,[rbp-0B0]
       jmp       short M00_L09
M00_L06:
       cmp       rdx,r9
       je        near ptr M00_L44
       mov       [rbp-0B0],r12
       jmp       near ptr M00_L12
M00_L07:
       xor       ecx,ecx
M00_L08:
       test      ecx,ecx
       mov       rax,[rbp-0B8]
       mov       r15,[rbp-98]
       jge       short M00_L05
M00_L09:
       mov       edx,[r15+8]
       inc       edx
       cmp       edx,[r15+0C]
       jae       near ptr M00_L27
       mov       [r15+8],edx
       mov       r8d,[r15+8]
       cmp       r8d,[r15+0C]
       jae       near ptr M00_L59
       mov       r14,[r15+10]
       cmp       r8d,[r14+8]
       jae       near ptr M00_L60
       mov       ecx,r8d
       mov       rdi,[r14+rcx*8+10]
       mov       [rbp-0C0],rdi
       mov       r14,[rdi+30]
       test      r14,r14
       je        near ptr M00_L46
       test      rax,rax
       je        near ptr M00_L45
       mov       [rbp-0B8],rax
       cmp       r14,rax
       je        short M00_L07
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],2
       jle       near ptr M00_L42
       mov       rcx,[rcx+240]
       mov       rdx,[rcx+10]
       test      rdx,rdx
       je        near ptr M00_L42
M00_L10:
       mov       rcx,[rdx+10]
       test      rcx,rcx
       jne       short M00_L11
       mov       rcx,27270C00110
       mov       rcx,[rcx]
       test      rcx,rcx
       jne       short M00_L11
       mov       rcx,27270C000F0
       mov       rcx,[rcx]
       test      rcx,rcx
       je        near ptr M00_L43
M00_L11:
       mov       rdx,[rcx]
       mov       rdx,[rdx+48]
       call      qword ptr [rdx+30]
       cmp       [rax],al
       lea       rdx,[r14+0C]
       mov       [rbp-0C8],r14
       mov       r8d,[r14+8]
       mov       r10,[rbp-0B8]
       lea       r9,[r10+0C]
       mov       [rbp-0B8],r10
       mov       r11d,[r10+8]
       cmp       r8d,r11d
       je        near ptr M00_L06
       mov       [rbp-0B0],r12
M00_L12:
       mov       [rbp-48],rdx
       mov       [rbp-50],r9
       mov       rcx,[rax+20]
       mov       [rsp+20],r11d
       xor       eax,eax
       mov       [rsp+28],eax
       mov       rax,7FFEFF95B650
       mov       [rbp-80],rax
       lea       rax,[M00_L13]
       mov       [rbp-70],rax
       lea       rax,[rbp-90]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFF5F2F93A0
       call      rax
M00_L13:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFF5F64F778],0
       je        short M00_L14
       call      qword ptr [7FFF5F63D608]; CORINFO_HELP_STOP_FOR_GC
M00_L14:
       mov       rcx,[rbp-88]
       mov       [rsi+8],rcx
       xor       ecx,ecx
       mov       [rbp-48],rcx
       mov       [rbp-50],rcx
M00_L15:
       mov       ecx,eax
       mov       r12,[rbp-0B0]
       mov       r14,[rbp-0C8]
       jmp       near ptr M00_L08
M00_L16:
       mov       rdx,[rbp-0C0]
       mov       r10,[rbp-0C8]
       mov       r11,r10
       mov       r12,rdx
       mov       rax,r11
       jmp       short M00_L20
M00_L17:
       cmp       rdx,r9
       je        near ptr M00_L58
       mov       [rbp-0B0],r12
       jmp       near ptr M00_L23
M00_L18:
       xor       ecx,ecx
       mov       [rbp-0B0],r12
M00_L19:
       test      ecx,ecx
       mov       rax,[rbp-0B8]
       mov       r12,[rbp-0B0]
       mov       r14,[rbp-0A8]
       jge       short M00_L16
M00_L20:
       mov       r15,[rbp-98]
       cmp       [r15],r13
       jne       near ptr M00_L48
       mov       edx,[r15+8]
       inc       edx
       cmp       edx,[r15+0C]
       jae       near ptr M00_L27
       mov       [r15+8],edx
       mov       ecx,[r15+8]
       cmp       ecx,[r15+0C]
       jae       near ptr M00_L59
       mov       rcx,[r15+10]
       mov       r8d,[r15+8]
       cmp       r8d,[rcx+8]
       jae       near ptr M00_L60
       mov       edx,r8d
       mov       rcx,[rcx+rdx*8+10]
       mov       rdx,rcx
       mov       rcx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonRecordOrderBy>b__13_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       cmp       [r14+18],rcx
       jne       near ptr M00_L49
       mov       r15,[rbp-98]
       mov       [rbp-0C0],rdx
       mov       rcx,[rdx+30]
       mov       r8,rcx
       mov       rcx,offset MT_System.Collections.Generic.GenericComparer<System.String>
       cmp       [rdi],rcx
       mov       rdi,[rbp-0A0]
       jne       near ptr M00_L51
       test      r8,r8
       je        near ptr M00_L53
       test      rax,rax
       je        near ptr M00_L55
       mov       [rbp-0C8],r8
       mov       [rbp-0B8],rax
       cmp       r8,rax
       je        near ptr M00_L18
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],2
       jle       near ptr M00_L56
       mov       rcx,[rcx+240]
       mov       r10,[rcx+10]
       test      r10,r10
       je        near ptr M00_L56
M00_L21:
       mov       rcx,[r10+10]
       test      rcx,rcx
       jne       short M00_L22
       mov       rcx,27270C00110
       mov       rcx,[rcx]
       test      rcx,rcx
       jne       short M00_L22
       mov       rcx,27270C000F0
       mov       rcx,[rcx]
       test      rcx,rcx
       je        near ptr M00_L57
M00_L22:
       mov       r10,[rcx]
       mov       r10,[r10+48]
       call      qword ptr [r10+30]
       cmp       [rax],al
       mov       r10,[rbp-0C8]
       lea       rdx,[r10+0C]
       mov       [rbp-0C8],r10
       mov       r8d,[r10+8]
       mov       r11,[rbp-0B8]
       lea       r9,[r11+0C]
       mov       [rbp-0B8],r11
       mov       ecx,[r11+8]
       cmp       r8d,ecx
       je        near ptr M00_L17
       mov       [rbp-0B0],r12
M00_L23:
       mov       [rbp-48],rdx
       mov       [rbp-50],r9
       mov       rax,[rax+20]
       mov       [rsp+20],ecx
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rax
       mov       rax,7FFEFF95B650
       mov       [rbp-80],rax
       lea       rax,[M00_L24]
       mov       [rbp-70],rax
       lea       rax,[rbp-90]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFF5F2F93A0
       call      rax
M00_L24:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFF5F64F778],0
       je        short M00_L25
       call      qword ptr [7FFF5F63D608]; CORINFO_HELP_STOP_FOR_GC
M00_L25:
       mov       rcx,[rbp-88]
       mov       [rsi+8],rcx
       xor       ecx,ecx
       mov       [rbp-48],rcx
       mov       [rbp-50],rcx
       mov       rdi,[rbp-0A0]
       mov       r15,[rbp-98]
M00_L26:
       mov       ecx,eax
       jmp       near ptr M00_L19
M00_L27:
       mov       edx,[r15+0C]
       mov       [r15+8],edx
M00_L28:
       mov       dword ptr [rbp-40],1
       jmp       near ptr M00_L62
M00_L29:
       mov       r15,[rbp-98]
       cmp       [r15],r13
       jne       near ptr M00_L32
M00_L30:
       mov       r8d,[r15+8]
       inc       r8d
       cmp       r8d,[r15+0C]
       jae       near ptr M00_L34
       mov       [r15+8],r8d
       mov       edx,[r15+8]
       cmp       edx,[r15+0C]
       mov       [rbp-0B8],rax
       jae       near ptr M00_L41
       mov       rsi,[r15+10]
       mov       r10d,[r15+8]
       cmp       r10d,[rsi+8]
       jae       near ptr M00_L60
       mov       edx,r10d
       mov       rsi,[rsi+rdx*8+10]
       mov       rdx,rsi
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       mov       rcx,rdi
       mov       r8,[rbp-0B8]
       mov       [rbp-0D0],rax
       mov       rdx,rax
       mov       r11,7FFEFF630E20
       call      qword ptr [r11]
       test      eax,eax
       mov       rax,[rbp-0B8]
       jg        short M00_L30
       mov       r12,[rbp-0D0]
       mov       [rbp-0B8],r12
       mov       r12,rsi
       mov       rax,[rbp-0B8]
       jmp       near ptr M00_L30
M00_L31:
       mov       r12,[rbp-0D0]
       mov       rax,r12
       mov       r12,rsi
M00_L32:
       cmp       [r15],r13
       jne       near ptr M00_L40
       mov       r8d,[r15+8]
       inc       r8d
       cmp       r8d,[r15+0C]
       jae       short M00_L34
       mov       [r15+8],r8d
       mov       ecx,[r15+8]
       cmp       ecx,[r15+0C]
       jae       near ptr M00_L41
       mov       rsi,[r15+10]
       mov       r10d,[r15+8]
       cmp       r10d,[rsi+8]
       jae       near ptr M00_L60
       mov       ecx,r10d
       mov       rsi,[rsi+rcx*8+10]
       mov       [rbp-0B8],rax
M00_L33:
       mov       rdx,rsi
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       mov       rcx,rdi
       mov       r8,[rbp-0B8]
       mov       [rbp-0D0],rax
       mov       rdx,rax
       mov       r11,7FFEFF630E20
       call      qword ptr [r11]
       test      eax,eax
       mov       rax,[rbp-0B8]
       jg        short M00_L32
       jmp       near ptr M00_L31
M00_L34:
       mov       ecx,[r15+0C]
       mov       [r15+8],ecx
       jmp       near ptr M00_L28
M00_L35:
       mov       ecx,[r12+0C]
       mov       [r12+8],ecx
       jmp       near ptr M00_L61
M00_L36:
       mov       rcx,r12
       mov       r11,7FFEFF630DE8
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M00_L61
       jmp       near ptr M00_L03
M00_L37:
       call      qword ptr [7FFF00037720]
       int       3
M00_L38:
       mov       rcx,r12
       mov       r11,7FFEFF630DF0
       call      qword ptr [r11]
       mov       r12,rax
M00_L39:
       mov       [rbp-0B0],r12
       mov       rdx,r12
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       mov       r12,[rbp-0B0]
       jmp       near ptr M00_L04
M00_L40:
       mov       [rbp-0B8],rax
       mov       rcx,r15
       mov       r11,7FFEFF630E10
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M00_L28
       mov       rcx,r15
       mov       r11,7FFEFF630E18
       call      qword ptr [r11]
       mov       rsi,rax
       jmp       near ptr M00_L33
M00_L41:
       mov       ecx,[r15+8]
       call      qword ptr [7FFF00037720]
       int       3
M00_L42:
       mov       ecx,2
       call      qword ptr [7FFF00037780]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       rdx,rax
       jmp       near ptr M00_L10
M00_L43:
       call      qword ptr [7FFEFF965DA0]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rcx,rax
       jmp       near ptr M00_L11
M00_L44:
       xor       eax,eax
       mov       [rbp-0B0],r12
       jmp       near ptr M00_L15
M00_L45:
       mov       ecx,1
       mov       [rbp-0B8],rax
       jmp       near ptr M00_L08
M00_L46:
       test      rax,rax
       je        short M00_L47
       mov       ecx,0FFFFFFFF
       mov       [rbp-0B8],rax
       jmp       near ptr M00_L08
M00_L47:
       xor       ecx,ecx
       mov       [rbp-0B8],rax
       jmp       near ptr M00_L08
M00_L48:
       mov       [rbp-0B8],rax
       mov       rcx,r15
       mov       r11,7FFEFF630DF8
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M00_L28
       mov       rcx,r15
       mov       r11,7FFEFF630E00
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       short M00_L50
M00_L49:
       mov       [rbp-0B8],rax
M00_L50:
       mov       [rbp-0C0],rdx
       mov       r14,[rbp-0A8]
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       mov       [rbp-0C8],rax
       mov       rax,[rbp-0B8]
       mov       r15,[rbp-98]
       jmp       short M00_L52
M00_L51:
       mov       [rbp-0C8],r8
M00_L52:
       mov       rcx,rdi
       mov       [rbp-0B8],rax
       mov       r8,rax
       mov       rdx,[rbp-0C8]
       mov       r11,7FFEFF630E08
       call      qword ptr [r11]
       mov       ecx,eax
       mov       [rbp-0B0],r12
       jmp       near ptr M00_L19
M00_L53:
       mov       [rbp-0B8],rax
       test      rax,rax
       jne       short M00_L54
       mov       rax,[rbp-0B8]
       xor       ecx,ecx
       mov       [rbp-0C8],r8
       mov       [rbp-0B8],rax
       mov       [rbp-0B0],r12
       jmp       near ptr M00_L19
M00_L54:
       mov       rax,[rbp-0B8]
       mov       ecx,0FFFFFFFF
       mov       [rbp-0C8],r8
       mov       [rbp-0B8],rax
       mov       [rbp-0B0],r12
       jmp       near ptr M00_L19
M00_L55:
       mov       ecx,1
       mov       [rbp-0C8],r8
       mov       [rbp-0B8],rax
       mov       [rbp-0B0],r12
       jmp       near ptr M00_L19
M00_L56:
       mov       ecx,2
       call      qword ptr [7FFF00037780]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       r10,rax
       jmp       near ptr M00_L21
M00_L57:
       call      qword ptr [7FFEFF965DA0]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rcx,rax
       jmp       near ptr M00_L22
M00_L58:
       xor       eax,eax
       mov       [rbp-0B0],r12
       jmp       near ptr M00_L26
M00_L59:
       mov       ecx,[r15+8]
       call      qword ptr [7FFF00037720]
       int       3
M00_L60:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L61:
       xor       ecx,ecx
       mov       [rbp-40],ecx
       xor       r12d,r12d
       mov       r15,[rbp-98]
M00_L62:
       cmp       [r15],r13
       jne       near ptr M00_L70
M00_L63:
       cmp       byte ptr [rbp-40],0
       je        near ptr M00_L71
       mov       [rbp-58],r12
       mov       rbx,[rbp+10]
       mov       r15,[rbx+60]
       mov       rdx,[rbp-58]
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [r15+8],rax
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
M00_L64:
       mov       ecx,11
       call      qword ptr [7FFEFF967DF8]
       int       3
M00_L65:
       mov       r13,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord>
       mov       rcx,r13
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       dword ptr [r12+8],0FFFFFFFF
       mov       [r12+0C],r14d
       lea       rcx,[r12+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L02
M00_L66:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdx,27270C02E50
       mov       rdx,[rdx]
       mov       rcx,r14
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonRecordOrderBy>b__13_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       call      qword ptr [7FFEFF6E6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,27270C02E60
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L67:
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L01
M00_L68:
       mov       rcx,rdi
       mov       r11,7FFEFF630E30
       call      qword ptr [r11]
       mov       r12,rax
       jmp       near ptr M00_L02
M00_L69:
       mov       r11,7FFEFF630DE0
       call      qword ptr [r11]
       mov       r12,rax
       jmp       near ptr M00_L02
M00_L70:
       mov       rcx,r15
       mov       r11,7FFEFF630E28
       call      qword ptr [r11]
       jmp       near ptr M00_L63
M00_L71:
       call      qword ptr [7FFEFFE6FE58]
       int       3
       sub       rsp,38
       vzeroupper
       cmp       qword ptr [rbp-98],0
       je        short M00_L72
       mov       r13,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord>
       mov       r15,[rbp-98]
       cmp       [r15],r13
       je        short M00_L72
       mov       rcx,r15
       mov       r11,7FFEFF630E28
       call      qword ptr [r11]
M00_L72:
       nop
       add       rsp,38
       ret
; Total bytes of code 2884
```
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonRecordOrderBy>b__13_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       mov       rax,[rdx+30]
       ret
; Total bytes of code 5
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FFF51600D78]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       ecx,ebx
       and       ecx,0FFFFFF
       mov       edx,ecx
       mov       r8d,ebx
       sar       r8d,18
       jne       short M02_L01
       cmp       [rax],ecx
       jle       short M02_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M02_L03
M02_L00:
       add       rsp,20
       pop       rbx
       ret
M02_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M02_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M02_L00
M02_L02:
       cmp       [rax+4],edx
       jle       short M02_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M02_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M02_L03
       jmp       short M02_L00
M02_L03:
       mov       ecx,ebx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax]
; Total bytes of code 130
```
```assembly
; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       push      rsi
       push      rbx
       sub       rsp,28
       call      qword ptr [7FFF515E87D0]
       mov       rbx,rax
       mov       rsi,rbx
       call      qword ptr [7FFF515FFA88]
       mov       rdx,rax
       test      rsi,rsi
       je        short M03_L00
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFF51600C28]
       mov       rax,[rbx]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M03_L00:
       call      qword ptr [7FFF515FE468]
       int       3
; Total bytes of code 61
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M04_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L00:
       call      qword ptr [7FFF0003E520]
       int       3
; Total bytes of code 44
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M05_L00
       ret
M05_L00:
       jmp       qword ptr [7FFEFF6E5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.PersonRecordOrderBy()
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
       xor       eax,eax
       mov       [rbp-58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp-40],rax
       mov       rbx,rcx
       lea       rcx,[rbp-90]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rcx,rsp
       mov       [rbp-78],rcx
       mov       rcx,rbp
       mov       [rbp-68],rcx
       mov       [rbp+10],rbx
       mov       rdi,[rbx+280]
       mov       rcx,19473800E68
       mov       r14,[rcx]
       test      r14,r14
       je        near ptr M00_L65
M00_L00:
       mov       rcx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [r15+10],eax
       lea       rcx,[r15+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        near ptr M00_L63
       xor       ecx,ecx
       mov       [r15+20],rcx
       lea       rcx,[r15+28]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,19448800A08
       mov       rdx,[rcx]
       lea       rcx,[r15+30]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [r15+48],0
       mov       rcx,[r15+18]
       mov       rax,offset MT_System.Collections.ObjectModel.Collection<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord>
       cmp       [rcx],rax
       jne       near ptr M00_L68
       mov       rdi,[rcx+8]
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord[]
       cmp       [rdi],rcx
       jne       near ptr M00_L67
       mov       r14d,[rdi+8]
       test      r14d,r14d
       jne       near ptr M00_L64
       mov       r13,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord>
       mov       rcx,r13
       test      byte ptr [7FFF000296F8],1
       je        near ptr M00_L66
M00_L01:
       mov       rcx,19473800E98
       mov       r12,[rcx]
M00_L02:
       mov       [rbp-98],r12
       mov       r13,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord>
       cmp       [r12],r13
       jne       near ptr M00_L36
       mov       ecx,[r12+8]
       inc       ecx
       cmp       ecx,[r12+0C]
       jae       near ptr M00_L35
       mov       [r12+8],ecx
M00_L03:
       mov       rdi,[r15+30]
       mov       [rbp-0A0],rdi
       mov       r14,[r15+28]
       mov       [rbp-0A8],r14
       cmp       [r12],r13
       jne       near ptr M00_L38
       mov       ecx,[r12+8]
       cmp       ecx,[r12+0C]
       jae       near ptr M00_L37
       mov       rax,[r12+10]
       cmp       ecx,[rax+8]
       jae       near ptr M00_L59
       mov       r12,[rax+rcx*8+10]
       mov       rcx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonRecordOrderBy>b__13_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       cmp       [r14+18],rcx
       jne       near ptr M00_L39
       mov       rax,[r12+30]
M00_L04:
       cmp       byte ptr [r15+48],0
       jne       near ptr M00_L29
       test      r14,r14
       je        near ptr M00_L22
       test      rdi,rdi
       je        near ptr M00_L22
       mov       r15,[rbp-98]
       cmp       [r15],r13
       jne       near ptr M00_L22
       mov       rcx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonRecordOrderBy>b__13_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       cmp       [r14+18],rcx
       jne       near ptr M00_L22
       mov       rcx,offset MT_System.Collections.Generic.GenericComparer<System.String>
       cmp       [rdi],rcx
       jne       near ptr M00_L22
       jmp       short M00_L09
M00_L05:
       mov       rax,r14
       mov       rdi,[rbp-0C0]
       mov       [rbp-0B0],rdi
       mov       r12,[rbp-0B0]
       jmp       short M00_L09
M00_L06:
       cmp       rdx,r9
       je        near ptr M00_L44
       mov       [rbp-0B0],r12
       jmp       near ptr M00_L12
M00_L07:
       xor       ecx,ecx
M00_L08:
       test      ecx,ecx
       mov       rax,[rbp-0B8]
       jge       short M00_L05
M00_L09:
       mov       r15,[rbp-98]
       mov       edx,[r15+8]
       inc       edx
       cmp       edx,[r15+0C]
       jae       near ptr M00_L27
       mov       [r15+8],edx
       mov       r8d,[r15+8]
       cmp       r8d,[r15+0C]
       jae       near ptr M00_L58
       mov       r14,[r15+10]
       cmp       r8d,[r14+8]
       jae       near ptr M00_L59
       mov       ecx,r8d
       mov       rdi,[r14+rcx*8+10]
       mov       [rbp-0C0],rdi
       mov       r14,[rdi+30]
       test      r14,r14
       je        near ptr M00_L46
       test      rax,rax
       je        near ptr M00_L45
       mov       [rbp-0B8],rax
       cmp       r14,rax
       je        short M00_L07
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],2
       jle       near ptr M00_L42
       mov       rcx,[rcx+240]
       mov       rdx,[rcx+10]
       test      rdx,rdx
       je        near ptr M00_L42
M00_L10:
       mov       rcx,[rdx+10]
       test      rcx,rcx
       jne       short M00_L11
       mov       rcx,19448800110
       mov       rcx,[rcx]
       test      rcx,rcx
       jne       short M00_L11
       mov       rcx,194488000F0
       mov       rcx,[rcx]
       test      rcx,rcx
       je        near ptr M00_L43
M00_L11:
       mov       rdx,[rcx]
       mov       rdx,[rdx+48]
       call      qword ptr [rdx+30]
       cmp       [rax],al
       lea       rdx,[r14+0C]
       mov       [rbp-0C8],r14
       mov       r8d,[r14+8]
       mov       r10,[rbp-0B8]
       lea       r9,[r10+0C]
       mov       [rbp-0B8],r10
       mov       r11d,[r10+8]
       cmp       r8d,r11d
       je        near ptr M00_L06
       mov       [rbp-0B0],r12
M00_L12:
       mov       [rbp-48],rdx
       mov       [rbp-50],r9
       mov       rcx,[rax+20]
       mov       [rsp+20],r11d
       xor       eax,eax
       mov       [rsp+28],eax
       mov       rax,7FFEFF98B650
       mov       [rbp-80],rax
       lea       rax,[M00_L13]
       mov       [rbp-70],rax
       lea       rax,[rbp-90]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFF5F2F93A0
       call      rax
M00_L13:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFF5F64F778],0
       je        short M00_L14
       call      qword ptr [7FFF5F63D608]; CORINFO_HELP_STOP_FOR_GC
M00_L14:
       mov       rcx,[rbp-88]
       mov       [rsi+8],rcx
       xor       ecx,ecx
       mov       [rbp-48],rcx
       mov       [rbp-50],rcx
M00_L15:
       mov       ecx,eax
       mov       r12,[rbp-0B0]
       mov       r14,[rbp-0C8]
       jmp       near ptr M00_L08
M00_L16:
       mov       [rbp-0B0],r12
M00_L17:
       mov       [rbp-48],rdx
       mov       [rbp-50],r9
       mov       rax,[rax+20]
       mov       [rsp+20],ecx
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rax
       mov       rax,7FFEFF98B650
       mov       [rbp-80],rax
       lea       rax,[M00_L18]
       mov       [rbp-70],rax
       lea       rax,[rbp-90]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFF5F2F93A0
       call      rax
M00_L18:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFF5F64F778],0
       je        short M00_L19
       call      qword ptr [7FFF5F63D608]; CORINFO_HELP_STOP_FOR_GC
M00_L19:
       mov       rcx,[rbp-88]
       mov       [rsi+8],rcx
       xor       ecx,ecx
       mov       [rbp-48],rcx
       mov       [rbp-50],rcx
       mov       rdi,[rbp-0A0]
       mov       r15,[rbp-98]
M00_L20:
       mov       ecx,eax
M00_L21:
       test      ecx,ecx
       mov       rax,[rbp-0B8]
       mov       r12,[rbp-0B0]
       jge       near ptr M00_L26
       mov       r14,[rbp-0A8]
M00_L22:
       mov       r15,[rbp-98]
       cmp       [r15],r13
       jne       near ptr M00_L47
       mov       edx,[r15+8]
       inc       edx
       cmp       edx,[r15+0C]
       jae       near ptr M00_L27
       mov       [r15+8],edx
       mov       ecx,[r15+8]
       cmp       ecx,[r15+0C]
       jae       near ptr M00_L58
       mov       rcx,[r15+10]
       mov       r8d,[r15+8]
       cmp       r8d,[rcx+8]
       jae       near ptr M00_L59
       mov       edx,r8d
       mov       rcx,[rcx+rdx*8+10]
       mov       rdx,rcx
       mov       rcx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonRecordOrderBy>b__13_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       cmp       [r14+18],rcx
       jne       near ptr M00_L48
       mov       r15,[rbp-98]
       mov       [rbp-0C0],rdx
       mov       rcx,[rdx+30]
       mov       r8,rcx
       mov       rcx,offset MT_System.Collections.Generic.GenericComparer<System.String>
       cmp       [rdi],rcx
       mov       rdi,[rbp-0A0]
       jne       near ptr M00_L50
       test      r8,r8
       je        near ptr M00_L52
       test      rax,rax
       je        near ptr M00_L54
       mov       [rbp-0C8],r8
       mov       [rbp-0B8],rax
       cmp       r8,rax
       je        near ptr M00_L25
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],2
       jle       near ptr M00_L55
       mov       rcx,[rcx+240]
       mov       r10,[rcx+10]
       test      r10,r10
       je        near ptr M00_L55
M00_L23:
       mov       rcx,[r10+10]
       test      rcx,rcx
       jne       short M00_L24
       mov       rcx,19448800110
       mov       rcx,[rcx]
       test      rcx,rcx
       jne       short M00_L24
       mov       rcx,194488000F0
       mov       rcx,[rcx]
       test      rcx,rcx
       je        near ptr M00_L56
M00_L24:
       mov       r10,[rcx]
       mov       r10,[r10+48]
       call      qword ptr [r10+30]
       cmp       [rax],al
       mov       r10,[rbp-0C8]
       lea       rdx,[r10+0C]
       mov       [rbp-0C8],r10
       mov       r8d,[r10+8]
       mov       r11,[rbp-0B8]
       lea       r9,[r11+0C]
       mov       [rbp-0B8],r11
       mov       ecx,[r11+8]
       cmp       r8d,ecx
       jne       near ptr M00_L16
       cmp       rdx,r9
       je        near ptr M00_L57
       mov       [rbp-0B0],r12
       jmp       near ptr M00_L17
M00_L25:
       xor       ecx,ecx
       mov       [rbp-0B0],r12
       jmp       near ptr M00_L21
M00_L26:
       mov       r10,[rbp-0C8]
       mov       r11,r10
       mov       rdx,[rbp-0C0]
       mov       r12,rdx
       mov       rax,r11
       mov       r14,[rbp-0A8]
       jmp       near ptr M00_L22
M00_L27:
       mov       edx,[r15+0C]
       mov       [r15+8],edx
M00_L28:
       mov       dword ptr [rbp-40],1
       jmp       near ptr M00_L61
M00_L29:
       mov       r15,[rbp-98]
       cmp       [r15],r13
       jne       near ptr M00_L32
M00_L30:
       mov       r8d,[r15+8]
       inc       r8d
       cmp       r8d,[r15+0C]
       jae       near ptr M00_L34
       mov       [r15+8],r8d
       mov       edx,[r15+8]
       cmp       edx,[r15+0C]
       mov       [rbp-0B8],rax
       jae       near ptr M00_L41
       mov       rsi,[r15+10]
       mov       r10d,[r15+8]
       cmp       r10d,[rsi+8]
       jae       near ptr M00_L59
       mov       edx,r10d
       mov       rsi,[rsi+rdx*8+10]
       mov       rdx,rsi
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       mov       rcx,rdi
       mov       r8,[rbp-0B8]
       mov       [rbp-0D0],rax
       mov       rdx,rax
       mov       r11,7FFEFF660E20
       call      qword ptr [r11]
       test      eax,eax
       mov       rax,[rbp-0B8]
       jg        short M00_L30
       mov       r12,[rbp-0D0]
       mov       [rbp-0B8],r12
       mov       r12,rsi
       mov       rax,[rbp-0B8]
       jmp       near ptr M00_L30
M00_L31:
       mov       r12,[rbp-0D0]
       mov       rax,r12
       mov       r12,rsi
M00_L32:
       cmp       [r15],r13
       jne       near ptr M00_L40
       mov       r8d,[r15+8]
       inc       r8d
       cmp       r8d,[r15+0C]
       jae       short M00_L34
       mov       [r15+8],r8d
       mov       ecx,[r15+8]
       cmp       ecx,[r15+0C]
       jae       near ptr M00_L41
       mov       rsi,[r15+10]
       mov       r10d,[r15+8]
       cmp       r10d,[rsi+8]
       jae       near ptr M00_L59
       mov       ecx,r10d
       mov       rsi,[rsi+rcx*8+10]
       mov       [rbp-0B8],rax
M00_L33:
       mov       rdx,rsi
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       mov       rcx,rdi
       mov       r8,[rbp-0B8]
       mov       [rbp-0D0],rax
       mov       rdx,rax
       mov       r11,7FFEFF660E20
       call      qword ptr [r11]
       test      eax,eax
       mov       rax,[rbp-0B8]
       jg        short M00_L32
       jmp       near ptr M00_L31
M00_L34:
       mov       ecx,[r15+0C]
       mov       [r15+8],ecx
       jmp       near ptr M00_L28
M00_L35:
       mov       ecx,[r12+0C]
       mov       [r12+8],ecx
       jmp       near ptr M00_L60
M00_L36:
       mov       rcx,r12
       mov       r11,7FFEFF660DE8
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M00_L60
       jmp       near ptr M00_L03
M00_L37:
       call      qword ptr [7FFF00067750]
       int       3
M00_L38:
       mov       rcx,r12
       mov       r11,7FFEFF660DF0
       call      qword ptr [r11]
       mov       r12,rax
M00_L39:
       mov       [rbp-0B0],r12
       mov       rdx,r12
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       mov       r12,[rbp-0B0]
       jmp       near ptr M00_L04
M00_L40:
       mov       [rbp-0B8],rax
       mov       rcx,r15
       mov       r11,7FFEFF660E10
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M00_L28
       mov       rcx,r15
       mov       r11,7FFEFF660E18
       call      qword ptr [r11]
       mov       rsi,rax
       jmp       near ptr M00_L33
M00_L41:
       mov       ecx,[r15+8]
       call      qword ptr [7FFF00067750]
       int       3
M00_L42:
       mov       ecx,2
       call      qword ptr [7FFF000677C8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       rdx,rax
       jmp       near ptr M00_L10
M00_L43:
       call      qword ptr [7FFEFF995DA0]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rcx,rax
       jmp       near ptr M00_L11
M00_L44:
       xor       eax,eax
       mov       [rbp-0B0],r12
       jmp       near ptr M00_L15
M00_L45:
       mov       ecx,1
       mov       [rbp-0B8],rax
       jmp       near ptr M00_L08
M00_L46:
       test      rax,rax
       je        near ptr M00_L05
       mov       ecx,0FFFFFFFF
       mov       [rbp-0B8],rax
       jmp       near ptr M00_L08
M00_L47:
       mov       [rbp-0B8],rax
       mov       rcx,r15
       mov       r11,7FFEFF660DF8
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M00_L28
       mov       rcx,r15
       mov       r11,7FFEFF660E00
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       short M00_L49
M00_L48:
       mov       [rbp-0B8],rax
M00_L49:
       mov       [rbp-0C0],rdx
       mov       r14,[rbp-0A8]
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       mov       [rbp-0C8],rax
       mov       rax,[rbp-0B8]
       mov       r15,[rbp-98]
       jmp       short M00_L51
M00_L50:
       mov       [rbp-0C8],r8
M00_L51:
       mov       rcx,rdi
       mov       [rbp-0B8],rax
       mov       r8,rax
       mov       rdx,[rbp-0C8]
       mov       r11,7FFEFF660E08
       call      qword ptr [r11]
       mov       ecx,eax
       mov       [rbp-0B0],r12
       jmp       near ptr M00_L21
M00_L52:
       mov       [rbp-0B8],rax
       test      rax,rax
       jne       short M00_L53
       mov       [rbp-0C8],r8
       jmp       near ptr M00_L26
M00_L53:
       mov       rax,[rbp-0B8]
       mov       ecx,0FFFFFFFF
       mov       [rbp-0C8],r8
       mov       [rbp-0B8],rax
       mov       [rbp-0B0],r12
       jmp       near ptr M00_L21
M00_L54:
       mov       ecx,1
       mov       [rbp-0C8],r8
       mov       [rbp-0B8],rax
       mov       [rbp-0B0],r12
       jmp       near ptr M00_L21
M00_L55:
       mov       ecx,2
       call      qword ptr [7FFF000677C8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       r10,rax
       jmp       near ptr M00_L23
M00_L56:
       call      qword ptr [7FFEFF995DA0]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rcx,rax
       jmp       near ptr M00_L24
M00_L57:
       xor       eax,eax
       mov       [rbp-0B0],r12
       jmp       near ptr M00_L20
M00_L58:
       mov       ecx,[r15+8]
       call      qword ptr [7FFF00067750]
       int       3
M00_L59:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L60:
       xor       ecx,ecx
       mov       [rbp-40],ecx
       xor       r12d,r12d
       mov       r15,[rbp-98]
M00_L61:
       cmp       [r15],r13
       jne       near ptr M00_L69
M00_L62:
       cmp       byte ptr [rbp-40],0
       je        near ptr M00_L70
       mov       [rbp-58],r12
       mov       rbx,[rbp+10]
       mov       r15,[rbx+60]
       mov       rdx,[rbp-58]
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [r15+8],rax
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
M00_L63:
       mov       ecx,11
       call      qword ptr [7FFEFF997DF8]
       int       3
M00_L64:
       mov       r13,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord>
       mov       rcx,r13
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       dword ptr [r12+8],0FFFFFFFF
       mov       [r12+0C],r14d
       lea       rcx,[r12+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L02
M00_L65:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdx,19473800E58
       mov       rdx,[rdx]
       mov       rcx,r14
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonRecordOrderBy>b__13_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       call      qword ptr [7FFEFF716BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,19473800E68
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L66:
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L01
M00_L67:
       mov       rcx,rdi
       mov       r11,7FFEFF660E30
       call      qword ptr [r11]
       mov       r12,rax
       jmp       near ptr M00_L02
M00_L68:
       mov       r11,7FFEFF660DE0
       call      qword ptr [r11]
       mov       r12,rax
       jmp       near ptr M00_L02
M00_L69:
       mov       rcx,r15
       mov       r11,7FFEFF660E28
       call      qword ptr [r11]
       jmp       near ptr M00_L62
M00_L70:
       call      qword ptr [7FFEFFE9FEA0]
       int       3
       sub       rsp,38
       vzeroupper
       cmp       qword ptr [rbp-98],0
       je        short M00_L71
       mov       r13,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord>
       mov       r15,[rbp-98]
       cmp       [r15],r13
       je        short M00_L71
       mov       rcx,r15
       mov       r11,7FFEFF660E28
       call      qword ptr [r11]
M00_L71:
       nop
       add       rsp,38
       ret
; Total bytes of code 2865
```
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonRecordOrderBy>b__13_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       mov       rax,[rdx+30]
       ret
; Total bytes of code 5
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FFF51600D78]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       ecx,ebx
       and       ecx,0FFFFFF
       mov       edx,ecx
       mov       r8d,ebx
       sar       r8d,18
       jne       short M02_L01
       cmp       [rax],ecx
       jle       short M02_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M02_L03
M02_L00:
       add       rsp,20
       pop       rbx
       ret
M02_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M02_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M02_L00
M02_L02:
       cmp       [rax+4],edx
       jle       short M02_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M02_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M02_L03
       jmp       short M02_L00
M02_L03:
       mov       ecx,ebx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax]
; Total bytes of code 130
```
```assembly
; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       push      rsi
       push      rbx
       sub       rsp,28
       call      qword ptr [7FFF515E87D0]
       mov       rbx,rax
       mov       rsi,rbx
       call      qword ptr [7FFF515FFA88]
       mov       rdx,rax
       test      rsi,rsi
       je        short M03_L00
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFF51600C28]
       mov       rax,[rbx]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M03_L00:
       call      qword ptr [7FFF515FE468]
       int       3
; Total bytes of code 61
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M04_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L00:
       call      qword ptr [7FFF0006E700]
       int       3
; Total bytes of code 44
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M05_L00
       ret
M05_L00:
       jmp       qword ptr [7FFEFF715C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.PersonRecordOrderBy()
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
       xor       eax,eax
       mov       [rbp-58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp-40],rax
       mov       rbx,rcx
       lea       rcx,[rbp-90]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rcx,rsp
       mov       [rbp-78],rcx
       mov       rcx,rbp
       mov       [rbp-68],rcx
       mov       [rbp+10],rbx
       mov       rdi,[rbx+280]
       mov       rcx,1B417400E78
       mov       r14,[rcx]
       test      r14,r14
       je        near ptr M00_L65
M00_L00:
       mov       rcx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [r15+10],eax
       lea       rcx,[r15+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        near ptr M00_L66
       xor       ecx,ecx
       mov       [r15+20],rcx
       lea       rcx,[r15+28]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,1B3EA400A08
       mov       rdx,[rcx]
       lea       rcx,[r15+30]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [r15+48],0
       mov       rcx,[r15+18]
       mov       rax,offset MT_System.Collections.ObjectModel.Collection<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord>
       cmp       [rcx],rax
       jne       near ptr M00_L69
       mov       rdi,[rcx+8]
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord[]
       cmp       [rdi],rcx
       jne       near ptr M00_L68
       mov       r14d,[rdi+8]
       test      r14d,r14d
       jne       near ptr M00_L64
       mov       r13,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord>
       mov       rcx,r13
       test      byte ptr [7FFF00088B80],1
       je        near ptr M00_L67
M00_L01:
       mov       rcx,1B417400FC0
       mov       r12,[rcx]
M00_L02:
       mov       [rbp-98],r12
       mov       r13,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord>
       cmp       [r12],r13
       jne       near ptr M00_L36
       mov       ecx,[r12+8]
       inc       ecx
       cmp       ecx,[r12+0C]
       jae       near ptr M00_L35
       mov       [r12+8],ecx
M00_L03:
       mov       rdi,[r15+30]
       mov       [rbp-0A0],rdi
       mov       r14,[r15+28]
       mov       [rbp-0A8],r14
       cmp       [r12],r13
       jne       near ptr M00_L38
       mov       ecx,[r12+8]
       cmp       ecx,[r12+0C]
       jae       near ptr M00_L37
       mov       rax,[r12+10]
       cmp       ecx,[rax+8]
       jae       near ptr M00_L60
       mov       r12,[rax+rcx*8+10]
       mov       rcx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonRecordOrderBy>b__13_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       cmp       [r14+18],rcx
       jne       near ptr M00_L39
       mov       rax,[r12+30]
M00_L04:
       cmp       byte ptr [r15+48],0
       jne       near ptr M00_L29
       test      r14,r14
       je        near ptr M00_L20
       test      rdi,rdi
       je        near ptr M00_L20
       mov       r15,[rbp-98]
       cmp       [r15],r13
       jne       near ptr M00_L20
       mov       rcx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonRecordOrderBy>b__13_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       cmp       [r14+18],rcx
       jne       near ptr M00_L20
       mov       rcx,offset MT_System.Collections.Generic.GenericComparer<System.String>
       cmp       [rdi],rcx
       jne       near ptr M00_L20
       jmp       short M00_L08
M00_L05:
       mov       rdi,[rbp-0C0]
       mov       rax,r14
       mov       [rbp-0B0],rdi
       mov       r12,[rbp-0B0]
       jmp       short M00_L08
M00_L06:
       xor       ecx,ecx
M00_L07:
       test      ecx,ecx
       mov       rax,[rbp-0B8]
       mov       r15,[rbp-98]
       jge       short M00_L05
M00_L08:
       mov       edx,[r15+8]
       inc       edx
       cmp       edx,[r15+0C]
       jae       near ptr M00_L27
       mov       [r15+8],edx
       mov       r8d,[r15+8]
       cmp       r8d,[r15+0C]
       jae       near ptr M00_L59
       mov       r14,[r15+10]
       cmp       r8d,[r14+8]
       jae       near ptr M00_L60
       mov       ecx,r8d
       mov       rdi,[r14+rcx*8+10]
       mov       [rbp-0C0],rdi
       mov       r14,[rdi+30]
       test      r14,r14
       je        near ptr M00_L46
       test      rax,rax
       je        near ptr M00_L45
       mov       [rbp-0B8],rax
       cmp       r14,rax
       je        short M00_L06
       mov       rcx,gs:[58]
       mov       rcx,[rcx+38]
       cmp       dword ptr [rcx+238],2
       jle       near ptr M00_L42
       mov       rcx,[rcx+240]
       mov       rdx,[rcx+10]
       test      rdx,rdx
       je        near ptr M00_L42
M00_L09:
       mov       rcx,[rdx+10]
       test      rcx,rcx
       jne       short M00_L10
       mov       rcx,1B3EA400110
       mov       rcx,[rcx]
       test      rcx,rcx
       jne       short M00_L10
       mov       rcx,1B3EA4000F0
       mov       rcx,[rcx]
       test      rcx,rcx
       je        near ptr M00_L43
M00_L10:
       mov       rdx,[rcx]
       mov       rdx,[rdx+48]
       call      qword ptr [rdx+30]
       cmp       [rax],al
       lea       rdx,[r14+0C]
       mov       [rbp-0C8],r14
       mov       r8d,[r14+8]
       mov       r10,[rbp-0B8]
       lea       r9,[r10+0C]
       mov       [rbp-0B8],r10
       mov       r11d,[r10+8]
       cmp       r8d,r11d
       je        near ptr M00_L15
       mov       [rbp-0B0],r12
M00_L11:
       mov       [rbp-48],rdx
       mov       [rbp-50],r9
       mov       rcx,[rax+20]
       mov       [rsp+20],r11d
       xor       eax,eax
       mov       [rsp+28],eax
       mov       rax,7FFEFF95B650
       mov       [rbp-80],rax
       lea       rax,[M00_L12]
       mov       [rbp-70],rax
       lea       rax,[rbp-90]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFF5F2F93A0
       call      rax
M00_L12:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFF5F64F778],0
       je        short M00_L13
       call      qword ptr [7FFF5F63D608]; CORINFO_HELP_STOP_FOR_GC
M00_L13:
       mov       rcx,[rbp-88]
       mov       [rsi+8],rcx
       xor       ecx,ecx
       mov       [rbp-48],rcx
       mov       [rbp-50],rcx
M00_L14:
       mov       ecx,eax
       mov       r12,[rbp-0B0]
       mov       r14,[rbp-0C8]
       jmp       near ptr M00_L07
M00_L15:
       cmp       rdx,r9
       je        near ptr M00_L44
       mov       [rbp-0B0],r12
       jmp       near ptr M00_L11
M00_L16:
       mov       rdx,[rbp-0C0]
       mov       r10,[rbp-0C8]
       mov       r11,r10
       mov       r12,rdx
       mov       rax,r11
       jmp       short M00_L20
M00_L17:
       cmp       rdx,r9
       je        near ptr M00_L58
       mov       [rbp-0B0],r12
       jmp       near ptr M00_L23
M00_L18:
       xor       ecx,ecx
       mov       [rbp-0B0],r12
M00_L19:
       test      ecx,ecx
       mov       rax,[rbp-0B8]
       mov       r12,[rbp-0B0]
       mov       r14,[rbp-0A8]
       jge       short M00_L16
M00_L20:
       mov       r15,[rbp-98]
       cmp       [r15],r13
       jne       near ptr M00_L48
       mov       edx,[r15+8]
       inc       edx
       cmp       edx,[r15+0C]
       jae       near ptr M00_L27
       mov       [r15+8],edx
       mov       ecx,[r15+8]
       cmp       ecx,[r15+0C]
       jae       near ptr M00_L59
       mov       rcx,[r15+10]
       mov       r8d,[r15+8]
       cmp       r8d,[rcx+8]
       jae       near ptr M00_L60
       mov       edx,r8d
       mov       rcx,[rcx+rdx*8+10]
       mov       rdx,rcx
       mov       rcx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonRecordOrderBy>b__13_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       cmp       [r14+18],rcx
       jne       near ptr M00_L49
       mov       r15,[rbp-98]
       mov       [rbp-0C0],rdx
       mov       rcx,[rdx+30]
       mov       r8,rcx
       mov       rcx,offset MT_System.Collections.Generic.GenericComparer<System.String>
       cmp       [rdi],rcx
       mov       rdi,[rbp-0A0]
       jne       near ptr M00_L51
       test      r8,r8
       je        near ptr M00_L53
       test      rax,rax
       je        near ptr M00_L55
       mov       [rbp-0C8],r8
       mov       [rbp-0B8],rax
       cmp       r8,rax
       je        near ptr M00_L18
       mov       rcx,gs:[58]
       mov       rcx,[rcx+38]
       cmp       dword ptr [rcx+238],2
       jle       near ptr M00_L56
       mov       rcx,[rcx+240]
       mov       r10,[rcx+10]
       test      r10,r10
       je        near ptr M00_L56
M00_L21:
       mov       rcx,[r10+10]
       test      rcx,rcx
       jne       short M00_L22
       mov       rcx,1B3EA400110
       mov       rcx,[rcx]
       test      rcx,rcx
       jne       short M00_L22
       mov       rcx,1B3EA4000F0
       mov       rcx,[rcx]
       test      rcx,rcx
       je        near ptr M00_L57
M00_L22:
       mov       r10,[rcx]
       mov       r10,[r10+48]
       call      qword ptr [r10+30]
       cmp       [rax],al
       mov       r10,[rbp-0C8]
       lea       rdx,[r10+0C]
       mov       [rbp-0C8],r10
       mov       r8d,[r10+8]
       mov       r11,[rbp-0B8]
       lea       r9,[r11+0C]
       mov       [rbp-0B8],r11
       mov       ecx,[r11+8]
       cmp       r8d,ecx
       je        near ptr M00_L17
       mov       [rbp-0B0],r12
M00_L23:
       mov       [rbp-48],rdx
       mov       [rbp-50],r9
       mov       rax,[rax+20]
       mov       [rsp+20],ecx
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rax
       mov       rax,7FFEFF95B650
       mov       [rbp-80],rax
       lea       rax,[M00_L24]
       mov       [rbp-70],rax
       lea       rax,[rbp-90]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFF5F2F93A0
       call      rax
M00_L24:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFF5F64F778],0
       je        short M00_L25
       call      qword ptr [7FFF5F63D608]; CORINFO_HELP_STOP_FOR_GC
M00_L25:
       mov       rcx,[rbp-88]
       mov       [rsi+8],rcx
       xor       ecx,ecx
       mov       [rbp-48],rcx
       mov       [rbp-50],rcx
       mov       rdi,[rbp-0A0]
       mov       r15,[rbp-98]
M00_L26:
       mov       ecx,eax
       jmp       near ptr M00_L19
M00_L27:
       mov       edx,[r15+0C]
       mov       [r15+8],edx
M00_L28:
       mov       dword ptr [rbp-40],1
       jmp       near ptr M00_L62
M00_L29:
       mov       r15,[rbp-98]
       cmp       [r15],r13
       jne       near ptr M00_L32
M00_L30:
       mov       r8d,[r15+8]
       inc       r8d
       cmp       r8d,[r15+0C]
       jae       near ptr M00_L34
       mov       [r15+8],r8d
       mov       edx,[r15+8]
       cmp       edx,[r15+0C]
       mov       [rbp-0B8],rax
       jae       near ptr M00_L41
       mov       rsi,[r15+10]
       mov       r10d,[r15+8]
       cmp       r10d,[rsi+8]
       jae       near ptr M00_L60
       mov       edx,r10d
       mov       rsi,[rsi+rdx*8+10]
       mov       rdx,rsi
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       mov       rcx,rdi
       mov       r8,[rbp-0B8]
       mov       [rbp-0D0],rax
       mov       rdx,rax
       mov       r11,7FFEFF6314F8
       call      qword ptr [r11]
       test      eax,eax
       mov       rax,[rbp-0B8]
       jg        short M00_L30
       mov       r12,[rbp-0D0]
       mov       [rbp-0B8],r12
       mov       r12,rsi
       mov       rax,[rbp-0B8]
       jmp       near ptr M00_L30
M00_L31:
       mov       r12,[rbp-0D0]
       mov       rax,r12
       mov       r12,rsi
M00_L32:
       cmp       [r15],r13
       jne       near ptr M00_L40
       mov       r8d,[r15+8]
       inc       r8d
       cmp       r8d,[r15+0C]
       jae       short M00_L34
       mov       [r15+8],r8d
       mov       ecx,[r15+8]
       cmp       ecx,[r15+0C]
       jae       near ptr M00_L41
       mov       rsi,[r15+10]
       mov       r10d,[r15+8]
       cmp       r10d,[rsi+8]
       jae       near ptr M00_L60
       mov       ecx,r10d
       mov       rsi,[rsi+rcx*8+10]
       mov       [rbp-0B8],rax
M00_L33:
       mov       rdx,rsi
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       mov       rcx,rdi
       mov       r8,[rbp-0B8]
       mov       [rbp-0D0],rax
       mov       rdx,rax
       mov       r11,7FFEFF6314F8
       call      qword ptr [r11]
       test      eax,eax
       mov       rax,[rbp-0B8]
       jg        short M00_L32
       jmp       near ptr M00_L31
M00_L34:
       mov       ecx,[r15+0C]
       mov       [r15+8],ecx
       jmp       near ptr M00_L28
M00_L35:
       mov       ecx,[r12+0C]
       mov       [r12+8],ecx
       jmp       near ptr M00_L61
M00_L36:
       mov       rcx,r12
       mov       r11,7FFEFF6314C0
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M00_L61
       jmp       near ptr M00_L03
M00_L37:
       call      qword ptr [7FFF0000FDC8]
       int       3
M00_L38:
       mov       rcx,r12
       mov       r11,7FFEFF6314C8
       call      qword ptr [r11]
       mov       r12,rax
M00_L39:
       mov       [rbp-0B0],r12
       mov       rdx,r12
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       mov       r12,[rbp-0B0]
       jmp       near ptr M00_L04
M00_L40:
       mov       [rbp-0B8],rax
       mov       rcx,r15
       mov       r11,7FFEFF6314E8
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M00_L28
       mov       rcx,r15
       mov       r11,7FFEFF6314F0
       call      qword ptr [r11]
       mov       rsi,rax
       jmp       near ptr M00_L33
M00_L41:
       mov       ecx,[r15+8]
       call      qword ptr [7FFF0000FDC8]
       int       3
M00_L42:
       mov       ecx,2
       call      qword ptr [7FFEFFEDFB58]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       rdx,rax
       jmp       near ptr M00_L09
M00_L43:
       call      qword ptr [7FFEFF965DA0]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rcx,rax
       jmp       near ptr M00_L10
M00_L44:
       xor       eax,eax
       mov       [rbp-0B0],r12
       jmp       near ptr M00_L14
M00_L45:
       mov       ecx,1
       mov       [rbp-0B8],rax
       jmp       near ptr M00_L07
M00_L46:
       test      rax,rax
       je        short M00_L47
       mov       ecx,0FFFFFFFF
       mov       [rbp-0B8],rax
       jmp       near ptr M00_L07
M00_L47:
       xor       ecx,ecx
       mov       [rbp-0B8],rax
       jmp       near ptr M00_L07
M00_L48:
       mov       [rbp-0B8],rax
       mov       rcx,r15
       mov       r11,7FFEFF6314D0
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M00_L28
       mov       rcx,r15
       mov       r11,7FFEFF6314D8
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       short M00_L50
M00_L49:
       mov       [rbp-0B8],rax
M00_L50:
       mov       [rbp-0C0],rdx
       mov       r14,[rbp-0A8]
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       mov       [rbp-0C8],rax
       mov       rax,[rbp-0B8]
       mov       r15,[rbp-98]
       jmp       short M00_L52
M00_L51:
       mov       [rbp-0C8],r8
M00_L52:
       mov       rcx,rdi
       mov       [rbp-0B8],rax
       mov       r8,rax
       mov       rdx,[rbp-0C8]
       mov       r11,7FFEFF6314E0
       call      qword ptr [r11]
       mov       ecx,eax
       mov       [rbp-0B0],r12
       jmp       near ptr M00_L19
M00_L53:
       mov       [rbp-0B8],rax
       test      rax,rax
       jne       short M00_L54
       mov       rax,[rbp-0B8]
       xor       ecx,ecx
       mov       [rbp-0C8],r8
       mov       [rbp-0B8],rax
       mov       [rbp-0B0],r12
       jmp       near ptr M00_L19
M00_L54:
       mov       rax,[rbp-0B8]
       mov       ecx,0FFFFFFFF
       mov       [rbp-0C8],r8
       mov       [rbp-0B8],rax
       mov       [rbp-0B0],r12
       jmp       near ptr M00_L19
M00_L55:
       mov       ecx,1
       mov       [rbp-0C8],r8
       mov       [rbp-0B8],rax
       mov       [rbp-0B0],r12
       jmp       near ptr M00_L19
M00_L56:
       mov       ecx,2
       call      qword ptr [7FFEFFEDFB58]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       r10,rax
       jmp       near ptr M00_L21
M00_L57:
       call      qword ptr [7FFEFF965DA0]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rcx,rax
       jmp       near ptr M00_L22
M00_L58:
       xor       eax,eax
       mov       [rbp-0B0],r12
       jmp       near ptr M00_L26
M00_L59:
       mov       ecx,[r15+8]
       call      qword ptr [7FFF0000FDC8]
       int       3
M00_L60:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L61:
       xor       ecx,ecx
       mov       [rbp-40],ecx
       xor       r12d,r12d
       mov       r15,[rbp-98]
M00_L62:
       cmp       [r15],r13
       jne       near ptr M00_L70
M00_L63:
       cmp       byte ptr [rbp-40],0
       je        near ptr M00_L71
       mov       [rbp-58],r12
       mov       rbx,[rbp+10]
       mov       r15,[rbx+60]
       mov       rdx,[rbp-58]
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [r15+8],rax
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
M00_L64:
       mov       r13,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord>
       mov       rcx,r13
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       dword ptr [r12+8],0FFFFFFFF
       mov       [r12+0C],r14d
       lea       rcx,[r12+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L02
M00_L65:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdx,1B417400E68
       mov       rdx,[rdx]
       mov       rcx,r14
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonRecordOrderBy>b__13_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       call      qword ptr [7FFEFF6E6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1B417400E78
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L66:
       mov       ecx,11
       call      qword ptr [7FFEFF967DF8]
       int       3
M00_L67:
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L01
M00_L68:
       mov       rcx,rdi
       mov       r11,7FFEFF631508
       call      qword ptr [r11]
       mov       r12,rax
       jmp       near ptr M00_L02
M00_L69:
       mov       r11,7FFEFF6314B8
       call      qword ptr [r11]
       mov       r12,rax
       jmp       near ptr M00_L02
M00_L70:
       mov       rcx,r15
       mov       r11,7FFEFF631500
       call      qword ptr [r11]
       jmp       near ptr M00_L63
M00_L71:
       call      qword ptr [7FFEFFEDCC48]
       int       3
       sub       rsp,38
       vzeroupper
       cmp       qword ptr [rbp-98],0
       je        short M00_L72
       mov       r13,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord>
       mov       r15,[rbp-98]
       cmp       [r15],r13
       je        short M00_L72
       mov       rcx,r15
       mov       r11,7FFEFF631500
       call      qword ptr [r11]
M00_L72:
       nop
       add       rsp,38
       ret
; Total bytes of code 2884
```
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonRecordOrderBy>b__13_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       mov       rax,[rdx+30]
       ret
; Total bytes of code 5
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FFF51600D78]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       ecx,ebx
       and       ecx,0FFFFFF
       mov       edx,ecx
       mov       r8d,ebx
       sar       r8d,18
       jne       short M02_L01
       cmp       [rax],ecx
       jle       short M02_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M02_L03
M02_L00:
       add       rsp,20
       pop       rbx
       ret
M02_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M02_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M02_L00
M02_L02:
       cmp       [rax+4],edx
       jle       short M02_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M02_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M02_L03
       jmp       short M02_L00
M02_L03:
       mov       ecx,ebx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax]
; Total bytes of code 130
```
```assembly
; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       push      rsi
       push      rbx
       sub       rsp,28
       call      qword ptr [7FFF515E87D0]
       mov       rbx,rax
       mov       rsi,rbx
       call      qword ptr [7FFF515FFA88]
       mov       rdx,rax
       test      rsi,rsi
       je        short M03_L00
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFF51600C28]
       mov       rax,[rbx]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M03_L00:
       call      qword ptr [7FFF515FE468]
       int       3
; Total bytes of code 61
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M04_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L00:
       call      qword ptr [7FFF0000D650]
       int       3
; Total bytes of code 44
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M05_L00
       ret
M05_L00:
       jmp       qword ptr [7FFEFF6E5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.PersonRecordOrderBy()
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
       xor       eax,eax
       mov       [rbp-58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp-40],rax
       mov       rbx,rcx
       lea       rcx,[rbp-90]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rcx,rsp
       mov       [rbp-78],rcx
       mov       rcx,rbp
       mov       [rbp-68],rcx
       mov       [rbp+10],rbx
       mov       rdi,[rbx+280]
       mov       rcx,2DDF9400EE0
       mov       r14,[rcx]
       test      r14,r14
       je        near ptr M00_L63
M00_L00:
       mov       rcx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [r15+10],eax
       lea       rcx,[r15+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        near ptr M00_L64
       xor       ecx,ecx
       mov       [r15+20],rcx
       lea       rcx,[r15+28]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,2DDCC400A08
       mov       rdx,[rcx]
       lea       rcx,[r15+30]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [r15+48],0
       mov       rcx,[r15+18]
       mov       r11,offset MT_System.Collections.ObjectModel.Collection<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord>
       cmp       [rcx],r11
       jne       near ptr M00_L65
       mov       rcx,[rcx+8]
       mov       r11,7FFEFF6418E8
       call      qword ptr [r11]
       mov       rdi,rax
M00_L01:
       mov       [rbp-98],rdi
       mov       r14,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord>
       cmp       [rdi],r14
       jne       near ptr M00_L35
       mov       ecx,[rdi+8]
       inc       ecx
       cmp       ecx,[rdi+0C]
       jae       near ptr M00_L34
       mov       [rdi+8],ecx
M00_L02:
       mov       r13,[r15+30]
       mov       [rbp-0A0],r13
       mov       r12,[r15+28]
       mov       [rbp-0A8],r12
       cmp       [rdi],r14
       jne       near ptr M00_L37
       mov       ecx,[rdi+8]
       cmp       ecx,[rdi+0C]
       jae       near ptr M00_L36
       mov       rax,[rdi+10]
       cmp       ecx,[rax+8]
       jae       near ptr M00_L59
       mov       rdi,[rax+rcx*8+10]
       mov       rcx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonRecordOrderBy>b__13_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       cmp       [r12+18],rcx
       jne       near ptr M00_L38
       mov       rax,[rdi+30]
M00_L03:
       cmp       byte ptr [r15+48],0
       jne       near ptr M00_L28
       test      r12,r12
       je        near ptr M00_L19
       test      r13,r13
       je        near ptr M00_L19
       mov       r15,[rbp-98]
       cmp       [r15],r14
       jne       near ptr M00_L19
       mov       rcx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonRecordOrderBy>b__13_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       cmp       [r12+18],rcx
       jne       near ptr M00_L19
       mov       rcx,offset MT_System.Collections.Generic.GenericComparer<System.String>
       cmp       [r13],rcx
       jne       near ptr M00_L19
       jmp       short M00_L07
M00_L04:
       mov       r13,[rbp-0C0]
       mov       rax,r12
       mov       [rbp-0B0],r13
       mov       rdi,[rbp-0B0]
       jmp       short M00_L07
M00_L05:
       xor       ecx,ecx
M00_L06:
       test      ecx,ecx
       mov       rax,[rbp-0B8]
       mov       r15,[rbp-98]
       jge       short M00_L04
M00_L07:
       mov       edx,[r15+8]
       inc       edx
       cmp       edx,[r15+0C]
       jae       near ptr M00_L26
       mov       [r15+8],edx
       mov       r8d,[r15+8]
       cmp       r8d,[r15+0C]
       jae       near ptr M00_L58
       mov       r12,[r15+10]
       cmp       r8d,[r12+8]
       jae       near ptr M00_L59
       mov       ecx,r8d
       mov       r13,[r12+rcx*8+10]
       mov       [rbp-0C0],r13
       mov       r12,[r13+30]
       test      r12,r12
       je        near ptr M00_L45
       test      rax,rax
       je        near ptr M00_L44
       mov       [rbp-0B8],rax
       cmp       r12,rax
       je        short M00_L05
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+238],2
       jle       near ptr M00_L41
       mov       rcx,[rcx+240]
       mov       rdx,[rcx+10]
       test      rdx,rdx
       je        near ptr M00_L41
M00_L08:
       mov       rcx,[rdx+10]
       test      rcx,rcx
       jne       short M00_L09
       mov       rcx,2DDCC400110
       mov       rcx,[rcx]
       test      rcx,rcx
       jne       short M00_L09
       mov       rcx,2DDCC4000F0
       mov       rcx,[rcx]
       test      rcx,rcx
       je        near ptr M00_L42
M00_L09:
       mov       rdx,[rcx]
       mov       rdx,[rdx+48]
       call      qword ptr [rdx+30]
       cmp       [rax],al
       lea       rdx,[r12+0C]
       mov       [rbp-0C8],r12
       mov       r8d,[r12+8]
       mov       r10,[rbp-0B8]
       lea       r9,[r10+0C]
       mov       [rbp-0B8],r10
       mov       r11d,[r10+8]
       cmp       r8d,r11d
       je        near ptr M00_L14
       mov       [rbp-0B0],rdi
M00_L10:
       mov       [rbp-48],rdx
       mov       [rbp-50],r9
       mov       rcx,[rax+20]
       mov       [rsp+20],r11d
       xor       eax,eax
       mov       [rsp+28],eax
       mov       rax,7FFEFF96B650
       mov       [rbp-80],rax
       lea       rax,[M00_L11]
       mov       [rbp-70],rax
       lea       rax,[rbp-90]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFF5F2F93A0
       call      rax
M00_L11:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFF5F64F778],0
       je        short M00_L12
       call      qword ptr [7FFF5F63D608]; CORINFO_HELP_STOP_FOR_GC
M00_L12:
       mov       rcx,[rbp-88]
       mov       [rsi+8],rcx
       xor       ecx,ecx
       mov       [rbp-48],rcx
       mov       [rbp-50],rcx
M00_L13:
       mov       ecx,eax
       mov       rdi,[rbp-0B0]
       mov       r12,[rbp-0C8]
       jmp       near ptr M00_L06
M00_L14:
       cmp       rdx,r9
       je        near ptr M00_L43
       mov       [rbp-0B0],rdi
       jmp       near ptr M00_L10
M00_L15:
       mov       rdx,[rbp-0C0]
       mov       r10,[rbp-0C8]
       mov       r11,r10
       mov       rdi,rdx
       mov       rax,r11
       jmp       short M00_L19
M00_L16:
       cmp       rdx,r9
       je        near ptr M00_L57
       mov       [rbp-0B0],rdi
       jmp       near ptr M00_L22
M00_L17:
       xor       ecx,ecx
       mov       [rbp-0B0],rdi
M00_L18:
       test      ecx,ecx
       mov       rax,[rbp-0B8]
       mov       rdi,[rbp-0B0]
       mov       r12,[rbp-0A8]
       jge       short M00_L15
M00_L19:
       mov       r15,[rbp-98]
       cmp       [r15],r14
       jne       near ptr M00_L47
       mov       edx,[r15+8]
       inc       edx
       cmp       edx,[r15+0C]
       jae       near ptr M00_L26
       mov       [r15+8],edx
       mov       ecx,[r15+8]
       cmp       ecx,[r15+0C]
       jae       near ptr M00_L58
       mov       rcx,[r15+10]
       mov       r8d,[r15+8]
       cmp       r8d,[rcx+8]
       jae       near ptr M00_L59
       mov       edx,r8d
       mov       rcx,[rcx+rdx*8+10]
       mov       rdx,rcx
       mov       rcx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonRecordOrderBy>b__13_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       cmp       [r12+18],rcx
       jne       near ptr M00_L48
       mov       r15,[rbp-98]
       mov       [rbp-0C0],rdx
       mov       rcx,[rdx+30]
       mov       r8,rcx
       mov       rcx,offset MT_System.Collections.Generic.GenericComparer<System.String>
       cmp       [r13],rcx
       mov       r13,[rbp-0A0]
       jne       near ptr M00_L50
       test      r8,r8
       je        near ptr M00_L52
       test      rax,rax
       je        near ptr M00_L54
       mov       [rbp-0C8],r8
       mov       [rbp-0B8],rax
       cmp       r8,rax
       je        near ptr M00_L17
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+238],2
       jle       near ptr M00_L55
       mov       rcx,[rcx+240]
       mov       r10,[rcx+10]
       test      r10,r10
       je        near ptr M00_L55
M00_L20:
       mov       rcx,[r10+10]
       test      rcx,rcx
       jne       short M00_L21
       mov       rcx,2DDCC400110
       mov       rcx,[rcx]
       test      rcx,rcx
       jne       short M00_L21
       mov       rcx,2DDCC4000F0
       mov       rcx,[rcx]
       test      rcx,rcx
       je        near ptr M00_L56
M00_L21:
       mov       r10,[rcx]
       mov       r10,[r10+48]
       call      qword ptr [r10+30]
       cmp       [rax],al
       mov       r10,[rbp-0C8]
       lea       rdx,[r10+0C]
       mov       [rbp-0C8],r10
       mov       r8d,[r10+8]
       mov       r11,[rbp-0B8]
       lea       r9,[r11+0C]
       mov       [rbp-0B8],r11
       mov       ecx,[r11+8]
       cmp       r8d,ecx
       je        near ptr M00_L16
       mov       [rbp-0B0],rdi
M00_L22:
       mov       [rbp-48],rdx
       mov       [rbp-50],r9
       mov       rax,[rax+20]
       mov       [rsp+20],ecx
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rax
       mov       rax,7FFEFF96B650
       mov       [rbp-80],rax
       lea       rax,[M00_L23]
       mov       [rbp-70],rax
       lea       rax,[rbp-90]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFF5F2F93A0
       call      rax
M00_L23:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFF5F64F778],0
       je        short M00_L24
       call      qword ptr [7FFF5F63D608]; CORINFO_HELP_STOP_FOR_GC
M00_L24:
       mov       rcx,[rbp-88]
       mov       [rsi+8],rcx
       xor       ecx,ecx
       mov       [rbp-48],rcx
       mov       [rbp-50],rcx
       mov       r13,[rbp-0A0]
       mov       r15,[rbp-98]
M00_L25:
       mov       ecx,eax
       jmp       near ptr M00_L18
M00_L26:
       mov       edx,[r15+0C]
       mov       [r15+8],edx
M00_L27:
       mov       dword ptr [rbp-40],1
       jmp       near ptr M00_L61
M00_L28:
       mov       r15,[rbp-98]
       cmp       [r15],r14
       jne       near ptr M00_L31
M00_L29:
       mov       r8d,[r15+8]
       inc       r8d
       cmp       r8d,[r15+0C]
       jae       near ptr M00_L33
       mov       [r15+8],r8d
       mov       edx,[r15+8]
       cmp       edx,[r15+0C]
       mov       [rbp-0B8],rax
       jae       near ptr M00_L40
       mov       rsi,[r15+10]
       mov       r10d,[r15+8]
       cmp       r10d,[rsi+8]
       jae       near ptr M00_L59
       mov       edx,r10d
       mov       rsi,[rsi+rdx*8+10]
       mov       rdx,rsi
       mov       rcx,[r12+8]
       call      qword ptr [r12+18]
       mov       rcx,r13
       mov       r8,[rbp-0B8]
       mov       [rbp-0D0],rax
       mov       rdx,rax
       mov       r11,7FFEFF6418D8
       call      qword ptr [r11]
       test      eax,eax
       mov       rax,[rbp-0B8]
       jg        short M00_L29
       mov       rdi,[rbp-0D0]
       mov       [rbp-0B8],rdi
       mov       rdi,rsi
       mov       rax,[rbp-0B8]
       jmp       near ptr M00_L29
M00_L30:
       mov       rdi,[rbp-0D0]
       mov       rax,rdi
       mov       rdi,rsi
M00_L31:
       cmp       [r15],r14
       jne       near ptr M00_L39
       mov       r8d,[r15+8]
       inc       r8d
       cmp       r8d,[r15+0C]
       jae       short M00_L33
       mov       [r15+8],r8d
       mov       ecx,[r15+8]
       cmp       ecx,[r15+0C]
       jae       near ptr M00_L40
       mov       rsi,[r15+10]
       mov       r10d,[r15+8]
       cmp       r10d,[rsi+8]
       jae       near ptr M00_L59
       mov       ecx,r10d
       mov       rsi,[rsi+rcx*8+10]
       mov       [rbp-0B8],rax
M00_L32:
       mov       rdx,rsi
       mov       rcx,[r12+8]
       call      qword ptr [r12+18]
       mov       rcx,r13
       mov       r8,[rbp-0B8]
       mov       [rbp-0D0],rax
       mov       rdx,rax
       mov       r11,7FFEFF6418D8
       call      qword ptr [r11]
       test      eax,eax
       mov       rax,[rbp-0B8]
       jg        near ptr M00_L31
       jmp       near ptr M00_L30
M00_L33:
       mov       ecx,[r15+0C]
       mov       [r15+8],ecx
       jmp       near ptr M00_L27
M00_L34:
       mov       ecx,[rdi+0C]
       mov       [rdi+8],ecx
       jmp       near ptr M00_L60
M00_L35:
       mov       rcx,rdi
       mov       r11,7FFEFF6418A0
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M00_L60
       jmp       near ptr M00_L02
M00_L36:
       call      qword ptr [7FFF001D4AC8]
       int       3
M00_L37:
       mov       rcx,rdi
       mov       r11,7FFEFF6418A8
       call      qword ptr [r11]
       mov       rdi,rax
M00_L38:
       mov       [rbp-0B0],rdi
       mov       rdx,rdi
       mov       rcx,[r12+8]
       call      qword ptr [r12+18]
       mov       rdi,[rbp-0B0]
       jmp       near ptr M00_L03
M00_L39:
       mov       [rbp-0B8],rax
       mov       rcx,r15
       mov       r11,7FFEFF6418C8
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M00_L27
       mov       rcx,r15
       mov       r11,7FFEFF6418D0
       call      qword ptr [r11]
       mov       rsi,rax
       jmp       near ptr M00_L32
M00_L40:
       mov       ecx,[r15+8]
       call      qword ptr [7FFF001D4AC8]
       int       3
M00_L41:
       mov       ecx,2
       call      qword ptr [7FFEFFE8C8D0]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       rdx,rax
       jmp       near ptr M00_L08
M00_L42:
       call      qword ptr [7FFEFF975DA0]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rcx,rax
       jmp       near ptr M00_L09
M00_L43:
       xor       eax,eax
       mov       [rbp-0B0],rdi
       jmp       near ptr M00_L13
M00_L44:
       mov       ecx,1
       mov       [rbp-0B8],rax
       jmp       near ptr M00_L06
M00_L45:
       test      rax,rax
       je        short M00_L46
       mov       ecx,0FFFFFFFF
       mov       [rbp-0B8],rax
       jmp       near ptr M00_L06
M00_L46:
       xor       ecx,ecx
       mov       [rbp-0B8],rax
       jmp       near ptr M00_L06
M00_L47:
       mov       [rbp-0B8],rax
       mov       rcx,r15
       mov       r11,7FFEFF6418B0
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M00_L27
       mov       rcx,r15
       mov       r11,7FFEFF6418B8
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       short M00_L49
M00_L48:
       mov       [rbp-0B8],rax
M00_L49:
       mov       [rbp-0C0],rdx
       mov       r12,[rbp-0A8]
       mov       rcx,[r12+8]
       call      qword ptr [r12+18]
       mov       [rbp-0C8],rax
       mov       rax,[rbp-0B8]
       mov       r15,[rbp-98]
       jmp       short M00_L51
M00_L50:
       mov       [rbp-0C8],r8
M00_L51:
       mov       rcx,r13
       mov       [rbp-0B8],rax
       mov       r8,rax
       mov       rdx,[rbp-0C8]
       mov       r11,7FFEFF6418C0
       call      qword ptr [r11]
       mov       ecx,eax
       mov       [rbp-0B0],rdi
       jmp       near ptr M00_L18
M00_L52:
       mov       [rbp-0B8],rax
       test      rax,rax
       jne       short M00_L53
       mov       rax,[rbp-0B8]
       xor       ecx,ecx
       mov       [rbp-0C8],r8
       mov       [rbp-0B8],rax
       mov       [rbp-0B0],rdi
       jmp       near ptr M00_L18
M00_L53:
       mov       rax,[rbp-0B8]
       mov       ecx,0FFFFFFFF
       mov       [rbp-0C8],r8
       mov       [rbp-0B8],rax
       mov       [rbp-0B0],rdi
       jmp       near ptr M00_L18
M00_L54:
       mov       ecx,1
       mov       [rbp-0C8],r8
       mov       [rbp-0B8],rax
       mov       [rbp-0B0],rdi
       jmp       near ptr M00_L18
M00_L55:
       mov       ecx,2
       call      qword ptr [7FFEFFE8C8D0]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       r10,rax
       jmp       near ptr M00_L20
M00_L56:
       call      qword ptr [7FFEFF975DA0]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rcx,rax
       jmp       near ptr M00_L21
M00_L57:
       xor       eax,eax
       mov       [rbp-0B0],rdi
       jmp       near ptr M00_L25
M00_L58:
       mov       ecx,[r15+8]
       call      qword ptr [7FFF001D4AC8]
       int       3
M00_L59:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L60:
       xor       ecx,ecx
       mov       [rbp-40],ecx
       xor       edi,edi
       mov       r15,[rbp-98]
M00_L61:
       cmp       [r15],r14
       jne       near ptr M00_L66
M00_L62:
       cmp       byte ptr [rbp-40],0
       je        near ptr M00_L67
       mov       [rbp-58],rdi
       mov       rbx,[rbp+10]
       mov       r15,[rbx+60]
       mov       rdx,[rbp-58]
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [r15+8],rax
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
M00_L63:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdx,2DDF9400ED0
       mov       rdx,[rdx]
       mov       rcx,r14
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonRecordOrderBy>b__13_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       call      qword ptr [7FFEFF6F6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,2DDF9400EE0
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L64:
       mov       ecx,11
       call      qword ptr [7FFEFF977DF8]
       int       3
M00_L65:
       mov       r11,7FFEFF641898
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L01
M00_L66:
       mov       rcx,r15
       mov       r11,7FFEFF6418E0
       call      qword ptr [r11]
       jmp       near ptr M00_L62
M00_L67:
       call      qword ptr [7FFEFFF0FAE0]
       int       3
       sub       rsp,38
       vzeroupper
       cmp       qword ptr [rbp-98],0
       je        short M00_L68
       mov       r14,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord>
       mov       r15,[rbp-98]
       cmp       [r15],r14
       je        short M00_L68
       mov       rcx,r15
       mov       r11,7FFEFF6418E0
       call      qword ptr [r11]
M00_L68:
       nop
       add       rsp,38
       ret
; Total bytes of code 2743
```
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonRecordOrderBy>b__13_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       mov       rax,[rdx+30]
       ret
; Total bytes of code 5
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FFF51600D78]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       ecx,ebx
       and       ecx,0FFFFFF
       mov       edx,ecx
       mov       r8d,ebx
       sar       r8d,18
       jne       short M02_L01
       cmp       [rax],ecx
       jle       short M02_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M02_L03
M02_L00:
       add       rsp,20
       pop       rbx
       ret
M02_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M02_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M02_L00
M02_L02:
       cmp       [rax+4],edx
       jle       short M02_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M02_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M02_L03
       jmp       short M02_L00
M02_L03:
       mov       ecx,ebx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax]
; Total bytes of code 130
```
```assembly
; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       push      rsi
       push      rbx
       sub       rsp,28
       call      qword ptr [7FFF515E87D0]
       mov       rbx,rax
       mov       rsi,rbx
       call      qword ptr [7FFF515FFA88]
       mov       rdx,rax
       test      rsi,rsi
       je        short M03_L00
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFF51600C28]
       mov       rax,[rbx]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M03_L00:
       call      qword ptr [7FFF515FE468]
       int       3
; Total bytes of code 61
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M04_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L00:
       call      qword ptr [7FFEFFF06388]
       int       3
; Total bytes of code 44
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateCollection()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+70]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       xor       eax,eax
       mov       [rbp-40],rax
       mov       rbx,rcx
       mov       esi,[rbx+268]
       mov       byte ptr [rbp-40],1
       mov       dword ptr [rbp-3C],2
       test      esi,esi
       setg      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M00_L10
M00_L00:
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Coordinate>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       test      esi,esi
       jl        near ptr M00_L13
       test      esi,esi
       je        near ptr M00_L14
       mov       edx,esi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Coordinate[]
       call      CORINFO_HELP_NEWARR_1_PTR
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M00_L01:
       xor       r14d,r14d
       cmp       r14d,esi
       jl        near ptr M00_L09
M00_L02:
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Coordinate>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp-50],rsi
       mov       rbx,[rbx+60]
       mov       rdx,[rbp-50]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L03:
       call      qword ptr [7FFEFF707C00]; System.RuntimeType.CreateInstanceOfT()
       mov       r15,rax
M00_L04:
       xor       ecx,ecx
       mov       [rbp-48],rcx
       mov       ecx,80000000
       mov       edx,7FFFFFFF
       call      qword ptr [7FFEFFD1E070]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       mov       r13,[r15]
       mov       r12,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Coordinate
       cmp       r13,r12
       jne       near ptr M00_L15
       mov       [r15+8],eax
M00_L05:
       mov       ecx,80000000
       mov       edx,7FFFFFFF
       call      qword ptr [7FFEFFD1E070]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       cmp       r13,r12
       jne       near ptr M00_L16
       mov       [r15+0C],eax
M00_L06:
       mov       ecx,80000000
       mov       edx,7FFFFFFF
       call      qword ptr [7FFEFFD1E070]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       cmp       r13,r12
       jne       near ptr M00_L17
       mov       [r15+10],eax
M00_L07:
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       edx,[rdi+10]
       cmp       [rcx+8],edx
       jbe       near ptr M00_L18
       lea       r8d,[rdx+1]
       mov       [rdi+10],r8d
       mov       r8,r15
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
M00_L08:
       add       r14d,1
       jo        near ptr M00_L19
       cmp       r14d,esi
       jge       near ptr M00_L02
M00_L09:
       mov       rcx,1B37D880818
       mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Coordinate
       mov       eax,[rax]
       and       eax,0C0000
       cmp       eax,40000
       sete      al
       movzx     eax,al
       test      eax,eax
       je        near ptr M00_L03
       xor       edx,edx
       mov       [rbp-48],rdx
       lea       rdx,[rbp-48]
       call      qword ptr [7FFF000577F8]
       mov       r15,[rbp-48]
       jmp       near ptr M00_L04
M00_L10:
       movzx     ecx,byte ptr [rbp-40]
       test      cl,cl
       je        short M00_L11
       lea       rcx,[rbp-40]
       call      qword ptr [7FFEFFD1E478]
       mov       esi,eax
       jmp       near ptr M00_L00
M00_L11:
       call      qword ptr [7FFEFFD1E490]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L12
       call      qword ptr [7FFF00057DC8]
       mov       rbx,rax
M00_L12:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,1B37D873620
       call      qword ptr [7FFEFF98DEC0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L13:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FFEFF98EEE0]
       int       3
M00_L14:
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Coordinate>
       call      qword ptr [7FFEFF705728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,172E8802E60
       mov       rdx,[rcx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L01
M00_L15:
       mov       rcx,r15
       mov       edx,eax
       mov       r11,7FFEFF650DB0
       call      qword ptr [r11]
       jmp       near ptr M00_L05
M00_L16:
       mov       rcx,r15
       mov       edx,eax
       mov       r11,7FFEFF650DB8
       call      qword ptr [r11]
       jmp       near ptr M00_L06
M00_L17:
       mov       rcx,r15
       mov       edx,eax
       mov       r11,7FFEFF650DC0
       call      qword ptr [r11]
       jmp       near ptr M00_L07
M00_L18:
       mov       rcx,rdi
       mov       rdx,r15
       call      qword ptr [7FFEFF8AE370]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M00_L08
       int       3
M00_L19:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       int       3
; Total bytes of code 716
```
```assembly
; System.RuntimeType.CreateInstanceOfT()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       lea       rbp,[rsp+40]
       mov       rbx,rcx
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M01_L02
       mov       rax,[rcx]
       test      rax,rax
       je        short M01_L02
M01_L00:
       mov       rdx,[rax+80]
       test      rdx,rdx
       je        short M01_L04
       mov       rcx,[rdx]
       mov       rax,offset MT_System.RuntimeType+ActivatorCache
       cmp       rcx,rax
       jne       short M01_L03
       mov       rsi,rdx
M01_L01:
       cmp       byte ptr [rsi+28],0
       je        short M01_L05
       mov       rax,[rsi+8]
       mov       rcx,[rsi+10]
       call      rax
       mov       rdi,rax
       mov       rax,[rsi+18]
       mov       rcx,rdi
       call      rax
       nop
       mov       rax,rdi
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L02:
       mov       rcx,rbx
       call      qword ptr [7FFEFF707C60]; System.RuntimeType.InitializeCache()
       jmp       short M01_L00
M01_L03:
       mov       rax,offset MT_System.RuntimeType+CompositeCacheEntry
       cmp       rcx,rax
       jne       short M01_L04
       mov       rsi,[rdx+8]
       test      rsi,rsi
       je        short M01_L04
       jmp       short M01_L01
M01_L04:
       mov       rdx,rbx
       mov       rcx,offset MT_System.RuntimeType+IGenericCacheEntry<System.RuntimeType+ActivatorCache>
       call      qword ptr [7FFEFF70C528]; System.RuntimeType+IGenericCacheEntry`1[[System.__Canon, System.Private.CoreLib]].CreateAndCache(System.RuntimeType)
       mov       rsi,rax
       jmp       short M01_L01
M01_L05:
       mov       rcx,offset MT_System.MissingMethodException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF00057840]
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFF00057858]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF00057870]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
       sub       rsp,28
       mov       rdi,rcx
       mov       rcx,offset MT_System.Reflection.TargetInvocationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,rdi
       call      qword ptr [7FFF00057888]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 271
```
```assembly
; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,68
       vzeroupper
       lea       rbp,[rsp+0A0]
       xor       eax,eax
       mov       [rbp-48],rax
       mov       ebx,ecx
       mov       esi,edx
       lea       rcx,[rbp-80]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rdi,rax
       mov       rdx,rsp
       mov       [rbp-68],rdx
       mov       rdx,rbp
       mov       [rbp-58],rdx
       cmp       ebx,esi
       jge       near ptr M02_L04
       sub       esi,ebx
       dec       esi
       je        near ptr M02_L05
       mov       r14d,esi
       shr       r14d,1
       or        r14d,esi
       mov       edx,r14d
       shr       edx,2
       or        r14d,edx
       mov       edx,r14d
       shr       edx,4
       or        r14d,edx
       mov       edx,r14d
       shr       edx,8
       or        r14d,edx
       mov       edx,r14d
       shr       edx,10
       or        r14d,edx
       xor       edx,edx
       mov       [rbp-3C],edx
M02_L00:
       lea       rdx,[rbp-3C]
       mov       [rbp-48],rdx
       lea       rdx,[rbp-3C]
       mov       r8d,4
       xor       ecx,ecx
       mov       r9d,2
       mov       rax,7FFEFFDB0488
       mov       [rbp-70],rax
       lea       rax,[M02_L01]
       mov       [rbp-60],rax
       lea       rax,[rbp-80]
       mov       [rdi+8],rax
       mov       byte ptr [rdi+4],0
       mov       rax,7FFF8CB23670
       call      rax
M02_L01:
       mov       byte ptr [rdi+4],1
       cmp       dword ptr [7FFF5F64F778],0
       je        short M02_L02
       call      qword ptr [7FFF5F63D608]; CORINFO_HELP_STOP_FOR_GC
M02_L02:
       mov       rcx,[rbp-78]
       mov       [rdi+8],rcx
       test      eax,eax
       jne       short M02_L06
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-48],rax
       mov       eax,r14d
       and       eax,[rbp-3C]
       cmp       eax,esi
       ja        short M02_L00
       add       eax,ebx
M02_L03:
       add       rsp,68
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L04:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF00057678]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFEFFC5E6E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M02_L05:
       mov       eax,ebx
       jmp       short M02_L03
M02_L06:
       mov       ecx,eax
       call      qword ptr [7FFF00057690]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 342
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       sub       rsp,28
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M03_L01
       lea       rax,[rcx+rdx*8+10]
       mov       rdx,[rcx]
       mov       rdx,[rdx+30]
       test      r8,r8
       je        short M03_L02
       cmp       rdx,[r8]
       jne       short M03_L03
M03_L00:
       mov       rcx,rax
       mov       rdx,r8
       add       rsp,28
       jmp       near ptr 00007FFF5F337B10
M03_L01:
       call      qword ptr [7FFF00057708]
       int       3
M03_L02:
       xor       ecx,ecx
       mov       [rax],rcx
       add       rsp,28
       ret
M03_L03:
       mov       r10,offset MT_System.Object[]
       cmp       [rcx],r10
       je        short M03_L00
       mov       rcx,rax
       add       rsp,28
       jmp       qword ptr [7FFEFF70D908]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
; Total bytes of code 94
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M04_L00
       ret
M04_L00:
       jmp       qword ptr [7FFEFF705C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,[rbx+10]
       lea       ebp,[rdi+1]
       mov       ecx,ebp
       mov       rdx,[rbx+8]
       cmp       dword ptr [rdx+8],0
       jne       short M05_L01
       mov       edx,4
M05_L00:
       mov       eax,7FFFFFC7
       cmp       edx,7FFFFFC7
       cmova     edx,eax
       cmp       edx,ecx
       cmovl     edx,ecx
       mov       rcx,rbx
       call      qword ptr [7FFF5160DD70]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
       mov       [rbx+10],ebp
       mov       rcx,[rbx+8]
       movsxd    rdx,edi
       mov       r8,rsi
       call      qword ptr [7FFF515E7FF0]; Precode of System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M05_L01:
       mov       rdx,[rbx+8]
       mov       edx,[rdx+8]
       add       edx,edx
       jmp       short M05_L00
; Total bytes of code 105
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateCollection()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+70]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       xor       eax,eax
       mov       [rbp-40],rax
       mov       rbx,rcx
       mov       esi,[rbx+268]
       mov       byte ptr [rbp-40],1
       mov       dword ptr [rbp-3C],2
       test      esi,esi
       setg      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M00_L10
M00_L00:
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Coordinate>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       test      esi,esi
       jl        near ptr M00_L13
       test      esi,esi
       je        near ptr M00_L14
       mov       edx,esi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Coordinate[]
       call      CORINFO_HELP_NEWARR_1_PTR
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M00_L01:
       xor       r14d,r14d
       cmp       r14d,esi
       jl        near ptr M00_L09
M00_L02:
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Coordinate>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp-50],rsi
       mov       rbx,[rbx+60]
       mov       rdx,[rbp-50]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L03:
       xor       edx,edx
       mov       [rbp-48],rdx
       lea       rdx,[rbp-48]
       call      qword ptr [7FFF00067720]
       mov       r15,[rbp-48]
M00_L04:
       xor       ecx,ecx
       mov       [rbp-48],rcx
       mov       ecx,80000000
       mov       edx,7FFFFFFF
       call      qword ptr [7FFEFFD2E070]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       mov       r13,[r15]
       mov       r12,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Coordinate
       cmp       r13,r12
       jne       near ptr M00_L15
       mov       [r15+8],eax
M00_L05:
       mov       ecx,80000000
       mov       edx,7FFFFFFF
       call      qword ptr [7FFEFFD2E070]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       cmp       r13,r12
       jne       near ptr M00_L16
       mov       [r15+0C],eax
M00_L06:
       mov       ecx,80000000
       mov       edx,7FFFFFFF
       call      qword ptr [7FFEFFD2E070]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       cmp       r13,r12
       jne       near ptr M00_L17
       mov       [r15+10],eax
M00_L07:
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       edx,[rdi+10]
       cmp       [rcx+8],edx
       jbe       near ptr M00_L18
       lea       r8d,[rdx+1]
       mov       [rdi+10],r8d
       mov       r8,r15
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
M00_L08:
       add       r14d,1
       jo        near ptr M00_L19
       cmp       r14d,esi
       jge       near ptr M00_L02
M00_L09:
       mov       rcx,22ADC490818
       mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Coordinate
       mov       eax,[rax]
       and       eax,0C0000
       cmp       eax,40000
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M00_L03
       call      qword ptr [7FFEFF717C00]; System.RuntimeType.CreateInstanceOfT()
       mov       r15,rax
       jmp       near ptr M00_L04
M00_L10:
       movzx     ecx,byte ptr [rbp-40]
       test      cl,cl
       je        short M00_L11
       lea       rcx,[rbp-40]
       call      qword ptr [7FFEFFD2E478]
       mov       esi,eax
       jmp       near ptr M00_L00
M00_L11:
       call      qword ptr [7FFEFFD2E490]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L12
       call      qword ptr [7FFF00067CF0]
       mov       rbx,rax
M00_L12:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,22ADC483620
       call      qword ptr [7FFEFF99DEC0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L13:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FFEFF99EEE0]
       int       3
M00_L14:
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Coordinate>
       call      qword ptr [7FFEFF715728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1EA74400E68
       mov       rdx,[rcx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L01
M00_L15:
       mov       rcx,r15
       mov       edx,eax
       mov       r11,7FFEFF660DB0
       call      qword ptr [r11]
       jmp       near ptr M00_L05
M00_L16:
       mov       rcx,r15
       mov       edx,eax
       mov       r11,7FFEFF660DB8
       call      qword ptr [r11]
       jmp       near ptr M00_L06
M00_L17:
       mov       rcx,r15
       mov       edx,eax
       mov       r11,7FFEFF660DC0
       call      qword ptr [r11]
       jmp       near ptr M00_L07
M00_L18:
       mov       rcx,rdi
       mov       rdx,r15
       call      qword ptr [7FFEFF8BE370]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M00_L08
       int       3
M00_L19:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       int       3
; Total bytes of code 716
```
```assembly
; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,68
       vzeroupper
       lea       rbp,[rsp+0A0]
       xor       eax,eax
       mov       [rbp-48],rax
       mov       ebx,ecx
       mov       esi,edx
       lea       rcx,[rbp-80]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rdi,rax
       mov       rdx,rsp
       mov       [rbp-68],rdx
       mov       rdx,rbp
       mov       [rbp-58],rdx
       cmp       ebx,esi
       jge       near ptr M01_L04
       sub       esi,ebx
       dec       esi
       je        near ptr M01_L05
       mov       r14d,esi
       shr       r14d,1
       or        r14d,esi
       mov       edx,r14d
       shr       edx,2
       or        r14d,edx
       mov       edx,r14d
       shr       edx,4
       or        r14d,edx
       mov       edx,r14d
       shr       edx,8
       or        r14d,edx
       mov       edx,r14d
       shr       edx,10
       or        r14d,edx
       xor       edx,edx
       mov       [rbp-3C],edx
M01_L00:
       lea       rdx,[rbp-3C]
       mov       [rbp-48],rdx
       lea       rdx,[rbp-3C]
       mov       r8d,4
       xor       ecx,ecx
       mov       r9d,2
       mov       rax,7FFEFFDC0488
       mov       [rbp-70],rax
       lea       rax,[M01_L01]
       mov       [rbp-60],rax
       lea       rax,[rbp-80]
       mov       [rdi+8],rax
       mov       byte ptr [rdi+4],0
       mov       rax,7FFF8CB23670
       call      rax
M01_L01:
       mov       byte ptr [rdi+4],1
       cmp       dword ptr [7FFF5F64F778],0
       je        short M01_L02
       call      qword ptr [7FFF5F63D608]; CORINFO_HELP_STOP_FOR_GC
M01_L02:
       mov       rcx,[rbp-78]
       mov       [rdi+8],rcx
       test      eax,eax
       jne       short M01_L06
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-48],rax
       mov       eax,r14d
       and       eax,[rbp-3C]
       cmp       eax,esi
       ja        short M01_L00
       add       eax,ebx
M01_L03:
       add       rsp,68
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L04:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF000675A0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFEFFC6E6E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L05:
       mov       eax,ebx
       jmp       short M01_L03
M01_L06:
       mov       ecx,eax
       call      qword ptr [7FFF000675B8]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 342
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       sub       rsp,28
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M02_L01
       lea       rax,[rcx+rdx*8+10]
       mov       rdx,[rcx]
       mov       rdx,[rdx+30]
       test      r8,r8
       je        short M02_L02
       cmp       rdx,[r8]
       jne       short M02_L03
M02_L00:
       mov       rcx,rax
       mov       rdx,r8
       add       rsp,28
       jmp       near ptr 00007FFF5F337B10
M02_L01:
       call      qword ptr [7FFF00067630]
       int       3
M02_L02:
       xor       ecx,ecx
       mov       [rax],rcx
       add       rsp,28
       ret
M02_L03:
       mov       r10,offset MT_System.Object[]
       cmp       [rcx],r10
       je        short M02_L00
       mov       rcx,rax
       add       rsp,28
       jmp       qword ptr [7FFEFF71D908]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
; Total bytes of code 94
```
```assembly
; System.RuntimeType.CreateInstanceOfT()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       lea       rbp,[rsp+40]
       mov       rbx,rcx
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M03_L02
       mov       rax,[rcx]
       test      rax,rax
       je        short M03_L02
M03_L00:
       mov       rdx,[rax+80]
       test      rdx,rdx
       je        short M03_L04
       mov       rcx,[rdx]
       mov       rax,offset MT_System.RuntimeType+ActivatorCache
       cmp       rcx,rax
       jne       short M03_L03
       mov       rsi,rdx
M03_L01:
       cmp       byte ptr [rsi+28],0
       je        short M03_L05
       mov       rax,[rsi+8]
       mov       rcx,[rsi+10]
       call      rax
       mov       rdi,rax
       mov       rax,[rsi+18]
       mov       rcx,rdi
       call      rax
       nop
       mov       rax,rdi
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L02:
       mov       rcx,rbx
       call      qword ptr [7FFEFF717C60]; System.RuntimeType.InitializeCache()
       jmp       short M03_L00
M03_L03:
       mov       rax,offset MT_System.RuntimeType+CompositeCacheEntry
       cmp       rcx,rax
       jne       short M03_L04
       mov       rsi,[rdx+8]
       test      rsi,rsi
       je        short M03_L04
       jmp       short M03_L01
M03_L04:
       mov       rdx,rbx
       mov       rcx,offset MT_System.RuntimeType+IGenericCacheEntry<System.RuntimeType+ActivatorCache>
       call      qword ptr [7FFEFF71C528]; System.RuntimeType+IGenericCacheEntry`1[[System.__Canon, System.Private.CoreLib]].CreateAndCache(System.RuntimeType)
       mov       rsi,rax
       jmp       short M03_L01
M03_L05:
       mov       rcx,offset MT_System.MissingMethodException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF00067768]
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFF00067780]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF00067798]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
       sub       rsp,28
       mov       rdi,rcx
       mov       rcx,offset MT_System.Reflection.TargetInvocationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,rdi
       call      qword ptr [7FFF000677B0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 271
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M04_L00
       ret
M04_L00:
       jmp       qword ptr [7FFEFF715C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,[rbx+10]
       lea       ebp,[rdi+1]
       mov       ecx,ebp
       mov       rdx,[rbx+8]
       cmp       dword ptr [rdx+8],0
       jne       short M05_L01
       mov       edx,4
M05_L00:
       mov       eax,7FFFFFC7
       cmp       edx,7FFFFFC7
       cmova     edx,eax
       cmp       edx,ecx
       cmovl     edx,ecx
       mov       rcx,rbx
       call      qword ptr [7FFF5160DD70]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
       mov       [rbx+10],ebp
       mov       rcx,[rbx+8]
       movsxd    rdx,edi
       mov       r8,rsi
       call      qword ptr [7FFF515E7FF0]; Precode of System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M05_L01:
       mov       rdx,[rbx+8]
       mov       edx,[rdx+8]
       add       edx,edx
       jmp       short M05_L00
; Total bytes of code 105
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateCollection()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+70]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       xor       eax,eax
       mov       [rbp-40],rax
       mov       rbx,rcx
       mov       esi,[rbx+268]
       mov       byte ptr [rbp-40],1
       mov       dword ptr [rbp-3C],2
       test      esi,esi
       setg      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M00_L10
M00_L00:
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Coordinate>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       test      esi,esi
       jl        near ptr M00_L13
       test      esi,esi
       je        near ptr M00_L14
       mov       edx,esi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Coordinate[]
       call      CORINFO_HELP_NEWARR_1_PTR
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M00_L01:
       xor       r14d,r14d
       cmp       r14d,esi
       jl        near ptr M00_L09
M00_L02:
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Coordinate>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp-50],rsi
       mov       rbx,[rbx+60]
       mov       rdx,[rbp-50]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L03:
       call      qword ptr [7FFEFF707C00]; System.RuntimeType.CreateInstanceOfT()
       mov       r15,rax
M00_L04:
       xor       ecx,ecx
       mov       [rbp-48],rcx
       mov       ecx,80000000
       mov       edx,7FFFFFFF
       call      qword ptr [7FFEFFD1E070]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       mov       r13,[r15]
       mov       r12,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Coordinate
       cmp       r13,r12
       jne       near ptr M00_L15
       mov       [r15+8],eax
M00_L05:
       mov       ecx,80000000
       mov       edx,7FFFFFFF
       call      qword ptr [7FFEFFD1E070]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       cmp       r13,r12
       jne       near ptr M00_L16
       mov       [r15+0C],eax
M00_L06:
       mov       ecx,80000000
       mov       edx,7FFFFFFF
       call      qword ptr [7FFEFFD1E070]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       cmp       r13,r12
       jne       near ptr M00_L17
       mov       [r15+10],eax
M00_L07:
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       edx,[rdi+10]
       cmp       [rcx+8],edx
       jbe       near ptr M00_L18
       lea       r8d,[rdx+1]
       mov       [rdi+10],r8d
       mov       r8,r15
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
M00_L08:
       add       r14d,1
       jo        near ptr M00_L19
       cmp       r14d,esi
       jge       near ptr M00_L02
M00_L09:
       mov       rcx,1ED7CEF0818
       mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Coordinate
       mov       eax,[rax]
       and       eax,0C0000
       cmp       eax,40000
       sete      al
       movzx     eax,al
       test      eax,eax
       je        near ptr M00_L03
       xor       edx,edx
       mov       [rbp-48],rdx
       lea       rdx,[rbp-48]
       call      qword ptr [7FFF000576D8]
       mov       r15,[rbp-48]
       jmp       near ptr M00_L04
M00_L10:
       movzx     ecx,byte ptr [rbp-40]
       test      cl,cl
       je        short M00_L11
       lea       rcx,[rbp-40]
       call      qword ptr [7FFEFFD1E478]
       mov       esi,eax
       jmp       near ptr M00_L00
M00_L11:
       call      qword ptr [7FFEFFD1E490]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L12
       call      qword ptr [7FFF00057DE0]
       mov       rbx,rax
M00_L12:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,1ED7CEE3620
       call      qword ptr [7FFEFF98DEC0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L13:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FFEFF98EEE0]
       int       3
M00_L14:
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Coordinate>
       call      qword ptr [7FFEFF705728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1ACE8002E60
       mov       rdx,[rcx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L01
M00_L15:
       mov       rcx,r15
       mov       edx,eax
       mov       r11,7FFEFF650DC0
       call      qword ptr [r11]
       jmp       near ptr M00_L05
M00_L16:
       mov       rcx,r15
       mov       edx,eax
       mov       r11,7FFEFF650DC8
       call      qword ptr [r11]
       jmp       near ptr M00_L06
M00_L17:
       mov       rcx,r15
       mov       edx,eax
       mov       r11,7FFEFF650DD0
       call      qword ptr [r11]
       jmp       near ptr M00_L07
M00_L18:
       mov       rcx,rdi
       mov       rdx,r15
       call      qword ptr [7FFEFF8AE370]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M00_L08
       int       3
M00_L19:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       int       3
; Total bytes of code 716
```
```assembly
; System.RuntimeType.CreateInstanceOfT()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       lea       rbp,[rsp+40]
       mov       rbx,rcx
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M01_L02
       mov       rax,[rcx]
       test      rax,rax
       je        short M01_L02
M01_L00:
       mov       rdx,[rax+80]
       test      rdx,rdx
       je        short M01_L04
       mov       rcx,[rdx]
       mov       rax,offset MT_System.RuntimeType+ActivatorCache
       cmp       rcx,rax
       jne       short M01_L03
       mov       rsi,rdx
M01_L01:
       cmp       byte ptr [rsi+28],0
       je        short M01_L05
       mov       rax,[rsi+8]
       mov       rcx,[rsi+10]
       call      rax
       mov       rdi,rax
       mov       rax,[rsi+18]
       mov       rcx,rdi
       call      rax
       nop
       mov       rax,rdi
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L02:
       mov       rcx,rbx
       call      qword ptr [7FFEFF707C60]; System.RuntimeType.InitializeCache()
       jmp       short M01_L00
M01_L03:
       mov       rax,offset MT_System.RuntimeType+CompositeCacheEntry
       cmp       rcx,rax
       jne       short M01_L04
       mov       rsi,[rdx+8]
       test      rsi,rsi
       je        short M01_L04
       jmp       short M01_L01
M01_L04:
       mov       rdx,rbx
       mov       rcx,offset MT_System.RuntimeType+IGenericCacheEntry<System.RuntimeType+ActivatorCache>
       call      qword ptr [7FFEFF70C528]; System.RuntimeType+IGenericCacheEntry`1[[System.__Canon, System.Private.CoreLib]].CreateAndCache(System.RuntimeType)
       mov       rsi,rax
       jmp       short M01_L01
M01_L05:
       mov       rcx,offset MT_System.MissingMethodException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF00057720]
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFF00057738]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF00057750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
       sub       rsp,28
       mov       rdi,rcx
       mov       rcx,offset MT_System.Reflection.TargetInvocationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,rdi
       call      qword ptr [7FFF00057768]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 271
```
```assembly
; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,68
       vzeroupper
       lea       rbp,[rsp+0A0]
       xor       eax,eax
       mov       [rbp-48],rax
       mov       ebx,ecx
       mov       esi,edx
       lea       rcx,[rbp-80]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rdi,rax
       mov       rdx,rsp
       mov       [rbp-68],rdx
       mov       rdx,rbp
       mov       [rbp-58],rdx
       cmp       ebx,esi
       jge       near ptr M02_L04
       sub       esi,ebx
       dec       esi
       je        near ptr M02_L05
       mov       r14d,esi
       shr       r14d,1
       or        r14d,esi
       mov       edx,r14d
       shr       edx,2
       or        r14d,edx
       mov       edx,r14d
       shr       edx,4
       or        r14d,edx
       mov       edx,r14d
       shr       edx,8
       or        r14d,edx
       mov       edx,r14d
       shr       edx,10
       or        r14d,edx
       xor       edx,edx
       mov       [rbp-3C],edx
M02_L00:
       lea       rdx,[rbp-3C]
       mov       [rbp-48],rdx
       lea       rdx,[rbp-3C]
       mov       r8d,4
       xor       ecx,ecx
       mov       r9d,2
       mov       rax,7FFEFFDB0488
       mov       [rbp-70],rax
       lea       rax,[M02_L01]
       mov       [rbp-60],rax
       lea       rax,[rbp-80]
       mov       [rdi+8],rax
       mov       byte ptr [rdi+4],0
       mov       rax,7FFF8CB23670
       call      rax
M02_L01:
       mov       byte ptr [rdi+4],1
       cmp       dword ptr [7FFF5F64F778],0
       je        short M02_L02
       call      qword ptr [7FFF5F63D608]; CORINFO_HELP_STOP_FOR_GC
M02_L02:
       mov       rcx,[rbp-78]
       mov       [rdi+8],rcx
       test      eax,eax
       jne       short M02_L06
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-48],rax
       mov       eax,r14d
       and       eax,[rbp-3C]
       cmp       eax,esi
       ja        short M02_L00
       add       eax,ebx
M02_L03:
       add       rsp,68
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L04:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF00057558]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFEFFC5E6E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M02_L05:
       mov       eax,ebx
       jmp       short M02_L03
M02_L06:
       mov       ecx,eax
       call      qword ptr [7FFF00057570]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 342
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       sub       rsp,28
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M03_L01
       lea       rax,[rcx+rdx*8+10]
       mov       rdx,[rcx]
       mov       rdx,[rdx+30]
       test      r8,r8
       je        short M03_L02
       cmp       rdx,[r8]
       jne       short M03_L03
M03_L00:
       mov       rcx,rax
       mov       rdx,r8
       add       rsp,28
       jmp       near ptr 00007FFF5F337B10
M03_L01:
       call      qword ptr [7FFF000575E8]
       int       3
M03_L02:
       xor       ecx,ecx
       mov       [rax],rcx
       add       rsp,28
       ret
M03_L03:
       mov       r10,offset MT_System.Object[]
       cmp       [rcx],r10
       je        short M03_L00
       mov       rcx,rax
       add       rsp,28
       jmp       qword ptr [7FFEFF70D908]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
; Total bytes of code 94
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M04_L00
       ret
M04_L00:
       jmp       qword ptr [7FFEFF705C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,[rbx+10]
       lea       ebp,[rdi+1]
       mov       ecx,ebp
       mov       rdx,[rbx+8]
       cmp       dword ptr [rdx+8],0
       jne       short M05_L01
       mov       edx,4
M05_L00:
       mov       eax,7FFFFFC7
       cmp       edx,7FFFFFC7
       cmova     edx,eax
       cmp       edx,ecx
       cmovl     edx,ecx
       mov       rcx,rbx
       call      qword ptr [7FFF5160DD70]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
       mov       [rbx+10],ebp
       mov       rcx,[rbx+8]
       movsxd    rdx,edi
       mov       r8,rsi
       call      qword ptr [7FFF515E7FF0]; Precode of System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M05_L01:
       mov       rdx,[rbx+8]
       mov       edx,[rdx+8]
       add       edx,edx
       jmp       short M05_L00
; Total bytes of code 105
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateCollection()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+70]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       xor       eax,eax
       mov       [rbp-40],rax
       mov       rbx,rcx
       mov       esi,[rbx+268]
       mov       byte ptr [rbp-40],1
       mov       dword ptr [rbp-3C],2
       test      esi,esi
       setg      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M00_L10
M00_L00:
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Coordinate>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       test      esi,esi
       jl        near ptr M00_L13
       test      esi,esi
       je        near ptr M00_L14
       mov       edx,esi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Coordinate[]
       call      CORINFO_HELP_NEWARR_1_PTR
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M00_L01:
       xor       r14d,r14d
       cmp       r14d,esi
       jl        near ptr M00_L09
M00_L02:
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Coordinate>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp-50],rsi
       mov       rbx,[rbx+60]
       mov       rdx,[rbp-50]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L03:
       xor       edx,edx
       mov       [rbp-48],rdx
       lea       rdx,[rbp-48]
       call      qword ptr [7FFF00057810]
       mov       r15,[rbp-48]
M00_L04:
       xor       ecx,ecx
       mov       [rbp-48],rcx
       mov       ecx,80000000
       mov       edx,7FFFFFFF
       call      qword ptr [7FFEFFD1E070]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       mov       r13,[r15]
       mov       r12,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Coordinate
       cmp       r13,r12
       jne       near ptr M00_L15
       mov       [r15+8],eax
M00_L05:
       mov       ecx,80000000
       mov       edx,7FFFFFFF
       call      qword ptr [7FFEFFD1E070]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       cmp       r13,r12
       jne       near ptr M00_L16
       mov       [r15+0C],eax
M00_L06:
       mov       ecx,80000000
       mov       edx,7FFFFFFF
       call      qword ptr [7FFEFFD1E070]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       cmp       r13,r12
       jne       near ptr M00_L17
       mov       [r15+10],eax
M00_L07:
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       edx,[rdi+10]
       cmp       [rcx+8],edx
       jbe       near ptr M00_L18
       lea       r8d,[rdx+1]
       mov       [rdi+10],r8d
       mov       r8,r15
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
M00_L08:
       add       r14d,1
       jo        near ptr M00_L19
       cmp       r14d,esi
       jge       near ptr M00_L02
M00_L09:
       mov       rcx,262C0620818
       mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Coordinate
       mov       eax,[rax]
       and       eax,0C0000
       cmp       eax,40000
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M00_L03
       call      qword ptr [7FFEFF707C00]; System.RuntimeType.CreateInstanceOfT()
       mov       r15,rax
       jmp       near ptr M00_L04
M00_L10:
       movzx     ecx,byte ptr [rbp-40]
       test      cl,cl
       je        short M00_L11
       lea       rcx,[rbp-40]
       call      qword ptr [7FFEFFD1E478]
       mov       esi,eax
       jmp       near ptr M00_L00
M00_L11:
       call      qword ptr [7FFEFFD1E490]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L12
       call      qword ptr [7FFF00057DE0]
       mov       rbx,rax
M00_L12:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,262C0613620
       call      qword ptr [7FFEFF98DEC0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L13:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FFEFF98EEE0]
       int       3
M00_L14:
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Coordinate>
       call      qword ptr [7FFEFF705728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,22258800E68
       mov       rdx,[rcx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L01
M00_L15:
       mov       rcx,r15
       mov       edx,eax
       mov       r11,7FFEFF650DB0
       call      qword ptr [r11]
       jmp       near ptr M00_L05
M00_L16:
       mov       rcx,r15
       mov       edx,eax
       mov       r11,7FFEFF650DB8
       call      qword ptr [r11]
       jmp       near ptr M00_L06
M00_L17:
       mov       rcx,r15
       mov       edx,eax
       mov       r11,7FFEFF650DC0
       call      qword ptr [r11]
       jmp       near ptr M00_L07
M00_L18:
       mov       rcx,rdi
       mov       rdx,r15
       call      qword ptr [7FFEFF8AE370]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M00_L08
       int       3
M00_L19:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       int       3
; Total bytes of code 716
```
```assembly
; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,68
       vzeroupper
       lea       rbp,[rsp+0A0]
       xor       eax,eax
       mov       [rbp-48],rax
       mov       ebx,ecx
       mov       esi,edx
       lea       rcx,[rbp-80]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rdi,rax
       mov       rdx,rsp
       mov       [rbp-68],rdx
       mov       rdx,rbp
       mov       [rbp-58],rdx
       cmp       ebx,esi
       jge       near ptr M01_L04
       sub       esi,ebx
       dec       esi
       je        near ptr M01_L05
       mov       r14d,esi
       shr       r14d,1
       or        r14d,esi
       mov       edx,r14d
       shr       edx,2
       or        r14d,edx
       mov       edx,r14d
       shr       edx,4
       or        r14d,edx
       mov       edx,r14d
       shr       edx,8
       or        r14d,edx
       mov       edx,r14d
       shr       edx,10
       or        r14d,edx
       xor       edx,edx
       mov       [rbp-3C],edx
M01_L00:
       lea       rdx,[rbp-3C]
       mov       [rbp-48],rdx
       lea       rdx,[rbp-3C]
       mov       r8d,4
       xor       ecx,ecx
       mov       r9d,2
       mov       rax,7FFEFFDB0488
       mov       [rbp-70],rax
       lea       rax,[M01_L01]
       mov       [rbp-60],rax
       lea       rax,[rbp-80]
       mov       [rdi+8],rax
       mov       byte ptr [rdi+4],0
       mov       rax,7FFF8CB23670
       call      rax
M01_L01:
       mov       byte ptr [rdi+4],1
       cmp       dword ptr [7FFF5F64F778],0
       je        short M01_L02
       call      qword ptr [7FFF5F63D608]; CORINFO_HELP_STOP_FOR_GC
M01_L02:
       mov       rcx,[rbp-78]
       mov       [rdi+8],rcx
       test      eax,eax
       jne       short M01_L06
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-48],rax
       mov       eax,r14d
       and       eax,[rbp-3C]
       cmp       eax,esi
       ja        short M01_L00
       add       eax,ebx
M01_L03:
       add       rsp,68
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L04:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF00057690]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFEFFC5E6E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L05:
       mov       eax,ebx
       jmp       short M01_L03
M01_L06:
       mov       ecx,eax
       call      qword ptr [7FFF000576A8]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 342
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       sub       rsp,28
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M02_L01
       lea       rax,[rcx+rdx*8+10]
       mov       rdx,[rcx]
       mov       rdx,[rdx+30]
       test      r8,r8
       je        short M02_L02
       cmp       rdx,[r8]
       jne       short M02_L03
M02_L00:
       mov       rcx,rax
       mov       rdx,r8
       add       rsp,28
       jmp       near ptr 00007FFF5F337B10
M02_L01:
       call      qword ptr [7FFF00057720]
       int       3
M02_L02:
       xor       ecx,ecx
       mov       [rax],rcx
       add       rsp,28
       ret
M02_L03:
       mov       r10,offset MT_System.Object[]
       cmp       [rcx],r10
       je        short M02_L00
       mov       rcx,rax
       add       rsp,28
       jmp       qword ptr [7FFEFF70D908]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
; Total bytes of code 94
```
```assembly
; System.RuntimeType.CreateInstanceOfT()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       lea       rbp,[rsp+40]
       mov       rbx,rcx
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M03_L02
       mov       rax,[rcx]
       test      rax,rax
       je        short M03_L02
M03_L00:
       mov       rdx,[rax+80]
       test      rdx,rdx
       je        short M03_L04
       mov       rcx,[rdx]
       mov       rax,offset MT_System.RuntimeType+ActivatorCache
       cmp       rcx,rax
       jne       short M03_L03
       mov       rsi,rdx
M03_L01:
       cmp       byte ptr [rsi+28],0
       je        short M03_L05
       mov       rax,[rsi+8]
       mov       rcx,[rsi+10]
       call      rax
       mov       rdi,rax
       mov       rax,[rsi+18]
       mov       rcx,rdi
       call      rax
       nop
       mov       rax,rdi
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L02:
       mov       rcx,rbx
       call      qword ptr [7FFEFF707C60]; System.RuntimeType.InitializeCache()
       jmp       short M03_L00
M03_L03:
       mov       rax,offset MT_System.RuntimeType+CompositeCacheEntry
       cmp       rcx,rax
       jne       short M03_L04
       mov       rsi,[rdx+8]
       test      rsi,rsi
       je        short M03_L04
       jmp       short M03_L01
M03_L04:
       mov       rdx,rbx
       mov       rcx,offset MT_System.RuntimeType+IGenericCacheEntry<System.RuntimeType+ActivatorCache>
       call      qword ptr [7FFEFF70C528]; System.RuntimeType+IGenericCacheEntry`1[[System.__Canon, System.Private.CoreLib]].CreateAndCache(System.RuntimeType)
       mov       rsi,rax
       jmp       short M03_L01
M03_L05:
       mov       rcx,offset MT_System.MissingMethodException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF00057858]
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFF00057870]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF00057888]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
       sub       rsp,28
       mov       rdi,rcx
       mov       rcx,offset MT_System.Reflection.TargetInvocationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,rdi
       call      qword ptr [7FFF000578A0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 271
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M04_L00
       ret
M04_L00:
       jmp       qword ptr [7FFEFF705C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,[rbx+10]
       lea       ebp,[rdi+1]
       mov       ecx,ebp
       mov       rdx,[rbx+8]
       cmp       dword ptr [rdx+8],0
       jne       short M05_L01
       mov       edx,4
M05_L00:
       mov       eax,7FFFFFC7
       cmp       edx,7FFFFFC7
       cmova     edx,eax
       cmp       edx,ecx
       cmovl     edx,ecx
       mov       rcx,rbx
       call      qword ptr [7FFF5160DD70]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
       mov       [rbx+10],ebp
       mov       rcx,[rbx+8]
       movsxd    rdx,edi
       mov       r8,rsi
       call      qword ptr [7FFF515E7FF0]; Precode of System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M05_L01:
       mov       rdx,[rbx+8]
       mov       edx,[rdx+8]
       add       edx,edx
       jmp       short M05_L00
; Total bytes of code 105
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateCollection()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+70]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       xor       eax,eax
       mov       [rbp-40],rax
       mov       rbx,rcx
       mov       esi,[rbx+268]
       mov       byte ptr [rbp-40],1
       mov       dword ptr [rbp-3C],2
       test      esi,esi
       setg      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M00_L10
M00_L00:
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Coordinate>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       test      esi,esi
       jl        near ptr M00_L13
       test      esi,esi
       je        near ptr M00_L14
       mov       edx,esi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Coordinate[]
       call      CORINFO_HELP_NEWARR_1_PTR
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M00_L01:
       xor       r14d,r14d
       cmp       r14d,esi
       jl        near ptr M00_L09
M00_L02:
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Coordinate>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp-50],rsi
       mov       rbx,[rbx+60]
       mov       rdx,[rbp-50]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L03:
       call      qword ptr [7FFEFF6E7C00]; System.RuntimeType.CreateInstanceOfT()
       mov       r15,rax
M00_L04:
       xor       ecx,ecx
       mov       [rbp-48],rcx
       mov       ecx,80000000
       mov       edx,7FFFFFFF
       call      qword ptr [7FFEFFDA5620]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       mov       r13,[r15]
       mov       r12,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Coordinate
       cmp       r13,r12
       jne       near ptr M00_L15
       mov       [r15+8],eax
M00_L05:
       mov       ecx,80000000
       mov       edx,7FFFFFFF
       call      qword ptr [7FFEFFDA5620]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       cmp       r13,r12
       jne       near ptr M00_L16
       mov       [r15+0C],eax
M00_L06:
       mov       ecx,80000000
       mov       edx,7FFFFFFF
       call      qword ptr [7FFEFFDA5620]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       cmp       r13,r12
       jne       near ptr M00_L17
       mov       [r15+10],eax
M00_L07:
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       edx,[rdi+10]
       cmp       [rcx+8],edx
       jbe       near ptr M00_L18
       lea       r8d,[rdx+1]
       mov       [rdi+10],r8d
       mov       r8,r15
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
M00_L08:
       add       r14d,1
       jo        near ptr M00_L19
       cmp       r14d,esi
       jge       near ptr M00_L02
M00_L09:
       mov       rcx,19A90500818
       mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Coordinate
       mov       eax,[rax]
       and       eax,0C0000
       cmp       eax,40000
       sete      al
       movzx     eax,al
       test      eax,eax
       je        near ptr M00_L03
       xor       edx,edx
       mov       [rbp-48],rdx
       lea       rdx,[rbp-48]
       call      qword ptr [7FFF00025440]
       mov       r15,[rbp-48]
       jmp       near ptr M00_L04
M00_L10:
       movzx     ecx,byte ptr [rbp-40]
       test      cl,cl
       je        short M00_L11
       lea       rcx,[rbp-40]
       call      qword ptr [7FFEFFDA5A28]
       mov       esi,eax
       jmp       near ptr M00_L00
M00_L11:
       call      qword ptr [7FFEFFDA5A40]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L12
       call      qword ptr [7FFF0002CF78]
       mov       rbx,rax
M00_L12:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,19A904F3620
       call      qword ptr [7FFEFF96DEC0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L13:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FFEFF96EEE0]
       int       3
M00_L14:
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Coordinate>
       call      qword ptr [7FFEFF6E5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,159FB402F80
       mov       rdx,[rcx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L01
M00_L15:
       mov       rcx,r15
       mov       edx,eax
       mov       r11,7FFEFF631030
       call      qword ptr [r11]
       jmp       near ptr M00_L05
M00_L16:
       mov       rcx,r15
       mov       edx,eax
       mov       r11,7FFEFF631038
       call      qword ptr [r11]
       jmp       near ptr M00_L06
M00_L17:
       mov       rcx,r15
       mov       edx,eax
       mov       r11,7FFEFF631040
       call      qword ptr [r11]
       jmp       near ptr M00_L07
M00_L18:
       mov       rcx,rdi
       mov       rdx,r15
       call      qword ptr [7FFEFF88E370]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M00_L08
       int       3
M00_L19:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       int       3
; Total bytes of code 716
```
```assembly
; System.RuntimeType.CreateInstanceOfT()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       lea       rbp,[rsp+40]
       mov       rbx,rcx
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M01_L00
       mov       rsi,[rcx]
       test      rsi,rsi
       jne       short M01_L03
M01_L00:
       mov       rcx,rbx
       call      qword ptr [7FFEFF6E7C60]; System.RuntimeType.InitializeCache()
M01_L01:
       mov       rdx,[rax+80]
       test      rdx,rdx
       je        short M01_L05
       mov       rcx,[rdx]
       mov       rax,offset MT_System.RuntimeType+ActivatorCache
       cmp       rcx,rax
       jne       short M01_L04
       mov       rsi,rdx
M01_L02:
       cmp       byte ptr [rsi+28],0
       je        short M01_L06
       mov       rax,[rsi+8]
       mov       rcx,[rsi+10]
       call      rax
       mov       rdi,rax
       mov       rax,[rsi+18]
       mov       rcx,rdi
       call      rax
       nop
       mov       rax,rdi
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L03:
       mov       rax,rsi
       jmp       short M01_L01
M01_L04:
       mov       rax,offset MT_System.RuntimeType+CompositeCacheEntry
       cmp       rcx,rax
       jne       short M01_L05
       mov       rsi,[rdx+8]
       test      rsi,rsi
       je        short M01_L05
       jmp       short M01_L02
M01_L05:
       mov       rdx,rbx
       mov       rcx,offset MT_System.RuntimeType+IGenericCacheEntry<System.RuntimeType+ActivatorCache>
       call      qword ptr [7FFEFF6EC528]; System.RuntimeType+IGenericCacheEntry`1[[System.__Canon, System.Private.CoreLib]].CreateAndCache(System.RuntimeType)
       mov       rsi,rax
       jmp       short M01_L02
M01_L06:
       mov       rcx,offset MT_System.MissingMethodException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF001163D0]
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFF0002D128]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF001163E8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
       sub       rsp,28
       mov       rdi,rcx
       mov       rcx,offset MT_System.Reflection.TargetInvocationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,rdi
       call      qword ptr [7FFF00115620]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 274
```
```assembly
; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,68
       vzeroupper
       lea       rbp,[rsp+0A0]
       xor       eax,eax
       mov       [rbp-48],rax
       mov       ebx,ecx
       mov       esi,edx
       lea       rcx,[rbp-80]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rdi,rax
       mov       rdx,rsp
       mov       [rbp-68],rdx
       mov       rdx,rbp
       mov       [rbp-58],rdx
       cmp       ebx,esi
       jge       near ptr M02_L04
       sub       esi,ebx
       dec       esi
       je        near ptr M02_L05
       mov       r14d,esi
       shr       r14d,1
       or        r14d,esi
       mov       edx,r14d
       shr       edx,2
       or        r14d,edx
       mov       edx,r14d
       shr       edx,4
       or        r14d,edx
       mov       edx,r14d
       shr       edx,8
       or        r14d,edx
       mov       edx,r14d
       shr       edx,10
       or        r14d,edx
       xor       edx,edx
       mov       [rbp-3C],edx
M02_L00:
       lea       rdx,[rbp-3C]
       mov       [rbp-48],rdx
       lea       rdx,[rbp-3C]
       mov       r8d,4
       xor       ecx,ecx
       mov       r9d,2
       mov       rax,7FFEFFDD4F18
       mov       [rbp-70],rax
       lea       rax,[M02_L01]
       mov       [rbp-60],rax
       lea       rax,[rbp-80]
       mov       [rdi+8],rax
       mov       byte ptr [rdi+4],0
       mov       rax,7FFF8CB23670
       call      rax
M02_L01:
       mov       byte ptr [rdi+4],1
       cmp       dword ptr [7FFF5F64F778],0
       je        short M02_L02
       call      qword ptr [7FFF5F63D608]; CORINFO_HELP_STOP_FOR_GC
M02_L02:
       mov       rcx,[rbp-78]
       mov       [rdi+8],rcx
       test      eax,eax
       jne       short M02_L06
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-48],rax
       mov       eax,r14d
       and       eax,[rbp-3C]
       cmp       eax,esi
       ja        short M02_L00
       add       eax,ebx
M02_L03:
       add       rsp,68
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L04:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF001168F8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFEFFCE5DD0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M02_L05:
       mov       eax,ebx
       jmp       short M02_L03
M02_L06:
       mov       ecx,eax
       call      qword ptr [7FFF00116910]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 342
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       sub       rsp,28
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M03_L01
       lea       rax,[rcx+rdx*8+10]
       mov       rdx,[rcx]
       mov       rdx,[rdx+30]
       test      r8,r8
       je        short M03_L02
       cmp       rdx,[r8]
       jne       short M03_L03
M03_L00:
       mov       rcx,rax
       mov       rdx,r8
       add       rsp,28
       jmp       near ptr 00007FFF5F337B10
M03_L01:
       call      qword ptr [7FFF0002C408]
       int       3
M03_L02:
       xor       ecx,ecx
       mov       [rax],rcx
       add       rsp,28
       ret
M03_L03:
       mov       r10,offset MT_System.Object[]
       cmp       [rcx],r10
       je        short M03_L00
       mov       rcx,rax
       add       rsp,28
       jmp       qword ptr [7FFEFF6ED908]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
; Total bytes of code 94
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M04_L00
       ret
M04_L00:
       jmp       qword ptr [7FFEFF6E5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,[rbx+10]
       mov       ebp,edi
       lea       ecx,[rbp+1]
       mov       r14,[rbx+8]
       cmp       dword ptr [r14+8],0
       jne       near ptr M05_L04
       mov       r15d,4
M05_L00:
       mov       edx,7FFFFFC7
       cmp       r15d,7FFFFFC7
       cmova     r15d,edx
       cmp       r15d,ecx
       cmovl     r15d,ecx
       cmp       r15d,edi
       jl        near ptr M05_L07
       cmp       [r14+8],r15d
       je        short M05_L03
       test      r15d,r15d
       jle       near ptr M05_L08
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+0A0]
       test      rax,rax
       je        short M05_L05
       mov       rcx,rax
M05_L01:
       mov       edx,r15d
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r15,rax
       test      edi,edi
       jg        short M05_L06
M05_L02:
       lea       rcx,[rbx+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
M05_L03:
       lea       ecx,[rbp+1]
       mov       [rbx+10],ecx
       mov       rcx,[rbx+8]
       movsxd    rdx,ebp
       mov       r8,rsi
       call      qword ptr [7FFEFF6E57B8]; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M05_L04:
       mov       r15d,[r14+8]
       add       r15d,r15d
       jmp       near ptr M05_L00
M05_L05:
       mov       rdx,7FFF00008508
       call      qword ptr [7FFEFF6EC5D0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M05_L01
M05_L06:
       mov       rcx,r14
       mov       r8d,edi
       mov       rdx,r15
       call      qword ptr [7FFEFF6E7060]; System.Array.Copy(System.Array, System.Array, Int32)
       jmp       short M05_L02
M05_L07:
       mov       ecx,7
       mov       edx,0F
       call      qword ptr [7FFEFF96EEE0]
       int       3
M05_L08:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+0A8]
       test      rdx,rdx
       je        short M05_L09
       jmp       short M05_L10
M05_L09:
       mov       rdx,7FFF00008510
       call      qword ptr [7FFEFF6EC5D0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M05_L10:
       mov       rcx,rdx
       call      qword ptr [7FFEFF6E5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M05_L03
; Total bytes of code 323
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateCollection()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+70]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       xor       eax,eax
       mov       [rbp-40],rax
       mov       rbx,rcx
       mov       esi,[rbx+268]
       mov       byte ptr [rbp-40],1
       mov       dword ptr [rbp-3C],2
       test      esi,esi
       setg      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M00_L10
M00_L00:
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Coordinate>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       test      esi,esi
       jl        near ptr M00_L13
       test      esi,esi
       je        near ptr M00_L14
       mov       edx,esi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Coordinate[]
       call      CORINFO_HELP_NEWARR_1_PTR
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M00_L01:
       xor       r14d,r14d
       cmp       r14d,esi
       jl        near ptr M00_L09
M00_L02:
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Coordinate>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp-50],rsi
       mov       rbx,[rbx+60]
       mov       rdx,[rbp-50]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L03:
       call      qword ptr [7FFEFF6E7C00]; System.RuntimeType.CreateInstanceOfT()
       mov       r15,rax
M00_L04:
       xor       ecx,ecx
       mov       [rbp-48],rcx
       mov       ecx,80000000
       mov       edx,7FFFFFFF
       call      qword ptr [7FFEFFCFE070]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       mov       r13,[r15]
       mov       r12,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Coordinate
       cmp       r13,r12
       jne       near ptr M00_L15
       mov       [r15+8],eax
M00_L05:
       mov       ecx,80000000
       mov       edx,7FFFFFFF
       call      qword ptr [7FFEFFCFE070]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       cmp       r13,r12
       jne       near ptr M00_L16
       mov       [r15+0C],eax
M00_L06:
       mov       ecx,80000000
       mov       edx,7FFFFFFF
       call      qword ptr [7FFEFFCFE070]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       cmp       r13,r12
       jne       near ptr M00_L17
       mov       [r15+10],eax
M00_L07:
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       edx,[rdi+10]
       cmp       [rcx+8],edx
       jbe       near ptr M00_L18
       lea       r8d,[rdx+1]
       mov       [rdi+10],r8d
       mov       r8,r15
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
M00_L08:
       add       r14d,1
       jo        near ptr M00_L19
       cmp       r14d,esi
       jge       near ptr M00_L02
M00_L09:
       mov       rcx,25802080818
       mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Coordinate
       mov       eax,[rax]
       and       eax,0C0000
       cmp       eax,40000
       sete      al
       movzx     eax,al
       test      eax,eax
       je        near ptr M00_L03
       xor       edx,edx
       mov       [rbp-48],rdx
       lea       rdx,[rbp-48]
       call      qword ptr [7FFEFFF6DF98]
       mov       r15,[rbp-48]
       jmp       near ptr M00_L04
M00_L10:
       movzx     ecx,byte ptr [rbp-40]
       test      cl,cl
       je        short M00_L11
       lea       rcx,[rbp-40]
       call      qword ptr [7FFEFFCFE478]
       mov       esi,eax
       jmp       near ptr M00_L00
M00_L11:
       call      qword ptr [7FFEFFCFE490]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L12
       call      qword ptr [7FFF00037E70]
       mov       rbx,rax
M00_L12:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,25802073620
       call      qword ptr [7FFEFF96DEC0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L13:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FFEFF96EEE0]
       int       3
M00_L14:
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Coordinate>
       call      qword ptr [7FFEFF6E5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,25880002E60
       mov       rdx,[rcx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L01
M00_L15:
       mov       rcx,r15
       mov       edx,eax
       mov       r11,7FFEFF630DF0
       call      qword ptr [r11]
       jmp       near ptr M00_L05
M00_L16:
       mov       rcx,r15
       mov       edx,eax
       mov       r11,7FFEFF630DF8
       call      qword ptr [r11]
       jmp       near ptr M00_L06
M00_L17:
       mov       rcx,r15
       mov       edx,eax
       mov       r11,7FFEFF630E00
       call      qword ptr [r11]
       jmp       near ptr M00_L07
M00_L18:
       mov       rcx,rdi
       mov       rdx,r15
       call      qword ptr [7FFEFF88E370]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M00_L08
       int       3
M00_L19:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       int       3
; Total bytes of code 716
```
```assembly
; System.RuntimeType.CreateInstanceOfT()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       lea       rbp,[rsp+40]
       mov       rbx,rcx
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M01_L02
       mov       rax,[rcx]
       test      rax,rax
       je        short M01_L02
M01_L00:
       mov       rdx,[rax+80]
       test      rdx,rdx
       je        short M01_L04
       mov       rcx,[rdx]
       mov       rax,offset MT_System.RuntimeType+ActivatorCache
       cmp       rcx,rax
       jne       short M01_L03
       mov       rsi,rdx
M01_L01:
       cmp       byte ptr [rsi+28],0
       je        short M01_L05
       mov       rax,[rsi+8]
       mov       rcx,[rsi+10]
       call      rax
       mov       rdi,rax
       mov       rax,[rsi+18]
       mov       rcx,rdi
       call      rax
       nop
       mov       rax,rdi
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L02:
       mov       rcx,rbx
       call      qword ptr [7FFEFF6E7C60]; System.RuntimeType.InitializeCache()
       jmp       short M01_L00
M01_L03:
       mov       rax,offset MT_System.RuntimeType+CompositeCacheEntry
       cmp       rcx,rax
       jne       short M01_L04
       mov       rsi,[rdx+8]
       test      rsi,rsi
       je        short M01_L04
       jmp       short M01_L01
M01_L04:
       mov       rdx,rbx
       mov       rcx,offset MT_System.RuntimeType+IGenericCacheEntry<System.RuntimeType+ActivatorCache>
       call      qword ptr [7FFEFF6EC528]; System.RuntimeType+IGenericCacheEntry`1[[System.__Canon, System.Private.CoreLib]].CreateAndCache(System.RuntimeType)
       mov       rsi,rax
       jmp       short M01_L01
M01_L05:
       mov       rcx,offset MT_System.MissingMethodException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF00037DB0]
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFF00037DC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF00037DE0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
       sub       rsp,28
       mov       rdi,rcx
       mov       rcx,offset MT_System.Reflection.TargetInvocationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,rdi
       call      qword ptr [7FFF00037DF8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 271
```
```assembly
; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,68
       vzeroupper
       lea       rbp,[rsp+0A0]
       xor       eax,eax
       mov       [rbp-48],rax
       mov       ebx,ecx
       mov       esi,edx
       lea       rcx,[rbp-80]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rdi,rax
       mov       rdx,rsp
       mov       [rbp-68],rdx
       mov       rdx,rbp
       mov       [rbp-58],rdx
       cmp       ebx,esi
       jge       near ptr M02_L04
       sub       esi,ebx
       dec       esi
       je        near ptr M02_L05
       mov       r14d,esi
       shr       r14d,1
       or        r14d,esi
       mov       edx,r14d
       shr       edx,2
       or        r14d,edx
       mov       edx,r14d
       shr       edx,4
       or        r14d,edx
       mov       edx,r14d
       shr       edx,8
       or        r14d,edx
       mov       edx,r14d
       shr       edx,10
       or        r14d,edx
       xor       edx,edx
       mov       [rbp-3C],edx
M02_L00:
       lea       rdx,[rbp-3C]
       mov       [rbp-48],rdx
       lea       rdx,[rbp-3C]
       mov       r8d,4
       xor       ecx,ecx
       mov       r9d,2
       mov       rax,7FFEFFD90488
       mov       [rbp-70],rax
       lea       rax,[M02_L01]
       mov       [rbp-60],rax
       lea       rax,[rbp-80]
       mov       [rdi+8],rax
       mov       byte ptr [rdi+4],0
       mov       rax,7FFF8CB23670
       call      rax
M02_L01:
       mov       byte ptr [rdi+4],1
       cmp       dword ptr [7FFF5F64F778],0
       je        short M02_L02
       call      qword ptr [7FFF5F63D608]; CORINFO_HELP_STOP_FOR_GC
M02_L02:
       mov       rcx,[rbp-78]
       mov       [rdi+8],rcx
       test      eax,eax
       jne       short M02_L06
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-48],rax
       mov       eax,r14d
       and       eax,[rbp-3C]
       cmp       eax,esi
       ja        short M02_L00
       add       eax,ebx
M02_L03:
       add       rsp,68
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L04:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF00037CD8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFEFFC3E6E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M02_L05:
       mov       eax,ebx
       jmp       short M02_L03
M02_L06:
       mov       ecx,eax
       call      qword ptr [7FFF00037CF0]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 342
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       sub       rsp,28
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M03_L01
       lea       rax,[rcx+rdx*8+10]
       mov       rdx,[rcx]
       mov       rdx,[rdx+30]
       test      r8,r8
       je        short M03_L02
       cmp       rdx,[r8]
       jne       short M03_L03
M03_L00:
       mov       rcx,rax
       mov       rdx,r8
       add       rsp,28
       jmp       near ptr 00007FFF5F337B10
M03_L01:
       call      qword ptr [7FFF00037D68]
       int       3
M03_L02:
       xor       ecx,ecx
       mov       [rax],rcx
       add       rsp,28
       ret
M03_L03:
       mov       r10,offset MT_System.Object[]
       cmp       [rcx],r10
       je        short M03_L00
       mov       rcx,rax
       add       rsp,28
       jmp       qword ptr [7FFEFF6ED908]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
; Total bytes of code 94
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M04_L00
       ret
M04_L00:
       jmp       qword ptr [7FFEFF6E5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,[rbx+10]
       lea       ebp,[rdi+1]
       mov       ecx,ebp
       mov       rdx,[rbx+8]
       cmp       dword ptr [rdx+8],0
       jne       short M05_L01
       mov       edx,4
M05_L00:
       mov       eax,7FFFFFC7
       cmp       edx,7FFFFFC7
       cmova     edx,eax
       cmp       edx,ecx
       cmovl     edx,ecx
       mov       rcx,rbx
       call      qword ptr [7FFF5160DD70]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
       mov       [rbx+10],ebp
       mov       rcx,[rbx+8]
       movsxd    rdx,edi
       mov       r8,rsi
       call      qword ptr [7FFF515E7FF0]; Precode of System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M05_L01:
       mov       rdx,[rbx+8]
       mov       edx,[rdx+8]
       add       edx,edx
       jmp       short M05_L00
; Total bytes of code 105
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateCollection()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+70]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       xor       eax,eax
       mov       [rbp-40],rax
       mov       rbx,rcx
       mov       esi,[rbx+268]
       mov       byte ptr [rbp-40],1
       mov       dword ptr [rbp-3C],2
       test      esi,esi
       setg      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M00_L10
M00_L00:
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Coordinate>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       test      esi,esi
       jl        near ptr M00_L13
       test      esi,esi
       je        near ptr M00_L14
       mov       edx,esi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Coordinate[]
       call      CORINFO_HELP_NEWARR_1_PTR
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M00_L01:
       xor       r14d,r14d
       cmp       r14d,esi
       jl        near ptr M00_L09
M00_L02:
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Coordinate>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp-50],rsi
       mov       rbx,[rbx+60]
       mov       rdx,[rbp-50]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L03:
       call      qword ptr [7FFEFF6F7C00]; System.RuntimeType.CreateInstanceOfT()
       mov       r15,rax
M00_L04:
       xor       ecx,ecx
       mov       [rbp-48],rcx
       mov       ecx,80000000
       mov       edx,7FFFFFFF
       call      qword ptr [7FFEFFD0E070]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       mov       r13,[r15]
       mov       r12,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Coordinate
       cmp       r13,r12
       jne       near ptr M00_L15
       mov       [r15+8],eax
M00_L05:
       mov       ecx,80000000
       mov       edx,7FFFFFFF
       call      qword ptr [7FFEFFD0E070]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       cmp       r13,r12
       jne       near ptr M00_L16
       mov       [r15+0C],eax
M00_L06:
       mov       ecx,80000000
       mov       edx,7FFFFFFF
       call      qword ptr [7FFEFFD0E070]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       cmp       r13,r12
       jne       near ptr M00_L17
       mov       [r15+10],eax
M00_L07:
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       edx,[rdi+10]
       cmp       [rcx+8],edx
       jbe       near ptr M00_L18
       lea       r8d,[rdx+1]
       mov       [rdi+10],r8d
       mov       r8,r15
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
M00_L08:
       add       r14d,1
       jo        near ptr M00_L19
       cmp       r14d,esi
       jge       near ptr M00_L02
M00_L09:
       mov       rcx,226C73C0818
       mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Coordinate
       mov       eax,[rax]
       and       eax,0C0000
       cmp       eax,40000
       sete      al
       movzx     eax,al
       test      eax,eax
       je        near ptr M00_L03
       xor       edx,edx
       mov       [rbp-48],rdx
       lea       rdx,[rbp-48]
       call      qword ptr [7FFF0003D188]
       mov       r15,[rbp-48]
       jmp       near ptr M00_L04
M00_L10:
       movzx     ecx,byte ptr [rbp-40]
       test      cl,cl
       je        short M00_L11
       lea       rcx,[rbp-40]
       call      qword ptr [7FFEFFD0E478]
       mov       esi,eax
       jmp       near ptr M00_L00
M00_L11:
       call      qword ptr [7FFEFFD0E490]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L12
       call      qword ptr [7FFF0003E1C0]
       mov       rbx,rax
M00_L12:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,226C73B3620
       call      qword ptr [7FFEFF97DEC0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L13:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FFEFF97EEE0]
       int       3
M00_L14:
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Coordinate>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1E65B400FB8
       mov       rdx,[rcx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L01
M00_L15:
       mov       rcx,r15
       mov       edx,eax
       mov       r11,7FFEFF641560
       call      qword ptr [r11]
       jmp       near ptr M00_L05
M00_L16:
       mov       rcx,r15
       mov       edx,eax
       mov       r11,7FFEFF641568
       call      qword ptr [r11]
       jmp       near ptr M00_L06
M00_L17:
       mov       rcx,r15
       mov       edx,eax
       mov       r11,7FFEFF641570
       call      qword ptr [r11]
       jmp       near ptr M00_L07
M00_L18:
       mov       rcx,rdi
       mov       rdx,r15
       call      qword ptr [7FFEFF89E370]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M00_L08
       int       3
M00_L19:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       int       3
; Total bytes of code 715
```
```assembly
; System.RuntimeType.CreateInstanceOfT()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       lea       rbp,[rsp+40]
       mov       rbx,rcx
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M01_L00
       mov       rsi,[rcx]
       test      rsi,rsi
       jne       short M01_L03
M01_L00:
       mov       rcx,rbx
       call      qword ptr [7FFEFF6F7C60]; System.RuntimeType.InitializeCache()
M01_L01:
       mov       rdx,[rax+80]
       test      rdx,rdx
       je        short M01_L05
       mov       rcx,[rdx]
       mov       rax,offset MT_System.RuntimeType+ActivatorCache
       cmp       rcx,rax
       jne       short M01_L04
       mov       rsi,rdx
M01_L02:
       cmp       byte ptr [rsi+28],0
       je        short M01_L06
       mov       rax,[rsi+8]
       mov       rcx,[rsi+10]
       call      rax
       mov       rdi,rax
       mov       rax,[rsi+18]
       mov       rcx,rdi
       call      rax
       nop
       mov       rax,rdi
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L03:
       mov       rax,rsi
       jmp       short M01_L01
M01_L04:
       mov       rax,offset MT_System.RuntimeType+CompositeCacheEntry
       cmp       rcx,rax
       jne       short M01_L05
       mov       rsi,[rdx+8]
       test      rsi,rsi
       je        short M01_L05
       jmp       short M01_L02
M01_L05:
       mov       rdx,rbx
       mov       rcx,offset MT_System.RuntimeType+IGenericCacheEntry<System.RuntimeType+ActivatorCache>
       call      qword ptr [7FFEFF6FC528]; System.RuntimeType+IGenericCacheEntry`1[[System.__Canon, System.Private.CoreLib]].CreateAndCache(System.RuntimeType)
       mov       rsi,rax
       jmp       short M01_L02
M01_L06:
       mov       rcx,offset MT_System.MissingMethodException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF0013C060]
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFF0003DC50]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF0013C078]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
       sub       rsp,28
       mov       rdi,rcx
       mov       rcx,offset MT_System.Reflection.TargetInvocationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,rdi
       call      qword ptr [7FFF0013C090]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 274
```
```assembly
; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,68
       vzeroupper
       lea       rbp,[rsp+0A0]
       xor       eax,eax
       mov       [rbp-48],rax
       mov       ebx,ecx
       mov       esi,edx
       lea       rcx,[rbp-80]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rdi,rax
       mov       rdx,rsp
       mov       [rbp-68],rdx
       mov       rdx,rbp
       mov       [rbp-58],rdx
       cmp       ebx,esi
       jge       near ptr M02_L04
       sub       esi,ebx
       dec       esi
       je        near ptr M02_L05
       mov       r14d,esi
       shr       r14d,1
       or        r14d,esi
       mov       edx,r14d
       shr       edx,2
       or        r14d,edx
       mov       edx,r14d
       shr       edx,4
       or        r14d,edx
       mov       edx,r14d
       shr       edx,8
       or        r14d,edx
       mov       edx,r14d
       shr       edx,10
       or        r14d,edx
       xor       edx,edx
       mov       [rbp-3C],edx
M02_L00:
       lea       rdx,[rbp-3C]
       mov       [rbp-48],rdx
       lea       rdx,[rbp-3C]
       mov       r8d,4
       xor       ecx,ecx
       mov       r9d,2
       mov       rax,7FFEFFDA0488
       mov       [rbp-70],rax
       lea       rax,[M02_L01]
       mov       [rbp-60],rax
       lea       rax,[rbp-80]
       mov       [rdi+8],rax
       mov       byte ptr [rdi+4],0
       mov       rax,7FFF8CB23670
       call      rax
M02_L01:
       mov       byte ptr [rdi+4],1
       cmp       dword ptr [7FFF5F64F778],0
       je        short M02_L02
       call      qword ptr [7FFF5F63D608]; CORINFO_HELP_STOP_FOR_GC
M02_L02:
       mov       rcx,[rbp-78]
       mov       [rdi+8],rcx
       test      eax,eax
       jne       short M02_L06
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-48],rax
       mov       eax,r14d
       and       eax,[rbp-3C]
       cmp       eax,esi
       ja        short M02_L00
       add       eax,ebx
M02_L03:
       add       rsp,68
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L04:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF00136658]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFEFFC4E6E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M02_L05:
       mov       eax,ebx
       jmp       short M02_L03
M02_L06:
       mov       ecx,eax
       call      qword ptr [7FFF001365B0]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 342
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       sub       rsp,28
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M03_L03
       lea       rax,[rcx+rdx*8+10]
       mov       rdx,[rcx]
       mov       rdx,[rdx+30]
       test      r8,r8
       je        short M03_L02
       cmp       rdx,[r8]
       jne       short M03_L01
M03_L00:
       mov       rcx,rax
       mov       rdx,r8
       add       rsp,28
       jmp       near ptr 00007FFF5F337B10
M03_L01:
       mov       r10,offset MT_System.Object[]
       cmp       [rcx],r10
       je        short M03_L00
       jmp       short M03_L04
M03_L02:
       xor       ecx,ecx
       mov       [rax],rcx
       add       rsp,28
       ret
M03_L03:
       call      qword ptr [7FFEFFEE4228]
       int       3
M03_L04:
       mov       rcx,rax
       add       rsp,28
       jmp       qword ptr [7FFEFF6FD908]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
; Total bytes of code 96
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M04_L00
       ret
M04_L00:
       jmp       qword ptr [7FFEFF6F5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,[rbx+10]
       mov       ebp,edi
       lea       ecx,[rbp+1]
       mov       r14,[rbx+8]
       cmp       dword ptr [r14+8],0
       jne       near ptr M05_L04
       mov       r15d,4
M05_L00:
       mov       edx,7FFFFFC7
       cmp       r15d,7FFFFFC7
       cmova     r15d,edx
       cmp       r15d,ecx
       cmovl     r15d,ecx
       cmp       r15d,edi
       jl        near ptr M05_L07
       cmp       [r14+8],r15d
       je        short M05_L03
       test      r15d,r15d
       jle       near ptr M05_L08
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+90]
       test      rax,rax
       je        short M05_L05
       mov       rcx,rax
M05_L01:
       mov       edx,r15d
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r15,rax
       test      edi,edi
       jg        short M05_L06
M05_L02:
       lea       rcx,[rbx+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
M05_L03:
       lea       ecx,[rbp+1]
       mov       [rbx+10],ecx
       mov       rcx,[rbx+8]
       movsxd    rdx,ebp
       mov       r8,rsi
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M05_L04:
       mov       r15d,[r14+8]
       add       r15d,r15d
       jmp       near ptr M05_L00
M05_L05:
       mov       rdx,7FFEFFFA3C50
       call      qword ptr [7FFEFF6FC5D0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M05_L01
M05_L06:
       mov       rcx,r14
       mov       r8d,edi
       mov       rdx,r15
       call      qword ptr [7FFEFF6F7060]; System.Array.Copy(System.Array, System.Array, Int32)
       jmp       short M05_L02
M05_L07:
       mov       ecx,7
       mov       edx,0F
       call      qword ptr [7FFEFF97EEE0]
       int       3
M05_L08:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+98]
       test      rdx,rdx
       je        short M05_L09
       jmp       short M05_L10
M05_L09:
       mov       rdx,7FFEFFFA4470
       call      qword ptr [7FFEFF6FC5D0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M05_L10:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M05_L03
; Total bytes of code 321
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateCollection()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+70]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       xor       eax,eax
       mov       [rbp-40],rax
       mov       rbx,rcx
       mov       esi,[rbx+268]
       mov       byte ptr [rbp-40],1
       mov       dword ptr [rbp-3C],2
       test      esi,esi
       setg      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M00_L11
M00_L00:
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Coordinate>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       test      esi,esi
       jl        near ptr M00_L14
       test      esi,esi
       je        near ptr M00_L15
       mov       edx,esi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Coordinate[]
       call      CORINFO_HELP_NEWARR_1_PTR
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M00_L01:
       xor       r14d,r14d
       cmp       r14d,esi
       jl        near ptr M00_L09
M00_L02:
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Coordinate>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp-50],rsi
       mov       rbx,[rbx+60]
       mov       rdx,[rbp-50]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L03:
       call      qword ptr [7FFEFF707C00]; System.RuntimeType.CreateInstanceOfT()
       mov       r15,rax
M00_L04:
       xor       ecx,ecx
       mov       [rbp-48],rcx
       mov       ecx,80000000
       mov       edx,7FFFFFFF
       call      qword ptr [7FFEFFD1E070]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       mov       r13,[r15]
       mov       r12,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Coordinate
       cmp       r13,r12
       jne       near ptr M00_L16
       mov       [r15+8],eax
M00_L05:
       mov       ecx,80000000
       mov       edx,7FFFFFFF
       call      qword ptr [7FFEFFD1E070]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       cmp       r13,r12
       jne       near ptr M00_L17
       mov       [r15+0C],eax
M00_L06:
       mov       ecx,80000000
       mov       edx,7FFFFFFF
       call      qword ptr [7FFEFFD1E070]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       cmp       r13,r12
       jne       near ptr M00_L18
       mov       [r15+10],eax
M00_L07:
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       edx,[rdi+10]
       cmp       [rcx+8],edx
       jbe       short M00_L10
       lea       r8d,[rdx+1]
       mov       [rdi+10],r8d
       mov       edx,edx
       mov       r8,r15
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
M00_L08:
       add       r14d,1
       jo        near ptr M00_L19
       cmp       r14d,esi
       jge       near ptr M00_L02
M00_L09:
       mov       rcx,2D976260818
       mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Coordinate
       mov       eax,[rax]
       and       eax,0C0000
       cmp       eax,40000
       sete      al
       movzx     eax,al
       test      eax,eax
       je        near ptr M00_L03
       xor       edx,edx
       mov       [rbp-48],rdx
       lea       rdx,[rbp-48]
       call      qword ptr [7FFF0007E9E8]
       mov       r15,[rbp-48]
       jmp       near ptr M00_L04
M00_L10:
       mov       rcx,rdi
       mov       rdx,r15
       call      qword ptr [7FFEFF8AE370]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M00_L08
M00_L11:
       movzx     ecx,byte ptr [rbp-40]
       test      cl,cl
       je        short M00_L12
       lea       rcx,[rbp-40]
       call      qword ptr [7FFEFFD1E478]
       mov       esi,eax
       jmp       near ptr M00_L00
M00_L12:
       call      qword ptr [7FFEFFD1E490]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L13
       call      qword ptr [7FFEFFF06130]
       mov       rbx,rax
M00_L13:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,2D976253620
       call      qword ptr [7FFEFF98DEC0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L14:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FFEFF98EEE0]
       int       3
M00_L15:
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Coordinate>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,2990E400FE8
       mov       rdx,[rcx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L01
M00_L16:
       mov       rcx,r15
       mov       edx,eax
       mov       r11,7FFEFF6517F8
       call      qword ptr [r11]
       jmp       near ptr M00_L05
M00_L17:
       mov       rcx,r15
       mov       edx,eax
       mov       r11,7FFEFF651800
       call      qword ptr [r11]
       jmp       near ptr M00_L06
M00_L18:
       mov       rcx,r15
       mov       edx,eax
       mov       r11,7FFEFF651808
       call      qword ptr [r11]
       jmp       near ptr M00_L07
       int       3
M00_L19:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       int       3
; Total bytes of code 710
```
```assembly
; System.RuntimeType.CreateInstanceOfT()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       lea       rbp,[rsp+40]
       mov       rbx,rcx
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M01_L00
       mov       rsi,[rcx]
       test      rsi,rsi
       jne       short M01_L03
M01_L00:
       mov       rcx,rbx
       call      qword ptr [7FFEFF707C60]; System.RuntimeType.InitializeCache()
M01_L01:
       mov       rdx,[rax+80]
       test      rdx,rdx
       je        short M01_L05
       mov       rcx,[rdx]
       mov       rax,offset MT_System.RuntimeType+ActivatorCache
       cmp       rcx,rax
       jne       short M01_L04
       mov       rsi,rdx
M01_L02:
       cmp       byte ptr [rsi+28],0
       je        short M01_L06
       mov       rax,[rsi+8]
       mov       rcx,[rsi+10]
       call      rax
       mov       rdi,rax
       mov       rax,[rsi+18]
       mov       rcx,rdi
       call      rax
       nop
       mov       rax,rdi
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L03:
       mov       rax,rsi
       jmp       short M01_L01
M01_L04:
       mov       rax,offset MT_System.RuntimeType+CompositeCacheEntry
       cmp       rcx,rax
       jne       short M01_L05
       mov       rsi,[rdx+8]
       test      rsi,rsi
       je        short M01_L05
       jmp       short M01_L02
M01_L05:
       mov       rdx,rbx
       mov       rcx,offset MT_System.RuntimeType+IGenericCacheEntry<System.RuntimeType+ActivatorCache>
       call      qword ptr [7FFEFF70C528]; System.RuntimeType+IGenericCacheEntry`1[[System.__Canon, System.Private.CoreLib]].CreateAndCache(System.RuntimeType)
       mov       rsi,rax
       jmp       short M01_L02
M01_L06:
       mov       rcx,offset MT_System.MissingMethodException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF001EC1C8]
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFEFFF064A8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF001EC1E0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
       sub       rsp,28
       mov       rdi,rcx
       mov       rcx,offset MT_System.Reflection.TargetInvocationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,rdi
       call      qword ptr [7FFF001EC1F8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 274
```
```assembly
; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,68
       vzeroupper
       lea       rbp,[rsp+0A0]
       xor       eax,eax
       mov       [rbp-48],rax
       mov       ebx,ecx
       mov       esi,edx
       lea       rcx,[rbp-80]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rdi,rax
       mov       rdx,rsp
       mov       [rbp-68],rdx
       mov       rdx,rbp
       mov       [rbp-58],rdx
       cmp       ebx,esi
       jge       near ptr M02_L04
       sub       esi,ebx
       dec       esi
       je        near ptr M02_L05
       mov       r14d,esi
       shr       r14d,1
       or        r14d,esi
       mov       edx,r14d
       shr       edx,2
       or        r14d,edx
       mov       edx,r14d
       shr       edx,4
       or        r14d,edx
       mov       edx,r14d
       shr       edx,8
       or        r14d,edx
       mov       edx,r14d
       shr       edx,10
       or        r14d,edx
       xor       edx,edx
       mov       [rbp-3C],edx
M02_L00:
       lea       rdx,[rbp-3C]
       mov       [rbp-48],rdx
       lea       rdx,[rbp-3C]
       mov       r8d,4
       xor       ecx,ecx
       mov       r9d,2
       mov       rax,7FFEFFDB0488
       mov       [rbp-70],rax
       lea       rax,[M02_L01]
       mov       [rbp-60],rax
       lea       rax,[rbp-80]
       mov       [rdi+8],rax
       mov       byte ptr [rdi+4],0
       mov       rax,7FFF8CB23670
       call      rax
M02_L01:
       mov       byte ptr [rdi+4],1
       cmp       dword ptr [7FFF5F64F778],0
       je        short M02_L02
       call      qword ptr [7FFF5F63D608]; CORINFO_HELP_STOP_FOR_GC
M02_L02:
       mov       rcx,[rbp-78]
       mov       [rdi+8],rcx
       test      eax,eax
       jne       short M02_L06
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-48],rax
       mov       eax,r14d
       and       eax,[rbp-3C]
       cmp       eax,esi
       ja        short M02_L00
       add       eax,ebx
M02_L03:
       add       rsp,68
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L04:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF001E67D8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFEFFC5E6E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M02_L05:
       mov       eax,ebx
       jmp       short M02_L03
M02_L06:
       mov       ecx,eax
       call      qword ptr [7FFF001E6730]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 342
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       sub       rsp,28
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M03_L02
       lea       rax,[rcx+rdx*8+10]
       mov       rdx,[rcx]
       mov       rdx,[rdx+30]
       test      r8,r8
       je        short M03_L01
       cmp       rdx,[r8]
       je        short M03_L00
       mov       r10,offset MT_System.Object[]
       cmp       [rcx],r10
       jne       short M03_L03
M03_L00:
       mov       rcx,rax
       mov       rdx,r8
       add       rsp,28
       jmp       near ptr 00007FFF5F337B10
M03_L01:
       xor       ecx,ecx
       mov       [rax],rcx
       add       rsp,28
       ret
M03_L02:
       call      qword ptr [7FFEFFE97D38]
       int       3
M03_L03:
       mov       rcx,rax
       add       rsp,28
       jmp       qword ptr [7FFEFF70D908]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
; Total bytes of code 94
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,[rbx+10]
       mov       ebp,edi
       lea       ecx,[rbp+1]
       mov       r14,[rbx+8]
       cmp       dword ptr [r14+8],0
       jne       near ptr M04_L04
       mov       r15d,4
M04_L00:
       mov       edx,7FFFFFC7
       cmp       r15d,7FFFFFC7
       cmova     r15d,edx
       cmp       r15d,ecx
       cmovl     r15d,ecx
       cmp       r15d,edi
       jl        near ptr M04_L07
       cmp       [r14+8],r15d
       je        short M04_L03
       test      r15d,r15d
       jle       near ptr M04_L08
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+70]
       test      rax,rax
       je        short M04_L05
       mov       rcx,rax
M04_L01:
       mov       edx,r15d
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r15,rax
       test      edi,edi
       jg        short M04_L06
M04_L02:
       lea       rcx,[rbx+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
M04_L03:
       lea       ecx,[rbp+1]
       mov       [rbx+10],ecx
       mov       rcx,[rbx+8]
       movsxd    rdx,ebp
       mov       r8,rsi
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M04_L04:
       mov       r15d,[r14+8]
       add       r15d,r15d
       jmp       near ptr M04_L00
M04_L05:
       mov       rdx,7FFEFFEE1038
       call      qword ptr [7FFEFF70C5D0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M04_L01
M04_L06:
       mov       rcx,r14
       mov       r8d,edi
       mov       rdx,r15
       call      qword ptr [7FFEFF707060]; System.Array.Copy(System.Array, System.Array, Int32)
       jmp       short M04_L02
M04_L07:
       mov       ecx,7
       mov       edx,0F
       call      qword ptr [7FFEFF98EEE0]
       int       3
M04_L08:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+78]
       test      rdx,rdx
       je        short M04_L09
       jmp       short M04_L10
M04_L09:
       mov       rdx,7FFEFFEE1890
       call      qword ptr [7FFEFF70C5D0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M04_L10:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M04_L03
; Total bytes of code 315
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M05_L00
       ret
M05_L00:
       jmp       qword ptr [7FFEFF705C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCreditCards()
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-28],rax
       mov       [rbp-30],rax
       mov       rbx,rcx
       mov       ecx,[rbx+268]
       mov       byte ptr [rbp-28],1
       mov       dword ptr [rbp-24],2
       test      ecx,ecx
       setg      al
       movzx     eax,al
       test      eax,eax
       je        short M00_L02
M00_L00:
       call      qword ptr [7FFEFFF9D6B0]; DotNetTips.Spargine.Tester.RandomCreditCardNumberGenerator.GetCreditCardNumbers(Int32)
       mov       rsi,rax
       test      rsi,rsi
       je        near ptr M00_L05
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Generic.IList<System.String>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M00_L06
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
M00_L01:
       mov       [rbp-30],r14
       mov       rbx,[rbx+60]
       mov       rdx,[rbp-30]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M00_L02:
       movzx     ecx,byte ptr [rbp-28]
       test      cl,cl
       je        short M00_L03
       lea       rcx,[rbp-28]
       call      qword ptr [7FFEFFD2E478]
       mov       ecx,eax
       jmp       near ptr M00_L00
M00_L03:
       call      qword ptr [7FFEFFD2E490]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L04
       call      qword ptr [7FFF0004EC40]
       mov       rbx,rax
M00_L04:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,29F018E3620
       call      qword ptr [7FFEFF99DEC0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       call      qword ptr [7FFEFF99D968]
       mov       ecx,5B
       mov       rdx,7FFEFFD5F450
       call      qword ptr [7FFEFF997738]
       mov       rbx,rax
       mov       ecx,1B61
       mov       rdx,7FFEFFA65D90
       call      qword ptr [7FFEFF997738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFEFF717870]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFEFFD5F450
       call      qword ptr [7FFEFF997738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFEFF717870]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFEFFE9F258]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFEFFE9F270]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L06:
       mov       rdx,rsi
       mov       rcx,offset MT_System.String[]
       call      qword ptr [7FFEFF7158F0]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        short M00_L07
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       rdx,rdi
       call      qword ptr [7FFEFFB15E00]; System.Collections.ObjectModel.ReadOnlyCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IList`1<System.__Canon>)
       jmp       near ptr M00_L01
M00_L07:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Generic.ICollection<System.String>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       r14,rax
       test      r14,r14
       je        near ptr M00_L11
       mov       rcx,offset MT_System.Collections.Generic.List<System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,r14
       mov       r11,7FFEFF660F28
       call      qword ptr [r11]
       mov       edx,eax
       mov       rcx,rdi
       call      qword ptr [7FFEFF99EC70]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,rsi
       mov       r11,7FFEFF660F30
       call      qword ptr [r11]
       mov       [rbp-38],rax
M00_L08:
       mov       rcx,[rbp-38]
       mov       r11,7FFEFF660F38
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L10
       mov       rcx,[rbp-38]
       mov       r11,7FFEFF660F40
       call      qword ptr [r11]
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       edx,[rdi+10]
       cmp       [rcx+8],edx
       jbe       short M00_L09
       lea       r8d,[rdx+1]
       mov       [rdi+10],r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M00_L08
M00_L09:
       mov       rcx,rdi
       mov       rdx,rax
       call      qword ptr [7FFEFF8BE370]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M00_L08
M00_L10:
       mov       rcx,[rbp-38]
       mov       r11,7FFEFF660F48
       call      qword ptr [r11]
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       rdx,rdi
       call      qword ptr [7FFEFFB15E00]; System.Collections.ObjectModel.ReadOnlyCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IList`1<System.__Canon>)
       jmp       near ptr M00_L01
M00_L11:
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdx,rsi
       mov       rcx,7FFF0011B4D8
       call      qword ptr [7FFEFFD2D5F0]; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFEFFB15E00]; System.Collections.ObjectModel.ReadOnlyCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IList`1<System.__Canon>)
       jmp       near ptr M00_L01
       sub       rsp,28
       cmp       qword ptr [rbp-38],0
       je        short M00_L12
       mov       rcx,[rbp-38]
       mov       r11,7FFEFF660F48
       call      qword ptr [r11]
M00_L12:
       nop
       add       rsp,28
       ret
; Total bytes of code 807
```
```assembly
; DotNetTips.Spargine.Tester.RandomCreditCardNumberGenerator.GetCreditCardNumbers(Int32)
; 		count = count.ArgumentInRange(min: 1);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var result = new List<string>(count);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		for (var cardCount = 0; cardCount < count; cardCount++)
; 		     ^^^^^^^^^^^^^^^^^
; 			var prefixAndLength = _prefixes[RandomNumberGenerator.GetInt32(0, _prefixes.Length)];
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			result.Add(CreateFakeCreditCardNumber(prefixAndLength.Prefix, prefixAndLength.Length));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return result.AsReadOnly();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       vzeroupper
       lea       rbp,[rsp+0C0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       xor       eax,eax
       mov       [rbp-40],rax
       mov       ebx,ecx
       lea       rcx,[rbp-88]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rcx,rsp
       mov       [rbp-70],rcx
       mov       rcx,rbp
       mov       [rbp-60],rcx
       test      ebx,ebx
       setg      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M01_L09
M01_L00:
       mov       rcx,offset MT_System.Collections.Generic.List<System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       test      ebx,ebx
       jl        near ptr M01_L12
       test      ebx,ebx
       je        near ptr M01_L13
       mov       edx,ebx
       mov       rcx,offset MT_System.String[]
       call      CORINFO_HELP_NEWARR_1_PTR
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M01_L01:
       mov       [rbp-90],rdi
       xor       r14d,r14d
       cmp       r14d,ebx
       jge       near ptr M01_L07
M01_L02:
       mov       rdx,25E95800EA0
       mov       r15,[rdx]
       mov       [rbp-98],r15
       xor       edx,edx
       mov       [rbp-44],edx
M01_L03:
       lea       rdx,[rbp-44]
       mov       [rbp-50],rdx
       lea       rdx,[rbp-44]
       mov       r8d,4
       xor       ecx,ecx
       mov       r9d,2
       mov       rax,7FFEFFDC0488
       mov       [rbp-78],rax
       lea       rax,[M01_L04]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFF8CB23670
       call      rax
M01_L04:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFF5F64F778],0
       je        short M01_L05
       call      qword ptr [7FFF5F63D608]; CORINFO_HELP_STOP_FOR_GC
M01_L05:
       mov       rcx,[rbp-80]
       mov       [rsi+8],rcx
       test      eax,eax
       jne       near ptr M01_L15
       xor       ecx,ecx
       mov       [rbp-50],rcx
       mov       [rbp-50],rcx
       mov       ecx,[rbp-44]
       and       ecx,3F
       cmp       ecx,31
       ja        near ptr M01_L03
       mov       ecx,ecx
       shl       rcx,4
       mov       r15,[rbp-98]
       lea       rcx,[r15+rcx+10]
       mov       rdx,[rcx]
       mov       eax,[rcx+8]
       mov       rcx,rdx
       mov       edx,eax
       call      qword ptr [7FFEFFF9D7A0]; DotNetTips.Spargine.Tester.RandomCreditCardNumberGenerator.CreateFakeCreditCardNumber(System.String, Int32)
       mov       rdi,[rbp-90]
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       edx,[rdi+10]
       mov       r8d,[rcx+8]
       cmp       r8d,edx
       jbe       near ptr M01_L14
       lea       r8d,[rdx+1]
       mov       [rdi+10],r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M01_L06:
       add       r14d,1
       jo        near ptr M01_L16
       cmp       r14d,ebx
       jge       short M01_L08
       jmp       near ptr M01_L02
M01_L07:
       mov       rdi,[rbp-90]
M01_L08:
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
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
M01_L09:
       movzx     ecx,byte ptr [rbp-40]
       test      cl,cl
       je        short M01_L10
       lea       rcx,[rbp-40]
       call      qword ptr [7FFEFFD2E478]
       mov       ebx,eax
       jmp       near ptr M01_L00
M01_L10:
       call      qword ptr [7FFEFFD2E490]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L11
       call      qword ptr [7FFF0004EC40]
       mov       rbx,rax
M01_L11:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,29F018E3620
       call      qword ptr [7FFEFF99DEC0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M01_L12:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FFEFF99EEE0]
       int       3
M01_L13:
       mov       rcx,25E6C800230
       mov       rdx,[rcx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L01
M01_L14:
       mov       rcx,rdi
       mov       rdx,rax
       call      qword ptr [7FFEFF8BE370]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M01_L06
M01_L15:
       mov       ecx,eax
       call      qword ptr [7FFF0004D6B0]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M01_L16:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 684
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rdx,rdx
       je        short M02_L06
       mov       rax,[rdx]
       movzx     r8d,word ptr [rax+0E]
       test      r8,r8
       je        short M02_L03
       mov       r10,[rax+38]
       cmp       r8,4
       jl        short M02_L01
       cmp       [r10],rcx
       je        short M02_L06
M02_L00:
       cmp       [r10+8],rcx
       je        short M02_L06
       cmp       [r10+10],rcx
       je        short M02_L06
       cmp       [r10+18],rcx
       je        short M02_L06
       add       r10,20
       add       r8,0FFFFFFFFFFFFFFFC
       cmp       r8,4
       jge       short M02_L04
       test      r8,r8
       je        short M02_L03
M02_L01:
       cmp       [r10],rcx
       je        short M02_L06
M02_L02:
       add       r10,8
       dec       r8
       test      r8,r8
       jle       short M02_L03
       cmp       [r10],rcx
       je        short M02_L06
       jmp       short M02_L02
M02_L03:
       test      dword ptr [rax],500C0000
       je        short M02_L05
       jmp       qword ptr [7FFEFFD27918]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
M02_L04:
       cmp       [r10],rcx
       je        short M02_L06
       jmp       short M02_L00
M02_L05:
       xor       edx,edx
M02_L06:
       mov       rax,rdx
       ret
; Total bytes of code 121
```
```assembly
; System.String.Concat(System.String, System.String)
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       test      rbx,rbx
       je        near ptr M03_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M03_L01
       test      rsi,rsi
       je        short M03_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M03_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M03_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFF5F338D20
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFEFF715818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFEFF715818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L00:
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L01:
       test      rsi,rsi
       je        short M03_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M03_L03
M03_L02:
       mov       rax,29F018E0008
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L03:
       mov       rax,rsi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L04:
       call      qword ptr [7FFF001340C0]
       int       3
; Total bytes of code 244
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
       push      rsi
       push      rbx
       test      rdx,rdx
       je        short M04_L02
       mov       rax,[rdx]
       cmp       rax,rcx
       je        short M04_L02
       mov       r8,25E6C800038
       mov       r8,[r8]
       add       r8,10
       rorx      r10,rax,20
       xor       r10,rcx
       mov       r9,9E3779B97F4A7C15
       imul      r10,r9
       mov       r9d,[r8]
       shrx      r10,r10,r9
       xor       r9d,r9d
M04_L00:
       lea       r11d,[r10+1]
       movsxd    r11,r11d
       lea       r11,[r11+r11*2]
       lea       r11,[r8+r11*8]
       mov       ebx,[r11]
       mov       rsi,[r11+8]
       and       ebx,0FFFFFFFE
       cmp       rsi,rax
       jne       short M04_L03
       mov       rsi,rcx
       xor       rsi,[r11+10]
       cmp       rsi,1
       ja        short M04_L03
       cmp       ebx,[r11]
       jne       short M04_L04
M04_L01:
       cmp       esi,1
       je        short M04_L02
       test      esi,esi
       jne       short M04_L05
       xor       edx,edx
M04_L02:
       mov       rax,rdx
       pop       rbx
       pop       rsi
       ret
M04_L03:
       test      ebx,ebx
       je        short M04_L04
       inc       r9d
       add       r10d,r9d
       and       r10d,[r8+4]
       cmp       r9d,8
       jl        short M04_L00
M04_L04:
       mov       esi,2
       jmp       short M04_L01
M04_L05:
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFEFF71D920]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny_NoCacheLookup(Void*, System.Object)
; Total bytes of code 166
```
```assembly
; System.Collections.ObjectModel.ReadOnlyCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IList`1<System.__Canon>)
       sub       rsp,28
       test      rdx,rdx
       je        short M05_L00
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       ret
M05_L00:
       mov       ecx,14
       call      qword ptr [7FFEFF99C1C8]
       int       3
; Total bytes of code 36
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       ebx,edx
       test      ebx,ebx
       jl        short M06_L03
       test      ebx,ebx
       je        short M06_L04
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+0B0]
       test      rax,rax
       je        short M06_L02
       mov       rcx,rax
M06_L00:
       mov       edx,ebx
       call      CORINFO_HELP_NEWARR_1_PTR
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M06_L01:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M06_L02:
       mov       rdx,7FFF000CDB00
       call      qword ptr [7FFEFF71C5D0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M06_L00
M06_L03:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FFEFF99EEE0]
       int       3
M06_L04:
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+0B8]
       test      rdx,rdx
       je        short M06_L05
       jmp       short M06_L06
M06_L05:
       mov       rdx,7FFF000CDB08
       call      qword ptr [7FFEFF71C5D0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M06_L06:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M06_L01
; Total bytes of code 179
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,[rbx+10]
       lea       ebp,[rdi+1]
       mov       ecx,ebp
       mov       rdx,[rbx+8]
       cmp       dword ptr [rdx+8],0
       jne       short M07_L01
       mov       edx,4
M07_L00:
       mov       eax,7FFFFFC7
       cmp       edx,7FFFFFC7
       cmova     edx,eax
       cmp       edx,ecx
       cmovl     edx,ecx
       mov       rcx,rbx
       call      qword ptr [7FFF5160DD70]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
       mov       [rbx+10],ebp
       mov       rcx,[rbx+8]
       movsxd    rdx,edi
       mov       r8,rsi
       call      qword ptr [7FFF515E7FF0]; Precode of System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M07_L01:
       mov       rdx,[rbx+8]
       mov       edx,[rdx+8]
       add       edx,edx
       jmp       short M07_L00
; Total bytes of code 105
```
```assembly
; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        short M08_L02
       call      qword ptr [7FFF6B925730]
       cmp       byte ptr [rax],0
       jne       short M08_L00
       mov       rcx,rsi
       call      qword ptr [7FFF6B927878]
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFF6B9256E8]; Precode of System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
       test      rax,rax
       jne       short M08_L01
M08_L00:
       mov       rcx,rsi
       call      qword ptr [7FFF6B927880]
       mov       rcx,rax
       call      qword ptr [7FFF6B9256D0]; CORINFO_HELP_NEWFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFF6B929010]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M08_L01:
       mov       rcx,rax
       lea       r11,[System.Linq.Enumerable.Select[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>)]
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [r11]
M08_L02:
       mov       ecx,11
       call      qword ptr [7FFF6B9295A8]
       int       3
; Total bytes of code 133
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCreditCards()
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-28],rax
       mov       [rbp-30],rax
       mov       rbx,rcx
       mov       ecx,[rbx+268]
       mov       byte ptr [rbp-28],1
       mov       dword ptr [rbp-24],2
       test      ecx,ecx
       setg      al
       movzx     eax,al
       test      eax,eax
       je        short M00_L02
M00_L00:
       call      qword ptr [7FFEFFF8D5C0]; DotNetTips.Spargine.Tester.RandomCreditCardNumberGenerator.GetCreditCardNumbers(Int32)
       mov       rsi,rax
       test      rsi,rsi
       je        near ptr M00_L05
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Generic.IList<System.String>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M00_L06
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
M00_L01:
       mov       [rbp-30],r14
       mov       rbx,[rbx+60]
       mov       rdx,[rbp-30]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M00_L02:
       movzx     ecx,byte ptr [rbp-28]
       test      cl,cl
       je        short M00_L03
       lea       rcx,[rbp-28]
       call      qword ptr [7FFEFFD1E478]
       mov       ecx,eax
       jmp       near ptr M00_L00
M00_L03:
       call      qword ptr [7FFEFFD1E490]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L04
       call      qword ptr [7FFF0003EB50]
       mov       rbx,rax
M00_L04:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,1DB36C13620
       call      qword ptr [7FFEFF98DEC0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       call      qword ptr [7FFEFF98D968]
       mov       ecx,5B
       mov       rdx,7FFEFFD4F450
       call      qword ptr [7FFEFF987738]
       mov       rbx,rax
       mov       ecx,1B61
       mov       rdx,7FFEFFA55D90
       call      qword ptr [7FFEFF987738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFEFF707870]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFEFFD4F450
       call      qword ptr [7FFEFF987738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFEFF707870]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFEFFE8F258]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFEFFE8F270]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L06:
       mov       rdx,rsi
       mov       rcx,offset MT_System.String[]
       call      qword ptr [7FFEFF7058F0]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        short M00_L07
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       rdx,rdi
       call      qword ptr [7FFEFFB05E00]; System.Collections.ObjectModel.ReadOnlyCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IList`1<System.__Canon>)
       jmp       near ptr M00_L01
M00_L07:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Generic.ICollection<System.String>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       r14,rax
       test      r14,r14
       je        near ptr M00_L11
       mov       rcx,offset MT_System.Collections.Generic.List<System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,r14
       mov       r11,7FFEFF650F18
       call      qword ptr [r11]
       mov       edx,eax
       mov       rcx,rdi
       call      qword ptr [7FFEFF98EC70]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,rsi
       mov       r11,7FFEFF650F20
       call      qword ptr [r11]
       mov       [rbp-38],rax
M00_L08:
       mov       rcx,[rbp-38]
       mov       r11,7FFEFF650F28
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L10
       mov       rcx,[rbp-38]
       mov       r11,7FFEFF650F30
       call      qword ptr [r11]
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       edx,[rdi+10]
       cmp       [rcx+8],edx
       jbe       short M00_L09
       lea       r8d,[rdx+1]
       mov       [rdi+10],r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M00_L08
M00_L09:
       mov       rcx,rdi
       mov       rdx,rax
       call      qword ptr [7FFEFF8AE370]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M00_L08
M00_L10:
       mov       rcx,[rbp-38]
       mov       r11,7FFEFF650F38
       call      qword ptr [r11]
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       rdx,rdi
       call      qword ptr [7FFEFFB05E00]; System.Collections.ObjectModel.ReadOnlyCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IList`1<System.__Canon>)
       jmp       near ptr M00_L01
M00_L11:
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdx,rsi
       mov       rcx,7FFF00109920
       call      qword ptr [7FFEFFD1D5F0]; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFEFFB05E00]; System.Collections.ObjectModel.ReadOnlyCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IList`1<System.__Canon>)
       jmp       near ptr M00_L01
       sub       rsp,28
       cmp       qword ptr [rbp-38],0
       je        short M00_L12
       mov       rcx,[rbp-38]
       mov       r11,7FFEFF650F38
       call      qword ptr [r11]
M00_L12:
       nop
       add       rsp,28
       ret
; Total bytes of code 807
```
```assembly
; DotNetTips.Spargine.Tester.RandomCreditCardNumberGenerator.GetCreditCardNumbers(Int32)
; 		count = count.ArgumentInRange(min: 1);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var result = new List<string>(count);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		for (var cardCount = 0; cardCount < count; cardCount++)
; 		     ^^^^^^^^^^^^^^^^^
; 			var prefixAndLength = _prefixes[RandomNumberGenerator.GetInt32(0, _prefixes.Length)];
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			result.Add(CreateFakeCreditCardNumber(prefixAndLength.Prefix, prefixAndLength.Length));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return result.AsReadOnly();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       vzeroupper
       lea       rbp,[rsp+0C0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       xor       eax,eax
       mov       [rbp-40],rax
       mov       ebx,ecx
       lea       rcx,[rbp-88]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rcx,rsp
       mov       [rbp-70],rcx
       mov       rcx,rbp
       mov       [rbp-60],rcx
       test      ebx,ebx
       setg      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M01_L08
M01_L00:
       mov       rcx,offset MT_System.Collections.Generic.List<System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       test      ebx,ebx
       jl        near ptr M01_L11
       test      ebx,ebx
       je        near ptr M01_L12
       mov       edx,ebx
       mov       rcx,offset MT_System.String[]
       call      CORINFO_HELP_NEWARR_1_PTR
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M01_L01:
       mov       [rbp-90],rdi
       xor       r14d,r14d
       cmp       r14d,ebx
       jl        short M01_L02
       jmp       near ptr M01_L13
M01_L02:
       mov       rdx,19ACEC00EA0
       mov       r15,[rdx]
       mov       [rbp-98],r15
       xor       edx,edx
       mov       [rbp-44],edx
M01_L03:
       lea       rdx,[rbp-44]
       mov       [rbp-50],rdx
       lea       rdx,[rbp-44]
       mov       r8d,4
       xor       ecx,ecx
       mov       r9d,2
       mov       rax,7FFEFFDB0488
       mov       [rbp-78],rax
       lea       rax,[M01_L04]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFF8CB23670
       call      rax
M01_L04:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFF5F64F778],0
       je        short M01_L05
       call      qword ptr [7FFF5F63D608]; CORINFO_HELP_STOP_FOR_GC
M01_L05:
       mov       rcx,[rbp-80]
       mov       [rsi+8],rcx
       test      eax,eax
       jne       near ptr M01_L15
       xor       ecx,ecx
       mov       [rbp-50],rcx
       mov       [rbp-50],rcx
       mov       ecx,[rbp-44]
       and       ecx,3F
       cmp       ecx,31
       ja        near ptr M01_L03
       mov       ecx,ecx
       shl       rcx,4
       mov       r15,[rbp-98]
       lea       rcx,[r15+rcx+10]
       mov       rdx,[rcx]
       mov       eax,[rcx+8]
       mov       rcx,rdx
       mov       edx,eax
       call      qword ptr [7FFEFFF8D6B0]; DotNetTips.Spargine.Tester.RandomCreditCardNumberGenerator.CreateFakeCreditCardNumber(System.String, Int32)
       mov       rdi,[rbp-90]
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       edx,[rdi+10]
       mov       r8d,[rcx+8]
       cmp       r8d,edx
       jbe       near ptr M01_L14
       lea       r8d,[rdx+1]
       mov       [rdi+10],r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M01_L06:
       add       r14d,1
       jo        near ptr M01_L16
       cmp       r14d,ebx
       jl        near ptr M01_L02
M01_L07:
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
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
M01_L08:
       movzx     ecx,byte ptr [rbp-40]
       test      cl,cl
       je        short M01_L09
       lea       rcx,[rbp-40]
       call      qword ptr [7FFEFFD1E478]
       mov       ebx,eax
       jmp       near ptr M01_L00
M01_L09:
       call      qword ptr [7FFEFFD1E490]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L10
       call      qword ptr [7FFF0003EB50]
       mov       rbx,rax
M01_L10:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,1DB36C13620
       call      qword ptr [7FFEFF98DEC0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M01_L11:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FFEFF98EEE0]
       int       3
M01_L12:
       mov       rcx,19AA1C00230
       mov       rdx,[rcx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L01
M01_L13:
       mov       rdi,[rbp-90]
       jmp       near ptr M01_L07
M01_L14:
       mov       rcx,rdi
       mov       rdx,rax
       call      qword ptr [7FFEFF8AE370]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M01_L06
M01_L15:
       mov       ecx,eax
       call      qword ptr [7FFF0003D6F8]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M01_L16:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 689
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rdx,rdx
       je        short M02_L06
       mov       rax,[rdx]
       movzx     r8d,word ptr [rax+0E]
       test      r8,r8
       je        short M02_L03
       mov       r10,[rax+38]
       cmp       r8,4
       jl        short M02_L01
       cmp       [r10],rcx
       je        short M02_L06
M02_L00:
       cmp       [r10+8],rcx
       je        short M02_L06
       cmp       [r10+10],rcx
       je        short M02_L06
       cmp       [r10+18],rcx
       je        short M02_L06
       add       r10,20
       add       r8,0FFFFFFFFFFFFFFFC
       cmp       r8,4
       jge       short M02_L04
       test      r8,r8
       je        short M02_L03
M02_L01:
       cmp       [r10],rcx
       je        short M02_L06
M02_L02:
       add       r10,8
       dec       r8
       test      r8,r8
       jle       short M02_L03
       cmp       [r10],rcx
       je        short M02_L06
       jmp       short M02_L02
M02_L03:
       test      dword ptr [rax],500C0000
       je        short M02_L05
       jmp       qword ptr [7FFEFFD17918]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
M02_L04:
       cmp       [r10],rcx
       je        short M02_L06
       jmp       short M02_L00
M02_L05:
       xor       edx,edx
M02_L06:
       mov       rax,rdx
       ret
; Total bytes of code 121
```
```assembly
; System.String.Concat(System.String, System.String)
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       test      rbx,rbx
       je        near ptr M03_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M03_L01
       test      rsi,rsi
       je        short M03_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M03_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M03_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFF5F338D20
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFEFF705818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFEFF705818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L00:
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L01:
       test      rsi,rsi
       je        short M03_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M03_L03
M03_L02:
       mov       rax,1DB36C10008
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L03:
       mov       rax,rsi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L04:
       call      qword ptr [7FFF00124090]
       int       3
; Total bytes of code 244
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
       push      rsi
       push      rbx
       test      rdx,rdx
       je        short M04_L02
       mov       rax,[rdx]
       cmp       rax,rcx
       je        short M04_L02
       mov       r8,19AA1C00038
       mov       r8,[r8]
       add       r8,10
       rorx      r10,rax,20
       xor       r10,rcx
       mov       r9,9E3779B97F4A7C15
       imul      r10,r9
       mov       r9d,[r8]
       shrx      r10,r10,r9
       xor       r9d,r9d
M04_L00:
       lea       r11d,[r10+1]
       movsxd    r11,r11d
       lea       r11,[r11+r11*2]
       lea       r11,[r8+r11*8]
       mov       ebx,[r11]
       mov       rsi,[r11+8]
       and       ebx,0FFFFFFFE
       cmp       rsi,rax
       jne       short M04_L03
       mov       rsi,rcx
       xor       rsi,[r11+10]
       cmp       rsi,1
       ja        short M04_L03
       cmp       ebx,[r11]
       jne       short M04_L04
M04_L01:
       cmp       esi,1
       je        short M04_L02
       test      esi,esi
       jne       short M04_L05
       xor       edx,edx
M04_L02:
       mov       rax,rdx
       pop       rbx
       pop       rsi
       ret
M04_L03:
       test      ebx,ebx
       je        short M04_L04
       inc       r9d
       add       r10d,r9d
       and       r10d,[r8+4]
       cmp       r9d,8
       jl        short M04_L00
M04_L04:
       mov       esi,2
       jmp       short M04_L01
M04_L05:
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFEFF70D920]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny_NoCacheLookup(Void*, System.Object)
; Total bytes of code 166
```
```assembly
; System.Collections.ObjectModel.ReadOnlyCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IList`1<System.__Canon>)
       sub       rsp,28
       test      rdx,rdx
       je        short M05_L00
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       ret
M05_L00:
       mov       ecx,14
       call      qword ptr [7FFEFF98C1C8]
       int       3
; Total bytes of code 36
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       ebx,edx
       test      ebx,ebx
       jl        short M06_L03
       test      ebx,ebx
       je        short M06_L04
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+0A8]
       test      rax,rax
       je        short M06_L02
       mov       rcx,rax
M06_L00:
       mov       edx,ebx
       call      CORINFO_HELP_NEWARR_1_PTR
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M06_L01:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M06_L02:
       mov       rdx,7FFF000BD958
       call      qword ptr [7FFEFF70C5D0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M06_L00
M06_L03:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FFEFF98EEE0]
       int       3
M06_L04:
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+0B0]
       test      rdx,rdx
       je        short M06_L05
       jmp       short M06_L06
M06_L05:
       mov       rdx,7FFF000BD960
       call      qword ptr [7FFEFF70C5D0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M06_L06:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M06_L01
; Total bytes of code 179
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,[rbx+10]
       lea       ebp,[rdi+1]
       mov       ecx,ebp
       mov       rdx,[rbx+8]
       cmp       dword ptr [rdx+8],0
       jne       short M07_L01
       mov       edx,4
M07_L00:
       mov       eax,7FFFFFC7
       cmp       edx,7FFFFFC7
       cmova     edx,eax
       cmp       edx,ecx
       cmovl     edx,ecx
       mov       rcx,rbx
       call      qword ptr [7FFF5160DD70]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
       mov       [rbx+10],ebp
       mov       rcx,[rbx+8]
       movsxd    rdx,edi
       mov       r8,rsi
       call      qword ptr [7FFF515E7FF0]; Precode of System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M07_L01:
       mov       rdx,[rbx+8]
       mov       edx,[rdx+8]
       add       edx,edx
       jmp       short M07_L00
; Total bytes of code 105
```
```assembly
; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        short M08_L02
       call      qword ptr [7FFF6B925730]
       cmp       byte ptr [rax],0
       jne       short M08_L00
       mov       rcx,rsi
       call      qword ptr [7FFF6B927878]
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFF6B9256E8]; Precode of System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
       test      rax,rax
       jne       short M08_L01
M08_L00:
       mov       rcx,rsi
       call      qword ptr [7FFF6B927880]
       mov       rcx,rax
       call      qword ptr [7FFF6B9256D0]; CORINFO_HELP_NEWFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFF6B929010]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M08_L01:
       mov       rcx,rax
       lea       r11,[System.Linq.Enumerable.Select[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>)]
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [r11]
M08_L02:
       mov       ecx,11
       call      qword ptr [7FFF6B9295A8]
       int       3
; Total bytes of code 133
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCreditCards()
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-28],rax
       mov       [rbp-30],rax
       mov       rbx,rcx
       mov       ecx,[rbx+268]
       mov       byte ptr [rbp-28],1
       mov       dword ptr [rbp-24],2
       test      ecx,ecx
       setg      al
       movzx     eax,al
       test      eax,eax
       je        short M00_L02
M00_L00:
       call      qword ptr [7FFEFFF9D6B0]; DotNetTips.Spargine.Tester.RandomCreditCardNumberGenerator.GetCreditCardNumbers(Int32)
       mov       rsi,rax
       test      rsi,rsi
       je        near ptr M00_L05
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Generic.IList<System.String>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M00_L06
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
M00_L01:
       mov       [rbp-30],r14
       mov       rbx,[rbx+60]
       mov       rdx,[rbp-30]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M00_L02:
       movzx     ecx,byte ptr [rbp-28]
       test      cl,cl
       je        short M00_L03
       lea       rcx,[rbp-28]
       call      qword ptr [7FFEFFD2E478]
       mov       ecx,eax
       jmp       near ptr M00_L00
M00_L03:
       call      qword ptr [7FFEFFD2E490]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L04
       call      qword ptr [7FFF0004EC10]
       mov       rbx,rax
M00_L04:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,21A0EA43620
       call      qword ptr [7FFEFF99DEC0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       call      qword ptr [7FFEFF99D968]
       mov       ecx,5B
       mov       rdx,7FFEFFD5F450
       call      qword ptr [7FFEFF997738]
       mov       rbx,rax
       mov       ecx,1B61
       mov       rdx,7FFEFFA65D90
       call      qword ptr [7FFEFF997738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFEFF717870]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFEFFD5F450
       call      qword ptr [7FFEFF997738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFEFF717870]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFEFFE9F258]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFEFFE9F270]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L06:
       mov       rdx,rsi
       mov       rcx,offset MT_System.String[]
       call      qword ptr [7FFEFF7158F0]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        short M00_L07
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       rdx,rdi
       call      qword ptr [7FFEFFB15E00]; System.Collections.ObjectModel.ReadOnlyCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IList`1<System.__Canon>)
       jmp       near ptr M00_L01
M00_L07:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Generic.ICollection<System.String>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       r14,rax
       test      r14,r14
       je        near ptr M00_L11
       mov       rcx,offset MT_System.Collections.Generic.List<System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,r14
       mov       r11,7FFEFF660F18
       call      qword ptr [r11]
       mov       edx,eax
       mov       rcx,rdi
       call      qword ptr [7FFEFF99EC70]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,rsi
       mov       r11,7FFEFF660F20
       call      qword ptr [r11]
       mov       [rbp-38],rax
M00_L08:
       mov       rcx,[rbp-38]
       mov       r11,7FFEFF660F28
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L10
       mov       rcx,[rbp-38]
       mov       r11,7FFEFF660F30
       call      qword ptr [r11]
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       edx,[rdi+10]
       cmp       [rcx+8],edx
       jbe       short M00_L09
       lea       r8d,[rdx+1]
       mov       [rdi+10],r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M00_L08
M00_L09:
       mov       rcx,rdi
       mov       rdx,rax
       call      qword ptr [7FFEFF8BE370]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M00_L08
M00_L10:
       mov       rcx,[rbp-38]
       mov       r11,7FFEFF660F38
       call      qword ptr [r11]
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       rdx,rdi
       call      qword ptr [7FFEFFB15E00]; System.Collections.ObjectModel.ReadOnlyCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IList`1<System.__Canon>)
       jmp       near ptr M00_L01
M00_L11:
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdx,rsi
       mov       rcx,7FFF0011A5F0
       call      qword ptr [7FFEFFD2D5F0]; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFEFFB15E00]; System.Collections.ObjectModel.ReadOnlyCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IList`1<System.__Canon>)
       jmp       near ptr M00_L01
       sub       rsp,28
       cmp       qword ptr [rbp-38],0
       je        short M00_L12
       mov       rcx,[rbp-38]
       mov       r11,7FFEFF660F38
       call      qword ptr [r11]
M00_L12:
       nop
       add       rsp,28
       ret
; Total bytes of code 807
```
```assembly
; DotNetTips.Spargine.Tester.RandomCreditCardNumberGenerator.GetCreditCardNumbers(Int32)
; 		count = count.ArgumentInRange(min: 1);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var result = new List<string>(count);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		for (var cardCount = 0; cardCount < count; cardCount++)
; 		     ^^^^^^^^^^^^^^^^^
; 			var prefixAndLength = _prefixes[RandomNumberGenerator.GetInt32(0, _prefixes.Length)];
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			result.Add(CreateFakeCreditCardNumber(prefixAndLength.Prefix, prefixAndLength.Length));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return result.AsReadOnly();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       vzeroupper
       lea       rbp,[rsp+0C0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       xor       eax,eax
       mov       [rbp-40],rax
       mov       ebx,ecx
       lea       rcx,[rbp-88]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rcx,rsp
       mov       [rbp-70],rcx
       mov       rcx,rbp
       mov       [rbp-60],rcx
       test      ebx,ebx
       setg      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M01_L08
M01_L00:
       mov       rcx,offset MT_System.Collections.Generic.List<System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       test      ebx,ebx
       jl        near ptr M01_L11
       test      ebx,ebx
       je        near ptr M01_L12
       mov       edx,ebx
       mov       rcx,offset MT_System.String[]
       call      CORINFO_HELP_NEWARR_1_PTR
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M01_L01:
       mov       [rbp-90],rdi
       xor       r14d,r14d
       cmp       r14d,ebx
       jl        short M01_L02
       jmp       near ptr M01_L13
M01_L02:
       mov       rdx,1D979C02E98
       mov       r15,[rdx]
       mov       [rbp-98],r15
       xor       edx,edx
       mov       [rbp-44],edx
M01_L03:
       lea       rdx,[rbp-44]
       mov       [rbp-50],rdx
       lea       rdx,[rbp-44]
       mov       r8d,4
       xor       ecx,ecx
       mov       r9d,2
       mov       rax,7FFEFFDC0488
       mov       [rbp-78],rax
       lea       rax,[M01_L04]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFF8CB23670
       call      rax
M01_L04:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFF5F64F778],0
       je        short M01_L05
       call      qword ptr [7FFF5F63D608]; CORINFO_HELP_STOP_FOR_GC
M01_L05:
       mov       rcx,[rbp-80]
       mov       [rsi+8],rcx
       test      eax,eax
       jne       near ptr M01_L15
       xor       ecx,ecx
       mov       [rbp-50],rcx
       mov       [rbp-50],rcx
       mov       ecx,[rbp-44]
       and       ecx,3F
       cmp       ecx,31
       ja        near ptr M01_L03
       mov       ecx,ecx
       shl       rcx,4
       mov       r15,[rbp-98]
       lea       rcx,[r15+rcx+10]
       mov       rdx,[rcx]
       mov       eax,[rcx+8]
       mov       rcx,rdx
       mov       edx,eax
       call      qword ptr [7FFEFFF9D7A0]; DotNetTips.Spargine.Tester.RandomCreditCardNumberGenerator.CreateFakeCreditCardNumber(System.String, Int32)
       mov       rdi,[rbp-90]
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       edx,[rdi+10]
       mov       r8d,[rcx+8]
       cmp       r8d,edx
       jbe       near ptr M01_L14
       lea       r8d,[rdx+1]
       mov       [rdi+10],r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M01_L06:
       add       r14d,1
       jo        near ptr M01_L16
       cmp       r14d,ebx
       jl        near ptr M01_L02
M01_L07:
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
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
M01_L08:
       movzx     ecx,byte ptr [rbp-40]
       test      cl,cl
       je        short M01_L09
       lea       rcx,[rbp-40]
       call      qword ptr [7FFEFFD2E478]
       mov       ebx,eax
       jmp       near ptr M01_L00
M01_L09:
       call      qword ptr [7FFEFFD2E490]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L10
       call      qword ptr [7FFF0004EC10]
       mov       rbx,rax
M01_L10:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,21A0EA43620
       call      qword ptr [7FFEFF99DEC0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M01_L11:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FFEFF99EEE0]
       int       3
M01_L12:
       mov       rcx,1D979C00230
       mov       rdx,[rcx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L01
M01_L13:
       mov       rdi,[rbp-90]
       jmp       near ptr M01_L07
M01_L14:
       mov       rcx,rdi
       mov       rdx,rax
       call      qword ptr [7FFEFF8BE370]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M01_L06
M01_L15:
       mov       ecx,eax
       call      qword ptr [7FFF0004D7D0]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M01_L16:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 689
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rdx,rdx
       je        short M02_L06
       mov       rax,[rdx]
       movzx     r8d,word ptr [rax+0E]
       test      r8,r8
       je        short M02_L03
       mov       r10,[rax+38]
       cmp       r8,4
       jl        short M02_L01
       cmp       [r10],rcx
       je        short M02_L06
M02_L00:
       cmp       [r10+8],rcx
       je        short M02_L06
       cmp       [r10+10],rcx
       je        short M02_L06
       cmp       [r10+18],rcx
       je        short M02_L06
       add       r10,20
       add       r8,0FFFFFFFFFFFFFFFC
       cmp       r8,4
       jge       short M02_L04
       test      r8,r8
       je        short M02_L03
M02_L01:
       cmp       [r10],rcx
       je        short M02_L06
M02_L02:
       add       r10,8
       dec       r8
       test      r8,r8
       jle       short M02_L03
       cmp       [r10],rcx
       je        short M02_L06
       jmp       short M02_L02
M02_L03:
       test      dword ptr [rax],500C0000
       je        short M02_L05
       jmp       qword ptr [7FFEFFD27918]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
M02_L04:
       cmp       [r10],rcx
       je        short M02_L06
       jmp       short M02_L00
M02_L05:
       xor       edx,edx
M02_L06:
       mov       rax,rdx
       ret
; Total bytes of code 121
```
```assembly
; System.String.Concat(System.String, System.String)
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       test      rbx,rbx
       je        near ptr M03_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M03_L01
       test      rsi,rsi
       je        short M03_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M03_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M03_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFF5F338D20
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFEFF715818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFEFF715818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L00:
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L01:
       test      rsi,rsi
       je        short M03_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M03_L03
M03_L02:
       mov       rax,21A0EA40008
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L03:
       mov       rax,rsi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L04:
       call      qword ptr [7FFF00134090]
       int       3
; Total bytes of code 244
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
       push      rsi
       push      rbx
       test      rdx,rdx
       je        short M04_L02
       mov       rax,[rdx]
       cmp       rax,rcx
       je        short M04_L02
       mov       r8,1D979C00038
       mov       r8,[r8]
       add       r8,10
       rorx      r10,rax,20
       xor       r10,rcx
       mov       r9,9E3779B97F4A7C15
       imul      r10,r9
       mov       r9d,[r8]
       shrx      r10,r10,r9
       xor       r9d,r9d
M04_L00:
       lea       r11d,[r10+1]
       movsxd    r11,r11d
       lea       r11,[r11+r11*2]
       lea       r11,[r8+r11*8]
       mov       ebx,[r11]
       mov       rsi,[r11+8]
       and       ebx,0FFFFFFFE
       cmp       rsi,rax
       jne       short M04_L03
       mov       rsi,rcx
       xor       rsi,[r11+10]
       cmp       rsi,1
       ja        short M04_L03
       cmp       ebx,[r11]
       jne       short M04_L04
M04_L01:
       cmp       esi,1
       je        short M04_L02
       test      esi,esi
       jne       short M04_L05
       xor       edx,edx
M04_L02:
       mov       rax,rdx
       pop       rbx
       pop       rsi
       ret
M04_L03:
       test      ebx,ebx
       je        short M04_L04
       inc       r9d
       add       r10d,r9d
       and       r10d,[r8+4]
       cmp       r9d,8
       jl        short M04_L00
M04_L04:
       mov       esi,2
       jmp       short M04_L01
M04_L05:
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFEFF71D920]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny_NoCacheLookup(Void*, System.Object)
; Total bytes of code 166
```
```assembly
; System.Collections.ObjectModel.ReadOnlyCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IList`1<System.__Canon>)
       sub       rsp,28
       test      rdx,rdx
       je        short M05_L00
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       ret
M05_L00:
       mov       ecx,14
       call      qword ptr [7FFEFF99C1C8]
       int       3
; Total bytes of code 36
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       ebx,edx
       test      ebx,ebx
       jl        short M06_L03
       test      ebx,ebx
       je        short M06_L04
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+0A8]
       test      rax,rax
       je        short M06_L02
       mov       rcx,rax
M06_L00:
       mov       edx,ebx
       call      CORINFO_HELP_NEWARR_1_PTR
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M06_L01:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M06_L02:
       mov       rdx,7FFF001067B0
       call      qword ptr [7FFEFF71C5D0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M06_L00
M06_L03:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FFEFF99EEE0]
       int       3
M06_L04:
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+0B0]
       test      rdx,rdx
       je        short M06_L05
       jmp       short M06_L06
M06_L05:
       mov       rdx,7FFF001067B8
       call      qword ptr [7FFEFF71C5D0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M06_L06:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M06_L01
; Total bytes of code 179
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,[rbx+10]
       lea       ebp,[rdi+1]
       mov       ecx,ebp
       mov       rdx,[rbx+8]
       cmp       dword ptr [rdx+8],0
       jne       short M07_L01
       mov       edx,4
M07_L00:
       mov       eax,7FFFFFC7
       cmp       edx,7FFFFFC7
       cmova     edx,eax
       cmp       edx,ecx
       cmovl     edx,ecx
       mov       rcx,rbx
       call      qword ptr [7FFF5160DD70]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
       mov       [rbx+10],ebp
       mov       rcx,[rbx+8]
       movsxd    rdx,edi
       mov       r8,rsi
       call      qword ptr [7FFF515E7FF0]; Precode of System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M07_L01:
       mov       rdx,[rbx+8]
       mov       edx,[rdx+8]
       add       edx,edx
       jmp       short M07_L00
; Total bytes of code 105
```
```assembly
; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        short M08_L02
       call      qword ptr [7FFF6B925730]
       cmp       byte ptr [rax],0
       jne       short M08_L00
       mov       rcx,rsi
       call      qword ptr [7FFF6B927878]
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFF6B9256E8]; Precode of System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
       test      rax,rax
       jne       short M08_L01
M08_L00:
       mov       rcx,rsi
       call      qword ptr [7FFF6B927880]
       mov       rcx,rax
       call      qword ptr [7FFF6B9256D0]; CORINFO_HELP_NEWFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFF6B929010]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M08_L01:
       mov       rcx,rax
       lea       r11,[System.Linq.Enumerable.Select[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>)]
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [r11]
M08_L02:
       mov       ecx,11
       call      qword ptr [7FFF6B9295A8]
       int       3
; Total bytes of code 133
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCreditCards()
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-28],rax
       mov       [rbp-30],rax
       mov       rbx,rcx
       mov       ecx,[rbx+268]
       mov       byte ptr [rbp-28],1
       mov       dword ptr [rbp-24],2
       test      ecx,ecx
       setg      al
       movzx     eax,al
       test      eax,eax
       je        short M00_L02
M00_L00:
       call      qword ptr [7FFEFFF8D6E0]; DotNetTips.Spargine.Tester.RandomCreditCardNumberGenerator.GetCreditCardNumbers(Int32)
       mov       rsi,rax
       test      rsi,rsi
       je        near ptr M00_L05
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Generic.IList<System.String>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M00_L06
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
M00_L01:
       mov       [rbp-30],r14
       mov       rbx,[rbx+60]
       mov       rdx,[rbp-30]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M00_L02:
       movzx     ecx,byte ptr [rbp-28]
       test      cl,cl
       je        short M00_L03
       lea       rcx,[rbp-28]
       call      qword ptr [7FFEFFD1E478]
       mov       ecx,eax
       jmp       near ptr M00_L00
M00_L03:
       call      qword ptr [7FFEFFD1E490]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L04
       call      qword ptr [7FFF0003EC40]
       mov       rbx,rax
M00_L04:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,20CB3543620
       call      qword ptr [7FFEFF98DEC0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       call      qword ptr [7FFEFF98D968]
       mov       ecx,5B
       mov       rdx,7FFEFFD4F450
       call      qword ptr [7FFEFF987738]
       mov       rbx,rax
       mov       ecx,1B61
       mov       rdx,7FFEFFA55D90
       call      qword ptr [7FFEFF987738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFEFF707870]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFEFFD4F450
       call      qword ptr [7FFEFF987738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFEFF707870]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFEFFE8F240]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFEFFE8F258]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L06:
       mov       rdx,rsi
       mov       rcx,offset MT_System.String[]
       call      qword ptr [7FFEFF7058F0]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        short M00_L07
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       rdx,rdi
       call      qword ptr [7FFEFFB05E00]; System.Collections.ObjectModel.ReadOnlyCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IList`1<System.__Canon>)
       jmp       near ptr M00_L01
M00_L07:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Generic.ICollection<System.String>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       r14,rax
       test      r14,r14
       je        near ptr M00_L11
       mov       rcx,offset MT_System.Collections.Generic.List<System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,r14
       mov       r11,7FFEFF650F28
       call      qword ptr [r11]
       mov       edx,eax
       mov       rcx,rdi
       call      qword ptr [7FFEFF98EC70]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,rsi
       mov       r11,7FFEFF650F30
       call      qword ptr [r11]
       mov       [rbp-38],rax
M00_L08:
       mov       rcx,[rbp-38]
       mov       r11,7FFEFF650F38
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L10
       mov       rcx,[rbp-38]
       mov       r11,7FFEFF650F40
       call      qword ptr [r11]
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       edx,[rdi+10]
       cmp       [rcx+8],edx
       jbe       short M00_L09
       lea       r8d,[rdx+1]
       mov       [rdi+10],r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M00_L08
M00_L09:
       mov       rcx,rdi
       mov       rdx,rax
       call      qword ptr [7FFEFF8AE370]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M00_L08
M00_L10:
       mov       rcx,[rbp-38]
       mov       r11,7FFEFF650F48
       call      qword ptr [r11]
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       rdx,rdi
       call      qword ptr [7FFEFFB05E00]; System.Collections.ObjectModel.ReadOnlyCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IList`1<System.__Canon>)
       jmp       near ptr M00_L01
M00_L11:
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdx,rsi
       mov       rcx,7FFF0010B3D0
       call      qword ptr [7FFEFFD1D5F0]; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFEFFB05E00]; System.Collections.ObjectModel.ReadOnlyCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IList`1<System.__Canon>)
       jmp       near ptr M00_L01
       sub       rsp,28
       cmp       qword ptr [rbp-38],0
       je        short M00_L12
       mov       rcx,[rbp-38]
       mov       r11,7FFEFF650F48
       call      qword ptr [r11]
M00_L12:
       nop
       add       rsp,28
       ret
; Total bytes of code 807
```
```assembly
; DotNetTips.Spargine.Tester.RandomCreditCardNumberGenerator.GetCreditCardNumbers(Int32)
; 		count = count.ArgumentInRange(min: 1);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var result = new List<string>(count);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		for (var cardCount = 0; cardCount < count; cardCount++)
; 		     ^^^^^^^^^^^^^^^^^
; 			var prefixAndLength = _prefixes[RandomNumberGenerator.GetInt32(0, _prefixes.Length)];
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			result.Add(CreateFakeCreditCardNumber(prefixAndLength.Prefix, prefixAndLength.Length));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return result.AsReadOnly();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       vzeroupper
       lea       rbp,[rsp+0C0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       xor       eax,eax
       mov       [rbp-40],rax
       mov       ebx,ecx
       lea       rcx,[rbp-88]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rcx,rsp
       mov       [rbp-70],rcx
       mov       rcx,rbp
       mov       [rbp-60],rcx
       test      ebx,ebx
       setg      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M01_L08
M01_L00:
       mov       rcx,offset MT_System.Collections.Generic.List<System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       test      ebx,ebx
       jl        near ptr M01_L11
       test      ebx,ebx
       je        near ptr M01_L12
       mov       edx,ebx
       mov       rcx,offset MT_System.String[]
       call      CORINFO_HELP_NEWARR_1_PTR
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M01_L01:
       mov       [rbp-90],rdi
       xor       r14d,r14d
       cmp       r14d,ebx
       jl        short M01_L02
       jmp       near ptr M01_L13
M01_L02:
       mov       rdx,1CC1E402E98
       mov       r15,[rdx]
       mov       [rbp-98],r15
       xor       edx,edx
       mov       [rbp-44],edx
M01_L03:
       lea       rdx,[rbp-44]
       mov       [rbp-50],rdx
       lea       rdx,[rbp-44]
       mov       r8d,4
       xor       ecx,ecx
       mov       r9d,2
       mov       rax,7FFEFFDB0488
       mov       [rbp-78],rax
       lea       rax,[M01_L04]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFF8CB23670
       call      rax
M01_L04:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFF5F64F778],0
       je        short M01_L05
       call      qword ptr [7FFF5F63D608]; CORINFO_HELP_STOP_FOR_GC
M01_L05:
       mov       rcx,[rbp-80]
       mov       [rsi+8],rcx
       test      eax,eax
       jne       near ptr M01_L15
       xor       ecx,ecx
       mov       [rbp-50],rcx
       mov       [rbp-50],rcx
       mov       ecx,[rbp-44]
       and       ecx,3F
       cmp       ecx,31
       ja        near ptr M01_L03
       mov       ecx,ecx
       shl       rcx,4
       mov       r15,[rbp-98]
       lea       rcx,[r15+rcx+10]
       mov       rdx,[rcx]
       mov       eax,[rcx+8]
       mov       rcx,rdx
       mov       edx,eax
       call      qword ptr [7FFEFFF8D7D0]; DotNetTips.Spargine.Tester.RandomCreditCardNumberGenerator.CreateFakeCreditCardNumber(System.String, Int32)
       mov       rdi,[rbp-90]
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       edx,[rdi+10]
       mov       r8d,[rcx+8]
       cmp       r8d,edx
       jbe       near ptr M01_L14
       lea       r8d,[rdx+1]
       mov       [rdi+10],r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M01_L06:
       add       r14d,1
       jo        near ptr M01_L16
       cmp       r14d,ebx
       jl        near ptr M01_L02
M01_L07:
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
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
M01_L08:
       movzx     ecx,byte ptr [rbp-40]
       test      cl,cl
       je        short M01_L09
       lea       rcx,[rbp-40]
       call      qword ptr [7FFEFFD1E478]
       mov       ebx,eax
       jmp       near ptr M01_L00
M01_L09:
       call      qword ptr [7FFEFFD1E490]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L10
       call      qword ptr [7FFF0003EC40]
       mov       rbx,rax
M01_L10:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,20CB3543620
       call      qword ptr [7FFEFF98DEC0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M01_L11:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FFEFF98EEE0]
       int       3
M01_L12:
       mov       rcx,1CC1E400230
       mov       rdx,[rcx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L01
M01_L13:
       mov       rdi,[rbp-90]
       jmp       near ptr M01_L07
M01_L14:
       mov       rcx,rdi
       mov       rdx,rax
       call      qword ptr [7FFEFF8AE370]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M01_L06
M01_L15:
       mov       ecx,eax
       call      qword ptr [7FFF0003D6C8]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M01_L16:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 689
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rdx,rdx
       je        short M02_L06
       mov       rax,[rdx]
       movzx     r8d,word ptr [rax+0E]
       test      r8,r8
       je        short M02_L03
       mov       r10,[rax+38]
       cmp       r8,4
       jl        short M02_L01
       cmp       [r10],rcx
       je        short M02_L06
M02_L00:
       cmp       [r10+8],rcx
       je        short M02_L06
       cmp       [r10+10],rcx
       je        short M02_L06
       cmp       [r10+18],rcx
       je        short M02_L06
       add       r10,20
       add       r8,0FFFFFFFFFFFFFFFC
       cmp       r8,4
       jge       short M02_L04
       test      r8,r8
       je        short M02_L03
M02_L01:
       cmp       [r10],rcx
       je        short M02_L06
M02_L02:
       add       r10,8
       dec       r8
       test      r8,r8
       jle       short M02_L03
       cmp       [r10],rcx
       je        short M02_L06
       jmp       short M02_L02
M02_L03:
       test      dword ptr [rax],500C0000
       je        short M02_L05
       jmp       qword ptr [7FFEFFD17918]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
M02_L04:
       cmp       [r10],rcx
       je        short M02_L06
       jmp       short M02_L00
M02_L05:
       xor       edx,edx
M02_L06:
       mov       rax,rdx
       ret
; Total bytes of code 121
```
```assembly
; System.String.Concat(System.String, System.String)
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       test      rbx,rbx
       je        near ptr M03_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M03_L01
       test      rsi,rsi
       je        short M03_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M03_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M03_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFF5F338D20
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFEFF705818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFEFF705818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L00:
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L01:
       test      rsi,rsi
       je        short M03_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M03_L03
M03_L02:
       mov       rax,20CB3540008
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L03:
       mov       rax,rsi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L04:
       call      qword ptr [7FFF001240C0]
       int       3
; Total bytes of code 244
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
       push      rsi
       push      rbx
       test      rdx,rdx
       je        short M04_L02
       mov       rax,[rdx]
       cmp       rax,rcx
       je        short M04_L02
       mov       r8,1CC1E400038
       mov       r8,[r8]
       add       r8,10
       rorx      r10,rax,20
       xor       r10,rcx
       mov       r9,9E3779B97F4A7C15
       imul      r10,r9
       mov       r9d,[r8]
       shrx      r10,r10,r9
       xor       r9d,r9d
M04_L00:
       lea       r11d,[r10+1]
       movsxd    r11,r11d
       lea       r11,[r11+r11*2]
       lea       r11,[r8+r11*8]
       mov       ebx,[r11]
       mov       rsi,[r11+8]
       and       ebx,0FFFFFFFE
       cmp       rsi,rax
       jne       short M04_L03
       mov       rsi,rcx
       xor       rsi,[r11+10]
       cmp       rsi,1
       ja        short M04_L03
       cmp       ebx,[r11]
       jne       short M04_L04
M04_L01:
       cmp       esi,1
       je        short M04_L02
       test      esi,esi
       jne       short M04_L05
       xor       edx,edx
M04_L02:
       mov       rax,rdx
       pop       rbx
       pop       rsi
       ret
M04_L03:
       test      ebx,ebx
       je        short M04_L04
       inc       r9d
       add       r10d,r9d
       and       r10d,[r8+4]
       cmp       r9d,8
       jl        short M04_L00
M04_L04:
       mov       esi,2
       jmp       short M04_L01
M04_L05:
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFEFF70D920]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny_NoCacheLookup(Void*, System.Object)
; Total bytes of code 166
```
```assembly
; System.Collections.ObjectModel.ReadOnlyCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IList`1<System.__Canon>)
       sub       rsp,28
       test      rdx,rdx
       je        short M05_L00
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       ret
M05_L00:
       mov       ecx,14
       call      qword ptr [7FFEFF98C1C8]
       int       3
; Total bytes of code 36
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       ebx,edx
       test      ebx,ebx
       jl        short M06_L03
       test      ebx,ebx
       je        short M06_L04
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+0B0]
       test      rax,rax
       je        short M06_L02
       mov       rcx,rax
M06_L00:
       mov       edx,ebx
       call      CORINFO_HELP_NEWARR_1_PTR
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M06_L01:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M06_L02:
       mov       rdx,7FFF000F7D80
       call      qword ptr [7FFEFF70C5D0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M06_L00
M06_L03:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FFEFF98EEE0]
       int       3
M06_L04:
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+0B8]
       test      rdx,rdx
       je        short M06_L05
       jmp       short M06_L06
M06_L05:
       mov       rdx,7FFF000F7D88
       call      qword ptr [7FFEFF70C5D0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M06_L06:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M06_L01
; Total bytes of code 179
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,[rbx+10]
       lea       ebp,[rdi+1]
       mov       ecx,ebp
       mov       rdx,[rbx+8]
       cmp       dword ptr [rdx+8],0
       jne       short M07_L01
       mov       edx,4
M07_L00:
       mov       eax,7FFFFFC7
       cmp       edx,7FFFFFC7
       cmova     edx,eax
       cmp       edx,ecx
       cmovl     edx,ecx
       mov       rcx,rbx
       call      qword ptr [7FFF5160DD70]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
       mov       [rbx+10],ebp
       mov       rcx,[rbx+8]
       movsxd    rdx,edi
       mov       r8,rsi
       call      qword ptr [7FFF515E7FF0]; Precode of System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M07_L01:
       mov       rdx,[rbx+8]
       mov       edx,[rdx+8]
       add       edx,edx
       jmp       short M07_L00
; Total bytes of code 105
```
```assembly
; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        short M08_L02
       call      qword ptr [7FFF6B925730]
       cmp       byte ptr [rax],0
       jne       short M08_L00
       mov       rcx,rsi
       call      qword ptr [7FFF6B927878]
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFF6B9256E8]; Precode of System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
       test      rax,rax
       jne       short M08_L01
M08_L00:
       mov       rcx,rsi
       call      qword ptr [7FFF6B927880]
       mov       rcx,rax
       call      qword ptr [7FFF6B9256D0]; CORINFO_HELP_NEWFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFF6B929010]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M08_L01:
       mov       rcx,rax
       lea       r11,[System.Linq.Enumerable.Select[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>)]
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [r11]
M08_L02:
       mov       ecx,11
       call      qword ptr [7FFF6B9295A8]
       int       3
; Total bytes of code 133
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCreditCards()
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-28],rax
       mov       [rbp-30],rax
       mov       rbx,rcx
       mov       ecx,[rbx+268]
       mov       byte ptr [rbp-28],1
       mov       dword ptr [rbp-24],2
       test      ecx,ecx
       setg      al
       movzx     eax,al
       test      eax,eax
       je        short M00_L02
M00_L00:
       call      qword ptr [7FFEFFF7D6E0]; DotNetTips.Spargine.Tester.RandomCreditCardNumberGenerator.GetCreditCardNumbers(Int32)
       mov       rsi,rax
       test      rsi,rsi
       je        near ptr M00_L05
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Generic.IList<System.String>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M00_L06
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
M00_L01:
       mov       [rbp-30],r14
       mov       rbx,[rbx+60]
       mov       rdx,[rbp-30]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M00_L02:
       movzx     ecx,byte ptr [rbp-28]
       test      cl,cl
       je        short M00_L03
       lea       rcx,[rbp-28]
       call      qword ptr [7FFEFFD0E460]
       mov       ecx,eax
       jmp       near ptr M00_L00
M00_L03:
       call      qword ptr [7FFEFFD0E478]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L04
       call      qword ptr [7FFF0003EE20]
       mov       rbx,rax
M00_L04:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,20E6E443620
       call      qword ptr [7FFEFF97DEC0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       call      qword ptr [7FFEFF97D968]
       mov       ecx,5B
       mov       rdx,7FFEFFD3F450
       call      qword ptr [7FFEFF977738]
       mov       rbx,rax
       mov       ecx,1B61
       mov       rdx,7FFEFFA45D90
       call      qword ptr [7FFEFF977738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFEFF6F7870]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFEFFD3F450
       call      qword ptr [7FFEFF977738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFEFF6F7870]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFEFFE7F228]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFEFFE7F240]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L06:
       mov       rdx,rsi
       mov       rcx,offset MT_System.String[]
       call      qword ptr [7FFEFF6F58F0]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        short M00_L07
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       rdx,rdi
       call      qword ptr [7FFEFFAF5E00]; System.Collections.ObjectModel.ReadOnlyCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IList`1<System.__Canon>)
       jmp       near ptr M00_L01
M00_L07:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Generic.ICollection<System.String>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       r14,rax
       test      r14,r14
       je        near ptr M00_L11
       mov       rcx,offset MT_System.Collections.Generic.List<System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,r14
       mov       r11,7FFEFF640F28
       call      qword ptr [r11]
       mov       edx,eax
       mov       rcx,rdi
       call      qword ptr [7FFEFF97EC70]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,rsi
       mov       r11,7FFEFF640F30
       call      qword ptr [r11]
       mov       [rbp-38],rax
M00_L08:
       mov       rcx,[rbp-38]
       mov       r11,7FFEFF640F38
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L10
       mov       rcx,[rbp-38]
       mov       r11,7FFEFF640F40
       call      qword ptr [r11]
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       edx,[rdi+10]
       cmp       [rcx+8],edx
       jbe       short M00_L09
       lea       r8d,[rdx+1]
       mov       [rdi+10],r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M00_L08
M00_L09:
       mov       rcx,rdi
       mov       rdx,rax
       call      qword ptr [7FFEFF89E370]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M00_L08
M00_L10:
       mov       rcx,[rbp-38]
       mov       r11,7FFEFF640F48
       call      qword ptr [r11]
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       rdx,rdi
       call      qword ptr [7FFEFFAF5E00]; System.Collections.ObjectModel.ReadOnlyCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IList`1<System.__Canon>)
       jmp       near ptr M00_L01
M00_L11:
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdx,rsi
       mov       rcx,7FFF000FD308
       call      qword ptr [7FFEFFD0D5D8]; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFEFFAF5E00]; System.Collections.ObjectModel.ReadOnlyCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IList`1<System.__Canon>)
       jmp       near ptr M00_L01
       sub       rsp,28
       cmp       qword ptr [rbp-38],0
       je        short M00_L12
       mov       rcx,[rbp-38]
       mov       r11,7FFEFF640F48
       call      qword ptr [r11]
M00_L12:
       nop
       add       rsp,28
       ret
; Total bytes of code 807
```
```assembly
; DotNetTips.Spargine.Tester.RandomCreditCardNumberGenerator.GetCreditCardNumbers(Int32)
; 		count = count.ArgumentInRange(min: 1);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var result = new List<string>(count);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		for (var cardCount = 0; cardCount < count; cardCount++)
; 		     ^^^^^^^^^^^^^^^^^
; 			var prefixAndLength = _prefixes[RandomNumberGenerator.GetInt32(0, _prefixes.Length)];
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			result.Add(CreateFakeCreditCardNumber(prefixAndLength.Prefix, prefixAndLength.Length));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return result.AsReadOnly();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       vzeroupper
       lea       rbp,[rsp+0C0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       xor       eax,eax
       mov       [rbp-40],rax
       mov       ebx,ecx
       lea       rcx,[rbp-88]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rcx,rsp
       mov       [rbp-70],rcx
       mov       rcx,rbp
       mov       [rbp-60],rcx
       test      ebx,ebx
       setg      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M01_L08
M01_L00:
       mov       rcx,offset MT_System.Collections.Generic.List<System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       test      ebx,ebx
       jl        near ptr M01_L11
       test      ebx,ebx
       je        near ptr M01_L12
       mov       edx,ebx
       mov       rcx,offset MT_System.String[]
       call      CORINFO_HELP_NEWARR_1_PTR
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M01_L01:
       mov       [rbp-90],rdi
       xor       r14d,r14d
       cmp       r14d,ebx
       jl        short M01_L02
       jmp       near ptr M01_L13
M01_L02:
       mov       rdx,1CE02400EA0
       mov       r15,[rdx]
       mov       [rbp-98],r15
       xor       edx,edx
       mov       [rbp-44],edx
M01_L03:
       lea       rdx,[rbp-44]
       mov       [rbp-50],rdx
       lea       rdx,[rbp-44]
       mov       r8d,4
       xor       ecx,ecx
       mov       r9d,2
       mov       rax,7FFEFFDA0488
       mov       [rbp-78],rax
       lea       rax,[M01_L04]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFF8CB23670
       call      rax
M01_L04:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFF5F64F778],0
       je        short M01_L05
       call      qword ptr [7FFF5F63D608]; CORINFO_HELP_STOP_FOR_GC
M01_L05:
       mov       rcx,[rbp-80]
       mov       [rsi+8],rcx
       test      eax,eax
       jne       near ptr M01_L15
       xor       ecx,ecx
       mov       [rbp-50],rcx
       mov       [rbp-50],rcx
       mov       ecx,[rbp-44]
       and       ecx,3F
       cmp       ecx,31
       ja        near ptr M01_L03
       mov       ecx,ecx
       shl       rcx,4
       mov       r15,[rbp-98]
       lea       rcx,[r15+rcx+10]
       mov       rdx,[rcx]
       mov       eax,[rcx+8]
       mov       rcx,rdx
       mov       edx,eax
       call      qword ptr [7FFEFFF7D7D0]; DotNetTips.Spargine.Tester.RandomCreditCardNumberGenerator.CreateFakeCreditCardNumber(System.String, Int32)
       mov       rdi,[rbp-90]
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       edx,[rdi+10]
       mov       r8d,[rcx+8]
       cmp       r8d,edx
       jbe       near ptr M01_L14
       lea       r8d,[rdx+1]
       mov       [rdi+10],r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M01_L06:
       add       r14d,1
       jo        near ptr M01_L16
       cmp       r14d,ebx
       jl        near ptr M01_L02
M01_L07:
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
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
M01_L08:
       movzx     ecx,byte ptr [rbp-40]
       test      cl,cl
       je        short M01_L09
       lea       rcx,[rbp-40]
       call      qword ptr [7FFEFFD0E460]
       mov       ebx,eax
       jmp       near ptr M01_L00
M01_L09:
       call      qword ptr [7FFEFFD0E478]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L10
       call      qword ptr [7FFF0003EE20]
       mov       rbx,rax
M01_L10:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,20E6E443620
       call      qword ptr [7FFEFF97DEC0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M01_L11:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FFEFF97EEE0]
       int       3
M01_L12:
       mov       rcx,1CDD9400230
       mov       rdx,[rcx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L01
M01_L13:
       mov       rdi,[rbp-90]
       jmp       near ptr M01_L07
M01_L14:
       mov       rcx,rdi
       mov       rdx,rax
       call      qword ptr [7FFEFF89E370]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M01_L06
M01_L15:
       mov       ecx,eax
       call      qword ptr [7FFEFFF7FC00]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M01_L16:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 689
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rdx,rdx
       je        short M02_L06
       mov       rax,[rdx]
       movzx     r8d,word ptr [rax+0E]
       test      r8,r8
       je        short M02_L03
       mov       r10,[rax+38]
       cmp       r8,4
       jl        short M02_L01
       cmp       [r10],rcx
       je        short M02_L06
M02_L00:
       cmp       [r10+8],rcx
       je        short M02_L06
       cmp       [r10+10],rcx
       je        short M02_L06
       cmp       [r10+18],rcx
       je        short M02_L06
       add       r10,20
       add       r8,0FFFFFFFFFFFFFFFC
       cmp       r8,4
       jge       short M02_L04
       test      r8,r8
       je        short M02_L03
M02_L01:
       cmp       [r10],rcx
       je        short M02_L06
M02_L02:
       add       r10,8
       dec       r8
       test      r8,r8
       jle       short M02_L03
       cmp       [r10],rcx
       je        short M02_L06
       jmp       short M02_L02
M02_L03:
       test      dword ptr [rax],500C0000
       je        short M02_L05
       jmp       qword ptr [7FFEFFD07900]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
M02_L04:
       cmp       [r10],rcx
       je        short M02_L06
       jmp       short M02_L00
M02_L05:
       xor       edx,edx
M02_L06:
       mov       rax,rdx
       ret
; Total bytes of code 121
```
```assembly
; System.String.Concat(System.String, System.String)
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       test      rbx,rbx
       je        near ptr M03_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M03_L01
       test      rsi,rsi
       je        short M03_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M03_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M03_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFF5F338D20
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFEFF6F5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFEFF6F5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L00:
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L01:
       test      rsi,rsi
       je        short M03_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M03_L03
M03_L02:
       mov       rax,20E6E440008
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L03:
       mov       rax,rsi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L04:
       call      qword ptr [7FFF00114168]
       int       3
; Total bytes of code 244
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
       push      rsi
       push      rbx
       test      rdx,rdx
       je        short M04_L02
       mov       rax,[rdx]
       cmp       rax,rcx
       je        short M04_L02
       mov       r8,1CDD9400038
       mov       r8,[r8]
       add       r8,10
       rorx      r10,rax,20
       xor       r10,rcx
       mov       r9,9E3779B97F4A7C15
       imul      r10,r9
       mov       r9d,[r8]
       shrx      r10,r10,r9
       xor       r9d,r9d
M04_L00:
       lea       r11d,[r10+1]
       movsxd    r11,r11d
       lea       r11,[r11+r11*2]
       lea       r11,[r8+r11*8]
       mov       ebx,[r11]
       mov       rsi,[r11+8]
       and       ebx,0FFFFFFFE
       cmp       rsi,rax
       jne       short M04_L03
       mov       rsi,rcx
       xor       rsi,[r11+10]
       cmp       rsi,1
       ja        short M04_L03
       cmp       ebx,[r11]
       jne       short M04_L04
M04_L01:
       cmp       esi,1
       je        short M04_L02
       test      esi,esi
       jne       short M04_L05
       xor       edx,edx
M04_L02:
       mov       rax,rdx
       pop       rbx
       pop       rsi
       ret
M04_L03:
       test      ebx,ebx
       je        short M04_L04
       inc       r9d
       add       r10d,r9d
       and       r10d,[r8+4]
       cmp       r9d,8
       jl        short M04_L00
M04_L04:
       mov       esi,2
       jmp       short M04_L01
M04_L05:
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFEFF6FD920]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny_NoCacheLookup(Void*, System.Object)
; Total bytes of code 166
```
```assembly
; System.Collections.ObjectModel.ReadOnlyCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IList`1<System.__Canon>)
       sub       rsp,28
       test      rdx,rdx
       je        short M05_L00
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       ret
M05_L00:
       mov       ecx,14
       call      qword ptr [7FFEFF97C1C8]
       int       3
; Total bytes of code 36
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       ebx,edx
       test      ebx,ebx
       jl        short M06_L03
       test      ebx,ebx
       je        short M06_L04
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+0A8]
       test      rax,rax
       je        short M06_L02
       mov       rcx,rax
M06_L00:
       mov       edx,ebx
       call      CORINFO_HELP_NEWARR_1_PTR
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M06_L01:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M06_L02:
       mov       rdx,7FFF000AE018
       call      qword ptr [7FFEFF6FC5D0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M06_L00
M06_L03:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FFEFF97EEE0]
       int       3
M06_L04:
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+0B0]
       test      rdx,rdx
       je        short M06_L05
       jmp       short M06_L06
M06_L05:
       mov       rdx,7FFF000AE020
       call      qword ptr [7FFEFF6FC5D0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M06_L06:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M06_L01
; Total bytes of code 179
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,[rbx+10]
       lea       ebp,[rdi+1]
       mov       ecx,ebp
       mov       rdx,[rbx+8]
       cmp       dword ptr [rdx+8],0
       jne       short M07_L01
       mov       edx,4
M07_L00:
       mov       eax,7FFFFFC7
       cmp       edx,7FFFFFC7
       cmova     edx,eax
       cmp       edx,ecx
       cmovl     edx,ecx
       mov       rcx,rbx
       call      qword ptr [7FFF5160DD70]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
       mov       [rbx+10],ebp
       mov       rcx,[rbx+8]
       movsxd    rdx,edi
       mov       r8,rsi
       call      qword ptr [7FFF515E7FF0]; Precode of System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M07_L01:
       mov       rdx,[rbx+8]
       mov       edx,[rdx+8]
       add       edx,edx
       jmp       short M07_L00
; Total bytes of code 105
```
```assembly
; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        short M08_L02
       call      qword ptr [7FFF6B925730]
       cmp       byte ptr [rax],0
       jne       short M08_L00
       mov       rcx,rsi
       call      qword ptr [7FFF6B927878]
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFF6B9256E8]; Precode of System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
       test      rax,rax
       jne       short M08_L01
M08_L00:
       mov       rcx,rsi
       call      qword ptr [7FFF6B927880]
       mov       rcx,rax
       call      qword ptr [7FFF6B9256D0]; CORINFO_HELP_NEWFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFF6B929010]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M08_L01:
       mov       rcx,rax
       lea       r11,[System.Linq.Enumerable.Select[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>)]
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [r11]
M08_L02:
       mov       ecx,11
       call      qword ptr [7FFF6B9295A8]
       int       3
; Total bytes of code 133
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCreditCards()
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-28],rax
       mov       [rbp-30],rax
       mov       rbx,rcx
       mov       ecx,[rbx+268]
       mov       byte ptr [rbp-28],1
       mov       dword ptr [rbp-24],2
       test      ecx,ecx
       setg      al
       movzx     eax,al
       test      eax,eax
       je        short M00_L02
M00_L00:
       call      qword ptr [7FFEFFF7D6F8]; DotNetTips.Spargine.Tester.RandomCreditCardNumberGenerator.GetCreditCardNumbers(Int32)
       mov       rsi,rax
       test      rsi,rsi
       je        near ptr M00_L05
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Generic.IList<System.String>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M00_L06
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
M00_L01:
       mov       [rbp-30],r14
       mov       rbx,[rbx+60]
       mov       rdx,[rbp-30]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M00_L02:
       movzx     ecx,byte ptr [rbp-28]
       test      cl,cl
       je        short M00_L03
       lea       rcx,[rbp-28]
       call      qword ptr [7FFEFFD0E478]
       mov       ecx,eax
       jmp       near ptr M00_L00
M00_L03:
       call      qword ptr [7FFEFFD0E490]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L04
       call      qword ptr [7FFF0003EE68]
       mov       rbx,rax
M00_L04:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,1C7A8D73620
       call      qword ptr [7FFEFF97DEC0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       call      qword ptr [7FFEFF97D968]
       mov       ecx,5B
       mov       rdx,7FFEFFD3F450
       call      qword ptr [7FFEFF977738]
       mov       rbx,rax
       mov       ecx,1B61
       mov       rdx,7FFEFFA45D90
       call      qword ptr [7FFEFF977738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFEFF6F7870]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFEFFD3F450
       call      qword ptr [7FFEFF977738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFEFF6F7870]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFEFFE7F378]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFEFFE7F390]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L06:
       mov       rdx,rsi
       mov       rcx,offset MT_System.String[]
       call      qword ptr [7FFEFF6F58F0]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        short M00_L07
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       rdx,rdi
       call      qword ptr [7FFEFFAF5E00]; System.Collections.ObjectModel.ReadOnlyCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IList`1<System.__Canon>)
       jmp       near ptr M00_L01
M00_L07:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Generic.ICollection<System.String>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       r14,rax
       test      r14,r14
       je        near ptr M00_L11
       mov       rcx,offset MT_System.Collections.Generic.List<System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,r14
       mov       r11,7FFEFF640F28
       call      qword ptr [r11]
       mov       edx,eax
       mov       rcx,rdi
       call      qword ptr [7FFEFF97EC70]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,rsi
       mov       r11,7FFEFF640F30
       call      qword ptr [r11]
       mov       [rbp-38],rax
M00_L08:
       mov       rcx,[rbp-38]
       mov       r11,7FFEFF640F38
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L10
       mov       rcx,[rbp-38]
       mov       r11,7FFEFF640F40
       call      qword ptr [r11]
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       edx,[rdi+10]
       cmp       [rcx+8],edx
       jbe       short M00_L09
       lea       r8d,[rdx+1]
       mov       [rdi+10],r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M00_L08
M00_L09:
       mov       rcx,rdi
       mov       rdx,rax
       call      qword ptr [7FFEFF89E370]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M00_L08
M00_L10:
       mov       rcx,[rbp-38]
       mov       r11,7FFEFF640F48
       call      qword ptr [r11]
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       rdx,rdi
       call      qword ptr [7FFEFFAF5E00]; System.Collections.ObjectModel.ReadOnlyCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IList`1<System.__Canon>)
       jmp       near ptr M00_L01
M00_L11:
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdx,rsi
       mov       rcx,7FFF000ED680
       call      qword ptr [7FFEFFD0D5F0]; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFEFFAF5E00]; System.Collections.ObjectModel.ReadOnlyCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IList`1<System.__Canon>)
       jmp       near ptr M00_L01
       sub       rsp,28
       cmp       qword ptr [rbp-38],0
       je        short M00_L12
       mov       rcx,[rbp-38]
       mov       r11,7FFEFF640F48
       call      qword ptr [r11]
M00_L12:
       nop
       add       rsp,28
       ret
; Total bytes of code 807
```
```assembly
; DotNetTips.Spargine.Tester.RandomCreditCardNumberGenerator.GetCreditCardNumbers(Int32)
; 		count = count.ArgumentInRange(min: 1);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var result = new List<string>(count);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		for (var cardCount = 0; cardCount < count; cardCount++)
; 		     ^^^^^^^^^^^^^^^^^
; 			var prefixAndLength = _prefixes[RandomNumberGenerator.GetInt32(0, _prefixes.Length)];
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			result.Add(CreateFakeCreditCardNumber(prefixAndLength.Prefix, prefixAndLength.Length));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return result.AsReadOnly();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       vzeroupper
       lea       rbp,[rsp+0C0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       xor       eax,eax
       mov       [rbp-40],rax
       mov       ebx,ecx
       lea       rcx,[rbp-88]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rcx,rsp
       mov       [rbp-70],rcx
       mov       rcx,rbp
       mov       [rbp-60],rcx
       test      ebx,ebx
       setg      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M01_L08
M01_L00:
       mov       rcx,offset MT_System.Collections.Generic.List<System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       test      ebx,ebx
       jl        near ptr M01_L11
       test      ebx,ebx
       je        near ptr M01_L12
       mov       edx,ebx
       mov       rcx,offset MT_System.String[]
       call      CORINFO_HELP_NEWARR_1_PTR
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M01_L01:
       mov       [rbp-90],rdi
       xor       r14d,r14d
       cmp       r14d,ebx
       jl        short M01_L02
       jmp       near ptr M01_L13
M01_L02:
       mov       rdx,1873AC00EA0
       mov       r15,[rdx]
       mov       [rbp-98],r15
       xor       edx,edx
       mov       [rbp-44],edx
M01_L03:
       lea       rdx,[rbp-44]
       mov       [rbp-50],rdx
       lea       rdx,[rbp-44]
       mov       r8d,4
       xor       ecx,ecx
       mov       r9d,2
       mov       rax,7FFEFFDA0488
       mov       [rbp-78],rax
       lea       rax,[M01_L04]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFF8CB23670
       call      rax
M01_L04:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFF5F64F778],0
       je        short M01_L05
       call      qword ptr [7FFF5F63D608]; CORINFO_HELP_STOP_FOR_GC
M01_L05:
       mov       rcx,[rbp-80]
       mov       [rsi+8],rcx
       test      eax,eax
       jne       near ptr M01_L15
       xor       ecx,ecx
       mov       [rbp-50],rcx
       mov       [rbp-50],rcx
       mov       ecx,[rbp-44]
       and       ecx,3F
       cmp       ecx,31
       ja        near ptr M01_L03
       mov       ecx,ecx
       shl       rcx,4
       mov       r15,[rbp-98]
       lea       rcx,[r15+rcx+10]
       mov       rdx,[rcx]
       mov       eax,[rcx+8]
       mov       rcx,rdx
       mov       edx,eax
       call      qword ptr [7FFEFFF7D7E8]; DotNetTips.Spargine.Tester.RandomCreditCardNumberGenerator.CreateFakeCreditCardNumber(System.String, Int32)
       mov       rdi,[rbp-90]
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       edx,[rdi+10]
       mov       r8d,[rcx+8]
       cmp       r8d,edx
       jbe       near ptr M01_L14
       lea       r8d,[rdx+1]
       mov       [rdi+10],r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M01_L06:
       add       r14d,1
       jo        near ptr M01_L16
       cmp       r14d,ebx
       jl        near ptr M01_L02
M01_L07:
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
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
M01_L08:
       movzx     ecx,byte ptr [rbp-40]
       test      cl,cl
       je        short M01_L09
       lea       rcx,[rbp-40]
       call      qword ptr [7FFEFFD0E478]
       mov       ebx,eax
       jmp       near ptr M01_L00
M01_L09:
       call      qword ptr [7FFEFFD0E490]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L10
       call      qword ptr [7FFF0003EE68]
       mov       rbx,rax
M01_L10:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,1C7A8D73620
       call      qword ptr [7FFEFF97DEC0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M01_L11:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FFEFF97EEE0]
       int       3
M01_L12:
       mov       rcx,18713C00230
       mov       rdx,[rcx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L01
M01_L13:
       mov       rdi,[rbp-90]
       jmp       near ptr M01_L07
M01_L14:
       mov       rcx,rdi
       mov       rdx,rax
       call      qword ptr [7FFEFF89E370]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M01_L06
M01_L15:
       mov       ecx,eax
       call      qword ptr [7FFEFFF7FC18]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M01_L16:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 689
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rdx,rdx
       je        short M02_L06
       mov       rax,[rdx]
       movzx     r8d,word ptr [rax+0E]
       test      r8,r8
       je        short M02_L03
       mov       r10,[rax+38]
       cmp       r8,4
       jl        short M02_L01
       cmp       [r10],rcx
       je        short M02_L06
M02_L00:
       cmp       [r10+8],rcx
       je        short M02_L06
       cmp       [r10+10],rcx
       je        short M02_L06
       cmp       [r10+18],rcx
       je        short M02_L06
       add       r10,20
       add       r8,0FFFFFFFFFFFFFFFC
       cmp       r8,4
       jge       short M02_L04
       test      r8,r8
       je        short M02_L03
M02_L01:
       cmp       [r10],rcx
       je        short M02_L06
M02_L02:
       add       r10,8
       dec       r8
       test      r8,r8
       jle       short M02_L03
       cmp       [r10],rcx
       je        short M02_L06
       jmp       short M02_L02
M02_L03:
       test      dword ptr [rax],500C0000
       je        short M02_L05
       jmp       qword ptr [7FFEFFD07918]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
M02_L04:
       cmp       [r10],rcx
       je        short M02_L06
       jmp       short M02_L00
M02_L05:
       xor       edx,edx
M02_L06:
       mov       rax,rdx
       ret
; Total bytes of code 121
```
```assembly
; System.String.Concat(System.String, System.String)
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       test      rbx,rbx
       je        near ptr M03_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M03_L01
       test      rsi,rsi
       je        short M03_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M03_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M03_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFF5F338D20
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFEFF6F5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFEFF6F5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L00:
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L01:
       test      rsi,rsi
       je        short M03_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M03_L03
M03_L02:
       mov       rax,1C7A8D70008
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L03:
       mov       rax,rsi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L04:
       call      qword ptr [7FFF001141B0]
       int       3
; Total bytes of code 244
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
       push      rsi
       push      rbx
       test      rdx,rdx
       je        short M04_L02
       mov       rax,[rdx]
       cmp       rax,rcx
       je        short M04_L02
       mov       r8,18713C00038
       mov       r8,[r8]
       add       r8,10
       rorx      r10,rax,20
       xor       r10,rcx
       mov       r9,9E3779B97F4A7C15
       imul      r10,r9
       mov       r9d,[r8]
       shrx      r10,r10,r9
       xor       r9d,r9d
M04_L00:
       lea       r11d,[r10+1]
       movsxd    r11,r11d
       lea       r11,[r11+r11*2]
       lea       r11,[r8+r11*8]
       mov       ebx,[r11]
       mov       rsi,[r11+8]
       and       ebx,0FFFFFFFE
       cmp       rsi,rax
       jne       short M04_L03
       mov       rsi,rcx
       xor       rsi,[r11+10]
       cmp       rsi,1
       ja        short M04_L03
       cmp       ebx,[r11]
       jne       short M04_L04
M04_L01:
       cmp       esi,1
       je        short M04_L02
       test      esi,esi
       jne       short M04_L05
       xor       edx,edx
M04_L02:
       mov       rax,rdx
       pop       rbx
       pop       rsi
       ret
M04_L03:
       test      ebx,ebx
       je        short M04_L04
       inc       r9d
       add       r10d,r9d
       and       r10d,[r8+4]
       cmp       r9d,8
       jl        short M04_L00
M04_L04:
       mov       esi,2
       jmp       short M04_L01
M04_L05:
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFEFF6FD920]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny_NoCacheLookup(Void*, System.Object)
; Total bytes of code 166
```
```assembly
; System.Collections.ObjectModel.ReadOnlyCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IList`1<System.__Canon>)
       sub       rsp,28
       test      rdx,rdx
       je        short M05_L00
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       ret
M05_L00:
       mov       ecx,14
       call      qword ptr [7FFEFF97C1C8]
       int       3
; Total bytes of code 36
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       ebx,edx
       test      ebx,ebx
       jl        short M06_L03
       test      ebx,ebx
       je        short M06_L04
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+0A8]
       test      rax,rax
       je        short M06_L02
       mov       rcx,rax
M06_L00:
       mov       edx,ebx
       call      CORINFO_HELP_NEWARR_1_PTR
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M06_L01:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M06_L02:
       mov       rdx,7FFF000F86C0
       call      qword ptr [7FFEFF6FC5D0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M06_L00
M06_L03:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FFEFF97EEE0]
       int       3
M06_L04:
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+0B0]
       test      rdx,rdx
       je        short M06_L05
       jmp       short M06_L06
M06_L05:
       mov       rdx,7FFF000F86C8
       call      qword ptr [7FFEFF6FC5D0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M06_L06:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M06_L01
; Total bytes of code 179
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,[rbx+10]
       lea       ebp,[rdi+1]
       mov       ecx,ebp
       mov       rdx,[rbx+8]
       cmp       dword ptr [rdx+8],0
       jne       short M07_L01
       mov       edx,4
M07_L00:
       mov       eax,7FFFFFC7
       cmp       edx,7FFFFFC7
       cmova     edx,eax
       cmp       edx,ecx
       cmovl     edx,ecx
       mov       rcx,rbx
       call      qword ptr [7FFF5160DD70]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
       mov       [rbx+10],ebp
       mov       rcx,[rbx+8]
       movsxd    rdx,edi
       mov       r8,rsi
       call      qword ptr [7FFF515E7FF0]; Precode of System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M07_L01:
       mov       rdx,[rbx+8]
       mov       edx,[rdx+8]
       add       edx,edx
       jmp       short M07_L00
; Total bytes of code 105
```
```assembly
; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        short M08_L02
       call      qword ptr [7FFF6B925730]
       cmp       byte ptr [rax],0
       jne       short M08_L00
       mov       rcx,rsi
       call      qword ptr [7FFF6B927878]
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFF6B9256E8]; Precode of System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
       test      rax,rax
       jne       short M08_L01
M08_L00:
       mov       rcx,rsi
       call      qword ptr [7FFF6B927880]
       mov       rcx,rax
       call      qword ptr [7FFF6B9256D0]; CORINFO_HELP_NEWFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFF6B929010]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M08_L01:
       mov       rcx,rax
       lea       r11,[System.Linq.Enumerable.Select[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>)]
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [r11]
M08_L02:
       mov       ecx,11
       call      qword ptr [7FFF6B9295A8]
       int       3
; Total bytes of code 133
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCreditCards()
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-28],rax
       mov       [rbp-30],rax
       mov       rbx,rcx
       mov       ecx,[rbx+268]
       mov       byte ptr [rbp-28],1
       mov       dword ptr [rbp-24],2
       test      ecx,ecx
       setg      al
       movzx     eax,al
       test      eax,eax
       je        short M00_L02
M00_L00:
       call      qword ptr [7FFF00027498]; DotNetTips.Spargine.Tester.RandomCreditCardNumberGenerator.GetCreditCardNumbers(Int32)
       mov       rsi,rax
       test      rsi,rsi
       je        near ptr M00_L05
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Generic.IList<System.String>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M00_L06
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
M00_L01:
       mov       [rbp-30],r14
       mov       rbx,[rbx+60]
       mov       rdx,[rbp-30]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M00_L02:
       movzx     ecx,byte ptr [rbp-28]
       test      cl,cl
       je        short M00_L03
       lea       rcx,[rbp-28]
       call      qword ptr [7FFEFFD1E478]
       mov       ecx,eax
       jmp       near ptr M00_L00
M00_L03:
       call      qword ptr [7FFEFFD1E490]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L04
       call      qword ptr [7FFF0002F828]
       mov       rbx,rax
M00_L04:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,2A623F43620
       call      qword ptr [7FFEFF98DEC0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       call      qword ptr [7FFEFF98D968]
       mov       ecx,5B
       mov       rdx,7FFEFFD4F450
       call      qword ptr [7FFEFF987738]
       mov       rbx,rax
       mov       ecx,1B61
       mov       rdx,7FFEFFA55D90
       call      qword ptr [7FFEFF987738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFEFF707870]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFEFFD4F450
       call      qword ptr [7FFEFF987738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFEFF707870]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFEFFEFC288]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFEFFEFC2A0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L06:
       mov       rdx,rsi
       mov       rcx,offset MT_System.String[]
       call      qword ptr [7FFEFF7058F0]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        short M00_L07
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       rdx,rdi
       call      qword ptr [7FFEFFB05E00]; System.Collections.ObjectModel.ReadOnlyCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IList`1<System.__Canon>)
       jmp       near ptr M00_L01
M00_L07:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Generic.ICollection<System.String>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       r14,rax
       test      r14,r14
       je        near ptr M00_L11
       mov       rcx,offset MT_System.Collections.Generic.List<System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,r14
       mov       r11,7FFEFF651300
       call      qword ptr [r11]
       mov       edx,eax
       mov       rcx,rdi
       call      qword ptr [7FFEFF98EC70]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,rsi
       mov       r11,7FFEFF651308
       call      qword ptr [r11]
       mov       [rbp-38],rax
M00_L08:
       mov       rcx,[rbp-38]
       mov       r11,7FFEFF651310
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L10
       mov       rcx,[rbp-38]
       mov       r11,7FFEFF651318
       call      qword ptr [r11]
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       edx,[rdi+10]
       cmp       [rcx+8],edx
       jbe       short M00_L09
       lea       r8d,[rdx+1]
       mov       [rdi+10],r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M00_L08
M00_L09:
       mov       rcx,rdi
       mov       rdx,rax
       call      qword ptr [7FFEFF8AE370]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M00_L08
M00_L10:
       mov       rcx,[rbp-38]
       mov       r11,7FFEFF651320
       call      qword ptr [r11]
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       rdx,rdi
       call      qword ptr [7FFEFFB05E00]; System.Collections.ObjectModel.ReadOnlyCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IList`1<System.__Canon>)
       jmp       near ptr M00_L01
M00_L11:
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdx,rsi
       mov       rcx,7FFF002A49C0
       call      qword ptr [7FFEFFD1D5F0]; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFEFFB05E00]; System.Collections.ObjectModel.ReadOnlyCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IList`1<System.__Canon>)
       jmp       near ptr M00_L01
       sub       rsp,28
       cmp       qword ptr [rbp-38],0
       je        short M00_L12
       mov       rcx,[rbp-38]
       mov       r11,7FFEFF651320
       call      qword ptr [r11]
M00_L12:
       nop
       add       rsp,28
       ret
; Total bytes of code 807
```
```assembly
; DotNetTips.Spargine.Tester.RandomCreditCardNumberGenerator.GetCreditCardNumbers(Int32)
; 		count = count.ArgumentInRange(min: 1);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var result = new List<string>(count);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		for (var cardCount = 0; cardCount < count; cardCount++)
; 		     ^^^^^^^^^^^^^^^^^
; 			var prefixAndLength = _prefixes[RandomNumberGenerator.GetInt32(0, _prefixes.Length)];
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			result.Add(CreateFakeCreditCardNumber(prefixAndLength.Prefix, prefixAndLength.Length));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return result.AsReadOnly();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       vzeroupper
       lea       rbp,[rsp+0C0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       xor       eax,eax
       mov       [rbp-40],rax
       mov       ebx,ecx
       lea       rcx,[rbp-88]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rcx,rsp
       mov       [rbp-70],rcx
       mov       rcx,rbp
       mov       [rbp-60],rcx
       test      ebx,ebx
       setg      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M01_L08
M01_L00:
       mov       rcx,offset MT_System.Collections.Generic.List<System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       test      ebx,ebx
       jl        near ptr M01_L11
       test      ebx,ebx
       je        near ptr M01_L12
       mov       edx,ebx
       mov       rcx,offset MT_System.String[]
       call      CORINFO_HELP_NEWARR_1_PTR
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M01_L01:
       mov       [rbp-90],rdi
       xor       r14d,r14d
       cmp       r14d,ebx
       jl        short M01_L02
       jmp       near ptr M01_L13
M01_L02:
       mov       rdx,265BC000EA0
       mov       r15,[rdx]
       mov       [rbp-98],r15
       xor       edx,edx
       mov       [rbp-44],edx
M01_L03:
       lea       rdx,[rbp-44]
       mov       [rbp-50],rdx
       lea       rdx,[rbp-44]
       mov       r8d,4
       xor       ecx,ecx
       mov       r9d,2
       mov       rax,7FFEFFDB0488
       mov       [rbp-78],rax
       lea       rax,[M01_L04]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFF8CB23670
       call      rax
M01_L04:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFF5F64F778],0
       je        short M01_L05
       call      qword ptr [7FFF5F63D608]; CORINFO_HELP_STOP_FOR_GC
M01_L05:
       mov       rcx,[rbp-80]
       mov       [rsi+8],rcx
       test      eax,eax
       jne       near ptr M01_L15
       xor       ecx,ecx
       mov       [rbp-50],rcx
       mov       [rbp-50],rcx
       mov       ecx,[rbp-44]
       and       ecx,3F
       cmp       ecx,31
       ja        near ptr M01_L03
       mov       ecx,ecx
       shl       rcx,4
       mov       r15,[rbp-98]
       lea       rcx,[r15+rcx+10]
       mov       rdx,[rcx]
       mov       eax,[rcx+8]
       mov       rcx,rdx
       mov       edx,eax
       call      qword ptr [7FFF00027588]; DotNetTips.Spargine.Tester.RandomCreditCardNumberGenerator.CreateFakeCreditCardNumber(System.String, Int32)
       mov       rdi,[rbp-90]
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       edx,[rdi+10]
       mov       r8d,[rcx+8]
       cmp       r8d,edx
       jbe       near ptr M01_L14
       lea       r8d,[rdx+1]
       mov       [rdi+10],r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M01_L06:
       add       r14d,1
       jo        near ptr M01_L16
       cmp       r14d,ebx
       jl        near ptr M01_L02
M01_L07:
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
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
M01_L08:
       movzx     ecx,byte ptr [rbp-40]
       test      cl,cl
       je        short M01_L09
       lea       rcx,[rbp-40]
       call      qword ptr [7FFEFFD1E478]
       mov       ebx,eax
       jmp       near ptr M01_L00
M01_L09:
       call      qword ptr [7FFEFFD1E490]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L10
       call      qword ptr [7FFF0002F828]
       mov       rbx,rax
M01_L10:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,2A623F43620
       call      qword ptr [7FFEFF98DEC0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M01_L11:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FFEFF98EEE0]
       int       3
M01_L12:
       mov       rcx,2658F000230
       mov       rdx,[rcx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L01
M01_L13:
       mov       rdi,[rbp-90]
       jmp       near ptr M01_L07
M01_L14:
       mov       rcx,rdi
       mov       rdx,rax
       call      qword ptr [7FFEFF8AE370]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M01_L06
M01_L15:
       mov       ecx,eax
       call      qword ptr [7FFF0002E6E8]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M01_L16:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 689
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rdx,rdx
       je        short M02_L07
       mov       rax,[rdx]
       movzx     r8d,word ptr [rax+0E]
       test      r8,r8
       je        short M02_L03
       mov       r10,[rax+38]
       cmp       r8,4
       jl        short M02_L01
       cmp       [r10],rcx
       je        short M02_L07
M02_L00:
       cmp       [r10+8],rcx
       je        short M02_L07
       cmp       [r10+10],rcx
       je        short M02_L07
       cmp       [r10+18],rcx
       je        short M02_L07
       add       r10,20
       add       r8,0FFFFFFFFFFFFFFFC
       cmp       r8,4
       jge       short M02_L05
       test      r8,r8
       je        short M02_L03
M02_L01:
       cmp       [r10],rcx
       je        short M02_L07
M02_L02:
       add       r10,8
       dec       r8
       test      r8,r8
       jg        short M02_L04
M02_L03:
       test      dword ptr [rax],500C0000
       je        short M02_L06
       jmp       qword ptr [7FFEFFD17918]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
M02_L04:
       cmp       [r10],rcx
       je        short M02_L07
       jmp       short M02_L02
M02_L05:
       cmp       [r10],rcx
       je        short M02_L07
       jmp       short M02_L00
M02_L06:
       xor       edx,edx
M02_L07:
       mov       rax,rdx
       ret
; Total bytes of code 121
```
```assembly
; System.String.Concat(System.String, System.String)
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       test      rbx,rbx
       je        near ptr M03_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M03_L01
       test      rsi,rsi
       je        short M03_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M03_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M03_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFF5F338D20
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFEFF705818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFEFF705818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L00:
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L01:
       test      rsi,rsi
       je        short M03_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M03_L03
M03_L02:
       mov       rax,2A623F40008
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L03:
       mov       rax,rsi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L04:
       call      qword ptr [7FFF00126358]
       int       3
; Total bytes of code 244
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
       push      rsi
       push      rbx
       test      rdx,rdx
       je        short M04_L02
       mov       rax,[rdx]
       cmp       rax,rcx
       je        short M04_L02
       mov       r8,2658F000038
       mov       r8,[r8]
       add       r8,10
       rorx      r10,rax,20
       xor       r10,rcx
       mov       r9,9E3779B97F4A7C15
       imul      r10,r9
       mov       r9d,[r8]
       shrx      r10,r10,r9
       xor       r9d,r9d
M04_L00:
       lea       r11d,[r10+1]
       movsxd    r11,r11d
       lea       r11,[r11+r11*2]
       lea       r11,[r8+r11*8]
       mov       ebx,[r11]
       mov       rsi,[r11+8]
       and       ebx,0FFFFFFFE
       cmp       rsi,rax
       jne       short M04_L03
       mov       rsi,rcx
       xor       rsi,[r11+10]
       cmp       rsi,1
       ja        short M04_L03
       cmp       ebx,[r11]
       jne       short M04_L04
M04_L01:
       cmp       esi,1
       je        short M04_L02
       test      esi,esi
       jne       short M04_L05
       xor       edx,edx
M04_L02:
       mov       rax,rdx
       pop       rbx
       pop       rsi
       ret
M04_L03:
       test      ebx,ebx
       je        short M04_L04
       inc       r9d
       add       r10d,r9d
       and       r10d,[r8+4]
       cmp       r9d,8
       jl        short M04_L00
M04_L04:
       mov       esi,2
       jmp       short M04_L01
M04_L05:
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFEFF70D920]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny_NoCacheLookup(Void*, System.Object)
; Total bytes of code 166
```
```assembly
; System.Collections.ObjectModel.ReadOnlyCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IList`1<System.__Canon>)
       sub       rsp,28
       test      rdx,rdx
       je        short M05_L00
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       ret
M05_L00:
       mov       ecx,14
       call      qword ptr [7FFEFF98C1C8]
       int       3
; Total bytes of code 36
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       ebx,edx
       test      ebx,ebx
       jl        short M06_L03
       test      ebx,ebx
       je        short M06_L04
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+0A8]
       test      rax,rax
       je        short M06_L02
       mov       rcx,rax
M06_L00:
       mov       edx,ebx
       call      CORINFO_HELP_NEWARR_1_PTR
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M06_L01:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M06_L02:
       mov       rdx,7FFF000DD620
       call      qword ptr [7FFEFF70C5D0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M06_L00
M06_L03:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FFEFF98EEE0]
       int       3
M06_L04:
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+0B0]
       test      rdx,rdx
       je        short M06_L05
       jmp       short M06_L06
M06_L05:
       mov       rdx,7FFF000DE8D0
       call      qword ptr [7FFEFF70C5D0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M06_L06:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M06_L01
; Total bytes of code 179
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,[rbx+10]
       mov       ebp,edi
       lea       ecx,[rbp+1]
       mov       r14,[rbx+8]
       cmp       dword ptr [r14+8],0
       jne       near ptr M07_L04
       mov       r15d,4
M07_L00:
       mov       edx,7FFFFFC7
       cmp       r15d,7FFFFFC7
       cmova     r15d,edx
       cmp       r15d,ecx
       cmovl     r15d,ecx
       cmp       r15d,edi
       jl        near ptr M07_L07
       cmp       [r14+8],r15d
       je        short M07_L03
       test      r15d,r15d
       jle       near ptr M07_L08
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+0A8]
       test      rax,rax
       je        short M07_L05
       mov       rcx,rax
M07_L01:
       mov       edx,r15d
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r15,rax
       test      edi,edi
       jg        short M07_L06
M07_L02:
       lea       rcx,[rbx+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
M07_L03:
       lea       ecx,[rbp+1]
       mov       [rbx+10],ecx
       mov       rcx,[rbx+8]
       movsxd    rdx,ebp
       mov       r8,rsi
       call      qword ptr [7FFEFF7057B8]; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M07_L04:
       mov       r15d,[r14+8]
       add       r15d,r15d
       jmp       near ptr M07_L00
M07_L05:
       mov       rdx,7FFF000DD620
       call      qword ptr [7FFEFF70C5D0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M07_L01
M07_L06:
       mov       rcx,r14
       mov       r8d,edi
       mov       rdx,r15
       call      qword ptr [7FFEFF707060]; System.Array.Copy(System.Array, System.Array, Int32)
       jmp       short M07_L02
M07_L07:
       mov       ecx,7
       mov       edx,0F
       call      qword ptr [7FFEFF98EEE0]
       int       3
M07_L08:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+0B0]
       test      rdx,rdx
       je        short M07_L09
       jmp       short M07_L10
M07_L09:
       mov       rdx,7FFF000DE8D0
       call      qword ptr [7FFEFF70C5D0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M07_L10:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M07_L03
; Total bytes of code 322
```
```assembly
; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        short M08_L02
       call      qword ptr [7FFF6B925730]
       cmp       byte ptr [rax],0
       jne       short M08_L00
       mov       rcx,rsi
       call      qword ptr [7FFF6B927878]
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFF6B9256E8]; Precode of System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
       test      rax,rax
       jne       short M08_L01
M08_L00:
       mov       rcx,rsi
       call      qword ptr [7FFF6B927880]
       mov       rcx,rax
       call      qword ptr [7FFF6B9256D0]; CORINFO_HELP_NEWFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFF6B929010]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M08_L01:
       mov       rcx,rax
       lea       r11,[System.Linq.Enumerable.Select[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>)]
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [r11]
M08_L02:
       mov       ecx,11
       call      qword ptr [7FFF6B9295A8]
       int       3
; Total bytes of code 133
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCreditCards()
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-28],rax
       mov       [rbp-30],rax
       mov       rbx,rcx
       mov       ecx,[rbx+268]
       mov       byte ptr [rbp-28],1
       mov       dword ptr [rbp-24],2
       test      ecx,ecx
       setg      al
       movzx     eax,al
       test      eax,eax
       je        short M00_L02
M00_L00:
       call      qword ptr [7FFF0008EF10]; DotNetTips.Spargine.Tester.RandomCreditCardNumberGenerator.GetCreditCardNumbers(Int32)
       mov       rsi,rax
       test      rsi,rsi
       je        near ptr M00_L05
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Generic.IList<System.String>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M00_L06
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
M00_L01:
       mov       [rbp-30],r14
       mov       rbx,[rbx+60]
       mov       rdx,[rbp-30]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M00_L02:
       movzx     ecx,byte ptr [rbp-28]
       test      cl,cl
       je        short M00_L03
       lea       rcx,[rbp-28]
       call      qword ptr [7FFEFFD2E478]
       mov       ecx,eax
       jmp       near ptr M00_L00
M00_L03:
       call      qword ptr [7FFEFFD2E490]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L04
       call      qword ptr [7FFEFFF36148]
       mov       rbx,rax
M00_L04:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,19648523620
       call      qword ptr [7FFEFF99DEC0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       call      qword ptr [7FFEFF99D968]
       mov       ecx,5B
       mov       rdx,7FFEFFD5F450
       call      qword ptr [7FFEFF997738]
       mov       rbx,rax
       mov       ecx,1B61
       mov       rdx,7FFEFFA65D90
       call      qword ptr [7FFEFF997738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFEFF717870]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFEFFD5F450
       call      qword ptr [7FFEFF997738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFEFF717870]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFEFFF36160]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFEFFF36178]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L06:
       mov       rdx,rsi
       mov       rcx,offset MT_System.String[]
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        short M00_L07
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       rdx,rdi
       call      qword ptr [7FFEFFB15E00]; System.Collections.ObjectModel.ReadOnlyCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IList`1<System.__Canon>)
       jmp       near ptr M00_L01
M00_L07:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Generic.ICollection<System.String>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       r14,rax
       test      r14,r14
       je        near ptr M00_L11
       mov       rcx,offset MT_System.Collections.Generic.List<System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,r14
       mov       r11,7FFEFF661918
       call      qword ptr [r11]
       mov       edx,eax
       mov       rcx,rdi
       call      qword ptr [7FFEFF99EC70]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,rsi
       mov       r11,7FFEFF661920
       call      qword ptr [r11]
       mov       [rbp-38],rax
M00_L08:
       mov       rcx,[rbp-38]
       mov       r11,7FFEFF661928
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L10
       mov       rcx,[rbp-38]
       mov       r11,7FFEFF661930
       call      qword ptr [r11]
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       edx,[rdi+10]
       cmp       [rcx+8],edx
       jbe       short M00_L09
       lea       r8d,[rdx+1]
       mov       [rdi+10],r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M00_L08
M00_L09:
       mov       rcx,rdi
       mov       rdx,rax
       call      qword ptr [7FFEFF8BE370]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M00_L08
M00_L10:
       mov       rcx,[rbp-38]
       mov       r11,7FFEFF661938
       call      qword ptr [r11]
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       rdx,rdi
       call      qword ptr [7FFEFFB15E00]; System.Collections.ObjectModel.ReadOnlyCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IList`1<System.__Canon>)
       jmp       near ptr M00_L01
M00_L11:
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdx,rsi
       mov       rcx,7FFF0030CF90
       call      qword ptr [7FFEFFD2D5F0]; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFEFFB15E00]; System.Collections.ObjectModel.ReadOnlyCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IList`1<System.__Canon>)
       jmp       near ptr M00_L01
       sub       rsp,28
       cmp       qword ptr [rbp-38],0
       je        short M00_L12
       mov       rcx,[rbp-38]
       mov       r11,7FFEFF661938
       call      qword ptr [r11]
M00_L12:
       nop
       add       rsp,28
       ret
; Total bytes of code 806
```
```assembly
; DotNetTips.Spargine.Tester.RandomCreditCardNumberGenerator.GetCreditCardNumbers(Int32)
; 		count = count.ArgumentInRange(min: 1);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var result = new List<string>(count);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		for (var cardCount = 0; cardCount < count; cardCount++)
; 		     ^^^^^^^^^^^^^^^^^
; 			var prefixAndLength = _prefixes[RandomNumberGenerator.GetInt32(0, _prefixes.Length)];
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			result.Add(CreateFakeCreditCardNumber(prefixAndLength.Prefix, prefixAndLength.Length));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return result.AsReadOnly();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       vzeroupper
       lea       rbp,[rsp+0C0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       xor       eax,eax
       mov       [rbp-40],rax
       mov       ebx,ecx
       lea       rcx,[rbp-88]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rcx,rsp
       mov       [rbp-70],rcx
       mov       rcx,rbp
       mov       [rbp-60],rcx
       test      ebx,ebx
       setg      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M01_L09
M01_L00:
       mov       rcx,offset MT_System.Collections.Generic.List<System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       test      ebx,ebx
       jl        near ptr M01_L12
       test      ebx,ebx
       je        near ptr M01_L13
       mov       edx,ebx
       mov       rcx,offset MT_System.String[]
       call      CORINFO_HELP_NEWARR_1_PTR
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M01_L01:
       mov       [rbp-90],rdi
       xor       r14d,r14d
       cmp       r14d,ebx
       jl        short M01_L04
       jmp       near ptr M01_L14
M01_L02:
       lea       r8d,[rdx+1]
       mov       [rdi+10],r8d
       mov       edx,edx
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M01_L03:
       add       r14d,1
       jo        near ptr M01_L16
       cmp       r14d,ebx
       jge       near ptr M01_L08
M01_L04:
       mov       rdx,155DE400F48
       mov       r15,[rdx]
       mov       [rbp-98],r15
       xor       edx,edx
       mov       [rbp-44],edx
M01_L05:
       lea       rdx,[rbp-44]
       mov       [rbp-50],rdx
       lea       rdx,[rbp-44]
       mov       r8d,4
       xor       ecx,ecx
       mov       r9d,2
       mov       rax,7FFEFFDC0488
       mov       [rbp-78],rax
       lea       rax,[M01_L06]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFF8CB23670
       call      rax
M01_L06:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFF5F64F778],0
       je        short M01_L07
       call      qword ptr [7FFF5F63D608]; CORINFO_HELP_STOP_FOR_GC
M01_L07:
       mov       rcx,[rbp-80]
       mov       [rsi+8],rcx
       test      eax,eax
       jne       near ptr M01_L15
       xor       ecx,ecx
       mov       [rbp-50],rcx
       mov       [rbp-50],rcx
       mov       ecx,[rbp-44]
       and       ecx,3F
       cmp       ecx,31
       ja        near ptr M01_L05
       mov       ecx,ecx
       shl       rcx,4
       mov       r15,[rbp-98]
       lea       rcx,[r15+rcx+10]
       mov       rdx,[rcx]
       mov       eax,[rcx+8]
       mov       rcx,rdx
       mov       edx,eax
       call      qword ptr [7FFF0008F000]; DotNetTips.Spargine.Tester.RandomCreditCardNumberGenerator.CreateFakeCreditCardNumber(System.String, Int32)
       mov       rdi,[rbp-90]
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       edx,[rdi+10]
       cmp       [rcx+8],edx
       ja        near ptr M01_L02
       mov       rcx,rdi
       mov       rdx,rax
       call      qword ptr [7FFEFF8BE370]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M01_L03
M01_L08:
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
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
M01_L09:
       movzx     ecx,byte ptr [rbp-40]
       test      cl,cl
       je        short M01_L10
       lea       rcx,[rbp-40]
       call      qword ptr [7FFEFFD2E478]
       mov       ebx,eax
       jmp       near ptr M01_L00
M01_L10:
       call      qword ptr [7FFEFFD2E490]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L11
       call      qword ptr [7FFEFFF36148]
       mov       rbx,rax
M01_L11:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,19648523620
       call      qword ptr [7FFEFF99DEC0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M01_L12:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FFEFF99EEE0]
       int       3
M01_L13:
       mov       rcx,155B3400230
       mov       rdx,[rcx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L01
M01_L14:
       mov       rdi,[rbp-90]
       jmp       near ptr M01_L08
M01_L15:
       mov       ecx,eax
       call      qword ptr [7FFF001E5A70]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M01_L16:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 687
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rdx,rdx
       je        short M02_L06
       mov       rax,[rdx]
       movzx     r8d,word ptr [rax+0E]
       test      r8,r8
       je        short M02_L03
       mov       r10,[rax+38]
       cmp       r8,4
       jl        short M02_L01
       cmp       [r10],rcx
       je        short M02_L06
M02_L00:
       cmp       [r10+8],rcx
       je        short M02_L06
       cmp       [r10+10],rcx
       je        short M02_L06
       cmp       [r10+18],rcx
       je        short M02_L06
       add       r10,20
       add       r8,0FFFFFFFFFFFFFFFC
       cmp       r8,4
       jge       short M02_L04
       test      r8,r8
       je        short M02_L03
M02_L01:
       cmp       [r10],rcx
       je        short M02_L06
M02_L02:
       add       r10,8
       dec       r8
       test      r8,r8
       jle       short M02_L03
       cmp       [r10],rcx
       je        short M02_L06
       jmp       short M02_L02
M02_L03:
       test      dword ptr [rax],500C0000
       je        short M02_L05
       jmp       qword ptr [7FFEFFD27918]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
M02_L04:
       cmp       [r10],rcx
       je        short M02_L06
       jmp       short M02_L00
M02_L05:
       xor       edx,edx
M02_L06:
       mov       rax,rdx
       ret
; Total bytes of code 121
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
       je        near ptr M03_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M03_L01
       test      rsi,rsi
       je        short M03_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M03_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M03_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFF5F338D20
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFEFF715818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFEFF715818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L00:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L01:
       test      rsi,rsi
       je        short M03_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M03_L03
M03_L02:
       mov       rax,19648520008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L03:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L04:
       call      qword ptr [7FFF001E71B0]
       int       3
; Total bytes of code 231
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
       push      rsi
       push      rbx
       test      rdx,rdx
       je        short M04_L02
       mov       rax,[rdx]
       cmp       rax,rcx
       je        short M04_L02
       mov       r8,155B3400038
       mov       r8,[r8]
       add       r8,10
       rorx      r10,rax,20
       xor       r10,rcx
       mov       r9,9E3779B97F4A7C15
       imul      r10,r9
       mov       r9d,[r8]
       shrx      r10,r10,r9
       xor       r9d,r9d
M04_L00:
       lea       r11d,[r10+1]
       movsxd    r11,r11d
       lea       r11,[r11+r11*2]
       lea       r11,[r8+r11*8]
       mov       ebx,[r11]
       mov       rsi,[r11+8]
       and       ebx,0FFFFFFFE
       cmp       rsi,rax
       jne       short M04_L03
       mov       rsi,rcx
       xor       rsi,[r11+10]
       cmp       rsi,1
       ja        short M04_L03
       cmp       ebx,[r11]
       jne       short M04_L05
M04_L01:
       cmp       esi,1
       je        short M04_L02
       test      esi,esi
       jne       short M04_L04
       xor       edx,edx
M04_L02:
       mov       rax,rdx
       pop       rbx
       pop       rsi
       ret
M04_L03:
       test      ebx,ebx
       je        short M04_L05
       inc       r9d
       add       r10d,r9d
       and       r10d,[r8+4]
       cmp       r9d,8
       jl        short M04_L00
       jmp       short M04_L05
M04_L04:
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFEFF71D920]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny_NoCacheLookup(Void*, System.Object)
M04_L05:
       mov       esi,2
       jmp       short M04_L01
; Total bytes of code 168
```
```assembly
; System.Collections.ObjectModel.ReadOnlyCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IList`1<System.__Canon>)
       sub       rsp,28
       test      rdx,rdx
       je        short M05_L00
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       ret
M05_L00:
       mov       ecx,14
       call      qword ptr [7FFEFF99C1C8]
       int       3
; Total bytes of code 36
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       ebx,edx
       test      ebx,ebx
       jl        short M06_L03
       test      ebx,ebx
       je        short M06_L04
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+70]
       test      rax,rax
       je        short M06_L02
       mov       rcx,rax
M06_L00:
       mov       edx,ebx
       call      CORINFO_HELP_NEWARR_1_PTR
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M06_L01:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M06_L02:
       mov       rdx,7FFEFFEF1058
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M06_L00
M06_L03:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FFEFF99EEE0]
       int       3
M06_L04:
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+78]
       test      rdx,rdx
       je        short M06_L05
       jmp       short M06_L06
M06_L05:
       mov       rdx,7FFEFFEF40E0
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M06_L06:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M06_L01
; Total bytes of code 171
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,[rbx+10]
       mov       ebp,edi
       lea       ecx,[rbp+1]
       mov       r14,[rbx+8]
       cmp       dword ptr [r14+8],0
       jne       near ptr M07_L04
       mov       r15d,4
M07_L00:
       mov       edx,7FFFFFC7
       cmp       r15d,7FFFFFC7
       cmova     r15d,edx
       cmp       r15d,ecx
       cmovl     r15d,ecx
       cmp       r15d,edi
       jl        near ptr M07_L07
       cmp       [r14+8],r15d
       je        short M07_L03
       test      r15d,r15d
       jle       near ptr M07_L08
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+70]
       test      rax,rax
       je        short M07_L05
       mov       rcx,rax
M07_L01:
       mov       edx,r15d
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r15,rax
       test      edi,edi
       jg        short M07_L06
M07_L02:
       lea       rcx,[rbx+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
M07_L03:
       lea       ecx,[rbp+1]
       mov       [rbx+10],ecx
       mov       rcx,[rbx+8]
       movsxd    rdx,ebp
       mov       r8,rsi
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M07_L04:
       mov       r15d,[r14+8]
       add       r15d,r15d
       jmp       near ptr M07_L00
M07_L05:
       mov       rdx,7FFEFFEF1058
       call      qword ptr [7FFEFF71C5D0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M07_L01
M07_L06:
       mov       rcx,r14
       mov       r8d,edi
       mov       rdx,r15
       call      qword ptr [7FFEFF717060]; System.Array.Copy(System.Array, System.Array, Int32)
       jmp       short M07_L02
M07_L07:
       mov       ecx,7
       mov       edx,0F
       call      qword ptr [7FFEFF99EEE0]
       int       3
M07_L08:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+78]
       test      rdx,rdx
       je        short M07_L09
       jmp       short M07_L10
M07_L09:
       mov       rdx,7FFEFFEF40E0
       call      qword ptr [7FFEFF71C5D0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M07_L10:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M07_L03
; Total bytes of code 315
```
```assembly
; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        short M08_L02
       call      qword ptr [7FFF6B925730]
       cmp       byte ptr [rax],0
       jne       short M08_L00
       mov       rcx,rsi
       call      qword ptr [7FFF6B927878]
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFF6B9256E8]; Precode of System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
       test      rax,rax
       jne       short M08_L01
M08_L00:
       mov       rcx,rsi
       call      qword ptr [7FFF6B927880]
       mov       rcx,rax
       call      qword ptr [7FFF6B9256D0]; CORINFO_HELP_NEWFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFF6B929010]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M08_L01:
       mov       rcx,rax
       lea       r11,[System.Linq.Enumerable.Select[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>)]
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [r11]
M08_L02:
       mov       ecx,11
       call      qword ptr [7FFF6B9295A8]
       int       3
; Total bytes of code 133
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonRecordCollection()
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       call      qword ptr [7FFEFFD3C6D8]; DotNetTips.Spargine.Benchmarking.LargeCollectionBenchmark.get_Count()
       mov       ecx,eax
       call      qword ptr [7FFEFFF26CD0]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecordCollection(Int32)
       mov       [rbp-8],rax
       mov       rcx,[rbp+10]
       mov       r8,[rbp-8]
       mov       rdx,7FFF0012C980
       call      qword ptr [7FFF0009DC38]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 73
```
```assembly
; DotNetTips.Spargine.Benchmarking.LargeCollectionBenchmark.get_Count()
       push      rbp
       mov       rbp,rsp
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       eax,[rax+268]
       pop       rbp
       ret
; Total bytes of code 20
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecordCollection(Int32)
; 		count = count.ArgumentInRange(min: 1, defaultValue: 2);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var records = new List<PersonRecord>(count);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		for (var recordIndex = 0; recordIndex < count; recordIndex++)
; 		     ^^^^^^^^^^^^^^^^^^^
; 			records.Add(GeneratePersonRecord());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return records.ToReadOnlyCollection();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rbp
       sub       rsp,0B0
       lea       rbp,[rsp+0B0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-80],ymm4
       vmovdqu   ymmword ptr [rbp-60],ymm4
       xor       eax,eax
       mov       [rbp-40],rax
       mov       [rbp+10],ecx
       mov       dword ptr [rbp-78],3E8
       xor       eax,eax
       mov       [rbp-68],rax
       lea       rcx,[rbp-68]
       mov       edx,2
       call      qword ptr [7FFEFFC06748]; System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       rax,[rbp-68]
       mov       [rbp-48],rax
       lea       rax,[rbp-48]
       mov       [rsp+20],rax
       mov       rax,26222EA0008
       mov       [rsp+28],rax
       mov       ecx,[rbp+10]
       mov       edx,1
       mov       r8,26222EA3620
       mov       r9d,7FFFFFFF
       call      qword ptr [7FFEFFD3E250]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32> ByRef, System.String)
       mov       [rbp+10],eax
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord>
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-70],rax
       mov       rcx,[rbp-70]
       mov       edx,[rbp+10]
       call      qword ptr [7FFEFF9AEC70]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       mov       rax,[rbp-70]
       mov       [rbp-40],rax
       xor       eax,eax
       mov       [rbp-4C],eax
       jmp       short M02_L01
M02_L00:
       mov       rcx,7FFF00086EF0
       call      CORINFO_HELP_COUNTPROFILE32
       mov       dword ptr [rbp-58],19
       mov       dword ptr [rbp-60],14
       lea       rdx,[rbp-58]
       lea       r8,[rbp-60]
       mov       ecx,2
       call      qword ptr [7FFEFFD3E178]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecord(Int32, Int32 ByRef, Int32 ByRef)
       mov       [rbp-80],rax
       mov       rdx,[rbp-80]
       mov       rcx,[rbp-40]
       cmp       [rcx],ecx
       call      qword ptr [7FFEFF8417D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       mov       eax,[rbp-4C]
       add       eax,1
       jo        short M02_L03
       mov       [rbp-4C],eax
M02_L01:
       mov       eax,[rbp-78]
       dec       eax
       mov       [rbp-78],eax
       cmp       dword ptr [rbp-78],0
       jg        short M02_L02
       lea       rcx,[rbp-78]
       mov       edx,47
       call      CORINFO_HELP_PATCHPOINT
M02_L02:
       mov       eax,[rbp-4C]
       cmp       eax,[rbp+10]
       jl        short M02_L00
       mov       rcx,7FFF00086EF4
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rdx,[rbp-40]
       mov       rcx,7FFF00086E80
       call      qword ptr [7FFEFFD3D3E0]; DotNetTips.Spargine.Extensions.EnumerableExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       nop
       add       rsp,0B0
       pop       rbp
       ret
M02_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 345
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
       mov       rdx,7FFF00244ED8
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M03_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFF00215B60]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFF00215B18]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 129
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonValCollection()
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       call      qword ptr [7FFEFFD2C6D8]; DotNetTips.Spargine.Benchmarking.LargeCollectionBenchmark.get_Count()
       mov       ecx,eax
       call      qword ptr [7FFEFFEAE748]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonValCollection(Int32)
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       cmp       [rcx],ecx
       call      qword ptr [7FFEFFF16C78]; Precode of System.Collections.ObjectModel.ReadOnlyCollection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.10.Tester]].get_Count()
       mov       [rbp-0C],eax
       mov       edx,[rbp-0C]
       mov       rcx,[rbp+10]
       call      qword ptr [7FFF0008E388]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 77
```
```assembly
; DotNetTips.Spargine.Benchmarking.LargeCollectionBenchmark.get_Count()
       push      rbp
       mov       rbp,rsp
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       eax,[rax+268]
       pop       rbp
       ret
; Total bytes of code 20
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonValCollection(Int32)
; 		count = count.ArgumentInRange(min: 1, defaultValue: 2);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var people = new List<Models.ValueTypes.Person>(count);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		for (var index = 0; index < count; index++)
; 		     ^^^^^^^^^^^^^
; 			people.Add(GeneratePersonVal());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return people.ToReadOnlyCollection();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rbp
       sub       rsp,140
       lea       rbp,[rsp+140]
       xor       eax,eax
       mov       [rbp-108],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFF40
M02_L00:
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       vmovdqa   xmmword ptr [rbp+rax-20],xmm4
       add       rax,30
       jne       short M02_L00
       mov       [rbp-40],rax
       mov       [rbp+10],ecx
       mov       dword ptr [rbp-0B8],3E8
       xor       eax,eax
       mov       [rbp-58],rax
       lea       rcx,[rbp-58]
       mov       edx,2
       call      qword ptr [7FFEFFBF6748]; System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       rax,[rbp-58]
       mov       [rbp-48],rax
       lea       rax,[rbp-48]
       mov       [rsp+20],rax
       mov       rax,26403FB0008
       mov       [rsp+28],rax
       mov       ecx,[rbp+10]
       mov       edx,1
       mov       r8,26403FB3620
       mov       r9d,7FFFFFFF
       call      qword ptr [7FFEFFD2E250]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32> ByRef, System.String)
       mov       [rbp+10],eax
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-60],rax
       mov       rcx,[rbp-60]
       mov       edx,[rbp+10]
       call      qword ptr [7FFEFFEAE778]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.10.Tester]]..ctor(Int32)
       mov       rax,[rbp-60]
       mov       [rbp-40],rax
       xor       eax,eax
       mov       [rbp-4C],eax
       jmp       short M02_L02
M02_L01:
       mov       rcx,7FFF000745C0
       call      CORINFO_HELP_COUNTPROFILE32
       lea       rcx,[rbp-0B0]
       mov       edx,2
       mov       r8d,19
       mov       r9d,14
       call      qword ptr [7FFEFFDD5020]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonVal(Int32, Int32, Int32)
       vmovdqu   ymm0,ymmword ptr [rbp-0B0]
       vmovdqu   ymmword ptr [rbp-108],ymm0
       vmovdqu   ymm0,ymmword ptr [rbp-90]
       vmovdqu   ymmword ptr [rbp-0E8],ymm0
       vmovdqu   xmm0,xmmword ptr [rbp-70]
       vmovdqu   xmmword ptr [rbp-0C8],xmm0
       lea       rdx,[rbp-108]
       mov       rcx,[rbp-40]
       cmp       [rcx],ecx
       call      qword ptr [7FFEFFE07500]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.10.Tester]].Add(DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       mov       eax,[rbp-4C]
       add       eax,1
       jo        short M02_L04
       mov       [rbp-4C],eax
M02_L02:
       mov       eax,[rbp-0B8]
       dec       eax
       mov       [rbp-0B8],eax
       cmp       dword ptr [rbp-0B8],0
       jg        short M02_L03
       lea       rcx,[rbp-0B8]
       mov       edx,40
       call      CORINFO_HELP_PATCHPOINT
M02_L03:
       mov       eax,[rbp-4C]
       cmp       eax,[rbp+10]
       jl        near ptr M02_L01
       mov       rcx,7FFF000745C4
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp-40]
       call      qword ptr [7FFEFFF4FDE0]; DotNetTips.Spargine.Extensions.EnumerableExtensions.ToReadOnlyCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.10.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>)
       nop
       vzeroupper
       add       rsp,140
       pop       rbp
       ret
M02_L04:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 429
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
       call      qword ptr [7FFF00204A68]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       lea       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFF00204A38]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 60
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.PersonOrderByBenchmark()
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
       xor       eax,eax
       mov       [rbp-58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp-40],rax
       mov       rbx,rcx
       lea       rcx,[rbp-90]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rcx,rsp
       mov       [rbp-78],rcx
       mov       rcx,rbp
       mov       [rbp-68],rcx
       mov       [rbp+10],rbx
       mov       rdi,[rbx+288]
       mov       rcx,17CF4800E60
       mov       r14,[rcx]
       test      r14,r14
       je        near ptr M00_L60
M00_L00:
       mov       rcx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [r15+10],eax
       lea       rcx,[r15+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        near ptr M00_L58
       xor       ecx,ecx
       mov       [r15+20],rcx
       lea       rcx,[r15+28]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,17CCB800A08
       mov       rdx,[rcx]
       lea       rcx,[r15+30]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [r15+48],0
       mov       rcx,[r15+18]
       mov       rax,offset MT_System.Collections.ObjectModel.Collection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rax
       jne       near ptr M00_L63
       mov       rdi,[rcx+8]
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rdi],rcx
       jne       near ptr M00_L62
       mov       r14d,[rdi+8]
       test      r14d,r14d
       jne       near ptr M00_L59
       mov       r13,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,r13
       test      byte ptr [7FFEFFFFDE58],1
       je        near ptr M00_L61
M00_L01:
       mov       rcx,17CF4800E98
       mov       r12,[rcx]
M00_L02:
       mov       [rbp-98],r12
       mov       r13,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r12],r13
       jne       near ptr M00_L30
       mov       ecx,[r12+8]
       inc       ecx
       cmp       ecx,[r12+0C]
       jae       near ptr M00_L29
       mov       [r12+8],ecx
M00_L03:
       mov       rdi,[r15+30]
       mov       [rbp-0A0],rdi
       mov       r14,[r15+28]
       mov       [rbp-0A8],r14
       cmp       [r12],r13
       jne       near ptr M00_L32
       mov       ecx,[r12+8]
       cmp       ecx,[r12+0C]
       jae       near ptr M00_L31
       mov       rax,[r12+10]
       cmp       ecx,[rax+8]
       jae       near ptr M00_L54
       mov       r12,[rax+rcx*8+10]
       mov       rcx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonOrderByBenchmark>b__12_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [r14+18],rcx
       jne       near ptr M00_L33
       mov       rax,[r12+30]
M00_L04:
       cmp       byte ptr [r15+48],0
       jne       near ptr M00_L34
       test      r14,r14
       je        near ptr M00_L20
       test      rdi,rdi
       je        near ptr M00_L20
       mov       r15,[rbp-98]
       cmp       [r15],r13
       jne       near ptr M00_L20
       mov       rcx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonOrderByBenchmark>b__12_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [r14+18],rcx
       jne       near ptr M00_L20
       mov       rcx,offset MT_System.Collections.Generic.GenericComparer<System.String>
       cmp       [rdi],rcx
       jne       near ptr M00_L20
       jmp       short M00_L09
M00_L05:
       mov       rdi,[rbp-0C0]
       mov       rax,r14
       mov       [rbp-0B0],rdi
       mov       r12,[rbp-0B0]
       jmp       short M00_L09
M00_L06:
       cmp       rdx,r9
       je        near ptr M00_L38
       mov       [rbp-0B0],r12
       jmp       near ptr M00_L12
M00_L07:
       xor       ecx,ecx
M00_L08:
       test      ecx,ecx
       mov       rax,[rbp-0B8]
       mov       r15,[rbp-98]
       jge       short M00_L05
M00_L09:
       mov       edx,[r15+8]
       inc       edx
       cmp       edx,[r15+0C]
       jae       near ptr M00_L27
       mov       [r15+8],edx
       mov       r8d,[r15+8]
       cmp       r8d,[r15+0C]
       jae       near ptr M00_L53
       mov       r14,[r15+10]
       cmp       r8d,[r14+8]
       jae       near ptr M00_L54
       mov       ecx,r8d
       mov       rdi,[r14+rcx*8+10]
       mov       [rbp-0C0],rdi
       mov       r14,[rdi+30]
       test      r14,r14
       je        near ptr M00_L40
       test      rax,rax
       je        near ptr M00_L39
       mov       [rbp-0B8],rax
       cmp       r14,rax
       je        short M00_L07
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],2
       jle       near ptr M00_L36
       mov       rcx,[rcx+240]
       mov       rdx,[rcx+10]
       test      rdx,rdx
       je        near ptr M00_L36
M00_L10:
       mov       rcx,[rdx+10]
       test      rcx,rcx
       jne       short M00_L11
       mov       rcx,17CCB800110
       mov       rcx,[rcx]
       test      rcx,rcx
       jne       short M00_L11
       mov       rcx,17CCB8000F0
       mov       rcx,[rcx]
       test      rcx,rcx
       je        near ptr M00_L37
M00_L11:
       mov       rdx,[rcx]
       mov       rdx,[rdx+48]
       call      qword ptr [rdx+30]
       cmp       [rax],al
       lea       rdx,[r14+0C]
       mov       [rbp-0C8],r14
       mov       r8d,[r14+8]
       mov       r10,[rbp-0B8]
       lea       r9,[r10+0C]
       mov       [rbp-0B8],r10
       mov       r11d,[r10+8]
       cmp       r8d,r11d
       je        near ptr M00_L06
       mov       [rbp-0B0],r12
M00_L12:
       mov       [rbp-48],rdx
       mov       [rbp-50],r9
       mov       rcx,[rax+20]
       mov       [rsp+20],r11d
       xor       eax,eax
       mov       [rsp+28],eax
       mov       rax,7FFEFF95B650
       mov       [rbp-80],rax
       lea       rax,[M00_L13]
       mov       [rbp-70],rax
       lea       rax,[rbp-90]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFF5F2F93A0
       call      rax
M00_L13:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFF5F64F778],0
       je        short M00_L14
       call      qword ptr [7FFF5F63D608]; CORINFO_HELP_STOP_FOR_GC
M00_L14:
       mov       rcx,[rbp-88]
       mov       [rsi+8],rcx
       xor       ecx,ecx
       mov       [rbp-48],rcx
       mov       [rbp-50],rcx
M00_L15:
       mov       ecx,eax
       mov       r12,[rbp-0B0]
       mov       r14,[rbp-0C8]
       jmp       near ptr M00_L08
M00_L16:
       mov       rdx,[rbp-0C0]
       mov       r10,[rbp-0C8]
       mov       r11,r10
       mov       r12,rdx
       mov       rax,r11
       jmp       short M00_L20
M00_L17:
       cmp       rdx,r9
       je        near ptr M00_L52
       mov       [rbp-0B0],r12
       jmp       near ptr M00_L23
M00_L18:
       xor       ecx,ecx
       mov       [rbp-0B0],r12
M00_L19:
       test      ecx,ecx
       mov       rax,[rbp-0B8]
       mov       r12,[rbp-0B0]
       mov       r14,[rbp-0A8]
       jge       short M00_L16
M00_L20:
       mov       r15,[rbp-98]
       cmp       [r15],r13
       jne       near ptr M00_L42
       mov       edx,[r15+8]
       inc       edx
       cmp       edx,[r15+0C]
       jae       near ptr M00_L27
       mov       [r15+8],edx
       mov       ecx,[r15+8]
       cmp       ecx,[r15+0C]
       jae       near ptr M00_L53
       mov       rcx,[r15+10]
       mov       r8d,[r15+8]
       cmp       r8d,[rcx+8]
       jae       near ptr M00_L54
       mov       edx,r8d
       mov       rcx,[rcx+rdx*8+10]
       mov       rdx,rcx
       mov       rcx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonOrderByBenchmark>b__12_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [r14+18],rcx
       jne       near ptr M00_L43
       mov       r15,[rbp-98]
       mov       [rbp-0C0],rdx
       mov       rcx,[rdx+30]
       mov       r8,rcx
       mov       rcx,offset MT_System.Collections.Generic.GenericComparer<System.String>
       cmp       [rdi],rcx
       mov       rdi,[rbp-0A0]
       jne       near ptr M00_L45
       test      r8,r8
       je        near ptr M00_L47
       test      rax,rax
       je        near ptr M00_L49
       mov       [rbp-0C8],r8
       mov       [rbp-0B8],rax
       cmp       r8,rax
       je        near ptr M00_L18
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],2
       jle       near ptr M00_L50
       mov       rcx,[rcx+240]
       mov       r10,[rcx+10]
       test      r10,r10
       je        near ptr M00_L50
M00_L21:
       mov       rcx,[r10+10]
       test      rcx,rcx
       jne       short M00_L22
       mov       rcx,17CCB800110
       mov       rcx,[rcx]
       test      rcx,rcx
       jne       short M00_L22
       mov       rcx,17CCB8000F0
       mov       rcx,[rcx]
       test      rcx,rcx
       je        near ptr M00_L51
M00_L22:
       mov       r10,[rcx]
       mov       r10,[r10+48]
       call      qword ptr [r10+30]
       cmp       [rax],al
       mov       r10,[rbp-0C8]
       lea       rdx,[r10+0C]
       mov       [rbp-0C8],r10
       mov       r8d,[r10+8]
       mov       r11,[rbp-0B8]
       lea       r9,[r11+0C]
       mov       [rbp-0B8],r11
       mov       ecx,[r11+8]
       cmp       r8d,ecx
       je        near ptr M00_L17
       mov       [rbp-0B0],r12
M00_L23:
       mov       [rbp-48],rdx
       mov       [rbp-50],r9
       mov       rax,[rax+20]
       mov       [rsp+20],ecx
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rax
       mov       rax,7FFEFF95B650
       mov       [rbp-80],rax
       lea       rax,[M00_L24]
       mov       [rbp-70],rax
       lea       rax,[rbp-90]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFF5F2F93A0
       call      rax
M00_L24:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFF5F64F778],0
       je        short M00_L25
       call      qword ptr [7FFF5F63D608]; CORINFO_HELP_STOP_FOR_GC
M00_L25:
       mov       rcx,[rbp-88]
       mov       [rsi+8],rcx
       xor       ecx,ecx
       mov       [rbp-48],rcx
       mov       [rbp-50],rcx
       mov       rdi,[rbp-0A0]
       mov       r15,[rbp-98]
M00_L26:
       mov       ecx,eax
       jmp       near ptr M00_L19
M00_L27:
       mov       ecx,[r15+0C]
       mov       [r15+8],ecx
M00_L28:
       mov       dword ptr [rbp-40],1
       jmp       near ptr M00_L56
M00_L29:
       mov       ecx,[r12+0C]
       mov       [r12+8],ecx
       jmp       near ptr M00_L55
M00_L30:
       mov       rcx,r12
       mov       r11,7FFEFF630DE8
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M00_L55
       jmp       near ptr M00_L03
M00_L31:
       call      qword ptr [7FFF00037690]
       int       3
M00_L32:
       mov       rcx,r12
       mov       r11,7FFEFF630DF0
       call      qword ptr [r11]
       mov       r12,rax
M00_L33:
       mov       [rbp-0B0],r12
       mov       rdx,r12
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       mov       r12,[rbp-0B0]
       jmp       near ptr M00_L04
M00_L34:
       mov       [rbp-0B8],rax
       mov       r15,[rbp-98]
M00_L35:
       mov       rcx,r15
       mov       r11,7FFEFF630E10
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M00_L28
       mov       rcx,r15
       mov       r11,7FFEFF630E18
       call      qword ptr [r11]
       mov       rsi,rax
       mov       rdx,rsi
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       mov       rcx,rdi
       mov       r8,[rbp-0B8]
       mov       [rbp-0D0],rax
       mov       rdx,rax
       mov       r11,7FFEFF630E20
       call      qword ptr [r11]
       test      eax,eax
       jg        short M00_L35
       mov       r12,[rbp-0D0]
       mov       [rbp-0B8],r12
       mov       r12,rsi
       mov       r15,[rbp-98]
       jmp       short M00_L35
M00_L36:
       mov       ecx,2
       call      qword ptr [7FFF00037708]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       rdx,rax
       jmp       near ptr M00_L10
M00_L37:
       call      qword ptr [7FFEFF965DA0]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rcx,rax
       jmp       near ptr M00_L11
M00_L38:
       xor       eax,eax
       mov       [rbp-0B0],r12
       jmp       near ptr M00_L15
M00_L39:
       mov       ecx,1
       mov       [rbp-0B8],rax
       jmp       near ptr M00_L08
M00_L40:
       test      rax,rax
       je        short M00_L41
       mov       ecx,0FFFFFFFF
       mov       [rbp-0B8],rax
       jmp       near ptr M00_L08
M00_L41:
       xor       ecx,ecx
       mov       [rbp-0B8],rax
       jmp       near ptr M00_L08
M00_L42:
       mov       [rbp-0B8],rax
       mov       rcx,r15
       mov       r11,7FFEFF630DF8
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M00_L28
       mov       rcx,r15
       mov       r11,7FFEFF630E00
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       short M00_L44
M00_L43:
       mov       [rbp-0B8],rax
M00_L44:
       mov       [rbp-0C0],rdx
       mov       r14,[rbp-0A8]
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       mov       [rbp-0C8],rax
       mov       rax,[rbp-0B8]
       mov       r15,[rbp-98]
       jmp       short M00_L46
M00_L45:
       mov       [rbp-0C8],r8
M00_L46:
       mov       rcx,rdi
       mov       [rbp-0B8],rax
       mov       r8,rax
       mov       rdx,[rbp-0C8]
       mov       r11,7FFEFF630E08
       call      qword ptr [r11]
       mov       ecx,eax
       mov       [rbp-0B0],r12
       jmp       near ptr M00_L19
M00_L47:
       mov       [rbp-0B8],rax
       test      rax,rax
       jne       short M00_L48
       mov       rax,[rbp-0B8]
       xor       ecx,ecx
       mov       [rbp-0C8],r8
       mov       [rbp-0B8],rax
       mov       [rbp-0B0],r12
       jmp       near ptr M00_L19
M00_L48:
       mov       rax,[rbp-0B8]
       mov       ecx,0FFFFFFFF
       mov       [rbp-0C8],r8
       mov       [rbp-0B8],rax
       mov       [rbp-0B0],r12
       jmp       near ptr M00_L19
M00_L49:
       mov       ecx,1
       mov       [rbp-0C8],r8
       mov       [rbp-0B8],rax
       mov       [rbp-0B0],r12
       jmp       near ptr M00_L19
M00_L50:
       mov       ecx,2
       call      qword ptr [7FFF00037708]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       r10,rax
       jmp       near ptr M00_L21
M00_L51:
       call      qword ptr [7FFEFF965DA0]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rcx,rax
       jmp       near ptr M00_L22
M00_L52:
       xor       eax,eax
       mov       [rbp-0B0],r12
       jmp       near ptr M00_L26
M00_L53:
       mov       ecx,[r15+8]
       call      qword ptr [7FFF00037690]
       int       3
M00_L54:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L55:
       xor       ecx,ecx
       mov       [rbp-40],ecx
       xor       r12d,r12d
       mov       r15,[rbp-98]
M00_L56:
       cmp       [r15],r13
       jne       near ptr M00_L64
M00_L57:
       cmp       byte ptr [rbp-40],0
       je        near ptr M00_L65
       mov       [rbp-58],r12
       mov       rbx,[rbp+10]
       mov       r15,[rbx+60]
       mov       rdx,[rbp-58]
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [r15+8],rax
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
M00_L58:
       mov       ecx,11
       call      qword ptr [7FFEFF967DF8]
       int       3
M00_L59:
       mov       r13,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,r13
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       dword ptr [r12+8],0FFFFFFFF
       mov       [r12+0C],r14d
       lea       rcx,[r12+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L02
M00_L60:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdx,17CF4800E58
       mov       rdx,[rdx]
       mov       rcx,r14
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonOrderByBenchmark>b__12_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFEFF6E6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,17CF4800E60
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L61:
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L01
M00_L62:
       mov       rcx,rdi
       mov       r11,7FFEFF630E30
       call      qword ptr [r11]
       mov       r12,rax
       jmp       near ptr M00_L02
M00_L63:
       mov       r11,7FFEFF630DE0
       call      qword ptr [r11]
       mov       r12,rax
       jmp       near ptr M00_L02
M00_L64:
       mov       rcx,r15
       mov       r11,7FFEFF630E28
       call      qword ptr [r11]
       jmp       near ptr M00_L57
M00_L65:
       call      qword ptr [7FFEFFE6FCF0]
       int       3
       sub       rsp,38
       vzeroupper
       cmp       qword ptr [rbp-98],0
       je        short M00_L66
       mov       r13,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       r15,[rbp-98]
       cmp       [r15],r13
       je        short M00_L66
       mov       rcx,r15
       mov       r11,7FFEFF630E28
       call      qword ptr [r11]
M00_L66:
       nop
       add       rsp,38
       ret
; Total bytes of code 2622
```
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonOrderByBenchmark>b__12_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       mov       rax,[rdx+30]
       ret
; Total bytes of code 5
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FFF51600D78]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       ecx,ebx
       and       ecx,0FFFFFF
       mov       edx,ecx
       mov       r8d,ebx
       sar       r8d,18
       jne       short M02_L01
       cmp       [rax],ecx
       jle       short M02_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M02_L03
M02_L00:
       add       rsp,20
       pop       rbx
       ret
M02_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M02_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M02_L00
M02_L02:
       cmp       [rax+4],edx
       jle       short M02_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M02_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M02_L03
       jmp       short M02_L00
M02_L03:
       mov       ecx,ebx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax]
; Total bytes of code 130
```
```assembly
; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       push      rsi
       push      rbx
       sub       rsp,28
       call      qword ptr [7FFF515E87D0]
       mov       rbx,rax
       mov       rsi,rbx
       call      qword ptr [7FFF515FFA88]
       mov       rdx,rax
       test      rsi,rsi
       je        short M03_L00
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFF51600C28]
       mov       rax,[rbx]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M03_L00:
       call      qword ptr [7FFF515FE468]
       int       3
; Total bytes of code 61
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M04_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L00:
       call      qword ptr [7FFF0003E538]
       int       3
; Total bytes of code 44
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M05_L00
       ret
M05_L00:
       jmp       qword ptr [7FFEFF6E5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.PersonOrderByBenchmark()
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
       xor       eax,eax
       mov       [rbp-58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp-40],rax
       mov       rbx,rcx
       lea       rcx,[rbp-90]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rcx,rsp
       mov       [rbp-78],rcx
       mov       rcx,rbp
       mov       [rbp-68],rcx
       mov       [rbp+10],rbx
       mov       rdi,[rbx+288]
       mov       rcx,1E076000E60
       mov       r14,[rcx]
       test      r14,r14
       je        near ptr M00_L60
M00_L00:
       mov       rcx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [r15+10],eax
       lea       rcx,[r15+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        near ptr M00_L58
       xor       ecx,ecx
       mov       [r15+20],rcx
       lea       rcx,[r15+28]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,1E049000A08
       mov       rdx,[rcx]
       lea       rcx,[r15+30]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [r15+48],0
       mov       rcx,[r15+18]
       mov       rax,offset MT_System.Collections.ObjectModel.Collection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rax
       jne       near ptr M00_L63
       mov       rdi,[rcx+8]
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rdi],rcx
       jne       near ptr M00_L62
       mov       r14d,[rdi+8]
       test      r14d,r14d
       jne       near ptr M00_L59
       mov       r13,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,r13
       test      byte ptr [7FFF0001D3E8],1
       je        near ptr M00_L61
M00_L01:
       mov       rcx,1E076000E98
       mov       r12,[rcx]
M00_L02:
       mov       [rbp-98],r12
       mov       r13,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r12],r13
       jne       near ptr M00_L30
       mov       ecx,[r12+8]
       inc       ecx
       cmp       ecx,[r12+0C]
       jae       near ptr M00_L29
       mov       [r12+8],ecx
M00_L03:
       mov       rdi,[r15+30]
       mov       [rbp-0A0],rdi
       mov       r14,[r15+28]
       mov       [rbp-0A8],r14
       cmp       [r12],r13
       jne       near ptr M00_L32
       mov       ecx,[r12+8]
       cmp       ecx,[r12+0C]
       jae       near ptr M00_L31
       mov       rax,[r12+10]
       cmp       ecx,[rax+8]
       jae       near ptr M00_L54
       mov       r12,[rax+rcx*8+10]
       mov       rcx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonOrderByBenchmark>b__12_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [r14+18],rcx
       jne       near ptr M00_L33
       mov       rax,[r12+30]
M00_L04:
       cmp       byte ptr [r15+48],0
       jne       near ptr M00_L34
       test      r14,r14
       je        near ptr M00_L23
       test      rdi,rdi
       je        near ptr M00_L23
       mov       r15,[rbp-98]
       cmp       [r15],r13
       jne       near ptr M00_L23
       mov       rcx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonOrderByBenchmark>b__12_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [r14+18],rcx
       jne       near ptr M00_L23
       mov       rcx,offset MT_System.Collections.Generic.GenericComparer<System.String>
       cmp       [rdi],rcx
       jne       near ptr M00_L23
       jmp       short M00_L09
M00_L05:
       mov       rdi,[rbp-0C0]
       mov       rax,r14
       mov       [rbp-0B0],rdi
       mov       r12,[rbp-0B0]
       jmp       short M00_L09
M00_L06:
       cmp       rdx,r9
       je        near ptr M00_L38
       mov       [rbp-0B0],r12
       jmp       near ptr M00_L12
M00_L07:
       xor       ecx,ecx
M00_L08:
       test      ecx,ecx
       mov       rax,[rbp-0B8]
       mov       r15,[rbp-98]
       jge       short M00_L05
M00_L09:
       mov       edx,[r15+8]
       inc       edx
       cmp       edx,[r15+0C]
       jae       near ptr M00_L27
       mov       [r15+8],edx
       mov       r8d,[r15+8]
       cmp       r8d,[r15+0C]
       jae       near ptr M00_L53
       mov       r14,[r15+10]
       cmp       r8d,[r14+8]
       jae       near ptr M00_L54
       mov       ecx,r8d
       mov       rdi,[r14+rcx*8+10]
       mov       [rbp-0C0],rdi
       mov       r14,[rdi+30]
       test      r14,r14
       je        near ptr M00_L40
       test      rax,rax
       je        near ptr M00_L39
       mov       [rbp-0B8],rax
       cmp       r14,rax
       je        short M00_L07
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],2
       jle       near ptr M00_L36
       mov       rcx,[rcx+240]
       mov       rdx,[rcx+10]
       test      rdx,rdx
       je        near ptr M00_L36
M00_L10:
       mov       rcx,[rdx+10]
       test      rcx,rcx
       jne       short M00_L11
       mov       rcx,1E049000110
       mov       rcx,[rcx]
       test      rcx,rcx
       jne       short M00_L11
       mov       rcx,1E0490000F0
       mov       rcx,[rcx]
       test      rcx,rcx
       je        near ptr M00_L37
M00_L11:
       mov       rdx,[rcx]
       mov       rdx,[rdx+48]
       call      qword ptr [rdx+30]
       cmp       [rax],al
       lea       rdx,[r14+0C]
       mov       [rbp-0C8],r14
       mov       r8d,[r14+8]
       mov       r10,[rbp-0B8]
       lea       r9,[r10+0C]
       mov       [rbp-0B8],r10
       mov       r11d,[r10+8]
       cmp       r8d,r11d
       je        near ptr M00_L06
       mov       [rbp-0B0],r12
M00_L12:
       mov       [rbp-48],rdx
       mov       [rbp-50],r9
       mov       rcx,[rax+20]
       mov       [rsp+20],r11d
       xor       eax,eax
       mov       [rsp+28],eax
       mov       rax,7FFEFF97B650
       mov       [rbp-80],rax
       lea       rax,[M00_L13]
       mov       [rbp-70],rax
       lea       rax,[rbp-90]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFF5F2F93A0
       call      rax
M00_L13:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFF5F64F778],0
       je        short M00_L14
       call      qword ptr [7FFF5F63D608]; CORINFO_HELP_STOP_FOR_GC
M00_L14:
       mov       rcx,[rbp-88]
       mov       [rsi+8],rcx
       xor       ecx,ecx
       mov       [rbp-48],rcx
       mov       [rbp-50],rcx
M00_L15:
       mov       ecx,eax
       mov       r12,[rbp-0B0]
       mov       r14,[rbp-0C8]
       jmp       near ptr M00_L08
M00_L16:
       mov       rdx,[rbp-0C0]
       mov       r10,[rbp-0C8]
       mov       r11,r10
       mov       r12,rdx
       mov       rax,r11
       jmp       near ptr M00_L23
M00_L17:
       mov       [rbp-0B0],r12
M00_L18:
       mov       [rbp-48],rdx
       mov       [rbp-50],r9
       mov       rax,[rax+20]
       mov       [rsp+20],ecx
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rax
       mov       rax,7FFEFF97B650
       mov       [rbp-80],rax
       lea       rax,[M00_L19]
       mov       [rbp-70],rax
       lea       rax,[rbp-90]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFF5F2F93A0
       call      rax
M00_L19:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFF5F64F778],0
       je        short M00_L20
       call      qword ptr [7FFF5F63D608]; CORINFO_HELP_STOP_FOR_GC
M00_L20:
       mov       rcx,[rbp-88]
       mov       [rsi+8],rcx
       xor       ecx,ecx
       mov       [rbp-48],rcx
       mov       [rbp-50],rcx
       mov       rdi,[rbp-0A0]
       mov       r15,[rbp-98]
M00_L21:
       mov       ecx,eax
M00_L22:
       test      ecx,ecx
       mov       rax,[rbp-0B8]
       mov       r12,[rbp-0B0]
       mov       r14,[rbp-0A8]
       jge       near ptr M00_L16
M00_L23:
       mov       r15,[rbp-98]
       cmp       [r15],r13
       jne       near ptr M00_L42
       mov       edx,[r15+8]
       inc       edx
       cmp       edx,[r15+0C]
       jae       near ptr M00_L27
       mov       [r15+8],edx
       mov       ecx,[r15+8]
       cmp       ecx,[r15+0C]
       jae       near ptr M00_L53
       mov       rcx,[r15+10]
       mov       r8d,[r15+8]
       cmp       r8d,[rcx+8]
       jae       near ptr M00_L54
       mov       edx,r8d
       mov       rcx,[rcx+rdx*8+10]
       mov       rdx,rcx
       mov       rcx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonOrderByBenchmark>b__12_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [r14+18],rcx
       jne       near ptr M00_L43
       mov       r15,[rbp-98]
       mov       [rbp-0C0],rdx
       mov       rcx,[rdx+30]
       mov       r8,rcx
       mov       rcx,offset MT_System.Collections.Generic.GenericComparer<System.String>
       cmp       [rdi],rcx
       mov       rdi,[rbp-0A0]
       jne       near ptr M00_L45
       test      r8,r8
       je        near ptr M00_L47
       test      rax,rax
       je        near ptr M00_L49
       mov       [rbp-0C8],r8
       mov       [rbp-0B8],rax
       cmp       r8,rax
       je        near ptr M00_L26
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],2
       jle       near ptr M00_L50
       mov       rcx,[rcx+240]
       mov       r10,[rcx+10]
       test      r10,r10
       je        near ptr M00_L50
M00_L24:
       mov       rcx,[r10+10]
       test      rcx,rcx
       jne       short M00_L25
       mov       rcx,1E049000110
       mov       rcx,[rcx]
       test      rcx,rcx
       jne       short M00_L25
       mov       rcx,1E0490000F0
       mov       rcx,[rcx]
       test      rcx,rcx
       je        near ptr M00_L51
M00_L25:
       mov       r10,[rcx]
       mov       r10,[r10+48]
       call      qword ptr [r10+30]
       cmp       [rax],al
       mov       r10,[rbp-0C8]
       lea       rdx,[r10+0C]
       mov       [rbp-0C8],r10
       mov       r8d,[r10+8]
       mov       r11,[rbp-0B8]
       lea       r9,[r11+0C]
       mov       [rbp-0B8],r11
       mov       ecx,[r11+8]
       cmp       r8d,ecx
       jne       near ptr M00_L17
       cmp       rdx,r9
       je        near ptr M00_L52
       mov       [rbp-0B0],r12
       jmp       near ptr M00_L18
M00_L26:
       xor       ecx,ecx
       mov       [rbp-0B0],r12
       jmp       near ptr M00_L22
M00_L27:
       mov       ecx,[r15+0C]
       mov       [r15+8],ecx
M00_L28:
       mov       dword ptr [rbp-40],1
       jmp       near ptr M00_L56
M00_L29:
       mov       ecx,[r12+0C]
       mov       [r12+8],ecx
       jmp       near ptr M00_L55
M00_L30:
       mov       rcx,r12
       mov       r11,7FFEFF650DE8
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M00_L55
       jmp       near ptr M00_L03
M00_L31:
       call      qword ptr [7FFF000574F8]
       int       3
M00_L32:
       mov       rcx,r12
       mov       r11,7FFEFF650DF0
       call      qword ptr [r11]
       mov       r12,rax
M00_L33:
       mov       [rbp-0B0],r12
       mov       rdx,r12
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       mov       r12,[rbp-0B0]
       jmp       near ptr M00_L04
M00_L34:
       mov       [rbp-0B8],rax
       mov       r15,[rbp-98]
M00_L35:
       mov       rcx,r15
       mov       r11,7FFEFF650E10
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M00_L28
       mov       rcx,r15
       mov       r11,7FFEFF650E18
       call      qword ptr [r11]
       mov       rsi,rax
       mov       rdx,rsi
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       mov       rcx,rdi
       mov       r8,[rbp-0B8]
       mov       [rbp-0D0],rax
       mov       rdx,rax
       mov       r11,7FFEFF650E20
       call      qword ptr [r11]
       test      eax,eax
       jg        short M00_L35
       mov       r12,[rbp-0D0]
       mov       [rbp-0B8],r12
       mov       r12,rsi
       mov       r15,[rbp-98]
       jmp       short M00_L35
M00_L36:
       mov       ecx,2
       call      qword ptr [7FFF00057660]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       rdx,rax
       jmp       near ptr M00_L10
M00_L37:
       call      qword ptr [7FFEFF985DA0]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rcx,rax
       jmp       near ptr M00_L11
M00_L38:
       xor       eax,eax
       mov       [rbp-0B0],r12
       jmp       near ptr M00_L15
M00_L39:
       mov       ecx,1
       mov       [rbp-0B8],rax
       jmp       near ptr M00_L08
M00_L40:
       test      rax,rax
       je        short M00_L41
       mov       ecx,0FFFFFFFF
       mov       [rbp-0B8],rax
       jmp       near ptr M00_L08
M00_L41:
       xor       ecx,ecx
       mov       [rbp-0B8],rax
       jmp       near ptr M00_L08
M00_L42:
       mov       [rbp-0B8],rax
       mov       rcx,r15
       mov       r11,7FFEFF650DF8
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M00_L28
       mov       rcx,r15
       mov       r11,7FFEFF650E00
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       short M00_L44
M00_L43:
       mov       [rbp-0B8],rax
M00_L44:
       mov       [rbp-0C0],rdx
       mov       r14,[rbp-0A8]
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       mov       [rbp-0C8],rax
       mov       rax,[rbp-0B8]
       mov       r15,[rbp-98]
       jmp       short M00_L46
M00_L45:
       mov       [rbp-0C8],r8
M00_L46:
       mov       rcx,rdi
       mov       [rbp-0B8],rax
       mov       r8,rax
       mov       rdx,[rbp-0C8]
       mov       r11,7FFEFF650E08
       call      qword ptr [r11]
       mov       ecx,eax
       mov       [rbp-0B0],r12
       jmp       near ptr M00_L22
M00_L47:
       mov       [rbp-0B8],rax
       test      rax,rax
       jne       short M00_L48
       mov       rax,[rbp-0B8]
       xor       ecx,ecx
       mov       [rbp-0C8],r8
       mov       [rbp-0B8],rax
       mov       [rbp-0B0],r12
       jmp       near ptr M00_L22
M00_L48:
       mov       rax,[rbp-0B8]
       mov       ecx,0FFFFFFFF
       mov       [rbp-0C8],r8
       mov       [rbp-0B8],rax
       mov       [rbp-0B0],r12
       jmp       near ptr M00_L22
M00_L49:
       mov       ecx,1
       mov       [rbp-0C8],r8
       mov       [rbp-0B8],rax
       mov       [rbp-0B0],r12
       jmp       near ptr M00_L22
M00_L50:
       mov       ecx,2
       call      qword ptr [7FFF00057660]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       r10,rax
       jmp       near ptr M00_L24
M00_L51:
       call      qword ptr [7FFEFF985DA0]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rcx,rax
       jmp       near ptr M00_L25
M00_L52:
       xor       eax,eax
       mov       [rbp-0B0],r12
       jmp       near ptr M00_L21
M00_L53:
       mov       ecx,[r15+8]
       call      qword ptr [7FFF000574F8]
       int       3
M00_L54:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L55:
       xor       ecx,ecx
       mov       [rbp-40],ecx
       xor       r12d,r12d
       mov       r15,[rbp-98]
M00_L56:
       cmp       [r15],r13
       jne       near ptr M00_L64
M00_L57:
       cmp       byte ptr [rbp-40],0
       je        near ptr M00_L65
       mov       [rbp-58],r12
       mov       rbx,[rbp+10]
       mov       r15,[rbx+60]
       mov       rdx,[rbp-58]
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [r15+8],rax
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
M00_L58:
       mov       ecx,11
       call      qword ptr [7FFEFF987DF8]
       int       3
M00_L59:
       mov       r13,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,r13
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       dword ptr [r12+8],0FFFFFFFF
       mov       [r12+0C],r14d
       lea       rcx,[r12+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L02
M00_L60:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdx,1E076000E58
       mov       rdx,[rdx]
       mov       rcx,r14
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonOrderByBenchmark>b__12_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFEFF706BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1E076000E60
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L61:
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L01
M00_L62:
       mov       rcx,rdi
       mov       r11,7FFEFF650E30
       call      qword ptr [r11]
       mov       r12,rax
       jmp       near ptr M00_L02
M00_L63:
       mov       r11,7FFEFF650DE0
       call      qword ptr [r11]
       mov       r12,rax
       jmp       near ptr M00_L02
M00_L64:
       mov       rcx,r15
       mov       r11,7FFEFF650E28
       call      qword ptr [r11]
       jmp       near ptr M00_L57
M00_L65:
       call      qword ptr [7FFEFFE8FD20]
       int       3
       sub       rsp,38
       vzeroupper
       cmp       qword ptr [rbp-98],0
       je        short M00_L66
       mov       r13,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       r15,[rbp-98]
       cmp       [r15],r13
       je        short M00_L66
       mov       rcx,r15
       mov       r11,7FFEFF650E28
       call      qword ptr [r11]
M00_L66:
       nop
       add       rsp,38
       ret
; Total bytes of code 2629
```
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonOrderByBenchmark>b__12_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       mov       rax,[rdx+30]
       ret
; Total bytes of code 5
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FFF51600D78]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       ecx,ebx
       and       ecx,0FFFFFF
       mov       edx,ecx
       mov       r8d,ebx
       sar       r8d,18
       jne       short M02_L01
       cmp       [rax],ecx
       jle       short M02_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M02_L03
M02_L00:
       add       rsp,20
       pop       rbx
       ret
M02_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M02_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M02_L00
M02_L02:
       cmp       [rax+4],edx
       jle       short M02_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M02_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M02_L03
       jmp       short M02_L00
M02_L03:
       mov       ecx,ebx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax]
; Total bytes of code 130
```
```assembly
; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       push      rsi
       push      rbx
       sub       rsp,28
       call      qword ptr [7FFF515E87D0]
       mov       rbx,rax
       mov       rsi,rbx
       call      qword ptr [7FFF515FFA88]
       mov       rdx,rax
       test      rsi,rsi
       je        short M03_L00
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFF51600C28]
       mov       rax,[rbx]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M03_L00:
       call      qword ptr [7FFF515FE468]
       int       3
; Total bytes of code 61
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M04_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L00:
       call      qword ptr [7FFF0005E478]
       int       3
; Total bytes of code 44
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M05_L00
       ret
M05_L00:
       jmp       qword ptr [7FFEFF705C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.PersonOrderByBenchmark()
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
       xor       eax,eax
       mov       [rbp-58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp-40],rax
       mov       rbx,rcx
       lea       rcx,[rbp-90]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rcx,rsp
       mov       [rbp-78],rcx
       mov       rcx,rbp
       mov       [rbp-68],rcx
       mov       [rbp+10],rbx
       mov       rdi,[rbx+288]
       mov       rcx,18CE1800E60
       mov       r14,[rcx]
       test      r14,r14
       je        near ptr M00_L60
M00_L00:
       mov       rcx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [r15+10],eax
       lea       rcx,[r15+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        near ptr M00_L58
       xor       ecx,ecx
       mov       [r15+20],rcx
       lea       rcx,[r15+28]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,18CB4800A08
       mov       rdx,[rcx]
       lea       rcx,[r15+30]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [r15+48],0
       mov       rcx,[r15+18]
       mov       rax,offset MT_System.Collections.ObjectModel.Collection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rax
       jne       near ptr M00_L63
       mov       rdi,[rcx+8]
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rdi],rcx
       jne       near ptr M00_L62
       mov       r14d,[rdi+8]
       test      r14d,r14d
       jne       near ptr M00_L59
       mov       r13,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,r13
       test      byte ptr [7FFF00061AE8],1
       je        near ptr M00_L61
M00_L01:
       mov       rcx,18CE1800FB0
       mov       r12,[rcx]
M00_L02:
       mov       [rbp-98],r12
       mov       r13,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r12],r13
       jne       near ptr M00_L30
       mov       ecx,[r12+8]
       inc       ecx
       cmp       ecx,[r12+0C]
       jae       near ptr M00_L29
       mov       [r12+8],ecx
M00_L03:
       mov       rdi,[r15+30]
       mov       [rbp-0A0],rdi
       mov       r14,[r15+28]
       mov       [rbp-0A8],r14
       cmp       [r12],r13
       jne       near ptr M00_L32
       mov       ecx,[r12+8]
       cmp       ecx,[r12+0C]
       jae       near ptr M00_L31
       mov       rax,[r12+10]
       cmp       ecx,[rax+8]
       jae       near ptr M00_L54
       mov       r12,[rax+rcx*8+10]
       mov       rcx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonOrderByBenchmark>b__12_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [r14+18],rcx
       jne       near ptr M00_L33
       mov       rax,[r12+30]
M00_L04:
       cmp       byte ptr [r15+48],0
       jne       near ptr M00_L34
       test      r14,r14
       je        near ptr M00_L20
       test      rdi,rdi
       je        near ptr M00_L20
       mov       r15,[rbp-98]
       cmp       [r15],r13
       jne       near ptr M00_L20
       mov       rcx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonOrderByBenchmark>b__12_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [r14+18],rcx
       jne       near ptr M00_L20
       mov       rcx,offset MT_System.Collections.Generic.GenericComparer<System.String>
       cmp       [rdi],rcx
       jne       near ptr M00_L20
       jmp       short M00_L09
M00_L05:
       mov       rdi,[rbp-0C0]
       mov       rax,r14
       mov       [rbp-0B0],rdi
       mov       r12,[rbp-0B0]
       jmp       short M00_L09
M00_L06:
       cmp       rdx,r9
       je        near ptr M00_L38
       mov       [rbp-0B0],r12
       jmp       near ptr M00_L12
M00_L07:
       xor       ecx,ecx
M00_L08:
       test      ecx,ecx
       mov       rax,[rbp-0B8]
       mov       r15,[rbp-98]
       jge       short M00_L05
M00_L09:
       mov       edx,[r15+8]
       inc       edx
       cmp       edx,[r15+0C]
       jae       near ptr M00_L27
       mov       [r15+8],edx
       mov       r8d,[r15+8]
       cmp       r8d,[r15+0C]
       jae       near ptr M00_L53
       mov       r14,[r15+10]
       cmp       r8d,[r14+8]
       jae       near ptr M00_L54
       mov       ecx,r8d
       mov       rdi,[r14+rcx*8+10]
       mov       [rbp-0C0],rdi
       mov       r14,[rdi+30]
       test      r14,r14
       je        near ptr M00_L40
       test      rax,rax
       je        near ptr M00_L39
       mov       [rbp-0B8],rax
       cmp       r14,rax
       je        short M00_L07
       mov       rcx,gs:[58]
       mov       rcx,[rcx+38]
       cmp       dword ptr [rcx+238],2
       jle       near ptr M00_L36
       mov       rcx,[rcx+240]
       mov       rdx,[rcx+10]
       test      rdx,rdx
       je        near ptr M00_L36
M00_L10:
       mov       rcx,[rdx+10]
       test      rcx,rcx
       jne       short M00_L11
       mov       rcx,18CB4800110
       mov       rcx,[rcx]
       test      rcx,rcx
       jne       short M00_L11
       mov       rcx,18CB48000F0
       mov       rcx,[rcx]
       test      rcx,rcx
       je        near ptr M00_L37
M00_L11:
       mov       rdx,[rcx]
       mov       rdx,[rdx+48]
       call      qword ptr [rdx+30]
       cmp       [rax],al
       lea       rdx,[r14+0C]
       mov       [rbp-0C8],r14
       mov       r8d,[r14+8]
       mov       r10,[rbp-0B8]
       lea       r9,[r10+0C]
       mov       [rbp-0B8],r10
       mov       r11d,[r10+8]
       cmp       r8d,r11d
       je        near ptr M00_L06
       mov       [rbp-0B0],r12
M00_L12:
       mov       [rbp-48],rdx
       mov       [rbp-50],r9
       mov       rcx,[rax+20]
       mov       [rsp+20],r11d
       xor       eax,eax
       mov       [rsp+28],eax
       mov       rax,7FFEFF98B650
       mov       [rbp-80],rax
       lea       rax,[M00_L13]
       mov       [rbp-70],rax
       lea       rax,[rbp-90]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFF5F2F93A0
       call      rax
M00_L13:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFF5F64F778],0
       je        short M00_L14
       call      qword ptr [7FFF5F63D608]; CORINFO_HELP_STOP_FOR_GC
M00_L14:
       mov       rcx,[rbp-88]
       mov       [rsi+8],rcx
       xor       ecx,ecx
       mov       [rbp-48],rcx
       mov       [rbp-50],rcx
M00_L15:
       mov       ecx,eax
       mov       r12,[rbp-0B0]
       mov       r14,[rbp-0C8]
       jmp       near ptr M00_L08
M00_L16:
       mov       rdx,[rbp-0C0]
       mov       r10,[rbp-0C8]
       mov       r11,r10
       mov       r12,rdx
       mov       rax,r11
       jmp       short M00_L20
M00_L17:
       cmp       rdx,r9
       je        near ptr M00_L52
       mov       [rbp-0B0],r12
       jmp       near ptr M00_L23
M00_L18:
       xor       ecx,ecx
       mov       [rbp-0B0],r12
M00_L19:
       test      ecx,ecx
       mov       rax,[rbp-0B8]
       mov       r12,[rbp-0B0]
       mov       r14,[rbp-0A8]
       jge       short M00_L16
M00_L20:
       mov       r15,[rbp-98]
       cmp       [r15],r13
       jne       near ptr M00_L42
       mov       edx,[r15+8]
       inc       edx
       cmp       edx,[r15+0C]
       jae       near ptr M00_L27
       mov       [r15+8],edx
       mov       ecx,[r15+8]
       cmp       ecx,[r15+0C]
       jae       near ptr M00_L53
       mov       rcx,[r15+10]
       mov       r8d,[r15+8]
       cmp       r8d,[rcx+8]
       jae       near ptr M00_L54
       mov       edx,r8d
       mov       rcx,[rcx+rdx*8+10]
       mov       rdx,rcx
       mov       rcx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonOrderByBenchmark>b__12_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [r14+18],rcx
       jne       near ptr M00_L43
       mov       r15,[rbp-98]
       mov       [rbp-0C0],rdx
       mov       rcx,[rdx+30]
       mov       r8,rcx
       mov       rcx,offset MT_System.Collections.Generic.GenericComparer<System.String>
       cmp       [rdi],rcx
       mov       rdi,[rbp-0A0]
       jne       near ptr M00_L45
       test      r8,r8
       je        near ptr M00_L47
       test      rax,rax
       je        near ptr M00_L49
       mov       [rbp-0C8],r8
       mov       [rbp-0B8],rax
       cmp       r8,rax
       je        near ptr M00_L18
       mov       rcx,gs:[58]
       mov       rcx,[rcx+38]
       cmp       dword ptr [rcx+238],2
       jle       near ptr M00_L50
       mov       rcx,[rcx+240]
       mov       r10,[rcx+10]
       test      r10,r10
       je        near ptr M00_L50
M00_L21:
       mov       rcx,[r10+10]
       test      rcx,rcx
       jne       short M00_L22
       mov       rcx,18CB4800110
       mov       rcx,[rcx]
       test      rcx,rcx
       jne       short M00_L22
       mov       rcx,18CB48000F0
       mov       rcx,[rcx]
       test      rcx,rcx
       je        near ptr M00_L51
M00_L22:
       mov       r10,[rcx]
       mov       r10,[r10+48]
       call      qword ptr [r10+30]
       cmp       [rax],al
       mov       r10,[rbp-0C8]
       lea       rdx,[r10+0C]
       mov       [rbp-0C8],r10
       mov       r8d,[r10+8]
       mov       r11,[rbp-0B8]
       lea       r9,[r11+0C]
       mov       [rbp-0B8],r11
       mov       ecx,[r11+8]
       cmp       r8d,ecx
       je        near ptr M00_L17
       mov       [rbp-0B0],r12
M00_L23:
       mov       [rbp-48],rdx
       mov       [rbp-50],r9
       mov       rax,[rax+20]
       mov       [rsp+20],ecx
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rax
       mov       rax,7FFEFF98B650
       mov       [rbp-80],rax
       lea       rax,[M00_L24]
       mov       [rbp-70],rax
       lea       rax,[rbp-90]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFF5F2F93A0
       call      rax
M00_L24:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFF5F64F778],0
       je        short M00_L25
       call      qword ptr [7FFF5F63D608]; CORINFO_HELP_STOP_FOR_GC
M00_L25:
       mov       rcx,[rbp-88]
       mov       [rsi+8],rcx
       xor       ecx,ecx
       mov       [rbp-48],rcx
       mov       [rbp-50],rcx
       mov       rdi,[rbp-0A0]
       mov       r15,[rbp-98]
M00_L26:
       mov       ecx,eax
       jmp       near ptr M00_L19
M00_L27:
       mov       ecx,[r15+0C]
       mov       [r15+8],ecx
M00_L28:
       mov       dword ptr [rbp-40],1
       jmp       near ptr M00_L56
M00_L29:
       mov       ecx,[r12+0C]
       mov       [r12+8],ecx
       jmp       near ptr M00_L55
M00_L30:
       mov       rcx,r12
       mov       r11,7FFEFF661028
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M00_L55
       jmp       near ptr M00_L03
M00_L31:
       call      qword ptr [7FFF0005CE88]
       int       3
M00_L32:
       mov       rcx,r12
       mov       r11,7FFEFF661030
       call      qword ptr [r11]
       mov       r12,rax
M00_L33:
       mov       [rbp-0B0],r12
       mov       rdx,r12
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       mov       r12,[rbp-0B0]
       jmp       near ptr M00_L04
M00_L34:
       mov       [rbp-0B8],rax
       mov       r15,[rbp-98]
M00_L35:
       mov       rcx,r15
       mov       r11,7FFEFF661050
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M00_L28
       mov       rcx,r15
       mov       r11,7FFEFF661058
       call      qword ptr [r11]
       mov       rsi,rax
       mov       rdx,rsi
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       mov       rcx,rdi
       mov       r8,[rbp-0B8]
       mov       [rbp-0D0],rax
       mov       rdx,rax
       mov       r11,7FFEFF661060
       call      qword ptr [r11]
       test      eax,eax
       jg        short M00_L35
       mov       r12,[rbp-0D0]
       mov       [rbp-0B8],r12
       mov       r12,rsi
       mov       r15,[rbp-98]
       jmp       short M00_L35
M00_L36:
       mov       ecx,2
       call      qword ptr [7FFF0005E2F8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       rdx,rax
       jmp       near ptr M00_L10
M00_L37:
       call      qword ptr [7FFEFF995DA0]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rcx,rax
       jmp       near ptr M00_L11
M00_L38:
       xor       eax,eax
       mov       [rbp-0B0],r12
       jmp       near ptr M00_L15
M00_L39:
       mov       ecx,1
       mov       [rbp-0B8],rax
       jmp       near ptr M00_L08
M00_L40:
       test      rax,rax
       je        short M00_L41
       mov       ecx,0FFFFFFFF
       mov       [rbp-0B8],rax
       jmp       near ptr M00_L08
M00_L41:
       xor       ecx,ecx
       mov       [rbp-0B8],rax
       jmp       near ptr M00_L08
M00_L42:
       mov       [rbp-0B8],rax
       mov       rcx,r15
       mov       r11,7FFEFF661038
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M00_L28
       mov       rcx,r15
       mov       r11,7FFEFF661040
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       short M00_L44
M00_L43:
       mov       [rbp-0B8],rax
M00_L44:
       mov       [rbp-0C0],rdx
       mov       r14,[rbp-0A8]
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       mov       [rbp-0C8],rax
       mov       rax,[rbp-0B8]
       mov       r15,[rbp-98]
       jmp       short M00_L46
M00_L45:
       mov       [rbp-0C8],r8
M00_L46:
       mov       rcx,rdi
       mov       [rbp-0B8],rax
       mov       r8,rax
       mov       rdx,[rbp-0C8]
       mov       r11,7FFEFF661048
       call      qword ptr [r11]
       mov       ecx,eax
       mov       [rbp-0B0],r12
       jmp       near ptr M00_L19
M00_L47:
       mov       [rbp-0B8],rax
       test      rax,rax
       jne       short M00_L48
       mov       rax,[rbp-0B8]
       xor       ecx,ecx
       mov       [rbp-0C8],r8
       mov       [rbp-0B8],rax
       mov       [rbp-0B0],r12
       jmp       near ptr M00_L19
M00_L48:
       mov       rax,[rbp-0B8]
       mov       ecx,0FFFFFFFF
       mov       [rbp-0C8],r8
       mov       [rbp-0B8],rax
       mov       [rbp-0B0],r12
       jmp       near ptr M00_L19
M00_L49:
       mov       ecx,1
       mov       [rbp-0C8],r8
       mov       [rbp-0B8],rax
       mov       [rbp-0B0],r12
       jmp       near ptr M00_L19
M00_L50:
       mov       ecx,2
       call      qword ptr [7FFF0005E2F8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       r10,rax
       jmp       near ptr M00_L21
M00_L51:
       call      qword ptr [7FFEFF995DA0]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rcx,rax
       jmp       near ptr M00_L22
M00_L52:
       xor       eax,eax
       mov       [rbp-0B0],r12
       jmp       near ptr M00_L26
M00_L53:
       mov       ecx,[r15+8]
       call      qword ptr [7FFF0005CE88]
       int       3
M00_L54:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L55:
       xor       ecx,ecx
       mov       [rbp-40],ecx
       xor       r12d,r12d
       mov       r15,[rbp-98]
M00_L56:
       cmp       [r15],r13
       jne       near ptr M00_L64
M00_L57:
       cmp       byte ptr [rbp-40],0
       je        near ptr M00_L65
       mov       [rbp-58],r12
       mov       rbx,[rbp+10]
       mov       r15,[rbx+60]
       mov       rdx,[rbp-58]
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [r15+8],rax
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
M00_L58:
       mov       ecx,11
       call      qword ptr [7FFEFF997DF8]
       int       3
M00_L59:
       mov       r13,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,r13
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       dword ptr [r12+8],0FFFFFFFF
       mov       [r12+0C],r14d
       lea       rcx,[r12+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L02
M00_L60:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdx,18CE1800E58
       mov       rdx,[rdx]
       mov       rcx,r14
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonOrderByBenchmark>b__12_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFEFF716BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,18CE1800E60
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L61:
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L01
M00_L62:
       mov       rcx,rdi
       mov       r11,7FFEFF661070
       call      qword ptr [r11]
       mov       r12,rax
       jmp       near ptr M00_L02
M00_L63:
       mov       r11,7FFEFF661020
       call      qword ptr [r11]
       mov       r12,rax
       jmp       near ptr M00_L02
M00_L64:
       mov       rcx,r15
       mov       r11,7FFEFF661068
       call      qword ptr [r11]
       jmp       near ptr M00_L57
M00_L65:
       call      qword ptr [7FFEFFF06D60]
       int       3
       sub       rsp,38
       vzeroupper
       cmp       qword ptr [rbp-98],0
       je        short M00_L66
       mov       r13,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       r15,[rbp-98]
       cmp       [r15],r13
       je        short M00_L66
       mov       rcx,r15
       mov       r11,7FFEFF661068
       call      qword ptr [r11]
M00_L66:
       nop
       add       rsp,38
       ret
; Total bytes of code 2622
```
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonOrderByBenchmark>b__12_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       mov       rax,[rdx+30]
       ret
; Total bytes of code 5
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FFF51600D78]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       ecx,ebx
       and       ecx,0FFFFFF
       mov       edx,ecx
       mov       r8d,ebx
       sar       r8d,18
       jne       short M02_L01
       cmp       [rax],ecx
       jle       short M02_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M02_L03
M02_L00:
       add       rsp,20
       pop       rbx
       ret
M02_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M02_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M02_L00
M02_L02:
       cmp       [rax+4],edx
       jle       short M02_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M02_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M02_L03
       jmp       short M02_L00
M02_L03:
       mov       ecx,ebx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax]
; Total bytes of code 130
```
```assembly
; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       push      rsi
       push      rbx
       sub       rsp,28
       call      qword ptr [7FFF515E87D0]
       mov       rbx,rax
       mov       rsi,rbx
       call      qword ptr [7FFF515FFA88]
       mov       rdx,rax
       test      rsi,rsi
       je        short M03_L00
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFF51600C28]
       mov       rax,[rbx]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M03_L00:
       call      qword ptr [7FFF515FE468]
       int       3
; Total bytes of code 61
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M04_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L00:
       call      qword ptr [7FFF0005D9C8]
       int       3
; Total bytes of code 44
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M05_L00
       ret
M05_L00:
       jmp       qword ptr [7FFEFF715C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.PersonOrderByBenchmark()
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
       xor       eax,eax
       mov       [rbp-58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp-40],rax
       mov       rbx,rcx
       lea       rcx,[rbp-90]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rcx,rsp
       mov       [rbp-78],rcx
       mov       rcx,rbp
       mov       [rbp-68],rcx
       mov       [rbp+10],rbx
       mov       rdi,[rbx+288]
       mov       rcx,28BBC800E60
       mov       r14,[rcx]
       test      r14,r14
       je        near ptr M00_L60
M00_L00:
       mov       rcx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [r15+10],eax
       lea       rcx,[r15+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        near ptr M00_L58
       xor       ecx,ecx
       mov       [r15+20],rcx
       lea       rcx,[r15+28]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,28B8F800A08
       mov       rdx,[rcx]
       lea       rcx,[r15+30]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [r15+48],0
       mov       rcx,[r15+18]
       mov       rax,offset MT_System.Collections.ObjectModel.Collection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rax
       jne       near ptr M00_L63
       mov       rdi,[rcx+8]
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rdi],rcx
       jne       near ptr M00_L62
       mov       r14d,[rdi+8]
       test      r14d,r14d
       jne       near ptr M00_L59
       mov       r13,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,r13
       test      byte ptr [7FFF0000D3F8],1
       je        near ptr M00_L61
M00_L01:
       mov       rcx,28BBC800E98
       mov       r12,[rcx]
M00_L02:
       mov       [rbp-98],r12
       mov       r13,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r12],r13
       jne       near ptr M00_L30
       mov       ecx,[r12+8]
       inc       ecx
       cmp       ecx,[r12+0C]
       jae       near ptr M00_L29
       mov       [r12+8],ecx
M00_L03:
       mov       rdi,[r15+30]
       mov       [rbp-0A0],rdi
       mov       r14,[r15+28]
       mov       [rbp-0A8],r14
       cmp       [r12],r13
       jne       near ptr M00_L32
       mov       ecx,[r12+8]
       cmp       ecx,[r12+0C]
       jae       near ptr M00_L31
       mov       rax,[r12+10]
       cmp       ecx,[rax+8]
       jae       near ptr M00_L54
       mov       r12,[rax+rcx*8+10]
       mov       rcx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonOrderByBenchmark>b__12_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [r14+18],rcx
       jne       near ptr M00_L33
       mov       rax,[r12+30]
M00_L04:
       cmp       byte ptr [r15+48],0
       jne       near ptr M00_L34
       test      r14,r14
       je        near ptr M00_L20
       test      rdi,rdi
       je        near ptr M00_L20
       mov       r15,[rbp-98]
       cmp       [r15],r13
       jne       near ptr M00_L20
       mov       rcx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonOrderByBenchmark>b__12_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [r14+18],rcx
       jne       near ptr M00_L20
       mov       rcx,offset MT_System.Collections.Generic.GenericComparer<System.String>
       cmp       [rdi],rcx
       jne       near ptr M00_L20
       jmp       short M00_L09
M00_L05:
       mov       rdi,[rbp-0C0]
       mov       rax,r14
       mov       [rbp-0B0],rdi
       mov       r12,[rbp-0B0]
       jmp       short M00_L09
M00_L06:
       cmp       rdx,r9
       je        near ptr M00_L38
       mov       [rbp-0B0],r12
       jmp       near ptr M00_L12
M00_L07:
       xor       ecx,ecx
M00_L08:
       test      ecx,ecx
       mov       rax,[rbp-0B8]
       mov       r15,[rbp-98]
       jge       short M00_L05
M00_L09:
       mov       edx,[r15+8]
       inc       edx
       cmp       edx,[r15+0C]
       jae       near ptr M00_L27
       mov       [r15+8],edx
       mov       r8d,[r15+8]
       cmp       r8d,[r15+0C]
       jae       near ptr M00_L53
       mov       r14,[r15+10]
       cmp       r8d,[r14+8]
       jae       near ptr M00_L54
       mov       ecx,r8d
       mov       rdi,[r14+rcx*8+10]
       mov       [rbp-0C0],rdi
       mov       r14,[rdi+30]
       test      r14,r14
       je        near ptr M00_L40
       test      rax,rax
       je        near ptr M00_L39
       mov       [rbp-0B8],rax
       cmp       r14,rax
       je        short M00_L07
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],2
       jle       near ptr M00_L36
       mov       rcx,[rcx+240]
       mov       rdx,[rcx+10]
       test      rdx,rdx
       je        near ptr M00_L36
M00_L10:
       mov       rcx,[rdx+10]
       test      rcx,rcx
       jne       short M00_L11
       mov       rcx,28B8F800110
       mov       rcx,[rcx]
       test      rcx,rcx
       jne       short M00_L11
       mov       rcx,28B8F8000F0
       mov       rcx,[rcx]
       test      rcx,rcx
       je        near ptr M00_L37
M00_L11:
       mov       rdx,[rcx]
       mov       rdx,[rdx+48]
       call      qword ptr [rdx+30]
       cmp       [rax],al
       lea       rdx,[r14+0C]
       mov       [rbp-0C8],r14
       mov       r8d,[r14+8]
       mov       r10,[rbp-0B8]
       lea       r9,[r10+0C]
       mov       [rbp-0B8],r10
       mov       r11d,[r10+8]
       cmp       r8d,r11d
       je        near ptr M00_L06
       mov       [rbp-0B0],r12
M00_L12:
       mov       [rbp-48],rdx
       mov       [rbp-50],r9
       mov       rcx,[rax+20]
       mov       [rsp+20],r11d
       xor       eax,eax
       mov       [rsp+28],eax
       mov       rax,7FFEFF96B650
       mov       [rbp-80],rax
       lea       rax,[M00_L13]
       mov       [rbp-70],rax
       lea       rax,[rbp-90]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFF5F2F93A0
       call      rax
M00_L13:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFF5F64F778],0
       je        short M00_L14
       call      qword ptr [7FFF5F63D608]; CORINFO_HELP_STOP_FOR_GC
M00_L14:
       mov       rcx,[rbp-88]
       mov       [rsi+8],rcx
       xor       ecx,ecx
       mov       [rbp-48],rcx
       mov       [rbp-50],rcx
M00_L15:
       mov       ecx,eax
       mov       r12,[rbp-0B0]
       mov       r14,[rbp-0C8]
       jmp       near ptr M00_L08
M00_L16:
       mov       rdx,[rbp-0C0]
       mov       r10,[rbp-0C8]
       mov       r11,r10
       mov       r12,rdx
       mov       rax,r11
       jmp       short M00_L20
M00_L17:
       cmp       rdx,r9
       je        near ptr M00_L52
       mov       [rbp-0B0],r12
       jmp       near ptr M00_L23
M00_L18:
       xor       ecx,ecx
       mov       [rbp-0B0],r12
M00_L19:
       test      ecx,ecx
       mov       rax,[rbp-0B8]
       mov       r12,[rbp-0B0]
       mov       r14,[rbp-0A8]
       jge       short M00_L16
M00_L20:
       mov       r15,[rbp-98]
       cmp       [r15],r13
       jne       near ptr M00_L42
       mov       edx,[r15+8]
       inc       edx
       cmp       edx,[r15+0C]
       jae       near ptr M00_L27
       mov       [r15+8],edx
       mov       ecx,[r15+8]
       cmp       ecx,[r15+0C]
       jae       near ptr M00_L53
       mov       rcx,[r15+10]
       mov       r8d,[r15+8]
       cmp       r8d,[rcx+8]
       jae       near ptr M00_L54
       mov       edx,r8d
       mov       rcx,[rcx+rdx*8+10]
       mov       rdx,rcx
       mov       rcx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonOrderByBenchmark>b__12_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [r14+18],rcx
       jne       near ptr M00_L43
       mov       r15,[rbp-98]
       mov       [rbp-0C0],rdx
       mov       rcx,[rdx+30]
       mov       r8,rcx
       mov       rcx,offset MT_System.Collections.Generic.GenericComparer<System.String>
       cmp       [rdi],rcx
       mov       rdi,[rbp-0A0]
       jne       near ptr M00_L45
       test      r8,r8
       je        near ptr M00_L47
       test      rax,rax
       je        near ptr M00_L49
       mov       [rbp-0C8],r8
       mov       [rbp-0B8],rax
       cmp       r8,rax
       je        near ptr M00_L18
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],2
       jle       near ptr M00_L50
       mov       rcx,[rcx+240]
       mov       r10,[rcx+10]
       test      r10,r10
       je        near ptr M00_L50
M00_L21:
       mov       rcx,[r10+10]
       test      rcx,rcx
       jne       short M00_L22
       mov       rcx,28B8F800110
       mov       rcx,[rcx]
       test      rcx,rcx
       jne       short M00_L22
       mov       rcx,28B8F8000F0
       mov       rcx,[rcx]
       test      rcx,rcx
       je        near ptr M00_L51
M00_L22:
       mov       r10,[rcx]
       mov       r10,[r10+48]
       call      qword ptr [r10+30]
       cmp       [rax],al
       mov       r10,[rbp-0C8]
       lea       rdx,[r10+0C]
       mov       [rbp-0C8],r10
       mov       r8d,[r10+8]
       mov       r11,[rbp-0B8]
       lea       r9,[r11+0C]
       mov       [rbp-0B8],r11
       mov       ecx,[r11+8]
       cmp       r8d,ecx
       je        near ptr M00_L17
       mov       [rbp-0B0],r12
M00_L23:
       mov       [rbp-48],rdx
       mov       [rbp-50],r9
       mov       rax,[rax+20]
       mov       [rsp+20],ecx
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rax
       mov       rax,7FFEFF96B650
       mov       [rbp-80],rax
       lea       rax,[M00_L24]
       mov       [rbp-70],rax
       lea       rax,[rbp-90]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFF5F2F93A0
       call      rax
M00_L24:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFF5F64F778],0
       je        short M00_L25
       call      qword ptr [7FFF5F63D608]; CORINFO_HELP_STOP_FOR_GC
M00_L25:
       mov       rcx,[rbp-88]
       mov       [rsi+8],rcx
       xor       ecx,ecx
       mov       [rbp-48],rcx
       mov       [rbp-50],rcx
       mov       rdi,[rbp-0A0]
       mov       r15,[rbp-98]
M00_L26:
       mov       ecx,eax
       jmp       near ptr M00_L19
M00_L27:
       mov       ecx,[r15+0C]
       mov       [r15+8],ecx
M00_L28:
       mov       dword ptr [rbp-40],1
       jmp       near ptr M00_L56
M00_L29:
       mov       ecx,[r12+0C]
       mov       [r12+8],ecx
       jmp       near ptr M00_L55
M00_L30:
       mov       rcx,r12
       mov       r11,7FFEFF640DE8
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M00_L55
       jmp       near ptr M00_L03
M00_L31:
       call      qword ptr [7FFF00047510]
       int       3
M00_L32:
       mov       rcx,r12
       mov       r11,7FFEFF640DF0
       call      qword ptr [r11]
       mov       r12,rax
M00_L33:
       mov       [rbp-0B0],r12
       mov       rdx,r12
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       mov       r12,[rbp-0B0]
       jmp       near ptr M00_L04
M00_L34:
       mov       [rbp-0B8],rax
       mov       r15,[rbp-98]
M00_L35:
       mov       rcx,r15
       mov       r11,7FFEFF640E10
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M00_L28
       mov       rcx,r15
       mov       r11,7FFEFF640E18
       call      qword ptr [r11]
       mov       rsi,rax
       mov       rdx,rsi
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       mov       rcx,rdi
       mov       r8,[rbp-0B8]
       mov       [rbp-0D0],rax
       mov       rdx,rax
       mov       r11,7FFEFF640E20
       call      qword ptr [r11]
       test      eax,eax
       jg        short M00_L35
       mov       r12,[rbp-0D0]
       mov       [rbp-0B8],r12
       mov       r12,rsi
       mov       r15,[rbp-98]
       jmp       short M00_L35
M00_L36:
       mov       ecx,2
       call      qword ptr [7FFF00047678]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       rdx,rax
       jmp       near ptr M00_L10
M00_L37:
       call      qword ptr [7FFEFF975DA0]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rcx,rax
       jmp       near ptr M00_L11
M00_L38:
       xor       eax,eax
       mov       [rbp-0B0],r12
       jmp       near ptr M00_L15
M00_L39:
       mov       ecx,1
       mov       [rbp-0B8],rax
       jmp       near ptr M00_L08
M00_L40:
       test      rax,rax
       je        short M00_L41
       mov       ecx,0FFFFFFFF
       mov       [rbp-0B8],rax
       jmp       near ptr M00_L08
M00_L41:
       xor       ecx,ecx
       mov       [rbp-0B8],rax
       jmp       near ptr M00_L08
M00_L42:
       mov       [rbp-0B8],rax
       mov       rcx,r15
       mov       r11,7FFEFF640DF8
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M00_L28
       mov       rcx,r15
       mov       r11,7FFEFF640E00
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       short M00_L44
M00_L43:
       mov       [rbp-0B8],rax
M00_L44:
       mov       [rbp-0C0],rdx
       mov       r14,[rbp-0A8]
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       mov       [rbp-0C8],rax
       mov       rax,[rbp-0B8]
       mov       r15,[rbp-98]
       jmp       short M00_L46
M00_L45:
       mov       [rbp-0C8],r8
M00_L46:
       mov       rcx,rdi
       mov       [rbp-0B8],rax
       mov       r8,rax
       mov       rdx,[rbp-0C8]
       mov       r11,7FFEFF640E08
       call      qword ptr [r11]
       mov       ecx,eax
       mov       [rbp-0B0],r12
       jmp       near ptr M00_L19
M00_L47:
       mov       [rbp-0B8],rax
       test      rax,rax
       jne       short M00_L48
       mov       rax,[rbp-0B8]
       xor       ecx,ecx
       mov       [rbp-0C8],r8
       mov       [rbp-0B8],rax
       mov       [rbp-0B0],r12
       jmp       near ptr M00_L19
M00_L48:
       mov       rax,[rbp-0B8]
       mov       ecx,0FFFFFFFF
       mov       [rbp-0C8],r8
       mov       [rbp-0B8],rax
       mov       [rbp-0B0],r12
       jmp       near ptr M00_L19
M00_L49:
       mov       ecx,1
       mov       [rbp-0C8],r8
       mov       [rbp-0B8],rax
       mov       [rbp-0B0],r12
       jmp       near ptr M00_L19
M00_L50:
       mov       ecx,2
       call      qword ptr [7FFF00047678]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       r10,rax
       jmp       near ptr M00_L21
M00_L51:
       call      qword ptr [7FFEFF975DA0]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rcx,rax
       jmp       near ptr M00_L22
M00_L52:
       xor       eax,eax
       mov       [rbp-0B0],r12
       jmp       near ptr M00_L26
M00_L53:
       mov       ecx,[r15+8]
       call      qword ptr [7FFF00047510]
       int       3
M00_L54:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L55:
       xor       ecx,ecx
       mov       [rbp-40],ecx
       xor       r12d,r12d
       mov       r15,[rbp-98]
M00_L56:
       cmp       [r15],r13
       jne       near ptr M00_L64
M00_L57:
       cmp       byte ptr [rbp-40],0
       je        near ptr M00_L65
       mov       [rbp-58],r12
       mov       rbx,[rbp+10]
       mov       r15,[rbx+60]
       mov       rdx,[rbp-58]
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [r15+8],rax
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
M00_L58:
       mov       ecx,11
       call      qword ptr [7FFEFF977DF8]
       int       3
M00_L59:
       mov       r13,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,r13
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       dword ptr [r12+8],0FFFFFFFF
       mov       [r12+0C],r14d
       lea       rcx,[r12+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L02
M00_L60:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdx,28BBC800E58
       mov       rdx,[rdx]
       mov       rcx,r14
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonOrderByBenchmark>b__12_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFEFF6F6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,28BBC800E60
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L61:
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L01
M00_L62:
       mov       rcx,rdi
       mov       r11,7FFEFF640E30
       call      qword ptr [r11]
       mov       r12,rax
       jmp       near ptr M00_L02
M00_L63:
       mov       r11,7FFEFF640DE0
       call      qword ptr [r11]
       mov       r12,rax
       jmp       near ptr M00_L02
M00_L64:
       mov       rcx,r15
       mov       r11,7FFEFF640E28
       call      qword ptr [r11]
       jmp       near ptr M00_L57
M00_L65:
       call      qword ptr [7FFEFFE7FD08]
       int       3
       sub       rsp,38
       vzeroupper
       cmp       qword ptr [rbp-98],0
       je        short M00_L66
       mov       r13,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       r15,[rbp-98]
       cmp       [r15],r13
       je        short M00_L66
       mov       rcx,r15
       mov       r11,7FFEFF640E28
       call      qword ptr [r11]
M00_L66:
       nop
       add       rsp,38
       ret
; Total bytes of code 2622
```
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonOrderByBenchmark>b__12_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       mov       rax,[rdx+30]
       ret
; Total bytes of code 5
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FFF51600D78]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       ecx,ebx
       and       ecx,0FFFFFF
       mov       edx,ecx
       mov       r8d,ebx
       sar       r8d,18
       jne       short M02_L01
       cmp       [rax],ecx
       jle       short M02_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M02_L03
M02_L00:
       add       rsp,20
       pop       rbx
       ret
M02_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M02_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M02_L00
M02_L02:
       cmp       [rax+4],edx
       jle       short M02_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M02_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M02_L03
       jmp       short M02_L00
M02_L03:
       mov       ecx,ebx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax]
; Total bytes of code 130
```
```assembly
; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       push      rsi
       push      rbx
       sub       rsp,28
       call      qword ptr [7FFF515E87D0]
       mov       rbx,rax
       mov       rsi,rbx
       call      qword ptr [7FFF515FFA88]
       mov       rdx,rax
       test      rsi,rsi
       je        short M03_L00
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFF51600C28]
       mov       rax,[rbx]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M03_L00:
       call      qword ptr [7FFF515FE468]
       int       3
; Total bytes of code 61
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M04_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L00:
       call      qword ptr [7FFF0004E5E0]
       int       3
; Total bytes of code 44
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M05_L00
       ret
M05_L00:
       jmp       qword ptr [7FFEFF6F5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.PersonOrderByBenchmark()
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
       xor       eax,eax
       mov       [rbp-58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp-40],rax
       mov       rbx,rcx
       lea       rcx,[rbp-90]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rcx,rsp
       mov       [rbp-78],rcx
       mov       rcx,rbp
       mov       [rbp-68],rcx
       mov       [rbp+10],rbx
       mov       rdi,[rbx+288]
       mov       rcx,1FDA6C00E60
       mov       r14,[rcx]
       test      r14,r14
       je        near ptr M00_L66
M00_L00:
       mov       rcx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [r15+10],eax
       lea       rcx,[r15+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        near ptr M00_L64
       xor       ecx,ecx
       mov       [r15+20],rcx
       lea       rcx,[r15+28]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,1FD7DC00A08
       mov       rdx,[rcx]
       lea       rcx,[r15+30]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [r15+48],0
       mov       rcx,[r15+18]
       mov       rax,offset MT_System.Collections.ObjectModel.Collection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rax
       jne       near ptr M00_L69
       mov       rdi,[rcx+8]
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rdi],rcx
       jne       near ptr M00_L68
       mov       r14d,[rdi+8]
       test      r14d,r14d
       jne       near ptr M00_L65
       mov       r13,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,r13
       test      byte ptr [7FFF00009608],1
       je        near ptr M00_L67
M00_L01:
       mov       rcx,1FDA6C00E98
       mov       r12,[rcx]
M00_L02:
       mov       [rbp-98],r12
       mov       r13,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r12],r13
       jne       near ptr M00_L36
       mov       ecx,[r12+8]
       inc       ecx
       cmp       ecx,[r12+0C]
       jae       near ptr M00_L35
       mov       [r12+8],ecx
M00_L03:
       mov       rdi,[r15+30]
       mov       [rbp-0A0],rdi
       mov       r14,[r15+28]
       mov       [rbp-0A8],r14
       cmp       [r12],r13
       jne       near ptr M00_L38
       mov       ecx,[r12+8]
       cmp       ecx,[r12+0C]
       jae       near ptr M00_L37
       mov       rax,[r12+10]
       cmp       ecx,[rax+8]
       jae       near ptr M00_L60
       mov       r12,[rax+rcx*8+10]
       mov       rcx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonOrderByBenchmark>b__12_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [r14+18],rcx
       jne       near ptr M00_L39
       mov       rax,[r12+30]
M00_L04:
       cmp       byte ptr [r15+48],0
       jne       near ptr M00_L29
       test      r14,r14
       je        near ptr M00_L20
       test      rdi,rdi
       je        near ptr M00_L20
       mov       r15,[rbp-98]
       cmp       [r15],r13
       jne       near ptr M00_L20
       mov       rcx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonOrderByBenchmark>b__12_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [r14+18],rcx
       jne       near ptr M00_L20
       mov       rcx,offset MT_System.Collections.Generic.GenericComparer<System.String>
       cmp       [rdi],rcx
       jne       near ptr M00_L20
       jmp       short M00_L09
M00_L05:
       mov       rdi,[rbp-0C0]
       mov       rax,r14
       mov       [rbp-0B0],rdi
       mov       r12,[rbp-0B0]
       jmp       short M00_L09
M00_L06:
       cmp       rdx,r9
       je        near ptr M00_L44
       mov       [rbp-0B0],r12
       jmp       near ptr M00_L12
M00_L07:
       xor       ecx,ecx
M00_L08:
       test      ecx,ecx
       mov       rax,[rbp-0B8]
       mov       r15,[rbp-98]
       jge       short M00_L05
M00_L09:
       mov       edx,[r15+8]
       inc       edx
       cmp       edx,[r15+0C]
       jae       near ptr M00_L27
       mov       [r15+8],edx
       mov       r8d,[r15+8]
       cmp       r8d,[r15+0C]
       jae       near ptr M00_L59
       mov       r14,[r15+10]
       cmp       r8d,[r14+8]
       jae       near ptr M00_L60
       mov       ecx,r8d
       mov       rdi,[r14+rcx*8+10]
       mov       [rbp-0C0],rdi
       mov       r14,[rdi+30]
       test      r14,r14
       je        near ptr M00_L46
       test      rax,rax
       je        near ptr M00_L45
       mov       [rbp-0B8],rax
       cmp       r14,rax
       je        short M00_L07
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],2
       jle       near ptr M00_L42
       mov       rcx,[rcx+240]
       mov       rdx,[rcx+10]
       test      rdx,rdx
       je        near ptr M00_L42
M00_L10:
       mov       rcx,[rdx+10]
       test      rcx,rcx
       jne       short M00_L11
       mov       rcx,1FD7DC00110
       mov       rcx,[rcx]
       test      rcx,rcx
       jne       short M00_L11
       mov       rcx,1FD7DC000F0
       mov       rcx,[rcx]
       test      rcx,rcx
       je        near ptr M00_L43
M00_L11:
       mov       rdx,[rcx]
       mov       rdx,[rdx+48]
       call      qword ptr [rdx+30]
       cmp       [rax],al
       lea       rdx,[r14+0C]
       mov       [rbp-0C8],r14
       mov       r8d,[r14+8]
       mov       r10,[rbp-0B8]
       lea       r9,[r10+0C]
       mov       [rbp-0B8],r10
       mov       r11d,[r10+8]
       cmp       r8d,r11d
       je        near ptr M00_L06
       mov       [rbp-0B0],r12
M00_L12:
       mov       [rbp-48],rdx
       mov       [rbp-50],r9
       mov       rcx,[rax+20]
       mov       [rsp+20],r11d
       xor       eax,eax
       mov       [rsp+28],eax
       mov       rax,7FFEFF96B650
       mov       [rbp-80],rax
       lea       rax,[M00_L13]
       mov       [rbp-70],rax
       lea       rax,[rbp-90]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFF5F2F93A0
       call      rax
M00_L13:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFF5F64F778],0
       je        short M00_L14
       call      qword ptr [7FFF5F63D608]; CORINFO_HELP_STOP_FOR_GC
M00_L14:
       mov       rcx,[rbp-88]
       mov       [rsi+8],rcx
       xor       ecx,ecx
       mov       [rbp-48],rcx
       mov       [rbp-50],rcx
M00_L15:
       mov       ecx,eax
       mov       r12,[rbp-0B0]
       mov       r14,[rbp-0C8]
       jmp       near ptr M00_L08
M00_L16:
       mov       rdx,[rbp-0C0]
       mov       r10,[rbp-0C8]
       mov       r11,r10
       mov       r12,rdx
       mov       rax,r11
       jmp       short M00_L20
M00_L17:
       cmp       rdx,r9
       je        near ptr M00_L58
       mov       [rbp-0B0],r12
       jmp       near ptr M00_L23
M00_L18:
       xor       ecx,ecx
       mov       [rbp-0B0],r12
M00_L19:
       test      ecx,ecx
       mov       rax,[rbp-0B8]
       mov       r12,[rbp-0B0]
       mov       r14,[rbp-0A8]
       jge       short M00_L16
M00_L20:
       mov       r15,[rbp-98]
       cmp       [r15],r13
       jne       near ptr M00_L48
       mov       edx,[r15+8]
       inc       edx
       cmp       edx,[r15+0C]
       jae       near ptr M00_L27
       mov       [r15+8],edx
       mov       ecx,[r15+8]
       cmp       ecx,[r15+0C]
       jae       near ptr M00_L59
       mov       rcx,[r15+10]
       mov       r8d,[r15+8]
       cmp       r8d,[rcx+8]
       jae       near ptr M00_L60
       mov       edx,r8d
       mov       rcx,[rcx+rdx*8+10]
       mov       rdx,rcx
       mov       rcx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonOrderByBenchmark>b__12_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [r14+18],rcx
       jne       near ptr M00_L49
       mov       r15,[rbp-98]
       mov       [rbp-0C0],rdx
       mov       rcx,[rdx+30]
       mov       r8,rcx
       mov       rcx,offset MT_System.Collections.Generic.GenericComparer<System.String>
       cmp       [rdi],rcx
       mov       rdi,[rbp-0A0]
       jne       near ptr M00_L51
       test      r8,r8
       je        near ptr M00_L53
       test      rax,rax
       je        near ptr M00_L55
       mov       [rbp-0C8],r8
       mov       [rbp-0B8],rax
       cmp       r8,rax
       je        near ptr M00_L18
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],2
       jle       near ptr M00_L56
       mov       rcx,[rcx+240]
       mov       r10,[rcx+10]
       test      r10,r10
       je        near ptr M00_L56
M00_L21:
       mov       rcx,[r10+10]
       test      rcx,rcx
       jne       short M00_L22
       mov       rcx,1FD7DC00110
       mov       rcx,[rcx]
       test      rcx,rcx
       jne       short M00_L22
       mov       rcx,1FD7DC000F0
       mov       rcx,[rcx]
       test      rcx,rcx
       je        near ptr M00_L57
M00_L22:
       mov       r10,[rcx]
       mov       r10,[r10+48]
       call      qword ptr [r10+30]
       cmp       [rax],al
       mov       r10,[rbp-0C8]
       lea       rdx,[r10+0C]
       mov       [rbp-0C8],r10
       mov       r8d,[r10+8]
       mov       r11,[rbp-0B8]
       lea       r9,[r11+0C]
       mov       [rbp-0B8],r11
       mov       ecx,[r11+8]
       cmp       r8d,ecx
       je        near ptr M00_L17
       mov       [rbp-0B0],r12
M00_L23:
       mov       [rbp-48],rdx
       mov       [rbp-50],r9
       mov       rax,[rax+20]
       mov       [rsp+20],ecx
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rax
       mov       rax,7FFEFF96B650
       mov       [rbp-80],rax
       lea       rax,[M00_L24]
       mov       [rbp-70],rax
       lea       rax,[rbp-90]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFF5F2F93A0
       call      rax
M00_L24:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFF5F64F778],0
       je        short M00_L25
       call      qword ptr [7FFF5F63D608]; CORINFO_HELP_STOP_FOR_GC
M00_L25:
       mov       rcx,[rbp-88]
       mov       [rsi+8],rcx
       xor       ecx,ecx
       mov       [rbp-48],rcx
       mov       [rbp-50],rcx
       mov       rdi,[rbp-0A0]
       mov       r15,[rbp-98]
M00_L26:
       mov       ecx,eax
       jmp       near ptr M00_L19
M00_L27:
       mov       edx,[r15+0C]
       mov       [r15+8],edx
M00_L28:
       mov       dword ptr [rbp-40],1
       jmp       near ptr M00_L62
M00_L29:
       mov       r15,[rbp-98]
       cmp       [r15],r13
       jne       near ptr M00_L32
M00_L30:
       mov       r8d,[r15+8]
       inc       r8d
       cmp       r8d,[r15+0C]
       jae       near ptr M00_L34
       mov       [r15+8],r8d
       mov       edx,[r15+8]
       cmp       edx,[r15+0C]
       mov       [rbp-0B8],rax
       jae       near ptr M00_L41
       mov       rsi,[r15+10]
       mov       r10d,[r15+8]
       cmp       r10d,[rsi+8]
       jae       near ptr M00_L60
       mov       edx,r10d
       mov       rsi,[rsi+rdx*8+10]
       mov       rdx,rsi
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       mov       rcx,rdi
       mov       r8,[rbp-0B8]
       mov       [rbp-0D0],rax
       mov       rdx,rax
       mov       r11,7FFEFF640E20
       call      qword ptr [r11]
       test      eax,eax
       mov       rax,[rbp-0B8]
       jg        short M00_L30
       mov       r12,[rbp-0D0]
       mov       [rbp-0B8],r12
       mov       r12,rsi
       mov       rax,[rbp-0B8]
       jmp       near ptr M00_L30
M00_L31:
       mov       r12,[rbp-0D0]
       mov       rax,r12
       mov       r12,rsi
M00_L32:
       cmp       [r15],r13
       jne       near ptr M00_L40
       mov       r8d,[r15+8]
       inc       r8d
       cmp       r8d,[r15+0C]
       jae       short M00_L34
       mov       [r15+8],r8d
       mov       ecx,[r15+8]
       cmp       ecx,[r15+0C]
       jae       near ptr M00_L41
       mov       rsi,[r15+10]
       mov       r10d,[r15+8]
       cmp       r10d,[rsi+8]
       jae       near ptr M00_L60
       mov       ecx,r10d
       mov       rsi,[rsi+rcx*8+10]
       mov       [rbp-0B8],rax
M00_L33:
       mov       rdx,rsi
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       mov       rcx,rdi
       mov       r8,[rbp-0B8]
       mov       [rbp-0D0],rax
       mov       rdx,rax
       mov       r11,7FFEFF640E20
       call      qword ptr [r11]
       test      eax,eax
       mov       rax,[rbp-0B8]
       jg        short M00_L32
       jmp       near ptr M00_L31
M00_L34:
       mov       ecx,[r15+0C]
       mov       [r15+8],ecx
       jmp       near ptr M00_L28
M00_L35:
       mov       ecx,[r12+0C]
       mov       [r12+8],ecx
       jmp       near ptr M00_L61
M00_L36:
       mov       rcx,r12
       mov       r11,7FFEFF640DE8
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M00_L61
       jmp       near ptr M00_L03
M00_L37:
       call      qword ptr [7FFF000476D8]
       int       3
M00_L38:
       mov       rcx,r12
       mov       r11,7FFEFF640DF0
       call      qword ptr [r11]
       mov       r12,rax
M00_L39:
       mov       [rbp-0B0],r12
       mov       rdx,r12
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       mov       r12,[rbp-0B0]
       jmp       near ptr M00_L04
M00_L40:
       mov       [rbp-0B8],rax
       mov       rcx,r15
       mov       r11,7FFEFF640E10
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M00_L28
       mov       rcx,r15
       mov       r11,7FFEFF640E18
       call      qword ptr [r11]
       mov       rsi,rax
       jmp       near ptr M00_L33
M00_L41:
       mov       ecx,[r15+8]
       call      qword ptr [7FFF000476D8]
       int       3
M00_L42:
       mov       ecx,2
       call      qword ptr [7FFF00047750]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       rdx,rax
       jmp       near ptr M00_L10
M00_L43:
       call      qword ptr [7FFEFF975DA0]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rcx,rax
       jmp       near ptr M00_L11
M00_L44:
       xor       eax,eax
       mov       [rbp-0B0],r12
       jmp       near ptr M00_L15
M00_L45:
       mov       ecx,1
       mov       [rbp-0B8],rax
       jmp       near ptr M00_L08
M00_L46:
       test      rax,rax
       je        short M00_L47
       mov       ecx,0FFFFFFFF
       mov       [rbp-0B8],rax
       jmp       near ptr M00_L08
M00_L47:
       xor       ecx,ecx
       mov       [rbp-0B8],rax
       jmp       near ptr M00_L08
M00_L48:
       mov       [rbp-0B8],rax
       mov       rcx,r15
       mov       r11,7FFEFF640DF8
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M00_L28
       mov       rcx,r15
       mov       r11,7FFEFF640E00
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       short M00_L50
M00_L49:
       mov       [rbp-0B8],rax
M00_L50:
       mov       [rbp-0C0],rdx
       mov       r14,[rbp-0A8]
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       mov       [rbp-0C8],rax
       mov       rax,[rbp-0B8]
       mov       r15,[rbp-98]
       jmp       short M00_L52
M00_L51:
       mov       [rbp-0C8],r8
M00_L52:
       mov       rcx,rdi
       mov       [rbp-0B8],rax
       mov       r8,rax
       mov       rdx,[rbp-0C8]
       mov       r11,7FFEFF640E08
       call      qword ptr [r11]
       mov       ecx,eax
       mov       [rbp-0B0],r12
       jmp       near ptr M00_L19
M00_L53:
       mov       [rbp-0B8],rax
       test      rax,rax
       jne       short M00_L54
       mov       rax,[rbp-0B8]
       xor       ecx,ecx
       mov       [rbp-0C8],r8
       mov       [rbp-0B8],rax
       mov       [rbp-0B0],r12
       jmp       near ptr M00_L19
M00_L54:
       mov       rax,[rbp-0B8]
       mov       ecx,0FFFFFFFF
       mov       [rbp-0C8],r8
       mov       [rbp-0B8],rax
       mov       [rbp-0B0],r12
       jmp       near ptr M00_L19
M00_L55:
       mov       ecx,1
       mov       [rbp-0C8],r8
       mov       [rbp-0B8],rax
       mov       [rbp-0B0],r12
       jmp       near ptr M00_L19
M00_L56:
       mov       ecx,2
       call      qword ptr [7FFF00047750]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       r10,rax
       jmp       near ptr M00_L21
M00_L57:
       call      qword ptr [7FFEFF975DA0]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rcx,rax
       jmp       near ptr M00_L22
M00_L58:
       xor       eax,eax
       mov       [rbp-0B0],r12
       jmp       near ptr M00_L26
M00_L59:
       mov       ecx,[r15+8]
       call      qword ptr [7FFF000476D8]
       int       3
M00_L60:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L61:
       xor       ecx,ecx
       mov       [rbp-40],ecx
       xor       r12d,r12d
       mov       r15,[rbp-98]
M00_L62:
       cmp       [r15],r13
       jne       near ptr M00_L70
M00_L63:
       cmp       byte ptr [rbp-40],0
       je        near ptr M00_L71
       mov       [rbp-58],r12
       mov       rbx,[rbp+10]
       mov       r15,[rbx+60]
       mov       rdx,[rbp-58]
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [r15+8],rax
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
M00_L64:
       mov       ecx,11
       call      qword ptr [7FFEFF977DF8]
       int       3
M00_L65:
       mov       r13,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,r13
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       dword ptr [r12+8],0FFFFFFFF
       mov       [r12+0C],r14d
       lea       rcx,[r12+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L02
M00_L66:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdx,1FDA6C00E58
       mov       rdx,[rdx]
       mov       rcx,r14
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonOrderByBenchmark>b__12_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFEFF6F6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1FDA6C00E60
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L67:
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L01
M00_L68:
       mov       rcx,rdi
       mov       r11,7FFEFF640E30
       call      qword ptr [r11]
       mov       r12,rax
       jmp       near ptr M00_L02
M00_L69:
       mov       r11,7FFEFF640DE0
       call      qword ptr [r11]
       mov       r12,rax
       jmp       near ptr M00_L02
M00_L70:
       mov       rcx,r15
       mov       r11,7FFEFF640E28
       call      qword ptr [r11]
       jmp       near ptr M00_L63
M00_L71:
       call      qword ptr [7FFEFFE7FE58]
       int       3
       sub       rsp,38
       vzeroupper
       cmp       qword ptr [rbp-98],0
       je        short M00_L72
       mov       r13,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       r15,[rbp-98]
       cmp       [r15],r13
       je        short M00_L72
       mov       rcx,r15
       mov       r11,7FFEFF640E28
       call      qword ptr [r11]
M00_L72:
       nop
       add       rsp,38
       ret
; Total bytes of code 2884
```
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonOrderByBenchmark>b__12_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       mov       rax,[rdx+30]
       ret
; Total bytes of code 5
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FFF51600D78]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       ecx,ebx
       and       ecx,0FFFFFF
       mov       edx,ecx
       mov       r8d,ebx
       sar       r8d,18
       jne       short M02_L01
       cmp       [rax],ecx
       jle       short M02_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M02_L03
M02_L00:
       add       rsp,20
       pop       rbx
       ret
M02_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M02_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M02_L00
M02_L02:
       cmp       [rax+4],edx
       jle       short M02_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M02_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M02_L03
       jmp       short M02_L00
M02_L03:
       mov       ecx,ebx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax]
; Total bytes of code 130
```
```assembly
; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       push      rsi
       push      rbx
       sub       rsp,28
       call      qword ptr [7FFF515E87D0]
       mov       rbx,rax
       mov       rsi,rbx
       call      qword ptr [7FFF515FFA88]
       mov       rdx,rax
       test      rsi,rsi
       je        short M03_L00
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFF51600C28]
       mov       rax,[rbx]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M03_L00:
       call      qword ptr [7FFF515FE468]
       int       3
; Total bytes of code 61
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M04_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L00:
       call      qword ptr [7FFF0004E688]
       int       3
; Total bytes of code 44
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M05_L00
       ret
M05_L00:
       jmp       qword ptr [7FFEFF6F5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.PersonOrderByBenchmark()
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
       xor       eax,eax
       mov       [rbp-58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp-40],rax
       mov       rbx,rcx
       lea       rcx,[rbp-90]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rcx,rsp
       mov       [rbp-78],rcx
       mov       rcx,rbp
       mov       [rbp-68],rcx
       mov       [rbp+10],rbx
       mov       rdi,[rbx+288]
       mov       rcx,2458D402E58
       mov       r14,[rcx]
       test      r14,r14
       je        near ptr M00_L65
M00_L00:
       mov       rcx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [r15+10],eax
       lea       rcx,[r15+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        near ptr M00_L63
       xor       ecx,ecx
       mov       [r15+20],rcx
       lea       rcx,[r15+28]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,2458D400A08
       mov       rdx,[rcx]
       lea       rcx,[r15+30]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [r15+48],0
       mov       rcx,[r15+18]
       mov       rax,offset MT_System.Collections.ObjectModel.Collection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rax
       jne       near ptr M00_L68
       mov       rdi,[rcx+8]
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rdi],rcx
       jne       near ptr M00_L67
       mov       r14d,[rdi+8]
       test      r14d,r14d
       jne       near ptr M00_L64
       mov       r13,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,r13
       test      byte ptr [7FFF00029A08],1
       je        near ptr M00_L66
M00_L01:
       mov       rcx,2458D402E90
       mov       r12,[rcx]
M00_L02:
       mov       [rbp-98],r12
       mov       r13,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r12],r13
       jne       near ptr M00_L35
       mov       ecx,[r12+8]
       inc       ecx
       cmp       ecx,[r12+0C]
       jae       near ptr M00_L34
       mov       [r12+8],ecx
M00_L03:
       mov       rdi,[r15+30]
       mov       [rbp-0A0],rdi
       mov       r14,[r15+28]
       mov       [rbp-0A8],r14
       cmp       [r12],r13
       jne       near ptr M00_L37
       mov       ecx,[r12+8]
       cmp       ecx,[r12+0C]
       jae       near ptr M00_L36
       mov       rax,[r12+10]
       cmp       ecx,[rax+8]
       jae       near ptr M00_L59
       mov       r12,[rax+rcx*8+10]
       mov       rcx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonOrderByBenchmark>b__12_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [r14+18],rcx
       jne       near ptr M00_L38
       mov       rax,[r12+30]
M00_L04:
       cmp       byte ptr [r15+48],0
       jne       near ptr M00_L28
       test      r14,r14
       je        near ptr M00_L19
       test      rdi,rdi
       je        near ptr M00_L19
       mov       r15,[rbp-98]
       cmp       [r15],r13
       jne       near ptr M00_L19
       mov       rcx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonOrderByBenchmark>b__12_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [r14+18],rcx
       jne       near ptr M00_L19
       mov       rcx,offset MT_System.Collections.Generic.GenericComparer<System.String>
       cmp       [rdi],rcx
       jne       near ptr M00_L19
       jmp       near ptr M00_L11
M00_L05:
       mov       rdi,[rbp-0C0]
       mov       r14,[rbp-0C8]
       mov       r10,r14
       mov       [rbp-0B0],rdi
       mov       rax,r10
       mov       r12,[rbp-0B0]
       jmp       near ptr M00_L11
M00_L06:
       mov       [rbp-0B0],r12
M00_L07:
       mov       [rbp-48],rdx
       mov       [rbp-50],r9
       mov       rcx,[rax+20]
       mov       [rsp+20],r11d
       xor       eax,eax
       mov       [rsp+28],eax
       mov       rax,7FFEFF98B650
       mov       [rbp-80],rax
       lea       rax,[M00_L08]
       mov       [rbp-70],rax
       lea       rax,[rbp-90]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFF5F2F93A0
       call      rax
M00_L08:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFF5F64F778],0
       je        short M00_L09
       call      qword ptr [7FFF5F63D608]; CORINFO_HELP_STOP_FOR_GC
M00_L09:
       mov       rcx,[rbp-88]
       mov       [rsi+8],rcx
       xor       ecx,ecx
       mov       [rbp-48],rcx
       mov       [rbp-50],rcx
M00_L10:
       test      eax,eax
       mov       rax,[rbp-0B8]
       mov       r12,[rbp-0B0]
       mov       r15,[rbp-98]
       jge       near ptr M00_L05
M00_L11:
       mov       edx,[r15+8]
       inc       edx
       cmp       edx,[r15+0C]
       jae       near ptr M00_L26
       mov       [r15+8],edx
       mov       r8d,[r15+8]
       cmp       r8d,[r15+0C]
       jae       near ptr M00_L58
       mov       r14,[r15+10]
       cmp       r8d,[r14+8]
       jae       near ptr M00_L59
       mov       ecx,r8d
       mov       rdi,[r14+rcx*8+10]
       mov       [rbp-0C0],rdi
       mov       r14,[rdi+30]
       test      r14,r14
       je        near ptr M00_L45
       test      rax,rax
       je        near ptr M00_L44
       mov       [rbp-0B8],rax
       cmp       r14,rax
       je        near ptr M00_L14
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],2
       jle       near ptr M00_L41
       mov       rcx,[rcx+240]
       mov       rdx,[rcx+10]
       test      rdx,rdx
       je        near ptr M00_L41
M00_L12:
       mov       rcx,[rdx+10]
       test      rcx,rcx
       jne       short M00_L13
       mov       rcx,2458D400110
       mov       rcx,[rcx]
       test      rcx,rcx
       jne       short M00_L13
       mov       rcx,2458D4000F0
       mov       rcx,[rcx]
       test      rcx,rcx
       je        near ptr M00_L42
M00_L13:
       mov       rdx,[rcx]
       mov       rdx,[rdx+48]
       call      qword ptr [rdx+30]
       cmp       [rax],al
       lea       rdx,[r14+0C]
       mov       [rbp-0C8],r14
       mov       r8d,[r14+8]
       mov       r10,[rbp-0B8]
       lea       r9,[r10+0C]
       mov       [rbp-0B8],r10
       mov       r11d,[r10+8]
       cmp       r8d,r11d
       jne       near ptr M00_L06
       cmp       rdx,r9
       je        near ptr M00_L43
       mov       [rbp-0B0],r12
       jmp       near ptr M00_L07
M00_L14:
       xor       ecx,ecx
       mov       [rbp-0C8],r14
       mov       [rbp-0B0],r12
       mov       eax,ecx
       jmp       near ptr M00_L10
M00_L15:
       mov       rdx,[rbp-0C0]
       mov       r10,[rbp-0C8]
       mov       r11,r10
       mov       r12,rdx
       mov       rax,r11
       jmp       short M00_L19
M00_L16:
       cmp       rdx,r9
       je        near ptr M00_L57
       mov       [rbp-0B0],r12
       jmp       near ptr M00_L22
M00_L17:
       xor       ecx,ecx
       mov       [rbp-0B0],r12
       mov       eax,ecx
M00_L18:
       test      eax,eax
       mov       rax,[rbp-0B8]
       mov       r12,[rbp-0B0]
       mov       r14,[rbp-0A8]
       jge       short M00_L15
M00_L19:
       mov       r15,[rbp-98]
       cmp       [r15],r13
       jne       near ptr M00_L47
       mov       edx,[r15+8]
       inc       edx
       cmp       edx,[r15+0C]
       jae       near ptr M00_L26
       mov       [r15+8],edx
       mov       ecx,[r15+8]
       cmp       ecx,[r15+0C]
       jae       near ptr M00_L58
       mov       rcx,[r15+10]
       mov       r8d,[r15+8]
       cmp       r8d,[rcx+8]
       jae       near ptr M00_L59
       mov       edx,r8d
       mov       rcx,[rcx+rdx*8+10]
       mov       rdx,rcx
       mov       rcx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonOrderByBenchmark>b__12_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [r14+18],rcx
       jne       near ptr M00_L48
       mov       r15,[rbp-98]
       mov       [rbp-0C0],rdx
       mov       rcx,[rdx+30]
       mov       r8,rcx
       mov       rcx,offset MT_System.Collections.Generic.GenericComparer<System.String>
       cmp       [rdi],rcx
       mov       rdi,[rbp-0A0]
       jne       near ptr M00_L50
       test      r8,r8
       je        near ptr M00_L52
       test      rax,rax
       je        near ptr M00_L54
       mov       [rbp-0C8],r8
       mov       [rbp-0B8],rax
       cmp       r8,rax
       je        near ptr M00_L17
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],2
       jle       near ptr M00_L55
       mov       rcx,[rcx+240]
       mov       r10,[rcx+10]
       test      r10,r10
       je        near ptr M00_L55
M00_L20:
       mov       rcx,[r10+10]
       test      rcx,rcx
       jne       short M00_L21
       mov       rcx,2458D400110
       mov       rcx,[rcx]
       test      rcx,rcx
       jne       short M00_L21
       mov       rcx,2458D4000F0
       mov       rcx,[rcx]
       test      rcx,rcx
       je        near ptr M00_L56
M00_L21:
       mov       r10,[rcx]
       mov       r10,[r10+48]
       call      qword ptr [r10+30]
       cmp       [rax],al
       mov       r10,[rbp-0C8]
       lea       rdx,[r10+0C]
       mov       [rbp-0C8],r10
       mov       r8d,[r10+8]
       mov       r11,[rbp-0B8]
       lea       r9,[r11+0C]
       mov       [rbp-0B8],r11
       mov       ecx,[r11+8]
       cmp       r8d,ecx
       je        near ptr M00_L16
       mov       [rbp-0B0],r12
M00_L22:
       mov       [rbp-48],rdx
       mov       [rbp-50],r9
       mov       rax,[rax+20]
       mov       [rsp+20],ecx
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rax
       mov       rax,7FFEFF98B650
       mov       [rbp-80],rax
       lea       rax,[M00_L23]
       mov       [rbp-70],rax
       lea       rax,[rbp-90]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFF5F2F93A0
       call      rax
M00_L23:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFF5F64F778],0
       je        short M00_L24
       call      qword ptr [7FFF5F63D608]; CORINFO_HELP_STOP_FOR_GC
M00_L24:
       mov       rcx,[rbp-88]
       mov       [rsi+8],rcx
       xor       ecx,ecx
       mov       [rbp-48],rcx
       mov       [rbp-50],rcx
       mov       rdi,[rbp-0A0]
       mov       r15,[rbp-98]
M00_L25:
       jmp       near ptr M00_L18
M00_L26:
       mov       edx,[r15+0C]
       mov       [r15+8],edx
M00_L27:
       mov       dword ptr [rbp-40],1
       jmp       near ptr M00_L61
M00_L28:
       mov       r15,[rbp-98]
       cmp       [r15],r13
       jne       near ptr M00_L31
M00_L29:
       mov       r8d,[r15+8]
       inc       r8d
       cmp       r8d,[r15+0C]
       jae       near ptr M00_L33
       mov       [r15+8],r8d
       mov       edx,[r15+8]
       cmp       edx,[r15+0C]
       mov       [rbp-0B8],rax
       jae       near ptr M00_L40
       mov       rsi,[r15+10]
       mov       r10d,[r15+8]
       cmp       r10d,[rsi+8]
       jae       near ptr M00_L59
       mov       edx,r10d
       mov       rsi,[rsi+rdx*8+10]
       mov       rdx,rsi
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       mov       rcx,rdi
       mov       r8,[rbp-0B8]
       mov       [rbp-0D0],rax
       mov       rdx,rax
       mov       r11,7FFEFF660E20
       call      qword ptr [r11]
       test      eax,eax
       mov       rax,[rbp-0B8]
       jg        short M00_L29
       mov       r12,[rbp-0D0]
       mov       [rbp-0B8],r12
       mov       r12,rsi
       mov       rax,[rbp-0B8]
       jmp       near ptr M00_L29
M00_L30:
       mov       r12,[rbp-0D0]
       mov       rax,r12
       mov       r12,rsi
M00_L31:
       cmp       [r15],r13
       jne       near ptr M00_L39
       mov       r8d,[r15+8]
       inc       r8d
       cmp       r8d,[r15+0C]
       jae       short M00_L33
       mov       [r15+8],r8d
       mov       ecx,[r15+8]
       cmp       ecx,[r15+0C]
       jae       near ptr M00_L40
       mov       rsi,[r15+10]
       mov       r10d,[r15+8]
       cmp       r10d,[rsi+8]
       jae       near ptr M00_L59
       mov       ecx,r10d
       mov       rsi,[rsi+rcx*8+10]
       mov       [rbp-0B8],rax
M00_L32:
       mov       rdx,rsi
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       mov       rcx,rdi
       mov       r8,[rbp-0B8]
       mov       [rbp-0D0],rax
       mov       rdx,rax
       mov       r11,7FFEFF660E20
       call      qword ptr [r11]
       test      eax,eax
       mov       rax,[rbp-0B8]
       jg        short M00_L31
       jmp       near ptr M00_L30
M00_L33:
       mov       ecx,[r15+0C]
       mov       [r15+8],ecx
       jmp       near ptr M00_L27
M00_L34:
       mov       ecx,[r12+0C]
       mov       [r12+8],ecx
       jmp       near ptr M00_L60
M00_L35:
       mov       rcx,r12
       mov       r11,7FFEFF660DE8
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M00_L60
       jmp       near ptr M00_L03
M00_L36:
       call      qword ptr [7FFF00067660]
       int       3
M00_L37:
       mov       rcx,r12
       mov       r11,7FFEFF660DF0
       call      qword ptr [r11]
       mov       r12,rax
M00_L38:
       mov       [rbp-0B0],r12
       mov       rdx,r12
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       mov       r12,[rbp-0B0]
       jmp       near ptr M00_L04
M00_L39:
       mov       [rbp-0B8],rax
       mov       rcx,r15
       mov       r11,7FFEFF660E10
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M00_L27
       mov       rcx,r15
       mov       r11,7FFEFF660E18
       call      qword ptr [r11]
       mov       rsi,rax
       jmp       near ptr M00_L32
M00_L40:
       mov       ecx,[r15+8]
       call      qword ptr [7FFF00067660]
       int       3
M00_L41:
       mov       ecx,2
       call      qword ptr [7FFF000676D8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       rdx,rax
       jmp       near ptr M00_L12
M00_L42:
       call      qword ptr [7FFEFF995DA0]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rcx,rax
       jmp       near ptr M00_L13
M00_L43:
       xor       eax,eax
       mov       [rbp-0B0],r12
       jmp       near ptr M00_L10
M00_L44:
       mov       edx,1
       mov       [rbp-0C8],r14
       mov       [rbp-0B8],rax
       mov       [rbp-0B0],r12
       mov       eax,edx
       jmp       near ptr M00_L10
M00_L45:
       test      rax,rax
       je        short M00_L46
       mov       edx,0FFFFFFFF
       mov       [rbp-0C8],r14
       mov       [rbp-0B8],rax
       mov       [rbp-0B0],r12
       mov       eax,edx
       jmp       near ptr M00_L10
M00_L46:
       xor       edx,edx
       mov       [rbp-0C8],r14
       mov       [rbp-0B8],rax
       mov       [rbp-0B0],r12
       mov       eax,edx
       jmp       near ptr M00_L10
M00_L47:
       mov       [rbp-0B8],rax
       mov       rcx,r15
       mov       r11,7FFEFF660DF8
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M00_L27
       mov       rcx,r15
       mov       r11,7FFEFF660E00
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       short M00_L49
M00_L48:
       mov       [rbp-0B8],rax
M00_L49:
       mov       [rbp-0C0],rdx
       mov       r14,[rbp-0A8]
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       mov       [rbp-0C8],rax
       mov       rax,[rbp-0B8]
       mov       r15,[rbp-98]
       jmp       short M00_L51
M00_L50:
       mov       [rbp-0C8],r8
M00_L51:
       mov       rcx,rdi
       mov       [rbp-0B8],rax
       mov       r8,rax
       mov       rdx,[rbp-0C8]
       mov       r11,7FFEFF660E08
       call      qword ptr [r11]
       mov       r10d,eax
       mov       [rbp-0B0],r12
       mov       eax,r10d
       jmp       near ptr M00_L18
M00_L52:
       mov       [rbp-0B8],rax
       test      rax,rax
       jne       short M00_L53
       mov       rax,[rbp-0B8]
       xor       r10d,r10d
       mov       [rbp-0C8],r8
       mov       [rbp-0B8],rax
       mov       [rbp-0B0],r12
       mov       eax,r10d
       jmp       near ptr M00_L18
M00_L53:
       mov       rax,[rbp-0B8]
       mov       r10d,0FFFFFFFF
       mov       [rbp-0C8],r8
       mov       [rbp-0B8],rax
       mov       [rbp-0B0],r12
       mov       eax,r10d
       jmp       near ptr M00_L18
M00_L54:
       mov       r10d,1
       mov       [rbp-0C8],r8
       mov       [rbp-0B8],rax
       mov       [rbp-0B0],r12
       mov       eax,r10d
       jmp       near ptr M00_L18
M00_L55:
       mov       ecx,2
       call      qword ptr [7FFF000676D8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       r10,rax
       jmp       near ptr M00_L20
M00_L56:
       call      qword ptr [7FFEFF995DA0]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rcx,rax
       jmp       near ptr M00_L21
M00_L57:
       xor       eax,eax
       mov       [rbp-0B0],r12
       jmp       near ptr M00_L25
M00_L58:
       mov       ecx,[r15+8]
       call      qword ptr [7FFF00067660]
       int       3
M00_L59:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L60:
       xor       ecx,ecx
       mov       [rbp-40],ecx
       xor       r12d,r12d
       mov       r15,[rbp-98]
M00_L61:
       cmp       [r15],r13
       jne       near ptr M00_L69
M00_L62:
       cmp       byte ptr [rbp-40],0
       je        near ptr M00_L70
       mov       [rbp-58],r12
       mov       rbx,[rbp+10]
       mov       r15,[rbx+60]
       mov       rdx,[rbp-58]
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [r15+8],rax
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
M00_L63:
       mov       ecx,11
       call      qword ptr [7FFEFF997DF8]
       int       3
M00_L64:
       mov       r13,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,r13
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       dword ptr [r12+8],0FFFFFFFF
       mov       [r12+0C],r14d
       lea       rcx,[r12+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L02
M00_L65:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdx,2458D402E50
       mov       rdx,[rdx]
       mov       rcx,r14
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonOrderByBenchmark>b__12_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFEFF716BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,2458D402E58
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L66:
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L01
M00_L67:
       mov       rcx,rdi
       mov       r11,7FFEFF660E30
       call      qword ptr [r11]
       mov       r12,rax
       jmp       near ptr M00_L02
M00_L68:
       mov       r11,7FFEFF660DE0
       call      qword ptr [r11]
       mov       r12,rax
       jmp       near ptr M00_L02
M00_L69:
       mov       rcx,r15
       mov       r11,7FFEFF660E28
       call      qword ptr [r11]
       jmp       near ptr M00_L62
M00_L70:
       call      qword ptr [7FFEFFE9FE70]
       int       3
       sub       rsp,38
       vzeroupper
       cmp       qword ptr [rbp-98],0
       je        short M00_L71
       mov       r13,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       r15,[rbp-98]
       cmp       [r15],r13
       je        short M00_L71
       mov       rcx,r15
       mov       r11,7FFEFF660E28
       call      qword ptr [r11]
M00_L71:
       nop
       add       rsp,38
       ret
; Total bytes of code 2979
```
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonOrderByBenchmark>b__12_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       mov       rax,[rdx+30]
       ret
; Total bytes of code 5
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FFF51600D78]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       ecx,ebx
       and       ecx,0FFFFFF
       mov       edx,ecx
       mov       r8d,ebx
       sar       r8d,18
       jne       short M02_L01
       cmp       [rax],ecx
       jle       short M02_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M02_L03
M02_L00:
       add       rsp,20
       pop       rbx
       ret
M02_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M02_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M02_L00
M02_L02:
       cmp       [rax+4],edx
       jle       short M02_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M02_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M02_L03
       jmp       short M02_L00
M02_L03:
       mov       ecx,ebx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax]
; Total bytes of code 130
```
```assembly
; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       push      rsi
       push      rbx
       sub       rsp,28
       call      qword ptr [7FFF515E87D0]
       mov       rbx,rax
       mov       rsi,rbx
       call      qword ptr [7FFF515FFA88]
       mov       rdx,rax
       test      rsi,rsi
       je        short M03_L00
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFF51600C28]
       mov       rax,[rbx]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M03_L00:
       call      qword ptr [7FFF515FE468]
       int       3
; Total bytes of code 61
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M04_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L00:
       call      qword ptr [7FFF0006E628]
       int       3
; Total bytes of code 44
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M05_L00
       ret
M05_L00:
       jmp       qword ptr [7FFEFF715C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.PersonOrderByBenchmark()
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
       xor       eax,eax
       mov       [rbp-58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp-40],rax
       mov       rbx,rcx
       lea       rcx,[rbp-90]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rcx,rsp
       mov       [rbp-78],rcx
       mov       rcx,rbp
       mov       [rbp-68],rcx
       mov       [rbp+10],rbx
       mov       rdi,[rbx+288]
       mov       rcx,1B73F400EB8
       mov       r14,[rcx]
       test      r14,r14
       je        near ptr M00_L65
M00_L00:
       mov       rcx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [r15+10],eax
       lea       rcx,[r15+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        near ptr M00_L66
       xor       ecx,ecx
       mov       [r15+20],rcx
       lea       rcx,[r15+28]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,1B712400A08
       mov       rdx,[rcx]
       lea       rcx,[r15+30]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [r15+48],0
       mov       rcx,[r15+18]
       mov       rax,offset MT_System.Collections.ObjectModel.Collection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rax
       jne       near ptr M00_L69
       mov       rdi,[rcx+8]
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rdi],rcx
       jne       near ptr M00_L68
       mov       r14d,[rdi+8]
       test      r14d,r14d
       jne       near ptr M00_L64
       mov       r13,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,r13
       test      byte ptr [7FFF000B02E0],1
       je        near ptr M00_L67
M00_L01:
       mov       rcx,1B73F400FD0
       mov       r12,[rcx]
M00_L02:
       mov       [rbp-98],r12
       mov       r13,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r12],r13
       jne       near ptr M00_L36
       mov       ecx,[r12+8]
       inc       ecx
       cmp       ecx,[r12+0C]
       jae       near ptr M00_L35
       mov       [r12+8],ecx
M00_L03:
       mov       rdi,[r15+30]
       mov       [rbp-0A0],rdi
       mov       r14,[r15+28]
       mov       [rbp-0A8],r14
       cmp       [r12],r13
       jne       near ptr M00_L38
       mov       ecx,[r12+8]
       cmp       ecx,[r12+0C]
       jae       near ptr M00_L37
       mov       rax,[r12+10]
       cmp       ecx,[rax+8]
       jae       near ptr M00_L60
       mov       r12,[rax+rcx*8+10]
       mov       rcx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonOrderByBenchmark>b__12_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [r14+18],rcx
       jne       near ptr M00_L39
       mov       rax,[r12+30]
M00_L04:
       cmp       byte ptr [r15+48],0
       jne       near ptr M00_L29
       test      r14,r14
       je        near ptr M00_L19
       test      rdi,rdi
       je        near ptr M00_L19
       mov       r15,[rbp-98]
       cmp       [r15],r13
       jne       near ptr M00_L19
       mov       rcx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonOrderByBenchmark>b__12_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [r14+18],rcx
       jne       near ptr M00_L19
       mov       rcx,offset MT_System.Collections.Generic.GenericComparer<System.String>
       cmp       [rdi],rcx
       jne       near ptr M00_L19
       jmp       short M00_L09
M00_L05:
       mov       rdi,[rbp-0C0]
       mov       rax,r14
       mov       [rbp-0B0],rdi
       mov       r12,[rbp-0B0]
       jmp       short M00_L09
M00_L06:
       cmp       rdx,r9
       je        near ptr M00_L44
       mov       [rbp-0B0],r12
       jmp       near ptr M00_L12
M00_L07:
       xor       ecx,ecx
M00_L08:
       test      ecx,ecx
       mov       rax,[rbp-0B8]
       mov       r15,[rbp-98]
       jge       short M00_L05
M00_L09:
       mov       edx,[r15+8]
       inc       edx
       cmp       edx,[r15+0C]
       jae       near ptr M00_L27
       mov       [r15+8],edx
       mov       r8d,[r15+8]
       cmp       r8d,[r15+0C]
       jae       near ptr M00_L59
       mov       r14,[r15+10]
       cmp       r8d,[r14+8]
       jae       near ptr M00_L60
       mov       ecx,r8d
       mov       rdi,[r14+rcx*8+10]
       mov       [rbp-0C0],rdi
       mov       r14,[rdi+30]
       test      r14,r14
       je        near ptr M00_L46
       test      rax,rax
       je        near ptr M00_L45
       mov       [rbp-0B8],rax
       cmp       r14,rax
       je        short M00_L07
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],2
       jle       near ptr M00_L42
       mov       rcx,[rcx+240]
       mov       rdx,[rcx+10]
       test      rdx,rdx
       je        near ptr M00_L42
M00_L10:
       mov       rcx,[rdx+10]
       test      rcx,rcx
       jne       short M00_L11
       mov       rcx,1B712400110
       mov       rcx,[rcx]
       test      rcx,rcx
       jne       short M00_L11
       mov       rcx,1B7124000F0
       mov       rcx,[rcx]
       test      rcx,rcx
       je        near ptr M00_L43
M00_L11:
       mov       rdx,[rcx]
       mov       rdx,[rdx+48]
       call      qword ptr [rdx+30]
       cmp       [rax],al
       lea       rdx,[r14+0C]
       mov       [rbp-0C8],r14
       mov       r8d,[r14+8]
       mov       r10,[rbp-0B8]
       lea       r9,[r10+0C]
       mov       [rbp-0B8],r10
       mov       r11d,[r10+8]
       cmp       r8d,r11d
       je        near ptr M00_L06
       mov       [rbp-0B0],r12
M00_L12:
       mov       [rbp-48],rdx
       mov       [rbp-50],r9
       mov       rcx,[rax+20]
       mov       [rsp+20],r11d
       xor       eax,eax
       mov       [rsp+28],eax
       mov       rax,7FFEFF96B650
       mov       [rbp-80],rax
       lea       rax,[M00_L13]
       mov       [rbp-70],rax
       lea       rax,[rbp-90]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFF5F2F93A0
       call      rax
M00_L13:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFF5F64F778],0
       je        short M00_L14
       call      qword ptr [7FFF5F63D608]; CORINFO_HELP_STOP_FOR_GC
M00_L14:
       mov       rcx,[rbp-88]
       mov       [rsi+8],rcx
       xor       ecx,ecx
       mov       [rbp-48],rcx
       mov       [rbp-50],rcx
M00_L15:
       mov       ecx,eax
       mov       r12,[rbp-0B0]
       mov       r14,[rbp-0C8]
       jmp       near ptr M00_L08
M00_L16:
       mov       rdx,[rbp-0C0]
       mov       r10,[rbp-0C8]
       mov       r11,r10
       mov       r12,rdx
       mov       rax,r11
       jmp       short M00_L19
M00_L17:
       xor       ecx,ecx
       mov       [rbp-0B0],r12
M00_L18:
       test      ecx,ecx
       mov       rax,[rbp-0B8]
       mov       r12,[rbp-0B0]
       mov       r14,[rbp-0A8]
       jge       short M00_L16
M00_L19:
       mov       r15,[rbp-98]
       cmp       [r15],r13
       jne       near ptr M00_L48
       mov       edx,[r15+8]
       inc       edx
       cmp       edx,[r15+0C]
       jae       near ptr M00_L27
       mov       [r15+8],edx
       mov       ecx,[r15+8]
       cmp       ecx,[r15+0C]
       jae       near ptr M00_L59
       mov       rcx,[r15+10]
       mov       r8d,[r15+8]
       cmp       r8d,[rcx+8]
       jae       near ptr M00_L60
       mov       edx,r8d
       mov       rcx,[rcx+rdx*8+10]
       mov       rdx,rcx
       mov       rcx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonOrderByBenchmark>b__12_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [r14+18],rcx
       jne       near ptr M00_L49
       mov       r15,[rbp-98]
       mov       [rbp-0C0],rdx
       mov       rcx,[rdx+30]
       mov       r8,rcx
       mov       rcx,offset MT_System.Collections.Generic.GenericComparer<System.String>
       cmp       [rdi],rcx
       mov       rdi,[rbp-0A0]
       jne       near ptr M00_L51
       test      r8,r8
       je        near ptr M00_L53
       test      rax,rax
       je        near ptr M00_L55
       mov       [rbp-0C8],r8
       mov       [rbp-0B8],rax
       cmp       r8,rax
       je        near ptr M00_L17
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],2
       jle       near ptr M00_L56
       mov       rcx,[rcx+240]
       mov       r10,[rcx+10]
       test      r10,r10
       je        near ptr M00_L56
M00_L20:
       mov       rcx,[r10+10]
       test      rcx,rcx
       jne       short M00_L21
       mov       rcx,1B712400110
       mov       rcx,[rcx]
       test      rcx,rcx
       jne       short M00_L21
       mov       rcx,1B7124000F0
       mov       rcx,[rcx]
       test      rcx,rcx
       je        near ptr M00_L57
M00_L21:
       mov       r10,[rcx]
       mov       r10,[r10+48]
       call      qword ptr [r10+30]
       cmp       [rax],al
       mov       r10,[rbp-0C8]
       lea       rdx,[r10+0C]
       mov       [rbp-0C8],r10
       mov       r8d,[r10+8]
       mov       r11,[rbp-0B8]
       lea       r9,[r11+0C]
       mov       [rbp-0B8],r11
       mov       ecx,[r11+8]
       cmp       r8d,ecx
       je        near ptr M00_L26
       mov       [rbp-0B0],r12
M00_L22:
       mov       [rbp-48],rdx
       mov       [rbp-50],r9
       mov       rax,[rax+20]
       mov       [rsp+20],ecx
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rax
       mov       rax,7FFEFF96B650
       mov       [rbp-80],rax
       lea       rax,[M00_L23]
       mov       [rbp-70],rax
       lea       rax,[rbp-90]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFF5F2F93A0
       call      rax
M00_L23:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFF5F64F778],0
       je        short M00_L24
       call      qword ptr [7FFF5F63D608]; CORINFO_HELP_STOP_FOR_GC
M00_L24:
       mov       rcx,[rbp-88]
       mov       [rsi+8],rcx
       xor       ecx,ecx
       mov       [rbp-48],rcx
       mov       [rbp-50],rcx
       mov       rdi,[rbp-0A0]
       mov       r15,[rbp-98]
M00_L25:
       mov       ecx,eax
       jmp       near ptr M00_L18
M00_L26:
       cmp       rdx,r9
       je        near ptr M00_L58
       mov       [rbp-0B0],r12
       jmp       near ptr M00_L22
M00_L27:
       mov       edx,[r15+0C]
       mov       [r15+8],edx
M00_L28:
       mov       dword ptr [rbp-40],1
       jmp       near ptr M00_L62
M00_L29:
       mov       r15,[rbp-98]
       cmp       [r15],r13
       jne       near ptr M00_L32
M00_L30:
       mov       r8d,[r15+8]
       inc       r8d
       cmp       r8d,[r15+0C]
       jae       near ptr M00_L34
       mov       [r15+8],r8d
       mov       edx,[r15+8]
       cmp       edx,[r15+0C]
       mov       [rbp-0B8],rax
       jae       near ptr M00_L41
       mov       rsi,[r15+10]
       mov       r10d,[r15+8]
       cmp       r10d,[rsi+8]
       jae       near ptr M00_L60
       mov       edx,r10d
       mov       rsi,[rsi+rdx*8+10]
       mov       rdx,rsi
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       mov       rcx,rdi
       mov       r8,[rbp-0B8]
       mov       [rbp-0D0],rax
       mov       rdx,rax
       mov       r11,7FFEFF6414F0
       call      qword ptr [r11]
       test      eax,eax
       mov       rax,[rbp-0B8]
       jg        short M00_L30
       mov       r12,[rbp-0D0]
       mov       [rbp-0B8],r12
       mov       r12,rsi
       mov       rax,[rbp-0B8]
       jmp       near ptr M00_L30
M00_L31:
       mov       r12,[rbp-0D0]
       mov       rax,r12
       mov       r12,rsi
M00_L32:
       cmp       [r15],r13
       jne       near ptr M00_L40
       mov       r8d,[r15+8]
       inc       r8d
       cmp       r8d,[r15+0C]
       jae       short M00_L34
       mov       [r15+8],r8d
       mov       ecx,[r15+8]
       cmp       ecx,[r15+0C]
       jae       near ptr M00_L41
       mov       rsi,[r15+10]
       mov       r10d,[r15+8]
       cmp       r10d,[rsi+8]
       jae       near ptr M00_L60
       mov       ecx,r10d
       mov       rsi,[rsi+rcx*8+10]
       mov       [rbp-0B8],rax
M00_L33:
       mov       rdx,rsi
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       mov       rcx,rdi
       mov       r8,[rbp-0B8]
       mov       [rbp-0D0],rax
       mov       rdx,rax
       mov       r11,7FFEFF6414F0
       call      qword ptr [r11]
       test      eax,eax
       mov       rax,[rbp-0B8]
       jg        short M00_L32
       jmp       near ptr M00_L31
M00_L34:
       mov       ecx,[r15+0C]
       mov       [r15+8],ecx
       jmp       near ptr M00_L28
M00_L35:
       mov       ecx,[r12+0C]
       mov       [r12+8],ecx
       jmp       near ptr M00_L61
M00_L36:
       mov       rcx,r12
       mov       r11,7FFEFF6414B8
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M00_L61
       jmp       near ptr M00_L03
M00_L37:
       call      qword ptr [7FFF001548D0]
       int       3
M00_L38:
       mov       rcx,r12
       mov       r11,7FFEFF6414C0
       call      qword ptr [r11]
       mov       r12,rax
M00_L39:
       mov       [rbp-0B0],r12
       mov       rdx,r12
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       mov       r12,[rbp-0B0]
       jmp       near ptr M00_L04
M00_L40:
       mov       [rbp-0B8],rax
       mov       rcx,r15
       mov       r11,7FFEFF6414E0
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M00_L28
       mov       rcx,r15
       mov       r11,7FFEFF6414E8
       call      qword ptr [r11]
       mov       rsi,rax
       jmp       near ptr M00_L33
M00_L41:
       mov       ecx,[r15+8]
       call      qword ptr [7FFF001548D0]
       int       3
M00_L42:
       mov       ecx,2
       call      qword ptr [7FFEFFEE5B30]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       rdx,rax
       jmp       near ptr M00_L10
M00_L43:
       call      qword ptr [7FFEFF975DA0]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rcx,rax
       jmp       near ptr M00_L11
M00_L44:
       xor       eax,eax
       mov       [rbp-0B0],r12
       jmp       near ptr M00_L15
M00_L45:
       mov       ecx,1
       mov       [rbp-0B8],rax
       jmp       near ptr M00_L08
M00_L46:
       test      rax,rax
       je        short M00_L47
       mov       ecx,0FFFFFFFF
       mov       [rbp-0B8],rax
       jmp       near ptr M00_L08
M00_L47:
       xor       ecx,ecx
       mov       [rbp-0B8],rax
       jmp       near ptr M00_L08
M00_L48:
       mov       [rbp-0B8],rax
       mov       rcx,r15
       mov       r11,7FFEFF6414C8
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M00_L28
       mov       rcx,r15
       mov       r11,7FFEFF6414D0
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       short M00_L50
M00_L49:
       mov       [rbp-0B8],rax
M00_L50:
       mov       [rbp-0C0],rdx
       mov       r14,[rbp-0A8]
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       mov       [rbp-0C8],rax
       mov       rax,[rbp-0B8]
       mov       r15,[rbp-98]
       jmp       short M00_L52
M00_L51:
       mov       [rbp-0C8],r8
M00_L52:
       mov       rcx,rdi
       mov       [rbp-0B8],rax
       mov       r8,rax
       mov       rdx,[rbp-0C8]
       mov       r11,7FFEFF6414D8
       call      qword ptr [r11]
       mov       ecx,eax
       mov       [rbp-0B0],r12
       jmp       near ptr M00_L18
M00_L53:
       mov       [rbp-0B8],rax
       test      rax,rax
       jne       short M00_L54
       mov       rax,[rbp-0B8]
       xor       ecx,ecx
       mov       [rbp-0C8],r8
       mov       [rbp-0B8],rax
       mov       [rbp-0B0],r12
       jmp       near ptr M00_L18
M00_L54:
       mov       rax,[rbp-0B8]
       mov       ecx,0FFFFFFFF
       mov       [rbp-0C8],r8
       mov       [rbp-0B8],rax
       mov       [rbp-0B0],r12
       jmp       near ptr M00_L18
M00_L55:
       mov       ecx,1
       mov       [rbp-0C8],r8
       mov       [rbp-0B8],rax
       mov       [rbp-0B0],r12
       jmp       near ptr M00_L18
M00_L56:
       mov       ecx,2
       call      qword ptr [7FFEFFEE5B30]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       r10,rax
       jmp       near ptr M00_L20
M00_L57:
       call      qword ptr [7FFEFF975DA0]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rcx,rax
       jmp       near ptr M00_L21
M00_L58:
       xor       eax,eax
       mov       [rbp-0B0],r12
       jmp       near ptr M00_L25
M00_L59:
       mov       ecx,[r15+8]
       call      qword ptr [7FFF001548D0]
       int       3
M00_L60:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L61:
       xor       ecx,ecx
       mov       [rbp-40],ecx
       xor       r12d,r12d
       mov       r15,[rbp-98]
M00_L62:
       cmp       [r15],r13
       jne       near ptr M00_L70
M00_L63:
       cmp       byte ptr [rbp-40],0
       je        near ptr M00_L71
       mov       [rbp-58],r12
       mov       rbx,[rbp+10]
       mov       r15,[rbx+60]
       mov       rdx,[rbp-58]
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [r15+8],rax
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
M00_L64:
       mov       r13,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,r13
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       dword ptr [r12+8],0FFFFFFFF
       mov       [r12+0C],r14d
       lea       rcx,[r12+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L02
M00_L65:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdx,1B73F400EB0
       mov       rdx,[rdx]
       mov       rcx,r14
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonOrderByBenchmark>b__12_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFEFF6F6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1B73F400EB8
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L66:
       mov       ecx,11
       call      qword ptr [7FFEFF977DF8]
       int       3
M00_L67:
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L01
M00_L68:
       mov       rcx,rdi
       mov       r11,7FFEFF641500
       call      qword ptr [r11]
       mov       r12,rax
       jmp       near ptr M00_L02
M00_L69:
       mov       r11,7FFEFF6414B0
       call      qword ptr [r11]
       mov       r12,rax
       jmp       near ptr M00_L02
M00_L70:
       mov       rcx,r15
       mov       r11,7FFEFF6414F8
       call      qword ptr [r11]
       jmp       near ptr M00_L63
M00_L71:
       call      qword ptr [7FFEFFEEEC88]
       int       3
       sub       rsp,38
       vzeroupper
       cmp       qword ptr [rbp-98],0
       je        short M00_L72
       mov       r13,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       r15,[rbp-98]
       cmp       [r15],r13
       je        short M00_L72
       mov       rcx,r15
       mov       r11,7FFEFF6414F8
       call      qword ptr [r11]
M00_L72:
       nop
       add       rsp,38
       ret
; Total bytes of code 2884
```
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonOrderByBenchmark>b__12_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       mov       rax,[rdx+30]
       ret
; Total bytes of code 5
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FFF51600D78]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       ecx,ebx
       and       ecx,0FFFFFF
       mov       edx,ecx
       mov       r8d,ebx
       sar       r8d,18
       jne       short M02_L01
       cmp       [rax],ecx
       jle       short M02_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M02_L03
M02_L00:
       add       rsp,20
       pop       rbx
       ret
M02_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M02_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M02_L00
M02_L02:
       cmp       [rax+4],edx
       jle       short M02_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M02_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M02_L03
       jmp       short M02_L00
M02_L03:
       mov       ecx,ebx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax]
; Total bytes of code 130
```
```assembly
; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       push      rsi
       push      rbx
       sub       rsp,28
       call      qword ptr [7FFF515E87D0]
       mov       rbx,rax
       mov       rsi,rbx
       call      qword ptr [7FFF515FFA88]
       mov       rdx,rax
       test      rsi,rsi
       je        short M03_L00
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFF51600C28]
       mov       rax,[rbx]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M03_L00:
       call      qword ptr [7FFF515FE468]
       int       3
; Total bytes of code 61
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M04_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L00:
       call      qword ptr [7FFEFFEE6628]
       int       3
; Total bytes of code 44
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M05_L00
       ret
M05_L00:
       jmp       qword ptr [7FFEFF6F5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.PersonOrderByBenchmark()
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
       xor       eax,eax
       mov       [rbp-58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp-40],rax
       mov       rbx,rcx
       lea       rcx,[rbp-90]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rcx,rsp
       mov       [rbp-78],rcx
       mov       rcx,rbp
       mov       [rbp-68],rcx
       mov       [rbp+10],rbx
       mov       rdi,[rbx+288]
       mov       rcx,271C1C00ED8
       mov       r14,[rcx]
       test      r14,r14
       je        near ptr M00_L63
M00_L00:
       mov       rcx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [r15+10],eax
       lea       rcx,[r15+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        near ptr M00_L64
       xor       ecx,ecx
       mov       [r15+20],rcx
       lea       rcx,[r15+28]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,27196C00A08
       mov       rdx,[rcx]
       lea       rcx,[r15+30]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [r15+48],0
       mov       rcx,[r15+18]
       mov       r11,offset MT_System.Collections.ObjectModel.Collection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],r11
       jne       near ptr M00_L65
       mov       rcx,[rcx+8]
       mov       r11,7FFEFF6318E8
       call      qword ptr [r11]
       mov       rdi,rax
M00_L01:
       mov       [rbp-98],rdi
       mov       r14,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rdi],r14
       jne       near ptr M00_L35
       mov       ecx,[rdi+8]
       inc       ecx
       cmp       ecx,[rdi+0C]
       jae       near ptr M00_L34
       mov       [rdi+8],ecx
M00_L02:
       mov       r13,[r15+30]
       mov       [rbp-0A0],r13
       mov       r12,[r15+28]
       mov       [rbp-0A8],r12
       cmp       [rdi],r14
       jne       near ptr M00_L37
       mov       ecx,[rdi+8]
       cmp       ecx,[rdi+0C]
       jae       near ptr M00_L36
       mov       rax,[rdi+10]
       cmp       ecx,[rax+8]
       jae       near ptr M00_L59
       mov       rdi,[rax+rcx*8+10]
       mov       rcx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonOrderByBenchmark>b__12_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [r12+18],rcx
       jne       near ptr M00_L38
       mov       rax,[rdi+30]
M00_L03:
       cmp       byte ptr [r15+48],0
       jne       near ptr M00_L28
       test      r12,r12
       je        near ptr M00_L19
       test      r13,r13
       je        near ptr M00_L19
       mov       r15,[rbp-98]
       cmp       [r15],r14
       jne       near ptr M00_L19
       mov       rcx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonOrderByBenchmark>b__12_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [r12+18],rcx
       jne       near ptr M00_L19
       mov       rcx,offset MT_System.Collections.Generic.GenericComparer<System.String>
       cmp       [r13],rcx
       jne       near ptr M00_L19
       jmp       short M00_L08
M00_L04:
       mov       r13,[rbp-0C0]
       mov       rax,r12
       mov       [rbp-0B0],r13
       mov       rdi,[rbp-0B0]
       jmp       short M00_L08
M00_L05:
       cmp       rdx,r9
       je        near ptr M00_L43
       mov       [rbp-0B0],rdi
       jmp       near ptr M00_L11
M00_L06:
       xor       ecx,ecx
M00_L07:
       test      ecx,ecx
       mov       rax,[rbp-0B8]
       mov       r15,[rbp-98]
       jge       short M00_L04
M00_L08:
       mov       edx,[r15+8]
       inc       edx
       cmp       edx,[r15+0C]
       jae       near ptr M00_L26
       mov       [r15+8],edx
       mov       r8d,[r15+8]
       cmp       r8d,[r15+0C]
       jae       near ptr M00_L58
       mov       r12,[r15+10]
       cmp       r8d,[r12+8]
       jae       near ptr M00_L59
       mov       ecx,r8d
       mov       r13,[r12+rcx*8+10]
       mov       [rbp-0C0],r13
       mov       r12,[r13+30]
       test      r12,r12
       je        near ptr M00_L45
       test      rax,rax
       je        near ptr M00_L44
       mov       [rbp-0B8],rax
       cmp       r12,rax
       je        short M00_L06
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],2
       jle       near ptr M00_L41
       mov       rcx,[rcx+240]
       mov       rdx,[rcx+10]
       test      rdx,rdx
       je        near ptr M00_L41
M00_L09:
       mov       rcx,[rdx+10]
       test      rcx,rcx
       jne       short M00_L10
       mov       rcx,27196C00110
       mov       rcx,[rcx]
       test      rcx,rcx
       jne       short M00_L10
       mov       rcx,27196C000F0
       mov       rcx,[rcx]
       test      rcx,rcx
       je        near ptr M00_L42
M00_L10:
       mov       rdx,[rcx]
       mov       rdx,[rdx+48]
       call      qword ptr [rdx+30]
       cmp       [rax],al
       lea       rdx,[r12+0C]
       mov       [rbp-0C8],r12
       mov       r8d,[r12+8]
       mov       r10,[rbp-0B8]
       lea       r9,[r10+0C]
       mov       [rbp-0B8],r10
       mov       r11d,[r10+8]
       cmp       r8d,r11d
       je        near ptr M00_L05
       mov       [rbp-0B0],rdi
M00_L11:
       mov       [rbp-48],rdx
       mov       [rbp-50],r9
       mov       rcx,[rax+20]
       mov       [rsp+20],r11d
       xor       eax,eax
       mov       [rsp+28],eax
       mov       rax,7FFEFF95B650
       mov       [rbp-80],rax
       lea       rax,[M00_L12]
       mov       [rbp-70],rax
       lea       rax,[rbp-90]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFF5F2F93A0
       call      rax
M00_L12:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFF5F64F778],0
       je        short M00_L13
       call      qword ptr [7FFF5F63D608]; CORINFO_HELP_STOP_FOR_GC
M00_L13:
       mov       rcx,[rbp-88]
       mov       [rsi+8],rcx
       xor       ecx,ecx
       mov       [rbp-48],rcx
       mov       [rbp-50],rcx
M00_L14:
       mov       ecx,eax
       mov       rdi,[rbp-0B0]
       mov       r12,[rbp-0C8]
       jmp       near ptr M00_L07
M00_L15:
       mov       rdx,[rbp-0C0]
       mov       r10,[rbp-0C8]
       mov       r11,r10
       mov       rdi,rdx
       mov       rax,r11
       jmp       short M00_L19
M00_L16:
       cmp       rdx,r9
       je        near ptr M00_L57
       mov       [rbp-0B0],rdi
       jmp       near ptr M00_L22
M00_L17:
       xor       ecx,ecx
       mov       [rbp-0B0],rdi
M00_L18:
       test      ecx,ecx
       mov       rax,[rbp-0B8]
       mov       rdi,[rbp-0B0]
       mov       r12,[rbp-0A8]
       jge       short M00_L15
M00_L19:
       mov       r15,[rbp-98]
       cmp       [r15],r14
       jne       near ptr M00_L47
       mov       edx,[r15+8]
       inc       edx
       cmp       edx,[r15+0C]
       jae       near ptr M00_L26
       mov       [r15+8],edx
       mov       ecx,[r15+8]
       cmp       ecx,[r15+0C]
       jae       near ptr M00_L58
       mov       rcx,[r15+10]
       mov       r8d,[r15+8]
       cmp       r8d,[rcx+8]
       jae       near ptr M00_L59
       mov       edx,r8d
       mov       rcx,[rcx+rdx*8+10]
       mov       rdx,rcx
       mov       rcx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonOrderByBenchmark>b__12_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [r12+18],rcx
       jne       near ptr M00_L48
       mov       r15,[rbp-98]
       mov       [rbp-0C0],rdx
       mov       rcx,[rdx+30]
       mov       r8,rcx
       mov       rcx,offset MT_System.Collections.Generic.GenericComparer<System.String>
       cmp       [r13],rcx
       mov       r13,[rbp-0A0]
       jne       near ptr M00_L50
       test      r8,r8
       je        near ptr M00_L52
       test      rax,rax
       je        near ptr M00_L54
       mov       [rbp-0C8],r8
       mov       [rbp-0B8],rax
       cmp       r8,rax
       je        near ptr M00_L17
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],2
       jle       near ptr M00_L55
       mov       rcx,[rcx+240]
       mov       r10,[rcx+10]
       test      r10,r10
       je        near ptr M00_L55
M00_L20:
       mov       rcx,[r10+10]
       test      rcx,rcx
       jne       short M00_L21
       mov       rcx,27196C00110
       mov       rcx,[rcx]
       test      rcx,rcx
       jne       short M00_L21
       mov       rcx,27196C000F0
       mov       rcx,[rcx]
       test      rcx,rcx
       je        near ptr M00_L56
M00_L21:
       mov       r10,[rcx]
       mov       r10,[r10+48]
       call      qword ptr [r10+30]
       cmp       [rax],al
       mov       r10,[rbp-0C8]
       lea       rdx,[r10+0C]
       mov       [rbp-0C8],r10
       mov       r8d,[r10+8]
       mov       r11,[rbp-0B8]
       lea       r9,[r11+0C]
       mov       [rbp-0B8],r11
       mov       ecx,[r11+8]
       cmp       r8d,ecx
       je        near ptr M00_L16
       mov       [rbp-0B0],rdi
M00_L22:
       mov       [rbp-48],rdx
       mov       [rbp-50],r9
       mov       rax,[rax+20]
       mov       [rsp+20],ecx
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rax
       mov       rax,7FFEFF95B650
       mov       [rbp-80],rax
       lea       rax,[M00_L23]
       mov       [rbp-70],rax
       lea       rax,[rbp-90]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFF5F2F93A0
       call      rax
M00_L23:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFF5F64F778],0
       je        short M00_L24
       call      qword ptr [7FFF5F63D608]; CORINFO_HELP_STOP_FOR_GC
M00_L24:
       mov       rcx,[rbp-88]
       mov       [rsi+8],rcx
       xor       ecx,ecx
       mov       [rbp-48],rcx
       mov       [rbp-50],rcx
       mov       r13,[rbp-0A0]
       mov       r15,[rbp-98]
M00_L25:
       mov       ecx,eax
       jmp       near ptr M00_L18
M00_L26:
       mov       edx,[r15+0C]
       mov       [r15+8],edx
M00_L27:
       mov       dword ptr [rbp-40],1
       jmp       near ptr M00_L61
M00_L28:
       mov       r15,[rbp-98]
       cmp       [r15],r14
       jne       near ptr M00_L31
M00_L29:
       mov       r8d,[r15+8]
       inc       r8d
       cmp       r8d,[r15+0C]
       jae       near ptr M00_L33
       mov       [r15+8],r8d
       mov       edx,[r15+8]
       cmp       edx,[r15+0C]
       mov       [rbp-0B8],rax
       jae       near ptr M00_L40
       mov       rsi,[r15+10]
       mov       r10d,[r15+8]
       cmp       r10d,[rsi+8]
       jae       near ptr M00_L59
       mov       edx,r10d
       mov       rsi,[rsi+rdx*8+10]
       mov       rdx,rsi
       mov       rcx,[r12+8]
       call      qword ptr [r12+18]
       mov       rcx,r13
       mov       r8,[rbp-0B8]
       mov       [rbp-0D0],rax
       mov       rdx,rax
       mov       r11,7FFEFF6318D8
       call      qword ptr [r11]
       test      eax,eax
       mov       rax,[rbp-0B8]
       jg        short M00_L29
       mov       rdi,[rbp-0D0]
       mov       [rbp-0B8],rdi
       mov       rdi,rsi
       mov       rax,[rbp-0B8]
       jmp       near ptr M00_L29
M00_L30:
       mov       rdi,[rbp-0D0]
       mov       rax,rdi
       mov       rdi,rsi
M00_L31:
       cmp       [r15],r14
       jne       near ptr M00_L39
       mov       r8d,[r15+8]
       inc       r8d
       cmp       r8d,[r15+0C]
       jae       short M00_L33
       mov       [r15+8],r8d
       mov       ecx,[r15+8]
       cmp       ecx,[r15+0C]
       jae       near ptr M00_L40
       mov       rsi,[r15+10]
       mov       r10d,[r15+8]
       cmp       r10d,[rsi+8]
       jae       near ptr M00_L59
       mov       ecx,r10d
       mov       rsi,[rsi+rcx*8+10]
       mov       [rbp-0B8],rax
M00_L32:
       mov       rdx,rsi
       mov       rcx,[r12+8]
       call      qword ptr [r12+18]
       mov       rcx,r13
       mov       r8,[rbp-0B8]
       mov       [rbp-0D0],rax
       mov       rdx,rax
       mov       r11,7FFEFF6318D8
       call      qword ptr [r11]
       test      eax,eax
       mov       rax,[rbp-0B8]
       jg        near ptr M00_L31
       jmp       near ptr M00_L30
M00_L33:
       mov       ecx,[r15+0C]
       mov       [r15+8],ecx
       jmp       near ptr M00_L27
M00_L34:
       mov       ecx,[rdi+0C]
       mov       [rdi+8],ecx
       jmp       near ptr M00_L60
M00_L35:
       mov       rcx,rdi
       mov       r11,7FFEFF6318A0
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M00_L60
       jmp       near ptr M00_L02
M00_L36:
       call      qword ptr [7FFF001D4A98]
       int       3
M00_L37:
       mov       rcx,rdi
       mov       r11,7FFEFF6318A8
       call      qword ptr [r11]
       mov       rdi,rax
M00_L38:
       mov       [rbp-0B0],rdi
       mov       rdx,rdi
       mov       rcx,[r12+8]
       call      qword ptr [r12+18]
       mov       rdi,[rbp-0B0]
       jmp       near ptr M00_L03
M00_L39:
       mov       [rbp-0B8],rax
       mov       rcx,r15
       mov       r11,7FFEFF6318C8
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M00_L27
       mov       rcx,r15
       mov       r11,7FFEFF6318D0
       call      qword ptr [r11]
       mov       rsi,rax
       jmp       near ptr M00_L32
M00_L40:
       mov       ecx,[r15+8]
       call      qword ptr [7FFF001D4A98]
       int       3
M00_L41:
       mov       ecx,2
       call      qword ptr [7FFEFFE7C8E8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       rdx,rax
       jmp       near ptr M00_L09
M00_L42:
       call      qword ptr [7FFEFF965DA0]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rcx,rax
       jmp       near ptr M00_L10
M00_L43:
       xor       eax,eax
       mov       [rbp-0B0],rdi
       jmp       near ptr M00_L14
M00_L44:
       mov       ecx,1
       mov       [rbp-0B8],rax
       jmp       near ptr M00_L07
M00_L45:
       test      rax,rax
       je        short M00_L46
       mov       ecx,0FFFFFFFF
       mov       [rbp-0B8],rax
       jmp       near ptr M00_L07
M00_L46:
       xor       ecx,ecx
       mov       [rbp-0B8],rax
       jmp       near ptr M00_L07
M00_L47:
       mov       [rbp-0B8],rax
       mov       rcx,r15
       mov       r11,7FFEFF6318B0
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M00_L27
       mov       rcx,r15
       mov       r11,7FFEFF6318B8
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       short M00_L49
M00_L48:
       mov       [rbp-0B8],rax
M00_L49:
       mov       [rbp-0C0],rdx
       mov       r12,[rbp-0A8]
       mov       rcx,[r12+8]
       call      qword ptr [r12+18]
       mov       [rbp-0C8],rax
       mov       rax,[rbp-0B8]
       mov       r15,[rbp-98]
       jmp       short M00_L51
M00_L50:
       mov       [rbp-0C8],r8
M00_L51:
       mov       rcx,r13
       mov       [rbp-0B8],rax
       mov       r8,rax
       mov       rdx,[rbp-0C8]
       mov       r11,7FFEFF6318C0
       call      qword ptr [r11]
       mov       ecx,eax
       mov       [rbp-0B0],rdi
       jmp       near ptr M00_L18
M00_L52:
       mov       [rbp-0B8],rax
       test      rax,rax
       jne       short M00_L53
       mov       rax,[rbp-0B8]
       xor       ecx,ecx
       mov       [rbp-0C8],r8
       mov       [rbp-0B8],rax
       mov       [rbp-0B0],rdi
       jmp       near ptr M00_L18
M00_L53:
       mov       rax,[rbp-0B8]
       mov       ecx,0FFFFFFFF
       mov       [rbp-0C8],r8
       mov       [rbp-0B8],rax
       mov       [rbp-0B0],rdi
       jmp       near ptr M00_L18
M00_L54:
       mov       ecx,1
       mov       [rbp-0C8],r8
       mov       [rbp-0B8],rax
       mov       [rbp-0B0],rdi
       jmp       near ptr M00_L18
M00_L55:
       mov       ecx,2
       call      qword ptr [7FFEFFE7C8E8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       r10,rax
       jmp       near ptr M00_L20
M00_L56:
       call      qword ptr [7FFEFF965DA0]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rcx,rax
       jmp       near ptr M00_L21
M00_L57:
       xor       eax,eax
       mov       [rbp-0B0],rdi
       jmp       near ptr M00_L25
M00_L58:
       mov       ecx,[r15+8]
       call      qword ptr [7FFF001D4A98]
       int       3
M00_L59:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L60:
       xor       ecx,ecx
       mov       [rbp-40],ecx
       xor       edi,edi
       mov       r15,[rbp-98]
M00_L61:
       cmp       [r15],r14
       jne       near ptr M00_L66
M00_L62:
       cmp       byte ptr [rbp-40],0
       je        near ptr M00_L67
       mov       [rbp-58],rdi
       mov       rbx,[rbp+10]
       mov       r15,[rbx+60]
       mov       rdx,[rbp-58]
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [r15+8],rax
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
M00_L63:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdx,271C1C00ED0
       mov       rdx,[rdx]
       mov       rcx,r14
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonOrderByBenchmark>b__12_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFEFF6E6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,271C1C00ED8
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L64:
       mov       ecx,11
       call      qword ptr [7FFEFF967DF8]
       int       3
M00_L65:
       mov       r11,7FFEFF631898
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L01
M00_L66:
       mov       rcx,r15
       mov       r11,7FFEFF6318E0
       call      qword ptr [r11]
       jmp       near ptr M00_L62
M00_L67:
       call      qword ptr [7FFEFFEFFAF8]
       int       3
       sub       rsp,38
       vzeroupper
       cmp       qword ptr [rbp-98],0
       je        short M00_L68
       mov       r14,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       r15,[rbp-98]
       cmp       [r15],r14
       je        short M00_L68
       mov       rcx,r15
       mov       r11,7FFEFF6318E0
       call      qword ptr [r11]
M00_L68:
       nop
       add       rsp,38
       ret
; Total bytes of code 2743
```
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonOrderByBenchmark>b__12_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       mov       rax,[rdx+30]
       ret
; Total bytes of code 5
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FFF51600D78]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       ecx,ebx
       and       ecx,0FFFFFF
       mov       edx,ecx
       mov       r8d,ebx
       sar       r8d,18
       jne       short M02_L01
       cmp       [rax],ecx
       jle       short M02_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M02_L03
M02_L00:
       add       rsp,20
       pop       rbx
       ret
M02_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M02_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M02_L00
M02_L02:
       cmp       [rax+4],edx
       jle       short M02_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M02_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M02_L03
       jmp       short M02_L00
M02_L03:
       mov       ecx,ebx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax]
; Total bytes of code 130
```
```assembly
; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       push      rsi
       push      rbx
       sub       rsp,28
       call      qword ptr [7FFF515E87D0]
       mov       rbx,rax
       mov       rsi,rbx
       call      qword ptr [7FFF515FFA88]
       mov       rdx,rax
       test      rsi,rsi
       je        short M03_L00
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFF51600C28]
       mov       rax,[rbx]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M03_L00:
       call      qword ptr [7FFF515FE468]
       int       3
; Total bytes of code 61
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M04_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L00:
       call      qword ptr [7FFEFFEF63A0]
       int       3
; Total bytes of code 44
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.PersonValOrderBy()
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
       xor       eax,eax
       mov       [rbp-58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp-40],rax
       mov       rbx,rcx
       lea       rcx,[rbp-90]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rcx,rsp
       mov       [rbp-78],rcx
       mov       rcx,rbp
       mov       [rbp-68],rcx
       mov       [rbp+10],rbx
       mov       rdi,[rbx+280]
       mov       rcx,180FE000E70
       mov       r14,[rcx]
       test      r14,r14
       je        near ptr M00_L60
M00_L00:
       mov       rcx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [r15+10],eax
       lea       rcx,[r15+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        near ptr M00_L58
       xor       ecx,ecx
       mov       [r15+20],rcx
       lea       rcx,[r15+28]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,180D1000A08
       mov       rdx,[rcx]
       lea       rcx,[r15+30]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [r15+48],0
       mov       rcx,[r15+18]
       mov       rax,offset MT_System.Collections.ObjectModel.Collection<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord>
       cmp       [rcx],rax
       jne       near ptr M00_L63
       mov       rdi,[rcx+8]
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord[]
       cmp       [rdi],rcx
       jne       near ptr M00_L62
       mov       r14d,[rdi+8]
       test      r14d,r14d
       jne       near ptr M00_L59
       mov       r13,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord>
       mov       rcx,r13
       test      byte ptr [7FFF000193F0],1
       je        near ptr M00_L61
M00_L01:
       mov       rcx,180FE000E98
       mov       r12,[rcx]
M00_L02:
       mov       [rbp-98],r12
       mov       r13,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord>
       cmp       [r12],r13
       jne       near ptr M00_L30
       mov       ecx,[r12+8]
       inc       ecx
       cmp       ecx,[r12+0C]
       jae       near ptr M00_L29
       mov       [r12+8],ecx
M00_L03:
       mov       rdi,[r15+30]
       mov       [rbp-0A0],rdi
       mov       r14,[r15+28]
       mov       [rbp-0A8],r14
       cmp       [r12],r13
       jne       near ptr M00_L32
       mov       ecx,[r12+8]
       cmp       ecx,[r12+0C]
       jae       near ptr M00_L31
       mov       rax,[r12+10]
       cmp       ecx,[rax+8]
       jae       near ptr M00_L54
       mov       r12,[rax+rcx*8+10]
       mov       rcx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonValOrderBy>b__14_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       cmp       [r14+18],rcx
       jne       near ptr M00_L33
       mov       rax,[r12+30]
M00_L04:
       cmp       byte ptr [r15+48],0
       jne       near ptr M00_L34
       test      r14,r14
       je        near ptr M00_L20
       test      rdi,rdi
       je        near ptr M00_L20
       mov       r15,[rbp-98]
       cmp       [r15],r13
       jne       near ptr M00_L20
       mov       rcx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonValOrderBy>b__14_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       cmp       [r14+18],rcx
       jne       near ptr M00_L20
       mov       rcx,offset MT_System.Collections.Generic.GenericComparer<System.String>
       cmp       [rdi],rcx
       jne       near ptr M00_L20
       jmp       short M00_L09
M00_L05:
       mov       rdi,[rbp-0C0]
       mov       rax,r14
       mov       [rbp-0B0],rdi
       mov       r12,[rbp-0B0]
       jmp       short M00_L09
M00_L06:
       cmp       rdx,r9
       je        near ptr M00_L38
       mov       [rbp-0B0],r12
       jmp       near ptr M00_L12
M00_L07:
       xor       ecx,ecx
M00_L08:
       test      ecx,ecx
       mov       rax,[rbp-0B8]
       mov       r15,[rbp-98]
       jge       short M00_L05
M00_L09:
       mov       edx,[r15+8]
       inc       edx
       cmp       edx,[r15+0C]
       jae       near ptr M00_L27
       mov       [r15+8],edx
       mov       r8d,[r15+8]
       cmp       r8d,[r15+0C]
       jae       near ptr M00_L53
       mov       r14,[r15+10]
       cmp       r8d,[r14+8]
       jae       near ptr M00_L54
       mov       ecx,r8d
       mov       rdi,[r14+rcx*8+10]
       mov       [rbp-0C0],rdi
       mov       r14,[rdi+30]
       test      r14,r14
       je        near ptr M00_L40
       test      rax,rax
       je        near ptr M00_L39
       mov       [rbp-0B8],rax
       cmp       r14,rax
       je        short M00_L07
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],2
       jle       near ptr M00_L36
       mov       rcx,[rcx+240]
       mov       rdx,[rcx+10]
       test      rdx,rdx
       je        near ptr M00_L36
M00_L10:
       mov       rcx,[rdx+10]
       test      rcx,rcx
       jne       short M00_L11
       mov       rcx,180D1000110
       mov       rcx,[rcx]
       test      rcx,rcx
       jne       short M00_L11
       mov       rcx,180D10000F0
       mov       rcx,[rcx]
       test      rcx,rcx
       je        near ptr M00_L37
M00_L11:
       mov       rdx,[rcx]
       mov       rdx,[rdx+48]
       call      qword ptr [rdx+30]
       cmp       [rax],al
       lea       rdx,[r14+0C]
       mov       [rbp-0C8],r14
       mov       r8d,[r14+8]
       mov       r10,[rbp-0B8]
       lea       r9,[r10+0C]
       mov       [rbp-0B8],r10
       mov       r11d,[r10+8]
       cmp       r8d,r11d
       je        near ptr M00_L06
       mov       [rbp-0B0],r12
M00_L12:
       mov       [rbp-48],rdx
       mov       [rbp-50],r9
       mov       rcx,[rax+20]
       mov       [rsp+20],r11d
       xor       eax,eax
       mov       [rsp+28],eax
       mov       rax,7FFEFF97B650
       mov       [rbp-80],rax
       lea       rax,[M00_L13]
       mov       [rbp-70],rax
       lea       rax,[rbp-90]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFF5F2F93A0
       call      rax
M00_L13:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFF5F64F778],0
       je        short M00_L14
       call      qword ptr [7FFF5F63D608]; CORINFO_HELP_STOP_FOR_GC
M00_L14:
       mov       rcx,[rbp-88]
       mov       [rsi+8],rcx
       xor       ecx,ecx
       mov       [rbp-48],rcx
       mov       [rbp-50],rcx
M00_L15:
       mov       ecx,eax
       mov       r12,[rbp-0B0]
       mov       r14,[rbp-0C8]
       jmp       near ptr M00_L08
M00_L16:
       mov       rdx,[rbp-0C0]
       mov       r10,[rbp-0C8]
       mov       r11,r10
       mov       r12,rdx
       mov       rax,r11
       jmp       short M00_L20
M00_L17:
       cmp       rdx,r9
       je        near ptr M00_L52
       mov       [rbp-0B0],r12
       jmp       near ptr M00_L23
M00_L18:
       xor       ecx,ecx
       mov       [rbp-0B0],r12
M00_L19:
       test      ecx,ecx
       mov       rax,[rbp-0B8]
       mov       r12,[rbp-0B0]
       mov       r14,[rbp-0A8]
       jge       short M00_L16
M00_L20:
       mov       r15,[rbp-98]
       cmp       [r15],r13
       jne       near ptr M00_L42
       mov       edx,[r15+8]
       inc       edx
       cmp       edx,[r15+0C]
       jae       near ptr M00_L27
       mov       [r15+8],edx
       mov       ecx,[r15+8]
       cmp       ecx,[r15+0C]
       jae       near ptr M00_L53
       mov       rcx,[r15+10]
       mov       r8d,[r15+8]
       cmp       r8d,[rcx+8]
       jae       near ptr M00_L54
       mov       edx,r8d
       mov       rcx,[rcx+rdx*8+10]
       mov       rdx,rcx
       mov       rcx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonValOrderBy>b__14_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       cmp       [r14+18],rcx
       jne       near ptr M00_L43
       mov       r15,[rbp-98]
       mov       [rbp-0C0],rdx
       mov       rcx,[rdx+30]
       mov       r8,rcx
       mov       rcx,offset MT_System.Collections.Generic.GenericComparer<System.String>
       cmp       [rdi],rcx
       mov       rdi,[rbp-0A0]
       jne       near ptr M00_L45
       test      r8,r8
       je        near ptr M00_L47
       test      rax,rax
       je        near ptr M00_L49
       mov       [rbp-0C8],r8
       mov       [rbp-0B8],rax
       cmp       r8,rax
       je        near ptr M00_L18
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],2
       jle       near ptr M00_L50
       mov       rcx,[rcx+240]
       mov       r10,[rcx+10]
       test      r10,r10
       je        near ptr M00_L50
M00_L21:
       mov       rcx,[r10+10]
       test      rcx,rcx
       jne       short M00_L22
       mov       rcx,180D1000110
       mov       rcx,[rcx]
       test      rcx,rcx
       jne       short M00_L22
       mov       rcx,180D10000F0
       mov       rcx,[rcx]
       test      rcx,rcx
       je        near ptr M00_L51
M00_L22:
       mov       r10,[rcx]
       mov       r10,[r10+48]
       call      qword ptr [r10+30]
       cmp       [rax],al
       mov       r10,[rbp-0C8]
       lea       rdx,[r10+0C]
       mov       [rbp-0C8],r10
       mov       r8d,[r10+8]
       mov       r11,[rbp-0B8]
       lea       r9,[r11+0C]
       mov       [rbp-0B8],r11
       mov       ecx,[r11+8]
       cmp       r8d,ecx
       je        near ptr M00_L17
       mov       [rbp-0B0],r12
M00_L23:
       mov       [rbp-48],rdx
       mov       [rbp-50],r9
       mov       rax,[rax+20]
       mov       [rsp+20],ecx
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rax
       mov       rax,7FFEFF97B650
       mov       [rbp-80],rax
       lea       rax,[M00_L24]
       mov       [rbp-70],rax
       lea       rax,[rbp-90]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFF5F2F93A0
       call      rax
M00_L24:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFF5F64F778],0
       je        short M00_L25
       call      qword ptr [7FFF5F63D608]; CORINFO_HELP_STOP_FOR_GC
M00_L25:
       mov       rcx,[rbp-88]
       mov       [rsi+8],rcx
       xor       ecx,ecx
       mov       [rbp-48],rcx
       mov       [rbp-50],rcx
       mov       rdi,[rbp-0A0]
       mov       r15,[rbp-98]
M00_L26:
       mov       ecx,eax
       jmp       near ptr M00_L19
M00_L27:
       mov       ecx,[r15+0C]
       mov       [r15+8],ecx
M00_L28:
       mov       dword ptr [rbp-40],1
       jmp       near ptr M00_L56
M00_L29:
       mov       ecx,[r12+0C]
       mov       [r12+8],ecx
       jmp       near ptr M00_L55
M00_L30:
       mov       rcx,r12
       mov       r11,7FFEFF650DE8
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M00_L55
       jmp       near ptr M00_L03
M00_L31:
       call      qword ptr [7FFF000576C0]
       int       3
M00_L32:
       mov       rcx,r12
       mov       r11,7FFEFF650DF0
       call      qword ptr [r11]
       mov       r12,rax
M00_L33:
       mov       [rbp-0B0],r12
       mov       rdx,r12
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       mov       r12,[rbp-0B0]
       jmp       near ptr M00_L04
M00_L34:
       mov       [rbp-0B8],rax
       mov       r15,[rbp-98]
M00_L35:
       mov       rcx,r15
       mov       r11,7FFEFF650E10
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M00_L28
       mov       rcx,r15
       mov       r11,7FFEFF650E18
       call      qword ptr [r11]
       mov       rsi,rax
       mov       rdx,rsi
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       mov       rcx,rdi
       mov       r8,[rbp-0B8]
       mov       [rbp-0D0],rax
       mov       rdx,rax
       mov       r11,7FFEFF650E20
       call      qword ptr [r11]
       test      eax,eax
       jg        short M00_L35
       mov       r12,[rbp-0D0]
       mov       [rbp-0B8],r12
       mov       r12,rsi
       mov       r15,[rbp-98]
       jmp       short M00_L35
M00_L36:
       mov       ecx,2
       call      qword ptr [7FFF00057738]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       rdx,rax
       jmp       near ptr M00_L10
M00_L37:
       call      qword ptr [7FFEFF985DA0]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rcx,rax
       jmp       near ptr M00_L11
M00_L38:
       xor       eax,eax
       mov       [rbp-0B0],r12
       jmp       near ptr M00_L15
M00_L39:
       mov       ecx,1
       mov       [rbp-0B8],rax
       jmp       near ptr M00_L08
M00_L40:
       test      rax,rax
       je        short M00_L41
       mov       ecx,0FFFFFFFF
       mov       [rbp-0B8],rax
       jmp       near ptr M00_L08
M00_L41:
       xor       ecx,ecx
       mov       [rbp-0B8],rax
       jmp       near ptr M00_L08
M00_L42:
       mov       [rbp-0B8],rax
       mov       rcx,r15
       mov       r11,7FFEFF650DF8
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M00_L28
       mov       rcx,r15
       mov       r11,7FFEFF650E00
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       short M00_L44
M00_L43:
       mov       [rbp-0B8],rax
M00_L44:
       mov       [rbp-0C0],rdx
       mov       r14,[rbp-0A8]
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       mov       [rbp-0C8],rax
       mov       rax,[rbp-0B8]
       mov       r15,[rbp-98]
       jmp       short M00_L46
M00_L45:
       mov       [rbp-0C8],r8
M00_L46:
       mov       rcx,rdi
       mov       [rbp-0B8],rax
       mov       r8,rax
       mov       rdx,[rbp-0C8]
       mov       r11,7FFEFF650E08
       call      qword ptr [r11]
       mov       ecx,eax
       mov       [rbp-0B0],r12
       jmp       near ptr M00_L19
M00_L47:
       mov       [rbp-0B8],rax
       test      rax,rax
       jne       short M00_L48
       mov       rax,[rbp-0B8]
       xor       ecx,ecx
       mov       [rbp-0C8],r8
       mov       [rbp-0B8],rax
       mov       [rbp-0B0],r12
       jmp       near ptr M00_L19
M00_L48:
       mov       rax,[rbp-0B8]
       mov       ecx,0FFFFFFFF
       mov       [rbp-0C8],r8
       mov       [rbp-0B8],rax
       mov       [rbp-0B0],r12
       jmp       near ptr M00_L19
M00_L49:
       mov       ecx,1
       mov       [rbp-0C8],r8
       mov       [rbp-0B8],rax
       mov       [rbp-0B0],r12
       jmp       near ptr M00_L19
M00_L50:
       mov       ecx,2
       call      qword ptr [7FFF00057738]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       r10,rax
       jmp       near ptr M00_L21
M00_L51:
       call      qword ptr [7FFEFF985DA0]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rcx,rax
       jmp       near ptr M00_L22
M00_L52:
       xor       eax,eax
       mov       [rbp-0B0],r12
       jmp       near ptr M00_L26
M00_L53:
       mov       ecx,[r15+8]
       call      qword ptr [7FFF000576C0]
       int       3
M00_L54:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L55:
       xor       ecx,ecx
       mov       [rbp-40],ecx
       xor       r12d,r12d
       mov       r15,[rbp-98]
M00_L56:
       cmp       [r15],r13
       jne       near ptr M00_L64
M00_L57:
       cmp       byte ptr [rbp-40],0
       je        near ptr M00_L65
       mov       [rbp-58],r12
       mov       rbx,[rbp+10]
       mov       r15,[rbx+60]
       mov       rdx,[rbp-58]
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [r15+8],rax
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
M00_L58:
       mov       ecx,11
       call      qword ptr [7FFEFF987DF8]
       int       3
M00_L59:
       mov       r13,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord>
       mov       rcx,r13
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       dword ptr [r12+8],0FFFFFFFF
       mov       [r12+0C],r14d
       lea       rcx,[r12+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L02
M00_L60:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdx,180FE000E58
       mov       rdx,[rdx]
       mov       rcx,r14
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonValOrderBy>b__14_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       call      qword ptr [7FFEFF706BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,180FE000E70
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L61:
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L01
M00_L62:
       mov       rcx,rdi
       mov       r11,7FFEFF650E30
       call      qword ptr [r11]
       mov       r12,rax
       jmp       near ptr M00_L02
M00_L63:
       mov       r11,7FFEFF650DE0
       call      qword ptr [r11]
       mov       r12,rax
       jmp       near ptr M00_L02
M00_L64:
       mov       rcx,r15
       mov       r11,7FFEFF650E28
       call      qword ptr [r11]
       jmp       near ptr M00_L57
M00_L65:
       call      qword ptr [7FFEFFE8FD08]
       int       3
       sub       rsp,38
       vzeroupper
       cmp       qword ptr [rbp-98],0
       je        short M00_L66
       mov       r13,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord>
       mov       r15,[rbp-98]
       cmp       [r15],r13
       je        short M00_L66
       mov       rcx,r15
       mov       r11,7FFEFF650E28
       call      qword ptr [r11]
M00_L66:
       nop
       add       rsp,38
       ret
; Total bytes of code 2622
```
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonValOrderBy>b__14_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       mov       rax,[rdx+30]
       ret
; Total bytes of code 5
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FFF51600D78]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       ecx,ebx
       and       ecx,0FFFFFF
       mov       edx,ecx
       mov       r8d,ebx
       sar       r8d,18
       jne       short M02_L01
       cmp       [rax],ecx
       jle       short M02_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M02_L03
M02_L00:
       add       rsp,20
       pop       rbx
       ret
M02_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M02_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M02_L00
M02_L02:
       cmp       [rax+4],edx
       jle       short M02_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M02_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M02_L03
       jmp       short M02_L00
M02_L03:
       mov       ecx,ebx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax]
; Total bytes of code 130
```
```assembly
; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       push      rsi
       push      rbx
       sub       rsp,28
       call      qword ptr [7FFF515E87D0]
       mov       rbx,rax
       mov       rsi,rbx
       call      qword ptr [7FFF515FFA88]
       mov       rdx,rax
       test      rsi,rsi
       je        short M03_L00
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFF51600C28]
       mov       rax,[rbx]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M03_L00:
       call      qword ptr [7FFF515FE468]
       int       3
; Total bytes of code 61
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M04_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L00:
       call      qword ptr [7FFF0005E568]
       int       3
; Total bytes of code 44
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M05_L00
       ret
M05_L00:
       jmp       qword ptr [7FFEFF705C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.PersonValOrderBy()
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
       xor       eax,eax
       mov       [rbp-58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp-40],rax
       mov       rbx,rcx
       lea       rcx,[rbp-90]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rcx,rsp
       mov       [rbp-78],rcx
       mov       rcx,rbp
       mov       [rbp-68],rcx
       mov       [rbp+10],rbx
       mov       rdi,[rbx+280]
       mov       rcx,21740000E70
       mov       r14,[rcx]
       test      r14,r14
       je        near ptr M00_L59
M00_L00:
       mov       rcx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [r15+10],eax
       lea       rcx,[r15+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        near ptr M00_L60
       xor       ecx,ecx
       mov       [r15+20],rcx
       lea       rcx,[r15+28]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,21717000A08
       mov       rdx,[rcx]
       lea       rcx,[r15+30]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [r15+48],0
       mov       rcx,[r15+18]
       mov       rax,offset MT_System.Collections.ObjectModel.Collection<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord>
       cmp       [rcx],rax
       jne       near ptr M00_L63
       mov       rdi,[rcx+8]
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord[]
       cmp       [rdi],rcx
       jne       near ptr M00_L62
       mov       r14d,[rdi+8]
       test      r14d,r14d
       jne       near ptr M00_L58
       mov       r13,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord>
       mov       rcx,r13
       test      byte ptr [7FFF0000DE58],1
       je        near ptr M00_L61
M00_L01:
       mov       rcx,21740000E98
       mov       r12,[rcx]
M00_L02:
       mov       [rbp-98],r12
       mov       r13,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord>
       cmp       [r12],r13
       jne       near ptr M00_L30
       mov       ecx,[r12+8]
       inc       ecx
       cmp       ecx,[r12+0C]
       jae       near ptr M00_L29
       mov       [r12+8],ecx
M00_L03:
       mov       rdi,[r15+30]
       mov       [rbp-0A0],rdi
       mov       r14,[r15+28]
       mov       [rbp-0A8],r14
       cmp       [r12],r13
       jne       near ptr M00_L32
       mov       ecx,[r12+8]
       cmp       ecx,[r12+0C]
       jae       near ptr M00_L31
       mov       rax,[r12+10]
       cmp       ecx,[rax+8]
       jae       near ptr M00_L54
       mov       r12,[rax+rcx*8+10]
       mov       rcx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonValOrderBy>b__14_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       cmp       [r14+18],rcx
       jne       near ptr M00_L33
       mov       rax,[r12+30]
M00_L04:
       cmp       byte ptr [r15+48],0
       jne       near ptr M00_L34
       test      r14,r14
       je        near ptr M00_L20
       test      rdi,rdi
       je        near ptr M00_L20
       mov       r15,[rbp-98]
       cmp       [r15],r13
       jne       near ptr M00_L20
       mov       rcx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonValOrderBy>b__14_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       cmp       [r14+18],rcx
       jne       near ptr M00_L20
       mov       rcx,offset MT_System.Collections.Generic.GenericComparer<System.String>
       cmp       [rdi],rcx
       jne       near ptr M00_L20
       jmp       short M00_L09
M00_L05:
       mov       rdi,[rbp-0C0]
       mov       rax,r14
       mov       [rbp-0B0],rdi
       mov       r12,[rbp-0B0]
       jmp       short M00_L09
M00_L06:
       cmp       rdx,r9
       je        near ptr M00_L38
       mov       [rbp-0B0],r12
       jmp       near ptr M00_L12
M00_L07:
       xor       ecx,ecx
M00_L08:
       test      ecx,ecx
       mov       rax,[rbp-0B8]
       mov       r15,[rbp-98]
       jge       short M00_L05
M00_L09:
       mov       edx,[r15+8]
       inc       edx
       cmp       edx,[r15+0C]
       jae       near ptr M00_L27
       mov       [r15+8],edx
       mov       r8d,[r15+8]
       cmp       r8d,[r15+0C]
       jae       near ptr M00_L53
       mov       r14,[r15+10]
       cmp       r8d,[r14+8]
       jae       near ptr M00_L54
       mov       ecx,r8d
       mov       rdi,[r14+rcx*8+10]
       mov       [rbp-0C0],rdi
       mov       r14,[rdi+30]
       test      r14,r14
       je        near ptr M00_L40
       test      rax,rax
       je        near ptr M00_L39
       mov       [rbp-0B8],rax
       cmp       r14,rax
       je        short M00_L07
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],2
       jle       near ptr M00_L36
       mov       rcx,[rcx+240]
       mov       rdx,[rcx+10]
       test      rdx,rdx
       je        near ptr M00_L36
M00_L10:
       mov       rcx,[rdx+10]
       test      rcx,rcx
       jne       short M00_L11
       mov       rcx,21717000110
       mov       rcx,[rcx]
       test      rcx,rcx
       jne       short M00_L11
       mov       rcx,217170000F0
       mov       rcx,[rcx]
       test      rcx,rcx
       je        near ptr M00_L37
M00_L11:
       mov       rdx,[rcx]
       mov       rdx,[rdx+48]
       call      qword ptr [rdx+30]
       cmp       [rax],al
       lea       rdx,[r14+0C]
       mov       [rbp-0C8],r14
       mov       r8d,[r14+8]
       mov       r10,[rbp-0B8]
       lea       r9,[r10+0C]
       mov       [rbp-0B8],r10
       mov       r11d,[r10+8]
       cmp       r8d,r11d
       je        near ptr M00_L06
       mov       [rbp-0B0],r12
M00_L12:
       mov       [rbp-48],rdx
       mov       [rbp-50],r9
       mov       rcx,[rax+20]
       mov       [rsp+20],r11d
       xor       eax,eax
       mov       [rsp+28],eax
       mov       rax,7FFEFF96B650
       mov       [rbp-80],rax
       lea       rax,[M00_L13]
       mov       [rbp-70],rax
       lea       rax,[rbp-90]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFF5F2F93A0
       call      rax
M00_L13:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFF5F64F778],0
       je        short M00_L14
       call      qword ptr [7FFF5F63D608]; CORINFO_HELP_STOP_FOR_GC
M00_L14:
       mov       rcx,[rbp-88]
       mov       [rsi+8],rcx
       xor       ecx,ecx
       mov       [rbp-48],rcx
       mov       [rbp-50],rcx
M00_L15:
       mov       ecx,eax
       mov       r12,[rbp-0B0]
       mov       r14,[rbp-0C8]
       jmp       near ptr M00_L08
M00_L16:
       mov       rdx,[rbp-0C0]
       mov       r10,[rbp-0C8]
       mov       r11,r10
       mov       r12,rdx
       mov       rax,r11
       jmp       short M00_L20
M00_L17:
       cmp       rdx,r9
       je        near ptr M00_L52
       mov       [rbp-0B0],r12
       jmp       near ptr M00_L23
M00_L18:
       xor       ecx,ecx
       mov       [rbp-0B0],r12
M00_L19:
       test      ecx,ecx
       mov       rax,[rbp-0B8]
       mov       r12,[rbp-0B0]
       mov       r14,[rbp-0A8]
       jge       short M00_L16
M00_L20:
       mov       r15,[rbp-98]
       cmp       [r15],r13
       jne       near ptr M00_L42
       mov       edx,[r15+8]
       inc       edx
       cmp       edx,[r15+0C]
       jae       near ptr M00_L27
       mov       [r15+8],edx
       mov       ecx,[r15+8]
       cmp       ecx,[r15+0C]
       jae       near ptr M00_L53
       mov       rcx,[r15+10]
       mov       r8d,[r15+8]
       cmp       r8d,[rcx+8]
       jae       near ptr M00_L54
       mov       edx,r8d
       mov       rcx,[rcx+rdx*8+10]
       mov       rdx,rcx
       mov       rcx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonValOrderBy>b__14_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       cmp       [r14+18],rcx
       jne       near ptr M00_L43
       mov       r15,[rbp-98]
       mov       [rbp-0C0],rdx
       mov       rcx,[rdx+30]
       mov       r8,rcx
       mov       rcx,offset MT_System.Collections.Generic.GenericComparer<System.String>
       cmp       [rdi],rcx
       mov       rdi,[rbp-0A0]
       jne       near ptr M00_L45
       test      r8,r8
       je        near ptr M00_L47
       test      rax,rax
       je        near ptr M00_L49
       mov       [rbp-0C8],r8
       mov       [rbp-0B8],rax
       cmp       r8,rax
       je        near ptr M00_L18
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],2
       jle       near ptr M00_L50
       mov       rcx,[rcx+240]
       mov       r10,[rcx+10]
       test      r10,r10
       je        near ptr M00_L50
M00_L21:
       mov       rcx,[r10+10]
       test      rcx,rcx
       jne       short M00_L22
       mov       rcx,21717000110
       mov       rcx,[rcx]
       test      rcx,rcx
       jne       short M00_L22
       mov       rcx,217170000F0
       mov       rcx,[rcx]
       test      rcx,rcx
       je        near ptr M00_L51
M00_L22:
       mov       r10,[rcx]
       mov       r10,[r10+48]
       call      qword ptr [r10+30]
       cmp       [rax],al
       mov       r10,[rbp-0C8]
       lea       rdx,[r10+0C]
       mov       [rbp-0C8],r10
       mov       r8d,[r10+8]
       mov       r11,[rbp-0B8]
       lea       r9,[r11+0C]
       mov       [rbp-0B8],r11
       mov       ecx,[r11+8]
       cmp       r8d,ecx
       je        near ptr M00_L17
       mov       [rbp-0B0],r12
M00_L23:
       mov       [rbp-48],rdx
       mov       [rbp-50],r9
       mov       rax,[rax+20]
       mov       [rsp+20],ecx
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rax
       mov       rax,7FFEFF96B650
       mov       [rbp-80],rax
       lea       rax,[M00_L24]
       mov       [rbp-70],rax
       lea       rax,[rbp-90]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFF5F2F93A0
       call      rax
M00_L24:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFF5F64F778],0
       je        short M00_L25
       call      qword ptr [7FFF5F63D608]; CORINFO_HELP_STOP_FOR_GC
M00_L25:
       mov       rcx,[rbp-88]
       mov       [rsi+8],rcx
       xor       ecx,ecx
       mov       [rbp-48],rcx
       mov       [rbp-50],rcx
       mov       rdi,[rbp-0A0]
       mov       r15,[rbp-98]
M00_L26:
       mov       ecx,eax
       jmp       near ptr M00_L19
M00_L27:
       mov       ecx,[r15+0C]
       mov       [r15+8],ecx
M00_L28:
       mov       dword ptr [rbp-40],1
       jmp       near ptr M00_L56
M00_L29:
       mov       ecx,[r12+0C]
       mov       [r12+8],ecx
       jmp       near ptr M00_L55
M00_L30:
       mov       rcx,r12
       mov       r11,7FFEFF640DE8
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M00_L55
       jmp       near ptr M00_L03
M00_L31:
       call      qword ptr [7FFF000474C8]
       int       3
M00_L32:
       mov       rcx,r12
       mov       r11,7FFEFF640DF0
       call      qword ptr [r11]
       mov       r12,rax
M00_L33:
       mov       [rbp-0B0],r12
       mov       rdx,r12
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       mov       r12,[rbp-0B0]
       jmp       near ptr M00_L04
M00_L34:
       mov       [rbp-0B8],rax
       mov       r15,[rbp-98]
M00_L35:
       mov       rcx,r15
       mov       r11,7FFEFF640E10
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M00_L28
       mov       rcx,r15
       mov       r11,7FFEFF640E18
       call      qword ptr [r11]
       mov       rsi,rax
       mov       rdx,rsi
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       mov       rcx,rdi
       mov       r8,[rbp-0B8]
       mov       [rbp-0D0],rax
       mov       rdx,rax
       mov       r11,7FFEFF640E20
       call      qword ptr [r11]
       test      eax,eax
       jg        short M00_L35
       mov       r12,[rbp-0D0]
       mov       [rbp-0B8],r12
       mov       r12,rsi
       mov       r15,[rbp-98]
       jmp       short M00_L35
M00_L36:
       mov       ecx,2
       call      qword ptr [7FFF000475E8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       rdx,rax
       jmp       near ptr M00_L10
M00_L37:
       call      qword ptr [7FFEFF975DA0]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rcx,rax
       jmp       near ptr M00_L11
M00_L38:
       xor       eax,eax
       mov       [rbp-0B0],r12
       jmp       near ptr M00_L15
M00_L39:
       mov       ecx,1
       mov       [rbp-0B8],rax
       jmp       near ptr M00_L08
M00_L40:
       test      rax,rax
       je        short M00_L41
       mov       ecx,0FFFFFFFF
       mov       [rbp-0B8],rax
       jmp       near ptr M00_L08
M00_L41:
       xor       ecx,ecx
       mov       [rbp-0B8],rax
       jmp       near ptr M00_L08
M00_L42:
       mov       [rbp-0B8],rax
       mov       rcx,r15
       mov       r11,7FFEFF640DF8
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M00_L28
       mov       rcx,r15
       mov       r11,7FFEFF640E00
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       short M00_L44
M00_L43:
       mov       [rbp-0B8],rax
M00_L44:
       mov       [rbp-0C0],rdx
       mov       r14,[rbp-0A8]
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       mov       [rbp-0C8],rax
       mov       rax,[rbp-0B8]
       mov       r15,[rbp-98]
       jmp       short M00_L46
M00_L45:
       mov       [rbp-0C8],r8
M00_L46:
       mov       rcx,rdi
       mov       [rbp-0B8],rax
       mov       r8,rax
       mov       rdx,[rbp-0C8]
       mov       r11,7FFEFF640E08
       call      qword ptr [r11]
       mov       ecx,eax
       mov       [rbp-0B0],r12
       jmp       near ptr M00_L19
M00_L47:
       mov       [rbp-0B8],rax
       test      rax,rax
       jne       short M00_L48
       mov       rax,[rbp-0B8]
       xor       ecx,ecx
       mov       [rbp-0C8],r8
       mov       [rbp-0B8],rax
       mov       [rbp-0B0],r12
       jmp       near ptr M00_L19
M00_L48:
       mov       rax,[rbp-0B8]
       mov       ecx,0FFFFFFFF
       mov       [rbp-0C8],r8
       mov       [rbp-0B8],rax
       mov       [rbp-0B0],r12
       jmp       near ptr M00_L19
M00_L49:
       mov       ecx,1
       mov       [rbp-0C8],r8
       mov       [rbp-0B8],rax
       mov       [rbp-0B0],r12
       jmp       near ptr M00_L19
M00_L50:
       mov       ecx,2
       call      qword ptr [7FFF000475E8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       r10,rax
       jmp       near ptr M00_L21
M00_L51:
       call      qword ptr [7FFEFF975DA0]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rcx,rax
       jmp       near ptr M00_L22
M00_L52:
       xor       eax,eax
       mov       [rbp-0B0],r12
       jmp       near ptr M00_L26
M00_L53:
       mov       ecx,[r15+8]
       call      qword ptr [7FFF000474C8]
       int       3
M00_L54:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L55:
       xor       ecx,ecx
       mov       [rbp-40],ecx
       xor       r12d,r12d
       mov       r15,[rbp-98]
M00_L56:
       cmp       [r15],r13
       jne       near ptr M00_L64
M00_L57:
       cmp       byte ptr [rbp-40],0
       je        near ptr M00_L65
       mov       [rbp-58],r12
       mov       rbx,[rbp+10]
       mov       r15,[rbx+60]
       mov       rdx,[rbp-58]
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [r15+8],rax
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
M00_L58:
       mov       r13,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord>
       mov       rcx,r13
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       dword ptr [r12+8],0FFFFFFFF
       mov       [r12+0C],r14d
       lea       rcx,[r12+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L02
M00_L59:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdx,21740000E58
       mov       rdx,[rdx]
       mov       rcx,r14
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonValOrderBy>b__14_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       call      qword ptr [7FFEFF6F6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,21740000E70
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L60:
       mov       ecx,11
       call      qword ptr [7FFEFF977DF8]
       int       3
M00_L61:
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L01
M00_L62:
       mov       rcx,rdi
       mov       r11,7FFEFF640E30
       call      qword ptr [r11]
       mov       r12,rax
       jmp       near ptr M00_L02
M00_L63:
       mov       r11,7FFEFF640DE0
       call      qword ptr [r11]
       mov       r12,rax
       jmp       near ptr M00_L02
M00_L64:
       mov       rcx,r15
       mov       r11,7FFEFF640E28
       call      qword ptr [r11]
       jmp       near ptr M00_L57
M00_L65:
       call      qword ptr [7FFEFFE7FCF0]
       int       3
       sub       rsp,38
       vzeroupper
       cmp       qword ptr [rbp-98],0
       je        short M00_L66
       mov       r13,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord>
       mov       r15,[rbp-98]
       cmp       [r15],r13
       je        short M00_L66
       mov       rcx,r15
       mov       r11,7FFEFF640E28
       call      qword ptr [r11]
M00_L66:
       nop
       add       rsp,38
       ret
; Total bytes of code 2622
```
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonValOrderBy>b__14_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       mov       rax,[rdx+30]
       ret
; Total bytes of code 5
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FFF51600D78]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       ecx,ebx
       and       ecx,0FFFFFF
       mov       edx,ecx
       mov       r8d,ebx
       sar       r8d,18
       jne       short M02_L01
       cmp       [rax],ecx
       jle       short M02_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M02_L03
M02_L00:
       add       rsp,20
       pop       rbx
       ret
M02_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M02_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M02_L00
M02_L02:
       cmp       [rax+4],edx
       jle       short M02_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M02_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M02_L03
       jmp       short M02_L00
M02_L03:
       mov       ecx,ebx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax]
; Total bytes of code 130
```
```assembly
; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       push      rsi
       push      rbx
       sub       rsp,28
       call      qword ptr [7FFF515E87D0]
       mov       rbx,rax
       mov       rsi,rbx
       call      qword ptr [7FFF515FFA88]
       mov       rdx,rax
       test      rsi,rsi
       je        short M03_L00
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFF51600C28]
       mov       rax,[rbx]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M03_L00:
       call      qword ptr [7FFF515FE468]
       int       3
; Total bytes of code 61
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M04_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L00:
       call      qword ptr [7FFF0004E628]
       int       3
; Total bytes of code 44
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M05_L00
       ret
M05_L00:
       jmp       qword ptr [7FFEFF6F5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.PersonValOrderBy()
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
       xor       eax,eax
       mov       [rbp-58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp-40],rax
       mov       rbx,rcx
       lea       rcx,[rbp-90]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rcx,rsp
       mov       [rbp-78],rcx
       mov       rcx,rbp
       mov       [rbp-68],rcx
       mov       [rbp+10],rbx
       mov       rdi,[rbx+280]
       mov       rcx,1FF52402E68
       mov       r14,[rcx]
       test      r14,r14
       je        near ptr M00_L60
M00_L00:
       mov       rcx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [r15+10],eax
       lea       rcx,[r15+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        near ptr M00_L58
       xor       ecx,ecx
       mov       [r15+20],rcx
       lea       rcx,[r15+28]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,1FF52400A08
       mov       rdx,[rcx]
       lea       rcx,[r15+30]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [r15+48],0
       mov       rcx,[r15+18]
       mov       rax,offset MT_System.Collections.ObjectModel.Collection<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord>
       cmp       [rcx],rax
       jne       near ptr M00_L63
       mov       rdi,[rcx+8]
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord[]
       cmp       [rdi],rcx
       jne       near ptr M00_L62
       mov       r14d,[rdi+8]
       test      r14d,r14d
       jne       near ptr M00_L59
       mov       r13,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord>
       mov       rcx,r13
       test      byte ptr [7FFEFFFFDE58],1
       je        near ptr M00_L61
M00_L01:
       mov       rcx,1FF52402E90
       mov       r12,[rcx]
M00_L02:
       mov       [rbp-98],r12
       mov       r13,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord>
       cmp       [r12],r13
       jne       near ptr M00_L30
       mov       ecx,[r12+8]
       inc       ecx
       cmp       ecx,[r12+0C]
       jae       near ptr M00_L29
       mov       [r12+8],ecx
M00_L03:
       mov       rdi,[r15+30]
       mov       [rbp-0A0],rdi
       mov       r14,[r15+28]
       mov       [rbp-0A8],r14
       cmp       [r12],r13
       jne       near ptr M00_L32
       mov       ecx,[r12+8]
       cmp       ecx,[r12+0C]
       jae       near ptr M00_L31
       mov       rax,[r12+10]
       cmp       ecx,[rax+8]
       jae       near ptr M00_L54
       mov       r12,[rax+rcx*8+10]
       mov       rcx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonValOrderBy>b__14_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       cmp       [r14+18],rcx
       jne       near ptr M00_L33
       mov       rax,[r12+30]
M00_L04:
       cmp       byte ptr [r15+48],0
       jne       near ptr M00_L34
       test      r14,r14
       je        near ptr M00_L20
       test      rdi,rdi
       je        near ptr M00_L20
       mov       r15,[rbp-98]
       cmp       [r15],r13
       jne       near ptr M00_L20
       mov       rcx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonValOrderBy>b__14_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       cmp       [r14+18],rcx
       jne       near ptr M00_L20
       mov       rcx,offset MT_System.Collections.Generic.GenericComparer<System.String>
       cmp       [rdi],rcx
       jne       near ptr M00_L20
       jmp       short M00_L09
M00_L05:
       mov       rdi,[rbp-0C0]
       mov       rax,r14
       mov       [rbp-0B0],rdi
       mov       r12,[rbp-0B0]
       jmp       short M00_L09
M00_L06:
       cmp       rdx,r9
       je        near ptr M00_L38
       mov       [rbp-0B0],r12
       jmp       near ptr M00_L12
M00_L07:
       xor       ecx,ecx
M00_L08:
       test      ecx,ecx
       mov       rax,[rbp-0B8]
       mov       r15,[rbp-98]
       jge       short M00_L05
M00_L09:
       mov       edx,[r15+8]
       inc       edx
       cmp       edx,[r15+0C]
       jae       near ptr M00_L27
       mov       [r15+8],edx
       mov       r8d,[r15+8]
       cmp       r8d,[r15+0C]
       jae       near ptr M00_L53
       mov       r14,[r15+10]
       cmp       r8d,[r14+8]
       jae       near ptr M00_L54
       mov       ecx,r8d
       mov       rdi,[r14+rcx*8+10]
       mov       [rbp-0C0],rdi
       mov       r14,[rdi+30]
       test      r14,r14
       je        near ptr M00_L40
       test      rax,rax
       je        near ptr M00_L39
       mov       [rbp-0B8],rax
       cmp       r14,rax
       je        short M00_L07
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+238],2
       jle       near ptr M00_L36
       mov       rcx,[rcx+240]
       mov       rdx,[rcx+10]
       test      rdx,rdx
       je        near ptr M00_L36
M00_L10:
       mov       rcx,[rdx+10]
       test      rcx,rcx
       jne       short M00_L11
       mov       rcx,1FF52400110
       mov       rcx,[rcx]
       test      rcx,rcx
       jne       short M00_L11
       mov       rcx,1FF524000F0
       mov       rcx,[rcx]
       test      rcx,rcx
       je        near ptr M00_L37
M00_L11:
       mov       rdx,[rcx]
       mov       rdx,[rdx+48]
       call      qword ptr [rdx+30]
       cmp       [rax],al
       lea       rdx,[r14+0C]
       mov       [rbp-0C8],r14
       mov       r8d,[r14+8]
       mov       r10,[rbp-0B8]
       lea       r9,[r10+0C]
       mov       [rbp-0B8],r10
       mov       r11d,[r10+8]
       cmp       r8d,r11d
       je        near ptr M00_L06
       mov       [rbp-0B0],r12
M00_L12:
       mov       [rbp-48],rdx
       mov       [rbp-50],r9
       mov       rcx,[rax+20]
       mov       [rsp+20],r11d
       xor       eax,eax
       mov       [rsp+28],eax
       mov       rax,7FFEFF95B650
       mov       [rbp-80],rax
       lea       rax,[M00_L13]
       mov       [rbp-70],rax
       lea       rax,[rbp-90]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFF5F2F93A0
       call      rax
M00_L13:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFF5F64F778],0
       je        short M00_L14
       call      qword ptr [7FFF5F63D608]; CORINFO_HELP_STOP_FOR_GC
M00_L14:
       mov       rcx,[rbp-88]
       mov       [rsi+8],rcx
       xor       ecx,ecx
       mov       [rbp-48],rcx
       mov       [rbp-50],rcx
M00_L15:
       mov       ecx,eax
       mov       r12,[rbp-0B0]
       mov       r14,[rbp-0C8]
       jmp       near ptr M00_L08
M00_L16:
       mov       rdx,[rbp-0C0]
       mov       r10,[rbp-0C8]
       mov       r11,r10
       mov       r12,rdx
       mov       rax,r11
       jmp       short M00_L20
M00_L17:
       cmp       rdx,r9
       je        near ptr M00_L52
       mov       [rbp-0B0],r12
       jmp       near ptr M00_L23
M00_L18:
       xor       ecx,ecx
       mov       [rbp-0B0],r12
M00_L19:
       test      ecx,ecx
       mov       rax,[rbp-0B8]
       mov       r12,[rbp-0B0]
       mov       r14,[rbp-0A8]
       jge       short M00_L16
M00_L20:
       mov       r15,[rbp-98]
       cmp       [r15],r13
       jne       near ptr M00_L42
       mov       edx,[r15+8]
       inc       edx
       cmp       edx,[r15+0C]
       jae       near ptr M00_L27
       mov       [r15+8],edx
       mov       ecx,[r15+8]
       cmp       ecx,[r15+0C]
       jae       near ptr M00_L53
       mov       rcx,[r15+10]
       mov       r8d,[r15+8]
       cmp       r8d,[rcx+8]
       jae       near ptr M00_L54
       mov       edx,r8d
       mov       rcx,[rcx+rdx*8+10]
       mov       rdx,rcx
       mov       rcx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonValOrderBy>b__14_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       cmp       [r14+18],rcx
       jne       near ptr M00_L43
       mov       r15,[rbp-98]
       mov       [rbp-0C0],rdx
       mov       rcx,[rdx+30]
       mov       r8,rcx
       mov       rcx,offset MT_System.Collections.Generic.GenericComparer<System.String>
       cmp       [rdi],rcx
       mov       rdi,[rbp-0A0]
       jne       near ptr M00_L45
       test      r8,r8
       je        near ptr M00_L47
       test      rax,rax
       je        near ptr M00_L49
       mov       [rbp-0C8],r8
       mov       [rbp-0B8],rax
       cmp       r8,rax
       je        near ptr M00_L18
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+238],2
       jle       near ptr M00_L50
       mov       rcx,[rcx+240]
       mov       r10,[rcx+10]
       test      r10,r10
       je        near ptr M00_L50
M00_L21:
       mov       rcx,[r10+10]
       test      rcx,rcx
       jne       short M00_L22
       mov       rcx,1FF52400110
       mov       rcx,[rcx]
       test      rcx,rcx
       jne       short M00_L22
       mov       rcx,1FF524000F0
       mov       rcx,[rcx]
       test      rcx,rcx
       je        near ptr M00_L51
M00_L22:
       mov       r10,[rcx]
       mov       r10,[r10+48]
       call      qword ptr [r10+30]
       cmp       [rax],al
       mov       r10,[rbp-0C8]
       lea       rdx,[r10+0C]
       mov       [rbp-0C8],r10
       mov       r8d,[r10+8]
       mov       r11,[rbp-0B8]
       lea       r9,[r11+0C]
       mov       [rbp-0B8],r11
       mov       ecx,[r11+8]
       cmp       r8d,ecx
       je        near ptr M00_L17
       mov       [rbp-0B0],r12
M00_L23:
       mov       [rbp-48],rdx
       mov       [rbp-50],r9
       mov       rax,[rax+20]
       mov       [rsp+20],ecx
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rax
       mov       rax,7FFEFF95B650
       mov       [rbp-80],rax
       lea       rax,[M00_L24]
       mov       [rbp-70],rax
       lea       rax,[rbp-90]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFF5F2F93A0
       call      rax
M00_L24:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFF5F64F778],0
       je        short M00_L25
       call      qword ptr [7FFF5F63D608]; CORINFO_HELP_STOP_FOR_GC
M00_L25:
       mov       rcx,[rbp-88]
       mov       [rsi+8],rcx
       xor       ecx,ecx
       mov       [rbp-48],rcx
       mov       [rbp-50],rcx
       mov       rdi,[rbp-0A0]
       mov       r15,[rbp-98]
M00_L26:
       mov       ecx,eax
       jmp       near ptr M00_L19
M00_L27:
       mov       ecx,[r15+0C]
       mov       [r15+8],ecx
M00_L28:
       mov       dword ptr [rbp-40],1
       jmp       near ptr M00_L56
M00_L29:
       mov       ecx,[r12+0C]
       mov       [r12+8],ecx
       jmp       near ptr M00_L55
M00_L30:
       mov       rcx,r12
       mov       r11,7FFEFF630DE8
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M00_L55
       jmp       near ptr M00_L03
M00_L31:
       call      qword ptr [7FFF00037648]
       int       3
M00_L32:
       mov       rcx,r12
       mov       r11,7FFEFF630DF0
       call      qword ptr [r11]
       mov       r12,rax
M00_L33:
       mov       [rbp-0B0],r12
       mov       rdx,r12
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       mov       r12,[rbp-0B0]
       jmp       near ptr M00_L04
M00_L34:
       mov       [rbp-0B8],rax
       mov       r15,[rbp-98]
M00_L35:
       mov       rcx,r15
       mov       r11,7FFEFF630E10
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M00_L28
       mov       rcx,r15
       mov       r11,7FFEFF630E18
       call      qword ptr [r11]
       mov       rsi,rax
       mov       rdx,rsi
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       mov       rcx,rdi
       mov       r8,[rbp-0B8]
       mov       [rbp-0D0],rax
       mov       rdx,rax
       mov       r11,7FFEFF630E20
       call      qword ptr [r11]
       test      eax,eax
       jg        short M00_L35
       mov       r12,[rbp-0D0]
       mov       [rbp-0B8],r12
       mov       r12,rsi
       mov       r15,[rbp-98]
       jmp       short M00_L35
M00_L36:
       mov       ecx,2
       call      qword ptr [7FFF000376C0]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       rdx,rax
       jmp       near ptr M00_L10
M00_L37:
       call      qword ptr [7FFEFF965DA0]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rcx,rax
       jmp       near ptr M00_L11
M00_L38:
       xor       eax,eax
       mov       [rbp-0B0],r12
       jmp       near ptr M00_L15
M00_L39:
       mov       ecx,1
       mov       [rbp-0B8],rax
       jmp       near ptr M00_L08
M00_L40:
       test      rax,rax
       je        short M00_L41
       mov       ecx,0FFFFFFFF
       mov       [rbp-0B8],rax
       jmp       near ptr M00_L08
M00_L41:
       xor       ecx,ecx
       mov       [rbp-0B8],rax
       jmp       near ptr M00_L08
M00_L42:
       mov       [rbp-0B8],rax
       mov       rcx,r15
       mov       r11,7FFEFF630DF8
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M00_L28
       mov       rcx,r15
       mov       r11,7FFEFF630E00
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       short M00_L44
M00_L43:
       mov       [rbp-0B8],rax
M00_L44:
       mov       [rbp-0C0],rdx
       mov       r14,[rbp-0A8]
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       mov       [rbp-0C8],rax
       mov       rax,[rbp-0B8]
       mov       r15,[rbp-98]
       jmp       short M00_L46
M00_L45:
       mov       [rbp-0C8],r8
M00_L46:
       mov       rcx,rdi
       mov       [rbp-0B8],rax
       mov       r8,rax
       mov       rdx,[rbp-0C8]
       mov       r11,7FFEFF630E08
       call      qword ptr [r11]
       mov       ecx,eax
       mov       [rbp-0B0],r12
       jmp       near ptr M00_L19
M00_L47:
       mov       [rbp-0B8],rax
       test      rax,rax
       jne       short M00_L48
       mov       rax,[rbp-0B8]
       xor       ecx,ecx
       mov       [rbp-0C8],r8
       mov       [rbp-0B8],rax
       mov       [rbp-0B0],r12
       jmp       near ptr M00_L19
M00_L48:
       mov       rax,[rbp-0B8]
       mov       ecx,0FFFFFFFF
       mov       [rbp-0C8],r8
       mov       [rbp-0B8],rax
       mov       [rbp-0B0],r12
       jmp       near ptr M00_L19
M00_L49:
       mov       ecx,1
       mov       [rbp-0C8],r8
       mov       [rbp-0B8],rax
       mov       [rbp-0B0],r12
       jmp       near ptr M00_L19
M00_L50:
       mov       ecx,2
       call      qword ptr [7FFF000376C0]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       r10,rax
       jmp       near ptr M00_L21
M00_L51:
       call      qword ptr [7FFEFF965DA0]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rcx,rax
       jmp       near ptr M00_L22
M00_L52:
       xor       eax,eax
       mov       [rbp-0B0],r12
       jmp       near ptr M00_L26
M00_L53:
       mov       ecx,[r15+8]
       call      qword ptr [7FFF00037648]
       int       3
M00_L54:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L55:
       xor       ecx,ecx
       mov       [rbp-40],ecx
       xor       r12d,r12d
       mov       r15,[rbp-98]
M00_L56:
       cmp       [r15],r13
       jne       near ptr M00_L64
M00_L57:
       cmp       byte ptr [rbp-40],0
       je        near ptr M00_L65
       mov       [rbp-58],r12
       mov       rbx,[rbp+10]
       mov       r15,[rbx+60]
       mov       rdx,[rbp-58]
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [r15+8],rax
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
M00_L58:
       mov       ecx,11
       call      qword ptr [7FFEFF967DF8]
       int       3
M00_L59:
       mov       r13,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord>
       mov       rcx,r13
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       dword ptr [r12+8],0FFFFFFFF
       mov       [r12+0C],r14d
       lea       rcx,[r12+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L02
M00_L60:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdx,1FF52402E50
       mov       rdx,[rdx]
       mov       rcx,r14
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonValOrderBy>b__14_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       call      qword ptr [7FFEFF6E6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1FF52402E68
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L61:
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L01
M00_L62:
       mov       rcx,rdi
       mov       r11,7FFEFF630E30
       call      qword ptr [r11]
       mov       r12,rax
       jmp       near ptr M00_L02
M00_L63:
       mov       r11,7FFEFF630DE0
       call      qword ptr [r11]
       mov       r12,rax
       jmp       near ptr M00_L02
M00_L64:
       mov       rcx,r15
       mov       r11,7FFEFF630E28
       call      qword ptr [r11]
       jmp       near ptr M00_L57
M00_L65:
       call      qword ptr [7FFEFFE6FD20]
       int       3
       sub       rsp,38
       vzeroupper
       cmp       qword ptr [rbp-98],0
       je        short M00_L66
       mov       r13,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord>
       mov       r15,[rbp-98]
       cmp       [r15],r13
       je        short M00_L66
       mov       rcx,r15
       mov       r11,7FFEFF630E28
       call      qword ptr [r11]
M00_L66:
       nop
       add       rsp,38
       ret
; Total bytes of code 2622
```
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonValOrderBy>b__14_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       mov       rax,[rdx+30]
       ret
; Total bytes of code 5
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FFF51600D78]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       ecx,ebx
       and       ecx,0FFFFFF
       mov       edx,ecx
       mov       r8d,ebx
       sar       r8d,18
       jne       short M02_L01
       cmp       [rax],ecx
       jle       short M02_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M02_L03
M02_L00:
       add       rsp,20
       pop       rbx
       ret
M02_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M02_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M02_L00
M02_L02:
       cmp       [rax+4],edx
       jle       short M02_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M02_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M02_L03
       jmp       short M02_L00
M02_L03:
       mov       ecx,ebx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax]
; Total bytes of code 130
```
```assembly
; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       push      rsi
       push      rbx
       sub       rsp,28
       call      qword ptr [7FFF515E87D0]
       mov       rbx,rax
       mov       rsi,rbx
       call      qword ptr [7FFF515FFA88]
       mov       rdx,rax
       test      rsi,rsi
       je        short M03_L00
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFF51600C28]
       mov       rax,[rbx]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M03_L00:
       call      qword ptr [7FFF515FE468]
       int       3
; Total bytes of code 61
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M04_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L00:
       call      qword ptr [7FFF0003E520]
       int       3
; Total bytes of code 44
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M05_L00
       ret
M05_L00:
       jmp       qword ptr [7FFEFF6E5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.PersonValOrderBy()
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
       xor       eax,eax
       mov       [rbp-58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp-40],rax
       mov       rbx,rcx
       lea       rcx,[rbp-90]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rcx,rsp
       mov       [rbp-78],rcx
       mov       rcx,rbp
       mov       [rbp-68],rcx
       mov       [rbp+10],rbx
       mov       rdi,[rbx+280]
       mov       rcx,1D681400E70
       mov       r14,[rcx]
       test      r14,r14
       je        near ptr M00_L60
M00_L00:
       mov       rcx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [r15+10],eax
       lea       rcx,[r15+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        near ptr M00_L58
       xor       ecx,ecx
       mov       [r15+20],rcx
       lea       rcx,[r15+28]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,1D658400A08
       mov       rdx,[rcx]
       lea       rcx,[r15+30]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [r15+48],0
       mov       rcx,[r15+18]
       mov       rax,offset MT_System.Collections.ObjectModel.Collection<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord>
       cmp       [rcx],rax
       jne       near ptr M00_L63
       mov       rdi,[rcx+8]
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord[]
       cmp       [rdi],rcx
       jne       near ptr M00_L62
       mov       r14d,[rdi+8]
       test      r14d,r14d
       jne       near ptr M00_L59
       mov       r13,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord>
       mov       rcx,r13
       test      byte ptr [7FFF0000D3F8],1
       je        near ptr M00_L61
M00_L01:
       mov       rcx,1D681400E98
       mov       r12,[rcx]
M00_L02:
       mov       [rbp-98],r12
       mov       r13,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord>
       cmp       [r12],r13
       jne       near ptr M00_L30
       mov       ecx,[r12+8]
       inc       ecx
       cmp       ecx,[r12+0C]
       jae       near ptr M00_L29
       mov       [r12+8],ecx
M00_L03:
       mov       rdi,[r15+30]
       mov       [rbp-0A0],rdi
       mov       r14,[r15+28]
       mov       [rbp-0A8],r14
       cmp       [r12],r13
       jne       near ptr M00_L32
       mov       ecx,[r12+8]
       cmp       ecx,[r12+0C]
       jae       near ptr M00_L31
       mov       rax,[r12+10]
       cmp       ecx,[rax+8]
       jae       near ptr M00_L54
       mov       r12,[rax+rcx*8+10]
       mov       rcx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonValOrderBy>b__14_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       cmp       [r14+18],rcx
       jne       near ptr M00_L33
       mov       rax,[r12+30]
M00_L04:
       cmp       byte ptr [r15+48],0
       jne       near ptr M00_L34
       test      r14,r14
       je        near ptr M00_L20
       test      rdi,rdi
       je        near ptr M00_L20
       mov       r15,[rbp-98]
       cmp       [r15],r13
       jne       near ptr M00_L20
       mov       rcx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonValOrderBy>b__14_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       cmp       [r14+18],rcx
       jne       near ptr M00_L20
       mov       rcx,offset MT_System.Collections.Generic.GenericComparer<System.String>
       cmp       [rdi],rcx
       jne       near ptr M00_L20
       jmp       short M00_L09
M00_L05:
       mov       rdi,[rbp-0C0]
       mov       rax,r14
       mov       [rbp-0B0],rdi
       mov       r12,[rbp-0B0]
       jmp       short M00_L09
M00_L06:
       cmp       rdx,r9
       je        near ptr M00_L38
       mov       [rbp-0B0],r12
       jmp       near ptr M00_L12
M00_L07:
       xor       ecx,ecx
M00_L08:
       test      ecx,ecx
       mov       rax,[rbp-0B8]
       mov       r15,[rbp-98]
       jge       short M00_L05
M00_L09:
       mov       edx,[r15+8]
       inc       edx
       cmp       edx,[r15+0C]
       jae       near ptr M00_L27
       mov       [r15+8],edx
       mov       r8d,[r15+8]
       cmp       r8d,[r15+0C]
       jae       near ptr M00_L53
       mov       r14,[r15+10]
       cmp       r8d,[r14+8]
       jae       near ptr M00_L54
       mov       ecx,r8d
       mov       rdi,[r14+rcx*8+10]
       mov       [rbp-0C0],rdi
       mov       r14,[rdi+30]
       test      r14,r14
       je        near ptr M00_L40
       test      rax,rax
       je        near ptr M00_L39
       mov       [rbp-0B8],rax
       cmp       r14,rax
       je        short M00_L07
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+238],2
       jle       near ptr M00_L36
       mov       rcx,[rcx+240]
       mov       rdx,[rcx+10]
       test      rdx,rdx
       je        near ptr M00_L36
M00_L10:
       mov       rcx,[rdx+10]
       test      rcx,rcx
       jne       short M00_L11
       mov       rcx,1D658400110
       mov       rcx,[rcx]
       test      rcx,rcx
       jne       short M00_L11
       mov       rcx,1D6584000F0
       mov       rcx,[rcx]
       test      rcx,rcx
       je        near ptr M00_L37
M00_L11:
       mov       rdx,[rcx]
       mov       rdx,[rdx+48]
       call      qword ptr [rdx+30]
       cmp       [rax],al
       lea       rdx,[r14+0C]
       mov       [rbp-0C8],r14
       mov       r8d,[r14+8]
       mov       r10,[rbp-0B8]
       lea       r9,[r10+0C]
       mov       [rbp-0B8],r10
       mov       r11d,[r10+8]
       cmp       r8d,r11d
       je        near ptr M00_L06
       mov       [rbp-0B0],r12
M00_L12:
       mov       [rbp-48],rdx
       mov       [rbp-50],r9
       mov       rcx,[rax+20]
       mov       [rsp+20],r11d
       xor       eax,eax
       mov       [rsp+28],eax
       mov       rax,7FFEFF96B650
       mov       [rbp-80],rax
       lea       rax,[M00_L13]
       mov       [rbp-70],rax
       lea       rax,[rbp-90]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFF5F2F93A0
       call      rax
M00_L13:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFF5F64F778],0
       je        short M00_L14
       call      qword ptr [7FFF5F63D608]; CORINFO_HELP_STOP_FOR_GC
M00_L14:
       mov       rcx,[rbp-88]
       mov       [rsi+8],rcx
       xor       ecx,ecx
       mov       [rbp-48],rcx
       mov       [rbp-50],rcx
M00_L15:
       mov       ecx,eax
       mov       r12,[rbp-0B0]
       mov       r14,[rbp-0C8]
       jmp       near ptr M00_L08
M00_L16:
       mov       rdx,[rbp-0C0]
       mov       r10,[rbp-0C8]
       mov       r11,r10
       mov       r12,rdx
       mov       rax,r11
       jmp       short M00_L20
M00_L17:
       cmp       rdx,r9
       je        near ptr M00_L52
       mov       [rbp-0B0],r12
       jmp       near ptr M00_L23
M00_L18:
       xor       ecx,ecx
       mov       [rbp-0B0],r12
M00_L19:
       test      ecx,ecx
       mov       rax,[rbp-0B8]
       mov       r12,[rbp-0B0]
       mov       r14,[rbp-0A8]
       jge       short M00_L16
M00_L20:
       mov       r15,[rbp-98]
       cmp       [r15],r13
       jne       near ptr M00_L42
       mov       edx,[r15+8]
       inc       edx
       cmp       edx,[r15+0C]
       jae       near ptr M00_L27
       mov       [r15+8],edx
       mov       ecx,[r15+8]
       cmp       ecx,[r15+0C]
       jae       near ptr M00_L53
       mov       rcx,[r15+10]
       mov       r8d,[r15+8]
       cmp       r8d,[rcx+8]
       jae       near ptr M00_L54
       mov       edx,r8d
       mov       rcx,[rcx+rdx*8+10]
       mov       rdx,rcx
       mov       rcx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonValOrderBy>b__14_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       cmp       [r14+18],rcx
       jne       near ptr M00_L43
       mov       r15,[rbp-98]
       mov       [rbp-0C0],rdx
       mov       rcx,[rdx+30]
       mov       r8,rcx
       mov       rcx,offset MT_System.Collections.Generic.GenericComparer<System.String>
       cmp       [rdi],rcx
       mov       rdi,[rbp-0A0]
       jne       near ptr M00_L45
       test      r8,r8
       je        near ptr M00_L47
       test      rax,rax
       je        near ptr M00_L49
       mov       [rbp-0C8],r8
       mov       [rbp-0B8],rax
       cmp       r8,rax
       je        near ptr M00_L18
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+238],2
       jle       near ptr M00_L50
       mov       rcx,[rcx+240]
       mov       r10,[rcx+10]
       test      r10,r10
       je        near ptr M00_L50
M00_L21:
       mov       rcx,[r10+10]
       test      rcx,rcx
       jne       short M00_L22
       mov       rcx,1D658400110
       mov       rcx,[rcx]
       test      rcx,rcx
       jne       short M00_L22
       mov       rcx,1D6584000F0
       mov       rcx,[rcx]
       test      rcx,rcx
       je        near ptr M00_L51
M00_L22:
       mov       r10,[rcx]
       mov       r10,[r10+48]
       call      qword ptr [r10+30]
       cmp       [rax],al
       mov       r10,[rbp-0C8]
       lea       rdx,[r10+0C]
       mov       [rbp-0C8],r10
       mov       r8d,[r10+8]
       mov       r11,[rbp-0B8]
       lea       r9,[r11+0C]
       mov       [rbp-0B8],r11
       mov       ecx,[r11+8]
       cmp       r8d,ecx
       je        near ptr M00_L17
       mov       [rbp-0B0],r12
M00_L23:
       mov       [rbp-48],rdx
       mov       [rbp-50],r9
       mov       rax,[rax+20]
       mov       [rsp+20],ecx
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rax
       mov       rax,7FFEFF96B650
       mov       [rbp-80],rax
       lea       rax,[M00_L24]
       mov       [rbp-70],rax
       lea       rax,[rbp-90]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFF5F2F93A0
       call      rax
M00_L24:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFF5F64F778],0
       je        short M00_L25
       call      qword ptr [7FFF5F63D608]; CORINFO_HELP_STOP_FOR_GC
M00_L25:
       mov       rcx,[rbp-88]
       mov       [rsi+8],rcx
       xor       ecx,ecx
       mov       [rbp-48],rcx
       mov       [rbp-50],rcx
       mov       rdi,[rbp-0A0]
       mov       r15,[rbp-98]
M00_L26:
       mov       ecx,eax
       jmp       near ptr M00_L19
M00_L27:
       mov       ecx,[r15+0C]
       mov       [r15+8],ecx
M00_L28:
       mov       dword ptr [rbp-40],1
       jmp       near ptr M00_L56
M00_L29:
       mov       ecx,[r12+0C]
       mov       [r12+8],ecx
       jmp       near ptr M00_L55
M00_L30:
       mov       rcx,r12
       mov       r11,7FFEFF640DE8
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M00_L55
       jmp       near ptr M00_L03
M00_L31:
       call      qword ptr [7FFF00047648]
       int       3
M00_L32:
       mov       rcx,r12
       mov       r11,7FFEFF640DF0
       call      qword ptr [r11]
       mov       r12,rax
M00_L33:
       mov       [rbp-0B0],r12
       mov       rdx,r12
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       mov       r12,[rbp-0B0]
       jmp       near ptr M00_L04
M00_L34:
       mov       [rbp-0B8],rax
       mov       r15,[rbp-98]
M00_L35:
       mov       rcx,r15
       mov       r11,7FFEFF640E10
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M00_L28
       mov       rcx,r15
       mov       r11,7FFEFF640E18
       call      qword ptr [r11]
       mov       rsi,rax
       mov       rdx,rsi
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       mov       rcx,rdi
       mov       r8,[rbp-0B8]
       mov       [rbp-0D0],rax
       mov       rdx,rax
       mov       r11,7FFEFF640E20
       call      qword ptr [r11]
       test      eax,eax
       jg        short M00_L35
       mov       r12,[rbp-0D0]
       mov       [rbp-0B8],r12
       mov       r12,rsi
       mov       r15,[rbp-98]
       jmp       short M00_L35
M00_L36:
       mov       ecx,2
       call      qword ptr [7FFF000476C0]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       rdx,rax
       jmp       near ptr M00_L10
M00_L37:
       call      qword ptr [7FFEFF975DA0]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rcx,rax
       jmp       near ptr M00_L11
M00_L38:
       xor       eax,eax
       mov       [rbp-0B0],r12
       jmp       near ptr M00_L15
M00_L39:
       mov       ecx,1
       mov       [rbp-0B8],rax
       jmp       near ptr M00_L08
M00_L40:
       test      rax,rax
       je        short M00_L41
       mov       ecx,0FFFFFFFF
       mov       [rbp-0B8],rax
       jmp       near ptr M00_L08
M00_L41:
       xor       ecx,ecx
       mov       [rbp-0B8],rax
       jmp       near ptr M00_L08
M00_L42:
       mov       [rbp-0B8],rax
       mov       rcx,r15
       mov       r11,7FFEFF640DF8
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M00_L28
       mov       rcx,r15
       mov       r11,7FFEFF640E00
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       short M00_L44
M00_L43:
       mov       [rbp-0B8],rax
M00_L44:
       mov       [rbp-0C0],rdx
       mov       r14,[rbp-0A8]
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       mov       [rbp-0C8],rax
       mov       rax,[rbp-0B8]
       mov       r15,[rbp-98]
       jmp       short M00_L46
M00_L45:
       mov       [rbp-0C8],r8
M00_L46:
       mov       rcx,rdi
       mov       [rbp-0B8],rax
       mov       r8,rax
       mov       rdx,[rbp-0C8]
       mov       r11,7FFEFF640E08
       call      qword ptr [r11]
       mov       ecx,eax
       mov       [rbp-0B0],r12
       jmp       near ptr M00_L19
M00_L47:
       mov       [rbp-0B8],rax
       test      rax,rax
       jne       short M00_L48
       mov       rax,[rbp-0B8]
       xor       ecx,ecx
       mov       [rbp-0C8],r8
       mov       [rbp-0B8],rax
       mov       [rbp-0B0],r12
       jmp       near ptr M00_L19
M00_L48:
       mov       rax,[rbp-0B8]
       mov       ecx,0FFFFFFFF
       mov       [rbp-0C8],r8
       mov       [rbp-0B8],rax
       mov       [rbp-0B0],r12
       jmp       near ptr M00_L19
M00_L49:
       mov       ecx,1
       mov       [rbp-0C8],r8
       mov       [rbp-0B8],rax
       mov       [rbp-0B0],r12
       jmp       near ptr M00_L19
M00_L50:
       mov       ecx,2
       call      qword ptr [7FFF000476C0]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       r10,rax
       jmp       near ptr M00_L21
M00_L51:
       call      qword ptr [7FFEFF975DA0]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rcx,rax
       jmp       near ptr M00_L22
M00_L52:
       xor       eax,eax
       mov       [rbp-0B0],r12
       jmp       near ptr M00_L26
M00_L53:
       mov       ecx,[r15+8]
       call      qword ptr [7FFF00047648]
       int       3
M00_L54:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L55:
       xor       ecx,ecx
       mov       [rbp-40],ecx
       xor       r12d,r12d
       mov       r15,[rbp-98]
M00_L56:
       cmp       [r15],r13
       jne       near ptr M00_L64
M00_L57:
       cmp       byte ptr [rbp-40],0
       je        near ptr M00_L65
       mov       [rbp-58],r12
       mov       rbx,[rbp+10]
       mov       r15,[rbx+60]
       mov       rdx,[rbp-58]
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [r15+8],rax
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
M00_L58:
       mov       ecx,11
       call      qword ptr [7FFEFF977DF8]
       int       3
M00_L59:
       mov       r13,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord>
       mov       rcx,r13
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       dword ptr [r12+8],0FFFFFFFF
       mov       [r12+0C],r14d
       lea       rcx,[r12+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L02
M00_L60:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdx,1D681400E58
       mov       rdx,[rdx]
       mov       rcx,r14
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonValOrderBy>b__14_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       call      qword ptr [7FFEFF6F6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1D681400E70
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L61:
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L01
M00_L62:
       mov       rcx,rdi
       mov       r11,7FFEFF640E30
       call      qword ptr [r11]
       mov       r12,rax
       jmp       near ptr M00_L02
M00_L63:
       mov       r11,7FFEFF640DE0
       call      qword ptr [r11]
       mov       r12,rax
       jmp       near ptr M00_L02
M00_L64:
       mov       rcx,r15
       mov       r11,7FFEFF640E28
       call      qword ptr [r11]
       jmp       near ptr M00_L57
M00_L65:
       call      qword ptr [7FFEFFE7FD08]
       int       3
       sub       rsp,38
       vzeroupper
       cmp       qword ptr [rbp-98],0
       je        short M00_L66
       mov       r13,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord>
       mov       r15,[rbp-98]
       cmp       [r15],r13
       je        short M00_L66
       mov       rcx,r15
       mov       r11,7FFEFF640E28
       call      qword ptr [r11]
M00_L66:
       nop
       add       rsp,38
       ret
; Total bytes of code 2622
```
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonValOrderBy>b__14_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       mov       rax,[rdx+30]
       ret
; Total bytes of code 5
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FFF51600D78]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       ecx,ebx
       and       ecx,0FFFFFF
       mov       edx,ecx
       mov       r8d,ebx
       sar       r8d,18
       jne       short M02_L01
       cmp       [rax],ecx
       jle       short M02_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M02_L03
M02_L00:
       add       rsp,20
       pop       rbx
       ret
M02_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M02_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M02_L00
M02_L02:
       cmp       [rax+4],edx
       jle       short M02_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M02_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M02_L03
       jmp       short M02_L00
M02_L03:
       mov       ecx,ebx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax]
; Total bytes of code 130
```
```assembly
; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       push      rsi
       push      rbx
       sub       rsp,28
       call      qword ptr [7FFF515E87D0]
       mov       rbx,rax
       mov       rsi,rbx
       call      qword ptr [7FFF515FFA88]
       mov       rdx,rax
       test      rsi,rsi
       je        short M03_L00
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFF51600C28]
       mov       rax,[rbx]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M03_L00:
       call      qword ptr [7FFF515FE468]
       int       3
; Total bytes of code 61
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M04_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L00:
       call      qword ptr [7FFF0004E4C0]
       int       3
; Total bytes of code 44
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M05_L00
       ret
M05_L00:
       jmp       qword ptr [7FFEFF6F5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.PersonValOrderBy()
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
       xor       eax,eax
       mov       [rbp-58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp-40],rax
       mov       rbx,rcx
       lea       rcx,[rbp-90]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rcx,rsp
       mov       [rbp-78],rcx
       mov       rcx,rbp
       mov       [rbp-68],rcx
       mov       [rbp+10],rbx
       mov       rdi,[rbx+280]
       mov       rcx,1C893002E68
       mov       r14,[rcx]
       test      r14,r14
       je        near ptr M00_L66
M00_L00:
       mov       rcx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [r15+10],eax
       lea       rcx,[r15+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        near ptr M00_L64
       xor       ecx,ecx
       mov       [r15+20],rcx
       lea       rcx,[r15+28]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,1C893000A08
       mov       rdx,[rcx]
       lea       rcx,[r15+30]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [r15+48],0
       mov       rcx,[r15+18]
       mov       rax,offset MT_System.Collections.ObjectModel.Collection<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord>
       cmp       [rcx],rax
       jne       near ptr M00_L69
       mov       rdi,[rcx+8]
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord[]
       cmp       [rdi],rcx
       jne       near ptr M00_L68
       mov       r14d,[rdi+8]
       test      r14d,r14d
       jne       near ptr M00_L65
       mov       r13,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord>
       mov       rcx,r13
       test      byte ptr [7FFF0002D680],1
       je        near ptr M00_L67
M00_L01:
       mov       rcx,1C893002E90
       mov       r12,[rcx]
M00_L02:
       mov       [rbp-98],r12
       mov       r13,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord>
       cmp       [r12],r13
       jne       near ptr M00_L36
       mov       ecx,[r12+8]
       inc       ecx
       cmp       ecx,[r12+0C]
       jae       near ptr M00_L35
       mov       [r12+8],ecx
M00_L03:
       mov       rdi,[r15+30]
       mov       [rbp-0A0],rdi
       mov       r14,[r15+28]
       mov       [rbp-0A8],r14
       cmp       [r12],r13
       jne       near ptr M00_L38
       mov       ecx,[r12+8]
       cmp       ecx,[r12+0C]
       jae       near ptr M00_L37
       mov       rax,[r12+10]
       cmp       ecx,[rax+8]
       jae       near ptr M00_L60
       mov       r12,[rax+rcx*8+10]
       mov       rcx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonValOrderBy>b__14_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       cmp       [r14+18],rcx
       jne       near ptr M00_L39
       mov       rax,[r12+30]
M00_L04:
       cmp       byte ptr [r15+48],0
       jne       near ptr M00_L29
       test      r14,r14
       je        near ptr M00_L20
       test      rdi,rdi
       je        near ptr M00_L20
       mov       r15,[rbp-98]
       cmp       [r15],r13
       jne       near ptr M00_L20
       mov       rcx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonValOrderBy>b__14_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       cmp       [r14+18],rcx
       jne       near ptr M00_L20
       mov       rcx,offset MT_System.Collections.Generic.GenericComparer<System.String>
       cmp       [rdi],rcx
       jne       near ptr M00_L20
       jmp       short M00_L09
M00_L05:
       mov       rdi,[rbp-0C0]
       mov       rax,r14
       mov       [rbp-0B0],rdi
       mov       r12,[rbp-0B0]
       jmp       short M00_L09
M00_L06:
       cmp       rdx,r9
       je        near ptr M00_L44
       mov       [rbp-0B0],r12
       jmp       near ptr M00_L12
M00_L07:
       xor       ecx,ecx
M00_L08:
       test      ecx,ecx
       mov       rax,[rbp-0B8]
       mov       r15,[rbp-98]
       jge       short M00_L05
M00_L09:
       mov       edx,[r15+8]
       inc       edx
       cmp       edx,[r15+0C]
       jae       near ptr M00_L27
       mov       [r15+8],edx
       mov       r8d,[r15+8]
       cmp       r8d,[r15+0C]
       jae       near ptr M00_L59
       mov       r14,[r15+10]
       cmp       r8d,[r14+8]
       jae       near ptr M00_L60
       mov       ecx,r8d
       mov       rdi,[r14+rcx*8+10]
       mov       [rbp-0C0],rdi
       mov       r14,[rdi+30]
       test      r14,r14
       je        near ptr M00_L46
       test      rax,rax
       je        near ptr M00_L45
       mov       [rbp-0B8],rax
       cmp       r14,rax
       je        short M00_L07
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],2
       jle       near ptr M00_L42
       mov       rcx,[rcx+240]
       mov       rdx,[rcx+10]
       test      rdx,rdx
       je        near ptr M00_L42
M00_L10:
       mov       rcx,[rdx+10]
       test      rcx,rcx
       jne       short M00_L11
       mov       rcx,1C893000110
       mov       rcx,[rcx]
       test      rcx,rcx
       jne       short M00_L11
       mov       rcx,1C8930000F0
       mov       rcx,[rcx]
       test      rcx,rcx
       je        near ptr M00_L43
M00_L11:
       mov       rdx,[rcx]
       mov       rdx,[rdx+48]
       call      qword ptr [rdx+30]
       cmp       [rax],al
       lea       rdx,[r14+0C]
       mov       [rbp-0C8],r14
       mov       r8d,[r14+8]
       mov       r10,[rbp-0B8]
       lea       r9,[r10+0C]
       mov       [rbp-0B8],r10
       mov       r11d,[r10+8]
       cmp       r8d,r11d
       je        near ptr M00_L06
       mov       [rbp-0B0],r12
M00_L12:
       mov       [rbp-48],rdx
       mov       [rbp-50],r9
       mov       rcx,[rax+20]
       mov       [rsp+20],r11d
       xor       eax,eax
       mov       [rsp+28],eax
       mov       rax,7FFEFF98B650
       mov       [rbp-80],rax
       lea       rax,[M00_L13]
       mov       [rbp-70],rax
       lea       rax,[rbp-90]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFF5F2F93A0
       call      rax
M00_L13:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFF5F64F778],0
       je        short M00_L14
       call      qword ptr [7FFF5F63D608]; CORINFO_HELP_STOP_FOR_GC
M00_L14:
       mov       rcx,[rbp-88]
       mov       [rsi+8],rcx
       xor       ecx,ecx
       mov       [rbp-48],rcx
       mov       [rbp-50],rcx
M00_L15:
       mov       ecx,eax
       mov       r12,[rbp-0B0]
       mov       r14,[rbp-0C8]
       jmp       near ptr M00_L08
M00_L16:
       mov       rdx,[rbp-0C0]
       mov       r10,[rbp-0C8]
       mov       r11,r10
       mov       r12,rdx
       mov       rax,r11
       jmp       short M00_L20
M00_L17:
       cmp       rdx,r9
       je        near ptr M00_L58
       mov       [rbp-0B0],r12
       jmp       near ptr M00_L23
M00_L18:
       xor       ecx,ecx
       mov       [rbp-0B0],r12
M00_L19:
       test      ecx,ecx
       mov       rax,[rbp-0B8]
       mov       r12,[rbp-0B0]
       mov       r14,[rbp-0A8]
       jge       short M00_L16
M00_L20:
       mov       r15,[rbp-98]
       cmp       [r15],r13
       jne       near ptr M00_L48
       mov       edx,[r15+8]
       inc       edx
       cmp       edx,[r15+0C]
       jae       near ptr M00_L27
       mov       [r15+8],edx
       mov       ecx,[r15+8]
       cmp       ecx,[r15+0C]
       jae       near ptr M00_L59
       mov       rcx,[r15+10]
       mov       r8d,[r15+8]
       cmp       r8d,[rcx+8]
       jae       near ptr M00_L60
       mov       edx,r8d
       mov       rcx,[rcx+rdx*8+10]
       mov       rdx,rcx
       mov       rcx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonValOrderBy>b__14_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       cmp       [r14+18],rcx
       jne       near ptr M00_L49
       mov       r15,[rbp-98]
       mov       [rbp-0C0],rdx
       mov       rcx,[rdx+30]
       mov       r8,rcx
       mov       rcx,offset MT_System.Collections.Generic.GenericComparer<System.String>
       cmp       [rdi],rcx
       mov       rdi,[rbp-0A0]
       jne       near ptr M00_L51
       test      r8,r8
       je        near ptr M00_L53
       test      rax,rax
       je        near ptr M00_L55
       mov       [rbp-0C8],r8
       mov       [rbp-0B8],rax
       cmp       r8,rax
       je        near ptr M00_L18
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],2
       jle       near ptr M00_L56
       mov       rcx,[rcx+240]
       mov       r10,[rcx+10]
       test      r10,r10
       je        near ptr M00_L56
M00_L21:
       mov       rcx,[r10+10]
       test      rcx,rcx
       jne       short M00_L22
       mov       rcx,1C893000110
       mov       rcx,[rcx]
       test      rcx,rcx
       jne       short M00_L22
       mov       rcx,1C8930000F0
       mov       rcx,[rcx]
       test      rcx,rcx
       je        near ptr M00_L57
M00_L22:
       mov       r10,[rcx]
       mov       r10,[r10+48]
       call      qword ptr [r10+30]
       cmp       [rax],al
       mov       r10,[rbp-0C8]
       lea       rdx,[r10+0C]
       mov       [rbp-0C8],r10
       mov       r8d,[r10+8]
       mov       r11,[rbp-0B8]
       lea       r9,[r11+0C]
       mov       [rbp-0B8],r11
       mov       ecx,[r11+8]
       cmp       r8d,ecx
       je        near ptr M00_L17
       mov       [rbp-0B0],r12
M00_L23:
       mov       [rbp-48],rdx
       mov       [rbp-50],r9
       mov       rax,[rax+20]
       mov       [rsp+20],ecx
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rax
       mov       rax,7FFEFF98B650
       mov       [rbp-80],rax
       lea       rax,[M00_L24]
       mov       [rbp-70],rax
       lea       rax,[rbp-90]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFF5F2F93A0
       call      rax
M00_L24:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFF5F64F778],0
       je        short M00_L25
       call      qword ptr [7FFF5F63D608]; CORINFO_HELP_STOP_FOR_GC
M00_L25:
       mov       rcx,[rbp-88]
       mov       [rsi+8],rcx
       xor       ecx,ecx
       mov       [rbp-48],rcx
       mov       [rbp-50],rcx
       mov       rdi,[rbp-0A0]
       mov       r15,[rbp-98]
M00_L26:
       mov       ecx,eax
       jmp       near ptr M00_L19
M00_L27:
       mov       edx,[r15+0C]
       mov       [r15+8],edx
M00_L28:
       mov       dword ptr [rbp-40],1
       jmp       near ptr M00_L62
M00_L29:
       mov       r15,[rbp-98]
       cmp       [r15],r13
       jne       near ptr M00_L32
M00_L30:
       mov       r8d,[r15+8]
       inc       r8d
       cmp       r8d,[r15+0C]
       jae       near ptr M00_L34
       mov       [r15+8],r8d
       mov       edx,[r15+8]
       cmp       edx,[r15+0C]
       mov       [rbp-0B8],rax
       jae       near ptr M00_L41
       mov       rsi,[r15+10]
       mov       r10d,[r15+8]
       cmp       r10d,[rsi+8]
       jae       near ptr M00_L60
       mov       edx,r10d
       mov       rsi,[rsi+rdx*8+10]
       mov       rdx,rsi
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       mov       rcx,rdi
       mov       r8,[rbp-0B8]
       mov       [rbp-0D0],rax
       mov       rdx,rax
       mov       r11,7FFEFF660E20
       call      qword ptr [r11]
       test      eax,eax
       mov       rax,[rbp-0B8]
       jg        short M00_L30
       mov       r12,[rbp-0D0]
       mov       [rbp-0B8],r12
       mov       r12,rsi
       mov       rax,[rbp-0B8]
       jmp       near ptr M00_L30
M00_L31:
       mov       r12,[rbp-0D0]
       mov       rax,r12
       mov       r12,rsi
M00_L32:
       cmp       [r15],r13
       jne       near ptr M00_L40
       mov       r8d,[r15+8]
       inc       r8d
       cmp       r8d,[r15+0C]
       jae       short M00_L34
       mov       [r15+8],r8d
       mov       ecx,[r15+8]
       cmp       ecx,[r15+0C]
       jae       near ptr M00_L41
       mov       rsi,[r15+10]
       mov       r10d,[r15+8]
       cmp       r10d,[rsi+8]
       jae       near ptr M00_L60
       mov       ecx,r10d
       mov       rsi,[rsi+rcx*8+10]
       mov       [rbp-0B8],rax
M00_L33:
       mov       rdx,rsi
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       mov       rcx,rdi
       mov       r8,[rbp-0B8]
       mov       [rbp-0D0],rax
       mov       rdx,rax
       mov       r11,7FFEFF660E20
       call      qword ptr [r11]
       test      eax,eax
       mov       rax,[rbp-0B8]
       jg        short M00_L32
       jmp       near ptr M00_L31
M00_L34:
       mov       ecx,[r15+0C]
       mov       [r15+8],ecx
       jmp       near ptr M00_L28
M00_L35:
       mov       ecx,[r12+0C]
       mov       [r12+8],ecx
       jmp       near ptr M00_L61
M00_L36:
       mov       rcx,r12
       mov       r11,7FFEFF660DE8
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M00_L61
       jmp       near ptr M00_L03
M00_L37:
       call      qword ptr [7FFF00067630]
       int       3
M00_L38:
       mov       rcx,r12
       mov       r11,7FFEFF660DF0
       call      qword ptr [r11]
       mov       r12,rax
M00_L39:
       mov       [rbp-0B0],r12
       mov       rdx,r12
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       mov       r12,[rbp-0B0]
       jmp       near ptr M00_L04
M00_L40:
       mov       [rbp-0B8],rax
       mov       rcx,r15
       mov       r11,7FFEFF660E10
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M00_L28
       mov       rcx,r15
       mov       r11,7FFEFF660E18
       call      qword ptr [r11]
       mov       rsi,rax
       jmp       near ptr M00_L33
M00_L41:
       mov       ecx,[r15+8]
       call      qword ptr [7FFF00067630]
       int       3
M00_L42:
       mov       ecx,2
       call      qword ptr [7FFF000676C0]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       rdx,rax
       jmp       near ptr M00_L10
M00_L43:
       call      qword ptr [7FFEFF995DA0]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rcx,rax
       jmp       near ptr M00_L11
M00_L44:
       xor       eax,eax
       mov       [rbp-0B0],r12
       jmp       near ptr M00_L15
M00_L45:
       mov       ecx,1
       mov       [rbp-0B8],rax
       jmp       near ptr M00_L08
M00_L46:
       test      rax,rax
       je        short M00_L47
       mov       ecx,0FFFFFFFF
       mov       [rbp-0B8],rax
       jmp       near ptr M00_L08
M00_L47:
       xor       ecx,ecx
       mov       [rbp-0B8],rax
       jmp       near ptr M00_L08
M00_L48:
       mov       [rbp-0B8],rax
       mov       rcx,r15
       mov       r11,7FFEFF660DF8
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M00_L28
       mov       rcx,r15
       mov       r11,7FFEFF660E00
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       short M00_L50
M00_L49:
       mov       [rbp-0B8],rax
M00_L50:
       mov       [rbp-0C0],rdx
       mov       r14,[rbp-0A8]
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       mov       [rbp-0C8],rax
       mov       rax,[rbp-0B8]
       mov       r15,[rbp-98]
       jmp       short M00_L52
M00_L51:
       mov       [rbp-0C8],r8
M00_L52:
       mov       rcx,rdi
       mov       [rbp-0B8],rax
       mov       r8,rax
       mov       rdx,[rbp-0C8]
       mov       r11,7FFEFF660E08
       call      qword ptr [r11]
       mov       ecx,eax
       mov       [rbp-0B0],r12
       jmp       near ptr M00_L19
M00_L53:
       mov       [rbp-0B8],rax
       test      rax,rax
       jne       short M00_L54
       mov       rax,[rbp-0B8]
       xor       ecx,ecx
       mov       [rbp-0C8],r8
       mov       [rbp-0B8],rax
       mov       [rbp-0B0],r12
       jmp       near ptr M00_L19
M00_L54:
       mov       rax,[rbp-0B8]
       mov       ecx,0FFFFFFFF
       mov       [rbp-0C8],r8
       mov       [rbp-0B8],rax
       mov       [rbp-0B0],r12
       jmp       near ptr M00_L19
M00_L55:
       mov       ecx,1
       mov       [rbp-0C8],r8
       mov       [rbp-0B8],rax
       mov       [rbp-0B0],r12
       jmp       near ptr M00_L19
M00_L56:
       mov       ecx,2
       call      qword ptr [7FFF000676C0]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       r10,rax
       jmp       near ptr M00_L21
M00_L57:
       call      qword ptr [7FFEFF995DA0]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rcx,rax
       jmp       near ptr M00_L22
M00_L58:
       xor       eax,eax
       mov       [rbp-0B0],r12
       jmp       near ptr M00_L26
M00_L59:
       mov       ecx,[r15+8]
       call      qword ptr [7FFF00067630]
       int       3
M00_L60:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L61:
       xor       ecx,ecx
       mov       [rbp-40],ecx
       xor       r12d,r12d
       mov       r15,[rbp-98]
M00_L62:
       cmp       [r15],r13
       jne       near ptr M00_L70
M00_L63:
       cmp       byte ptr [rbp-40],0
       je        near ptr M00_L71
       mov       [rbp-58],r12
       mov       rbx,[rbp+10]
       mov       r15,[rbx+60]
       mov       rdx,[rbp-58]
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [r15+8],rax
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
M00_L64:
       mov       ecx,11
       call      qword ptr [7FFEFF997DF8]
       int       3
M00_L65:
       mov       r13,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord>
       mov       rcx,r13
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       dword ptr [r12+8],0FFFFFFFF
       mov       [r12+0C],r14d
       lea       rcx,[r12+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L02
M00_L66:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdx,1C893002E50
       mov       rdx,[rdx]
       mov       rcx,r14
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonValOrderBy>b__14_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       call      qword ptr [7FFEFF716BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1C893002E68
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L67:
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L01
M00_L68:
       mov       rcx,rdi
       mov       r11,7FFEFF660E30
       call      qword ptr [r11]
       mov       r12,rax
       jmp       near ptr M00_L02
M00_L69:
       mov       r11,7FFEFF660DE0
       call      qword ptr [r11]
       mov       r12,rax
       jmp       near ptr M00_L02
M00_L70:
       mov       rcx,r15
       mov       r11,7FFEFF660E28
       call      qword ptr [r11]
       jmp       near ptr M00_L63
M00_L71:
       call      qword ptr [7FFEFFE9FE70]
       int       3
       sub       rsp,38
       vzeroupper
       cmp       qword ptr [rbp-98],0
       je        short M00_L72
       mov       r13,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord>
       mov       r15,[rbp-98]
       cmp       [r15],r13
       je        short M00_L72
       mov       rcx,r15
       mov       r11,7FFEFF660E28
       call      qword ptr [r11]
M00_L72:
       nop
       add       rsp,38
       ret
; Total bytes of code 2884
```
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonValOrderBy>b__14_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       mov       rax,[rdx+30]
       ret
; Total bytes of code 5
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FFF51600D78]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       ecx,ebx
       and       ecx,0FFFFFF
       mov       edx,ecx
       mov       r8d,ebx
       sar       r8d,18
       jne       short M02_L01
       cmp       [rax],ecx
       jle       short M02_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M02_L03
M02_L00:
       add       rsp,20
       pop       rbx
       ret
M02_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M02_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M02_L00
M02_L02:
       cmp       [rax+4],edx
       jle       short M02_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M02_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M02_L03
       jmp       short M02_L00
M02_L03:
       mov       ecx,ebx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax]
; Total bytes of code 130
```
```assembly
; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       push      rsi
       push      rbx
       sub       rsp,28
       call      qword ptr [7FFF515E87D0]
       mov       rbx,rax
       mov       rsi,rbx
       call      qword ptr [7FFF515FFA88]
       mov       rdx,rax
       test      rsi,rsi
       je        short M03_L00
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFF51600C28]
       mov       rax,[rbx]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M03_L00:
       call      qword ptr [7FFF515FE468]
       int       3
; Total bytes of code 61
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M04_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L00:
       call      qword ptr [7FFF0006E640]
       int       3
; Total bytes of code 44
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M05_L00
       ret
M05_L00:
       jmp       qword ptr [7FFEFF715C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.PersonValOrderBy()
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
       xor       eax,eax
       mov       [rbp-58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp-40],rax
       mov       rbx,rcx
       lea       rcx,[rbp-90]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rcx,rsp
       mov       [rbp-78],rcx
       mov       rcx,rbp
       mov       [rbp-68],rcx
       mov       [rbp+10],rbx
       mov       rdi,[rbx+280]
       mov       rcx,1EF3D000E70
       mov       r14,[rcx]
       test      r14,r14
       je        near ptr M00_L66
M00_L00:
       mov       rcx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [r15+10],eax
       lea       rcx,[r15+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        near ptr M00_L64
       xor       ecx,ecx
       mov       [r15+20],rcx
       lea       rcx,[r15+28]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,1EF10000A08
       mov       rdx,[rcx]
       lea       rcx,[r15+30]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [r15+48],0
       mov       rcx,[r15+18]
       mov       rax,offset MT_System.Collections.ObjectModel.Collection<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord>
       cmp       [rcx],rax
       jne       near ptr M00_L69
       mov       rdi,[rcx+8]
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord[]
       cmp       [rdi],rcx
       jne       near ptr M00_L68
       mov       r14d,[rdi+8]
       test      r14d,r14d
       jne       near ptr M00_L65
       mov       r13,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord>
       mov       rcx,r13
       test      byte ptr [7FFF000096F8],1
       je        near ptr M00_L67
M00_L01:
       mov       rcx,1EF3D000E98
       mov       r12,[rcx]
M00_L02:
       mov       [rbp-98],r12
       mov       r13,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord>
       cmp       [r12],r13
       jne       near ptr M00_L36
       mov       ecx,[r12+8]
       inc       ecx
       cmp       ecx,[r12+0C]
       jae       near ptr M00_L35
       mov       [r12+8],ecx
M00_L03:
       mov       rdi,[r15+30]
       mov       [rbp-0A0],rdi
       mov       r14,[r15+28]
       mov       [rbp-0A8],r14
       cmp       [r12],r13
       jne       near ptr M00_L38
       mov       ecx,[r12+8]
       cmp       ecx,[r12+0C]
       jae       near ptr M00_L37
       mov       rax,[r12+10]
       cmp       ecx,[rax+8]
       jae       near ptr M00_L60
       mov       r12,[rax+rcx*8+10]
       mov       rcx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonValOrderBy>b__14_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       cmp       [r14+18],rcx
       jne       near ptr M00_L39
       mov       rax,[r12+30]
M00_L04:
       cmp       byte ptr [r15+48],0
       jne       near ptr M00_L29
       test      r14,r14
       je        near ptr M00_L20
       test      rdi,rdi
       je        near ptr M00_L20
       mov       r15,[rbp-98]
       cmp       [r15],r13
       jne       near ptr M00_L20
       mov       rcx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonValOrderBy>b__14_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       cmp       [r14+18],rcx
       jne       near ptr M00_L20
       mov       rcx,offset MT_System.Collections.Generic.GenericComparer<System.String>
       cmp       [rdi],rcx
       jne       near ptr M00_L20
       jmp       short M00_L09
M00_L05:
       mov       rdi,[rbp-0C0]
       mov       rax,r14
       mov       [rbp-0B0],rdi
       mov       r12,[rbp-0B0]
       jmp       short M00_L09
M00_L06:
       cmp       rdx,r9
       je        near ptr M00_L44
       mov       [rbp-0B0],r12
       jmp       near ptr M00_L12
M00_L07:
       xor       ecx,ecx
M00_L08:
       test      ecx,ecx
       mov       rax,[rbp-0B8]
       mov       r15,[rbp-98]
       jge       short M00_L05
M00_L09:
       mov       edx,[r15+8]
       inc       edx
       cmp       edx,[r15+0C]
       jae       near ptr M00_L27
       mov       [r15+8],edx
       mov       r8d,[r15+8]
       cmp       r8d,[r15+0C]
       jae       near ptr M00_L59
       mov       r14,[r15+10]
       cmp       r8d,[r14+8]
       jae       near ptr M00_L60
       mov       ecx,r8d
       mov       rdi,[r14+rcx*8+10]
       mov       [rbp-0C0],rdi
       mov       r14,[rdi+30]
       test      r14,r14
       je        near ptr M00_L46
       test      rax,rax
       je        near ptr M00_L45
       mov       [rbp-0B8],rax
       cmp       r14,rax
       je        short M00_L07
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],2
       jle       near ptr M00_L42
       mov       rcx,[rcx+240]
       mov       rdx,[rcx+10]
       test      rdx,rdx
       je        near ptr M00_L42
M00_L10:
       mov       rcx,[rdx+10]
       test      rcx,rcx
       jne       short M00_L11
       mov       rcx,1EF10000110
       mov       rcx,[rcx]
       test      rcx,rcx
       jne       short M00_L11
       mov       rcx,1EF100000F0
       mov       rcx,[rcx]
       test      rcx,rcx
       je        near ptr M00_L43
M00_L11:
       mov       rdx,[rcx]
       mov       rdx,[rdx+48]
       call      qword ptr [rdx+30]
       cmp       [rax],al
       lea       rdx,[r14+0C]
       mov       [rbp-0C8],r14
       mov       r8d,[r14+8]
       mov       r10,[rbp-0B8]
       lea       r9,[r10+0C]
       mov       [rbp-0B8],r10
       mov       r11d,[r10+8]
       cmp       r8d,r11d
       je        near ptr M00_L06
       mov       [rbp-0B0],r12
M00_L12:
       mov       [rbp-48],rdx
       mov       [rbp-50],r9
       mov       rcx,[rax+20]
       mov       [rsp+20],r11d
       xor       eax,eax
       mov       [rsp+28],eax
       mov       rax,7FFEFF96B650
       mov       [rbp-80],rax
       lea       rax,[M00_L13]
       mov       [rbp-70],rax
       lea       rax,[rbp-90]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFF5F2F93A0
       call      rax
M00_L13:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFF5F64F778],0
       je        short M00_L14
       call      qword ptr [7FFF5F63D608]; CORINFO_HELP_STOP_FOR_GC
M00_L14:
       mov       rcx,[rbp-88]
       mov       [rsi+8],rcx
       xor       ecx,ecx
       mov       [rbp-48],rcx
       mov       [rbp-50],rcx
M00_L15:
       mov       ecx,eax
       mov       r12,[rbp-0B0]
       mov       r14,[rbp-0C8]
       jmp       near ptr M00_L08
M00_L16:
       mov       rdx,[rbp-0C0]
       mov       r10,[rbp-0C8]
       mov       r11,r10
       mov       r12,rdx
       mov       rax,r11
       jmp       short M00_L20
M00_L17:
       cmp       rdx,r9
       je        near ptr M00_L58
       mov       [rbp-0B0],r12
       jmp       near ptr M00_L23
M00_L18:
       xor       ecx,ecx
       mov       [rbp-0B0],r12
M00_L19:
       test      ecx,ecx
       mov       rax,[rbp-0B8]
       mov       r12,[rbp-0B0]
       mov       r14,[rbp-0A8]
       jge       short M00_L16
M00_L20:
       mov       r15,[rbp-98]
       cmp       [r15],r13
       jne       near ptr M00_L48
       mov       edx,[r15+8]
       inc       edx
       cmp       edx,[r15+0C]
       jae       near ptr M00_L27
       mov       [r15+8],edx
       mov       ecx,[r15+8]
       cmp       ecx,[r15+0C]
       jae       near ptr M00_L59
       mov       rcx,[r15+10]
       mov       r8d,[r15+8]
       cmp       r8d,[rcx+8]
       jae       near ptr M00_L60
       mov       edx,r8d
       mov       rcx,[rcx+rdx*8+10]
       mov       rdx,rcx
       mov       rcx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonValOrderBy>b__14_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       cmp       [r14+18],rcx
       jne       near ptr M00_L49
       mov       r15,[rbp-98]
       mov       [rbp-0C0],rdx
       mov       rcx,[rdx+30]
       mov       r8,rcx
       mov       rcx,offset MT_System.Collections.Generic.GenericComparer<System.String>
       cmp       [rdi],rcx
       mov       rdi,[rbp-0A0]
       jne       near ptr M00_L51
       test      r8,r8
       je        near ptr M00_L53
       test      rax,rax
       je        near ptr M00_L55
       mov       [rbp-0C8],r8
       mov       [rbp-0B8],rax
       cmp       r8,rax
       je        near ptr M00_L18
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],2
       jle       near ptr M00_L56
       mov       rcx,[rcx+240]
       mov       r10,[rcx+10]
       test      r10,r10
       je        near ptr M00_L56
M00_L21:
       mov       rcx,[r10+10]
       test      rcx,rcx
       jne       short M00_L22
       mov       rcx,1EF10000110
       mov       rcx,[rcx]
       test      rcx,rcx
       jne       short M00_L22
       mov       rcx,1EF100000F0
       mov       rcx,[rcx]
       test      rcx,rcx
       je        near ptr M00_L57
M00_L22:
       mov       r10,[rcx]
       mov       r10,[r10+48]
       call      qword ptr [r10+30]
       cmp       [rax],al
       mov       r10,[rbp-0C8]
       lea       rdx,[r10+0C]
       mov       [rbp-0C8],r10
       mov       r8d,[r10+8]
       mov       r11,[rbp-0B8]
       lea       r9,[r11+0C]
       mov       [rbp-0B8],r11
       mov       ecx,[r11+8]
       cmp       r8d,ecx
       je        near ptr M00_L17
       mov       [rbp-0B0],r12
M00_L23:
       mov       [rbp-48],rdx
       mov       [rbp-50],r9
       mov       rax,[rax+20]
       mov       [rsp+20],ecx
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rax
       mov       rax,7FFEFF96B650
       mov       [rbp-80],rax
       lea       rax,[M00_L24]
       mov       [rbp-70],rax
       lea       rax,[rbp-90]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFF5F2F93A0
       call      rax
M00_L24:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFF5F64F778],0
       je        short M00_L25
       call      qword ptr [7FFF5F63D608]; CORINFO_HELP_STOP_FOR_GC
M00_L25:
       mov       rcx,[rbp-88]
       mov       [rsi+8],rcx
       xor       ecx,ecx
       mov       [rbp-48],rcx
       mov       [rbp-50],rcx
       mov       rdi,[rbp-0A0]
       mov       r15,[rbp-98]
M00_L26:
       mov       ecx,eax
       jmp       near ptr M00_L19
M00_L27:
       mov       edx,[r15+0C]
       mov       [r15+8],edx
M00_L28:
       mov       dword ptr [rbp-40],1
       jmp       near ptr M00_L62
M00_L29:
       mov       r15,[rbp-98]
       cmp       [r15],r13
       jne       near ptr M00_L32
M00_L30:
       mov       r8d,[r15+8]
       inc       r8d
       cmp       r8d,[r15+0C]
       jae       near ptr M00_L34
       mov       [r15+8],r8d
       mov       edx,[r15+8]
       cmp       edx,[r15+0C]
       mov       [rbp-0B8],rax
       jae       near ptr M00_L41
       mov       rsi,[r15+10]
       mov       r10d,[r15+8]
       cmp       r10d,[rsi+8]
       jae       near ptr M00_L60
       mov       edx,r10d
       mov       rsi,[rsi+rdx*8+10]
       mov       rdx,rsi
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       mov       rcx,rdi
       mov       r8,[rbp-0B8]
       mov       [rbp-0D0],rax
       mov       rdx,rax
       mov       r11,7FFEFF640E20
       call      qword ptr [r11]
       test      eax,eax
       mov       rax,[rbp-0B8]
       jg        short M00_L30
       mov       r12,[rbp-0D0]
       mov       [rbp-0B8],r12
       mov       r12,rsi
       mov       rax,[rbp-0B8]
       jmp       near ptr M00_L30
M00_L31:
       mov       r12,[rbp-0D0]
       mov       rax,r12
       mov       r12,rsi
M00_L32:
       cmp       [r15],r13
       jne       near ptr M00_L40
       mov       r8d,[r15+8]
       inc       r8d
       cmp       r8d,[r15+0C]
       jae       short M00_L34
       mov       [r15+8],r8d
       mov       ecx,[r15+8]
       cmp       ecx,[r15+0C]
       jae       near ptr M00_L41
       mov       rsi,[r15+10]
       mov       r10d,[r15+8]
       cmp       r10d,[rsi+8]
       jae       near ptr M00_L60
       mov       ecx,r10d
       mov       rsi,[rsi+rcx*8+10]
       mov       [rbp-0B8],rax
M00_L33:
       mov       rdx,rsi
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       mov       rcx,rdi
       mov       r8,[rbp-0B8]
       mov       [rbp-0D0],rax
       mov       rdx,rax
       mov       r11,7FFEFF640E20
       call      qword ptr [r11]
       test      eax,eax
       mov       rax,[rbp-0B8]
       jg        short M00_L32
       jmp       near ptr M00_L31
M00_L34:
       mov       ecx,[r15+0C]
       mov       [r15+8],ecx
       jmp       near ptr M00_L28
M00_L35:
       mov       ecx,[r12+0C]
       mov       [r12+8],ecx
       jmp       near ptr M00_L61
M00_L36:
       mov       rcx,r12
       mov       r11,7FFEFF640DE8
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M00_L61
       jmp       near ptr M00_L03
M00_L37:
       call      qword ptr [7FFF00047750]
       int       3
M00_L38:
       mov       rcx,r12
       mov       r11,7FFEFF640DF0
       call      qword ptr [r11]
       mov       r12,rax
M00_L39:
       mov       [rbp-0B0],r12
       mov       rdx,r12
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       mov       r12,[rbp-0B0]
       jmp       near ptr M00_L04
M00_L40:
       mov       [rbp-0B8],rax
       mov       rcx,r15
       mov       r11,7FFEFF640E10
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M00_L28
       mov       rcx,r15
       mov       r11,7FFEFF640E18
       call      qword ptr [r11]
       mov       rsi,rax
       jmp       near ptr M00_L33
M00_L41:
       mov       ecx,[r15+8]
       call      qword ptr [7FFF00047750]
       int       3
M00_L42:
       mov       ecx,2
       call      qword ptr [7FFF000477C8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       rdx,rax
       jmp       near ptr M00_L10
M00_L43:
       call      qword ptr [7FFEFF975DA0]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rcx,rax
       jmp       near ptr M00_L11
M00_L44:
       xor       eax,eax
       mov       [rbp-0B0],r12
       jmp       near ptr M00_L15
M00_L45:
       mov       ecx,1
       mov       [rbp-0B8],rax
       jmp       near ptr M00_L08
M00_L46:
       test      rax,rax
       je        short M00_L47
       mov       ecx,0FFFFFFFF
       mov       [rbp-0B8],rax
       jmp       near ptr M00_L08
M00_L47:
       xor       ecx,ecx
       mov       [rbp-0B8],rax
       jmp       near ptr M00_L08
M00_L48:
       mov       [rbp-0B8],rax
       mov       rcx,r15
       mov       r11,7FFEFF640DF8
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M00_L28
       mov       rcx,r15
       mov       r11,7FFEFF640E00
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       short M00_L50
M00_L49:
       mov       [rbp-0B8],rax
M00_L50:
       mov       [rbp-0C0],rdx
       mov       r14,[rbp-0A8]
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       mov       [rbp-0C8],rax
       mov       rax,[rbp-0B8]
       mov       r15,[rbp-98]
       jmp       short M00_L52
M00_L51:
       mov       [rbp-0C8],r8
M00_L52:
       mov       rcx,rdi
       mov       [rbp-0B8],rax
       mov       r8,rax
       mov       rdx,[rbp-0C8]
       mov       r11,7FFEFF640E08
       call      qword ptr [r11]
       mov       ecx,eax
       mov       [rbp-0B0],r12
       jmp       near ptr M00_L19
M00_L53:
       mov       [rbp-0B8],rax
       test      rax,rax
       jne       short M00_L54
       mov       rax,[rbp-0B8]
       xor       ecx,ecx
       mov       [rbp-0C8],r8
       mov       [rbp-0B8],rax
       mov       [rbp-0B0],r12
       jmp       near ptr M00_L19
M00_L54:
       mov       rax,[rbp-0B8]
       mov       ecx,0FFFFFFFF
       mov       [rbp-0C8],r8
       mov       [rbp-0B8],rax
       mov       [rbp-0B0],r12
       jmp       near ptr M00_L19
M00_L55:
       mov       ecx,1
       mov       [rbp-0C8],r8
       mov       [rbp-0B8],rax
       mov       [rbp-0B0],r12
       jmp       near ptr M00_L19
M00_L56:
       mov       ecx,2
       call      qword ptr [7FFF000477C8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       r10,rax
       jmp       near ptr M00_L21
M00_L57:
       call      qword ptr [7FFEFF975DA0]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rcx,rax
       jmp       near ptr M00_L22
M00_L58:
       xor       eax,eax
       mov       [rbp-0B0],r12
       jmp       near ptr M00_L26
M00_L59:
       mov       ecx,[r15+8]
       call      qword ptr [7FFF00047750]
       int       3
M00_L60:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L61:
       xor       ecx,ecx
       mov       [rbp-40],ecx
       xor       r12d,r12d
       mov       r15,[rbp-98]
M00_L62:
       cmp       [r15],r13
       jne       near ptr M00_L70
M00_L63:
       cmp       byte ptr [rbp-40],0
       je        near ptr M00_L71
       mov       [rbp-58],r12
       mov       rbx,[rbp+10]
       mov       r15,[rbx+60]
       mov       rdx,[rbp-58]
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [r15+8],rax
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
M00_L64:
       mov       ecx,11
       call      qword ptr [7FFEFF977DF8]
       int       3
M00_L65:
       mov       r13,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord>
       mov       rcx,r13
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       dword ptr [r12+8],0FFFFFFFF
       mov       [r12+0C],r14d
       lea       rcx,[r12+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L02
M00_L66:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdx,1EF3D000E58
       mov       rdx,[rdx]
       mov       rcx,r14
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonValOrderBy>b__14_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       call      qword ptr [7FFEFF6F6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1EF3D000E70
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L67:
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L01
M00_L68:
       mov       rcx,rdi
       mov       r11,7FFEFF640E30
       call      qword ptr [r11]
       mov       r12,rax
       jmp       near ptr M00_L02
M00_L69:
       mov       r11,7FFEFF640DE0
       call      qword ptr [r11]
       mov       r12,rax
       jmp       near ptr M00_L02
M00_L70:
       mov       rcx,r15
       mov       r11,7FFEFF640E28
       call      qword ptr [r11]
       jmp       near ptr M00_L63
M00_L71:
       call      qword ptr [7FFEFFE7FE58]
       int       3
       sub       rsp,38
       vzeroupper
       cmp       qword ptr [rbp-98],0
       je        short M00_L72
       mov       r13,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord>
       mov       r15,[rbp-98]
       cmp       [r15],r13
       je        short M00_L72
       mov       rcx,r15
       mov       r11,7FFEFF640E28
       call      qword ptr [r11]
M00_L72:
       nop
       add       rsp,38
       ret
; Total bytes of code 2884
```
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonValOrderBy>b__14_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       mov       rax,[rdx+30]
       ret
; Total bytes of code 5
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FFF51600D78]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       ecx,ebx
       and       ecx,0FFFFFF
       mov       edx,ecx
       mov       r8d,ebx
       sar       r8d,18
       jne       short M02_L01
       cmp       [rax],ecx
       jle       short M02_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M02_L03
M02_L00:
       add       rsp,20
       pop       rbx
       ret
M02_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M02_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M02_L00
M02_L02:
       cmp       [rax+4],edx
       jle       short M02_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M02_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M02_L03
       jmp       short M02_L00
M02_L03:
       mov       ecx,ebx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax]
; Total bytes of code 130
```
```assembly
; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       push      rsi
       push      rbx
       sub       rsp,28
       call      qword ptr [7FFF515E87D0]
       mov       rbx,rax
       mov       rsi,rbx
       call      qword ptr [7FFF515FFA88]
       mov       rdx,rax
       test      rsi,rsi
       je        short M03_L00
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFF51600C28]
       mov       rax,[rbx]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M03_L00:
       call      qword ptr [7FFF515FE468]
       int       3
; Total bytes of code 61
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M04_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L00:
       call      qword ptr [7FFF0004E658]
       int       3
; Total bytes of code 44
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M05_L00
       ret
M05_L00:
       jmp       qword ptr [7FFEFF6F5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.PersonValOrderBy()
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
       xor       eax,eax
       mov       [rbp-58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp-40],rax
       mov       rbx,rcx
       lea       rcx,[rbp-90]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rcx,rsp
       mov       [rbp-78],rcx
       mov       rcx,rbp
       mov       [rbp-68],rcx
       mov       [rbp+10],rbx
       mov       rdi,[rbx+280]
       mov       rcx,227EE400EA8
       mov       r14,[rcx]
       test      r14,r14
       je        near ptr M00_L65
M00_L00:
       mov       rcx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [r15+10],eax
       lea       rcx,[r15+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        near ptr M00_L66
       xor       ecx,ecx
       mov       [r15+20],rcx
       lea       rcx,[r15+28]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,227C1400A08
       mov       rdx,[rcx]
       lea       rcx,[r15+30]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [r15+48],0
       mov       rcx,[r15+18]
       mov       rax,offset MT_System.Collections.ObjectModel.Collection<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord>
       cmp       [rcx],rax
       jne       near ptr M00_L69
       mov       rdi,[rcx+8]
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord[]
       cmp       [rdi],rcx
       jne       near ptr M00_L68
       mov       r14d,[rdi+8]
       test      r14d,r14d
       jne       near ptr M00_L64
       mov       r13,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord>
       mov       rcx,r13
       test      byte ptr [7FFF000B7530],1
       je        near ptr M00_L67
M00_L01:
       mov       rcx,227EE400FD8
       mov       r12,[rcx]
M00_L02:
       mov       [rbp-98],r12
       mov       r13,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord>
       cmp       [r12],r13
       jne       near ptr M00_L36
       mov       ecx,[r12+8]
       inc       ecx
       cmp       ecx,[r12+0C]
       jae       near ptr M00_L35
       mov       [r12+8],ecx
M00_L03:
       mov       rdi,[r15+30]
       mov       [rbp-0A0],rdi
       mov       r14,[r15+28]
       mov       [rbp-0A8],r14
       cmp       [r12],r13
       jne       near ptr M00_L38
       mov       ecx,[r12+8]
       cmp       ecx,[r12+0C]
       jae       near ptr M00_L37
       mov       rax,[r12+10]
       cmp       ecx,[rax+8]
       jae       near ptr M00_L60
       mov       r12,[rax+rcx*8+10]
       mov       rcx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonValOrderBy>b__14_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       cmp       [r14+18],rcx
       jne       near ptr M00_L39
       mov       rax,[r12+30]
M00_L04:
       cmp       byte ptr [r15+48],0
       jne       near ptr M00_L29
       test      r14,r14
       je        near ptr M00_L20
       test      rdi,rdi
       je        near ptr M00_L20
       mov       r15,[rbp-98]
       cmp       [r15],r13
       jne       near ptr M00_L20
       mov       rcx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonValOrderBy>b__14_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       cmp       [r14+18],rcx
       jne       near ptr M00_L20
       mov       rcx,offset MT_System.Collections.Generic.GenericComparer<System.String>
       cmp       [rdi],rcx
       jne       near ptr M00_L20
       jmp       short M00_L09
M00_L05:
       mov       rdi,[rbp-0C0]
       mov       rax,r14
       mov       [rbp-0B0],rdi
       mov       r12,[rbp-0B0]
       jmp       short M00_L09
M00_L06:
       cmp       rdx,r9
       je        near ptr M00_L44
       mov       [rbp-0B0],r12
       jmp       near ptr M00_L12
M00_L07:
       xor       ecx,ecx
M00_L08:
       test      ecx,ecx
       mov       rax,[rbp-0B8]
       mov       r15,[rbp-98]
       jge       short M00_L05
M00_L09:
       mov       edx,[r15+8]
       inc       edx
       cmp       edx,[r15+0C]
       jae       near ptr M00_L27
       mov       [r15+8],edx
       mov       r8d,[r15+8]
       cmp       r8d,[r15+0C]
       jae       near ptr M00_L59
       mov       r14,[r15+10]
       cmp       r8d,[r14+8]
       jae       near ptr M00_L60
       mov       ecx,r8d
       mov       rdi,[r14+rcx*8+10]
       mov       [rbp-0C0],rdi
       mov       r14,[rdi+30]
       test      r14,r14
       je        near ptr M00_L46
       test      rax,rax
       je        near ptr M00_L45
       mov       [rbp-0B8],rax
       cmp       r14,rax
       je        short M00_L07
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],2
       jle       near ptr M00_L42
       mov       rcx,[rcx+240]
       mov       rdx,[rcx+10]
       test      rdx,rdx
       je        near ptr M00_L42
M00_L10:
       mov       rcx,[rdx+10]
       test      rcx,rcx
       jne       short M00_L11
       mov       rcx,227C1400110
       mov       rcx,[rcx]
       test      rcx,rcx
       jne       short M00_L11
       mov       rcx,227C14000F0
       mov       rcx,[rcx]
       test      rcx,rcx
       je        near ptr M00_L43
M00_L11:
       mov       rdx,[rcx]
       mov       rdx,[rdx+48]
       call      qword ptr [rdx+30]
       cmp       [rax],al
       lea       rdx,[r14+0C]
       mov       [rbp-0C8],r14
       mov       r8d,[r14+8]
       mov       r10,[rbp-0B8]
       lea       r9,[r10+0C]
       mov       [rbp-0B8],r10
       mov       r11d,[r10+8]
       cmp       r8d,r11d
       je        near ptr M00_L06
       mov       [rbp-0B0],r12
M00_L12:
       mov       [rbp-48],rdx
       mov       [rbp-50],r9
       mov       rcx,[rax+20]
       mov       [rsp+20],r11d
       xor       eax,eax
       mov       [rsp+28],eax
       mov       rax,7FFEFF97B650
       mov       [rbp-80],rax
       lea       rax,[M00_L13]
       mov       [rbp-70],rax
       lea       rax,[rbp-90]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFF5F2F93A0
       call      rax
M00_L13:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFF5F64F778],0
       je        short M00_L14
       call      qword ptr [7FFF5F63D608]; CORINFO_HELP_STOP_FOR_GC
M00_L14:
       mov       rcx,[rbp-88]
       mov       [rsi+8],rcx
       xor       ecx,ecx
       mov       [rbp-48],rcx
       mov       [rbp-50],rcx
M00_L15:
       mov       ecx,eax
       mov       r12,[rbp-0B0]
       mov       r14,[rbp-0C8]
       jmp       near ptr M00_L08
M00_L16:
       mov       rdx,[rbp-0C0]
       mov       r10,[rbp-0C8]
       mov       r11,r10
       mov       r12,rdx
       mov       rax,r11
       jmp       short M00_L20
M00_L17:
       cmp       rdx,r9
       je        near ptr M00_L58
       mov       [rbp-0B0],r12
       jmp       near ptr M00_L23
M00_L18:
       xor       ecx,ecx
       mov       [rbp-0B0],r12
M00_L19:
       test      ecx,ecx
       mov       rax,[rbp-0B8]
       mov       r12,[rbp-0B0]
       mov       r14,[rbp-0A8]
       jge       short M00_L16
M00_L20:
       mov       r15,[rbp-98]
       cmp       [r15],r13
       jne       near ptr M00_L48
       mov       edx,[r15+8]
       inc       edx
       cmp       edx,[r15+0C]
       jae       near ptr M00_L27
       mov       [r15+8],edx
       mov       ecx,[r15+8]
       cmp       ecx,[r15+0C]
       jae       near ptr M00_L59
       mov       rcx,[r15+10]
       mov       r8d,[r15+8]
       cmp       r8d,[rcx+8]
       jae       near ptr M00_L60
       mov       edx,r8d
       mov       rcx,[rcx+rdx*8+10]
       mov       rdx,rcx
       mov       rcx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonValOrderBy>b__14_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       cmp       [r14+18],rcx
       jne       near ptr M00_L49
       mov       r15,[rbp-98]
       mov       [rbp-0C0],rdx
       mov       rcx,[rdx+30]
       mov       r8,rcx
       mov       rcx,offset MT_System.Collections.Generic.GenericComparer<System.String>
       cmp       [rdi],rcx
       mov       rdi,[rbp-0A0]
       jne       near ptr M00_L51
       test      r8,r8
       je        near ptr M00_L53
       test      rax,rax
       je        near ptr M00_L55
       mov       [rbp-0C8],r8
       mov       [rbp-0B8],rax
       cmp       r8,rax
       je        near ptr M00_L18
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],2
       jle       near ptr M00_L56
       mov       rcx,[rcx+240]
       mov       r10,[rcx+10]
       test      r10,r10
       je        near ptr M00_L56
M00_L21:
       mov       rcx,[r10+10]
       test      rcx,rcx
       jne       short M00_L22
       mov       rcx,227C1400110
       mov       rcx,[rcx]
       test      rcx,rcx
       jne       short M00_L22
       mov       rcx,227C14000F0
       mov       rcx,[rcx]
       test      rcx,rcx
       je        near ptr M00_L57
M00_L22:
       mov       r10,[rcx]
       mov       r10,[r10+48]
       call      qword ptr [r10+30]
       cmp       [rax],al
       mov       r10,[rbp-0C8]
       lea       rdx,[r10+0C]
       mov       [rbp-0C8],r10
       mov       r8d,[r10+8]
       mov       r11,[rbp-0B8]
       lea       r9,[r11+0C]
       mov       [rbp-0B8],r11
       mov       ecx,[r11+8]
       cmp       r8d,ecx
       je        near ptr M00_L17
       mov       [rbp-0B0],r12
M00_L23:
       mov       [rbp-48],rdx
       mov       [rbp-50],r9
       mov       rax,[rax+20]
       mov       [rsp+20],ecx
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rax
       mov       rax,7FFEFF97B650
       mov       [rbp-80],rax
       lea       rax,[M00_L24]
       mov       [rbp-70],rax
       lea       rax,[rbp-90]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFF5F2F93A0
       call      rax
M00_L24:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFF5F64F778],0
       je        short M00_L25
       call      qword ptr [7FFF5F63D608]; CORINFO_HELP_STOP_FOR_GC
M00_L25:
       mov       rcx,[rbp-88]
       mov       [rsi+8],rcx
       xor       ecx,ecx
       mov       [rbp-48],rcx
       mov       [rbp-50],rcx
       mov       rdi,[rbp-0A0]
       mov       r15,[rbp-98]
M00_L26:
       mov       ecx,eax
       jmp       near ptr M00_L19
M00_L27:
       mov       edx,[r15+0C]
       mov       [r15+8],edx
M00_L28:
       mov       dword ptr [rbp-40],1
       jmp       near ptr M00_L62
M00_L29:
       mov       r15,[rbp-98]
       cmp       [r15],r13
       jne       near ptr M00_L32
M00_L30:
       mov       r8d,[r15+8]
       inc       r8d
       cmp       r8d,[r15+0C]
       jae       near ptr M00_L34
       mov       [r15+8],r8d
       mov       edx,[r15+8]
       cmp       edx,[r15+0C]
       mov       [rbp-0B8],rax
       jae       near ptr M00_L41
       mov       rsi,[r15+10]
       mov       r10d,[r15+8]
       cmp       r10d,[rsi+8]
       jae       near ptr M00_L60
       mov       edx,r10d
       mov       rsi,[rsi+rdx*8+10]
       mov       rdx,rsi
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       mov       rcx,rdi
       mov       r8,[rbp-0B8]
       mov       [rbp-0D0],rax
       mov       rdx,rax
       mov       r11,7FFEFF651640
       call      qword ptr [r11]
       test      eax,eax
       mov       rax,[rbp-0B8]
       jg        short M00_L30
       mov       r12,[rbp-0D0]
       mov       [rbp-0B8],r12
       mov       r12,rsi
       mov       rax,[rbp-0B8]
       jmp       near ptr M00_L30
M00_L31:
       mov       r12,[rbp-0D0]
       mov       rax,r12
       mov       r12,rsi
M00_L32:
       cmp       [r15],r13
       jne       near ptr M00_L40
       mov       r8d,[r15+8]
       inc       r8d
       cmp       r8d,[r15+0C]
       jae       short M00_L34
       mov       [r15+8],r8d
       mov       ecx,[r15+8]
       cmp       ecx,[r15+0C]
       jae       near ptr M00_L41
       mov       rsi,[r15+10]
       mov       r10d,[r15+8]
       cmp       r10d,[rsi+8]
       jae       near ptr M00_L60
       mov       ecx,r10d
       mov       rsi,[rsi+rcx*8+10]
       mov       [rbp-0B8],rax
M00_L33:
       mov       rdx,rsi
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       mov       rcx,rdi
       mov       r8,[rbp-0B8]
       mov       [rbp-0D0],rax
       mov       rdx,rax
       mov       r11,7FFEFF651640
       call      qword ptr [r11]
       test      eax,eax
       mov       rax,[rbp-0B8]
       jg        short M00_L32
       jmp       near ptr M00_L31
M00_L34:
       mov       ecx,[r15+0C]
       mov       [r15+8],ecx
       jmp       near ptr M00_L28
M00_L35:
       mov       ecx,[r12+0C]
       mov       [r12+8],ecx
       jmp       near ptr M00_L61
M00_L36:
       mov       rcx,r12
       mov       r11,7FFEFF651608
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M00_L61
       jmp       near ptr M00_L03
M00_L37:
       call      qword ptr [7FFF001648B8]
       int       3
M00_L38:
       mov       rcx,r12
       mov       r11,7FFEFF651610
       call      qword ptr [r11]
       mov       r12,rax
M00_L39:
       mov       [rbp-0B0],r12
       mov       rdx,r12
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       mov       r12,[rbp-0B0]
       jmp       near ptr M00_L04
M00_L40:
       mov       [rbp-0B8],rax
       mov       rcx,r15
       mov       r11,7FFEFF651630
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M00_L28
       mov       rcx,r15
       mov       r11,7FFEFF651638
       call      qword ptr [r11]
       mov       rsi,rax
       jmp       near ptr M00_L33
M00_L41:
       mov       ecx,[r15+8]
       call      qword ptr [7FFF001648B8]
       int       3
M00_L42:
       mov       ecx,2
       call      qword ptr [7FFEFFEF5B90]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       rdx,rax
       jmp       near ptr M00_L10
M00_L43:
       call      qword ptr [7FFEFF985DA0]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rcx,rax
       jmp       near ptr M00_L11
M00_L44:
       xor       eax,eax
       mov       [rbp-0B0],r12
       jmp       near ptr M00_L15
M00_L45:
       mov       ecx,1
       mov       [rbp-0B8],rax
       jmp       near ptr M00_L08
M00_L46:
       test      rax,rax
       je        short M00_L47
       mov       ecx,0FFFFFFFF
       mov       [rbp-0B8],rax
       jmp       near ptr M00_L08
M00_L47:
       xor       ecx,ecx
       mov       [rbp-0B8],rax
       jmp       near ptr M00_L08
M00_L48:
       mov       [rbp-0B8],rax
       mov       rcx,r15
       mov       r11,7FFEFF651618
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M00_L28
       mov       rcx,r15
       mov       r11,7FFEFF651620
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       short M00_L50
M00_L49:
       mov       [rbp-0B8],rax
M00_L50:
       mov       [rbp-0C0],rdx
       mov       r14,[rbp-0A8]
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       mov       [rbp-0C8],rax
       mov       rax,[rbp-0B8]
       mov       r15,[rbp-98]
       jmp       short M00_L52
M00_L51:
       mov       [rbp-0C8],r8
M00_L52:
       mov       rcx,rdi
       mov       [rbp-0B8],rax
       mov       r8,rax
       mov       rdx,[rbp-0C8]
       mov       r11,7FFEFF651628
       call      qword ptr [r11]
       mov       ecx,eax
       mov       [rbp-0B0],r12
       jmp       near ptr M00_L19
M00_L53:
       mov       [rbp-0B8],rax
       test      rax,rax
       jne       short M00_L54
       mov       rax,[rbp-0B8]
       xor       ecx,ecx
       mov       [rbp-0C8],r8
       mov       [rbp-0B8],rax
       mov       [rbp-0B0],r12
       jmp       near ptr M00_L19
M00_L54:
       mov       rax,[rbp-0B8]
       mov       ecx,0FFFFFFFF
       mov       [rbp-0C8],r8
       mov       [rbp-0B8],rax
       mov       [rbp-0B0],r12
       jmp       near ptr M00_L19
M00_L55:
       mov       ecx,1
       mov       [rbp-0C8],r8
       mov       [rbp-0B8],rax
       mov       [rbp-0B0],r12
       jmp       near ptr M00_L19
M00_L56:
       mov       ecx,2
       call      qword ptr [7FFEFFEF5B90]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       r10,rax
       jmp       near ptr M00_L21
M00_L57:
       call      qword ptr [7FFEFF985DA0]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rcx,rax
       jmp       near ptr M00_L22
M00_L58:
       xor       eax,eax
       mov       [rbp-0B0],r12
       jmp       near ptr M00_L26
M00_L59:
       mov       ecx,[r15+8]
       call      qword ptr [7FFF001648B8]
       int       3
M00_L60:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L61:
       xor       ecx,ecx
       mov       [rbp-40],ecx
       xor       r12d,r12d
       mov       r15,[rbp-98]
M00_L62:
       cmp       [r15],r13
       jne       near ptr M00_L70
M00_L63:
       cmp       byte ptr [rbp-40],0
       je        near ptr M00_L71
       mov       [rbp-58],r12
       mov       rbx,[rbp+10]
       mov       r15,[rbx+60]
       mov       rdx,[rbp-58]
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [r15+8],rax
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
M00_L64:
       mov       r13,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord>
       mov       rcx,r13
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       dword ptr [r12+8],0FFFFFFFF
       mov       [r12+0C],r14d
       lea       rcx,[r12+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L02
M00_L65:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdx,227EE400E90
       mov       rdx,[rdx]
       mov       rcx,r14
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonValOrderBy>b__14_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       call      qword ptr [7FFEFF706BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,227EE400EA8
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L66:
       mov       ecx,11
       call      qword ptr [7FFEFF987DF8]
       int       3
M00_L67:
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L01
M00_L68:
       mov       rcx,rdi
       mov       r11,7FFEFF651650
       call      qword ptr [r11]
       mov       r12,rax
       jmp       near ptr M00_L02
M00_L69:
       mov       r11,7FFEFF651600
       call      qword ptr [r11]
       mov       r12,rax
       jmp       near ptr M00_L02
M00_L70:
       mov       rcx,r15
       mov       r11,7FFEFF651648
       call      qword ptr [r11]
       jmp       near ptr M00_L63
M00_L71:
       call      qword ptr [7FFEFFEFE4A8]
       int       3
       sub       rsp,38
       vzeroupper
       cmp       qword ptr [rbp-98],0
       je        short M00_L72
       mov       r13,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord>
       mov       r15,[rbp-98]
       cmp       [r15],r13
       je        short M00_L72
       mov       rcx,r15
       mov       r11,7FFEFF651648
       call      qword ptr [r11]
M00_L72:
       nop
       add       rsp,38
       ret
; Total bytes of code 2884
```
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonValOrderBy>b__14_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       mov       rax,[rdx+30]
       ret
; Total bytes of code 5
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FFF51600D78]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       ecx,ebx
       and       ecx,0FFFFFF
       mov       edx,ecx
       mov       r8d,ebx
       sar       r8d,18
       jne       short M02_L01
       cmp       [rax],ecx
       jle       short M02_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M02_L03
M02_L00:
       add       rsp,20
       pop       rbx
       ret
M02_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M02_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M02_L00
M02_L02:
       cmp       [rax+4],edx
       jle       short M02_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M02_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M02_L03
       jmp       short M02_L00
M02_L03:
       mov       ecx,ebx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax]
; Total bytes of code 130
```
```assembly
; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       push      rsi
       push      rbx
       sub       rsp,28
       call      qword ptr [7FFF515E87D0]
       mov       rbx,rax
       mov       rsi,rbx
       call      qword ptr [7FFF515FFA88]
       mov       rdx,rax
       test      rsi,rsi
       je        short M03_L00
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFF51600C28]
       mov       rax,[rbx]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M03_L00:
       call      qword ptr [7FFF515FE468]
       int       3
; Total bytes of code 61
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M04_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L00:
       call      qword ptr [7FFF0004D698]
       int       3
; Total bytes of code 44
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M05_L00
       ret
M05_L00:
       jmp       qword ptr [7FFEFF705C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.PersonValOrderBy()
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
       xor       eax,eax
       mov       [rbp-58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp-40],rax
       mov       rbx,rcx
       lea       rcx,[rbp-90]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rcx,rsp
       mov       [rbp-78],rcx
       mov       rcx,rbp
       mov       [rbp-68],rcx
       mov       [rbp+10],rbx
       mov       rdi,[rbx+280]
       mov       rcx,1AB90802EE0
       mov       r14,[rcx]
       test      r14,r14
       je        near ptr M00_L61
M00_L00:
       mov       rcx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [r15+10],eax
       lea       rcx,[r15+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        near ptr M00_L62
       xor       ecx,ecx
       mov       [r15+20],rcx
       lea       rcx,[r15+28]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,1AB90800A08
       mov       rdx,[rcx]
       lea       rcx,[r15+30]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [r15+48],0
       mov       rcx,[r15+18]
       mov       r11,offset MT_System.Collections.ObjectModel.Collection<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord>
       cmp       [rcx],r11
       jne       near ptr M00_L63
       mov       rcx,[rcx+8]
       mov       r11,7FFEFF6318E8
       call      qword ptr [r11]
       mov       rdi,rax
M00_L01:
       mov       [rbp-98],rdi
       mov       r14,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord>
       cmp       [rdi],r14
       jne       near ptr M00_L33
       mov       ecx,[rdi+8]
       inc       ecx
       cmp       ecx,[rdi+0C]
       jae       near ptr M00_L32
       mov       [rdi+8],ecx
M00_L02:
       mov       r13,[r15+30]
       mov       [rbp-0A0],r13
       mov       r12,[r15+28]
       mov       [rbp-0A8],r12
       cmp       [rdi],r14
       jne       near ptr M00_L35
       mov       ecx,[rdi+8]
       cmp       ecx,[rdi+0C]
       jae       near ptr M00_L34
       mov       rax,[rdi+10]
       cmp       ecx,[rax+8]
       jae       near ptr M00_L57
       mov       rdi,[rax+rcx*8+10]
       mov       rcx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonValOrderBy>b__14_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       cmp       [r12+18],rcx
       jne       near ptr M00_L36
       mov       rax,[rdi+30]
M00_L03:
       cmp       byte ptr [r15+48],0
       jne       near ptr M00_L26
       test      r12,r12
       je        near ptr M00_L20
       test      r13,r13
       je        near ptr M00_L20
       mov       r15,[rbp-98]
       cmp       [r15],r14
       jne       near ptr M00_L20
       mov       rcx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonValOrderBy>b__14_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       cmp       [r12+18],rcx
       jne       near ptr M00_L20
       mov       rcx,offset MT_System.Collections.Generic.GenericComparer<System.String>
       cmp       [r13],rcx
       jne       near ptr M00_L20
       jmp       near ptr M00_L10
M00_L04:
       mov       r12,[rbp-0C8]
       mov       r13,[rbp-0C0]
       mov       r10,r12
       mov       [rbp-0B0],r13
       mov       rax,r10
       mov       rdi,[rbp-0B0]
       jmp       near ptr M00_L10
M00_L05:
       mov       [rbp-0B0],rdi
M00_L06:
       mov       [rbp-48],rdx
       mov       [rbp-50],r9
       mov       rcx,[rax+20]
       mov       [rsp+20],r11d
       xor       eax,eax
       mov       [rsp+28],eax
       mov       rax,7FFEFF95B650
       mov       [rbp-80],rax
       lea       rax,[M00_L07]
       mov       [rbp-70],rax
       lea       rax,[rbp-90]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFF5F2F93A0
       call      rax
M00_L07:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFF5F64F778],0
       je        short M00_L08
       call      qword ptr [7FFF5F63D608]; CORINFO_HELP_STOP_FOR_GC
M00_L08:
       mov       rcx,[rbp-88]
       mov       [rsi+8],rcx
       xor       ecx,ecx
       mov       [rbp-48],rcx
       mov       [rbp-50],rcx
M00_L09:
       test      eax,eax
       mov       rax,[rbp-0B8]
       mov       rdi,[rbp-0B0]
       mov       r15,[rbp-98]
       jge       near ptr M00_L04
M00_L10:
       mov       edx,[r15+8]
       inc       edx
       cmp       edx,[r15+0C]
       jae       near ptr M00_L24
       mov       [r15+8],edx
       mov       r8d,[r15+8]
       cmp       r8d,[r15+0C]
       jae       near ptr M00_L56
       mov       r12,[r15+10]
       cmp       r8d,[r12+8]
       jae       near ptr M00_L57
       mov       ecx,r8d
       mov       r13,[r12+rcx*8+10]
       mov       [rbp-0C0],r13
       mov       r12,[r13+30]
       test      r12,r12
       je        near ptr M00_L43
       test      rax,rax
       je        near ptr M00_L42
       mov       [rbp-0B8],rax
       cmp       r12,rax
       je        near ptr M00_L13
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],2
       jle       near ptr M00_L39
       mov       rcx,[rcx+240]
       mov       rdx,[rcx+10]
       test      rdx,rdx
       je        near ptr M00_L39
M00_L11:
       mov       rcx,[rdx+10]
       test      rcx,rcx
       jne       short M00_L12
       mov       rcx,1AB90800110
       mov       rcx,[rcx]
       test      rcx,rcx
       jne       short M00_L12
       mov       rcx,1AB908000F0
       mov       rcx,[rcx]
       test      rcx,rcx
       je        near ptr M00_L40
M00_L12:
       mov       rdx,[rcx]
       mov       rdx,[rdx+48]
       call      qword ptr [rdx+30]
       cmp       [rax],al
       lea       rdx,[r12+0C]
       mov       [rbp-0C8],r12
       mov       r8d,[r12+8]
       mov       r10,[rbp-0B8]
       lea       r9,[r10+0C]
       mov       [rbp-0B8],r10
       mov       r11d,[r10+8]
       cmp       r8d,r11d
       jne       near ptr M00_L05
       cmp       rdx,r9
       je        near ptr M00_L41
       mov       [rbp-0B0],rdi
       jmp       near ptr M00_L06
M00_L13:
       xor       ecx,ecx
       mov       [rbp-0C8],r12
       mov       [rbp-0B0],rdi
       mov       eax,ecx
       jmp       near ptr M00_L09
M00_L14:
       mov       rdx,[rbp-0C0]
       mov       r10,[rbp-0C8]
       mov       r11,r10
       mov       rdi,rdx
       mov       rax,r11
       jmp       near ptr M00_L20
M00_L15:
       mov       [rbp-0B0],rdi
M00_L16:
       mov       [rbp-48],rdx
       mov       [rbp-50],r9
       mov       rax,[rax+20]
       mov       [rsp+20],ecx
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rax
       mov       rax,7FFEFF95B650
       mov       [rbp-80],rax
       lea       rax,[M00_L17]
       mov       [rbp-70],rax
       lea       rax,[rbp-90]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFF5F2F93A0
       call      rax
M00_L17:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFF5F64F778],0
       je        short M00_L18
       call      qword ptr [7FFF5F63D608]; CORINFO_HELP_STOP_FOR_GC
M00_L18:
       mov       rcx,[rbp-88]
       mov       [rsi+8],rcx
       xor       ecx,ecx
       mov       [rbp-48],rcx
       mov       [rbp-50],rcx
       mov       r13,[rbp-0A0]
       mov       r15,[rbp-98]
M00_L19:
       test      eax,eax
       mov       rax,[rbp-0B8]
       mov       rdi,[rbp-0B0]
       mov       r12,[rbp-0A8]
       jge       near ptr M00_L14
M00_L20:
       mov       r15,[rbp-98]
       cmp       [r15],r14
       jne       near ptr M00_L45
       mov       edx,[r15+8]
       inc       edx
       cmp       edx,[r15+0C]
       jae       near ptr M00_L24
       mov       [r15+8],edx
       mov       ecx,[r15+8]
       cmp       ecx,[r15+0C]
       jae       near ptr M00_L56
       mov       rcx,[r15+10]
       mov       r8d,[r15+8]
       cmp       r8d,[rcx+8]
       jae       near ptr M00_L57
       mov       edx,r8d
       mov       rcx,[rcx+rdx*8+10]
       mov       rdx,rcx
       mov       rcx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonValOrderBy>b__14_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       cmp       [r12+18],rcx
       jne       near ptr M00_L46
       mov       r15,[rbp-98]
       mov       [rbp-0C0],rdx
       mov       rcx,[rdx+30]
       mov       r8,rcx
       mov       rcx,offset MT_System.Collections.Generic.GenericComparer<System.String>
       cmp       [r13],rcx
       mov       r13,[rbp-0A0]
       jne       near ptr M00_L48
       test      r8,r8
       je        near ptr M00_L50
       test      rax,rax
       je        near ptr M00_L52
       mov       [rbp-0C8],r8
       mov       [rbp-0B8],rax
       cmp       r8,rax
       je        near ptr M00_L23
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],2
       jle       near ptr M00_L53
       mov       rcx,[rcx+240]
       mov       r10,[rcx+10]
       test      r10,r10
       je        near ptr M00_L53
M00_L21:
       mov       rcx,[r10+10]
       test      rcx,rcx
       jne       short M00_L22
       mov       rcx,1AB90800110
       mov       rcx,[rcx]
       test      rcx,rcx
       jne       short M00_L22
       mov       rcx,1AB908000F0
       mov       rcx,[rcx]
       test      rcx,rcx
       je        near ptr M00_L54
M00_L22:
       mov       r10,[rcx]
       mov       r10,[r10+48]
       call      qword ptr [r10+30]
       cmp       [rax],al
       mov       r10,[rbp-0C8]
       lea       rdx,[r10+0C]
       mov       [rbp-0C8],r10
       mov       r8d,[r10+8]
       mov       r11,[rbp-0B8]
       lea       r9,[r11+0C]
       mov       [rbp-0B8],r11
       mov       ecx,[r11+8]
       cmp       r8d,ecx
       jne       near ptr M00_L15
       cmp       rdx,r9
       je        near ptr M00_L55
       mov       [rbp-0B0],rdi
       jmp       near ptr M00_L16
M00_L23:
       xor       ecx,ecx
       mov       [rbp-0B0],rdi
       mov       eax,ecx
       jmp       near ptr M00_L19
M00_L24:
       mov       edx,[r15+0C]
       mov       [r15+8],edx
M00_L25:
       mov       dword ptr [rbp-40],1
       jmp       near ptr M00_L59
M00_L26:
       mov       r15,[rbp-98]
       cmp       [r15],r14
       jne       near ptr M00_L29
M00_L27:
       mov       r8d,[r15+8]
       inc       r8d
       cmp       r8d,[r15+0C]
       jae       near ptr M00_L31
       mov       [r15+8],r8d
       mov       edx,[r15+8]
       cmp       edx,[r15+0C]
       mov       [rbp-0B8],rax
       jae       near ptr M00_L38
       mov       rsi,[r15+10]
       mov       r10d,[r15+8]
       cmp       r10d,[rsi+8]
       jae       near ptr M00_L57
       mov       edx,r10d
       mov       rsi,[rsi+rdx*8+10]
       mov       rdx,rsi
       mov       rcx,[r12+8]
       call      qword ptr [r12+18]
       mov       rcx,r13
       mov       r8,[rbp-0B8]
       mov       [rbp-0D0],rax
       mov       rdx,rax
       mov       r11,7FFEFF6318D8
       call      qword ptr [r11]
       test      eax,eax
       mov       rax,[rbp-0B8]
       jg        short M00_L27
       mov       rdi,[rbp-0D0]
       mov       [rbp-0B8],rdi
       mov       rdi,rsi
       mov       rax,[rbp-0B8]
       jmp       near ptr M00_L27
M00_L28:
       mov       rdi,[rbp-0D0]
       mov       rax,rdi
       mov       rdi,rsi
M00_L29:
       cmp       [r15],r14
       jne       near ptr M00_L37
       mov       r8d,[r15+8]
       inc       r8d
       cmp       r8d,[r15+0C]
       jae       short M00_L31
       mov       [r15+8],r8d
       mov       ecx,[r15+8]
       cmp       ecx,[r15+0C]
       jae       near ptr M00_L38
       mov       rsi,[r15+10]
       mov       r10d,[r15+8]
       cmp       r10d,[rsi+8]
       jae       near ptr M00_L57
       mov       ecx,r10d
       mov       rsi,[rsi+rcx*8+10]
       mov       [rbp-0B8],rax
M00_L30:
       mov       rdx,rsi
       mov       rcx,[r12+8]
       call      qword ptr [r12+18]
       mov       rcx,r13
       mov       r8,[rbp-0B8]
       mov       [rbp-0D0],rax
       mov       rdx,rax
       mov       r11,7FFEFF6318D8
       call      qword ptr [r11]
       test      eax,eax
       mov       rax,[rbp-0B8]
       jg        near ptr M00_L29
       jmp       near ptr M00_L28
M00_L31:
       mov       ecx,[r15+0C]
       mov       [r15+8],ecx
       jmp       near ptr M00_L25
M00_L32:
       mov       ecx,[rdi+0C]
       mov       [rdi+8],ecx
       jmp       near ptr M00_L58
M00_L33:
       mov       rcx,rdi
       mov       r11,7FFEFF6318A0
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M00_L58
       jmp       near ptr M00_L02
M00_L34:
       call      qword ptr [7FFF001D4AC8]
       int       3
M00_L35:
       mov       rcx,rdi
       mov       r11,7FFEFF6318A8
       call      qword ptr [r11]
       mov       rdi,rax
M00_L36:
       mov       [rbp-0B0],rdi
       mov       rdx,rdi
       mov       rcx,[r12+8]
       call      qword ptr [r12+18]
       mov       rdi,[rbp-0B0]
       jmp       near ptr M00_L03
M00_L37:
       mov       [rbp-0B8],rax
       mov       rcx,r15
       mov       r11,7FFEFF6318C8
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M00_L25
       mov       rcx,r15
       mov       r11,7FFEFF6318D0
       call      qword ptr [r11]
       mov       rsi,rax
       jmp       near ptr M00_L30
M00_L38:
       mov       ecx,[r15+8]
       call      qword ptr [7FFF001D4AC8]
       int       3
M00_L39:
       mov       ecx,2
       call      qword ptr [7FFEFFE7C8E8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       rdx,rax
       jmp       near ptr M00_L11
M00_L40:
       call      qword ptr [7FFEFF965DA0]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rcx,rax
       jmp       near ptr M00_L12
M00_L41:
       xor       eax,eax
       mov       [rbp-0B0],rdi
       jmp       near ptr M00_L09
M00_L42:
       mov       edx,1
       mov       [rbp-0C8],r12
       mov       [rbp-0B8],rax
       mov       [rbp-0B0],rdi
       mov       eax,edx
       jmp       near ptr M00_L09
M00_L43:
       test      rax,rax
       je        short M00_L44
       mov       edx,0FFFFFFFF
       mov       [rbp-0C8],r12
       mov       [rbp-0B8],rax
       mov       [rbp-0B0],rdi
       mov       eax,edx
       jmp       near ptr M00_L09
M00_L44:
       xor       edx,edx
       mov       [rbp-0C8],r12
       mov       [rbp-0B8],rax
       mov       [rbp-0B0],rdi
       mov       eax,edx
       jmp       near ptr M00_L09
M00_L45:
       mov       [rbp-0B8],rax
       mov       rcx,r15
       mov       r11,7FFEFF6318B0
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M00_L25
       mov       rcx,r15
       mov       r11,7FFEFF6318B8
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       short M00_L47
M00_L46:
       mov       [rbp-0B8],rax
M00_L47:
       mov       [rbp-0C0],rdx
       mov       r12,[rbp-0A8]
       mov       rcx,[r12+8]
       call      qword ptr [r12+18]
       mov       [rbp-0C8],rax
       mov       rax,[rbp-0B8]
       mov       r15,[rbp-98]
       jmp       short M00_L49
M00_L48:
       mov       [rbp-0C8],r8
M00_L49:
       mov       rcx,r13
       mov       [rbp-0B8],rax
       mov       r8,rax
       mov       rdx,[rbp-0C8]
       mov       r11,7FFEFF6318C0
       call      qword ptr [r11]
       mov       r10d,eax
       mov       [rbp-0B0],rdi
       mov       eax,r10d
       jmp       near ptr M00_L19
M00_L50:
       mov       [rbp-0B8],rax
       test      rax,rax
       jne       short M00_L51
       mov       rax,[rbp-0B8]
       xor       r10d,r10d
       mov       [rbp-0C8],r8
       mov       [rbp-0B8],rax
       mov       [rbp-0B0],rdi
       mov       eax,r10d
       jmp       near ptr M00_L19
M00_L51:
       mov       rax,[rbp-0B8]
       mov       r10d,0FFFFFFFF
       mov       [rbp-0C8],r8
       mov       [rbp-0B8],rax
       mov       [rbp-0B0],rdi
       mov       eax,r10d
       jmp       near ptr M00_L19
M00_L52:
       mov       r10d,1
       mov       [rbp-0C8],r8
       mov       [rbp-0B8],rax
       mov       [rbp-0B0],rdi
       mov       eax,r10d
       jmp       near ptr M00_L19
M00_L53:
       mov       ecx,2
       call      qword ptr [7FFEFFE7C8E8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       r10,rax
       jmp       near ptr M00_L21
M00_L54:
       call      qword ptr [7FFEFF965DA0]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rcx,rax
       jmp       near ptr M00_L22
M00_L55:
       xor       eax,eax
       mov       [rbp-0B0],rdi
       jmp       near ptr M00_L19
M00_L56:
       mov       ecx,[r15+8]
       call      qword ptr [7FFF001D4AC8]
       int       3
M00_L57:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L58:
       xor       ecx,ecx
       mov       [rbp-40],ecx
       xor       edi,edi
       mov       r15,[rbp-98]
M00_L59:
       cmp       [r15],r14
       jne       near ptr M00_L64
M00_L60:
       cmp       byte ptr [rbp-40],0
       je        near ptr M00_L65
       mov       [rbp-58],rdi
       mov       rbx,[rbp+10]
       mov       r15,[rbx+60]
       mov       rdx,[rbp-58]
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [r15+8],rax
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
M00_L61:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdx,1AB90802EC8
       mov       rdx,[rdx]
       mov       rcx,r14
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonValOrderBy>b__14_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       call      qword ptr [7FFEFF6E6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1AB90802EE0
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L62:
       mov       ecx,11
       call      qword ptr [7FFEFF967DF8]
       int       3
M00_L63:
       mov       r11,7FFEFF631898
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L01
M00_L64:
       mov       rcx,r15
       mov       r11,7FFEFF6318E0
       call      qword ptr [r11]
       jmp       near ptr M00_L60
M00_L65:
       call      qword ptr [7FFEFFEEFAF8]
       int       3
       sub       rsp,38
       vzeroupper
       cmp       qword ptr [rbp-98],0
       je        short M00_L66
       mov       r14,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord>
       mov       r15,[rbp-98]
       cmp       [r15],r14
       je        short M00_L66
       mov       rcx,r15
       mov       r11,7FFEFF6318E0
       call      qword ptr [r11]
M00_L66:
       nop
       add       rsp,38
       ret
; Total bytes of code 2845
```
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonValOrderBy>b__14_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       mov       rax,[rdx+30]
       ret
; Total bytes of code 5
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FFF51600D78]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       ecx,ebx
       and       ecx,0FFFFFF
       mov       edx,ecx
       mov       r8d,ebx
       sar       r8d,18
       jne       short M02_L01
       cmp       [rax],ecx
       jle       short M02_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M02_L03
M02_L00:
       add       rsp,20
       pop       rbx
       ret
M02_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M02_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M02_L00
M02_L02:
       cmp       [rax+4],edx
       jle       short M02_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M02_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M02_L03
       jmp       short M02_L00
M02_L03:
       mov       ecx,ebx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax]
; Total bytes of code 130
```
```assembly
; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       push      rsi
       push      rbx
       sub       rsp,28
       call      qword ptr [7FFF515E87D0]
       mov       rbx,rax
       mov       rsi,rbx
       call      qword ptr [7FFF515FFA88]
       mov       rdx,rax
       test      rsi,rsi
       je        short M03_L00
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFF51600C28]
       mov       rax,[rbx]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M03_L00:
       call      qword ptr [7FFF515FE468]
       int       3
; Total bytes of code 61
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M04_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L00:
       call      qword ptr [7FFEFFEE63A0]
       int       3
; Total bytes of code 44
```

