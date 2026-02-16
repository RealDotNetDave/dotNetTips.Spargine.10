## .NET 10.0.3 (10.0.3, 10.0.326.7603), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.EnumerationBenchmark.FromDisplayName()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,90
       lea       rbp,[rsp+0C0]
       xor       eax,eax
       mov       [rbp-98],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-90],ymm4
       vmovdqu   ymmword ptr [rbp-70],ymm4
       vmovdqu   ymmword ptr [rbp-50],ymm4
       mov       [rbp+10],rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Enumeration+<>c__DisplayClass16_0<DotNetTips.Spargine.Extensions.NumericFormat>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rsi,21E569506C0
       mov       [rbx+8],rsi
       mov       rdx,rsi
       mov       ecx,[rdx+8]
       test      ecx,ecx
       sete      al
       movzx     eax,al
       cmp       eax,ecx
       jae       near ptr M00_L42
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Extensions.NumericFormat, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       [rbp-98],rsi
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Core.Enumeration+<>c__DisplayClass16_0`1[[System.__Canon, System.Private.CoreLib]].<FromDisplayName>b__0(System.__Canon)
       mov       [rdi+18],rcx
       mov       rbx,offset MT_DotNetTips.Spargine.Core.Enumeration+<GetAll>d__18<DotNetTips.Spargine.Extensions.NumericFormat>
       mov       rcx,rbx
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       dword ptr [rsi+18],0FFFFFFFE
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rsi+1C],eax
       cmp       dword ptr [rsi+18],0FFFFFFFE
       jne       near ptr M00_L38
       mov       r14d,[rsi+1C]
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       cmp       r14d,eax
       jne       near ptr M00_L38
       xor       ecx,ecx
       mov       [rsi+18],ecx
M00_L00:
       mov       rcx,rsi
       mov       [rbp-0A0],rcx
       mov       rax,offset DotNetTips.Spargine.Core.Enumeration+<>c__DisplayClass16_0`1[[System.__Canon, System.Private.CoreLib]].<FromDisplayName>b__0(System.__Canon)
       cmp       [rdi+18],rax
       jne       near ptr M00_L14
M00_L01:
       mov       rcx,[rbp-0A0]
       mov       rbx,rcx
       mov       esi,[rbx+18]
       test      esi,esi
       je        near ptr M00_L06
       cmp       esi,1
       jne       near ptr M00_L40
       mov       dword ptr [rbx+18],0FFFFFFFF
M00_L02:
       inc       dword ptr [rbx+20]
M00_L03:
       mov       eax,[rbx+20]
       mov       r8,[rbx+10]
       cmp       eax,[r8+8]
       jge       near ptr M00_L35
       cmp       eax,[r8+8]
       jae       near ptr M00_L33
       mov       ecx,eax
       mov       rcx,[r8+rcx*8+10]
       mov       rdx,offset MT_System.Reflection.RtFieldInfo
       cmp       [rcx],rdx
       jne       near ptr M00_L23
       xor       edx,edx
       call      qword ptr [7FFC108633F8]; System.Reflection.RtFieldInfo.GetValue(System.Object)
       mov       rdx,rax
M00_L04:
       test      rdx,rdx
       je        short M00_L02
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.NumericFormat
       cmp       [rdx],rcx
       jne       short M00_L02
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+18],1
       mov       rcx,[rbp-0A0]
       mov       rsi,[rcx+8]
       mov       r14,[rdi+8]
       mov       r15,[rsi+8]
       mov       rdx,[r14+8]
       cmp       r15,rdx
       jne       near ptr M00_L11
       mov       r13d,1
M00_L05:
       test      r13d,r13d
       je        near ptr M00_L01
       jmp       near ptr M00_L36
M00_L06:
       mov       dword ptr [rbx+18],0FFFFFFFF
       mov       rax,1DDC1551128
       mov       r14,[rax]
       test      r14,r14
       je        near ptr M00_L22
M00_L07:
       mov       rcx,r14
       xor       edx,edx
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFC10C87AE0]; System.RuntimeType+RuntimeTypeCache.GetFieldList(MemberListType, System.String)
       mov       rsi,rax
       mov       r14d,[rsi+8]
       mov       r8d,r14d
       lea       rcx,[rbp-88]
       mov       r15,offset MT_System.RuntimeType+ListBuilder<System.Reflection.FieldInfo>
       mov       rdx,r15
       call      qword ptr [7FFC10C87AF8]; System.RuntimeType+ListBuilder`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       test      r14d,r14d
       jle       short M00_L10
       add       rsi,10
M00_L08:
       mov       r8,[rsi]
       mov       ecx,[r8+18]
       mov       edx,ecx
       and       edx,18
       cmp       edx,ecx
       jne       short M00_L09
       lea       rcx,[rbp-88]
       mov       rdx,r15
       call      qword ptr [7FFC10796AC0]; System.RuntimeType+ListBuilder`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
M00_L09:
       add       rsi,8
       dec       r14d
       jne       short M00_L08
M00_L10:
       vmovdqu   xmm0,xmmword ptr [rbp-88]
       vmovdqu   xmmword ptr [rbp-70],xmm0
       mov       rcx,[rbp-78]
       mov       [rbp-60],rcx
       lea       rcx,[rbp-70]
       mov       rdx,r15
       call      qword ptr [7FFC10796B38]; System.RuntimeType+ListBuilder`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       lea       rcx,[rbx+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+20],ecx
       jmp       near ptr M00_L03
M00_L11:
       test      r15,r15
       je        near ptr M00_L21
       test      rdx,rdx
       je        near ptr M00_L21
       mov       r8d,[r15+8]
       cmp       r8d,[rdx+8]
       jne       near ptr M00_L21
       lea       rax,[r15+0C]
       add       rdx,0C
       mov       r8d,[r15+8]
       add       r8d,r8d
       cmp       r8,0A
       je        short M00_L12
       mov       rcx,rax
       call      qword ptr [7FFC105CC330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r13d,eax
       jmp       short M00_L13
M00_L12:
       mov       r8,[rax]
       mov       rax,[rax+2]
       mov       r10,[rdx]
       xor       r8,r10
       xor       rax,[rdx+2]
       or        rax,r8
       sete      r13b
       movzx     r13d,r13b
M00_L13:
       jmp       near ptr M00_L05
M00_L14:
       mov       rcx,[rbp-0A0]
       mov       rbx,rcx
       mov       esi,[rbx+18]
       test      esi,esi
       je        near ptr M00_L24
       cmp       esi,1
       jne       near ptr M00_L40
       mov       dword ptr [rbx+18],0FFFFFFFF
M00_L15:
       inc       dword ptr [rbx+20]
M00_L16:
       mov       eax,[rbx+20]
       mov       r8,[rbx+10]
       cmp       eax,[r8+8]
       jge       near ptr M00_L35
       cmp       eax,[r8+8]
       jae       near ptr M00_L33
       mov       ecx,eax
       mov       rcx,[r8+rcx*8+10]
       mov       rdx,offset MT_System.Reflection.RtFieldInfo
       cmp       [rcx],rdx
       jne       near ptr M00_L27
       xor       edx,edx
       call      qword ptr [7FFC108633F8]; System.Reflection.RtFieldInfo.GetValue(System.Object)
       mov       rdx,rax
M00_L17:
       test      rdx,rdx
       je        short M00_L15
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.NumericFormat
       cmp       [rdx],rcx
       jne       short M00_L15
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+18],1
       mov       rcx,[rbp-0A0]
       mov       rsi,[rcx+8]
       mov       rdx,offset DotNetTips.Spargine.Core.Enumeration+<>c__DisplayClass16_0`1[[System.__Canon, System.Private.CoreLib]].<FromDisplayName>b__0(System.__Canon)
       cmp       [rdi+18],rdx
       jne       near ptr M00_L28
       mov       r14,[rdi+8]
       mov       r15,[rsi+8]
       mov       rdx,[r14+8]
       cmp       r15,rdx
       jne       near ptr M00_L29
       jmp       near ptr M00_L34
M00_L18:
       mov       ecx,r13d
       mov       r8,[rsi+rcx*8+10]
       mov       ecx,[r8+18]
       mov       edx,ecx
       and       edx,18
       cmp       edx,ecx
       jne       short M00_L19
       lea       rcx,[rbp-88]
       mov       rdx,r15
       call      qword ptr [7FFC10796AC0]; System.RuntimeType+ListBuilder`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
M00_L19:
       inc       r13d
       cmp       [rsi+8],r13d
       jg        short M00_L18
       jmp       near ptr M00_L26
M00_L20:
       test      r13d,r13d
       je        near ptr M00_L14
       jmp       near ptr M00_L36
M00_L21:
       xor       r13d,r13d
       jmp       near ptr M00_L05
M00_L22:
       mov       rcx,21E56950788
       call      qword ptr [7FFC107956C8]; System.RuntimeType.InitializeCache()
       mov       r14,rax
       jmp       near ptr M00_L07
M00_L23:
       xor       edx,edx
       mov       rax,[rcx]
       mov       rax,[rax+58]
       call      qword ptr [rax]
       mov       rdx,rax
       jmp       near ptr M00_L04
M00_L24:
       mov       dword ptr [rbx+18],0FFFFFFFF
       mov       rax,1DDC1551128
       mov       r14,[rax]
       test      r14,r14
       jne       short M00_L25
       mov       rcx,21E56950788
       call      qword ptr [7FFC107956C8]; System.RuntimeType.InitializeCache()
       mov       r14,rax
M00_L25:
       mov       rcx,r14
       xor       edx,edx
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFC10C87AE0]; System.RuntimeType+RuntimeTypeCache.GetFieldList(MemberListType, System.String)
       mov       rsi,rax
       mov       r8d,[rsi+8]
       lea       rcx,[rbp-88]
       mov       r15,offset MT_System.RuntimeType+ListBuilder<System.Reflection.FieldInfo>
       mov       rdx,r15
       call      qword ptr [7FFC10C87AF8]; System.RuntimeType+ListBuilder`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       xor       r13d,r13d
       cmp       dword ptr [rsi+8],0
       jg        near ptr M00_L18
M00_L26:
       vmovdqu   xmm0,xmmword ptr [rbp-88]
       vmovdqu   xmmword ptr [rbp-70],xmm0
       mov       rcx,[rbp-78]
       mov       [rbp-60],rcx
       lea       rcx,[rbp-70]
       mov       rdx,r15
       call      qword ptr [7FFC10796B38]; System.RuntimeType+ListBuilder`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       lea       rcx,[rbx+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+20],ecx
       jmp       near ptr M00_L16
M00_L27:
       xor       edx,edx
       mov       rax,[rcx]
       mov       rax,[rax+58]
       call      qword ptr [rax]
       mov       rdx,rax
       jmp       near ptr M00_L17
M00_L28:
       mov       rdx,rsi
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       mov       r13d,eax
       jmp       near ptr M00_L20
M00_L29:
       test      r15,r15
       je        short M00_L32
       test      rdx,rdx
       je        short M00_L32
       mov       r8d,[r15+8]
       cmp       r8d,[rdx+8]
       jne       short M00_L32
       add       r15,0C
       mov       rax,r15
       add       rdx,0C
       add       r8d,r8d
       cmp       r8,0A
       je        short M00_L30
       mov       rcx,rax
       call      qword ptr [7FFC105CC330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r13d,eax
       jmp       short M00_L31
M00_L30:
       mov       r8,[rax]
       mov       rax,[rax+2]
       mov       r10,[rdx]
       xor       r8,r10
       xor       rax,[rdx+2]
       or        rax,r8
       sete      r13b
       movzx     r13d,r13b
M00_L31:
       jmp       near ptr M00_L20
M00_L32:
       xor       r13d,r13d
       jmp       near ptr M00_L20
M00_L33:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L34:
       mov       r13d,1
       jmp       near ptr M00_L20
M00_L35:
       xor       ecx,ecx
       mov       [rbx+10],rcx
       jmp       short M00_L40
M00_L36:
       mov       rcx,[rbp-0A0]
       call      qword ptr [7FFC10C5D338]; DotNetTips.Spargine.Core.Enumeration+<GetAll>d__18`1[[System.__Canon, System.Private.CoreLib]].System.IDisposable.Dispose()
M00_L37:
       test      rsi,rsi
       je        short M00_L41
       mov       [rbp-90],rsi
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+60]
       lea       r8,[rbp-90]
       mov       rdx,7FFC10C5E5E8
       cmp       [rcx],ecx
       call      qword ptr [7FFC10BFEAD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,90
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L38:
       mov       rcx,rbx
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       xor       eax,eax
       mov       [rsi+18],eax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rsi+1C],eax
       jmp       near ptr M00_L00
M00_L39:
       xor       esi,esi
       jmp       short M00_L37
M00_L40:
       call      M00_L43
       jmp       short M00_L39
M00_L41:
       lea       rcx,[rbp-58]
       mov       edx,14
       mov       r8d,2
       call      qword ptr [7FFC105CC270]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler..ctor(Int32, Int32)
       lea       rcx,[rbp-58]
       mov       rdx,21E56950708
       call      qword ptr [7FFC105CC288]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendLiteral(System.String)
       lea       rcx,[rbp-58]
       mov       rdx,[rbp-98]
       call      qword ptr [7FFC1085E028]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted(System.String)
       lea       rcx,[rbp-58]
       mov       rdx,21E56950740
       call      qword ptr [7FFC105CC288]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendLiteral(System.String)
       lea       rcx,[rbp-58]
       mov       rdx,7FFC10C5CAE0
       mov       r8,21E56950788
       call      qword ptr [7FFC1085DFC8]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       lea       rcx,[rbp-58]
       mov       rdx,21E56940C80
       call      qword ptr [7FFC105CC288]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendLiteral(System.String)
       lea       rcx,[rbp-58]
       call      qword ptr [7FFC105CC2A0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       mov       rbx,rax
       mov       ecx,1CA5
       mov       rdx,7FFC10893D38
       call      qword ptr [7FFC105CF210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC109D4048]
       int       3
M00_L42:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L43:
       sub       rsp,28
       mov       rcx,[rbp-0A0]
       call      qword ptr [7FFC10C5D338]; DotNetTips.Spargine.Core.Enumeration+<GetAll>d__18`1[[System.__Canon, System.Private.CoreLib]].System.IDisposable.Dispose()
       nop
       add       rsp,28
       ret
; Total bytes of code 1705
```
```assembly
; DotNetTips.Spargine.Core.Enumeration+<>c__DisplayClass16_0`1[[System.__Canon, System.Private.CoreLib]].<FromDisplayName>b__0(System.__Canon)
; 		return Parse<T>(displayName, predicate: item => string.Equals(item.DisplayName, displayName, StringComparison.Ordinal));
; 		                                                ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rbx
       sub       rsp,20
       mov       rdx,[rdx+8]
       mov       rcx,[rcx+8]
       cmp       rdx,rcx
       jne       short M01_L01
       mov       eax,1
M01_L00:
       add       rsp,20
       pop       rbx
       ret
M01_L01:
       test      rdx,rdx
       je        short M01_L04
       test      rcx,rcx
       je        short M01_L04
       mov       r8d,[rdx+8]
       cmp       r8d,[rcx+8]
       jne       short M01_L04
       add       rdx,0C
       add       rcx,0C
       mov       rbx,rcx
       add       r8d,r8d
       cmp       r8,0A
       je        short M01_L02
       mov       rcx,rdx
       mov       rdx,rbx
       call      qword ptr [7FFC105CC330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L03
M01_L02:
       mov       rax,[rdx]
       mov       rcx,[rdx+2]
       mov       rdx,[rbx]
       xor       rax,rdx
       xor       rcx,[rbx+2]
       or        rax,rcx
       sete      al
       movzx     eax,al
M01_L03:
       jmp       short M01_L00
M01_L04:
       xor       eax,eax
       jmp       short M01_L00
; Total bytes of code 115
```
```assembly
; System.Reflection.RtFieldInfo.GetValue(System.Object)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       cmp       qword ptr [rbx+30],0
       jne       near ptr M02_L02
       mov       rcx,offset MT_System.Reflection.FieldAccessor
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rdi+8]
       mov       rcx,[rcx+10]
       cmp       [rcx],cl
       call      qword ptr [7FFC10794B58]; System.Type.GetRootElementType()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+98]
       call      qword ptr [rax+8]
       test      rax,rax
       je        short M02_L03
       mov       rcx,rax
       call      00007FFC701AEBE0
       test      eax,eax
       jne       short M02_L00
       mov       rcx,[rdi+8]
       mov       rcx,[rcx+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFC1079D4A0]; System.RuntimeType.get_IsNullableOfT()
       test      eax,eax
       jne       short M02_L00
       mov       dword ptr [rdi+20],0F
       jmp       short M02_L01
M02_L00:
       mov       dword ptr [rdi+20],11
M02_L01:
       lea       rcx,[rbx+30]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
M02_L02:
       mov       rcx,[rbx+30]
       mov       rdx,rsi
       cmp       [rcx],ecx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFC109478B8]; System.Reflection.FieldAccessor.GetValue(System.Object)
M02_L03:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFC10C86280]
       mov       r8,rax
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFC10C86298]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 220
```
```assembly
; System.RuntimeType+RuntimeTypeCache.GetFieldList(MemberListType, System.String)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       ebx,edx
       mov       rdi,r8
       lea       rbp,[rsi+50]
       mov       r14,[rbp]
       test      r14,r14
       je        short M03_L02
M03_L00:
       cmp       [r14],r14b
       cmp       ebx,1
       je        short M03_L03
       cmp       ebx,2
       je        near ptr M03_L05
       cmp       byte ptr [r14+18],0
       je        near ptr M03_L07
       mov       rax,[r14+8]
M03_L01:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L02:
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache+MemberInfoCache<System.Reflection.RuntimeFieldInfo>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       lea       rcx,[r15+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbp
       mov       rdx,r15
       xor       r8d,r8d
       call      00007FFC7019B3A0
       mov       r14,rax
       test      r14,r14
       cmove     r14,r15
       jmp       short M03_L00
M03_L03:
       lea       rcx,[r14+20]
       mov       r8,rdi
       mov       rdx,offset MT_System.Reflection.CerHashtable<System.String, System.Reflection.RuntimeFieldInfo[]>
       call      qword ptr [7FFC10797C90]; System.Reflection.CerHashtable`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Item(System.__Canon)
       test      rax,rax
       jne       short M03_L04
       mov       rcx,r14
       mov       rdx,rdi
       mov       r8d,1
       mov       r9d,2
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       qword ptr [7FFC10796910]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
M03_L04:
       jmp       near ptr M03_L01
M03_L05:
       lea       rcx,[r14+28]
       mov       r8,rdi
       mov       rdx,offset MT_System.Reflection.CerHashtable<System.String, System.Reflection.RuntimeFieldInfo[]>
       call      qword ptr [7FFC10797C90]; System.Reflection.CerHashtable`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Item(System.__Canon)
       test      rax,rax
       jne       short M03_L06
       mov       rcx,r14
       mov       rdx,rdi
       mov       r8d,2
       mov       r9d,2
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       qword ptr [7FFC10796910]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
M03_L06:
       jmp       near ptr M03_L01
M03_L07:
       mov       rcx,r14
       mov       r8d,ebx
       xor       edx,edx
       mov       r9d,2
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       qword ptr [7FFC10796910]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
; Total bytes of code 304
```
```assembly
; System.RuntimeType+ListBuilder`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       xor       eax,eax
       mov       [rcx],rax
       mov       [rcx+8],rax
       mov       [rcx+10],eax
       mov       [rcx+14],r8d
       ret
; Total bytes of code 17
```
```assembly
; System.RuntimeType+ListBuilder`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rdx
       mov       rbx,rcx
       mov       rcx,rdx
       mov       rsi,r8
       mov       edx,[rbx+10]
       test      edx,edx
       je        near ptr M05_L06
       cmp       edx,1
       je        short M05_L02
       cmp       [rbx+14],edx
       je        near ptr M05_L08
M05_L00:
       movsxd    rdx,dword ptr [rbx+10]
       mov       rcx,[rbx]
       mov       r8,rsi
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
M05_L01:
       inc       dword ptr [rbx+10]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M05_L02:
       cmp       dword ptr [rbx+14],2
       jl        short M05_L07
M05_L03:
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       cmp       qword ptr [rdx+8],40
       jle       short M05_L05
       mov       rax,[rdx+40]
       test      rax,rax
       je        short M05_L05
       mov       rcx,rax
M05_L04:
       movsxd    rdx,dword ptr [rbx+14]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rcx,rbx
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rcx,[rbx]
       mov       r8,[rbx+8]
       xor       edx,edx
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       short M05_L00
M05_L05:
       mov       rdx,7FFC10CACB20
       call      qword ptr [7FFC105CF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M05_L04
M05_L06:
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       short M05_L01
M05_L07:
       mov       dword ptr [rbx+14],4
       jmp       short M05_L03
M05_L08:
       mov       edi,[rbx+14]
       add       edi,edi
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       cmp       qword ptr [rdx+8],38
       jle       short M05_L09
       mov       rax,[rdx+38]
       test      rax,rax
       je        short M05_L09
       mov       rcx,rax
       jmp       short M05_L10
M05_L09:
       mov       rdx,7FFC10CACB00
       call      qword ptr [7FFC105CF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M05_L10:
       mov       rdx,rbx
       mov       r8d,edi
       call      qword ptr [7FFC10796AD8]; System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
       mov       [rbx+14],edi
       jmp       near ptr M05_L00
; Total bytes of code 256
```
```assembly
; System.RuntimeType+ListBuilder`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rdx
       mov       rbx,rcx
       mov       rcx,rdx
       mov       esi,[rbx+10]
       test      esi,esi
       je        short M06_L03
       cmp       esi,1
       je        near ptr M06_L08
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       cmp       qword ptr [rdx+8],38
       jle       short M06_L02
       mov       rdx,[rdx+38]
       test      rdx,rdx
       je        short M06_L02
M06_L00:
       test      esi,esi
       jl        near ptr M06_L11
       mov       rdi,[rbx]
       test      rdi,rdi
       je        near ptr M06_L12
       cmp       [rdi+8],esi
       jne       near ptr M06_L15
M06_L01:
       mov       eax,[rbx+10]
       mov       [rbx+14],eax
       mov       rax,[rbx]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M06_L02:
       mov       rdx,7FFC10CACB00
       call      qword ptr [7FFC105CF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       short M06_L00
M06_L03:
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       cmp       qword ptr [rdx+8],48
       jle       short M06_L04
       mov       rax,[rdx+48]
       test      rax,rax
       je        short M06_L04
       mov       rcx,rax
       jmp       short M06_L05
M06_L04:
       mov       rdx,7FFC10CAE5C8
       call      qword ptr [7FFC105CF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M06_L05:
       mov       rdx,[rcx+18]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M06_L06
       jmp       short M06_L07
M06_L06:
       mov       rdx,7FFC10CAA430
       call      qword ptr [7FFC105CF630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdx,rax
M06_L07:
       mov       rcx,rdx
       call      qword ptr [7FFC105C5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rax]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M06_L08:
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       cmp       qword ptr [rdx+8],40
       jle       short M06_L09
       mov       rax,[rdx+40]
       test      rax,rax
       je        short M06_L09
       mov       rcx,rax
       jmp       short M06_L10
M06_L09:
       mov       rdx,7FFC10CACB20
       call      qword ptr [7FFC105CF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M06_L10:
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rsi,rax
       mov       r8,[rbx+8]
       mov       rcx,rsi
       xor       edx,edx
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M06_L11:
       mov       ecx,45
       mov       edx,0D
       call      qword ptr [7FFC10B45908]
       int       3
M06_L12:
       mov       rcx,[rdx+18]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M06_L13
       jmp       short M06_L14
M06_L13:
       mov       rcx,rdx
       mov       rdx,7FFC10CADEB0
       call      qword ptr [7FFC105CF630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M06_L14:
       mov       edx,esi
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdx,rax
       mov       rcx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       near ptr M06_L01
M06_L15:
       mov       rcx,[rdx+18]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M06_L16
       jmp       short M06_L17
M06_L16:
       mov       rcx,rdx
       mov       rdx,7FFC10CADEB0
       call      qword ptr [7FFC105CF630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M06_L17:
       mov       edx,esi
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbp,rax
       lea       rcx,[rbp+10]
       lea       rdx,[rdi+10]
       mov       r8d,[rdi+8]
       cmp       esi,r8d
       cmovg     esi,r8d
       mov       r8d,esi
       shl       r8,3
       call      qword ptr [7FFC105C57A0]; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rbx
       mov       rdx,rbp
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       near ptr M06_L01
; Total bytes of code 486
```
```assembly
; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       r8,8
       jae       short M07_L05
       cmp       r8,4
       jae       short M07_L04
       xor       eax,eax
       mov       r10,r8
       and       r10,2
       je        short M07_L00
       movzx     eax,word ptr [rcx]
       movzx     r9d,word ptr [rdx]
       sub       eax,r9d
M07_L00:
       test      r8b,1
       jne       short M07_L03
M07_L01:
       test      eax,eax
       sete      al
       movzx     eax,al
M07_L02:
       vzeroupper
       ret
M07_L03:
       movzx     r8d,byte ptr [rcx+r10]
       movzx     ecx,byte ptr [rdx+r10]
       sub       r8d,ecx
       or        eax,r8d
       jmp       short M07_L01
M07_L04:
       add       r8,0FFFFFFFFFFFFFFFC
       mov       eax,[rcx]
       sub       eax,[rdx]
       mov       ecx,[rcx+r8]
       sub       ecx,[rdx+r8]
       or        eax,ecx
       sete      al
       movzx     eax,al
       jmp       short M07_L02
M07_L05:
       cmp       rcx,rdx
       je        near ptr M07_L11
       cmp       r8,20
       jb        short M07_L08
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFE0
       je        short M07_L07
M07_L06:
       vmovups   ymm0,[rcx+rax]
       vpcmpeqb  ymm0,ymm0,[rdx+rax]
       vpmovmskb r10d,ymm0
       cmp       r10d,0FFFFFFFF
       jne       near ptr M07_L13
       add       rax,20
       cmp       r8,rax
       ja        short M07_L06
M07_L07:
       vmovups   ymm0,[rcx+r8]
       vpcmpeqb  ymm0,ymm0,[rdx+r8]
       vpmovmskb ecx,ymm0
       cmp       ecx,0FFFFFFFF
       jne       short M07_L13
       jmp       short M07_L11
M07_L08:
       cmp       r8,10
       jb        short M07_L12
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFF0
       je        short M07_L10
M07_L09:
       vmovups   xmm0,[rcx+rax]
       vpcmpeqb  xmm0,xmm0,[rdx+rax]
       vpmovmskb r10d,xmm0
       cmp       r10d,0FFFF
       jne       short M07_L13
       add       rax,10
       cmp       r8,rax
       ja        short M07_L09
M07_L10:
       vmovups   xmm0,[rcx+r8]
       vpcmpeqb  xmm0,xmm0,[rdx+r8]
       vpmovmskb eax,xmm0
       cmp       eax,0FFFF
       jne       short M07_L13
M07_L11:
       mov       eax,1
       vzeroupper
       ret
M07_L12:
       lea       rax,[r8-8]
       mov       r8,[rcx]
       sub       r8,[rdx]
       mov       rcx,[rcx+rax]
       sub       rcx,[rdx+rax]
       or        rcx,r8
       sete      al
       movzx     eax,al
       jmp       near ptr M07_L02
M07_L13:
       xor       eax,eax
       vzeroupper
       ret
; Total bytes of code 290
```
```assembly
; System.RuntimeType.InitializeCache()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,98
       vzeroupper
       lea       rbp,[rsp+0D0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       xor       eax,eax
       mov       [rbp-40],rax
       mov       rbx,rcx
       lea       rcx,[rbp-88]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rcx,rsp
       mov       [rbp-70],rcx
       mov       rcx,rbp
       mov       [rbp-60],rcx
       cmp       qword ptr [rbx+10],0
       je        near ptr M08_L08
M08_L00:
       mov       rcx,[rbx+10]
       mov       rdx,[rcx]
       mov       rdi,rdx
       test      rdi,rdi
       je        short M08_L01
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache
       cmp       [rdi],rcx
       jne       near ptr M08_L09
M08_L01:
       test      rdi,rdi
       jne       near ptr M08_L07
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       [rbp-0A0],rdi
       xor       ecx,ecx
       mov       [rdi+98],ecx
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbx
       call      00007FFC701ABEA0
       mov       r14,rax
       test      r14,r14
       je        near ptr M08_L10
M08_L02:
       mov       rax,[r14+8]
       test      rax,rax
       jne       near ptr M08_L05
       mov       [rbp+10],rbx
       mov       [rbp-0A8],r14
       mov       [rbp-50],r14
       xor       ecx,ecx
       mov       [rbp-48],rcx
       mov       rcx,[rbp-50]
       mov       rcx,[rcx+18]
       lea       rdx,[rbp-50]
       mov       [rbp-98],rdx
       mov       [rbp-90],rcx
       lea       rcx,[rbp-98]
       lea       rdx,[rbp-48]
       mov       rax,7FFC107B8420
       mov       [rbp-78],rax
       lea       rax,[M08_L03]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFC700A6D10
       call      rax
M08_L03:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFC704FF778],0
       je        short M08_L04
       call      qword ptr [7FFC704ED608]; CORINFO_HELP_STOP_FOR_GC
M08_L04:
       mov       rcx,[rbp-80]
       mov       [rsi+8],rcx
       mov       rbx,[rbp-48]
       xor       ecx,ecx
       mov       [rbp-48],rcx
       mov       r14,[rbp-0A8]
       lea       rcx,[r14+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
       mov       rbx,[rbp+10]
M08_L05:
       cmp       rax,rbx
       sete      cl
       mov       rdi,[rbp-0A0]
       mov       [rdi+9C],cl
       mov       rcx,[rbx+10]
       mov       rdx,rdi
       xor       r8d,r8d
       call      00007FFC701B9AA0
       mov       rdx,rax
       test      rdx,rdx
       je        short M08_L06
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache
       cmp       [rdx],rcx
       jne       short M08_L11
M08_L06:
       test      rdx,rdx
       cmovne    rdi,rdx
M08_L07:
       mov       rax,rdi
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
M08_L08:
       mov       [rbp-40],rbx
       lea       rcx,[rbp-40]
       mov       edx,1
       call      qword ptr [7FFC10C8C5A0]; System.RuntimeTypeHandle.GetGCHandle(System.Runtime.InteropServices.GCHandleType)
       mov       rdx,rax
       lea       rcx,[rbx+10]
       xor       eax,eax
       lock cmpxchg [rcx],rdx
       test      rax,rax
       je        near ptr M08_L00
       lea       rcx,[rbp-40]
       call      qword ptr [7FFC10C86AF0]
       jmp       near ptr M08_L00
M08_L09:
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M08_L10:
       mov       [rbp+10],rbx
       mov       rcx,rbx
       call      qword ptr [7FFC10795710]; System.RuntimeTypeHandle.<GetModule>g__GetModuleWorker|48_0(System.RuntimeType)
       mov       r14,rax
       mov       rbx,[rbp+10]
       jmp       near ptr M08_L02
M08_L11:
       mov       rdx,rax
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
; Total bytes of code 566
```
```assembly
; DotNetTips.Spargine.Core.Enumeration+<GetAll>d__18`1[[System.__Canon, System.Private.CoreLib]].System.IDisposable.Dispose()
       xor       eax,eax
       mov       [rcx+10],rax
       mov       dword ptr [rcx+18],0FFFFFFFE
       ret
; Total bytes of code 14
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
       call      qword ptr [7FFC6FFF8080]
       mov       rcx,[rax]
       imul      edx,edi,0B
       add       edx,esi
       mov       eax,100
       cmp       edx,100
       cmovle    edx,eax
       cmp       [rcx],ecx
       call      qword ptr [7FFC70017960]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
       mov       [rbx+8],rax
       test      rax,rax
       je        short M11_L01
       lea       rcx,[rax+10]
       mov       eax,[rax+8]
M11_L00:
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
M11_L01:
       xor       ecx,ecx
       xor       eax,eax
       jmp       short M11_L00
; Total bytes of code 102
```
```assembly
; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendLiteral(System.String)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       lea       r8,[rbx+18]
       mov       ecx,[rbx+10]
       mov       eax,[r8+8]
       cmp       ecx,eax
       ja        short M12_L00
       mov       r8,[r8]
       mov       r10d,ecx
       lea       r10,[r8+r10*2]
       sub       eax,ecx
       mov       esi,[rdx+8]
       cmp       esi,eax
       ja        short M12_L01
       mov       r8d,esi
       add       r8,r8
       add       rdx,0C
       mov       rcx,r10
       call      qword ptr [7FFC7000B980]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       [rbx+10],esi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M12_L00:
       call      qword ptr [7FFC7000D310]
       int       3
M12_L01:
       mov       rcx,rbx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [rax]
; Total bytes of code 98
```
```assembly
; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted(System.String)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       cmp       byte ptr [rbx+14],0
       jne       short M13_L01
       test      rdx,rdx
       je        short M13_L01
       lea       r8,[rbx+18]
       mov       ecx,[rbx+10]
       mov       eax,[r8+8]
       cmp       ecx,eax
       ja        short M13_L00
       mov       r8,[r8]
       mov       r10d,ecx
       lea       r10,[r8+r10*2]
       sub       eax,ecx
       mov       esi,[rdx+8]
       cmp       esi,eax
       ja        short M13_L01
       mov       r8d,esi
       add       r8,r8
       add       rdx,0C
       mov       rcx,r10
       call      qword ptr [7FFC7000B980]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       [rbx+10],esi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M13_L00:
       call      qword ptr [7FFC7000D310]
       int       3
M13_L01:
       mov       rcx,rbx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [rax]
; Total bytes of code 109
```
```assembly
; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rsi
       push      rbx
       sub       rsp,58
       xor       eax,eax
       mov       [rsp+28],rax
       xorps     xmm4,xmm4
       movaps    [rsp+30],xmm4
       mov       [rsp+40],rax
       mov       [rsp+50],rdx
       mov       rbx,rcx
       mov       rcx,rdx
       mov       rsi,r8
       cmp       byte ptr [rbx+14],0
       jne       near ptr M14_L05
       test      rsi,rsi
       je        near ptr M14_L06
       mov       rcx,rsi
       call      qword ptr [7FFC700051F0]
       test      rax,rax
       jne       short M14_L01
       mov       rcx,rsi
       lea       r11,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       call      qword ptr [r11]
       mov       rdx,rax
M14_L00:
       test      rdx,rdx
       je        near ptr M14_L06
       lea       r8,[rbx+18]
       mov       ecx,[rbx+10]
       mov       eax,[r8+8]
       cmp       ecx,eax
       ja        near ptr M14_L07
       mov       r8,[r8]
       mov       r10d,ecx
       lea       r10,[r8+r10*2]
       sub       eax,ecx
       mov       esi,[rdx+8]
       cmp       esi,eax
       ja        near ptr M14_L08
       mov       r8d,esi
       add       r8,r8
       add       rdx,0C
       mov       rcx,r10
       call      qword ptr [7FFC7000B980]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       [rbx+10],esi
       jmp       near ptr M14_L06
M14_L01:
       mov       rcx,rsi
       call      qword ptr [7FFC70005228]
       test      rax,rax
       je        near ptr M14_L04
       mov       rcx,rsi
       call      qword ptr [7FFC70006468]
       mov       rsi,rax
M14_L02:
       mov       rcx,rsi
       lea       rdx,[rbx+18]
       mov       r9d,[rbx+10]
       mov       r8d,[rdx+8]
       cmp       r9d,r8d
       ja        near ptr M14_L07
       mov       rdx,[rdx]
       mov       r11d,r9d
       lea       rdx,[rdx+r11*2]
       sub       r8d,r9d
       mov       [rsp+38],rdx
       mov       [rsp+40],r8d
       xor       edx,edx
       mov       [rsp+28],rdx
       mov       [rsp+30],edx
       mov       rdx,[rbx]
       mov       [rsp+20],rdx
       lea       rdx,[rsp+38]
       lea       r9,[rsp+28]
       lea       r8,[rsp+48]
       lea       r11,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       call      qword ptr [r11]
       test      eax,eax
       jne       short M14_L03
       mov       rcx,rbx
       call      qword ptr [7FFC70013078]
       jmp       short M14_L02
M14_L03:
       mov       ecx,[rsp+48]
       add       [rbx+10],ecx
       jmp       short M14_L06
M14_L04:
       mov       rcx,rsi
       call      qword ptr [7FFC70006460]
       mov       rcx,rax
       mov       r8,[rbx]
       lea       r11,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       xor       edx,edx
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       near ptr M14_L00
M14_L05:
       call      qword ptr [7FFC6FFFE130]
       mov       rdx,rax
       mov       rcx,rbx
       mov       r8,rsi
       xor       r9d,r9d
       call      qword ptr [7FFC70022780]
M14_L06:
       nop
       add       rsp,58
       pop       rbx
       pop       rsi
       ret
M14_L07:
       call      qword ptr [7FFC7000D310]
       int       3
M14_L08:
       mov       rcx,rbx
       call      qword ptr [7FFC70013050]
       jmp       short M14_L06
; Total bytes of code 397
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
       ja        short M15_L01
       mov       rcx,[rcx]
       mov       [rsp+28],rcx
       mov       [rsp+30],eax
       lea       rcx,[rsp+28]
       call      qword ptr [7FFC70009B88]; Precode of System.String.Ctor(System.ReadOnlySpan`1<Char>)
       mov       rdi,rax
       mov       rbp,[rbx+8]
       xor       eax,eax
       mov       [rbx+8],rax
       mov       [rsi],rax
       mov       [rsi+8],rax
       mov       [rbx+10],eax
       test      rbp,rbp
       je        short M15_L00
       call      qword ptr [7FFC6FFF8080]
       mov       rcx,[rax]
       mov       rdx,rbp
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFC70017968]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
M15_L00:
       mov       rax,rdi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M15_L01:
       call      qword ptr [7FFC7000D310]
       int       3
; Total bytes of code 126
```

## .NET 10.0.3 (10.0.3, 10.0.326.7603), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.EnumerationBenchmark.FromName()
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
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-0A0],ymm4
       vmovdqu   ymmword ptr [rbp-80],ymm4
       vmovdqu   ymmword ptr [rbp-60],ymm4
       xor       eax,eax
       mov       [rbp-40],rax
       mov       [rbp+10],rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Enumeration+<>c__DisplayClass17_0<DotNetTips.Spargine.Extensions.NumericFormat>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       dword ptr [rbx+8],1
       lea       rsi,[rbx+8]
       mov       rcx,gs:[58]
       mov       rcx,[rcx+38]
       cmp       dword ptr [rcx+238],2
       jle       near ptr M00_L48
       mov       rcx,[rcx+240]
       mov       rax,[rcx+10]
       test      rax,rax
       je        near ptr M00_L48
M00_L00:
       mov       rcx,[rax+10]
       test      rcx,rcx
       jne       short M00_L01
       mov       rcx,17FDA000190
       mov       rcx,[rcx]
       test      rcx,rcx
       jne       short M00_L01
       mov       rcx,17FDA000170
       mov       rcx,[rcx]
       test      rcx,rcx
       je        near ptr M00_L49
M00_L01:
       mov       esi,[rsi]
       test      esi,esi
       jl        near ptr M00_L50
       cmp       esi,12C
       jae       near ptr M00_L54
       mov       rcx,17FDA0002B8
       mov       rcx,[rcx]
       mov       eax,esi
       mov       rdi,[rcx+rax*8+10]
       test      rdi,rdi
       je        near ptr M00_L53
M00_L02:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Extensions.NumericFormat, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       [rbp-0A0],rdi
       lea       rcx,[rsi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Core.Enumeration+<>c__DisplayClass17_0`1[[System.__Canon, System.Private.CoreLib]].<FromValue>b__0(System.__Canon)
       mov       [rsi+18],rcx
       mov       rbx,offset MT_DotNetTips.Spargine.Core.Enumeration+<GetAll>d__18<DotNetTips.Spargine.Extensions.NumericFormat>
       mov       rcx,rbx
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+18],0FFFFFFFE
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rdi+1C],eax
       cmp       dword ptr [rdi+18],0FFFFFFFE
       jne       near ptr M00_L56
       mov       r14d,[rdi+1C]
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       cmp       r14d,eax
       jne       near ptr M00_L56
       xor       ecx,ecx
       mov       [rdi+18],ecx
M00_L03:
       mov       [rbp-0A8],rdi
       mov       rcx,offset DotNetTips.Spargine.Core.Enumeration+<>c__DisplayClass17_0`1[[System.__Canon, System.Private.CoreLib]].<FromValue>b__0(System.__Canon)
       cmp       [rsi+18],rcx
       jne       near ptr M00_L20
M00_L04:
       mov       rdi,[rbp-0A8]
       mov       rbx,rdi
       mov       r14d,[rbx+18]
       test      r14d,r14d
       je        near ptr M00_L08
       cmp       r14d,1
       jne       near ptr M00_L57
       mov       dword ptr [rbx+18],0FFFFFFFF
M00_L05:
       inc       dword ptr [rbx+20]
M00_L06:
       mov       eax,[rbx+20]
       mov       r8,[rbx+10]
       cmp       eax,[r8+8]
       jge       near ptr M00_L45
       cmp       eax,[r8+8]
       jae       near ptr M00_L44
       mov       ecx,eax
       mov       rcx,[r8+rcx*8+10]
       mov       rdx,offset MT_System.Reflection.RtFieldInfo
       cmp       [rcx],rdx
       jne       near ptr M00_L32
       xor       edx,edx
       call      qword ptr [7FFC10839520]; System.Reflection.RtFieldInfo.GetValue(System.Object)
       mov       rdx,rax
M00_L07:
       test      rdx,rdx
       je        short M00_L05
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.NumericFormat
       cmp       [rdx],rcx
       jne       short M00_L05
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+18],1
       mov       r14,[rdi+8]
       mov       ecx,[r14+10]
       mov       rax,[rsi+8]
       cmp       ecx,[rax+8]
       jne       near ptr M00_L04
       jmp       near ptr M00_L46
M00_L08:
       mov       dword ptr [rbx+18],0FFFFFFFF
       mov       rcx,17FD9CE1100
       mov       r15,[rcx]
       test      r15,r15
       jne       short M00_L09
       mov       rcx,1C06F290740
       call      qword ptr [7FFC107656C8]; System.RuntimeType.InitializeCache()
       mov       r13,rax
       jmp       short M00_L10
M00_L09:
       mov       r13,r15
M00_L10:
       cmp       [r13],r13b
       lea       r12,[r13+50]
       mov       rcx,[r12]
       test      rcx,rcx
       je        near ptr M00_L29
M00_L11:
       xor       edx,edx
       xor       r8d,r8d
       mov       r9d,2
       cmp       [rcx],ecx
       call      qword ptr [7FFC107668F8]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].GetMemberList(MemberListType, System.String, CacheType)
       mov       r14,rax
       mov       r15d,[r14+8]
       mov       eax,r15d
       xor       edx,edx
       mov       [rbp-90],rdx
       mov       [rbp-88],rdx
       mov       [rbp-80],edx
       mov       [rbp-7C],eax
       test      r15d,r15d
       jle       short M00_L16
       add       r14,10
M00_L12:
       mov       r13,[r14]
       mov       edx,[r13+18]
       mov       r8d,edx
       and       r8d,18
       cmp       r8d,edx
       jne       short M00_L15
       cmp       dword ptr [rbp-80],0
       je        near ptr M00_L19
       cmp       dword ptr [rbp-80],1
       je        short M00_L17
       mov       edx,[rbp-7C]
       cmp       edx,[rbp-80]
       je        near ptr M00_L31
M00_L13:
       movsxd    rdx,dword ptr [rbp-80]
       mov       rcx,[rbp-90]
       mov       r8,r13
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
M00_L14:
       mov       ecx,[rbp-80]
       inc       ecx
       mov       [rbp-80],ecx
M00_L15:
       add       r14,8
       dec       r15d
       jne       short M00_L12
M00_L16:
       vmovdqu   xmm0,xmmword ptr [rbp-90]
       vmovdqu   xmmword ptr [rbp-78],xmm0
       mov       rcx,[rbp-80]
       mov       [rbp-68],rcx
       lea       rcx,[rbp-78]
       mov       rdx,offset MT_System.RuntimeType+ListBuilder<System.Reflection.FieldInfo>
       call      qword ptr [7FFC10766B38]; System.RuntimeType+ListBuilder`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       lea       rcx,[rbx+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+20],ecx
       jmp       near ptr M00_L06
M00_L17:
       cmp       dword ptr [rbp-7C],2
       jl        near ptr M00_L30
M00_L18:
       movsxd    rdx,dword ptr [rbp-7C]
       mov       rcx,offset MT_System.Reflection.FieldInfo[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       [rbp-90],rax
       mov       rcx,[rbp-90]
       mov       r8,[rbp-88]
       xor       edx,edx
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       near ptr M00_L13
M00_L19:
       mov       [rbp-88],r13
       jmp       near ptr M00_L14
M00_L20:
       mov       rdi,[rbp-0A8]
       mov       rbx,rdi
       mov       r14d,[rbx+18]
       test      r14d,r14d
       je        near ptr M00_L33
       cmp       r14d,1
       jne       near ptr M00_L57
       mov       dword ptr [rbx+18],0FFFFFFFF
M00_L21:
       inc       dword ptr [rbx+20]
M00_L22:
       mov       eax,[rbx+20]
       mov       r8,[rbx+10]
       cmp       eax,[r8+8]
       jge       near ptr M00_L45
       cmp       eax,[r8+8]
       jae       near ptr M00_L44
       mov       ecx,eax
       mov       rcx,[r8+rcx*8+10]
       mov       rdx,offset MT_System.Reflection.RtFieldInfo
       cmp       [rcx],rdx
       jne       near ptr M00_L42
       xor       edx,edx
       call      qword ptr [7FFC10839520]; System.Reflection.RtFieldInfo.GetValue(System.Object)
       mov       rdx,rax
M00_L23:
       test      rdx,rdx
       je        short M00_L21
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.NumericFormat
       cmp       [rdx],rcx
       jne       short M00_L21
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+18],1
       mov       r14,[rdi+8]
       mov       rdx,offset DotNetTips.Spargine.Core.Enumeration+<>c__DisplayClass17_0`1[[System.__Canon, System.Private.CoreLib]].<FromValue>b__0(System.__Canon)
       cmp       [rsi+18],rdx
       jne       near ptr M00_L43
       mov       edx,[r14+10]
       mov       rcx,[rsi+8]
       cmp       edx,[rcx+8]
       jne       near ptr M00_L20
       jmp       near ptr M00_L46
M00_L24:
       mov       edx,[rbp-7C]
       cmp       edx,[rbp-80]
       je        near ptr M00_L37
M00_L25:
       movsxd    rdx,dword ptr [rbp-80]
       mov       rcx,[rbp-90]
       mov       r8,r13
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
M00_L26:
       mov       ecx,[rbp-80]
       inc       ecx
       mov       [rbp-80],ecx
M00_L27:
       inc       r15d
       cmp       [r14+8],r15d
       jle       near ptr M00_L41
M00_L28:
       mov       edx,r15d
       mov       r13,[r14+rdx*8+10]
       mov       edx,[r13+18]
       mov       r8d,edx
       and       r8d,18
       cmp       r8d,edx
       jne       short M00_L27
       cmp       dword ptr [rbp-80],0
       je        near ptr M00_L40
       cmp       dword ptr [rbp-80],1
       jne       short M00_L24
       jmp       near ptr M00_L38
M00_L29:
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache+MemberInfoCache<System.Reflection.RuntimeFieldInfo>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       lea       rcx,[r15+10]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r12
       mov       rdx,r15
       xor       r8d,r8d
       call      00007FFC7019B3A0
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M00_L11
       mov       rcx,r15
       jmp       near ptr M00_L11
M00_L30:
       mov       dword ptr [rbp-7C],4
       jmp       near ptr M00_L18
M00_L31:
       mov       r12d,[rbp-7C]
       add       r12d,r12d
       lea       rdx,[rbp-90]
       mov       r8d,r12d
       mov       rcx,7FFC107B8FB8
       call      qword ptr [7FFC10766AD8]; System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
       mov       [rbp-7C],r12d
       jmp       near ptr M00_L13
M00_L32:
       xor       edx,edx
       mov       rax,[rcx]
       mov       rax,[rax+58]
       call      qword ptr [rax]
       mov       rdx,rax
       jmp       near ptr M00_L07
M00_L33:
       mov       dword ptr [rbx+18],0FFFFFFFF
       mov       rcx,17FD9CE1100
       mov       r15,[rcx]
       test      r15,r15
       jne       short M00_L34
       mov       rcx,1C06F290740
       call      qword ptr [7FFC107656C8]; System.RuntimeType.InitializeCache()
       mov       r13,rax
       jmp       short M00_L35
M00_L34:
       mov       r13,r15
M00_L35:
       cmp       [r13],r13b
       lea       r12,[r13+50]
       mov       rcx,[r12]
       test      rcx,rcx
       jne       short M00_L36
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache+MemberInfoCache<System.Reflection.RuntimeFieldInfo>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       lea       rcx,[r15+10]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r12
       mov       rdx,r15
       xor       r8d,r8d
       call      00007FFC7019B3A0
       mov       rcx,rax
       test      rcx,rcx
       jne       short M00_L36
       mov       rcx,r15
M00_L36:
       xor       edx,edx
       xor       r8d,r8d
       mov       r9d,2
       cmp       [rcx],ecx
       call      qword ptr [7FFC107668F8]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].GetMemberList(MemberListType, System.String, CacheType)
       mov       r14,rax
       mov       eax,[r14+8]
       xor       edx,edx
       mov       [rbp-90],rdx
       mov       [rbp-88],rdx
       mov       [rbp-80],edx
       mov       [rbp-7C],eax
       xor       r15d,r15d
       cmp       dword ptr [r14+8],0
       jle       near ptr M00_L41
       jmp       near ptr M00_L28
M00_L37:
       mov       r12d,[rbp-7C]
       add       r12d,r12d
       lea       rdx,[rbp-90]
       mov       r8d,r12d
       mov       rcx,7FFC107B8FB8
       call      qword ptr [7FFC10766AD8]; System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
       mov       [rbp-7C],r12d
       jmp       near ptr M00_L25
M00_L38:
       cmp       dword ptr [rbp-7C],2
       jge       short M00_L39
       mov       dword ptr [rbp-7C],4
M00_L39:
       movsxd    rdx,dword ptr [rbp-7C]
       mov       rcx,offset MT_System.Reflection.FieldInfo[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       [rbp-90],rax
       mov       rcx,[rbp-90]
       mov       r8,[rbp-88]
       xor       edx,edx
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       near ptr M00_L25
M00_L40:
       mov       [rbp-88],r13
       jmp       near ptr M00_L26
M00_L41:
       vmovdqu   xmm0,xmmword ptr [rbp-90]
       vmovdqu   xmmword ptr [rbp-78],xmm0
       mov       rcx,[rbp-80]
       mov       [rbp-68],rcx
       lea       rcx,[rbp-78]
       mov       rdx,offset MT_System.RuntimeType+ListBuilder<System.Reflection.FieldInfo>
       call      qword ptr [7FFC10766B38]; System.RuntimeType+ListBuilder`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       lea       rcx,[rbx+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+20],ecx
       jmp       near ptr M00_L22
M00_L42:
       xor       edx,edx
       mov       rax,[rcx]
       mov       rax,[rax+58]
       call      qword ptr [rax]
       mov       rdx,rax
       jmp       near ptr M00_L23
M00_L43:
       mov       rdx,r14
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       je        near ptr M00_L20
       jmp       short M00_L46
M00_L44:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L45:
       xor       ecx,ecx
       mov       [rbx+10],rcx
       jmp       near ptr M00_L57
M00_L46:
       mov       rcx,rdi
       call      qword ptr [7FFC10C47CE8]; DotNetTips.Spargine.Core.Enumeration+<GetAll>d__18`1[[System.__Canon, System.Private.CoreLib]].System.IDisposable.Dispose()
M00_L47:
       test      r14,r14
       je        near ptr M00_L58
       mov       [rbp-98],r14
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+60]
       lea       r8,[rbp-98]
       mov       rdx,7FFC10C48F98
       cmp       [rcx],ecx
       call      qword ptr [7FFC10BEEFA0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
M00_L48:
       mov       ecx,2
       call      qword ptr [7FFC10C561F0]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L00
M00_L49:
       call      qword ptr [7FFC1059D4B8]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rcx,rax
       jmp       near ptr M00_L01
M00_L50:
       test      rcx,rcx
       je        short M00_L51
       call      qword ptr [7FFC10B14948]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider)
       jmp       short M00_L52
M00_L51:
       call      qword ptr [7FFC1059D2A8]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
M00_L52:
       mov       r8,[rax+28]
       mov       ecx,esi
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFC10C570A8]
       mov       rdi,rax
       jmp       near ptr M00_L02
M00_L53:
       mov       ecx,esi
       call      qword ptr [7FFC107654D0]; System.Number.<UInt32ToDecStrForKnownSmallNumber>g__CreateAndCacheString|50_0(UInt32)
       mov       rdi,rax
       jmp       near ptr M00_L02
M00_L54:
       mov       ecx,esi
       call      qword ptr [7FFC107654E8]; System.Number.UInt32ToDecStr_NoSmallNumberCheck(UInt32)
       mov       rdi,rax
       jmp       near ptr M00_L02
M00_L55:
       xor       r14d,r14d
       jmp       near ptr M00_L47
M00_L56:
       mov       rcx,rbx
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       xor       eax,eax
       mov       [rdi+18],eax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rdi+1C],eax
       jmp       near ptr M00_L03
M00_L57:
       call      M00_L59
       jmp       short M00_L55
M00_L58:
       lea       rcx,[rbp-60]
       mov       edx,14
       mov       r8d,2
       call      qword ptr [7FFC1059C270]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler..ctor(Int32, Int32)
       lea       rcx,[rbp-60]
       mov       rdx,1C06F2906C0
       call      qword ptr [7FFC1059C288]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendLiteral(System.String)
       lea       rcx,[rbp-60]
       mov       rdx,[rbp-0A0]
       call      qword ptr [7FFC1082E088]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted(System.String)
       lea       rcx,[rbp-60]
       mov       rdx,1C06F2906F8
       call      qword ptr [7FFC1059C288]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendLiteral(System.String)
       lea       rcx,[rbp-60]
       mov       rdx,7FFC10C47490
       mov       r8,1C06F290740
       call      qword ptr [7FFC1082E028]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       lea       rcx,[rbp-60]
       mov       rdx,1C06F280C80
       call      qword ptr [7FFC1059C288]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendLiteral(System.String)
       lea       rcx,[rbp-60]
       call      qword ptr [7FFC1059C2A0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       mov       rbx,rax
       mov       ecx,1CA5
       mov       rdx,7FFC10864098
       call      qword ptr [7FFC1059F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC109A4078]
       int       3
M00_L59:
       sub       rsp,28
       mov       rcx,[rbp-0A8]
       call      qword ptr [7FFC10C47CE8]; DotNetTips.Spargine.Core.Enumeration+<GetAll>d__18`1[[System.__Canon, System.Private.CoreLib]].System.IDisposable.Dispose()
       nop
       add       rsp,28
       ret
; Total bytes of code 2176
```
```assembly
; DotNetTips.Spargine.Core.Enumeration+<>c__DisplayClass17_0`1[[System.__Canon, System.Private.CoreLib]].<FromValue>b__0(System.__Canon)
; 		return Parse<T>(value.ToString(CultureInfo.CurrentCulture), item => item.Value == value);
; 		                                                                    ^^^^^^^^^^^^^^^^^^^
       mov       eax,[rdx+10]
       cmp       eax,[rcx+8]
       sete      al
       movzx     eax,al
       ret
; Total bytes of code 13
```
```assembly
; System.Reflection.RtFieldInfo.GetValue(System.Object)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       cmp       qword ptr [rbx+30],0
       jne       near ptr M02_L02
       mov       rcx,offset MT_System.Reflection.FieldAccessor
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rdi+8]
       mov       rcx,[rcx+10]
       cmp       [rcx],cl
       call      qword ptr [7FFC10764B58]; System.Type.GetRootElementType()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+98]
       call      qword ptr [rax+8]
       test      rax,rax
       je        short M02_L03
       mov       rcx,rax
       call      00007FFC701AEBE0
       test      eax,eax
       jne       short M02_L00
       mov       rcx,[rdi+8]
       mov       rcx,[rcx+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFC1076D4A0]; System.RuntimeType.get_IsNullableOfT()
       test      eax,eax
       jne       short M02_L00
       mov       dword ptr [rdi+20],0F
       jmp       short M02_L01
M02_L00:
       mov       dword ptr [rdi+20],11
M02_L01:
       lea       rcx,[rbx+30]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
M02_L02:
       mov       rcx,[rbx+30]
       mov       rdx,rsi
       cmp       [rcx],ecx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFC109178E8]; System.Reflection.FieldAccessor.GetValue(System.Object)
M02_L03:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFC10C567C0]
       mov       r8,rax
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFC10C567D8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 220
```
```assembly
; System.RuntimeType.InitializeCache()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,98
       vzeroupper
       lea       rbp,[rsp+0D0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       xor       eax,eax
       mov       [rbp-40],rax
       mov       rbx,rcx
       lea       rcx,[rbp-88]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rcx,rsp
       mov       [rbp-70],rcx
       mov       rcx,rbp
       mov       [rbp-60],rcx
       cmp       qword ptr [rbx+10],0
       je        near ptr M03_L08
M03_L00:
       mov       rcx,[rbx+10]
       mov       rdx,[rcx]
       mov       rdi,rdx
       test      rdi,rdi
       je        short M03_L01
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache
       cmp       [rdi],rcx
       jne       near ptr M03_L09
M03_L01:
       test      rdi,rdi
       jne       near ptr M03_L07
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       [rbp-0A0],rdi
       xor       ecx,ecx
       mov       [rdi+98],ecx
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbx
       call      00007FFC701ABEA0
       mov       r14,rax
       test      r14,r14
       je        near ptr M03_L10
M03_L02:
       mov       rax,[r14+8]
       test      rax,rax
       jne       near ptr M03_L05
       mov       [rbp+10],rbx
       mov       [rbp-0A8],r14
       mov       [rbp-50],r14
       xor       ecx,ecx
       mov       [rbp-48],rcx
       mov       rcx,[rbp-50]
       mov       rcx,[rcx+18]
       lea       rdx,[rbp-50]
       mov       [rbp-98],rdx
       mov       [rbp-90],rcx
       lea       rcx,[rbp-98]
       lea       rdx,[rbp-48]
       mov       rax,7FFC10788420
       mov       [rbp-78],rax
       lea       rax,[M03_L03]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFC700A6D10
       call      rax
M03_L03:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFC704FF778],0
       je        short M03_L04
       call      qword ptr [7FFC704ED608]; CORINFO_HELP_STOP_FOR_GC
M03_L04:
       mov       rcx,[rbp-80]
       mov       [rsi+8],rcx
       mov       rbx,[rbp-48]
       xor       ecx,ecx
       mov       [rbp-48],rcx
       mov       r14,[rbp-0A8]
       lea       rcx,[r14+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
       mov       rbx,[rbp+10]
M03_L05:
       cmp       rax,rbx
       sete      cl
       mov       rdi,[rbp-0A0]
       mov       [rdi+9C],cl
       mov       rcx,[rbx+10]
       mov       rdx,rdi
       xor       r8d,r8d
       call      00007FFC701B9AA0
       mov       rdx,rax
       test      rdx,rdx
       je        short M03_L06
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache
       cmp       [rdx],rcx
       jne       short M03_L11
M03_L06:
       test      rdx,rdx
       cmovne    rdi,rdx
M03_L07:
       mov       rax,rdi
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
M03_L08:
       mov       [rbp-40],rbx
       lea       rcx,[rbp-40]
       mov       edx,1
       call      qword ptr [7FFC10C5C4B0]; System.RuntimeTypeHandle.GetGCHandle(System.Runtime.InteropServices.GCHandleType)
       mov       rdx,rax
       lea       rcx,[rbx+10]
       xor       eax,eax
       lock cmpxchg [rcx],rdx
       test      rax,rax
       je        near ptr M03_L00
       lea       rcx,[rbp-40]
       call      qword ptr [7FFC10C56E08]
       jmp       near ptr M03_L00
M03_L09:
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M03_L10:
       mov       [rbp+10],rbx
       mov       rcx,rbx
       call      qword ptr [7FFC10765710]; System.RuntimeTypeHandle.<GetModule>g__GetModuleWorker|48_0(System.RuntimeType)
       mov       r14,rax
       mov       rbx,[rbp+10]
       jmp       near ptr M03_L02
M03_L11:
       mov       rdx,rax
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
; Total bytes of code 566
```
```assembly
; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].GetMemberList(MemberListType, System.String, CacheType)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       rsi,r8
       mov       edi,r9d
       cmp       edx,1
       je        short M04_L00
       cmp       edx,2
       je        short M04_L04
       cmp       byte ptr [rbx+18],0
       je        near ptr M04_L08
       mov       rax,[rbx+8]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M04_L00:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+40]
       test      rdx,rdx
       je        short M04_L01
       jmp       short M04_L02
M04_L01:
       mov       rdx,7FFC10CA1148
       call      qword ptr [7FFC1059F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M04_L02:
       lea       rcx,[rbx+20]
       mov       r8,rsi
       call      qword ptr [7FFC10767C90]; System.Reflection.CerHashtable`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Item(System.__Canon)
       test      rax,rax
       jne       short M04_L03
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r9d,edi
       mov       r8d,1
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFC10766910]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
M04_L03:
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M04_L04:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+40]
       test      rdx,rdx
       je        short M04_L05
       jmp       short M04_L06
M04_L05:
       mov       rdx,7FFC10CA1148
       call      qword ptr [7FFC1059F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M04_L06:
       lea       rcx,[rbx+28]
       mov       r8,rsi
       call      qword ptr [7FFC10767C90]; System.Reflection.CerHashtable`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Item(System.__Canon)
       test      rax,rax
       jne       short M04_L07
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r9d,edi
       mov       r8d,2
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFC10766910]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
M04_L07:
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M04_L08:
       mov       rcx,rbx
       mov       r9d,edi
       mov       r8d,edx
       xor       edx,edx
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFC10766910]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
; Total bytes of code 265
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       sub       rsp,28
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M05_L00
       lea       rax,[rcx+rdx*8+10]
       mov       rcx,[rcx]
       mov       rdx,[rcx+30]
       test      r8,r8
       je        short M05_L02
       cmp       rdx,[r8]
       je        short M05_L01
       mov       r10,offset MT_System.Object[]
       cmp       rcx,r10
       je        short M05_L01
       mov       rcx,rax
       add       rsp,28
       jmp       qword ptr [7FFC10766EC8]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
M05_L00:
       call      qword ptr [7FFC10C543A8]
       int       3
M05_L01:
       mov       rcx,rax
       mov       rdx,r8
       add       rsp,28
       jmp       near ptr 00007FFC701E9D90
M05_L02:
       xor       ecx,ecx
       mov       [rax],rcx
       add       rsp,28
       ret
; Total bytes of code 94
```
```assembly
; System.RuntimeType+ListBuilder`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rdx
       mov       rbx,rcx
       mov       rcx,rdx
       mov       esi,[rbx+10]
       test      esi,esi
       je        short M06_L03
       cmp       esi,1
       je        near ptr M06_L08
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       cmp       qword ptr [rdx+8],38
       jle       short M06_L02
       mov       rdx,[rdx+38]
       test      rdx,rdx
       je        short M06_L02
M06_L00:
       test      esi,esi
       jl        near ptr M06_L11
       mov       rdi,[rbx]
       test      rdi,rdi
       je        near ptr M06_L12
       cmp       [rdi+8],esi
       jne       near ptr M06_L15
M06_L01:
       mov       eax,[rbx+10]
       mov       [rbx+14],eax
       mov       rax,[rbx]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M06_L02:
       mov       rdx,7FFC10C7F7E0
       call      qword ptr [7FFC1059F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       short M06_L00
M06_L03:
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       cmp       qword ptr [rdx+8],48
       jle       short M06_L04
       mov       rax,[rdx+48]
       test      rax,rax
       je        short M06_L04
       mov       rcx,rax
       jmp       short M06_L05
M06_L04:
       mov       rdx,7FFC10CA1270
       call      qword ptr [7FFC1059F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M06_L05:
       mov       rdx,[rcx+18]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M06_L06
       jmp       short M06_L07
M06_L06:
       mov       rdx,7FFC10C7CF28
       call      qword ptr [7FFC1059F630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdx,rax
M06_L07:
       mov       rcx,rdx
       call      qword ptr [7FFC10595728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rax]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M06_L08:
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       cmp       qword ptr [rdx+8],40
       jle       short M06_L09
       mov       rax,[rdx+40]
       test      rax,rax
       je        short M06_L09
       mov       rcx,rax
       jmp       short M06_L10
M06_L09:
       mov       rdx,7FFC10C7F800
       call      qword ptr [7FFC1059F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M06_L10:
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rsi,rax
       mov       r8,[rbx+8]
       mov       rcx,rsi
       xor       edx,edx
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M06_L11:
       mov       ecx,45
       mov       edx,0D
       call      qword ptr [7FFC10B15938]
       int       3
M06_L12:
       mov       rcx,[rdx+18]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M06_L13
       jmp       short M06_L14
M06_L13:
       mov       rcx,rdx
       mov       rdx,7FFC10CA0A50
       call      qword ptr [7FFC1059F630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M06_L14:
       mov       edx,esi
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdx,rax
       mov       rcx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       near ptr M06_L01
M06_L15:
       mov       rcx,[rdx+18]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M06_L16
       jmp       short M06_L17
M06_L16:
       mov       rcx,rdx
       mov       rdx,7FFC10CA0A50
       call      qword ptr [7FFC1059F630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M06_L17:
       mov       edx,esi
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbp,rax
       lea       rcx,[rbp+10]
       lea       rdx,[rdi+10]
       mov       r8d,[rdi+8]
       cmp       esi,r8d
       cmovg     esi,r8d
       mov       r8d,esi
       shl       r8,3
       call      qword ptr [7FFC105957A0]; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rbx
       mov       rdx,rbp
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       near ptr M06_L01
; Total bytes of code 486
```
```assembly
; System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rdx
       mov       ebx,r8d
       test      ebx,ebx
       jl        short M07_L01
       mov       rdi,[rsi]
       test      rdi,rdi
       je        short M07_L02
       cmp       [rdi+8],ebx
       jne       short M07_L05
M07_L00:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M07_L01:
       mov       ecx,45
       mov       edx,0D
       call      qword ptr [7FFC10B15938]
       int       3
M07_L02:
       mov       rdx,[rcx+18]
       mov       rax,[rdx+18]
       test      rax,rax
       je        short M07_L03
       mov       rcx,rax
       jmp       short M07_L04
M07_L03:
       mov       rdx,7FFC10CA0A50
       call      qword ptr [7FFC1059F630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M07_L04:
       mov       edx,ebx
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdx,rax
       mov       rcx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       short M07_L00
M07_L05:
       mov       rdx,[rcx+18]
       mov       rax,[rdx+18]
       test      rax,rax
       je        short M07_L06
       mov       rcx,rax
       jmp       short M07_L07
M07_L06:
       mov       rdx,7FFC10CA0A50
       call      qword ptr [7FFC1059F630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M07_L07:
       mov       edx,ebx
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbp,rax
       lea       rcx,[rbp+10]
       lea       rdx,[rdi+10]
       mov       r8d,[rdi+8]
       cmp       ebx,r8d
       cmovg     ebx,r8d
       mov       r8d,ebx
       shl       r8,3
       call      qword ptr [7FFC105957A0]; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rsi
       mov       rdx,rbp
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       near ptr M07_L00
; Total bytes of code 214
```
```assembly
; DotNetTips.Spargine.Core.Enumeration+<GetAll>d__18`1[[System.__Canon, System.Private.CoreLib]].System.IDisposable.Dispose()
       xor       eax,eax
       mov       [rcx+10],rax
       mov       dword ptr [rcx+18],0FFFFFFFE
       ret
; Total bytes of code 14
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
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FFC7000FD78]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       ecx,ebx
       and       ecx,0FFFFFF
       mov       edx,ecx
       mov       r8d,ebx
       sar       r8d,18
       jne       short M10_L01
       cmp       [rax],ecx
       jle       short M10_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M10_L03
M10_L00:
       add       rsp,20
       pop       rbx
       ret
M10_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M10_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M10_L00
M10_L02:
       cmp       [rax+4],edx
       jle       short M10_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M10_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M10_L03
       jmp       short M10_L00
M10_L03:
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
       call      qword ptr [7FFC6FFF77D0]
       mov       rbx,rax
       mov       rsi,rbx
       call      qword ptr [7FFC7000EA88]
       mov       rdx,rax
       test      rsi,rsi
       je        short M11_L00
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFC7000FC28]
       mov       rax,[rbx]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M11_L00:
       call      qword ptr [7FFC7000D468]
       int       3
; Total bytes of code 61
```
```assembly
; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider)
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rax,offset MT_System.Globalization.CultureInfo
       cmp       [rbx],rax
       jne       short M12_L00
       mov       rax,[rbx+18]
       test      rax,rax
       je        short M12_L00
       add       rsp,20
       pop       rbx
       ret
M12_L00:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Globalization.NumberFormatInfo
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       short M12_L01
       mov       rcx,rbx
       mov       r11,7FFC104E0CD0
       mov       rdx,1C06F281518
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,offset MT_System.Globalization.NumberFormatInfo
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       short M12_L01
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFC1059D2A8]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
M12_L01:
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 127
```
```assembly
; System.Globalization.NumberFormatInfo.get_CurrentInfo()
       push      rbx
       sub       rsp,20
       call      qword ptr [7FFC7000E9B0]; Precode of System.Globalization.CultureInfo.get_CurrentCulture()
       mov       rbx,rax
       cmp       byte ptr [rbx+61],0
       jne       short M13_L00
       mov       rax,[rbx+18]
       test      rax,rax
       je        short M13_L00
       add       rsp,20
       pop       rbx
       ret
M13_L00:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       call      qword ptr [7FFC6FFF7040]; Precode of System.RuntimeTypeHandle.GetRuntimeTypeFromHandle(IntPtr)
       mov       rdx,rax
       mov       rcx,rbx
       lea       r11,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       call      qword ptr [r11]
       mov       rcx,rax
       call      qword ptr [7FFC700064D8]
       nop
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 80
```
```assembly
; System.Number.<UInt32ToDecStrForKnownSmallNumber>g__CreateAndCacheString|50_0(UInt32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       ebx,ecx
       mov       edx,ebx
       or        edx,1
       lzcnt     edx,edx
       xor       edx,1F
       mov       ecx,ebx
       mov       rax,7FFC6F38C0B8
       add       rcx,[rax+rdx*8]
       sar       rcx,20
       movsxd    rsi,ecx
       mov       rdx,rsi
       mov       rcx,offset MT_System.String
       call      00007FFC701EAFA0
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M14_L05
       lea       rcx,[rdi+0C]
       mov       [rsp+28],rcx
       mov       rcx,[rsp+28]
M14_L00:
       lea       rcx,[rcx+rsi*2]
       mov       edx,ebx
       cmp       edx,0A
       jb        near ptr M14_L04
       cmp       ebx,64
       jb        short M14_L02
       mov       rax,1C06F2820A4
M14_L01:
       add       rcx,0FFFFFFFFFFFFFFFC
       mov       r8d,edx
       imul      r8,51EB851F
       shr       r8,25
       imul      r10d,r8d,64
       sub       edx,r10d
       mov       r10,rax
       shl       edx,2
       mov       edx,[r10+rdx]
       mov       [rcx],edx
       cmp       r8d,64
       mov       edx,r8d
       jae       short M14_L01
M14_L02:
       cmp       edx,0A
       jb        short M14_L04
       add       rcx,0FFFFFFFFFFFFFFFC
       mov       rax,1C06F2820A4
       shl       edx,2
       mov       edx,[rax+rdx]
       mov       [rcx],edx
M14_L03:
       xor       ecx,ecx
       mov       [rsp+28],rcx
       mov       rcx,17FDA0002B8
       mov       rcx,[rcx]
       cmp       ebx,12C
       jae       short M14_L06
       mov       edx,ebx
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M14_L04:
       add       edx,30
       mov       [rcx-2],dx
       jmp       short M14_L03
M14_L05:
       xor       edi,edi
       xor       ecx,ecx
       jmp       near ptr M14_L00
M14_L06:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 276
```
```assembly
; System.Number.UInt32ToDecStr_NoSmallNumberCheck(UInt32)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       ebx,ecx
       mov       ecx,ebx
       or        ecx,1
       lzcnt     ecx,ecx
       xor       ecx,1F
       mov       eax,ebx
       mov       rdx,7FFC6F38C0B8
       add       rax,[rdx+rcx*8]
       sar       rax,20
       movsxd    rsi,eax
       mov       rcx,rsi
       call      qword ptr [7FFC10596670]; System.String.FastAllocateString(IntPtr)
       mov       rdi,rax
       test      rdi,rdi
       je        short M15_L00
       mov       rcx,7FFC10D7F9E8
       call      CORINFO_HELP_COUNTPROFILE32
       lea       rcx,[rdi+0C]
       mov       [rsp+20],rcx
       mov       rbp,[rsp+20]
       jmp       short M15_L01
M15_L00:
       xor       edi,edi
       xor       ebp,ebp
M15_L01:
       mov       rcx,7FFC10D7F9EC
       call      CORINFO_HELP_COUNTPROFILE32
       lea       rax,[rbp+rsi*2]
       cmp       ebx,0A
       jb        short M15_L05
       cmp       ebx,64
       jb        short M15_L03
       mov       rcx,1C06F2820A4
M15_L02:
       add       rax,0FFFFFFFFFFFFFFFC
       mov       edx,ebx
       imul      rdx,51EB851F
       shr       rdx,25
       imul      r8d,edx,64
       sub       ebx,r8d
       mov       r8,rcx
       shl       ebx,2
       mov       r10d,ebx
       mov       r8d,[r8+r10]
       mov       [rax],r8d
       cmp       edx,64
       mov       ebx,edx
       jae       short M15_L02
M15_L03:
       cmp       ebx,0A
       jb        short M15_L05
       add       rax,0FFFFFFFFFFFFFFFC
       mov       rcx,1C06F2820A4
       lea       edx,[rbx*4]
       mov       ecx,[rcx+rdx]
       mov       [rax],ecx
M15_L04:
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rax,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M15_L05:
       lea       ecx,[rbx+30]
       mov       [rax-2],cx
       jmp       short M15_L04
; Total bytes of code 250
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
       call      qword ptr [7FFC6FFF8080]
       mov       rcx,[rax]
       imul      edx,edi,0B
       add       edx,esi
       mov       eax,100
       cmp       edx,100
       cmovle    edx,eax
       cmp       [rcx],ecx
       call      qword ptr [7FFC70017960]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
       mov       [rbx+8],rax
       test      rax,rax
       je        short M16_L01
       lea       rcx,[rax+10]
       mov       eax,[rax+8]
M16_L00:
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
M16_L01:
       xor       ecx,ecx
       xor       eax,eax
       jmp       short M16_L00
; Total bytes of code 102
```
```assembly
; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendLiteral(System.String)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       lea       r8,[rbx+18]
       mov       ecx,[rbx+10]
       mov       eax,[r8+8]
       cmp       ecx,eax
       ja        short M17_L00
       mov       r8,[r8]
       mov       r10d,ecx
       lea       r10,[r8+r10*2]
       sub       eax,ecx
       mov       esi,[rdx+8]
       cmp       esi,eax
       ja        short M17_L01
       mov       r8d,esi
       add       r8,r8
       add       rdx,0C
       mov       rcx,r10
       call      qword ptr [7FFC7000B980]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       [rbx+10],esi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M17_L00:
       call      qword ptr [7FFC7000D310]
       int       3
M17_L01:
       mov       rcx,rbx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [rax]
; Total bytes of code 98
```
```assembly
; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted(System.String)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       cmp       byte ptr [rbx+14],0
       jne       short M18_L01
       test      rdx,rdx
       je        short M18_L01
       lea       r8,[rbx+18]
       mov       ecx,[rbx+10]
       mov       eax,[r8+8]
       cmp       ecx,eax
       ja        short M18_L00
       mov       r8,[r8]
       mov       r10d,ecx
       lea       r10,[r8+r10*2]
       sub       eax,ecx
       mov       esi,[rdx+8]
       cmp       esi,eax
       ja        short M18_L01
       mov       r8d,esi
       add       r8,r8
       add       rdx,0C
       mov       rcx,r10
       call      qword ptr [7FFC7000B980]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       [rbx+10],esi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M18_L00:
       call      qword ptr [7FFC7000D310]
       int       3
M18_L01:
       mov       rcx,rbx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [rax]
; Total bytes of code 109
```
```assembly
; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rsi
       push      rbx
       sub       rsp,58
       xor       eax,eax
       mov       [rsp+28],rax
       xorps     xmm4,xmm4
       movaps    [rsp+30],xmm4
       mov       [rsp+40],rax
       mov       [rsp+50],rdx
       mov       rbx,rcx
       mov       rcx,rdx
       mov       rsi,r8
       cmp       byte ptr [rbx+14],0
       jne       near ptr M19_L05
       test      rsi,rsi
       je        near ptr M19_L06
       mov       rcx,rsi
       call      qword ptr [7FFC700051F0]
       test      rax,rax
       jne       short M19_L01
       mov       rcx,rsi
       lea       r11,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       call      qword ptr [r11]
       mov       rdx,rax
M19_L00:
       test      rdx,rdx
       je        near ptr M19_L06
       lea       r8,[rbx+18]
       mov       ecx,[rbx+10]
       mov       eax,[r8+8]
       cmp       ecx,eax
       ja        near ptr M19_L07
       mov       r8,[r8]
       mov       r10d,ecx
       lea       r10,[r8+r10*2]
       sub       eax,ecx
       mov       esi,[rdx+8]
       cmp       esi,eax
       ja        near ptr M19_L08
       mov       r8d,esi
       add       r8,r8
       add       rdx,0C
       mov       rcx,r10
       call      qword ptr [7FFC7000B980]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       [rbx+10],esi
       jmp       near ptr M19_L06
M19_L01:
       mov       rcx,rsi
       call      qword ptr [7FFC70005228]
       test      rax,rax
       je        near ptr M19_L04
       mov       rcx,rsi
       call      qword ptr [7FFC70006468]
       mov       rsi,rax
M19_L02:
       mov       rcx,rsi
       lea       rdx,[rbx+18]
       mov       r9d,[rbx+10]
       mov       r8d,[rdx+8]
       cmp       r9d,r8d
       ja        near ptr M19_L07
       mov       rdx,[rdx]
       mov       r11d,r9d
       lea       rdx,[rdx+r11*2]
       sub       r8d,r9d
       mov       [rsp+38],rdx
       mov       [rsp+40],r8d
       xor       edx,edx
       mov       [rsp+28],rdx
       mov       [rsp+30],edx
       mov       rdx,[rbx]
       mov       [rsp+20],rdx
       lea       rdx,[rsp+38]
       lea       r9,[rsp+28]
       lea       r8,[rsp+48]
       lea       r11,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       call      qword ptr [r11]
       test      eax,eax
       jne       short M19_L03
       mov       rcx,rbx
       call      qword ptr [7FFC70013078]
       jmp       short M19_L02
M19_L03:
       mov       ecx,[rsp+48]
       add       [rbx+10],ecx
       jmp       short M19_L06
M19_L04:
       mov       rcx,rsi
       call      qword ptr [7FFC70006460]
       mov       rcx,rax
       mov       r8,[rbx]
       lea       r11,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       xor       edx,edx
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       near ptr M19_L00
M19_L05:
       call      qword ptr [7FFC6FFFE130]
       mov       rdx,rax
       mov       rcx,rbx
       mov       r8,rsi
       xor       r9d,r9d
       call      qword ptr [7FFC70022780]
M19_L06:
       nop
       add       rsp,58
       pop       rbx
       pop       rsi
       ret
M19_L07:
       call      qword ptr [7FFC7000D310]
       int       3
M19_L08:
       mov       rcx,rbx
       call      qword ptr [7FFC70013050]
       jmp       short M19_L06
; Total bytes of code 397
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
       ja        short M20_L01
       mov       rcx,[rcx]
       mov       [rsp+28],rcx
       mov       [rsp+30],eax
       lea       rcx,[rsp+28]
       call      qword ptr [7FFC70009B88]; Precode of System.String.Ctor(System.ReadOnlySpan`1<Char>)
       mov       rdi,rax
       mov       rbp,[rbx+8]
       xor       eax,eax
       mov       [rbx+8],rax
       mov       [rsi],rax
       mov       [rsi+8],rax
       mov       [rbx+10],eax
       test      rbp,rbp
       je        short M20_L00
       call      qword ptr [7FFC6FFF8080]
       mov       rcx,[rax]
       mov       rdx,rbp
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFC70017968]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
M20_L00:
       mov       rax,rdi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M20_L01:
       call      qword ptr [7FFC7000D310]
       int       3
; Total bytes of code 126
```

## .NET 10.0.3 (10.0.3, 10.0.326.7603), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.EnumerationBenchmark.GetAll()
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
       mov       [rbp-58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp-40],rax
       mov       [rbp+10],rcx
       mov       rsi,offset MT_DotNetTips.Spargine.Core.Enumeration+<GetAll>d__18<DotNetTips.Spargine.Extensions.NumericFormat>
       mov       rcx,rsi
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+18],0FFFFFFFE
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rdi+1C],eax
       cmp       dword ptr [rdi+18],0FFFFFFFE
       jne       near ptr M00_L51
       mov       r14d,[rdi+1C]
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       cmp       r14d,eax
       jne       near ptr M00_L51
       xor       ecx,ecx
       mov       [rdi+18],ecx
M00_L00:
       mov       rcx,rdi
       mov       [rbp-60],rcx
M00_L01:
       cmp       [rcx],rsi
       jne       near ptr M00_L45
       mov       rdi,rcx
       mov       [rbp-68],rdi
       mov       eax,[rdi+18]
       test      eax,eax
       je        near ptr M00_L16
       cmp       eax,1
       jne       near ptr M00_L49
       mov       dword ptr [rdi+18],0FFFFFFFF
M00_L02:
       mov       rdi,[rbp-68]
       inc       dword ptr [rdi+20]
M00_L03:
       mov       ecx,[rdi+20]
       mov       rax,[rdi+10]
       cmp       ecx,[rax+8]
       jge       near ptr M00_L30
       cmp       ecx,[rax+8]
       jae       near ptr M00_L48
       mov       ecx,ecx
       mov       r14,[rax+rcx*8+10]
       mov       r15,r14
       mov       rcx,offset MT_System.Reflection.RtFieldInfo
       cmp       [r15],rcx
       jne       near ptr M00_L44
       mov       [rbp-70],r15
       cmp       qword ptr [r15+30],0
       jne       near ptr M00_L13
       mov       rcx,offset MT_System.Reflection.FieldAccessor
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       [rbp-78],r13
       lea       rcx,[r13+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       r14,[r14+10]
       cmp       [r14],r14b
M00_L04:
       mov       rcx,offset MT_System.RuntimeType
       cmp       [r14],rcx
       jne       near ptr M00_L43
       mov       [rbp-80],r14
       mov       rcx,[r14+18]
       mov       rax,7FFC701A4990
       call      rax
       movzx     ebx,al
       mov       r14,[rbp-80]
       cmp       dword ptr [7FFC704FF778],0
       jne       near ptr M00_L41
M00_L05:
       cmp       ebx,1D
       ja        short M00_L06
       mov       ecx,1FEF7FFF
       bt        ecx,ebx
       jae       near ptr M00_L42
M00_L06:
       cmp       ebx,10
       sete      dil
       movzx     edi,dil
M00_L07:
       test      edi,edi
       je        short M00_L08
       mov       rcx,r14
       mov       rax,[r14]
       mov       rax,[rax+68]
       call      qword ptr [rax+8]
       mov       r14,rax
       jmp       short M00_L04
M00_L08:
       mov       rcx,r14
       mov       rax,[r14]
       mov       rax,[rax+98]
       call      qword ptr [rax+8]
       test      rax,rax
       je        near ptr M00_L47
       mov       rcx,rax
       call      00007FFC701AEBE0
       test      eax,eax
       jne       short M00_L11
       mov       r13,[rbp-78]
       mov       rcx,[r13+8]
       mov       rcx,[rcx+10]
       mov       rdx,[rcx+18]
       test      dl,2
       je        short M00_L09
       xor       eax,eax
       jmp       short M00_L10
M00_L09:
       mov       eax,[rdx]
       and       eax,0F0000
       cmp       eax,50000
       sete      al
       movzx     eax,al
M00_L10:
       test      eax,eax
       jne       short M00_L11
       mov       dword ptr [r13+20],0F
       jmp       short M00_L12
M00_L11:
       mov       r13,[rbp-78]
       mov       dword ptr [r13+20],11
M00_L12:
       mov       r15,[rbp-70]
       lea       rcx,[r15+30]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
M00_L13:
       mov       rcx,[r15+30]
       xor       edx,edx
       cmp       [rcx],ecx
       call      qword ptr [7FFC109378E8]; System.Reflection.FieldAccessor.GetValue(System.Object)
       mov       rdx,rax
M00_L14:
       test      rdx,rdx
       je        near ptr M00_L02
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.NumericFormat
       cmp       [rdx],rcx
       jne       near ptr M00_L02
       mov       rdi,[rbp-68]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rdi+18],1
       mov       rcx,[rbp-60]
       mov       r14,[rcx+8]
M00_L15:
       mov       [rbp-40],r14
       mov       rbx,[rbp+10]
       mov       rdi,[rbx+60]
       mov       rdx,[rbp-40]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rdi+8],rcx
       mov       [rbp+10],rbx
       mov       rcx,[rbp-60]
       jmp       near ptr M00_L01
M00_L16:
       mov       dword ptr [rdi+18],0FFFFFFFF
       mov       rax,1C6B8B61178
       mov       r14,[rax]
       test      r14,r14
       jne       short M00_L17
       mov       rcx,2074DFA06C0
       call      qword ptr [7FFC107856C8]; System.RuntimeType.InitializeCache()
       mov       r15,rax
       jmp       short M00_L18
M00_L17:
       mov       r15,r14
M00_L18:
       cmp       [r15],r15b
       lea       r14,[r15+50]
       mov       rax,[r14]
       test      rax,rax
       je        near ptr M00_L32
M00_L19:
       cmp       byte ptr [rax+18],0
       je        near ptr M00_L33
       mov       r14,[rax+8]
M00_L20:
       mov       r15d,[r14+8]
       mov       edx,r15d
       xor       r8d,r8d
       mov       [rbp-58],r8
       mov       [rbp-50],r8
       mov       [rbp-48],r8d
       mov       [rbp-44],edx
       test      r15d,r15d
       jle       short M00_L25
       add       r14,10
M00_L21:
       mov       r13,[r14]
       mov       edx,[r13+18]
       mov       r8d,edx
       and       r8d,18
       cmp       r8d,edx
       jne       short M00_L24
       cmp       dword ptr [rbp-48],0
       je        near ptr M00_L29
       cmp       dword ptr [rbp-48],1
       je        near ptr M00_L27
       mov       edx,[rbp-44]
       cmp       edx,[rbp-48]
       je        near ptr M00_L35
M00_L22:
       movsxd    rdx,dword ptr [rbp-48]
       mov       rcx,[rbp-58]
       mov       r8,r13
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
M00_L23:
       mov       edx,[rbp-48]
       inc       edx
       mov       [rbp-48],edx
M00_L24:
       add       r14,8
       dec       r15d
       jne       short M00_L21
M00_L25:
       mov       r14,[rbp-58]
       mov       r15,[rbp-50]
       mov       r13d,[rbp-48]
       test      r13d,r13d
       je        near ptr M00_L36
       cmp       r13d,1
       je        near ptr M00_L37
       test      r13d,r13d
       jl        near ptr M00_L46
       test      r14,r14
       je        near ptr M00_L38
       cmp       [r14+8],r13d
       jne       near ptr M00_L39
M00_L26:
       lea       rcx,[rdi+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rdi+20],ecx
       jmp       near ptr M00_L03
M00_L27:
       cmp       dword ptr [rbp-44],2
       jl        near ptr M00_L34
M00_L28:
       movsxd    rdx,dword ptr [rbp-44]
       mov       rcx,offset MT_System.Reflection.FieldInfo[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       [rbp-58],rax
       mov       rcx,[rbp-58]
       mov       r8,[rbp-50]
       xor       edx,edx
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       near ptr M00_L22
M00_L29:
       mov       [rbp-50],r13
       jmp       near ptr M00_L23
M00_L30:
       xor       ecx,ecx
       mov       rdi,[rbp-68]
       mov       [rdi+10],rcx
       jmp       near ptr M00_L49
M00_L31:
       mov       rcx,[rbp-60]
       mov       r11,7FFC10500AC8
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L15
M00_L32:
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache+MemberInfoCache<System.Reflection.RuntimeFieldInfo>
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       lea       rcx,[r13+10]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r14
       mov       rdx,r13
       xor       r8d,r8d
       call      00007FFC7019B3A0
       test      rax,rax
       jne       near ptr M00_L19
       mov       rax,r13
       jmp       near ptr M00_L19
M00_L33:
       mov       rcx,rax
       xor       edx,edx
       xor       r8d,r8d
       mov       r9d,2
       call      qword ptr [7FFC10786910]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
       mov       r14,rax
       jmp       near ptr M00_L20
M00_L34:
       mov       dword ptr [rbp-44],4
       jmp       near ptr M00_L28
M00_L35:
       mov       r12d,[rbp-44]
       add       r12d,r12d
       lea       rdx,[rbp-58]
       mov       r8d,r12d
       mov       rcx,7FFC107D8FB8
       call      qword ptr [7FFC10786AD8]; System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
       mov       [rbp-44],r12d
       jmp       near ptr M00_L22
M00_L36:
       mov       rdx,1C6B9001BE0
       mov       r14,[rdx]
       jmp       near ptr M00_L26
M00_L37:
       mov       rcx,offset MT_System.Reflection.FieldInfo[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       mov       rcx,r14
       mov       r8,r15
       xor       edx,edx
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       near ptr M00_L26
M00_L38:
       mov       edx,r13d
       mov       rcx,offset MT_System.Reflection.FieldInfo[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       jmp       near ptr M00_L26
M00_L39:
       mov       edx,r13d
       mov       rcx,offset MT_System.Reflection.FieldInfo[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r15,rax
       lea       rcx,[r15+10]
       lea       rdx,[r14+10]
       mov       r8d,[r14+8]
       cmp       r13d,r8d
       jle       short M00_L40
       mov       r13d,r8d
M00_L40:
       mov       r8d,r13d
       shl       r8,3
       call      qword ptr [7FFC105B57A0]; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r14,r15
       jmp       near ptr M00_L26
M00_L41:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L05
M00_L42:
       mov       edi,1
       jmp       near ptr M00_L07
M00_L43:
       mov       rcx,r14
       mov       rax,[r14]
       mov       rax,[rax+68]
       call      qword ptr [rax]
       mov       edi,eax
       jmp       near ptr M00_L07
M00_L44:
       mov       rcx,r15
       xor       edx,edx
       mov       rax,[r15]
       mov       rax,[rax+58]
       call      qword ptr [rax]
       mov       rdx,rax
       jmp       near ptr M00_L14
M00_L45:
       mov       r11,7FFC10500AC0
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L31
       jmp       short M00_L49
M00_L46:
       mov       ecx,45
       mov       edx,0D
       call      qword ptr [7FFC10B35938]
       int       3
M00_L47:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFC10C76598]
       mov       r8,rax
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFC10C765B0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L48:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L49:
       mov       rcx,[rbp-60]
       cmp       [rcx],rsi
       jne       short M00_L52
       xor       r11d,r11d
       mov       [rcx+10],r11
       mov       dword ptr [rcx+18],0FFFFFFFE
M00_L50:
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
M00_L51:
       mov       rcx,rsi
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       xor       eax,eax
       mov       [rdi+18],eax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rdi+1C],eax
       jmp       near ptr M00_L00
M00_L52:
       mov       r11,7FFC10500AD0
       call      qword ptr [r11]
       jmp       short M00_L50
       sub       rsp,28
       vzeroupper
       mov       rsi,offset MT_DotNetTips.Spargine.Core.Enumeration+<GetAll>d__18<DotNetTips.Spargine.Extensions.NumericFormat>
       mov       rcx,[rbp-60]
       cmp       [rcx],rsi
       jne       short M00_L53
       xor       r11d,r11d
       mov       [rcx+10],r11
       mov       dword ptr [rcx+18],0FFFFFFFE
       jmp       short M00_L54
M00_L53:
       mov       r11,7FFC10500AD0
       call      qword ptr [r11]
M00_L54:
       nop
       add       rsp,28
       ret
; Total bytes of code 1605
```
```assembly
; System.Reflection.FieldAccessor.GetValue(System.Object)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       rsi,rdx
M01_L00:
       mov       ecx,[rbx+20]
       cmp       ecx,7
       jne       short M01_L02
       mov       rax,[rbx+10]
       mov       rax,[rax]
M01_L01:
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L02:
       cmp       ecx,11
       ja        short M01_L03
       mov       ecx,ecx
       lea       rax,[7FFC1066A910]
       mov       eax,[rax+rcx*4]
       lea       rdx,[M01_L00]
       add       rax,rdx
       jmp       rax
M01_L03:
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
       mov       rcx,[rbx+8]
       mov       rcx,[rcx+10]
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFC104FA578]; Precode of System.RuntimeType.IsInstanceOfType(System.Object)
       test      eax,eax
       jne       short M01_L04
       test      rsi,rsi
       jne       near ptr M01_L13
       jmp       near ptr M01_L12
M01_L04:
       cmp       [rsi],sil
       mov       rax,[rbx+10]
       mov       rax,[rsi+rax+8]
       jmp       short M01_L01
       mov       rcx,[rbx+8]
       mov       rcx,[rcx+10]
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFC104FA578]; Precode of System.RuntimeType.IsInstanceOfType(System.Object)
       test      eax,eax
       jne       short M01_L05
       test      rsi,rsi
       jne       near ptr M01_L13
       jmp       near ptr M01_L12
M01_L05:
       cmp       [rsi],sil
       mov       rdx,[rbx+10]
       lea       rdx,[rsi+rdx+8]
       mov       rcx,[rbx+18]
       call      qword ptr [7FFC10C76688]
       jmp       near ptr M01_L01
       mov       rcx,[rbx+8]
       mov       rcx,[rcx+10]
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFC104FA578]; Precode of System.RuntimeType.IsInstanceOfType(System.Object)
       test      eax,eax
       jne       short M01_L06
       test      rsi,rsi
       jne       near ptr M01_L13
       jmp       near ptr M01_L12
M01_L06:
       cmp       [rsi],sil
       mov       rcx,[rbx+10]
       mov       rsi,[rsi+rcx+8]
       mov       rcx,[rbx+8]
       mov       rdx,[rcx+28]
       test      rdx,rdx
       jne       short M01_L07
       call      qword ptr [7FFC10937870]; System.Reflection.RtFieldInfo.InitializeFieldType()
       mov       rdx,rax
M01_L07:
       mov       rcx,rsi
       call      qword ptr [7FFC10C76670]
       jmp       near ptr M01_L01
       mov       rcx,[rbx+18]
       mov       rdx,[rbx+10]
       call      qword ptr [7FFC10C76688]
       jmp       near ptr M01_L01
       mov       rcx,[rbx+18]
       mov       rdx,[rbx+10]
       mov       rdx,[rdx]
       cmp       [rdx],dl
       add       rdx,8
       call      qword ptr [7FFC10C76688]
       jmp       near ptr M01_L01
       mov       rcx,[rbx+10]
       mov       rsi,[rcx]
       mov       rcx,[rbx+8]
       mov       rdx,[rcx+28]
       test      rdx,rdx
       jne       short M01_L08
       call      qword ptr [7FFC10937870]; System.Reflection.RtFieldInfo.InitializeFieldType()
       mov       rdx,rax
M01_L08:
       mov       rcx,rsi
       call      qword ptr [7FFC10C76670]
       jmp       near ptr M01_L01
       mov       rcx,rbx
       call      qword ptr [7FFC10937900]; System.Reflection.FieldAccessor.IsStatic()
       test      eax,eax
       jne       short M01_L09
       mov       rcx,[rbx+8]
       mov       rcx,[rcx+10]
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFC104FA578]; Precode of System.RuntimeType.IsInstanceOfType(System.Object)
       test      eax,eax
       jne       short M01_L09
       test      rsi,rsi
       jne       near ptr M01_L13
       jmp       near ptr M01_L12
M01_L09:
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rdi,[rbx+8]
       mov       rcx,[rbx+8]
       mov       rdx,[rcx+28]
       test      rdx,rdx
       jne       short M01_L10
       call      qword ptr [7FFC10937870]; System.Reflection.RtFieldInfo.InitializeFieldType()
       mov       rdx,rax
M01_L10:
       mov       rcx,offset MT_System.RuntimeType
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       r8,rax
       lea       r9,[rsp+28]
       mov       [rsp+20],r9
       mov       r9,[rbx+8]
       mov       r9,[r9+10]
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFC10937918]; System.RuntimeFieldHandle.GetValue(System.Reflection.RtFieldInfo, System.Object, System.RuntimeType, System.RuntimeType, Boolean ByRef)
       mov       rsi,rax
       cmp       byte ptr [rsp+28],0
       je        short M01_L11
       mov       rcx,rbx
       call      qword ptr [7FFC10937930]; System.Reflection.FieldAccessor.Initialize()
M01_L11:
       mov       rax,rsi
       jmp       near ptr M01_L01
       mov       rcx,rbx
       call      qword ptr [7FFC10937900]; System.Reflection.FieldAccessor.IsStatic()
       test      eax,eax
       jne       short M01_L14
       mov       rcx,[rbx+8]
       mov       rcx,[rcx+10]
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFC104FA578]; Precode of System.RuntimeType.IsInstanceOfType(System.Object)
       test      eax,eax
       jne       short M01_L14
       test      rsi,rsi
       jne       short M01_L13
M01_L12:
       call      qword ptr [7FFC10C766A0]
       int       3
M01_L13:
       mov       rdx,[rbx+8]
       mov       rcx,rsi
       call      qword ptr [7FFC10C766B8]
       int       3
M01_L14:
       mov       dword ptr [rsp+28],1
       mov       rdi,[rbx+8]
       mov       rcx,[rbx+8]
       mov       rdx,[rcx+28]
       test      rdx,rdx
       jne       short M01_L15
       call      qword ptr [7FFC10937870]; System.Reflection.RtFieldInfo.InitializeFieldType()
       mov       rdx,rax
M01_L15:
       mov       rcx,offset MT_System.RuntimeType
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       r8,rax
       lea       r9,[rsp+28]
       mov       [rsp+20],r9
       mov       r9,[rbx+8]
       mov       r9,[r9+10]
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFC10937918]; System.RuntimeFieldHandle.GetValue(System.Reflection.RtFieldInfo, System.Object, System.RuntimeType, System.RuntimeType, Boolean ByRef)
       jmp       near ptr M01_L01
       mov       rcx,[rbx+8]
       cmp       [rcx],ecx
       call      qword ptr [7FFC107D8320]; Precode of System.Reflection.RuntimeFieldInfo.get_DeclaringType()
       test      rax,rax
       je        short M01_L16
       mov       rcx,[rbx+8]
       cmp       [rcx],ecx
       call      qword ptr [7FFC107D8320]; Precode of System.Reflection.RuntimeFieldInfo.get_DeclaringType()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+0B0]
       call      qword ptr [rax]
       test      eax,eax
       je        short M01_L16
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFC10C766D0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC10935D58]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L16:
       mov       rcx,[rbx+8]
       cmp       [rcx],ecx
       call      qword ptr [7FFC107D8320]; Precode of System.Reflection.RuntimeFieldInfo.get_DeclaringType()
       test      rax,rax
       je        short M01_L18
       mov       rcx,[rbx+8]
       mov       rdx,[rcx+28]
       test      rdx,rdx
       jne       short M01_L17
       call      qword ptr [7FFC10937870]; System.Reflection.RtFieldInfo.InitializeFieldType()
       mov       rdx,rax
M01_L17:
       mov       rcx,offset MT_System.RuntimeType
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFC1078D4A0]; System.RuntimeType.get_IsNullableOfT()
       test      eax,eax
       je        short M01_L18
       mov       rcx,offset MT_System.NotSupportedException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC10C766E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L18:
       mov       rcx,offset MT_System.FieldAccessException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFC10C76700]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 905
```
```assembly
; System.RuntimeType.InitializeCache()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,98
       vzeroupper
       lea       rbp,[rsp+0D0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       xor       eax,eax
       mov       [rbp-40],rax
       mov       rbx,rcx
       lea       rcx,[rbp-88]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rcx,rsp
       mov       [rbp-70],rcx
       mov       rcx,rbp
       mov       [rbp-60],rcx
       cmp       qword ptr [rbx+10],0
       je        near ptr M02_L08
M02_L00:
       mov       rcx,[rbx+10]
       mov       rdx,[rcx]
       mov       rdi,rdx
       test      rdi,rdi
       je        short M02_L01
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache
       cmp       [rdi],rcx
       jne       near ptr M02_L09
M02_L01:
       test      rdi,rdi
       jne       near ptr M02_L07
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       [rbp-0A0],rdi
       xor       ecx,ecx
       mov       [rdi+98],ecx
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbx
       call      00007FFC701ABEA0
       mov       r14,rax
       test      r14,r14
       je        near ptr M02_L10
M02_L02:
       mov       rax,[r14+8]
       test      rax,rax
       jne       near ptr M02_L05
       mov       [rbp+10],rbx
       mov       [rbp-0A8],r14
       mov       [rbp-50],r14
       xor       ecx,ecx
       mov       [rbp-48],rcx
       mov       rcx,[rbp-50]
       mov       rcx,[rcx+18]
       lea       rdx,[rbp-50]
       mov       [rbp-98],rdx
       mov       [rbp-90],rcx
       lea       rcx,[rbp-98]
       lea       rdx,[rbp-48]
       mov       rax,7FFC107A8420
       mov       [rbp-78],rax
       lea       rax,[M02_L03]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFC700A6D10
       call      rax
M02_L03:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFC704FF778],0
       je        short M02_L04
       call      qword ptr [7FFC704ED608]; CORINFO_HELP_STOP_FOR_GC
M02_L04:
       mov       rcx,[rbp-80]
       mov       [rsi+8],rcx
       mov       rbx,[rbp-48]
       xor       ecx,ecx
       mov       [rbp-48],rcx
       mov       r14,[rbp-0A8]
       lea       rcx,[r14+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
       mov       rbx,[rbp+10]
M02_L05:
       cmp       rax,rbx
       sete      cl
       mov       rdi,[rbp-0A0]
       mov       [rdi+9C],cl
       mov       rcx,[rbx+10]
       mov       rdx,rdi
       xor       r8d,r8d
       call      00007FFC701B9AA0
       mov       rdx,rax
       test      rdx,rdx
       je        short M02_L06
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache
       cmp       [rdx],rcx
       jne       short M02_L11
M02_L06:
       test      rdx,rdx
       cmovne    rdi,rdx
M02_L07:
       mov       rax,rdi
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
M02_L08:
       mov       [rbp-40],rbx
       lea       rcx,[rbp-40]
       mov       edx,1
       call      qword ptr [7FFC10C7D470]; System.RuntimeTypeHandle.GetGCHandle(System.Runtime.InteropServices.GCHandleType)
       mov       rdx,rax
       lea       rcx,[rbx+10]
       xor       eax,eax
       lock cmpxchg [rcx],rdx
       test      rax,rax
       je        near ptr M02_L00
       lea       rcx,[rbp-40]
       call      qword ptr [7FFC10C76D00]
       jmp       near ptr M02_L00
M02_L09:
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M02_L10:
       mov       [rbp+10],rbx
       mov       rcx,rbx
       call      qword ptr [7FFC10785710]; System.RuntimeTypeHandle.<GetModule>g__GetModuleWorker|48_0(System.RuntimeType)
       mov       r14,rax
       mov       rbx,[rbp+10]
       jmp       near ptr M02_L02
M02_L11:
       mov       rdx,rax
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
; Total bytes of code 566
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       sub       rsp,28
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M03_L00
       lea       rax,[rcx+rdx*8+10]
       mov       rcx,[rcx]
       mov       rdx,[rcx+30]
       test      r8,r8
       je        short M03_L02
       cmp       rdx,[r8]
       je        short M03_L01
       mov       r10,offset MT_System.Object[]
       cmp       rcx,r10
       je        short M03_L01
       mov       rcx,rax
       add       rsp,28
       jmp       qword ptr [7FFC10786EC8]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
M03_L00:
       call      qword ptr [7FFC10C741C8]
       int       3
M03_L01:
       mov       rcx,rax
       mov       rdx,r8
       add       rsp,28
       jmp       near ptr 00007FFC701E9D90
M03_L02:
       xor       ecx,ecx
       mov       [rax],rcx
       add       rsp,28
       ret
; Total bytes of code 94
```
```assembly
; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,50
       lea       rbp,[rsp+30]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rbp+8],xmm4
       xor       eax,eax
       mov       [rbp+18],rax
       mov       rax,0B2074E01FC68
       mov       [rbp],rax
       mov       rsi,rcx
       mov       rbx,rdx
       mov       edi,r8d
       mov       r14d,r9d
       test      rbx,rbx
       je        short M04_L00
       cmp       dword ptr [rbx+8],0
       jne       short M04_L03
M04_L00:
       xor       r8d,r8d
       mov       [rbp+8],r8
       mov       [rbp+10],r8d
       mov       [rsp+20],r14d
       lea       r8,[rbp+8]
       mov       rcx,rsi
       mov       r9d,edi
       mov       rdx,2074DF90008
       call      qword ptr [7FFC10786928]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].GetListByName(System.String, System.Span`1<Byte>, MemberListType, CacheType)
       mov       [rbp+18],rax
M04_L01:
       lea       rdx,[rbp+18]
       mov       rcx,rsi
       mov       r8,rbx
       mov       r9d,edi
       call      qword ptr [7FFC10786B50]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Insert(System.__Canon[] ByRef, System.String, MemberListType)
       mov       rax,[rbp+18]
       mov       r8,0B2074E01FC68
       cmp       [rbp],r8
       je        short M04_L02
       call      CORINFO_HELP_FAIL_FAST
M04_L02:
       nop
       lea       rsp,[rbp+20]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M04_L03:
       cmp       r14d,1
       jne       short M04_L04
       cmp       word ptr [rbx+0C],2E
       je        short M04_L04
       cmp       word ptr [rbx+0C],2A
       jne       short M04_L00
M04_L04:
       mov       rcx,1C6B9000108
       mov       rcx,[rcx]
       mov       rdx,rbx
       call      qword ptr [7FFC106BCD38]; Precode of System.Text.UTF8Encoding.GetByteCount(System.String)
       cmp       eax,400
       jbe       short M04_L05
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       r8,[rax+10]
       mov       eax,[rax+8]
       jmp       short M04_L07
M04_L05:
       mov       r8d,eax
       test      r8,r8
       je        short M04_L07
       mov       rdx,r8
       add       rdx,0F
       and       rdx,0FFFFFFFFFFFFFFF0
       add       rsp,30
       neg       rdx
       add       rdx,rsp
       jb        short M04_L06
       xor       edx,edx
M04_L06:
       test      [rsp],esp
       sub       rsp,1000
       cmp       rsp,rdx
       jae       short M04_L06
       mov       rsp,rdx
       test      [rsp],esp
       sub       rsp,30
       lea       r8,[rsp+30]
M04_L07:
       mov       [rbp+8],r8
       mov       [rbp+10],eax
       mov       [rsp+20],r14d
       lea       r8,[rbp+8]
       mov       rdx,rbx
       mov       rcx,rsi
       mov       r9d,edi
       call      qword ptr [7FFC10786928]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].GetListByName(System.String, System.Span`1<Byte>, MemberListType, CacheType)
       mov       [rbp+18],rax
       jmp       near ptr M04_L01
; Total bytes of code 348
```
```assembly
; System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rdx
       mov       ebx,r8d
       test      ebx,ebx
       jl        short M05_L01
       mov       rdi,[rsi]
       test      rdi,rdi
       je        short M05_L02
       cmp       [rdi+8],ebx
       jne       short M05_L05
M05_L00:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M05_L01:
       mov       ecx,45
       mov       edx,0D
       call      qword ptr [7FFC10B35938]
       int       3
M05_L02:
       mov       rdx,[rcx+18]
       mov       rax,[rdx+18]
       test      rax,rax
       je        short M05_L03
       mov       rcx,rax
       jmp       short M05_L04
M05_L03:
       mov       rdx,7FFC10CC09C0
       call      qword ptr [7FFC105BF630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M05_L04:
       mov       edx,ebx
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdx,rax
       mov       rcx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       short M05_L00
M05_L05:
       mov       rdx,[rcx+18]
       mov       rax,[rdx+18]
       test      rax,rax
       je        short M05_L06
       mov       rcx,rax
       jmp       short M05_L07
M05_L06:
       mov       rdx,7FFC10CC09C0
       call      qword ptr [7FFC105BF630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M05_L07:
       mov       edx,ebx
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbp,rax
       lea       rcx,[rbp+10]
       lea       rdx,[rdi+10]
       mov       r8d,[rdi+8]
       cmp       ebx,r8d
       cmovg     ebx,r8d
       mov       r8d,ebx
       shl       r8,3
       call      qword ptr [7FFC105B57A0]; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rsi
       mov       rdx,rbp
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       near ptr M05_L00
; Total bytes of code 214
```
```assembly
; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       sub       rsp,28
       cmp       r8,4000
       ja        short M06_L02
       call      00007FFC70192CC0
       cmp       dword ptr [7FFC704FF778],0
       jne       short M06_L01
M06_L00:
       add       rsp,28
       ret
M06_L01:
       call      CORINFO_HELP_POLL_GC
       jmp       short M06_L00
M06_L02:
       add       rsp,28
       jmp       qword ptr [7FFC10B3DBC0]
; Total bytes of code 49
```

## .NET 10.0.3 (10.0.3, 10.0.326.7603), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.EnumerationBenchmark.TryFromDisplayName()
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
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-0B0],ymm4
       vmovdqu   ymmword ptr [rbp-90],ymm4
       vmovdqu   ymmword ptr [rbp-70],ymm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp+10],rcx
       mov       rcx,1CB28C02100
       mov       rcx,[rcx]
       mov       rbx,[rcx+8]
       mov       rsi,rbx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Enumeration+<>c__DisplayClass19_0<DotNetTips.Spargine.Extensions.NumericFormat>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        near ptr M00_L43
       xor       esi,esi
       cmp       dword ptr [rbx+8],0
       jle       near ptr M00_L43
M00_L00:
       movzx     ecx,word ptr [rbx+rsi*2+0C]
       cmp       ecx,100
       jge       near ptr M00_L41
       mov       rax,7FFC6F3868D0
       test      byte ptr [rax+rcx],80
       jne       near ptr M00_L42
M00_L01:
       mov       rax,offset MT_DotNetTips.Spargine.Core.Enumeration+<GetAll>d__18<DotNetTips.Spargine.Extensions.NumericFormat>
       mov       [rbp-88],rax
       mov       dword ptr [rbp-70],0FFFFFFFE
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rbp-6C],eax
       cmp       dword ptr [rbp-70],0FFFFFFFE
       jne       near ptr M00_L45
       mov       ebx,[rbp-6C]
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       cmp       ebx,eax
       jne       near ptr M00_L45
       xor       eax,eax
       mov       [rbp-70],eax
       lea       rbx,[rbp-88]
M00_L02:
       mov       [rbp-40],rbx
M00_L03:
       mov       rbx,[rbp-40]
       mov       rsi,rbx
       mov       ecx,[rsi+18]
       test      ecx,ecx
       je        near ptr M00_L08
       cmp       ecx,1
       jne       near ptr M00_L46
       mov       dword ptr [rsi+18],0FFFFFFFF
M00_L04:
       inc       dword ptr [rsi+20]
M00_L05:
       mov       ecx,[rsi+20]
       mov       rax,[rsi+10]
       cmp       ecx,[rax+8]
       jge       near ptr M00_L38
       cmp       ecx,[rax+8]
       jae       near ptr M00_L37
       mov       r14,[rax+rcx*8+10]
       mov       rcx,offset MT_System.Reflection.RtFieldInfo
       cmp       [r14],rcx
       jne       near ptr M00_L35
       cmp       qword ptr [r14+30],0
       jne       short M00_L06
       mov       rcx,offset MT_System.Reflection.FieldAccessor
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       mov       rdx,r14
       call      qword ptr [7FFC109178D0]; System.Reflection.FieldAccessor..ctor(System.Reflection.FieldInfo)
       lea       rcx,[r14+30]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
M00_L06:
       mov       rcx,[r14+30]
       xor       edx,edx
       cmp       [rcx],ecx
       call      qword ptr [7FFC109178E8]; System.Reflection.FieldAccessor.GetValue(System.Object)
M00_L07:
       test      rax,rax
       je        short M00_L04
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.NumericFormat
       cmp       [rax],rcx
       jne       near ptr M00_L04
       mov       [rsi+8],rax
       mov       dword ptr [rsi+18],1
       mov       r14,[rbx+8]
       mov       rcx,[r14+8]
       mov       rdx,[rdi+8]
       cmp       rcx,rdx
       je        near ptr M00_L25
       test      rcx,rcx
       je        near ptr M00_L24
       test      rdx,rdx
       je        near ptr M00_L24
       mov       r8d,[rcx+8]
       cmp       r8d,[rdx+8]
       jne       near ptr M00_L24
       lea       rax,[rcx+0C]
       add       rdx,0C
       mov       ecx,[rcx+8]
       add       ecx,ecx
       mov       r8d,ecx
       cmp       r8,0A
       jne       near ptr M00_L22
       mov       rcx,[rax]
       mov       rax,[rax+2]
       mov       r8,[rdx]
       xor       rcx,r8
       xor       rax,[rdx+2]
       or        rcx,rax
       sete      al
       movzx     eax,al
       jmp       near ptr M00_L23
M00_L08:
       mov       dword ptr [rsi+18],0FFFFFFFF
       mov       rcx,1CB270B1178
       mov       r14,[rcx]
       test      r14,r14
       jne       short M00_L09
       mov       rcx,20BBDC60840
       call      qword ptr [7FFC107656C8]; System.RuntimeType.InitializeCache()
       mov       r15,rax
       jmp       short M00_L10
M00_L09:
       mov       r15,r14
M00_L10:
       cmp       [r15],r15b
       lea       r14,[r15+50]
       mov       rcx,[r14]
       test      rcx,rcx
       je        near ptr M00_L26
M00_L11:
       cmp       byte ptr [rcx+18],0
       je        near ptr M00_L27
       mov       r14,[rcx+8]
M00_L12:
       mov       r15d,[r14+8]
       mov       edx,r15d
       xor       r8d,r8d
       mov       [rbp-58],r8
       mov       [rbp-50],r8
       mov       [rbp-48],r8d
       mov       [rbp-44],edx
       test      r15d,r15d
       jle       short M00_L17
       add       r14,10
M00_L13:
       mov       r13,[r14]
       mov       edx,[r13+18]
       mov       r8d,edx
       and       r8d,18
       cmp       r8d,edx
       jne       short M00_L16
       cmp       dword ptr [rbp-48],0
       je        near ptr M00_L21
       cmp       dword ptr [rbp-48],1
       je        short M00_L19
       mov       edx,[rbp-44]
       cmp       edx,[rbp-48]
       je        near ptr M00_L29
M00_L14:
       movsxd    rdx,dword ptr [rbp-48]
       mov       rcx,[rbp-58]
       mov       r8,r13
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
M00_L15:
       mov       edx,[rbp-48]
       inc       edx
       mov       [rbp-48],edx
M00_L16:
       add       r14,8
       dec       r15d
       jne       short M00_L13
M00_L17:
       mov       r14,[rbp-58]
       mov       r15,[rbp-50]
       mov       r13d,[rbp-48]
       test      r13d,r13d
       je        near ptr M00_L30
       cmp       r13d,1
       je        near ptr M00_L31
       test      r13d,r13d
       jl        near ptr M00_L36
       test      r14,r14
       je        near ptr M00_L32
       cmp       [r14+8],r13d
       jne       near ptr M00_L33
M00_L18:
       mov       [rsi+10],r14
       xor       ecx,ecx
       mov       [rsi+20],ecx
       jmp       near ptr M00_L05
M00_L19:
       cmp       dword ptr [rbp-44],2
       jl        near ptr M00_L28
M00_L20:
       movsxd    rdx,dword ptr [rbp-44]
       mov       rcx,offset MT_System.Reflection.FieldInfo[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       [rbp-58],rax
       mov       rcx,[rbp-58]
       mov       r8,[rbp-50]
       xor       edx,edx
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       near ptr M00_L14
M00_L21:
       mov       [rbp-50],r13
       jmp       near ptr M00_L15
M00_L22:
       mov       rcx,rax
       call      qword ptr [7FFC1059C330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
M00_L23:
       test      eax,eax
       je        near ptr M00_L03
       jmp       near ptr M00_L39
M00_L24:
       xor       eax,eax
       jmp       short M00_L23
M00_L25:
       mov       eax,1
       jmp       short M00_L23
M00_L26:
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache+MemberInfoCache<System.Reflection.RuntimeFieldInfo>
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       lea       rcx,[r13+10]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r14
       mov       rdx,r13
       xor       r8d,r8d
       call      00007FFC7019B3A0
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M00_L11
       mov       rcx,r13
       jmp       near ptr M00_L11
M00_L27:
       xor       edx,edx
       xor       r8d,r8d
       mov       r9d,2
       call      qword ptr [7FFC10766910]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
       mov       r14,rax
       jmp       near ptr M00_L12
M00_L28:
       mov       dword ptr [rbp-44],4
       jmp       near ptr M00_L20
M00_L29:
       mov       r12d,[rbp-44]
       add       r12d,r12d
       lea       rdx,[rbp-58]
       mov       r8d,r12d
       mov       rcx,7FFC107B8FB8
       call      qword ptr [7FFC10766AD8]; System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
       mov       [rbp-44],r12d
       jmp       near ptr M00_L14
M00_L30:
       mov       rcx,1CB28C01BE0
       mov       r14,[rcx]
       jmp       near ptr M00_L18
M00_L31:
       mov       rcx,offset MT_System.Reflection.FieldInfo[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       mov       rcx,r14
       mov       r8,r15
       xor       edx,edx
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       near ptr M00_L18
M00_L32:
       mov       edx,r13d
       mov       rcx,offset MT_System.Reflection.FieldInfo[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       jmp       near ptr M00_L18
M00_L33:
       mov       edx,r13d
       mov       rcx,offset MT_System.Reflection.FieldInfo[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r15,rax
       lea       rdx,[r15+10]
       lea       r8,[r14+10]
       mov       r9d,[r14+8]
       cmp       r13d,r9d
       jle       short M00_L34
       mov       r13d,r9d
M00_L34:
       mov       r9d,r13d
       mov       rcx,7FFC10C989E0
       call      qword ptr [7FFC10C564D8]
       mov       r14,r15
       jmp       near ptr M00_L18
M00_L35:
       mov       rcx,r14
       xor       edx,edx
       mov       rax,[r14]
       mov       rax,[rax+58]
       call      qword ptr [rax]
       jmp       near ptr M00_L07
M00_L36:
       mov       ecx,45
       mov       edx,0D
       call      qword ptr [7FFC10B15938]
       int       3
M00_L37:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L38:
       xor       ecx,ecx
       mov       [rsi+10],rcx
       jmp       near ptr M00_L46
M00_L39:
       xor       ecx,ecx
       mov       rbx,[rbp-40]
       mov       [rbx+10],rcx
       mov       dword ptr [rbx+18],0FFFFFFFE
M00_L40:
       mov       [rbp-60],r14
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+60]
       lea       r8,[rbp-60]
       mov       rdx,7FFC10C38E00
       cmp       [rcx],ecx
       call      qword ptr [7FFC10BDEBC8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
M00_L41:
       call      qword ptr [7FFC10C55E90]
       test      eax,eax
       je        near ptr M00_L01
M00_L42:
       inc       esi
       cmp       [rbx+8],esi
       jg        near ptr M00_L00
M00_L43:
       xor       r14d,r14d
       jmp       short M00_L40
M00_L44:
       xor       r14d,r14d
       jmp       short M00_L40
M00_L45:
       mov       rax,offset MT_DotNetTips.Spargine.Core.Enumeration+<GetAll>d__18<DotNetTips.Spargine.Extensions.NumericFormat>
       mov       [rbp-0B0],rax
       xor       eax,eax
       mov       [rbp-98],eax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rbp-94],eax
       lea       rbx,[rbp-0B0]
       jmp       near ptr M00_L02
M00_L46:
       call      M00_L47
       jmp       short M00_L44
M00_L47:
       sub       rsp,28
       cmp       qword ptr [rbp-40],0
       je        short M00_L48
       xor       ecx,ecx
       mov       rbx,[rbp-40]
       mov       [rbx+10],rcx
       mov       dword ptr [rbx+18],0FFFFFFFE
M00_L48:
       add       rsp,28
       ret
; Total bytes of code 1442
```
```assembly
; System.Reflection.FieldAccessor..ctor(System.Reflection.FieldInfo)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       vzeroupper
       mov       rbx,rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        short M01_L00
       mov       rcx,offset MT_System.Reflection.RtFieldInfo
       cmp       [rsi],rcx
       jne       near ptr M01_L08
M01_L00:
       mov       [rsp+50],rbx
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rsi,[rsi+10]
       cmp       [rsi],sil
       mov       rdi,offset MT_System.RuntimeType
M01_L01:
       cmp       [rsi],rdi
       jne       near ptr M01_L12
       mov       [rsp+20],rsi
       mov       rcx,[rsi+18]
       mov       rax,7FFC701A4990
       call      rax
       movzx     ebx,al
       mov       rsi,[rsp+20]
       cmp       dword ptr [7FFC704FF778],0
       jne       near ptr M01_L10
M01_L02:
       cmp       ebx,1D
       ja        short M01_L03
       mov       ecx,1FEF7FFF
       bt        ecx,ebx
       jae       near ptr M01_L11
M01_L03:
       cmp       ebx,10
       sete      bpl
       movzx     ebp,bpl
M01_L04:
       test      ebp,ebp
       jne       short M01_L09
       cmp       [rsi],rdi
       jne       near ptr M01_L13
M01_L05:
       test      rsi,rsi
       je        near ptr M01_L14
       mov       rcx,rsi
       call      00007FFC701AEBE0
       test      eax,eax
       jne       near ptr M01_L17
       mov       rbx,[rsp+50]
       mov       rcx,[rbx+8]
       mov       rcx,[rcx+10]
       mov       rax,[rcx+18]
       test      al,2
       jne       near ptr M01_L15
       mov       eax,[rax]
       and       eax,0F0000
       cmp       eax,50000
       sete      al
       movzx     eax,al
M01_L06:
       test      eax,eax
       jne       near ptr M01_L16
       mov       dword ptr [rbx+20],0F
M01_L07:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L08:
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M01_L09:
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+68]
       call      qword ptr [rax+8]
       mov       rsi,rax
       jmp       near ptr M01_L01
M01_L10:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M01_L02
M01_L11:
       mov       ebp,1
       jmp       near ptr M01_L04
M01_L12:
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+68]
       call      qword ptr [rax]
       mov       ebp,eax
       jmp       near ptr M01_L04
M01_L13:
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+98]
       call      qword ptr [rax+8]
       mov       rsi,rax
       jmp       near ptr M01_L05
M01_L14:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFC10C56748]
       mov       r8,rax
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFC10C56760]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L15:
       xor       eax,eax
       jmp       near ptr M01_L06
M01_L16:
       mov       [rsp+50],rbx
M01_L17:
       mov       rbx,[rsp+50]
       mov       dword ptr [rbx+20],11
       jmp       near ptr M01_L07
; Total bytes of code 427
```
```assembly
; System.Reflection.FieldAccessor.GetValue(System.Object)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       rsi,rdx
M02_L00:
       mov       ecx,[rbx+20]
       cmp       ecx,7
       jne       short M02_L02
       mov       rax,[rbx+10]
       mov       rax,[rax]
M02_L01:
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L02:
       cmp       ecx,11
       ja        short M02_L03
       mov       ecx,ecx
       lea       rax,[7FFC10CD05D0]
       mov       eax,[rax+rcx*4]
       lea       rdx,[M02_L00]
       add       rax,rdx
       jmp       rax
M02_L03:
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
       mov       rcx,[rbx+8]
       mov       rcx,[rcx+10]
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFC104DA578]; Precode of System.RuntimeType.IsInstanceOfType(System.Object)
       test      eax,eax
       jne       short M02_L04
       test      rsi,rsi
       jne       near ptr M02_L13
       jmp       near ptr M02_L12
M02_L04:
       cmp       [rsi],sil
       mov       rax,[rbx+10]
       mov       rax,[rsi+rax+8]
       jmp       short M02_L01
       mov       rcx,[rbx+8]
       mov       rcx,[rcx+10]
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFC104DA578]; Precode of System.RuntimeType.IsInstanceOfType(System.Object)
       test      eax,eax
       jne       short M02_L05
       test      rsi,rsi
       jne       near ptr M02_L13
       jmp       near ptr M02_L12
M02_L05:
       cmp       [rsi],sil
       mov       rdx,[rbx+10]
       lea       rdx,[rsi+rdx+8]
       mov       rcx,[rbx+18]
       call      qword ptr [7FFC10C56790]
       jmp       near ptr M02_L01
       mov       rcx,[rbx+8]
       mov       rcx,[rcx+10]
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFC104DA578]; Precode of System.RuntimeType.IsInstanceOfType(System.Object)
       test      eax,eax
       jne       short M02_L06
       test      rsi,rsi
       jne       near ptr M02_L13
       jmp       near ptr M02_L12
M02_L06:
       cmp       [rsi],sil
       mov       rcx,[rbx+10]
       mov       rsi,[rsi+rcx+8]
       mov       rcx,[rbx+8]
       mov       rdx,[rcx+28]
       test      rdx,rdx
       jne       short M02_L07
       call      qword ptr [7FFC10917870]; System.Reflection.RtFieldInfo.InitializeFieldType()
       mov       rdx,rax
M02_L07:
       mov       rcx,rsi
       call      qword ptr [7FFC10C56778]
       jmp       near ptr M02_L01
       mov       rcx,[rbx+18]
       mov       rdx,[rbx+10]
       call      qword ptr [7FFC10C56790]
       jmp       near ptr M02_L01
       mov       rcx,[rbx+18]
       mov       rdx,[rbx+10]
       mov       rdx,[rdx]
       cmp       [rdx],dl
       add       rdx,8
       call      qword ptr [7FFC10C56790]
       jmp       near ptr M02_L01
       mov       rcx,[rbx+10]
       mov       rsi,[rcx]
       mov       rcx,[rbx+8]
       mov       rdx,[rcx+28]
       test      rdx,rdx
       jne       short M02_L08
       call      qword ptr [7FFC10917870]; System.Reflection.RtFieldInfo.InitializeFieldType()
       mov       rdx,rax
M02_L08:
       mov       rcx,rsi
       call      qword ptr [7FFC10C56778]
       jmp       near ptr M02_L01
       mov       rcx,rbx
       call      qword ptr [7FFC10917900]; System.Reflection.FieldAccessor.IsStatic()
       test      eax,eax
       jne       short M02_L09
       mov       rcx,[rbx+8]
       mov       rcx,[rcx+10]
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFC104DA578]; Precode of System.RuntimeType.IsInstanceOfType(System.Object)
       test      eax,eax
       jne       short M02_L09
       test      rsi,rsi
       jne       near ptr M02_L13
       jmp       near ptr M02_L12
M02_L09:
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rdi,[rbx+8]
       mov       rcx,[rbx+8]
       mov       rdx,[rcx+28]
       test      rdx,rdx
       jne       short M02_L10
       call      qword ptr [7FFC10917870]; System.Reflection.RtFieldInfo.InitializeFieldType()
       mov       rdx,rax
M02_L10:
       mov       rcx,offset MT_System.RuntimeType
       call      qword ptr [7FFC10596328]; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       r8,rax
       lea       r9,[rsp+28]
       mov       [rsp+20],r9
       mov       r9,[rbx+8]
       mov       r9,[r9+10]
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFC10917918]; System.RuntimeFieldHandle.GetValue(System.Reflection.RtFieldInfo, System.Object, System.RuntimeType, System.RuntimeType, Boolean ByRef)
       mov       rsi,rax
       cmp       byte ptr [rsp+28],0
       je        short M02_L11
       mov       rcx,rbx
       call      qword ptr [7FFC10917930]; System.Reflection.FieldAccessor.Initialize()
M02_L11:
       mov       rax,rsi
       jmp       near ptr M02_L01
       mov       rcx,rbx
       call      qword ptr [7FFC10917900]; System.Reflection.FieldAccessor.IsStatic()
       test      eax,eax
       jne       short M02_L14
       mov       rcx,[rbx+8]
       mov       rcx,[rcx+10]
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFC104DA578]; Precode of System.RuntimeType.IsInstanceOfType(System.Object)
       test      eax,eax
       jne       short M02_L14
       test      rsi,rsi
       jne       short M02_L13
M02_L12:
       call      qword ptr [7FFC10C567A8]
       int       3
M02_L13:
       mov       rdx,[rbx+8]
       mov       rcx,rsi
       call      qword ptr [7FFC10C567C0]
       int       3
M02_L14:
       mov       dword ptr [rsp+28],1
       mov       rdi,[rbx+8]
       mov       rcx,[rbx+8]
       mov       rdx,[rcx+28]
       test      rdx,rdx
       jne       short M02_L15
       call      qword ptr [7FFC10917870]; System.Reflection.RtFieldInfo.InitializeFieldType()
       mov       rdx,rax
M02_L15:
       mov       rcx,offset MT_System.RuntimeType
       call      qword ptr [7FFC10596328]; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       r8,rax
       lea       r9,[rsp+28]
       mov       [rsp+20],r9
       mov       r9,[rbx+8]
       mov       r9,[r9+10]
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFC10917918]; System.RuntimeFieldHandle.GetValue(System.Reflection.RtFieldInfo, System.Object, System.RuntimeType, System.RuntimeType, Boolean ByRef)
       jmp       near ptr M02_L01
       mov       rcx,[rbx+8]
       cmp       [rcx],ecx
       call      qword ptr [7FFC107B8320]; Precode of System.Reflection.RuntimeFieldInfo.get_DeclaringType()
       test      rax,rax
       je        short M02_L16
       mov       rcx,[rbx+8]
       cmp       [rcx],ecx
       call      qword ptr [7FFC107B8320]; Precode of System.Reflection.RuntimeFieldInfo.get_DeclaringType()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+0B0]
       call      qword ptr [rax]
       test      eax,eax
       je        short M02_L16
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFC10C567D8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC10915D58]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M02_L16:
       mov       rcx,[rbx+8]
       cmp       [rcx],ecx
       call      qword ptr [7FFC107B8320]; Precode of System.Reflection.RuntimeFieldInfo.get_DeclaringType()
       test      rax,rax
       je        short M02_L18
       mov       rcx,[rbx+8]
       mov       rdx,[rcx+28]
       test      rdx,rdx
       jne       short M02_L17
       call      qword ptr [7FFC10917870]; System.Reflection.RtFieldInfo.InitializeFieldType()
       mov       rdx,rax
M02_L17:
       mov       rcx,offset MT_System.RuntimeType
       call      qword ptr [7FFC10596328]; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFC1076D4A0]; System.RuntimeType.get_IsNullableOfT()
       test      eax,eax
       je        short M02_L18
       mov       rcx,offset MT_System.NotSupportedException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC10C567F0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M02_L18:
       mov       rcx,offset MT_System.FieldAccessException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFC10C56808]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 908
```
```assembly
; System.RuntimeType.InitializeCache()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,98
       vzeroupper
       lea       rbp,[rsp+0D0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       xor       eax,eax
       mov       [rbp-40],rax
       mov       rbx,rcx
       lea       rcx,[rbp-88]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rcx,rsp
       mov       [rbp-70],rcx
       mov       rcx,rbp
       mov       [rbp-60],rcx
       cmp       qword ptr [rbx+10],0
       je        near ptr M03_L08
M03_L00:
       mov       rcx,[rbx+10]
       mov       rdx,[rcx]
       mov       rdi,rdx
       test      rdi,rdi
       je        short M03_L01
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache
       cmp       [rdi],rcx
       jne       near ptr M03_L09
M03_L01:
       test      rdi,rdi
       jne       near ptr M03_L07
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       [rbp-0A0],rdi
       xor       ecx,ecx
       mov       [rdi+98],ecx
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbx
       call      00007FFC701ABEA0
       mov       r14,rax
       test      r14,r14
       je        near ptr M03_L10
M03_L02:
       mov       rax,[r14+8]
       test      rax,rax
       jne       near ptr M03_L05
       mov       [rbp+10],rbx
       mov       [rbp-0A8],r14
       mov       [rbp-50],r14
       xor       ecx,ecx
       mov       [rbp-48],rcx
       mov       rcx,[rbp-50]
       mov       rcx,[rcx+18]
       lea       rdx,[rbp-50]
       mov       [rbp-98],rdx
       mov       [rbp-90],rcx
       lea       rcx,[rbp-98]
       lea       rdx,[rbp-48]
       mov       rax,7FFC10788420
       mov       [rbp-78],rax
       lea       rax,[M03_L03]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFC700A6D10
       call      rax
M03_L03:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFC704FF778],0
       je        short M03_L04
       call      qword ptr [7FFC704ED608]; CORINFO_HELP_STOP_FOR_GC
M03_L04:
       mov       rcx,[rbp-80]
       mov       [rsi+8],rcx
       mov       rbx,[rbp-48]
       xor       ecx,ecx
       mov       [rbp-48],rcx
       mov       r14,[rbp-0A8]
       lea       rcx,[r14+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
       mov       rbx,[rbp+10]
M03_L05:
       cmp       rax,rbx
       sete      cl
       mov       rdi,[rbp-0A0]
       mov       [rdi+9C],cl
       mov       rcx,[rbx+10]
       mov       rdx,rdi
       xor       r8d,r8d
       call      00007FFC701B9AA0
       mov       rdx,rax
       test      rdx,rdx
       je        short M03_L06
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache
       cmp       [rdx],rcx
       jne       short M03_L11
M03_L06:
       test      rdx,rdx
       cmovne    rdi,rdx
M03_L07:
       mov       rax,rdi
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
M03_L08:
       mov       [rbp-40],rbx
       lea       rcx,[rbp-40]
       mov       edx,1
       call      qword ptr [7FFC10C5D5A8]; System.RuntimeTypeHandle.GetGCHandle(System.Runtime.InteropServices.GCHandleType)
       mov       rdx,rax
       lea       rcx,[rbx+10]
       xor       eax,eax
       lock cmpxchg [rcx],rdx
       test      rax,rax
       je        near ptr M03_L00
       lea       rcx,[rbp-40]
       call      qword ptr [7FFC10C56DC0]
       jmp       near ptr M03_L00
M03_L09:
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M03_L10:
       mov       [rbp+10],rbx
       mov       rcx,rbx
       call      qword ptr [7FFC10765710]; System.RuntimeTypeHandle.<GetModule>g__GetModuleWorker|48_0(System.RuntimeType)
       mov       r14,rax
       mov       rbx,[rbp+10]
       jmp       near ptr M03_L02
M03_L11:
       mov       rdx,rax
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
; Total bytes of code 566
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       sub       rsp,28
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M04_L00
       lea       rax,[rcx+rdx*8+10]
       mov       rcx,[rcx]
       mov       rdx,[rcx+30]
       test      r8,r8
       je        short M04_L02
       cmp       rdx,[r8]
       je        short M04_L01
       mov       r10,offset MT_System.Object[]
       cmp       rcx,r10
       je        short M04_L01
       mov       rcx,rax
       add       rsp,28
       jmp       qword ptr [7FFC10766EC8]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
M04_L00:
       call      qword ptr [7FFC10C54348]
       int       3
M04_L01:
       mov       rcx,rax
       mov       rdx,r8
       add       rsp,28
       jmp       near ptr 00007FFC701E9D90
M04_L02:
       xor       ecx,ecx
       mov       [rax],rcx
       add       rsp,28
       ret
; Total bytes of code 94
```
```assembly
; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       r8,8
       jae       short M05_L05
       cmp       r8,4
       jae       short M05_L04
       xor       eax,eax
       mov       r10,r8
       and       r10,2
       je        short M05_L00
       movzx     eax,word ptr [rcx]
       movzx     r9d,word ptr [rdx]
       sub       eax,r9d
M05_L00:
       test      r8b,1
       jne       short M05_L03
M05_L01:
       test      eax,eax
       sete      al
       movzx     eax,al
M05_L02:
       vzeroupper
       ret
M05_L03:
       movzx     r8d,byte ptr [rcx+r10]
       movzx     ecx,byte ptr [rdx+r10]
       sub       r8d,ecx
       or        eax,r8d
       jmp       short M05_L01
M05_L04:
       add       r8,0FFFFFFFFFFFFFFFC
       mov       eax,[rcx]
       sub       eax,[rdx]
       mov       ecx,[rcx+r8]
       sub       ecx,[rdx+r8]
       or        eax,ecx
       sete      al
       movzx     eax,al
       jmp       short M05_L02
M05_L05:
       cmp       rcx,rdx
       je        near ptr M05_L11
       cmp       r8,20
       jb        short M05_L08
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFE0
       je        short M05_L07
M05_L06:
       vmovups   ymm0,[rcx+rax]
       vpcmpeqb  ymm0,ymm0,[rdx+rax]
       vpmovmskb r10d,ymm0
       cmp       r10d,0FFFFFFFF
       jne       near ptr M05_L13
       add       rax,20
       cmp       r8,rax
       ja        short M05_L06
M05_L07:
       vmovups   ymm0,[rcx+r8]
       vpcmpeqb  ymm0,ymm0,[rdx+r8]
       vpmovmskb ecx,ymm0
       cmp       ecx,0FFFFFFFF
       jne       short M05_L13
       jmp       short M05_L11
M05_L08:
       cmp       r8,10
       jb        short M05_L12
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFF0
       je        short M05_L10
M05_L09:
       vmovups   xmm0,[rcx+rax]
       vpcmpeqb  xmm0,xmm0,[rdx+rax]
       vpmovmskb r10d,xmm0
       cmp       r10d,0FFFF
       jne       short M05_L13
       add       rax,10
       cmp       r8,rax
       ja        short M05_L09
M05_L10:
       vmovups   xmm0,[rcx+r8]
       vpcmpeqb  xmm0,xmm0,[rdx+r8]
       vpmovmskb eax,xmm0
       cmp       eax,0FFFF
       jne       short M05_L13
M05_L11:
       mov       eax,1
       vzeroupper
       ret
M05_L12:
       lea       rax,[r8-8]
       mov       r8,[rcx]
       sub       r8,[rdx]
       mov       rcx,[rcx+rax]
       sub       rcx,[rdx+rax]
       or        rcx,r8
       sete      al
       movzx     eax,al
       jmp       near ptr M05_L02
M05_L13:
       xor       eax,eax
       vzeroupper
       ret
; Total bytes of code 290
```
```assembly
; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,50
       lea       rbp,[rsp+30]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rbp+8],xmm4
       xor       eax,eax
       mov       [rbp+18],rax
       mov       rax,9D207FF69380
       mov       [rbp],rax
       mov       rsi,rcx
       mov       rbx,rdx
       mov       edi,r8d
       mov       r14d,r9d
       test      rbx,rbx
       je        short M06_L00
       cmp       dword ptr [rbx+8],0
       jne       short M06_L03
M06_L00:
       xor       r8d,r8d
       mov       [rbp+8],r8
       mov       [rbp+10],r8d
       mov       [rsp+20],r14d
       lea       r8,[rbp+8]
       mov       rcx,rsi
       mov       r9d,edi
       mov       rdx,20BBDC50008
       call      qword ptr [7FFC10766928]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].GetListByName(System.String, System.Span`1<Byte>, MemberListType, CacheType)
       mov       [rbp+18],rax
M06_L01:
       lea       rdx,[rbp+18]
       mov       rcx,rsi
       mov       r8,rbx
       mov       r9d,edi
       call      qword ptr [7FFC10766B50]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Insert(System.__Canon[] ByRef, System.String, MemberListType)
       mov       rax,[rbp+18]
       mov       r8,9D207FF69380
       cmp       [rbp],r8
       je        short M06_L02
       call      CORINFO_HELP_FAIL_FAST
M06_L02:
       nop
       lea       rsp,[rbp+20]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M06_L03:
       cmp       r14d,1
       jne       short M06_L04
       cmp       word ptr [rbx+0C],2E
       je        short M06_L04
       cmp       word ptr [rbx+0C],2A
       jne       short M06_L00
M06_L04:
       mov       rcx,1CB28C00108
       mov       rcx,[rcx]
       mov       rdx,rbx
       call      qword ptr [7FFC1069CD38]; Precode of System.Text.UTF8Encoding.GetByteCount(System.String)
       cmp       eax,400
       jbe       short M06_L05
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       r8,[rax+10]
       mov       eax,[rax+8]
       jmp       short M06_L07
M06_L05:
       mov       r8d,eax
       test      r8,r8
       je        short M06_L07
       mov       rdx,r8
       add       rdx,0F
       and       rdx,0FFFFFFFFFFFFFFF0
       add       rsp,30
       neg       rdx
       add       rdx,rsp
       jb        short M06_L06
       xor       edx,edx
M06_L06:
       test      [rsp],esp
       sub       rsp,1000
       cmp       rsp,rdx
       jae       short M06_L06
       mov       rsp,rdx
       test      [rsp],esp
       sub       rsp,30
       lea       r8,[rsp+30]
M06_L07:
       mov       [rbp+8],r8
       mov       [rbp+10],eax
       mov       [rsp+20],r14d
       lea       r8,[rbp+8]
       mov       rdx,rbx
       mov       rcx,rsi
       mov       r9d,edi
       call      qword ptr [7FFC10766928]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].GetListByName(System.String, System.Span`1<Byte>, MemberListType, CacheType)
       mov       [rbp+18],rax
       jmp       near ptr M06_L01
; Total bytes of code 348
```
```assembly
; System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rdx
       mov       ebx,r8d
       test      ebx,ebx
       jl        short M07_L01
       mov       rdi,[rsi]
       test      rdi,rdi
       je        short M07_L02
       cmp       [rdi+8],ebx
       jne       short M07_L05
M07_L00:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M07_L01:
       mov       ecx,45
       mov       edx,0D
       call      qword ptr [7FFC10B15938]
       int       3
M07_L02:
       mov       rdx,[rcx+18]
       mov       rax,[rdx+18]
       test      rax,rax
       je        short M07_L03
       mov       rcx,rax
       jmp       short M07_L04
M07_L03:
       mov       rdx,7FFC10CA0658
       call      qword ptr [7FFC1059F630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M07_L04:
       mov       edx,ebx
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdx,rax
       mov       rcx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       short M07_L00
M07_L05:
       mov       rdx,[rcx+18]
       mov       rax,[rdx+18]
       test      rax,rax
       je        short M07_L06
       mov       rcx,rax
       jmp       short M07_L07
M07_L06:
       mov       rdx,7FFC10CA0658
       call      qword ptr [7FFC1059F630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M07_L07:
       mov       edx,ebx
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbp,rax
       lea       rcx,[rbp+10]
       lea       rdx,[rdi+10]
       mov       r8d,[rdi+8]
       cmp       ebx,r8d
       cmovg     ebx,r8d
       mov       r8d,ebx
       shl       r8,3
       call      qword ptr [7FFC105957A0]; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rsi
       mov       rdx,rbp
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       near ptr M07_L00
; Total bytes of code 214
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

## .NET 10.0.3 (10.0.3, 10.0.326.7603), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.EnumerationBenchmark.TryFromValue()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0B8
       lea       rbp,[rsp+0F0]
       xor       eax,eax
       mov       [rbp-0C8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-0C0],ymm4
       vmovdqu   ymmword ptr [rbp-0A0],ymm4
       vmovdqu   ymmword ptr [rbp-80],ymm4
       vmovdqu   ymmword ptr [rbp-60],ymm4
       mov       [rbp+10],rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Enumeration+<>c__DisplayClass20_0<DotNetTips.Spargine.Extensions.NumericFormat>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       dword ptr [rbx+8],1
       mov       rax,offset MT_DotNetTips.Spargine.Core.Enumeration+<GetAll>d__18<DotNetTips.Spargine.Extensions.NumericFormat>
       mov       [rbp-0A0],rax
       mov       dword ptr [rbp-88],0FFFFFFFE
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rbp-84],eax
       cmp       dword ptr [rbp-88],0FFFFFFFE
       jne       near ptr M00_L31
       mov       esi,[rbp-84]
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       cmp       esi,eax
       jne       near ptr M00_L31
       xor       eax,eax
       mov       [rbp-88],eax
       lea       rsi,[rbp-0A0]
M00_L00:
       mov       [rbp-40],rsi
M00_L01:
       mov       rdi,rsi
       mov       ecx,[rdi+18]
       test      ecx,ecx
       je        near ptr M00_L05
       cmp       ecx,1
       jne       near ptr M00_L32
       mov       dword ptr [rdi+18],0FFFFFFFF
M00_L02:
       inc       dword ptr [rdi+20]
M00_L03:
       mov       ecx,[rdi+20]
       mov       rax,[rdi+10]
       cmp       ecx,[rax+8]
       jge       near ptr M00_L27
       cmp       ecx,[rax+8]
       jae       near ptr M00_L25
       mov       rcx,[rax+rcx*8+10]
       mov       rax,offset MT_System.Reflection.RtFieldInfo
       cmp       [rcx],rax
       jne       near ptr M00_L26
       call      qword ptr [7FFC10C67F00]; System.Reflection.RtFieldInfo.get_FieldAccessor()
       mov       rcx,rax
       xor       edx,edx
       cmp       [rcx],ecx
       call      qword ptr [7FFC109278B8]; System.Reflection.FieldAccessor.GetValue(System.Object)
M00_L04:
       test      rax,rax
       je        short M00_L02
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.NumericFormat
       cmp       [rax],rcx
       jne       short M00_L02
       mov       [rdi+8],rax
       mov       dword ptr [rdi+18],1
       mov       rcx,[rsi+8]
       mov       r8d,[rcx+10]
       cmp       r8d,[rbx+8]
       jne       near ptr M00_L01
       jmp       near ptr M00_L28
M00_L05:
       mov       dword ptr [rdi+18],0FFFFFFFF
       mov       rcx,17622141100
       mov       r14,[rcx]
       test      r14,r14
       je        near ptr M00_L18
M00_L06:
       cmp       [r14],r14b
       lea       r15,[r14+50]
       mov       rcx,[r15]
       test      rcx,rcx
       je        near ptr M00_L19
M00_L07:
       cmp       byte ptr [rcx+18],0
       je        near ptr M00_L20
       mov       r14,[rcx+8]
M00_L08:
       mov       r15d,[r14+8]
       mov       edx,r15d
       xor       r8d,r8d
       mov       [rbp-70],r8
       mov       [rbp-68],r8
       mov       [rbp-60],r8d
       mov       [rbp-5C],edx
       test      r15d,r15d
       jle       short M00_L13
       add       r14,10
M00_L09:
       mov       r13,[r14]
       mov       edx,[r13+18]
       mov       r8d,edx
       and       r8d,18
       cmp       r8d,edx
       jne       short M00_L12
       cmp       dword ptr [rbp-60],0
       je        near ptr M00_L17
       cmp       dword ptr [rbp-60],1
       je        near ptr M00_L15
       mov       edx,[rbp-5C]
       cmp       edx,[rbp-60]
       je        near ptr M00_L22
M00_L10:
       movsxd    rdx,dword ptr [rbp-60]
       mov       rcx,[rbp-70]
       mov       r8,r13
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
M00_L11:
       mov       edx,[rbp-60]
       inc       edx
       mov       [rbp-60],edx
M00_L12:
       add       r14,8
       dec       r15d
       jne       short M00_L09
M00_L13:
       vmovdqu   xmm0,xmmword ptr [rbp-70]
       vmovdqu   xmmword ptr [rbp-58],xmm0
       mov       rdx,[rbp-60]
       mov       [rbp-48],rdx
       cmp       dword ptr [rbp-48],0
       je        near ptr M00_L23
       cmp       dword ptr [rbp-48],1
       je        near ptr M00_L24
       lea       rdx,[rbp-58]
       mov       r8d,[rbp-48]
       mov       rcx,7FFC107C8FB8
       call      qword ptr [7FFC10776AD8]; System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
       mov       ecx,[rbp-48]
       mov       [rbp-44],ecx
       mov       r14,[rbp-58]
M00_L14:
       mov       [rdi+10],r14
       xor       ecx,ecx
       mov       [rdi+20],ecx
       jmp       near ptr M00_L03
M00_L15:
       cmp       dword ptr [rbp-5C],2
       jl        near ptr M00_L21
M00_L16:
       movsxd    rdx,dword ptr [rbp-5C]
       mov       rcx,offset MT_System.Reflection.FieldInfo[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       [rbp-70],rax
       mov       rcx,[rbp-70]
       mov       r8,[rbp-68]
       xor       edx,edx
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       near ptr M00_L10
M00_L17:
       mov       [rbp-68],r13
       jmp       near ptr M00_L11
M00_L18:
       mov       rcx,1B6B75C06C0
       call      qword ptr [7FFC107756C8]; System.RuntimeType.InitializeCache()
       mov       r14,rax
       jmp       near ptr M00_L06
M00_L19:
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache+MemberInfoCache<System.Reflection.RuntimeFieldInfo>
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       lea       rcx,[r13+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r15
       mov       rdx,r13
       xor       r8d,r8d
       call      00007FFC7019B3A0
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M00_L07
       mov       rcx,r13
       jmp       near ptr M00_L07
M00_L20:
       xor       edx,edx
       xor       r8d,r8d
       mov       r9d,2
       call      qword ptr [7FFC10776910]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
       mov       r14,rax
       jmp       near ptr M00_L08
M00_L21:
       mov       dword ptr [rbp-5C],4
       jmp       near ptr M00_L16
M00_L22:
       mov       r12d,[rbp-5C]
       add       r12d,r12d
       lea       rdx,[rbp-70]
       mov       r8d,r12d
       mov       rcx,7FFC107C8FB8
       call      qword ptr [7FFC10776AD8]; System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
       mov       [rbp-5C],r12d
       jmp       near ptr M00_L10
M00_L23:
       mov       rcx,17622401BE0
       mov       r14,[rcx]
       jmp       near ptr M00_L14
M00_L24:
       mov       rcx,offset MT_System.Reflection.FieldInfo[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       mov       rcx,r14
       mov       r8,[rbp-50]
       xor       edx,edx
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       near ptr M00_L14
M00_L25:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L26:
       xor       edx,edx
       mov       rax,[rcx]
       mov       rax,[rax+58]
       call      qword ptr [rax]
       jmp       near ptr M00_L04
M00_L27:
       xor       ecx,ecx
       mov       [rdi+10],rcx
       jmp       short M00_L32
M00_L28:
       xor       r8d,r8d
       mov       [rsi+10],r8
       mov       dword ptr [rsi+18],0FFFFFFFE
M00_L29:
       mov       [rbp-78],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+60]
       lea       r8,[rbp-78]
       mov       rdx,7FFC10C488C0
       cmp       [rcx],ecx
       call      qword ptr [7FFC10BEEB20]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,0B8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L30:
       xor       ecx,ecx
       jmp       short M00_L29
M00_L31:
       mov       rax,offset MT_DotNetTips.Spargine.Core.Enumeration+<GetAll>d__18<DotNetTips.Spargine.Extensions.NumericFormat>
       mov       [rbp-0C8],rax
       xor       eax,eax
       mov       [rbp-0B0],eax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rbp-0AC],eax
       lea       rsi,[rbp-0C8]
       jmp       near ptr M00_L00
M00_L32:
       call      M00_L33
       jmp       short M00_L30
M00_L33:
       sub       rsp,28
       cmp       qword ptr [rbp-40],0
       je        short M00_L34
       xor       ecx,ecx
       mov       rsi,[rbp-40]
       mov       [rsi+10],rcx
       mov       dword ptr [rsi+18],0FFFFFFFE
M00_L34:
       add       rsp,28
       ret
; Total bytes of code 1082
```
```assembly
; System.Reflection.RtFieldInfo.get_FieldAccessor()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       cmp       qword ptr [rbx+30],0
       je        short M01_L01
M01_L00:
       mov       rax,[rbx+30]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L01:
       mov       rcx,offset MT_System.Reflection.FieldAccessor
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFC109278A0]; System.Reflection.FieldAccessor..ctor(System.Reflection.FieldInfo)
       lea       rcx,[rbx+30]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M01_L00
; Total bytes of code 71
```
```assembly
; System.Reflection.FieldAccessor.GetValue(System.Object)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       rsi,rdx
M02_L00:
       mov       ecx,[rbx+20]
       cmp       ecx,7
       jne       short M02_L02
       mov       rax,[rbx+10]
       mov       rax,[rax]
M02_L01:
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L02:
       cmp       ecx,11
       ja        short M02_L03
       mov       ecx,ecx
       lea       rax,[7FFC1065A9B8]
       mov       eax,[rax+rcx*4]
       lea       rdx,[M02_L00]
       add       rax,rdx
       jmp       rax
M02_L03:
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
       mov       rcx,[rbx+8]
       mov       rcx,[rcx+10]
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFC104EA578]; Precode of System.RuntimeType.IsInstanceOfType(System.Object)
       test      eax,eax
       jne       short M02_L04
       test      rsi,rsi
       jne       near ptr M02_L14
       jmp       near ptr M02_L13
M02_L04:
       cmp       [rsi],sil
       mov       rax,[rbx+10]
       mov       rax,[rsi+rax+8]
       jmp       short M02_L01
       mov       rcx,[rbx+8]
       mov       rcx,[rcx+10]
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFC104EA578]; Precode of System.RuntimeType.IsInstanceOfType(System.Object)
       test      eax,eax
       jne       short M02_L05
       test      rsi,rsi
       jne       near ptr M02_L14
       jmp       near ptr M02_L13
M02_L05:
       cmp       [rsi],sil
       mov       rdx,[rbx+10]
       lea       rdx,[rsi+rdx+8]
       mov       rcx,[rbx+18]
       call      qword ptr [7FFC10C66790]
       jmp       near ptr M02_L01
       mov       rcx,[rbx+8]
       mov       rcx,[rcx+10]
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFC104EA578]; Precode of System.RuntimeType.IsInstanceOfType(System.Object)
       test      eax,eax
       jne       short M02_L06
       test      rsi,rsi
       jne       near ptr M02_L14
       jmp       near ptr M02_L13
M02_L06:
       cmp       [rsi],sil
       mov       rcx,[rbx+10]
       mov       rsi,[rsi+rcx+8]
       mov       rcx,[rbx+8]
       mov       rdx,[rcx+28]
       test      rdx,rdx
       jne       short M02_L07
       call      qword ptr [7FFC10927840]; System.Reflection.RtFieldInfo.InitializeFieldType()
       mov       rdx,rax
M02_L07:
       mov       rcx,rsi
       call      qword ptr [7FFC10C66778]
       jmp       near ptr M02_L01
       mov       rcx,[rbx+18]
       mov       rdx,[rbx+10]
       call      qword ptr [7FFC10C66790]
       jmp       near ptr M02_L01
       mov       rcx,[rbx+18]
       mov       rdx,[rbx+10]
       mov       rdx,[rdx]
       cmp       [rdx],dl
       add       rdx,8
       call      qword ptr [7FFC10C66790]
       jmp       near ptr M02_L01
       mov       rcx,[rbx+10]
       mov       rsi,[rcx]
       mov       rcx,[rbx+8]
       mov       rdx,[rcx+28]
       test      rdx,rdx
       jne       short M02_L08
       call      qword ptr [7FFC10927840]; System.Reflection.RtFieldInfo.InitializeFieldType()
       mov       rdx,rax
M02_L08:
       mov       rcx,rsi
       call      qword ptr [7FFC10C66778]
       jmp       near ptr M02_L01
       mov       rcx,rbx
       call      qword ptr [7FFC109278D0]; System.Reflection.FieldAccessor.IsStatic()
       test      eax,eax
       jne       short M02_L09
       mov       rcx,[rbx+8]
       mov       rcx,[rcx+10]
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFC104EA578]; Precode of System.RuntimeType.IsInstanceOfType(System.Object)
       test      eax,eax
       jne       short M02_L09
       test      rsi,rsi
       jne       near ptr M02_L14
       jmp       near ptr M02_L13
M02_L09:
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,[rbx+8]
       mov       rdi,rcx
       mov       rdx,[rcx+28]
       test      rdx,rdx
       jne       short M02_L10
       call      qword ptr [7FFC10927840]; System.Reflection.RtFieldInfo.InitializeFieldType()
       mov       rdx,rax
M02_L10:
       mov       r8,rdx
       test      r8,r8
       je        short M02_L11
       mov       rcx,offset MT_System.RuntimeType
       cmp       [r8],rcx
       je        short M02_L11
       call      qword ptr [7FFC105A6328]; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M02_L11:
       lea       r9,[rsp+28]
       mov       [rsp+20],r9
       mov       r9,[rbx+8]
       mov       r9,[r9+10]
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFC109278E8]; System.RuntimeFieldHandle.GetValue(System.Reflection.RtFieldInfo, System.Object, System.RuntimeType, System.RuntimeType, Boolean ByRef)
       mov       rsi,rax
       cmp       byte ptr [rsp+28],0
       je        short M02_L12
       mov       rcx,rbx
       call      qword ptr [7FFC10927900]; System.Reflection.FieldAccessor.Initialize()
M02_L12:
       mov       rax,rsi
       jmp       near ptr M02_L01
       mov       rcx,rbx
       call      qword ptr [7FFC109278D0]; System.Reflection.FieldAccessor.IsStatic()
       test      eax,eax
       jne       short M02_L15
       mov       rcx,[rbx+8]
       mov       rcx,[rcx+10]
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFC104EA578]; Precode of System.RuntimeType.IsInstanceOfType(System.Object)
       test      eax,eax
       jne       short M02_L15
       test      rsi,rsi
       jne       short M02_L14
M02_L13:
       call      qword ptr [7FFC10C667A8]
       int       3
M02_L14:
       mov       rdx,[rbx+8]
       mov       rcx,rsi
       call      qword ptr [7FFC10C667C0]
       int       3
M02_L15:
       mov       dword ptr [rsp+28],1
       mov       rdi,[rbx+8]
       mov       rcx,[rbx+8]
       mov       rdx,[rcx+28]
       test      rdx,rdx
       jne       short M02_L16
       call      qword ptr [7FFC10927840]; System.Reflection.RtFieldInfo.InitializeFieldType()
       mov       rdx,rax
M02_L16:
       mov       rcx,offset MT_System.RuntimeType
       call      qword ptr [7FFC105A6328]; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       r8,rax
       lea       r9,[rsp+28]
       mov       [rsp+20],r9
       mov       r9,[rbx+8]
       mov       r9,[r9+10]
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFC109278E8]; System.RuntimeFieldHandle.GetValue(System.Reflection.RtFieldInfo, System.Object, System.RuntimeType, System.RuntimeType, Boolean ByRef)
       jmp       near ptr M02_L01
       mov       rcx,[rbx+8]
       cmp       [rcx],ecx
       call      qword ptr [7FFC107C8320]; Precode of System.Reflection.RuntimeFieldInfo.get_DeclaringType()
       test      rax,rax
       je        short M02_L17
       mov       rcx,[rbx+8]
       cmp       [rcx],ecx
       call      qword ptr [7FFC107C8320]; Precode of System.Reflection.RuntimeFieldInfo.get_DeclaringType()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+0B0]
       call      qword ptr [rax]
       test      eax,eax
       je        short M02_L17
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFC10C667D8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC10925D28]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M02_L17:
       mov       rcx,[rbx+8]
       cmp       [rcx],ecx
       call      qword ptr [7FFC107C8320]; Precode of System.Reflection.RuntimeFieldInfo.get_DeclaringType()
       test      rax,rax
       je        short M02_L19
       mov       rcx,[rbx+8]
       mov       rdx,[rcx+28]
       test      rdx,rdx
       jne       short M02_L18
       call      qword ptr [7FFC10927840]; System.Reflection.RtFieldInfo.InitializeFieldType()
       mov       rdx,rax
M02_L18:
       mov       rcx,offset MT_System.RuntimeType
       call      qword ptr [7FFC105A6328]; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFC1077D4A0]; System.RuntimeType.get_IsNullableOfT()
       test      eax,eax
       je        short M02_L19
       mov       rcx,offset MT_System.NotSupportedException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC10C667F0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M02_L19:
       mov       rcx,offset MT_System.FieldAccessException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFC10C66808]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 918
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       sub       rsp,28
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M03_L00
       lea       rax,[rcx+rdx*8+10]
       mov       rcx,[rcx]
       mov       rdx,[rcx+30]
       test      r8,r8
       je        short M03_L02
       cmp       rdx,[r8]
       je        short M03_L01
       mov       r10,offset MT_System.Object[]
       cmp       rcx,r10
       je        short M03_L01
       mov       rcx,rax
       add       rsp,28
       jmp       qword ptr [7FFC10776EC8]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
M03_L00:
       call      qword ptr [7FFC10C642D0]
       int       3
M03_L01:
       mov       rcx,rax
       mov       rdx,r8
       add       rsp,28
       jmp       near ptr 00007FFC701E9D90
M03_L02:
       xor       ecx,ecx
       mov       [rax],rcx
       add       rsp,28
       ret
; Total bytes of code 94
```
```assembly
; System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rdx
       mov       ebx,r8d
       test      ebx,ebx
       jl        short M04_L01
       mov       rdi,[rsi]
       test      rdi,rdi
       je        short M04_L02
       cmp       [rdi+8],ebx
       jne       short M04_L05
M04_L00:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M04_L01:
       mov       ecx,45
       mov       edx,0D
       call      qword ptr [7FFC10B25908]
       int       3
M04_L02:
       mov       rdx,[rcx+18]
       mov       rax,[rdx+18]
       test      rax,rax
       je        short M04_L03
       mov       rcx,rax
       jmp       short M04_L04
M04_L03:
       mov       rdx,7FFC10CB0398
       call      qword ptr [7FFC105AF630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M04_L04:
       mov       edx,ebx
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdx,rax
       mov       rcx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       short M04_L00
M04_L05:
       mov       rdx,[rcx+18]
       mov       rax,[rdx+18]
       test      rax,rax
       je        short M04_L06
       mov       rcx,rax
       jmp       short M04_L07
M04_L06:
       mov       rdx,7FFC10CB0398
       call      qword ptr [7FFC105AF630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M04_L07:
       mov       edx,ebx
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbp,rax
       lea       rcx,[rbp+10]
       lea       rdx,[rdi+10]
       mov       r8d,[rdi+8]
       cmp       ebx,r8d
       cmovg     ebx,r8d
       mov       r8d,ebx
       shl       r8,3
       call      qword ptr [7FFC105A57A0]; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rsi
       mov       rdx,rbp
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       near ptr M04_L00
; Total bytes of code 214
```
```assembly
; System.RuntimeType.InitializeCache()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,98
       vzeroupper
       lea       rbp,[rsp+0D0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       xor       eax,eax
       mov       [rbp-40],rax
       mov       rbx,rcx
       lea       rcx,[rbp-88]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rcx,rsp
       mov       [rbp-70],rcx
       mov       rcx,rbp
       mov       [rbp-60],rcx
       cmp       qword ptr [rbx+10],0
       je        near ptr M05_L08
M05_L00:
       mov       rcx,[rbx+10]
       mov       rdx,[rcx]
       mov       rdi,rdx
       test      rdi,rdi
       je        short M05_L01
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache
       cmp       [rdi],rcx
       jne       near ptr M05_L09
M05_L01:
       test      rdi,rdi
       jne       near ptr M05_L07
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       [rbp-0A0],rdi
       xor       ecx,ecx
       mov       [rdi+98],ecx
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbx
       call      00007FFC701ABEA0
       mov       r14,rax
       test      r14,r14
       je        near ptr M05_L10
M05_L02:
       mov       rax,[r14+8]
       test      rax,rax
       jne       near ptr M05_L05
       mov       [rbp+10],rbx
       mov       [rbp-0A8],r14
       mov       [rbp-50],r14
       xor       ecx,ecx
       mov       [rbp-48],rcx
       mov       rcx,[rbp-50]
       mov       rcx,[rcx+18]
       lea       rdx,[rbp-50]
       mov       [rbp-98],rdx
       mov       [rbp-90],rcx
       lea       rcx,[rbp-98]
       lea       rdx,[rbp-48]
       mov       rax,7FFC10798420
       mov       [rbp-78],rax
       lea       rax,[M05_L03]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFC700A6D10
       call      rax
M05_L03:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFC704FF778],0
       je        short M05_L04
       call      qword ptr [7FFC704ED608]; CORINFO_HELP_STOP_FOR_GC
M05_L04:
       mov       rcx,[rbp-80]
       mov       [rsi+8],rcx
       mov       rbx,[rbp-48]
       xor       ecx,ecx
       mov       [rbp-48],rcx
       mov       r14,[rbp-0A8]
       lea       rcx,[r14+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
       mov       rbx,[rbp+10]
M05_L05:
       cmp       rax,rbx
       sete      cl
       mov       rdi,[rbp-0A0]
       mov       [rdi+9C],cl
       mov       rcx,[rbx+10]
       mov       rdx,rdi
       xor       r8d,r8d
       call      00007FFC701B9AA0
       mov       rdx,rax
       test      rdx,rdx
       je        short M05_L06
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache
       cmp       [rdx],rcx
       jne       short M05_L11
M05_L06:
       test      rdx,rdx
       cmovne    rdi,rdx
M05_L07:
       mov       rax,rdi
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
M05_L08:
       mov       [rbp-40],rbx
       lea       rcx,[rbp-40]
       mov       edx,1
       call      qword ptr [7FFC10C6D638]; System.RuntimeTypeHandle.GetGCHandle(System.Runtime.InteropServices.GCHandleType)
       mov       rdx,rax
       lea       rcx,[rbx+10]
       xor       eax,eax
       lock cmpxchg [rcx],rdx
       test      rax,rax
       je        near ptr M05_L00
       lea       rcx,[rbp-40]
       call      qword ptr [7FFC10C66EE0]
       jmp       near ptr M05_L00
M05_L09:
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M05_L10:
       mov       [rbp+10],rbx
       mov       rcx,rbx
       call      qword ptr [7FFC10775710]; System.RuntimeTypeHandle.<GetModule>g__GetModuleWorker|48_0(System.RuntimeType)
       mov       r14,rax
       mov       rbx,[rbp+10]
       jmp       near ptr M05_L02
M05_L11:
       mov       rdx,rax
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
; Total bytes of code 566
```
```assembly
; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,50
       lea       rbp,[rsp+30]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rbp+8],xmm4
       xor       eax,eax
       mov       [rbp+18],rax
       mov       rax,785D075A9B00
       mov       [rbp],rax
       mov       rsi,rcx
       mov       rbx,rdx
       mov       edi,r8d
       mov       r14d,r9d
       test      rbx,rbx
       je        short M06_L00
       cmp       dword ptr [rbx+8],0
       jne       short M06_L03
M06_L00:
       xor       r8d,r8d
       mov       [rbp+8],r8
       mov       [rbp+10],r8d
       mov       [rsp+20],r14d
       lea       r8,[rbp+8]
       mov       rcx,rsi
       mov       r9d,edi
       mov       rdx,1B6B75B0008
       call      qword ptr [7FFC10776928]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].GetListByName(System.String, System.Span`1<Byte>, MemberListType, CacheType)
       mov       [rbp+18],rax
M06_L01:
       lea       rdx,[rbp+18]
       mov       rcx,rsi
       mov       r8,rbx
       mov       r9d,edi
       call      qword ptr [7FFC10776B50]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Insert(System.__Canon[] ByRef, System.String, MemberListType)
       mov       rax,[rbp+18]
       mov       r8,785D075A9B00
       cmp       [rbp],r8
       je        short M06_L02
       call      CORINFO_HELP_FAIL_FAST
M06_L02:
       nop
       lea       rsp,[rbp+20]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M06_L03:
       cmp       r14d,1
       jne       short M06_L04
       cmp       word ptr [rbx+0C],2E
       je        short M06_L04
       cmp       word ptr [rbx+0C],2A
       jne       short M06_L00
M06_L04:
       mov       rcx,17622400108
       mov       rcx,[rcx]
       mov       rdx,rbx
       call      qword ptr [7FFC106ACD38]; Precode of System.Text.UTF8Encoding.GetByteCount(System.String)
       cmp       eax,400
       jbe       short M06_L05
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       r8,[rax+10]
       mov       eax,[rax+8]
       jmp       short M06_L07
M06_L05:
       mov       r8d,eax
       test      r8,r8
       je        short M06_L07
       mov       rdx,r8
       add       rdx,0F
       and       rdx,0FFFFFFFFFFFFFFF0
       add       rsp,30
       neg       rdx
       add       rdx,rsp
       jb        short M06_L06
       xor       edx,edx
M06_L06:
       test      [rsp],esp
       sub       rsp,1000
       cmp       rsp,rdx
       jae       short M06_L06
       mov       rsp,rdx
       test      [rsp],esp
       sub       rsp,30
       lea       r8,[rsp+30]
M06_L07:
       mov       [rbp+8],r8
       mov       [rbp+10],eax
       mov       [rsp+20],r14d
       lea       r8,[rbp+8]
       mov       rdx,rbx
       mov       rcx,rsi
       mov       r9d,edi
       call      qword ptr [7FFC10776928]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].GetListByName(System.String, System.Span`1<Byte>, MemberListType, CacheType)
       mov       [rbp+18],rax
       jmp       near ptr M06_L01
; Total bytes of code 348
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

