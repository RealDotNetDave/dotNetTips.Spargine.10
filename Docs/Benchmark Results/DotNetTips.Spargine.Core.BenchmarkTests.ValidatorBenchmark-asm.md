## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.ValidatorBenchmark.EnsureInRangeDouble()
       mov       rax,[rcx+90]
       mov       rcx,4049400000000000
       mov       [rax+10],rcx
       ret
; Total bytes of code 22
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.ValidatorBenchmark.EnsureInRangeInt()
       mov       rax,[rcx+90]
       mov       dword ptr [rax+38],32
       ret
; Total bytes of code 15
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.ValidatorBenchmark.EnsureInRangeLong()
       mov       rax,[rcx+90]
       mov       qword ptr [rax+18],32
       ret
; Total bytes of code 16
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.ValidatorBenchmark.CheckItemsExists_NoValidation_ForComparison()
       push      rbx
       sub       rsp,10
       mov       rdx,[rcx+1A8]
       mov       [rsp+8],rdx
       mov       rbx,[rcx+90]
       mov       rdx,[rsp+8]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,10
       pop       rbx
       ret
; Total bytes of code 50
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.ValidatorBenchmark.CheckItemsExists_Validation_Inlining()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rsi,[rbx+1A8]
       test      rsi,rsi
       je        short M00_L00
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFD22AEF618]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M00_L02
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],rcx
       jne       short M00_L01
M00_L00:
       mov       [rsp+20],rsi
       mov       rbx,[rbx+90]
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
       mov       rcx,rax
       mov       r11,7FFD228C08D8
       call      qword ptr [r11]
       jmp       short M00_L00
M00_L02:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFD22976850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M00_L03
       mov       rcx,rax
       mov       edx,1
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax]
       test      eax,eax
       jge       short M00_L00
M00_L03:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.ICollection
       call      qword ptr [7FFD22AEF618]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M00_L04
       mov       rcx,rax
       mov       r11,7FFD228C08D0
       call      qword ptr [r11]
       jmp       near ptr M00_L00
M00_L04:
       mov       rdx,rsi
       mov       rcx,7FFD23002CA0
       call      qword ptr [7FFD22F96D30]
       jmp       near ptr M00_L00
; Total bytes of code 238
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rdx,rdx
       je        short M01_L01
       mov       rax,[rdx]
       movzx     r8d,word ptr [rax+0E]
       test      r8,r8
       je        short M01_L05
       mov       r10,[rax+38]
       cmp       r8,4
       jl        short M01_L04
       cmp       [r10],rcx
       je        short M01_L01
M01_L00:
       cmp       [r10+8],rcx
       jne       short M01_L03
M01_L01:
       mov       rax,rdx
       ret
M01_L02:
       cmp       [r10],rcx
       je        short M01_L01
       jmp       short M01_L00
M01_L03:
       cmp       [r10+10],rcx
       je        short M01_L01
       cmp       [r10+18],rcx
       je        short M01_L01
       add       r10,20
       add       r8,0FFFFFFFFFFFFFFFC
       cmp       r8,4
       jge       short M01_L02
       test      r8,r8
       je        short M01_L05
M01_L04:
       cmp       [r10],rcx
       je        short M01_L01
       add       r10,8
       dec       r8
       test      r8,r8
       jg        short M01_L04
M01_L05:
       test      dword ptr [rax],500C0000
       jne       short M01_L06
       xor       edx,edx
       jmp       short M01_L01
M01_L06:
       jmp       qword ptr [7FFD22F16EC8]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
; Total bytes of code 116
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rdx,rdx
       je        short M02_L02
       mov       rax,[rdx]
       cmp       rax,rcx
       je        short M02_L02
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M02_L02
M02_L00:
       test      rax,rax
       je        short M02_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M02_L02
       test      rax,rax
       je        short M02_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M02_L02
       test      rax,rax
       jne       short M02_L03
M02_L01:
       xor       edx,edx
M02_L02:
       mov       rax,rdx
       ret
M02_L03:
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M02_L02
       test      rax,rax
       je        short M02_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M02_L02
       jmp       short M02_L00
; Total bytes of code 86
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.ValidatorBenchmark.CheckItemsExists_Validation()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rsi,[rbx+1A8]
       test      rsi,rsi
       je        short M00_L00
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFD22B0F618]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M00_L02
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],rcx
       jne       short M00_L01
M00_L00:
       mov       [rsp+20],rsi
       mov       rbx,[rbx+90]
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
       mov       rcx,rax
       mov       r11,7FFD228E08D8
       call      qword ptr [r11]
       jmp       short M00_L00
M00_L02:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFD22996850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M00_L03
       mov       rcx,rax
       mov       edx,1
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax]
       test      eax,eax
       jge       short M00_L00
M00_L03:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.ICollection
       call      qword ptr [7FFD22B0F618]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M00_L04
       mov       rcx,rax
       mov       r11,7FFD228E08D0
       call      qword ptr [r11]
       jmp       near ptr M00_L00
M00_L04:
       mov       rdx,rsi
       mov       rcx,7FFD230325C0
       call      qword ptr [7FFD22FB6D48]
       jmp       near ptr M00_L00
; Total bytes of code 238
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rdx,rdx
       je        short M01_L01
       mov       rax,[rdx]
       movzx     r8d,word ptr [rax+0E]
       test      r8,r8
       je        short M01_L05
       mov       r10,[rax+38]
       cmp       r8,4
       jl        short M01_L04
       cmp       [r10],rcx
       je        short M01_L01
M01_L00:
       cmp       [r10+8],rcx
       jne       short M01_L03
M01_L01:
       mov       rax,rdx
       ret
M01_L02:
       cmp       [r10],rcx
       je        short M01_L01
       jmp       short M01_L00
M01_L03:
       cmp       [r10+10],rcx
       je        short M01_L01
       cmp       [r10+18],rcx
       je        short M01_L01
       add       r10,20
       add       r8,0FFFFFFFFFFFFFFFC
       cmp       r8,4
       jge       short M01_L02
       test      r8,r8
       je        short M01_L05
M01_L04:
       cmp       [r10],rcx
       je        short M01_L01
       add       r10,8
       dec       r8
       test      r8,r8
       jg        short M01_L04
M01_L05:
       test      dword ptr [rax],500C0000
       jne       short M01_L06
       xor       edx,edx
       jmp       short M01_L01
M01_L06:
       jmp       qword ptr [7FFD22F36EC8]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
; Total bytes of code 116
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rdx,rdx
       je        short M02_L02
       mov       rax,[rdx]
       cmp       rax,rcx
       je        short M02_L02
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M02_L02
M02_L00:
       test      rax,rax
       je        short M02_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M02_L02
       test      rax,rax
       je        short M02_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M02_L02
       test      rax,rax
       jne       short M02_L03
M02_L01:
       xor       edx,edx
M02_L02:
       mov       rax,rdx
       ret
M02_L03:
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M02_L02
       test      rax,rax
       je        short M02_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M02_L02
       jmp       short M02_L00
; Total bytes of code 86
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.ValidatorBenchmark.ArgumentNotNullOrEmpty_NoValidation_ForComparison()
       push      rbx
       sub       rsp,10
       mov       rdx,1FD5FBE0B70
       mov       [rsp+8],rdx
       mov       rbx,[rcx+90]
       mov       rdx,[rsp+8]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,10
       pop       rbx
       ret
; Total bytes of code 53
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.ValidatorBenchmark.ArgumentNotNullOrEmpty_Validation_Inlining_ForComparison()
       push      rbx
       sub       rsp,10
       xor       eax,eax
       mov       [rsp+8],rax
       mov       rdx,2326DD50B70
       mov       [rsp+8],rdx
       mov       rbx,[rcx+90]
       mov       rdx,[rsp+8]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,10
       pop       rbx
       ret
; Total bytes of code 60
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.ValidatorBenchmark.ArgumentNotNullOrEmpty_Validation_ForComparison()
       push      rbx
       sub       rsp,10
       xor       eax,eax
       mov       [rsp+8],rax
       mov       rdx,31F9DA50B70
       mov       [rsp+8],rdx
       mov       rbx,[rcx+90]
       mov       rdx,[rsp+8]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,10
       pop       rbx
       ret
; Total bytes of code 60
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.ValidatorBenchmark.ArgumentDefined()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Status
       call      CORINFO_HELP_NEWSFAST
       mov       dword ptr [rax+8],2
       mov       rdx,rax
       mov       rcx,2A7CC510B70
       call      qword ptr [7FFD228CA5D0]; System.RuntimeType.IsEnumDefined(System.Object)
       test      eax,eax
       je        short M00_L00
       mov       dword ptr [rsp+20],2
       mov       rcx,[rbx+90]
       cmp       [rcx],cl
       lea       rcx,[rsp+20]
       call      qword ptr [7FFD22FA6CA0]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Core.Status, DotNetTips.Spargine.10.Core]](DotNetTips.Spargine.Core.Status ByRef)
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L00:
       call      qword ptr [7FFD22FA6BC8]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L01
       call      qword ptr [7FFD230340D8]
       mov       rbx,rax
M00_L01:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,2A7CC504EE8
       call      qword ptr [7FFD22DD41F8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 162
```
```assembly
; System.RuntimeType.IsEnumDefined(System.Object)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,rdx
M01_L00:
       test      rsi,rsi
       je        near ptr M01_L22
       mov       rcx,[rbx+18]
       test      cl,2
       jne       near ptr M01_L14
       mov       rcx,[rcx+10]
       mov       rax,offset MT_System.Enum
       cmp       rcx,rax
       sete      cl
       movzx     ecx,cl
M01_L01:
       test      ecx,ecx
       je        near ptr M01_L24
       mov       rcx,rsi
       call      qword ptr [7FFD2298C9A8]; System.Object.GetType()
       mov       rdi,rax
       mov       rcx,[rdi+18]
       test      cl,2
       jne       near ptr M01_L15
       mov       rcx,[rcx+10]
       mov       rdx,offset MT_System.Enum
       cmp       rcx,rdx
       sete      cl
       movzx     ecx,cl
M01_L02:
       test      ecx,ecx
       je        short M01_L05
       cmp       rbx,rdi
       jne       near ptr M01_L23
M01_L03:
       mov       rcx,[rdi+18]
       mov       rax,rcx
       test      al,2
       jne       near ptr M01_L16
       mov       rax,[rax+10]
       mov       rdx,offset MT_System.Enum
       cmp       rax,rdx
       sete      al
       movzx     eax,al
M01_L04:
       test      eax,eax
       je        near ptr M01_L24
       call      00007FFD825D1A90
       mov       rcx,267374009D8
       mov       rbp,[rcx]
       cmp       eax,1A
       jae       near ptr M01_L60
       mov       ecx,eax
       mov       rcx,[rbp+rcx*8+10]
       mov       rdi,rcx
M01_L05:
       mov       rcx,2A7CC500020
       cmp       rdi,rcx
       je        near ptr M01_L25
       mov       rcx,2A7CC503120
       cmp       rdi,rcx
       jne       near ptr M01_L26
M01_L06:
       mov       rcx,[rbx+18]
       call      00007FFD825D1A90
       mov       rcx,267374009D8
       mov       rbp,[rcx]
       cmp       eax,1A
       jae       near ptr M01_L60
       mov       ecx,eax
       mov       rbp,[rbp+rcx*8+10]
       cmp       rbp,rdi
       jne       near ptr M01_L27
       mov       rcx,[rdi+10]
       test      rcx,rcx
       je        near ptr M01_L17
       mov       rax,[rcx]
       test      rax,rax
       je        near ptr M01_L17
M01_L07:
       mov       ebp,[rax+98]
       test      ebp,ebp
       je        near ptr M01_L28
M01_L08:
       add       ebp,0FFFFFFFC
       cmp       ebp,5
       jne       near ptr M01_L48
       mov       rdx,offset MT_System.Int32
       cmp       [rsi],rdx
       je        short M01_L09
       mov       rdx,rsi
       mov       rcx,offset MT_System.Int32
       call      System.Runtime.CompilerServices.CastHelpers.Unbox(System.Runtime.CompilerServices.MethodTable*, System.Object)
M01_L09:
       mov       esi,[rsi+8]
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M01_L18
       mov       rax,[rcx]
       test      rax,rax
       je        short M01_L18
M01_L10:
       mov       rcx,[rax+80]
       test      rcx,rcx
       je        near ptr M01_L20
       mov       rdx,offset MT_System.Enum+EnumInfo<System.UInt32>
       cmp       [rcx],rdx
       jne       short M01_L19
       mov       rax,rcx
M01_L11:
       test      rax,rax
       je        short M01_L21
M01_L12:
       mov       rcx,[rax+8]
       cmp       byte ptr [rax+19],0
       je        near ptr M01_L50
       mov       edx,esi
       mov       ecx,[rcx+8]
       cmp       rcx,rdx
       seta      al
       movzx     eax,al
M01_L13:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L14:
       xor       ecx,ecx
       jmp       near ptr M01_L01
M01_L15:
       xor       ecx,ecx
       jmp       near ptr M01_L02
M01_L16:
       xor       eax,eax
       jmp       near ptr M01_L04
M01_L17:
       mov       rcx,rdi
       call      qword ptr [7FFD22987C30]; System.RuntimeType.InitializeCache()
       jmp       near ptr M01_L07
M01_L18:
       mov       rcx,rbx
       call      qword ptr [7FFD22987C30]; System.RuntimeType.InitializeCache()
       jmp       short M01_L10
M01_L19:
       mov       rdx,offset MT_System.RuntimeType+CompositeCacheEntry
       cmp       [rcx],rdx
       jne       short M01_L20
       mov       rax,[rcx+28]
       jmp       short M01_L11
M01_L20:
       xor       eax,eax
       jmp       short M01_L11
M01_L21:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFD22E5C330]; System.Enum.<GetEnumInfo>g__InitializeEnumInfo|5_0[[System.UInt32, System.Private.CoreLib]](System.RuntimeType, Boolean)
       jmp       short M01_L12
M01_L22:
       mov       ecx,3AD
       mov       rdx,7FFD228C4000
       call      qword ptr [7FFD22BA7798]
       mov       rcx,rax
       call      qword ptr [7FFD22FAF600]
       int       3
M01_L23:
       mov       rcx,rdi
       mov       rdx,rbx
       call      qword ptr [7FFD22FAF000]
       test      eax,eax
       jne       near ptr M01_L03
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       call      qword ptr [7FFD22FAFA20]
       mov       rcx,rax
       mov       rdx,rdi
       mov       r8,rbx
       call      qword ptr [7FFD22FAFA38]
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FFD22E5DF68]
       mov       rcx,rbp
       call      CORINFO_HELP_THROW
       int       3
M01_L24:
       call      qword ptr [7FFD22FAFA08]
       int       3
M01_L25:
       mov       rcx,rbx
       call      qword ptr [7FFD22FA4E40]; System.Enum.GetNamesNoCopy(System.RuntimeType)
       mov       rbx,rax
       mov       rdx,rsi
       mov       rcx,offset MT_System.String
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,7FFD22FDA7F0
       call      qword ptr [7FFD22FA6BE0]
       not       eax
       shr       eax,1F
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L26:
       mov       rcx,2A7CC5053E0
       cmp       rdi,rcx
       je        near ptr M01_L06
       mov       rcx,2A7CC503070
       cmp       rdi,rcx
       je        near ptr M01_L06
       mov       rcx,2A7CC502ED0
       cmp       rdi,rcx
       je        near ptr M01_L06
       mov       rcx,2A7CC5053B8
       cmp       rdi,rcx
       je        near ptr M01_L06
       mov       rcx,2A7CC502E58
       cmp       rdi,rcx
       je        near ptr M01_L06
       mov       rcx,2A7CC505408
       cmp       rdi,rcx
       je        near ptr M01_L06
       mov       rcx,2A7CC502C50
       cmp       rdi,rcx
       je        near ptr M01_L06
       mov       rcx,2A7CC505390
       cmp       rdi,rcx
       je        near ptr M01_L06
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFD22FAFA50]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD22E55878]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L27:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFD22FAFA68]
       mov       rcx,rax
       mov       rdx,rdi
       mov       r8,rbp
       call      qword ptr [7FFD22FAFA38]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD22E5DF68]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L28:
       mov       rbp,rdi
       mov       rcx,rbp
       call      qword ptr [7FFD22AFF2E8]; System.RuntimeType.get_IsActualEnum()
       test      eax,eax
       je        short M01_L29
       mov       rcx,rdi
       call      qword ptr [7FFD228CA588]; Precode of System.RuntimeType.GetEnumUnderlyingType()
       mov       rbp,rax
       test      rbp,rbp
       je        short M01_L29
       mov       rcx,offset MT_System.RuntimeType
       cmp       [rbp],rcx
       je        short M01_L29
       mov       rdx,rax
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M01_L29:
       mov       rcx,2A7CC5053B8
       cmp       rbp,rcx
       jne       short M01_L30
       mov       ebp,5
       jmp       near ptr M01_L45
M01_L30:
       mov       rcx,2A7CC502ED0
       cmp       rbp,rcx
       jne       short M01_L31
       mov       ebp,6
       jmp       near ptr M01_L45
M01_L31:
       mov       rcx,2A7CC5053E0
       cmp       rbp,rcx
       jne       short M01_L32
       mov       ebp,7
       jmp       near ptr M01_L45
M01_L32:
       mov       rcx,2A7CC503070
       cmp       rbp,rcx
       jne       short M01_L33
       mov       ebp,8
       jmp       near ptr M01_L45
M01_L33:
       mov       rcx,2A7CC503120
       cmp       rbp,rcx
       jne       short M01_L34
       mov       ebp,9
       jmp       near ptr M01_L45
M01_L34:
       mov       rcx,2A7CC502E58
       cmp       rbp,rcx
       jne       short M01_L35
       mov       ebp,0A
       jmp       near ptr M01_L45
M01_L35:
       mov       rcx,2A7CC505408
       cmp       rbp,rcx
       jne       short M01_L36
       mov       ebp,0B
       jmp       near ptr M01_L45
M01_L36:
       mov       rcx,2A7CC502C50
       cmp       rbp,rcx
       jne       short M01_L37
       mov       ebp,0C
       jmp       near ptr M01_L45
M01_L37:
       mov       rcx,2A7CC505368
       cmp       rbp,rcx
       jne       short M01_L38
       mov       ebp,3
       jmp       near ptr M01_L45
M01_L38:
       mov       rcx,2A7CC505390
       cmp       rbp,rcx
       jne       short M01_L39
       mov       ebp,4
       jmp       near ptr M01_L45
M01_L39:
       mov       rcx,2A7CC505430
       cmp       rbp,rcx
       jne       short M01_L40
       mov       ebp,0D
       jmp       short M01_L45
M01_L40:
       mov       rcx,2A7CC505458
       cmp       rbp,rcx
       jne       short M01_L41
       mov       ebp,0E
       jmp       short M01_L45
M01_L41:
       mov       rcx,2A7CC5062E0
       cmp       rbp,rcx
       jne       short M01_L42
       mov       ebp,0F
       jmp       short M01_L45
M01_L42:
       mov       rcx,2A7CC502AC8
       cmp       rbp,rcx
       jne       short M01_L43
       mov       ebp,10
       jmp       short M01_L45
M01_L43:
       mov       rcx,2A7CC500020
       cmp       rbp,rcx
       jne       short M01_L44
       mov       ebp,12
       jmp       short M01_L45
M01_L44:
       mov       rcx,2A7CC510BD8
       mov       eax,1
       mov       edx,2
       cmp       rbp,rcx
       cmove     eax,edx
       mov       ebp,eax
M01_L45:
       mov       rcx,[rdi+10]
       test      rcx,rcx
       je        short M01_L46
       mov       rax,[rcx]
       test      rax,rax
       je        short M01_L46
       jmp       short M01_L47
M01_L46:
       mov       rcx,rdi
       call      qword ptr [7FFD22987C30]; System.RuntimeType.InitializeCache()
M01_L47:
       mov       [rax+98],ebp
       jmp       near ptr M01_L08
M01_L48:
       cmp       ebp,0A
       ja        short M01_L49
       mov       edx,ebp
       lea       rcx,[7FFD22A200D0]
       mov       ecx,[rcx+rdx*4]
       lea       rax,[M01_L00]
       add       rcx,rax
       jmp       rcx
M01_L49:
       mov       rdx,2A7CC503048
       cmp       rdi,rdx
       je        near ptr M01_L58
       jmp       near ptr M01_L56
       mov       rdx,rsi
       mov       rcx,offset MT_System.SByte
       call      System.Runtime.CompilerServices.CastHelpers.Unbox(System.Runtime.CompilerServices.MethodTable*, System.Object)
       movzx     edx,byte ptr [rax]
       mov       rcx,rbx
       call      qword ptr [7FFD22FAF690]
       jmp       near ptr M01_L13
       mov       rdx,rsi
       mov       rcx,offset MT_System.Byte
       call      System.Runtime.CompilerServices.CastHelpers.Unbox(System.Runtime.CompilerServices.MethodTable*, System.Object)
       movzx     edx,byte ptr [rax]
       mov       rcx,rbx
       call      qword ptr [7FFD22FAF690]
       jmp       near ptr M01_L13
       mov       rdx,rsi
       mov       rcx,offset MT_System.Int16
       call      System.Runtime.CompilerServices.CastHelpers.Unbox(System.Runtime.CompilerServices.MethodTable*, System.Object)
       movzx     edx,word ptr [rax]
       mov       rcx,rbx
       call      qword ptr [7FFD22FAF678]
       jmp       near ptr M01_L13
       mov       rdx,rsi
       mov       rcx,offset MT_System.UInt16
       call      System.Runtime.CompilerServices.CastHelpers.Unbox(System.Runtime.CompilerServices.MethodTable*, System.Object)
       movzx     edx,word ptr [rax]
       mov       rcx,rbx
       call      qword ptr [7FFD22FAF678]
       jmp       near ptr M01_L13
M01_L50:
       test      rcx,rcx
       jne       short M01_L51
       xor       eax,eax
       xor       r8d,r8d
       jmp       short M01_L52
M01_L51:
       lea       rax,[rcx+10]
       mov       r8d,[rcx+8]
M01_L52:
       cmp       dword ptr [rcx+8],20
       jle       short M01_L53
       mov       rcx,rax
       mov       edx,r8d
       mov       r8d,esi
       call      qword ptr [7FFD22FAF2B8]
       jmp       short M01_L54
M01_L53:
       mov       rcx,rax
       mov       edx,esi
       call      qword ptr [7FFD22FAF5D0]; System.SpanHelpers.NonPackedIndexOfValueType[[System.Int32, System.Private.CoreLib],[System.SpanHelpers+DontNegate`1[[System.Int32, System.Private.CoreLib]], System.Private.CoreLib]](Int32 ByRef, Int32, Int32)
M01_L54:
       not       eax
       shr       eax,1F
       jmp       near ptr M01_L13
       mov       rdx,rsi
       mov       rcx,offset MT_System.UInt32
       call      System.Runtime.CompilerServices.CastHelpers.Unbox(System.Runtime.CompilerServices.MethodTable*, System.Object)
       mov       edx,[rax]
       mov       rcx,rbx
       call      qword ptr [7FFD22FA6C40]; System.Enum.IsDefinedPrimitive[[System.UInt32, System.Private.CoreLib]](System.RuntimeType, UInt32)
       jmp       near ptr M01_L13
       mov       rdx,rsi
       mov       rcx,offset MT_System.Int64
       call      System.Runtime.CompilerServices.CastHelpers.Unbox(System.Runtime.CompilerServices.MethodTable*, System.Object)
       mov       rdx,[rax]
       mov       rcx,rbx
       call      qword ptr [7FFD22FAF660]
       jmp       near ptr M01_L13
       mov       rdx,rsi
       mov       rcx,offset MT_System.UInt64
       call      System.Runtime.CompilerServices.CastHelpers.Unbox(System.Runtime.CompilerServices.MethodTable*, System.Object)
       mov       rdx,[rax]
       mov       rcx,rbx
       call      qword ptr [7FFD22FAF660]
       jmp       near ptr M01_L13
       mov       rdx,rsi
       mov       rcx,offset MT_System.Single
       call      System.Runtime.CompilerServices.CastHelpers.Unbox(System.Runtime.CompilerServices.MethodTable*, System.Object)
       vmovss    xmm1,dword ptr [rax]
       mov       rcx,rbx
       call      qword ptr [7FFD22FAF648]
       jmp       near ptr M01_L13
       mov       rdx,rsi
       mov       rcx,offset MT_System.Double
       call      System.Runtime.CompilerServices.CastHelpers.Unbox(System.Runtime.CompilerServices.MethodTable*, System.Object)
       vmovsd    xmm1,qword ptr [rax]
       mov       rcx,rbx
       call      qword ptr [7FFD22FAF630]
       jmp       near ptr M01_L13
       mov       rcx,offset MT_System.Char
       cmp       [rsi],rcx
       je        short M01_L55
       mov       rdx,rsi
       call      System.Runtime.CompilerServices.CastHelpers.Unbox(System.Runtime.CompilerServices.MethodTable*, System.Object)
M01_L55:
       movzx     edx,word ptr [rsi+8]
       mov       rcx,rbx
       call      qword ptr [7FFD22FAF6A8]
       jmp       near ptr M01_L13
M01_L56:
       mov       rdx,2A7CC505480
       cmp       rdi,rdx
       je        short M01_L57
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFD22FAFA50]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFD22E55878]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M01_L57:
       mov       rdx,rsi
       mov       rcx,offset MT_System.UIntPtr
       call      System.Runtime.CompilerServices.CastHelpers.Unbox(System.Runtime.CompilerServices.MethodTable*, System.Object)
       mov       rdx,[rax]
       mov       rcx,rbx
       call      qword ptr [7FFD22FAF618]
       jmp       short M01_L59
M01_L58:
       mov       rdx,rsi
       mov       rcx,offset MT_System.IntPtr
       call      System.Runtime.CompilerServices.CastHelpers.Unbox(System.Runtime.CompilerServices.MethodTable*, System.Object)
       mov       rdx,[rax]
       mov       rcx,rbx
       call      qword ptr [7FFD22FAF618]
M01_L59:
       jmp       near ptr M01_L13
M01_L60:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 2093
```
```assembly
; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Core.Status, DotNetTips.Spargine.10.Core]](DotNetTips.Spargine.Core.Status ByRef)
       ret
; Total bytes of code 1
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.ValidatorBenchmark.EnsureCountInRange()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+30],ymm4
       mov       [rsp+50],rax
       mov       rbx,rcx
       mov       rsi,[rbx+1A8]
       test      rsi,rsi
       je        near ptr M00_L06
       mov       rdi,rsi
       mov       rdx,rdi
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFD22ADF618]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        near ptr M00_L08
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],rcx
       jne       near ptr M00_L07
       mov       ebp,[rax+10]
M00_L00:
       test      ebp,ebp
       jle       short M00_L01
       mov       [rsp+28],rdi
       mov       rbx,[rbx+90]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       vzeroupper
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L01:
       lea       rcx,[rsp+30]
       mov       edx,27
       mov       r8d,2
       call      qword ptr [7FFD22B84E70]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler..ctor(Int32, Int32)
       mov       ecx,[rsp+40]
       mov       edx,[rsp+50]
       cmp       ecx,edx
       ja        near ptr M00_L15
       mov       rax,[rsp+48]
       mov       r8d,ecx
       lea       rax,[rax+r8*2]
       sub       edx,ecx
       cmp       edx,21
       jb        near ptr M00_L13
       vmovups   ymm0,[7FFD229FEAA0]
       vmovups   [rax],ymm0
       vmovups   ymm0,[7FFD229FEAC0]
       vmovups   [rax+20],ymm0
       mov       word ptr [rax+40],20
       mov       ecx,[rsp+40]
       add       ecx,21
       mov       [rsp+40],ecx
M00_L02:
       lea       rcx,[rsp+30]
       mov       edx,1
       call      qword ptr [7FFD22B84DB0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Int32, System.Private.CoreLib]](Int32)
       mov       ecx,[rsp+40]
       mov       edx,[rsp+50]
       cmp       ecx,edx
       ja        near ptr M00_L15
       mov       rax,[rsp+48]
       mov       r8d,ecx
       lea       rax,[rax+r8*2]
       sub       edx,ecx
       cmp       edx,5
       jb        near ptr M00_L14
       mov       rcx,64006E00610020
       mov       [rax],rcx
       mov       word ptr [rax+8],20
       mov       ecx,[rsp+40]
       add       ecx,5
       mov       [rsp+40],ecx
M00_L03:
       lea       rcx,[rsp+30]
       mov       edx,7FFFFFFF
       call      qword ptr [7FFD22B84DB0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Int32, System.Private.CoreLib]](Int32)
       mov       ecx,[rsp+40]
       mov       edx,[rsp+50]
       cmp       ecx,edx
       ja        near ptr M00_L15
       mov       rax,[rsp+48]
       mov       r8d,ecx
       lea       rax,[rax+r8*2]
       sub       edx,ecx
       je        near ptr M00_L16
       mov       word ptr [rax],2E
       mov       ecx,[rsp+40]
       inc       ecx
       mov       [rsp+40],ecx
M00_L04:
       lea       rcx,[rsp+30]
       call      qword ptr [7FFD22B84EA0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L05
       call      qword ptr [7FFD22F8F540]
       mov       rbx,rax
M00_L05:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,2A757560B70
       call      qword ptr [7FFD22DB41F8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L06:
       call      qword ptr [7FFD22E34C60]
       mov       ecx,20EB
       mov       rdx,7FFD22C34F20
       call      qword ptr [7FFD22B87798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFD22C34F20
       call      qword ptr [7FFD22B87798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD22967840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0F32
       mov       rdx,7FFD22C34F20
       call      qword ptr [7FFD22B87798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD22967840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFD22F8F4B0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFD22F8F4C8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       mov       rcx,rax
       mov       r11,7FFD228B08F0
       call      qword ptr [r11]
       mov       ebp,eax
       jmp       near ptr M00_L00
M00_L08:
       mov       rdx,rdi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFD22966850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M00_L09
       mov       rcx,rax
       mov       edx,1
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax]
       mov       ebp,eax
       test      ebp,ebp
       jl        short M00_L09
       jmp       near ptr M00_L00
M00_L09:
       mov       rdx,rdi
       mov       rcx,offset MT_System.Collections.ICollection
       call      qword ptr [7FFD22ADF618]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M00_L10
       mov       rcx,rax
       mov       r11,7FFD228B08E8
       call      qword ptr [r11]
       mov       ebp,eax
       jmp       near ptr M00_L00
M00_L10:
       mov       rdx,rdi
       mov       rcx,offset MT_System.Collections.Generic.IReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
       test      rax,rax
       je        short M00_L11
       mov       rcx,rax
       mov       r11,7FFD228B08D8
       call      qword ptr [r11]
       mov       ebp,eax
       jmp       near ptr M00_L00
M00_L11:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Generic.IList<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFD22ADF618]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       jne       short M00_L12
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       call      qword ptr [7FFD22B8F258]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FFD22E34B88]
M00_L12:
       mov       rcx,rdi
       mov       r11,7FFD228B08D0
       call      qword ptr [r11]
       mov       ebp,eax
       jmp       near ptr M00_L00
M00_L13:
       lea       rcx,[rsp+30]
       mov       rdx,2A757560BC8
       call      qword ptr [7FFD22F84648]
       jmp       near ptr M00_L02
M00_L14:
       lea       rcx,[rsp+30]
       mov       rdx,2A757560C20
       call      qword ptr [7FFD22F84648]
       jmp       near ptr M00_L03
M00_L15:
       call      qword ptr [7FFD22AD7198]
       int       3
M00_L16:
       lea       rcx,[rsp+30]
       mov       rdx,2A757550658
       call      qword ptr [7FFD22F84648]
       jmp       near ptr M00_L04
; Total bytes of code 974
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rdx,rdx
       je        short M01_L01
       mov       rax,[rdx]
       movzx     r8d,word ptr [rax+0E]
       test      r8,r8
       je        short M01_L05
       mov       r10,[rax+38]
       cmp       r8,4
       jl        short M01_L04
       cmp       [r10],rcx
       je        short M01_L01
M01_L00:
       cmp       [r10+8],rcx
       jne       short M01_L03
M01_L01:
       mov       rax,rdx
       ret
M01_L02:
       cmp       [r10],rcx
       je        short M01_L01
       jmp       short M01_L00
M01_L03:
       cmp       [r10+10],rcx
       je        short M01_L01
       cmp       [r10+18],rcx
       je        short M01_L01
       add       r10,20
       add       r8,0FFFFFFFFFFFFFFFC
       cmp       r8,4
       jge       short M01_L02
       test      r8,r8
       je        short M01_L05
M01_L04:
       cmp       [r10],rcx
       je        short M01_L01
       add       r10,8
       dec       r8
       test      r8,r8
       jg        short M01_L04
M01_L05:
       test      dword ptr [rax],500C0000
       jne       short M01_L06
       xor       edx,edx
       jmp       short M01_L01
M01_L06:
       jmp       qword ptr [7FFD22F06EC8]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
; Total bytes of code 116
```
```assembly
; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler..ctor(Int32, Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       esi,edx
       mov       edi,r8d
       xor       eax,eax
       mov       [rbx],rax
       call      qword ptr [7FFD823EA098]
       mov       rcx,[rax]
       imul      edx,edi,0B
       add       edx,esi
       mov       eax,100
       cmp       edx,100
       cmovle    edx,eax
       cmp       [rcx],ecx
       call      qword ptr [7FFD824098B8]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
       mov       [rbx+8],rax
       test      rax,rax
       je        short M02_L01
       lea       rcx,[rax+10]
       mov       eax,[rax+8]
M02_L00:
       mov       [rbx+18],rcx
       mov       [rbx+20],eax
       xor       eax,eax
       mov       [rbx+10],eax
       mov       byte ptr [rbx+14],0
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L01:
       xor       ecx,ecx
       xor       eax,eax
       jmp       short M02_L00
; Total bytes of code 102
```
```assembly
; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Int32, System.Private.CoreLib]](Int32)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       xorps     xmm4,xmm4
       movaps    [rsp+30],xmm4
       movaps    [rsp+40],xmm4
       mov       rbx,rcx
       mov       esi,edx
       cmp       byte ptr [rbx+14],0
       jne       short M03_L03
M03_L00:
       lea       rdx,[rbx+18]
       mov       r8d,[rbx+10]
       mov       edi,[rdx+8]
       cmp       r8d,edi
       ja        near ptr M03_L10
       mov       rdx,[rdx]
       mov       ecx,r8d
       lea       rbp,[rdx+rcx*2]
       sub       edi,r8d
       mov       rcx,[rbx]
       test      esi,esi
       jl        short M03_L05
       mov       [rsp+40],rbp
       mov       [rsp+48],edi
       lea       rdx,[rsp+40]
       lea       r8,[rsp+50]
       mov       ecx,esi
       call      qword ptr [7FFD82410CF8]; Precode of System.Number.TryUInt32ToDecStr[[System.Char, System.Private.CoreLib]](UInt32, System.Span`1<Char>, Int32 ByRef)
M03_L01:
       test      eax,eax
       jne       short M03_L02
       mov       rcx,rbx
       call      qword ptr [7FFD82404FF8]
       jmp       short M03_L00
M03_L02:
       mov       eax,[rsp+50]
       add       [rbx+10],eax
       jmp       short M03_L04
M03_L03:
       mov       rcx,rbx
       mov       edx,esi
       xor       r8d,r8d
       call      qword ptr [7FFD82411B50]
M03_L04:
       nop
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M03_L05:
       test      rcx,rcx
       je        short M03_L06
       call      qword ptr [7FFD82401260]; Precode of System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider)
       jmp       short M03_L07
M03_L06:
       call      qword ptr [7FFD82401248]; Precode of System.Globalization.NumberFormatInfo.get_CurrentInfo()
M03_L07:
       mov       r8,[rax+28]
       test      r8,r8
       jne       short M03_L08
       xor       r9d,r9d
       xor       r8d,r8d
       jmp       short M03_L09
M03_L08:
       lea       r9,[r8+0C]
       mov       r8d,[r8+8]
M03_L09:
       mov       [rsp+30],r9
       mov       [rsp+38],r8d
       mov       [rsp+40],rbp
       mov       [rsp+48],edi
       lea       r8,[rsp+50]
       mov       [rsp+20],r8
       lea       r8,[rsp+30]
       lea       r9,[rsp+40]
       mov       ecx,esi
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFD82410CE0]
       jmp       near ptr M03_L01
M03_L10:
       call      qword ptr [7FFD823FF2B8]
       int       3
; Total bytes of code 255
```
```assembly
; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       lea       rsi,[rbx+18]
       mov       rcx,rsi
       mov       eax,[rbx+10]
       cmp       eax,[rcx+8]
       ja        short M04_L01
       mov       rcx,[rcx]
       mov       [rsp+28],rcx
       mov       [rsp+30],eax
       lea       rcx,[rsp+28]
       call      qword ptr [7FFD823FBB28]; Precode of System.String.Ctor(System.ReadOnlySpan`1<Char>)
       mov       rdi,rax
       mov       rbp,[rbx+8]
       xor       eax,eax
       mov       [rbx+8],rax
       mov       [rsi],rax
       mov       [rsi+8],rax
       mov       [rbx+10],eax
       test      rbp,rbp
       je        short M04_L00
       call      qword ptr [7FFD823EA098]
       mov       rcx,[rax]
       mov       rdx,rbp
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFD824098C0]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
M04_L00:
       mov       rax,rdi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M04_L01:
       call      qword ptr [7FFD823FF2B8]
       int       3
; Total bytes of code 126
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
       je        near ptr M05_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M05_L01
       test      rsi,rsi
       je        short M05_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M05_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M05_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFD826152E0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFD22965818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFD22965818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
M05_L00:
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
M05_L01:
       test      rsi,rsi
       je        short M05_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M05_L03
M05_L02:
       mov       rax,2A757550008
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M05_L03:
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
M05_L04:
       call      qword ptr [7FFD22F8F8A0]
       int       3
; Total bytes of code 244
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rdx,rdx
       je        short M06_L02
       mov       rax,[rdx]
       cmp       rax,rcx
       je        short M06_L02
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M06_L02
M06_L00:
       test      rax,rax
       je        short M06_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M06_L02
       test      rax,rax
       je        short M06_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M06_L02
       test      rax,rax
       jne       short M06_L03
M06_L01:
       xor       edx,edx
M06_L02:
       mov       rax,rdx
       ret
M06_L03:
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M06_L02
       test      rax,rax
       je        short M06_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M06_L02
       jmp       short M06_L00
; Total bytes of code 86
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
       push      rsi
       push      rbx
       test      rdx,rdx
       je        short M07_L02
       mov       rax,[rdx]
       cmp       rax,rcx
       je        short M07_L02
       mov       r8,266C2400038
       mov       r8,[r8]
       add       r8,10
       rorx      r10,rax,20
       xor       r10,rcx
       mov       r9,9E3779B97F4A7C15
       imul      r10,r9
       mov       r9d,[r8]
       shrx      r10,r10,r9
       xor       r9d,r9d
M07_L00:
       lea       r11d,[r10+1]
       movsxd    r11,r11d
       lea       r11,[r11+r11*2]
       lea       r11,[r8+r11*8]
       mov       ebx,[r11]
       mov       rsi,[r11+8]
       and       ebx,0FFFFFFFE
       cmp       rsi,rax
       jne       short M07_L03
       mov       rsi,rcx
       xor       rsi,[r11+10]
       cmp       rsi,1
       ja        short M07_L03
       cmp       ebx,[r11]
       jne       short M07_L04
M07_L01:
       cmp       esi,1
       jne       short M07_L05
M07_L02:
       mov       rax,rdx
       pop       rbx
       pop       rsi
       ret
M07_L03:
       test      ebx,ebx
       je        short M07_L04
       inc       r9d
       add       r10d,r9d
       and       r10d,[r8+4]
       cmp       r9d,8
       jl        short M07_L00
M07_L04:
       mov       esi,2
       jmp       short M07_L01
M07_L05:
       test      esi,esi
       jne       short M07_L06
       xor       edx,edx
       jmp       short M07_L02
M07_L06:
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFD2296D908]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny_NoCacheLookup(Void*, System.Object)
; Total bytes of code 168
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       rcx,[rbx]
       call      qword ptr [7FFD823EC570]
       mov       rcx,rax
       call      qword ptr [7FFD823E90A0]; Precode of System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       lea       rcx,[rbx+8]
       call      qword ptr [7FFD823E8FE8]; CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,30
       pop       rbx
       ret
; Total bytes of code 51
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.ValidatorBenchmark.EnsureNotEmpty()
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,68
       lea       rbp,[rsp+90]
       xor       eax,eax
       mov       [rbp-68],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-60],ymm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       mov       [rbp-30],rax
       mov       [rbp+10],rcx
       mov       r8,[rcx+1A8]
       test      r8,r8
       je        near ptr M00_L07
       mov       [rbp-40],r8
       mov       rax,195744018B8
       cmp       qword ptr [rax],0
       je        near ptr M00_L08
M00_L00:
       mov       rax,195744018B8
       mov       rbx,[rax]
       mov       rax,offset MT_System.Resources.ResourceManager
       cmp       [rbx],rax
       jne       near ptr M00_L18
       mov       rax,195744018C0
       mov       rsi,[rax]
       test      rsi,rsi
       jne       short M00_L02
       mov       rax,gs:[58]
       mov       rax,[rax+30]
       cmp       dword ptr [rax+238],2
       jle       near ptr M00_L09
       mov       rax,[rax+240]
       mov       rax,[rax+10]
       test      rax,rax
       je        near ptr M00_L09
M00_L01:
       mov       rsi,[rax+18]
       test      rsi,rsi
       jne       short M00_L02
       mov       rax,19574400108
       mov       rsi,[rax]
       test      rsi,rsi
       jne       short M00_L02
       call      qword ptr [7FFD22B94138]; System.Globalization.CultureInfo.get_UserDefaultUICulture()
       mov       rsi,rax
M00_L02:
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFD22B9FFA8]; System.Resources.ResourceManager.GetFirstResourceSet(System.Globalization.CultureInfo)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M00_L12
       movzx     r8d,byte ptr [rbx+54]
       mov       rcx,offset MT_System.Resources.RuntimeResourceSet
       cmp       [rdi],rcx
       jne       near ptr M00_L11
       mov       rcx,rdi
       mov       rdx,1D6095E0BC8
       mov       r9d,1
       call      qword ptr [7FFD22D04AB0]; System.Resources.RuntimeResourceSet.GetObject(System.String, Boolean, Boolean)
       mov       r14,rax
       test      r14,r14
       je        short M00_L03
       mov       rcx,offset MT_System.String
       cmp       [r14],rcx
       jne       near ptr M00_L10
M00_L03:
       test      r14,r14
       je        near ptr M00_L12
M00_L04:
       mov       rdx,[rbp-40]
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFD22AEF618]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        near ptr M00_L20
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],rcx
       jne       near ptr M00_L19
       mov       ebx,[rax+10]
M00_L05:
       test      ebx,ebx
       je        near ptr M00_L23
M00_L06:
       mov       r8,[rbp-40]
       mov       [rbp-38],r8
       mov       rcx,[rbp+10]
       mov       rbx,[rcx+90]
       mov       rdx,[rbp-38]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,68
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L07:
       call      qword ptr [7FFD22E44C60]
       mov       ecx,20EB
       mov       rdx,7FFD22C44F20
       call      qword ptr [7FFD22B97798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFD22C44F20
       call      qword ptr [7FFD22B97798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD22977840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0F32
       mov       rdx,7FFD22C44F20
       call      qword ptr [7FFD22B97798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD22977840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFD22F9F8D0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFD22F9F8E8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L08:
       mov       rcx,offset MT_System.Resources.ResourceManager
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,1D6095E0C90
       call      qword ptr [7FFD22F9F900]
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,1D6095E0C20
       call      qword ptr [7FFD22B9F8D0]; System.Resources.ResourceManager..ctor(System.String, System.Reflection.Assembly)
       mov       rcx,195744018B8
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L09:
       mov       ecx,2
       call      qword ptr [7FFD22F9F240]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L01
M00_L10:
       mov       rdx,rax
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M00_L11:
       mov       rcx,rdi
       mov       rdx,1D6095E0BC8
       mov       rax,[rdi]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
       mov       r14,rax
       jmp       near ptr M00_L03
M00_L12:
       mov       rcx,offset MT_System.Resources.ResourceFallbackManager
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       r8,[rbx+30]
       mov       rcx,r14
       mov       rdx,rsi
       mov       r9d,1
       call      qword ptr [7FFD22F9F258]
       mov       rcx,offset MT_System.Resources.ResourceFallbackManager+<GetEnumerator>d__5
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       xor       ecx,ecx
       mov       [rsi+20],ecx
       lea       rcx,[rsi+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp-50],rsi
M00_L13:
       mov       rcx,[rbp-50]
       call      qword ptr [7FFD22CF9058]; Precode of System.Resources.ResourceFallbackManager+<GetEnumerator>d__5.MoveNext()
       test      eax,eax
       je        near ptr M00_L16
       mov       rcx,[rbp-50]
       mov       rsi,[rcx+8]
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,1
       mov       r9d,1
       call      qword ptr [7FFD22AB8720]; Precode of System.Resources.ResourceManager.InternalGetResourceSet(System.Globalization.CultureInfo, Boolean, Boolean)
       mov       r14,rax
       test      r14,r14
       je        near ptr M00_L16
       cmp       r14,rdi
       je        short M00_L13
       movzx     r8d,byte ptr [rbx+54]
       mov       rcx,r14
       mov       rdx,1D6095E0BC8
       mov       rax,[r14]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
       mov       r15,rax
       test      r15,r15
       jne       short M00_L14
       mov       rdi,r14
       jmp       short M00_L13
M00_L14:
       cmp       qword ptr [rbx+38],0
       je        short M00_L15
       mov       rdx,[rbx+38]
       mov       [rbp-60],rdx
       mov       byte ptr [rbp-30],0
       lea       rdx,[rbp-30]
       mov       rcx,[rbp-60]
       call      qword ptr [7FFD22975998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rcx,[rbx+38]
       lea       rcx,[rcx+8]
       mov       [rbp-68],rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       rcx,[rbp-68]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbx+38]
       lea       rcx,[rcx+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       nop
       cmp       byte ptr [rbp-30],0
       je        short M00_L15
       mov       rcx,[rbp-60]
       call      qword ptr [7FFD22976820]; System.Threading.Monitor.Exit(System.Object)
M00_L15:
       mov       [rbp-58],r15
       jmp       short M00_L17
M00_L16:
       xor       r8d,r8d
       mov       rcx,[rbp-50]
       mov       [rcx+18],r8
       mov       dword ptr [rcx+20],0FFFFFFFE
       xor       r14d,r14d
       jmp       near ptr M00_L04
M00_L17:
       call      M00_L30
       nop
       mov       r14,[rbp-58]
       jmp       near ptr M00_L04
M00_L18:
       mov       r8,195744018C0
       mov       r8,[r8]
       mov       rcx,rbx
       mov       rdx,1D6095E0BC8
       mov       rax,[rbx]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       mov       r14,rax
       jmp       near ptr M00_L04
M00_L19:
       mov       rcx,rax
       mov       r11,7FFD228C0958
       call      qword ptr [r11]
       mov       ebx,eax
       jmp       near ptr M00_L05
M00_L20:
       mov       rdx,[rbp-40]
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFD22976850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M00_L21
       mov       rcx,rax
       mov       edx,1
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax]
       mov       ebx,eax
       test      ebx,ebx
       jl        short M00_L21
       jmp       near ptr M00_L05
M00_L21:
       mov       rdx,[rbp-40]
       mov       rcx,offset MT_System.Collections.ICollection
       call      qword ptr [7FFD22AEF618]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M00_L22
       mov       rcx,rax
       mov       r11,7FFD228C0950
       call      qword ptr [r11]
       mov       ebx,eax
       jmp       near ptr M00_L05
M00_L22:
       mov       rcx,[rbp-40]
       mov       r11,7FFD228C0920
       call      qword ptr [r11]
       mov       [rbp-48],rax
       jmp       short M00_L25
M00_L23:
       test      r14,r14
       jne       short M00_L24
       call      qword ptr [7FFD22F9F918]
       mov       r14,rax
M00_L24:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.InvalidValueException<System.Collections.Generic.IEnumerable<DotNetTips.Spargine.Tester.Models.RefTypes.Person>>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,r14
       mov       r8,[rbp-40]
       call      qword ptr [7FFD22F9F930]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L25:
       mov       rcx,[rbp-48]
       mov       r11,7FFD228C0928
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L27
       mov       rbx,r14
       test      rbx,rbx
       jne       short M00_L26
       call      qword ptr [7FFD22F9F918]
       mov       rbx,rax
M00_L26:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.InvalidValueException<System.Collections.Generic.IEnumerable<DotNetTips.Spargine.Tester.Models.RefTypes.Person>>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r8,[rbp-40]
       call      qword ptr [7FFD22F9F930]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L27:
       mov       rcx,[rbp-48]
       mov       r11,7FFD228C0930
       call      qword ptr [r11]
       jmp       near ptr M00_L06
       sub       rsp,28
       cmp       qword ptr [rbp-48],0
       je        short M00_L28
       mov       rcx,[rbp-48]
       mov       r11,7FFD228C0930
       call      qword ptr [r11]
M00_L28:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       byte ptr [rbp-30],0
       je        short M00_L29
       mov       rcx,[rbp-60]
       call      qword ptr [7FFD22976820]; System.Threading.Monitor.Exit(System.Object)
M00_L29:
       nop
       add       rsp,28
       ret
M00_L30:
       sub       rsp,28
       xor       r8d,r8d
       mov       rcx,[rbp-50]
       mov       [rcx+18],r8
       mov       dword ptr [rcx+20],0FFFFFFFE
       add       rsp,28
       ret
; Total bytes of code 1499
```
```assembly
; System.Globalization.CultureInfo.get_UserDefaultUICulture()
       mov       rax,195744000F8
       mov       rax,[rax]
       test      rax,rax
       je        short M01_L00
       ret
M01_L00:
       jmp       qword ptr [7FFD22B94150]; System.Globalization.CultureInfo.InitializeUserDefaultUICulture()
; Total bytes of code 25
```
```assembly
; System.Resources.ResourceManager.GetFirstResourceSet(System.Globalization.CultureInfo)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-20],rax
       mov       [rbp-40],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       rbx,[rcx+30]
       test      rbx,rbx
       je        short M02_L03
       mov       rdx,[rbp+18]
       mov       rsi,offset MT_System.Globalization.CultureInfo
       cmp       [rdx],rsi
       jne       near ptr M02_L17
       mov       rdx,[rbp+18]
       mov       rdi,[rdx+48]
       test      rdi,rdi
       je        near ptr M02_L16
M02_L00:
       cmp       [rbx],rsi
       jne       near ptr M02_L19
       mov       rdx,[rbx+48]
       test      rdx,rdx
       je        near ptr M02_L18
M02_L01:
       cmp       rdi,rdx
       jne       near ptr M02_L15
M02_L02:
       mov       rax,19574400100
       mov       rax,[rax]
       mov       [rbp+18],rax
M02_L03:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+38]
       test      rax,rax
       je        near ptr M02_L22
       mov       [rbp-30],rax
       xor       eax,eax
       mov       [rbp-28],eax
       cmp       byte ptr [rbp-28],0
       je        short M02_L04
       call      qword ptr [7FFD22F9F288]
       int       3
M02_L04:
       mov       rcx,[rbp-30]
       call      00007FFD8261E120
       test      eax,eax
       jne       short M02_L05
       mov       rcx,[rbp-30]
       call      qword ptr [7FFD22F9F2A0]
M02_L05:
       mov       dword ptr [rbp-28],1
       mov       rcx,[rbp+18]
       mov       rsi,offset MT_System.Globalization.CultureInfo
       cmp       [rcx],rsi
       jne       near ptr M02_L11
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+48]
       test      rcx,rcx
       je        short M02_L10
M02_L06:
       mov       rax,[rbp+10]
       mov       r8,[rax+38]
       mov       rdx,[r8+8]
       cmp       rcx,rdx
       jne       short M02_L08
M02_L07:
       mov       rax,[rbp+10]
       mov       rcx,[rax+38]
       mov       rbx,[rcx+10]
       jmp       near ptr M02_L13
M02_L08:
       test      rcx,rcx
       je        near ptr M02_L12
       test      rdx,rdx
       je        short M02_L12
       mov       r8d,[rcx+8]
       cmp       r8d,[rdx+8]
       jne       short M02_L12
       add       rcx,0C
       add       r8d,r8d
       add       rdx,0C
       call      qword ptr [7FFD2297FBB8]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
M02_L09:
       test      eax,eax
       je        near ptr M02_L20
       jmp       short M02_L07
M02_L10:
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+18]
       mov       rdx,1D6095D0008
       test      rcx,rcx
       cmove     rcx,rdx
       mov       rbx,rcx
       mov       rcx,[rbp+18]
       lea       rcx,[rcx+48]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbx
       jmp       near ptr M02_L06
M02_L11:
       mov       rcx,[rbp+18]
       mov       rax,[rbp+18]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       rcx,rax
       jmp       near ptr M02_L06
M02_L12:
       xor       ecx,ecx
       mov       eax,ecx
       jmp       short M02_L09
M02_L13:
       cmp       byte ptr [rbp-28],0
       je        short M02_L14
       mov       rcx,[rbp-30]
       call      00007FFD8261E040
       test      eax,eax
       jne       near ptr M02_L21
M02_L14:
       mov       rax,rbx
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M02_L15:
       test      rdi,rdi
       je        near ptr M02_L03
       test      rdx,rdx
       je        near ptr M02_L03
       mov       r8d,[rdi+8]
       cmp       r8d,[rdx+8]
       jne       near ptr M02_L03
       lea       rax,[rdi+0C]
       mov       r8d,[rdi+8]
       add       r8d,r8d
       add       rdx,0C
       mov       rcx,rax
       call      qword ptr [7FFD2297FBB8]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       test      eax,eax
       je        near ptr M02_L03
       jmp       near ptr M02_L02
M02_L16:
       mov       rdx,[rbp+18]
       mov       rdx,[rdx+30]
       mov       rdx,[rdx+18]
       mov       rax,1D6095D0008
       test      rdx,rdx
       cmove     rdx,rax
       mov       rdi,rdx
       mov       rdx,[rbp+18]
       lea       rcx,[rdx+48]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L00
M02_L17:
       mov       rcx,[rbp+18]
       mov       rax,[rbp+18]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       rdi,rax
       mov       rcx,[rbp+10]
       mov       rbx,[rcx+30]
       jmp       short M02_L19
M02_L18:
       mov       rdx,[rbx+30]
       mov       rdx,[rdx+18]
       mov       rax,1D6095D0008
       test      rdx,rdx
       cmove     rdx,rax
       mov       rsi,rdx
       lea       rcx,[rbx+48]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,rsi
       jmp       near ptr M02_L01
M02_L19:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       rdx,rax
       jmp       near ptr M02_L01
M02_L20:
       call      M02_L26
       jmp       short M02_L22
M02_L21:
       mov       ecx,eax
       mov       rdx,[rbp-30]
       call      qword ptr [7FFD22F9F0A8]
       jmp       near ptr M02_L14
M02_L22:
       mov       rax,[rbp+10]
       mov       rbx,[rax+18]
       xor       edx,edx
       mov       [rbp-20],rdx
       test      rbx,rbx
       je        short M02_L23
       mov       [rbp-38],rbx
       xor       edx,edx
       mov       [rbp-28],edx
       lea       rdx,[rbp-28]
       mov       rcx,rbx
       call      qword ptr [7FFD22975998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rcx,[rbp+18]
       mov       rax,[rbp+18]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       rdx,rax
       lea       r8,[rbp-20]
       mov       rcx,rbx
       call      qword ptr [7FFD229BAC10]; Precode of System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryGetValue(System.__Canon, System.__Canon ByRef)
       nop
       cmp       byte ptr [rbp-28],0
       je        short M02_L23
       mov       rcx,rbx
       call      qword ptr [7FFD22976820]; System.Threading.Monitor.Exit(System.Object)
M02_L23:
       cmp       qword ptr [rbp-20],0
       je        near ptr M02_L25
       mov       rax,[rbp+10]
       cmp       qword ptr [rax+38],0
       je        short M02_L24
       mov       rdx,[rax+38]
       mov       [rbp-30],rdx
       xor       edx,edx
       mov       [rbp-28],edx
       lea       rdx,[rbp-28]
       mov       rcx,[rbp-30]
       call      qword ptr [7FFD22975998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rax,[rbp+10]
       mov       rcx,[rax+38]
       lea       rcx,[rcx+8]
       mov       [rbp-40],rcx
       mov       rcx,[rbp+18]
       mov       rdx,[rbp+18]
       mov       rdx,[rdx]
       mov       rdx,[rdx+40]
       call      qword ptr [rdx+38]
       mov       rcx,[rbp-40]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp+10]
       mov       rcx,[rax+38]
       lea       rcx,[rcx+10]
       mov       rdx,[rbp-20]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       cmp       byte ptr [rbp-28],0
       je        short M02_L24
       mov       rcx,[rbp-30]
       call      qword ptr [7FFD22976820]; System.Threading.Monitor.Exit(System.Object)
M02_L24:
       mov       rax,[rbp-20]
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M02_L25:
       xor       eax,eax
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M02_L26:
       sub       rsp,28
       cmp       byte ptr [rbp-28],0
       je        short M02_L27
       mov       rcx,[rbp-30]
       call      00007FFD8261E040
       test      eax,eax
       je        short M02_L27
       mov       ecx,eax
       mov       rdx,[rbp-30]
       call      qword ptr [7FFD22F9F0A8]
M02_L27:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       byte ptr [rbp-28],0
       je        short M02_L28
       mov       rcx,[rbp-38]
       call      qword ptr [7FFD22976820]; System.Threading.Monitor.Exit(System.Object)
M02_L28:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       byte ptr [rbp-28],0
       je        short M02_L29
       mov       rcx,[rbp-30]
       call      qword ptr [7FFD22976820]; System.Threading.Monitor.Exit(System.Object)
M02_L29:
       nop
       add       rsp,28
       ret
; Total bytes of code 1028
```
```assembly
; System.Resources.RuntimeResourceSet.GetObject(System.String, Boolean, Boolean)
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
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-80],ymm4
       vmovdqu   ymmword ptr [rbp-60],ymm4
       xor       eax,eax
       mov       [rbp-40],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8d
       mov       [rbp+28],r9d
       test      rdx,rdx
       je        near ptr M03_L24
       mov       rax,[rcx+28]
       mov       [rbp-70],rax
       mov       rbx,[rcx+20]
       test      rax,rax
       je        near ptr M03_L25
       test      rbx,rbx
       je        near ptr M03_L25
       mov       [rbp-78],rbx
       xor       r8d,r8d
       mov       [rbp-50],r8d
       cmp       byte ptr [rbp-50],0
       je        short M03_L00
       call      qword ptr [7FFD22F9F288]
       int       3
M03_L00:
       mov       rcx,rbx
       call      00007FFD8261E120
       test      eax,eax
       jne       short M03_L01
       mov       rcx,rbx
       call      qword ptr [7FFD22F9F2A0]
M03_L01:
       mov       dword ptr [rbp-50],1
       cmp       qword ptr [rbx+8],0
       je        near ptr M03_L16
       mov       rsi,[rbx+18]
       mov       rdi,[rsi]
       mov       rcx,offset MT_System.Resources.FastResourceComparer
       cmp       rdi,rcx
       jne       near ptr M03_L11
       mov       ecx,1505
       mov       rdx,[rbp+18]
       mov       r14d,[rdx+8]
       test      r14d,r14d
       jle       short M03_L03
       lea       r11,[rdx+0C]
M03_L02:
       mov       eax,ecx
       shl       eax,5
       add       ecx,eax
       movzx     eax,word ptr [r11]
       xor       ecx,eax
       add       r11,2
       dec       r14d
       jne       short M03_L02
M03_L03:
       mov       r14d,ecx
M03_L04:
       mov       r8,[rbx+8]
       mov       ecx,r14d
       imul      rcx,[rbx+30]
       shr       rcx,20
       inc       rcx
       mov       eax,[r8+8]
       mov       r10d,eax
       imul      rcx,r10
       shr       rcx,20
       cmp       ecx,eax
       jae       near ptr M03_L20
       mov       ecx,ecx
       lea       r8,[r8+rcx*4+10]
       mov       r15d,[r8]
       mov       r13,[rbx+10]
       xor       r12d,r12d
       dec       r15d
       mov       eax,[r13+8]
       mov       [rbp-64],eax
       cmp       eax,r15d
       jbe       near ptr M03_L16
M03_L05:
       mov       r8d,r15d
       shl       r8,5
       lea       r15,[r13+r8+10]
       cmp       [r15+8],r14d
       jne       near ptr M03_L15
       mov       r10,[r15]
       mov       r8,offset MT_System.Resources.FastResourceComparer
       cmp       rdi,r8
       jne       near ptr M03_L14
       cmp       r10,rdx
       jne       short M03_L09
       mov       r9d,1
M03_L06:
       test      r9d,r9d
       je        near ptr M03_L15
       add       r15,10
M03_L07:
       test      r15,r15
       je        short M03_L10
       vmovdqu   xmm0,xmmword ptr [r15]
       vmovdqu   xmmword ptr [rbp-48],xmm0
       mov       rsi,[rbp-48]
       test      rsi,rsi
       je        near ptr M03_L17
M03_L08:
       mov       [rbp-80],rsi
       jmp       near ptr M03_L22
M03_L09:
       test      r10,r10
       je        near ptr M03_L13
       mov       r8d,[r10+8]
       mov       ecx,[rdx+8]
       cmp       r8d,ecx
       jne       near ptr M03_L13
       lea       rcx,[r10+0C]
       add       r8d,r8d
       add       rdx,0C
       call      qword ptr [7FFD2297FBB8]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r9d,eax
       mov       rdx,[rbp+18]
       jmp       short M03_L06
M03_L10:
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-48],xmm0
       mov       rcx,[rbp-70]
       call      qword ptr [7FFD22D04B28]; System.Resources.ResourceReader.FindPosForResource(System.String)
       test      eax,eax
       jl        near ptr M03_L21
       movzx     r8d,byte ptr [rbp+28]
       lea       r9,[rbp-48]
       mov       rcx,[rbp-70]
       mov       edx,eax
       call      qword ptr [7FFD22D04BA0]; System.Resources.RuntimeResourceSet.ReadValue(System.Resources.ResourceReader, Int32, Boolean, System.Resources.ResourceLocator ByRef)
       mov       rsi,rax
       mov       r8,[rbp-48]
       mov       edx,[rbp-40]
       mov       [rbp-60],r8
       mov       [rbp-58],edx
       lea       r8,[rbp-60]
       mov       rdx,[rbp+18]
       mov       rcx,rbx
       mov       r9d,1
       call      qword ptr [7FFD22D04C60]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.Resources.ResourceLocator, System.Private.CoreLib]].TryInsert(System.__Canon, System.Resources.ResourceLocator, System.Collections.Generic.InsertionBehavior)
       mov       rdx,[rbp+18]
       jmp       near ptr M03_L08
M03_L11:
       mov       rcx,rsi
       mov       rdx,[rbp+18]
       mov       r11,7FFD228C09A8
       call      qword ptr [r11]
       mov       r14d,eax
       mov       rdx,[rbp+18]
       jmp       near ptr M03_L04
M03_L12:
       cmp       eax,r15d
       jbe       short M03_L16
       jmp       near ptr M03_L05
M03_L13:
       xor       r9d,r9d
       jmp       near ptr M03_L06
M03_L14:
       mov       rcx,rsi
       mov       r8,rdx
       mov       rdx,r10
       mov       r11,7FFD228C09B0
       call      qword ptr [r11]
       mov       r9d,eax
       mov       rdx,[rbp+18]
       jmp       near ptr M03_L06
M03_L15:
       mov       r15d,[r15+0C]
       inc       r12d
       mov       eax,[rbp-64]
       cmp       eax,r12d
       jae       short M03_L12
       call      qword ptr [7FFD22B97A08]
       int       3
M03_L16:
       xor       r15d,r15d
       mov       rdx,[rbp+18]
       jmp       near ptr M03_L07
M03_L17:
       mov       eax,[rbp-40]
       cmp       byte ptr [rbp+28],0
       jne       short M03_L18
       mov       rcx,[rbp-70]
       mov       edx,eax
       call      qword ptr [7FFD22F9F360]
       jmp       short M03_L19
M03_L18:
       mov       rcx,[rbp-70]
       mov       edx,eax
       call      qword ptr [7FFD22E44CF0]; System.Resources.ResourceReader.LoadString(Int32)
M03_L19:
       mov       [rbp-80],rax
       jmp       short M03_L22
M03_L20:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M03_L21:
       call      M03_L38
       jmp       near ptr M03_L27
M03_L22:
       cmp       byte ptr [rbp-50],0
       je        short M03_L23
       mov       rcx,[rbp-78]
       call      00007FFD8261E040
       test      eax,eax
       jne       short M03_L26
M03_L23:
       mov       rax,[rbp-80]
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
M03_L24:
       mov       ecx,13BFC
       mov       rdx,7FFD228B4000
       call      qword ptr [7FFD22B97798]
       mov       rcx,rax
       call      qword ptr [7FFD22F9F090]
       int       3
M03_L25:
       mov       rcx,offset MT_System.ObjectDisposedException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFD22F9F330]
       mov       r8,rax
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFD22F9F348]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M03_L26:
       mov       ecx,eax
       mov       rdx,[rbp-78]
       call      qword ptr [7FFD22F9F0A8]
       jmp       short M03_L23
M03_L27:
       cmp       byte ptr [rbp+20],0
       jne       short M03_L28
       xor       eax,eax
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
M03_L28:
       xor       esi,esi
       mov       rcx,[rbp+10]
       mov       rbx,[rcx+30]
       test      rbx,rbx
       jne       short M03_L29
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.String, System.Resources.ResourceLocator>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       r8,19574400070
       mov       r8,[r8]
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFD22D04960]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.Resources.ResourceLocator, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       esi,1
M03_L29:
       mov       [rbp-78],rbx
       xor       edx,edx
       mov       [rbp-50],edx
       lea       rdx,[rbp-50]
       mov       rcx,rbx
       call      qword ptr [7FFD22975998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       test      esi,esi
       je        near ptr M03_L32
       mov       rcx,offset MT_System.Resources.ResourceReader+ResourceEnumerator
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,[rbp-70]
       call      qword ptr [7FFD22F9F378]
       jmp       short M03_L31
M03_L30:
       mov       rcx,rsi
       call      qword ptr [7FFD22CFF050]
       mov       rdx,rax
       mov       rcx,offset MT_System.String
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       rdx,rax
       mov       r8d,[rsi+14]
       cmp       [rbx],bl
       xor       ecx,ecx
       mov       [rbp-60],rcx
       mov       [rbp-58],r8d
       lea       r8,[rbp-60]
       mov       rcx,rbx
       mov       r9d,2
       call      qword ptr [7FFD22D04C60]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.Resources.ResourceLocator, System.Private.CoreLib]].TryInsert(System.__Canon, System.Resources.ResourceLocator, System.Collections.Generic.InsertionBehavior)
M03_L31:
       mov       rcx,rsi
       call      qword ptr [7FFD22CFF048]
       test      eax,eax
       jne       short M03_L30
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+30]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
M03_L32:
       lea       r8,[rbp-48]
       mov       rcx,rbx
       mov       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFD22CFD3D8]; Precode of System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.Resources.ResourceLocator, System.Private.CoreLib]].TryGetValue(System.__Canon, System.Resources.ResourceLocator ByRef)
       test      eax,eax
       jne       short M03_L33
       xor       r8d,r8d
       mov       [rbp-80],r8
       jmp       short M03_L36
M03_L33:
       cmp       qword ptr [rbp-48],0
       je        short M03_L34
       mov       r8,[rbp-48]
       mov       [rbp-80],r8
       jmp       short M03_L36
M03_L34:
       movzx     r8d,byte ptr [rbp+28]
       lea       r9,[rbp-48]
       mov       rcx,[rbp-70]
       mov       edx,[rbp-40]
       call      qword ptr [7FFD22D04BA0]; System.Resources.RuntimeResourceSet.ReadValue(System.Resources.ResourceReader, Int32, Boolean, System.Resources.ResourceLocator ByRef)
       mov       rsi,rax
       cmp       qword ptr [rbp-48],0
       je        short M03_L35
       mov       r8,[rbp-48]
       mov       edx,[rbp-40]
       mov       [rbp-60],r8
       mov       [rbp-58],edx
       lea       r8,[rbp-60]
       mov       rdx,[rbp+18]
       mov       rcx,rbx
       mov       r9d,1
       call      qword ptr [7FFD22D04C60]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.Resources.ResourceLocator, System.Private.CoreLib]].TryInsert(System.__Canon, System.Resources.ResourceLocator, System.Collections.Generic.InsertionBehavior)
       nop
M03_L35:
       cmp       byte ptr [rbp-50],0
       je        short M03_L37
       mov       rcx,[rbp-78]
       call      qword ptr [7FFD22976820]; System.Threading.Monitor.Exit(System.Object)
       jmp       short M03_L37
M03_L36:
       call      M03_L40
       jmp       near ptr M03_L23
M03_L37:
       mov       rax,rsi
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
M03_L38:
       sub       rsp,28
       cmp       byte ptr [rbp-50],0
       je        short M03_L39
       mov       rcx,[rbp-78]
       call      00007FFD8261E040
       test      eax,eax
       je        short M03_L39
       mov       ecx,eax
       mov       rdx,[rbp-78]
       call      qword ptr [7FFD22F9F0A8]
M03_L39:
       nop
       add       rsp,28
       ret
M03_L40:
       sub       rsp,28
       cmp       byte ptr [rbp-50],0
       je        short M03_L41
       mov       rcx,[rbp-78]
       call      qword ptr [7FFD22976820]; System.Threading.Monitor.Exit(System.Object)
M03_L41:
       nop
       add       rsp,28
       ret
; Total bytes of code 1351
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rdx,rdx
       je        short M04_L01
       mov       rax,[rdx]
       movzx     r8d,word ptr [rax+0E]
       test      r8,r8
       je        short M04_L05
       mov       r10,[rax+38]
       cmp       r8,4
       jl        short M04_L04
       cmp       [r10],rcx
       je        short M04_L01
M04_L00:
       cmp       [r10+8],rcx
       jne       short M04_L03
M04_L01:
       mov       rax,rdx
       ret
M04_L02:
       cmp       [r10],rcx
       je        short M04_L01
       jmp       short M04_L00
M04_L03:
       cmp       [r10+10],rcx
       je        short M04_L01
       cmp       [r10+18],rcx
       je        short M04_L01
       add       r10,20
       add       r8,0FFFFFFFFFFFFFFFC
       cmp       r8,4
       jge       short M04_L02
       test      r8,r8
       je        short M04_L05
M04_L04:
       cmp       [r10],rcx
       je        short M04_L01
       add       r10,8
       dec       r8
       test      r8,r8
       jg        short M04_L04
M04_L05:
       test      dword ptr [rax],500C0000
       jne       short M04_L06
       xor       edx,edx
       jmp       short M04_L01
M04_L06:
       jmp       qword ptr [7FFD22F16EC8]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
; Total bytes of code 116
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
       call      00007FFD826152E0
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFD22975818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFD22975818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1D6095D0008
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
       call      qword ptr [7FFD22F9FBB8]
       int       3
; Total bytes of code 235
```
```assembly
; System.Resources.ResourceManager..ctor(System.String, System.Reflection.Assembly)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rdi,rdx
       mov       rsi,r8
       test      rdi,rdi
       je        short M06_L00
       test      rsi,rsi
       je        short M06_L01
       mov       rcx,rsi
       call      qword ptr [7FFD823F75F0]
       test      rax,rax
       je        short M06_L02
       lea       rcx,[rbx+10]
       mov       rdx,rsi
       call      qword ptr [7FFD823E8FE8]; CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      qword ptr [7FFD823E8FE8]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax]
M06_L00:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFD823FC210]
       int       3
M06_L01:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFD823FC210]
       int       3
M06_L02:
       call      qword ptr [7FFD823F3550]
       mov       rbx,rax
       call      qword ptr [7FFD823FE2A8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD823FC1A8]
       mov       rcx,rbx
       call      qword ptr [7FFD823E8FC0]; CORINFO_HELP_THROW
       int       3
; Total bytes of code 157
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FFD82401D18]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       ecx,ebx
       and       ecx,0FFFFFF
       mov       edx,ecx
       mov       r8d,ebx
       sar       r8d,18
       jne       short M07_L01
       cmp       [rax],ecx
       jle       short M07_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M07_L03
M07_L00:
       add       rsp,20
       pop       rbx
       ret
M07_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M07_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M07_L00
M07_L02:
       cmp       [rax+4],edx
       jle       short M07_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M07_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M07_L03
       jmp       short M07_L00
M07_L03:
       mov       ecx,ebx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax]
; Total bytes of code 130
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       test      rdx,rdx
       je        short M08_L00
       cmp       [rdx],rcx
       jne       short M08_L01
M08_L00:
       mov       rax,rdx
       ret
M08_L01:
       jmp       qword ptr [7FFD2297FD08]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
; Total bytes of code 20
```
```assembly
; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rbx,rdx
       cmp       byte ptr [rbx],0
       je        short M09_L00
       call      qword ptr [7FFD82401C18]
       int       3
M09_L00:
       test      rsi,rsi
       je        short M09_L02
       mov       rcx,rsi
       call      qword ptr [7FFD82401BD8]
       test      eax,eax
       jne       short M09_L01
       mov       rcx,rsi
       call      qword ptr [7FFD82401BE8]
M09_L01:
       mov       byte ptr [rbx],1
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M09_L02:
       xor       ecx,ecx
       call      qword ptr [7FFD823FC210]
       int       3
; Total bytes of code 70
```
```assembly
; System.Threading.Monitor.Exit(System.Object)
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       test      rbx,rbx
       je        short M10_L00
       mov       rcx,rbx
       call      00007FFD8261E040
       test      eax,eax
       jne       short M10_L01
       add       rsp,20
       pop       rbx
       ret
M10_L00:
       xor       ecx,ecx
       call      qword ptr [7FFD22F9F090]
       int       3
M10_L01:
       mov       ecx,eax
       mov       rdx,rbx
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFD22F9F0A8]
; Total bytes of code 56
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rdx,rdx
       je        short M11_L02
       mov       rax,[rdx]
       cmp       rax,rcx
       je        short M11_L02
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M11_L02
M11_L00:
       test      rax,rax
       je        short M11_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M11_L02
       test      rax,rax
       je        short M11_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M11_L02
       test      rax,rax
       jne       short M11_L03
M11_L01:
       xor       edx,edx
M11_L02:
       mov       rax,rdx
       ret
M11_L03:
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M11_L02
       test      rax,rax
       je        short M11_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M11_L02
       jmp       short M11_L00
; Total bytes of code 86
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.ValidatorBenchmark.EnsureNotNullOrEmpty()
       push      rbx
       sub       rsp,10
       xor       eax,eax
       mov       [rsp+8],rax
       mov       rdx,173FFF40B70
       mov       [rsp+8],rdx
       mov       rbx,[rcx+90]
       mov       rdx,[rsp+8]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,10
       pop       rbx
       ret
; Total bytes of code 60
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.ValidatorBenchmark.EnsureNotNullOrWhiteSpace()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       esi,0C
       mov       edi,16
M00_L00:
       mov       rcx,1CA74F80B70
       movzx     ecx,word ptr [rcx+rsi]
       cmp       ecx,100
       jge       short M00_L02
       mov       rax,7FFD81776BF0
       test      byte ptr [rax+rcx],80
       jne       short M00_L03
M00_L01:
       mov       rcx,1CA74F80B70
       mov       [rsp+28],rcx
       mov       rbx,[rbx+90]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L02:
       call      qword ptr [7FFD22F9EF88]
       test      eax,eax
       je        short M00_L01
M00_L03:
       add       rsi,2
       dec       edi
       jne       short M00_L00
       call      qword ptr [7FFD22F96B80]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L04
       call      qword ptr [7FFD22F9F390]
       mov       rbx,rax
M00_L04:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ArgumentInvalidException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,2DB
       mov       rdx,7FFD22C42E38
       call      qword ptr [7FFD22B97798]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFD22E4FB10]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 219
```

