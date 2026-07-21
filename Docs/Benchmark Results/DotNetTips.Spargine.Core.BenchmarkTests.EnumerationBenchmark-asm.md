## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       xor       eax,eax
       mov       [rbp-0A8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-0A0],ymm4
       vmovdqu   ymmword ptr [rbp-80],ymm4
       vmovdqu   ymmword ptr [rbp-60],ymm4
       mov       [rbp-40],rax
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Enumeration+<>c__DisplayClass16_0<DotNetTips.Spargine.Extensions.NumericFormat>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdi,2E4CC2F0AA0
       mov       [rsi+8],rdi
       mov       rdx,rdi
       mov       ecx,[rdx+8]
       test      ecx,ecx
       sete      al
       movzx     eax,al
       cmp       eax,ecx
       jae       near ptr M00_L39
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp-0A8],rdi
       mov       rdi,offset MT_DotNetTips.Spargine.Core.Enumeration+<GetAll>d__18<DotNetTips.Spargine.Extensions.NumericFormat>
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       dword ptr [r14+18],0FFFFFFFE
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [r14+1C],eax
       cmp       dword ptr [r14+18],0FFFFFFFE
       jne       near ptr M00_L35
       mov       r15d,[r14+1C]
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       cmp       r15d,eax
       jne       near ptr M00_L35
       xor       ecx,ecx
       mov       [r14+18],ecx
M00_L00:
       mov       rcx,r14
       mov       [rbp-0B0],rcx
M00_L01:
       cmp       [rcx],rdi
       jne       near ptr M00_L31
       mov       r14,rcx
       mov       eax,[r14+18]
       test      eax,eax
       je        near ptr M00_L07
       cmp       eax,1
       jne       near ptr M00_L22
       mov       dword ptr [r14+18],0FFFFFFFF
M00_L02:
       inc       dword ptr [r14+20]
M00_L03:
       mov       ecx,[r14+20]
       mov       rdx,[r14+10]
       cmp       ecx,[rdx+8]
       jge       near ptr M00_L29
       cmp       ecx,[rdx+8]
       jae       near ptr M00_L32
       mov       rcx,[rdx+rcx*8+10]
       mov       rdx,offset MT_System.Reflection.RtFieldInfo
       cmp       [rcx],rdx
       jne       near ptr M00_L28
       xor       edx,edx
       call      qword ptr [7FF8A7EC3940]; System.Reflection.RtFieldInfo.GetValue(System.Object)
       mov       rdx,rax
M00_L04:
       test      rdx,rdx
       je        short M00_L02
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.NumericFormat
       cmp       [rdx],rcx
       jne       short M00_L02
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [r14+18],1
M00_L05:
       mov       rcx,[rbp-0B0]
       mov       r14,[rcx+8]
       mov       r8,[r14+8]
       mov       rdx,[rsi+8]
       cmp       r8,rdx
       je        near ptr M00_L19
       test      r8,r8
       je        near ptr M00_L21
       test      rdx,rdx
       je        near ptr M00_L21
       mov       eax,[r8+8]
       cmp       eax,[rdx+8]
       jne       near ptr M00_L21
       lea       rax,[r8+0C]
       mov       r8d,[r8+8]
       add       r8d,r8d
       add       rdx,0C
       mov       rcx,rax
       call      qword ptr [7FF8A7C2C330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
M00_L06:
       test      eax,eax
       mov       rcx,[rbp-0B0]
       je        near ptr M00_L01
       jmp       near ptr M00_L33
M00_L07:
       mov       dword ptr [r14+18],0FFFFFFFF
       mov       rax,2A436EB1970
       mov       r15,[rax]
       test      r15,r15
       je        near ptr M00_L23
M00_L08:
       cmp       [r15],r15b
       lea       r13,[r15+50]
       mov       rax,[r13]
       test      rax,rax
       je        near ptr M00_L24
M00_L09:
       cmp       byte ptr [rax+18],0
       je        near ptr M00_L25
       mov       r15,[rax+8]
M00_L10:
       mov       r13d,[r15+8]
       mov       edx,r13d
       xor       r8d,r8d
       mov       [rbp-90],r8
       mov       [rbp-88],r8
       mov       [rbp-80],r8d
       mov       [rbp-7C],edx
       test      r13d,r13d
       jle       short M00_L15
       add       r15,10
M00_L11:
       mov       r12,[r15]
       mov       edx,[r12+18]
       mov       r8d,edx
       and       r8d,18
       cmp       r8d,edx
       jne       short M00_L14
       cmp       dword ptr [rbp-80],0
       je        near ptr M00_L18
       cmp       dword ptr [rbp-80],1
       je        short M00_L16
       mov       edx,[rbp-7C]
       cmp       edx,[rbp-80]
       je        near ptr M00_L27
M00_L12:
       movsxd    rdx,dword ptr [rbp-80]
       mov       rcx,[rbp-90]
       mov       r8,r12
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
M00_L13:
       mov       edx,[rbp-80]
       inc       edx
       mov       [rbp-80],edx
M00_L14:
       add       r15,8
       dec       r13d
       jne       short M00_L11
M00_L15:
       vmovdqu   xmm0,xmmword ptr [rbp-90]
       vmovdqu   xmmword ptr [rbp-78],xmm0
       mov       rdx,[rbp-80]
       mov       [rbp-68],rdx
       lea       rcx,[rbp-78]
       mov       rdx,offset MT_System.RuntimeType+ListBuilder<System.Reflection.FieldInfo>
       call      qword ptr [7FF8A7DF6B38]; System.RuntimeType+ListBuilder`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       lea       rcx,[r14+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r14+20],ecx
       jmp       near ptr M00_L03
M00_L16:
       cmp       dword ptr [rbp-7C],2
       jl        near ptr M00_L26
M00_L17:
       movsxd    rdx,dword ptr [rbp-7C]
       mov       rcx,offset MT_System.Reflection.FieldInfo[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       [rbp-90],rax
       mov       rcx,[rbp-90]
       mov       r8,[rbp-88]
       xor       edx,edx
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       near ptr M00_L12
M00_L18:
       mov       [rbp-88],r12
       jmp       near ptr M00_L13
M00_L19:
       mov       eax,1
       jmp       near ptr M00_L06
M00_L20:
       mov       rcx,[rbp-0B0]
       cmp       [rcx],rdi
       je        near ptr M00_L05
       mov       rcx,[rbp-0B0]
       mov       r11,7FF8A7B70A38
       call      qword ptr [r11]
       mov       r14,rax
       mov       rcx,rsi
       mov       rdx,r14
       mov       rax,offset DotNetTips.Spargine.Core.Enumeration+<>c__DisplayClass16_0`1[[System.__Canon, System.Private.CoreLib]].<FromDisplayName>b__0(System.__Canon)
       call      rax
       jmp       near ptr M00_L06
M00_L21:
       xor       eax,eax
       jmp       near ptr M00_L06
M00_L22:
       xor       r14d,r14d
       jmp       near ptr M00_L30
M00_L23:
       mov       rcx,2E4CC2F0B68
       call      qword ptr [7FF8A7DF56C8]; System.RuntimeType.InitializeCache()
       mov       r15,rax
       jmp       near ptr M00_L08
M00_L24:
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache+MemberInfoCache<System.Reflection.RuntimeFieldInfo>
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       lea       rcx,[r12+10]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r13
       mov       rdx,r12
       xor       r8d,r8d
       call      00007FF907846040
       test      rax,rax
       jne       near ptr M00_L09
       mov       rax,r12
       jmp       near ptr M00_L09
M00_L25:
       mov       rcx,rax
       xor       edx,edx
       xor       r8d,r8d
       mov       r9d,2
       call      qword ptr [7FF8A7DF6910]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
       mov       r15,rax
       jmp       near ptr M00_L10
M00_L26:
       mov       dword ptr [rbp-7C],4
       jmp       near ptr M00_L17
M00_L27:
       mov       eax,[rbp-7C]
       add       eax,eax
       mov       [rbp-94],eax
       lea       rdx,[rbp-90]
       mov       r8d,eax
       mov       rcx,7FF8A7E49080
       call      qword ptr [7FF8A7DF6AD8]; System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
       mov       edx,[rbp-94]
       mov       [rbp-7C],edx
       jmp       near ptr M00_L12
M00_L28:
       xor       edx,edx
       mov       rax,[rcx]
       mov       rax,[rax+58]
       call      qword ptr [rax]
       mov       rdx,rax
       jmp       near ptr M00_L04
M00_L29:
       xor       ecx,ecx
       mov       [r14+10],rcx
       jmp       near ptr M00_L22
M00_L30:
       test      r14d,r14d
       jne       near ptr M00_L20
       jmp       near ptr M00_L36
M00_L31:
       mov       r11,7FF8A7B70A30
       call      qword ptr [r11]
       mov       r14d,eax
       jmp       short M00_L30
M00_L32:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L33:
       cmp       [rcx],rdi
       jne       short M00_L37
       call      qword ptr [7FF8A82AAFD0]; DotNetTips.Spargine.Core.Enumeration+<GetAll>d__18`1[[System.__Canon, System.Private.CoreLib]].System.IDisposable.Dispose()
M00_L34:
       mov       [rbp-0A0],r14
       mov       rcx,[rbx+88]
       lea       r8,[rbp-0A0]
       mov       rdx,7FF8A82ABB20
       cmp       [rcx],ecx
       call      qword ptr [7FF8A824E508]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
M00_L35:
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       xor       eax,eax
       mov       [r14+18],eax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [r14+1C],eax
       jmp       near ptr M00_L00
M00_L36:
       call      M00_L40
       jmp       short M00_L38
M00_L37:
       mov       r11,7FF8A7B70A40
       call      qword ptr [r11]
       jmp       short M00_L34
M00_L38:
       lea       rcx,[rbp-60]
       mov       edx,14
       mov       r8d,2
       call      qword ptr [7FF8A7C2C270]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler..ctor(Int32, Int32)
       lea       rcx,[rbp-60]
       mov       rdx,2E4CC2F0AE8
       call      qword ptr [7FF8A7C2C288]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendLiteral(System.String)
       lea       rcx,[rbp-60]
       mov       rdx,[rbp-0A8]
       call      qword ptr [7FF8A7EBE388]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted(System.String)
       lea       rcx,[rbp-60]
       mov       rdx,2E4CC2F0B20
       call      qword ptr [7FF8A7C2C288]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendLiteral(System.String)
       lea       rcx,[rbp-60]
       mov       rdx,7FF8A82AA1B0
       mov       r8,2E4CC2F0B68
       call      qword ptr [7FF8A7EBE328]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       lea       rcx,[rbp-60]
       mov       rdx,2E4CC2E0C80
       call      qword ptr [7FF8A7C2C288]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendLiteral(System.String)
       lea       rcx,[rbp-60]
       call      qword ptr [7FF8A7C2C2A0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       mov       rbx,rax
       mov       ecx,2033
       mov       rdx,7FF8A7EF4538
       call      qword ptr [7FF8A7C2F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8A80347B0]
       int       3
M00_L39:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L40:
       sub       rsp,28
       mov       rdi,offset MT_DotNetTips.Spargine.Core.Enumeration+<GetAll>d__18<DotNetTips.Spargine.Extensions.NumericFormat>
       mov       rcx,[rbp-0B0]
       cmp       [rcx],rdi
       jne       short M00_L41
       call      qword ptr [7FF8A82AAFD0]; DotNetTips.Spargine.Core.Enumeration+<GetAll>d__18`1[[System.__Canon, System.Private.CoreLib]].System.IDisposable.Dispose()
       jmp       short M00_L42
M00_L41:
       mov       r11,7FF8A7B70A40
       call      qword ptr [r11]
M00_L42:
       nop
       add       rsp,28
       ret
; Total bytes of code 1480
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
       jne       near ptr M01_L02
       mov       rcx,offset MT_System.Reflection.FieldAccessor
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rdi+8]
       mov       rcx,[rcx+10]
       cmp       [rcx],cl
       call      qword ptr [7FF8A7DF4B58]; System.Type.GetRootElementType()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+98]
       call      qword ptr [rax+8]
       test      rax,rax
       je        short M01_L03
       mov       rcx,rax
       call      00007FF90781C1F0
       test      eax,eax
       jne       short M01_L00
       mov       rcx,[rdi+8]
       mov       rcx,[rcx+10]
       cmp       [rcx],ecx
       call      qword ptr [7FF8A7DFD500]; System.RuntimeType.get_IsNullableOfT()
       test      eax,eax
       jne       short M01_L00
       mov       dword ptr [rdi+20],0F
       jmp       short M01_L01
M01_L00:
       mov       dword ptr [rdi+20],11
M01_L01:
       lea       rcx,[rbx+30]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
M01_L02:
       mov       rcx,[rbx+30]
       mov       rdx,rsi
       cmp       [rcx],ecx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FF8A7FA7CF0]; System.Reflection.FieldAccessor.GetValue(System.Object)
M01_L03:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF8A82C55D8]
       mov       r8,rax
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF8A82C55F0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 220
```
```assembly
; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       r8,8
       jae       short M02_L05
       cmp       r8,4
       jae       short M02_L04
       xor       eax,eax
       mov       r10,r8
       and       r10,2
       je        short M02_L00
       movzx     eax,word ptr [rcx]
       movzx     r9d,word ptr [rdx]
       sub       eax,r9d
M02_L00:
       test      r8b,1
       jne       short M02_L03
M02_L01:
       test      eax,eax
       sete      al
       movzx     eax,al
M02_L02:
       vzeroupper
       ret
M02_L03:
       movzx     r8d,byte ptr [rcx+r10]
       movzx     ecx,byte ptr [rdx+r10]
       sub       r8d,ecx
       or        eax,r8d
       jmp       short M02_L01
M02_L04:
       add       r8,0FFFFFFFFFFFFFFFC
       mov       eax,[rcx]
       sub       eax,[rdx]
       mov       ecx,[rcx+r8]
       sub       ecx,[rdx+r8]
       or        eax,ecx
       sete      al
       movzx     eax,al
       jmp       short M02_L02
M02_L05:
       cmp       rcx,rdx
       je        near ptr M02_L11
       cmp       r8,20
       jb        short M02_L08
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFE0
       je        short M02_L07
M02_L06:
       vmovups   ymm0,[rcx+rax]
       vpcmpeqb  ymm0,ymm0,[rdx+rax]
       vpmovmskb r10d,ymm0
       cmp       r10d,0FFFFFFFF
       jne       near ptr M02_L13
       add       rax,20
       cmp       r8,rax
       ja        short M02_L06
M02_L07:
       vmovups   ymm0,[rcx+r8]
       vpcmpeqb  ymm0,ymm0,[rdx+r8]
       vpmovmskb ecx,ymm0
       cmp       ecx,0FFFFFFFF
       jne       short M02_L13
       jmp       short M02_L11
M02_L08:
       cmp       r8,10
       jb        short M02_L12
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFF0
       je        short M02_L10
M02_L09:
       vmovups   xmm0,[rcx+rax]
       vpcmpeqb  xmm0,xmm0,[rdx+rax]
       vpmovmskb r10d,xmm0
       cmp       r10d,0FFFF
       jne       short M02_L13
       add       rax,10
       cmp       r8,rax
       ja        short M02_L09
M02_L10:
       vmovups   xmm0,[rcx+r8]
       vpcmpeqb  xmm0,xmm0,[rdx+r8]
       vpmovmskb eax,xmm0
       cmp       eax,0FFFF
       jne       short M02_L13
M02_L11:
       mov       eax,1
       vzeroupper
       ret
M02_L12:
       lea       rax,[r8-8]
       mov       r8,[rcx]
       sub       r8,[rdx]
       mov       rcx,[rcx+rax]
       sub       rcx,[rdx+rax]
       or        rcx,r8
       sete      al
       movzx     eax,al
       jmp       near ptr M02_L02
M02_L13:
       xor       eax,eax
       vzeroupper
       ret
; Total bytes of code 290
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
       jmp       qword ptr [7FF8A7DF6EC8]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
M03_L00:
       call      qword ptr [7FF8A824F678]
       int       3
M03_L01:
       mov       rcx,rax
       mov       rdx,r8
       add       rsp,28
       jmp       near ptr 00007FF9078A3EE0
M03_L02:
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
       je        short M04_L03
       cmp       esi,1
       je        near ptr M04_L08
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       cmp       qword ptr [rdx+8],38
       jle       short M04_L02
       mov       rdx,[rdx+38]
       test      rdx,rdx
       je        short M04_L02
M04_L00:
       test      esi,esi
       jl        near ptr M04_L11
       mov       rdi,[rbx]
       test      rdi,rdi
       je        near ptr M04_L12
       cmp       [rdi+8],esi
       jne       near ptr M04_L15
M04_L01:
       mov       eax,[rbx+10]
       mov       [rbx+14],eax
       mov       rax,[rbx]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M04_L02:
       mov       rdx,7FF8A82E64B0
       call      qword ptr [7FF8A7C2F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       short M04_L00
M04_L03:
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       cmp       qword ptr [rdx+8],48
       jle       short M04_L04
       mov       rax,[rdx+48]
       test      rax,rax
       je        short M04_L04
       mov       rcx,rax
       jmp       short M04_L05
M04_L04:
       mov       rdx,7FF8A82E80E0
       call      qword ptr [7FF8A7C2F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M04_L05:
       mov       rdx,[rcx+18]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M04_L06
       jmp       short M04_L07
M04_L06:
       mov       rdx,7FF8A82E8100
       call      qword ptr [7FF8A7C2F630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdx,rax
M04_L07:
       mov       rcx,rdx
       call      qword ptr [7FF8A7C25728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rax]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M04_L08:
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       cmp       qword ptr [rdx+8],40
       jle       short M04_L09
       mov       rax,[rdx+40]
       test      rax,rax
       je        short M04_L09
       mov       rcx,rax
       jmp       short M04_L10
M04_L09:
       mov       rdx,7FF8A82E64D0
       call      qword ptr [7FF8A7C2F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M04_L10:
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
M04_L11:
       mov       ecx,45
       mov       edx,0D
       call      qword ptr [7FF8A81A6448]
       int       3
M04_L12:
       mov       rcx,[rdx+18]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M04_L13
       jmp       short M04_L14
M04_L13:
       mov       rcx,rdx
       mov       rdx,7FF8A82E79A8
       call      qword ptr [7FF8A7C2F630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M04_L14:
       mov       edx,esi
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdx,rax
       mov       rcx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       near ptr M04_L01
M04_L15:
       mov       rcx,[rdx+18]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M04_L16
       jmp       short M04_L17
M04_L16:
       mov       rcx,rdx
       mov       rdx,7FF8A82E79A8
       call      qword ptr [7FF8A7C2F630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M04_L17:
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
       call      qword ptr [7FF8A7C257A0]; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rbx
       mov       rdx,rbp
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       near ptr M04_L01
; Total bytes of code 486
```
```assembly
; DotNetTips.Spargine.Core.Enumeration+<>c__DisplayClass16_0`1[[System.__Canon, System.Private.CoreLib]].<FromDisplayName>b__0(System.__Canon)
; 		return Parse<T>(displayName, predicate: item => string.Equals(item.DisplayName, displayName, StringComparison.Ordinal));
; 		                                                ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,28
       mov       r8,[rdx+8]
       mov       rdx,[rcx+8]
       cmp       r8,rdx
       je        short M05_L01
       test      r8,r8
       je        short M05_L02
       test      rdx,rdx
       je        short M05_L02
       mov       ecx,[r8+8]
       cmp       ecx,[rdx+8]
       jne       short M05_L02
       add       r8,0C
       mov       rax,r8
       add       ecx,ecx
       mov       r8d,ecx
       add       rdx,0C
       mov       rcx,rax
       call      qword ptr [7FF8A7C2C330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
M05_L00:
       nop
       add       rsp,28
       ret
M05_L01:
       mov       eax,1
       jmp       short M05_L00
M05_L02:
       xor       eax,eax
       jmp       short M05_L00
; Total bytes of code 78
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
       je        near ptr M06_L08
M06_L00:
       mov       rcx,[rbx+10]
       mov       rdx,[rcx]
       mov       rdi,rdx
       test      rdi,rdi
       je        short M06_L01
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache
       cmp       [rdi],rcx
       jne       near ptr M06_L09
M06_L01:
       test      rdi,rdi
       jne       near ptr M06_L07
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
       call      00007FF9078553D0
       mov       r14,rax
       test      r14,r14
       je        near ptr M06_L10
M06_L02:
       mov       rax,[r14+8]
       test      rax,rax
       jne       near ptr M06_L05
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
       mov       rax,7FF8A7E18420
       mov       [rbp-78],rax
       lea       rax,[M06_L03]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FF9077323D0
       call      rax
M06_L03:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FF907B64A90],0
       je        short M06_L04
       call      qword ptr [7FF907B52648]; CORINFO_HELP_STOP_FOR_GC
M06_L04:
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
M06_L05:
       cmp       rax,rbx
       sete      cl
       mov       rdi,[rbp-0A0]
       mov       [rdi+9C],cl
       mov       rcx,[rbx+10]
       mov       rdx,rdi
       xor       r8d,r8d
       call      00007FF90786BEF0
       mov       rdx,rax
       test      rdx,rdx
       je        short M06_L06
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache
       cmp       [rdx],rcx
       jne       short M06_L11
M06_L06:
       test      rdx,rdx
       cmovne    rdi,rdx
M06_L07:
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
M06_L08:
       mov       [rbp-40],rbx
       lea       rcx,[rbp-40]
       mov       edx,1
       call      qword ptr [7FF8A82CC480]; System.RuntimeTypeHandle.GetGCHandle(System.Runtime.InteropServices.GCHandleType)
       mov       rdx,rax
       lea       rcx,[rbx+10]
       xor       eax,eax
       lock cmpxchg [rcx],rdx
       test      rax,rax
       je        near ptr M06_L00
       lea       rcx,[rbp-40]
       call      qword ptr [7FF8A82C5C80]
       jmp       near ptr M06_L00
M06_L09:
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M06_L10:
       mov       [rbp+10],rbx
       mov       rcx,rbx
       call      qword ptr [7FF8A7DF5710]; System.RuntimeTypeHandle.<GetModule>g__GetModuleWorker|48_0(System.RuntimeType)
       mov       r14,rax
       mov       rbx,[rbp+10]
       jmp       near ptr M06_L02
M06_L11:
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
       mov       rax,0A13ECE64D09A
       mov       [rbp],rax
       mov       rsi,rcx
       mov       rbx,rdx
       mov       edi,r8d
       mov       r14d,r9d
       test      rbx,rbx
       je        short M07_L00
       cmp       dword ptr [rbx+8],0
       jne       short M07_L03
M07_L00:
       xor       r8d,r8d
       mov       [rbp+8],r8
       mov       [rbp+10],r8d
       mov       [rsp+20],r14d
       lea       r8,[rbp+8]
       mov       rcx,rsi
       mov       r9d,edi
       mov       rdx,2E4CC2E0008
       call      qword ptr [7FF8A7DF6928]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].GetListByName(System.String, System.Span`1<Byte>, MemberListType, CacheType)
       mov       [rbp+18],rax
M07_L01:
       lea       rdx,[rbp+18]
       mov       rcx,rsi
       mov       r8,rbx
       mov       r9d,edi
       call      qword ptr [7FF8A7DF6B50]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Insert(System.__Canon[] ByRef, System.String, MemberListType)
       mov       rax,[rbp+18]
       mov       r8,0A13ECE64D09A
       cmp       [rbp],r8
       je        short M07_L02
       call      CORINFO_HELP_FAIL_FAST
M07_L02:
       nop
       lea       rsp,[rbp+20]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M07_L03:
       cmp       r14d,1
       jne       short M07_L04
       cmp       word ptr [rbx+0C],2E
       je        short M07_L04
       cmp       word ptr [rbx+0C],2A
       jne       short M07_L00
M07_L04:
       mov       rcx,2A437400108
       mov       rcx,[rcx]
       mov       rdx,rbx
       call      qword ptr [7FF8A7D2CC60]; Precode of System.Text.UTF8Encoding.GetByteCount(System.String)
       cmp       eax,400
       jbe       short M07_L05
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       r8,[rax+10]
       mov       eax,[rax+8]
       jmp       short M07_L07
M07_L05:
       mov       r8d,eax
       test      r8,r8
       je        short M07_L07
       mov       rdx,r8
       add       rdx,0F
       and       rdx,0FFFFFFFFFFFFFFF0
       add       rsp,30
       neg       rdx
       add       rdx,rsp
       jb        short M07_L06
       xor       edx,edx
M07_L06:
       test      [rsp],esp
       sub       rsp,1000
       cmp       rsp,rdx
       jae       short M07_L06
       mov       rsp,rdx
       test      [rsp],esp
       sub       rsp,30
       lea       r8,[rsp+30]
M07_L07:
       mov       [rbp+8],r8
       mov       [rbp+10],eax
       mov       [rsp+20],r14d
       lea       r8,[rbp+8]
       mov       rdx,rbx
       mov       rcx,rsi
       mov       r9d,edi
       call      qword ptr [7FF8A7DF6928]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].GetListByName(System.String, System.Span`1<Byte>, MemberListType, CacheType)
       mov       [rbp+18],rax
       jmp       near ptr M07_L01
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
       call      qword ptr [7FF8A81A6448]
       int       3
M08_L02:
       mov       rdx,[rcx+18]
       mov       rax,[rdx+18]
       test      rax,rax
       je        short M08_L03
       mov       rcx,rax
       jmp       short M08_L04
M08_L03:
       mov       rdx,7FF8A82E79A8
       call      qword ptr [7FF8A7C2F630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FF8A82E79A8
       call      qword ptr [7FF8A7C2F630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       call      qword ptr [7FF8A7C257A0]; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
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
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       lea       r8,[rbx+18]
       mov       edx,[rbx+10]
       mov       ecx,[r8+8]
       cmp       edx,ecx
       ja        short M12_L00
       mov       r8,[r8]
       mov       eax,edx
       lea       rax,[r8+rax*2]
       sub       ecx,edx
       mov       edi,[rsi+8]
       cmp       edi,ecx
       ja        short M12_L01
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       mov       rcx,rax
       call      qword ptr [7FF8A7C25818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,7FF8A82F0C78
       call      CORINFO_HELP_COUNTPROFILE32
       add       [rbx+10],edi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M12_L00:
       call      qword ptr [7FF8A7DFF210]
       int       3
M12_L01:
       mov       rcx,7FF8A82F0C7C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rbx
       mov       rdx,rsi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FF8A8247D80]
; Total bytes of code 132
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
       call      qword ptr [7FF8D756D928]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       [rbx+10],esi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M13_L00:
       call      qword ptr [7FF8D756F2B8]
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
       call      qword ptr [7FF8D7567170]
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
       call      qword ptr [7FF8D756D928]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       [rbx+10],esi
       jmp       near ptr M14_L06
M14_L01:
       mov       rcx,rsi
       call      qword ptr [7FF8D75671A8]
       test      rax,rax
       je        near ptr M14_L04
       mov       rcx,rsi
       call      qword ptr [7FF8D75683E8]
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
       call      qword ptr [7FF8D7574FF8]
       jmp       short M14_L02
M14_L03:
       mov       ecx,[rsp+48]
       add       [rbx+10],ecx
       jmp       short M14_L06
M14_L04:
       mov       rcx,rsi
       call      qword ptr [7FF8D75683E0]
       mov       rcx,rax
       mov       r8,[rbx]
       lea       r11,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       xor       edx,edx
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       near ptr M14_L00
M14_L05:
       call      qword ptr [7FF8D75600E8]
       mov       rdx,rax
       mov       rcx,rbx
       mov       r8,rsi
       xor       r9d,r9d
       call      qword ptr [7FF8D7584678]
M14_L06:
       nop
       add       rsp,58
       pop       rbx
       pop       rsi
       ret
M14_L07:
       call      qword ptr [7FF8D756F2B8]
       int       3
M14_L08:
       mov       rcx,rbx
       call      qword ptr [7FF8D7574FD0]
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
       call      qword ptr [7FF8D756BB28]; Precode of System.String.Ctor(System.ReadOnlySpan`1<Char>)
       mov       rdi,rax
       mov       rbp,[rbx+8]
       xor       eax,eax
       mov       [rbx+8],rax
       mov       [rsi],rax
       mov       [rsi+8],rax
       mov       [rbx+10],eax
       test      rbp,rbp
       je        short M15_L00
       call      qword ptr [7FF8D755A098]
       mov       rcx,[rax]
       mov       rdx,rbp
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FF8D75798C0]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
M15_L00:
       mov       rax,rdi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M15_L01:
       call      qword ptr [7FF8D756F2B8]
       int       3
; Total bytes of code 126
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       sub       rsp,88
       lea       rbp,[rsp+0C0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-90],ymm4
       vmovdqu   ymmword ptr [rbp-70],ymm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       xor       eax,eax
       mov       [rbp-40],rax
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Enumeration+<>c__DisplayClass17_0<DotNetTips.Spargine.Extensions.NumericFormat>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       dword ptr [rsi+8],1
       lea       rdi,[rsi+8]
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],2
       jle       near ptr M00_L42
       mov       rcx,[rcx+240]
       mov       rax,[rcx+10]
       test      rax,rax
       je        near ptr M00_L42
M00_L00:
       mov       rcx,[rax+10]
       test      rcx,rcx
       jne       short M00_L01
       mov       rcx,1749B800190
       mov       rcx,[rcx]
       test      rcx,rcx
       jne       short M00_L01
       mov       rcx,1749B800170
       mov       rcx,[rcx]
       test      rcx,rcx
       je        near ptr M00_L43
M00_L01:
       mov       edi,[rdi]
       test      edi,edi
       jl        near ptr M00_L44
       cmp       edi,12C
       jae       near ptr M00_L48
       mov       rcx,1749B8002B8
       mov       rcx,[rcx]
       mov       eax,edi
       mov       rdx,[rcx+rax*8+10]
       test      rdx,rdx
       je        near ptr M00_L47
M00_L02:
       mov       [rbp-90],rdx
       mov       rdi,offset MT_DotNetTips.Spargine.Core.Enumeration+<GetAll>d__18<DotNetTips.Spargine.Extensions.NumericFormat>
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       dword ptr [r14+18],0FFFFFFFE
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [r14+1C],eax
       cmp       dword ptr [r14+18],0FFFFFFFE
       jne       near ptr M00_L49
       mov       r15d,[r14+1C]
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       cmp       r15d,eax
       jne       near ptr M00_L49
       xor       ecx,ecx
       mov       [r14+18],ecx
M00_L03:
       mov       [rbp-98],r14
M00_L04:
       mov       rcx,[rbp-98]
       cmp       [rcx],rdi
       jne       near ptr M00_L37
       mov       r14,rcx
       mov       eax,[r14+18]
       test      eax,eax
       je        near ptr M00_L09
       cmp       eax,1
       jne       near ptr M00_L24
       mov       dword ptr [r14+18],0FFFFFFFF
M00_L05:
       inc       dword ptr [r14+20]
M00_L06:
       mov       ecx,[r14+20]
       mov       rdx,[r14+10]
       cmp       ecx,[rdx+8]
       jge       near ptr M00_L35
       cmp       ecx,[rdx+8]
       jae       near ptr M00_L39
       mov       rcx,[rdx+rcx*8+10]
       mov       rdx,offset MT_System.Reflection.RtFieldInfo
       cmp       [rcx],rdx
       jne       near ptr M00_L34
       xor       edx,edx
       call      qword ptr [7FF8A7E93940]; System.Reflection.RtFieldInfo.GetValue(System.Object)
       mov       rdx,rax
M00_L07:
       test      rdx,rdx
       je        short M00_L05
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.NumericFormat
       cmp       [rdx],rcx
       jne       short M00_L05
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [r14+18],1
M00_L08:
       mov       rcx,[rbp-98]
       mov       r14,[rcx+8]
       mov       r11d,[r14+10]
       cmp       r11d,[rsi+8]
       jne       near ptr M00_L04
       jmp       near ptr M00_L40
M00_L09:
       mov       dword ptr [r14+18],0FFFFFFFF
       mov       rax,1749B511170
       mov       r15,[rax]
       test      r15,r15
       jne       short M00_L10
       mov       rcx,1B530890B20
       call      qword ptr [7FF8A7DC56C8]; System.RuntimeType.InitializeCache()
       mov       r13,rax
       jmp       short M00_L11
M00_L10:
       mov       r13,r15
M00_L11:
       cmp       [r13],r13b
       lea       r15,[r13+50]
       mov       rax,[r15]
       test      rax,rax
       je        near ptr M00_L25
M00_L12:
       cmp       byte ptr [rax+18],0
       je        near ptr M00_L26
       mov       r15,[rax+8]
M00_L13:
       mov       r13d,[r15+8]
       mov       edx,r13d
       xor       r8d,r8d
       mov       [rbp-78],r8
       mov       [rbp-70],r8
       mov       [rbp-68],r8d
       mov       [rbp-64],edx
       test      r13d,r13d
       jle       short M00_L18
       add       r15,10
M00_L14:
       mov       r12,[r15]
       mov       edx,[r12+18]
       mov       r8d,edx
       and       r8d,18
       cmp       r8d,edx
       jne       short M00_L17
       cmp       dword ptr [rbp-68],0
       je        near ptr M00_L22
       cmp       dword ptr [rbp-68],1
       je        near ptr M00_L20
       mov       edx,[rbp-64]
       cmp       edx,[rbp-68]
       je        near ptr M00_L28
M00_L15:
       movsxd    rdx,dword ptr [rbp-68]
       mov       rcx,[rbp-78]
       mov       r8,r12
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
M00_L16:
       mov       edx,[rbp-68]
       inc       edx
       mov       [rbp-68],edx
M00_L17:
       add       r15,8
       dec       r13d
       jne       short M00_L14
M00_L18:
       mov       r15,[rbp-78]
       mov       r13,[rbp-70]
       mov       r12d,[rbp-68]
       test      r12d,r12d
       je        near ptr M00_L29
       cmp       r12d,1
       je        near ptr M00_L30
       test      r12d,r12d
       jl        near ptr M00_L38
       test      r15,r15
       je        near ptr M00_L31
       cmp       [r15+8],r12d
       jne       near ptr M00_L32
M00_L19:
       lea       rcx,[r14+10]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r14+20],ecx
       jmp       near ptr M00_L06
M00_L20:
       cmp       dword ptr [rbp-64],2
       jl        near ptr M00_L27
M00_L21:
       movsxd    rdx,dword ptr [rbp-64]
       mov       rcx,offset MT_System.Reflection.FieldInfo[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       [rbp-78],rax
       mov       rcx,[rbp-78]
       mov       r8,[rbp-70]
       xor       edx,edx
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       near ptr M00_L15
M00_L22:
       mov       [rbp-70],r12
       jmp       near ptr M00_L16
M00_L23:
       mov       rcx,[rbp-98]
       cmp       [rcx],rdi
       je        near ptr M00_L08
       mov       rcx,[rbp-98]
       mov       r11,7FF8A7B40A30
       call      qword ptr [r11]
       mov       r14,rax
       mov       rcx,rsi
       mov       rdx,r14
       mov       rax,offset DotNetTips.Spargine.Core.Enumeration+<>c__DisplayClass17_0`1[[System.__Canon, System.Private.CoreLib]].<FromValue>b__0(System.__Canon)
       call      rax
       test      eax,eax
       je        near ptr M00_L04
       jmp       near ptr M00_L40
M00_L24:
       xor       r14d,r14d
       jmp       near ptr M00_L36
M00_L25:
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache+MemberInfoCache<System.Reflection.RuntimeFieldInfo>
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       lea       rcx,[r12+10]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r15
       mov       rdx,r12
       xor       r8d,r8d
       call      00007FF907846040
       test      rax,rax
       jne       near ptr M00_L12
       mov       rax,r12
       jmp       near ptr M00_L12
M00_L26:
       mov       rcx,rax
       xor       edx,edx
       xor       r8d,r8d
       mov       r9d,2
       call      qword ptr [7FF8A7DC6910]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
       mov       r15,rax
       jmp       near ptr M00_L13
M00_L27:
       mov       dword ptr [rbp-64],4
       jmp       near ptr M00_L21
M00_L28:
       mov       eax,[rbp-64]
       add       eax,eax
       mov       [rbp-7C],eax
       lea       rdx,[rbp-78]
       mov       r8d,eax
       mov       rcx,7FF8A7E19080
       call      qword ptr [7FF8A7DC6AD8]; System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
       mov       edx,[rbp-7C]
       mov       [rbp-64],edx
       jmp       near ptr M00_L15
M00_L29:
       mov       rdx,1749B801C40
       mov       r15,[rdx]
       jmp       near ptr M00_L19
M00_L30:
       mov       rcx,offset MT_System.Reflection.FieldInfo[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r15,rax
       mov       rcx,r15
       mov       r8,r13
       xor       edx,edx
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       near ptr M00_L19
M00_L31:
       mov       edx,r12d
       mov       rcx,offset MT_System.Reflection.FieldInfo[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r15,rax
       jmp       near ptr M00_L19
M00_L32:
       mov       edx,r12d
       mov       rcx,offset MT_System.Reflection.FieldInfo[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r13,rax
       lea       rdx,[r13+10]
       lea       r8,[r15+10]
       mov       r9d,[r15+8]
       cmp       r12d,r9d
       jle       short M00_L33
       mov       r12d,r9d
M00_L33:
       mov       r9d,r12d
       mov       rcx,7FF8A82C6AE0
       call      qword ptr [7FF8A8295308]
       mov       r15,r13
       jmp       near ptr M00_L19
M00_L34:
       xor       edx,edx
       mov       rax,[rcx]
       mov       rax,[rax+58]
       call      qword ptr [rax]
       mov       rdx,rax
       jmp       near ptr M00_L07
M00_L35:
       xor       ecx,ecx
       mov       [r14+10],rcx
       jmp       near ptr M00_L24
M00_L36:
       test      r14d,r14d
       jne       near ptr M00_L23
       jmp       near ptr M00_L50
M00_L37:
       mov       r11,7FF8A7B40A28
       call      qword ptr [r11]
       mov       r14d,eax
       jmp       short M00_L36
M00_L38:
       mov       ecx,45
       mov       edx,0D
       call      qword ptr [7FF8A8176418]
       int       3
M00_L39:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L40:
       mov       rcx,[rbp-98]
       cmp       [rcx],rdi
       jne       near ptr M00_L51
       call      qword ptr [7FF8A827AF70]; DotNetTips.Spargine.Core.Enumeration+<GetAll>d__18`1[[System.__Canon, System.Private.CoreLib]].System.IDisposable.Dispose()
M00_L41:
       mov       [rbp-88],r14
       mov       rcx,[rbx+88]
       lea       r8,[rbp-88]
       mov       rdx,7FF8A827BAC0
       cmp       [rcx],ecx
       call      qword ptr [7FF8A821E508]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
M00_L42:
       mov       ecx,2
       call      qword ptr [7FF8A8294F48]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L00
M00_L43:
       call      qword ptr [7FF8A7BFD4B8]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rcx,rax
       jmp       near ptr M00_L01
M00_L44:
       test      rcx,rcx
       je        short M00_L45
       call      qword ptr [7FF8A8175440]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider)
       jmp       short M00_L46
M00_L45:
       call      qword ptr [7FF8A7BFD2A8]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
M00_L46:
       mov       r8,[rax+28]
       mov       ecx,edi
       mov       edx,0FFFFFFFF
       call      qword ptr [7FF8A8295D70]
       mov       rdx,rax
       jmp       near ptr M00_L02
M00_L47:
       mov       ecx,edi
       call      qword ptr [7FF8A7DC54D0]; System.Number.<UInt32ToDecStrForKnownSmallNumber>g__CreateAndCacheString|50_0(UInt32)
       mov       rdx,rax
       jmp       near ptr M00_L02
M00_L48:
       mov       ecx,edi
       call      qword ptr [7FF8A7DC54E8]; System.Number.UInt32ToDecStr_NoSmallNumberCheck(UInt32)
       mov       rdx,rax
       jmp       near ptr M00_L02
M00_L49:
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       xor       eax,eax
       mov       [r14+18],eax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [r14+1C],eax
       jmp       near ptr M00_L03
M00_L50:
       call      M00_L53
       jmp       short M00_L52
M00_L51:
       mov       r11,7FF8A7B40A38
       call      qword ptr [r11]
       jmp       near ptr M00_L41
M00_L52:
       lea       rcx,[rbp-60]
       mov       edx,14
       mov       r8d,2
       call      qword ptr [7FF8A7BFC270]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler..ctor(Int32, Int32)
       lea       rcx,[rbp-60]
       mov       rdx,1B530890AA0
       call      qword ptr [7FF8A7BFC288]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendLiteral(System.String)
       lea       rcx,[rbp-60]
       mov       rdx,[rbp-90]
       call      qword ptr [7FF8A7E8E328]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted(System.String)
       lea       rcx,[rbp-60]
       mov       rdx,1B530890AD8
       call      qword ptr [7FF8A7BFC288]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendLiteral(System.String)
       lea       rcx,[rbp-60]
       mov       rdx,7FF8A827A150
       mov       r8,1B530890B20
       call      qword ptr [7FF8A7E8E2C8]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       lea       rcx,[rbp-60]
       mov       rdx,1B530880C80
       call      qword ptr [7FF8A7BFC288]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendLiteral(System.String)
       lea       rcx,[rbp-60]
       call      qword ptr [7FF8A7BFC2A0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       mov       rbx,rax
       mov       ecx,2033
       mov       rdx,7FF8A7EC41D8
       call      qword ptr [7FF8A7BFF210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8A8004780]
       int       3
M00_L53:
       sub       rsp,28
       mov       rdi,offset MT_DotNetTips.Spargine.Core.Enumeration+<GetAll>d__18<DotNetTips.Spargine.Extensions.NumericFormat>
       mov       rcx,[rbp-98]
       cmp       [rcx],rdi
       jne       short M00_L54
       call      qword ptr [7FF8A827AF70]; DotNetTips.Spargine.Core.Enumeration+<GetAll>d__18`1[[System.__Canon, System.Private.CoreLib]].System.IDisposable.Dispose()
       jmp       short M00_L55
M00_L54:
       mov       r11,7FF8A7B40A38
       call      qword ptr [r11]
M00_L55:
       nop
       add       rsp,28
       ret
; Total bytes of code 1779
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
       jne       near ptr M01_L02
       mov       rcx,offset MT_System.Reflection.FieldAccessor
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rdi+8]
       mov       rcx,[rcx+10]
       cmp       [rcx],cl
       call      qword ptr [7FF8A7DC4B58]; System.Type.GetRootElementType()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+98]
       call      qword ptr [rax+8]
       test      rax,rax
       je        short M01_L03
       mov       rcx,rax
       call      00007FF90781C1F0
       test      eax,eax
       jne       short M01_L00
       mov       rcx,[rdi+8]
       mov       rcx,[rcx+10]
       cmp       [rcx],ecx
       call      qword ptr [7FF8A7DCD500]; System.RuntimeType.get_IsNullableOfT()
       test      eax,eax
       jne       short M01_L00
       mov       dword ptr [rdi+20],0F
       jmp       short M01_L01
M01_L00:
       mov       dword ptr [rdi+20],11
M01_L01:
       lea       rcx,[rbx+30]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
M01_L02:
       mov       rcx,[rbx+30]
       mov       rdx,rsi
       cmp       [rcx],ecx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FF8A7F77CC0]; System.Reflection.FieldAccessor.GetValue(System.Object)
M01_L03:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF8A8295620]
       mov       r8,rax
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF8A8295638]
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
       call      00007FF9078553D0
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
       mov       rax,7FF8A7DE8420
       mov       [rbp-78],rax
       lea       rax,[M02_L03]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FF9077323D0
       call      rax
M02_L03:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FF907B64A90],0
       je        short M02_L04
       call      qword ptr [7FF907B52648]; CORINFO_HELP_STOP_FOR_GC
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
       call      00007FF90786BEF0
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
       call      qword ptr [7FF8A829C720]; System.RuntimeTypeHandle.GetGCHandle(System.Runtime.InteropServices.GCHandleType)
       mov       rdx,rax
       lea       rcx,[rbx+10]
       xor       eax,eax
       lock cmpxchg [rcx],rdx
       test      rax,rax
       je        near ptr M02_L00
       lea       rcx,[rbp-40]
       call      qword ptr [7FF8A8295E00]
       jmp       near ptr M02_L00
M02_L09:
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M02_L10:
       mov       [rbp+10],rbx
       mov       rcx,rbx
       call      qword ptr [7FF8A7DC5710]; System.RuntimeTypeHandle.<GetModule>g__GetModuleWorker|48_0(System.RuntimeType)
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
       jmp       qword ptr [7FF8A7DC6EC8]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
M03_L00:
       call      qword ptr [7FF8A821F618]
       int       3
M03_L01:
       mov       rcx,rax
       mov       rdx,r8
       add       rsp,28
       jmp       near ptr 00007FF9078A3EE0
M03_L02:
       xor       ecx,ecx
       mov       [rax],rcx
       add       rsp,28
       ret
; Total bytes of code 94
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
; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,50
       lea       rbp,[rsp+30]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rbp+8],xmm4
       xor       eax,eax
       mov       [rbp+18],rax
       mov       rax,98DB608F8D68
       mov       [rbp],rax
       mov       rsi,rcx
       mov       rbx,rdx
       mov       edi,r8d
       mov       r14d,r9d
       test      rbx,rbx
       je        near ptr M05_L06
       cmp       dword ptr [rbx+8],0
       je        near ptr M05_L06
       cmp       r14d,1
       jne       short M05_L00
       movzx     r15d,word ptr [rbx+0C]
       cmp       r15d,2E
       jne       short M05_L01
       mov       rcx,7FF8A83B6440
       call      CORINFO_HELP_COUNTPROFILE32
M05_L00:
       mov       rcx,1749B800108
       mov       r15,[rcx]
       mov       rcx,r15
       mov       rdx,7FF8A83B6448
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rcx,r15
       mov       rdx,rbx
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+18]
       mov       r15d,eax
       cmp       r15d,400
       jbe       short M05_L02
       movsxd    rdx,r15d
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       r13,[rax+10]
       mov       r15d,[rax+8]
       jmp       short M05_L04
M05_L01:
       cmp       r15d,2A
       jne       near ptr M05_L05
       mov       rcx,7FF8A83B643C
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M05_L00
M05_L02:
       mov       rcx,7FF8A83B6550
       call      CORINFO_HELP_COUNTPROFILE32
       mov       edx,r15d
       mov       r13,rdx
       test      r13,r13
       je        short M05_L04
       mov       rcx,r13
       add       rcx,0F
       and       rcx,0FFFFFFFFFFFFFFF0
       add       rsp,30
       neg       rcx
       add       rcx,rsp
       jb        short M05_L03
       xor       ecx,ecx
M05_L03:
       test      [rsp],esp
       sub       rsp,1000
       cmp       rsp,rcx
       jae       short M05_L03
       mov       rsp,rcx
       test      [rsp],esp
       sub       rsp,30
       lea       r13,[rsp+30]
M05_L04:
       mov       rcx,7FF8A83B6554
       call      CORINFO_HELP_COUNTPROFILE32
       mov       [rbp+8],r13
       mov       [rbp+10],r15d
       mov       [rsp+20],r14d
       lea       r8,[rbp+8]
       mov       rdx,rbx
       mov       rcx,rsi
       mov       r9d,edi
       call      qword ptr [7FF8A7DC6928]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].GetListByName(System.String, System.Span`1<Byte>, MemberListType, CacheType)
       mov       [rbp+18],rax
       jmp       short M05_L07
M05_L05:
       mov       rcx,7FF8A83B6438
       call      CORINFO_HELP_COUNTPROFILE32
M05_L06:
       xor       r8d,r8d
       mov       [rbp+8],r8
       mov       [rbp+10],r8d
       mov       [rsp+20],r14d
       lea       r8,[rbp+8]
       mov       rcx,rsi
       mov       r9d,edi
       mov       rdx,1B530880008
       call      qword ptr [7FF8A7DC6928]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].GetListByName(System.String, System.Span`1<Byte>, MemberListType, CacheType)
       mov       [rbp+18],rax
M05_L07:
       mov       rcx,7FF8A83B6558
       call      CORINFO_HELP_COUNTPROFILE32
       lea       rdx,[rbp+18]
       mov       rcx,rsi
       mov       r8,rbx
       mov       r9d,edi
       call      qword ptr [7FF8A7DC6B50]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Insert(System.__Canon[] ByRef, System.String, MemberListType)
       mov       rax,[rbp+18]
       mov       r8,98DB608F8D68
       cmp       [rbp],r8
       je        short M05_L08
       call      CORINFO_HELP_FAIL_FAST
M05_L08:
       nop
       lea       rsp,[rbp+20]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 495
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
       call      qword ptr [7FF8A8176418]
       int       3
M06_L02:
       mov       rdx,[rcx+18]
       mov       rax,[rdx+18]
       test      rax,rax
       je        short M06_L03
       mov       rcx,rax
       jmp       short M06_L04
M06_L03:
       mov       rdx,7FF8A82B7F10
       call      qword ptr [7FF8A7BFF630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FF8A82B7F10
       call      qword ptr [7FF8A7BFF630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       call      qword ptr [7FF8A7BF57A0]; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rsi
       mov       rdx,rbp
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       near ptr M06_L00
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
       call      qword ptr [7FF8D7571D18]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       ecx,ebx
       and       ecx,0FFFFFF
       mov       edx,ecx
       mov       r8d,ebx
       sar       r8d,18
       jne       short M09_L01
       cmp       [rax],ecx
       jle       short M09_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M09_L03
M09_L00:
       add       rsp,20
       pop       rbx
       ret
M09_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M09_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M09_L00
M09_L02:
       cmp       [rax+4],edx
       jle       short M09_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M09_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M09_L03
       jmp       short M09_L00
M09_L03:
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
       call      qword ptr [7FF8D75597E8]
       mov       rbx,rax
       mov       rsi,rbx
       call      qword ptr [7FF8D7570A28]
       mov       rdx,rax
       test      rsi,rsi
       je        short M10_L00
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FF8D7571BC8]
       mov       rax,[rbx]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M10_L00:
       call      qword ptr [7FF8D756F410]
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
       jne       short M11_L00
       mov       rax,[rbx+18]
       test      rax,rax
       je        short M11_L00
       add       rsp,20
       pop       rbx
       ret
M11_L00:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Globalization.NumberFormatInfo
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       short M11_L01
       mov       rcx,rbx
       mov       r11,7FF8A7B40C50
       mov       rdx,1B530881518
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,offset MT_System.Globalization.NumberFormatInfo
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       short M11_L01
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FF8A7BFD2A8]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
M11_L01:
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 127
```
```assembly
; System.Globalization.NumberFormatInfo.get_CurrentInfo()
       push      rbx
       sub       rsp,20
       call      qword ptr [7FF8D7570950]; Precode of System.Globalization.CultureInfo.get_CurrentCulture()
       mov       rbx,rax
       cmp       byte ptr [rbx+61],0
       jne       short M12_L00
       mov       rax,[rbx+18]
       test      rax,rax
       je        short M12_L00
       add       rsp,20
       pop       rbx
       ret
M12_L00:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       call      qword ptr [7FF8D7559058]; Precode of System.RuntimeTypeHandle.GetRuntimeTypeFromHandle(IntPtr)
       mov       rdx,rax
       mov       rcx,rbx
       lea       r11,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       call      qword ptr [r11]
       mov       rcx,rax
       call      qword ptr [7FF8D7568458]
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
       call      qword ptr [7FF8D7559700]
       mov       rsi,[rax]
       mov       ecx,ebx
       call      qword ptr [7FF8D756D418]; Precode of System.Number.UInt32ToDecStr_NoSmallNumberCheck(UInt32)
       mov       rdi,rax
       cmp       ebx,[rsi+8]
       jae       short M13_L00
       mov       ecx,ebx
       lea       rcx,[rsi+rcx*8+10]
       mov       rdx,rdi
       call      qword ptr [7FF8D7558FE8]; CORINFO_HELP_ASSIGN_REF
       mov       rax,rdi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M13_L00:
       call      qword ptr [7FF8D7558FD8]
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
       jae       near ptr M14_L06
       lea       rdx,[7FF8D68EC370]
       add       rax,[rdx+rcx*8]
       sar       rax,20
       movsxd    rsi,eax
       mov       rcx,rsi
       call      qword ptr [7FF8D756B9F0]; Precode of System.String.FastAllocateString(IntPtr)
       test      rax,rax
       je        short M14_L00
       lea       rcx,[rax+0C]
       mov       [rsp+20],rcx
       mov       rcx,[rsp+20]
       jmp       short M14_L01
M14_L00:
       xor       eax,eax
       xor       ecx,ecx
M14_L01:
       lea       rcx,[rcx+rsi*2]
       cmp       ebx,0A
       jb        short M14_L05
       cmp       ebx,64
       jb        short M14_L03
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       add       rdx,0C
M14_L02:
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
       jae       short M14_L02
M14_L03:
       cmp       ebx,0A
       jb        short M14_L05
       add       rcx,0FFFFFFFFFFFFFFFC
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       add       rdx,0C
       lea       r8d,[rbx*4]
       mov       edx,[rdx+r8]
       mov       [rcx],edx
M14_L04:
       xor       ecx,ecx
       mov       [rsp+20],rcx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M14_L05:
       lea       edx,[rbx+30]
       mov       [rcx-2],dx
       jmp       short M14_L04
M14_L06:
       call      qword ptr [7FF8D7558FD8]
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
       je        short M15_L01
       lea       rcx,[rax+10]
       mov       eax,[rax+8]
M15_L00:
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
M15_L01:
       xor       ecx,ecx
       xor       eax,eax
       jmp       short M15_L00
; Total bytes of code 102
```
```assembly
; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendLiteral(System.String)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       lea       r8,[rbx+18]
       mov       edx,[rbx+10]
       mov       ecx,[r8+8]
       cmp       edx,ecx
       ja        short M16_L00
       mov       r8,[r8]
       mov       eax,edx
       lea       rax,[r8+rax*2]
       sub       ecx,edx
       mov       edi,[rsi+8]
       cmp       edi,ecx
       ja        short M16_L01
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       mov       rcx,rax
       call      qword ptr [7FF8A7BF5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,7FF8A82C06E0
       call      CORINFO_HELP_COUNTPROFILE32
       add       [rbx+10],edi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M16_L00:
       call      qword ptr [7FF8A7DCF210]
       int       3
M16_L01:
       mov       rcx,7FF8A82C06E4
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rbx
       mov       rdx,rsi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FF8A8217D80]
; Total bytes of code 132
```
```assembly
; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted(System.String)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       cmp       byte ptr [rbx+14],0
       jne       short M17_L01
       test      rdx,rdx
       je        short M17_L01
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
       call      qword ptr [7FF8D756D928]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       [rbx+10],esi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M17_L00:
       call      qword ptr [7FF8D756F2B8]
       int       3
M17_L01:
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
       jne       near ptr M18_L05
       test      rsi,rsi
       je        near ptr M18_L06
       mov       rcx,rsi
       call      qword ptr [7FF8D7567170]
       test      rax,rax
       jne       short M18_L01
       mov       rcx,rsi
       lea       r11,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       call      qword ptr [r11]
       mov       rdx,rax
M18_L00:
       test      rdx,rdx
       je        near ptr M18_L06
       lea       r8,[rbx+18]
       mov       ecx,[rbx+10]
       mov       eax,[r8+8]
       cmp       ecx,eax
       ja        near ptr M18_L07
       mov       r8,[r8]
       mov       r10d,ecx
       lea       r10,[r8+r10*2]
       sub       eax,ecx
       mov       esi,[rdx+8]
       cmp       esi,eax
       ja        near ptr M18_L08
       mov       r8d,esi
       add       r8,r8
       add       rdx,0C
       mov       rcx,r10
       call      qword ptr [7FF8D756D928]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       [rbx+10],esi
       jmp       near ptr M18_L06
M18_L01:
       mov       rcx,rsi
       call      qword ptr [7FF8D75671A8]
       test      rax,rax
       je        near ptr M18_L04
       mov       rcx,rsi
       call      qword ptr [7FF8D75683E8]
       mov       rsi,rax
M18_L02:
       mov       rcx,rsi
       lea       rdx,[rbx+18]
       mov       r9d,[rbx+10]
       mov       r8d,[rdx+8]
       cmp       r9d,r8d
       ja        near ptr M18_L07
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
       jne       short M18_L03
       mov       rcx,rbx
       call      qword ptr [7FF8D7574FF8]
       jmp       short M18_L02
M18_L03:
       mov       ecx,[rsp+48]
       add       [rbx+10],ecx
       jmp       short M18_L06
M18_L04:
       mov       rcx,rsi
       call      qword ptr [7FF8D75683E0]
       mov       rcx,rax
       mov       r8,[rbx]
       lea       r11,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       xor       edx,edx
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       near ptr M18_L00
M18_L05:
       call      qword ptr [7FF8D75600E8]
       mov       rdx,rax
       mov       rcx,rbx
       mov       r8,rsi
       xor       r9d,r9d
       call      qword ptr [7FF8D7584678]
M18_L06:
       nop
       add       rsp,58
       pop       rbx
       pop       rsi
       ret
M18_L07:
       call      qword ptr [7FF8D756F2B8]
       int       3
M18_L08:
       mov       rcx,rbx
       call      qword ptr [7FF8D7574FD0]
       jmp       short M18_L06
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
       ja        short M19_L01
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
       je        short M19_L00
       call      qword ptr [7FF8D755A098]
       mov       rcx,[rax]
       mov       rdx,rbp
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FF8D75798C0]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
M19_L00:
       mov       rax,rdi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M19_L01:
       call      qword ptr [7FF8D756F2B8]
       int       3
; Total bytes of code 126
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.EnumerationBenchmark.GetAll()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Enumeration+<GetAll>d__18<DotNetTips.Spargine.Extensions.NumericFormat>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       dword ptr [rsi+18],0FFFFFFFE
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rsi+1C],eax
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
; Total bytes of code 88
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rcx,283528001B8
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
       je        near ptr M00_L42
       xor       esi,esi
       cmp       dword ptr [rbx+8],0
       jle       near ptr M00_L42
M00_L00:
       movzx     ecx,word ptr [rbx+rsi*2+0C]
       cmp       ecx,100
       jge       near ptr M00_L40
       mov       rax,7FF8D68E6B88
       test      byte ptr [rax+rcx],80
       jne       near ptr M00_L41
M00_L01:
       mov       rax,offset MT_DotNetTips.Spargine.Core.Enumeration+<GetAll>d__18<DotNetTips.Spargine.Extensions.NumericFormat>
       mov       [rbp-88],rax
       mov       dword ptr [rbp-70],0FFFFFFFE
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rbp-6C],eax
       cmp       dword ptr [rbp-70],0FFFFFFFE
       jne       near ptr M00_L44
       mov       ebx,[rbp-6C]
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       cmp       ebx,eax
       jne       near ptr M00_L44
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
       je        near ptr M00_L09
       cmp       ecx,1
       jne       near ptr M00_L45
       mov       dword ptr [rsi+18],0FFFFFFFF
M00_L04:
       inc       dword ptr [rsi+20]
M00_L05:
       mov       ecx,[rsi+20]
       mov       rax,[rsi+10]
       cmp       ecx,[rax+8]
       jge       near ptr M00_L37
       cmp       ecx,[rax+8]
       jae       near ptr M00_L36
       mov       r14,[rax+rcx*8+10]
       mov       rcx,offset MT_System.Reflection.RtFieldInfo
       cmp       [r14],rcx
       jne       near ptr M00_L34
       cmp       qword ptr [r14+30],0
       jne       short M00_L06
       mov       rcx,offset MT_System.Reflection.FieldAccessor
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       mov       rdx,r14
       call      qword ptr [7FF8A7F97CD8]; System.Reflection.FieldAccessor..ctor(System.Reflection.FieldInfo)
       lea       rcx,[r14+30]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
M00_L06:
       mov       rcx,[r14+30]
       xor       edx,edx
       cmp       [rcx],ecx
       call      qword ptr [7FF8A7F97CF0]; System.Reflection.FieldAccessor.GetValue(System.Object)
M00_L07:
       test      rax,rax
       je        short M00_L04
       mov       r8,offset MT_DotNetTips.Spargine.Extensions.NumericFormat
       cmp       [rax],r8
       jne       near ptr M00_L04
       mov       [rsi+8],rax
       mov       dword ptr [rsi+18],1
       mov       r14,[rbx+8]
       mov       r8,[r14+8]
       mov       rdx,[rdi+8]
       cmp       r8,rdx
       je        near ptr M00_L24
       test      r8,r8
       je        near ptr M00_L23
       test      rdx,rdx
       je        near ptr M00_L23
       mov       ecx,[r8+8]
       cmp       ecx,[rdx+8]
       jne       near ptr M00_L23
       lea       rcx,[r8+0C]
       mov       r8d,[r8+8]
       add       r8d,r8d
       add       rdx,0C
       call      qword ptr [7FF8A7C1C330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
M00_L08:
       test      eax,eax
       je        near ptr M00_L03
       jmp       near ptr M00_L38
M00_L09:
       mov       dword ptr [rsi+18],0FFFFFFFF
       mov       rcx,2833C551100
       mov       r14,[rcx]
       test      r14,r14
       jne       short M00_L10
       mov       rcx,2C3D1900C20
       call      qword ptr [7FF8A7DE56C8]; System.RuntimeType.InitializeCache()
       mov       r15,rax
       jmp       short M00_L11
M00_L10:
       mov       r15,r14
M00_L11:
       cmp       [r15],r15b
       lea       r14,[r15+50]
       mov       rcx,[r14]
       test      rcx,rcx
       je        near ptr M00_L25
M00_L12:
       cmp       byte ptr [rcx+18],0
       je        near ptr M00_L26
       mov       r14,[rcx+8]
M00_L13:
       mov       r15d,[r14+8]
       mov       edx,r15d
       xor       r8d,r8d
       mov       [rbp-58],r8
       mov       [rbp-50],r8
       mov       [rbp-48],r8d
       mov       [rbp-44],edx
       test      r15d,r15d
       jle       short M00_L18
       add       r14,10
M00_L14:
       mov       r13,[r14]
       mov       edx,[r13+18]
       mov       r8d,edx
       and       r8d,18
       cmp       r8d,edx
       jne       short M00_L17
       cmp       dword ptr [rbp-48],0
       je        near ptr M00_L22
       cmp       dword ptr [rbp-48],1
       je        short M00_L20
       mov       edx,[rbp-44]
       cmp       edx,[rbp-48]
       je        near ptr M00_L28
M00_L15:
       movsxd    rdx,dword ptr [rbp-48]
       mov       rcx,[rbp-58]
       mov       r8,r13
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
M00_L16:
       mov       edx,[rbp-48]
       inc       edx
       mov       [rbp-48],edx
M00_L17:
       add       r14,8
       dec       r15d
       jne       short M00_L14
M00_L18:
       mov       r14,[rbp-58]
       mov       r15,[rbp-50]
       mov       r13d,[rbp-48]
       test      r13d,r13d
       je        near ptr M00_L29
       cmp       r13d,1
       je        near ptr M00_L30
       test      r13d,r13d
       jl        near ptr M00_L35
       test      r14,r14
       je        near ptr M00_L31
       cmp       [r14+8],r13d
       jne       near ptr M00_L32
M00_L19:
       mov       [rsi+10],r14
       xor       ecx,ecx
       mov       [rsi+20],ecx
       jmp       near ptr M00_L05
M00_L20:
       cmp       dword ptr [rbp-44],2
       jl        near ptr M00_L27
M00_L21:
       movsxd    rdx,dword ptr [rbp-44]
       mov       rcx,offset MT_System.Reflection.FieldInfo[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       [rbp-58],rax
       mov       rcx,[rbp-58]
       mov       r8,[rbp-50]
       xor       edx,edx
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       near ptr M00_L15
M00_L22:
       mov       [rbp-50],r13
       jmp       near ptr M00_L16
M00_L23:
       xor       eax,eax
       jmp       near ptr M00_L08
M00_L24:
       mov       eax,1
       jmp       near ptr M00_L08
M00_L25:
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache+MemberInfoCache<System.Reflection.RuntimeFieldInfo>
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       lea       rcx,[r13+10]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r14
       mov       rdx,r13
       xor       r8d,r8d
       call      00007FF907846040
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M00_L12
       mov       rcx,r13
       jmp       near ptr M00_L12
M00_L26:
       xor       edx,edx
       xor       r8d,r8d
       mov       r9d,2
       call      qword ptr [7FF8A7DE6910]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
       mov       r14,rax
       jmp       near ptr M00_L13
M00_L27:
       mov       dword ptr [rbp-44],4
       jmp       near ptr M00_L21
M00_L28:
       mov       r12d,[rbp-44]
       add       r12d,r12d
       lea       rdx,[rbp-58]
       mov       r8d,r12d
       mov       rcx,7FF8A7E39080
       call      qword ptr [7FF8A7DE6AD8]; System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
       mov       [rbp-44],r12d
       jmp       near ptr M00_L15
M00_L29:
       mov       rcx,2833C801C40
       mov       r14,[rcx]
       jmp       near ptr M00_L19
M00_L30:
       mov       rcx,offset MT_System.Reflection.FieldInfo[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       mov       rcx,r14
       mov       r8,r15
       xor       edx,edx
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       near ptr M00_L19
M00_L31:
       mov       edx,r13d
       mov       rcx,offset MT_System.Reflection.FieldInfo[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       jmp       near ptr M00_L19
M00_L32:
       mov       edx,r13d
       mov       rcx,offset MT_System.Reflection.FieldInfo[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r15,rax
       lea       rdx,[r15+10]
       lea       r8,[r14+10]
       mov       r9d,[r14+8]
       cmp       r13d,r9d
       jle       short M00_L33
       mov       r13d,r9d
M00_L33:
       mov       r9d,r13d
       mov       rcx,7FF8A82E5DD8
       call      qword ptr [7FF8A82B52A8]
       mov       r14,r15
       jmp       near ptr M00_L19
M00_L34:
       mov       rcx,r14
       xor       edx,edx
       mov       rax,[r14]
       mov       rax,[rax+58]
       call      qword ptr [rax]
       jmp       near ptr M00_L07
M00_L35:
       mov       ecx,45
       mov       edx,0D
       call      qword ptr [7FF8A8196448]
       int       3
M00_L36:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L37:
       xor       ecx,ecx
       mov       [rsi+10],rcx
       jmp       near ptr M00_L45
M00_L38:
       xor       ecx,ecx
       mov       rbx,[rbp-40]
       mov       [rbx+10],rcx
       mov       dword ptr [rbx+18],0FFFFFFFE
M00_L39:
       mov       [rbp-60],r14
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+88]
       lea       r8,[rbp-60]
       mov       rdx,7FF8A829B7E0
       cmp       [rcx],ecx
       call      qword ptr [7FF8A823E4F0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FF8A82B5BD8]
       test      eax,eax
       je        near ptr M00_L01
M00_L41:
       inc       esi
       cmp       [rbx+8],esi
       jg        near ptr M00_L00
M00_L42:
       xor       r14d,r14d
       jmp       short M00_L39
M00_L43:
       xor       r14d,r14d
       jmp       short M00_L39
M00_L44:
       mov       rax,offset MT_DotNetTips.Spargine.Core.Enumeration+<GetAll>d__18<DotNetTips.Spargine.Extensions.NumericFormat>
       mov       [rbp-0B0],rax
       xor       eax,eax
       mov       [rbp-98],eax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rbp-94],eax
       lea       rbx,[rbp-0B0]
       jmp       near ptr M00_L02
M00_L45:
       call      M00_L46
       jmp       short M00_L43
M00_L46:
       sub       rsp,28
       cmp       qword ptr [rbp-40],0
       je        short M00_L47
       xor       ecx,ecx
       mov       rbx,[rbp-40]
       mov       [rbx+10],rcx
       mov       dword ptr [rbx+18],0FFFFFFFE
M00_L47:
       add       rsp,28
       ret
; Total bytes of code 1405
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
       mov       rax,7FF907846950
       call      rax
       movzx     ebx,al
       mov       rsi,[rsp+20]
       cmp       dword ptr [7FF907B64A90],0
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
       call      00007FF90781C1F0
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
       call      qword ptr [7FF8A82B5590]
       mov       r8,rax
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF8A82B55A8]
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
       lea       rax,[7FF8A83117F0]
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
       call      qword ptr [7FF8A7B5A578]; Precode of System.RuntimeType.IsInstanceOfType(System.Object)
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
       call      qword ptr [7FF8A7B5A578]; Precode of System.RuntimeType.IsInstanceOfType(System.Object)
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
       call      qword ptr [7FF8A82B55D8]
       jmp       near ptr M02_L01
       mov       rcx,[rbx+8]
       mov       rcx,[rcx+10]
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FF8A7B5A578]; Precode of System.RuntimeType.IsInstanceOfType(System.Object)
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
       call      qword ptr [7FF8A7F97C78]; System.Reflection.RtFieldInfo.InitializeFieldType()
       mov       rdx,rax
M02_L07:
       mov       rcx,rsi
       call      qword ptr [7FF8A82B55C0]
       jmp       near ptr M02_L01
       mov       rcx,[rbx+18]
       mov       rdx,[rbx+10]
       call      qword ptr [7FF8A82B55D8]
       jmp       near ptr M02_L01
       mov       rcx,[rbx+18]
       mov       rdx,[rbx+10]
       mov       rdx,[rdx]
       cmp       [rdx],dl
       add       rdx,8
       call      qword ptr [7FF8A82B55D8]
       jmp       near ptr M02_L01
       mov       rcx,[rbx+10]
       mov       rsi,[rcx]
       mov       rcx,[rbx+8]
       mov       rdx,[rcx+28]
       test      rdx,rdx
       jne       short M02_L08
       call      qword ptr [7FF8A7F97C78]; System.Reflection.RtFieldInfo.InitializeFieldType()
       mov       rdx,rax
M02_L08:
       mov       rcx,rsi
       call      qword ptr [7FF8A82B55C0]
       jmp       near ptr M02_L01
       mov       rcx,rbx
       call      qword ptr [7FF8A7F97D08]; System.Reflection.FieldAccessor.IsStatic()
       test      eax,eax
       jne       short M02_L09
       mov       rcx,[rbx+8]
       mov       rcx,[rcx+10]
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FF8A7B5A578]; Precode of System.RuntimeType.IsInstanceOfType(System.Object)
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
       call      qword ptr [7FF8A7F97C78]; System.Reflection.RtFieldInfo.InitializeFieldType()
       mov       rdx,rax
M02_L10:
       mov       rcx,offset MT_System.RuntimeType
       call      qword ptr [7FF8A7C16328]; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       r8,rax
       lea       r9,[rsp+28]
       mov       [rsp+20],r9
       mov       r9,[rbx+8]
       mov       r9,[r9+10]
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF8A7F97D20]; System.RuntimeFieldHandle.GetValue(System.Reflection.RtFieldInfo, System.Object, System.RuntimeType, System.RuntimeType, Boolean ByRef)
       mov       rsi,rax
       cmp       byte ptr [rsp+28],0
       je        short M02_L11
       mov       rcx,rbx
       call      qword ptr [7FF8A7F97D38]; System.Reflection.FieldAccessor.Initialize()
M02_L11:
       mov       rax,rsi
       jmp       near ptr M02_L01
       mov       rcx,rbx
       call      qword ptr [7FF8A7F97D08]; System.Reflection.FieldAccessor.IsStatic()
       test      eax,eax
       jne       short M02_L14
       mov       rcx,[rbx+8]
       mov       rcx,[rcx+10]
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FF8A7B5A578]; Precode of System.RuntimeType.IsInstanceOfType(System.Object)
       test      eax,eax
       jne       short M02_L14
       test      rsi,rsi
       jne       short M02_L13
M02_L12:
       call      qword ptr [7FF8A82B55F0]
       int       3
M02_L13:
       mov       rdx,[rbx+8]
       mov       rcx,rsi
       call      qword ptr [7FF8A82B5608]
       int       3
M02_L14:
       mov       dword ptr [rsp+28],1
       mov       rdi,[rbx+8]
       mov       rcx,[rbx+8]
       mov       rdx,[rcx+28]
       test      rdx,rdx
       jne       short M02_L15
       call      qword ptr [7FF8A7F97C78]; System.Reflection.RtFieldInfo.InitializeFieldType()
       mov       rdx,rax
M02_L15:
       mov       rcx,offset MT_System.RuntimeType
       call      qword ptr [7FF8A7C16328]; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       r8,rax
       lea       r9,[rsp+28]
       mov       [rsp+20],r9
       mov       r9,[rbx+8]
       mov       r9,[r9+10]
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF8A7F97D20]; System.RuntimeFieldHandle.GetValue(System.Reflection.RtFieldInfo, System.Object, System.RuntimeType, System.RuntimeType, Boolean ByRef)
       jmp       near ptr M02_L01
       mov       rcx,[rbx+8]
       cmp       [rcx],ecx
       call      qword ptr [7FF8A7E383E8]; Precode of System.Reflection.RuntimeFieldInfo.get_DeclaringType()
       test      rax,rax
       je        short M02_L16
       mov       rcx,[rbx+8]
       cmp       [rcx],ecx
       call      qword ptr [7FF8A7E383E8]; Precode of System.Reflection.RuntimeFieldInfo.get_DeclaringType()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+0B0]
       call      qword ptr [rax]
       test      eax,eax
       je        short M02_L16
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF8A82B5620]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8A7F96130]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M02_L16:
       mov       rcx,[rbx+8]
       cmp       [rcx],ecx
       call      qword ptr [7FF8A7E383E8]; Precode of System.Reflection.RuntimeFieldInfo.get_DeclaringType()
       test      rax,rax
       je        short M02_L18
       mov       rcx,[rbx+8]
       mov       rdx,[rcx+28]
       test      rdx,rdx
       jne       short M02_L17
       call      qword ptr [7FF8A7F97C78]; System.Reflection.RtFieldInfo.InitializeFieldType()
       mov       rdx,rax
M02_L17:
       mov       rcx,offset MT_System.RuntimeType
       call      qword ptr [7FF8A7C16328]; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF8A7DED500]; System.RuntimeType.get_IsNullableOfT()
       test      eax,eax
       je        short M02_L18
       mov       rcx,offset MT_System.NotSupportedException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8A82B5638]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M02_L18:
       mov       rcx,offset MT_System.FieldAccessException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF8A82B5650]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 908
```
```assembly
; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       r8,8
       jae       short M03_L05
       cmp       r8,4
       jae       short M03_L04
       xor       eax,eax
       mov       r10,r8
       and       r10,2
       je        short M03_L00
       movzx     eax,word ptr [rcx]
       movzx     r9d,word ptr [rdx]
       sub       eax,r9d
M03_L00:
       test      r8b,1
       jne       short M03_L03
M03_L01:
       test      eax,eax
       sete      al
       movzx     eax,al
M03_L02:
       vzeroupper
       ret
M03_L03:
       movzx     r8d,byte ptr [rcx+r10]
       movzx     ecx,byte ptr [rdx+r10]
       sub       r8d,ecx
       or        eax,r8d
       jmp       short M03_L01
M03_L04:
       add       r8,0FFFFFFFFFFFFFFFC
       mov       eax,[rcx]
       sub       eax,[rdx]
       mov       ecx,[rcx+r8]
       sub       ecx,[rdx+r8]
       or        eax,ecx
       sete      al
       movzx     eax,al
       jmp       short M03_L02
M03_L05:
       cmp       rcx,rdx
       je        near ptr M03_L11
       cmp       r8,20
       jb        short M03_L08
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFE0
       je        short M03_L07
M03_L06:
       vmovups   ymm0,[rcx+rax]
       vpcmpeqb  ymm0,ymm0,[rdx+rax]
       vpmovmskb r10d,ymm0
       cmp       r10d,0FFFFFFFF
       jne       near ptr M03_L13
       add       rax,20
       cmp       r8,rax
       ja        short M03_L06
M03_L07:
       vmovups   ymm0,[rcx+r8]
       vpcmpeqb  ymm0,ymm0,[rdx+r8]
       vpmovmskb ecx,ymm0
       cmp       ecx,0FFFFFFFF
       jne       short M03_L13
       jmp       short M03_L11
M03_L08:
       cmp       r8,10
       jb        short M03_L12
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFF0
       je        short M03_L10
M03_L09:
       vmovups   xmm0,[rcx+rax]
       vpcmpeqb  xmm0,xmm0,[rdx+rax]
       vpmovmskb r10d,xmm0
       cmp       r10d,0FFFF
       jne       short M03_L13
       add       rax,10
       cmp       r8,rax
       ja        short M03_L09
M03_L10:
       vmovups   xmm0,[rcx+r8]
       vpcmpeqb  xmm0,xmm0,[rdx+r8]
       vpmovmskb eax,xmm0
       cmp       eax,0FFFF
       jne       short M03_L13
M03_L11:
       mov       eax,1
       vzeroupper
       ret
M03_L12:
       lea       rax,[r8-8]
       mov       r8,[rcx]
       sub       r8,[rdx]
       mov       rcx,[rcx+rax]
       sub       rcx,[rdx+rax]
       or        rcx,r8
       sete      al
       movzx     eax,al
       jmp       near ptr M03_L02
M03_L13:
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
       call      00007FF9078553D0
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
       mov       rax,7FF8A7E08420
       mov       [rbp-78],rax
       lea       rax,[M04_L03]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FF9077323D0
       call      rax
M04_L03:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FF907B64A90],0
       je        short M04_L04
       call      qword ptr [7FF907B52648]; CORINFO_HELP_STOP_FOR_GC
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
       call      00007FF90786BEF0
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
       call      qword ptr [7FF8A82BC6C0]; System.RuntimeTypeHandle.GetGCHandle(System.Runtime.InteropServices.GCHandleType)
       mov       rdx,rax
       lea       rcx,[rbx+10]
       xor       eax,eax
       lock cmpxchg [rcx],rdx
       test      rax,rax
       je        near ptr M04_L00
       lea       rcx,[rbp-40]
       call      qword ptr [7FF8A82B5D40]
       jmp       near ptr M04_L00
M04_L09:
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M04_L10:
       mov       [rbp+10],rbx
       mov       rcx,rbx
       call      qword ptr [7FF8A7DE5710]; System.RuntimeTypeHandle.<GetModule>g__GetModuleWorker|48_0(System.RuntimeType)
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
       jmp       qword ptr [7FF8A7DE6EC8]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
M05_L00:
       call      qword ptr [7FF8A823F6A8]
       int       3
M05_L01:
       mov       rcx,rax
       mov       rdx,r8
       add       rsp,28
       jmp       near ptr 00007FF9078A3EE0
M05_L02:
       xor       ecx,ecx
       mov       [rax],rcx
       add       rsp,28
       ret
; Total bytes of code 94
```
```assembly
; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,50
       lea       rbp,[rsp+30]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rbp+8],xmm4
       xor       eax,eax
       mov       [rbp+18],rax
       mov       rax,197F378833D2
       mov       [rbp],rax
       mov       rsi,rcx
       mov       rbx,rdx
       mov       edi,r8d
       mov       r14d,r9d
       test      rbx,rbx
       je        near ptr M06_L06
       cmp       dword ptr [rbx+8],0
       je        near ptr M06_L06
       cmp       r14d,1
       jne       short M06_L00
       movzx     r15d,word ptr [rbx+0C]
       cmp       r15d,2E
       jne       short M06_L01
       mov       rcx,7FF8A83D9660
       call      CORINFO_HELP_COUNTPROFILE32
M06_L00:
       mov       rcx,2833C800108
       mov       r15,[rcx]
       mov       rcx,r15
       mov       rdx,7FF8A83D9668
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rcx,r15
       mov       rdx,rbx
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+18]
       mov       r15d,eax
       cmp       r15d,400
       jbe       short M06_L02
       movsxd    rdx,r15d
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       r13,[rax+10]
       mov       r15d,[rax+8]
       jmp       short M06_L04
M06_L01:
       cmp       r15d,2A
       jne       near ptr M06_L05
       mov       rcx,7FF8A83D965C
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M06_L00
M06_L02:
       mov       rcx,7FF8A83D9770
       call      CORINFO_HELP_COUNTPROFILE32
       mov       edx,r15d
       mov       r13,rdx
       test      r13,r13
       je        short M06_L04
       mov       rcx,r13
       add       rcx,0F
       and       rcx,0FFFFFFFFFFFFFFF0
       add       rsp,30
       neg       rcx
       add       rcx,rsp
       jb        short M06_L03
       xor       ecx,ecx
M06_L03:
       test      [rsp],esp
       sub       rsp,1000
       cmp       rsp,rcx
       jae       short M06_L03
       mov       rsp,rcx
       test      [rsp],esp
       sub       rsp,30
       lea       r13,[rsp+30]
M06_L04:
       mov       rcx,7FF8A83D9774
       call      CORINFO_HELP_COUNTPROFILE32
       mov       [rbp+8],r13
       mov       [rbp+10],r15d
       mov       [rsp+20],r14d
       lea       r8,[rbp+8]
       mov       rdx,rbx
       mov       rcx,rsi
       mov       r9d,edi
       call      qword ptr [7FF8A7DE6928]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].GetListByName(System.String, System.Span`1<Byte>, MemberListType, CacheType)
       mov       [rbp+18],rax
       jmp       short M06_L07
M06_L05:
       mov       rcx,7FF8A83D9658
       call      CORINFO_HELP_COUNTPROFILE32
M06_L06:
       xor       r8d,r8d
       mov       [rbp+8],r8
       mov       [rbp+10],r8d
       mov       [rsp+20],r14d
       lea       r8,[rbp+8]
       mov       rcx,rsi
       mov       r9d,edi
       mov       rdx,2C3D18F0008
       call      qword ptr [7FF8A7DE6928]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].GetListByName(System.String, System.Span`1<Byte>, MemberListType, CacheType)
       mov       [rbp+18],rax
M06_L07:
       mov       rcx,7FF8A83D9778
       call      CORINFO_HELP_COUNTPROFILE32
       lea       rdx,[rbp+18]
       mov       rcx,rsi
       mov       r8,rbx
       mov       r9d,edi
       call      qword ptr [7FF8A7DE6B50]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Insert(System.__Canon[] ByRef, System.String, MemberListType)
       mov       rax,[rbp+18]
       mov       r8,197F378833D2
       cmp       [rbp],r8
       je        short M06_L08
       call      CORINFO_HELP_FAIL_FAST
M06_L08:
       nop
       lea       rsp,[rbp+20]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 495
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
       call      qword ptr [7FF8A8196448]
       int       3
M07_L02:
       mov       rdx,[rcx+18]
       mov       rax,[rdx+18]
       test      rax,rax
       je        short M07_L03
       mov       rcx,rax
       jmp       short M07_L04
M07_L03:
       mov       rdx,7FF8A82D7610
       call      qword ptr [7FF8A7C1F630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FF8A82D7610
       call      qword ptr [7FF8A7C1F630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       call      qword ptr [7FF8A7C157A0]; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
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

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       jne       near ptr M00_L30
       mov       esi,[rbp-84]
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       cmp       esi,eax
       jne       near ptr M00_L30
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
       call      qword ptr [7FF8A82C6DA8]; System.Reflection.RtFieldInfo.get_FieldAccessor()
       mov       rcx,rax
       xor       edx,edx
       cmp       [rcx],ecx
       call      qword ptr [7FF8A7FA7CF0]; System.Reflection.FieldAccessor.GetValue(System.Object)
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
       mov       rcx,257698F1970
       mov       r14,[rcx]
       test      r14,r14
       jne       short M00_L06
       mov       rcx,29800820AA0
       call      qword ptr [7FF8A7DF56C8]; System.RuntimeType.InitializeCache()
       mov       r15,rax
       jmp       short M00_L07
M00_L06:
       mov       r15,r14
M00_L07:
       cmp       [r15],r15b
       lea       r14,[r15+50]
       mov       rcx,[r14]
       test      rcx,rcx
       je        near ptr M00_L19
M00_L08:
       cmp       byte ptr [rcx+18],0
       je        near ptr M00_L20
       mov       r14,[rcx+8]
M00_L09:
       mov       r15d,[r14+8]
       mov       edx,r15d
       xor       r8d,r8d
       mov       [rbp-70],r8
       mov       [rbp-68],r8
       mov       [rbp-60],r8d
       mov       [rbp-5C],edx
       test      r15d,r15d
       jle       short M00_L14
       add       r14,10
M00_L10:
       mov       r13,[r14]
       mov       edx,[r13+18]
       mov       r8d,edx
       and       r8d,18
       cmp       r8d,edx
       jne       short M00_L13
       cmp       dword ptr [rbp-60],0
       je        near ptr M00_L18
       cmp       dword ptr [rbp-60],1
       je        near ptr M00_L16
       mov       edx,[rbp-5C]
       cmp       edx,[rbp-60]
       je        near ptr M00_L22
M00_L11:
       movsxd    rdx,dword ptr [rbp-60]
       mov       rcx,[rbp-70]
       mov       r8,r13
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
M00_L12:
       mov       edx,[rbp-60]
       inc       edx
       mov       [rbp-60],edx
M00_L13:
       add       r14,8
       dec       r15d
       jne       short M00_L10
M00_L14:
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
       mov       rcx,7FF8A7E49080
       call      qword ptr [7FF8A7DF6AD8]; System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
       mov       ecx,[rbp-48]
       mov       [rbp-44],ecx
       mov       r14,[rbp-58]
M00_L15:
       mov       [rdi+10],r14
       xor       ecx,ecx
       mov       [rdi+20],ecx
       jmp       near ptr M00_L03
M00_L16:
       cmp       dword ptr [rbp-5C],2
       jl        near ptr M00_L21
M00_L17:
       movsxd    rdx,dword ptr [rbp-5C]
       mov       rcx,offset MT_System.Reflection.FieldInfo[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       [rbp-70],rax
       mov       rcx,[rbp-70]
       mov       r8,[rbp-68]
       xor       edx,edx
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       near ptr M00_L11
M00_L18:
       mov       [rbp-68],r13
       jmp       near ptr M00_L12
M00_L19:
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache+MemberInfoCache<System.Reflection.RuntimeFieldInfo>
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       lea       rcx,[r13+10]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r14
       mov       rdx,r13
       xor       r8d,r8d
       call      00007FF907846040
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M00_L08
       mov       rcx,r13
       jmp       near ptr M00_L08
M00_L20:
       xor       edx,edx
       xor       r8d,r8d
       mov       r9d,2
       call      qword ptr [7FF8A7DF6910]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
       mov       r14,rax
       jmp       near ptr M00_L09
M00_L21:
       mov       dword ptr [rbp-5C],4
       jmp       near ptr M00_L17
M00_L22:
       mov       r12d,[rbp-5C]
       add       r12d,r12d
       lea       rdx,[rbp-70]
       mov       r8d,r12d
       mov       rcx,7FF8A7E49080
       call      qword ptr [7FF8A7DF6AD8]; System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
       mov       [rbp-5C],r12d
       jmp       near ptr M00_L11
M00_L23:
       mov       rcx,2576B801C40
       mov       r14,[rcx]
       jmp       near ptr M00_L15
M00_L24:
       mov       rcx,offset MT_System.Reflection.FieldInfo[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       mov       rcx,r14
       mov       r8,[rbp-50]
       xor       edx,edx
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       near ptr M00_L15
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
       mov       rcx,[rcx+88]
       lea       r8,[rbp-78]
       mov       rdx,7FF8A82AB780
       cmp       [rcx],ecx
       call      qword ptr [7FF8A824E4D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       mov       rax,offset MT_DotNetTips.Spargine.Core.Enumeration+<GetAll>d__18<DotNetTips.Spargine.Extensions.NumericFormat>
       mov       [rbp-0C8],rax
       xor       eax,eax
       mov       [rbp-0B0],eax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rbp-0AC],eax
       lea       rsi,[rbp-0C8]
       jmp       near ptr M00_L00
M00_L31:
       xor       ecx,ecx
       jmp       short M00_L29
M00_L32:
       call      M00_L33
       jmp       short M00_L31
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
; Total bytes of code 1081
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
       call      qword ptr [7FF8A7FA7CD8]; System.Reflection.FieldAccessor..ctor(System.Reflection.FieldInfo)
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
       lea       rax,[7FF8A83216D8]
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
       call      qword ptr [7FF8A7B6A578]; Precode of System.RuntimeType.IsInstanceOfType(System.Object)
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
       call      qword ptr [7FF8A7B6A578]; Precode of System.RuntimeType.IsInstanceOfType(System.Object)
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
       call      qword ptr [7FF8A82C55F0]
       jmp       near ptr M02_L01
       mov       rcx,[rbx+8]
       mov       rcx,[rcx+10]
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FF8A7B6A578]; Precode of System.RuntimeType.IsInstanceOfType(System.Object)
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
       call      qword ptr [7FF8A7FA7C78]; System.Reflection.RtFieldInfo.InitializeFieldType()
       mov       rdx,rax
M02_L07:
       mov       rcx,rsi
       call      qword ptr [7FF8A82C55D8]
       jmp       near ptr M02_L01
       mov       rcx,[rbx+18]
       mov       rdx,[rbx+10]
       call      qword ptr [7FF8A82C55F0]
       jmp       near ptr M02_L01
       mov       rcx,[rbx+18]
       mov       rdx,[rbx+10]
       mov       rdx,[rdx]
       cmp       [rdx],dl
       add       rdx,8
       call      qword ptr [7FF8A82C55F0]
       jmp       near ptr M02_L01
       mov       rcx,[rbx+10]
       mov       rsi,[rcx]
       mov       rcx,[rbx+8]
       mov       rdx,[rcx+28]
       test      rdx,rdx
       jne       short M02_L08
       call      qword ptr [7FF8A7FA7C78]; System.Reflection.RtFieldInfo.InitializeFieldType()
       mov       rdx,rax
M02_L08:
       mov       rcx,rsi
       call      qword ptr [7FF8A82C55D8]
       jmp       near ptr M02_L01
       mov       rcx,rbx
       call      qword ptr [7FF8A7FA7D08]; System.Reflection.FieldAccessor.IsStatic()
       test      eax,eax
       jne       short M02_L09
       mov       rcx,[rbx+8]
       mov       rcx,[rcx+10]
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FF8A7B6A578]; Precode of System.RuntimeType.IsInstanceOfType(System.Object)
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
       call      qword ptr [7FF8A7FA7C78]; System.Reflection.RtFieldInfo.InitializeFieldType()
       mov       rdx,rax
M02_L10:
       mov       r8,rdx
       test      r8,r8
       je        short M02_L11
       mov       rcx,offset MT_System.RuntimeType
       cmp       [r8],rcx
       je        short M02_L11
       call      qword ptr [7FF8A7C26328]; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M02_L11:
       lea       r9,[rsp+28]
       mov       [rsp+20],r9
       mov       r9,[rbx+8]
       mov       r9,[r9+10]
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF8A7FA7D20]; System.RuntimeFieldHandle.GetValue(System.Reflection.RtFieldInfo, System.Object, System.RuntimeType, System.RuntimeType, Boolean ByRef)
       mov       rsi,rax
       cmp       byte ptr [rsp+28],0
       je        short M02_L12
       mov       rcx,rbx
       call      qword ptr [7FF8A7FA7D38]; System.Reflection.FieldAccessor.Initialize()
M02_L12:
       mov       rax,rsi
       jmp       near ptr M02_L01
       mov       rcx,rbx
       call      qword ptr [7FF8A7FA7D08]; System.Reflection.FieldAccessor.IsStatic()
       test      eax,eax
       jne       short M02_L15
       mov       rcx,[rbx+8]
       mov       rcx,[rcx+10]
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FF8A7B6A578]; Precode of System.RuntimeType.IsInstanceOfType(System.Object)
       test      eax,eax
       jne       short M02_L15
       test      rsi,rsi
       jne       short M02_L14
M02_L13:
       call      qword ptr [7FF8A82C5608]
       int       3
M02_L14:
       mov       rdx,[rbx+8]
       mov       rcx,rsi
       call      qword ptr [7FF8A82C5620]
       int       3
M02_L15:
       mov       dword ptr [rsp+28],1
       mov       rdi,[rbx+8]
       mov       rcx,[rbx+8]
       mov       rdx,[rcx+28]
       test      rdx,rdx
       jne       short M02_L16
       call      qword ptr [7FF8A7FA7C78]; System.Reflection.RtFieldInfo.InitializeFieldType()
       mov       rdx,rax
M02_L16:
       mov       rcx,offset MT_System.RuntimeType
       call      qword ptr [7FF8A7C26328]; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       r8,rax
       lea       r9,[rsp+28]
       mov       [rsp+20],r9
       mov       r9,[rbx+8]
       mov       r9,[r9+10]
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF8A7FA7D20]; System.RuntimeFieldHandle.GetValue(System.Reflection.RtFieldInfo, System.Object, System.RuntimeType, System.RuntimeType, Boolean ByRef)
       jmp       near ptr M02_L01
       mov       rcx,[rbx+8]
       cmp       [rcx],ecx
       call      qword ptr [7FF8A7E483E8]; Precode of System.Reflection.RuntimeFieldInfo.get_DeclaringType()
       test      rax,rax
       je        short M02_L17
       mov       rcx,[rbx+8]
       cmp       [rcx],ecx
       call      qword ptr [7FF8A7E483E8]; Precode of System.Reflection.RuntimeFieldInfo.get_DeclaringType()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+0B0]
       call      qword ptr [rax]
       test      eax,eax
       je        short M02_L17
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF8A82C5638]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8A7FA6130]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M02_L17:
       mov       rcx,[rbx+8]
       cmp       [rcx],ecx
       call      qword ptr [7FF8A7E483E8]; Precode of System.Reflection.RuntimeFieldInfo.get_DeclaringType()
       test      rax,rax
       je        short M02_L19
       mov       rcx,[rbx+8]
       mov       rdx,[rcx+28]
       test      rdx,rdx
       jne       short M02_L18
       call      qword ptr [7FF8A7FA7C78]; System.Reflection.RtFieldInfo.InitializeFieldType()
       mov       rdx,rax
M02_L18:
       mov       rcx,offset MT_System.RuntimeType
       call      qword ptr [7FF8A7C26328]; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF8A7DFD500]; System.RuntimeType.get_IsNullableOfT()
       test      eax,eax
       je        short M02_L19
       mov       rcx,offset MT_System.NotSupportedException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8A82C5650]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M02_L19:
       mov       rcx,offset MT_System.FieldAccessException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF8A82C5668]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 918
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
       call      00007FF9078553D0
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
       mov       rax,7FF8A7E18420
       mov       [rbp-78],rax
       lea       rax,[M03_L03]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FF9077323D0
       call      rax
M03_L03:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FF907B64A90],0
       je        short M03_L04
       call      qword ptr [7FF907B52648]; CORINFO_HELP_STOP_FOR_GC
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
       call      00007FF90786BEF0
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
       call      qword ptr [7FF8A82CC768]; System.RuntimeTypeHandle.GetGCHandle(System.Runtime.InteropServices.GCHandleType)
       mov       rdx,rax
       lea       rcx,[rbx+10]
       xor       eax,eax
       lock cmpxchg [rcx],rdx
       test      rax,rax
       je        near ptr M03_L00
       lea       rcx,[rbp-40]
       call      qword ptr [7FF8A82C5CE0]
       jmp       near ptr M03_L00
M03_L09:
       call      qword ptr [7FF8A7C26328]; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M03_L10:
       mov       [rbp+10],rbx
       mov       rcx,rbx
       call      qword ptr [7FF8A7DF5710]; System.RuntimeTypeHandle.<GetModule>g__GetModuleWorker|48_0(System.RuntimeType)
       mov       r14,rax
       mov       rbx,[rbp+10]
       jmp       near ptr M03_L02
M03_L11:
       mov       rdx,rax
       call      qword ptr [7FF8A7C26328]; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
; Total bytes of code 568
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
       jmp       qword ptr [7FF8A7DF6EC8]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
M04_L00:
       call      qword ptr [7FF8A824F690]
       int       3
M04_L01:
       mov       rcx,rax
       mov       rdx,r8
       add       rsp,28
       jmp       near ptr 00007FF9078A3EE0
M04_L02:
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
       call      qword ptr [7FF8A81A6448]
       int       3
M05_L02:
       mov       rdx,[rcx+18]
       mov       rax,[rdx+18]
       test      rax,rax
       je        short M05_L03
       mov       rcx,rax
       jmp       short M05_L04
M05_L03:
       mov       rdx,7FF8A82E7428
       call      qword ptr [7FF8A7C2F630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FF8A82E7428
       call      qword ptr [7FF8A7C2F630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       call      qword ptr [7FF8A7C257A0]; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rsi
       mov       rdx,rbp
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       near ptr M05_L00
; Total bytes of code 214
```
```assembly
; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,50
       lea       rbp,[rsp+30]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rbp+8],xmm4
       xor       eax,eax
       mov       [rbp+18],rax
       mov       rax,9264C701C130
       mov       [rbp],rax
       mov       rsi,rcx
       mov       rbx,rdx
       mov       edi,r8d
       mov       r14d,r9d
       test      rbx,rbx
       je        near ptr M06_L06
       cmp       dword ptr [rbx+8],0
       je        near ptr M06_L06
       cmp       r14d,1
       jne       short M06_L00
       movzx     r15d,word ptr [rbx+0C]
       cmp       r15d,2E
       jne       short M06_L01
       mov       rcx,7FF8A83E82E0
       call      CORINFO_HELP_COUNTPROFILE32
M06_L00:
       mov       rcx,2576B800108
       mov       r15,[rcx]
       mov       rcx,r15
       mov       rdx,7FF8A83E82E8
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rcx,r15
       mov       rdx,rbx
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+18]
       mov       r15d,eax
       cmp       r15d,400
       jbe       short M06_L02
       movsxd    rdx,r15d
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       r13,[rax+10]
       mov       r15d,[rax+8]
       jmp       short M06_L04
M06_L01:
       cmp       r15d,2A
       jne       near ptr M06_L05
       mov       rcx,7FF8A83E82DC
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M06_L00
M06_L02:
       mov       rcx,7FF8A83E83F0
       call      CORINFO_HELP_COUNTPROFILE32
       mov       edx,r15d
       mov       r13,rdx
       test      r13,r13
       je        short M06_L04
       mov       rcx,r13
       add       rcx,0F
       and       rcx,0FFFFFFFFFFFFFFF0
       add       rsp,30
       neg       rcx
       add       rcx,rsp
       jb        short M06_L03
       xor       ecx,ecx
M06_L03:
       test      [rsp],esp
       sub       rsp,1000
       cmp       rsp,rcx
       jae       short M06_L03
       mov       rsp,rcx
       test      [rsp],esp
       sub       rsp,30
       lea       r13,[rsp+30]
M06_L04:
       mov       rcx,7FF8A83E83F4
       call      CORINFO_HELP_COUNTPROFILE32
       mov       [rbp+8],r13
       mov       [rbp+10],r15d
       mov       [rsp+20],r14d
       lea       r8,[rbp+8]
       mov       rdx,rbx
       mov       rcx,rsi
       mov       r9d,edi
       call      qword ptr [7FF8A7DF6928]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].GetListByName(System.String, System.Span`1<Byte>, MemberListType, CacheType)
       mov       [rbp+18],rax
       jmp       short M06_L07
M06_L05:
       mov       rcx,7FF8A83E82D8
       call      CORINFO_HELP_COUNTPROFILE32
M06_L06:
       xor       r8d,r8d
       mov       [rbp+8],r8
       mov       [rbp+10],r8d
       mov       [rsp+20],r14d
       lea       r8,[rbp+8]
       mov       rcx,rsi
       mov       r9d,edi
       mov       rdx,29800810008
       call      qword ptr [7FF8A7DF6928]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].GetListByName(System.String, System.Span`1<Byte>, MemberListType, CacheType)
       mov       [rbp+18],rax
M06_L07:
       mov       rcx,7FF8A83E83F8
       call      CORINFO_HELP_COUNTPROFILE32
       lea       rdx,[rbp+18]
       mov       rcx,rsi
       mov       r8,rbx
       mov       r9d,edi
       call      qword ptr [7FF8A7DF6B50]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Insert(System.__Canon[] ByRef, System.String, MemberListType)
       mov       rax,[rbp+18]
       mov       r8,9264C701C130
       cmp       [rbp],r8
       je        short M06_L08
       call      CORINFO_HELP_FAIL_FAST
M06_L08:
       nop
       lea       rsp,[rbp+20]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 495
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

