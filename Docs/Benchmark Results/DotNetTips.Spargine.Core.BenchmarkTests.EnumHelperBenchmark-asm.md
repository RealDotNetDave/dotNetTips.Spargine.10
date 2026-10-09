## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.EnumHelperBenchmark.GetItems_FixNamesFalse()
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
       vmovdqu   ymmword ptr [rbp-80],ymm4
       vmovdqu   ymmword ptr [rbp-60],ymm4
       xor       eax,eax
       mov       [rbp-40],rax
       mov       rbx,rcx
       mov       rcx,28BD30001B8
       mov       rsi,[rcx]
       mov       rcx,28BD30001A8
       mov       rdi,[rcx]
       test      rsi,rsi
       je        near ptr M00_L09
M00_L00:
       mov       r14,[rdi+8]
       mov       rcx,[r14+8]
       mov       rax,2CC52090B70
       mov       [rbp-50],rax
       mov       byte ptr [rbp-48],0
       test      rcx,rcx
       jne       near ptr M00_L10
       xor       ecx,ecx
       mov       [rbp-58],rcx
       lea       rcx,[rbp-50]
       cmp       qword ptr [rbp-58],0
       jne       short M00_L01
       mov       rcx,[rbp-50]
       mov       [rbp-58],rcx
       lea       rcx,[rbp-58]
       cmp       qword ptr [rbp-58],0
       je        near ptr M00_L11
M00_L01:
       mov       r15,[rcx]
       mov       rcx,offset MT_System.RuntimeType
       cmp       [r15],rcx
       jne       near ptr M00_L12
       mov       rcx,r15
       call      00007FFDB6DC3FE0
       test      eax,eax
       je        near ptr M00_L08
M00_L02:
       mov       r15d,eax
M00_L03:
       imul      edx,r15d,0C2B2AE3D
       add       edx,41CBC134
       rol       edx,11
       imul      edx,27D4EB2F
       cmp       byte ptr [rbp-48],0
       setne     cl
       movzx     ecx,cl
       imul      ecx,0C2B2AE3D
       add       edx,ecx
       rol       edx,11
       imul      edx,27D4EB2F
       mov       ecx,edx
       shr       ecx,0F
       xor       ecx,edx
       imul      edx,ecx,85EBCA77
       mov       ecx,edx
       shr       ecx,0D
       xor       ecx,edx
       imul      edx,ecx,0C2B2AE3D
       mov       r15d,edx
       shr       r15d,10
       xor       r15d,edx
       xor       edx,edx
       mov       [rbp-58],rdx
M00_L04:
       mov       r13,[r14+8]
       test      r13,r13
       jne       near ptr M00_L16
       mov       rcx,[r14+10]
       mov       edx,r15d
       imul      rdx,[r14+28]
       shr       rdx,20
       inc       rdx
       mov       r13d,[rcx+8]
       mov       eax,r13d
       imul      rdx,rax
       shr       rdx,20
       cmp       edx,r13d
       jae       near ptr M00_L20
       mov       edx,edx
       mov       r13,[rcx+rdx*8+10]
       test      r13,r13
       je        near ptr M00_L15
M00_L05:
       cmp       r15d,[r13+18]
       jne       near ptr M00_L14
       mov       rcx,[r13+20]
       movzx     r12d,byte ptr [r13+28]
       test      rcx,rcx
       je        near ptr M00_L14
       mov       rdx,offset MT_System.RuntimeType
       cmp       [rcx],rdx
       jne       near ptr M00_L13
       mov       rdx,2CC52090B70
       cmp       rcx,rdx
       sete      al
       movzx     eax,al
M00_L06:
       test      eax,eax
       je        near ptr M00_L14
       test      r12d,r12d
       jne       near ptr M00_L14
       mov       r8,[r13+8]
       mov       [rbp-40],r8
M00_L07:
       mov       rcx,[rbp-40]
       xor       edx,edx
       mov       [rbp-40],rdx
       mov       [rbp-60],rcx
       mov       rbx,[rbx+90]
       mov       rdx,[rbp-60]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
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
M00_L08:
       mov       rcx,r15
       call      qword ptr [7FFD5719E970]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       jmp       near ptr M00_L02
M00_L09:
       mov       rcx,offset MT_System.Func<System.ValueTuple<System.Type, System.Boolean>, System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Core.EnumValue>>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,28BD30001B0
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Core.EnumHelper+<>c__6`1[[System.Net.Cache.RequestCacheLevel, System.Net.Primitives]].<GetItems>b__6_0(System.ValueTuple`2<System.Type,Boolean>)
       call      qword ptr [7FFD57196BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,28BD30001B8
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L10:
       vmovdqu   xmm0,xmmword ptr [rbp-50]
       vmovdqu   xmmword ptr [rbp-70],xmm0
       lea       rdx,[rbp-70]
       mov       r11,7FFD570E09E0
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       near ptr M00_L04
M00_L11:
       xor       r15d,r15d
       jmp       near ptr M00_L03
M00_L12:
       mov       rcx,r15
       mov       rax,[r15]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
       mov       r15d,eax
       jmp       near ptr M00_L03
M00_L13:
       mov       rdx,2CC52090B70
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       jmp       near ptr M00_L06
M00_L14:
       mov       r13,[r13+10]
       test      r13,r13
       jne       near ptr M00_L05
M00_L15:
       xor       edx,edx
       mov       [rbp-40],rdx
       mov       rdx,2CC52090B70
       mov       [rbp-70],rdx
       mov       byte ptr [rbp-68],0
       mov       [rbp-80],rdx
       mov       byte ptr [rbp-78],0
       lea       rdx,[rbp-80]
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       xor       r8d,r8d
       mov       [rsp+28],r8d
       mov       dword ptr [rsp+30],1
       lea       r8,[rbp-40]
       mov       [rsp+38],r8
       mov       [rsp+20],rax
       lea       r8,[rbp-70]
       mov       r9d,r15d
       shl       r9,20
       or        r9,1
       mov       rdx,r14
       mov       rcx,rdi
       call      qword ptr [7FFD577CE880]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.ValueTuple`2[[System.__Canon, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryAddInternal(Tables<System.ValueTuple`2<System.__Canon,Boolean>,System.__Canon>, System.ValueTuple`2<System.__Canon,Boolean>, System.Nullable`1<Int32>, System.__Canon, Boolean, Boolean, System.__Canon ByRef)
       jmp       near ptr M00_L07
M00_L16:
       mov       r8,[r14+10]
       mov       edx,r15d
       imul      rdx,[r14+28]
       shr       rdx,20
       inc       rdx
       mov       ecx,[r8+8]
       mov       r11d,ecx
       imul      rdx,r11
       shr       rdx,20
       cmp       edx,ecx
       jae       short M00_L20
       mov       edx,edx
       mov       r12,[r8+rdx*8+10]
       test      r12,r12
       je        near ptr M00_L15
M00_L17:
       cmp       r15d,[r12+18]
       jne       short M00_L18
       vmovdqu   xmm0,xmmword ptr [r12+20]
       vmovdqu   xmmword ptr [rbp-70],xmm0
       mov       r8,2CC52090B70
       mov       [rbp-80],r8
       mov       byte ptr [rbp-78],0
       lea       r8,[rbp-80]
       lea       rdx,[rbp-70]
       mov       rcx,r13
       mov       r11,7FFD570E09E8
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L19
M00_L18:
       mov       r12,[r12+10]
       test      r12,r12
       jne       short M00_L17
       jmp       near ptr M00_L15
M00_L19:
       mov       rdx,[r12+8]
       mov       [rbp-40],rdx
       jmp       near ptr M00_L07
M00_L20:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 963
```
```assembly
; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
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
       mov       [rbp+10],rcx
       cmp       qword ptr [rbp+10],0
       je        short M01_L01
       lea       rcx,[rbp+10]
       mov       [rbp-98],rcx
       lea       rcx,[rbp-90]
       call      qword ptr [7FFD9C999030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-98]
       call      qword ptr [rax]
       mov       ebx,eax
       lea       rcx,[rbp-90]
       call      qword ptr [7FFD9C999038]; CORINFO_HELP_JIT_PINVOKE_END
       mov       eax,ebx
M01_L00:
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
M01_L01:
       xor       eax,eax
       jmp       short M01_L00
; Total bytes of code 119
```
```assembly
; DotNetTips.Spargine.Core.EnumHelper+<>c__6`1[[System.Net.Cache.RequestCacheLevel, System.Net.Primitives]].<GetItems>b__6_0(System.ValueTuple`2<System.Type,Boolean>)
       push      rbp
       sub       rsp,0D0
       lea       rbp,[rsp+0D0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-0B0],ymm4
       vmovdqu   ymmword ptr [rbp-90],ymm4
       vmovdqu   ymmword ptr [rbp-70],ymm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       xor       eax,eax
       mov       [rbp-40],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       dword ptr [rbp-98],3E8
; 			var (cachedEnumType, cachedFixNames) = key;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rax,[rbp+18]
       mov       rax,[rax]
       mov       [rbp-40],rax
       mov       rax,[rbp+18]
       movzx     eax,byte ptr [rax+8]
       mov       [rbp-44],eax
; 			var enumValues = (T[])Enum.GetValues(cachedEnumType);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,[rbp-40]
       call      qword ptr [7FFD577CE9E8]; System.Enum.GetValues(System.Type)
       mov       [rbp-90],rax
       mov       rcx,[rbp-90]
       mov       rdx,7FFD57833DC0
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rax,[rbp-90]
       mov       [rbp-0A0],rax
       mov       rdx,[rbp-0A0]
       mov       rcx,offset MT_System.Net.Cache.RequestCacheLevel[]
       call      qword ptr [7FFD571958D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       [rbp-50],rax
; 			var length = enumValues.Length;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rax,[rbp-50]
       mov       eax,[rax+8]
       mov       [rbp-54],eax
; 			var result = new EnumValue[length];
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       movsxd    rdx,dword ptr [rbp-54]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.EnumValue[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       [rbp-60],rax
; 			var enumNames = GetNames(cachedEnumType, cachedFixNames);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,[rbp-40]
       mov       edx,[rbp-44]
       call      qword ptr [7FFD577CEA00]; DotNetTips.Spargine.Core.EnumHelper.GetNames(System.Type, Boolean)
       mov       [rbp-68],rax
; 			for (var valueIndex = 0; valueIndex < length; valueIndex++)
; 			     ^^^^^^^^^^^^^^^^^^
       xor       eax,eax
       mov       [rbp-6C],eax
       jmp       near ptr M02_L01
M02_L00:
       mov       rcx,7FFD57833EC8
       call      CORINFO_HELP_COUNTPROFILE32
; 				var value = Convert.ToInt32(enumValues[valueIndex], CultureInfo.InvariantCulture);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,offset MT_System.Net.Cache.RequestCacheLevel
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-80],rax
       mov       rax,[rbp-50]
       mov       ecx,[rbp-6C]
       cmp       ecx,[rax+8]
       jae       near ptr M02_L03
       mov       edx,ecx
       lea       rax,[rax+rdx*4+10]
       mov       eax,[rax]
       mov       rcx,[rbp-80]
       mov       [rcx+8],eax
       call      qword ptr [7FFD577C51D0]; System.Globalization.CultureInfo.get_InvariantCulture()
       mov       [rbp-0A8],rax
       mov       rdx,[rbp-0A8]
       mov       rcx,[rbp-80]
       call      qword ptr [7FFD577CEA18]; System.Convert.ToInt32(System.Object, System.IFormatProvider)
       mov       [rbp-78],eax
; 				result[valueIndex] = new EnumValue(value, enumNames[valueIndex]);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,offset MT_DotNetTips.Spargine.Core.EnumValue
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-88],rax
       mov       rcx,[rbp-68]
       mov       edx,[rbp-6C]
       cmp       [rcx],ecx
       call      qword ptr [7FFD57283578]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Item(Int32)
       mov       [rbp-0B0],rax
       mov       r8,[rbp-0B0]
       lea       rdx,[rbp-78]
       mov       rcx,[rbp-88]
       call      qword ptr [7FFD577CEA30]; DotNetTips.Spargine.Core.EnumValue..ctor(Int32 ByRef, System.String)
       movsxd    rdx,dword ptr [rbp-6C]
       mov       rcx,[rbp-60]
       mov       r8,[rbp-88]
       call      qword ptr [7FFD571957B8]; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       eax,[rbp-6C]
       add       eax,1
       jo        short M02_L04
       mov       [rbp-6C],eax
M02_L01:
       mov       eax,[rbp-98]
       dec       eax
       mov       [rbp-98],eax
       cmp       dword ptr [rbp-98],0
       jg        short M02_L02
       lea       rcx,[rbp-98]
       mov       edx,68
       call      CORINFO_HELP_PATCHPOINT
M02_L02:
       mov       eax,[rbp-6C]
       cmp       eax,[rbp-54]
       jl        near ptr M02_L00
       mov       rcx,7FFD57833ECC
       call      CORINFO_HELP_COUNTPROFILE32
; 			return Array.AsReadOnly(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rdx,[rbp-60]
       mov       rcx,7FFD57833D38
       call      qword ptr [7FFD576BD2A8]; System.Array.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       nop
       add       rsp,0D0
       pop       rbp
       ret
M02_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M02_L04:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 540
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M03_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M03_L00:
       call      qword ptr [7FFD57895908]
       int       3
; Total bytes of code 44
```
```assembly
; System.Collections.Concurrent.ConcurrentDictionary`2[[System.ValueTuple`2[[System.__Canon, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryAddInternal(Tables<System.ValueTuple`2<System.__Canon,Boolean>,System.__Canon>, System.ValueTuple`2<System.__Canon,Boolean>, System.Nullable`1<Int32>, System.__Canon, Boolean, Boolean, System.__Canon ByRef)
       push      rbp
       sub       rsp,180
       lea       rbp,[rsp+180]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-120],xmm4
       vmovdqa   xmmword ptr [rbp-110],xmm4
       mov       rax,0FFFFFFFFFFFFFF40
M04_L00:
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       vmovdqa   xmmword ptr [rbp+rax-20],xmm4
       add       rax,30
       jne       short M04_L00
       mov       [rbp-40],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9
       mov       dword ptr [rbp-0E0],3E8
       mov       rax,[rbp+18]
       mov       rax,[rax+8]
       mov       [rbp-48],rax
       mov       rax,[rbp+28]
       mov       [rbp-58],rax
       lea       rcx,[rbp-58]
       call      qword ptr [7FFD576B71C8]; System.Nullable`1[[System.Int32, System.Private.CoreLib]].get_HasValue()
       test      eax,eax
       jne       short M04_L01
       mov       rax,[rbp+20]
       vmovdqu   xmm0,xmmword ptr [rax]
       vmovdqu   xmmword ptr [rbp-0F0],xmm0
       lea       r8,[rbp-0F0]
       mov       rdx,[rbp-48]
       mov       rcx,[rbp+10]
       call      qword ptr [7FFD577CE850]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.ValueTuple`2[[System.__Canon, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GetHashCode(System.Collections.Generic.IEqualityComparer`1<System.ValueTuple`2<System.__Canon,Boolean>>, System.ValueTuple`2<System.__Canon,Boolean>)
       mov       [rbp-0B0],eax
       jmp       short M04_L02
M04_L01:
       mov       rcx,7FFD57835EA8
       call      CORINFO_HELP_COUNTPROFILE32
       lea       rcx,[rbp-58]
       call      qword ptr [7FFD576B71E0]; System.Nullable`1[[System.Int32, System.Private.CoreLib]].GetValueOrDefault()
       mov       [rbp-0B0],eax
M04_L02:
       mov       eax,[rbp-0B0]
       mov       [rbp-4C],eax
M04_L03:
       mov       eax,[rbp-0E0]
       dec       eax
       mov       [rbp-0E0],eax
       cmp       dword ptr [rbp-0E0],0
       jg        short M04_L04
       lea       rcx,[rbp-0E0]
       mov       edx,24
       call      CORINFO_HELP_PATCHPOINT
M04_L04:
       mov       rax,[rbp+18]
       mov       rax,[rax+18]
       mov       [rbp-60],rax
       mov       rax,[rbp+10]
       mov       rax,[rax]
       mov       [rbp-128],rax
       mov       rax,[rbp-128]
       mov       rax,[rax+30]
       mov       rax,[rax]
       mov       rax,[rax+18]
       mov       [rbp-130],rax
       cmp       qword ptr [rbp-130],0
       je        short M04_L05
       mov       rax,[rbp-130]
       mov       [rbp-0B8],rax
       jmp       short M04_L06
M04_L05:
       mov       rcx,[rbp-128]
       mov       rdx,7FFD57819AA0
       call      qword ptr [7FFD5719C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       [rbp-0B8],rax
M04_L06:
       lea       r9,[rbp-70]
       mov       rcx,[rbp-0B8]
       mov       rdx,[rbp+18]
       mov       r8d,[rbp-4C]
       call      qword ptr [7FFD577CEBE0]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.ValueTuple`2[[System.__Canon, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GetBucketAndLock(Tables<System.ValueTuple`2<System.__Canon,Boolean>,System.__Canon>, Int32, UInt32 ByRef)
       mov       [rbp-68],rax
       xor       eax,eax
       mov       [rbp-74],eax
       xor       eax,eax
       mov       [rbp-78],eax
       xor       eax,eax
       mov       [rbp-80],eax
       movzx     eax,byte ptr [rbp+40]
       test      eax,eax
       je        short M04_L07
       mov       rcx,7FFD57835EAC
       call      CORINFO_HELP_COUNTPROFILE32
       lea       rdx,[rbp-80]
       mov       rax,[rbp-60]
       mov       ecx,[rbp-70]
       cmp       ecx,[rax+8]
       jae       near ptr M04_L20
       mov       r8d,ecx
       lea       rax,[rax+r8*8+10]
       mov       rcx,[rax]
       call      qword ptr [7FFD57195998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
M04_L07:
       mov       rax,[rbp+10]
       mov       rax,[rax+8]
       cmp       rax,[rbp+18]
       je        short M04_L09
       mov       rax,[rbp+10]
       mov       rax,[rax+8]
       mov       [rbp+18],rax
       mov       rax,[rbp+18]
       mov       rax,[rax+8]
       cmp       rax,[rbp-48]
       je        short M04_L08
       mov       rcx,7FFD57835EB0
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,[rbp+18]
       mov       rax,[rax+8]
       mov       [rbp-48],rax
       mov       rax,[rbp+20]
       vmovdqu   xmm0,xmmword ptr [rax]
       vmovdqu   xmmword ptr [rbp-100],xmm0
       lea       r8,[rbp-100]
       mov       rdx,[rbp-48]
       mov       rcx,[rbp+10]
       call      qword ptr [7FFD577CE850]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.ValueTuple`2[[System.__Canon, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GetHashCode(System.Collections.Generic.IEqualityComparer`1<System.ValueTuple`2<System.__Canon,Boolean>>, System.ValueTuple`2<System.__Canon,Boolean>)
       mov       [rbp-4C],eax
M04_L08:
       mov       rcx,7FFD57835EB4
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M04_L25
M04_L09:
       xor       eax,eax
       mov       [rbp-84],eax
       xor       eax,eax
       mov       [rbp-90],rax
       mov       rax,[rbp-68]
       mov       rax,[rax]
       mov       [rbp-0A0],rax
       jmp       near ptr M04_L18
M04_L10:
       mov       rax,[rbp-0A0]
       mov       eax,[rax+18]
       cmp       eax,[rbp-4C]
       jne       near ptr M04_L17
       mov       rax,[rbp+10]
       mov       rax,[rax]
       mov       [rbp-138],rax
       mov       rax,[rbp-138]
       mov       rax,[rax+30]
       mov       rax,[rax]
       mov       rax,[rax+18]
       mov       [rbp-140],rax
       cmp       qword ptr [rbp-140],0
       je        short M04_L11
       mov       rax,[rbp-140]
       mov       [rbp-0C0],rax
       jmp       short M04_L12
M04_L11:
       mov       rcx,[rbp-138]
       mov       rdx,7FFD57819AA0
       call      qword ptr [7FFD5719C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       [rbp-0C0],rax
M04_L12:
       mov       rax,[rbp+20]
       vmovdqu   xmm0,xmmword ptr [rax]
       vmovdqu   xmmword ptr [rbp-110],xmm0
       lea       r9,[rbp-110]
       mov       rdx,[rbp-48]
       mov       r8,[rbp-0A0]
       mov       rcx,[rbp-0C0]
       call      qword ptr [7FFD577CEBF8]
       test      eax,eax
       je        short M04_L13
       movzx     eax,byte ptr [rbp+38]
       test      eax,eax
       je        short M04_L15
       jmp       short M04_L14
M04_L13:
       mov       rcx,7FFD57835EB8
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M04_L17
M04_L14:
       mov       rax,[rbp-0A0]
       lea       rcx,[rax+8]
       mov       rdx,[rbp+30]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+48]
       mov       rdx,[rbp+30]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       short M04_L16
M04_L15:
       mov       rcx,7FFD57835EBC
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,[rbp-0A0]
       mov       rdx,[rax+8]
       mov       rcx,[rbp+48]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M04_L16:
       xor       eax,eax
       mov       [rbp-0AC],eax
       jmp       near ptr M04_L26
M04_L17:
       mov       rax,[rbp-0A0]
       mov       [rbp-90],rax
       mov       rcx,7FFD57835EC0
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,[rbp-0A0]
       mov       rax,[rax+10]
       mov       [rbp-0A0],rax
M04_L18:
       mov       eax,[rbp-0E0]
       dec       eax
       mov       [rbp-0E0],eax
       cmp       dword ptr [rbp-0E0],0
       jg        short M04_L19
       lea       rcx,[rbp-0E0]
       mov       edx,148
       call      CORINFO_HELP_PATCHPOINT
M04_L19:
       cmp       qword ptr [rbp-0A0],0
       jne       near ptr M04_L10
       mov       rax,[rbp+10]
       mov       rax,[rax]
       mov       [rbp-148],rax
       mov       rax,[rbp-148]
       mov       rax,[rax+30]
       mov       rax,[rax]
       mov       rax,[rax+50]
       mov       [rbp-150],rax
       cmp       qword ptr [rbp-150],0
       je        short M04_L22
       mov       rax,[rbp-150]
       mov       [rbp-0D0],rax
       jmp       short M04_L23
M04_L20:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M04_L21:
       call      CORINFO_HELP_OVERFLOW
       int       3
M04_L22:
       mov       rcx,[rbp-148]
       mov       rdx,7FFD5787F820
       call      qword ptr [7FFD5719C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       [rbp-0D0],rax
M04_L23:
       mov       rcx,[rbp-0D0]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-0C8],rax
       mov       rax,[rbp+20]
       vmovdqu   xmm0,xmmword ptr [rax]
       vmovdqu   xmmword ptr [rbp-120],xmm0
       mov       rax,[rbp-68]
       mov       rax,[rax]
       mov       [rsp+20],rax
       lea       rdx,[rbp-120]
       mov       rcx,[rbp-0C8]
       mov       r8,[rbp+30]
       mov       r9d,[rbp-4C]
       call      qword ptr [7FFD577CEC10]; System.Collections.Concurrent.ConcurrentDictionary`2+Node[[System.ValueTuple`2[[System.__Canon, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.ValueTuple`2<System.__Canon,Boolean>, System.__Canon, Int32, Node<System.ValueTuple`2<System.__Canon,Boolean>,System.__Canon>)
       mov       rax,[rbp-0C8]
       mov       [rbp-98],rax
       mov       rcx,[rbp-68]
       mov       rdx,[rbp-98]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,[rbp+18]
       mov       rax,[rax+20]
       mov       ecx,[rbp-70]
       cmp       ecx,[rax+8]
       jae       near ptr M04_L20
       mov       edx,ecx
       lea       rax,[rax+rdx*4+10]
       mov       [rbp-0D8],rax
       mov       rax,[rbp-0D8]
       mov       eax,[rax]
       add       eax,1
       jo        near ptr M04_L21
       mov       rcx,[rbp-0D8]
       mov       [rcx],eax
       mov       rax,[rbp+18]
       mov       rax,[rax+20]
       mov       ecx,[rbp-70]
       cmp       ecx,[rax+8]
       jae       near ptr M04_L20
       mov       edx,ecx
       lea       rax,[rax+rdx*4+10]
       mov       eax,[rax]
       mov       rcx,[rbp+10]
       cmp       eax,[rcx+10]
       jle       short M04_L24
       mov       rcx,7FFD57835EC4
       call      CORINFO_HELP_COUNTPROFILE32
       mov       dword ptr [rbp-74],1
M04_L24:
       call      M04_L30
       jmp       short M04_L27
M04_L25:
       call      M04_L30
       jmp       near ptr M04_L03
M04_L26:
       call      M04_L30
       jmp       short M04_L29
M04_L27:
       mov       eax,[rbp-74]
       or        eax,[rbp-78]
       test      eax,eax
       je        short M04_L28
       mov       rcx,7FFD57835ED0
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp+10]
       mov       rdx,[rbp+18]
       mov       r8d,[rbp-74]
       mov       r9d,[rbp-78]
       call      qword ptr [7FFD577CEC28]
M04_L28:
       mov       rcx,7FFD57835ED4
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp+48]
       mov       rdx,[rbp+30]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       eax,1
       add       rsp,180
       pop       rbp
       ret
M04_L29:
       mov       rcx,7FFD57835ED8
       call      CORINFO_HELP_COUNTPROFILE32
       mov       eax,[rbp-0AC]
       add       rsp,180
       pop       rbp
       ret
M04_L30:
       sub       rsp,28
       movzx     eax,byte ptr [rbp-80]
       test      eax,eax
       je        short M04_L31
       mov       rcx,7FFD57835EC8
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,[rbp-60]
       mov       ecx,[rbp-70]
       cmp       ecx,[rax+8]
       jae       short M04_L32
       mov       edx,ecx
       lea       rax,[rax+rdx*8+10]
       mov       rcx,[rax]
       call      qword ptr [7FFD57196820]; System.Threading.Monitor.Exit(System.Object)
M04_L31:
       mov       rcx,7FFD57835ECC
       call      CORINFO_HELP_COUNTPROFILE32
       nop
       add       rsp,28
       ret
M04_L32:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1567
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.EnumHelperBenchmark.GetItems_FixNamesTrue()
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
       vmovdqu   ymmword ptr [rbp-80],ymm4
       vmovdqu   ymmword ptr [rbp-60],ymm4
       xor       eax,eax
       mov       [rbp-40],rax
       mov       rbx,rcx
       mov       rcx,1BE9EC021B0
       mov       rsi,[rcx]
       mov       rcx,1BE9EC021A0
       mov       rdi,[rcx]
       test      rsi,rsi
       je        near ptr M00_L09
M00_L00:
       mov       r14,[rdi+8]
       mov       rcx,[r14+8]
       mov       rax,1FF33B80B70
       mov       [rbp-50],rax
       mov       byte ptr [rbp-48],1
       test      rcx,rcx
       jne       near ptr M00_L10
       xor       ecx,ecx
       mov       [rbp-58],rcx
       lea       rcx,[rbp-50]
       cmp       qword ptr [rbp-58],0
       jne       short M00_L01
       mov       rcx,[rbp-50]
       mov       [rbp-58],rcx
       lea       rcx,[rbp-58]
       cmp       qword ptr [rbp-58],0
       je        near ptr M00_L11
M00_L01:
       mov       r15,[rcx]
       mov       rcx,offset MT_System.RuntimeType
       cmp       [r15],rcx
       jne       near ptr M00_L12
       mov       rcx,r15
       call      00007FFDB6DC3FE0
       test      eax,eax
       je        near ptr M00_L08
M00_L02:
       mov       r15d,eax
M00_L03:
       imul      edx,r15d,0C2B2AE3D
       add       edx,741C3EC4
       rol       edx,11
       imul      edx,27D4EB2F
       cmp       byte ptr [rbp-48],0
       setne     cl
       movzx     ecx,cl
       imul      ecx,0C2B2AE3D
       add       edx,ecx
       rol       edx,11
       imul      edx,27D4EB2F
       mov       ecx,edx
       shr       ecx,0F
       xor       ecx,edx
       imul      edx,ecx,85EBCA77
       mov       ecx,edx
       shr       ecx,0D
       xor       ecx,edx
       imul      edx,ecx,0C2B2AE3D
       mov       r15d,edx
       shr       r15d,10
       xor       r15d,edx
       xor       edx,edx
       mov       [rbp-58],rdx
M00_L04:
       mov       r13,[r14+8]
       test      r13,r13
       jne       near ptr M00_L16
       mov       rcx,[r14+10]
       mov       edx,r15d
       imul      rdx,[r14+28]
       shr       rdx,20
       inc       rdx
       mov       r13d,[rcx+8]
       mov       eax,r13d
       imul      rdx,rax
       shr       rdx,20
       cmp       edx,r13d
       jae       near ptr M00_L20
       mov       edx,edx
       mov       r13,[rcx+rdx*8+10]
       test      r13,r13
       je        near ptr M00_L15
M00_L05:
       cmp       r15d,[r13+18]
       jne       near ptr M00_L14
       mov       rcx,[r13+20]
       movzx     r12d,byte ptr [r13+28]
       test      rcx,rcx
       je        near ptr M00_L14
       mov       rdx,offset MT_System.RuntimeType
       cmp       [rcx],rdx
       jne       near ptr M00_L13
       mov       rdx,1FF33B80B70
       cmp       rcx,rdx
       sete      al
       movzx     eax,al
M00_L06:
       test      eax,eax
       je        near ptr M00_L14
       cmp       r12d,1
       jne       near ptr M00_L14
       mov       r8,[r13+8]
       mov       [rbp-40],r8
M00_L07:
       mov       rcx,[rbp-40]
       xor       edx,edx
       mov       [rbp-40],rdx
       mov       [rbp-60],rcx
       mov       rbx,[rbx+90]
       mov       rdx,[rbp-60]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
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
M00_L08:
       mov       rcx,r15
       call      qword ptr [7FFD571BE970]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       jmp       near ptr M00_L02
M00_L09:
       mov       rcx,offset MT_System.Func<System.ValueTuple<System.Type, System.Boolean>, System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Core.EnumValue>>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,1BE9EC021A8
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Core.EnumHelper+<>c__6`1[[System.Net.Cache.RequestCacheLevel, System.Net.Primitives]].<GetItems>b__6_0(System.ValueTuple`2<System.Type,Boolean>)
       call      qword ptr [7FFD571B6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1BE9EC021B0
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L10:
       vmovdqu   xmm0,xmmword ptr [rbp-50]
       vmovdqu   xmmword ptr [rbp-70],xmm0
       lea       rdx,[rbp-70]
       mov       r11,7FFD57100A40
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       near ptr M00_L04
M00_L11:
       xor       r15d,r15d
       jmp       near ptr M00_L03
M00_L12:
       mov       rcx,r15
       mov       rax,[r15]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
       mov       r15d,eax
       jmp       near ptr M00_L03
M00_L13:
       mov       rdx,1FF33B80B70
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       jmp       near ptr M00_L06
M00_L14:
       mov       r13,[r13+10]
       test      r13,r13
       jne       near ptr M00_L05
M00_L15:
       xor       edx,edx
       mov       [rbp-40],rdx
       mov       rdx,1FF33B80B70
       mov       [rbp-70],rdx
       mov       byte ptr [rbp-68],1
       mov       [rbp-80],rdx
       mov       byte ptr [rbp-78],1
       lea       rdx,[rbp-80]
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       xor       r8d,r8d
       mov       [rsp+28],r8d
       mov       dword ptr [rsp+30],1
       lea       r8,[rbp-40]
       mov       [rsp+38],r8
       mov       [rsp+20],rax
       lea       r8,[rbp-70]
       mov       r9d,r15d
       shl       r9,20
       or        r9,1
       mov       rdx,r14
       mov       rcx,rdi
       call      qword ptr [7FFD577EE748]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.ValueTuple`2[[System.__Canon, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryAddInternal(Tables<System.ValueTuple`2<System.__Canon,Boolean>,System.__Canon>, System.ValueTuple`2<System.__Canon,Boolean>, System.Nullable`1<Int32>, System.__Canon, Boolean, Boolean, System.__Canon ByRef)
       jmp       near ptr M00_L07
M00_L16:
       mov       r8,[r14+10]
       mov       edx,r15d
       imul      rdx,[r14+28]
       shr       rdx,20
       inc       rdx
       mov       ecx,[r8+8]
       mov       r11d,ecx
       imul      rdx,r11
       shr       rdx,20
       cmp       edx,ecx
       jae       short M00_L20
       mov       edx,edx
       mov       r12,[r8+rdx*8+10]
       test      r12,r12
       je        near ptr M00_L15
M00_L17:
       cmp       r15d,[r12+18]
       jne       short M00_L18
       vmovdqu   xmm0,xmmword ptr [r12+20]
       vmovdqu   xmmword ptr [rbp-70],xmm0
       mov       r8,1FF33B80B70
       mov       [rbp-80],r8
       mov       byte ptr [rbp-78],1
       lea       r8,[rbp-80]
       lea       rdx,[rbp-70]
       mov       rcx,r13
       mov       r11,7FFD57100A48
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L19
M00_L18:
       mov       r12,[r12+10]
       test      r12,r12
       jne       short M00_L17
       jmp       near ptr M00_L15
M00_L19:
       mov       rdx,[r12+8]
       mov       [rbp-40],rdx
       jmp       near ptr M00_L07
M00_L20:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 964
```
```assembly
; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
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
       mov       [rbp+10],rcx
       cmp       qword ptr [rbp+10],0
       je        short M01_L01
       lea       rcx,[rbp+10]
       mov       [rbp-98],rcx
       lea       rcx,[rbp-90]
       call      qword ptr [7FFD9C999030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-98]
       call      qword ptr [rax]
       mov       ebx,eax
       lea       rcx,[rbp-90]
       call      qword ptr [7FFD9C999038]; CORINFO_HELP_JIT_PINVOKE_END
       mov       eax,ebx
M01_L00:
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
M01_L01:
       xor       eax,eax
       jmp       short M01_L00
; Total bytes of code 119
```
```assembly
; DotNetTips.Spargine.Core.EnumHelper+<>c__6`1[[System.Net.Cache.RequestCacheLevel, System.Net.Primitives]].<GetItems>b__6_0(System.ValueTuple`2<System.Type,Boolean>)
       push      rbp
       sub       rsp,0D0
       lea       rbp,[rsp+0D0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-0B0],ymm4
       vmovdqu   ymmword ptr [rbp-90],ymm4
       vmovdqu   ymmword ptr [rbp-70],ymm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       xor       eax,eax
       mov       [rbp-40],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       dword ptr [rbp-98],3E8
; 			var (cachedEnumType, cachedFixNames) = key;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rax,[rbp+18]
       mov       rax,[rax]
       mov       [rbp-40],rax
       mov       rax,[rbp+18]
       movzx     eax,byte ptr [rax+8]
       mov       [rbp-44],eax
; 			var enumValues = (T[])Enum.GetValues(cachedEnumType);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,[rbp-40]
       call      qword ptr [7FFD577EE8B0]; System.Enum.GetValues(System.Type)
       mov       [rbp-90],rax
       mov       rcx,[rbp-90]
       mov       rdx,7FFD57853770
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rax,[rbp-90]
       mov       [rbp-0A0],rax
       mov       rdx,[rbp-0A0]
       mov       rcx,offset MT_System.Net.Cache.RequestCacheLevel[]
       call      qword ptr [7FFD571B58D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       [rbp-50],rax
; 			var length = enumValues.Length;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rax,[rbp-50]
       mov       eax,[rax+8]
       mov       [rbp-54],eax
; 			var result = new EnumValue[length];
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       movsxd    rdx,dword ptr [rbp-54]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.EnumValue[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       [rbp-60],rax
; 			var enumNames = GetNames(cachedEnumType, cachedFixNames);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,[rbp-40]
       mov       edx,[rbp-44]
       call      qword ptr [7FFD577EE8C8]; DotNetTips.Spargine.Core.EnumHelper.GetNames(System.Type, Boolean)
       mov       [rbp-68],rax
; 			for (var valueIndex = 0; valueIndex < length; valueIndex++)
; 			     ^^^^^^^^^^^^^^^^^^
       xor       eax,eax
       mov       [rbp-6C],eax
       jmp       near ptr M02_L01
M02_L00:
       mov       rcx,7FFD57853878
       call      CORINFO_HELP_COUNTPROFILE32
; 				var value = Convert.ToInt32(enumValues[valueIndex], CultureInfo.InvariantCulture);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,offset MT_System.Net.Cache.RequestCacheLevel
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-80],rax
       mov       rax,[rbp-50]
       mov       ecx,[rbp-6C]
       cmp       ecx,[rax+8]
       jae       near ptr M02_L03
       mov       edx,ecx
       lea       rax,[rax+rdx*4+10]
       mov       eax,[rax]
       mov       rcx,[rbp-80]
       mov       [rcx+8],eax
       call      qword ptr [7FFD577E5200]; System.Globalization.CultureInfo.get_InvariantCulture()
       mov       [rbp-0A8],rax
       mov       rdx,[rbp-0A8]
       mov       rcx,[rbp-80]
       call      qword ptr [7FFD577EE8E0]; System.Convert.ToInt32(System.Object, System.IFormatProvider)
       mov       [rbp-78],eax
; 				result[valueIndex] = new EnumValue(value, enumNames[valueIndex]);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,offset MT_DotNetTips.Spargine.Core.EnumValue
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-88],rax
       mov       rcx,[rbp-68]
       mov       edx,[rbp-6C]
       cmp       [rcx],ecx
       call      qword ptr [7FFD572A3578]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Item(Int32)
       mov       [rbp-0B0],rax
       mov       r8,[rbp-0B0]
       lea       rdx,[rbp-78]
       mov       rcx,[rbp-88]
       call      qword ptr [7FFD577EE8F8]; DotNetTips.Spargine.Core.EnumValue..ctor(Int32 ByRef, System.String)
       movsxd    rdx,dword ptr [rbp-6C]
       mov       rcx,[rbp-60]
       mov       r8,[rbp-88]
       call      qword ptr [7FFD571B57B8]; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       eax,[rbp-6C]
       add       eax,1
       jo        short M02_L04
       mov       [rbp-6C],eax
M02_L01:
       mov       eax,[rbp-98]
       dec       eax
       mov       [rbp-98],eax
       cmp       dword ptr [rbp-98],0
       jg        short M02_L02
       lea       rcx,[rbp-98]
       mov       edx,68
       call      CORINFO_HELP_PATCHPOINT
M02_L02:
       mov       eax,[rbp-6C]
       cmp       eax,[rbp-54]
       jl        near ptr M02_L00
       mov       rcx,7FFD5785387C
       call      CORINFO_HELP_COUNTPROFILE32
; 			return Array.AsReadOnly(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rdx,[rbp-60]
       mov       rcx,7FFD578536E8
       call      qword ptr [7FFD576DD2A8]; System.Array.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       nop
       add       rsp,0D0
       pop       rbp
       ret
M02_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M02_L04:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 540
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M03_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M03_L00:
       call      qword ptr [7FFD578C67F0]
       int       3
; Total bytes of code 44
```
```assembly
; System.Collections.Concurrent.ConcurrentDictionary`2[[System.ValueTuple`2[[System.__Canon, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryAddInternal(Tables<System.ValueTuple`2<System.__Canon,Boolean>,System.__Canon>, System.ValueTuple`2<System.__Canon,Boolean>, System.Nullable`1<Int32>, System.__Canon, Boolean, Boolean, System.__Canon ByRef)
       push      rbp
       sub       rsp,180
       lea       rbp,[rsp+180]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-120],xmm4
       vmovdqa   xmmword ptr [rbp-110],xmm4
       mov       rax,0FFFFFFFFFFFFFF40
M04_L00:
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       vmovdqa   xmmword ptr [rbp+rax-20],xmm4
       add       rax,30
       jne       short M04_L00
       mov       [rbp-40],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9
       mov       dword ptr [rbp-0E0],3E8
       mov       rax,[rbp+18]
       mov       rax,[rax+8]
       mov       [rbp-48],rax
       mov       rax,[rbp+28]
       mov       [rbp-58],rax
       lea       rcx,[rbp-58]
       call      qword ptr [7FFD576D71C8]; System.Nullable`1[[System.Int32, System.Private.CoreLib]].get_HasValue()
       test      eax,eax
       jne       short M04_L01
       mov       rax,[rbp+20]
       vmovdqu   xmm0,xmmword ptr [rax]
       vmovdqu   xmmword ptr [rbp-0F0],xmm0
       lea       r8,[rbp-0F0]
       mov       rdx,[rbp-48]
       mov       rcx,[rbp+10]
       call      qword ptr [7FFD577EE718]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.ValueTuple`2[[System.__Canon, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GetHashCode(System.Collections.Generic.IEqualityComparer`1<System.ValueTuple`2<System.__Canon,Boolean>>, System.ValueTuple`2<System.__Canon,Boolean>)
       mov       [rbp-0B0],eax
       jmp       short M04_L02
M04_L01:
       mov       rcx,7FFD5785FC70
       call      CORINFO_HELP_COUNTPROFILE32
       lea       rcx,[rbp-58]
       call      qword ptr [7FFD576D71E0]; System.Nullable`1[[System.Int32, System.Private.CoreLib]].GetValueOrDefault()
       mov       [rbp-0B0],eax
M04_L02:
       mov       eax,[rbp-0B0]
       mov       [rbp-4C],eax
M04_L03:
       mov       eax,[rbp-0E0]
       dec       eax
       mov       [rbp-0E0],eax
       cmp       dword ptr [rbp-0E0],0
       jg        short M04_L04
       lea       rcx,[rbp-0E0]
       mov       edx,24
       call      CORINFO_HELP_PATCHPOINT
M04_L04:
       mov       rax,[rbp+18]
       mov       rax,[rax+18]
       mov       [rbp-60],rax
       mov       rax,[rbp+10]
       mov       rax,[rax]
       mov       [rbp-128],rax
       mov       rax,[rbp-128]
       mov       rax,[rax+30]
       mov       rax,[rax]
       mov       rax,[rax+18]
       mov       [rbp-130],rax
       cmp       qword ptr [rbp-130],0
       je        short M04_L05
       mov       rax,[rbp-130]
       mov       [rbp-0B8],rax
       jmp       short M04_L06
M04_L05:
       mov       rcx,[rbp-128]
       mov       rdx,7FFD57839AA0
       call      qword ptr [7FFD571BC5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       [rbp-0B8],rax
M04_L06:
       lea       r9,[rbp-70]
       mov       rcx,[rbp-0B8]
       mov       rdx,[rbp+18]
       mov       r8d,[rbp-4C]
       call      qword ptr [7FFD577EF948]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.ValueTuple`2[[System.__Canon, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GetBucketAndLock(Tables<System.ValueTuple`2<System.__Canon,Boolean>,System.__Canon>, Int32, UInt32 ByRef)
       mov       [rbp-68],rax
       xor       eax,eax
       mov       [rbp-74],eax
       xor       eax,eax
       mov       [rbp-78],eax
       xor       eax,eax
       mov       [rbp-80],eax
       movzx     eax,byte ptr [rbp+40]
       test      eax,eax
       je        short M04_L07
       mov       rcx,7FFD5785FC74
       call      CORINFO_HELP_COUNTPROFILE32
       lea       rdx,[rbp-80]
       mov       rax,[rbp-60]
       mov       ecx,[rbp-70]
       cmp       ecx,[rax+8]
       jae       near ptr M04_L20
       mov       r8d,ecx
       lea       rax,[rax+r8*8+10]
       mov       rcx,[rax]
       call      qword ptr [7FFD571B5998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
M04_L07:
       mov       rax,[rbp+10]
       mov       rax,[rax+8]
       cmp       rax,[rbp+18]
       je        short M04_L09
       mov       rax,[rbp+10]
       mov       rax,[rax+8]
       mov       [rbp+18],rax
       mov       rax,[rbp+18]
       mov       rax,[rax+8]
       cmp       rax,[rbp-48]
       je        short M04_L08
       mov       rcx,7FFD5785FC78
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,[rbp+18]
       mov       rax,[rax+8]
       mov       [rbp-48],rax
       mov       rax,[rbp+20]
       vmovdqu   xmm0,xmmword ptr [rax]
       vmovdqu   xmmword ptr [rbp-100],xmm0
       lea       r8,[rbp-100]
       mov       rdx,[rbp-48]
       mov       rcx,[rbp+10]
       call      qword ptr [7FFD577EE718]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.ValueTuple`2[[System.__Canon, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GetHashCode(System.Collections.Generic.IEqualityComparer`1<System.ValueTuple`2<System.__Canon,Boolean>>, System.ValueTuple`2<System.__Canon,Boolean>)
       mov       [rbp-4C],eax
M04_L08:
       mov       rcx,7FFD5785FC7C
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M04_L25
M04_L09:
       xor       eax,eax
       mov       [rbp-84],eax
       xor       eax,eax
       mov       [rbp-90],rax
       mov       rax,[rbp-68]
       mov       rax,[rax]
       mov       [rbp-0A0],rax
       jmp       near ptr M04_L18
M04_L10:
       mov       rax,[rbp-0A0]
       mov       eax,[rax+18]
       cmp       eax,[rbp-4C]
       jne       near ptr M04_L17
       mov       rax,[rbp+10]
       mov       rax,[rax]
       mov       [rbp-138],rax
       mov       rax,[rbp-138]
       mov       rax,[rax+30]
       mov       rax,[rax]
       mov       rax,[rax+18]
       mov       [rbp-140],rax
       cmp       qword ptr [rbp-140],0
       je        short M04_L11
       mov       rax,[rbp-140]
       mov       [rbp-0C0],rax
       jmp       short M04_L12
M04_L11:
       mov       rcx,[rbp-138]
       mov       rdx,7FFD57839AA0
       call      qword ptr [7FFD571BC5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       [rbp-0C0],rax
M04_L12:
       mov       rax,[rbp+20]
       vmovdqu   xmm0,xmmword ptr [rax]
       vmovdqu   xmmword ptr [rbp-110],xmm0
       lea       r9,[rbp-110]
       mov       rdx,[rbp-48]
       mov       r8,[rbp-0A0]
       mov       rcx,[rbp-0C0]
       call      qword ptr [7FFD577EF960]
       test      eax,eax
       je        short M04_L13
       movzx     eax,byte ptr [rbp+38]
       test      eax,eax
       je        short M04_L15
       jmp       short M04_L14
M04_L13:
       mov       rcx,7FFD5785FC80
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M04_L17
M04_L14:
       mov       rax,[rbp-0A0]
       lea       rcx,[rax+8]
       mov       rdx,[rbp+30]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+48]
       mov       rdx,[rbp+30]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       short M04_L16
M04_L15:
       mov       rcx,7FFD5785FC84
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,[rbp-0A0]
       mov       rdx,[rax+8]
       mov       rcx,[rbp+48]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M04_L16:
       xor       eax,eax
       mov       [rbp-0AC],eax
       jmp       near ptr M04_L26
M04_L17:
       mov       rax,[rbp-0A0]
       mov       [rbp-90],rax
       mov       rcx,7FFD5785FC88
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,[rbp-0A0]
       mov       rax,[rax+10]
       mov       [rbp-0A0],rax
M04_L18:
       mov       eax,[rbp-0E0]
       dec       eax
       mov       [rbp-0E0],eax
       cmp       dword ptr [rbp-0E0],0
       jg        short M04_L19
       lea       rcx,[rbp-0E0]
       mov       edx,148
       call      CORINFO_HELP_PATCHPOINT
M04_L19:
       cmp       qword ptr [rbp-0A0],0
       jne       near ptr M04_L10
       mov       rax,[rbp+10]
       mov       rax,[rax]
       mov       [rbp-148],rax
       mov       rax,[rbp-148]
       mov       rax,[rax+30]
       mov       rax,[rax]
       mov       rax,[rax+50]
       mov       [rbp-150],rax
       cmp       qword ptr [rbp-150],0
       je        short M04_L22
       mov       rax,[rbp-150]
       mov       [rbp-0D0],rax
       jmp       short M04_L23
M04_L20:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M04_L21:
       call      CORINFO_HELP_OVERFLOW
       int       3
M04_L22:
       mov       rcx,[rbp-148]
       mov       rdx,7FFD578AB980
       call      qword ptr [7FFD571BC5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       [rbp-0D0],rax
M04_L23:
       mov       rcx,[rbp-0D0]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-0C8],rax
       mov       rax,[rbp+20]
       vmovdqu   xmm0,xmmword ptr [rax]
       vmovdqu   xmmword ptr [rbp-120],xmm0
       mov       rax,[rbp-68]
       mov       rax,[rax]
       mov       [rsp+20],rax
       lea       rdx,[rbp-120]
       mov       rcx,[rbp-0C8]
       mov       r8,[rbp+30]
       mov       r9d,[rbp-4C]
       call      qword ptr [7FFD577EF978]; System.Collections.Concurrent.ConcurrentDictionary`2+Node[[System.ValueTuple`2[[System.__Canon, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.ValueTuple`2<System.__Canon,Boolean>, System.__Canon, Int32, Node<System.ValueTuple`2<System.__Canon,Boolean>,System.__Canon>)
       mov       rax,[rbp-0C8]
       mov       [rbp-98],rax
       mov       rcx,[rbp-68]
       mov       rdx,[rbp-98]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,[rbp+18]
       mov       rax,[rax+20]
       mov       ecx,[rbp-70]
       cmp       ecx,[rax+8]
       jae       near ptr M04_L20
       mov       edx,ecx
       lea       rax,[rax+rdx*4+10]
       mov       [rbp-0D8],rax
       mov       rax,[rbp-0D8]
       mov       eax,[rax]
       add       eax,1
       jo        near ptr M04_L21
       mov       rcx,[rbp-0D8]
       mov       [rcx],eax
       mov       rax,[rbp+18]
       mov       rax,[rax+20]
       mov       ecx,[rbp-70]
       cmp       ecx,[rax+8]
       jae       near ptr M04_L20
       mov       edx,ecx
       lea       rax,[rax+rdx*4+10]
       mov       eax,[rax]
       mov       rcx,[rbp+10]
       cmp       eax,[rcx+10]
       jle       short M04_L24
       mov       rcx,7FFD5785FC8C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       dword ptr [rbp-74],1
M04_L24:
       call      M04_L30
       jmp       short M04_L27
M04_L25:
       call      M04_L30
       jmp       near ptr M04_L03
M04_L26:
       call      M04_L30
       jmp       short M04_L29
M04_L27:
       mov       eax,[rbp-74]
       or        eax,[rbp-78]
       test      eax,eax
       je        short M04_L28
       mov       rcx,7FFD5785FC98
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp+10]
       mov       rdx,[rbp+18]
       mov       r8d,[rbp-74]
       mov       r9d,[rbp-78]
       call      qword ptr [7FFD577EF990]
M04_L28:
       mov       rcx,7FFD5785FC9C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp+48]
       mov       rdx,[rbp+30]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       eax,1
       add       rsp,180
       pop       rbp
       ret
M04_L29:
       mov       rcx,7FFD5785FCA0
       call      CORINFO_HELP_COUNTPROFILE32
       mov       eax,[rbp-0AC]
       add       rsp,180
       pop       rbp
       ret
M04_L30:
       sub       rsp,28
       movzx     eax,byte ptr [rbp-80]
       test      eax,eax
       je        short M04_L31
       mov       rcx,7FFD5785FC90
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,[rbp-60]
       mov       ecx,[rbp-70]
       cmp       ecx,[rax+8]
       jae       short M04_L32
       mov       edx,ecx
       lea       rax,[rax+rdx*8+10]
       mov       rcx,[rax]
       call      qword ptr [7FFD571B6820]; System.Threading.Monitor.Exit(System.Object)
M04_L31:
       mov       rcx,7FFD5785FC94
       call      CORINFO_HELP_COUNTPROFILE32
       nop
       add       rsp,28
       ret
M04_L32:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1567
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.EnumHelperBenchmark.FlagCount()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,offset MT_System.AttributeTargets
       call      CORINFO_HELP_NEWSFAST
       mov       rcx,rax
       mov       dword ptr [rcx+8],1C4
       call      qword ptr [7FFD577CE598]; System.Enum.GetValue()
       test      rax,rax
       jne       short M00_L00
       xor       esi,esi
       jmp       short M00_L01
M00_L00:
       mov       rdx,rax
       mov       rcx,offset MT_System.IConvertible
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastInterface(Void*, System.Object)
       mov       rcx,rax
       mov       r11,7FFD570E0A00
       xor       edx,edx
       call      qword ptr [r11]
       mov       rsi,rax
M00_L01:
       xor       eax,eax
       popcnt    rax,rsi
       mov       rcx,[rbx+90]
       mov       [rcx+38],eax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 112
```
```assembly
; System.Enum.GetValue()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
M01_L00:
       lea       rsi,[rbx+8]
       mov       rcx,[rbx]
       call      00007FFDB6E01A90
       add       eax,0FFFFFFFE
       cmp       eax,6
       jne       short M01_L02
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       ecx,[rsi]
       mov       [rax+8],ecx
M01_L01:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L02:
       cmp       eax,17
       ja        short M01_L03
       mov       ecx,eax
       lea       rax,[7FFD57249F90]
       mov       eax,[rax+rcx*4]
       lea       rdx,[M01_L00]
       add       rax,rdx
       jmp       rax
M01_L03:
       call      qword ptr [7FFD57855728]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
       mov       rcx,offset MT_System.SByte
       call      CORINFO_HELP_NEWSFAST
       movsx     rcx,byte ptr [rsi]
       mov       [rax+8],cl
       jmp       short M01_L01
       mov       rcx,offset MT_System.Byte
       call      CORINFO_HELP_NEWSFAST
       movzx     ecx,byte ptr [rsi]
       mov       [rax+8],cl
       jmp       short M01_L01
       mov       rcx,offset MT_System.Int16
       call      CORINFO_HELP_NEWSFAST
       movsx     rcx,word ptr [rsi]
       mov       [rax+8],cx
       jmp       short M01_L01
       mov       rcx,offset MT_System.UInt16
       call      CORINFO_HELP_NEWSFAST
       movzx     ecx,word ptr [rsi]
       mov       [rax+8],cx
       jmp       near ptr M01_L01
       mov       rcx,offset MT_System.UInt32
       call      CORINFO_HELP_NEWSFAST
       mov       ecx,[rsi]
       mov       [rax+8],ecx
       jmp       near ptr M01_L01
       mov       rcx,offset MT_System.Int64
       call      CORINFO_HELP_NEWSFAST
       mov       rcx,[rsi]
       mov       [rax+8],rcx
       jmp       near ptr M01_L01
       mov       rcx,offset MT_System.UInt64
       call      CORINFO_HELP_NEWSFAST
       mov       rcx,[rsi]
       mov       [rax+8],rcx
       jmp       near ptr M01_L01
       mov       rcx,offset MT_System.Single
       call      CORINFO_HELP_NEWSFAST
       vmovss    xmm0,dword ptr [rsi]
       vmovss    dword ptr [rax+8],xmm0
       jmp       near ptr M01_L01
       mov       rcx,offset MT_System.Double
       call      CORINFO_HELP_NEWSFAST
       vmovsd    xmm0,qword ptr [rsi]
       vmovsd    qword ptr [rax+8],xmm0
       jmp       near ptr M01_L01
       mov       rcx,offset MT_System.IntPtr
       call      CORINFO_HELP_NEWSFAST
       mov       rcx,[rsi]
       mov       [rax+8],rcx
       jmp       near ptr M01_L01
       mov       rcx,offset MT_System.UIntPtr
       call      CORINFO_HELP_NEWSFAST
       mov       rcx,[rsi]
       mov       [rax+8],rcx
       jmp       near ptr M01_L01
       mov       rcx,offset MT_System.Char
       call      CORINFO_HELP_NEWSFAST
       movzx     ecx,word ptr [rsi]
       mov       [rax+8],cx
       jmp       near ptr M01_L01
       mov       rcx,offset MT_System.Boolean
       call      CORINFO_HELP_NEWSFAST
       movzx     ecx,byte ptr [rsi]
       mov       [rax+8],cl
       jmp       near ptr M01_L01
; Total bytes of code 443
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.ChkCastInterface(Void*, System.Object)
       test      rdx,rdx
       je        short M02_L01
       mov       rax,[rdx]
       movzx     r8d,word ptr [rax+0E]
       test      r8,r8
       je        short M02_L05
       mov       rax,[rax+38]
       cmp       r8,4
       jl        short M02_L04
       cmp       [rax],rcx
       je        short M02_L01
M02_L00:
       cmp       [rax+8],rcx
       je        short M02_L01
       cmp       [rax+10],rcx
       je        short M02_L01
       cmp       [rax+18],rcx
       jne       short M02_L03
M02_L01:
       mov       rax,rdx
       ret
M02_L02:
       cmp       [rax],rcx
       je        short M02_L01
       jmp       short M02_L00
M02_L03:
       add       rax,20
       add       r8,0FFFFFFFFFFFFFFFC
       cmp       r8,4
       jge       short M02_L02
       test      r8,r8
       je        short M02_L05
M02_L04:
       cmp       [rax],rcx
       je        short M02_L01
       add       rax,8
       dec       r8
       test      r8,r8
       jg        short M02_L04
M02_L05:
       jmp       qword ptr [7FFD578550F8]
; Total bytes of code 104
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.EnumHelperBenchmark.GetDescription()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       dword ptr [rsp+34],6D
       mov       rcx,offset MT_System.RuntimeType+IGenericCacheEntry<System.Enum+EnumInfo<System.UInt32>>
       mov       rsi,24E84B30B70
       mov       rdx,rsi
       call      qword ptr [7FFD5788CFF0]; System.RuntimeType+IGenericCacheEntry`1[[System.__Canon, System.Private.CoreLib]].Find(System.RuntimeType)
       mov       rcx,rax
       test      rcx,rcx
       je        near ptr M00_L03
       cmp       qword ptr [rcx+10],0
       je        near ptr M00_L03
M00_L00:
       mov       edx,[rsp+34]
       call      qword ptr [7FFD577FE5C8]; System.Enum.GetNameInlined[[System.UInt32, System.Private.CoreLib]](EnumInfo`1<UInt32>, UInt32)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M00_L04
       mov       rdx,rdi
       mov       rcx,rsi
       mov       r8d,1C
       call      qword ptr [7FFD5710A490]; System.RuntimeType.GetField(System.String, System.Reflection.BindingFlags)
       mov       rsi,rax
       test      rsi,rsi
       je        near ptr M00_L05
       mov       rdx,rsi
       mov       rcx,7FFD5785DE10
       xor       r8d,r8d
       call      qword ptr [7FFD576E67A8]; System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.MemberInfo, Boolean)
       mov       rbp,rax
       test      rbp,rbp
       jne       near ptr M00_L06
M00_L01:
       mov       rdx,rsi
       mov       rcx,7FFD5785DE98
       xor       r8d,r8d
       call      qword ptr [7FFD576E67A8]; System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.MemberInfo, Boolean)
       mov       rbp,rax
       test      rbp,rbp
       je        short M00_L05
       mov       rcx,[rbp+8]
       call      qword ptr [7FFD573EE4F0]; System.String.IsNullOrEmpty(System.String)
       test      eax,eax
       jne       short M00_L05
       mov       rsi,[rbp+8]
M00_L02:
       mov       [rsp+28],rsi
       mov       rcx,[rbx+90]
       lea       r8,[rsp+28]
       mov       rdx,7FFD578609B0
       cmp       [rcx],ecx
       call      qword ptr [7FFD577FE730]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L03:
       mov       rcx,rsi
       mov       edx,1
       call      qword ptr [7FFD573EDF50]; System.Enum.<GetEnumInfo>g__InitializeEnumInfo|5_0[[System.UInt32, System.Private.CoreLib]](System.RuntimeType, Boolean)
       mov       rcx,rax
       jmp       near ptr M00_L00
M00_L04:
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Data.CountryName
       call      CORINFO_HELP_NEWSFAST
       mov       dword ptr [rax+8],6D
       mov       rcx,rax
       call      qword ptr [7FFD57106098]; System.Enum.ToString()
       mov       rsi,rax
       jmp       short M00_L02
M00_L05:
       mov       rsi,rdi
       jmp       short M00_L02
M00_L06:
       mov       rcx,rbp
       mov       rax,[rbp]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       rcx,rax
       call      qword ptr [7FFD573EE4F0]; System.String.IsNullOrEmpty(System.String)
       test      eax,eax
       jne       near ptr M00_L01
       mov       rcx,rbp
       mov       rax,[rbp]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       rsi,rax
       jmp       near ptr M00_L02
; Total bytes of code 373
```
```assembly
; System.RuntimeType+IGenericCacheEntry`1[[System.__Canon, System.Private.CoreLib]].Find(System.RuntimeType)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       rcx,[rdx+10]
       test      rcx,rcx
       je        short M01_L01
       mov       rax,[rcx]
       test      rax,rax
       je        short M01_L01
M01_L00:
       mov       rsi,[rax+80]
       test      rsi,rsi
       je        short M01_L05
       mov       rcx,[rbx+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx]
       mov       rdx,rsi
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
       test      rax,rax
       je        short M01_L02
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L01:
       mov       rcx,rdx
       call      qword ptr [7FFD571C7C30]; System.RuntimeType.InitializeCache()
       jmp       short M01_L00
M01_L02:
       mov       rdx,rsi
       mov       rcx,offset MT_System.RuntimeType+CompositeCacheEntry
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rsi,rax
       test      rsi,rsi
       je        short M01_L05
       mov       rcx,[rbx+30]
       mov       rcx,[rcx]
       mov       rax,[rcx+18]
       test      rax,rax
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rcx,rbx
       mov       rdx,7FFD572F0C98
       call      qword ptr [7FFD571CC5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
M01_L04:
       mov       rcx,rsi
       call      rax
       mov       rax,[rax]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L05:
       xor       eax,eax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 171
```
```assembly
; System.Enum.GetNameInlined[[System.UInt32, System.Private.CoreLib]](EnumInfo`1<UInt32>, UInt32)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       r8d,edx
       mov       rbx,[rcx+10]
       cmp       byte ptr [rcx+19],0
       je        short M02_L00
       mov       esi,[rbx+8]
       cmp       esi,r8d
       jbe       short M02_L05
       mov       eax,r8d
       mov       rax,[rbx+rax*8+10]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L00:
       mov       rcx,[rcx+8]
       test      rcx,rcx
       jne       short M02_L01
       xor       eax,eax
       xor       r10d,r10d
       jmp       short M02_L02
M02_L01:
       lea       rax,[rcx+10]
       mov       r10d,[rcx+8]
M02_L02:
       cmp       dword ptr [rcx+8],20
       jle       short M02_L03
       mov       rcx,rax
       mov       edx,r10d
       call      qword ptr [7FFD57886EB0]
       jmp       short M02_L04
M02_L03:
       mov       rcx,rax
       mov       edx,r8d
       mov       r8d,r10d
       call      qword ptr [7FFD578870C0]; System.SpanHelpers.NonPackedIndexOfValueType[[System.Int32, System.Private.CoreLib],[System.SpanHelpers+DontNegate`1[[System.Int32, System.Private.CoreLib]], System.Private.CoreLib]](Int32 ByRef, Int32, Int32)
M02_L04:
       mov       esi,[rbx+8]
       cmp       esi,eax
       jbe       short M02_L05
       mov       eax,eax
       mov       rax,[rbx+rax*8+10]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L05:
       xor       eax,eax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 131
```
```assembly
; System.RuntimeType.GetField(System.String, System.Reflection.BindingFlags)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rdi,rcx
       mov       rsi,rdx
       mov       ebx,r8d
       test      rsi,rsi
       je        near ptr M03_L14
       test      bl,1
       jne       near ptr M03_L15
       mov       ebp,1
M03_L00:
       mov       rcx,[rdi+10]
       test      rcx,rcx
       je        near ptr M03_L16
       mov       r14,[rcx]
       test      r14,r14
       je        near ptr M03_L16
M03_L01:
       mov       edi,ebp
       mov       r15,rsi
       cmp       [r14],r14b
       lea       r13,[r14+50]
       mov       r12,[r13]
       test      r12,r12
       je        near ptr M03_L17
M03_L02:
       mov       r14,r12
       cmp       [r14],r14b
       cmp       edi,1
       jne       near ptr M03_L18
       mov       rbp,[r14+20]
       test      rbp,rbp
       je        near ptr M03_L21
       test      r15,r15
       je        short M03_L03
       mov       rcx,r15
       call      qword ptr [7FFD571C66D0]; System.String.GetNonRandomizedHashCode()
       jmp       short M03_L04
M03_L03:
       movsx     rdx,byte ptr [0]
       mov       edx,[0]
       add       edx,edx
       movsx     rcx,byte ptr [0]
       xor       ecx,ecx
       mov       r8d,2D81957C
       mov       r9d,0E9E2C9F2
       call      qword ptr [7FFD575FD9B0]; System.Marvin.ComputeHash32(Byte ByRef, UInt32, UInt32, UInt32)
M03_L04:
       mov       edx,eax
       not       eax
       test      edx,edx
       cmovl     edx,eax
       mov       r12,[rbp+8]
       mov       esi,[r12+8]
       mov       eax,edx
       cdq
       idiv      esi
       mov       edi,edx
       cmp       edi,esi
       jae       near ptr M03_L31
       mov       r8d,edi
       mov       rcx,[r12+r8*8+10]
       test      rcx,rcx
       je        near ptr M03_L21
M03_L05:
       cmp       rcx,r15
       je        short M03_L06
       test      r15,r15
       je        near ptr M03_L20
       mov       r8d,[rcx+8]
       cmp       r8d,[r15+8]
       jne       near ptr M03_L20
       add       rcx,0C
       add       r8d,r8d
       lea       rdx,[r15+0C]
       call      qword ptr [7FFD571CFBB8]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       test      eax,eax
       je        near ptr M03_L20
M03_L06:
       mov       rcx,[rbp+10]
       cmp       edi,[rcx+8]
       jae       near ptr M03_L31
       mov       edx,edi
       mov       rsi,[rcx+rdx*8+10]
M03_L07:
       test      rsi,rsi
       je        near ptr M03_L22
M03_L08:
       xor       edi,edi
       xor       ebx,2
       xor       ebp,ebp
       mov       r14d,[rsi+8]
       mov       r15d,10
       inc       r14d
M03_L09:
       dec       r14d
       je        short M03_L12
       mov       r13,[rsi+r15]
       mov       ecx,[r13+18]
       mov       eax,ebx
       and       eax,ecx
       cmp       eax,ecx
       jne       short M03_L11
       test      rdi,rdi
       jne       near ptr M03_L27
M03_L10:
       mov       rdi,r13
M03_L11:
       add       r15,8
       jmp       short M03_L09
M03_L12:
       test      ebp,ebp
       jne       near ptr M03_L29
M03_L13:
       mov       rax,rdi
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
M03_L14:
       mov       ecx,3E7
       mov       rdx,7FFD57104000
       call      qword ptr [7FFD573E7798]
       mov       rcx,rax
       call      qword ptr [7FFD57884E40]
       int       3
M03_L15:
       mov       rcx,20E05C00070
       mov       rcx,[rcx]
       mov       rdx,rsi
       call      qword ptr [7FFD57885F38]
       mov       rsi,rax
       mov       ebp,2
       jmp       near ptr M03_L00
M03_L16:
       mov       rcx,rdi
       call      qword ptr [7FFD571C7C30]; System.RuntimeType.InitializeCache()
       mov       r14,rax
       jmp       near ptr M03_L01
M03_L17:
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache+MemberInfoCache<System.Reflection.RuntimeFieldInfo>
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       lea       rcx,[r12+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r13
       mov       rdx,r12
       xor       r8d,r8d
       call      00007FFDB6DF21C0
       mov       r14,rax
       test      r14,r14
       cmove     r14,r12
       mov       r12,r14
       jmp       near ptr M03_L02
M03_L18:
       cmp       ebp,2
       je        short M03_L23
       cmp       byte ptr [r12+18],0
       je        near ptr M03_L26
       jmp       near ptr M03_L25
M03_L19:
       cmp       edi,esi
       jae       near ptr M03_L31
       mov       ecx,edi
       mov       rcx,[r12+rcx*8+10]
       test      rcx,rcx
       je        short M03_L21
       jmp       near ptr M03_L05
M03_L20:
       inc       edi
       mov       esi,[r12+8]
       cmp       esi,edi
       jg        short M03_L19
       sub       edi,esi
       jmp       short M03_L19
M03_L21:
       xor       esi,esi
       jmp       near ptr M03_L07
M03_L22:
       mov       rcx,r14
       mov       rdx,r15
       mov       r8d,1
       mov       r9d,2
       call      qword ptr [7FFD571CD2C0]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
       mov       rsi,rax
       jmp       near ptr M03_L08
M03_L23:
       lea       rcx,[r12+28]
       mov       r8,rsi
       mov       rdx,offset MT_System.Reflection.CerHashtable<System.String, System.Reflection.RuntimeFieldInfo[]>
       call      qword ptr [7FFD571CF408]; System.Reflection.CerHashtable`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Item(System.__Canon)
       test      rax,rax
       jne       short M03_L24
       mov       rcx,r12
       mov       rdx,rsi
       mov       r8d,2
       mov       r9d,2
       call      qword ptr [7FFD571CD2C0]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
M03_L24:
       mov       rsi,rax
       jmp       near ptr M03_L08
M03_L25:
       mov       rsi,[r12+8]
       jmp       near ptr M03_L08
M03_L26:
       mov       rcx,r12
       mov       r8d,ebp
       xor       edx,edx
       mov       r9d,2
       call      qword ptr [7FFD571CD2C0]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
       mov       rsi,rax
       jmp       near ptr M03_L08
M03_L27:
       mov       rcx,r13
       mov       rax,[r13]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       r12,rax
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       cmp       r12,rax
       je        near ptr M03_L30
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFD571CED78]; System.Type.get_IsInterface()
       test      eax,eax
       je        short M03_L28
       mov       rcx,r13
       mov       rax,[r13]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFD571CED78]; System.Type.get_IsInterface()
       test      eax,eax
       je        short M03_L28
       mov       ebp,1
M03_L28:
       mov       rcx,r13
       mov       rax,[r13]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       r12,rax
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       rdx,rax
       mov       rcx,r12
       mov       rax,[r12]
       mov       rax,[rax+0B0]
       call      qword ptr [rax+18]
       test      eax,eax
       jne       near ptr M03_L10
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFD571CED78]; System.Type.get_IsInterface()
       test      eax,eax
       je        near ptr M03_L11
       jmp       near ptr M03_L10
M03_L29:
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFD571CED78]; System.Type.get_IsInterface()
       test      eax,eax
       je        near ptr M03_L13
M03_L30:
       mov       rcx,rdi
       call      qword ptr [7FFD57886220]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M03_L31:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1006
```
```assembly
; System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.MemberInfo, Boolean)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,78
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+40],ymm4
       vmovdqa   xmmword ptr [rsp+60],xmm4
       mov       [rsp+70],rcx
       mov       rbx,rdx
       mov       esi,r8d
       test      rbx,rbx
       je        near ptr M04_L23
       mov       rcx,[rcx+18]
       mov       rdi,[rcx]
       mov       rcx,rdi
       call      System.RuntimeTypeHandle.GetRuntimeTypeFromHandle(IntPtr)
       mov       rbp,rax
       mov       rcx,[rbp+18]
       test      cl,2
       jne       near ptr M04_L24
       mov       ecx,[rcx]
       and       ecx,0F0000
       cmp       ecx,0C0000
       sete      cl
       movzx     ecx,cl
M04_L00:
       test      ecx,ecx
       jne       near ptr M04_L25
       mov       rcx,rbp
       call      00007FFDB6DF8F60
       test      eax,eax
       jne       near ptr M04_L26
       mov       rcx,[rbp+18]
       test      cl,2
       jne       near ptr M04_L17
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        near ptr M04_L17
       mov       rax,[rcx+20]
       add       rax,10
       mov       rax,[rax]
       test      rax,rax
       je        near ptr M04_L32
M04_L01:
       mov       rcx,rax
M04_L02:
       test      rcx,rcx
       je        near ptr M04_L34
M04_L03:
       mov       rax,24E84B21A60
       cmp       rcx,rax
       jne       near ptr M04_L33
M04_L04:
       mov       rcx,offset MT_System.Reflection.MdFieldInfo
       cmp       [rbx],rcx
       jne       near ptr M04_L35
       mov       r14d,4
M04_L05:
       cmp       r14d,2
       je        near ptr M04_L37
       cmp       r14d,10
       je        near ptr M04_L36
       mov       rcx,offset MT_System.Reflection.MdFieldInfo
       cmp       [rbx],rcx
       jne       near ptr M04_L57
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+58],xmm0
       vmovdqu   xmmword ptr [rsp+60],xmm0
       mov       rcx,24E84B219B8
       cmp       rbp,rcx
       je        near ptr M04_L38
       mov       rcx,24E84B21A60
       cmp       rbp,rcx
       sete      sil
       movzx     esi,sil
M04_L06:
       test      esi,esi
       jne       near ptr M04_L44
       mov       rcx,20DEFC001C8
       mov       r14,[rcx]
       mov       rdx,rbp
       cmp       qword ptr [r14+8],0
       je        near ptr M04_L12
       mov       r15,[r14+10]
       xor       r13d,r13d
       mov       r12,[r14+18]
       mov       rcx,offset MT_System.Collections.Generic.ObjectEqualityComparer<System.RuntimeType>
       cmp       [r12],rcx
       jne       near ptr M04_L41
       mov       [rsp+48],rdx
       xor       ecx,ecx
       mov       [rsp+40],rcx
       lea       rcx,[rsp+48]
       cmp       qword ptr [rsp+40],0
       jne       short M04_L07
       mov       rcx,[rsp+48]
       mov       [rsp+40],rcx
       lea       rcx,[rsp+40]
       cmp       qword ptr [rsp+40],0
       je        near ptr M04_L39
M04_L07:
       mov       rax,[rcx]
       mov       [rsp+38],rax
       mov       rcx,offset MT_System.RuntimeType
       cmp       [rax],rcx
       jne       near ptr M04_L40
       mov       rcx,rax
       call      00007FFDB6DC3FE0
       test      eax,eax
       je        near ptr M04_L18
M04_L08:
       xor       ecx,ecx
       mov       [rsp+40],rcx
M04_L09:
       mov       [rsp+54],eax
       mov       rdx,[r14+8]
       mov       ecx,eax
       imul      rcx,[r14+20]
       shr       rcx,20
       inc       rcx
       mov       r8d,[rdx+8]
       imul      rcx,r8
       shr       rcx,20
       cmp       ecx,[rdx+8]
       jae       near ptr M04_L59
       mov       ecx,ecx
       lea       rdx,[rdx+rcx*4+10]
       mov       r10d,[rdx]
       dec       r10d
       js        short M04_L12
M04_L10:
       cmp       r10d,[r15+8]
       jae       near ptr M04_L59
       mov       edx,r10d
       shl       rdx,4
       lea       r14,[r15+rdx+10]
       cmp       [r14+8],eax
       je        near ptr M04_L42
M04_L11:
       mov       r10d,[r14+0C]
       inc       r13d
       cmp       [r15+8],r13d
       jb        near ptr M04_L43
       test      r10d,r10d
       mov       eax,[rsp+54]
       jge       short M04_L10
M04_L12:
       mov       rsi,[rbx+10]
       cmp       [rsi],sil
       mov       rcx,rsi
       call      00007FFDB6DF61E0
       mov       rcx,rax
       test      rcx,rcx
       je        near ptr M04_L51
M04_L13:
       mov       edx,[rbx+1C]
       mov       r8d,[rsp+68]
       mov       r9,rbp
       call      qword ptr [7FFD571CE9B8]; System.Reflection.CustomAttribute.GetCustomAttributes(System.Reflection.RuntimeModule, Int32, Int32, System.RuntimeType)
       mov       rbx,rax
       cmp       dword ptr [rsp+68],0
       jle       short M04_L14
       mov       r9d,[rbx+8]
       sub       r9d,[rsp+68]
       cmp       dword ptr [rsp+68],1
       jne       short M04_L19
       movsxd    rdx,r9d
       mov       rcx,rbx
       mov       r8,[rsp+60]
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
M04_L14:
       mov       rbp,rbx
       test      rbp,rbp
       je        short M04_L15
       mov       rdx,offset MT_System.ComponentModel.DescriptionAttribute[]
       cmp       [rbp],rdx
       je        short M04_L15
       mov       rdx,rbx
       mov       rcx,offset MT_System.Attribute[]
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rbp,rax
M04_L15:
       test      rbp,rbp
       je        short M04_L16
       mov       ecx,[rbp+8]
       test      ecx,ecx
       jne       near ptr M04_L20
M04_L16:
       xor       edx,edx
       jmp       near ptr M04_L21
M04_L17:
       xor       eax,eax
       jmp       near ptr M04_L01
M04_L18:
       mov       rcx,[rsp+38]
       call      qword ptr [7FFD571CE970]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       jmp       near ptr M04_L08
M04_L19:
       mov       rcx,[rsp+58]
       mov       esi,[rsp+68]
       test      rcx,rcx
       je        near ptr M04_L56
       mov       rdx,[rcx]
       cmp       rdx,[rbx]
       jne       near ptr M04_L56
       cmp       dword ptr [rdx+4],18
       jne       near ptr M04_L56
       test      r9d,r9d
       jl        near ptr M04_L56
       cmp       esi,[rcx+8]
       ja        near ptr M04_L56
       lea       r8d,[r9+rsi]
       cmp       r8d,[rbx+8]
       ja        near ptr M04_L56
       movzx     r8d,word ptr [rdx]
       mov       eax,esi
       imul      rax,r8
       add       rcx,10
       mov       r10,rcx
       mov       ecx,r9d
       imul      rcx,r8
       lea       rcx,[rbx+rcx+10]
       test      dword ptr [rdx],1000000
       je        near ptr M04_L54
       cmp       rax,4000
       ja        near ptr M04_L53
       mov       rdx,r10
       mov       r8,rax
       call      00007FFDB6DC37A0
       cmp       dword ptr [7FFDB7103A90],0
       je        near ptr M04_L14
       jmp       near ptr M04_L52
M04_L20:
       test      ecx,ecx
       je        near ptr M04_L59
       mov       rax,[rbp+10]
       mov       rdx,rax
       cmp       ecx,1
       jne       near ptr M04_L58
M04_L21:
       mov       rax,rdx
       test      rax,rax
       je        short M04_L22
       mov       rcx,rdi
       cmp       [rax],rcx
       je        short M04_L22
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
M04_L22:
       nop
       add       rsp,78
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M04_L23:
       mov       ecx,1A1
       mov       rdx,7FFD57104000
       call      qword ptr [7FFD573E7798]
       mov       rcx,rax
       call      qword ptr [7FFD57884E40]
       int       3
M04_L24:
       xor       ecx,ecx
       jmp       near ptr M04_L00
M04_L25:
       xor       ecx,ecx
       jmp       near ptr M04_L02
M04_L26:
       mov       rcx,rbp
       call      qword ptr [7FFD5710A400]
       mov       r14,rax
       mov       r15,24E84B219B8
       xor       r13d,r13d
       jmp       short M04_L30
M04_L27:
       mov       rdx,[r14+r13*8+10]
       mov       rcx,offset MT_System.RuntimeType
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       r12,rax
       mov       rcx,r12
       cmp       [rcx],ecx
       call      qword ptr [7FFD571CD398]; System.RuntimeType.get_IsActualInterface()
       test      eax,eax
       jne       short M04_L29
       mov       rcx,r12
       call      00007FFDB6DF8F60
       test      eax,eax
       je        short M04_L28
       mov       rcx,r12
       call      qword ptr [7FFD5710A3F8]
       mov       ecx,eax
       and       ecx,4
       and       eax,8
       or        ecx,eax
       je        short M04_L29
M04_L28:
       mov       r15,r12
M04_L29:
       inc       r13d
M04_L30:
       cmp       [r14+8],r13d
       jg        short M04_L27
       mov       rcx,24E84B219B8
       cmp       r15,rcx
       jne       short M04_L31
       mov       rcx,rbp
       call      qword ptr [7FFD5710A3F8]
       mov       rcx,24E84B24B90
       test      al,8
       cmovne    r15,rcx
M04_L31:
       mov       rcx,r15
       jmp       near ptr M04_L02
M04_L32:
       call      qword ptr [7FFD571C5C80]; System.RuntimeTypeHandle.GetRuntimeTypeFromHandleSlow(IntPtr)
       jmp       near ptr M04_L01
M04_L33:
       call      qword ptr [7FFD571CDB00]; System.RuntimeType.GetBaseType()
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M04_L03
M04_L34:
       mov       rcx,offset MT_System.Attribute
       cmp       rdi,rcx
       je        near ptr M04_L04
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFD57885CC8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD575443C0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M04_L35:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       r14d,eax
       jmp       near ptr M04_L05
M04_L36:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Reflection.PropertyInfo
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       rcx,rax
       mov       rdx,rbp
       movzx     r8d,sil
       call      qword ptr [7FFD576ECFA8]; System.Attribute.InternalGetCustomAttributes(System.Reflection.PropertyInfo, System.Type, Boolean)
       mov       rbp,rax
       jmp       near ptr M04_L15
M04_L37:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Reflection.EventInfo
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       rcx,rax
       mov       rdx,rbp
       movzx     r8d,sil
       call      qword ptr [7FFD57885CE0]
       mov       rbp,rax
       jmp       near ptr M04_L15
M04_L38:
       mov       esi,1
       jmp       near ptr M04_L06
M04_L39:
       xor       eax,eax
       jmp       near ptr M04_L08
M04_L40:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
       jmp       near ptr M04_L08
M04_L41:
       mov       rcx,r12
       mov       r11,7FFD57110AB0
       call      qword ptr [r11]
       jmp       near ptr M04_L09
M04_L42:
       mov       rdx,[r14]
       mov       rcx,r12
       mov       r8,rbp
       mov       r11,7FFD57110AB8
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M04_L11
       mov       rcx,24E84B21AF8
       cmp       rbp,rcx
       jne       short M04_L46
       jmp       short M04_L44
M04_L43:
       call      qword ptr [7FFD573E7A08]
       int       3
M04_L44:
       mov       rcx,rbx
       call      qword ptr [7FFD57886040]
       test      rax,rax
       je        short M04_L45
       lea       rcx,[rsp+58]
       mov       r8,rax
       mov       rdx,offset MT_System.RuntimeType+ListBuilder<System.Attribute>
       call      qword ptr [7FFD571CD4B8]; System.RuntimeType+ListBuilder`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
M04_L45:
       test      esi,esi
       jne       short M04_L47
M04_L46:
       mov       rcx,24E84B21AA8
       cmp       rbp,rcx
       jne       short M04_L49
M04_L47:
       mov       rcx,rbx
       call      qword ptr [7FFD57886058]
       test      rax,rax
       je        short M04_L48
       lea       rcx,[rsp+58]
       mov       r8,rax
       mov       rdx,offset MT_System.RuntimeType+ListBuilder<System.Attribute>
       call      qword ptr [7FFD571CD4B8]; System.RuntimeType+ListBuilder`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
M04_L48:
       test      esi,esi
       jne       short M04_L50
M04_L49:
       mov       rcx,24E84B21B48
       cmp       rbp,rcx
       jne       near ptr M04_L12
M04_L50:
       test      byte ptr [rbx+30],80
       je        near ptr M04_L12
       mov       rcx,offset MT_System.NonSerializedAttribute
       call      CORINFO_HELP_NEWSFAST
       mov       r8,rax
       lea       rcx,[rsp+58]
       mov       rdx,offset MT_System.RuntimeType+ListBuilder<System.Attribute>
       call      qword ptr [7FFD571CD4B8]; System.RuntimeType+ListBuilder`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       jmp       near ptr M04_L12
M04_L51:
       mov       rcx,rsi
       call      qword ptr [7FFD571C7C78]; System.RuntimeTypeHandle.<GetModule>g__GetModuleWorker|48_0(System.RuntimeType)
       mov       rcx,rax
       jmp       near ptr M04_L13
M04_L52:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M04_L14
M04_L53:
       mov       rdx,r10
       mov       r8,rax
       call      qword ptr [7FFD5776EA30]
       jmp       near ptr M04_L14
M04_L54:
       cmp       rax,10
       jne       short M04_L55
       vmovdqu   xmm0,xmmword ptr [r10]
       vmovdqu   xmmword ptr [rcx],xmm0
       jmp       near ptr M04_L14
M04_L55:
       mov       rdx,r10
       mov       r8,rax
       call      qword ptr [7FFD571C5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M04_L14
M04_L56:
       mov       [rsp+20],esi
       xor       r8d,r8d
       mov       [rsp+28],r8d
       mov       r8,rbx
       xor       edx,edx
       call      qword ptr [7FFD577F6670]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M04_L14
M04_L57:
       movzx     r8d,sil
       mov       rcx,rbx
       mov       rdx,rbp
       mov       rax,[rbx]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       mov       rbx,rax
       jmp       near ptr M04_L14
M04_L58:
       mov       rcx,rdx
       call      qword ptr [7FFD57885C68]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M04_L59:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1846
```
```assembly
; System.String.IsNullOrEmpty(System.String)
       test      rcx,rcx
       je        short M05_L00
       cmp       dword ptr [rcx+8],0
       sete      al
       movzx     eax,al
       ret
M05_L00:
       mov       eax,1
       ret
; Total bytes of code 22
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
; System.Enum.<GetEnumInfo>g__InitializeEnumInfo|5_0[[System.UInt32, System.Private.CoreLib]](System.RuntimeType, Boolean)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,1B8
       vzeroupper
       lea       rbp,[rsp+1F0]
       xor       eax,eax
       mov       [rbp-188],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-180],xmm4
       vmovdqa   xmmword ptr [rbp-170],xmm4
       mov       rax,0FFFFFFFFFFFFFEE0
M07_L00:
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       vmovdqa   xmmword ptr [rbp+rax-20],xmm4
       add       rax,30
       jne       short M07_L00
       mov       [rbp-40],rax
       mov       rbx,rcx
       mov       esi,edx
       lea       rcx,[rbp-158]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rdi,rax
       mov       rcx,rsp
       mov       [rbp-140],rcx
       mov       rcx,rbp
       mov       [rbp-130],rcx
       test      sil,sil
       je        near ptr M07_L37
       mov       [rbp+10],rbx
       mov       [rbp-50],rbx
       xor       ecx,ecx
       mov       [rbp-40],rcx
       mov       [rbp-48],rcx
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rbp-60],xmm0
       lea       rcx,[rbp-50]
       mov       [rbp-60],rcx
       mov       rcx,[rbp-50]
       test      rcx,rcx
       je        near ptr M07_L43
       mov       rcx,[rcx+18]
M07_L01:
       mov       [rbp-58],rcx
       vmovups   xmm0,[rbp-60]
       vmovups   [rbp-168],xmm0
       lea       rcx,[rbp-168]
       lea       rdx,[rbp-40]
       lea       r8,[rbp-48]
       mov       r9d,1
       mov       rax,7FFD57104EE8
       mov       [rbp-148],rax
       lea       rax,[M07_L02]
       mov       [rbp-138],rax
       lea       rax,[rbp-158]
       mov       [rdi+8],rax
       mov       byte ptr [rdi+4],0
       mov       rax,7FFDB6DE13E0
       call      rax
M07_L02:
       mov       byte ptr [rdi+4],1
       cmp       dword ptr [7FFDB7103A90],0
       je        short M07_L03
       call      qword ptr [7FFDB70F2648]; CORINFO_HELP_STOP_FOR_GC
M07_L03:
       mov       rcx,[rbp-150]
       mov       [rdi+8],rcx
       mov       rbx,[rbp-50]
       cmp       [rbx],bl
       mov       rcx,[rbx+18]
       call      00007FFDB6DFEBA0
       test      rax,rax
       jne       near ptr M07_L21
M07_L04:
       mov       rcx,20DEFC001C8
       mov       rsi,[rcx]
       cmp       qword ptr [rsi+8],0
       je        near ptr M07_L11
       mov       r14,[rsi+10]
       xor       r15d,r15d
       mov       r13,[rsi+18]
       mov       rcx,offset MT_System.Collections.Generic.ObjectEqualityComparer<System.RuntimeType>
       cmp       [r13],rcx
       jne       near ptr M07_L46
       mov       rcx,24E84B25F08
       mov       [rbp-68],rcx
       xor       ecx,ecx
       mov       [rbp-70],rcx
       lea       rcx,[rbp-68]
       cmp       qword ptr [rbp-70],0
       jne       short M07_L05
       mov       rcx,[rbp-68]
       mov       [rbp-70],rcx
       lea       rcx,[rbp-70]
       cmp       qword ptr [rbp-70],0
       je        near ptr M07_L44
M07_L05:
       mov       r12,[rcx]
       mov       rcx,offset MT_System.RuntimeType
       cmp       [r12],rcx
       jne       near ptr M07_L45
       mov       rcx,r12
       call      00007FFDB6DC3FE0
       test      eax,eax
       je        near ptr M07_L22
M07_L06:
       mov       r12d,eax
M07_L07:
       xor       ecx,ecx
       mov       [rbp-70],rcx
M07_L08:
       mov       rdx,[rsi+8]
       mov       ecx,r12d
       imul      rcx,[rsi+20]
       shr       rcx,20
       inc       rcx
       mov       r8d,[rdx+8]
       mov       r11d,r8d
       imul      rcx,r11
       shr       rcx,20
       cmp       ecx,r8d
       jae       near ptr M07_L56
       mov       ecx,ecx
       lea       rdx,[rdx+rcx*4+10]
       mov       eax,[rdx]
       dec       eax
       js        short M07_L11
M07_L09:
       mov       esi,[r14+8]
       cmp       eax,esi
       jae       near ptr M07_L56
       mov       edx,eax
       shl       rdx,4
       lea       rax,[r14+rdx+10]
       mov       [rbp-198],rax
       cmp       [rax+8],r12d
       je        near ptr M07_L47
M07_L10:
       mov       eax,[rax+0C]
       inc       r15d
       cmp       esi,r15d
       jb        near ptr M07_L48
       test      eax,eax
       jge       short M07_L09
M07_L11:
       mov       rcx,rbx
       call      00007FFDB6DF61E0
       mov       rsi,rax
       test      rsi,rsi
       je        near ptr M07_L50
M07_L12:
       mov       [rbp-190],rsi
       mov       rcx,rbx
       call      00007FFDB6DF9E60
       mov       ebx,eax
       cmp       [rsi],sil
       mov       rcx,rsi
       call      00007FFDB6E420E0
       mov       [rbp-78],rax
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rbp-0C8],ymm0
       vmovdqu   ymmword ptr [rbp-0A8],ymm0
       vmovdqu   xmmword ptr [rbp-88],xmm0
       mov       dword ptr [rbp-118],10
       mov       rcx,[rbp-78]
       lea       r9,[rbp-0BC]
       mov       [rsp+20],r9
       lea       r9,[rbp-0C8]
       mov       [rsp+28],r9
       lea       r9,[rbp-118]
       mov       r8d,ebx
       mov       edx,0C000000
       mov       rax,7FFD5730B2A0
       mov       [rbp-148],rax
       lea       rax,[M07_L13]
       mov       [rbp-138],rax
       lea       rax,[rbp-158]
       mov       [rdi+8],rax
       mov       byte ptr [rdi+4],0
       mov       rax,7FFDB6DE1CD0
       call      rax
M07_L13:
       mov       byte ptr [rdi+4],1
       cmp       dword ptr [7FFDB7103A90],0
       je        short M07_L14
       call      qword ptr [7FFDB70F2648]; CORINFO_HELP_STOP_FOR_GC
M07_L14:
       mov       r8,[rbp-150]
       mov       [rdi+8],r8
       mov       r8d,[rbp-118]
       mov       [rbp-0C0],r8d
       cmp       dword ptr [rbp-0C0],0
       jne       near ptr M07_L23
M07_L15:
       xor       ecx,ecx
M07_L16:
       xor       eax,eax
       mov       [rbp-100],rax
       mov       [rbp-108],rax
       test      ecx,ecx
       jne       near ptr M07_L49
M07_L17:
       xor       ebx,ebx
M07_L18:
       mov       rcx,offset MT_System.Enum+EnumInfo<System.UInt32>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdi,[rbp-40]
       mov       r14,[rbp-48]
       mov       [rsi+18],bl
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,1
       mov       ebx,[rdi+8]
       cmp       ebx,1
       jle       near ptr M07_L31
M07_L19:
       lea       eax,[rcx-1]
       cmp       eax,ebx
       jae       near ptr M07_L56
       lea       rax,[rdi+rax*4+10]
       mov       edx,[rdi+rcx*4+10]
       cmp       [rax],edx
       jae       near ptr M07_L28
M07_L20:
       inc       ecx
       cmp       ebx,ecx
       jg        short M07_L19
       jmp       near ptr M07_L31
M07_L21:
       mov       rcx,rax
       call      qword ptr [7FFD571C5860]; System.RuntimeTypeHandle.GetRuntimeTypeFromHandle(IntPtr)
       test      rax,rax
       jne       short M07_L17
       jmp       near ptr M07_L04
M07_L22:
       mov       rcx,r12
       call      qword ptr [7FFD571CE970]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       jmp       near ptr M07_L06
M07_L23:
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-0E0],xmm0
       vmovdqu   xmmword ptr [rbp-0D8],xmm0
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-0F8],xmm0
       vmovdqu   xmmword ptr [rbp-0F0],xmm0
       xor       esi,esi
       cmp       dword ptr [rbp-0C0],0
       jle       near ptr M07_L26
M07_L24:
       cmp       qword ptr [rbp-0C8],0
       jne       near ptr M07_L27
       cmp       esi,10
       jae       near ptr M07_L56
       lea       r8,[rbp-0BC]
       mov       edx,[r8+rsi*4]
M07_L25:
       lea       r8,[rbp-0D0]
       lea       r9,[rbp-0E0]
       mov       rcx,[rbp-78]
       call      00007FFDB6DFB270
       test      eax,eax
       jl        near ptr M07_L51
       mov       ecx,[rbp-0D0]
       mov       rdx,24E84B25F08
       mov       [rsp+20],rdx
       xor       edx,edx
       mov       [rsp+28],edx
       lea       rdx,[rbp-0F8]
       mov       [rsp+30],rdx
       lea       rdx,[rbp-100]
       mov       [rsp+38],rdx
       lea       rdx,[rbp-108]
       mov       [rsp+40],rdx
       lea       rdx,[rbp-110]
       mov       [rsp+48],rdx
       lea       rdx,[rbp-78]
       mov       r8,[rbp-190]
       mov       r9d,ebx
       call      qword ptr [7FFD571CEBB0]; System.Reflection.CustomAttribute.FilterCustomAttributeRecord(System.Reflection.MetadataToken, System.Reflection.MetadataImport ByRef, System.Reflection.RuntimeModule, System.Reflection.MetadataToken, System.RuntimeType, Boolean, ListBuilder`1<System.Object> ByRef, System.RuntimeType ByRef, System.IRuntimeMethodInfo ByRef, Boolean ByRef)
       test      eax,eax
       jne       near ptr M07_L52
       inc       esi
       cmp       esi,[rbp-0C0]
       jl        near ptr M07_L24
M07_L26:
       jmp       near ptr M07_L15
M07_L27:
       mov       rdx,[rbp-0C8]
       cmp       esi,[rdx+8]
       jae       near ptr M07_L56
       mov       edx,[rdx+rsi*4+10]
       jmp       near ptr M07_L25
M07_L28:
       cmp       [rax],edx
       jbe       near ptr M07_L20
       mov       r15d,ebx
       test      r14,r14
       je        short M07_L29
       mov       ecx,[r14+8]
       sub       ecx,r15d
       js        near ptr M07_L53
M07_L29:
       test      r14,r14
       je        near ptr M07_L36
       lea       r13,[rdi+10]
       add       r14,10
       test      byte ptr [7FFD57956468],1
       je        near ptr M07_L54
M07_L30:
       mov       rcx,20E05C00330
       mov       rcx,[rcx]
       mov       [rbp-178],r13
       mov       [rbp-170],r15d
       mov       [rbp-188],r14
       mov       [rbp-180],r15d
       lea       r8,[rbp-188]
       lea       rdx,[rbp-178]
       mov       r11,7FFD57110C50
       xor       r9d,r9d
       call      qword ptr [r11]
M07_L31:
       xor       r8d,r8d
       test      ebx,ebx
       jle       short M07_L33
M07_L32:
       mov       edx,[rdi+r8*4+10]
       mov       [rbp-120],rdx
       movsxd    rdx,r8d
       cmp       [rbp-120],rdx
       jne       near ptr M07_L55
       inc       r8d
       cmp       ebx,r8d
       jg        short M07_L32
M07_L33:
       mov       r8d,1
M07_L34:
       mov       [rsi+19],r8b
       xor       r8d,r8d
       mov       [rbp-40],r8
       mov       [rbp-48],r8
       mov       rbx,[rbp+10]
       cmp       [rbx],bl
       mov       r8,rsi
       mov       rdx,rbx
       mov       rcx,offset MT_System.RuntimeType+IGenericCacheEntry<System.Enum+EnumInfo<System.UInt32>>
       call      qword ptr [7FFD573EE070]; System.RuntimeType+IGenericCacheEntry`1[[System.__Canon, System.Private.CoreLib]].Replace(System.RuntimeType, System.__Canon)
M07_L35:
       mov       rax,rsi
       add       rsp,1B8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M07_L36:
       mov       rcx,rdi
       mov       r8d,r15d
       xor       edx,edx
       xor       r9d,r9d
       call      qword ptr [7FFD57887330]
       jmp       near ptr M07_L31
M07_L37:
       cmp       qword ptr [rbx+10],0
       je        short M07_L38
       mov       rcx,[rbx+10]
       mov       rax,[rcx]
       test      rax,rax
       je        short M07_L38
       jmp       short M07_L39
M07_L38:
       mov       rcx,rbx
       call      qword ptr [7FFD571C7C30]; System.RuntimeType.InitializeCache()
M07_L39:
       mov       rsi,[rax+80]
       test      rsi,rsi
       je        short M07_L41
       mov       rdx,rsi
       mov       rcx,offset MT_System.Enum+EnumInfo<System.UInt32>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M07_L40
       mov       rsi,rax
       jmp       short M07_L42
M07_L40:
       mov       rdx,rsi
       mov       rcx,offset MT_System.RuntimeType+CompositeCacheEntry
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M07_L41
       mov       rsi,[rax+28]
       test      rsi,rsi
       je        short M07_L41
       jmp       short M07_L42
M07_L41:
       mov       rdx,rbx
       mov       rcx,offset MT_System.RuntimeType+IGenericCacheEntry<System.Enum+EnumInfo<System.UInt32>>
       call      qword ptr [7FFD571CC4F8]; System.RuntimeType+IGenericCacheEntry`1[[System.__Canon, System.Private.CoreLib]].CreateAndCache(System.RuntimeType)
       mov       rsi,rax
M07_L42:
       jmp       near ptr M07_L35
M07_L43:
       xor       ecx,ecx
       jmp       near ptr M07_L01
M07_L44:
       xor       r12d,r12d
       jmp       near ptr M07_L07
M07_L45:
       mov       rcx,r12
       mov       rax,[r12]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
       mov       r12d,eax
       jmp       near ptr M07_L07
M07_L46:
       mov       rcx,r13
       mov       rdx,24E84B25F08
       mov       r11,7FFD57110C40
       call      qword ptr [r11]
       mov       r12d,eax
       jmp       near ptr M07_L08
M07_L47:
       mov       rdx,[rax]
       mov       rcx,r13
       mov       r8,24E84B25F08
       mov       r11,7FFD57110C48
       call      qword ptr [r11]
       test      eax,eax
       mov       rax,[rbp-198]
       je        near ptr M07_L10
       jmp       near ptr M07_L11
M07_L48:
       call      qword ptr [7FFD573E7A08]
       int       3
M07_L49:
       mov       ebx,1
       jmp       near ptr M07_L18
M07_L50:
       mov       rcx,rbx
       call      qword ptr [7FFD571C7C78]; System.RuntimeTypeHandle.<GetModule>g__GetModuleWorker|48_0(System.RuntimeType)
       mov       rsi,rax
       jmp       near ptr M07_L12
M07_L51:
       mov       rcx,offset MT_System.BadImageFormatException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD57885A28]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M07_L52:
       mov       ecx,1
       jmp       near ptr M07_L16
M07_L53:
       mov       ecx,10
       call      qword ptr [7FFD5788E160]
       int       3
M07_L54:
       mov       rcx,offset MT_System.Collections.Generic.ArraySortHelper<System.UInt32, System.String>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M07_L30
M07_L55:
       xor       r8d,r8d
       jmp       near ptr M07_L34
M07_L56:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1949
```
```assembly
; System.Enum.ToString()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
M08_L00:
       mov       rcx,rbx
       call      qword ptr [7FFD571CC9A8]; System.Object.GetType()
       mov       rsi,rax
       lea       rdi,[rbx+8]
       mov       rcx,[rbx]
       call      00007FFDB6E01A90
       add       eax,0FFFFFFFC
       cmp       eax,4
       jne       near ptr M08_L08
       mov       edi,[rdi]
       mov       rbx,[rsi+10]
       test      rbx,rbx
       je        near ptr M08_L27
       mov       rax,[rbx]
       test      rax,rax
       je        near ptr M08_L27
M08_L01:
       mov       rcx,[rax+80]
       test      rcx,rcx
       je        short M08_L07
       mov       rdx,offset MT_System.Enum+EnumInfo<System.UInt32>
       cmp       [rcx],rdx
       je        short M08_L03
       mov       rdx,offset MT_System.RuntimeType+CompositeCacheEntry
       cmp       [rcx],rdx
       je        short M08_L02
       xor       ecx,ecx
M08_L02:
       test      rcx,rcx
       je        short M08_L07
       mov       rcx,[rcx+28]
M08_L03:
       test      rcx,rcx
       je        near ptr M08_L28
       cmp       qword ptr [rcx+10],0
       je        near ptr M08_L28
M08_L04:
       cmp       byte ptr [rcx+18],0
       jne       near ptr M08_L35
       mov       rsi,[rcx+10]
       cmp       byte ptr [rcx+19],0
       je        near ptr M08_L29
       mov       ebx,[rsi+8]
       cmp       ebx,edi
       jbe       near ptr M08_L34
       mov       ecx,edi
       mov       rax,[rsi+rcx*8+10]
M08_L05:
       test      rax,rax
       je        near ptr M08_L36
M08_L06:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M08_L07:
       xor       ecx,ecx
       jmp       short M08_L03
M08_L08:
       cmp       eax,7
       ja        short M08_L09
       mov       ecx,eax
       lea       rdx,[7FFD578FF840]
       mov       edx,[rdx+rcx*4]
       lea       rax,[M08_L00]
       add       rdx,rax
       jmp       rdx
M08_L09:
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FFD57887990]
       jmp       short M08_L06
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FFD57887708]
       jmp       short M08_L06
       movzx     edi,byte ptr [rdi]
       mov       rbx,[rsi+10]
       test      rbx,rbx
       je        short M08_L10
       mov       rax,[rbx]
       test      rax,rax
       je        short M08_L10
       jmp       short M08_L11
M08_L10:
       mov       rcx,rsi
       call      qword ptr [7FFD571C7C30]; System.RuntimeType.InitializeCache()
M08_L11:
       mov       rbx,[rax+80]
       test      rbx,rbx
       je        short M08_L13
       mov       rdx,rbx
       mov       rcx,offset MT_System.Enum+EnumInfo<System.Byte>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M08_L12
       mov       rcx,rax
       jmp       short M08_L14
M08_L12:
       mov       rdx,rbx
       mov       rcx,offset MT_System.RuntimeType+CompositeCacheEntry
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M08_L13
       mov       rcx,[rax+28]
       jmp       short M08_L14
M08_L13:
       xor       ecx,ecx
M08_L14:
       test      rcx,rcx
       je        short M08_L15
       cmp       qword ptr [rcx+10],0
       jne       short M08_L16
M08_L15:
       mov       rcx,rsi
       mov       edx,1
       call      qword ptr [7FFD578877C8]
       mov       rcx,rax
M08_L16:
       cmp       byte ptr [rcx+18],0
       jne       short M08_L24
       mov       rsi,[rcx+10]
       cmp       byte ptr [rcx+19],0
       je        short M08_L17
       cmp       [rsi+8],edi
       jbe       short M08_L22
       mov       eax,edi
       mov       rax,[rsi+rax*8+10]
       jmp       short M08_L23
M08_L17:
       mov       rcx,[rcx+8]
       test      rcx,rcx
       jne       short M08_L18
       xor       eax,eax
       xor       r8d,r8d
       jmp       short M08_L19
M08_L18:
       lea       rax,[rcx+10]
       mov       r8d,[rcx+8]
M08_L19:
       cmp       dword ptr [rcx+8],20
       jle       short M08_L20
       mov       rcx,rax
       mov       edx,r8d
       mov       r8d,edi
       call      qword ptr [7FFD578878E8]
       jmp       short M08_L21
M08_L20:
       mov       rcx,rax
       mov       edx,edi
       call      qword ptr [7FFD577666D0]; System.SpanHelpers.NonPackedIndexOfValueType[[System.Byte, System.Private.CoreLib],[System.SpanHelpers+DontNegate`1[[System.Byte, System.Private.CoreLib]], System.Private.CoreLib]](Byte ByRef, Byte, Int32)
M08_L21:
       cmp       [rsi+8],eax
       jbe       short M08_L22
       mov       ecx,eax
       mov       rax,[rsi+rcx*8+10]
       jmp       short M08_L23
M08_L22:
       xor       eax,eax
M08_L23:
       jmp       short M08_L25
M08_L24:
       mov       edx,edi
       call      qword ptr [7FFD57887720]
M08_L25:
       test      rax,rax
       jne       short M08_L26
       mov       ecx,edi
       call      qword ptr [7FFD571C79F0]; System.Number.UInt32ToDecStr(UInt32)
M08_L26:
       jmp       near ptr M08_L06
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FFD578876D8]
       jmp       near ptr M08_L06
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FFD578876C0]
       jmp       near ptr M08_L06
M08_L27:
       mov       rcx,rsi
       call      qword ptr [7FFD571C7C30]; System.RuntimeType.InitializeCache()
       jmp       near ptr M08_L01
M08_L28:
       mov       rcx,rsi
       mov       edx,1
       call      qword ptr [7FFD573EDF50]; System.Enum.<GetEnumInfo>g__InitializeEnumInfo|5_0[[System.UInt32, System.Private.CoreLib]](System.RuntimeType, Boolean)
       mov       rcx,rax
       jmp       near ptr M08_L04
M08_L29:
       mov       rcx,[rcx+8]
       test      rcx,rcx
       jne       short M08_L30
       xor       eax,eax
       xor       r8d,r8d
       jmp       short M08_L31
M08_L30:
       lea       rax,[rcx+10]
       mov       r8d,[rcx+8]
M08_L31:
       cmp       dword ptr [rcx+8],20
       jle       short M08_L32
       mov       rcx,rax
       mov       edx,r8d
       mov       r8d,edi
       call      qword ptr [7FFD57886EB0]
       jmp       short M08_L33
M08_L32:
       mov       rcx,rax
       mov       edx,edi
       call      qword ptr [7FFD578870C0]; System.SpanHelpers.NonPackedIndexOfValueType[[System.Int32, System.Private.CoreLib],[System.SpanHelpers+DontNegate`1[[System.Int32, System.Private.CoreLib]], System.Private.CoreLib]](Int32 ByRef, Int32, Int32)
M08_L33:
       mov       ebx,[rsi+8]
       cmp       ebx,eax
       jbe       short M08_L34
       mov       ecx,eax
       mov       rax,[rsi+rcx*8+10]
       jmp       near ptr M08_L05
M08_L34:
       xor       eax,eax
       jmp       near ptr M08_L05
M08_L35:
       mov       edx,edi
       call      qword ptr [7FFD57887948]
       jmp       near ptr M08_L05
M08_L36:
       mov       ecx,edi
       call      qword ptr [7FFD5733F210]; System.Number.Int32ToDecStr(Int32)
       jmp       near ptr M08_L06
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FFD57887690]
       jmp       near ptr M08_L06
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FFD57887678]
       jmp       near ptr M08_L06
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FFD57887660]
       jmp       near ptr M08_L06
; Total bytes of code 761
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.EnumHelperBenchmark.GetDescription_NoCache_ForComparison()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Data.CountryName
       call      CORINFO_HELP_NEWSFAST
       mov       dword ptr [rax+8],6D
       mov       rcx,rax
       call      qword ptr [7FFD577DE520]; DotNetTips.Spargine.Core.BenchmarkTests.EnumHelperBenchmark.GetDescriptionNoCache(System.Enum)
       mov       [rsp+28],rax
       mov       rbx,[rbx+90]
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
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.EnumHelperBenchmark.GetDescriptionNoCache(System.Enum)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,0A8
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+50],ymm4
       vmovdqu   ymmword ptr [rsp+70],ymm4
       vmovdqa   xmmword ptr [rsp+90],xmm4
       xor       eax,eax
       mov       [rsp+0A0],rax
       mov       rbx,rcx
       test      rbx,rbx
       je        near ptr M01_L45
       mov       rcx,rbx
       call      qword ptr [7FFD571AC9A8]; System.Object.GetType()
       mov       rsi,rax
       mov       rcx,[rsi+18]
       test      cl,2
       jne       near ptr M01_L46
       mov       rcx,[rcx+10]
       mov       rdx,offset MT_System.Enum
       cmp       rcx,rdx
       sete      al
       movzx     eax,al
M01_L00:
       test      eax,eax
       je        near ptr M01_L47
       mov       rcx,[rsi+18]
       test      cl,2
       jne       near ptr M01_L36
       mov       rcx,[rcx+10]
       mov       rax,offset MT_System.Enum
       cmp       rcx,rax
       sete      cl
       movzx     ecx,cl
M01_L01:
       test      ecx,ecx
       je        near ptr M01_L48
M01_L02:
       mov       rcx,rbx
       call      qword ptr [7FFD577DE628]; System.Enum.ToUInt64(System.Object)
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFD577DE688]; System.Enum.GetName(System.RuntimeType, UInt64)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M01_L49
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8d,1C
       call      qword ptr [7FFD570EA490]; System.RuntimeType.GetField(System.String, System.Reflection.BindingFlags)
       mov       rbx,rax
       test      rbx,rbx
       je        near ptr M01_L101
       mov       rsi,2D6743D0B98
       mov       rcx,offset MT_System.ComponentModel.DescriptionAttribute
       mov       ecx,[rcx]
       and       ecx,0F0000
       cmp       ecx,0C0000
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M01_L50
       mov       rcx,rsi
       call      00007FFDB6DF8F60
       test      eax,eax
       jne       near ptr M01_L51
       mov       rcx,[7FFD5783DD18]
       test      rcx,rcx
       je        near ptr M01_L37
       mov       rax,[rcx+20]
       add       rax,10
       mov       rax,[rax]
       test      rax,rax
       je        near ptr M01_L57
M01_L03:
       mov       rcx,rax
M01_L04:
       test      rcx,rcx
       je        near ptr M01_L59
M01_L05:
       mov       rax,2D6743C1A60
       cmp       rcx,rax
       jne       near ptr M01_L58
       mov       rbp,[rbx]
       mov       r14,offset MT_System.Reflection.MdFieldInfo
       cmp       rbp,r14
       jne       near ptr M01_L60
       mov       r15d,4
M01_L06:
       cmp       r15d,2
       je        near ptr M01_L62
       cmp       r15d,10
       je        near ptr M01_L61
       cmp       rbp,r14
       jne       near ptr M01_L72
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+90],xmm0
       vmovdqu   xmmword ptr [rsp+98],xmm0
       mov       rcx,295DF4001C8
       mov       rsi,[rcx]
       cmp       qword ptr [rsi+8],0
       je        near ptr M01_L12
       mov       r15,[rsi+10]
       xor       r13d,r13d
       mov       r12,[rsi+18]
       mov       rcx,offset MT_System.Collections.Generic.ObjectEqualityComparer<System.RuntimeType>
       cmp       [r12],rcx
       jne       near ptr M01_L65
       mov       rcx,2D6743D0B98
       mov       [rsp+80],rcx
       xor       ecx,ecx
       mov       [rsp+78],rcx
       lea       rcx,[rsp+80]
       cmp       qword ptr [rsp+78],0
       jne       short M01_L07
       mov       rcx,[rsp+80]
       mov       [rsp+78],rcx
       lea       rcx,[rsp+78]
       cmp       qword ptr [rsp+78],0
       je        near ptr M01_L63
M01_L07:
       mov       rax,[rcx]
       mov       [rsp+40],rax
       mov       rcx,offset MT_System.RuntimeType
       cmp       [rax],rcx
       jne       near ptr M01_L64
       mov       rcx,rax
       call      00007FFDB6DC3FE0
       test      eax,eax
       je        near ptr M01_L38
M01_L08:
       xor       ecx,ecx
       mov       [rsp+78],rcx
M01_L09:
       mov       [rsp+8C],eax
       mov       rdx,[rsi+8]
       mov       ecx,eax
       imul      rcx,[rsi+20]
       shr       rcx,20
       inc       rcx
       mov       r8d,[rdx+8]
       mov       r11d,r8d
       imul      rcx,r11
       shr       rcx,20
       cmp       ecx,r8d
       jae       near ptr M01_L102
       mov       ecx,ecx
       lea       rdx,[rdx+rcx*4+10]
       mov       r10d,[rdx]
       dec       r10d
       js        short M01_L12
M01_L10:
       mov       esi,[r15+8]
       cmp       r10d,esi
       jae       near ptr M01_L102
       mov       edx,r10d
       shl       rdx,4
       lea       r10,[r15+rdx+10]
       mov       [rsp+48],r10
       cmp       [r10+8],eax
       je        near ptr M01_L66
M01_L11:
       mov       r10d,[r10+0C]
       inc       r13d
       cmp       esi,r13d
       jb        near ptr M01_L92
       test      r10d,r10d
       mov       eax,[rsp+8C]
       jge       short M01_L10
M01_L12:
       mov       rsi,[rbx+10]
       cmp       [rsi],sil
       mov       rcx,rsi
       call      00007FFDB6DF61E0
       mov       rcx,rax
       test      rcx,rcx
       je        near ptr M01_L67
M01_L13:
       mov       edx,[rbx+1C]
       mov       r8d,[rsp+0A0]
       mov       r9,2D6743D0B98
       call      qword ptr [7FFD571AE9B8]; System.Reflection.CustomAttribute.GetCustomAttributes(System.Reflection.RuntimeModule, Int32, Int32, System.RuntimeType)
       mov       rsi,rax
       cmp       dword ptr [rsp+0A0],0
       jle       short M01_L14
       mov       r9d,[rsi+8]
       sub       r9d,[rsp+0A0]
       cmp       dword ptr [rsp+0A0],1
       jne       near ptr M01_L39
       movsxd    rdx,r9d
       mov       rcx,rsi
       mov       r8,[rsp+98]
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
M01_L14:
       mov       r15,rsi
       test      r15,r15
       je        short M01_L15
       mov       rdx,offset MT_System.ComponentModel.DescriptionAttribute[]
       cmp       [r15],rdx
       je        short M01_L15
       mov       rdx,rsi
       mov       rcx,offset MT_System.Attribute[]
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       r15,rax
M01_L15:
       test      r15,r15
       je        near ptr M01_L40
       mov       ecx,[r15+8]
       test      ecx,ecx
       je        near ptr M01_L40
       test      ecx,ecx
       je        near ptr M01_L102
       mov       rax,[r15+10]
       mov       rdx,rax
       cmp       ecx,1
       jne       near ptr M01_L73
M01_L16:
       mov       rsi,rdx
       test      rsi,rsi
       je        short M01_L17
       mov       rcx,offset MT_System.ComponentModel.DescriptionAttribute
       cmp       [rsi],rcx
       je        short M01_L17
       call      qword ptr [7FFD571AFD08]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       mov       rsi,rax
M01_L17:
       test      rsi,rsi
       jne       near ptr M01_L74
M01_L18:
       mov       rsi,2D6743D0BC0
       mov       rcx,offset MT_System.Runtime.Serialization.EnumMemberAttribute
       mov       ecx,[rcx]
       and       ecx,0F0000
       cmp       ecx,0C0000
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M01_L75
       mov       rcx,rsi
       call      00007FFDB6DF8F60
       test      eax,eax
       jne       near ptr M01_L76
       mov       rcx,[7FFD5783DED8]
       test      rcx,rcx
       je        near ptr M01_L41
       mov       rax,[rcx+20]
       add       rax,10
       mov       rax,[rax]
       test      rax,rax
       je        near ptr M01_L82
M01_L19:
       mov       rcx,rax
M01_L20:
       test      rcx,rcx
       je        near ptr M01_L84
M01_L21:
       mov       rax,2D6743C1A60
       cmp       rcx,rax
       jne       near ptr M01_L83
       cmp       rbp,r14
       jne       near ptr M01_L85
       mov       r15d,4
M01_L22:
       cmp       r15d,2
       je        near ptr M01_L87
       cmp       r15d,10
       je        near ptr M01_L86
       cmp       rbp,r14
       jne       near ptr M01_L98
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+60],xmm0
       vmovdqu   xmmword ptr [rsp+68],xmm0
       mov       rcx,295DF4001C8
       mov       rsi,[rcx]
       cmp       qword ptr [rsi+8],0
       je        near ptr M01_L29
       mov       rbp,[rsi+10]
       xor       r14d,r14d
       mov       r15,[rsi+18]
       mov       rcx,offset MT_System.Collections.Generic.ObjectEqualityComparer<System.RuntimeType>
       cmp       [r15],rcx
       jne       near ptr M01_L90
       mov       rcx,2D6743D0BC0
       mov       [rsp+58],rcx
       xor       ecx,ecx
       mov       [rsp+50],rcx
       lea       rcx,[rsp+58]
       cmp       qword ptr [rsp+50],0
       jne       short M01_L23
       mov       rcx,[rsp+58]
       mov       [rsp+50],rcx
       lea       rcx,[rsp+50]
       cmp       qword ptr [rsp+50],0
       je        near ptr M01_L88
M01_L23:
       mov       r13,[rcx]
       mov       rcx,offset MT_System.RuntimeType
       cmp       [r13],rcx
       jne       near ptr M01_L89
       mov       rcx,r13
       call      00007FFDB6DC3FE0
       test      eax,eax
       je        near ptr M01_L42
M01_L24:
       mov       r13d,eax
M01_L25:
       xor       ecx,ecx
       mov       [rsp+50],rcx
M01_L26:
       mov       rdx,[rsi+8]
       mov       ecx,r13d
       imul      rcx,[rsi+20]
       shr       rcx,20
       inc       rcx
       mov       r8d,[rdx+8]
       mov       r11d,r8d
       imul      rcx,r11
       shr       rcx,20
       cmp       ecx,r8d
       jae       near ptr M01_L102
       mov       ecx,ecx
       lea       rdx,[rdx+rcx*4+10]
       mov       eax,[rdx]
       dec       eax
       js        short M01_L29
M01_L27:
       mov       esi,[rbp+8]
       cmp       eax,esi
       jae       near ptr M01_L102
       mov       edx,eax
       shl       rdx,4
       lea       r12,[rbp+rdx+10]
       cmp       [r12+8],r13d
       je        near ptr M01_L91
M01_L28:
       mov       eax,[r12+0C]
       inc       r14d
       cmp       esi,r14d
       jb        near ptr M01_L92
       test      eax,eax
       jge       short M01_L27
M01_L29:
       mov       rsi,[rbx+10]
       cmp       [rsi],sil
       mov       rcx,rsi
       call      00007FFDB6DF61E0
       mov       rcx,rax
       test      rcx,rcx
       je        near ptr M01_L93
M01_L30:
       mov       edx,[rbx+1C]
       mov       r8d,[rsp+70]
       mov       r9,2D6743D0BC0
       call      qword ptr [7FFD571AE9B8]; System.Reflection.CustomAttribute.GetCustomAttributes(System.Reflection.RuntimeModule, Int32, Int32, System.RuntimeType)
       mov       rbx,rax
       cmp       dword ptr [rsp+70],0
       jle       short M01_L31
       mov       r9d,[rbx+8]
       sub       r9d,[rsp+70]
       cmp       dword ptr [rsp+70],1
       jne       near ptr M01_L43
       movsxd    rdx,r9d
       mov       rcx,rbx
       mov       r8,[rsp+68]
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
M01_L31:
       mov       rbp,rbx
       test      rbp,rbp
       je        short M01_L32
       mov       rdx,offset MT_System.ComponentModel.DescriptionAttribute[]
       cmp       [rbp],rdx
       je        short M01_L32
       mov       rdx,rbx
       mov       rcx,offset MT_System.Attribute[]
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rbp,rax
M01_L32:
       test      rbp,rbp
       je        near ptr M01_L44
       mov       ecx,[rbp+8]
       test      ecx,ecx
       je        near ptr M01_L44
       test      ecx,ecx
       je        near ptr M01_L102
       mov       rax,[rbp+10]
       mov       rdx,rax
       cmp       ecx,1
       jne       near ptr M01_L99
M01_L33:
       mov       rcx,rdx
       test      rcx,rcx
       je        short M01_L34
       mov       rax,offset MT_System.Runtime.Serialization.EnumMemberAttribute
       cmp       [rcx],rax
       jne       near ptr M01_L100
M01_L34:
       test      rcx,rcx
       je        near ptr M01_L101
       mov       rax,[rcx+8]
       mov       rdx,rax
       test      rdx,rdx
       je        near ptr M01_L101
       cmp       dword ptr [rdx+8],0
       je        near ptr M01_L101
M01_L35:
       add       rsp,0A8
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L36:
       xor       ecx,ecx
       jmp       near ptr M01_L01
M01_L37:
       xor       eax,eax
       jmp       near ptr M01_L03
M01_L38:
       mov       rcx,[rsp+40]
       call      qword ptr [7FFD571AE970]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       jmp       near ptr M01_L08
M01_L39:
       mov       rcx,[rsp+90]
       mov       r15d,[rsp+0A0]
       test      rcx,rcx
       je        near ptr M01_L71
       mov       rdx,[rcx]
       cmp       rdx,[rsi]
       jne       near ptr M01_L71
       cmp       dword ptr [rdx+4],18
       jne       near ptr M01_L71
       test      r9d,r9d
       jl        near ptr M01_L71
       cmp       r15d,[rcx+8]
       ja        near ptr M01_L71
       lea       r8d,[r9+r15]
       cmp       r8d,[rsi+8]
       ja        near ptr M01_L71
       movzx     r8d,word ptr [rdx]
       mov       eax,r15d
       imul      rax,r8
       add       rcx,10
       mov       r10,rcx
       mov       ecx,r9d
       imul      rcx,r8
       lea       rcx,[rsi+rcx+10]
       test      dword ptr [rdx],1000000
       je        near ptr M01_L70
       cmp       rax,4000
       ja        near ptr M01_L69
       mov       rdx,r10
       mov       r8,rax
       call      00007FFDB6DC37A0
       cmp       dword ptr [7FFDB7103A90],0
       je        near ptr M01_L14
       jmp       near ptr M01_L68
M01_L40:
       xor       edx,edx
       jmp       near ptr M01_L16
M01_L41:
       xor       eax,eax
       jmp       near ptr M01_L19
M01_L42:
       mov       rcx,r13
       call      qword ptr [7FFD571AE970]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       jmp       near ptr M01_L24
M01_L43:
       mov       rcx,[rsp+60]
       mov       esi,[rsp+70]
       test      rcx,rcx
       je        near ptr M01_L97
       mov       rdx,[rcx]
       cmp       rdx,[rbx]
       jne       near ptr M01_L97
       cmp       dword ptr [rdx+4],18
       jne       near ptr M01_L97
       test      r9d,r9d
       jl        near ptr M01_L97
       cmp       esi,[rcx+8]
       ja        near ptr M01_L97
       lea       r8d,[r9+rsi]
       cmp       r8d,[rbx+8]
       ja        near ptr M01_L97
       movzx     r8d,word ptr [rdx]
       mov       eax,esi
       imul      rax,r8
       add       rcx,10
       mov       r10,rcx
       mov       ecx,r9d
       imul      rcx,r8
       lea       rcx,[rbx+rcx+10]
       test      dword ptr [rdx],1000000
       je        near ptr M01_L96
       cmp       rax,4000
       ja        near ptr M01_L95
       mov       rdx,r10
       mov       r8,rax
       call      00007FFDB6DC37A0
       cmp       dword ptr [7FFDB7103A90],0
       je        near ptr M01_L31
       jmp       near ptr M01_L94
M01_L44:
       xor       edx,edx
       jmp       near ptr M01_L33
M01_L45:
       call      qword ptr [7FFD5774F078]
       mov       ecx,7
       mov       rdx,7FFD57472E38
       call      qword ptr [7FFD573C7798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFD57474F20
       call      qword ptr [7FFD573C7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD571A7840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,5
       mov       rdx,7FFD57472E38
       call      qword ptr [7FFD573C7798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD571A7840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFD5786CC48]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFD57865740]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M01_L46:
       mov       rcx,rsi
       mov       rdx,2D6743C5F30
       call      qword ptr [7FFD570EA608]; System.RuntimeType.IsSubclassOf(System.Type)
       jmp       near ptr M01_L00
M01_L47:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,13
       mov       rdx,7FFD57472E38
       call      qword ptr [7FFD573C7798]
       mov       rsi,rax
       mov       ecx,7
       mov       rdx,7FFD57472E38
       call      qword ptr [7FFD573C7798]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFD575262B0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L48:
       mov       rcx,rsi
       call      qword ptr [7FFD57866BE0]; System.Type.IsIntegerType(System.Type)
       test      eax,eax
       jne       near ptr M01_L02
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFD57866BF8]
       mov       rsi,rax
       mov       ecx,3AD
       mov       rdx,7FFD570E4000
       call      qword ptr [7FFD573C7798]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFD575262B0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L49:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       jmp       near ptr M01_L35
M01_L50:
       xor       ecx,ecx
       jmp       near ptr M01_L04
M01_L51:
       mov       rcx,rsi
       call      qword ptr [7FFD570EA400]
       mov       rbp,rax
       mov       r14,2D6743C19B8
       xor       r15d,r15d
       jmp       short M01_L55
M01_L52:
       mov       rdx,[rbp+r15*8+10]
       mov       rcx,offset MT_System.RuntimeType
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       r13,rax
       mov       rcx,r13
       cmp       [rcx],ecx
       call      qword ptr [7FFD571AD398]; System.RuntimeType.get_IsActualInterface()
       test      eax,eax
       jne       short M01_L54
       mov       rcx,r13
       call      00007FFDB6DF8F60
       test      eax,eax
       je        short M01_L53
       mov       rcx,r13
       call      qword ptr [7FFD570EA3F8]
       mov       ecx,eax
       and       ecx,4
       and       eax,8
       or        ecx,eax
       je        short M01_L54
M01_L53:
       mov       r14,r13
M01_L54:
       inc       r15d
M01_L55:
       cmp       [rbp+8],r15d
       jg        short M01_L52
       mov       rcx,2D6743C19B8
       cmp       r14,rcx
       jne       short M01_L56
       mov       rcx,rsi
       call      qword ptr [7FFD570EA3F8]
       mov       rcx,2D6743C4B90
       test      al,8
       cmovne    r14,rcx
M01_L56:
       mov       rcx,r14
       jmp       near ptr M01_L04
M01_L57:
       call      qword ptr [7FFD571A5C80]; System.RuntimeTypeHandle.GetRuntimeTypeFromHandleSlow(IntPtr)
       jmp       near ptr M01_L03
M01_L58:
       call      qword ptr [7FFD571ADB00]; System.RuntimeType.GetBaseType()
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M01_L05
M01_L59:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFD57865BD8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD575243C0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L60:
       mov       rcx,rbx
       mov       rax,[rbp+40]
       call      qword ptr [rax+28]
       mov       r15d,eax
       jmp       near ptr M01_L06
M01_L61:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Reflection.PropertyInfo
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       rcx,rbx
       mov       rdx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFD576CCFA8]; System.Attribute.InternalGetCustomAttributes(System.Reflection.PropertyInfo, System.Type, Boolean)
       mov       r15,rax
       jmp       near ptr M01_L15
M01_L62:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Reflection.EventInfo
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       rcx,rbx
       mov       rdx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFD57865BF0]
       mov       r15,rax
       jmp       near ptr M01_L15
M01_L63:
       xor       eax,eax
       jmp       near ptr M01_L08
M01_L64:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
       jmp       near ptr M01_L08
M01_L65:
       mov       rcx,r12
       mov       rdx,2D6743D0B98
       mov       r11,7FFD570F0AD8
       call      qword ptr [r11]
       jmp       near ptr M01_L09
M01_L66:
       mov       rdx,[r10]
       mov       rcx,r12
       mov       r8,2D6743D0B98
       mov       r11,7FFD570F0AE0
       call      qword ptr [r11]
       test      eax,eax
       mov       r10,[rsp+48]
       je        near ptr M01_L11
       jmp       near ptr M01_L12
M01_L67:
       mov       rcx,rsi
       call      qword ptr [7FFD571A7C78]; System.RuntimeTypeHandle.<GetModule>g__GetModuleWorker|48_0(System.RuntimeType)
       mov       rcx,rax
       jmp       near ptr M01_L13
M01_L68:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M01_L14
M01_L69:
       mov       rdx,r10
       mov       r8,rax
       call      qword ptr [7FFD5774EA30]
       jmp       near ptr M01_L14
M01_L70:
       mov       rdx,r10
       mov       r8,rax
       call      qword ptr [7FFD571A5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L14
M01_L71:
       mov       [rsp+20],r15d
       xor       r8d,r8d
       mov       [rsp+28],r8d
       mov       r8,rsi
       xor       edx,edx
       call      qword ptr [7FFD577D6658]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M01_L14
M01_L72:
       mov       rcx,rbx
       mov       rdx,rsi
       xor       r8d,r8d
       mov       rax,[rbp+48]
       call      qword ptr [rax+28]
       mov       rsi,rax
       jmp       near ptr M01_L14
M01_L73:
       mov       rcx,rdx
       call      qword ptr [7FFD57865B78]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M01_L74:
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       test      rax,rax
       je        near ptr M01_L18
       cmp       dword ptr [rax+8],0
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M01_L18
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       jmp       near ptr M01_L35
M01_L75:
       xor       ecx,ecx
       jmp       near ptr M01_L20
M01_L76:
       mov       rcx,rsi
       call      qword ptr [7FFD570EA400]
       mov       r15,rax
       mov       r13,2D6743C19B8
       xor       r12d,r12d
       jmp       short M01_L80
M01_L77:
       cmp       r12d,[r15+8]
       jae       near ptr M01_L102
       mov       rdx,[r15+r12*8+10]
       mov       rcx,offset MT_System.RuntimeType
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       [rsp+38],rax
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFD571AD398]; System.RuntimeType.get_IsActualInterface()
       test      eax,eax
       jne       short M01_L79
       mov       rcx,[rsp+38]
       call      00007FFDB6DF8F60
       test      eax,eax
       je        short M01_L78
       mov       rcx,[rsp+38]
       call      qword ptr [7FFD570EA3F8]
       mov       ecx,eax
       and       ecx,4
       and       eax,8
       or        ecx,eax
       je        short M01_L79
M01_L78:
       mov       r13,[rsp+38]
M01_L79:
       inc       r12d
M01_L80:
       cmp       [r15+8],r12d
       jg        short M01_L77
       mov       rcx,2D6743C19B8
       cmp       r13,rcx
       jne       short M01_L81
       mov       rcx,rsi
       call      qword ptr [7FFD570EA3F8]
       mov       rcx,2D6743C4B90
       test      al,8
       cmovne    r13,rcx
M01_L81:
       mov       rcx,r13
       jmp       near ptr M01_L20
M01_L82:
       call      qword ptr [7FFD571A5C80]; System.RuntimeTypeHandle.GetRuntimeTypeFromHandleSlow(IntPtr)
       jmp       near ptr M01_L19
M01_L83:
       call      qword ptr [7FFD571ADB00]; System.RuntimeType.GetBaseType()
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M01_L21
M01_L84:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFD57865BD8]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFD575243C0]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M01_L85:
       mov       rcx,rbx
       mov       rax,[rbp+40]
       call      qword ptr [rax+28]
       mov       r15d,eax
       jmp       near ptr M01_L22
M01_L86:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Reflection.PropertyInfo
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       rcx,rax
       mov       rdx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFD576CCFA8]; System.Attribute.InternalGetCustomAttributes(System.Reflection.PropertyInfo, System.Type, Boolean)
       mov       rbp,rax
       jmp       near ptr M01_L32
M01_L87:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Reflection.EventInfo
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       rcx,rax
       mov       rdx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFD57865BF0]
       mov       rbp,rax
       jmp       near ptr M01_L32
M01_L88:
       xor       r13d,r13d
       jmp       near ptr M01_L25
M01_L89:
       mov       rcx,r13
       mov       rax,[r13]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
       mov       r13d,eax
       jmp       near ptr M01_L25
M01_L90:
       mov       rcx,r15
       mov       rdx,2D6743D0BC0
       mov       r11,7FFD570F0AE8
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       near ptr M01_L26
M01_L91:
       mov       rdx,[r12]
       mov       rcx,r15
       mov       r8,2D6743D0BC0
       mov       r11,7FFD570F0AF0
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M01_L28
       jmp       near ptr M01_L29
M01_L92:
       call      qword ptr [7FFD573C7A08]
       int       3
M01_L93:
       mov       rcx,rsi
       call      qword ptr [7FFD571A7C78]; System.RuntimeTypeHandle.<GetModule>g__GetModuleWorker|48_0(System.RuntimeType)
       mov       rcx,rax
       jmp       near ptr M01_L30
M01_L94:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M01_L31
M01_L95:
       mov       rdx,r10
       mov       r8,rax
       call      qword ptr [7FFD5774EA30]
       jmp       near ptr M01_L31
M01_L96:
       mov       rdx,r10
       mov       r8,rax
       call      qword ptr [7FFD571A5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L31
M01_L97:
       mov       [rsp+20],esi
       xor       r8d,r8d
       mov       [rsp+28],r8d
       mov       r8,rbx
       xor       edx,edx
       call      qword ptr [7FFD577D6658]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M01_L31
M01_L98:
       mov       rcx,rbx
       mov       rdx,rsi
       xor       r8d,r8d
       mov       rax,[rbp+48]
       call      qword ptr [rax+28]
       mov       rbx,rax
       jmp       near ptr M01_L31
M01_L99:
       mov       rcx,rdx
       call      qword ptr [7FFD57865B78]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M01_L100:
       mov       rcx,rax
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M01_L101:
       mov       rax,rdi
       jmp       near ptr M01_L35
M01_L102:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 3730
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.EnumHelperBenchmark.GetSetFlags()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       ecx,1C4
       call      qword ptr [7FFD577A6808]; DotNetTips.Spargine.Core.EnumHelper.GetSetFlags[[System.AttributeTargets, System.Private.CoreLib]](System.AttributeTargets)
       mov       [rsp+28],rax
       mov       rbx,[rbx+90]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       ret
; Total bytes of code 64
```
```assembly
; DotNetTips.Spargine.Core.EnumHelper.GetSetFlags[[System.AttributeTargets, System.Private.CoreLib]](System.AttributeTargets)
; 		if (EnumMetadata<TEnum>.IsFlags is false)
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var type = typeof(TEnum);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
; 			throw new ArgumentException($"Enum type {type.Name} is not a flags enumeration.", nameof(input));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var inputValue = Convert.ToUInt64(input, CultureInfo.InvariantCulture);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var values = Enum.GetValues<TEnum>();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var items = new List<TEnum>(values.Length);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		for (var index = 0; index < values.Length; index++)
; 		     ^^^^^^^^^^^^^
; 			var value = values[index];
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var valueBits = Convert.ToUInt64(value, CultureInfo.InvariantCulture);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			if (valueBits != 0 && (inputValue & valueBits) == valueBits)
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 				items.Add(value);
; 				^^^^^^^^^^^^^^^^^
; 		return new ReadOnlyCollection<TEnum>(items);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       ebx,ecx
M01_L00:
       mov       rsi,offset MT_System.AttributeTargets
       mov       rcx,rsi
       call      CORINFO_HELP_NEWSFAST
       mov       rcx,rax
       mov       [rcx+8],ebx
       call      qword ptr [7FFD577A6988]; System.Enum.GetValue()
       test      rax,rax
       jne       short M01_L01
       xor       ebx,ebx
       jmp       short M01_L02
M01_L01:
       mov       rdx,rax
       mov       rcx,offset MT_System.IConvertible
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastInterface(Void*, System.Object)
       mov       rcx,rax
       mov       r11,7FFD570E08D0
       xor       edx,edx
       call      qword ptr [r11]
       mov       rbx,rax
M01_L02:
       mov       rdi,25079B20B70
       mov       rcx,offset MT_System.AttributeTargets
       call      00007FFDB6E01A90
       add       eax,0FFFFFFFD
       cmp       eax,5
       jne       near ptr M01_L30
       mov       rcx,20FE4821158
       mov       rax,[rcx]
       test      rax,rax
       je        near ptr M01_L18
M01_L03:
       mov       rcx,[rax+80]
       test      rcx,rcx
       je        near ptr M01_L20
       mov       rdx,offset MT_System.Enum+EnumInfo<System.UInt32>
       cmp       [rcx],rdx
       jne       near ptr M01_L19
       mov       rax,rcx
M01_L04:
       test      rax,rax
       je        near ptr M01_L21
M01_L05:
       mov       rbp,[rax+8]
M01_L06:
       mov       edx,[rbp+8]
       test      edx,edx
       jl        near ptr M01_L117
       mov       edi,edx
       mov       edx,edi
       mov       rcx,offset MT_System.AttributeTargets[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
       mov       r15,[rbp]
       mov       rcx,r15
       cmp       rcx,[r14]
       je        near ptr M01_L104
M01_L07:
       mov       rcx,r15
       mov       eax,[rcx+4]
       add       eax,0FFFFFFE8
       shr       eax,3
       mov       ecx,eax
       test      ecx,ecx
       jne       near ptr M01_L22
       xor       r13d,r13d
M01_L08:
       mov       rcx,[r14]
       mov       edx,[rcx+4]
       add       edx,0FFFFFFE8
       shr       edx,3
       mov       ecx,edx
       test      ecx,ecx
       jne       near ptr M01_L23
       xor       r12d,r12d
M01_L09:
       cmp       r15,[r14]
       je        short M01_L10
       mov       ecx,eax
       mov       r8d,1
       test      ecx,ecx
       cmove     ecx,r8d
       mov       r8d,edx
       mov       r10d,1
       test      r8d,r8d
       cmove     r8d,r10d
       cmp       ecx,r8d
       jne       near ptr M01_L106
M01_L10:
       test      edi,edi
       jl        near ptr M01_L107
       test      eax,eax
       jne       near ptr M01_L24
       xor       r8d,r8d
M01_L11:
       cmp       r13d,r8d
       jl        near ptr M01_L108
       sub       r13d,r8d
       js        near ptr M01_L109
       lea       ecx,[rdi+r13]
       cmp       ecx,[rbp+8]
       ja        near ptr M01_L109
       test      edx,edx
       jne       near ptr M01_L25
       xor       eax,eax
M01_L12:
       cmp       r12d,eax
       jl        near ptr M01_L110
       sub       r12d,eax
       js        near ptr M01_L111
       lea       ecx,[r12+rdi]
       cmp       ecx,[r14+8]
       ja        near ptr M01_L111
       cmp       r15,[r14]
       je        short M01_L13
       mov       rcx,rbp
       mov       rdx,r14
       call      qword ptr [7FFD5773E970]; System.Array.CanAssignArrayType(System.Array, System.Array)
       test      eax,eax
       jne       near ptr M01_L113
M01_L13:
       mov       rcx,r15
       movzx     edx,word ptr [rcx]
       mov       r8d,edi
       imul      r8,rdx
       lea       rax,[rbp+8]
       mov       r10d,[r15+4]
       add       r10,0FFFFFFFFFFFFFFF0
       add       rax,r10
       mov       r10d,r13d
       imul      r10,rdx
       add       r10,rax
       lea       rax,[r14+8]
       mov       r9,[r14]
       mov       r9d,[r9+4]
       add       r9,0FFFFFFFFFFFFFFF0
       add       rax,r9
       mov       r9d,r12d
       imul      rdx,r9
       add       rdx,rax
       test      dword ptr [rcx],1000000
       jne       near ptr M01_L112
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FFD57195818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L14:
       mov       rcx,offset MT_System.Collections.Generic.List<System.AttributeTargets>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       ebp,[r14+8]
       mov       edx,ebp
       test      edx,edx
       je        near ptr M01_L114
       movsxd    rdx,edx
       mov       rcx,offset MT_System.AttributeTargets[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M01_L15:
       xor       r15d,r15d
       test      ebp,ebp
       jg        near ptr M01_L29
M01_L16:
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<System.AttributeTargets>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
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
M01_L17:
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       edx,[rdi+10]
       mov       eax,[rcx+8]
       cmp       eax,edx
       jbe       near ptr M01_L115
       lea       r8d,[rdx+1]
       mov       [rdi+10],r8d
       cmp       edx,eax
       jae       near ptr M01_L116
       mov       [rcx+rdx*4+10],r13d
       jmp       near ptr M01_L28
M01_L18:
       mov       rcx,rdi
       call      qword ptr [7FFD57197C30]; System.RuntimeType.InitializeCache()
       jmp       near ptr M01_L03
M01_L19:
       mov       rdx,offset MT_System.RuntimeType+CompositeCacheEntry
       cmp       [rcx],rdx
       jne       short M01_L20
       mov       rax,[rcx+28]
       jmp       near ptr M01_L04
M01_L20:
       xor       eax,eax
       jmp       near ptr M01_L04
M01_L21:
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FFD573BDF50]; System.Enum.<GetEnumInfo>g__InitializeEnumInfo|5_0[[System.UInt32, System.Private.CoreLib]](System.RuntimeType, Boolean)
       jmp       near ptr M01_L05
M01_L22:
       movsxd    rcx,ecx
       mov       r13d,[rbp+rcx*4+10]
       jmp       near ptr M01_L08
M01_L23:
       movsxd    rcx,ecx
       mov       r12d,[r14+rcx*4+10]
       jmp       near ptr M01_L09
M01_L24:
       movsxd    r8,eax
       mov       r8d,[rbp+r8*4+10]
       mov       eax,r8d
       mov       r8d,eax
       jmp       near ptr M01_L11
M01_L25:
       movsxd    rax,edx
       mov       eax,[r14+rax*4+10]
       jmp       near ptr M01_L12
M01_L26:
       xor       r12d,r12d
M01_L27:
       test      r12,r12
       je        short M01_L28
       mov       rcx,rbx
       and       rcx,r12
       cmp       rcx,r12
       je        near ptr M01_L17
M01_L28:
       add       r15d,1
       jo        near ptr M01_L117
       cmp       ebp,r15d
       jle       near ptr M01_L16
M01_L29:
       mov       r13d,[r14+r15*4+10]
       mov       rcx,rsi
       call      CORINFO_HELP_NEWSFAST
       mov       rcx,rax
       mov       [rcx+8],r13d
       call      qword ptr [7FFD577A6988]; System.Enum.GetValue()
       test      rax,rax
       je        short M01_L26
       mov       rdx,rax
       mov       rcx,offset MT_System.IConvertible
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastInterface(Void*, System.Object)
       mov       rcx,rax
       mov       r11,7FFD570E08E0
       xor       edx,edx
       call      qword ptr [r11]
       mov       r12,rax
       jmp       short M01_L27
M01_L30:
       cmp       eax,16
       ja        short M01_L31
       mov       ecx,eax
       lea       rax,[7FFD57231258]
       mov       eax,[rax+rcx*4]
       lea       rdx,[M01_L00]
       add       rax,rdx
       jmp       rax
M01_L31:
       call      qword ptr [7FFD577AEE08]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
       mov       rcx,20FE4821158
       mov       rax,[rcx]
       test      rax,rax
       je        short M01_L32
       jmp       short M01_L33
M01_L32:
       mov       rcx,rdi
       call      qword ptr [7FFD57197C30]; System.RuntimeType.InitializeCache()
M01_L33:
       mov       rbp,[rax+80]
       test      rbp,rbp
       je        short M01_L35
       mov       rdx,rbp
       mov       rcx,offset MT_System.Enum+EnumInfo<System.Byte>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M01_L34
       jmp       short M01_L36
M01_L34:
       mov       rdx,rbp
       mov       rcx,offset MT_System.RuntimeType+CompositeCacheEntry
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M01_L35
       mov       rax,[rax+28]
       jmp       short M01_L36
M01_L35:
       xor       eax,eax
M01_L36:
       test      rax,rax
       jne       short M01_L37
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FFD577AF228]
M01_L37:
       mov       rbp,[rax+8]
       jmp       near ptr M01_L06
       mov       rcx,20FE4821158
       mov       rax,[rcx]
       test      rax,rax
       je        short M01_L38
       jmp       short M01_L39
M01_L38:
       mov       rcx,rdi
       call      qword ptr [7FFD57197C30]; System.RuntimeType.InitializeCache()
M01_L39:
       mov       rbp,[rax+80]
       test      rbp,rbp
       je        short M01_L41
       mov       rdx,rbp
       mov       rcx,offset MT_System.Enum+EnumInfo<System.Byte>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M01_L40
       jmp       short M01_L42
M01_L40:
       mov       rdx,rbp
       mov       rcx,offset MT_System.RuntimeType+CompositeCacheEntry
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M01_L41
       mov       rax,[rax+28]
       jmp       short M01_L42
M01_L41:
       xor       eax,eax
M01_L42:
       test      rax,rax
       jne       short M01_L43
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FFD577AF228]
M01_L43:
       mov       rbp,[rax+8]
       jmp       near ptr M01_L06
       mov       rcx,20FE4821158
       mov       rax,[rcx]
       test      rax,rax
       je        short M01_L44
       jmp       short M01_L45
M01_L44:
       mov       rcx,rdi
       call      qword ptr [7FFD57197C30]; System.RuntimeType.InitializeCache()
M01_L45:
       mov       rbp,[rax+80]
       test      rbp,rbp
       je        short M01_L47
       mov       rdx,rbp
       mov       rcx,offset MT_System.Enum+EnumInfo<System.UInt16>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M01_L46
       jmp       short M01_L48
M01_L46:
       mov       rdx,rbp
       mov       rcx,offset MT_System.RuntimeType+CompositeCacheEntry
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M01_L47
       mov       rax,[rax+28]
       jmp       short M01_L48
M01_L47:
       xor       eax,eax
M01_L48:
       test      rax,rax
       jne       short M01_L49
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FFD577AF300]
M01_L49:
       mov       rbp,[rax+8]
       jmp       near ptr M01_L06
       mov       rcx,20FE4821158
       mov       rax,[rcx]
       test      rax,rax
       je        short M01_L50
       jmp       short M01_L51
M01_L50:
       mov       rcx,rdi
       call      qword ptr [7FFD57197C30]; System.RuntimeType.InitializeCache()
M01_L51:
       mov       rbp,[rax+80]
       test      rbp,rbp
       je        short M01_L53
       mov       rdx,rbp
       mov       rcx,offset MT_System.Enum+EnumInfo<System.UInt16>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M01_L52
       jmp       short M01_L54
M01_L52:
       mov       rdx,rbp
       mov       rcx,offset MT_System.RuntimeType+CompositeCacheEntry
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M01_L53
       mov       rax,[rax+28]
       jmp       short M01_L54
M01_L53:
       xor       eax,eax
M01_L54:
       test      rax,rax
       jne       short M01_L55
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FFD577AF300]
M01_L55:
       mov       rbp,[rax+8]
       jmp       near ptr M01_L06
       mov       rcx,20FE4821158
       mov       rax,[rcx]
       test      rax,rax
       je        short M01_L56
       jmp       short M01_L57
M01_L56:
       mov       rcx,rdi
       call      qword ptr [7FFD57197C30]; System.RuntimeType.InitializeCache()
M01_L57:
       mov       rbp,[rax+80]
       test      rbp,rbp
       je        short M01_L59
       mov       rdx,rbp
       mov       rcx,offset MT_System.Enum+EnumInfo<System.UInt32>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M01_L58
       jmp       short M01_L60
M01_L58:
       mov       rdx,rbp
       mov       rcx,offset MT_System.RuntimeType+CompositeCacheEntry
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M01_L59
       mov       rax,[rax+28]
       jmp       short M01_L60
M01_L59:
       xor       eax,eax
M01_L60:
       test      rax,rax
       jne       short M01_L61
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FFD573BDF50]; System.Enum.<GetEnumInfo>g__InitializeEnumInfo|5_0[[System.UInt32, System.Private.CoreLib]](System.RuntimeType, Boolean)
M01_L61:
       mov       rbp,[rax+8]
       jmp       near ptr M01_L06
       mov       rcx,20FE4821158
       mov       rax,[rcx]
       test      rax,rax
       je        short M01_L62
       jmp       short M01_L63
M01_L62:
       mov       rcx,rdi
       call      qword ptr [7FFD57197C30]; System.RuntimeType.InitializeCache()
M01_L63:
       mov       rbp,[rax+80]
       test      rbp,rbp
       je        short M01_L65
       mov       rdx,rbp
       mov       rcx,offset MT_System.Enum+EnumInfo<System.UInt64>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M01_L64
       jmp       short M01_L66
M01_L64:
       mov       rdx,rbp
       mov       rcx,offset MT_System.RuntimeType+CompositeCacheEntry
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M01_L65
       mov       rax,[rax+28]
       jmp       short M01_L66
M01_L65:
       xor       eax,eax
M01_L66:
       test      rax,rax
       jne       short M01_L67
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FFD577AF3A8]
M01_L67:
       mov       rbp,[rax+8]
       jmp       near ptr M01_L06
       mov       rcx,20FE4821158
       mov       rax,[rcx]
       test      rax,rax
       je        short M01_L68
       jmp       short M01_L69
M01_L68:
       mov       rcx,rdi
       call      qword ptr [7FFD57197C30]; System.RuntimeType.InitializeCache()
M01_L69:
       mov       rbp,[rax+80]
       test      rbp,rbp
       je        short M01_L71
       mov       rdx,rbp
       mov       rcx,offset MT_System.Enum+EnumInfo<System.UInt64>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M01_L70
       jmp       short M01_L72
M01_L70:
       mov       rdx,rbp
       mov       rcx,offset MT_System.RuntimeType+CompositeCacheEntry
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M01_L71
       mov       rax,[rax+28]
       jmp       short M01_L72
M01_L71:
       xor       eax,eax
M01_L72:
       test      rax,rax
       jne       short M01_L73
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FFD577AF3A8]
M01_L73:
       mov       rbp,[rax+8]
       jmp       near ptr M01_L06
       mov       rcx,20FE4821158
       mov       rax,[rcx]
       test      rax,rax
       je        short M01_L74
       jmp       short M01_L75
M01_L74:
       mov       rcx,rdi
       call      qword ptr [7FFD57197C30]; System.RuntimeType.InitializeCache()
M01_L75:
       mov       rbp,[rax+80]
       test      rbp,rbp
       je        short M01_L77
       mov       rdx,rbp
       mov       rcx,offset MT_System.Enum+EnumInfo<System.UIntPtr>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M01_L76
       jmp       short M01_L78
M01_L76:
       mov       rdx,rbp
       mov       rcx,offset MT_System.RuntimeType+CompositeCacheEntry
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M01_L77
       mov       rax,[rax+28]
       jmp       short M01_L78
M01_L77:
       xor       eax,eax
M01_L78:
       test      rax,rax
       jne       short M01_L79
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FFD577AF408]
M01_L79:
       mov       rbp,[rax+8]
       jmp       near ptr M01_L06
       mov       rcx,20FE4821158
       mov       rax,[rcx]
       test      rax,rax
       je        short M01_L80
       jmp       short M01_L81
M01_L80:
       mov       rcx,rdi
       call      qword ptr [7FFD57197C30]; System.RuntimeType.InitializeCache()
M01_L81:
       mov       rbp,[rax+80]
       test      rbp,rbp
       je        short M01_L83
       mov       rdx,rbp
       mov       rcx,offset MT_System.Enum+EnumInfo<System.UIntPtr>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M01_L82
       jmp       short M01_L84
M01_L82:
       mov       rdx,rbp
       mov       rcx,offset MT_System.RuntimeType+CompositeCacheEntry
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M01_L83
       mov       rax,[rax+28]
       jmp       short M01_L84
M01_L83:
       xor       eax,eax
M01_L84:
       test      rax,rax
       jne       short M01_L85
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FFD577AF408]
M01_L85:
       mov       rbp,[rax+8]
       jmp       near ptr M01_L06
       mov       rcx,20FE4821158
       mov       rax,[rcx]
       test      rax,rax
       je        short M01_L86
       jmp       short M01_L87
M01_L86:
       mov       rcx,rdi
       call      qword ptr [7FFD57197C30]; System.RuntimeType.InitializeCache()
M01_L87:
       mov       rbp,[rax+80]
       test      rbp,rbp
       je        short M01_L89
       mov       rdx,rbp
       mov       rcx,offset MT_System.Enum+EnumInfo<System.Single>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M01_L88
       jmp       short M01_L90
M01_L88:
       mov       rdx,rbp
       mov       rcx,offset MT_System.RuntimeType+CompositeCacheEntry
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M01_L89
       mov       rax,[rax+28]
       jmp       short M01_L90
M01_L89:
       xor       eax,eax
M01_L90:
       test      rax,rax
       jne       short M01_L91
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FFD577AF468]
M01_L91:
       mov       rbp,[rax+8]
       jmp       near ptr M01_L06
       mov       rcx,20FE4821158
       mov       rax,[rcx]
       test      rax,rax
       je        short M01_L92
       jmp       short M01_L93
M01_L92:
       mov       rcx,rdi
       call      qword ptr [7FFD57197C30]; System.RuntimeType.InitializeCache()
M01_L93:
       mov       rbp,[rax+80]
       test      rbp,rbp
       je        short M01_L95
       mov       rdx,rbp
       mov       rcx,offset MT_System.Enum+EnumInfo<System.Double>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M01_L94
       jmp       short M01_L96
M01_L94:
       mov       rdx,rbp
       mov       rcx,offset MT_System.RuntimeType+CompositeCacheEntry
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M01_L95
       mov       rax,[rax+28]
       jmp       short M01_L96
M01_L95:
       xor       eax,eax
M01_L96:
       test      rax,rax
       jne       short M01_L97
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FFD577AF4C8]
M01_L97:
       mov       rbp,[rax+8]
       jmp       near ptr M01_L06
       mov       rcx,20FE4821158
       mov       rax,[rcx]
       test      rax,rax
       je        short M01_L98
       jmp       short M01_L99
M01_L98:
       mov       rcx,rdi
       call      qword ptr [7FFD57197C30]; System.RuntimeType.InitializeCache()
M01_L99:
       mov       rcx,[rax+80]
       test      rcx,rcx
       je        short M01_L101
       mov       rdx,[rcx]
       mov       rax,offset MT_System.Enum+EnumInfo<System.Char>
       cmp       rdx,rax
       jne       short M01_L100
       mov       rax,rcx
       jmp       short M01_L102
M01_L100:
       mov       rax,offset MT_System.RuntimeType+CompositeCacheEntry
       cmp       rdx,rax
       jne       short M01_L101
       mov       rax,[rcx+28]
       jmp       short M01_L102
M01_L101:
       xor       eax,eax
M01_L102:
       test      rax,rax
       jne       short M01_L103
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FFD577AF528]
M01_L103:
       mov       rbp,[rax+8]
       jmp       near ptr M01_L06
M01_L104:
       cmp       dword ptr [rcx+4],18
       jne       near ptr M01_L07
       cmp       edi,[rbp+8]
       ja        near ptr M01_L07
       cmp       edi,[r14+8]
       ja        near ptr M01_L07
       mov       r8d,edi
       movzx     edx,word ptr [rcx]
       imul      r8,rdx
       lea       rdx,[rbp+10]
       lea       rax,[r14+10]
       test      dword ptr [rcx],1000000
       je        short M01_L105
       mov       rcx,rax
       call      qword ptr [7FFD571957A0]; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L14
M01_L105:
       mov       rcx,rax
       call      qword ptr [7FFD57195818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L14
M01_L106:
       mov       rcx,offset MT_System.RankException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFD577AF600]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFD577AF618]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M01_L107:
       mov       ecx,0B3
       mov       rdx,7FFD570D4000
       call      qword ptr [7FFD573B7798]
       mov       rdx,rax
       mov       ecx,edi
       call      qword ptr [7FFD577AF588]
       int       3
M01_L108:
       mov       [rsp+34],r8d
       mov       ecx,167
       mov       rdx,7FFD570D4000
       call      qword ptr [7FFD573B7798]
       mov       r8,rax
       mov       edx,[rsp+34]
       mov       ecx,r13d
       call      qword ptr [7FFD577AF5B8]
       int       3
M01_L109:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFD577AF630]
       mov       rsi,rax
       mov       ecx,12D
       mov       rdx,7FFD570D4000
       call      qword ptr [7FFD573B7798]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFD575162B0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L110:
       mov       [rsp+30],eax
       mov       ecx,17F
       mov       rdx,7FFD570D4000
       call      qword ptr [7FFD573B7798]
       mov       r8,rax
       mov       edx,[rsp+30]
       mov       ecx,r12d
       call      qword ptr [7FFD577AF5B8]
       int       3
M01_L111:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFD577AF648]
       mov       rsi,rax
       mov       ecx,145
       mov       rdx,7FFD570D4000
       call      qword ptr [7FFD573B7798]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFD575162B0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L112:
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FFD571957A0]; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L14
M01_L113:
       mov       [rsp+20],edi
       mov       [rsp+28],eax
       mov       rcx,rbp
       mov       edx,r13d
       mov       r8,r14
       mov       r9d,r12d
       call      qword ptr [7FFD577AF690]
       jmp       near ptr M01_L14
M01_L114:
       mov       rcx,offset MT_System.Collections.Generic.List<System.AttributeTargets>
       call      qword ptr [7FFD57195728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,20FFAC00188
       mov       rdx,[rcx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L15
M01_L115:
       mov       rcx,rdi
       mov       edx,r13d
       call      qword ptr [7FFD577A69E8]
       jmp       near ptr M01_L28
M01_L116:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M01_L117:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 2967
```

