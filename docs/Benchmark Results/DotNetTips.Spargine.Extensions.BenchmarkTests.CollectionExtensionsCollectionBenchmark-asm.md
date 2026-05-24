## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.AsReadOnlySpan()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       test      rsi,rsi
       je        near ptr M00_L06
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L07
       mov       rcx,rsi
       mov       r11,7FF9E5B50DF0
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L01
       test      byte ptr [7FF9E648E268],1
       je        near ptr M00_L08
M00_L00:
       mov       rdx,1D70B400A98
       mov       rdi,[rdx]
       jmp       short M00_L02
M00_L01:
       movsxd    rdx,eax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r11,7FF9E5B50DF8
       xor       r8d,r8d
       call      qword ptr [r11]
M00_L02:
       test      rdi,rdi
       je        near ptr M00_L09
       lea       rsi,[rdi+10]
       mov       edi,[rdi+8]
M00_L03:
       test      edi,edi
       je        near ptr M00_L10
       mov       edx,edi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbp,rax
       lea       rcx,[rbp+10]
       mov       r8d,edi
       shl       r8,3
       cmp       r8,4000
       jbe       short M00_L04
       mov       rdx,rsi
       call      qword ptr [7FF9E63D7C00]
       jmp       short M00_L05
M00_L04:
       mov       rdx,rsi
       call      00007FFA45809170
       cmp       dword ptr [7FFA45B339A0],0
       jne       near ptr M00_L11
M00_L05:
       mov       [rsp+20],rbp
       mov       rbx,[rbx+60]
       mov       rdx,[rsp+20]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L06:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,65
       mov       rdx,7FF9E6018D68
       call      qword ptr [7FF9E5C0F300]
       mov       rsi,rax
       call      qword ptr [7FF9E63DC6A8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF9E63DC6C0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rdi,rax
       jmp       near ptr M00_L02
M00_L08:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L00
M00_L09:
       xor       esi,esi
       xor       edi,edi
       jmp       near ptr M00_L03
M00_L10:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1D70B400A98
       mov       rbp,[rcx]
       jmp       near ptr M00_L05
M00_L11:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L05
; Total bytes of code 451
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
       je        short M01_L03
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
M01_L03:
       xor       edx,edx
       jmp       short M01_L00
; Total bytes of code 88
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M02_L00
       ret
M02_L00:
       jmp       qword ptr [7FF9E5C05C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.AsReadOnlySpan()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       test      rsi,rsi
       je        near ptr M00_L05
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L06
       mov       rcx,rsi
       mov       r11,7FF9E5B40DD8
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L01
       test      byte ptr [7FF9E647E2D8],1
       je        near ptr M00_L07
M00_L00:
       mov       rdx,25168000A98
       mov       rdi,[rdx]
       jmp       short M00_L02
M00_L01:
       movsxd    rdx,eax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r11,7FF9E5B40DE0
       xor       r8d,r8d
       call      qword ptr [r11]
M00_L02:
       test      rdi,rdi
       je        near ptr M00_L08
       lea       rsi,[rdi+10]
       mov       edi,[rdi+8]
M00_L03:
       test      edi,edi
       je        near ptr M00_L09
       mov       edx,edi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbp,rax
       lea       rcx,[rbp+10]
       mov       r8d,edi
       shl       r8,3
       cmp       r8,4000
       ja        near ptr M00_L11
       mov       rdx,rsi
       call      00007FFA45809170
       cmp       dword ptr [7FFA45B339A0],0
       jne       near ptr M00_L10
M00_L04:
       mov       [rsp+20],rbp
       mov       rbx,[rbx+60]
       mov       rdx,[rsp+20]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L05:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,65
       mov       rdx,7FF9E5FF8D68
       call      qword ptr [7FF9E5BFF228]
       mov       rsi,rax
       call      qword ptr [7FF9E63DC138]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF9E63DC150]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L06:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rdi,rax
       jmp       near ptr M00_L02
M00_L07:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FF9E5BF5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L00
M00_L08:
       xor       esi,esi
       xor       edi,edi
       jmp       near ptr M00_L03
M00_L09:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FF9E5BF5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,25168000A98
       mov       rbp,[rcx]
       jmp       near ptr M00_L04
M00_L10:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L04
M00_L11:
       mov       rdx,rsi
       call      qword ptr [7FF9E619E9A0]
       jmp       near ptr M00_L04
; Total bytes of code 460
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
       test      rax,rax
       je        short M01_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       jmp       short M01_L00
; Total bytes of code 86
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M02_L00
       ret
M02_L00:
       jmp       qword ptr [7FF9E5BF5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.AsReadOnlySpan()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       test      rsi,rsi
       je        near ptr M00_L05
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L06
       mov       rcx,rsi
       mov       r11,7FF9E5B20DD8
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L01
       test      byte ptr [7FF9E645DB40],1
       je        near ptr M00_L07
M00_L00:
       mov       rdx,20888800A98
       mov       rdi,[rdx]
       jmp       short M00_L02
M00_L01:
       movsxd    rdx,eax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r11,7FF9E5B20DE0
       xor       r8d,r8d
       call      qword ptr [r11]
M00_L02:
       test      rdi,rdi
       je        near ptr M00_L08
       lea       rsi,[rdi+10]
       mov       edi,[rdi+8]
M00_L03:
       test      edi,edi
       je        near ptr M00_L09
       mov       edx,edi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbp,rax
       lea       rcx,[rbp+10]
       mov       r8d,edi
       shl       r8,3
       cmp       r8,4000
       ja        near ptr M00_L11
       mov       rdx,rsi
       call      00007FFA45809170
       cmp       dword ptr [7FFA45B339A0],0
       jne       near ptr M00_L10
M00_L04:
       mov       [rsp+20],rbp
       mov       rbx,[rbx+60]
       mov       rdx,[rsp+20]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L05:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,65
       mov       rdx,7FF9E5FD8D68
       call      qword ptr [7FF9E5BDF228]
       mov       rsi,rax
       call      qword ptr [7FF9E63BC108]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF9E63BC120]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L06:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rdi,rax
       jmp       near ptr M00_L02
M00_L07:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FF9E5BD5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L00
M00_L08:
       xor       esi,esi
       xor       edi,edi
       jmp       near ptr M00_L03
M00_L09:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FF9E5BD5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,20888800A98
       mov       rbp,[rcx]
       jmp       near ptr M00_L04
M00_L10:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L04
M00_L11:
       mov       rdx,rsi
       call      qword ptr [7FF9E617E9A0]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L04
; Total bytes of code 460
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
       test      rax,rax
       je        short M01_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       jmp       short M01_L00
; Total bytes of code 86
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M02_L00
       ret
M02_L00:
       jmp       qword ptr [7FF9E5BD5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
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
       call      qword ptr [7FF9EE0F5618]
       add       rbx,4000
       add       rsi,4000
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       jne       short M03_L04
M03_L01:
       cmp       rdi,4000
       ja        short M03_L00
M03_L02:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       call      qword ptr [7FF9EE0F5618]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       jne       short M03_L05
M03_L03:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M03_L04:
       call      qword ptr [7FF9EE0E4040]; CORINFO_HELP_POLL_GC
       jmp       short M03_L01
M03_L05:
       call      qword ptr [7FF9EE0E4040]; CORINFO_HELP_POLL_GC
       jmp       short M03_L03
M03_L06:
       add       rdi,0FFFFFFFFFFFFC000
       lea       rcx,[rbx+rdi]
       lea       rdx,[rsi+rdi]
       mov       r8d,4000
       call      qword ptr [7FF9EE0F5618]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       je        short M03_L07
       call      qword ptr [7FF9EE0E4040]; CORINFO_HELP_POLL_GC
M03_L07:
       cmp       rdi,4000
       ja        short M03_L06
       jmp       short M03_L02
; Total bytes of code 199
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.AsReadOnlySpan()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       test      rsi,rsi
       je        near ptr M00_L05
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L06
       mov       rcx,rsi
       mov       r11,7FF9E5B30DD8
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L01
       test      byte ptr [7FF9E646E378],1
       je        near ptr M00_L07
M00_L00:
       mov       rdx,1F3B2000A98
       mov       rdi,[rdx]
       jmp       short M00_L02
M00_L01:
       movsxd    rdx,eax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r11,7FF9E5B30DE0
       xor       r8d,r8d
       call      qword ptr [r11]
M00_L02:
       test      rdi,rdi
       je        near ptr M00_L08
       lea       rsi,[rdi+10]
       mov       edi,[rdi+8]
M00_L03:
       test      edi,edi
       je        near ptr M00_L09
       mov       edx,edi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbp,rax
       lea       rcx,[rbp+10]
       mov       r8d,edi
       shl       r8,3
       cmp       r8,4000
       ja        near ptr M00_L11
       mov       rdx,rsi
       call      00007FFA45809170
       cmp       dword ptr [7FFA45B339A0],0
       jne       near ptr M00_L10
M00_L04:
       mov       [rsp+20],rbp
       mov       rbx,[rbx+60]
       mov       rdx,[rsp+20]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L05:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,65
       mov       rdx,7FF9E5FE8D68
       call      qword ptr [7FF9E5BEF228]
       mov       rsi,rax
       call      qword ptr [7FF9E63CC0A8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF9E63CC0C0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L06:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rdi,rax
       jmp       near ptr M00_L02
M00_L07:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FF9E5BE5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L00
M00_L08:
       xor       esi,esi
       xor       edi,edi
       jmp       near ptr M00_L03
M00_L09:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FF9E5BE5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1F3B2000A98
       mov       rbp,[rcx]
       jmp       near ptr M00_L04
M00_L10:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L04
M00_L11:
       mov       rdx,rsi
       call      qword ptr [7FF9E618E9A0]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L04
; Total bytes of code 460
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
       test      rax,rax
       je        short M01_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       jmp       short M01_L00
; Total bytes of code 86
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M02_L00
       ret
M02_L00:
       jmp       qword ptr [7FF9E5BE5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
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
       call      qword ptr [7FF9EE0F5618]
       add       rbx,4000
       add       rsi,4000
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       jne       short M03_L04
M03_L01:
       cmp       rdi,4000
       ja        short M03_L00
M03_L02:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       call      qword ptr [7FF9EE0F5618]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       jne       short M03_L05
M03_L03:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M03_L04:
       call      qword ptr [7FF9EE0E4040]; CORINFO_HELP_POLL_GC
       jmp       short M03_L01
M03_L05:
       call      qword ptr [7FF9EE0E4040]; CORINFO_HELP_POLL_GC
       jmp       short M03_L03
M03_L06:
       add       rdi,0FFFFFFFFFFFFC000
       lea       rcx,[rbx+rdi]
       lea       rdx,[rsi+rdi]
       mov       r8d,4000
       call      qword ptr [7FF9EE0F5618]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       je        short M03_L07
       call      qword ptr [7FF9EE0E4040]; CORINFO_HELP_POLL_GC
M03_L07:
       cmp       rdi,4000
       ja        short M03_L06
       jmp       short M03_L02
; Total bytes of code 199
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.AsReadOnlySpan()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       test      rsi,rsi
       je        near ptr M00_L05
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L06
       mov       rcx,rsi
       mov       r11,7FF9E5B10DD0
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L01
       test      byte ptr [7FF9E644E4E0],1
       je        near ptr M00_L07
M00_L00:
       mov       rdx,1FD84802A90
       mov       rdi,[rdx]
       jmp       short M00_L02
M00_L01:
       movsxd    rdx,eax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r11,7FF9E5B10DD8
       xor       r8d,r8d
       call      qword ptr [r11]
M00_L02:
       test      rdi,rdi
       je        near ptr M00_L08
       lea       rsi,[rdi+10]
       mov       edi,[rdi+8]
M00_L03:
       test      edi,edi
       je        near ptr M00_L09
       mov       edx,edi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbp,rax
       lea       rcx,[rbp+10]
       mov       r8d,edi
       shl       r8,3
       cmp       r8,4000
       ja        near ptr M00_L11
       mov       rdx,rsi
       call      00007FFA45809170
       cmp       dword ptr [7FFA45B339A0],0
       jne       near ptr M00_L10
M00_L04:
       mov       [rsp+20],rbp
       mov       rbx,[rbx+60]
       mov       rdx,[rsp+20]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L05:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,65
       mov       rdx,7FF9E5FC8D68
       call      qword ptr [7FF9E5BCF228]
       mov       rsi,rax
       call      qword ptr [7FF9E63AC090]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF9E63AC0A8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L06:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rdi,rax
       jmp       near ptr M00_L02
M00_L07:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FF9E5BC5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L00
M00_L08:
       xor       esi,esi
       xor       edi,edi
       jmp       near ptr M00_L03
M00_L09:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FF9E5BC5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1FD84802A90
       mov       rbp,[rcx]
       jmp       near ptr M00_L04
M00_L10:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L04
M00_L11:
       mov       rdx,rsi
       call      qword ptr [7FF9E616E9A0]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L04
; Total bytes of code 460
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
       test      rax,rax
       je        short M01_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       jmp       short M01_L00
; Total bytes of code 86
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M02_L00
       ret
M02_L00:
       jmp       qword ptr [7FF9E5BC5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
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
       call      qword ptr [7FF9EE0F5618]
       add       rbx,4000
       add       rsi,4000
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       jne       short M03_L04
M03_L01:
       cmp       rdi,4000
       ja        short M03_L00
M03_L02:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       call      qword ptr [7FF9EE0F5618]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       jne       short M03_L05
M03_L03:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M03_L04:
       call      qword ptr [7FF9EE0E4040]; CORINFO_HELP_POLL_GC
       jmp       short M03_L01
M03_L05:
       call      qword ptr [7FF9EE0E4040]; CORINFO_HELP_POLL_GC
       jmp       short M03_L03
M03_L06:
       add       rdi,0FFFFFFFFFFFFC000
       lea       rcx,[rbx+rdi]
       lea       rdx,[rsi+rdi]
       mov       r8d,4000
       call      qword ptr [7FF9EE0F5618]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       je        short M03_L07
       call      qword ptr [7FF9EE0E4040]; CORINFO_HELP_POLL_GC
M03_L07:
       cmp       rdi,4000
       ja        short M03_L06
       jmp       short M03_L02
; Total bytes of code 199
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.AsReadOnlySpan()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       test      rsi,rsi
       je        near ptr M00_L05
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L06
       mov       rcx,rsi
       mov       r11,7FF9E5B20DD0
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L01
       test      byte ptr [7FF9E645ED88],1
       je        near ptr M00_L07
M00_L00:
       mov       rdx,1D874800A98
       mov       rdi,[rdx]
       jmp       short M00_L02
M00_L01:
       movsxd    rdx,eax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r11,7FF9E5B20DD8
       xor       r8d,r8d
       call      qword ptr [r11]
M00_L02:
       test      rdi,rdi
       je        near ptr M00_L08
       lea       rsi,[rdi+10]
       mov       edi,[rdi+8]
M00_L03:
       test      edi,edi
       je        near ptr M00_L09
       mov       edx,edi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbp,rax
       lea       rcx,[rbp+10]
       mov       r8d,edi
       shl       r8,3
       cmp       r8,4000
       ja        near ptr M00_L11
       mov       rdx,rsi
       call      00007FFA45809170
       cmp       dword ptr [7FFA45B339A0],0
       jne       near ptr M00_L10
M00_L04:
       mov       [rsp+20],rbp
       mov       rbx,[rbx+60]
       mov       rdx,[rsp+20]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L05:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,65
       mov       rdx,7FF9E5FD8D68
       call      qword ptr [7FF9E5BDF228]
       mov       rsi,rax
       call      qword ptr [7FF9E63BC138]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF9E63BC150]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L06:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rdi,rax
       jmp       near ptr M00_L02
M00_L07:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FF9E5BD5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L00
M00_L08:
       xor       esi,esi
       xor       edi,edi
       jmp       near ptr M00_L03
M00_L09:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FF9E5BD5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1D874800A98
       mov       rbp,[rcx]
       jmp       near ptr M00_L04
M00_L10:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L04
M00_L11:
       mov       rdx,rsi
       call      qword ptr [7FF9E617E9A0]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L04
; Total bytes of code 460
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
       test      rax,rax
       je        short M01_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       jmp       short M01_L00
; Total bytes of code 86
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M02_L00
       ret
M02_L00:
       jmp       qword ptr [7FF9E5BD5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
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
       call      qword ptr [7FF9EE0F5618]
       add       rbx,4000
       add       rsi,4000
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       jne       short M03_L04
M03_L01:
       cmp       rdi,4000
       ja        short M03_L00
M03_L02:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       call      qword ptr [7FF9EE0F5618]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       jne       short M03_L05
M03_L03:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M03_L04:
       call      qword ptr [7FF9EE0E4040]; CORINFO_HELP_POLL_GC
       jmp       short M03_L01
M03_L05:
       call      qword ptr [7FF9EE0E4040]; CORINFO_HELP_POLL_GC
       jmp       short M03_L03
M03_L06:
       add       rdi,0FFFFFFFFFFFFC000
       lea       rcx,[rbx+rdi]
       lea       rdx,[rsi+rdi]
       mov       r8d,4000
       call      qword ptr [7FF9EE0F5618]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       je        short M03_L07
       call      qword ptr [7FF9EE0E4040]; CORINFO_HELP_POLL_GC
M03_L07:
       cmp       rdi,4000
       ja        short M03_L06
       jmp       short M03_L02
; Total bytes of code 199
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.AsReadOnlySpan()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       test      rsi,rsi
       je        near ptr M00_L05
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L06
       mov       rcx,rsi
       mov       r11,7FF9E5B20F88
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L01
       test      byte ptr [7FF9E64916C8],1
       je        near ptr M00_L07
M00_L00:
       mov       rdx,11B3FC00AF8
       mov       rdi,[rdx]
       jmp       short M00_L02
M00_L01:
       movsxd    rdx,eax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r11,7FF9E5B20F90
       xor       r8d,r8d
       call      qword ptr [r11]
M00_L02:
       test      rdi,rdi
       je        near ptr M00_L08
       lea       rsi,[rdi+10]
       mov       edi,[rdi+8]
M00_L03:
       test      edi,edi
       je        near ptr M00_L09
       mov       edx,edi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbp,rax
       lea       rcx,[rbp+10]
       mov       r8d,edi
       shl       r8,3
       cmp       r8,4000
       ja        near ptr M00_L11
       mov       rdx,rsi
       call      00007FFA45809170
       cmp       dword ptr [7FFA45B339A0],0
       jne       near ptr M00_L10
M00_L04:
       mov       [rsp+20],rbp
       mov       rbx,[rbx+60]
       mov       rdx,[rsp+20]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L05:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,65
       mov       rdx,7FF9E5FD8D68
       call      qword ptr [7FF9E5BDF228]
       mov       rsi,rax
       call      qword ptr [7FF9E62BD2D8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF9E62BD2F0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L06:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rdi,rax
       jmp       near ptr M00_L02
M00_L07:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L00
M00_L08:
       xor       esi,esi
       xor       edi,edi
       jmp       near ptr M00_L03
M00_L09:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,11B3FC00AF8
       mov       rbp,[rcx]
       jmp       near ptr M00_L04
M00_L10:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L04
M00_L11:
       mov       rdx,rsi
       call      qword ptr [7FF9E617E9A0]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L04
; Total bytes of code 458
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
       test      rax,rax
       je        short M01_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       jmp       short M01_L00
; Total bytes of code 86
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M02_L00
       ret
M02_L00:
       jmp       qword ptr [7FF9E5BD5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
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
       call      00007FFA45809170
       add       rbx,4000
       add       rsi,4000
       cmp       dword ptr [7FFA45B339A0],0
       jne       short M03_L04
M03_L01:
       cmp       rdi,4000
       ja        short M03_L00
M03_L02:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       call      00007FFA45809170
       cmp       dword ptr [7FFA45B339A0],0
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
       call      00007FFA45809170
       cmp       dword ptr [7FFA45B339A0],0
       je        short M03_L07
       call      CORINFO_HELP_POLL_GC
M03_L07:
       cmp       rdi,4000
       ja        short M03_L06
       jmp       short M03_L02
; Total bytes of code 184
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.AsReadOnlySpan()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       test      rsi,rsi
       je        near ptr M00_L05
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L06
       mov       rcx,rsi
       mov       r11,7FF9E5B11210
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L01
       test      byte ptr [7FF9E65074C0],1
       je        near ptr M00_L07
M00_L00:
       mov       rdx,1F0F7800B00
       mov       rdi,[rdx]
       jmp       short M00_L02
M00_L01:
       movsxd    rdx,eax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r11,7FF9E5B11218
       xor       r8d,r8d
       call      qword ptr [r11]
M00_L02:
       test      rdi,rdi
       je        near ptr M00_L08
       lea       rsi,[rdi+10]
       mov       edi,[rdi+8]
M00_L03:
       test      edi,edi
       je        near ptr M00_L09
       mov       edx,edi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbp,rax
       lea       rcx,[rbp+10]
       mov       r8d,edi
       shl       r8,3
       cmp       r8,4000
       ja        near ptr M00_L11
       mov       rdx,rsi
       call      00007FFA45809170
       cmp       dword ptr [7FFA45B339A0],0
       jne       near ptr M00_L10
M00_L04:
       mov       [rsp+20],rbp
       mov       rbx,[rbx+60]
       mov       rdx,[rsp+20]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L05:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,65
       mov       rdx,7FF9E5FC8D68
       call      qword ptr [7FF9E5BCF228]
       mov       rsi,rax
       call      qword ptr [7FF9E62A4E58]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF9E62A4E70]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L06:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rdi,rax
       jmp       near ptr M00_L02
M00_L07:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L00
M00_L08:
       xor       esi,esi
       xor       edi,edi
       jmp       near ptr M00_L03
M00_L09:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1F0F7800B00
       mov       rbp,[rcx]
       jmp       near ptr M00_L04
M00_L10:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L04
M00_L11:
       mov       rdx,rsi
       call      qword ptr [7FF9E616E9A0]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L04
; Total bytes of code 458
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
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M02_L00
       ret
M02_L00:
       jmp       qword ptr [7FF9E5BC5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
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
       call      00007FFA45809170
       add       rbx,4000
       add       rsi,4000
       cmp       dword ptr [7FFA45B339A0],0
       jne       short M03_L04
M03_L01:
       cmp       rdi,4000
       ja        short M03_L00
M03_L02:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       call      00007FFA45809170
       cmp       dword ptr [7FFA45B339A0],0
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
       call      00007FFA45809170
       cmp       dword ptr [7FFA45B339A0],0
       je        short M03_L07
       call      CORINFO_HELP_POLL_GC
M03_L07:
       cmp       rdi,4000
       ja        short M03_L06
       jmp       short M03_L02
; Total bytes of code 184
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.AsSpan()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       test      rsi,rsi
       je        near ptr M00_L05
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L06
       mov       rcx,rsi
       mov       r11,7FF9E5B20DD0
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L01
       test      byte ptr [7FF9E645E240],1
       je        near ptr M00_L07
M00_L00:
       mov       rdx,1941A400A98
       mov       rdi,[rdx]
       jmp       short M00_L02
M00_L01:
       movsxd    rdx,eax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r11,7FF9E5B20DD8
       xor       r8d,r8d
       call      qword ptr [r11]
M00_L02:
       test      rdi,rdi
       je        near ptr M00_L08
       lea       rsi,[rdi+10]
       mov       edi,[rdi+8]
M00_L03:
       test      edi,edi
       je        near ptr M00_L09
       mov       edx,edi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbp,rax
       lea       rcx,[rbp+10]
       mov       r8d,edi
       shl       r8,3
       cmp       r8,4000
       ja        near ptr M00_L11
       mov       rdx,rsi
       call      00007FFA45809170
       cmp       dword ptr [7FFA45B339A0],0
       jne       near ptr M00_L10
M00_L04:
       mov       [rsp+20],rbp
       mov       rbx,[rbx+60]
       mov       rdx,[rsp+20]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L05:
       call      qword ptr [7FF9E617EAD8]
       mov       ecx,65
       mov       rdx,7FF9E5FD8D68
       call      qword ptr [7FF9E5BDF228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF9E5EA5AC0
       call      qword ptr [7FF9E5BDF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9E5BDD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9E5FD8D68
       call      qword ptr [7FF9E5BDF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9E5BDD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9E63AC5A0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9E63AC5B8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L06:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rdi,rax
       jmp       near ptr M00_L02
M00_L07:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FF9E5BD5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L00
M00_L08:
       xor       esi,esi
       xor       edi,edi
       jmp       near ptr M00_L03
M00_L09:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FF9E5BD5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1941A400A98
       mov       rbp,[rcx]
       jmp       near ptr M00_L04
M00_L10:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L04
M00_L11:
       mov       rdx,rsi
       call      qword ptr [7FF9E617E9E8]
       jmp       near ptr M00_L04
; Total bytes of code 538
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
       test      rax,rax
       je        short M01_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       jmp       short M01_L00
; Total bytes of code 86
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
       call      00007FFA45879D30
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF9E5BD5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF9E5BD5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1D499360008
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
       call      qword ptr [7FF9E63AE100]
       int       3
; Total bytes of code 244
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M03_L00
       ret
M03_L00:
       jmp       qword ptr [7FF9E5BD5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.AsSpan()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       test      rsi,rsi
       je        near ptr M00_L06
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L07
       mov       rcx,rsi
       mov       r11,7FF9E5B40DD8
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L01
       test      byte ptr [7FF9E647F2C8],1
       je        near ptr M00_L08
M00_L00:
       mov       rdx,25A87C02A90
       mov       rdi,[rdx]
       jmp       short M00_L02
M00_L01:
       movsxd    rdx,eax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r11,7FF9E5B40DE0
       xor       r8d,r8d
       call      qword ptr [r11]
M00_L02:
       test      rdi,rdi
       je        near ptr M00_L09
       lea       rsi,[rdi+10]
       mov       edi,[rdi+8]
M00_L03:
       test      edi,edi
       je        near ptr M00_L10
       mov       edx,edi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbp,rax
       lea       rcx,[rbp+10]
       mov       r8d,edi
       shl       r8,3
       cmp       r8,4000
       jbe       short M00_L04
       mov       rdx,rsi
       call      qword ptr [7FF9E63C7498]
       jmp       short M00_L05
M00_L04:
       mov       rdx,rsi
       call      00007FFA45809170
       cmp       dword ptr [7FFA45B339A0],0
       jne       near ptr M00_L11
M00_L05:
       mov       [rsp+20],rbp
       mov       rbx,[rbx+60]
       mov       rdx,[rsp+20]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L06:
       call      qword ptr [7FF9E619EAC0]
       mov       ecx,65
       mov       rdx,7FF9E5FF8D68
       call      qword ptr [7FF9E5BFF228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF9E5EC5AC0
       call      qword ptr [7FF9E5BFF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9E5BFD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9E5FF8D68
       call      qword ptr [7FF9E5BFF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9E5BFD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9E63CC558]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9E63CC570]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rdi,rax
       jmp       near ptr M00_L02
M00_L08:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FF9E5BF5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L00
M00_L09:
       xor       esi,esi
       xor       edi,edi
       jmp       near ptr M00_L03
M00_L10:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FF9E5BF5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,25A87C02A90
       mov       rbp,[rcx]
       jmp       near ptr M00_L05
M00_L11:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L05
; Total bytes of code 531
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
       test      rax,rax
       je        short M01_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       jmp       short M01_L00
; Total bytes of code 86
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
       call      00007FFA45879D30
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF9E5BF5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF9E5BF5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,29B1CCA0008
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
       call      qword ptr [7FF9E63CE0B8]
       int       3
; Total bytes of code 244
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M03_L00
       ret
M03_L00:
       jmp       qword ptr [7FF9E5BF5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.AsSpan()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       test      rsi,rsi
       je        near ptr M00_L05
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L06
       mov       rcx,rsi
       mov       r11,7FF9E5B30DD8
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L01
       test      byte ptr [7FF9E646F400],1
       je        near ptr M00_L07
M00_L00:
       mov       rdx,1FA23400A98
       mov       rdi,[rdx]
       jmp       short M00_L02
M00_L01:
       movsxd    rdx,eax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r11,7FF9E5B30DE0
       xor       r8d,r8d
       call      qword ptr [r11]
M00_L02:
       test      rdi,rdi
       je        near ptr M00_L08
       lea       rsi,[rdi+10]
       mov       edi,[rdi+8]
M00_L03:
       test      edi,edi
       je        near ptr M00_L09
       mov       edx,edi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbp,rax
       lea       rcx,[rbp+10]
       mov       r8d,edi
       shl       r8,3
       cmp       r8,4000
       ja        near ptr M00_L11
       mov       rdx,rsi
       call      00007FFA45809170
       cmp       dword ptr [7FFA45B339A0],0
       jne       near ptr M00_L10
M00_L04:
       mov       [rsp+20],rbp
       mov       rbx,[rbx+60]
       mov       rdx,[rsp+20]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L05:
       call      qword ptr [7FF9E618EF70]
       mov       ecx,65
       mov       rdx,7FF9E5FE8D68
       call      qword ptr [7FF9E5BEF228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF9E5EB5AC0
       call      qword ptr [7FF9E5BEF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9E5BED9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9E5FE8D68
       call      qword ptr [7FF9E5BEF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9E5BED9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9E63CC5B8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9E63CC5D0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L06:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rdi,rax
       jmp       near ptr M00_L02
M00_L07:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FF9E5BE5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L00
M00_L08:
       xor       esi,esi
       xor       edi,edi
       jmp       near ptr M00_L03
M00_L09:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FF9E5BE5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1FA23400A98
       mov       rbp,[rcx]
       jmp       near ptr M00_L04
M00_L10:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L04
M00_L11:
       mov       rdx,rsi
       call      qword ptr [7FF9E618EE80]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L04
; Total bytes of code 538
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
       test      rax,rax
       je        short M01_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       jmp       short M01_L00
; Total bytes of code 86
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
       call      00007FFA45879D30
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF9E5BE5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF9E5BE5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,23AA26F0008
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
       call      qword ptr [7FF9E63CE118]
       int       3
; Total bytes of code 244
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M03_L00
       ret
M03_L00:
       jmp       qword ptr [7FF9E5BE5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
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
       je        short M04_L03
       mov       rcx,rbx
       sub       rcx,rsi
       cmp       rcx,rdi
       jb        short M04_L06
M04_L00:
       add       rdi,0FFFFFFFFFFFFC000
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,4000
       call      qword ptr [7FF9EE0F5618]
       add       rbx,4000
       add       rsi,4000
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       jne       short M04_L04
M04_L01:
       cmp       rdi,4000
       ja        short M04_L00
M04_L02:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       call      qword ptr [7FF9EE0F5618]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       jne       short M04_L05
M04_L03:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M04_L04:
       call      qword ptr [7FF9EE0E4040]; CORINFO_HELP_POLL_GC
       jmp       short M04_L01
M04_L05:
       call      qword ptr [7FF9EE0E4040]; CORINFO_HELP_POLL_GC
       jmp       short M04_L03
M04_L06:
       add       rdi,0FFFFFFFFFFFFC000
       lea       rcx,[rbx+rdi]
       lea       rdx,[rsi+rdi]
       mov       r8d,4000
       call      qword ptr [7FF9EE0F5618]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       je        short M04_L07
       call      qword ptr [7FF9EE0E4040]; CORINFO_HELP_POLL_GC
M04_L07:
       cmp       rdi,4000
       ja        short M04_L06
       jmp       short M04_L02
; Total bytes of code 199
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.AsSpan()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       test      rsi,rsi
       je        near ptr M00_L05
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L06
       mov       rcx,rsi
       mov       r11,7FF9E5B20DD0
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L01
       test      byte ptr [7FF9E645E4B8],1
       je        near ptr M00_L07
M00_L00:
       mov       rdx,1D702802A90
       mov       rdi,[rdx]
       jmp       short M00_L02
M00_L01:
       movsxd    rdx,eax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r11,7FF9E5B20DD8
       xor       r8d,r8d
       call      qword ptr [r11]
M00_L02:
       test      rdi,rdi
       je        near ptr M00_L08
       lea       rsi,[rdi+10]
       mov       edi,[rdi+8]
M00_L03:
       test      edi,edi
       je        near ptr M00_L09
       mov       edx,edi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbp,rax
       lea       rcx,[rbp+10]
       mov       r8d,edi
       shl       r8,3
       cmp       r8,4000
       ja        near ptr M00_L11
       mov       rdx,rsi
       call      00007FFA45809170
       cmp       dword ptr [7FFA45B339A0],0
       jne       near ptr M00_L10
M00_L04:
       mov       [rsp+20],rbp
       mov       rbx,[rbx+60]
       mov       rdx,[rsp+20]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L05:
       call      qword ptr [7FF9E617EFA0]
       mov       ecx,65
       mov       rdx,7FF9E5FD8D68
       call      qword ptr [7FF9E5BDF228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF9E5EA5AC0
       call      qword ptr [7FF9E5BDF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9E5BDD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9E5FD8D68
       call      qword ptr [7FF9E5BDF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9E5BDD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9E63BC168]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9E63BC180]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L06:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rdi,rax
       jmp       near ptr M00_L02
M00_L07:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FF9E5BD5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L00
M00_L08:
       xor       esi,esi
       xor       edi,edi
       jmp       near ptr M00_L03
M00_L09:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FF9E5BD5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1D702802A90
       mov       rbp,[rcx]
       jmp       near ptr M00_L04
M00_L10:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L04
M00_L11:
       mov       rdx,rsi
       call      qword ptr [7FF9E617E9A0]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L04
; Total bytes of code 538
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
       test      rax,rax
       je        short M01_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       jmp       short M01_L00
; Total bytes of code 86
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
       call      00007FFA45879D30
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF9E5BD5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF9E5BD5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,21797660008
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
       call      qword ptr [7FF9E63BE100]
       int       3
; Total bytes of code 244
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M03_L00
       ret
M03_L00:
       jmp       qword ptr [7FF9E5BD5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
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
       je        short M04_L03
       mov       rcx,rbx
       sub       rcx,rsi
       cmp       rcx,rdi
       jb        short M04_L06
M04_L00:
       add       rdi,0FFFFFFFFFFFFC000
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,4000
       call      qword ptr [7FF9EE0F5618]
       add       rbx,4000
       add       rsi,4000
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       jne       short M04_L04
M04_L01:
       cmp       rdi,4000
       ja        short M04_L00
M04_L02:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       call      qword ptr [7FF9EE0F5618]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       jne       short M04_L05
M04_L03:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M04_L04:
       call      qword ptr [7FF9EE0E4040]; CORINFO_HELP_POLL_GC
       jmp       short M04_L01
M04_L05:
       call      qword ptr [7FF9EE0E4040]; CORINFO_HELP_POLL_GC
       jmp       short M04_L03
M04_L06:
       add       rdi,0FFFFFFFFFFFFC000
       lea       rcx,[rbx+rdi]
       lea       rdx,[rsi+rdi]
       mov       r8d,4000
       call      qword ptr [7FF9EE0F5618]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       je        short M04_L07
       call      qword ptr [7FF9EE0E4040]; CORINFO_HELP_POLL_GC
M04_L07:
       cmp       rdi,4000
       ja        short M04_L06
       jmp       short M04_L02
; Total bytes of code 199
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.AsSpan()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       test      rsi,rsi
       je        near ptr M00_L05
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L06
       mov       rcx,rsi
       mov       r11,7FF9E5B20DD0
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L01
       test      byte ptr [7FF9E645DC38],1
       je        near ptr M00_L07
M00_L00:
       mov       rdx,1ED62800A98
       mov       rdi,[rdx]
       jmp       short M00_L02
M00_L01:
       movsxd    rdx,eax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r11,7FF9E5B20DD8
       xor       r8d,r8d
       call      qword ptr [r11]
M00_L02:
       test      rdi,rdi
       je        near ptr M00_L08
       lea       rsi,[rdi+10]
       mov       edi,[rdi+8]
M00_L03:
       test      edi,edi
       je        near ptr M00_L09
       mov       edx,edi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbp,rax
       lea       rcx,[rbp+10]
       mov       r8d,edi
       shl       r8,3
       cmp       r8,4000
       ja        near ptr M00_L11
       mov       rdx,rsi
       call      00007FFA45809170
       cmp       dword ptr [7FFA45B339A0],0
       jne       near ptr M00_L10
M00_L04:
       mov       [rsp+20],rbp
       mov       rbx,[rbx+60]
       mov       rdx,[rsp+20]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L05:
       call      qword ptr [7FF9E617F000]
       mov       ecx,65
       mov       rdx,7FF9E5FD8D68
       call      qword ptr [7FF9E5BDF228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF9E5EA5AC0
       call      qword ptr [7FF9E5BDF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9E5BDD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9E5FD8D68
       call      qword ptr [7FF9E5BDF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9E5BDD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9E63BC168]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9E63BC180]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L06:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rdi,rax
       jmp       near ptr M00_L02
M00_L07:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FF9E5BD5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L00
M00_L08:
       xor       esi,esi
       xor       edi,edi
       jmp       near ptr M00_L03
M00_L09:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FF9E5BD5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1ED62800A98
       mov       rbp,[rcx]
       jmp       near ptr M00_L04
M00_L10:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L04
M00_L11:
       mov       rdx,rsi
       call      qword ptr [7FF9E617E9A0]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L04
; Total bytes of code 538
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
       test      rax,rax
       je        short M01_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       jmp       short M01_L00
; Total bytes of code 86
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
       call      00007FFA45879D30
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF9E5BD5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF9E5BD5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,22DE1900008
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
       call      qword ptr [7FF9E63BE178]
       int       3
; Total bytes of code 244
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M03_L00
       ret
M03_L00:
       jmp       qword ptr [7FF9E5BD5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
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
       je        short M04_L03
       mov       rcx,rbx
       sub       rcx,rsi
       cmp       rcx,rdi
       jb        short M04_L06
M04_L00:
       add       rdi,0FFFFFFFFFFFFC000
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,4000
       call      qword ptr [7FF9EE0F5618]
       add       rbx,4000
       add       rsi,4000
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       jne       short M04_L04
M04_L01:
       cmp       rdi,4000
       ja        short M04_L00
M04_L02:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       call      qword ptr [7FF9EE0F5618]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       jne       short M04_L05
M04_L03:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M04_L04:
       call      qword ptr [7FF9EE0E4040]; CORINFO_HELP_POLL_GC
       jmp       short M04_L01
M04_L05:
       call      qword ptr [7FF9EE0E4040]; CORINFO_HELP_POLL_GC
       jmp       short M04_L03
M04_L06:
       add       rdi,0FFFFFFFFFFFFC000
       lea       rcx,[rbx+rdi]
       lea       rdx,[rsi+rdi]
       mov       r8d,4000
       call      qword ptr [7FF9EE0F5618]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       je        short M04_L07
       call      qword ptr [7FF9EE0E4040]; CORINFO_HELP_POLL_GC
M04_L07:
       cmp       rdi,4000
       ja        short M04_L06
       jmp       short M04_L02
; Total bytes of code 199
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.AsSpan()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       test      rsi,rsi
       je        near ptr M00_L05
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L06
       mov       rcx,rsi
       mov       r11,7FF9E5B20DD0
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L01
       test      byte ptr [7FF9E645F4A0],1
       je        near ptr M00_L07
M00_L00:
       mov       rdx,1C077800A98
       mov       rdi,[rdx]
       jmp       short M00_L02
M00_L01:
       movsxd    rdx,eax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r11,7FF9E5B20DD8
       xor       r8d,r8d
       call      qword ptr [r11]
M00_L02:
       test      rdi,rdi
       je        near ptr M00_L08
       lea       rsi,[rdi+10]
       mov       edi,[rdi+8]
M00_L03:
       test      edi,edi
       je        near ptr M00_L09
       mov       edx,edi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbp,rax
       lea       rcx,[rbp+10]
       mov       r8d,edi
       shl       r8,3
       cmp       r8,4000
       ja        near ptr M00_L11
       mov       rdx,rsi
       call      00007FFA45809170
       cmp       dword ptr [7FFA45B339A0],0
       jne       near ptr M00_L10
M00_L04:
       mov       [rsp+20],rbp
       mov       rbx,[rbx+60]
       mov       rdx,[rsp+20]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L05:
       call      qword ptr [7FF9E617EFD0]
       mov       ecx,65
       mov       rdx,7FF9E5FD8D68
       call      qword ptr [7FF9E5BDF228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF9E5EA5AC0
       call      qword ptr [7FF9E5BDF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9E5BDD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9E5FD8D68
       call      qword ptr [7FF9E5BDF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9E5BDD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9E63BC168]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9E63BC180]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L06:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rdi,rax
       jmp       near ptr M00_L02
M00_L07:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FF9E5BD5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L00
M00_L08:
       xor       esi,esi
       xor       edi,edi
       jmp       near ptr M00_L03
M00_L09:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FF9E5BD5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1C077800A98
       mov       rbp,[rcx]
       jmp       near ptr M00_L04
M00_L10:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L04
M00_L11:
       mov       rdx,rsi
       call      qword ptr [7FF9E617E9A0]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L04
; Total bytes of code 538
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
       test      rax,rax
       je        short M01_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       jmp       short M01_L00
; Total bytes of code 86
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
       call      00007FFA45879D30
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF9E5BD5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF9E5BD5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,200F68C0008
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
       call      qword ptr [7FF9E63BE100]
       int       3
; Total bytes of code 244
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M03_L00
       ret
M03_L00:
       jmp       qword ptr [7FF9E5BD5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
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
       je        short M04_L03
       mov       rcx,rbx
       sub       rcx,rsi
       cmp       rcx,rdi
       jb        short M04_L06
M04_L00:
       add       rdi,0FFFFFFFFFFFFC000
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,4000
       call      qword ptr [7FF9EE0F5618]
       add       rbx,4000
       add       rsi,4000
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       jne       short M04_L04
M04_L01:
       cmp       rdi,4000
       ja        short M04_L00
M04_L02:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       call      qword ptr [7FF9EE0F5618]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       jne       short M04_L05
M04_L03:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M04_L04:
       call      qword ptr [7FF9EE0E4040]; CORINFO_HELP_POLL_GC
       jmp       short M04_L01
M04_L05:
       call      qword ptr [7FF9EE0E4040]; CORINFO_HELP_POLL_GC
       jmp       short M04_L03
M04_L06:
       add       rdi,0FFFFFFFFFFFFC000
       lea       rcx,[rbx+rdi]
       lea       rdx,[rsi+rdi]
       mov       r8d,4000
       call      qword ptr [7FF9EE0F5618]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       je        short M04_L07
       call      qword ptr [7FF9EE0E4040]; CORINFO_HELP_POLL_GC
M04_L07:
       cmp       rdi,4000
       ja        short M04_L06
       jmp       short M04_L02
; Total bytes of code 199
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.AsSpan()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       test      rsi,rsi
       je        near ptr M00_L05
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L06
       mov       rcx,rsi
       mov       r11,7FF9E5B50EC0
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L01
       test      byte ptr [7FF9E64AE2E0],1
       je        near ptr M00_L07
M00_L00:
       mov       rdx,1D6CE000AF8
       mov       rdi,[rdx]
       jmp       short M00_L02
M00_L01:
       movsxd    rdx,eax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r11,7FF9E5B50EC8
       xor       r8d,r8d
       call      qword ptr [r11]
M00_L02:
       test      rdi,rdi
       je        near ptr M00_L08
       lea       rsi,[rdi+10]
       mov       edi,[rdi+8]
M00_L03:
       test      edi,edi
       je        near ptr M00_L09
       mov       edx,edi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbp,rax
       lea       rcx,[rbp+10]
       mov       r8d,edi
       shl       r8,3
       cmp       r8,4000
       ja        near ptr M00_L11
       mov       rdx,rsi
       call      00007FFA45809170
       cmp       dword ptr [7FFA45B339A0],0
       jne       near ptr M00_L10
M00_L04:
       mov       [rsp+20],rbp
       mov       rbx,[rbx+60]
       mov       rdx,[rsp+20]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L05:
       call      qword ptr [7FF9E61AEFB8]
       mov       ecx,65
       mov       rdx,7FF9E6008D68
       call      qword ptr [7FF9E5C0F228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF9E5ED5AC0
       call      qword ptr [7FF9E5C0F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9E5C0D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9E6008D68
       call      qword ptr [7FF9E5C0F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9E5C0D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9E63DC180]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9E63DC198]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L06:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rdi,rax
       jmp       near ptr M00_L02
M00_L07:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FF9E5C05728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L00
M00_L08:
       xor       esi,esi
       xor       edi,edi
       jmp       near ptr M00_L03
M00_L09:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FF9E5C05728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1D6CE000AF8
       mov       rbp,[rcx]
       jmp       near ptr M00_L04
M00_L10:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L04
M00_L11:
       mov       rdx,rsi
       call      qword ptr [7FF9E61AEE38]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L04
; Total bytes of code 538
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
       test      rax,rax
       je        short M01_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       jmp       short M01_L00
; Total bytes of code 86
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
       call      00007FFA45879D30
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF9E5C05818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF9E5C05818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,2174D190008
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
       call      qword ptr [7FF9E63DE8B0]
       int       3
; Total bytes of code 244
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M03_L00
       ret
M03_L00:
       jmp       qword ptr [7FF9E5C05C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
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
       je        short M04_L03
       mov       rcx,rbx
       sub       rcx,rsi
       cmp       rcx,rdi
       jb        short M04_L06
M04_L00:
       add       rdi,0FFFFFFFFFFFFC000
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,4000
       call      00007FFA45809170
       add       rbx,4000
       add       rsi,4000
       cmp       dword ptr [7FFA45B339A0],0
       jne       short M04_L04
M04_L01:
       cmp       rdi,4000
       ja        short M04_L00
M04_L02:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       call      00007FFA45809170
       cmp       dword ptr [7FFA45B339A0],0
       jne       short M04_L05
M04_L03:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M04_L04:
       call      CORINFO_HELP_POLL_GC
       jmp       short M04_L01
M04_L05:
       call      CORINFO_HELP_POLL_GC
       jmp       short M04_L03
M04_L06:
       add       rdi,0FFFFFFFFFFFFC000
       lea       rcx,[rbx+rdi]
       lea       rdx,[rsi+rdi]
       mov       r8d,4000
       call      00007FFA45809170
       cmp       dword ptr [7FFA45B339A0],0
       je        short M04_L07
       call      CORINFO_HELP_POLL_GC
M04_L07:
       cmp       rdi,4000
       ja        short M04_L06
       jmp       short M04_L02
; Total bytes of code 184
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.AsSpan()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       test      rsi,rsi
       je        near ptr M00_L05
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L06
       mov       rcx,rsi
       mov       r11,7FF9E5B21208
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L01
       test      byte ptr [7FF9E6516C88],1
       je        near ptr M00_L07
M00_L00:
       mov       rdx,2398E000B00
       mov       rdi,[rdx]
       jmp       short M00_L02
M00_L01:
       movsxd    rdx,eax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r11,7FF9E5B21210
       xor       r8d,r8d
       call      qword ptr [r11]
M00_L02:
       test      rdi,rdi
       je        near ptr M00_L08
       lea       rsi,[rdi+10]
       mov       edi,[rdi+8]
M00_L03:
       test      edi,edi
       je        near ptr M00_L09
       mov       edx,edi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbp,rax
       lea       rcx,[rbp+10]
       mov       r8d,edi
       shl       r8,3
       cmp       r8,4000
       ja        near ptr M00_L11
       mov       rdx,rsi
       call      00007FFA45809170
       cmp       dword ptr [7FFA45B339A0],0
       jne       near ptr M00_L10
M00_L04:
       mov       [rsp+20],rbp
       mov       rbx,[rbx+60]
       mov       rdx,[rsp+20]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L05:
       call      qword ptr [7FF9E617F000]
       mov       ecx,65
       mov       rdx,7FF9E5FD8D68
       call      qword ptr [7FF9E5BDF228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF9E5EA5AC0
       call      qword ptr [7FF9E5BDF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9E5BDD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9E5FD8D68
       call      qword ptr [7FF9E5BDF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9E5BDD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9E62B4E58]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9E62B4E70]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L06:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rdi,rax
       jmp       near ptr M00_L02
M00_L07:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L00
M00_L08:
       xor       esi,esi
       xor       edi,edi
       jmp       near ptr M00_L03
M00_L09:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,2398E000B00
       mov       rbp,[rcx]
       jmp       near ptr M00_L04
M00_L10:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L04
M00_L11:
       mov       rdx,rsi
       call      qword ptr [7FF9E617EE38]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L04
; Total bytes of code 536
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
       call      00007FFA45879D30
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF9E5BD5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF9E5BD5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,27A0D070008
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
       call      qword ptr [7FF9E640E610]
       int       3
; Total bytes of code 235
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M03_L00
       ret
M03_L00:
       jmp       qword ptr [7FF9E5BD5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
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
       je        short M04_L03
       mov       rcx,rbx
       sub       rcx,rsi
       cmp       rcx,rdi
       jb        short M04_L06
M04_L00:
       add       rdi,0FFFFFFFFFFFFC000
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,4000
       call      00007FFA45809170
       add       rbx,4000
       add       rsi,4000
       cmp       dword ptr [7FFA45B339A0],0
       jne       short M04_L04
M04_L01:
       cmp       rdi,4000
       ja        short M04_L00
M04_L02:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       call      00007FFA45809170
       cmp       dword ptr [7FFA45B339A0],0
       jne       short M04_L05
M04_L03:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M04_L04:
       call      CORINFO_HELP_POLL_GC
       jmp       short M04_L01
M04_L05:
       call      CORINFO_HELP_POLL_GC
       jmp       short M04_L03
M04_L06:
       add       rdi,0FFFFFFFFFFFFC000
       lea       rcx,[rbx+rdi]
       lea       rdx,[rsi+rdi]
       mov       r8d,4000
       call      00007FFA45809170
       cmp       dword ptr [7FFA45B339A0],0
       je        short M04_L07
       call      CORINFO_HELP_POLL_GC
M04_L07:
       cmp       rdi,4000
       ja        short M04_L06
       jmp       short M04_L02
; Total bytes of code 184
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.ToFrozenSet()
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
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-70],xmm4
       xor       eax,eax
       mov       [rbp-60],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       test      rsi,rsi
       je        near ptr M00_L44
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L46
       mov       rcx,[rsi+8]
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],r11
       jne       near ptr M00_L45
       mov       edi,[rcx+10]
M00_L00:
       test      edi,edi
       je        near ptr M00_L59
       mov       rdx,243CC000A20
       mov       rdi,[rdx]
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Frozen.FrozenSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r14,rax
       test      r14,r14
       jne       near ptr M00_L47
M00_L01:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Generic.HashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r14,rax
       mov       r15,r14
       test      r15,r15
       jne       near ptr M00_L48
M00_L02:
       mov       rcx,offset MT_System.Collections.Generic.HashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       lea       rcx,[r15+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       test      r14,r14
       jne       near ptr M00_L49
M00_L03:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L51
       mov       rcx,[rsi+8]
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],r11
       jne       near ptr M00_L50
       mov       ecx,[rcx+10]
M00_L04:
       test      ecx,ecx
       jle       short M00_L05
       call      qword ptr [7FF9E5BC5A88]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       r14d,eax
       movsxd    rdx,r14d
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r13,rax
       movsxd    rdx,r14d
       mov       rcx,offset MT_System.Collections.Generic.HashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Entry[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r12,rax
       mov       dword ptr [r15+2C],0FFFFFFFF
       lea       rcx,[r15+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,r14d
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [r15+20],rax
M00_L05:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L54
       mov       rsi,[rsi+8]
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L53
       cmp       dword ptr [rsi+10],0
       je        near ptr M00_L52
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       r13d,[rsi+14]
       lea       rcx,[r14+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r14+10],rcx
       mov       [r14+18],r13d
       mov       [r14+1C],ecx
M00_L06:
       mov       [rbp-78],r14
M00_L07:
       mov       rdx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rcx,[rbp-78]
       cmp       [rcx],rdx
       jne       near ptr M00_L36
       mov       rdx,[rcx]
       add       rcx,8
       call      qword ptr [7FF9E5E5C150]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L08:
       test      eax,eax
       je        near ptr M00_L39
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-78]
       cmp       [rax],rcx
       jne       near ptr M00_L24
       mov       rsi,[rax+10]
M00_L09:
       cmp       qword ptr [r15+8],0
       je        near ptr M00_L25
M00_L10:
       mov       r14,[r15+10]
       mov       r13,[r15+18]
       xor       r12d,r12d
       test      rsi,rsi
       je        near ptr M00_L20
       mov       rcx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r13],rcx
       jne       near ptr M00_L32
       mov       rdx,[rsi+28]
       test      rdx,rdx
       je        near ptr M00_L26
       mov       rcx,243B6000068
       mov       rcx,[rcx]
       mov       r8,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],r8
       jne       near ptr M00_L31
       lea       rcx,[rdx+0C]
       mov       r8d,[rdx+8]
       add       r8d,r8d
       mov       [rbp-44],r8d
       mov       dword ptr [rbp-50],0B383D32E
       mov       dword ptr [rbp-58],0A4E891D1
       cmp       r8d,8
       jb        near ptr M00_L18
       mov       edx,r8d
       shr       edx,3
       xchg      ax,ax
M00_L11:
       mov       r10d,[rbp-50]
       add       r10d,[rcx]
       mov       [rbp-50],r10d
       mov       r10d,[rcx+4]
       mov       r9d,[rbp-50]
       mov       r11d,[rbp-58]
       xor       r11d,r9d
       rol       r9d,14
       add       r9d,r11d
       rol       r11d,9
       xor       r11d,r9d
       rol       r9d,1B
       add       r9d,r11d
       rol       r11d,13
       mov       [rbp-50],r9d
       mov       [rbp-58],r11d
       add       r10d,[rbp-50]
       mov       [rbp-50],r10d
       mov       r10d,[rbp-50]
       mov       r9d,[rbp-58]
       xor       r9d,r10d
       rol       r10d,14
       add       r10d,r9d
       rol       r9d,9
       xor       r9d,r10d
       rol       r10d,1B
       add       r10d,r9d
       rol       r9d,13
       mov       [rbp-50],r10d
       mov       [rbp-58],r9d
       add       rcx,8
       dec       edx
       jne       short M00_L11
       test      r8b,4
       jne       near ptr M00_L27
M00_L12:
       mov       edx,r8d
       and       rdx,7
       mov       ecx,[rcx+rdx-4]
       shr       ecx,8
       or        ecx,80000000
       not       r8d
       shl       r8d,3
       shrx      ecx,ecx,r8d
M00_L13:
       add       ecx,[rbp-50]
       mov       [rbp-50],ecx
       lea       rcx,[rbp-50]
       lea       rdx,[rbp-58]
       call      qword ptr [7FF9E6465398]; System.Marvin.Block(UInt32 ByRef, UInt32 ByRef)
       lea       rcx,[rbp-50]
       lea       rdx,[rbp-58]
       call      qword ptr [7FF9E6465398]; System.Marvin.Block(UInt32 ByRef, UInt32 ByRef)
       mov       eax,[rbp-58]
       xor       eax,[rbp-50]
M00_L14:
       mov       [rbp-3C],eax
       mov       rdx,[r15+8]
       mov       ecx,eax
       imul      rcx,[r15+20]
       shr       rcx,20
       inc       rcx
       mov       r8d,[rdx+8]
       mov       r11d,r8d
       imul      rcx,r11
       shr       rcx,20
       cmp       ecx,r8d
       jae       near ptr M00_L38
       mov       ecx,ecx
       lea       r10,[rdx+rcx*4+10]
       mov       [rbp-88],r10
       mov       r9d,[r10]
       dec       r9d
       jns       near ptr M00_L21
M00_L15:
       cmp       dword ptr [r15+30],0
       jg        near ptr M00_L23
       mov       edx,[r15+28]
       mov       [rbp-40],edx
       cmp       [r14+8],edx
       je        near ptr M00_L34
M00_L16:
       mov       edx,[rbp-40]
       mov       r14d,edx
       lea       ecx,[r14+1]
       mov       [r15+28],ecx
       mov       rcx,[r15+10]
       mov       r8,rcx
M00_L17:
       cmp       r14d,[r8+8]
       jae       near ptr M00_L38
       mov       ecx,r14d
       shl       rcx,4
       mov       [rbp-80],r8
       lea       rcx,[r8+rcx+10]
       mov       [rcx+8],eax
       mov       r10,[rbp-88]
       mov       edx,[r10]
       dec       edx
       mov       [rcx+0C],edx
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       inc       r14d
       mov       rdx,[rbp-88]
       mov       [rdx],r14d
       inc       dword ptr [r15+34]
       cmp       r12d,64
       jbe       near ptr M00_L07
       jmp       near ptr M00_L35
M00_L18:
       cmp       r8d,4
       jb        near ptr M00_L28
M00_L19:
       mov       edx,[rbp-50]
       mov       [rbp-98],rcx
       add       edx,[rcx]
       mov       [rbp-50],edx
       lea       rcx,[rbp-50]
       lea       rdx,[rbp-58]
       call      qword ptr [7FF9E6465398]; System.Marvin.Block(UInt32 ByRef, UInt32 ByRef)
       mov       rax,[rbp-78]
       mov       rcx,[rbp-98]
       mov       r8d,[rbp-44]
       jmp       near ptr M00_L12
M00_L20:
       xor       edx,edx
       xor       r10d,r10d
       mov       eax,r10d
       jmp       near ptr M00_L14
M00_L21:
       cmp       r9d,[r14+8]
       jae       near ptr M00_L38
       mov       edx,r9d
       shl       rdx,4
       lea       r9,[r14+rdx+10]
       mov       [rbp-90],r9
       cmp       [r9+8],eax
       je        near ptr M00_L33
M00_L22:
       mov       r9d,[r9+0C]
       inc       r12d
       cmp       [r14+8],r12d
       jb        near ptr M00_L37
       test      r9d,r9d
       mov       eax,[rbp-3C]
       jge       short M00_L21
       jmp       near ptr M00_L15
M00_L23:
       mov       ecx,[r15+2C]
       mov       r8d,ecx
       dec       dword ptr [r15+30]
       cmp       ecx,[r14+8]
       jae       near ptr M00_L38
       shl       rcx,4
       mov       ecx,[r14+rcx+1C]
       neg       ecx
       add       ecx,0FFFFFFFD
       mov       [r15+2C],ecx
       mov       ecx,r8d
       mov       r8,r14
       mov       r14d,ecx
       jmp       near ptr M00_L17
M00_L24:
       mov       rcx,rax
       mov       r11,7FF9E5B10D40
       call      qword ptr [r11]
       mov       rsi,rax
       mov       rax,[rbp-78]
       jmp       near ptr M00_L09
M00_L25:
       mov       rcx,r15
       xor       edx,edx
       call      qword ptr [7FF9E5D97750]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       mov       rax,[rbp-78]
       jmp       near ptr M00_L10
M00_L26:
       xor       ecx,ecx
       mov       eax,ecx
       jmp       near ptr M00_L14
M00_L27:
       jmp       near ptr M00_L19
M00_L28:
       mov       r8d,[rbp-44]
       mov       edx,80
       test      r8b,1
       je        short M00_L29
       mov       edx,r8d
       and       rdx,2
       movzx     edx,byte ptr [rcx+rdx]
       or        edx,8000
M00_L29:
       test      r8b,2
       je        short M00_L30
       shl       edx,10
       movzx     ecx,word ptr [rcx]
       or        edx,ecx
       mov       ecx,edx
       jmp       near ptr M00_L13
M00_L30:
       mov       ecx,edx
       jmp       near ptr M00_L13
M00_L31:
       mov       r8,[rcx]
       mov       r8,[r8+48]
       call      qword ptr [r8+18]
       jmp       near ptr M00_L14
M00_L32:
       mov       rcx,r13
       mov       rdx,rsi
       mov       r11,7FF9E5B10D58
       call      qword ptr [r11]
       jmp       near ptr M00_L14
M00_L33:
       mov       rdx,[r9]
       mov       rcx,r13
       mov       r8,rsi
       mov       r11,7FF9E5B10D60
       call      qword ptr [r11]
       test      eax,eax
       mov       r9,[rbp-90]
       jne       near ptr M00_L07
       jmp       near ptr M00_L22
M00_L34:
       mov       rcx,r15
       call      qword ptr [7FF9E63AFB28]
       mov       rcx,[r15+8]
       mov       r14d,[rbp-3C]
       mov       edx,r14d
       imul      rdx,[r15+20]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       imul      rdx,rax
       shr       rdx,20
       cmp       edx,[rcx+8]
       jae       short M00_L38
       mov       edx,edx
       lea       r10,[rcx+rdx*4+10]
       mov       rax,r10
       mov       [rbp-88],rax
       mov       eax,r14d
       jmp       near ptr M00_L16
M00_L35:
       mov       r14,[rbp-80]
       mov       rdx,r13
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M00_L07
       mov       edx,[r14+8]
       mov       rcx,r15
       mov       r8d,1
       call      qword ptr [7FF9E5F3D980]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,r15
       mov       rdx,rsi
       call      qword ptr [7FF9E5D97810]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       jmp       near ptr M00_L07
M00_L36:
       mov       r11,7FF9E5B10D38
       call      qword ptr [r11]
       jmp       near ptr M00_L08
M00_L37:
       call      qword ptr [7FF9E5BCF498]
       int       3
M00_L38:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L39:
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-78]
       cmp       [rax],rcx
       jne       near ptr M00_L55
M00_L40:
       mov       ecx,[r15+28]
       test      ecx,ecx
       jle       short M00_L41
       mov       rax,[r15+10]
       mov       eax,[rax+8]
       cdq
       idiv      ecx
       cmp       eax,3
       jg        near ptr M00_L56
M00_L41:
       mov       ecx,[r15+28]
       sub       ecx,[r15+30]
       je        near ptr M00_L57
       xor       esi,esi
M00_L42:
       test      rsi,rsi
       jne       short M00_L43
       mov       rdx,r15
       mov       rcx,7FF9E63D01D8
       call      qword ptr [7FF9E63A5848]; System.Collections.Frozen.FrozenSet.CreateFromSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
       mov       rsi,rax
M00_L43:
       mov       [rbp-60],rsi
       mov       rcx,[rbx+60]
       lea       r8,[rbp-60]
       mov       rdx,7FF9E63DAF48
       cmp       [rcx],ecx
       call      qword ptr [7FF9E63A6B68]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
M00_L44:
       call      qword ptr [7FF9E616F000]
       mov       ecx,65
       mov       rdx,7FF9E5FC8D68
       call      qword ptr [7FF9E5BCF228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF9E5E95AC0
       call      qword ptr [7FF9E5BCF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9E5BCD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9E5FC8D68
       call      qword ptr [7FF9E5BCF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9E5BCD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9E63AD530]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9E63AD548]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L45:
       mov       r11,7FF9E5B10D18
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L00
M00_L46:
       mov       rcx,rsi
       mov       r11,7FF9E5B10D10
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L00
M00_L47:
       mov       rcx,[r14+8]
       mov       rdx,rdi
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       test      eax,eax
       je        near ptr M00_L01
       xor       r15d,r15d
       mov       rsi,r14
       jmp       near ptr M00_L42
M00_L48:
       mov       ecx,[r15+28]
       sub       ecx,[r15+30]
       je        near ptr M00_L41
       mov       rcx,r15
       call      qword ptr [7FF9E63A61D8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].get_Comparer()
       mov       rcx,rax
       mov       rdx,rdi
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       test      eax,eax
       jne       near ptr M00_L41
       jmp       near ptr M00_L02
M00_L49:
       mov       r8,r14
       mov       rdx,r15
       mov       rcx,offset MT_System.Collections.Generic.HashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FF9E64652A8]
       test      eax,eax
       je        near ptr M00_L03
       mov       rcx,r15
       mov       rdx,r14
       call      qword ptr [7FF9E63AFB88]
       jmp       near ptr M00_L41
M00_L50:
       mov       r11,7FF9E5B10D28
       call      qword ptr [r11]
       mov       ecx,eax
       jmp       near ptr M00_L04
M00_L51:
       mov       rcx,rsi
       mov       r11,7FF9E5B10D20
       call      qword ptr [r11]
       mov       ecx,eax
       jmp       near ptr M00_L04
M00_L52:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,243CC000AC8
       mov       r14,[rcx]
       jmp       near ptr M00_L06
M00_L53:
       mov       rcx,rsi
       mov       r11,7FF9E5B10D50
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L06
M00_L54:
       mov       rcx,rsi
       mov       r11,7FF9E5B10D30
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L06
M00_L55:
       mov       rcx,rax
       mov       r11,7FF9E5B10D48
       call      qword ptr [r11]
       jmp       near ptr M00_L40
M00_L56:
       mov       edx,ecx
       sub       edx,[r15+30]
       mov       rcx,r15
       call      qword ptr [7FF9E63AFBA0]
       jmp       near ptr M00_L41
M00_L57:
       mov       rcx,offset MT_System.Collections.Frozen.FrozenSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,243CC000AD0
       mov       rcx,[rcx]
       cmp       rdi,[rcx+8]
       je        short M00_L58
       mov       rcx,offset MT_System.Collections.Frozen.EmptyFrozenSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L42
M00_L58:
       mov       rcx,offset MT_System.Collections.Frozen.FrozenSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,243CC000AD0
       mov       rsi,[rdx]
       jmp       near ptr M00_L42
M00_L59:
       xor       r8d,r8d
       mov       [rbp-70],r8
       mov       [rbp-68],r8d
       lea       r8,[rbp-70]
       mov       rcx,7FF9E6497098
       xor       edx,edx
       call      qword ptr [7FF9E6465338]
       mov       rsi,rax
       jmp       near ptr M00_L43
       sub       rsp,28
       cmp       qword ptr [rbp-78],0
       je        short M00_L60
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-78]
       cmp       [rax],rcx
       je        short M00_L60
       mov       rcx,rax
       mov       r11,7FF9E5B10D48
       call      qword ptr [r11]
M00_L60:
       nop
       add       rsp,28
       ret
; Total bytes of code 2510
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
       mov       rcx,7FF9ED480B08
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
       call      qword ptr [7FF9E63AEA90]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9E5F35E60]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M02_L03:
       mov       esi,ebx
       or        esi,1
       jmp       short M02_L06
M02_L04:
       mov       ecx,esi
       call      qword ptr [7FF9E63AEAA8]
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
; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx]
       mov       rdx,rcx
       mov       eax,[rbx+10]
       cmp       eax,[rcx+14]
       jne       short M03_L01
       mov       ecx,[rbx+14]
       cmp       ecx,[rdx+10]
       jae       short M03_L00
       mov       rdx,[rdx+8]
       cmp       ecx,[rdx+8]
       jae       short M03_L02
       mov       ecx,ecx
       mov       rdx,[rdx+rcx*8+10]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       dword ptr [rbx+14]
       mov       eax,1
       add       rsp,20
       pop       rbx
       ret
M03_L00:
       xor       eax,eax
       mov       [rbx+8],rax
       mov       dword ptr [rbx+14],0FFFFFFFF
       add       rsp,20
       pop       rbx
       ret
M03_L01:
       call      qword ptr [7FF9E5BCFC60]
       int       3
M03_L02:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 101
```
```assembly
; System.Marvin.Block(UInt32 ByRef, UInt32 ByRef)
       mov       eax,[rcx]
       mov       r8d,eax
       xor       r8d,[rdx]
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       mov       [rcx],eax
       mov       [rdx],r8d
       ret
; Total bytes of code 37
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
       call      qword ptr [7FF9E5BC5A88]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       esi,eax
       movsxd    rdx,esi
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rdi,rax
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+0B0]
       test      rax,rax
       je        short M05_L01
       mov       rcx,rax
M05_L00:
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
M05_L01:
       mov       rdx,7FF9E643B9B0
       call      qword ptr [7FF9E5BCF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M05_L00
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
       call      qword ptr [7FF9EE0E7EC8]
       mov       rcx,rax
       movsxd    rdx,esi
       call      qword ptr [7FF9EE0E4088]; CORINFO_HELP_NEWARR_1_DIRECT
       mov       rbp,rax
       mov       r14d,[rbx+28]
       mov       rcx,[rbx+10]
       mov       rdx,rbp
       mov       r8d,r14d
       call      qword ptr [7FF9EE0F52F0]; Precode of System.Array.Copy(System.Array, System.Array, Int32)
       movzx     ecx,dil
       test      cl,1
       jne       near ptr M06_L06
M06_L00:
       movsxd    rcx,esi
       call      qword ptr [7FF9EE0F1B50]
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      qword ptr [7FF9EE0E3FE8]; CORINFO_HELP_ASSIGN_REF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,esi
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rbx+20],rax
       xor       ecx,ecx
       test      r14d,r14d
       jle       short M06_L03
       cmp       [rbp+8],r14d
       jl        near ptr M06_L04
M06_L01:
       mov       edx,ecx
       shl       rdx,4
       lea       rdx,[rbp+rdx+10]
       cmp       dword ptr [rdx+0C],0FFFFFFFF
       jl        short M06_L02
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
       jae       near ptr M06_L11
       mov       r10d,r10d
       lea       rax,[r8+r10*4+10]
       mov       r8d,[rax]
       dec       r8d
       mov       [rdx+0C],r8d
       lea       edx,[rcx+1]
       mov       [rax],edx
M06_L02:
       inc       ecx
       cmp       ecx,r14d
       jl        short M06_L01
M06_L03:
       lea       rcx,[rbx+10]
       mov       rdx,rbp
       call      qword ptr [7FF9EE0E3FE8]; CORINFO_HELP_ASSIGN_REF
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
M06_L04:
       cmp       ecx,[rbp+8]
       jae       near ptr M06_L11
       mov       eax,ecx
       shl       rax,4
       lea       rdx,[rbp+rax+10]
       cmp       dword ptr [rdx+0C],0FFFFFFFF
       jl        short M06_L05
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
       jae       near ptr M06_L11
       mov       eax,r10d
       lea       rax,[r8+rax*4+10]
       mov       r8d,[rax]
       dec       r8d
       mov       [rdx+0C],r8d
       lea       edx,[rcx+1]
       mov       [rax],edx
M06_L05:
       inc       ecx
       cmp       ecx,r14d
       jl        short M06_L04
       jmp       near ptr M06_L03
M06_L06:
       mov       rcx,[rbx]
       call      qword ptr [7FF9EE0E74F8]
       mov       rdi,rax
       mov       rcx,[rbx+18]
       call      qword ptr [7FF9EE0F3730]
       mov       rcx,rax
       lea       r11,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       [rcx],ecx
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF9EE0E4090]; Precode of System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdi,rax
       lea       rcx,[rbx+18]
       mov       rdx,rdi
       call      qword ptr [7FF9EE0E3FE8]; CORINFO_HELP_ASSIGN_REF
       xor       r15d,r15d
       cmp       r15d,r14d
       jge       near ptr M06_L00
M06_L07:
       cmp       r15d,[rbp+8]
       jae       short M06_L11
       mov       rcx,r15
       shl       rcx,4
       lea       r13,[rbp+rcx+10]
       cmp       dword ptr [r13+0C],0FFFFFFFF
       jl        short M06_L10
       cmp       qword ptr [r13],0
       jne       short M06_L08
       xor       r12d,r12d
       jmp       short M06_L09
M06_L08:
       mov       rcx,[rbx]
       call      qword ptr [7FF9EE0E9150]
       mov       rdx,[r13]
       mov       rcx,rdi
       mov       r11,rax
       call      qword ptr [rax]
       mov       r12d,eax
M06_L09:
       mov       [r13+8],r12d
M06_L10:
       inc       r15d
       cmp       r15d,r14d
       jl        short M06_L07
       jmp       near ptr M06_L00
M06_L11:
       call      qword ptr [7FF9EE0E3FD8]
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
       je        near ptr M07_L07
       mov       rdi,[rbx+10]
       xor       ebp,ebp
       mov       r14,[rbx+18]
       test      rsi,rsi
       je        near ptr M07_L11
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+78]
       test      r11,r11
       je        near ptr M07_L08
M07_L00:
       mov       rcx,offset MT_System.Collections.Generic.ObjectEqualityComparer<System.RuntimeType>
       cmp       [r14],rcx
       jne       near ptr M07_L13
       mov       [rsp+38],rsi
       xor       ecx,ecx
       mov       [rsp+30],rcx
       lea       rcx,[rsp+38]
       cmp       qword ptr [rsp+30],0
       jne       short M07_L01
       mov       rcx,[rsp+38]
       mov       [rsp+30],rcx
       lea       rcx,[rsp+30]
       cmp       qword ptr [rsp+30],0
       je        near ptr M07_L12
M07_L01:
       mov       r15,[rcx]
       mov       rcx,offset MT_System.RuntimeType
       cmp       [r15],rcx
       jne       near ptr M07_L10
       mov       rcx,r15
       call      00007FFA45809590
       test      eax,eax
       je        near ptr M07_L09
M07_L02:
       mov       r15d,eax
M07_L03:
       xor       ecx,ecx
       mov       [rsp+30],rcx
M07_L04:
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
       jae       near ptr M07_L18
       mov       edx,edx
       lea       rcx,[rcx+rdx*4+10]
       mov       r13d,[rcx]
       dec       r13d
       js        short M07_L07
M07_L05:
       mov       r12d,[rdi+8]
       cmp       r13d,r12d
       jae       near ptr M07_L18
       mov       ecx,r13d
       shl       rcx,4
       lea       rax,[rdi+rcx+10]
       mov       [rsp+28],rax
       cmp       [rax+8],r15d
       je        near ptr M07_L14
M07_L06:
       mov       rax,[rsp+28]
       mov       r13d,[rax+0C]
       inc       ebp
       cmp       r12d,ebp
       jb        near ptr M07_L17
       test      r13d,r13d
       jge       short M07_L05
M07_L07:
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
M07_L08:
       mov       rdx,7FF9E6436508
       call      qword ptr [7FF9E5BCF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M07_L00
M07_L09:
       mov       rcx,r15
       call      qword ptr [7FF9E5D977F8]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       jmp       near ptr M07_L02
M07_L10:
       mov       rcx,r15
       mov       rax,[r15]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
       mov       r15d,eax
       jmp       near ptr M07_L03
M07_L11:
       xor       r15d,r15d
       jmp       near ptr M07_L04
M07_L12:
       xor       r15d,r15d
       jmp       near ptr M07_L03
M07_L13:
       mov       rcx,r14
       mov       rdx,rsi
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       near ptr M07_L04
M07_L14:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+80]
       test      r11,r11
       je        short M07_L15
       jmp       short M07_L16
M07_L15:
       mov       rdx,7FF9E6436520
       call      qword ptr [7FF9E5BCF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M07_L16:
       mov       rax,[rsp+28]
       mov       rdx,[rax]
       mov       rcx,r14
       mov       r8,rsi
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M07_L06
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
M07_L17:
       call      qword ptr [7FF9E5BCF498]
       int       3
M07_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 547
```
```assembly
; System.Collections.Frozen.FrozenSet.CreateFromSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,188
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+0D0],ymm4
       mov       [rsp+180],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rcx,[rbx]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rdx,offset MT_System.String
       cmp       [rcx],rdx
       je        near ptr M08_L54
       mov       rdi,[rbx+18]
       test      rdi,rdi
       je        near ptr M08_L57
M08_L00:
       mov       rcx,[rsi+18]
       mov       rdx,offset MT_System.String
       cmp       [rcx],rdx
       je        near ptr M08_L60
M08_L01:
       mov       ecx,[rbx+28]
       sub       ecx,[rbx+30]
       cmp       ecx,4
       jle       near ptr M08_L89
       mov       rcx,[rsi+18]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        near ptr M08_L30
M08_L02:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,[rbx]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rdx,offset MT_System.String
       cmp       [rcx],rdx
       je        near ptr M08_L92
       mov       rdx,[rbx+18]
       test      rdx,rdx
       je        near ptr M08_L95
M08_L03:
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+10],rcx
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx+8]
       mov       rax,[rdx+20]
       test      rax,rax
       je        near ptr M08_L31
M08_L04:
       lea       rcx,[rsi+10]
       mov       rdx,rsi
       call      rax
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx+10]
       mov       rdi,[rdx+28]
       test      rdi,rdi
       je        near ptr M08_L32
M08_L05:
       mov       rcx,rdi
       mov       ebp,[rbx+28]
       sub       ebp,[rbx+30]
       mov       [rsp+0CC],ebp
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       xor       r15d,r15d
       mov       r13d,ebp
       test      r13d,r13d
       jl        near ptr M08_L98
       mov       r12,[rbx+10]
       xor       eax,eax
       cmp       dword ptr [rbx+28],0
       jle       short M08_L08
M08_L06:
       test      r13d,r13d
       je        short M08_L08
       cmp       eax,[r12+8]
       jae       near ptr M08_L154
       mov       [rsp+0C0],rax
       mov       r8,rax
       shl       r8,4
       lea       r8,[r12+r8+10]
       cmp       dword ptr [r8+0C],0FFFFFFFF
       jl        short M08_L07
       lea       edx,[r15+1]
       mov       [rsp+15C],edx
       mov       r8,[r8]
       movsxd    rdx,r15d
       mov       rcx,r14
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       dec       r13d
       mov       r15d,[rsp+15C]
M08_L07:
       mov       rax,[rsp+0C0]
       inc       eax
       mov       rcx,rax
       cmp       ecx,[rbx+28]
       mov       rax,rcx
       jl        short M08_L06
M08_L08:
       mov       rcx,rdi
       mov       edx,ebp
       call      CORINFO_HELP_NEWARR_1_PTR
       lea       rcx,[rsi+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,243B6001D88
       mov       r13,[rcx]
       mov       [rsp+40],r13
       mov       rcx,r13
       mov       edx,ebp
       call      qword ptr [7FF9E61D6F48]; System.Buffers.SharedArrayPool`1[[System.Int32, System.Private.CoreLib]].Rent(Int32)
       mov       rbx,rax
       mov       [rsp+0B8],rbx
       mov       edi,ebp
       test      rbx,rbx
       je        near ptr M08_L99
       cmp       [rbx+8],edi
       jb        near ptr M08_L108
       lea       r15,[rbx+10]
M08_L09:
       xor       r12d,r12d
       cmp       ebp,r12d
       jg        near ptr M08_L50
M08_L10:
       mov       rcx,r15
       mov       r12d,edi
       mov       [rsp+0E0],rcx
       mov       [rsp+0E8],r12d
       lea       rcx,[rsp+0E0]
       xor       edx,edx
       call      qword ptr [7FF9E63A68E0]; System.Collections.Frozen.FrozenHashTable.CalcNumBuckets(System.ReadOnlySpan`1<Int32>, Boolean)
       mov       r8d,eax
       mov       [rsp+158],r8d
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,r8d
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rsp+150],rax
       mov       rcx,r13
       lea       edx,[r8+r12]
       call      qword ptr [7FF9E61D6F48]; System.Buffers.SharedArrayPool`1[[System.Int32, System.Private.CoreLib]].Rent(Int32)
       mov       [rsp+0A0],rax
       test      rax,rax
       je        near ptr M08_L106
       mov       edx,[rsp+158]
       cmp       [rax+8],edx
       jb        near ptr M08_L108
       lea       r8,[rax+10]
       mov       r10d,edx
M08_L11:
       mov       [rsp+58],r8
       mov       [rsp+100],r10d
       test      rax,rax
       je        near ptr M08_L107
       mov       ecx,edx
       mov       r9d,r12d
       add       rcx,r9
       mov       r9d,[rax+8]
       cmp       rcx,r9
       ja        near ptr M08_L108
       mov       edx,edx
       lea       r9,[rax+rdx*4+10]
M08_L12:
       mov       [rsp+50],r9
       mov       [rsp+0FC],r12d
       mov       edx,r10d
       mov       rcx,rdx
       cmp       rcx,8
       jb        near ptr M08_L110
       lea       r11,[rcx*4]
       mov       [rsp+140],r11
       and       r11,0FFFFFFFFFFFFFFC0
       xor       r13d,r13d
       cmp       rcx,10
       jb        short M08_L14
       nop       dword ptr [rax]
       nop       dword ptr [rax+rax]
M08_L13:
       vpcmpeqd  ymm0,ymm0,ymm0
       vmovups   [r8+r13],ymm0
       vmovups   [r8+r13+20],ymm0
       add       r13,40
       cmp       r13,r11
       jb        short M08_L13
M08_L14:
       mov       r11,[rsp+140]
       test      r11b,20
       jne       near ptr M08_L109
M08_L15:
       vpcmpeqd  ymm0,ymm0,ymm0
       vmovups   [r8+r11-20],ymm0
M08_L16:
       xor       ecx,ecx
       test      edi,edi
       jle       near ptr M08_L35
       cmp       edi,r12d
       jg        near ptr M08_L34
       jmp       short M08_L17
M08_L17:
       mov       r11d,ecx
       mov       r11d,[r15+r11*4]
       mov       r13,[rsp+150]
       imul      r11,r13
       shr       r11,20
       inc       r11
       imul      r11,rdx
       shr       r11,20
       cmp       r11d,r10d
       jae       near ptr M08_L154
       mov       r11d,r11d
       lea       r11,[r8+r11*4]
       mov       ebx,ecx
       mov       eax,[r11]
       mov       [r9+rbx*4],eax
       mov       [r11],ecx
       inc       ecx
       cmp       ecx,edi
       jl        short M08_L17
M08_L18:
       mov       edx,edi
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbx,rax
       mov       edx,[rsp+100]
       mov       rcx,offset MT_System.Collections.Frozen.FrozenHashTable+Bucket[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       [rsp+98],rax
       xor       ecx,ecx
       xor       edx,edx
       mov       r8d,[rax+8]
       mov       [rsp+0C8],r8d
       test      r8d,r8d
       jle       near ptr M08_L114
       mov       r10d,[rsp+100]
       cmp       r8d,r10d
       jg        near ptr M08_L41
       xor       edx,edx
       jmp       near ptr M08_L38
M08_L19:
       mov       rax,[rsp+98]
M08_L20:
       mov       r12,[rsp+40]
       mov       rdx,r12
       mov       [rsp+90],rdx
       mov       r8,[rsp+0A0]
       test      r8,r8
       je        near ptr M08_L136
       mov       rdx,[rsp+90]
       mov       ecx,[r8+8]
       dec       ecx
       or        ecx,0F
       xor       r10d,r10d
       lzcnt     r10d,ecx
       xor       r10d,1F
       add       r10d,0FFFFFFFD
       mov       [rsp+13C],r10d
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],7
       jle       near ptr M08_L116
       mov       rcx,[rcx+240]
       mov       r9,[rcx+38]
       test      r9,r9
       je        near ptr M08_L115
M08_L21:
       mov       [rsp+48],r9
       mov       r11,[r9+10]
       test      r11,r11
       je        near ptr M08_L117
M08_L22:
       xor       ecx,ecx
       mov       dword ptr [rsp+134],1
       mov       r10d,[rsp+13C]
       cmp       [r11+8],r10d
       jbe       near ptr M08_L23
       mov       dword ptr [rsp+138],1
       mov       edx,10
       shlx      edx,edx,r10d
       mov       r8,[rsp+0A0]
       cmp       [r8+8],edx
       jne       near ptr M08_L118
       mov       edx,r10d
       shl       rdx,4
       lea       r11,[r11+rdx+10]
       mov       [rsp+80],r11
       mov       rdx,[r11]
       mov       [rsp+78],rdx
       mov       rcx,r11
       mov       rdx,r8
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       rdx,[rsp+80]
       mov       [rdx+8],ecx
       cmp       qword ptr [rsp+78],0
       jne       near ptr M08_L119
       mov       rax,[rsp+98]
       mov       ecx,[rsp+138]
       mov       r10d,[rsp+13C]
M08_L23:
       mov       r11,243B6000C90
       mov       r11,[r11]
       mov       [rsp+38],r11
       mov       rdx,r11
       mov       [rsp+88],rdx
       cmp       byte ptr [rdx+9D],0
       jne       near ptr M08_L132
M08_L24:
       lea       rcx,[rsi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+28]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rsi+30],r13
       xor       ebx,ebx
       test      edi,edi
       jle       short M08_L26
       mov       ebp,[rsp+0CC]
       cmp       ebp,edi
       jl        near ptr M08_L43
       xor       ebx,ebx
M08_L25:
       mov       r13d,[r15+rbx]
       mov       rcx,[rsi+18]
       mov       r8,[r14+rbx*2+10]
       movsxd    rdx,r13d
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       add       rbx,4
       dec       edi
       jne       short M08_L25
M08_L26:
       mov       rbx,[rsp+0B8]
       test      rbx,rbx
       je        near ptr M08_L136
       mov       ecx,[rbx+8]
       dec       ecx
       or        ecx,0F
       xor       edi,edi
       lzcnt     edi,ecx
       xor       edi,1F
       add       edi,0FFFFFFFD
       mov       rbp,[rsp+48]
       mov       rax,[rbp+10]
       test      rax,rax
       je        near ptr M08_L137
M08_L27:
       xor       ebp,ebp
       mov       r14d,1
       cmp       [rax+8],edi
       jbe       short M08_L28
       mov       ebp,1
       mov       ecx,10
       shlx      ecx,ecx,edi
       cmp       [rbx+8],ecx
       jne       near ptr M08_L138
       cmp       edi,[rax+8]
       jae       near ptr M08_L154
       mov       ecx,edi
       shl       rcx,4
       lea       r15,[rax+rcx+10]
       mov       r13,[r15]
       mov       rcx,r15
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r15+8],ecx
       test      r13,r13
       jne       near ptr M08_L139
M08_L28:
       mov       r15,[rsp+38]
       cmp       byte ptr [r15+9D],0
       jne       near ptr M08_L151
M08_L29:
       mov       rax,rsi
       vzeroupper
       add       rsp,188
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M08_L30:
       mov       rcx,rsi
       mov       rdx,7FF9E643EBA0
       call      qword ptr [7FF9E5BCF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M08_L02
M08_L31:
       mov       rdx,7FF9E64805D8
       call      qword ptr [7FF9E5BCF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M08_L04
M08_L32:
       mov       rdx,7FF9E6480500
       call      qword ptr [7FF9E5BCF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M08_L05
M08_L33:
       mov       r8,[rsp+58]
       mov       r9,[rsp+50]
       mov       r10d,[rsp+100]
M08_L34:
       mov       r11d,ecx
       mov       r11d,[r15+r11*4]
       imul      r11,[rsp+150]
       shr       r11,20
       inc       r11
       imul      r11,rdx
       shr       r11,20
       cmp       r11d,r10d
       jae       near ptr M08_L154
       mov       r11d,r11d
       lea       r11,[r8+r11*4]
       cmp       ecx,r12d
       jae       near ptr M08_L154
       mov       ebx,ecx
       mov       [rsp+178],rbx
       mov       ebx,[r11]
       mov       rax,[rsp+178]
       mov       [r9+rax*4],ebx
       mov       [r11],ecx
       inc       ecx
       cmp       ecx,edi
       mov       r12d,[rsp+0FC]
       jl        short M08_L33
       jmp       near ptr M08_L113
M08_L35:
       mov       r13,[rsp+150]
       jmp       near ptr M08_L18
M08_L36:
       cmp       r11d,edi
       jae       near ptr M08_L154
       mov       eax,r11d
       lea       rax,[r15+rax*4]
       mov       ebp,[rax]
       cmp       ecx,[rbx+8]
       jae       near ptr M08_L154
       mov       r12d,ecx
       mov       [rbx+r12*4+10],ebp
       mov       [rax],ecx
       inc       ecx
       inc       r10d
       mov       r12d,[rsp+0FC]
       cmp       r11d,r12d
       jae       near ptr M08_L154
       mov       r11d,r11d
       mov       rbp,[rsp+50]
       mov       r11d,[rbp+r11*4]
       test      r11d,r11d
       jge       short M08_L36
       lea       r11d,[r13+r10-1]
       mov       rax,[rsp+98]
       lea       r10,[rax+rdx*2+10]
       mov       [r10],r13d
       mov       [r10+4],r11d
       mov       r13,[rsp+150]
M08_L37:
       add       rdx,4
       dec       r8d
       je        near ptr M08_L19
M08_L38:
       mov       r9,[rsp+58]
       mov       r11d,[r9+rdx]
       test      r11d,r11d
       jl        short M08_L37
       xor       r10d,r10d
       mov       r13d,ecx
       jmp       near ptr M08_L36
M08_L39:
       mov       rax,[rsp+98]
M08_L40:
       mov       edx,[rsp+14C]
       inc       edx
       cmp       r8d,edx
       mov       r10d,[rsp+100]
       jle       near ptr M08_L20
M08_L41:
       cmp       edx,r10d
       jae       near ptr M08_L154
       mov       [rsp+14C],edx
       mov       r11d,edx
       mov       r9,[rsp+58]
       mov       r11d,[r9+r11*4]
       test      r11d,r11d
       jl        short M08_L39
       xor       r8d,r8d
       mov       edx,ecx
M08_L42:
       cmp       r11d,edi
       jae       near ptr M08_L154
       mov       eax,r11d
       lea       rax,[r15+rax*4]
       mov       r13d,[rax]
       cmp       ecx,[rbx+8]
       jae       near ptr M08_L154
       mov       r10d,ecx
       mov       [rbx+r10*4+10],r13d
       mov       [rax],ecx
       inc       ecx
       inc       r8d
       cmp       r11d,r12d
       jae       near ptr M08_L154
       mov       r11d,r11d
       mov       r13,[rsp+50]
       mov       r11d,[r13+r11*4]
       test      r11d,r11d
       jge       short M08_L42
       mov       r13,[rsp+150]
       lea       r11d,[rdx+r8-1]
       mov       r8d,[rsp+14C]
       mov       rax,[rsp+98]
       lea       r8,[rax+r8*8+10]
       mov       [r8],edx
       mov       [r8+4],r11d
       mov       rax,[rsp+98]
       mov       r8d,[rsp+0C8]
       jmp       near ptr M08_L40
M08_L43:
       cmp       ebx,edi
       jae       near ptr M08_L154
       mov       ecx,ebx
       mov       r13d,[r15+rcx*4]
       mov       rcx,[rsi+18]
       cmp       ebx,ebp
       jae       near ptr M08_L154
       mov       r8d,ebx
       mov       r8,[r14+r8*8+10]
       movsxd    rdx,r13d
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       inc       ebx
       cmp       ebx,edi
       jl        short M08_L43
       jmp       near ptr M08_L26
M08_L44:
       mov       rcx,[rsi+8]
       mov       rdx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rdx
       jne       near ptr M08_L105
       mov       r8,[rsp+0B0]
       mov       rdx,[r8+28]
       test      rdx,rdx
       je        near ptr M08_L100
       mov       rcx,243B6000068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M08_L104
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,0B383D32E
       mov       r8d,0A4E891D1
       cmp       edx,8
       jb        near ptr M08_L51
       mov       r9d,edx
       shr       r9d,3
M08_L45:
       add       eax,[rcx]
       mov       r11d,[rcx+4]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       add       r11d,eax
       mov       eax,r8d
       xor       eax,r11d
       rol       r11d,14
       add       r11d,eax
       rol       eax,9
       xor       eax,r11d
       rol       r11d,1B
       add       r11d,eax
       rol       eax,13
       mov       r8d,r11d
       add       rcx,8
       dec       r9d
       mov       r10d,eax
       mov       eax,r8d
       mov       r8d,r10d
       jne       short M08_L45
       test      dl,4
       jne       near ptr M08_L52
M08_L46:
       mov       r9d,edx
       and       r9,7
       mov       ecx,[rcx+r9-4]
       shr       ecx,8
       or        ecx,80000000
       not       edx
       shl       edx,3
       shrx      ecx,ecx,edx
M08_L47:
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
       mov       eax,ecx
       rol       eax,14
       add       eax,edx
       rol       edx,9
       xor       edx,eax
       rol       eax,1B
       add       eax,edx
       mov       r8d,edx
       rol       r8d,13
       xor       eax,r8d
M08_L48:
       mov       r10,[rsp+0A8]
M08_L49:
       mov       [r10],eax
       inc       r12d
       cmp       ebp,r12d
       jle       near ptr M08_L10
       mov       ebp,[rsp+0CC]
M08_L50:
       cmp       r12d,edi
       jae       near ptr M08_L154
       lea       rax,[r15+r12*4]
       mov       r8,[r14+r12*8+10]
       mov       [rsp+0B0],r8
       mov       [rsp+0A8],rax
       test      r8,r8
       je        short M08_L53
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx+10]
       mov       r11,[rdx+30]
       test      r11,r11
       jne       near ptr M08_L44
       mov       rdx,7FF9E6480508
       call      qword ptr [7FF9E5BCF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M08_L44
M08_L51:
       cmp       edx,4
       jb        near ptr M08_L101
M08_L52:
       add       eax,[rcx]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       jmp       near ptr M08_L46
M08_L53:
       mov       r10,rax
       xor       eax,eax
       jmp       near ptr M08_L49
M08_L54:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdi,[rdx+0A0]
       test      rdi,rdi
       je        short M08_L55
       jmp       short M08_L56
M08_L55:
       mov       rdx,7FF9E643B818
       call      qword ptr [7FF9E5BCF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
M08_L56:
       mov       rdx,[rbx+18]
       mov       rcx,offset MT_System.Collections.Generic.IEqualityComparer<System.String>
       call      qword ptr [7FF9E5BC58D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rcx,rax
       call      qword ptr [7FF9E63AFCD8]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF9E5BC58D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdi,rax
       jmp       near ptr M08_L00
M08_L57:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+0A8]
       test      rdx,rdx
       je        short M08_L58
       jmp       short M08_L59
M08_L58:
       mov       rdx,7FF9E643B828
       call      qword ptr [7FF9E5BCF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M08_L59:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdi,[rax]
       jmp       near ptr M08_L00
M08_L60:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF9E5D97810]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       test      eax,eax
       jge       near ptr M08_L01
       mov       rcx,[rsi+18]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       je        short M08_L61
       jmp       short M08_L62
M08_L61:
       mov       rcx,rsi
       mov       rdx,7FF9E643FA58
       call      qword ptr [7FF9E5BCF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M08_L62:
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       cmp       [rax],rdi
       je        short M08_L63
       mov       rdx,243B6000068
       cmp       rdi,[rdx]
       je        short M08_L63
       mov       rdx,243B6000070
       cmp       rdi,[rdx]
       jne       near ptr M08_L01
M08_L63:
       mov       rdx,rdi
       mov       rcx,offset MT_System.Collections.Generic.IEqualityComparer<System.String>
       call      qword ptr [7FF9E5BC58D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdi,rax
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.HashSet<System.String>
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       rbx,rax
       mov       edx,[rbx+28]
       sub       edx,[rbx+30]
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbp,rax
       mov       r9d,[rbx+28]
       sub       r9d,[rbx+30]
       mov       rcx,rbx
       mov       rdx,rbp
       xor       r8d,r8d
       call      qword ptr [7FF9E5F3DA28]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].CopyTo(System.__Canon[], Int32, Int32)
       mov       ebx,7FFFFFFF
       xor       r14d,r14d
       xor       r15d,r15d
       xor       ecx,ecx
       jmp       short M08_L67
M08_L64:
       mov       rdx,[rbp+rcx*8+10]
       cmp       [rdx+8],ebx
       jge       short M08_L65
       mov       ebx,[rdx+8]
M08_L65:
       cmp       [rdx+8],r14d
       jle       short M08_L66
       mov       r14d,[rdx+8]
M08_L66:
       mov       edx,[rdx+8]
       mov       r8d,1
       shlx      rdx,r8,rdx
       or        r15,rdx
       inc       ecx
M08_L67:
       cmp       [rbp+8],ecx
       jg        short M08_L64
       mov       rcx,rbp
       mov       rdx,rdi
       mov       r8d,ebx
       mov       r9d,r14d
       call      qword ptr [7FF9E6464C60]
       mov       r13,rax
       test      r13,r13
       je        short M08_L70
       mov       rcx,[rsi+18]
       cmp       qword ptr [rcx+8],30
       jle       short M08_L68
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M08_L68
       jmp       short M08_L69
M08_L68:
       mov       rcx,rsi
       mov       rdx,7FF9E643FE50
       call      qword ptr [7FF9E5BCF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M08_L69:
       mov       rdx,r13
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       nop
       vzeroupper
       add       rsp,188
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M08_L70:
       lea       rdx,[rbp+10]
       mov       r8d,[rbp+8]
       mov       [rsp+0D0],rdx
       mov       [rsp+0D8],r8d
       mov       [rsp+20],r14d
       lea       rdx,[rsp+0D0]
       mov       r8,243B6000070
       cmp       rdi,[r8]
       sete      r8b
       movzx     r8d,r8b
       lea       rcx,[rsp+160]
       mov       r9d,ebx
       call      qword ptr [7FF9E6464C78]
       mov       ebx,[rsp+168]
       movzx     r14d,byte ptr [rsp+160]
       movzx     r12d,byte ptr [rsp+161]
       mov       r13d,[rsp+164]
       mov       eax,[rsp+16C]
       mov       [rsp+0F8],eax
       mov       edx,[rsp+170]
       mov       [rsp+0F4],edx
       test      ebx,ebx
       je        near ptr M08_L82
       test      r13d,r13d
       jge       near ptr M08_L76
       test      r14d,r14d
       je        near ptr M08_L73
       test      r12d,r12d
       jne       short M08_L71
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_RightJustifiedCaseInsensitiveSubstring
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       r15d,[rsp+0F4]
       mov       [rsp+20],r15d
       mov       [rsp+28],r13d
       mov       [rsp+30],ebx
       mov       rcx,r14
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+0F8]
       call      qword ptr [7FF9E6464C90]
       jmp       short M08_L72
M08_L71:
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_RightJustifiedCaseInsensitiveAsciiSubstring
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       r15d,[rsp+0F4]
       mov       [rsp+20],r15d
       mov       [rsp+28],r13d
       mov       [rsp+30],ebx
       mov       rcx,r14
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+0F8]
       call      qword ptr [7FF9E6464C90]
M08_L72:
       mov       r13,r14
       jmp       near ptr M08_L86
M08_L73:
       cmp       ebx,1
       je        short M08_L74
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_RightJustifiedSubstring
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       r15d,[rsp+0F4]
       mov       [rsp+20],r15d
       mov       [rsp+28],r13d
       mov       [rsp+30],ebx
       mov       rcx,r12
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+0F8]
       call      qword ptr [7FF9E6464C90]
       jmp       short M08_L75
M08_L74:
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_RightJustifiedSingleChar
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       r15d,[rsp+0F4]
       mov       [rsp+20],r15d
       mov       [rsp+28],r13d
       mov       dword ptr [rsp+30],1
       mov       rcx,r12
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+0F8]
       call      qword ptr [7FF9E6464C90]
M08_L75:
       mov       r13,r12
       jmp       near ptr M08_L86
M08_L76:
       test      r14d,r14d
       je        near ptr M08_L79
       test      r12d,r12d
       jne       short M08_L77
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_LeftJustifiedCaseInsensitiveSubstring
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       r15d,[rsp+0F4]
       mov       [rsp+20],r15d
       mov       [rsp+28],r13d
       mov       [rsp+30],ebx
       mov       rcx,r14
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+0F8]
       call      qword ptr [7FF9E6464C90]
       jmp       short M08_L78
M08_L77:
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_LeftJustifiedCaseInsensitiveAsciiSubstring
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       r15d,[rsp+0F4]
       mov       [rsp+20],r15d
       mov       [rsp+28],r13d
       mov       [rsp+30],ebx
       mov       rcx,r14
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+0F8]
       call      qword ptr [7FF9E6464C90]
M08_L78:
       mov       r13,r14
       jmp       near ptr M08_L86
M08_L79:
       cmp       ebx,1
       je        short M08_L80
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_LeftJustifiedSubstring
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       r15d,[rsp+0F4]
       mov       [rsp+20],r15d
       mov       [rsp+28],r13d
       mov       [rsp+30],ebx
       mov       rcx,r12
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+0F8]
       call      qword ptr [7FF9E6464C90]
       jmp       short M08_L81
M08_L80:
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_LeftJustifiedSingleChar
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       r15d,[rsp+0F4]
       mov       [rsp+20],r15d
       mov       [rsp+28],r13d
       mov       dword ptr [rsp+30],1
       mov       rcx,r12
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+0F8]
       call      qword ptr [7FF9E6464C90]
M08_L81:
       mov       r13,r12
       jmp       near ptr M08_L86
M08_L82:
       test      r14d,r14d
       je        short M08_L85
       test      r12d,r12d
       jne       short M08_L83
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_FullCaseInsensitive
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       ebx,[rsp+0F4]
       mov       [rsp+20],ebx
       mov       [rsp+28],r15
       mov       rcx,r13
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+0F8]
       call      qword ptr [7FF9E6464CA8]
       jmp       short M08_L84
M08_L83:
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_FullCaseInsensitiveAscii
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       ebx,[rsp+0F4]
       mov       [rsp+20],ebx
       mov       [rsp+28],r15
       mov       rcx,r13
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+0F8]
       call      qword ptr [7FF9E6464CC0]
M08_L84:
       jmp       short M08_L86
M08_L85:
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_Full
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       ebx,[rsp+0F4]
       mov       [rsp+20],ebx
       mov       [rsp+28],r15
       mov       rcx,r13
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+0F8]
       call      qword ptr [7FF9E6464CD8]
M08_L86:
       mov       rcx,[rsi+18]
       cmp       qword ptr [rcx+8],30
       jle       short M08_L87
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M08_L87
       jmp       short M08_L88
M08_L87:
       mov       rcx,rsi
       mov       rdx,7FF9E643FE50
       call      qword ptr [7FF9E5BCF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M08_L88:
       mov       rdx,r13
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       nop
       vzeroupper
       add       rsp,188
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M08_L89:
       mov       rcx,[rsi+18]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M08_L90
       jmp       short M08_L91
M08_L90:
       mov       rcx,rsi
       mov       rdx,7FF9E643F938
       call      qword ptr [7FF9E5BCF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M08_L91:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF9E64653F8]
       mov       rax,rsi
       vzeroupper
       add       rsp,188
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M08_L92:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdi,[rdx+0A0]
       test      rdi,rdi
       je        short M08_L93
       jmp       short M08_L94
M08_L93:
       mov       rdx,7FF9E643B818
       call      qword ptr [7FF9E5BCF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
M08_L94:
       mov       rdx,[rbx+18]
       mov       rcx,offset MT_System.Collections.Generic.IEqualityComparer<System.String>
       call      qword ptr [7FF9E5BC58D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rcx,rax
       call      qword ptr [7FF9E63AFCD8]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF9E5BC58D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdx,rax
       jmp       near ptr M08_L03
M08_L95:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+0A8]
       test      rdx,rdx
       je        short M08_L96
       jmp       short M08_L97
M08_L96:
       mov       rdx,7FF9E643B828
       call      qword ptr [7FF9E5BCF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M08_L97:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       jmp       near ptr M08_L03
M08_L98:
       mov       ecx,28F
       mov       rdx,7FF9E5B04000
       call      qword ptr [7FF9E5BCF228]
       mov       rdx,rax
       mov       ecx,r13d
       call      qword ptr [7FF9E63ADB90]
       int       3
M08_L99:
       test      edi,edi
       jne       near ptr M08_L108
       xor       r15d,r15d
       xor       edi,edi
       jmp       near ptr M08_L09
M08_L100:
       xor       eax,eax
       jmp       near ptr M08_L48
M08_L101:
       mov       r9d,80
       test      dl,1
       je        short M08_L102
       mov       r9d,edx
       and       r9,2
       movzx     r9d,byte ptr [rcx+r9]
       or        r9d,8000
M08_L102:
       test      dl,2
       je        short M08_L103
       shl       r9d,10
       movzx     ecx,word ptr [rcx]
       or        r9d,ecx
       mov       ecx,r9d
       jmp       near ptr M08_L47
M08_L103:
       mov       ecx,r9d
       jmp       near ptr M08_L47
M08_L104:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       jmp       near ptr M08_L48
M08_L105:
       mov       r8,[rsp+0B0]
       mov       rdx,r8
       call      qword ptr [r11]
       jmp       near ptr M08_L48
M08_L106:
       mov       edx,[rsp+158]
       test      edx,edx
       jne       short M08_L108
       xor       r8d,r8d
       xor       r10d,r10d
       jmp       near ptr M08_L11
M08_L107:
       or        edx,r12d
       jne       short M08_L108
       xor       r9d,r9d
       xor       r12d,r12d
       mov       ecx,r9d
       mov       r9,r12
       mov       r12d,ecx
       jmp       near ptr M08_L12
M08_L108:
       call      qword ptr [7FF9E5D9F228]
       int       3
M08_L109:
       vpcmpeqd  ymm0,ymm0,ymm0
       vmovups   [r8+r13],ymm0
       jmp       near ptr M08_L15
M08_L110:
       xor       r11d,r11d
       test      cl,4
       je        short M08_L111
       mov       dword ptr [r8+r11*4],0FFFFFFFF
       mov       dword ptr [r8+r11*4+4],0FFFFFFFF
       mov       dword ptr [r8+r11*4+8],0FFFFFFFF
       mov       dword ptr [r8+r11*4+0C],0FFFFFFFF
       add       r11,4
M08_L111:
       test      cl,2
       je        short M08_L112
       mov       dword ptr [r8+r11*4],0FFFFFFFF
       mov       dword ptr [r8+r11*4+4],0FFFFFFFF
       add       r11,2
M08_L112:
       test      cl,1
       je        near ptr M08_L16
       mov       dword ptr [r8+r11*4],0FFFFFFFF
       jmp       near ptr M08_L16
M08_L113:
       mov       r13,[rsp+150]
       jmp       near ptr M08_L18
M08_L114:
       mov       rax,[rsp+98]
       jmp       near ptr M08_L20
M08_L115:
       mov       ecx,7
       call      qword ptr [7FF9E63ADDE8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       r9,rax
       mov       rax,[rsp+98]
       mov       rdx,[rsp+90]
       jmp       near ptr M08_L21
M08_L116:
       jmp       short M08_L115
M08_L117:
       mov       rcx,rdx
       call      qword ptr [7FF9E616F480]; System.Buffers.SharedArrayPool`1[[System.Int32, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
       mov       r11,rax
       mov       rax,[rsp+98]
       jmp       near ptr M08_L22
M08_L118:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9E61FEF10]
       mov       rbx,rax
       mov       ecx,29B
       mov       rdx,7FF9E5B04000
       call      qword ptr [7FF9E5BCF228]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9E5F37D50]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M08_L119:
       mov       r8,[rsp+90]
       mov       rcx,[r8+10]
       mov       r10d,[rsp+13C]
       cmp       r10d,[rcx+8]
       jae       near ptr M08_L154
       mov       edx,r10d
       mov       r9,[rcx+rdx*8+10]
       test      r9,r9
       jne       short M08_L121
       mov       rcx,r8
       mov       edx,r10d
       call      qword ptr [7FF9E63AFCC0]
       mov       r9,rax
M08_L120:
       mov       rcx,[r9+8]
       mov       [rsp+70],rcx
       call      qword ptr [7FF9E61FF4E0]; System.Threading.Thread.GetCurrentProcessorNumber()
       mov       ecx,0AAAAAAAB
       mov       edx,eax
       imul      rcx,rdx
       shr       rcx,23
       imul      ecx,0C
       sub       eax,ecx
       xor       edx,edx
       jmp       near ptr M08_L128
M08_L121:
       jmp       short M08_L120
M08_L122:
       cmp       eax,[r8+8]
       jae       near ptr M08_L154
       mov       [rsp+120],eax
       mov       ecx,eax
       mov       r10,[r8+rcx*8+10]
       mov       [rsp+68],r10
       cmp       [r10],r10b
       xor       r9d,r9d
       mov       [rsp+118],r9d
       mov       rcx,r10
       call      qword ptr [7FF9E60EE2B0]; System.Threading.Monitor.Enter(System.Object)
       mov       rax,[rsp+68]
       mov       rcx,[rax+8]
       mov       r8d,[rax+10]
       mov       [rsp+114],r8d
       cmp       [rcx+8],r8d
       jbe       short M08_L124
       test      r8d,r8d
       jne       short M08_L125
       xor       edx,edx
       mov       [rax+14],edx
M08_L123:
       movsxd    rdx,r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,[rsp+78]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rsp+114]
       inc       ecx
       mov       rax,[rsp+68]
       mov       [rax+10],ecx
       mov       dword ptr [rsp+118],1
M08_L124:
       mov       rcx,rax
       call      qword ptr [7FF9E5BC6820]; System.Threading.Monitor.Exit(System.Object)
       cmp       dword ptr [rsp+118],0
       je        short M08_L126
       jmp       short M08_L129
M08_L125:
       jmp       short M08_L123
M08_L126:
       mov       eax,[rsp+120]
       inc       eax
       mov       ecx,eax
       mov       r8,[rsp+70]
       cmp       [r8+8],ecx
       jne       short M08_L127
       xor       ecx,ecx
M08_L127:
       mov       edx,[rsp+11C]
       inc       edx
       mov       eax,ecx
M08_L128:
       mov       r8,[rsp+70]
       mov       [rsp+11C],edx
       cmp       [r8+8],edx
       jg        near ptr M08_L122
       jmp       short M08_L130
M08_L129:
       mov       edx,1
       jmp       short M08_L131
M08_L130:
       xor       edx,edx
M08_L131:
       mov       [rsp+134],edx
       mov       rax,[rsp+98]
       mov       ecx,[rsp+138]
       mov       r10d,[rsp+13C]
       jmp       near ptr M08_L23
M08_L132:
       mov       r8,[rsp+0A0]
       cmp       dword ptr [r8+8],0
       mov       [rsp+138],ecx
       je        near ptr M08_L24
       mov       rcx,r8
       call      qword ptr [7FF9E5FED740]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+130],eax
       mov       rdx,[rsp+0A0]
       mov       r8d,[rdx+8]
       mov       [rsp+12C],r8d
       mov       rcx,[rsp+90]
       call      qword ptr [7FF9E5FED740]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,[rsp+88]
       mov       r8d,[rsp+130]
       mov       r9d,[rsp+12C]
       mov       edx,3
       call      qword ptr [7FF9E63AF8D0]
       mov       eax,[rsp+138]
       test      [rsp+134],eax
       jne       short M08_L133
       mov       rcx,[rsp+0A0]
       call      qword ptr [7FF9E5FED740]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+128],eax
       mov       rcx,[rsp+0A0]
       mov       edx,[rcx+8]
       mov       [rsp+124],edx
       mov       rcx,[rsp+90]
       call      qword ptr [7FF9E5FED740]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       cmp       dword ptr [rsp+138],0
       jne       short M08_L134
       mov       ecx,0FFFFFFFF
       mov       edx,1
       jmp       short M08_L135
M08_L133:
       mov       rax,[rsp+98]
       jmp       near ptr M08_L24
M08_L134:
       mov       ecx,[rsp+13C]
       xor       edx,edx
M08_L135:
       mov       [rsp+20],ecx
       mov       [rsp+28],edx
       mov       rcx,[rsp+88]
       mov       edx,[rsp+128]
       mov       r8d,[rsp+124]
       call      qword ptr [7FF9E61FEF88]
       mov       rax,[rsp+98]
       jmp       near ptr M08_L24
M08_L136:
       mov       ecx,2
       call      qword ptr [7FF9E5BCFD50]
       int       3
M08_L137:
       mov       rcx,r12
       call      qword ptr [7FF9E616F480]; System.Buffers.SharedArrayPool`1[[System.Int32, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
       jmp       near ptr M08_L27
M08_L138:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9E61FEF10]
       mov       r12,rax
       mov       ecx,29B
       mov       rdx,7FF9E5B04000
       call      qword ptr [7FF9E5BCF228]
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,rbx
       call      qword ptr [7FF9E5F37D50]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M08_L139:
       mov       rcx,[r12+10]
       cmp       edi,[rcx+8]
       jae       near ptr M08_L154
       mov       edx,edi
       mov       rax,[rcx+rdx*8+10]
       test      rax,rax
       jne       short M08_L140
       mov       rcx,r12
       mov       edx,edi
       call      qword ptr [7FF9E63AFCC0]
M08_L140:
       mov       r14,[rax+8]
       call      qword ptr [7FF9E61FF4E0]; System.Threading.Thread.GetCurrentProcessorNumber()
       mov       ecx,0AAAAAAAB
       mov       edx,eax
       imul      rcx,rdx
       shr       rcx,23
       imul      ecx,0C
       mov       r15d,eax
       sub       r15d,ecx
       xor       eax,eax
       jmp       near ptr M08_L147
M08_L141:
       cmp       r15d,[r14+8]
       jae       near ptr M08_L154
       mov       ecx,r15d
       mov       rdx,[r14+rcx*8+10]
       mov       [rsp+60],rdx
       cmp       [rdx],dl
       xor       r8d,r8d
       mov       [rsp+108],r8d
       mov       rcx,rdx
       call      qword ptr [7FF9E60EE2B0]; System.Threading.Monitor.Enter(System.Object)
       mov       rax,[rsp+60]
       mov       rcx,[rax+8]
       mov       r8d,[rax+10]
       mov       [rsp+104],r8d
       cmp       [rcx+8],r8d
       jbe       short M08_L143
       test      r8d,r8d
       jne       short M08_L144
       xor       edx,edx
       mov       [rax+14],edx
M08_L142:
       movsxd    rdx,r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rsp+104]
       inc       ecx
       mov       rax,[rsp+60]
       mov       [rax+10],ecx
       mov       dword ptr [rsp+108],1
M08_L143:
       mov       rcx,rax
       call      qword ptr [7FF9E5BC6820]; System.Threading.Monitor.Exit(System.Object)
       cmp       dword ptr [rsp+108],0
       je        short M08_L145
       jmp       short M08_L148
M08_L144:
       jmp       short M08_L142
M08_L145:
       inc       r15d
       cmp       [r14+8],r15d
       jne       short M08_L146
       xor       r15d,r15d
M08_L146:
       mov       eax,[rsp+10C]
       inc       eax
M08_L147:
       mov       [rsp+10C],eax
       cmp       [r14+8],eax
       jg        near ptr M08_L141
       jmp       short M08_L149
M08_L148:
       mov       r14d,1
       jmp       short M08_L150
M08_L149:
       xor       r14d,r14d
M08_L150:
       jmp       near ptr M08_L28
M08_L151:
       cmp       dword ptr [rbx+8],0
       je        near ptr M08_L29
       mov       rcx,rbx
       call      qword ptr [7FF9E5FED740]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r13d,eax
       mov       eax,[rbx+8]
       mov       [rsp+110],eax
       mov       rcx,r12
       call      qword ptr [7FF9E5FED740]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,r15
       mov       r8d,r13d
       mov       r9d,[rsp+110]
       mov       edx,3
       call      qword ptr [7FF9E63AF8D0]
       test      r14d,ebp
       jne       near ptr M08_L29
       mov       rcx,rbx
       call      qword ptr [7FF9E5FED740]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r14d,eax
       mov       ebx,[rbx+8]
       mov       rcx,r12
       call      qword ptr [7FF9E5FED740]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       test      ebp,ebp
       jne       short M08_L152
       mov       ecx,0FFFFFFFF
       mov       edx,1
       jmp       short M08_L153
M08_L152:
       mov       ecx,edi
       xor       edx,edx
M08_L153:
       mov       [rsp+20],ecx
       mov       [rsp+28],edx
       mov       rcx,r15
       mov       edx,r14d
       mov       r8d,ebx
       call      qword ptr [7FF9E61FEF88]
       jmp       near ptr M08_L29
M08_L154:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 6102
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
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       test      rbx,rbx
       je        near ptr M10_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M10_L01
       test      rsi,rsi
       je        short M10_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M10_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M10_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFA45879D30
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF9E5BC5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF9E5BC5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
M10_L00:
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
M10_L01:
       test      rsi,rsi
       je        short M10_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M10_L03
M10_L02:
       mov       rax,2844B130008
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M10_L03:
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
M10_L04:
       call      qword ptr [7FF9E63AF5E8]
       int       3
; Total bytes of code 244
```
```assembly
; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].get_Comparer()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       rcx,[rbx]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rdx,offset MT_System.String
       cmp       [rcx],rdx
       je        short M11_L01
       mov       rax,[rbx+18]
       test      rax,rax
       je        short M11_L04
M11_L00:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M11_L01:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rsi,[rdx+0A0]
       test      rsi,rsi
       je        short M11_L02
       jmp       short M11_L03
M11_L02:
       mov       rdx,7FF9E643B818
       call      qword ptr [7FF9E5BCF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rsi,rax
M11_L03:
       mov       rdx,[rbx+18]
       mov       rcx,offset MT_System.Collections.Generic.IEqualityComparer<System.String>
       call      qword ptr [7FF9E5BC58D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rcx,rax
       call      qword ptr [7FF9E63AFCD8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9E5BC58D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M11_L04:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+0A8]
       test      rdx,rdx
       je        short M11_L05
       jmp       short M11_L06
M11_L05:
       mov       rdx,7FF9E643B828
       call      qword ptr [7FF9E5BCF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M11_L06:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rax]
       jmp       near ptr M11_L00
; Total bytes of code 206
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M12_L00
       ret
M12_L00:
       jmp       qword ptr [7FF9E5BC5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.ToFrozenSet()
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
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-70],xmm4
       xor       eax,eax
       mov       [rbp-60],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       test      rsi,rsi
       je        near ptr M00_L44
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L46
       mov       rcx,[rsi+8]
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],r11
       jne       near ptr M00_L45
       mov       edi,[rcx+10]
M00_L00:
       test      edi,edi
       je        near ptr M00_L59
       mov       rdx,271DA000A20
       mov       rdi,[rdx]
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Frozen.FrozenSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r14,rax
       test      r14,r14
       jne       near ptr M00_L47
M00_L01:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Generic.HashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r14,rax
       mov       r15,r14
       test      r15,r15
       jne       near ptr M00_L48
M00_L02:
       mov       rcx,offset MT_System.Collections.Generic.HashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       lea       rcx,[r15+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       test      r14,r14
       jne       near ptr M00_L49
M00_L03:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L51
       mov       rcx,[rsi+8]
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],r11
       jne       near ptr M00_L50
       mov       ecx,[rcx+10]
M00_L04:
       test      ecx,ecx
       jle       short M00_L05
       call      qword ptr [7FF9E5BD5A88]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       r14d,eax
       movsxd    rdx,r14d
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r13,rax
       movsxd    rdx,r14d
       mov       rcx,offset MT_System.Collections.Generic.HashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Entry[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r12,rax
       mov       dword ptr [r15+2C],0FFFFFFFF
       lea       rcx,[r15+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,r14d
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [r15+20],rax
M00_L05:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L54
       mov       rsi,[rsi+8]
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L53
       cmp       dword ptr [rsi+10],0
       je        near ptr M00_L52
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       r13d,[rsi+14]
       lea       rcx,[r14+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r14+10],rcx
       mov       [r14+18],r13d
       mov       [r14+1C],ecx
M00_L06:
       mov       [rbp-78],r14
M00_L07:
       mov       rdx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rcx,[rbp-78]
       cmp       [rcx],rdx
       jne       near ptr M00_L36
       mov       rdx,[rcx]
       add       rcx,8
       call      qword ptr [7FF9E5E6C150]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L08:
       test      eax,eax
       je        near ptr M00_L39
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-78]
       cmp       [rax],rcx
       jne       near ptr M00_L24
       mov       rsi,[rax+10]
M00_L09:
       cmp       qword ptr [r15+8],0
       je        near ptr M00_L25
M00_L10:
       mov       r14,[r15+10]
       mov       r13,[r15+18]
       xor       r12d,r12d
       test      rsi,rsi
       je        near ptr M00_L20
       mov       rcx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r13],rcx
       jne       near ptr M00_L32
       mov       rdx,[rsi+28]
       test      rdx,rdx
       je        near ptr M00_L26
       mov       rcx,271C4000068
       mov       rcx,[rcx]
       mov       r8,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],r8
       jne       near ptr M00_L31
       lea       rcx,[rdx+0C]
       mov       r8d,[rdx+8]
       add       r8d,r8d
       mov       [rbp-44],r8d
       mov       dword ptr [rbp-50],81755651
       mov       dword ptr [rbp-58],3DE9AF74
       cmp       r8d,8
       jb        near ptr M00_L18
       mov       edx,r8d
       shr       edx,3
       xchg      ax,ax
M00_L11:
       mov       r10d,[rbp-50]
       add       r10d,[rcx]
       mov       [rbp-50],r10d
       mov       r10d,[rcx+4]
       mov       r9d,[rbp-50]
       mov       r11d,[rbp-58]
       xor       r11d,r9d
       rol       r9d,14
       add       r9d,r11d
       rol       r11d,9
       xor       r11d,r9d
       rol       r9d,1B
       add       r9d,r11d
       rol       r11d,13
       mov       [rbp-50],r9d
       mov       [rbp-58],r11d
       add       r10d,[rbp-50]
       mov       [rbp-50],r10d
       mov       r10d,[rbp-50]
       mov       r9d,[rbp-58]
       xor       r9d,r10d
       rol       r10d,14
       add       r10d,r9d
       rol       r9d,9
       xor       r9d,r10d
       rol       r10d,1B
       add       r10d,r9d
       rol       r9d,13
       mov       [rbp-50],r10d
       mov       [rbp-58],r9d
       add       rcx,8
       dec       edx
       jne       short M00_L11
       test      r8b,4
       jne       near ptr M00_L27
M00_L12:
       mov       edx,r8d
       and       rdx,7
       mov       ecx,[rcx+rdx-4]
       shr       ecx,8
       or        ecx,80000000
       not       r8d
       shl       r8d,3
       shrx      ecx,ecx,r8d
M00_L13:
       add       ecx,[rbp-50]
       mov       [rbp-50],ecx
       lea       rcx,[rbp-50]
       lea       rdx,[rbp-58]
       call      qword ptr [7FF9E64852D8]; System.Marvin.Block(UInt32 ByRef, UInt32 ByRef)
       lea       rcx,[rbp-50]
       lea       rdx,[rbp-58]
       call      qword ptr [7FF9E64852D8]; System.Marvin.Block(UInt32 ByRef, UInt32 ByRef)
       mov       eax,[rbp-58]
       xor       eax,[rbp-50]
M00_L14:
       mov       [rbp-3C],eax
       mov       rdx,[r15+8]
       mov       ecx,eax
       imul      rcx,[r15+20]
       shr       rcx,20
       inc       rcx
       mov       r8d,[rdx+8]
       mov       r11d,r8d
       imul      rcx,r11
       shr       rcx,20
       cmp       ecx,r8d
       jae       near ptr M00_L38
       mov       ecx,ecx
       lea       r10,[rdx+rcx*4+10]
       mov       [rbp-88],r10
       mov       r9d,[r10]
       dec       r9d
       jns       near ptr M00_L21
M00_L15:
       cmp       dword ptr [r15+30],0
       jg        near ptr M00_L23
       mov       edx,[r15+28]
       mov       [rbp-40],edx
       cmp       [r14+8],edx
       je        near ptr M00_L34
M00_L16:
       mov       edx,[rbp-40]
       mov       r14d,edx
       lea       ecx,[r14+1]
       mov       [r15+28],ecx
       mov       rcx,[r15+10]
       mov       r8,rcx
M00_L17:
       cmp       r14d,[r8+8]
       jae       near ptr M00_L38
       mov       ecx,r14d
       shl       rcx,4
       mov       [rbp-80],r8
       lea       rcx,[r8+rcx+10]
       mov       [rcx+8],eax
       mov       r10,[rbp-88]
       mov       edx,[r10]
       dec       edx
       mov       [rcx+0C],edx
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       inc       r14d
       mov       rdx,[rbp-88]
       mov       [rdx],r14d
       inc       dword ptr [r15+34]
       cmp       r12d,64
       jbe       near ptr M00_L07
       jmp       near ptr M00_L35
M00_L18:
       cmp       r8d,4
       jb        near ptr M00_L28
M00_L19:
       mov       edx,[rbp-50]
       mov       [rbp-98],rcx
       add       edx,[rcx]
       mov       [rbp-50],edx
       lea       rcx,[rbp-50]
       lea       rdx,[rbp-58]
       call      qword ptr [7FF9E64852D8]; System.Marvin.Block(UInt32 ByRef, UInt32 ByRef)
       mov       rax,[rbp-78]
       mov       rcx,[rbp-98]
       mov       r8d,[rbp-44]
       jmp       near ptr M00_L12
M00_L20:
       xor       edx,edx
       xor       r10d,r10d
       mov       eax,r10d
       jmp       near ptr M00_L14
M00_L21:
       cmp       r9d,[r14+8]
       jae       near ptr M00_L38
       mov       edx,r9d
       shl       rdx,4
       lea       r9,[r14+rdx+10]
       mov       [rbp-90],r9
       cmp       [r9+8],eax
       je        near ptr M00_L33
M00_L22:
       mov       r9d,[r9+0C]
       inc       r12d
       cmp       [r14+8],r12d
       jb        near ptr M00_L37
       test      r9d,r9d
       mov       eax,[rbp-3C]
       jge       short M00_L21
       jmp       near ptr M00_L15
M00_L23:
       mov       ecx,[r15+2C]
       mov       r8d,ecx
       dec       dword ptr [r15+30]
       cmp       ecx,[r14+8]
       jae       near ptr M00_L38
       shl       rcx,4
       mov       ecx,[r14+rcx+1C]
       neg       ecx
       add       ecx,0FFFFFFFD
       mov       [r15+2C],ecx
       mov       ecx,r8d
       mov       r8,r14
       mov       r14d,ecx
       jmp       near ptr M00_L17
M00_L24:
       mov       rcx,rax
       mov       r11,7FF9E5B20D38
       call      qword ptr [r11]
       mov       rsi,rax
       mov       rax,[rbp-78]
       jmp       near ptr M00_L09
M00_L25:
       mov       rcx,r15
       xor       edx,edx
       call      qword ptr [7FF9E5DA7750]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       mov       rax,[rbp-78]
       jmp       near ptr M00_L10
M00_L26:
       xor       ecx,ecx
       mov       eax,ecx
       jmp       near ptr M00_L14
M00_L27:
       jmp       near ptr M00_L19
M00_L28:
       mov       r8d,[rbp-44]
       mov       edx,80
       test      r8b,1
       je        short M00_L29
       mov       edx,r8d
       and       rdx,2
       movzx     edx,byte ptr [rcx+rdx]
       or        edx,8000
M00_L29:
       test      r8b,2
       je        short M00_L30
       shl       edx,10
       movzx     ecx,word ptr [rcx]
       or        edx,ecx
       mov       ecx,edx
       jmp       near ptr M00_L13
M00_L30:
       mov       ecx,edx
       jmp       near ptr M00_L13
M00_L31:
       mov       r8,[rcx]
       mov       r8,[r8+48]
       call      qword ptr [r8+18]
       jmp       near ptr M00_L14
M00_L32:
       mov       rcx,r13
       mov       rdx,rsi
       mov       r11,7FF9E5B20D50
       call      qword ptr [r11]
       jmp       near ptr M00_L14
M00_L33:
       mov       rdx,[r9]
       mov       rcx,r13
       mov       r8,rsi
       mov       r11,7FF9E5B20D58
       call      qword ptr [r11]
       test      eax,eax
       mov       r9,[rbp-90]
       jne       near ptr M00_L07
       jmp       near ptr M00_L22
M00_L34:
       mov       rcx,r15
       call      qword ptr [7FF9E63AFA68]
       mov       rcx,[r15+8]
       mov       r14d,[rbp-3C]
       mov       edx,r14d
       imul      rdx,[r15+20]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       imul      rdx,rax
       shr       rdx,20
       cmp       edx,[rcx+8]
       jae       short M00_L38
       mov       edx,edx
       lea       r10,[rcx+rdx*4+10]
       mov       rax,r10
       mov       [rbp-88],rax
       mov       eax,r14d
       jmp       near ptr M00_L16
M00_L35:
       mov       r14,[rbp-80]
       mov       rdx,r13
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M00_L07
       mov       edx,[r14+8]
       mov       rcx,r15
       mov       r8d,1
       call      qword ptr [7FF9E5F4D980]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,r15
       mov       rdx,rsi
       call      qword ptr [7FF9E5DA7810]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       jmp       near ptr M00_L07
M00_L36:
       mov       r11,7FF9E5B20D30
       call      qword ptr [r11]
       jmp       near ptr M00_L08
M00_L37:
       call      qword ptr [7FF9E5BDF498]
       int       3
M00_L38:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L39:
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-78]
       cmp       [rax],rcx
       jne       near ptr M00_L55
M00_L40:
       mov       ecx,[r15+28]
       test      ecx,ecx
       jle       short M00_L41
       mov       rax,[r15+10]
       mov       eax,[rax+8]
       cdq
       idiv      ecx
       cmp       eax,3
       jg        near ptr M00_L56
M00_L41:
       mov       ecx,[r15+28]
       sub       ecx,[r15+30]
       je        near ptr M00_L57
       xor       esi,esi
M00_L42:
       test      rsi,rsi
       jne       short M00_L43
       mov       rdx,r15
       mov       rcx,7FF9E63BE560
       call      qword ptr [7FF9E63A52D8]; System.Collections.Frozen.FrozenSet.CreateFromSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
       mov       rsi,rax
M00_L43:
       mov       [rbp-60],rsi
       mov       rcx,[rbx+60]
       lea       r8,[rbp-60]
       mov       rdx,7FF9E63D9368
       cmp       [rcx],ecx
       call      qword ptr [7FF9E63A65F8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
M00_L44:
       call      qword ptr [7FF9E617EAC0]
       mov       ecx,65
       mov       rdx,7FF9E5FD8D68
       call      qword ptr [7FF9E5BDF228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF9E5EA5AC0
       call      qword ptr [7FF9E5BDF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9E5BDD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9E5FD8D68
       call      qword ptr [7FF9E5BDF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9E5BDD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9E63AD9C8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9E63AD9E0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L45:
       mov       r11,7FF9E5B20D10
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L00
M00_L46:
       mov       rcx,rsi
       mov       r11,7FF9E5B20D08
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L00
M00_L47:
       mov       rcx,[r14+8]
       mov       rdx,rdi
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       test      eax,eax
       je        near ptr M00_L01
       xor       r15d,r15d
       mov       rsi,r14
       jmp       near ptr M00_L42
M00_L48:
       mov       ecx,[r15+28]
       sub       ecx,[r15+30]
       je        near ptr M00_L41
       mov       rcx,r15
       call      qword ptr [7FF9E63A5C68]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].get_Comparer()
       mov       rcx,rax
       mov       rdx,rdi
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       test      eax,eax
       jne       near ptr M00_L41
       jmp       near ptr M00_L02
M00_L49:
       mov       r8,r14
       mov       rdx,r15
       mov       rcx,offset MT_System.Collections.Generic.HashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FF9E64851E8]
       test      eax,eax
       je        near ptr M00_L03
       mov       rcx,r15
       mov       rdx,r14
       call      qword ptr [7FF9E63AFAC8]
       jmp       near ptr M00_L41
M00_L50:
       mov       r11,7FF9E5B20D20
       call      qword ptr [r11]
       mov       ecx,eax
       jmp       near ptr M00_L04
M00_L51:
       mov       rcx,rsi
       mov       r11,7FF9E5B20D18
       call      qword ptr [r11]
       mov       ecx,eax
       jmp       near ptr M00_L04
M00_L52:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,271DA000AC8
       mov       r14,[rcx]
       jmp       near ptr M00_L06
M00_L53:
       mov       rcx,rsi
       mov       r11,7FF9E5B20D48
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L06
M00_L54:
       mov       rcx,rsi
       mov       r11,7FF9E5B20D28
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L06
M00_L55:
       mov       rcx,rax
       mov       r11,7FF9E5B20D40
       call      qword ptr [r11]
       jmp       near ptr M00_L40
M00_L56:
       mov       edx,ecx
       sub       edx,[r15+30]
       mov       rcx,r15
       call      qword ptr [7FF9E63AFAE0]
       jmp       near ptr M00_L41
M00_L57:
       mov       rcx,offset MT_System.Collections.Frozen.FrozenSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,271DA000AD0
       mov       rcx,[rcx]
       cmp       rdi,[rcx+8]
       je        short M00_L58
       mov       rcx,offset MT_System.Collections.Frozen.EmptyFrozenSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L42
M00_L58:
       mov       rcx,offset MT_System.Collections.Frozen.FrozenSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,271DA000AD0
       mov       rsi,[rdx]
       jmp       near ptr M00_L42
M00_L59:
       xor       r8d,r8d
       mov       [rbp-70],r8
       mov       [rbp-68],r8d
       lea       r8,[rbp-70]
       mov       rcx,7FF9E64A6540
       xor       edx,edx
       call      qword ptr [7FF9E6485278]
       mov       rsi,rax
       jmp       near ptr M00_L43
       sub       rsp,28
       cmp       qword ptr [rbp-78],0
       je        short M00_L60
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-78]
       cmp       [rax],rcx
       je        short M00_L60
       mov       rcx,rax
       mov       r11,7FF9E5B20D40
       call      qword ptr [r11]
M00_L60:
       nop
       add       rsp,28
       ret
; Total bytes of code 2510
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
       mov       rcx,7FF9ED480B08
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
       call      qword ptr [7FF9E63AEA30]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9E5F45E60]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M02_L03:
       mov       esi,ebx
       or        esi,1
       jmp       short M02_L06
M02_L04:
       mov       ecx,esi
       call      qword ptr [7FF9E63AEA48]
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
; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx]
       mov       rdx,rcx
       mov       eax,[rbx+10]
       cmp       eax,[rcx+14]
       jne       short M03_L00
       mov       ecx,[rbx+14]
       cmp       ecx,[rdx+10]
       jae       short M03_L01
       mov       rdx,[rdx+8]
       cmp       ecx,[rdx+8]
       jae       short M03_L02
       mov       ecx,ecx
       mov       rdx,[rdx+rcx*8+10]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       dword ptr [rbx+14]
       mov       eax,1
       add       rsp,20
       pop       rbx
       ret
M03_L00:
       call      qword ptr [7FF9E5BDFC60]
       int       3
M03_L01:
       xor       eax,eax
       mov       [rbx+8],rax
       mov       dword ptr [rbx+14],0FFFFFFFF
       add       rsp,20
       pop       rbx
       ret
M03_L02:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 101
```
```assembly
; System.Marvin.Block(UInt32 ByRef, UInt32 ByRef)
       mov       eax,[rcx]
       mov       r8d,eax
       xor       r8d,[rdx]
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       mov       [rcx],eax
       mov       [rdx],r8d
       ret
; Total bytes of code 37
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
       call      qword ptr [7FF9E5BD5A88]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       esi,eax
       movsxd    rdx,esi
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rdi,rax
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+0B0]
       test      rax,rax
       je        short M05_L01
       mov       rcx,rax
M05_L00:
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
M05_L01:
       mov       rdx,7FF9E643ED70
       call      qword ptr [7FF9E5BDF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M05_L00
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
       call      qword ptr [7FF9EE0E7EC8]
       mov       rcx,rax
       movsxd    rdx,esi
       call      qword ptr [7FF9EE0E4088]; CORINFO_HELP_NEWARR_1_DIRECT
       mov       rbp,rax
       mov       r14d,[rbx+28]
       mov       rcx,[rbx+10]
       mov       rdx,rbp
       mov       r8d,r14d
       call      qword ptr [7FF9EE0F52F0]; Precode of System.Array.Copy(System.Array, System.Array, Int32)
       movzx     ecx,dil
       test      cl,1
       jne       near ptr M06_L06
M06_L00:
       movsxd    rcx,esi
       call      qword ptr [7FF9EE0F1B50]
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      qword ptr [7FF9EE0E3FE8]; CORINFO_HELP_ASSIGN_REF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,esi
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rbx+20],rax
       xor       ecx,ecx
       test      r14d,r14d
       jle       short M06_L03
       cmp       [rbp+8],r14d
       jl        near ptr M06_L04
M06_L01:
       mov       edx,ecx
       shl       rdx,4
       lea       rdx,[rbp+rdx+10]
       cmp       dword ptr [rdx+0C],0FFFFFFFF
       jl        short M06_L02
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
       jae       near ptr M06_L11
       mov       r10d,r10d
       lea       rax,[r8+r10*4+10]
       mov       r8d,[rax]
       dec       r8d
       mov       [rdx+0C],r8d
       lea       edx,[rcx+1]
       mov       [rax],edx
M06_L02:
       inc       ecx
       cmp       ecx,r14d
       jl        short M06_L01
M06_L03:
       lea       rcx,[rbx+10]
       mov       rdx,rbp
       call      qword ptr [7FF9EE0E3FE8]; CORINFO_HELP_ASSIGN_REF
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
M06_L04:
       cmp       ecx,[rbp+8]
       jae       near ptr M06_L11
       mov       eax,ecx
       shl       rax,4
       lea       rdx,[rbp+rax+10]
       cmp       dword ptr [rdx+0C],0FFFFFFFF
       jl        short M06_L05
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
       jae       near ptr M06_L11
       mov       eax,r10d
       lea       rax,[r8+rax*4+10]
       mov       r8d,[rax]
       dec       r8d
       mov       [rdx+0C],r8d
       lea       edx,[rcx+1]
       mov       [rax],edx
M06_L05:
       inc       ecx
       cmp       ecx,r14d
       jl        short M06_L04
       jmp       near ptr M06_L03
M06_L06:
       mov       rcx,[rbx]
       call      qword ptr [7FF9EE0E74F8]
       mov       rdi,rax
       mov       rcx,[rbx+18]
       call      qword ptr [7FF9EE0F3730]
       mov       rcx,rax
       lea       r11,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       [rcx],ecx
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF9EE0E4090]; Precode of System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdi,rax
       lea       rcx,[rbx+18]
       mov       rdx,rdi
       call      qword ptr [7FF9EE0E3FE8]; CORINFO_HELP_ASSIGN_REF
       xor       r15d,r15d
       cmp       r15d,r14d
       jge       near ptr M06_L00
M06_L07:
       cmp       r15d,[rbp+8]
       jae       short M06_L11
       mov       rcx,r15
       shl       rcx,4
       lea       r13,[rbp+rcx+10]
       cmp       dword ptr [r13+0C],0FFFFFFFF
       jl        short M06_L10
       cmp       qword ptr [r13],0
       jne       short M06_L08
       xor       r12d,r12d
       jmp       short M06_L09
M06_L08:
       mov       rcx,[rbx]
       call      qword ptr [7FF9EE0E9150]
       mov       rdx,[r13]
       mov       rcx,rdi
       mov       r11,rax
       call      qword ptr [rax]
       mov       r12d,eax
M06_L09:
       mov       [r13+8],r12d
M06_L10:
       inc       r15d
       cmp       r15d,r14d
       jl        short M06_L07
       jmp       near ptr M06_L00
M06_L11:
       call      qword ptr [7FF9EE0E3FD8]
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
       je        near ptr M07_L06
       mov       rdi,[rbx+10]
       xor       ebp,ebp
       mov       r14,[rbx+18]
       test      rsi,rsi
       je        near ptr M07_L11
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+78]
       test      r11,r11
       je        near ptr M07_L07
M07_L00:
       mov       rcx,offset MT_System.Collections.Generic.ObjectEqualityComparer<System.RuntimeType>
       cmp       [r14],rcx
       jne       near ptr M07_L13
       mov       [rsp+38],rsi
       xor       ecx,ecx
       mov       [rsp+30],rcx
       lea       rcx,[rsp+38]
       cmp       qword ptr [rsp+30],0
       jne       short M07_L01
       mov       rcx,[rsp+38]
       mov       [rsp+30],rcx
       lea       rcx,[rsp+30]
       cmp       qword ptr [rsp+30],0
       je        near ptr M07_L12
M07_L01:
       mov       r15,[rcx]
       mov       rcx,offset MT_System.RuntimeType
       cmp       [r15],rcx
       je        near ptr M07_L08
       mov       rcx,r15
       mov       rax,[r15]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
       mov       r15d,eax
M07_L02:
       xor       ecx,ecx
       mov       [rsp+30],rcx
M07_L03:
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
       jae       near ptr M07_L18
       mov       edx,edx
       lea       rcx,[rcx+rdx*4+10]
       mov       r13d,[rcx]
       dec       r13d
       js        short M07_L06
M07_L04:
       mov       r12d,[rdi+8]
       cmp       r13d,r12d
       jae       near ptr M07_L18
       mov       ecx,r13d
       shl       rcx,4
       lea       rax,[rdi+rcx+10]
       mov       [rsp+28],rax
       cmp       [rax+8],r15d
       je        near ptr M07_L14
M07_L05:
       mov       rax,[rsp+28]
       mov       r13d,[rax+0C]
       inc       ebp
       cmp       r12d,ebp
       jb        near ptr M07_L17
       test      r13d,r13d
       jge       short M07_L04
M07_L06:
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
M07_L07:
       mov       rdx,7FF9E6439940
       call      qword ptr [7FF9E5BDF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M07_L00
M07_L08:
       mov       rcx,r15
       call      00007FFA45809590
       test      eax,eax
       je        short M07_L10
       mov       r15d,eax
M07_L09:
       jmp       near ptr M07_L02
M07_L10:
       mov       rcx,r15
       call      qword ptr [7FF9E5DA77F8]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       mov       r15d,eax
       jmp       short M07_L09
M07_L11:
       xor       r15d,r15d
       jmp       near ptr M07_L03
M07_L12:
       xor       r15d,r15d
       jmp       near ptr M07_L02
M07_L13:
       mov       rcx,r14
       mov       rdx,rsi
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       near ptr M07_L03
M07_L14:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+80]
       test      r11,r11
       je        short M07_L15
       jmp       short M07_L16
M07_L15:
       mov       rdx,7FF9E6439958
       call      qword ptr [7FF9E5BDF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M07_L16:
       mov       rax,[rsp+28]
       mov       rdx,[rax]
       mov       rcx,r14
       mov       r8,rsi
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M07_L05
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
M07_L17:
       call      qword ptr [7FF9E5BDF498]
       int       3
M07_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 543
```
```assembly
; System.Collections.Frozen.FrozenSet.CreateFromSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,188
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+0D0],ymm4
       mov       [rsp+180],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rcx,[rbx]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rdx,offset MT_System.String
       cmp       [rcx],rdx
       je        near ptr M08_L53
       mov       rdi,[rbx+18]
       test      rdi,rdi
       je        near ptr M08_L56
M08_L00:
       mov       rcx,[rsi+18]
       mov       rdx,offset MT_System.String
       cmp       [rcx],rdx
       je        near ptr M08_L59
M08_L01:
       mov       ecx,[rbx+28]
       sub       ecx,[rbx+30]
       cmp       ecx,4
       jle       near ptr M08_L88
       mov       rcx,[rsi+18]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        near ptr M08_L43
M08_L02:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,[rbx]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rdx,offset MT_System.String
       cmp       [rcx],rdx
       je        near ptr M08_L91
       mov       rdx,[rbx+18]
       test      rdx,rdx
       je        near ptr M08_L94
M08_L03:
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+10],rcx
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx+8]
       mov       rax,[rdx+20]
       test      rax,rax
       je        near ptr M08_L44
M08_L04:
       lea       rcx,[rsi+10]
       mov       rdx,rsi
       call      rax
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx+10]
       mov       rdi,[rdx+28]
       test      rdi,rdi
       je        near ptr M08_L45
M08_L05:
       mov       rcx,rdi
       mov       ebp,[rbx+28]
       sub       ebp,[rbx+30]
       mov       [rsp+0CC],ebp
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       xor       r15d,r15d
       mov       r13d,ebp
       test      r13d,r13d
       jl        near ptr M08_L97
       mov       r12,[rbx+10]
       xor       eax,eax
       cmp       dword ptr [rbx+28],0
       jle       short M08_L08
M08_L06:
       test      r13d,r13d
       je        short M08_L08
       cmp       eax,[r12+8]
       jae       near ptr M08_L154
       mov       [rsp+0C0],rax
       mov       r8,rax
       shl       r8,4
       lea       r8,[r12+r8+10]
       cmp       dword ptr [r8+0C],0FFFFFFFF
       jl        short M08_L07
       lea       edx,[r15+1]
       mov       [rsp+15C],edx
       mov       r8,[r8]
       movsxd    rdx,r15d
       mov       rcx,r14
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       dec       r13d
       mov       r15d,[rsp+15C]
M08_L07:
       mov       rax,[rsp+0C0]
       inc       eax
       mov       rcx,rax
       cmp       ecx,[rbx+28]
       mov       rax,rcx
       jl        short M08_L06
M08_L08:
       mov       rcx,rdi
       mov       edx,ebp
       call      CORINFO_HELP_NEWARR_1_PTR
       lea       rcx,[rsi+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,271C4001D88
       mov       r13,[rcx]
       mov       [rsp+40],r13
       mov       rcx,r13
       mov       edx,ebp
       call      qword ptr [7FF9E61D5898]; System.Buffers.SharedArrayPool`1[[System.Int32, System.Private.CoreLib]].Rent(Int32)
       mov       rbx,rax
       mov       [rsp+0B8],rbx
       mov       edi,ebp
       test      rbx,rbx
       je        near ptr M08_L98
       cmp       [rbx+8],edi
       jb        near ptr M08_L108
       lea       r15,[rbx+10]
M08_L09:
       xor       r12d,r12d
       cmp       ebp,r12d
       jg        near ptr M08_L16
       jmp       near ptr M08_L99
M08_L10:
       mov       rcx,[rsi+8]
       mov       rdx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rdx
       jne       near ptr M08_L105
       mov       r8,[rsp+0B0]
       mov       rdx,[r8+28]
       test      rdx,rdx
       je        near ptr M08_L100
       mov       rcx,271C4000068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M08_L104
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,81755651
       mov       r8d,3DE9AF74
       cmp       edx,8
       jb        near ptr M08_L17
       mov       r9d,edx
       shr       r9d,3
M08_L11:
       add       eax,[rcx]
       mov       r11d,[rcx+4]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       add       r11d,eax
       mov       eax,r8d
       xor       eax,r11d
       rol       r11d,14
       add       r11d,eax
       rol       eax,9
       xor       eax,r11d
       rol       r11d,1B
       add       r11d,eax
       rol       eax,13
       mov       r8d,r11d
       add       rcx,8
       dec       r9d
       mov       r10d,eax
       mov       eax,r8d
       mov       r8d,r10d
       jne       short M08_L11
       test      dl,4
       jne       near ptr M08_L18
M08_L12:
       mov       r9d,edx
       and       r9,7
       mov       ecx,[rcx+r9-4]
       shr       ecx,8
       or        ecx,80000000
       not       edx
       shl       edx,3
       shrx      ecx,ecx,edx
M08_L13:
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
       mov       eax,ecx
       rol       eax,14
       add       eax,edx
       rol       edx,9
       xor       edx,eax
       rol       eax,1B
       add       eax,edx
       mov       r8d,edx
       rol       r8d,13
       xor       eax,r8d
M08_L14:
       mov       r10,[rsp+0A8]
M08_L15:
       mov       [r10],eax
       inc       r12d
       cmp       ebp,r12d
       jle       near ptr M08_L20
       mov       ebp,[rsp+0CC]
M08_L16:
       cmp       r12d,edi
       jae       near ptr M08_L154
       lea       rax,[r15+r12*4]
       mov       r8,[r14+r12*8+10]
       mov       [rsp+0B0],r8
       mov       [rsp+0A8],rax
       test      r8,r8
       je        short M08_L19
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx+10]
       mov       r11,[rdx+30]
       test      r11,r11
       jne       near ptr M08_L10
       mov       rdx,7FF9E6473758
       call      qword ptr [7FF9E5BDF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M08_L10
M08_L17:
       cmp       edx,4
       jb        near ptr M08_L101
M08_L18:
       add       eax,[rcx]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       jmp       near ptr M08_L12
M08_L19:
       mov       r10,rax
       xor       eax,eax
       jmp       near ptr M08_L15
M08_L20:
       mov       rcx,r15
       mov       r12d,edi
       mov       [rsp+0E0],rcx
       mov       [rsp+0E8],r12d
       lea       rcx,[rsp+0E0]
       xor       edx,edx
       call      qword ptr [7FF9E63A6370]; System.Collections.Frozen.FrozenHashTable.CalcNumBuckets(System.ReadOnlySpan`1<Int32>, Boolean)
       mov       r8d,eax
       mov       [rsp+158],r8d
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,r8d
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rsp+150],rax
       mov       rcx,r13
       lea       edx,[r8+r12]
       call      qword ptr [7FF9E61D5898]; System.Buffers.SharedArrayPool`1[[System.Int32, System.Private.CoreLib]].Rent(Int32)
       mov       [rsp+0A0],rax
       test      rax,rax
       je        near ptr M08_L106
       mov       edx,[rsp+158]
       cmp       [rax+8],edx
       jb        near ptr M08_L108
       lea       r8,[rax+10]
       mov       r10d,edx
M08_L21:
       mov       [rsp+58],r8
       mov       [rsp+100],r10d
       test      rax,rax
       je        near ptr M08_L107
       mov       ecx,edx
       mov       r9d,r12d
       add       rcx,r9
       mov       r9d,[rax+8]
       cmp       rcx,r9
       ja        near ptr M08_L108
       mov       edx,edx
       lea       r9,[rax+rdx*4+10]
M08_L22:
       mov       [rsp+50],r9
       mov       [rsp+0FC],r12d
       mov       edx,r10d
       mov       rcx,rdx
       cmp       rcx,8
       jb        near ptr M08_L109
       lea       r11,[rcx*4]
       mov       [rsp+140],r11
       and       r11,0FFFFFFFFFFFFFFC0
       xor       r13d,r13d
       cmp       rcx,10
       jb        short M08_L24
M08_L23:
       vpcmpeqd  ymm0,ymm0,ymm0
       vmovups   [r8+r13],ymm0
       vmovups   [r8+r13+20],ymm0
       add       r13,40
       cmp       r13,r11
       jb        short M08_L23
M08_L24:
       mov       r11,[rsp+140]
       test      r11b,20
       je        short M08_L25
       vpcmpeqd  ymm0,ymm0,ymm0
       vmovups   [r8+r13],ymm0
M08_L25:
       vpcmpeqd  ymm0,ymm0,ymm0
       vmovups   [r8+r11-20],ymm0
M08_L26:
       xor       ecx,ecx
       test      edi,edi
       jle       near ptr M08_L112
       cmp       edi,r12d
       jg        near ptr M08_L47
       jmp       short M08_L27
M08_L27:
       mov       r11d,ecx
       mov       r11d,[r15+r11*4]
       mov       r13,[rsp+150]
       imul      r11,r13
       shr       r11,20
       inc       r11
       imul      r11,rdx
       shr       r11,20
       cmp       r11d,r10d
       jae       near ptr M08_L154
       mov       r11d,r11d
       lea       r11,[r8+r11*4]
       mov       ebx,ecx
       mov       eax,[r11]
       mov       [r9+rbx*4],eax
       mov       [r11],ecx
       inc       ecx
       cmp       ecx,edi
       jl        short M08_L27
M08_L28:
       mov       edx,edi
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbx,rax
       mov       edx,[rsp+100]
       mov       rcx,offset MT_System.Collections.Frozen.FrozenHashTable+Bucket[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       [rsp+98],rax
       xor       ecx,ecx
       xor       edx,edx
       mov       r8d,[rax+8]
       mov       [rsp+0C8],r8d
       test      r8d,r8d
       jle       near ptr M08_L114
       mov       r10d,[rsp+100]
       cmp       r8d,r10d
       jg        near ptr M08_L50
       xor       edx,edx
       jmp       short M08_L31
       nop       dword ptr [rax]
       xchg      ax,ax
M08_L29:
       cmp       r11d,edi
       jae       near ptr M08_L154
       mov       eax,r11d
       lea       rax,[r15+rax*4]
       mov       ebp,[rax]
       cmp       ecx,[rbx+8]
       jae       near ptr M08_L154
       mov       r12d,ecx
       mov       [rbx+r12*4+10],ebp
       mov       [rax],ecx
       inc       ecx
       inc       r10d
       mov       r12d,[rsp+0FC]
       cmp       r11d,r12d
       jae       near ptr M08_L154
       mov       r11d,r11d
       mov       rbp,[rsp+50]
       mov       r11d,[rbp+r11*4]
       test      r11d,r11d
       jge       short M08_L29
       lea       r11d,[r13+r10-1]
       mov       rax,[rsp+98]
       lea       r10,[rax+rdx*2+10]
       mov       [r10],r13d
       mov       [r10+4],r11d
       mov       r13,[rsp+150]
M08_L30:
       add       rdx,4
       dec       r8d
       je        short M08_L32
M08_L31:
       mov       r9,[rsp+58]
       mov       r11d,[r9+rdx]
       test      r11d,r11d
       jl        short M08_L30
       xor       r10d,r10d
       mov       r13d,ecx
       jmp       near ptr M08_L29
M08_L32:
       mov       rax,[rsp+98]
M08_L33:
       mov       r12,[rsp+40]
       mov       rdx,r12
       mov       [rsp+90],rdx
       mov       r8,[rsp+0A0]
       test      r8,r8
       je        near ptr M08_L136
       mov       rdx,[rsp+90]
       mov       ecx,[r8+8]
       dec       ecx
       or        ecx,0F
       xor       r10d,r10d
       lzcnt     r10d,ecx
       xor       r10d,1F
       add       r10d,0FFFFFFFD
       mov       [rsp+13C],r10d
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+238],7
       jle       near ptr M08_L116
       mov       rcx,[rcx+240]
       mov       r9,[rcx+38]
       test      r9,r9
       je        near ptr M08_L115
M08_L34:
       mov       [rsp+48],r9
       mov       r11,[r9+10]
       test      r11,r11
       je        near ptr M08_L117
M08_L35:
       xor       ecx,ecx
       mov       dword ptr [rsp+134],1
       mov       r10d,[rsp+13C]
       cmp       [r11+8],r10d
       jbe       near ptr M08_L36
       mov       dword ptr [rsp+138],1
       mov       edx,10
       shlx      edx,edx,r10d
       mov       r8,[rsp+0A0]
       cmp       [r8+8],edx
       jne       near ptr M08_L118
       mov       edx,r10d
       shl       rdx,4
       lea       r11,[r11+rdx+10]
       mov       [rsp+80],r11
       mov       rdx,[r11]
       mov       [rsp+78],rdx
       mov       rcx,r11
       mov       rdx,r8
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       rdx,[rsp+80]
       mov       [rdx+8],ecx
       cmp       qword ptr [rsp+78],0
       jne       near ptr M08_L119
       mov       rax,[rsp+98]
       mov       ecx,[rsp+138]
       mov       r10d,[rsp+13C]
M08_L36:
       mov       r11,271C4000C90
       mov       r11,[r11]
       mov       [rsp+38],r11
       mov       rdx,r11
       mov       [rsp+88],rdx
       cmp       byte ptr [rdx+9D],0
       jne       near ptr M08_L132
M08_L37:
       lea       rcx,[rsi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+28]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rsi+30],r13
       xor       ebx,ebx
       test      edi,edi
       jle       short M08_L39
       mov       ebp,[rsp+0CC]
       cmp       ebp,edi
       jl        near ptr M08_L52
       xor       ebx,ebx
M08_L38:
       mov       r13d,[r15+rbx]
       mov       rcx,[rsi+18]
       mov       r8,[r14+rbx*2+10]
       movsxd    rdx,r13d
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       add       rbx,4
       dec       edi
       jne       short M08_L38
M08_L39:
       mov       rbx,[rsp+0B8]
       test      rbx,rbx
       je        near ptr M08_L136
       mov       ecx,[rbx+8]
       dec       ecx
       or        ecx,0F
       xor       edi,edi
       lzcnt     edi,ecx
       xor       edi,1F
       add       edi,0FFFFFFFD
       mov       rbp,[rsp+48]
       mov       rax,[rbp+10]
       test      rax,rax
       je        near ptr M08_L137
M08_L40:
       xor       ebp,ebp
       mov       r14d,1
       cmp       [rax+8],edi
       jbe       short M08_L41
       mov       ebp,1
       mov       ecx,10
       shlx      ecx,ecx,edi
       cmp       [rbx+8],ecx
       jne       near ptr M08_L138
       cmp       edi,[rax+8]
       jae       near ptr M08_L154
       mov       ecx,edi
       shl       rcx,4
       lea       r15,[rax+rcx+10]
       mov       r13,[r15]
       mov       rcx,r15
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r15+8],ecx
       test      r13,r13
       jne       near ptr M08_L139
M08_L41:
       mov       r15,[rsp+38]
       cmp       byte ptr [r15+9D],0
       jne       near ptr M08_L151
M08_L42:
       mov       rax,rsi
       vzeroupper
       add       rsp,188
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M08_L43:
       mov       rcx,rsi
       mov       rdx,7FF9E6471E00
       call      qword ptr [7FF9E5BDF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M08_L02
M08_L44:
       mov       rdx,7FF9E6473828
       call      qword ptr [7FF9E5BDF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M08_L04
M08_L45:
       mov       rdx,7FF9E6473750
       call      qword ptr [7FF9E5BDF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M08_L05
M08_L46:
       mov       r8,[rsp+58]
       mov       r9,[rsp+50]
       mov       r10d,[rsp+100]
M08_L47:
       mov       r11d,ecx
       mov       r11d,[r15+r11*4]
       imul      r11,[rsp+150]
       shr       r11,20
       inc       r11
       imul      r11,rdx
       shr       r11,20
       cmp       r11d,r10d
       jae       near ptr M08_L154
       mov       r11d,r11d
       lea       r11,[r8+r11*4]
       cmp       ecx,r12d
       jae       near ptr M08_L154
       mov       ebx,ecx
       mov       [rsp+178],rbx
       mov       ebx,[r11]
       mov       rax,[rsp+178]
       mov       [r9+rax*4],ebx
       mov       [r11],ecx
       inc       ecx
       cmp       ecx,edi
       mov       r12d,[rsp+0FC]
       jl        short M08_L46
       jmp       near ptr M08_L113
M08_L48:
       mov       rax,[rsp+98]
M08_L49:
       mov       edx,[rsp+14C]
       inc       edx
       cmp       r8d,edx
       jle       near ptr M08_L33
M08_L50:
       cmp       edx,r10d
       jae       near ptr M08_L154
       mov       [rsp+14C],edx
       mov       r11d,edx
       mov       r9,[rsp+58]
       mov       r11d,[r9+r11*4]
       test      r11d,r11d
       jl        short M08_L48
       xor       r8d,r8d
       mov       edx,ecx
M08_L51:
       cmp       r11d,edi
       jae       near ptr M08_L154
       mov       eax,r11d
       lea       rax,[r15+rax*4]
       mov       r13d,[rax]
       cmp       ecx,[rbx+8]
       jae       near ptr M08_L154
       mov       ebp,ecx
       mov       [rbx+rbp*4+10],r13d
       mov       [rax],ecx
       inc       ecx
       inc       r8d
       cmp       r11d,r12d
       jae       near ptr M08_L154
       mov       r11d,r11d
       mov       rbp,[rsp+50]
       mov       r11d,[rbp+r11*4]
       test      r11d,r11d
       jge       short M08_L51
       mov       r13,[rsp+150]
       lea       r11d,[rdx+r8-1]
       mov       r8d,[rsp+14C]
       mov       rax,[rsp+98]
       lea       r8,[rax+r8*8+10]
       mov       [r8],edx
       mov       [r8+4],r11d
       mov       rax,[rsp+98]
       mov       r8d,[rsp+0C8]
       jmp       near ptr M08_L49
M08_L52:
       cmp       ebx,edi
       jae       near ptr M08_L154
       mov       ecx,ebx
       mov       r13d,[r15+rcx*4]
       mov       rcx,[rsi+18]
       cmp       ebx,ebp
       jae       near ptr M08_L154
       mov       r8d,ebx
       mov       r8,[r14+r8*8+10]
       movsxd    rdx,r13d
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       inc       ebx
       cmp       ebx,edi
       jl        short M08_L52
       jmp       near ptr M08_L39
M08_L53:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdi,[rdx+0A0]
       test      rdi,rdi
       je        short M08_L54
       jmp       short M08_L55
M08_L54:
       mov       rdx,7FF9E643EBD8
       call      qword ptr [7FF9E5BDF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
M08_L55:
       mov       rdx,[rbx+18]
       mov       rcx,offset MT_System.Collections.Generic.IEqualityComparer<System.String>
       call      qword ptr [7FF9E5BD58D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rcx,rax
       call      qword ptr [7FF9E63AFC00]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF9E5BD58D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdi,rax
       jmp       near ptr M08_L00
M08_L56:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+0A8]
       test      rdx,rdx
       je        short M08_L57
       jmp       short M08_L58
M08_L57:
       mov       rdx,7FF9E643EBE8
       call      qword ptr [7FF9E5BDF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M08_L58:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdi,[rax]
       jmp       near ptr M08_L00
M08_L59:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF9E5DA7810]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       test      eax,eax
       jge       near ptr M08_L01
       mov       rcx,[rsi+18]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       je        short M08_L60
       jmp       short M08_L61
M08_L60:
       mov       rcx,rsi
       mov       rdx,7FF9E6472CB8
       call      qword ptr [7FF9E5BDF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M08_L61:
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       cmp       [rax],rdi
       je        short M08_L62
       mov       rdx,271C4000068
       cmp       rdi,[rdx]
       je        short M08_L62
       mov       rdx,271C4000070
       cmp       rdi,[rdx]
       jne       near ptr M08_L01
M08_L62:
       mov       rdx,rdi
       mov       rcx,offset MT_System.Collections.Generic.IEqualityComparer<System.String>
       call      qword ptr [7FF9E5BD58D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdi,rax
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.HashSet<System.String>
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       rbx,rax
       mov       edx,[rbx+28]
       sub       edx,[rbx+30]
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbp,rax
       mov       r9d,[rbx+28]
       sub       r9d,[rbx+30]
       mov       rcx,rbx
       mov       rdx,rbp
       xor       r8d,r8d
       call      qword ptr [7FF9E5F4DA28]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].CopyTo(System.__Canon[], Int32, Int32)
       mov       ebx,7FFFFFFF
       xor       r14d,r14d
       xor       r15d,r15d
       xor       ecx,ecx
       jmp       short M08_L66
M08_L63:
       mov       rdx,[rbp+rcx*8+10]
       cmp       [rdx+8],ebx
       jge       short M08_L64
       mov       ebx,[rdx+8]
M08_L64:
       cmp       [rdx+8],r14d
       jle       short M08_L65
       mov       r14d,[rdx+8]
M08_L65:
       mov       edx,[rdx+8]
       mov       r8d,1
       shlx      rdx,r8,rdx
       or        r15,rdx
       inc       ecx
M08_L66:
       cmp       [rbp+8],ecx
       jg        short M08_L63
       mov       rcx,rbp
       mov       rdx,rdi
       mov       r8d,ebx
       mov       r9d,r14d
       call      qword ptr [7FF9E6484B88]
       mov       r13,rax
       test      r13,r13
       je        short M08_L69
       mov       rcx,[rsi+18]
       cmp       qword ptr [rcx+8],30
       jle       short M08_L67
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M08_L67
       jmp       short M08_L68
M08_L67:
       mov       rcx,rsi
       mov       rdx,7FF9E64730B0
       call      qword ptr [7FF9E5BDF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M08_L68:
       mov       rdx,r13
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       nop
       vzeroupper
       add       rsp,188
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M08_L69:
       lea       rdx,[rbp+10]
       mov       r8d,[rbp+8]
       mov       [rsp+0D0],rdx
       mov       [rsp+0D8],r8d
       mov       [rsp+20],r14d
       lea       rdx,[rsp+0D0]
       mov       r8,271C4000070
       cmp       rdi,[r8]
       sete      r8b
       movzx     r8d,r8b
       lea       rcx,[rsp+160]
       mov       r9d,ebx
       call      qword ptr [7FF9E6484BA0]
       mov       ebx,[rsp+168]
       movzx     r14d,byte ptr [rsp+160]
       movzx     r12d,byte ptr [rsp+161]
       mov       r13d,[rsp+164]
       mov       eax,[rsp+16C]
       mov       [rsp+0F8],eax
       mov       edx,[rsp+170]
       mov       [rsp+0F4],edx
       test      ebx,ebx
       je        near ptr M08_L81
       test      r13d,r13d
       jge       near ptr M08_L75
       test      r14d,r14d
       je        near ptr M08_L72
       test      r12d,r12d
       jne       short M08_L70
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_RightJustifiedCaseInsensitiveSubstring
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       r15d,[rsp+0F4]
       mov       [rsp+20],r15d
       mov       [rsp+28],r13d
       mov       [rsp+30],ebx
       mov       rcx,r14
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+0F8]
       call      qword ptr [7FF9E6484BB8]
       jmp       short M08_L71
M08_L70:
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_RightJustifiedCaseInsensitiveAsciiSubstring
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       r15d,[rsp+0F4]
       mov       [rsp+20],r15d
       mov       [rsp+28],r13d
       mov       [rsp+30],ebx
       mov       rcx,r14
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+0F8]
       call      qword ptr [7FF9E6484BB8]
M08_L71:
       mov       r13,r14
       jmp       near ptr M08_L85
M08_L72:
       cmp       ebx,1
       je        short M08_L73
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_RightJustifiedSubstring
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       r15d,[rsp+0F4]
       mov       [rsp+20],r15d
       mov       [rsp+28],r13d
       mov       [rsp+30],ebx
       mov       rcx,r12
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+0F8]
       call      qword ptr [7FF9E6484BB8]
       jmp       short M08_L74
M08_L73:
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_RightJustifiedSingleChar
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       r15d,[rsp+0F4]
       mov       [rsp+20],r15d
       mov       [rsp+28],r13d
       mov       dword ptr [rsp+30],1
       mov       rcx,r12
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+0F8]
       call      qword ptr [7FF9E6484BB8]
M08_L74:
       mov       r13,r12
       jmp       near ptr M08_L85
M08_L75:
       test      r14d,r14d
       je        near ptr M08_L78
       test      r12d,r12d
       jne       short M08_L76
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_LeftJustifiedCaseInsensitiveSubstring
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       r15d,[rsp+0F4]
       mov       [rsp+20],r15d
       mov       [rsp+28],r13d
       mov       [rsp+30],ebx
       mov       rcx,r14
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+0F8]
       call      qword ptr [7FF9E6484BB8]
       jmp       short M08_L77
M08_L76:
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_LeftJustifiedCaseInsensitiveAsciiSubstring
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       r15d,[rsp+0F4]
       mov       [rsp+20],r15d
       mov       [rsp+28],r13d
       mov       [rsp+30],ebx
       mov       rcx,r14
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+0F8]
       call      qword ptr [7FF9E6484BB8]
M08_L77:
       mov       r13,r14
       jmp       near ptr M08_L85
M08_L78:
       cmp       ebx,1
       je        short M08_L79
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_LeftJustifiedSubstring
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       r15d,[rsp+0F4]
       mov       [rsp+20],r15d
       mov       [rsp+28],r13d
       mov       [rsp+30],ebx
       mov       rcx,r12
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+0F8]
       call      qword ptr [7FF9E6484BB8]
       jmp       short M08_L80
M08_L79:
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_LeftJustifiedSingleChar
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       r15d,[rsp+0F4]
       mov       [rsp+20],r15d
       mov       [rsp+28],r13d
       mov       dword ptr [rsp+30],1
       mov       rcx,r12
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+0F8]
       call      qword ptr [7FF9E6484BB8]
M08_L80:
       mov       r13,r12
       jmp       near ptr M08_L85
M08_L81:
       test      r14d,r14d
       je        short M08_L84
       test      r12d,r12d
       jne       short M08_L82
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_FullCaseInsensitive
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       ebx,[rsp+0F4]
       mov       [rsp+20],ebx
       mov       [rsp+28],r15
       mov       rcx,r13
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+0F8]
       call      qword ptr [7FF9E6484BD0]
       jmp       short M08_L83
M08_L82:
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_FullCaseInsensitiveAscii
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       ebx,[rsp+0F4]
       mov       [rsp+20],ebx
       mov       [rsp+28],r15
       mov       rcx,r13
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+0F8]
       call      qword ptr [7FF9E6484BE8]
M08_L83:
       jmp       short M08_L85
M08_L84:
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_Full
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       ebx,[rsp+0F4]
       mov       [rsp+20],ebx
       mov       [rsp+28],r15
       mov       rcx,r13
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+0F8]
       call      qword ptr [7FF9E6484C00]
M08_L85:
       mov       rcx,[rsi+18]
       cmp       qword ptr [rcx+8],30
       jle       short M08_L86
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M08_L86
       jmp       short M08_L87
M08_L86:
       mov       rcx,rsi
       mov       rdx,7FF9E64730B0
       call      qword ptr [7FF9E5BDF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M08_L87:
       mov       rdx,r13
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       nop
       vzeroupper
       add       rsp,188
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M08_L88:
       mov       rcx,[rsi+18]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M08_L89
       jmp       short M08_L90
M08_L89:
       mov       rcx,rsi
       mov       rdx,7FF9E6472B98
       call      qword ptr [7FF9E5BDF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M08_L90:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF9E6485338]
       mov       rax,rsi
       vzeroupper
       add       rsp,188
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M08_L91:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdi,[rdx+0A0]
       test      rdi,rdi
       je        short M08_L92
       jmp       short M08_L93
M08_L92:
       mov       rdx,7FF9E643EBD8
       call      qword ptr [7FF9E5BDF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
M08_L93:
       mov       rdx,[rbx+18]
       mov       rcx,offset MT_System.Collections.Generic.IEqualityComparer<System.String>
       call      qword ptr [7FF9E5BD58D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rcx,rax
       call      qword ptr [7FF9E63AFC00]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF9E5BD58D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdx,rax
       jmp       near ptr M08_L03
M08_L94:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+0A8]
       test      rdx,rdx
       je        short M08_L95
       jmp       short M08_L96
M08_L95:
       mov       rdx,7FF9E643EBE8
       call      qword ptr [7FF9E5BDF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M08_L96:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       jmp       near ptr M08_L03
M08_L97:
       mov       ecx,28F
       mov       rdx,7FF9E5B14000
       call      qword ptr [7FF9E5BDF228]
       mov       rdx,rax
       mov       ecx,r13d
       call      qword ptr [7FF9E63ADAD0]
       int       3
M08_L98:
       test      edi,edi
       jne       near ptr M08_L108
       xor       r15d,r15d
       xor       edi,edi
       jmp       near ptr M08_L09
M08_L99:
       jmp       near ptr M08_L20
M08_L100:
       xor       eax,eax
       jmp       near ptr M08_L14
M08_L101:
       mov       r9d,80
       test      dl,1
       je        short M08_L102
       mov       r9d,edx
       and       r9,2
       movzx     r9d,byte ptr [rcx+r9]
       or        r9d,8000
M08_L102:
       test      dl,2
       je        short M08_L103
       shl       r9d,10
       movzx     ecx,word ptr [rcx]
       or        r9d,ecx
       mov       ecx,r9d
       jmp       near ptr M08_L13
M08_L103:
       mov       ecx,r9d
       jmp       near ptr M08_L13
M08_L104:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       jmp       near ptr M08_L14
M08_L105:
       mov       r8,[rsp+0B0]
       mov       rdx,r8
       call      qword ptr [r11]
       jmp       near ptr M08_L14
M08_L106:
       mov       edx,[rsp+158]
       test      edx,edx
       jne       short M08_L108
       xor       r8d,r8d
       xor       r10d,r10d
       jmp       near ptr M08_L21
M08_L107:
       or        edx,r12d
       jne       short M08_L108
       xor       r9d,r9d
       xor       r12d,r12d
       mov       ecx,r9d
       mov       r9,r12
       mov       r12d,ecx
       jmp       near ptr M08_L22
M08_L108:
       call      qword ptr [7FF9E5DAF228]
       int       3
M08_L109:
       xor       r11d,r11d
       test      cl,4
       je        short M08_L110
       mov       dword ptr [r8+r11*4],0FFFFFFFF
       mov       dword ptr [r8+r11*4+4],0FFFFFFFF
       mov       dword ptr [r8+r11*4+8],0FFFFFFFF
       mov       dword ptr [r8+r11*4+0C],0FFFFFFFF
       add       r11,4
M08_L110:
       test      cl,2
       je        short M08_L111
       mov       dword ptr [r8+r11*4],0FFFFFFFF
       mov       dword ptr [r8+r11*4+4],0FFFFFFFF
       add       r11,2
M08_L111:
       test      cl,1
       je        near ptr M08_L26
       mov       dword ptr [r8+r11*4],0FFFFFFFF
       jmp       near ptr M08_L26
M08_L112:
       mov       r13,[rsp+150]
       jmp       near ptr M08_L28
M08_L113:
       mov       r13,[rsp+150]
       jmp       near ptr M08_L28
M08_L114:
       mov       rax,[rsp+98]
       jmp       near ptr M08_L33
M08_L115:
       mov       ecx,7
       call      qword ptr [7FF9E63ADD28]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       r9,rax
       mov       rax,[rsp+98]
       mov       rdx,[rsp+90]
       jmp       near ptr M08_L34
M08_L116:
       jmp       short M08_L115
M08_L117:
       mov       rcx,rdx
       call      qword ptr [7FF9E617EF40]; System.Buffers.SharedArrayPool`1[[System.Int32, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
       mov       r11,rax
       mov       rax,[rsp+98]
       jmp       near ptr M08_L35
M08_L118:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9E620E988]
       mov       rbx,rax
       mov       ecx,29B
       mov       rdx,7FF9E5B14000
       call      qword ptr [7FF9E5BDF228]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9E5F47D50]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M08_L119:
       mov       r8,[rsp+90]
       mov       rcx,[r8+10]
       mov       r10d,[rsp+13C]
       cmp       r10d,[rcx+8]
       jae       near ptr M08_L154
       mov       edx,r10d
       mov       r9,[rcx+rdx*8+10]
       test      r9,r9
       jne       short M08_L121
       mov       rcx,r8
       mov       edx,r10d
       call      qword ptr [7FF9E63AFBE8]
       mov       r9,rax
M08_L120:
       mov       rcx,[r9+8]
       mov       [rsp+70],rcx
       call      qword ptr [7FF9E620EF58]; System.Threading.Thread.GetCurrentProcessorNumber()
       mov       ecx,0AAAAAAAB
       mov       edx,eax
       imul      rcx,rdx
       shr       rcx,23
       imul      ecx,0C
       sub       eax,ecx
       xor       edx,edx
       jmp       near ptr M08_L128
M08_L121:
       jmp       short M08_L120
M08_L122:
       cmp       eax,[r8+8]
       jae       near ptr M08_L154
       mov       [rsp+120],eax
       mov       ecx,eax
       mov       r10,[r8+rcx*8+10]
       mov       [rsp+68],r10
       cmp       [r10],r10b
       xor       r9d,r9d
       mov       [rsp+118],r9d
       mov       rcx,r10
       call      qword ptr [7FF9E60FDF98]; System.Threading.Monitor.Enter(System.Object)
       mov       rax,[rsp+68]
       mov       rcx,[rax+8]
       mov       r8d,[rax+10]
       mov       [rsp+114],r8d
       cmp       [rcx+8],r8d
       jbe       short M08_L124
       test      r8d,r8d
       jne       short M08_L125
       xor       edx,edx
       mov       [rax+14],edx
M08_L123:
       movsxd    rdx,r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,[rsp+78]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rsp+114]
       inc       ecx
       mov       rax,[rsp+68]
       mov       [rax+10],ecx
       mov       dword ptr [rsp+118],1
M08_L124:
       mov       rcx,rax
       call      qword ptr [7FF9E5BD6820]; System.Threading.Monitor.Exit(System.Object)
       cmp       dword ptr [rsp+118],0
       je        short M08_L126
       jmp       short M08_L129
M08_L125:
       jmp       short M08_L123
M08_L126:
       mov       eax,[rsp+120]
       inc       eax
       mov       ecx,eax
       mov       r8,[rsp+70]
       cmp       [r8+8],ecx
       jne       short M08_L127
       xor       ecx,ecx
M08_L127:
       mov       edx,[rsp+11C]
       inc       edx
       mov       eax,ecx
M08_L128:
       mov       r8,[rsp+70]
       mov       [rsp+11C],edx
       cmp       [r8+8],edx
       jg        near ptr M08_L122
       jmp       short M08_L130
M08_L129:
       mov       edx,1
       jmp       short M08_L131
M08_L130:
       xor       edx,edx
M08_L131:
       mov       [rsp+134],edx
       mov       rax,[rsp+98]
       mov       ecx,[rsp+138]
       mov       r10d,[rsp+13C]
       jmp       near ptr M08_L36
M08_L132:
       mov       r8,[rsp+0A0]
       cmp       dword ptr [r8+8],0
       mov       [rsp+138],ecx
       je        near ptr M08_L37
       mov       rcx,r8
       call      qword ptr [7FF9E5FFD740]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+130],eax
       mov       rdx,[rsp+0A0]
       mov       r8d,[rdx+8]
       mov       [rsp+12C],r8d
       mov       rcx,[rsp+90]
       call      qword ptr [7FF9E5FFD740]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,[rsp+88]
       mov       r8d,[rsp+130]
       mov       r9d,[rsp+12C]
       mov       edx,3
       call      qword ptr [7FF9E63AF810]
       mov       eax,[rsp+138]
       test      [rsp+134],eax
       jne       short M08_L133
       mov       rcx,[rsp+0A0]
       call      qword ptr [7FF9E5FFD740]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+128],eax
       mov       rcx,[rsp+0A0]
       mov       edx,[rcx+8]
       mov       [rsp+124],edx
       mov       rcx,[rsp+90]
       call      qword ptr [7FF9E5FFD740]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       cmp       dword ptr [rsp+138],0
       jne       short M08_L134
       mov       ecx,0FFFFFFFF
       mov       edx,1
       jmp       short M08_L135
M08_L133:
       mov       rax,[rsp+98]
       jmp       near ptr M08_L37
M08_L134:
       mov       ecx,[rsp+13C]
       xor       edx,edx
M08_L135:
       mov       [rsp+20],ecx
       mov       [rsp+28],edx
       mov       rcx,[rsp+88]
       mov       edx,[rsp+128]
       mov       r8d,[rsp+124]
       call      qword ptr [7FF9E620EA00]
       mov       rax,[rsp+98]
       jmp       near ptr M08_L37
M08_L136:
       mov       ecx,2
       call      qword ptr [7FF9E5BDFD50]
       int       3
M08_L137:
       mov       rcx,r12
       call      qword ptr [7FF9E617EF40]; System.Buffers.SharedArrayPool`1[[System.Int32, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
       jmp       near ptr M08_L40
M08_L138:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9E620E988]
       mov       r12,rax
       mov       ecx,29B
       mov       rdx,7FF9E5B14000
       call      qword ptr [7FF9E5BDF228]
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,rbx
       call      qword ptr [7FF9E5F47D50]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M08_L139:
       mov       rcx,[r12+10]
       cmp       edi,[rcx+8]
       jae       near ptr M08_L154
       mov       edx,edi
       mov       rax,[rcx+rdx*8+10]
       test      rax,rax
       jne       short M08_L140
       mov       rcx,r12
       mov       edx,edi
       call      qword ptr [7FF9E63AFBE8]
M08_L140:
       mov       r14,[rax+8]
       call      qword ptr [7FF9E620EF58]; System.Threading.Thread.GetCurrentProcessorNumber()
       mov       ecx,0AAAAAAAB
       mov       edx,eax
       imul      rcx,rdx
       shr       rcx,23
       imul      ecx,0C
       mov       r15d,eax
       sub       r15d,ecx
       xor       eax,eax
       jmp       near ptr M08_L147
M08_L141:
       cmp       r15d,[r14+8]
       jae       near ptr M08_L154
       mov       ecx,r15d
       mov       rdx,[r14+rcx*8+10]
       mov       [rsp+60],rdx
       cmp       [rdx],dl
       xor       r8d,r8d
       mov       [rsp+108],r8d
       mov       rcx,rdx
       call      qword ptr [7FF9E60FDF98]; System.Threading.Monitor.Enter(System.Object)
       mov       rax,[rsp+60]
       mov       rcx,[rax+8]
       mov       r8d,[rax+10]
       mov       [rsp+104],r8d
       cmp       [rcx+8],r8d
       jbe       short M08_L143
       test      r8d,r8d
       jne       short M08_L144
       xor       edx,edx
       mov       [rax+14],edx
M08_L142:
       movsxd    rdx,r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rsp+104]
       inc       ecx
       mov       rax,[rsp+60]
       mov       [rax+10],ecx
       mov       dword ptr [rsp+108],1
M08_L143:
       mov       rcx,rax
       call      qword ptr [7FF9E5BD6820]; System.Threading.Monitor.Exit(System.Object)
       cmp       dword ptr [rsp+108],0
       je        short M08_L145
       jmp       short M08_L148
M08_L144:
       jmp       short M08_L142
M08_L145:
       inc       r15d
       cmp       [r14+8],r15d
       jne       short M08_L146
       xor       r15d,r15d
M08_L146:
       mov       eax,[rsp+10C]
       inc       eax
M08_L147:
       mov       [rsp+10C],eax
       cmp       [r14+8],eax
       jg        near ptr M08_L141
       jmp       short M08_L149
M08_L148:
       mov       r14d,1
       jmp       short M08_L150
M08_L149:
       xor       r14d,r14d
M08_L150:
       jmp       near ptr M08_L41
M08_L151:
       cmp       dword ptr [rbx+8],0
       je        near ptr M08_L42
       mov       rcx,rbx
       call      qword ptr [7FF9E5FFD740]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r13d,eax
       mov       eax,[rbx+8]
       mov       [rsp+110],eax
       mov       rcx,r12
       call      qword ptr [7FF9E5FFD740]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,r15
       mov       r8d,r13d
       mov       r9d,[rsp+110]
       mov       edx,3
       call      qword ptr [7FF9E63AF810]
       test      r14d,ebp
       jne       near ptr M08_L42
       mov       rcx,rbx
       call      qword ptr [7FF9E5FFD740]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r14d,eax
       mov       ebx,[rbx+8]
       mov       rcx,r12
       call      qword ptr [7FF9E5FFD740]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       test      ebp,ebp
       jne       short M08_L152
       mov       ecx,0FFFFFFFF
       mov       edx,1
       jmp       short M08_L153
M08_L152:
       mov       ecx,edi
       xor       edx,edx
M08_L153:
       mov       [rsp+20],ecx
       mov       [rsp+28],edx
       mov       rcx,r15
       mov       edx,r14d
       mov       r8d,ebx
       call      qword ptr [7FF9E620EA00]
       jmp       near ptr M08_L42
M08_L154:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 6080
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
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       test      rbx,rbx
       je        near ptr M10_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M10_L01
       test      rsi,rsi
       je        short M10_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M10_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M10_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFA45879D30
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF9E5BD5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF9E5BD5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
M10_L00:
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
M10_L01:
       test      rsi,rsi
       je        short M10_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M10_L03
M10_L02:
       mov       rax,2B258E80008
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M10_L03:
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
M10_L04:
       call      qword ptr [7FF9E63AF528]
       int       3
; Total bytes of code 244
```
```assembly
; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].get_Comparer()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       rcx,[rbx]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rdx,offset MT_System.String
       cmp       [rcx],rdx
       je        short M11_L01
       mov       rax,[rbx+18]
       test      rax,rax
       je        short M11_L04
M11_L00:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M11_L01:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rsi,[rdx+0A0]
       test      rsi,rsi
       je        short M11_L02
       jmp       short M11_L03
M11_L02:
       mov       rdx,7FF9E643EBD8
       call      qword ptr [7FF9E5BDF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rsi,rax
M11_L03:
       mov       rdx,[rbx+18]
       mov       rcx,offset MT_System.Collections.Generic.IEqualityComparer<System.String>
       call      qword ptr [7FF9E5BD58D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rcx,rax
       call      qword ptr [7FF9E63AFC00]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9E5BD58D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M11_L04:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+0A8]
       test      rdx,rdx
       je        short M11_L05
       jmp       short M11_L06
M11_L05:
       mov       rdx,7FF9E643EBE8
       call      qword ptr [7FF9E5BDF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M11_L06:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rax]
       jmp       near ptr M11_L00
; Total bytes of code 206
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M12_L00
       ret
M12_L00:
       jmp       qword ptr [7FF9E5BD5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.ToFrozenSet()
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
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-70],xmm4
       xor       eax,eax
       mov       [rbp-60],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       test      rsi,rsi
       je        near ptr M00_L44
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L46
       mov       rcx,[rsi+8]
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],r11
       jne       near ptr M00_L45
       mov       edi,[rcx+10]
M00_L00:
       test      edi,edi
       je        near ptr M00_L59
       mov       rdx,180D2802A18
       mov       rdi,[rdx]
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Frozen.FrozenSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r14,rax
       test      r14,r14
       jne       near ptr M00_L47
M00_L01:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Generic.HashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r14,rax
       mov       r15,r14
       test      r15,r15
       jne       near ptr M00_L48
M00_L02:
       mov       rcx,offset MT_System.Collections.Generic.HashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       lea       rcx,[r15+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       test      r14,r14
       jne       near ptr M00_L49
M00_L03:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L51
       mov       rcx,[rsi+8]
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],r11
       jne       near ptr M00_L50
       mov       ecx,[rcx+10]
M00_L04:
       test      ecx,ecx
       jle       short M00_L05
       call      qword ptr [7FF9E5BC5A88]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       r14d,eax
       movsxd    rdx,r14d
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r13,rax
       movsxd    rdx,r14d
       mov       rcx,offset MT_System.Collections.Generic.HashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Entry[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r12,rax
       mov       dword ptr [r15+2C],0FFFFFFFF
       lea       rcx,[r15+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,r14d
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [r15+20],rax
M00_L05:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L54
       mov       rsi,[rsi+8]
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L53
       cmp       dword ptr [rsi+10],0
       je        near ptr M00_L52
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       r13d,[rsi+14]
       lea       rcx,[r14+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r14+10],rcx
       mov       [r14+18],r13d
       mov       [r14+1C],ecx
M00_L06:
       mov       [rbp-78],r14
M00_L07:
       mov       rdx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rcx,[rbp-78]
       cmp       [rcx],rdx
       jne       near ptr M00_L36
       mov       rdx,[rcx]
       add       rcx,8
       call      qword ptr [7FF9E5E5C150]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L08:
       test      eax,eax
       je        near ptr M00_L39
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-78]
       cmp       [rax],rcx
       jne       near ptr M00_L24
       mov       rsi,[rax+10]
M00_L09:
       cmp       qword ptr [r15+8],0
       je        near ptr M00_L25
M00_L10:
       mov       r14,[r15+10]
       mov       r13,[r15+18]
       xor       r12d,r12d
       test      rsi,rsi
       je        near ptr M00_L20
       mov       rcx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r13],rcx
       jne       near ptr M00_L32
       mov       rdx,[rsi+28]
       test      rdx,rdx
       je        near ptr M00_L26
       mov       rcx,180D2800068
       mov       rcx,[rcx]
       mov       r8,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],r8
       jne       near ptr M00_L31
       lea       rcx,[rdx+0C]
       mov       r8d,[rdx+8]
       add       r8d,r8d
       mov       [rbp-44],r8d
       mov       dword ptr [rbp-50],6923D06B
       mov       dword ptr [rbp-58],0AB894543
       cmp       r8d,8
       jb        near ptr M00_L18
       mov       edx,r8d
       shr       edx,3
       xchg      ax,ax
M00_L11:
       mov       r10d,[rbp-50]
       add       r10d,[rcx]
       mov       [rbp-50],r10d
       mov       r10d,[rcx+4]
       mov       r9d,[rbp-50]
       mov       r11d,[rbp-58]
       xor       r11d,r9d
       rol       r9d,14
       add       r9d,r11d
       rol       r11d,9
       xor       r11d,r9d
       rol       r9d,1B
       add       r9d,r11d
       rol       r11d,13
       mov       [rbp-50],r9d
       mov       [rbp-58],r11d
       add       r10d,[rbp-50]
       mov       [rbp-50],r10d
       mov       r10d,[rbp-50]
       mov       r9d,[rbp-58]
       xor       r9d,r10d
       rol       r10d,14
       add       r10d,r9d
       rol       r9d,9
       xor       r9d,r10d
       rol       r10d,1B
       add       r10d,r9d
       rol       r9d,13
       mov       [rbp-50],r10d
       mov       [rbp-58],r9d
       add       rcx,8
       dec       edx
       jne       short M00_L11
       test      r8b,4
       jne       near ptr M00_L27
M00_L12:
       mov       edx,r8d
       and       rdx,7
       mov       ecx,[rcx+rdx-4]
       shr       ecx,8
       or        ecx,80000000
       not       r8d
       shl       r8d,3
       shrx      ecx,ecx,r8d
M00_L13:
       add       ecx,[rbp-50]
       mov       [rbp-50],ecx
       lea       rcx,[rbp-50]
       lea       rdx,[rbp-58]
       call      qword ptr [7FF9E6465320]; System.Marvin.Block(UInt32 ByRef, UInt32 ByRef)
       lea       rcx,[rbp-50]
       lea       rdx,[rbp-58]
       call      qword ptr [7FF9E6465320]; System.Marvin.Block(UInt32 ByRef, UInt32 ByRef)
       mov       eax,[rbp-58]
       xor       eax,[rbp-50]
M00_L14:
       mov       [rbp-3C],eax
       mov       rdx,[r15+8]
       mov       ecx,eax
       imul      rcx,[r15+20]
       shr       rcx,20
       inc       rcx
       mov       r8d,[rdx+8]
       mov       r11d,r8d
       imul      rcx,r11
       shr       rcx,20
       cmp       ecx,r8d
       jae       near ptr M00_L38
       mov       ecx,ecx
       lea       r10,[rdx+rcx*4+10]
       mov       [rbp-88],r10
       mov       r9d,[r10]
       dec       r9d
       jns       near ptr M00_L21
M00_L15:
       cmp       dword ptr [r15+30],0
       jg        near ptr M00_L23
       mov       edx,[r15+28]
       mov       [rbp-40],edx
       cmp       [r14+8],edx
       je        near ptr M00_L34
M00_L16:
       mov       edx,[rbp-40]
       mov       r14d,edx
       lea       ecx,[r14+1]
       mov       [r15+28],ecx
       mov       rcx,[r15+10]
       mov       r8,rcx
M00_L17:
       cmp       r14d,[r8+8]
       jae       near ptr M00_L38
       mov       ecx,r14d
       shl       rcx,4
       mov       [rbp-80],r8
       lea       rcx,[r8+rcx+10]
       mov       [rcx+8],eax
       mov       r10,[rbp-88]
       mov       edx,[r10]
       dec       edx
       mov       [rcx+0C],edx
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       inc       r14d
       mov       rdx,[rbp-88]
       mov       [rdx],r14d
       inc       dword ptr [r15+34]
       cmp       r12d,64
       jbe       near ptr M00_L07
       jmp       near ptr M00_L35
M00_L18:
       cmp       r8d,4
       jb        near ptr M00_L28
M00_L19:
       mov       edx,[rbp-50]
       mov       [rbp-98],rcx
       add       edx,[rcx]
       mov       [rbp-50],edx
       lea       rcx,[rbp-50]
       lea       rdx,[rbp-58]
       call      qword ptr [7FF9E6465320]; System.Marvin.Block(UInt32 ByRef, UInt32 ByRef)
       mov       rax,[rbp-78]
       mov       rcx,[rbp-98]
       mov       r8d,[rbp-44]
       jmp       near ptr M00_L12
M00_L20:
       xor       edx,edx
       xor       r10d,r10d
       mov       eax,r10d
       jmp       near ptr M00_L14
M00_L21:
       cmp       r9d,[r14+8]
       jae       near ptr M00_L38
       mov       edx,r9d
       shl       rdx,4
       lea       r9,[r14+rdx+10]
       mov       [rbp-90],r9
       cmp       [r9+8],eax
       je        near ptr M00_L33
M00_L22:
       mov       r9d,[r9+0C]
       inc       r12d
       cmp       [r14+8],r12d
       jb        near ptr M00_L37
       test      r9d,r9d
       mov       eax,[rbp-3C]
       jge       short M00_L21
       jmp       near ptr M00_L15
M00_L23:
       mov       ecx,[r15+2C]
       mov       r8d,ecx
       dec       dword ptr [r15+30]
       cmp       ecx,[r14+8]
       jae       near ptr M00_L38
       shl       rcx,4
       mov       ecx,[r14+rcx+1C]
       neg       ecx
       add       ecx,0FFFFFFFD
       mov       [r15+2C],ecx
       mov       ecx,r8d
       mov       r8,r14
       mov       r14d,ecx
       jmp       near ptr M00_L17
M00_L24:
       mov       rcx,rax
       mov       r11,7FF9E5B10D38
       call      qword ptr [r11]
       mov       rsi,rax
       mov       rax,[rbp-78]
       jmp       near ptr M00_L09
M00_L25:
       mov       rcx,r15
       xor       edx,edx
       call      qword ptr [7FF9E5D97750]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       mov       rax,[rbp-78]
       jmp       near ptr M00_L10
M00_L26:
       xor       ecx,ecx
       mov       eax,ecx
       jmp       near ptr M00_L14
M00_L27:
       jmp       near ptr M00_L19
M00_L28:
       mov       r8d,[rbp-44]
       mov       edx,80
       test      r8b,1
       je        short M00_L29
       mov       edx,r8d
       and       rdx,2
       movzx     edx,byte ptr [rcx+rdx]
       or        edx,8000
M00_L29:
       test      r8b,2
       je        short M00_L30
       shl       edx,10
       movzx     ecx,word ptr [rcx]
       or        edx,ecx
       mov       ecx,edx
       jmp       near ptr M00_L13
M00_L30:
       mov       ecx,edx
       jmp       near ptr M00_L13
M00_L31:
       mov       r8,[rcx]
       mov       r8,[r8+48]
       call      qword ptr [r8+18]
       jmp       near ptr M00_L14
M00_L32:
       mov       rcx,r13
       mov       rdx,rsi
       mov       r11,7FF9E5B10D50
       call      qword ptr [r11]
       jmp       near ptr M00_L14
M00_L33:
       mov       rdx,[r9]
       mov       rcx,r13
       mov       r8,rsi
       mov       r11,7FF9E5B10D58
       call      qword ptr [r11]
       test      eax,eax
       mov       r9,[rbp-90]
       jne       near ptr M00_L07
       jmp       near ptr M00_L22
M00_L34:
       mov       rcx,r15
       call      qword ptr [7FF9E63AFAB0]
       mov       rcx,[r15+8]
       mov       r14d,[rbp-3C]
       mov       edx,r14d
       imul      rdx,[r15+20]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       imul      rdx,rax
       shr       rdx,20
       cmp       edx,[rcx+8]
       jae       short M00_L38
       mov       edx,edx
       lea       r10,[rcx+rdx*4+10]
       mov       rax,r10
       mov       [rbp-88],rax
       mov       eax,r14d
       jmp       near ptr M00_L16
M00_L35:
       mov       r14,[rbp-80]
       mov       rdx,r13
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M00_L07
       mov       edx,[r14+8]
       mov       rcx,r15
       mov       r8d,1
       call      qword ptr [7FF9E5F3D980]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,r15
       mov       rdx,rsi
       call      qword ptr [7FF9E5D97810]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       jmp       near ptr M00_L07
M00_L36:
       mov       r11,7FF9E5B10D30
       call      qword ptr [r11]
       jmp       near ptr M00_L08
M00_L37:
       call      qword ptr [7FF9E5BCF498]
       int       3
M00_L38:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L39:
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-78]
       cmp       [rax],rcx
       jne       near ptr M00_L55
M00_L40:
       mov       ecx,[r15+28]
       test      ecx,ecx
       jle       short M00_L41
       mov       rax,[r15+10]
       mov       eax,[rax+8]
       cdq
       idiv      ecx
       cmp       eax,3
       jg        near ptr M00_L56
M00_L41:
       mov       ecx,[r15+28]
       sub       ecx,[r15+30]
       je        near ptr M00_L57
       xor       esi,esi
M00_L42:
       test      rsi,rsi
       jne       short M00_L43
       mov       rdx,r15
       mov       rcx,7FF9E63D01D8
       call      qword ptr [7FF9E63A57E8]; System.Collections.Frozen.FrozenSet.CreateFromSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
       mov       rsi,rax
M00_L43:
       mov       [rbp-60],rsi
       mov       rcx,[rbx+60]
       lea       r8,[rbp-60]
       mov       rdx,7FF9E63DAF48
       cmp       [rcx],ecx
       call      qword ptr [7FF9E63A6B08]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
M00_L44:
       call      qword ptr [7FF9E616EFA0]
       mov       ecx,65
       mov       rdx,7FF9E5FC8D68
       call      qword ptr [7FF9E5BCF228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF9E5E95AC0
       call      qword ptr [7FF9E5BCF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9E5BCD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9E5FC8D68
       call      qword ptr [7FF9E5BCF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9E5BCD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9E63AD5D8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9E63AD5F0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L45:
       mov       r11,7FF9E5B10D10
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L00
M00_L46:
       mov       rcx,rsi
       mov       r11,7FF9E5B10D08
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L00
M00_L47:
       mov       rcx,[r14+8]
       mov       rdx,rdi
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       test      eax,eax
       je        near ptr M00_L01
       xor       r15d,r15d
       mov       rsi,r14
       jmp       near ptr M00_L42
M00_L48:
       mov       ecx,[r15+28]
       sub       ecx,[r15+30]
       je        near ptr M00_L41
       mov       rcx,r15
       call      qword ptr [7FF9E63A6178]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].get_Comparer()
       mov       rcx,rax
       mov       rdx,rdi
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       test      eax,eax
       jne       near ptr M00_L41
       jmp       near ptr M00_L02
M00_L49:
       mov       r8,r14
       mov       rdx,r15
       mov       rcx,offset MT_System.Collections.Generic.HashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FF9E6465230]
       test      eax,eax
       je        near ptr M00_L03
       mov       rcx,r15
       mov       rdx,r14
       call      qword ptr [7FF9E63AFB10]
       jmp       near ptr M00_L41
M00_L50:
       mov       r11,7FF9E5B10D20
       call      qword ptr [r11]
       mov       ecx,eax
       jmp       near ptr M00_L04
M00_L51:
       mov       rcx,rsi
       mov       r11,7FF9E5B10D18
       call      qword ptr [r11]
       mov       ecx,eax
       jmp       near ptr M00_L04
M00_L52:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,180D2802AC0
       mov       r14,[rcx]
       jmp       near ptr M00_L06
M00_L53:
       mov       rcx,rsi
       mov       r11,7FF9E5B10D48
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L06
M00_L54:
       mov       rcx,rsi
       mov       r11,7FF9E5B10D28
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L06
M00_L55:
       mov       rcx,rax
       mov       r11,7FF9E5B10D40
       call      qword ptr [r11]
       jmp       near ptr M00_L40
M00_L56:
       mov       edx,ecx
       sub       edx,[r15+30]
       mov       rcx,r15
       call      qword ptr [7FF9E63AFB28]
       jmp       near ptr M00_L41
M00_L57:
       mov       rcx,offset MT_System.Collections.Frozen.FrozenSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,180D2802AC8
       mov       rcx,[rcx]
       cmp       rdi,[rcx+8]
       je        short M00_L58
       mov       rcx,offset MT_System.Collections.Frozen.EmptyFrozenSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L42
M00_L58:
       mov       rcx,offset MT_System.Collections.Frozen.FrozenSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,180D2802AC8
       mov       rsi,[rdx]
       jmp       near ptr M00_L42
M00_L59:
       xor       r8d,r8d
       mov       [rbp-70],r8
       mov       [rbp-68],r8d
       lea       r8,[rbp-70]
       mov       rcx,7FF9E6496540
       xor       edx,edx
       call      qword ptr [7FF9E64652C0]
       mov       rsi,rax
       jmp       near ptr M00_L43
       sub       rsp,28
       cmp       qword ptr [rbp-78],0
       je        short M00_L60
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-78]
       cmp       [rax],rcx
       je        short M00_L60
       mov       rcx,rax
       mov       r11,7FF9E5B10D40
       call      qword ptr [r11]
M00_L60:
       nop
       add       rsp,28
       ret
; Total bytes of code 2510
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
       mov       rcx,7FF9ED480B08
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
       call      qword ptr [7FF9E63AEA18]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9E5F35E60]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M02_L03:
       mov       esi,ebx
       or        esi,1
       jmp       short M02_L06
M02_L04:
       mov       ecx,esi
       call      qword ptr [7FF9E63AEA30]
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
; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx]
       mov       rdx,rcx
       mov       eax,[rbx+10]
       cmp       eax,[rcx+14]
       jne       short M03_L00
       mov       ecx,[rbx+14]
       cmp       ecx,[rdx+10]
       jae       short M03_L01
       mov       rdx,[rdx+8]
       cmp       ecx,[rdx+8]
       jae       short M03_L02
       mov       ecx,ecx
       mov       rdx,[rdx+rcx*8+10]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       dword ptr [rbx+14]
       mov       eax,1
       add       rsp,20
       pop       rbx
       ret
M03_L00:
       call      qword ptr [7FF9E5BCFC60]
       int       3
M03_L01:
       xor       eax,eax
       mov       [rbx+8],rax
       mov       dword ptr [rbx+14],0FFFFFFFF
       add       rsp,20
       pop       rbx
       ret
M03_L02:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 101
```
```assembly
; System.Marvin.Block(UInt32 ByRef, UInt32 ByRef)
       mov       eax,[rcx]
       mov       r8d,eax
       xor       r8d,[rdx]
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       mov       [rcx],eax
       mov       [rdx],r8d
       ret
; Total bytes of code 37
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
       call      qword ptr [7FF9E5BC5A88]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       esi,eax
       movsxd    rdx,esi
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rdi,rax
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+0B0]
       test      rax,rax
       je        short M05_L01
       mov       rcx,rax
M05_L00:
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
M05_L01:
       mov       rdx,7FF9E643BAE8
       call      qword ptr [7FF9E5BCF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M05_L00
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
       call      qword ptr [7FF9EE0E7EC8]
       mov       rcx,rax
       movsxd    rdx,esi
       call      qword ptr [7FF9EE0E4088]; CORINFO_HELP_NEWARR_1_DIRECT
       mov       rbp,rax
       mov       r14d,[rbx+28]
       mov       rcx,[rbx+10]
       mov       rdx,rbp
       mov       r8d,r14d
       call      qword ptr [7FF9EE0F52F0]; Precode of System.Array.Copy(System.Array, System.Array, Int32)
       movzx     ecx,dil
       test      cl,1
       jne       near ptr M06_L06
M06_L00:
       movsxd    rcx,esi
       call      qword ptr [7FF9EE0F1B50]
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      qword ptr [7FF9EE0E3FE8]; CORINFO_HELP_ASSIGN_REF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,esi
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rbx+20],rax
       xor       ecx,ecx
       test      r14d,r14d
       jle       short M06_L03
       cmp       [rbp+8],r14d
       jl        near ptr M06_L04
M06_L01:
       mov       edx,ecx
       shl       rdx,4
       lea       rdx,[rbp+rdx+10]
       cmp       dword ptr [rdx+0C],0FFFFFFFF
       jl        short M06_L02
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
       jae       near ptr M06_L11
       mov       r10d,r10d
       lea       rax,[r8+r10*4+10]
       mov       r8d,[rax]
       dec       r8d
       mov       [rdx+0C],r8d
       lea       edx,[rcx+1]
       mov       [rax],edx
M06_L02:
       inc       ecx
       cmp       ecx,r14d
       jl        short M06_L01
M06_L03:
       lea       rcx,[rbx+10]
       mov       rdx,rbp
       call      qword ptr [7FF9EE0E3FE8]; CORINFO_HELP_ASSIGN_REF
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
M06_L04:
       cmp       ecx,[rbp+8]
       jae       near ptr M06_L11
       mov       eax,ecx
       shl       rax,4
       lea       rdx,[rbp+rax+10]
       cmp       dword ptr [rdx+0C],0FFFFFFFF
       jl        short M06_L05
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
       jae       near ptr M06_L11
       mov       eax,r10d
       lea       rax,[r8+rax*4+10]
       mov       r8d,[rax]
       dec       r8d
       mov       [rdx+0C],r8d
       lea       edx,[rcx+1]
       mov       [rax],edx
M06_L05:
       inc       ecx
       cmp       ecx,r14d
       jl        short M06_L04
       jmp       near ptr M06_L03
M06_L06:
       mov       rcx,[rbx]
       call      qword ptr [7FF9EE0E74F8]
       mov       rdi,rax
       mov       rcx,[rbx+18]
       call      qword ptr [7FF9EE0F3730]
       mov       rcx,rax
       lea       r11,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       [rcx],ecx
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF9EE0E4090]; Precode of System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdi,rax
       lea       rcx,[rbx+18]
       mov       rdx,rdi
       call      qword ptr [7FF9EE0E3FE8]; CORINFO_HELP_ASSIGN_REF
       xor       r15d,r15d
       cmp       r15d,r14d
       jge       near ptr M06_L00
M06_L07:
       cmp       r15d,[rbp+8]
       jae       short M06_L11
       mov       rcx,r15
       shl       rcx,4
       lea       r13,[rbp+rcx+10]
       cmp       dword ptr [r13+0C],0FFFFFFFF
       jl        short M06_L10
       cmp       qword ptr [r13],0
       jne       short M06_L08
       xor       r12d,r12d
       jmp       short M06_L09
M06_L08:
       mov       rcx,[rbx]
       call      qword ptr [7FF9EE0E9150]
       mov       rdx,[r13]
       mov       rcx,rdi
       mov       r11,rax
       call      qword ptr [rax]
       mov       r12d,eax
M06_L09:
       mov       [r13+8],r12d
M06_L10:
       inc       r15d
       cmp       r15d,r14d
       jl        short M06_L07
       jmp       near ptr M06_L00
M06_L11:
       call      qword ptr [7FF9EE0E3FD8]
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
       je        near ptr M07_L07
       mov       rdi,[rbx+10]
       xor       ebp,ebp
       mov       r14,[rbx+18]
       test      rsi,rsi
       je        near ptr M07_L11
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+78]
       test      r11,r11
       je        near ptr M07_L08
M07_L00:
       mov       rcx,offset MT_System.Collections.Generic.ObjectEqualityComparer<System.RuntimeType>
       cmp       [r14],rcx
       jne       near ptr M07_L13
       mov       [rsp+38],rsi
       xor       ecx,ecx
       mov       [rsp+30],rcx
       lea       rcx,[rsp+38]
       cmp       qword ptr [rsp+30],0
       jne       short M07_L01
       mov       rcx,[rsp+38]
       mov       [rsp+30],rcx
       lea       rcx,[rsp+30]
       cmp       qword ptr [rsp+30],0
       je        near ptr M07_L12
M07_L01:
       mov       r15,[rcx]
       mov       rcx,offset MT_System.RuntimeType
       cmp       [r15],rcx
       jne       near ptr M07_L10
       mov       rcx,r15
       call      00007FFA45809590
       test      eax,eax
       je        near ptr M07_L09
M07_L02:
       mov       r15d,eax
M07_L03:
       xor       ecx,ecx
       mov       [rsp+30],rcx
M07_L04:
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
       jae       near ptr M07_L18
       mov       edx,edx
       lea       rcx,[rcx+rdx*4+10]
       mov       r13d,[rcx]
       dec       r13d
       js        short M07_L07
M07_L05:
       mov       r12d,[rdi+8]
       cmp       r13d,r12d
       jae       near ptr M07_L18
       mov       ecx,r13d
       shl       rcx,4
       lea       rax,[rdi+rcx+10]
       mov       [rsp+28],rax
       cmp       [rax+8],r15d
       je        near ptr M07_L14
M07_L06:
       mov       rax,[rsp+28]
       mov       r13d,[rax+0C]
       inc       ebp
       cmp       r12d,ebp
       jb        near ptr M07_L17
       test      r13d,r13d
       jge       short M07_L05
M07_L07:
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
M07_L08:
       mov       rdx,7FF9E6436538
       call      qword ptr [7FF9E5BCF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M07_L00
M07_L09:
       mov       rcx,r15
       call      qword ptr [7FF9E5D977F8]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       jmp       near ptr M07_L02
M07_L10:
       mov       rcx,r15
       mov       rax,[r15]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
       mov       r15d,eax
       jmp       near ptr M07_L03
M07_L11:
       xor       r15d,r15d
       jmp       near ptr M07_L04
M07_L12:
       xor       r15d,r15d
       jmp       near ptr M07_L03
M07_L13:
       mov       rcx,r14
       mov       rdx,rsi
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       near ptr M07_L04
M07_L14:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+80]
       test      r11,r11
       je        short M07_L15
       jmp       short M07_L16
M07_L15:
       mov       rdx,7FF9E6436550
       call      qword ptr [7FF9E5BCF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M07_L16:
       mov       rax,[rsp+28]
       mov       rdx,[rax]
       mov       rcx,r14
       mov       r8,rsi
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M07_L06
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
M07_L17:
       call      qword ptr [7FF9E5BCF498]
       int       3
M07_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 547
```
```assembly
; System.Collections.Frozen.FrozenSet.CreateFromSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,188
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+0D0],ymm4
       mov       [rsp+180],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rcx,[rbx]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rdx,offset MT_System.String
       cmp       [rcx],rdx
       je        near ptr M08_L52
       mov       rdi,[rbx+18]
       test      rdi,rdi
       je        near ptr M08_L55
M08_L00:
       mov       rcx,[rsi+18]
       mov       rdx,offset MT_System.String
       cmp       [rcx],rdx
       je        near ptr M08_L58
M08_L01:
       mov       ecx,[rbx+28]
       sub       ecx,[rbx+30]
       cmp       ecx,4
       jle       near ptr M08_L87
       mov       rcx,[rsi+18]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        near ptr M08_L35
M08_L02:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,[rbx]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rdx,offset MT_System.String
       cmp       [rcx],rdx
       je        near ptr M08_L90
       mov       rdx,[rbx+18]
       test      rdx,rdx
       je        near ptr M08_L93
M08_L03:
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+10],rcx
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx+8]
       mov       rax,[rdx+20]
       test      rax,rax
       je        near ptr M08_L36
M08_L04:
       lea       rcx,[rsi+10]
       mov       rdx,rsi
       call      rax
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx+10]
       mov       rdi,[rdx+28]
       test      rdi,rdi
       je        near ptr M08_L37
M08_L05:
       mov       rcx,rdi
       mov       ebp,[rbx+28]
       sub       ebp,[rbx+30]
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       xor       r15d,r15d
       mov       r13d,ebp
       test      r13d,r13d
       jl        near ptr M08_L96
       mov       r12,[rbx+10]
       xor       eax,eax
       cmp       dword ptr [rbx+28],0
       jle       short M08_L08
M08_L06:
       test      r13d,r13d
       je        short M08_L08
       cmp       eax,[r12+8]
       jae       near ptr M08_L152
       mov       [rsp+0C8],rax
       mov       r8,rax
       shl       r8,4
       lea       r8,[r12+r8+10]
       cmp       dword ptr [r8+0C],0FFFFFFFF
       jl        short M08_L07
       lea       edx,[r15+1]
       mov       [rsp+15C],edx
       mov       r8,[r8]
       movsxd    rdx,r15d
       mov       rcx,r14
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       dec       r13d
       mov       r15d,[rsp+15C]
M08_L07:
       mov       rax,[rsp+0C8]
       inc       eax
       mov       rcx,rax
       cmp       ecx,[rbx+28]
       mov       rax,rcx
       jl        short M08_L06
M08_L08:
       mov       rcx,rdi
       mov       edx,ebp
       call      CORINFO_HELP_NEWARR_1_PTR
       lea       rcx,[rsi+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,180D2801D88
       mov       r13,[rcx]
       mov       [rsp+40],r13
       mov       rcx,r13
       mov       edx,ebp
       call      qword ptr [7FF9E61D69D8]; System.Buffers.SharedArrayPool`1[[System.Int32, System.Private.CoreLib]].Rent(Int32)
       mov       rbx,rax
       mov       [rsp+0C0],rbx
       mov       edi,ebp
       test      rbx,rbx
       je        near ptr M08_L97
       cmp       [rbx+8],edi
       jb        near ptr M08_L106
       lea       r15,[rbx+10]
M08_L09:
       xor       r12d,r12d
       cmp       ebp,r12d
       jg        near ptr M08_L51
M08_L10:
       mov       rcx,r15
       mov       r12d,edi
       mov       [rsp+0E0],rcx
       mov       [rsp+0E8],r12d
       lea       rcx,[rsp+0E0]
       xor       edx,edx
       call      qword ptr [7FF9E63A6880]; System.Collections.Frozen.FrozenHashTable.CalcNumBuckets(System.ReadOnlySpan`1<Int32>, Boolean)
       mov       r8d,eax
       mov       [rsp+158],r8d
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,r8d
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rsp+150],rax
       mov       rcx,r13
       lea       edx,[r8+r12]
       call      qword ptr [7FF9E61D69D8]; System.Buffers.SharedArrayPool`1[[System.Int32, System.Private.CoreLib]].Rent(Int32)
       mov       [rsp+0A8],rax
       test      rax,rax
       je        near ptr M08_L104
       mov       edx,[rsp+158]
       cmp       [rax+8],edx
       jb        near ptr M08_L106
       lea       r8,[rax+10]
       mov       r10d,edx
M08_L11:
       mov       [rsp+58],r8
       mov       [rsp+100],r10d
       test      rax,rax
       je        near ptr M08_L105
       mov       ecx,edx
       mov       r9d,r12d
       add       rcx,r9
       mov       r9d,[rax+8]
       cmp       rcx,r9
       ja        near ptr M08_L106
       mov       edx,edx
       lea       r9,[rax+rdx*4+10]
M08_L12:
       mov       [rsp+50],r9
       mov       [rsp+0FC],r12d
       mov       edx,r10d
       mov       rcx,rdx
       cmp       rcx,8
       jb        near ptr M08_L108
       lea       r11,[rcx*4]
       mov       [rsp+140],r11
       and       r11,0FFFFFFFFFFFFFFC0
       xor       r13d,r13d
       cmp       rcx,10
       jb        short M08_L14
       nop       dword ptr [rax]
M08_L13:
       vpcmpeqd  ymm0,ymm0,ymm0
       vmovups   [r8+r13],ymm0
       vmovups   [r8+r13+20],ymm0
       add       r13,40
       cmp       r13,r11
       jb        short M08_L13
M08_L14:
       mov       r11,[rsp+140]
       test      r11b,20
       jne       near ptr M08_L107
M08_L15:
       vpcmpeqd  ymm0,ymm0,ymm0
       vmovups   [r8+r11-20],ymm0
M08_L16:
       xor       ecx,ecx
       test      edi,edi
       jle       near ptr M08_L111
       cmp       edi,r12d
       jg        near ptr M08_L20
       jmp       short M08_L17
M08_L17:
       mov       r11d,ecx
       mov       r11d,[r15+r11*4]
       mov       r13,[rsp+150]
       imul      r11,r13
       shr       r11,20
       inc       r11
       imul      r11,rdx
       shr       r11,20
       cmp       r11d,r10d
       jae       near ptr M08_L152
       mov       r11d,r11d
       lea       r11,[r8+r11*4]
       mov       ebx,ecx
       mov       eax,[r11]
       mov       [r9+rbx*4],eax
       mov       [r11],ecx
       inc       ecx
       cmp       ecx,edi
       jl        short M08_L17
M08_L18:
       mov       edx,edi
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbx,rax
       mov       [rsp+0A0],rbx
       mov       edx,[rsp+100]
       mov       rcx,offset MT_System.Collections.Frozen.FrozenHashTable+Bucket[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       [rsp+98],rax
       xor       ecx,ecx
       xor       edx,edx
       cmp       dword ptr [rax+8],0
       jle       near ptr M08_L25
       mov       r8d,[rsp+100]
       cmp       [rax+8],r8d
       jg        near ptr M08_L43
       jmp       near ptr M08_L24
M08_L19:
       mov       r8,[rsp+58]
       mov       r9,[rsp+50]
       mov       r10d,[rsp+100]
M08_L20:
       mov       r11d,ecx
       mov       r11d,[r15+r11*4]
       imul      r11,[rsp+150]
       shr       r11,20
       inc       r11
       imul      r11,rdx
       shr       r11,20
       cmp       r11d,r10d
       jae       near ptr M08_L152
       mov       r11d,r11d
       lea       r11,[r8+r11*4]
       cmp       ecx,r12d
       jae       near ptr M08_L152
       mov       ebx,ecx
       mov       [rsp+178],rbx
       mov       ebx,[r11]
       mov       rax,[rsp+178]
       mov       [r9+rax*4],ebx
       mov       [r11],ecx
       inc       ecx
       cmp       ecx,edi
       mov       r12d,[rsp+0FC]
       jl        short M08_L19
       jmp       near ptr M08_L112
M08_L21:
       xor       r9d,r9d
       mov       [rsp+14C],r9d
       mov       r11d,ecx
M08_L22:
       cmp       r8d,edi
       jae       near ptr M08_L152
       mov       r12d,r8d
       lea       r12,[r15+r12*4]
       mov       r13d,[r12]
       cmp       ecx,[rbx+8]
       jae       near ptr M08_L152
       mov       ebx,ecx
       mov       r9,[rsp+0A0]
       mov       [r9+rbx*4+10],r13d
       mov       [r12],ecx
       inc       ecx
       mov       r12d,[rsp+14C]
       inc       r12d
       cmp       r8d,[rsp+0FC]
       jae       near ptr M08_L152
       mov       r8d,r8d
       mov       r13,[rsp+50]
       mov       r8d,[r13+r8*4]
       test      r8d,r8d
       mov       [rsp+14C],r12d
       mov       rbx,[rsp+0A0]
       jge       short M08_L22
       mov       r12d,[rsp+0FC]
       mov       r13,[rsp+150]
       mov       r9d,[rsp+14C]
       lea       r8d,[r11+r9-1]
       mov       r9d,edx
       lea       r9,[rax+r9*8+10]
       mov       [r9],r11d
       mov       [r9+4],r8d
M08_L23:
       inc       edx
       cmp       [rax+8],edx
       jle       short M08_L25
M08_L24:
       mov       r8d,edx
       mov       r10,[rsp+58]
       mov       r8d,[r10+r8*4]
       test      r8d,r8d
       jl        short M08_L23
       jmp       near ptr M08_L21
M08_L25:
       mov       r12,[rsp+40]
       mov       rdx,r12
       mov       [rsp+90],rdx
       mov       r8,[rsp+0A8]
       test      r8,r8
       je        near ptr M08_L134
       mov       rdx,[rsp+90]
       mov       ecx,[r8+8]
       dec       ecx
       or        ecx,0F
       xor       r10d,r10d
       lzcnt     r10d,ecx
       xor       r10d,1F
       add       r10d,0FFFFFFFD
       mov       [rsp+13C],r10d
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],7
       jle       near ptr M08_L114
       mov       rcx,[rcx+240]
       mov       r9,[rcx+38]
       test      r9,r9
       je        near ptr M08_L113
M08_L26:
       mov       [rsp+48],r9
       mov       r11,[r9+10]
       test      r11,r11
       je        near ptr M08_L115
M08_L27:
       xor       ecx,ecx
       mov       dword ptr [rsp+134],1
       mov       edx,[r11+8]
       mov       r10d,[rsp+13C]
       cmp       edx,r10d
       jbe       near ptr M08_L28
       mov       dword ptr [rsp+138],1
       mov       edx,10
       shlx      edx,edx,r10d
       mov       r8,[rsp+0A8]
       cmp       [r8+8],edx
       jne       near ptr M08_L116
       mov       edx,r10d
       shl       rdx,4
       lea       r11,[r11+rdx+10]
       mov       [rsp+80],r11
       mov       rdx,[r11]
       mov       [rsp+78],rdx
       mov       rcx,r11
       mov       rdx,r8
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       rdx,[rsp+80]
       mov       [rdx+8],ecx
       cmp       qword ptr [rsp+78],0
       jne       near ptr M08_L117
       mov       rax,[rsp+98]
       mov       ecx,[rsp+138]
       mov       r10d,[rsp+13C]
M08_L28:
       mov       rdx,180D2800C90
       mov       rdx,[rdx]
       mov       [rsp+38],rdx
       mov       r11,rdx
       mov       [rsp+88],r11
       cmp       byte ptr [r11+9D],0
       jne       near ptr M08_L130
M08_L29:
       lea       rcx,[rsi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+28]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rsi+30],r13
       xor       ebx,ebx
       test      edi,edi
       jle       short M08_L31
       cmp       ebp,edi
       jl        near ptr M08_L44
       xor       ebx,ebx
M08_L30:
       mov       r13d,[r15+rbx]
       mov       rcx,[rsi+18]
       mov       r8,[r14+rbx*2+10]
       movsxd    rdx,r13d
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       add       rbx,4
       dec       edi
       jne       short M08_L30
M08_L31:
       mov       rbx,[rsp+0C0]
       test      rbx,rbx
       je        near ptr M08_L134
       mov       ecx,[rbx+8]
       dec       ecx
       or        ecx,0F
       xor       edi,edi
       lzcnt     edi,ecx
       xor       edi,1F
       add       edi,0FFFFFFFD
       mov       rbp,[rsp+48]
       mov       rax,[rbp+10]
       test      rax,rax
       je        near ptr M08_L135
M08_L32:
       xor       ebp,ebp
       mov       r14d,1
       mov       ecx,[rax+8]
       cmp       ecx,edi
       jbe       short M08_L33
       mov       ebp,1
       mov       edx,10
       shlx      edx,edx,edi
       cmp       [rbx+8],edx
       jne       near ptr M08_L136
       cmp       edi,ecx
       jae       near ptr M08_L152
       mov       ecx,edi
       shl       rcx,4
       lea       r15,[rax+rcx+10]
       mov       r13,[r15]
       mov       rcx,r15
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r15+8],ecx
       test      r13,r13
       jne       near ptr M08_L137
M08_L33:
       mov       r15,[rsp+38]
       cmp       byte ptr [r15+9D],0
       jne       near ptr M08_L149
M08_L34:
       mov       rax,rsi
       vzeroupper
       add       rsp,188
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M08_L35:
       mov       rcx,rsi
       mov       rdx,7FF9E643EA98
       call      qword ptr [7FF9E5BCF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M08_L02
M08_L36:
       mov       rdx,7FF9E64804D8
       call      qword ptr [7FF9E5BCF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M08_L04
M08_L37:
       mov       rdx,7FF9E6480400
       call      qword ptr [7FF9E5BCF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M08_L05
M08_L38:
       cmp       edx,4
       jb        near ptr M08_L99
M08_L39:
       add       eax,[rcx]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       jmp       near ptr M08_L47
M08_L40:
       mov       r10,rax
       xor       eax,eax
       jmp       near ptr M08_L50
M08_L41:
       cmp       r11d,edi
       jae       near ptr M08_L152
       mov       ebx,r11d
       lea       rbx,[r15+rbx*4]
       mov       r13d,[rbx]
       mov       r8,[rsp+0A0]
       cmp       ecx,[r8+8]
       jae       near ptr M08_L152
       mov       r8d,ecx
       mov       r9,[rsp+0A0]
       mov       [r9+r8*4+10],r13d
       mov       [rbx],ecx
       inc       ecx
       mov       r8d,[rsp+14C]
       inc       r8d
       mov       ebx,[rsp+0FC]
       cmp       r11d,ebx
       jae       near ptr M08_L152
       mov       r11d,r11d
       mov       r13,[rsp+50]
       mov       r11d,[r13+r11*4]
       test      r11d,r11d
       mov       [rsp+14C],r8d
       jge       short M08_L41
       mov       rbx,r9
       mov       r13,[rsp+150]
       mov       r9d,[rsp+14C]
       lea       r9d,[r12+r9-1]
       mov       r11d,edx
       lea       r11,[rax+r11*8+10]
       mov       [r11],r12d
       mov       [r11+4],r9d
       mov       r12d,[rsp+0FC]
M08_L42:
       inc       edx
       cmp       [rax+8],edx
       mov       rax,[rsp+98]
       mov       r8d,[rsp+100]
       jle       near ptr M08_L25
M08_L43:
       cmp       edx,r8d
       jae       near ptr M08_L152
       mov       r11d,edx
       mov       r10,[rsp+58]
       mov       r11d,[r10+r11*4]
       test      r11d,r11d
       jl        short M08_L42
       xor       r9d,r9d
       mov       [rsp+14C],r9d
       mov       r12d,ecx
       jmp       near ptr M08_L41
M08_L44:
       cmp       ebx,edi
       jae       near ptr M08_L152
       mov       ecx,ebx
       mov       r13d,[r15+rcx*4]
       mov       rcx,[rsi+18]
       cmp       ebx,ebp
       jae       near ptr M08_L152
       mov       r8d,ebx
       mov       r8,[r14+r8*8+10]
       movsxd    rdx,r13d
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       inc       ebx
       cmp       ebx,edi
       jl        short M08_L44
       jmp       near ptr M08_L31
M08_L45:
       mov       rcx,[rsi+8]
       mov       rdx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rdx
       jne       near ptr M08_L103
       mov       r8,[rsp+0B8]
       mov       rdx,[r8+28]
       test      rdx,rdx
       je        near ptr M08_L98
       mov       rcx,180D2800068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M08_L102
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,6923D06B
       mov       r8d,0AB894543
       cmp       edx,8
       jb        near ptr M08_L38
       mov       r9d,edx
       shr       r9d,3
M08_L46:
       add       eax,[rcx]
       mov       r11d,[rcx+4]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       add       r11d,eax
       mov       eax,r8d
       xor       eax,r11d
       rol       r11d,14
       add       r11d,eax
       rol       eax,9
       xor       eax,r11d
       rol       r11d,1B
       add       r11d,eax
       rol       eax,13
       mov       r8d,r11d
       add       rcx,8
       dec       r9d
       mov       r10d,eax
       mov       eax,r8d
       mov       r8d,r10d
       jne       short M08_L46
       test      dl,4
       jne       near ptr M08_L39
M08_L47:
       mov       r9d,edx
       and       r9,7
       mov       ecx,[rcx+r9-4]
       shr       ecx,8
       or        ecx,80000000
       not       edx
       shl       edx,3
       shrx      ecx,ecx,edx
M08_L48:
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
       mov       eax,ecx
       rol       eax,14
       add       eax,edx
       rol       edx,9
       xor       edx,eax
       rol       eax,1B
       add       eax,edx
       mov       r8d,edx
       rol       r8d,13
       xor       eax,r8d
M08_L49:
       mov       r10,[rsp+0B0]
M08_L50:
       mov       [r10],eax
       inc       r12d
       cmp       ebp,r12d
       jle       near ptr M08_L10
M08_L51:
       cmp       r12d,edi
       jae       near ptr M08_L152
       lea       rax,[r15+r12*4]
       mov       r8,[r14+r12*8+10]
       mov       [rsp+0B8],r8
       mov       [rsp+0B0],rax
       test      r8,r8
       je        near ptr M08_L40
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx+10]
       mov       r11,[rdx+30]
       test      r11,r11
       jne       near ptr M08_L45
       mov       rdx,7FF9E6480408
       call      qword ptr [7FF9E5BCF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M08_L45
M08_L52:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdi,[rdx+0A0]
       test      rdi,rdi
       je        short M08_L53
       jmp       short M08_L54
M08_L53:
       mov       rdx,7FF9E643B950
       call      qword ptr [7FF9E5BCF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
M08_L54:
       mov       rdx,[rbx+18]
       mov       rcx,offset MT_System.Collections.Generic.IEqualityComparer<System.String>
       call      qword ptr [7FF9E5BC58D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rcx,rax
       call      qword ptr [7FF9E63AFC48]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF9E5BC58D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdi,rax
       jmp       near ptr M08_L00
M08_L55:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+0A8]
       test      rdx,rdx
       je        short M08_L56
       jmp       short M08_L57
M08_L56:
       mov       rdx,7FF9E643B960
       call      qword ptr [7FF9E5BCF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M08_L57:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdi,[rax]
       jmp       near ptr M08_L00
M08_L58:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF9E5D97810]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       test      eax,eax
       jge       near ptr M08_L01
       mov       rcx,[rsi+18]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       je        short M08_L59
       jmp       short M08_L60
M08_L59:
       mov       rcx,rsi
       mov       rdx,7FF9E643F950
       call      qword ptr [7FF9E5BCF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M08_L60:
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       cmp       [rax],rdi
       je        short M08_L61
       mov       rdx,180D2800068
       cmp       rdi,[rdx]
       je        short M08_L61
       mov       rdx,180D2800070
       cmp       rdi,[rdx]
       jne       near ptr M08_L01
M08_L61:
       mov       rdx,rdi
       mov       rcx,offset MT_System.Collections.Generic.IEqualityComparer<System.String>
       call      qword ptr [7FF9E5BC58D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdi,rax
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.HashSet<System.String>
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       rbx,rax
       mov       edx,[rbx+28]
       sub       edx,[rbx+30]
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbp,rax
       mov       r9d,[rbx+28]
       sub       r9d,[rbx+30]
       mov       rcx,rbx
       mov       rdx,rbp
       xor       r8d,r8d
       call      qword ptr [7FF9E5F3DA28]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].CopyTo(System.__Canon[], Int32, Int32)
       mov       ebx,7FFFFFFF
       xor       r14d,r14d
       xor       r15d,r15d
       xor       ecx,ecx
       jmp       short M08_L65
M08_L62:
       mov       rdx,[rbp+rcx*8+10]
       cmp       [rdx+8],ebx
       jge       short M08_L63
       mov       ebx,[rdx+8]
M08_L63:
       cmp       [rdx+8],r14d
       jle       short M08_L64
       mov       r14d,[rdx+8]
M08_L64:
       mov       edx,[rdx+8]
       mov       r8d,1
       shlx      rdx,r8,rdx
       or        r15,rdx
       inc       ecx
M08_L65:
       cmp       [rbp+8],ecx
       jg        short M08_L62
       mov       rcx,rbp
       mov       rdx,rdi
       mov       r8d,ebx
       mov       r9d,r14d
       call      qword ptr [7FF9E6464BD0]
       mov       r13,rax
       test      r13,r13
       je        short M08_L68
       mov       rcx,[rsi+18]
       cmp       qword ptr [rcx+8],30
       jle       short M08_L66
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M08_L66
       jmp       short M08_L67
M08_L66:
       mov       rcx,rsi
       mov       rdx,7FF9E643FD48
       call      qword ptr [7FF9E5BCF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M08_L67:
       mov       rdx,r13
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       nop
       vzeroupper
       add       rsp,188
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M08_L68:
       lea       rdx,[rbp+10]
       mov       r8d,[rbp+8]
       mov       [rsp+0D0],rdx
       mov       [rsp+0D8],r8d
       mov       [rsp+20],r14d
       lea       rdx,[rsp+0D0]
       mov       r8,180D2800070
       cmp       rdi,[r8]
       sete      r8b
       movzx     r8d,r8b
       lea       rcx,[rsp+160]
       mov       r9d,ebx
       call      qword ptr [7FF9E6464BE8]
       mov       ebx,[rsp+168]
       movzx     r14d,byte ptr [rsp+160]
       movzx     r12d,byte ptr [rsp+161]
       mov       r13d,[rsp+164]
       mov       eax,[rsp+16C]
       mov       [rsp+0F8],eax
       mov       edx,[rsp+170]
       mov       [rsp+0F4],edx
       test      ebx,ebx
       je        near ptr M08_L80
       test      r13d,r13d
       jge       near ptr M08_L74
       test      r14d,r14d
       je        near ptr M08_L71
       test      r12d,r12d
       jne       short M08_L69
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_RightJustifiedCaseInsensitiveSubstring
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       r15d,[rsp+0F4]
       mov       [rsp+20],r15d
       mov       [rsp+28],r13d
       mov       [rsp+30],ebx
       mov       rcx,r14
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+0F8]
       call      qword ptr [7FF9E6464C00]
       jmp       short M08_L70
M08_L69:
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_RightJustifiedCaseInsensitiveAsciiSubstring
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       r15d,[rsp+0F4]
       mov       [rsp+20],r15d
       mov       [rsp+28],r13d
       mov       [rsp+30],ebx
       mov       rcx,r14
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+0F8]
       call      qword ptr [7FF9E6464C00]
M08_L70:
       mov       r13,r14
       jmp       near ptr M08_L84
M08_L71:
       cmp       ebx,1
       je        short M08_L72
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_RightJustifiedSubstring
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       r15d,[rsp+0F4]
       mov       [rsp+20],r15d
       mov       [rsp+28],r13d
       mov       [rsp+30],ebx
       mov       rcx,r12
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+0F8]
       call      qword ptr [7FF9E6464C00]
       jmp       short M08_L73
M08_L72:
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_RightJustifiedSingleChar
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       r15d,[rsp+0F4]
       mov       [rsp+20],r15d
       mov       [rsp+28],r13d
       mov       dword ptr [rsp+30],1
       mov       rcx,r12
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+0F8]
       call      qword ptr [7FF9E6464C00]
M08_L73:
       mov       r13,r12
       jmp       near ptr M08_L84
M08_L74:
       test      r14d,r14d
       je        near ptr M08_L77
       test      r12d,r12d
       jne       short M08_L75
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_LeftJustifiedCaseInsensitiveSubstring
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       r15d,[rsp+0F4]
       mov       [rsp+20],r15d
       mov       [rsp+28],r13d
       mov       [rsp+30],ebx
       mov       rcx,r14
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+0F8]
       call      qword ptr [7FF9E6464C00]
       jmp       short M08_L76
M08_L75:
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_LeftJustifiedCaseInsensitiveAsciiSubstring
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       r15d,[rsp+0F4]
       mov       [rsp+20],r15d
       mov       [rsp+28],r13d
       mov       [rsp+30],ebx
       mov       rcx,r14
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+0F8]
       call      qword ptr [7FF9E6464C00]
M08_L76:
       mov       r13,r14
       jmp       near ptr M08_L84
M08_L77:
       cmp       ebx,1
       je        short M08_L78
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_LeftJustifiedSubstring
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       r15d,[rsp+0F4]
       mov       [rsp+20],r15d
       mov       [rsp+28],r13d
       mov       [rsp+30],ebx
       mov       rcx,r12
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+0F8]
       call      qword ptr [7FF9E6464C00]
       jmp       short M08_L79
M08_L78:
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_LeftJustifiedSingleChar
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       r15d,[rsp+0F4]
       mov       [rsp+20],r15d
       mov       [rsp+28],r13d
       mov       dword ptr [rsp+30],1
       mov       rcx,r12
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+0F8]
       call      qword ptr [7FF9E6464C00]
M08_L79:
       mov       r13,r12
       jmp       near ptr M08_L84
M08_L80:
       test      r14d,r14d
       je        short M08_L83
       test      r12d,r12d
       jne       short M08_L81
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_FullCaseInsensitive
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       ebx,[rsp+0F4]
       mov       [rsp+20],ebx
       mov       [rsp+28],r15
       mov       rcx,r13
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+0F8]
       call      qword ptr [7FF9E6464C18]
       jmp       short M08_L82
M08_L81:
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_FullCaseInsensitiveAscii
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       ebx,[rsp+0F4]
       mov       [rsp+20],ebx
       mov       [rsp+28],r15
       mov       rcx,r13
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+0F8]
       call      qword ptr [7FF9E6464C30]
M08_L82:
       jmp       short M08_L84
M08_L83:
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_Full
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       ebx,[rsp+0F4]
       mov       [rsp+20],ebx
       mov       [rsp+28],r15
       mov       rcx,r13
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+0F8]
       call      qword ptr [7FF9E6464C48]
M08_L84:
       mov       rcx,[rsi+18]
       cmp       qword ptr [rcx+8],30
       jle       short M08_L85
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M08_L85
       jmp       short M08_L86
M08_L85:
       mov       rcx,rsi
       mov       rdx,7FF9E643FD48
       call      qword ptr [7FF9E5BCF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M08_L86:
       mov       rdx,r13
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       nop
       vzeroupper
       add       rsp,188
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M08_L87:
       mov       rcx,[rsi+18]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M08_L88
       jmp       short M08_L89
M08_L88:
       mov       rcx,rsi
       mov       rdx,7FF9E643F830
       call      qword ptr [7FF9E5BCF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M08_L89:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF9E6465380]
       mov       rax,rsi
       vzeroupper
       add       rsp,188
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M08_L90:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdi,[rdx+0A0]
       test      rdi,rdi
       je        short M08_L91
       jmp       short M08_L92
M08_L91:
       mov       rdx,7FF9E643B950
       call      qword ptr [7FF9E5BCF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
M08_L92:
       mov       rdx,[rbx+18]
       mov       rcx,offset MT_System.Collections.Generic.IEqualityComparer<System.String>
       call      qword ptr [7FF9E5BC58D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rcx,rax
       call      qword ptr [7FF9E63AFC48]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF9E5BC58D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdx,rax
       jmp       near ptr M08_L03
M08_L93:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+0A8]
       test      rdx,rdx
       je        short M08_L94
       jmp       short M08_L95
M08_L94:
       mov       rdx,7FF9E643B960
       call      qword ptr [7FF9E5BCF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M08_L95:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       jmp       near ptr M08_L03
M08_L96:
       mov       ecx,28F
       mov       rdx,7FF9E5B04000
       call      qword ptr [7FF9E5BCF228]
       mov       rdx,rax
       mov       ecx,r13d
       call      qword ptr [7FF9E63ADB18]
       int       3
M08_L97:
       test      edi,edi
       jne       near ptr M08_L106
       xor       r15d,r15d
       xor       edi,edi
       jmp       near ptr M08_L09
M08_L98:
       xor       eax,eax
       jmp       near ptr M08_L49
M08_L99:
       mov       r9d,80
       test      dl,1
       je        short M08_L100
       mov       r9d,edx
       and       r9,2
       movzx     r9d,byte ptr [rcx+r9]
       or        r9d,8000
M08_L100:
       test      dl,2
       je        short M08_L101
       shl       r9d,10
       movzx     ecx,word ptr [rcx]
       or        r9d,ecx
       mov       ecx,r9d
       jmp       near ptr M08_L48
M08_L101:
       mov       ecx,r9d
       jmp       near ptr M08_L48
M08_L102:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       jmp       near ptr M08_L49
M08_L103:
       mov       r8,[rsp+0B8]
       mov       rdx,r8
       call      qword ptr [r11]
       jmp       near ptr M08_L49
M08_L104:
       mov       edx,[rsp+158]
       test      edx,edx
       jne       short M08_L106
       xor       r8d,r8d
       xor       r10d,r10d
       jmp       near ptr M08_L11
M08_L105:
       or        edx,r12d
       jne       short M08_L106
       xor       r9d,r9d
       xor       r12d,r12d
       mov       ecx,r9d
       mov       r9,r12
       mov       r12d,ecx
       jmp       near ptr M08_L12
M08_L106:
       call      qword ptr [7FF9E5D9F228]
       int       3
M08_L107:
       vpcmpeqd  ymm0,ymm0,ymm0
       vmovups   [r8+r13],ymm0
       jmp       near ptr M08_L15
M08_L108:
       xor       r11d,r11d
       test      cl,4
       je        short M08_L109
       mov       dword ptr [r8+r11*4],0FFFFFFFF
       mov       dword ptr [r8+r11*4+4],0FFFFFFFF
       mov       dword ptr [r8+r11*4+8],0FFFFFFFF
       mov       dword ptr [r8+r11*4+0C],0FFFFFFFF
       add       r11,4
M08_L109:
       test      cl,2
       je        short M08_L110
       mov       dword ptr [r8+r11*4],0FFFFFFFF
       mov       dword ptr [r8+r11*4+4],0FFFFFFFF
       add       r11,2
M08_L110:
       test      cl,1
       je        near ptr M08_L16
       mov       dword ptr [r8+r11*4],0FFFFFFFF
       jmp       near ptr M08_L16
M08_L111:
       mov       r13,[rsp+150]
       jmp       near ptr M08_L18
M08_L112:
       mov       r13,[rsp+150]
       jmp       near ptr M08_L18
M08_L113:
       mov       ecx,7
       call      qword ptr [7FF9E63ADD70]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       r9,rax
       mov       rax,[rsp+98]
       mov       rdx,[rsp+90]
       jmp       near ptr M08_L26
M08_L114:
       jmp       short M08_L113
M08_L115:
       mov       rcx,rdx
       call      qword ptr [7FF9E616F420]; System.Buffers.SharedArrayPool`1[[System.Int32, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
       mov       r11,rax
       mov       rax,[rsp+98]
       jmp       near ptr M08_L27
M08_L116:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9E61FEE98]
       mov       rbx,rax
       mov       ecx,29B
       mov       rdx,7FF9E5B04000
       call      qword ptr [7FF9E5BCF228]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9E5F37D50]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M08_L117:
       mov       r8,[rsp+90]
       mov       rcx,[r8+10]
       mov       r10d,[rsp+13C]
       cmp       r10d,[rcx+8]
       jae       near ptr M08_L152
       mov       edx,r10d
       mov       r9,[rcx+rdx*8+10]
       test      r9,r9
       jne       short M08_L119
       mov       rcx,r8
       mov       edx,r10d
       call      qword ptr [7FF9E63AFC30]
       mov       r9,rax
M08_L118:
       mov       rcx,[r9+8]
       mov       [rsp+70],rcx
       call      qword ptr [7FF9E61FF468]; System.Threading.Thread.GetCurrentProcessorNumber()
       mov       ecx,0AAAAAAAB
       mov       edx,eax
       imul      rcx,rdx
       shr       rcx,23
       imul      ecx,0C
       sub       eax,ecx
       xor       edx,edx
       jmp       near ptr M08_L126
M08_L119:
       jmp       short M08_L118
M08_L120:
       cmp       eax,[r8+8]
       jae       near ptr M08_L152
       mov       [rsp+120],eax
       mov       ecx,eax
       mov       r10,[r8+rcx*8+10]
       mov       [rsp+68],r10
       cmp       [r10],r10b
       xor       r9d,r9d
       mov       [rsp+118],r9d
       mov       rcx,r10
       call      qword ptr [7FF9E60EE2B0]; System.Threading.Monitor.Enter(System.Object)
       mov       rax,[rsp+68]
       mov       rcx,[rax+8]
       mov       r8d,[rax+10]
       mov       [rsp+114],r8d
       cmp       [rcx+8],r8d
       jbe       short M08_L122
       test      r8d,r8d
       jne       short M08_L123
       xor       edx,edx
       mov       [rax+14],edx
M08_L121:
       movsxd    rdx,r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,[rsp+78]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rsp+114]
       inc       ecx
       mov       rax,[rsp+68]
       mov       [rax+10],ecx
       mov       dword ptr [rsp+118],1
M08_L122:
       mov       rcx,rax
       call      qword ptr [7FF9E5BC6820]; System.Threading.Monitor.Exit(System.Object)
       cmp       dword ptr [rsp+118],0
       je        short M08_L124
       jmp       short M08_L127
M08_L123:
       jmp       short M08_L121
M08_L124:
       mov       eax,[rsp+120]
       inc       eax
       mov       ecx,eax
       mov       r8,[rsp+70]
       cmp       [r8+8],ecx
       jne       short M08_L125
       xor       ecx,ecx
M08_L125:
       mov       edx,[rsp+11C]
       inc       edx
       mov       eax,ecx
M08_L126:
       mov       r8,[rsp+70]
       mov       [rsp+11C],edx
       cmp       [r8+8],edx
       jg        near ptr M08_L120
       jmp       short M08_L128
M08_L127:
       mov       edx,1
       jmp       short M08_L129
M08_L128:
       xor       edx,edx
M08_L129:
       mov       eax,edx
       mov       [rsp+134],eax
       mov       rax,[rsp+98]
       mov       ecx,[rsp+138]
       mov       r10d,[rsp+13C]
       jmp       near ptr M08_L28
M08_L130:
       mov       r8,[rsp+0A8]
       cmp       dword ptr [r8+8],0
       mov       [rsp+138],ecx
       je        near ptr M08_L29
       mov       rcx,r8
       call      qword ptr [7FF9E5FED740]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+130],eax
       mov       rdx,[rsp+0A8]
       mov       r8d,[rdx+8]
       mov       [rsp+12C],r8d
       mov       rcx,[rsp+90]
       call      qword ptr [7FF9E5FED740]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,[rsp+88]
       mov       r8d,[rsp+130]
       mov       r9d,[rsp+12C]
       mov       edx,3
       call      qword ptr [7FF9E63AF858]
       mov       eax,[rsp+138]
       test      [rsp+134],eax
       jne       short M08_L131
       mov       rcx,[rsp+0A8]
       call      qword ptr [7FF9E5FED740]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+128],eax
       mov       rcx,[rsp+0A8]
       mov       edx,[rcx+8]
       mov       [rsp+124],edx
       mov       rcx,[rsp+90]
       call      qword ptr [7FF9E5FED740]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       cmp       dword ptr [rsp+138],0
       jne       short M08_L132
       mov       ecx,0FFFFFFFF
       mov       edx,1
       jmp       short M08_L133
M08_L131:
       mov       rax,[rsp+98]
       jmp       near ptr M08_L29
M08_L132:
       mov       ecx,[rsp+13C]
       xor       edx,edx
M08_L133:
       mov       [rsp+20],ecx
       mov       [rsp+28],edx
       mov       rcx,[rsp+88]
       mov       edx,[rsp+128]
       mov       r8d,[rsp+124]
       call      qword ptr [7FF9E61FEF10]
       mov       rax,[rsp+98]
       jmp       near ptr M08_L29
M08_L134:
       mov       ecx,2
       call      qword ptr [7FF9E5BCFD50]
       int       3
M08_L135:
       mov       rcx,r12
       call      qword ptr [7FF9E616F420]; System.Buffers.SharedArrayPool`1[[System.Int32, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
       jmp       near ptr M08_L32
M08_L136:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9E61FEE98]
       mov       r12,rax
       mov       ecx,29B
       mov       rdx,7FF9E5B04000
       call      qword ptr [7FF9E5BCF228]
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,rbx
       call      qword ptr [7FF9E5F37D50]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M08_L137:
       mov       rcx,[r12+10]
       cmp       edi,[rcx+8]
       jae       near ptr M08_L152
       mov       edx,edi
       mov       rax,[rcx+rdx*8+10]
       test      rax,rax
       jne       short M08_L138
       mov       rcx,r12
       mov       edx,edi
       call      qword ptr [7FF9E63AFC30]
M08_L138:
       mov       r14,[rax+8]
       call      qword ptr [7FF9E61FF468]; System.Threading.Thread.GetCurrentProcessorNumber()
       mov       ecx,0AAAAAAAB
       mov       edx,eax
       imul      rcx,rdx
       shr       rcx,23
       imul      ecx,0C
       mov       r15d,eax
       sub       r15d,ecx
       xor       eax,eax
       jmp       near ptr M08_L145
M08_L139:
       cmp       r15d,[r14+8]
       jae       near ptr M08_L152
       mov       ecx,r15d
       mov       rdx,[r14+rcx*8+10]
       mov       [rsp+60],rdx
       cmp       [rdx],dl
       xor       r8d,r8d
       mov       [rsp+108],r8d
       mov       rcx,rdx
       call      qword ptr [7FF9E60EE2B0]; System.Threading.Monitor.Enter(System.Object)
       mov       rax,[rsp+60]
       mov       rcx,[rax+8]
       mov       r8d,[rax+10]
       mov       [rsp+104],r8d
       cmp       [rcx+8],r8d
       jbe       short M08_L141
       test      r8d,r8d
       jne       short M08_L142
       xor       edx,edx
       mov       [rax+14],edx
M08_L140:
       movsxd    rdx,r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rsp+104]
       inc       ecx
       mov       rax,[rsp+60]
       mov       [rax+10],ecx
       mov       dword ptr [rsp+108],1
M08_L141:
       mov       rcx,rax
       call      qword ptr [7FF9E5BC6820]; System.Threading.Monitor.Exit(System.Object)
       cmp       dword ptr [rsp+108],0
       je        short M08_L143
       jmp       short M08_L146
M08_L142:
       jmp       short M08_L140
M08_L143:
       inc       r15d
       cmp       [r14+8],r15d
       jne       short M08_L144
       xor       r15d,r15d
M08_L144:
       mov       eax,[rsp+10C]
       inc       eax
M08_L145:
       mov       [rsp+10C],eax
       cmp       [r14+8],eax
       jg        near ptr M08_L139
       jmp       short M08_L147
M08_L146:
       mov       r14d,1
       jmp       short M08_L148
M08_L147:
       xor       r14d,r14d
M08_L148:
       jmp       near ptr M08_L33
M08_L149:
       cmp       dword ptr [rbx+8],0
       je        near ptr M08_L34
       mov       rcx,rbx
       call      qword ptr [7FF9E5FED740]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r13d,eax
       mov       eax,[rbx+8]
       mov       [rsp+110],eax
       mov       rcx,r12
       call      qword ptr [7FF9E5FED740]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,r15
       mov       r8d,r13d
       mov       r9d,[rsp+110]
       mov       edx,3
       call      qword ptr [7FF9E63AF858]
       test      r14d,ebp
       jne       near ptr M08_L34
       mov       rcx,rbx
       call      qword ptr [7FF9E5FED740]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r14d,eax
       mov       ebx,[rbx+8]
       mov       rcx,r12
       call      qword ptr [7FF9E5FED740]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       test      ebp,ebp
       jne       short M08_L150
       mov       ecx,0FFFFFFFF
       mov       edx,1
       jmp       short M08_L151
M08_L150:
       mov       ecx,edi
       xor       edx,edx
M08_L151:
       mov       [rsp+20],ecx
       mov       [rsp+28],edx
       mov       rcx,r15
       mov       edx,r14d
       mov       r8d,ebx
       call      qword ptr [7FF9E61FEF10]
       jmp       near ptr M08_L34
M08_L152:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 6131
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
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       test      rbx,rbx
       je        near ptr M10_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M10_L01
       test      rsi,rsi
       je        short M10_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M10_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M10_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFA45879D30
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF9E5BC5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF9E5BC5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
M10_L00:
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
M10_L01:
       test      rsi,rsi
       je        short M10_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M10_L03
M10_L02:
       mov       rax,1C167770008
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M10_L03:
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
M10_L04:
       call      qword ptr [7FF9E63AF570]
       int       3
; Total bytes of code 244
```
```assembly
; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].get_Comparer()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       rcx,[rbx]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rdx,offset MT_System.String
       cmp       [rcx],rdx
       je        short M11_L01
       mov       rax,[rbx+18]
       test      rax,rax
       je        short M11_L04
M11_L00:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M11_L01:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rsi,[rdx+0A0]
       test      rsi,rsi
       je        short M11_L02
       jmp       short M11_L03
M11_L02:
       mov       rdx,7FF9E643B950
       call      qword ptr [7FF9E5BCF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rsi,rax
M11_L03:
       mov       rdx,[rbx+18]
       mov       rcx,offset MT_System.Collections.Generic.IEqualityComparer<System.String>
       call      qword ptr [7FF9E5BC58D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rcx,rax
       call      qword ptr [7FF9E63AFC48]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9E5BC58D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M11_L04:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+0A8]
       test      rdx,rdx
       je        short M11_L05
       jmp       short M11_L06
M11_L05:
       mov       rdx,7FF9E643B960
       call      qword ptr [7FF9E5BCF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M11_L06:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rax]
       jmp       near ptr M11_L00
; Total bytes of code 206
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M12_L00
       ret
M12_L00:
       jmp       qword ptr [7FF9E5BC5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.ToFrozenSet()
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
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-70],xmm4
       xor       eax,eax
       mov       [rbp-60],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       test      rsi,rsi
       je        near ptr M00_L44
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L46
       mov       rcx,[rsi+8]
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],r11
       jne       near ptr M00_L45
       mov       edi,[rcx+10]
M00_L00:
       test      edi,edi
       je        near ptr M00_L59
       mov       rdx,23DE0002A18
       mov       rdi,[rdx]
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Frozen.FrozenSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r14,rax
       test      r14,r14
       jne       near ptr M00_L47
M00_L01:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Generic.HashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r14,rax
       mov       r15,r14
       test      r15,r15
       jne       near ptr M00_L48
M00_L02:
       mov       rcx,offset MT_System.Collections.Generic.HashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       lea       rcx,[r15+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       test      r14,r14
       jne       near ptr M00_L49
M00_L03:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L51
       mov       rcx,[rsi+8]
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],r11
       jne       near ptr M00_L50
       mov       ecx,[rcx+10]
M00_L04:
       test      ecx,ecx
       jle       short M00_L05
       call      qword ptr [7FF9E5BE5A88]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       r14d,eax
       movsxd    rdx,r14d
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r13,rax
       movsxd    rdx,r14d
       mov       rcx,offset MT_System.Collections.Generic.HashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Entry[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r12,rax
       mov       dword ptr [r15+2C],0FFFFFFFF
       lea       rcx,[r15+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,r14d
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [r15+20],rax
M00_L05:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L54
       mov       rsi,[rsi+8]
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L53
       cmp       dword ptr [rsi+10],0
       je        near ptr M00_L52
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       r13d,[rsi+14]
       lea       rcx,[r14+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r14+10],rcx
       mov       [r14+18],r13d
       mov       [r14+1C],ecx
M00_L06:
       mov       [rbp-78],r14
M00_L07:
       mov       rdx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rcx,[rbp-78]
       cmp       [rcx],rdx
       jne       near ptr M00_L36
       mov       rdx,[rcx]
       add       rcx,8
       call      qword ptr [7FF9E5E7C150]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L08:
       test      eax,eax
       je        near ptr M00_L39
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-78]
       cmp       [rax],rcx
       jne       near ptr M00_L24
       mov       rsi,[rax+10]
M00_L09:
       cmp       qword ptr [r15+8],0
       je        near ptr M00_L25
M00_L10:
       mov       r14,[r15+10]
       mov       r13,[r15+18]
       xor       r12d,r12d
       test      rsi,rsi
       je        near ptr M00_L20
       mov       rcx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r13],rcx
       jne       near ptr M00_L32
       mov       rdx,[rsi+28]
       test      rdx,rdx
       je        near ptr M00_L26
       mov       rcx,23DE0000068
       mov       rcx,[rcx]
       mov       r8,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],r8
       jne       near ptr M00_L31
       lea       rcx,[rdx+0C]
       mov       r8d,[rdx+8]
       add       r8d,r8d
       mov       [rbp-44],r8d
       mov       dword ptr [rbp-50],7E4C50C3
       mov       dword ptr [rbp-58],9CD1DC9D
       cmp       r8d,8
       jb        near ptr M00_L18
       mov       edx,r8d
       shr       edx,3
       xchg      ax,ax
M00_L11:
       mov       r10d,[rbp-50]
       add       r10d,[rcx]
       mov       [rbp-50],r10d
       mov       r10d,[rcx+4]
       mov       r9d,[rbp-50]
       mov       r11d,[rbp-58]
       xor       r11d,r9d
       rol       r9d,14
       add       r9d,r11d
       rol       r11d,9
       xor       r11d,r9d
       rol       r9d,1B
       add       r9d,r11d
       rol       r11d,13
       mov       [rbp-50],r9d
       mov       [rbp-58],r11d
       add       r10d,[rbp-50]
       mov       [rbp-50],r10d
       mov       r10d,[rbp-50]
       mov       r9d,[rbp-58]
       xor       r9d,r10d
       rol       r10d,14
       add       r10d,r9d
       rol       r9d,9
       xor       r9d,r10d
       rol       r10d,1B
       add       r10d,r9d
       rol       r9d,13
       mov       [rbp-50],r10d
       mov       [rbp-58],r9d
       add       rcx,8
       dec       edx
       jne       short M00_L11
       test      r8b,4
       jne       near ptr M00_L27
M00_L12:
       mov       edx,r8d
       and       rdx,7
       mov       ecx,[rcx+rdx-4]
       shr       ecx,8
       or        ecx,80000000
       not       r8d
       shl       r8d,3
       shrx      ecx,ecx,r8d
M00_L13:
       add       ecx,[rbp-50]
       mov       [rbp-50],ecx
       lea       rcx,[rbp-50]
       lea       rdx,[rbp-58]
       call      qword ptr [7FF9E6485338]; System.Marvin.Block(UInt32 ByRef, UInt32 ByRef)
       lea       rcx,[rbp-50]
       lea       rdx,[rbp-58]
       call      qword ptr [7FF9E6485338]; System.Marvin.Block(UInt32 ByRef, UInt32 ByRef)
       mov       eax,[rbp-58]
       xor       eax,[rbp-50]
M00_L14:
       mov       [rbp-3C],eax
       mov       rdx,[r15+8]
       mov       ecx,eax
       imul      rcx,[r15+20]
       shr       rcx,20
       inc       rcx
       mov       r8d,[rdx+8]
       mov       r11d,r8d
       imul      rcx,r11
       shr       rcx,20
       cmp       ecx,r8d
       jae       near ptr M00_L38
       mov       ecx,ecx
       lea       r10,[rdx+rcx*4+10]
       mov       [rbp-88],r10
       mov       r9d,[r10]
       dec       r9d
       jns       near ptr M00_L21
M00_L15:
       cmp       dword ptr [r15+30],0
       jg        near ptr M00_L23
       mov       edx,[r15+28]
       mov       [rbp-40],edx
       cmp       [r14+8],edx
       je        near ptr M00_L34
M00_L16:
       mov       edx,[rbp-40]
       mov       r14d,edx
       lea       ecx,[r14+1]
       mov       [r15+28],ecx
       mov       rcx,[r15+10]
       mov       r8,rcx
M00_L17:
       cmp       r14d,[r8+8]
       jae       near ptr M00_L38
       mov       ecx,r14d
       shl       rcx,4
       mov       [rbp-80],r8
       lea       rcx,[r8+rcx+10]
       mov       [rcx+8],eax
       mov       r10,[rbp-88]
       mov       edx,[r10]
       dec       edx
       mov       [rcx+0C],edx
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       inc       r14d
       mov       rdx,[rbp-88]
       mov       [rdx],r14d
       inc       dword ptr [r15+34]
       cmp       r12d,64
       jbe       near ptr M00_L07
       jmp       near ptr M00_L35
M00_L18:
       cmp       r8d,4
       jb        near ptr M00_L28
M00_L19:
       mov       edx,[rbp-50]
       mov       [rbp-98],rcx
       add       edx,[rcx]
       mov       [rbp-50],edx
       lea       rcx,[rbp-50]
       lea       rdx,[rbp-58]
       call      qword ptr [7FF9E6485338]; System.Marvin.Block(UInt32 ByRef, UInt32 ByRef)
       mov       rax,[rbp-78]
       mov       rcx,[rbp-98]
       mov       r8d,[rbp-44]
       jmp       near ptr M00_L12
M00_L20:
       xor       edx,edx
       xor       r10d,r10d
       mov       eax,r10d
       jmp       near ptr M00_L14
M00_L21:
       cmp       r9d,[r14+8]
       jae       near ptr M00_L38
       mov       edx,r9d
       shl       rdx,4
       lea       r9,[r14+rdx+10]
       mov       [rbp-90],r9
       cmp       [r9+8],eax
       je        near ptr M00_L33
M00_L22:
       mov       r9d,[r9+0C]
       inc       r12d
       cmp       [r14+8],r12d
       jb        near ptr M00_L37
       test      r9d,r9d
       mov       eax,[rbp-3C]
       jge       short M00_L21
       jmp       near ptr M00_L15
M00_L23:
       mov       ecx,[r15+2C]
       mov       r8d,ecx
       dec       dword ptr [r15+30]
       cmp       ecx,[r14+8]
       jae       near ptr M00_L38
       shl       rcx,4
       mov       ecx,[r14+rcx+1C]
       neg       ecx
       add       ecx,0FFFFFFFD
       mov       [r15+2C],ecx
       mov       ecx,r8d
       mov       r8,r14
       mov       r14d,ecx
       jmp       near ptr M00_L17
M00_L24:
       mov       rcx,rax
       mov       r11,7FF9E5B30EB8
       call      qword ptr [r11]
       mov       rsi,rax
       mov       rax,[rbp-78]
       jmp       near ptr M00_L09
M00_L25:
       mov       rcx,r15
       xor       edx,edx
       call      qword ptr [7FF9E5DB7750]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       mov       rax,[rbp-78]
       jmp       near ptr M00_L10
M00_L26:
       xor       ecx,ecx
       mov       eax,ecx
       jmp       near ptr M00_L14
M00_L27:
       jmp       near ptr M00_L19
M00_L28:
       mov       r8d,[rbp-44]
       mov       edx,80
       test      r8b,1
       je        short M00_L29
       mov       edx,r8d
       and       rdx,2
       movzx     edx,byte ptr [rcx+rdx]
       or        edx,8000
M00_L29:
       test      r8b,2
       je        short M00_L30
       shl       edx,10
       movzx     ecx,word ptr [rcx]
       or        edx,ecx
       mov       ecx,edx
       jmp       near ptr M00_L13
M00_L30:
       mov       ecx,edx
       jmp       near ptr M00_L13
M00_L31:
       mov       r8,[rcx]
       mov       r8,[r8+48]
       call      qword ptr [r8+18]
       jmp       near ptr M00_L14
M00_L32:
       mov       rcx,r13
       mov       rdx,rsi
       mov       r11,7FF9E5B30ED0
       call      qword ptr [r11]
       jmp       near ptr M00_L14
M00_L33:
       mov       rdx,[r9]
       mov       rcx,r13
       mov       r8,rsi
       mov       r11,7FF9E5B30ED8
       call      qword ptr [r11]
       test      eax,eax
       mov       r9,[rbp-90]
       jne       near ptr M00_L07
       jmp       near ptr M00_L22
M00_L34:
       mov       rcx,r15
       call      qword ptr [7FF9E63CFAC8]
       mov       rcx,[r15+8]
       mov       r14d,[rbp-3C]
       mov       edx,r14d
       imul      rdx,[r15+20]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       imul      rdx,rax
       shr       rdx,20
       cmp       edx,[rcx+8]
       jae       short M00_L38
       mov       edx,edx
       lea       r10,[rcx+rdx*4+10]
       mov       rax,r10
       mov       [rbp-88],rax
       mov       eax,r14d
       jmp       near ptr M00_L16
M00_L35:
       mov       r14,[rbp-80]
       mov       rdx,r13
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M00_L07
       mov       edx,[r14+8]
       mov       rcx,r15
       mov       r8d,1
       call      qword ptr [7FF9E5F5D980]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,r15
       mov       rdx,rsi
       call      qword ptr [7FF9E5DB7810]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       jmp       near ptr M00_L07
M00_L36:
       mov       r11,7FF9E5B30EB0
       call      qword ptr [r11]
       jmp       near ptr M00_L08
M00_L37:
       call      qword ptr [7FF9E5BEF498]
       int       3
M00_L38:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L39:
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-78]
       cmp       [rax],rcx
       jne       near ptr M00_L55
M00_L40:
       mov       ecx,[r15+28]
       test      ecx,ecx
       jle       short M00_L41
       mov       rax,[r15+10]
       mov       eax,[rax+8]
       cdq
       idiv      ecx
       cmp       eax,3
       jg        near ptr M00_L56
M00_L41:
       mov       ecx,[r15+28]
       sub       ecx,[r15+30]
       je        near ptr M00_L57
       xor       esi,esi
M00_L42:
       test      rsi,rsi
       jne       short M00_L43
       mov       rdx,r15
       mov       rcx,7FF9E63F06D0
       call      qword ptr [7FF9E63C58A8]; System.Collections.Frozen.FrozenSet.CreateFromSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
       mov       rsi,rax
M00_L43:
       mov       [rbp-60],rsi
       mov       rcx,[rbx+60]
       lea       r8,[rbp-60]
       mov       rdx,7FF9E63FB440
       cmp       [rcx],ecx
       call      qword ptr [7FF9E63C6BC8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
M00_L44:
       call      qword ptr [7FF9E618EFA0]
       mov       ecx,65
       mov       rdx,7FF9E5FE8D68
       call      qword ptr [7FF9E5BEF228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF9E5EB5AC0
       call      qword ptr [7FF9E5BEF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9E5BED9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9E5FE8D68
       call      qword ptr [7FF9E5BEF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9E5BED9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9E63CD5D8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9E63CD5F0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L45:
       mov       r11,7FF9E5B30E90
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L00
M00_L46:
       mov       rcx,rsi
       mov       r11,7FF9E5B30E88
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L00
M00_L47:
       mov       rcx,[r14+8]
       mov       rdx,rdi
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       test      eax,eax
       je        near ptr M00_L01
       xor       r15d,r15d
       mov       rsi,r14
       jmp       near ptr M00_L42
M00_L48:
       mov       ecx,[r15+28]
       sub       ecx,[r15+30]
       je        near ptr M00_L41
       mov       rcx,r15
       call      qword ptr [7FF9E63C6238]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].get_Comparer()
       mov       rcx,rax
       mov       rdx,rdi
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       test      eax,eax
       jne       near ptr M00_L41
       jmp       near ptr M00_L02
M00_L49:
       mov       r8,r14
       mov       rdx,r15
       mov       rcx,offset MT_System.Collections.Generic.HashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FF9E6485278]
       test      eax,eax
       je        near ptr M00_L03
       mov       rcx,r15
       mov       rdx,r14
       call      qword ptr [7FF9E63CFC18]
       jmp       near ptr M00_L41
M00_L50:
       mov       r11,7FF9E5B30EA0
       call      qword ptr [r11]
       mov       ecx,eax
       jmp       near ptr M00_L04
M00_L51:
       mov       rcx,rsi
       mov       r11,7FF9E5B30E98
       call      qword ptr [r11]
       mov       ecx,eax
       jmp       near ptr M00_L04
M00_L52:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,23DE0002AC0
       mov       r14,[rcx]
       jmp       near ptr M00_L06
M00_L53:
       mov       rcx,rsi
       mov       r11,7FF9E5B30EC8
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L06
M00_L54:
       mov       rcx,rsi
       mov       r11,7FF9E5B30EA8
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L06
M00_L55:
       mov       rcx,rax
       mov       r11,7FF9E5B30EC0
       call      qword ptr [r11]
       jmp       near ptr M00_L40
M00_L56:
       mov       edx,ecx
       sub       edx,[r15+30]
       mov       rcx,r15
       call      qword ptr [7FF9E63CFC30]
       jmp       near ptr M00_L41
M00_L57:
       mov       rcx,offset MT_System.Collections.Frozen.FrozenSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,23DE0002AC8
       mov       rcx,[rcx]
       cmp       rdi,[rcx+8]
       je        short M00_L58
       mov       rcx,offset MT_System.Collections.Frozen.EmptyFrozenSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L42
M00_L58:
       mov       rcx,offset MT_System.Collections.Frozen.FrozenSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,23DE0002AC8
       mov       rsi,[rdx]
       jmp       near ptr M00_L42
M00_L59:
       xor       r8d,r8d
       mov       [rbp-70],r8
       mov       [rbp-68],r8d
       lea       r8,[rbp-70]
       mov       rcx,7FF9E64BA828
       xor       edx,edx
       call      qword ptr [7FF9E64852D8]
       mov       rsi,rax
       jmp       near ptr M00_L43
       sub       rsp,28
       cmp       qword ptr [rbp-78],0
       je        short M00_L60
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-78]
       cmp       [rax],rcx
       je        short M00_L60
       mov       rcx,rax
       mov       r11,7FF9E5B30EC0
       call      qword ptr [r11]
M00_L60:
       nop
       add       rsp,28
       ret
; Total bytes of code 2510
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
       mov       rcx,7FF9ED480B08
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
       call      qword ptr [7FF9E63CEA18]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9E5F55E60]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M02_L03:
       mov       esi,ebx
       or        esi,1
       jmp       short M02_L06
M02_L04:
       mov       ecx,esi
       call      qword ptr [7FF9E63CEA30]
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
; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx]
       mov       rdx,rcx
       mov       eax,[rbx+10]
       cmp       eax,[rcx+14]
       jne       short M03_L00
       mov       ecx,[rbx+14]
       cmp       ecx,[rdx+10]
       jae       short M03_L01
       mov       rdx,[rdx+8]
       cmp       ecx,[rdx+8]
       jae       short M03_L02
       mov       ecx,ecx
       mov       rdx,[rdx+rcx*8+10]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       dword ptr [rbx+14]
       mov       eax,1
       add       rsp,20
       pop       rbx
       ret
M03_L00:
       call      qword ptr [7FF9E5BEFC60]
       int       3
M03_L01:
       xor       eax,eax
       mov       [rbx+8],rax
       mov       dword ptr [rbx+14],0FFFFFFFF
       add       rsp,20
       pop       rbx
       ret
M03_L02:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 101
```
```assembly
; System.Marvin.Block(UInt32 ByRef, UInt32 ByRef)
       mov       eax,[rcx]
       mov       r8d,eax
       xor       r8d,[rdx]
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       mov       [rcx],eax
       mov       [rdx],r8d
       ret
; Total bytes of code 37
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
       call      qword ptr [7FF9E5BE5A88]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       esi,eax
       movsxd    rdx,esi
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rdi,rax
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+0B0]
       test      rax,rax
       je        short M05_L01
       mov       rcx,rax
M05_L00:
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
M05_L01:
       mov       rdx,7FF9E645C880
       call      qword ptr [7FF9E5BEF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M05_L00
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
       call      qword ptr [7FF9EE0E7EC8]
       mov       rcx,rax
       movsxd    rdx,esi
       call      qword ptr [7FF9EE0E4088]; CORINFO_HELP_NEWARR_1_DIRECT
       mov       rbp,rax
       mov       r14d,[rbx+28]
       mov       rcx,[rbx+10]
       mov       rdx,rbp
       mov       r8d,r14d
       call      qword ptr [7FF9EE0F52F0]; Precode of System.Array.Copy(System.Array, System.Array, Int32)
       movzx     ecx,dil
       test      cl,1
       jne       near ptr M06_L06
M06_L00:
       movsxd    rcx,esi
       call      qword ptr [7FF9EE0F1B50]
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      qword ptr [7FF9EE0E3FE8]; CORINFO_HELP_ASSIGN_REF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,esi
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rbx+20],rax
       xor       ecx,ecx
       test      r14d,r14d
       jle       short M06_L03
       cmp       [rbp+8],r14d
       jl        near ptr M06_L04
M06_L01:
       mov       edx,ecx
       shl       rdx,4
       lea       rdx,[rbp+rdx+10]
       cmp       dword ptr [rdx+0C],0FFFFFFFF
       jl        short M06_L02
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
       jae       near ptr M06_L11
       mov       r10d,r10d
       lea       rax,[r8+r10*4+10]
       mov       r8d,[rax]
       dec       r8d
       mov       [rdx+0C],r8d
       lea       edx,[rcx+1]
       mov       [rax],edx
M06_L02:
       inc       ecx
       cmp       ecx,r14d
       jl        short M06_L01
M06_L03:
       lea       rcx,[rbx+10]
       mov       rdx,rbp
       call      qword ptr [7FF9EE0E3FE8]; CORINFO_HELP_ASSIGN_REF
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
M06_L04:
       cmp       ecx,[rbp+8]
       jae       near ptr M06_L11
       mov       eax,ecx
       shl       rax,4
       lea       rdx,[rbp+rax+10]
       cmp       dword ptr [rdx+0C],0FFFFFFFF
       jl        short M06_L05
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
       jae       near ptr M06_L11
       mov       eax,r10d
       lea       rax,[r8+rax*4+10]
       mov       r8d,[rax]
       dec       r8d
       mov       [rdx+0C],r8d
       lea       edx,[rcx+1]
       mov       [rax],edx
M06_L05:
       inc       ecx
       cmp       ecx,r14d
       jl        short M06_L04
       jmp       near ptr M06_L03
M06_L06:
       mov       rcx,[rbx]
       call      qword ptr [7FF9EE0E74F8]
       mov       rdi,rax
       mov       rcx,[rbx+18]
       call      qword ptr [7FF9EE0F3730]
       mov       rcx,rax
       lea       r11,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       [rcx],ecx
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF9EE0E4090]; Precode of System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdi,rax
       lea       rcx,[rbx+18]
       mov       rdx,rdi
       call      qword ptr [7FF9EE0E3FE8]; CORINFO_HELP_ASSIGN_REF
       xor       r15d,r15d
       cmp       r15d,r14d
       jge       near ptr M06_L00
M06_L07:
       cmp       r15d,[rbp+8]
       jae       short M06_L11
       mov       rcx,r15
       shl       rcx,4
       lea       r13,[rbp+rcx+10]
       cmp       dword ptr [r13+0C],0FFFFFFFF
       jl        short M06_L10
       cmp       qword ptr [r13],0
       jne       short M06_L08
       xor       r12d,r12d
       jmp       short M06_L09
M06_L08:
       mov       rcx,[rbx]
       call      qword ptr [7FF9EE0E9150]
       mov       rdx,[r13]
       mov       rcx,rdi
       mov       r11,rax
       call      qword ptr [rax]
       mov       r12d,eax
M06_L09:
       mov       [r13+8],r12d
M06_L10:
       inc       r15d
       cmp       r15d,r14d
       jl        short M06_L07
       jmp       near ptr M06_L00
M06_L11:
       call      qword ptr [7FF9EE0E3FD8]
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
       je        near ptr M07_L07
       mov       rdi,[rbx+10]
       xor       ebp,ebp
       mov       r14,[rbx+18]
       test      rsi,rsi
       je        near ptr M07_L11
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+78]
       test      r11,r11
       je        near ptr M07_L08
M07_L00:
       mov       rcx,offset MT_System.Collections.Generic.ObjectEqualityComparer<System.RuntimeType>
       cmp       [r14],rcx
       jne       near ptr M07_L13
       mov       [rsp+38],rsi
       xor       ecx,ecx
       mov       [rsp+30],rcx
       lea       rcx,[rsp+38]
       cmp       qword ptr [rsp+30],0
       jne       short M07_L01
       mov       rcx,[rsp+38]
       mov       [rsp+30],rcx
       lea       rcx,[rsp+30]
       cmp       qword ptr [rsp+30],0
       je        near ptr M07_L12
M07_L01:
       mov       r15,[rcx]
       mov       rcx,offset MT_System.RuntimeType
       cmp       [r15],rcx
       jne       near ptr M07_L10
       mov       rcx,r15
       call      00007FFA45809590
       test      eax,eax
       je        near ptr M07_L09
M07_L02:
       mov       r15d,eax
M07_L03:
       xor       ecx,ecx
       mov       [rsp+30],rcx
M07_L04:
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
       jae       near ptr M07_L18
       mov       edx,edx
       lea       rcx,[rcx+rdx*4+10]
       mov       r13d,[rcx]
       dec       r13d
       js        short M07_L07
M07_L05:
       mov       r12d,[rdi+8]
       cmp       r13d,r12d
       jae       near ptr M07_L18
       mov       ecx,r13d
       shl       rcx,4
       lea       rax,[rdi+rcx+10]
       mov       [rsp+28],rax
       cmp       [rax+8],r15d
       je        near ptr M07_L14
M07_L06:
       mov       rax,[rsp+28]
       mov       r13d,[rax+0C]
       inc       ebp
       cmp       r12d,ebp
       jb        near ptr M07_L17
       test      r13d,r13d
       jge       short M07_L05
M07_L07:
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
M07_L08:
       mov       rdx,7FF9E64563F8
       call      qword ptr [7FF9E5BEF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M07_L00
M07_L09:
       mov       rcx,r15
       call      qword ptr [7FF9E5DB77F8]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       jmp       near ptr M07_L02
M07_L10:
       mov       rcx,r15
       mov       rax,[r15]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
       mov       r15d,eax
       jmp       near ptr M07_L03
M07_L11:
       xor       r15d,r15d
       jmp       near ptr M07_L04
M07_L12:
       xor       r15d,r15d
       jmp       near ptr M07_L03
M07_L13:
       mov       rcx,r14
       mov       rdx,rsi
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       near ptr M07_L04
M07_L14:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+80]
       test      r11,r11
       je        short M07_L15
       jmp       short M07_L16
M07_L15:
       mov       rdx,7FF9E6456410
       call      qword ptr [7FF9E5BEF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M07_L16:
       mov       rax,[rsp+28]
       mov       rdx,[rax]
       mov       rcx,r14
       mov       r8,rsi
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M07_L06
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
M07_L17:
       call      qword ptr [7FF9E5BEF498]
       int       3
M07_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 547
```
```assembly
; System.Collections.Frozen.FrozenSet.CreateFromSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,188
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+0D0],ymm4
       mov       [rsp+180],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rcx,[rbx]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rdx,offset MT_System.String
       cmp       [rcx],rdx
       je        near ptr M08_L53
       mov       rdi,[rbx+18]
       test      rdi,rdi
       je        near ptr M08_L56
M08_L00:
       mov       rcx,[rsi+18]
       mov       rdx,offset MT_System.String
       cmp       [rcx],rdx
       je        near ptr M08_L59
M08_L01:
       mov       ecx,[rbx+28]
       sub       ecx,[rbx+30]
       cmp       ecx,4
       jle       near ptr M08_L88
       mov       rcx,[rsi+18]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        near ptr M08_L39
M08_L02:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,[rbx]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rdx,offset MT_System.String
       cmp       [rcx],rdx
       je        near ptr M08_L91
       mov       rdx,[rbx+18]
       test      rdx,rdx
       je        near ptr M08_L94
M08_L03:
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+10],rcx
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx+8]
       mov       rax,[rdx+20]
       test      rax,rax
       je        near ptr M08_L40
M08_L04:
       lea       rcx,[rsi+10]
       mov       rdx,rsi
       call      rax
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx+10]
       mov       rdi,[rdx+28]
       test      rdi,rdi
       je        near ptr M08_L41
M08_L05:
       mov       rcx,rdi
       mov       ebp,[rbx+28]
       sub       ebp,[rbx+30]
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       xor       r15d,r15d
       mov       r13d,ebp
       test      r13d,r13d
       jl        near ptr M08_L97
       mov       r12,[rbx+10]
       xor       eax,eax
       cmp       dword ptr [rbx+28],0
       jg        near ptr M08_L52
M08_L06:
       mov       rcx,rdi
       mov       edx,ebp
       call      CORINFO_HELP_NEWARR_1_PTR
       lea       rcx,[rsi+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,23DE0001D88
       mov       r13,[rcx]
       mov       [rsp+40],r13
       mov       rcx,r13
       mov       edx,ebp
       call      qword ptr [7FF9E61F6990]; System.Buffers.SharedArrayPool`1[[System.Int32, System.Private.CoreLib]].Rent(Int32)
       mov       rbx,rax
       mov       [rsp+0C0],rbx
       mov       edi,ebp
       test      rbx,rbx
       je        near ptr M08_L98
       cmp       [rbx+8],edi
       jb        near ptr M08_L107
       lea       r15,[rbx+10]
M08_L07:
       xor       r12d,r12d
       cmp       ebp,r12d
       jg        near ptr M08_L49
M08_L08:
       mov       rcx,r15
       mov       r12d,edi
       mov       [rsp+0E0],rcx
       mov       [rsp+0E8],r12d
       lea       rcx,[rsp+0E0]
       xor       edx,edx
       call      qword ptr [7FF9E63C6940]; System.Collections.Frozen.FrozenHashTable.CalcNumBuckets(System.ReadOnlySpan`1<Int32>, Boolean)
       mov       r8d,eax
       mov       [rsp+158],r8d
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,r8d
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rsp+150],rax
       mov       rcx,r13
       lea       edx,[r8+r12]
       call      qword ptr [7FF9E61F6990]; System.Buffers.SharedArrayPool`1[[System.Int32, System.Private.CoreLib]].Rent(Int32)
       mov       [rsp+0A8],rax
       test      rax,rax
       je        near ptr M08_L105
       mov       edx,[rsp+158]
       cmp       [rax+8],edx
       jb        near ptr M08_L107
       lea       r8,[rax+10]
       mov       r10d,edx
M08_L09:
       mov       [rsp+58],r8
       mov       [rsp+100],r10d
       test      rax,rax
       je        near ptr M08_L106
       mov       ecx,edx
       mov       r9d,r12d
       add       rcx,r9
       mov       r9d,[rax+8]
       cmp       rcx,r9
       ja        near ptr M08_L107
       mov       edx,edx
       lea       r9,[rax+rdx*4+10]
M08_L10:
       mov       [rsp+50],r9
       mov       [rsp+0FC],r12d
       mov       edx,r10d
       mov       rcx,rdx
       cmp       rcx,8
       jb        near ptr M08_L109
       lea       r11,[rcx*4]
       mov       [rsp+140],r11
       and       r11,0FFFFFFFFFFFFFFC0
       xor       r13d,r13d
       cmp       rcx,10
       jb        short M08_L12
       nop       dword ptr [rax]
M08_L11:
       vpcmpeqd  ymm0,ymm0,ymm0
       vmovups   [r8+r13],ymm0
       vmovups   [r8+r13+20],ymm0
       add       r13,40
       cmp       r13,r11
       jb        short M08_L11
M08_L12:
       mov       r11,[rsp+140]
       test      r11b,20
       jne       near ptr M08_L108
M08_L13:
       vpcmpeqd  ymm0,ymm0,ymm0
       vmovups   [r8+r11-20],ymm0
M08_L14:
       xor       ecx,ecx
       test      edi,edi
       jle       near ptr M08_L112
       cmp       edi,r12d
       jg        near ptr M08_L35
       jmp       short M08_L15
M08_L15:
       mov       r11d,ecx
       mov       r11d,[r15+r11*4]
       mov       r13,[rsp+150]
       imul      r11,r13
       shr       r11,20
       inc       r11
       imul      r11,rdx
       shr       r11,20
       cmp       r11d,r10d
       jae       near ptr M08_L153
       mov       r11d,r11d
       lea       r11,[r8+r11*4]
       mov       ebx,ecx
       mov       eax,[r11]
       mov       [r9+rbx*4],eax
       mov       [r11],ecx
       inc       ecx
       cmp       ecx,edi
       jl        short M08_L15
M08_L16:
       mov       edx,edi
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbx,rax
       mov       [rsp+0A0],rbx
       mov       edx,[rsp+100]
       mov       rcx,offset MT_System.Collections.Frozen.FrozenHashTable+Bucket[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       [rsp+98],rax
       xor       ecx,ecx
       xor       edx,edx
       cmp       dword ptr [rax+8],0
       jle       near ptr M08_L24
       mov       r8d,[rsp+100]
       cmp       [rax+8],r8d
       jg        near ptr M08_L22
       jmp       short M08_L18
M08_L17:
       inc       edx
       cmp       [rax+8],edx
       jle       near ptr M08_L24
M08_L18:
       mov       r8d,edx
       mov       r10,[rsp+58]
       mov       r8d,[r10+r8*4]
       test      r8d,r8d
       jl        short M08_L17
       xor       r9d,r9d
       mov       [rsp+14C],r9d
       mov       r11d,ecx
M08_L19:
       cmp       r8d,edi
       jae       near ptr M08_L153
       mov       r12d,r8d
       lea       r12,[r15+r12*4]
       mov       r13d,[r12]
       cmp       ecx,[rbx+8]
       jae       near ptr M08_L153
       mov       ebx,ecx
       mov       r9,[rsp+0A0]
       mov       [r9+rbx*4+10],r13d
       mov       [r12],ecx
       inc       ecx
       mov       r12d,[rsp+14C]
       inc       r12d
       cmp       r8d,[rsp+0FC]
       jae       near ptr M08_L153
       mov       r8d,r8d
       mov       r13,[rsp+50]
       mov       r8d,[r13+r8*4]
       test      r8d,r8d
       mov       [rsp+14C],r12d
       mov       rbx,[rsp+0A0]
       jge       short M08_L19
       mov       r12d,[rsp+0FC]
       mov       r13,[rsp+150]
       mov       r9d,[rsp+14C]
       lea       r8d,[r11+r9-1]
       mov       r9d,edx
       lea       r9,[rax+r9*8+10]
       mov       [r9],r11d
       mov       [r9+4],r8d
       jmp       near ptr M08_L17
M08_L20:
       cmp       r11d,edi
       jae       near ptr M08_L153
       mov       ebx,r11d
       lea       rbx,[r15+rbx*4]
       mov       r13d,[rbx]
       mov       r8,[rsp+0A0]
       cmp       ecx,[r8+8]
       jae       near ptr M08_L153
       mov       r8d,ecx
       mov       r9,[rsp+0A0]
       mov       [r9+r8*4+10],r13d
       mov       [rbx],ecx
       inc       ecx
       mov       r8d,[rsp+14C]
       inc       r8d
       mov       ebx,[rsp+0FC]
       cmp       r11d,ebx
       jae       near ptr M08_L153
       mov       r11d,r11d
       mov       r13,[rsp+50]
       mov       r11d,[r13+r11*4]
       test      r11d,r11d
       mov       [rsp+14C],r8d
       jge       short M08_L20
       mov       rbx,r9
       mov       r13,[rsp+150]
       mov       r9d,[rsp+14C]
       lea       r9d,[r12+r9-1]
       mov       r11d,edx
       lea       r11,[rax+r11*8+10]
       mov       [r11],r12d
       mov       [r11+4],r9d
       mov       r12d,[rsp+0FC]
M08_L21:
       inc       edx
       cmp       [rax+8],edx
       mov       rax,[rsp+98]
       mov       r8d,[rsp+100]
       jle       short M08_L24
M08_L22:
       cmp       edx,r8d
       jae       near ptr M08_L153
       mov       r11d,edx
       mov       r10,[rsp+58]
       mov       r11d,[r10+r11*4]
       test      r11d,r11d
       jl        short M08_L21
       xor       r9d,r9d
       mov       [rsp+14C],r9d
       mov       r12d,ecx
       jmp       near ptr M08_L20
M08_L23:
       cmp       ebx,edi
       jae       near ptr M08_L153
       mov       ecx,ebx
       mov       r13d,[r15+rcx*4]
       mov       rcx,[rsi+18]
       cmp       ebx,ebp
       jae       near ptr M08_L153
       mov       r8d,ebx
       mov       r8,[r14+r8*8+10]
       movsxd    rdx,r13d
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       inc       ebx
       cmp       ebx,edi
       jl        short M08_L23
       jmp       near ptr M08_L30
M08_L24:
       mov       r12,[rsp+40]
       mov       rdx,r12
       mov       [rsp+90],rdx
       mov       r8,[rsp+0A8]
       test      r8,r8
       je        near ptr M08_L135
       mov       rdx,[rsp+90]
       mov       ecx,[r8+8]
       dec       ecx
       or        ecx,0F
       xor       r10d,r10d
       lzcnt     r10d,ecx
       xor       r10d,1F
       add       r10d,0FFFFFFFD
       mov       [rsp+13C],r10d
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],7
       jle       near ptr M08_L115
       mov       rcx,[rcx+240]
       mov       r9,[rcx+38]
       test      r9,r9
       je        near ptr M08_L114
M08_L25:
       mov       [rsp+48],r9
       mov       r11,[r9+10]
       test      r11,r11
       je        near ptr M08_L116
M08_L26:
       xor       ecx,ecx
       mov       dword ptr [rsp+134],1
       mov       r10d,[rsp+13C]
       cmp       [r11+8],r10d
       jbe       near ptr M08_L27
       mov       dword ptr [rsp+138],1
       mov       edx,10
       shlx      edx,edx,r10d
       mov       r8,[rsp+0A8]
       cmp       [r8+8],edx
       jne       near ptr M08_L117
       mov       edx,r10d
       shl       rdx,4
       lea       r11,[r11+rdx+10]
       mov       [rsp+80],r11
       mov       rdx,[r11]
       mov       [rsp+78],rdx
       mov       rcx,r11
       mov       rdx,r8
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       rdx,[rsp+80]
       mov       [rdx+8],ecx
       cmp       qword ptr [rsp+78],0
       jne       near ptr M08_L118
       mov       rax,[rsp+98]
       mov       ecx,[rsp+138]
       mov       r10d,[rsp+13C]
M08_L27:
       mov       r11,23DE0000C90
       mov       r11,[r11]
       mov       [rsp+38],r11
       mov       rdx,r11
       mov       [rsp+88],rdx
       cmp       byte ptr [rdx+9D],0
       jne       near ptr M08_L131
M08_L28:
       lea       rcx,[rsi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+28]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rsi+30],r13
       xor       ebx,ebx
       test      edi,edi
       jle       short M08_L30
       cmp       ebp,edi
       jl        near ptr M08_L23
       xor       ebx,ebx
M08_L29:
       mov       r13d,[r15+rbx]
       mov       rcx,[rsi+18]
       mov       r8,[r14+rbx*2+10]
       movsxd    rdx,r13d
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       add       rbx,4
       dec       edi
       jne       short M08_L29
M08_L30:
       mov       rbx,[rsp+0C0]
       test      rbx,rbx
       je        near ptr M08_L135
       mov       ecx,[rbx+8]
       dec       ecx
       or        ecx,0F
       xor       edi,edi
       lzcnt     edi,ecx
       xor       edi,1F
       add       edi,0FFFFFFFD
       mov       rbp,[rsp+48]
       mov       rax,[rbp+10]
       test      rax,rax
       je        near ptr M08_L136
M08_L31:
       xor       ebp,ebp
       mov       r14d,1
       cmp       [rax+8],edi
       jbe       short M08_L32
       mov       ebp,1
       mov       ecx,10
       shlx      ecx,ecx,edi
       cmp       [rbx+8],ecx
       jne       near ptr M08_L137
       cmp       edi,[rax+8]
       jae       near ptr M08_L153
       mov       ecx,edi
       shl       rcx,4
       lea       r15,[rax+rcx+10]
       mov       r13,[r15]
       mov       rcx,r15
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r15+8],ecx
       test      r13,r13
       jne       near ptr M08_L138
M08_L32:
       mov       r15,[rsp+38]
       cmp       byte ptr [r15+9D],0
       jne       near ptr M08_L150
M08_L33:
       mov       rax,rsi
       vzeroupper
       add       rsp,188
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M08_L34:
       mov       r8,[rsp+58]
       mov       r9,[rsp+50]
       mov       r10d,[rsp+100]
M08_L35:
       mov       r11d,ecx
       mov       r11d,[r15+r11*4]
       imul      r11,[rsp+150]
       shr       r11,20
       inc       r11
       imul      r11,rdx
       shr       r11,20
       cmp       r11d,r10d
       jae       near ptr M08_L153
       mov       r11d,r11d
       lea       r11,[r8+r11*4]
       cmp       ecx,r12d
       jae       near ptr M08_L153
       mov       ebx,ecx
       mov       [rsp+178],rbx
       mov       ebx,[r11]
       mov       rax,[rsp+178]
       mov       [r9+rax*4],ebx
       mov       [r11],ecx
       inc       ecx
       cmp       ecx,edi
       mov       r12d,[rsp+0FC]
       jl        short M08_L34
       jmp       near ptr M08_L113
M08_L36:
       cmp       edx,4
       jb        near ptr M08_L100
M08_L37:
       add       eax,[rcx]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       jmp       near ptr M08_L45
M08_L38:
       mov       r10,rax
       xor       eax,eax
       jmp       near ptr M08_L48
M08_L39:
       mov       rcx,rsi
       mov       rdx,7FF9E645E318
       call      qword ptr [7FF9E5BEF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M08_L02
M08_L40:
       mov       rdx,7FF9E645FD40
       call      qword ptr [7FF9E5BEF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M08_L04
M08_L41:
       mov       rdx,7FF9E645FC68
       call      qword ptr [7FF9E5BEF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M08_L05
M08_L42:
       mov       rdx,7FF9E645FC70
       call      qword ptr [7FF9E5BEF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M08_L43:
       mov       rcx,[rsi+8]
       mov       rdx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rdx
       jne       near ptr M08_L104
       mov       r8,[rsp+0B8]
       mov       rdx,[r8+28]
       test      rdx,rdx
       je        near ptr M08_L99
       mov       rcx,23DE0000068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M08_L103
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,7E4C50C3
       mov       r8d,9CD1DC9D
       cmp       edx,8
       jb        near ptr M08_L36
       mov       r9d,edx
       shr       r9d,3
M08_L44:
       add       eax,[rcx]
       mov       r11d,[rcx+4]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       add       r11d,eax
       mov       eax,r8d
       xor       eax,r11d
       rol       r11d,14
       add       r11d,eax
       rol       eax,9
       xor       eax,r11d
       rol       r11d,1B
       add       r11d,eax
       rol       eax,13
       mov       r8d,r11d
       add       rcx,8
       dec       r9d
       mov       r10d,eax
       mov       eax,r8d
       mov       r8d,r10d
       jne       short M08_L44
       test      dl,4
       jne       near ptr M08_L37
M08_L45:
       mov       r9d,edx
       and       r9,7
       mov       ecx,[rcx+r9-4]
       shr       ecx,8
       or        ecx,80000000
       not       edx
       shl       edx,3
       shrx      ecx,ecx,edx
M08_L46:
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
       mov       eax,ecx
       rol       eax,14
       add       eax,edx
       rol       edx,9
       xor       edx,eax
       rol       eax,1B
       add       eax,edx
       mov       r8d,edx
       rol       r8d,13
       xor       eax,r8d
M08_L47:
       mov       r10,[rsp+0B0]
M08_L48:
       mov       [r10],eax
       inc       r12d
       cmp       ebp,r12d
       jle       near ptr M08_L08
M08_L49:
       cmp       r12d,edi
       jae       near ptr M08_L153
       lea       rax,[r15+r12*4]
       mov       r8,[r14+r12*8+10]
       mov       [rsp+0B8],r8
       mov       [rsp+0B0],rax
       test      r8,r8
       je        near ptr M08_L38
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx+10]
       mov       r11,[rdx+30]
       test      r11,r11
       je        near ptr M08_L42
       jmp       near ptr M08_L43
M08_L50:
       lea       edx,[r15+1]
       mov       [rsp+15C],edx
       mov       r8,[r8]
       movsxd    rdx,r15d
       mov       rcx,r14
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       dec       r13d
       mov       r15d,[rsp+15C]
M08_L51:
       mov       rax,[rsp+0C8]
       inc       eax
       mov       rcx,rax
       cmp       ecx,[rbx+28]
       mov       rax,rcx
       jge       near ptr M08_L06
M08_L52:
       test      r13d,r13d
       je        near ptr M08_L06
       cmp       eax,[r12+8]
       jae       near ptr M08_L153
       mov       [rsp+0C8],rax
       mov       r8,rax
       shl       r8,4
       lea       r8,[r12+r8+10]
       cmp       dword ptr [r8+0C],0FFFFFFFF
       jl        short M08_L51
       jmp       short M08_L50
M08_L53:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdi,[rdx+0A0]
       test      rdi,rdi
       je        short M08_L54
       jmp       short M08_L55
M08_L54:
       mov       rdx,7FF9E645C6E8
       call      qword ptr [7FF9E5BEF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
M08_L55:
       mov       rdx,[rbx+18]
       mov       rcx,offset MT_System.Collections.Generic.IEqualityComparer<System.String>
       call      qword ptr [7FF9E5BE58D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rcx,rax
       call      qword ptr [7FF9E63CFC48]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF9E5BE58D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdi,rax
       jmp       near ptr M08_L00
M08_L56:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+0A8]
       test      rdx,rdx
       je        short M08_L57
       jmp       short M08_L58
M08_L57:
       mov       rdx,7FF9E645C6F8
       call      qword ptr [7FF9E5BEF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M08_L58:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdi,[rax]
       jmp       near ptr M08_L00
M08_L59:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF9E5DB7810]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       test      eax,eax
       jge       near ptr M08_L01
       mov       rcx,[rsi+18]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       je        short M08_L60
       jmp       short M08_L61
M08_L60:
       mov       rcx,rsi
       mov       rdx,7FF9E645F1D0
       call      qword ptr [7FF9E5BEF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M08_L61:
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       cmp       [rax],rdi
       je        short M08_L62
       mov       rdx,23DE0000068
       cmp       rdi,[rdx]
       je        short M08_L62
       mov       rdx,23DE0000070
       cmp       rdi,[rdx]
       jne       near ptr M08_L01
M08_L62:
       mov       rdx,rdi
       mov       rcx,offset MT_System.Collections.Generic.IEqualityComparer<System.String>
       call      qword ptr [7FF9E5BE58D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdi,rax
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.HashSet<System.String>
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       rbx,rax
       mov       edx,[rbx+28]
       sub       edx,[rbx+30]
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbp,rax
       mov       r9d,[rbx+28]
       sub       r9d,[rbx+30]
       mov       rcx,rbx
       mov       rdx,rbp
       xor       r8d,r8d
       call      qword ptr [7FF9E5F5DA28]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].CopyTo(System.__Canon[], Int32, Int32)
       mov       ebx,7FFFFFFF
       xor       r14d,r14d
       xor       r15d,r15d
       xor       ecx,ecx
       jmp       short M08_L66
M08_L63:
       mov       rdx,[rbp+rcx*8+10]
       cmp       [rdx+8],ebx
       jge       short M08_L64
       mov       ebx,[rdx+8]
M08_L64:
       cmp       [rdx+8],r14d
       jle       short M08_L65
       mov       r14d,[rdx+8]
M08_L65:
       mov       edx,[rdx+8]
       mov       r8d,1
       shlx      rdx,r8,rdx
       or        r15,rdx
       inc       ecx
M08_L66:
       cmp       [rbp+8],ecx
       jg        short M08_L63
       mov       rcx,rbp
       mov       rdx,rdi
       mov       r8d,ebx
       mov       r9d,r14d
       call      qword ptr [7FF9E6484BD0]
       mov       r13,rax
       test      r13,r13
       je        short M08_L69
       mov       rcx,[rsi+18]
       cmp       qword ptr [rcx+8],30
       jle       short M08_L67
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M08_L67
       jmp       short M08_L68
M08_L67:
       mov       rcx,rsi
       mov       rdx,7FF9E645F5C8
       call      qword ptr [7FF9E5BEF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M08_L68:
       mov       rdx,r13
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       nop
       vzeroupper
       add       rsp,188
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M08_L69:
       lea       rdx,[rbp+10]
       mov       r8d,[rbp+8]
       mov       [rsp+0D0],rdx
       mov       [rsp+0D8],r8d
       mov       [rsp+20],r14d
       lea       rdx,[rsp+0D0]
       mov       r8,23DE0000070
       cmp       rdi,[r8]
       sete      r8b
       movzx     r8d,r8b
       lea       rcx,[rsp+160]
       mov       r9d,ebx
       call      qword ptr [7FF9E6484BE8]
       mov       ebx,[rsp+168]
       movzx     r14d,byte ptr [rsp+160]
       movzx     r12d,byte ptr [rsp+161]
       mov       r13d,[rsp+164]
       mov       eax,[rsp+16C]
       mov       [rsp+0F8],eax
       mov       edx,[rsp+170]
       mov       [rsp+0F4],edx
       test      ebx,ebx
       je        near ptr M08_L81
       test      r13d,r13d
       jge       near ptr M08_L75
       test      r14d,r14d
       je        near ptr M08_L72
       test      r12d,r12d
       jne       short M08_L70
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_RightJustifiedCaseInsensitiveSubstring
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       r15d,[rsp+0F4]
       mov       [rsp+20],r15d
       mov       [rsp+28],r13d
       mov       [rsp+30],ebx
       mov       rcx,r14
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+0F8]
       call      qword ptr [7FF9E6484C00]
       jmp       short M08_L71
M08_L70:
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_RightJustifiedCaseInsensitiveAsciiSubstring
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       r15d,[rsp+0F4]
       mov       [rsp+20],r15d
       mov       [rsp+28],r13d
       mov       [rsp+30],ebx
       mov       rcx,r14
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+0F8]
       call      qword ptr [7FF9E6484C00]
M08_L71:
       mov       r13,r14
       jmp       near ptr M08_L85
M08_L72:
       cmp       ebx,1
       je        short M08_L73
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_RightJustifiedSubstring
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       r15d,[rsp+0F4]
       mov       [rsp+20],r15d
       mov       [rsp+28],r13d
       mov       [rsp+30],ebx
       mov       rcx,r12
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+0F8]
       call      qword ptr [7FF9E6484C00]
       jmp       short M08_L74
M08_L73:
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_RightJustifiedSingleChar
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       r15d,[rsp+0F4]
       mov       [rsp+20],r15d
       mov       [rsp+28],r13d
       mov       dword ptr [rsp+30],1
       mov       rcx,r12
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+0F8]
       call      qword ptr [7FF9E6484C00]
M08_L74:
       mov       r13,r12
       jmp       near ptr M08_L85
M08_L75:
       test      r14d,r14d
       je        near ptr M08_L78
       test      r12d,r12d
       jne       short M08_L76
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_LeftJustifiedCaseInsensitiveSubstring
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       r15d,[rsp+0F4]
       mov       [rsp+20],r15d
       mov       [rsp+28],r13d
       mov       [rsp+30],ebx
       mov       rcx,r14
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+0F8]
       call      qword ptr [7FF9E6484C00]
       jmp       short M08_L77
M08_L76:
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_LeftJustifiedCaseInsensitiveAsciiSubstring
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       r15d,[rsp+0F4]
       mov       [rsp+20],r15d
       mov       [rsp+28],r13d
       mov       [rsp+30],ebx
       mov       rcx,r14
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+0F8]
       call      qword ptr [7FF9E6484C00]
M08_L77:
       mov       r13,r14
       jmp       near ptr M08_L85
M08_L78:
       cmp       ebx,1
       je        short M08_L79
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_LeftJustifiedSubstring
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       r15d,[rsp+0F4]
       mov       [rsp+20],r15d
       mov       [rsp+28],r13d
       mov       [rsp+30],ebx
       mov       rcx,r12
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+0F8]
       call      qword ptr [7FF9E6484C00]
       jmp       short M08_L80
M08_L79:
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_LeftJustifiedSingleChar
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       r15d,[rsp+0F4]
       mov       [rsp+20],r15d
       mov       [rsp+28],r13d
       mov       dword ptr [rsp+30],1
       mov       rcx,r12
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+0F8]
       call      qword ptr [7FF9E6484C00]
M08_L80:
       mov       r13,r12
       jmp       near ptr M08_L85
M08_L81:
       test      r14d,r14d
       je        short M08_L84
       test      r12d,r12d
       jne       short M08_L82
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_FullCaseInsensitive
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       ebx,[rsp+0F4]
       mov       [rsp+20],ebx
       mov       [rsp+28],r15
       mov       rcx,r13
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+0F8]
       call      qword ptr [7FF9E6484C18]
       jmp       short M08_L83
M08_L82:
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_FullCaseInsensitiveAscii
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       ebx,[rsp+0F4]
       mov       [rsp+20],ebx
       mov       [rsp+28],r15
       mov       rcx,r13
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+0F8]
       call      qword ptr [7FF9E6484C30]
M08_L83:
       jmp       short M08_L85
M08_L84:
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_Full
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       ebx,[rsp+0F4]
       mov       [rsp+20],ebx
       mov       [rsp+28],r15
       mov       rcx,r13
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+0F8]
       call      qword ptr [7FF9E6484C48]
M08_L85:
       mov       rcx,[rsi+18]
       cmp       qword ptr [rcx+8],30
       jle       short M08_L86
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M08_L86
       jmp       short M08_L87
M08_L86:
       mov       rcx,rsi
       mov       rdx,7FF9E645F5C8
       call      qword ptr [7FF9E5BEF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M08_L87:
       mov       rdx,r13
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       nop
       vzeroupper
       add       rsp,188
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M08_L88:
       mov       rcx,[rsi+18]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M08_L89
       jmp       short M08_L90
M08_L89:
       mov       rcx,rsi
       mov       rdx,7FF9E645F0B0
       call      qword ptr [7FF9E5BEF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M08_L90:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF9E6485398]
       mov       rax,rsi
       vzeroupper
       add       rsp,188
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M08_L91:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdi,[rdx+0A0]
       test      rdi,rdi
       je        short M08_L92
       jmp       short M08_L93
M08_L92:
       mov       rdx,7FF9E645C6E8
       call      qword ptr [7FF9E5BEF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
M08_L93:
       mov       rdx,[rbx+18]
       mov       rcx,offset MT_System.Collections.Generic.IEqualityComparer<System.String>
       call      qword ptr [7FF9E5BE58D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rcx,rax
       call      qword ptr [7FF9E63CFC48]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF9E5BE58D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdx,rax
       jmp       near ptr M08_L03
M08_L94:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+0A8]
       test      rdx,rdx
       je        short M08_L95
       jmp       short M08_L96
M08_L95:
       mov       rdx,7FF9E645C6F8
       call      qword ptr [7FF9E5BEF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M08_L96:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       jmp       near ptr M08_L03
M08_L97:
       mov       ecx,28F
       mov       rdx,7FF9E5B24000
       call      qword ptr [7FF9E5BEF228]
       mov       rdx,rax
       mov       ecx,r13d
       call      qword ptr [7FF9E63CDB18]
       int       3
M08_L98:
       test      edi,edi
       jne       near ptr M08_L107
       xor       r15d,r15d
       xor       edi,edi
       jmp       near ptr M08_L07
M08_L99:
       xor       eax,eax
       jmp       near ptr M08_L47
M08_L100:
       mov       r9d,80
       test      dl,1
       je        short M08_L101
       mov       r9d,edx
       and       r9,2
       movzx     r9d,byte ptr [rcx+r9]
       or        r9d,8000
M08_L101:
       test      dl,2
       je        short M08_L102
       shl       r9d,10
       movzx     ecx,word ptr [rcx]
       or        r9d,ecx
       mov       ecx,r9d
       jmp       near ptr M08_L46
M08_L102:
       mov       ecx,r9d
       jmp       near ptr M08_L46
M08_L103:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       jmp       near ptr M08_L47
M08_L104:
       mov       r8,[rsp+0B8]
       mov       rdx,r8
       call      qword ptr [r11]
       jmp       near ptr M08_L47
M08_L105:
       mov       edx,[rsp+158]
       test      edx,edx
       jne       short M08_L107
       xor       r8d,r8d
       xor       r10d,r10d
       jmp       near ptr M08_L09
M08_L106:
       or        edx,r12d
       jne       short M08_L107
       xor       r9d,r9d
       xor       r12d,r12d
       mov       ecx,r9d
       mov       r9,r12
       mov       r12d,ecx
       jmp       near ptr M08_L10
M08_L107:
       call      qword ptr [7FF9E5DBF228]
       int       3
M08_L108:
       vpcmpeqd  ymm0,ymm0,ymm0
       vmovups   [r8+r13],ymm0
       jmp       near ptr M08_L13
M08_L109:
       xor       r11d,r11d
       test      cl,4
       je        short M08_L110
       mov       dword ptr [r8+r11*4],0FFFFFFFF
       mov       dword ptr [r8+r11*4+4],0FFFFFFFF
       mov       dword ptr [r8+r11*4+8],0FFFFFFFF
       mov       dword ptr [r8+r11*4+0C],0FFFFFFFF
       add       r11,4
M08_L110:
       test      cl,2
       je        short M08_L111
       mov       dword ptr [r8+r11*4],0FFFFFFFF
       mov       dword ptr [r8+r11*4+4],0FFFFFFFF
       add       r11,2
M08_L111:
       test      cl,1
       je        near ptr M08_L14
       mov       dword ptr [r8+r11*4],0FFFFFFFF
       jmp       near ptr M08_L14
M08_L112:
       mov       r13,[rsp+150]
       jmp       near ptr M08_L16
M08_L113:
       mov       r13,[rsp+150]
       jmp       near ptr M08_L16
M08_L114:
       mov       ecx,7
       call      qword ptr [7FF9E63CDD70]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       r9,rax
       mov       rax,[rsp+98]
       mov       rdx,[rsp+90]
       jmp       near ptr M08_L25
M08_L115:
       jmp       short M08_L114
M08_L116:
       mov       rcx,rdx
       call      qword ptr [7FF9E618F420]; System.Buffers.SharedArrayPool`1[[System.Int32, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
       mov       r11,rax
       mov       rax,[rsp+98]
       jmp       near ptr M08_L26
M08_L117:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9E621EE68]
       mov       rbx,rax
       mov       ecx,29B
       mov       rdx,7FF9E5B24000
       call      qword ptr [7FF9E5BEF228]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9E5F57D50]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M08_L118:
       mov       r8,[rsp+90]
       mov       rcx,[r8+10]
       mov       r10d,[rsp+13C]
       cmp       r10d,[rcx+8]
       jae       near ptr M08_L153
       mov       edx,r10d
       mov       r9,[rcx+rdx*8+10]
       test      r9,r9
       jne       short M08_L120
       mov       rcx,r8
       mov       edx,r10d
       call      qword ptr [7FF9E63CFC00]
       mov       r9,rax
M08_L119:
       mov       rcx,[r9+8]
       mov       [rsp+70],rcx
       call      qword ptr [7FF9E621F438]; System.Threading.Thread.GetCurrentProcessorNumber()
       mov       ecx,0AAAAAAAB
       mov       edx,eax
       imul      rcx,rdx
       shr       rcx,23
       imul      ecx,0C
       sub       eax,ecx
       xor       edx,edx
       jmp       near ptr M08_L127
M08_L120:
       jmp       short M08_L119
M08_L121:
       cmp       eax,[r8+8]
       jae       near ptr M08_L153
       mov       [rsp+120],eax
       mov       ecx,eax
       mov       r10,[r8+rcx*8+10]
       mov       [rsp+68],r10
       cmp       [r10],r10b
       xor       r9d,r9d
       mov       [rsp+118],r9d
       mov       rcx,r10
       call      qword ptr [7FF9E610E2B0]; System.Threading.Monitor.Enter(System.Object)
       mov       rax,[rsp+68]
       mov       rcx,[rax+8]
       mov       r8d,[rax+10]
       mov       [rsp+114],r8d
       cmp       [rcx+8],r8d
       jbe       short M08_L123
       test      r8d,r8d
       jne       short M08_L124
       xor       edx,edx
       mov       [rax+14],edx
M08_L122:
       movsxd    rdx,r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,[rsp+78]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rsp+114]
       inc       ecx
       mov       rax,[rsp+68]
       mov       [rax+10],ecx
       mov       dword ptr [rsp+118],1
M08_L123:
       mov       rcx,rax
       call      qword ptr [7FF9E5BE6820]; System.Threading.Monitor.Exit(System.Object)
       cmp       dword ptr [rsp+118],0
       je        short M08_L125
       jmp       short M08_L128
M08_L124:
       jmp       short M08_L122
M08_L125:
       mov       eax,[rsp+120]
       inc       eax
       mov       ecx,eax
       mov       r8,[rsp+70]
       cmp       [r8+8],ecx
       jne       short M08_L126
       xor       ecx,ecx
M08_L126:
       mov       edx,[rsp+11C]
       inc       edx
       mov       eax,ecx
M08_L127:
       mov       r8,[rsp+70]
       mov       [rsp+11C],edx
       cmp       [r8+8],edx
       jg        near ptr M08_L121
       jmp       short M08_L129
M08_L128:
       mov       edx,1
       jmp       short M08_L130
M08_L129:
       xor       edx,edx
M08_L130:
       mov       [rsp+134],edx
       mov       rax,[rsp+98]
       mov       ecx,[rsp+138]
       mov       r10d,[rsp+13C]
       jmp       near ptr M08_L27
M08_L131:
       mov       r8,[rsp+0A8]
       cmp       dword ptr [r8+8],0
       mov       [rsp+138],ecx
       je        near ptr M08_L28
       mov       rcx,r8
       call      qword ptr [7FF9E600D740]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+130],eax
       mov       rdx,[rsp+0A8]
       mov       r8d,[rdx+8]
       mov       [rsp+12C],r8d
       mov       rcx,[rsp+90]
       call      qword ptr [7FF9E600D740]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,[rsp+88]
       mov       r8d,[rsp+130]
       mov       r9d,[rsp+12C]
       mov       edx,3
       call      qword ptr [7FF9E63CF858]
       mov       eax,[rsp+138]
       test      [rsp+134],eax
       jne       short M08_L132
       mov       rcx,[rsp+0A8]
       call      qword ptr [7FF9E600D740]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+128],eax
       mov       rcx,[rsp+0A8]
       mov       edx,[rcx+8]
       mov       [rsp+124],edx
       mov       rcx,[rsp+90]
       call      qword ptr [7FF9E600D740]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       cmp       dword ptr [rsp+138],0
       jne       short M08_L133
       mov       ecx,0FFFFFFFF
       mov       edx,1
       jmp       short M08_L134
M08_L132:
       mov       rax,[rsp+98]
       jmp       near ptr M08_L28
M08_L133:
       mov       ecx,[rsp+13C]
       xor       edx,edx
M08_L134:
       mov       [rsp+20],ecx
       mov       [rsp+28],edx
       mov       rcx,[rsp+88]
       mov       edx,[rsp+128]
       mov       r8d,[rsp+124]
       call      qword ptr [7FF9E621EEE0]
       mov       rax,[rsp+98]
       jmp       near ptr M08_L28
M08_L135:
       mov       ecx,2
       call      qword ptr [7FF9E5BEFD50]
       int       3
M08_L136:
       mov       rcx,r12
       call      qword ptr [7FF9E618F420]; System.Buffers.SharedArrayPool`1[[System.Int32, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
       jmp       near ptr M08_L31
M08_L137:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9E621EE68]
       mov       r12,rax
       mov       ecx,29B
       mov       rdx,7FF9E5B24000
       call      qword ptr [7FF9E5BEF228]
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,rbx
       call      qword ptr [7FF9E5F57D50]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M08_L138:
       mov       rcx,[r12+10]
       cmp       edi,[rcx+8]
       jae       near ptr M08_L153
       mov       edx,edi
       mov       rax,[rcx+rdx*8+10]
       test      rax,rax
       jne       short M08_L139
       mov       rcx,r12
       mov       edx,edi
       call      qword ptr [7FF9E63CFC00]
M08_L139:
       mov       r14,[rax+8]
       call      qword ptr [7FF9E621F438]; System.Threading.Thread.GetCurrentProcessorNumber()
       mov       ecx,0AAAAAAAB
       mov       edx,eax
       imul      rcx,rdx
       shr       rcx,23
       imul      ecx,0C
       mov       r15d,eax
       sub       r15d,ecx
       xor       eax,eax
       jmp       near ptr M08_L146
M08_L140:
       cmp       r15d,[r14+8]
       jae       near ptr M08_L153
       mov       ecx,r15d
       mov       rdx,[r14+rcx*8+10]
       mov       [rsp+60],rdx
       cmp       [rdx],dl
       xor       r8d,r8d
       mov       [rsp+108],r8d
       mov       rcx,rdx
       call      qword ptr [7FF9E610E2B0]; System.Threading.Monitor.Enter(System.Object)
       mov       rax,[rsp+60]
       mov       rcx,[rax+8]
       mov       r8d,[rax+10]
       mov       [rsp+104],r8d
       cmp       [rcx+8],r8d
       jbe       short M08_L142
       test      r8d,r8d
       jne       short M08_L143
       xor       edx,edx
       mov       [rax+14],edx
M08_L141:
       movsxd    rdx,r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rsp+104]
       inc       ecx
       mov       rax,[rsp+60]
       mov       [rax+10],ecx
       mov       dword ptr [rsp+108],1
M08_L142:
       mov       rcx,rax
       call      qword ptr [7FF9E5BE6820]; System.Threading.Monitor.Exit(System.Object)
       cmp       dword ptr [rsp+108],0
       je        short M08_L144
       jmp       short M08_L147
M08_L143:
       jmp       short M08_L141
M08_L144:
       inc       r15d
       cmp       [r14+8],r15d
       jne       short M08_L145
       xor       r15d,r15d
M08_L145:
       mov       eax,[rsp+10C]
       inc       eax
M08_L146:
       mov       [rsp+10C],eax
       cmp       [r14+8],eax
       jg        near ptr M08_L140
       jmp       short M08_L148
M08_L147:
       mov       r14d,1
       jmp       short M08_L149
M08_L148:
       xor       r14d,r14d
M08_L149:
       jmp       near ptr M08_L32
M08_L150:
       cmp       dword ptr [rbx+8],0
       je        near ptr M08_L33
       mov       rcx,rbx
       call      qword ptr [7FF9E600D740]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r13d,eax
       mov       eax,[rbx+8]
       mov       [rsp+110],eax
       mov       rcx,r12
       call      qword ptr [7FF9E600D740]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,r15
       mov       r8d,r13d
       mov       r9d,[rsp+110]
       mov       edx,3
       call      qword ptr [7FF9E63CF858]
       test      r14d,ebp
       jne       near ptr M08_L33
       mov       rcx,rbx
       call      qword ptr [7FF9E600D740]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r14d,eax
       mov       ebx,[rbx+8]
       mov       rcx,r12
       call      qword ptr [7FF9E600D740]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       test      ebp,ebp
       jne       short M08_L151
       mov       ecx,0FFFFFFFF
       mov       edx,1
       jmp       short M08_L152
M08_L151:
       mov       ecx,edi
       xor       edx,edx
M08_L152:
       mov       [rsp+20],ecx
       mov       [rsp+28],edx
       mov       rcx,r15
       mov       edx,r14d
       mov       r8d,ebx
       call      qword ptr [7FF9E621EEE0]
       jmp       near ptr M08_L33
M08_L153:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 6135
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
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       test      rbx,rbx
       je        near ptr M10_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M10_L01
       test      rsi,rsi
       je        short M10_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M10_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M10_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFA45879D30
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF9E5BE5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF9E5BE5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
M10_L00:
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
M10_L01:
       test      rsi,rsi
       je        short M10_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M10_L03
M10_L02:
       mov       rax,27E75080008
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M10_L03:
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
M10_L04:
       call      qword ptr [7FF9E63CF570]
       int       3
; Total bytes of code 244
```
```assembly
; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].get_Comparer()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       rcx,[rbx]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rdx,offset MT_System.String
       cmp       [rcx],rdx
       je        short M11_L01
       mov       rax,[rbx+18]
       test      rax,rax
       je        short M11_L04
M11_L00:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M11_L01:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rsi,[rdx+0A0]
       test      rsi,rsi
       je        short M11_L02
       jmp       short M11_L03
M11_L02:
       mov       rdx,7FF9E645C6E8
       call      qword ptr [7FF9E5BEF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rsi,rax
M11_L03:
       mov       rdx,[rbx+18]
       mov       rcx,offset MT_System.Collections.Generic.IEqualityComparer<System.String>
       call      qword ptr [7FF9E5BE58D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rcx,rax
       call      qword ptr [7FF9E63CFC48]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9E5BE58D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M11_L04:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+0A8]
       test      rdx,rdx
       je        short M11_L05
       jmp       short M11_L06
M11_L05:
       mov       rdx,7FF9E645C6F8
       call      qword ptr [7FF9E5BEF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M11_L06:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rax]
       jmp       near ptr M11_L00
; Total bytes of code 206
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M12_L00
       ret
M12_L00:
       jmp       qword ptr [7FF9E5BE5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.ToFrozenSet()
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
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-70],xmm4
       xor       eax,eax
       mov       [rbp-60],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       test      rsi,rsi
       je        near ptr M00_L44
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L46
       mov       rcx,[rsi+8]
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],r11
       jne       near ptr M00_L45
       mov       edi,[rcx+10]
M00_L00:
       test      edi,edi
       je        near ptr M00_L59
       mov       rdx,27419400A20
       mov       rdi,[rdx]
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Frozen.FrozenSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r14,rax
       test      r14,r14
       jne       near ptr M00_L47
M00_L01:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Generic.HashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r14,rax
       mov       r15,r14
       test      r15,r15
       jne       near ptr M00_L48
M00_L02:
       mov       rcx,offset MT_System.Collections.Generic.HashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       lea       rcx,[r15+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       test      r14,r14
       jne       near ptr M00_L49
M00_L03:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L51
       mov       rcx,[rsi+8]
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],r11
       jne       near ptr M00_L50
       mov       ecx,[rcx+10]
M00_L04:
       test      ecx,ecx
       jle       short M00_L05
       call      qword ptr [7FF9E5BF5A88]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       r14d,eax
       movsxd    rdx,r14d
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r13,rax
       movsxd    rdx,r14d
       mov       rcx,offset MT_System.Collections.Generic.HashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Entry[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r12,rax
       mov       dword ptr [r15+2C],0FFFFFFFF
       lea       rcx,[r15+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,r14d
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [r15+20],rax
M00_L05:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L54
       mov       rsi,[rsi+8]
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L53
       cmp       dword ptr [rsi+10],0
       je        near ptr M00_L52
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       r13d,[rsi+14]
       lea       rcx,[r14+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r14+10],rcx
       mov       [r14+18],r13d
       mov       [r14+1C],ecx
M00_L06:
       mov       [rbp-78],r14
M00_L07:
       mov       rdx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rcx,[rbp-78]
       cmp       [rcx],rdx
       jne       near ptr M00_L36
       mov       rdx,[rcx]
       add       rcx,8
       call      qword ptr [7FF9E5E8C150]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L08:
       test      eax,eax
       je        near ptr M00_L39
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-78]
       cmp       [rax],rcx
       jne       near ptr M00_L24
       mov       rsi,[rax+10]
M00_L09:
       cmp       qword ptr [r15+8],0
       je        near ptr M00_L25
M00_L10:
       mov       r14,[r15+10]
       mov       r13,[r15+18]
       xor       r12d,r12d
       test      rsi,rsi
       je        near ptr M00_L20
       mov       rcx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r13],rcx
       jne       near ptr M00_L32
       mov       rdx,[rsi+28]
       test      rdx,rdx
       je        near ptr M00_L26
       mov       rcx,27403400068
       mov       rcx,[rcx]
       mov       r8,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],r8
       jne       near ptr M00_L31
       lea       rcx,[rdx+0C]
       mov       r8d,[rdx+8]
       add       r8d,r8d
       mov       [rbp-44],r8d
       mov       dword ptr [rbp-50],0C33A731
       mov       dword ptr [rbp-58],25A0AD16
       cmp       r8d,8
       jb        near ptr M00_L18
       mov       edx,r8d
       shr       edx,3
       xchg      ax,ax
M00_L11:
       mov       r10d,[rbp-50]
       add       r10d,[rcx]
       mov       [rbp-50],r10d
       mov       r10d,[rcx+4]
       mov       r9d,[rbp-50]
       mov       r11d,[rbp-58]
       xor       r11d,r9d
       rol       r9d,14
       add       r9d,r11d
       rol       r11d,9
       xor       r11d,r9d
       rol       r9d,1B
       add       r9d,r11d
       rol       r11d,13
       mov       [rbp-50],r9d
       mov       [rbp-58],r11d
       add       r10d,[rbp-50]
       mov       [rbp-50],r10d
       mov       r10d,[rbp-50]
       mov       r9d,[rbp-58]
       xor       r9d,r10d
       rol       r10d,14
       add       r10d,r9d
       rol       r9d,9
       xor       r9d,r10d
       rol       r10d,1B
       add       r10d,r9d
       rol       r9d,13
       mov       [rbp-50],r10d
       mov       [rbp-58],r9d
       add       rcx,8
       dec       edx
       jne       short M00_L11
       test      r8b,4
       jne       near ptr M00_L27
M00_L12:
       mov       edx,r8d
       and       rdx,7
       mov       ecx,[rcx+rdx-4]
       shr       ecx,8
       or        ecx,80000000
       not       r8d
       shl       r8d,3
       shrx      ecx,ecx,r8d
M00_L13:
       add       ecx,[rbp-50]
       mov       [rbp-50],ecx
       lea       rcx,[rbp-50]
       lea       rdx,[rbp-58]
       call      qword ptr [7FF9E64A52F0]; System.Marvin.Block(UInt32 ByRef, UInt32 ByRef)
       lea       rcx,[rbp-50]
       lea       rdx,[rbp-58]
       call      qword ptr [7FF9E64A52F0]; System.Marvin.Block(UInt32 ByRef, UInt32 ByRef)
       mov       eax,[rbp-58]
       xor       eax,[rbp-50]
M00_L14:
       mov       [rbp-3C],eax
       mov       rdx,[r15+8]
       mov       ecx,eax
       imul      rcx,[r15+20]
       shr       rcx,20
       inc       rcx
       mov       r8d,[rdx+8]
       mov       r11d,r8d
       imul      rcx,r11
       shr       rcx,20
       cmp       ecx,r8d
       jae       near ptr M00_L38
       mov       ecx,ecx
       lea       r10,[rdx+rcx*4+10]
       mov       [rbp-88],r10
       mov       r9d,[r10]
       dec       r9d
       jns       near ptr M00_L21
M00_L15:
       cmp       dword ptr [r15+30],0
       jg        near ptr M00_L23
       mov       edx,[r15+28]
       mov       [rbp-40],edx
       cmp       [r14+8],edx
       je        near ptr M00_L34
M00_L16:
       mov       edx,[rbp-40]
       mov       r14d,edx
       lea       ecx,[r14+1]
       mov       [r15+28],ecx
       mov       rcx,[r15+10]
       mov       r8,rcx
M00_L17:
       cmp       r14d,[r8+8]
       jae       near ptr M00_L38
       mov       ecx,r14d
       shl       rcx,4
       mov       [rbp-80],r8
       lea       rcx,[r8+rcx+10]
       mov       [rcx+8],eax
       mov       r10,[rbp-88]
       mov       edx,[r10]
       dec       edx
       mov       [rcx+0C],edx
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       inc       r14d
       mov       rdx,[rbp-88]
       mov       [rdx],r14d
       inc       dword ptr [r15+34]
       cmp       r12d,64
       jbe       near ptr M00_L07
       jmp       near ptr M00_L35
M00_L18:
       cmp       r8d,4
       jb        near ptr M00_L28
M00_L19:
       mov       edx,[rbp-50]
       mov       [rbp-98],rcx
       add       edx,[rcx]
       mov       [rbp-50],edx
       lea       rcx,[rbp-50]
       lea       rdx,[rbp-58]
       call      qword ptr [7FF9E64A52F0]; System.Marvin.Block(UInt32 ByRef, UInt32 ByRef)
       mov       rax,[rbp-78]
       mov       rcx,[rbp-98]
       mov       r8d,[rbp-44]
       jmp       near ptr M00_L12
M00_L20:
       xor       edx,edx
       xor       r10d,r10d
       mov       eax,r10d
       jmp       near ptr M00_L14
M00_L21:
       cmp       r9d,[r14+8]
       jae       near ptr M00_L38
       mov       edx,r9d
       shl       rdx,4
       lea       r9,[r14+rdx+10]
       mov       [rbp-90],r9
       cmp       [r9+8],eax
       je        near ptr M00_L33
M00_L22:
       mov       r9d,[r9+0C]
       inc       r12d
       cmp       [r14+8],r12d
       jb        near ptr M00_L37
       test      r9d,r9d
       mov       eax,[rbp-3C]
       jge       short M00_L21
       jmp       near ptr M00_L15
M00_L23:
       mov       ecx,[r15+2C]
       mov       r8d,ecx
       dec       dword ptr [r15+30]
       cmp       ecx,[r14+8]
       jae       near ptr M00_L38
       shl       rcx,4
       mov       ecx,[r14+rcx+1C]
       neg       ecx
       add       ecx,0FFFFFFFD
       mov       [r15+2C],ecx
       mov       ecx,r8d
       mov       r8,r14
       mov       r14d,ecx
       jmp       near ptr M00_L17
M00_L24:
       mov       rcx,rax
       mov       r11,7FF9E5B40D50
       call      qword ptr [r11]
       mov       rsi,rax
       mov       rax,[rbp-78]
       jmp       near ptr M00_L09
M00_L25:
       mov       rcx,r15
       xor       edx,edx
       call      qword ptr [7FF9E5DC7750]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       mov       rax,[rbp-78]
       jmp       near ptr M00_L10
M00_L26:
       xor       ecx,ecx
       mov       eax,ecx
       jmp       near ptr M00_L14
M00_L27:
       jmp       near ptr M00_L19
M00_L28:
       mov       r8d,[rbp-44]
       mov       edx,80
       test      r8b,1
       je        short M00_L29
       mov       edx,r8d
       and       rdx,2
       movzx     edx,byte ptr [rcx+rdx]
       or        edx,8000
M00_L29:
       test      r8b,2
       je        short M00_L30
       shl       edx,10
       movzx     ecx,word ptr [rcx]
       or        edx,ecx
       mov       ecx,edx
       jmp       near ptr M00_L13
M00_L30:
       mov       ecx,edx
       jmp       near ptr M00_L13
M00_L31:
       mov       r8,[rcx]
       mov       r8,[r8+48]
       call      qword ptr [r8+18]
       jmp       near ptr M00_L14
M00_L32:
       mov       rcx,r13
       mov       rdx,rsi
       mov       r11,7FF9E5B40D68
       call      qword ptr [r11]
       jmp       near ptr M00_L14
M00_L33:
       mov       rdx,[r9]
       mov       rcx,r13
       mov       r8,rsi
       mov       r11,7FF9E5B40D70
       call      qword ptr [r11]
       test      eax,eax
       mov       r9,[rbp-90]
       jne       near ptr M00_L07
       jmp       near ptr M00_L22
M00_L34:
       mov       rcx,r15
       call      qword ptr [7FF9E63DFAC8]
       mov       rcx,[r15+8]
       mov       r14d,[rbp-3C]
       mov       edx,r14d
       imul      rdx,[r15+20]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       imul      rdx,rax
       shr       rdx,20
       cmp       edx,[rcx+8]
       jae       short M00_L38
       mov       edx,edx
       lea       r10,[rcx+rdx*4+10]
       mov       rax,r10
       mov       [rbp-88],rax
       mov       eax,r14d
       jmp       near ptr M00_L16
M00_L35:
       mov       r14,[rbp-80]
       mov       rdx,r13
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M00_L07
       mov       edx,[r14+8]
       mov       rcx,r15
       mov       r8d,1
       call      qword ptr [7FF9E5F6D980]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,r15
       mov       rdx,rsi
       call      qword ptr [7FF9E5DC7810]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       jmp       near ptr M00_L07
M00_L36:
       mov       r11,7FF9E5B40D48
       call      qword ptr [r11]
       jmp       near ptr M00_L08
M00_L37:
       call      qword ptr [7FF9E5BFF498]
       int       3
M00_L38:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L39:
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-78]
       cmp       [rax],rcx
       jne       near ptr M00_L55
M00_L40:
       mov       ecx,[r15+28]
       test      ecx,ecx
       jle       short M00_L41
       mov       rax,[r15+10]
       mov       eax,[rax+8]
       cdq
       idiv      ecx
       cmp       eax,3
       jg        near ptr M00_L56
M00_L41:
       mov       ecx,[r15+28]
       sub       ecx,[r15+30]
       je        near ptr M00_L57
       xor       esi,esi
M00_L42:
       test      rsi,rsi
       jne       short M00_L43
       mov       rdx,r15
       mov       rcx,7FF9E64006D0
       call      qword ptr [7FF9E63D58A8]; System.Collections.Frozen.FrozenSet.CreateFromSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
       mov       rsi,rax
M00_L43:
       mov       [rbp-60],rsi
       mov       rcx,[rbx+60]
       lea       r8,[rbp-60]
       mov       rdx,7FF9E640B440
       cmp       [rcx],ecx
       call      qword ptr [7FF9E63D6BC8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
M00_L44:
       call      qword ptr [7FF9E619EFA0]
       mov       ecx,65
       mov       rdx,7FF9E5FF8D68
       call      qword ptr [7FF9E5BFF228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF9E5EC5AC0
       call      qword ptr [7FF9E5BFF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9E5BFD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9E5FF8D68
       call      qword ptr [7FF9E5BFF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9E5BFD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9E63DD5D8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9E63DD5F0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L45:
       mov       r11,7FF9E5B40D28
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L00
M00_L46:
       mov       rcx,rsi
       mov       r11,7FF9E5B40D20
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L00
M00_L47:
       mov       rcx,[r14+8]
       mov       rdx,rdi
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       test      eax,eax
       je        near ptr M00_L01
       xor       r15d,r15d
       mov       rsi,r14
       jmp       near ptr M00_L42
M00_L48:
       mov       ecx,[r15+28]
       sub       ecx,[r15+30]
       je        near ptr M00_L41
       mov       rcx,r15
       call      qword ptr [7FF9E63D6238]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].get_Comparer()
       mov       rcx,rax
       mov       rdx,rdi
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       test      eax,eax
       jne       near ptr M00_L41
       jmp       near ptr M00_L02
M00_L49:
       mov       r8,r14
       mov       rdx,r15
       mov       rcx,offset MT_System.Collections.Generic.HashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FF9E64A51D0]
       test      eax,eax
       je        near ptr M00_L03
       mov       rcx,r15
       mov       rdx,r14
       call      qword ptr [7FF9E63DFB28]
       jmp       near ptr M00_L41
M00_L50:
       mov       r11,7FF9E5B40D38
       call      qword ptr [r11]
       mov       ecx,eax
       jmp       near ptr M00_L04
M00_L51:
       mov       rcx,rsi
       mov       r11,7FF9E5B40D30
       call      qword ptr [r11]
       mov       ecx,eax
       jmp       near ptr M00_L04
M00_L52:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,27419400AC8
       mov       r14,[rcx]
       jmp       near ptr M00_L06
M00_L53:
       mov       rcx,rsi
       mov       r11,7FF9E5B40D60
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L06
M00_L54:
       mov       rcx,rsi
       mov       r11,7FF9E5B40D40
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L06
M00_L55:
       mov       rcx,rax
       mov       r11,7FF9E5B40D58
       call      qword ptr [r11]
       jmp       near ptr M00_L40
M00_L56:
       mov       edx,ecx
       sub       edx,[r15+30]
       mov       rcx,r15
       call      qword ptr [7FF9E63DFB40]
       jmp       near ptr M00_L41
M00_L57:
       mov       rcx,offset MT_System.Collections.Frozen.FrozenSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,27419400AD8
       mov       rcx,[rcx]
       cmp       rdi,[rcx+8]
       je        short M00_L58
       mov       rcx,offset MT_System.Collections.Frozen.EmptyFrozenSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L42
M00_L58:
       mov       rcx,offset MT_System.Collections.Frozen.FrozenSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,27419400AD8
       mov       rsi,[rdx]
       jmp       near ptr M00_L42
M00_L59:
       xor       r8d,r8d
       mov       [rbp-70],r8
       mov       [rbp-68],r8d
       lea       r8,[rbp-70]
       mov       rcx,7FF9E64C6B48
       xor       edx,edx
       call      qword ptr [7FF9E64A5290]
       mov       rsi,rax
       jmp       near ptr M00_L43
       sub       rsp,28
       cmp       qword ptr [rbp-78],0
       je        short M00_L60
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-78]
       cmp       [rax],rcx
       je        short M00_L60
       mov       rcx,rax
       mov       r11,7FF9E5B40D58
       call      qword ptr [r11]
M00_L60:
       nop
       add       rsp,28
       ret
; Total bytes of code 2510
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
       mov       rcx,7FF9ED480B08
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
       call      qword ptr [7FF9E63DEA18]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9E5F65E60]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M02_L03:
       mov       esi,ebx
       or        esi,1
       jmp       short M02_L06
M02_L04:
       mov       ecx,esi
       call      qword ptr [7FF9E63DEA30]
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
; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx]
       mov       rdx,rcx
       mov       eax,[rbx+10]
       cmp       eax,[rcx+14]
       jne       short M03_L00
       mov       ecx,[rbx+14]
       cmp       ecx,[rdx+10]
       jae       short M03_L01
       mov       rdx,[rdx+8]
       cmp       ecx,[rdx+8]
       jae       short M03_L02
       mov       ecx,ecx
       mov       rdx,[rdx+rcx*8+10]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       dword ptr [rbx+14]
       mov       eax,1
       add       rsp,20
       pop       rbx
       ret
M03_L00:
       call      qword ptr [7FF9E5BFFC60]
       int       3
M03_L01:
       xor       eax,eax
       mov       [rbx+8],rax
       mov       dword ptr [rbx+14],0FFFFFFFF
       add       rsp,20
       pop       rbx
       ret
M03_L02:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 101
```
```assembly
; System.Marvin.Block(UInt32 ByRef, UInt32 ByRef)
       mov       eax,[rcx]
       mov       r8d,eax
       xor       r8d,[rdx]
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       mov       [rcx],eax
       mov       [rdx],r8d
       ret
; Total bytes of code 37
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
       call      qword ptr [7FF9E5BF5A88]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       esi,eax
       movsxd    rdx,esi
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rdi,rax
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+0B0]
       test      rax,rax
       je        short M05_L01
       mov       rcx,rax
M05_L00:
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
M05_L01:
       mov       rdx,7FF9E646BB58
       call      qword ptr [7FF9E5BFF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M05_L00
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
       call      qword ptr [7FF9EE0E7EC8]
       mov       rcx,rax
       movsxd    rdx,esi
       call      qword ptr [7FF9EE0E4088]; CORINFO_HELP_NEWARR_1_DIRECT
       mov       rbp,rax
       mov       r14d,[rbx+28]
       mov       rcx,[rbx+10]
       mov       rdx,rbp
       mov       r8d,r14d
       call      qword ptr [7FF9EE0F52F0]; Precode of System.Array.Copy(System.Array, System.Array, Int32)
       movzx     ecx,dil
       test      cl,1
       jne       near ptr M06_L06
M06_L00:
       movsxd    rcx,esi
       call      qword ptr [7FF9EE0F1B50]
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      qword ptr [7FF9EE0E3FE8]; CORINFO_HELP_ASSIGN_REF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,esi
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rbx+20],rax
       xor       ecx,ecx
       test      r14d,r14d
       jle       short M06_L03
       cmp       [rbp+8],r14d
       jl        near ptr M06_L04
M06_L01:
       mov       edx,ecx
       shl       rdx,4
       lea       rdx,[rbp+rdx+10]
       cmp       dword ptr [rdx+0C],0FFFFFFFF
       jl        short M06_L02
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
       jae       near ptr M06_L11
       mov       r10d,r10d
       lea       rax,[r8+r10*4+10]
       mov       r8d,[rax]
       dec       r8d
       mov       [rdx+0C],r8d
       lea       edx,[rcx+1]
       mov       [rax],edx
M06_L02:
       inc       ecx
       cmp       ecx,r14d
       jl        short M06_L01
M06_L03:
       lea       rcx,[rbx+10]
       mov       rdx,rbp
       call      qword ptr [7FF9EE0E3FE8]; CORINFO_HELP_ASSIGN_REF
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
M06_L04:
       cmp       ecx,[rbp+8]
       jae       near ptr M06_L11
       mov       eax,ecx
       shl       rax,4
       lea       rdx,[rbp+rax+10]
       cmp       dword ptr [rdx+0C],0FFFFFFFF
       jl        short M06_L05
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
       jae       near ptr M06_L11
       mov       eax,r10d
       lea       rax,[r8+rax*4+10]
       mov       r8d,[rax]
       dec       r8d
       mov       [rdx+0C],r8d
       lea       edx,[rcx+1]
       mov       [rax],edx
M06_L05:
       inc       ecx
       cmp       ecx,r14d
       jl        short M06_L04
       jmp       near ptr M06_L03
M06_L06:
       mov       rcx,[rbx]
       call      qword ptr [7FF9EE0E74F8]
       mov       rdi,rax
       mov       rcx,[rbx+18]
       call      qword ptr [7FF9EE0F3730]
       mov       rcx,rax
       lea       r11,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       [rcx],ecx
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF9EE0E4090]; Precode of System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdi,rax
       lea       rcx,[rbx+18]
       mov       rdx,rdi
       call      qword ptr [7FF9EE0E3FE8]; CORINFO_HELP_ASSIGN_REF
       xor       r15d,r15d
       cmp       r15d,r14d
       jge       near ptr M06_L00
M06_L07:
       cmp       r15d,[rbp+8]
       jae       short M06_L11
       mov       rcx,r15
       shl       rcx,4
       lea       r13,[rbp+rcx+10]
       cmp       dword ptr [r13+0C],0FFFFFFFF
       jl        short M06_L10
       cmp       qword ptr [r13],0
       jne       short M06_L08
       xor       r12d,r12d
       jmp       short M06_L09
M06_L08:
       mov       rcx,[rbx]
       call      qword ptr [7FF9EE0E9150]
       mov       rdx,[r13]
       mov       rcx,rdi
       mov       r11,rax
       call      qword ptr [rax]
       mov       r12d,eax
M06_L09:
       mov       [r13+8],r12d
M06_L10:
       inc       r15d
       cmp       r15d,r14d
       jl        short M06_L07
       jmp       near ptr M06_L00
M06_L11:
       call      qword ptr [7FF9EE0E3FD8]
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
       je        near ptr M07_L07
       mov       rdi,[rbx+10]
       xor       ebp,ebp
       mov       r14,[rbx+18]
       test      rsi,rsi
       je        near ptr M07_L11
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+78]
       test      r11,r11
       je        near ptr M07_L08
M07_L00:
       mov       rcx,offset MT_System.Collections.Generic.ObjectEqualityComparer<System.RuntimeType>
       cmp       [r14],rcx
       jne       near ptr M07_L13
       mov       [rsp+38],rsi
       xor       ecx,ecx
       mov       [rsp+30],rcx
       lea       rcx,[rsp+38]
       cmp       qword ptr [rsp+30],0
       jne       short M07_L01
       mov       rcx,[rsp+38]
       mov       [rsp+30],rcx
       lea       rcx,[rsp+30]
       cmp       qword ptr [rsp+30],0
       je        near ptr M07_L12
M07_L01:
       mov       r15,[rcx]
       mov       rcx,offset MT_System.RuntimeType
       cmp       [r15],rcx
       jne       near ptr M07_L10
       mov       rcx,r15
       call      00007FFA45809590
       test      eax,eax
       je        near ptr M07_L09
M07_L02:
       mov       r15d,eax
M07_L03:
       xor       ecx,ecx
       mov       [rsp+30],rcx
M07_L04:
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
       jae       near ptr M07_L18
       mov       edx,edx
       lea       rcx,[rcx+rdx*4+10]
       mov       r13d,[rcx]
       dec       r13d
       js        short M07_L07
M07_L05:
       mov       r12d,[rdi+8]
       cmp       r13d,r12d
       jae       near ptr M07_L18
       mov       ecx,r13d
       shl       rcx,4
       lea       rax,[rdi+rcx+10]
       mov       [rsp+28],rax
       cmp       [rax+8],r15d
       je        near ptr M07_L14
M07_L06:
       mov       rax,[rsp+28]
       mov       r13d,[rax+0C]
       inc       ebp
       cmp       r12d,ebp
       jb        near ptr M07_L17
       test      r13d,r13d
       jge       short M07_L05
M07_L07:
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
M07_L08:
       mov       rdx,7FF9E64663F8
       call      qword ptr [7FF9E5BFF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M07_L00
M07_L09:
       mov       rcx,r15
       call      qword ptr [7FF9E5DC77F8]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       jmp       near ptr M07_L02
M07_L10:
       mov       rcx,r15
       mov       rax,[r15]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
       mov       r15d,eax
       jmp       near ptr M07_L03
M07_L11:
       xor       r15d,r15d
       jmp       near ptr M07_L04
M07_L12:
       xor       r15d,r15d
       jmp       near ptr M07_L03
M07_L13:
       mov       rcx,r14
       mov       rdx,rsi
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       near ptr M07_L04
M07_L14:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+80]
       test      r11,r11
       je        short M07_L15
       jmp       short M07_L16
M07_L15:
       mov       rdx,7FF9E6466410
       call      qword ptr [7FF9E5BFF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M07_L16:
       mov       rax,[rsp+28]
       mov       rdx,[rax]
       mov       rcx,r14
       mov       r8,rsi
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M07_L06
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
M07_L17:
       call      qword ptr [7FF9E5BFF498]
       int       3
M07_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 547
```
```assembly
; System.Collections.Frozen.FrozenSet.CreateFromSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,188
       xor       eax,eax
       mov       [rsp+0D8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+0E0],xmm4
       mov       [rsp+0F0],rax
       mov       [rsp+180],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rcx,[rbx]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rdx,offset MT_System.String
       cmp       [rcx],rdx
       je        near ptr M08_L53
       mov       rdi,[rbx+18]
       test      rdi,rdi
       je        near ptr M08_L56
M08_L00:
       mov       rcx,[rsi+18]
       mov       rdx,offset MT_System.String
       cmp       [rcx],rdx
       je        near ptr M08_L59
M08_L01:
       mov       ecx,[rbx+28]
       sub       ecx,[rbx+30]
       cmp       ecx,4
       jle       near ptr M08_L88
       mov       rcx,[rsi+18]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        near ptr M08_L08
M08_L02:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,[rbx]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rdx,offset MT_System.String
       cmp       [rcx],rdx
       je        near ptr M08_L91
       mov       rdx,[rbx+18]
       test      rdx,rdx
       je        near ptr M08_L94
M08_L03:
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+10],rcx
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx+8]
       mov       rax,[rdx+20]
       test      rax,rax
       je        near ptr M08_L09
M08_L04:
       lea       rcx,[rsi+10]
       mov       rdx,rsi
       call      rax
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx+10]
       mov       rdi,[rdx+28]
       test      rdi,rdi
       je        near ptr M08_L10
M08_L05:
       mov       rcx,rdi
       mov       ebp,[rbx+28]
       sub       ebp,[rbx+30]
       mov       [rsp+0D4],ebp
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       xor       r15d,r15d
       mov       r13d,ebp
       test      r13d,r13d
       jl        near ptr M08_L97
       mov       r12,[rbx+10]
       xor       eax,eax
       cmp       dword ptr [rbx+28],0
       jg        near ptr M08_L52
M08_L06:
       mov       rcx,rdi
       mov       edx,ebp
       call      CORINFO_HELP_NEWARR_1_PTR
       lea       rcx,[rsi+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,27403401D88
       mov       r13,[rcx]
       mov       [rsp+48],r13
       mov       rcx,r13
       mov       edx,ebp
       call      qword ptr [7FF9E6206990]; System.Buffers.SharedArrayPool`1[[System.Int32, System.Private.CoreLib]].Rent(Int32)
       mov       rbx,rax
       mov       [rsp+0C0],rbx
       mov       edi,ebp
       test      rbx,rbx
       je        near ptr M08_L98
       cmp       [rbx+8],edi
       jb        near ptr M08_L108
       lea       r15,[rbx+10]
M08_L07:
       xor       r12d,r12d
       cmp       ebp,r12d
       jg        near ptr M08_L18
       jmp       near ptr M08_L99
M08_L08:
       mov       rcx,rsi
       mov       rdx,7FF9E646DD28
       call      qword ptr [7FF9E5BFF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M08_L02
M08_L09:
       mov       rdx,7FF9E646F750
       call      qword ptr [7FF9E5BFF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M08_L04
M08_L10:
       mov       rdx,7FF9E646F678
       call      qword ptr [7FF9E5BFF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M08_L05
M08_L11:
       mov       rdx,7FF9E646F680
       call      qword ptr [7FF9E5BFF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M08_L12:
       mov       rcx,[rsi+8]
       mov       rdx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rdx
       jne       near ptr M08_L105
       mov       r8,[rsp+0B8]
       mov       rdx,[r8+28]
       test      rdx,rdx
       je        near ptr M08_L100
       mov       rcx,27403400068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M08_L104
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,0C33A731
       mov       r8d,25A0AD16
       cmp       edx,8
       jb        near ptr M08_L19
       mov       r9d,edx
       shr       r9d,3
M08_L13:
       add       eax,[rcx]
       mov       r11d,[rcx+4]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       add       r11d,eax
       mov       eax,r8d
       xor       eax,r11d
       rol       r11d,14
       add       r11d,eax
       rol       eax,9
       xor       eax,r11d
       rol       r11d,1B
       add       r11d,eax
       rol       eax,13
       mov       r8d,r11d
       add       rcx,8
       dec       r9d
       mov       r10d,eax
       mov       eax,r8d
       mov       r8d,r10d
       jne       short M08_L13
       test      dl,4
       jne       near ptr M08_L20
M08_L14:
       mov       r9d,edx
       and       r9,7
       mov       ecx,[rcx+r9-4]
       shr       ecx,8
       or        ecx,80000000
       not       edx
       shl       edx,3
       shrx      ecx,ecx,edx
M08_L15:
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
       mov       eax,ecx
       rol       eax,14
       add       eax,edx
       rol       edx,9
       xor       edx,eax
       rol       eax,1B
       add       eax,edx
       mov       r8d,edx
       rol       r8d,13
       xor       eax,r8d
M08_L16:
       mov       r10,[rsp+0B0]
M08_L17:
       mov       [r10],eax
       inc       r12d
       cmp       ebp,r12d
       jle       near ptr M08_L22
       mov       ebp,[rsp+0D4]
M08_L18:
       cmp       r12d,edi
       jae       near ptr M08_L154
       lea       rax,[r15+r12*4]
       mov       r8,[r14+r12*8+10]
       mov       [rsp+0B8],r8
       mov       [rsp+0B0],rax
       test      r8,r8
       je        short M08_L21
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx+10]
       mov       r11,[rdx+30]
       test      r11,r11
       je        near ptr M08_L11
       jmp       near ptr M08_L12
M08_L19:
       cmp       edx,4
       jb        near ptr M08_L101
M08_L20:
       add       eax,[rcx]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       jmp       near ptr M08_L14
       nop
M08_L21:
       mov       r10,rax
       xor       eax,eax
       jmp       near ptr M08_L17
M08_L22:
       mov       rcx,r15
       mov       r12d,edi
       mov       [rsp+0E8],rcx
       mov       [rsp+0F0],r12d
       lea       rcx,[rsp+0E8]
       xor       edx,edx
       call      qword ptr [7FF9E63D6940]; System.Collections.Frozen.FrozenHashTable.CalcNumBuckets(System.ReadOnlySpan`1<Int32>, Boolean)
       mov       r8d,eax
       mov       [rsp+158],r8d
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,r8d
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rsp+150],rax
       mov       rcx,r13
       lea       edx,[r8+r12]
       call      qword ptr [7FF9E6206990]; System.Buffers.SharedArrayPool`1[[System.Int32, System.Private.CoreLib]].Rent(Int32)
       mov       [rsp+0A8],rax
       test      rax,rax
       je        near ptr M08_L106
       mov       edx,[rsp+158]
       cmp       [rax+8],edx
       jb        near ptr M08_L108
       lea       r8,[rax+10]
       mov       r10d,edx
M08_L23:
       mov       [rsp+60],r8
       mov       [rsp+108],r10d
       test      rax,rax
       je        near ptr M08_L107
       mov       ecx,edx
       mov       r9d,r12d
       add       rcx,r9
       mov       r9d,[rax+8]
       cmp       rcx,r9
       ja        near ptr M08_L108
       mov       edx,edx
       lea       r9,[rax+rdx*4+10]
M08_L24:
       mov       [rsp+58],r9
       mov       [rsp+104],r12d
       mov       edx,r10d
       mov       rcx,rdx
       cmp       rcx,8
       jb        near ptr M08_L110
       lea       r11,[rcx*4]
       mov       [rsp+148],r11
       and       r11,0FFFFFFFFFFFFFFC0
       xor       r13d,r13d
       cmp       rcx,10
       jb        short M08_L26
M08_L25:
       vpcmpeqd  ymm0,ymm0,ymm0
       vmovups   [r8+r13],ymm0
       vmovups   [r8+r13+20],ymm0
       add       r13,40
       cmp       r13,r11
       jb        short M08_L25
M08_L26:
       mov       r11,[rsp+148]
       test      r11b,20
       jne       near ptr M08_L109
M08_L27:
       vpcmpeqd  ymm0,ymm0,ymm0
       vmovups   [r8+r11-20],ymm0
M08_L28:
       xor       ecx,ecx
       test      edi,edi
       jle       near ptr M08_L113
       cmp       edi,r12d
       jg        near ptr M08_L49
       jmp       short M08_L29
M08_L29:
       mov       r11d,ecx
       mov       r11d,[r15+r11*4]
       mov       r13,[rsp+150]
       imul      r11,r13
       shr       r11,20
       inc       r11
       imul      r11,rdx
       shr       r11,20
       cmp       r11d,r10d
       jae       near ptr M08_L154
       mov       r11d,r11d
       lea       r11,[r8+r11*4]
       mov       ebx,ecx
       mov       eax,[r11]
       mov       [r9+rbx*4],eax
       mov       [r11],ecx
       inc       ecx
       cmp       ecx,edi
       jl        short M08_L29
M08_L30:
       mov       edx,edi
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbx,rax
       mov       edx,[rsp+108]
       mov       rcx,offset MT_System.Collections.Frozen.FrozenHashTable+Bucket[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       [rsp+0A0],rax
       xor       ecx,ecx
       xor       edx,edx
       cmp       dword ptr [rax+8],0
       jle       near ptr M08_L38
       mov       r8d,[rsp+108]
       cmp       [rax+8],r8d
       jg        near ptr M08_L35
       jmp       short M08_L32
M08_L31:
       inc       edx
       cmp       [rax+8],edx
       jle       near ptr M08_L38
M08_L32:
       mov       r8d,edx
       mov       r10,[rsp+60]
       mov       r8d,[r10+r8*4]
       test      r8d,r8d
       jl        short M08_L31
       xor       r9d,r9d
       mov       r11d,ecx
M08_L33:
       cmp       r8d,edi
       jae       near ptr M08_L154
       mov       r13d,r8d
       lea       r13,[r15+r13*4]
       mov       r12d,[r13]
       cmp       ecx,[rbx+8]
       jae       near ptr M08_L154
       mov       ebp,ecx
       mov       [rbx+rbp*4+10],r12d
       mov       [r13],ecx
       inc       ecx
       inc       r9d
       cmp       r8d,[rsp+104]
       jae       near ptr M08_L154
       mov       r8d,r8d
       mov       rbp,[rsp+58]
       mov       r8d,[rbp+r8*4]
       test      r8d,r8d
       jge       short M08_L33
       mov       r12d,[rsp+104]
       mov       r13,[rsp+150]
       lea       r8d,[r11+r9-1]
       mov       r9d,edx
       lea       r9,[rax+r9*8+10]
       mov       [r9],r11d
       mov       [r9+4],r8d
       jmp       near ptr M08_L31
M08_L34:
       inc       edx
       cmp       [rax+8],edx
       mov       rax,[rsp+0A0]
       mov       r8d,[rsp+108]
       jle       near ptr M08_L38
M08_L35:
       cmp       edx,r8d
       jae       near ptr M08_L154
       mov       r11d,edx
       mov       r10,[rsp+60]
       mov       r11d,[r10+r11*4]
       test      r11d,r11d
       jl        short M08_L34
       xor       r9d,r9d
       mov       r12d,ecx
M08_L36:
       cmp       r11d,edi
       jae       near ptr M08_L154
       mov       r13d,r11d
       lea       r13,[r15+r13*4]
       mov       r8d,[r13]
       cmp       ecx,[rbx+8]
       jae       near ptr M08_L154
       mov       ebp,ecx
       mov       [rbx+rbp*4+10],r8d
       mov       [r13],ecx
       inc       ecx
       inc       r9d
       mov       ebp,[rsp+104]
       cmp       r11d,ebp
       jae       near ptr M08_L154
       mov       r11d,r11d
       mov       r13,[rsp+58]
       mov       r11d,[r13+r11*4]
       test      r11d,r11d
       jge       short M08_L36
       mov       r13,[rsp+150]
       lea       r9d,[r12+r9-1]
       mov       r11d,edx
       lea       r11,[rax+r11*8+10]
       mov       [r11],r12d
       mov       [r11+4],r9d
       mov       r12d,[rsp+104]
       jmp       near ptr M08_L34
M08_L37:
       cmp       ebx,edi
       jae       near ptr M08_L154
       mov       ecx,ebx
       mov       r13d,[r15+rcx*4]
       mov       rcx,[rsi+18]
       cmp       ebx,ebp
       jae       near ptr M08_L154
       mov       r8d,ebx
       mov       r8,[r14+r8*8+10]
       movsxd    rdx,r13d
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       inc       ebx
       cmp       ebx,edi
       jl        short M08_L37
       jmp       near ptr M08_L44
M08_L38:
       mov       r12,[rsp+48]
       mov       rdx,r12
       mov       [rsp+98],rdx
       mov       r8,[rsp+0A8]
       test      r8,r8
       je        near ptr M08_L136
       mov       rdx,[rsp+98]
       mov       ecx,[r8+8]
       dec       ecx
       or        ecx,0F
       xor       r10d,r10d
       lzcnt     r10d,ecx
       xor       r10d,1F
       add       r10d,0FFFFFFFD
       mov       [rsp+144],r10d
       mov       rcx,gs:[58]
       mov       rcx,[rcx+38]
       cmp       dword ptr [rcx+238],7
       jle       near ptr M08_L116
       mov       rcx,[rcx+240]
       mov       r9,[rcx+38]
       test      r9,r9
       je        near ptr M08_L115
M08_L39:
       mov       [rsp+50],r9
       mov       r11,[r9+10]
       test      r11,r11
       je        near ptr M08_L117
M08_L40:
       xor       ecx,ecx
       mov       dword ptr [rsp+13C],1
       mov       r10d,[rsp+144]
       cmp       [r11+8],r10d
       jbe       near ptr M08_L41
       mov       dword ptr [rsp+140],1
       mov       edx,10
       shlx      edx,edx,r10d
       mov       r8,[rsp+0A8]
       cmp       [r8+8],edx
       jne       near ptr M08_L118
       mov       edx,r10d
       shl       rdx,4
       lea       r11,[r11+rdx+10]
       mov       [rsp+88],r11
       mov       rdx,[r11]
       mov       [rsp+80],rdx
       mov       rcx,r11
       mov       rdx,r8
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       rdx,[rsp+88]
       mov       [rdx+8],ecx
       cmp       qword ptr [rsp+80],0
       jne       near ptr M08_L119
       mov       rax,[rsp+0A0]
       mov       ecx,[rsp+140]
       mov       r10d,[rsp+144]
M08_L41:
       mov       r11,27403400C90
       mov       r11,[r11]
       mov       [rsp+40],r11
       mov       rdx,r11
       mov       [rsp+90],rdx
       cmp       byte ptr [rdx+9D],0
       jne       near ptr M08_L132
M08_L42:
       lea       rcx,[rsi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+28]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rsi+30],r13
       xor       ebx,ebx
       test      edi,edi
       jle       short M08_L44
       mov       ebp,[rsp+0D4]
       cmp       ebp,edi
       jl        near ptr M08_L37
       xor       ebx,ebx
M08_L43:
       mov       r13d,[r15+rbx]
       mov       rcx,[rsi+18]
       mov       r8,[r14+rbx*2+10]
       movsxd    rdx,r13d
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       add       rbx,4
       dec       edi
       jne       short M08_L43
M08_L44:
       mov       rbx,[rsp+0C0]
       test      rbx,rbx
       je        near ptr M08_L136
       mov       ecx,[rbx+8]
       dec       ecx
       or        ecx,0F
       xor       edi,edi
       lzcnt     edi,ecx
       xor       edi,1F
       add       edi,0FFFFFFFD
       mov       rbp,[rsp+50]
       mov       rax,[rbp+10]
       test      rax,rax
       je        near ptr M08_L137
M08_L45:
       xor       ebp,ebp
       mov       r14d,1
       cmp       [rax+8],edi
       jbe       short M08_L46
       mov       ebp,1
       mov       ecx,10
       shlx      ecx,ecx,edi
       cmp       [rbx+8],ecx
       jne       near ptr M08_L138
       cmp       edi,[rax+8]
       jae       near ptr M08_L154
       mov       ecx,edi
       shl       rcx,4
       lea       r15,[rax+rcx+10]
       mov       r13,[r15]
       mov       rcx,r15
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r15+8],ecx
       test      r13,r13
       jne       near ptr M08_L139
M08_L46:
       mov       r15,[rsp+40]
       cmp       byte ptr [r15+9D],0
       jne       near ptr M08_L151
M08_L47:
       mov       rax,rsi
       vzeroupper
       add       rsp,188
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M08_L48:
       mov       r8,[rsp+60]
       mov       r9,[rsp+58]
       mov       r10d,[rsp+108]
M08_L49:
       mov       r11d,ecx
       mov       r11d,[r15+r11*4]
       imul      r11,[rsp+150]
       shr       r11,20
       inc       r11
       imul      r11,rdx
       shr       r11,20
       cmp       r11d,r10d
       jae       near ptr M08_L154
       mov       r11d,r11d
       lea       r11,[r8+r11*4]
       cmp       ecx,r12d
       jae       near ptr M08_L154
       mov       ebx,ecx
       mov       [rsp+178],rbx
       mov       ebx,[r11]
       mov       rax,[rsp+178]
       mov       [r9+rax*4],ebx
       mov       [r11],ecx
       inc       ecx
       cmp       ecx,edi
       mov       r12d,[rsp+104]
       jl        short M08_L48
       jmp       near ptr M08_L114
M08_L50:
       lea       edx,[r15+1]
       mov       [rsp+15C],edx
       mov       r8,[r8]
       movsxd    rdx,r15d
       mov       rcx,r14
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       dec       r13d
       mov       r15d,[rsp+15C]
M08_L51:
       mov       rax,[rsp+0C8]
       inc       eax
       mov       rcx,rax
       cmp       ecx,[rbx+28]
       mov       rax,rcx
       jge       near ptr M08_L06
M08_L52:
       test      r13d,r13d
       je        near ptr M08_L06
       cmp       eax,[r12+8]
       jae       near ptr M08_L154
       mov       [rsp+0C8],rax
       mov       r8,rax
       shl       r8,4
       lea       r8,[r12+r8+10]
       cmp       dword ptr [r8+0C],0FFFFFFFF
       jl        short M08_L51
       jmp       short M08_L50
M08_L53:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdi,[rdx+0A0]
       test      rdi,rdi
       je        short M08_L54
       jmp       short M08_L55
M08_L54:
       mov       rdx,7FF9E646B9C0
       call      qword ptr [7FF9E5BFF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
M08_L55:
       mov       rdx,[rbx+18]
       mov       rcx,offset MT_System.Collections.Generic.IEqualityComparer<System.String>
       call      qword ptr [7FF9E5BF58D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rcx,rax
       call      qword ptr [7FF9E63DFC48]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF9E5BF58D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdi,rax
       jmp       near ptr M08_L00
M08_L56:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+0A8]
       test      rdx,rdx
       je        short M08_L57
       jmp       short M08_L58
M08_L57:
       mov       rdx,7FF9E646B9D0
       call      qword ptr [7FF9E5BFF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M08_L58:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdi,[rax]
       jmp       near ptr M08_L00
M08_L59:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF9E5DC7810]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       test      eax,eax
       jge       near ptr M08_L01
       mov       rcx,[rsi+18]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       je        short M08_L60
       jmp       short M08_L61
M08_L60:
       mov       rcx,rsi
       mov       rdx,7FF9E646EBE0
       call      qword ptr [7FF9E5BFF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M08_L61:
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       cmp       [rax],rdi
       je        short M08_L62
       mov       rdx,27403400068
       cmp       rdi,[rdx]
       je        short M08_L62
       mov       rdx,27403400070
       cmp       rdi,[rdx]
       jne       near ptr M08_L01
M08_L62:
       mov       rdx,rdi
       mov       rcx,offset MT_System.Collections.Generic.IEqualityComparer<System.String>
       call      qword ptr [7FF9E5BF58D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdi,rax
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.HashSet<System.String>
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       rbx,rax
       mov       edx,[rbx+28]
       sub       edx,[rbx+30]
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbp,rax
       mov       r9d,[rbx+28]
       sub       r9d,[rbx+30]
       mov       rcx,rbx
       mov       rdx,rbp
       xor       r8d,r8d
       call      qword ptr [7FF9E5F6DA28]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].CopyTo(System.__Canon[], Int32, Int32)
       mov       ebx,7FFFFFFF
       xor       r14d,r14d
       xor       r15d,r15d
       xor       ecx,ecx
       jmp       short M08_L66
M08_L63:
       mov       rdx,[rbp+rcx*8+10]
       cmp       [rdx+8],ebx
       jge       short M08_L64
       mov       ebx,[rdx+8]
M08_L64:
       cmp       [rdx+8],r14d
       jle       short M08_L65
       mov       r14d,[rdx+8]
M08_L65:
       mov       edx,[rdx+8]
       mov       r8d,1
       shlx      rdx,r8,rdx
       or        r15,rdx
       inc       ecx
M08_L66:
       cmp       [rbp+8],ecx
       jg        short M08_L63
       mov       rcx,rbp
       mov       rdx,rdi
       mov       r8d,ebx
       mov       r9d,r14d
       call      qword ptr [7FF9E64A45B8]
       mov       r13,rax
       test      r13,r13
       je        short M08_L69
       mov       rcx,[rsi+18]
       cmp       qword ptr [rcx+8],30
       jle       short M08_L67
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M08_L67
       jmp       short M08_L68
M08_L67:
       mov       rcx,rsi
       mov       rdx,7FF9E646EFD8
       call      qword ptr [7FF9E5BFF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M08_L68:
       mov       rdx,r13
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       nop
       vzeroupper
       add       rsp,188
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M08_L69:
       lea       rdx,[rbp+10]
       mov       r8d,[rbp+8]
       mov       [rsp+0D8],rdx
       mov       [rsp+0E0],r8d
       mov       [rsp+20],r14d
       lea       rdx,[rsp+0D8]
       mov       r8,27403400070
       cmp       rdi,[r8]
       sete      r8b
       movzx     r8d,r8b
       lea       rcx,[rsp+160]
       mov       r9d,ebx
       call      qword ptr [7FF9E64A45D0]
       mov       ebx,[rsp+168]
       movzx     r14d,byte ptr [rsp+160]
       movzx     r12d,byte ptr [rsp+161]
       mov       r13d,[rsp+164]
       mov       eax,[rsp+16C]
       mov       [rsp+100],eax
       mov       edx,[rsp+170]
       mov       [rsp+0FC],edx
       test      ebx,ebx
       je        near ptr M08_L81
       test      r13d,r13d
       jge       near ptr M08_L75
       test      r14d,r14d
       je        near ptr M08_L72
       test      r12d,r12d
       jne       short M08_L70
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_RightJustifiedCaseInsensitiveSubstring
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       r15d,[rsp+0FC]
       mov       [rsp+20],r15d
       mov       [rsp+28],r13d
       mov       [rsp+30],ebx
       mov       rcx,r14
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+100]
       call      qword ptr [7FF9E64A45E8]
       jmp       short M08_L71
M08_L70:
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_RightJustifiedCaseInsensitiveAsciiSubstring
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       r15d,[rsp+0FC]
       mov       [rsp+20],r15d
       mov       [rsp+28],r13d
       mov       [rsp+30],ebx
       mov       rcx,r14
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+100]
       call      qword ptr [7FF9E64A45E8]
M08_L71:
       mov       r13,r14
       jmp       near ptr M08_L85
M08_L72:
       cmp       ebx,1
       je        short M08_L73
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_RightJustifiedSubstring
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       r15d,[rsp+0FC]
       mov       [rsp+20],r15d
       mov       [rsp+28],r13d
       mov       [rsp+30],ebx
       mov       rcx,r12
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+100]
       call      qword ptr [7FF9E64A45E8]
       jmp       short M08_L74
M08_L73:
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_RightJustifiedSingleChar
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       r15d,[rsp+0FC]
       mov       [rsp+20],r15d
       mov       [rsp+28],r13d
       mov       dword ptr [rsp+30],1
       mov       rcx,r12
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+100]
       call      qword ptr [7FF9E64A45E8]
M08_L74:
       mov       r13,r12
       jmp       near ptr M08_L85
M08_L75:
       test      r14d,r14d
       je        near ptr M08_L78
       test      r12d,r12d
       jne       short M08_L76
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_LeftJustifiedCaseInsensitiveSubstring
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       r15d,[rsp+0FC]
       mov       [rsp+20],r15d
       mov       [rsp+28],r13d
       mov       [rsp+30],ebx
       mov       rcx,r14
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+100]
       call      qword ptr [7FF9E64A45E8]
       jmp       short M08_L77
M08_L76:
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_LeftJustifiedCaseInsensitiveAsciiSubstring
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       r15d,[rsp+0FC]
       mov       [rsp+20],r15d
       mov       [rsp+28],r13d
       mov       [rsp+30],ebx
       mov       rcx,r14
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+100]
       call      qword ptr [7FF9E64A45E8]
M08_L77:
       mov       r13,r14
       jmp       near ptr M08_L85
M08_L78:
       cmp       ebx,1
       je        short M08_L79
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_LeftJustifiedSubstring
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       r15d,[rsp+0FC]
       mov       [rsp+20],r15d
       mov       [rsp+28],r13d
       mov       [rsp+30],ebx
       mov       rcx,r12
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+100]
       call      qword ptr [7FF9E64A45E8]
       jmp       short M08_L80
M08_L79:
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_LeftJustifiedSingleChar
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       r15d,[rsp+0FC]
       mov       [rsp+20],r15d
       mov       [rsp+28],r13d
       mov       dword ptr [rsp+30],1
       mov       rcx,r12
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+100]
       call      qword ptr [7FF9E64A45E8]
M08_L80:
       mov       r13,r12
       jmp       near ptr M08_L85
M08_L81:
       test      r14d,r14d
       je        short M08_L84
       test      r12d,r12d
       jne       short M08_L82
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_FullCaseInsensitive
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       ebx,[rsp+0FC]
       mov       [rsp+20],ebx
       mov       [rsp+28],r15
       mov       rcx,r13
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+100]
       call      qword ptr [7FF9E64A4600]
       jmp       short M08_L83
M08_L82:
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_FullCaseInsensitiveAscii
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       ebx,[rsp+0FC]
       mov       [rsp+20],ebx
       mov       [rsp+28],r15
       mov       rcx,r13
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+100]
       call      qword ptr [7FF9E64A4618]
M08_L83:
       jmp       short M08_L85
M08_L84:
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_Full
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       ebx,[rsp+0FC]
       mov       [rsp+20],ebx
       mov       [rsp+28],r15
       mov       rcx,r13
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+100]
       call      qword ptr [7FF9E64A4630]
M08_L85:
       mov       rcx,[rsi+18]
       cmp       qword ptr [rcx+8],30
       jle       short M08_L86
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M08_L86
       jmp       short M08_L87
M08_L86:
       mov       rcx,rsi
       mov       rdx,7FF9E646EFD8
       call      qword ptr [7FF9E5BFF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M08_L87:
       mov       rdx,r13
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       nop
       vzeroupper
       add       rsp,188
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M08_L88:
       mov       rcx,[rsi+18]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M08_L89
       jmp       short M08_L90
M08_L89:
       mov       rcx,rsi
       mov       rdx,7FF9E646EAC0
       call      qword ptr [7FF9E5BFF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M08_L90:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF9E64A5218]
       mov       rax,rsi
       vzeroupper
       add       rsp,188
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M08_L91:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdi,[rdx+0A0]
       test      rdi,rdi
       je        short M08_L92
       jmp       short M08_L93
M08_L92:
       mov       rdx,7FF9E646B9C0
       call      qword ptr [7FF9E5BFF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
M08_L93:
       mov       rdx,[rbx+18]
       mov       rcx,offset MT_System.Collections.Generic.IEqualityComparer<System.String>
       call      qword ptr [7FF9E5BF58D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rcx,rax
       call      qword ptr [7FF9E63DFC48]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF9E5BF58D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdx,rax
       jmp       near ptr M08_L03
M08_L94:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+0A8]
       test      rdx,rdx
       je        short M08_L95
       jmp       short M08_L96
M08_L95:
       mov       rdx,7FF9E646B9D0
       call      qword ptr [7FF9E5BFF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M08_L96:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       jmp       near ptr M08_L03
M08_L97:
       mov       ecx,28F
       mov       rdx,7FF9E5B34000
       call      qword ptr [7FF9E5BFF228]
       mov       rdx,rax
       mov       ecx,r13d
       call      qword ptr [7FF9E63DDB18]
       int       3
M08_L98:
       test      edi,edi
       jne       near ptr M08_L108
       xor       r15d,r15d
       xor       edi,edi
       jmp       near ptr M08_L07
M08_L99:
       jmp       near ptr M08_L22
M08_L100:
       xor       eax,eax
       jmp       near ptr M08_L16
M08_L101:
       mov       r9d,80
       test      dl,1
       je        short M08_L102
       mov       r9d,edx
       and       r9,2
       movzx     r9d,byte ptr [rcx+r9]
       or        r9d,8000
M08_L102:
       test      dl,2
       je        short M08_L103
       shl       r9d,10
       movzx     ecx,word ptr [rcx]
       or        r9d,ecx
       mov       ecx,r9d
       jmp       near ptr M08_L15
M08_L103:
       mov       ecx,r9d
       jmp       near ptr M08_L15
M08_L104:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       jmp       near ptr M08_L16
M08_L105:
       mov       r8,[rsp+0B8]
       mov       rdx,r8
       call      qword ptr [r11]
       jmp       near ptr M08_L16
M08_L106:
       mov       edx,[rsp+158]
       test      edx,edx
       jne       short M08_L108
       xor       r8d,r8d
       xor       r10d,r10d
       jmp       near ptr M08_L23
M08_L107:
       or        edx,r12d
       jne       short M08_L108
       xor       r9d,r9d
       xor       r12d,r12d
       mov       ecx,r9d
       mov       r9,r12
       mov       r12d,ecx
       jmp       near ptr M08_L24
M08_L108:
       call      qword ptr [7FF9E5DCF228]
       int       3
M08_L109:
       vpcmpeqd  ymm0,ymm0,ymm0
       vmovups   [r8+r13],ymm0
       jmp       near ptr M08_L27
M08_L110:
       xor       r11d,r11d
       test      cl,4
       je        short M08_L111
       mov       dword ptr [r8+r11*4],0FFFFFFFF
       mov       dword ptr [r8+r11*4+4],0FFFFFFFF
       mov       dword ptr [r8+r11*4+8],0FFFFFFFF
       mov       dword ptr [r8+r11*4+0C],0FFFFFFFF
       add       r11,4
M08_L111:
       test      cl,2
       je        short M08_L112
       mov       dword ptr [r8+r11*4],0FFFFFFFF
       mov       dword ptr [r8+r11*4+4],0FFFFFFFF
       add       r11,2
M08_L112:
       test      cl,1
       je        near ptr M08_L28
       mov       dword ptr [r8+r11*4],0FFFFFFFF
       jmp       near ptr M08_L28
M08_L113:
       mov       r13,[rsp+150]
       jmp       near ptr M08_L30
M08_L114:
       mov       r13,[rsp+150]
       jmp       near ptr M08_L30
M08_L115:
       mov       ecx,7
       call      qword ptr [7FF9E63DDD70]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       r9,rax
       mov       rax,[rsp+0A0]
       mov       rdx,[rsp+98]
       jmp       near ptr M08_L39
M08_L116:
       jmp       short M08_L115
M08_L117:
       mov       rcx,rdx
       call      qword ptr [7FF9E619F420]; System.Buffers.SharedArrayPool`1[[System.Int32, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
       mov       r11,rax
       mov       rax,[rsp+0A0]
       jmp       near ptr M08_L40
M08_L118:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9E622EE68]
       mov       rbx,rax
       mov       ecx,29B
       mov       rdx,7FF9E5B34000
       call      qword ptr [7FF9E5BFF228]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9E5F67D50]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M08_L119:
       mov       r8,[rsp+98]
       mov       rcx,[r8+10]
       mov       r10d,[rsp+144]
       cmp       r10d,[rcx+8]
       jae       near ptr M08_L154
       mov       edx,r10d
       mov       r9,[rcx+rdx*8+10]
       test      r9,r9
       jne       short M08_L121
       mov       rcx,r8
       mov       edx,r10d
       call      qword ptr [7FF9E63DFC30]
       mov       r9,rax
M08_L120:
       mov       rcx,[r9+8]
       mov       [rsp+78],rcx
       call      qword ptr [7FF9E622F438]; System.Threading.Thread.GetCurrentProcessorNumber()
       mov       ecx,0AAAAAAAB
       mov       edx,eax
       imul      rcx,rdx
       shr       rcx,23
       imul      ecx,0C
       sub       eax,ecx
       xor       edx,edx
       jmp       near ptr M08_L128
M08_L121:
       jmp       short M08_L120
M08_L122:
       cmp       eax,[r8+8]
       jae       near ptr M08_L154
       mov       [rsp+128],eax
       mov       ecx,eax
       mov       r10,[r8+rcx*8+10]
       mov       [rsp+70],r10
       cmp       [r10],r10b
       xor       r9d,r9d
       mov       [rsp+120],r9d
       mov       rcx,r10
       call      qword ptr [7FF9E611E2B0]; System.Threading.Monitor.Enter(System.Object)
       mov       rax,[rsp+70]
       mov       rcx,[rax+8]
       mov       r8d,[rax+10]
       mov       [rsp+11C],r8d
       cmp       [rcx+8],r8d
       jbe       short M08_L124
       test      r8d,r8d
       jne       short M08_L125
       xor       edx,edx
       mov       [rax+14],edx
M08_L123:
       movsxd    rdx,r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,[rsp+80]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rsp+11C]
       inc       ecx
       mov       rax,[rsp+70]
       mov       [rax+10],ecx
       mov       dword ptr [rsp+120],1
M08_L124:
       mov       rcx,rax
       call      qword ptr [7FF9E5BF6820]; System.Threading.Monitor.Exit(System.Object)
       cmp       dword ptr [rsp+120],0
       je        short M08_L126
       jmp       short M08_L129
M08_L125:
       jmp       short M08_L123
M08_L126:
       mov       eax,[rsp+128]
       inc       eax
       mov       ecx,eax
       mov       r8,[rsp+78]
       cmp       [r8+8],ecx
       jne       short M08_L127
       xor       ecx,ecx
M08_L127:
       mov       edx,[rsp+124]
       inc       edx
       mov       eax,ecx
M08_L128:
       mov       r8,[rsp+78]
       mov       [rsp+124],edx
       cmp       [r8+8],edx
       jg        near ptr M08_L122
       jmp       short M08_L130
M08_L129:
       mov       edx,1
       jmp       short M08_L131
M08_L130:
       xor       edx,edx
M08_L131:
       mov       [rsp+13C],edx
       mov       rax,[rsp+0A0]
       mov       ecx,[rsp+140]
       mov       r10d,[rsp+144]
       jmp       near ptr M08_L41
M08_L132:
       mov       r8,[rsp+0A8]
       cmp       dword ptr [r8+8],0
       mov       [rsp+140],ecx
       je        near ptr M08_L42
       mov       rcx,r8
       call      qword ptr [7FF9E601D740]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+138],eax
       mov       rdx,[rsp+0A8]
       mov       r8d,[rdx+8]
       mov       [rsp+134],r8d
       mov       rcx,[rsp+98]
       call      qword ptr [7FF9E601D740]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,[rsp+90]
       mov       r8d,[rsp+138]
       mov       r9d,[rsp+134]
       mov       edx,3
       call      qword ptr [7FF9E63DF858]
       mov       eax,[rsp+140]
       test      [rsp+13C],eax
       jne       short M08_L133
       mov       rcx,[rsp+0A8]
       call      qword ptr [7FF9E601D740]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+130],eax
       mov       rcx,[rsp+0A8]
       mov       edx,[rcx+8]
       mov       [rsp+12C],edx
       mov       rcx,[rsp+98]
       call      qword ptr [7FF9E601D740]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       cmp       dword ptr [rsp+140],0
       jne       short M08_L134
       mov       ecx,0FFFFFFFF
       mov       edx,1
       jmp       short M08_L135
M08_L133:
       mov       rax,[rsp+0A0]
       jmp       near ptr M08_L42
M08_L134:
       mov       ecx,[rsp+144]
       xor       edx,edx
M08_L135:
       mov       [rsp+20],ecx
       mov       [rsp+28],edx
       mov       rcx,[rsp+90]
       mov       edx,[rsp+130]
       mov       r8d,[rsp+12C]
       call      qword ptr [7FF9E622EEE0]
       mov       rax,[rsp+0A0]
       jmp       near ptr M08_L42
M08_L136:
       mov       ecx,2
       call      qword ptr [7FF9E5BFFD50]
       int       3
M08_L137:
       mov       rcx,r12
       call      qword ptr [7FF9E619F420]; System.Buffers.SharedArrayPool`1[[System.Int32, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
       jmp       near ptr M08_L45
M08_L138:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9E622EE68]
       mov       r12,rax
       mov       ecx,29B
       mov       rdx,7FF9E5B34000
       call      qword ptr [7FF9E5BFF228]
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,rbx
       call      qword ptr [7FF9E5F67D50]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M08_L139:
       mov       rcx,[r12+10]
       cmp       edi,[rcx+8]
       jae       near ptr M08_L154
       mov       edx,edi
       mov       rax,[rcx+rdx*8+10]
       test      rax,rax
       jne       short M08_L140
       mov       rcx,r12
       mov       edx,edi
       call      qword ptr [7FF9E63DFC30]
M08_L140:
       mov       r14,[rax+8]
       call      qword ptr [7FF9E622F438]; System.Threading.Thread.GetCurrentProcessorNumber()
       mov       ecx,0AAAAAAAB
       mov       edx,eax
       imul      rcx,rdx
       shr       rcx,23
       imul      ecx,0C
       mov       r15d,eax
       sub       r15d,ecx
       xor       eax,eax
       jmp       near ptr M08_L147
M08_L141:
       cmp       r15d,[r14+8]
       jae       near ptr M08_L154
       mov       ecx,r15d
       mov       rdx,[r14+rcx*8+10]
       mov       [rsp+68],rdx
       cmp       [rdx],dl
       xor       r8d,r8d
       mov       [rsp+110],r8d
       mov       rcx,rdx
       call      qword ptr [7FF9E611E2B0]; System.Threading.Monitor.Enter(System.Object)
       mov       rax,[rsp+68]
       mov       rcx,[rax+8]
       mov       r8d,[rax+10]
       mov       [rsp+10C],r8d
       cmp       [rcx+8],r8d
       jbe       short M08_L143
       test      r8d,r8d
       jne       short M08_L144
       xor       edx,edx
       mov       [rax+14],edx
M08_L142:
       movsxd    rdx,r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rsp+10C]
       inc       ecx
       mov       rax,[rsp+68]
       mov       [rax+10],ecx
       mov       dword ptr [rsp+110],1
M08_L143:
       mov       rcx,rax
       call      qword ptr [7FF9E5BF6820]; System.Threading.Monitor.Exit(System.Object)
       cmp       dword ptr [rsp+110],0
       je        short M08_L145
       jmp       short M08_L148
M08_L144:
       jmp       short M08_L142
M08_L145:
       inc       r15d
       cmp       [r14+8],r15d
       jne       short M08_L146
       xor       r15d,r15d
M08_L146:
       mov       eax,[rsp+114]
       inc       eax
M08_L147:
       mov       [rsp+114],eax
       cmp       [r14+8],eax
       jg        near ptr M08_L141
       jmp       short M08_L149
M08_L148:
       mov       r14d,1
       jmp       short M08_L150
M08_L149:
       xor       r14d,r14d
M08_L150:
       jmp       near ptr M08_L46
M08_L151:
       cmp       dword ptr [rbx+8],0
       je        near ptr M08_L47
       mov       rcx,rbx
       call      qword ptr [7FF9E601D740]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r13d,eax
       mov       eax,[rbx+8]
       mov       [rsp+118],eax
       mov       rcx,r12
       call      qword ptr [7FF9E601D740]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,r15
       mov       r8d,r13d
       mov       r9d,[rsp+118]
       mov       edx,3
       call      qword ptr [7FF9E63DF858]
       test      r14d,ebp
       jne       near ptr M08_L47
       mov       rcx,rbx
       call      qword ptr [7FF9E601D740]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r14d,eax
       mov       ebx,[rbx+8]
       mov       rcx,r12
       call      qword ptr [7FF9E601D740]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       test      ebp,ebp
       jne       short M08_L152
       mov       ecx,0FFFFFFFF
       mov       edx,1
       jmp       short M08_L153
M08_L152:
       mov       ecx,edi
       xor       edx,edx
M08_L153:
       mov       [rsp+20],ecx
       mov       [rsp+28],edx
       mov       rcx,r15
       mov       edx,r14d
       mov       r8d,ebx
       call      qword ptr [7FF9E622EEE0]
       jmp       near ptr M08_L47
M08_L154:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 6085
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
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       test      rbx,rbx
       je        near ptr M10_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M10_L01
       test      rsi,rsi
       je        short M10_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M10_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M10_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFA45879D30
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF9E5BF5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF9E5BF5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
M10_L00:
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
M10_L01:
       test      rsi,rsi
       je        short M10_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M10_L03
M10_L02:
       mov       rax,2B498570008
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M10_L03:
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
M10_L04:
       call      qword ptr [7FF9E63DF570]
       int       3
; Total bytes of code 244
```
```assembly
; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].get_Comparer()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       rcx,[rbx]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rdx,offset MT_System.String
       cmp       [rcx],rdx
       je        short M11_L01
       mov       rax,[rbx+18]
       test      rax,rax
       je        short M11_L04
M11_L00:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M11_L01:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rsi,[rdx+0A0]
       test      rsi,rsi
       je        short M11_L02
       jmp       short M11_L03
M11_L02:
       mov       rdx,7FF9E646B9C0
       call      qword ptr [7FF9E5BFF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rsi,rax
M11_L03:
       mov       rdx,[rbx+18]
       mov       rcx,offset MT_System.Collections.Generic.IEqualityComparer<System.String>
       call      qword ptr [7FF9E5BF58D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rcx,rax
       call      qword ptr [7FF9E63DFC48]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9E5BF58D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M11_L04:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+0A8]
       test      rdx,rdx
       je        short M11_L05
       jmp       short M11_L06
M11_L05:
       mov       rdx,7FF9E646B9D0
       call      qword ptr [7FF9E5BFF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M11_L06:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rax]
       jmp       near ptr M11_L00
; Total bytes of code 206
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M12_L00
       ret
M12_L00:
       jmp       qword ptr [7FF9E5BF5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.ToFrozenSet()
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
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-70],xmm4
       xor       eax,eax
       mov       [rbp-60],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       test      rsi,rsi
       je        near ptr M00_L44
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L46
       mov       rcx,[rsi+8]
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],r11
       jne       near ptr M00_L45
       mov       edi,[rcx+10]
M00_L00:
       test      edi,edi
       je        near ptr M00_L59
       mov       rdx,18F4B400A20
       mov       rdi,[rdx]
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Frozen.FrozenSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r14,rax
       test      r14,r14
       jne       near ptr M00_L47
M00_L01:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Generic.HashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r14,rax
       mov       r15,r14
       test      r15,r15
       jne       near ptr M00_L48
M00_L02:
       mov       rcx,offset MT_System.Collections.Generic.HashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       lea       rcx,[r15+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       test      r14,r14
       jne       near ptr M00_L49
M00_L03:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L51
       mov       rcx,[rsi+8]
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],r11
       jne       near ptr M00_L50
       mov       ecx,[rcx+10]
M00_L04:
       test      ecx,ecx
       jle       short M00_L05
       call      qword ptr [7FF9E5BD5A88]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       r14d,eax
       movsxd    rdx,r14d
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r13,rax
       movsxd    rdx,r14d
       mov       rcx,offset MT_System.Collections.Generic.HashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Entry[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r12,rax
       mov       dword ptr [r15+2C],0FFFFFFFF
       lea       rcx,[r15+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,r14d
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [r15+20],rax
M00_L05:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L54
       mov       rsi,[rsi+8]
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L53
       cmp       dword ptr [rsi+10],0
       je        near ptr M00_L52
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       r13d,[rsi+14]
       lea       rcx,[r14+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r14+10],rcx
       mov       [r14+18],r13d
       mov       [r14+1C],ecx
M00_L06:
       mov       [rbp-78],r14
M00_L07:
       mov       rdx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rcx,[rbp-78]
       cmp       [rcx],rdx
       jne       near ptr M00_L36
       mov       rdx,[rcx]
       add       rcx,8
       call      qword ptr [7FF9E5E6C150]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L08:
       test      eax,eax
       je        near ptr M00_L39
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-78]
       cmp       [rax],rcx
       jne       near ptr M00_L24
       mov       rsi,[rax+10]
M00_L09:
       cmp       qword ptr [r15+8],0
       je        near ptr M00_L25
M00_L10:
       mov       r14,[r15+10]
       mov       r13,[r15+18]
       xor       r12d,r12d
       test      rsi,rsi
       je        near ptr M00_L20
       mov       rcx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r13],rcx
       jne       near ptr M00_L32
       mov       rdx,[rsi+28]
       test      rdx,rdx
       je        near ptr M00_L26
       mov       rcx,18F35400068
       mov       rcx,[rcx]
       mov       r8,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],r8
       jne       near ptr M00_L31
       lea       rcx,[rdx+0C]
       mov       r8d,[rdx+8]
       add       r8d,r8d
       mov       [rbp-44],r8d
       mov       dword ptr [rbp-50],109E73A0
       mov       dword ptr [rbp-58],2A12B45D
       cmp       r8d,8
       jb        near ptr M00_L18
       mov       edx,r8d
       shr       edx,3
       xchg      ax,ax
M00_L11:
       mov       r10d,[rbp-50]
       add       r10d,[rcx]
       mov       [rbp-50],r10d
       mov       r10d,[rcx+4]
       mov       r9d,[rbp-50]
       mov       r11d,[rbp-58]
       xor       r11d,r9d
       rol       r9d,14
       add       r9d,r11d
       rol       r11d,9
       xor       r11d,r9d
       rol       r9d,1B
       add       r9d,r11d
       rol       r11d,13
       mov       [rbp-50],r9d
       mov       [rbp-58],r11d
       add       r10d,[rbp-50]
       mov       [rbp-50],r10d
       mov       r10d,[rbp-50]
       mov       r9d,[rbp-58]
       xor       r9d,r10d
       rol       r10d,14
       add       r10d,r9d
       rol       r9d,9
       xor       r9d,r10d
       rol       r10d,1B
       add       r10d,r9d
       rol       r9d,13
       mov       [rbp-50],r10d
       mov       [rbp-58],r9d
       add       rcx,8
       dec       edx
       jne       short M00_L11
       test      r8b,4
       jne       near ptr M00_L27
M00_L12:
       mov       edx,r8d
       and       rdx,7
       mov       ecx,[rcx+rdx-4]
       shr       ecx,8
       or        ecx,80000000
       not       r8d
       shl       r8d,3
       shrx      ecx,ecx,r8d
M00_L13:
       add       ecx,[rbp-50]
       mov       [rbp-50],ecx
       lea       rcx,[rbp-50]
       lea       rdx,[rbp-58]
       call      qword ptr [7FF9E6475338]; System.Marvin.Block(UInt32 ByRef, UInt32 ByRef)
       lea       rcx,[rbp-50]
       lea       rdx,[rbp-58]
       call      qword ptr [7FF9E6475338]; System.Marvin.Block(UInt32 ByRef, UInt32 ByRef)
       mov       eax,[rbp-58]
       xor       eax,[rbp-50]
M00_L14:
       mov       [rbp-3C],eax
       mov       rdx,[r15+8]
       mov       ecx,eax
       imul      rcx,[r15+20]
       shr       rcx,20
       inc       rcx
       mov       r8d,[rdx+8]
       mov       r11d,r8d
       imul      rcx,r11
       shr       rcx,20
       cmp       ecx,r8d
       jae       near ptr M00_L38
       mov       ecx,ecx
       lea       r10,[rdx+rcx*4+10]
       mov       [rbp-88],r10
       mov       r9d,[r10]
       dec       r9d
       jns       near ptr M00_L21
M00_L15:
       cmp       dword ptr [r15+30],0
       jg        near ptr M00_L23
       mov       edx,[r15+28]
       mov       [rbp-40],edx
       cmp       [r14+8],edx
       je        near ptr M00_L34
M00_L16:
       mov       edx,[rbp-40]
       mov       r14d,edx
       lea       ecx,[r14+1]
       mov       [r15+28],ecx
       mov       rcx,[r15+10]
       mov       r8,rcx
M00_L17:
       cmp       r14d,[r8+8]
       jae       near ptr M00_L38
       mov       ecx,r14d
       shl       rcx,4
       mov       [rbp-80],r8
       lea       rcx,[r8+rcx+10]
       mov       [rcx+8],eax
       mov       r10,[rbp-88]
       mov       edx,[r10]
       dec       edx
       mov       [rcx+0C],edx
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       inc       r14d
       mov       rdx,[rbp-88]
       mov       [rdx],r14d
       inc       dword ptr [r15+34]
       cmp       r12d,64
       jbe       near ptr M00_L07
       jmp       near ptr M00_L35
M00_L18:
       cmp       r8d,4
       jb        near ptr M00_L28
M00_L19:
       mov       edx,[rbp-50]
       mov       [rbp-98],rcx
       add       edx,[rcx]
       mov       [rbp-50],edx
       lea       rcx,[rbp-50]
       lea       rdx,[rbp-58]
       call      qword ptr [7FF9E6475338]; System.Marvin.Block(UInt32 ByRef, UInt32 ByRef)
       mov       rax,[rbp-78]
       mov       rcx,[rbp-98]
       mov       r8d,[rbp-44]
       jmp       near ptr M00_L12
M00_L20:
       xor       edx,edx
       xor       r10d,r10d
       mov       eax,r10d
       jmp       near ptr M00_L14
M00_L21:
       cmp       r9d,[r14+8]
       jae       near ptr M00_L38
       mov       edx,r9d
       shl       rdx,4
       lea       r9,[r14+rdx+10]
       mov       [rbp-90],r9
       cmp       [r9+8],eax
       je        near ptr M00_L33
M00_L22:
       mov       r9d,[r9+0C]
       inc       r12d
       cmp       [r14+8],r12d
       jb        near ptr M00_L37
       test      r9d,r9d
       mov       eax,[rbp-3C]
       jge       short M00_L21
       jmp       near ptr M00_L15
M00_L23:
       mov       ecx,[r15+2C]
       mov       r8d,ecx
       dec       dword ptr [r15+30]
       cmp       ecx,[r14+8]
       jae       near ptr M00_L38
       shl       rcx,4
       mov       ecx,[r14+rcx+1C]
       neg       ecx
       add       ecx,0FFFFFFFD
       mov       [r15+2C],ecx
       mov       ecx,r8d
       mov       r8,r14
       mov       r14d,ecx
       jmp       near ptr M00_L17
M00_L24:
       mov       rcx,rax
       mov       r11,7FF9E5B20D40
       call      qword ptr [r11]
       mov       rsi,rax
       mov       rax,[rbp-78]
       jmp       near ptr M00_L09
M00_L25:
       mov       rcx,r15
       xor       edx,edx
       call      qword ptr [7FF9E5DA7750]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       mov       rax,[rbp-78]
       jmp       near ptr M00_L10
M00_L26:
       xor       ecx,ecx
       mov       eax,ecx
       jmp       near ptr M00_L14
M00_L27:
       jmp       near ptr M00_L19
M00_L28:
       mov       r8d,[rbp-44]
       mov       edx,80
       test      r8b,1
       je        short M00_L29
       mov       edx,r8d
       and       rdx,2
       movzx     edx,byte ptr [rcx+rdx]
       or        edx,8000
M00_L29:
       test      r8b,2
       je        short M00_L30
       shl       edx,10
       movzx     ecx,word ptr [rcx]
       or        edx,ecx
       mov       ecx,edx
       jmp       near ptr M00_L13
M00_L30:
       mov       ecx,edx
       jmp       near ptr M00_L13
M00_L31:
       mov       r8,[rcx]
       mov       r8,[r8+48]
       call      qword ptr [r8+18]
       jmp       near ptr M00_L14
M00_L32:
       mov       rcx,r13
       mov       rdx,rsi
       mov       r11,7FF9E5B20D58
       call      qword ptr [r11]
       jmp       near ptr M00_L14
M00_L33:
       mov       rdx,[r9]
       mov       rcx,r13
       mov       r8,rsi
       mov       r11,7FF9E5B20D60
       call      qword ptr [r11]
       test      eax,eax
       mov       r9,[rbp-90]
       jne       near ptr M00_L07
       jmp       near ptr M00_L22
M00_L34:
       mov       rcx,r15
       call      qword ptr [7FF9E63BFAC8]
       mov       rcx,[r15+8]
       mov       r14d,[rbp-3C]
       mov       edx,r14d
       imul      rdx,[r15+20]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       imul      rdx,rax
       shr       rdx,20
       cmp       edx,[rcx+8]
       jae       short M00_L38
       mov       edx,edx
       lea       r10,[rcx+rdx*4+10]
       mov       rax,r10
       mov       [rbp-88],rax
       mov       eax,r14d
       jmp       near ptr M00_L16
M00_L35:
       mov       r14,[rbp-80]
       mov       rdx,r13
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M00_L07
       mov       edx,[r14+8]
       mov       rcx,r15
       mov       r8d,1
       call      qword ptr [7FF9E5F4D980]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,r15
       mov       rdx,rsi
       call      qword ptr [7FF9E5DA7810]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       jmp       near ptr M00_L07
M00_L36:
       mov       r11,7FF9E5B20D38
       call      qword ptr [r11]
       jmp       near ptr M00_L08
M00_L37:
       call      qword ptr [7FF9E5BDF498]
       int       3
M00_L38:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L39:
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-78]
       cmp       [rax],rcx
       jne       near ptr M00_L55
M00_L40:
       mov       ecx,[r15+28]
       test      ecx,ecx
       jle       short M00_L41
       mov       rax,[r15+10]
       mov       eax,[rax+8]
       cdq
       idiv      ecx
       cmp       eax,3
       jg        near ptr M00_L56
M00_L41:
       mov       ecx,[r15+28]
       sub       ecx,[r15+30]
       je        near ptr M00_L57
       xor       esi,esi
M00_L42:
       test      rsi,rsi
       jne       short M00_L43
       mov       rdx,r15
       mov       rcx,7FF9E63E06D0
       call      qword ptr [7FF9E63B5920]; System.Collections.Frozen.FrozenSet.CreateFromSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
       mov       rsi,rax
M00_L43:
       mov       [rbp-60],rsi
       mov       rcx,[rbx+60]
       lea       r8,[rbp-60]
       mov       rdx,7FF9E63EB440
       cmp       [rcx],ecx
       call      qword ptr [7FF9E63B6C40]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
M00_L44:
       call      qword ptr [7FF9E617EFE8]
       mov       ecx,65
       mov       rdx,7FF9E5FD8D68
       call      qword ptr [7FF9E5BDF228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF9E5EA5AC0
       call      qword ptr [7FF9E5BDF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9E5BDD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9E5FD8D68
       call      qword ptr [7FF9E5BDF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9E5BDD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9E63BD5D8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9E63BD5F0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L45:
       mov       r11,7FF9E5B20D18
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L00
M00_L46:
       mov       rcx,rsi
       mov       r11,7FF9E5B20D10
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L00
M00_L47:
       mov       rcx,[r14+8]
       mov       rdx,rdi
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       test      eax,eax
       je        near ptr M00_L01
       xor       r15d,r15d
       mov       rsi,r14
       jmp       near ptr M00_L42
M00_L48:
       mov       ecx,[r15+28]
       sub       ecx,[r15+30]
       je        near ptr M00_L41
       mov       rcx,r15
       call      qword ptr [7FF9E63B62B0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].get_Comparer()
       mov       rcx,rax
       mov       rdx,rdi
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       test      eax,eax
       jne       near ptr M00_L41
       jmp       near ptr M00_L02
M00_L49:
       mov       r8,r14
       mov       rdx,r15
       mov       rcx,offset MT_System.Collections.Generic.HashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FF9E6475278]
       test      eax,eax
       je        near ptr M00_L03
       mov       rcx,r15
       mov       rdx,r14
       call      qword ptr [7FF9E63BFC00]
       jmp       near ptr M00_L41
M00_L50:
       mov       r11,7FF9E5B20D28
       call      qword ptr [r11]
       mov       ecx,eax
       jmp       near ptr M00_L04
M00_L51:
       mov       rcx,rsi
       mov       r11,7FF9E5B20D20
       call      qword ptr [r11]
       mov       ecx,eax
       jmp       near ptr M00_L04
M00_L52:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,18F4B400AC8
       mov       r14,[rcx]
       jmp       near ptr M00_L06
M00_L53:
       mov       rcx,rsi
       mov       r11,7FF9E5B20D50
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L06
M00_L54:
       mov       rcx,rsi
       mov       r11,7FF9E5B20D30
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L06
M00_L55:
       mov       rcx,rax
       mov       r11,7FF9E5B20D48
       call      qword ptr [r11]
       jmp       near ptr M00_L40
M00_L56:
       mov       edx,ecx
       sub       edx,[r15+30]
       mov       rcx,r15
       call      qword ptr [7FF9E63BFC18]
       jmp       near ptr M00_L41
M00_L57:
       mov       rcx,offset MT_System.Collections.Frozen.FrozenSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,18F4B400AD0
       mov       rcx,[rcx]
       cmp       rdi,[rcx+8]
       je        short M00_L58
       mov       rcx,offset MT_System.Collections.Frozen.EmptyFrozenSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L42
M00_L58:
       mov       rcx,offset MT_System.Collections.Frozen.FrozenSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,18F4B400AD0
       mov       rsi,[rdx]
       jmp       near ptr M00_L42
M00_L59:
       xor       r8d,r8d
       mov       [rbp-70],r8
       mov       [rbp-68],r8d
       lea       r8,[rbp-70]
       mov       rcx,7FF9E64A6510
       xor       edx,edx
       call      qword ptr [7FF9E64752D8]
       mov       rsi,rax
       jmp       near ptr M00_L43
       sub       rsp,28
       cmp       qword ptr [rbp-78],0
       je        short M00_L60
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-78]
       cmp       [rax],rcx
       je        short M00_L60
       mov       rcx,rax
       mov       r11,7FF9E5B20D48
       call      qword ptr [r11]
M00_L60:
       nop
       add       rsp,28
       ret
; Total bytes of code 2510
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
       mov       rcx,7FF9ED480B08
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
       call      qword ptr [7FF9E63BEA78]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9E5F45E60]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M02_L03:
       mov       esi,ebx
       or        esi,1
       jmp       short M02_L06
M02_L04:
       mov       ecx,esi
       call      qword ptr [7FF9E63BEA90]
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
; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx]
       mov       rdx,rcx
       mov       eax,[rbx+10]
       cmp       eax,[rcx+14]
       jne       short M03_L00
       mov       ecx,[rbx+14]
       cmp       ecx,[rdx+10]
       jae       short M03_L01
       mov       rdx,[rdx+8]
       cmp       ecx,[rdx+8]
       jae       short M03_L02
       mov       ecx,ecx
       mov       rdx,[rdx+rcx*8+10]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       dword ptr [rbx+14]
       mov       eax,1
       add       rsp,20
       pop       rbx
       ret
M03_L00:
       call      qword ptr [7FF9E5BDFC60]
       int       3
M03_L01:
       xor       eax,eax
       mov       [rbx+8],rax
       mov       dword ptr [rbx+14],0FFFFFFFF
       add       rsp,20
       pop       rbx
       ret
M03_L02:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 101
```
```assembly
; System.Marvin.Block(UInt32 ByRef, UInt32 ByRef)
       mov       eax,[rcx]
       mov       r8d,eax
       xor       r8d,[rdx]
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       mov       [rcx],eax
       mov       [rdx],r8d
       ret
; Total bytes of code 37
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
       call      qword ptr [7FF9E5BD5A88]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       esi,eax
       movsxd    rdx,esi
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rdi,rax
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+0B0]
       test      rax,rax
       je        short M05_L01
       mov       rcx,rax
M05_L00:
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
M05_L01:
       mov       rdx,7FF9E644C618
       call      qword ptr [7FF9E5BDF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M05_L00
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
       call      qword ptr [7FF9EE0E7EC8]
       mov       rcx,rax
       movsxd    rdx,esi
       call      qword ptr [7FF9EE0E4088]; CORINFO_HELP_NEWARR_1_DIRECT
       mov       rbp,rax
       mov       r14d,[rbx+28]
       mov       rcx,[rbx+10]
       mov       rdx,rbp
       mov       r8d,r14d
       call      qword ptr [7FF9EE0F52F0]; Precode of System.Array.Copy(System.Array, System.Array, Int32)
       movzx     ecx,dil
       test      cl,1
       jne       near ptr M06_L06
M06_L00:
       movsxd    rcx,esi
       call      qword ptr [7FF9EE0F1B50]
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      qword ptr [7FF9EE0E3FE8]; CORINFO_HELP_ASSIGN_REF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,esi
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rbx+20],rax
       xor       ecx,ecx
       test      r14d,r14d
       jle       short M06_L03
       cmp       [rbp+8],r14d
       jl        near ptr M06_L04
M06_L01:
       mov       edx,ecx
       shl       rdx,4
       lea       rdx,[rbp+rdx+10]
       cmp       dword ptr [rdx+0C],0FFFFFFFF
       jl        short M06_L02
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
       jae       near ptr M06_L11
       mov       r10d,r10d
       lea       rax,[r8+r10*4+10]
       mov       r8d,[rax]
       dec       r8d
       mov       [rdx+0C],r8d
       lea       edx,[rcx+1]
       mov       [rax],edx
M06_L02:
       inc       ecx
       cmp       ecx,r14d
       jl        short M06_L01
M06_L03:
       lea       rcx,[rbx+10]
       mov       rdx,rbp
       call      qword ptr [7FF9EE0E3FE8]; CORINFO_HELP_ASSIGN_REF
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
M06_L04:
       cmp       ecx,[rbp+8]
       jae       near ptr M06_L11
       mov       eax,ecx
       shl       rax,4
       lea       rdx,[rbp+rax+10]
       cmp       dword ptr [rdx+0C],0FFFFFFFF
       jl        short M06_L05
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
       jae       near ptr M06_L11
       mov       eax,r10d
       lea       rax,[r8+rax*4+10]
       mov       r8d,[rax]
       dec       r8d
       mov       [rdx+0C],r8d
       lea       edx,[rcx+1]
       mov       [rax],edx
M06_L05:
       inc       ecx
       cmp       ecx,r14d
       jl        short M06_L04
       jmp       near ptr M06_L03
M06_L06:
       mov       rcx,[rbx]
       call      qword ptr [7FF9EE0E74F8]
       mov       rdi,rax
       mov       rcx,[rbx+18]
       call      qword ptr [7FF9EE0F3730]
       mov       rcx,rax
       lea       r11,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       [rcx],ecx
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF9EE0E4090]; Precode of System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdi,rax
       lea       rcx,[rbx+18]
       mov       rdx,rdi
       call      qword ptr [7FF9EE0E3FE8]; CORINFO_HELP_ASSIGN_REF
       xor       r15d,r15d
       cmp       r15d,r14d
       jge       near ptr M06_L00
M06_L07:
       cmp       r15d,[rbp+8]
       jae       short M06_L11
       mov       rcx,r15
       shl       rcx,4
       lea       r13,[rbp+rcx+10]
       cmp       dword ptr [r13+0C],0FFFFFFFF
       jl        short M06_L10
       cmp       qword ptr [r13],0
       jne       short M06_L08
       xor       r12d,r12d
       jmp       short M06_L09
M06_L08:
       mov       rcx,[rbx]
       call      qword ptr [7FF9EE0E9150]
       mov       rdx,[r13]
       mov       rcx,rdi
       mov       r11,rax
       call      qword ptr [rax]
       mov       r12d,eax
M06_L09:
       mov       [r13+8],r12d
M06_L10:
       inc       r15d
       cmp       r15d,r14d
       jl        short M06_L07
       jmp       near ptr M06_L00
M06_L11:
       call      qword ptr [7FF9EE0E3FD8]
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
       je        near ptr M07_L07
       mov       rdi,[rbx+10]
       xor       ebp,ebp
       mov       r14,[rbx+18]
       test      rsi,rsi
       je        near ptr M07_L11
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+78]
       test      r11,r11
       je        near ptr M07_L08
M07_L00:
       mov       rcx,offset MT_System.Collections.Generic.ObjectEqualityComparer<System.RuntimeType>
       cmp       [r14],rcx
       jne       near ptr M07_L13
       mov       [rsp+38],rsi
       xor       ecx,ecx
       mov       [rsp+30],rcx
       lea       rcx,[rsp+38]
       cmp       qword ptr [rsp+30],0
       jne       short M07_L01
       mov       rcx,[rsp+38]
       mov       [rsp+30],rcx
       lea       rcx,[rsp+30]
       cmp       qword ptr [rsp+30],0
       je        near ptr M07_L12
M07_L01:
       mov       r15,[rcx]
       mov       rcx,offset MT_System.RuntimeType
       cmp       [r15],rcx
       jne       near ptr M07_L10
       mov       rcx,r15
       call      00007FFA45809590
       test      eax,eax
       je        near ptr M07_L09
M07_L02:
       mov       r15d,eax
M07_L03:
       xor       ecx,ecx
       mov       [rsp+30],rcx
M07_L04:
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
       jae       near ptr M07_L18
       mov       edx,edx
       lea       rcx,[rcx+rdx*4+10]
       mov       r13d,[rcx]
       dec       r13d
       js        short M07_L07
M07_L05:
       mov       r12d,[rdi+8]
       cmp       r13d,r12d
       jae       near ptr M07_L18
       mov       ecx,r13d
       shl       rcx,4
       lea       rax,[rdi+rcx+10]
       mov       [rsp+28],rax
       cmp       [rax+8],r15d
       je        near ptr M07_L14
M07_L06:
       mov       rax,[rsp+28]
       mov       r13d,[rax+0C]
       inc       ebp
       cmp       r12d,ebp
       jb        near ptr M07_L17
       test      r13d,r13d
       jge       short M07_L05
M07_L07:
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
M07_L08:
       mov       rdx,7FF9E64461C0
       call      qword ptr [7FF9E5BDF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M07_L00
M07_L09:
       mov       rcx,r15
       call      qword ptr [7FF9E5DA77F8]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       jmp       near ptr M07_L02
M07_L10:
       mov       rcx,r15
       mov       rax,[r15]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
       mov       r15d,eax
       jmp       near ptr M07_L03
M07_L11:
       xor       r15d,r15d
       jmp       near ptr M07_L04
M07_L12:
       xor       r15d,r15d
       jmp       near ptr M07_L03
M07_L13:
       mov       rcx,r14
       mov       rdx,rsi
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       near ptr M07_L04
M07_L14:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+80]
       test      r11,r11
       je        short M07_L15
       jmp       short M07_L16
M07_L15:
       mov       rdx,7FF9E64461D8
       call      qword ptr [7FF9E5BDF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M07_L16:
       mov       rax,[rsp+28]
       mov       rdx,[rax]
       mov       rcx,r14
       mov       r8,rsi
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M07_L06
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
M07_L17:
       call      qword ptr [7FF9E5BDF498]
       int       3
M07_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 547
```
```assembly
; System.Collections.Frozen.FrozenSet.CreateFromSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,188
       xor       eax,eax
       mov       [rsp+0D8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+0E0],xmm4
       mov       [rsp+0F0],rax
       mov       [rsp+180],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rcx,[rbx]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rdx,offset MT_System.String
       cmp       [rcx],rdx
       je        near ptr M08_L53
       mov       rdi,[rbx+18]
       test      rdi,rdi
       je        near ptr M08_L56
M08_L00:
       mov       rcx,[rsi+18]
       mov       rdx,offset MT_System.String
       cmp       [rcx],rdx
       je        near ptr M08_L59
M08_L01:
       mov       ecx,[rbx+28]
       sub       ecx,[rbx+30]
       cmp       ecx,4
       jle       near ptr M08_L88
       mov       rcx,[rsi+18]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        near ptr M08_L08
M08_L02:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,[rbx]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rdx,offset MT_System.String
       cmp       [rcx],rdx
       je        near ptr M08_L91
       mov       rdx,[rbx+18]
       test      rdx,rdx
       je        near ptr M08_L94
M08_L03:
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+10],rcx
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx+8]
       mov       rax,[rdx+20]
       test      rax,rax
       je        near ptr M08_L09
M08_L04:
       lea       rcx,[rsi+10]
       mov       rdx,rsi
       call      rax
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx+10]
       mov       rdi,[rdx+28]
       test      rdi,rdi
       je        near ptr M08_L10
M08_L05:
       mov       rcx,rdi
       mov       ebp,[rbx+28]
       sub       ebp,[rbx+30]
       mov       [rsp+0D4],ebp
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       xor       r15d,r15d
       mov       r13d,ebp
       test      r13d,r13d
       jl        near ptr M08_L97
       mov       r12,[rbx+10]
       xor       eax,eax
       cmp       dword ptr [rbx+28],0
       jg        near ptr M08_L52
M08_L06:
       mov       rcx,rdi
       mov       edx,ebp
       call      CORINFO_HELP_NEWARR_1_PTR
       lea       rcx,[rsi+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,18F35401D88
       mov       r13,[rcx]
       mov       [rsp+40],r13
       mov       rcx,r13
       mov       edx,ebp
       call      qword ptr [7FF9E61E6E88]; System.Buffers.SharedArrayPool`1[[System.Int32, System.Private.CoreLib]].Rent(Int32)
       mov       rbx,rax
       mov       [rsp+0B8],rbx
       mov       edi,ebp
       test      rbx,rbx
       je        near ptr M08_L98
       cmp       [rbx+8],edi
       jb        near ptr M08_L108
       lea       r15,[rbx+10]
M08_L07:
       xor       r12d,r12d
       cmp       ebp,r12d
       jg        near ptr M08_L18
       jmp       near ptr M08_L99
M08_L08:
       mov       rcx,rsi
       mov       rdx,7FF9E644E068
       call      qword ptr [7FF9E5BDF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M08_L02
M08_L09:
       mov       rdx,7FF9E644FA90
       call      qword ptr [7FF9E5BDF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M08_L04
M08_L10:
       mov       rdx,7FF9E644F9B8
       call      qword ptr [7FF9E5BDF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M08_L05
M08_L11:
       mov       rdx,7FF9E644F9C0
       call      qword ptr [7FF9E5BDF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M08_L12:
       mov       rcx,[rsi+8]
       mov       rdx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rdx
       jne       near ptr M08_L105
       mov       r8,[rsp+0B0]
       mov       rdx,[r8+28]
       test      rdx,rdx
       je        near ptr M08_L100
       mov       rcx,18F35400068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M08_L104
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,109E73A0
       mov       r8d,2A12B45D
       cmp       edx,8
       jb        near ptr M08_L19
       mov       r9d,edx
       shr       r9d,3
M08_L13:
       add       eax,[rcx]
       mov       r11d,[rcx+4]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       add       r11d,eax
       mov       eax,r8d
       xor       eax,r11d
       rol       r11d,14
       add       r11d,eax
       rol       eax,9
       xor       eax,r11d
       rol       r11d,1B
       add       r11d,eax
       rol       eax,13
       mov       r8d,r11d
       add       rcx,8
       dec       r9d
       mov       r10d,eax
       mov       eax,r8d
       mov       r8d,r10d
       jne       short M08_L13
       test      dl,4
       jne       near ptr M08_L20
M08_L14:
       mov       r9d,edx
       and       r9,7
       mov       ecx,[rcx+r9-4]
       shr       ecx,8
       or        ecx,80000000
       not       edx
       shl       edx,3
       shrx      ecx,ecx,edx
M08_L15:
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
       mov       eax,ecx
       rol       eax,14
       add       eax,edx
       rol       edx,9
       xor       edx,eax
       rol       eax,1B
       add       eax,edx
       mov       r8d,edx
       rol       r8d,13
       xor       eax,r8d
M08_L16:
       mov       r10,[rsp+0A8]
M08_L17:
       mov       [r10],eax
       inc       r12d
       cmp       ebp,r12d
       jle       near ptr M08_L22
       mov       ebp,[rsp+0D4]
M08_L18:
       cmp       r12d,edi
       jae       near ptr M08_L153
       lea       rax,[r15+r12*4]
       mov       r8,[r14+r12*8+10]
       mov       [rsp+0B0],r8
       mov       [rsp+0A8],rax
       test      r8,r8
       je        short M08_L21
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx+10]
       mov       r11,[rdx+30]
       test      r11,r11
       je        near ptr M08_L11
       jmp       near ptr M08_L12
M08_L19:
       cmp       edx,4
       jb        near ptr M08_L101
M08_L20:
       add       eax,[rcx]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       jmp       near ptr M08_L14
       nop       dword ptr [rax+rax]
M08_L21:
       mov       r10,rax
       xor       eax,eax
       jmp       near ptr M08_L17
M08_L22:
       mov       rcx,r15
       mov       r12d,edi
       mov       [rsp+0E8],rcx
       mov       [rsp+0F0],r12d
       lea       rcx,[rsp+0E8]
       xor       edx,edx
       call      qword ptr [7FF9E63B69B8]; System.Collections.Frozen.FrozenHashTable.CalcNumBuckets(System.ReadOnlySpan`1<Int32>, Boolean)
       mov       r8d,eax
       mov       [rsp+158],r8d
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       r10d,r8d
       mov       [rsp+0C8],r10
       xor       edx,edx
       div       r10
       inc       rax
       mov       [rsp+150],rax
       mov       rcx,r13
       lea       edx,[r8+r12]
       call      qword ptr [7FF9E61E6E88]; System.Buffers.SharedArrayPool`1[[System.Int32, System.Private.CoreLib]].Rent(Int32)
       mov       [rsp+0A0],rax
       test      rax,rax
       je        near ptr M08_L106
       mov       edx,[rsp+158]
       cmp       [rax+8],edx
       jb        near ptr M08_L108
       lea       r8,[rax+10]
       mov       r10d,edx
M08_L23:
       mov       [rsp+58],r8
       mov       [rsp+108],r10d
       test      rax,rax
       je        near ptr M08_L107
       mov       edx,r12d
       mov       rcx,[rsp+0C8]
       add       rdx,rcx
       mov       r9d,[rax+8]
       cmp       rdx,r9
       ja        near ptr M08_L108
       lea       r9,[rax+rcx*4+10]
M08_L24:
       mov       [rsp+50],r9
       mov       [rsp+104],r12d
       mov       edx,r10d
       mov       rcx,rdx
       cmp       rcx,8
       jb        near ptr M08_L109
       lea       r11,[rcx*4]
       mov       [rsp+148],r11
       and       r11,0FFFFFFFFFFFFFFC0
       xor       r13d,r13d
       cmp       rcx,10
       jb        short M08_L26
M08_L25:
       vpcmpeqd  ymm0,ymm0,ymm0
       vmovups   [r8+r13],ymm0
       vmovups   [r8+r13+20],ymm0
       add       r13,40
       cmp       r13,r11
       jb        short M08_L25
M08_L26:
       mov       r11,[rsp+148]
       test      r11b,20
       je        short M08_L27
       vpcmpeqd  ymm0,ymm0,ymm0
       vmovups   [r8+r13],ymm0
M08_L27:
       vpcmpeqd  ymm0,ymm0,ymm0
       vmovups   [r8+r11-20],ymm0
M08_L28:
       xor       ecx,ecx
       test      edi,edi
       jle       near ptr M08_L112
       cmp       edi,r12d
       jg        near ptr M08_L49
       jmp       short M08_L29
M08_L29:
       mov       r11d,ecx
       mov       r11d,[r15+r11*4]
       mov       r13,[rsp+150]
       imul      r11,r13
       shr       r11,20
       inc       r11
       imul      r11,rdx
       shr       r11,20
       cmp       r11d,r10d
       jae       near ptr M08_L153
       mov       r11d,r11d
       lea       r11,[r8+r11*4]
       mov       ebx,ecx
       mov       eax,[r11]
       mov       [r9+rbx*4],eax
       mov       [r11],ecx
       inc       ecx
       cmp       ecx,edi
       jl        short M08_L29
M08_L30:
       mov       edx,edi
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbx,rax
       mov       edx,[rsp+108]
       mov       rcx,offset MT_System.Collections.Frozen.FrozenHashTable+Bucket[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       [rsp+98],rax
       xor       ecx,ecx
       xor       edx,edx
       cmp       dword ptr [rax+8],0
       jle       near ptr M08_L38
       mov       r8d,[rsp+108]
       cmp       [rax+8],r8d
       jg        near ptr M08_L35
       jmp       short M08_L32
M08_L31:
       inc       edx
       cmp       [rax+8],edx
       jle       near ptr M08_L38
M08_L32:
       mov       r8d,edx
       mov       r10,[rsp+58]
       mov       r8d,[r10+r8*4]
       test      r8d,r8d
       jl        short M08_L31
       xor       r9d,r9d
       mov       r11d,ecx
M08_L33:
       cmp       r8d,edi
       jae       near ptr M08_L153
       mov       r13d,r8d
       lea       r13,[r15+r13*4]
       mov       r12d,[r13]
       cmp       ecx,[rbx+8]
       jae       near ptr M08_L153
       mov       ebp,ecx
       mov       [rbx+rbp*4+10],r12d
       mov       [r13],ecx
       inc       ecx
       inc       r9d
       cmp       r8d,[rsp+104]
       jae       near ptr M08_L153
       mov       r8d,r8d
       mov       rbp,[rsp+50]
       mov       r8d,[rbp+r8*4]
       test      r8d,r8d
       jge       short M08_L33
       mov       r12d,[rsp+104]
       mov       r13,[rsp+150]
       lea       r8d,[r11+r9-1]
       mov       r9d,edx
       lea       r9,[rax+r9*8+10]
       mov       [r9],r11d
       mov       [r9+4],r8d
       jmp       near ptr M08_L31
M08_L34:
       inc       edx
       cmp       [rax+8],edx
       mov       rax,[rsp+98]
       mov       r8d,[rsp+108]
       jle       near ptr M08_L38
M08_L35:
       cmp       edx,r8d
       jae       near ptr M08_L153
       mov       r11d,edx
       mov       r10,[rsp+58]
       mov       r11d,[r10+r11*4]
       test      r11d,r11d
       jl        short M08_L34
       xor       r9d,r9d
       mov       r12d,ecx
M08_L36:
       cmp       r11d,edi
       jae       near ptr M08_L153
       mov       r13d,r11d
       lea       r13,[r15+r13*4]
       mov       r8d,[r13]
       cmp       ecx,[rbx+8]
       jae       near ptr M08_L153
       mov       ebp,ecx
       mov       [rbx+rbp*4+10],r8d
       mov       [r13],ecx
       inc       ecx
       inc       r9d
       mov       ebp,[rsp+104]
       cmp       r11d,ebp
       jae       near ptr M08_L153
       mov       r11d,r11d
       mov       r13,[rsp+50]
       mov       r11d,[r13+r11*4]
       test      r11d,r11d
       jge       short M08_L36
       mov       r13,[rsp+150]
       lea       r9d,[r12+r9-1]
       mov       r11d,edx
       lea       r11,[rax+r11*8+10]
       mov       [r11],r12d
       mov       [r11+4],r9d
       mov       r12d,[rsp+104]
       jmp       near ptr M08_L34
M08_L37:
       cmp       ebx,edi
       jae       near ptr M08_L153
       mov       ecx,ebx
       mov       r13d,[r15+rcx*4]
       mov       rcx,[rsi+18]
       cmp       ebx,ebp
       jae       near ptr M08_L153
       mov       r8d,ebx
       mov       r8,[r14+r8*8+10]
       movsxd    rdx,r13d
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       inc       ebx
       cmp       ebx,edi
       jl        short M08_L37
       jmp       near ptr M08_L44
M08_L38:
       mov       r12,[rsp+40]
       mov       rdx,r12
       mov       [rsp+90],rdx
       mov       r8,[rsp+0A0]
       test      r8,r8
       je        near ptr M08_L135
       mov       rdx,[rsp+90]
       mov       ecx,[r8+8]
       dec       ecx
       or        ecx,0F
       xor       r10d,r10d
       lzcnt     r10d,ecx
       xor       r10d,1F
       add       r10d,0FFFFFFFD
       mov       [rsp+144],r10d
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+238],7
       jle       near ptr M08_L115
       mov       rcx,[rcx+240]
       mov       r9,[rcx+38]
       test      r9,r9
       je        near ptr M08_L114
M08_L39:
       mov       [rsp+48],r9
       mov       r11,[r9+10]
       test      r11,r11
       je        near ptr M08_L116
M08_L40:
       xor       ecx,ecx
       mov       dword ptr [rsp+13C],1
       mov       edx,[r11+8]
       mov       r10d,[rsp+144]
       cmp       edx,r10d
       jbe       near ptr M08_L41
       mov       dword ptr [rsp+140],1
       mov       edx,10
       shlx      edx,edx,r10d
       mov       r8,[rsp+0A0]
       cmp       [r8+8],edx
       jne       near ptr M08_L117
       mov       edx,r10d
       shl       rdx,4
       lea       r11,[r11+rdx+10]
       mov       [rsp+80],r11
       mov       rdx,[r11]
       mov       [rsp+78],rdx
       mov       rcx,r11
       mov       rdx,r8
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       rdx,[rsp+80]
       mov       [rdx+8],ecx
       cmp       qword ptr [rsp+78],0
       jne       near ptr M08_L118
       mov       rax,[rsp+98]
       mov       ecx,[rsp+140]
       mov       r10d,[rsp+144]
M08_L41:
       mov       rdx,18F35400C90
       mov       rdx,[rdx]
       mov       [rsp+38],rdx
       mov       r11,rdx
       mov       [rsp+88],r11
       cmp       byte ptr [r11+9D],0
       jne       near ptr M08_L131
M08_L42:
       lea       rcx,[rsi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+28]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rsi+30],r13
       xor       ebx,ebx
       test      edi,edi
       jle       short M08_L44
       mov       ebp,[rsp+0D4]
       cmp       ebp,edi
       jl        near ptr M08_L37
       xor       ebx,ebx
M08_L43:
       mov       r13d,[r15+rbx]
       mov       rcx,[rsi+18]
       mov       r8,[r14+rbx*2+10]
       movsxd    rdx,r13d
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       add       rbx,4
       dec       edi
       jne       short M08_L43
M08_L44:
       mov       rbx,[rsp+0B8]
       test      rbx,rbx
       je        near ptr M08_L135
       mov       ecx,[rbx+8]
       dec       ecx
       or        ecx,0F
       xor       edi,edi
       lzcnt     edi,ecx
       xor       edi,1F
       add       edi,0FFFFFFFD
       mov       rbp,[rsp+48]
       mov       rax,[rbp+10]
       test      rax,rax
       je        near ptr M08_L136
M08_L45:
       xor       ebp,ebp
       mov       r14d,1
       mov       ecx,[rax+8]
       cmp       ecx,edi
       jbe       short M08_L46
       mov       ebp,1
       mov       edx,10
       shlx      edx,edx,edi
       cmp       [rbx+8],edx
       jne       near ptr M08_L137
       cmp       edi,ecx
       jae       near ptr M08_L153
       mov       ecx,edi
       shl       rcx,4
       lea       r15,[rax+rcx+10]
       mov       r13,[r15]
       mov       rcx,r15
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r15+8],ecx
       test      r13,r13
       jne       near ptr M08_L138
M08_L46:
       mov       r15,[rsp+38]
       cmp       byte ptr [r15+9D],0
       jne       near ptr M08_L150
M08_L47:
       mov       rax,rsi
       vzeroupper
       add       rsp,188
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M08_L48:
       mov       r8,[rsp+58]
       mov       r9,[rsp+50]
       mov       r10d,[rsp+108]
M08_L49:
       mov       r11d,ecx
       mov       r11d,[r15+r11*4]
       imul      r11,[rsp+150]
       shr       r11,20
       inc       r11
       imul      r11,rdx
       shr       r11,20
       cmp       r11d,r10d
       jae       near ptr M08_L153
       mov       r11d,r11d
       lea       r11,[r8+r11*4]
       cmp       ecx,r12d
       jae       near ptr M08_L153
       mov       ebx,ecx
       mov       [rsp+178],rbx
       mov       ebx,[r11]
       mov       rax,[rsp+178]
       mov       [r9+rax*4],ebx
       mov       [r11],ecx
       inc       ecx
       cmp       ecx,edi
       mov       r12d,[rsp+104]
       jl        short M08_L48
       jmp       near ptr M08_L113
M08_L50:
       lea       edx,[r15+1]
       mov       [rsp+15C],edx
       mov       r8,[r8]
       movsxd    rdx,r15d
       mov       rcx,r14
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       dec       r13d
       mov       r15d,[rsp+15C]
M08_L51:
       mov       rax,[rsp+0C0]
       inc       eax
       mov       rcx,rax
       cmp       ecx,[rbx+28]
       mov       rax,rcx
       jge       near ptr M08_L06
M08_L52:
       test      r13d,r13d
       je        near ptr M08_L06
       cmp       eax,[r12+8]
       jae       near ptr M08_L153
       mov       [rsp+0C0],rax
       mov       r8,rax
       shl       r8,4
       lea       r8,[r12+r8+10]
       cmp       dword ptr [r8+0C],0FFFFFFFF
       jl        short M08_L51
       jmp       short M08_L50
M08_L53:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdi,[rdx+0A0]
       test      rdi,rdi
       je        short M08_L54
       jmp       short M08_L55
M08_L54:
       mov       rdx,7FF9E644C480
       call      qword ptr [7FF9E5BDF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
M08_L55:
       mov       rdx,[rbx+18]
       mov       rcx,offset MT_System.Collections.Generic.IEqualityComparer<System.String>
       call      qword ptr [7FF9E5BD58D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rcx,rax
       call      qword ptr [7FF9E63BFC30]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF9E5BD58D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdi,rax
       jmp       near ptr M08_L00
M08_L56:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+0A8]
       test      rdx,rdx
       je        short M08_L57
       jmp       short M08_L58
M08_L57:
       mov       rdx,7FF9E644C490
       call      qword ptr [7FF9E5BDF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M08_L58:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdi,[rax]
       jmp       near ptr M08_L00
M08_L59:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF9E5DA7810]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       test      eax,eax
       jge       near ptr M08_L01
       mov       rcx,[rsi+18]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       je        short M08_L60
       jmp       short M08_L61
M08_L60:
       mov       rcx,rsi
       mov       rdx,7FF9E644EF20
       call      qword ptr [7FF9E5BDF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M08_L61:
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       cmp       [rax],rdi
       je        short M08_L62
       mov       rdx,18F35400068
       cmp       rdi,[rdx]
       je        short M08_L62
       mov       rdx,18F35400070
       cmp       rdi,[rdx]
       jne       near ptr M08_L01
M08_L62:
       mov       rdx,rdi
       mov       rcx,offset MT_System.Collections.Generic.IEqualityComparer<System.String>
       call      qword ptr [7FF9E5BD58D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdi,rax
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.HashSet<System.String>
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       rbx,rax
       mov       edx,[rbx+28]
       sub       edx,[rbx+30]
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbp,rax
       mov       r9d,[rbx+28]
       sub       r9d,[rbx+30]
       mov       rcx,rbx
       mov       rdx,rbp
       xor       r8d,r8d
       call      qword ptr [7FF9E5F4DA28]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].CopyTo(System.__Canon[], Int32, Int32)
       mov       ebx,7FFFFFFF
       xor       r14d,r14d
       xor       r15d,r15d
       xor       ecx,ecx
       jmp       short M08_L66
M08_L63:
       mov       rdx,[rbp+rcx*8+10]
       cmp       [rdx+8],ebx
       jge       short M08_L64
       mov       ebx,[rdx+8]
M08_L64:
       cmp       [rdx+8],r14d
       jle       short M08_L65
       mov       r14d,[rdx+8]
M08_L65:
       mov       edx,[rdx+8]
       mov       r8d,1
       shlx      rdx,r8,rdx
       or        r15,rdx
       inc       ecx
M08_L66:
       cmp       [rbp+8],ecx
       jg        short M08_L63
       mov       rcx,rbp
       mov       rdx,rdi
       mov       r8d,ebx
       mov       r9d,r14d
       call      qword ptr [7FF9E6474BD0]
       mov       r13,rax
       test      r13,r13
       je        short M08_L69
       mov       rcx,[rsi+18]
       cmp       qword ptr [rcx+8],30
       jle       short M08_L67
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M08_L67
       jmp       short M08_L68
M08_L67:
       mov       rcx,rsi
       mov       rdx,7FF9E644F318
       call      qword ptr [7FF9E5BDF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M08_L68:
       mov       rdx,r13
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       nop
       vzeroupper
       add       rsp,188
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M08_L69:
       lea       rdx,[rbp+10]
       mov       r8d,[rbp+8]
       mov       [rsp+0D8],rdx
       mov       [rsp+0E0],r8d
       mov       [rsp+20],r14d
       lea       rdx,[rsp+0D8]
       mov       r8,18F35400070
       cmp       rdi,[r8]
       sete      r8b
       movzx     r8d,r8b
       lea       rcx,[rsp+160]
       mov       r9d,ebx
       call      qword ptr [7FF9E6474BE8]
       mov       ebx,[rsp+168]
       movzx     r14d,byte ptr [rsp+160]
       movzx     r12d,byte ptr [rsp+161]
       mov       r13d,[rsp+164]
       mov       eax,[rsp+16C]
       mov       [rsp+100],eax
       mov       edx,[rsp+170]
       mov       [rsp+0FC],edx
       test      ebx,ebx
       je        near ptr M08_L81
       test      r13d,r13d
       jge       near ptr M08_L75
       test      r14d,r14d
       je        near ptr M08_L72
       test      r12d,r12d
       jne       short M08_L70
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_RightJustifiedCaseInsensitiveSubstring
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       r15d,[rsp+0FC]
       mov       [rsp+20],r15d
       mov       [rsp+28],r13d
       mov       [rsp+30],ebx
       mov       rcx,r14
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+100]
       call      qword ptr [7FF9E6474C00]
       jmp       short M08_L71
M08_L70:
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_RightJustifiedCaseInsensitiveAsciiSubstring
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       r15d,[rsp+0FC]
       mov       [rsp+20],r15d
       mov       [rsp+28],r13d
       mov       [rsp+30],ebx
       mov       rcx,r14
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+100]
       call      qword ptr [7FF9E6474C00]
M08_L71:
       mov       r13,r14
       jmp       near ptr M08_L85
M08_L72:
       cmp       ebx,1
       je        short M08_L73
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_RightJustifiedSubstring
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       r15d,[rsp+0FC]
       mov       [rsp+20],r15d
       mov       [rsp+28],r13d
       mov       [rsp+30],ebx
       mov       rcx,r12
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+100]
       call      qword ptr [7FF9E6474C00]
       jmp       short M08_L74
M08_L73:
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_RightJustifiedSingleChar
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       r15d,[rsp+0FC]
       mov       [rsp+20],r15d
       mov       [rsp+28],r13d
       mov       dword ptr [rsp+30],1
       mov       rcx,r12
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+100]
       call      qword ptr [7FF9E6474C00]
M08_L74:
       mov       r13,r12
       jmp       near ptr M08_L85
M08_L75:
       test      r14d,r14d
       je        near ptr M08_L78
       test      r12d,r12d
       jne       short M08_L76
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_LeftJustifiedCaseInsensitiveSubstring
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       r15d,[rsp+0FC]
       mov       [rsp+20],r15d
       mov       [rsp+28],r13d
       mov       [rsp+30],ebx
       mov       rcx,r14
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+100]
       call      qword ptr [7FF9E6474C00]
       jmp       short M08_L77
M08_L76:
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_LeftJustifiedCaseInsensitiveAsciiSubstring
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       r15d,[rsp+0FC]
       mov       [rsp+20],r15d
       mov       [rsp+28],r13d
       mov       [rsp+30],ebx
       mov       rcx,r14
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+100]
       call      qword ptr [7FF9E6474C00]
M08_L77:
       mov       r13,r14
       jmp       near ptr M08_L85
M08_L78:
       cmp       ebx,1
       je        short M08_L79
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_LeftJustifiedSubstring
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       r15d,[rsp+0FC]
       mov       [rsp+20],r15d
       mov       [rsp+28],r13d
       mov       [rsp+30],ebx
       mov       rcx,r12
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+100]
       call      qword ptr [7FF9E6474C00]
       jmp       short M08_L80
M08_L79:
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_LeftJustifiedSingleChar
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       r15d,[rsp+0FC]
       mov       [rsp+20],r15d
       mov       [rsp+28],r13d
       mov       dword ptr [rsp+30],1
       mov       rcx,r12
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+100]
       call      qword ptr [7FF9E6474C00]
M08_L80:
       mov       r13,r12
       jmp       near ptr M08_L85
M08_L81:
       test      r14d,r14d
       je        short M08_L84
       test      r12d,r12d
       jne       short M08_L82
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_FullCaseInsensitive
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       ebx,[rsp+0FC]
       mov       [rsp+20],ebx
       mov       [rsp+28],r15
       mov       rcx,r13
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+100]
       call      qword ptr [7FF9E6474C18]
       jmp       short M08_L83
M08_L82:
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_FullCaseInsensitiveAscii
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       ebx,[rsp+0FC]
       mov       [rsp+20],ebx
       mov       [rsp+28],r15
       mov       rcx,r13
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+100]
       call      qword ptr [7FF9E6474C30]
M08_L83:
       jmp       short M08_L85
M08_L84:
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_Full
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       ebx,[rsp+0FC]
       mov       [rsp+20],ebx
       mov       [rsp+28],r15
       mov       rcx,r13
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+100]
       call      qword ptr [7FF9E6474C48]
M08_L85:
       mov       rcx,[rsi+18]
       cmp       qword ptr [rcx+8],30
       jle       short M08_L86
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M08_L86
       jmp       short M08_L87
M08_L86:
       mov       rcx,rsi
       mov       rdx,7FF9E644F318
       call      qword ptr [7FF9E5BDF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M08_L87:
       mov       rdx,r13
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       nop
       vzeroupper
       add       rsp,188
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M08_L88:
       mov       rcx,[rsi+18]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M08_L89
       jmp       short M08_L90
M08_L89:
       mov       rcx,rsi
       mov       rdx,7FF9E644EE00
       call      qword ptr [7FF9E5BDF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M08_L90:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF9E6475398]
       mov       rax,rsi
       vzeroupper
       add       rsp,188
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M08_L91:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdi,[rdx+0A0]
       test      rdi,rdi
       je        short M08_L92
       jmp       short M08_L93
M08_L92:
       mov       rdx,7FF9E644C480
       call      qword ptr [7FF9E5BDF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
M08_L93:
       mov       rdx,[rbx+18]
       mov       rcx,offset MT_System.Collections.Generic.IEqualityComparer<System.String>
       call      qword ptr [7FF9E5BD58D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rcx,rax
       call      qword ptr [7FF9E63BFC30]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF9E5BD58D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdx,rax
       jmp       near ptr M08_L03
M08_L94:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+0A8]
       test      rdx,rdx
       je        short M08_L95
       jmp       short M08_L96
M08_L95:
       mov       rdx,7FF9E644C490
       call      qword ptr [7FF9E5BDF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M08_L96:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       jmp       near ptr M08_L03
M08_L97:
       mov       ecx,28F
       mov       rdx,7FF9E5B14000
       call      qword ptr [7FF9E5BDF228]
       mov       rdx,rax
       mov       ecx,r13d
       call      qword ptr [7FF9E63BDB18]
       int       3
M08_L98:
       test      edi,edi
       jne       near ptr M08_L108
       xor       r15d,r15d
       xor       edi,edi
       jmp       near ptr M08_L07
M08_L99:
       jmp       near ptr M08_L22
M08_L100:
       xor       eax,eax
       jmp       near ptr M08_L16
M08_L101:
       mov       r9d,80
       test      dl,1
       je        short M08_L102
       mov       r9d,edx
       and       r9,2
       movzx     r9d,byte ptr [rcx+r9]
       or        r9d,8000
M08_L102:
       test      dl,2
       je        short M08_L103
       shl       r9d,10
       movzx     ecx,word ptr [rcx]
       or        r9d,ecx
       mov       ecx,r9d
       jmp       near ptr M08_L15
M08_L103:
       mov       ecx,r9d
       jmp       near ptr M08_L15
M08_L104:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       jmp       near ptr M08_L16
M08_L105:
       mov       r8,[rsp+0B0]
       mov       rdx,r8
       call      qword ptr [r11]
       jmp       near ptr M08_L16
M08_L106:
       mov       edx,[rsp+158]
       test      edx,edx
       jne       short M08_L108
       xor       r8d,r8d
       xor       r10d,r10d
       jmp       near ptr M08_L23
M08_L107:
       or        edx,r12d
       jne       short M08_L108
       xor       r9d,r9d
       xor       r12d,r12d
       mov       ecx,r9d
       mov       r9,r12
       mov       r12d,ecx
       jmp       near ptr M08_L24
M08_L108:
       call      qword ptr [7FF9E5DAF228]
       int       3
M08_L109:
       xor       r11d,r11d
       test      cl,4
       je        short M08_L110
       mov       dword ptr [r8+r11*4],0FFFFFFFF
       mov       dword ptr [r8+r11*4+4],0FFFFFFFF
       mov       dword ptr [r8+r11*4+8],0FFFFFFFF
       mov       dword ptr [r8+r11*4+0C],0FFFFFFFF
       add       r11,4
M08_L110:
       test      cl,2
       je        short M08_L111
       mov       dword ptr [r8+r11*4],0FFFFFFFF
       mov       dword ptr [r8+r11*4+4],0FFFFFFFF
       add       r11,2
M08_L111:
       test      cl,1
       je        near ptr M08_L28
       mov       dword ptr [r8+r11*4],0FFFFFFFF
       jmp       near ptr M08_L28
M08_L112:
       mov       r13,[rsp+150]
       jmp       near ptr M08_L30
M08_L113:
       mov       r13,[rsp+150]
       jmp       near ptr M08_L30
M08_L114:
       mov       ecx,7
       call      qword ptr [7FF9E63BDD70]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       r9,rax
       mov       rax,[rsp+98]
       mov       rdx,[rsp+90]
       jmp       near ptr M08_L39
M08_L115:
       jmp       short M08_L114
M08_L116:
       mov       rcx,rdx
       call      qword ptr [7FF9E617F480]; System.Buffers.SharedArrayPool`1[[System.Int32, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
       mov       r11,rax
       mov       rax,[rsp+98]
       jmp       near ptr M08_L40
M08_L117:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9E620EEC8]
       mov       rbx,rax
       mov       ecx,29B
       mov       rdx,7FF9E5B14000
       call      qword ptr [7FF9E5BDF228]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9E5F47D50]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M08_L118:
       mov       r8,[rsp+90]
       mov       rcx,[r8+10]
       mov       r10d,[rsp+144]
       cmp       r10d,[rcx+8]
       jae       near ptr M08_L153
       mov       edx,r10d
       mov       r9,[rcx+rdx*8+10]
       test      r9,r9
       jne       short M08_L120
       mov       rcx,r8
       mov       edx,r10d
       call      qword ptr [7FF9E63BFBE8]
       mov       r9,rax
M08_L119:
       mov       rcx,[r9+8]
       mov       [rsp+70],rcx
       call      qword ptr [7FF9E620F498]; System.Threading.Thread.GetCurrentProcessorNumber()
       mov       ecx,0AAAAAAAB
       mov       edx,eax
       imul      rcx,rdx
       shr       rcx,23
       imul      ecx,0C
       sub       eax,ecx
       xor       edx,edx
       jmp       near ptr M08_L127
M08_L120:
       jmp       short M08_L119
M08_L121:
       cmp       eax,[r8+8]
       jae       near ptr M08_L153
       mov       [rsp+128],eax
       mov       ecx,eax
       mov       r10,[r8+rcx*8+10]
       mov       [rsp+68],r10
       cmp       [r10],r10b
       xor       r9d,r9d
       mov       [rsp+120],r9d
       mov       rcx,r10
       call      qword ptr [7FF9E60FE2B0]; System.Threading.Monitor.Enter(System.Object)
       mov       rax,[rsp+68]
       mov       rcx,[rax+8]
       mov       r8d,[rax+10]
       mov       [rsp+11C],r8d
       cmp       [rcx+8],r8d
       jbe       short M08_L123
       test      r8d,r8d
       jne       short M08_L124
       xor       edx,edx
       mov       [rax+14],edx
M08_L122:
       movsxd    rdx,r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,[rsp+78]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rsp+11C]
       inc       ecx
       mov       rax,[rsp+68]
       mov       [rax+10],ecx
       mov       dword ptr [rsp+120],1
M08_L123:
       mov       rcx,rax
       call      qword ptr [7FF9E5BD6820]; System.Threading.Monitor.Exit(System.Object)
       cmp       dword ptr [rsp+120],0
       je        short M08_L125
       jmp       short M08_L128
M08_L124:
       jmp       short M08_L122
M08_L125:
       mov       eax,[rsp+128]
       inc       eax
       mov       ecx,eax
       mov       r8,[rsp+70]
       cmp       [r8+8],ecx
       jne       short M08_L126
       xor       ecx,ecx
M08_L126:
       mov       edx,[rsp+124]
       inc       edx
       mov       eax,ecx
M08_L127:
       mov       r8,[rsp+70]
       mov       [rsp+124],edx
       cmp       [r8+8],edx
       jg        near ptr M08_L121
       jmp       short M08_L129
M08_L128:
       mov       edx,1
       jmp       short M08_L130
M08_L129:
       xor       edx,edx
M08_L130:
       mov       eax,edx
       mov       [rsp+13C],eax
       mov       rax,[rsp+98]
       mov       ecx,[rsp+140]
       mov       r10d,[rsp+144]
       jmp       near ptr M08_L41
M08_L131:
       mov       r8,[rsp+0A0]
       cmp       dword ptr [r8+8],0
       mov       [rsp+140],ecx
       je        near ptr M08_L42
       mov       rcx,r8
       call      qword ptr [7FF9E5FFD740]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+138],eax
       mov       rdx,[rsp+0A0]
       mov       r8d,[rdx+8]
       mov       [rsp+134],r8d
       mov       rcx,[rsp+90]
       call      qword ptr [7FF9E5FFD740]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,[rsp+88]
       mov       r8d,[rsp+138]
       mov       r9d,[rsp+134]
       mov       edx,3
       call      qword ptr [7FF9E63BF858]
       mov       eax,[rsp+140]
       test      [rsp+13C],eax
       jne       short M08_L132
       mov       rcx,[rsp+0A0]
       call      qword ptr [7FF9E5FFD740]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+130],eax
       mov       rcx,[rsp+0A0]
       mov       edx,[rcx+8]
       mov       [rsp+12C],edx
       mov       rcx,[rsp+90]
       call      qword ptr [7FF9E5FFD740]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       cmp       dword ptr [rsp+140],0
       jne       short M08_L133
       mov       ecx,0FFFFFFFF
       mov       edx,1
       jmp       short M08_L134
M08_L132:
       mov       rax,[rsp+98]
       jmp       near ptr M08_L42
M08_L133:
       mov       ecx,[rsp+144]
       xor       edx,edx
M08_L134:
       mov       [rsp+20],ecx
       mov       [rsp+28],edx
       mov       rcx,[rsp+88]
       mov       edx,[rsp+130]
       mov       r8d,[rsp+12C]
       call      qword ptr [7FF9E620EF40]
       mov       rax,[rsp+98]
       jmp       near ptr M08_L42
M08_L135:
       mov       ecx,2
       call      qword ptr [7FF9E5BDFD50]
       int       3
M08_L136:
       mov       rcx,r12
       call      qword ptr [7FF9E617F480]; System.Buffers.SharedArrayPool`1[[System.Int32, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
       jmp       near ptr M08_L45
M08_L137:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9E620EEC8]
       mov       r12,rax
       mov       ecx,29B
       mov       rdx,7FF9E5B14000
       call      qword ptr [7FF9E5BDF228]
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,rbx
       call      qword ptr [7FF9E5F47D50]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M08_L138:
       mov       rcx,[r12+10]
       cmp       edi,[rcx+8]
       jae       near ptr M08_L153
       mov       edx,edi
       mov       rax,[rcx+rdx*8+10]
       test      rax,rax
       jne       short M08_L139
       mov       rcx,r12
       mov       edx,edi
       call      qword ptr [7FF9E63BFBE8]
M08_L139:
       mov       r14,[rax+8]
       call      qword ptr [7FF9E620F498]; System.Threading.Thread.GetCurrentProcessorNumber()
       mov       ecx,0AAAAAAAB
       mov       edx,eax
       imul      rcx,rdx
       shr       rcx,23
       imul      ecx,0C
       mov       r15d,eax
       sub       r15d,ecx
       xor       eax,eax
       jmp       near ptr M08_L146
M08_L140:
       cmp       r15d,[r14+8]
       jae       near ptr M08_L153
       mov       ecx,r15d
       mov       rdx,[r14+rcx*8+10]
       mov       [rsp+60],rdx
       cmp       [rdx],dl
       xor       r8d,r8d
       mov       [rsp+110],r8d
       mov       rcx,rdx
       call      qword ptr [7FF9E60FE2B0]; System.Threading.Monitor.Enter(System.Object)
       mov       rax,[rsp+60]
       mov       rcx,[rax+8]
       mov       r8d,[rax+10]
       mov       [rsp+10C],r8d
       cmp       [rcx+8],r8d
       jbe       short M08_L142
       test      r8d,r8d
       jne       short M08_L143
       xor       edx,edx
       mov       [rax+14],edx
M08_L141:
       movsxd    rdx,r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rsp+10C]
       inc       ecx
       mov       rax,[rsp+60]
       mov       [rax+10],ecx
       mov       dword ptr [rsp+110],1
M08_L142:
       mov       rcx,rax
       call      qword ptr [7FF9E5BD6820]; System.Threading.Monitor.Exit(System.Object)
       cmp       dword ptr [rsp+110],0
       je        short M08_L144
       jmp       short M08_L147
M08_L143:
       jmp       short M08_L141
M08_L144:
       inc       r15d
       cmp       [r14+8],r15d
       jne       short M08_L145
       xor       r15d,r15d
M08_L145:
       mov       eax,[rsp+114]
       inc       eax
M08_L146:
       mov       [rsp+114],eax
       cmp       [r14+8],eax
       jg        near ptr M08_L140
       jmp       short M08_L148
M08_L147:
       mov       r14d,1
       jmp       short M08_L149
M08_L148:
       xor       r14d,r14d
M08_L149:
       jmp       near ptr M08_L46
M08_L150:
       cmp       dword ptr [rbx+8],0
       je        near ptr M08_L47
       mov       rcx,rbx
       call      qword ptr [7FF9E5FFD740]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r13d,eax
       mov       eax,[rbx+8]
       mov       [rsp+118],eax
       mov       rcx,r12
       call      qword ptr [7FF9E5FFD740]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,r15
       mov       r8d,r13d
       mov       r9d,[rsp+118]
       mov       edx,3
       call      qword ptr [7FF9E63BF858]
       test      r14d,ebp
       jne       near ptr M08_L47
       mov       rcx,rbx
       call      qword ptr [7FF9E5FFD740]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r14d,eax
       mov       ebx,[rbx+8]
       mov       rcx,r12
       call      qword ptr [7FF9E5FFD740]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       test      ebp,ebp
       jne       short M08_L151
       mov       ecx,0FFFFFFFF
       mov       edx,1
       jmp       short M08_L152
M08_L151:
       mov       ecx,edi
       xor       edx,edx
M08_L152:
       mov       [rsp+20],ecx
       mov       [rsp+28],edx
       mov       rcx,r15
       mov       edx,r14d
       mov       r8d,ebx
       call      qword ptr [7FF9E620EF40]
       jmp       near ptr M08_L47
M08_L153:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 6090
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
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       test      rbx,rbx
       je        near ptr M10_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M10_L01
       test      rsi,rsi
       je        short M10_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M10_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M10_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFA45879D30
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF9E5BD5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF9E5BD5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
M10_L00:
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
M10_L01:
       test      rsi,rsi
       je        short M10_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M10_L03
M10_L02:
       mov       rax,1CFCA5A0008
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M10_L03:
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
M10_L04:
       call      qword ptr [7FF9E63BF570]
       int       3
; Total bytes of code 244
```
```assembly
; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].get_Comparer()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       rcx,[rbx]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rdx,offset MT_System.String
       cmp       [rcx],rdx
       je        short M11_L01
       mov       rax,[rbx+18]
       test      rax,rax
       je        short M11_L04
M11_L00:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M11_L01:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rsi,[rdx+0A0]
       test      rsi,rsi
       je        short M11_L02
       jmp       short M11_L03
M11_L02:
       mov       rdx,7FF9E644C480
       call      qword ptr [7FF9E5BDF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rsi,rax
M11_L03:
       mov       rdx,[rbx+18]
       mov       rcx,offset MT_System.Collections.Generic.IEqualityComparer<System.String>
       call      qword ptr [7FF9E5BD58D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rcx,rax
       call      qword ptr [7FF9E63BFC30]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9E5BD58D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M11_L04:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+0A8]
       test      rdx,rdx
       je        short M11_L05
       jmp       short M11_L06
M11_L05:
       mov       rdx,7FF9E644C490
       call      qword ptr [7FF9E5BDF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M11_L06:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rax]
       jmp       near ptr M11_L00
; Total bytes of code 206
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M12_L00
       ret
M12_L00:
       jmp       qword ptr [7FF9E5BD5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.ToFrozenSet()
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
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-70],xmm4
       xor       eax,eax
       mov       [rbp-60],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       test      rsi,rsi
       je        near ptr M00_L44
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L46
       mov       rcx,[rsi+8]
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],r11
       jne       near ptr M00_L45
       mov       edi,[rcx+10]
M00_L00:
       test      edi,edi
       je        near ptr M00_L59
       mov       rdx,150A1000A20
       mov       rdi,[rdx]
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Frozen.FrozenSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r14,rax
       test      r14,r14
       jne       near ptr M00_L47
M00_L01:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Generic.HashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r14,rax
       mov       r15,r14
       test      r15,r15
       jne       near ptr M00_L48
M00_L02:
       mov       rcx,offset MT_System.Collections.Generic.HashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       lea       rcx,[r15+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       test      r14,r14
       jne       near ptr M00_L49
M00_L03:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L51
       mov       rcx,[rsi+8]
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],r11
       jne       near ptr M00_L50
       mov       ecx,[rcx+10]
M00_L04:
       test      ecx,ecx
       jle       short M00_L05
       call      qword ptr [7FF9E5BF5A88]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       r14d,eax
       movsxd    rdx,r14d
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r13,rax
       movsxd    rdx,r14d
       mov       rcx,offset MT_System.Collections.Generic.HashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Entry[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r12,rax
       mov       dword ptr [r15+2C],0FFFFFFFF
       lea       rcx,[r15+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,r14d
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [r15+20],rax
M00_L05:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L54
       mov       rsi,[rsi+8]
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L53
       cmp       dword ptr [rsi+10],0
       je        near ptr M00_L52
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       r13d,[rsi+14]
       lea       rcx,[r14+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r14+10],rcx
       mov       [r14+18],r13d
       mov       [r14+1C],ecx
M00_L06:
       mov       [rbp-78],r14
M00_L07:
       mov       rdx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rcx,[rbp-78]
       cmp       [rcx],rdx
       jne       near ptr M00_L36
       mov       rdx,[rcx]
       add       rcx,8
       call      qword ptr [7FF9E5E8C150]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L08:
       test      eax,eax
       je        near ptr M00_L39
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-78]
       cmp       [rax],rcx
       jne       near ptr M00_L23
       mov       rsi,[rax+10]
M00_L09:
       cmp       qword ptr [r15+8],0
       je        near ptr M00_L24
M00_L10:
       mov       r14,[r15+10]
       mov       r13,[r15+18]
       xor       r12d,r12d
       test      rsi,rsi
       je        near ptr M00_L20
       mov       rcx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r13],rcx
       jne       near ptr M00_L31
       mov       rdx,[rsi+28]
       test      rdx,rdx
       je        near ptr M00_L25
       mov       rcx,1508B000068
       mov       rcx,[rcx]
       mov       r8,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],r8
       jne       near ptr M00_L30
       lea       rcx,[rdx+0C]
       mov       r8d,[rdx+8]
       add       r8d,r8d
       mov       [rbp-44],r8d
       mov       dword ptr [rbp-50],1B8B7DD7
       mov       dword ptr [rbp-58],73383025
       cmp       r8d,8
       jb        near ptr M00_L18
       mov       edx,r8d
       shr       edx,3
       xchg      ax,ax
M00_L11:
       mov       r10d,[rbp-50]
       add       r10d,[rcx]
       mov       [rbp-50],r10d
       mov       r10d,[rcx+4]
       mov       r9d,[rbp-50]
       mov       r11d,[rbp-58]
       xor       r11d,r9d
       rol       r9d,14
       add       r9d,r11d
       rol       r11d,9
       xor       r11d,r9d
       rol       r9d,1B
       add       r9d,r11d
       rol       r11d,13
       mov       [rbp-50],r9d
       mov       [rbp-58],r11d
       add       r10d,[rbp-50]
       mov       [rbp-50],r10d
       mov       r10d,[rbp-50]
       mov       r9d,[rbp-58]
       xor       r9d,r10d
       rol       r10d,14
       add       r10d,r9d
       rol       r9d,9
       xor       r9d,r10d
       rol       r10d,1B
       add       r10d,r9d
       rol       r9d,13
       mov       [rbp-50],r10d
       mov       [rbp-58],r9d
       add       rcx,8
       dec       edx
       jne       short M00_L11
       test      r8b,4
       jne       near ptr M00_L26
M00_L12:
       mov       edx,r8d
       and       rdx,7
       mov       ecx,[rcx+rdx-4]
       shr       ecx,8
       or        ecx,80000000
       not       r8d
       shl       r8d,3
       shrx      ecx,ecx,r8d
M00_L13:
       add       ecx,[rbp-50]
       mov       [rbp-50],ecx
       lea       rcx,[rbp-50]
       lea       rdx,[rbp-58]
       call      qword ptr [7FF9E64A6040]; System.Marvin.Block(UInt32 ByRef, UInt32 ByRef)
       lea       rcx,[rbp-50]
       lea       rdx,[rbp-58]
       call      qword ptr [7FF9E64A6040]; System.Marvin.Block(UInt32 ByRef, UInt32 ByRef)
       mov       eax,[rbp-58]
       xor       eax,[rbp-50]
M00_L14:
       mov       [rbp-3C],eax
       mov       rdx,[r15+8]
       mov       ecx,eax
       imul      rcx,[r15+20]
       shr       rcx,20
       inc       rcx
       mov       r8d,[rdx+8]
       mov       r11d,r8d
       imul      rcx,r11
       shr       rcx,20
       cmp       ecx,r8d
       jae       near ptr M00_L38
       mov       ecx,ecx
       lea       r10,[rdx+rcx*4+10]
       mov       [rbp-88],r10
       mov       r9d,[r10]
       dec       r9d
       jns       near ptr M00_L21
M00_L15:
       cmp       dword ptr [r15+30],0
       jg        near ptr M00_L33
       mov       edx,[r15+28]
       mov       [rbp-40],edx
       cmp       [r14+8],edx
       je        near ptr M00_L34
M00_L16:
       mov       edx,[rbp-40]
       mov       r14d,edx
       lea       ecx,[r14+1]
       mov       [r15+28],ecx
       mov       rcx,[r15+10]
       mov       r8,rcx
M00_L17:
       cmp       r14d,[r8+8]
       jae       near ptr M00_L38
       mov       ecx,r14d
       shl       rcx,4
       mov       [rbp-80],r8
       lea       rcx,[r8+rcx+10]
       mov       [rcx+8],eax
       mov       r10,[rbp-88]
       mov       edx,[r10]
       dec       edx
       mov       [rcx+0C],edx
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       inc       r14d
       mov       rdx,[rbp-88]
       mov       [rdx],r14d
       inc       dword ptr [r15+34]
       cmp       r12d,64
       jbe       near ptr M00_L07
       jmp       near ptr M00_L35
M00_L18:
       cmp       r8d,4
       jb        near ptr M00_L27
M00_L19:
       mov       edx,[rbp-50]
       mov       [rbp-98],rcx
       add       edx,[rcx]
       mov       [rbp-50],edx
       lea       rcx,[rbp-50]
       lea       rdx,[rbp-58]
       call      qword ptr [7FF9E64A6040]; System.Marvin.Block(UInt32 ByRef, UInt32 ByRef)
       mov       rax,[rbp-78]
       mov       rcx,[rbp-98]
       mov       r8d,[rbp-44]
       jmp       near ptr M00_L12
M00_L20:
       xor       edx,edx
       xor       r10d,r10d
       mov       eax,r10d
       jmp       near ptr M00_L14
M00_L21:
       cmp       r9d,[r14+8]
       jae       near ptr M00_L38
       mov       edx,r9d
       shl       rdx,4
       lea       r9,[r14+rdx+10]
       mov       [rbp-90],r9
       cmp       [r9+8],eax
       je        near ptr M00_L32
M00_L22:
       mov       r9d,[r9+0C]
       inc       r12d
       cmp       [r14+8],r12d
       jb        near ptr M00_L37
       test      r9d,r9d
       mov       eax,[rbp-3C]
       jge       short M00_L21
       jmp       near ptr M00_L15
M00_L23:
       mov       rcx,rax
       mov       r11,7FF9E5B40E78
       call      qword ptr [r11]
       mov       rsi,rax
       mov       rax,[rbp-78]
       jmp       near ptr M00_L09
M00_L24:
       mov       rcx,r15
       xor       edx,edx
       call      qword ptr [7FF9E5DC7750]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       mov       rax,[rbp-78]
       jmp       near ptr M00_L10
M00_L25:
       xor       ecx,ecx
       mov       eax,ecx
       jmp       near ptr M00_L14
M00_L26:
       jmp       near ptr M00_L19
M00_L27:
       mov       r8d,[rbp-44]
       mov       edx,80
       test      r8b,1
       je        short M00_L28
       mov       edx,r8d
       and       rdx,2
       movzx     edx,byte ptr [rcx+rdx]
       or        edx,8000
M00_L28:
       test      r8b,2
       je        short M00_L29
       shl       edx,10
       movzx     ecx,word ptr [rcx]
       or        edx,ecx
       mov       ecx,edx
       jmp       near ptr M00_L13
M00_L29:
       mov       ecx,edx
       jmp       near ptr M00_L13
M00_L30:
       mov       r8,[rcx]
       mov       r8,[r8+48]
       call      qword ptr [r8+18]
       jmp       near ptr M00_L14
M00_L31:
       mov       rcx,r13
       mov       rdx,rsi
       mov       r11,7FF9E5B40E90
       call      qword ptr [r11]
       jmp       near ptr M00_L14
M00_L32:
       mov       rdx,[r9]
       mov       rcx,r13
       mov       r8,rsi
       mov       r11,7FF9E5B40E98
       call      qword ptr [r11]
       test      eax,eax
       mov       r9,[rbp-90]
       jne       near ptr M00_L07
       jmp       near ptr M00_L22
M00_L33:
       mov       ecx,[r15+2C]
       mov       r8d,ecx
       dec       dword ptr [r15+30]
       mov       ecx,[r15+2C]
       cmp       ecx,[r14+8]
       jae       near ptr M00_L38
       shl       rcx,4
       mov       ecx,[r14+rcx+1C]
       neg       ecx
       add       ecx,0FFFFFFFD
       mov       [r15+2C],ecx
       mov       ecx,r8d
       mov       r8,r14
       mov       r14d,ecx
       jmp       near ptr M00_L17
M00_L34:
       mov       rcx,r15
       call      qword ptr [7FF9E64A47F8]
       mov       rcx,[r15+8]
       mov       r14d,[rbp-3C]
       mov       edx,r14d
       imul      rdx,[r15+20]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       imul      rdx,rax
       shr       rdx,20
       cmp       edx,[rcx+8]
       jae       short M00_L38
       mov       edx,edx
       lea       r10,[rcx+rdx*4+10]
       mov       rax,r10
       mov       [rbp-88],rax
       mov       eax,r14d
       jmp       near ptr M00_L16
M00_L35:
       mov       r14,[rbp-80]
       mov       rdx,r13
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M00_L07
       mov       edx,[r14+8]
       mov       rcx,r15
       mov       r8d,1
       call      qword ptr [7FF9E5F6D980]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,r15
       mov       rdx,rsi
       call      qword ptr [7FF9E5DC7810]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       jmp       near ptr M00_L07
M00_L36:
       mov       r11,7FF9E5B40E70
       call      qword ptr [r11]
       jmp       near ptr M00_L08
M00_L37:
       call      qword ptr [7FF9E5BFF498]
       int       3
M00_L38:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L39:
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-78]
       cmp       [rax],rcx
       jne       near ptr M00_L55
M00_L40:
       mov       ecx,[r15+28]
       test      ecx,ecx
       jle       short M00_L41
       mov       rax,[r15+10]
       mov       eax,[rax+8]
       cdq
       idiv      ecx
       cmp       eax,3
       jg        near ptr M00_L56
M00_L41:
       mov       ecx,[r15+28]
       sub       ecx,[r15+30]
       je        near ptr M00_L57
       xor       esi,esi
M00_L42:
       test      rsi,rsi
       jne       short M00_L43
       mov       rdx,r15
       mov       rcx,7FF9E6400918
       call      qword ptr [7FF9E63C61F0]; System.Collections.Frozen.FrozenSet.CreateFromSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
       mov       rsi,rax
M00_L43:
       mov       [rbp-60],rsi
       mov       rcx,[rbx+60]
       lea       r8,[rbp-60]
       mov       rdx,7FF9E640B688
       cmp       [rcx],ecx
       call      qword ptr [7FF9E63C7510]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
M00_L44:
       call      qword ptr [7FF9E619EFB8]
       mov       ecx,65
       mov       rdx,7FF9E5FF8D68
       call      qword ptr [7FF9E5BFF228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF9E5EC5AC0
       call      qword ptr [7FF9E5BFF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9E5BFD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9E5FF8D68
       call      qword ptr [7FF9E5BFF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9E5BFD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9E64A5F50]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9E63CF648]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L45:
       mov       r11,7FF9E5B40E50
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L00
M00_L46:
       mov       rcx,rsi
       mov       r11,7FF9E5B40E48
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L00
M00_L47:
       mov       rcx,[r14+8]
       mov       rdx,rdi
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       test      eax,eax
       je        near ptr M00_L01
       xor       r15d,r15d
       mov       rsi,r14
       jmp       near ptr M00_L42
M00_L48:
       mov       ecx,[r15+28]
       sub       ecx,[r15+30]
       je        near ptr M00_L41
       mov       rcx,r15
       call      qword ptr [7FF9E63C6B80]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].get_Comparer()
       mov       rcx,rax
       mov       rdx,rdi
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       test      eax,eax
       jne       near ptr M00_L41
       jmp       near ptr M00_L02
M00_L49:
       mov       r8,r14
       mov       rdx,r15
       mov       rcx,offset MT_System.Collections.Generic.HashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FF9E64A5F80]
       test      eax,eax
       je        near ptr M00_L03
       mov       rcx,r15
       mov       rdx,r14
       call      qword ptr [7FF9E64A4960]
       jmp       near ptr M00_L41
M00_L50:
       mov       r11,7FF9E5B40E60
       call      qword ptr [r11]
       mov       ecx,eax
       jmp       near ptr M00_L04
M00_L51:
       mov       rcx,rsi
       mov       r11,7FF9E5B40E58
       call      qword ptr [r11]
       mov       ecx,eax
       jmp       near ptr M00_L04
M00_L52:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,150A1000B28
       mov       r14,[rcx]
       jmp       near ptr M00_L06
M00_L53:
       mov       rcx,rsi
       mov       r11,7FF9E5B40E88
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L06
M00_L54:
       mov       rcx,rsi
       mov       r11,7FF9E5B40E68
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L06
M00_L55:
       mov       rcx,rax
       mov       r11,7FF9E5B40E80
       call      qword ptr [r11]
       jmp       near ptr M00_L40
M00_L56:
       mov       edx,ecx
       sub       edx,[r15+30]
       mov       rcx,r15
       call      qword ptr [7FF9E64A4978]
       jmp       near ptr M00_L41
M00_L57:
       mov       rcx,offset MT_System.Collections.Frozen.FrozenSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,150A1000B30
       mov       rcx,[rcx]
       cmp       rdi,[rcx+8]
       je        short M00_L58
       mov       rcx,offset MT_System.Collections.Frozen.EmptyFrozenSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L42
M00_L58:
       mov       rcx,offset MT_System.Collections.Frozen.FrozenSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,150A1000B30
       mov       rsi,[rdx]
       jmp       near ptr M00_L42
M00_L59:
       xor       r8d,r8d
       mov       [rbp-70],r8
       mov       [rbp-68],r8d
       lea       r8,[rbp-70]
       mov       rcx,7FF9E64D6DA0
       xor       edx,edx
       call      qword ptr [7FF9E64A5FE0]
       mov       rsi,rax
       jmp       near ptr M00_L43
       sub       rsp,28
       cmp       qword ptr [rbp-78],0
       je        short M00_L60
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-78]
       cmp       [rax],rcx
       je        short M00_L60
       mov       rcx,rax
       mov       r11,7FF9E5B40E80
       call      qword ptr [r11]
M00_L60:
       nop
       add       rsp,28
       ret
; Total bytes of code 2514
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
       mov       rcx,7FF9ED480B08
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
       call      qword ptr [7FF9E63CF0A8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9E5F65E60]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M02_L03:
       mov       esi,ebx
       or        esi,1
       jmp       short M02_L06
M02_L04:
       mov       ecx,esi
       call      qword ptr [7FF9E63CF0C0]
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
; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx]
       mov       rdx,rcx
       mov       eax,[rbx+10]
       cmp       eax,[rcx+14]
       jne       short M03_L00
       mov       ecx,[rbx+14]
       cmp       ecx,[rdx+10]
       jae       short M03_L01
       mov       rdx,[rdx+8]
       cmp       ecx,[rdx+8]
       jae       short M03_L02
       mov       ecx,ecx
       mov       rdx,[rdx+rcx*8+10]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       dword ptr [rbx+14]
       mov       eax,1
       add       rsp,20
       pop       rbx
       ret
M03_L00:
       call      qword ptr [7FF9E5BFFC60]
       int       3
M03_L01:
       xor       eax,eax
       mov       [rbx+8],rax
       mov       dword ptr [rbx+14],0FFFFFFFF
       add       rsp,20
       pop       rbx
       ret
M03_L02:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 101
```
```assembly
; System.Marvin.Block(UInt32 ByRef, UInt32 ByRef)
       mov       eax,[rcx]
       mov       r8d,eax
       xor       r8d,[rdx]
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       mov       [rcx],eax
       mov       [rdx],r8d
       ret
; Total bytes of code 37
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
       call      qword ptr [7FF9E5BF5A88]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       esi,eax
       movsxd    rdx,esi
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rdi,rax
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+0B0]
       test      rax,rax
       je        short M05_L01
       mov       rcx,rax
M05_L00:
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
M05_L01:
       mov       rdx,7FF9E649B148
       call      qword ptr [7FF9E5BFF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M05_L00
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
       call      qword ptr [7FF9EE0E7EC8]
       mov       rcx,rax
       movsxd    rdx,esi
       call      qword ptr [7FF9EE0E4088]; CORINFO_HELP_NEWARR_1_DIRECT
       mov       rbp,rax
       mov       r14d,[rbx+28]
       mov       rcx,[rbx+10]
       mov       rdx,rbp
       mov       r8d,r14d
       call      qword ptr [7FF9EE0F52F0]; Precode of System.Array.Copy(System.Array, System.Array, Int32)
       movzx     ecx,dil
       test      cl,1
       jne       near ptr M06_L06
M06_L00:
       movsxd    rcx,esi
       call      qword ptr [7FF9EE0F1B50]
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      qword ptr [7FF9EE0E3FE8]; CORINFO_HELP_ASSIGN_REF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,esi
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rbx+20],rax
       xor       ecx,ecx
       test      r14d,r14d
       jle       short M06_L03
       cmp       [rbp+8],r14d
       jl        near ptr M06_L04
M06_L01:
       mov       edx,ecx
       shl       rdx,4
       lea       rdx,[rbp+rdx+10]
       cmp       dword ptr [rdx+0C],0FFFFFFFF
       jl        short M06_L02
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
       jae       near ptr M06_L11
       mov       r10d,r10d
       lea       rax,[r8+r10*4+10]
       mov       r8d,[rax]
       dec       r8d
       mov       [rdx+0C],r8d
       lea       edx,[rcx+1]
       mov       [rax],edx
M06_L02:
       inc       ecx
       cmp       ecx,r14d
       jl        short M06_L01
M06_L03:
       lea       rcx,[rbx+10]
       mov       rdx,rbp
       call      qword ptr [7FF9EE0E3FE8]; CORINFO_HELP_ASSIGN_REF
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
M06_L04:
       cmp       ecx,[rbp+8]
       jae       near ptr M06_L11
       mov       eax,ecx
       shl       rax,4
       lea       rdx,[rbp+rax+10]
       cmp       dword ptr [rdx+0C],0FFFFFFFF
       jl        short M06_L05
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
       jae       near ptr M06_L11
       mov       eax,r10d
       lea       rax,[r8+rax*4+10]
       mov       r8d,[rax]
       dec       r8d
       mov       [rdx+0C],r8d
       lea       edx,[rcx+1]
       mov       [rax],edx
M06_L05:
       inc       ecx
       cmp       ecx,r14d
       jl        short M06_L04
       jmp       near ptr M06_L03
M06_L06:
       mov       rcx,[rbx]
       call      qword ptr [7FF9EE0E74F8]
       mov       rdi,rax
       mov       rcx,[rbx+18]
       call      qword ptr [7FF9EE0F3730]
       mov       rcx,rax
       lea       r11,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       [rcx],ecx
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF9EE0E4090]; Precode of System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdi,rax
       lea       rcx,[rbx+18]
       mov       rdx,rdi
       call      qword ptr [7FF9EE0E3FE8]; CORINFO_HELP_ASSIGN_REF
       xor       r15d,r15d
       cmp       r15d,r14d
       jge       near ptr M06_L00
M06_L07:
       cmp       r15d,[rbp+8]
       jae       short M06_L11
       mov       rcx,r15
       shl       rcx,4
       lea       r13,[rbp+rcx+10]
       cmp       dword ptr [r13+0C],0FFFFFFFF
       jl        short M06_L10
       cmp       qword ptr [r13],0
       jne       short M06_L08
       xor       r12d,r12d
       jmp       short M06_L09
M06_L08:
       mov       rcx,[rbx]
       call      qword ptr [7FF9EE0E9150]
       mov       rdx,[r13]
       mov       rcx,rdi
       mov       r11,rax
       call      qword ptr [rax]
       mov       r12d,eax
M06_L09:
       mov       [r13+8],r12d
M06_L10:
       inc       r15d
       cmp       r15d,r14d
       jl        short M06_L07
       jmp       near ptr M06_L00
M06_L11:
       call      qword ptr [7FF9EE0E3FD8]
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
       je        near ptr M07_L07
       mov       rdi,[rbx+10]
       xor       ebp,ebp
       mov       r14,[rbx+18]
       test      rsi,rsi
       je        near ptr M07_L11
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+78]
       test      r11,r11
       je        near ptr M07_L08
M07_L00:
       mov       rcx,offset MT_System.Collections.Generic.ObjectEqualityComparer<System.RuntimeType>
       cmp       [r14],rcx
       jne       near ptr M07_L13
       mov       [rsp+38],rsi
       xor       ecx,ecx
       mov       [rsp+30],rcx
       lea       rcx,[rsp+38]
       cmp       qword ptr [rsp+30],0
       jne       short M07_L01
       mov       rcx,[rsp+38]
       mov       [rsp+30],rcx
       lea       rcx,[rsp+30]
       cmp       qword ptr [rsp+30],0
       je        near ptr M07_L12
M07_L01:
       mov       r15,[rcx]
       mov       rcx,offset MT_System.RuntimeType
       cmp       [r15],rcx
       jne       near ptr M07_L10
       mov       rcx,r15
       call      00007FFA45809590
       test      eax,eax
       je        near ptr M07_L09
M07_L02:
       mov       r15d,eax
M07_L03:
       xor       ecx,ecx
       mov       [rsp+30],rcx
M07_L04:
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
       jae       near ptr M07_L18
       mov       edx,edx
       lea       rcx,[rcx+rdx*4+10]
       mov       r13d,[rcx]
       dec       r13d
       js        short M07_L07
M07_L05:
       mov       r12d,[rdi+8]
       cmp       r13d,r12d
       jae       near ptr M07_L18
       mov       ecx,r13d
       shl       rcx,4
       lea       rax,[rdi+rcx+10]
       mov       [rsp+28],rax
       cmp       [rax+8],r15d
       je        near ptr M07_L14
M07_L06:
       mov       rax,[rsp+28]
       mov       r13d,[rax+0C]
       inc       ebp
       cmp       r12d,ebp
       jb        near ptr M07_L17
       test      r13d,r13d
       jge       short M07_L05
M07_L07:
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
M07_L08:
       mov       rdx,7FF9E646D898
       call      qword ptr [7FF9E5BFF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M07_L00
M07_L09:
       mov       rcx,r15
       call      qword ptr [7FF9E5DC77F8]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       jmp       near ptr M07_L02
M07_L10:
       mov       rcx,r15
       mov       rax,[r15]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
       mov       r15d,eax
       jmp       near ptr M07_L03
M07_L11:
       xor       r15d,r15d
       jmp       near ptr M07_L04
M07_L12:
       xor       r15d,r15d
       jmp       near ptr M07_L03
M07_L13:
       mov       rcx,r14
       mov       rdx,rsi
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       near ptr M07_L04
M07_L14:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+80]
       test      r11,r11
       je        short M07_L15
       jmp       short M07_L16
M07_L15:
       mov       rdx,7FF9E646D8B0
       call      qword ptr [7FF9E5BFF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M07_L16:
       mov       rax,[rsp+28]
       mov       rdx,[rax]
       mov       rcx,r14
       mov       r8,rsi
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M07_L06
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
M07_L17:
       call      qword ptr [7FF9E5BFF498]
       int       3
M07_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 547
```
```assembly
; System.Collections.Frozen.FrozenSet.CreateFromSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,188
       xor       eax,eax
       mov       [rsp+0D8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+0E0],xmm4
       mov       [rsp+0F0],rax
       mov       [rsp+180],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rcx,[rbx]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rdx,offset MT_System.String
       cmp       [rcx],rdx
       je        near ptr M08_L53
       mov       rdi,[rbx+18]
       test      rdi,rdi
       je        near ptr M08_L56
M08_L00:
       mov       rcx,[rsi+18]
       mov       rdx,offset MT_System.String
       cmp       [rcx],rdx
       je        near ptr M08_L59
M08_L01:
       mov       ecx,[rbx+28]
       sub       ecx,[rbx+30]
       cmp       ecx,4
       jle       near ptr M08_L88
       mov       rcx,[rsi+18]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        near ptr M08_L18
M08_L02:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,[rbx]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rdx,offset MT_System.String
       cmp       [rcx],rdx
       je        near ptr M08_L91
       mov       rdx,[rbx+18]
       test      rdx,rdx
       je        near ptr M08_L94
M08_L03:
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+10],rcx
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx+8]
       mov       rax,[rdx+20]
       test      rax,rax
       je        near ptr M08_L08
M08_L04:
       lea       rcx,[rsi+10]
       mov       rdx,rsi
       call      rax
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx+10]
       mov       rdi,[rdx+28]
       test      rdi,rdi
       je        near ptr M08_L09
M08_L05:
       mov       rcx,rdi
       mov       ebp,[rbx+28]
       sub       ebp,[rbx+30]
       mov       [rsp+0D4],ebp
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       xor       r15d,r15d
       mov       r13d,ebp
       test      r13d,r13d
       jl        near ptr M08_L97
       mov       r12,[rbx+10]
       xor       eax,eax
       cmp       dword ptr [rbx+28],0
       jg        near ptr M08_L52
M08_L06:
       mov       rcx,rdi
       mov       edx,ebp
       call      CORINFO_HELP_NEWARR_1_PTR
       lea       rcx,[rsi+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,1508B001D88
       mov       r13,[rcx]
       mov       [rsp+48],r13
       mov       rcx,r13
       mov       edx,ebp
       call      qword ptr [7FF9E62069A0]; System.Buffers.SharedArrayPool`1[[System.Int32, System.Private.CoreLib]].Rent(Int32)
       mov       rbx,rax
       mov       [rsp+0C0],rbx
       mov       edi,ebp
       test      rbx,rbx
       je        near ptr M08_L98
       cmp       [rbx+8],edi
       jb        near ptr M08_L108
       lea       r15,[rbx+10]
M08_L07:
       xor       r12d,r12d
       cmp       ebp,r12d
       jg        near ptr M08_L17
       jmp       near ptr M08_L99
M08_L08:
       mov       rdx,7FF9E649E280
       call      qword ptr [7FF9E5BFF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M08_L04
       nop       dword ptr [rax]
M08_L09:
       mov       rdx,7FF9E649E1A8
       call      qword ptr [7FF9E5BFF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M08_L05
M08_L10:
       mov       rdx,7FF9E649E1B0
       call      qword ptr [7FF9E5BFF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M08_L11:
       mov       rcx,[rsi+8]
       mov       rdx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rdx
       jne       near ptr M08_L105
       mov       r8,[rsp+0B8]
       mov       rdx,[r8+28]
       test      rdx,rdx
       je        near ptr M08_L100
       mov       rcx,1508B000068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M08_L104
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,1B8B7DD7
       mov       r8d,73383025
       cmp       edx,8
       jb        near ptr M08_L19
       mov       r9d,edx
       shr       r9d,3
M08_L12:
       add       eax,[rcx]
       mov       r11d,[rcx+4]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       add       r11d,eax
       mov       eax,r8d
       xor       eax,r11d
       rol       r11d,14
       add       r11d,eax
       rol       eax,9
       xor       eax,r11d
       rol       r11d,1B
       add       r11d,eax
       rol       eax,13
       mov       r8d,r11d
       add       rcx,8
       dec       r9d
       mov       r10d,eax
       mov       eax,r8d
       mov       r8d,r10d
       jne       short M08_L12
       test      dl,4
       jne       near ptr M08_L20
M08_L13:
       mov       r9d,edx
       and       r9,7
       mov       ecx,[rcx+r9-4]
       shr       ecx,8
       or        ecx,80000000
       not       edx
       shl       edx,3
       shrx      ecx,ecx,edx
M08_L14:
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
       mov       eax,ecx
       rol       eax,14
       add       eax,edx
       rol       edx,9
       xor       edx,eax
       rol       eax,1B
       add       eax,edx
       mov       r8d,edx
       rol       r8d,13
       xor       eax,r8d
M08_L15:
       mov       r10,[rsp+0B0]
M08_L16:
       mov       [r10],eax
       inc       r12d
       cmp       ebp,r12d
       jle       near ptr M08_L22
       mov       ebp,[rsp+0D4]
M08_L17:
       cmp       r12d,edi
       jae       near ptr M08_L153
       lea       rax,[r15+r12*4]
       mov       r8,[r14+r12*8+10]
       mov       [rsp+0B8],r8
       mov       [rsp+0B0],rax
       test      r8,r8
       je        short M08_L21
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx+10]
       mov       r11,[rdx+30]
       test      r11,r11
       je        near ptr M08_L10
       jmp       near ptr M08_L11
M08_L18:
       mov       rcx,rsi
       mov       rdx,7FF9E649C858
       call      qword ptr [7FF9E5BFF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M08_L02
M08_L19:
       cmp       edx,4
       jb        near ptr M08_L101
M08_L20:
       add       eax,[rcx]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       jmp       near ptr M08_L13
M08_L21:
       mov       r10,rax
       xor       eax,eax
       jmp       near ptr M08_L16
M08_L22:
       mov       rcx,r15
       mov       r12d,edi
       mov       [rsp+0E8],rcx
       mov       [rsp+0F0],r12d
       lea       rcx,[rsp+0E8]
       xor       edx,edx
       call      qword ptr [7FF9E63C7288]; System.Collections.Frozen.FrozenHashTable.CalcNumBuckets(System.ReadOnlySpan`1<Int32>, Boolean)
       mov       r8d,eax
       mov       [rsp+158],r8d
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,r8d
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rsp+150],rax
       mov       rcx,r13
       lea       edx,[r8+r12]
       call      qword ptr [7FF9E62069A0]; System.Buffers.SharedArrayPool`1[[System.Int32, System.Private.CoreLib]].Rent(Int32)
       mov       [rsp+0A8],rax
       test      rax,rax
       je        near ptr M08_L106
       mov       edx,[rsp+158]
       cmp       [rax+8],edx
       jb        near ptr M08_L108
       lea       r8,[rax+10]
       mov       r10d,edx
M08_L23:
       mov       [rsp+60],r8
       mov       [rsp+108],r10d
       test      rax,rax
       je        near ptr M08_L107
       mov       ecx,edx
       mov       r9d,r12d
       add       rcx,r9
       mov       r9d,[rax+8]
       cmp       rcx,r9
       ja        near ptr M08_L108
       mov       edx,edx
       lea       r9,[rax+rdx*4+10]
M08_L24:
       mov       [rsp+58],r9
       mov       [rsp+104],r12d
       mov       edx,r10d
       mov       rcx,rdx
       cmp       rcx,8
       jb        near ptr M08_L109
       lea       r11,[rcx*4]
       mov       [rsp+148],r11
       and       r11,0FFFFFFFFFFFFFFC0
       xor       r13d,r13d
       cmp       rcx,10
       jb        short M08_L26
M08_L25:
       vpcmpeqd  ymm0,ymm0,ymm0
       vmovups   [r8+r13],ymm0
       vmovups   [r8+r13+20],ymm0
       add       r13,40
       cmp       r13,r11
       jb        short M08_L25
M08_L26:
       mov       r11,[rsp+148]
       test      r11b,20
       je        short M08_L27
       vpcmpeqd  ymm0,ymm0,ymm0
       vmovups   [r8+r13],ymm0
M08_L27:
       vpcmpeqd  ymm0,ymm0,ymm0
       vmovups   [r8+r11-20],ymm0
M08_L28:
       xor       ecx,ecx
       test      edi,edi
       jle       near ptr M08_L112
       cmp       edi,r12d
       jg        near ptr M08_L49
       jmp       short M08_L29
M08_L29:
       mov       r11d,ecx
       mov       r11d,[r15+r11*4]
       mov       r13,[rsp+150]
       imul      r11,r13
       shr       r11,20
       inc       r11
       imul      r11,rdx
       shr       r11,20
       cmp       r11d,r10d
       jae       near ptr M08_L153
       mov       r11d,r11d
       lea       r11,[r8+r11*4]
       mov       ebx,ecx
       mov       eax,[r11]
       mov       [r9+rbx*4],eax
       mov       [r11],ecx
       inc       ecx
       cmp       ecx,edi
       jl        short M08_L29
M08_L30:
       mov       edx,edi
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbx,rax
       mov       edx,[rsp+108]
       mov       rcx,offset MT_System.Collections.Frozen.FrozenHashTable+Bucket[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       [rsp+0A0],rax
       xor       ecx,ecx
       xor       edx,edx
       cmp       dword ptr [rax+8],0
       jle       near ptr M08_L38
       mov       r8d,[rsp+108]
       cmp       [rax+8],r8d
       jg        near ptr M08_L35
       jmp       short M08_L32
M08_L31:
       inc       edx
       cmp       [rax+8],edx
       jle       near ptr M08_L38
M08_L32:
       mov       r8d,edx
       mov       r10,[rsp+60]
       mov       r8d,[r10+r8*4]
       test      r8d,r8d
       jl        short M08_L31
       xor       r9d,r9d
       mov       r11d,ecx
M08_L33:
       cmp       r8d,edi
       jae       near ptr M08_L153
       mov       r13d,r8d
       lea       r13,[r15+r13*4]
       mov       r12d,[r13]
       cmp       ecx,[rbx+8]
       jae       near ptr M08_L153
       mov       ebp,ecx
       mov       [rbx+rbp*4+10],r12d
       mov       [r13],ecx
       inc       ecx
       inc       r9d
       cmp       r8d,[rsp+104]
       jae       near ptr M08_L153
       mov       r8d,r8d
       mov       rbp,[rsp+58]
       mov       r8d,[rbp+r8*4]
       test      r8d,r8d
       jge       short M08_L33
       mov       r12d,[rsp+104]
       mov       r13,[rsp+150]
       lea       r8d,[r11+r9-1]
       mov       r9d,edx
       lea       r9,[rax+r9*8+10]
       mov       [r9],r11d
       mov       [r9+4],r8d
       jmp       near ptr M08_L31
M08_L34:
       inc       edx
       cmp       [rax+8],edx
       mov       rax,[rsp+0A0]
       mov       r8d,[rsp+108]
       jle       near ptr M08_L38
M08_L35:
       cmp       edx,r8d
       jae       near ptr M08_L153
       mov       r11d,edx
       mov       r10,[rsp+60]
       mov       r11d,[r10+r11*4]
       test      r11d,r11d
       jl        short M08_L34
       xor       r9d,r9d
       mov       r12d,ecx
M08_L36:
       cmp       r11d,edi
       jae       near ptr M08_L153
       mov       r13d,r11d
       lea       r13,[r15+r13*4]
       mov       r8d,[r13]
       cmp       ecx,[rbx+8]
       jae       near ptr M08_L153
       mov       ebp,ecx
       mov       [rbx+rbp*4+10],r8d
       mov       [r13],ecx
       inc       ecx
       inc       r9d
       mov       ebp,[rsp+104]
       cmp       r11d,ebp
       jae       near ptr M08_L153
       mov       r11d,r11d
       mov       r13,[rsp+58]
       mov       r11d,[r13+r11*4]
       test      r11d,r11d
       jge       short M08_L36
       mov       r13,[rsp+150]
       lea       r9d,[r12+r9-1]
       mov       r11d,edx
       lea       r11,[rax+r11*8+10]
       mov       [r11],r12d
       mov       [r11+4],r9d
       mov       r12d,[rsp+104]
       jmp       near ptr M08_L34
M08_L37:
       cmp       ebx,edi
       jae       near ptr M08_L153
       mov       ecx,ebx
       mov       r13d,[r15+rcx*4]
       mov       rcx,[rsi+18]
       cmp       ebx,ebp
       jae       near ptr M08_L153
       mov       r8d,ebx
       mov       r8,[r14+r8*8+10]
       movsxd    rdx,r13d
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       inc       ebx
       cmp       ebx,edi
       jl        short M08_L37
       jmp       near ptr M08_L44
M08_L38:
       mov       r12,[rsp+48]
       mov       rdx,r12
       mov       [rsp+98],rdx
       mov       r8,[rsp+0A8]
       test      r8,r8
       je        near ptr M08_L135
       mov       rdx,[rsp+98]
       mov       ecx,[r8+8]
       dec       ecx
       or        ecx,0F
       xor       r10d,r10d
       lzcnt     r10d,ecx
       xor       r10d,1F
       add       r10d,0FFFFFFFD
       mov       [rsp+144],r10d
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+238],7
       jle       near ptr M08_L115
       mov       rcx,[rcx+240]
       mov       r9,[rcx+38]
       test      r9,r9
       je        near ptr M08_L114
M08_L39:
       mov       [rsp+50],r9
       mov       r11,[r9+10]
       test      r11,r11
       je        near ptr M08_L116
M08_L40:
       xor       ecx,ecx
       mov       dword ptr [rsp+13C],1
       mov       r10d,[rsp+144]
       cmp       [r11+8],r10d
       jbe       near ptr M08_L41
       mov       dword ptr [rsp+140],1
       mov       edx,10
       shlx      edx,edx,r10d
       mov       r8,[rsp+0A8]
       cmp       [r8+8],edx
       jne       near ptr M08_L117
       mov       edx,r10d
       shl       rdx,4
       lea       r11,[r11+rdx+10]
       mov       [rsp+88],r11
       mov       rdx,[r11]
       mov       [rsp+80],rdx
       mov       rcx,r11
       mov       rdx,r8
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       rdx,[rsp+88]
       mov       [rdx+8],ecx
       cmp       qword ptr [rsp+80],0
       jne       near ptr M08_L118
       mov       rax,[rsp+0A0]
       mov       ecx,[rsp+140]
       mov       r10d,[rsp+144]
M08_L41:
       mov       r11,1508B000C90
       mov       r11,[r11]
       mov       [rsp+40],r11
       mov       rdx,r11
       mov       [rsp+90],rdx
       cmp       byte ptr [rdx+9D],0
       jne       near ptr M08_L131
M08_L42:
       lea       rcx,[rsi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+28]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rsi+30],r13
       xor       ebx,ebx
       test      edi,edi
       jle       short M08_L44
       mov       ebp,[rsp+0D4]
       cmp       ebp,edi
       jl        near ptr M08_L37
       xor       ebx,ebx
M08_L43:
       mov       r13d,[r15+rbx]
       mov       rcx,[rsi+18]
       mov       r8,[r14+rbx*2+10]
       movsxd    rdx,r13d
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       add       rbx,4
       dec       edi
       jne       short M08_L43
M08_L44:
       mov       rbx,[rsp+0C0]
       test      rbx,rbx
       je        near ptr M08_L135
       mov       ecx,[rbx+8]
       dec       ecx
       or        ecx,0F
       xor       edi,edi
       lzcnt     edi,ecx
       xor       edi,1F
       add       edi,0FFFFFFFD
       mov       rbp,[rsp+50]
       mov       rax,[rbp+10]
       test      rax,rax
       je        near ptr M08_L136
M08_L45:
       xor       ebp,ebp
       mov       r14d,1
       cmp       [rax+8],edi
       jbe       short M08_L46
       mov       ebp,1
       mov       ecx,10
       shlx      ecx,ecx,edi
       cmp       [rbx+8],ecx
       jne       near ptr M08_L137
       cmp       edi,[rax+8]
       jae       near ptr M08_L153
       mov       ecx,edi
       shl       rcx,4
       lea       r15,[rax+rcx+10]
       mov       r13,[r15]
       mov       rcx,r15
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r15+8],ecx
       test      r13,r13
       jne       near ptr M08_L138
M08_L46:
       mov       r15,[rsp+40]
       cmp       byte ptr [r15+9D],0
       jne       near ptr M08_L150
M08_L47:
       mov       rax,rsi
       vzeroupper
       add       rsp,188
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M08_L48:
       mov       r8,[rsp+60]
       mov       r9,[rsp+58]
       mov       r10d,[rsp+108]
M08_L49:
       mov       r11d,ecx
       mov       r11d,[r15+r11*4]
       imul      r11,[rsp+150]
       shr       r11,20
       inc       r11
       imul      r11,rdx
       shr       r11,20
       cmp       r11d,r10d
       jae       near ptr M08_L153
       mov       r11d,r11d
       lea       r11,[r8+r11*4]
       cmp       ecx,r12d
       jae       near ptr M08_L153
       mov       ebx,ecx
       mov       [rsp+178],rbx
       mov       ebx,[r11]
       mov       rax,[rsp+178]
       mov       [r9+rax*4],ebx
       mov       [r11],ecx
       inc       ecx
       cmp       ecx,edi
       mov       r12d,[rsp+104]
       jl        short M08_L48
       jmp       near ptr M08_L113
M08_L50:
       lea       edx,[r15+1]
       mov       [rsp+15C],edx
       mov       r8,[r8]
       movsxd    rdx,r15d
       mov       rcx,r14
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       dec       r13d
       mov       r15d,[rsp+15C]
M08_L51:
       mov       rax,[rsp+0C8]
       inc       eax
       mov       rcx,rax
       cmp       ecx,[rbx+28]
       mov       rax,rcx
       jge       near ptr M08_L06
M08_L52:
       test      r13d,r13d
       je        near ptr M08_L06
       cmp       eax,[r12+8]
       jae       near ptr M08_L153
       mov       [rsp+0C8],rax
       mov       r8,rax
       shl       r8,4
       lea       r8,[r12+r8+10]
       cmp       dword ptr [r8+0C],0FFFFFFFF
       jl        short M08_L51
       jmp       short M08_L50
M08_L53:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdi,[rdx+90]
       test      rdi,rdi
       je        short M08_L54
       jmp       short M08_L55
M08_L54:
       mov       rdx,7FF9E649ACA0
       call      qword ptr [7FF9E5BFF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
M08_L55:
       mov       rdx,[rbx+18]
       mov       rcx,offset MT_System.Collections.Generic.IEqualityComparer<System.String>
       call      qword ptr [7FF9E5BF58D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rcx,rax
       call      qword ptr [7FF9E64A4918]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF9E5BF58D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdi,rax
       jmp       near ptr M08_L00
M08_L56:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+88]
       test      rdx,rdx
       je        short M08_L57
       jmp       short M08_L58
M08_L57:
       mov       rdx,7FF9E649AC90
       call      qword ptr [7FF9E5BFF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M08_L58:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdi,[rax]
       jmp       near ptr M08_L00
M08_L59:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF9E5DC7810]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       test      eax,eax
       jge       near ptr M08_L01
       mov       rcx,[rsi+18]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       je        short M08_L60
       jmp       short M08_L61
M08_L60:
       mov       rcx,rsi
       mov       rdx,7FF9E649D710
       call      qword ptr [7FF9E5BFF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M08_L61:
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       cmp       [rax],rdi
       je        short M08_L62
       mov       rdx,1508B000068
       cmp       rdi,[rdx]
       je        short M08_L62
       mov       rdx,1508B000070
       cmp       rdi,[rdx]
       jne       near ptr M08_L01
M08_L62:
       mov       rdx,rdi
       mov       rcx,offset MT_System.Collections.Generic.IEqualityComparer<System.String>
       call      qword ptr [7FF9E5BF58D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdi,rax
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.HashSet<System.String>
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       rbx,rax
       mov       edx,[rbx+28]
       sub       edx,[rbx+30]
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbp,rax
       mov       r9d,[rbx+28]
       sub       r9d,[rbx+30]
       mov       rcx,rbx
       mov       rdx,rbp
       xor       r8d,r8d
       call      qword ptr [7FF9E5F6DA28]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].CopyTo(System.__Canon[], Int32, Int32)
       mov       ebx,7FFFFFFF
       xor       r14d,r14d
       xor       r15d,r15d
       xor       ecx,ecx
       jmp       short M08_L66
M08_L63:
       mov       rdx,[rbp+rcx*8+10]
       cmp       [rdx+8],ebx
       jge       short M08_L64
       mov       ebx,[rdx+8]
M08_L64:
       cmp       [rdx+8],r14d
       jle       short M08_L65
       mov       r14d,[rdx+8]
M08_L65:
       mov       edx,[rdx+8]
       mov       r8d,1
       shlx      rdx,r8,rdx
       or        r15,rdx
       inc       ecx
M08_L66:
       cmp       [rbp+8],ecx
       jg        short M08_L63
       mov       rcx,rbp
       mov       rdx,rdi
       mov       r8d,ebx
       mov       r9d,r14d
       call      qword ptr [7FF9E64A58F0]
       mov       r13,rax
       test      r13,r13
       je        short M08_L69
       mov       rcx,[rsi+18]
       cmp       qword ptr [rcx+8],30
       jle       short M08_L67
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M08_L67
       jmp       short M08_L68
M08_L67:
       mov       rcx,rsi
       mov       rdx,7FF9E649DB08
       call      qword ptr [7FF9E5BFF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M08_L68:
       mov       rdx,r13
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       nop
       vzeroupper
       add       rsp,188
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M08_L69:
       lea       rdx,[rbp+10]
       mov       r8d,[rbp+8]
       mov       [rsp+0D8],rdx
       mov       [rsp+0E0],r8d
       mov       [rsp+20],r14d
       lea       rdx,[rsp+0D8]
       mov       r8,1508B000070
       cmp       rdi,[r8]
       sete      r8b
       movzx     r8d,r8b
       lea       rcx,[rsp+160]
       mov       r9d,ebx
       call      qword ptr [7FF9E64A5908]
       mov       ebx,[rsp+168]
       movzx     r14d,byte ptr [rsp+160]
       movzx     r12d,byte ptr [rsp+161]
       mov       r13d,[rsp+164]
       mov       eax,[rsp+16C]
       mov       [rsp+100],eax
       mov       edx,[rsp+170]
       mov       [rsp+0FC],edx
       test      ebx,ebx
       je        near ptr M08_L81
       test      r13d,r13d
       jge       near ptr M08_L75
       test      r14d,r14d
       je        near ptr M08_L72
       test      r12d,r12d
       jne       short M08_L70
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_RightJustifiedCaseInsensitiveSubstring
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       r15d,[rsp+0FC]
       mov       [rsp+20],r15d
       mov       [rsp+28],r13d
       mov       [rsp+30],ebx
       mov       rcx,r14
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+100]
       call      qword ptr [7FF9E64A5920]
       jmp       short M08_L71
M08_L70:
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_RightJustifiedCaseInsensitiveAsciiSubstring
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       r15d,[rsp+0FC]
       mov       [rsp+20],r15d
       mov       [rsp+28],r13d
       mov       [rsp+30],ebx
       mov       rcx,r14
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+100]
       call      qword ptr [7FF9E64A5920]
M08_L71:
       mov       r13,r14
       jmp       near ptr M08_L85
M08_L72:
       cmp       ebx,1
       je        short M08_L73
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_RightJustifiedSubstring
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       r15d,[rsp+0FC]
       mov       [rsp+20],r15d
       mov       [rsp+28],r13d
       mov       [rsp+30],ebx
       mov       rcx,r12
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+100]
       call      qword ptr [7FF9E64A5920]
       jmp       short M08_L74
M08_L73:
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_RightJustifiedSingleChar
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       r15d,[rsp+0FC]
       mov       [rsp+20],r15d
       mov       [rsp+28],r13d
       mov       dword ptr [rsp+30],1
       mov       rcx,r12
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+100]
       call      qword ptr [7FF9E64A5920]
M08_L74:
       mov       r13,r12
       jmp       near ptr M08_L85
M08_L75:
       test      r14d,r14d
       je        near ptr M08_L78
       test      r12d,r12d
       jne       short M08_L76
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_LeftJustifiedCaseInsensitiveSubstring
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       r15d,[rsp+0FC]
       mov       [rsp+20],r15d
       mov       [rsp+28],r13d
       mov       [rsp+30],ebx
       mov       rcx,r14
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+100]
       call      qword ptr [7FF9E64A5920]
       jmp       short M08_L77
M08_L76:
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_LeftJustifiedCaseInsensitiveAsciiSubstring
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       r15d,[rsp+0FC]
       mov       [rsp+20],r15d
       mov       [rsp+28],r13d
       mov       [rsp+30],ebx
       mov       rcx,r14
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+100]
       call      qword ptr [7FF9E64A5920]
M08_L77:
       mov       r13,r14
       jmp       near ptr M08_L85
M08_L78:
       cmp       ebx,1
       je        short M08_L79
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_LeftJustifiedSubstring
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       r15d,[rsp+0FC]
       mov       [rsp+20],r15d
       mov       [rsp+28],r13d
       mov       [rsp+30],ebx
       mov       rcx,r12
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+100]
       call      qword ptr [7FF9E64A5920]
       jmp       short M08_L80
M08_L79:
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_LeftJustifiedSingleChar
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       r15d,[rsp+0FC]
       mov       [rsp+20],r15d
       mov       [rsp+28],r13d
       mov       dword ptr [rsp+30],1
       mov       rcx,r12
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+100]
       call      qword ptr [7FF9E64A5920]
M08_L80:
       mov       r13,r12
       jmp       near ptr M08_L85
M08_L81:
       test      r14d,r14d
       je        short M08_L84
       test      r12d,r12d
       jne       short M08_L82
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_FullCaseInsensitive
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       ebx,[rsp+0FC]
       mov       [rsp+20],ebx
       mov       [rsp+28],r15
       mov       rcx,r13
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+100]
       call      qword ptr [7FF9E64A5938]
       jmp       short M08_L83
M08_L82:
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_FullCaseInsensitiveAscii
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       ebx,[rsp+0FC]
       mov       [rsp+20],ebx
       mov       [rsp+28],r15
       mov       rcx,r13
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+100]
       call      qword ptr [7FF9E64A5950]
M08_L83:
       jmp       short M08_L85
M08_L84:
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_Full
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       ebx,[rsp+0FC]
       mov       [rsp+20],ebx
       mov       [rsp+28],r15
       mov       rcx,r13
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+100]
       call      qword ptr [7FF9E64A5968]
M08_L85:
       mov       rcx,[rsi+18]
       cmp       qword ptr [rcx+8],30
       jle       short M08_L86
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M08_L86
       jmp       short M08_L87
M08_L86:
       mov       rcx,rsi
       mov       rdx,7FF9E649DB08
       call      qword ptr [7FF9E5BFF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M08_L87:
       mov       rdx,r13
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       nop
       vzeroupper
       add       rsp,188
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M08_L88:
       mov       rcx,[rsi+18]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M08_L89
       jmp       short M08_L90
M08_L89:
       mov       rcx,rsi
       mov       rdx,7FF9E649D5F0
       call      qword ptr [7FF9E5BFF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M08_L90:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF9E64A60A0]
       mov       rax,rsi
       vzeroupper
       add       rsp,188
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M08_L91:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdi,[rdx+90]
       test      rdi,rdi
       je        short M08_L92
       jmp       short M08_L93
M08_L92:
       mov       rdx,7FF9E649ACA0
       call      qword ptr [7FF9E5BFF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
M08_L93:
       mov       rdx,[rbx+18]
       mov       rcx,offset MT_System.Collections.Generic.IEqualityComparer<System.String>
       call      qword ptr [7FF9E5BF58D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rcx,rax
       call      qword ptr [7FF9E64A4918]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF9E5BF58D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdx,rax
       jmp       near ptr M08_L03
M08_L94:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+88]
       test      rdx,rdx
       je        short M08_L95
       jmp       short M08_L96
M08_L95:
       mov       rdx,7FF9E649AC90
       call      qword ptr [7FF9E5BFF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M08_L96:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       jmp       near ptr M08_L03
M08_L97:
       mov       ecx,28F
       mov       rdx,7FF9E5B34000
       call      qword ptr [7FF9E5BFF228]
       mov       rdx,rax
       mov       ecx,r13d
       call      qword ptr [7FF9E63CDAE8]
       int       3
M08_L98:
       test      edi,edi
       jne       near ptr M08_L108
       xor       r15d,r15d
       xor       edi,edi
       jmp       near ptr M08_L07
M08_L99:
       jmp       near ptr M08_L22
M08_L100:
       xor       eax,eax
       jmp       near ptr M08_L15
M08_L101:
       mov       r9d,80
       test      dl,1
       je        short M08_L102
       mov       r9d,edx
       and       r9,2
       movzx     r9d,byte ptr [rcx+r9]
       or        r9d,8000
M08_L102:
       test      dl,2
       je        short M08_L103
       shl       r9d,10
       movzx     ecx,word ptr [rcx]
       or        r9d,ecx
       mov       ecx,r9d
       jmp       near ptr M08_L14
M08_L103:
       mov       ecx,r9d
       jmp       near ptr M08_L14
M08_L104:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       jmp       near ptr M08_L15
M08_L105:
       mov       r8,[rsp+0B8]
       mov       rdx,r8
       call      qword ptr [r11]
       jmp       near ptr M08_L15
M08_L106:
       mov       edx,[rsp+158]
       test      edx,edx
       jne       short M08_L108
       xor       r8d,r8d
       xor       r10d,r10d
       jmp       near ptr M08_L23
M08_L107:
       or        edx,r12d
       jne       short M08_L108
       xor       r9d,r9d
       xor       r12d,r12d
       mov       ecx,r9d
       mov       r9,r12
       mov       r12d,ecx
       jmp       near ptr M08_L24
M08_L108:
       call      qword ptr [7FF9E5DCF228]
       int       3
M08_L109:
       xor       r11d,r11d
       test      cl,4
       je        short M08_L110
       mov       dword ptr [r8+r11*4],0FFFFFFFF
       mov       dword ptr [r8+r11*4+4],0FFFFFFFF
       mov       dword ptr [r8+r11*4+8],0FFFFFFFF
       mov       dword ptr [r8+r11*4+0C],0FFFFFFFF
       add       r11,4
M08_L110:
       test      cl,2
       je        short M08_L111
       mov       dword ptr [r8+r11*4],0FFFFFFFF
       mov       dword ptr [r8+r11*4+4],0FFFFFFFF
       add       r11,2
M08_L111:
       test      cl,1
       je        near ptr M08_L28
       mov       dword ptr [r8+r11*4],0FFFFFFFF
       jmp       near ptr M08_L28
M08_L112:
       mov       r13,[rsp+150]
       jmp       near ptr M08_L30
M08_L113:
       mov       r13,[rsp+150]
       jmp       near ptr M08_L30
M08_L114:
       mov       ecx,7
       call      qword ptr [7FF9E63CDD40]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       r9,rax
       mov       rax,[rsp+0A0]
       mov       rdx,[rsp+98]
       jmp       near ptr M08_L39
M08_L115:
       jmp       short M08_L114
M08_L116:
       mov       rcx,rdx
       call      qword ptr [7FF9E619F438]; System.Buffers.SharedArrayPool`1[[System.Int32, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
       mov       r11,rax
       mov       rax,[rsp+0A0]
       jmp       near ptr M08_L40
M08_L117:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9E622EE68]
       mov       rbx,rax
       mov       ecx,29B
       mov       rdx,7FF9E5B34000
       call      qword ptr [7FF9E5BFF228]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9E5F67D50]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M08_L118:
       mov       r8,[rsp+98]
       mov       rcx,[r8+10]
       mov       r10d,[rsp+144]
       cmp       r10d,[rcx+8]
       jae       near ptr M08_L153
       mov       edx,r10d
       mov       r9,[rcx+rdx*8+10]
       test      r9,r9
       jne       short M08_L120
       mov       rcx,r8
       mov       edx,r10d
       call      qword ptr [7FF9E64A48E8]
       mov       r9,rax
M08_L119:
       mov       rcx,[r9+8]
       mov       [rsp+78],rcx
       call      qword ptr [7FF9E622F438]; System.Threading.Thread.GetCurrentProcessorNumber()
       mov       ecx,0AAAAAAAB
       mov       edx,eax
       imul      rcx,rdx
       shr       rcx,23
       imul      ecx,0C
       sub       eax,ecx
       xor       edx,edx
       jmp       near ptr M08_L127
M08_L120:
       jmp       short M08_L119
M08_L121:
       cmp       eax,[r8+8]
       jae       near ptr M08_L153
       mov       [rsp+128],eax
       mov       ecx,eax
       mov       r10,[r8+rcx*8+10]
       mov       [rsp+70],r10
       cmp       [r10],r10b
       xor       r9d,r9d
       mov       [rsp+120],r9d
       mov       rcx,r10
       call      qword ptr [7FF9E611E2B0]; System.Threading.Monitor.Enter(System.Object)
       mov       rax,[rsp+70]
       mov       rcx,[rax+8]
       mov       r8d,[rax+10]
       mov       [rsp+11C],r8d
       cmp       [rcx+8],r8d
       jbe       short M08_L123
       test      r8d,r8d
       jne       short M08_L124
       xor       edx,edx
       mov       [rax+14],edx
M08_L122:
       movsxd    rdx,r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,[rsp+80]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rsp+11C]
       inc       ecx
       mov       rax,[rsp+70]
       mov       [rax+10],ecx
       mov       dword ptr [rsp+120],1
M08_L123:
       mov       rcx,rax
       call      qword ptr [7FF9E5BF6820]; System.Threading.Monitor.Exit(System.Object)
       cmp       dword ptr [rsp+120],0
       je        short M08_L125
       jmp       short M08_L128
M08_L124:
       jmp       short M08_L122
M08_L125:
       mov       eax,[rsp+128]
       inc       eax
       mov       ecx,eax
       mov       r8,[rsp+78]
       cmp       [r8+8],ecx
       jne       short M08_L126
       xor       ecx,ecx
M08_L126:
       mov       edx,[rsp+124]
       inc       edx
       mov       eax,ecx
M08_L127:
       mov       r8,[rsp+78]
       mov       [rsp+124],edx
       cmp       [r8+8],edx
       jg        near ptr M08_L121
       jmp       short M08_L129
M08_L128:
       mov       edx,1
       jmp       short M08_L130
M08_L129:
       xor       edx,edx
M08_L130:
       mov       [rsp+13C],edx
       mov       rax,[rsp+0A0]
       mov       ecx,[rsp+140]
       mov       r10d,[rsp+144]
       jmp       near ptr M08_L41
M08_L131:
       mov       r8,[rsp+0A8]
       cmp       dword ptr [r8+8],0
       mov       [rsp+140],ecx
       je        near ptr M08_L42
       mov       rcx,r8
       call      qword ptr [7FF9E601D740]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+138],eax
       mov       rdx,[rsp+0A8]
       mov       r8d,[rdx+8]
       mov       [rsp+134],r8d
       mov       rcx,[rsp+98]
       call      qword ptr [7FF9E601D740]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,[rsp+90]
       mov       r8d,[rsp+138]
       mov       r9d,[rsp+134]
       mov       edx,3
       call      qword ptr [7FF9E63CEAA8]
       mov       eax,[rsp+140]
       test      [rsp+13C],eax
       jne       short M08_L132
       mov       rcx,[rsp+0A8]
       call      qword ptr [7FF9E601D740]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+130],eax
       mov       rcx,[rsp+0A8]
       mov       edx,[rcx+8]
       mov       [rsp+12C],edx
       mov       rcx,[rsp+98]
       call      qword ptr [7FF9E601D740]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       cmp       dword ptr [rsp+140],0
       jne       short M08_L133
       mov       ecx,0FFFFFFFF
       mov       edx,1
       jmp       short M08_L134
M08_L132:
       mov       rax,[rsp+0A0]
       jmp       near ptr M08_L42
M08_L133:
       mov       ecx,[rsp+144]
       xor       edx,edx
M08_L134:
       mov       [rsp+20],ecx
       mov       [rsp+28],edx
       mov       rcx,[rsp+90]
       mov       edx,[rsp+130]
       mov       r8d,[rsp+12C]
       call      qword ptr [7FF9E622EEE0]
       mov       rax,[rsp+0A0]
       jmp       near ptr M08_L42
M08_L135:
       mov       ecx,2
       call      qword ptr [7FF9E5BFFD50]
       int       3
M08_L136:
       mov       rcx,r12
       call      qword ptr [7FF9E619F438]; System.Buffers.SharedArrayPool`1[[System.Int32, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
       jmp       near ptr M08_L45
M08_L137:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9E622EE68]
       mov       r12,rax
       mov       ecx,29B
       mov       rdx,7FF9E5B34000
       call      qword ptr [7FF9E5BFF228]
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,rbx
       call      qword ptr [7FF9E5F67D50]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M08_L138:
       mov       rcx,[r12+10]
       cmp       edi,[rcx+8]
       jae       near ptr M08_L153
       mov       edx,edi
       mov       rax,[rcx+rdx*8+10]
       test      rax,rax
       jne       short M08_L139
       mov       rcx,r12
       mov       edx,edi
       call      qword ptr [7FF9E64A48E8]
M08_L139:
       mov       r14,[rax+8]
       call      qword ptr [7FF9E622F438]; System.Threading.Thread.GetCurrentProcessorNumber()
       mov       ecx,0AAAAAAAB
       mov       edx,eax
       imul      rcx,rdx
       shr       rcx,23
       imul      ecx,0C
       mov       r15d,eax
       sub       r15d,ecx
       xor       eax,eax
       jmp       near ptr M08_L146
M08_L140:
       cmp       r15d,[r14+8]
       jae       near ptr M08_L153
       mov       ecx,r15d
       mov       rdx,[r14+rcx*8+10]
       mov       [rsp+68],rdx
       cmp       [rdx],dl
       xor       r8d,r8d
       mov       [rsp+110],r8d
       mov       rcx,rdx
       call      qword ptr [7FF9E611E2B0]; System.Threading.Monitor.Enter(System.Object)
       mov       rax,[rsp+68]
       mov       rcx,[rax+8]
       mov       r8d,[rax+10]
       mov       [rsp+10C],r8d
       cmp       [rcx+8],r8d
       jbe       short M08_L142
       test      r8d,r8d
       jne       short M08_L143
       xor       edx,edx
       mov       [rax+14],edx
M08_L141:
       movsxd    rdx,r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rsp+10C]
       inc       ecx
       mov       rax,[rsp+68]
       mov       [rax+10],ecx
       mov       dword ptr [rsp+110],1
M08_L142:
       mov       rcx,rax
       call      qword ptr [7FF9E5BF6820]; System.Threading.Monitor.Exit(System.Object)
       cmp       dword ptr [rsp+110],0
       je        short M08_L144
       jmp       short M08_L147
M08_L143:
       jmp       short M08_L141
M08_L144:
       inc       r15d
       cmp       [r14+8],r15d
       jne       short M08_L145
       xor       r15d,r15d
M08_L145:
       mov       eax,[rsp+114]
       inc       eax
M08_L146:
       mov       [rsp+114],eax
       cmp       [r14+8],eax
       jg        near ptr M08_L140
       jmp       short M08_L148
M08_L147:
       mov       r14d,1
       jmp       short M08_L149
M08_L148:
       xor       r14d,r14d
M08_L149:
       jmp       near ptr M08_L46
M08_L150:
       cmp       dword ptr [rbx+8],0
       je        near ptr M08_L47
       mov       rcx,rbx
       call      qword ptr [7FF9E601D740]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r13d,eax
       mov       eax,[rbx+8]
       mov       [rsp+118],eax
       mov       rcx,r12
       call      qword ptr [7FF9E601D740]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,r15
       mov       r8d,r13d
       mov       r9d,[rsp+118]
       mov       edx,3
       call      qword ptr [7FF9E63CEAA8]
       test      r14d,ebp
       jne       near ptr M08_L47
       mov       rcx,rbx
       call      qword ptr [7FF9E601D740]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r14d,eax
       mov       ebx,[rbx+8]
       mov       rcx,r12
       call      qword ptr [7FF9E601D740]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       test      ebp,ebp
       jne       short M08_L151
       mov       ecx,0FFFFFFFF
       mov       edx,1
       jmp       short M08_L152
M08_L151:
       mov       ecx,edi
       xor       edx,edx
M08_L152:
       mov       [rsp+20],ecx
       mov       [rsp+28],edx
       mov       rcx,r15
       mov       edx,r14d
       mov       r8d,ebx
       call      qword ptr [7FF9E622EEE0]
       jmp       near ptr M08_L47
M08_L153:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 6079
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
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       test      rbx,rbx
       je        near ptr M10_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M10_L01
       test      rsi,rsi
       je        short M10_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M10_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M10_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFA45879D30
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF9E5BF5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF9E5BF5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
M10_L00:
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
M10_L01:
       test      rsi,rsi
       je        short M10_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M10_L03
M10_L02:
       mov       rax,191200E0008
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M10_L03:
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
M10_L04:
       call      qword ptr [7FF9E63CFCD8]
       int       3
; Total bytes of code 244
```
```assembly
; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].get_Comparer()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       rcx,[rbx]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rdx,offset MT_System.String
       cmp       [rcx],rdx
       je        short M11_L01
       mov       rax,[rbx+18]
       test      rax,rax
       je        short M11_L04
M11_L00:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M11_L01:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rsi,[rdx+90]
       test      rsi,rsi
       je        short M11_L02
       jmp       short M11_L03
M11_L02:
       mov       rdx,7FF9E649ACA0
       call      qword ptr [7FF9E5BFF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rsi,rax
M11_L03:
       mov       rdx,[rbx+18]
       mov       rcx,offset MT_System.Collections.Generic.IEqualityComparer<System.String>
       call      qword ptr [7FF9E5BF58D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rcx,rax
       call      qword ptr [7FF9E64A4918]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9E5BF58D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M11_L04:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+88]
       test      rdx,rdx
       je        short M11_L05
       jmp       short M11_L06
M11_L05:
       mov       rdx,7FF9E649AC90
       call      qword ptr [7FF9E5BFF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M11_L06:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rax]
       jmp       near ptr M11_L00
; Total bytes of code 206
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M12_L00
       ret
M12_L00:
       jmp       qword ptr [7FF9E5BF5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.ToFrozenSet()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,78
       lea       rbp,[rsp+0B0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rbp-68],xmm4
       xor       eax,eax
       mov       [rbp-58],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       test      rsi,rsi
       je        near ptr M00_L43
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L45
       mov       rcx,[rsi+8]
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],r11
       jne       near ptr M00_L44
       mov       edi,[rcx+10]
M00_L00:
       test      edi,edi
       je        near ptr M00_L56
       mov       rdx,1CA94000AC8
       mov       rdi,[rdx]
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Frozen.FrozenSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r14,rax
       test      r14,r14
       jne       near ptr M00_L46
M00_L01:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Generic.HashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r14,rax
       mov       r15,r14
       test      r15,r15
       jne       near ptr M00_L47
M00_L02:
       mov       rcx,offset MT_System.Collections.Generic.HashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       lea       rcx,[r15+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       test      r14,r14
       jne       near ptr M00_L48
M00_L03:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L50
       mov       rcx,[rsi+8]
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],r11
       jne       near ptr M00_L49
       mov       ecx,[rcx+10]
M00_L04:
       test      ecx,ecx
       jle       short M00_L05
       call      qword ptr [7FF9E5BF5A88]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       r14d,eax
       movsxd    rdx,r14d
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r13,rax
       movsxd    rdx,r14d
       mov       rcx,offset MT_System.Collections.Generic.HashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Entry[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r12,rax
       mov       dword ptr [r15+2C],0FFFFFFFF
       lea       rcx,[r15+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,r14d
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [r15+20],rax
M00_L05:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L51
       mov       rcx,[rsi+8]
       mov       r11,7FF9E5B41208
       call      qword ptr [r11]
       mov       rcx,rax
M00_L06:
       mov       [rbp-70],rcx
M00_L07:
       mov       rdx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rcx,[rbp-70]
       cmp       [rcx],rdx
       jne       near ptr M00_L35
       mov       rdx,[rcx]
       add       rcx,8
       call      qword ptr [7FF9E5E8C150]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L08:
       test      eax,eax
       je        near ptr M00_L38
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-70]
       cmp       [rax],rcx
       jne       near ptr M00_L24
       mov       rsi,[rax+10]
M00_L09:
       cmp       qword ptr [r15+8],0
       je        near ptr M00_L25
M00_L10:
       mov       r14,[r15+10]
       mov       r13,[r15+18]
       xor       r12d,r12d
       test      rsi,rsi
       je        near ptr M00_L20
       mov       rcx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r13],rcx
       jne       near ptr M00_L31
       mov       rdx,[rsi+28]
       test      rdx,rdx
       je        near ptr M00_L26
       mov       rcx,1CA7E000068
       mov       rcx,[rcx]
       mov       r8,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],r8
       jne       near ptr M00_L30
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       dword ptr [rbp-48],135F7ECC
       mov       dword ptr [rbp-50],0E51208E5
       cmp       edx,8
       jb        near ptr M00_L18
       mov       r8d,edx
       shr       r8d,3
M00_L11:
       mov       r10d,[rbp-48]
       add       r10d,[rcx]
       mov       [rbp-48],r10d
       mov       r10d,[rcx+4]
       mov       r9d,[rbp-48]
       mov       r11d,[rbp-50]
       xor       r11d,r9d
       rol       r9d,14
       add       r9d,r11d
       rol       r11d,9
       xor       r11d,r9d
       rol       r9d,1B
       add       r9d,r11d
       rol       r11d,13
       mov       [rbp-48],r9d
       mov       [rbp-50],r11d
       add       r10d,[rbp-48]
       mov       [rbp-48],r10d
       mov       r10d,[rbp-48]
       mov       r9d,[rbp-50]
       xor       r9d,r10d
       rol       r10d,14
       add       r10d,r9d
       rol       r9d,9
       xor       r9d,r10d
       rol       r10d,1B
       add       r10d,r9d
       rol       r9d,13
       mov       [rbp-48],r10d
       mov       [rbp-50],r9d
       add       rcx,8
       dec       r8d
       jne       short M00_L11
       test      dl,4
       jne       near ptr M00_L19
M00_L12:
       mov       r8d,edx
       and       r8,7
       mov       ecx,[rcx+r8-4]
       shr       ecx,8
       or        ecx,80000000
       not       edx
       shl       edx,3
       shrx      ecx,ecx,edx
M00_L13:
       add       ecx,[rbp-48]
       mov       [rbp-48],ecx
       lea       rcx,[rbp-48]
       lea       rdx,[rbp-50]
       call      qword ptr [7FF9E64C6490]; System.Marvin.Block(UInt32 ByRef, UInt32 ByRef)
       lea       rcx,[rbp-48]
       lea       rdx,[rbp-50]
       call      qword ptr [7FF9E64C6490]; System.Marvin.Block(UInt32 ByRef, UInt32 ByRef)
       mov       eax,[rbp-50]
       xor       eax,[rbp-48]
M00_L14:
       mov       [rbp-3C],eax
       mov       rdx,[r15+8]
       mov       ecx,eax
       imul      rcx,[r15+20]
       shr       rcx,20
       inc       rcx
       mov       r8d,[rdx+8]
       mov       r11d,r8d
       imul      rcx,r11
       shr       rcx,20
       cmp       ecx,r8d
       jae       near ptr M00_L37
       mov       ecx,ecx
       lea       r10,[rdx+rcx*4+10]
       mov       [rbp-80],r10
       mov       r9d,[r10]
       dec       r9d
       jns       near ptr M00_L21
M00_L15:
       cmp       dword ptr [r15+30],0
       jg        near ptr M00_L23
       mov       edx,[r15+28]
       mov       [rbp-40],edx
       cmp       [r14+8],edx
       je        near ptr M00_L33
M00_L16:
       mov       edx,[rbp-40]
       mov       r14d,edx
       lea       ecx,[r14+1]
       mov       [r15+28],ecx
       mov       rcx,[r15+10]
       mov       r8,rcx
M00_L17:
       cmp       r14d,[r8+8]
       jae       near ptr M00_L37
       mov       ecx,r14d
       shl       rcx,4
       mov       [rbp-78],r8
       lea       rcx,[r8+rcx+10]
       mov       [rcx+8],eax
       mov       r10,[rbp-80]
       mov       edx,[r10]
       dec       edx
       mov       [rcx+0C],edx
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       inc       r14d
       mov       rdx,[rbp-80]
       mov       [rdx],r14d
       inc       dword ptr [r15+34]
       cmp       r12d,64
       jbe       near ptr M00_L07
       jmp       near ptr M00_L34
M00_L18:
       cmp       edx,4
       jb        near ptr M00_L27
M00_L19:
       mov       r8d,[rbp-48]
       add       r8d,[rcx]
       mov       [rbp-48],r8d
       mov       r8d,[rbp-48]
       mov       r10d,[rbp-50]
       xor       r10d,r8d
       rol       r8d,14
       add       r8d,r10d
       rol       r10d,9
       xor       r10d,r8d
       rol       r8d,1B
       add       r8d,r10d
       rol       r10d,13
       mov       [rbp-48],r8d
       mov       [rbp-50],r10d
       jmp       near ptr M00_L12
M00_L20:
       xor       edx,edx
       xor       r10d,r10d
       mov       eax,r10d
       jmp       near ptr M00_L14
M00_L21:
       cmp       r9d,[r14+8]
       jae       near ptr M00_L37
       mov       edx,r9d
       shl       rdx,4
       lea       r9,[r14+rdx+10]
       mov       [rbp-88],r9
       cmp       [r9+8],eax
       je        near ptr M00_L32
M00_L22:
       mov       r9d,[r9+0C]
       inc       r12d
       cmp       [r14+8],r12d
       jb        near ptr M00_L36
       test      r9d,r9d
       mov       eax,[rbp-3C]
       jge       short M00_L21
       jmp       near ptr M00_L15
M00_L23:
       mov       ecx,[r15+2C]
       mov       r8d,ecx
       dec       dword ptr [r15+30]
       cmp       ecx,[r14+8]
       jae       near ptr M00_L37
       shl       rcx,4
       mov       ecx,[r14+rcx+1C]
       neg       ecx
       add       ecx,0FFFFFFFD
       mov       [r15+2C],ecx
       mov       ecx,r8d
       mov       r8,r14
       mov       r14d,ecx
       jmp       near ptr M00_L17
M00_L24:
       mov       rcx,rax
       mov       r11,7FF9E5B411F8
       call      qword ptr [r11]
       mov       rsi,rax
       mov       rax,[rbp-70]
       jmp       near ptr M00_L09
M00_L25:
       mov       rcx,r15
       xor       edx,edx
       call      qword ptr [7FF9E5DC7750]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       mov       rax,[rbp-70]
       jmp       near ptr M00_L10
M00_L26:
       xor       ecx,ecx
       mov       eax,ecx
       jmp       near ptr M00_L14
M00_L27:
       mov       r8d,80
       test      dl,1
       je        short M00_L28
       mov       r8d,edx
       and       r8,2
       movzx     r8d,byte ptr [rcx+r8]
       or        r8d,8000
M00_L28:
       test      dl,2
       je        short M00_L29
       shl       r8d,10
       movzx     ecx,word ptr [rcx]
       or        r8d,ecx
       mov       ecx,r8d
       jmp       near ptr M00_L13
M00_L29:
       mov       ecx,r8d
       jmp       near ptr M00_L13
M00_L30:
       mov       r8,[rcx]
       mov       r8,[r8+48]
       call      qword ptr [r8+18]
       jmp       near ptr M00_L14
M00_L31:
       mov       rcx,r13
       mov       rdx,rsi
       mov       r11,7FF9E5B41210
       call      qword ptr [r11]
       jmp       near ptr M00_L14
M00_L32:
       mov       rdx,[r9]
       mov       rcx,r13
       mov       r8,rsi
       mov       r11,7FF9E5B41218
       call      qword ptr [r11]
       test      eax,eax
       mov       r9,[rbp-88]
       jne       near ptr M00_L07
       jmp       near ptr M00_L22
M00_L33:
       mov       rcx,r15
       call      qword ptr [7FF9E64C4C48]
       mov       rcx,[r15+8]
       mov       r14d,[rbp-3C]
       mov       edx,r14d
       imul      rdx,[r15+20]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       imul      rdx,rax
       shr       rdx,20
       cmp       edx,[rcx+8]
       jae       short M00_L37
       mov       edx,edx
       lea       r10,[rcx+rdx*4+10]
       mov       rax,r10
       mov       [rbp-80],rax
       mov       eax,r14d
       jmp       near ptr M00_L16
M00_L34:
       mov       r14,[rbp-78]
       mov       rdx,r13
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M00_L07
       mov       edx,[r14+8]
       mov       rcx,r15
       mov       r8d,1
       call      qword ptr [7FF9E5F6D980]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,r15
       mov       rdx,rsi
       call      qword ptr [7FF9E5DC7810]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       jmp       near ptr M00_L07
M00_L35:
       mov       r11,7FF9E5B411F0
       call      qword ptr [r11]
       jmp       near ptr M00_L08
M00_L36:
       call      qword ptr [7FF9E5BFF498]
       int       3
M00_L37:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L38:
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-70]
       cmp       [rax],rcx
       jne       near ptr M00_L52
M00_L39:
       mov       ecx,[r15+28]
       test      ecx,ecx
       jle       short M00_L40
       mov       rax,[r15+10]
       mov       eax,[rax+8]
       xor       edx,edx
       div       ecx
       cmp       eax,3
       jg        near ptr M00_L53
M00_L40:
       mov       ecx,[r15+28]
       sub       ecx,[r15+30]
       je        near ptr M00_L54
       xor       esi,esi
M00_L41:
       test      rsi,rsi
       jne       short M00_L42
       mov       rdx,r15
       mov       rcx,7FF9E6488810
       call      qword ptr [7FF9E642DE78]; System.Collections.Frozen.FrozenSet.CreateFromSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
       mov       rsi,rax
M00_L42:
       mov       [rbp-58],rsi
       mov       rcx,[rbx+60]
       lea       r8,[rbp-58]
       mov       rdx,7FF9E64A3598
       cmp       [rcx],ecx
       call      qword ptr [7FF9E642F180]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,78
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L43:
       call      qword ptr [7FF9E619F000]
       mov       ecx,65
       mov       rdx,7FF9E5FF8D68
       call      qword ptr [7FF9E5BFF228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF9E5EC5AC0
       call      qword ptr [7FF9E5BFF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9E5BFD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9E5FF8D68
       call      qword ptr [7FF9E5BFF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9E5BFD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9E62D6E98]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9E62D6EB0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L44:
       mov       r11,7FF9E5B411D0
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L00
M00_L45:
       mov       rcx,rsi
       mov       r11,7FF9E5B411C8
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L00
M00_L46:
       mov       rcx,[r14+8]
       mov       rdx,rdi
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       test      eax,eax
       je        near ptr M00_L01
       xor       r15d,r15d
       mov       rsi,r14
       jmp       near ptr M00_L41
M00_L47:
       mov       ecx,[r15+28]
       sub       ecx,[r15+30]
       je        near ptr M00_L40
       mov       rcx,r15
       call      qword ptr [7FF9E642E808]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].get_Comparer()
       mov       rcx,rax
       mov       rdx,rdi
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       test      eax,eax
       jne       near ptr M00_L40
       jmp       near ptr M00_L02
M00_L48:
       mov       r8,r14
       mov       rdx,r15
       mov       rcx,offset MT_System.Collections.Generic.HashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FF9E64C63A0]
       test      eax,eax
       je        near ptr M00_L03
       mov       rcx,r15
       mov       rdx,r14
       call      qword ptr [7FF9E64C4DB0]
       jmp       near ptr M00_L40
M00_L49:
       mov       r11,7FF9E5B411E0
       call      qword ptr [r11]
       mov       ecx,eax
       jmp       near ptr M00_L04
M00_L50:
       mov       rcx,rsi
       mov       r11,7FF9E5B411D8
       call      qword ptr [r11]
       mov       ecx,eax
       jmp       near ptr M00_L04
M00_L51:
       mov       rcx,rsi
       mov       r11,7FF9E5B411E8
       call      qword ptr [r11]
       mov       rcx,rax
       jmp       near ptr M00_L06
M00_L52:
       mov       rcx,rax
       mov       r11,7FF9E5B41200
       call      qword ptr [r11]
       jmp       near ptr M00_L39
M00_L53:
       mov       edx,ecx
       sub       edx,[r15+30]
       mov       rcx,r15
       call      qword ptr [7FF9E64C4DC8]
       jmp       near ptr M00_L40
M00_L54:
       mov       rcx,offset MT_System.Collections.Frozen.FrozenSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1CA94000B38
       mov       rcx,[rcx]
       cmp       rdi,[rcx+8]
       je        short M00_L55
       mov       rcx,offset MT_System.Collections.Frozen.EmptyFrozenSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L41
M00_L55:
       mov       rcx,offset MT_System.Collections.Frozen.FrozenSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,1CA94000B38
       mov       rsi,[rdx]
       jmp       near ptr M00_L41
M00_L56:
       xor       r8d,r8d
       mov       [rbp-68],r8
       mov       [rbp-60],r8d
       lea       r8,[rbp-68]
       mov       rcx,7FF9E657D560
       xor       edx,edx
       call      qword ptr [7FF9E64C6430]
       mov       rsi,rax
       jmp       near ptr M00_L42
       sub       rsp,28
       cmp       qword ptr [rbp-70],0
       je        short M00_L57
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-70]
       cmp       [rax],rcx
       je        short M00_L57
       mov       rcx,rax
       mov       r11,7FF9E5B41200
       call      qword ptr [r11]
M00_L57:
       nop
       add       rsp,28
       ret
; Total bytes of code 2372
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
       mov       rcx,7FF9ED480B08
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
       call      qword ptr [7FF9E62DF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9E5F65E60]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M02_L03:
       mov       esi,ebx
       or        esi,1
       jmp       short M02_L06
M02_L04:
       mov       ecx,esi
       call      qword ptr [7FF9E62DF240]
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
; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx]
       mov       rdx,rcx
       mov       eax,[rbx+10]
       cmp       eax,[rcx+14]
       jne       short M03_L01
       mov       ecx,[rbx+14]
       cmp       ecx,[rdx+10]
       jae       short M03_L00
       mov       rdx,[rdx+8]
       cmp       ecx,[rdx+8]
       jae       short M03_L02
       mov       ecx,ecx
       mov       rdx,[rdx+rcx*8+10]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       dword ptr [rbx+14]
       mov       eax,1
       add       rsp,20
       pop       rbx
       ret
M03_L00:
       xor       eax,eax
       mov       [rbx+8],rax
       mov       dword ptr [rbx+14],0FFFFFFFF
       add       rsp,20
       pop       rbx
       ret
M03_L01:
       call      qword ptr [7FF9E5BFFC60]
       int       3
M03_L02:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 101
```
```assembly
; System.Marvin.Block(UInt32 ByRef, UInt32 ByRef)
       mov       eax,[rcx]
       mov       r8d,eax
       xor       r8d,[rdx]
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       mov       [rcx],eax
       mov       [rdx],r8d
       ret
; Total bytes of code 37
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
       call      qword ptr [7FF9E5BF5A88]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       esi,eax
       movsxd    rdx,esi
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rdi,rax
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+0B0]
       test      rax,rax
       je        short M05_L01
       mov       rcx,rax
M05_L00:
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
M05_L01:
       mov       rdx,7FF9E65544D8
       call      qword ptr [7FF9E5BFF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M05_L00
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
       call      qword ptr [7FF9EE0E7EC8]
       mov       rcx,rax
       movsxd    rdx,esi
       call      qword ptr [7FF9EE0E4088]; CORINFO_HELP_NEWARR_1_DIRECT
       mov       rbp,rax
       mov       r14d,[rbx+28]
       mov       rcx,[rbx+10]
       mov       rdx,rbp
       mov       r8d,r14d
       call      qword ptr [7FF9EE0F52F0]; Precode of System.Array.Copy(System.Array, System.Array, Int32)
       movzx     ecx,dil
       test      cl,1
       jne       near ptr M06_L06
M06_L00:
       movsxd    rcx,esi
       call      qword ptr [7FF9EE0F1B50]
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      qword ptr [7FF9EE0E3FE8]; CORINFO_HELP_ASSIGN_REF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,esi
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rbx+20],rax
       xor       ecx,ecx
       test      r14d,r14d
       jle       short M06_L03
       cmp       [rbp+8],r14d
       jl        near ptr M06_L04
M06_L01:
       mov       edx,ecx
       shl       rdx,4
       lea       rdx,[rbp+rdx+10]
       cmp       dword ptr [rdx+0C],0FFFFFFFF
       jl        short M06_L02
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
       jae       near ptr M06_L11
       mov       r10d,r10d
       lea       rax,[r8+r10*4+10]
       mov       r8d,[rax]
       dec       r8d
       mov       [rdx+0C],r8d
       lea       edx,[rcx+1]
       mov       [rax],edx
M06_L02:
       inc       ecx
       cmp       ecx,r14d
       jl        short M06_L01
M06_L03:
       lea       rcx,[rbx+10]
       mov       rdx,rbp
       call      qword ptr [7FF9EE0E3FE8]; CORINFO_HELP_ASSIGN_REF
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
M06_L04:
       cmp       ecx,[rbp+8]
       jae       near ptr M06_L11
       mov       eax,ecx
       shl       rax,4
       lea       rdx,[rbp+rax+10]
       cmp       dword ptr [rdx+0C],0FFFFFFFF
       jl        short M06_L05
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
       jae       near ptr M06_L11
       mov       eax,r10d
       lea       rax,[r8+rax*4+10]
       mov       r8d,[rax]
       dec       r8d
       mov       [rdx+0C],r8d
       lea       edx,[rcx+1]
       mov       [rax],edx
M06_L05:
       inc       ecx
       cmp       ecx,r14d
       jl        short M06_L04
       jmp       near ptr M06_L03
M06_L06:
       mov       rcx,[rbx]
       call      qword ptr [7FF9EE0E74F8]
       mov       rdi,rax
       mov       rcx,[rbx+18]
       call      qword ptr [7FF9EE0F3730]
       mov       rcx,rax
       lea       r11,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       [rcx],ecx
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF9EE0E4090]; Precode of System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdi,rax
       lea       rcx,[rbx+18]
       mov       rdx,rdi
       call      qword ptr [7FF9EE0E3FE8]; CORINFO_HELP_ASSIGN_REF
       xor       r15d,r15d
       cmp       r15d,r14d
       jge       near ptr M06_L00
M06_L07:
       cmp       r15d,[rbp+8]
       jae       short M06_L11
       mov       rcx,r15
       shl       rcx,4
       lea       r13,[rbp+rcx+10]
       cmp       dword ptr [r13+0C],0FFFFFFFF
       jl        short M06_L10
       cmp       qword ptr [r13],0
       jne       short M06_L08
       xor       r12d,r12d
       jmp       short M06_L09
M06_L08:
       mov       rcx,[rbx]
       call      qword ptr [7FF9EE0E9150]
       mov       rdx,[r13]
       mov       rcx,rdi
       mov       r11,rax
       call      qword ptr [rax]
       mov       r12d,eax
M06_L09:
       mov       [r13+8],r12d
M06_L10:
       inc       r15d
       cmp       r15d,r14d
       jl        short M06_L07
       jmp       near ptr M06_L00
M06_L11:
       call      qword ptr [7FF9EE0E3FD8]
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
       je        near ptr M07_L06
       mov       rdi,[rbx+10]
       xor       ebp,ebp
       mov       r14,[rbx+18]
       test      rsi,rsi
       je        near ptr M07_L11
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+78]
       test      r11,r11
       je        near ptr M07_L07
M07_L00:
       mov       rcx,offset MT_System.Collections.Generic.ObjectEqualityComparer<System.RuntimeType>
       cmp       [r14],rcx
       jne       near ptr M07_L13
       mov       [rsp+38],rsi
       xor       ecx,ecx
       mov       [rsp+30],rcx
       lea       rcx,[rsp+38]
       cmp       qword ptr [rsp+30],0
       jne       short M07_L01
       mov       rcx,[rsp+38]
       mov       [rsp+30],rcx
       lea       rcx,[rsp+30]
       cmp       qword ptr [rsp+30],0
       je        near ptr M07_L12
M07_L01:
       mov       r15,[rcx]
       mov       rcx,offset MT_BenchmarkDotNet.Characteristics.Characteristic<System.Boolean>
       cmp       [r15],rcx
       je        near ptr M07_L08
       mov       rcx,r15
       mov       rax,[r15]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
       mov       r15d,eax
M07_L02:
       xor       ecx,ecx
       mov       [rsp+30],rcx
M07_L03:
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
       jae       near ptr M07_L18
       mov       edx,edx
       lea       rcx,[rcx+rdx*4+10]
       mov       r13d,[rcx]
       dec       r13d
       js        short M07_L06
M07_L04:
       mov       r12d,[rdi+8]
       cmp       r13d,r12d
       jae       near ptr M07_L18
       mov       ecx,r13d
       shl       rcx,4
       lea       rax,[rdi+rcx+10]
       mov       [rsp+28],rax
       cmp       [rax+8],r15d
       je        near ptr M07_L14
M07_L05:
       mov       rax,[rsp+28]
       mov       r13d,[rax+0C]
       inc       ebp
       cmp       r12d,ebp
       jb        near ptr M07_L17
       test      r13d,r13d
       jge       short M07_L04
M07_L06:
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
M07_L07:
       mov       rdx,7FF9E6415CA8
       call      qword ptr [7FF9E5BFF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M07_L00
M07_L08:
       mov       rcx,r15
       call      00007FFA45809590
       test      eax,eax
       je        short M07_L10
       mov       r15d,eax
M07_L09:
       jmp       near ptr M07_L02
M07_L10:
       mov       rcx,r15
       call      qword ptr [7FF9E5DC77F8]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       mov       r15d,eax
       jmp       short M07_L09
M07_L11:
       xor       r15d,r15d
       jmp       near ptr M07_L03
M07_L12:
       xor       r15d,r15d
       jmp       near ptr M07_L02
M07_L13:
       mov       rcx,r14
       mov       rdx,rsi
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       near ptr M07_L03
M07_L14:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+80]
       test      r11,r11
       je        short M07_L15
       jmp       short M07_L16
M07_L15:
       mov       rdx,7FF9E6415CC0
       call      qword ptr [7FF9E5BFF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M07_L16:
       mov       rax,[rsp+28]
       mov       rdx,[rax]
       mov       rcx,r14
       mov       r8,rsi
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M07_L05
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
M07_L17:
       call      qword ptr [7FF9E5BFF498]
       int       3
M07_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 543
```
```assembly
; System.Collections.Frozen.FrozenSet.CreateFromSet[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.HashSet`1<System.__Canon>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,188
       xor       eax,eax
       mov       [rsp+0D8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+0E0],xmm4
       mov       [rsp+0F0],rax
       mov       [rsp+180],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rcx,[rbx]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rdx,offset MT_System.String
       cmp       [rcx],rdx
       je        near ptr M08_L57
       mov       rdi,[rbx+18]
       test      rdi,rdi
       je        near ptr M08_L60
M08_L00:
       mov       rcx,[rsi+18]
       mov       rdx,offset MT_System.String
       cmp       [rcx],rdx
       je        near ptr M08_L63
M08_L01:
       mov       ecx,[rbx+28]
       sub       ecx,[rbx+30]
       cmp       ecx,4
       jle       near ptr M08_L92
       mov       rcx,[rsi+18]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        near ptr M08_L18
M08_L02:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,[rbx]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rdx,offset MT_System.String
       cmp       [rcx],rdx
       je        near ptr M08_L95
       mov       rdx,[rbx+18]
       test      rdx,rdx
       je        near ptr M08_L98
M08_L03:
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+10],rcx
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx+8]
       mov       rax,[rdx+20]
       test      rax,rax
       je        near ptr M08_L08
M08_L04:
       lea       rcx,[rsi+10]
       mov       rdx,rsi
       call      rax
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx+10]
       mov       rdi,[rdx+28]
       test      rdi,rdi
       je        near ptr M08_L09
M08_L05:
       mov       rcx,rdi
       mov       ebp,[rbx+28]
       sub       ebp,[rbx+30]
       mov       [rsp+0D4],ebp
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       xor       r15d,r15d
       mov       r13d,ebp
       test      r13d,r13d
       jl        near ptr M08_L101
       mov       r12,[rbx+10]
       xor       eax,eax
       cmp       dword ptr [rbx+28],0
       jg        near ptr M08_L56
M08_L06:
       mov       rcx,rdi
       mov       edx,ebp
       call      CORINFO_HELP_NEWARR_1_PTR
       lea       rcx,[rsi+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,1CA7E001D88
       mov       r13,[rcx]
       mov       [rsp+48],r13
       mov       rcx,r13
       mov       edx,ebp
       call      qword ptr [7FF9E6206F48]; System.Buffers.SharedArrayPool`1[[System.Int32, System.Private.CoreLib]].Rent(Int32)
       mov       rbx,rax
       mov       [rsp+0C0],rbx
       mov       edi,ebp
       test      rbx,rbx
       je        near ptr M08_L102
       cmp       [rbx+8],edi
       jb        near ptr M08_L112
       lea       r15,[rbx+10]
M08_L07:
       xor       r12d,r12d
       cmp       ebp,r12d
       jg        near ptr M08_L17
       jmp       near ptr M08_L103
M08_L08:
       mov       rdx,7FF9E6556890
       call      qword ptr [7FF9E5BFF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M08_L04
       nop       dword ptr [rax]
M08_L09:
       mov       rdx,7FF9E65567B8
       call      qword ptr [7FF9E5BFF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M08_L05
M08_L10:
       mov       rdx,7FF9E65567C0
       call      qword ptr [7FF9E5BFF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M08_L11:
       mov       rcx,[rsi+8]
       mov       rdx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rdx
       jne       near ptr M08_L109
       mov       r8,[rsp+0B8]
       mov       rdx,[r8+28]
       test      rdx,rdx
       je        near ptr M08_L104
       mov       rcx,1CA7E000068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M08_L108
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,135F7ECC
       mov       r8d,0E51208E5
       cmp       edx,8
       jb        near ptr M08_L19
       mov       r9d,edx
       shr       r9d,3
M08_L12:
       add       eax,[rcx]
       mov       r11d,[rcx+4]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       add       r11d,eax
       mov       eax,r8d
       xor       eax,r11d
       rol       r11d,14
       add       r11d,eax
       rol       eax,9
       xor       eax,r11d
       rol       r11d,1B
       add       r11d,eax
       rol       eax,13
       mov       r8d,r11d
       add       rcx,8
       dec       r9d
       mov       r10d,eax
       mov       eax,r8d
       mov       r8d,r10d
       jne       short M08_L12
       test      dl,4
       jne       near ptr M08_L20
M08_L13:
       mov       r9d,edx
       and       r9,7
       mov       ecx,[rcx+r9-4]
       shr       ecx,8
       or        ecx,80000000
       not       edx
       shl       edx,3
       shrx      ecx,ecx,edx
M08_L14:
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
       mov       eax,ecx
       rol       eax,14
       add       eax,edx
       rol       edx,9
       xor       edx,eax
       rol       eax,1B
       add       eax,edx
       mov       r8d,edx
       rol       r8d,13
       xor       eax,r8d
M08_L15:
       mov       r10,[rsp+0B0]
M08_L16:
       mov       [r10],eax
       inc       r12d
       cmp       ebp,r12d
       jle       near ptr M08_L22
       mov       ebp,[rsp+0D4]
M08_L17:
       cmp       r12d,edi
       jae       near ptr M08_L154
       lea       rax,[r15+r12*4]
       mov       r8,[r14+r12*8+10]
       mov       [rsp+0B8],r8
       mov       [rsp+0B0],rax
       test      r8,r8
       je        short M08_L21
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx+10]
       mov       r11,[rdx+30]
       test      r11,r11
       je        near ptr M08_L10
       jmp       near ptr M08_L11
M08_L18:
       mov       rcx,rsi
       mov       rdx,7FF9E6554E70
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M08_L02
M08_L19:
       cmp       edx,4
       jb        near ptr M08_L105
M08_L20:
       add       eax,[rcx]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       jmp       near ptr M08_L13
M08_L21:
       mov       r10,rax
       xor       eax,eax
       jmp       near ptr M08_L16
M08_L22:
       mov       rcx,r15
       mov       r12d,edi
       mov       [rsp+0E8],rcx
       mov       [rsp+0F0],r12d
       lea       rcx,[rsp+0E8]
       xor       edx,edx
       call      qword ptr [7FF9E642EF10]; System.Collections.Frozen.FrozenHashTable.CalcNumBuckets(System.ReadOnlySpan`1<Int32>, Boolean)
       mov       r8d,eax
       mov       [rsp+158],r8d
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,r8d
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rsp+150],rax
       mov       rcx,r13
       lea       edx,[r8+r12]
       call      qword ptr [7FF9E6206F48]; System.Buffers.SharedArrayPool`1[[System.Int32, System.Private.CoreLib]].Rent(Int32)
       mov       [rsp+0A8],rax
       test      rax,rax
       je        near ptr M08_L110
       mov       edx,[rsp+158]
       cmp       [rax+8],edx
       jb        near ptr M08_L112
       lea       r8,[rax+10]
       mov       r10d,edx
M08_L23:
       mov       [rsp+60],r8
       mov       [rsp+108],r10d
       test      rax,rax
       je        near ptr M08_L111
       mov       ecx,edx
       mov       r9d,r12d
       add       rcx,r9
       mov       r9d,[rax+8]
       cmp       rcx,r9
       ja        near ptr M08_L112
       mov       edx,edx
       lea       r9,[rax+rdx*4+10]
M08_L24:
       mov       [rsp+58],r9
       mov       [rsp+104],r12d
       mov       edx,r10d
       mov       rcx,rdx
       cmp       rcx,8
       jb        near ptr M08_L30
       lea       r11,[rcx*4]
       mov       [rsp+148],r11
       and       r11,0FFFFFFFFFFFFFFC0
       xor       r13d,r13d
       cmp       rcx,10
       jb        short M08_L26
M08_L25:
       vpcmpeqd  ymm0,ymm0,ymm0
       vmovups   [r8+r13],ymm0
       vmovups   [r8+r13+20],ymm0
       add       r13,40
       cmp       r13,r11
       jb        short M08_L25
M08_L26:
       mov       r11,[rsp+148]
       test      r11b,20
       je        short M08_L27
       vpcmpeqd  ymm0,ymm0,ymm0
       vmovups   [r8+r13],ymm0
M08_L27:
       vpcmpeqd  ymm0,ymm0,ymm0
       vmovups   [r8+r11-20],ymm0
M08_L28:
       xor       ecx,ecx
       test      edi,edi
       jle       near ptr M08_L113
       cmp       edi,r12d
       jg        near ptr M08_L45
M08_L29:
       mov       r11d,ecx
       mov       r11d,[r15+r11*4]
       mov       r13,[rsp+150]
       imul      r11,r13
       shr       r11,20
       inc       r11
       imul      r11,rdx
       shr       r11,20
       cmp       r11d,r10d
       jae       near ptr M08_L154
       mov       r11d,r11d
       lea       r11,[r8+r11*4]
       mov       ebx,ecx
       mov       eax,[r11]
       mov       [r9+rbx*4],eax
       mov       [r11],ecx
       inc       ecx
       cmp       ecx,edi
       jge       short M08_L33
       jmp       short M08_L29
M08_L30:
       xor       r11d,r11d
       test      cl,4
       je        short M08_L31
       mov       dword ptr [r8+r11*4],0FFFFFFFF
       mov       dword ptr [r8+r11*4+4],0FFFFFFFF
       mov       dword ptr [r8+r11*4+8],0FFFFFFFF
       mov       dword ptr [r8+r11*4+0C],0FFFFFFFF
       add       r11,4
M08_L31:
       test      cl,2
       je        short M08_L32
       mov       dword ptr [r8+r11*4],0FFFFFFFF
       mov       dword ptr [r8+r11*4+4],0FFFFFFFF
       add       r11,2
M08_L32:
       test      cl,1
       je        near ptr M08_L28
       mov       dword ptr [r8+r11*4],0FFFFFFFF
       jmp       near ptr M08_L28
M08_L33:
       mov       edx,edi
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbx,rax
       mov       edx,[rsp+108]
       mov       rcx,offset MT_System.Collections.Frozen.FrozenHashTable+Bucket[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       [rsp+0A0],rax
       xor       ecx,ecx
       xor       edx,edx
       cmp       dword ptr [rax+8],0
       jle       short M08_L34
       mov       r8d,[rsp+108]
       cmp       [rax+8],r8d
       jg        near ptr M08_L51
       jmp       near ptr M08_L49
M08_L34:
       mov       r12,[rsp+48]
       mov       rdx,r12
       mov       [rsp+98],rdx
       mov       r8,[rsp+0A8]
       test      r8,r8
       je        near ptr M08_L136
       mov       rdx,[rsp+98]
       mov       ecx,[r8+8]
       dec       ecx
       or        ecx,0F
       xor       r10d,r10d
       lzcnt     r10d,ecx
       xor       r10d,1F
       add       r10d,0FFFFFFFD
       mov       [rsp+144],r10d
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],7
       jle       near ptr M08_L116
       mov       rcx,[rcx+240]
       mov       r9,[rcx+38]
       test      r9,r9
       je        near ptr M08_L115
M08_L35:
       mov       [rsp+50],r9
       mov       r11,[r9+10]
       test      r11,r11
       je        near ptr M08_L117
M08_L36:
       xor       ecx,ecx
       mov       dword ptr [rsp+13C],1
       mov       r10d,[rsp+144]
       cmp       [r11+8],r10d
       jbe       near ptr M08_L37
       mov       dword ptr [rsp+140],1
       mov       edx,10
       shlx      edx,edx,r10d
       mov       r8,[rsp+0A8]
       cmp       [r8+8],edx
       jne       near ptr M08_L118
       mov       edx,r10d
       shl       rdx,4
       lea       r11,[r11+rdx+10]
       mov       [rsp+88],r11
       mov       rdx,[r11]
       mov       [rsp+80],rdx
       mov       rcx,r11
       mov       rdx,r8
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       rdx,[rsp+88]
       mov       [rdx+8],ecx
       cmp       qword ptr [rsp+80],0
       jne       near ptr M08_L119
       mov       rax,[rsp+0A0]
       mov       ecx,[rsp+140]
       mov       r10d,[rsp+144]
M08_L37:
       mov       r11,1CA7E000C90
       mov       r11,[r11]
       mov       [rsp+40],r11
       mov       rdx,r11
       mov       [rsp+90],rdx
       cmp       byte ptr [rdx+9D],0
       jne       near ptr M08_L132
M08_L38:
       lea       rcx,[rsi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+28]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rsi+30],r13
       xor       ebx,ebx
       test      edi,edi
       jle       short M08_L40
       mov       ebp,[rsp+0D4]
       cmp       ebp,edi
       jl        near ptr M08_L53
       xor       ebx,ebx
M08_L39:
       mov       r13d,[r15+rbx]
       mov       rcx,[rsi+18]
       mov       r8,[r14+rbx*2+10]
       movsxd    rdx,r13d
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       add       rbx,4
       dec       edi
       jne       short M08_L39
M08_L40:
       mov       rbx,[rsp+0C0]
       test      rbx,rbx
       je        near ptr M08_L136
       mov       ecx,[rbx+8]
       dec       ecx
       or        ecx,0F
       xor       edi,edi
       lzcnt     edi,ecx
       xor       edi,1F
       add       edi,0FFFFFFFD
       mov       rbp,[rsp+50]
       mov       rax,[rbp+10]
       test      rax,rax
       je        near ptr M08_L137
M08_L41:
       xor       ebp,ebp
       mov       r14d,1
       cmp       [rax+8],edi
       jbe       short M08_L42
       mov       ebp,1
       mov       ecx,10
       shlx      ecx,ecx,edi
       cmp       [rbx+8],ecx
       jne       near ptr M08_L138
       cmp       edi,[rax+8]
       jae       near ptr M08_L154
       mov       ecx,edi
       shl       rcx,4
       lea       r15,[rax+rcx+10]
       mov       r13,[r15]
       mov       rcx,r15
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r15+8],ecx
       test      r13,r13
       jne       near ptr M08_L139
M08_L42:
       mov       r15,[rsp+40]
       cmp       byte ptr [r15+9D],0
       jne       near ptr M08_L151
M08_L43:
       mov       rax,rsi
       vzeroupper
       add       rsp,188
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M08_L44:
       mov       r8,[rsp+60]
       mov       r9,[rsp+58]
       mov       r10d,[rsp+108]
M08_L45:
       mov       r11d,ecx
       mov       r11d,[r15+r11*4]
       imul      r11,[rsp+150]
       shr       r11,20
       inc       r11
       imul      r11,rdx
       shr       r11,20
       cmp       r11d,r10d
       jae       near ptr M08_L154
       mov       r11d,r11d
       lea       r11,[r8+r11*4]
       cmp       ecx,r12d
       jae       near ptr M08_L154
       mov       ebx,ecx
       mov       [rsp+178],rbx
       mov       ebx,[r11]
       mov       rax,[rsp+178]
       mov       [r9+rax*4],ebx
       mov       [r11],ecx
       inc       ecx
       cmp       ecx,edi
       mov       r12d,[rsp+104]
       jl        short M08_L44
       jmp       near ptr M08_L114
M08_L46:
       xor       r9d,r9d
       mov       r11d,ecx
M08_L47:
       cmp       r8d,edi
       jae       near ptr M08_L154
       mov       r13d,r8d
       lea       r13,[r15+r13*4]
       mov       r12d,[r13]
       cmp       ecx,[rbx+8]
       jae       near ptr M08_L154
       mov       ebp,ecx
       mov       [rbx+rbp*4+10],r12d
       mov       [r13],ecx
       inc       ecx
       inc       r9d
       cmp       r8d,[rsp+104]
       jae       near ptr M08_L154
       mov       r8d,r8d
       mov       rbp,[rsp+58]
       mov       r8d,[rbp+r8*4]
       test      r8d,r8d
       jge       short M08_L47
       mov       r12d,[rsp+104]
       mov       r13,[rsp+150]
       lea       r8d,[r11+r9-1]
       mov       r9d,edx
       lea       r9,[rax+r9*8+10]
       mov       [r9],r11d
       mov       [r9+4],r8d
M08_L48:
       inc       edx
       cmp       [rax+8],edx
       jle       near ptr M08_L34
M08_L49:
       mov       r8d,edx
       mov       r10,[rsp+60]
       mov       r8d,[r10+r8*4]
       test      r8d,r8d
       jl        short M08_L48
       jmp       near ptr M08_L46
M08_L50:
       inc       edx
       cmp       [rax+8],edx
       mov       rax,[rsp+0A0]
       mov       r8d,[rsp+108]
       jle       near ptr M08_L34
M08_L51:
       cmp       edx,r8d
       jae       near ptr M08_L154
       mov       r11d,edx
       mov       r10,[rsp+60]
       mov       r11d,[r10+r11*4]
       test      r11d,r11d
       jl        short M08_L50
       xor       r9d,r9d
       mov       r12d,ecx
M08_L52:
       cmp       r11d,edi
       jae       near ptr M08_L154
       mov       r13d,r11d
       lea       r13,[r15+r13*4]
       mov       r8d,[r13]
       cmp       ecx,[rbx+8]
       jae       near ptr M08_L154
       mov       ebp,ecx
       mov       [rbx+rbp*4+10],r8d
       mov       [r13],ecx
       inc       ecx
       inc       r9d
       mov       ebp,[rsp+104]
       cmp       r11d,ebp
       jae       near ptr M08_L154
       mov       r11d,r11d
       mov       r13,[rsp+58]
       mov       r11d,[r13+r11*4]
       test      r11d,r11d
       jge       short M08_L52
       mov       r13,[rsp+150]
       lea       r9d,[r12+r9-1]
       mov       r11d,edx
       lea       r11,[rax+r11*8+10]
       mov       [r11],r12d
       mov       [r11+4],r9d
       mov       r12d,[rsp+104]
       jmp       near ptr M08_L50
M08_L53:
       cmp       ebx,edi
       jae       near ptr M08_L154
       mov       ecx,ebx
       mov       r13d,[r15+rcx*4]
       mov       rcx,[rsi+18]
       cmp       ebx,ebp
       jae       near ptr M08_L154
       mov       r8d,ebx
       mov       r8,[r14+r8*8+10]
       movsxd    rdx,r13d
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       inc       ebx
       cmp       ebx,edi
       jl        short M08_L53
       jmp       near ptr M08_L40
M08_L54:
       lea       edx,[r15+1]
       mov       [rsp+15C],edx
       mov       r8,[r8]
       movsxd    rdx,r15d
       mov       rcx,r14
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       dec       r13d
       mov       r15d,[rsp+15C]
M08_L55:
       mov       rax,[rsp+0C8]
       inc       eax
       mov       rcx,rax
       cmp       ecx,[rbx+28]
       mov       rax,rcx
       jge       near ptr M08_L06
M08_L56:
       test      r13d,r13d
       je        near ptr M08_L06
       cmp       eax,[r12+8]
       jae       near ptr M08_L154
       mov       [rsp+0C8],rax
       mov       r8,rax
       shl       r8,4
       lea       r8,[r12+r8+10]
       cmp       dword ptr [r8+0C],0FFFFFFFF
       jl        short M08_L55
       jmp       short M08_L54
M08_L57:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdi,[rdx+90]
       test      rdi,rdi
       je        short M08_L58
       jmp       short M08_L59
M08_L58:
       mov       rdx,7FF9E65541C8
       call      qword ptr [7FF9E5BFF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
M08_L59:
       mov       rdx,[rbx+18]
       mov       rcx,offset MT_System.Collections.Generic.IEqualityComparer<System.String>
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rcx,rax
       call      qword ptr [7FF9E64C4D80]
       mov       rdx,rax
       mov       rcx,rdi
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdi,rax
       jmp       near ptr M08_L00
M08_L60:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+88]
       test      rdx,rdx
       je        short M08_L61
       jmp       short M08_L62
M08_L61:
       mov       rdx,7FF9E65541B8
       call      qword ptr [7FF9E5BFF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M08_L62:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdi,[rax]
       jmp       near ptr M08_L00
M08_L63:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF9E5DC7810]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       test      eax,eax
       jge       near ptr M08_L01
       mov       rcx,[rsi+18]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       je        short M08_L64
       jmp       short M08_L65
M08_L64:
       mov       rcx,rsi
       mov       rdx,7FF9E6555D28
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M08_L65:
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       cmp       [rax],rdi
       je        short M08_L66
       mov       rdx,1CA7E000068
       cmp       rdi,[rdx]
       je        short M08_L66
       mov       rdx,1CA7E000070
       cmp       rdi,[rdx]
       jne       near ptr M08_L01
M08_L66:
       mov       rdx,rdi
       mov       rcx,offset MT_System.Collections.Generic.IEqualityComparer<System.String>
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdi,rax
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.HashSet<System.String>
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       rbx,rax
       mov       edx,[rbx+28]
       sub       edx,[rbx+30]
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbp,rax
       mov       r9d,[rbx+28]
       sub       r9d,[rbx+30]
       mov       rcx,rbx
       mov       rdx,rbp
       xor       r8d,r8d
       call      qword ptr [7FF9E5F6DA28]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].CopyTo(System.__Canon[], Int32, Int32)
       mov       ebx,7FFFFFFF
       xor       r14d,r14d
       xor       r15d,r15d
       xor       ecx,ecx
       jmp       short M08_L70
M08_L67:
       mov       rdx,[rbp+rcx*8+10]
       cmp       [rdx+8],ebx
       jge       short M08_L68
       mov       ebx,[rdx+8]
M08_L68:
       cmp       [rdx+8],r14d
       jle       short M08_L69
       mov       r14d,[rdx+8]
M08_L69:
       mov       edx,[rdx+8]
       mov       r8d,1
       shlx      rdx,r8,rdx
       or        r15,rdx
       inc       ecx
M08_L70:
       cmp       [rbp+8],ecx
       jg        short M08_L67
       mov       rcx,rbp
       mov       rdx,rdi
       mov       r8d,ebx
       mov       r9d,r14d
       call      qword ptr [7FF9E64C5710]
       mov       r13,rax
       test      r13,r13
       je        short M08_L73
       mov       rcx,[rsi+18]
       cmp       qword ptr [rcx+8],30
       jle       short M08_L71
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M08_L71
       jmp       short M08_L72
M08_L71:
       mov       rcx,rsi
       mov       rdx,7FF9E6556120
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M08_L72:
       mov       rdx,r13
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       nop
       vzeroupper
       add       rsp,188
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M08_L73:
       lea       rdx,[rbp+10]
       mov       r8d,[rbp+8]
       mov       [rsp+0D8],rdx
       mov       [rsp+0E0],r8d
       mov       [rsp+20],r14d
       lea       rdx,[rsp+0D8]
       mov       r8,1CA7E000070
       cmp       rdi,[r8]
       sete      r8b
       movzx     r8d,r8b
       lea       rcx,[rsp+160]
       mov       r9d,ebx
       call      qword ptr [7FF9E64C5728]
       mov       ebx,[rsp+168]
       movzx     r14d,byte ptr [rsp+160]
       movzx     r12d,byte ptr [rsp+161]
       mov       r13d,[rsp+164]
       mov       eax,[rsp+16C]
       mov       [rsp+100],eax
       mov       edx,[rsp+170]
       mov       [rsp+0FC],edx
       test      ebx,ebx
       je        near ptr M08_L85
       test      r13d,r13d
       jge       near ptr M08_L79
       test      r14d,r14d
       je        near ptr M08_L76
       test      r12d,r12d
       jne       short M08_L74
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_RightJustifiedCaseInsensitiveSubstring
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       r15d,[rsp+0FC]
       mov       [rsp+20],r15d
       mov       [rsp+28],r13d
       mov       [rsp+30],ebx
       mov       rcx,r14
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+100]
       call      qword ptr [7FF9E64C5740]
       jmp       short M08_L75
M08_L74:
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_RightJustifiedCaseInsensitiveAsciiSubstring
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       r15d,[rsp+0FC]
       mov       [rsp+20],r15d
       mov       [rsp+28],r13d
       mov       [rsp+30],ebx
       mov       rcx,r14
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+100]
       call      qword ptr [7FF9E64C5740]
M08_L75:
       mov       r13,r14
       jmp       near ptr M08_L89
M08_L76:
       cmp       ebx,1
       je        short M08_L77
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_RightJustifiedSubstring
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       r15d,[rsp+0FC]
       mov       [rsp+20],r15d
       mov       [rsp+28],r13d
       mov       [rsp+30],ebx
       mov       rcx,r12
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+100]
       call      qword ptr [7FF9E64C5740]
       jmp       short M08_L78
M08_L77:
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_RightJustifiedSingleChar
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       r15d,[rsp+0FC]
       mov       [rsp+20],r15d
       mov       [rsp+28],r13d
       mov       dword ptr [rsp+30],1
       mov       rcx,r12
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+100]
       call      qword ptr [7FF9E64C5740]
M08_L78:
       mov       r13,r12
       jmp       near ptr M08_L89
M08_L79:
       test      r14d,r14d
       je        near ptr M08_L82
       test      r12d,r12d
       jne       short M08_L80
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_LeftJustifiedCaseInsensitiveSubstring
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       r15d,[rsp+0FC]
       mov       [rsp+20],r15d
       mov       [rsp+28],r13d
       mov       [rsp+30],ebx
       mov       rcx,r14
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+100]
       call      qword ptr [7FF9E64C5740]
       jmp       short M08_L81
M08_L80:
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_LeftJustifiedCaseInsensitiveAsciiSubstring
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       r15d,[rsp+0FC]
       mov       [rsp+20],r15d
       mov       [rsp+28],r13d
       mov       [rsp+30],ebx
       mov       rcx,r14
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+100]
       call      qword ptr [7FF9E64C5740]
M08_L81:
       mov       r13,r14
       jmp       near ptr M08_L89
M08_L82:
       cmp       ebx,1
       je        short M08_L83
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_LeftJustifiedSubstring
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       r15d,[rsp+0FC]
       mov       [rsp+20],r15d
       mov       [rsp+28],r13d
       mov       [rsp+30],ebx
       mov       rcx,r12
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+100]
       call      qword ptr [7FF9E64C5740]
       jmp       short M08_L84
M08_L83:
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_LeftJustifiedSingleChar
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       r15d,[rsp+0FC]
       mov       [rsp+20],r15d
       mov       [rsp+28],r13d
       mov       dword ptr [rsp+30],1
       mov       rcx,r12
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+100]
       call      qword ptr [7FF9E64C5740]
M08_L84:
       mov       r13,r12
       jmp       near ptr M08_L89
M08_L85:
       test      r14d,r14d
       je        short M08_L88
       test      r12d,r12d
       jne       short M08_L86
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_FullCaseInsensitive
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       ebx,[rsp+0FC]
       mov       [rsp+20],ebx
       mov       [rsp+28],r15
       mov       rcx,r13
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+100]
       call      qword ptr [7FF9E64C5758]
       jmp       short M08_L87
M08_L86:
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_FullCaseInsensitiveAscii
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       ebx,[rsp+0FC]
       mov       [rsp+20],ebx
       mov       [rsp+28],r15
       mov       rcx,r13
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+100]
       call      qword ptr [7FF9E64C5770]
M08_L87:
       jmp       short M08_L89
M08_L88:
       mov       rcx,offset MT_System.Collections.Frozen.OrdinalStringFrozenSet_Full
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       ebx,[rsp+0FC]
       mov       [rsp+20],ebx
       mov       [rsp+28],r15
       mov       rcx,r13
       mov       rdx,rbp
       mov       r8,rdi
       mov       r9d,[rsp+100]
       call      qword ptr [7FF9E64C5788]
M08_L89:
       mov       rcx,[rsi+18]
       cmp       qword ptr [rcx+8],30
       jle       short M08_L90
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M08_L90
       jmp       short M08_L91
M08_L90:
       mov       rcx,rsi
       mov       rdx,7FF9E6556120
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M08_L91:
       mov       rdx,r13
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       nop
       vzeroupper
       add       rsp,188
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M08_L92:
       mov       rcx,[rsi+18]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M08_L93
       jmp       short M08_L94
M08_L93:
       mov       rcx,rsi
       mov       rdx,7FF9E6555C08
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M08_L94:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF9E64C63B8]
       mov       rax,rsi
       vzeroupper
       add       rsp,188
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M08_L95:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdi,[rdx+90]
       test      rdi,rdi
       je        short M08_L96
       jmp       short M08_L97
M08_L96:
       mov       rdx,7FF9E65541C8
       call      qword ptr [7FF9E5BFF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
M08_L97:
       mov       rdx,[rbx+18]
       mov       rcx,offset MT_System.Collections.Generic.IEqualityComparer<System.String>
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rcx,rax
       call      qword ptr [7FF9E64C4D80]
       mov       rdx,rax
       mov       rcx,rdi
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdx,rax
       jmp       near ptr M08_L03
M08_L98:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+88]
       test      rdx,rdx
       je        short M08_L99
       jmp       short M08_L100
M08_L99:
       mov       rdx,7FF9E65541B8
       call      qword ptr [7FF9E5BFF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M08_L100:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       jmp       near ptr M08_L03
M08_L101:
       mov       ecx,28F
       mov       rdx,7FF9E5B34000
       call      qword ptr [7FF9E5BFF228]
       mov       rdx,rax
       mov       ecx,r13d
       call      qword ptr [7FF9E62D53E0]
       int       3
M08_L102:
       test      edi,edi
       jne       near ptr M08_L112
       xor       r15d,r15d
       xor       edi,edi
       jmp       near ptr M08_L07
M08_L103:
       jmp       near ptr M08_L22
M08_L104:
       xor       eax,eax
       jmp       near ptr M08_L15
M08_L105:
       mov       r9d,80
       test      dl,1
       je        short M08_L106
       mov       r9d,edx
       and       r9,2
       movzx     r9d,byte ptr [rcx+r9]
       or        r9d,8000
M08_L106:
       test      dl,2
       je        short M08_L107
       shl       r9d,10
       movzx     ecx,word ptr [rcx]
       or        r9d,ecx
       mov       ecx,r9d
       jmp       near ptr M08_L14
M08_L107:
       mov       ecx,r9d
       jmp       near ptr M08_L14
M08_L108:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       jmp       near ptr M08_L15
M08_L109:
       mov       r8,[rsp+0B8]
       mov       rdx,r8
       call      qword ptr [r11]
       jmp       near ptr M08_L15
M08_L110:
       mov       edx,[rsp+158]
       test      edx,edx
       jne       short M08_L112
       xor       r8d,r8d
       xor       r10d,r10d
       jmp       near ptr M08_L23
M08_L111:
       or        edx,r12d
       jne       short M08_L112
       xor       r9d,r9d
       xor       r12d,r12d
       mov       ecx,r9d
       mov       r9,r12
       mov       r12d,ecx
       jmp       near ptr M08_L24
M08_L112:
       call      qword ptr [7FF9E5DCF228]
       int       3
M08_L113:
       mov       r13,[rsp+150]
       jmp       near ptr M08_L33
M08_L114:
       mov       r13,[rsp+150]
       jmp       near ptr M08_L33
M08_L115:
       mov       ecx,7
       call      qword ptr [7FF9E62D56E0]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       r9,rax
       mov       rax,[rsp+0A0]
       mov       rdx,[rsp+98]
       jmp       near ptr M08_L35
M08_L116:
       jmp       short M08_L115
M08_L117:
       mov       rcx,rdx
       call      qword ptr [7FF9E619F480]; System.Buffers.SharedArrayPool`1[[System.Int32, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
       mov       r11,rax
       mov       rax,[rsp+0A0]
       jmp       near ptr M08_L36
M08_L118:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9E622EEF8]
       mov       rbx,rax
       mov       ecx,29B
       mov       rdx,7FF9E5B34000
       call      qword ptr [7FF9E5BFF228]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9E5F67D50]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M08_L119:
       mov       r8,[rsp+98]
       mov       rcx,[r8+10]
       mov       r10d,[rsp+144]
       cmp       r10d,[rcx+8]
       jae       near ptr M08_L154
       mov       edx,r10d
       mov       r9,[rcx+rdx*8+10]
       test      r9,r9
       jne       short M08_L121
       mov       rcx,r8
       mov       edx,r10d
       call      qword ptr [7FF9E64C4CD8]
       mov       r9,rax
M08_L120:
       mov       rcx,[r9+8]
       mov       [rsp+78],rcx
       call      qword ptr [7FF9E622F4C8]; System.Threading.Thread.GetCurrentProcessorNumber()
       mov       ecx,0AAAAAAAB
       mov       edx,eax
       imul      rcx,rdx
       shr       rcx,23
       imul      ecx,0C
       sub       eax,ecx
       xor       edx,edx
       jmp       near ptr M08_L128
M08_L121:
       jmp       short M08_L120
M08_L122:
       cmp       eax,[r8+8]
       jae       near ptr M08_L154
       mov       [rsp+128],eax
       mov       ecx,eax
       mov       r10,[r8+rcx*8+10]
       mov       [rsp+70],r10
       cmp       [r10],r10b
       xor       r9d,r9d
       mov       [rsp+120],r9d
       mov       rcx,r10
       call      qword ptr [7FF9E611DFB0]; System.Threading.Monitor.Enter(System.Object)
       mov       rax,[rsp+70]
       mov       rcx,[rax+8]
       mov       r8d,[rax+10]
       mov       [rsp+11C],r8d
       cmp       [rcx+8],r8d
       jbe       short M08_L124
       test      r8d,r8d
       jne       short M08_L125
       xor       edx,edx
       mov       [rax+14],edx
M08_L123:
       movsxd    rdx,r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,[rsp+80]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rsp+11C]
       inc       ecx
       mov       rax,[rsp+70]
       mov       [rax+10],ecx
       mov       dword ptr [rsp+120],1
M08_L124:
       mov       rcx,rax
       call      qword ptr [7FF9E5BF6820]; System.Threading.Monitor.Exit(System.Object)
       cmp       dword ptr [rsp+120],0
       je        short M08_L126
       jmp       short M08_L129
M08_L125:
       jmp       short M08_L123
M08_L126:
       mov       eax,[rsp+128]
       inc       eax
       mov       ecx,eax
       mov       r8,[rsp+78]
       cmp       [r8+8],ecx
       jne       short M08_L127
       xor       ecx,ecx
M08_L127:
       mov       edx,[rsp+124]
       inc       edx
       mov       eax,ecx
M08_L128:
       mov       r8,[rsp+78]
       mov       [rsp+124],edx
       cmp       [r8+8],edx
       jg        near ptr M08_L122
       jmp       short M08_L130
M08_L129:
       mov       edx,1
       jmp       short M08_L131
M08_L130:
       xor       edx,edx
M08_L131:
       mov       [rsp+13C],edx
       mov       rax,[rsp+0A0]
       mov       ecx,[rsp+140]
       mov       r10d,[rsp+144]
       jmp       near ptr M08_L37
M08_L132:
       mov       r8,[rsp+0A8]
       cmp       dword ptr [r8+8],0
       mov       [rsp+140],ecx
       je        near ptr M08_L38
       mov       rcx,r8
       call      qword ptr [7FF9E601D740]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+138],eax
       mov       rdx,[rsp+0A8]
       mov       r8d,[rdx+8]
       mov       [rsp+134],r8d
       mov       rcx,[rsp+98]
       call      qword ptr [7FF9E601D740]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,[rsp+90]
       mov       r8d,[rsp+138]
       mov       r9d,[rsp+134]
       mov       edx,3
       call      qword ptr [7FF9E62D6970]
       mov       eax,[rsp+140]
       test      [rsp+13C],eax
       jne       short M08_L133
       mov       rcx,[rsp+0A8]
       call      qword ptr [7FF9E601D740]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+130],eax
       mov       rcx,[rsp+0A8]
       mov       edx,[rcx+8]
       mov       [rsp+12C],edx
       mov       rcx,[rsp+98]
       call      qword ptr [7FF9E601D740]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       cmp       dword ptr [rsp+140],0
       jne       short M08_L134
       mov       ecx,0FFFFFFFF
       mov       edx,1
       jmp       short M08_L135
M08_L133:
       mov       rax,[rsp+0A0]
       jmp       near ptr M08_L38
M08_L134:
       mov       ecx,[rsp+144]
       xor       edx,edx
M08_L135:
       mov       [rsp+20],ecx
       mov       [rsp+28],edx
       mov       rcx,[rsp+90]
       mov       edx,[rsp+130]
       mov       r8d,[rsp+12C]
       call      qword ptr [7FF9E622EF70]
       mov       rax,[rsp+0A0]
       jmp       near ptr M08_L38
M08_L136:
       mov       ecx,2
       call      qword ptr [7FF9E5BFFD50]
       int       3
M08_L137:
       mov       rcx,r12
       call      qword ptr [7FF9E619F480]; System.Buffers.SharedArrayPool`1[[System.Int32, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
       jmp       near ptr M08_L41
M08_L138:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9E622EEF8]
       mov       r12,rax
       mov       ecx,29B
       mov       rdx,7FF9E5B34000
       call      qword ptr [7FF9E5BFF228]
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,rbx
       call      qword ptr [7FF9E5F67D50]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M08_L139:
       mov       rcx,[r12+10]
       cmp       edi,[rcx+8]
       jae       near ptr M08_L154
       mov       edx,edi
       mov       rax,[rcx+rdx*8+10]
       test      rax,rax
       jne       short M08_L140
       mov       rcx,r12
       mov       edx,edi
       call      qword ptr [7FF9E64C4CD8]
M08_L140:
       mov       r14,[rax+8]
       call      qword ptr [7FF9E622F4C8]; System.Threading.Thread.GetCurrentProcessorNumber()
       mov       ecx,0AAAAAAAB
       mov       edx,eax
       imul      rcx,rdx
       shr       rcx,23
       imul      ecx,0C
       mov       r15d,eax
       sub       r15d,ecx
       xor       eax,eax
       jmp       near ptr M08_L147
M08_L141:
       cmp       r15d,[r14+8]
       jae       near ptr M08_L154
       mov       ecx,r15d
       mov       rdx,[r14+rcx*8+10]
       mov       [rsp+68],rdx
       cmp       [rdx],dl
       xor       r8d,r8d
       mov       [rsp+110],r8d
       mov       rcx,rdx
       call      qword ptr [7FF9E611DFB0]; System.Threading.Monitor.Enter(System.Object)
       mov       rax,[rsp+68]
       mov       rcx,[rax+8]
       mov       r8d,[rax+10]
       mov       [rsp+10C],r8d
       cmp       [rcx+8],r8d
       jbe       short M08_L143
       test      r8d,r8d
       jne       short M08_L144
       xor       edx,edx
       mov       [rax+14],edx
M08_L142:
       movsxd    rdx,r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rsp+10C]
       inc       ecx
       mov       rax,[rsp+68]
       mov       [rax+10],ecx
       mov       dword ptr [rsp+110],1
M08_L143:
       mov       rcx,rax
       call      qword ptr [7FF9E5BF6820]; System.Threading.Monitor.Exit(System.Object)
       cmp       dword ptr [rsp+110],0
       je        short M08_L145
       jmp       short M08_L148
M08_L144:
       jmp       short M08_L142
M08_L145:
       inc       r15d
       cmp       [r14+8],r15d
       jne       short M08_L146
       xor       r15d,r15d
M08_L146:
       mov       eax,[rsp+114]
       inc       eax
M08_L147:
       mov       [rsp+114],eax
       cmp       [r14+8],eax
       jg        near ptr M08_L141
       jmp       short M08_L149
M08_L148:
       mov       r14d,1
       jmp       short M08_L150
M08_L149:
       xor       r14d,r14d
M08_L150:
       jmp       near ptr M08_L42
M08_L151:
       cmp       dword ptr [rbx+8],0
       je        near ptr M08_L43
       mov       rcx,rbx
       call      qword ptr [7FF9E601D740]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r13d,eax
       mov       eax,[rbx+8]
       mov       [rsp+118],eax
       mov       rcx,r12
       call      qword ptr [7FF9E601D740]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,r15
       mov       r8d,r13d
       mov       r9d,[rsp+118]
       mov       edx,3
       call      qword ptr [7FF9E62D6970]
       test      r14d,ebp
       jne       near ptr M08_L43
       mov       rcx,rbx
       call      qword ptr [7FF9E601D740]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r14d,eax
       mov       ebx,[rbx+8]
       mov       rcx,r12
       call      qword ptr [7FF9E601D740]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       test      ebp,ebp
       jne       short M08_L152
       mov       ecx,0FFFFFFFF
       mov       edx,1
       jmp       short M08_L153
M08_L152:
       mov       ecx,edi
       xor       edx,edx
M08_L153:
       mov       [rsp+20],ecx
       mov       [rsp+28],edx
       mov       rcx,r15
       mov       edx,r14d
       mov       r8d,ebx
       call      qword ptr [7FF9E622EF70]
       jmp       near ptr M08_L43
M08_L154:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 6068
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
       call      00007FFA45879D30
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF9E5BF5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF9E5BF5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,20B12EE0008
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
       call      qword ptr [7FF9E642F978]
       int       3
; Total bytes of code 235
```
```assembly
; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].get_Comparer()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       rcx,[rbx]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rdx,offset MT_System.String
       cmp       [rcx],rdx
       je        short M11_L01
       mov       rax,[rbx+18]
       test      rax,rax
       je        short M11_L04
M11_L00:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M11_L01:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rsi,[rdx+90]
       test      rsi,rsi
       je        short M11_L02
       jmp       short M11_L03
M11_L02:
       mov       rdx,7FF9E65541C8
       call      qword ptr [7FF9E5BFF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rsi,rax
M11_L03:
       mov       rdx,[rbx+18]
       mov       rcx,offset MT_System.Collections.Generic.IEqualityComparer<System.String>
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rcx,rax
       call      qword ptr [7FF9E64C4D80]
       mov       rdx,rax
       mov       rcx,rsi
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M11_L04:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+88]
       test      rdx,rdx
       je        short M11_L05
       jmp       short M11_L06
M11_L05:
       mov       rdx,7FF9E65541B8
       call      qword ptr [7FF9E5BFF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M11_L06:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rax]
       jmp       near ptr M11_L00
; Total bytes of code 204
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M12_L00
       ret
M12_L00:
       jmp       qword ptr [7FF9E5BF5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

