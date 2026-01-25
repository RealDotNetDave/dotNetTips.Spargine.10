## .NET 10.0.2 (10.0.2, 10.0.225.61305), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Enumeration+<>c__DisplayClass16_0<DotNetTips.Spargine.Extensions.NumericFormat>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rsi,1AC8C2006C0
       mov       [rbx+8],rsi
       mov       rdx,rsi
       mov       ecx,[rdx+8]
       test      ecx,ecx
       sete      al
       movzx     eax,al
       cmp       eax,ecx
       jae       near ptr M00_L45
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Extensions.NumericFormat, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       [rbp-0A0],rsi
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
       jne       near ptr M00_L41
       mov       r14d,[rsi+1C]
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       cmp       r14d,eax
       jne       near ptr M00_L41
       xor       ecx,ecx
       mov       [rsi+18],ecx
M00_L00:
       mov       rcx,rsi
       mov       [rbp-0A8],rcx
       mov       rax,offset DotNetTips.Spargine.Core.Enumeration+<>c__DisplayClass16_0`1[[System.__Canon, System.Private.CoreLib]].<FromDisplayName>b__0(System.__Canon)
       cmp       [rdi+18],rax
       jne       near ptr M00_L10
M00_L01:
       mov       rcx,[rbp-0A8]
       mov       rbx,rcx
       mov       esi,[rbx+18]
       test      esi,esi
       jne       near ptr M00_L19
       mov       dword ptr [rbx+18],0FFFFFFFF
       mov       rax,16BF6E91178
       mov       r14,[rax]
       test      r14,r14
       jne       short M00_L02
       mov       rcx,1AC8C200788
       call      qword ptr [7FF86E8956C8]; System.RuntimeType.InitializeCache()
       jmp       short M00_L03
M00_L02:
       mov       rax,r14
M00_L03:
       mov       rcx,rax
       xor       edx,edx
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FF86ED87FA8]; System.RuntimeType+RuntimeTypeCache.GetFieldList(MemberListType, System.String)
       mov       rsi,rax
       mov       r14d,[rsi+8]
       mov       r8d,r14d
       lea       rcx,[rbp-90]
       mov       r15,offset MT_System.RuntimeType+ListBuilder<System.Reflection.FieldInfo>
       mov       rdx,r15
       call      qword ptr [7FF86ED87FC0]; System.RuntimeType+ListBuilder`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
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
       call      qword ptr [7FF86E896AC0]; System.RuntimeType+ListBuilder`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
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
       call      qword ptr [7FF86E896B38]; System.RuntimeType+ListBuilder`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       lea       rcx,[rbx+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+20],ecx
M00_L07:
       mov       eax,[rbx+20]
       mov       r8,[rbx+10]
       cmp       eax,[r8+8]
       jge       near ptr M00_L38
       cmp       eax,[r8+8]
       jae       near ptr M00_L37
       mov       edx,eax
       mov       r10,[r8+rdx*8+10]
       mov       rdx,offset MT_System.Reflection.RtFieldInfo
       cmp       [r10],rdx
       jne       near ptr M00_L20
       mov       rcx,r10
       xor       edx,edx
       call      qword ptr [7FF86E969340]; System.Reflection.RtFieldInfo.GetValue(System.Object)
M00_L08:
       mov       rdx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.NumericFormat
       call      qword ptr [7FF86E666850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r14,rax
       mov       rdx,r14
       test      rdx,rdx
       je        near ptr M00_L22
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+18],1
       mov       r15,[rdi+8]
       mov       r13,[r14+8]
       mov       rdx,[r15+8]
       cmp       r13,rdx
       jne       near ptr M00_L14
       mov       r12d,1
M00_L09:
       test      r12d,r12d
       je        near ptr M00_L01
       jmp       near ptr M00_L39
M00_L10:
       mov       rcx,[rbp-0A8]
       mov       rbx,rcx
       mov       esi,[rbx+18]
       test      esi,esi
       je        near ptr M00_L23
       jmp       near ptr M00_L29
M00_L11:
       mov       eax,[rbx+20]
       mov       r8,[rbx+10]
       cmp       eax,[r8+8]
       jge       near ptr M00_L38
       cmp       eax,[r8+8]
       jae       near ptr M00_L37
       mov       edx,eax
       mov       r10,[r8+rdx*8+10]
       mov       rdx,offset MT_System.Reflection.RtFieldInfo
       cmp       [r10],rdx
       jne       near ptr M00_L31
       mov       rcx,r10
       xor       edx,edx
       call      qword ptr [7FF86E969340]; System.Reflection.RtFieldInfo.GetValue(System.Object)
M00_L12:
       mov       rdx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.NumericFormat
       call      qword ptr [7FF86E666850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r14,rax
       mov       rdx,r14
       test      rdx,rdx
       je        near ptr M00_L30
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+18],1
       mov       rcx,offset DotNetTips.Spargine.Core.Enumeration+<>c__DisplayClass16_0`1[[System.__Canon, System.Private.CoreLib]].<FromDisplayName>b__0(System.__Canon)
       cmp       [rdi+18],rcx
       jne       near ptr M00_L32
       mov       r15,[rdi+8]
       mov       r13,[r14+8]
       mov       rdx,[r15+8]
       cmp       r13,rdx
       jne       near ptr M00_L33
       mov       r12d,1
M00_L13:
       test      r12d,r12d
       je        near ptr M00_L10
       jmp       near ptr M00_L39
M00_L14:
       test      r13,r13
       je        short M00_L15
       test      rdx,rdx
       jne       short M00_L16
M00_L15:
       xor       r12d,r12d
       jmp       near ptr M00_L09
M00_L16:
       mov       ecx,[r13+8]
       cmp       ecx,[rdx+8]
       jne       short M00_L15
       lea       rcx,[r13+0C]
       add       rdx,0C
       mov       r8d,[r13+8]
       add       r8d,r8d
       cmp       r8,0A
       jne       short M00_L17
       mov       rax,[rcx]
       mov       rcx,[rcx+2]
       mov       r8,[rdx]
       xor       rax,r8
       xor       rcx,[rdx+2]
       or        rcx,rax
       sete      r12b
       movzx     r12d,r12b
       jmp       short M00_L18
M00_L17:
       call      qword ptr [7FF86E66C330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r12d,eax
M00_L18:
       jmp       near ptr M00_L09
M00_L19:
       cmp       esi,1
       je        short M00_L21
       jmp       near ptr M00_L43
M00_L20:
       mov       rcx,r10
       xor       edx,edx
       mov       rax,[r10]
       mov       rax,[rax+58]
       call      qword ptr [rax]
       jmp       near ptr M00_L08
M00_L21:
       mov       dword ptr [rbx+18],0FFFFFFFF
M00_L22:
       inc       dword ptr [rbx+20]
       jmp       near ptr M00_L07
M00_L23:
       mov       dword ptr [rbx+18],0FFFFFFFF
       mov       rax,16BF6E91178
       mov       r14,[rax]
       test      r14,r14
       jne       short M00_L24
       mov       rcx,1AC8C200788
       call      qword ptr [7FF86E8956C8]; System.RuntimeType.InitializeCache()
       jmp       short M00_L25
M00_L24:
       mov       rax,r14
M00_L25:
       mov       rcx,rax
       xor       edx,edx
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FF86ED87FA8]; System.RuntimeType+RuntimeTypeCache.GetFieldList(MemberListType, System.String)
       mov       rsi,rax
       mov       r8d,[rsi+8]
       lea       rcx,[rbp-90]
       mov       r15,offset MT_System.RuntimeType+ListBuilder<System.Reflection.FieldInfo>
       mov       rdx,r15
       call      qword ptr [7FF86ED87FC0]; System.RuntimeType+ListBuilder`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       xor       r13d,r13d
       cmp       dword ptr [rsi+8],0
       jle       short M00_L28
M00_L26:
       mov       ecx,r13d
       mov       r8,[rsi+rcx*8+10]
       mov       ecx,[r8+18]
       mov       edx,ecx
       and       edx,18
       cmp       edx,ecx
       jne       short M00_L27
       lea       rcx,[rbp-90]
       mov       rdx,r15
       call      qword ptr [7FF86E896AC0]; System.RuntimeType+ListBuilder`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
M00_L27:
       inc       r13d
       cmp       [rsi+8],r13d
       jg        short M00_L26
M00_L28:
       vmovdqu   xmm0,xmmword ptr [rbp-90]
       vmovdqu   xmmword ptr [rbp-78],xmm0
       mov       rcx,[rbp-80]
       mov       [rbp-68],rcx
       lea       rcx,[rbp-78]
       mov       rdx,r15
       call      qword ptr [7FF86E896B38]; System.RuntimeType+ListBuilder`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       lea       rcx,[rbx+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+20],ecx
       jmp       near ptr M00_L11
M00_L29:
       cmp       esi,1
       jne       near ptr M00_L43
       mov       dword ptr [rbx+18],0FFFFFFFF
M00_L30:
       inc       dword ptr [rbx+20]
       jmp       near ptr M00_L11
M00_L31:
       mov       rcx,r10
       xor       edx,edx
       mov       rax,[r10]
       mov       rax,[rax+58]
       call      qword ptr [rax]
       jmp       near ptr M00_L12
M00_L32:
       mov       rdx,r14
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       mov       r12d,eax
       jmp       near ptr M00_L13
M00_L33:
       test      r13,r13
       je        short M00_L36
       test      rdx,rdx
       je        short M00_L36
       mov       ecx,[r13+8]
       cmp       ecx,[rdx+8]
       jne       short M00_L36
       lea       rcx,[r13+0C]
       add       rdx,0C
       mov       r8d,[r13+8]
       add       r8d,r8d
       cmp       r8,0A
       je        short M00_L34
       call      qword ptr [7FF86E66C330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r12d,eax
       jmp       short M00_L35
M00_L34:
       mov       rax,[rcx]
       mov       rcx,[rcx+2]
       mov       r8,[rdx]
       xor       rax,r8
       xor       rcx,[rdx+2]
       or        rcx,rax
       sete      r12b
       movzx     r12d,r12b
M00_L35:
       jmp       near ptr M00_L13
M00_L36:
       xor       r12d,r12d
       jmp       near ptr M00_L13
M00_L37:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L38:
       xor       eax,eax
       mov       [rbx+10],rax
       jmp       short M00_L43
M00_L39:
       mov       rcx,[rbp-0A8]
       call      qword ptr [7FF86ED78570]; DotNetTips.Spargine.Core.Enumeration+<GetAll>d__18`1[[System.__Canon, System.Private.CoreLib]].System.IDisposable.Dispose()
M00_L40:
       test      r14,r14
       je        short M00_L44
       mov       [rbp-98],r14
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+60]
       lea       r8,[rbp-98]
       mov       rdx,7FF86ED79820
       cmp       [rcx],ecx
       call      qword ptr [7FF86ED1F078]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       mov       rcx,rbx
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       xor       eax,eax
       mov       [rsi+18],eax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rsi+1C],eax
       jmp       near ptr M00_L00
M00_L42:
       xor       r14d,r14d
       jmp       short M00_L40
M00_L43:
       call      M00_L46
       jmp       short M00_L42
M00_L44:
       lea       rcx,[rbp-60]
       mov       edx,14
       mov       r8d,2
       call      qword ptr [7FF86E66C270]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler..ctor(Int32, Int32)
       lea       rcx,[rbp-60]
       mov       rdx,1AC8C200708
       call      qword ptr [7FF86E66C288]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendLiteral(System.String)
       lea       rcx,[rbp-60]
       mov       rdx,[rbp-0A0]
       call      qword ptr [7FF86E95E088]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted(System.String)
       lea       rcx,[rbp-60]
       mov       rdx,1AC8C200740
       call      qword ptr [7FF86E66C288]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendLiteral(System.String)
       lea       rcx,[rbp-60]
       mov       rdx,7FF86ED77D18
       mov       r8,1AC8C200788
       call      qword ptr [7FF86E95E028]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       lea       rcx,[rbp-60]
       mov       rdx,1AC8C1F0C80
       call      qword ptr [7FF86E66C288]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendLiteral(System.String)
       lea       rcx,[rbp-60]
       call      qword ptr [7FF86E66C2A0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       mov       rbx,rax
       mov       ecx,1CA5
       mov       rdx,7FF86E994098
       call      qword ptr [7FF86E66F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF86EAD4078]
       int       3
M00_L45:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L46:
       sub       rsp,28
       mov       rcx,[rbp-0A8]
       call      qword ptr [7FF86ED78570]; DotNetTips.Spargine.Core.Enumeration+<GetAll>d__18`1[[System.__Canon, System.Private.CoreLib]].System.IDisposable.Dispose()
       nop
       add       rsp,28
       ret
; Total bytes of code 1681
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
       call      qword ptr [7FF86E66C330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      00007FF8CE267010
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
       mov       rax,7FF86E8B8420
       mov       [rbp-78],rax
       lea       rax,[M02_L03]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FF8CE248A70
       call      rax
M02_L03:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FF8CE5BF778],0
       je        short M02_L04
       call      qword ptr [7FF8CE5AD608]; CORINFO_HELP_STOP_FOR_GC
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
       call      00007FF8CE2765E0
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
       call      qword ptr [7FF86ED8C498]; System.RuntimeTypeHandle.GetGCHandle(System.Runtime.InteropServices.GCHandleType)
       mov       rdx,rax
       lea       rcx,[rbx+10]
       xor       eax,eax
       lock cmpxchg [rcx],rdx
       test      rax,rax
       je        near ptr M02_L00
       lea       rcx,[rbp-40]
       call      qword ptr [7FF86ED86E38]
       jmp       near ptr M02_L00
M02_L09:
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M02_L10:
       mov       [rbp+10],rbx
       mov       rcx,rbx
       call      qword ptr [7FF86E895710]; System.RuntimeTypeHandle.<GetModule>g__GetModuleWorker|48_0(System.RuntimeType)
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
       call      00007FF8CE264230
       mov       r14,rax
       test      r14,r14
       cmove     r14,r15
       jmp       short M03_L00
M03_L03:
       lea       rcx,[r14+20]
       mov       r8,rdi
       mov       rdx,offset MT_System.Reflection.CerHashtable<System.String, System.Reflection.RuntimeFieldInfo[]>
       call      qword ptr [7FF86E897C90]; System.Reflection.CerHashtable`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Item(System.__Canon)
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
       jmp       qword ptr [7FF86E896910]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
M03_L04:
       jmp       near ptr M03_L01
M03_L05:
       lea       rcx,[r14+28]
       mov       r8,rdi
       mov       rdx,offset MT_System.Reflection.CerHashtable<System.String, System.Reflection.RuntimeFieldInfo[]>
       call      qword ptr [7FF86E897C90]; System.Reflection.CerHashtable`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Item(System.__Canon)
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
       jmp       qword ptr [7FF86E896910]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
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
       jmp       qword ptr [7FF86E896910]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
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
       mov       rdx,7FF86EDD06C0
       call      qword ptr [7FF86E66F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rdx,7FF86EDD06A0
       call      qword ptr [7FF86E66F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M05_L10:
       mov       rdx,rbx
       mov       r8d,edi
       call      qword ptr [7FF86E896AD8]; System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
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
       mov       rdx,7FF86EDD06A0
       call      qword ptr [7FF86E66F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rdx,7FF86EDD0FE0
       call      qword ptr [7FF86E66F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M06_L05:
       mov       rdx,[rcx+18]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M06_L06
       jmp       short M06_L07
M06_L06:
       mov       rdx,7FF86EDAD7A8
       call      qword ptr [7FF86E66F630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdx,rax
M06_L07:
       mov       rcx,rdx
       call      qword ptr [7FF86E665728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
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
       mov       rdx,7FF86EDD06C0
       call      qword ptr [7FF86E66F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF86EC45938]
       int       3
M06_L12:
       mov       rcx,[rdx+18]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M06_L13
       jmp       short M06_L14
M06_L13:
       mov       rcx,rdx
       mov       rdx,7FF86EDD08F0
       call      qword ptr [7FF86E66F630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FF86EDD08F0
       call      qword ptr [7FF86E66F630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       call      qword ptr [7FF86E6657A0]; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF86E894B58]; System.Type.GetRootElementType()
       mov       rcx,rax
       mov       rax,offset MT_System.RuntimeType
       cmp       [rcx],rax
       jne       short M07_L04
M07_L00:
       test      rcx,rcx
       je        short M07_L05
       call      00007FF8CE26A990
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
       jmp       qword ptr [7FF86EA478E8]; System.Reflection.FieldAccessor.GetValue(System.Object)
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
       call      qword ptr [7FF86ED86A60]
       mov       r8,rax
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF86ED86A78]
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
       mov       rcx,7FF86ED7E2D0
       call      CORINFO_HELP_COUNTPROFILE32
       cmp       rbx,10
       jae       short M09_L01
       mov       rcx,7FF86ED7E2E8
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,7FF86ED7E2EC
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
       mov       rcx,7FF86ED7E2B4
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
       mov       rcx,7FF86ED7E2D4
       call      CORINFO_HELP_COUNTPROFILE32
M09_L03:
       vmovups   xmm0,[rsi+rbx]
       vpcmpeqb  xmm0,xmm0,[rdi+rbx]
       vpmovmskb ecx,xmm0
       cmp       ecx,0FFFF
       jne       near ptr M09_L10
       mov       rcx,7FF86ED7E2D8
       call      CORINFO_HELP_COUNTPROFILE32
M09_L04:
       mov       rcx,7FF86ED7E2B8
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
       mov       rcx,7FF86ED7E2E4
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
       mov       rcx,7FF86ED7E2C8
       call      CORINFO_HELP_COUNTPROFILE32
       vmovups   ymm0,[rsi+rbp]
       vpcmpeqb  ymm0,ymm0,[rdi+rbp]
       vpmovmskb ecx,ymm0
       cmp       ecx,0FFFFFFFF
       je        short M09_L07
M09_L08:
       mov       rcx,7FF86ED7E2CC
       call      CORINFO_HELP_COUNTPROFILE32
M09_L09:
       mov       rcx,7FF86ED7E2F0
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
       mov       rcx,7FF86ED7E2DC
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M09_L09
M09_L11:
       mov       rcx,7FF86ED7E2BC
       call      CORINFO_HELP_COUNTPROFILE32
M09_L12:
       vmovups   ymm0,[rsi+rbx]
       vpcmpeqb  ymm0,ymm0,[rdi+rbx]
       vpmovmskb ecx,ymm0
       cmp       ecx,0FFFFFFFF
       jne       short M09_L13
       mov       rcx,7FF86ED7E2C0
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M09_L04
M09_L13:
       mov       rcx,7FF86ED7E2C4
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M09_L09
M09_L14:
       cmp       rbx,4
       jb        short M09_L15
       mov       rcx,7FF86ED7E2B0
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
       mov       rcx,7FF86ED7E2A8
       call      CORINFO_HELP_COUNTPROFILE32
       movzx     ebp,word ptr [rsi]
       movzx     ecx,word ptr [rdi]
       sub       ebp,ecx
M09_L16:
       test      bl,1
       je        short M09_L17
       mov       rcx,7FF86ED7E2AC
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
       mov       rcx,7FF86ED7E2E0
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
       call      qword ptr [7FF8BDF18080]
       mov       rcx,[rax]
       imul      edx,edi,0B
       add       edx,esi
       mov       eax,100
       cmp       edx,100
       cmovle    edx,eax
       cmp       [rcx],ecx
       call      qword ptr [7FF8BDF37960]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
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
       call      qword ptr [7FF8BDF2B980]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       [rbx+10],esi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M13_L00:
       call      qword ptr [7FF8BDF2D310]
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
       call      qword ptr [7FF8BDF2B980]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       [rbx+10],esi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M14_L00:
       call      qword ptr [7FF8BDF2D310]
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
       call      qword ptr [7FF8BDF251F0]
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
       call      qword ptr [7FF8BDF2B980]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       [rbx+10],esi
       jmp       near ptr M15_L06
M15_L01:
       mov       rcx,rsi
       call      qword ptr [7FF8BDF25228]
       test      rax,rax
       je        near ptr M15_L04
       mov       rcx,rsi
       call      qword ptr [7FF8BDF26468]
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
       call      qword ptr [7FF8BDF33078]
       jmp       short M15_L02
M15_L03:
       mov       ecx,[rsp+48]
       add       [rbx+10],ecx
       jmp       short M15_L06
M15_L04:
       mov       rcx,rsi
       call      qword ptr [7FF8BDF26460]
       mov       rcx,rax
       mov       r8,[rbx]
       lea       r11,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       xor       edx,edx
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       near ptr M15_L00
M15_L05:
       call      qword ptr [7FF8BDF1E130]
       mov       rdx,rax
       mov       rcx,rbx
       mov       r8,rsi
       xor       r9d,r9d
       call      qword ptr [7FF8BDF42780]
M15_L06:
       nop
       add       rsp,58
       pop       rbx
       pop       rsi
       ret
M15_L07:
       call      qword ptr [7FF8BDF2D310]
       int       3
M15_L08:
       mov       rcx,rbx
       call      qword ptr [7FF8BDF33050]
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
       call      qword ptr [7FF8BDF29B88]; Precode of System.String.Ctor(System.ReadOnlySpan`1<Char>)
       mov       rdi,rax
       mov       rbp,[rbx+8]
       xor       eax,eax
       mov       [rbx+8],rax
       mov       [rsi],rax
       mov       [rsi+8],rax
       mov       [rbx+10],eax
       test      rbp,rbp
       je        short M16_L00
       call      qword ptr [7FF8BDF18080]
       mov       rcx,[rax]
       mov       rdx,rbp
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FF8BDF37968]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
M16_L00:
       mov       rax,rdi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M16_L01:
       call      qword ptr [7FF8BDF2D310]
       int       3
; Total bytes of code 126
```

## .NET 10.0.2 (10.0.2, 10.0.225.61305), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rcx,[rcx+30]
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
       mov       rcx,2185D400190
       mov       rcx,[rcx]
       test      rcx,rcx
       jne       short M00_L01
       mov       rcx,2185D400170
       mov       rcx,[rcx]
       test      rcx,rcx
       je        near ptr M00_L49
M00_L01:
       mov       esi,[rsi]
       test      esi,esi
       jl        near ptr M00_L50
       cmp       esi,12C
       jae       near ptr M00_L54
       mov       rcx,2185D4002B8
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
       jne       near ptr M00_L33
       xor       edx,edx
       call      qword ptr [7FF86E9633F8]; System.Reflection.RtFieldInfo.GetValue(System.Object)
M00_L07:
       mov       rdx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.NumericFormat
       call      qword ptr [7FF86E666850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r14,rax
       mov       rdx,r14
       test      rdx,rdx
       je        short M00_L05
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+18],1
       mov       ecx,[r14+10]
       mov       rax,[rsi+8]
       cmp       ecx,[rax+8]
       jne       near ptr M00_L04
       jmp       near ptr M00_L46
M00_L08:
       mov       dword ptr [rbx+18],0FFFFFFFF
       mov       rcx,2185D191100
       mov       r15,[rcx]
       test      r15,r15
       jne       short M00_L09
       mov       rcx,258F2540740
       call      qword ptr [7FF86E8956C8]; System.RuntimeType.InitializeCache()
       mov       r13,rax
       jmp       short M00_L10
M00_L09:
       mov       r13,r15
M00_L10:
       cmp       [r13],r13b
       lea       r12,[r13+50]
       mov       rcx,[r12]
       test      rcx,rcx
       je        near ptr M00_L30
M00_L11:
       xor       edx,edx
       xor       r8d,r8d
       mov       r9d,2
       cmp       [rcx],ecx
       call      qword ptr [7FF86E8968F8]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].GetMemberList(MemberListType, System.String, CacheType)
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
       je        near ptr M00_L32
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
       call      qword ptr [7FF86E896B38]; System.RuntimeType+ListBuilder`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       lea       rcx,[rbx+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+20],ecx
       jmp       near ptr M00_L06
M00_L17:
       cmp       dword ptr [rbp-7C],2
       jl        near ptr M00_L31
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
       je        near ptr M00_L34
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
       call      qword ptr [7FF86E9633F8]; System.Reflection.RtFieldInfo.GetValue(System.Object)
M00_L23:
       mov       rdx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.NumericFormat
       call      qword ptr [7FF86E666850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r14,rax
       mov       rdx,r14
       test      rdx,rdx
       je        short M00_L21
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+18],1
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
       je        near ptr M00_L38
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
       cmp       dword ptr [rbp-7C],2
       jl        near ptr M00_L39
M00_L29:
       movsxd    rdx,dword ptr [rbp-7C]
       mov       rcx,offset MT_System.Reflection.FieldInfo[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       [rbp-90],rax
       mov       rcx,[rbp-90]
       mov       r8,[rbp-88]
       xor       edx,edx
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       near ptr M00_L25
M00_L30:
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache+MemberInfoCache<System.Reflection.RuntimeFieldInfo>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       lea       rcx,[r15+10]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r12
       mov       rdx,r15
       xor       r8d,r8d
       call      00007FF8CE264230
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M00_L11
       mov       rcx,r15
       jmp       near ptr M00_L11
M00_L31:
       mov       dword ptr [rbp-7C],4
       jmp       near ptr M00_L18
M00_L32:
       mov       r12d,[rbp-7C]
       add       r12d,r12d
       lea       rdx,[rbp-90]
       mov       r8d,r12d
       mov       rcx,7FF86E8E8FB8
       call      qword ptr [7FF86E896AD8]; System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
       mov       [rbp-7C],r12d
       jmp       near ptr M00_L13
M00_L33:
       xor       edx,edx
       mov       rax,[rcx]
       mov       rax,[rax+58]
       call      qword ptr [rax]
       jmp       near ptr M00_L07
M00_L34:
       mov       dword ptr [rbx+18],0FFFFFFFF
       mov       rcx,2185D191100
       mov       r15,[rcx]
       test      r15,r15
       jne       short M00_L35
       mov       rcx,258F2540740
       call      qword ptr [7FF86E8956C8]; System.RuntimeType.InitializeCache()
       mov       r13,rax
       jmp       short M00_L36
M00_L35:
       mov       r13,r15
M00_L36:
       cmp       [r13],r13b
       lea       r12,[r13+50]
       mov       rcx,[r12]
       test      rcx,rcx
       jne       short M00_L37
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache+MemberInfoCache<System.Reflection.RuntimeFieldInfo>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       lea       rcx,[r15+10]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r12
       mov       rdx,r15
       xor       r8d,r8d
       call      00007FF8CE264230
       mov       rcx,rax
       test      rcx,rcx
       jne       short M00_L37
       mov       rcx,r15
M00_L37:
       xor       edx,edx
       xor       r8d,r8d
       mov       r9d,2
       cmp       [rcx],ecx
       call      qword ptr [7FF86E8968F8]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].GetMemberList(MemberListType, System.String, CacheType)
       mov       r14,rax
       mov       eax,[r14+8]
       xor       edx,edx
       mov       [rbp-90],rdx
       mov       [rbp-88],rdx
       mov       [rbp-80],edx
       mov       [rbp-7C],eax
       xor       r15d,r15d
       cmp       dword ptr [r14+8],0
       jle       short M00_L41
       jmp       near ptr M00_L28
M00_L38:
       mov       r12d,[rbp-7C]
       add       r12d,r12d
       lea       rdx,[rbp-90]
       mov       r8d,r12d
       mov       rcx,7FF86E8E8FB8
       call      qword ptr [7FF86E896AD8]; System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
       mov       [rbp-7C],r12d
       jmp       near ptr M00_L25
M00_L39:
       mov       dword ptr [rbp-7C],4
       jmp       near ptr M00_L29
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
       call      qword ptr [7FF86E896B38]; System.RuntimeType+ListBuilder`1[[System.__Canon, System.Private.CoreLib]].ToArray()
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
       call      qword ptr [7FF86ED77DC8]; DotNetTips.Spargine.Core.Enumeration+<GetAll>d__18`1[[System.__Canon, System.Private.CoreLib]].System.IDisposable.Dispose()
M00_L47:
       test      r14,r14
       je        near ptr M00_L58
       mov       [rbp-98],r14
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+60]
       lea       r8,[rbp-98]
       mov       rdx,7FF86ED79078
       cmp       [rcx],ecx
       call      qword ptr [7FF86ED1EFD0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FF86ED86220]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L00
M00_L49:
       call      qword ptr [7FF86E66D4B8]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rcx,rax
       jmp       near ptr M00_L01
M00_L50:
       test      rcx,rcx
       je        short M00_L51
       call      qword ptr [7FF86EC44948]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider)
       jmp       short M00_L52
M00_L51:
       call      qword ptr [7FF86E66D2A8]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
M00_L52:
       mov       r8,[rax+28]
       mov       ecx,esi
       mov       edx,0FFFFFFFF
       call      qword ptr [7FF86ED87048]
       mov       rdi,rax
       jmp       near ptr M00_L02
M00_L53:
       mov       ecx,esi
       call      qword ptr [7FF86E8954D0]; System.Number.<UInt32ToDecStrForKnownSmallNumber>g__CreateAndCacheString|50_0(UInt32)
       mov       rdi,rax
       jmp       near ptr M00_L02
M00_L54:
       mov       ecx,esi
       call      qword ptr [7FF86E8954E8]; System.Number.UInt32ToDecStr_NoSmallNumberCheck(UInt32)
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
       call      qword ptr [7FF86E66C270]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler..ctor(Int32, Int32)
       lea       rcx,[rbp-60]
       mov       rdx,258F25406C0
       call      qword ptr [7FF86E66C288]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendLiteral(System.String)
       lea       rcx,[rbp-60]
       mov       rdx,[rbp-0A0]
       call      qword ptr [7FF86E95E088]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted(System.String)
       lea       rcx,[rbp-60]
       mov       rdx,258F25406F8
       call      qword ptr [7FF86E66C288]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendLiteral(System.String)
       lea       rcx,[rbp-60]
       mov       rdx,7FF86ED77570
       mov       r8,258F2540740
       call      qword ptr [7FF86E95E028]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       lea       rcx,[rbp-60]
       mov       rdx,258F2530C80
       call      qword ptr [7FF86E66C288]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendLiteral(System.String)
       lea       rcx,[rbp-60]
       call      qword ptr [7FF86E66C2A0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       mov       rbx,rax
       mov       ecx,1CA5
       mov       rdx,7FF86E9938A8
       call      qword ptr [7FF86E66F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF86EAD4078]
       int       3
M00_L59:
       sub       rsp,28
       mov       rcx,[rbp-0A8]
       call      qword ptr [7FF86ED77DC8]; DotNetTips.Spargine.Core.Enumeration+<GetAll>d__18`1[[System.__Canon, System.Private.CoreLib]].System.IDisposable.Dispose()
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
       call      qword ptr [7FF86E894B58]; System.Type.GetRootElementType()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+98]
       call      qword ptr [rax+8]
       test      rax,rax
       je        short M02_L03
       mov       rcx,rax
       call      00007FF8CE26A990
       test      eax,eax
       jne       short M02_L00
       mov       rcx,[rdi+8]
       mov       rcx,[rcx+10]
       cmp       [rcx],ecx
       call      qword ptr [7FF86E89D4A0]; System.RuntimeType.get_IsNullableOfT()
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
       jmp       qword ptr [7FF86EA478E8]; System.Reflection.FieldAccessor.GetValue(System.Object)
M02_L03:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF86ED867F0]
       mov       r8,rax
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF86ED86808]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 220
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rdx,rdx
       je        short M03_L00
       cmp       [rdx],rcx
       jne       short M03_L01
M03_L00:
       mov       rax,rdx
       ret
M03_L01:
       mov       rax,[rdx]
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M03_L00
M03_L02:
       test      rax,rax
       je        short M03_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M03_L00
       test      rax,rax
       je        short M03_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M03_L00
       test      rax,rax
       je        short M03_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M03_L00
       test      rax,rax
       je        short M03_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M03_L00
       jmp       short M03_L02
M03_L03:
       xor       edx,edx
       jmp       short M03_L00
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
       je        near ptr M04_L08
M04_L00:
       mov       rcx,[rbx+10]
       mov       rdx,[rcx]
       mov       rdi,rdx
       test      rdi,rdi
       je        short M04_L01
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache
       cmp       [rdi],rcx
       jne       near ptr M04_L09
M04_L01:
       test      rdi,rdi
       jne       near ptr M04_L07
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
       call      00007FF8CE267010
       mov       r14,rax
       test      r14,r14
       je        near ptr M04_L10
M04_L02:
       mov       rax,[r14+8]
       test      rax,rax
       jne       near ptr M04_L05
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
       mov       rax,7FF86E8B8420
       mov       [rbp-78],rax
       lea       rax,[M04_L03]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FF8CE248A70
       call      rax
M04_L03:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FF8CE5BF778],0
       je        short M04_L04
       call      qword ptr [7FF8CE5AD608]; CORINFO_HELP_STOP_FOR_GC
M04_L04:
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
M04_L05:
       cmp       rax,rbx
       sete      cl
       mov       rdi,[rbp-0A0]
       mov       [rdi+9C],cl
       mov       rcx,[rbx+10]
       mov       rdx,rdi
       xor       r8d,r8d
       call      00007FF8CE2765E0
       mov       rdx,rax
       test      rdx,rdx
       je        short M04_L06
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache
       cmp       [rdx],rcx
       jne       short M04_L11
M04_L06:
       test      rdx,rdx
       cmovne    rdi,rdx
M04_L07:
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
M04_L08:
       mov       [rbp-40],rbx
       lea       rcx,[rbp-40]
       mov       edx,1
       call      qword ptr [7FF86ED8C4E0]; System.RuntimeTypeHandle.GetGCHandle(System.Runtime.InteropServices.GCHandleType)
       mov       rdx,rax
       lea       rcx,[rbx+10]
       xor       eax,eax
       lock cmpxchg [rcx],rdx
       test      rax,rax
       je        near ptr M04_L00
       lea       rcx,[rbp-40]
       call      qword ptr [7FF86ED86E38]
       jmp       near ptr M04_L00
M04_L09:
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M04_L10:
       mov       [rbp+10],rbx
       mov       rcx,rbx
       call      qword ptr [7FF86E895710]; System.RuntimeTypeHandle.<GetModule>g__GetModuleWorker|48_0(System.RuntimeType)
       mov       r14,rax
       mov       rbx,[rbp+10]
       jmp       near ptr M04_L02
M04_L11:
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
       je        short M05_L00
       cmp       edx,2
       je        short M05_L04
       cmp       byte ptr [rbx+18],0
       je        near ptr M05_L08
       mov       rax,[rbx+8]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M05_L00:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+40]
       test      rdx,rdx
       je        short M05_L01
       jmp       short M05_L02
M05_L01:
       mov       rdx,7FF86EDD1330
       call      qword ptr [7FF86E66F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M05_L02:
       lea       rcx,[rbx+20]
       mov       r8,rsi
       call      qword ptr [7FF86E897C90]; System.Reflection.CerHashtable`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Item(System.__Canon)
       test      rax,rax
       jne       short M05_L03
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r9d,edi
       mov       r8d,1
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FF86E896910]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
M05_L03:
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M05_L04:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+40]
       test      rdx,rdx
       je        short M05_L05
       jmp       short M05_L06
M05_L05:
       mov       rdx,7FF86EDD1330
       call      qword ptr [7FF86E66F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M05_L06:
       lea       rcx,[rbx+28]
       mov       r8,rsi
       call      qword ptr [7FF86E897C90]; System.Reflection.CerHashtable`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Item(System.__Canon)
       test      rax,rax
       jne       short M05_L07
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r9d,edi
       mov       r8d,2
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FF86E896910]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
M05_L07:
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M05_L08:
       mov       rcx,rbx
       mov       r9d,edi
       mov       r8d,edx
       xor       edx,edx
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FF86E896910]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
; Total bytes of code 265
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       sub       rsp,28
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M06_L00
       lea       rax,[rcx+rdx*8+10]
       mov       rcx,[rcx]
       mov       rdx,[rcx+30]
       test      r8,r8
       je        short M06_L02
       cmp       rdx,[r8]
       je        short M06_L01
       mov       r10,offset MT_System.Object[]
       cmp       rcx,r10
       je        short M06_L01
       mov       rcx,rax
       add       rsp,28
       jmp       qword ptr [7FF86E896EC8]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
M06_L00:
       call      qword ptr [7FF86ED84390]
       int       3
M06_L01:
       mov       rcx,rax
       mov       rdx,r8
       add       rsp,28
       jmp       near ptr 00007FF8CE2A9DD0
M06_L02:
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
       je        short M07_L03
       cmp       esi,1
       je        near ptr M07_L08
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       cmp       qword ptr [rdx+8],38
       jle       short M07_L02
       mov       rdx,[rdx+38]
       test      rdx,rdx
       je        short M07_L02
M07_L00:
       test      esi,esi
       jl        near ptr M07_L11
       mov       rdi,[rbx]
       test      rdi,rdi
       je        near ptr M07_L12
       cmp       [rdi+8],esi
       jne       near ptr M07_L15
M07_L01:
       mov       eax,[rbx+10]
       mov       [rbx+14],eax
       mov       rax,[rbx]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M07_L02:
       mov       rdx,7FF86EDD0638
       call      qword ptr [7FF86E66F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       short M07_L00
M07_L03:
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       cmp       qword ptr [rdx+8],48
       jle       short M07_L04
       mov       rax,[rdx+48]
       test      rax,rax
       je        short M07_L04
       mov       rcx,rax
       jmp       short M07_L05
M07_L04:
       mov       rdx,7FF86EDD1458
       call      qword ptr [7FF86E66F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M07_L05:
       mov       rdx,[rcx+18]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M07_L06
       jmp       short M07_L07
M07_L06:
       mov       rdx,7FF86EDAD390
       call      qword ptr [7FF86E66F630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdx,rax
M07_L07:
       mov       rcx,rdx
       call      qword ptr [7FF86E665728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rax]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M07_L08:
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       cmp       qword ptr [rdx+8],40
       jle       short M07_L09
       mov       rax,[rdx+40]
       test      rax,rax
       je        short M07_L09
       mov       rcx,rax
       jmp       short M07_L10
M07_L09:
       mov       rdx,7FF86EDD0658
       call      qword ptr [7FF86E66F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M07_L10:
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
M07_L11:
       mov       ecx,45
       mov       edx,0D
       call      qword ptr [7FF86EC45938]
       int       3
M07_L12:
       mov       rcx,[rdx+18]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M07_L13
       jmp       short M07_L14
M07_L13:
       mov       rcx,rdx
       mov       rdx,7FF86EDD0C68
       call      qword ptr [7FF86E66F630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M07_L14:
       mov       edx,esi
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdx,rax
       mov       rcx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       near ptr M07_L01
M07_L15:
       mov       rcx,[rdx+18]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M07_L16
       jmp       short M07_L17
M07_L16:
       mov       rcx,rdx
       mov       rdx,7FF86EDD0C68
       call      qword ptr [7FF86E66F630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M07_L17:
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
       call      qword ptr [7FF86E6657A0]; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rbx
       mov       rdx,rbp
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       near ptr M07_L01
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
       jl        short M08_L01
       mov       rdi,[rsi]
       test      rdi,rdi
       je        short M08_L02
       cmp       [rdi+8],ebx
       jne       short M08_L05
M08_L00:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M08_L01:
       mov       ecx,45
       mov       edx,0D
       call      qword ptr [7FF86EC45938]
       int       3
M08_L02:
       mov       rdx,[rcx+18]
       mov       rax,[rdx+18]
       test      rax,rax
       je        short M08_L03
       mov       rcx,rax
       jmp       short M08_L04
M08_L03:
       mov       rdx,7FF86EDD0C68
       call      qword ptr [7FF86E66F630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M08_L04:
       mov       edx,ebx
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdx,rax
       mov       rcx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       short M08_L00
M08_L05:
       mov       rdx,[rcx+18]
       mov       rax,[rdx+18]
       test      rax,rax
       je        short M08_L06
       mov       rcx,rax
       jmp       short M08_L07
M08_L06:
       mov       rdx,7FF86EDD0C68
       call      qword ptr [7FF86E66F630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M08_L07:
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
       call      qword ptr [7FF86E6657A0]; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rsi
       mov       rdx,rbp
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       near ptr M08_L00
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
       call      qword ptr [7FF8BDF2FD78]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       ecx,ebx
       and       ecx,0FFFFFF
       mov       edx,ecx
       mov       r8d,ebx
       sar       r8d,18
       jne       short M11_L01
       cmp       [rax],ecx
       jle       short M11_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M11_L03
M11_L00:
       add       rsp,20
       pop       rbx
       ret
M11_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M11_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M11_L00
M11_L02:
       cmp       [rax+4],edx
       jle       short M11_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M11_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M11_L03
       jmp       short M11_L00
M11_L03:
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
       call      qword ptr [7FF8BDF177D0]
       mov       rbx,rax
       mov       rsi,rbx
       call      qword ptr [7FF8BDF2EA88]
       mov       rdx,rax
       test      rsi,rsi
       je        short M12_L00
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FF8BDF2FC28]
       mov       rax,[rbx]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M12_L00:
       call      qword ptr [7FF8BDF2D468]
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
       jne       short M13_L00
       mov       rax,[rbx+18]
       test      rax,rax
       je        short M13_L00
       add       rsp,20
       pop       rbx
       ret
M13_L00:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Globalization.NumberFormatInfo
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       short M13_L01
       mov       rcx,rbx
       mov       r11,7FF86E5B0CD0
       mov       rdx,258F2531518
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,offset MT_System.Globalization.NumberFormatInfo
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       short M13_L01
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FF86E66D2A8]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
M13_L01:
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 127
```
```assembly
; System.Globalization.NumberFormatInfo.get_CurrentInfo()
       push      rbx
       sub       rsp,20
       call      qword ptr [7FF8BDF2E9B0]; Precode of System.Globalization.CultureInfo.get_CurrentCulture()
       mov       rbx,rax
       cmp       byte ptr [rbx+61],0
       jne       short M14_L00
       mov       rax,[rbx+18]
       test      rax,rax
       je        short M14_L00
       add       rsp,20
       pop       rbx
       ret
M14_L00:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       call      qword ptr [7FF8BDF17040]; Precode of System.RuntimeTypeHandle.GetRuntimeTypeFromHandle(IntPtr)
       mov       rdx,rax
       mov       rcx,rbx
       lea       r11,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       call      qword ptr [r11]
       mov       rcx,rax
       call      qword ptr [7FF8BDF264D8]
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
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FF8BDF176E8]
       mov       rsi,[rax]
       mov       ecx,ebx
       call      qword ptr [7FF8BDF2B468]; Precode of System.Number.UInt32ToDecStr_NoSmallNumberCheck(UInt32)
       mov       rdi,rax
       cmp       ebx,[rsi+8]
       jae       short M15_L00
       mov       ecx,ebx
       lea       rcx,[rsi+rcx*8+10]
       mov       rdx,rdi
       call      qword ptr [7FF8BDF16FD0]; CORINFO_HELP_ASSIGN_REF
       mov       rax,rdi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M15_L00:
       call      qword ptr [7FF8BDF16FC0]
       int       3
; Total bytes of code 68
```
```assembly
; System.Number.UInt32ToDecStr_NoSmallNumberCheck(UInt32)
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       ebx,ecx
       mov       ecx,ebx
       or        ecx,1
       bsr       ecx,ecx
       mov       eax,ebx
       cmp       ecx,20
       jae       near ptr M16_L06
       lea       rdx,[7FF8BD2AC0B8]
       add       rax,[rdx+rcx*8]
       sar       rax,20
       movsxd    rsi,eax
       mov       rcx,rsi
       call      qword ptr [7FF8BDF29A50]; Precode of System.String.FastAllocateString(IntPtr)
       test      rax,rax
       je        short M16_L00
       lea       rcx,[rax+0C]
       mov       [rsp+20],rcx
       mov       rcx,[rsp+20]
       jmp       short M16_L01
M16_L00:
       xor       eax,eax
       xor       ecx,ecx
M16_L01:
       lea       rcx,[rcx+rsi*2]
       cmp       ebx,0A
       jb        short M16_L05
       cmp       ebx,64
       jb        short M16_L03
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       add       rdx,0C
M16_L02:
       add       rcx,0FFFFFFFFFFFFFFFC
       mov       r8d,ebx
       imul      r8,51EB851F
       shr       r8,25
       imul      r10d,r8d,64
       sub       ebx,r10d
       mov       r10,rdx
       shl       ebx,2
       mov       r9d,ebx
       mov       r10d,[r10+r9]
       mov       [rcx],r10d
       cmp       r8d,64
       mov       ebx,r8d
       jae       short M16_L02
M16_L03:
       cmp       ebx,0A
       jb        short M16_L05
       add       rcx,0FFFFFFFFFFFFFFFC
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       add       rdx,0C
       lea       r8d,[rbx*4]
       mov       edx,[rdx+r8]
       mov       [rcx],edx
M16_L04:
       xor       ecx,ecx
       mov       [rsp+20],rcx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M16_L05:
       lea       edx,[rbx+30]
       mov       [rcx-2],dx
       jmp       short M16_L04
M16_L06:
       call      qword ptr [7FF8BDF16FC0]
       int       3
; Total bytes of code 231
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
       call      qword ptr [7FF8BDF18080]
       mov       rcx,[rax]
       imul      edx,edi,0B
       add       edx,esi
       mov       eax,100
       cmp       edx,100
       cmovle    edx,eax
       cmp       [rcx],ecx
       call      qword ptr [7FF8BDF37960]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
       mov       [rbx+8],rax
       test      rax,rax
       je        short M17_L01
       lea       rcx,[rax+10]
       mov       eax,[rax+8]
M17_L00:
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
M17_L01:
       xor       ecx,ecx
       xor       eax,eax
       jmp       short M17_L00
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
       call      qword ptr [7FF8BDF2B980]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       [rbx+10],esi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M18_L00:
       call      qword ptr [7FF8BDF2D310]
       int       3
M18_L01:
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
       jne       short M19_L01
       test      rdx,rdx
       je        short M19_L01
       lea       r8,[rbx+18]
       mov       ecx,[rbx+10]
       mov       eax,[r8+8]
       cmp       ecx,eax
       ja        short M19_L00
       mov       r8,[r8]
       mov       r10d,ecx
       lea       r10,[r8+r10*2]
       sub       eax,ecx
       mov       esi,[rdx+8]
       cmp       esi,eax
       ja        short M19_L01
       mov       r8d,esi
       add       r8,r8
       add       rdx,0C
       mov       rcx,r10
       call      qword ptr [7FF8BDF2B980]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       [rbx+10],esi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M19_L00:
       call      qword ptr [7FF8BDF2D310]
       int       3
M19_L01:
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
       jne       near ptr M20_L05
       test      rsi,rsi
       je        near ptr M20_L06
       mov       rcx,rsi
       call      qword ptr [7FF8BDF251F0]
       test      rax,rax
       jne       short M20_L01
       mov       rcx,rsi
       lea       r11,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       call      qword ptr [r11]
       mov       rdx,rax
M20_L00:
       test      rdx,rdx
       je        near ptr M20_L06
       lea       r8,[rbx+18]
       mov       ecx,[rbx+10]
       mov       eax,[r8+8]
       cmp       ecx,eax
       ja        near ptr M20_L07
       mov       r8,[r8]
       mov       r10d,ecx
       lea       r10,[r8+r10*2]
       sub       eax,ecx
       mov       esi,[rdx+8]
       cmp       esi,eax
       ja        near ptr M20_L08
       mov       r8d,esi
       add       r8,r8
       add       rdx,0C
       mov       rcx,r10
       call      qword ptr [7FF8BDF2B980]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       [rbx+10],esi
       jmp       near ptr M20_L06
M20_L01:
       mov       rcx,rsi
       call      qword ptr [7FF8BDF25228]
       test      rax,rax
       je        near ptr M20_L04
       mov       rcx,rsi
       call      qword ptr [7FF8BDF26468]
       mov       rsi,rax
M20_L02:
       mov       rcx,rsi
       lea       rdx,[rbx+18]
       mov       r9d,[rbx+10]
       mov       r8d,[rdx+8]
       cmp       r9d,r8d
       ja        near ptr M20_L07
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
       jne       short M20_L03
       mov       rcx,rbx
       call      qword ptr [7FF8BDF33078]
       jmp       short M20_L02
M20_L03:
       mov       ecx,[rsp+48]
       add       [rbx+10],ecx
       jmp       short M20_L06
M20_L04:
       mov       rcx,rsi
       call      qword ptr [7FF8BDF26460]
       mov       rcx,rax
       mov       r8,[rbx]
       lea       r11,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       xor       edx,edx
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       near ptr M20_L00
M20_L05:
       call      qword ptr [7FF8BDF1E130]
       mov       rdx,rax
       mov       rcx,rbx
       mov       r8,rsi
       xor       r9d,r9d
       call      qword ptr [7FF8BDF42780]
M20_L06:
       nop
       add       rsp,58
       pop       rbx
       pop       rsi
       ret
M20_L07:
       call      qword ptr [7FF8BDF2D310]
       int       3
M20_L08:
       mov       rcx,rbx
       call      qword ptr [7FF8BDF33050]
       jmp       short M20_L06
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
       ja        short M21_L01
       mov       rcx,[rcx]
       mov       [rsp+28],rcx
       mov       [rsp+30],eax
       lea       rcx,[rsp+28]
       call      qword ptr [7FF8BDF29B88]; Precode of System.String.Ctor(System.ReadOnlySpan`1<Char>)
       mov       rdi,rax
       mov       rbp,[rbx+8]
       xor       eax,eax
       mov       [rbx+8],rax
       mov       [rsi],rax
       mov       [rsi+8],rax
       mov       [rbx+10],eax
       test      rbp,rbp
       je        short M21_L00
       call      qword ptr [7FF8BDF18080]
       mov       rcx,[rax]
       mov       rdx,rbp
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FF8BDF37968]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
M21_L00:
       mov       rax,rdi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M21_L01:
       call      qword ptr [7FF8BDF2D310]
       int       3
; Total bytes of code 126
```

## .NET 10.0.2 (10.0.2, 10.0.225.61305), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rsi,offset MT_DotNetTips.Spargine.Core.Enumeration+<GetAll>d__18<DotNetTips.Spargine.Extensions.NumericFormat>
       mov       rcx,rsi
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+18],0FFFFFFFE
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rdi+1C],eax
       cmp       dword ptr [rdi+18],0FFFFFFFE
       jne       near ptr M00_L52
       mov       r14d,[rdi+1C]
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       cmp       r14d,eax
       jne       near ptr M00_L52
       xor       ecx,ecx
       mov       [rdi+18],ecx
M00_L00:
       mov       [rbp-68],rdi
M00_L01:
       mov       r14,[rdi]
       cmp       r14,rsi
       jne       near ptr M00_L46
       mov       r15,rdi
       mov       [rbp-70],r15
       mov       ecx,[r15+18]
       test      ecx,ecx
       je        near ptr M00_L15
       cmp       ecx,1
       jne       near ptr M00_L50
       mov       dword ptr [r15+18],0FFFFFFFF
       mov       rdi,[rbp-68]
M00_L02:
       inc       dword ptr [r15+20]
M00_L03:
       mov       ecx,[r15+20]
       mov       rax,[r15+10]
       cmp       ecx,[rax+8]
       jge       near ptr M00_L29
       cmp       ecx,[rax+8]
       jae       near ptr M00_L49
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
       mov       rdx,7FF8CE2651A0
       call      rdx
       movzx     ebx,al
       mov       rdi,[rbp-98]
       cmp       dword ptr [7FF8CE5BF778],0
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
       je        near ptr M00_L48
       mov       rcx,rax
       call      00007FF8CE26A990
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
       call      qword ptr [7FF86EA578E8]; System.Reflection.FieldAccessor.GetValue(System.Object)
M00_L13:
       mov       rdx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.NumericFormat
       call      qword ptr [7FF86E676850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M00_L45
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
       mov       rcx,1A206F41128
       mov       r13,[rcx]
       test      r13,r13
       jne       short M00_L16
       mov       rcx,1E29DC806C0
       call      qword ptr [7FF86E8A56C8]; System.RuntimeType.InitializeCache()
       mov       r12,rax
       jmp       short M00_L17
M00_L16:
       mov       r12,r13
M00_L17:
       cmp       [r12],r12b
       lea       r13,[r12+50]
       mov       rcx,[r13]
       test      rcx,rcx
       je        near ptr M00_L31
M00_L18:
       cmp       byte ptr [rcx+18],0
       je        near ptr M00_L32
       mov       r13,[rcx+8]
M00_L19:
       mov       r12d,[r13+8]
       mov       edx,r12d
       xor       r8d,r8d
       mov       [rbp-58],r8
       mov       [rbp-50],r8
       mov       [rbp-48],r8d
       mov       [rbp-44],edx
       test      r12d,r12d
       jle       short M00_L24
       add       r13,10
M00_L20:
       mov       rax,[r13]
       mov       [rbp-80],rax
       mov       edx,[rax+18]
       mov       r8d,edx
       and       r8d,18
       cmp       r8d,edx
       jne       short M00_L23
       mov       rax,[rbp-80]
       cmp       dword ptr [rbp-48],0
       je        near ptr M00_L28
       cmp       dword ptr [rbp-48],1
       je        near ptr M00_L26
       mov       edx,[rbp-44]
       cmp       edx,[rbp-48]
       je        near ptr M00_L34
M00_L21:
       movsxd    rdx,dword ptr [rbp-48]
       mov       rcx,[rbp-58]
       mov       r8,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
M00_L22:
       mov       edx,[rbp-48]
       inc       edx
       mov       [rbp-48],edx
M00_L23:
       add       r13,8
       dec       r12d
       jne       short M00_L20
M00_L24:
       mov       r13,[rbp-58]
       mov       r12,[rbp-50]
       mov       eax,[rbp-48]
       mov       [rbp-60],eax
       test      eax,eax
       je        near ptr M00_L35
       cmp       eax,1
       je        near ptr M00_L36
       test      eax,eax
       jl        near ptr M00_L47
       test      r13,r13
       je        near ptr M00_L37
       cmp       [r13+8],eax
       jne       near ptr M00_L38
M00_L25:
       lea       rcx,[r15+10]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r15+20],ecx
       jmp       near ptr M00_L03
M00_L26:
       cmp       dword ptr [rbp-44],2
       jl        near ptr M00_L33
M00_L27:
       movsxd    rdx,dword ptr [rbp-44]
       mov       rcx,offset MT_System.Reflection.FieldInfo[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       [rbp-58],rax
       mov       rcx,[rbp-58]
       mov       r8,[rbp-50]
       xor       edx,edx
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       rax,[rbp-80]
       jmp       near ptr M00_L21
M00_L28:
       mov       [rbp-50],rax
       jmp       near ptr M00_L22
M00_L29:
       xor       ecx,ecx
       mov       r15,[rbp-70]
       mov       [r15+10],rcx
       jmp       near ptr M00_L50
M00_L30:
       mov       rcx,rdi
       mov       r11,7FF86E5C0AC8
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L14
M00_L31:
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache+MemberInfoCache<System.Reflection.RuntimeFieldInfo>
       call      CORINFO_HELP_NEWSFAST
       mov       rcx,rax
       mov       [rbp-88],rcx
       lea       rcx,[rcx+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r13
       mov       rdx,[rbp-88]
       xor       r8d,r8d
       call      00007FF8CE264230
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M00_L18
       mov       r13,[rbp-88]
       mov       rcx,r13
       jmp       near ptr M00_L18
M00_L32:
       xor       edx,edx
       xor       r8d,r8d
       mov       r9d,2
       call      qword ptr [7FF86E8A6910]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
       mov       r13,rax
       jmp       near ptr M00_L19
M00_L33:
       mov       dword ptr [rbp-44],4
       jmp       near ptr M00_L27
M00_L34:
       mov       r10d,[rbp-44]
       add       r10d,r10d
       mov       [rbp-5C],r10d
       lea       rdx,[rbp-58]
       mov       r8d,r10d
       mov       rcx,7FF86E8F8FB8
       call      qword ptr [7FF86E8A6AD8]; System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
       mov       edx,[rbp-5C]
       mov       [rbp-44],edx
       mov       rax,[rbp-80]
       jmp       near ptr M00_L21
M00_L35:
       mov       rcx,1A208C01BE0
       mov       r13,[rcx]
       jmp       near ptr M00_L25
M00_L36:
       mov       rcx,offset MT_System.Reflection.FieldInfo[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r13,rax
       mov       rcx,r13
       mov       r8,r12
       xor       edx,edx
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       near ptr M00_L25
M00_L37:
       mov       edx,eax
       mov       rcx,offset MT_System.Reflection.FieldInfo[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r13,rax
       jmp       near ptr M00_L25
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
       call      qword ptr [7FF86E6757A0]; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r13,r12
       jmp       near ptr M00_L25
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
       mov       rdi,[rbp-68]
       mov       r15,[rbp-70]
       jmp       near ptr M00_L02
M00_L46:
       mov       rcx,rdi
       mov       r11,7FF86E5C0AC0
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L30
       jmp       short M00_L50
M00_L47:
       mov       ecx,45
       mov       edx,0D
       call      qword ptr [7FF86EC55938]
       int       3
M00_L48:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF86ED96670]
       mov       r8,rax
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FF86ED96688]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L49:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L50:
       cmp       r14,rsi
       jne       short M00_L53
       xor       ecx,ecx
       mov       rdi,[rbp-68]
       mov       [rdi+10],rcx
       mov       dword ptr [rdi+18],0FFFFFFFE
M00_L51:
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
M00_L52:
       mov       rcx,rsi
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       xor       eax,eax
       mov       [rdi+18],eax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rdi+1C],eax
       jmp       near ptr M00_L00
M00_L53:
       mov       rdi,[rbp-68]
       mov       rcx,rdi
       mov       r11,7FF86E5C0AD0
       call      qword ptr [r11]
       jmp       short M00_L51
       sub       rsp,28
       vzeroupper
       mov       rdi,[rbp-68]
       mov       r14,[rdi]
       mov       rsi,offset MT_DotNetTips.Spargine.Core.Enumeration+<GetAll>d__18<DotNetTips.Spargine.Extensions.NumericFormat>
       cmp       r14,rsi
       jne       short M00_L54
       xor       ecx,ecx
       mov       [rdi+10],rcx
       mov       dword ptr [rdi+18],0FFFFFFFE
       jmp       short M00_L55
M00_L54:
       mov       rcx,rdi
       mov       r11,7FF86E5C0AD0
       call      qword ptr [r11]
M00_L55:
       nop
       add       rsp,28
       ret
; Total bytes of code 1731
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
       lea       rax,[7FF86E7299D8]
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
       call      qword ptr [7FF86E5BA578]; Precode of System.RuntimeType.IsInstanceOfType(System.Object)
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
       call      qword ptr [7FF86E5BA578]; Precode of System.RuntimeType.IsInstanceOfType(System.Object)
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
       call      qword ptr [7FF86ED966B8]
       jmp       near ptr M01_L01
       mov       rcx,[rbx+8]
       mov       rcx,[rcx+10]
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FF86E5BA578]; Precode of System.RuntimeType.IsInstanceOfType(System.Object)
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
       call      qword ptr [7FF86EA57870]; System.Reflection.RtFieldInfo.InitializeFieldType()
       mov       rdx,rax
M01_L07:
       mov       rcx,rsi
       call      qword ptr [7FF86ED966A0]
       jmp       near ptr M01_L01
       mov       rcx,[rbx+18]
       mov       rdx,[rbx+10]
       call      qword ptr [7FF86ED966B8]
       jmp       near ptr M01_L01
       mov       rcx,[rbx+18]
       mov       rdx,[rbx+10]
       mov       rdx,[rdx]
       cmp       [rdx],dl
       add       rdx,8
       call      qword ptr [7FF86ED966B8]
       jmp       near ptr M01_L01
       mov       rcx,[rbx+10]
       mov       rsi,[rcx]
       mov       rcx,[rbx+8]
       mov       rdx,[rcx+28]
       test      rdx,rdx
       jne       short M01_L08
       call      qword ptr [7FF86EA57870]; System.Reflection.RtFieldInfo.InitializeFieldType()
       mov       rdx,rax
M01_L08:
       mov       rcx,rsi
       call      qword ptr [7FF86ED966A0]
       jmp       near ptr M01_L01
       mov       rcx,rbx
       call      qword ptr [7FF86EA57900]; System.Reflection.FieldAccessor.IsStatic()
       test      eax,eax
       jne       short M01_L09
       mov       rcx,[rbx+8]
       mov       rcx,[rcx+10]
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FF86E5BA578]; Precode of System.RuntimeType.IsInstanceOfType(System.Object)
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
       call      qword ptr [7FF86EA57870]; System.Reflection.RtFieldInfo.InitializeFieldType()
       mov       rdx,rax
M01_L10:
       mov       r8,rdx
       test      r8,r8
       je        short M01_L11
       mov       rcx,offset MT_System.RuntimeType
       cmp       [r8],rcx
       je        short M01_L11
       call      qword ptr [7FF86E676328]; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M01_L11:
       lea       r9,[rsp+28]
       mov       [rsp+20],r9
       mov       r9,[rbx+8]
       mov       r9,[r9+10]
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF86EA57918]; System.RuntimeFieldHandle.GetValue(System.Reflection.RtFieldInfo, System.Object, System.RuntimeType, System.RuntimeType, Boolean ByRef)
       mov       rsi,rax
       cmp       byte ptr [rsp+28],0
       je        short M01_L12
       mov       rcx,rbx
       call      qword ptr [7FF86EA57930]; System.Reflection.FieldAccessor.Initialize()
M01_L12:
       mov       rax,rsi
       jmp       near ptr M01_L01
       mov       rcx,rbx
       call      qword ptr [7FF86EA57900]; System.Reflection.FieldAccessor.IsStatic()
       test      eax,eax
       jne       short M01_L15
       mov       rcx,[rbx+8]
       mov       rcx,[rcx+10]
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FF86E5BA578]; Precode of System.RuntimeType.IsInstanceOfType(System.Object)
       test      eax,eax
       jne       short M01_L15
       test      rsi,rsi
       jne       short M01_L14
M01_L13:
       call      qword ptr [7FF86ED966D0]
       int       3
M01_L14:
       mov       rdx,[rbx+8]
       mov       rcx,rsi
       call      qword ptr [7FF86ED966E8]
       int       3
M01_L15:
       mov       dword ptr [rsp+28],1
       mov       rdi,[rbx+8]
       mov       rcx,[rbx+8]
       mov       rdx,[rcx+28]
       test      rdx,rdx
       jne       short M01_L16
       call      qword ptr [7FF86EA57870]; System.Reflection.RtFieldInfo.InitializeFieldType()
       mov       rdx,rax
M01_L16:
       mov       rcx,offset MT_System.RuntimeType
       call      qword ptr [7FF86E676328]; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       r8,rax
       lea       r9,[rsp+28]
       mov       [rsp+20],r9
       mov       r9,[rbx+8]
       mov       r9,[r9+10]
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF86EA57918]; System.RuntimeFieldHandle.GetValue(System.Reflection.RtFieldInfo, System.Object, System.RuntimeType, System.RuntimeType, Boolean ByRef)
       jmp       near ptr M01_L01
       mov       rcx,[rbx+8]
       cmp       [rcx],ecx
       call      qword ptr [7FF86E8F8320]; Precode of System.Reflection.RuntimeFieldInfo.get_DeclaringType()
       test      rax,rax
       je        short M01_L17
       mov       rcx,[rbx+8]
       cmp       [rcx],ecx
       call      qword ptr [7FF86E8F8320]; Precode of System.Reflection.RuntimeFieldInfo.get_DeclaringType()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+0B0]
       call      qword ptr [rax]
       test      eax,eax
       je        short M01_L17
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF86ED96700]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF86EA55D58]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L17:
       mov       rcx,[rbx+8]
       cmp       [rcx],ecx
       call      qword ptr [7FF86E8F8320]; Precode of System.Reflection.RuntimeFieldInfo.get_DeclaringType()
       test      rax,rax
       je        short M01_L19
       mov       rcx,[rbx+8]
       mov       rdx,[rcx+28]
       test      rdx,rdx
       jne       short M01_L18
       call      qword ptr [7FF86EA57870]; System.Reflection.RtFieldInfo.InitializeFieldType()
       mov       rdx,rax
M01_L18:
       mov       rcx,offset MT_System.RuntimeType
       call      qword ptr [7FF86E676328]; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF86E8AD4A0]; System.RuntimeType.get_IsNullableOfT()
       test      eax,eax
       je        short M01_L19
       mov       rcx,offset MT_System.NotSupportedException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FF86ED96718]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L19:
       mov       rcx,offset MT_System.FieldAccessException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF86ED96730]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 918
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
       call      00007FF8CE267010
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
       mov       rax,7FF86E8C8420
       mov       [rbp-78],rax
       lea       rax,[M03_L03]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FF8CE248A70
       call      rax
M03_L03:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FF8CE5BF778],0
       je        short M03_L04
       call      qword ptr [7FF8CE5AD608]; CORINFO_HELP_STOP_FOR_GC
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
       call      00007FF8CE2765E0
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
       call      qword ptr [7FF86ED9C138]; System.RuntimeTypeHandle.GetGCHandle(System.Runtime.InteropServices.GCHandleType)
       mov       rdx,rax
       lea       rcx,[rbx+10]
       xor       eax,eax
       lock cmpxchg [rcx],rdx
       test      rax,rax
       je        near ptr M03_L00
       lea       rcx,[rbp-40]
       call      qword ptr [7FF86ED96D30]
       jmp       near ptr M03_L00
M03_L09:
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M03_L10:
       mov       [rbp+10],rbx
       mov       rcx,rbx
       call      qword ptr [7FF86E8A5710]; System.RuntimeTypeHandle.<GetModule>g__GetModuleWorker|48_0(System.RuntimeType)
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
       jmp       qword ptr [7FF86E8A6EC8]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
M04_L00:
       call      qword ptr [7FF86ED94258]
       int       3
M04_L01:
       mov       rcx,rax
       mov       rdx,r8
       add       rsp,28
       jmp       near ptr 00007FF8CE2A9DD0
M04_L02:
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
       mov       rax,8AD343E2F0C
       mov       [rbp],rax
       mov       rsi,rcx
       mov       rbx,rdx
       mov       edi,r8d
       mov       r14d,r9d
       test      rbx,rbx
       je        short M05_L00
       cmp       dword ptr [rbx+8],0
       jne       short M05_L03
M05_L00:
       xor       r8d,r8d
       mov       [rbp+8],r8
       mov       [rbp+10],r8d
       mov       [rsp+20],r14d
       lea       r8,[rbp+8]
       mov       rcx,rsi
       mov       r9d,edi
       mov       rdx,1E29DC70008
       call      qword ptr [7FF86E8A6928]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].GetListByName(System.String, System.Span`1<Byte>, MemberListType, CacheType)
       mov       [rbp+18],rax
M05_L01:
       lea       rdx,[rbp+18]
       mov       rcx,rsi
       mov       r8,rbx
       mov       r9d,edi
       call      qword ptr [7FF86E8A6B50]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Insert(System.__Canon[] ByRef, System.String, MemberListType)
       mov       rax,[rbp+18]
       mov       r8,8AD343E2F0C
       cmp       [rbp],r8
       je        short M05_L02
       call      CORINFO_HELP_FAIL_FAST
M05_L02:
       nop
       lea       rsp,[rbp+20]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M05_L03:
       cmp       r14d,1
       jne       short M05_L04
       cmp       word ptr [rbx+0C],2E
       je        short M05_L04
       cmp       word ptr [rbx+0C],2A
       jne       short M05_L00
M05_L04:
       mov       rcx,1A208C00108
       mov       rcx,[rcx]
       mov       rdx,rbx
       call      qword ptr [7FF86E77CD38]; Precode of System.Text.UTF8Encoding.GetByteCount(System.String)
       cmp       eax,400
       jbe       short M05_L05
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       r8,[rax+10]
       mov       eax,[rax+8]
       jmp       short M05_L07
M05_L05:
       mov       r8d,eax
       test      r8,r8
       je        short M05_L07
       mov       rdx,r8
       add       rdx,0F
       and       rdx,0FFFFFFFFFFFFFFF0
       add       rsp,30
       neg       rdx
       add       rdx,rsp
       jb        short M05_L06
       xor       edx,edx
M05_L06:
       test      [rsp],esp
       sub       rsp,1000
       cmp       rsp,rdx
       jae       short M05_L06
       mov       rsp,rdx
       test      [rsp],esp
       sub       rsp,30
       lea       r8,[rsp+30]
M05_L07:
       mov       [rbp+8],r8
       mov       [rbp+10],eax
       mov       [rsp+20],r14d
       lea       r8,[rbp+8]
       mov       rdx,rbx
       mov       rcx,rsi
       mov       r9d,edi
       call      qword ptr [7FF86E8A6928]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].GetListByName(System.String, System.Span`1<Byte>, MemberListType, CacheType)
       mov       [rbp+18],rax
       jmp       near ptr M05_L01
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
       call      qword ptr [7FF86EC55938]
       int       3
M06_L02:
       mov       rdx,[rcx+18]
       mov       rax,[rdx+18]
       test      rax,rax
       je        short M06_L03
       mov       rcx,rax
       jmp       short M06_L04
M06_L03:
       mov       rdx,7FF86EDE0190
       call      qword ptr [7FF86E67F630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FF86EDE0190
       call      qword ptr [7FF86E67F630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       call      qword ptr [7FF86E6757A0]; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      00007FF8CE25B8A0
       cmp       dword ptr [7FF8CE5BF778],0
       jne       short M07_L01
M07_L00:
       add       rsp,28
       ret
M07_L01:
       call      CORINFO_HELP_POLL_GC
       jmp       short M07_L00
M07_L02:
       add       rsp,28
       jmp       qword ptr [7FF86ED94198]
; Total bytes of code 49
```

