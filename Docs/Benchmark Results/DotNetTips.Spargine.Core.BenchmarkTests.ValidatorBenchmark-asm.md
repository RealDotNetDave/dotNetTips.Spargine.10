## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.ValidatorBenchmark.EnsureInRangeDouble()
       mov       rax,[rcx+88]
       mov       rcx,4049400000000000
       mov       [rax+10],rcx
       ret
; Total bytes of code 22
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.ValidatorBenchmark.EnsureInRangeInt()
       mov       rax,[rcx+88]
       mov       dword ptr [rax+38],32
       ret
; Total bytes of code 15
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.ValidatorBenchmark.EnsureInRangeLong()
       mov       rax,[rcx+88]
       mov       qword ptr [rax+18],32
       ret
; Total bytes of code 16
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.ValidatorBenchmark.CheckItemsExists_NoValidation_ForComparison()
       push      rbx
       sub       rsp,10
       mov       rdx,[rcx+198]
       mov       [rsp+8],rdx
       mov       rbx,[rcx+88]
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

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.ValidatorBenchmark.CheckItemsExists_Validation_Inlining()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rsi,[rbx+198]
       test      rsi,rsi
       je        short M00_L00
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FF8A7D9F618]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M00_L02
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],rcx
       jne       short M00_L01
M00_L00:
       mov       [rsp+20],rsi
       mov       rbx,[rbx+88]
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
       mov       r11,7FF8A7B708D8
       call      qword ptr [r11]
       jmp       short M00_L00
M00_L02:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FF8A7C26850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
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
       call      qword ptr [7FF8A7D9F618]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M00_L04
       mov       rcx,rax
       mov       r11,7FF8A7B708D0
       call      qword ptr [r11]
       jmp       near ptr M00_L00
M00_L04:
       mov       rdx,rsi
       mov       rcx,7FF8A82B0E90
       call      qword ptr [7FF8A8236C10]
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
       jmp       qword ptr [7FF8A81B6E68]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
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

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.ValidatorBenchmark.CheckItemsExists_Validation()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rsi,[rbx+198]
       test      rsi,rsi
       je        short M00_L00
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FF8A7DAF618]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M00_L02
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],rcx
       jne       short M00_L01
M00_L00:
       mov       [rsp+20],rsi
       mov       rbx,[rbx+88]
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
       mov       r11,7FF8A7B808D8
       call      qword ptr [r11]
       jmp       short M00_L00
M00_L02:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FF8A7C36850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
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
       call      qword ptr [7FF8A7DAF618]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M00_L04
       mov       rcx,rax
       mov       r11,7FF8A7B808D0
       call      qword ptr [r11]
       jmp       near ptr M00_L00
M00_L04:
       mov       rdx,rsi
       mov       rcx,7FF8A827F1B0
       call      qword ptr [7FF8A8246C28]
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
       jmp       qword ptr [7FF8A81C6E68]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
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

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.ValidatorBenchmark.ArgumentNotNullOrEmpty_NoValidation_ForComparison()
       push      rbx
       sub       rsp,10
       mov       rdx,2305F940AA0
       mov       [rsp+8],rdx
       mov       rbx,[rcx+88]
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

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.ValidatorBenchmark.ArgumentNotNullOrEmpty_Validation_Inlining_ForComparison()
       push      rbx
       sub       rsp,10
       xor       eax,eax
       mov       [rsp+8],rax
       mov       rdx,1ACA5A00AA0
       mov       [rsp+8],rdx
       mov       rbx,[rcx+88]
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

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.ValidatorBenchmark.ArgumentNotNullOrEmpty_Validation_ForComparison()
       push      rbx
       sub       rsp,10
       xor       eax,eax
       mov       [rsp+8],rax
       mov       rdx,32506A00AA0
       mov       [rsp+8],rdx
       mov       rbx,[rcx+88]
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

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rcx,249378A0AA0
       call      qword ptr [7FF8A7B5A5D0]; System.RuntimeType.IsEnumDefined(System.Object)
       test      eax,eax
       je        short M00_L00
       mov       dword ptr [rsp+20],2
       mov       rcx,[rbx+88]
       cmp       [rcx],cl
       lea       rcx,[rsp+20]
       call      qword ptr [7FF8A8226C40]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Core.Status, DotNetTips.Spargine.10.Core]](DotNetTips.Spargine.Core.Status ByRef)
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L00:
       call      qword ptr [7FF8A8226B68]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L01
       call      qword ptr [7FF8A822FF60]
       mov       rbx,rax
M00_L01:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,24937894EE8
       call      qword ptr [7FF8A80541F8]
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
       call      qword ptr [7FF8A7C1C9A8]; System.Object.GetType()
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
       call      00007FF90785E010
       mov       rcx,208A28009D8
       mov       rbp,[rcx]
       cmp       eax,1A
       jae       near ptr M01_L60
       mov       ecx,eax
       mov       rcx,[rbp+rcx*8+10]
       mov       rdi,rcx
M01_L05:
       mov       rcx,24937890020
       cmp       rdi,rcx
       je        near ptr M01_L25
       mov       rcx,24937893120
       cmp       rdi,rcx
       jne       near ptr M01_L26
M01_L06:
       mov       rcx,[rbx+18]
       call      00007FF90785E010
       mov       rcx,208A28009D8
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
       call      qword ptr [7FF8A7C17C30]; System.RuntimeType.InitializeCache()
       jmp       near ptr M01_L07
M01_L18:
       mov       rcx,rbx
       call      qword ptr [7FF8A7C17C30]; System.RuntimeType.InitializeCache()
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
       call      qword ptr [7FF8A80DC2A0]; System.Enum.<GetEnumInfo>g__InitializeEnumInfo|5_0[[System.UInt32, System.Private.CoreLib]](System.RuntimeType, Boolean)
       jmp       short M01_L12
M01_L22:
       mov       ecx,3AD
       mov       rdx,7FF8A7B54000
       call      qword ptr [7FF8A7E37798]
       mov       rcx,rax
       call      qword ptr [7FF8A822EE38]
       int       3
M01_L23:
       mov       rcx,rdi
       mov       rdx,rbx
       call      qword ptr [7FF8A822F378]
       test      eax,eax
       jne       near ptr M01_L03
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       call      qword ptr [7FF8A822F318]
       mov       rcx,rax
       mov       rdx,rdi
       mov       r8,rbx
       call      qword ptr [7FF8A822F330]
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FF8A80DDED8]
       mov       rcx,rbp
       call      CORINFO_HELP_THROW
       int       3
M01_L24:
       call      qword ptr [7FF8A822F300]
       int       3
M01_L25:
       mov       rcx,rbx
       call      qword ptr [7FF8A8224CF0]; System.Enum.GetNamesNoCopy(System.RuntimeType)
       mov       rbx,rax
       mov       rdx,rsi
       mov       rcx,offset MT_System.String
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,7FF8A82590F0
       call      qword ptr [7FF8A8226B80]
       not       eax
       shr       eax,1F
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L26:
       mov       rcx,249378953E0
       cmp       rdi,rcx
       je        near ptr M01_L06
       mov       rcx,24937893070
       cmp       rdi,rcx
       je        near ptr M01_L06
       mov       rcx,24937892ED0
       cmp       rdi,rcx
       je        near ptr M01_L06
       mov       rcx,249378953B8
       cmp       rdi,rcx
       je        near ptr M01_L06
       mov       rcx,24937892E58
       cmp       rdi,rcx
       je        near ptr M01_L06
       mov       rcx,24937895408
       cmp       rdi,rcx
       je        near ptr M01_L06
       mov       rcx,24937892C50
       cmp       rdi,rcx
       je        near ptr M01_L06
       mov       rcx,24937895390
       cmp       rdi,rcx
       je        near ptr M01_L06
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF8A822F348]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8A80D5878]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L27:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF8A822F360]
       mov       rcx,rax
       mov       rdx,rdi
       mov       r8,rbp
       call      qword ptr [7FF8A822F330]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8A80DDED8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L28:
       mov       rbp,rdi
       mov       rcx,rbp
       call      qword ptr [7FF8A7D8F2E8]; System.RuntimeType.get_IsActualEnum()
       test      eax,eax
       je        short M01_L29
       mov       rcx,rdi
       call      qword ptr [7FF8A7B5A588]; Precode of System.RuntimeType.GetEnumUnderlyingType()
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
       mov       rcx,249378953B8
       cmp       rbp,rcx
       jne       short M01_L30
       mov       ebp,5
       jmp       near ptr M01_L45
M01_L30:
       mov       rcx,24937892ED0
       cmp       rbp,rcx
       jne       short M01_L31
       mov       ebp,6
       jmp       near ptr M01_L45
M01_L31:
       mov       rcx,249378953E0
       cmp       rbp,rcx
       jne       short M01_L32
       mov       ebp,7
       jmp       near ptr M01_L45
M01_L32:
       mov       rcx,24937893070
       cmp       rbp,rcx
       jne       short M01_L33
       mov       ebp,8
       jmp       near ptr M01_L45
M01_L33:
       mov       rcx,24937893120
       cmp       rbp,rcx
       jne       short M01_L34
       mov       ebp,9
       jmp       near ptr M01_L45
M01_L34:
       mov       rcx,24937892E58
       cmp       rbp,rcx
       jne       short M01_L35
       mov       ebp,0A
       jmp       near ptr M01_L45
M01_L35:
       mov       rcx,24937895408
       cmp       rbp,rcx
       jne       short M01_L36
       mov       ebp,0B
       jmp       near ptr M01_L45
M01_L36:
       mov       rcx,24937892C50
       cmp       rbp,rcx
       jne       short M01_L37
       mov       ebp,0C
       jmp       near ptr M01_L45
M01_L37:
       mov       rcx,24937895368
       cmp       rbp,rcx
       jne       short M01_L38
       mov       ebp,3
       jmp       near ptr M01_L45
M01_L38:
       mov       rcx,24937895390
       cmp       rbp,rcx
       jne       short M01_L39
       mov       ebp,4
       jmp       near ptr M01_L45
M01_L39:
       mov       rcx,24937895430
       cmp       rbp,rcx
       jne       short M01_L40
       mov       ebp,0D
       jmp       short M01_L45
M01_L40:
       mov       rcx,24937895458
       cmp       rbp,rcx
       jne       short M01_L41
       mov       ebp,0E
       jmp       short M01_L45
M01_L41:
       mov       rcx,249378962E0
       cmp       rbp,rcx
       jne       short M01_L42
       mov       ebp,0F
       jmp       short M01_L45
M01_L42:
       mov       rcx,24937892AC8
       cmp       rbp,rcx
       jne       short M01_L43
       mov       ebp,10
       jmp       short M01_L45
M01_L43:
       mov       rcx,24937890020
       cmp       rbp,rcx
       jne       short M01_L44
       mov       ebp,12
       jmp       short M01_L45
M01_L44:
       mov       rcx,249378A0B08
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
       call      qword ptr [7FF8A7C17C30]; System.RuntimeType.InitializeCache()
M01_L47:
       mov       [rax+98],ebp
       jmp       near ptr M01_L08
M01_L48:
       cmp       ebp,0A
       ja        short M01_L49
       mov       edx,ebp
       lea       rcx,[7FF8A7CAF320]
       mov       ecx,[rcx+rdx*4]
       lea       rax,[M01_L00]
       add       rcx,rax
       jmp       rcx
M01_L49:
       mov       rdx,24937893048
       cmp       rdi,rdx
       je        near ptr M01_L58
       jmp       near ptr M01_L56
       mov       rdx,rsi
       mov       rcx,offset MT_System.SByte
       call      System.Runtime.CompilerServices.CastHelpers.Unbox(System.Runtime.CompilerServices.MethodTable*, System.Object)
       movzx     edx,byte ptr [rax]
       mov       rcx,rbx
       call      qword ptr [7FF8A822EF40]
       jmp       near ptr M01_L13
       mov       rdx,rsi
       mov       rcx,offset MT_System.Byte
       call      System.Runtime.CompilerServices.CastHelpers.Unbox(System.Runtime.CompilerServices.MethodTable*, System.Object)
       movzx     edx,byte ptr [rax]
       mov       rcx,rbx
       call      qword ptr [7FF8A822EF40]
       jmp       near ptr M01_L13
       mov       rdx,rsi
       mov       rcx,offset MT_System.Int16
       call      System.Runtime.CompilerServices.CastHelpers.Unbox(System.Runtime.CompilerServices.MethodTable*, System.Object)
       movzx     edx,word ptr [rax]
       mov       rcx,rbx
       call      qword ptr [7FF8A822EF28]
       jmp       near ptr M01_L13
       mov       rdx,rsi
       mov       rcx,offset MT_System.UInt16
       call      System.Runtime.CompilerServices.CastHelpers.Unbox(System.Runtime.CompilerServices.MethodTable*, System.Object)
       movzx     edx,word ptr [rax]
       mov       rcx,rbx
       call      qword ptr [7FF8A822EF28]
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
       call      qword ptr [7FF8A822F5E8]
       jmp       short M01_L54
M01_L53:
       mov       rcx,rax
       mov       edx,esi
       call      qword ptr [7FF8A822F900]; System.SpanHelpers.NonPackedIndexOfValueType[[System.Int32, System.Private.CoreLib],[System.SpanHelpers+DontNegate`1[[System.Int32, System.Private.CoreLib]], System.Private.CoreLib]](Int32 ByRef, Int32, Int32)
M01_L54:
       not       eax
       shr       eax,1F
       jmp       near ptr M01_L13
       mov       rdx,rsi
       mov       rcx,offset MT_System.UInt32
       call      System.Runtime.CompilerServices.CastHelpers.Unbox(System.Runtime.CompilerServices.MethodTable*, System.Object)
       mov       edx,[rax]
       mov       rcx,rbx
       call      qword ptr [7FF8A8226BE0]; System.Enum.IsDefinedPrimitive[[System.UInt32, System.Private.CoreLib]](System.RuntimeType, UInt32)
       jmp       near ptr M01_L13
       mov       rdx,rsi
       mov       rcx,offset MT_System.Int64
       call      System.Runtime.CompilerServices.CastHelpers.Unbox(System.Runtime.CompilerServices.MethodTable*, System.Object)
       mov       rdx,[rax]
       mov       rcx,rbx
       call      qword ptr [7FF8A822EF10]
       jmp       near ptr M01_L13
       mov       rdx,rsi
       mov       rcx,offset MT_System.UInt64
       call      System.Runtime.CompilerServices.CastHelpers.Unbox(System.Runtime.CompilerServices.MethodTable*, System.Object)
       mov       rdx,[rax]
       mov       rcx,rbx
       call      qword ptr [7FF8A822EF10]
       jmp       near ptr M01_L13
       mov       rdx,rsi
       mov       rcx,offset MT_System.Single
       call      System.Runtime.CompilerServices.CastHelpers.Unbox(System.Runtime.CompilerServices.MethodTable*, System.Object)
       vmovss    xmm1,dword ptr [rax]
       mov       rcx,rbx
       call      qword ptr [7FF8A822EEF8]
       jmp       near ptr M01_L13
       mov       rdx,rsi
       mov       rcx,offset MT_System.Double
       call      System.Runtime.CompilerServices.CastHelpers.Unbox(System.Runtime.CompilerServices.MethodTable*, System.Object)
       vmovsd    xmm1,qword ptr [rax]
       mov       rcx,rbx
       call      qword ptr [7FF8A822EEE0]
       jmp       near ptr M01_L13
       mov       rcx,offset MT_System.Char
       cmp       [rsi],rcx
       je        short M01_L55
       mov       rdx,rsi
       call      System.Runtime.CompilerServices.CastHelpers.Unbox(System.Runtime.CompilerServices.MethodTable*, System.Object)
M01_L55:
       movzx     edx,word ptr [rsi+8]
       mov       rcx,rbx
       call      qword ptr [7FF8A822EF58]
       jmp       near ptr M01_L13
M01_L56:
       mov       rdx,24937895480
       cmp       rdi,rdx
       je        short M01_L57
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF8A822F348]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF8A80D5878]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M01_L57:
       mov       rdx,rsi
       mov       rcx,offset MT_System.UIntPtr
       call      System.Runtime.CompilerServices.CastHelpers.Unbox(System.Runtime.CompilerServices.MethodTable*, System.Object)
       mov       rdx,[rax]
       mov       rcx,rbx
       call      qword ptr [7FF8A822EEC8]
       jmp       short M01_L59
M01_L58:
       mov       rdx,rsi
       mov       rcx,offset MT_System.IntPtr
       call      System.Runtime.CompilerServices.CastHelpers.Unbox(System.Runtime.CompilerServices.MethodTable*, System.Object)
       mov       rdx,[rax]
       mov       rcx,rbx
       call      qword ptr [7FF8A822EEC8]
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

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rsi,[rbx+198]
       test      rsi,rsi
       je        short M00_L01
       mov       rdi,rsi
       mov       rdx,rdi
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FF8A7D6F618]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        near ptr M00_L03
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],rcx
       jne       near ptr M00_L02
       mov       ebp,[rax+10]
M00_L00:
       test      ebp,ebp
       jle       near ptr M00_L08
       mov       [rsp+28],rdi
       mov       rbx,[rbx+88]
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
       call      qword ptr [7FF8A80B4C60]
       mov       ecx,20EB
       mov       rdx,7FF8A7EC4D10
       call      qword ptr [7FF8A7E17798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF8A7EC4D10
       call      qword ptr [7FF8A7E17798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8A7BF7840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0F32
       mov       rdx,7FF8A7EC4D10
       call      qword ptr [7FF8A7E17798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8A7BF7840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF8A820EFB8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF8A820EFD0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L02:
       mov       rcx,rax
       mov       r11,7FF8A7B408F0
       call      qword ptr [r11]
       mov       ebp,eax
       jmp       near ptr M00_L00
M00_L03:
       mov       rdx,rdi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FF8A7BF6850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M00_L04
       mov       rcx,rax
       mov       edx,1
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax]
       mov       ebp,eax
       test      ebp,ebp
       jl        short M00_L04
       jmp       near ptr M00_L00
M00_L04:
       mov       rdx,rdi
       mov       rcx,offset MT_System.Collections.ICollection
       call      qword ptr [7FF8A7D6F618]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M00_L05
       mov       rcx,rax
       mov       r11,7FF8A7B408E8
       call      qword ptr [r11]
       mov       ebp,eax
       jmp       near ptr M00_L00
M00_L05:
       mov       rdx,rdi
       mov       rcx,offset MT_System.Collections.Generic.IReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
       test      rax,rax
       je        short M00_L06
       mov       rcx,rax
       mov       r11,7FF8A7B408D8
       call      qword ptr [r11]
       mov       ebp,eax
       jmp       near ptr M00_L00
M00_L06:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Generic.IList<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FF8A7D6F618]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       jne       short M00_L07
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       call      qword ptr [7FF8A7E1F258]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FF8A80B4B88]
M00_L07:
       mov       rcx,rdi
       mov       r11,7FF8A7B408D0
       call      qword ptr [r11]
       mov       ebp,eax
       jmp       near ptr M00_L00
M00_L08:
       lea       rcx,[rsp+30]
       mov       edx,27
       mov       r8d,2
       call      qword ptr [7FF8A7E14E70]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler..ctor(Int32, Int32)
       mov       ecx,[rsp+40]
       mov       edx,[rsp+50]
       cmp       ecx,edx
       ja        near ptr M00_L13
       mov       rax,[rsp+48]
       mov       r8d,ecx
       lea       rax,[rax+r8*2]
       sub       edx,ecx
       cmp       edx,21
       jb        short M00_L09
       vmovups   ymm0,[7FF8A7C8D820]
       vmovups   [rax],ymm0
       vmovups   ymm0,[7FF8A7C8D840]
       vmovups   [rax+20],ymm0
       mov       word ptr [rax+40],20
       mov       ecx,[rsp+40]
       add       ecx,21
       mov       [rsp+40],ecx
       jmp       short M00_L10
M00_L09:
       lea       rcx,[rsp+30]
       mov       rdx,21501230AF8
       call      qword ptr [7FF8A8204558]
M00_L10:
       lea       rcx,[rsp+30]
       mov       edx,1
       call      qword ptr [7FF8A7E14DB0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Int32, System.Private.CoreLib]](Int32)
       mov       ecx,[rsp+40]
       mov       edx,[rsp+50]
       cmp       ecx,edx
       ja        short M00_L13
       mov       rax,[rsp+48]
       mov       r8d,ecx
       lea       rax,[rax+r8*2]
       sub       edx,ecx
       cmp       edx,5
       jb        short M00_L11
       mov       rcx,64006E00610020
       mov       [rax],rcx
       mov       word ptr [rax+8],20
       mov       ecx,[rsp+40]
       add       ecx,5
       mov       [rsp+40],ecx
       jmp       short M00_L12
M00_L11:
       lea       rcx,[rsp+30]
       mov       rdx,21501230B50
       call      qword ptr [7FF8A8204558]
M00_L12:
       lea       rcx,[rsp+30]
       mov       edx,7FFFFFFF
       call      qword ptr [7FF8A7E14DB0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Int32, System.Private.CoreLib]](Int32)
       mov       ecx,[rsp+40]
       mov       edx,[rsp+50]
       cmp       ecx,edx
       jbe       short M00_L14
M00_L13:
       call      qword ptr [7FF8A7D67198]
       int       3
M00_L14:
       mov       rax,[rsp+48]
       mov       r8d,ecx
       lea       rax,[rax+r8*2]
       sub       edx,ecx
       je        short M00_L15
       mov       word ptr [rax],2E
       mov       ecx,[rsp+40]
       inc       ecx
       mov       [rsp+40],ecx
       jmp       short M00_L16
M00_L15:
       lea       rcx,[rsp+30]
       mov       rdx,21501220658
       call      qword ptr [7FF8A8204558]
M00_L16:
       lea       rcx,[rsp+30]
       call      qword ptr [7FF8A7E14EA0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L17
       call      qword ptr [7FF8A820F270]
       mov       rbx,rax
M00_L17:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,21501230AA0
       call      qword ptr [7FF8A80341F8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 945
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
       jmp       qword ptr [7FF8A8186E98]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
; Total bytes of code 116
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
       je        near ptr M02_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M02_L01
       test      rsi,rsi
       je        short M02_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M02_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M02_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FF9078A50F0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF8A7BF5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF8A7BF5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
M02_L00:
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
M02_L01:
       test      rsi,rsi
       je        short M02_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M02_L03
M02_L02:
       mov       rax,21501220008
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M02_L03:
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
M02_L04:
       call      qword ptr [7FF8A820F798]
       int       3
; Total bytes of code 244
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
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
       push      rsi
       push      rbx
       test      rdx,rdx
       je        short M04_L02
       mov       rax,[rdx]
       cmp       rax,rcx
       je        short M04_L02
       mov       r8,1D46C000038
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
       jne       short M04_L05
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
       test      esi,esi
       jne       short M04_L06
       xor       edx,edx
       jmp       short M04_L02
M04_L06:
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FF8A7BFD908]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny_NoCacheLookup(Void*, System.Object)
; Total bytes of code 168
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       rcx,[rbx]
       call      qword ptr [7FF8D755C570]
       mov       rcx,rax
       call      qword ptr [7FF8D75590A0]; Precode of System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       lea       rcx,[rbx+8]
       call      qword ptr [7FF8D7558FE8]; CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,30
       pop       rbx
       ret
; Total bytes of code 51
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
       call      qword ptr [7FF8D755A098]
       mov       rcx,[rax]
       imul      edx,edi,0B
       add       edx,esi
       mov       eax,100
       cmp       edx,100
       cmovle    edx,eax
       cmp       [rcx],ecx
       call      qword ptr [7FF8D75798B8]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
       mov       [rbx+8],rax
       test      rax,rax
       je        short M06_L01
       lea       rcx,[rax+10]
       mov       eax,[rax+8]
M06_L00:
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
M06_L01:
       xor       ecx,ecx
       xor       eax,eax
       jmp       short M06_L00
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
       jne       short M07_L03
M07_L00:
       lea       rdx,[rbx+18]
       mov       r8d,[rbx+10]
       mov       edi,[rdx+8]
       cmp       r8d,edi
       ja        near ptr M07_L10
       mov       rdx,[rdx]
       mov       ecx,r8d
       lea       rbp,[rdx+rcx*2]
       sub       edi,r8d
       mov       rcx,[rbx]
       test      esi,esi
       jl        short M07_L05
       mov       [rsp+40],rbp
       mov       [rsp+48],edi
       lea       rdx,[rsp+40]
       lea       r8,[rsp+50]
       mov       ecx,esi
       call      qword ptr [7FF8D7580CF8]; Precode of System.Number.TryUInt32ToDecStr[[System.Char, System.Private.CoreLib]](UInt32, System.Span`1<Char>, Int32 ByRef)
M07_L01:
       test      eax,eax
       jne       short M07_L02
       mov       rcx,rbx
       call      qword ptr [7FF8D7574FF8]
       jmp       short M07_L00
M07_L02:
       mov       eax,[rsp+50]
       add       [rbx+10],eax
       jmp       short M07_L04
M07_L03:
       mov       rcx,rbx
       mov       edx,esi
       xor       r8d,r8d
       call      qword ptr [7FF8D7581B50]
M07_L04:
       nop
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M07_L05:
       test      rcx,rcx
       je        short M07_L06
       call      qword ptr [7FF8D7571260]; Precode of System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider)
       jmp       short M07_L07
M07_L06:
       call      qword ptr [7FF8D7571248]; Precode of System.Globalization.NumberFormatInfo.get_CurrentInfo()
M07_L07:
       mov       r8,[rax+28]
       test      r8,r8
       jne       short M07_L08
       xor       r9d,r9d
       xor       r8d,r8d
       jmp       short M07_L09
M07_L08:
       lea       r9,[r8+0C]
       mov       r8d,[r8+8]
M07_L09:
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
       call      qword ptr [7FF8D7580CE0]
       jmp       near ptr M07_L01
M07_L10:
       call      qword ptr [7FF8D756F2B8]
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
       ja        short M08_L01
       mov       rcx,[rcx]
       mov       [rsp+28],rcx
       mov       [rsp+30],eax
       lea       rcx,[rsp+28]
       call      qword ptr [7FF8D756BB28]; Precode of System.String.Ctor(System.ReadOnlySpan`1<Char>)
       mov       rdi,rax
       mov       rbp,[rbx+8]
       xor       eax,eax
       mov       [rbx+8],rax
       mov       [rsi],rax
       mov       [rsi+8],rax
       mov       [rbx+10],eax
       test      rbp,rbp
       je        short M08_L00
       call      qword ptr [7FF8D755A098]
       mov       rcx,[rax]
       mov       rdx,rbp
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FF8D75798C0]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
M08_L00:
       mov       rax,rdi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M08_L01:
       call      qword ptr [7FF8D756F2B8]
       int       3
; Total bytes of code 126
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.ValidatorBenchmark.EnsureNotEmpty()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-20],rax
       mov       rbx,rcx
       mov       rsi,[rbx+198]
       test      rsi,rsi
       je        short M00_L02
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FF8A7D9F618]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        near ptr M00_L04
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],rcx
       jne       near ptr M00_L03
       mov       edi,[rax+10]
M00_L00:
       test      edi,edi
       je        near ptr M00_L07
M00_L01:
       mov       [rbp-20],rsi
       mov       rbx,[rbx+88]
       mov       rdx,[rbp-20]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M00_L02:
       call      qword ptr [7FF8A80E4C60]
       mov       ecx,20EB
       mov       rdx,7FF8A7EF4D10
       call      qword ptr [7FF8A7E47798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF8A7EF4D10
       call      qword ptr [7FF8A7E47798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8A7C27840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0F32
       mov       rdx,7FF8A7EF4D10
       call      qword ptr [7FF8A7E47798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8A7C27840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF8A823F3D8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF8A823F3F0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L03:
       mov       rcx,rax
       mov       r11,7FF8A7B70920
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L00
M00_L04:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FF8A7C26850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M00_L05
       mov       rcx,rax
       mov       edx,1
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax]
       mov       edi,eax
       test      edi,edi
       jl        short M00_L05
       jmp       near ptr M00_L00
M00_L05:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.ICollection
       call      qword ptr [7FF8A7D9F618]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M00_L06
       mov       rcx,rax
       mov       r11,7FF8A7B70918
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L00
M00_L06:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Generic.IReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
       test      rax,rax
       je        near ptr M00_L11
       jmp       short M00_L09
M00_L07:
       call      qword ptr [7FF8A8236BF8]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L08
       call      qword ptr [7FF8A823F408]
       mov       rbx,rax
M00_L08:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.InvalidValueException<System.Collections.Generic.IEnumerable<DotNetTips.Spargine.Tester.Models.RefTypes.Person>>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r8,rsi
       call      qword ptr [7FF8A823F420]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M00_L09:
       mov       rcx,rax
       mov       r11,7FF8A7B70908
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L01
       call      qword ptr [7FF8A8236BF8]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L10
       call      qword ptr [7FF8A823F408]
       mov       rbx,rax
M00_L10:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.InvalidValueException<System.Collections.Generic.IEnumerable<DotNetTips.Spargine.Tester.Models.RefTypes.Person>>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r8,rsi
       call      qword ptr [7FF8A823F420]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M00_L11:
       mov       rcx,rsi
       mov       r11,7FF8A7B708F0
       call      qword ptr [r11]
       mov       [rbp-28],rax
       mov       rcx,[rbp-28]
       mov       r11,7FF8A7B708F8
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L13
       call      qword ptr [7FF8A8236BF8]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L12
       call      qword ptr [7FF8A823F408]
       mov       rbx,rax
M00_L12:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.InvalidValueException<System.Collections.Generic.IEnumerable<DotNetTips.Spargine.Tester.Models.RefTypes.Person>>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r8,rsi
       call      qword ptr [7FF8A823F420]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M00_L13:
       mov       rcx,[rbp-28]
       mov       r11,7FF8A7B70900
       call      qword ptr [r11]
       jmp       near ptr M00_L01
       sub       rsp,28
       cmp       qword ptr [rbp-28],0
       je        short M00_L14
       mov       rcx,[rbp-28]
       mov       r11,7FF8A7B70900
       call      qword ptr [r11]
M00_L14:
       nop
       add       rsp,28
       ret
; Total bytes of code 748
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
       jmp       qword ptr [7FF8A81B6E68]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
; Total bytes of code 116
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
       je        near ptr M02_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M02_L01
       test      rsi,rsi
       je        short M02_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M02_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M02_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FF9078A50F0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF8A7C25818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF8A7C25818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
M02_L00:
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
M02_L01:
       test      rsi,rsi
       je        short M02_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M02_L03
M02_L02:
       mov       rax,20854920008
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M02_L03:
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
M02_L04:
       call      qword ptr [7FF8A823F798]
       int       3
; Total bytes of code 244
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
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
       push      rsi
       push      rbx
       test      rdx,rdx
       je        short M04_L02
       mov       rax,[rdx]
       cmp       rax,rcx
       je        short M04_L02
       mov       r8,1C7BF800038
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
       jne       short M04_L05
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
       test      esi,esi
       jne       short M04_L06
       xor       edx,edx
       jmp       short M04_L02
M04_L06:
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FF8A7C2D908]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny_NoCacheLookup(Void*, System.Object)
; Total bytes of code 168
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.ValidatorBenchmark.EnsureNotNullOrEmpty()
       push      rbx
       sub       rsp,10
       xor       eax,eax
       mov       [rsp+8],rax
       mov       rdx,1F37DDE0AA0
       mov       [rsp+8],rdx
       mov       rbx,[rcx+88]
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

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rcx,1EACC020AA0
       movzx     ecx,word ptr [rcx+rsi]
       cmp       ecx,100
       jge       short M00_L02
       mov       rax,7FF8D68E6B88
       test      byte ptr [rax+rcx],80
       jne       short M00_L03
M00_L01:
       mov       rcx,1EACC020AA0
       mov       [rsp+28],rcx
       mov       rbx,[rbx+88]
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
       call      qword ptr [7FF8A822EE50]
       test      eax,eax
       je        short M00_L01
M00_L03:
       add       rsi,2
       dec       edi
       jne       short M00_L00
       call      qword ptr [7FF8A8226B20]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L04
       call      qword ptr [7FF8A822F090]
       mov       rbx,rax
M00_L04:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ArgumentInvalidException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,2DB
       mov       rdx,7FF8A7EE2E38
       call      qword ptr [7FF8A7E37798]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF8A80DFAB0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 219
```

