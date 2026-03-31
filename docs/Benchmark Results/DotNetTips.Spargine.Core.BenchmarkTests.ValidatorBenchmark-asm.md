## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.ValidatorBenchmark.CheckItemsExists_NoValidation()
       push      rbx
       sub       rsp,10
       mov       rdx,[rcx+138]
       mov       [rsp+8],rdx
       mov       rbx,[rcx+60]
       mov       rdx,[rsp+8]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,10
       pop       rbx
       ret
; Total bytes of code 47
```

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.ValidatorBenchmark.CheckItemsExists_Validation_Inlining()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rsi,[rbx+138]
       test      rsi,rsi
       je        short M00_L00
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FF99781F9D8]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M00_L02
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],rcx
       jne       short M00_L01
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
       mov       rcx,rax
       mov       r11,7FF997760990
       call      qword ptr [r11]
       jmp       short M00_L00
M00_L02:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FF997816850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
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
       call      qword ptr [7FF99781F9D8]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M00_L04
       mov       rcx,rax
       mov       r11,7FF997760988
       call      qword ptr [r11]
       jmp       near ptr M00_L00
M00_L04:
       mov       rdx,rsi
       mov       rcx,7FF997E8D5C0
       call      qword ptr [7FF997E37798]
       jmp       near ptr M00_L00
; Total bytes of code 235
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
       jmp       qword ptr [7FF997DB7468]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
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

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.ValidatorBenchmark.CheckItemsExists_Validation()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rsi,[rbx+138]
       test      rsi,rsi
       je        short M00_L00
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FF99780F9D8]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M00_L02
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],rcx
       jne       short M00_L01
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
       mov       rcx,rax
       mov       r11,7FF997750990
       call      qword ptr [r11]
       jmp       short M00_L00
M00_L02:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FF997806850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
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
       call      qword ptr [7FF99780F9D8]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M00_L04
       mov       rcx,rax
       mov       r11,7FF997750988
       call      qword ptr [r11]
       jmp       near ptr M00_L00
M00_L04:
       mov       rdx,rsi
       mov       rcx,7FF997E7D5C8
       call      qword ptr [7FF997E278E8]
       jmp       near ptr M00_L00
; Total bytes of code 235
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
       jmp       qword ptr [7FF997DA7498]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
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

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.ValidatorBenchmark.ArgumentNotNullOrEmpty_NoValidation()
       push      rbx
       sub       rsp,10
       mov       rdx,242046A06C0
       mov       [rsp+8],rdx
       mov       rbx,[rcx+60]
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

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.ValidatorBenchmark.ArgumentNotNullOrEmpty_Validation_Inlining()
       push      rbx
       sub       rsp,10
       xor       eax,eax
       mov       [rsp+8],rax
       mov       rdx,232E8E006C0
       mov       [rsp+8],rdx
       mov       rbx,[rcx+60]
       mov       rdx,[rsp+8]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,10
       pop       rbx
       ret
; Total bytes of code 57
```

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.ValidatorBenchmark.ArgumentNotNullOrEmpty_Validation()
       push      rbx
       sub       rsp,10
       xor       eax,eax
       mov       [rsp+8],rax
       mov       rdx,2BDA34406C0
       mov       [rsp+8],rdx
       mov       rbx,[rcx+60]
       mov       rdx,[rsp+8]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,10
       pop       rbx
       ret
; Total bytes of code 57
```

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rcx,23155D606C0
       call      qword ptr [7FF99776A5D0]; System.RuntimeType.IsEnumDefined(System.Object)
       test      eax,eax
       je        short M00_L00
       mov       dword ptr [rsp+20],2
       mov       rcx,[rbx+60]
       cmp       [rcx],cl
       lea       rcx,[rsp+20]
       call      qword ptr [7FF997E47948]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Core.Status, DotNetTips.Spargine.10.Core]](DotNetTips.Spargine.Core.Status ByRef)
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L00:
       call      qword ptr [7FF997E47840]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L01
       call      qword ptr [7FF997ED4AF8]
       mov       rbx,rax
M00_L01:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,23155D51640
       call      qword ptr [7FF997C2F8B8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 159
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
       call      qword ptr [7FF9979F61C0]; System.Object.GetType()
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
       call      00007FF9F744EFD0
       mov       rcx,1F0C0C00B28
       mov       rbp,[rcx]
       cmp       eax,1A
       jae       near ptr M01_L60
       mov       ecx,eax
       mov       rcx,[rbp+rcx*8+10]
       mov       rdi,rcx
M01_L05:
       mov       rcx,23155D50020
       cmp       rdi,rcx
       je        near ptr M01_L25
       mov       rcx,23155D53E20
       cmp       rdi,rcx
       jne       near ptr M01_L26
M01_L06:
       mov       rcx,[rbx+18]
       call      00007FF9F744EFD0
       mov       rcx,1F0C0C00B28
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
       call      qword ptr [7FF9979F56C8]; System.RuntimeType.InitializeCache()
       jmp       near ptr M01_L07
M01_L18:
       mov       rcx,rbx
       call      qword ptr [7FF9979F56C8]; System.RuntimeType.InitializeCache()
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
       call      qword ptr [7FF997CFD500]; System.Enum.<GetEnumInfo>g__InitializeEnumInfo|5_0[[System.UInt32, System.Private.CoreLib]](System.RuntimeType, Boolean)
       jmp       short M01_L12
M01_L22:
       mov       ecx,3AD
       mov       rdx,7FF997764000
       call      qword ptr [7FF99782F210]
       mov       rcx,rax
       call      qword ptr [7FF997E4FCA8]
       int       3
M01_L23:
       mov       rcx,rdi
       mov       rdx,rbx
       call      qword ptr [7FF997ED4180]
       test      eax,eax
       jne       near ptr M01_L03
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       call      qword ptr [7FF997ED4120]
       mov       rcx,rax
       mov       rdx,rdi
       mov       r8,rbx
       call      qword ptr [7FF997ED4138]
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FF997CFF0F0]
       mov       rcx,rbp
       call      CORINFO_HELP_THROW
       int       3
M01_L24:
       call      qword ptr [7FF997ED4108]
       int       3
M01_L25:
       mov       rcx,rbx
       call      qword ptr [7FF997E45938]; System.Enum.GetNamesNoCopy(System.RuntimeType)
       mov       rbx,rax
       mov       rdx,rsi
       mov       rcx,offset MT_System.String
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,7FF997E7C660
       call      qword ptr [7FF997E47858]
       not       eax
       shr       eax,1F
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L26:
       mov       rcx,23155D56240
       cmp       rdi,rcx
       je        near ptr M01_L06
       mov       rcx,23155D53D70
       cmp       rdi,rcx
       je        near ptr M01_L06
       mov       rcx,23155D53BD0
       cmp       rdi,rcx
       je        near ptr M01_L06
       mov       rcx,23155D56218
       cmp       rdi,rcx
       je        near ptr M01_L06
       mov       rcx,23155D53B58
       cmp       rdi,rcx
       je        near ptr M01_L06
       mov       rcx,23155D56268
       cmp       rdi,rcx
       je        near ptr M01_L06
       mov       rcx,23155D53950
       cmp       rdi,rcx
       je        near ptr M01_L06
       mov       rcx,23155D561F0
       cmp       rdi,rcx
       je        near ptr M01_L06
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF997ED4150]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF997DC4378]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L27:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF997ED4168]
       mov       rcx,rax
       mov       rdx,rdi
       mov       r8,rbp
       call      qword ptr [7FF997ED4138]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF997CFF0F0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L28:
       mov       rbp,rdi
       mov       rcx,rbp
       call      qword ptr [7FF997AB7BA0]; System.RuntimeType.get_IsActualEnum()
       test      eax,eax
       je        short M01_L29
       mov       rcx,rdi
       call      qword ptr [7FF99776A588]; Precode of System.RuntimeType.GetEnumUnderlyingType()
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
       mov       rcx,23155D56218
       cmp       rbp,rcx
       jne       short M01_L30
       mov       ebp,5
       jmp       near ptr M01_L45
M01_L30:
       mov       rcx,23155D53BD0
       cmp       rbp,rcx
       jne       short M01_L31
       mov       ebp,6
       jmp       near ptr M01_L45
M01_L31:
       mov       rcx,23155D56240
       cmp       rbp,rcx
       jne       short M01_L32
       mov       ebp,7
       jmp       near ptr M01_L45
M01_L32:
       mov       rcx,23155D53D70
       cmp       rbp,rcx
       jne       short M01_L33
       mov       ebp,8
       jmp       near ptr M01_L45
M01_L33:
       mov       rcx,23155D53E20
       cmp       rbp,rcx
       jne       short M01_L34
       mov       ebp,9
       jmp       near ptr M01_L45
M01_L34:
       mov       rcx,23155D53B58
       cmp       rbp,rcx
       jne       short M01_L35
       mov       ebp,0A
       jmp       near ptr M01_L45
M01_L35:
       mov       rcx,23155D56268
       cmp       rbp,rcx
       jne       short M01_L36
       mov       ebp,0B
       jmp       near ptr M01_L45
M01_L36:
       mov       rcx,23155D53950
       cmp       rbp,rcx
       jne       short M01_L37
       mov       ebp,0C
       jmp       near ptr M01_L45
M01_L37:
       mov       rcx,23155D561C8
       cmp       rbp,rcx
       jne       short M01_L38
       mov       ebp,3
       jmp       near ptr M01_L45
M01_L38:
       mov       rcx,23155D561F0
       cmp       rbp,rcx
       jne       short M01_L39
       mov       ebp,4
       jmp       near ptr M01_L45
M01_L39:
       mov       rcx,23155D56290
       cmp       rbp,rcx
       jne       short M01_L40
       mov       ebp,0D
       jmp       short M01_L45
M01_L40:
       mov       rcx,23155D562B8
       cmp       rbp,rcx
       jne       short M01_L41
       mov       ebp,0E
       jmp       short M01_L45
M01_L41:
       mov       rcx,23155D56F38
       cmp       rbp,rcx
       jne       short M01_L42
       mov       ebp,0F
       jmp       short M01_L45
M01_L42:
       mov       rcx,23155D537C8
       cmp       rbp,rcx
       jne       short M01_L43
       mov       ebp,10
       jmp       short M01_L45
M01_L43:
       mov       rcx,23155D50020
       cmp       rbp,rcx
       jne       short M01_L44
       mov       ebp,12
       jmp       short M01_L45
M01_L44:
       mov       rcx,23155D60728
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
       call      qword ptr [7FF9979F56C8]; System.RuntimeType.InitializeCache()
M01_L47:
       mov       [rax+98],ebp
       jmp       near ptr M01_L08
M01_L48:
       cmp       ebp,0A
       ja        short M01_L49
       mov       edx,ebp
       lea       rcx,[7FF9978BD1D0]
       mov       ecx,[rcx+rdx*4]
       lea       rax,[M01_L00]
       add       rcx,rax
       jmp       rcx
M01_L49:
       mov       rdx,23155D53D48
       cmp       rdi,rdx
       je        near ptr M01_L58
       jmp       near ptr M01_L56
       mov       rdx,rsi
       mov       rcx,offset MT_System.SByte
       call      System.Runtime.CompilerServices.CastHelpers.Unbox(System.Runtime.CompilerServices.MethodTable*, System.Object)
       movzx     edx,byte ptr [rax]
       mov       rcx,rbx
       call      qword ptr [7FF997E4FD38]
       jmp       near ptr M01_L13
       mov       rdx,rsi
       mov       rcx,offset MT_System.Byte
       call      System.Runtime.CompilerServices.CastHelpers.Unbox(System.Runtime.CompilerServices.MethodTable*, System.Object)
       movzx     edx,byte ptr [rax]
       mov       rcx,rbx
       call      qword ptr [7FF997E4FD38]
       jmp       near ptr M01_L13
       mov       rdx,rsi
       mov       rcx,offset MT_System.Int16
       call      System.Runtime.CompilerServices.CastHelpers.Unbox(System.Runtime.CompilerServices.MethodTable*, System.Object)
       movzx     edx,word ptr [rax]
       mov       rcx,rbx
       call      qword ptr [7FF997E4FD20]
       jmp       near ptr M01_L13
       mov       rdx,rsi
       mov       rcx,offset MT_System.UInt16
       call      System.Runtime.CompilerServices.CastHelpers.Unbox(System.Runtime.CompilerServices.MethodTable*, System.Object)
       movzx     edx,word ptr [rax]
       mov       rcx,rbx
       call      qword ptr [7FF997E4FD20]
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
       call      qword ptr [7FF997ED43F0]
       jmp       short M01_L54
M01_L53:
       mov       rcx,rax
       mov       edx,esi
       call      qword ptr [7FF997ED4708]; System.SpanHelpers.NonPackedIndexOfValueType[[System.Int32, System.Private.CoreLib],[System.SpanHelpers+DontNegate`1[[System.Int32, System.Private.CoreLib]], System.Private.CoreLib]](Int32 ByRef, Int32, Int32)
M01_L54:
       not       eax
       shr       eax,1F
       jmp       near ptr M01_L13
       mov       rdx,rsi
       mov       rcx,offset MT_System.UInt32
       call      System.Runtime.CompilerServices.CastHelpers.Unbox(System.Runtime.CompilerServices.MethodTable*, System.Object)
       mov       edx,[rax]
       mov       rcx,rbx
       call      qword ptr [7FF997E478B8]; System.Enum.IsDefinedPrimitive[[System.UInt32, System.Private.CoreLib]](System.RuntimeType, UInt32)
       jmp       near ptr M01_L13
       mov       rdx,rsi
       mov       rcx,offset MT_System.Int64
       call      System.Runtime.CompilerServices.CastHelpers.Unbox(System.Runtime.CompilerServices.MethodTable*, System.Object)
       mov       rdx,[rax]
       mov       rcx,rbx
       call      qword ptr [7FF997E4FD08]
       jmp       near ptr M01_L13
       mov       rdx,rsi
       mov       rcx,offset MT_System.UInt64
       call      System.Runtime.CompilerServices.CastHelpers.Unbox(System.Runtime.CompilerServices.MethodTable*, System.Object)
       mov       rdx,[rax]
       mov       rcx,rbx
       call      qword ptr [7FF997E4FD08]
       jmp       near ptr M01_L13
       mov       rdx,rsi
       mov       rcx,offset MT_System.Single
       call      System.Runtime.CompilerServices.CastHelpers.Unbox(System.Runtime.CompilerServices.MethodTable*, System.Object)
       vmovss    xmm1,dword ptr [rax]
       mov       rcx,rbx
       call      qword ptr [7FF997E4FCF0]
       jmp       near ptr M01_L13
       mov       rdx,rsi
       mov       rcx,offset MT_System.Double
       call      System.Runtime.CompilerServices.CastHelpers.Unbox(System.Runtime.CompilerServices.MethodTable*, System.Object)
       vmovsd    xmm1,qword ptr [rax]
       mov       rcx,rbx
       call      qword ptr [7FF997E4FCD8]
       jmp       near ptr M01_L13
       mov       rcx,offset MT_System.Char
       cmp       [rsi],rcx
       je        short M01_L55
       mov       rdx,rsi
       call      System.Runtime.CompilerServices.CastHelpers.Unbox(System.Runtime.CompilerServices.MethodTable*, System.Object)
M01_L55:
       movzx     edx,word ptr [rsi+8]
       mov       rcx,rbx
       call      qword ptr [7FF997E4FD50]
       jmp       near ptr M01_L13
M01_L56:
       mov       rdx,23155D562E0
       cmp       rdi,rdx
       je        short M01_L57
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF997ED4150]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF997DC4378]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M01_L57:
       mov       rdx,rsi
       mov       rcx,offset MT_System.UIntPtr
       call      System.Runtime.CompilerServices.CastHelpers.Unbox(System.Runtime.CompilerServices.MethodTable*, System.Object)
       mov       rdx,[rax]
       mov       rcx,rbx
       call      qword ptr [7FF997E4FCC0]
       jmp       short M01_L59
M01_L58:
       mov       rdx,rsi
       mov       rcx,offset MT_System.IntPtr
       call      System.Runtime.CompilerServices.CastHelpers.Unbox(System.Runtime.CompilerServices.MethodTable*, System.Object)
       mov       rdx,[rax]
       mov       rcx,rbx
       call      qword ptr [7FF997E4FCC0]
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

