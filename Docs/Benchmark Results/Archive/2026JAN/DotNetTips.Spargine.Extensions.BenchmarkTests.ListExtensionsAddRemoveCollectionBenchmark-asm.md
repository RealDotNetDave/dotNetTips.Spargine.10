## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsAddRemoveCollectionBenchmark.AddFirst()
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
       call      qword ptr [7FFCFD05CC90]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
       mov       [rbp-10],rax
       mov       r8,[rbp-10]
       mov       rdx,[rbp-8]
       mov       rcx,7FFCFD151B28
       call      qword ptr [7FFCFD05CC30]; DotNetTips.Spargine.Extensions.ListExtensions.AddFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.__Canon)
       mov       rcx,[rbp+10]
       mov       r8,[rbp-8]
       mov       rdx,7FFCFD151C40
       call      qword ptr [7FFCFD05CC60]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 108
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
; DotNetTips.Spargine.Extensions.ListExtensions.AddFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.__Canon)
       push      rbp
       sub       rsp,60
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
; 			item = item.ArgumentNotNull();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       xor       eax,eax
       mov       [rbp-10],rax
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
       mov       rdx,7FFCFD160688
       call      qword ptr [7FFCFC7CF630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-18],rax
M02_L01:
       mov       rax,2A577EBB890
       mov       [rsp+20],rax
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+20]
       mov       r8,[rbp-10]
       mov       r9,2A577EB0008
       call      qword ptr [7FFCFCE9E3A0]
       mov       [rbp+20],rax
; 			list = list.ArgumentNotNull();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       mov       rdx,7FFCFD160A10
       call      qword ptr [7FFCFC7CF630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-20],rax
M02_L03:
       mov       rax,2A577EC30C8
       mov       [rsp+20],rax
       mov       rcx,[rbp-20]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       mov       r9,2A577EB0008
       call      qword ptr [7FFCFCE9E3A0]
       mov       [rbp+18],rax
; 			list.Insert(0, item);
; 			^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,[rbp+18]
       mov       r8,[rbp+20]
       xor       edx,edx
       cmp       [rcx],ecx
       call      qword ptr [7FFCFC8E1828]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Insert(Int32, System.__Canon)
       nop
       add       rsp,60
       pop       rbp
       ret
; Total bytes of code 270
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
       mov       rdx,7FFCFD160B70
       call      qword ptr [7FFCFC7CF630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M03_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFCFD05CD68]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFCFD05CD20]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 130
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsAddRemoveCollectionBenchmark.AddFirst()
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
       call      qword ptr [7FFCFD0DCC90]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
       mov       [rbp-10],rax
       mov       r8,[rbp-10]
       mov       rdx,[rbp-8]
       mov       rcx,7FFCFD151B18
       call      qword ptr [7FFCFD0DCC30]; DotNetTips.Spargine.Extensions.ListExtensions.AddFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.__Canon)
       mov       rcx,[rbp+10]
       mov       r8,[rbp-8]
       mov       rdx,7FFCFD151C30
       call      qword ptr [7FFCFD0DCC60]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 108
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
; DotNetTips.Spargine.Extensions.ListExtensions.AddFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.__Canon)
; 			item = item.ArgumentNotNull();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			list = list.ArgumentNotNull();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			list.Insert(0, item);
; 			^^^^^^^^^^^^^^^^^^^^^
       push      rbp
       sub       rsp,60
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       xor       eax,eax
       mov       [rbp-10],rax
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
       mov       rdx,7FFCFD160688
       call      qword ptr [7FFCFC7CF630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-18],rax
M02_L01:
       mov       rax,21E113BB890
       mov       [rsp+20],rax
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+20]
       mov       r8,[rbp-10]
       mov       r9,21E113B0008
       call      qword ptr [7FFCFCE9E3E8]
       mov       [rbp+20],rax
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
       mov       rdx,7FFCFD160A10
       call      qword ptr [7FFCFC7CF630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-20],rax
M02_L03:
       mov       rax,21E113C30C8
       mov       [rsp+20],rax
       mov       rcx,[rbp-20]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       mov       r9,21E113B0008
       call      qword ptr [7FFCFCE9E3E8]
       mov       [rbp+18],rax
       mov       rcx,[rbp+18]
       mov       r8,[rbp+20]
       xor       edx,edx
       cmp       [rcx],ecx
       call      qword ptr [7FFCFC8E1828]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Insert(Int32, System.__Canon)
       nop
       add       rsp,60
       pop       rbp
       ret
; Total bytes of code 270
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
       mov       rdx,7FFCFD160B70
       call      qword ptr [7FFCFC7CF630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M03_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFCFD0DCD68]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFCFD0DCD20]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 130
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; BenchmarkDotNet.Autogenerated.Runnable_1003.__ForDisassemblyDiagnoser__()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
;             if (NotEleven == 11)
;             ^^^^^^^^^^^^^^^^^^^^
       mov       rax,[rbp+10]
       cmp       dword ptr [rax+2C0],0B
       jne       short M00_L00
;                 AddFirst();
;                 ^^^^^^^^^^^
       mov       rcx,[rbp+10]
       call      qword ptr [7FFCFCB9D890]
M00_L00:
       nop
       add       rsp,20
       pop       rbp
       ret
; Total bytes of code 44
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsAddRemoveCollectionBenchmark.AddFirst()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+38],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       rdi,[rbx+48]
       test      rdi,rdi
       je        near ptr M00_L05
       test      rsi,rsi
       je        near ptr M00_L06
       mov       ebp,[rsi+10]
       mov       rcx,[rsi+8]
       cmp       ebp,[rcx+8]
       je        short M00_L01
       test      ebp,ebp
       jg        near ptr M00_L11
M00_L00:
       mov       rcx,[rsi+8]
       mov       edx,[rcx+8]
       test      rdx,rdx
       je        near ptr M00_L12
       lea       rcx,[rcx+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rsi+10]
       inc       dword ptr [rsi+14]
       mov       [rsp+38],rsi
       mov       rbx,[rbx+60]
       mov       rdx,[rsp+38]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L01:
       mov       edx,ebp
       add       edx,1
       jo        near ptr M00_L13
       mov       rcx,[rsi+8]
       cmp       dword ptr [rcx+8],0
       jne       near ptr M00_L04
       mov       ecx,4
M00_L02:
       mov       eax,7FFFFFC7
       cmp       ecx,7FFFFFC7
       cmova     ecx,eax
       cmp       ecx,edx
       cmovl     ecx,edx
       movsxd    rdx,ecx
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       test      ebp,ebp
       je        near ptr M00_L03
       mov       rcx,[rsi+8]
       test      rcx,rcx
       je        near ptr M00_L10
       mov       rdx,[rcx]
       cmp       rdx,[r14]
       jne       near ptr M00_L10
       cmp       dword ptr [rdx+4],18
       jne       near ptr M00_L10
       test      ebp,ebp
       jl        near ptr M00_L10
       cmp       ebp,[rcx+8]
       ja        near ptr M00_L10
       lea       r8d,[rbp+1]
       cmp       r8d,[r14+8]
       ja        near ptr M00_L10
       movzx     r8d,word ptr [rdx]
       mov       eax,ebp
       imul      rax,r8
       add       rcx,10
       mov       r10,rcx
       lea       rcx,[r14+r8+10]
       test      dword ptr [rdx],1000000
       je        near ptr M00_L09
       cmp       rax,4000
       ja        near ptr M00_L08
       mov       rdx,r10
       mov       r8,rax
       call      00007FFD5C3C5D60
       cmp       dword ptr [7FFD5C72F778],0
       jne       near ptr M00_L07
M00_L03:
       lea       rcx,[rsi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L04:
       mov       rcx,[rsi+8]
       mov       ecx,[rcx+8]
       add       ecx,ecx
       jmp       near ptr M00_L02
M00_L05:
       call      qword ptr [7FFCFCEC6CE8]
       mov       ecx,0F
       mov       rdx,7FFCFCD26050
       call      qword ptr [7FFCFCA77738]
       mov       rbx,rax
       mov       ecx,1B61
       mov       rdx,7FFCFCBF5D90
       call      qword ptr [7FFCFCA77738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCFC7F7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFCFCD26050
       call      qword ptr [7FFCFCA77738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCFC7F7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCFCFFCA50]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCFCFFCA68]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L06:
       call      qword ptr [7FFCFCEC6CE8]
       mov       ecx,69E
       mov       rdx,7FFCFCD26050
       call      qword ptr [7FFCFCA77738]
       mov       rbx,rax
       mov       ecx,1B61
       mov       rdx,7FFCFCBF5D90
       call      qword ptr [7FFCFCA77738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCFC7F7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFCFCD26050
       call      qword ptr [7FFCFCA77738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCFC7F7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCFCFFCA50]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCFCFFCA68]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L03
M00_L08:
       mov       rdx,r10
       mov       r8,rax
       call      qword ptr [7FFCFCFF5248]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L03
M00_L09:
       mov       rdx,r10
       mov       r8,rax
       call      qword ptr [7FFCFC7F5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L03
M00_L10:
       mov       [rsp+20],ebp
       xor       r8d,r8d
       mov       [rsp+28],r8d
       mov       r8,r14
       xor       edx,edx
       mov       r9d,1
       call      qword ptr [7FFCFD1CC660]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M00_L03
M00_L11:
       mov       [rsp+20],ebp
       mov       rcx,[rsi+8]
       mov       r8,[rsi+8]
       xor       edx,edx
       mov       r9d,1
       call      qword ptr [7FFCFCE4CF90]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       near ptr M00_L00
M00_L12:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L13:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 809
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
       call      00007FFD5C418D20
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFCFC7F5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFCFC7F5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,2789D3B0008
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
       call      qword ptr [7FFCFD13FF48]
       int       3
; Total bytes of code 235
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
       je        short M02_L03
       mov       rcx,rbx
       sub       rcx,rsi
       cmp       rcx,rdi
       jb        short M02_L06
M02_L00:
       add       rdi,0FFFFFFFFFFFFC000
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,4000
       call      00007FFD5C3C5D60
       add       rbx,4000
       add       rsi,4000
       cmp       dword ptr [7FFD5C72F778],0
       jne       short M02_L04
M02_L01:
       cmp       rdi,4000
       ja        short M02_L00
M02_L02:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       call      00007FFD5C3C5D60
       cmp       dword ptr [7FFD5C72F778],0
       jne       short M02_L05
M02_L03:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L04:
       call      CORINFO_HELP_POLL_GC
       jmp       short M02_L01
M02_L05:
       call      CORINFO_HELP_POLL_GC
       jmp       short M02_L03
M02_L06:
       add       rdi,0FFFFFFFFFFFFC000
       lea       rcx,[rbx+rdi]
       lea       rdx,[rsi+rdi]
       mov       r8d,4000
       call      00007FFD5C3C5D60
       cmp       dword ptr [7FFD5C72F778],0
       je        short M02_L07
       call      CORINFO_HELP_POLL_GC
M02_L07:
       cmp       rdi,4000
       ja        short M02_L06
       jmp       short M02_L02
; Total bytes of code 184
```
```assembly
; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M03_L10
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M03_L10
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       ja        short M03_L03
       test      r8b,18
       je        short M03_L01
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
M03_L00:
       vzeroupper
       ret
M03_L01:
       test      r8b,4
       je        short M03_L02
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
       jmp       short M03_L00
M03_L02:
       test      r8,r8
       je        short M03_L00
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M03_L00
       movsx     r8,word ptr [rax-2]
       mov       [r10-2],r8w
       jmp       short M03_L00
M03_L03:
       cmp       r8,40
       ja        short M03_L07
M03_L04:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       jbe       short M03_L05
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       ja        short M03_L06
M03_L05:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
       jmp       short M03_L00
M03_L06:
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M03_L05
M03_L07:
       cmp       r8,800
       ja        short M03_L11
       cmp       r8,100
       jb        short M03_L08
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
M03_L08:
       mov       r9,r8
       shr       r9,6
M03_L09:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M03_L09
       and       r8,3F
       cmp       r8,10
       ja        near ptr M03_L04
       jmp       near ptr M03_L05
M03_L10:
       cmp       rcx,rdx
       jne       short M03_L11
       cmp       [rdx],dl
       jmp       near ptr M03_L00
M03_L11:
       cmp       [rcx],cl
       cmp       [rdx],dl
       vzeroupper
       jmp       qword ptr [7FFCFC7F66E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 319
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
       je        near ptr M04_L07
       test      rsi,rsi
       je        near ptr M04_L06
       mov       rcx,[rbx]
       cmp       rcx,[rsi]
       je        short M04_L00
       mov       rcx,[rbx]
       mov       ecx,[rcx+4]
       add       ecx,0FFFFFFE8
       shr       ecx,3
       mov       edx,1
       test      ecx,ecx
       cmove     ecx,edx
       mov       rdx,[rsi]
       mov       edx,[rdx+4]
       add       edx,0FFFFFFE8
       shr       edx,3
       mov       eax,1
       test      edx,edx
       cmove     edx,eax
       cmp       ecx,edx
       jne       near ptr M04_L08
M04_L00:
       mov       r14d,[rsp+70]
       test      r14d,r14d
       jl        near ptr M04_L09
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFD5A7A9400]; Precode of System.Array.GetLowerBound(Int32)
       cmp       edi,eax
       jge       short M04_L01
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,edi
       mov       edx,eax
       call      qword ptr [7FFD5A7C09C8]
       int       3
M04_L01:
       sub       edi,eax
       js        near ptr M04_L10
       lea       ecx,[rdi+r14]
       cmp       ecx,[rbx+8]
       ja        near ptr M04_L10
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFD5A7A9400]; Precode of System.Array.GetLowerBound(Int32)
       cmp       ebp,eax
       jge       short M04_L02
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,ebp
       mov       edx,eax
       call      qword ptr [7FFD5A7C09C8]
       int       3
M04_L02:
       sub       ebp,eax
       js        near ptr M04_L11
       lea       ecx,[r14+rbp]
       cmp       ecx,[rsi+8]
       ja        near ptr M04_L11
       mov       rcx,[rbx]
       cmp       rcx,[rsi]
       je        short M04_L03
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFD5A7A9320]
       test      eax,eax
       je        short M04_L03
       cmp       byte ptr [rsp+78],0
       jne       near ptr M04_L16
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
M04_L03:
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
       jne       short M04_L04
       cmp       r8,14
       jne       near ptr M04_L15
       jmp       near ptr M04_L14
M04_L04:
       cmp       r8,4000
       ja        near ptr M04_L13
       jmp       near ptr M04_L12
M04_L05:
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M04_L06:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFD5A7AB268]
       int       3
M04_L07:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFD5A7AB268]
       int       3
M04_L08:
       call      qword ptr [7FFD5A7A2830]
       mov       rbx,rax
       call      qword ptr [7FFD5A7ADDB0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD5A7AC810]
       mov       rcx,rbx
       call      qword ptr [7FFD5A797FA8]; CORINFO_HELP_THROW
       int       3
M04_L09:
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       ecx,r14d
       call      qword ptr [7FFD5A7C09B0]
       int       3
M04_L10:
       call      qword ptr [7FFD5A7A25F8]
       mov       rbx,rax
       call      qword ptr [7FFD5A7ACC68]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,rbx
       call      qword ptr [7FFD5A7AB218]
       mov       rcx,rbx
       call      qword ptr [7FFD5A797FA8]; CORINFO_HELP_THROW
       int       3
M04_L11:
       call      qword ptr [7FFD5A7A25F8]
       mov       r14,rax
       call      qword ptr [7FFD5A7ACC60]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,r14
       call      qword ptr [7FFD5A7AB218]
       mov       rcx,r14
       call      qword ptr [7FFD5A797FA8]; CORINFO_HELP_THROW
       int       3
M04_L12:
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FFD5A7A96A0]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       je        near ptr M04_L05
       call      qword ptr [7FFD5A798028]; CORINFO_HELP_POLL_GC
       jmp       near ptr M04_L05
M04_L13:
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
M04_L14:
       movups    xmm0,[r10]
       movups    xmm1,[r10+4]
       movups    [rdx],xmm0
       movups    [rdx+4],xmm1
       jmp       near ptr M04_L05
M04_L15:
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FFD5A7AC980]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M04_L05
M04_L16:
       call      qword ptr [7FFD5A7A2620]
       mov       rbx,rax
       call      qword ptr [7FFD5A7AD730]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD5A7AB298]
       mov       rcx,rbx
       call      qword ptr [7FFD5A797FA8]; CORINFO_HELP_THROW
       int       3
; Total bytes of code 748
```
```assembly
; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       sub       rsp,38
       mov       eax,[rsp+60]
       test      rcx,rcx
       je        near ptr M05_L06
       test      r8,r8
       je        near ptr M05_L06
       mov       r10,[rcx]
       cmp       r10,[r8]
       jne       near ptr M05_L06
       cmp       dword ptr [r10+4],18
       jne       near ptr M05_L06
       mov       r11d,eax
       or        r11d,edx
       or        r11d,r9d
       jl        near ptr M05_L06
       lea       r11d,[rdx+rax]
       cmp       r11d,[rcx+8]
       ja        near ptr M05_L06
       lea       r11d,[r9+rax]
       cmp       r11d,[r8+8]
       ja        short M05_L06
       movzx     r11d,word ptr [r10]
       mov       eax,eax
       imul      rax,r11
       mov       edx,edx
       imul      rdx,r11
       lea       rdx,[rcx+rdx+10]
       mov       ecx,r9d
       imul      rcx,r11
       lea       rcx,[r8+rcx+10]
       test      dword ptr [r10],1000000
       je        short M05_L05
       cmp       rax,4000
       ja        short M05_L04
       mov       r8,rax
       call      00007FFD5C3C5D60
       cmp       dword ptr [7FFD5C72F778],0
       jne       short M05_L02
M05_L00:
       cmp       dword ptr [7FFD5C72F778],0
       jne       short M05_L03
M05_L01:
       add       rsp,38
       ret
M05_L02:
       call      CORINFO_HELP_POLL_GC
       jmp       short M05_L00
M05_L03:
       call      CORINFO_HELP_POLL_GC
       jmp       short M05_L01
M05_L04:
       mov       r8,rax
       add       rsp,38
       jmp       qword ptr [7FFCFCFF5248]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
M05_L05:
       mov       r8,rax
       call      qword ptr [7FFCFC7F5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M05_L00
M05_L06:
       mov       [rsp+20],eax
       xor       eax,eax
       mov       [rsp+28],eax
       call      qword ptr [7FFCFD1CC660]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       short M05_L00
; Total bytes of code 225
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsAddRemoveCollectionBenchmark.AddFirst()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+38],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       rdi,[rbx+48]
       test      rdi,rdi
       je        near ptr M00_L05
       test      rsi,rsi
       je        near ptr M00_L06
       mov       ebp,[rsi+10]
       mov       rdx,[rsi+8]
       cmp       ebp,[rdx+8]
       jne       near ptr M00_L04
       mov       edx,ebp
       add       edx,1
       jo        near ptr M00_L13
       mov       rcx,[rsi+8]
       cmp       dword ptr [rcx+8],0
       jne       near ptr M00_L03
       mov       ecx,4
M00_L00:
       mov       eax,7FFFFFC7
       cmp       ecx,7FFFFFC7
       cmova     ecx,eax
       cmp       ecx,edx
       cmovl     ecx,edx
       movsxd    rdx,ecx
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       test      ebp,ebp
       je        near ptr M00_L01
       mov       rcx,[rsi+8]
       test      rcx,rcx
       je        near ptr M00_L10
       mov       rdx,[rcx]
       cmp       rdx,[r14]
       jne       near ptr M00_L10
       cmp       dword ptr [rdx+4],18
       jne       near ptr M00_L10
       test      ebp,ebp
       jl        near ptr M00_L10
       cmp       ebp,[rcx+8]
       ja        near ptr M00_L10
       lea       r8d,[rbp+1]
       cmp       r8d,[r14+8]
       ja        near ptr M00_L10
       movzx     r8d,word ptr [rdx]
       mov       eax,ebp
       imul      rax,r8
       add       rcx,10
       mov       r10,rcx
       lea       rcx,[r14+r8+10]
       test      dword ptr [rdx],1000000
       je        near ptr M00_L09
       cmp       rax,4000
       ja        near ptr M00_L08
       mov       rdx,r10
       mov       r8,rax
       call      00007FFD5C3C5D60
       cmp       dword ptr [7FFD5C72F778],0
       jne       near ptr M00_L07
M00_L01:
       lea       rcx,[rsi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
M00_L02:
       mov       rcx,[rsi+8]
       mov       edx,[rcx+8]
       test      rdx,rdx
       je        near ptr M00_L12
       lea       rcx,[rcx+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rsi+10]
       inc       dword ptr [rsi+14]
       mov       [rsp+38],rsi
       mov       rbx,[rbx+60]
       mov       rdx,[rsp+38]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L03:
       mov       rcx,[rsi+8]
       mov       ecx,[rcx+8]
       add       ecx,ecx
       jmp       near ptr M00_L00
M00_L04:
       test      ebp,ebp
       jle       short M00_L02
       jmp       near ptr M00_L11
M00_L05:
       call      qword ptr [7FFCFCEBE958]
       mov       ecx,0F
       mov       rdx,7FFCFCD16050
       call      qword ptr [7FFCFC7EF210]
       mov       rbx,rax
       mov       ecx,1B61
       mov       rdx,7FFCFCBE5770
       call      qword ptr [7FFCFC7EF210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCFC7ED9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFCFCD16050
       call      qword ptr [7FFCFC7EF210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCFC7ED9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCFD104690]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCFD1046A8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L06:
       call      qword ptr [7FFCFCEBE958]
       mov       ecx,69E
       mov       rdx,7FFCFCD16050
       call      qword ptr [7FFCFC7EF210]
       mov       rbx,rax
       mov       ecx,1B61
       mov       rdx,7FFCFCBE5770
       call      qword ptr [7FFCFC7EF210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCFC7ED9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFCFCD16050
       call      qword ptr [7FFCFC7EF210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCFC7ED9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCFD104690]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCFD1046A8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L01
M00_L08:
       mov       rdx,r10
       mov       r8,rax
       call      qword ptr [7FFCFCEBE370]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L01
M00_L09:
       mov       rdx,r10
       mov       r8,rax
       call      qword ptr [7FFCFC7E5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L01
M00_L10:
       mov       [rsp+20],ebp
       xor       r8d,r8d
       mov       [rsp+28],r8d
       mov       r8,r14
       xor       edx,edx
       mov       r9d,1
       call      qword ptr [7FFCFD1C4B10]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M00_L01
M00_L11:
       mov       [rsp+20],ebp
       mov       rcx,[rsi+8]
       mov       r8,[rsi+8]
       xor       edx,edx
       mov       r9d,1
       call      qword ptr [7FFCFCE3CFC0]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       near ptr M00_L02
M00_L12:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L13:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 809
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
       call      00007FFD5C418D20
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFCFC7E5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFCFC7E5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,24222960008
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
       call      qword ptr [7FFCFD1C7D20]
       int       3
; Total bytes of code 235
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
       je        short M02_L03
       mov       rcx,rbx
       sub       rcx,rsi
       cmp       rcx,rdi
       jb        short M02_L06
M02_L00:
       add       rdi,0FFFFFFFFFFFFC000
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,4000
       call      00007FFD5C3C5D60
       add       rbx,4000
       add       rsi,4000
       cmp       dword ptr [7FFD5C72F778],0
       jne       short M02_L04
M02_L01:
       cmp       rdi,4000
       ja        short M02_L00
M02_L02:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       call      00007FFD5C3C5D60
       cmp       dword ptr [7FFD5C72F778],0
       jne       short M02_L05
M02_L03:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L04:
       call      CORINFO_HELP_POLL_GC
       jmp       short M02_L01
M02_L05:
       call      CORINFO_HELP_POLL_GC
       jmp       short M02_L03
M02_L06:
       add       rdi,0FFFFFFFFFFFFC000
       lea       rcx,[rbx+rdi]
       lea       rdx,[rsi+rdi]
       mov       r8d,4000
       call      00007FFD5C3C5D60
       cmp       dword ptr [7FFD5C72F778],0
       je        short M02_L07
       call      CORINFO_HELP_POLL_GC
M02_L07:
       cmp       rdi,4000
       ja        short M02_L06
       jmp       short M02_L02
; Total bytes of code 184
```
```assembly
; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M03_L10
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M03_L10
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       ja        short M03_L03
       test      r8b,18
       je        short M03_L01
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
M03_L00:
       vzeroupper
       ret
M03_L01:
       test      r8b,4
       je        short M03_L02
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
       jmp       short M03_L00
M03_L02:
       test      r8,r8
       je        short M03_L00
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M03_L00
       movsx     r8,word ptr [rax-2]
       mov       [r10-2],r8w
       jmp       short M03_L00
M03_L03:
       cmp       r8,40
       ja        short M03_L07
M03_L04:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       jbe       short M03_L05
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       ja        short M03_L06
M03_L05:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
       jmp       short M03_L00
M03_L06:
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M03_L05
M03_L07:
       cmp       r8,800
       ja        short M03_L11
       cmp       r8,100
       jb        short M03_L08
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
M03_L08:
       mov       r9,r8
       shr       r9,6
M03_L09:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M03_L09
       and       r8,3F
       cmp       r8,10
       ja        near ptr M03_L04
       jmp       near ptr M03_L05
M03_L10:
       cmp       rcx,rdx
       jne       short M03_L11
       cmp       [rdx],dl
       jmp       near ptr M03_L00
M03_L11:
       cmp       [rcx],cl
       cmp       [rdx],dl
       vzeroupper
       jmp       qword ptr [7FFCFC7E66E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 319
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
       je        near ptr M04_L07
       test      rsi,rsi
       je        near ptr M04_L06
       mov       rcx,[rbx]
       cmp       rcx,[rsi]
       je        short M04_L00
       mov       rcx,[rbx]
       mov       ecx,[rcx+4]
       add       ecx,0FFFFFFE8
       shr       ecx,3
       mov       edx,1
       test      ecx,ecx
       cmove     ecx,edx
       mov       rdx,[rsi]
       mov       edx,[rdx+4]
       add       edx,0FFFFFFE8
       shr       edx,3
       mov       eax,1
       test      edx,edx
       cmove     edx,eax
       cmp       ecx,edx
       jne       near ptr M04_L08
M04_L00:
       mov       r14d,[rsp+70]
       test      r14d,r14d
       jl        near ptr M04_L09
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFD5A7A9400]; Precode of System.Array.GetLowerBound(Int32)
       cmp       edi,eax
       jge       short M04_L01
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,edi
       mov       edx,eax
       call      qword ptr [7FFD5A7C09C8]
       int       3
M04_L01:
       sub       edi,eax
       js        near ptr M04_L10
       lea       ecx,[rdi+r14]
       cmp       ecx,[rbx+8]
       ja        near ptr M04_L10
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFD5A7A9400]; Precode of System.Array.GetLowerBound(Int32)
       cmp       ebp,eax
       jge       short M04_L02
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,ebp
       mov       edx,eax
       call      qword ptr [7FFD5A7C09C8]
       int       3
M04_L02:
       sub       ebp,eax
       js        near ptr M04_L11
       lea       ecx,[r14+rbp]
       cmp       ecx,[rsi+8]
       ja        near ptr M04_L11
       mov       rcx,[rbx]
       cmp       rcx,[rsi]
       je        short M04_L03
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFD5A7A9320]
       test      eax,eax
       je        short M04_L03
       cmp       byte ptr [rsp+78],0
       jne       near ptr M04_L16
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
M04_L03:
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
       jne       short M04_L04
       cmp       r8,14
       jne       near ptr M04_L15
       jmp       near ptr M04_L14
M04_L04:
       cmp       r8,4000
       ja        near ptr M04_L13
       jmp       near ptr M04_L12
M04_L05:
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M04_L06:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFD5A7AB268]
       int       3
M04_L07:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFD5A7AB268]
       int       3
M04_L08:
       call      qword ptr [7FFD5A7A2830]
       mov       rbx,rax
       call      qword ptr [7FFD5A7ADDB0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD5A7AC810]
       mov       rcx,rbx
       call      qword ptr [7FFD5A797FA8]; CORINFO_HELP_THROW
       int       3
M04_L09:
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       ecx,r14d
       call      qword ptr [7FFD5A7C09B0]
       int       3
M04_L10:
       call      qword ptr [7FFD5A7A25F8]
       mov       rbx,rax
       call      qword ptr [7FFD5A7ACC68]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,rbx
       call      qword ptr [7FFD5A7AB218]
       mov       rcx,rbx
       call      qword ptr [7FFD5A797FA8]; CORINFO_HELP_THROW
       int       3
M04_L11:
       call      qword ptr [7FFD5A7A25F8]
       mov       r14,rax
       call      qword ptr [7FFD5A7ACC60]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,r14
       call      qword ptr [7FFD5A7AB218]
       mov       rcx,r14
       call      qword ptr [7FFD5A797FA8]; CORINFO_HELP_THROW
       int       3
M04_L12:
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FFD5A7A96A0]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       je        near ptr M04_L05
       call      qword ptr [7FFD5A798028]; CORINFO_HELP_POLL_GC
       jmp       near ptr M04_L05
M04_L13:
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
M04_L14:
       movups    xmm0,[r10]
       movups    xmm1,[r10+4]
       movups    [rdx],xmm0
       movups    [rdx+4],xmm1
       jmp       near ptr M04_L05
M04_L15:
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FFD5A7AC980]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M04_L05
M04_L16:
       call      qword ptr [7FFD5A7A2620]
       mov       rbx,rax
       call      qword ptr [7FFD5A7AD730]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD5A7AB298]
       mov       rcx,rbx
       call      qword ptr [7FFD5A797FA8]; CORINFO_HELP_THROW
       int       3
; Total bytes of code 748
```
```assembly
; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       sub       rsp,38
       mov       eax,[rsp+60]
       test      rcx,rcx
       je        near ptr M05_L06
       test      r8,r8
       je        near ptr M05_L06
       mov       r10,[rcx]
       cmp       r10,[r8]
       jne       near ptr M05_L06
       cmp       dword ptr [r10+4],18
       jne       near ptr M05_L06
       mov       r11d,eax
       or        r11d,edx
       or        r11d,r9d
       jl        near ptr M05_L06
       lea       r11d,[rdx+rax]
       cmp       r11d,[rcx+8]
       ja        near ptr M05_L06
       lea       r11d,[r9+rax]
       cmp       r11d,[r8+8]
       ja        short M05_L06
       movzx     r11d,word ptr [r10]
       mov       eax,eax
       imul      rax,r11
       mov       edx,edx
       imul      rdx,r11
       lea       rdx,[rcx+rdx+10]
       mov       ecx,r9d
       imul      rcx,r11
       lea       rcx,[r8+rcx+10]
       test      dword ptr [r10],1000000
       je        short M05_L05
       cmp       rax,4000
       ja        short M05_L04
       mov       r8,rax
       call      00007FFD5C3C5D60
       cmp       dword ptr [7FFD5C72F778],0
       jne       short M05_L02
M05_L00:
       cmp       dword ptr [7FFD5C72F778],0
       jne       short M05_L03
M05_L01:
       add       rsp,38
       ret
M05_L02:
       call      CORINFO_HELP_POLL_GC
       jmp       short M05_L00
M05_L03:
       call      CORINFO_HELP_POLL_GC
       jmp       short M05_L01
M05_L04:
       mov       r8,rax
       add       rsp,38
       jmp       qword ptr [7FFCFCEBE370]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
M05_L05:
       mov       r8,rax
       call      qword ptr [7FFCFC7E5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M05_L00
M05_L06:
       mov       [rsp+20],eax
       xor       eax,eax
       mov       [rsp+28],eax
       call      qword ptr [7FFCFD1C4B10]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       short M05_L00
; Total bytes of code 225
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsAddRemoveCollectionBenchmark.AddFirst()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+38],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       rdi,[rbx+48]
       test      rdi,rdi
       je        near ptr M00_L05
       test      rsi,rsi
       je        near ptr M00_L06
       mov       ebp,[rsi+10]
       mov       rcx,[rsi+8]
       cmp       ebp,[rcx+8]
       je        short M00_L01
       test      ebp,ebp
       jg        near ptr M00_L11
M00_L00:
       mov       rcx,[rsi+8]
       mov       edx,[rcx+8]
       test      rdx,rdx
       je        near ptr M00_L12
       lea       rcx,[rcx+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rsi+10]
       inc       dword ptr [rsi+14]
       mov       [rsp+38],rsi
       mov       rbx,[rbx+60]
       mov       rdx,[rsp+38]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L01:
       mov       edx,ebp
       add       edx,1
       jo        near ptr M00_L13
       mov       rcx,[rsi+8]
       cmp       dword ptr [rcx+8],0
       jne       near ptr M00_L04
       mov       ecx,4
M00_L02:
       mov       eax,7FFFFFC7
       cmp       ecx,7FFFFFC7
       cmova     ecx,eax
       cmp       ecx,edx
       cmovl     ecx,edx
       movsxd    rdx,ecx
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       test      ebp,ebp
       je        near ptr M00_L03
       mov       rcx,[rsi+8]
       test      rcx,rcx
       je        near ptr M00_L10
       mov       rdx,[rcx]
       cmp       rdx,[r14]
       jne       near ptr M00_L10
       cmp       dword ptr [rdx+4],18
       jne       near ptr M00_L10
       test      ebp,ebp
       jl        near ptr M00_L10
       cmp       ebp,[rcx+8]
       ja        near ptr M00_L10
       lea       r8d,[rbp+1]
       cmp       r8d,[r14+8]
       ja        near ptr M00_L10
       movzx     r8d,word ptr [rdx]
       mov       eax,ebp
       imul      rax,r8
       add       rcx,10
       mov       r10,rcx
       lea       rcx,[r14+r8+10]
       test      dword ptr [rdx],1000000
       je        near ptr M00_L09
       cmp       rax,4000
       ja        near ptr M00_L08
       mov       rdx,r10
       mov       r8,rax
       call      00007FFD5C3C5D60
       cmp       dword ptr [7FFD5C72F778],0
       jne       near ptr M00_L07
M00_L03:
       lea       rcx,[rsi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L04:
       mov       rcx,[rsi+8]
       mov       ecx,[rcx+8]
       add       ecx,ecx
       jmp       near ptr M00_L02
M00_L05:
       call      qword ptr [7FFCFCEAE958]
       mov       ecx,0F
       mov       rdx,7FFCFCD06050
       call      qword ptr [7FFCFC7DF210]
       mov       rbx,rax
       mov       ecx,1B61
       mov       rdx,7FFCFCBD5770
       call      qword ptr [7FFCFC7DF210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCFC7DD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFCFCD06050
       call      qword ptr [7FFCFC7DF210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCFC7DD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCFD0F47C8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCFD0F47E0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L06:
       call      qword ptr [7FFCFCEAE958]
       mov       ecx,69E
       mov       rdx,7FFCFCD06050
       call      qword ptr [7FFCFC7DF210]
       mov       rbx,rax
       mov       ecx,1B61
       mov       rdx,7FFCFCBD5770
       call      qword ptr [7FFCFC7DF210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCFC7DD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFCFCD06050
       call      qword ptr [7FFCFC7DF210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCFC7DD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCFD0F47C8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCFD0F47E0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L03
M00_L08:
       mov       rdx,r10
       mov       r8,rax
       call      qword ptr [7FFCFCEAE370]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L03
M00_L09:
       mov       rdx,r10
       mov       r8,rax
       call      qword ptr [7FFCFC7D5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L03
M00_L10:
       mov       [rsp+20],ebp
       xor       r8d,r8d
       mov       [rsp+28],r8d
       mov       r8,r14
       xor       edx,edx
       mov       r9d,1
       call      qword ptr [7FFCFD1B4DC8]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M00_L03
M00_L11:
       mov       [rsp+20],ebp
       mov       rcx,[rsi+8]
       mov       r8,[rsi+8]
       xor       edx,edx
       mov       r9d,1
       call      qword ptr [7FFCFCE2CFC0]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       near ptr M00_L00
M00_L12:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L13:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 809
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
       call      00007FFD5C418D20
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFCFC7D5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFCFC7D5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,2C3120F0008
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
       call      qword ptr [7FFCFD1B7CA8]
       int       3
; Total bytes of code 235
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
       je        short M02_L03
       mov       rcx,rbx
       sub       rcx,rsi
       cmp       rcx,rdi
       jb        short M02_L06
M02_L00:
       add       rdi,0FFFFFFFFFFFFC000
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,4000
       call      00007FFD5C3C5D60
       add       rbx,4000
       add       rsi,4000
       cmp       dword ptr [7FFD5C72F778],0
       jne       short M02_L04
M02_L01:
       cmp       rdi,4000
       ja        short M02_L00
M02_L02:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       call      00007FFD5C3C5D60
       cmp       dword ptr [7FFD5C72F778],0
       jne       short M02_L05
M02_L03:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L04:
       call      CORINFO_HELP_POLL_GC
       jmp       short M02_L01
M02_L05:
       call      CORINFO_HELP_POLL_GC
       jmp       short M02_L03
M02_L06:
       add       rdi,0FFFFFFFFFFFFC000
       lea       rcx,[rbx+rdi]
       lea       rdx,[rsi+rdi]
       mov       r8d,4000
       call      00007FFD5C3C5D60
       cmp       dword ptr [7FFD5C72F778],0
       je        short M02_L07
       call      CORINFO_HELP_POLL_GC
M02_L07:
       cmp       rdi,4000
       ja        short M02_L06
       jmp       short M02_L02
; Total bytes of code 184
```
```assembly
; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M03_L10
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M03_L10
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       ja        short M03_L03
       test      r8b,18
       je        short M03_L01
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
M03_L00:
       vzeroupper
       ret
M03_L01:
       test      r8b,4
       je        short M03_L02
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
       jmp       short M03_L00
M03_L02:
       test      r8,r8
       je        short M03_L00
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M03_L00
       movsx     r8,word ptr [rax-2]
       mov       [r10-2],r8w
       jmp       short M03_L00
M03_L03:
       cmp       r8,40
       ja        short M03_L07
M03_L04:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       jbe       short M03_L05
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       ja        short M03_L06
M03_L05:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
       jmp       short M03_L00
M03_L06:
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M03_L05
M03_L07:
       cmp       r8,800
       ja        short M03_L11
       cmp       r8,100
       jb        short M03_L08
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
M03_L08:
       mov       r9,r8
       shr       r9,6
M03_L09:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M03_L09
       and       r8,3F
       cmp       r8,10
       ja        near ptr M03_L04
       jmp       near ptr M03_L05
M03_L10:
       cmp       rcx,rdx
       jne       short M03_L11
       cmp       [rdx],dl
       jmp       near ptr M03_L00
M03_L11:
       cmp       [rcx],cl
       cmp       [rdx],dl
       vzeroupper
       jmp       qword ptr [7FFCFC7D66E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 319
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
       je        near ptr M04_L07
       test      rsi,rsi
       je        near ptr M04_L06
       mov       rcx,[rbx]
       cmp       rcx,[rsi]
       je        short M04_L00
       mov       rcx,[rbx]
       mov       ecx,[rcx+4]
       add       ecx,0FFFFFFE8
       shr       ecx,3
       mov       edx,1
       test      ecx,ecx
       cmove     ecx,edx
       mov       rdx,[rsi]
       mov       edx,[rdx+4]
       add       edx,0FFFFFFE8
       shr       edx,3
       mov       eax,1
       test      edx,edx
       cmove     edx,eax
       cmp       ecx,edx
       jne       near ptr M04_L08
M04_L00:
       mov       r14d,[rsp+70]
       test      r14d,r14d
       jl        near ptr M04_L09
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFD5A7A9400]; Precode of System.Array.GetLowerBound(Int32)
       cmp       edi,eax
       jge       short M04_L01
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,edi
       mov       edx,eax
       call      qword ptr [7FFD5A7C09C8]
       int       3
M04_L01:
       sub       edi,eax
       js        near ptr M04_L10
       lea       ecx,[rdi+r14]
       cmp       ecx,[rbx+8]
       ja        near ptr M04_L10
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFD5A7A9400]; Precode of System.Array.GetLowerBound(Int32)
       cmp       ebp,eax
       jge       short M04_L02
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,ebp
       mov       edx,eax
       call      qword ptr [7FFD5A7C09C8]
       int       3
M04_L02:
       sub       ebp,eax
       js        near ptr M04_L11
       lea       ecx,[r14+rbp]
       cmp       ecx,[rsi+8]
       ja        near ptr M04_L11
       mov       rcx,[rbx]
       cmp       rcx,[rsi]
       je        short M04_L03
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFD5A7A9320]
       test      eax,eax
       je        short M04_L03
       cmp       byte ptr [rsp+78],0
       jne       near ptr M04_L16
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
M04_L03:
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
       jne       short M04_L04
       cmp       r8,14
       jne       near ptr M04_L15
       jmp       near ptr M04_L14
M04_L04:
       cmp       r8,4000
       ja        near ptr M04_L13
       jmp       near ptr M04_L12
M04_L05:
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M04_L06:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFD5A7AB268]
       int       3
M04_L07:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFD5A7AB268]
       int       3
M04_L08:
       call      qword ptr [7FFD5A7A2830]
       mov       rbx,rax
       call      qword ptr [7FFD5A7ADDB0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD5A7AC810]
       mov       rcx,rbx
       call      qword ptr [7FFD5A797FA8]; CORINFO_HELP_THROW
       int       3
M04_L09:
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       ecx,r14d
       call      qword ptr [7FFD5A7C09B0]
       int       3
M04_L10:
       call      qword ptr [7FFD5A7A25F8]
       mov       rbx,rax
       call      qword ptr [7FFD5A7ACC68]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,rbx
       call      qword ptr [7FFD5A7AB218]
       mov       rcx,rbx
       call      qword ptr [7FFD5A797FA8]; CORINFO_HELP_THROW
       int       3
M04_L11:
       call      qword ptr [7FFD5A7A25F8]
       mov       r14,rax
       call      qword ptr [7FFD5A7ACC60]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,r14
       call      qword ptr [7FFD5A7AB218]
       mov       rcx,r14
       call      qword ptr [7FFD5A797FA8]; CORINFO_HELP_THROW
       int       3
M04_L12:
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FFD5A7A96A0]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       je        near ptr M04_L05
       call      qword ptr [7FFD5A798028]; CORINFO_HELP_POLL_GC
       jmp       near ptr M04_L05
M04_L13:
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
M04_L14:
       movups    xmm0,[r10]
       movups    xmm1,[r10+4]
       movups    [rdx],xmm0
       movups    [rdx+4],xmm1
       jmp       near ptr M04_L05
M04_L15:
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FFD5A7AC980]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M04_L05
M04_L16:
       call      qword ptr [7FFD5A7A2620]
       mov       rbx,rax
       call      qword ptr [7FFD5A7AD730]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD5A7AB298]
       mov       rcx,rbx
       call      qword ptr [7FFD5A797FA8]; CORINFO_HELP_THROW
       int       3
; Total bytes of code 748
```
```assembly
; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       sub       rsp,38
       mov       eax,[rsp+60]
       test      rcx,rcx
       je        near ptr M05_L06
       test      r8,r8
       je        near ptr M05_L06
       mov       r10,[rcx]
       cmp       r10,[r8]
       jne       near ptr M05_L06
       cmp       dword ptr [r10+4],18
       jne       near ptr M05_L06
       mov       r11d,eax
       or        r11d,edx
       or        r11d,r9d
       jl        near ptr M05_L06
       lea       r11d,[rdx+rax]
       cmp       r11d,[rcx+8]
       ja        near ptr M05_L06
       lea       r11d,[r9+rax]
       cmp       r11d,[r8+8]
       ja        short M05_L06
       movzx     r11d,word ptr [r10]
       mov       eax,eax
       imul      rax,r11
       mov       edx,edx
       imul      rdx,r11
       lea       rdx,[rcx+rdx+10]
       mov       ecx,r9d
       imul      rcx,r11
       lea       rcx,[r8+rcx+10]
       test      dword ptr [r10],1000000
       je        short M05_L02
       cmp       rax,4000
       ja        short M05_L05
       mov       r8,rax
       call      00007FFD5C3C5D60
       cmp       dword ptr [7FFD5C72F778],0
       jne       short M05_L03
M05_L00:
       cmp       dword ptr [7FFD5C72F778],0
       jne       short M05_L04
M05_L01:
       add       rsp,38
       ret
M05_L02:
       mov       r8,rax
       call      qword ptr [7FFCFC7D5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M05_L00
M05_L03:
       call      CORINFO_HELP_POLL_GC
       jmp       short M05_L00
M05_L04:
       call      CORINFO_HELP_POLL_GC
       jmp       short M05_L01
M05_L05:
       mov       r8,rax
       add       rsp,38
       jmp       qword ptr [7FFCFCEAE370]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
M05_L06:
       mov       [rsp+20],eax
       xor       eax,eax
       mov       [rsp+28],eax
       call      qword ptr [7FFCFD1B4DC8]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       short M05_L00
; Total bytes of code 225
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsAddRemoveCollectionBenchmark.AddFirst()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+38],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       rdi,[rbx+48]
       test      rdi,rdi
       je        near ptr M00_L05
       test      rsi,rsi
       je        near ptr M00_L06
       mov       ebp,[rsi+10]
       mov       rdx,[rsi+8]
       cmp       ebp,[rdx+8]
       jne       near ptr M00_L04
       mov       edx,ebp
       add       edx,1
       jo        near ptr M00_L13
       mov       rcx,[rsi+8]
       cmp       dword ptr [rcx+8],0
       jne       near ptr M00_L03
       mov       ecx,4
M00_L00:
       mov       eax,7FFFFFC7
       cmp       ecx,7FFFFFC7
       cmova     ecx,eax
       cmp       ecx,edx
       cmovl     ecx,edx
       movsxd    rdx,ecx
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       test      ebp,ebp
       je        near ptr M00_L01
       mov       rcx,[rsi+8]
       test      rcx,rcx
       je        near ptr M00_L10
       mov       rdx,[rcx]
       cmp       rdx,[r14]
       jne       near ptr M00_L10
       cmp       dword ptr [rdx+4],18
       jne       near ptr M00_L10
       test      ebp,ebp
       jl        near ptr M00_L10
       cmp       ebp,[rcx+8]
       ja        near ptr M00_L10
       lea       r8d,[rbp+1]
       cmp       r8d,[r14+8]
       ja        near ptr M00_L10
       movzx     r8d,word ptr [rdx]
       mov       eax,ebp
       imul      rax,r8
       add       rcx,10
       mov       r10,rcx
       lea       rcx,[r14+r8+10]
       test      dword ptr [rdx],1000000
       je        near ptr M00_L09
       cmp       rax,4000
       ja        near ptr M00_L08
       mov       rdx,r10
       mov       r8,rax
       call      00007FFD5C3C5D60
       cmp       dword ptr [7FFD5C72F778],0
       jne       near ptr M00_L07
M00_L01:
       lea       rcx,[rsi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
M00_L02:
       mov       rcx,[rsi+8]
       mov       edx,[rcx+8]
       test      rdx,rdx
       je        near ptr M00_L12
       lea       rcx,[rcx+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rsi+10]
       inc       dword ptr [rsi+14]
       mov       [rsp+38],rsi
       mov       rbx,[rbx+60]
       mov       rdx,[rsp+38]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L03:
       mov       rcx,[rsi+8]
       mov       ecx,[rcx+8]
       add       ecx,ecx
       jmp       near ptr M00_L00
M00_L04:
       test      ebp,ebp
       jle       short M00_L02
       jmp       near ptr M00_L11
M00_L05:
       call      qword ptr [7FFCFCEBE430]
       mov       ecx,0F
       mov       rdx,7FFCFCD16050
       call      qword ptr [7FFCFC7EF210]
       mov       rbx,rax
       mov       ecx,1B61
       mov       rdx,7FFCFCBE5770
       call      qword ptr [7FFCFC7EF210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCFC7ED9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFCFCD16050
       call      qword ptr [7FFCFC7EF210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCFC7ED9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCFD0F4240]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCFD0F4258]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L06:
       call      qword ptr [7FFCFCEBE430]
       mov       ecx,69E
       mov       rdx,7FFCFCD16050
       call      qword ptr [7FFCFC7EF210]
       mov       rbx,rax
       mov       ecx,1B61
       mov       rdx,7FFCFCBE5770
       call      qword ptr [7FFCFC7EF210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCFC7ED9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFCFCD16050
       call      qword ptr [7FFCFC7EF210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCFC7ED9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCFD0F4240]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCFD0F4258]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L01
M00_L08:
       mov       rdx,r10
       mov       r8,rax
       call      qword ptr [7FFCFCEBE388]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L01
M00_L09:
       mov       rdx,r10
       mov       r8,rax
       call      qword ptr [7FFCFC7E5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L01
M00_L10:
       mov       [rsp+20],ebp
       xor       r8d,r8d
       mov       [rsp+28],r8d
       mov       r8,r14
       xor       edx,edx
       mov       r9d,1
       call      qword ptr [7FFCFD0F79F0]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M00_L01
M00_L11:
       mov       [rsp+20],ebp
       mov       rcx,[rsi+8]
       mov       r8,[rsi+8]
       xor       edx,edx
       mov       r9d,1
       call      qword ptr [7FFCFCE3CFC0]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       near ptr M00_L02
M00_L12:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L13:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 809
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
       call      00007FFD5C418D20
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFCFC7E5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFCFC7E5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,27030360008
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
       call      qword ptr [7FFCFD1E7C78]
       int       3
; Total bytes of code 235
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
       je        short M02_L03
       mov       rcx,rbx
       sub       rcx,rsi
       cmp       rcx,rdi
       jb        short M02_L06
M02_L00:
       add       rdi,0FFFFFFFFFFFFC000
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,4000
       call      00007FFD5C3C5D60
       add       rbx,4000
       add       rsi,4000
       cmp       dword ptr [7FFD5C72F778],0
       jne       short M02_L04
M02_L01:
       cmp       rdi,4000
       ja        short M02_L00
M02_L02:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       call      00007FFD5C3C5D60
       cmp       dword ptr [7FFD5C72F778],0
       jne       short M02_L05
M02_L03:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L04:
       call      CORINFO_HELP_POLL_GC
       jmp       short M02_L01
M02_L05:
       call      CORINFO_HELP_POLL_GC
       jmp       short M02_L03
M02_L06:
       add       rdi,0FFFFFFFFFFFFC000
       lea       rcx,[rbx+rdi]
       lea       rdx,[rsi+rdi]
       mov       r8d,4000
       call      00007FFD5C3C5D60
       cmp       dword ptr [7FFD5C72F778],0
       je        short M02_L07
       call      CORINFO_HELP_POLL_GC
M02_L07:
       cmp       rdi,4000
       ja        short M02_L06
       jmp       short M02_L02
; Total bytes of code 184
```
```assembly
; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M03_L10
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M03_L10
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       ja        short M03_L03
       test      r8b,18
       je        short M03_L01
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
M03_L00:
       vzeroupper
       ret
M03_L01:
       test      r8b,4
       je        short M03_L02
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
       jmp       short M03_L00
M03_L02:
       test      r8,r8
       je        short M03_L00
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M03_L00
       movsx     r8,word ptr [rax-2]
       mov       [r10-2],r8w
       jmp       short M03_L00
M03_L03:
       cmp       r8,40
       ja        short M03_L07
M03_L04:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       jbe       short M03_L05
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       ja        short M03_L06
M03_L05:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
       jmp       short M03_L00
M03_L06:
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M03_L05
M03_L07:
       cmp       r8,800
       ja        short M03_L11
       cmp       r8,100
       jb        short M03_L08
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
M03_L08:
       mov       r9,r8
       shr       r9,6
M03_L09:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M03_L09
       and       r8,3F
       cmp       r8,10
       ja        near ptr M03_L04
       jmp       near ptr M03_L05
M03_L10:
       cmp       rcx,rdx
       jne       short M03_L11
       cmp       [rdx],dl
       jmp       near ptr M03_L00
M03_L11:
       cmp       [rcx],cl
       cmp       [rdx],dl
       vzeroupper
       jmp       qword ptr [7FFCFC7E66E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 319
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
       je        near ptr M04_L07
       test      rsi,rsi
       je        near ptr M04_L06
       mov       rcx,[rbx]
       cmp       rcx,[rsi]
       je        short M04_L00
       mov       rcx,[rbx]
       mov       ecx,[rcx+4]
       add       ecx,0FFFFFFE8
       shr       ecx,3
       mov       edx,1
       test      ecx,ecx
       cmove     ecx,edx
       mov       rdx,[rsi]
       mov       edx,[rdx+4]
       add       edx,0FFFFFFE8
       shr       edx,3
       mov       eax,1
       test      edx,edx
       cmove     edx,eax
       cmp       ecx,edx
       jne       near ptr M04_L08
M04_L00:
       mov       r14d,[rsp+70]
       test      r14d,r14d
       jl        near ptr M04_L09
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFD5A7A9400]; Precode of System.Array.GetLowerBound(Int32)
       cmp       edi,eax
       jge       short M04_L01
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,edi
       mov       edx,eax
       call      qword ptr [7FFD5A7C09C8]
       int       3
M04_L01:
       sub       edi,eax
       js        near ptr M04_L10
       lea       ecx,[rdi+r14]
       cmp       ecx,[rbx+8]
       ja        near ptr M04_L10
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFD5A7A9400]; Precode of System.Array.GetLowerBound(Int32)
       cmp       ebp,eax
       jge       short M04_L02
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,ebp
       mov       edx,eax
       call      qword ptr [7FFD5A7C09C8]
       int       3
M04_L02:
       sub       ebp,eax
       js        near ptr M04_L11
       lea       ecx,[r14+rbp]
       cmp       ecx,[rsi+8]
       ja        near ptr M04_L11
       mov       rcx,[rbx]
       cmp       rcx,[rsi]
       je        short M04_L03
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFD5A7A9320]
       test      eax,eax
       je        short M04_L03
       cmp       byte ptr [rsp+78],0
       jne       near ptr M04_L16
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
M04_L03:
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
       jne       short M04_L04
       cmp       r8,14
       jne       near ptr M04_L15
       jmp       near ptr M04_L14
M04_L04:
       cmp       r8,4000
       ja        near ptr M04_L13
       jmp       near ptr M04_L12
M04_L05:
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M04_L06:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFD5A7AB268]
       int       3
M04_L07:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFD5A7AB268]
       int       3
M04_L08:
       call      qword ptr [7FFD5A7A2830]
       mov       rbx,rax
       call      qword ptr [7FFD5A7ADDB0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD5A7AC810]
       mov       rcx,rbx
       call      qword ptr [7FFD5A797FA8]; CORINFO_HELP_THROW
       int       3
M04_L09:
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       ecx,r14d
       call      qword ptr [7FFD5A7C09B0]
       int       3
M04_L10:
       call      qword ptr [7FFD5A7A25F8]
       mov       rbx,rax
       call      qword ptr [7FFD5A7ACC68]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,rbx
       call      qword ptr [7FFD5A7AB218]
       mov       rcx,rbx
       call      qword ptr [7FFD5A797FA8]; CORINFO_HELP_THROW
       int       3
M04_L11:
       call      qword ptr [7FFD5A7A25F8]
       mov       r14,rax
       call      qword ptr [7FFD5A7ACC60]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,r14
       call      qword ptr [7FFD5A7AB218]
       mov       rcx,r14
       call      qword ptr [7FFD5A797FA8]; CORINFO_HELP_THROW
       int       3
M04_L12:
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FFD5A7A96A0]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       je        near ptr M04_L05
       call      qword ptr [7FFD5A798028]; CORINFO_HELP_POLL_GC
       jmp       near ptr M04_L05
M04_L13:
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
M04_L14:
       movups    xmm0,[r10]
       movups    xmm1,[r10+4]
       movups    [rdx],xmm0
       movups    [rdx+4],xmm1
       jmp       near ptr M04_L05
M04_L15:
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FFD5A7AC980]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M04_L05
M04_L16:
       call      qword ptr [7FFD5A7A2620]
       mov       rbx,rax
       call      qword ptr [7FFD5A7AD730]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD5A7AB298]
       mov       rcx,rbx
       call      qword ptr [7FFD5A797FA8]; CORINFO_HELP_THROW
       int       3
; Total bytes of code 748
```
```assembly
; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       sub       rsp,38
       mov       eax,[rsp+60]
       test      rcx,rcx
       je        near ptr M05_L06
       test      r8,r8
       je        near ptr M05_L06
       mov       r10,[rcx]
       cmp       r10,[r8]
       jne       near ptr M05_L06
       cmp       dword ptr [r10+4],18
       jne       near ptr M05_L06
       mov       r11d,eax
       or        r11d,edx
       or        r11d,r9d
       jl        near ptr M05_L06
       lea       r11d,[rdx+rax]
       cmp       r11d,[rcx+8]
       ja        near ptr M05_L06
       lea       r11d,[r9+rax]
       cmp       r11d,[r8+8]
       ja        short M05_L06
       movzx     r11d,word ptr [r10]
       mov       eax,eax
       imul      rax,r11
       mov       edx,edx
       imul      rdx,r11
       lea       rdx,[rcx+rdx+10]
       mov       ecx,r9d
       imul      rcx,r11
       lea       rcx,[r8+rcx+10]
       test      dword ptr [r10],1000000
       je        short M05_L02
       cmp       rax,4000
       ja        short M05_L05
       mov       r8,rax
       call      00007FFD5C3C5D60
       cmp       dword ptr [7FFD5C72F778],0
       jne       short M05_L03
M05_L00:
       cmp       dword ptr [7FFD5C72F778],0
       jne       short M05_L04
M05_L01:
       add       rsp,38
       ret
M05_L02:
       mov       r8,rax
       call      qword ptr [7FFCFC7E5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M05_L00
M05_L03:
       call      CORINFO_HELP_POLL_GC
       jmp       short M05_L00
M05_L04:
       call      CORINFO_HELP_POLL_GC
       jmp       short M05_L01
M05_L05:
       mov       r8,rax
       add       rsp,38
       jmp       qword ptr [7FFCFCEBE388]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
M05_L06:
       mov       [rsp+20],eax
       xor       eax,eax
       mov       [rsp+28],eax
       call      qword ptr [7FFCFD0F79F0]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       short M05_L00
; Total bytes of code 225
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsAddRemoveCollectionBenchmark.AddFirst()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+38],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       rdi,[rbx+48]
       test      rdi,rdi
       je        near ptr M00_L06
       test      rsi,rsi
       je        near ptr M00_L07
       mov       ebp,[rsi+10]
       mov       rcx,[rsi+8]
       cmp       ebp,[rcx+8]
       je        short M00_L01
       test      ebp,ebp
       jg        near ptr M00_L11
M00_L00:
       mov       rcx,[rsi+8]
       mov       edx,[rcx+8]
       test      rdx,rdx
       je        near ptr M00_L12
       lea       rcx,[rcx+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rsi+10]
       inc       dword ptr [rsi+14]
       mov       [rsp+38],rsi
       mov       rbx,[rbx+60]
       mov       rdx,[rsp+38]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L01:
       mov       edx,ebp
       add       edx,1
       jo        near ptr M00_L13
       mov       rcx,[rsi+8]
       cmp       dword ptr [rcx+8],0
       jne       near ptr M00_L04
       mov       ecx,4
M00_L02:
       mov       eax,7FFFFFC7
       cmp       ecx,7FFFFFC7
       cmova     ecx,eax
       cmp       ecx,edx
       cmovl     ecx,edx
       movsxd    rdx,ecx
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       test      ebp,ebp
       je        near ptr M00_L03
       mov       rcx,[rsi+8]
       test      rcx,rcx
       je        near ptr M00_L10
       mov       rdx,[rcx]
       cmp       rdx,[r14]
       jne       near ptr M00_L10
       cmp       dword ptr [rdx+4],18
       jne       near ptr M00_L10
       test      ebp,ebp
       jl        near ptr M00_L10
       cmp       ebp,[rcx+8]
       ja        near ptr M00_L10
       lea       r8d,[rbp+1]
       cmp       r8d,[r14+8]
       ja        near ptr M00_L10
       movzx     r8d,word ptr [rdx]
       mov       eax,ebp
       imul      rax,r8
       add       rcx,10
       mov       r10,rcx
       lea       rcx,[r14+r8+10]
       test      dword ptr [rdx],1000000
       je        short M00_L05
       cmp       rax,4000
       ja        near ptr M00_L09
       mov       rdx,r10
       mov       r8,rax
       call      00007FFD5C3C5D60
       cmp       dword ptr [7FFD5C72F778],0
       jne       near ptr M00_L08
M00_L03:
       lea       rcx,[rsi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L04:
       mov       rcx,[rsi+8]
       mov       ecx,[rcx+8]
       add       ecx,ecx
       jmp       near ptr M00_L02
M00_L05:
       mov       rdx,r10
       mov       r8,rax
       call      qword ptr [7FFCFC7D5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M00_L03
M00_L06:
       call      qword ptr [7FFCFCEAE418]
       mov       ecx,0F
       mov       rdx,7FFCFCD06050
       call      qword ptr [7FFCFC7DF210]
       mov       rbx,rax
       mov       ecx,1B61
       mov       rdx,7FFCFCBD5618
       call      qword ptr [7FFCFC7DF210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCFC7DD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFCFCD06050
       call      qword ptr [7FFCFC7DF210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCFC7DD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCFCFF6910]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCFCFF6928]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       call      qword ptr [7FFCFCEAE418]
       mov       ecx,69E
       mov       rdx,7FFCFCD06050
       call      qword ptr [7FFCFC7DF210]
       mov       rbx,rax
       mov       ecx,1B61
       mov       rdx,7FFCFCBD5618
       call      qword ptr [7FFCFC7DF210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCFC7DD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFCFCD06050
       call      qword ptr [7FFCFC7DF210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCFC7DD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCFCFF6910]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCFCFF6928]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L08:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L03
M00_L09:
       mov       rdx,r10
       mov       r8,rax
       call      qword ptr [7FFCFCFF5890]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L03
M00_L10:
       mov       [rsp+20],ebp
       xor       r8d,r8d
       mov       [rsp+28],r8d
       mov       r8,r14
       xor       edx,edx
       mov       r9d,1
       call      qword ptr [7FFCFCFF65F8]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M00_L03
M00_L11:
       mov       [rsp+20],ebp
       mov       rcx,[rsi+8]
       mov       r8,[rsi+8]
       xor       edx,edx
       mov       r9d,1
       call      qword ptr [7FFCFCE2CF90]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       near ptr M00_L00
M00_L12:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L13:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 802
```
```assembly
; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M01_L10
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M01_L10
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       ja        short M01_L03
       test      r8b,18
       jne       short M01_L02
       test      r8b,4
       je        short M01_L01
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
M01_L00:
       vzeroupper
       ret
M01_L01:
       test      r8,r8
       je        short M01_L00
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M01_L00
       movsx     rcx,word ptr [rax-2]
       mov       [r10-2],cx
       jmp       short M01_L00
M01_L02:
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rcx,[rax-8]
       mov       [r10-8],rcx
       jmp       short M01_L00
M01_L03:
       cmp       r8,40
       ja        short M01_L07
M01_L04:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        short M01_L06
M01_L05:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
       jmp       short M01_L00
M01_L06:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M01_L05
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M01_L05
M01_L07:
       cmp       r8,800
       ja        short M01_L11
       cmp       r8,100
       jb        short M01_L08
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
M01_L08:
       mov       r9,r8
       shr       r9,6
M01_L09:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M01_L09
       and       r8,3F
       cmp       r8,10
       ja        near ptr M01_L04
       jmp       near ptr M01_L05
M01_L10:
       cmp       rcx,rdx
       jne       short M01_L11
       cmp       [rdx],dl
       jmp       near ptr M01_L00
M01_L11:
       cmp       [rcx],cl
       cmp       [rdx],dl
       vzeroupper
       jmp       qword ptr [7FFCFC7D66E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 319
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
       call      00007FFD5C418D20
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFCFC7D5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFCFC7D5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,2EDF8D10008
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
       call      qword ptr [7FFCFD12F4E0]
       int       3
; Total bytes of code 235
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
       je        short M03_L03
       mov       rcx,rbx
       sub       rcx,rsi
       cmp       rcx,rdi
       jb        short M03_L06
M03_L00:
       add       rdi,0FFFFFFFFFFFFC000
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,4000
       call      00007FFD5C3C5D60
       add       rbx,4000
       add       rsi,4000
       cmp       dword ptr [7FFD5C72F778],0
       jne       short M03_L04
M03_L01:
       cmp       rdi,4000
       ja        short M03_L00
M03_L02:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       call      00007FFD5C3C5D60
       cmp       dword ptr [7FFD5C72F778],0
       jne       short M03_L05
M03_L03:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M03_L04:
       call      CORINFO_HELP_POLL_GC
       jmp       short M03_L01
M03_L05:
       call      CORINFO_HELP_POLL_GC
       jmp       short M03_L03
M03_L06:
       add       rdi,0FFFFFFFFFFFFC000
       lea       rcx,[rbx+rdi]
       lea       rdx,[rsi+rdi]
       mov       r8d,4000
       call      00007FFD5C3C5D60
       cmp       dword ptr [7FFD5C72F778],0
       je        short M03_L07
       call      CORINFO_HELP_POLL_GC
M03_L07:
       cmp       rdi,4000
       ja        short M03_L06
       jmp       short M03_L02
; Total bytes of code 184
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
       je        near ptr M04_L07
       test      rsi,rsi
       je        near ptr M04_L06
       mov       rcx,[rbx]
       cmp       rcx,[rsi]
       je        short M04_L00
       mov       rcx,[rbx]
       mov       ecx,[rcx+4]
       add       ecx,0FFFFFFE8
       shr       ecx,3
       mov       edx,1
       test      ecx,ecx
       cmove     ecx,edx
       mov       rdx,[rsi]
       mov       edx,[rdx+4]
       add       edx,0FFFFFFE8
       shr       edx,3
       mov       eax,1
       test      edx,edx
       cmove     edx,eax
       cmp       ecx,edx
       jne       near ptr M04_L08
M04_L00:
       mov       r14d,[rsp+70]
       test      r14d,r14d
       jl        near ptr M04_L09
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFD5A7A9400]; Precode of System.Array.GetLowerBound(Int32)
       cmp       edi,eax
       jge       short M04_L01
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,edi
       mov       edx,eax
       call      qword ptr [7FFD5A7C09C8]
       int       3
M04_L01:
       sub       edi,eax
       js        near ptr M04_L10
       lea       ecx,[rdi+r14]
       cmp       ecx,[rbx+8]
       ja        near ptr M04_L10
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFD5A7A9400]; Precode of System.Array.GetLowerBound(Int32)
       cmp       ebp,eax
       jge       short M04_L02
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,ebp
       mov       edx,eax
       call      qword ptr [7FFD5A7C09C8]
       int       3
M04_L02:
       sub       ebp,eax
       js        near ptr M04_L11
       lea       ecx,[r14+rbp]
       cmp       ecx,[rsi+8]
       ja        near ptr M04_L11
       mov       rcx,[rbx]
       cmp       rcx,[rsi]
       je        short M04_L03
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFD5A7A9320]
       test      eax,eax
       je        short M04_L03
       cmp       byte ptr [rsp+78],0
       jne       near ptr M04_L16
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
M04_L03:
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
       jne       short M04_L04
       cmp       r8,14
       jne       near ptr M04_L15
       jmp       near ptr M04_L14
M04_L04:
       cmp       r8,4000
       ja        near ptr M04_L13
       jmp       near ptr M04_L12
M04_L05:
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M04_L06:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFD5A7AB268]
       int       3
M04_L07:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFD5A7AB268]
       int       3
M04_L08:
       call      qword ptr [7FFD5A7A2830]
       mov       rbx,rax
       call      qword ptr [7FFD5A7ADDB0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD5A7AC810]
       mov       rcx,rbx
       call      qword ptr [7FFD5A797FA8]; CORINFO_HELP_THROW
       int       3
M04_L09:
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       ecx,r14d
       call      qword ptr [7FFD5A7C09B0]
       int       3
M04_L10:
       call      qword ptr [7FFD5A7A25F8]
       mov       rbx,rax
       call      qword ptr [7FFD5A7ACC68]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,rbx
       call      qword ptr [7FFD5A7AB218]
       mov       rcx,rbx
       call      qword ptr [7FFD5A797FA8]; CORINFO_HELP_THROW
       int       3
M04_L11:
       call      qword ptr [7FFD5A7A25F8]
       mov       r14,rax
       call      qword ptr [7FFD5A7ACC60]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,r14
       call      qword ptr [7FFD5A7AB218]
       mov       rcx,r14
       call      qword ptr [7FFD5A797FA8]; CORINFO_HELP_THROW
       int       3
M04_L12:
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FFD5A7A96A0]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       je        near ptr M04_L05
       call      qword ptr [7FFD5A798028]; CORINFO_HELP_POLL_GC
       jmp       near ptr M04_L05
M04_L13:
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
M04_L14:
       movups    xmm0,[r10]
       movups    xmm1,[r10+4]
       movups    [rdx],xmm0
       movups    [rdx+4],xmm1
       jmp       near ptr M04_L05
M04_L15:
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FFD5A7AC980]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M04_L05
M04_L16:
       call      qword ptr [7FFD5A7A2620]
       mov       rbx,rax
       call      qword ptr [7FFD5A7AD730]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD5A7AB298]
       mov       rcx,rbx
       call      qword ptr [7FFD5A797FA8]; CORINFO_HELP_THROW
       int       3
; Total bytes of code 748
```
```assembly
; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       sub       rsp,38
       mov       eax,[rsp+60]
       test      rcx,rcx
       je        near ptr M05_L06
       test      r8,r8
       je        near ptr M05_L06
       mov       r10,[rcx]
       cmp       r10,[r8]
       jne       near ptr M05_L06
       cmp       dword ptr [r10+4],18
       jne       near ptr M05_L06
       mov       r11d,eax
       or        r11d,edx
       or        r11d,r9d
       jl        near ptr M05_L06
       lea       r11d,[rdx+rax]
       cmp       r11d,[rcx+8]
       ja        near ptr M05_L06
       lea       r11d,[r9+rax]
       cmp       r11d,[r8+8]
       ja        short M05_L06
       movzx     r11d,word ptr [r10]
       mov       eax,eax
       imul      rax,r11
       mov       edx,edx
       imul      rdx,r11
       lea       rdx,[rcx+rdx+10]
       mov       ecx,r9d
       imul      rcx,r11
       lea       rcx,[r8+rcx+10]
       test      dword ptr [r10],1000000
       je        short M05_L02
       cmp       rax,4000
       ja        short M05_L05
       mov       r8,rax
       call      00007FFD5C3C5D60
       cmp       dword ptr [7FFD5C72F778],0
       jne       short M05_L03
M05_L00:
       cmp       dword ptr [7FFD5C72F778],0
       jne       short M05_L04
M05_L01:
       add       rsp,38
       ret
M05_L02:
       mov       r8,rax
       call      qword ptr [7FFCFC7D5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M05_L00
M05_L03:
       call      CORINFO_HELP_POLL_GC
       jmp       short M05_L00
M05_L04:
       call      CORINFO_HELP_POLL_GC
       jmp       short M05_L01
M05_L05:
       mov       r8,rax
       add       rsp,38
       jmp       qword ptr [7FFCFCFF5890]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
M05_L06:
       mov       [rsp+20],eax
       xor       eax,eax
       mov       [rsp+28],eax
       call      qword ptr [7FFCFCFF65F8]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       short M05_L00
; Total bytes of code 225
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsAddRemoveCollectionBenchmark.AddLast()
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
       call      qword ptr [7FFCFD0FD1D0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
       mov       [rbp-10],rax
       mov       r8,[rbp-10]
       mov       rdx,[rbp-8]
       mov       rcx,7FFCFD177F38
       call      qword ptr [7FFCFD0FD170]; DotNetTips.Spargine.Extensions.ListExtensions.AddLast[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.__Canon)
       mov       rcx,[rbp+10]
       mov       r8,[rbp-8]
       mov       rdx,7FFCFD178050
       call      qword ptr [7FFCFD0FD1A0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 108
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
; DotNetTips.Spargine.Extensions.ListExtensions.AddLast[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.__Canon)
       push      rbp
       sub       rsp,60
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
; 			item = item.ArgumentNotNull();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       xor       eax,eax
       mov       [rbp-10],rax
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
       mov       rdx,7FFCFD180688
       call      qword ptr [7FFCFC7DF630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-18],rax
M02_L01:
       mov       rax,23F1B3EB890
       mov       [rsp+20],rax
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+20]
       mov       r8,[rbp-10]
       mov       r9,23F1B3E0008
       call      qword ptr [7FFCFCEAE898]
       mov       [rbp+20],rax
; 			list = list.ArgumentNotNull();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       mov       rdx,7FFCFD180A10
       call      qword ptr [7FFCFC7DF630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-20],rax
M02_L03:
       mov       rax,23F1B3F30C8
       mov       [rsp+20],rax
       mov       rcx,[rbp-20]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       mov       r9,23F1B3E0008
       call      qword ptr [7FFCFCEAE898]
       mov       [rbp+18],rax
; 			list.Add(item);
; 			^^^^^^^^^^^^^^^
       mov       rcx,[rbp+18]
       mov       rdx,[rbp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFCFC8F17D0]
       nop
       add       rsp,60
       pop       rbp
       ret
; Total bytes of code 268
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
       mov       rdx,7FFCFD180B70
       call      qword ptr [7FFCFC7DF630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M03_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFCFD0FD2A8]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFCFD0FD260]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 130
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsAddRemoveCollectionBenchmark.AddLast()
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
       call      qword ptr [7FFCFD0FCCA8]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
       mov       [rbp-10],rax
       mov       r8,[rbp-10]
       mov       rdx,[rbp-8]
       mov       rcx,7FFCFD171B28
       call      qword ptr [7FFCFD0FCC48]; DotNetTips.Spargine.Extensions.ListExtensions.AddLast[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.__Canon)
       mov       rcx,[rbp+10]
       mov       r8,[rbp-8]
       mov       rdx,7FFCFD171C40
       call      qword ptr [7FFCFD0FCC78]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 108
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
; DotNetTips.Spargine.Extensions.ListExtensions.AddLast[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.__Canon)
; 			item = item.ArgumentNotNull();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			list = list.ArgumentNotNull();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			list.Add(item);
; 			^^^^^^^^^^^^^^^
       push      rbp
       sub       rsp,60
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       xor       eax,eax
       mov       [rbp-10],rax
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
       mov       rdx,7FFCFD180688
       call      qword ptr [7FFCFC7EF630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-18],rax
M02_L01:
       mov       rax,285A9E6B890
       mov       [rsp+20],rax
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+20]
       mov       r8,[rbp-10]
       mov       r9,285A9E60008
       call      qword ptr [7FFCFCEBE3B8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp+20],rax
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
       mov       rdx,7FFCFD180A10
       call      qword ptr [7FFCFC7EF630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-20],rax
M02_L03:
       mov       rax,285A9E730C8
       mov       [rsp+20],rax
       mov       rcx,[rbp-20]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       mov       r9,285A9E60008
       call      qword ptr [7FFCFCEBE3B8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp+18],rax
       mov       rcx,[rbp+18]
       mov       rdx,[rbp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFCFC9017D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       nop
       add       rsp,60
       pop       rbp
       ret
; Total bytes of code 268
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
       mov       rdx,7FFCFD180B70
       call      qword ptr [7FFCFC7EF630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M03_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFCFD0FCD80]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFCFD0FCD38]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 130
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsAddRemoveCollectionBenchmark.AddLast()
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
       call      qword ptr [7FFCFD10D1D0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_PersonRef01()
       mov       [rbp-10],rax
       mov       r8,[rbp-10]
       mov       rdx,[rbp-8]
       mov       rcx,7FFCFD187F48
       call      qword ptr [7FFCFD10D170]; DotNetTips.Spargine.Extensions.ListExtensions.AddLast[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.__Canon)
       mov       rcx,[rbp+10]
       mov       r8,[rbp-8]
       mov       rdx,7FFCFD188060
       call      qword ptr [7FFCFD10D1A0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 108
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
; DotNetTips.Spargine.Extensions.ListExtensions.AddLast[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.__Canon)
; 			item = item.ArgumentNotNull();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			list = list.ArgumentNotNull();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			list.Add(item);
; 			^^^^^^^^^^^^^^^
       push      rbp
       sub       rsp,60
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       xor       eax,eax
       mov       [rbp-10],rax
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
       mov       rdx,7FFCFD190688
       call      qword ptr [7FFCFC7EF630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-18],rax
M02_L01:
       mov       rax,148A982B890
       mov       [rsp+20],rax
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+20]
       mov       r8,[rbp-10]
       mov       r9,148A9820008
       call      qword ptr [7FFCFCEBE8E0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp+20],rax
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
       mov       rdx,7FFCFD190A10
       call      qword ptr [7FFCFC7EF630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-20],rax
M02_L03:
       mov       rax,148A98330C8
       mov       [rsp+20],rax
       mov       rcx,[rbp-20]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       mov       r9,148A9820008
       call      qword ptr [7FFCFCEBE8E0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp+18],rax
       mov       rcx,[rbp+18]
       mov       rdx,[rbp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFCFC9017D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       nop
       add       rsp,60
       pop       rbp
       ret
; Total bytes of code 268
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
       mov       rdx,7FFCFD190B70
       call      qword ptr [7FFCFC7EF630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M03_L01:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFCFD10D2A8]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       lea       r8,[rbp+20]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFCFD10D260]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 130
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsAddRemoveCollectionBenchmark.AddLast()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       rdx,[rbx+48]
       test      rdx,rdx
       je        short M00_L02
       test      rsi,rsi
       je        near ptr M00_L03
       inc       dword ptr [rsi+14]
       mov       rcx,[rsi+8]
       mov       eax,[rsi+10]
       mov       r8d,[rcx+8]
       cmp       r8d,eax
       jbe       short M00_L01
       lea       r8d,[rax+1]
       mov       [rsi+10],r8d
       mov       eax,eax
       lea       rcx,[rcx+rax*8+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L00:
       mov       [rsp+20],rsi
       mov       rbx,[rbx+60]
       mov       rdx,[rsp+20]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L01:
       mov       rcx,rsi
       call      qword ptr [7FFCFC98E370]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M00_L00
M00_L02:
       call      qword ptr [7FFCFCEBEA48]
       mov       ecx,0F
       mov       rdx,7FFCFCD16050
       call      qword ptr [7FFCFCA67738]
       mov       rbx,rax
       mov       ecx,1B61
       mov       rdx,7FFCFCBE5D90
       call      qword ptr [7FFCFCA67738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCFC7E7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFCFCD16050
       call      qword ptr [7FFCFCA67738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCFC7E7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCFD104720]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCFD104738]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L03:
       call      qword ptr [7FFCFCEBEA48]
       mov       ecx,69E
       mov       rdx,7FFCFCD16050
       call      qword ptr [7FFCFCA67738]
       mov       rbx,rax
       mov       ecx,1B61
       mov       rdx,7FFCFCBE5D90
       call      qword ptr [7FFCFCA67738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCFC7E7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFCFCD16050
       call      qword ptr [7FFCFCA67738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCFC7E7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCFD104720]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCFD104738]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 427
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,[rbx+10]
       mov       ebp,edi
       lea       ecx,[rbp+1]
       mov       rdx,[rbx+8]
       cmp       dword ptr [rdx+8],0
       jne       short M01_L01
       mov       r14d,4
M01_L00:
       mov       edx,7FFFFFC7
       cmp       r14d,7FFFFFC7
       cmova     r14d,edx
       cmp       r14d,ecx
       cmovl     r14d,ecx
       cmp       r14d,edi
       jge       short M01_L02
       mov       ecx,7
       mov       edx,0F
       call      qword ptr [7FFCFCEB6028]
       int       3
M01_L01:
       mov       rdx,[rbx+8]
       mov       r14d,[rdx+8]
       add       r14d,r14d
       jmp       short M01_L00
M01_L02:
       mov       rcx,[rbx+8]
       cmp       [rcx+8],r14d
       je        near ptr M01_L08
       test      r14d,r14d
       jg        short M01_L05
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+0B8]
       test      rdx,rdx
       je        short M01_L04
M01_L03:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M01_L08
M01_L04:
       mov       rdx,7FFCFD222900
       call      qword ptr [7FFCFC7EC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       short M01_L03
M01_L05:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+0B0]
       test      rax,rax
       je        short M01_L09
       mov       rcx,rax
M01_L06:
       mov       edx,r14d
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       test      edi,edi
       jle       short M01_L07
       mov       rcx,[rbx+8]
       mov       r8d,edi
       mov       rdx,r14
       call      qword ptr [7FFCFC984FD8]; System.Array.Copy(System.Array, System.Array, Int32)
M01_L07:
       lea       rcx,[rbx+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
M01_L08:
       lea       ecx,[rbp+1]
       mov       [rbx+10],ecx
       mov       rcx,[rbx+8]
       movsxd    rdx,ebp
       mov       r8,rsi
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L09:
       mov       rdx,7FFCFD197998
       call      qword ptr [7FFCFC7EC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M01_L06
; Total bytes of code 309
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
       call      00007FFD5C418D20
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFCFC7E5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFCFC7E5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,258377A0008
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
       call      qword ptr [7FFCFD1C7B58]
       int       3
; Total bytes of code 235
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsAddRemoveCollectionBenchmark.AddLast()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       rdx,[rbx+48]
       test      rdx,rdx
       je        short M00_L02
       test      rsi,rsi
       je        near ptr M00_L03
       inc       dword ptr [rsi+14]
       mov       rcx,[rsi+8]
       mov       eax,[rsi+10]
       mov       r8d,[rcx+8]
       cmp       r8d,eax
       jbe       short M00_L01
       lea       r8d,[rax+1]
       mov       [rsi+10],r8d
       mov       eax,eax
       lea       rcx,[rcx+rax*8+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L00:
       mov       [rsp+20],rsi
       mov       rbx,[rbx+60]
       mov       rdx,[rsp+20]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L01:
       mov       rcx,rsi
       call      qword ptr [7FFCFC7E71C8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M00_L00
M00_L02:
       call      qword ptr [7FFCFCEBE430]
       mov       ecx,0F
       mov       rdx,7FFCFCD16050
       call      qword ptr [7FFCFC7EF210]
       mov       rbx,rax
       mov       ecx,1B61
       mov       rdx,7FFCFCBE5770
       call      qword ptr [7FFCFC7EF210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCFC7ED9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFCFCD16050
       call      qword ptr [7FFCFC7EF210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCFC7ED9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCFD074198]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCFD0741B0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L03:
       call      qword ptr [7FFCFCEBE430]
       mov       ecx,69E
       mov       rdx,7FFCFCD16050
       call      qword ptr [7FFCFC7EF210]
       mov       rbx,rax
       mov       ecx,1B61
       mov       rdx,7FFCFCBE5770
       call      qword ptr [7FFCFC7EF210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCFC7ED9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFCFCD16050
       call      qword ptr [7FFCFC7EF210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCFC7ED9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCFD074198]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCFD0741B0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 427
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,40
       mov       [rsp+38],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,[rbx+10]
       mov       ebp,edi
       lea       ecx,[rbp+1]
       mov       r14,[rbx+8]
       cmp       dword ptr [r14+8],0
       jne       near ptr M01_L04
       mov       r15d,4
M01_L00:
       mov       edx,7FFFFFC7
       cmp       r15d,7FFFFFC7
       cmova     r15d,edx
       cmp       r15d,ecx
       cmovl     r15d,ecx
       cmp       r15d,edi
       jl        near ptr M01_L06
       cmp       [r14+8],r15d
       je        near ptr M01_L03
       test      r15d,r15d
       jle       near ptr M01_L13
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+0B0]
       test      rax,rax
       je        near ptr M01_L05
       mov       rcx,rax
M01_L01:
       mov       edx,r15d
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r15,rax
       test      edi,edi
       jle       short M01_L02
       test      r14,r14
       je        near ptr M01_L10
       mov       rcx,[r14]
       cmp       rcx,[r15]
       jne       near ptr M01_L11
       cmp       dword ptr [rcx+4],18
       jne       near ptr M01_L11
       cmp       edi,[r14+8]
       ja        near ptr M01_L11
       cmp       edi,[r15+8]
       ja        near ptr M01_L11
       mov       r8d,edi
       movzx     edx,word ptr [rcx]
       imul      r8,rdx
       lea       rdx,[r14+10]
       lea       rax,[r15+10]
       test      dword ptr [rcx],1000000
       je        near ptr M01_L09
       cmp       r8,4000
       ja        near ptr M01_L08
       mov       rcx,rax
       call      00007FFD5C3C5D60
       cmp       dword ptr [7FFD5C72F778],0
       jne       short M01_L07
M01_L02:
       lea       rcx,[rbx+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
M01_L03:
       lea       ecx,[rbp+1]
       mov       [rbx+10],ecx
       mov       rcx,[rbx+8]
       movsxd    rdx,ebp
       mov       r8,rsi
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       nop
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L04:
       mov       r15d,[r14+8]
       add       r15d,r15d
       jmp       near ptr M01_L00
M01_L05:
       mov       rdx,7FFCFD1E1B20
       call      qword ptr [7FFCFC7EF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L01
M01_L06:
       mov       ecx,7
       mov       edx,0F
       call      qword ptr [7FFCFCEB6058]
       int       3
M01_L07:
       call      CORINFO_HELP_POLL_GC
       jmp       short M01_L02
M01_L08:
       mov       rcx,rax
       call      qword ptr [7FFCFCEBE388]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L02
M01_L09:
       mov       rcx,rax
       call      qword ptr [7FFCFC7E5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L02
M01_L10:
       xor       r13d,r13d
       jmp       short M01_L12
M01_L11:
       mov       rcx,r14
       xor       edx,edx
       call      qword ptr [7FFCFD1B71E0]; System.Array.GetLowerBound(Int32)
       mov       r13d,eax
M01_L12:
       mov       rcx,r15
       xor       edx,edx
       call      qword ptr [7FFCFD1B71E0]; System.Array.GetLowerBound(Int32)
       mov       r9d,eax
       mov       [rsp+20],edi
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,r14
       mov       edx,r13d
       mov       r8,r15
       call      qword ptr [7FFCFD1B4BE8]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M01_L02
M01_L13:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+0B8]
       test      rdx,rdx
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rdx,7FFCFD2176C8
       call      qword ptr [7FFCFC7EF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M01_L15:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L03
; Total bytes of code 525
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
       call      00007FFD5C418D20
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFCFC7E5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFCFC7E5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,22E7AAD0008
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
       call      qword ptr [7FFCFD1B7D38]
       int       3
; Total bytes of code 235
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsAddRemoveCollectionBenchmark.AddLast()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       rdx,[rbx+48]
       test      rdx,rdx
       je        short M00_L01
       test      rsi,rsi
       je        near ptr M00_L02
       inc       dword ptr [rsi+14]
       mov       rcx,[rsi+8]
       mov       eax,[rsi+10]
       mov       r8d,[rcx+8]
       cmp       r8d,eax
       jbe       near ptr M00_L03
       lea       r8d,[rax+1]
       mov       [rsi+10],r8d
       mov       eax,eax
       lea       rcx,[rcx+rax*8+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L00:
       mov       [rsp+20],rsi
       mov       rbx,[rbx+60]
       mov       rdx,[rsp+20]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L01:
       call      qword ptr [7FFCFCE9E3E8]
       mov       ecx,0F
       mov       rdx,7FFCFCCF6050
       call      qword ptr [7FFCFC7CF210]
       mov       rbx,rax
       mov       ecx,1B61
       mov       rdx,7FFCFCBC5770
       call      qword ptr [7FFCFC7CF210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCFC7CD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFCFCCF6050
       call      qword ptr [7FFCFC7CF210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCFC7CD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCFD0542B8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCFD0542D0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L02:
       call      qword ptr [7FFCFCE9E3E8]
       mov       ecx,69E
       mov       rdx,7FFCFCCF6050
       call      qword ptr [7FFCFC7CF210]
       mov       rbx,rax
       mov       ecx,1B61
       mov       rdx,7FFCFCBC5770
       call      qword ptr [7FFCFC7CF210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCFC7CD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFCFCCF6050
       call      qword ptr [7FFCFC7CF210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCFC7CD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCFD0542B8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCFD0542D0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L03:
       mov       rcx,rsi
       call      qword ptr [7FFCFC7C71C8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M00_L00
; Total bytes of code 434
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
       call      00007FFD5C418D20
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFCFC7C5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFCFC7C5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,24700E50008
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
       call      qword ptr [7FFCFD1A7C90]
       int       3
; Total bytes of code 235
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,[rbx+10]
       mov       ebp,edi
       lea       ecx,[rbp+1]
       mov       rdx,[rbx+8]
       cmp       dword ptr [rdx+8],0
       jne       short M02_L01
       mov       r14d,4
M02_L00:
       mov       edx,7FFFFFC7
       cmp       r14d,7FFFFFC7
       cmova     r14d,edx
       cmp       r14d,ecx
       cmovl     r14d,ecx
       cmp       r14d,edi
       jge       short M02_L02
       mov       ecx,7
       mov       edx,0F
       call      qword ptr [7FFCFCE96058]
       int       3
M02_L01:
       mov       rdx,[rbx+8]
       mov       r14d,[rdx+8]
       add       r14d,r14d
       jmp       short M02_L00
M02_L02:
       mov       rcx,[rbx+8]
       cmp       [rcx+8],r14d
       je        near ptr M02_L08
       test      r14d,r14d
       jg        short M02_L05
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+0B8]
       test      rdx,rdx
       je        short M02_L04
M02_L03:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M02_L08
M02_L04:
       mov       rdx,7FFCFD1F7068
       call      qword ptr [7FFCFC7CF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       short M02_L03
M02_L05:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+0B0]
       test      rax,rax
       je        short M02_L09
       mov       rcx,rax
M02_L06:
       mov       edx,r14d
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       test      edi,edi
       jle       short M02_L07
       mov       rcx,[rbx+8]
       mov       r8d,edi
       mov       rdx,r14
       call      qword ptr [7FFCFC7CF588]; System.Array.Copy(System.Array, System.Array, Int32)
M02_L07:
       lea       rcx,[rbx+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
M02_L08:
       lea       ecx,[rbp+1]
       mov       [rbx+10],ecx
       mov       rcx,[rbx+8]
       movsxd    rdx,ebp
       mov       r8,rsi
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L09:
       mov       rdx,7FFCFD16D930
       call      qword ptr [7FFCFC7CF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M02_L06
; Total bytes of code 309
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsAddRemoveCollectionBenchmark.AddLast()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       rdx,[rbx+48]
       test      rdx,rdx
       je        short M00_L01
       test      rsi,rsi
       je        near ptr M00_L02
       inc       dword ptr [rsi+14]
       mov       rcx,[rsi+8]
       mov       eax,[rsi+10]
       mov       r8d,[rcx+8]
       cmp       r8d,eax
       jbe       near ptr M00_L03
       lea       r8d,[rax+1]
       mov       [rsi+10],r8d
       mov       eax,eax
       lea       rcx,[rcx+rax*8+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L00:
       mov       [rsp+20],rsi
       mov       rbx,[rbx+60]
       mov       rdx,[rsp+20]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L01:
       call      qword ptr [7FFCFCEBE958]
       mov       ecx,0F
       mov       rdx,7FFCFCD16050
       call      qword ptr [7FFCFC7EF210]
       mov       rbx,rax
       mov       ecx,1B61
       mov       rdx,7FFCFCBE5C10
       call      qword ptr [7FFCFC7EF210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCFC7ED9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFCFCD16050
       call      qword ptr [7FFCFC7EF210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCFC7ED9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCFD0F53E0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCFD0F53F8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L02:
       call      qword ptr [7FFCFCEBE958]
       mov       ecx,69E
       mov       rdx,7FFCFCD16050
       call      qword ptr [7FFCFC7EF210]
       mov       rbx,rax
       mov       ecx,1B61
       mov       rdx,7FFCFCBE5C10
       call      qword ptr [7FFCFC7EF210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCFC7ED9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFCFCD16050
       call      qword ptr [7FFCFC7EF210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCFC7ED9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCFD0F53E0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCFD0F53F8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L03:
       mov       rcx,rsi
       call      qword ptr [7FFCFC7E71C8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M00_L00
; Total bytes of code 434
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
       call      00007FFD5C418D20
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFCFC7E5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFCFC7E5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1BC458D0008
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
       call      qword ptr [7FFCFD1FC330]
       int       3
; Total bytes of code 235
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,40
       mov       [rsp+38],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,[rbx+10]
       mov       ebp,edi
       lea       ecx,[rbp+1]
       mov       r14,[rbx+8]
       cmp       dword ptr [r14+8],0
       jne       near ptr M02_L04
       mov       r15d,4
M02_L00:
       mov       edx,7FFFFFC7
       cmp       r15d,7FFFFFC7
       cmova     r15d,edx
       cmp       r15d,ecx
       cmovl     r15d,ecx
       cmp       r15d,edi
       jl        near ptr M02_L07
       cmp       [r14+8],r15d
       je        near ptr M02_L03
       test      r15d,r15d
       jle       near ptr M02_L13
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+98]
       test      rax,rax
       je        near ptr M02_L05
       mov       rcx,rax
M02_L01:
       mov       edx,r15d
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r15,rax
       test      edi,edi
       jle       short M02_L02
       test      r14,r14
       je        near ptr M02_L10
       mov       rcx,[r14]
       cmp       rcx,[r15]
       jne       near ptr M02_L11
       cmp       dword ptr [rcx+4],18
       jne       near ptr M02_L11
       cmp       edi,[r14+8]
       ja        near ptr M02_L11
       cmp       edi,[r15+8]
       ja        near ptr M02_L11
       mov       r8d,edi
       movzx     edx,word ptr [rcx]
       imul      r8,rdx
       lea       rdx,[r14+10]
       lea       rax,[r15+10]
       test      dword ptr [rcx],1000000
       je        short M02_L06
       cmp       r8,4000
       ja        near ptr M02_L09
       mov       rcx,rax
       call      00007FFD5C3C5D60
       cmp       dword ptr [7FFD5C72F778],0
       jne       short M02_L08
M02_L02:
       lea       rcx,[rbx+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
M02_L03:
       lea       ecx,[rbp+1]
       mov       [rbx+10],ecx
       mov       rcx,[rbx+8]
       movsxd    rdx,ebp
       mov       r8,rsi
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       nop
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M02_L04:
       mov       r15d,[r14+8]
       add       r15d,r15d
       jmp       near ptr M02_L00
M02_L05:
       mov       rdx,7FFCFD10ED10
       call      qword ptr [7FFCFC7EF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M02_L01
M02_L06:
       mov       rcx,rax
       call      qword ptr [7FFCFC7E5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M02_L02
M02_L07:
       mov       ecx,7
       mov       edx,0F
       call      qword ptr [7FFCFCEB6058]
       int       3
M02_L08:
       call      CORINFO_HELP_POLL_GC
       jmp       short M02_L02
M02_L09:
       mov       rcx,rax
       call      qword ptr [7FFCFCEBE820]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M02_L02
M02_L10:
       xor       r13d,r13d
       jmp       short M02_L12
M02_L11:
       mov       rcx,r14
       xor       edx,edx
       call      qword ptr [7FFCFD1F7750]; System.Array.GetLowerBound(Int32)
       mov       r13d,eax
M02_L12:
       mov       rcx,r15
       xor       edx,edx
       call      qword ptr [7FFCFD1F7750]; System.Array.GetLowerBound(Int32)
       mov       r9d,eax
       mov       [rsp+20],edi
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,r14
       mov       edx,r13d
       mov       r8,r15
       call      qword ptr [7FFCFD0F7768]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M02_L02
M02_L13:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+0A0]
       test      rdx,rdx
       je        short M02_L14
       jmp       short M02_L15
M02_L14:
       mov       rdx,7FFCFD175710
       call      qword ptr [7FFCFC7EF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M02_L15:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L03
; Total bytes of code 521
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsAddRemoveCollectionBenchmark.AddLast()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       rdx,[rbx+48]
       test      rdx,rdx
       je        short M00_L02
       test      rsi,rsi
       je        near ptr M00_L03
       inc       dword ptr [rsi+14]
       mov       rcx,[rsi+8]
       mov       eax,[rsi+10]
       mov       r8d,[rcx+8]
       cmp       r8d,eax
       jbe       short M00_L01
       lea       r8d,[rax+1]
       mov       [rsi+10],r8d
       mov       eax,eax
       lea       rcx,[rcx+rax*8+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L00:
       mov       [rsp+20],rsi
       mov       rbx,[rbx+60]
       mov       rdx,[rsp+20]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L01:
       mov       rcx,rsi
       call      qword ptr [7FFCFC7F71C8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M00_L00
M00_L02:
       call      qword ptr [7FFCFCECE958]
       mov       ecx,0F
       mov       rdx,7FFCFCD26050
       call      qword ptr [7FFCFC7FF210]
       mov       rbx,rax
       mov       ecx,1B61
       mov       rdx,7FFCFCBF5770
       call      qword ptr [7FFCFC7FF210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCFC7FD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFCFCD26050
       call      qword ptr [7FFCFC7FF210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCFC7FD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCFD134948]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCFD134960]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L03:
       call      qword ptr [7FFCFCECE958]
       mov       ecx,69E
       mov       rdx,7FFCFCD26050
       call      qword ptr [7FFCFC7FF210]
       mov       rbx,rax
       mov       ecx,1B61
       mov       rdx,7FFCFCBF5770
       call      qword ptr [7FFCFC7FF210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCFC7FD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFCFCD26050
       call      qword ptr [7FFCFC7FF210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCFC7FD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCFD134948]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCFD134960]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 427
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
       jne       near ptr M01_L04
       mov       r15d,4
M01_L00:
       mov       edx,7FFFFFC7
       cmp       r15d,7FFFFFC7
       cmova     r15d,edx
       cmp       r15d,ecx
       cmovl     r15d,ecx
       cmp       r15d,edi
       jl        near ptr M01_L06
       cmp       [r14+8],r15d
       je        short M01_L03
       test      r15d,r15d
       jle       near ptr M01_L08
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+78]
       test      rax,rax
       je        short M01_L05
       mov       rcx,rax
M01_L01:
       mov       edx,r15d
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r15,rax
       test      edi,edi
       jg        short M01_L07
M01_L02:
       lea       rcx,[rbx+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
M01_L03:
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
M01_L04:
       mov       r15d,[r14+8]
       add       r15d,r15d
       jmp       near ptr M01_L00
M01_L05:
       mov       rdx,7FFCFD0072F8
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M01_L01
M01_L06:
       mov       ecx,7
       mov       edx,0F
       call      qword ptr [7FFCFCEC6058]
       int       3
M01_L07:
       mov       rcx,r14
       mov       r8d,edi
       mov       rdx,r15
       call      qword ptr [7FFCFC7FF588]; System.Array.Copy(System.Array, System.Array, Int32)
       jmp       short M01_L02
M01_L08:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+80]
       test      rdx,rdx
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rdx,7FFCFD05D0A8
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M01_L10:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L03
; Total bytes of code 316
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
       call      00007FFD5C418D20
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFCFC7F5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFCFC7F5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1FAB0AE0008
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
       call      qword ptr [7FFCFD13F540]
       int       3
; Total bytes of code 235
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; BenchmarkDotNet.Autogenerated.Runnable_1000.__ForDisassemblyDiagnoser__()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
;             if (NotEleven == 11)
;             ^^^^^^^^^^^^^^^^^^^^
       mov       rax,[rbp+10]
       cmp       dword ptr [rax+2C0],0B
       jne       short M00_L00
;                 AddRangeIfNotExists();
;                 ^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,[rbp+10]
       call      qword ptr [7FFCFCBBD890]
M00_L00:
       nop
       add       rsp,20
       pop       rbp
       ret
; Total bytes of code 44
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsAddRemoveCollectionBenchmark.AddRangeIfNotExists()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,68
       lea       rbp,[rsp+0A0]
       xor       eax,eax
       mov       [rbp-50],rax
       mov       [rbp-58],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       rdi,[rbx+280]
       test      rsi,rsi
       je        near ptr M00_L36
       mov       r14,rsi
       test      rdi,rdi
       je        near ptr M00_L37
       mov       rcx,offset MT_System.Collections.Generic.HashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,2A1E7400AC0
       mov       rdx,[rcx]
       lea       rcx,[r15+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,r14
       mov       rcx,offset MT_System.Collections.Generic.HashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r13,rax
       test      r13,r13
       je        short M00_L00
       mov       rcx,[r15+18]
       mov       rdx,[r13+18]
       mov       rax,2A1E7400AC0
       test      rdx,rdx
       cmove     rdx,[rax]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       test      eax,eax
       jne       near ptr M00_L31
M00_L00:
       mov       rcx,r14
       mov       r11,7FFCFC731C78
       call      qword ptr [r11]
       test      eax,eax
       jle       short M00_L01
       mov       rcx,r15
       mov       edx,eax
       call      qword ptr [7FFCFCAB71B0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
M00_L01:
       mov       rcx,r14
       mov       r11,7FFCFC731C80
       call      qword ptr [r11]
       mov       [rbp-68],rax
M00_L02:
       mov       rax,[rbp-68]
       mov       rcx,rax
       mov       r11,7FFCFC731C88
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M00_L30
       mov       rcx,[rbp-68]
       mov       r11,7FFCFC731C90
       call      qword ptr [r11]
       mov       r13,rax
       cmp       qword ptr [r15+8],0
       je        near ptr M00_L14
M00_L03:
       mov       r14,[r15+10]
       mov       r12,[r15+18]
       xor       eax,eax
       mov       [rbp-3C],eax
       test      r13,r13
       je        near ptr M00_L15
       mov       rcx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r12],rcx
       jne       near ptr M00_L23
       mov       rdx,[r13+28]
       test      rdx,rdx
       je        near ptr M00_L16
       mov       rcx,2A1D1400068
       mov       rcx,[rcx]
       mov       r8,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],r8
       jne       near ptr M00_L22
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       r8d,808B52E1
       mov       r10d,0C4459885
       cmp       edx,8
       jb        near ptr M00_L17
       mov       r9d,edx
       shr       r9d,3
       nop
M00_L04:
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
       mov       eax,r8d
       mov       r8d,r10d
       mov       r10d,eax
       jne       short M00_L04
       test      dl,4
       jne       near ptr M00_L18
M00_L05:
       mov       r9d,edx
       and       r9,7
       mov       ecx,[rcx+r9-4]
       shr       ecx,8
       or        ecx,80000000
       not       edx
       shl       edx,3
       shrx      ecx,ecx,edx
M00_L06:
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
M00_L07:
       mov       r10d,r8d
M00_L08:
       mov       [rbp-40],r10d
       mov       rdx,[r15+8]
       mov       ecx,r10d
       imul      rcx,[r15+20]
       shr       rcx,20
       inc       rcx
       mov       r8d,[rdx+8]
       imul      rcx,r8
       shr       rcx,20
       cmp       ecx,[rdx+8]
       jae       near ptr M00_L29
       mov       ecx,ecx
       lea       r9,[rdx+rcx*4+10]
       mov       [rbp-78],r9
       mov       r11d,[r9]
       dec       r11d
       jns       near ptr M00_L12
M00_L09:
       cmp       dword ptr [r15+30],0
       jg        near ptr M00_L25
       mov       edx,[r15+28]
       mov       [rbp-44],edx
       cmp       [r14+8],edx
       je        near ptr M00_L26
M00_L10:
       mov       edx,[rbp-44]
       mov       r14d,edx
       lea       ecx,[r14+1]
       mov       [r15+28],ecx
       mov       rcx,[r15+10]
       mov       r8,rcx
M00_L11:
       cmp       r14d,[r8+8]
       jae       near ptr M00_L29
       mov       ecx,r14d
       shl       rcx,4
       mov       [rbp-70],r8
       lea       rcx,[r8+rcx+10]
       mov       [rcx+8],r10d
       mov       r9,[rbp-78]
       mov       edx,[r9]
       dec       edx
       mov       [rcx+0C],edx
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       inc       r14d
       mov       rdx,[rbp-78]
       mov       [rdx],r14d
       inc       dword ptr [r15+34]
       cmp       dword ptr [rbp-3C],64
       jbe       near ptr M00_L02
       jmp       near ptr M00_L27
M00_L12:
       cmp       r11d,[r14+8]
       jae       near ptr M00_L29
       mov       edx,r11d
       shl       rdx,4
       lea       r11,[r14+rdx+10]
       mov       [rbp-80],r11
       cmp       [r11+8],r10d
       je        near ptr M00_L24
M00_L13:
       mov       r11d,[r11+0C]
       mov       eax,[rbp-3C]
       inc       eax
       mov       [rbp-3C],eax
       cmp       [r14+8],eax
       jb        near ptr M00_L28
       test      r11d,r11d
       mov       r10d,[rbp-40]
       jge       short M00_L12
       jmp       near ptr M00_L09
M00_L14:
       mov       rcx,r15
       xor       edx,edx
       call      qword ptr [7FFCFCAB71B0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       jmp       near ptr M00_L03
M00_L15:
       xor       r10d,r10d
       jmp       near ptr M00_L08
M00_L16:
       xor       r8d,r8d
       jmp       near ptr M00_L07
M00_L17:
       cmp       edx,4
       jb        short M00_L19
M00_L18:
       add       r8d,[rcx]
       xor       r10d,r8d
       rol       r8d,14
       add       r8d,r10d
       rol       r10d,9
       xor       r10d,r8d
       rol       r8d,1B
       add       r8d,r10d
       rol       r10d,13
       jmp       near ptr M00_L05
M00_L19:
       mov       r9d,80
       test      dl,1
       je        short M00_L20
       mov       r9d,edx
       and       r9,2
       movzx     r9d,byte ptr [rcx+r9]
       or        r9d,8000
M00_L20:
       test      dl,2
       je        short M00_L21
       shl       r9d,10
       movzx     ecx,word ptr [rcx]
       or        r9d,ecx
       mov       ecx,r9d
       jmp       near ptr M00_L06
M00_L21:
       mov       ecx,r9d
       jmp       near ptr M00_L06
M00_L22:
       mov       r8,[rcx]
       mov       r8,[r8+48]
       call      qword ptr [r8+18]
       mov       r8d,eax
       jmp       near ptr M00_L07
M00_L23:
       mov       rcx,r12
       mov       rdx,r13
       mov       r11,7FFCFC731CA0
       call      qword ptr [r11]
       mov       r8d,eax
       jmp       near ptr M00_L07
M00_L24:
       mov       rdx,[r11]
       mov       rcx,r12
       mov       r8,r13
       mov       r11,7FFCFC731CA8
       call      qword ptr [r11]
       test      eax,eax
       mov       r11,[rbp-80]
       jne       near ptr M00_L02
       jmp       near ptr M00_L13
M00_L25:
       mov       ecx,[r15+2C]
       mov       r8d,ecx
       dec       dword ptr [r15+30]
       cmp       ecx,[r14+8]
       jae       near ptr M00_L29
       shl       rcx,4
       mov       ecx,[r14+rcx+1C]
       neg       ecx
       add       ecx,0FFFFFFFD
       mov       [r15+2C],ecx
       mov       eax,r8d
       mov       r8,r14
       mov       r14d,eax
       jmp       near ptr M00_L11
M00_L26:
       mov       rcx,r15
       call      qword ptr [7FFCFD1CF090]
       mov       rcx,[r15+8]
       mov       r14d,[rbp-40]
       mov       edx,r14d
       imul      rdx,[r15+20]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       imul      rdx,rax
       shr       rdx,20
       cmp       edx,[rcx+8]
       jae       short M00_L29
       mov       edx,edx
       lea       r9,[rcx+rdx*4+10]
       mov       rax,r9
       mov       [rbp-78],rax
       mov       r10d,r14d
       jmp       near ptr M00_L10
M00_L27:
       mov       r14,[rbp-70]
       mov       rdx,r12
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M00_L02
       mov       edx,[r14+8]
       mov       rcx,r15
       mov       r8d,1
       call      qword ptr [7FFCFCC9D638]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,r15
       mov       rdx,r13
       call      qword ptr [7FFCFCAB7270]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       jmp       near ptr M00_L02
M00_L28:
       call      qword ptr [7FFCFC7EF480]
       int       3
M00_L29:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L30:
       mov       rcx,[rbp-68]
       mov       r11,7FFCFC731C98
       call      qword ptr [r11]
       cmp       dword ptr [r15+28],0
       jle       short M00_L32
       mov       rax,[r15+10]
       mov       eax,[rax+8]
       cdq
       idiv      dword ptr [r15+28]
       cmp       eax,3
       jle       short M00_L32
       mov       edx,[r15+28]
       sub       edx,[r15+30]
       mov       rcx,r15
       call      qword ptr [7FFCFD326C70]
       jmp       short M00_L32
M00_L31:
       mov       rcx,r15
       mov       rdx,r13
       call      qword ptr [7FFCFD326C58]
M00_L32:
       mov       r8,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rdi],r8
       jne       near ptr M00_L42
       cmp       dword ptr [rdi+10],0
       je        near ptr M00_L41
       mov       r14d,[rdi+14]
       xor       r13d,r13d
       cmp       r14d,[rdi+14]
       jne       near ptr M00_L40
M00_L33:
       cmp       r13d,[rdi+10]
       jae       short M00_L35
       mov       r8,[rdi+8]
       cmp       r13d,[r8+8]
       jae       near ptr M00_L48
       mov       r12,[r8+r13*8+10]
       inc       r13d
       lea       r8,[rbp-50]
       mov       rcx,r15
       mov       rdx,r12
       call      qword ptr [7FFCFCAB7228]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
       test      eax,eax
       jne       near ptr M00_L38
M00_L34:
       cmp       r14d,[rdi+14]
       je        short M00_L33
       jmp       near ptr M00_L40
M00_L35:
       mov       [rbp-58],rsi
       mov       rcx,[rbx+60]
       lea       r8,[rbp-58]
       mov       rdx,7FFCFD1878B8
       cmp       [rcx],ecx
       call      qword ptr [7FFCFD10D2D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
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
M00_L36:
       call      qword ptr [7FFCFCEBE958]
       mov       ecx,69E
       mov       rdx,7FFCFCD16050
       call      qword ptr [7FFCFC7EF210]
       mov       rbx,rax
       mov       ecx,1B61
       mov       rdx,7FFCFCBE5770
       call      qword ptr [7FFCFC7EF210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCFC7ED9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFCFCD16050
       call      qword ptr [7FFCFC7EF210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCFC7ED9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCFD104678]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCFD104690]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L37:
       call      qword ptr [7FFCFCEBE958]
       mov       ecx,0B5
       mov       rdx,7FFCFCD16050
       call      qword ptr [7FFCFC7EF210]
       mov       rbx,rax
       mov       ecx,1B61
       mov       rdx,7FFCFCBE5770
       call      qword ptr [7FFCFC7EF210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCFC7ED9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFCFCD16050
       call      qword ptr [7FFCFC7EF210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCFC7ED9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCFD104678]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCFD104690]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L38:
       inc       dword ptr [rsi+14]
       mov       rax,[rsi+8]
       mov       r8d,[rsi+10]
       cmp       [rax+8],r8d
       jbe       short M00_L39
       lea       ecx,[r8+1]
       mov       [rsi+10],ecx
       mov       ecx,r8d
       lea       rcx,[rax+rcx*8+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L34
M00_L39:
       mov       rcx,rsi
       mov       rdx,r12
       call      qword ptr [7FFCFC7E71C8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M00_L34
M00_L40:
       call      qword ptr [7FFCFC7EFC48]
       int       3
M00_L41:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,2A1E7400D48
       mov       rcx,[rcx]
       jmp       short M00_L43
M00_L42:
       mov       rcx,rdi
       mov       r11,7FFCFC731C58
       call      qword ptr [r11]
       mov       rcx,rax
M00_L43:
       mov       [rbp-60],rcx
M00_L44:
       mov       rcx,[rbp-60]
       mov       r11,[rcx]
       mov       r11,7FFCFC731C60
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L47
       mov       rcx,[rbp-60]
       mov       r11,7FFCFC731C68
       call      qword ptr [r11]
       mov       rdi,rax
       lea       r8,[rbp-50]
       mov       rcx,r15
       mov       rdx,rdi
       call      qword ptr [7FFCFCAB7228]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
       test      eax,eax
       je        short M00_L44
       inc       dword ptr [rsi+14]
       mov       rax,[rsi+8]
       mov       r8d,[rsi+10]
       cmp       [rax+8],r8d
       jbe       short M00_L45
       lea       ecx,[r8+1]
       mov       [rsi+10],ecx
       cmp       r8d,[rax+8]
       jae       short M00_L46
       mov       ecx,r8d
       lea       rcx,[rax+rcx*8+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M00_L44
M00_L45:
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FFCFC7E71C8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M00_L44
M00_L46:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L47:
       mov       rcx,[rbp-60]
       mov       r11,7FFCFC731C70
       call      qword ptr [r11]
       jmp       near ptr M00_L35
M00_L48:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       sub       rsp,28
       cmp       qword ptr [rbp-60],0
       je        short M00_L49
       mov       rcx,[rbp-60]
       mov       r11,7FFCFC731C70
       call      qword ptr [r11]
M00_L49:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       qword ptr [rbp-68],0
       je        short M00_L50
       mov       rcx,[rbp-68]
       mov       r11,7FFCFC731C98
       call      qword ptr [r11]
M00_L50:
       nop
       add       rsp,28
       ret
; Total bytes of code 2178
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
; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       ecx,edx
       call      qword ptr [7FFCFC7E5A88]; System.Collections.HashHelpers.GetPrime(Int32)
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
       mov       rdx,7FFCFD2ABC60
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M02_L00
; Total bytes of code 169
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
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       esi,edx
       mov       edi,r8d
       mov       rcx,[rbx]
       call      qword ptr [7FFD5A79BEB0]
       mov       rcx,rax
       movsxd    rdx,esi
       call      qword ptr [7FFD5A798070]; CORINFO_HELP_NEWARR_1_DIRECT
       mov       rbp,rax
       mov       r14d,[rbx+28]
       mov       rcx,[rbx+10]
       mov       rdx,rbp
       mov       r8d,r14d
       call      qword ptr [7FFD5A7A9378]; Precode of System.Array.Copy(System.Array, System.Array, Int32)
       movzx     ecx,dil
       test      cl,1
       jne       near ptr M03_L06
M03_L00:
       movsxd    rcx,esi
       call      qword ptr [7FFD5A7A5BF0]
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      qword ptr [7FFD5A797FD0]; CORINFO_HELP_ASSIGN_REF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,esi
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rbx+20],rax
       xor       ecx,ecx
       test      r14d,r14d
       jle       short M03_L03
       cmp       [rbp+8],r14d
       jl        near ptr M03_L04
M03_L01:
       mov       edx,ecx
       shl       rdx,4
       lea       rdx,[rbp+rdx+10]
       cmp       dword ptr [rdx+0C],0FFFFFFFF
       jl        short M03_L02
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
       jae       near ptr M03_L11
       mov       r10d,r10d
       lea       rax,[r8+r10*4+10]
       mov       r8d,[rax]
       dec       r8d
       mov       [rdx+0C],r8d
       lea       edx,[rcx+1]
       mov       [rax],edx
M03_L02:
       inc       ecx
       cmp       ecx,r14d
       jl        short M03_L01
M03_L03:
       lea       rcx,[rbx+10]
       mov       rdx,rbp
       call      qword ptr [7FFD5A797FD0]; CORINFO_HELP_ASSIGN_REF
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
M03_L04:
       cmp       ecx,[rbp+8]
       jae       near ptr M03_L11
       mov       eax,ecx
       shl       rax,4
       lea       rdx,[rbp+rax+10]
       cmp       dword ptr [rdx+0C],0FFFFFFFF
       jl        short M03_L05
       mov       eax,[rdx+8]
       mov       r8,[rbx+8]
       mov       r10d,eax
       imul      r10,[rbx+20]
       shr       r10,20
       inc       r10
       mov       eax,[r8+8]
       imul      r10,rax
       shr       r10,20
       cmp       r10d,[r8+8]
       jae       near ptr M03_L11
       mov       eax,r10d
       lea       rax,[r8+rax*4+10]
       mov       r8d,[rax]
       dec       r8d
       mov       [rdx+0C],r8d
       lea       edx,[rcx+1]
       mov       [rax],edx
M03_L05:
       inc       ecx
       cmp       ecx,r14d
       jl        short M03_L04
       jmp       near ptr M03_L03
M03_L06:
       mov       rcx,[rbx]
       call      qword ptr [7FFD5A79B4F0]
       mov       rdi,rax
       mov       rcx,[rbx+18]
       call      qword ptr [7FFD5A7A77D0]
       mov       rcx,rax
       lea       r11,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       [rcx],ecx
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFD5A798078]; Precode of System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdi,rax
       lea       rcx,[rbx+18]
       mov       rdx,rdi
       call      qword ptr [7FFD5A797FD0]; CORINFO_HELP_ASSIGN_REF
       xor       r15d,r15d
       cmp       r15d,r14d
       jge       near ptr M03_L00
M03_L07:
       cmp       r15d,[rbp+8]
       jae       short M03_L11
       mov       rcx,r15
       shl       rcx,4
       lea       r13,[rbp+rcx+10]
       cmp       dword ptr [r13+0C],0FFFFFFFF
       jl        short M03_L10
       cmp       qword ptr [r13],0
       jne       short M03_L08
       xor       r12d,r12d
       jmp       short M03_L09
M03_L08:
       mov       rcx,[rbx]
       call      qword ptr [7FFD5A79D148]
       mov       rdx,[r13]
       mov       rcx,rdi
       mov       r11,rax
       call      qword ptr [rax]
       mov       r12d,eax
M03_L09:
       mov       [r13+8],r12d
M03_L10:
       inc       r15d
       cmp       r15d,r14d
       jl        short M03_L07
       jmp       near ptr M03_L00
M03_L11:
       call      qword ptr [7FFD5A797FC0]
       int       3
; Total bytes of code 540
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
       je        near ptr M04_L07
       mov       rdi,[rbx+10]
       xor       ebp,ebp
       mov       r14,[rbx+18]
       test      rsi,rsi
       je        near ptr M04_L10
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+78]
       test      r11,r11
       je        near ptr M04_L08
M04_L00:
       mov       rcx,offset MT_System.Collections.Generic.ObjectEqualityComparer<System.RuntimeType>
       cmp       [r14],rcx
       jne       near ptr M04_L13
       mov       [rsp+28],rsi
       xor       ecx,ecx
       mov       [rsp+20],rcx
       lea       rcx,[rsp+28]
       cmp       qword ptr [rsp+20],0
       jne       short M04_L01
       mov       rcx,[rsp+28]
       mov       [rsp+20],rcx
       lea       rcx,[rsp+20]
       cmp       qword ptr [rsp+20],0
       je        near ptr M04_L11
M04_L01:
       mov       r15,[rcx]
       mov       rcx,offset MT_System.RuntimeType
       cmp       [r15],rcx
       jne       near ptr M04_L12
       mov       rcx,r15
       call      00007FFD5C3C6270
       test      eax,eax
       je        near ptr M04_L09
M04_L02:
       mov       r15d,eax
M04_L03:
       xor       ecx,ecx
       mov       [rsp+20],rcx
M04_L04:
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
       jae       near ptr M04_L18
       mov       edx,edx
       lea       rcx,[rcx+rdx*4+10]
       mov       r13d,[rcx]
       dec       r13d
       js        short M04_L07
M04_L05:
       cmp       r13d,[rdi+8]
       jae       near ptr M04_L18
       mov       ecx,r13d
       shl       rcx,4
       lea       r12,[rdi+rcx+10]
       cmp       [r12+8],r15d
       je        near ptr M04_L14
M04_L06:
       mov       r13d,[r12+0C]
       inc       ebp
       cmp       [rdi+8],ebp
       jb        near ptr M04_L17
       test      r13d,r13d
       jge       short M04_L05
M04_L07:
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
M04_L08:
       mov       rdx,7FFCFD221DC0
       call      qword ptr [7FFCFC7EF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M04_L00
M04_L09:
       mov       rcx,r15
       call      qword ptr [7FFCFCAB7258]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       jmp       near ptr M04_L02
M04_L10:
       xor       r15d,r15d
       jmp       near ptr M04_L04
M04_L11:
       xor       r15d,r15d
       jmp       near ptr M04_L03
M04_L12:
       mov       rcx,r15
       mov       rax,[r15]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
       mov       r15d,eax
       jmp       near ptr M04_L03
M04_L13:
       mov       rcx,r14
       mov       rdx,rsi
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       near ptr M04_L04
M04_L14:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+80]
       test      r11,r11
       je        short M04_L15
       jmp       short M04_L16
M04_L15:
       mov       rdx,7FFCFD221DD8
       call      qword ptr [7FFCFC7EF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M04_L16:
       mov       rdx,[r12]
       mov       rcx,r14
       mov       r8,rsi
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M04_L06
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
M04_L17:
       call      qword ptr [7FFCFC7EF480]
       int       3
M04_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 532
```
```assembly
; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
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
       mov       rdi,r8
       cmp       qword ptr [rbx+8],0
       je        near ptr M05_L13
M05_L00:
       mov       rbp,[rbx+10]
       mov       r14,[rbx+18]
       xor       r15d,r15d
       test      rsi,rsi
       je        near ptr M05_L14
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+78]
       test      r11,r11
       je        near ptr M05_L12
M05_L01:
       mov       rcx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r14],rcx
       jne       near ptr M05_L22
       mov       rdx,[rsi+28]
       test      rdx,rdx
       je        near ptr M05_L15
       mov       rcx,2A1D1400068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M05_L21
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,808B52E1
       mov       r8d,0C4459885
       cmp       edx,8
       jb        near ptr M05_L16
       mov       r10d,edx
       shr       r10d,3
M05_L02:
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
       jne       short M05_L02
       test      dl,4
       jne       near ptr M05_L17
M05_L03:
       mov       r10d,edx
       and       r10,7
       mov       ecx,[rcx+r10-4]
       shr       ecx,8
       or        ecx,80000000
       not       edx
       shl       edx,3
       shrx      ecx,ecx,edx
M05_L04:
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
M05_L05:
       mov       rcx,[rbx+8]
       mov       edx,r13d
       imul      rdx,[rbx+20]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       mov       r8d,eax
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,eax
       jae       near ptr M05_L30
       mov       edx,edx
       lea       r12,[rcx+rdx*4+10]
       mov       eax,[r12]
       dec       eax
       jns       near ptr M05_L10
M05_L06:
       cmp       dword ptr [rbx+30],0
       jg        near ptr M05_L27
       mov       eax,[rbx+28]
       mov       [rsp+38],eax
       cmp       [rbp+8],eax
       je        near ptr M05_L28
M05_L07:
       mov       eax,[rsp+38]
       mov       ebp,eax
       lea       ecx,[rbp+1]
       mov       [rbx+28],ecx
       mov       rcx,[rbx+10]
       mov       rax,rcx
M05_L08:
       cmp       ebp,[rax+8]
       jae       near ptr M05_L30
       mov       ecx,ebp
       shl       rcx,4
       mov       [rsp+30],rax
       lea       rcx,[rax+rcx+10]
       mov       [rcx+8],r13d
       mov       edx,[r12]
       dec       edx
       mov       [rcx+0C],edx
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       lea       edx,[rbp+1]
       mov       [r12],edx
       inc       dword ptr [rbx+34]
       mov       [rdi],ebp
       cmp       r15d,64
       ja        near ptr M05_L29
M05_L09:
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
M05_L10:
       cmp       eax,[rbp+8]
       jae       near ptr M05_L30
       mov       [rsp+3C],eax
       mov       ecx,eax
       shl       rcx,4
       lea       r8,[rbp+rcx+10]
       mov       [rsp+28],r8
       cmp       [r8+8],r13d
       je        near ptr M05_L23
M05_L11:
       mov       r8,[rsp+28]
       mov       eax,[r8+0C]
       inc       r15d
       cmp       [rbp+8],r15d
       jb        near ptr M05_L26
       test      eax,eax
       jge       short M05_L10
       jmp       near ptr M05_L06
M05_L12:
       mov       rdx,7FFCFD221DC0
       call      qword ptr [7FFCFC7EF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M05_L01
M05_L13:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFCFCAB71B0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       jmp       near ptr M05_L00
M05_L14:
       xor       r13d,r13d
       jmp       near ptr M05_L05
M05_L15:
       xor       r13d,r13d
       jmp       near ptr M05_L05
M05_L16:
       cmp       edx,4
       jb        short M05_L18
M05_L17:
       add       eax,[rcx]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       jmp       near ptr M05_L03
M05_L18:
       mov       r10d,80
       test      dl,1
       je        short M05_L19
       mov       r10d,edx
       and       r10,2
       movzx     r10d,byte ptr [rcx+r10]
       or        r10d,8000
M05_L19:
       test      dl,2
       je        short M05_L20
       shl       r10d,10
       movzx     ecx,word ptr [rcx]
       or        r10d,ecx
       mov       ecx,r10d
       jmp       near ptr M05_L04
M05_L20:
       mov       ecx,r10d
       jmp       near ptr M05_L04
M05_L21:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       r13d,eax
       jmp       near ptr M05_L05
M05_L22:
       mov       rcx,r14
       mov       rdx,rsi
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       near ptr M05_L05
M05_L23:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+80]
       test      r11,r11
       je        short M05_L24
       jmp       short M05_L25
M05_L24:
       mov       rdx,7FFCFD221DD8
       call      qword ptr [7FFCFC7EF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M05_L25:
       mov       rax,[rsp+28]
       mov       rdx,[rax]
       mov       rcx,r14
       mov       r8,rsi
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M05_L11
       mov       eax,[rsp+3C]
       mov       [rdi],eax
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
M05_L26:
       call      qword ptr [7FFCFC7EF480]
       int       3
M05_L27:
       mov       ecx,[rbx+2C]
       mov       eax,ecx
       dec       dword ptr [rbx+30]
       cmp       ecx,[rbp+8]
       jae       near ptr M05_L30
       shl       rcx,4
       mov       ecx,[rbp+rcx+1C]
       neg       ecx
       add       ecx,0FFFFFFFD
       mov       [rbx+2C],ecx
       mov       ecx,eax
       mov       rax,rbp
       mov       ebp,ecx
       jmp       near ptr M05_L08
M05_L28:
       mov       rcx,rbx
       call      qword ptr [7FFCFD1CF090]
       mov       rcx,[rbx+8]
       mov       edx,r13d
       imul      rdx,[rbx+20]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       imul      rdx,rax
       shr       rdx,20
       cmp       edx,[rcx+8]
       jae       short M05_L30
       mov       edx,edx
       lea       r12,[rcx+rdx*4+10]
       jmp       near ptr M05_L07
M05_L29:
       mov       rdx,r14
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M05_L09
       mov       rbp,[rsp+30]
       mov       edx,[rbp+8]
       mov       rcx,rbx
       mov       r8d,1
       call      qword ptr [7FFCFCC9D638]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFCFCAB7270]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       mov       [rdi],eax
       jmp       near ptr M05_L09
M05_L30:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1100
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
       je        near ptr M07_L00
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M07_L00
       test      rbx,rbx
       je        near ptr M07_L03
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        near ptr M07_L03
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M07_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFD5C418D20
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFCFC7E5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFCFC7E5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M07_L00:
       test      rbx,rbx
       je        short M07_L01
       mov       ebp,[rbx+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M07_L02
M07_L01:
       mov       rax,2E266260008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M07_L02:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M07_L03:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M07_L04:
       call      qword ptr [7FFCFD1C7C30]
       int       3
; Total bytes of code 235
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,[rbx+10]
       mov       ebp,edi
       lea       ecx,[rbp+1]
       mov       rdx,[rbx+8]
       cmp       dword ptr [rdx+8],0
       jne       short M08_L01
       mov       r14d,4
M08_L00:
       mov       edx,7FFFFFC7
       cmp       r14d,7FFFFFC7
       cmova     r14d,edx
       cmp       r14d,ecx
       cmovl     r14d,ecx
       cmp       r14d,edi
       jge       short M08_L02
       mov       ecx,7
       mov       edx,0F
       call      qword ptr [7FFCFCEB6058]
       int       3
M08_L01:
       mov       rdx,[rbx+8]
       mov       r14d,[rdx+8]
       add       r14d,r14d
       jmp       short M08_L00
M08_L02:
       mov       rcx,[rbx+8]
       cmp       [rcx+8],r14d
       je        near ptr M08_L08
       test      r14d,r14d
       jg        short M08_L05
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+0B8]
       test      rdx,rdx
       je        short M08_L04
M08_L03:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M08_L08
M08_L04:
       mov       rdx,7FFCFD222140
       call      qword ptr [7FFCFC7EF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       short M08_L03
M08_L05:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+0B0]
       test      rax,rax
       je        short M08_L09
       mov       rcx,rax
M08_L06:
       mov       edx,r14d
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       test      edi,edi
       jle       short M08_L07
       mov       rcx,[rbx+8]
       mov       r8d,edi
       mov       rdx,r14
       call      qword ptr [7FFCFC7EF588]; System.Array.Copy(System.Array, System.Array, Int32)
M08_L07:
       lea       rcx,[rbx+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
M08_L08:
       lea       ecx,[rbp+1]
       mov       [rbx+10],ecx
       mov       rcx,[rbx+8]
       movsxd    rdx,ebp
       mov       r8,rsi
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M08_L09:
       mov       rdx,7FFCFD197D70
       call      qword ptr [7FFCFC7EF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M08_L06
; Total bytes of code 309
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M09_L00
       ret
M09_L00:
       jmp       qword ptr [7FFCFC7E5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsAddRemoveCollectionBenchmark.AddRangeIfNotExists()
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
       mov       [rbp-50],rax
       mov       [rbp-58],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       [rbp-60],rsi
       mov       rdi,[rbx+280]
       test      rsi,rsi
       je        near ptr M00_L53
       mov       r14,rsi
       test      rdi,rdi
       je        near ptr M00_L54
       mov       rcx,offset MT_System.Collections.Generic.HashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,25CD1400AC0
       mov       rdx,[rcx]
       lea       rcx,[r15+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,r14
       mov       rcx,offset MT_System.Collections.Generic.HashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r13,rax
       test      r13,r13
       jne       near ptr M00_L55
M00_L00:
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r14],rcx
       jne       near ptr M00_L56
       mov       ecx,[r14+10]
M00_L01:
       test      ecx,ecx
       jle       short M00_L02
       call      qword ptr [7FFCFC7E5A88]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       r13d,eax
       movsxd    rdx,r13d
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r12,rax
       movsxd    rdx,r13d
       mov       rcx,offset MT_System.Collections.Generic.HashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Entry[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rbp-70],rax
       mov       dword ptr [r15+2C],0FFFFFFFF
       lea       rcx,[r15+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+10]
       mov       rdx,[rbp-70]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,r13d
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [r15+20],rax
M00_L02:
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r14],rcx
       jne       near ptr M00_L58
       cmp       dword ptr [r14+10],0
       je        near ptr M00_L57
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       r12d,[r14+14]
       lea       rcx,[r13+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r13+10],rcx
       mov       [r13+18],r12d
       mov       [r13+1C],ecx
M00_L03:
       mov       [rbp-78],r13
M00_L04:
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       r13,[rbp-78]
       cmp       [r13],rcx
       jne       near ptr M00_L32
       lea       r14,[r13+8]
       mov       rcx,[r14]
       mov       edx,[r14+10]
       mov       rax,[r14]
       cmp       edx,[rax+14]
       jne       near ptr M00_L34
       mov       edx,[r14+14]
       cmp       edx,[rcx+10]
       jae       near ptr M00_L16
       mov       rcx,[rcx+8]
       mov       edx,[r14+14]
       cmp       edx,[rcx+8]
       jae       near ptr M00_L35
       mov       rdx,[rcx+rdx*8+10]
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [r14+14]
       mov       r14,[r13+10]
M00_L05:
       cmp       qword ptr [r15+8],0
       je        near ptr M00_L18
M00_L06:
       mov       r12,[r15+10]
       mov       rax,[r15+18]
       xor       r8d,r8d
       mov       [rbp-3C],r8d
       test      r14,r14
       je        near ptr M00_L19
       mov       rcx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       [rbp-88],rax
       cmp       [rax],rcx
       jne       near ptr M00_L27
       mov       rax,[rbp-88]
       mov       rdx,[r14+28]
       test      rdx,rdx
       je        near ptr M00_L20
       mov       rcx,25CBB400068
       mov       rcx,[rcx]
       mov       r10,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],r10
       jne       near ptr M00_L26
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       r10d,4E6F59D7
       mov       r9d,8EB03D44
       cmp       edx,8
       jb        near ptr M00_L21
       mov       r11d,edx
       shr       r11d,3
M00_L07:
       add       r10d,[rcx]
       mov       esi,[rcx+4]
       xor       r9d,r10d
       rol       r10d,14
       add       r10d,r9d
       rol       r9d,9
       xor       r9d,r10d
       rol       r10d,1B
       add       r10d,r9d
       rol       r9d,13
       add       esi,r10d
       mov       r10d,r9d
       xor       r10d,esi
       rol       esi,14
       add       esi,r10d
       rol       r10d,9
       xor       r10d,esi
       rol       esi,1B
       add       esi,r10d
       rol       r10d,13
       mov       r9d,esi
       add       rcx,8
       dec       r11d
       mov       r8d,r9d
       mov       r9d,r10d
       mov       r10d,r8d
       jne       short M00_L07
       test      dl,4
       jne       near ptr M00_L22
M00_L08:
       mov       r11d,edx
       and       r11,7
       mov       ecx,[rcx+r11-4]
       shr       ecx,8
       or        ecx,80000000
       not       edx
       shl       edx,3
       shrx      ecx,ecx,edx
M00_L09:
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
       mov       r10d,ecx
       rol       r10d,14
       add       r10d,edx
       rol       edx,9
       xor       edx,r10d
       rol       r10d,1B
       add       r10d,edx
       mov       r9d,edx
       rol       r9d,13
       xor       r10d,r9d
M00_L10:
       mov       [rbp-40],r10d
       mov       rdx,[r15+8]
       mov       ecx,r10d
       imul      rcx,[r15+20]
       shr       rcx,20
       inc       rcx
       mov       r11d,[rdx+8]
       imul      rcx,r11
       shr       rcx,20
       cmp       ecx,[rdx+8]
       jae       near ptr M00_L35
       mov       ecx,ecx
       lea       r9,[rdx+rcx*4+10]
       mov       [rbp-90],r9
       mov       r11d,[r9]
       dec       r11d
       jns       near ptr M00_L14
M00_L11:
       cmp       dword ptr [r15+30],0
       jg        near ptr M00_L29
       mov       edx,[r15+28]
       mov       [rbp-44],edx
       cmp       [r12+8],edx
       je        near ptr M00_L30
M00_L12:
       mov       edx,[rbp-44]
       mov       r12d,edx
       lea       ecx,[r12+1]
       mov       [r15+28],ecx
       mov       rcx,[r15+10]
       mov       r11,rcx
       mov       [rbp-88],rax
M00_L13:
       cmp       r12d,[r11+8]
       jae       near ptr M00_L35
       mov       ecx,r12d
       shl       rcx,4
       mov       [rbp-80],r11
       lea       rcx,[r11+rcx+10]
       mov       [rcx+8],r10d
       mov       r9,[rbp-90]
       mov       edx,[r9]
       dec       edx
       mov       [rcx+0C],edx
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       inc       r12d
       mov       rdx,[rbp-90]
       mov       [rdx],r12d
       inc       dword ptr [r15+34]
       cmp       dword ptr [rbp-3C],64
       jbe       near ptr M00_L04
       jmp       near ptr M00_L31
M00_L14:
       cmp       r11d,[r12+8]
       jae       near ptr M00_L35
       mov       edx,r11d
       shl       rdx,4
       lea       r11,[r12+rdx+10]
       mov       [rbp-98],r11
       cmp       [r11+8],r10d
       je        near ptr M00_L28
M00_L15:
       mov       r11d,[r11+0C]
       mov       r8d,[rbp-3C]
       inc       r8d
       mov       [rbp-3C],r8d
       cmp       [r12+8],r8d
       jb        near ptr M00_L33
       test      r11d,r11d
       mov       r10d,[rbp-40]
       jge       short M00_L14
       jmp       near ptr M00_L11
M00_L16:
       xor       eax,eax
       mov       [r14+8],rax
       mov       dword ptr [r14+14],0FFFFFFFF
       jmp       near ptr M00_L36
M00_L17:
       mov       rcx,r13
       mov       r11,7FFCFC731E18
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L05
M00_L18:
       mov       rcx,r15
       xor       edx,edx
       call      qword ptr [7FFCFCAB71B0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       jmp       near ptr M00_L06
M00_L19:
       xor       r10d,r10d
       jmp       near ptr M00_L10
M00_L20:
       xor       r10d,r10d
       jmp       near ptr M00_L10
M00_L21:
       cmp       edx,4
       jb        short M00_L23
M00_L22:
       add       r10d,[rcx]
       xor       r9d,r10d
       rol       r10d,14
       add       r10d,r9d
       rol       r9d,9
       xor       r9d,r10d
       rol       r10d,1B
       add       r10d,r9d
       rol       r9d,13
       jmp       near ptr M00_L08
M00_L23:
       mov       r11d,80
       test      dl,1
       je        short M00_L24
       mov       r11d,edx
       and       r11,2
       movzx     r11d,byte ptr [rcx+r11]
       or        r11d,8000
M00_L24:
       test      dl,2
       je        short M00_L25
       shl       r11d,10
       movzx     ecx,word ptr [rcx]
       or        r11d,ecx
       mov       ecx,r11d
       jmp       near ptr M00_L09
M00_L25:
       mov       ecx,r11d
       jmp       near ptr M00_L09
M00_L26:
       mov       [rbp-88],rax
       mov       r10,[rcx]
       mov       r10,[r10+48]
       call      qword ptr [r10+18]
       mov       r10d,eax
       mov       rax,[rbp-88]
       jmp       near ptr M00_L10
M00_L27:
       mov       rax,[rbp-88]
       mov       [rbp-88],rax
       mov       rcx,rax
       mov       rdx,r14
       mov       r11,7FFCFC731E28
       call      qword ptr [r11]
       mov       r10d,eax
       mov       rax,[rbp-88]
       jmp       near ptr M00_L10
M00_L28:
       mov       rdx,[r11]
       mov       [rbp-88],rax
       mov       rcx,rax
       mov       r8,r14
       mov       r11,7FFCFC731E30
       call      qword ptr [r11]
       test      eax,eax
       mov       rax,[rbp-88]
       mov       r11,[rbp-98]
       jne       near ptr M00_L04
       jmp       near ptr M00_L15
M00_L29:
       mov       ecx,[r15+2C]
       mov       r11d,ecx
       dec       dword ptr [r15+30]
       mov       ecx,[r15+2C]
       cmp       ecx,[r12+8]
       jae       near ptr M00_L35
       shl       rcx,4
       mov       ecx,[r12+rcx+1C]
       neg       ecx
       add       ecx,0FFFFFFFD
       mov       [r15+2C],ecx
       mov       [rbp-88],rax
       mov       ecx,r11d
       mov       r11,r12
       mov       r12d,ecx
       jmp       near ptr M00_L13
M00_L30:
       mov       [rbp-88],rax
       mov       rcx,r15
       call      qword ptr [7FFCFD1CF1E0]
       mov       rcx,[r15+8]
       mov       r12d,[rbp-40]
       mov       edx,r12d
       imul      rdx,[r15+20]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       imul      rdx,rax
       shr       rdx,20
       cmp       edx,[rcx+8]
       jae       near ptr M00_L35
       mov       edx,edx
       lea       r9,[rcx+rdx*4+10]
       mov       rax,r9
       mov       [rbp-90],rax
       mov       r10d,r12d
       mov       rax,[rbp-88]
       jmp       near ptr M00_L12
M00_L31:
       mov       rdx,[rbp-88]
       mov       r12,[rbp-80]
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M00_L04
       mov       edx,[r12+8]
       mov       rcx,r15
       mov       r8d,1
       call      qword ptr [7FFCFCC9D638]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,r15
       mov       rdx,r14
       call      qword ptr [7FFCFCAB7270]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       jmp       near ptr M00_L04
M00_L32:
       mov       rcx,r13
       mov       r11,7FFCFC731E10
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L17
       jmp       near ptr M00_L59
M00_L33:
       call      qword ptr [7FFCFC7EF480]
       int       3
M00_L34:
       call      qword ptr [7FFCFC7EFC48]
       int       3
M00_L35:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L36:
       mov       ecx,[r15+28]
       test      ecx,ecx
       jle       short M00_L37
       mov       rax,[r15+10]
       mov       eax,[rax+8]
       xor       edx,edx
       div       ecx
       cmp       eax,3
       jg        near ptr M00_L60
M00_L37:
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rdi],rcx
       jne       near ptr M00_L62
       cmp       dword ptr [rdi+10],0
       je        near ptr M00_L61
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       r13d,[rdi+14]
       lea       rcx,[r14+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r14+10],rcx
       mov       [r14+18],r13d
       mov       [r14+1C],ecx
M00_L38:
       mov       [rbp-68],r14
       cmp       qword ptr [rbp-68],0
       je        short M00_L42
       mov       r14,[rbp-68]
       mov       rdi,[r14]
       mov       rdx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rdi,rdx
       jne       short M00_L42
M00_L39:
       mov       rdx,rdi
       lea       rcx,[r14+8]
       cmp       [rcx],ecx
       call      qword ptr [7FFCFCBAC9A8]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       je        near ptr M00_L51
       mov       r13,[r14+10]
       lea       r8,[rbp-50]
       mov       rcx,r15
       mov       rdx,r13
       call      qword ptr [7FFCFCAB7228]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
       test      eax,eax
       je        short M00_L39
       jmp       short M00_L44
M00_L40:
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rdi,rcx
       jne       near ptr M00_L47
       mov       r13,[r14+10]
M00_L41:
       lea       r8,[rbp-50]
       mov       rcx,r15
       mov       rdx,r13
       call      qword ptr [7FFCFCAB7228]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
       test      eax,eax
       jne       near ptr M00_L48
M00_L42:
       mov       r14,[rbp-68]
       mov       rdi,[r14]
       mov       rdx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rdi,rdx
       jne       short M00_L46
       mov       rdx,rdi
       lea       rcx,[r14+8]
       cmp       [rcx],ecx
       call      qword ptr [7FFCFCBAC9A8]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L43:
       test      eax,eax
       jne       short M00_L40
       jmp       near ptr M00_L51
M00_L44:
       mov       rsi,[rbp-60]
       inc       dword ptr [rsi+14]
       mov       r12,[rsi+8]
       mov       eax,[rsi+10]
       cmp       [r12+8],eax
       jbe       short M00_L45
       lea       ecx,[rax+1]
       mov       [rsi+10],ecx
       cmp       eax,[r12+8]
       jae       near ptr M00_L50
       mov       ecx,eax
       lea       rcx,[r12+rcx*8+10]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L39
M00_L45:
       mov       rcx,rsi
       mov       rdx,r13
       call      qword ptr [7FFCFC7E71C8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M00_L39
M00_L46:
       mov       rcx,r14
       mov       r11,7FFCFC731DE8
       call      qword ptr [r11]
       jmp       short M00_L43
M00_L47:
       mov       rcx,r14
       mov       r11,7FFCFC731DF0
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M00_L41
M00_L48:
       mov       rsi,[rbp-60]
       inc       dword ptr [rsi+14]
       mov       r12,[rsi+8]
       mov       eax,[rsi+10]
       cmp       [r12+8],eax
       ja        short M00_L49
       mov       rcx,rsi
       mov       rdx,r13
       call      qword ptr [7FFCFC7E71C8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M00_L42
M00_L49:
       lea       ecx,[rax+1]
       mov       [rsi+10],ecx
       cmp       eax,[r12+8]
       jae       short M00_L50
       mov       ecx,eax
       lea       rcx,[r12+rcx*8+10]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L42
M00_L50:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L51:
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rdi,rcx
       jne       near ptr M00_L63
M00_L52:
       mov       rsi,[rbp-60]
       mov       [rbp-58],rsi
       mov       rcx,[rbx+60]
       lea       r8,[rbp-58]
       mov       rdx,7FFCFD18B8C8
       cmp       [rcx],ecx
       call      qword ptr [7FFCFD10D3B0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
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
M00_L53:
       call      qword ptr [7FFCFCEBE958]
       mov       ecx,69E
       mov       rdx,7FFCFCD16050
       call      qword ptr [7FFCFC7EF210]
       mov       rbx,rax
       mov       ecx,1B61
       mov       rdx,7FFCFCBE5770
       call      qword ptr [7FFCFC7EF210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCFC7ED9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFCFCD16050
       call      qword ptr [7FFCFC7EF210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCFC7ED9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCFD1046A8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCFD1046C0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L54:
       call      qword ptr [7FFCFCEBE958]
       mov       ecx,0B5
       mov       rdx,7FFCFCD16050
       call      qword ptr [7FFCFC7EF210]
       mov       r14,rax
       mov       ecx,1B61
       mov       rdx,7FFCFCBE5770
       call      qword ptr [7FFCFC7EF210]
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFCFC7ED9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFCFCD16050
       call      qword ptr [7FFCFC7EF210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCFC7ED9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCFD1046A8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCFD1046C0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L55:
       mov       r8,r13
       mov       rdx,r15
       mov       rcx,offset MT_System.Collections.Generic.HashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFCFD3175A0]
       test      eax,eax
       je        near ptr M00_L00
       mov       rcx,r15
       mov       rdx,r13
       call      qword ptr [7FFCFD317210]
       jmp       near ptr M00_L37
M00_L56:
       mov       rcx,r14
       mov       r11,7FFCFC731E00
       call      qword ptr [r11]
       mov       ecx,eax
       jmp       near ptr M00_L01
M00_L57:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,25CD1400D28
       mov       r13,[rcx]
       jmp       near ptr M00_L03
M00_L58:
       mov       rcx,r14
       mov       r11,7FFCFC731E08
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M00_L03
M00_L59:
       mov       rcx,r13
       mov       r11,7FFCFC731E20
       call      qword ptr [r11]
       jmp       near ptr M00_L36
M00_L60:
       mov       edx,ecx
       sub       edx,[r15+30]
       mov       rcx,r15
       call      qword ptr [7FFCFD317228]
       jmp       near ptr M00_L37
M00_L61:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,25CD1400D28
       mov       r14,[rcx]
       jmp       near ptr M00_L38
M00_L62:
       mov       rcx,rdi
       mov       r11,7FFCFC731DE0
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L38
M00_L63:
       mov       rcx,r14
       mov       r11,7FFCFC731DF8
       call      qword ptr [r11]
       jmp       near ptr M00_L52
       sub       rsp,28
       cmp       qword ptr [rbp-68],0
       je        short M00_L64
       mov       r14,[rbp-68]
       mov       rdi,[r14]
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rdi,rcx
       je        short M00_L64
       mov       rcx,r14
       mov       r11,7FFCFC731DF8
       call      qword ptr [r11]
M00_L64:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       qword ptr [rbp-78],0
       je        short M00_L65
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-78]
       cmp       [rax],rcx
       je        short M00_L65
       mov       rcx,rax
       mov       r11,7FFCFC731E20
       call      qword ptr [r11]
M00_L65:
       nop
       add       rsp,28
       ret
; Total bytes of code 2890
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
       mov       rcx,7FFD59B31390
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
       call      qword ptr [7FFCFD1C6640]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCFCC95B48]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M02_L03:
       mov       esi,ebx
       or        esi,1
       jmp       short M02_L06
M02_L04:
       mov       ecx,esi
       call      qword ptr [7FFCFD1C6658]
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
; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       ecx,edx
       call      qword ptr [7FFCFC7E5A88]; System.Collections.HashHelpers.GetPrime(Int32)
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
       mov       rdx,7FFCFD2AB4E0
       call      qword ptr [7FFCFC7EF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M03_L00
; Total bytes of code 170
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
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       esi,edx
       mov       edi,r8d
       mov       rcx,[rbx]
       call      qword ptr [7FFD5A79BEB0]
       mov       rcx,rax
       movsxd    rdx,esi
       call      qword ptr [7FFD5A798070]; CORINFO_HELP_NEWARR_1_DIRECT
       mov       rbp,rax
       mov       r14d,[rbx+28]
       mov       rcx,[rbx+10]
       mov       rdx,rbp
       mov       r8d,r14d
       call      qword ptr [7FFD5A7A9378]; Precode of System.Array.Copy(System.Array, System.Array, Int32)
       movzx     ecx,dil
       test      cl,1
       jne       near ptr M04_L06
M04_L00:
       movsxd    rcx,esi
       call      qword ptr [7FFD5A7A5BF0]
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      qword ptr [7FFD5A797FD0]; CORINFO_HELP_ASSIGN_REF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,esi
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rbx+20],rax
       xor       ecx,ecx
       test      r14d,r14d
       jle       short M04_L03
       cmp       [rbp+8],r14d
       jl        near ptr M04_L04
M04_L01:
       mov       edx,ecx
       shl       rdx,4
       lea       rdx,[rbp+rdx+10]
       cmp       dword ptr [rdx+0C],0FFFFFFFF
       jl        short M04_L02
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
       jae       near ptr M04_L11
       mov       r10d,r10d
       lea       rax,[r8+r10*4+10]
       mov       r8d,[rax]
       dec       r8d
       mov       [rdx+0C],r8d
       lea       edx,[rcx+1]
       mov       [rax],edx
M04_L02:
       inc       ecx
       cmp       ecx,r14d
       jl        short M04_L01
M04_L03:
       lea       rcx,[rbx+10]
       mov       rdx,rbp
       call      qword ptr [7FFD5A797FD0]; CORINFO_HELP_ASSIGN_REF
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
M04_L04:
       cmp       ecx,[rbp+8]
       jae       near ptr M04_L11
       mov       eax,ecx
       shl       rax,4
       lea       rdx,[rbp+rax+10]
       cmp       dword ptr [rdx+0C],0FFFFFFFF
       jl        short M04_L05
       mov       eax,[rdx+8]
       mov       r8,[rbx+8]
       mov       r10d,eax
       imul      r10,[rbx+20]
       shr       r10,20
       inc       r10
       mov       eax,[r8+8]
       imul      r10,rax
       shr       r10,20
       cmp       r10d,[r8+8]
       jae       near ptr M04_L11
       mov       eax,r10d
       lea       rax,[r8+rax*4+10]
       mov       r8d,[rax]
       dec       r8d
       mov       [rdx+0C],r8d
       lea       edx,[rcx+1]
       mov       [rax],edx
M04_L05:
       inc       ecx
       cmp       ecx,r14d
       jl        short M04_L04
       jmp       near ptr M04_L03
M04_L06:
       mov       rcx,[rbx]
       call      qword ptr [7FFD5A79B4F0]
       mov       rdi,rax
       mov       rcx,[rbx+18]
       call      qword ptr [7FFD5A7A77D0]
       mov       rcx,rax
       lea       r11,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       [rcx],ecx
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFD5A798078]; Precode of System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdi,rax
       lea       rcx,[rbx+18]
       mov       rdx,rdi
       call      qword ptr [7FFD5A797FD0]; CORINFO_HELP_ASSIGN_REF
       xor       r15d,r15d
       cmp       r15d,r14d
       jge       near ptr M04_L00
M04_L07:
       cmp       r15d,[rbp+8]
       jae       short M04_L11
       mov       rcx,r15
       shl       rcx,4
       lea       r13,[rbp+rcx+10]
       cmp       dword ptr [r13+0C],0FFFFFFFF
       jl        short M04_L10
       cmp       qword ptr [r13],0
       jne       short M04_L08
       xor       r12d,r12d
       jmp       short M04_L09
M04_L08:
       mov       rcx,[rbx]
       call      qword ptr [7FFD5A79D148]
       mov       rdx,[r13]
       mov       rcx,rdi
       mov       r11,rax
       call      qword ptr [rax]
       mov       r12d,eax
M04_L09:
       mov       [r13+8],r12d
M04_L10:
       inc       r15d
       cmp       r15d,r14d
       jl        short M04_L07
       jmp       near ptr M04_L00
M04_L11:
       call      qword ptr [7FFD5A797FC0]
       int       3
; Total bytes of code 540
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
       je        near ptr M05_L06
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
       je        near ptr M05_L07
M05_L00:
       mov       rcx,offset MT_System.Collections.Generic.ObjectEqualityComparer<System.RuntimeType>
       cmp       [r14],rcx
       jne       near ptr M05_L13
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
       je        near ptr M05_L08
       mov       rcx,r15
       mov       rax,[r15]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
       mov       r15d,eax
M05_L02:
       xor       ecx,ecx
       mov       [rsp+30],rcx
M05_L03:
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
       js        short M05_L06
M05_L04:
       mov       r12d,[rdi+8]
       cmp       r13d,r12d
       jae       near ptr M05_L18
       mov       ecx,r13d
       shl       rcx,4
       lea       rax,[rdi+rcx+10]
       mov       [rsp+28],rax
       cmp       [rax+8],r15d
       je        near ptr M05_L14
M05_L05:
       mov       rax,[rsp+28]
       mov       r13d,[rax+0C]
       inc       ebp
       cmp       r12d,ebp
       jb        near ptr M05_L17
       test      r13d,r13d
       jge       short M05_L04
M05_L06:
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
M05_L07:
       mov       rdx,7FFCFD222420
       call      qword ptr [7FFCFC7EF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M05_L00
M05_L08:
       mov       rcx,r15
       call      00007FFD5C3C6270
       test      eax,eax
       je        short M05_L10
       mov       r15d,eax
M05_L09:
       jmp       near ptr M05_L02
M05_L10:
       mov       rcx,r15
       call      qword ptr [7FFCFCAB7258]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       mov       r15d,eax
       jmp       short M05_L09
M05_L11:
       xor       r15d,r15d
       jmp       near ptr M05_L03
M05_L12:
       xor       r15d,r15d
       jmp       near ptr M05_L02
M05_L13:
       mov       rcx,r14
       mov       rdx,rsi
       call      qword ptr [r11]
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
       mov       rdx,7FFCFD222438
       call      qword ptr [7FFCFC7EF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M05_L16:
       mov       rax,[rsp+28]
       mov       rdx,[rax]
       mov       rcx,r14
       mov       r8,rsi
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M05_L05
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
       call      qword ptr [7FFCFC7EF480]
       int       3
M05_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 543
```
```assembly
; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx]
       mov       rdx,rcx
       mov       eax,[rbx+10]
       cmp       eax,[rcx+14]
       jne       short M06_L01
       mov       ecx,[rbx+14]
       cmp       ecx,[rdx+10]
       jae       short M06_L00
       mov       rdx,[rdx+8]
       cmp       ecx,[rdx+8]
       jae       short M06_L02
       mov       ecx,ecx
       mov       rdx,[rdx+rcx*8+10]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       dword ptr [rbx+14]
       mov       eax,1
       add       rsp,20
       pop       rbx
       ret
M06_L00:
       xor       eax,eax
       mov       [rbx+8],rax
       mov       dword ptr [rbx+14],0FFFFFFFF
       add       rsp,20
       pop       rbx
       ret
M06_L01:
       call      qword ptr [7FFCFC7EFC48]
       int       3
M06_L02:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 101
```
```assembly
; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
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
       mov       rdi,r8
       cmp       qword ptr [rbx+8],0
       je        near ptr M07_L13
M07_L00:
       mov       rbp,[rbx+10]
       mov       r14,[rbx+18]
       xor       r15d,r15d
       test      rsi,rsi
       je        near ptr M07_L14
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+78]
       test      r11,r11
       je        near ptr M07_L12
M07_L01:
       mov       rcx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r14],rcx
       jne       near ptr M07_L22
       mov       rdx,[rsi+28]
       test      rdx,rdx
       je        near ptr M07_L15
       mov       rcx,25CBB400068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M07_L21
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,4E6F59D7
       mov       r8d,8EB03D44
       cmp       edx,8
       jb        near ptr M07_L16
       mov       r10d,edx
       shr       r10d,3
M07_L02:
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
       jne       short M07_L02
       test      dl,4
       jne       near ptr M07_L17
M07_L03:
       mov       r10d,edx
       and       r10,7
       mov       ecx,[rcx+r10-4]
       shr       ecx,8
       or        ecx,80000000
       not       edx
       shl       edx,3
       shrx      ecx,ecx,edx
M07_L04:
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
M07_L05:
       mov       rcx,[rbx+8]
       mov       edx,r13d
       imul      rdx,[rbx+20]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       mov       r8d,eax
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,eax
       jae       near ptr M07_L30
       mov       edx,edx
       lea       r12,[rcx+rdx*4+10]
       mov       eax,[r12]
       dec       eax
       jns       near ptr M07_L10
M07_L06:
       cmp       dword ptr [rbx+30],0
       jg        near ptr M07_L27
       mov       eax,[rbx+28]
       mov       [rsp+38],eax
       cmp       [rbp+8],eax
       je        near ptr M07_L28
M07_L07:
       mov       eax,[rsp+38]
       mov       ebp,eax
       lea       ecx,[rbp+1]
       mov       [rbx+28],ecx
       mov       rcx,[rbx+10]
       mov       rax,rcx
M07_L08:
       cmp       ebp,[rax+8]
       jae       near ptr M07_L30
       mov       ecx,ebp
       shl       rcx,4
       mov       [rsp+30],rax
       lea       rcx,[rax+rcx+10]
       mov       [rcx+8],r13d
       mov       edx,[r12]
       dec       edx
       mov       [rcx+0C],edx
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       lea       edx,[rbp+1]
       mov       [r12],edx
       inc       dword ptr [rbx+34]
       mov       [rdi],ebp
       cmp       r15d,64
       ja        near ptr M07_L29
M07_L09:
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
M07_L10:
       cmp       eax,[rbp+8]
       jae       near ptr M07_L30
       mov       [rsp+3C],eax
       mov       ecx,eax
       shl       rcx,4
       lea       r8,[rbp+rcx+10]
       mov       [rsp+28],r8
       cmp       [r8+8],r13d
       je        near ptr M07_L23
M07_L11:
       mov       r8,[rsp+28]
       mov       eax,[r8+0C]
       inc       r15d
       cmp       [rbp+8],r15d
       jb        near ptr M07_L26
       test      eax,eax
       jge       short M07_L10
       jmp       near ptr M07_L06
M07_L12:
       mov       rdx,7FFCFD222420
       call      qword ptr [7FFCFC7EF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M07_L01
M07_L13:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFCFCAB71B0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       jmp       near ptr M07_L00
M07_L14:
       xor       r13d,r13d
       jmp       near ptr M07_L05
M07_L15:
       xor       r13d,r13d
       jmp       near ptr M07_L05
M07_L16:
       cmp       edx,4
       jb        short M07_L18
M07_L17:
       add       eax,[rcx]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       jmp       near ptr M07_L03
M07_L18:
       mov       r10d,80
       test      dl,1
       je        short M07_L19
       mov       r10d,edx
       and       r10,2
       movzx     r10d,byte ptr [rcx+r10]
       or        r10d,8000
M07_L19:
       test      dl,2
       je        short M07_L20
       shl       r10d,10
       movzx     ecx,word ptr [rcx]
       or        r10d,ecx
       mov       ecx,r10d
       jmp       near ptr M07_L04
M07_L20:
       mov       ecx,r10d
       jmp       near ptr M07_L04
M07_L21:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       r13d,eax
       jmp       near ptr M07_L05
M07_L22:
       mov       rcx,r14
       mov       rdx,rsi
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       near ptr M07_L05
M07_L23:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+80]
       test      r11,r11
       je        short M07_L24
       jmp       short M07_L25
M07_L24:
       mov       rdx,7FFCFD222438
       call      qword ptr [7FFCFC7EF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M07_L25:
       mov       rax,[rsp+28]
       mov       rdx,[rax]
       mov       rcx,r14
       mov       r8,rsi
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M07_L11
       mov       eax,[rsp+3C]
       mov       [rdi],eax
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
M07_L26:
       call      qword ptr [7FFCFC7EF480]
       int       3
M07_L27:
       mov       ecx,[rbx+2C]
       mov       eax,ecx
       dec       dword ptr [rbx+30]
       mov       ecx,[rbx+2C]
       cmp       ecx,[rbp+8]
       jae       near ptr M07_L30
       shl       rcx,4
       mov       ecx,[rbp+rcx+1C]
       neg       ecx
       add       ecx,0FFFFFFFD
       mov       [rbx+2C],ecx
       mov       ecx,eax
       mov       rax,rbp
       mov       ebp,ecx
       jmp       near ptr M07_L08
M07_L28:
       mov       rcx,rbx
       call      qword ptr [7FFCFD1CF1E0]
       mov       rcx,[rbx+8]
       mov       edx,r13d
       imul      rdx,[rbx+20]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       imul      rdx,rax
       shr       rdx,20
       cmp       edx,[rcx+8]
       jae       short M07_L30
       mov       edx,edx
       lea       r12,[rcx+rdx*4+10]
       jmp       near ptr M07_L07
M07_L29:
       mov       rdx,r14
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M07_L09
       mov       rbp,[rsp+30]
       mov       edx,[rbp+8]
       mov       rcx,rbx
       mov       r8d,1
       call      qword ptr [7FFCFCC9D638]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFCFCAB7270]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       mov       [rdi],eax
       jmp       near ptr M07_L09
M07_L30:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1103
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,[rbx+10]
       mov       ebp,edi
       lea       ecx,[rbp+1]
       mov       rdx,[rbx+8]
       cmp       dword ptr [rdx+8],0
       jne       short M08_L01
       mov       r14d,4
M08_L00:
       mov       edx,7FFFFFC7
       cmp       r14d,7FFFFFC7
       cmova     r14d,edx
       cmp       r14d,ecx
       cmovl     r14d,ecx
       cmp       r14d,edi
       jge       short M08_L02
       mov       ecx,7
       mov       edx,0F
       call      qword ptr [7FFCFCEB6058]
       int       3
M08_L01:
       mov       rdx,[rbx+8]
       mov       r14d,[rdx+8]
       add       r14d,r14d
       jmp       short M08_L00
M08_L02:
       mov       rcx,[rbx+8]
       cmp       [rcx+8],r14d
       je        near ptr M08_L08
       test      r14d,r14d
       jg        short M08_L05
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+0B8]
       test      rdx,rdx
       je        short M08_L04
M08_L03:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M08_L08
M08_L04:
       mov       rdx,7FFCFD2227A0
       call      qword ptr [7FFCFC7EF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       short M08_L03
M08_L05:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+0B0]
       test      rax,rax
       je        short M08_L09
       mov       rcx,rax
M08_L06:
       mov       edx,r14d
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       test      edi,edi
       jle       short M08_L07
       mov       rcx,[rbx+8]
       mov       r8d,edi
       mov       rdx,r14
       call      qword ptr [7FFCFC7EF588]; System.Array.Copy(System.Array, System.Array, Int32)
M08_L07:
       lea       rcx,[rbx+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
M08_L08:
       lea       ecx,[rbp+1]
       mov       [rbx+10],ecx
       mov       rcx,[rbx+8]
       movsxd    rdx,ebp
       mov       r8,rsi
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M08_L09:
       mov       rdx,7FFCFD197FD8
       call      qword ptr [7FFCFC7EF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M08_L06
; Total bytes of code 309
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
       je        near ptr M10_L00
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M10_L00
       test      rbx,rbx
       je        near ptr M10_L03
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        near ptr M10_L03
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M10_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFD5C418D20
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFCFC7E5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFCFC7E5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M10_L00:
       test      rbx,rbx
       je        short M10_L01
       mov       ebp,[rbx+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M10_L02
M10_L01:
       mov       rax,29D502C0008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M10_L02:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M10_L03:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M10_L04:
       call      qword ptr [7FFCFD1C7E88]
       int       3
; Total bytes of code 235
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
       jmp       qword ptr [7FFCFC7E5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsAddRemoveCollectionBenchmark.AddRangeIfNotExists()
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
       mov       [rbp-50],rax
       mov       [rbp-58],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       [rbp-60],rsi
       mov       rdi,[rbx+280]
       test      rsi,rsi
       je        near ptr M00_L53
       mov       r14,rsi
       test      rdi,rdi
       je        near ptr M00_L54
       mov       rcx,offset MT_System.Collections.Generic.HashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,140DB802AB8
       mov       rdx,[rcx]
       lea       rcx,[r15+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,r14
       mov       rcx,offset MT_System.Collections.Generic.HashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r13,rax
       test      r13,r13
       jne       near ptr M00_L55
M00_L00:
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r14],rcx
       jne       near ptr M00_L56
       mov       ecx,[r14+10]
M00_L01:
       test      ecx,ecx
       jle       short M00_L02
       call      qword ptr [7FFCFC7D5A88]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       r13d,eax
       movsxd    rdx,r13d
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r12,rax
       movsxd    rdx,r13d
       mov       rcx,offset MT_System.Collections.Generic.HashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Entry[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rbp-70],rax
       mov       dword ptr [r15+2C],0FFFFFFFF
       lea       rcx,[r15+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+10]
       mov       rdx,[rbp-70]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,r13d
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [r15+20],rax
M00_L02:
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r14],rcx
       jne       near ptr M00_L58
       cmp       dword ptr [r14+10],0
       je        near ptr M00_L57
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       r12d,[r14+14]
       lea       rcx,[r13+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r13+10],rcx
       mov       [r13+18],r12d
       mov       [r13+1C],ecx
M00_L03:
       mov       [rbp-78],r13
M00_L04:
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       r13,[rbp-78]
       cmp       [r13],rcx
       jne       near ptr M00_L32
       lea       r14,[r13+8]
       mov       rcx,[r14]
       mov       edx,[r14+10]
       mov       rax,[r14]
       cmp       edx,[rax+14]
       jne       near ptr M00_L34
       mov       edx,[r14+14]
       cmp       edx,[rcx+10]
       jae       near ptr M00_L17
       mov       rcx,[rcx+8]
       mov       edx,[r14+14]
       cmp       edx,[rcx+8]
       jae       near ptr M00_L35
       mov       rdx,[rcx+rdx*8+10]
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [r14+14]
       mov       r14,[r13+10]
M00_L05:
       cmp       qword ptr [r15+8],0
       je        near ptr M00_L19
M00_L06:
       mov       r12,[r15+10]
       mov       rax,[r15+18]
       xor       r8d,r8d
       mov       [rbp-3C],r8d
       test      r14,r14
       je        near ptr M00_L20
       mov       rcx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       [rbp-88],rax
       cmp       [rax],rcx
       jne       near ptr M00_L28
       mov       rax,[rbp-88]
       mov       rdx,[r14+28]
       test      rdx,rdx
       je        near ptr M00_L21
       mov       rcx,140DB800068
       mov       rcx,[rcx]
       mov       r10,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],r10
       jne       near ptr M00_L27
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       r10d,561E8E0
       mov       r9d,2650AF6E
       cmp       edx,8
       jb        near ptr M00_L22
       mov       r11d,edx
       shr       r11d,3
M00_L07:
       add       r10d,[rcx]
       mov       esi,[rcx+4]
       xor       r9d,r10d
       rol       r10d,14
       add       r10d,r9d
       rol       r9d,9
       xor       r9d,r10d
       rol       r10d,1B
       add       r10d,r9d
       rol       r9d,13
       add       esi,r10d
       mov       r10d,r9d
       xor       r10d,esi
       rol       esi,14
       add       esi,r10d
       rol       r10d,9
       xor       r10d,esi
       rol       esi,1B
       add       esi,r10d
       rol       r10d,13
       mov       r9d,esi
       add       rcx,8
       dec       r11d
       mov       r8d,r9d
       mov       r9d,r10d
       mov       r10d,r8d
       jne       short M00_L07
       test      dl,4
       jne       near ptr M00_L23
M00_L08:
       mov       r11d,edx
       and       r11,7
       mov       ecx,[rcx+r11-4]
       shr       ecx,8
       or        ecx,80000000
       not       edx
       shl       edx,3
       shrx      ecx,ecx,edx
M00_L09:
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
       mov       r10d,ecx
       rol       r10d,14
       add       r10d,edx
       rol       edx,9
       xor       edx,r10d
       rol       r10d,1B
       add       r10d,edx
       mov       r9d,edx
       rol       r9d,13
       xor       r10d,r9d
M00_L10:
       mov       [rbp-40],r10d
       mov       rdx,[r15+8]
       mov       ecx,r10d
       imul      rcx,[r15+20]
       shr       rcx,20
       inc       rcx
       mov       r11d,[rdx+8]
       imul      rcx,r11
       shr       rcx,20
       cmp       ecx,[rdx+8]
       jae       near ptr M00_L35
       mov       ecx,ecx
       lea       r9,[rdx+rcx*4+10]
       mov       [rbp-90],r9
       mov       r11d,[r9]
       dec       r11d
       jns       near ptr M00_L14
M00_L11:
       cmp       dword ptr [r15+30],0
       jg        near ptr M00_L16
       mov       edx,[r15+28]
       mov       [rbp-44],edx
       cmp       [r12+8],edx
       je        near ptr M00_L30
M00_L12:
       mov       edx,[rbp-44]
       mov       r12d,edx
       lea       ecx,[r12+1]
       mov       [r15+28],ecx
       mov       rcx,[r15+10]
       mov       r11,rcx
       mov       [rbp-88],rax
M00_L13:
       cmp       r12d,[r11+8]
       jae       near ptr M00_L35
       mov       ecx,r12d
       shl       rcx,4
       mov       [rbp-80],r11
       lea       rcx,[r11+rcx+10]
       mov       [rcx+8],r10d
       mov       r9,[rbp-90]
       mov       edx,[r9]
       dec       edx
       mov       [rcx+0C],edx
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       inc       r12d
       mov       rdx,[rbp-90]
       mov       [rdx],r12d
       inc       dword ptr [r15+34]
       cmp       dword ptr [rbp-3C],64
       jbe       near ptr M00_L04
       jmp       near ptr M00_L31
M00_L14:
       cmp       r11d,[r12+8]
       jae       near ptr M00_L35
       mov       edx,r11d
       shl       rdx,4
       lea       r11,[r12+rdx+10]
       mov       [rbp-98],r11
       cmp       [r11+8],r10d
       je        near ptr M00_L29
M00_L15:
       mov       r11d,[r11+0C]
       mov       r8d,[rbp-3C]
       inc       r8d
       mov       [rbp-3C],r8d
       cmp       [r12+8],r8d
       jb        near ptr M00_L33
       test      r11d,r11d
       mov       r10d,[rbp-40]
       jge       short M00_L14
       jmp       near ptr M00_L11
M00_L16:
       mov       ecx,[r15+2C]
       mov       r11d,ecx
       dec       dword ptr [r15+30]
       cmp       ecx,[r12+8]
       jae       near ptr M00_L35
       shl       rcx,4
       mov       ecx,[r12+rcx+1C]
       neg       ecx
       add       ecx,0FFFFFFFD
       mov       [r15+2C],ecx
       mov       [rbp-88],rax
       mov       ecx,r11d
       mov       r11,r12
       mov       r12d,ecx
       jmp       near ptr M00_L13
M00_L17:
       xor       eax,eax
       mov       [r14+8],rax
       mov       dword ptr [r14+14],0FFFFFFFF
       jmp       near ptr M00_L36
M00_L18:
       mov       rcx,r13
       mov       r11,7FFCFC721D60
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L05
M00_L19:
       mov       rcx,r15
       xor       edx,edx
       call      qword ptr [7FFCFCAA71B0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       jmp       near ptr M00_L06
M00_L20:
       xor       r10d,r10d
       jmp       near ptr M00_L10
M00_L21:
       xor       r10d,r10d
       jmp       near ptr M00_L10
M00_L22:
       cmp       edx,4
       jb        short M00_L24
M00_L23:
       add       r10d,[rcx]
       xor       r9d,r10d
       rol       r10d,14
       add       r10d,r9d
       rol       r9d,9
       xor       r9d,r10d
       rol       r10d,1B
       add       r10d,r9d
       rol       r9d,13
       jmp       near ptr M00_L08
M00_L24:
       mov       r11d,80
       test      dl,1
       je        short M00_L25
       mov       r11d,edx
       and       r11,2
       movzx     r11d,byte ptr [rcx+r11]
       or        r11d,8000
M00_L25:
       test      dl,2
       je        short M00_L26
       shl       r11d,10
       movzx     ecx,word ptr [rcx]
       or        r11d,ecx
       mov       ecx,r11d
       jmp       near ptr M00_L09
M00_L26:
       mov       ecx,r11d
       jmp       near ptr M00_L09
M00_L27:
       mov       [rbp-88],rax
       mov       r10,[rcx]
       mov       r10,[r10+48]
       call      qword ptr [r10+18]
       mov       r10d,eax
       mov       rax,[rbp-88]
       jmp       near ptr M00_L10
M00_L28:
       mov       rax,[rbp-88]
       mov       [rbp-88],rax
       mov       rcx,rax
       mov       rdx,r14
       mov       r11,7FFCFC721D70
       call      qword ptr [r11]
       mov       r10d,eax
       mov       rax,[rbp-88]
       jmp       near ptr M00_L10
M00_L29:
       mov       rdx,[r11]
       mov       [rbp-88],rax
       mov       rcx,rax
       mov       r8,r14
       mov       r11,7FFCFC721D78
       call      qword ptr [r11]
       test      eax,eax
       mov       rax,[rbp-88]
       mov       r11,[rbp-98]
       jne       near ptr M00_L04
       jmp       near ptr M00_L15
M00_L30:
       mov       [rbp-88],rax
       mov       rcx,r15
       call      qword ptr [7FFCFD1AF138]
       mov       rcx,[r15+8]
       mov       r12d,[rbp-40]
       mov       edx,r12d
       imul      rdx,[r15+20]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       imul      rdx,rax
       shr       rdx,20
       cmp       edx,[rcx+8]
       jae       near ptr M00_L35
       mov       edx,edx
       lea       r9,[rcx+rdx*4+10]
       mov       rax,r9
       mov       [rbp-90],rax
       mov       r10d,r12d
       mov       rax,[rbp-88]
       jmp       near ptr M00_L12
M00_L31:
       mov       rdx,[rbp-88]
       mov       r12,[rbp-80]
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M00_L04
       mov       edx,[r12+8]
       mov       rcx,r15
       mov       r8d,1
       call      qword ptr [7FFCFCC8D608]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,r15
       mov       rdx,r14
       call      qword ptr [7FFCFCAA7270]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       jmp       near ptr M00_L04
M00_L32:
       mov       rcx,r13
       mov       r11,7FFCFC721D58
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L18
       jmp       near ptr M00_L59
M00_L33:
       call      qword ptr [7FFCFC7DF480]
       int       3
M00_L34:
       call      qword ptr [7FFCFC7DFC48]
       int       3
M00_L35:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L36:
       mov       ecx,[r15+28]
       test      ecx,ecx
       jle       short M00_L37
       mov       rax,[r15+10]
       mov       eax,[rax+8]
       xor       edx,edx
       div       ecx
       cmp       eax,3
       jg        near ptr M00_L60
M00_L37:
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rdi],rcx
       jne       near ptr M00_L62
       cmp       dword ptr [rdi+10],0
       je        near ptr M00_L61
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       r13d,[rdi+14]
       lea       rcx,[r14+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r14+10],rcx
       mov       [r14+18],r13d
       mov       [r14+1C],ecx
M00_L38:
       mov       [rbp-68],r14
       cmp       qword ptr [rbp-68],0
       je        short M00_L42
       mov       r14,[rbp-68]
       mov       rdi,[r14]
       mov       rdx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rdi,rdx
       jne       short M00_L42
M00_L39:
       mov       rdx,rdi
       lea       rcx,[r14+8]
       cmp       [rcx],ecx
       call      qword ptr [7FFCFCB9C0D8]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       je        near ptr M00_L51
       mov       r13,[r14+10]
       lea       r8,[rbp-50]
       mov       rcx,r15
       mov       rdx,r13
       call      qword ptr [7FFCFCAA7228]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
       test      eax,eax
       je        short M00_L39
       jmp       short M00_L44
M00_L40:
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rdi,rcx
       jne       near ptr M00_L47
       mov       r13,[r14+10]
M00_L41:
       lea       r8,[rbp-50]
       mov       rcx,r15
       mov       rdx,r13
       call      qword ptr [7FFCFCAA7228]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
       test      eax,eax
       jne       near ptr M00_L48
M00_L42:
       mov       r14,[rbp-68]
       mov       rdi,[r14]
       mov       rdx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rdi,rdx
       jne       short M00_L46
       mov       rdx,rdi
       lea       rcx,[r14+8]
       cmp       [rcx],ecx
       call      qword ptr [7FFCFCB9C0D8]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L43:
       test      eax,eax
       jne       short M00_L40
       jmp       near ptr M00_L51
M00_L44:
       mov       rsi,[rbp-60]
       inc       dword ptr [rsi+14]
       mov       r12,[rsi+8]
       mov       eax,[rsi+10]
       cmp       [r12+8],eax
       jbe       short M00_L45
       lea       ecx,[rax+1]
       mov       [rsi+10],ecx
       cmp       eax,[r12+8]
       jae       near ptr M00_L50
       mov       ecx,eax
       lea       rcx,[r12+rcx*8+10]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L39
M00_L45:
       mov       rcx,rsi
       mov       rdx,r13
       call      qword ptr [7FFCFC7D71C8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M00_L39
M00_L46:
       mov       rcx,r14
       mov       r11,7FFCFC721D30
       call      qword ptr [r11]
       jmp       short M00_L43
M00_L47:
       mov       rcx,r14
       mov       r11,7FFCFC721D38
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M00_L41
M00_L48:
       mov       rsi,[rbp-60]
       inc       dword ptr [rsi+14]
       mov       r12,[rsi+8]
       mov       eax,[rsi+10]
       cmp       [r12+8],eax
       ja        short M00_L49
       mov       rcx,rsi
       mov       rdx,r13
       call      qword ptr [7FFCFC7D71C8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M00_L42
M00_L49:
       lea       ecx,[rax+1]
       mov       [rsi+10],ecx
       cmp       eax,[r12+8]
       jae       short M00_L50
       mov       ecx,eax
       lea       rcx,[r12+rcx*8+10]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L42
M00_L50:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L51:
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rdi,rcx
       jne       near ptr M00_L63
M00_L52:
       mov       rsi,[rbp-60]
       mov       [rbp-58],rsi
       mov       rcx,[rbx+60]
       lea       r8,[rbp-58]
       mov       rdx,7FFCFD1659E8
       cmp       [rcx],ecx
       call      qword ptr [7FFCFD0EE928]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
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
M00_L53:
       call      qword ptr [7FFCFCEAE418]
       mov       ecx,69E
       mov       rdx,7FFCFCD06050
       call      qword ptr [7FFCFC7DF210]
       mov       rbx,rax
       mov       ecx,1B61
       mov       rdx,7FFCFCBD5618
       call      qword ptr [7FFCFC7DF210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCFC7DD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFCFCD06050
       call      qword ptr [7FFCFC7DF210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCFC7DD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCFD0E4168]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCFD0E4180]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L54:
       call      qword ptr [7FFCFCEAE418]
       mov       ecx,0B5
       mov       rdx,7FFCFCD06050
       call      qword ptr [7FFCFC7DF210]
       mov       r14,rax
       mov       ecx,1B61
       mov       rdx,7FFCFCBD5618
       call      qword ptr [7FFCFC7DF210]
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFCFC7DD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFCFCD06050
       call      qword ptr [7FFCFC7DF210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCFC7DD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCFD0E4168]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCFD0E4180]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L55:
       mov       r8,r13
       mov       rdx,r15
       mov       rcx,offset MT_System.Collections.Generic.HashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFCFD317600]
       test      eax,eax
       je        near ptr M00_L00
       mov       rcx,r15
       mov       rdx,r13
       call      qword ptr [7FFCFD317270]
       jmp       near ptr M00_L37
M00_L56:
       mov       rcx,r14
       mov       r11,7FFCFC721D48
       call      qword ptr [r11]
       mov       ecx,eax
       jmp       near ptr M00_L01
M00_L57:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,140DB802D28
       mov       r13,[rcx]
       jmp       near ptr M00_L03
M00_L58:
       mov       rcx,r14
       mov       r11,7FFCFC721D50
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M00_L03
M00_L59:
       mov       rcx,r13
       mov       r11,7FFCFC721D68
       call      qword ptr [r11]
       jmp       near ptr M00_L36
M00_L60:
       mov       edx,ecx
       sub       edx,[r15+30]
       mov       rcx,r15
       call      qword ptr [7FFCFD317288]
       jmp       near ptr M00_L37
M00_L61:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,140DB802D28
       mov       r14,[rcx]
       jmp       near ptr M00_L38
M00_L62:
       mov       rcx,rdi
       mov       r11,7FFCFC721D28
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L38
M00_L63:
       mov       rcx,r14
       mov       r11,7FFCFC721D40
       call      qword ptr [r11]
       jmp       near ptr M00_L52
       sub       rsp,28
       cmp       qword ptr [rbp-68],0
       je        short M00_L64
       mov       r14,[rbp-68]
       mov       rdi,[r14]
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rdi,rcx
       je        short M00_L64
       mov       rcx,r14
       mov       r11,7FFCFC721D40
       call      qword ptr [r11]
M00_L64:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       qword ptr [rbp-78],0
       je        short M00_L65
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-78]
       cmp       [rax],rcx
       je        short M00_L65
       mov       rcx,rax
       mov       r11,7FFCFC721D68
       call      qword ptr [r11]
M00_L65:
       nop
       add       rsp,28
       ret
; Total bytes of code 2886
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
       mov       rcx,7FFD59B31390
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
       call      qword ptr [7FFCFD1A6748]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCFCC85B18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M02_L03:
       mov       esi,ebx
       or        esi,1
       jmp       short M02_L06
M02_L04:
       mov       ecx,esi
       call      qword ptr [7FFCFD1A6760]
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
; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       ecx,edx
       call      qword ptr [7FFCFC7D5A88]; System.Collections.HashHelpers.GetPrime(Int32)
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
       mov       rdx,7FFCFD29B768
       call      qword ptr [7FFCFC7DF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M03_L00
; Total bytes of code 170
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
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       esi,edx
       mov       edi,r8d
       mov       rcx,[rbx]
       call      qword ptr [7FFD5A79BEB0]
       mov       rcx,rax
       movsxd    rdx,esi
       call      qword ptr [7FFD5A798070]; CORINFO_HELP_NEWARR_1_DIRECT
       mov       rbp,rax
       mov       r14d,[rbx+28]
       mov       rcx,[rbx+10]
       mov       rdx,rbp
       mov       r8d,r14d
       call      qword ptr [7FFD5A7A9378]; Precode of System.Array.Copy(System.Array, System.Array, Int32)
       movzx     ecx,dil
       test      cl,1
       jne       near ptr M04_L06
M04_L00:
       movsxd    rcx,esi
       call      qword ptr [7FFD5A7A5BF0]
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      qword ptr [7FFD5A797FD0]; CORINFO_HELP_ASSIGN_REF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,esi
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rbx+20],rax
       xor       ecx,ecx
       test      r14d,r14d
       jle       short M04_L03
       cmp       [rbp+8],r14d
       jl        near ptr M04_L04
M04_L01:
       mov       edx,ecx
       shl       rdx,4
       lea       rdx,[rbp+rdx+10]
       cmp       dword ptr [rdx+0C],0FFFFFFFF
       jl        short M04_L02
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
       jae       near ptr M04_L11
       mov       r10d,r10d
       lea       rax,[r8+r10*4+10]
       mov       r8d,[rax]
       dec       r8d
       mov       [rdx+0C],r8d
       lea       edx,[rcx+1]
       mov       [rax],edx
M04_L02:
       inc       ecx
       cmp       ecx,r14d
       jl        short M04_L01
M04_L03:
       lea       rcx,[rbx+10]
       mov       rdx,rbp
       call      qword ptr [7FFD5A797FD0]; CORINFO_HELP_ASSIGN_REF
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
M04_L04:
       cmp       ecx,[rbp+8]
       jae       near ptr M04_L11
       mov       eax,ecx
       shl       rax,4
       lea       rdx,[rbp+rax+10]
       cmp       dword ptr [rdx+0C],0FFFFFFFF
       jl        short M04_L05
       mov       eax,[rdx+8]
       mov       r8,[rbx+8]
       mov       r10d,eax
       imul      r10,[rbx+20]
       shr       r10,20
       inc       r10
       mov       eax,[r8+8]
       imul      r10,rax
       shr       r10,20
       cmp       r10d,[r8+8]
       jae       near ptr M04_L11
       mov       eax,r10d
       lea       rax,[r8+rax*4+10]
       mov       r8d,[rax]
       dec       r8d
       mov       [rdx+0C],r8d
       lea       edx,[rcx+1]
       mov       [rax],edx
M04_L05:
       inc       ecx
       cmp       ecx,r14d
       jl        short M04_L04
       jmp       near ptr M04_L03
M04_L06:
       mov       rcx,[rbx]
       call      qword ptr [7FFD5A79B4F0]
       mov       rdi,rax
       mov       rcx,[rbx+18]
       call      qword ptr [7FFD5A7A77D0]
       mov       rcx,rax
       lea       r11,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       [rcx],ecx
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFD5A798078]; Precode of System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdi,rax
       lea       rcx,[rbx+18]
       mov       rdx,rdi
       call      qword ptr [7FFD5A797FD0]; CORINFO_HELP_ASSIGN_REF
       xor       r15d,r15d
       cmp       r15d,r14d
       jge       near ptr M04_L00
M04_L07:
       cmp       r15d,[rbp+8]
       jae       short M04_L11
       mov       rcx,r15
       shl       rcx,4
       lea       r13,[rbp+rcx+10]
       cmp       dword ptr [r13+0C],0FFFFFFFF
       jl        short M04_L10
       cmp       qword ptr [r13],0
       jne       short M04_L08
       xor       r12d,r12d
       jmp       short M04_L09
M04_L08:
       mov       rcx,[rbx]
       call      qword ptr [7FFD5A79D148]
       mov       rdx,[r13]
       mov       rcx,rdi
       mov       r11,rax
       call      qword ptr [rax]
       mov       r12d,eax
M04_L09:
       mov       [r13+8],r12d
M04_L10:
       inc       r15d
       cmp       r15d,r14d
       jl        short M04_L07
       jmp       near ptr M04_L00
M04_L11:
       call      qword ptr [7FFD5A797FC0]
       int       3
; Total bytes of code 540
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
       je        near ptr M05_L06
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
       je        near ptr M05_L07
M05_L00:
       mov       rcx,offset MT_System.Collections.Generic.ObjectEqualityComparer<System.RuntimeType>
       cmp       [r14],rcx
       jne       near ptr M05_L13
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
       je        near ptr M05_L08
       mov       rcx,r15
       mov       rax,[r15]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
       mov       r15d,eax
M05_L02:
       xor       ecx,ecx
       mov       [rsp+30],rcx
M05_L03:
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
       js        short M05_L06
M05_L04:
       mov       r12d,[rdi+8]
       cmp       r13d,r12d
       jae       near ptr M05_L18
       mov       ecx,r13d
       shl       rcx,4
       lea       rax,[rdi+rcx+10]
       mov       [rsp+28],rax
       cmp       [rax+8],r15d
       je        near ptr M05_L14
M05_L05:
       mov       rax,[rsp+28]
       mov       r13d,[rax+0C]
       inc       ebp
       cmp       r12d,ebp
       jb        near ptr M05_L17
       test      r13d,r13d
       jge       short M05_L04
M05_L06:
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
M05_L07:
       mov       rdx,7FFCFD207948
       call      qword ptr [7FFCFC7DF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M05_L00
M05_L08:
       mov       rcx,r15
       call      00007FFD5C3C6270
       test      eax,eax
       je        short M05_L10
       mov       r15d,eax
M05_L09:
       jmp       near ptr M05_L02
M05_L10:
       mov       rcx,r15
       call      qword ptr [7FFCFCAA7258]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       mov       r15d,eax
       jmp       short M05_L09
M05_L11:
       xor       r15d,r15d
       jmp       near ptr M05_L03
M05_L12:
       xor       r15d,r15d
       jmp       near ptr M05_L02
M05_L13:
       mov       rcx,r14
       mov       rdx,rsi
       call      qword ptr [r11]
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
       mov       rdx,7FFCFD207960
       call      qword ptr [7FFCFC7DF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M05_L16:
       mov       rax,[rsp+28]
       mov       rdx,[rax]
       mov       rcx,r14
       mov       r8,rsi
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M05_L05
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
       call      qword ptr [7FFCFC7DF480]
       int       3
M05_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 543
```
```assembly
; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx]
       mov       rdx,rcx
       mov       eax,[rbx+10]
       cmp       eax,[rcx+14]
       jne       short M06_L01
       mov       ecx,[rbx+14]
       cmp       ecx,[rdx+10]
       jae       short M06_L00
       mov       rdx,[rdx+8]
       cmp       ecx,[rdx+8]
       jae       short M06_L02
       mov       ecx,ecx
       mov       rdx,[rdx+rcx*8+10]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       dword ptr [rbx+14]
       mov       eax,1
       add       rsp,20
       pop       rbx
       ret
M06_L00:
       xor       eax,eax
       mov       [rbx+8],rax
       mov       dword ptr [rbx+14],0FFFFFFFF
       add       rsp,20
       pop       rbx
       ret
M06_L01:
       call      qword ptr [7FFCFC7DFC48]
       int       3
M06_L02:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 101
```
```assembly
; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
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
       mov       rdi,r8
       cmp       qword ptr [rbx+8],0
       je        near ptr M07_L13
M07_L00:
       mov       rbp,[rbx+10]
       mov       r14,[rbx+18]
       xor       r15d,r15d
       test      rsi,rsi
       je        near ptr M07_L14
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+78]
       test      r11,r11
       je        near ptr M07_L12
M07_L01:
       mov       rcx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r14],rcx
       jne       near ptr M07_L22
       mov       rdx,[rsi+28]
       test      rdx,rdx
       je        near ptr M07_L15
       mov       rcx,140DB800068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M07_L21
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,561E8E0
       mov       r8d,2650AF6E
       cmp       edx,8
       jb        near ptr M07_L16
       mov       r10d,edx
       shr       r10d,3
M07_L02:
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
       jne       short M07_L02
       test      dl,4
       jne       near ptr M07_L17
M07_L03:
       mov       r10d,edx
       and       r10,7
       mov       ecx,[rcx+r10-4]
       shr       ecx,8
       or        ecx,80000000
       not       edx
       shl       edx,3
       shrx      ecx,ecx,edx
M07_L04:
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
M07_L05:
       mov       rcx,[rbx+8]
       mov       edx,r13d
       imul      rdx,[rbx+20]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       mov       r8d,eax
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,eax
       jae       near ptr M07_L30
       mov       edx,edx
       lea       r12,[rcx+rdx*4+10]
       mov       eax,[r12]
       dec       eax
       jns       near ptr M07_L10
M07_L06:
       cmp       dword ptr [rbx+30],0
       jg        near ptr M07_L27
       mov       eax,[rbx+28]
       mov       [rsp+38],eax
       cmp       [rbp+8],eax
       je        near ptr M07_L28
M07_L07:
       mov       eax,[rsp+38]
       mov       ebp,eax
       lea       ecx,[rbp+1]
       mov       [rbx+28],ecx
       mov       rcx,[rbx+10]
       mov       rax,rcx
M07_L08:
       cmp       ebp,[rax+8]
       jae       near ptr M07_L30
       mov       ecx,ebp
       shl       rcx,4
       mov       [rsp+30],rax
       lea       rcx,[rax+rcx+10]
       mov       [rcx+8],r13d
       mov       edx,[r12]
       dec       edx
       mov       [rcx+0C],edx
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       lea       edx,[rbp+1]
       mov       [r12],edx
       inc       dword ptr [rbx+34]
       mov       [rdi],ebp
       cmp       r15d,64
       ja        near ptr M07_L29
M07_L09:
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
M07_L10:
       cmp       eax,[rbp+8]
       jae       near ptr M07_L30
       mov       [rsp+3C],eax
       mov       ecx,eax
       shl       rcx,4
       lea       r8,[rbp+rcx+10]
       mov       [rsp+28],r8
       cmp       [r8+8],r13d
       je        near ptr M07_L23
M07_L11:
       mov       r8,[rsp+28]
       mov       eax,[r8+0C]
       inc       r15d
       cmp       [rbp+8],r15d
       jb        near ptr M07_L26
       test      eax,eax
       jge       short M07_L10
       jmp       near ptr M07_L06
M07_L12:
       mov       rdx,7FFCFD207948
       call      qword ptr [7FFCFC7DF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M07_L01
M07_L13:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFCFCAA71B0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       jmp       near ptr M07_L00
M07_L14:
       xor       r13d,r13d
       jmp       near ptr M07_L05
M07_L15:
       xor       r13d,r13d
       jmp       near ptr M07_L05
M07_L16:
       cmp       edx,4
       jb        short M07_L18
M07_L17:
       add       eax,[rcx]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       jmp       near ptr M07_L03
M07_L18:
       mov       r10d,80
       test      dl,1
       je        short M07_L19
       mov       r10d,edx
       and       r10,2
       movzx     r10d,byte ptr [rcx+r10]
       or        r10d,8000
M07_L19:
       test      dl,2
       je        short M07_L20
       shl       r10d,10
       movzx     ecx,word ptr [rcx]
       or        r10d,ecx
       mov       ecx,r10d
       jmp       near ptr M07_L04
M07_L20:
       mov       ecx,r10d
       jmp       near ptr M07_L04
M07_L21:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       r13d,eax
       jmp       near ptr M07_L05
M07_L22:
       mov       rcx,r14
       mov       rdx,rsi
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       near ptr M07_L05
M07_L23:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+80]
       test      r11,r11
       je        short M07_L24
       jmp       short M07_L25
M07_L24:
       mov       rdx,7FFCFD207960
       call      qword ptr [7FFCFC7DF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M07_L25:
       mov       rax,[rsp+28]
       mov       rdx,[rax]
       mov       rcx,r14
       mov       r8,rsi
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M07_L11
       mov       eax,[rsp+3C]
       mov       [rdi],eax
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
M07_L26:
       call      qword ptr [7FFCFC7DF480]
       int       3
M07_L27:
       mov       ecx,[rbx+2C]
       mov       eax,ecx
       dec       dword ptr [rbx+30]
       cmp       ecx,[rbp+8]
       jae       near ptr M07_L30
       shl       rcx,4
       mov       ecx,[rbp+rcx+1C]
       neg       ecx
       add       ecx,0FFFFFFFD
       mov       [rbx+2C],ecx
       mov       ecx,eax
       mov       rax,rbp
       mov       ebp,ecx
       jmp       near ptr M07_L08
M07_L28:
       mov       rcx,rbx
       call      qword ptr [7FFCFD1AF138]
       mov       rcx,[rbx+8]
       mov       edx,r13d
       imul      rdx,[rbx+20]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       imul      rdx,rax
       shr       rdx,20
       cmp       edx,[rcx+8]
       jae       short M07_L30
       mov       edx,edx
       lea       r12,[rcx+rdx*4+10]
       jmp       near ptr M07_L07
M07_L29:
       mov       rdx,r14
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M07_L09
       mov       rbp,[rsp+30]
       mov       edx,[rbp+8]
       mov       rcx,rbx
       mov       r8d,1
       call      qword ptr [7FFCFCC8D608]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFCFCAA7270]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       mov       [rdi],eax
       jmp       near ptr M07_L09
M07_L30:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1100
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,[rbx+10]
       mov       ebp,edi
       lea       ecx,[rbp+1]
       mov       rdx,[rbx+8]
       cmp       dword ptr [rdx+8],0
       jne       short M08_L01
       mov       r14d,4
M08_L00:
       mov       edx,7FFFFFC7
       cmp       r14d,7FFFFFC7
       cmova     r14d,edx
       cmp       r14d,ecx
       cmovl     r14d,ecx
       cmp       r14d,edi
       jge       short M08_L02
       mov       ecx,7
       mov       edx,0F
       call      qword ptr [7FFCFCEA6028]
       int       3
M08_L01:
       mov       rdx,[rbx+8]
       mov       r14d,[rdx+8]
       add       r14d,r14d
       jmp       short M08_L00
M08_L02:
       mov       rcx,[rbx+8]
       cmp       [rcx+8],r14d
       je        near ptr M08_L08
       test      r14d,r14d
       jg        short M08_L05
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+0B8]
       test      rdx,rdx
       je        short M08_L04
M08_L03:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M08_L08
M08_L04:
       mov       rdx,7FFCFD207CC8
       call      qword ptr [7FFCFC7DF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       short M08_L03
M08_L05:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+0B0]
       test      rax,rax
       je        short M08_L09
       mov       rcx,rax
M08_L06:
       mov       edx,r14d
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       test      edi,edi
       jle       short M08_L07
       mov       rcx,[rbx+8]
       mov       r8d,edi
       mov       rdx,r14
       call      qword ptr [7FFCFC7DF588]; System.Array.Copy(System.Array, System.Array, Int32)
M08_L07:
       lea       rcx,[rbx+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
M08_L08:
       lea       ecx,[rbp+1]
       mov       [rbx+10],ecx
       mov       rcx,[rbx+8]
       movsxd    rdx,ebp
       mov       r8,rsi
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M08_L09:
       mov       rdx,7FFCFD1D1708
       call      qword ptr [7FFCFC7DF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M08_L06
; Total bytes of code 309
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
       je        near ptr M10_L00
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M10_L00
       test      rbx,rbx
       je        near ptr M10_L03
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        near ptr M10_L03
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M10_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFD5C418D20
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFCFC7D5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFCFC7D5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M10_L00:
       test      rbx,rbx
       je        short M10_L01
       mov       ebp,[rbx+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M10_L02
M10_L01:
       mov       rax,181708C0008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M10_L02:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M10_L03:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M10_L04:
       call      qword ptr [7FFCFD1A7DE0]
       int       3
; Total bytes of code 235
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
       jmp       qword ptr [7FFCFC7D5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsAddRemoveCollectionBenchmark.AddRangeIfNotExists()
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
       mov       [rbp-50],rax
       mov       [rbp-58],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       [rbp-60],rsi
       mov       rdi,[rbx+280]
       test      rsi,rsi
       je        near ptr M00_L53
       mov       r14,rsi
       test      rdi,rdi
       je        near ptr M00_L54
       mov       rcx,offset MT_System.Collections.Generic.HashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,2BA5DC00AE0
       mov       rdx,[rcx]
       lea       rcx,[r15+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,r14
       mov       rcx,offset MT_System.Collections.Generic.HashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r13,rax
       test      r13,r13
       jne       near ptr M00_L55
M00_L00:
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r14],rcx
       jne       near ptr M00_L56
       mov       ecx,[r14+10]
M00_L01:
       test      ecx,ecx
       jle       short M00_L02
       call      qword ptr [7FFCFC7D5A88]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       r13d,eax
       movsxd    rdx,r13d
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r12,rax
       movsxd    rdx,r13d
       mov       rcx,offset MT_System.Collections.Generic.HashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Entry[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rbp-70],rax
       mov       dword ptr [r15+2C],0FFFFFFFF
       lea       rcx,[r15+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+10]
       mov       rdx,[rbp-70]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,r13d
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [r15+20],rax
M00_L02:
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r14],rcx
       jne       near ptr M00_L58
       cmp       dword ptr [r14+10],0
       je        near ptr M00_L57
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       r12d,[r14+14]
       lea       rcx,[r13+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r13+10],rcx
       mov       [r13+18],r12d
       mov       [r13+1C],ecx
M00_L03:
       mov       [rbp-78],r13
M00_L04:
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       r13,[rbp-78]
       cmp       [r13],rcx
       jne       near ptr M00_L32
       lea       r14,[r13+8]
       mov       rcx,[r14]
       mov       edx,[r14+10]
       mov       rax,[r14]
       cmp       edx,[rax+14]
       jne       near ptr M00_L34
       mov       edx,[r14+14]
       cmp       edx,[rcx+10]
       jae       near ptr M00_L17
       mov       rcx,[rcx+8]
       mov       edx,[r14+14]
       cmp       edx,[rcx+8]
       jae       near ptr M00_L35
       mov       rdx,[rcx+rdx*8+10]
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [r14+14]
       mov       r14,[r13+10]
M00_L05:
       cmp       qword ptr [r15+8],0
       je        near ptr M00_L19
M00_L06:
       mov       r12,[r15+10]
       mov       rax,[r15+18]
       xor       r8d,r8d
       mov       [rbp-3C],r8d
       test      r14,r14
       je        near ptr M00_L14
       mov       rcx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       [rbp-88],rax
       cmp       [rax],rcx
       jne       near ptr M00_L27
       mov       rax,[rbp-88]
       mov       rdx,[r14+28]
       test      rdx,rdx
       je        near ptr M00_L20
       mov       rcx,2BA47C00068
       mov       rcx,[rcx]
       mov       r10,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],r10
       jne       near ptr M00_L26
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       r10d,2CC7B82C
       mov       r9d,57E68410
       cmp       edx,8
       jb        near ptr M00_L21
       mov       r11d,edx
       shr       r11d,3
M00_L07:
       add       r10d,[rcx]
       mov       esi,[rcx+4]
       xor       r9d,r10d
       rol       r10d,14
       add       r10d,r9d
       rol       r9d,9
       xor       r9d,r10d
       rol       r10d,1B
       add       r10d,r9d
       rol       r9d,13
       add       esi,r10d
       mov       r10d,r9d
       xor       r10d,esi
       rol       esi,14
       add       esi,r10d
       rol       r10d,9
       xor       r10d,esi
       rol       esi,1B
       add       esi,r10d
       rol       r10d,13
       mov       r9d,esi
       add       rcx,8
       dec       r11d
       mov       r8d,r9d
       mov       r9d,r10d
       mov       r10d,r8d
       jne       short M00_L07
       test      dl,4
       jne       near ptr M00_L22
M00_L08:
       mov       r11d,edx
       and       r11,7
       mov       ecx,[rcx+r11-4]
       shr       ecx,8
       or        ecx,80000000
       not       edx
       shl       edx,3
       shrx      ecx,ecx,edx
M00_L09:
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
       mov       r10d,ecx
       rol       r10d,14
       add       r10d,edx
       rol       edx,9
       xor       edx,r10d
       rol       r10d,1B
       add       r10d,edx
       mov       r9d,edx
       rol       r9d,13
       xor       r10d,r9d
M00_L10:
       mov       [rbp-40],r10d
       mov       rdx,[r15+8]
       mov       ecx,r10d
       imul      rcx,[r15+20]
       shr       rcx,20
       inc       rcx
       mov       r11d,[rdx+8]
       imul      rcx,r11
       shr       rcx,20
       cmp       ecx,[rdx+8]
       jae       near ptr M00_L35
       mov       ecx,ecx
       lea       r9,[rdx+rcx*4+10]
       mov       [rbp-90],r9
       mov       r11d,[r9]
       dec       r11d
       jns       near ptr M00_L15
M00_L11:
       cmp       dword ptr [r15+30],0
       jg        near ptr M00_L29
       mov       edx,[r15+28]
       mov       [rbp-44],edx
       cmp       [r12+8],edx
       je        near ptr M00_L30
M00_L12:
       mov       edx,[rbp-44]
       mov       r12d,edx
       lea       ecx,[r12+1]
       mov       [r15+28],ecx
       mov       rcx,[r15+10]
       mov       r11,rcx
       mov       [rbp-88],rax
M00_L13:
       cmp       r12d,[r11+8]
       jae       near ptr M00_L35
       mov       ecx,r12d
       shl       rcx,4
       mov       [rbp-80],r11
       lea       rcx,[r11+rcx+10]
       mov       [rcx+8],r10d
       mov       r9,[rbp-90]
       mov       edx,[r9]
       dec       edx
       mov       [rcx+0C],edx
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       inc       r12d
       mov       rdx,[rbp-90]
       mov       [rdx],r12d
       inc       dword ptr [r15+34]
       cmp       dword ptr [rbp-3C],64
       jbe       near ptr M00_L04
       jmp       near ptr M00_L31
M00_L14:
       xor       r10d,r10d
       jmp       near ptr M00_L10
M00_L15:
       cmp       r11d,[r12+8]
       jae       near ptr M00_L35
       mov       edx,r11d
       shl       rdx,4
       lea       r11,[r12+rdx+10]
       mov       [rbp-98],r11
       cmp       [r11+8],r10d
       je        near ptr M00_L28
M00_L16:
       mov       r11d,[r11+0C]
       mov       r8d,[rbp-3C]
       inc       r8d
       mov       [rbp-3C],r8d
       cmp       [r12+8],r8d
       jb        near ptr M00_L33
       test      r11d,r11d
       mov       r10d,[rbp-40]
       jge       short M00_L15
       jmp       near ptr M00_L11
M00_L17:
       xor       eax,eax
       mov       [r14+8],rax
       mov       dword ptr [r14+14],0FFFFFFFF
       jmp       near ptr M00_L36
M00_L18:
       mov       rcx,r13
       mov       r11,7FFCFC721E10
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L05
M00_L19:
       mov       rcx,r15
       xor       edx,edx
       call      qword ptr [7FFCFCAA71B0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       jmp       near ptr M00_L06
M00_L20:
       xor       r10d,r10d
       jmp       near ptr M00_L10
M00_L21:
       cmp       edx,4
       jb        short M00_L23
M00_L22:
       add       r10d,[rcx]
       xor       r9d,r10d
       rol       r10d,14
       add       r10d,r9d
       rol       r9d,9
       xor       r9d,r10d
       rol       r10d,1B
       add       r10d,r9d
       rol       r9d,13
       jmp       near ptr M00_L08
M00_L23:
       mov       r11d,80
       test      dl,1
       je        short M00_L24
       mov       r11d,edx
       and       r11,2
       movzx     r11d,byte ptr [rcx+r11]
       or        r11d,8000
M00_L24:
       test      dl,2
       je        short M00_L25
       shl       r11d,10
       movzx     ecx,word ptr [rcx]
       or        r11d,ecx
       mov       ecx,r11d
       jmp       near ptr M00_L09
M00_L25:
       mov       ecx,r11d
       jmp       near ptr M00_L09
M00_L26:
       mov       [rbp-88],rax
       mov       r10,[rcx]
       mov       r10,[r10+48]
       call      qword ptr [r10+18]
       mov       r10d,eax
       mov       rax,[rbp-88]
       jmp       near ptr M00_L10
M00_L27:
       mov       rax,[rbp-88]
       mov       [rbp-88],rax
       mov       rcx,rax
       mov       rdx,r14
       mov       r11,7FFCFC721E20
       call      qword ptr [r11]
       mov       r10d,eax
       mov       rax,[rbp-88]
       jmp       near ptr M00_L10
M00_L28:
       mov       rdx,[r11]
       mov       [rbp-88],rax
       mov       rcx,rax
       mov       r8,r14
       mov       r11,7FFCFC721E28
       call      qword ptr [r11]
       test      eax,eax
       mov       rax,[rbp-88]
       mov       r11,[rbp-98]
       jne       near ptr M00_L04
       jmp       near ptr M00_L16
M00_L29:
       mov       ecx,[r15+2C]
       mov       r11d,ecx
       dec       dword ptr [r15+30]
       cmp       ecx,[r12+8]
       jae       near ptr M00_L35
       shl       rcx,4
       mov       ecx,[r12+rcx+1C]
       neg       ecx
       add       ecx,0FFFFFFFD
       mov       [r15+2C],ecx
       mov       [rbp-88],rax
       mov       ecx,r11d
       mov       r11,r12
       mov       r12d,ecx
       jmp       near ptr M00_L13
M00_L30:
       mov       [rbp-88],rax
       mov       rcx,r15
       call      qword ptr [7FFCFD3943C0]
       mov       rcx,[r15+8]
       mov       r12d,[rbp-40]
       mov       edx,r12d
       imul      rdx,[r15+20]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       imul      rdx,rax
       shr       rdx,20
       cmp       edx,[rcx+8]
       jae       near ptr M00_L35
       mov       edx,edx
       lea       r9,[rcx+rdx*4+10]
       mov       rax,r9
       mov       [rbp-90],rax
       mov       r10d,r12d
       mov       rax,[rbp-88]
       jmp       near ptr M00_L12
M00_L31:
       mov       rdx,[rbp-88]
       mov       r12,[rbp-80]
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M00_L04
       mov       edx,[r12+8]
       mov       rcx,r15
       mov       r8d,1
       call      qword ptr [7FFCFCC8D638]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,r15
       mov       rdx,r14
       call      qword ptr [7FFCFCAA7270]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       jmp       near ptr M00_L04
M00_L32:
       mov       rcx,r13
       mov       r11,7FFCFC721E08
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L18
       jmp       near ptr M00_L59
M00_L33:
       call      qword ptr [7FFCFC7DF480]
       int       3
M00_L34:
       call      qword ptr [7FFCFC7DFC48]
       int       3
M00_L35:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L36:
       mov       ecx,[r15+28]
       test      ecx,ecx
       jle       short M00_L37
       mov       rax,[r15+10]
       mov       eax,[rax+8]
       xor       edx,edx
       div       ecx
       cmp       eax,3
       jg        near ptr M00_L60
M00_L37:
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rdi],rcx
       jne       near ptr M00_L62
       cmp       dword ptr [rdi+10],0
       je        near ptr M00_L61
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       r13d,[rdi+14]
       lea       rcx,[r14+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r14+10],rcx
       mov       [r14+18],r13d
       mov       [r14+1C],ecx
M00_L38:
       mov       [rbp-68],r14
       cmp       qword ptr [rbp-68],0
       je        short M00_L42
       mov       r14,[rbp-68]
       mov       rdi,[r14]
       mov       rdx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rdi,rdx
       jne       short M00_L42
M00_L39:
       mov       rdx,rdi
       lea       rcx,[r14+8]
       cmp       [rcx],ecx
       call      qword ptr [7FFCFCB9C9A8]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       je        near ptr M00_L51
       mov       r13,[r14+10]
       lea       r8,[rbp-50]
       mov       rcx,r15
       mov       rdx,r13
       call      qword ptr [7FFCFCAA7228]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
       test      eax,eax
       je        short M00_L39
       jmp       short M00_L44
M00_L40:
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rdi,rcx
       jne       near ptr M00_L47
       mov       r13,[r14+10]
M00_L41:
       lea       r8,[rbp-50]
       mov       rcx,r15
       mov       rdx,r13
       call      qword ptr [7FFCFCAA7228]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
       test      eax,eax
       jne       near ptr M00_L48
M00_L42:
       mov       r14,[rbp-68]
       mov       rdi,[r14]
       mov       rdx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rdi,rdx
       jne       short M00_L46
       mov       rdx,rdi
       lea       rcx,[r14+8]
       cmp       [rcx],ecx
       call      qword ptr [7FFCFCB9C9A8]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L43:
       test      eax,eax
       jne       short M00_L40
       jmp       near ptr M00_L51
M00_L44:
       mov       rsi,[rbp-60]
       inc       dword ptr [rsi+14]
       mov       r12,[rsi+8]
       mov       eax,[rsi+10]
       cmp       [r12+8],eax
       jbe       short M00_L45
       lea       ecx,[rax+1]
       mov       [rsi+10],ecx
       cmp       eax,[r12+8]
       jae       near ptr M00_L50
       mov       ecx,eax
       lea       rcx,[r12+rcx*8+10]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L39
M00_L45:
       mov       rcx,rsi
       mov       rdx,r13
       call      qword ptr [7FFCFC7D71C8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M00_L39
M00_L46:
       mov       rcx,r14
       mov       r11,7FFCFC721DE0
       call      qword ptr [r11]
       jmp       short M00_L43
M00_L47:
       mov       rcx,r14
       mov       r11,7FFCFC721DE8
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M00_L41
M00_L48:
       mov       rsi,[rbp-60]
       inc       dword ptr [rsi+14]
       mov       r12,[rsi+8]
       mov       eax,[rsi+10]
       cmp       [r12+8],eax
       ja        short M00_L49
       mov       rcx,rsi
       mov       rdx,r13
       call      qword ptr [7FFCFC7D71C8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M00_L42
M00_L49:
       lea       ecx,[rax+1]
       mov       [rsi+10],ecx
       cmp       eax,[r12+8]
       jae       short M00_L50
       mov       ecx,eax
       lea       rcx,[r12+rcx*8+10]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L42
M00_L50:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L51:
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rdi,rcx
       jne       near ptr M00_L63
M00_L52:
       mov       rsi,[rbp-60]
       mov       [rbp-58],rsi
       mov       rcx,[rbx+60]
       lea       r8,[rbp-58]
       mov       rdx,7FFCFD1DCC58
       cmp       [rcx],ecx
       call      qword ptr [7FFCFD1C4918]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
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
M00_L53:
       call      qword ptr [7FFCFCEAE958]
       mov       ecx,69E
       mov       rdx,7FFCFCD06050
       call      qword ptr [7FFCFC7DF210]
       mov       rbx,rax
       mov       ecx,1B61
       mov       rdx,7FFCFCBD5770
       call      qword ptr [7FFCFC7DF210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCFC7DD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFCFCD06050
       call      qword ptr [7FFCFC7DF210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCFC7DD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCFD0F4780]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCFD0F4798]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L54:
       call      qword ptr [7FFCFCEAE958]
       mov       ecx,0B5
       mov       rdx,7FFCFCD06050
       call      qword ptr [7FFCFC7DF210]
       mov       r14,rax
       mov       ecx,1B61
       mov       rdx,7FFCFCBD5770
       call      qword ptr [7FFCFC7DF210]
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFCFC7DD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFCFCD06050
       call      qword ptr [7FFCFC7DF210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCFC7DD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCFD0F4780]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCFD0F4798]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L55:
       mov       r8,r13
       mov       rdx,r15
       mov       rcx,offset MT_System.Collections.Generic.HashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFCFD3976C0]
       test      eax,eax
       je        near ptr M00_L00
       mov       rcx,r15
       mov       rdx,r13
       call      qword ptr [7FFCFD397690]
       jmp       near ptr M00_L37
M00_L56:
       mov       rcx,r14
       mov       r11,7FFCFC721DF8
       call      qword ptr [r11]
       mov       ecx,eax
       jmp       near ptr M00_L01
M00_L57:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,2BA5DC00D28
       mov       r13,[rcx]
       jmp       near ptr M00_L03
M00_L58:
       mov       rcx,r14
       mov       r11,7FFCFC721E00
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M00_L03
M00_L59:
       mov       rcx,r13
       mov       r11,7FFCFC721E18
       call      qword ptr [r11]
       jmp       near ptr M00_L36
M00_L60:
       mov       edx,ecx
       sub       edx,[r15+30]
       mov       rcx,r15
       call      qword ptr [7FFCFD3976A8]
       jmp       near ptr M00_L37
M00_L61:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,2BA5DC00D28
       mov       r14,[rcx]
       jmp       near ptr M00_L38
M00_L62:
       mov       rcx,rdi
       mov       r11,7FFCFC721DD8
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L38
M00_L63:
       mov       rcx,r14
       mov       r11,7FFCFC721DF0
       call      qword ptr [r11]
       jmp       near ptr M00_L52
       sub       rsp,28
       cmp       qword ptr [rbp-68],0
       je        short M00_L64
       mov       r14,[rbp-68]
       mov       rdi,[r14]
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rdi,rcx
       je        short M00_L64
       mov       rcx,r14
       mov       r11,7FFCFC721DF0
       call      qword ptr [r11]
M00_L64:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       qword ptr [rbp-78],0
       je        short M00_L65
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-78]
       cmp       [rax],rcx
       je        short M00_L65
       mov       rcx,rax
       mov       r11,7FFCFC721E18
       call      qword ptr [r11]
M00_L65:
       nop
       add       rsp,28
       ret
; Total bytes of code 2886
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
       mov       rcx,7FFD59B31390
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
       call      qword ptr [7FFCFD1C6760]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCFCC85B48]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M02_L03:
       mov       esi,ebx
       or        esi,1
       jmp       short M02_L06
M02_L04:
       mov       ecx,esi
       call      qword ptr [7FFCFD1C6778]
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
; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       ecx,edx
       call      qword ptr [7FFCFC7D5A88]; System.Collections.HashHelpers.GetPrime(Int32)
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
       mov       rdx,7FFCFD308B48
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M03_L00
; Total bytes of code 169
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
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       esi,edx
       mov       edi,r8d
       mov       rcx,[rbx]
       call      qword ptr [7FFD5A79BEB0]
       mov       rcx,rax
       movsxd    rdx,esi
       call      qword ptr [7FFD5A798070]; CORINFO_HELP_NEWARR_1_DIRECT
       mov       rbp,rax
       mov       r14d,[rbx+28]
       mov       rcx,[rbx+10]
       mov       rdx,rbp
       mov       r8d,r14d
       call      qword ptr [7FFD5A7A9378]; Precode of System.Array.Copy(System.Array, System.Array, Int32)
       movzx     ecx,dil
       test      cl,1
       jne       near ptr M04_L06
M04_L00:
       movsxd    rcx,esi
       call      qword ptr [7FFD5A7A5BF0]
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      qword ptr [7FFD5A797FD0]; CORINFO_HELP_ASSIGN_REF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,esi
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rbx+20],rax
       xor       ecx,ecx
       test      r14d,r14d
       jle       short M04_L03
       cmp       [rbp+8],r14d
       jl        near ptr M04_L04
M04_L01:
       mov       edx,ecx
       shl       rdx,4
       lea       rdx,[rbp+rdx+10]
       cmp       dword ptr [rdx+0C],0FFFFFFFF
       jl        short M04_L02
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
       jae       near ptr M04_L11
       mov       r10d,r10d
       lea       rax,[r8+r10*4+10]
       mov       r8d,[rax]
       dec       r8d
       mov       [rdx+0C],r8d
       lea       edx,[rcx+1]
       mov       [rax],edx
M04_L02:
       inc       ecx
       cmp       ecx,r14d
       jl        short M04_L01
M04_L03:
       lea       rcx,[rbx+10]
       mov       rdx,rbp
       call      qword ptr [7FFD5A797FD0]; CORINFO_HELP_ASSIGN_REF
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
M04_L04:
       cmp       ecx,[rbp+8]
       jae       near ptr M04_L11
       mov       eax,ecx
       shl       rax,4
       lea       rdx,[rbp+rax+10]
       cmp       dword ptr [rdx+0C],0FFFFFFFF
       jl        short M04_L05
       mov       eax,[rdx+8]
       mov       r8,[rbx+8]
       mov       r10d,eax
       imul      r10,[rbx+20]
       shr       r10,20
       inc       r10
       mov       eax,[r8+8]
       imul      r10,rax
       shr       r10,20
       cmp       r10d,[r8+8]
       jae       near ptr M04_L11
       mov       eax,r10d
       lea       rax,[r8+rax*4+10]
       mov       r8d,[rax]
       dec       r8d
       mov       [rdx+0C],r8d
       lea       edx,[rcx+1]
       mov       [rax],edx
M04_L05:
       inc       ecx
       cmp       ecx,r14d
       jl        short M04_L04
       jmp       near ptr M04_L03
M04_L06:
       mov       rcx,[rbx]
       call      qword ptr [7FFD5A79B4F0]
       mov       rdi,rax
       mov       rcx,[rbx+18]
       call      qword ptr [7FFD5A7A77D0]
       mov       rcx,rax
       lea       r11,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       [rcx],ecx
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFD5A798078]; Precode of System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdi,rax
       lea       rcx,[rbx+18]
       mov       rdx,rdi
       call      qword ptr [7FFD5A797FD0]; CORINFO_HELP_ASSIGN_REF
       xor       r15d,r15d
       cmp       r15d,r14d
       jge       near ptr M04_L00
M04_L07:
       cmp       r15d,[rbp+8]
       jae       short M04_L11
       mov       rcx,r15
       shl       rcx,4
       lea       r13,[rbp+rcx+10]
       cmp       dword ptr [r13+0C],0FFFFFFFF
       jl        short M04_L10
       cmp       qword ptr [r13],0
       jne       short M04_L08
       xor       r12d,r12d
       jmp       short M04_L09
M04_L08:
       mov       rcx,[rbx]
       call      qword ptr [7FFD5A79D148]
       mov       rdx,[r13]
       mov       rcx,rdi
       mov       r11,rax
       call      qword ptr [rax]
       mov       r12d,eax
M04_L09:
       mov       [r13+8],r12d
M04_L10:
       inc       r15d
       cmp       r15d,r14d
       jl        short M04_L07
       jmp       near ptr M04_L00
M04_L11:
       call      qword ptr [7FFD5A797FC0]
       int       3
; Total bytes of code 540
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
       je        near ptr M05_L06
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
       je        near ptr M05_L07
M05_L00:
       mov       rcx,offset MT_System.Collections.Generic.ObjectEqualityComparer<System.RuntimeType>
       cmp       [r14],rcx
       jne       near ptr M05_L13
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
       je        near ptr M05_L08
       mov       rcx,r15
       mov       rax,[r15]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
       mov       r15d,eax
M05_L02:
       xor       ecx,ecx
       mov       [rsp+30],rcx
M05_L03:
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
       js        short M05_L06
M05_L04:
       mov       r12d,[rdi+8]
       cmp       r13d,r12d
       jae       near ptr M05_L18
       mov       ecx,r13d
       shl       rcx,4
       lea       rax,[rdi+rcx+10]
       mov       [rsp+28],rax
       cmp       [rax+8],r15d
       je        near ptr M05_L14
M05_L05:
       mov       rax,[rsp+28]
       mov       r13d,[rax+0C]
       inc       ebp
       cmp       r12d,ebp
       jb        near ptr M05_L17
       test      r13d,r13d
       jge       short M05_L04
M05_L06:
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
M05_L07:
       mov       rdx,7FFCFD212D98
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M05_L00
M05_L08:
       mov       rcx,r15
       call      00007FFD5C3C6270
       test      eax,eax
       je        short M05_L10
       mov       r15d,eax
M05_L09:
       jmp       near ptr M05_L02
M05_L10:
       mov       rcx,r15
       call      qword ptr [7FFCFCAA7258]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       mov       r15d,eax
       jmp       short M05_L09
M05_L11:
       xor       r15d,r15d
       jmp       near ptr M05_L03
M05_L12:
       xor       r15d,r15d
       jmp       near ptr M05_L02
M05_L13:
       mov       rcx,r14
       mov       rdx,rsi
       call      qword ptr [r11]
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
       mov       rdx,7FFCFD212DB0
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M05_L16:
       mov       rax,[rsp+28]
       mov       rdx,[rax]
       mov       rcx,r14
       mov       r8,rsi
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M05_L05
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
       call      qword ptr [7FFCFC7DF480]
       int       3
M05_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 541
```
```assembly
; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx]
       mov       rdx,rcx
       mov       eax,[rbx+10]
       cmp       eax,[rcx+14]
       jne       short M06_L01
       mov       ecx,[rbx+14]
       cmp       ecx,[rdx+10]
       jae       short M06_L00
       mov       rdx,[rdx+8]
       cmp       ecx,[rdx+8]
       jae       short M06_L02
       mov       ecx,ecx
       mov       rdx,[rdx+rcx*8+10]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       dword ptr [rbx+14]
       mov       eax,1
       add       rsp,20
       pop       rbx
       ret
M06_L00:
       xor       eax,eax
       mov       [rbx+8],rax
       mov       dword ptr [rbx+14],0FFFFFFFF
       add       rsp,20
       pop       rbx
       ret
M06_L01:
       call      qword ptr [7FFCFC7DFC48]
       int       3
M06_L02:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 101
```
```assembly
; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
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
       mov       rdi,r8
       cmp       qword ptr [rbx+8],0
       je        near ptr M07_L14
M07_L00:
       mov       rbp,[rbx+10]
       mov       r14,[rbx+18]
       xor       r15d,r15d
       test      rsi,rsi
       je        near ptr M07_L10
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+78]
       test      r11,r11
       je        near ptr M07_L13
M07_L01:
       mov       rcx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r14],rcx
       jne       near ptr M07_L22
       mov       rdx,[rsi+28]
       test      rdx,rdx
       je        near ptr M07_L15
       mov       rcx,2BA47C00068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M07_L21
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,2CC7B82C
       mov       r8d,57E68410
       cmp       edx,8
       jb        near ptr M07_L16
       mov       r10d,edx
       shr       r10d,3
M07_L02:
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
       jne       short M07_L02
       test      dl,4
       jne       near ptr M07_L17
M07_L03:
       mov       r10d,edx
       and       r10,7
       mov       ecx,[rcx+r10-4]
       shr       ecx,8
       or        ecx,80000000
       not       edx
       shl       edx,3
       shrx      ecx,ecx,edx
M07_L04:
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
M07_L05:
       mov       rcx,[rbx+8]
       mov       edx,r13d
       imul      rdx,[rbx+20]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       mov       r8d,eax
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,eax
       jae       near ptr M07_L30
       mov       edx,edx
       lea       r12,[rcx+rdx*4+10]
       mov       eax,[r12]
       dec       eax
       jns       near ptr M07_L11
M07_L06:
       cmp       dword ptr [rbx+30],0
       jg        near ptr M07_L27
       mov       eax,[rbx+28]
       mov       [rsp+38],eax
       cmp       [rbp+8],eax
       je        near ptr M07_L28
M07_L07:
       mov       eax,[rsp+38]
       mov       ebp,eax
       lea       ecx,[rbp+1]
       mov       [rbx+28],ecx
       mov       rcx,[rbx+10]
       mov       rax,rcx
M07_L08:
       cmp       ebp,[rax+8]
       jae       near ptr M07_L30
       mov       ecx,ebp
       shl       rcx,4
       mov       [rsp+30],rax
       lea       rcx,[rax+rcx+10]
       mov       [rcx+8],r13d
       mov       edx,[r12]
       dec       edx
       mov       [rcx+0C],edx
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       lea       edx,[rbp+1]
       mov       [r12],edx
       inc       dword ptr [rbx+34]
       mov       [rdi],ebp
       cmp       r15d,64
       ja        near ptr M07_L29
M07_L09:
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
M07_L10:
       xor       r13d,r13d
       jmp       near ptr M07_L05
M07_L11:
       cmp       eax,[rbp+8]
       jae       near ptr M07_L30
       mov       [rsp+3C],eax
       mov       ecx,eax
       shl       rcx,4
       lea       r8,[rbp+rcx+10]
       mov       [rsp+28],r8
       cmp       [r8+8],r13d
       je        near ptr M07_L23
M07_L12:
       mov       r8,[rsp+28]
       mov       eax,[r8+0C]
       inc       r15d
       cmp       [rbp+8],r15d
       jb        near ptr M07_L26
       test      eax,eax
       jge       short M07_L11
       jmp       near ptr M07_L06
M07_L13:
       mov       rdx,7FFCFD212D98
       call      qword ptr [7FFCFC7DF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M07_L01
M07_L14:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFCFCAA71B0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       jmp       near ptr M07_L00
M07_L15:
       xor       r13d,r13d
       jmp       near ptr M07_L05
M07_L16:
       cmp       edx,4
       jb        short M07_L18
M07_L17:
       add       eax,[rcx]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       jmp       near ptr M07_L03
M07_L18:
       mov       r10d,80
       test      dl,1
       je        short M07_L19
       mov       r10d,edx
       and       r10,2
       movzx     r10d,byte ptr [rcx+r10]
       or        r10d,8000
M07_L19:
       test      dl,2
       je        short M07_L20
       shl       r10d,10
       movzx     ecx,word ptr [rcx]
       or        r10d,ecx
       mov       ecx,r10d
       jmp       near ptr M07_L04
M07_L20:
       mov       ecx,r10d
       jmp       near ptr M07_L04
M07_L21:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       r13d,eax
       jmp       near ptr M07_L05
M07_L22:
       mov       rcx,r14
       mov       rdx,rsi
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       near ptr M07_L05
M07_L23:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+80]
       test      r11,r11
       je        short M07_L24
       jmp       short M07_L25
M07_L24:
       mov       rdx,7FFCFD212DB0
       call      qword ptr [7FFCFC7DF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M07_L25:
       mov       rax,[rsp+28]
       mov       rdx,[rax]
       mov       rcx,r14
       mov       r8,rsi
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M07_L12
       mov       eax,[rsp+3C]
       mov       [rdi],eax
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
M07_L26:
       call      qword ptr [7FFCFC7DF480]
       int       3
M07_L27:
       mov       ecx,[rbx+2C]
       mov       eax,ecx
       dec       dword ptr [rbx+30]
       cmp       ecx,[rbp+8]
       jae       near ptr M07_L30
       shl       rcx,4
       mov       ecx,[rbp+rcx+1C]
       neg       ecx
       add       ecx,0FFFFFFFD
       mov       [rbx+2C],ecx
       mov       ecx,eax
       mov       rax,rbp
       mov       ebp,ecx
       jmp       near ptr M07_L08
M07_L28:
       mov       rcx,rbx
       call      qword ptr [7FFCFD3943C0]
       mov       rcx,[rbx+8]
       mov       edx,r13d
       imul      rdx,[rbx+20]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       imul      rdx,rax
       shr       rdx,20
       cmp       edx,[rcx+8]
       jae       short M07_L30
       mov       edx,edx
       lea       r12,[rcx+rdx*4+10]
       jmp       near ptr M07_L07
M07_L29:
       mov       rdx,r14
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M07_L09
       mov       rbp,[rsp+30]
       mov       edx,[rbp+8]
       mov       rcx,rbx
       mov       r8d,1
       call      qword ptr [7FFCFCC8D638]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFCFCAA7270]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       mov       [rdi],eax
       jmp       near ptr M07_L09
M07_L30:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1100
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,[rbx+10]
       mov       ebp,edi
       lea       ecx,[rbp+1]
       mov       rdx,[rbx+8]
       cmp       dword ptr [rdx+8],0
       jne       short M08_L01
       mov       r14d,4
M08_L00:
       mov       edx,7FFFFFC7
       cmp       r14d,7FFFFFC7
       cmova     r14d,edx
       cmp       r14d,ecx
       cmovl     r14d,ecx
       cmp       r14d,edi
       jge       short M08_L02
       mov       ecx,7
       mov       edx,0F
       call      qword ptr [7FFCFCEA6058]
       int       3
M08_L01:
       mov       rdx,[rbx+8]
       mov       r14d,[rdx+8]
       add       r14d,r14d
       jmp       short M08_L00
M08_L02:
       mov       rcx,[rbx+8]
       cmp       [rcx+8],r14d
       je        near ptr M08_L08
       test      r14d,r14d
       jg        short M08_L05
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+0B8]
       test      rdx,rdx
       je        short M08_L04
M08_L03:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M08_L08
M08_L04:
       mov       rdx,7FFCFD213118
       call      qword ptr [7FFCFC7DF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       short M08_L03
M08_L05:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+98]
       test      rax,rax
       je        short M08_L09
       mov       rcx,rax
M08_L06:
       mov       edx,r14d
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       test      edi,edi
       jle       short M08_L07
       mov       rcx,[rbx+8]
       mov       r8d,edi
       mov       rdx,r14
       call      qword ptr [7FFCFC7DF588]; System.Array.Copy(System.Array, System.Array, Int32)
M08_L07:
       lea       rcx,[rbx+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
M08_L08:
       lea       ecx,[rbp+1]
       mov       [rbx+10],ecx
       mov       rcx,[rbx+8]
       movsxd    rdx,ebp
       mov       r8,rsi
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M08_L09:
       mov       rdx,7FFCFD120030
       call      qword ptr [7FFCFC7DF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M08_L06
; Total bytes of code 309
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
       je        near ptr M10_L00
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M10_L00
       test      rbx,rbx
       je        near ptr M10_L03
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        near ptr M10_L03
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M10_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFD5C418D20
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFCFC7D5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFCFC7D5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M10_L00:
       test      rbx,rbx
       je        short M10_L01
       mov       ebp,[rbx+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M10_L02
M10_L01:
       mov       rax,2FADCA50008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M10_L02:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M10_L03:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M10_L04:
       call      qword ptr [7FFCFD1C7DC8]
       int       3
; Total bytes of code 235
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
       jmp       qword ptr [7FFCFC7D5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsAddRemoveCollectionBenchmark.AddRangeIfNotExists()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,98
       lea       rbp,[rsp+0D0]
       xor       eax,eax
       mov       [rbp-58],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       rdi,[rbx+280]
       test      rsi,rsi
       je        near ptr M00_L58
       mov       r14,rsi
       test      rdi,rdi
       je        near ptr M00_L59
       mov       rcx,offset MT_System.Collections.Generic.HashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,239D4C00C58
       mov       rdx,[rcx]
       lea       rcx,[r15+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,r14
       mov       rcx,offset MT_System.Collections.Generic.HashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r13,rax
       test      r13,r13
       jne       near ptr M00_L60
M00_L00:
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r14],rcx
       jne       near ptr M00_L61
       mov       ecx,[r14+10]
M00_L01:
       test      ecx,ecx
       jle       short M00_L02
       call      qword ptr [7FFCFC7E5A88]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       r13d,eax
       movsxd    rdx,r13d
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r12,rax
       movsxd    rdx,r13d
       mov       rcx,offset MT_System.Collections.Generic.HashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Entry[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rbp-68],rax
       mov       dword ptr [r15+2C],0FFFFFFFF
       lea       rcx,[r15+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+10]
       mov       rdx,[rbp-68]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,r13d
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [r15+20],rax
M00_L02:
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r14],rcx
       jne       near ptr M00_L63
       cmp       dword ptr [r14+10],0
       je        near ptr M00_L62
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       r12d,[r14+14]
       lea       rcx,[r13+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r13+10],rcx
       mov       [r13+18],r12d
       mov       [r13+1C],ecx
M00_L03:
       mov       [rbp-70],r13
M00_L04:
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       r13,[rbp-70]
       cmp       [r13],rcx
       jne       near ptr M00_L24
       lea       r14,[r13+8]
       mov       rcx,[r14]
       mov       rdx,rcx
       mov       eax,[r14+10]
       cmp       eax,[rcx+14]
       jne       near ptr M00_L26
       mov       ecx,[r14+14]
       cmp       ecx,[rdx+10]
       jae       near ptr M00_L17
       mov       rdx,[rdx+8]
       cmp       ecx,[rdx+8]
       jae       near ptr M00_L27
       mov       ecx,ecx
       mov       rdx,[rdx+rcx*8+10]
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [r14+14]
       mov       r14,[r13+10]
M00_L05:
       cmp       qword ptr [r15+8],0
       je        near ptr M00_L19
M00_L06:
       mov       r12,[r15+10]
       mov       rax,[r15+18]
       xor       r8d,r8d
       mov       [rbp-3C],r8d
       test      r14,r14
       je        near ptr M00_L13
       mov       rcx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       [rbp-80],rax
       cmp       [rax],rcx
       jne       near ptr M00_L20
       mov       rax,[rbp-80]
       mov       rdx,[r14+28]
       test      rdx,rdx
       je        short M00_L07
       mov       [rbp-80],rax
       mov       rcx,239BEC00068
       mov       rcx,[rcx]
       mov       r10,[rcx]
       mov       r10,[r10+48]
       call      qword ptr [r10+18]
       mov       ecx,eax
       mov       rax,[rbp-80]
       jmp       short M00_L08
M00_L07:
       xor       ecx,ecx
M00_L08:
       mov       r10d,ecx
M00_L09:
       mov       [rbp-40],r10d
       mov       rdx,[r15+8]
       mov       ecx,r10d
       imul      rcx,[r15+20]
       shr       rcx,20
       inc       rcx
       mov       r11d,[rdx+8]
       imul      rcx,r11
       shr       rcx,20
       cmp       ecx,[rdx+8]
       jae       near ptr M00_L27
       mov       ecx,ecx
       lea       r9,[rdx+rcx*4+10]
       mov       [rbp-88],r9
       mov       r11d,[r9]
       dec       r11d
       jns       near ptr M00_L14
M00_L10:
       cmp       dword ptr [r15+30],0
       jg        near ptr M00_L16
       mov       edx,[r15+28]
       mov       [rbp-44],edx
       cmp       [r12+8],edx
       je        near ptr M00_L22
M00_L11:
       mov       edx,[rbp-44]
       mov       r12d,edx
       lea       ecx,[r12+1]
       mov       [r15+28],ecx
       mov       rcx,[r15+10]
       mov       r11,rcx
       mov       [rbp-80],rax
M00_L12:
       cmp       r12d,[r11+8]
       jae       near ptr M00_L27
       mov       ecx,r12d
       shl       rcx,4
       mov       [rbp-78],r11
       lea       rcx,[r11+rcx+10]
       mov       [rcx+8],r10d
       mov       r9,[rbp-88]
       mov       edx,[r9]
       dec       edx
       mov       [rcx+0C],edx
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       inc       r12d
       mov       rdx,[rbp-88]
       mov       [rdx],r12d
       inc       dword ptr [r15+34]
       cmp       dword ptr [rbp-3C],64
       jbe       near ptr M00_L04
       jmp       near ptr M00_L23
M00_L13:
       xor       r10d,r10d
       jmp       near ptr M00_L09
M00_L14:
       cmp       r11d,[r12+8]
       jae       near ptr M00_L27
       mov       edx,r11d
       shl       rdx,4
       lea       r11,[r12+rdx+10]
       mov       [rbp-90],r11
       cmp       [r11+8],r10d
       je        near ptr M00_L21
M00_L15:
       mov       r11d,[r11+0C]
       mov       r8d,[rbp-3C]
       inc       r8d
       mov       [rbp-3C],r8d
       cmp       [r12+8],r8d
       jb        near ptr M00_L25
       test      r11d,r11d
       mov       r10d,[rbp-40]
       jge       short M00_L14
       jmp       near ptr M00_L10
M00_L16:
       mov       ecx,[r15+2C]
       mov       r11d,ecx
       dec       dword ptr [r15+30]
       cmp       ecx,[r12+8]
       jae       near ptr M00_L27
       shl       rcx,4
       mov       ecx,[r12+rcx+1C]
       neg       ecx
       add       ecx,0FFFFFFFD
       mov       [r15+2C],ecx
       mov       [rbp-80],rax
       mov       ecx,r11d
       mov       r11,r12
       mov       r12d,ecx
       jmp       near ptr M00_L12
M00_L17:
       xor       eax,eax
       mov       [r14+8],rax
       mov       dword ptr [r14+14],0FFFFFFFF
       jmp       near ptr M00_L28
M00_L18:
       mov       rcx,r13
       mov       r11,7FFCFC732088
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L05
M00_L19:
       mov       rcx,r15
       xor       edx,edx
       call      qword ptr [7FFCFCAB71B0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       jmp       near ptr M00_L06
M00_L20:
       mov       rax,[rbp-80]
       mov       [rbp-80],rax
       mov       rcx,rax
       mov       rdx,r14
       mov       r11,7FFCFC732098
       call      qword ptr [r11]
       mov       ecx,eax
       mov       rax,[rbp-80]
       jmp       near ptr M00_L08
M00_L21:
       mov       rdx,[r11]
       mov       [rbp-80],rax
       mov       rcx,rax
       mov       r8,r14
       mov       r11,7FFCFC7320A0
       call      qword ptr [r11]
       test      eax,eax
       mov       rax,[rbp-80]
       mov       r11,[rbp-90]
       jne       near ptr M00_L04
       jmp       near ptr M00_L15
M00_L22:
       mov       [rbp-80],rax
       mov       ecx,[r15+28]
       call      qword ptr [7FFCFC7EF558]; System.Collections.HashHelpers.ExpandPrime(Int32)
       mov       edx,eax
       mov       rcx,r15
       xor       r8d,r8d
       call      qword ptr [7FFCFCC9D608]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,[r15+8]
       mov       r12d,[rbp-40]
       mov       edx,r12d
       imul      rdx,[r15+20]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       imul      rdx,rax
       shr       rdx,20
       cmp       edx,[rcx+8]
       jae       near ptr M00_L27
       mov       edx,edx
       lea       r9,[rcx+rdx*4+10]
       mov       rax,r9
       mov       [rbp-88],rax
       mov       r10d,r12d
       mov       rax,[rbp-80]
       jmp       near ptr M00_L11
M00_L23:
       mov       rdx,[rbp-80]
       mov       r12,[rbp-78]
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M00_L04
       mov       edx,[r12+8]
       mov       rcx,r15
       mov       r8d,1
       call      qword ptr [7FFCFCC9D608]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,r15
       mov       rdx,r14
       call      qword ptr [7FFCFCAB7270]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       jmp       near ptr M00_L04
M00_L24:
       mov       rcx,r13
       mov       r11,7FFCFC732080
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L18
       jmp       near ptr M00_L64
M00_L25:
       call      qword ptr [7FFCFC7EF480]
       int       3
M00_L26:
       call      qword ptr [7FFCFC7EFC48]
       int       3
M00_L27:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L28:
       mov       ecx,[r15+28]
       test      ecx,ecx
       jle       short M00_L29
       mov       rax,[r15+10]
       mov       eax,[rax+8]
       xor       edx,edx
       div       ecx
       cmp       eax,3
       jg        near ptr M00_L65
M00_L29:
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rdi],rcx
       jne       near ptr M00_L67
       cmp       dword ptr [rdi+10],0
       je        near ptr M00_L66
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       r13d,[rdi+14]
       lea       rcx,[r14+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r14+10],rcx
       mov       [r14+18],r13d
       mov       [r14+1C],ecx
M00_L30:
       mov       [rbp-60],r14
M00_L31:
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       r14,[rbp-60]
       cmp       [r14],rcx
       jne       near ptr M00_L53
       lea       rdi,[r14+8]
       mov       rcx,[rdi]
       mov       rdx,rcx
       mov       eax,[rdi+10]
       cmp       eax,[rcx+14]
       jne       near ptr M00_L55
       mov       ecx,[rdi+14]
       cmp       ecx,[rdx+10]
       jae       near ptr M00_L46
       mov       rdx,[rdx+8]
       cmp       ecx,[rdx+8]
       jae       near ptr M00_L56
       mov       ecx,ecx
       mov       rdx,[rdx+rcx*8+10]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rdi+14]
       mov       rdi,[r14+10]
M00_L32:
       cmp       qword ptr [r15+8],0
       je        near ptr M00_L48
M00_L33:
       mov       r13,[r15+10]
       mov       r12,[r15+18]
       xor       eax,eax
       mov       [rbp-48],eax
       test      rdi,rdi
       je        near ptr M00_L41
       mov       rcx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r12],rcx
       jne       near ptr M00_L49
       mov       rdx,[rdi+28]
       test      rdx,rdx
       je        short M00_L34
       mov       rcx,239BEC00068
       mov       rcx,[rcx]
       mov       r8,[rcx]
       mov       r8,[r8+48]
       call      qword ptr [r8+18]
       mov       ecx,eax
       jmp       short M00_L35
M00_L34:
       xor       ecx,ecx
M00_L35:
       mov       r10d,ecx
M00_L36:
       mov       [rbp-4C],r10d
       mov       rdx,[r15+8]
       mov       ecx,r10d
       imul      rcx,[r15+20]
       shr       rcx,20
       inc       rcx
       mov       r8d,[rdx+8]
       imul      rcx,r8
       shr       rcx,20
       cmp       ecx,[rdx+8]
       jae       near ptr M00_L56
       mov       ecx,ecx
       lea       r9,[rdx+rcx*4+10]
       mov       [rbp-0A0],r9
       mov       r11d,[r9]
       dec       r11d
       jns       near ptr M00_L42
M00_L37:
       cmp       dword ptr [r15+30],0
       jg        near ptr M00_L44
       mov       edx,[r15+28]
       mov       [rbp-50],edx
       cmp       [r13+8],edx
       je        near ptr M00_L51
M00_L38:
       mov       edx,[rbp-50]
       mov       r13d,edx
       lea       ecx,[r13+1]
       mov       [r15+28],ecx
       mov       rcx,[r15+10]
       mov       r8,rcx
M00_L39:
       cmp       r13d,[r8+8]
       jae       near ptr M00_L56
       mov       ecx,r13d
       shl       rcx,4
       mov       [rbp-98],r8
       lea       rcx,[r8+rcx+10]
       mov       [rcx+8],r10d
       mov       r9,[rbp-0A0]
       mov       edx,[r9]
       dec       edx
       mov       [rcx+0C],edx
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       inc       r13d
       mov       rdx,[rbp-0A0]
       mov       [rdx],r13d
       inc       dword ptr [r15+34]
       cmp       dword ptr [rbp-48],64
       ja        near ptr M00_L52
M00_L40:
       inc       dword ptr [rsi+14]
       mov       rcx,[rsi+8]
       mov       edx,[rsi+10]
       cmp       [rcx+8],edx
       jbe       near ptr M00_L45
       lea       eax,[rdx+1]
       mov       [rsi+10],eax
       cmp       edx,[rcx+8]
       jae       near ptr M00_L56
       mov       edx,edx
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L31
M00_L41:
       xor       r10d,r10d
       jmp       near ptr M00_L36
M00_L42:
       cmp       r11d,[r13+8]
       jae       near ptr M00_L56
       mov       edx,r11d
       shl       rdx,4
       lea       r11,[r13+rdx+10]
       mov       [rbp-0A8],r11
       cmp       [r11+8],r10d
       je        near ptr M00_L50
M00_L43:
       mov       r11d,[r11+0C]
       mov       eax,[rbp-48]
       inc       eax
       mov       [rbp-48],eax
       cmp       [r13+8],eax
       jb        near ptr M00_L54
       test      r11d,r11d
       mov       r10d,[rbp-4C]
       jge       short M00_L42
       jmp       near ptr M00_L37
M00_L44:
       mov       ecx,[r15+2C]
       mov       r8d,ecx
       dec       dword ptr [r15+30]
       cmp       ecx,[r13+8]
       jae       near ptr M00_L56
       shl       rcx,4
       mov       ecx,[r13+rcx+1C]
       neg       ecx
       add       ecx,0FFFFFFFD
       mov       [r15+2C],ecx
       mov       eax,r8d
       mov       r8,r13
       mov       r13d,eax
       jmp       near ptr M00_L39
M00_L45:
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FFCFC7E71C8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M00_L31
M00_L46:
       xor       eax,eax
       mov       [rdi+8],rax
       mov       dword ptr [rdi+14],0FFFFFFFF
       jmp       near ptr M00_L57
M00_L47:
       mov       rcx,r14
       mov       r11,7FFCFC732060
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L32
M00_L48:
       mov       rcx,r15
       xor       edx,edx
       call      qword ptr [7FFCFCAB71B0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       jmp       near ptr M00_L33
M00_L49:
       mov       rcx,r12
       mov       rdx,rdi
       mov       r11,7FFCFC7320A8
       call      qword ptr [r11]
       mov       ecx,eax
       jmp       near ptr M00_L35
M00_L50:
       mov       rdx,[r11]
       mov       rcx,r12
       mov       r8,rdi
       mov       r11,7FFCFC7320B0
       call      qword ptr [r11]
       test      eax,eax
       mov       r11,[rbp-0A8]
       je        near ptr M00_L43
       jmp       near ptr M00_L31
M00_L51:
       mov       rcx,r15
       call      qword ptr [7FFCFD3D4AC8]
       mov       rcx,[r15+8]
       mov       r13d,[rbp-4C]
       mov       edx,r13d
       imul      rdx,[r15+20]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       imul      rdx,rax
       shr       rdx,20
       cmp       edx,[rcx+8]
       jae       near ptr M00_L56
       mov       edx,edx
       lea       r9,[rcx+rdx*4+10]
       mov       rax,r9
       mov       [rbp-0A0],rax
       mov       r10d,r13d
       jmp       near ptr M00_L38
M00_L52:
       mov       rdx,r12
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M00_L40
       mov       r13,[rbp-98]
       mov       edx,[r13+8]
       mov       rcx,r15
       mov       r8d,1
       call      qword ptr [7FFCFCC9D608]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,r15
       mov       rdx,rdi
       call      qword ptr [7FFCFCAB7270]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       jmp       near ptr M00_L40
M00_L53:
       mov       rcx,r14
       mov       r11,7FFCFC732058
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L47
       jmp       near ptr M00_L68
M00_L54:
       call      qword ptr [7FFCFC7EF480]
       int       3
M00_L55:
       call      qword ptr [7FFCFC7EFC48]
       int       3
M00_L56:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L57:
       mov       [rbp-58],rsi
       mov       rcx,[rbx+60]
       lea       r8,[rbp-58]
       mov       rdx,7FFCFD3CAB70
       cmp       [rcx],ecx
       call      qword ptr [7FFCFD3D4270]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,98
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
       call      qword ptr [7FFCFCEBE448]
       mov       ecx,69E
       mov       rdx,7FFCFCD16050
       call      qword ptr [7FFCFC7EF210]
       mov       rbx,rax
       mov       ecx,1B61
       mov       rdx,7FFCFCBE5618
       call      qword ptr [7FFCFC7EF210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCFC7ED9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFCFCD16050
       call      qword ptr [7FFCFC7EF210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCFC7ED9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCFD006958]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCFD006970]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L59:
       call      qword ptr [7FFCFCEBE448]
       mov       ecx,0B5
       mov       rdx,7FFCFCD16050
       call      qword ptr [7FFCFC7EF210]
       mov       r14,rax
       mov       ecx,1B61
       mov       rdx,7FFCFCBE5618
       call      qword ptr [7FFCFC7EF210]
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFCFC7ED9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFCFCD16050
       call      qword ptr [7FFCFC7EF210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCFC7ED9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCFD006958]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCFD006970]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L60:
       mov       r8,r13
       mov       rdx,r15
       mov       rcx,offset MT_System.Collections.Generic.HashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFCFD3DC780]
       test      eax,eax
       je        near ptr M00_L00
       mov       rcx,r15
       mov       rdx,r13
       call      qword ptr [7FFCFD3DC750]
       jmp       near ptr M00_L29
M00_L61:
       mov       rcx,r14
       mov       r11,7FFCFC732070
       call      qword ptr [r11]
       mov       ecx,eax
       jmp       near ptr M00_L01
M00_L62:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,239D4C00D48
       mov       r13,[rcx]
       jmp       near ptr M00_L03
M00_L63:
       mov       rcx,r14
       mov       r11,7FFCFC732078
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M00_L03
M00_L64:
       mov       rcx,r13
       mov       r11,7FFCFC732090
       call      qword ptr [r11]
       jmp       near ptr M00_L28
M00_L65:
       mov       edx,ecx
       sub       edx,[r15+30]
       mov       rcx,r15
       call      qword ptr [7FFCFD3DC768]
       jmp       near ptr M00_L29
M00_L66:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,239D4C00D48
       mov       r14,[rcx]
       jmp       near ptr M00_L30
M00_L67:
       mov       rcx,rdi
       mov       r11,7FFCFC732050
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L30
M00_L68:
       mov       rcx,r14
       mov       r11,7FFCFC732068
       call      qword ptr [r11]
       jmp       near ptr M00_L57
       sub       rsp,28
       cmp       qword ptr [rbp-60],0
       je        short M00_L69
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-60]
       cmp       [rax],rcx
       je        short M00_L69
       mov       rcx,rax
       mov       r11,7FFCFC732068
       call      qword ptr [r11]
M00_L69:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       qword ptr [rbp-70],0
       je        short M00_L70
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-70]
       cmp       [rax],rcx
       je        short M00_L70
       mov       rcx,rax
       mov       r11,7FFCFC732090
       call      qword ptr [r11]
M00_L70:
       nop
       add       rsp,28
       ret
; Total bytes of code 3019
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
       mov       rcx,7FFD59B31390
       xor       eax,eax
       mov       edx,48
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
       call      qword ptr [7FFCFD134C48]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCFCC95B18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M02_L03:
       mov       esi,ebx
       or        esi,1
       jmp       short M02_L06
M02_L04:
       mov       ecx,esi
       call      qword ptr [7FFCFD134C60]
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
; Total bytes of code 182
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
       call      qword ptr [7FFCFC7E5A88]; System.Collections.HashHelpers.GetPrime(Int32)
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
       mov       rdx,7FFCFD3BB898
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M03_L00
; Total bytes of code 169
```
```assembly
; System.Collections.HashHelpers.ExpandPrime(Int32)
       push      rbx
       sub       rsp,20
       lea       ebx,[rcx+rcx]
       cmp       ebx,7FFFFFC3
       ja        short M04_L01
M04_L00:
       mov       rcx,7FFCFD1CDD20
       call      CORINFO_HELP_COUNTPROFILE32
       mov       ecx,ebx
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFCFC7E5A88]; System.Collections.HashHelpers.GetPrime(Int32)
M04_L01:
       cmp       ecx,7FFFFFC3
       jge       short M04_L02
       mov       rcx,7FFCFD1CDD18
       call      CORINFO_HELP_COUNTPROFILE32
       mov       eax,7FFFFFC3
       add       rsp,20
       pop       rbx
       ret
M04_L02:
       mov       rcx,7FFCFD1CDD1C
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M04_L00
; Total bytes of code 95
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
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       esi,edx
       mov       edi,r8d
       mov       rcx,[rbx]
       call      qword ptr [7FFD5A79BEB0]
       mov       rcx,rax
       movsxd    rdx,esi
       call      qword ptr [7FFD5A798070]; CORINFO_HELP_NEWARR_1_DIRECT
       mov       rbp,rax
       mov       r14d,[rbx+28]
       mov       rcx,[rbx+10]
       mov       rdx,rbp
       mov       r8d,r14d
       call      qword ptr [7FFD5A7A9378]; Precode of System.Array.Copy(System.Array, System.Array, Int32)
       movzx     ecx,dil
       test      cl,1
       jne       near ptr M05_L06
M05_L00:
       movsxd    rcx,esi
       call      qword ptr [7FFD5A7A5BF0]
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      qword ptr [7FFD5A797FD0]; CORINFO_HELP_ASSIGN_REF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,esi
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rbx+20],rax
       xor       ecx,ecx
       test      r14d,r14d
       jle       short M05_L03
       cmp       [rbp+8],r14d
       jl        near ptr M05_L04
M05_L01:
       mov       edx,ecx
       shl       rdx,4
       lea       rdx,[rbp+rdx+10]
       cmp       dword ptr [rdx+0C],0FFFFFFFF
       jl        short M05_L02
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
       jae       near ptr M05_L11
       mov       r10d,r10d
       lea       rax,[r8+r10*4+10]
       mov       r8d,[rax]
       dec       r8d
       mov       [rdx+0C],r8d
       lea       edx,[rcx+1]
       mov       [rax],edx
M05_L02:
       inc       ecx
       cmp       ecx,r14d
       jl        short M05_L01
M05_L03:
       lea       rcx,[rbx+10]
       mov       rdx,rbp
       call      qword ptr [7FFD5A797FD0]; CORINFO_HELP_ASSIGN_REF
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
M05_L04:
       cmp       ecx,[rbp+8]
       jae       near ptr M05_L11
       mov       eax,ecx
       shl       rax,4
       lea       rdx,[rbp+rax+10]
       cmp       dword ptr [rdx+0C],0FFFFFFFF
       jl        short M05_L05
       mov       eax,[rdx+8]
       mov       r8,[rbx+8]
       mov       r10d,eax
       imul      r10,[rbx+20]
       shr       r10,20
       inc       r10
       mov       eax,[r8+8]
       imul      r10,rax
       shr       r10,20
       cmp       r10d,[r8+8]
       jae       near ptr M05_L11
       mov       eax,r10d
       lea       rax,[r8+rax*4+10]
       mov       r8d,[rax]
       dec       r8d
       mov       [rdx+0C],r8d
       lea       edx,[rcx+1]
       mov       [rax],edx
M05_L05:
       inc       ecx
       cmp       ecx,r14d
       jl        short M05_L04
       jmp       near ptr M05_L03
M05_L06:
       mov       rcx,[rbx]
       call      qword ptr [7FFD5A79B4F0]
       mov       rdi,rax
       mov       rcx,[rbx+18]
       call      qword ptr [7FFD5A7A77D0]
       mov       rcx,rax
       lea       r11,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       [rcx],ecx
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFD5A798078]; Precode of System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdi,rax
       lea       rcx,[rbx+18]
       mov       rdx,rdi
       call      qword ptr [7FFD5A797FD0]; CORINFO_HELP_ASSIGN_REF
       xor       r15d,r15d
       cmp       r15d,r14d
       jge       near ptr M05_L00
M05_L07:
       cmp       r15d,[rbp+8]
       jae       short M05_L11
       mov       rcx,r15
       shl       rcx,4
       lea       r13,[rbp+rcx+10]
       cmp       dword ptr [r13+0C],0FFFFFFFF
       jl        short M05_L10
       cmp       qword ptr [r13],0
       jne       short M05_L08
       xor       r12d,r12d
       jmp       short M05_L09
M05_L08:
       mov       rcx,[rbx]
       call      qword ptr [7FFD5A79D148]
       mov       rdx,[r13]
       mov       rcx,rdi
       mov       r11,rax
       call      qword ptr [rax]
       mov       r12d,eax
M05_L09:
       mov       [r13+8],r12d
M05_L10:
       inc       r15d
       cmp       r15d,r14d
       jl        short M05_L07
       jmp       near ptr M05_L00
M05_L11:
       call      qword ptr [7FFD5A797FC0]
       int       3
; Total bytes of code 540
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
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Data.Models.Country
       cmp       [r15],rcx
       jne       near ptr M06_L12
       mov       rcx,r15
       call      00007FFD5C3C6270
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
       mov       rdx,7FFCFD179520
       call      qword ptr [7FFCFC7EF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M06_L00
M06_L09:
       mov       rcx,r15
       call      qword ptr [7FFCFCAB7258]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
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
       mov       rdx,7FFCFD179538
       call      qword ptr [7FFCFC7EF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFCFC7EF480]
       int       3
M06_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 532
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
       jl        near ptr M07_L06
       cmp       [r14+8],r15d
       je        short M07_L03
       test      r15d,r15d
       jle       near ptr M07_L08
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+78]
       test      rax,rax
       je        short M07_L05
       mov       rcx,rax
M07_L01:
       mov       edx,r15d
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r15,rax
       test      edi,edi
       jg        short M07_L07
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
       mov       rdx,7FFCFCFED488
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M07_L01
M07_L06:
       mov       ecx,7
       mov       edx,0F
       call      qword ptr [7FFCFCEB6028]
       int       3
M07_L07:
       mov       rcx,r14
       mov       r8d,edi
       mov       rdx,r15
       call      qword ptr [7FFCFC7EF588]; System.Array.Copy(System.Array, System.Array, Int32)
       jmp       short M07_L02
M07_L08:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+80]
       test      rdx,rdx
       je        short M07_L09
       jmp       short M07_L10
M07_L09:
       mov       rdx,7FFCFD074490
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M07_L10:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M07_L03
; Total bytes of code 316
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
       je        near ptr M09_L00
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M09_L00
       test      rbx,rbx
       je        near ptr M09_L03
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        near ptr M09_L03
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M09_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFD5C418D20
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFCFC7E5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFCFC7E5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M09_L00:
       test      rbx,rbx
       je        short M09_L01
       mov       ebp,[rbx+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M09_L02
M09_L01:
       mov       rax,27A53D30008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M09_L02:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M09_L03:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M09_L04:
       call      qword ptr [7FFCFD13F540]
       int       3
; Total bytes of code 235
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
       jmp       qword ptr [7FFCFC7E5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsAddRemoveCollectionBenchmark.RemoveFirst()
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
       mov       rax,[rbp+10]
       mov       rdx,[rax+278]
       mov       rcx,7FFCFD187740
       call      qword ptr [7FFCFD1078A0]; System.Linq.Enumerable.First[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       [rbp-18],rax
       mov       r8,[rbp-18]
       mov       rdx,[rbp-10]
       mov       rcx,7FFCFD187FD0
       call      qword ptr [7FFCFD10D140]; DotNetTips.Spargine.Extensions.ListExtensions.RemoveFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.__Canon)
       mov       [rbp-4],eax
       mov       rcx,[rbp+10]
       mov       edx,[rbp-4]
       call      qword ptr [7FFCFD10D170]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 122
```
```assembly
; System.Linq.Enumerable.First[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rdx
       call      qword ptr [7FFD5C097CF8]
       mov       rcx,rax
       lea       r8,[rsp+20]
       mov       rdx,rbx
       call      qword ptr [7FFD5C09A208]; Precode of System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
       cmp       byte ptr [rsp+20],0
       je        short M01_L00
       add       rsp,30
       pop       rbx
       ret
M01_L00:
       call      qword ptr [7FFD5C0995C8]
       int       3
; Total bytes of code 56
```
```assembly
; DotNetTips.Spargine.Extensions.ListExtensions.RemoveFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.__Canon)
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
; 			list = list.ArgumentNotNull();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rax,[rbp+10]
       mov       rax,[rax+18]
       mov       rax,[rax+10]
       mov       [rbp-18],rax
       cmp       qword ptr [rbp-18],0
       je        short M02_L00
       mov       rax,[rbp-18]
       mov       [rbp-10],rax
       jmp       short M02_L01
M02_L00:
       mov       rcx,[rbp+10]
       mov       rdx,7FFCFD1909B8
       call      qword ptr [7FFCFCA67AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M02_L01:
       mov       rax,211DA4630C8
       mov       [rsp+20],rax
       mov       rcx,[rbp-10]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       mov       r9,211DA450008
       call      qword ptr [7FFCFCEBE898]
       mov       [rbp+18],rax
; 			return list.Remove(item);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,[rbp+18]
       mov       rdx,[rbp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFCFC901838]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 152
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
       call      qword ptr [7FFCFD10D320]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       lea       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFCFD10D2F0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 60
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsAddRemoveCollectionBenchmark.RemoveFirst()
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
       mov       rax,[rbp+10]
       mov       rdx,[rax+278]
       mov       rcx,7FFCFD167740
       call      qword ptr [7FFCFD0E7918]; System.Linq.Enumerable.First[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       [rbp-18],rax
       mov       r8,[rbp-18]
       mov       rdx,[rbp-10]
       mov       rcx,7FFCFD167FD0
       call      qword ptr [7FFCFD0ED1B8]; DotNetTips.Spargine.Extensions.ListExtensions.RemoveFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.__Canon)
       mov       [rbp-4],eax
       mov       rcx,[rbp+10]
       mov       edx,[rbp-4]
       call      qword ptr [7FFCFD0ED1E8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 122
```
```assembly
; System.Linq.Enumerable.First[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       mov       [rbp-20],rcx
       mov       rbx,rdx
       mov       rdx,[rcx+18]
       mov       rsi,[rdx+18]
       test      rsi,rsi
       je        near ptr M01_L07
M01_L00:
       test      rbx,rbx
       je        near ptr M01_L20
       mov       rcx,[rsi+18]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       je        near ptr M01_L08
M01_L01:
       mov       rdx,rbx
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M01_L23
       mov       rcx,[rsi+18]
       mov       rdi,[rcx+20]
       test      rdi,rdi
       je        near ptr M01_L09
M01_L02:
       mov       rcx,[rdi+18]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       je        near ptr M01_L10
M01_L03:
       mov       rdx,rbx
       call      qword ptr [7FFCFC7CF9D8]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rsi,rax
       test      rsi,rsi
       je        near ptr M01_L15
       mov       rcx,[rdi+18]
       cmp       qword ptr [rcx+8],40
       jle       near ptr M01_L11
       mov       r11,[rcx+40]
       test      r11,r11
       je        near ptr M01_L11
M01_L04:
       mov       rcx,rsi
       call      qword ptr [r11]
       test      eax,eax
       jg        near ptr M01_L12
M01_L05:
       xor       edx,edx
       mov       [rbp-28],edx
       xor       esi,esi
M01_L06:
       cmp       byte ptr [rbp-28],0
       je        near ptr M01_L24
       mov       rcx,7FFCFD414A34
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,rsi
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L07:
       mov       rdx,7FFCFD420BD8
       call      qword ptr [7FFCFC7CF630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M01_L00
M01_L08:
       mov       rcx,rsi
       mov       rdx,7FFCFD1C7330
       call      qword ptr [7FFCFC7CF630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L01
M01_L09:
       mov       rcx,rsi
       mov       rdx,7FFCFD1C7310
       call      qword ptr [7FFCFC7CF630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M01_L02
M01_L10:
       mov       rcx,rdi
       mov       rdx,7FFCFD420BF8
       call      qword ptr [7FFCFC7CF630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L03
M01_L11:
       mov       rcx,rdi
       mov       rdx,7FFCFD420EE0
       call      qword ptr [7FFCFC7CF630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M01_L04
M01_L12:
       mov       dword ptr [rbp-28],1
       mov       rcx,[rdi+18]
       cmp       qword ptr [rcx+8],48
       jle       short M01_L14
       mov       r11,[rcx+48]
       test      r11,r11
       je        short M01_L14
M01_L13:
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [r11]
       mov       rsi,rax
       jmp       near ptr M01_L06
M01_L14:
       mov       rcx,rdi
       mov       rdx,7FFCFD420EF8
       call      qword ptr [7FFCFC7CF630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r11,rax
       jmp       short M01_L13
M01_L15:
       mov       rcx,[rdi+18]
       cmp       qword ptr [rcx+8],30
       jle       near ptr M01_L21
       mov       r11,[rcx+30]
       test      r11,r11
       je        near ptr M01_L21
M01_L16:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp-30],rax
       mov       rcx,rax
       mov       r11,7FFCFC711450
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M01_L22
       mov       dword ptr [rbp-28],1
       mov       rcx,[rdi+18]
       cmp       qword ptr [rcx+8],38
       jle       short M01_L18
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M01_L18
M01_L17:
       mov       rcx,[rbp-30]
       call      qword ptr [r11]
       mov       rsi,rax
       jmp       short M01_L19
M01_L18:
       mov       rcx,rdi
       mov       rdx,7FFCFD420E28
       call      qword ptr [7FFCFC7CF630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r11,rax
       jmp       short M01_L17
M01_L19:
       mov       rcx,[rbp-30]
       mov       r11,7FFCFC711458
       call      qword ptr [r11]
       jmp       near ptr M01_L06
M01_L20:
       mov       ecx,11
       call      qword ptr [7FFCFC7CF930]
       int       3
M01_L21:
       mov       rcx,rdi
       mov       rdx,7FFCFD420E10
       call      qword ptr [7FFCFC7CF630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M01_L16
M01_L22:
       call      M01_L25
       jmp       near ptr M01_L05
M01_L23:
       lea       rdx,[rbp-28]
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax+20]
       mov       rsi,rax
       jmp       near ptr M01_L06
M01_L24:
       mov       rcx,7FFCFD414A30
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FFCFD0E51B8]
       int       3
M01_L25:
       sub       rsp,28
       mov       rcx,[rbp-30]
       test      rcx,rcx
       je        short M01_L26
       mov       r11,7FFCFC711458
       call      qword ptr [r11]
M01_L26:
       nop
       add       rsp,28
       ret
; Total bytes of code 695
```
```assembly
; DotNetTips.Spargine.Extensions.ListExtensions.RemoveFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.__Canon)
; 			list = list.ArgumentNotNull();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			return list.Remove(item);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       rax,[rbp+10]
       mov       rax,[rax+18]
       mov       rax,[rax+10]
       mov       [rbp-18],rax
       cmp       qword ptr [rbp-18],0
       je        short M02_L00
       mov       rax,[rbp-18]
       mov       [rbp-10],rax
       jmp       short M02_L01
M02_L00:
       mov       rcx,[rbp+10]
       mov       rdx,7FFCFD1709B8
       call      qword ptr [7FFCFC7CF630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-10],rax
M02_L01:
       mov       rax,192993430C8
       mov       [rsp+20],rax
       mov       rcx,[rbp-10]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       mov       r9,19299330008
       call      qword ptr [7FFCFCE9E8E0]
       mov       [rbp+18],rax
       mov       rcx,[rbp+18]
       mov       rdx,[rbp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFCFC8E1838]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 152
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
       call      qword ptr [7FFCFD0ED398]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       lea       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFCFD0ED368]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 60
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsAddRemoveCollectionBenchmark.RemoveFirst()
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
       mov       rax,[rbp+10]
       mov       rdx,[rax+278]
       mov       rcx,7FFCFD177970
       call      qword ptr [7FFCFD0F78A0]; System.Linq.Enumerable.First[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       [rbp-18],rax
       mov       r8,[rbp-18]
       mov       rdx,[rbp-10]
       mov       rcx,7FFCFD178200
       call      qword ptr [7FFCFD0FD140]; DotNetTips.Spargine.Extensions.ListExtensions.RemoveFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.__Canon)
       mov       [rbp-4],eax
       mov       rcx,[rbp+10]
       mov       edx,[rbp-4]
       call      qword ptr [7FFCFD0FD170]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 122
```
```assembly
; System.Linq.Enumerable.First[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       mov       [rbp-20],rcx
       mov       rbx,rdx
       mov       rdx,[rcx+18]
       mov       rsi,[rdx+18]
       test      rsi,rsi
       je        near ptr M01_L07
M01_L00:
       test      rbx,rbx
       je        near ptr M01_L20
       mov       rcx,[rsi+18]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       je        near ptr M01_L08
M01_L01:
       mov       rdx,rbx
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M01_L23
       mov       rcx,[rsi+18]
       mov       rdi,[rcx+20]
       test      rdi,rdi
       je        near ptr M01_L09
M01_L02:
       mov       rcx,[rdi+18]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       je        near ptr M01_L10
M01_L03:
       mov       rdx,rbx
       call      qword ptr [7FFCFC97F5B8]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rsi,rax
       test      rsi,rsi
       je        near ptr M01_L15
       mov       rcx,[rdi+18]
       cmp       qword ptr [rcx+8],40
       jle       near ptr M01_L11
       mov       r11,[rcx+40]
       test      r11,r11
       je        near ptr M01_L11
M01_L04:
       mov       rcx,rsi
       call      qword ptr [r11]
       test      eax,eax
       jg        near ptr M01_L12
M01_L05:
       xor       edx,edx
       mov       [rbp-28],edx
       xor       esi,esi
M01_L06:
       cmp       byte ptr [rbp-28],0
       je        near ptr M01_L24
       mov       rcx,7FFCFD424B6C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,rsi
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L07:
       mov       rdx,7FFCFD431D20
       call      qword ptr [7FFCFCA57AF8]
       mov       rsi,rax
       jmp       near ptr M01_L00
M01_L08:
       mov       rcx,rsi
       mov       rdx,7FFCFD2852B0
       call      qword ptr [7FFCFCA57AF8]
       mov       rcx,rax
       jmp       near ptr M01_L01
M01_L09:
       mov       rcx,rsi
       mov       rdx,7FFCFD285290
       call      qword ptr [7FFCFCA57AF8]
       mov       rdi,rax
       jmp       near ptr M01_L02
M01_L10:
       mov       rcx,rdi
       mov       rdx,7FFCFD431D40
       call      qword ptr [7FFCFCA57AF8]
       mov       rcx,rax
       jmp       near ptr M01_L03
M01_L11:
       mov       rcx,rdi
       mov       rdx,7FFCFD432028
       call      qword ptr [7FFCFCA57AF8]
       mov       r11,rax
       jmp       near ptr M01_L04
M01_L12:
       mov       dword ptr [rbp-28],1
       mov       rcx,[rdi+18]
       cmp       qword ptr [rcx+8],48
       jle       short M01_L14
       mov       r11,[rcx+48]
       test      r11,r11
       je        short M01_L14
M01_L13:
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [r11]
       mov       rsi,rax
       jmp       near ptr M01_L06
M01_L14:
       mov       rcx,rdi
       mov       rdx,7FFCFD432040
       call      qword ptr [7FFCFCA57AF8]
       mov       r11,rax
       jmp       short M01_L13
M01_L15:
       mov       rcx,[rdi+18]
       cmp       qword ptr [rcx+8],30
       jle       near ptr M01_L21
       mov       r11,[rcx+30]
       test      r11,r11
       je        near ptr M01_L21
M01_L16:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp-30],rax
       mov       rcx,rax
       mov       r11,7FFCFC721468
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M01_L22
       mov       dword ptr [rbp-28],1
       mov       rcx,[rdi+18]
       cmp       qword ptr [rcx+8],38
       jle       short M01_L18
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M01_L18
M01_L17:
       mov       rcx,[rbp-30]
       call      qword ptr [r11]
       mov       rsi,rax
       jmp       short M01_L19
M01_L18:
       mov       rcx,rdi
       mov       rdx,7FFCFD431F70
       call      qword ptr [7FFCFCA57AF8]
       mov       r11,rax
       jmp       short M01_L17
M01_L19:
       mov       rcx,[rbp-30]
       mov       r11,7FFCFC721470
       call      qword ptr [r11]
       jmp       near ptr M01_L06
M01_L20:
       mov       ecx,11
       call      qword ptr [7FFCFCA57DF8]
       int       3
M01_L21:
       mov       rcx,rdi
       mov       rdx,7FFCFD431F58
       call      qword ptr [7FFCFCA57AF8]
       mov       r11,rax
       jmp       near ptr M01_L16
M01_L22:
       call      M01_L25
       jmp       near ptr M01_L05
M01_L23:
       lea       rdx,[rbp-28]
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax+20]
       mov       rsi,rax
       jmp       near ptr M01_L06
M01_L24:
       mov       rcx,7FFCFD424B68
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FFCFD0F5110]
       int       3
M01_L25:
       sub       rsp,28
       mov       rcx,[rbp-30]
       test      rcx,rcx
       je        short M01_L26
       mov       r11,7FFCFC721470
       call      qword ptr [r11]
M01_L26:
       nop
       add       rsp,28
       ret
; Total bytes of code 695
```
```assembly
; DotNetTips.Spargine.Extensions.ListExtensions.RemoveFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.__Canon)
; 			list = list.ArgumentNotNull();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			return list.Remove(item);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       rax,[rbp+10]
       mov       rax,[rax+18]
       mov       rax,[rax+10]
       mov       [rbp-18],rax
       cmp       qword ptr [rbp-18],0
       je        short M02_L00
       mov       rax,[rbp-18]
       mov       [rbp-10],rax
       jmp       short M02_L01
M02_L00:
       mov       rcx,[rbp+10]
       mov       rdx,7FFCFD1809B8
       call      qword ptr [7FFCFCA57AF8]
       mov       [rbp-10],rax
M02_L01:
       mov       rax,247442030C8
       mov       [rsp+20],rax
       mov       rcx,[rbp-10]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       mov       r9,247441F0008
       call      qword ptr [7FFCFCEAE898]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp+18],rax
       mov       rcx,[rbp+18]
       mov       rdx,[rbp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFCFC8F1838]
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 152
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
       call      qword ptr [7FFCFD0FD320]
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       lea       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFCFD0FD2F0]
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 60
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsAddRemoveCollectionBenchmark.RemoveFirst()
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
       xor       eax,eax
       mov       [rbp-40],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       rdi,rsi
       test      rsi,rsi
       je        near ptr M00_L09
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L10
       mov       rcx,rsi
       mov       r11,7FFCFC731DD0
       call      qword ptr [r11]
       test      eax,eax
       jg        short M00_L00
       xor       ecx,ecx
       mov       [rbp-40],ecx
       jmp       short M00_L01
M00_L00:
       mov       dword ptr [rbp-40],1
       mov       rcx,rsi
       mov       r11,7FFCFC731DD8
       xor       edx,edx
       call      qword ptr [r11]
       mov       rcx,rax
M00_L01:
       mov       rsi,rcx
M00_L02:
       cmp       byte ptr [rbp-40],0
       je        near ptr M00_L11
       mov       r14,[rdi+8]
       mov       r15d,[rdi+10]
       test      r14,r14
       je        near ptr M00_L12
       mov       r13d,[r14+8]
       cmp       r13d,r15d
       jb        near ptr M00_L13
       test      rsi,rsi
       je        near ptr M00_L14
       xor       r12d,r12d
       test      r15d,r15d
       jle       near ptr M00_L17
       cmp       r13d,r15d
       jl        near ptr M00_L19
M00_L03:
       mov       ecx,r12d
       mov       rcx,[r14+rcx*8+10]
       test      rcx,rcx
       je        near ptr M00_L18
       mov       rdx,rsi
       mov       r11,7FFCFC731DE0
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M00_L18
M00_L04:
       mov       r9d,r12d
M00_L05:
       test      r9d,r9d
       jl        near ptr M00_L25
       cmp       r9d,[rdi+10]
       jae       near ptr M00_L08
       mov       eax,[rdi+10]
       dec       eax
       mov       [rdi+10],eax
       cmp       r9d,eax
       jge       near ptr M00_L06
       mov       r8,[rdi+8]
       mov       rcx,r8
       lea       edx,[r9+1]
       sub       eax,r9d
       test      rcx,rcx
       je        near ptr M00_L24
       mov       r10,[rcx]
       cmp       dword ptr [r10+4],18
       jne       near ptr M00_L24
       mov       r11d,eax
       or        r11d,edx
       jl        near ptr M00_L24
       lea       r11d,[rdx+rax]
       mov       esi,[rcx+8]
       cmp       r11d,esi
       ja        near ptr M00_L24
       lea       r11d,[r9+rax]
       cmp       r11d,esi
       ja        near ptr M00_L24
       movzx     r8d,word ptr [r10]
       imul      rax,r8
       add       rcx,10
       imul      rdx,r8
       add       rdx,rcx
       mov       r9d,r9d
       imul      r8,r9
       add       rcx,r8
       test      dword ptr [r10],1000000
       je        near ptr M00_L23
       cmp       rax,4000
       ja        near ptr M00_L22
       mov       r8,rax
       call      00007FFD5C3C5D60
       cmp       dword ptr [7FFD5C72F778],0
       jne       near ptr M00_L21
M00_L06:
       mov       rax,[rdi+8]
       movsxd    rcx,dword ptr [rdi+10]
       mov       edx,[rax+8]
       cmp       rcx,rdx
       jae       near ptr M00_L26
       xor       edx,edx
       mov       [rax+rcx*8+10],rdx
       inc       dword ptr [rdi+14]
       mov       esi,1
M00_L07:
       mov       rax,[rbx+60]
       mov       [rax+4C],sil
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
M00_L08:
       call      qword ptr [7FFCFD0F48B8]
       int       3
M00_L09:
       mov       ecx,11
       call      qword ptr [7FFCFC7EF930]
       int       3
M00_L10:
       lea       rdx,[rbp-40]
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax+20]
       mov       rsi,rax
       jmp       near ptr M00_L02
M00_L11:
       call      qword ptr [7FFCFD0F4CA8]
       int       3
M00_L12:
       mov       ecx,2
       call      qword ptr [7FFCFC7EFD38]
       int       3
M00_L13:
       call      qword ptr [7FFCFD3272D0]
       int       3
M00_L14:
       xor       r9d,r9d
       cmp       r9d,r15d
       jge       short M00_L17
M00_L15:
       cmp       r9d,r13d
       jae       near ptr M00_L26
       mov       ecx,r9d
       cmp       qword ptr [r14+rcx*8+10],0
       je        short M00_L16
       inc       r9d
       cmp       r9d,r15d
       jl        short M00_L15
       jmp       short M00_L17
M00_L16:
       jmp       near ptr M00_L05
M00_L17:
       mov       r9d,0FFFFFFFF
       jmp       near ptr M00_L05
M00_L18:
       inc       r12d
       cmp       r12d,r15d
       jl        near ptr M00_L03
       jmp       short M00_L17
M00_L19:
       cmp       r12d,r13d
       jae       short M00_L26
       mov       ecx,r12d
       mov       rcx,[r14+rcx*8+10]
       test      rcx,rcx
       je        short M00_L20
       mov       rdx,rsi
       mov       r11,7FFCFC731DE0
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L04
M00_L20:
       inc       r12d
       cmp       r12d,r15d
       jl        short M00_L19
       jmp       short M00_L17
M00_L21:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L06
M00_L22:
       mov       r8,rax
       call      qword ptr [7FFCFD00C948]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L06
M00_L23:
       mov       r8,rax
       call      qword ptr [7FFCFC7E5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L06
M00_L24:
       mov       [rsp+20],eax
       xor       eax,eax
       mov       [rsp+28],eax
       call      qword ptr [7FFCFD1B4C60]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M00_L06
M00_L25:
       xor       esi,esi
       jmp       near ptr M00_L07
M00_L26:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 759
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
; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       cmp       rsi,rbx
       je        short M02_L03
       mov       rcx,rbx
       sub       rcx,rsi
       cmp       rcx,rdi
       jb        short M02_L06
M02_L00:
       add       rdi,0FFFFFFFFFFFFC000
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,4000
       call      00007FFD5C3C5D60
       add       rbx,4000
       add       rsi,4000
       cmp       dword ptr [7FFD5C72F778],0
       jne       short M02_L04
M02_L01:
       cmp       rdi,4000
       ja        short M02_L00
M02_L02:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       call      00007FFD5C3C5D60
       cmp       dword ptr [7FFD5C72F778],0
       jne       short M02_L05
M02_L03:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L04:
       call      CORINFO_HELP_POLL_GC
       jmp       short M02_L01
M02_L05:
       call      CORINFO_HELP_POLL_GC
       jmp       short M02_L03
M02_L06:
       add       rdi,0FFFFFFFFFFFFC000
       lea       rcx,[rbx+rdi]
       lea       rdx,[rsi+rdi]
       mov       r8d,4000
       call      00007FFD5C3C5D60
       cmp       dword ptr [7FFD5C72F778],0
       je        short M02_L07
       call      CORINFO_HELP_POLL_GC
M02_L07:
       cmp       rdi,4000
       ja        short M02_L06
       jmp       short M02_L02
; Total bytes of code 184
```
```assembly
; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M03_L10
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M03_L10
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       ja        short M03_L03
       test      r8b,18
       je        short M03_L01
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
M03_L00:
       vzeroupper
       ret
M03_L01:
       test      r8b,4
       je        short M03_L02
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
       jmp       short M03_L00
M03_L02:
       test      r8,r8
       je        short M03_L00
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M03_L00
       movsx     r8,word ptr [rax-2]
       mov       [r10-2],r8w
       jmp       short M03_L00
M03_L03:
       cmp       r8,40
       ja        short M03_L07
M03_L04:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       jbe       short M03_L05
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       ja        short M03_L06
M03_L05:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
       jmp       short M03_L00
M03_L06:
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M03_L05
M03_L07:
       cmp       r8,800
       ja        short M03_L11
       cmp       r8,100
       jb        short M03_L08
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
M03_L08:
       mov       r9,r8
       shr       r9,6
M03_L09:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M03_L09
       and       r8,3F
       cmp       r8,10
       ja        near ptr M03_L04
       jmp       near ptr M03_L05
M03_L10:
       cmp       rcx,rdx
       jne       short M03_L11
       cmp       [rdx],dl
       jmp       near ptr M03_L00
M03_L11:
       cmp       [rcx],cl
       cmp       [rdx],dl
       vzeroupper
       jmp       qword ptr [7FFCFC7E66E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 319
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
       je        near ptr M04_L07
       test      rsi,rsi
       je        near ptr M04_L06
       mov       rcx,[rbx]
       cmp       rcx,[rsi]
       je        short M04_L00
       mov       rcx,[rbx]
       mov       ecx,[rcx+4]
       add       ecx,0FFFFFFE8
       shr       ecx,3
       mov       edx,1
       test      ecx,ecx
       cmove     ecx,edx
       mov       rdx,[rsi]
       mov       edx,[rdx+4]
       add       edx,0FFFFFFE8
       shr       edx,3
       mov       eax,1
       test      edx,edx
       cmove     edx,eax
       cmp       ecx,edx
       jne       near ptr M04_L08
M04_L00:
       mov       r14d,[rsp+70]
       test      r14d,r14d
       jl        near ptr M04_L09
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFD5A7A9400]; Precode of System.Array.GetLowerBound(Int32)
       cmp       edi,eax
       jge       short M04_L01
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,edi
       mov       edx,eax
       call      qword ptr [7FFD5A7C09C8]
       int       3
M04_L01:
       sub       edi,eax
       js        near ptr M04_L10
       lea       ecx,[rdi+r14]
       cmp       ecx,[rbx+8]
       ja        near ptr M04_L10
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFD5A7A9400]; Precode of System.Array.GetLowerBound(Int32)
       cmp       ebp,eax
       jge       short M04_L02
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,ebp
       mov       edx,eax
       call      qword ptr [7FFD5A7C09C8]
       int       3
M04_L02:
       sub       ebp,eax
       js        near ptr M04_L11
       lea       ecx,[r14+rbp]
       cmp       ecx,[rsi+8]
       ja        near ptr M04_L11
       mov       rcx,[rbx]
       cmp       rcx,[rsi]
       je        short M04_L03
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFD5A7A9320]
       test      eax,eax
       je        short M04_L03
       cmp       byte ptr [rsp+78],0
       jne       near ptr M04_L16
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
M04_L03:
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
       jne       short M04_L04
       cmp       r8,14
       jne       near ptr M04_L15
       jmp       near ptr M04_L14
M04_L04:
       cmp       r8,4000
       ja        near ptr M04_L13
       jmp       near ptr M04_L12
M04_L05:
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M04_L06:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFD5A7AB268]
       int       3
M04_L07:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFD5A7AB268]
       int       3
M04_L08:
       call      qword ptr [7FFD5A7A2830]
       mov       rbx,rax
       call      qword ptr [7FFD5A7ADDB0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD5A7AC810]
       mov       rcx,rbx
       call      qword ptr [7FFD5A797FA8]; CORINFO_HELP_THROW
       int       3
M04_L09:
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       ecx,r14d
       call      qword ptr [7FFD5A7C09B0]
       int       3
M04_L10:
       call      qword ptr [7FFD5A7A25F8]
       mov       rbx,rax
       call      qword ptr [7FFD5A7ACC68]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,rbx
       call      qword ptr [7FFD5A7AB218]
       mov       rcx,rbx
       call      qword ptr [7FFD5A797FA8]; CORINFO_HELP_THROW
       int       3
M04_L11:
       call      qword ptr [7FFD5A7A25F8]
       mov       r14,rax
       call      qword ptr [7FFD5A7ACC60]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,r14
       call      qword ptr [7FFD5A7AB218]
       mov       rcx,r14
       call      qword ptr [7FFD5A797FA8]; CORINFO_HELP_THROW
       int       3
M04_L12:
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FFD5A7A96A0]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       je        near ptr M04_L05
       call      qword ptr [7FFD5A798028]; CORINFO_HELP_POLL_GC
       jmp       near ptr M04_L05
M04_L13:
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
M04_L14:
       movups    xmm0,[r10]
       movups    xmm1,[r10+4]
       movups    [rdx],xmm0
       movups    [rdx+4],xmm1
       jmp       near ptr M04_L05
M04_L15:
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FFD5A7AC980]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M04_L05
M04_L16:
       call      qword ptr [7FFD5A7A2620]
       mov       rbx,rax
       call      qword ptr [7FFD5A7AD730]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD5A7AB298]
       mov       rcx,rbx
       call      qword ptr [7FFD5A797FA8]; CORINFO_HELP_THROW
       int       3
; Total bytes of code 748
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsAddRemoveCollectionBenchmark.RemoveFirst()
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
       xor       eax,eax
       mov       [rbp-40],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       rdi,rsi
       test      rsi,rsi
       je        near ptr M00_L09
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L10
       mov       rcx,rsi
       mov       r11,7FFCFC721C68
       call      qword ptr [r11]
       test      eax,eax
       jg        short M00_L00
       xor       ecx,ecx
       mov       [rbp-40],ecx
       jmp       short M00_L01
M00_L00:
       mov       dword ptr [rbp-40],1
       mov       rcx,rsi
       mov       r11,7FFCFC721C70
       xor       edx,edx
       call      qword ptr [r11]
       mov       rcx,rax
M00_L01:
       mov       rsi,rcx
M00_L02:
       cmp       byte ptr [rbp-40],0
       je        near ptr M00_L11
       mov       r14,[rdi+8]
       mov       r15d,[rdi+10]
       test      r14,r14
       je        near ptr M00_L12
       mov       r13d,[r14+8]
       cmp       r13d,r15d
       jb        near ptr M00_L13
       test      rsi,rsi
       je        near ptr M00_L14
       xor       r12d,r12d
       test      r15d,r15d
       jle       near ptr M00_L17
       cmp       r13d,r15d
       jl        near ptr M00_L19
M00_L03:
       mov       ecx,r12d
       mov       rcx,[r14+rcx*8+10]
       test      rcx,rcx
       je        near ptr M00_L18
       mov       rdx,rsi
       mov       r11,7FFCFC721C78
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M00_L18
M00_L04:
       mov       r9d,r12d
M00_L05:
       test      r9d,r9d
       jl        near ptr M00_L25
       cmp       r9d,[rdi+10]
       jae       near ptr M00_L08
       mov       eax,[rdi+10]
       dec       eax
       mov       [rdi+10],eax
       cmp       r9d,eax
       jge       near ptr M00_L06
       mov       r8,[rdi+8]
       mov       rcx,r8
       lea       edx,[r9+1]
       sub       eax,r9d
       test      rcx,rcx
       je        near ptr M00_L24
       mov       r10,[rcx]
       cmp       dword ptr [r10+4],18
       jne       near ptr M00_L24
       mov       r11d,eax
       or        r11d,edx
       jl        near ptr M00_L24
       lea       r11d,[rdx+rax]
       mov       esi,[rcx+8]
       cmp       r11d,esi
       ja        near ptr M00_L24
       lea       r11d,[r9+rax]
       cmp       r11d,esi
       ja        near ptr M00_L24
       movzx     r8d,word ptr [r10]
       imul      rax,r8
       add       rcx,10
       imul      rdx,r8
       add       rdx,rcx
       mov       r9d,r9d
       imul      r8,r9
       add       rcx,r8
       test      dword ptr [r10],1000000
       je        near ptr M00_L23
       cmp       rax,4000
       ja        near ptr M00_L22
       mov       r8,rax
       call      00007FFD5C3C5D60
       cmp       dword ptr [7FFD5C72F778],0
       jne       near ptr M00_L21
M00_L06:
       mov       rax,[rdi+8]
       movsxd    rcx,dword ptr [rdi+10]
       mov       edx,[rax+8]
       cmp       rcx,rdx
       jae       near ptr M00_L26
       xor       edx,edx
       mov       [rax+rcx*8+10],rdx
       inc       dword ptr [rdi+14]
       mov       esi,1
M00_L07:
       mov       rax,[rbx+60]
       mov       [rax+4C],sil
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
M00_L08:
       call      qword ptr [7FFCFD0648E8]
       int       3
M00_L09:
       mov       ecx,11
       call      qword ptr [7FFCFC7DF930]
       int       3
M00_L10:
       lea       rdx,[rbp-40]
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax+20]
       mov       rsi,rax
       jmp       near ptr M00_L02
M00_L11:
       call      qword ptr [7FFCFD064CD8]
       int       3
M00_L12:
       mov       ecx,2
       call      qword ptr [7FFCFC7DFD38]
       int       3
M00_L13:
       call      qword ptr [7FFCFD317678]
       int       3
M00_L14:
       xor       r9d,r9d
       cmp       r9d,r15d
       jge       short M00_L17
M00_L15:
       cmp       r9d,r13d
       jae       near ptr M00_L26
       mov       ecx,r9d
       cmp       qword ptr [r14+rcx*8+10],0
       je        short M00_L16
       inc       r9d
       cmp       r9d,r15d
       jl        short M00_L15
       jmp       short M00_L17
M00_L16:
       jmp       near ptr M00_L05
M00_L17:
       mov       r9d,0FFFFFFFF
       jmp       near ptr M00_L05
M00_L18:
       inc       r12d
       cmp       r12d,r15d
       jl        near ptr M00_L03
       jmp       short M00_L17
M00_L19:
       cmp       r12d,r13d
       jae       short M00_L26
       mov       ecx,r12d
       mov       rcx,[r14+rcx*8+10]
       test      rcx,rcx
       je        short M00_L20
       mov       rdx,rsi
       mov       r11,7FFCFC721C78
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L04
M00_L20:
       inc       r12d
       cmp       r12d,r15d
       jl        short M00_L19
       jmp       short M00_L17
M00_L21:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L06
M00_L22:
       mov       r8,rax
       call      qword ptr [7FFCFCEAE370]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L06
M00_L23:
       mov       r8,rax
       call      qword ptr [7FFCFC7D5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L06
M00_L24:
       mov       [rsp+20],eax
       xor       eax,eax
       mov       [rsp+28],eax
       call      qword ptr [7FFCFD1B4CA8]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M00_L06
M00_L25:
       xor       esi,esi
       jmp       near ptr M00_L07
M00_L26:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 759
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
; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       cmp       rsi,rbx
       je        short M02_L03
       mov       rcx,rbx
       sub       rcx,rsi
       cmp       rcx,rdi
       jb        short M02_L06
M02_L00:
       add       rdi,0FFFFFFFFFFFFC000
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,4000
       call      00007FFD5C3C5D60
       add       rbx,4000
       add       rsi,4000
       cmp       dword ptr [7FFD5C72F778],0
       jne       short M02_L04
M02_L01:
       cmp       rdi,4000
       ja        short M02_L00
M02_L02:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       call      00007FFD5C3C5D60
       cmp       dword ptr [7FFD5C72F778],0
       jne       short M02_L05
M02_L03:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L04:
       call      CORINFO_HELP_POLL_GC
       jmp       short M02_L01
M02_L05:
       call      CORINFO_HELP_POLL_GC
       jmp       short M02_L03
M02_L06:
       add       rdi,0FFFFFFFFFFFFC000
       lea       rcx,[rbx+rdi]
       lea       rdx,[rsi+rdi]
       mov       r8d,4000
       call      00007FFD5C3C5D60
       cmp       dword ptr [7FFD5C72F778],0
       je        short M02_L07
       call      CORINFO_HELP_POLL_GC
M02_L07:
       cmp       rdi,4000
       ja        short M02_L06
       jmp       short M02_L02
; Total bytes of code 184
```
```assembly
; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M03_L10
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M03_L10
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       ja        short M03_L03
       test      r8b,18
       je        short M03_L01
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
M03_L00:
       vzeroupper
       ret
M03_L01:
       test      r8b,4
       je        short M03_L02
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
       jmp       short M03_L00
M03_L02:
       test      r8,r8
       je        short M03_L00
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M03_L00
       movsx     r8,word ptr [rax-2]
       mov       [r10-2],r8w
       jmp       short M03_L00
M03_L03:
       cmp       r8,40
       ja        short M03_L07
M03_L04:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       jbe       short M03_L05
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       ja        short M03_L06
M03_L05:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
       jmp       short M03_L00
M03_L06:
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M03_L05
M03_L07:
       cmp       r8,800
       ja        short M03_L11
       cmp       r8,100
       jb        short M03_L08
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
M03_L08:
       mov       r9,r8
       shr       r9,6
M03_L09:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M03_L09
       and       r8,3F
       cmp       r8,10
       ja        near ptr M03_L04
       jmp       near ptr M03_L05
M03_L10:
       cmp       rcx,rdx
       jne       short M03_L11
       cmp       [rdx],dl
       jmp       near ptr M03_L00
M03_L11:
       cmp       [rcx],cl
       cmp       [rdx],dl
       vzeroupper
       jmp       qword ptr [7FFCFC7D66E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 319
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
       je        near ptr M04_L07
       test      rsi,rsi
       je        near ptr M04_L06
       mov       rcx,[rbx]
       cmp       rcx,[rsi]
       je        short M04_L00
       mov       rcx,[rbx]
       mov       ecx,[rcx+4]
       add       ecx,0FFFFFFE8
       shr       ecx,3
       mov       edx,1
       test      ecx,ecx
       cmove     ecx,edx
       mov       rdx,[rsi]
       mov       edx,[rdx+4]
       add       edx,0FFFFFFE8
       shr       edx,3
       mov       eax,1
       test      edx,edx
       cmove     edx,eax
       cmp       ecx,edx
       jne       near ptr M04_L08
M04_L00:
       mov       r14d,[rsp+70]
       test      r14d,r14d
       jl        near ptr M04_L09
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFD5A7A9400]; Precode of System.Array.GetLowerBound(Int32)
       cmp       edi,eax
       jge       short M04_L01
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,edi
       mov       edx,eax
       call      qword ptr [7FFD5A7C09C8]
       int       3
M04_L01:
       sub       edi,eax
       js        near ptr M04_L10
       lea       ecx,[rdi+r14]
       cmp       ecx,[rbx+8]
       ja        near ptr M04_L10
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFD5A7A9400]; Precode of System.Array.GetLowerBound(Int32)
       cmp       ebp,eax
       jge       short M04_L02
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,ebp
       mov       edx,eax
       call      qword ptr [7FFD5A7C09C8]
       int       3
M04_L02:
       sub       ebp,eax
       js        near ptr M04_L11
       lea       ecx,[r14+rbp]
       cmp       ecx,[rsi+8]
       ja        near ptr M04_L11
       mov       rcx,[rbx]
       cmp       rcx,[rsi]
       je        short M04_L03
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFD5A7A9320]
       test      eax,eax
       je        short M04_L03
       cmp       byte ptr [rsp+78],0
       jne       near ptr M04_L16
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
M04_L03:
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
       jne       short M04_L04
       cmp       r8,14
       jne       near ptr M04_L15
       jmp       near ptr M04_L14
M04_L04:
       cmp       r8,4000
       ja        near ptr M04_L13
       jmp       near ptr M04_L12
M04_L05:
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M04_L06:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFD5A7AB268]
       int       3
M04_L07:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFD5A7AB268]
       int       3
M04_L08:
       call      qword ptr [7FFD5A7A2830]
       mov       rbx,rax
       call      qword ptr [7FFD5A7ADDB0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD5A7AC810]
       mov       rcx,rbx
       call      qword ptr [7FFD5A797FA8]; CORINFO_HELP_THROW
       int       3
M04_L09:
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       ecx,r14d
       call      qword ptr [7FFD5A7C09B0]
       int       3
M04_L10:
       call      qword ptr [7FFD5A7A25F8]
       mov       rbx,rax
       call      qword ptr [7FFD5A7ACC68]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,rbx
       call      qword ptr [7FFD5A7AB218]
       mov       rcx,rbx
       call      qword ptr [7FFD5A797FA8]; CORINFO_HELP_THROW
       int       3
M04_L11:
       call      qword ptr [7FFD5A7A25F8]
       mov       r14,rax
       call      qword ptr [7FFD5A7ACC60]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,r14
       call      qword ptr [7FFD5A7AB218]
       mov       rcx,r14
       call      qword ptr [7FFD5A797FA8]; CORINFO_HELP_THROW
       int       3
M04_L12:
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FFD5A7A96A0]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       je        near ptr M04_L05
       call      qword ptr [7FFD5A798028]; CORINFO_HELP_POLL_GC
       jmp       near ptr M04_L05
M04_L13:
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
M04_L14:
       movups    xmm0,[r10]
       movups    xmm1,[r10+4]
       movups    [rdx],xmm0
       movups    [rdx+4],xmm1
       jmp       near ptr M04_L05
M04_L15:
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FFD5A7AC980]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M04_L05
M04_L16:
       call      qword ptr [7FFD5A7A2620]
       mov       rbx,rax
       call      qword ptr [7FFD5A7AD730]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD5A7AB298]
       mov       rcx,rbx
       call      qword ptr [7FFD5A797FA8]; CORINFO_HELP_THROW
       int       3
; Total bytes of code 748
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsAddRemoveCollectionBenchmark.RemoveFirst()
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
       xor       eax,eax
       mov       [rbp-40],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       rdi,rsi
       test      rsi,rsi
       je        near ptr M00_L09
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L10
       mov       rcx,rsi
       mov       r11,7FFCFC741D90
       call      qword ptr [r11]
       test      eax,eax
       jg        short M00_L00
       xor       ecx,ecx
       mov       [rbp-40],ecx
       jmp       short M00_L01
M00_L00:
       mov       dword ptr [rbp-40],1
       mov       rcx,rsi
       mov       r11,7FFCFC741D98
       xor       edx,edx
       call      qword ptr [r11]
       mov       rcx,rax
M00_L01:
       mov       rsi,rcx
M00_L02:
       cmp       byte ptr [rbp-40],0
       je        near ptr M00_L11
       mov       r14,[rdi+8]
       mov       r15d,[rdi+10]
       test      r14,r14
       je        near ptr M00_L12
       mov       r13d,[r14+8]
       cmp       r13d,r15d
       jb        near ptr M00_L13
       test      rsi,rsi
       je        near ptr M00_L14
       xor       r12d,r12d
       test      r15d,r15d
       jle       near ptr M00_L17
       cmp       r13d,r15d
       jl        near ptr M00_L19
M00_L03:
       mov       ecx,r12d
       mov       rcx,[r14+rcx*8+10]
       test      rcx,rcx
       je        near ptr M00_L18
       mov       rdx,rsi
       mov       r11,7FFCFC741DA0
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M00_L18
M00_L04:
       mov       r9d,r12d
M00_L05:
       test      r9d,r9d
       jl        near ptr M00_L25
       cmp       r9d,[rdi+10]
       jae       near ptr M00_L08
       mov       eax,[rdi+10]
       dec       eax
       mov       [rdi+10],eax
       cmp       r9d,eax
       jge       near ptr M00_L06
       mov       r8,[rdi+8]
       mov       rcx,r8
       lea       edx,[r9+1]
       sub       eax,r9d
       test      rcx,rcx
       je        near ptr M00_L24
       mov       r10,[rcx]
       cmp       dword ptr [r10+4],18
       jne       near ptr M00_L24
       mov       r11d,eax
       or        r11d,edx
       jl        near ptr M00_L24
       lea       r11d,[rdx+rax]
       mov       esi,[rcx+8]
       cmp       r11d,esi
       ja        near ptr M00_L24
       lea       r11d,[r9+rax]
       cmp       r11d,esi
       ja        near ptr M00_L24
       movzx     r8d,word ptr [r10]
       imul      rax,r8
       add       rcx,10
       imul      rdx,r8
       add       rdx,rcx
       mov       r9d,r9d
       imul      r8,r9
       add       rcx,r8
       test      dword ptr [r10],1000000
       je        near ptr M00_L23
       cmp       rax,4000
       ja        near ptr M00_L22
       mov       r8,rax
       call      00007FFD5C3C5D60
       cmp       dword ptr [7FFD5C72F778],0
       jne       near ptr M00_L21
M00_L06:
       mov       rax,[rdi+8]
       movsxd    rcx,dword ptr [rdi+10]
       mov       edx,[rax+8]
       cmp       rcx,rdx
       jae       near ptr M00_L26
       xor       edx,edx
       mov       [rax+rcx*8+10],rdx
       inc       dword ptr [rdi+14]
       mov       esi,1
M00_L07:
       mov       rax,[rbx+60]
       mov       [rax+4C],sil
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
M00_L08:
       call      qword ptr [7FFCFD104870]
       int       3
M00_L09:
       mov       ecx,11
       call      qword ptr [7FFCFC7FF930]
       int       3
M00_L10:
       lea       rdx,[rbp-40]
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax+20]
       mov       rsi,rax
       jmp       near ptr M00_L02
M00_L11:
       call      qword ptr [7FFCFD104C60]
       int       3
M00_L12:
       mov       ecx,2
       call      qword ptr [7FFCFC7FFD38]
       int       3
M00_L13:
       call      qword ptr [7FFCFD337648]
       int       3
M00_L14:
       xor       r9d,r9d
       cmp       r9d,r15d
       jge       short M00_L17
M00_L15:
       cmp       r9d,r13d
       jae       near ptr M00_L26
       mov       ecx,r9d
       cmp       qword ptr [r14+rcx*8+10],0
       je        short M00_L16
       inc       r9d
       cmp       r9d,r15d
       jl        short M00_L15
       jmp       short M00_L17
M00_L16:
       jmp       near ptr M00_L05
M00_L17:
       mov       r9d,0FFFFFFFF
       jmp       near ptr M00_L05
M00_L18:
       inc       r12d
       cmp       r12d,r15d
       jl        near ptr M00_L03
       jmp       short M00_L17
M00_L19:
       cmp       r12d,r13d
       jae       short M00_L26
       mov       ecx,r12d
       mov       rcx,[r14+rcx*8+10]
       test      rcx,rcx
       je        short M00_L20
       mov       rdx,rsi
       mov       r11,7FFCFC741DA0
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L04
M00_L20:
       inc       r12d
       cmp       r12d,r15d
       jl        short M00_L19
       jmp       short M00_L17
M00_L21:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L06
M00_L22:
       mov       r8,rax
       call      qword ptr [7FFCFD01C900]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L06
M00_L23:
       mov       r8,rax
       call      qword ptr [7FFCFC7F5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L06
M00_L24:
       mov       [rsp+20],eax
       xor       eax,eax
       mov       [rsp+28],eax
       call      qword ptr [7FFCFD1D4E28]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M00_L06
M00_L25:
       xor       esi,esi
       jmp       near ptr M00_L07
M00_L26:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 759
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
; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       cmp       rsi,rbx
       je        short M02_L03
       mov       rcx,rbx
       sub       rcx,rsi
       cmp       rcx,rdi
       jb        short M02_L06
M02_L00:
       add       rdi,0FFFFFFFFFFFFC000
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,4000
       call      00007FFD5C3C5D60
       add       rbx,4000
       add       rsi,4000
       cmp       dword ptr [7FFD5C72F778],0
       jne       short M02_L04
M02_L01:
       cmp       rdi,4000
       ja        short M02_L00
M02_L02:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       call      00007FFD5C3C5D60
       cmp       dword ptr [7FFD5C72F778],0
       jne       short M02_L05
M02_L03:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L04:
       call      CORINFO_HELP_POLL_GC
       jmp       short M02_L01
M02_L05:
       call      CORINFO_HELP_POLL_GC
       jmp       short M02_L03
M02_L06:
       add       rdi,0FFFFFFFFFFFFC000
       lea       rcx,[rbx+rdi]
       lea       rdx,[rsi+rdi]
       mov       r8d,4000
       call      00007FFD5C3C5D60
       cmp       dword ptr [7FFD5C72F778],0
       je        short M02_L07
       call      CORINFO_HELP_POLL_GC
M02_L07:
       cmp       rdi,4000
       ja        short M02_L06
       jmp       short M02_L02
; Total bytes of code 184
```
```assembly
; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M03_L10
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M03_L10
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       ja        short M03_L03
       test      r8b,18
       je        short M03_L01
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
M03_L00:
       vzeroupper
       ret
M03_L01:
       test      r8b,4
       je        short M03_L02
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
       jmp       short M03_L00
M03_L02:
       test      r8,r8
       je        short M03_L00
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M03_L00
       movsx     r8,word ptr [rax-2]
       mov       [r10-2],r8w
       jmp       short M03_L00
M03_L03:
       cmp       r8,40
       ja        short M03_L07
M03_L04:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       jbe       short M03_L05
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       ja        short M03_L06
M03_L05:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
       jmp       short M03_L00
M03_L06:
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M03_L05
M03_L07:
       cmp       r8,800
       ja        short M03_L11
       cmp       r8,100
       jb        short M03_L08
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
M03_L08:
       mov       r9,r8
       shr       r9,6
M03_L09:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M03_L09
       and       r8,3F
       cmp       r8,10
       ja        near ptr M03_L04
       jmp       near ptr M03_L05
M03_L10:
       cmp       rcx,rdx
       jne       short M03_L11
       cmp       [rdx],dl
       jmp       near ptr M03_L00
M03_L11:
       cmp       [rcx],cl
       cmp       [rdx],dl
       vzeroupper
       jmp       qword ptr [7FFCFC7F66E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 319
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
       je        near ptr M04_L07
       test      rsi,rsi
       je        near ptr M04_L06
       mov       rcx,[rbx]
       cmp       rcx,[rsi]
       je        short M04_L00
       mov       rcx,[rbx]
       mov       ecx,[rcx+4]
       add       ecx,0FFFFFFE8
       shr       ecx,3
       mov       edx,1
       test      ecx,ecx
       cmove     ecx,edx
       mov       rdx,[rsi]
       mov       edx,[rdx+4]
       add       edx,0FFFFFFE8
       shr       edx,3
       mov       eax,1
       test      edx,edx
       cmove     edx,eax
       cmp       ecx,edx
       jne       near ptr M04_L08
M04_L00:
       mov       r14d,[rsp+70]
       test      r14d,r14d
       jl        near ptr M04_L09
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFD5A7A9400]; Precode of System.Array.GetLowerBound(Int32)
       cmp       edi,eax
       jge       short M04_L01
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,edi
       mov       edx,eax
       call      qword ptr [7FFD5A7C09C8]
       int       3
M04_L01:
       sub       edi,eax
       js        near ptr M04_L10
       lea       ecx,[rdi+r14]
       cmp       ecx,[rbx+8]
       ja        near ptr M04_L10
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFD5A7A9400]; Precode of System.Array.GetLowerBound(Int32)
       cmp       ebp,eax
       jge       short M04_L02
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,ebp
       mov       edx,eax
       call      qword ptr [7FFD5A7C09C8]
       int       3
M04_L02:
       sub       ebp,eax
       js        near ptr M04_L11
       lea       ecx,[r14+rbp]
       cmp       ecx,[rsi+8]
       ja        near ptr M04_L11
       mov       rcx,[rbx]
       cmp       rcx,[rsi]
       je        short M04_L03
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFD5A7A9320]
       test      eax,eax
       je        short M04_L03
       cmp       byte ptr [rsp+78],0
       jne       near ptr M04_L16
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
M04_L03:
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
       jne       short M04_L04
       cmp       r8,14
       jne       near ptr M04_L15
       jmp       near ptr M04_L14
M04_L04:
       cmp       r8,4000
       ja        near ptr M04_L13
       jmp       near ptr M04_L12
M04_L05:
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M04_L06:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFD5A7AB268]
       int       3
M04_L07:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFD5A7AB268]
       int       3
M04_L08:
       call      qword ptr [7FFD5A7A2830]
       mov       rbx,rax
       call      qword ptr [7FFD5A7ADDB0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD5A7AC810]
       mov       rcx,rbx
       call      qword ptr [7FFD5A797FA8]; CORINFO_HELP_THROW
       int       3
M04_L09:
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       ecx,r14d
       call      qword ptr [7FFD5A7C09B0]
       int       3
M04_L10:
       call      qword ptr [7FFD5A7A25F8]
       mov       rbx,rax
       call      qword ptr [7FFD5A7ACC68]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,rbx
       call      qword ptr [7FFD5A7AB218]
       mov       rcx,rbx
       call      qword ptr [7FFD5A797FA8]; CORINFO_HELP_THROW
       int       3
M04_L11:
       call      qword ptr [7FFD5A7A25F8]
       mov       r14,rax
       call      qword ptr [7FFD5A7ACC60]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,r14
       call      qword ptr [7FFD5A7AB218]
       mov       rcx,r14
       call      qword ptr [7FFD5A797FA8]; CORINFO_HELP_THROW
       int       3
M04_L12:
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FFD5A7A96A0]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       je        near ptr M04_L05
       call      qword ptr [7FFD5A798028]; CORINFO_HELP_POLL_GC
       jmp       near ptr M04_L05
M04_L13:
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
M04_L14:
       movups    xmm0,[r10]
       movups    xmm1,[r10+4]
       movups    [rdx],xmm0
       movups    [rdx+4],xmm1
       jmp       near ptr M04_L05
M04_L15:
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FFD5A7AC980]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M04_L05
M04_L16:
       call      qword ptr [7FFD5A7A2620]
       mov       rbx,rax
       call      qword ptr [7FFD5A7AD730]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD5A7AB298]
       mov       rcx,rbx
       call      qword ptr [7FFD5A797FA8]; CORINFO_HELP_THROW
       int       3
; Total bytes of code 748
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsAddRemoveCollectionBenchmark.RemoveFirst()
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
       xor       eax,eax
       mov       [rbp-40],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       rdi,rsi
       test      rsi,rsi
       je        near ptr M00_L09
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L10
       mov       rcx,rsi
       mov       r11,7FFCFC731DF8
       call      qword ptr [r11]
       test      eax,eax
       jg        near ptr M00_L05
       xor       ecx,ecx
       mov       [rbp-40],ecx
M00_L00:
       mov       rsi,rcx
M00_L01:
       cmp       byte ptr [rbp-40],0
       je        near ptr M00_L11
       mov       r14,[rdi+8]
       mov       r15d,[rdi+10]
       test      r14,r14
       je        near ptr M00_L12
       mov       r13d,[r14+8]
       cmp       r13d,r15d
       jb        near ptr M00_L13
       test      rsi,rsi
       je        near ptr M00_L14
       xor       r12d,r12d
       test      r15d,r15d
       jle       near ptr M00_L17
       cmp       r13d,r15d
       jl        near ptr M00_L19
M00_L02:
       mov       ecx,r12d
       mov       rcx,[r14+rcx*8+10]
       test      rcx,rcx
       je        near ptr M00_L18
       mov       rdx,rsi
       mov       r11,7FFCFC731E08
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M00_L18
M00_L03:
       mov       r9d,r12d
M00_L04:
       test      r9d,r9d
       jl        near ptr M00_L25
       cmp       r9d,[rdi+10]
       jb        short M00_L06
       call      qword ptr [7FFCFD0F4A20]
       int       3
M00_L05:
       mov       dword ptr [rbp-40],1
       mov       rcx,rsi
       mov       r11,7FFCFC731E00
       xor       edx,edx
       call      qword ptr [r11]
       mov       rcx,rax
       jmp       near ptr M00_L00
M00_L06:
       mov       eax,[rdi+10]
       dec       eax
       mov       [rdi+10],eax
       cmp       r9d,eax
       jge       near ptr M00_L07
       mov       r8,[rdi+8]
       mov       rcx,r8
       lea       edx,[r9+1]
       sub       eax,r9d
       test      rcx,rcx
       je        near ptr M00_L24
       mov       r10,[rcx]
       cmp       dword ptr [r10+4],18
       jne       near ptr M00_L24
       mov       r11d,eax
       or        r11d,edx
       jl        near ptr M00_L24
       lea       r11d,[rdx+rax]
       mov       esi,[rcx+8]
       cmp       r11d,esi
       ja        near ptr M00_L24
       lea       r11d,[r9+rax]
       cmp       r11d,esi
       ja        near ptr M00_L24
       movzx     r8d,word ptr [r10]
       imul      rax,r8
       add       rcx,10
       imul      rdx,r8
       add       rdx,rcx
       mov       r9d,r9d
       imul      r8,r9
       add       rcx,r8
       test      dword ptr [r10],1000000
       je        near ptr M00_L23
       cmp       rax,4000
       ja        near ptr M00_L22
       mov       r8,rax
       call      00007FFD5C3C5D60
       cmp       dword ptr [7FFD5C72F778],0
       jne       near ptr M00_L21
M00_L07:
       mov       rax,[rdi+8]
       movsxd    rcx,dword ptr [rdi+10]
       mov       edx,[rax+8]
       cmp       rcx,rdx
       jae       near ptr M00_L26
       xor       edx,edx
       mov       [rax+rcx*8+10],rdx
       inc       dword ptr [rdi+14]
       mov       esi,1
M00_L08:
       mov       rax,[rbx+60]
       mov       [rax+4C],sil
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
M00_L09:
       mov       ecx,11
       call      qword ptr [7FFCFC7EF930]
       int       3
M00_L10:
       lea       rdx,[rbp-40]
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax+20]
       mov       rsi,rax
       jmp       near ptr M00_L01
M00_L11:
       call      qword ptr [7FFCFD0F4E10]
       int       3
M00_L12:
       mov       ecx,2
       call      qword ptr [7FFCFC7EFD38]
       int       3
M00_L13:
       call      qword ptr [7FFCFD3A7870]
       int       3
M00_L14:
       xor       r9d,r9d
       cmp       r9d,r15d
       jge       short M00_L17
M00_L15:
       cmp       r9d,r13d
       jae       near ptr M00_L26
       mov       ecx,r9d
       cmp       qword ptr [r14+rcx*8+10],0
       je        short M00_L16
       inc       r9d
       cmp       r9d,r15d
       jl        short M00_L15
       jmp       short M00_L17
M00_L16:
       jmp       near ptr M00_L04
M00_L17:
       mov       r9d,0FFFFFFFF
       jmp       near ptr M00_L04
M00_L18:
       inc       r12d
       cmp       r12d,r15d
       jl        near ptr M00_L02
       jmp       short M00_L17
M00_L19:
       cmp       r12d,r13d
       jae       short M00_L26
       mov       ecx,r12d
       mov       rcx,[r14+rcx*8+10]
       test      rcx,rcx
       je        short M00_L20
       mov       rdx,rsi
       mov       r11,7FFCFC731E08
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L03
M00_L20:
       inc       r12d
       cmp       r12d,r15d
       jl        short M00_L19
       jmp       short M00_L17
M00_L21:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L07
M00_L22:
       mov       r8,rax
       call      qword ptr [7FFCFD0049C0]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L07
M00_L23:
       mov       r8,rax
       call      qword ptr [7FFCFC7E5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L07
M00_L24:
       mov       [rsp+20],eax
       xor       eax,eax
       mov       [rsp+28],eax
       call      qword ptr [7FFCFD0F7A68]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M00_L07
M00_L25:
       xor       esi,esi
       jmp       near ptr M00_L08
M00_L26:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 762
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
; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       cmp       rsi,rbx
       je        short M02_L03
       mov       rcx,rbx
       sub       rcx,rsi
       cmp       rcx,rdi
       jb        short M02_L06
M02_L00:
       add       rdi,0FFFFFFFFFFFFC000
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,4000
       call      00007FFD5C3C5D60
       add       rbx,4000
       add       rsi,4000
       cmp       dword ptr [7FFD5C72F778],0
       jne       short M02_L04
M02_L01:
       cmp       rdi,4000
       ja        short M02_L00
M02_L02:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       call      00007FFD5C3C5D60
       cmp       dword ptr [7FFD5C72F778],0
       jne       short M02_L05
M02_L03:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L04:
       call      CORINFO_HELP_POLL_GC
       jmp       short M02_L01
M02_L05:
       call      CORINFO_HELP_POLL_GC
       jmp       short M02_L03
M02_L06:
       add       rdi,0FFFFFFFFFFFFC000
       lea       rcx,[rbx+rdi]
       lea       rdx,[rsi+rdi]
       mov       r8d,4000
       call      00007FFD5C3C5D60
       cmp       dword ptr [7FFD5C72F778],0
       je        short M02_L07
       call      CORINFO_HELP_POLL_GC
M02_L07:
       cmp       rdi,4000
       ja        short M02_L06
       jmp       short M02_L02
; Total bytes of code 184
```
```assembly
; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M03_L10
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M03_L10
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       ja        short M03_L03
       test      r8b,18
       je        short M03_L01
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
M03_L00:
       vzeroupper
       ret
M03_L01:
       test      r8b,4
       je        short M03_L02
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
       jmp       short M03_L00
M03_L02:
       test      r8,r8
       je        short M03_L00
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M03_L00
       movsx     r8,word ptr [rax-2]
       mov       [r10-2],r8w
       jmp       short M03_L00
M03_L03:
       cmp       r8,40
       ja        short M03_L07
M03_L04:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       jbe       short M03_L05
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       ja        short M03_L06
M03_L05:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
       jmp       short M03_L00
M03_L06:
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M03_L05
M03_L07:
       cmp       r8,800
       ja        short M03_L11
       cmp       r8,100
       jb        short M03_L08
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
M03_L08:
       mov       r9,r8
       shr       r9,6
M03_L09:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M03_L09
       and       r8,3F
       cmp       r8,10
       ja        near ptr M03_L04
       jmp       near ptr M03_L05
M03_L10:
       cmp       rcx,rdx
       jne       short M03_L11
       cmp       [rdx],dl
       jmp       near ptr M03_L00
M03_L11:
       cmp       [rcx],cl
       cmp       [rdx],dl
       vzeroupper
       jmp       qword ptr [7FFCFC7E66E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 319
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
       je        near ptr M04_L07
       test      rsi,rsi
       je        near ptr M04_L06
       mov       rcx,[rbx]
       cmp       rcx,[rsi]
       je        short M04_L00
       mov       rcx,[rbx]
       mov       ecx,[rcx+4]
       add       ecx,0FFFFFFE8
       shr       ecx,3
       mov       edx,1
       test      ecx,ecx
       cmove     ecx,edx
       mov       rdx,[rsi]
       mov       edx,[rdx+4]
       add       edx,0FFFFFFE8
       shr       edx,3
       mov       eax,1
       test      edx,edx
       cmove     edx,eax
       cmp       ecx,edx
       jne       near ptr M04_L08
M04_L00:
       mov       r14d,[rsp+70]
       test      r14d,r14d
       jl        near ptr M04_L09
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFD5A7A9400]; Precode of System.Array.GetLowerBound(Int32)
       cmp       edi,eax
       jge       short M04_L01
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,edi
       mov       edx,eax
       call      qword ptr [7FFD5A7C09C8]
       int       3
M04_L01:
       sub       edi,eax
       js        near ptr M04_L10
       lea       ecx,[rdi+r14]
       cmp       ecx,[rbx+8]
       ja        near ptr M04_L10
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFD5A7A9400]; Precode of System.Array.GetLowerBound(Int32)
       cmp       ebp,eax
       jge       short M04_L02
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,ebp
       mov       edx,eax
       call      qword ptr [7FFD5A7C09C8]
       int       3
M04_L02:
       sub       ebp,eax
       js        near ptr M04_L11
       lea       ecx,[r14+rbp]
       cmp       ecx,[rsi+8]
       ja        near ptr M04_L11
       mov       rcx,[rbx]
       cmp       rcx,[rsi]
       je        short M04_L03
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFD5A7A9320]
       test      eax,eax
       je        short M04_L03
       cmp       byte ptr [rsp+78],0
       jne       near ptr M04_L16
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
M04_L03:
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
       jne       short M04_L04
       cmp       r8,14
       jne       near ptr M04_L15
       jmp       near ptr M04_L14
M04_L04:
       cmp       r8,4000
       ja        near ptr M04_L13
       jmp       near ptr M04_L12
M04_L05:
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M04_L06:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFD5A7AB268]
       int       3
M04_L07:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFD5A7AB268]
       int       3
M04_L08:
       call      qword ptr [7FFD5A7A2830]
       mov       rbx,rax
       call      qword ptr [7FFD5A7ADDB0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD5A7AC810]
       mov       rcx,rbx
       call      qword ptr [7FFD5A797FA8]; CORINFO_HELP_THROW
       int       3
M04_L09:
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       ecx,r14d
       call      qword ptr [7FFD5A7C09B0]
       int       3
M04_L10:
       call      qword ptr [7FFD5A7A25F8]
       mov       rbx,rax
       call      qword ptr [7FFD5A7ACC68]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,rbx
       call      qword ptr [7FFD5A7AB218]
       mov       rcx,rbx
       call      qword ptr [7FFD5A797FA8]; CORINFO_HELP_THROW
       int       3
M04_L11:
       call      qword ptr [7FFD5A7A25F8]
       mov       r14,rax
       call      qword ptr [7FFD5A7ACC60]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,r14
       call      qword ptr [7FFD5A7AB218]
       mov       rcx,r14
       call      qword ptr [7FFD5A797FA8]; CORINFO_HELP_THROW
       int       3
M04_L12:
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FFD5A7A96A0]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       je        near ptr M04_L05
       call      qword ptr [7FFD5A798028]; CORINFO_HELP_POLL_GC
       jmp       near ptr M04_L05
M04_L13:
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
M04_L14:
       movups    xmm0,[r10]
       movups    xmm1,[r10+4]
       movups    [rdx],xmm0
       movups    [rdx+4],xmm1
       jmp       near ptr M04_L05
M04_L15:
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FFD5A7AC980]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M04_L05
M04_L16:
       call      qword ptr [7FFD5A7A2620]
       mov       rbx,rax
       call      qword ptr [7FFD5A7AD730]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD5A7AB298]
       mov       rcx,rbx
       call      qword ptr [7FFD5A797FA8]; CORINFO_HELP_THROW
       int       3
; Total bytes of code 748
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsAddRemoveCollectionBenchmark.RemoveFirst()
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
       xor       eax,eax
       mov       [rbp-40],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       rdi,rsi
       test      rsi,rsi
       je        near ptr M00_L10
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L11
       mov       rcx,rsi
       mov       r11,7FFCFC741FB0
       call      qword ptr [r11]
       test      eax,eax
       jg        near ptr M00_L05
       xor       ecx,ecx
       mov       [rbp-40],ecx
M00_L00:
       mov       rsi,rcx
M00_L01:
       cmp       byte ptr [rbp-40],0
       je        near ptr M00_L12
       mov       r14,[rdi+8]
       mov       r15d,[rdi+10]
       test      r14,r14
       je        near ptr M00_L13
       mov       r13d,[r14+8]
       cmp       r13d,r15d
       jb        near ptr M00_L14
       test      rsi,rsi
       je        near ptr M00_L15
       xor       r12d,r12d
       test      r15d,r15d
       jle       near ptr M00_L18
       cmp       r13d,r15d
       jl        near ptr M00_L20
M00_L02:
       mov       ecx,r12d
       mov       rcx,[r14+rcx*8+10]
       test      rcx,rcx
       je        near ptr M00_L19
       mov       rdx,rsi
       mov       r11,7FFCFC741FC0
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M00_L19
M00_L03:
       mov       r9d,r12d
M00_L04:
       test      r9d,r9d
       jl        near ptr M00_L25
       cmp       r9d,[rdi+10]
       jb        short M00_L06
       call      qword ptr [7FFCFD027510]
       int       3
M00_L05:
       mov       dword ptr [rbp-40],1
       mov       rcx,rsi
       mov       r11,7FFCFC741FB8
       xor       edx,edx
       call      qword ptr [r11]
       mov       rcx,rax
       jmp       near ptr M00_L00
M00_L06:
       mov       eax,[rdi+10]
       dec       eax
       mov       [rdi+10],eax
       cmp       r9d,eax
       jge       near ptr M00_L07
       mov       r8,[rdi+8]
       mov       rcx,r8
       lea       edx,[r9+1]
       sub       eax,r9d
       test      rcx,rcx
       je        near ptr M00_L24
       mov       r10,[rcx]
       cmp       dword ptr [r10+4],18
       jne       near ptr M00_L24
       mov       r11d,eax
       or        r11d,edx
       jl        near ptr M00_L24
       lea       r11d,[rdx+rax]
       mov       esi,[rcx+8]
       cmp       r11d,esi
       ja        near ptr M00_L24
       lea       r11d,[r9+rax]
       cmp       r11d,esi
       ja        near ptr M00_L24
       movzx     r8d,word ptr [r10]
       imul      rax,r8
       add       rcx,10
       imul      rdx,r8
       add       rdx,rcx
       mov       r9d,r9d
       imul      r8,r9
       add       rcx,r8
       test      dword ptr [r10],1000000
       je        short M00_L09
       cmp       rax,4000
       ja        near ptr M00_L23
       mov       r8,rax
       call      00007FFD5C3C5D60
       cmp       dword ptr [7FFD5C72F778],0
       jne       near ptr M00_L22
M00_L07:
       mov       rax,[rdi+8]
       movsxd    rcx,dword ptr [rdi+10]
       mov       edx,[rax+8]
       cmp       rcx,rdx
       jae       near ptr M00_L26
       xor       edx,edx
       mov       [rax+rcx*8+10],rdx
       inc       dword ptr [rdi+14]
       mov       esi,1
M00_L08:
       mov       rax,[rbx+60]
       mov       [rax+4C],sil
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
M00_L09:
       mov       r8,rax
       call      qword ptr [7FFCFC7F5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M00_L07
M00_L10:
       mov       ecx,11
       call      qword ptr [7FFCFC7FF930]
       int       3
M00_L11:
       lea       rdx,[rbp-40]
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax+20]
       mov       rsi,rax
       jmp       near ptr M00_L01
M00_L12:
       call      qword ptr [7FFCFD13DF20]
       int       3
M00_L13:
       mov       ecx,2
       call      qword ptr [7FFCFC7FFD38]
       int       3
M00_L14:
       call      qword ptr [7FFCFD3ECB88]
       int       3
M00_L15:
       xor       r9d,r9d
       cmp       r9d,r15d
       jge       short M00_L18
M00_L16:
       cmp       r9d,r13d
       jae       near ptr M00_L26
       mov       ecx,r9d
       cmp       qword ptr [r14+rcx*8+10],0
       je        short M00_L17
       inc       r9d
       cmp       r9d,r15d
       jl        short M00_L16
       jmp       short M00_L18
M00_L17:
       jmp       near ptr M00_L04
M00_L18:
       mov       r9d,0FFFFFFFF
       jmp       near ptr M00_L04
M00_L19:
       inc       r12d
       cmp       r12d,r15d
       jl        near ptr M00_L02
       jmp       short M00_L18
M00_L20:
       cmp       r12d,r13d
       jae       short M00_L26
       mov       ecx,r12d
       mov       rcx,[r14+rcx*8+10]
       test      rcx,rcx
       je        short M00_L21
       mov       rdx,rsi
       mov       r11,7FFCFC741FC0
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L03
M00_L21:
       inc       r12d
       cmp       r12d,r15d
       jl        short M00_L20
       jmp       short M00_L18
M00_L22:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L07
M00_L23:
       mov       r8,rax
       call      qword ptr [7FFCFCECE820]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L07
M00_L24:
       mov       [rsp+20],eax
       xor       eax,eax
       mov       [rsp+28],eax
       call      qword ptr [7FFCFD026238]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M00_L07
M00_L25:
       xor       esi,esi
       jmp       near ptr M00_L08
M00_L26:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 755
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
; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M02_L10
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M02_L10
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       ja        short M02_L03
       test      r8b,18
       jne       short M02_L02
       test      r8b,4
       je        short M02_L01
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
M02_L00:
       vzeroupper
       ret
M02_L01:
       test      r8,r8
       je        short M02_L00
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M02_L00
       movsx     rcx,word ptr [rax-2]
       mov       [r10-2],cx
       jmp       short M02_L00
M02_L02:
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rcx,[rax-8]
       mov       [r10-8],rcx
       jmp       short M02_L00
M02_L03:
       cmp       r8,40
       ja        short M02_L07
M02_L04:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        short M02_L06
M02_L05:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
       jmp       short M02_L00
M02_L06:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M02_L05
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M02_L05
M02_L07:
       cmp       r8,800
       ja        short M02_L11
       cmp       r8,100
       jb        short M02_L08
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
M02_L08:
       mov       r9,r8
       shr       r9,6
M02_L09:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M02_L09
       and       r8,3F
       cmp       r8,10
       ja        near ptr M02_L04
       jmp       near ptr M02_L05
M02_L10:
       cmp       rcx,rdx
       jne       short M02_L11
       cmp       [rdx],dl
       jmp       near ptr M02_L00
M02_L11:
       cmp       [rcx],cl
       cmp       [rdx],dl
       vzeroupper
       jmp       qword ptr [7FFCFC7F66E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 319
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
       je        short M03_L03
       mov       rcx,rbx
       sub       rcx,rsi
       cmp       rcx,rdi
       jb        short M03_L06
M03_L00:
       add       rdi,0FFFFFFFFFFFFC000
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,4000
       call      00007FFD5C3C5D60
       add       rbx,4000
       add       rsi,4000
       cmp       dword ptr [7FFD5C72F778],0
       jne       short M03_L04
M03_L01:
       cmp       rdi,4000
       ja        short M03_L00
M03_L02:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       call      00007FFD5C3C5D60
       cmp       dword ptr [7FFD5C72F778],0
       jne       short M03_L05
M03_L03:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M03_L04:
       call      CORINFO_HELP_POLL_GC
       jmp       short M03_L01
M03_L05:
       call      CORINFO_HELP_POLL_GC
       jmp       short M03_L03
M03_L06:
       add       rdi,0FFFFFFFFFFFFC000
       lea       rcx,[rbx+rdi]
       lea       rdx,[rsi+rdi]
       mov       r8d,4000
       call      00007FFD5C3C5D60
       cmp       dword ptr [7FFD5C72F778],0
       je        short M03_L07
       call      CORINFO_HELP_POLL_GC
M03_L07:
       cmp       rdi,4000
       ja        short M03_L06
       jmp       short M03_L02
; Total bytes of code 184
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
       je        near ptr M04_L07
       test      rsi,rsi
       je        near ptr M04_L06
       mov       rcx,[rbx]
       cmp       rcx,[rsi]
       je        short M04_L00
       mov       rcx,[rbx]
       mov       ecx,[rcx+4]
       add       ecx,0FFFFFFE8
       shr       ecx,3
       mov       edx,1
       test      ecx,ecx
       cmove     ecx,edx
       mov       rdx,[rsi]
       mov       edx,[rdx+4]
       add       edx,0FFFFFFE8
       shr       edx,3
       mov       eax,1
       test      edx,edx
       cmove     edx,eax
       cmp       ecx,edx
       jne       near ptr M04_L08
M04_L00:
       mov       r14d,[rsp+70]
       test      r14d,r14d
       jl        near ptr M04_L09
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFD5A7A9400]; Precode of System.Array.GetLowerBound(Int32)
       cmp       edi,eax
       jge       short M04_L01
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,edi
       mov       edx,eax
       call      qword ptr [7FFD5A7C09C8]
       int       3
M04_L01:
       sub       edi,eax
       js        near ptr M04_L10
       lea       ecx,[rdi+r14]
       cmp       ecx,[rbx+8]
       ja        near ptr M04_L10
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFD5A7A9400]; Precode of System.Array.GetLowerBound(Int32)
       cmp       ebp,eax
       jge       short M04_L02
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,ebp
       mov       edx,eax
       call      qword ptr [7FFD5A7C09C8]
       int       3
M04_L02:
       sub       ebp,eax
       js        near ptr M04_L11
       lea       ecx,[r14+rbp]
       cmp       ecx,[rsi+8]
       ja        near ptr M04_L11
       mov       rcx,[rbx]
       cmp       rcx,[rsi]
       je        short M04_L03
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFD5A7A9320]
       test      eax,eax
       je        short M04_L03
       cmp       byte ptr [rsp+78],0
       jne       near ptr M04_L16
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
M04_L03:
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
       jne       short M04_L04
       cmp       r8,14
       jne       near ptr M04_L15
       jmp       near ptr M04_L14
M04_L04:
       cmp       r8,4000
       ja        near ptr M04_L13
       jmp       near ptr M04_L12
M04_L05:
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M04_L06:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFD5A7AB268]
       int       3
M04_L07:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFD5A7AB268]
       int       3
M04_L08:
       call      qword ptr [7FFD5A7A2830]
       mov       rbx,rax
       call      qword ptr [7FFD5A7ADDB0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD5A7AC810]
       mov       rcx,rbx
       call      qword ptr [7FFD5A797FA8]; CORINFO_HELP_THROW
       int       3
M04_L09:
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       ecx,r14d
       call      qword ptr [7FFD5A7C09B0]
       int       3
M04_L10:
       call      qword ptr [7FFD5A7A25F8]
       mov       rbx,rax
       call      qword ptr [7FFD5A7ACC68]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,rbx
       call      qword ptr [7FFD5A7AB218]
       mov       rcx,rbx
       call      qword ptr [7FFD5A797FA8]; CORINFO_HELP_THROW
       int       3
M04_L11:
       call      qword ptr [7FFD5A7A25F8]
       mov       r14,rax
       call      qword ptr [7FFD5A7ACC60]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,r14
       call      qword ptr [7FFD5A7AB218]
       mov       rcx,r14
       call      qword ptr [7FFD5A797FA8]; CORINFO_HELP_THROW
       int       3
M04_L12:
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FFD5A7A96A0]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       je        near ptr M04_L05
       call      qword ptr [7FFD5A798028]; CORINFO_HELP_POLL_GC
       jmp       near ptr M04_L05
M04_L13:
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
M04_L14:
       movups    xmm0,[r10]
       movups    xmm1,[r10+4]
       movups    [rdx],xmm0
       movups    [rdx+4],xmm1
       jmp       near ptr M04_L05
M04_L15:
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FFD5A7AC980]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M04_L05
M04_L16:
       call      qword ptr [7FFD5A7A2620]
       mov       rbx,rax
       call      qword ptr [7FFD5A7AD730]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD5A7AB298]
       mov       rcx,rbx
       call      qword ptr [7FFD5A797FA8]; CORINFO_HELP_THROW
       int       3
; Total bytes of code 748
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsAddRemoveCollectionBenchmark.RemoveLast()
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
       mov       rax,[rbp+10]
       mov       rdx,[rax+278]
       mov       rcx,7FFCFCCF5D38
       call      qword ptr [7FFCFCC7FFA8]; System.Linq.Enumerable.Last[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       [rbp-18],rax
       mov       r8,[rbp-18]
       mov       rdx,[rbp-10]
       mov       rcx,7FFCFD151C88
       call      qword ptr [7FFCFD05CCD8]; DotNetTips.Spargine.Extensions.ListExtensions.RemoveLast[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.__Canon)
       mov       [rbp-4],eax
       mov       rcx,[rbp+10]
       mov       edx,[rbp-4]
       call      qword ptr [7FFCFD05CD08]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 122
```
```assembly
; System.Linq.Enumerable.Last[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rdx
       call      qword ptr [7FFD5C097E10]
       mov       rcx,rax
       lea       r8,[rsp+20]
       mov       rdx,rbx
       call      qword ptr [7FFD5C09A240]; Precode of System.Linq.Enumerable.TryGetLast[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
       cmp       byte ptr [rsp+20],0
       je        short M01_L00
       add       rsp,30
       pop       rbx
       ret
M01_L00:
       call      qword ptr [7FFD5C0995C8]
       int       3
; Total bytes of code 56
```
```assembly
; DotNetTips.Spargine.Extensions.ListExtensions.RemoveLast[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.__Canon)
       push      rbp
       sub       rsp,50
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-0C],eax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
; 			list = list.ArgumentNotNull();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rax,[rbp+10]
       mov       rax,[rax+18]
       mov       rax,[rax+10]
       mov       [rbp-20],rax
       cmp       qword ptr [rbp-20],0
       je        short M02_L00
       mov       rax,[rbp-20]
       mov       [rbp-18],rax
       jmp       short M02_L01
M02_L00:
       mov       rcx,[rbp+10]
       mov       rdx,7FFCFD160928
       call      qword ptr [7FFCFC7CF630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-18],rax
M02_L01:
       mov       rax,1DBFF1430C8
       mov       [rsp+20],rax
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       mov       r9,1DBFF130008
       call      qword ptr [7FFCFCE9E418]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp+18],rax
; 			var index = list.LastIndexOf(item);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,[rbp+18]
       mov       rdx,[rbp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFCFD05CD50]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].LastIndexOf(System.__Canon)
       mov       [rbp-0C],eax
; 			if (index >= 0)
; 			^^^^^^^^^^^^^^^
       cmp       dword ptr [rbp-0C],0
       jl        short M02_L02
; 				list.RemoveAt(index);
; 				^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,[rbp+18]
       mov       edx,[rbp-0C]
       cmp       [rcx],ecx
       call      qword ptr [7FFCFC8E1848]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
; 				return true;
; 				^^^^^^^^^^^^
       mov       eax,1
       add       rsp,50
       pop       rbp
       ret
; 			return false;
; 			^^^^^^^^^^^^^
M02_L02:
       xor       eax,eax
       add       rsp,50
       pop       rbp
       ret
; Total bytes of code 193
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
       call      qword ptr [7FFCFD05CE88]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       lea       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFCFD05CE58]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 60
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; BenchmarkDotNet.Autogenerated.Runnable_1002.__ForDisassemblyDiagnoser__()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
;             if (NotEleven == 11)
;             ^^^^^^^^^^^^^^^^^^^^
       mov       rax,[rbp+10]
       cmp       dword ptr [rax+2C0],0B
       jne       short M00_L00
;                 RemoveLast();
;                 ^^^^^^^^^^^^^
       mov       rcx,[rbp+10]
       call      qword ptr [7FFCFCBAD890]
M00_L00:
       nop
       add       rsp,20
       pop       rbp
       ret
; Total bytes of code 44
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsAddRemoveCollectionBenchmark.RemoveLast()
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
       mov       rax,[rbp+10]
       mov       rdx,[rax+278]
       mov       rcx,7FFCFCD15D38
       call      qword ptr [7FFCFCC9FF78]; System.Linq.Enumerable.Last[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       [rbp-18],rax
       mov       r8,[rbp-18]
       mov       rdx,[rbp-10]
       mov       rcx,7FFCFD189348
       call      qword ptr [7FFCFD10D278]; DotNetTips.Spargine.Extensions.ListExtensions.RemoveLast[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.__Canon)
       mov       [rbp-4],eax
       mov       rcx,[rbp+10]
       mov       edx,[rbp-4]
       call      qword ptr [7FFCFD10D2A8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 122
```
```assembly
; System.Linq.Enumerable.Last[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rdx
       mov       rdx,[rcx+18]
       mov       rax,[rdx+18]
       test      rax,rax
       je        short M01_L01
       mov       rcx,rax
M01_L00:
       lea       r8,[rsp+20]
       mov       rdx,rbx
       call      qword ptr [7FFCFD105188]; System.Linq.Enumerable.TryGetLast[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
       mov       rbx,rax
       cmp       byte ptr [rsp+20],0
       je        short M01_L02
       mov       rcx,7FFCFD434AB4
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,rbx
       add       rsp,30
       pop       rbx
       ret
M01_L01:
       mov       rdx,7FFCFD4423C8
       call      qword ptr [7FFCFCA67AF8]
       mov       rcx,rax
       jmp       short M01_L00
M01_L02:
       mov       rcx,7FFCFD434AB0
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FFCFD105278]
       int       3
; Total bytes of code 120
```
```assembly
; DotNetTips.Spargine.Extensions.ListExtensions.RemoveLast[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.__Canon)
; 			list = list.ArgumentNotNull();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var index = list.LastIndexOf(item);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			if (index >= 0)
; 			^^^^^^^^^^^^^^^
; 				list.RemoveAt(index);
; 				^^^^^^^^^^^^^^^^^^^^^
; 				return true;
; 				^^^^^^^^^^^^
; 			return false;
; 			^^^^^^^^^^^^^
       push      rbp
       sub       rsp,50
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-0C],eax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       rax,[rbp+10]
       mov       rax,[rax+18]
       mov       rax,[rax+10]
       mov       [rbp-20],rax
       cmp       qword ptr [rbp-20],0
       je        short M02_L00
       mov       rax,[rbp-20]
       mov       [rbp-18],rax
       jmp       short M02_L01
M02_L00:
       mov       rcx,[rbp+10]
       mov       rdx,7FFCFD191598
       call      qword ptr [7FFCFCA67AF8]
       mov       [rbp-18],rax
M02_L01:
       mov       rax,2D318DF30C8
       mov       [rsp+20],rax
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       mov       r9,2D318DE0008
       call      qword ptr [7FFCFCEBE9A0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp+18],rax
       mov       rcx,[rbp+18]
       mov       rdx,[rbp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFCFD10D2F0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].LastIndexOf(System.__Canon)
       mov       [rbp-0C],eax
       cmp       dword ptr [rbp-0C],0
       jl        short M02_L02
       mov       rcx,7FFCFD4356A8
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp+18]
       mov       edx,[rbp-0C]
       cmp       [rcx],ecx
       call      qword ptr [7FFCFC901848]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
       mov       eax,1
       add       rsp,50
       pop       rbp
       ret
M02_L02:
       mov       rcx,7FFCFD4356AC
       call      CORINFO_HELP_COUNTPROFILE32
       xor       eax,eax
       add       rsp,50
       pop       rbp
       ret
; Total bytes of code 223
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
       call      qword ptr [7FFCFD10D428]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       lea       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFCFD10D3F8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 60
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsAddRemoveCollectionBenchmark.RemoveLast()
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
       xor       eax,eax
       mov       [rbp-40],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       rdi,rsi
       test      rsi,rsi
       je        near ptr M00_L07
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L11
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L08
       mov       r14d,[rsi+10]
M00_L00:
       test      r14d,r14d
       jle       near ptr M00_L10
       mov       dword ptr [rbp-40],1
       mov       rdx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rdx
       jne       near ptr M00_L09
       dec       r14d
       cmp       r14d,[rsi+10]
       jae       near ptr M00_L28
       mov       rdx,[rsi+8]
       cmp       r14d,[rdx+8]
       jae       near ptr M00_L31
       mov       ecx,r14d
       mov       r14,[rdx+rcx*8+10]
M00_L01:
       cmp       byte ptr [rbp-40],0
       je        near ptr M00_L12
       mov       ecx,[rdi+10]
       test      ecx,ecx
       je        near ptr M00_L13
       lea       esi,[rcx-1]
       mov       edx,ecx
       test      esi,esi
       jl        near ptr M00_L14
       test      edx,edx
       jl        near ptr M00_L15
       cmp       esi,ecx
       jge       near ptr M00_L16
       lea       ecx,[rsi+1]
       cmp       edx,ecx
       jg        near ptr M00_L17
       mov       r15,[rdi+8]
       test      r15,r15
       je        near ptr M00_L18
       mov       r13d,[r15+8]
       test      r13d,r13d
       je        near ptr M00_L19
       cmp       r13d,esi
       jbe       near ptr M00_L20
       mov       r12d,esi
       sub       r12d,edx
       inc       r12d
       test      r14,r14
       je        near ptr M00_L21
       cmp       esi,r12d
       jl        near ptr M00_L24
       cmp       r13d,esi
       jle       near ptr M00_L26
M00_L02:
       mov       ecx,esi
       mov       rcx,[r15+rcx*8+10]
       test      rcx,rcx
       je        near ptr M00_L25
       mov       rdx,r14
       mov       r11,7FFCFC711DC0
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M00_L25
M00_L03:
       mov       r9d,esi
M00_L04:
       test      r9d,r9d
       jl        near ptr M00_L30
       mov       r8d,[rdi+10]
       cmp       r9d,r8d
       jae       near ptr M00_L28
       dec       r8d
       mov       [rdi+10],r8d
       cmp       r9d,r8d
       jl        near ptr M00_L29
M00_L05:
       mov       rax,[rdi+8]
       movsxd    rcx,dword ptr [rdi+10]
       mov       edx,[rax+8]
       cmp       rcx,rdx
       jae       near ptr M00_L31
       xor       edx,edx
       mov       [rax+rcx*8+10],rdx
       inc       dword ptr [rdi+14]
       mov       esi,1
M00_L06:
       mov       rax,[rbx+60]
       mov       [rax+4C],sil
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
M00_L07:
       mov       ecx,11
       call      qword ptr [7FFCFC7CF930]
       int       3
M00_L08:
       mov       rcx,rsi
       mov       r11,7FFCFC711DB0
       call      qword ptr [r11]
       mov       r14d,eax
       jmp       near ptr M00_L00
M00_L09:
       lea       edx,[r14-1]
       mov       rcx,rsi
       mov       r11,7FFCFC711DB8
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L01
M00_L10:
       xor       edx,edx
       mov       [rbp-40],edx
       xor       r14d,r14d
       jmp       near ptr M00_L01
M00_L11:
       lea       rdx,[rbp-40]
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax+28]
       mov       r14,rax
       jmp       near ptr M00_L01
M00_L12:
       call      qword ptr [7FFCFD0E51B8]
       int       3
M00_L13:
       mov       r9d,0FFFFFFFF
       jmp       near ptr M00_L04
M00_L14:
       call      qword ptr [7FFCFD0EFBD0]
       int       3
M00_L15:
       mov       ecx,1B
       mov       edx,0D
       call      qword ptr [7FFCFCE96058]
       int       3
M00_L16:
       mov       ecx,15
       mov       edx,12
       call      qword ptr [7FFCFCE96058]
       int       3
M00_L17:
       mov       ecx,1B
       mov       edx,12
       call      qword ptr [7FFCFCE96058]
       int       3
M00_L18:
       mov       ecx,2
       call      qword ptr [7FFCFC7CFD38]
       int       3
M00_L19:
       test      esi,esi
       jne       short M00_L20
       call      qword ptr [7FFCFD3071B0]
       int       3
M00_L20:
       call      qword ptr [7FFCFD307198]
       int       3
M00_L21:
       mov       r9d,esi
       cmp       r9d,r12d
       jl        short M00_L24
M00_L22:
       cmp       r9d,r13d
       jae       near ptr M00_L31
       mov       eax,r9d
       cmp       qword ptr [r15+rax*8+10],0
       je        short M00_L23
       dec       r9d
       cmp       r9d,r12d
       jge       short M00_L22
       jmp       short M00_L24
M00_L23:
       jmp       near ptr M00_L04
M00_L24:
       mov       r9d,0FFFFFFFF
       jmp       near ptr M00_L04
M00_L25:
       dec       esi
       cmp       esi,r12d
       jge       near ptr M00_L02
       jmp       short M00_L24
M00_L26:
       cmp       esi,r13d
       jae       short M00_L31
       mov       ecx,esi
       mov       rcx,[r15+rcx*8+10]
       test      rcx,rcx
       je        short M00_L27
       mov       rdx,r14
       mov       r11,7FFCFC711DC0
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L03
M00_L27:
       dec       esi
       cmp       esi,r12d
       jge       short M00_L26
       jmp       short M00_L24
M00_L28:
       call      qword ptr [7FFCFD0E4DC8]
       int       3
M00_L29:
       sub       r8d,r9d
       mov       [rsp+20],r8d
       mov       r8,[rdi+8]
       mov       rcx,[rdi+8]
       lea       edx,[r9+1]
       call      qword ptr [7FFCFCE1CFC0]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       near ptr M00_L05
M00_L30:
       xor       esi,esi
       jmp       near ptr M00_L06
M00_L31:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 818
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
; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       sub       rsp,38
       mov       eax,[rsp+60]
       test      rcx,rcx
       je        near ptr M02_L06
       test      r8,r8
       je        near ptr M02_L06
       mov       r10,[rcx]
       cmp       r10,[r8]
       jne       near ptr M02_L06
       cmp       dword ptr [r10+4],18
       jne       near ptr M02_L06
       mov       r11d,eax
       or        r11d,edx
       or        r11d,r9d
       jl        near ptr M02_L06
       lea       r11d,[rdx+rax]
       cmp       r11d,[rcx+8]
       ja        near ptr M02_L06
       lea       r11d,[r9+rax]
       cmp       r11d,[r8+8]
       ja        short M02_L06
       movzx     r11d,word ptr [r10]
       mov       eax,eax
       imul      rax,r11
       mov       edx,edx
       imul      rdx,r11
       lea       rdx,[rcx+rdx+10]
       mov       ecx,r9d
       imul      rcx,r11
       lea       rcx,[r8+rcx+10]
       test      dword ptr [r10],1000000
       je        short M02_L05
       cmp       rax,4000
       ja        short M02_L04
       mov       r8,rax
       call      00007FFD5C3C5D60
       cmp       dword ptr [7FFD5C72F778],0
       jne       short M02_L02
M02_L00:
       cmp       dword ptr [7FFD5C72F778],0
       jne       short M02_L03
M02_L01:
       add       rsp,38
       ret
M02_L02:
       call      CORINFO_HELP_POLL_GC
       jmp       short M02_L00
M02_L03:
       call      CORINFO_HELP_POLL_GC
       jmp       short M02_L01
M02_L04:
       mov       r8,rax
       add       rsp,38
       jmp       qword ptr [7FFCFCE9E370]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
M02_L05:
       mov       r8,rax
       call      qword ptr [7FFCFC7C5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M02_L00
M02_L06:
       mov       [rsp+20],eax
       xor       eax,eax
       mov       [rsp+28],eax
       call      qword ptr [7FFCFD1A4B10]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       short M02_L00
; Total bytes of code 225
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsAddRemoveCollectionBenchmark.RemoveLast()
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
       xor       eax,eax
       mov       [rbp-40],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       rdi,rsi
       test      rsi,rsi
       je        near ptr M00_L07
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L11
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L08
       mov       r14d,[rsi+10]
M00_L00:
       test      r14d,r14d
       jle       near ptr M00_L10
       mov       dword ptr [rbp-40],1
       mov       rdx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rdx
       jne       near ptr M00_L09
       dec       r14d
       cmp       r14d,[rsi+10]
       jae       near ptr M00_L28
       mov       rdx,[rsi+8]
       cmp       r14d,[rdx+8]
       jae       near ptr M00_L31
       mov       ecx,r14d
       mov       r14,[rdx+rcx*8+10]
M00_L01:
       cmp       byte ptr [rbp-40],0
       je        near ptr M00_L12
       mov       ecx,[rdi+10]
       test      ecx,ecx
       je        near ptr M00_L13
       lea       esi,[rcx-1]
       mov       edx,ecx
       test      esi,esi
       jl        near ptr M00_L14
       test      edx,edx
       jl        near ptr M00_L15
       cmp       esi,ecx
       jge       near ptr M00_L16
       lea       ecx,[rsi+1]
       cmp       edx,ecx
       jg        near ptr M00_L17
       mov       r15,[rdi+8]
       test      r15,r15
       je        near ptr M00_L18
       mov       r13d,[r15+8]
       test      r13d,r13d
       je        near ptr M00_L19
       cmp       r13d,esi
       jbe       near ptr M00_L20
       mov       r12d,esi
       sub       r12d,edx
       inc       r12d
       test      r14,r14
       je        near ptr M00_L21
       cmp       esi,r12d
       jl        near ptr M00_L24
       cmp       r13d,esi
       jle       near ptr M00_L26
M00_L02:
       mov       ecx,esi
       mov       rcx,[r15+rcx*8+10]
       test      rcx,rcx
       je        near ptr M00_L25
       mov       rdx,r14
       mov       r11,7FFCFC731D20
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M00_L25
M00_L03:
       mov       r9d,esi
M00_L04:
       test      r9d,r9d
       jl        near ptr M00_L30
       mov       r8d,[rdi+10]
       cmp       r9d,r8d
       jae       near ptr M00_L28
       dec       r8d
       mov       [rdi+10],r8d
       cmp       r9d,r8d
       jl        near ptr M00_L29
M00_L05:
       mov       rax,[rdi+8]
       movsxd    rcx,dword ptr [rdi+10]
       mov       edx,[rax+8]
       cmp       rcx,rdx
       jae       near ptr M00_L31
       xor       edx,edx
       mov       [rax+rcx*8+10],rdx
       inc       dword ptr [rdi+14]
       mov       esi,1
M00_L06:
       mov       rax,[rbx+60]
       mov       [rax+4C],sil
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
M00_L07:
       mov       ecx,11
       call      qword ptr [7FFCFC7EF930]
       int       3
M00_L08:
       mov       rcx,rsi
       mov       r11,7FFCFC731D10
       call      qword ptr [r11]
       mov       r14d,eax
       jmp       near ptr M00_L00
M00_L09:
       lea       edx,[r14-1]
       mov       rcx,rsi
       mov       r11,7FFCFC731D18
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L01
M00_L10:
       xor       edx,edx
       mov       [rbp-40],edx
       xor       r14d,r14d
       jmp       near ptr M00_L01
M00_L11:
       lea       rdx,[rbp-40]
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax+28]
       mov       r14,rax
       jmp       near ptr M00_L01
M00_L12:
       call      qword ptr [7FFCFD0F4CA8]
       int       3
M00_L13:
       mov       r9d,0FFFFFFFF
       jmp       near ptr M00_L04
M00_L14:
       call      qword ptr [7FFCFD0FF5E8]
       int       3
M00_L15:
       mov       ecx,1B
       mov       edx,0D
       call      qword ptr [7FFCFCEB6058]
       int       3
M00_L16:
       mov       ecx,15
       mov       edx,12
       call      qword ptr [7FFCFCEB6058]
       int       3
M00_L17:
       mov       ecx,1B
       mov       edx,12
       call      qword ptr [7FFCFCEB6058]
       int       3
M00_L18:
       mov       ecx,2
       call      qword ptr [7FFCFC7EFD38]
       int       3
M00_L19:
       test      esi,esi
       jne       short M00_L20
       call      qword ptr [7FFCFD3275B8]
       int       3
M00_L20:
       call      qword ptr [7FFCFD3275A0]
       int       3
M00_L21:
       mov       r9d,esi
       cmp       r9d,r12d
       jl        short M00_L24
M00_L22:
       cmp       r9d,r13d
       jae       near ptr M00_L31
       mov       eax,r9d
       cmp       qword ptr [r15+rax*8+10],0
       je        short M00_L23
       dec       r9d
       cmp       r9d,r12d
       jge       short M00_L22
       jmp       short M00_L24
M00_L23:
       jmp       near ptr M00_L04
M00_L24:
       mov       r9d,0FFFFFFFF
       jmp       near ptr M00_L04
M00_L25:
       dec       esi
       cmp       esi,r12d
       jge       near ptr M00_L02
       jmp       short M00_L24
M00_L26:
       cmp       esi,r13d
       jae       short M00_L31
       mov       ecx,esi
       mov       rcx,[r15+rcx*8+10]
       test      rcx,rcx
       je        short M00_L27
       mov       rdx,r14
       mov       r11,7FFCFC731D20
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L03
M00_L27:
       dec       esi
       cmp       esi,r12d
       jge       short M00_L26
       jmp       short M00_L24
M00_L28:
       call      qword ptr [7FFCFD0F48B8]
       int       3
M00_L29:
       sub       r8d,r9d
       mov       [rsp+20],r8d
       mov       r8,[rdi+8]
       mov       rcx,[rdi+8]
       lea       edx,[r9+1]
       call      qword ptr [7FFCFCE3CFC0]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       near ptr M00_L05
M00_L30:
       xor       esi,esi
       jmp       near ptr M00_L06
M00_L31:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 818
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
; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       sub       rsp,38
       mov       eax,[rsp+60]
       test      rcx,rcx
       je        near ptr M02_L06
       test      r8,r8
       je        near ptr M02_L06
       mov       r10,[rcx]
       cmp       r10,[r8]
       jne       near ptr M02_L06
       cmp       dword ptr [r10+4],18
       jne       near ptr M02_L06
       mov       r11d,eax
       or        r11d,edx
       or        r11d,r9d
       jl        near ptr M02_L06
       lea       r11d,[rdx+rax]
       cmp       r11d,[rcx+8]
       ja        near ptr M02_L06
       lea       r11d,[r9+rax]
       cmp       r11d,[r8+8]
       ja        short M02_L06
       movzx     r11d,word ptr [r10]
       mov       eax,eax
       imul      rax,r11
       mov       edx,edx
       imul      rdx,r11
       lea       rdx,[rcx+rdx+10]
       mov       ecx,r9d
       imul      rcx,r11
       lea       rcx,[r8+rcx+10]
       test      dword ptr [r10],1000000
       je        short M02_L05
       cmp       rax,4000
       ja        short M02_L04
       mov       r8,rax
       call      00007FFD5C3C5D60
       cmp       dword ptr [7FFD5C72F778],0
       jne       short M02_L02
M02_L00:
       cmp       dword ptr [7FFD5C72F778],0
       jne       short M02_L03
M02_L01:
       add       rsp,38
       ret
M02_L02:
       call      CORINFO_HELP_POLL_GC
       jmp       short M02_L00
M02_L03:
       call      CORINFO_HELP_POLL_GC
       jmp       short M02_L01
M02_L04:
       mov       r8,rax
       add       rsp,38
       jmp       qword ptr [7FFCFCEBE388]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
M02_L05:
       mov       r8,rax
       call      qword ptr [7FFCFC7E5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M02_L00
M02_L06:
       mov       [rsp+20],eax
       xor       eax,eax
       mov       [rsp+28],eax
       call      qword ptr [7FFCFD1B4C18]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       short M02_L00
; Total bytes of code 225
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsAddRemoveCollectionBenchmark.RemoveLast()
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
       xor       eax,eax
       mov       [rbp-40],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       rdi,rsi
       test      rsi,rsi
       je        near ptr M00_L07
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L11
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L08
       mov       r14d,[rsi+10]
M00_L00:
       test      r14d,r14d
       jle       near ptr M00_L10
       mov       dword ptr [rbp-40],1
       mov       rdx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rdx
       jne       near ptr M00_L09
       dec       r14d
       cmp       r14d,[rsi+10]
       jae       near ptr M00_L28
       mov       rdx,[rsi+8]
       cmp       r14d,[rdx+8]
       jae       near ptr M00_L31
       mov       ecx,r14d
       mov       r14,[rdx+rcx*8+10]
M00_L01:
       cmp       byte ptr [rbp-40],0
       je        near ptr M00_L12
       mov       ecx,[rdi+10]
       test      ecx,ecx
       je        near ptr M00_L13
       lea       esi,[rcx-1]
       mov       edx,ecx
       test      esi,esi
       jl        near ptr M00_L14
       test      edx,edx
       jl        near ptr M00_L15
       cmp       esi,ecx
       jge       near ptr M00_L16
       lea       ecx,[rsi+1]
       cmp       edx,ecx
       jg        near ptr M00_L17
       mov       r15,[rdi+8]
       test      r15,r15
       je        near ptr M00_L18
       mov       r13d,[r15+8]
       test      r13d,r13d
       je        near ptr M00_L19
       cmp       r13d,esi
       jbe       near ptr M00_L20
       mov       r12d,esi
       sub       r12d,edx
       inc       r12d
       test      r14,r14
       je        near ptr M00_L21
       cmp       esi,r12d
       jl        near ptr M00_L24
       cmp       r13d,esi
       jle       near ptr M00_L26
M00_L02:
       mov       ecx,esi
       mov       rcx,[r15+rcx*8+10]
       test      rcx,rcx
       je        near ptr M00_L25
       mov       rdx,r14
       mov       r11,7FFCFC741DA8
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M00_L25
M00_L03:
       mov       r9d,esi
M00_L04:
       test      r9d,r9d
       jl        near ptr M00_L30
       mov       r8d,[rdi+10]
       cmp       r9d,r8d
       jae       near ptr M00_L28
       dec       r8d
       mov       [rdi+10],r8d
       cmp       r9d,r8d
       jl        near ptr M00_L29
M00_L05:
       mov       rax,[rdi+8]
       movsxd    rcx,dword ptr [rdi+10]
       mov       edx,[rax+8]
       cmp       rcx,rdx
       jae       near ptr M00_L31
       xor       edx,edx
       mov       [rax+rcx*8+10],rdx
       inc       dword ptr [rdi+14]
       mov       esi,1
M00_L06:
       mov       rax,[rbx+60]
       mov       [rax+4C],sil
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
M00_L07:
       mov       ecx,11
       call      qword ptr [7FFCFC7FF930]
       int       3
M00_L08:
       mov       rcx,rsi
       mov       r11,7FFCFC741D98
       call      qword ptr [r11]
       mov       r14d,eax
       jmp       near ptr M00_L00
M00_L09:
       lea       edx,[r14-1]
       mov       rcx,rsi
       mov       r11,7FFCFC741DA0
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L01
M00_L10:
       xor       edx,edx
       mov       [rbp-40],edx
       xor       r14d,r14d
       jmp       near ptr M00_L01
M00_L11:
       lea       rdx,[rbp-40]
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax+28]
       mov       r14,rax
       jmp       near ptr M00_L01
M00_L12:
       call      qword ptr [7FFCFD104DE0]
       int       3
M00_L13:
       mov       r9d,0FFFFFFFF
       jmp       near ptr M00_L04
M00_L14:
       call      qword ptr [7FFCFD10F4C8]
       int       3
M00_L15:
       mov       ecx,1B
       mov       edx,0D
       call      qword ptr [7FFCFCEC6058]
       int       3
M00_L16:
       mov       ecx,15
       mov       edx,12
       call      qword ptr [7FFCFCEC6058]
       int       3
M00_L17:
       mov       ecx,1B
       mov       edx,12
       call      qword ptr [7FFCFCEC6058]
       int       3
M00_L18:
       mov       ecx,2
       call      qword ptr [7FFCFC7FFD38]
       int       3
M00_L19:
       test      esi,esi
       jne       short M00_L20
       call      qword ptr [7FFCFD3375D0]
       int       3
M00_L20:
       call      qword ptr [7FFCFD3375B8]
       int       3
M00_L21:
       mov       r9d,esi
       cmp       r9d,r12d
       jl        short M00_L24
M00_L22:
       cmp       r9d,r13d
       jae       near ptr M00_L31
       mov       eax,r9d
       cmp       qword ptr [r15+rax*8+10],0
       je        short M00_L23
       dec       r9d
       cmp       r9d,r12d
       jge       short M00_L22
       jmp       short M00_L24
M00_L23:
       jmp       near ptr M00_L04
M00_L24:
       mov       r9d,0FFFFFFFF
       jmp       near ptr M00_L04
M00_L25:
       dec       esi
       cmp       esi,r12d
       jge       near ptr M00_L02
       jmp       short M00_L24
M00_L26:
       cmp       esi,r13d
       jae       short M00_L31
       mov       ecx,esi
       mov       rcx,[r15+rcx*8+10]
       test      rcx,rcx
       je        short M00_L27
       mov       rdx,r14
       mov       r11,7FFCFC741DA8
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L03
M00_L27:
       dec       esi
       cmp       esi,r12d
       jge       short M00_L26
       jmp       short M00_L24
M00_L28:
       call      qword ptr [7FFCFD1049F0]
       int       3
M00_L29:
       sub       r8d,r9d
       mov       [rsp+20],r8d
       mov       r8,[rdi+8]
       mov       rcx,[rdi+8]
       lea       edx,[r9+1]
       call      qword ptr [7FFCFCE4CFC0]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       near ptr M00_L05
M00_L30:
       xor       esi,esi
       jmp       near ptr M00_L06
M00_L31:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 818
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
; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       sub       rsp,38
       mov       eax,[rsp+60]
       test      rcx,rcx
       je        near ptr M02_L06
       test      r8,r8
       je        near ptr M02_L06
       mov       r10,[rcx]
       cmp       r10,[r8]
       jne       near ptr M02_L06
       cmp       dword ptr [r10+4],18
       jne       near ptr M02_L06
       mov       r11d,eax
       or        r11d,edx
       or        r11d,r9d
       jl        near ptr M02_L06
       lea       r11d,[rdx+rax]
       cmp       r11d,[rcx+8]
       ja        near ptr M02_L06
       lea       r11d,[r9+rax]
       cmp       r11d,[r8+8]
       ja        short M02_L06
       movzx     r11d,word ptr [r10]
       mov       eax,eax
       imul      rax,r11
       mov       edx,edx
       imul      rdx,r11
       lea       rdx,[rcx+rdx+10]
       mov       ecx,r9d
       imul      rcx,r11
       lea       rcx,[r8+rcx+10]
       test      dword ptr [r10],1000000
       je        short M02_L02
       cmp       rax,4000
       ja        short M02_L05
       mov       r8,rax
       call      00007FFD5C3C5D60
       cmp       dword ptr [7FFD5C72F778],0
       jne       short M02_L03
M02_L00:
       cmp       dword ptr [7FFD5C72F778],0
       jne       short M02_L04
M02_L01:
       add       rsp,38
       ret
M02_L02:
       mov       r8,rax
       call      qword ptr [7FFCFC7F5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M02_L00
M02_L03:
       call      CORINFO_HELP_POLL_GC
       jmp       short M02_L00
M02_L04:
       call      CORINFO_HELP_POLL_GC
       jmp       short M02_L01
M02_L05:
       mov       r8,rax
       add       rsp,38
       jmp       qword ptr [7FFCFCECE340]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
M02_L06:
       mov       [rsp+20],eax
       xor       eax,eax
       mov       [rsp+28],eax
       call      qword ptr [7FFCFD1D4DE0]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       short M02_L00
; Total bytes of code 225
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsAddRemoveCollectionBenchmark.RemoveLast()
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
       xor       eax,eax
       mov       [rbp-40],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       rdi,rsi
       test      rsi,rsi
       je        near ptr M00_L07
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L11
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L08
       mov       r14d,[rsi+10]
M00_L00:
       test      r14d,r14d
       jle       near ptr M00_L10
       mov       dword ptr [rbp-40],1
       mov       rdx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rdx
       jne       near ptr M00_L09
       dec       r14d
       cmp       r14d,[rsi+10]
       jae       near ptr M00_L28
       mov       rdx,[rsi+8]
       cmp       r14d,[rdx+8]
       jae       near ptr M00_L31
       mov       ecx,r14d
       mov       r14,[rdx+rcx*8+10]
M00_L01:
       cmp       byte ptr [rbp-40],0
       je        near ptr M00_L12
       mov       ecx,[rdi+10]
       test      ecx,ecx
       je        near ptr M00_L13
       lea       esi,[rcx-1]
       mov       edx,ecx
       test      esi,esi
       jl        near ptr M00_L14
       test      edx,edx
       jl        near ptr M00_L15
       cmp       esi,ecx
       jge       near ptr M00_L16
       lea       ecx,[rsi+1]
       cmp       edx,ecx
       jg        near ptr M00_L17
       mov       r15,[rdi+8]
       test      r15,r15
       je        near ptr M00_L18
       mov       r13d,[r15+8]
       test      r13d,r13d
       je        near ptr M00_L19
       cmp       r13d,esi
       jbe       near ptr M00_L20
       mov       r12d,esi
       sub       r12d,edx
       inc       r12d
       test      r14,r14
       je        near ptr M00_L21
       cmp       esi,r12d
       jl        near ptr M00_L24
       cmp       r13d,esi
       jle       near ptr M00_L26
M00_L02:
       mov       ecx,esi
       mov       rcx,[r15+rcx*8+10]
       test      rcx,rcx
       je        near ptr M00_L25
       mov       rdx,r14
       mov       r11,7FFCFC711F58
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M00_L25
M00_L03:
       mov       r9d,esi
M00_L04:
       test      r9d,r9d
       jl        near ptr M00_L30
       mov       r8d,[rdi+10]
       cmp       r9d,r8d
       jae       near ptr M00_L28
       dec       r8d
       mov       [rdi+10],r8d
       cmp       r9d,r8d
       jl        near ptr M00_L29
M00_L05:
       mov       rax,[rdi+8]
       movsxd    rcx,dword ptr [rdi+10]
       mov       edx,[rax+8]
       cmp       rcx,rdx
       jae       near ptr M00_L31
       xor       edx,edx
       mov       [rax+rcx*8+10],rdx
       inc       dword ptr [rdi+14]
       mov       esi,1
M00_L06:
       mov       rax,[rbx+60]
       mov       [rax+4C],sil
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
M00_L07:
       mov       ecx,11
       call      qword ptr [7FFCFC7CF930]
       int       3
M00_L08:
       mov       rcx,rsi
       mov       r11,7FFCFC711F48
       call      qword ptr [r11]
       mov       r14d,eax
       jmp       near ptr M00_L00
M00_L09:
       lea       edx,[r14-1]
       mov       rcx,rsi
       mov       r11,7FFCFC711F50
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L01
M00_L10:
       xor       edx,edx
       mov       [rbp-40],edx
       xor       r14d,r14d
       jmp       near ptr M00_L01
M00_L11:
       lea       rdx,[rbp-40]
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax+28]
       mov       r14,rax
       jmp       near ptr M00_L01
M00_L12:
       call      qword ptr [7FFCFD0E63D0]
       int       3
M00_L13:
       mov       r9d,0FFFFFFFF
       jmp       near ptr M00_L04
M00_L14:
       call      qword ptr [7FFCFD1C6A48]
       int       3
M00_L15:
       mov       ecx,1B
       mov       edx,0D
       call      qword ptr [7FFCFCE96028]
       int       3
M00_L16:
       mov       ecx,15
       mov       edx,12
       call      qword ptr [7FFCFCE96028]
       int       3
M00_L17:
       mov       ecx,1B
       mov       edx,12
       call      qword ptr [7FFCFCE96028]
       int       3
M00_L18:
       mov       ecx,2
       call      qword ptr [7FFCFC7CFD38]
       int       3
M00_L19:
       test      esi,esi
       jne       short M00_L20
       call      qword ptr [7FFCFD37C720]
       int       3
M00_L20:
       call      qword ptr [7FFCFD37C708]
       int       3
M00_L21:
       mov       r9d,esi
       cmp       r9d,r12d
       jl        short M00_L24
M00_L22:
       cmp       r9d,r13d
       jae       near ptr M00_L31
       mov       eax,r9d
       cmp       qword ptr [r15+rax*8+10],0
       je        short M00_L23
       dec       r9d
       cmp       r9d,r12d
       jge       short M00_L22
       jmp       short M00_L24
M00_L23:
       jmp       near ptr M00_L04
M00_L24:
       mov       r9d,0FFFFFFFF
       jmp       near ptr M00_L04
M00_L25:
       dec       esi
       cmp       esi,r12d
       jge       near ptr M00_L02
       jmp       short M00_L24
M00_L26:
       cmp       esi,r13d
       jae       short M00_L31
       mov       ecx,esi
       mov       rcx,[r15+rcx*8+10]
       test      rcx,rcx
       je        short M00_L27
       mov       rdx,r14
       mov       r11,7FFCFC711F58
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L03
M00_L27:
       dec       esi
       cmp       esi,r12d
       jge       short M00_L26
       jmp       short M00_L24
M00_L28:
       call      qword ptr [7FFCFD0E5FE0]
       int       3
M00_L29:
       sub       r8d,r9d
       mov       [rsp+20],r8d
       mov       r8,[rdi+8]
       mov       rcx,[rdi+8]
       lea       edx,[r9+1]
       call      qword ptr [7FFCFCE1CF90]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       near ptr M00_L05
M00_L30:
       xor       esi,esi
       jmp       near ptr M00_L06
M00_L31:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 818
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rdx,rdx
       je        short M01_L02
       cmp       [rdx],rcx
       je        short M01_L02
       mov       rax,[rdx]
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
; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       sub       rsp,38
       mov       eax,[rsp+60]
       test      rcx,rcx
       je        near ptr M02_L06
       test      r8,r8
       je        near ptr M02_L06
       mov       r10,[rcx]
       cmp       r10,[r8]
       jne       near ptr M02_L06
       cmp       dword ptr [r10+4],18
       jne       near ptr M02_L06
       mov       r11d,eax
       or        r11d,edx
       or        r11d,r9d
       jl        near ptr M02_L06
       lea       r11d,[rdx+rax]
       cmp       r11d,[rcx+8]
       ja        near ptr M02_L06
       lea       r11d,[r9+rax]
       cmp       r11d,[r8+8]
       ja        short M02_L06
       movzx     r11d,word ptr [r10]
       mov       eax,eax
       imul      rax,r11
       mov       edx,edx
       imul      rdx,r11
       lea       rdx,[rcx+rdx+10]
       mov       ecx,r9d
       imul      rcx,r11
       lea       rcx,[r8+rcx+10]
       test      dword ptr [r10],1000000
       je        short M02_L02
       cmp       rax,4000
       ja        short M02_L05
       mov       r8,rax
       call      00007FFD5C3C5D60
       cmp       dword ptr [7FFD5C72F778],0
       jne       short M02_L03
M02_L00:
       cmp       dword ptr [7FFD5C72F778],0
       jne       short M02_L04
M02_L01:
       add       rsp,38
       ret
M02_L02:
       mov       r8,rax
       call      qword ptr [7FFCFC7C5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M02_L00
M02_L03:
       call      CORINFO_HELP_POLL_GC
       jmp       short M02_L00
M02_L04:
       call      CORINFO_HELP_POLL_GC
       jmp       short M02_L01
M02_L05:
       mov       r8,rax
       add       rsp,38
       jmp       qword ptr [7FFCFCE9E310]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
M02_L06:
       mov       [rsp+20],eax
       xor       eax,eax
       mov       [rsp+28],eax
       call      qword ptr [7FFCFD0E7A20]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       short M02_L00
; Total bytes of code 225
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ListExtensionsAddRemoveCollectionBenchmark.RemoveLast()
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
       xor       eax,eax
       mov       [rbp-40],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       rdi,rsi
       test      rsi,rsi
       je        near ptr M00_L07
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L11
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L08
       mov       r14d,[rsi+10]
M00_L00:
       test      r14d,r14d
       jle       near ptr M00_L10
       mov       dword ptr [rbp-40],1
       mov       rdx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rdx
       jne       near ptr M00_L09
       dec       r14d
       cmp       r14d,[rsi+10]
       jae       near ptr M00_L28
       mov       rdx,[rsi+8]
       cmp       r14d,[rdx+8]
       jae       near ptr M00_L31
       mov       ecx,r14d
       mov       r14,[rdx+rcx*8+10]
M00_L01:
       cmp       byte ptr [rbp-40],0
       je        near ptr M00_L12
       mov       ecx,[rdi+10]
       test      ecx,ecx
       je        near ptr M00_L13
       lea       esi,[rcx-1]
       mov       edx,ecx
       test      esi,esi
       jl        near ptr M00_L14
       test      edx,edx
       jl        near ptr M00_L15
       cmp       esi,ecx
       jge       near ptr M00_L16
       lea       ecx,[rsi+1]
       cmp       edx,ecx
       jg        near ptr M00_L17
       mov       r15,[rdi+8]
       test      r15,r15
       je        near ptr M00_L18
       mov       r13d,[r15+8]
       test      r13d,r13d
       je        near ptr M00_L19
       cmp       r13d,esi
       jbe       near ptr M00_L20
       mov       r12d,esi
       sub       r12d,edx
       inc       r12d
       test      r14,r14
       je        near ptr M00_L21
       cmp       esi,r12d
       jl        near ptr M00_L24
       cmp       r13d,esi
       jle       near ptr M00_L26
M00_L02:
       mov       ecx,esi
       mov       rcx,[r15+rcx*8+10]
       test      rcx,rcx
       je        near ptr M00_L25
       mov       rdx,r14
       mov       r11,7FFCFC741FC8
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M00_L25
M00_L03:
       mov       r9d,esi
M00_L04:
       test      r9d,r9d
       jl        near ptr M00_L30
       mov       r8d,[rdi+10]
       cmp       r9d,r8d
       jae       near ptr M00_L28
       dec       r8d
       mov       [rdi+10],r8d
       cmp       r9d,r8d
       jl        near ptr M00_L29
M00_L05:
       mov       rax,[rdi+8]
       movsxd    rcx,dword ptr [rdi+10]
       mov       edx,[rax+8]
       cmp       rcx,rdx
       jae       near ptr M00_L31
       xor       edx,edx
       mov       [rax+rcx*8+10],rdx
       inc       dword ptr [rdi+14]
       mov       esi,1
M00_L06:
       mov       rax,[rbx+60]
       mov       [rax+4C],sil
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
M00_L07:
       mov       ecx,11
       call      qword ptr [7FFCFC7FF930]
       int       3
M00_L08:
       mov       rcx,rsi
       mov       r11,7FFCFC741FB8
       call      qword ptr [r11]
       mov       r14d,eax
       jmp       near ptr M00_L00
M00_L09:
       lea       edx,[r14-1]
       mov       rcx,rsi
       mov       r11,7FFCFC741FC0
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L01
M00_L10:
       xor       edx,edx
       mov       [rbp-40],edx
       xor       r14d,r14d
       jmp       near ptr M00_L01
M00_L11:
       lea       rdx,[rbp-40]
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax+28]
       mov       r14,rax
       jmp       near ptr M00_L01
M00_L12:
       call      qword ptr [7FFCFD14DED8]
       int       3
M00_L13:
       mov       r9d,0FFFFFFFF
       jmp       near ptr M00_L04
M00_L14:
       call      qword ptr [7FFCFD3E46F0]
       int       3
M00_L15:
       mov       ecx,1B
       mov       edx,0D
       call      qword ptr [7FFCFCEC6028]
       int       3
M00_L16:
       mov       ecx,15
       mov       edx,12
       call      qword ptr [7FFCFCEC6028]
       int       3
M00_L17:
       mov       ecx,1B
       mov       edx,12
       call      qword ptr [7FFCFCEC6028]
       int       3
M00_L18:
       mov       ecx,2
       call      qword ptr [7FFCFC7FFD38]
       int       3
M00_L19:
       test      esi,esi
       jne       short M00_L20
       call      qword ptr [7FFCFD3ECA68]
       int       3
M00_L20:
       call      qword ptr [7FFCFD3ECA50]
       int       3
M00_L21:
       mov       r9d,esi
       cmp       r9d,r12d
       jl        short M00_L24
M00_L22:
       cmp       r9d,r13d
       jae       near ptr M00_L31
       mov       eax,r9d
       cmp       qword ptr [r15+rax*8+10],0
       je        short M00_L23
       dec       r9d
       cmp       r9d,r12d
       jge       short M00_L22
       jmp       short M00_L24
M00_L23:
       jmp       near ptr M00_L04
M00_L24:
       mov       r9d,0FFFFFFFF
       jmp       near ptr M00_L04
M00_L25:
       dec       esi
       cmp       esi,r12d
       jge       near ptr M00_L02
       jmp       short M00_L24
M00_L26:
       cmp       esi,r13d
       jae       short M00_L31
       mov       ecx,esi
       mov       rcx,[r15+rcx*8+10]
       test      rcx,rcx
       je        short M00_L27
       mov       rdx,r14
       mov       r11,7FFCFC741FC8
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L03
M00_L27:
       dec       esi
       cmp       esi,r12d
       jge       short M00_L26
       jmp       short M00_L24
M00_L28:
       call      qword ptr [7FFCFD0174F8]
       int       3
M00_L29:
       sub       r8d,r9d
       mov       [rsp+20],r8d
       mov       r8,[rdi+8]
       mov       rcx,[rdi+8]
       lea       edx,[r9+1]
       call      qword ptr [7FFCFCE4CF90]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       near ptr M00_L05
M00_L30:
       xor       esi,esi
       jmp       near ptr M00_L06
M00_L31:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 818
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
; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       sub       rsp,38
       mov       eax,[rsp+60]
       test      rcx,rcx
       je        near ptr M02_L06
       test      r8,r8
       je        near ptr M02_L06
       mov       r10,[rcx]
       cmp       r10,[r8]
       jne       near ptr M02_L06
       cmp       dword ptr [r10+4],18
       jne       near ptr M02_L06
       mov       r11d,eax
       or        r11d,edx
       or        r11d,r9d
       jl        near ptr M02_L06
       lea       r11d,[rdx+rax]
       cmp       r11d,[rcx+8]
       ja        near ptr M02_L06
       lea       r11d,[r9+rax]
       cmp       r11d,[r8+8]
       ja        short M02_L06
       movzx     r11d,word ptr [r10]
       mov       eax,eax
       imul      rax,r11
       mov       edx,edx
       imul      rdx,r11
       lea       rdx,[rcx+rdx+10]
       mov       ecx,r9d
       imul      rcx,r11
       lea       rcx,[r8+rcx+10]
       test      dword ptr [r10],1000000
       je        short M02_L02
       cmp       rax,4000
       ja        short M02_L05
       mov       r8,rax
       call      00007FFD5C3C5D60
       cmp       dword ptr [7FFD5C72F778],0
       jne       short M02_L03
M02_L00:
       cmp       dword ptr [7FFD5C72F778],0
       jne       short M02_L04
M02_L01:
       add       rsp,38
       ret
M02_L02:
       mov       r8,rax
       call      qword ptr [7FFCFC7F5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M02_L00
M02_L03:
       call      CORINFO_HELP_POLL_GC
       jmp       short M02_L00
M02_L04:
       call      CORINFO_HELP_POLL_GC
       jmp       short M02_L01
M02_L05:
       mov       r8,rax
       add       rsp,38
       jmp       qword ptr [7FFCFD0158A8]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
M02_L06:
       mov       [rsp+20],eax
       xor       eax,eax
       mov       [rsp+28],eax
       call      qword ptr [7FFCFD016610]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       short M02_L00
; Total bytes of code 225
```

