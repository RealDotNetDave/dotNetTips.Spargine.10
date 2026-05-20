## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rcx,7FFC68A3EA40
       call      qword ptr [7FFC689DC648]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FFC68C842B8]; System.Random+ThreadSafeRandom.Create()
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
       mov       rcx,7FFC68E43160
       call      qword ptr [7FFC68E359F8]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]](System.Collections.Immutable.ImmutableArray`1<System.__Canon> ByRef)
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
       mov       rdx,7FFC68584000
       call      qword ptr [7FFC688677B0]
       mov       rcx,rax
       call      qword ptr [7FFC68E3C498]
       int       3
M00_L07:
       mov       ecx,8
       call      qword ptr [7FFC68E3C6C0]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
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
       call      qword ptr [7FFC68E3E4F0]
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
       call      qword ptr [7FFC68E42720]; System.Linq.Enumerable+ShuffleIterator`1[[System.__Canon, System.Private.CoreLib]].ToArray()
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
       mov       rdx,7FFC68EA5C60
       call      qword ptr [7FFC68867B70]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L00
M01_L05:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFC687BF618]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rsi,rax
       test      rsi,rsi
       je        near ptr M01_L33
       mov       rcx,rsi
       mov       r11,7FFC68590DB0
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L07
       test      byte ptr [7FFC68EBD098],1
       je        near ptr M01_L32
M01_L06:
       mov       rdx,19EE6800A98
       mov       rsi,[rdx]
       jmp       short M01_L08
M01_L07:
       movsxd    rdx,eax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbx,rax
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r11,7FFC68590DB8
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
       call      qword ptr [7FFC68C842B8]; System.Random+ThreadSafeRandom.Create()
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
       call      qword ptr [7FFC687BF618]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
       mov       rdx,7FFC68EA5AF8
       call      qword ptr [7FFC68867B70]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L15
M01_L22:
       mov       rcx,rbx
       mov       rdx,7FFC68EA5C40
       call      qword ptr [7FFC68867B70]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M01_L16
M01_L23:
       mov       rcx,rsi
       mov       rdx,7FFC68EA5C88
       call      qword ptr [7FFC68867B70]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       call      qword ptr [7FFC68645728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rax]
       jmp       near ptr M01_L20
M01_L27:
       mov       rcx,rsi
       mov       rdx,7FFC68EA5D28
       call      qword ptr [7FFC68867B70]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M01_L25
M01_L28:
       mov       rdx,7FFC68EA5D68
       call      qword ptr [7FFC68867B70]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       short M01_L26
M01_L29:
       mov       rcx,rsi
       mov       rdx,7FFC68EA5D48
       call      qword ptr [7FFC68867B70]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L18
M01_L30:
       mov       rcx,rsi
       mov       rdx,7FFC68EA5D50
       call      qword ptr [7FFC68867B70]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       call      qword ptr [7FFC68645728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M01_L06
M01_L33:
       mov       rdx,rbx
       mov       rcx,7FFC68EBCF38
       call      qword ptr [7FFC68E3E448]
       mov       rsi,rax
       jmp       near ptr M01_L02
M01_L34:
       mov       ecx,0BD3
       mov       rdx,7FFC68584000
       call      qword ptr [7FFC688677B0]
       mov       rcx,rax
       call      qword ptr [7FFC68E3C498]
       int       3
M01_L35:
       mov       ecx,8
       call      qword ptr [7FFC68E3C6C0]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
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
       call      qword ptr [7FFC68E3E4F0]
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
       mov       rdx,7FFC68EA5C08
       call      qword ptr [7FFC68867B70]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       jmp       qword ptr [7FFC68E3E448]
M01_L44:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1348
```
```assembly
; System.Random+ThreadSafeRandom.Create()
       push      rbx
       sub       rsp,20
       call      qword ptr [7FFCC808E760]
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCC8098738]
       call      qword ptr [7FFCC8085EA8]
       lea       rcx,[rax+10]
       mov       rdx,rbx
       call      qword ptr [7FFCC8083FE8]; CORINFO_HELP_ASSIGN_REF
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
       call      qword ptr [7FFCC809CCF8]; Precode of System.Threading.Thread.GetThreadStaticsBase()
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

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rcx,7FFC68A0EA40
       call      qword ptr [7FFC689AC648]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FFC68C54330]; System.Random+ThreadSafeRandom.Create()
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
       mov       rcx,7FFC68E13960
       call      qword ptr [7FFC68E05A58]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]](System.Collections.Immutable.ImmutableArray`1<System.__Canon> ByRef)
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
       mov       rdx,7FFC68554000
       call      qword ptr [7FFC688377B0]
       mov       rcx,rax
       call      qword ptr [7FFC68E0C420]
       int       3
M00_L07:
       mov       ecx,8
       call      qword ptr [7FFC68E0C648]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
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
       call      qword ptr [7FFC68E0E4F0]
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
       jle       near ptr M01_L13
       mov       rcx,[rcx+40]
       test      rcx,rcx
       je        near ptr M01_L13
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
       je        short M01_L03
       mov       rcx,offset MT_System.Linq.Enumerable+ShuffleIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],rcx
       jne       near ptr M01_L31
       mov       rcx,rax
       call      qword ptr [7FFC68E12F20]; System.Linq.Enumerable+ShuffleIterator`1[[System.__Canon, System.Private.CoreLib]].ToArray()
M01_L01:
       mov       rsi,rax
M01_L02:
       test      rsi,rsi
       je        near ptr M01_L34
       lea       rbx,[rsi+10]
       mov       edi,[rsi+8]
       mov       ebp,edi
       xor       r14d,r14d
       jmp       near ptr M01_L12
M01_L03:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFC6878F618]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rsi,rax
       test      rsi,rsi
       je        near ptr M01_L33
       mov       rcx,rsi
       mov       r11,7FFC68560DB0
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L05
       test      byte ptr [7FFC68E8AFE8],1
       je        near ptr M01_L32
M01_L04:
       mov       rdx,22F29C00A98
       mov       rsi,[rdx]
       jmp       short M01_L06
M01_L05:
       movsxd    rdx,eax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbx,rax
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r11,7FFC68560DB8
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rsi,rbx
M01_L06:
       jmp       near ptr M01_L02
M01_L07:
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
M01_L08:
       mov       rcx,[rax+10]
       test      rcx,rcx
       jne       short M01_L09
       call      qword ptr [7FFC68C54330]; System.Random+ThreadSafeRandom.Create()
       mov       rcx,rax
M01_L09:
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
M01_L10:
       shr       r10,20
       add       r10d,r14d
       cmp       r10d,r14d
       je        short M01_L11
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
M01_L11:
       inc       r14d
M01_L12:
       lea       ecx,[rdi-1]
       cmp       r14d,ecx
       jl        near ptr M01_L07
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
M01_L13:
       mov       rcx,rbx
       mov       rdx,7FFC68E75AA8
       call      qword ptr [7FFC68837B70]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L00
M01_L14:
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       je        near ptr M01_L21
M01_L15:
       mov       rdx,rsi
       call      qword ptr [7FFC6878F618]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
       mov       rdx,7FFC68E75940
       call      qword ptr [7FFC68837B70]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L15
M01_L22:
       mov       rcx,rbx
       mov       rdx,7FFC68E75A88
       call      qword ptr [7FFC68837B70]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M01_L16
M01_L23:
       mov       rcx,rsi
       mov       rdx,7FFC68E75AD0
       call      qword ptr [7FFC68837B70]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       call      qword ptr [7FFC68615728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rax]
       jmp       near ptr M01_L20
M01_L27:
       mov       rcx,rsi
       mov       rdx,7FFC68E75B70
       call      qword ptr [7FFC68837B70]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M01_L25
M01_L28:
       mov       rdx,7FFC68E75BB0
       call      qword ptr [7FFC68837B70]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       short M01_L26
M01_L29:
       mov       rcx,rsi
       mov       rdx,7FFC68E75B90
       call      qword ptr [7FFC68837B70]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L18
M01_L30:
       mov       rcx,rsi
       mov       rdx,7FFC68E75B98
       call      qword ptr [7FFC68837B70]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       call      qword ptr [7FFC68615728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M01_L04
M01_L33:
       mov       rdx,rbx
       mov       rcx,7FFC68E8AE88
       call      qword ptr [7FFC68E0E460]
       mov       rsi,rax
       jmp       near ptr M01_L02
M01_L34:
       mov       ecx,0BD3
       mov       rdx,7FFC68554000
       call      qword ptr [7FFC688377B0]
       mov       rcx,rax
       call      qword ptr [7FFC68E0C420]
       int       3
M01_L35:
       mov       ecx,8
       call      qword ptr [7FFC68E0C648]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M01_L08
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
       jmp       near ptr M01_L10
M01_L39:
       call      qword ptr [7FFC68E0E4F0]
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
       mov       rdx,7FFC68E75A50
       call      qword ptr [7FFC68837B70]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       jmp       qword ptr [7FFC68E0E460]
M01_L44:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1348
```
```assembly
; System.Random+ThreadSafeRandom.Create()
       push      rbx
       sub       rsp,20
       call      qword ptr [7FFCC808E760]
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCC8098738]
       call      qword ptr [7FFCC8085EA8]
       lea       rcx,[rax+10]
       mov       rdx,rbx
       call      qword ptr [7FFCC8083FE8]; CORINFO_HELP_ASSIGN_REF
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
       call      qword ptr [7FFCC809CCF8]; Precode of System.Threading.Thread.GetThreadStaticsBase()
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

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rcx,7FFC68A1EA40
       call      qword ptr [7FFC689BC648]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FFC68C64390]; System.Random+ThreadSafeRandom.Create()
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
       mov       rcx,7FFC68E23960
       call      qword ptr [7FFC68E15AD0]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]](System.Collections.Immutable.ImmutableArray`1<System.__Canon> ByRef)
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
       mov       rdx,7FFC68564000
       call      qword ptr [7FFC688477B0]
       mov       rcx,rax
       call      qword ptr [7FFC68E1C990]
       int       3
M00_L07:
       mov       ecx,8
       call      qword ptr [7FFC68E1CBB8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
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
       call      qword ptr [7FFC68E1E9B8]
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
       call      qword ptr [7FFC68E22F20]; System.Linq.Enumerable+ShuffleIterator`1[[System.__Canon, System.Private.CoreLib]].ToArray()
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
       mov       rdx,7FFC68E874C0
       call      qword ptr [7FFC68847B70]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L00
M01_L05:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFC6879F618]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rsi,rax
       test      rsi,rsi
       je        near ptr M01_L33
       mov       rcx,rsi
       mov       r11,7FFC68570DB0
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L07
       test      byte ptr [7FFC68EA4C40],1
       je        near ptr M01_L32
M01_L06:
       mov       rdx,188F8800A98
       mov       rsi,[rdx]
       jmp       short M01_L08
M01_L07:
       movsxd    rdx,eax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbx,rax
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r11,7FFC68570DB8
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
       call      qword ptr [7FFC68C64390]; System.Random+ThreadSafeRandom.Create()
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
       call      qword ptr [7FFC6879F618]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
       mov       rdx,7FFC68E87358
       call      qword ptr [7FFC68847B70]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L15
M01_L22:
       mov       rcx,rbx
       mov       rdx,7FFC68E874A0
       call      qword ptr [7FFC68847B70]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M01_L16
M01_L23:
       mov       rcx,rsi
       mov       rdx,7FFC68E874E8
       call      qword ptr [7FFC68847B70]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       call      qword ptr [7FFC68625728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rax]
       jmp       near ptr M01_L20
M01_L27:
       mov       rcx,rsi
       mov       rdx,7FFC68E87588
       call      qword ptr [7FFC68847B70]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M01_L25
M01_L28:
       mov       rdx,7FFC68E875C8
       call      qword ptr [7FFC68847B70]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       short M01_L26
M01_L29:
       mov       rcx,rsi
       mov       rdx,7FFC68E875A8
       call      qword ptr [7FFC68847B70]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L18
M01_L30:
       mov       rcx,rsi
       mov       rdx,7FFC68E875B0
       call      qword ptr [7FFC68847B70]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       call      qword ptr [7FFC68625728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M01_L06
M01_L33:
       mov       rdx,rbx
       mov       rcx,7FFC68EA4AE0
       call      qword ptr [7FFC68E1E8F8]
       mov       rsi,rax
       jmp       near ptr M01_L02
M01_L34:
       mov       ecx,0BD3
       mov       rdx,7FFC68564000
       call      qword ptr [7FFC688477B0]
       mov       rcx,rax
       call      qword ptr [7FFC68E1C990]
       int       3
M01_L35:
       mov       ecx,8
       call      qword ptr [7FFC68E1CBB8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
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
       call      qword ptr [7FFC68E1E9B8]
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
       mov       rdx,7FFC68E87468
       call      qword ptr [7FFC68847B70]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       jmp       qword ptr [7FFC68E1E8F8]
M01_L44:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1348
```
```assembly
; System.Random+ThreadSafeRandom.Create()
       push      rbx
       sub       rsp,20
       call      qword ptr [7FFCC808E760]
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCC8098738]
       call      qword ptr [7FFCC8085EA8]
       lea       rcx,[rax+10]
       mov       rdx,rbx
       call      qword ptr [7FFCC8083FE8]; CORINFO_HELP_ASSIGN_REF
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
       call      qword ptr [7FFCC809CCF8]; Precode of System.Threading.Thread.GetThreadStaticsBase()
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

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rcx,7FFC68A1EA40
       call      qword ptr [7FFC689BC648]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FFC68BCC618]; System.Random+ThreadSafeRandom.Create()
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
       mov       r12d,r8d
       shr       r13,20
       mov       r13d,r13d
       imul      r13,r12
       mov       r10d,r13d
       cmp       r10d,r8d
       jb        near ptr M00_L08
M00_L03:
       shr       r13,20
       add       r13d,r15d
       cmp       r13d,r15d
       je        short M00_L04
       mov       r12,[rdi+r15*8]
       lea       rcx,[rdi+r15*8]
       cmp       r13d,r14d
       jae       near ptr M00_L12
       mov       edx,r13d
       mov       rdx,[rdi+rdx*8]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       ecx,r13d
       lea       rcx,[rdi+rcx*8]
       mov       rdx,r12
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M00_L04:
       inc       r15d
       jmp       near ptr M00_L00
M00_L05:
       mov       [rsp+20],rsi
       mov       rdx,[rbx+60]
       cmp       [rdx],dl
       lea       rdx,[rsp+20]
       mov       rcx,7FFC68DBEF20
       call      qword ptr [7FFC68CEDD70]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]](System.Collections.Immutable.ImmutableArray`1<System.__Canon> ByRef)
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
       mov       rdx,7FFC68564000
       call      qword ptr [7FFC688477B0]
       mov       rcx,rax
       call      qword ptr [7FFC68DF74E0]
       int       3
M00_L07:
       mov       ecx,8
       call      qword ptr [7FFC68DF6EF8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L01
M00_L08:
       mov       eax,r8d
       neg       eax
       xor       edx,edx
       div       r8d
       jmp       short M00_L10
M00_L09:
       mov       r10,[rcx+8]
       mov       rax,[rcx+10]
       mov       r9,[rcx+18]
       mov       r11,[rcx+20]
       mov       r13,rax
       shl       r13,11
       xor       r9,r10
       xor       r11,rax
       lea       r12,[rax+rax*4]
       rol       r12,7
       lea       r12,[r12+r12*8]
       xor       rax,r9
       xor       r10,r11
       xor       r9,r13
       rol       r11,2D
       mov       [rcx+8],r10
       mov       [rcx+10],rax
       mov       [rcx+18],r9
       mov       [rcx+20],r11
       mov       r13d,r8d
       shr       r12,20
       mov       eax,r12d
       imul      r13,rax
       mov       r10d,r13d
M00_L10:
       cmp       r10d,edx
       jb        short M00_L09
       jmp       near ptr M00_L03
M00_L11:
       call      qword ptr [7FFC68DF6EE0]
       int       3
M00_L12:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 617
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
       call      qword ptr [7FFC68626850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M01_L11
       mov       rdx,offset MT_System.Linq.Enumerable+ShuffleIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],rdx
       jne       near ptr M01_L24
       mov       rbx,[rax+18]
       mov       rdx,rbx
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFC68626850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M01_L05
       mov       rcx,offset MT_System.Linq.Enumerable+ShuffleIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],rcx
       jne       near ptr M01_L16
       mov       rcx,rax
       call      qword ptr [7FFC68DBE4E0]; System.Linq.Enumerable+ShuffleIterator`1[[System.__Canon, System.Private.CoreLib]].ToArray()
M01_L01:
       mov       rsi,rax
M01_L02:
       test      rsi,rsi
       je        near ptr M01_L18
       lea       rbx,[rsi+10]
       mov       edi,[rsi+8]
       mov       ebp,edi
       xor       r14d,r14d
M01_L03:
       lea       ecx,[rdi-1]
       cmp       r14d,ecx
       jl        short M01_L06
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
       mov       rdx,7FFC68DACD18
       call      qword ptr [7FFC68847B70]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L00
M01_L05:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFC6879F618]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        near ptr M01_L17
       mov       rdx,rax
       mov       rcx,7FFC68CDD938
       call      qword ptr [7FFC689BDA28]; System.Linq.Enumerable.ICollectionToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>)
       mov       rsi,rax
       jmp       short M01_L02
M01_L06:
       cmp       r14d,edi
       jg        near ptr M01_L23
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+238],8
       jle       near ptr M01_L19
       mov       rcx,[rcx+240]
       mov       rax,[rcx+40]
       test      rax,rax
       je        near ptr M01_L19
M01_L07:
       mov       rcx,[rax+10]
       test      rcx,rcx
       jne       short M01_L08
       call      qword ptr [7FFC68BCC618]; System.Random+ThreadSafeRandom.Create()
       mov       rcx,rax
M01_L08:
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
       mov       r13d,r8d
       shr       r15,20
       mov       r15d,r15d
       imul      r15,r13
       mov       r10d,r15d
       cmp       r10d,r8d
       jb        near ptr M01_L20
M01_L09:
       shr       r15,20
       add       r15d,r14d
       cmp       r15d,r14d
       je        short M01_L10
       mov       r13,[rbx+r14*8]
       lea       rcx,[rbx+r14*8]
       cmp       r15d,ebp
       jae       near ptr M01_L28
       mov       edx,r15d
       mov       rdx,[rbx+rdx*8]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       ecx,r15d
       lea       rcx,[rbx+rcx*8]
       mov       rdx,r13
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M01_L10:
       inc       r14d
       jmp       near ptr M01_L03
M01_L11:
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       je        short M01_L14
M01_L12:
       mov       rdx,rsi
       call      qword ptr [7FFC6879F618]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M01_L25
       mov       rcx,[rbx+18]
       cmp       qword ptr [rcx+8],38
       jle       short M01_L15
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M01_L15
M01_L13:
       mov       rdx,rdi
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FFC689BDA28]; System.Linq.Enumerable.ICollectionToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>)
M01_L14:
       mov       rcx,rbx
       mov       rdx,7FFC68DACBB0
       call      qword ptr [7FFC68847B70]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M01_L12
M01_L15:
       mov       rcx,rbx
       mov       rdx,7FFC68DACCF8
       call      qword ptr [7FFC68847B70]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M01_L13
M01_L16:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       jmp       near ptr M01_L01
M01_L17:
       mov       rdx,rbx
       mov       rcx,7FFC68DC7D98
       call      qword ptr [7FFC68DF6FB8]
       mov       rsi,rax
       jmp       near ptr M01_L02
M01_L18:
       mov       ecx,0BD3
       mov       rdx,7FFC68564000
       call      qword ptr [7FFC688477B0]
       mov       rcx,rax
       call      qword ptr [7FFC68DF74E0]
       int       3
M01_L19:
       mov       ecx,8
       call      qword ptr [7FFC68DF6EF8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M01_L07
M01_L20:
       mov       eax,r8d
       neg       eax
       xor       edx,edx
       div       r8d
       jmp       short M01_L22
M01_L21:
       mov       r10,[rcx+8]
       mov       rax,[rcx+10]
       mov       r9,[rcx+18]
       mov       r11,[rcx+20]
       mov       r15,rax
       shl       r15,11
       xor       r9,r10
       xor       r11,rax
       lea       r13,[rax+rax*4]
       rol       r13,7
       lea       r13,[r13+r13*8]
       xor       rax,r9
       xor       r10,r11
       xor       r9,r15
       rol       r11,2D
       mov       [rcx+8],r10
       mov       [rcx+10],rax
       mov       [rcx+18],r9
       mov       [rcx+20],r11
       mov       r15d,r8d
       shr       r13,20
       mov       eax,r13d
       imul      r15,rax
       mov       r10d,r15d
M01_L22:
       cmp       r10d,edx
       jb        short M01_L21
       jmp       near ptr M01_L09
M01_L23:
       call      qword ptr [7FFC68DF6EE0]
       int       3
M01_L24:
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
M01_L25:
       mov       rcx,[rbx+18]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L26
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L26
       jmp       short M01_L27
M01_L26:
       mov       rcx,rbx
       mov       rdx,7FFC68DACCC0
       call      qword ptr [7FFC68847B70]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M01_L27:
       mov       rdx,rsi
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FFC68DF6FB8]
M01_L28:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 949
```
```assembly
; System.Random+ThreadSafeRandom.Create()
       push      rbx
       sub       rsp,20
       call      qword ptr [7FFCC808E760]
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCC8098738]
       call      qword ptr [7FFCC8085EA8]
       lea       rcx,[rax+10]
       mov       rdx,rbx
       call      qword ptr [7FFCC8083FE8]; CORINFO_HELP_ASSIGN_REF
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
       call      qword ptr [7FFCC809CCF8]; Precode of System.Threading.Thread.GetThreadStaticsBase()
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

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rcx,7FFC689FEA40
       call      qword ptr [7FFC6899C648]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FFC68BAC618]; System.Random+ThreadSafeRandom.Create()
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
       mov       r12d,r8d
       shr       r13,20
       mov       r13d,r13d
       imul      r13,r12
       mov       r10d,r13d
       cmp       r10d,r8d
       jb        near ptr M00_L08
M00_L03:
       shr       r13,20
       add       r13d,r15d
       cmp       r13d,r15d
       je        short M00_L04
       mov       r12,[rdi+r15*8]
       lea       rcx,[rdi+r15*8]
       cmp       r13d,r14d
       jae       near ptr M00_L12
       mov       edx,r13d
       mov       rdx,[rdi+rdx*8]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       ecx,r13d
       lea       rcx,[rdi+rcx*8]
       mov       rdx,r12
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M00_L04:
       inc       r15d
       jmp       near ptr M00_L00
M00_L05:
       mov       [rsp+20],rsi
       mov       rdx,[rbx+60]
       cmp       [rdx],dl
       lea       rdx,[rsp+20]
       mov       rcx,7FFC68D9EF20
       call      qword ptr [7FFC68CCDD70]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]](System.Collections.Immutable.ImmutableArray`1<System.__Canon> ByRef)
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
       mov       rdx,7FFC68544000
       call      qword ptr [7FFC688277B0]
       mov       rcx,rax
       call      qword ptr [7FFC68DD6DF0]
       int       3
M00_L07:
       mov       ecx,8
       call      qword ptr [7FFC68DD6F70]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L01
M00_L08:
       mov       eax,r8d
       neg       eax
       xor       edx,edx
       div       r8d
       jmp       short M00_L10
M00_L09:
       mov       r10,[rcx+8]
       mov       rax,[rcx+10]
       mov       r9,[rcx+18]
       mov       r11,[rcx+20]
       mov       r13,rax
       shl       r13,11
       xor       r9,r10
       xor       r11,rax
       lea       r12,[rax+rax*4]
       rol       r12,7
       lea       r12,[r12+r12*8]
       xor       rax,r9
       xor       r10,r11
       xor       r9,r13
       rol       r11,2D
       mov       [rcx+8],r10
       mov       [rcx+10],rax
       mov       [rcx+18],r9
       mov       [rcx+20],r11
       mov       r13d,r8d
       shr       r12,20
       mov       eax,r12d
       imul      r13,rax
       mov       r10d,r13d
M00_L10:
       cmp       r10d,edx
       jb        short M00_L09
       jmp       near ptr M00_L03
M00_L11:
       call      qword ptr [7FFC68DD6F58]
       int       3
M00_L12:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 617
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
       call      qword ptr [7FFC68606850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M01_L11
       mov       rdx,offset MT_System.Linq.Enumerable+ShuffleIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],rdx
       jne       near ptr M01_L24
       mov       rbx,[rax+18]
       mov       rdx,rbx
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFC68606850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M01_L05
       mov       rcx,offset MT_System.Linq.Enumerable+ShuffleIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],rcx
       jne       near ptr M01_L16
       mov       rcx,rax
       call      qword ptr [7FFC68D9E4E0]; System.Linq.Enumerable+ShuffleIterator`1[[System.__Canon, System.Private.CoreLib]].ToArray()
M01_L01:
       mov       rsi,rax
M01_L02:
       test      rsi,rsi
       je        near ptr M01_L18
       lea       rbx,[rsi+10]
       mov       edi,[rsi+8]
       mov       ebp,edi
       xor       r14d,r14d
M01_L03:
       lea       ecx,[rdi-1]
       cmp       r14d,ecx
       jl        short M01_L06
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
       mov       rdx,7FFC68D8D000
       call      qword ptr [7FFC68827B70]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L00
M01_L05:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFC6877F618]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        near ptr M01_L17
       mov       rdx,rax
       mov       rcx,7FFC68CBD918
       call      qword ptr [7FFC6899DA28]; System.Linq.Enumerable.ICollectionToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>)
       mov       rsi,rax
       jmp       short M01_L02
M01_L06:
       cmp       r14d,edi
       jg        near ptr M01_L23
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+238],8
       jle       near ptr M01_L19
       mov       rcx,[rcx+240]
       mov       rax,[rcx+40]
       test      rax,rax
       je        near ptr M01_L19
M01_L07:
       mov       rcx,[rax+10]
       test      rcx,rcx
       jne       short M01_L08
       call      qword ptr [7FFC68BAC618]; System.Random+ThreadSafeRandom.Create()
       mov       rcx,rax
M01_L08:
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
       mov       r13d,r8d
       shr       r15,20
       mov       r15d,r15d
       imul      r15,r13
       mov       r10d,r15d
       cmp       r10d,r8d
       jb        near ptr M01_L20
M01_L09:
       shr       r15,20
       add       r15d,r14d
       cmp       r15d,r14d
       je        short M01_L10
       mov       r13,[rbx+r14*8]
       lea       rcx,[rbx+r14*8]
       cmp       r15d,ebp
       jae       near ptr M01_L28
       mov       edx,r15d
       mov       rdx,[rbx+rdx*8]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       ecx,r15d
       lea       rcx,[rbx+rcx*8]
       mov       rdx,r13
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M01_L10:
       inc       r14d
       jmp       near ptr M01_L03
M01_L11:
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       je        short M01_L14
M01_L12:
       mov       rdx,rsi
       call      qword ptr [7FFC6877F618]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M01_L25
       mov       rcx,[rbx+18]
       cmp       qword ptr [rcx+8],38
       jle       short M01_L15
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M01_L15
M01_L13:
       mov       rdx,rdi
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FFC6899DA28]; System.Linq.Enumerable.ICollectionToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>)
M01_L14:
       mov       rcx,rbx
       mov       rdx,7FFC68D8CE98
       call      qword ptr [7FFC68827B70]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M01_L12
M01_L15:
       mov       rcx,rbx
       mov       rdx,7FFC68D8CFE0
       call      qword ptr [7FFC68827B70]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M01_L13
M01_L16:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       jmp       near ptr M01_L01
M01_L17:
       mov       rdx,rbx
       mov       rcx,7FFC68DA5278
       call      qword ptr [7FFC68DD7030]
       mov       rsi,rax
       jmp       near ptr M01_L02
M01_L18:
       mov       ecx,0BD3
       mov       rdx,7FFC68544000
       call      qword ptr [7FFC688277B0]
       mov       rcx,rax
       call      qword ptr [7FFC68DD6DF0]
       int       3
M01_L19:
       mov       ecx,8
       call      qword ptr [7FFC68DD6F70]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M01_L07
M01_L20:
       mov       eax,r8d
       neg       eax
       xor       edx,edx
       div       r8d
       jmp       short M01_L22
M01_L21:
       mov       r10,[rcx+8]
       mov       rax,[rcx+10]
       mov       r9,[rcx+18]
       mov       r11,[rcx+20]
       mov       r15,rax
       shl       r15,11
       xor       r9,r10
       xor       r11,rax
       lea       r13,[rax+rax*4]
       rol       r13,7
       lea       r13,[r13+r13*8]
       xor       rax,r9
       xor       r10,r11
       xor       r9,r15
       rol       r11,2D
       mov       [rcx+8],r10
       mov       [rcx+10],rax
       mov       [rcx+18],r9
       mov       [rcx+20],r11
       mov       r15d,r8d
       shr       r13,20
       mov       eax,r13d
       imul      r15,rax
       mov       r10d,r15d
M01_L22:
       cmp       r10d,edx
       jb        short M01_L21
       jmp       near ptr M01_L09
M01_L23:
       call      qword ptr [7FFC68DD6F58]
       int       3
M01_L24:
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
M01_L25:
       mov       rcx,[rbx+18]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L26
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L26
       jmp       short M01_L27
M01_L26:
       mov       rcx,rbx
       mov       rdx,7FFC68D8CFA8
       call      qword ptr [7FFC68827B70]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M01_L27:
       mov       rdx,rsi
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FFC68DD7030]
M01_L28:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 949
```
```assembly
; System.Random+ThreadSafeRandom.Create()
       push      rbx
       sub       rsp,20
       call      qword ptr [7FFCC808E760]
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCC8098738]
       call      qword ptr [7FFCC8085EA8]
       lea       rcx,[rax+10]
       mov       rdx,rbx
       call      qword ptr [7FFCC8083FE8]; CORINFO_HELP_ASSIGN_REF
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
       call      qword ptr [7FFCC809CCF8]; Precode of System.Threading.Thread.GetThreadStaticsBase()
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

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rcx,7FFC689FEA40
       call      qword ptr [7FFC6899C648]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FFC68BAFA98]; System.Random+ThreadSafeRandom.Create()
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
       mov       rcx,7FFC68DE15E8
       call      qword ptr [7FFC68DC52A8]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]](System.Collections.Immutable.ImmutableArray`1<System.__Canon> ByRef)
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
       mov       rdx,7FFC68544000
       call      qword ptr [7FFC688277B0]
       mov       rcx,rax
       call      qword ptr [7FFC68DCC3D8]
       int       3
M00_L07:
       mov       ecx,8
       call      qword ptr [7FFC68DCC5E8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
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
       call      qword ptr [7FFC68DCE448]
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
       call      qword ptr [7FFC68DE0BA8]; System.Linq.Enumerable+ShuffleIterator`1[[System.__Canon, System.Private.CoreLib]].ToArray()
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
       mov       rdx,7FFC68E56CC8
       call      qword ptr [7FFC68827B70]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       r11,7FFC68550DA0
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L07
       test      byte ptr [7FFC68E6AE98],1
       je        near ptr M01_L32
M01_L06:
       mov       rdx,25D63000A98
       mov       rsi,[rdx]
       jmp       short M01_L08
M01_L07:
       movsxd    rdx,eax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbx,rax
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r11,7FFC68550DA8
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
       call      qword ptr [7FFC68BAFA98]; System.Random+ThreadSafeRandom.Create()
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
       mov       rdx,7FFC68E56B60
       call      qword ptr [7FFC68827B70]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L15
M01_L22:
       mov       rcx,rbx
       mov       rdx,7FFC68E56CA8
       call      qword ptr [7FFC68827B70]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M01_L16
M01_L23:
       mov       rcx,rsi
       mov       rdx,7FFC68E56CF0
       call      qword ptr [7FFC68827B70]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       call      qword ptr [7FFC68605728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rax]
       jmp       near ptr M01_L20
M01_L27:
       mov       rcx,rsi
       mov       rdx,7FFC68E56D90
       call      qword ptr [7FFC68827B70]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M01_L25
M01_L28:
       mov       rdx,7FFC68E56DD0
       call      qword ptr [7FFC68827B70]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       short M01_L26
M01_L29:
       mov       rcx,rsi
       mov       rdx,7FFC68E56DB0
       call      qword ptr [7FFC68827B70]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L18
M01_L30:
       mov       rcx,rsi
       mov       rdx,7FFC68E56DB8
       call      qword ptr [7FFC68827B70]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       call      qword ptr [7FFC68605728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M01_L06
M01_L33:
       mov       rdx,rbx
       mov       rcx,7FFC68E6AD38
       call      qword ptr [7FFC68DCE478]
       mov       rsi,rax
       jmp       near ptr M01_L02
M01_L34:
       mov       ecx,0BD3
       mov       rdx,7FFC68544000
       call      qword ptr [7FFC688277B0]
       mov       rcx,rax
       call      qword ptr [7FFC68DCC3D8]
       int       3
M01_L35:
       mov       ecx,8
       call      qword ptr [7FFC68DCC5E8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
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
       call      qword ptr [7FFC68DCE448]
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
       mov       rdx,7FFC68E56C70
       call      qword ptr [7FFC68827B70]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       jmp       qword ptr [7FFC68DCE478]
M01_L44:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1346
```
```assembly
; System.Random+ThreadSafeRandom.Create()
       push      rbx
       sub       rsp,20
       call      qword ptr [7FFCC808E760]
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCC8098738]
       call      qword ptr [7FFCC8085EA8]
       lea       rcx,[rax+10]
       mov       rdx,rbx
       call      qword ptr [7FFCC8083FE8]; CORINFO_HELP_ASSIGN_REF
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
       call      qword ptr [7FFCC809CCF8]; Precode of System.Threading.Thread.GetThreadStaticsBase()
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

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rcx,7FFC689FEA40
       call      qword ptr [7FFC6899C648]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FFC68BAC630]; System.Random+ThreadSafeRandom.Create()
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
       mov       r12d,r8d
       shr       r13,20
       mov       r13d,r13d
       imul      r13,r12
       mov       r10d,r13d
       cmp       r10d,r8d
       jb        near ptr M00_L08
M00_L03:
       shr       r13,20
       add       r13d,r15d
       cmp       r13d,r15d
       je        short M00_L04
       mov       r12,[rdi+r15*8]
       lea       rcx,[rdi+r15*8]
       cmp       r13d,r14d
       jae       near ptr M00_L12
       mov       edx,r13d
       mov       rdx,[rdi+rdx*8]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       ecx,r13d
       lea       rcx,[rdi+rcx*8]
       mov       rdx,r12
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M00_L04:
       inc       r15d
       jmp       near ptr M00_L00
M00_L05:
       mov       [rsp+20],rsi
       mov       rdx,[rbx+60]
       cmp       [rdx],dl
       lea       rdx,[rsp+20]
       mov       rcx,7FFC68D8F258
       call      qword ptr [7FFC68CCDD88]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]](System.Collections.Immutable.ImmutableArray`1<System.__Canon> ByRef)
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
       mov       rdx,7FFC68544000
       call      qword ptr [7FFC688277B0]
       mov       rcx,rax
       call      qword ptr [7FFC68DD6670]
       int       3
M00_L07:
       mov       ecx,8
       call      qword ptr [7FFC68DD6F88]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L01
M00_L08:
       mov       eax,r8d
       neg       eax
       xor       edx,edx
       div       r8d
       jmp       short M00_L10
M00_L09:
       mov       r10,[rcx+8]
       mov       rax,[rcx+10]
       mov       r9,[rcx+18]
       mov       r11,[rcx+20]
       mov       r13,rax
       shl       r13,11
       xor       r9,r10
       xor       r11,rax
       lea       r12,[rax+rax*4]
       rol       r12,7
       lea       r12,[r12+r12*8]
       xor       rax,r9
       xor       r10,r11
       xor       r9,r13
       rol       r11,2D
       mov       [rcx+8],r10
       mov       [rcx+10],rax
       mov       [rcx+18],r9
       mov       [rcx+20],r11
       mov       r13d,r8d
       shr       r12,20
       mov       eax,r12d
       imul      r13,rax
       mov       r10d,r13d
M00_L10:
       cmp       r10d,edx
       jb        short M00_L09
       jmp       near ptr M00_L03
M00_L11:
       call      qword ptr [7FFC68DD6F70]
       int       3
M00_L12:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 617
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
       call      qword ptr [7FFC68606850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M01_L14
       mov       rdx,offset MT_System.Linq.Enumerable+ShuffleIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],rdx
       jne       near ptr M01_L28
       mov       rbx,[rax+18]
       mov       rdx,rbx
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFC68606850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M01_L05
       mov       rcx,offset MT_System.Linq.Enumerable+ShuffleIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],rcx
       jne       near ptr M01_L19
       mov       rcx,rax
       call      qword ptr [7FFC68D8E818]; System.Linq.Enumerable+ShuffleIterator`1[[System.__Canon, System.Private.CoreLib]].ToArray()
M01_L01:
       mov       rsi,rax
M01_L02:
       test      rsi,rsi
       je        near ptr M01_L22
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
       mov       rdx,7FFC68D9B5B8
       call      qword ptr [7FFC68827B70]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L00
M01_L05:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFC6877F618]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rsi,rax
       test      rsi,rsi
       je        near ptr M01_L21
       mov       rcx,rsi
       mov       r11,7FFC68550B20
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L07
       test      byte ptr [7FFC68DA80C8],1
       je        near ptr M01_L20
M01_L06:
       mov       rdx,138A4C00A20
       mov       rsi,[rdx]
       jmp       short M01_L08
M01_L07:
       movsxd    rdx,eax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbx,rax
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r11,7FFC68550B28
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rsi,rbx
M01_L08:
       jmp       near ptr M01_L02
M01_L09:
       cmp       r14d,edi
       jg        near ptr M01_L27
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+238],8
       jle       near ptr M01_L23
       mov       rcx,[rcx+240]
       mov       rax,[rcx+40]
       test      rax,rax
       je        near ptr M01_L23
M01_L10:
       mov       rcx,[rax+10]
       test      rcx,rcx
       jne       short M01_L11
       call      qword ptr [7FFC68BAC630]; System.Random+ThreadSafeRandom.Create()
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
       jb        near ptr M01_L24
M01_L12:
       shr       r10,20
       add       r10d,r14d
       cmp       r10d,r14d
       je        short M01_L13
       mov       r15,[rbx+r14*8]
       lea       rcx,[rbx+r14*8]
       cmp       r10d,ebp
       jae       near ptr M01_L32
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
       je        short M01_L17
M01_L15:
       mov       rdx,rsi
       call      qword ptr [7FFC6877F618]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M01_L29
       mov       rcx,[rbx+18]
       cmp       qword ptr [rcx+8],38
       jle       short M01_L18
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M01_L18
M01_L16:
       mov       rdx,rdi
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FFC6899DA28]; System.Linq.Enumerable.ICollectionToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>)
M01_L17:
       mov       rcx,rbx
       mov       rdx,7FFC68D9B450
       call      qword ptr [7FFC68827B70]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M01_L15
M01_L18:
       mov       rcx,rbx
       mov       rdx,7FFC68D9B598
       call      qword ptr [7FFC68827B70]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M01_L16
M01_L19:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       jmp       near ptr M01_L01
M01_L20:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFC68605728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M01_L06
M01_L21:
       mov       rdx,rbx
       mov       rcx,7FFC68DA7F68
       call      qword ptr [7FFC68DD7048]
       mov       rsi,rax
       jmp       near ptr M01_L02
M01_L22:
       mov       ecx,0BD3
       mov       rdx,7FFC68544000
       call      qword ptr [7FFC688277B0]
       mov       rcx,rax
       call      qword ptr [7FFC68DD6670]
       int       3
M01_L23:
       mov       ecx,8
       call      qword ptr [7FFC68DD6F88]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M01_L10
M01_L24:
       mov       eax,r8d
       neg       eax
       xor       edx,edx
       div       r8d
       jmp       short M01_L26
M01_L25:
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
M01_L26:
       cmp       r9d,edx
       jb        short M01_L25
       jmp       near ptr M01_L12
M01_L27:
       call      qword ptr [7FFC68DD6F70]
       int       3
M01_L28:
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
M01_L29:
       mov       rcx,[rbx+18]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L30
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L30
       jmp       short M01_L31
M01_L30:
       mov       rcx,rbx
       mov       rdx,7FFC68D9B560
       call      qword ptr [7FFC68827B70]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M01_L31:
       mov       rdx,rsi
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FFC68DD7048]
M01_L32:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1049
```
```assembly
; System.Random+ThreadSafeRandom.Create()
       push      rbx
       sub       rsp,20
       call      qword ptr [7FFCC808E760]
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCC8098738]
       call      qword ptr [7FFCC8085EA8]
       lea       rcx,[rax+10]
       mov       rdx,rbx
       call      qword ptr [7FFCC8083FE8]; CORINFO_HELP_ASSIGN_REF
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
       call      qword ptr [7FFCC809CCF8]; Precode of System.Threading.Thread.GetThreadStaticsBase()
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

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rcx,7FFC68A0EA40
       call      qword ptr [7FFC689AC648]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FFC68BBC618]; System.Random+ThreadSafeRandom.Create()
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
       mov       r12d,r8d
       shr       r13,20
       mov       r13d,r13d
       imul      r13,r12
       mov       r10d,r13d
       cmp       r10d,r8d
       jb        near ptr M00_L08
M00_L03:
       shr       r13,20
       add       r13d,r15d
       cmp       r13d,r15d
       je        short M00_L04
       mov       r12,[rdi+r15*8]
       lea       rcx,[rdi+r15*8]
       cmp       r13d,r14d
       jae       near ptr M00_L12
       mov       edx,r13d
       mov       rdx,[rdi+rdx*8]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       ecx,r13d
       lea       rcx,[rdi+rcx*8]
       mov       rdx,r12
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M00_L04:
       inc       r15d
       jmp       near ptr M00_L00
M00_L05:
       mov       [rsp+20],rsi
       mov       rdx,[rbx+60]
       cmp       [rdx],dl
       lea       rdx,[rsp+20]
       mov       rcx,7FFC68E7F258
       call      qword ptr [7FFC68E3D668]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]](System.Collections.Immutable.ImmutableArray`1<System.__Canon> ByRef)
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
       mov       rdx,7FFC68554000
       call      qword ptr [7FFC688377B0]
       mov       rcx,rax
       call      qword ptr [7FFC68CE59F8]
       int       3
M00_L07:
       mov       ecx,8
       call      qword ptr [7FFC68CE41B0]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L01
M00_L08:
       mov       eax,r8d
       neg       eax
       xor       edx,edx
       div       r8d
       jmp       short M00_L10
M00_L09:
       mov       r10,[rcx+8]
       mov       rax,[rcx+10]
       mov       r9,[rcx+18]
       mov       r11,[rcx+20]
       mov       r13,rax
       shl       r13,11
       xor       r9,r10
       xor       r11,rax
       lea       r12,[rax+rax*4]
       rol       r12,7
       lea       r12,[r12+r12*8]
       xor       rax,r9
       xor       r10,r11
       xor       r9,r13
       rol       r11,2D
       mov       [rcx+8],r10
       mov       [rcx+10],rax
       mov       [rcx+18],r9
       mov       [rcx+20],r11
       mov       r13d,r8d
       shr       r12,20
       mov       eax,r12d
       imul      r13,rax
       mov       r10d,r13d
M00_L10:
       cmp       r10d,edx
       jb        short M00_L09
       jmp       near ptr M00_L03
M00_L11:
       call      qword ptr [7FFC68E3F138]
       int       3
M00_L12:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 617
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
       jne       near ptr M01_L28
       mov       rbx,[rax+18]
       mov       rdx,rbx
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M01_L05
       mov       rcx,offset MT_System.Linq.Enumerable+ShuffleIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],rcx
       jne       near ptr M01_L19
       mov       rcx,rax
       call      qword ptr [7FFC68E7E818]; System.Linq.Enumerable+ShuffleIterator`1[[System.__Canon, System.Private.CoreLib]].ToArray()
M01_L01:
       mov       rsi,rax
M01_L02:
       test      rsi,rsi
       je        near ptr M01_L22
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
       mov       rdx,7FFC68F311C0
       call      qword ptr [7FFC68837B70]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L00
M01_L05:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rsi,rax
       test      rsi,rsi
       je        near ptr M01_L21
       mov       rcx,rsi
       mov       r11,7FFC685611D8
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L07
       test      byte ptr [7FFC68EAB618],1
       je        near ptr M01_L20
M01_L06:
       mov       rdx,21D9E000AD0
       mov       rsi,[rdx]
       jmp       short M01_L08
M01_L07:
       movsxd    rdx,eax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbx,rax
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r11,7FFC685611E0
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rsi,rbx
M01_L08:
       jmp       near ptr M01_L02
M01_L09:
       cmp       r14d,edi
       jg        near ptr M01_L27
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],8
       jle       near ptr M01_L23
       mov       rcx,[rcx+240]
       mov       rax,[rcx+40]
       test      rax,rax
       je        near ptr M01_L23
M01_L10:
       mov       rcx,[rax+10]
       test      rcx,rcx
       jne       short M01_L11
       call      qword ptr [7FFC68BBC618]; System.Random+ThreadSafeRandom.Create()
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
       mov       r13d,r8d
       shr       r15,20
       mov       r15d,r15d
       imul      r15,r13
       mov       r10d,r15d
       cmp       r10d,r8d
       jb        near ptr M01_L24
M01_L12:
       shr       r15,20
       add       r15d,r14d
       cmp       r15d,r14d
       je        short M01_L13
       mov       r13,[rbx+r14*8]
       lea       rcx,[rbx+r14*8]
       cmp       r15d,ebp
       jae       near ptr M01_L32
       mov       edx,r15d
       mov       rdx,[rbx+rdx*8]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       ecx,r15d
       lea       rcx,[rbx+rcx*8]
       mov       rdx,r13
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M01_L13:
       inc       r14d
       jmp       near ptr M01_L03
M01_L14:
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       je        short M01_L17
M01_L15:
       mov       rdx,rsi
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M01_L29
       mov       rcx,[rbx+18]
       cmp       qword ptr [rcx+8],38
       jle       short M01_L18
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M01_L18
M01_L16:
       mov       rdx,rdi
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FFC689ADA28]; System.Linq.Enumerable.ICollectionToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>)
M01_L17:
       mov       rcx,rbx
       mov       rdx,7FFC68F31058
       call      qword ptr [7FFC68837B70]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M01_L15
M01_L18:
       mov       rcx,rbx
       mov       rdx,7FFC68F311A0
       call      qword ptr [7FFC68837B70]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M01_L16
M01_L19:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       jmp       near ptr M01_L01
M01_L20:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M01_L06
M01_L21:
       mov       rdx,rbx
       mov       rcx,7FFC68EAB4B8
       call      qword ptr [7FFC68E3F168]
       mov       rsi,rax
       jmp       near ptr M01_L02
M01_L22:
       mov       ecx,0BD3
       mov       rdx,7FFC68554000
       call      qword ptr [7FFC688377B0]
       mov       rcx,rax
       call      qword ptr [7FFC68CE59F8]
       int       3
M01_L23:
       mov       ecx,8
       call      qword ptr [7FFC68CE41B0]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M01_L10
M01_L24:
       mov       eax,r8d
       neg       eax
       xor       edx,edx
       div       r8d
       jmp       short M01_L26
M01_L25:
       mov       r10,[rcx+8]
       mov       rax,[rcx+10]
       mov       r9,[rcx+18]
       mov       r11,[rcx+20]
       mov       r15,rax
       shl       r15,11
       xor       r9,r10
       xor       r11,rax
       lea       r13,[rax+rax*4]
       rol       r13,7
       lea       r13,[r13+r13*8]
       xor       rax,r9
       xor       r10,r11
       xor       r9,r15
       rol       r11,2D
       mov       [rcx+8],r10
       mov       [rcx+10],rax
       mov       [rcx+18],r9
       mov       [rcx+20],r11
       mov       r15d,r8d
       shr       r13,20
       mov       eax,r13d
       imul      r15,rax
       mov       r10d,r15d
M01_L26:
       cmp       r10d,edx
       jb        short M01_L25
       jmp       near ptr M01_L12
M01_L27:
       call      qword ptr [7FFC68E3F138]
       int       3
M01_L28:
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
M01_L29:
       mov       rcx,[rbx+18]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L30
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L30
       jmp       short M01_L31
M01_L30:
       mov       rcx,rbx
       mov       rdx,7FFC68F31168
       call      qword ptr [7FFC68837B70]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M01_L31:
       mov       rdx,rsi
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FFC68E3F168]
M01_L32:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1047
```
```assembly
; System.Random+ThreadSafeRandom.Create()
       push      rbx
       sub       rsp,20
       call      qword ptr [7FFCC808E760]
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCC8098738]
       call      qword ptr [7FFCC8085EA8]
       lea       rcx,[rax+10]
       mov       rdx,rbx
       call      qword ptr [7FFCC8083FE8]; CORINFO_HELP_ASSIGN_REF
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
       call      qword ptr [7FFCC809CCF8]; Precode of System.Threading.Thread.GetThreadStaticsBase()
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

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.IsNotEmpty()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rdx,[rbx+278]
       mov       rcx,7FFC68DCABC0
       call      qword ptr [7FFC68CFD770]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.IsNotEmpty[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
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

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.IsNotEmpty()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rdx,[rbx+278]
       mov       rcx,7FFC68DBD1E0
       call      qword ptr [7FFC68DC4DF8]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.IsNotEmpty[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
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

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.IsNotEmpty()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rdx,[rbx+278]
       mov       rcx,7FFC68DBB180
       call      qword ptr [7FFC68CED878]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.IsNotEmpty[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
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

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.IsNotEmpty()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rdx,[rbx+278]
       mov       rcx,7FFC68DCB180
       call      qword ptr [7FFC68CFD878]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.IsNotEmpty[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
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

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.IsNotEmpty()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rdx,[rbx+278]
       mov       rcx,7FFC68DCAB40
       call      qword ptr [7FFC68CFD7A0]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.IsNotEmpty[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
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

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.IsNotEmpty()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rdx,[rbx+278]
       mov       rcx,7FFC68DBAB40
       call      qword ptr [7FFC68CED7A0]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.IsNotEmpty[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
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

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.IsNotEmpty()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rdx,[rbx+278]
       mov       rcx,7FFC68E33CC0
       call      qword ptr [7FFC68E07180]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.IsNotEmpty[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
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

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.IsNotEmpty()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rdx,[rbx+278]
       mov       rcx,7FFC68E6AE88
       call      qword ptr [7FFC68E2D0C8]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.IsNotEmpty[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
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

