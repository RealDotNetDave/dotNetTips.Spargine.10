## .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.IsNotEmptyWithCount()
       mov       rax,[rcx+278]
       mov       eax,[rax+8]
       cmp       eax,[rcx+270]
       sete      al
       movzx     eax,al
       mov       rcx,[rcx+60]
       mov       [rcx+4C],al
       ret
; Total bytes of code 30
```

## .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.IsNotEmptyWithCount()
       mov       rax,[rcx+278]
       mov       eax,[rax+8]
       cmp       eax,[rcx+270]
       sete      al
       movzx     eax,al
       mov       rcx,[rcx+60]
       mov       [rcx+4C],al
       ret
; Total bytes of code 30
```

## .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.IsNotEmptyWithCount()
       mov       rax,[rcx+278]
       mov       eax,[rax+8]
       cmp       eax,[rcx+270]
       sete      al
       movzx     eax,al
       mov       rcx,[rcx+60]
       mov       [rcx+4C],al
       ret
; Total bytes of code 30
```

## .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.IsNotEmptyWithCount()
       mov       rax,[rcx+278]
       mov       eax,[rax+8]
       cmp       eax,[rcx+270]
       sete      al
       movzx     eax,al
       mov       rcx,[rcx+60]
       mov       [rcx+4C],al
       ret
; Total bytes of code 30
```

## .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.IsNotEmptyWithCount()
       mov       rax,[rcx+278]
       mov       eax,[rax+8]
       cmp       eax,[rcx+270]
       sete      al
       movzx     eax,al
       mov       rcx,[rcx+60]
       mov       [rcx+4C],al
       ret
; Total bytes of code 30
```

## .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.IsNotEmptyWithCount()
       mov       rax,[rcx+278]
       mov       eax,[rax+8]
       cmp       eax,[rcx+270]
       sete      al
       movzx     eax,al
       mov       rcx,[rcx+60]
       mov       [rcx+4C],al
       ret
; Total bytes of code 30
```

## .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.IsNotEmptyWithCount()
       mov       rax,[rcx+278]
       mov       eax,[rax+8]
       cmp       eax,[rcx+270]
       sete      al
       movzx     eax,al
       mov       rcx,[rcx+60]
       mov       [rcx+4C],al
       ret
; Total bytes of code 30
```

## .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.IsNotEmptyWithCount()
       mov       rax,[rcx+278]
       mov       eax,[rax+8]
       cmp       eax,[rcx+270]
       sete      al
       movzx     eax,al
       mov       rcx,[rcx+60]
       mov       [rcx+4C],al
       ret
; Total bytes of code 30
```

## .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.Shuffle()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Linq.Enumerable+ShuffleIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rsi+10],eax
       lea       rcx,[rsi+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rsi+18]
       mov       rcx,7FFD5799EA40
       call      qword ptr [7FFD578EC6A8]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rsi,rax
       test      rsi,rsi
       je        near ptr M00_L06
       lea       rdi,[rsi+10]
       mov       ebp,[rsi+8]
       mov       r14d,ebp
       xor       r15d,r15d
M00_L00:
       lea       ecx,[rbp-1]
       cmp       r15d,ecx
       jge       near ptr M00_L05
       cmp       r15d,ebp
       jg        near ptr M00_L11
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+238],8
       jle       near ptr M00_L07
       mov       rcx,[rcx+240]
       mov       rax,[rcx+40]
       test      rax,rax
       je        near ptr M00_L07
M00_L01:
       mov       rcx,[rax+10]
       test      rcx,rcx
       jne       short M00_L02
       call      qword ptr [7FFD57BD4360]; System.Random+ThreadSafeRandom.Create()
       mov       rcx,rax
M00_L02:
       mov       r8d,ebp
       sub       r8d,r15d
       mov       rax,[rcx+8]
       mov       rdx,[rcx+10]
       mov       r10,[rcx+18]
       mov       r9,[rcx+20]
       mov       r11,rdx
       shl       r11,11
       xor       r10,rax
       xor       r9,rdx
       lea       r13,[rdx+rdx*4]
       rol       r13,7
       lea       r13,[r13+r13*8]
       xor       rdx,r10
       xor       rax,r9
       xor       r10,r11
       rol       r9,2D
       mov       [rcx+8],rax
       mov       [rcx+10],rdx
       mov       [rcx+18],r10
       mov       [rcx+20],r9
       mov       r10d,r8d
       shr       r13,20
       mov       r9d,r13d
       imul      r10,r9
       mov       r9d,r10d
       cmp       r9d,r8d
       jb        near ptr M00_L08
M00_L03:
       shr       r10,20
       add       r10d,r15d
       cmp       r10d,r15d
       je        short M00_L04
       mov       r13,[rdi+r15*8]
       lea       rcx,[rdi+r15*8]
       cmp       r10d,r14d
       jae       near ptr M00_L12
       mov       r12d,r10d
       mov       rdx,[rdi+r12*8]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rdi+r12*8]
       mov       rdx,r13
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M00_L04:
       inc       r15d
       jmp       near ptr M00_L00
M00_L05:
       mov       [rsp+20],rsi
       mov       rdx,[rbx+60]
       cmp       [rdx],dl
       lea       rdx,[rsp+20]
       mov       rcx,7FFD57D93960
       call      qword ptr [7FFD57D85BF0]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]](System.Collections.Immutable.ImmutableArray`1<System.__Canon> ByRef)
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
M00_L06:
       mov       ecx,0BD3
       mov       rdx,7FFD574D4000
       call      qword ptr [7FFD5759F228]
       mov       rcx,rax
       call      qword ptr [7FFD57D8CAB0]
       int       3
M00_L07:
       mov       ecx,8
       call      qword ptr [7FFD57D8CCD8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L01
M00_L08:
       mov       eax,r8d
       neg       eax
       xor       edx,edx
       div       r8d
       jmp       short M00_L10
M00_L09:
       mov       r10,[rcx+8]
       mov       r9,[rcx+10]
       mov       rax,[rcx+18]
       mov       r11,[rcx+20]
       mov       r13,r9
       shl       r13,11
       xor       rax,r10
       xor       r11,r9
       lea       r12,[r9+r9*4]
       rol       r12,7
       lea       r12,[r12+r12*8]
       xor       r9,rax
       xor       r10,r11
       xor       rax,r13
       rol       r11,2D
       mov       [rcx+8],r10
       mov       [rcx+10],r9
       mov       [rcx+18],rax
       mov       [rcx+20],r11
       mov       r10d,r8d
       shr       r12,20
       mov       eax,r12d
       imul      r10,rax
       mov       r9d,r10d
M00_L10:
       cmp       r9d,edx
       jb        short M00_L09
       jmp       near ptr M00_L03
M00_L11:
       call      qword ptr [7FFD57D8EAC0]
       int       3
M00_L12:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 614
```
```assembly
; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       mov       rsi,rdx
       mov       rcx,[rbx+18]
       cmp       qword ptr [rcx+8],40
       jle       near ptr M01_L04
       mov       rcx,[rcx+40]
       test      rcx,rcx
       je        near ptr M01_L04
M01_L00:
       mov       rdx,rsi
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M01_L14
       mov       rdx,offset MT_System.Linq.Enumerable+ShuffleIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],rdx
       jne       near ptr M01_L40
       mov       rbx,[rax+18]
       mov       rdx,rbx
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M01_L05
       mov       rcx,offset MT_System.Linq.Enumerable+ShuffleIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],rcx
       jne       near ptr M01_L31
       mov       rcx,rax
       call      qword ptr [7FFD57D92F20]; System.Linq.Enumerable+ShuffleIterator`1[[System.__Canon, System.Private.CoreLib]].ToArray()
M01_L01:
       mov       rsi,rax
M01_L02:
       test      rsi,rsi
       je        near ptr M01_L34
       lea       rbx,[rsi+10]
       mov       edi,[rsi+8]
       mov       ebp,edi
       xor       r14d,r14d
M01_L03:
       lea       ecx,[rdi-1]
       cmp       r14d,ecx
       jl        near ptr M01_L09
       mov       rax,rsi
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L04:
       mov       rcx,rbx
       mov       rdx,7FFD57DF86A8
       call      qword ptr [7FFD5759F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L00
M01_L05:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFD5759F9F0]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rsi,rax
       test      rsi,rsi
       je        near ptr M01_L33
       mov       rcx,rsi
       mov       r11,7FFD574E0DA0
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L07
       test      byte ptr [7FFD57E14B08],1
       je        near ptr M01_L32
M01_L06:
       mov       rdx,1EF1C002A90
       mov       rsi,[rdx]
       jmp       short M01_L08
M01_L07:
       movsxd    rdx,eax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbx,rax
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r11,7FFD574E0DA8
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rsi,rbx
M01_L08:
       jmp       near ptr M01_L02
M01_L09:
       cmp       r14d,edi
       jg        near ptr M01_L39
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+238],8
       jle       near ptr M01_L35
       mov       rcx,[rcx+240]
       mov       rax,[rcx+40]
       test      rax,rax
       je        near ptr M01_L35
M01_L10:
       mov       rcx,[rax+10]
       test      rcx,rcx
       jne       short M01_L11
       call      qword ptr [7FFD57BD4360]; System.Random+ThreadSafeRandom.Create()
       mov       rcx,rax
M01_L11:
       mov       r8d,edi
       sub       r8d,r14d
       mov       rax,[rcx+8]
       mov       rdx,[rcx+10]
       mov       r10,[rcx+18]
       mov       r9,[rcx+20]
       mov       r11,rdx
       shl       r11,11
       xor       r10,rax
       xor       r9,rdx
       lea       r15,[rdx+rdx*4]
       rol       r15,7
       lea       r15,[r15+r15*8]
       xor       rdx,r10
       xor       rax,r9
       xor       r10,r11
       rol       r9,2D
       mov       [rcx+8],rax
       mov       [rcx+10],rdx
       mov       [rcx+18],r10
       mov       [rcx+20],r9
       mov       r10d,r8d
       shr       r15,20
       mov       r9d,r15d
       imul      r10,r9
       mov       r9d,r10d
       cmp       r9d,r8d
       jb        near ptr M01_L36
M01_L12:
       shr       r10,20
       add       r10d,r14d
       cmp       r10d,r14d
       je        short M01_L13
       mov       r15,[rbx+r14*8]
       lea       rcx,[rbx+r14*8]
       cmp       r10d,ebp
       jae       near ptr M01_L44
       mov       r13d,r10d
       mov       rdx,[rbx+r13*8]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rbx+r13*8]
       mov       rdx,r15
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M01_L13:
       inc       r14d
       jmp       near ptr M01_L03
M01_L14:
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       je        near ptr M01_L21
M01_L15:
       mov       rdx,rsi
       call      qword ptr [7FFD5759F9F0]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M01_L41
       mov       rcx,[rbx+18]
       cmp       qword ptr [rcx+8],38
       jle       near ptr M01_L22
       mov       rsi,[rcx+38]
       test      rsi,rsi
       je        near ptr M01_L22
M01_L16:
       mov       rcx,[rsi+18]
       mov       r11,[rcx+28]
       test      r11,r11
       je        near ptr M01_L23
M01_L17:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       je        near ptr M01_L24
       mov       rcx,[rsi+18]
       cmp       qword ptr [rcx+8],38
       jle       near ptr M01_L29
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        near ptr M01_L29
M01_L18:
       movsxd    rdx,ebx
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbx,rax
       mov       rcx,[rsi+18]
       cmp       qword ptr [rcx+8],40
       jle       near ptr M01_L30
       mov       r11,[rcx+40]
       test      r11,r11
       je        near ptr M01_L30
M01_L19:
       mov       rcx,rdi
       mov       rdx,rbx
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rax,rbx
M01_L20:
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L21:
       mov       rcx,rbx
       mov       rdx,7FFD57DF8540
       call      qword ptr [7FFD5759F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L15
M01_L22:
       mov       rcx,rbx
       mov       rdx,7FFD57DF8688
       call      qword ptr [7FFD5759F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M01_L16
M01_L23:
       mov       rcx,rsi
       mov       rdx,7FFD57DF86D0
       call      qword ptr [7FFD5759F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M01_L17
M01_L24:
       mov       rcx,[rsi+18]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L27
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L27
M01_L25:
       mov       rdx,[rcx+18]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M01_L28
M01_L26:
       mov       rcx,rdx
       call      qword ptr [7FFD57595728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rax]
       jmp       near ptr M01_L20
M01_L27:
       mov       rcx,rsi
       mov       rdx,7FFD57DF8770
       call      qword ptr [7FFD5759F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M01_L25
M01_L28:
       mov       rdx,7FFD57DF87B0
       call      qword ptr [7FFD5759F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       short M01_L26
M01_L29:
       mov       rcx,rsi
       mov       rdx,7FFD57DF8790
       call      qword ptr [7FFD5759F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L18
M01_L30:
       mov       rcx,rsi
       mov       rdx,7FFD57DF8798
       call      qword ptr [7FFD5759F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M01_L19
M01_L31:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       jmp       near ptr M01_L01
M01_L32:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFD57595728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M01_L06
M01_L33:
       mov       rdx,rbx
       mov       rcx,7FFD57E149A8
       call      qword ptr [7FFD57D8EA18]
       mov       rsi,rax
       jmp       near ptr M01_L02
M01_L34:
       mov       ecx,0BD3
       mov       rdx,7FFD574D4000
       call      qword ptr [7FFD5759F228]
       mov       rcx,rax
       call      qword ptr [7FFD57D8CAB0]
       int       3
M01_L35:
       mov       ecx,8
       call      qword ptr [7FFD57D8CCD8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M01_L10
M01_L36:
       mov       eax,r8d
       neg       eax
       xor       edx,edx
       div       r8d
       jmp       short M01_L38
M01_L37:
       mov       r10,[rcx+8]
       mov       r9,[rcx+10]
       mov       rax,[rcx+18]
       mov       r11,[rcx+20]
       mov       r15,r9
       shl       r15,11
       xor       rax,r10
       xor       r11,r9
       lea       r13,[r9+r9*4]
       rol       r13,7
       lea       r13,[r13+r13*8]
       xor       r9,rax
       xor       r10,r11
       xor       rax,r15
       rol       r11,2D
       mov       [rcx+8],r10
       mov       [rcx+10],r9
       mov       [rcx+18],rax
       mov       [rcx+20],r11
       mov       r10d,r8d
       shr       r13,20
       mov       eax,r13d
       imul      r10,rax
       mov       r9d,r10d
M01_L38:
       cmp       r9d,edx
       jb        short M01_L37
       jmp       near ptr M01_L12
M01_L39:
       call      qword ptr [7FFD57D8EAC0]
       int       3
M01_L40:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [rax+30]
M01_L41:
       mov       rcx,[rbx+18]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L42
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L42
       jmp       short M01_L43
M01_L42:
       mov       rcx,rbx
       mov       rdx,7FFD57DF8650
       call      qword ptr [7FFD5759F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M01_L43:
       mov       rdx,rsi
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FFD57D8EA18]
M01_L44:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1348
```
```assembly
; System.Random+ThreadSafeRandom.Create()
       push      rbx
       sub       rsp,20
       call      qword ptr [7FFD7EE5F760]
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD7EE69738]
       call      qword ptr [7FFD7EE56EA8]
       lea       rcx,[rax+10]
       mov       rdx,rbx
       call      qword ptr [7FFD7EE54FE8]; CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 51
```
```assembly
; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]](System.Collections.Immutable.ImmutableArray`1<System.__Canon> ByRef)
       ret
; Total bytes of code 1
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FFD7EE6DCF8]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       ecx,ebx
       and       ecx,0FFFFFF
       mov       edx,ecx
       mov       r8d,ebx
       sar       r8d,18
       jne       short M04_L01
       cmp       [rax],ecx
       jle       short M04_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M04_L03
M04_L00:
       add       rsp,20
       pop       rbx
       ret
M04_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M04_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M04_L00
M04_L02:
       cmp       [rax+4],edx
       jle       short M04_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M04_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M04_L03
       jmp       short M04_L00
M04_L03:
       mov       ecx,ebx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax]
; Total bytes of code 130
```

## .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.Shuffle()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Linq.Enumerable+ShuffleIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rsi+10],eax
       lea       rcx,[rsi+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rsi+18]
       mov       rcx,7FFD5797EA40
       call      qword ptr [7FFD578CC6A8]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rsi,rax
       test      rsi,rsi
       je        near ptr M00_L06
       lea       rdi,[rsi+10]
       mov       ebp,[rsi+8]
       mov       r14d,ebp
       xor       r15d,r15d
M00_L00:
       lea       ecx,[rbp-1]
       cmp       r15d,ecx
       jge       near ptr M00_L05
       cmp       r15d,ebp
       jg        near ptr M00_L11
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+238],8
       jle       near ptr M00_L07
       mov       rcx,[rcx+240]
       mov       rax,[rcx+40]
       test      rax,rax
       je        near ptr M00_L07
M00_L01:
       mov       rcx,[rax+10]
       test      rcx,rcx
       jne       short M00_L02
       call      qword ptr [7FFD57BB43C0]; System.Random+ThreadSafeRandom.Create()
       mov       rcx,rax
M00_L02:
       mov       r8d,ebp
       sub       r8d,r15d
       mov       rax,[rcx+8]
       mov       rdx,[rcx+10]
       mov       r10,[rcx+18]
       mov       r9,[rcx+20]
       mov       r11,rdx
       shl       r11,11
       xor       r10,rax
       xor       r9,rdx
       lea       r13,[rdx+rdx*4]
       rol       r13,7
       lea       r13,[r13+r13*8]
       xor       rdx,r10
       xor       rax,r9
       xor       r10,r11
       rol       r9,2D
       mov       [rcx+8],rax
       mov       [rcx+10],rdx
       mov       [rcx+18],r10
       mov       [rcx+20],r9
       mov       r10d,r8d
       shr       r13,20
       mov       r9d,r13d
       imul      r10,r9
       mov       r9d,r10d
       cmp       r9d,r8d
       jb        near ptr M00_L08
M00_L03:
       shr       r10,20
       add       r10d,r15d
       cmp       r10d,r15d
       je        short M00_L04
       mov       r13,[rdi+r15*8]
       lea       rcx,[rdi+r15*8]
       cmp       r10d,r14d
       jae       near ptr M00_L12
       mov       r12d,r10d
       mov       rdx,[rdi+r12*8]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rdi+r12*8]
       mov       rdx,r13
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M00_L04:
       inc       r15d
       jmp       near ptr M00_L00
M00_L05:
       mov       [rsp+20],rsi
       mov       rdx,[rbx+60]
       cmp       [rdx],dl
       lea       rdx,[rsp+20]
       mov       rcx,7FFD57D73960
       call      qword ptr [7FFD57D65B78]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]](System.Collections.Immutable.ImmutableArray`1<System.__Canon> ByRef)
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
M00_L06:
       mov       ecx,0BD3
       mov       rdx,7FFD574B4000
       call      qword ptr [7FFD5757F228]
       mov       rcx,rax
       call      qword ptr [7FFD57D6CB10]
       int       3
M00_L07:
       mov       ecx,8
       call      qword ptr [7FFD57D6CD38]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L01
M00_L08:
       mov       eax,r8d
       neg       eax
       xor       edx,edx
       div       r8d
       jmp       short M00_L10
M00_L09:
       mov       r10,[rcx+8]
       mov       r9,[rcx+10]
       mov       rax,[rcx+18]
       mov       r11,[rcx+20]
       mov       r13,r9
       shl       r13,11
       xor       rax,r10
       xor       r11,r9
       lea       r12,[r9+r9*4]
       rol       r12,7
       lea       r12,[r12+r12*8]
       xor       r9,rax
       xor       r10,r11
       xor       rax,r13
       rol       r11,2D
       mov       [rcx+8],r10
       mov       [rcx+10],r9
       mov       [rcx+18],rax
       mov       [rcx+20],r11
       mov       r10d,r8d
       shr       r12,20
       mov       eax,r12d
       imul      r10,rax
       mov       r9d,r10d
M00_L10:
       cmp       r9d,edx
       jb        short M00_L09
       jmp       near ptr M00_L03
M00_L11:
       call      qword ptr [7FFD57D6EB38]
       int       3
M00_L12:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 614
```
```assembly
; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       mov       rsi,rdx
       mov       rcx,[rbx+18]
       cmp       qword ptr [rcx+8],40
       jle       near ptr M01_L04
       mov       rcx,[rcx+40]
       test      rcx,rcx
       je        near ptr M01_L04
M01_L00:
       mov       rdx,rsi
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M01_L14
       mov       rdx,offset MT_System.Linq.Enumerable+ShuffleIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],rdx
       jne       near ptr M01_L40
       mov       rbx,[rax+18]
       mov       rdx,rbx
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M01_L05
       mov       rcx,offset MT_System.Linq.Enumerable+ShuffleIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],rcx
       jne       near ptr M01_L31
       mov       rcx,rax
       call      qword ptr [7FFD57D72F20]; System.Linq.Enumerable+ShuffleIterator`1[[System.__Canon, System.Private.CoreLib]].ToArray()
M01_L01:
       mov       rsi,rax
M01_L02:
       test      rsi,rsi
       je        near ptr M01_L34
       lea       rbx,[rsi+10]
       mov       edi,[rsi+8]
       mov       ebp,edi
       xor       r14d,r14d
M01_L03:
       lea       ecx,[rdi-1]
       cmp       r14d,ecx
       jl        near ptr M01_L09
       mov       rax,rsi
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L04:
       mov       rcx,rbx
       mov       rdx,7FFD57DD83F0
       call      qword ptr [7FFD5757F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L00
M01_L05:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFD5757F9F0]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rsi,rax
       test      rsi,rsi
       je        near ptr M01_L33
       mov       rcx,rsi
       mov       r11,7FFD574C0DA0
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L07
       test      byte ptr [7FFD57DF4BA0],1
       je        near ptr M01_L32
M01_L06:
       mov       rdx,204B4C02A90
       mov       rsi,[rdx]
       jmp       short M01_L08
M01_L07:
       movsxd    rdx,eax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbx,rax
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r11,7FFD574C0DA8
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rsi,rbx
M01_L08:
       jmp       near ptr M01_L02
M01_L09:
       cmp       r14d,edi
       jg        near ptr M01_L39
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+238],8
       jle       near ptr M01_L35
       mov       rcx,[rcx+240]
       mov       rax,[rcx+40]
       test      rax,rax
       je        near ptr M01_L35
M01_L10:
       mov       rcx,[rax+10]
       test      rcx,rcx
       jne       short M01_L11
       call      qword ptr [7FFD57BB43C0]; System.Random+ThreadSafeRandom.Create()
       mov       rcx,rax
M01_L11:
       mov       r8d,edi
       sub       r8d,r14d
       mov       rax,[rcx+8]
       mov       rdx,[rcx+10]
       mov       r10,[rcx+18]
       mov       r9,[rcx+20]
       mov       r11,rdx
       shl       r11,11
       xor       r10,rax
       xor       r9,rdx
       lea       r15,[rdx+rdx*4]
       rol       r15,7
       lea       r15,[r15+r15*8]
       xor       rdx,r10
       xor       rax,r9
       xor       r10,r11
       rol       r9,2D
       mov       [rcx+8],rax
       mov       [rcx+10],rdx
       mov       [rcx+18],r10
       mov       [rcx+20],r9
       mov       r10d,r8d
       shr       r15,20
       mov       r9d,r15d
       imul      r10,r9
       mov       r9d,r10d
       cmp       r9d,r8d
       jb        near ptr M01_L36
M01_L12:
       shr       r10,20
       add       r10d,r14d
       cmp       r10d,r14d
       je        short M01_L13
       mov       r15,[rbx+r14*8]
       lea       rcx,[rbx+r14*8]
       cmp       r10d,ebp
       jae       near ptr M01_L44
       mov       r13d,r10d
       mov       rdx,[rbx+r13*8]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rbx+r13*8]
       mov       rdx,r15
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M01_L13:
       inc       r14d
       jmp       near ptr M01_L03
M01_L14:
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       je        near ptr M01_L21
M01_L15:
       mov       rdx,rsi
       call      qword ptr [7FFD5757F9F0]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M01_L41
       mov       rcx,[rbx+18]
       cmp       qword ptr [rcx+8],38
       jle       near ptr M01_L22
       mov       rsi,[rcx+38]
       test      rsi,rsi
       je        near ptr M01_L22
M01_L16:
       mov       rcx,[rsi+18]
       mov       r11,[rcx+28]
       test      r11,r11
       je        near ptr M01_L23
M01_L17:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       je        near ptr M01_L24
       mov       rcx,[rsi+18]
       cmp       qword ptr [rcx+8],38
       jle       near ptr M01_L29
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        near ptr M01_L29
M01_L18:
       movsxd    rdx,ebx
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbx,rax
       mov       rcx,[rsi+18]
       cmp       qword ptr [rcx+8],40
       jle       near ptr M01_L30
       mov       r11,[rcx+40]
       test      r11,r11
       je        near ptr M01_L30
M01_L19:
       mov       rcx,rdi
       mov       rdx,rbx
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rax,rbx
M01_L20:
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L21:
       mov       rcx,rbx
       mov       rdx,7FFD57DD8288
       call      qword ptr [7FFD5757F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L15
M01_L22:
       mov       rcx,rbx
       mov       rdx,7FFD57DD83D0
       call      qword ptr [7FFD5757F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M01_L16
M01_L23:
       mov       rcx,rsi
       mov       rdx,7FFD57DD8418
       call      qword ptr [7FFD5757F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M01_L17
M01_L24:
       mov       rcx,[rsi+18]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L27
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L27
M01_L25:
       mov       rdx,[rcx+18]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M01_L28
M01_L26:
       mov       rcx,rdx
       call      qword ptr [7FFD57575728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rax]
       jmp       near ptr M01_L20
M01_L27:
       mov       rcx,rsi
       mov       rdx,7FFD57DD84B8
       call      qword ptr [7FFD5757F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M01_L25
M01_L28:
       mov       rdx,7FFD57DD84F8
       call      qword ptr [7FFD5757F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       short M01_L26
M01_L29:
       mov       rcx,rsi
       mov       rdx,7FFD57DD84D8
       call      qword ptr [7FFD5757F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L18
M01_L30:
       mov       rcx,rsi
       mov       rdx,7FFD57DD84E0
       call      qword ptr [7FFD5757F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M01_L19
M01_L31:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       jmp       near ptr M01_L01
M01_L32:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFD57575728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M01_L06
M01_L33:
       mov       rdx,rbx
       mov       rcx,7FFD57DF4A40
       call      qword ptr [7FFD57D6EA78]
       mov       rsi,rax
       jmp       near ptr M01_L02
M01_L34:
       mov       ecx,0BD3
       mov       rdx,7FFD574B4000
       call      qword ptr [7FFD5757F228]
       mov       rcx,rax
       call      qword ptr [7FFD57D6CB10]
       int       3
M01_L35:
       mov       ecx,8
       call      qword ptr [7FFD57D6CD38]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M01_L10
M01_L36:
       mov       eax,r8d
       neg       eax
       xor       edx,edx
       div       r8d
       jmp       short M01_L38
M01_L37:
       mov       r10,[rcx+8]
       mov       r9,[rcx+10]
       mov       rax,[rcx+18]
       mov       r11,[rcx+20]
       mov       r15,r9
       shl       r15,11
       xor       rax,r10
       xor       r11,r9
       lea       r13,[r9+r9*4]
       rol       r13,7
       lea       r13,[r13+r13*8]
       xor       r9,rax
       xor       r10,r11
       xor       rax,r15
       rol       r11,2D
       mov       [rcx+8],r10
       mov       [rcx+10],r9
       mov       [rcx+18],rax
       mov       [rcx+20],r11
       mov       r10d,r8d
       shr       r13,20
       mov       eax,r13d
       imul      r10,rax
       mov       r9d,r10d
M01_L38:
       cmp       r9d,edx
       jb        short M01_L37
       jmp       near ptr M01_L12
M01_L39:
       call      qword ptr [7FFD57D6EB38]
       int       3
M01_L40:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [rax+30]
M01_L41:
       mov       rcx,[rbx+18]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L42
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L42
       jmp       short M01_L43
M01_L42:
       mov       rcx,rbx
       mov       rdx,7FFD57DD8398
       call      qword ptr [7FFD5757F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M01_L43:
       mov       rdx,rsi
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FFD57D6EA78]
M01_L44:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1348
```
```assembly
; System.Random+ThreadSafeRandom.Create()
       push      rbx
       sub       rsp,20
       call      qword ptr [7FFD7EE5F760]
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD7EE69738]
       call      qword ptr [7FFD7EE56EA8]
       lea       rcx,[rax+10]
       mov       rdx,rbx
       call      qword ptr [7FFD7EE54FE8]; CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 51
```
```assembly
; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]](System.Collections.Immutable.ImmutableArray`1<System.__Canon> ByRef)
       ret
; Total bytes of code 1
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FFD7EE6DCF8]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       ecx,ebx
       and       ecx,0FFFFFF
       mov       edx,ecx
       mov       r8d,ebx
       sar       r8d,18
       jne       short M04_L01
       cmp       [rax],ecx
       jle       short M04_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M04_L03
M04_L00:
       add       rsp,20
       pop       rbx
       ret
M04_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M04_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M04_L00
M04_L02:
       cmp       [rax+4],edx
       jle       short M04_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M04_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M04_L03
       jmp       short M04_L00
M04_L03:
       mov       ecx,ebx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax]
; Total bytes of code 130
```

## .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.Shuffle()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Linq.Enumerable+ShuffleIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rsi+10],eax
       lea       rcx,[rsi+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rsi+18]
       mov       rcx,7FFD5797EA40
       call      qword ptr [7FFD578CC6A8]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rsi,rax
       test      rsi,rsi
       je        near ptr M00_L06
       lea       rdi,[rsi+10]
       mov       ebp,[rsi+8]
       mov       r14d,ebp
       xor       r15d,r15d
M00_L00:
       lea       ecx,[rbp-1]
       cmp       r15d,ecx
       jge       near ptr M00_L05
       cmp       r15d,ebp
       jg        near ptr M00_L11
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],8
       jle       near ptr M00_L07
       mov       rcx,[rcx+240]
       mov       rax,[rcx+40]
       test      rax,rax
       je        near ptr M00_L07
M00_L01:
       mov       rcx,[rax+10]
       test      rcx,rcx
       jne       short M00_L02
       call      qword ptr [7FFD57BB4360]; System.Random+ThreadSafeRandom.Create()
       mov       rcx,rax
M00_L02:
       mov       r8d,ebp
       sub       r8d,r15d
       mov       rax,[rcx+8]
       mov       rdx,[rcx+10]
       mov       r10,[rcx+18]
       mov       r9,[rcx+20]
       mov       r11,rdx
       shl       r11,11
       xor       r10,rax
       xor       r9,rdx
       lea       r13,[rdx+rdx*4]
       rol       r13,7
       lea       r13,[r13+r13*8]
       xor       rdx,r10
       xor       rax,r9
       xor       r10,r11
       rol       r9,2D
       mov       [rcx+8],rax
       mov       [rcx+10],rdx
       mov       [rcx+18],r10
       mov       [rcx+20],r9
       mov       r10d,r8d
       shr       r13,20
       mov       r9d,r13d
       imul      r10,r9
       mov       r9d,r10d
       cmp       r9d,r8d
       jb        near ptr M00_L08
M00_L03:
       shr       r10,20
       add       r10d,r15d
       cmp       r10d,r15d
       je        short M00_L04
       mov       r13,[rdi+r15*8]
       lea       rcx,[rdi+r15*8]
       cmp       r10d,r14d
       jae       near ptr M00_L12
       mov       r12d,r10d
       mov       rdx,[rdi+r12*8]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rdi+r12*8]
       mov       rdx,r13
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M00_L04:
       inc       r15d
       jmp       near ptr M00_L00
M00_L05:
       mov       [rsp+20],rsi
       mov       rdx,[rbx+60]
       cmp       [rdx],dl
       lea       rdx,[rsp+20]
       mov       rcx,7FFD57D73960
       call      qword ptr [7FFD57D65BF0]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]](System.Collections.Immutable.ImmutableArray`1<System.__Canon> ByRef)
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
M00_L06:
       mov       ecx,0BD3
       mov       rdx,7FFD574B4000
       call      qword ptr [7FFD5757F228]
       mov       rcx,rax
       call      qword ptr [7FFD57D6CA98]
       int       3
M00_L07:
       mov       ecx,8
       call      qword ptr [7FFD57D6CCC0]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L01
M00_L08:
       mov       eax,r8d
       neg       eax
       xor       edx,edx
       div       r8d
       jmp       short M00_L10
M00_L09:
       mov       r10,[rcx+8]
       mov       r9,[rcx+10]
       mov       rax,[rcx+18]
       mov       r11,[rcx+20]
       mov       r13,r9
       shl       r13,11
       xor       rax,r10
       xor       r11,r9
       lea       r12,[r9+r9*4]
       rol       r12,7
       lea       r12,[r12+r12*8]
       xor       r9,rax
       xor       r10,r11
       xor       rax,r13
       rol       r11,2D
       mov       [rcx+8],r10
       mov       [rcx+10],r9
       mov       [rcx+18],rax
       mov       [rcx+20],r11
       mov       r10d,r8d
       shr       r12,20
       mov       eax,r12d
       imul      r10,rax
       mov       r9d,r10d
M00_L10:
       cmp       r9d,edx
       jb        short M00_L09
       jmp       near ptr M00_L03
M00_L11:
       call      qword ptr [7FFD57D6EAC0]
       int       3
M00_L12:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 614
```
```assembly
; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       mov       rsi,rdx
       mov       rcx,[rbx+18]
       cmp       qword ptr [rcx+8],40
       jle       near ptr M01_L04
       mov       rcx,[rcx+40]
       test      rcx,rcx
       je        near ptr M01_L04
M01_L00:
       mov       rdx,rsi
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M01_L14
       mov       rdx,offset MT_System.Linq.Enumerable+ShuffleIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],rdx
       jne       near ptr M01_L40
       mov       rbx,[rax+18]
       mov       rdx,rbx
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M01_L05
       mov       rcx,offset MT_System.Linq.Enumerable+ShuffleIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],rcx
       jne       near ptr M01_L31
       mov       rcx,rax
       call      qword ptr [7FFD57D72F20]; System.Linq.Enumerable+ShuffleIterator`1[[System.__Canon, System.Private.CoreLib]].ToArray()
M01_L01:
       mov       rsi,rax
M01_L02:
       test      rsi,rsi
       je        near ptr M01_L34
       lea       rbx,[rsi+10]
       mov       edi,[rsi+8]
       mov       ebp,edi
       xor       r14d,r14d
M01_L03:
       lea       ecx,[rdi-1]
       cmp       r14d,ecx
       jl        near ptr M01_L09
       mov       rax,rsi
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L04:
       mov       rcx,rbx
       mov       rdx,7FFD57DD8A60
       call      qword ptr [7FFD5757F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L00
M01_L05:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFD5757F9F0]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rsi,rax
       test      rsi,rsi
       je        near ptr M01_L33
       mov       rcx,rsi
       mov       r11,7FFD574C0DA0
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L08
       test      byte ptr [7FFD57DF3F38],1
       je        near ptr M01_L32
M01_L06:
       mov       rdx,28540000A98
       mov       rsi,[rdx]
M01_L07:
       jmp       near ptr M01_L02
M01_L08:
       movsxd    rdx,eax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbx,rax
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r11,7FFD574C0DA8
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rsi,rbx
       jmp       short M01_L07
M01_L09:
       cmp       r14d,edi
       jg        near ptr M01_L39
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],8
       jle       near ptr M01_L35
       mov       rcx,[rcx+240]
       mov       rax,[rcx+40]
       test      rax,rax
       je        near ptr M01_L35
M01_L10:
       mov       rcx,[rax+10]
       test      rcx,rcx
       jne       short M01_L11
       call      qword ptr [7FFD57BB4360]; System.Random+ThreadSafeRandom.Create()
       mov       rcx,rax
M01_L11:
       mov       r8d,edi
       sub       r8d,r14d
       mov       rax,[rcx+8]
       mov       rdx,[rcx+10]
       mov       r10,[rcx+18]
       mov       r9,[rcx+20]
       mov       r11,rdx
       shl       r11,11
       xor       r10,rax
       xor       r9,rdx
       lea       r15,[rdx+rdx*4]
       rol       r15,7
       lea       r15,[r15+r15*8]
       xor       rdx,r10
       xor       rax,r9
       xor       r10,r11
       rol       r9,2D
       mov       [rcx+8],rax
       mov       [rcx+10],rdx
       mov       [rcx+18],r10
       mov       [rcx+20],r9
       mov       r10d,r8d
       shr       r15,20
       mov       r9d,r15d
       imul      r10,r9
       mov       r9d,r10d
       cmp       r9d,r8d
       jb        near ptr M01_L36
M01_L12:
       shr       r10,20
       add       r10d,r14d
       cmp       r10d,r14d
       je        short M01_L13
       mov       r15,[rbx+r14*8]
       lea       rcx,[rbx+r14*8]
       cmp       r10d,ebp
       jae       near ptr M01_L44
       mov       r13d,r10d
       mov       rdx,[rbx+r13*8]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rbx+r13*8]
       mov       rdx,r15
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M01_L13:
       inc       r14d
       jmp       near ptr M01_L03
M01_L14:
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       je        near ptr M01_L21
M01_L15:
       mov       rdx,rsi
       call      qword ptr [7FFD5757F9F0]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M01_L41
       mov       rcx,[rbx+18]
       cmp       qword ptr [rcx+8],38
       jle       near ptr M01_L22
       mov       rsi,[rcx+38]
       test      rsi,rsi
       je        near ptr M01_L22
M01_L16:
       mov       rcx,[rsi+18]
       mov       r11,[rcx+28]
       test      r11,r11
       je        near ptr M01_L23
M01_L17:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       je        near ptr M01_L24
       mov       rcx,[rsi+18]
       cmp       qword ptr [rcx+8],38
       jle       near ptr M01_L29
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        near ptr M01_L29
M01_L18:
       movsxd    rdx,ebx
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbx,rax
       mov       rcx,[rsi+18]
       cmp       qword ptr [rcx+8],40
       jle       near ptr M01_L30
       mov       r11,[rcx+40]
       test      r11,r11
       je        near ptr M01_L30
M01_L19:
       mov       rcx,rdi
       mov       rdx,rbx
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rax,rbx
M01_L20:
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L21:
       mov       rcx,rbx
       mov       rdx,7FFD57DD88F8
       call      qword ptr [7FFD5757F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L15
M01_L22:
       mov       rcx,rbx
       mov       rdx,7FFD57DD8A40
       call      qword ptr [7FFD5757F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M01_L16
M01_L23:
       mov       rcx,rsi
       mov       rdx,7FFD57DD8A88
       call      qword ptr [7FFD5757F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M01_L17
M01_L24:
       mov       rcx,[rsi+18]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L27
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L27
M01_L25:
       mov       rdx,[rcx+18]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M01_L28
M01_L26:
       mov       rcx,rdx
       call      qword ptr [7FFD57575728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rax]
       jmp       near ptr M01_L20
M01_L27:
       mov       rcx,rsi
       mov       rdx,7FFD57DD8B28
       call      qword ptr [7FFD5757F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M01_L25
M01_L28:
       mov       rdx,7FFD57DD8B68
       call      qword ptr [7FFD5757F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       short M01_L26
M01_L29:
       mov       rcx,rsi
       mov       rdx,7FFD57DD8B48
       call      qword ptr [7FFD5757F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L18
M01_L30:
       mov       rcx,rsi
       mov       rdx,7FFD57DD8B50
       call      qword ptr [7FFD5757F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M01_L19
M01_L31:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       jmp       near ptr M01_L01
M01_L32:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFD57575728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M01_L06
M01_L33:
       mov       rdx,rbx
       mov       rcx,7FFD57DF3DD8
       call      qword ptr [7FFD57D6EA00]
       mov       rsi,rax
       jmp       near ptr M01_L02
M01_L34:
       mov       ecx,0BD3
       mov       rdx,7FFD574B4000
       call      qword ptr [7FFD5757F228]
       mov       rcx,rax
       call      qword ptr [7FFD57D6CA98]
       int       3
M01_L35:
       mov       ecx,8
       call      qword ptr [7FFD57D6CCC0]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M01_L10
M01_L36:
       mov       eax,r8d
       neg       eax
       xor       edx,edx
       div       r8d
       jmp       short M01_L38
M01_L37:
       mov       r10,[rcx+8]
       mov       r9,[rcx+10]
       mov       rax,[rcx+18]
       mov       r11,[rcx+20]
       mov       r15,r9
       shl       r15,11
       xor       rax,r10
       xor       r11,r9
       lea       r13,[r9+r9*4]
       rol       r13,7
       lea       r13,[r13+r13*8]
       xor       r9,rax
       xor       r10,r11
       xor       rax,r15
       rol       r11,2D
       mov       [rcx+8],r10
       mov       [rcx+10],r9
       mov       [rcx+18],rax
       mov       [rcx+20],r11
       mov       r10d,r8d
       shr       r13,20
       mov       eax,r13d
       imul      r10,rax
       mov       r9d,r10d
M01_L38:
       cmp       r9d,edx
       jb        short M01_L37
       jmp       near ptr M01_L12
M01_L39:
       call      qword ptr [7FFD57D6EAC0]
       int       3
M01_L40:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [rax+30]
M01_L41:
       mov       rcx,[rbx+18]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L42
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L42
       jmp       short M01_L43
M01_L42:
       mov       rcx,rbx
       mov       rdx,7FFD57DD8A08
       call      qword ptr [7FFD5757F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M01_L43:
       mov       rdx,rsi
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FFD57D6EA00]
M01_L44:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1348
```
```assembly
; System.Random+ThreadSafeRandom.Create()
       push      rbx
       sub       rsp,20
       call      qword ptr [7FFD7EE5F760]
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD7EE69738]
       call      qword ptr [7FFD7EE56EA8]
       lea       rcx,[rax+10]
       mov       rdx,rbx
       call      qword ptr [7FFD7EE54FE8]; CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 51
```
```assembly
; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]](System.Collections.Immutable.ImmutableArray`1<System.__Canon> ByRef)
       ret
; Total bytes of code 1
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FFD7EE6DCF8]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       ecx,ebx
       and       ecx,0FFFFFF
       mov       edx,ecx
       mov       r8d,ebx
       sar       r8d,18
       jne       short M04_L01
       cmp       [rax],ecx
       jle       short M04_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M04_L03
M04_L00:
       add       rsp,20
       pop       rbx
       ret
M04_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M04_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M04_L00
M04_L02:
       cmp       [rax+4],edx
       jle       short M04_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M04_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M04_L03
       jmp       short M04_L00
M04_L03:
       mov       ecx,ebx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax]
; Total bytes of code 130
```

## .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.Shuffle()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Linq.Enumerable+ShuffleIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rsi+10],eax
       lea       rcx,[rsi+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rsi+18]
       mov       rcx,7FFD5797EA40
       call      qword ptr [7FFD578CC6A8]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rsi,rax
       test      rsi,rsi
       je        near ptr M00_L06
       lea       rdi,[rsi+10]
       mov       ebp,[rsi+8]
       mov       r14d,ebp
       xor       r15d,r15d
M00_L00:
       lea       ecx,[rbp-1]
       cmp       r15d,ecx
       jge       near ptr M00_L05
       cmp       r15d,ebp
       jg        near ptr M00_L11
       mov       rcx,gs:[58]
       mov       rcx,[rcx+38]
       cmp       dword ptr [rcx+238],8
       jle       near ptr M00_L07
       mov       rcx,[rcx+240]
       mov       rax,[rcx+40]
       test      rax,rax
       je        near ptr M00_L07
M00_L01:
       mov       rcx,[rax+10]
       test      rcx,rcx
       jne       short M00_L02
       call      qword ptr [7FFD57BB43C0]; System.Random+ThreadSafeRandom.Create()
       mov       rcx,rax
M00_L02:
       mov       r8d,ebp
       sub       r8d,r15d
       mov       rax,[rcx+8]
       mov       rdx,[rcx+10]
       mov       r10,[rcx+18]
       mov       r9,[rcx+20]
       mov       r11,rdx
       shl       r11,11
       xor       r10,rax
       xor       r9,rdx
       lea       r13,[rdx+rdx*4]
       rol       r13,7
       lea       r13,[r13+r13*8]
       xor       rdx,r10
       xor       rax,r9
       xor       r10,r11
       rol       r9,2D
       mov       [rcx+8],rax
       mov       [rcx+10],rdx
       mov       [rcx+18],r10
       mov       [rcx+20],r9
       mov       r10d,r8d
       shr       r13,20
       mov       r9d,r13d
       imul      r10,r9
       mov       r9d,r10d
       cmp       r9d,r8d
       jb        near ptr M00_L08
M00_L03:
       shr       r10,20
       add       r10d,r15d
       cmp       r10d,r15d
       je        short M00_L04
       mov       r13,[rdi+r15*8]
       lea       rcx,[rdi+r15*8]
       cmp       r10d,r14d
       jae       near ptr M00_L12
       mov       r12d,r10d
       mov       rdx,[rdi+r12*8]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rdi+r12*8]
       mov       rdx,r13
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M00_L04:
       inc       r15d
       jmp       near ptr M00_L00
M00_L05:
       mov       [rsp+20],rsi
       mov       rdx,[rbx+60]
       cmp       [rdx],dl
       lea       rdx,[rsp+20]
       mov       rcx,7FFD57D73960
       call      qword ptr [7FFD57D65B78]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]](System.Collections.Immutable.ImmutableArray`1<System.__Canon> ByRef)
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
M00_L06:
       mov       ecx,0BD3
       mov       rdx,7FFD574B4000
       call      qword ptr [7FFD5757F228]
       mov       rcx,rax
       call      qword ptr [7FFD57D6CB10]
       int       3
M00_L07:
       mov       ecx,8
       call      qword ptr [7FFD57D6CD38]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L01
M00_L08:
       mov       eax,r8d
       neg       eax
       xor       edx,edx
       div       r8d
       jmp       short M00_L10
M00_L09:
       mov       r10,[rcx+8]
       mov       r9,[rcx+10]
       mov       rax,[rcx+18]
       mov       r11,[rcx+20]
       mov       r13,r9
       shl       r13,11
       xor       rax,r10
       xor       r11,r9
       lea       r12,[r9+r9*4]
       rol       r12,7
       lea       r12,[r12+r12*8]
       xor       r9,rax
       xor       r10,r11
       xor       rax,r13
       rol       r11,2D
       mov       [rcx+8],r10
       mov       [rcx+10],r9
       mov       [rcx+18],rax
       mov       [rcx+20],r11
       mov       r10d,r8d
       shr       r12,20
       mov       eax,r12d
       imul      r10,rax
       mov       r9d,r10d
M00_L10:
       cmp       r9d,edx
       jb        short M00_L09
       jmp       near ptr M00_L03
M00_L11:
       call      qword ptr [7FFD57D6EB38]
       int       3
M00_L12:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 614
```
```assembly
; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       mov       rsi,rdx
       mov       rcx,[rbx+18]
       cmp       qword ptr [rcx+8],40
       jle       near ptr M01_L04
       mov       rcx,[rcx+40]
       test      rcx,rcx
       je        near ptr M01_L04
M01_L00:
       mov       rdx,rsi
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M01_L14
       mov       rdx,offset MT_System.Linq.Enumerable+ShuffleIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],rdx
       jne       near ptr M01_L40
       mov       rbx,[rax+18]
       mov       rdx,rbx
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M01_L05
       mov       rcx,offset MT_System.Linq.Enumerable+ShuffleIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],rcx
       jne       near ptr M01_L31
       mov       rcx,rax
       call      qword ptr [7FFD57D72F20]; System.Linq.Enumerable+ShuffleIterator`1[[System.__Canon, System.Private.CoreLib]].ToArray()
M01_L01:
       mov       rsi,rax
M01_L02:
       test      rsi,rsi
       je        near ptr M01_L34
       lea       rbx,[rsi+10]
       mov       edi,[rsi+8]
       mov       ebp,edi
       xor       r14d,r14d
M01_L03:
       lea       ecx,[rdi-1]
       cmp       r14d,ecx
       jl        near ptr M01_L09
       mov       rax,rsi
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L04:
       mov       rcx,rbx
       mov       rdx,7FFD57DD85E8
       call      qword ptr [7FFD5757F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L00
M01_L05:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFD5757F9F0]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rsi,rax
       test      rsi,rsi
       je        near ptr M01_L33
       mov       rcx,rsi
       mov       r11,7FFD574C0C18
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L07
       test      byte ptr [7FFD57DF4BA8],1
       je        near ptr M01_L32
M01_L06:
       mov       rdx,2B486000A98
       mov       rsi,[rdx]
       jmp       short M01_L08
M01_L07:
       movsxd    rdx,eax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbx,rax
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r11,7FFD574C0C20
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rsi,rbx
M01_L08:
       jmp       near ptr M01_L02
M01_L09:
       cmp       r14d,edi
       jg        near ptr M01_L39
       mov       rcx,gs:[58]
       mov       rcx,[rcx+38]
       cmp       dword ptr [rcx+238],8
       jle       near ptr M01_L35
       mov       rcx,[rcx+240]
       mov       rax,[rcx+40]
       test      rax,rax
       je        near ptr M01_L35
M01_L10:
       mov       rcx,[rax+10]
       test      rcx,rcx
       jne       short M01_L11
       call      qword ptr [7FFD57BB43C0]; System.Random+ThreadSafeRandom.Create()
       mov       rcx,rax
M01_L11:
       mov       r8d,edi
       sub       r8d,r14d
       mov       rax,[rcx+8]
       mov       rdx,[rcx+10]
       mov       r10,[rcx+18]
       mov       r9,[rcx+20]
       mov       r11,rdx
       shl       r11,11
       xor       r10,rax
       xor       r9,rdx
       lea       r15,[rdx+rdx*4]
       rol       r15,7
       lea       r15,[r15+r15*8]
       xor       rdx,r10
       xor       rax,r9
       xor       r10,r11
       rol       r9,2D
       mov       [rcx+8],rax
       mov       [rcx+10],rdx
       mov       [rcx+18],r10
       mov       [rcx+20],r9
       mov       r10d,r8d
       shr       r15,20
       mov       r9d,r15d
       imul      r10,r9
       mov       r9d,r10d
       cmp       r9d,r8d
       jb        near ptr M01_L36
M01_L12:
       shr       r10,20
       add       r10d,r14d
       cmp       r10d,r14d
       je        short M01_L13
       mov       r15,[rbx+r14*8]
       lea       rcx,[rbx+r14*8]
       cmp       r10d,ebp
       jae       near ptr M01_L44
       mov       r13d,r10d
       mov       rdx,[rbx+r13*8]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rbx+r13*8]
       mov       rdx,r15
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M01_L13:
       inc       r14d
       jmp       near ptr M01_L03
M01_L14:
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       je        near ptr M01_L21
M01_L15:
       mov       rdx,rsi
       call      qword ptr [7FFD5757F9F0]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M01_L41
       mov       rcx,[rbx+18]
       cmp       qword ptr [rcx+8],38
       jle       near ptr M01_L22
       mov       rsi,[rcx+38]
       test      rsi,rsi
       je        near ptr M01_L22
M01_L16:
       mov       rcx,[rsi+18]
       mov       r11,[rcx+28]
       test      r11,r11
       je        near ptr M01_L23
M01_L17:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       je        near ptr M01_L24
       mov       rcx,[rsi+18]
       cmp       qword ptr [rcx+8],38
       jle       near ptr M01_L29
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        near ptr M01_L29
M01_L18:
       movsxd    rdx,ebx
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbx,rax
       mov       rcx,[rsi+18]
       cmp       qword ptr [rcx+8],40
       jle       near ptr M01_L30
       mov       r11,[rcx+40]
       test      r11,r11
       je        near ptr M01_L30
M01_L19:
       mov       rcx,rdi
       mov       rdx,rbx
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rax,rbx
M01_L20:
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L21:
       mov       rcx,rbx
       mov       rdx,7FFD57DD8480
       call      qword ptr [7FFD5757F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L15
M01_L22:
       mov       rcx,rbx
       mov       rdx,7FFD57DD85C8
       call      qword ptr [7FFD5757F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M01_L16
M01_L23:
       mov       rcx,rsi
       mov       rdx,7FFD57DD8610
       call      qword ptr [7FFD5757F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M01_L17
M01_L24:
       mov       rcx,[rsi+18]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L27
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L27
M01_L25:
       mov       rdx,[rcx+18]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M01_L28
M01_L26:
       mov       rcx,rdx
       call      qword ptr [7FFD57575728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rax]
       jmp       near ptr M01_L20
M01_L27:
       mov       rcx,rsi
       mov       rdx,7FFD57DD86B0
       call      qword ptr [7FFD5757F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M01_L25
M01_L28:
       mov       rdx,7FFD57DD86F0
       call      qword ptr [7FFD5757F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       short M01_L26
M01_L29:
       mov       rcx,rsi
       mov       rdx,7FFD57DD86D0
       call      qword ptr [7FFD5757F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L18
M01_L30:
       mov       rcx,rsi
       mov       rdx,7FFD57DD86D8
       call      qword ptr [7FFD5757F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M01_L19
M01_L31:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       jmp       near ptr M01_L01
M01_L32:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFD57575728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M01_L06
M01_L33:
       mov       rdx,rbx
       mov       rcx,7FFD57DF4A48
       call      qword ptr [7FFD57D6EA90]
       mov       rsi,rax
       jmp       near ptr M01_L02
M01_L34:
       mov       ecx,0BD3
       mov       rdx,7FFD574B4000
       call      qword ptr [7FFD5757F228]
       mov       rcx,rax
       call      qword ptr [7FFD57D6CB10]
       int       3
M01_L35:
       mov       ecx,8
       call      qword ptr [7FFD57D6CD38]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M01_L10
M01_L36:
       mov       eax,r8d
       neg       eax
       xor       edx,edx
       div       r8d
       jmp       short M01_L38
M01_L37:
       mov       r10,[rcx+8]
       mov       r9,[rcx+10]
       mov       rax,[rcx+18]
       mov       r11,[rcx+20]
       mov       r15,r9
       shl       r15,11
       xor       rax,r10
       xor       r11,r9
       lea       r13,[r9+r9*4]
       rol       r13,7
       lea       r13,[r13+r13*8]
       xor       r9,rax
       xor       r10,r11
       xor       rax,r15
       rol       r11,2D
       mov       [rcx+8],r10
       mov       [rcx+10],r9
       mov       [rcx+18],rax
       mov       [rcx+20],r11
       mov       r10d,r8d
       shr       r13,20
       mov       eax,r13d
       imul      r10,rax
       mov       r9d,r10d
M01_L38:
       cmp       r9d,edx
       jb        short M01_L37
       jmp       near ptr M01_L12
M01_L39:
       call      qword ptr [7FFD57D6EB38]
       int       3
M01_L40:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [rax+30]
M01_L41:
       mov       rcx,[rbx+18]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L42
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L42
       jmp       short M01_L43
M01_L42:
       mov       rcx,rbx
       mov       rdx,7FFD57DD8590
       call      qword ptr [7FFD5757F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M01_L43:
       mov       rdx,rsi
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FFD57D6EA90]
M01_L44:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1348
```
```assembly
; System.Random+ThreadSafeRandom.Create()
       push      rbx
       sub       rsp,20
       call      qword ptr [7FFD7EE5F760]
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD7EE69738]
       call      qword ptr [7FFD7EE56EA8]
       lea       rcx,[rax+10]
       mov       rdx,rbx
       call      qword ptr [7FFD7EE54FE8]; CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 51
```
```assembly
; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]](System.Collections.Immutable.ImmutableArray`1<System.__Canon> ByRef)
       ret
; Total bytes of code 1
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FFD7EE6DCF8]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       ecx,ebx
       and       ecx,0FFFFFF
       mov       edx,ecx
       mov       r8d,ebx
       sar       r8d,18
       jne       short M04_L01
       cmp       [rax],ecx
       jle       short M04_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M04_L03
M04_L00:
       add       rsp,20
       pop       rbx
       ret
M04_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M04_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M04_L00
M04_L02:
       cmp       [rax+4],edx
       jle       short M04_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M04_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M04_L03
       jmp       short M04_L00
M04_L03:
       mov       ecx,ebx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax]
; Total bytes of code 130
```

## .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.Shuffle()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Linq.Enumerable+ShuffleIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rsi+10],eax
       lea       rcx,[rsi+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rsi+18]
       mov       rcx,7FFD5799EA40
       call      qword ptr [7FFD578EC6A8]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rsi,rax
       test      rsi,rsi
       je        near ptr M00_L06
       lea       rdi,[rsi+10]
       mov       ebp,[rsi+8]
       mov       r14d,ebp
       xor       r15d,r15d
M00_L00:
       lea       ecx,[rbp-1]
       cmp       r15d,ecx
       jge       near ptr M00_L05
       cmp       r15d,ebp
       jg        near ptr M00_L11
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],8
       jle       near ptr M00_L07
       mov       rcx,[rcx+240]
       mov       rax,[rcx+40]
       test      rax,rax
       je        near ptr M00_L07
M00_L01:
       mov       rcx,[rax+10]
       test      rcx,rcx
       jne       short M00_L02
       call      qword ptr [7FFD57BD43D8]; System.Random+ThreadSafeRandom.Create()
       mov       rcx,rax
M00_L02:
       mov       r8d,ebp
       sub       r8d,r15d
       mov       rax,[rcx+8]
       mov       rdx,[rcx+10]
       mov       r10,[rcx+18]
       mov       r9,[rcx+20]
       mov       r11,rdx
       shl       r11,11
       xor       r10,rax
       xor       r9,rdx
       lea       r13,[rdx+rdx*4]
       rol       r13,7
       lea       r13,[r13+r13*8]
       xor       rdx,r10
       xor       rax,r9
       xor       r10,r11
       rol       r9,2D
       mov       [rcx+8],rax
       mov       [rcx+10],rdx
       mov       [rcx+18],r10
       mov       [rcx+20],r9
       mov       r10d,r8d
       shr       r13,20
       mov       r9d,r13d
       imul      r10,r9
       mov       r9d,r10d
       cmp       r9d,r8d
       jb        near ptr M00_L08
M00_L03:
       shr       r10,20
       add       r10d,r15d
       cmp       r10d,r15d
       je        short M00_L04
       mov       r13,[rdi+r15*8]
       lea       rcx,[rdi+r15*8]
       cmp       r10d,r14d
       jae       near ptr M00_L12
       mov       r12d,r10d
       mov       rdx,[rdi+r12*8]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rdi+r12*8]
       mov       rdx,r13
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M00_L04:
       inc       r15d
       jmp       near ptr M00_L00
M00_L05:
       mov       [rsp+20],rsi
       mov       rdx,[rbx+60]
       cmp       [rdx],dl
       lea       rdx,[rsp+20]
       mov       rcx,7FFD57D93960
       call      qword ptr [7FFD57D85C50]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]](System.Collections.Immutable.ImmutableArray`1<System.__Canon> ByRef)
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
M00_L06:
       mov       ecx,0BD3
       mov       rdx,7FFD574D4000
       call      qword ptr [7FFD5759F228]
       mov       rcx,rax
       call      qword ptr [7FFD57D8CB28]
       int       3
M00_L07:
       mov       ecx,8
       call      qword ptr [7FFD57D8CD50]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L01
M00_L08:
       mov       eax,r8d
       neg       eax
       xor       edx,edx
       div       r8d
       jmp       short M00_L10
M00_L09:
       mov       r10,[rcx+8]
       mov       r9,[rcx+10]
       mov       rax,[rcx+18]
       mov       r11,[rcx+20]
       mov       r13,r9
       shl       r13,11
       xor       rax,r10
       xor       r11,r9
       lea       r12,[r9+r9*4]
       rol       r12,7
       lea       r12,[r12+r12*8]
       xor       r9,rax
       xor       r10,r11
       xor       rax,r13
       rol       r11,2D
       mov       [rcx+8],r10
       mov       [rcx+10],r9
       mov       [rcx+18],rax
       mov       [rcx+20],r11
       mov       r10d,r8d
       shr       r12,20
       mov       eax,r12d
       imul      r10,rax
       mov       r9d,r10d
M00_L10:
       cmp       r9d,edx
       jb        short M00_L09
       jmp       near ptr M00_L03
M00_L11:
       call      qword ptr [7FFD57D8EB38]
       int       3
M00_L12:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 614
```
```assembly
; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       mov       rsi,rdx
       mov       rcx,[rbx+18]
       cmp       qword ptr [rcx+8],40
       jle       near ptr M01_L04
       mov       rcx,[rcx+40]
       test      rcx,rcx
       je        near ptr M01_L04
M01_L00:
       mov       rdx,rsi
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M01_L14
       mov       rdx,offset MT_System.Linq.Enumerable+ShuffleIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],rdx
       jne       near ptr M01_L40
       mov       rbx,[rax+18]
       mov       rdx,rbx
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M01_L05
       mov       rcx,offset MT_System.Linq.Enumerable+ShuffleIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],rcx
       jne       near ptr M01_L31
       mov       rcx,rax
       call      qword ptr [7FFD57D92F20]; System.Linq.Enumerable+ShuffleIterator`1[[System.__Canon, System.Private.CoreLib]].ToArray()
M01_L01:
       mov       rsi,rax
M01_L02:
       test      rsi,rsi
       je        near ptr M01_L34
       lea       rbx,[rsi+10]
       mov       edi,[rsi+8]
       mov       ebp,edi
       xor       r14d,r14d
M01_L03:
       lea       ecx,[rdi-1]
       cmp       r14d,ecx
       jl        near ptr M01_L09
       mov       rax,rsi
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L04:
       mov       rcx,rbx
       mov       rdx,7FFD57DF8720
       call      qword ptr [7FFD5759F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L00
M01_L05:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFD5759F9F0]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rsi,rax
       test      rsi,rsi
       je        near ptr M01_L33
       mov       rcx,rsi
       mov       r11,7FFD574E0D90
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L07
       test      byte ptr [7FFD57E11E58],1
       je        near ptr M01_L32
M01_L06:
       mov       rdx,1C9D4400A98
       mov       rsi,[rdx]
       jmp       short M01_L08
M01_L07:
       movsxd    rdx,eax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbx,rax
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r11,7FFD574E0D98
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rsi,rbx
M01_L08:
       jmp       near ptr M01_L02
M01_L09:
       cmp       r14d,edi
       jg        near ptr M01_L39
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],8
       jle       near ptr M01_L35
       mov       rcx,[rcx+240]
       mov       rax,[rcx+40]
       test      rax,rax
       je        near ptr M01_L35
M01_L10:
       mov       rcx,[rax+10]
       test      rcx,rcx
       jne       short M01_L11
       call      qword ptr [7FFD57BD43D8]; System.Random+ThreadSafeRandom.Create()
       mov       rcx,rax
M01_L11:
       mov       r8d,edi
       sub       r8d,r14d
       mov       rax,[rcx+8]
       mov       rdx,[rcx+10]
       mov       r10,[rcx+18]
       mov       r9,[rcx+20]
       mov       r11,rdx
       shl       r11,11
       xor       r10,rax
       xor       r9,rdx
       lea       r15,[rdx+rdx*4]
       rol       r15,7
       lea       r15,[r15+r15*8]
       xor       rdx,r10
       xor       rax,r9
       xor       r10,r11
       rol       r9,2D
       mov       [rcx+8],rax
       mov       [rcx+10],rdx
       mov       [rcx+18],r10
       mov       [rcx+20],r9
       mov       r10d,r8d
       shr       r15,20
       mov       r9d,r15d
       imul      r10,r9
       mov       r9d,r10d
       cmp       r9d,r8d
       jb        near ptr M01_L36
M01_L12:
       shr       r10,20
       add       r10d,r14d
       cmp       r10d,r14d
       je        short M01_L13
       mov       r15,[rbx+r14*8]
       lea       rcx,[rbx+r14*8]
       cmp       r10d,ebp
       jae       near ptr M01_L44
       mov       r13d,r10d
       mov       rdx,[rbx+r13*8]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rbx+r13*8]
       mov       rdx,r15
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M01_L13:
       inc       r14d
       jmp       near ptr M01_L03
M01_L14:
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       je        near ptr M01_L21
M01_L15:
       mov       rdx,rsi
       call      qword ptr [7FFD5759F9F0]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M01_L41
       mov       rcx,[rbx+18]
       cmp       qword ptr [rcx+8],38
       jle       near ptr M01_L22
       mov       rsi,[rcx+38]
       test      rsi,rsi
       je        near ptr M01_L22
M01_L16:
       mov       rcx,[rsi+18]
       mov       r11,[rcx+28]
       test      r11,r11
       je        near ptr M01_L23
M01_L17:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       je        near ptr M01_L24
       mov       rcx,[rsi+18]
       cmp       qword ptr [rcx+8],38
       jle       near ptr M01_L29
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        near ptr M01_L29
M01_L18:
       movsxd    rdx,ebx
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbx,rax
       mov       rcx,[rsi+18]
       cmp       qword ptr [rcx+8],40
       jle       near ptr M01_L30
       mov       r11,[rcx+40]
       test      r11,r11
       je        near ptr M01_L30
M01_L19:
       mov       rcx,rdi
       mov       rdx,rbx
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rax,rbx
M01_L20:
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L21:
       mov       rcx,rbx
       mov       rdx,7FFD57DF85B8
       call      qword ptr [7FFD5759F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L15
M01_L22:
       mov       rcx,rbx
       mov       rdx,7FFD57DF8700
       call      qword ptr [7FFD5759F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M01_L16
M01_L23:
       mov       rcx,rsi
       mov       rdx,7FFD57DF8748
       call      qword ptr [7FFD5759F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M01_L17
M01_L24:
       mov       rcx,[rsi+18]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L27
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L27
M01_L25:
       mov       rdx,[rcx+18]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M01_L28
M01_L26:
       mov       rcx,rdx
       call      qword ptr [7FFD57595728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rax]
       jmp       near ptr M01_L20
M01_L27:
       mov       rcx,rsi
       mov       rdx,7FFD57DF87E8
       call      qword ptr [7FFD5759F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M01_L25
M01_L28:
       mov       rdx,7FFD57DF8828
       call      qword ptr [7FFD5759F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       short M01_L26
M01_L29:
       mov       rcx,rsi
       mov       rdx,7FFD57DF8808
       call      qword ptr [7FFD5759F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L18
M01_L30:
       mov       rcx,rsi
       mov       rdx,7FFD57DF8810
       call      qword ptr [7FFD5759F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M01_L19
M01_L31:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       jmp       near ptr M01_L01
M01_L32:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFD57595728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M01_L06
M01_L33:
       mov       rdx,rbx
       mov       rcx,7FFD57E11CF8
       call      qword ptr [7FFD57D8EAA8]
       mov       rsi,rax
       jmp       near ptr M01_L02
M01_L34:
       mov       ecx,0BD3
       mov       rdx,7FFD574D4000
       call      qword ptr [7FFD5759F228]
       mov       rcx,rax
       call      qword ptr [7FFD57D8CB28]
       int       3
M01_L35:
       mov       ecx,8
       call      qword ptr [7FFD57D8CD50]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M01_L10
M01_L36:
       mov       eax,r8d
       neg       eax
       xor       edx,edx
       div       r8d
       jmp       short M01_L38
M01_L37:
       mov       r10,[rcx+8]
       mov       r9,[rcx+10]
       mov       rax,[rcx+18]
       mov       r11,[rcx+20]
       mov       r15,r9
       shl       r15,11
       xor       rax,r10
       xor       r11,r9
       lea       r13,[r9+r9*4]
       rol       r13,7
       lea       r13,[r13+r13*8]
       xor       r9,rax
       xor       r10,r11
       xor       rax,r15
       rol       r11,2D
       mov       [rcx+8],r10
       mov       [rcx+10],r9
       mov       [rcx+18],rax
       mov       [rcx+20],r11
       mov       r10d,r8d
       shr       r13,20
       mov       eax,r13d
       imul      r10,rax
       mov       r9d,r10d
M01_L38:
       cmp       r9d,edx
       jb        short M01_L37
       jmp       near ptr M01_L12
M01_L39:
       call      qword ptr [7FFD57D8EB38]
       int       3
M01_L40:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [rax+30]
M01_L41:
       mov       rcx,[rbx+18]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L42
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L42
       jmp       short M01_L43
M01_L42:
       mov       rcx,rbx
       mov       rdx,7FFD57DF86C8
       call      qword ptr [7FFD5759F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M01_L43:
       mov       rdx,rsi
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FFD57D8EAA8]
M01_L44:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1348
```
```assembly
; System.Random+ThreadSafeRandom.Create()
       push      rbx
       sub       rsp,20
       call      qword ptr [7FFD7EE5F760]
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD7EE69738]
       call      qword ptr [7FFD7EE56EA8]
       lea       rcx,[rax+10]
       mov       rdx,rbx
       call      qword ptr [7FFD7EE54FE8]; CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 51
```
```assembly
; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]](System.Collections.Immutable.ImmutableArray`1<System.__Canon> ByRef)
       ret
; Total bytes of code 1
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FFD7EE6DCF8]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       ecx,ebx
       and       ecx,0FFFFFF
       mov       edx,ecx
       mov       r8d,ebx
       sar       r8d,18
       jne       short M04_L01
       cmp       [rax],ecx
       jle       short M04_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M04_L03
M04_L00:
       add       rsp,20
       pop       rbx
       ret
M04_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M04_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M04_L00
M04_L02:
       cmp       [rax+4],edx
       jle       short M04_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M04_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M04_L03
       jmp       short M04_L00
M04_L03:
       mov       ecx,ebx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax]
; Total bytes of code 130
```

## .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.Shuffle()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Linq.Enumerable+ShuffleIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rsi+10],eax
       lea       rcx,[rsi+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rsi+18]
       mov       rcx,7FFD5798EA40
       call      qword ptr [7FFD578DC6A8]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rsi,rax
       test      rsi,rsi
       je        near ptr M00_L06
       lea       rdi,[rsi+10]
       mov       ebp,[rsi+8]
       mov       r14d,ebp
       xor       r15d,r15d
M00_L00:
       lea       ecx,[rbp-1]
       cmp       r15d,ecx
       jge       near ptr M00_L05
       cmp       r15d,ebp
       jg        near ptr M00_L11
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+238],8
       jle       near ptr M00_L07
       mov       rcx,[rcx+240]
       mov       rax,[rcx+40]
       test      rax,rax
       je        near ptr M00_L07
M00_L01:
       mov       rcx,[rax+10]
       test      rcx,rcx
       jne       short M00_L02
       call      qword ptr [7FFD57BC43C0]; System.Random+ThreadSafeRandom.Create()
       mov       rcx,rax
M00_L02:
       mov       r8d,ebp
       sub       r8d,r15d
       mov       rax,[rcx+8]
       mov       rdx,[rcx+10]
       mov       r10,[rcx+18]
       mov       r9,[rcx+20]
       mov       r11,rdx
       shl       r11,11
       xor       r10,rax
       xor       r9,rdx
       lea       r13,[rdx+rdx*4]
       rol       r13,7
       lea       r13,[r13+r13*8]
       xor       rdx,r10
       xor       rax,r9
       xor       r10,r11
       rol       r9,2D
       mov       [rcx+8],rax
       mov       [rcx+10],rdx
       mov       [rcx+18],r10
       mov       [rcx+20],r9
       mov       r10d,r8d
       shr       r13,20
       mov       r9d,r13d
       imul      r10,r9
       mov       r9d,r10d
       cmp       r9d,r8d
       jb        near ptr M00_L08
M00_L03:
       shr       r10,20
       add       r10d,r15d
       cmp       r10d,r15d
       je        short M00_L04
       mov       r13,[rdi+r15*8]
       lea       rcx,[rdi+r15*8]
       cmp       r10d,r14d
       jae       near ptr M00_L12
       mov       r12d,r10d
       mov       rdx,[rdi+r12*8]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rdi+r12*8]
       mov       rdx,r13
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M00_L04:
       inc       r15d
       jmp       near ptr M00_L00
M00_L05:
       mov       [rsp+20],rsi
       mov       rdx,[rbx+60]
       cmp       [rdx],dl
       lea       rdx,[rsp+20]
       mov       rcx,7FFD57D83960
       call      qword ptr [7FFD57D75C50]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]](System.Collections.Immutable.ImmutableArray`1<System.__Canon> ByRef)
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
M00_L06:
       mov       ecx,0BD3
       mov       rdx,7FFD574C4000
       call      qword ptr [7FFD5758F228]
       mov       rcx,rax
       call      qword ptr [7FFD57D7CB10]
       int       3
M00_L07:
       mov       ecx,8
       call      qword ptr [7FFD57D7CD38]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L01
M00_L08:
       mov       eax,r8d
       neg       eax
       xor       edx,edx
       div       r8d
       jmp       short M00_L10
M00_L09:
       mov       r10,[rcx+8]
       mov       r9,[rcx+10]
       mov       rax,[rcx+18]
       mov       r11,[rcx+20]
       mov       r13,r9
       shl       r13,11
       xor       rax,r10
       xor       r11,r9
       lea       r12,[r9+r9*4]
       rol       r12,7
       lea       r12,[r12+r12*8]
       xor       r9,rax
       xor       r10,r11
       xor       rax,r13
       rol       r11,2D
       mov       [rcx+8],r10
       mov       [rcx+10],r9
       mov       [rcx+18],rax
       mov       [rcx+20],r11
       mov       r10d,r8d
       shr       r12,20
       mov       eax,r12d
       imul      r10,rax
       mov       r9d,r10d
M00_L10:
       cmp       r9d,edx
       jb        short M00_L09
       jmp       near ptr M00_L03
M00_L11:
       call      qword ptr [7FFD57D7EA90]
       int       3
M00_L12:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 614
```
```assembly
; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       mov       rsi,rdx
       mov       rcx,[rbx+18]
       cmp       qword ptr [rcx+8],40
       jle       near ptr M01_L04
       mov       rcx,[rcx+40]
       test      rcx,rcx
       je        near ptr M01_L04
M01_L00:
       mov       rdx,rsi
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M01_L14
       mov       rdx,offset MT_System.Linq.Enumerable+ShuffleIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],rdx
       jne       near ptr M01_L40
       mov       rbx,[rax+18]
       mov       rdx,rbx
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M01_L05
       mov       rcx,offset MT_System.Linq.Enumerable+ShuffleIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],rcx
       jne       near ptr M01_L31
       mov       rcx,rax
       call      qword ptr [7FFD57D82F20]; System.Linq.Enumerable+ShuffleIterator`1[[System.__Canon, System.Private.CoreLib]].ToArray()
M01_L01:
       mov       rsi,rax
M01_L02:
       test      rsi,rsi
       je        near ptr M01_L34
       lea       rbx,[rsi+10]
       mov       edi,[rsi+8]
       mov       ebp,edi
       xor       r14d,r14d
M01_L03:
       lea       ecx,[rdi-1]
       cmp       r14d,ecx
       jl        near ptr M01_L09
       mov       rax,rsi
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L04:
       mov       rcx,rbx
       mov       rdx,7FFD57DE89F8
       call      qword ptr [7FFD5758F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L00
M01_L05:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rsi,rax
       test      rsi,rsi
       je        near ptr M01_L33
       mov       rcx,rsi
       mov       r11,7FFD574D0D90
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L07
       test      byte ptr [7FFD57E01E20],1
       je        near ptr M01_L32
M01_L06:
       mov       rdx,2938F400A98
       mov       rsi,[rdx]
       jmp       short M01_L08
M01_L07:
       movsxd    rdx,eax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbx,rax
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r11,7FFD574D0D98
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rsi,rbx
M01_L08:
       jmp       near ptr M01_L02
M01_L09:
       cmp       r14d,edi
       jg        near ptr M01_L39
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+238],8
       jle       near ptr M01_L35
       mov       rcx,[rcx+240]
       mov       rax,[rcx+40]
       test      rax,rax
       je        near ptr M01_L35
M01_L10:
       mov       rcx,[rax+10]
       test      rcx,rcx
       jne       short M01_L11
       call      qword ptr [7FFD57BC43C0]; System.Random+ThreadSafeRandom.Create()
       mov       rcx,rax
M01_L11:
       mov       r8d,edi
       sub       r8d,r14d
       mov       rax,[rcx+8]
       mov       rdx,[rcx+10]
       mov       r10,[rcx+18]
       mov       r9,[rcx+20]
       mov       r11,rdx
       shl       r11,11
       xor       r10,rax
       xor       r9,rdx
       lea       r15,[rdx+rdx*4]
       rol       r15,7
       lea       r15,[r15+r15*8]
       xor       rdx,r10
       xor       rax,r9
       xor       r10,r11
       rol       r9,2D
       mov       [rcx+8],rax
       mov       [rcx+10],rdx
       mov       [rcx+18],r10
       mov       [rcx+20],r9
       mov       r10d,r8d
       shr       r15,20
       mov       r9d,r15d
       imul      r10,r9
       mov       r9d,r10d
       cmp       r9d,r8d
       jb        near ptr M01_L36
M01_L12:
       shr       r10,20
       add       r10d,r14d
       cmp       r10d,r14d
       je        short M01_L13
       mov       r15,[rbx+r14*8]
       lea       rcx,[rbx+r14*8]
       cmp       r10d,ebp
       jae       near ptr M01_L44
       mov       r13d,r10d
       mov       rdx,[rbx+r13*8]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rbx+r13*8]
       mov       rdx,r15
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M01_L13:
       inc       r14d
       jmp       near ptr M01_L03
M01_L14:
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       je        near ptr M01_L21
M01_L15:
       mov       rdx,rsi
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M01_L41
       mov       rcx,[rbx+18]
       cmp       qword ptr [rcx+8],38
       jle       near ptr M01_L22
       mov       rsi,[rcx+38]
       test      rsi,rsi
       je        near ptr M01_L22
M01_L16:
       mov       rcx,[rsi+18]
       mov       r11,[rcx+28]
       test      r11,r11
       je        near ptr M01_L23
M01_L17:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       je        near ptr M01_L24
       mov       rcx,[rsi+18]
       cmp       qword ptr [rcx+8],38
       jle       near ptr M01_L29
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        near ptr M01_L29
M01_L18:
       movsxd    rdx,ebx
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbx,rax
       mov       rcx,[rsi+18]
       cmp       qword ptr [rcx+8],40
       jle       near ptr M01_L30
       mov       r11,[rcx+40]
       test      r11,r11
       je        near ptr M01_L30
M01_L19:
       mov       rcx,rdi
       mov       rdx,rbx
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rax,rbx
M01_L20:
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L21:
       mov       rcx,rbx
       mov       rdx,7FFD57DE8890
       call      qword ptr [7FFD5758F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L15
M01_L22:
       mov       rcx,rbx
       mov       rdx,7FFD57DE89D8
       call      qword ptr [7FFD5758F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M01_L16
M01_L23:
       mov       rcx,rsi
       mov       rdx,7FFD57DE8A20
       call      qword ptr [7FFD5758F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M01_L17
M01_L24:
       mov       rcx,[rsi+18]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L27
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L27
M01_L25:
       mov       rdx,[rcx+18]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M01_L28
M01_L26:
       mov       rcx,rdx
       call      qword ptr [7FFD57585728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rax]
       jmp       near ptr M01_L20
M01_L27:
       mov       rcx,rsi
       mov       rdx,7FFD57DE8AC0
       call      qword ptr [7FFD5758F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M01_L25
M01_L28:
       mov       rdx,7FFD57DE8B00
       call      qword ptr [7FFD5758F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       short M01_L26
M01_L29:
       mov       rcx,rsi
       mov       rdx,7FFD57DE8AE0
       call      qword ptr [7FFD5758F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L18
M01_L30:
       mov       rcx,rsi
       mov       rdx,7FFD57DE8AE8
       call      qword ptr [7FFD5758F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M01_L19
M01_L31:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       jmp       near ptr M01_L01
M01_L32:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFD57585728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M01_L06
M01_L33:
       mov       rdx,rbx
       mov       rcx,7FFD57E01CC0
       call      qword ptr [7FFD57D7EAC0]
       mov       rsi,rax
       jmp       near ptr M01_L02
M01_L34:
       mov       ecx,0BD3
       mov       rdx,7FFD574C4000
       call      qword ptr [7FFD5758F228]
       mov       rcx,rax
       call      qword ptr [7FFD57D7CB10]
       int       3
M01_L35:
       mov       ecx,8
       call      qword ptr [7FFD57D7CD38]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M01_L10
M01_L36:
       mov       eax,r8d
       neg       eax
       xor       edx,edx
       div       r8d
       jmp       short M01_L38
M01_L37:
       mov       r10,[rcx+8]
       mov       r9,[rcx+10]
       mov       rax,[rcx+18]
       mov       r11,[rcx+20]
       mov       r15,r9
       shl       r15,11
       xor       rax,r10
       xor       r11,r9
       lea       r13,[r9+r9*4]
       rol       r13,7
       lea       r13,[r13+r13*8]
       xor       r9,rax
       xor       r10,r11
       xor       rax,r15
       rol       r11,2D
       mov       [rcx+8],r10
       mov       [rcx+10],r9
       mov       [rcx+18],rax
       mov       [rcx+20],r11
       mov       r10d,r8d
       shr       r13,20
       mov       eax,r13d
       imul      r10,rax
       mov       r9d,r10d
M01_L38:
       cmp       r9d,edx
       jb        short M01_L37
       jmp       near ptr M01_L12
M01_L39:
       call      qword ptr [7FFD57D7EA90]
       int       3
M01_L40:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [rax+30]
M01_L41:
       mov       rcx,[rbx+18]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L42
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L42
       jmp       short M01_L43
M01_L42:
       mov       rcx,rbx
       mov       rdx,7FFD57DE89A0
       call      qword ptr [7FFD5758F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M01_L43:
       mov       rdx,rsi
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FFD57D7EAC0]
M01_L44:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1346
```
```assembly
; System.Random+ThreadSafeRandom.Create()
       push      rbx
       sub       rsp,20
       call      qword ptr [7FFD7EE5F760]
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD7EE69738]
       call      qword ptr [7FFD7EE56EA8]
       lea       rcx,[rax+10]
       mov       rdx,rbx
       call      qword ptr [7FFD7EE54FE8]; CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 51
```
```assembly
; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]](System.Collections.Immutable.ImmutableArray`1<System.__Canon> ByRef)
       ret
; Total bytes of code 1
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FFD7EE6DCF8]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       ecx,ebx
       and       ecx,0FFFFFF
       mov       edx,ecx
       mov       r8d,ebx
       sar       r8d,18
       jne       short M04_L01
       cmp       [rax],ecx
       jle       short M04_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M04_L03
M04_L00:
       add       rsp,20
       pop       rbx
       ret
M04_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M04_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M04_L00
M04_L02:
       cmp       [rax+4],edx
       jle       short M04_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M04_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M04_L03
       jmp       short M04_L00
M04_L03:
       mov       ecx,ebx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax]
; Total bytes of code 130
```

## .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.Shuffle()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Linq.Enumerable+ShuffleIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rsi+10],eax
       lea       rcx,[rsi+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rsi+18]
       mov       rcx,7FFD5799EA40
       call      qword ptr [7FFD578EC6A8]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rsi,rax
       test      rsi,rsi
       je        near ptr M00_L06
       lea       rdi,[rsi+10]
       mov       ebp,[rsi+8]
       mov       r14d,ebp
       xor       r15d,r15d
M00_L00:
       lea       ecx,[rbp-1]
       cmp       r15d,ecx
       jge       near ptr M00_L05
       cmp       r15d,ebp
       jg        near ptr M00_L11
       mov       rcx,gs:[58]
       mov       rcx,[rcx+38]
       cmp       dword ptr [rcx+238],8
       jle       near ptr M00_L07
       mov       rcx,[rcx+240]
       mov       rax,[rcx+40]
       test      rax,rax
       je        near ptr M00_L07
M00_L01:
       mov       rcx,[rax+10]
       test      rcx,rcx
       jne       short M00_L02
       call      qword ptr [7FFD57BD4330]; System.Random+ThreadSafeRandom.Create()
       mov       rcx,rax
M00_L02:
       mov       r8d,ebp
       sub       r8d,r15d
       mov       rax,[rcx+8]
       mov       rdx,[rcx+10]
       mov       r10,[rcx+18]
       mov       r9,[rcx+20]
       mov       r11,rdx
       shl       r11,11
       xor       r10,rax
       xor       r9,rdx
       lea       r13,[rdx+rdx*4]
       rol       r13,7
       lea       r13,[r13+r13*8]
       xor       rdx,r10
       xor       rax,r9
       xor       r10,r11
       rol       r9,2D
       mov       [rcx+8],rax
       mov       [rcx+10],rdx
       mov       [rcx+18],r10
       mov       [rcx+20],r9
       mov       r10d,r8d
       shr       r13,20
       mov       r9d,r13d
       imul      r10,r9
       mov       r9d,r10d
       cmp       r9d,r8d
       jb        near ptr M00_L08
M00_L03:
       shr       r10,20
       add       r10d,r15d
       cmp       r10d,r15d
       je        short M00_L04
       mov       r13,[rdi+r15*8]
       lea       rcx,[rdi+r15*8]
       cmp       r10d,r14d
       jae       near ptr M00_L12
       mov       r12d,r10d
       mov       rdx,[rdi+r12*8]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rdi+r12*8]
       mov       rdx,r13
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M00_L04:
       inc       r15d
       jmp       near ptr M00_L00
M00_L05:
       mov       [rsp+20],rsi
       mov       rdx,[rbx+60]
       cmp       [rdx],dl
       lea       rdx,[rsp+20]
       mov       rcx,7FFD57DCB1E8
       call      qword ptr [7FFD57D7C6D8]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]](System.Collections.Immutable.ImmutableArray`1<System.__Canon> ByRef)
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
M00_L06:
       mov       ecx,0BD3
       mov       rdx,7FFD574D4000
       call      qword ptr [7FFD5759F228]
       mov       rcx,rax
       call      qword ptr [7FFD57C8D8A8]
       int       3
M00_L07:
       mov       ecx,8
       call      qword ptr [7FFD57C8DB60]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L01
M00_L08:
       mov       eax,r8d
       neg       eax
       xor       edx,edx
       div       r8d
       jmp       short M00_L10
M00_L09:
       mov       r10,[rcx+8]
       mov       r9,[rcx+10]
       mov       rax,[rcx+18]
       mov       r11,[rcx+20]
       mov       r13,r9
       shl       r13,11
       xor       rax,r10
       xor       r11,r9
       lea       r12,[r9+r9*4]
       rol       r12,7
       lea       r12,[r12+r12*8]
       xor       r9,rax
       xor       r10,r11
       xor       rax,r13
       rol       r11,2D
       mov       [rcx+8],r10
       mov       [rcx+10],r9
       mov       [rcx+18],rax
       mov       [rcx+20],r11
       mov       r10d,r8d
       shr       r12,20
       mov       eax,r12d
       imul      r10,rax
       mov       r9d,r10d
M00_L10:
       cmp       r9d,edx
       jb        short M00_L09
       jmp       near ptr M00_L03
M00_L11:
       call      qword ptr [7FFD57D7F8E8]
       int       3
M00_L12:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 614
```
```assembly
; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       mov       rsi,rdx
       mov       rcx,[rbx+18]
       cmp       qword ptr [rcx+8],40
       jle       near ptr M01_L04
       mov       rcx,[rcx+40]
       test      rcx,rcx
       je        near ptr M01_L04
M01_L00:
       mov       rdx,rsi
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M01_L14
       mov       rdx,offset MT_System.Linq.Enumerable+ShuffleIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],rdx
       jne       near ptr M01_L40
       mov       rbx,[rax+18]
       mov       rdx,rbx
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M01_L05
       mov       rcx,offset MT_System.Linq.Enumerable+ShuffleIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],rcx
       jne       near ptr M01_L31
       mov       rcx,rax
       call      qword ptr [7FFD57DCA7A8]; System.Linq.Enumerable+ShuffleIterator`1[[System.__Canon, System.Private.CoreLib]].ToArray()
M01_L01:
       mov       rsi,rax
M01_L02:
       test      rsi,rsi
       je        near ptr M01_L34
       lea       rbx,[rsi+10]
       mov       edi,[rsi+8]
       mov       ebp,edi
       xor       r14d,r14d
M01_L03:
       lea       ecx,[rdi-1]
       cmp       r14d,ecx
       jl        near ptr M01_L09
       mov       rax,rsi
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L04:
       mov       rcx,rbx
       mov       rdx,7FFD57E1BE40
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L00
M01_L05:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rsi,rax
       test      rsi,rsi
       je        near ptr M01_L33
       mov       rcx,rsi
       mov       r11,7FFD574E0F58
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L07
       test      byte ptr [7FFD57E35228],1
       je        near ptr M01_L32
M01_L06:
       mov       rdx,2EBD9800AF8
       mov       rsi,[rdx]
       jmp       short M01_L08
M01_L07:
       movsxd    rdx,eax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbx,rax
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r11,7FFD574E0F60
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rsi,rbx
M01_L08:
       jmp       near ptr M01_L02
M01_L09:
       cmp       r14d,edi
       jg        near ptr M01_L39
       mov       rcx,gs:[58]
       mov       rcx,[rcx+38]
       cmp       dword ptr [rcx+238],8
       jle       near ptr M01_L35
       mov       rcx,[rcx+240]
       mov       rax,[rcx+40]
       test      rax,rax
       je        near ptr M01_L35
M01_L10:
       mov       rcx,[rax+10]
       test      rcx,rcx
       jne       short M01_L11
       call      qword ptr [7FFD57BD4330]; System.Random+ThreadSafeRandom.Create()
       mov       rcx,rax
M01_L11:
       mov       r8d,edi
       sub       r8d,r14d
       mov       rax,[rcx+8]
       mov       rdx,[rcx+10]
       mov       r10,[rcx+18]
       mov       r9,[rcx+20]
       mov       r11,rdx
       shl       r11,11
       xor       r10,rax
       xor       r9,rdx
       lea       r15,[rdx+rdx*4]
       rol       r15,7
       lea       r15,[r15+r15*8]
       xor       rdx,r10
       xor       rax,r9
       xor       r10,r11
       rol       r9,2D
       mov       [rcx+8],rax
       mov       [rcx+10],rdx
       mov       [rcx+18],r10
       mov       [rcx+20],r9
       mov       r10d,r8d
       shr       r15,20
       mov       r9d,r15d
       imul      r10,r9
       mov       r9d,r10d
       cmp       r9d,r8d
       jb        near ptr M01_L36
M01_L12:
       shr       r10,20
       add       r10d,r14d
       cmp       r10d,r14d
       je        short M01_L13
       mov       r15,[rbx+r14*8]
       lea       rcx,[rbx+r14*8]
       cmp       r10d,ebp
       jae       near ptr M01_L44
       mov       r13d,r10d
       mov       rdx,[rbx+r13*8]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rbx+r13*8]
       mov       rdx,r15
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M01_L13:
       inc       r14d
       jmp       near ptr M01_L03
M01_L14:
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       je        near ptr M01_L21
M01_L15:
       mov       rdx,rsi
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M01_L41
       mov       rcx,[rbx+18]
       cmp       qword ptr [rcx+8],38
       jle       near ptr M01_L22
       mov       rsi,[rcx+38]
       test      rsi,rsi
       je        near ptr M01_L22
M01_L16:
       mov       rcx,[rsi+18]
       mov       r11,[rcx+28]
       test      r11,r11
       je        near ptr M01_L23
M01_L17:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       je        near ptr M01_L24
       mov       rcx,[rsi+18]
       cmp       qword ptr [rcx+8],38
       jle       near ptr M01_L29
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        near ptr M01_L29
M01_L18:
       movsxd    rdx,ebx
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbx,rax
       mov       rcx,[rsi+18]
       cmp       qword ptr [rcx+8],40
       jle       near ptr M01_L30
       mov       r11,[rcx+40]
       test      r11,r11
       je        near ptr M01_L30
M01_L19:
       mov       rcx,rdi
       mov       rdx,rbx
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rax,rbx
M01_L20:
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L21:
       mov       rcx,rbx
       mov       rdx,7FFD57E1BCD8
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L15
M01_L22:
       mov       rcx,rbx
       mov       rdx,7FFD57E1BE20
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M01_L16
M01_L23:
       mov       rcx,rsi
       mov       rdx,7FFD57E1BE50
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M01_L17
M01_L24:
       mov       rcx,[rsi+18]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L27
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L27
M01_L25:
       mov       rdx,[rcx+18]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M01_L28
M01_L26:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rax]
       jmp       near ptr M01_L20
M01_L27:
       mov       rcx,rsi
       mov       rdx,7FFD57E1BEF0
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M01_L25
M01_L28:
       mov       rdx,7FFD57DBC520
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       short M01_L26
M01_L29:
       mov       rcx,rsi
       mov       rdx,7FFD57E1BF10
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L18
M01_L30:
       mov       rcx,rsi
       mov       rdx,7FFD57E1BF18
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M01_L19
M01_L31:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       jmp       near ptr M01_L01
M01_L32:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M01_L06
M01_L33:
       mov       rdx,rbx
       mov       rcx,7FFD57E350C8
       call      qword ptr [7FFD57D7F870]
       mov       rsi,rax
       jmp       near ptr M01_L02
M01_L34:
       mov       ecx,0BD3
       mov       rdx,7FFD574D4000
       call      qword ptr [7FFD5759F228]
       mov       rcx,rax
       call      qword ptr [7FFD57C8D8A8]
       int       3
M01_L35:
       mov       ecx,8
       call      qword ptr [7FFD57C8DB60]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M01_L10
M01_L36:
       mov       eax,r8d
       neg       eax
       xor       edx,edx
       div       r8d
       jmp       short M01_L38
M01_L37:
       mov       r10,[rcx+8]
       mov       r9,[rcx+10]
       mov       rax,[rcx+18]
       mov       r11,[rcx+20]
       mov       r15,r9
       shl       r15,11
       xor       rax,r10
       xor       r11,r9
       lea       r13,[r9+r9*4]
       rol       r13,7
       lea       r13,[r13+r13*8]
       xor       r9,rax
       xor       r10,r11
       xor       rax,r15
       rol       r11,2D
       mov       [rcx+8],r10
       mov       [rcx+10],r9
       mov       [rcx+18],rax
       mov       [rcx+20],r11
       mov       r10d,r8d
       shr       r13,20
       mov       eax,r13d
       imul      r10,rax
       mov       r9d,r10d
M01_L38:
       cmp       r9d,edx
       jb        short M01_L37
       jmp       near ptr M01_L12
M01_L39:
       call      qword ptr [7FFD57D7F8E8]
       int       3
M01_L40:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [rax+30]
M01_L41:
       mov       rcx,[rbx+18]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L42
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L42
       jmp       short M01_L43
M01_L42:
       mov       rcx,rbx
       mov       rdx,7FFD57E1BDE8
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M01_L43:
       mov       rdx,rsi
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FFD57D7F870]
M01_L44:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1335
```
```assembly
; System.Random+ThreadSafeRandom.Create()
       push      rbx
       sub       rsp,20
       call      qword ptr [7FFD7EE5F760]
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD7EE69738]
       call      qword ptr [7FFD7EE56EA8]
       lea       rcx,[rax+10]
       mov       rdx,rbx
       call      qword ptr [7FFD7EE54FE8]; CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 51
```
```assembly
; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]](System.Collections.Immutable.ImmutableArray`1<System.__Canon> ByRef)
       ret
; Total bytes of code 1
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FFD7EE6DCF8]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       ecx,ebx
       and       ecx,0FFFFFF
       mov       edx,ecx
       mov       r8d,ebx
       sar       r8d,18
       jne       short M04_L01
       cmp       [rax],ecx
       jle       short M04_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M04_L03
M04_L00:
       add       rsp,20
       pop       rbx
       ret
M04_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M04_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M04_L00
M04_L02:
       cmp       [rax+4],edx
       jle       short M04_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M04_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M04_L03
       jmp       short M04_L00
M04_L03:
       mov       ecx,ebx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax]
; Total bytes of code 130
```

## .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.Shuffle()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Linq.Enumerable+ShuffleIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rsi+10],eax
       lea       rcx,[rsi+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rsi+18]
       mov       rcx,7FFD5799EA40
       call      qword ptr [7FFD578EC6A8]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rsi,rax
       test      rsi,rsi
       je        near ptr M00_L06
       lea       rdi,[rsi+10]
       mov       ebp,[rsi+8]
       mov       r14d,ebp
       xor       r15d,r15d
M00_L00:
       lea       ecx,[rbp-1]
       cmp       r15d,ecx
       jge       near ptr M00_L05
       cmp       r15d,ebp
       jg        near ptr M00_L11
       mov       rcx,gs:[58]
       mov       rcx,[rcx+38]
       cmp       dword ptr [rcx+238],8
       jle       near ptr M00_L07
       mov       rcx,[rcx+240]
       mov       rax,[rcx+40]
       test      rax,rax
       je        near ptr M00_L07
M00_L01:
       mov       rcx,[rax+10]
       test      rcx,rcx
       jne       short M00_L02
       call      qword ptr [7FFD57BD43C0]; System.Random+ThreadSafeRandom.Create()
       mov       rcx,rax
M00_L02:
       mov       r8d,ebp
       sub       r8d,r15d
       mov       rax,[rcx+8]
       mov       rdx,[rcx+10]
       mov       r10,[rcx+18]
       mov       r9,[rcx+20]
       mov       r11,rdx
       shl       r11,11
       xor       r10,rax
       xor       r9,rdx
       lea       r13,[rdx+rdx*4]
       rol       r13,7
       lea       r13,[r13+r13*8]
       xor       rdx,r10
       xor       rax,r9
       xor       r10,r11
       rol       r9,2D
       mov       [rcx+8],rax
       mov       [rcx+10],rdx
       mov       [rcx+18],r10
       mov       [rcx+20],r9
       mov       r10d,r8d
       shr       r13,20
       mov       r9d,r13d
       imul      r10,r9
       mov       r9d,r10d
       cmp       r9d,r8d
       jb        near ptr M00_L08
M00_L03:
       shr       r10,20
       add       r10d,r15d
       cmp       r10d,r15d
       je        short M00_L04
       mov       r13,[rdi+r15*8]
       lea       rcx,[rdi+r15*8]
       cmp       r10d,r14d
       jae       near ptr M00_L12
       mov       r12d,r10d
       mov       rdx,[rdi+r12*8]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rdi+r12*8]
       mov       rdx,r13
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M00_L04:
       inc       r15d
       jmp       near ptr M00_L00
M00_L05:
       mov       [rsp+20],rsi
       mov       rdx,[rbx+60]
       cmp       [rdx],dl
       lea       rdx,[rsp+20]
       mov       rcx,7FFD57E19DE8
       call      qword ptr [7FFD57DCE0E8]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]](System.Collections.Immutable.ImmutableArray`1<System.__Canon> ByRef)
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
M00_L06:
       mov       ecx,0BD3
       mov       rdx,7FFD574D4000
       call      qword ptr [7FFD5759F228]
       mov       rcx,rax
       call      qword ptr [7FFD57C85500]
       int       3
M00_L07:
       mov       ecx,8
       call      qword ptr [7FFD57C857B8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L01
M00_L08:
       mov       eax,r8d
       neg       eax
       xor       edx,edx
       div       r8d
       jmp       short M00_L10
M00_L09:
       mov       r10,[rcx+8]
       mov       r9,[rcx+10]
       mov       rax,[rcx+18]
       mov       r11,[rcx+20]
       mov       r13,r9
       shl       r13,11
       xor       rax,r10
       xor       r11,r9
       lea       r12,[r9+r9*4]
       rol       r12,7
       lea       r12,[r12+r12*8]
       xor       r9,rax
       xor       r10,r11
       xor       rax,r13
       rol       r11,2D
       mov       [rcx+8],r10
       mov       [rcx+10],r9
       mov       [rcx+18],rax
       mov       [rcx+20],r11
       mov       r10d,r8d
       shr       r12,20
       mov       eax,r12d
       imul      r10,rax
       mov       r9d,r10d
M00_L10:
       cmp       r9d,edx
       jb        short M00_L09
       jmp       near ptr M00_L03
M00_L11:
       call      qword ptr [7FFD57DCFC48]
       int       3
M00_L12:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 614
```
```assembly
; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       mov       rsi,rdx
       mov       rcx,[rbx+18]
       cmp       qword ptr [rcx+8],40
       jle       near ptr M01_L04
       mov       rcx,[rcx+40]
       test      rcx,rcx
       je        near ptr M01_L04
M01_L00:
       mov       rdx,rsi
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M01_L14
       mov       rdx,offset MT_System.Linq.Enumerable+ShuffleIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],rdx
       jne       near ptr M01_L40
       mov       rbx,[rax+18]
       mov       rdx,rbx
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M01_L05
       mov       rcx,offset MT_System.Linq.Enumerable+ShuffleIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],rcx
       jne       near ptr M01_L31
       mov       rcx,rax
       call      qword ptr [7FFD57E193A8]; System.Linq.Enumerable+ShuffleIterator`1[[System.__Canon, System.Private.CoreLib]].ToArray()
M01_L01:
       mov       rsi,rax
M01_L02:
       test      rsi,rsi
       je        near ptr M01_L34
       lea       rbx,[rsi+10]
       mov       edi,[rsi+8]
       mov       ebp,edi
       xor       r14d,r14d
M01_L03:
       lea       ecx,[rdi-1]
       cmp       r14d,ecx
       jl        near ptr M01_L09
       mov       rax,rsi
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L04:
       mov       rcx,rbx
       mov       rdx,7FFD57ED0710
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L00
M01_L05:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rsi,rax
       test      rsi,rsi
       je        near ptr M01_L33
       mov       rcx,rsi
       mov       r11,7FFD574E10B8
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L07
       test      byte ptr [7FFD57E467A0],1
       je        near ptr M01_L32
M01_L06:
       mov       rdx,1C66EC00B00
       mov       rsi,[rdx]
       jmp       short M01_L08
M01_L07:
       movsxd    rdx,eax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbx,rax
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r11,7FFD574E10C0
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rsi,rbx
M01_L08:
       jmp       near ptr M01_L02
M01_L09:
       cmp       r14d,edi
       jg        near ptr M01_L39
       mov       rcx,gs:[58]
       mov       rcx,[rcx+38]
       cmp       dword ptr [rcx+238],8
       jle       near ptr M01_L35
       mov       rcx,[rcx+240]
       mov       rax,[rcx+40]
       test      rax,rax
       je        near ptr M01_L35
M01_L10:
       mov       rcx,[rax+10]
       test      rcx,rcx
       jne       short M01_L11
       call      qword ptr [7FFD57BD43C0]; System.Random+ThreadSafeRandom.Create()
       mov       rcx,rax
M01_L11:
       mov       r8d,edi
       sub       r8d,r14d
       mov       rax,[rcx+8]
       mov       rdx,[rcx+10]
       mov       r10,[rcx+18]
       mov       r9,[rcx+20]
       mov       r11,rdx
       shl       r11,11
       xor       r10,rax
       xor       r9,rdx
       lea       r15,[rdx+rdx*4]
       rol       r15,7
       lea       r15,[r15+r15*8]
       xor       rdx,r10
       xor       rax,r9
       xor       r10,r11
       rol       r9,2D
       mov       [rcx+8],rax
       mov       [rcx+10],rdx
       mov       [rcx+18],r10
       mov       [rcx+20],r9
       mov       r10d,r8d
       shr       r15,20
       mov       r9d,r15d
       imul      r10,r9
       mov       r9d,r10d
       cmp       r9d,r8d
       jb        near ptr M01_L36
M01_L12:
       shr       r10,20
       add       r10d,r14d
       cmp       r10d,r14d
       je        short M01_L13
       mov       r15,[rbx+r14*8]
       lea       rcx,[rbx+r14*8]
       cmp       r10d,ebp
       jae       near ptr M01_L44
       mov       r13d,r10d
       mov       rdx,[rbx+r13*8]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rbx+r13*8]
       mov       rdx,r15
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M01_L13:
       inc       r14d
       jmp       near ptr M01_L03
M01_L14:
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       je        near ptr M01_L21
M01_L15:
       mov       rdx,rsi
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M01_L41
       mov       rcx,[rbx+18]
       cmp       qword ptr [rcx+8],38
       jle       near ptr M01_L22
       mov       rsi,[rcx+38]
       test      rsi,rsi
       je        near ptr M01_L22
M01_L16:
       mov       rcx,[rsi+18]
       mov       r11,[rcx+28]
       test      r11,r11
       je        near ptr M01_L23
M01_L17:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       je        near ptr M01_L24
       mov       rcx,[rsi+18]
       cmp       qword ptr [rcx+8],38
       jle       near ptr M01_L29
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        near ptr M01_L29
M01_L18:
       movsxd    rdx,ebx
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbx,rax
       mov       rcx,[rsi+18]
       cmp       qword ptr [rcx+8],40
       jle       near ptr M01_L30
       mov       r11,[rcx+40]
       test      r11,r11
       je        near ptr M01_L30
M01_L19:
       mov       rcx,rdi
       mov       rdx,rbx
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rax,rbx
M01_L20:
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L21:
       mov       rcx,rbx
       mov       rdx,7FFD57ED05A8
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L15
M01_L22:
       mov       rcx,rbx
       mov       rdx,7FFD57ED06F0
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M01_L16
M01_L23:
       mov       rcx,rsi
       mov       rdx,7FFD57ED0720
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M01_L17
M01_L24:
       mov       rcx,[rsi+18]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L27
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L27
M01_L25:
       mov       rdx,[rcx+18]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M01_L28
M01_L26:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rax]
       jmp       near ptr M01_L20
M01_L27:
       mov       rcx,rsi
       mov       rdx,7FFD57ED07C0
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M01_L25
M01_L28:
       mov       rdx,7FFD57CA8198
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       short M01_L26
M01_L29:
       mov       rcx,rsi
       mov       rdx,7FFD57ED07E0
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L18
M01_L30:
       mov       rcx,rsi
       mov       rdx,7FFD57ED07E8
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M01_L19
M01_L31:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       jmp       near ptr M01_L01
M01_L32:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M01_L06
M01_L33:
       mov       rdx,rbx
       mov       rcx,7FFD57E46640
       call      qword ptr [7FFD57DCFBD0]
       mov       rsi,rax
       jmp       near ptr M01_L02
M01_L34:
       mov       ecx,0BD3
       mov       rdx,7FFD574D4000
       call      qword ptr [7FFD5759F228]
       mov       rcx,rax
       call      qword ptr [7FFD57C85500]
       int       3
M01_L35:
       mov       ecx,8
       call      qword ptr [7FFD57C857B8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M01_L10
M01_L36:
       mov       eax,r8d
       neg       eax
       xor       edx,edx
       div       r8d
       jmp       short M01_L38
M01_L37:
       mov       r10,[rcx+8]
       mov       r9,[rcx+10]
       mov       rax,[rcx+18]
       mov       r11,[rcx+20]
       mov       r15,r9
       shl       r15,11
       xor       rax,r10
       xor       r11,r9
       lea       r13,[r9+r9*4]
       rol       r13,7
       lea       r13,[r13+r13*8]
       xor       r9,rax
       xor       r10,r11
       xor       rax,r15
       rol       r11,2D
       mov       [rcx+8],r10
       mov       [rcx+10],r9
       mov       [rcx+18],rax
       mov       [rcx+20],r11
       mov       r10d,r8d
       shr       r13,20
       mov       eax,r13d
       imul      r10,rax
       mov       r9d,r10d
M01_L38:
       cmp       r9d,edx
       jb        short M01_L37
       jmp       near ptr M01_L12
M01_L39:
       call      qword ptr [7FFD57DCFC48]
       int       3
M01_L40:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [rax+30]
M01_L41:
       mov       rcx,[rbx+18]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L42
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L42
       jmp       short M01_L43
M01_L42:
       mov       rcx,rbx
       mov       rdx,7FFD57ED06B8
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M01_L43:
       mov       rdx,rsi
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FFD57DCFBD0]
M01_L44:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1335
```
```assembly
; System.Random+ThreadSafeRandom.Create()
       push      rbx
       sub       rsp,20
       call      qword ptr [7FFD7EE5F760]
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD7EE69738]
       call      qword ptr [7FFD7EE56EA8]
       lea       rcx,[rax+10]
       mov       rdx,rbx
       call      qword ptr [7FFD7EE54FE8]; CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 51
```
```assembly
; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]](System.Collections.Immutable.ImmutableArray`1<System.__Canon> ByRef)
       ret
; Total bytes of code 1
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FFD7EE6DCF8]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       ecx,ebx
       and       ecx,0FFFFFF
       mov       edx,ecx
       mov       r8d,ebx
       sar       r8d,18
       jne       short M04_L01
       cmp       [rax],ecx
       jle       short M04_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M04_L03
M04_L00:
       add       rsp,20
       pop       rbx
       ret
M04_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M04_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M04_L00
M04_L02:
       cmp       [rax+4],edx
       jle       short M04_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M04_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M04_L03
       jmp       short M04_L00
M04_L03:
       mov       ecx,ebx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax]
; Total bytes of code 130
```

## .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.IsNotEmpty()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rdx,[rbx+278]
       mov       rcx,7FFD57D6F260
       call      qword ptr [7FFD57D75680]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.IsNotEmpty[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
       mov       rcx,[rbx+60]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 44
```
```assembly
; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.IsNotEmpty[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
; 			return collection.ArgumentNotNull().IsEmpty ? false : collection.Length > 0;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       eax,[rdx+8]
       test      eax,eax
       setne     al
       movzx     eax,al
       ret
; Total bytes of code 12
```

## .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.IsNotEmpty()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rdx,[rbx+278]
       mov       rcx,7FFD57D3EF68
       call      qword ptr [7FFD57D55140]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.IsNotEmpty[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
       mov       rcx,[rbx+60]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 44
```
```assembly
; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.IsNotEmpty[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
; 			return collection.ArgumentNotNull().IsEmpty ? false : collection.Length > 0;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       eax,[rdx+8]
       test      eax,eax
       setne     al
       movzx     eax,al
       ret
; Total bytes of code 12
```

## .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.IsNotEmpty()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rdx,[rbx+278]
       mov       rcx,7FFD57D6E6E8
       call      qword ptr [7FFD57D75518]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.IsNotEmpty[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
       mov       rcx,[rbx+60]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 44
```
```assembly
; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.IsNotEmpty[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
; 			return collection.ArgumentNotNull().IsEmpty ? false : collection.Length > 0;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       eax,[rdx+8]
       test      eax,eax
       setne     al
       movzx     eax,al
       ret
; Total bytes of code 12
```

## .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.IsNotEmpty()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rdx,[rbx+278]
       mov       rcx,7FFD57D5EF58
       call      qword ptr [7FFD57D65560]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.IsNotEmpty[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
       mov       rcx,[rbx+60]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 44
```
```assembly
; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.IsNotEmpty[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
; 			return collection.ArgumentNotNull().IsEmpty ? false : collection.Length > 0;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       eax,[rdx+8]
       test      eax,eax
       setne     al
       movzx     eax,al
       ret
; Total bytes of code 12
```

## .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.IsNotEmpty()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rdx,[rbx+278]
       mov       rcx,7FFD57D8EF58
       call      qword ptr [7FFD57D955A8]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.IsNotEmpty[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
       mov       rcx,[rbx+60]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 44
```
```assembly
; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.IsNotEmpty[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
; 			return collection.ArgumentNotNull().IsEmpty ? false : collection.Length > 0;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       eax,[rdx+8]
       test      eax,eax
       setne     al
       movzx     eax,al
       ret
; Total bytes of code 12
```

## .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.IsNotEmpty()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rdx,[rbx+278]
       mov       rcx,7FFD57D4EF58
       call      qword ptr [7FFD57D65128]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.IsNotEmpty[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
       mov       rcx,[rbx+60]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 44
```
```assembly
; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.IsNotEmpty[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
; 			return collection.ArgumentNotNull().IsEmpty ? false : collection.Length > 0;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       eax,[rdx+8]
       test      eax,eax
       setne     al
       movzx     eax,al
       ret
; Total bytes of code 12
```

## .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.IsNotEmpty()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rdx,[rbx+278]
       mov       rcx,7FFD57D6EF58
       call      qword ptr [7FFD57D462F8]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.IsNotEmpty[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
       mov       rcx,[rbx+60]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 44
```
```assembly
; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.IsNotEmpty[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
; 			return collection.ArgumentNotNull().IsEmpty ? false : collection.Length > 0;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       eax,[rdx+8]
       test      eax,eax
       setne     al
       movzx     eax,al
       ret
; Total bytes of code 12
```

## .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.IsNotEmpty()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rdx,[rbx+278]
       mov       rcx,7FFD57DF6228
       call      qword ptr [7FFD57DADBF0]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.IsNotEmpty[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
       mov       rcx,[rbx+60]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 44
```
```assembly
; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.IsNotEmpty[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
; 			return collection.ArgumentNotNull().IsEmpty ? false : collection.Length > 0;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       eax,[rdx+8]
       test      eax,eax
       setne     al
       movzx     eax,al
       ret
; Total bytes of code 12
```

