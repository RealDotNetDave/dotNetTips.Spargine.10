## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.EnumerationBenchmark.FromDisplayName()
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
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Enumeration+<>c__DisplayClass13_0<DotNetTips.Spargine.Extensions.NumericFormat>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rsi,2B3C1A20698
       mov       [rbx+8],rsi
       mov       rdx,rsi
       mov       ecx,[rdx+8]
       test      ecx,ecx
       sete      al
       movzx     eax,al
       cmp       eax,ecx
       jae       near ptr M00_L44
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Extensions.NumericFormat, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       [rbp-0A0],rsi
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Core.Enumeration+<>c__DisplayClass13_0`1[[System.__Canon, System.Private.CoreLib]].<FromDisplayName>b__0(System.__Canon)
       mov       [rdi+18],rcx
       mov       rbx,offset MT_DotNetTips.Spargine.Core.Enumeration+<GetAll>d__15<DotNetTips.Spargine.Extensions.NumericFormat>
       mov       rcx,rbx
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       dword ptr [rsi+18],0FFFFFFFE
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rsi+1C],eax
       cmp       dword ptr [rsi+18],0FFFFFFFE
       jne       near ptr M00_L40
       mov       r14d,[rsi+1C]
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       cmp       r14d,eax
       jne       near ptr M00_L40
       xor       ecx,ecx
       mov       [rsi+18],ecx
M00_L00:
       mov       rcx,rsi
       mov       [rbp-0A8],rcx
       mov       rax,offset DotNetTips.Spargine.Core.Enumeration+<>c__DisplayClass13_0`1[[System.__Canon, System.Private.CoreLib]].<FromDisplayName>b__0(System.__Canon)
       cmp       [rdi+18],rax
       jne       near ptr M00_L12
M00_L01:
       mov       rcx,[rbp-0A8]
       mov       rbx,rcx
       mov       esi,[rbx+18]
       test      esi,esi
       jne       near ptr M00_L10
       mov       dword ptr [rbx+18],0FFFFFFFF
       mov       rax,2732C601178
       mov       r14,[rax]
       test      r14,r14
       jne       short M00_L02
       mov       rcx,2B3C1A20760
       call      qword ptr [7FF9F7D656C8]; System.RuntimeType.InitializeCache()
       jmp       short M00_L03
M00_L02:
       mov       rax,r14
M00_L03:
       mov       rcx,rax
       xor       edx,edx
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FF9F82CC240]; System.RuntimeType+RuntimeTypeCache.GetFieldList(MemberListType, System.String)
       mov       rsi,rax
       mov       r14d,[rsi+8]
       mov       r8d,r14d
       lea       rcx,[rbp-90]
       mov       r15,offset MT_System.RuntimeType+ListBuilder<System.Reflection.FieldInfo>
       mov       rdx,r15
       call      qword ptr [7FF9F82CC258]; System.RuntimeType+ListBuilder`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       test      r14d,r14d
       jle       short M00_L06
       add       rsi,10
M00_L04:
       mov       r8,[rsi]
       mov       ecx,[r8+18]
       mov       edx,ecx
       and       edx,18
       cmp       edx,ecx
       jne       short M00_L05
       lea       rcx,[rbp-90]
       mov       rdx,r15
       call      qword ptr [7FF9F7D66AC0]; System.RuntimeType+ListBuilder`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
M00_L05:
       add       rsi,8
       dec       r14d
       jne       short M00_L04
M00_L06:
       vmovdqu   xmm0,xmmword ptr [rbp-90]
       vmovdqu   xmmword ptr [rbp-78],xmm0
       mov       rcx,[rbp-80]
       mov       [rbp-68],rcx
       lea       rcx,[rbp-78]
       mov       rdx,r15
       call      qword ptr [7FF9F7D66B38]; System.RuntimeType+ListBuilder`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       lea       rcx,[rbx+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+20],ecx
M00_L07:
       mov       eax,[rbx+20]
       mov       r8,[rbx+10]
       cmp       eax,[r8+8]
       jge       near ptr M00_L37
       cmp       eax,[r8+8]
       jae       near ptr M00_L36
       mov       edx,eax
       mov       r10,[r8+rdx*8+10]
       mov       rdx,offset MT_System.Reflection.RtFieldInfo
       cmp       [r10],rdx
       jne       near ptr M00_L21
       mov       rcx,r10
       xor       edx,edx
       call      qword ptr [7FF9F7E4E728]; System.Reflection.RtFieldInfo.GetValue(System.Object)
M00_L08:
       mov       rdx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.NumericFormat
       call      qword ptr [7FF9F7AF6850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r14,rax
       mov       rdx,r14
       test      rdx,rdx
       je        short M00_L11
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+18],1
       mov       r15,[rdi+8]
       mov       r13,[r14+8]
       mov       rdx,[r15+8]
       cmp       r13,rdx
       jne       near ptr M00_L16
       mov       r12d,1
M00_L09:
       test      r12d,r12d
       je        near ptr M00_L01
       jmp       near ptr M00_L38
M00_L10:
       cmp       esi,1
       jne       near ptr M00_L42
       mov       dword ptr [rbx+18],0FFFFFFFF
M00_L11:
       inc       dword ptr [rbx+20]
       jmp       near ptr M00_L07
M00_L12:
       mov       rcx,[rbp-0A8]
       mov       rbx,rcx
       mov       esi,[rbx+18]
       test      esi,esi
       je        near ptr M00_L22
       jmp       near ptr M00_L28
M00_L13:
       mov       eax,[rbx+20]
       mov       r8,[rbx+10]
       cmp       eax,[r8+8]
       jge       near ptr M00_L37
       cmp       eax,[r8+8]
       jae       near ptr M00_L36
       mov       edx,eax
       mov       r10,[r8+rdx*8+10]
       mov       rdx,offset MT_System.Reflection.RtFieldInfo
       cmp       [r10],rdx
       jne       near ptr M00_L30
       mov       rcx,r10
       xor       edx,edx
       call      qword ptr [7FF9F7E4E728]; System.Reflection.RtFieldInfo.GetValue(System.Object)
M00_L14:
       mov       rdx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.NumericFormat
       call      qword ptr [7FF9F7AF6850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r14,rax
       mov       rdx,r14
       test      rdx,rdx
       je        near ptr M00_L29
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+18],1
       mov       rcx,offset DotNetTips.Spargine.Core.Enumeration+<>c__DisplayClass13_0`1[[System.__Canon, System.Private.CoreLib]].<FromDisplayName>b__0(System.__Canon)
       cmp       [rdi+18],rcx
       jne       near ptr M00_L31
       mov       r15,[rdi+8]
       mov       r13,[r14+8]
       mov       rdx,[r15+8]
       cmp       r13,rdx
       jne       near ptr M00_L32
       mov       r12d,1
M00_L15:
       test      r12d,r12d
       je        near ptr M00_L12
       jmp       near ptr M00_L38
M00_L16:
       test      r13,r13
       je        short M00_L17
       test      rdx,rdx
       jne       short M00_L18
M00_L17:
       xor       r12d,r12d
       jmp       near ptr M00_L09
M00_L18:
       mov       ecx,[r13+8]
       cmp       ecx,[rdx+8]
       jne       short M00_L17
       lea       rcx,[r13+0C]
       add       rdx,0C
       mov       r8d,[r13+8]
       add       r8d,r8d
       cmp       r8,0A
       jne       short M00_L19
       mov       rax,[rcx]
       mov       rcx,[rcx+2]
       mov       r8,[rdx]
       xor       rax,r8
       xor       rcx,[rdx+2]
       or        rcx,rax
       sete      r12b
       movzx     r12d,r12b
       jmp       short M00_L20
M00_L19:
       call      qword ptr [7FF9F7AFC330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r12d,eax
M00_L20:
       jmp       near ptr M00_L09
M00_L21:
       mov       rcx,r10
       xor       edx,edx
       mov       rax,[r10]
       mov       rax,[rax+58]
       call      qword ptr [rax]
       jmp       near ptr M00_L08
M00_L22:
       mov       dword ptr [rbx+18],0FFFFFFFF
       mov       rax,2732C601178
       mov       r14,[rax]
       test      r14,r14
       jne       short M00_L23
       mov       rcx,2B3C1A20760
       call      qword ptr [7FF9F7D656C8]; System.RuntimeType.InitializeCache()
       jmp       short M00_L24
M00_L23:
       mov       rax,r14
M00_L24:
       mov       rcx,rax
       xor       edx,edx
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FF9F82CC240]; System.RuntimeType+RuntimeTypeCache.GetFieldList(MemberListType, System.String)
       mov       rsi,rax
       mov       r8d,[rsi+8]
       lea       rcx,[rbp-90]
       mov       r15,offset MT_System.RuntimeType+ListBuilder<System.Reflection.FieldInfo>
       mov       rdx,r15
       call      qword ptr [7FF9F82CC258]; System.RuntimeType+ListBuilder`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       xor       r13d,r13d
       cmp       dword ptr [rsi+8],0
       jle       short M00_L27
M00_L25:
       mov       ecx,r13d
       mov       r8,[rsi+rcx*8+10]
       mov       ecx,[r8+18]
       mov       edx,ecx
       and       edx,18
       cmp       edx,ecx
       jne       short M00_L26
       lea       rcx,[rbp-90]
       mov       rdx,r15
       call      qword ptr [7FF9F7D66AC0]; System.RuntimeType+ListBuilder`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
M00_L26:
       inc       r13d
       cmp       [rsi+8],r13d
       jg        short M00_L25
M00_L27:
       vmovdqu   xmm0,xmmword ptr [rbp-90]
       vmovdqu   xmmword ptr [rbp-78],xmm0
       mov       rcx,[rbp-80]
       mov       [rbp-68],rcx
       lea       rcx,[rbp-78]
       mov       rdx,r15
       call      qword ptr [7FF9F7D66B38]; System.RuntimeType+ListBuilder`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       lea       rcx,[rbx+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+20],ecx
       jmp       near ptr M00_L13
M00_L28:
       cmp       esi,1
       jne       near ptr M00_L42
       mov       dword ptr [rbx+18],0FFFFFFFF
M00_L29:
       inc       dword ptr [rbx+20]
       jmp       near ptr M00_L13
M00_L30:
       mov       rcx,r10
       xor       edx,edx
       mov       rax,[r10]
       mov       rax,[rax+58]
       call      qword ptr [rax]
       jmp       near ptr M00_L14
M00_L31:
       mov       rdx,r14
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       mov       r12d,eax
       jmp       near ptr M00_L15
M00_L32:
       test      r13,r13
       je        short M00_L35
       test      rdx,rdx
       je        short M00_L35
       mov       ecx,[r13+8]
       cmp       ecx,[rdx+8]
       jne       short M00_L35
       lea       rcx,[r13+0C]
       add       rdx,0C
       mov       r8d,[r13+8]
       add       r8d,r8d
       cmp       r8,0A
       je        short M00_L33
       call      qword ptr [7FF9F7AFC330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r12d,eax
       jmp       short M00_L34
M00_L33:
       mov       rax,[rcx]
       mov       rcx,[rcx+2]
       mov       r8,[rdx]
       xor       rax,r8
       xor       rcx,[rdx+2]
       or        rcx,rax
       sete      r12b
       movzx     r12d,r12b
M00_L34:
       jmp       near ptr M00_L15
M00_L35:
       xor       r12d,r12d
       jmp       near ptr M00_L15
M00_L36:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L37:
       xor       eax,eax
       mov       [rbx+10],rax
       jmp       short M00_L42
M00_L38:
       mov       rcx,[rbp-0A8]
       call      qword ptr [7FF9F82AC030]; DotNetTips.Spargine.Core.Enumeration+<GetAll>d__15`1[[System.__Canon, System.Private.CoreLib]].System.IDisposable.Dispose()
M00_L39:
       test      r14,r14
       je        short M00_L43
       mov       [rbp-98],r14
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+60]
       lea       r8,[rbp-98]
       mov       rdx,7FF9F82AD2E0
       cmp       [rcx],ecx
       call      qword ptr [7FF9F821F168]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
M00_L40:
       mov       rcx,rbx
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       xor       eax,eax
       mov       [rsi+18],eax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rsi+1C],eax
       jmp       near ptr M00_L00
M00_L41:
       xor       r14d,r14d
       jmp       short M00_L39
M00_L42:
       call      M00_L45
       jmp       short M00_L41
M00_L43:
       lea       rcx,[rbp-60]
       mov       edx,14
       mov       r8d,2
       call      qword ptr [7FF9F7AFC270]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler..ctor(Int32, Int32)
       lea       rcx,[rbp-60]
       mov       rdx,2B3C1A206E0
       call      qword ptr [7FF9F7AFC288]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendLiteral(System.String)
       lea       rcx,[rbp-60]
       mov       rdx,[rbp-0A0]
       call      qword ptr [7FF9F7E5E088]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted(System.String)
       lea       rcx,[rbp-60]
       mov       rdx,2B3C1A20718
       call      qword ptr [7FF9F7AFC288]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendLiteral(System.String)
       lea       rcx,[rbp-60]
       mov       rdx,7FF9F82AB7D8
       mov       r8,2B3C1A20760
       call      qword ptr [7FF9F7E5E028]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       lea       rcx,[rbp-60]
       mov       rdx,2B3C1A10C80
       call      qword ptr [7FF9F7AFC288]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendLiteral(System.String)
       lea       rcx,[rbp-60]
       call      qword ptr [7FF9F7AFC2A0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       mov       rbx,rax
       mov       ecx,1C3F
       mov       rdx,7FF9F7E95610
       call      qword ptr [7FF9F7AFF210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F7FE4078]
       int       3
M00_L44:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L45:
       sub       rsp,28
       mov       rcx,[rbp-0A8]
       call      qword ptr [7FF9F82AC030]; DotNetTips.Spargine.Core.Enumeration+<GetAll>d__15`1[[System.__Canon, System.Private.CoreLib]].System.IDisposable.Dispose()
       nop
       add       rsp,28
       ret
; Total bytes of code 1676
```
```assembly
; DotNetTips.Spargine.Core.Enumeration+<>c__DisplayClass13_0`1[[System.__Canon, System.Private.CoreLib]].<FromDisplayName>b__0(System.__Canon)
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
       je        short M01_L02
       test      rcx,rcx
       jne       short M01_L03
M01_L02:
       xor       eax,eax
       jmp       short M01_L00
M01_L03:
       mov       r8d,[rdx+8]
       cmp       r8d,[rcx+8]
       jne       short M01_L02
       lea       rax,[rdx+0C]
       add       rcx,0C
       mov       rbx,rcx
       mov       ecx,[rdx+8]
       add       ecx,ecx
       mov       r8d,ecx
       cmp       r8,0A
       jne       short M01_L04
       mov       rcx,[rax]
       mov       rax,[rax+2]
       mov       rdx,[rbx]
       xor       rcx,rdx
       xor       rax,[rbx+2]
       or        rax,rcx
       sete      al
       movzx     eax,al
       jmp       short M01_L05
M01_L04:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FF9F7AFC330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
M01_L05:
       jmp       short M01_L00
; Total bytes of code 120
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
       call      00007FFA576F1870
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
       mov       rax,7FF9F7D9C5A0
       mov       [rbp-78],rax
       lea       rax,[M02_L03]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFA57682C30
       call      rax
M02_L03:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFA57A4F778],0
       je        short M02_L04
       call      qword ptr [7FFA57A3D608]; CORINFO_HELP_STOP_FOR_GC
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
       call      00007FFA577004E0
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
       call      qword ptr [7FF9F82CCF30]; System.RuntimeTypeHandle.GetGCHandle(System.Runtime.InteropServices.GCHandleType)
       mov       rdx,rax
       lea       rcx,[rbx+10]
       xor       eax,eax
       lock cmpxchg [rcx],rdx
       test      rax,rax
       je        near ptr M02_L00
       lea       rcx,[rbp-40]
       call      qword ptr [7FF9F82C7288]
       jmp       near ptr M02_L00
M02_L09:
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M02_L10:
       mov       [rbp+10],rbx
       mov       rcx,rbx
       call      qword ptr [7FF9F7D65710]; System.RuntimeTypeHandle.<GetModule>g__GetModuleWorker|48_0(System.RuntimeType)
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
       call      00007FFA576EFBA0
       mov       r14,rax
       test      r14,r14
       cmove     r14,r15
       jmp       short M03_L00
M03_L03:
       lea       rcx,[r14+20]
       mov       r8,rdi
       mov       rdx,offset MT_System.Reflection.CerHashtable<System.String, System.Reflection.RuntimeFieldInfo[]>
       call      qword ptr [7FF9F7D67C90]; System.Reflection.CerHashtable`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Item(System.__Canon)
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
       jmp       qword ptr [7FF9F7D66910]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
M03_L04:
       jmp       near ptr M03_L01
M03_L05:
       lea       rcx,[r14+28]
       mov       r8,rdi
       mov       rdx,offset MT_System.Reflection.CerHashtable<System.String, System.Reflection.RuntimeFieldInfo[]>
       call      qword ptr [7FF9F7D67C90]; System.Reflection.CerHashtable`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Item(System.__Canon)
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
       jmp       qword ptr [7FF9F7D66910]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
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
       jmp       qword ptr [7FF9F7D66910]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
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
       mov       rdx,7FF9F8310C88
       call      qword ptr [7FF9F7AFF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rdx,7FF9F8310C68
       call      qword ptr [7FF9F7AFF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M05_L10:
       mov       rdx,rbx
       mov       r8d,edi
       call      qword ptr [7FF9F7D66AD8]; System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
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
       mov       rdx,7FF9F8310C68
       call      qword ptr [7FF9F7AFF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rdx,7FF9F83115C0
       call      qword ptr [7FF9F7AFF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M06_L05:
       mov       rdx,[rcx+18]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M06_L06
       jmp       short M06_L07
M06_L06:
       mov       rdx,7FF9F83115E0
       call      qword ptr [7FF9F7AFF630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdx,rax
M06_L07:
       mov       rcx,rdx
       call      qword ptr [7FF9F7AF5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
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
       mov       rdx,7FF9F8310C88
       call      qword ptr [7FF9F7AFF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF9F8165938]
       int       3
M06_L12:
       mov       rcx,[rdx+18]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M06_L13
       jmp       short M06_L14
M06_L13:
       mov       rcx,rdx
       mov       rdx,7FF9F8310EB8
       call      qword ptr [7FF9F7AFF630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FF9F8310EB8
       call      qword ptr [7FF9F7AFF630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       call      qword ptr [7FF9F7AF57A0]; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rbx
       mov       rdx,rbp
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       near ptr M06_L01
; Total bytes of code 486
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
       jne       near ptr M07_L03
       mov       rcx,offset MT_System.Reflection.FieldAccessor
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rdi+8]
       mov       rcx,[rcx+10]
       cmp       [rcx],cl
       call      qword ptr [7FF9F7D64B58]; System.Type.GetRootElementType()
       mov       rcx,rax
       mov       rax,offset MT_System.RuntimeType
       cmp       [rcx],rax
       jne       short M07_L04
M07_L00:
       test      rcx,rcx
       je        short M07_L05
       call      00007FFA576F2E70
       test      eax,eax
       jne       near ptr M07_L07
       mov       rcx,[rdi+8]
       mov       rcx,[rcx+10]
       mov       rdx,[rcx+18]
       test      dl,2
       jne       near ptr M07_L06
       mov       edx,[rdx]
       and       edx,0F0000
       cmp       edx,50000
       sete      dl
       movzx     edx,dl
M07_L01:
       test      edx,edx
       jne       short M07_L07
       mov       dword ptr [rdi+20],0F
M07_L02:
       lea       rcx,[rbx+30]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
M07_L03:
       mov       rcx,[rbx+30]
       mov       rdx,rsi
       cmp       [rcx],ecx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FF9F7F478E8]; System.Reflection.FieldAccessor.GetValue(System.Object)
M07_L04:
       mov       rax,[rcx]
       mov       rax,[rax+98]
       call      qword ptr [rax+8]
       mov       rcx,rax
       jmp       short M07_L00
M07_L05:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9F82C6DC0]
       mov       r8,rax
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF9F82C6DD8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M07_L06:
       xor       edx,edx
       jmp       short M07_L01
M07_L07:
       mov       dword ptr [rdi+20],11
       jmp       short M07_L02
; Total bytes of code 270
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rdx,rdx
       je        short M08_L00
       cmp       [rdx],rcx
       jne       short M08_L01
M08_L00:
       mov       rax,rdx
       ret
M08_L01:
       mov       rax,[rdx]
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M08_L00
M08_L02:
       test      rax,rax
       je        short M08_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M08_L00
       test      rax,rax
       je        short M08_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M08_L00
       test      rax,rax
       je        short M08_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M08_L00
       test      rax,rax
       je        short M08_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M08_L00
       jmp       short M08_L02
M08_L03:
       xor       edx,edx
       jmp       short M08_L00
; Total bytes of code 88
```
```assembly
; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       cmp       rbx,8
       jb        near ptr M09_L14
       cmp       rsi,rdi
       je        near ptr M09_L04
       cmp       rbx,20
       jae       near ptr M09_L06
       mov       rcx,7FF9F82B1878
       call      CORINFO_HELP_COUNTPROFILE32
       cmp       rbx,10
       jae       short M09_L01
       mov       rcx,7FF9F82B1890
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,7FF9F82B1894
       call      CORINFO_HELP_COUNTPROFILE32
       add       rbx,0FFFFFFFFFFFFFFF8
       mov       rcx,[rsi]
       sub       rcx,[rdi]
       mov       rax,[rsi+rbx]
       sub       rax,[rdi+rbx]
       or        rcx,rax
       sete      bl
       movzx     ebx,bl
M09_L00:
       mov       rcx,7FF9F82B185C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       eax,ebx
       vzeroupper
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M09_L01:
       xor       ebp,ebp
       add       rbx,0FFFFFFFFFFFFFFF0
       je        short M09_L03
       vmovups   xmm0,[rsi]
       vpcmpeqb  xmm0,xmm0,[rdi]
       vpmovmskb ecx,xmm0
       cmp       ecx,0FFFF
       jne       short M09_L05
M09_L02:
       add       rbp,10
       cmp       rbx,rbp
       ja        near ptr M09_L18
       mov       rcx,7FF9F82B187C
       call      CORINFO_HELP_COUNTPROFILE32
M09_L03:
       vmovups   xmm0,[rsi+rbx]
       vpcmpeqb  xmm0,xmm0,[rdi+rbx]
       vpmovmskb ecx,xmm0
       cmp       ecx,0FFFF
       jne       near ptr M09_L10
       mov       rcx,7FF9F82B1880
       call      CORINFO_HELP_COUNTPROFILE32
M09_L04:
       mov       rcx,7FF9F82B1860
       call      CORINFO_HELP_COUNTPROFILE32
       mov       eax,1
       vzeroupper
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M09_L05:
       mov       rcx,7FF9F82B188C
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M09_L09
M09_L06:
       xor       ebp,ebp
       add       rbx,0FFFFFFFFFFFFFFE0
       je        near ptr M09_L12
       vmovups   ymm0,[rsi]
       vpcmpeqb  ymm0,ymm0,[rdi]
       vpmovmskb ecx,ymm0
       cmp       ecx,0FFFFFFFF
       jne       short M09_L08
M09_L07:
       add       rbp,20
       cmp       rbx,rbp
       jbe       short M09_L11
       mov       rcx,7FF9F82B1870
       call      CORINFO_HELP_COUNTPROFILE32
       vmovups   ymm0,[rsi+rbp]
       vpcmpeqb  ymm0,ymm0,[rdi+rbp]
       vpmovmskb ecx,ymm0
       cmp       ecx,0FFFFFFFF
       je        short M09_L07
M09_L08:
       mov       rcx,7FF9F82B1874
       call      CORINFO_HELP_COUNTPROFILE32
M09_L09:
       mov       rcx,7FF9F82B1898
       call      CORINFO_HELP_COUNTPROFILE32
       xor       eax,eax
       vzeroupper
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M09_L10:
       mov       rcx,7FF9F82B1884
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M09_L09
M09_L11:
       mov       rcx,7FF9F82B1864
       call      CORINFO_HELP_COUNTPROFILE32
M09_L12:
       vmovups   ymm0,[rsi+rbx]
       vpcmpeqb  ymm0,ymm0,[rdi+rbx]
       vpmovmskb ecx,ymm0
       cmp       ecx,0FFFFFFFF
       jne       short M09_L13
       mov       rcx,7FF9F82B1868
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M09_L04
M09_L13:
       mov       rcx,7FF9F82B186C
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M09_L09
M09_L14:
       cmp       rbx,4
       jb        short M09_L15
       mov       rcx,7FF9F82B1858
       call      CORINFO_HELP_COUNTPROFILE32
       lea       rcx,[rbx-4]
       mov       eax,[rsi]
       sub       eax,[rdi]
       mov       edx,[rsi+rcx]
       sub       edx,[rdi+rcx]
       or        eax,edx
       sete      bl
       movzx     ebx,bl
       jmp       near ptr M09_L00
M09_L15:
       xor       ebp,ebp
       mov       r14,rbx
       and       r14,2
       je        short M09_L16
       mov       rcx,7FF9F82B1850
       call      CORINFO_HELP_COUNTPROFILE32
       movzx     ebp,word ptr [rsi]
       movzx     ecx,word ptr [rdi]
       sub       ebp,ecx
M09_L16:
       test      bl,1
       je        short M09_L17
       mov       rcx,7FF9F82B1854
       call      CORINFO_HELP_COUNTPROFILE32
       movzx     ecx,byte ptr [rsi+r14]
       movzx     eax,byte ptr [rdi+r14]
       sub       ecx,eax
       or        ebp,ecx
M09_L17:
       test      ebp,ebp
       sete      bl
       movzx     ebx,bl
       jmp       near ptr M09_L00
M09_L18:
       mov       rcx,7FF9F82B1888
       call      CORINFO_HELP_COUNTPROFILE32
       vmovups   xmm0,[rsi+rbp]
       vpcmpeqb  xmm0,xmm0,[rdi+rbp]
       vpmovmskb ecx,xmm0
       cmp       ecx,0FFFF
       jne       near ptr M09_L05
       jmp       near ptr M09_L02
; Total bytes of code 686
```
```assembly
; DotNetTips.Spargine.Core.Enumeration+<GetAll>d__15`1[[System.__Canon, System.Private.CoreLib]].System.IDisposable.Dispose()
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
       call      qword ptr [7FFA57549080]
       mov       rcx,[rax]
       imul      edx,edi,0B
       add       edx,esi
       mov       eax,100
       cmp       edx,100
       cmovle    edx,eax
       cmp       [rcx],ecx
       call      qword ptr [7FFA57568958]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
       mov       [rbx+8],rax
       test      rax,rax
       je        short M12_L01
       lea       rcx,[rax+10]
       mov       eax,[rax+8]
M12_L00:
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
M12_L01:
       xor       ecx,ecx
       xor       eax,eax
       jmp       short M12_L00
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
       call      qword ptr [7FFA5755C980]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       [rbx+10],esi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M13_L00:
       call      qword ptr [7FFA5755E310]
       int       3
M13_L01:
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
       jne       short M14_L01
       test      rdx,rdx
       je        short M14_L01
       lea       r8,[rbx+18]
       mov       ecx,[rbx+10]
       mov       eax,[r8+8]
       cmp       ecx,eax
       ja        short M14_L00
       mov       r8,[r8]
       mov       r10d,ecx
       lea       r10,[r8+r10*2]
       sub       eax,ecx
       mov       esi,[rdx+8]
       cmp       esi,eax
       ja        short M14_L01
       mov       r8d,esi
       add       r8,r8
       add       rdx,0C
       mov       rcx,r10
       call      qword ptr [7FFA5755C980]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       [rbx+10],esi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M14_L00:
       call      qword ptr [7FFA5755E310]
       int       3
M14_L01:
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
       jne       near ptr M15_L05
       test      rsi,rsi
       je        near ptr M15_L06
       mov       rcx,rsi
       call      qword ptr [7FFA575561F0]
       test      rax,rax
       jne       short M15_L01
       mov       rcx,rsi
       lea       r11,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       call      qword ptr [r11]
       mov       rdx,rax
M15_L00:
       test      rdx,rdx
       je        near ptr M15_L06
       lea       r8,[rbx+18]
       mov       ecx,[rbx+10]
       mov       eax,[r8+8]
       cmp       ecx,eax
       ja        near ptr M15_L07
       mov       r8,[r8]
       mov       r10d,ecx
       lea       r10,[r8+r10*2]
       sub       eax,ecx
       mov       esi,[rdx+8]
       cmp       esi,eax
       ja        near ptr M15_L08
       mov       r8d,esi
       add       r8,r8
       add       rdx,0C
       mov       rcx,r10
       call      qword ptr [7FFA5755C980]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       [rbx+10],esi
       jmp       near ptr M15_L06
M15_L01:
       mov       rcx,rsi
       call      qword ptr [7FFA57556228]
       test      rax,rax
       je        near ptr M15_L04
       mov       rcx,rsi
       call      qword ptr [7FFA57557468]
       mov       rsi,rax
M15_L02:
       mov       rcx,rsi
       lea       rdx,[rbx+18]
       mov       r9d,[rbx+10]
       mov       r8d,[rdx+8]
       cmp       r9d,r8d
       ja        near ptr M15_L07
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
       jne       short M15_L03
       mov       rcx,rbx
       call      qword ptr [7FFA57564070]
       jmp       short M15_L02
M15_L03:
       mov       ecx,[rsp+48]
       add       [rbx+10],ecx
       jmp       short M15_L06
M15_L04:
       mov       rcx,rsi
       call      qword ptr [7FFA57557460]
       mov       rcx,rax
       mov       r8,[rbx]
       lea       r11,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       xor       edx,edx
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       near ptr M15_L00
M15_L05:
       call      qword ptr [7FFA5754F130]
       mov       rdx,rax
       mov       rcx,rbx
       mov       r8,rsi
       xor       r9d,r9d
       call      qword ptr [7FFA57573778]
M15_L06:
       nop
       add       rsp,58
       pop       rbx
       pop       rsi
       ret
M15_L07:
       call      qword ptr [7FFA5755E310]
       int       3
M15_L08:
       mov       rcx,rbx
       call      qword ptr [7FFA57564048]
       jmp       short M15_L06
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
       ja        short M16_L01
       mov       rcx,[rcx]
       mov       [rsp+28],rcx
       mov       [rsp+30],eax
       lea       rcx,[rsp+28]
       call      qword ptr [7FFA5755AB88]; Precode of System.String.Ctor(System.ReadOnlySpan`1<Char>)
       mov       rdi,rax
       mov       rbp,[rbx+8]
       xor       eax,eax
       mov       [rbx+8],rax
       mov       [rsi],rax
       mov       [rsi+8],rax
       mov       [rbx+10],eax
       test      rbp,rbp
       je        short M16_L00
       call      qword ptr [7FFA57549080]
       mov       rcx,[rax]
       mov       rdx,rbp
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFA57568960]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
M16_L00:
       mov       rax,rdi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M16_L01:
       call      qword ptr [7FFA5755E310]
       int       3
; Total bytes of code 126
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       sub       rsp,88
       vzeroupper
       lea       rbp,[rsp+0C0]
       xor       eax,eax
       mov       [rbp-58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp-40],rax
       mov       [rbp+10],rcx
       mov       rsi,offset MT_DotNetTips.Spargine.Core.Enumeration+<GetAll>d__15<DotNetTips.Spargine.Extensions.NumericFormat>
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
       mov       [rbp-68],rdi
M00_L01:
       mov       r14,[rdi]
       cmp       r14,rsi
       jne       near ptr M00_L45
       mov       r15,rdi
       mov       [rbp-70],r15
       mov       ecx,[r15+18]
       test      ecx,ecx
       je        near ptr M00_L15
       cmp       ecx,1
       jne       near ptr M00_L49
       mov       dword ptr [r15+18],0FFFFFFFF
M00_L02:
       mov       rdi,[rbp-68]
       mov       r15,[rbp-70]
       inc       dword ptr [r15+20]
M00_L03:
       mov       ecx,[r15+20]
       mov       rax,[r15+10]
       cmp       ecx,[rax+8]
       jge       near ptr M00_L33
       cmp       ecx,[rax+8]
       jae       near ptr M00_L48
       mov       ecx,ecx
       mov       r13,[rax+rcx*8+10]
       mov       rcx,offset MT_System.Reflection.RtFieldInfo
       cmp       [r13],rcx
       jne       near ptr M00_L44
       mov       [rbp-78],r13
       cmp       qword ptr [r13+30],0
       jne       near ptr M00_L12
       mov       rcx,offset MT_System.Reflection.FieldAccessor
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       [rbp-90],r12
       lea       rcx,[r12+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[r12+8]
       mov       rax,[rcx+10]
       cmp       [rax],al
M00_L04:
       mov       rcx,offset MT_System.RuntimeType
       cmp       [rax],rcx
       jne       near ptr M00_L43
       mov       [rbp-98],rax
       mov       rcx,[rax+18]
       mov       rdx,7FFA576F06C0
       call      rdx
       movzx     ebx,al
       mov       rdi,[rbp-98]
       cmp       dword ptr [7FFA57A4F778],0
       jne       near ptr M00_L41
M00_L05:
       cmp       ebx,1D
       ja        short M00_L06
       mov       ecx,1FEF7FFF
       bt        ecx,ebx
       jae       near ptr M00_L42
M00_L06:
       cmp       ebx,10
       sete      r15b
       movzx     r15d,r15b
M00_L07:
       test      r15d,r15d
       jne       near ptr M00_L40
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+98]
       call      qword ptr [rax+8]
       test      rax,rax
       je        near ptr M00_L47
       mov       rcx,rax
       call      00007FFA576F2E70
       test      eax,eax
       jne       short M00_L10
       mov       r12,[rbp-90]
       mov       rcx,[r12+8]
       mov       rcx,[rcx+10]
       mov       rdx,[rcx+18]
       test      dl,2
       je        short M00_L08
       xor       eax,eax
       jmp       short M00_L09
M00_L08:
       mov       eax,[rdx]
       and       eax,0F0000
       cmp       eax,50000
       sete      al
       movzx     eax,al
M00_L09:
       test      eax,eax
       jne       short M00_L10
       mov       dword ptr [r12+20],0F
       jmp       short M00_L11
M00_L10:
       mov       r12,[rbp-90]
       mov       dword ptr [r12+20],11
M00_L11:
       mov       r13,[rbp-78]
       lea       rcx,[r13+30]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
M00_L12:
       mov       rcx,[r13+30]
       xor       edx,edx
       cmp       [rcx],ecx
       call      qword ptr [7FF9F7F478B8]; System.Reflection.FieldAccessor.GetValue(System.Object)
M00_L13:
       mov       rdx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.NumericFormat
       call      qword ptr [7FF9F7AF6850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M00_L02
       mov       r15,[rbp-70]
       lea       rcx,[r15+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [r15+18],1
       mov       rdi,[rbp-68]
       mov       r14,[rdi+8]
M00_L14:
       mov       [rbp-40],r14
       mov       rbx,[rbp+10]
       mov       r15,[rbx+60]
       mov       rdx,[rbp-40]
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r15+8],rcx
       mov       [rbp+10],rbx
       jmp       near ptr M00_L01
M00_L15:
       mov       dword ptr [r15+18],0FFFFFFFF
       mov       rcx,235F7B51168
       mov       r13,[rcx]
       test      r13,r13
       je        short M00_L18
M00_L16:
       cmp       [r13],r13b
       lea       r12,[r13+50]
       mov       rcx,[r12]
       test      rcx,rcx
       jne       short M00_L17
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache+MemberInfoCache<System.Reflection.RuntimeFieldInfo>
       call      CORINFO_HELP_NEWSFAST
       mov       rcx,rax
       mov       [rbp-88],rcx
       lea       rcx,[rcx+10]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r12
       mov       rdx,[rbp-88]
       xor       r8d,r8d
       call      00007FFA576EFBA0
       mov       rcx,rax
       test      rcx,rcx
       jne       short M00_L17
       mov       r13,[rbp-88]
       mov       rcx,r13
M00_L17:
       cmp       byte ptr [rcx+18],0
       je        short M00_L19
       mov       rax,[rcx+8]
       jmp       short M00_L20
M00_L18:
       mov       rcx,2768E7D0698
       call      qword ptr [7FF9F7AF7C48]; System.RuntimeType.InitializeCache()
       mov       r13,rax
       jmp       short M00_L16
M00_L19:
       xor       edx,edx
       xor       r8d,r8d
       mov       r9d,2
       call      qword ptr [7FF9F7AFD2C0]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
M00_L20:
       mov       r13d,[rax+8]
       mov       edx,r13d
       xor       r8d,r8d
       mov       [rbp-58],r8
       mov       [rbp-50],r8
       mov       [rbp-48],r8d
       mov       [rbp-44],edx
       test      r13d,r13d
       jle       short M00_L25
       lea       r12,[rax+10]
M00_L21:
       mov       rax,[r12]
       mov       [rbp-80],rax
       mov       edx,[rax+18]
       mov       r8d,edx
       and       r8d,18
       cmp       r8d,edx
       jne       short M00_L24
       mov       rax,[rbp-80]
       cmp       dword ptr [rbp-48],0
       je        near ptr M00_L29
       cmp       dword ptr [rbp-48],1
       je        short M00_L27
       mov       edx,[rbp-44]
       cmp       edx,[rbp-48]
       je        near ptr M00_L36
M00_L22:
       movsxd    rdx,dword ptr [rbp-48]
       mov       rcx,[rbp-58]
       mov       r8,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
M00_L23:
       mov       edx,[rbp-48]
       inc       edx
       mov       [rbp-48],edx
M00_L24:
       add       r12,8
       dec       r13d
       jne       short M00_L21
M00_L25:
       mov       r13,[rbp-58]
       mov       r12,[rbp-50]
       mov       eax,[rbp-48]
       mov       [rbp-60],eax
       test      eax,eax
       jne       short M00_L30
       mov       rcx,235F9801BE0
       mov       r13,[rcx]
M00_L26:
       lea       rcx,[r15+10]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r15+20],ecx
       jmp       near ptr M00_L03
M00_L27:
       cmp       dword ptr [rbp-44],2
       jl        near ptr M00_L35
M00_L28:
       movsxd    rdx,dword ptr [rbp-44]
       mov       rcx,offset MT_System.Reflection.FieldInfo[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       [rbp-58],rax
       mov       rcx,[rbp-58]
       mov       r8,[rbp-50]
       xor       edx,edx
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       rax,[rbp-80]
       jmp       near ptr M00_L22
M00_L29:
       mov       [rbp-50],rax
       jmp       near ptr M00_L23
M00_L30:
       cmp       eax,1
       je        short M00_L32
       test      eax,eax
       jl        near ptr M00_L46
       test      r13,r13
       je        near ptr M00_L37
       cmp       [r13+8],eax
       jne       near ptr M00_L38
M00_L31:
       jmp       short M00_L26
M00_L32:
       mov       rcx,offset MT_System.Reflection.FieldInfo[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r13,rax
       mov       rcx,r13
       mov       r8,r12
       xor       edx,edx
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       near ptr M00_L26
M00_L33:
       xor       ecx,ecx
       mov       r15,[rbp-70]
       mov       [r15+10],rcx
       jmp       near ptr M00_L49
M00_L34:
       mov       rcx,rdi
       mov       r11,7FF9F7A409A0
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L14
M00_L35:
       mov       dword ptr [rbp-44],4
       jmp       near ptr M00_L28
M00_L36:
       mov       r10d,[rbp-44]
       add       r10d,r10d
       mov       [rbp-5C],r10d
       lea       rdx,[rbp-58]
       mov       r8d,r10d
       mov       rcx,7FF9F7CA8150
       call      qword ptr [7FF9F7AFD4E8]; System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
       mov       edx,[rbp-5C]
       mov       [rbp-44],edx
       mov       rax,[rbp-80]
       jmp       near ptr M00_L22
M00_L37:
       mov       edx,eax
       mov       rcx,offset MT_System.Reflection.FieldInfo[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r13,rax
       jmp       near ptr M00_L31
M00_L38:
       mov       edx,eax
       mov       rcx,offset MT_System.Reflection.FieldInfo[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r12,rax
       lea       rcx,[r12+10]
       lea       rdx,[r13+10]
       mov       r8d,[r13+8]
       mov       r13d,[rbp-60]
       cmp       r13d,r8d
       jle       short M00_L39
       mov       r13d,r8d
M00_L39:
       mov       r8d,r13d
       shl       r8,3
       call      qword ptr [7FF9F7AF57A0]; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r13,r12
       jmp       near ptr M00_L31
M00_L40:
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+68]
       call      qword ptr [rax+8]
       mov       rdi,rax
       mov       rax,rdi
       jmp       near ptr M00_L04
M00_L41:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L05
M00_L42:
       mov       r15d,1
       jmp       near ptr M00_L07
M00_L43:
       mov       rcx,rax
       mov       [rbp-98],rax
       mov       rdx,[rax]
       mov       rdx,[rdx+68]
       call      qword ptr [rdx]
       mov       r15d,eax
       mov       rdi,[rbp-98]
       jmp       near ptr M00_L07
M00_L44:
       mov       rcx,r13
       xor       edx,edx
       mov       rax,[r13]
       mov       rax,[rax+58]
       call      qword ptr [rax]
       jmp       near ptr M00_L13
M00_L45:
       mov       rcx,rdi
       mov       r11,7FF9F7A40998
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L34
       jmp       short M00_L49
M00_L46:
       mov       ecx,45
       mov       edx,0D
       call      qword ptr [7FF9F8155908]
       int       3
M00_L47:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9F81DFB28]
       mov       r8,rax
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FF9F81DFB40]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L48:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L49:
       cmp       r14,rsi
       jne       short M00_L52
       xor       ecx,ecx
       mov       rdi,[rbp-68]
       mov       [rdi+10],rcx
       mov       dword ptr [rdi+18],0FFFFFFFE
M00_L50:
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
       mov       rdi,[rbp-68]
       mov       rcx,rdi
       mov       r11,7FF9F7A409A8
       call      qword ptr [r11]
       jmp       short M00_L50
       sub       rsp,28
       vzeroupper
       mov       rdi,[rbp-68]
       mov       r14,[rdi]
       mov       rsi,offset MT_DotNetTips.Spargine.Core.Enumeration+<GetAll>d__15<DotNetTips.Spargine.Extensions.NumericFormat>
       cmp       r14,rsi
       jne       short M00_L53
       xor       ecx,ecx
       mov       [rdi+10],rcx
       mov       dword ptr [rdi+18],0FFFFFFFE
       jmp       short M00_L54
M00_L53:
       mov       rcx,rdi
       mov       r11,7FF9F7A409A8
       call      qword ptr [r11]
M00_L54:
       nop
       add       rsp,28
       ret
; Total bytes of code 1680
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
       lea       rax,[7FF9F7BBEB08]
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
       call      qword ptr [7FF9F7A3A578]; Precode of System.RuntimeType.IsInstanceOfType(System.Object)
       test      eax,eax
       jne       short M01_L04
       test      rsi,rsi
       jne       near ptr M01_L14
       jmp       near ptr M01_L13
M01_L04:
       cmp       [rsi],sil
       mov       rax,[rbx+10]
       mov       rax,[rsi+rax+8]
       jmp       short M01_L01
       mov       rcx,[rbx+8]
       mov       rcx,[rcx+10]
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FF9F7A3A578]; Precode of System.RuntimeType.IsInstanceOfType(System.Object)
       test      eax,eax
       jne       short M01_L05
       test      rsi,rsi
       jne       near ptr M01_L14
       jmp       near ptr M01_L13
M01_L05:
       cmp       [rsi],sil
       mov       rdx,[rbx+10]
       lea       rdx,[rsi+rdx+8]
       mov       rcx,[rbx+18]
       call      qword ptr [7FF9F81DFBB8]
       jmp       near ptr M01_L01
       mov       rcx,[rbx+8]
       mov       rcx,[rcx+10]
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FF9F7A3A578]; Precode of System.RuntimeType.IsInstanceOfType(System.Object)
       test      eax,eax
       jne       short M01_L06
       test      rsi,rsi
       jne       near ptr M01_L14
       jmp       near ptr M01_L13
M01_L06:
       cmp       [rsi],sil
       mov       rcx,[rbx+10]
       mov       rsi,[rsi+rcx+8]
       mov       rcx,[rbx+8]
       mov       rdx,[rcx+28]
       test      rdx,rdx
       jne       short M01_L07
       call      qword ptr [7FF9F7F47840]; System.Reflection.RtFieldInfo.InitializeFieldType()
       mov       rdx,rax
M01_L07:
       mov       rcx,rsi
       call      qword ptr [7FF9F81DFBA0]
       jmp       near ptr M01_L01
       mov       rcx,[rbx+18]
       mov       rdx,[rbx+10]
       call      qword ptr [7FF9F81DFBB8]
       jmp       near ptr M01_L01
       mov       rcx,[rbx+18]
       mov       rdx,[rbx+10]
       mov       rdx,[rdx]
       cmp       [rdx],dl
       add       rdx,8
       call      qword ptr [7FF9F81DFBB8]
       jmp       near ptr M01_L01
       mov       rcx,[rbx+10]
       mov       rsi,[rcx]
       mov       rcx,[rbx+8]
       mov       rdx,[rcx+28]
       test      rdx,rdx
       jne       short M01_L08
       call      qword ptr [7FF9F7F47840]; System.Reflection.RtFieldInfo.InitializeFieldType()
       mov       rdx,rax
M01_L08:
       mov       rcx,rsi
       call      qword ptr [7FF9F81DFBA0]
       jmp       near ptr M01_L01
       mov       rcx,rbx
       call      qword ptr [7FF9F7F478D0]; System.Reflection.FieldAccessor.IsStatic()
       test      eax,eax
       jne       short M01_L09
       mov       rcx,[rbx+8]
       mov       rcx,[rcx+10]
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FF9F7A3A578]; Precode of System.RuntimeType.IsInstanceOfType(System.Object)
       test      eax,eax
       jne       short M01_L09
       test      rsi,rsi
       jne       near ptr M01_L14
       jmp       near ptr M01_L13
M01_L09:
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,[rbx+8]
       mov       rdi,rcx
       mov       rdx,[rcx+28]
       test      rdx,rdx
       jne       short M01_L10
       call      qword ptr [7FF9F7F47840]; System.Reflection.RtFieldInfo.InitializeFieldType()
       mov       rdx,rax
M01_L10:
       mov       r8,rdx
       test      r8,r8
       je        short M01_L11
       mov       rcx,offset MT_System.RuntimeType
       cmp       [r8],rcx
       je        short M01_L11
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M01_L11:
       lea       r9,[rsp+28]
       mov       [rsp+20],r9
       mov       r9,[rbx+8]
       mov       r9,[r9+10]
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9F7F478E8]; System.RuntimeFieldHandle.GetValue(System.Reflection.RtFieldInfo, System.Object, System.RuntimeType, System.RuntimeType, Boolean ByRef)
       mov       rsi,rax
       cmp       byte ptr [rsp+28],0
       je        short M01_L12
       mov       rcx,rbx
       call      qword ptr [7FF9F7F47900]; System.Reflection.FieldAccessor.Initialize()
M01_L12:
       mov       rax,rsi
       jmp       near ptr M01_L01
       mov       rcx,rbx
       call      qword ptr [7FF9F7F478D0]; System.Reflection.FieldAccessor.IsStatic()
       test      eax,eax
       jne       short M01_L15
       mov       rcx,[rbx+8]
       mov       rcx,[rcx+10]
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FF9F7A3A578]; Precode of System.RuntimeType.IsInstanceOfType(System.Object)
       test      eax,eax
       jne       short M01_L15
       test      rsi,rsi
       jne       short M01_L14
M01_L13:
       call      qword ptr [7FF9F81DFBD0]
       int       3
M01_L14:
       mov       rdx,[rbx+8]
       mov       rcx,rsi
       call      qword ptr [7FF9F81DFBE8]
       int       3
M01_L15:
       mov       dword ptr [rsp+28],1
       mov       rdi,[rbx+8]
       mov       rcx,[rbx+8]
       mov       rdx,[rcx+28]
       test      rdx,rdx
       jne       short M01_L16
       call      qword ptr [7FF9F7F47840]; System.Reflection.RtFieldInfo.InitializeFieldType()
       mov       rdx,rax
M01_L16:
       mov       rcx,offset MT_System.RuntimeType
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       r8,rax
       lea       r9,[rsp+28]
       mov       [rsp+20],r9
       mov       r9,[rbx+8]
       mov       r9,[r9+10]
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9F7F478E8]; System.RuntimeFieldHandle.GetValue(System.Reflection.RtFieldInfo, System.Object, System.RuntimeType, System.RuntimeType, Boolean ByRef)
       jmp       near ptr M01_L01
       mov       rcx,[rbx+8]
       cmp       [rcx],ecx
       call      qword ptr [7FF9F7CA74B8]; Precode of System.Reflection.RuntimeFieldInfo.get_DeclaringType()
       test      rax,rax
       je        short M01_L17
       mov       rcx,[rbx+8]
       cmp       [rcx],ecx
       call      qword ptr [7FF9F7CA74B8]; Precode of System.Reflection.RuntimeFieldInfo.get_DeclaringType()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+0B0]
       call      qword ptr [rax]
       test      eax,eax
       je        short M01_L17
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9F81DFC00]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F7F45D28]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L17:
       mov       rcx,[rbx+8]
       cmp       [rcx],ecx
       call      qword ptr [7FF9F7CA74B8]; Precode of System.Reflection.RuntimeFieldInfo.get_DeclaringType()
       test      rax,rax
       je        short M01_L19
       mov       rcx,[rbx+8]
       mov       rdx,[rcx+28]
       test      rdx,rdx
       jne       short M01_L18
       call      qword ptr [7FF9F7F47840]; System.Reflection.RtFieldInfo.InitializeFieldType()
       mov       rdx,rax
M01_L18:
       mov       rcx,offset MT_System.RuntimeType
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF9F7C95398]; System.RuntimeType.get_IsNullableOfT()
       test      eax,eax
       je        short M01_L19
       mov       rcx,offset MT_System.NotSupportedException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F81DFC18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L19:
       mov       rcx,offset MT_System.FieldAccessException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9F81DFC30]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 915
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rdx,rdx
       je        short M02_L00
       cmp       [rdx],rcx
       jne       short M02_L01
M02_L00:
       mov       rax,rdx
       ret
M02_L01:
       mov       rax,[rdx]
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M02_L00
M02_L02:
       test      rax,rax
       je        short M02_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M02_L00
       test      rax,rax
       je        short M02_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M02_L00
       test      rax,rax
       je        short M02_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M02_L00
       test      rax,rax
       je        short M02_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M02_L00
       jmp       short M02_L02
M02_L03:
       xor       edx,edx
       jmp       short M02_L00
; Total bytes of code 88
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
       call      00007FFA576F1870
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
       mov       rax,7FF9F7C56D90
       mov       [rbp-78],rax
       lea       rax,[M03_L03]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFA57682C30
       call      rax
M03_L03:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFA57A4F778],0
       je        short M03_L04
       call      qword ptr [7FFA57A3D608]; CORINFO_HELP_STOP_FOR_GC
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
       call      00007FFA577004E0
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
       call      qword ptr [7FF9F8296160]; System.RuntimeTypeHandle.GetGCHandle(System.Runtime.InteropServices.GCHandleType)
       mov       rdx,rax
       lea       rcx,[rbx+10]
       xor       eax,eax
       lock cmpxchg [rcx],rdx
       test      rax,rax
       je        near ptr M03_L00
       lea       rcx,[rbp-40]
       call      qword ptr [7FF9F82949D8]
       jmp       near ptr M03_L00
M03_L09:
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M03_L10:
       mov       [rbp+10],rbx
       mov       rcx,rbx
       call      qword ptr [7FF9F7AF7C90]; System.RuntimeTypeHandle.<GetModule>g__GetModuleWorker|48_0(System.RuntimeType)
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
       mov       rax,7B741015C56F
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
       mov       rdx,2768E7C0008
       call      qword ptr [7FF9F7AFD320]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].GetListByName(System.String, System.Span`1<Byte>, MemberListType, CacheType)
       mov       [rbp+18],rax
M04_L01:
       lea       rdx,[rbp+18]
       mov       rcx,rsi
       mov       r8,rbx
       mov       r9d,edi
       call      qword ptr [7FF9F7AFD578]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Insert(System.__Canon[] ByRef, System.String, MemberListType)
       mov       rax,[rbp+18]
       mov       r8,7B741015C56F
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
       mov       rcx,235F9800220
       mov       rcx,[rcx]
       mov       rdx,rbx
       call      qword ptr [7FF9F7C84930]; Precode of System.Text.UTF8Encoding.GetByteCount(System.String)
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
       call      qword ptr [7FF9F7AFD320]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].GetListByName(System.String, System.Span`1<Byte>, MemberListType, CacheType)
       mov       [rbp+18],rax
       jmp       near ptr M04_L01
; Total bytes of code 348
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
       jmp       qword ptr [7FF9F7AFD8F0]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
M05_L00:
       call      qword ptr [7FF9F81DF918]
       int       3
M05_L01:
       mov       rcx,rax
       mov       rdx,r8
       add       rsp,28
       jmp       near ptr 00007FFA57737B10
M05_L02:
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
       jl        short M06_L01
       mov       rdi,[rsi]
       test      rdi,rdi
       je        short M06_L02
       cmp       [rdi+8],ebx
       jne       short M06_L05
M06_L00:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M06_L01:
       mov       ecx,45
       mov       edx,0D
       call      qword ptr [7FF9F8155908]
       int       3
M06_L02:
       mov       rdx,[rcx+18]
       mov       rax,[rdx+18]
       test      rax,rax
       je        short M06_L03
       mov       rcx,rax
       jmp       short M06_L04
M06_L03:
       mov       rdx,7FF9F8243360
       call      qword ptr [7FF9F7D77AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M06_L04:
       mov       edx,ebx
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdx,rax
       mov       rcx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       short M06_L00
M06_L05:
       mov       rdx,[rcx+18]
       mov       rax,[rdx+18]
       test      rax,rax
       je        short M06_L06
       mov       rcx,rax
       jmp       short M06_L07
M06_L06:
       mov       rdx,7FF9F8243360
       call      qword ptr [7FF9F7D77AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M06_L07:
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
       call      qword ptr [7FF9F7AF57A0]; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rsi
       mov       rdx,rbp
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       near ptr M06_L00
; Total bytes of code 214
```
```assembly
; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       sub       rsp,28
       cmp       r8,4000
       ja        short M07_L02
       call      00007FFA576E5D60
       cmp       dword ptr [7FFA57A4F778],0
       jne       short M07_L01
M07_L00:
       add       rsp,28
       ret
M07_L01:
       call      CORINFO_HELP_POLL_GC
       jmp       short M07_L00
M07_L02:
       add       rsp,28
       jmp       qword ptr [7FF9F81DFCA8]
; Total bytes of code 49
```

