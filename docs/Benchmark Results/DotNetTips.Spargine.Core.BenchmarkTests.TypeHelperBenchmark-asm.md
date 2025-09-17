## .NET 10.0.0 (10.0.25.45207), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark.CreateWithParameters()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,offset MT_System.Object[]
       mov       edx,2
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rcx,22208F50090
       mov       [rax+10],rcx
       mov       rcx,22208F500B8
       mov       [rax+18],rcx
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       rcx,22208F50128
       mov       r9,rax
       mov       edx,214
       xor       r8d,r8d
       call      qword ptr [7FFE77874E58]; System.RuntimeType.CreateInstanceImpl(System.Reflection.BindingFlags, System.Reflection.Binder, System.Object[], System.Globalization.CultureInfo)
       test      rax,rax
       je        short M00_L01
       mov       rcx,rax
       mov       r8,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person
       cmp       [rcx],r8
       jne       short M00_L00
       mov       [rsp+28],rcx
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       edx,edx
       mov       [rbx+8],rdx
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L00:
       mov       rdx,rax
       mov       rcx,r8
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M00_L01:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,24A1
       mov       rdx,7FFE77625418
       call      qword ptr [7FFE775076F0]
       mov       rsi,rax
       mov       rcx,22208F50128
       call      qword ptr [7FFE771CA310]; Precode of System.RuntimeType.get_FullName()
       mov       rdi,rax
       mov       ecx,1C19
       mov       rdx,7FFE77625418
       call      qword ptr [7FFE775076F0]
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FFE772877F8]; System.String.Concat(System.String, System.String, System.String)
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE776E5A88]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 289
```
```assembly
; System.RuntimeType.CreateInstanceImpl(System.Reflection.BindingFlags, System.Reflection.Binder, System.Object[], System.Globalization.CultureInfo)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0F8
       vzeroupper
       lea       rbp,[rsp+130]
       xor       eax,eax
       mov       [rbp-88],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-80],ymm4
       vmovdqu   ymmword ptr [rbp-60],ymm4
       mov       [rbp+10],rcx
       mov       [rbp+20],r8
       mov       [rbp+28],r9
       mov       ebx,edx
       cmp       [rcx],cl
       mov       r14,rcx
M01_L00:
       mov       rax,offset MT_System.RuntimeType
       cmp       [r14],rax
       jne       near ptr M01_L56
       mov       [rbp-0B8],r14
       mov       rax,[r14+18]
       mov       rcx,rax
       mov       rax,7FFED6E9E4E0
       call      rax
       movzx     esi,al
       mov       r14,[rbp-0B8]
       cmp       dword ptr [7FFED71EE808],0
       jne       near ptr M01_L54
M01_L01:
       cmp       esi,1D
       ja        short M01_L02
       mov       ecx,1FEF7FFF
       bt        ecx,esi
       jae       near ptr M01_L55
M01_L02:
       cmp       esi,10
       sete      dil
       movzx     edi,dil
M01_L03:
       test      edi,edi
       jne       near ptr M01_L53
       mov       rcx,offset MT_System.RuntimeType
       cmp       [r14],rcx
       jne       near ptr M01_L57
M01_L04:
       test      r14,r14
       je        near ptr M01_L58
       mov       rcx,r14
       call      00007FFED6EA1090
       test      eax,eax
       jne       near ptr M01_L59
       mov       rcx,[rbp+10]
       mov       rdi,rcx
M01_L05:
       mov       rax,offset MT_System.RuntimeType
       cmp       [rdi],rax
       jne       near ptr M01_L63
       mov       [rbp-0C0],rdi
       mov       rax,[rdi+18]
       mov       rcx,rax
       mov       rax,7FFED6E9E4E0
       call      rax
       movzx     esi,al
       mov       rdi,[rbp-0C0]
       cmp       dword ptr [7FFED71EE808],0
       jne       near ptr M01_L61
M01_L06:
       cmp       esi,1D
       ja        short M01_L07
       mov       ecx,1FEF7FFF
       bt        ecx,esi
       jae       near ptr M01_L62
M01_L07:
       cmp       esi,10
       sete      r14b
       movzx     r14d,r14b
M01_L08:
       test      r14d,r14d
       jne       near ptr M01_L60
       mov       rax,22208F41418
       cmp       rdi,rax
       je        near ptr M01_L64
       mov       rax,22208F41440
       cmp       rdi,rax
       je        near ptr M01_L65
       mov       rax,1E174001A68
       cmp       qword ptr [rbp+28],0
       mov       rax,[rax]
       cmovne    rax,[rbp+28]
       mov       [rbp+28],rax
       mov       rsi,[rbp+20]
       test      rsi,rsi
       jne       short M01_L09
       call      qword ptr [7FFE77874E88]; System.Type.get_DefaultBinder()
       mov       rsi,rax
M01_L09:
       test      bl,20
       sete      dil
       movzx     edi,dil
       test      ebx,2000000
       sete      r14b
       movzx     r14d,r14b
       mov       [rbp-3C],r14d
       mov       rcx,[rbp+28]
       cmp       dword ptr [rcx+8],0
       je        near ptr M01_L66
M01_L10:
       mov       rcx,[rbp+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L11
       mov       rax,[rcx+10]
       mov       rdi,[rax]
       test      rdi,rdi
       jne       near ptr M01_L30
M01_L11:
       call      qword ptr [7FFE77287C00]; System.RuntimeType.InitializeCache()
       mov       r15,rax
M01_L12:
       cmp       [r15],r15b
       lea       rdi,[r15+48]
       mov       rax,[rdi]
       test      rax,rax
       je        near ptr M01_L68
M01_L13:
       cmp       byte ptr [rax+18],0
       je        near ptr M01_L69
       mov       rdi,[rax+8]
M01_L14:
       mov       r15d,[rdi+8]
       mov       edx,r15d
       xor       eax,eax
       mov       [rbp-70],rax
       mov       [rbp-68],rax
       mov       [rbp-60],eax
       mov       [rbp-5C],edx
       mov       r13d,10
       inc       r15d
M01_L15:
       dec       r15d
       jne       near ptr M01_L31
       mov       rdi,[rbp-70]
       mov       r15,[rbp-68]
       mov       r13d,[rbp-60]
       movsxd    rdx,r13d
       mov       rcx,offset MT_System.Reflection.MethodBase[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r12,rax
       xor       eax,eax
       mov       [rbp-40],eax
       mov       rdx,[rbp+28]
       cmp       dword ptr [rdx+8],0
       je        near ptr M01_L37
       mov       rdx,[rbp+28]
       mov       edx,[rdx+8]
       mov       rcx,offset MT_System.Type[]
       call      CORINFO_HELP_NEWARR_1_PTR
M01_L16:
       mov       [rbp-0B0],rax
       xor       edx,edx
       mov       rcx,[rbp+28]
       cmp       dword ptr [rcx+8],0
       jle       short M01_L19
M01_L17:
       mov       rcx,[rbp+28]
       cmp       edx,[rcx+8]
       jae       near ptr M01_L99
       mov       rcx,[rbp+28]
       mov       [rbp-98],rdx
       mov       rcx,[rcx+rdx*8+10]
       test      rcx,rcx
       je        short M01_L18
       call      qword ptr [7FFE7728C960]; System.Object.GetType()
       mov       r8,rax
       mov       rdx,[rbp-98]
       mov       rcx,[rbp-0B0]
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
M01_L18:
       mov       rdx,[rbp-98]
       inc       edx
       mov       rcx,rdx
       mov       rdx,[rbp+28]
       cmp       [rdx+8],ecx
       mov       rdx,rcx
       jg        short M01_L17
M01_L19:
       xor       edx,edx
       cmp       edx,r13d
       jge       near ptr M01_L28
M01_L20:
       test      rdi,rdi
       je        near ptr M01_L38
       cmp       edx,[rdi+8]
       jae       near ptr M01_L99
       mov       [rbp-0A0],rdx
       mov       r8,[rdi+rdx*8+10]
M01_L21:
       mov       r10,r8
       test      r10,r10
       je        short M01_L22
       mov       rcx,offset MT_System.Reflection.RuntimeConstructorInfo
       cmp       [r10],rcx
       jne       near ptr M01_L72
M01_L22:
       mov       r8,r10
       mov       [rbp-0C8],r8
       mov       ecx,[r8+5C]
       mov       r10d,ebx
       xor       r10d,2
       mov       [rbp-78],r10d
       mov       r9d,r10d
       and       r9d,ecx
       cmp       r9d,ecx
       jne       near ptr M01_L27
       mov       r9,[r8+20]
       test      r9,r9
       je        near ptr M01_L73
M01_L23:
       test      r9,r9
       je        near ptr M01_L39
       lea       r11,[r9+10]
       mov       r9d,[r9+8]
M01_L24:
       mov       [rbp-0E8],r11
       mov       rcx,r11
       mov       [rbp-0E0],rcx
       mov       r14d,r9d
       mov       rax,[rbp-0B0]
       cmp       [rax+8],r14d
       je        near ptr M01_L41
       mov       r10d,[rbp-78]
       test      r10d,3300
       je        near ptr M01_L75
       mov       [rbp-8C],r9d
       cmp       [rax+8],r9d
       jle       near ptr M01_L76
       mov       r10,[r8+40]
       test      r10,r10
       je        near ptr M01_L40
M01_L25:
       test      byte ptr [r10+34],2
       jne       near ptr M01_L42
M01_L26:
       mov       r9d,[rbp-8C]
       test      r9d,r9d
       jne       near ptr M01_L77
       mov       r14d,[rbp-3C]
M01_L27:
       mov       rdx,[rbp-0A0]
       inc       edx
       cmp       edx,r13d
       jl        near ptr M01_L20
M01_L28:
       mov       edi,[rbp-40]
       test      edi,edi
       je        near ptr M01_L85
       cmp       [r12+8],edi
       je        near ptr M01_L45
       test      edi,edi
       jl        near ptr M01_L87
       movsxd    rdx,edi
       mov       rcx,offset MT_System.Reflection.MethodBase[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r15,rax
       lea       rcx,[r15+10]
       lea       rdx,[r12+10]
       mov       r8d,[r12+8]
       cmp       edi,r8d
       cmovle    r8d,edi
       shl       r8,3
       cmp       r8,4000
       ja        near ptr M01_L89
       call      00007FFED6E70160
       cmp       dword ptr [7FFED71EE808],0
       jne       near ptr M01_L88
M01_L29:
       mov       r12,r15
       jmp       near ptr M01_L45
M01_L30:
       mov       r15,rdi
       jmp       near ptr M01_L12
M01_L31:
       mov       r12,[rdi+r13]
       mov       edx,[r12+5C]
       mov       eax,ebx
       xor       eax,2
       and       eax,edx
       cmp       eax,edx
       jne       short M01_L35
       cmp       dword ptr [rbp-60],0
       je        short M01_L36
       cmp       dword ptr [rbp-60],1
       jne       near ptr M01_L71
       cmp       dword ptr [rbp-5C],2
       jl        near ptr M01_L70
M01_L32:
       movsxd    rdx,dword ptr [rbp-5C]
       mov       rcx,offset MT_System.Reflection.ConstructorInfo[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       [rbp-70],rax
       mov       rcx,[rbp-70]
       mov       r8,[rbp-68]
       xor       edx,edx
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
M01_L33:
       movsxd    rdx,dword ptr [rbp-60]
       mov       rcx,[rbp-70]
       mov       r8,r12
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
M01_L34:
       mov       edx,[rbp-60]
       inc       edx
       mov       [rbp-60],edx
M01_L35:
       add       r13,8
       jmp       near ptr M01_L15
M01_L36:
       mov       [rbp-68],r12
       jmp       short M01_L34
M01_L37:
       mov       rcx,1E1740001E0
       mov       rcx,[rcx]
       mov       rdx,rcx
       mov       rax,rdx
       jmp       near ptr M01_L16
M01_L38:
       mov       r8,r15
       mov       [rbp-0A0],rdx
       jmp       near ptr M01_L21
M01_L39:
       xor       r11d,r11d
       xor       r9d,r9d
       jmp       near ptr M01_L24
M01_L40:
       mov       rcx,r8
       call      qword ptr [7FFE77874F90]; System.Reflection.RuntimeConstructorInfo.<get_Signature>g__LazyCreateSignature|21_0()
       mov       r10,rax
       jmp       near ptr M01_L25
M01_L41:
       mov       r10d,[rbp-78]
       test      r10d,10000
       jne       near ptr M01_L78
M01_L42:
       mov       r14d,[rbp-40]
       lea       ecx,[r14+1]
       mov       [rbp-40],ecx
       test      rdi,rdi
       je        short M01_L44
       mov       rdx,[rbp-0A0]
       cmp       edx,[rdi+8]
       jae       near ptr M01_L99
       mov       [rbp-0A0],rdx
       mov       r8,[rdi+rdx*8+10]
M01_L43:
       movsxd    rdx,r14d
       mov       rcx,r12
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       r14d,[rbp-3C]
       jmp       near ptr M01_L27
M01_L44:
       mov       r8,r15
       jmp       short M01_L43
M01_L45:
       xor       r9d,r9d
       mov       [rsp+20],r9
       mov       rdi,[rbp+30]
       mov       [rsp+28],rdi
       mov       [rsp+30],r9
       lea       r9,[rbp-48]
       mov       [rsp+38],r9
       lea       r9,[rbp+28]
       mov       rcx,rsi
       mov       edx,ebx
       mov       r8,r12
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       r15,rax
       test      r15,r15
       je        near ptr M01_L90
       mov       rcx,offset MT_System.Reflection.RuntimeConstructorInfo
       cmp       [r15],rcx
       jne       near ptr M01_L93
       mov       rax,[r15+20]
       test      rax,rax
       je        near ptr M01_L91
M01_L46:
       test      rax,rax
       je        short M01_L52
       mov       edx,[rax+8]
M01_L47:
       mov       [rbp-50],edx
M01_L48:
       cmp       dword ptr [rbp-50],0
       je        near ptr M01_L94
       mov       rcx,r15
       test      rcx,rcx
       je        short M01_L49
       mov       rdx,offset MT_System.Reflection.RuntimeConstructorInfo
       cmp       [rcx],rdx
       jne       near ptr M01_L96
M01_L49:
       mov       rdx,offset MT_System.Reflection.RuntimeConstructorInfo
       cmp       [rcx],rdx
       jne       near ptr M01_L97
       mov       [rsp+20],rdi
       mov       edx,ebx
       mov       r8,rsi
       mov       r9,[rbp+28]
       call      qword ptr [7FFE77407138]; System.Reflection.RuntimeConstructorInfo.Invoke(System.Reflection.BindingFlags, System.Reflection.Binder, System.Object[], System.Globalization.CultureInfo)
       mov       rdi,rax
M01_L50:
       cmp       qword ptr [rbp-48],0
       jne       near ptr M01_L98
M01_L51:
       mov       rax,rdi
       add       rsp,0F8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L52:
       xor       edx,edx
       jmp       short M01_L47
M01_L53:
       mov       rcx,r14
       mov       rax,[r14]
       mov       rax,[rax+68]
       call      qword ptr [rax+8]
       mov       r14,rax
       jmp       near ptr M01_L00
M01_L54:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M01_L01
M01_L55:
       mov       edi,1
       jmp       near ptr M01_L03
M01_L56:
       mov       rcx,r14
       mov       rax,[r14]
       mov       rax,[rax+68]
       call      qword ptr [rax]
       mov       edi,eax
       jmp       near ptr M01_L03
M01_L57:
       mov       rcx,r14
       mov       rax,[r14]
       mov       rax,[rax+98]
       call      qword ptr [rax+8]
       mov       r14,rax
       jmp       near ptr M01_L04
M01_L58:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE77A46B68]
       mov       r8,rax
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFE77A46B80]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L59:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE77A46C40]
       mov       rcx,rax
       mov       rdx,[rbp+10]
       call      qword ptr [7FFE77A46C58]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE7750FC90]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L60:
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+68]
       call      qword ptr [rax+8]
       mov       rdi,rax
       jmp       near ptr M01_L05
M01_L61:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M01_L06
M01_L62:
       mov       r14d,1
       jmp       near ptr M01_L08
M01_L63:
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+68]
       call      qword ptr [rax]
       mov       r14d,eax
       jmp       near ptr M01_L08
M01_L64:
       mov       rcx,offset MT_System.NotSupportedException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE77A46C70]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE77507708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L65:
       mov       rcx,offset MT_System.NotSupportedException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE77A46C88]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE77507708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L66:
       test      bl,10
       je        near ptr M01_L10
       test      bl,4
       je        near ptr M01_L10
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE77874F30]; System.RuntimeType.IsGenericCOMObjectImpl()
       test      eax,eax
       jne       short M01_L67
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE771CA438]; System.RuntimeType.IsValueTypeImpl()
       test      eax,eax
       je        near ptr M01_L10
M01_L67:
       mov       rcx,[rbp+10]
       mov       edx,edi
       mov       r8d,r14d
       call      qword ptr [7FFE7728ED30]; System.RuntimeType.CreateInstanceDefaultCtor(Boolean, Boolean)
       mov       rdi,rax
       jmp       near ptr M01_L51
M01_L68:
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache+MemberInfoCache<System.Reflection.RuntimeConstructorInfo>
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       lea       rcx,[r13+10]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       rdx,r13
       xor       r8d,r8d
       call      00007FFED6E8EEF0
       test      rax,rax
       cmove     rax,r13
       jmp       near ptr M01_L13
M01_L69:
       mov       rcx,rax
       xor       edx,edx
       xor       r8d,r8d
       mov       r9d,1
       call      qword ptr [7FFE7728D278]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
       mov       rdi,rax
       jmp       near ptr M01_L14
M01_L70:
       mov       dword ptr [rbp-5C],4
       jmp       near ptr M01_L32
M01_L71:
       mov       edx,[rbp-5C]
       cmp       edx,[rbp-60]
       jne       near ptr M01_L33
       mov       eax,[rbp-5C]
       add       eax,eax
       mov       [rbp-74],eax
       lea       rdx,[rbp-70]
       mov       r8d,eax
       mov       rcx,7FFE778851D0
       call      qword ptr [7FFE7728D488]; System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
       mov       edx,[rbp-74]
       mov       [rbp-5C],edx
       jmp       near ptr M01_L33
M01_L72:
       mov       rdx,r8
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M01_L73:
       mov       rcx,[r8+40]
       mov       r9,rcx
       test      r9,r9
       mov       [rbp-0D0],r9
       jne       short M01_L74
       mov       rcx,r8
       call      qword ptr [7FFE77874F90]; System.Reflection.RuntimeConstructorInfo.<get_Signature>g__LazyCreateSignature|21_0()
       mov       [rbp-0D0],rax
       mov       r8,[rbp-0C8]
M01_L74:
       xor       ecx,ecx
       mov       [rsp+20],ecx
       lea       r9,[rbp-80]
       mov       rcx,r8
       mov       rdx,r8
       mov       r8,[rbp-0D0]
       call      qword ptr [7FFE7728FE10]; System.Reflection.RuntimeParameterInfo.GetParameters(System.IRuntimeMethodInfo, System.Reflection.MemberInfo, System.Signature, System.Reflection.ParameterInfo ByRef, Boolean)
       mov       r9,rax
       mov       [rbp-0D8],r9
       xor       ecx,ecx
       mov       [rbp-80],rcx
       mov       rax,[rbp-0C8]
       lea       rcx,[rax+20]
       mov       rdx,r9
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,[rbp-0D8]
       mov       r8,[rbp-0C8]
       jmp       near ptr M01_L23
M01_L75:
       mov       r14d,[rbp-3C]
       jmp       near ptr M01_L27
M01_L76:
       test      r10d,40000
       je        near ptr M01_L26
       mov       rax,[rbp-0B0]
       mov       ecx,[rax+8]
       cmp       ecx,[rbp-8C]
       jae       near ptr M01_L99
       mov       r11,[rbp-0E8]
       mov       rcx,[r11+rcx*8]
       mov       r8,[rcx]
       mov       r8,[r8+40]
       call      qword ptr [r8+20]
       test      al,10
       jne       near ptr M01_L42
       jmp       near ptr M01_L26
M01_L77:
       lea       ecx,[r9-1]
       mov       rax,[rbp-0B0]
       cmp       [rax+8],ecx
       jl        near ptr M01_L81
       lea       ecx,[r9-1]
       cmp       ecx,r9d
       jae       near ptr M01_L99
       mov       r11,[rbp-0E8]
       mov       r14,[r11+rcx*8]
       mov       rcx,r14
       mov       r8,[r14]
       mov       r8,[r8+40]
       call      qword ptr [r8+38]
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+58]
       call      qword ptr [rax+10]
       test      eax,eax
       je        short M01_L80
       mov       rcx,r14
       mov       rdx,22208F50168
       xor       r8d,r8d
       mov       rax,[r14]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
       test      eax,eax
       jne       near ptr M01_L42
       mov       r14d,[rbp-3C]
       jmp       near ptr M01_L27
M01_L78:
       test      r10d,100
       jne       short M01_L79
       xor       r8d,r8d
       jmp       short M01_L84
M01_L79:
       jmp       near ptr M01_L42
M01_L80:
       mov       r14d,[rbp-3C]
       jmp       near ptr M01_L27
M01_L81:
       mov       r14d,[rbp-3C]
       jmp       near ptr M01_L27
M01_L82:
       cmp       r8d,[rax+8]
       jae       near ptr M01_L99
       mov       r10,[rax+r8*8+10]
       test      r10,r10
       je        short M01_L83
       cmp       r8d,r14d
       jae       near ptr M01_L99
       mov       [rbp-0A8],r8
       mov       rdx,[rcx+r8*8]
       mov       rcx,r10
       call      qword ptr [7FFE77877FA8]; System.Reflection.SignatureTypeExtensions.MatchesParameterTypeExactly(System.Type, System.Reflection.ParameterInfo)
       test      eax,eax
       mov       rcx,[rbp-0E0]
       mov       r8,[rbp-0A8]
       je        short M01_L86
M01_L83:
       inc       r8d
       mov       rax,[rbp-0B0]
M01_L84:
       cmp       r8d,r14d
       jl        short M01_L82
       jmp       near ptr M01_L42
M01_L85:
       call      qword ptr [7FFE77A46EE0]
       mov       rbx,rax
       mov       rcx,offset MT_System.MissingMethodException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE771CA310]; Precode of System.RuntimeType.get_FullName()
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE77A46C58]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE77A46EF8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M01_L86:
       mov       r14d,[rbp-3C]
       jmp       near ptr M01_L27
M01_L87:
       mov       ecx,45
       mov       edx,0D
       call      qword ptr [7FFE778F55A8]
       int       3
M01_L88:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M01_L29
M01_L89:
       call      qword ptr [7FFE778FDC68]
       jmp       near ptr M01_L29
M01_L90:
       call      qword ptr [7FFE77A46EE0]
       mov       rbx,rax
       mov       rcx,offset MT_System.MissingMethodException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE771CA310]; Precode of System.RuntimeType.get_FullName()
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE77A46C58]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE77A46EF8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M01_L91:
       mov       r8,[r15+40]
       test      r8,r8
       jne       short M01_L92
       mov       rcx,r15
       call      qword ptr [7FFE77874F90]; System.Reflection.RuntimeConstructorInfo.<get_Signature>g__LazyCreateSignature|21_0()
       mov       r8,rax
M01_L92:
       xor       r9d,r9d
       mov       [rsp+20],r9d
       lea       r9,[rbp-88]
       mov       rcx,r15
       mov       rdx,r15
       call      qword ptr [7FFE7728FE10]; System.Reflection.RuntimeParameterInfo.GetParameters(System.IRuntimeMethodInfo, System.Reflection.MemberInfo, System.Signature, System.Reflection.ParameterInfo ByRef, Boolean)
       mov       r13,rax
       xor       ecx,ecx
       mov       [rbp-88],rcx
       lea       rcx,[r15+20]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,r13
       jmp       near ptr M01_L46
M01_L93:
       lea       rdx,[rbp-58]
       mov       rcx,r15
       mov       rax,[r15]
       mov       rax,[rax+50]
       call      qword ptr [rax+10]
       jmp       near ptr M01_L48
M01_L94:
       mov       rcx,[rbp+28]
       cmp       dword ptr [rcx+8],0
       je        short M01_L95
       mov       rcx,offset MT_System.NotSupportedException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE77A46F10]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE77507708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L95:
       mov       rcx,[rbp+10]
       mov       r8d,r14d
       mov       edx,1
       call      qword ptr [7FFE77875068]; System.Activator.CreateInstance(System.Type, Boolean, Boolean)
       mov       rdi,rax
       jmp       near ptr M01_L51
M01_L96:
       mov       rdx,r15
       mov       rcx,offset MT_System.Reflection.ConstructorInfo
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       rcx,rax
       jmp       near ptr M01_L49
M01_L97:
       mov       [rsp+20],rdi
       mov       edx,ebx
       mov       r8,rsi
       mov       r9,[rbp+28]
       mov       rax,[rcx]
       mov       rax,[rax+60]
       call      qword ptr [rax+28]
       mov       rdi,rax
       jmp       near ptr M01_L50
M01_L98:
       lea       rdx,[rbp+28]
       mov       rcx,rsi
       mov       r8,[rbp-48]
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       jmp       near ptr M01_L51
M01_L99:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       sub       rsp,48
       vzeroupper
       mov       r15,rcx
       call      qword ptr [7FFE77A46EE0]
       mov       rdi,rax
       mov       rcx,offset MT_System.MissingMethodException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE771CA310]; Precode of System.RuntimeType.get_FullName()
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFE77A46C58]
       mov       rdx,rax
       mov       rcx,rbx
       mov       r8,r15
       call      qword ptr [7FFE77A46F28]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 3210
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       test      rdx,rdx
       je        short M02_L01
       cmp       [rdx],rcx
       je        short M02_L01
       mov       rax,[rdx]
M02_L00:
       mov       rax,[rax+10]
       cmp       rax,rcx
       jne       short M02_L02
M02_L01:
       mov       rax,rdx
       ret
M02_L02:
       test      rax,rax
       je        short M02_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M02_L01
       test      rax,rax
       je        short M02_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M02_L01
       test      rax,rax
       je        short M02_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M02_L01
       test      rax,rax
       jne       short M02_L00
M02_L03:
       jmp       qword ptr [7FFE77A46670]
; Total bytes of code 79
```
```assembly
; System.String.Concat(System.String, System.String, System.String)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       test      rbx,rbx
       je        near ptr M03_L00
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        near ptr M03_L00
       test      rsi,rsi
       je        near ptr M03_L01
       mov       r14d,[rsi+8]
       test      r14d,r14d
       je        near ptr M03_L01
       test      rdi,rdi
       je        near ptr M03_L02
       mov       r15d,[rdi+8]
       test      r15d,r15d
       je        near ptr M03_L02
       mov       r13d,ebp
       mov       edx,r14d
       add       rdx,r13
       mov       ecx,r15d
       add       rdx,rcx
       cmp       rdx,7FFFFFFF
       jg        near ptr M03_L03
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFED6EDF840
       mov       r12,rax
       cmp       [r12],r12b
       lea       rax,[r12+0C]
       mov       [rsp+20],rax
       mov       rcx,rax
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFE77285818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rbx,[rsp+20]
       lea       rcx,[rbx+r13*2]
       mov       r8d,r14d
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFE77285818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       ebp,r14d
       movsxd    rcx,ebp
       lea       rcx,[rbx+rcx*2]
       mov       r8d,r15d
       add       r8,r8
       lea       rdx,[rdi+0C]
       call      qword ptr [7FFE77285818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r12
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
M03_L00:
       mov       rcx,rsi
       mov       rdx,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FFE77287810]; System.String.Concat(System.String, System.String)
M03_L01:
       mov       rcx,rbx
       mov       rdx,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FFE77287810]; System.String.Concat(System.String, System.String)
M03_L02:
       mov       rcx,rbx
       mov       rdx,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FFE77287810]; System.String.Concat(System.String, System.String)
M03_L03:
       call      qword ptr [7FFE77A45E60]
       int       3
; Total bytes of code 333
```

## .NET 10.0.0 (10.0.25.45207), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark.GetAttributeFieldInfo()
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
       mov       rcx,21081F60090
       mov       rdx,21081F600B8
       mov       r8d,1C
       call      qword ptr [7FFE771EA490]; System.RuntimeType.GetField(System.String, System.Reflection.BindingFlags)
       mov       rbx,rax
       test      rbx,rbx
       je        near ptr M00_L17
       mov       rcx,offset MT_System.Reflection.RtFieldInfo
       cmp       [rbx],rcx
       jne       near ptr M00_L26
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-50],xmm0
       vmovdqu   xmmword ptr [rbp-48],xmm0
       mov       rcx,211000001C8
       mov       rsi,[rcx]
       cmp       qword ptr [rsi+8],0
       je        near ptr M00_L06
       mov       rdi,[rsi+10]
       xor       r14d,r14d
       mov       r15,[rsi+18]
       mov       rcx,offset MT_System.Collections.Generic.ObjectEqualityComparer<System.RuntimeType>
       cmp       [r15],rcx
       jne       near ptr M00_L20
       mov       rcx,21081F60110
       mov       [rbp-58],rcx
       xor       ecx,ecx
       mov       [rbp-60],rcx
       lea       rcx,[rbp-58]
       cmp       qword ptr [rbp-60],0
       jne       short M00_L00
       mov       rcx,[rbp-58]
       mov       [rbp-60],rcx
       lea       rcx,[rbp-60]
       cmp       qword ptr [rbp-60],0
       je        near ptr M00_L18
M00_L00:
       mov       r13,[rcx]
       mov       rcx,offset MT_System.RuntimeType
       cmp       [r13],rcx
       jne       near ptr M00_L19
       mov       rcx,r13
       call      00007FFED6E834A0
       test      eax,eax
       je        near ptr M00_L10
M00_L01:
       mov       r13d,eax
M00_L02:
       xor       ecx,ecx
       mov       [rbp-60],rcx
M00_L03:
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
       jae       near ptr M00_L35
       mov       ecx,ecx
       lea       rdx,[rdx+rcx*4+10]
       mov       eax,[rdx]
       dec       eax
       js        short M00_L06
M00_L04:
       mov       esi,[rdi+8]
       cmp       eax,esi
       jae       near ptr M00_L35
       mov       edx,eax
       shl       rdx,4
       lea       r12,[rdi+rdx+10]
       cmp       [r12+8],r13d
       je        near ptr M00_L21
M00_L05:
       mov       eax,[r12+0C]
       inc       r14d
       cmp       esi,r14d
       jb        near ptr M00_L22
       test      eax,eax
       jge       short M00_L04
M00_L06:
       mov       rcx,[rbx+38]
       call      CORINFO_HELP_GETDYNAMIC_GCSTATIC_BASE_NOCTOR
       mov       rcx,[rax+20]
       add       rcx,10
       mov       rsi,[rcx]
       test      rsi,rsi
       je        near ptr M00_L23
M00_L07:
       mov       rcx,rsi
       call      00007FFED6E34140
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M00_L24
M00_L08:
       mov       rcx,[rbx+38]
       call      00007FFED6ECD2E0
       mov       edx,eax
       mov       rcx,rdi
       mov       r8d,[rbp-40]
       mov       r9,21081F60110
       call      qword ptr [7FFE772AE940]; System.Reflection.CustomAttribute.GetCustomAttributes(System.Reflection.RuntimeModule, Int32, Int32, System.RuntimeType)
       mov       rbx,rax
       cmp       dword ptr [rbp-40],0
       jg        near ptr M00_L25
M00_L09:
       test      rbx,rbx
       jne       short M00_L11
       mov       ecx,11
       call      qword ptr [7FFE77527DB0]
       int       3
M00_L10:
       mov       rcx,r13
       call      qword ptr [7FFE772AE8F8]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       jmp       near ptr M00_L01
M00_L11:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<System.Object>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M00_L12
       lea       rdx,[rbp-68]
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax+20]
       jmp       short M00_L14
M00_L12:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.IList<System.Object>
       call      qword ptr [7FFE7744F558]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rsi,rax
       test      rsi,rsi
       je        near ptr M00_L30
       mov       rbx,[rsi]
       mov       rcx,offset MT_System.ObsoleteAttribute[]
       cmp       rbx,rcx
       jne       near ptr M00_L27
       mov       edi,[rsi+8]
       test      edi,edi
       jle       near ptr M00_L33
M00_L13:
       mov       dword ptr [rbp-68],1
       mov       rax,offset MT_System.ObsoleteAttribute[]
       cmp       rbx,rax
       jne       near ptr M00_L29
       cmp       dword ptr [rsi+8],0
       je        near ptr M00_L28
       mov       rax,[rsi+10]
M00_L14:
       test      rax,rax
       je        short M00_L15
       mov       rcx,offset MT_System.ObsoleteAttribute
       cmp       [rax],rcx
       jne       short M00_L15
       mov       [rbp-70],rax
       jmp       short M00_L16
M00_L15:
       xor       ecx,ecx
       mov       [rbp-70],rcx
M00_L16:
       mov       rcx,[rbp+10]
       mov       rbx,[rcx+18]
       mov       rdx,[rbp-70]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
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
M00_L17:
       call      qword ptr [7FFE7791DD88]
       mov       ecx,2595
       mov       rdx,7FFE77645418
       call      qword ptr [7FFE775276F0]
       mov       rbx,rax
       mov       ecx,1B55
       mov       rdx,7FFE77645418
       call      qword ptr [7FFE775276F0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE772A7810]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,110B
       mov       rdx,7FFE77645418
       call      qword ptr [7FFE775276F0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE772A7810]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE77A6C570]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE77A669A0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L18:
       xor       r13d,r13d
       jmp       near ptr M00_L02
M00_L19:
       mov       rcx,r13
       mov       rax,[r13]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
       mov       r13d,eax
       jmp       near ptr M00_L02
M00_L20:
       mov       rcx,r15
       mov       rdx,21081F60110
       mov       r11,7FFE771F0B20
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       near ptr M00_L03
M00_L21:
       mov       rdx,[r12]
       mov       rcx,r15
       mov       r8,21081F60110
       mov       r11,7FFE771F0B28
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M00_L05
       jmp       near ptr M00_L06
M00_L22:
       call      qword ptr [7FFE77527960]
       int       3
M00_L23:
       mov       rcx,rax
       call      qword ptr [7FFE772A5C80]; System.RuntimeTypeHandle.GetRuntimeTypeFromHandleSlow(IntPtr)
       mov       rsi,rax
       jmp       near ptr M00_L07
M00_L24:
       mov       rcx,rsi
       call      qword ptr [7FFE772A7C48]; System.RuntimeTypeHandle.<GetModule>g__GetModuleWorker|48_0(System.RuntimeType)
       mov       rdi,rax
       jmp       near ptr M00_L08
M00_L25:
       mov       r9d,[rbx+8]
       sub       r9d,[rbp-40]
       lea       rcx,[rbp-50]
       mov       r8,rbx
       mov       rdx,offset MT_System.RuntimeType+ListBuilder<System.Attribute>
       call      qword ptr [7FFE77A67300]
       jmp       near ptr M00_L09
M00_L26:
       mov       rcx,rbx
       mov       rdx,21081F60110
       xor       r8d,r8d
       mov       rax,[rbx]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       mov       rbx,rax
       jmp       near ptr M00_L09
M00_L27:
       mov       rcx,rsi
       mov       r11,7FFE771F0B58
       call      qword ptr [r11]
       mov       edi,eax
       test      edi,edi
       jle       near ptr M00_L33
       jmp       near ptr M00_L13
M00_L28:
       call      qword ptr [7FFE779AF2B8]
       int       3
M00_L29:
       mov       rcx,rsi
       mov       r11,7FFE771F0B60
       xor       edx,edx
       call      qword ptr [r11]
       jmp       near ptr M00_L14
M00_L30:
       mov       rcx,rbx
       mov       r11,7FFE771F0B38
       call      qword ptr [r11]
       mov       [rbp-78],rax
       mov       rcx,[rbp-78]
       mov       r11,7FFE771F0B40
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L31
       mov       dword ptr [rbp-68],1
       mov       rcx,[rbp-78]
       mov       r11,7FFE771F0B48
       call      qword ptr [r11]
       mov       [rbp-80],rax
       jmp       short M00_L32
M00_L31:
       mov       rcx,[rbp-78]
       mov       r11,7FFE771F0B50
       call      qword ptr [r11]
       jmp       short M00_L33
M00_L32:
       call      M00_L36
       jmp       short M00_L34
M00_L33:
       xor       ecx,ecx
       mov       [rbp-68],ecx
       xor       eax,eax
       jmp       near ptr M00_L14
M00_L34:
       mov       rax,[rbp-80]
       jmp       near ptr M00_L14
M00_L35:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L36:
       sub       rsp,28
       cmp       qword ptr [rbp-78],0
       je        short M00_L37
       mov       rcx,[rbp-78]
       mov       r11,7FFE771F0B50
       call      qword ptr [r11]
M00_L37:
       nop
       add       rsp,28
       ret
; Total bytes of code 1327
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
       mov       rsi,rcx
       mov       rdi,rdx
       mov       ebx,r8d
       test      rdi,rdi
       je        near ptr M01_L16
       test      bl,1
       jne       near ptr M01_L17
       mov       ebp,1
M01_L00:
       cmp       qword ptr [rsi+10],0
       je        short M01_L01
       mov       rcx,[rsi+10]
       mov       r14,[rcx]
       test      r14,r14
       jne       short M01_L04
M01_L01:
       mov       rcx,rsi
       call      qword ptr [7FFE772A7C00]; System.RuntimeType.InitializeCache()
       mov       rsi,rax
M01_L02:
       mov       r14d,ebp
       mov       r15,rdi
       cmp       [rsi],sil
       lea       r13,[rsi+50]
       mov       r12,[r13]
       test      r12,r12
       je        near ptr M01_L18
M01_L03:
       mov       rsi,r12
       cmp       [rsi],sil
       cmp       r14d,1
       jne       near ptr M01_L19
       mov       rbp,[rsi+20]
       test      rbp,rbp
       je        near ptr M01_L27
       test      r15,r15
       jne       short M01_L05
       movsx     rdx,byte ptr [0]
       mov       edx,[0]
       add       edx,edx
       movsx     rcx,byte ptr [0]
       xor       ecx,ecx
       mov       r8d,0D3DE343
       mov       r9d,0E34A4CEF
       call      qword ptr [7FFE777BC840]; System.Marvin.ComputeHash32(Byte ByRef, UInt32, UInt32, UInt32)
       jmp       short M01_L06
M01_L04:
       mov       rsi,r14
       jmp       short M01_L02
M01_L05:
       mov       rcx,r15
       call      qword ptr [7FFE772A66D0]; System.String.GetNonRandomizedHashCode()
M01_L06:
       mov       edx,eax
       not       eax
       test      edx,edx
       cmovl     edx,eax
       mov       r12,[rbp+8]
       mov       edi,[r12+8]
       mov       eax,edx
       cdq
       idiv      edi
       mov       r14d,edx
       cmp       r14d,edi
       jae       near ptr M01_L37
       mov       ecx,r14d
       mov       r13,[r12+rcx*8+10]
       test      r13,r13
       je        near ptr M01_L27
M01_L07:
       cmp       r13,r15
       jne       near ptr M01_L21
M01_L08:
       mov       rcx,[rbp+10]
       cmp       r14d,[rcx+8]
       jae       near ptr M01_L37
       mov       edx,r14d
       mov       rdi,[rcx+rdx*8+10]
M01_L09:
       test      rdi,rdi
       je        near ptr M01_L28
M01_L10:
       xor       esi,esi
       xor       ebx,2
       xor       ebp,ebp
       mov       r14d,[rdi+8]
       mov       r15d,10
       inc       r14d
       jmp       short M01_L14
M01_L11:
       mov       r13,[rdi+r15]
       mov       ecx,[r13+18]
       mov       eax,ebx
       and       eax,ecx
       cmp       eax,ecx
       jne       short M01_L13
       test      rsi,rsi
       jne       near ptr M01_L33
M01_L12:
       mov       rsi,r13
M01_L13:
       add       r15,8
M01_L14:
       dec       r14d
       jne       short M01_L11
       test      ebp,ebp
       jne       near ptr M01_L35
M01_L15:
       mov       rax,rsi
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
M01_L16:
       mov       ecx,3E7
       mov       rdx,7FFE771E4000
       call      qword ptr [7FFE775276F0]
       mov       rcx,rax
       call      qword ptr [7FFE77A653C8]
       int       3
M01_L17:
       mov       rcx,21100001F70
       mov       rcx,[rcx]
       mov       rdx,rdi
       call      qword ptr [7FFE77A66E20]
       mov       rdi,rax
       mov       ebp,2
       jmp       near ptr M01_L00
M01_L18:
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache+MemberInfoCache<System.Reflection.RuntimeFieldInfo>
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       lea       rcx,[r12+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r13
       mov       rdx,r12
       xor       r8d,r8d
       call      00007FFED6E8EEF0
       mov       rsi,rax
       test      rsi,rsi
       cmove     rsi,r12
       mov       r12,rsi
       jmp       near ptr M01_L03
M01_L19:
       cmp       ebp,2
       je        near ptr M01_L29
       cmp       byte ptr [r12+18],0
       je        near ptr M01_L32
       jmp       near ptr M01_L31
M01_L20:
       cmp       r14d,edi
       jae       near ptr M01_L37
       mov       ecx,r14d
       mov       r13,[r12+rcx*8+10]
       test      r13,r13
       je        short M01_L27
       jmp       near ptr M01_L07
M01_L21:
       test      r15,r15
       jne       short M01_L23
M01_L22:
       inc       r14d
       mov       edi,[r12+8]
       cmp       edi,r14d
       jg        short M01_L20
       jmp       short M01_L26
M01_L23:
       mov       ecx,[r13+8]
       cmp       ecx,[r15+8]
       jne       short M01_L22
       lea       rcx,[r13+0C]
       lea       rdx,[r15+0C]
       mov       r8d,[r13+8]
       add       r8d,r8d
       cmp       r8,0A
       jne       short M01_L24
       mov       rax,[rcx]
       mov       rcx,[rcx+2]
       mov       r8,[rdx]
       xor       r8,rax
       xor       rcx,[rdx+2]
       or        rcx,r8
       sete      al
       movzx     eax,al
       jmp       short M01_L25
M01_L24:
       call      qword ptr [7FFE772AFB40]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
M01_L25:
       test      eax,eax
       je        short M01_L22
       jmp       near ptr M01_L08
M01_L26:
       sub       r14d,edi
       jmp       short M01_L20
M01_L27:
       xor       edi,edi
       jmp       near ptr M01_L09
M01_L28:
       mov       rcx,rsi
       mov       rdx,r15
       mov       r8d,1
       mov       r9d,2
       call      qword ptr [7FFE772AD278]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
       mov       rdi,rax
       jmp       near ptr M01_L10
M01_L29:
       lea       rcx,[r12+28]
       mov       r8,rdi
       mov       rdx,offset MT_System.Reflection.CerHashtable<System.String, System.Reflection.RuntimeFieldInfo[]>
       call      qword ptr [7FFE772AF390]; System.Reflection.CerHashtable`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Item(System.__Canon)
       test      rax,rax
       jne       short M01_L30
       mov       rcx,r12
       mov       rdx,rdi
       mov       r8d,2
       mov       r9d,2
       call      qword ptr [7FFE772AD278]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
M01_L30:
       mov       rdi,rax
       jmp       near ptr M01_L10
M01_L31:
       mov       rdi,[r12+8]
       jmp       near ptr M01_L10
M01_L32:
       mov       rcx,r12
       mov       r8d,ebp
       xor       edx,edx
       mov       r9d,2
       call      qword ptr [7FFE772AD278]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
       mov       rdi,rax
       jmp       near ptr M01_L10
M01_L33:
       mov       rcx,r13
       mov       rax,[r13]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       r12,rax
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       cmp       r12,rax
       je        near ptr M01_L36
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFE772AED00]; System.Type.get_IsInterface()
       test      eax,eax
       je        short M01_L34
       mov       rcx,r13
       mov       rax,[r13]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFE772AED00]; System.Type.get_IsInterface()
       test      eax,eax
       je        short M01_L34
       mov       ebp,1
M01_L34:
       mov       rcx,r13
       mov       rax,[r13]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       r12,rax
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       rdx,rax
       mov       rcx,r12
       mov       rax,[r12]
       mov       rax,[rax+0B0]
       call      qword ptr [rax+18]
       test      eax,eax
       jne       near ptr M01_L12
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFE772AED00]; System.Type.get_IsInterface()
       test      eax,eax
       je        near ptr M01_L13
       jmp       near ptr M01_L12
M01_L35:
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFE772AED00]; System.Type.get_IsInterface()
       test      eax,eax
       je        near ptr M01_L15
M01_L36:
       mov       rcx,rsi
       call      qword ptr [7FFE77A672D0]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M01_L37:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1052
```
```assembly
; System.Reflection.CustomAttribute.GetCustomAttributes(System.Reflection.RuntimeModule, Int32, Int32, System.RuntimeType)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0D8
       vzeroupper
       lea       rbp,[rsp+110]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-80],ymm4
       vmovdqu   ymmword ptr [rbp-60],ymm4
       xor       eax,eax
       mov       [rbp-40],rax
       mov       rsi,rcx
       mov       edi,edx
       mov       r14d,r8d
       mov       rbx,r9
       lea       rcx,[rbp-0C8]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       r15,rax
       mov       rcx,rsp
       mov       [rbp-0B0],rcx
       mov       rcx,rbp
       mov       [rbp-0A0],rcx
       xor       ecx,ecx
       mov       [rsp+20],ecx
       lea       rcx,[rbp-68]
       mov       [rsp+28],rcx
       lea       rcx,[rbp-50]
       mov       rdx,rsi
       mov       r8d,edi
       mov       r9,rbx
       call      qword ptr [7FFE772AE958]; System.Reflection.CustomAttribute.AddCustomAttributes(ListBuilder`1<System.Object> ByRef, System.Reflection.RuntimeModule, Int32, System.RuntimeType, Boolean, ListBuilder`1<System.Object>)
       add       r14d,[rbp-40]
       xor       esi,esi
       mov       rcx,21081F51A60
       cmp       rbx,rcx
       je        near ptr M02_L16
       mov       rcx,[rbx+18]
       test      cl,2
       jne       near ptr M02_L17
       mov       ecx,[rcx]
       and       ecx,0C0000
       cmp       ecx,40000
       sete      cl
       movzx     ecx,cl
M02_L00:
       test      ecx,ecx
       jne       near ptr M02_L25
       mov       [rbp+28],rbx
       mov       rdi,rbx
       mov       rbx,[rbp+28]
M02_L01:
       mov       rcx,offset MT_System.RuntimeType
       cmp       [rdi],rcx
       jne       near ptr M02_L21
       mov       [rbp+28],rbx
       mov       [rbp-0E0],rdi
       mov       rcx,[rdi+18]
       mov       rax,7FFED6E9E4E0
       call      rax
       movzx     ebx,al
       mov       rdi,[rbp-0E0]
       cmp       dword ptr [7FFED71EE808],0
       jne       near ptr M02_L19
M02_L02:
       cmp       ebx,1D
       ja        short M02_L03
       mov       ecx,1FEF7FFF
       bt        ecx,ebx
       jae       near ptr M02_L20
M02_L03:
       cmp       ebx,10
       sete      r13b
       movzx     r13d,r13b
M02_L04:
       mov       rbx,[rbp+28]
M02_L05:
       test      r13d,r13d
       jne       near ptr M02_L18
       mov       rcx,offset MT_System.RuntimeType
       cmp       [rdi],rcx
       jne       near ptr M02_L22
M02_L06:
       test      rdi,rdi
       je        near ptr M02_L23
       mov       rcx,rdi
       call      00007FFED6EA1090
       test      eax,eax
       jne       near ptr M02_L24
M02_L07:
       test      esi,esi
       jne       near ptr M02_L30
       test      r14d,r14d
       je        near ptr M02_L35
       mov       [rbp-70],r14d
       mov       r14d,[rbp-70]
       test      r14d,r14d
       jl        near ptr M02_L32
       mov       [rbp-80],rbx
       xor       ecx,ecx
       mov       [rbp-78],rcx
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rbp-90],xmm0
       lea       rcx,[rbp-80]
       mov       [rbp-90],rcx
       mov       rcx,[rbp-80]
       test      rcx,rcx
       je        near ptr M02_L33
       mov       rcx,[rcx+18]
M02_L08:
       mov       [rbp-88],rcx
       vmovups   xmm0,[rbp-90]
       vmovups   [rbp-0D8],xmm0
       xor       ecx,ecx
       mov       [rsp+20],ecx
       lea       rcx,[rbp-78]
       mov       [rsp+28],rcx
       lea       rcx,[rbp-0D8]
       lea       r8,[rbp-70]
       mov       edx,1
       xor       r9d,r9d
       mov       rax,7FFE772B1878
       mov       [rbp-0B8],rax
       lea       rax,[M02_L09]
       mov       [rbp-0A8],rax
       lea       rax,[rbp-0C8]
       mov       [r15+8],rax
       mov       byte ptr [r15+4],0
       mov       rax,7FFED6EA4900
       call      rax
M02_L09:
       mov       byte ptr [r15+4],1
       cmp       dword ptr [7FFED71EE808],0
       je        short M02_L10
       call      qword ptr [7FFED71DC608]; CORINFO_HELP_STOP_FOR_GC
M02_L10:
       mov       rdx,[rbp-0C0]
       mov       [r15+8],rdx
       mov       rdx,[rbp-78]
       xor       ecx,ecx
       mov       [rbp-78],rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        short M02_L11
       mov       rcx,offset MT_System.ObsoleteAttribute[]
       cmp       [rbx],rcx
       jne       near ptr M02_L34
M02_L11:
       xor       esi,esi
       cmp       dword ptr [rbp-40],0
       jle       short M02_L14
M02_L12:
       cmp       qword ptr [rbp-50],0
       je        short M02_L15
       mov       rdx,[rbp-50]
       cmp       esi,[rdx+8]
       jae       near ptr M02_L38
       mov       rdx,[rbp-50]
       mov       r8,[rdx+rsi*8+10]
M02_L13:
       movsxd    rdx,esi
       mov       rcx,rbx
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       inc       esi
       cmp       esi,[rbp-40]
       jl        short M02_L12
M02_L14:
       mov       rax,rbx
       add       rsp,0D8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L15:
       mov       r8,[rbp-48]
       jmp       short M02_L13
M02_L16:
       test      r14d,r14d
       je        near ptr M02_L27
       jmp       near ptr M02_L26
M02_L17:
       xor       ecx,ecx
       jmp       near ptr M02_L00
M02_L18:
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+68]
       call      qword ptr [rax+8]
       mov       rdi,rax
       jmp       near ptr M02_L01
M02_L19:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M02_L02
M02_L20:
       mov       r13d,1
       jmp       near ptr M02_L04
M02_L21:
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+68]
       call      qword ptr [rax]
       mov       r13d,eax
       jmp       near ptr M02_L05
M02_L22:
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+98]
       call      qword ptr [rax+8]
       mov       rdi,rax
       jmp       near ptr M02_L06
M02_L23:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE77A66988]
       mov       r8,rax
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFE77A669A0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M02_L24:
       mov       rcx,rbx
       mov       rdx,21081F51A60
       call      qword ptr [7FFE771EA608]; Precode of System.RuntimeType.IsSubclassOf(System.Type)
       test      eax,eax
       jne       near ptr M02_L16
M02_L25:
       mov       esi,1
       jmp       near ptr M02_L07
M02_L26:
       movsxd    rdx,r14d
       mov       rcx,offset MT_System.Attribute[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbx,rax
       jmp       short M02_L29
M02_L27:
       test      byte ptr [7FFE77AC6368],1
       jne       short M02_L28
       mov       rcx,offset MT_System.Array+EmptyArray<System.Attribute>
       call      qword ptr [7FFE772A5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
M02_L28:
       mov       rdx,21100002140
       mov       rbx,[rdx]
M02_L29:
       jmp       near ptr M02_L11
M02_L30:
       test      r14d,r14d
       je        short M02_L31
       movsxd    rdx,r14d
       mov       rcx,offset MT_System.Object[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbx,rax
       jmp       near ptr M02_L11
M02_L31:
       mov       rdx,21100001A68
       mov       rbx,[rdx]
       jmp       near ptr M02_L11
M02_L32:
       mov       ecx,0B3
       mov       rdx,7FFE771E4000
       call      qword ptr [7FFE775276F0]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FFE77A65398]
       int       3
M02_L33:
       xor       ecx,ecx
       jmp       near ptr M02_L08
M02_L34:
       mov       rcx,offset MT_System.Object[]
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rbx,rax
       jmp       near ptr M02_L11
M02_L35:
       cmp       qword ptr [rbx+10],0
       je        short M02_L36
       mov       rcx,[rbx+10]
       mov       rcx,[rcx]
       test      rcx,rcx
       je        short M02_L36
       mov       rax,rcx
       jmp       short M02_L37
M02_L36:
       mov       rcx,rbx
       call      qword ptr [7FFE772A7C00]; System.RuntimeType.InitializeCache()
M02_L37:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFE77445188]; System.RuntimeType+RuntimeTypeCache.GetEmptyArray()
       mov       rbx,rax
       jmp       near ptr M02_L11
M02_L38:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1143
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
       sub       rsp,58
       vzeroupper
       lea       rbp,[rsp+90]
       mov       [rbp+10],rcx
       lea       rcx,[rbp-70]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rbx,rax
       mov       rcx,rsp
       mov       [rbp-58],rcx
       mov       rcx,rbp
       mov       [rbp-48],rcx
       cmp       qword ptr [rbp+10],0
       je        short M03_L03
       mov       rcx,7FFE77ABC74C
       call      CORINFO_HELP_COUNTPROFILE32
       lea       rcx,[rbp+10]
       mov       rax,7FFE7742F250
       mov       [rbp-60],rax
       lea       rax,[M03_L00]
       mov       [rbp-50],rax
       lea       rax,[rbp-70]
       mov       [rbx+8],rax
       mov       byte ptr [rbx+4],0
       mov       rax,7FFED6DAF7F0
       call      rax
M03_L00:
       mov       byte ptr [rbx+4],1
       cmp       dword ptr [7FFED71EE808],0
       je        short M03_L01
       call      qword ptr [7FFED71DC608]; CORINFO_HELP_STOP_FOR_GC
M03_L01:
       mov       rcx,[rbp-68]
       mov       [rbx+8],rcx
M03_L02:
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M03_L03:
       mov       rcx,7FFE77ABC748
       call      CORINFO_HELP_COUNTPROFILE32
       xor       eax,eax
       jmp       short M03_L02
; Total bytes of code 195
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rdx,rdx
       je        short M04_L00
       cmp       [rdx],rcx
       jne       short M04_L01
M04_L00:
       mov       rax,rdx
       ret
M04_L01:
       mov       rax,[rdx]
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M04_L00
M04_L02:
       test      rax,rax
       je        short M04_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M04_L00
       test      rax,rax
       je        short M04_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M04_L00
       test      rax,rax
       jne       short M04_L04
M04_L03:
       xor       edx,edx
       jmp       short M04_L00
M04_L04:
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M04_L00
       test      rax,rax
       je        short M04_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M04_L00
       jmp       short M04_L02
; Total bytes of code 88
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rdx,rdx
       je        short M05_L07
       mov       rax,[rdx]
       movzx     r8d,word ptr [rax+0E]
       test      r8,r8
       je        short M05_L03
       mov       r10,[rax+38]
       cmp       r8,4
       jl        short M05_L01
       cmp       [r10],rcx
       je        short M05_L07
M05_L00:
       cmp       [r10+8],rcx
       je        short M05_L07
       cmp       [r10+10],rcx
       je        short M05_L07
       cmp       [r10+18],rcx
       je        short M05_L07
       add       r10,20
       add       r8,0FFFFFFFFFFFFFFFC
       cmp       r8,4
       jge       short M05_L05
       test      r8,r8
       je        short M05_L03
M05_L01:
       cmp       [r10],rcx
       je        short M05_L07
M05_L02:
       add       r10,8
       dec       r8
       test      r8,r8
       jg        short M05_L04
M05_L03:
       test      dword ptr [rax],500C0000
       je        short M05_L06
       jmp       qword ptr [7FFE7770D1B8]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
M05_L04:
       cmp       [r10],rcx
       je        short M05_L07
       jmp       short M05_L02
M05_L05:
       cmp       [r10],rcx
       je        short M05_L07
       jmp       short M05_L00
M05_L06:
       xor       edx,edx
M05_L07:
       mov       rax,rdx
       ret
; Total bytes of code 121
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
       je        near ptr M06_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M06_L01
       test      rsi,rsi
       je        short M06_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M06_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M06_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFED6EDF840
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFE772A5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFE772A5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
M06_L00:
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
M06_L01:
       test      rsi,rsi
       je        short M06_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M06_L03
M06_L02:
       mov       rax,21081F50008
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M06_L03:
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
M06_L04:
       call      qword ptr [7FFE77A65EA8]
       int       3
; Total bytes of code 244
```
```assembly
; System.RuntimeTypeHandle.GetRuntimeTypeFromHandleSlow(IntPtr)
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
       mov       [rbp-40],rax
       mov       [rbp-0A0],rcx
       lea       rdx,[rbp-40]
       mov       [rbp-0A8],rdx
       lea       rcx,[rbp-98]
       call      qword ptr [7FFED6CEF020]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-0A0]
       mov       rdx,[rbp-0A8]
       call      qword ptr [rax]
       lea       rcx,[rbp-98]
       call      qword ptr [7FFED6CEF028]; CORINFO_HELP_JIT_PINVOKE_END
       mov       rax,[rbp-40]
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
; Total bytes of code 124
```
```assembly
; System.RuntimeTypeHandle.<GetModule>g__GetModuleWorker|48_0(System.RuntimeType)
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
       mov       [rbp-40],rax
       mov       [rbp+10],rcx
       lea       rcx,[rbp+10]
       mov       [rbp-0A0],rcx
       lea       rdx,[rbp-40]
       mov       [rbp-0A8],rdx
       lea       rcx,[rbp-98]
       call      qword ptr [7FFED6CEF020]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-0A0]
       mov       rdx,[rbp-0A8]
       call      qword ptr [rax]
       lea       rcx,[rbp-98]
       call      qword ptr [7FFED6CEF028]; CORINFO_HELP_JIT_PINVOKE_END
       mov       rax,[rbp-40]
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
; Total bytes of code 132
```

## .NET 10.0.0 (10.0.25.45207), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark.CreateStringBuilder()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,0B8
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+50],ymm4
       vmovdqu   ymmword ptr [rsp+70],ymm4
       vmovdqu   ymmword ptr [rsp+90],ymm4
       xor       eax,eax
       mov       [rsp+0B0],rax
       mov       rbx,rcx
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       dword ptr [rsi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbx+138]
       mov       edx,[rcx+14]
       mov       [rsp+0A0],rcx
       xor       ecx,ecx
       mov       [rsp+0A8],rcx
       mov       [rsp+0B0],edx
       mov       [rsp+0B4],ecx
       jmp       near ptr M00_L30
M00_L00:
       cmp       edx,2D
       jne       short M00_L01
       mov       r13d,1
       inc       ebp
       cmp       ebp,7
       jae       near ptr M00_L97
       cmp       ebp,7
       jae       near ptr M00_L104
       mov       edx,ebp
       movzx     edx,word ptr [r14+rdx*2+0C]
M00_L01:
       lea       r15d,[rdx-30]
       cmp       r15d,0A
       jae       near ptr M00_L63
       inc       ebp
       cmp       ebp,7
       jae       near ptr M00_L97
M00_L02:
       cmp       ebp,7
       jae       near ptr M00_L104
       mov       edx,ebp
       movzx     edx,word ptr [r14+rdx*2+0C]
       lea       ecx,[rdx-30]
       cmp       ecx,9
       ja        short M00_L03
       cmp       r15d,0F4240
       jge       short M00_L03
       lea       ecx,[r15+r15*4]
       lea       r15d,[rdx+rcx*2-30]
       inc       ebp
       cmp       ebp,7
       jb        short M00_L02
       jmp       near ptr M00_L97
M00_L03:
       cmp       edx,20
       jne       short M00_L05
M00_L04:
       inc       ebp
       cmp       ebp,7
       jae       near ptr M00_L97
       cmp       ebp,7
       jae       near ptr M00_L104
       mov       edx,ebp
       movzx     edx,word ptr [r14+rdx*2+0C]
       cmp       edx,20
       je        short M00_L04
M00_L05:
       cmp       edx,7D
       je        short M00_L09
       cmp       edx,3A
       jne       short M00_L07
       mov       r8d,ebp
       lea       ebp,[r8+1]
       cmp       ebp,7
       jae       near ptr M00_L97
M00_L06:
       cmp       ebp,7
       jae       near ptr M00_L104
       mov       edx,ebp
       movzx     edx,word ptr [r14+rdx*2+0C]
       cmp       edx,7D
       je        short M00_L08
       cmp       edx,7B
       jne       near ptr M00_L71
M00_L07:
       mov       ecx,ebp
       mov       edx,4C
       call      qword ptr [7FFE77A570C0]
       int       3
M00_L08:
       inc       r8d
       mov       edx,ebp
       sub       edx,r8d
       mov       ecx,r8d
       mov       r8d,edx
       add       r8,rcx
       cmp       r8,7
       ja        near ptr M00_L98
       lea       r12,[r14+rcx*2+0C]
       mov       [rsp+74],edx
       mov       r8d,[rsp+74]
M00_L09:
       inc       ebp
       xor       r14d,r14d
       cmp       eax,2
       jae       near ptr M00_L62
       cmp       eax,2
       jae       near ptr M00_L104
       lea       rdx,[rsp+90]
       mov       ecx,eax
       mov       rax,[rdx+rcx*8]
       mov       [rsp+48],rax
       test      r13d,r13d
       je        near ptr M00_L13
       mov       [rsp+74],r8d
M00_L10:
       mov       rdx,rax
       mov       rcx,offset MT_System.ISpanFormattable
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        near ptr M00_L14
       mov       rdx,[rsi+8]
       mov       r9,rdx
       mov       r8d,[rsi+18]
       mov       ecx,r8d
       mov       edx,[rdx+8]
       sub       edx,r8d
       test      r9,r9
       je        near ptr M00_L72
       mov       r8d,edx
       add       r8,rcx
       mov       r11d,[r9+8]
       cmp       r8,r11
       ja        near ptr M00_L103
       lea       r9,[r9+rcx*2+10]
M00_L11:
       mov       [rsp+50],r9
       mov       [rsp+58],edx
       mov       [rsp+60],r12
       mov       r10d,[rsp+74]
       mov       [rsp+68],r10d
       mov       [rsp+20],rdi
       lea       rdx,[rsp+50]
       lea       r9,[rsp+60]
       lea       r8,[rsp+88]
       mov       rcx,rax
       mov       r11,7FFE771E0AA0
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L14
       mov       edx,[rsp+88]
       mov       rcx,[rsi+8]
       mov       r8,rcx
       mov       eax,[rsi+18]
       mov       r10d,eax
       mov       r9d,[rcx+8]
       sub       r9d,eax
       test      r8,r8
       je        near ptr M00_L73
       mov       r11d,r9d
       add       r10,r11
       mov       r8d,[r8+8]
       cmp       r10,r8
       ja        near ptr M00_L103
M00_L12:
       cmp       edx,r9d
       jbe       near ptr M00_L74
       jmp       near ptr M00_L99
M00_L13:
       test      r15d,r15d
       mov       [rsp+74],r8d
       je        near ptr M00_L10
M00_L14:
       mov       rdx,[rsp+48]
       mov       rcx,offset MT_System.IFormattable
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       [rsp+40],rax
       test      rax,rax
       jne       short M00_L17
       mov       r12,[rsp+48]
       test      r12,r12
       je        short M00_L15
       mov       rcx,r12
       mov       rax,[r12]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       r12,rax
       jmp       short M00_L16
M00_L15:
       xor       r12d,r12d
M00_L16:
       jmp       short M00_L19
M00_L17:
       mov       rax,[rsp+40]
       mov       ecx,[rsp+74]
       test      ecx,ecx
       je        short M00_L18
       mov       [rsp+60],r12
       mov       [rsp+68],ecx
       lea       rcx,[rsp+60]
       call      System.String.Ctor(System.ReadOnlySpan`1<Char>)
       mov       r14,rax
       mov       rax,[rsp+40]
M00_L18:
       mov       rcx,rax
       mov       r8,rdi
       mov       rdx,r14
       mov       r11,7FFE771E0A98
       call      qword ptr [r11]
       mov       r12,rax
M00_L19:
       test      r12,r12
       jne       short M00_L20
       mov       r12,24DF2D20008
M00_L20:
       cmp       [r12+8],r15d
       jge       near ptr M00_L26
       test      r13d,r13d
       jne       short M00_L23
       sub       r15d,[r12+8]
       js        near ptr M00_L102
       test      r15d,r15d
       jne       near ptr M00_L82
M00_L21:
       lea       rdx,[r12+0C]
       mov       r8d,[r12+8]
       test      r8d,r8d
       je        near ptr M00_L35
       mov       rcx,[rsi+8]
       mov       eax,[rsi+18]
       lea       r12d,[rax+r8]
       cmp       r12d,[rcx+8]
       ja        near ptr M00_L85
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jle       near ptr M00_L84
       mov       r8d,r8d
       call      qword ptr [7FFE7799C228]
M00_L22:
       mov       [rsi+18],r12d
       jmp       near ptr M00_L35
M00_L23:
       lea       rdx,[r12+0C]
       mov       r8d,[r12+8]
       test      r8d,r8d
       je        short M00_L25
       mov       rcx,[rsi+8]
       mov       eax,[rsi+18]
       lea       r13d,[rax+r8]
       cmp       r13d,[rcx+8]
       ja        near ptr M00_L79
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jle       near ptr M00_L78
       mov       r8d,r8d
       add       r8,r8
       call      qword ptr [7FFE77295818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L24:
       mov       [rsi+18],r13d
M00_L25:
       mov       r14d,r15d
       sub       r14d,[r12+8]
       js        near ptr M00_L101
       test      r14d,r14d
       je        near ptr M00_L35
       jmp       near ptr M00_L80
M00_L26:
       lea       rdx,[r12+0C]
       mov       r8d,[r12+8]
       test      r8d,r8d
       je        near ptr M00_L35
       mov       rcx,[rsi+8]
       mov       eax,[rsi+18]
       lea       r13d,[rax+r8]
       cmp       r13d,[rcx+8]
       ja        near ptr M00_L77
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jle       near ptr M00_L76
       mov       r8d,r8d
       add       r8,r8
       call      qword ptr [7FFE77295818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L27:
       mov       [rsi+18],r13d
       jmp       near ptr M00_L35
M00_L28:
       test      r13d,r13d
       je        short M00_L30
       mov       r8,[rsi+8]
       mov       r14d,[rsi+18]
       lea       ecx,[r14+r13]
       cmp       ecx,[r8+8]
       ja        near ptr M00_L53
       movsxd    rcx,r14d
       lea       rcx,[r8+rcx*2+10]
       cmp       r13d,2
       jle       near ptr M00_L52
       mov       r8d,r13d
       add       r8,r8
       mov       rdx,r15
       call      qword ptr [7FFE77295818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L29:
       add       r13d,r14d
       mov       [rsi+18],r13d
M00_L30:
       lea       rcx,[rsp+0A0]
       mov       rdx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       call      qword ptr [7FFE77514420]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       je        near ptr M00_L65
       mov       r8,[rsp+0A8]
       mov       rdx,20D5DC00100
       mov       rdi,[rdx]
       mov       rdx,[r8+18]
       mov       r8,[r8+28]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+90],xmm0
       mov       [rsp+90],rdx
       mov       [rsp+98],r8
       xor       ebp,ebp
M00_L31:
       cmp       ebp,7
       ja        near ptr M00_L98
       mov       r14,24DF2D30090
       mov       r8d,ebp
       lea       r15,[r14+r8*2+0C]
       mov       r13d,ebp
       neg       r13d
       add       r13d,7
       mov       r8d,7D
       mov       edx,7B
       mov       rcx,r15
       mov       r9d,r13d
       call      qword ptr [7FFE7751C588]; System.PackedSpanHelpers.IndexOfAny[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib],[System.PackedSpanHelpers+NopTransform, System.Private.CoreLib]](Int16 ByRef, Int16, Int16, Int32)
       mov       r12d,eax
       test      r12d,r12d
       jl        near ptr M00_L28
       cmp       r12d,r13d
       ja        near ptr M00_L103
       test      r12d,r12d
       je        short M00_L33
       mov       r8,[rsi+8]
       mov       r13d,[rsi+18]
       lea       ecx,[r12+r13]
       cmp       ecx,[r8+8]
       ja        near ptr M00_L37
       movsxd    rcx,r13d
       lea       rcx,[r8+rcx*2+10]
       cmp       r12d,2
       jle       near ptr M00_L36
       mov       r8d,r12d
       add       r8,r8
       mov       rdx,r15
       call      qword ptr [7FFE77295818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L32:
       add       r13d,r12d
       mov       [rsi+18],r13d
M00_L33:
       add       ebp,r12d
       cmp       ebp,7
       jae       near ptr M00_L104
       mov       edx,ebp
       movzx     edx,word ptr [r14+rdx*2+0C]
       inc       ebp
       cmp       ebp,7
       jae       near ptr M00_L97
       cmp       ebp,7
       jae       near ptr M00_L104
       mov       ecx,ebp
       movzx     eax,word ptr [r14+rcx*2+0C]
       cmp       edx,eax
       jne       near ptr M00_L46
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       r8,[rsi+8]
       cmp       [r8+8],edx
       jbe       near ptr M00_L70
       mov       [r8+rdx*2+10],ax
       inc       ecx
       mov       [rsi+18],ecx
M00_L34:
       inc       ebp
M00_L35:
       cmp       ebp,7
       jae       near ptr M00_L30
       jmp       near ptr M00_L31
M00_L36:
       movzx     r8d,word ptr [r15]
       mov       [rcx],r8w
       cmp       r12d,2
       jne       short M00_L32
       jmp       near ptr M00_L66
M00_L37:
       mov       r8d,[rsi+1C]
       add       r8d,[rsi+18]
       add       r8d,r12d
       cmp       r8d,[rsi+20]
       jg        near ptr M00_L93
       cmp       r8d,r12d
       jl        near ptr M00_L93
       mov       r8,[rsi+8]
       mov       r13d,[r8+8]
       sub       r13d,[rsi+18]
       test      r13d,r13d
       jle       short M00_L39
       mov       r8,[rsi+8]
       mov       ecx,[rsi+18]
       test      r8,r8
       je        near ptr M00_L67
       cmp       [r8+8],ecx
       jb        near ptr M00_L103
       mov       edx,ecx
       lea       rdx,[r8+rdx*2+10]
       mov       r8d,[r8+8]
       sub       r8d,ecx
M00_L38:
       cmp       r13d,r8d
       ja        near ptr M00_L96
       mov       r8d,r13d
       add       r8,r8
       mov       rcx,rdx
       mov       rdx,r15
       call      qword ptr [7FFE77295818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rdx,[rsi+8]
       mov       edx,[rdx+8]
       mov       [rsi+18],edx
M00_L39:
       mov       eax,r12d
       sub       eax,r13d
       mov       [rsp+84],eax
       mov       edx,[rsi+1C]
       lea       ecx,[rax+rdx]
       mov       r8d,[rsi+18]
       add       ecx,r8d
       cmp       ecx,[rsi+20]
       jg        near ptr M00_L94
       cmp       ecx,eax
       jl        near ptr M00_L94
       add       edx,r8d
       mov       ecx,edx
       cmp       ecx,1F40
       jg        near ptr M00_L44
M00_L40:
       cmp       eax,ecx
       jl        near ptr M00_L45
       mov       ecx,eax
M00_L41:
       add       edx,ecx
       cmp       edx,ecx
       jl        near ptr M00_L95
       cmp       ecx,400
       jge       near ptr M00_L68
       movsxd    rdx,ecx
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rsp+30],rax
M00_L42:
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+38],rax
       mov       ecx,[rsi+18]
       mov       [rax+18],ecx
       mov       ecx,[rsi+1C]
       mov       [rax+1C],ecx
       mov       rdx,[rsi+8]
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rsi+10]
       mov       rax,[rsp+38]
       lea       rcx,[rax+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rsi+20]
       mov       rax,[rsp+38]
       mov       [rax+20],ecx
       lea       rcx,[rsi+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rsi+18]
       add       [rsi+1C],ecx
       xor       ecx,ecx
       mov       [rsi+18],ecx
       lea       rcx,[rsi+8]
       mov       rdx,[rsp+30]
       call      CORINFO_HELP_ASSIGN_REF
       movsxd    r8,r13d
       lea       rdx,[r15+r8*2]
       mov       r8,[rsi+8]
       test      r8,r8
       je        near ptr M00_L69
       lea       rcx,[r8+10]
       mov       r8d,[r8+8]
M00_L43:
       mov       r15d,[rsp+84]
       cmp       r15d,r8d
       ja        near ptr M00_L96
       mov       r8d,r15d
       add       r8,r8
       call      qword ptr [7FFE77295818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       [rsi+18],r15d
       jmp       near ptr M00_L33
M00_L44:
       mov       ecx,1F40
       jmp       near ptr M00_L40
M00_L45:
       jmp       near ptr M00_L41
M00_L46:
       cmp       edx,7B
       jne       near ptr M00_L64
       xor       r15d,r15d
       xor       r13d,r13d
       xor       r12d,r12d
       xor       r8d,r8d
       add       eax,0FFFFFFD0
       cmp       eax,0A
       jae       near ptr M00_L63
       inc       ebp
       cmp       ebp,7
       jae       near ptr M00_L97
       cmp       ebp,7
       jae       near ptr M00_L104
       mov       edx,ebp
       movzx     edx,word ptr [r14+rdx*2+0C]
       cmp       edx,7D
       je        near ptr M00_L09
       lea       ecx,[rdx-30]
       cmp       ecx,9
       ja        short M00_L48
M00_L47:
       cmp       eax,0F4240
       jge       short M00_L48
       lea       eax,[rax+rax*4]
       lea       eax,[rdx+rax*2-30]
       inc       ebp
       cmp       ebp,7
       jae       near ptr M00_L97
       cmp       ebp,7
       jae       near ptr M00_L104
       mov       edx,ebp
       movzx     edx,word ptr [r14+rdx*2+0C]
       lea       ecx,[rdx-30]
       cmp       ecx,9
       jbe       short M00_L47
M00_L48:
       cmp       edx,20
       jne       short M00_L50
M00_L49:
       inc       ebp
       cmp       ebp,7
       jae       near ptr M00_L97
       cmp       ebp,7
       jae       near ptr M00_L104
       mov       edx,ebp
       movzx     edx,word ptr [r14+rdx*2+0C]
       cmp       edx,20
       je        short M00_L49
M00_L50:
       cmp       edx,2C
       jne       near ptr M00_L05
       inc       ebp
       cmp       ebp,7
       jae       near ptr M00_L97
M00_L51:
       mov       edx,ebp
       movzx     edx,word ptr [r14+rdx*2+0C]
       cmp       edx,20
       jne       near ptr M00_L00
       inc       ebp
       cmp       ebp,7
       jb        short M00_L51
       jmp       near ptr M00_L97
M00_L52:
       movzx     r8d,word ptr [r15]
       mov       [rcx],r8w
       cmp       r13d,2
       jne       near ptr M00_L29
       jmp       near ptr M00_L86
M00_L53:
       mov       r8d,[rsi+1C]
       add       r8d,[rsi+18]
       add       r8d,r13d
       cmp       r8d,[rsi+20]
       jg        near ptr M00_L90
       cmp       r8d,r13d
       jl        near ptr M00_L90
       mov       r8,[rsi+8]
       mov       ebp,[r8+8]
       sub       ebp,[rsi+18]
       test      ebp,ebp
       jle       short M00_L55
       mov       r8,[rsi+8]
       mov       ecx,[rsi+18]
       test      r8,r8
       je        near ptr M00_L87
       cmp       [r8+8],ecx
       jb        near ptr M00_L103
       mov       edx,ecx
       lea       rdx,[r8+rdx*2+10]
       mov       r8d,[r8+8]
       sub       r8d,ecx
M00_L54:
       cmp       ebp,r8d
       ja        near ptr M00_L96
       mov       r8d,ebp
       add       r8,r8
       mov       rcx,rdx
       mov       rdx,r15
       call      qword ptr [7FFE77295818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rdx,[rsi+8]
       mov       edx,[rdx+8]
       mov       [rsi+18],edx
M00_L55:
       mov       edi,r13d
       sub       edi,ebp
       mov       edx,[rsi+1C]
       lea       ecx,[rdi+rdx]
       mov       eax,[rsi+18]
       add       ecx,eax
       cmp       ecx,[rsi+20]
       jg        near ptr M00_L91
       cmp       ecx,edi
       jl        near ptr M00_L91
       add       edx,eax
       mov       ecx,edx
       cmp       ecx,1F40
       jg        near ptr M00_L60
M00_L56:
       cmp       edi,ecx
       jl        near ptr M00_L61
       mov       ecx,edi
M00_L57:
       add       edx,ecx
       cmp       edx,ecx
       jl        near ptr M00_L92
       cmp       ecx,400
       jge       near ptr M00_L88
       movsxd    rdx,ecx
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
M00_L58:
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       ecx,[rsi+18]
       mov       [r13+18],ecx
       mov       ecx,[rsi+1C]
       mov       [r13+1C],ecx
       mov       rdx,[rsi+8]
       lea       rcx,[r13+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rsi+10]
       lea       rcx,[r13+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rsi+20]
       mov       [r13+20],ecx
       lea       rcx,[rsi+10]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rsi+18]
       add       [rsi+1C],ecx
       xor       ecx,ecx
       mov       [rsi+18],ecx
       lea       rcx,[rsi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       movsxd    r8,ebp
       lea       rdx,[r15+r8*2]
       mov       r8,[rsi+8]
       test      r8,r8
       je        near ptr M00_L89
       lea       rcx,[r8+10]
       mov       r8d,[r8+8]
M00_L59:
       cmp       edi,r8d
       ja        near ptr M00_L96
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFE77295818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       [rsi+18],edi
       jmp       near ptr M00_L30
M00_L60:
       mov       ecx,1F40
       jmp       near ptr M00_L56
M00_L61:
       jmp       near ptr M00_L57
M00_L62:
       call      qword ptr [7FFE77A570D8]
       int       3
M00_L63:
       mov       ecx,ebp
       mov       edx,4D
       call      qword ptr [7FFE77A570C0]
       int       3
M00_L64:
       mov       ecx,ebp
       mov       edx,4B
       call      qword ptr [7FFE77A570C0]
       int       3
M00_L65:
       mov       rcx,rsi
       call      qword ptr [7FFE774DF790]; System.Text.StringBuilder.ToString()
       mov       [rsp+78],rax
       mov       rcx,[rbx+18]
       lea       r8,[rsp+78]
       mov       rdx,7FFE77A303E0
       cmp       [rcx],ecx
       call      qword ptr [7FFE7799E988]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,0B8
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L66:
       movzx     r8d,word ptr [r15+2]
       mov       [rcx+2],r8w
       jmp       near ptr M00_L32
M00_L67:
       test      ecx,ecx
       jne       near ptr M00_L103
       xor       edx,edx
       xor       r8d,r8d
       jmp       near ptr M00_L38
M00_L68:
       xor       edx,edx
       call      qword ptr [7FFE7790DED8]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       [rsp+30],rax
       jmp       near ptr M00_L42
M00_L69:
       xor       ecx,ecx
       xor       r8d,r8d
       jmp       near ptr M00_L43
M00_L70:
       mov       rcx,rsi
       mov       edx,eax
       call      qword ptr [7FFE7743F2E8]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L34
M00_L71:
       inc       ebp
       cmp       ebp,7
       jb        near ptr M00_L06
       jmp       near ptr M00_L97
M00_L72:
       or        ecx,edx
       jne       near ptr M00_L103
       xor       r9d,r9d
       xor       edx,edx
       jmp       near ptr M00_L11
M00_L73:
       or        r10d,r9d
       jne       near ptr M00_L103
       xor       r9d,r9d
       jmp       near ptr M00_L12
M00_L74:
       add       eax,[rsp+88]
       mov       [rsi+18],eax
       test      r13d,r13d
       je        near ptr M00_L35
       cmp       r15d,[rsp+88]
       jle       near ptr M00_L35
       sub       r15d,[rsp+88]
       js        near ptr M00_L100
       test      r15d,r15d
       je        near ptr M00_L35
       mov       edx,eax
       mov       r8d,r15d
       lea       rax,[rdx+r8]
       mov       r10d,[rcx+8]
       cmp       rax,r10
       ja        short M00_L75
       lea       rcx,[rcx+rdx*2+10]
       mov       rdx,r8
       mov       r8d,20
       call      qword ptr [7FFE777A6EF8]; System.SpanHelpers.Fill[[System.Char, System.Private.CoreLib]](Char ByRef, UIntPtr, Char)
       add       [rsi+18],r15d
       jmp       near ptr M00_L35
M00_L75:
       mov       rcx,rsi
       mov       r8d,r15d
       mov       edx,20
       call      qword ptr [7FFE77A571B0]
       jmp       near ptr M00_L35
M00_L76:
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       jne       near ptr M00_L27
       movzx     edx,word ptr [rdx+2]
       mov       [rcx+2],dx
       jmp       near ptr M00_L27
M00_L77:
       mov       rcx,rsi
       call      qword ptr [7FFE7743F120]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M00_L35
M00_L78:
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       jne       near ptr M00_L24
       movzx     edx,word ptr [rdx+2]
       mov       [rcx+2],dx
       jmp       near ptr M00_L24
M00_L79:
       mov       rcx,rsi
       call      qword ptr [7FFE7743F120]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M00_L25
M00_L80:
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+18]
       mov       eax,r14d
       lea       r8,[rcx+rax]
       mov       r10d,[rdx+8]
       cmp       r8,r10
       ja        short M00_L81
       lea       rcx,[rdx+rcx*2+10]
       mov       rdx,rax
       mov       r8d,20
       call      qword ptr [7FFE777A6EF8]; System.SpanHelpers.Fill[[System.Char, System.Private.CoreLib]](Char ByRef, UIntPtr, Char)
       add       [rsi+18],r14d
       jmp       near ptr M00_L35
M00_L81:
       mov       rcx,rsi
       mov       r8d,r14d
       mov       edx,20
       call      qword ptr [7FFE77A571B0]
       jmp       near ptr M00_L35
M00_L82:
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+18]
       mov       eax,r15d
       lea       r8,[rcx+rax]
       mov       r10d,[rdx+8]
       cmp       r8,r10
       ja        short M00_L83
       lea       rcx,[rdx+rcx*2+10]
       mov       rdx,rax
       mov       r8d,20
       call      qword ptr [7FFE777A6EF8]; System.SpanHelpers.Fill[[System.Char, System.Private.CoreLib]](Char ByRef, UIntPtr, Char)
       add       [rsi+18],r15d
       jmp       near ptr M00_L21
M00_L83:
       mov       rcx,rsi
       mov       r8d,r15d
       mov       edx,20
       call      qword ptr [7FFE77A571B0]
       jmp       near ptr M00_L21
M00_L84:
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       jne       near ptr M00_L22
       movzx     edx,word ptr [rdx+2]
       mov       [rcx+2],dx
       jmp       near ptr M00_L22
M00_L85:
       mov       rcx,rsi
       call      qword ptr [7FFE7743F120]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M00_L35
M00_L86:
       movzx     r8d,word ptr [r15+2]
       mov       [rcx+2],r8w
       jmp       near ptr M00_L29
M00_L87:
       test      ecx,ecx
       jne       near ptr M00_L103
       xor       edx,edx
       xor       r8d,r8d
       jmp       near ptr M00_L54
M00_L88:
       xor       edx,edx
       call      qword ptr [7FFE7790DED8]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       r14,rax
       jmp       near ptr M00_L58
M00_L89:
       xor       ecx,ecx
       xor       r8d,r8d
       jmp       near ptr M00_L59
M00_L90:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,196D5
       mov       rdx,7FFE771D4000
       call      qword ptr [7FFE775176F0]
       mov       rsi,rax
       call      qword ptr [7FFE77A56A78]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE77885C50]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L91:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,196EB
       mov       rdx,7FFE771D4000
       call      qword ptr [7FFE775176F0]
       mov       rsi,rax
       call      qword ptr [7FFE77A56A90]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE77885C50]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L92:
       mov       rcx,offset MT_System.OutOfMemoryException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE77A56AA8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L93:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,196D5
       mov       rdx,7FFE771D4000
       call      qword ptr [7FFE775176F0]
       mov       rsi,rax
       call      qword ptr [7FFE77A56A78]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE77885C50]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L94:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,196EB
       mov       rdx,7FFE771D4000
       call      qword ptr [7FFE775176F0]
       mov       rsi,rax
       call      qword ptr [7FFE77A56A90]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE77885C50]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L95:
       mov       rcx,offset MT_System.OutOfMemoryException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFE77A56AA8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L96:
       call      qword ptr [7FFE777A7F30]
       int       3
M00_L97:
       mov       ecx,ebp
       mov       edx,4C
       call      qword ptr [7FFE77A570C0]
       int       3
M00_L98:
       mov       ecx,21
       call      qword ptr [7FFE77517828]
       int       3
M00_L99:
       call      qword ptr [7FFE77A570F0]
       int       3
M00_L100:
       mov       ecx,196BD
       mov       rdx,7FFE771D4000
       call      qword ptr [7FFE775176F0]
       mov       rdx,rax
       mov       ecx,r15d
       call      qword ptr [7FFE77A55380]
       int       3
M00_L101:
       mov       ecx,196BD
       mov       rdx,7FFE771D4000
       call      qword ptr [7FFE775176F0]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FFE77A55380]
       int       3
M00_L102:
       mov       ecx,196BD
       mov       rdx,7FFE771D4000
       call      qword ptr [7FFE775176F0]
       mov       rdx,rax
       mov       ecx,r15d
       call      qword ptr [7FFE77A55380]
       int       3
M00_L103:
       call      qword ptr [7FFE774370D8]
       int       3
M00_L104:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 3840
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rdx,rdx
       je        short M01_L04
       mov       rax,[rdx]
       movzx     r8d,word ptr [rax+0E]
       test      r8,r8
       je        short M01_L03
       mov       r10,[rax+38]
       cmp       r8,4
       jl        short M01_L01
       cmp       [r10],rcx
       je        short M01_L04
M01_L00:
       cmp       [r10+8],rcx
       je        short M01_L04
       cmp       [r10+10],rcx
       je        short M01_L04
       cmp       [r10+18],rcx
       je        short M01_L04
       add       r10,20
       add       r8,0FFFFFFFFFFFFFFFC
       cmp       r8,4
       jge       short M01_L05
       test      r8,r8
       je        short M01_L03
M01_L01:
       cmp       [r10],rcx
       je        short M01_L04
M01_L02:
       add       r10,8
       dec       r8
       test      r8,r8
       jg        short M01_L06
M01_L03:
       test      dword ptr [rax],500C0000
       jne       short M01_L07
       xor       edx,edx
M01_L04:
       mov       rax,rdx
       ret
M01_L05:
       cmp       [r10],rcx
       je        short M01_L04
       jmp       short M01_L00
M01_L06:
       cmp       [r10],rcx
       je        short M01_L04
       jmp       short M01_L02
M01_L07:
       jmp       qword ptr [7FFE776FD1B8]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
; Total bytes of code 121
```
```assembly
; System.String.Ctor(System.ReadOnlySpan`1<Char>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,[rcx]
       mov       esi,[rcx+8]
       test      esi,esi
       je        short M02_L00
       mov       edx,esi
       mov       rcx,offset MT_System.String
       call      00007FFED6EDF840
       mov       rdi,rax
       cmp       [rdi],dil
       lea       rcx,[rdi+0C]
       mov       r8d,esi
       add       r8,r8
       mov       rdx,rbx
       call      qword ptr [7FFE77295818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rdi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L00:
       mov       rax,24DF2D20008
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 88
```
```assembly
; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M03_L10
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M03_L10
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       jbe       near ptr M03_L06
       cmp       r8,40
       ja        short M03_L03
M03_L00:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       jbe       short M03_L01
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M03_L01
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
M03_L01:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
M03_L02:
       vzeroupper
       ret
M03_L03:
       cmp       r8,800
       ja        near ptr M03_L11
       cmp       r8,100
       jae       short M03_L07
M03_L04:
       mov       r9,r8
       shr       r9,6
M03_L05:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M03_L05
       and       r8,3F
       cmp       r8,10
       ja        short M03_L00
       jmp       short M03_L01
M03_L06:
       test      r8b,18
       jne       short M03_L08
       test      r8b,4
       jne       short M03_L09
       test      r8,r8
       je        short M03_L02
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M03_L02
       movsx     rcx,word ptr [rax-2]
       mov       [r10-2],cx
       jmp       short M03_L02
M03_L07:
       mov       r9,rcx
       and       r9,3F
       neg       r9
       add       r9,40
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rdx,r9
       add       rcx,r9
       sub       r8,r9
       jmp       near ptr M03_L04
M03_L08:
       mov       rdx,[rdx]
       mov       [rcx],rdx
       mov       rcx,[rax-8]
       mov       [r10-8],rcx
       jmp       near ptr M03_L02
M03_L09:
       mov       edx,[rdx]
       mov       [rcx],edx
       mov       ecx,[rax-4]
       mov       [r10-4],ecx
       jmp       near ptr M03_L02
M03_L10:
       cmp       rcx,rdx
       jne       short M03_L11
       cmp       [rdx],dl
       jmp       near ptr M03_L02
M03_L11:
       cmp       [rcx],cl
       cmp       [rdx],dl
       vzeroupper
       jmp       qword ptr [7FFE772966E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 327
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
       jne       short M04_L01
       mov       ecx,[rbx+14]
       cmp       ecx,[rdx+10]
       jae       short M04_L00
       mov       rdx,[rdx+8]
       cmp       ecx,[rdx+8]
       jae       short M04_L02
       mov       ecx,ecx
       mov       rdx,[rdx+rcx*8+10]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       dword ptr [rbx+14]
       mov       eax,1
       add       rsp,20
       pop       rbx
       ret
M04_L00:
       xor       eax,eax
       mov       [rbx+8],rax
       mov       dword ptr [rbx+14],0FFFFFFFF
       add       rsp,20
       pop       rbx
       ret
M04_L01:
       call      qword ptr [7FFE7751C090]
       int       3
M04_L02:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 101
```
```assembly
; System.PackedSpanHelpers.IndexOfAny[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib],[System.PackedSpanHelpers+NopTransform, System.Private.CoreLib]](Int16 ByRef, Int16, Int16, Int32)
       cmp       r9d,8
       jge       near ptr M05_L13
       xor       r10d,r10d
       cmp       r9d,4
       jl        near ptr M05_L11
       add       r9d,0FFFFFFFC
       movsx     r11,word ptr [rcx]
       movsx     rax,dx
       cmp       r11d,eax
       je        short M05_L00
       movsx     rax,r8w
       cmp       r11d,eax
       jne       short M05_L01
M05_L00:
       xor       eax,eax
       vzeroupper
       ret
M05_L01:
       movsx     r11,word ptr [rcx+2]
       movsx     rax,dx
       cmp       r11d,eax
       jne       short M05_L03
M05_L02:
       mov       eax,1
       vzeroupper
       ret
M05_L03:
       movsx     rax,r8w
       cmp       r11d,eax
       je        short M05_L02
       movsx     r11,word ptr [rcx+4]
       movsx     r10,dx
       cmp       r11d,r10d
       je        short M05_L04
       movsx     rax,r8w
       cmp       r11d,eax
       sete      r11b
       movzx     r11d,r11b
       test      r11d,r11d
       je        short M05_L05
M05_L04:
       mov       eax,2
       vzeroupper
       ret
M05_L05:
       movsx     r11,word ptr [rcx+6]
       movsx     rax,dx
       cmp       r11d,eax
       je        short M05_L06
       movsx     rax,r8w
       cmp       r11d,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M05_L07
M05_L06:
       mov       eax,3
       jmp       near ptr M05_L20
M05_L07:
       mov       r10d,4
       test      r9d,r9d
       jle       short M05_L12
M05_L08:
       dec       r9d
       movsx     r11,word ptr [rcx+r10*2]
       movsx     rax,dx
       cmp       r11d,eax
       je        short M05_L09
       movsx     rax,r8w
       cmp       r11d,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M05_L10
M05_L09:
       mov       eax,r10d
       jmp       near ptr M05_L20
M05_L10:
       inc       r10
M05_L11:
       test      r9d,r9d
       jg        short M05_L08
M05_L12:
       mov       eax,0FFFFFFFF
       jmp       near ptr M05_L20
M05_L13:
       mov       rax,rcx
       cmp       r9d,10
       jle       near ptr M05_L18
       vmovd     xmm0,edx
       vpbroadcastb ymm0,xmm0
       vmovd     xmm1,r8d
       vpbroadcastb ymm1,xmm1
       cmp       r9d,20
       jle       short M05_L16
       lea       edx,[r9-20]
       movsxd    r8,edx
       lea       rdx,[rax+r8*2]
M05_L14:
       vmovups   ymm2,[rax]
       vpackuswb ymm2,ymm2,[rax+20]
       vpcmpeqb  ymm3,ymm0,ymm2
       vpcmpeqb  ymm2,ymm1,ymm2
       vpor      ymm2,ymm2,ymm3
       vptest    ymm2,ymm2
       jne       short M05_L15
       add       rax,40
       cmp       rax,rdx
       jb        short M05_L14
       jmp       short M05_L16
M05_L15:
       sub       rax,rcx
       shr       rax,1
       vpermq    ymm0,ymm2,0D8
       vpmovmskb r9d,ymm0
       xor       ecx,ecx
       tzcnt     ecx,r9d
       add       eax,ecx
       jmp       near ptr M05_L20
M05_L16:
       add       r9d,0FFFFFFF0
       movsxd    rdx,r9d
       lea       rdx,[rcx+rdx*2]
       cmp       rax,rdx
       cmova     rax,rdx
       vmovups   ymm2,[rax]
       vpackuswb ymm2,ymm2,[rdx]
       vpcmpeqb  ymm0,ymm0,ymm2
       vpcmpeqb  ymm1,ymm1,ymm2
       vpor      ymm0,ymm1,ymm0
       vptest    ymm0,ymm0
       je        near ptr M05_L12
       vpermq    ymm0,ymm0,0D8
       vpmovmskb r8d,ymm0
       tzcnt     r8d,r8d
       cmp       r8d,10
       jl        short M05_L17
       mov       rax,rdx
       add       r8d,0FFFFFFF0
M05_L17:
       sub       rax,rcx
       shr       rax,1
       add       eax,r8d
       jmp       short M05_L20
M05_L18:
       vmovd     xmm0,edx
       vpbroadcastb xmm0,xmm0
       vmovd     xmm1,r8d
       vpbroadcastb xmm1,xmm1
       lea       eax,[r9-8]
       cdqe
       lea       rax,[rcx+rax*2]
       cmp       rcx,rax
       mov       rdx,rcx
       cmova     rdx,rax
       vmovups   xmm2,[rdx]
       vpackuswb xmm2,xmm2,[rax]
       vpcmpeqb  xmm0,xmm0,xmm2
       vpcmpeqb  xmm1,xmm1,xmm2
       vpor      xmm0,xmm1,xmm0
       vptest    xmm0,xmm0
       je        near ptr M05_L12
       vpmovmskb r8d,xmm0
       tzcnt     r8d,r8d
       cmp       r8d,8
       jl        short M05_L19
       mov       rdx,rax
       add       r8d,0FFFFFFF8
M05_L19:
       sub       rdx,rcx
       shr       rdx,1
       lea       eax,[rdx+r8]
M05_L20:
       vzeroupper
       ret
; Total bytes of code 554
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       edx,[rbx+1C]
       add       edx,[rbx+18]
       je        short M06_L02
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFED6EDF840
       mov       rsi,rax
M06_L00:
       mov       r8d,[rbx+18]
       test      r8d,r8d
       jle       short M06_L01
       mov       rdx,[rbx+8]
       mov       ecx,[rbx+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rsi+8]
       ja        short M06_L03
       cmp       [rdx+8],r8d
       jb        short M06_L03
       movsxd    rcx,ecx
       lea       rcx,[rsi+rcx*2+0C]
       movsxd    r8,r8d
       add       r8,r8
       add       rdx,10
       call      qword ptr [7FFE77295818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M06_L01:
       mov       rbx,[rbx+10]
       test      rbx,rbx
       jne       short M06_L00
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M06_L02:
       mov       rax,24DF2D20008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M06_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,196A5
       mov       rdx,7FFE771D4000
       call      qword ptr [7FFE775176F0]
       mov       rbx,rax
       call      qword ptr [7FFE77A55908]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE77885C50]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 201
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
; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
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
       mov       [rbp-40],rax
       mov       ebx,ecx
       mov       esi,edx
       lea       rcx,[rbp-78]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rdi,rax
       mov       r9,rsp
       mov       [rbp-60],r9
       mov       r9,rbp
       mov       [rbp-50],r9
       mov       r8d,10
       mov       r9d,50
       test      sil,sil
       cmovne    r8d,r9d
       xor       r9d,r9d
       mov       [rbp-40],r9
       lea       r9,[rbp-40]
       mov       edx,ebx
       mov       rcx,offset MT_System.Char[]
       mov       rax,7FFE773F0AF8
       mov       [rbp-68],rax
       lea       rax,[M08_L00]
       mov       [rbp-58],rax
       lea       rax,[rbp-78]
       mov       [rdi+8],rax
       mov       byte ptr [rdi+4],0
       mov       rax,7FFED6EB03F0
       call      rax
M08_L00:
       mov       byte ptr [rdi+4],1
       cmp       dword ptr [7FFED71EE808],0
       je        short M08_L01
       call      qword ptr [7FFED71DC608]; CORINFO_HELP_STOP_FOR_GC
M08_L01:
       mov       rax,[rbp-70]
       mov       [rdi+8],rax
       mov       rax,[rbp-40]
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
; Total bytes of code 202
```
```assembly
; System.Text.StringBuilder.AppendWithExpansion(Char)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       mov       rcx,rbx
       mov       edx,1
       call      qword ptr [7FFED6D09920]; Precode of System.Text.StringBuilder.ExpandByABlock(Int32)
       mov       rax,[rbx+8]
       cmp       dword ptr [rax+8],0
       jbe       short M09_L00
       mov       [rax+10],si
       inc       dword ptr [rbx+18]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M09_L00:
       call      qword ptr [7FFED6CEEFC8]
       int       3
; Total bytes of code 56
```
```assembly
; System.SpanHelpers.Fill[[System.Char, System.Private.CoreLib]](Char ByRef, UIntPtr, Char)
       cmp       rdx,10
       jae       short M10_L05
       xor       eax,eax
       cmp       rdx,8
       jae       short M10_L10
M10_L00:
       test      dl,4
       jne       near ptr M10_L12
M10_L01:
       test      dl,2
       jne       short M10_L04
M10_L02:
       test      dl,1
       je        short M10_L03
       mov       [rcx+rax*2],r8w
M10_L03:
       vzeroupper
       ret
M10_L04:
       mov       [rcx+rax*2],r8w
       mov       [rcx+rax*2+2],r8w
       add       rax,2
       jmp       short M10_L02
M10_L05:
       vmovd     xmm0,r8d
       vpbroadcastw ymm0,xmm0
       lea       rax,[rdx+rdx]
       mov       r8,rax
       and       r8,0FFFFFFFFFFFFFFC0
       xor       r10d,r10d
       cmp       rdx,20
       jb        short M10_L07
M10_L06:
       vmovups   [rcx+r10],ymm0
       vmovups   [rcx+r10+20],ymm0
       add       r10,40
       cmp       r10,r8
       jb        short M10_L06
M10_L07:
       test      al,20
       jne       short M10_L09
M10_L08:
       vmovups   [rcx+rax-20],ymm0
       jmp       short M10_L03
M10_L09:
       vmovups   [rcx+r10],ymm0
       jmp       short M10_L08
M10_L10:
       mov       r10,rdx
       and       r10,0FFFFFFFFFFFFFFF8
M10_L11:
       mov       [rcx+rax*2],r8w
       mov       [rcx+rax*2+2],r8w
       mov       [rcx+rax*2+4],r8w
       mov       [rcx+rax*2+6],r8w
       mov       [rcx+rax*2+8],r8w
       mov       [rcx+rax*2+0A],r8w
       mov       [rcx+rax*2+0C],r8w
       mov       [rcx+rax*2+0E],r8w
       add       rax,8
       cmp       rax,r10
       jb        short M10_L11
       jmp       near ptr M10_L00
M10_L12:
       mov       [rcx+rax*2],r8w
       mov       [rcx+rax*2+2],r8w
       mov       [rcx+rax*2+4],r8w
       mov       [rcx+rax*2+6],r8w
       add       rax,4
       jmp       near ptr M10_L01
; Total bytes of code 231
```
```assembly
; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rdi,rdx
       mov       esi,r8d
       mov       eax,[rbx+1C]
       mov       ecx,[rbx+18]
       add       eax,ecx
       add       eax,esi
       cmp       eax,[rbx+20]
       jg        near ptr M11_L04
       cmp       eax,esi
       jl        near ptr M11_L04
       mov       rax,[rbx+8]
       mov       ebp,[rax+8]
       sub       ebp,ecx
       test      ebp,ebp
       jle       short M11_L01
       test      rax,rax
       je        near ptr M11_L05
       mov       edx,[rax+8]
       cmp       edx,ecx
       jb        near ptr M11_L06
       mov       r8d,ecx
       lea       rax,[rax+r8*2+10]
       sub       edx,ecx
M11_L00:
       cmp       ebp,edx
       ja        near ptr M11_L11
       mov       r8d,ebp
       add       r8,r8
       mov       rcx,rax
       mov       rdx,rdi
       call      qword ptr [7FFE77295818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rdx,[rbx+8]
       mov       edx,[rdx+8]
       mov       [rbx+18],edx
M11_L01:
       sub       esi,ebp
       mov       edx,[rbx+1C]
       lea       ecx,[rsi+rdx]
       mov       eax,[rbx+18]
       add       ecx,eax
       cmp       ecx,[rbx+20]
       jg        near ptr M11_L07
       cmp       ecx,esi
       jl        near ptr M11_L07
       add       edx,eax
       mov       ecx,edx
       mov       eax,1F40
       cmp       ecx,1F40
       cmovg     ecx,eax
       cmp       esi,ecx
       cmovge    ecx,esi
       add       edx,ecx
       cmp       edx,ecx
       jl        near ptr M11_L08
       cmp       ecx,400
       jge       near ptr M11_L09
       movsxd    rdx,ecx
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
M11_L02:
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       ecx,[rbx+18]
       mov       [r15+18],ecx
       mov       ecx,[rbx+1C]
       mov       [r15+1C],ecx
       mov       rdx,[rbx+8]
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbx+10]
       lea       rcx,[r15+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rbx+20]
       mov       [r15+20],ecx
       lea       rcx,[rbx+10]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rbx+18]
       add       [rbx+1C],ecx
       xor       ecx,ecx
       mov       [rbx+18],ecx
       lea       rcx,[rbx+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       movsxd    r8,ebp
       lea       rdx,[rdi+r8*2]
       mov       r8,[rbx+8]
       test      r8,r8
       je        near ptr M11_L10
       lea       rcx,[r8+10]
       mov       r8d,[r8+8]
M11_L03:
       cmp       esi,r8d
       ja        near ptr M11_L11
       mov       r8d,esi
       add       r8,r8
       call      qword ptr [7FFE77295818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       [rbx+18],esi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M11_L04:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,196D5
       mov       rdx,7FFE771D4000
       call      qword ptr [7FFE775176F0]
       mov       rsi,rax
       call      qword ptr [7FFE77A56A78]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE77885C50]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M11_L05:
       test      ecx,ecx
       jne       short M11_L06
       xor       eax,eax
       xor       edx,edx
       jmp       near ptr M11_L00
M11_L06:
       call      qword ptr [7FFE774370D8]
       int       3
M11_L07:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,196EB
       mov       rdx,7FFE771D4000
       call      qword ptr [7FFE775176F0]
       mov       rsi,rax
       call      qword ptr [7FFE77A56A90]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE77885C50]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M11_L08:
       mov       rcx,offset MT_System.OutOfMemoryException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE77A56AA8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M11_L09:
       xor       edx,edx
       call      qword ptr [7FFE7790DED8]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       r14,rax
       jmp       near ptr M11_L02
M11_L10:
       xor       ecx,ecx
       xor       r8d,r8d
       jmp       near ptr M11_L03
M11_L11:
       call      qword ptr [7FFE777A7F30]
       int       3
; Total bytes of code 621
```

## .NET 10.0.0 (10.0.25.45207), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark.BuiltInTypes()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       call      qword ptr [7FFE779BE898]; DotNetTips.Spargine.Core.TypeHelper.get_BuiltInTypes()
       mov       [rsp+28],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       ret
; Total bytes of code 56
```
```assembly
; DotNetTips.Spargine.Core.TypeHelper.get_BuiltInTypes()
; 			if (_builtInTypes == null)
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^
; 				ComputeBuiltInTypes();
; 				^^^^^^^^^^^^^^^^^^^^^^
; 			return _builtInTypes == null
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 				? new List<Type>().AsReadOnly()
; 				                               
; 				: _builtInTypes.ToList().AsReadOnly();
; 				                                      
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+70]
       mov       rbx,1B8D58020A8
       cmp       qword ptr [rbx],0
       je        near ptr M01_L07
M01_L00:
       mov       rbx,[rbx]
       test      rbx,rbx
       je        near ptr M01_L13
       mov       rdx,rbx
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<System.Type>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M01_L08
       mov       rcx,offset MT_System.Collections.Generic.List<System.Type>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdi,[rbx]
       mov       r14,offset MT_System.Collections.Generic.HashSet<System.Type>
       cmp       rdi,r14
       jne       near ptr M01_L09
       mov       r15d,[rbx+28]
       sub       r15d,[rbx+30]
M01_L01:
       test      r15d,r15d
       je        near ptr M01_L10
       movsxd    rdx,r15d
       mov       rcx,offset MT_System.Type[]
       call      CORINFO_HELP_NEWARR_1_PTR
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       r13,[rsi+8]
       cmp       rdi,r14
       jne       near ptr M01_L12
       xor       edi,edi
       mov       r14d,[rbx+28]
       sub       r14d,[rbx+30]
       js        near ptr M01_L11
       mov       r8d,[r13+8]
       cmp       [r13+8],r14d
       jl        near ptr M01_L06
       mov       r12,[rbx+10]
       xor       eax,eax
       cmp       dword ptr [rbx+28],0
       jle       short M01_L04
M01_L02:
       test      r14d,r14d
       je        short M01_L04
       cmp       eax,[r12+8]
       jae       near ptr M01_L14
       mov       [rbp-48],rax
       mov       r8,rax
       shl       r8,4
       lea       r8,[r12+r8+10]
       cmp       dword ptr [r8+0C],0FFFFFFFF
       jl        short M01_L03
       lea       edx,[rdi+1]
       mov       [rbp-3C],edx
       mov       r8,[r8]
       movsxd    rdx,edi
       mov       rcx,r13
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       dec       r14d
       mov       edi,[rbp-3C]
M01_L03:
       mov       rax,[rbp-48]
       inc       eax
       mov       rcx,rax
       cmp       ecx,[rbx+28]
       mov       rax,rcx
       jl        short M01_L02
M01_L04:
       mov       [rsi+10],r15d
M01_L05:
       cmp       [rsi],sil
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<System.Type>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L06:
       mov       ecx,6
       call      qword ptr [7FFE7826DDD0]
       int       3
M01_L07:
       call      qword ptr [7FFE779BE8C8]; DotNetTips.Spargine.Core.TypeHelper.ComputeBuiltInTypes()
       jmp       near ptr M01_L00
M01_L08:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+38]
       mov       rsi,rax
       jmp       short M01_L05
M01_L09:
       mov       rcx,rbx
       mov       r11,7FFE77200C58
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       near ptr M01_L01
M01_L10:
       mov       rcx,1B8D5801AD8
       mov       rdx,[rcx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L05
M01_L11:
       mov       ecx,28F
       mov       rdx,7FFE771F4000
       call      qword ptr [7FFE775376F0]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FFE77EE57E8]
       int       3
M01_L12:
       mov       rcx,rbx
       mov       rdx,r13
       mov       r11,7FFE77200C60
       xor       r8d,r8d
       call      qword ptr [r11]
       jmp       near ptr M01_L04
M01_L13:
       mov       rcx,offset MT_System.Collections.Generic.List<System.Type>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE77716130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<System.Type>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFE777C5728]; System.Collections.ObjectModel.ReadOnlyCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IList`1<System.__Canon>)
       mov       rax,rsi
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L14:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 597
```

## .NET 10.0.0 (10.0.25.45207), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark.CreateNormal()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rcx,201F9E80090
       mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person
       mov       eax,[rax]
       and       eax,0C0000
       cmp       eax,40000
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M00_L01
       call      qword ptr [7FFE772A7BA0]; System.RuntimeType.CreateInstanceOfT()
M00_L00:
       xor       ecx,ecx
       mov       [rsp+28],rcx
       mov       [rsp+20],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       ret
M00_L01:
       xor       edx,edx
       mov       [rsp+28],rdx
       lea       rdx,[rsp+28]
       call      qword ptr [7FFE77A66A30]
       mov       rax,[rsp+28]
       jmp       short M00_L00
; Total bytes of code 135
```
```assembly
; System.RuntimeType.CreateInstanceOfT()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       lea       rbp,[rsp+40]
       mov       rbx,rcx
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        near ptr M01_L04
       mov       rax,[rcx]
       test      rax,rax
       je        near ptr M01_L04
M01_L00:
       mov       rdx,[rax+80]
       test      rdx,rdx
       je        short M01_L03
       mov       rcx,[rdx]
       mov       rax,offset MT_System.RuntimeType+ActivatorCache
       cmp       rcx,rax
       je        short M01_L01
       mov       rax,offset MT_System.RuntimeType+CompositeCacheEntry
       cmp       rcx,rax
       jne       short M01_L03
       mov       rsi,[rdx+8]
       test      rsi,rsi
       je        short M01_L03
       jmp       short M01_L02
M01_L01:
       mov       rsi,rdx
M01_L02:
       cmp       byte ptr [rsi+28],0
       je        short M01_L05
       mov       rax,[rsi+8]
       mov       rcx,[rsi+10]
       call      rax
       mov       rdi,rax
       mov       rax,[rsi+18]
       mov       rcx,rdi
       call      rax
       nop
       mov       rax,rdi
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L03:
       mov       rdx,rbx
       mov       rcx,offset MT_System.RuntimeType+IGenericCacheEntry<System.RuntimeType+ActivatorCache>
       call      qword ptr [7FFE772AC4C8]; System.RuntimeType+IGenericCacheEntry`1[[System.__Canon, System.Private.CoreLib]].CreateAndCache(System.RuntimeType)
       mov       rsi,rax
       jmp       short M01_L02
M01_L04:
       mov       rcx,rbx
       call      qword ptr [7FFE772A7C00]; System.RuntimeType.InitializeCache()
       jmp       near ptr M01_L00
M01_L05:
       mov       rcx,offset MT_System.MissingMethodException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE77A66A78]
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFE77A66A90]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE77A66AA8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
       sub       rsp,28
       mov       rdi,rcx
       mov       rcx,offset MT_System.Reflection.TargetInvocationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,rdi
       call      qword ptr [7FFE77A66AC0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 282
```

## .NET 10.0.0 (10.0.25.45207), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark.DoesObjectEqualInstance()
       mov       rax,[rcx+50]
       cmp       rax,[rcx+58]
       sete      al
       movzx     eax,al
       mov       rcx,[rcx+18]
       mov       [rcx+4C],al
       ret
; Total bytes of code 22
```

## .NET 10.0.0 (10.0.25.45207), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark.GetAllAbstractMethods()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,294FAF57028
       call      qword ptr [7FFE779AEA30]; DotNetTips.Spargine.Core.TypeHelper.GetAllAbstractMethods(System.Type)
       mov       [rsp+28],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       ret
; Total bytes of code 66
```
```assembly
; DotNetTips.Spargine.Core.TypeHelper.GetAllAbstractMethods(System.Type)
; 		type = type.ArgumentNotNull();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var cacheKey = $"{type.FullName}.GetAllAbstractMethods";
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		if (_methodCache.TryGetValue<MethodInfo[]>(cacheKey, out var cachedMethods))
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			return Array.AsReadOnly(cachedMethods!);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var methods = type.GetTypeInfo().DeclaredMethods.Where(m => m.IsAbstract).ToArray();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		_methodCache.AddCacheItem(cacheKey, methods, TimeSpan.FromMinutes(5));
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return Array.AsReadOnly(methods);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,88
       xor       eax,eax
       mov       [rsp+68],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+70],xmm4
       mov       [rsp+80],rax
       mov       rbx,rcx
       test      rbx,rbx
       je        near ptr M01_L38
       mov       rcx,offset MT_System.RuntimeType
       cmp       [rbx],rcx
       jne       near ptr M01_L42
       cmp       qword ptr [rbx+10],0
       je        short M01_L00
       mov       rcx,[rbx+10]
       mov       rsi,[rcx]
       test      rsi,rsi
       jne       short M01_L02
M01_L00:
       mov       [rsp+0D0],rbx
       mov       rcx,rbx
       call      qword ptr [7FFE772A7C00]; System.RuntimeType.InitializeCache()
       mov       rdi,rax
       mov       rbx,[rsp+0D0]
M01_L01:
       mov       rsi,[rdi+20]
       test      rsi,rsi
       jne       near ptr M01_L09
       mov       [rsp+48],rdi
       mov       rcx,[rdi+8]
       cmp       [rcx],ecx
       call      qword ptr [7FFE772AC678]; System.Type.GetRootElementType()
       mov       rsi,rax
       mov       [rsp+40],rsi
       mov       rcx,offset MT_System.RuntimeType
       cmp       [rsi],rcx
       jne       near ptr M01_L18
       mov       rcx,[rsi+18]
       test      cl,2
       jne       short M01_L03
       mov       eax,[rcx]
       and       eax,80000030
       cmp       eax,30
       sete      al
       movzx     eax,al
       jmp       short M01_L04
M01_L02:
       mov       rdi,rsi
       jmp       short M01_L01
M01_L03:
       xor       eax,eax
M01_L04:
       test      eax,eax
       jne       short M01_L06
       mov       rcx,offset MT_System.RuntimeType
       cmp       [rsi],rcx
       jne       near ptr M01_L19
       mov       rcx,rsi
       call      qword ptr [7FFE772AC678]; System.Type.GetRootElementType()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+98]
       call      qword ptr [rax+8]
       test      rax,rax
       je        near ptr M01_L39
       mov       rcx,rax
       call      00007FFED6EA1090
M01_L05:
       test      eax,eax
       jne       near ptr M01_L40
M01_L06:
       mov       rcx,offset MT_System.RuntimeType
       cmp       [rsi],rcx
       jne       near ptr M01_L20
       mov       [rsp+0D0],rbx
       mov       rcx,[rsi+18]
       mov       rax,7FFED6E9E4E0
       vzeroupper
       call      rax
       movzx     ebx,al
       cmp       dword ptr [7FFED71EE808],0
       jne       near ptr M01_L41
M01_L07:
       cmp       ebx,1B
       mov       rbx,[rsp+0D0]
       je        near ptr M01_L40
M01_L08:
       mov       rdi,[rsp+48]
       lea       rdx,[rdi+20]
       mov       rcx,rdi
       mov       r8d,3
       call      qword ptr [7FFE77444A50]; System.RuntimeType+RuntimeTypeCache.ConstructName(System.String ByRef, System.TypeNameFormatFlags)
       mov       rsi,rax
M01_L09:
       test      rsi,rsi
       je        near ptr M01_L43
       mov       edi,[rsi+8]
       test      edi,edi
       je        near ptr M01_L43
       mov       ebp,edi
       lea       edx,[rbp+16]
       test      edx,edx
       jl        near ptr M01_L44
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFED6EDF840
       mov       r14,rax
       cmp       [r14],r14b
       lea       rcx,[r14+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFE772A5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       eax,ebp
       lea       rax,[r14+rax*2+0C]
       vmovups   ymm0,[7FFE77B07540]
       vmovups   [rax],ymm0
       mov       rcx,6F006800740065
       mov       [rax+20],rcx
       mov       dword ptr [rax+28],730064
M01_L10:
       mov       [rsp+50],r14
       mov       rcx,254660020B8
       mov       rsi,[rcx]
       mov       edi,[r14+8]
       test      edi,edi
       je        near ptr M01_L45
       movzx     ecx,word ptr [r14+0C]
       cmp       ecx,100
       jge       near ptr M01_L47
       mov       rax,7FFED6077778
       test      byte ptr [rax+rcx],80
       jne       near ptr M01_L49
M01_L11:
       dec       edi
       mov       ecx,edi
       movzx     ecx,word ptr [r14+rcx*2+0C]
       cmp       ecx,100
       jge       near ptr M01_L48
       mov       rax,7FFED6077778
       test      byte ptr [rax+rcx],80
       jne       near ptr M01_L49
M01_L12:
       mov       rdi,r14
M01_L13:
       mov       rsi,[rsi+10]
       mov       [rsp+30],rsi
       cmp       [rsi],sil
       mov       [rsp+38],rdi
       test      rdi,rdi
       je        near ptr M01_L50
       cmp       byte ptr [rsi+3C],0
       jne       near ptr M01_L51
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+8]
       test      rcx,rcx
       jne       near ptr M01_L54
       mov       [rsp+0D0],rbx
       lea       rcx,[rsp+68]
       mov       rax,7FFFEE1B5380
       call      rax
       mov       rbx,[rsp+68]
       mov       rax,25466001A80
       mov       rsi,[rax]
       sub       rbx,[rsi+8]
       cmp       dword ptr [7FFED71EE808],0
       jne       near ptr M01_L52
M01_L14:
       mov       eax,0B2D05E00
       cmp       rbx,rax
       jae       near ptr M01_L53
       add       rbx,[rsi+10]
M01_L15:
       mov       rsi,[rsp+30]
       mov       rbp,[rsi+30]
       mov       rcx,[rbp+8]
       mov       rdi,[rsp+38]
       mov       r15,[rcx+8]
       mov       r13,[r15+8]
       cmp       byte ptr [rcx+19],0
       jne       near ptr M01_L21
       mov       rcx,r13
       mov       rdx,rdi
       mov       r11,7FFE771F0B50
       call      qword ptr [r11]
       mov       r12d,eax
M01_L16:
       mov       rcx,[r15+10]
       mov       edx,r12d
       imul      rdx,[r15+28]
       shr       rdx,20
       inc       rdx
       mov       r8d,[rcx+8]
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,[rcx+8]
       jae       near ptr M01_L85
       mov       edx,edx
       mov       r15,[rcx+rdx*8+10]
       test      r15,r15
       je        near ptr M01_L64
       test      r13,r13
       je        near ptr M01_L36
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer+OrdinalComparer
       cmp       [r13],rcx
       jne       near ptr M01_L36
M01_L17:
       cmp       r12d,[r15+20]
       jne       near ptr M01_L57
       mov       rdx,[r15+8]
       cmp       rdx,rdi
       je        near ptr M01_L55
       test      rdx,rdx
       je        near ptr M01_L56
       mov       ecx,[rdx+8]
       cmp       ecx,[rdi+8]
       jne       near ptr M01_L56
       lea       rcx,[rdx+0C]
       lea       rax,[rdi+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       r8d,edx
       cmp       r8,0A
       jne       near ptr M01_L22
       mov       rdx,[rcx]
       mov       rcx,[rcx+2]
       mov       r8,[rax]
       xor       rdx,r8
       xor       rcx,[rax+2]
       or        rcx,rdx
       sete      al
       movzx     eax,al
       jmp       short M01_L23
M01_L18:
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+60]
       call      qword ptr [rax+10]
       jmp       near ptr M01_L04
M01_L19:
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+0B0]
       call      qword ptr [rax]
       jmp       near ptr M01_L05
M01_L20:
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+60]
       call      qword ptr [rax+30]
       test      eax,eax
       jne       near ptr M01_L40
       jmp       near ptr M01_L08
M01_L21:
       mov       edx,[rdi+8]
       add       edx,edx
       lea       rcx,[rdi+0C]
       mov       r8d,0F2376F22
       mov       r9d,5E565074
       call      qword ptr [7FFE777BC840]; System.Marvin.ComputeHash32(Byte ByRef, UInt32, UInt32, UInt32)
       mov       r12d,eax
       jmp       near ptr M01_L16
M01_L22:
       mov       rdx,rax
       call      qword ptr [7FFE772AFB40]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
M01_L23:
       test      eax,eax
       je        near ptr M01_L57
M01_L24:
       mov       rdx,[r15+10]
       mov       [rsp+80],rdx
       mov       rdi,[rsp+80]
       cmp       byte ptr [rdi+43],0
       jne       near ptr M01_L69
       mov       rdx,[rdi+38]
       test      rdx,rdx
       jl        near ptr M01_L65
M01_L25:
       mov       rcx,3FFFFFFFFFFFFFFF
       and       rcx,rbx
       cmp       rdx,rcx
       jbe       near ptr M01_L66
       cmp       qword ptr [rdi+50],0
       jg        near ptr M01_L67
M01_L26:
       xor       r15d,r15d
M01_L27:
       test      r15d,r15d
       jne       near ptr M01_L69
M01_L28:
       cmp       qword ptr [rdi+10],0
       jne       near ptr M01_L68
M01_L29:
       mov       [rdi+58],rbx
       mov       r15,[rdi+20]
       cmp       byte ptr [rsi+3D],0
       jne       near ptr M01_L70
M01_L30:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+28]
       mov       rdx,[rsi+40]
       mov       rax,3FFFFFFFFFFFFFFF
       and       rax,rbx
       mov       r8,3FFFFFFFFFFFFFFF
       and       rdx,r8
       sub       rax,rdx
       cmp       rcx,rax
       jl        near ptr M01_L71
M01_L31:
       cmp       qword ptr [rsi+18],0
       jne       near ptr M01_L72
M01_L32:
       mov       r13d,1
M01_L33:
       xor       edx,edx
       mov       [rsp+80],rdx
       test      r13d,r13d
       je        near ptr M01_L77
       mov       rdx,r15
       mov       rcx,offset MT_System.Reflection.MethodInfo[]
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
       test      rax,rax
       je        near ptr M01_L77
       mov       r14,r15
       test      r14,r14
       je        short M01_L34
       mov       rcx,offset MT_System.Reflection.MethodInfo[]
       cmp       [r14],rcx
       je        short M01_L34
       mov       rdx,r15
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       r14,rax
M01_L34:
       test      r14,r14
       je        near ptr M01_L78
       cmp       dword ptr [r14+8],0
       jne       near ptr M01_L79
       mov       rcx,25466002198
       mov       rax,[rcx]
M01_L35:
       vzeroupper
       add       rsp,88
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
       cmp       r12d,[r15+20]
       jne       near ptr M01_L63
       mov       rdx,[r15+8]
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer+OrdinalComparer
       cmp       [r13],rcx
       jne       near ptr M01_L58
       cmp       rdx,rdi
       je        near ptr M01_L62
       test      rdx,rdx
       je        near ptr M01_L61
       mov       ecx,[rdx+8]
       cmp       ecx,[rdi+8]
       jne       near ptr M01_L61
       add       rdx,0C
       lea       rax,[rdi+0C]
       add       ecx,ecx
       mov       r8d,ecx
       cmp       r8,0A
       jne       near ptr M01_L59
       jmp       near ptr M01_L60
M01_L37:
       test      eax,eax
       je        near ptr M01_L63
       jmp       near ptr M01_L24
M01_L38:
       call      qword ptr [7FFE7791DEC0]
       mov       ecx,20E7
       mov       rdx,7FFE77645418
       call      qword ptr [7FFE775276F0]
       mov       rbx,rax
       mov       ecx,1B55
       mov       rdx,7FFE77645418
       call      qword ptr [7FFE775276F0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE772A7810]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,110B
       mov       rdx,7FFE77645418
       call      qword ptr [7FFE775276F0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE772A7810]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE77A7CDC8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE77A7C018]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M01_L39:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE77A7C000]
       mov       r8,rax
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFE77A7C018]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M01_L40:
       xor       esi,esi
       jmp       near ptr M01_L09
M01_L41:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M01_L07
M01_L42:
       mov       rcx,rbx
       mov       [rsp+0D0],rbx
       mov       rax,[rbx]
       mov       rax,[rax+50]
       call      qword ptr [rax+20]
       mov       rsi,rax
       mov       rbx,[rsp+0D0]
       jmp       near ptr M01_L09
M01_L43:
       mov       r14,294FAF60090
       jmp       near ptr M01_L10
M01_L44:
       call      qword ptr [7FFE77A771B0]
       int       3
M01_L45:
       call      qword ptr [7FFE7770FD08]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L46
       call      qword ptr [7FFE77A7CDC8]
       mov       rbx,rax
M01_L46:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,294FAF59690
       call      qword ptr [7FFE77A7C018]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M01_L47:
       call      qword ptr [7FFE77A76C28]
       test      eax,eax
       jne       short M01_L49
       jmp       near ptr M01_L11
M01_L48:
       call      qword ptr [7FFE77A76C28]
       test      eax,eax
       je        near ptr M01_L12
M01_L49:
       mov       rcx,r14
       mov       edx,3
       call      qword ptr [7FFE77A76C40]
       mov       rdi,rax
       mov       r14,[rsp+50]
       jmp       near ptr M01_L13
M01_L50:
       mov       ecx,117
       mov       rdx,7FFE77A433D0
       call      qword ptr [7FFE775276F0]
       mov       rcx,rax
       call      qword ptr [7FFE779AEE68]
       int       3
M01_L51:
       call      qword ptr [7FFE779AF360]
       int       3
M01_L52:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M01_L14
M01_L53:
       call      qword ptr [7FFE77895DA0]; System.DateTime.UpdateLeapSecondCacheAndReturnUtcNow()
       mov       rbx,rax
       jmp       near ptr M01_L15
M01_L54:
       lea       rdx,[rsp+70]
       mov       r11,7FFE771F0B40
       call      qword ptr [r11]
       lea       rcx,[rsp+70]
       call      qword ptr [7FFE779AF1F8]
       mov       [rsp+0D0],rbx
       mov       rbx,rax
       jmp       near ptr M01_L15
M01_L55:
       mov       eax,1
       jmp       near ptr M01_L23
M01_L56:
       xor       eax,eax
       jmp       near ptr M01_L23
M01_L57:
       mov       r15,[r15+18]
       test      r15,r15
       jne       near ptr M01_L17
       jmp       short M01_L64
M01_L58:
       mov       rcx,r13
       mov       r8,rdi
       mov       r11,7FFE771F0B48
       call      qword ptr [r11]
       jmp       near ptr M01_L37
M01_L59:
       mov       rcx,rdx
       mov       rdx,rax
       call      qword ptr [7FFE772AFB40]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L37
M01_L60:
       mov       rcx,rdx
       mov       r8,rax
       mov       rdx,[rcx]
       mov       rcx,[rcx+2]
       mov       r11,[r8]
       xor       rdx,r11
       xor       rcx,[r8+2]
       or        rcx,rdx
       sete      al
       movzx     eax,al
       jmp       near ptr M01_L37
M01_L61:
       xor       eax,eax
       jmp       near ptr M01_L37
M01_L62:
       mov       eax,1
       jmp       near ptr M01_L37
M01_L63:
       mov       r15,[r15+18]
       test      r15,r15
       jne       near ptr M01_L36
M01_L64:
       xor       edx,edx
       mov       [rsp+80],rdx
       jmp       near ptr M01_L74
M01_L65:
       cmp       qword ptr [rdi+50],0
       je        near ptr M01_L28
       jmp       near ptr M01_L25
M01_L66:
       mov       rcx,rdi
       mov       edx,3
       call      qword ptr [7FFE779AFA38]
       mov       r15d,1
       jmp       near ptr M01_L27
M01_L67:
       mov       rdx,[rdi+58]
       mov       rcx,rbx
       call      qword ptr [7FFE779AF390]; System.DateTime.op_Subtraction(System.DateTime, System.DateTime)
       mov       rcx,rax
       mov       rdx,[rdi+50]
       call      qword ptr [7FFE779AFB70]
       test      eax,eax
       jne       short M01_L66
       jmp       near ptr M01_L26
M01_L68:
       mov       rcx,[rdi+10]
       mov       rdx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFE779AFB28]
       test      eax,eax
       je        near ptr M01_L29
M01_L69:
       cmp       byte ptr [rdi+45],2
       jne       short M01_L73
       jmp       near ptr M01_L29
M01_L70:
       mov       rcx,rdi
       call      qword ptr [7FFE779AF2E8]
       jmp       near ptr M01_L30
M01_L71:
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFE779AF3C0]
       jmp       near ptr M01_L31
M01_L72:
       mov       rcx,[rsi+28]
       cmp       [rcx],ecx
       call      qword ptr [7FFE77A7CEA0]
       inc       qword ptr [rax+10]
       jmp       near ptr M01_L32
M01_L73:
       mov       r8,[rsi+10]
       mov       rcx,rbp
       mov       rdx,rdi
       call      qword ptr [7FFE779AF348]
M01_L74:
       mov       rdx,[rsi+10]
       mov       r15,[rdx+28]
       mov       rdx,[rsi+40]
       mov       rcx,rbx
       call      qword ptr [7FFE779AF390]; System.DateTime.op_Subtraction(System.DateTime, System.DateTime)
       cmp       r15,rax
       jge       short M01_L75
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFE779AF3C0]
M01_L75:
       xor       r15d,r15d
       cmp       qword ptr [rsi+18],0
       je        short M01_L76
       mov       rcx,[rsi+28]
       cmp       [rcx],ecx
       call      qword ptr [7FFE77A7CEA0]
       inc       qword ptr [rax+18]
M01_L76:
       xor       r13d,r13d
       jmp       near ptr M01_L33
M01_L77:
       mov       rcx,[rsp+0D0]
       call      qword ptr [7FFE7752E070]; System.Reflection.IntrospectionExtensions.GetTypeInfo(System.Type)
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+0C0]
       call      qword ptr [rax+10]
       mov       rbx,rax
       mov       rcx,254660020E8
       mov       r8,[rcx]
       test      r8,r8
       jne       short M01_L81
       jmp       short M01_L80
M01_L78:
       mov       ecx,2
       call      qword ptr [7FFE7752C180]
       int       3
M01_L79:
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<System.Reflection.MethodInfo>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,r14
       call      qword ptr [7FFE777B5728]; System.Collections.ObjectModel.ReadOnlyCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IList`1<System.__Canon>)
       mov       rax,rbx
       jmp       near ptr M01_L35
M01_L80:
       mov       rcx,offset MT_System.Func<System.Reflection.MethodInfo, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,254660020C8
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Core.TypeHelper+<>c.<GetAllAbstractMethods>b__16_0(System.Reflection.MethodInfo)
       call      qword ptr [7FFE772A6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,254660020E8
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rsi
M01_L81:
       mov       rdx,rbx
       mov       rcx,7FFE77A41A88
       call      qword ptr [7FFE77704090]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rdx,rax
       mov       rcx,7FFE77A41B10
       call      qword ptr [7FFE77706358]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rbx,rax
       mov       ecx,5
       call      qword ptr [7FFE779AEB20]; System.TimeSpan.FromMinutes(Int64)
       mov       rsi,rax
       mov       rcx,254660020B8
       mov       rdi,[rcx]
       mov       r14,[rsp+50]
       mov       ecx,[r14+8]
       xor       ecx,ecx
       je        short M01_L83
       call      qword ptr [7FFE7770FD08]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L82
       call      qword ptr [7FFE77A7CDC8]
       mov       rbx,rax
M01_L82:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,294FAF59690
       call      qword ptr [7FFE77A7C018]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M01_L83:
       mov       rcx,r14
       call      qword ptr [7FFE7770FD50]; System.String.Trim()
       mov       rbp,rax
       test      rbx,rbx
       jne       near ptr M01_L84
       call      qword ptr [7FFE7791DEC0]
       mov       ecx,1FF3
       mov       rdx,7FFE77645418
       call      qword ptr [7FFE775276F0]
       mov       rbx,rax
       mov       ecx,1B55
       mov       rdx,7FFE77645418
       call      qword ptr [7FFE775276F0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE772A7810]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,110B
       mov       rdx,7FFE77645418
       call      qword ptr [7FFE775276F0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE772A7810]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE77A7CDC8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE77A7C018]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M01_L84:
       mov       rcx,offset MT_Microsoft.Extensions.Caching.Memory.MemoryCacheEntryOptions
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdi,[rdi+10]
       mov       rcx,r14
       call      qword ptr [7FFE779AF588]; Microsoft.Extensions.Caching.Memory.MemoryCacheEntryOptions..ctor()
       mov       byte ptr [rsp+58],1
       mov       [rsp+60],rsi
       lea       rdx,[rsp+58]
       mov       rcx,r14
       call      qword ptr [7FFE779AF600]; Microsoft.Extensions.Caching.Memory.MemoryCacheEntryOptions.set_AbsoluteExpirationRelativeToNow(System.Nullable`1<System.TimeSpan>)
       mov       [rsp+20],r14
       mov       rdx,rdi
       mov       r8,rbp
       mov       r9,rbx
       mov       rcx,7FFE77A4DC10
       call      qword ptr [7FFE779AF540]; Microsoft.Extensions.Caching.Memory.CacheExtensions.Set[[System.__Canon, System.Private.CoreLib]](Microsoft.Extensions.Caching.Memory.IMemoryCache, System.Object, System.__Canon, Microsoft.Extensions.Caching.Memory.MemoryCacheEntryOptions)
       mov       rdx,rbx
       mov       rcx,7FFE77A41CB0
       call      qword ptr [7FFE7789C210]; System.Array.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       nop
       vzeroupper
       add       rsp,88
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L85:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 3079
```

## .NET 10.0.0 (10.0.25.45207), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark.GetAllConstructors()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.TypeHelper+<GetAllConstructors>d__17
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       dword ptr [rsi+28],0FFFFFFFE
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rsi+2C],eax
       mov       rcx,234D4197028
       mov       [rsi+18],rcx
       mov       [rsp+20],rsi
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 99
```

## .NET 10.0.0 (10.0.25.45207), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark.GetAllDeclaredFields()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.TypeHelper+<GetAllDeclaredFields>d__18
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       dword ptr [rsi+28],0FFFFFFFE
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rsi+2C],eax
       mov       rcx,2156DA87028
       mov       [rsi+18],rcx
       mov       [rsp+20],rsi
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 99
```

## .NET 10.0.0 (10.0.25.45207), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark.GetAllDeclaredMethods()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.TypeHelper+<GetAllDeclaredMethods>d__19
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       dword ptr [rsi+28],0FFFFFFFE
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rsi+2C],eax
       mov       rcx,1FEDE527028
       mov       [rsi+18],rcx
       mov       [rsp+20],rsi
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 99
```

## .NET 10.0.0 (10.0.25.45207), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark.GetAllFields()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.TypeHelper+<GetAllFields>d__20
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       dword ptr [rsi+28],0FFFFFFFE
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rsi+2C],eax
       mov       rcx,1FBF5717028
       mov       [rsi+18],rcx
       mov       [rsp+20],rsi
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 99
```

## .NET 10.0.0 (10.0.25.45207), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark.GetAllGenericMethods()
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,198
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       mov       rax,0FFFFFFFFFFFFFEB0
M00_L00:
       vmovdqa   xmmword ptr [rsp+rax+190],xmm4
       vmovdqa   xmmword ptr [rsp+rax+1A0],xmm4
       vmovdqa   xmmword ptr [rsp+rax+1B0],xmm4
       add       rax,30
       jne       short M00_L00
       mov       [rsp+190],rax
       mov       rbx,rcx
       mov       rcx,28711981168
       mov       rsi,[rcx]
       test      rsi,rsi
       jne       short M00_L01
       mov       rcx,2C7A863EDD8
       call      qword ptr [7FFE77287C00]; System.RuntimeType.InitializeCache()
       mov       rdi,rax
       jmp       short M00_L02
M00_L01:
       mov       rdi,rsi
M00_L02:
       cmp       [rdi],dil
       lea       rsi,[rdi+40]
       mov       rcx,[rsi]
       test      rcx,rcx
       je        near ptr M00_L24
M00_L03:
       cmp       byte ptr [rcx+18],0
       je        near ptr M00_L25
       mov       rsi,[rcx+8]
M00_L04:
       mov       edi,[rsi+8]
       mov       edx,edi
       xor       r8d,r8d
       mov       [rsp+180],r8
       mov       [rsp+188],r8
       mov       [rsp+190],r8d
       mov       [rsp+194],edx
       mov       ebp,10
       inc       edi
       jmp       short M00_L09
M00_L05:
       mov       r14,[rsi+rbp]
       mov       edx,[r14+58]
       mov       r8d,edx
       and       r8d,3C
       cmp       r8d,edx
       jne       short M00_L08
       cmp       dword ptr [rsp+190],0
       je        near ptr M00_L26
       cmp       dword ptr [rsp+190],1
       je        near ptr M00_L27
       mov       edx,[rsp+194]
       cmp       edx,[rsp+190]
       je        near ptr M00_L29
M00_L06:
       movsxd    rdx,dword ptr [rsp+190]
       mov       rcx,[rsp+180]
       mov       r8,r14
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
M00_L07:
       mov       edx,[rsp+190]
       inc       edx
       mov       [rsp+190],edx
M00_L08:
       add       rbp,8
M00_L09:
       dec       edi
       jne       short M00_L05
       mov       rsi,[rsp+180]
       mov       rdi,[rsp+188]
       mov       ebp,[rsp+190]
       test      ebp,ebp
       je        near ptr M00_L30
       cmp       ebp,1
       je        near ptr M00_L31
       test      ebp,ebp
       jl        near ptr M00_L32
       test      rsi,rsi
       je        near ptr M00_L33
       cmp       [rsi+8],ebp
       je        short M00_L11
       mov       edx,ebp
       mov       rcx,offset MT_System.Reflection.MethodInfo[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       lea       rcx,[rdi+10]
       lea       rdx,[rsi+10]
       mov       r8d,[rsi+8]
       cmp       ebp,r8d
       cmovg     ebp,r8d
       mov       r8d,ebp
       shl       r8,3
       cmp       r8,4000
       ja        near ptr M00_L35
       call      00007FFED6E70160
       cmp       dword ptr [7FFED71EE808],0
       jne       near ptr M00_L34
M00_L10:
       mov       rsi,rdi
M00_L11:
       mov       rcx,287298000D8
       mov       rdi,[rcx]
       test      rdi,rdi
       je        near ptr M00_L36
M00_L12:
       test      rsi,rsi
       je        near ptr M00_L37
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<System.Reflection.MethodInfo>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L38
       mov       rdx,rsi
       mov       rcx,offset MT_System.Reflection.MethodInfo[]
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
       mov       rbp,rax
       test      rbp,rbp
       je        near ptr M00_L40
       cmp       dword ptr [rbp+8],0
       je        near ptr M00_L39
       mov       rcx,offset MT_System.Linq.Enumerable+ArrayWhereIterator<System.Reflection.MethodInfo>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [r14+10],eax
       lea       rcx,[r14+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+20]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
M00_L13:
       mov       rdx,r14
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<System.Reflection.MethodInfo>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M00_L46
       mov       rdx,offset MT_System.Linq.Enumerable+ArrayWhereIterator<System.Reflection.MethodInfo>
       cmp       [rax],rdx
       jne       near ptr M00_L45
       mov       rdx,[rax+18]
       test      rdx,rdx
       je        near ptr M00_L18
       lea       r14,[rdx+10]
       mov       esi,[rdx+8]
M00_L14:
       mov       rdi,[rax+20]
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rsp+140],ymm0
       vmovdqu   ymmword ptr [rsp+160],ymm0
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rsp+48],ymm0
       vmovdqu   ymmword ptr [rsp+68],ymm0
       vmovdqu   ymmword ptr [rsp+88],ymm0
       vmovdqu   ymmword ptr [rsp+0A8],ymm0
       vmovdqu   ymmword ptr [rsp+0C8],ymm0
       vmovdqu   ymmword ptr [rsp+0E8],ymm0
       vmovdqu   ymmword ptr [rsp+100],ymm0
       xor       edx,edx
       mov       [rsp+38],edx
       mov       [rsp+3C],edx
       mov       [rsp+40],edx
       lea       rdx,[rsp+140]
       mov       [rsp+120],rdx
       mov       dword ptr [rsp+128],8
       lea       rdx,[rsp+140]
       mov       [rsp+130],rdx
       mov       dword ptr [rsp+138],8
       test      esi,esi
       jle       short M00_L17
       xor       ebp,ebp
M00_L15:
       mov       r15,[r14+rbp]
       mov       rdx,r15
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       test      eax,eax
       je        short M00_L16
       mov       rcx,[rsp+130]
       mov       edx,[rsp+138]
       mov       eax,[rsp+40]
       cmp       eax,edx
       jae       near ptr M00_L42
       mov       edx,eax
       lea       rcx,[rcx+rdx*8]
       mov       rdx,r15
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       ecx,[rsp+40]
       inc       ecx
       mov       [rsp+40],ecx
M00_L16:
       add       rbp,8
       dec       esi
       jne       short M00_L15
M00_L17:
       mov       esi,[rsp+3C]
       add       esi,[rsp+40]
       jo        near ptr M00_L48
       mov       eax,esi
       test      eax,eax
       je        short M00_L19
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Reflection.MethodInfo[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       mov       r8,offset MT_System.Reflection.MethodInfo[]
       cmp       [rdi],r8
       jne       near ptr M00_L43
       lea       r8,[rdi+10]
       mov       [rsp+20],r8
       mov       [rsp+28],esi
       lea       r8,[rsp+20]
       lea       rcx,[rsp+38]
       mov       rdx,offset MT_System.Collections.Generic.SegmentedArrayBuilder<System.Reflection.MethodInfo>
       call      qword ptr [7FFE77A4C660]; System.Collections.Generic.SegmentedArrayBuilder`1[[System.__Canon, System.Private.CoreLib]].ToSpanInlined(System.Span`1<System.__Canon>)
       jmp       short M00_L21
M00_L18:
       xor       r14d,r14d
       xor       esi,esi
       jmp       near ptr M00_L14
M00_L19:
       test      byte ptr [7FFE77AA60B8],1
       je        near ptr M00_L44
M00_L20:
       mov       rdx,28729800188
       mov       rdi,[rdx]
M00_L21:
       mov       r8d,[rsp+38]
       test      r8d,r8d
       jne       short M00_L23
M00_L22:
       mov       rdx,rdi
       mov       rcx,7FFE77A0D4C0
       call      qword ptr [7FFE7787C210]; System.Array.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       mov       [rsp+30],rax
       mov       rcx,[rbx+18]
       lea       r8,[rsp+30]
       mov       rdx,7FFE77A0F998
       cmp       [rcx],ecx
       call      qword ptr [7FFE7798EE20]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,198
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M00_L23:
       lea       rcx,[rsp+38]
       mov       rdx,offset MT_System.Collections.Generic.SegmentedArrayBuilder<System.Reflection.MethodInfo>
       call      qword ptr [7FFE7798EC88]; System.Collections.Generic.SegmentedArrayBuilder`1[[System.__Canon, System.Private.CoreLib]].ReturnArrays(Int32)
       jmp       short M00_L22
M00_L24:
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache+MemberInfoCache<System.Reflection.RuntimeMethodInfo>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       mov       rdx,rbp
       xor       r8d,r8d
       call      00007FFED6E8EEF0
       mov       rcx,rax
       test      rcx,rcx
       cmove     rcx,rbp
       jmp       near ptr M00_L03
M00_L25:
       xor       edx,edx
       xor       r8d,r8d
       xor       r9d,r9d
       call      qword ptr [7FFE7728D278]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
       mov       rsi,rax
       jmp       near ptr M00_L04
M00_L26:
       mov       [rsp+188],r14
       jmp       near ptr M00_L07
M00_L27:
       cmp       dword ptr [rsp+194],2
       jge       short M00_L28
       mov       dword ptr [rsp+194],4
M00_L28:
       movsxd    rdx,dword ptr [rsp+194]
       mov       rcx,offset MT_System.Reflection.MethodInfo[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       [rsp+180],rax
       mov       rcx,[rsp+180]
       mov       r8,[rsp+188]
       xor       edx,edx
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       near ptr M00_L06
M00_L29:
       mov       r15d,[rsp+194]
       add       r15d,r15d
       lea       rdx,[rsp+180]
       mov       r8d,r15d
       mov       rcx,7FFE77407580
       call      qword ptr [7FFE7728D488]; System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
       mov       [rsp+194],r15d
       jmp       near ptr M00_L06
M00_L30:
       mov       rcx,offset MT_System.Array+EmptyArray<System.Reflection.MethodInfo>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,28729800188
       mov       rsi,[rcx]
       jmp       near ptr M00_L11
M00_L31:
       mov       rcx,offset MT_System.Reflection.MethodInfo[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rdi
       xor       edx,edx
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       near ptr M00_L11
M00_L32:
       mov       ecx,45
       mov       edx,0D
       call      qword ptr [7FFE778F55A8]
       int       3
M00_L33:
       mov       edx,ebp
       mov       rcx,offset MT_System.Reflection.MethodInfo[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rsi,rax
       jmp       near ptr M00_L11
M00_L34:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L10
M00_L35:
       call      qword ptr [7FFE778FD7B8]
       jmp       near ptr M00_L10
M00_L36:
       mov       rcx,offset MT_System.Func<System.Reflection.MethodInfo, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,287298000B0
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Core.TypeHelper+<>c.<GetAllGenericMethods>b__21_0(System.Reflection.MethodInfo)
       call      qword ptr [7FFE77286BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,287298000D8
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L12
M00_L37:
       mov       ecx,11
       call      qword ptr [7FFE77507DB0]
       int       3
M00_L38:
       mov       rcx,rax
       mov       rdx,rdi
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+8]
       mov       r14,rax
       jmp       near ptr M00_L13
M00_L39:
       mov       rcx,offset MT_System.Array+EmptyArray<System.Reflection.MethodInfo>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,28729800188
       mov       r14,[rdx]
       jmp       near ptr M00_L13
M00_L40:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Generic.List<System.Reflection.MethodInfo>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r14,rax
       test      r14,r14
       je        short M00_L41
       mov       rcx,offset MT_System.Linq.Enumerable+ListWhereIterator<System.Reflection.MethodInfo>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,r14
       mov       r8,rdi
       call      qword ptr [7FFE77A4C4E0]
       mov       r14,rsi
       jmp       near ptr M00_L13
M00_L41:
       mov       rcx,offset MT_System.Linq.Enumerable+IEnumerableWhereIterator<System.Reflection.MethodInfo>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       rdx,rsi
       mov       r8,rdi
       call      qword ptr [7FFE77A4C4F8]
       jmp       near ptr M00_L13
M00_L42:
       lea       rcx,[rsp+38]
       mov       r8,r15
       mov       rdx,offset MT_System.Collections.Generic.SegmentedArrayBuilder<System.Reflection.MethodInfo>
       call      qword ptr [7FFE7798EA60]; System.Collections.Generic.SegmentedArrayBuilder`1[[System.__Canon, System.Private.CoreLib]].AddSlow(System.__Canon)
       jmp       near ptr M00_L16
M00_L43:
       call      qword ptr [7FFE77A46FB8]
       int       3
M00_L44:
       mov       rcx,offset MT_System.Array+EmptyArray<System.Reflection.MethodInfo>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L20
M00_L45:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rdi,rax
       jmp       near ptr M00_L22
M00_L46:
       mov       rdx,r14
       mov       rcx,offset MT_System.Collections.Generic.ICollection<System.Reflection.MethodInfo>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M00_L47
       mov       rdx,rax
       mov       rcx,7FFE77B746D8
       call      qword ptr [7FFE776E7738]; System.Linq.Enumerable.ICollectionToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>)
       mov       rdi,rax
       jmp       near ptr M00_L22
M00_L47:
       mov       rdx,r14
       mov       rcx,7FFE77B74760
       call      qword ptr [7FFE77A47210]
       mov       rdi,rax
       jmp       near ptr M00_L22
M00_L48:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 1926
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
       je        near ptr M01_L08
M01_L00:
       mov       rcx,[rbx+10]
       mov       rdx,[rcx]
       mov       rdi,rdx
       test      rdi,rdi
       je        short M01_L01
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache
       cmp       [rdi],rcx
       jne       near ptr M01_L09
M01_L01:
       test      rdi,rdi
       jne       near ptr M01_L07
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
       call      00007FFED6E34140
       mov       r14,rax
       test      r14,r14
       je        near ptr M01_L10
M01_L02:
       mov       rax,[r14+8]
       test      rax,rax
       jne       near ptr M01_L05
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
       mov       rax,7FFE773E6D90
       mov       [rbp-78],rax
       lea       rax,[M01_L03]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFED6DD50B0
       call      rax
M01_L03:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFED71EE808],0
       je        short M01_L04
       call      qword ptr [7FFED71DC608]; CORINFO_HELP_STOP_FOR_GC
M01_L04:
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
M01_L05:
       cmp       rax,rbx
       sete      cl
       mov       rdi,[rbp-0A0]
       mov       [rdi+9C],cl
       mov       rcx,[rbx+10]
       mov       rdx,rdi
       xor       r8d,r8d
       call      00007FFED6EB03C0
       mov       rdx,rax
       test      rdx,rdx
       je        short M01_L06
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache
       cmp       [rdx],rcx
       jne       short M01_L11
M01_L06:
       test      rdx,rdx
       cmovne    rdi,rdx
M01_L07:
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
M01_L08:
       mov       [rbp-40],rbx
       lea       rcx,[rbp-40]
       mov       edx,1
       call      qword ptr [7FFE77A4DE90]; System.RuntimeTypeHandle.GetGCHandle(System.Runtime.InteropServices.GCHandleType)
       mov       rdx,rax
       lea       rcx,[rbx+10]
       xor       eax,eax
       lock cmpxchg [rcx],rdx
       test      rax,rax
       je        near ptr M01_L00
       lea       rcx,[rbp-40]
       call      qword ptr [7FFE77A47780]
       jmp       near ptr M01_L00
M01_L09:
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M01_L10:
       mov       [rbp+10],rbx
       mov       rcx,rbx
       call      qword ptr [7FFE77287C48]; System.RuntimeTypeHandle.<GetModule>g__GetModuleWorker|48_0(System.RuntimeType)
       mov       r14,rax
       mov       rbx,[rbp+10]
       jmp       near ptr M01_L02
M01_L11:
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
       jbe       short M02_L00
       lea       rax,[rcx+rdx*8+10]
       mov       rcx,[rcx]
       mov       rdx,[rcx+30]
       test      r8,r8
       je        short M02_L02
       cmp       rdx,[r8]
       je        short M02_L01
       mov       r10,offset MT_System.Object[]
       cmp       rcx,r10
       je        short M02_L01
       mov       rcx,rax
       add       rsp,28
       jmp       qword ptr [7FFE7728D890]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
M02_L00:
       call      qword ptr [7FFE77A441E0]
       int       3
M02_L01:
       mov       rcx,rax
       mov       rdx,r8
       add       rsp,28
       jmp       near ptr 00007FFED6EDE630
M02_L02:
       xor       ecx,ecx
       mov       [rax],rcx
       add       rsp,28
       ret
; Total bytes of code 94
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
       mov       r8,28713800038
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
       jne       short M04_L04
       mov       rsi,rcx
       xor       rsi,[r11+10]
       cmp       rsi,1
       ja        short M04_L04
       cmp       ebx,[r11]
       jne       short M04_L05
M04_L01:
       cmp       esi,1
       jne       short M04_L03
M04_L02:
       mov       rax,rdx
       pop       rbx
       pop       rsi
       ret
M04_L03:
       test      esi,esi
       jne       short M04_L06
       xor       edx,edx
       jmp       short M04_L02
M04_L04:
       test      ebx,ebx
       je        short M04_L05
       inc       r9d
       add       r10d,r9d
       and       r10d,[r8+4]
       cmp       r9d,8
       jl        short M04_L00
M04_L05:
       mov       esi,2
       jmp       short M04_L01
M04_L06:
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFE7728D8A8]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny_NoCacheLookup(Void*, System.Object)
; Total bytes of code 168
```
```assembly
; System.Collections.Generic.SegmentedArrayBuilder`1[[System.__Canon, System.Private.CoreLib]].ToSpanInlined(System.Span`1<System.__Canon>)
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+38],rdx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,[r8]
       mov       ebp,[r8+8]
       mov       r14d,[rbx]
       test      r14d,r14d
       je        short M05_L01
       mov       rdx,[rbx+0E8]
       mov       r15d,[rbx+0F0]
       cmp       r15d,ebp
       jg        near ptr M05_L15
       mov       r13d,r15d
       shl       r13,3
       mov       r8,r13
       cmp       r8,4000
       ja        near ptr M05_L04
       mov       rcx,rdi
       call      00007FFED6E70160
       cmp       dword ptr [7FFED71EE808],0
       jne       short M05_L03
M05_L00:
       add       rdi,r13
       sub       ebp,r15d
       dec       r14d
       jne       short M05_L05
M05_L01:
       lea       rcx,[rbx+0F8]
       mov       edx,[rbx+8]
       cmp       edx,[rcx+8]
       ja        near ptr M05_L12
       mov       rax,[rcx]
       cmp       edx,ebp
       ja        near ptr M05_L15
       mov       r8d,edx
       shl       r8,3
       cmp       r8,4000
       ja        near ptr M05_L14
       mov       rcx,rdi
       mov       rdx,rax
       call      00007FFED6E70160
       cmp       dword ptr [7FFED71EE808],0
       jne       near ptr M05_L13
M05_L02:
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M05_L03:
       call      CORINFO_HELP_POLL_GC
       jmp       short M05_L00
M05_L04:
       mov       rcx,rdi
       call      qword ptr [7FFE778FD7B8]
       jmp       short M05_L00
M05_L05:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0A0
       jle       short M05_L06
       mov       rdx,[rcx+0A0]
       test      rdx,rdx
       je        short M05_L06
       jmp       short M05_L07
M05_L06:
       mov       rcx,rsi
       mov       rdx,7FFE77AB1990
       call      qword ptr [7FFE7728C570]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M05_L07:
       lea       r8,[rbx+10]
       lea       rcx,[rsp+28]
       mov       r9d,1B
       call      qword ptr [7FFE7798ECA0]; <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan[[System.Collections.Generic.SegmentedArrayBuilder`1+Arrays[[System.__Canon, System.Private.CoreLib]], System.Linq],[System.__Canon, System.Private.CoreLib]](Arrays<System.__Canon> ByRef, Int32)
       cmp       r14d,[rsp+30]
       ja        short M05_L12
       mov       rsi,[rsp+28]
       xor       r15d,r15d
       jmp       short M05_L11
M05_L08:
       mov       r8,[rsi+r15*8]
       test      r8,r8
       jne       short M05_L09
       xor       edx,edx
       xor       r13d,r13d
       jmp       short M05_L10
M05_L09:
       lea       rdx,[r8+10]
       mov       r13d,[r8+8]
M05_L10:
       cmp       r13d,ebp
       jg        short M05_L15
       mov       r8d,r13d
       shl       r8,3
       mov       rcx,rdi
       call      qword ptr [7FFE772857A0]; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r13d
       lea       rdi,[rdi+rcx*8]
       sub       ebp,r13d
       inc       r15d
M05_L11:
       cmp       r15d,r14d
       jl        short M05_L08
       jmp       near ptr M05_L01
M05_L12:
       call      qword ptr [7FFE774270D8]
       int       3
M05_L13:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M05_L02
M05_L14:
       mov       rcx,rdi
       mov       rdx,rax
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FFE778FD7B8]
M05_L15:
       call      qword ptr [7FFE77797F30]
       int       3
; Total bytes of code 437
```
```assembly
; System.Array.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       push      rsi
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        short M06_L02
       cmp       dword ptr [rbx+8],0
       je        short M06_L03
       mov       rdx,[rcx+18]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M06_L01
M06_L00:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M06_L01:
       mov       rdx,7FFE77AB06C0
       call      qword ptr [7FFE77507AB0]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       short M06_L00
M06_L02:
       mov       ecx,2
       call      qword ptr [7FFE7750C180]
       int       3
M06_L03:
       mov       rdx,[rcx+18]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M06_L04
       jmp       short M06_L05
M06_L04:
       mov       rdx,7FFE77AB06C0
       call      qword ptr [7FFE77507AB0]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdx,rax
M06_L05:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rax]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 156
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
; System.Collections.Generic.SegmentedArrayBuilder`1[[System.__Canon, System.Private.CoreLib]].ReturnArrays(Int32)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       mov       [rsp+40],rdx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       ebx,r8d
       cmp       [rsi],sil
       lea       rbp,[rsi+10]
       dec       ebx
       cmp       ebx,1B
       ja        near ptr M08_L10
       xor       r14d,r14d
       cmp       r14d,ebx
       jl        near ptr M08_L11
M08_L00:
       cmp       ebx,1B
       jae       near ptr M08_L39
       mov       edx,ebx
       mov       rbx,[rbp+rdx*8]
       mov       edx,[rsi+8]
       test      rbx,rbx
       je        near ptr M08_L17
       lea       rcx,[rbx+10]
       xor       eax,eax
       mov       r8,[rbx]
       cmp       dword ptr [r8+4],18
       jne       near ptr M08_L14
M08_L01:
       mov       r10d,eax
       neg       r10d
       test      eax,eax
       jg        near ptr M08_L09
       mov       eax,r10d
       or        eax,edx
       jl        near ptr M08_L09
       lea       eax,[r10+rdx]
       cmp       eax,[rbx+8]
       ja        near ptr M08_L09
       movzx     eax,word ptr [r8]
       mov       r10d,r10d
       imul      r10,rax
       add       rcx,r10
       mov       edx,edx
       imul      rdx,rax
       test      dword ptr [r8],1000000
       je        near ptr M08_L15
       shr       rdx,3
       call      qword ptr [7FFE7798EDA8]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
M08_L02:
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0B8
       jle       near ptr M08_L08
       mov       rcx,[rcx+0B8]
       test      rcx,rcx
       je        near ptr M08_L08
M08_L03:
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,[rax]
       mov       rsi,rcx
       mov       rcx,offset MT_System.Buffers.SharedArrayPool<System.Reflection.MethodInfo>
       cmp       [rsi],rcx
       jne       near ptr M08_L38
       mov       ecx,[rbx+8]
       dec       ecx
       or        ecx,0F
       xor       edi,edi
       lzcnt     edi,ecx
       xor       edi,1F
       add       edi,0FFFFFFFD
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+238],0A
       jle       near ptr M08_L16
       mov       rcx,[rcx+240]
       mov       rax,[rcx+50]
       test      rax,rax
       je        near ptr M08_L16
M08_L04:
       mov       rax,[rax+10]
       test      rax,rax
       je        near ptr M08_L18
M08_L05:
       xor       ebp,ebp
       mov       r14d,1
       mov       ecx,[rax+8]
       cmp       ecx,edi
       jbe       short M08_L06
       mov       ebp,1
       mov       ecx,10
       shlx      ecx,ecx,edi
       cmp       [rbx+8],ecx
       jne       near ptr M08_L19
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
       jne       near ptr M08_L20
M08_L06:
       mov       rcx,28713800C90
       mov       r15,[rcx]
       cmp       byte ptr [r15+9D],0
       jne       near ptr M08_L35
M08_L07:
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
M08_L08:
       mov       rcx,rdi
       mov       rdx,7FFE77AB2068
       call      qword ptr [7FFE7728C570]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M08_L03
M08_L09:
       call      qword ptr [7FFE77A47690]
       int       3
M08_L10:
       call      qword ptr [7FFE774270D8]
       int       3
M08_L11:
       mov       r15,[rbp+r14*8]
       mov       rcx,r15
       call      qword ptr [7FFE77A468E0]
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0B8
       jle       short M08_L12
       mov       rcx,[rcx+0B8]
       test      rcx,rcx
       je        short M08_L12
       jmp       short M08_L13
M08_L12:
       mov       rcx,rdi
       mov       rdx,7FFE77AB2068
       call      qword ptr [7FFE7728C570]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M08_L13:
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,[rax]
       mov       rdx,r15
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFE77A0EA48]; System.Buffers.SharedArrayPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon[], Boolean)
       inc       r14d
       cmp       r14d,ebx
       jl        short M08_L11
       jmp       near ptr M08_L00
M08_L14:
       mov       r10d,[r8+4]
       add       r10d,0FFFFFFE8
       shr       r10d,3
       movsxd    rax,r10d
       mov       eax,[rcx+rax*4]
       shl       r10d,3
       movsxd    r10,r10d
       add       rcx,r10
       jmp       near ptr M08_L01
M08_L15:
       call      qword ptr [7FFE772857E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
       jmp       near ptr M08_L02
M08_L16:
       mov       ecx,0A
       call      qword ptr [7FFE777943F0]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M08_L04
M08_L17:
       mov       ecx,2
       call      qword ptr [7FFE7750C180]
       int       3
M08_L18:
       mov       rcx,rsi
       call      qword ptr [7FFE7798EDD8]; System.Buffers.SharedArrayPool`1[[System.__Canon, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
       jmp       near ptr M08_L05
M08_L19:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE77A46880]
       mov       rsi,rax
       mov       ecx,29B
       mov       rdx,7FFE771C4000
       call      qword ptr [7FFE775076F0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE776E5B30]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M08_L20:
       mov       rcx,[rsi+10]
       cmp       edi,[rcx+8]
       jae       near ptr M08_L39
       mov       edx,edi
       mov       rax,[rcx+rdx*8+10]
       test      rax,rax
       jne       short M08_L21
       mov       rcx,rsi
       mov       edx,edi
       call      qword ptr [7FFE77A476D8]
M08_L21:
       mov       r14,[rax+8]
       mov       rcx,offset MT_System.Threading.ProcessorIdCache
       call      qword ptr [7FFE77285740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       cmp       byte ptr [7FFE771CB18C],0
       je        short M08_L22
       call      qword ptr [7FFE77A46670]
       mov       r15d,eax
       jmp       short M08_L24
M08_L22:
       mov       ecx,0B
       call      qword ptr [7FFE77A46688]
       mov       r15d,[rax+10]
       mov       ecx,0B
       call      qword ptr [7FFE77A46688]
       lea       ecx,[r15-1]
       mov       [rax+10],ecx
       movzx     eax,r15w
       test      eax,eax
       jne       short M08_L23
       call      qword ptr [7FFE77A466A0]
       mov       r15d,eax
       jmp       short M08_L24
M08_L23:
       sar       r15d,10
M08_L24:
       mov       rcx,offset MT_System.Buffers.SharedArrayPoolStatics
       call      qword ptr [7FFE77285740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       eax,r15d
       xor       edx,edx
       div       dword ptr [7FFE771CB180]
       mov       r15d,edx
       xor       r12d,r12d
       jmp       near ptr M08_L31
M08_L25:
       cmp       r15d,[r14+8]
       jae       near ptr M08_L39
       mov       ecx,r15d
       mov       rax,[r14+rcx*8+10]
       mov       [rsp+30],rax
       cmp       [rax],al
       xor       edx,edx
       mov       [rsp+3C],edx
       mov       rcx,rax
       call      qword ptr [7FFE7787D278]; System.Threading.Monitor.Enter(System.Object)
       mov       rax,[rsp+30]
       mov       rcx,[rax+8]
       mov       r8d,[rax+10]
       mov       [rsp+38],r8d
       cmp       [rcx+8],r8d
       jbe       short M08_L27
       test      r8d,r8d
       jne       short M08_L28
       xor       edx,edx
       mov       [rax+14],edx
M08_L26:
       mov       edx,r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rsp+38]
       inc       ecx
       mov       rax,[rsp+30]
       mov       [rax+10],ecx
       mov       dword ptr [rsp+3C],1
M08_L27:
       mov       rcx,rax
       call      qword ptr [7FFE77286820]; System.Threading.Monitor.Exit(System.Object)
       cmp       dword ptr [rsp+3C],0
       je        short M08_L29
       jmp       short M08_L32
M08_L28:
       jmp       short M08_L26
M08_L29:
       inc       r15d
       cmp       [r14+8],r15d
       jne       short M08_L30
       xor       r15d,r15d
M08_L30:
       inc       r12d
M08_L31:
       cmp       [r14+8],r12d
       jg        near ptr M08_L25
       jmp       short M08_L33
M08_L32:
       mov       r14d,1
       jmp       short M08_L34
M08_L33:
       xor       r14d,r14d
M08_L34:
       jmp       near ptr M08_L06
M08_L35:
       cmp       dword ptr [rbx+8],0
       je        near ptr M08_L07
       mov       rcx,rbx
       call      qword ptr [7FFE7779C600]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r13d,eax
       mov       r12d,[rbx+8]
       mov       rcx,rsi
       call      qword ptr [7FFE7779C600]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,r15
       mov       r8d,r13d
       mov       r9d,r12d
       mov       edx,3
       call      qword ptr [7FFE77A468B0]
       test      r14d,ebp
       jne       near ptr M08_L07
       mov       rcx,rbx
       call      qword ptr [7FFE7779C600]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r14d,eax
       mov       ebx,[rbx+8]
       mov       rcx,rsi
       call      qword ptr [7FFE7779C600]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       test      ebp,ebp
       jne       short M08_L36
       mov       ecx,0FFFFFFFF
       mov       edx,1
       jmp       short M08_L37
M08_L36:
       mov       ecx,edi
       xor       edx,edx
M08_L37:
       mov       [rsp+20],ecx
       mov       [rsp+28],edx
       mov       rcx,r15
       mov       edx,r14d
       mov       r8d,ebx
       call      qword ptr [7FFE77A468C8]
       jmp       near ptr M08_L07
M08_L38:
       mov       rcx,rsi
       mov       rdx,rbx
       xor       r8d,r8d
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FFE77A0EA48]; System.Buffers.SharedArrayPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon[], Boolean)
M08_L39:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1284
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
       mov       rax,0ABF0329DE262
       mov       [rbp],rax
       mov       rsi,rcx
       mov       rbx,rdx
       mov       edi,r8d
       mov       r14d,r9d
       test      rbx,rbx
       je        short M09_L00
       cmp       dword ptr [rbx+8],0
       jne       short M09_L03
M09_L00:
       xor       r8d,r8d
       mov       [rbp+8],r8
       mov       [rbp+10],r8d
       mov       [rsp+20],r14d
       lea       r8,[rbp+8]
       mov       rcx,rsi
       mov       r9d,edi
       mov       rdx,2C7A8630008
       call      qword ptr [7FFE7728D2D8]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].GetListByName(System.String, System.Span`1<Byte>, MemberListType, CacheType)
       mov       [rbp+18],rax
M09_L01:
       mov       rcx,7FFE77C0D2A8
       call      CORINFO_HELP_COUNTPROFILE32
       lea       rdx,[rbp+18]
       mov       rcx,rsi
       mov       r8,rbx
       mov       r9d,edi
       call      qword ptr [7FFE7728D518]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Insert(System.__Canon[] ByRef, System.String, MemberListType)
       mov       rax,[rbp+18]
       mov       rcx,0ABF0329DE262
       cmp       [rbp],rcx
       je        short M09_L02
       call      CORINFO_HELP_FAIL_FAST
M09_L02:
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
M09_L03:
       cmp       r14d,1
       je        near ptr M09_L07
M09_L04:
       mov       rcx,28713800220
       mov       r15,[rcx]
       mov       rcx,r15
       mov       rdx,7FFE77C0D198
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rcx,r15
       mov       rdx,rbx
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+18]
       mov       r15d,eax
       cmp       r15d,400
       ja        near ptr M09_L10
       mov       rcx,7FFE77C0D2A0
       call      CORINFO_HELP_COUNTPROFILE32
       mov       edx,r15d
       mov       r13,rdx
       test      r13,r13
       je        short M09_L06
       mov       rcx,r13
       add       rcx,0F
       and       rcx,0FFFFFFFFFFFFFFF0
       add       rsp,30
       neg       rcx
       add       rcx,rsp
       jb        short M09_L05
       xor       ecx,ecx
M09_L05:
       test      [rsp],esp
       sub       rsp,1000
       cmp       rsp,rcx
       jae       short M09_L05
       mov       rsp,rcx
       test      [rsp],esp
       sub       rsp,30
       lea       r13,[rsp+30]
M09_L06:
       mov       rcx,7FFE77C0D2A4
       call      CORINFO_HELP_COUNTPROFILE32
       mov       [rbp+8],r13
       mov       [rbp+10],r15d
       mov       [rsp+20],r14d
       lea       r8,[rbp+8]
       mov       rdx,rbx
       mov       rcx,rsi
       mov       r9d,edi
       call      qword ptr [7FFE7728D2D8]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].GetListByName(System.String, System.Span`1<Byte>, MemberListType, CacheType)
       mov       [rbp+18],rax
       jmp       near ptr M09_L01
M09_L07:
       cmp       word ptr [rbx+0C],2E
       je        short M09_L09
       cmp       word ptr [rbx+0C],2A
       je        short M09_L08
       mov       rcx,7FFE77C0D188
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M09_L00
M09_L08:
       mov       rcx,7FFE77C0D18C
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M09_L04
M09_L09:
       mov       rcx,7FFE77C0D190
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M09_L04
M09_L10:
       movsxd    rdx,r15d
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       r13,[rax+10]
       mov       r15d,[rax+8]
       jmp       near ptr M09_L06
; Total bytes of code 507
```
```assembly
; System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rdx
       mov       ebx,r8d
       test      ebx,ebx
       jl        near ptr M10_L04
       mov       rdi,[rsi]
       test      rdi,rdi
       je        near ptr M10_L05
       mov       ebp,[rdi+8]
       cmp       ebp,ebx
       je        short M10_L02
       mov       rdx,[rcx+18]
       mov       rax,[rdx+18]
       test      rax,rax
       je        short M10_L03
       mov       rcx,rax
M10_L00:
       mov       edx,ebx
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       lea       rcx,[r14+10]
       lea       rdx,[rdi+10]
       cmp       ebx,ebp
       cmovg     ebx,ebp
       mov       r8d,ebx
       shl       r8,3
       cmp       r8,4000
       ja        near ptr M10_L09
       call      00007FFED6E70160
       cmp       dword ptr [7FFED71EE808],0
       jne       short M10_L08
M10_L01:
       mov       rcx,rsi
       mov       rdx,r14
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M10_L02:
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M10_L03:
       mov       rdx,7FFE77A7EDB0
       call      qword ptr [7FFE77507AB0]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M10_L00
M10_L04:
       mov       ecx,45
       mov       edx,0D
       call      qword ptr [7FFE778F55A8]
       int       3
M10_L05:
       mov       rdx,[rcx+18]
       mov       rax,[rdx+18]
       test      rax,rax
       je        short M10_L06
       mov       rcx,rax
       jmp       short M10_L07
M10_L06:
       mov       rdx,7FFE77A7EDB0
       call      qword ptr [7FFE77507AB0]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M10_L07:
       mov       edx,ebx
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdx,rax
       mov       rcx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       short M10_L02
M10_L08:
       call      CORINFO_HELP_POLL_GC
       jmp       short M10_L01
M10_L09:
       call      qword ptr [7FFE778FD7B8]
       jmp       near ptr M10_L01
; Total bytes of code 257
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M11_L00
       ret
M11_L00:
       jmp       qword ptr [7FFE77285C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```
```assembly
; DotNetTips.Spargine.Core.TypeHelper+<>c.<GetAllGenericMethods>b__21_0(System.Reflection.MethodInfo)
; 		return Array.AsReadOnly(type.GetTypeInfo().DeclaredMethods.Where(m => m.IsGenericMethod).ToArray());
; 		                                                                      ^^^^^^^^^^^^^^^^^
       push      rbx
       sub       rsp,20
       mov       rbx,rdx
       mov       rcx,offset MT_System.Reflection.RuntimeMethodInfo
       cmp       [rbx],rcx
       jne       short M12_L00
       mov       rcx,[rbx+50]
       call      00007FFED6EB5690
       nop
       add       rsp,20
       pop       rbx
       ret
M12_L00:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+58]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax+10]
; Total bytes of code 58
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M13_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M13_L00:
       call      qword ptr [7FFE77A46B80]
       int       3
; Total bytes of code 44
```
```assembly
; System.Collections.Generic.SegmentedArrayBuilder`1[[System.__Canon, System.Private.CoreLib]].AddSlow(System.__Canon)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,68
       mov       [rsp+60],rdx
       mov       rbx,rcx
       mov       rsi,r8
       mov       rdi,rdx
       mov       ecx,[rbx+100]
       mov       edx,ecx
       add       edx,[rbx+4]
       jo        near ptr M14_L55
       mov       [rbx+4],edx
       cmp       dword ptr [rbx+4],7FFFFFC7
       jg        near ptr M14_L43
       movsxd    rbp,ecx
       add       rbp,rbp
       cmp       rbp,10
       jle       short M14_L00
       cmp       rbp,7FFFFFC7
       jle       short M14_L01
       mov       r14d,7FFFFFC7
       jmp       short M14_L02
M14_L00:
       mov       ebp,10
M14_L01:
       mov       r14,rbp
M14_L02:
       lea       rbp,[rbx+10]
       mov       r15d,[rbx]
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0B8
       jle       near ptr M14_L19
       mov       rcx,[rcx+0B8]
       test      rcx,rcx
       je        near ptr M14_L19
M14_L03:
       cmp       r15d,1B
       jae       near ptr M14_L54
       mov       eax,r15d
       lea       rbp,[rbp+rax*8]
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r15,[rax]
       mov       r13d,r14d
       mov       rcx,28713800C90
       mov       r12,[rcx]
       lea       ecx,[r13-1]
       or        ecx,0F
       xor       eax,eax
       lzcnt     eax,ecx
       xor       eax,1F
       add       eax,0FFFFFFFD
       mov       [rsp+5C],eax
       mov       rcx,[r15]
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCThreadStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rax+10]
       test      rax,rax
       je        near ptr M14_L20
       mov       r8d,[rsp+5C]
       cmp       [rax+8],r8d
       jbe       near ptr M14_L20
       mov       ecx,r8d
       shl       rcx,4
       mov       r10,[rax+rcx+10]
       test      r10,r10
       je        near ptr M14_L20
       mov       r14,r10
       mov       r13d,[rsp+5C]
       mov       ecx,r13d
       shl       rcx,4
       xor       edx,edx
       mov       [rax+rcx+10],rdx
       cmp       byte ptr [r12+9D],0
       je        near ptr M14_L15
       mov       rcx,r14
       call      qword ptr [7FFE7779C600]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+4C],eax
       mov       edx,[r14+8]
       mov       [rsp+48],edx
       mov       rcx,r15
       call      00007FFED6E834A0
       mov       r9d,eax
       test      r9d,r9d
       je        near ptr M14_L44
M14_L04:
       mov       [rsp+20],r13d
       mov       rcx,r12
       mov       edx,[rsp+4C]
       mov       r8d,[rsp+48]
       call      qword ptr [7FFE77A46658]
       jmp       near ptr M14_L15
M14_L05:
       mov       rcx,r15
       call      qword ptr [7FFE7728E8F8]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       mov       r9d,eax
       jmp       near ptr M14_L14
M14_L06:
       xor       r14d,r14d
       jmp       near ptr M14_L34
M14_L07:
       mov       r14,r10
       test      r14,r14
       jne       near ptr M14_L40
M14_L08:
       mov       ecx,10
       mov       r8d,[rsp+5C]
       shlx      r13d,ecx,r8d
M14_L09:
       mov       rcx,[r15]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx+8]
       cmp       qword ptr [rdx+8],38
       jle       near ptr M14_L36
       mov       rax,[rdx+38]
       test      rax,rax
       je        near ptr M14_L36
       mov       rcx,rax
M14_L10:
       mov       rdx,[rcx+18]
       mov       rax,[rdx+18]
       test      rax,rax
       je        near ptr M14_L37
       mov       rcx,rax
M14_L11:
       movsxd    rdx,r13d
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       cmp       byte ptr [r12+9D],0
       je        near ptr M14_L15
       mov       rcx,r14
       call      00007FFED6E834A0
       mov       r13d,eax
       test      r13d,r13d
       je        near ptr M14_L38
M14_L12:
       mov       eax,[r14+8]
       mov       [rsp+58],eax
       mov       rcx,r15
       call      00007FFED6E834A0
       mov       r9d,eax
       test      r9d,r9d
       je        near ptr M14_L39
M14_L13:
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       rcx,r12
       mov       edx,r13d
       mov       r8d,[rsp+58]
       call      qword ptr [7FFE77A46658]
       mov       eax,[r14+8]
       mov       [rsp+54],eax
       mov       rcx,r15
       call      00007FFED6E834A0
       mov       r9d,eax
       test      r9d,r9d
       je        near ptr M14_L05
M14_L14:
       mov       rcx,[r15+10]
       mov       edx,1
       mov       r8d,2
       mov       r15d,[rsp+5C]
       cmp       [rcx+8],r15d
       cmovg     edx,r8d
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       [rsp+28],edx
       mov       rcx,r12
       mov       edx,r13d
       mov       r8d,[rsp+54]
       call      qword ptr [7FFE77A466E8]
M14_L15:
       mov       rcx,rbp
       mov       rdx,r14
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],90
       jle       near ptr M14_L41
       mov       rcx,[rcx+90]
       test      rcx,rcx
       je        near ptr M14_L41
M14_L16:
       test      r14,r14
       je        near ptr M14_L52
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+20]
       test      rax,rax
       je        near ptr M14_L42
M14_L17:
       cmp       [r14],rax
       jne       near ptr M14_L53
       lea       rdi,[r14+10]
       mov       ebp,[r14+8]
M14_L18:
       mov       [rbx+0F8],rdi
       mov       [rbx+100],ebp
       inc       dword ptr [rbx]
       lea       rcx,[rbx+0F8]
       cmp       dword ptr [rcx+8],0
       jbe       near ptr M14_L54
       mov       rcx,[rcx]
       mov       rdx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       dword ptr [rbx+8],1
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M14_L19:
       mov       rcx,rdi
       mov       rdx,7FFE77AB2068
       call      qword ptr [7FFE7728C570]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M14_L03
M14_L20:
       mov       rax,[r15+10]
       mov       r8d,[rsp+5C]
       cmp       [rax+8],r8d
       ja        short M14_L26
       test      r13d,r13d
       je        short M14_L21
       test      r13d,r13d
       jge       near ptr M14_L09
       jmp       near ptr M14_L51
M14_L21:
       mov       rcx,[r15]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx+8]
       cmp       qword ptr [rdx+8],40
       jle       short M14_L24
       mov       rax,[rdx+40]
       test      rax,rax
       je        short M14_L24
       mov       rcx,rax
M14_L22:
       mov       rdx,[rcx+18]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M14_L25
M14_L23:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r14,[rax]
       jmp       near ptr M14_L15
M14_L24:
       mov       rdx,7FFE77AB2170
       call      qword ptr [7FFE7728C570]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M14_L22
M14_L25:
       mov       rdx,7FFE77A7BE50
       call      qword ptr [7FFE77507AB0]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       short M14_L23
M14_L26:
       mov       ecx,r8d
       mov       rcx,[rax+rcx*8+10]
       test      rcx,rcx
       je        near ptr M14_L08
       mov       r13,[rcx+8]
       test      byte ptr [7FFE77A9E570],1
       je        near ptr M14_L45
M14_L27:
       cmp       byte ptr [7FFE771CB18C],0
       je        near ptr M14_L46
       call      qword ptr [7FFE77A46670]
       mov       r14d,eax
M14_L28:
       test      byte ptr [7FFE77A9E400],1
       je        near ptr M14_L48
M14_L29:
       mov       eax,r14d
       xor       edx,edx
       div       dword ptr [7FFE771CB180]
       mov       r14d,edx
       xor       eax,eax
       mov       [rsp+44],eax
       cmp       dword ptr [r13+8],0
       jle       near ptr M14_L50
M14_L30:
       cmp       r14d,[r13+8]
       jae       near ptr M14_L54
       mov       ecx,r14d
       mov       rdx,[r13+rcx*8+10]
       mov       [rsp+30],rdx
       cmp       [rdx],dl
       xor       r8d,r8d
       mov       [rsp+38],r8
       mov       rcx,rdx
       call      00007FFED6E20370
       test      eax,eax
       je        near ptr M14_L49
M14_L31:
       mov       rax,[rsp+30]
       mov       rcx,[rax+8]
       mov       edx,[rax+10]
       dec       edx
       cmp       [rcx+8],edx
       ja        short M14_L35
M14_L32:
       mov       rcx,rax
       call      00007FFED6E6FFC0
       test      eax,eax
       je        short M14_L33
       mov       ecx,eax
       mov       rdx,[rsp+30]
       call      qword ptr [7FFE77A466D0]
M14_L33:
       mov       r10,[rsp+38]
       test      r10,r10
       jne       near ptr M14_L07
       inc       r14d
       cmp       [r13+8],r14d
       je        near ptr M14_L06
M14_L34:
       mov       eax,[rsp+44]
       inc       eax
       cmp       [r13+8],eax
       mov       [rsp+44],eax
       jg        near ptr M14_L30
       jmp       near ptr M14_L50
M14_L35:
       mov       r8d,edx
       mov       r10,[rcx+r8*8+10]
       mov       [rsp+38],r10
       xor       r9d,r9d
       mov       [rcx+r8*8+10],r9
       mov       [rax+10],edx
       jmp       short M14_L32
M14_L36:
       mov       rdx,7FFE77AB2150
       call      qword ptr [7FFE7728C570]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M14_L10
M14_L37:
       mov       rdx,7FFE77AB1960
       call      qword ptr [7FFE77507AB0]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M14_L11
M14_L38:
       mov       rcx,r14
       call      qword ptr [7FFE7728E8F8]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       mov       r13d,eax
       jmp       near ptr M14_L12
M14_L39:
       mov       rcx,r15
       call      qword ptr [7FFE7728E8F8]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       mov       r9d,eax
       jmp       near ptr M14_L13
M14_L40:
       cmp       byte ptr [r12+9D],0
       je        near ptr M14_L15
       mov       rcx,r14
       call      qword ptr [7FFE7779C600]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r13d,eax
       mov       eax,[r14+8]
       mov       [rsp+50],eax
       mov       rcx,r15
       call      qword ptr [7FFE7779C600]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       r15d,[rsp+5C]
       mov       [rsp+20],r15d
       mov       edx,r13d
       mov       r8d,[rsp+50]
       mov       rcx,r12
       call      qword ptr [7FFE77A46658]
       jmp       near ptr M14_L15
M14_L41:
       mov       rcx,rdi
       mov       rdx,7FFE77AB18D8
       call      qword ptr [7FFE7728C570]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M14_L16
M14_L42:
       mov       rdx,7FFE77A7EFC8
       call      qword ptr [7FFE7728C570]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M14_L17
M14_L43:
       mov       rcx,offset MT_System.OutOfMemoryException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE77A47390]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M14_L44:
       mov       rcx,r15
       call      qword ptr [7FFE7728E8F8]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       mov       r9d,eax
       jmp       near ptr M14_L04
M14_L45:
       mov       rcx,offset MT_System.Threading.ProcessorIdCache
       call      qword ptr [7FFE77285740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M14_L27
M14_L46:
       mov       ecx,0B
       call      qword ptr [7FFE77A46688]
       mov       r14d,[rax+10]
       mov       ecx,0B
       call      qword ptr [7FFE77A46688]
       lea       ecx,[r14-1]
       mov       [rax+10],ecx
       movzx     eax,r14w
       test      eax,eax
       jne       short M14_L47
       call      qword ptr [7FFE77A466A0]
       mov       r14d,eax
       jmp       near ptr M14_L28
M14_L47:
       sar       r14d,10
       jmp       near ptr M14_L28
M14_L48:
       mov       rcx,offset MT_System.Buffers.SharedArrayPoolStatics
       call      qword ptr [7FFE77285740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M14_L29
M14_L49:
       mov       rcx,[rsp+30]
       call      qword ptr [7FFE77A466B8]
       jmp       near ptr M14_L31
M14_L50:
       xor       r10d,r10d
       jmp       near ptr M14_L07
M14_L51:
       mov       ecx,1733C
       mov       rdx,7FFE771C4000
       call      qword ptr [7FFE775076F0]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FFE77A45890]
       int       3
M14_L52:
       xor       edi,edi
       xor       ebp,ebp
       jmp       near ptr M14_L18
M14_L53:
       call      qword ptr [7FFE77A46FB8]
       int       3
M14_L54:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M14_L55:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 1714
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rdx,rdx
       je        short M15_L01
       mov       rax,[rdx]
       movzx     r8d,word ptr [rax+0E]
       test      r8,r8
       je        short M15_L05
       mov       r10,[rax+38]
       cmp       r8,4
       jl        short M15_L04
       cmp       [r10],rcx
       je        short M15_L01
M15_L00:
       cmp       [r10+8],rcx
       je        short M15_L01
       cmp       [r10+10],rcx
       jne       short M15_L03
M15_L01:
       mov       rax,rdx
       ret
M15_L02:
       cmp       [r10],rcx
       je        short M15_L01
       jmp       short M15_L00
M15_L03:
       cmp       [r10+18],rcx
       je        short M15_L01
       add       r10,20
       add       r8,0FFFFFFFFFFFFFFFC
       cmp       r8,4
       jge       short M15_L02
       test      r8,r8
       je        short M15_L05
M15_L04:
       cmp       [r10],rcx
       je        short M15_L01
       add       r10,8
       dec       r8
       test      r8,r8
       jg        short M15_L04
M15_L05:
       test      dword ptr [rax],500C0000
       jne       short M15_L06
       xor       edx,edx
       jmp       short M15_L01
M15_L06:
       jmp       qword ptr [7FFE776ED1B8]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
; Total bytes of code 116
```
```assembly
; System.Linq.Enumerable.ICollectionToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rcx,rbx
       call      qword ptr [7FFEE9B885F8]
       mov       rcx,rsi
       mov       r11,rax
       call      qword ptr [rax]
       mov       edi,eax
       test      edi,edi
       je        short M16_L00
       mov       rcx,rbx
       call      qword ptr [7FFEE9B87A40]
       mov       rcx,rax
       movsxd    rdx,edi
       call      qword ptr [7FFEE9B856D0]; CORINFO_HELP_NEWARR_1_DIRECT
       mov       rdi,rax
       mov       rcx,rbx
       call      qword ptr [7FFEE9B88600]
       mov       rcx,rsi
       mov       r11,rax
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [rax]
       mov       rax,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M16_L00:
       mov       rcx,rbx
       call      qword ptr [7FFEE9B88220]
       mov       rcx,rax
       lea       rax,[System.Linq.Enumerable.Select[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>)]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax]
; Total bytes of code 128
```

## .NET 10.0.0 (10.0.25.45207), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark.GetAllMethods()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.TypeHelper+<GetAllMethods>d__22
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       dword ptr [rsi+28],0FFFFFFFE
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rsi+2C],eax
       mov       rcx,25659E4EDD8
       mov       [rsi+18],rcx
       mov       [rsp+20],rsi
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 99
```

## .NET 10.0.0 (10.0.25.45207), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark.GetAllProperties()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.TypeHelper+<GetAllProperties>d__23
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       dword ptr [rsi+28],0FFFFFFFE
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rsi+2C],eax
       mov       rcx,1D49C380090
       mov       [rsi+18],rcx
       mov       [rsp+20],rsi
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 99
```

## .NET 10.0.0 (10.0.25.45207), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark.GetAllPublicMethods()
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,198
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       mov       rax,0FFFFFFFFFFFFFEB0
M00_L00:
       vmovdqa   xmmword ptr [rsp+rax+190],xmm4
       vmovdqa   xmmword ptr [rsp+rax+1A0],xmm4
       vmovdqa   xmmword ptr [rsp+rax+1B0],xmm4
       add       rax,30
       jne       short M00_L00
       mov       [rsp+190],rax
       mov       rbx,rcx
       mov       rcx,1631A0D1168
       mov       rsi,[rcx]
       test      rsi,rsi
       jne       short M00_L01
       mov       rcx,1A3B0CC0090
       call      qword ptr [7FFE772A7C00]; System.RuntimeType.InitializeCache()
       mov       rdi,rax
       jmp       short M00_L02
M00_L01:
       mov       rdi,rsi
M00_L02:
       cmp       [rdi],dil
       lea       rsi,[rdi+40]
       mov       rcx,[rsi]
       test      rcx,rcx
       je        near ptr M00_L27
M00_L03:
       cmp       byte ptr [rcx+18],0
       je        near ptr M00_L28
       mov       rsi,[rcx+8]
M00_L04:
       mov       edi,[rsi+8]
       mov       edx,edi
       xor       r8d,r8d
       mov       [rsp+180],r8
       mov       [rsp+188],r8
       mov       [rsp+190],r8d
       mov       [rsp+194],edx
       mov       ebp,10
       inc       edi
M00_L05:
       dec       edi
       je        near ptr M00_L12
       mov       r14,[rsi+rbp]
       mov       edx,[r14+58]
       mov       r8d,edx
       and       r8d,3C
       cmp       r8d,edx
       jne       short M00_L08
       cmp       dword ptr [rsp+190],0
       je        near ptr M00_L11
       cmp       dword ptr [rsp+190],1
       je        short M00_L09
       mov       edx,[rsp+194]
       cmp       edx,[rsp+190]
       je        near ptr M00_L30
M00_L06:
       movsxd    rdx,dword ptr [rsp+190]
       mov       rcx,[rsp+180]
       mov       r8,r14
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
M00_L07:
       mov       edx,[rsp+190]
       inc       edx
       mov       [rsp+190],edx
M00_L08:
       add       rbp,8
       jmp       short M00_L05
M00_L09:
       cmp       dword ptr [rsp+194],2
       jl        near ptr M00_L29
M00_L10:
       movsxd    rdx,dword ptr [rsp+194]
       mov       rcx,offset MT_System.Reflection.MethodInfo[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       [rsp+180],rax
       mov       rcx,[rsp+180]
       mov       r8,[rsp+188]
       xor       edx,edx
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       short M00_L06
M00_L11:
       mov       [rsp+188],r14
       jmp       short M00_L07
M00_L12:
       mov       rsi,[rsp+180]
       mov       rdi,[rsp+188]
       mov       ebp,[rsp+190]
       test      ebp,ebp
       je        near ptr M00_L31
       cmp       ebp,1
       je        near ptr M00_L32
       test      ebp,ebp
       jl        near ptr M00_L33
       test      rsi,rsi
       je        near ptr M00_L34
       cmp       [rsi+8],ebp
       je        short M00_L14
       mov       edx,ebp
       mov       rcx,offset MT_System.Reflection.MethodInfo[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       lea       rcx,[rdi+10]
       lea       rdx,[rsi+10]
       mov       r8d,[rsi+8]
       cmp       ebp,r8d
       cmovg     ebp,r8d
       mov       r8d,ebp
       shl       r8,3
       cmp       r8,4000
       ja        near ptr M00_L36
       call      00007FFED6E70160
       cmp       dword ptr [7FFED71EE808],0
       jne       near ptr M00_L35
M00_L13:
       mov       rsi,rdi
M00_L14:
       mov       rcx,1631BC020D8
       mov       rdi,[rcx]
       test      rdi,rdi
       je        near ptr M00_L37
M00_L15:
       test      rsi,rsi
       je        near ptr M00_L38
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<System.Reflection.MethodInfo>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L39
       mov       rdx,rsi
       mov       rcx,offset MT_System.Reflection.MethodInfo[]
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
       mov       rbp,rax
       test      rbp,rbp
       je        near ptr M00_L41
       cmp       dword ptr [rbp+8],0
       je        near ptr M00_L40
       mov       rcx,offset MT_System.Linq.Enumerable+ArrayWhereIterator<System.Reflection.MethodInfo>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [r14+10],eax
       lea       rcx,[r14+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+20]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
M00_L16:
       mov       rdx,r14
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<System.Reflection.MethodInfo>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M00_L47
       mov       rdx,offset MT_System.Linq.Enumerable+ArrayWhereIterator<System.Reflection.MethodInfo>
       cmp       [rax],rdx
       jne       near ptr M00_L46
       mov       rdx,[rax+18]
       test      rdx,rdx
       je        near ptr M00_L21
       lea       r14,[rdx+10]
       mov       esi,[rdx+8]
M00_L17:
       mov       rdi,[rax+20]
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rsp+140],ymm0
       vmovdqu   ymmword ptr [rsp+160],ymm0
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rsp+48],ymm0
       vmovdqu   ymmword ptr [rsp+68],ymm0
       vmovdqu   ymmword ptr [rsp+88],ymm0
       vmovdqu   ymmword ptr [rsp+0A8],ymm0
       vmovdqu   ymmword ptr [rsp+0C8],ymm0
       vmovdqu   ymmword ptr [rsp+0E8],ymm0
       vmovdqu   ymmword ptr [rsp+100],ymm0
       xor       edx,edx
       mov       [rsp+38],edx
       mov       [rsp+3C],edx
       mov       [rsp+40],edx
       lea       rdx,[rsp+140]
       mov       [rsp+120],rdx
       mov       dword ptr [rsp+128],8
       lea       rdx,[rsp+140]
       mov       [rsp+130],rdx
       mov       dword ptr [rsp+138],8
       test      esi,esi
       jle       short M00_L20
       xor       ebp,ebp
M00_L18:
       mov       r15,[r14+rbp]
       mov       rdx,r15
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       test      eax,eax
       je        short M00_L19
       mov       rcx,[rsp+130]
       mov       edx,[rsp+138]
       mov       eax,[rsp+40]
       cmp       eax,edx
       jae       near ptr M00_L43
       mov       edx,eax
       lea       rcx,[rcx+rdx*8]
       mov       rdx,r15
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       ecx,[rsp+40]
       inc       ecx
       mov       [rsp+40],ecx
M00_L19:
       add       rbp,8
       dec       esi
       jne       short M00_L18
M00_L20:
       mov       esi,[rsp+3C]
       add       esi,[rsp+40]
       jo        near ptr M00_L49
       mov       eax,esi
       test      eax,eax
       je        short M00_L22
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Reflection.MethodInfo[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       mov       r8,offset MT_System.Reflection.MethodInfo[]
       cmp       [rdi],r8
       jne       near ptr M00_L44
       lea       r8,[rdi+10]
       mov       [rsp+20],r8
       mov       [rsp+28],esi
       lea       r8,[rsp+20]
       lea       rcx,[rsp+38]
       mov       rdx,offset MT_System.Collections.Generic.SegmentedArrayBuilder<System.Reflection.MethodInfo>
       call      qword ptr [7FFE77A6C618]; System.Collections.Generic.SegmentedArrayBuilder`1[[System.__Canon, System.Private.CoreLib]].ToSpanInlined(System.Span`1<System.__Canon>)
       jmp       short M00_L24
M00_L21:
       xor       r14d,r14d
       xor       esi,esi
       jmp       near ptr M00_L17
M00_L22:
       test      byte ptr [7FFE77AC6078],1
       je        near ptr M00_L45
M00_L23:
       mov       rdx,1631BC02180
       mov       rdi,[rdx]
M00_L24:
       mov       r8d,[rsp+38]
       test      r8d,r8d
       jne       short M00_L26
M00_L25:
       mov       rdx,rdi
       mov       rcx,7FFE77A2D4C0
       call      qword ptr [7FFE7789C210]; System.Array.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       mov       [rsp+30],rax
       mov       rcx,[rbx+18]
       lea       r8,[rsp+30]
       mov       rdx,7FFE77A2F9A8
       cmp       [rcx],ecx
       call      qword ptr [7FFE779AEE08]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,198
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M00_L26:
       lea       rcx,[rsp+38]
       mov       rdx,offset MT_System.Collections.Generic.SegmentedArrayBuilder<System.Reflection.MethodInfo>
       call      qword ptr [7FFE779AED48]; System.Collections.Generic.SegmentedArrayBuilder`1[[System.__Canon, System.Private.CoreLib]].ReturnArrays(Int32)
       jmp       short M00_L25
M00_L27:
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache+MemberInfoCache<System.Reflection.RuntimeMethodInfo>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       mov       rdx,rbp
       xor       r8d,r8d
       call      00007FFED6E8EEF0
       mov       rcx,rax
       test      rcx,rcx
       cmove     rcx,rbp
       jmp       near ptr M00_L03
M00_L28:
       xor       edx,edx
       xor       r8d,r8d
       xor       r9d,r9d
       call      qword ptr [7FFE772AD278]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
       mov       rsi,rax
       jmp       near ptr M00_L04
M00_L29:
       mov       dword ptr [rsp+194],4
       jmp       near ptr M00_L10
M00_L30:
       mov       r15d,[rsp+194]
       add       r15d,r15d
       lea       rdx,[rsp+180]
       mov       r8d,r15d
       mov       rcx,7FFE77427580
       call      qword ptr [7FFE772AD488]; System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
       mov       [rsp+194],r15d
       jmp       near ptr M00_L06
M00_L31:
       mov       rcx,offset MT_System.Array+EmptyArray<System.Reflection.MethodInfo>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1631BC02180
       mov       rsi,[rcx]
       jmp       near ptr M00_L14
M00_L32:
       mov       rcx,offset MT_System.Reflection.MethodInfo[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rdi
       xor       edx,edx
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       near ptr M00_L14
M00_L33:
       mov       ecx,45
       mov       edx,0D
       call      qword ptr [7FFE779155A8]
       int       3
M00_L34:
       mov       edx,ebp
       mov       rcx,offset MT_System.Reflection.MethodInfo[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rsi,rax
       jmp       near ptr M00_L14
M00_L35:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L13
M00_L36:
       call      qword ptr [7FFE7791D7B8]
       jmp       near ptr M00_L13
M00_L37:
       mov       rcx,offset MT_System.Func<System.Reflection.MethodInfo, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,1631BC020A8
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Core.TypeHelper+<>c.<GetAllPublicMethods>b__24_0(System.Reflection.MethodInfo)
       call      qword ptr [7FFE772A6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1631BC020D8
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L15
M00_L38:
       mov       ecx,11
       call      qword ptr [7FFE77527DB0]
       int       3
M00_L39:
       mov       rcx,rax
       mov       rdx,rdi
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+8]
       mov       r14,rax
       jmp       near ptr M00_L16
M00_L40:
       mov       rcx,offset MT_System.Array+EmptyArray<System.Reflection.MethodInfo>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,1631BC02180
       mov       r14,[rdx]
       jmp       near ptr M00_L16
M00_L41:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Generic.List<System.Reflection.MethodInfo>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r14,rax
       test      r14,r14
       je        short M00_L42
       mov       rcx,offset MT_System.Linq.Enumerable+ListWhereIterator<System.Reflection.MethodInfo>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,r14
       mov       r8,rdi
       call      qword ptr [7FFE77A6C498]
       mov       r14,rsi
       jmp       near ptr M00_L16
M00_L42:
       mov       rcx,offset MT_System.Linq.Enumerable+IEnumerableWhereIterator<System.Reflection.MethodInfo>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       rdx,rsi
       mov       r8,rdi
       call      qword ptr [7FFE77A6C4B0]
       jmp       near ptr M00_L16
M00_L43:
       lea       rcx,[rsp+38]
       mov       r8,r15
       mov       rdx,offset MT_System.Collections.Generic.SegmentedArrayBuilder<System.Reflection.MethodInfo>
       call      qword ptr [7FFE779AEA30]; System.Collections.Generic.SegmentedArrayBuilder`1[[System.__Canon, System.Private.CoreLib]].AddSlow(System.__Canon)
       jmp       near ptr M00_L19
M00_L44:
       call      qword ptr [7FFE77A66F10]
       int       3
M00_L45:
       mov       rcx,offset MT_System.Array+EmptyArray<System.Reflection.MethodInfo>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L23
M00_L46:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rdi,rax
       jmp       near ptr M00_L25
M00_L47:
       mov       rdx,r14
       mov       rcx,offset MT_System.Collections.Generic.ICollection<System.Reflection.MethodInfo>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M00_L48
       mov       rdx,rax
       mov       rcx,7FFE77B945F0
       call      qword ptr [7FFE77707738]; System.Linq.Enumerable.ICollectionToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>)
       mov       rdi,rax
       jmp       near ptr M00_L25
M00_L48:
       mov       rdx,r14
       mov       rcx,7FFE77B94678
       call      qword ptr [7FFE77A671C8]
       mov       rdi,rax
       jmp       near ptr M00_L25
M00_L49:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 1929
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
       je        near ptr M01_L08
M01_L00:
       mov       rcx,[rbx+10]
       mov       rdx,[rcx]
       mov       rdi,rdx
       test      rdi,rdi
       je        short M01_L01
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache
       cmp       [rdi],rcx
       jne       near ptr M01_L09
M01_L01:
       test      rdi,rdi
       jne       near ptr M01_L07
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
       call      00007FFED6E34140
       mov       r14,rax
       test      r14,r14
       je        near ptr M01_L10
M01_L02:
       mov       rax,[r14+8]
       test      rax,rax
       jne       near ptr M01_L05
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
       mov       rax,7FFE77406D90
       mov       [rbp-78],rax
       lea       rax,[M01_L03]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFED6DD50B0
       call      rax
M01_L03:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFED71EE808],0
       je        short M01_L04
       call      qword ptr [7FFED71DC608]; CORINFO_HELP_STOP_FOR_GC
M01_L04:
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
M01_L05:
       cmp       rax,rbx
       sete      cl
       mov       rdi,[rbp-0A0]
       mov       [rdi+9C],cl
       mov       rcx,[rbx+10]
       mov       rdx,rdi
       xor       r8d,r8d
       call      00007FFED6EB03C0
       mov       rdx,rax
       test      rdx,rdx
       je        short M01_L06
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache
       cmp       [rdx],rcx
       jne       short M01_L11
M01_L06:
       test      rdx,rdx
       cmovne    rdi,rdx
M01_L07:
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
M01_L08:
       mov       [rbp-40],rbx
       lea       rcx,[rbp-40]
       mov       edx,1
       call      qword ptr [7FFE77A6E028]; System.RuntimeTypeHandle.GetGCHandle(System.Runtime.InteropServices.GCHandleType)
       mov       rdx,rax
       lea       rcx,[rbx+10]
       xor       eax,eax
       lock cmpxchg [rcx],rdx
       test      rax,rax
       je        near ptr M01_L00
       lea       rcx,[rbp-40]
       call      qword ptr [7FFE77A67720]
       jmp       near ptr M01_L00
M01_L09:
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M01_L10:
       mov       [rbp+10],rbx
       mov       rcx,rbx
       call      qword ptr [7FFE772A7C48]; System.RuntimeTypeHandle.<GetModule>g__GetModuleWorker|48_0(System.RuntimeType)
       mov       r14,rax
       mov       rbx,[rbp+10]
       jmp       near ptr M01_L02
M01_L11:
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
       jbe       short M02_L00
       lea       rax,[rcx+rdx*8+10]
       mov       rcx,[rcx]
       mov       rdx,[rcx+30]
       test      r8,r8
       je        short M02_L02
       cmp       rdx,[r8]
       je        short M02_L01
       mov       r10,offset MT_System.Object[]
       cmp       rcx,r10
       je        short M02_L01
       mov       rcx,rax
       add       rsp,28
       jmp       qword ptr [7FFE772AD890]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
M02_L00:
       call      qword ptr [7FFE77A641B0]
       int       3
M02_L01:
       mov       rcx,rax
       mov       rdx,r8
       add       rsp,28
       jmp       near ptr 00007FFED6EDE630
M02_L02:
       xor       ecx,ecx
       mov       [rax],rcx
       add       rsp,28
       ret
; Total bytes of code 94
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
       mov       r8,1631BC00038
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
       jne       short M04_L04
       mov       rsi,rcx
       xor       rsi,[r11+10]
       cmp       rsi,1
       ja        short M04_L04
       cmp       ebx,[r11]
       jne       short M04_L05
M04_L01:
       cmp       esi,1
       jne       short M04_L03
M04_L02:
       mov       rax,rdx
       pop       rbx
       pop       rsi
       ret
M04_L03:
       test      esi,esi
       jne       short M04_L06
       xor       edx,edx
       jmp       short M04_L02
M04_L04:
       test      ebx,ebx
       je        short M04_L05
       inc       r9d
       add       r10d,r9d
       and       r10d,[r8+4]
       cmp       r9d,8
       jl        short M04_L00
M04_L05:
       mov       esi,2
       jmp       short M04_L01
M04_L06:
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFE772AD8A8]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny_NoCacheLookup(Void*, System.Object)
; Total bytes of code 168
```
```assembly
; System.Collections.Generic.SegmentedArrayBuilder`1[[System.__Canon, System.Private.CoreLib]].ToSpanInlined(System.Span`1<System.__Canon>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[r8]
       mov       edi,[r8+8]
       mov       ebp,[rbx]
       test      ebp,ebp
       je        near ptr M05_L04
       mov       rdx,[rbx+0E8]
       mov       r14d,[rbx+0F0]
       cmp       r14d,edi
       jg        near ptr M05_L14
       mov       r15d,r14d
       shl       r15,3
       mov       r8,r15
       cmp       r8,4000
       ja        near ptr M05_L08
       mov       rcx,rsi
       call      00007FFED6E70160
       cmp       dword ptr [7FFED71EE808],0
       jne       near ptr M05_L07
M05_L00:
       add       rsi,r15
       sub       edi,r14d
       dec       ebp
       je        short M05_L04
       lea       r14,[rbx+10]
       cmp       ebp,1B
       ja        near ptr M05_L11
       xor       r15d,r15d
M05_L01:
       mov       rcx,[r14+r15*8]
       test      rcx,rcx
       je        near ptr M05_L06
       lea       rdx,[rcx+10]
       mov       r13d,[rcx+8]
M05_L02:
       cmp       r13d,edi
       jg        near ptr M05_L14
       mov       r12d,r13d
       shl       r12,3
       mov       r8,r12
       cmp       r8,4000
       ja        near ptr M05_L10
       mov       rcx,rsi
       call      00007FFED6E70160
       cmp       dword ptr [7FFED71EE808],0
       jne       near ptr M05_L09
M05_L03:
       add       r12,rsi
       mov       rsi,r12
       sub       edi,r13d
       inc       r15d
       cmp       r15d,ebp
       jl        short M05_L01
M05_L04:
       lea       rcx,[rbx+0F8]
       mov       edx,[rbx+8]
       cmp       edx,[rcx+8]
       ja        short M05_L11
       mov       rax,[rcx]
       cmp       edx,edi
       ja        near ptr M05_L14
       mov       r8d,edx
       shl       r8,3
       cmp       r8,4000
       ja        short M05_L13
       mov       rcx,rsi
       mov       rdx,rax
       call      00007FFED6E70160
       cmp       dword ptr [7FFED71EE808],0
       jne       short M05_L12
M05_L05:
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
M05_L06:
       xor       edx,edx
       xor       r13d,r13d
       jmp       near ptr M05_L02
M05_L07:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M05_L00
M05_L08:
       mov       rcx,rsi
       call      qword ptr [7FFE7791D7B8]
       jmp       near ptr M05_L00
M05_L09:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M05_L03
M05_L10:
       mov       rcx,rsi
       call      qword ptr [7FFE7791D7B8]
       jmp       near ptr M05_L03
M05_L11:
       call      qword ptr [7FFE774470D8]
       int       3
M05_L12:
       call      CORINFO_HELP_POLL_GC
       jmp       short M05_L05
M05_L13:
       mov       rcx,rsi
       mov       rdx,rax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FFE7791D7B8]
M05_L14:
       call      qword ptr [7FFE777B7F30]
       int       3
; Total bytes of code 406
```
```assembly
; System.Array.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       push      rsi
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        short M06_L02
       cmp       dword ptr [rbx+8],0
       je        short M06_L03
       mov       rdx,[rcx+18]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M06_L01
M06_L00:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M06_L01:
       mov       rdx,7FFE77AD07D0
       call      qword ptr [7FFE77527AB0]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       short M06_L00
M06_L02:
       mov       ecx,2
       call      qword ptr [7FFE7752C180]
       int       3
M06_L03:
       mov       rdx,[rcx+18]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M06_L04
       jmp       short M06_L05
M06_L04:
       mov       rdx,7FFE77AD07D0
       call      qword ptr [7FFE77527AB0]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdx,rax
M06_L05:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rax]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 156
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
; System.Collections.Generic.SegmentedArrayBuilder`1[[System.__Canon, System.Private.CoreLib]].ReturnArrays(Int32)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,0A8
       mov       [rsp+0A0],rdx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       ebx,r8d
       cmp       [rdi],dil
       lea       rbp,[rdi+10]
       dec       ebx
       cmp       ebx,1B
       ja        near ptr M08_L17
       xor       r14d,r14d
       cmp       r14d,ebx
       jge       near ptr M08_L07
M08_L00:
       mov       r15,[rbp+r14*8]
       test      r15,r15
       je        near ptr M08_L45
       mov       rdx,[r15]
       movzx     ecx,word ptr [rdx]
       mov       eax,[r15+8]
       imul      rax,rcx
       lea       rcx,[r15+10]
       test      dword ptr [rdx],1000000
       je        near ptr M08_L18
       mov       rdx,rax
       shr       rdx,3
       call      qword ptr [7FFE779AED78]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
M08_L01:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],98
       jle       near ptr M08_L15
       mov       rcx,[rcx+98]
       test      rcx,rcx
       je        near ptr M08_L15
M08_L02:
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,[rax]
       mov       r13,rcx
       mov       rcx,offset MT_System.Buffers.SharedArrayPool<System.Reflection.MethodInfo>
       cmp       [r13],rcx
       jne       near ptr M08_L39
       mov       ecx,[r15+8]
       dec       ecx
       or        ecx,0F
       xor       r12d,r12d
       lzcnt     r12d,ecx
       xor       r12d,1F
       add       r12d,0FFFFFFFD
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+238],0A
       jle       near ptr M08_L19
       mov       rcx,[rcx+240]
       mov       rax,[rcx+50]
       test      rax,rax
       je        near ptr M08_L19
M08_L03:
       mov       rax,[rax+10]
       test      rax,rax
       je        near ptr M08_L20
M08_L04:
       xor       r8d,r8d
       mov       dword ptr [rsp+98],1
       mov       ecx,[rax+8]
       cmp       ecx,r12d
       jbe       short M08_L05
       mov       dword ptr [rsp+9C],1
       mov       ecx,10
       shlx      ecx,ecx,r12d
       cmp       [r15+8],ecx
       jne       near ptr M08_L40
       mov       ecx,r12d
       shl       rcx,4
       lea       rax,[rax+rcx+10]
       mov       [rsp+58],rax
       mov       r9,[rax]
       mov       [rsp+50],r9
       mov       rcx,rax
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       rdx,[rsp+58]
       mov       [rdx+8],ecx
       cmp       qword ptr [rsp+50],0
       jne       near ptr M08_L21
       mov       r8d,[rsp+9C]
M08_L05:
       mov       rcx,1631BC00C90
       mov       rax,[rcx]
       mov       [rsp+60],rax
       cmp       byte ptr [rax+9D],0
       jne       near ptr M08_L36
M08_L06:
       inc       r14d
       cmp       r14d,ebx
       jl        near ptr M08_L00
M08_L07:
       cmp       ebx,1B
       jae       near ptr M08_L67
       mov       edx,ebx
       mov       rbx,[rbp+rdx*8]
       mov       edx,[rdi+8]
       test      rbx,rbx
       je        near ptr M08_L45
       lea       rcx,[rbx+10]
       xor       eax,eax
       mov       r8,[rbx]
       cmp       dword ptr [r8+4],18
       jne       near ptr M08_L41
M08_L08:
       mov       r10d,eax
       neg       r10d
       test      eax,eax
       jg        near ptr M08_L42
       mov       eax,r10d
       or        eax,edx
       jl        near ptr M08_L42
       lea       eax,[r10+rdx]
       cmp       eax,[rbx+8]
       ja        near ptr M08_L42
       movzx     eax,word ptr [r8]
       mov       r10d,r10d
       imul      r10,rax
       add       rcx,r10
       mov       edx,edx
       imul      rdx,rax
       test      dword ptr [r8],1000000
       je        near ptr M08_L43
       shr       rdx,3
       call      qword ptr [7FFE779AED78]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
M08_L09:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],98
       jle       near ptr M08_L16
       mov       rcx,[rcx+98]
       test      rcx,rcx
       je        near ptr M08_L16
M08_L10:
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,[rax]
       mov       rsi,rcx
       mov       rcx,offset MT_System.Buffers.SharedArrayPool<System.Reflection.MethodInfo>
       cmp       [rsi],rcx
       jne       near ptr M08_L66
       mov       ecx,[rbx+8]
       dec       ecx
       or        ecx,0F
       xor       edi,edi
       lzcnt     edi,ecx
       xor       edi,1F
       add       edi,0FFFFFFFD
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+238],0A
       jle       near ptr M08_L44
       mov       rcx,[rcx+240]
       mov       rax,[rcx+50]
       test      rax,rax
       je        near ptr M08_L44
M08_L11:
       mov       rax,[rax+10]
       test      rax,rax
       je        near ptr M08_L46
M08_L12:
       xor       ebp,ebp
       mov       r14d,1
       mov       ecx,[rax+8]
       cmp       ecx,edi
       jbe       short M08_L13
       mov       ebp,1
       mov       ecx,10
       shlx      ecx,ecx,edi
       cmp       [rbx+8],ecx
       jne       near ptr M08_L47
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
       jne       near ptr M08_L48
M08_L13:
       mov       rcx,1631BC00C90
       mov       r15,[rcx]
       cmp       byte ptr [r15+9D],0
       jne       near ptr M08_L63
M08_L14:
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
M08_L15:
       mov       rcx,rsi
       mov       rdx,7FFE77AD17B8
       call      qword ptr [7FFE772AC570]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M08_L02
M08_L16:
       mov       rcx,rsi
       mov       rdx,7FFE77AD17B8
       call      qword ptr [7FFE772AC570]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M08_L10
M08_L17:
       call      qword ptr [7FFE774470D8]
       int       3
M08_L18:
       mov       rdx,rax
       call      qword ptr [7FFE772A57E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
       jmp       near ptr M08_L01
M08_L19:
       mov       ecx,0A
       call      qword ptr [7FFE777B43F0]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M08_L03
M08_L20:
       mov       rcx,r13
       call      qword ptr [7FFE779AEDA8]; System.Buffers.SharedArrayPool`1[[System.__Canon, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
       jmp       near ptr M08_L04
M08_L21:
       mov       rcx,[r13+10]
       cmp       r12d,[rcx+8]
       jae       near ptr M08_L67
       mov       edx,r12d
       mov       r8,[rcx+rdx*8+10]
       test      r8,r8
       jne       short M08_L22
       mov       rcx,r13
       mov       edx,r12d
       call      qword ptr [7FFE77A675A0]
       mov       r8,rax
M08_L22:
       mov       rdx,[r8+8]
       mov       [rsp+48],rdx
       mov       rcx,offset MT_System.Threading.ProcessorIdCache
       call      qword ptr [7FFE772A5740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       cmp       byte ptr [7FFE771EB18C],0
       je        short M08_L23
       call      qword ptr [7FFE77A66640]
       mov       edx,eax
       mov       [rsp+80],edx
       jmp       short M08_L25
M08_L23:
       mov       ecx,0B
       call      qword ptr [7FFE77A66658]
       mov       eax,[rax+10]
       mov       [rsp+7C],eax
       mov       ecx,0B
       call      qword ptr [7FFE77A66658]
       mov       edx,[rsp+7C]
       lea       ecx,[rdx-1]
       mov       [rax+10],ecx
       movzx     eax,dx
       test      eax,eax
       jne       short M08_L24
       call      qword ptr [7FFE77A66670]
       mov       edx,eax
       mov       [rsp+80],edx
       jmp       short M08_L25
M08_L24:
       sar       edx,10
       mov       [rsp+80],edx
M08_L25:
       mov       rcx,offset MT_System.Buffers.SharedArrayPoolStatics
       call      qword ptr [7FFE772A5740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       eax,[rsp+80]
       xor       edx,edx
       div       dword ptr [7FFE771EB180]
       mov       eax,edx
       xor       edx,edx
       jmp       near ptr M08_L32
M08_L26:
       cmp       eax,[r8+8]
       jae       near ptr M08_L67
       mov       [rsp+88],eax
       mov       ecx,eax
       mov       r10,[r8+rcx*8+10]
       mov       [rsp+40],r10
       cmp       [r10],r10b
       xor       r9d,r9d
       mov       [rsp+78],r9d
       mov       rcx,r10
       call      qword ptr [7FFE7789D278]; System.Threading.Monitor.Enter(System.Object)
       mov       rax,[rsp+40]
       mov       rcx,[rax+8]
       mov       r8d,[rax+10]
       mov       [rsp+74],r8d
       cmp       [rcx+8],r8d
       jbe       short M08_L28
       test      r8d,r8d
       jne       short M08_L29
       xor       edx,edx
       mov       [rax+14],edx
M08_L27:
       mov       edx,r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,[rsp+50]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rsp+74]
       inc       ecx
       mov       rax,[rsp+40]
       mov       [rax+10],ecx
       mov       dword ptr [rsp+78],1
M08_L28:
       mov       rcx,rax
       call      qword ptr [7FFE772A6820]; System.Threading.Monitor.Exit(System.Object)
       cmp       dword ptr [rsp+78],0
       je        short M08_L30
       jmp       short M08_L33
M08_L29:
       jmp       short M08_L27
M08_L30:
       mov       eax,[rsp+88]
       inc       eax
       mov       ecx,eax
       mov       r8,[rsp+48]
       cmp       [r8+8],ecx
       jne       short M08_L31
       xor       ecx,ecx
M08_L31:
       mov       edx,[rsp+84]
       inc       edx
       mov       eax,ecx
M08_L32:
       mov       r8,[rsp+48]
       mov       [rsp+84],edx
       cmp       [r8+8],edx
       jg        near ptr M08_L26
       jmp       short M08_L34
M08_L33:
       mov       r10d,1
       jmp       short M08_L35
M08_L34:
       xor       r10d,r10d
M08_L35:
       mov       [rsp+98],r10d
       mov       r8d,[rsp+9C]
       jmp       near ptr M08_L05
M08_L36:
       cmp       dword ptr [r15+8],0
       mov       [rsp+9C],r8d
       je        near ptr M08_L06
       mov       rcx,r15
       call      qword ptr [7FFE777BC600]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+94],eax
       mov       edx,[r15+8]
       mov       [rsp+90],edx
       mov       rcx,r13
       call      qword ptr [7FFE777BC600]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,[rsp+60]
       mov       r8d,[rsp+94]
       mov       r9d,[rsp+90]
       mov       edx,3
       call      qword ptr [7FFE77A66880]
       mov       eax,[rsp+9C]
       test      [rsp+98],eax
       jne       near ptr M08_L06
       mov       rcx,r15
       call      qword ptr [7FFE777BC600]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+8C],eax
       mov       r15d,[r15+8]
       mov       rcx,r13
       call      qword ptr [7FFE777BC600]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       cmp       dword ptr [rsp+9C],0
       jne       short M08_L37
       mov       ecx,0FFFFFFFF
       mov       edx,1
       jmp       short M08_L38
M08_L37:
       mov       ecx,r12d
       xor       edx,edx
M08_L38:
       mov       [rsp+20],ecx
       mov       [rsp+28],edx
       mov       rcx,[rsp+60]
       mov       edx,[rsp+8C]
       mov       r8d,r15d
       call      qword ptr [7FFE77A66898]
       jmp       near ptr M08_L06
M08_L39:
       mov       rcx,r13
       mov       rdx,r15
       xor       r8d,r8d
       call      qword ptr [7FFE77A2EA48]; System.Buffers.SharedArrayPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon[], Boolean)
       jmp       near ptr M08_L06
M08_L40:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE77A66850]
       mov       rbp,rax
       mov       ecx,29B
       mov       rdx,7FFE771E4000
       call      qword ptr [7FFE775276F0]
       mov       r8,rax
       mov       rdx,rbp
       mov       rcx,rbx
       call      qword ptr [7FFE77705B30]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M08_L41:
       mov       r10d,[r8+4]
       add       r10d,0FFFFFFE8
       shr       r10d,3
       movsxd    rax,r10d
       mov       eax,[rcx+rax*4]
       shl       r10d,3
       movsxd    r10,r10d
       add       rcx,r10
       jmp       near ptr M08_L08
M08_L42:
       call      qword ptr [7FFE77A67678]
       int       3
M08_L43:
       call      qword ptr [7FFE772A57E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
       jmp       near ptr M08_L09
M08_L44:
       mov       ecx,0A
       call      qword ptr [7FFE777B43F0]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M08_L11
M08_L45:
       mov       ecx,2
       call      qword ptr [7FFE7752C180]
       int       3
M08_L46:
       mov       rcx,rsi
       call      qword ptr [7FFE779AEDA8]; System.Buffers.SharedArrayPool`1[[System.__Canon, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
       jmp       near ptr M08_L12
M08_L47:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE77A66850]
       mov       rsi,rax
       mov       ecx,29B
       mov       rdx,7FFE771E4000
       call      qword ptr [7FFE775276F0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE77705B30]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M08_L48:
       mov       rcx,[rsi+10]
       cmp       edi,[rcx+8]
       jae       near ptr M08_L67
       mov       edx,edi
       mov       rax,[rcx+rdx*8+10]
       test      rax,rax
       jne       short M08_L49
       mov       rcx,rsi
       mov       edx,edi
       call      qword ptr [7FFE77A675A0]
M08_L49:
       mov       r14,[rax+8]
       mov       rcx,offset MT_System.Threading.ProcessorIdCache
       call      qword ptr [7FFE772A5740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       cmp       byte ptr [7FFE771EB18C],0
       je        short M08_L50
       call      qword ptr [7FFE77A66640]
       mov       r15d,eax
       jmp       short M08_L52
M08_L50:
       mov       ecx,0B
       call      qword ptr [7FFE77A66658]
       mov       r15d,[rax+10]
       mov       ecx,0B
       call      qword ptr [7FFE77A66658]
       lea       ecx,[r15-1]
       mov       [rax+10],ecx
       movzx     eax,r15w
       test      eax,eax
       jne       short M08_L51
       call      qword ptr [7FFE77A66670]
       mov       r15d,eax
       jmp       short M08_L52
M08_L51:
       sar       r15d,10
M08_L52:
       mov       rcx,offset MT_System.Buffers.SharedArrayPoolStatics
       call      qword ptr [7FFE772A5740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       eax,r15d
       xor       edx,edx
       div       dword ptr [7FFE771EB180]
       mov       r15d,edx
       xor       r12d,r12d
       jmp       near ptr M08_L59
M08_L53:
       cmp       r15d,[r14+8]
       jae       near ptr M08_L67
       mov       ecx,r15d
       mov       rax,[r14+rcx*8+10]
       mov       [rsp+38],rax
       cmp       [rax],al
       xor       edx,edx
       mov       [rsp+70],edx
       mov       rcx,rax
       call      qword ptr [7FFE7789D278]; System.Threading.Monitor.Enter(System.Object)
       mov       rax,[rsp+38]
       mov       rcx,[rax+8]
       mov       r8d,[rax+10]
       mov       [rsp+6C],r8d
       cmp       [rcx+8],r8d
       jbe       short M08_L55
       test      r8d,r8d
       jne       short M08_L56
       xor       edx,edx
       mov       [rax+14],edx
M08_L54:
       mov       edx,r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rsp+6C]
       inc       ecx
       mov       rax,[rsp+38]
       mov       [rax+10],ecx
       mov       dword ptr [rsp+70],1
M08_L55:
       mov       rcx,rax
       call      qword ptr [7FFE772A6820]; System.Threading.Monitor.Exit(System.Object)
       cmp       dword ptr [rsp+70],0
       je        short M08_L57
       jmp       short M08_L60
M08_L56:
       jmp       short M08_L54
M08_L57:
       inc       r15d
       cmp       [r14+8],r15d
       jne       short M08_L58
       xor       r15d,r15d
M08_L58:
       inc       r12d
M08_L59:
       cmp       [r14+8],r12d
       jg        near ptr M08_L53
       jmp       short M08_L61
M08_L60:
       mov       r14d,1
       jmp       short M08_L62
M08_L61:
       xor       r14d,r14d
M08_L62:
       jmp       near ptr M08_L13
M08_L63:
       cmp       dword ptr [rbx+8],0
       je        near ptr M08_L14
       mov       rcx,rbx
       call      qword ptr [7FFE777BC600]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r13d,eax
       mov       r12d,[rbx+8]
       mov       rcx,rsi
       call      qword ptr [7FFE777BC600]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,r15
       mov       r8d,r13d
       mov       r9d,r12d
       mov       edx,3
       call      qword ptr [7FFE77A66880]
       test      r14d,ebp
       jne       near ptr M08_L14
       mov       rcx,rbx
       call      qword ptr [7FFE777BC600]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r14d,eax
       mov       ebx,[rbx+8]
       mov       rcx,rsi
       call      qword ptr [7FFE777BC600]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       test      ebp,ebp
       jne       short M08_L64
       mov       ecx,0FFFFFFFF
       mov       edx,1
       jmp       short M08_L65
M08_L64:
       mov       ecx,edi
       xor       edx,edx
M08_L65:
       mov       [rsp+20],ecx
       mov       [rsp+28],edx
       mov       rcx,r15
       mov       edx,r14d
       mov       r8d,ebx
       call      qword ptr [7FFE77A66898]
       jmp       near ptr M08_L14
M08_L66:
       mov       rcx,rsi
       mov       rdx,rbx
       xor       r8d,r8d
       add       rsp,0A8
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FFE77A2EA48]; System.Buffers.SharedArrayPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon[], Boolean)
M08_L67:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 2372
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
       mov       rax,8BBB7DE2CF0F
       mov       [rbp],rax
       mov       rsi,rcx
       mov       rbx,rdx
       mov       edi,r8d
       mov       r14d,r9d
       test      rbx,rbx
       je        short M09_L00
       cmp       dword ptr [rbx+8],0
       jne       short M09_L03
M09_L00:
       xor       r8d,r8d
       mov       [rbp+8],r8
       mov       [rbp+10],r8d
       mov       [rsp+20],r14d
       lea       r8,[rbp+8]
       mov       rcx,rsi
       mov       r9d,edi
       mov       rdx,1A3B0CB0008
       call      qword ptr [7FFE772AD2D8]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].GetListByName(System.String, System.Span`1<Byte>, MemberListType, CacheType)
       mov       [rbp+18],rax
M09_L01:
       mov       rcx,7FFE77C2D7C0
       call      CORINFO_HELP_COUNTPROFILE32
       lea       rdx,[rbp+18]
       mov       rcx,rsi
       mov       r8,rbx
       mov       r9d,edi
       call      qword ptr [7FFE772AD518]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Insert(System.__Canon[] ByRef, System.String, MemberListType)
       mov       rax,[rbp+18]
       mov       rcx,8BBB7DE2CF0F
       cmp       [rbp],rcx
       je        short M09_L02
       call      CORINFO_HELP_FAIL_FAST
M09_L02:
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
M09_L03:
       cmp       r14d,1
       je        near ptr M09_L07
M09_L04:
       mov       rcx,1631BC00220
       mov       r15,[rcx]
       mov       rcx,r15
       mov       rdx,7FFE77C2D6B0
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rcx,r15
       mov       rdx,rbx
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+18]
       mov       r15d,eax
       cmp       r15d,400
       ja        near ptr M09_L10
       mov       rcx,7FFE77C2D7B8
       call      CORINFO_HELP_COUNTPROFILE32
       mov       edx,r15d
       mov       r13,rdx
       test      r13,r13
       je        short M09_L06
       mov       rcx,r13
       add       rcx,0F
       and       rcx,0FFFFFFFFFFFFFFF0
       add       rsp,30
       neg       rcx
       add       rcx,rsp
       jb        short M09_L05
       xor       ecx,ecx
M09_L05:
       test      [rsp],esp
       sub       rsp,1000
       cmp       rsp,rcx
       jae       short M09_L05
       mov       rsp,rcx
       test      [rsp],esp
       sub       rsp,30
       lea       r13,[rsp+30]
M09_L06:
       mov       rcx,7FFE77C2D7BC
       call      CORINFO_HELP_COUNTPROFILE32
       mov       [rbp+8],r13
       mov       [rbp+10],r15d
       mov       [rsp+20],r14d
       lea       r8,[rbp+8]
       mov       rdx,rbx
       mov       rcx,rsi
       mov       r9d,edi
       call      qword ptr [7FFE772AD2D8]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].GetListByName(System.String, System.Span`1<Byte>, MemberListType, CacheType)
       mov       [rbp+18],rax
       jmp       near ptr M09_L01
M09_L07:
       cmp       word ptr [rbx+0C],2E
       je        short M09_L09
       cmp       word ptr [rbx+0C],2A
       je        short M09_L08
       mov       rcx,7FFE77C2D6A0
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M09_L00
M09_L08:
       mov       rcx,7FFE77C2D6A4
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M09_L04
M09_L09:
       mov       rcx,7FFE77C2D6A8
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M09_L04
M09_L10:
       movsxd    rdx,r15d
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       r13,[rax+10]
       mov       r15d,[rax+8]
       jmp       near ptr M09_L06
; Total bytes of code 507
```
```assembly
; System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rdx
       mov       ebx,r8d
       test      ebx,ebx
       jl        near ptr M10_L04
       mov       rdi,[rsi]
       test      rdi,rdi
       je        near ptr M10_L05
       mov       ebp,[rdi+8]
       cmp       ebp,ebx
       je        short M10_L02
       mov       rdx,[rcx+18]
       mov       rax,[rdx+18]
       test      rax,rax
       je        short M10_L03
       mov       rcx,rax
M10_L00:
       mov       edx,ebx
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       lea       rcx,[r14+10]
       lea       rdx,[rdi+10]
       cmp       ebx,ebp
       cmovg     ebx,ebp
       mov       r8d,ebx
       shl       r8,3
       cmp       r8,4000
       ja        near ptr M10_L09
       call      00007FFED6E70160
       cmp       dword ptr [7FFED71EE808],0
       jne       short M10_L08
M10_L01:
       mov       rcx,rsi
       mov       rdx,r14
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M10_L02:
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M10_L03:
       mov       rdx,7FFE77A9EF50
       call      qword ptr [7FFE77527AB0]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M10_L00
M10_L04:
       mov       ecx,45
       mov       edx,0D
       call      qword ptr [7FFE779155A8]
       int       3
M10_L05:
       mov       rdx,[rcx+18]
       mov       rax,[rdx+18]
       test      rax,rax
       je        short M10_L06
       mov       rcx,rax
       jmp       short M10_L07
M10_L06:
       mov       rdx,7FFE77A9EF50
       call      qword ptr [7FFE77527AB0]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M10_L07:
       mov       edx,ebx
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdx,rax
       mov       rcx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       short M10_L02
M10_L08:
       call      CORINFO_HELP_POLL_GC
       jmp       short M10_L01
M10_L09:
       call      qword ptr [7FFE7791D7B8]
       jmp       near ptr M10_L01
; Total bytes of code 257
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M11_L00
       ret
M11_L00:
       jmp       qword ptr [7FFE772A5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```
```assembly
; DotNetTips.Spargine.Core.TypeHelper+<>c.<GetAllPublicMethods>b__24_0(System.Reflection.MethodInfo)
; 		return Array.AsReadOnly(type.GetTypeInfo().DeclaredMethods.Where(m => m.IsPublic).ToArray());
; 		                                                                      ^^^^^^^^^^
       push      rbx
       sub       rsp,20
       mov       rcx,offset MT_System.Reflection.RuntimeMethodInfo
       cmp       [rdx],rcx
       jne       short M12_L01
       mov       ebx,[rdx+5C]
M12_L00:
       and       ebx,7
       cmp       ebx,6
       sete      al
       movzx     eax,al
       add       rsp,20
       pop       rbx
       ret
M12_L01:
       mov       rcx,rdx
       mov       rax,[rdx]
       mov       rax,[rax+50]
       call      qword ptr [rax+20]
       mov       ebx,eax
       jmp       short M12_L00
; Total bytes of code 58
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M13_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M13_L00:
       call      qword ptr [7FFE77A66B38]
       int       3
; Total bytes of code 44
```
```assembly
; System.Collections.Generic.SegmentedArrayBuilder`1[[System.__Canon, System.Private.CoreLib]].AddSlow(System.__Canon)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,68
       mov       [rsp+60],rdx
       mov       rbx,rcx
       mov       rsi,r8
       mov       rdi,rdx
       mov       ecx,[rbx+100]
       mov       edx,ecx
       add       edx,[rbx+4]
       jo        near ptr M14_L55
       mov       [rbx+4],edx
       cmp       dword ptr [rbx+4],7FFFFFC7
       jg        near ptr M14_L43
       movsxd    rbp,ecx
       add       rbp,rbp
       cmp       rbp,10
       jle       short M14_L00
       cmp       rbp,7FFFFFC7
       jle       short M14_L01
       mov       r14d,7FFFFFC7
       jmp       short M14_L02
M14_L00:
       mov       ebp,10
M14_L01:
       mov       r14,rbp
M14_L02:
       lea       rbp,[rbx+10]
       mov       r15d,[rbx]
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],98
       jle       near ptr M14_L19
       mov       rcx,[rcx+98]
       test      rcx,rcx
       je        near ptr M14_L19
M14_L03:
       cmp       r15d,1B
       jae       near ptr M14_L54
       mov       eax,r15d
       lea       rbp,[rbp+rax*8]
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r15,[rax]
       mov       r13d,r14d
       mov       rcx,1631BC00C90
       mov       r12,[rcx]
       lea       ecx,[r13-1]
       or        ecx,0F
       xor       eax,eax
       lzcnt     eax,ecx
       xor       eax,1F
       add       eax,0FFFFFFFD
       mov       [rsp+5C],eax
       mov       rcx,[r15]
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCThreadStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rax+10]
       test      rax,rax
       je        near ptr M14_L20
       mov       r8d,[rsp+5C]
       cmp       [rax+8],r8d
       jbe       near ptr M14_L20
       mov       ecx,r8d
       shl       rcx,4
       mov       r10,[rax+rcx+10]
       test      r10,r10
       je        near ptr M14_L20
       mov       r14,r10
       mov       r13d,[rsp+5C]
       mov       ecx,r13d
       shl       rcx,4
       xor       edx,edx
       mov       [rax+rcx+10],rdx
       cmp       byte ptr [r12+9D],0
       je        near ptr M14_L15
       mov       rcx,r14
       call      qword ptr [7FFE777BC600]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+4C],eax
       mov       edx,[r14+8]
       mov       [rsp+48],edx
       mov       rcx,r15
       call      00007FFED6E834A0
       mov       r9d,eax
       test      r9d,r9d
       je        near ptr M14_L44
M14_L04:
       mov       [rsp+20],r13d
       mov       rcx,r12
       mov       edx,[rsp+4C]
       mov       r8d,[rsp+48]
       call      qword ptr [7FFE77A66628]
       jmp       near ptr M14_L15
M14_L05:
       mov       rcx,r15
       call      qword ptr [7FFE772AE8F8]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       mov       r9d,eax
       jmp       near ptr M14_L14
M14_L06:
       xor       r14d,r14d
       jmp       near ptr M14_L34
M14_L07:
       mov       r14,r10
       test      r14,r14
       jne       near ptr M14_L40
M14_L08:
       mov       ecx,10
       mov       r8d,[rsp+5C]
       shlx      r13d,ecx,r8d
M14_L09:
       mov       rcx,[r15]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx+8]
       cmp       qword ptr [rdx+8],38
       jle       near ptr M14_L36
       mov       rax,[rdx+38]
       test      rax,rax
       je        near ptr M14_L36
       mov       rcx,rax
M14_L10:
       mov       rdx,[rcx+18]
       mov       rax,[rdx+18]
       test      rax,rax
       je        near ptr M14_L37
       mov       rcx,rax
M14_L11:
       movsxd    rdx,r13d
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       cmp       byte ptr [r12+9D],0
       je        near ptr M14_L15
       mov       rcx,r14
       call      00007FFED6E834A0
       mov       r13d,eax
       test      r13d,r13d
       je        near ptr M14_L38
M14_L12:
       mov       eax,[r14+8]
       mov       [rsp+58],eax
       mov       rcx,r15
       call      00007FFED6E834A0
       mov       r9d,eax
       test      r9d,r9d
       je        near ptr M14_L39
M14_L13:
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       rcx,r12
       mov       edx,r13d
       mov       r8d,[rsp+58]
       call      qword ptr [7FFE77A66628]
       mov       eax,[r14+8]
       mov       [rsp+54],eax
       mov       rcx,r15
       call      00007FFED6E834A0
       mov       r9d,eax
       test      r9d,r9d
       je        near ptr M14_L05
M14_L14:
       mov       rcx,[r15+10]
       mov       edx,1
       mov       r8d,2
       mov       r15d,[rsp+5C]
       cmp       [rcx+8],r15d
       cmovg     edx,r8d
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       [rsp+28],edx
       mov       rcx,r12
       mov       edx,r13d
       mov       r8d,[rsp+54]
       call      qword ptr [7FFE77A666B8]
M14_L15:
       mov       rcx,rbp
       mov       rdx,r14
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0A0
       jle       near ptr M14_L41
       mov       rcx,[rcx+0A0]
       test      rcx,rcx
       je        near ptr M14_L41
M14_L16:
       test      r14,r14
       je        near ptr M14_L52
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+20]
       test      rax,rax
       je        near ptr M14_L42
M14_L17:
       cmp       [r14],rax
       jne       near ptr M14_L53
       lea       rdi,[r14+10]
       mov       ebp,[r14+8]
M14_L18:
       mov       [rbx+0F8],rdi
       mov       [rbx+100],ebp
       inc       dword ptr [rbx]
       lea       rcx,[rbx+0F8]
       cmp       dword ptr [rcx+8],0
       jbe       near ptr M14_L54
       mov       rcx,[rcx]
       mov       rdx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       dword ptr [rbx+8],1
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M14_L19:
       mov       rcx,rdi
       mov       rdx,7FFE77AD17B8
       call      qword ptr [7FFE772AC570]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M14_L03
M14_L20:
       mov       rax,[r15+10]
       mov       r8d,[rsp+5C]
       cmp       [rax+8],r8d
       ja        short M14_L26
       test      r13d,r13d
       je        short M14_L21
       test      r13d,r13d
       jge       near ptr M14_L09
       jmp       near ptr M14_L51
M14_L21:
       mov       rcx,[r15]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx+8]
       cmp       qword ptr [rdx+8],40
       jle       short M14_L24
       mov       rax,[rdx+40]
       test      rax,rax
       je        short M14_L24
       mov       rcx,rax
M14_L22:
       mov       rdx,[rcx+18]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M14_L25
M14_L23:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r14,[rax]
       jmp       near ptr M14_L15
M14_L24:
       mov       rdx,7FFE77AD1900
       call      qword ptr [7FFE772AC570]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M14_L22
M14_L25:
       mov       rdx,7FFE77A9C078
       call      qword ptr [7FFE77527AB0]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       short M14_L23
M14_L26:
       mov       ecx,r8d
       mov       rcx,[rax+rcx*8+10]
       test      rcx,rcx
       je        near ptr M14_L08
       mov       r13,[rcx+8]
       test      byte ptr [7FFE77ABE550],1
       je        near ptr M14_L45
M14_L27:
       cmp       byte ptr [7FFE771EB18C],0
       je        near ptr M14_L46
       call      qword ptr [7FFE77A66640]
       mov       r14d,eax
M14_L28:
       test      byte ptr [7FFE77ABE3E0],1
       je        near ptr M14_L48
M14_L29:
       mov       eax,r14d
       xor       edx,edx
       div       dword ptr [7FFE771EB180]
       mov       r14d,edx
       xor       eax,eax
       mov       [rsp+44],eax
       cmp       dword ptr [r13+8],0
       jle       near ptr M14_L50
M14_L30:
       cmp       r14d,[r13+8]
       jae       near ptr M14_L54
       mov       ecx,r14d
       mov       rdx,[r13+rcx*8+10]
       mov       [rsp+30],rdx
       cmp       [rdx],dl
       xor       r8d,r8d
       mov       [rsp+38],r8
       mov       rcx,rdx
       call      00007FFED6E20370
       test      eax,eax
       je        near ptr M14_L49
M14_L31:
       mov       rax,[rsp+30]
       mov       rcx,[rax+8]
       mov       edx,[rax+10]
       dec       edx
       cmp       [rcx+8],edx
       ja        short M14_L35
M14_L32:
       mov       rcx,rax
       call      00007FFED6E6FFC0
       test      eax,eax
       je        short M14_L33
       mov       ecx,eax
       mov       rdx,[rsp+30]
       call      qword ptr [7FFE77A666A0]
M14_L33:
       mov       r10,[rsp+38]
       test      r10,r10
       jne       near ptr M14_L07
       inc       r14d
       cmp       [r13+8],r14d
       je        near ptr M14_L06
M14_L34:
       mov       eax,[rsp+44]
       inc       eax
       cmp       [r13+8],eax
       mov       [rsp+44],eax
       jg        near ptr M14_L30
       jmp       near ptr M14_L50
M14_L35:
       mov       r8d,edx
       mov       r10,[rcx+r8*8+10]
       mov       [rsp+38],r10
       xor       r9d,r9d
       mov       [rcx+r8*8+10],r9
       mov       [rax+10],edx
       jmp       short M14_L32
M14_L36:
       mov       rdx,7FFE77AD18E0
       call      qword ptr [7FFE772AC570]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M14_L10
M14_L37:
       mov       rdx,7FFE77AD1998
       call      qword ptr [7FFE77527AB0]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M14_L11
M14_L38:
       mov       rcx,r14
       call      qword ptr [7FFE772AE8F8]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       mov       r13d,eax
       jmp       near ptr M14_L12
M14_L39:
       mov       rcx,r15
       call      qword ptr [7FFE772AE8F8]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       mov       r9d,eax
       jmp       near ptr M14_L13
M14_L40:
       cmp       byte ptr [r12+9D],0
       je        near ptr M14_L15
       mov       rcx,r14
       call      qword ptr [7FFE777BC600]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r13d,eax
       mov       eax,[r14+8]
       mov       [rsp+50],eax
       mov       rcx,r15
       call      qword ptr [7FFE777BC600]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       r15d,[rsp+5C]
       mov       [rsp+20],r15d
       mov       edx,r13d
       mov       r8d,[rsp+50]
       mov       rcx,r12
       call      qword ptr [7FFE77A66628]
       jmp       near ptr M14_L15
M14_L41:
       mov       rcx,rdi
       mov       rdx,7FFE77AD17C8
       call      qword ptr [7FFE772AC570]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M14_L16
M14_L42:
       mov       rdx,7FFE77A9EEE0
       call      qword ptr [7FFE772AC570]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M14_L17
M14_L43:
       mov       rcx,offset MT_System.OutOfMemoryException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE77A67348]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M14_L44:
       mov       rcx,r15
       call      qword ptr [7FFE772AE8F8]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       mov       r9d,eax
       jmp       near ptr M14_L04
M14_L45:
       mov       rcx,offset MT_System.Threading.ProcessorIdCache
       call      qword ptr [7FFE772A5740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M14_L27
M14_L46:
       mov       ecx,0B
       call      qword ptr [7FFE77A66658]
       mov       r14d,[rax+10]
       mov       ecx,0B
       call      qword ptr [7FFE77A66658]
       lea       ecx,[r14-1]
       mov       [rax+10],ecx
       movzx     eax,r14w
       test      eax,eax
       jne       short M14_L47
       call      qword ptr [7FFE77A66670]
       mov       r14d,eax
       jmp       near ptr M14_L28
M14_L47:
       sar       r14d,10
       jmp       near ptr M14_L28
M14_L48:
       mov       rcx,offset MT_System.Buffers.SharedArrayPoolStatics
       call      qword ptr [7FFE772A5740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M14_L29
M14_L49:
       mov       rcx,[rsp+30]
       call      qword ptr [7FFE77A66688]
       jmp       near ptr M14_L31
M14_L50:
       xor       r10d,r10d
       jmp       near ptr M14_L07
M14_L51:
       mov       ecx,1733C
       mov       rdx,7FFE771E4000
       call      qword ptr [7FFE775276F0]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FFE77A65860]
       int       3
M14_L52:
       xor       edi,edi
       xor       ebp,ebp
       jmp       near ptr M14_L18
M14_L53:
       call      qword ptr [7FFE77A66F10]
       int       3
M14_L54:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M14_L55:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 1714
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rdx,rdx
       je        short M15_L01
       mov       rax,[rdx]
       movzx     r8d,word ptr [rax+0E]
       test      r8,r8
       je        short M15_L05
       mov       r10,[rax+38]
       cmp       r8,4
       jl        short M15_L04
       cmp       [r10],rcx
       je        short M15_L01
M15_L00:
       cmp       [r10+8],rcx
       je        short M15_L01
       cmp       [r10+10],rcx
       jne       short M15_L03
M15_L01:
       mov       rax,rdx
       ret
M15_L02:
       cmp       [r10],rcx
       je        short M15_L01
       jmp       short M15_L00
M15_L03:
       cmp       [r10+18],rcx
       je        short M15_L01
       add       r10,20
       add       r8,0FFFFFFFFFFFFFFFC
       cmp       r8,4
       jge       short M15_L02
       test      r8,r8
       je        short M15_L05
M15_L04:
       cmp       [r10],rcx
       je        short M15_L01
       add       r10,8
       dec       r8
       test      r8,r8
       jg        short M15_L04
M15_L05:
       test      dword ptr [rax],500C0000
       jne       short M15_L06
       xor       edx,edx
       jmp       short M15_L01
M15_L06:
       jmp       qword ptr [7FFE7770D1B8]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
; Total bytes of code 116
```
```assembly
; System.Linq.Enumerable.ICollectionToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rcx,rbx
       call      qword ptr [7FFEE9B885F8]
       mov       rcx,rsi
       mov       r11,rax
       call      qword ptr [rax]
       mov       edi,eax
       test      edi,edi
       je        short M16_L00
       mov       rcx,rbx
       call      qword ptr [7FFEE9B87A40]
       mov       rcx,rax
       movsxd    rdx,edi
       call      qword ptr [7FFEE9B856D0]; CORINFO_HELP_NEWARR_1_DIRECT
       mov       rdi,rax
       mov       rcx,rbx
       call      qword ptr [7FFEE9B88600]
       mov       rcx,rsi
       mov       r11,rax
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [rax]
       mov       rax,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M16_L00:
       mov       rcx,rbx
       call      qword ptr [7FFEE9B88220]
       mov       rcx,rax
       lea       rax,[System.Linq.Enumerable.Select[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>)]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax]
; Total bytes of code 128
```

## .NET 10.0.0 (10.0.25.45207), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark.GetAllStaticMethods()
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,198
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       mov       rax,0FFFFFFFFFFFFFEB0
M00_L00:
       vmovdqa   xmmword ptr [rsp+rax+190],xmm4
       vmovdqa   xmmword ptr [rsp+rax+1A0],xmm4
       vmovdqa   xmmword ptr [rsp+rax+1B0],xmm4
       add       rax,30
       jne       short M00_L00
       mov       [rsp+190],rax
       mov       rbx,rcx
       mov       rcx,1763D691168
       mov       rsi,[rcx]
       test      rsi,rsi
       jne       short M00_L01
       mov       rcx,1B6D4330090
       call      qword ptr [7FFE77287C00]; System.RuntimeType.InitializeCache()
       mov       rdi,rax
       jmp       short M00_L02
M00_L01:
       mov       rdi,rsi
M00_L02:
       cmp       [rdi],dil
       lea       rsi,[rdi+40]
       mov       rcx,[rsi]
       test      rcx,rcx
       je        near ptr M00_L26
M00_L03:
       cmp       byte ptr [rcx+18],0
       je        near ptr M00_L27
       mov       rsi,[rcx+8]
M00_L04:
       mov       edi,[rsi+8]
       mov       edx,edi
       xor       r8d,r8d
       mov       [rsp+180],r8
       mov       [rsp+188],r8
       mov       [rsp+190],r8d
       mov       [rsp+194],edx
       mov       ebp,10
       inc       edi
M00_L05:
       dec       edi
       je        near ptr M00_L11
       mov       r14,[rsi+rbp]
       mov       edx,[r14+58]
       mov       r8d,edx
       and       r8d,3C
       cmp       r8d,edx
       jne       short M00_L08
       cmp       dword ptr [rsp+190],0
       je        near ptr M00_L28
       cmp       dword ptr [rsp+190],1
       je        short M00_L09
       mov       edx,[rsp+194]
       cmp       edx,[rsp+190]
       je        near ptr M00_L30
M00_L06:
       movsxd    rdx,dword ptr [rsp+190]
       mov       rcx,[rsp+180]
       mov       r8,r14
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
M00_L07:
       mov       edx,[rsp+190]
       inc       edx
       mov       [rsp+190],edx
M00_L08:
       add       rbp,8
       jmp       short M00_L05
M00_L09:
       cmp       dword ptr [rsp+194],2
       jl        near ptr M00_L29
M00_L10:
       movsxd    rdx,dword ptr [rsp+194]
       mov       rcx,offset MT_System.Reflection.MethodInfo[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       [rsp+180],rax
       mov       rcx,[rsp+180]
       mov       r8,[rsp+188]
       xor       edx,edx
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       short M00_L06
M00_L11:
       mov       rsi,[rsp+180]
       mov       rdi,[rsp+188]
       mov       ebp,[rsp+190]
       test      ebp,ebp
       je        near ptr M00_L31
       cmp       ebp,1
       je        near ptr M00_L32
       test      ebp,ebp
       jl        near ptr M00_L33
       test      rsi,rsi
       je        near ptr M00_L34
       cmp       [rsi+8],ebp
       je        short M00_L13
       mov       edx,ebp
       mov       rcx,offset MT_System.Reflection.MethodInfo[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       lea       rcx,[rdi+10]
       lea       rdx,[rsi+10]
       mov       r8d,[rsi+8]
       cmp       ebp,r8d
       cmovg     ebp,r8d
       mov       r8d,ebp
       shl       r8,3
       cmp       r8,4000
       ja        near ptr M00_L36
       call      00007FFED6E70160
       cmp       dword ptr [7FFED71EE808],0
       jne       near ptr M00_L35
M00_L12:
       mov       rsi,rdi
M00_L13:
       mov       rcx,1763F4020D8
       mov       rdi,[rcx]
       test      rdi,rdi
       je        near ptr M00_L37
M00_L14:
       test      rsi,rsi
       je        near ptr M00_L38
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<System.Reflection.MethodInfo>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L39
       mov       rdx,rsi
       mov       rcx,offset MT_System.Reflection.MethodInfo[]
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
       mov       rbp,rax
       test      rbp,rbp
       je        near ptr M00_L41
       cmp       dword ptr [rbp+8],0
       je        near ptr M00_L40
       mov       rcx,offset MT_System.Linq.Enumerable+ArrayWhereIterator<System.Reflection.MethodInfo>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [r14+10],eax
       lea       rcx,[r14+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+20]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
M00_L15:
       mov       rdx,r14
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<System.Reflection.MethodInfo>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M00_L47
       mov       rdx,offset MT_System.Linq.Enumerable+ArrayWhereIterator<System.Reflection.MethodInfo>
       cmp       [rax],rdx
       jne       near ptr M00_L46
       mov       rdx,[rax+18]
       test      rdx,rdx
       je        near ptr M00_L20
       lea       r14,[rdx+10]
       mov       esi,[rdx+8]
M00_L16:
       mov       rdi,[rax+20]
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rsp+140],ymm0
       vmovdqu   ymmword ptr [rsp+160],ymm0
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rsp+48],ymm0
       vmovdqu   ymmword ptr [rsp+68],ymm0
       vmovdqu   ymmword ptr [rsp+88],ymm0
       vmovdqu   ymmword ptr [rsp+0A8],ymm0
       vmovdqu   ymmword ptr [rsp+0C8],ymm0
       vmovdqu   ymmword ptr [rsp+0E8],ymm0
       vmovdqu   ymmword ptr [rsp+100],ymm0
       xor       edx,edx
       mov       [rsp+38],edx
       mov       [rsp+3C],edx
       mov       [rsp+40],edx
       lea       rdx,[rsp+140]
       mov       [rsp+120],rdx
       mov       dword ptr [rsp+128],8
       lea       rdx,[rsp+140]
       mov       [rsp+130],rdx
       mov       dword ptr [rsp+138],8
       test      esi,esi
       jle       short M00_L19
       xor       ebp,ebp
M00_L17:
       mov       r15,[r14+rbp]
       mov       rdx,r15
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       test      eax,eax
       je        short M00_L18
       mov       rcx,[rsp+130]
       mov       edx,[rsp+138]
       mov       eax,[rsp+40]
       cmp       eax,edx
       jae       near ptr M00_L43
       mov       edx,eax
       lea       rcx,[rcx+rdx*8]
       mov       rdx,r15
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       ecx,[rsp+40]
       inc       ecx
       mov       [rsp+40],ecx
M00_L18:
       add       rbp,8
       dec       esi
       jne       short M00_L17
M00_L19:
       mov       esi,[rsp+3C]
       add       esi,[rsp+40]
       jo        near ptr M00_L49
       mov       eax,esi
       test      eax,eax
       je        short M00_L21
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Reflection.MethodInfo[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       mov       r8,offset MT_System.Reflection.MethodInfo[]
       cmp       [rdi],r8
       jne       near ptr M00_L44
       lea       r8,[rdi+10]
       mov       [rsp+20],r8
       mov       [rsp+28],esi
       lea       r8,[rsp+20]
       lea       rcx,[rsp+38]
       mov       rdx,offset MT_System.Collections.Generic.SegmentedArrayBuilder<System.Reflection.MethodInfo>
       call      qword ptr [7FFE77A4C600]; System.Collections.Generic.SegmentedArrayBuilder`1[[System.__Canon, System.Private.CoreLib]].ToSpanInlined(System.Span`1<System.__Canon>)
       jmp       short M00_L23
M00_L20:
       xor       r14d,r14d
       xor       esi,esi
       jmp       near ptr M00_L16
M00_L21:
       test      byte ptr [7FFE77AA5FF0],1
       je        near ptr M00_L45
M00_L22:
       mov       rdx,1763F402190
       mov       rdi,[rdx]
M00_L23:
       mov       r8d,[rsp+38]
       test      r8d,r8d
       jne       short M00_L25
M00_L24:
       mov       rdx,rdi
       mov       rcx,7FFE77A20F78
       call      qword ptr [7FFE7787C210]; System.Array.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       mov       [rsp+30],rax
       mov       rcx,[rbx+18]
       lea       r8,[rsp+30]
       mov       rdx,7FFE77A23460
       cmp       [rcx],ecx
       call      qword ptr [7FFE7798EDD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,198
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M00_L25:
       lea       rcx,[rsp+38]
       mov       rdx,offset MT_System.Collections.Generic.SegmentedArrayBuilder<System.Reflection.MethodInfo>
       call      qword ptr [7FFE7798ED18]; System.Collections.Generic.SegmentedArrayBuilder`1[[System.__Canon, System.Private.CoreLib]].ReturnArrays(Int32)
       jmp       short M00_L24
M00_L26:
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache+MemberInfoCache<System.Reflection.RuntimeMethodInfo>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       mov       rdx,rbp
       xor       r8d,r8d
       call      00007FFED6E8EEF0
       mov       rcx,rax
       test      rcx,rcx
       cmove     rcx,rbp
       jmp       near ptr M00_L03
M00_L27:
       xor       edx,edx
       xor       r8d,r8d
       xor       r9d,r9d
       call      qword ptr [7FFE7728D278]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
       mov       rsi,rax
       jmp       near ptr M00_L04
M00_L28:
       mov       [rsp+188],r14
       jmp       near ptr M00_L07
M00_L29:
       mov       dword ptr [rsp+194],4
       jmp       near ptr M00_L10
M00_L30:
       mov       r15d,[rsp+194]
       add       r15d,r15d
       lea       rdx,[rsp+180]
       mov       r8d,r15d
       mov       rcx,7FFE77407580
       call      qword ptr [7FFE7728D488]; System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
       mov       [rsp+194],r15d
       jmp       near ptr M00_L06
M00_L31:
       mov       rcx,offset MT_System.Array+EmptyArray<System.Reflection.MethodInfo>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1763F402190
       mov       rsi,[rcx]
       jmp       near ptr M00_L13
M00_L32:
       mov       rcx,offset MT_System.Reflection.MethodInfo[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rdi
       xor       edx,edx
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       near ptr M00_L13
M00_L33:
       mov       ecx,45
       mov       edx,0D
       call      qword ptr [7FFE778F55A8]
       int       3
M00_L34:
       mov       edx,ebp
       mov       rcx,offset MT_System.Reflection.MethodInfo[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rsi,rax
       jmp       near ptr M00_L13
M00_L35:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L12
M00_L36:
       call      qword ptr [7FFE778FDC68]
       jmp       near ptr M00_L12
M00_L37:
       mov       rcx,offset MT_System.Func<System.Reflection.MethodInfo, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,1763F4020A8
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Core.TypeHelper+<>c.<GetAllPublicMethods>b__24_0(System.Reflection.MethodInfo)
       call      qword ptr [7FFE77286BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1763F4020D8
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L14
M00_L38:
       mov       ecx,11
       call      qword ptr [7FFE77507DB0]
       int       3
M00_L39:
       mov       rcx,rax
       mov       rdx,rdi
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+8]
       mov       r14,rax
       jmp       near ptr M00_L15
M00_L40:
       mov       rcx,offset MT_System.Array+EmptyArray<System.Reflection.MethodInfo>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,1763F402190
       mov       r14,[rdx]
       jmp       near ptr M00_L15
M00_L41:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Generic.List<System.Reflection.MethodInfo>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r14,rax
       test      r14,r14
       je        short M00_L42
       mov       rcx,offset MT_System.Linq.Enumerable+ListWhereIterator<System.Reflection.MethodInfo>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,r14
       mov       r8,rdi
       call      qword ptr [7FFE77A4C480]
       mov       r14,rsi
       jmp       near ptr M00_L15
M00_L42:
       mov       rcx,offset MT_System.Linq.Enumerable+IEnumerableWhereIterator<System.Reflection.MethodInfo>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       rdx,rsi
       mov       r8,rdi
       call      qword ptr [7FFE77A4C498]
       jmp       near ptr M00_L15
M00_L43:
       lea       rcx,[rsp+38]
       mov       r8,r15
       mov       rdx,offset MT_System.Collections.Generic.SegmentedArrayBuilder<System.Reflection.MethodInfo>
       call      qword ptr [7FFE7798EA00]; System.Collections.Generic.SegmentedArrayBuilder`1[[System.__Canon, System.Private.CoreLib]].AddSlow(System.__Canon)
       jmp       near ptr M00_L18
M00_L44:
       call      qword ptr [7FFE77A46EE0]
       int       3
M00_L45:
       mov       rcx,offset MT_System.Array+EmptyArray<System.Reflection.MethodInfo>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L22
M00_L46:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rdi,rax
       jmp       near ptr M00_L24
M00_L47:
       mov       rdx,r14
       mov       rcx,offset MT_System.Collections.Generic.ICollection<System.Reflection.MethodInfo>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M00_L48
       mov       rdx,rax
       mov       rcx,7FFE77B72938
       call      qword ptr [7FFE776E7738]; System.Linq.Enumerable.ICollectionToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>)
       mov       rdi,rax
       jmp       near ptr M00_L24
M00_L48:
       mov       rdx,r14
       mov       rcx,7FFE77B729C0
       call      qword ptr [7FFE77A47198]
       mov       rdi,rax
       jmp       near ptr M00_L24
M00_L49:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 1932
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
       je        near ptr M01_L08
M01_L00:
       mov       rcx,[rbx+10]
       mov       rdx,[rcx]
       mov       rdi,rdx
       test      rdi,rdi
       je        short M01_L01
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache
       cmp       [rdi],rcx
       jne       near ptr M01_L09
M01_L01:
       test      rdi,rdi
       jne       near ptr M01_L07
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
       call      00007FFED6E34140
       mov       r14,rax
       test      r14,r14
       je        near ptr M01_L10
M01_L02:
       mov       rax,[r14+8]
       test      rax,rax
       jne       near ptr M01_L05
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
       mov       rax,7FFE773E6D90
       mov       [rbp-78],rax
       lea       rax,[M01_L03]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFED6DD50B0
       call      rax
M01_L03:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFED71EE808],0
       je        short M01_L04
       call      qword ptr [7FFED71DC608]; CORINFO_HELP_STOP_FOR_GC
M01_L04:
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
M01_L05:
       cmp       rax,rbx
       sete      cl
       mov       rdi,[rbp-0A0]
       mov       [rdi+9C],cl
       mov       rcx,[rbx+10]
       mov       rdx,rdi
       xor       r8d,r8d
       call      00007FFED6EB03C0
       mov       rdx,rax
       test      rdx,rdx
       je        short M01_L06
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache
       cmp       [rdx],rcx
       jne       short M01_L11
M01_L06:
       test      rdx,rdx
       cmovne    rdi,rdx
M01_L07:
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
M01_L08:
       mov       [rbp-40],rbx
       lea       rcx,[rbp-40]
       mov       edx,1
       call      qword ptr [7FFE77A4DFC8]; System.RuntimeTypeHandle.GetGCHandle(System.Runtime.InteropServices.GCHandleType)
       mov       rdx,rax
       lea       rcx,[rbx+10]
       xor       eax,eax
       lock cmpxchg [rcx],rdx
       test      rax,rax
       je        near ptr M01_L00
       lea       rcx,[rbp-40]
       call      qword ptr [7FFE77A47450]
       jmp       near ptr M01_L00
M01_L09:
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M01_L10:
       mov       [rbp+10],rbx
       mov       rcx,rbx
       call      qword ptr [7FFE77287C48]; System.RuntimeTypeHandle.<GetModule>g__GetModuleWorker|48_0(System.RuntimeType)
       mov       r14,rax
       mov       rbx,[rbp+10]
       jmp       near ptr M01_L02
M01_L11:
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
       jbe       short M02_L00
       lea       rax,[rcx+rdx*8+10]
       mov       rcx,[rcx]
       mov       rdx,[rcx+30]
       test      r8,r8
       je        short M02_L02
       cmp       rdx,[r8]
       je        short M02_L01
       mov       r10,offset MT_System.Object[]
       cmp       rcx,r10
       je        short M02_L01
       mov       rcx,rax
       add       rsp,28
       jmp       qword ptr [7FFE7728D890]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
M02_L00:
       call      qword ptr [7FFE77A44240]
       int       3
M02_L01:
       mov       rcx,rax
       mov       rdx,r8
       add       rsp,28
       jmp       near ptr 00007FFED6EDE630
M02_L02:
       xor       ecx,ecx
       mov       [rax],rcx
       add       rsp,28
       ret
; Total bytes of code 94
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
       mov       r8,1763F400038
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
       jne       short M04_L04
       mov       rsi,rcx
       xor       rsi,[r11+10]
       cmp       rsi,1
       ja        short M04_L04
       cmp       ebx,[r11]
       jne       short M04_L05
M04_L01:
       cmp       esi,1
       jne       short M04_L03
M04_L02:
       mov       rax,rdx
       pop       rbx
       pop       rsi
       ret
M04_L03:
       test      esi,esi
       jne       short M04_L06
       xor       edx,edx
       jmp       short M04_L02
M04_L04:
       test      ebx,ebx
       je        short M04_L05
       inc       r9d
       add       r10d,r9d
       and       r10d,[r8+4]
       cmp       r9d,8
       jl        short M04_L00
M04_L05:
       mov       esi,2
       jmp       short M04_L01
M04_L06:
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFE7728D8A8]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny_NoCacheLookup(Void*, System.Object)
; Total bytes of code 168
```
```assembly
; System.Collections.Generic.SegmentedArrayBuilder`1[[System.__Canon, System.Private.CoreLib]].ToSpanInlined(System.Span`1<System.__Canon>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[r8]
       mov       edi,[r8+8]
       mov       ebp,[rbx]
       test      ebp,ebp
       je        near ptr M05_L04
       mov       rdx,[rbx+0E8]
       mov       r14d,[rbx+0F0]
       cmp       r14d,edi
       jg        near ptr M05_L14
       mov       r15d,r14d
       shl       r15,3
       mov       r8,r15
       cmp       r8,4000
       ja        near ptr M05_L08
       mov       rcx,rsi
       call      00007FFED6E70160
       cmp       dword ptr [7FFED71EE808],0
       jne       near ptr M05_L07
M05_L00:
       add       rsi,r15
       sub       edi,r14d
       dec       ebp
       je        short M05_L04
       lea       r14,[rbx+10]
       cmp       ebp,1B
       ja        near ptr M05_L11
       xor       r15d,r15d
M05_L01:
       mov       rcx,[r14+r15*8]
       test      rcx,rcx
       je        near ptr M05_L06
       lea       rdx,[rcx+10]
       mov       r13d,[rcx+8]
M05_L02:
       cmp       r13d,edi
       jg        near ptr M05_L14
       mov       r12d,r13d
       shl       r12,3
       mov       r8,r12
       cmp       r8,4000
       ja        near ptr M05_L10
       mov       rcx,rsi
       call      00007FFED6E70160
       cmp       dword ptr [7FFED71EE808],0
       jne       near ptr M05_L09
M05_L03:
       add       r12,rsi
       mov       rsi,r12
       sub       edi,r13d
       inc       r15d
       cmp       r15d,ebp
       jl        short M05_L01
M05_L04:
       lea       rcx,[rbx+0F8]
       mov       edx,[rbx+8]
       cmp       edx,[rcx+8]
       ja        short M05_L11
       mov       rax,[rcx]
       cmp       edx,edi
       ja        near ptr M05_L14
       mov       r8d,edx
       shl       r8,3
       cmp       r8,4000
       ja        short M05_L13
       mov       rcx,rsi
       mov       rdx,rax
       call      00007FFED6E70160
       cmp       dword ptr [7FFED71EE808],0
       jne       short M05_L12
M05_L05:
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
M05_L06:
       xor       edx,edx
       xor       r13d,r13d
       jmp       near ptr M05_L02
M05_L07:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M05_L00
M05_L08:
       mov       rcx,rsi
       call      qword ptr [7FFE778FDC68]
       jmp       near ptr M05_L00
M05_L09:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M05_L03
M05_L10:
       mov       rcx,rsi
       call      qword ptr [7FFE778FDC68]
       jmp       near ptr M05_L03
M05_L11:
       call      qword ptr [7FFE774270D8]
       int       3
M05_L12:
       call      CORINFO_HELP_POLL_GC
       jmp       short M05_L05
M05_L13:
       mov       rcx,rsi
       mov       rdx,rax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FFE778FDC68]
M05_L14:
       call      qword ptr [7FFE77797F30]
       int       3
; Total bytes of code 406
```
```assembly
; System.Array.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       push      rsi
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        short M06_L02
       cmp       dword ptr [rbx+8],0
       je        short M06_L03
       mov       rdx,[rcx+18]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M06_L01
M06_L00:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M06_L01:
       mov       rdx,7FFE77AB01F8
       call      qword ptr [7FFE77507AB0]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       short M06_L00
M06_L02:
       mov       ecx,2
       call      qword ptr [7FFE7750C180]
       int       3
M06_L03:
       mov       rdx,[rcx+18]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M06_L04
       jmp       short M06_L05
M06_L04:
       mov       rdx,7FFE77AB01F8
       call      qword ptr [7FFE77507AB0]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdx,rax
M06_L05:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rax]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 156
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
; System.Collections.Generic.SegmentedArrayBuilder`1[[System.__Canon, System.Private.CoreLib]].ReturnArrays(Int32)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,0A8
       mov       [rsp+0A0],rdx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       ebx,r8d
       cmp       [rdi],dil
       lea       rbp,[rdi+10]
       dec       ebx
       cmp       ebx,1B
       ja        near ptr M08_L17
       xor       r14d,r14d
       cmp       r14d,ebx
       jge       near ptr M08_L07
M08_L00:
       mov       r15,[rbp+r14*8]
       test      r15,r15
       je        near ptr M08_L45
       mov       rdx,[r15]
       movzx     ecx,word ptr [rdx]
       mov       eax,[r15+8]
       imul      rax,rcx
       lea       rcx,[r15+10]
       test      dword ptr [rdx],1000000
       je        near ptr M08_L18
       mov       rdx,rax
       shr       rdx,3
       call      qword ptr [7FFE7798ED48]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
M08_L01:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],98
       jle       near ptr M08_L15
       mov       rcx,[rcx+98]
       test      rcx,rcx
       je        near ptr M08_L15
M08_L02:
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,[rax]
       mov       r13,rcx
       mov       rcx,offset MT_System.Buffers.SharedArrayPool<System.Reflection.MethodInfo>
       cmp       [r13],rcx
       jne       near ptr M08_L39
       mov       ecx,[r15+8]
       dec       ecx
       or        ecx,0F
       xor       r12d,r12d
       lzcnt     r12d,ecx
       xor       r12d,1F
       add       r12d,0FFFFFFFD
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+238],0A
       jle       near ptr M08_L19
       mov       rcx,[rcx+240]
       mov       rax,[rcx+50]
       test      rax,rax
       je        near ptr M08_L19
M08_L03:
       mov       rax,[rax+10]
       test      rax,rax
       je        near ptr M08_L20
M08_L04:
       xor       r8d,r8d
       mov       dword ptr [rsp+98],1
       mov       ecx,[rax+8]
       cmp       ecx,r12d
       jbe       short M08_L05
       mov       dword ptr [rsp+9C],1
       mov       ecx,10
       shlx      ecx,ecx,r12d
       cmp       [r15+8],ecx
       jne       near ptr M08_L40
       mov       ecx,r12d
       shl       rcx,4
       lea       rax,[rax+rcx+10]
       mov       [rsp+58],rax
       mov       r9,[rax]
       mov       [rsp+50],r9
       mov       rcx,rax
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       rdx,[rsp+58]
       mov       [rdx+8],ecx
       cmp       qword ptr [rsp+50],0
       jne       near ptr M08_L21
       mov       r8d,[rsp+9C]
M08_L05:
       mov       rcx,1763F400C90
       mov       rax,[rcx]
       mov       [rsp+60],rax
       cmp       byte ptr [rax+9D],0
       jne       near ptr M08_L36
M08_L06:
       inc       r14d
       cmp       r14d,ebx
       jl        near ptr M08_L00
M08_L07:
       cmp       ebx,1B
       jae       near ptr M08_L67
       mov       edx,ebx
       mov       rbx,[rbp+rdx*8]
       mov       edx,[rdi+8]
       test      rbx,rbx
       je        near ptr M08_L45
       lea       rcx,[rbx+10]
       xor       eax,eax
       mov       r8,[rbx]
       cmp       dword ptr [r8+4],18
       jne       near ptr M08_L41
M08_L08:
       mov       r10d,eax
       neg       r10d
       test      eax,eax
       jg        near ptr M08_L42
       mov       eax,r10d
       or        eax,edx
       jl        near ptr M08_L42
       lea       eax,[r10+rdx]
       cmp       eax,[rbx+8]
       ja        near ptr M08_L42
       movzx     eax,word ptr [r8]
       mov       r10d,r10d
       imul      r10,rax
       add       rcx,r10
       mov       edx,edx
       imul      rdx,rax
       test      dword ptr [r8],1000000
       je        near ptr M08_L43
       shr       rdx,3
       call      qword ptr [7FFE7798ED48]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
M08_L09:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],98
       jle       near ptr M08_L16
       mov       rcx,[rcx+98]
       test      rcx,rcx
       je        near ptr M08_L16
M08_L10:
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,[rax]
       mov       rsi,rcx
       mov       rcx,offset MT_System.Buffers.SharedArrayPool<System.Reflection.MethodInfo>
       cmp       [rsi],rcx
       jne       near ptr M08_L66
       mov       ecx,[rbx+8]
       dec       ecx
       or        ecx,0F
       xor       edi,edi
       lzcnt     edi,ecx
       xor       edi,1F
       add       edi,0FFFFFFFD
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+238],0A
       jle       near ptr M08_L44
       mov       rcx,[rcx+240]
       mov       rax,[rcx+50]
       test      rax,rax
       je        near ptr M08_L44
M08_L11:
       mov       rax,[rax+10]
       test      rax,rax
       je        near ptr M08_L46
M08_L12:
       xor       ebp,ebp
       mov       r14d,1
       mov       ecx,[rax+8]
       cmp       ecx,edi
       jbe       short M08_L13
       mov       ebp,1
       mov       ecx,10
       shlx      ecx,ecx,edi
       cmp       [rbx+8],ecx
       jne       near ptr M08_L47
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
       jne       near ptr M08_L48
M08_L13:
       mov       rcx,1763F400C90
       mov       r15,[rcx]
       cmp       byte ptr [r15+9D],0
       jne       near ptr M08_L63
M08_L14:
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
M08_L15:
       mov       rcx,rsi
       mov       rdx,7FFE77AB1570
       call      qword ptr [7FFE7728C570]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M08_L02
M08_L16:
       mov       rcx,rsi
       mov       rdx,7FFE77AB1570
       call      qword ptr [7FFE7728C570]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M08_L10
M08_L17:
       call      qword ptr [7FFE774270D8]
       int       3
M08_L18:
       mov       rdx,rax
       call      qword ptr [7FFE772857E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
       jmp       near ptr M08_L01
M08_L19:
       mov       ecx,0A
       call      qword ptr [7FFE777943F0]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M08_L03
M08_L20:
       mov       rcx,r13
       call      qword ptr [7FFE7798ED78]; System.Buffers.SharedArrayPool`1[[System.__Canon, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
       jmp       near ptr M08_L04
M08_L21:
       mov       rcx,[r13+10]
       cmp       r12d,[rcx+8]
       jae       near ptr M08_L67
       mov       edx,r12d
       mov       r8,[rcx+rdx*8+10]
       test      r8,r8
       jne       short M08_L22
       mov       rcx,r13
       mov       edx,r12d
       call      qword ptr [7FFE77A47618]
       mov       r8,rax
M08_L22:
       mov       rdx,[r8+8]
       mov       [rsp+48],rdx
       mov       rcx,offset MT_System.Threading.ProcessorIdCache
       call      qword ptr [7FFE77285740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       cmp       byte ptr [7FFE771CB18C],0
       je        short M08_L23
       call      qword ptr [7FFE77A46610]
       mov       edx,eax
       mov       [rsp+80],edx
       jmp       short M08_L25
M08_L23:
       mov       ecx,0B
       call      qword ptr [7FFE77A46628]
       mov       eax,[rax+10]
       mov       [rsp+7C],eax
       mov       ecx,0B
       call      qword ptr [7FFE77A46628]
       mov       edx,[rsp+7C]
       lea       ecx,[rdx-1]
       mov       [rax+10],ecx
       movzx     eax,dx
       test      eax,eax
       jne       short M08_L24
       call      qword ptr [7FFE77A46640]
       mov       edx,eax
       mov       [rsp+80],edx
       jmp       short M08_L25
M08_L24:
       sar       edx,10
       mov       [rsp+80],edx
M08_L25:
       mov       rcx,offset MT_System.Buffers.SharedArrayPoolStatics
       call      qword ptr [7FFE77285740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       eax,[rsp+80]
       xor       edx,edx
       div       dword ptr [7FFE771CB180]
       mov       eax,edx
       xor       edx,edx
       jmp       near ptr M08_L32
M08_L26:
       cmp       eax,[r8+8]
       jae       near ptr M08_L67
       mov       [rsp+88],eax
       mov       ecx,eax
       mov       r10,[r8+rcx*8+10]
       mov       [rsp+40],r10
       cmp       [r10],r10b
       xor       r9d,r9d
       mov       [rsp+78],r9d
       mov       rcx,r10
       call      qword ptr [7FFE7787D278]; System.Threading.Monitor.Enter(System.Object)
       mov       rax,[rsp+40]
       mov       rcx,[rax+8]
       mov       r8d,[rax+10]
       mov       [rsp+74],r8d
       cmp       [rcx+8],r8d
       jbe       short M08_L28
       test      r8d,r8d
       jne       short M08_L29
       xor       edx,edx
       mov       [rax+14],edx
M08_L27:
       mov       edx,r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,[rsp+50]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rsp+74]
       inc       ecx
       mov       rax,[rsp+40]
       mov       [rax+10],ecx
       mov       dword ptr [rsp+78],1
M08_L28:
       mov       rcx,rax
       call      qword ptr [7FFE77286820]; System.Threading.Monitor.Exit(System.Object)
       cmp       dword ptr [rsp+78],0
       je        short M08_L30
       jmp       short M08_L33
M08_L29:
       jmp       short M08_L27
M08_L30:
       mov       eax,[rsp+88]
       inc       eax
       mov       ecx,eax
       mov       r8,[rsp+48]
       cmp       [r8+8],ecx
       jne       short M08_L31
       xor       ecx,ecx
M08_L31:
       mov       edx,[rsp+84]
       inc       edx
       mov       eax,ecx
M08_L32:
       mov       r8,[rsp+48]
       mov       [rsp+84],edx
       cmp       [r8+8],edx
       jg        near ptr M08_L26
       jmp       short M08_L34
M08_L33:
       mov       r10d,1
       jmp       short M08_L35
M08_L34:
       xor       r10d,r10d
M08_L35:
       mov       [rsp+98],r10d
       mov       r8d,[rsp+9C]
       jmp       near ptr M08_L05
M08_L36:
       cmp       dword ptr [r15+8],0
       mov       [rsp+9C],r8d
       je        near ptr M08_L06
       mov       rcx,r15
       call      qword ptr [7FFE7779C600]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+94],eax
       mov       edx,[r15+8]
       mov       [rsp+90],edx
       mov       rcx,r13
       call      qword ptr [7FFE7779C600]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,[rsp+60]
       mov       r8d,[rsp+94]
       mov       r9d,[rsp+90]
       mov       edx,3
       call      qword ptr [7FFE77A46850]
       mov       eax,[rsp+9C]
       test      [rsp+98],eax
       jne       near ptr M08_L06
       mov       rcx,r15
       call      qword ptr [7FFE7779C600]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+8C],eax
       mov       r15d,[r15+8]
       mov       rcx,r13
       call      qword ptr [7FFE7779C600]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       cmp       dword ptr [rsp+9C],0
       jne       short M08_L37
       mov       ecx,0FFFFFFFF
       mov       edx,1
       jmp       short M08_L38
M08_L37:
       mov       ecx,r12d
       xor       edx,edx
M08_L38:
       mov       [rsp+20],ecx
       mov       [rsp+28],edx
       mov       rcx,[rsp+60]
       mov       edx,[rsp+8C]
       mov       r8d,r15d
       call      qword ptr [7FFE77A46868]
       jmp       near ptr M08_L06
M08_L39:
       mov       rcx,r13
       mov       rdx,r15
       xor       r8d,r8d
       call      qword ptr [7FFE77A22500]; System.Buffers.SharedArrayPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon[], Boolean)
       jmp       near ptr M08_L06
M08_L40:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE77A46820]
       mov       rbp,rax
       mov       ecx,29B
       mov       rdx,7FFE771C4000
       call      qword ptr [7FFE775076F0]
       mov       r8,rax
       mov       rdx,rbp
       mov       rcx,rbx
       call      qword ptr [7FFE776E5B30]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M08_L41:
       mov       r10d,[r8+4]
       add       r10d,0FFFFFFE8
       shr       r10d,3
       movsxd    rax,r10d
       mov       eax,[rcx+rax*4]
       shl       r10d,3
       movsxd    r10,r10d
       add       rcx,r10
       jmp       near ptr M08_L08
M08_L42:
       call      qword ptr [7FFE77A476F0]
       int       3
M08_L43:
       call      qword ptr [7FFE772857E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
       jmp       near ptr M08_L09
M08_L44:
       mov       ecx,0A
       call      qword ptr [7FFE777943F0]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M08_L11
M08_L45:
       mov       ecx,2
       call      qword ptr [7FFE7750C180]
       int       3
M08_L46:
       mov       rcx,rsi
       call      qword ptr [7FFE7798ED78]; System.Buffers.SharedArrayPool`1[[System.__Canon, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
       jmp       near ptr M08_L12
M08_L47:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE77A46820]
       mov       rsi,rax
       mov       ecx,29B
       mov       rdx,7FFE771C4000
       call      qword ptr [7FFE775076F0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE776E5B30]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M08_L48:
       mov       rcx,[rsi+10]
       cmp       edi,[rcx+8]
       jae       near ptr M08_L67
       mov       edx,edi
       mov       rax,[rcx+rdx*8+10]
       test      rax,rax
       jne       short M08_L49
       mov       rcx,rsi
       mov       edx,edi
       call      qword ptr [7FFE77A47618]
M08_L49:
       mov       r14,[rax+8]
       mov       rcx,offset MT_System.Threading.ProcessorIdCache
       call      qword ptr [7FFE77285740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       cmp       byte ptr [7FFE771CB18C],0
       je        short M08_L50
       call      qword ptr [7FFE77A46610]
       mov       r15d,eax
       jmp       short M08_L52
M08_L50:
       mov       ecx,0B
       call      qword ptr [7FFE77A46628]
       mov       r15d,[rax+10]
       mov       ecx,0B
       call      qword ptr [7FFE77A46628]
       lea       ecx,[r15-1]
       mov       [rax+10],ecx
       movzx     eax,r15w
       test      eax,eax
       jne       short M08_L51
       call      qword ptr [7FFE77A46640]
       mov       r15d,eax
       jmp       short M08_L52
M08_L51:
       sar       r15d,10
M08_L52:
       mov       rcx,offset MT_System.Buffers.SharedArrayPoolStatics
       call      qword ptr [7FFE77285740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       eax,r15d
       xor       edx,edx
       div       dword ptr [7FFE771CB180]
       mov       r15d,edx
       xor       r12d,r12d
       jmp       near ptr M08_L59
M08_L53:
       cmp       r15d,[r14+8]
       jae       near ptr M08_L67
       mov       ecx,r15d
       mov       rax,[r14+rcx*8+10]
       mov       [rsp+38],rax
       cmp       [rax],al
       xor       edx,edx
       mov       [rsp+70],edx
       mov       rcx,rax
       call      qword ptr [7FFE7787D278]; System.Threading.Monitor.Enter(System.Object)
       mov       rax,[rsp+38]
       mov       rcx,[rax+8]
       mov       r8d,[rax+10]
       mov       [rsp+6C],r8d
       cmp       [rcx+8],r8d
       jbe       short M08_L55
       test      r8d,r8d
       jne       short M08_L56
       xor       edx,edx
       mov       [rax+14],edx
M08_L54:
       mov       edx,r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rsp+6C]
       inc       ecx
       mov       rax,[rsp+38]
       mov       [rax+10],ecx
       mov       dword ptr [rsp+70],1
M08_L55:
       mov       rcx,rax
       call      qword ptr [7FFE77286820]; System.Threading.Monitor.Exit(System.Object)
       cmp       dword ptr [rsp+70],0
       je        short M08_L57
       jmp       short M08_L60
M08_L56:
       jmp       short M08_L54
M08_L57:
       inc       r15d
       cmp       [r14+8],r15d
       jne       short M08_L58
       xor       r15d,r15d
M08_L58:
       inc       r12d
M08_L59:
       cmp       [r14+8],r12d
       jg        near ptr M08_L53
       jmp       short M08_L61
M08_L60:
       mov       r14d,1
       jmp       short M08_L62
M08_L61:
       xor       r14d,r14d
M08_L62:
       jmp       near ptr M08_L13
M08_L63:
       cmp       dword ptr [rbx+8],0
       je        near ptr M08_L14
       mov       rcx,rbx
       call      qword ptr [7FFE7779C600]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r13d,eax
       mov       r12d,[rbx+8]
       mov       rcx,rsi
       call      qword ptr [7FFE7779C600]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,r15
       mov       r8d,r13d
       mov       r9d,r12d
       mov       edx,3
       call      qword ptr [7FFE77A46850]
       test      r14d,ebp
       jne       near ptr M08_L14
       mov       rcx,rbx
       call      qword ptr [7FFE7779C600]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r14d,eax
       mov       ebx,[rbx+8]
       mov       rcx,rsi
       call      qword ptr [7FFE7779C600]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       test      ebp,ebp
       jne       short M08_L64
       mov       ecx,0FFFFFFFF
       mov       edx,1
       jmp       short M08_L65
M08_L64:
       mov       ecx,edi
       xor       edx,edx
M08_L65:
       mov       [rsp+20],ecx
       mov       [rsp+28],edx
       mov       rcx,r15
       mov       edx,r14d
       mov       r8d,ebx
       call      qword ptr [7FFE77A46868]
       jmp       near ptr M08_L14
M08_L66:
       mov       rcx,rsi
       mov       rdx,rbx
       xor       r8d,r8d
       add       rsp,0A8
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FFE77A22500]; System.Buffers.SharedArrayPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon[], Boolean)
M08_L67:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 2372
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
       mov       rax,0B8EF3C648B58
       mov       [rbp],rax
       mov       rsi,rcx
       mov       rbx,rdx
       mov       edi,r8d
       mov       r14d,r9d
       test      rbx,rbx
       je        short M09_L00
       cmp       dword ptr [rbx+8],0
       jne       short M09_L03
M09_L00:
       xor       r8d,r8d
       mov       [rbp+8],r8
       mov       [rbp+10],r8d
       mov       [rsp+20],r14d
       lea       r8,[rbp+8]
       mov       rcx,rsi
       mov       r9d,edi
       mov       rdx,1B6D4320008
       call      qword ptr [7FFE7728D2D8]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].GetListByName(System.String, System.Span`1<Byte>, MemberListType, CacheType)
       mov       [rbp+18],rax
M09_L01:
       lea       rdx,[rbp+18]
       mov       rcx,rsi
       mov       r8,rbx
       mov       r9d,edi
       call      qword ptr [7FFE7728D518]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Insert(System.__Canon[] ByRef, System.String, MemberListType)
       mov       rax,[rbp+18]
       mov       rcx,0B8EF3C648B58
       cmp       [rbp],rcx
       je        short M09_L02
       call      CORINFO_HELP_FAIL_FAST
M09_L02:
       nop
       lea       rsp,[rbp+20]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M09_L03:
       cmp       r14d,1
       jne       short M09_L04
       cmp       word ptr [rbx+0C],2E
       je        short M09_L04
       cmp       word ptr [rbx+0C],2A
       jne       short M09_L00
M09_L04:
       mov       rcx,1763F400220
       mov       rcx,[rcx]
       mov       rdx,rbx
       call      qword ptr [7FFE77414778]; Precode of System.Text.UTF8Encoding.GetByteCount(System.String)
       cmp       eax,400
       jbe       short M09_L05
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       r8,[rax+10]
       mov       eax,[rax+8]
       jmp       short M09_L07
M09_L05:
       mov       r8d,eax
       test      r8,r8
       je        short M09_L07
       mov       rdx,r8
       add       rdx,0F
       and       rdx,0FFFFFFFFFFFFFFF0
       add       rsp,30
       neg       rdx
       add       rdx,rsp
       jb        short M09_L06
       xor       edx,edx
M09_L06:
       test      [rsp],esp
       sub       rsp,1000
       cmp       rsp,rdx
       jae       short M09_L06
       mov       rsp,rdx
       test      [rsp],esp
       sub       rsp,30
       lea       r8,[rsp+30]
M09_L07:
       mov       [rbp+8],r8
       mov       [rbp+10],eax
       mov       [rsp+20],r14d
       lea       r8,[rbp+8]
       mov       rdx,rbx
       mov       rcx,rsi
       mov       r9d,edi
       call      qword ptr [7FFE7728D2D8]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].GetListByName(System.String, System.Span`1<Byte>, MemberListType, CacheType)
       mov       [rbp+18],rax
       jmp       near ptr M09_L01
; Total bytes of code 348
```
```assembly
; System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rdx
       mov       ebx,r8d
       test      ebx,ebx
       jl        near ptr M10_L04
       mov       rdi,[rsi]
       test      rdi,rdi
       je        near ptr M10_L05
       mov       ebp,[rdi+8]
       cmp       ebp,ebx
       je        short M10_L02
       mov       rdx,[rcx+18]
       mov       rax,[rdx+18]
       test      rax,rax
       je        short M10_L03
       mov       rcx,rax
M10_L00:
       mov       edx,ebx
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       lea       rcx,[r14+10]
       lea       rdx,[rdi+10]
       cmp       ebx,ebp
       cmovg     ebx,ebp
       mov       r8d,ebx
       shl       r8,3
       cmp       r8,4000
       ja        near ptr M10_L09
       call      00007FFED6E70160
       cmp       dword ptr [7FFED71EE808],0
       jne       short M10_L08
M10_L01:
       mov       rcx,rsi
       mov       rdx,r14
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M10_L02:
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M10_L03:
       mov       rdx,7FFE77A7E9C0
       call      qword ptr [7FFE77507AB0]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M10_L00
M10_L04:
       mov       ecx,45
       mov       edx,0D
       call      qword ptr [7FFE778F55A8]
       int       3
M10_L05:
       mov       rdx,[rcx+18]
       mov       rax,[rdx+18]
       test      rax,rax
       je        short M10_L06
       mov       rcx,rax
       jmp       short M10_L07
M10_L06:
       mov       rdx,7FFE77A7E9C0
       call      qword ptr [7FFE77507AB0]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M10_L07:
       mov       edx,ebx
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdx,rax
       mov       rcx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       short M10_L02
M10_L08:
       call      CORINFO_HELP_POLL_GC
       jmp       short M10_L01
M10_L09:
       call      qword ptr [7FFE778FDC68]
       jmp       near ptr M10_L01
; Total bytes of code 257
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M11_L00
       ret
M11_L00:
       jmp       qword ptr [7FFE77285C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```
```assembly
; DotNetTips.Spargine.Core.TypeHelper+<>c.<GetAllPublicMethods>b__24_0(System.Reflection.MethodInfo)
; 		return Array.AsReadOnly(type.GetTypeInfo().DeclaredMethods.Where(m => m.IsPublic).ToArray());
; 		                                                                      ^^^^^^^^^^
       push      rbx
       sub       rsp,20
       mov       rcx,offset MT_System.Reflection.RuntimeMethodInfo
       cmp       [rdx],rcx
       jne       short M12_L01
       mov       ebx,[rdx+5C]
M12_L00:
       and       ebx,7
       cmp       ebx,6
       sete      al
       movzx     eax,al
       add       rsp,20
       pop       rbx
       ret
M12_L01:
       mov       rcx,rdx
       mov       rax,[rdx]
       mov       rax,[rax+50]
       call      qword ptr [rax+20]
       mov       ebx,eax
       jmp       short M12_L00
; Total bytes of code 58
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M13_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M13_L00:
       call      qword ptr [7FFE77A46B08]
       int       3
; Total bytes of code 44
```
```assembly
; System.Collections.Generic.SegmentedArrayBuilder`1[[System.__Canon, System.Private.CoreLib]].AddSlow(System.__Canon)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,68
       mov       [rsp+60],rdx
       mov       rbx,rcx
       mov       rsi,r8
       mov       rdi,rdx
       mov       ecx,[rbx+100]
       mov       edx,ecx
       add       edx,[rbx+4]
       jo        near ptr M14_L55
       mov       [rbx+4],edx
       cmp       dword ptr [rbx+4],7FFFFFC7
       jg        near ptr M14_L43
       movsxd    rbp,ecx
       add       rbp,rbp
       cmp       rbp,10
       jle       short M14_L00
       cmp       rbp,7FFFFFC7
       jle       short M14_L01
       mov       r14d,7FFFFFC7
       jmp       short M14_L02
M14_L00:
       mov       ebp,10
M14_L01:
       mov       r14,rbp
M14_L02:
       lea       rbp,[rbx+10]
       mov       r15d,[rbx]
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],98
       jle       near ptr M14_L19
       mov       rcx,[rcx+98]
       test      rcx,rcx
       je        near ptr M14_L19
M14_L03:
       cmp       r15d,1B
       jae       near ptr M14_L54
       mov       eax,r15d
       lea       rbp,[rbp+rax*8]
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r15,[rax]
       mov       r13d,r14d
       mov       rcx,1763F400C90
       mov       r12,[rcx]
       lea       ecx,[r13-1]
       or        ecx,0F
       xor       eax,eax
       lzcnt     eax,ecx
       xor       eax,1F
       add       eax,0FFFFFFFD
       mov       [rsp+5C],eax
       mov       rcx,[r15]
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCThreadStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rax+10]
       test      rax,rax
       je        near ptr M14_L20
       mov       r8d,[rsp+5C]
       cmp       [rax+8],r8d
       jbe       near ptr M14_L20
       mov       ecx,r8d
       shl       rcx,4
       mov       r10,[rax+rcx+10]
       test      r10,r10
       je        near ptr M14_L20
       mov       r14,r10
       mov       r13d,[rsp+5C]
       mov       ecx,r13d
       shl       rcx,4
       xor       edx,edx
       mov       [rax+rcx+10],rdx
       cmp       byte ptr [r12+9D],0
       je        near ptr M14_L15
       mov       rcx,r14
       call      qword ptr [7FFE7779C600]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+4C],eax
       mov       edx,[r14+8]
       mov       [rsp+48],edx
       mov       rcx,r15
       call      00007FFED6E834A0
       mov       r9d,eax
       test      r9d,r9d
       je        near ptr M14_L44
M14_L04:
       mov       [rsp+20],r13d
       mov       rcx,r12
       mov       edx,[rsp+4C]
       mov       r8d,[rsp+48]
       call      qword ptr [7FFE77A465F8]
       jmp       near ptr M14_L15
M14_L05:
       mov       rcx,r15
       call      qword ptr [7FFE7728E8F8]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       mov       r9d,eax
       jmp       near ptr M14_L14
M14_L06:
       xor       r14d,r14d
       jmp       near ptr M14_L34
M14_L07:
       mov       r14,r10
       test      r14,r14
       jne       near ptr M14_L40
M14_L08:
       mov       ecx,10
       mov       r8d,[rsp+5C]
       shlx      r13d,ecx,r8d
M14_L09:
       mov       rcx,[r15]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx+8]
       cmp       qword ptr [rdx+8],38
       jle       near ptr M14_L36
       mov       rax,[rdx+38]
       test      rax,rax
       je        near ptr M14_L36
       mov       rcx,rax
M14_L10:
       mov       rdx,[rcx+18]
       mov       rax,[rdx+18]
       test      rax,rax
       je        near ptr M14_L37
       mov       rcx,rax
M14_L11:
       movsxd    rdx,r13d
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       cmp       byte ptr [r12+9D],0
       je        near ptr M14_L15
       mov       rcx,r14
       call      00007FFED6E834A0
       mov       r13d,eax
       test      r13d,r13d
       je        near ptr M14_L38
M14_L12:
       mov       eax,[r14+8]
       mov       [rsp+58],eax
       mov       rcx,r15
       call      00007FFED6E834A0
       mov       r9d,eax
       test      r9d,r9d
       je        near ptr M14_L39
M14_L13:
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       rcx,r12
       mov       edx,r13d
       mov       r8d,[rsp+58]
       call      qword ptr [7FFE77A465F8]
       mov       eax,[r14+8]
       mov       [rsp+54],eax
       mov       rcx,r15
       call      00007FFED6E834A0
       mov       r9d,eax
       test      r9d,r9d
       je        near ptr M14_L05
M14_L14:
       mov       rcx,[r15+10]
       mov       edx,1
       mov       r8d,2
       mov       r15d,[rsp+5C]
       cmp       [rcx+8],r15d
       cmovg     edx,r8d
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       [rsp+28],edx
       mov       rcx,r12
       mov       edx,r13d
       mov       r8d,[rsp+54]
       call      qword ptr [7FFE77A46688]
M14_L15:
       mov       rcx,rbp
       mov       rdx,r14
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0A0
       jle       near ptr M14_L41
       mov       rcx,[rcx+0A0]
       test      rcx,rcx
       je        near ptr M14_L41
M14_L16:
       test      r14,r14
       je        near ptr M14_L52
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+20]
       test      rax,rax
       je        near ptr M14_L42
M14_L17:
       cmp       [r14],rax
       jne       near ptr M14_L53
       lea       rdi,[r14+10]
       mov       ebp,[r14+8]
M14_L18:
       mov       [rbx+0F8],rdi
       mov       [rbx+100],ebp
       inc       dword ptr [rbx]
       lea       rcx,[rbx+0F8]
       cmp       dword ptr [rcx+8],0
       jbe       near ptr M14_L54
       mov       rcx,[rcx]
       mov       rdx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       dword ptr [rbx+8],1
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M14_L19:
       mov       rcx,rdi
       mov       rdx,7FFE77AB1570
       call      qword ptr [7FFE7728C570]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M14_L03
M14_L20:
       mov       rax,[r15+10]
       mov       r8d,[rsp+5C]
       cmp       [rax+8],r8d
       ja        short M14_L26
       test      r13d,r13d
       je        short M14_L21
       test      r13d,r13d
       jge       near ptr M14_L09
       jmp       near ptr M14_L51
M14_L21:
       mov       rcx,[r15]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx+8]
       cmp       qword ptr [rdx+8],40
       jle       short M14_L24
       mov       rax,[rdx+40]
       test      rax,rax
       je        short M14_L24
       mov       rcx,rax
M14_L22:
       mov       rdx,[rcx+18]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M14_L25
M14_L23:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r14,[rax]
       jmp       near ptr M14_L15
M14_L24:
       mov       rdx,7FFE77AB16B8
       call      qword ptr [7FFE7728C570]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M14_L22
M14_L25:
       mov       rdx,7FFE77A7B900
       call      qword ptr [7FFE77507AB0]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       short M14_L23
M14_L26:
       mov       ecx,r8d
       mov       rcx,[rax+rcx*8+10]
       test      rcx,rcx
       je        near ptr M14_L08
       mov       r13,[rcx+8]
       test      byte ptr [7FFE77A9E400],1
       je        near ptr M14_L45
M14_L27:
       cmp       byte ptr [7FFE771CB18C],0
       je        near ptr M14_L46
       call      qword ptr [7FFE77A46610]
       mov       r14d,eax
M14_L28:
       test      byte ptr [7FFE77A9E290],1
       je        near ptr M14_L48
M14_L29:
       mov       eax,r14d
       xor       edx,edx
       div       dword ptr [7FFE771CB180]
       mov       r14d,edx
       xor       eax,eax
       mov       [rsp+44],eax
       cmp       dword ptr [r13+8],0
       jle       near ptr M14_L50
M14_L30:
       cmp       r14d,[r13+8]
       jae       near ptr M14_L54
       mov       ecx,r14d
       mov       rdx,[r13+rcx*8+10]
       mov       [rsp+30],rdx
       cmp       [rdx],dl
       xor       r8d,r8d
       mov       [rsp+38],r8
       mov       rcx,rdx
       call      00007FFED6E20370
       test      eax,eax
       je        near ptr M14_L49
M14_L31:
       mov       rax,[rsp+30]
       mov       rcx,[rax+8]
       mov       edx,[rax+10]
       dec       edx
       cmp       [rcx+8],edx
       ja        short M14_L35
M14_L32:
       mov       rcx,rax
       call      00007FFED6E6FFC0
       test      eax,eax
       je        short M14_L33
       mov       ecx,eax
       mov       rdx,[rsp+30]
       call      qword ptr [7FFE77A46670]
M14_L33:
       mov       r10,[rsp+38]
       test      r10,r10
       jne       near ptr M14_L07
       inc       r14d
       cmp       [r13+8],r14d
       je        near ptr M14_L06
M14_L34:
       mov       eax,[rsp+44]
       inc       eax
       cmp       [r13+8],eax
       mov       [rsp+44],eax
       jg        near ptr M14_L30
       jmp       near ptr M14_L50
M14_L35:
       mov       r8d,edx
       mov       r10,[rcx+r8*8+10]
       mov       [rsp+38],r10
       xor       r9d,r9d
       mov       [rcx+r8*8+10],r9
       mov       [rax+10],edx
       jmp       short M14_L32
M14_L36:
       mov       rdx,7FFE77AB1698
       call      qword ptr [7FFE7728C570]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M14_L10
M14_L37:
       mov       rdx,7FFE77AB1750
       call      qword ptr [7FFE77507AB0]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M14_L11
M14_L38:
       mov       rcx,r14
       call      qword ptr [7FFE7728E8F8]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       mov       r13d,eax
       jmp       near ptr M14_L12
M14_L39:
       mov       rcx,r15
       call      qword ptr [7FFE7728E8F8]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       mov       r9d,eax
       jmp       near ptr M14_L13
M14_L40:
       cmp       byte ptr [r12+9D],0
       je        near ptr M14_L15
       mov       rcx,r14
       call      qword ptr [7FFE7779C600]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r13d,eax
       mov       eax,[r14+8]
       mov       [rsp+50],eax
       mov       rcx,r15
       call      qword ptr [7FFE7779C600]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       r15d,[rsp+5C]
       mov       [rsp+20],r15d
       mov       edx,r13d
       mov       r8d,[rsp+50]
       mov       rcx,r12
       call      qword ptr [7FFE77A465F8]
       jmp       near ptr M14_L15
M14_L41:
       mov       rcx,rdi
       mov       rdx,7FFE77AB1580
       call      qword ptr [7FFE7728C570]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M14_L16
M14_L42:
       mov       rdx,7FFE77A7E950
       call      qword ptr [7FFE7728C570]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M14_L17
M14_L43:
       mov       rcx,offset MT_System.OutOfMemoryException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE77A47318]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M14_L44:
       mov       rcx,r15
       call      qword ptr [7FFE7728E8F8]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       mov       r9d,eax
       jmp       near ptr M14_L04
M14_L45:
       mov       rcx,offset MT_System.Threading.ProcessorIdCache
       call      qword ptr [7FFE77285740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M14_L27
M14_L46:
       mov       ecx,0B
       call      qword ptr [7FFE77A46628]
       mov       r14d,[rax+10]
       mov       ecx,0B
       call      qword ptr [7FFE77A46628]
       lea       ecx,[r14-1]
       mov       [rax+10],ecx
       movzx     eax,r14w
       test      eax,eax
       jne       short M14_L47
       call      qword ptr [7FFE77A46640]
       mov       r14d,eax
       jmp       near ptr M14_L28
M14_L47:
       sar       r14d,10
       jmp       near ptr M14_L28
M14_L48:
       mov       rcx,offset MT_System.Buffers.SharedArrayPoolStatics
       call      qword ptr [7FFE77285740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M14_L29
M14_L49:
       mov       rcx,[rsp+30]
       call      qword ptr [7FFE77A46658]
       jmp       near ptr M14_L31
M14_L50:
       xor       r10d,r10d
       jmp       near ptr M14_L07
M14_L51:
       mov       ecx,1733C
       mov       rdx,7FFE771C4000
       call      qword ptr [7FFE775076F0]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FFE77A45830]
       int       3
M14_L52:
       xor       edi,edi
       xor       ebp,ebp
       jmp       near ptr M14_L18
M14_L53:
       call      qword ptr [7FFE77A46EE0]
       int       3
M14_L54:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M14_L55:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 1714
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rdx,rdx
       je        short M15_L01
       mov       rax,[rdx]
       movzx     r8d,word ptr [rax+0E]
       test      r8,r8
       je        short M15_L05
       mov       r10,[rax+38]
       cmp       r8,4
       jl        short M15_L04
       cmp       [r10],rcx
       je        short M15_L01
M15_L00:
       cmp       [r10+8],rcx
       je        short M15_L01
       cmp       [r10+10],rcx
       jne       short M15_L03
M15_L01:
       mov       rax,rdx
       ret
M15_L02:
       cmp       [r10],rcx
       je        short M15_L01
       jmp       short M15_L00
M15_L03:
       cmp       [r10+18],rcx
       je        short M15_L01
       add       r10,20
       add       r8,0FFFFFFFFFFFFFFFC
       cmp       r8,4
       jge       short M15_L02
       test      r8,r8
       je        short M15_L05
M15_L04:
       cmp       [r10],rcx
       je        short M15_L01
       add       r10,8
       dec       r8
       test      r8,r8
       jg        short M15_L04
M15_L05:
       test      dword ptr [rax],500C0000
       jne       short M15_L06
       xor       edx,edx
       jmp       short M15_L01
M15_L06:
       jmp       qword ptr [7FFE776ED1B8]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
; Total bytes of code 116
```
```assembly
; System.Linq.Enumerable.ICollectionToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rcx,rbx
       call      qword ptr [7FFEE9B885F8]
       mov       rcx,rsi
       mov       r11,rax
       call      qword ptr [rax]
       mov       edi,eax
       test      edi,edi
       je        short M16_L00
       mov       rcx,rbx
       call      qword ptr [7FFEE9B87A40]
       mov       rcx,rax
       movsxd    rdx,edi
       call      qword ptr [7FFEE9B856D0]; CORINFO_HELP_NEWARR_1_DIRECT
       mov       rdi,rax
       mov       rcx,rbx
       call      qword ptr [7FFEE9B88600]
       mov       rcx,rsi
       mov       r11,rax
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [rax]
       mov       rax,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M16_L00:
       mov       rcx,rbx
       call      qword ptr [7FFEE9B88220]
       mov       rcx,rax
       lea       rax,[System.Linq.Enumerable.Select[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>)]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax]
; Total bytes of code 128
```

## .NET 10.0.0 (10.0.25.45207), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark.GetMembersWithAttribute()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.TypeHelper+<GetMembersWithAttribute>d__36<DotNetTips.Spargine.Core.InformationAttribute>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       dword ptr [rsi+28],0FFFFFFFE
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rsi+2C],eax
       mov       rcx,20C49310090
       mov       [rsi+18],rcx
       mov       [rsp+20],rsi
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 99
```

## .NET 10.0.0 (10.0.25.45207), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark.GetTypeDisplayName()
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,60
       vzeroupper
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp-58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-50],ymm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       mov       [rbp+10],rcx
       mov       byte ptr [rbp-28],1
       mov       byte ptr [rbp-27],0
       mov       byte ptr [rbp-26],1
       mov       word ptr [rbp-24],2B
       mov       rcx,1C0D50020C0
       mov       rbx,[rcx]
       mov       rcx,[rbx+20]
       mov       [rbp-38],rcx
       cmp       qword ptr [rbp-38],0
       je        near ptr M00_L41
       lea       rcx,[rbx+20]
       mov       r8,[rbp-38]
       test      rcx,rcx
       je        near ptr M00_L40
       xor       edx,edx
       call      00007FFED6E8EEF0
       cmp       rax,[rbp-38]
       jne       near ptr M00_L41
M00_L00:
       mov       rbx,[rbp-38]
M00_L01:
       xor       eax,eax
       mov       [rbp-38],rax
       cmp       dword ptr [rbx+20],0
       jl        near ptr M00_L43
       cmp       qword ptr [rbx+10],0
       je        near ptr M00_L09
       mov       eax,[rbx+1C]
       add       eax,[rbx+18]
       mov       esi,eax
       neg       esi
       test      esi,esi
       jg        near ptr M00_L08
       mov       rsi,rbx
       cmp       dword ptr [rbx+1C],0
       jle       short M00_L03
M00_L02:
       mov       rsi,[rsi+10]
       cmp       dword ptr [rsi+1C],0
       jg        short M00_L02
M00_L03:
       cmp       rsi,rbx
       je        near ptr M00_L06
       mov       rdx,[rbx+8]
       mov       ecx,[rdx+8]
       add       ecx,[rbx+1C]
       lea       edx,[rax+rax*2]
       add       edx,edx
       mov       r8d,66666667
       mov       eax,r8d
       imul      edx
       mov       eax,edx
       shr       eax,1F
       sar       edx,1
       add       edx,eax
       mov       rax,[rbx+8]
       mov       eax,[rax+8]
       cmp       edx,eax
       cmovl     edx,eax
       cmp       ecx,edx
       cmovg     ecx,edx
       sub       ecx,[rsi+1C]
       mov       rdx,[rsi+8]
       cmp       [rdx+8],ecx
       jge       short M00_L07
       cmp       ecx,400
       jge       near ptr M00_L45
       movsxd    rdx,ecx
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rdi,rax
M00_L04:
       mov       rcx,[rsi+8]
       mov       r8d,[rsi+18]
       mov       rdx,rdi
       call      qword ptr [7FFE77434FA8]; System.Array.Copy(System.Array, System.Array, Int32)
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
M00_L05:
       mov       rdx,[rsi+10]
       lea       rcx,[rbx+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       edx,[rsi+1C]
       mov       [rbx+1C],edx
M00_L06:
       mov       edx,[rsi+1C]
       neg       edx
       mov       [rbx+18],edx
       jmp       short M00_L10
M00_L07:
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M00_L05
M00_L08:
       mov       rdx,[rbx+8]
       mov       ecx,[rbx+18]
       mov       r8d,ecx
       mov       eax,esi
       add       r8,rax
       mov       eax,[rdx+8]
       cmp       r8,rax
       ja        near ptr M00_L44
       mov       ecx,ecx
       lea       rcx,[rdx+rcx*2+10]
       mov       edx,esi
       xor       r8d,r8d
       call      qword ptr [7FFE777A6EF8]; System.SpanHelpers.Fill[[System.Char, System.Private.CoreLib]](Char ByRef, UIntPtr, Char)
       add       [rbx+18],esi
       jmp       short M00_L10
M00_L09:
       xor       ecx,ecx
       mov       [rbx+18],rcx
M00_L10:
       mov       [rbp-30],rbx
       mov       rcx,offset MT_System.Int32[]
       test      dword ptr [rcx],80000000
       je        short M00_L11
       xor       eax,eax
       jmp       short M00_L12
M00_L11:
       test      byte ptr [rcx],30
       setne     al
       movzx     eax,al
M00_L12:
       mov       rcx,2016A010090
       movzx     ecx,al
       test      ecx,ecx
       jne       near ptr M00_L27
       mov       rcx,offset MT_System.Int32[]
       mov       rax,7FFED6E9E4E0
       call      rax
       movzx     ebx,al
       mov       rax,2016A010090
       cmp       dword ptr [7FFED71EE808],0
       jne       near ptr M00_L28
M00_L13:
       cmp       ebx,14
       je        near ptr M00_L29
       cmp       ebx,1D
       sete      cl
       movzx     ecx,cl
M00_L14:
       test      ecx,ecx
       je        near ptr M00_L19
       mov       rcx,offset MT_System.Int32[]
       call      00007FFED6E34240
       test      rax,rax
       je        near ptr M00_L30
       test      al,2
       jne       near ptr M00_L31
       mov       rcx,[rax+20]
       add       rcx,10
       mov       rdx,[rcx]
M00_L15:
       test      rdx,rdx
       je        near ptr M00_L32
M00_L16:
       mov       rcx,2016A010090
M00_L17:
       mov       [rbp-40],rdx
       lea       rcx,[rbp-30]
       lea       rdx,[rbp-40]
       lea       r8,[rbp-28]
       call      qword ptr [7FFE7799EA90]; DotNetTips.Spargine.Core.TypeHelper.ProcessType(System.Text.StringBuilder ByRef, System.Type ByRef, DotNetTips.Spargine.Core.DisplayNameOptions ByRef)
       mov       rcx,[rbp-30]
       mov       rdx,2016A0103CC
       mov       r8,[rcx+8]
       mov       eax,[rcx+18]
       lea       r10d,[rax+2]
       cmp       [r8+8],r10d
       jb        near ptr M00_L33
       movsxd    rdx,eax
       lea       rdx,[r8+rdx*2+10]
       mov       word ptr [rdx],5B
       mov       word ptr [rdx+2],5D
       mov       [rcx+18],r10d
M00_L18:
       xor       ecx,ecx
       mov       [rbp-40],rcx
       mov       rcx,[rbp-30]
       cmp       [rcx],ecx
       call      qword ptr [7FFE774DF790]; System.Text.StringBuilder.ToString()
       mov       [rbp-58],rax
       jmp       near ptr M00_L39
M00_L19:
       mov       rcx,2016A010090
       call      00007FFED6EA0F50
       test      eax,eax
       jne       near ptr M00_L34
       cmp       byte ptr [rbp-28],0
       je        near ptr M00_L36
       mov       rcx,2016A010090
       call      qword ptr [7FFE77297C00]; System.RuntimeType.InitializeCache()
       mov       rbx,rax
       mov       rax,[rbx+20]
       test      rax,rax
       jne       short M00_L20
       mov       rcx,[rbx+8]
       call      qword ptr [7FFE77434A38]; System.RuntimeType.IsFullNameRoundtripCompatible(System.RuntimeType)
       test      eax,eax
       je        short M00_L21
       lea       rdx,[rbx+20]
       mov       rcx,rbx
       mov       r8d,3
       call      qword ptr [7FFE77434A50]; System.RuntimeType+RuntimeTypeCache.ConstructName(System.String ByRef, System.TypeNameFormatFlags)
M00_L20:
       test      rax,rax
       je        near ptr M00_L36
       mov       rcx,2016A010090
       call      qword ptr [7FFE77297C00]; System.RuntimeType.InitializeCache()
       mov       rbx,rax
       mov       rsi,[rbx+20]
       test      rsi,rsi
       jne       short M00_L23
       mov       rcx,[rbx+8]
       call      qword ptr [7FFE77434A38]; System.RuntimeType.IsFullNameRoundtripCompatible(System.RuntimeType)
       test      eax,eax
       jne       short M00_L22
       xor       esi,esi
       jmp       short M00_L23
M00_L21:
       xor       eax,eax
       jmp       short M00_L20
M00_L22:
       lea       rdx,[rbx+20]
       mov       rcx,rbx
       mov       r8d,3
       call      qword ptr [7FFE77434A50]; System.RuntimeType+RuntimeTypeCache.ConstructName(System.String ByRef, System.TypeNameFormatFlags)
       mov       rsi,rax
M00_L23:
       mov       rbx,[rbp-30]
       cmp       [rbx],bl
       test      rsi,rsi
       je        short M00_L26
       lea       rdx,[rsi+0C]
       mov       r8d,[rsi+8]
       test      r8d,r8d
       je        short M00_L26
       mov       rcx,[rbx+8]
       mov       eax,[rbx+18]
       lea       edi,[rax+r8]
       cmp       edi,[rcx+8]
       ja        near ptr M00_L37
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jg        short M00_L24
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       jne       short M00_L25
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M00_L25
M00_L24:
       mov       r8d,r8d
       add       r8,r8
       call      qword ptr [7FFE77295818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L25:
       mov       [rbx+18],edi
M00_L26:
       movzx     r9d,word ptr [rbp-24]
       cmp       r9d,2B
       je        near ptr M00_L18
       jmp       near ptr M00_L38
M00_L27:
       mov       rcx,2016A010090
       mov       rax,[7FFE771DA1E8]
       call      qword ptr [rax+28]
       mov       rcx,[rbp-30]
       mov       r9d,[rax+8]
       mov       edx,[rbp-28]
       mov       [rbp-50],edx
       mov       dx,[rbp-24]
       mov       [rbp-4C],dx
       lea       rdx,[rbp-50]
       mov       [rsp+20],rdx
       mov       rdx,2016A010090
       mov       r8,rax
       call      qword ptr [7FFE7799F198]
       jmp       near ptr M00_L18
M00_L28:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L13
M00_L29:
       mov       ecx,1
       jmp       near ptr M00_L14
M00_L30:
       xor       edx,edx
       jmp       near ptr M00_L17
M00_L31:
       mov       rdx,rax
       and       rdx,0FFFFFFFFFFFFFFFD
       add       rdx,8
       mov       rdx,[rdx]
       jmp       near ptr M00_L15
M00_L32:
       mov       rcx,rax
       call      qword ptr [7FFE77295C80]; System.RuntimeTypeHandle.GetRuntimeTypeFromHandleSlow(IntPtr)
       mov       rdx,rax
       jmp       near ptr M00_L16
M00_L33:
       mov       r8d,2
       call      qword ptr [7FFE7743F120]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M00_L18
M00_L34:
       cmp       byte ptr [rbp-27],0
       je        near ptr M00_L18
       mov       rbx,[rbp-30]
       mov       rcx,2016A010090
       mov       rax,[7FFE771DA1C0]
       call      qword ptr [rax+30]
       mov       rdx,rax
       mov       rcx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FFE7743F168]; System.Text.StringBuilder.Append(System.String)
       jmp       near ptr M00_L18
M00_L35:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L36:
       mov       rcx,2016A010090
       mov       rax,[7FFE771DA1C0]
       call      qword ptr [rax+30]
       mov       rsi,rax
       jmp       near ptr M00_L23
M00_L37:
       mov       rcx,rbx
       call      qword ptr [7FFE7743F120]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M00_L26
M00_L38:
       mov       rcx,[rbp-30]
       movzx     r8d,word ptr [rbp-24]
       mov       r9,[rbp-30]
       mov       edx,[r9+1C]
       add       edx,[r9+18]
       mov       r9d,edx
       sub       r9d,[rsi+8]
       jo        short M00_L35
       mov       edx,[rsi+8]
       mov       [rsp+20],edx
       mov       edx,2B
       cmp       [rcx],ecx
       call      qword ptr [7FFE7799EF88]
       jmp       near ptr M00_L18
M00_L39:
       call      M00_L46
       nop
       xor       ecx,ecx
       mov       [rbp-30],rcx
       mov       r10,[rbp-58]
       mov       [rbp-48],r10
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+18]
       lea       r8,[rbp-48]
       mov       rdx,7FFE77A3ABC8
       cmp       [rcx],ecx
       call      qword ptr [7FFE7799F1F8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,60
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M00_L40:
       call      qword ptr [7FFE77A660A0]
       int       3
M00_L41:
       mov       rcx,[rbx+18]
       lea       rdx,[rbp-38]
       cmp       [rcx],ecx
       call      qword ptr [7FFE77994660]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M00_L42
       add       rbx,2C
       lock dec  dword ptr [rbx]
       jmp       near ptr M00_L00
M00_L42:
       mov       rax,[rbx+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       rbx,rax
       jmp       near ptr M00_L01
M00_L43:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FFE771D4000
       call      qword ptr [7FFE775176F0]
       mov       rsi,rax
       call      qword ptr [7FFE77A67258]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE77885C50]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L44:
       mov       rcx,rbx
       mov       r8d,esi
       xor       edx,edx
       call      qword ptr [7FFE77A6C420]
       jmp       near ptr M00_L10
M00_L45:
       xor       edx,edx
       call      qword ptr [7FFE7790E010]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       rdi,rax
       jmp       near ptr M00_L04
M00_L46:
       sub       rsp,28
       vzeroupper
       mov       rbx,[rbp-30]
       mov       rax,1C0D50020C0
       mov       rsi,[rax]
       mov       rdi,[rsi+10]
       mov       rax,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [rdi+18],rax
       jne       near ptr M00_L58
       mov       rax,[rbx+8]
       mov       eax,[rax+8]
       mov       ecx,[rbx+1C]
       add       eax,ecx
       mov       rdx,[rdi+8]
       cmp       eax,[rdx+0C]
       jg        near ptr M00_L63
       cmp       dword ptr [rbx+20],0
       jge       short M00_L47
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FFE771D4000
       call      qword ptr [7FFE775176F0]
       mov       rsi,rax
       call      qword ptr [7FFE77A67258]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE77885C50]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L47:
       cmp       qword ptr [rbx+10],0
       jne       short M00_L48
       xor       ecx,ecx
       mov       [rbx+18],rcx
       jmp       near ptr M00_L59
M00_L48:
       mov       eax,ecx
       add       eax,[rbx+18]
       mov       edi,eax
       neg       edi
       test      edi,edi
       jle       short M00_L50
       mov       rdx,[rbx+8]
       mov       ecx,[rbx+18]
       mov       r8d,ecx
       mov       eax,edi
       add       r8,rax
       mov       eax,[rdx+8]
       cmp       r8,rax
       ja        short M00_L49
       mov       ecx,ecx
       lea       rcx,[rdx+rcx*2+10]
       mov       edx,edi
       xor       r8d,r8d
       call      qword ptr [7FFE777A6EF8]; System.SpanHelpers.Fill[[System.Char, System.Private.CoreLib]](Char ByRef, UIntPtr, Char)
       add       [rbx+18],edi
       jmp       near ptr M00_L59
M00_L49:
       mov       rcx,rbx
       mov       r8d,edi
       xor       edx,edx
       call      qword ptr [7FFE77A6C420]
       jmp       near ptr M00_L59
M00_L50:
       mov       rdi,rbx
       test      ecx,ecx
       jle       short M00_L52
M00_L51:
       mov       rdi,[rdi+10]
       cmp       dword ptr [rdi+1C],0
       jg        short M00_L51
M00_L52:
       cmp       rdi,rbx
       je        near ptr M00_L57
       mov       rdx,[rbx+8]
       add       ecx,[rdx+8]
       lea       edx,[rax+rax*2]
       add       edx,edx
       mov       r8d,66666667
       mov       eax,r8d
       imul      edx
       mov       eax,edx
       shr       eax,1F
       sar       edx,1
       add       edx,eax
       mov       rax,[rbx+8]
       mov       eax,[rax+8]
       cmp       edx,eax
       cmovl     edx,eax
       cmp       ecx,edx
       cmovg     ecx,edx
       sub       ecx,[rdi+1C]
       mov       rdx,[rdi+8]
       cmp       [rdx+8],ecx
       jge       short M00_L55
       cmp       ecx,400
       jge       short M00_L53
       movsxd    rdx,ecx
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
       jmp       short M00_L54
M00_L53:
       xor       edx,edx
       call      qword ptr [7FFE7790E010]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       r14,rax
M00_L54:
       mov       rcx,[rdi+8]
       mov       r8d,[rdi+18]
       mov       rdx,r14
       call      qword ptr [7FFE77434FA8]; System.Array.Copy(System.Array, System.Array, Int32)
       lea       rcx,[rbx+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M00_L56
M00_L55:
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
M00_L56:
       mov       rdx,[rdi+10]
       lea       rcx,[rbx+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       edx,[rdi+1C]
       mov       [rbx+1C],edx
M00_L57:
       mov       edx,[rdi+1C]
       neg       edx
       mov       [rbx+18],edx
       jmp       short M00_L59
M00_L58:
       mov       rdx,rbx
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       test      eax,eax
       je        short M00_L63
M00_L59:
       cmp       qword ptr [rsi+20],0
       jne       short M00_L61
       lea       rcx,[rsi+20]
       test      rcx,rcx
       jne       short M00_L60
       call      qword ptr [7FFE77A660A0]
       int       3
M00_L60:
       mov       rdx,rbx
       xor       r8d,r8d
       call      00007FFED6E8EEF0
       test      rax,rax
       je        short M00_L63
M00_L61:
       lea       rcx,[rsi+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[rsi+28]
       jg        short M00_L62
       mov       rcx,[rsi+18]
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FFE77994768]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
       jmp       short M00_L63
M00_L62:
       add       rsi,2C
       lock dec  dword ptr [rsi]
M00_L63:
       add       rsp,28
       ret
; Total bytes of code 2106
```
```assembly
; System.Array.Copy(System.Array, System.Array, Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rsi,rcx
       mov       rbx,rdx
       mov       edi,r8d
       test      rsi,rsi
       je        near ptr M01_L10
       test      rbx,rbx
       je        near ptr M01_L09
       mov       rcx,[rsi]
       cmp       rcx,[rbx]
       jne       near ptr M01_L08
       cmp       dword ptr [rcx+4],18
       jne       near ptr M01_L07
       cmp       edi,[rsi+8]
       ja        near ptr M01_L06
       cmp       edi,[rbx+8]
       ja        near ptr M01_L05
       mov       edi,edi
       movzx     ebp,word ptr [rcx]
       imul      rdi,rbp
       add       rsi,10
       add       rbx,10
       test      dword ptr [rcx],1000000
       je        short M01_L01
       mov       rcx,7FFE77A90E50
       call      CORINFO_HELP_COUNTPROFILE32
       cmp       rdi,4000
       ja        short M01_L04
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       call      00007FFED6E70160
       cmp       dword ptr [7FFED71EE808],0
       jne       short M01_L03
M01_L00:
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L01:
       mov       rcx,7FFE77A90E68
       call      CORINFO_HELP_COUNTPROFILE32
       cmp       rdi,19
       je        short M01_L02
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       call      qword ptr [7FFE77295818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L00
M01_L02:
       vmovdqu   xmm0,xmmword ptr [rsi]
       vmovdqu   xmm1,xmmword ptr [rsi+9]
       vmovdqu   xmmword ptr [rbx],xmm0
       vmovdqu   xmmword ptr [rbx+9],xmm1
       jmp       short M01_L00
M01_L03:
       call      CORINFO_HELP_POLL_GC
       jmp       short M01_L00
M01_L04:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       qword ptr [7FFE7790D7B8]
M01_L05:
       mov       rcx,7FFE77A90E54
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M01_L11
M01_L06:
       mov       rcx,7FFE77A90E58
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M01_L11
M01_L07:
       mov       rcx,7FFE77A90E5C
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M01_L11
M01_L08:
       mov       rcx,7FFE77A90E60
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M01_L11
M01_L09:
       mov       rcx,7FFE77A90E64
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M01_L11
M01_L10:
       xor       esi,esi
       xor       ebp,ebp
       jmp       short M01_L12
M01_L11:
       mov       rcx,7FFE77A90E6C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFE77A64DC8]; System.Array.GetLowerBound(Int32)
       mov       ebp,eax
M01_L12:
       test      rbx,rbx
       jne       short M01_L13
       xor       ebx,ebx
       xor       r14d,r14d
       jmp       short M01_L14
M01_L13:
       mov       rcx,7FFE77A90E70
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFE77A64DC8]; System.Array.GetLowerBound(Int32)
       mov       r14d,eax
M01_L14:
       mov       rcx,7FFE77A90E74
       call      CORINFO_HELP_COUNTPROFILE32
       mov       [rsp+20],edi
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rsi
       mov       edx,ebp
       mov       r8,rbx
       mov       r9d,r14d
       call      qword ptr [7FFE77A64DE0]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M01_L00
; Total bytes of code 457
```
```assembly
; System.SpanHelpers.Fill[[System.Char, System.Private.CoreLib]](Char ByRef, UIntPtr, Char)
       cmp       rdx,10
       jae       short M02_L05
       xor       eax,eax
       cmp       rdx,8
       jae       short M02_L10
M02_L00:
       test      dl,4
       jne       near ptr M02_L12
M02_L01:
       test      dl,2
       jne       short M02_L04
M02_L02:
       test      dl,1
       je        short M02_L03
       mov       [rcx+rax*2],r8w
M02_L03:
       vzeroupper
       ret
M02_L04:
       mov       [rcx+rax*2],r8w
       mov       [rcx+rax*2+2],r8w
       add       rax,2
       jmp       short M02_L02
M02_L05:
       vmovd     xmm0,r8d
       vpbroadcastw ymm0,xmm0
       lea       rax,[rdx+rdx]
       mov       r8,rax
       and       r8,0FFFFFFFFFFFFFFC0
       xor       r10d,r10d
       cmp       rdx,20
       jb        short M02_L07
M02_L06:
       vmovups   [rcx+r10],ymm0
       vmovups   [rcx+r10+20],ymm0
       add       r10,40
       cmp       r10,r8
       jb        short M02_L06
M02_L07:
       test      al,20
       jne       short M02_L09
M02_L08:
       vmovups   [rcx+rax-20],ymm0
       jmp       short M02_L03
M02_L09:
       vmovups   [rcx+r10],ymm0
       jmp       short M02_L08
M02_L10:
       mov       r10,rdx
       and       r10,0FFFFFFFFFFFFFFF8
M02_L11:
       mov       [rcx+rax*2],r8w
       mov       [rcx+rax*2+2],r8w
       mov       [rcx+rax*2+4],r8w
       mov       [rcx+rax*2+6],r8w
       mov       [rcx+rax*2+8],r8w
       mov       [rcx+rax*2+0A],r8w
       mov       [rcx+rax*2+0C],r8w
       mov       [rcx+rax*2+0E],r8w
       add       rax,8
       cmp       rax,r10
       jb        short M02_L11
       jmp       near ptr M02_L00
M02_L12:
       mov       [rcx+rax*2],r8w
       mov       [rcx+rax*2+2],r8w
       mov       [rcx+rax*2+4],r8w
       mov       [rcx+rax*2+6],r8w
       add       rax,4
       jmp       near ptr M02_L01
; Total bytes of code 231
```
```assembly
; DotNetTips.Spargine.Core.TypeHelper.ProcessType(System.Text.StringBuilder ByRef, System.Type ByRef, DotNetTips.Spargine.Core.DisplayNameOptions ByRef)
; 		if (type.IsGenericType)
; 		^^^^^^^^^^^^^^^^^^^^^^^
; 			var genericArguments = type.GetGenericArguments();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			ProcessGenericType(builder, type, genericArguments, genericArguments.Length, options);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		else if (type.IsArray)
; 		     ^^^^^^^^^^^^^^^^^
; 			ProcessType(builder, type.GetElementType()!, options);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			_ = builder.Append("[]");
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
; 		else if (type.IsGenericParameter)
; 		     ^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			if (options.IncludeGenericParameterNames)
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 				_ = builder.Append(type.Name);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var name = options.FullName && type.FullName is not null ? type.FullName : type.Name;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			_ = builder.Append(name);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
; 			if (options.NestedTypeDelimiter != ControlChars.Plus)
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 				_ = builder.Replace(ControlChars.Plus, options.NestedTypeDelimiter, builder.Length - name.Length, name.Length);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M03_L00:
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,50
       vzeroupper
       xor       eax,eax
       mov       [rsp+48],rax
       mov       [rsp+90],rcx
       mov       [rsp+0A0],r8
       mov       rbx,rdx
       mov       rcx,[rbx]
       mov       rbp,offset MT_System.RuntimeType
       cmp       [rcx],rbp
       jne       near ptr M03_L47
       mov       rsi,[rsp+90]
       mov       rdi,[rsp+0A0]
       mov       rax,[rcx+18]
       test      al,2
       jne       near ptr M03_L46
       test      dword ptr [rax],80000000
       je        short M03_L01
       xor       edx,edx
       jmp       short M03_L02
M03_L01:
       test      byte ptr [rax],30
       setne     dl
       movzx     edx,dl
M03_L02:
       movzx     r14d,dl
M03_L03:
       test      r14d,r14d
       jne       near ptr M03_L48
       mov       [rsp+98],rbx
       mov       r14,[rbx]
       mov       [rsp+30],r14
       cmp       [r14],rbp
       jne       near ptr M03_L51
       mov       [rsp+90],rsi
       mov       [rsp+0A0],rdi
       mov       rcx,[r14+18]
       mov       rax,7FFED6E9E4E0
       call      rax
       movzx     ebx,al
       cmp       dword ptr [7FFED71EE808],0
       jne       near ptr M03_L49
M03_L04:
       cmp       ebx,14
       je        near ptr M03_L50
       cmp       ebx,1D
       sete      al
       movzx     eax,al
M03_L05:
       mov       rsi,[rsp+90]
       mov       rdi,[rsp+0A0]
M03_L06:
       test      eax,eax
       je        near ptr M03_L31
       mov       rbx,[rsp+98]
       mov       rbx,[rbx]
       cmp       [rbx],rbp
       jne       near ptr M03_L55
       mov       rcx,[rbx+18]
       call      00007FFED6E34240
       test      rax,rax
       je        near ptr M03_L52
       test      al,2
       jne       near ptr M03_L53
       mov       rcx,[rax+20]
       add       rcx,10
       mov       r14,[rcx]
M03_L07:
       test      r14,r14
       je        near ptr M03_L54
M03_L08:
       mov       rbx,[r14]
       cmp       rbx,rbp
       jne       near ptr M03_L57
       mov       rcx,[r14+18]
       test      cl,2
       jne       near ptr M03_L56
       mov       ecx,[rcx]
       test      ecx,80000000
       je        short M03_L09
       xor       eax,eax
       jmp       short M03_L10
M03_L09:
       test      cl,30
       setne     al
       movzx     eax,al
M03_L10:
       movzx     r15d,al
M03_L11:
       test      r15d,r15d
       jne       near ptr M03_L58
       cmp       rbx,rbp
       jne       near ptr M03_L61
       mov       [rsp+90],rsi
       mov       [rsp+0A0],rdi
       mov       [rsp+38],r14
       mov       rcx,[r14+18]
       mov       rax,7FFED6E9E4E0
       call      rax
       movzx     esi,al
       mov       r14,[rsp+38]
       cmp       dword ptr [7FFED71EE808],0
       jne       near ptr M03_L59
M03_L12:
       cmp       esi,14
       je        near ptr M03_L60
       cmp       esi,1D
       sete      al
       movzx     eax,al
M03_L13:
       mov       rsi,[rsp+90]
       mov       rdi,[rsp+0A0]
M03_L14:
       test      eax,eax
       je        near ptr M03_L18
       cmp       rbx,rbp
       jne       near ptr M03_L63
       mov       rcx,[r14+18]
       call      00007FFED6E34240
       test      rax,rax
       je        near ptr M03_L62
       mov       rcx,rax
       call      qword ptr [7FFE77295860]; System.RuntimeTypeHandle.GetRuntimeTypeFromHandle(IntPtr)
       nop
M03_L15:
       mov       [rsp+48],rax
       lea       rdx,[rsp+48]
       mov       rcx,rsi
       mov       r8,rdi
       call      qword ptr [7FFE7799EA90]
       mov       rcx,[rsi]
       mov       rdx,2016A0103CC
       mov       r8,[rcx+8]
       mov       eax,[rcx+18]
       lea       r10d,[rax+2]
       cmp       [r8+8],r10d
       jb        near ptr M03_L64
       movsxd    rdx,eax
       lea       rdx,[r8+rdx*2+10]
       mov       word ptr [rdx],5B
       mov       word ptr [rdx+2],5D
       mov       [rcx+18],r10d
M03_L16:
       xor       ecx,ecx
       mov       [rsp+48],rcx
       mov       rcx,[rsi]
       mov       rdx,2016A0103CC
       mov       r8,[rcx+8]
       mov       eax,[rcx+18]
       lea       r10d,[rax+2]
       cmp       [r8+8],r10d
       jb        near ptr M03_L71
       movsxd    rdx,eax
       lea       rdx,[r8+rdx*2+10]
       mov       word ptr [rdx],5B
       mov       word ptr [rdx+2],5D
       mov       [rcx+18],r10d
M03_L17:
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L18:
       cmp       rbx,rbp
       jne       near ptr M03_L65
       mov       rcx,r14
       call      00007FFED6EA0F50
M03_L19:
       test      eax,eax
       jne       near ptr M03_L66
       cmp       byte ptr [rdi],0
       je        near ptr M03_L68
       cmp       rbx,rbp
       jne       near ptr M03_L67
       cmp       qword ptr [r14+10],0
       je        short M03_L20
       mov       rcx,[r14+10]
       mov       r15,[rcx]
       test      r15,r15
       jne       short M03_L22
M03_L20:
       mov       rcx,r14
       call      qword ptr [7FFE77297C00]; System.RuntimeType.InitializeCache()
       mov       r13,rax
M03_L21:
       mov       rax,[r13+20]
       test      rax,rax
       jne       short M03_L24
       mov       rcx,[r13+8]
       call      qword ptr [7FFE77434A38]; System.RuntimeType.IsFullNameRoundtripCompatible(System.RuntimeType)
       test      eax,eax
       jne       short M03_L23
       xor       eax,eax
       jmp       short M03_L24
M03_L22:
       mov       r13,r15
       jmp       short M03_L21
M03_L23:
       lea       rdx,[r13+20]
       mov       rcx,r13
       mov       r8d,3
       call      qword ptr [7FFE77434A50]; System.RuntimeType+RuntimeTypeCache.ConstructName(System.String ByRef, System.TypeNameFormatFlags)
M03_L24:
       test      rax,rax
       je        near ptr M03_L68
       cmp       rbx,rbp
       jne       near ptr M03_L69
       cmp       qword ptr [r14+10],0
       je        short M03_L25
       mov       rcx,[r14+10]
       mov       rbx,[rcx]
       test      rbx,rbx
       jne       short M03_L27
M03_L25:
       mov       rcx,r14
       call      qword ptr [7FFE77297C00]; System.RuntimeType.InitializeCache()
       mov       r14,rax
M03_L26:
       mov       rbp,[r14+20]
       test      rbp,rbp
       jne       short M03_L29
       mov       rcx,[r14+8]
       call      qword ptr [7FFE77434A38]; System.RuntimeType.IsFullNameRoundtripCompatible(System.RuntimeType)
       test      eax,eax
       jne       short M03_L28
       xor       ebp,ebp
       jmp       short M03_L29
M03_L27:
       mov       r14,rbx
       jmp       short M03_L26
M03_L28:
       lea       rdx,[r14+20]
       mov       rcx,r14
       mov       r8d,3
       call      qword ptr [7FFE77434A50]; System.RuntimeType+RuntimeTypeCache.ConstructName(System.String ByRef, System.TypeNameFormatFlags)
       mov       rbp,rax
M03_L29:
       mov       rcx,[rsi]
       cmp       [rcx],cl
       test      rbp,rbp
       je        short M03_L30
       mov       r8d,[rbp+8]
       lea       rdx,[rbp+0C]
       call      qword ptr [7FFE7743F090]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M03_L30:
       cmp       word ptr [rdi+4],2B
       je        near ptr M03_L16
       jmp       near ptr M03_L70
M03_L31:
       mov       rbx,[rsp+98]
       mov       rcx,[rbx]
       cmp       [rcx],rbp
       jne       near ptr M03_L72
       call      00007FFED6EA0F50
M03_L32:
       test      eax,eax
       jne       near ptr M03_L73
       cmp       byte ptr [rdi],0
       je        near ptr M03_L75
       mov       rcx,[rbx]
       cmp       [rcx],rbp
       jne       near ptr M03_L74
       cmp       qword ptr [rcx+10],0
       je        short M03_L33
       mov       rax,[rcx+10]
       mov       r14,[rax]
       test      r14,r14
       jne       short M03_L35
M03_L33:
       call      qword ptr [7FFE77297C00]; System.RuntimeType.InitializeCache()
       mov       r15,rax
M03_L34:
       mov       rax,[r15+20]
       test      rax,rax
       jne       short M03_L37
       mov       rcx,[r15+8]
       call      qword ptr [7FFE77434A38]; System.RuntimeType.IsFullNameRoundtripCompatible(System.RuntimeType)
       test      eax,eax
       jne       short M03_L36
       xor       eax,eax
       jmp       short M03_L37
M03_L35:
       mov       r15,r14
       jmp       short M03_L34
M03_L36:
       lea       rdx,[r15+20]
       mov       rcx,r15
       mov       r8d,3
       call      qword ptr [7FFE77434A50]; System.RuntimeType+RuntimeTypeCache.ConstructName(System.String ByRef, System.TypeNameFormatFlags)
M03_L37:
       test      rax,rax
       je        near ptr M03_L75
       mov       rcx,[rbx]
       cmp       [rcx],rbp
       jne       near ptr M03_L76
       cmp       qword ptr [rcx+10],0
       je        short M03_L38
       mov       rax,[rcx+10]
       mov       rbx,[rax]
       test      rbx,rbx
       jne       short M03_L40
M03_L38:
       call      qword ptr [7FFE77297C00]; System.RuntimeType.InitializeCache()
       mov       rbp,rax
M03_L39:
       mov       rbx,[rbp+20]
       test      rbx,rbx
       jne       short M03_L42
       mov       rcx,[rbp+8]
       call      qword ptr [7FFE77434A38]; System.RuntimeType.IsFullNameRoundtripCompatible(System.RuntimeType)
       test      eax,eax
       jne       short M03_L41
       xor       ebx,ebx
       jmp       short M03_L42
M03_L40:
       mov       rbp,rbx
       jmp       short M03_L39
M03_L41:
       lea       rdx,[rbp+20]
       mov       rcx,rbp
       mov       r8d,3
       call      qword ptr [7FFE77434A50]; System.RuntimeType+RuntimeTypeCache.ConstructName(System.String ByRef, System.TypeNameFormatFlags)
       mov       rbx,rax
M03_L42:
       mov       rbp,[rsi]
       cmp       [rbp],bpl
       test      rbx,rbx
       je        short M03_L45
       lea       rdx,[rbx+0C]
       mov       r8d,[rbx+8]
       test      r8d,r8d
       je        short M03_L45
       mov       rcx,[rbp+8]
       mov       eax,[rbp+18]
       lea       r14d,[rax+r8]
       cmp       r14d,[rcx+8]
       ja        near ptr M03_L77
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jg        short M03_L43
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       jne       short M03_L44
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M03_L44
M03_L43:
       mov       r8d,r8d
       add       r8,r8
       call      qword ptr [7FFE77295818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M03_L44:
       mov       [rbp+18],r14d
M03_L45:
       cmp       word ptr [rdi+4],2B
       je        near ptr M03_L17
       jmp       near ptr M03_L78
M03_L46:
       xor       edx,edx
       jmp       near ptr M03_L02
M03_L47:
       mov       rsi,[rsp+90]
       mov       rdi,[rsp+0A0]
       mov       rax,[rcx]
       mov       rax,[rax+60]
       call      qword ptr [rax+8]
       mov       r14d,eax
       jmp       near ptr M03_L03
M03_L48:
       mov       rcx,[rbx]
       mov       rax,[rcx]
       mov       rax,[rax+68]
       call      qword ptr [rax+28]
       mov       rcx,[rsi]
       mov       rdx,[rbx]
       mov       r9d,[rax+8]
       mov       r8d,[rdi]
       mov       [rsp+40],r8d
       mov       r8w,[rdi+4]
       mov       [rsp+44],r8w
       lea       r8,[rsp+40]
       mov       [rsp+20],r8
       mov       r8,rax
       call      qword ptr [7FFE7799F198]
       jmp       near ptr M03_L17
M03_L49:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M03_L04
M03_L50:
       mov       eax,1
       jmp       near ptr M03_L05
M03_L51:
       mov       rcx,r14
       mov       rax,[r14]
       mov       rax,[rax+58]
       call      qword ptr [rax+10]
       jmp       near ptr M03_L06
M03_L52:
       xor       r14d,r14d
       jmp       near ptr M03_L08
M03_L53:
       mov       rcx,rax
       and       rcx,0FFFFFFFFFFFFFFFD
       add       rcx,8
       mov       r14,[rcx]
       jmp       near ptr M03_L07
M03_L54:
       mov       rcx,rax
       call      qword ptr [7FFE77295C80]; System.RuntimeTypeHandle.GetRuntimeTypeFromHandleSlow(IntPtr)
       mov       r14,rax
       jmp       near ptr M03_L08
M03_L55:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+68]
       call      qword ptr [rax+8]
       mov       r14,rax
       jmp       near ptr M03_L08
M03_L56:
       xor       eax,eax
       jmp       near ptr M03_L10
M03_L57:
       mov       rcx,r14
       mov       rax,[rbx+60]
       call      qword ptr [rax+8]
       mov       r15d,eax
       jmp       near ptr M03_L11
M03_L58:
       mov       rcx,r14
       mov       rax,[rbx+68]
       call      qword ptr [rax+28]
       mov       rcx,[rsi]
       mov       r9d,[rax+8]
       mov       edx,[rdi]
       mov       [rsp+40],edx
       mov       dx,[rdi+4]
       mov       [rsp+44],dx
       lea       rdx,[rsp+40]
       mov       [rsp+20],rdx
       mov       rdx,r14
       mov       r8,rax
       call      qword ptr [7FFE7799F198]
       jmp       near ptr M03_L16
M03_L59:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M03_L12
M03_L60:
       mov       eax,1
       jmp       near ptr M03_L13
M03_L61:
       mov       rcx,r14
       mov       rax,[rbx+58]
       call      qword ptr [rax+10]
       jmp       near ptr M03_L14
M03_L62:
       xor       eax,eax
       jmp       near ptr M03_L15
M03_L63:
       mov       rcx,r14
       mov       rax,[rbx+68]
       call      qword ptr [rax+8]
       jmp       near ptr M03_L15
M03_L64:
       mov       r8d,2
       call      qword ptr [7FFE7743F120]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M03_L16
M03_L65:
       mov       rcx,r14
       mov       rax,[rbx+58]
       call      qword ptr [rax+30]
       jmp       near ptr M03_L19
M03_L66:
       cmp       byte ptr [rdi+1],0
       je        near ptr M03_L16
       mov       rdi,[rsi]
       mov       rcx,r14
       mov       rax,[rbx+40]
       call      qword ptr [rax+30]
       mov       rdx,rax
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFE7743F168]; System.Text.StringBuilder.Append(System.String)
       jmp       near ptr M03_L16
M03_L67:
       mov       rcx,r14
       mov       rax,[rbx+50]
       call      qword ptr [rax+20]
       jmp       near ptr M03_L24
M03_L68:
       mov       rcx,r14
       mov       rax,[rbx+40]
       call      qword ptr [rax+30]
       mov       rbp,rax
       jmp       near ptr M03_L29
M03_L69:
       mov       rcx,r14
       mov       rax,[rbx+50]
       call      qword ptr [rax+20]
       mov       rbp,rax
       jmp       near ptr M03_L29
M03_L70:
       mov       rcx,[rsi]
       movzx     r8d,word ptr [rdi+4]
       mov       r9,[rsi]
       mov       edx,[r9+1C]
       add       edx,[r9+18]
       mov       r9d,edx
       sub       r9d,[rbp+8]
       jo        near ptr M03_L79
       mov       edx,[rbp+8]
       mov       [rsp+20],edx
       mov       edx,2B
       cmp       [rcx],ecx
       call      qword ptr [7FFE7799EF88]
       jmp       near ptr M03_L16
M03_L71:
       mov       r8d,2
       call      qword ptr [7FFE7743F120]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M03_L17
M03_L72:
       mov       rax,[rcx]
       mov       rax,[rax+58]
       call      qword ptr [rax+30]
       jmp       near ptr M03_L32
M03_L73:
       cmp       byte ptr [rdi+1],0
       je        near ptr M03_L17
       mov       rsi,[rsi]
       mov       rcx,[rbx]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       rdx,rax
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFE7743F168]; System.Text.StringBuilder.Append(System.String)
       jmp       near ptr M03_L17
M03_L74:
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+20]
       jmp       near ptr M03_L37
M03_L75:
       mov       rcx,[rbx]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       rbx,rax
       jmp       near ptr M03_L42
M03_L76:
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+20]
       mov       rbx,rax
       jmp       near ptr M03_L42
M03_L77:
       mov       rcx,rbp
       call      qword ptr [7FFE7743F120]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M03_L45
M03_L78:
       mov       rcx,[rsi]
       movzx     r8d,word ptr [rdi+4]
       mov       r9,[rsi]
       mov       edx,[r9+1C]
       add       edx,[r9+18]
       mov       r9d,edx
       sub       r9d,[rbx+8]
       jo        short M03_L79
       mov       edx,[rbx+8]
       mov       [rsp+20],edx
       mov       edx,2B
       cmp       [rcx],ecx
       call      qword ptr [7FFE7799EF88]
       jmp       near ptr M03_L17
M03_L79:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 2030
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       edx,[rbx+1C]
       add       edx,[rbx+18]
       je        short M04_L02
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFED6EDF840
       mov       rsi,rax
M04_L00:
       mov       r8d,[rbx+18]
       test      r8d,r8d
       jle       short M04_L01
       mov       rdx,[rbx+8]
       mov       ecx,[rbx+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rsi+8]
       ja        short M04_L03
       cmp       [rdx+8],r8d
       jb        short M04_L03
       movsxd    rcx,ecx
       lea       rcx,[rsi+rcx*2+0C]
       movsxd    r8,r8d
       add       r8,r8
       add       rdx,10
       call      qword ptr [7FFE77295818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M04_L01:
       mov       rbx,[rbx+10]
       test      rbx,rbx
       jne       short M04_L00
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L02:
       mov       rax,2016A000008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,196A5
       mov       rdx,7FFE771D4000
       call      qword ptr [7FFE775176F0]
       mov       rbx,rax
       call      qword ptr [7FFE77A660B8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE77885C50]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 201
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
       call      00007FFED6E34140
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
       mov       rax,7FFE773F6D90
       mov       [rbp-78],rax
       lea       rax,[M05_L03]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFED6DD50B0
       call      rax
M05_L03:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFED71EE808],0
       je        short M05_L04
       call      qword ptr [7FFED71DC608]; CORINFO_HELP_STOP_FOR_GC
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
       call      00007FFED6EB03C0
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
       call      qword ptr [7FFE77A6C498]; System.RuntimeTypeHandle.GetGCHandle(System.Runtime.InteropServices.GCHandleType)
       mov       rdx,rax
       lea       rcx,[rbx+10]
       xor       eax,eax
       lock cmpxchg [rcx],rdx
       test      rax,rax
       je        near ptr M05_L00
       lea       rcx,[rbp-40]
       call      qword ptr [7FFE77A673A8]
       jmp       near ptr M05_L00
M05_L09:
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M05_L10:
       mov       [rbp+10],rbx
       mov       rcx,rbx
       call      qword ptr [7FFE77297C48]; System.RuntimeTypeHandle.<GetModule>g__GetModuleWorker|48_0(System.RuntimeType)
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
; System.RuntimeType.IsFullNameRoundtripCompatible(System.RuntimeType)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,40
       vzeroupper
       cmp       [rcx],cl
       mov       rbx,rcx
       mov       rsi,offset MT_System.RuntimeType
M06_L00:
       mov       rdi,[rbx]
       cmp       rdi,rsi
       jne       near ptr M06_L17
       mov       [rsp+30],rbx
       mov       rcx,[rbx+18]
       mov       rax,7FFED6E9E4E0
       call      rax
       movzx     ebx,al
       mov       rbp,[rsp+30]
       cmp       dword ptr [7FFED71EE808],0
       jne       near ptr M06_L15
M06_L01:
       cmp       ebx,1D
       ja        short M06_L02
       mov       ecx,1FEF7FFF
       bt        ecx,ebx
       jae       near ptr M06_L16
M06_L02:
       cmp       ebx,10
       sete      r14b
       movzx     r14d,r14b
M06_L03:
       test      r14d,r14d
       jne       near ptr M06_L14
       mov       [rsp+38],rbp
       cmp       rdi,rsi
       jne       near ptr M06_L19
       mov       rcx,[rbp+18]
       test      cl,2
       jne       near ptr M06_L18
       mov       ecx,[rcx]
       and       ecx,80000030
       cmp       ecx,30
       sete      al
       movzx     eax,al
M06_L04:
       test      eax,eax
       jne       near ptr M06_L11
       cmp       rdi,rsi
       jne       near ptr M06_L26
       mov       rbx,rbp
       mov       rbp,[rsp+38]
M06_L05:
       cmp       [rbx],rsi
       jne       near ptr M06_L23
       mov       [rsp+28],rbx
       mov       rcx,[rbx+18]
       mov       rax,7FFED6E9E4E0
       call      rax
       movzx     ebx,al
       cmp       dword ptr [7FFED71EE808],0
       jne       near ptr M06_L21
       mov       rcx,[rsp+28]
M06_L06:
       cmp       ebx,1D
       ja        short M06_L07
       mov       eax,1FEF7FFF
       bt        eax,ebx
       jae       near ptr M06_L22
M06_L07:
       cmp       ebx,10
       sete      bpl
       movzx     ebp,bpl
M06_L08:
       test      ebp,ebp
       jne       near ptr M06_L20
       cmp       [rcx],rsi
       jne       near ptr M06_L24
M06_L09:
       test      rcx,rcx
       je        near ptr M06_L25
       call      00007FFED6EA1090
M06_L10:
       test      eax,eax
       mov       rbp,[rsp+38]
       jne       near ptr M06_L27
M06_L11:
       cmp       rdi,rsi
       jne       near ptr M06_L29
       mov       rcx,[rbp+18]
       mov       rax,7FFED6E9E4E0
       call      rax
       movzx     edi,al
       cmp       dword ptr [7FFED71EE808],0
       jne       near ptr M06_L28
M06_L12:
       cmp       edi,1B
       je        near ptr M06_L27
M06_L13:
       mov       eax,1
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M06_L14:
       mov       rcx,rbp
       mov       rax,[rdi+68]
       call      qword ptr [rax+8]
       mov       rbp,rax
       mov       rbx,rbp
       jmp       near ptr M06_L00
M06_L15:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M06_L01
M06_L16:
       mov       r14d,1
       jmp       near ptr M06_L03
M06_L17:
       mov       rcx,rbx
       mov       rax,[rdi+68]
       call      qword ptr [rax]
       mov       r14d,eax
       mov       rbp,rbx
       jmp       near ptr M06_L03
M06_L18:
       xor       eax,eax
       jmp       near ptr M06_L04
M06_L19:
       mov       rcx,rbp
       mov       rax,[rdi+60]
       call      qword ptr [rax+10]
       jmp       near ptr M06_L04
M06_L20:
       mov       rax,[rcx]
       mov       rax,[rax+68]
       call      qword ptr [rax+8]
       mov       rbx,rax
       mov       rbp,[rsp+38]
       jmp       near ptr M06_L05
M06_L21:
       call      CORINFO_HELP_POLL_GC
       mov       rcx,[rsp+28]
       jmp       near ptr M06_L06
M06_L22:
       mov       ebp,1
       jmp       near ptr M06_L08
M06_L23:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+68]
       call      qword ptr [rax]
       mov       rcx,rbx
       mov       ebp,eax
       jmp       near ptr M06_L08
M06_L24:
       mov       rax,[rcx]
       mov       rax,[rax+98]
       call      qword ptr [rax+8]
       mov       rcx,rax
       jmp       near ptr M06_L09
M06_L25:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFE77A67378]
       mov       r8,rax
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FFE77A67390]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M06_L26:
       mov       rcx,rbp
       mov       rax,[rdi+0B0]
       call      qword ptr [rax]
       jmp       near ptr M06_L10
M06_L27:
       xor       eax,eax
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M06_L28:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M06_L12
M06_L29:
       mov       rcx,rbp
       mov       rax,[rdi+60]
       call      qword ptr [rax+30]
       test      eax,eax
       jne       short M06_L27
       jmp       near ptr M06_L13
; Total bytes of code 663
```
```assembly
; System.RuntimeType+RuntimeTypeCache.ConstructName(System.String ByRef, System.TypeNameFormatFlags)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,78
       vzeroupper
       lea       rbp,[rsp+0B0]
       xor       eax,eax
       mov       [rbp-40],rax
       mov       [rbp-48],rax
       mov       [rbp+18],rdx
       mov       rbx,rcx
       mov       edi,r8d
       lea       rcx,[rbp-80]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       r14,rax
       mov       rcx,rsp
       mov       [rbp-68],rcx
       mov       rcx,rbp
       mov       [rbp-58],rcx
       mov       rcx,[rbx+8]
       test      rcx,rcx
       je        near ptr M07_L04
       mov       [rbp-48],rcx
       mov       rcx,[rbp-48]
       test      rcx,rcx
       je        near ptr M07_L03
       mov       rcx,[rcx+18]
M07_L00:
       lea       rdx,[rbp-48]
       mov       [rbp-90],rdx
       mov       [rbp-88],rcx
       lea       rcx,[rbp-90]
       mov       edx,edi
       lea       r8,[rbp-40]
       mov       rax,7FFE77304D48
       mov       [rbp-70],rax
       lea       rax,[M07_L01]
       mov       [rbp-60],rax
       lea       rax,[rbp-80]
       mov       [r14+8],rax
       mov       byte ptr [r14+4],0
       mov       rax,7FFED6E38460
       call      rax
M07_L01:
       mov       byte ptr [r14+4],1
       cmp       dword ptr [7FFED71EE808],0
       je        short M07_L02
       call      qword ptr [7FFED71DC608]; CORINFO_HELP_STOP_FOR_GC
M07_L02:
       mov       rcx,[rbp-78]
       mov       [r14+8],rcx
       mov       rbx,[rbp-40]
       xor       ecx,ecx
       mov       [rbp-40],rcx
       mov       rcx,[rbp+18]
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,rbx
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
M07_L03:
       xor       ecx,ecx
       jmp       near ptr M07_L00
M07_L04:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE77A67378]
       mov       r8,rax
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFE77A67390]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 312
```
```assembly
; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M08_L10
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M08_L10
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       jbe       short M08_L04
       cmp       r8,40
       ja        near ptr M08_L07
M08_L00:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        short M08_L03
M08_L01:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
M08_L02:
       vzeroupper
       ret
M08_L03:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M08_L01
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M08_L01
M08_L04:
       test      r8b,18
       je        short M08_L05
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
       jmp       short M08_L02
M08_L05:
       test      r8b,4
       je        short M08_L06
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
       jmp       short M08_L02
M08_L06:
       test      r8,r8
       je        short M08_L02
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M08_L02
       movsx     rcx,word ptr [rax-2]
       mov       [r10-2],cx
       jmp       short M08_L02
M08_L07:
       cmp       r8,800
       ja        short M08_L11
       cmp       r8,100
       jb        short M08_L08
       mov       r9,rcx
       and       r9,3F
       neg       r9
       add       r9,40
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rdx,r9
       add       rcx,r9
       sub       r8,r9
M08_L08:
       mov       r9,r8
       shr       r9,6
M08_L09:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M08_L09
       and       r8,3F
       cmp       r8,10
       ja        near ptr M08_L00
       jmp       near ptr M08_L01
M08_L10:
       cmp       rcx,rdx
       jne       short M08_L11
       cmp       [rdx],dl
       jmp       near ptr M08_L02
M08_L11:
       cmp       [rcx],cl
       cmp       [rdx],dl
       vzeroupper
       jmp       qword ptr [7FFE772966E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 323
```
```assembly
; System.RuntimeTypeHandle.GetRuntimeTypeFromHandleSlow(IntPtr)
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
       mov       [rbp-40],rax
       mov       [rbp-0A0],rcx
       lea       rdx,[rbp-40]
       mov       [rbp-0A8],rdx
       lea       rcx,[rbp-98]
       call      qword ptr [7FFED6CEF020]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-0A0]
       mov       rdx,[rbp-0A8]
       call      qword ptr [rax]
       lea       rcx,[rbp-98]
       call      qword ptr [7FFED6CEF028]; CORINFO_HELP_JIT_PINVOKE_END
       mov       rax,[rbp-40]
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
; Total bytes of code 124
```
```assembly
; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rdi,rdx
       mov       esi,r8d
       mov       eax,[rbx+1C]
       mov       ecx,[rbx+18]
       add       eax,ecx
       add       eax,esi
       cmp       eax,[rbx+20]
       jg        near ptr M10_L04
       cmp       eax,esi
       jl        near ptr M10_L04
       mov       rax,[rbx+8]
       mov       ebp,[rax+8]
       sub       ebp,ecx
       test      ebp,ebp
       jle       short M10_L01
       mov       rax,[rbx+8]
       test      rax,rax
       je        near ptr M10_L05
       mov       edx,[rax+8]
       cmp       edx,ecx
       jb        near ptr M10_L06
       mov       r8d,ecx
       lea       rax,[rax+r8*2+10]
       sub       edx,ecx
M10_L00:
       cmp       ebp,edx
       ja        near ptr M10_L11
       mov       r8d,ebp
       add       r8,r8
       mov       rcx,rax
       mov       rdx,rdi
       call      qword ptr [7FFE77295818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rdx,[rbx+8]
       mov       edx,[rdx+8]
       mov       [rbx+18],edx
M10_L01:
       sub       esi,ebp
       mov       edx,[rbx+1C]
       lea       ecx,[rsi+rdx]
       mov       eax,[rbx+18]
       add       ecx,eax
       cmp       ecx,[rbx+20]
       jg        near ptr M10_L07
       cmp       ecx,esi
       jl        near ptr M10_L07
       add       edx,eax
       mov       ecx,edx
       mov       eax,1F40
       cmp       ecx,1F40
       cmovg     ecx,eax
       cmp       esi,ecx
       cmovge    ecx,esi
       add       edx,ecx
       cmp       edx,ecx
       jl        near ptr M10_L08
       cmp       ecx,400
       jge       near ptr M10_L09
       movsxd    rdx,ecx
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
M10_L02:
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       ecx,[rbx+18]
       mov       [r15+18],ecx
       mov       ecx,[rbx+1C]
       mov       [r15+1C],ecx
       mov       rdx,[rbx+8]
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbx+10]
       lea       rcx,[r15+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rbx+20]
       mov       [r15+20],ecx
       lea       rcx,[rbx+10]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rbx+18]
       add       [rbx+1C],ecx
       xor       ecx,ecx
       mov       [rbx+18],ecx
       lea       rcx,[rbx+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       movsxd    r8,ebp
       lea       rdx,[rdi+r8*2]
       mov       r8,[rbx+8]
       test      r8,r8
       je        near ptr M10_L10
       lea       rcx,[r8+10]
       mov       r8d,[r8+8]
M10_L03:
       cmp       esi,r8d
       ja        near ptr M10_L11
       mov       r8d,esi
       add       r8,r8
       call      qword ptr [7FFE77295818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       [rbx+18],esi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M10_L04:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,196D5
       mov       rdx,7FFE771D4000
       call      qword ptr [7FFE775176F0]
       mov       rsi,rax
       call      qword ptr [7FFE77A67240]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE77885C50]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M10_L05:
       test      ecx,ecx
       jne       short M10_L06
       xor       eax,eax
       xor       edx,edx
       jmp       near ptr M10_L00
M10_L06:
       call      qword ptr [7FFE774370D8]
       int       3
M10_L07:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,196EB
       mov       rdx,7FFE771D4000
       call      qword ptr [7FFE775176F0]
       mov       rsi,rax
       call      qword ptr [7FFE77A67258]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE77885C50]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M10_L08:
       mov       rcx,offset MT_System.OutOfMemoryException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE77A67270]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M10_L09:
       xor       edx,edx
       call      qword ptr [7FFE7790E010]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       r14,rax
       jmp       near ptr M10_L02
M10_L10:
       xor       ecx,ecx
       xor       r8d,r8d
       jmp       near ptr M10_L03
M10_L11:
       call      qword ptr [7FFE777A7F30]
       int       3
; Total bytes of code 625
```
```assembly
; System.Text.StringBuilder.Append(System.String)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       test      rdx,rdx
       je        short M11_L02
       lea       rax,[rdx+0C]
       mov       r8d,[rdx+8]
       test      r8d,r8d
       je        short M11_L02
       mov       rcx,[rbx+8]
       mov       edx,[rbx+18]
       lea       esi,[rdx+r8]
       cmp       esi,[rcx+8]
       ja        short M11_L03
       movsxd    rdx,edx
       lea       rcx,[rcx+rdx*2+10]
       cmp       r8d,2
       jg        short M11_L00
       movzx     edx,word ptr [rax]
       mov       [rcx],dx
       cmp       r8d,2
       jne       short M11_L01
       movzx     r8d,word ptr [rax+2]
       mov       [rcx+2],r8w
       jmp       short M11_L01
M11_L00:
       mov       r8d,r8d
       add       r8,r8
       mov       rdx,rax
       call      qword ptr [7FFE77295818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M11_L01:
       mov       [rbx+18],esi
M11_L02:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M11_L03:
       mov       rcx,rbx
       mov       rdx,rax
       call      qword ptr [7FFE7743F120]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M11_L02
; Total bytes of code 123
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
; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,[rsi+18]
       mov       rcx,rdi
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FFED6D14C30]; Precode of System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       jne       short M13_L00
       cmp       qword ptr [rdi+10],0
       jne       short M13_L01
       xor       eax,eax
       mov       [rbx],rax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M13_L00:
       mov       eax,1
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M13_L01:
       mov       rcx,rsi
       mov       rdx,rbx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax]
; Total bytes of code 91
```
```assembly
; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0A8
       lea       rbp,[rsp+0E0]
       xor       eax,eax
       mov       [rbp-48],rax
       mov       r8d,ecx
       mov       ecx,10
       mov       r9d,50
       test      dl,dl
       cmovne    ecx,r9d
       mov       [rbp-3C],ecx
       xor       edx,edx
       mov       [rbp-48],rdx
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       [rbp-0B0],rcx
       mov       edx,r8d
       mov       [rbp-0A4],edx
       mov       r8d,[rbp-3C]
       mov       [rbp-0A8],r8d
       lea       r9,[rbp-48]
       mov       [rbp-0B8],r9
       lea       rcx,[rbp-0A0]
       call      qword ptr [7FFED6CEF020]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-0B0]
       mov       edx,[rbp-0A4]
       mov       r8d,[rbp-0A8]
       mov       r9,[rbp-0B8]
       call      qword ptr [rax]
       lea       rcx,[rbp-0A0]
       call      qword ptr [7FFED6CEF028]; CORINFO_HELP_JIT_PINVOKE_END
       mov       rax,[rbp-48]
       add       rsp,0A8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 193
```
```assembly
; Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rdx
       mov       rsi,[rbx+8]
       mov       eax,[rsi+8]
       mov       r8d,[rbx+1C]
       add       eax,r8d
       cmp       eax,[rcx+0C]
       jg        near ptr M15_L09
       cmp       dword ptr [rbx+20],0
       jl        near ptr M15_L10
       cmp       qword ptr [rbx+10],0
       je        near ptr M15_L07
       mov       eax,r8d
       add       eax,[rbx+18]
       mov       edi,eax
       neg       edi
       test      edi,edi
       jg        near ptr M15_L06
       mov       rdi,rbx
       test      r8d,r8d
       jle       short M15_L01
M15_L00:
       mov       rdi,[rdi+10]
       cmp       dword ptr [rdi+1C],0
       jg        short M15_L00
M15_L01:
       cmp       rdi,rbx
       je        near ptr M15_L05
       add       r8d,[rsi+8]
       lea       edx,[rax+rax*2]
       add       edx,edx
       mov       ecx,66666667
       mov       eax,ecx
       imul      edx
       mov       ecx,edx
       shr       ecx,1F
       sar       edx,1
       add       ecx,edx
       mov       edx,[rsi+8]
       cmp       ecx,edx
       cmovl     ecx,edx
       cmp       r8d,ecx
       cmovg     r8d,ecx
       mov       ecx,r8d
       sub       ecx,[rdi+1C]
       mov       rdx,[rdi+8]
       cmp       [rdx+8],ecx
       jge       short M15_L03
       cmp       ecx,400
       jge       near ptr M15_L12
       movsxd    rdx,ecx
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rsi,rax
M15_L02:
       mov       rcx,[rdi+8]
       mov       r8d,[rdi+18]
       mov       rdx,rsi
       call      qword ptr [7FFE77434FA8]; System.Array.Copy(System.Array, System.Array, Int32)
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M15_L04
M15_L03:
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
M15_L04:
       mov       rdx,[rdi+10]
       lea       rcx,[rbx+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       edx,[rdi+1C]
       mov       [rbx+1C],edx
M15_L05:
       mov       edx,[rdi+1C]
       neg       edx
       mov       [rbx+18],edx
       jmp       short M15_L08
M15_L06:
       mov       edx,[rbx+18]
       mov       ecx,edx
       mov       r8d,edi
       add       rcx,r8
       mov       r8d,[rsi+8]
       cmp       rcx,r8
       ja        near ptr M15_L11
       mov       edx,edx
       lea       rcx,[rsi+rdx*2+10]
       mov       edx,edi
       xor       r8d,r8d
       call      qword ptr [7FFE777A6EF8]; System.SpanHelpers.Fill[[System.Char, System.Private.CoreLib]](Char ByRef, UIntPtr, Char)
       add       [rbx+18],edi
       jmp       short M15_L08
M15_L07:
       xor       eax,eax
       mov       [rbx+18],rax
M15_L08:
       mov       eax,1
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M15_L09:
       xor       eax,eax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M15_L10:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FFE771D4000
       call      qword ptr [7FFE775176F0]
       mov       rsi,rax
       call      qword ptr [7FFE77A67258]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE77885C50]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M15_L11:
       mov       rcx,rbx
       mov       r8d,edi
       xor       edx,edx
       call      qword ptr [7FFE77A6C420]
       jmp       short M15_L08
M15_L12:
       xor       edx,edx
       call      qword ptr [7FFE7790E010]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       rsi,rax
       jmp       near ptr M15_L02
; Total bytes of code 438
```
```assembly
; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rcx,[rbx+10]
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFED6D14C40]; Precode of System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryEnqueue(System.__Canon)
       test      eax,eax
       je        short M16_L00
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M16_L00:
       mov       rcx,rbx
       mov       rdx,rsi
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [rax]
; Total bytes of code 60
```

## .NET 10.0.0 (10.0.25.45207), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark.ProcessGenericType()
       push      rsi
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+30],rax
       mov       rbx,rcx
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       dword ptr [rsi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,1F168000208
       mov       r8,[r9]
       mov       byte ptr [rsp+28],1
       mov       byte ptr [rsp+29],0
       mov       byte ptr [rsp+2A],1
       mov       word ptr [rsp+2C],2E
       lea       r9,[rsp+28]
       mov       [rsp+20],r9
       xor       r9d,r9d
       mov       rcx,rsi
       mov       rdx,231FD26DC18
       call      qword ptr [7FFE7798E898]; DotNetTips.Spargine.Core.TypeHelper.ProcessGenericType(System.Text.StringBuilder, System.Type, System.Type[], Int32, DotNetTips.Spargine.Core.DisplayNameOptions)
       mov       rcx,rsi
       call      qword ptr [7FFE774CF790]; System.Text.StringBuilder.ToString()
       mov       [rsp+30],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+30]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,38
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 185
```
```assembly
; DotNetTips.Spargine.Core.TypeHelper.ProcessGenericType(System.Text.StringBuilder, System.Type, System.Type[], Int32, DotNetTips.Spargine.Core.DisplayNameOptions)
; 		builder = builder.ArgumentNotNull();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		type = type.ArgumentNotNull();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		genericArguments = genericArguments.ArgumentNotNull();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var offset = 0;
; 		^^^^^^^^^^^^^^^
; 		if (type.IsNested)
; 		^^^^^^^^^^^^^^^^^^
; 			offset = type.DeclaringType!.GetGenericArguments().Length;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		if (options.FullName)
; 		^^^^^^^^^^^^^^^^^^^^^
; 			if (type.IsNested)
; 			^^^^^^^^^^^^^^^^^^
; 				ProcessGenericType(builder, type.DeclaringType!, genericArguments, offset, options);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 				_ = builder.Append(options.NestedTypeDelimiter);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			else if (!string.IsNullOrEmpty(type.Namespace))
; 			     ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 				_ = builder.Append(type.Namespace);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 				_ = builder.Append(ControlChars.Dot);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var genericPartIndex = type.Name.IndexOf('`', StringComparison.Ordinal);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		if (genericPartIndex <= 0)
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			_ = builder.Append(type.Name);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		_ = builder.Append(type.Name, 0, genericPartIndex);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		if (options.IncludeGenericParameters)
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			_ = builder.Append(ControlChars.StartAngleBracket);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			for (var typeCount = offset; typeCount < length; typeCount++)
; 			     ^^^^^^^^^^^^^^^^^^^^^^
; 				ProcessType(builder, genericArguments[typeCount], options);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 				if (typeCount + 1 == length)
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 				_ = builder.Append(ControlChars.Comma);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 				if (options.IncludeGenericParameterNames || !genericArguments[typeCount + 1].IsGenericParameter)
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 					_ = builder.Append(ControlChars.Space);
; 					^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			_ = builder.Append(ControlChars.EndAngleBracket);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M01_L00:
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       mov       [rsp+90],rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       edi,r9d
       mov       rbp,[rsp+0B0]
       mov       rcx,[rsp+90]
       test      rcx,rcx
       je        near ptr M01_L39
       mov       [rsp+90],rcx
       test      rbx,rbx
       je        near ptr M01_L40
       test      rsi,rsi
       je        near ptr M01_L41
       xor       r14d,r14d
       mov       r15,[rbx]
       mov       r13,offset MT_System.RuntimeType
       cmp       r15,r13
       jne       near ptr M01_L44
       cmp       qword ptr [rbx+10],0
       je        short M01_L01
       mov       rcx,[rbx+10]
       mov       r12,[rcx]
       test      r12,r12
       jne       short M01_L06
M01_L01:
       mov       rcx,rbx
       call      qword ptr [7FFE77287C00]; System.RuntimeType.InitializeCache()
       mov       r12,rax
M01_L02:
       cmp       qword ptr [r12+10],0
       je        near ptr M01_L42
M01_L03:
       mov       rcx,231FD261440
       cmp       [r12+10],rcx
       jne       near ptr M01_L43
       xor       eax,eax
M01_L04:
       test      rax,rax
       jne       near ptr M01_L45
M01_L05:
       cmp       byte ptr [rbp],0
       je        near ptr M01_L20
       cmp       r15,r13
       jne       near ptr M01_L48
       cmp       qword ptr [rbx+10],0
       je        short M01_L07
       mov       rcx,[rbx+10]
       mov       r12,[rcx]
       test      r12,r12
       je        short M01_L07
       jmp       short M01_L08
M01_L06:
       jmp       short M01_L02
M01_L07:
       mov       rcx,rbx
       call      qword ptr [7FFE77287C00]; System.RuntimeType.InitializeCache()
       mov       r12,rax
M01_L08:
       cmp       qword ptr [r12+10],0
       je        near ptr M01_L46
M01_L09:
       mov       rcx,231FD261440
       cmp       [r12+10],rcx
       jne       near ptr M01_L47
       xor       eax,eax
M01_L10:
       test      rax,rax
       jne       near ptr M01_L49
       cmp       r15,r13
       jne       near ptr M01_L51
       cmp       qword ptr [rbx+10],0
       je        short M01_L11
       mov       rcx,[rbx+10]
       mov       rcx,[rcx]
       test      rcx,rcx
       jne       short M01_L14
M01_L11:
       mov       rcx,rbx
       call      qword ptr [7FFE77287C00]; System.RuntimeType.InitializeCache()
M01_L12:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFE7787C648]; System.RuntimeType+RuntimeTypeCache.GetNamespace()
       test      rax,rax
       je        near ptr M01_L50
       cmp       dword ptr [rax+8],0
       je        near ptr M01_L50
M01_L13:
       test      rax,rax
       je        near ptr M01_L20
       cmp       dword ptr [rax+8],0
       je        near ptr M01_L20
       mov       r12,[rsp+90]
       cmp       r15,r13
       jne       near ptr M01_L53
       cmp       qword ptr [rbx+10],0
       je        short M01_L15
       mov       rcx,[rbx+10]
       mov       rcx,[rcx]
       test      rcx,rcx
       je        short M01_L15
       mov       rax,rcx
       jmp       short M01_L16
M01_L14:
       mov       rax,rcx
       jmp       short M01_L12
M01_L15:
       mov       rcx,rbx
       call      qword ptr [7FFE77287C00]; System.RuntimeType.InitializeCache()
M01_L16:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFE7787C648]; System.RuntimeType+RuntimeTypeCache.GetNamespace()
       test      rax,rax
       je        near ptr M01_L52
       cmp       dword ptr [rax+8],0
       je        near ptr M01_L52
M01_L17:
       cmp       [r12],r12b
       test      rax,rax
       je        short M01_L19
       lea       rdx,[rax+0C]
       mov       eax,[rax+8]
       mov       [rsp+44],eax
       test      eax,eax
       je        short M01_L19
       mov       r8,[r12+8]
       mov       r10d,[r12+18]
       mov       [rsp+40],r10d
       lea       ecx,[r10+rax]
       cmp       ecx,[r8+8]
       ja        short M01_L21
       movsxd    rcx,r10d
       lea       rcx,[r8+rcx*2+10]
       cmp       eax,2
       jle       near ptr M01_L54
       mov       r8d,eax
       add       r8,r8
       call      qword ptr [7FFE77285818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L18:
       mov       eax,[rsp+44]
       add       eax,[rsp+40]
       mov       [r12+18],eax
M01_L19:
       mov       rcx,[rsp+90]
       mov       edx,[rcx+18]
       mov       eax,edx
       mov       r8,[rcx+8]
       cmp       [r8+8],eax
       jbe       short M01_L22
       mov       eax,eax
       mov       word ptr [r8+rax*2+10],2E
       inc       edx
       mov       [rcx+18],edx
M01_L20:
       cmp       r15,r13
       jne       near ptr M01_L56
       cmp       qword ptr [rbx+10],0
       je        short M01_L23
       mov       rcx,[rbx+10]
       mov       rcx,[rcx]
       test      rcx,rcx
       je        short M01_L23
       mov       rax,rcx
       jmp       short M01_L24
M01_L21:
       mov       rcx,r12
       mov       r8d,eax
       call      qword ptr [7FFE7742F120]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M01_L19
M01_L22:
       mov       edx,2E
       call      qword ptr [7FFE7742F2E8]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M01_L20
M01_L23:
       mov       rcx,rbx
       call      qword ptr [7FFE77287C00]; System.RuntimeType.InitializeCache()
M01_L24:
       mov       r10,[rax+18]
       test      r10,r10
       je        short M01_L26
M01_L25:
       lea       rcx,[r10+0C]
       mov       r8d,[r10+8]
       mov       edx,60
       call      qword ptr [7FFE774276D8]; System.PackedSpanHelpers.IndexOf[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib],[System.PackedSpanHelpers+NopTransform, System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
       mov       r12d,eax
       test      r12d,r12d
       jle       near ptr M01_L57
       mov       rax,[rsp+90]
       mov       [rsp+30],rax
       cmp       r15,r13
       jne       near ptr M01_L58
       cmp       qword ptr [rbx+10],0
       je        short M01_L27
       mov       rcx,[rbx+10]
       mov       rcx,[rcx]
       test      rcx,rcx
       je        short M01_L27
       mov       rax,rcx
       jmp       short M01_L28
M01_L26:
       lea       rdx,[rax+18]
       mov       rcx,rax
       xor       r8d,r8d
       call      qword ptr [7FFE77424A50]; System.RuntimeType+RuntimeTypeCache.ConstructName(System.String ByRef, System.TypeNameFormatFlags)
       mov       r10,rax
       jmp       short M01_L25
M01_L27:
       mov       rcx,rbx
       call      qword ptr [7FFE77287C00]; System.RuntimeType.InitializeCache()
M01_L28:
       mov       rdx,[rax+18]
       test      rdx,rdx
       je        near ptr M01_L35
M01_L29:
       mov       rbx,[rsp+30]
       cmp       [rbx],bl
       test      rdx,rdx
       je        near ptr M01_L59
       mov       r8d,[rdx+8]
       sub       r8d,r12d
       js        near ptr M01_L60
       add       rdx,0C
       mov       r8,[rbx+8]
       mov       r15d,[rbx+18]
       lea       ecx,[r15+r12]
       cmp       ecx,[r8+8]
       ja        near ptr M01_L36
       movsxd    rcx,r15d
       lea       rcx,[r8+rcx*2+10]
       cmp       r12d,2
       jle       near ptr M01_L61
       movsxd    r8,r12d
       add       r8,r8
       call      qword ptr [7FFE77285818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L30:
       add       r12d,r15d
       mov       [rbx+18],r12d
M01_L31:
       cmp       byte ptr [rbp+2],0
       je        short M01_L34
       mov       rcx,[rsp+90]
       mov       edx,[rcx+18]
       mov       eax,edx
       mov       r8,[rcx+8]
       cmp       [r8+8],eax
       jbe       near ptr M01_L37
       cmp       eax,[r8+8]
       jae       near ptr M01_L65
       mov       eax,eax
       mov       word ptr [r8+rax*2+10],3C
       inc       edx
       mov       [rcx+18],edx
M01_L32:
       cmp       r14d,edi
       jl        near ptr M01_L62
M01_L33:
       mov       rcx,[rsp+90]
       mov       edx,[rcx+18]
       mov       eax,edx
       mov       r8,[rcx+8]
       cmp       [r8+8],eax
       jbe       short M01_L38
       cmp       eax,[r8+8]
       jae       near ptr M01_L65
       mov       eax,eax
       mov       word ptr [r8+rax*2+10],3E
       inc       edx
       mov       [rcx+18],edx
M01_L34:
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
M01_L35:
       lea       rdx,[rax+18]
       mov       rcx,rax
       xor       r8d,r8d
       call      qword ptr [7FFE77424A50]; System.RuntimeType+RuntimeTypeCache.ConstructName(System.String ByRef, System.TypeNameFormatFlags)
       mov       rdx,rax
       jmp       near ptr M01_L29
M01_L36:
       mov       rcx,rbx
       mov       r8d,r12d
       call      qword ptr [7FFE7742F120]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M01_L31
M01_L37:
       mov       edx,3C
       call      qword ptr [7FFE7742F2E8]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M01_L32
M01_L38:
       mov       edx,3E
       call      qword ptr [7FFE7742F2E8]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M01_L34
M01_L39:
       call      qword ptr [7FFE778FDD88]
       mov       ecx,268B
       mov       rdx,7FFE77625418
       call      qword ptr [7FFE775076F0]
       mov       rbx,rax
       mov       ecx,1B55
       mov       rdx,7FFE77625418
       call      qword ptr [7FFE775076F0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE77287810]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,110B
       mov       rdx,7FFE77625418
       call      qword ptr [7FFE775076F0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE77287810]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE77A47BD0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE77A46D00]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M01_L40:
       call      qword ptr [7FFE778FDD88]
       mov       ecx,20E7
       mov       rdx,7FFE77625418
       call      qword ptr [7FFE775076F0]
       mov       rbx,rax
       mov       ecx,1B55
       mov       rdx,7FFE77625418
       call      qword ptr [7FFE775076F0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE77287810]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,110B
       mov       rdx,7FFE77625418
       call      qword ptr [7FFE775076F0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE77287810]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE77A47BD0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE77A46D00]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M01_L41:
       call      qword ptr [7FFE778FDD88]
       mov       ecx,269B
       mov       rdx,7FFE77625418
       call      qword ptr [7FFE775076F0]
       mov       rbx,rax
       mov       ecx,1B55
       mov       rdx,7FFE77625418
       call      qword ptr [7FFE775076F0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE77287810]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,110B
       mov       rdx,7FFE77625418
       call      qword ptr [7FFE775076F0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE77287810]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE77A47BD0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE77A46D00]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M01_L42:
       mov       rcx,[r12+8]
       call      qword ptr [7FFE774244F8]; System.RuntimeTypeHandle.GetDeclaringType(System.RuntimeType)
       mov       rdx,rax
       mov       rcx,231FD261440
       test      rdx,rdx
       cmove     rdx,rcx
       lea       rcx,[r12+10]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L03
M01_L43:
       mov       rax,[r12+10]
       jmp       near ptr M01_L04
M01_L44:
       mov       rcx,rbx
       mov       rax,[r15+40]
       call      qword ptr [rax+38]
       jmp       near ptr M01_L04
M01_L45:
       mov       rcx,rbx
       mov       rax,[r15+40]
       call      qword ptr [rax+38]
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+68]
       call      qword ptr [rax+28]
       mov       r14d,[rax+8]
       jmp       near ptr M01_L05
M01_L46:
       mov       rcx,[r12+8]
       call      qword ptr [7FFE774244F8]; System.RuntimeTypeHandle.GetDeclaringType(System.RuntimeType)
       mov       rdx,rax
       mov       rcx,231FD261440
       test      rdx,rdx
       cmove     rdx,rcx
       lea       rcx,[r12+10]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L09
M01_L47:
       mov       rax,[r12+10]
       jmp       near ptr M01_L10
M01_L48:
       mov       rcx,rbx
       mov       rax,[r15+40]
       call      qword ptr [rax+38]
       jmp       near ptr M01_L10
M01_L49:
       mov       r12,[rsp+90]
       mov       rcx,rbx
       mov       rax,[r15+40]
       call      qword ptr [rax+38]
       mov       rdx,rax
       mov       r8d,[rbp]
       mov       [rsp+38],r8d
       mov       r8w,[rbp+4]
       mov       [rsp+3C],r8w
       lea       r8,[rsp+38]
       mov       [rsp+20],r8
       mov       r8,rsi
       mov       r9d,r14d
       mov       rcx,r12
       call      qword ptr [7FFE7798E898]
       mov       rcx,[rsp+90]
       movzx     edx,word ptr [rbp+4]
       cmp       [rcx],ecx
       call      qword ptr [7FFE7742F0C0]; System.Text.StringBuilder.Append(Char)
       jmp       near ptr M01_L20
M01_L50:
       xor       eax,eax
       jmp       near ptr M01_L13
M01_L51:
       mov       rcx,rbx
       mov       rax,[r15+50]
       call      qword ptr [rax+10]
       jmp       near ptr M01_L13
M01_L52:
       xor       eax,eax
       jmp       near ptr M01_L17
M01_L53:
       mov       rcx,rbx
       mov       rax,[r15+50]
       call      qword ptr [rax+10]
       jmp       near ptr M01_L17
M01_L54:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       eax,2
       jne       short M01_L55
       movzx     edx,word ptr [rdx+2]
       mov       [rcx+2],dx
       jmp       near ptr M01_L18
M01_L55:
       jmp       near ptr M01_L18
M01_L56:
       mov       rcx,rbx
       mov       rax,[r15+40]
       call      qword ptr [rax+30]
       mov       r10,rax
       jmp       near ptr M01_L25
M01_L57:
       mov       rsi,[rsp+90]
       mov       rcx,rbx
       mov       rax,[r15+40]
       call      qword ptr [rax+30]
       mov       rdx,rax
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFE7742F168]; System.Text.StringBuilder.Append(System.String)
       jmp       near ptr M01_L34
M01_L58:
       mov       rcx,rbx
       mov       rdx,[r15+40]
       call      qword ptr [rdx+30]
       mov       rdx,rax
       jmp       near ptr M01_L29
M01_L59:
       mov       ecx,3AD
       mov       rdx,7FFE771C4000
       call      qword ptr [7FFE775076F0]
       mov       rcx,rax
       call      qword ptr [7FFE77A45458]
       int       3
M01_L60:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,0B8F
       mov       rdx,7FFE771C4000
       call      qword ptr [7FFE775076F0]
       mov       rsi,rax
       call      qword ptr [7FFE77A459B0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE77875C50]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L61:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       r12d,2
       jne       near ptr M01_L30
       movzx     edx,word ptr [rdx+2]
       mov       [rcx+2],dx
       jmp       near ptr M01_L30
M01_L62:
       cmp       r14d,[rsi+8]
       jae       near ptr M01_L65
       mov       edx,r14d
       lea       rdx,[rsi+rdx*8+10]
       lea       rcx,[rsp+90]
       mov       r8,rbp
       call      qword ptr [7FFE7798E958]
       mov       ecx,r14d
       add       ecx,1
       jo        short M01_L66
       cmp       ecx,edi
       je        short M01_L64
       mov       rcx,[rsp+90]
       mov       edx,2C
       cmp       [rcx],ecx
       call      qword ptr [7FFE7742F0C0]; System.Text.StringBuilder.Append(Char)
       cmp       byte ptr [rbp+1],0
       jne       short M01_L63
       mov       ecx,r14d
       add       ecx,1
       jo        short M01_L66
       cmp       ecx,[rsi+8]
       jae       short M01_L65
       mov       ecx,r14d
       add       ecx,1
       jo        short M01_L66
       mov       rcx,[rsi+rcx*8+10]
       mov       rax,[rcx]
       mov       rax,[rax+58]
       call      qword ptr [rax+30]
       test      eax,eax
       jne       short M01_L64
M01_L63:
       mov       rcx,[rsp+90]
       mov       edx,20
       cmp       [rcx],ecx
       call      qword ptr [7FFE7742F0C0]; System.Text.StringBuilder.Append(Char)
M01_L64:
       add       r14d,1
       jo        short M01_L66
       cmp       r14d,edi
       jl        near ptr M01_L62
       jmp       near ptr M01_L33
M01_L65:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M01_L66:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 2235
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       edx,[rbx+1C]
       add       edx,[rbx+18]
       je        short M02_L02
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFED6EDF840
       mov       rsi,rax
M02_L00:
       mov       r8d,[rbx+18]
       test      r8d,r8d
       jle       short M02_L01
       mov       rdx,[rbx+8]
       mov       ecx,[rbx+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rsi+8]
       ja        short M02_L03
       cmp       [rdx+8],r8d
       jb        short M02_L03
       movsxd    rcx,ecx
       lea       rcx,[rsi+rcx*2+0C]
       movsxd    r8,r8d
       add       r8,r8
       add       rdx,10
       call      qword ptr [7FFE77285818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L01:
       mov       rbx,[rbx+10]
       test      rbx,rbx
       jne       short M02_L00
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L02:
       mov       rax,231FD260008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,196A5
       mov       rdx,7FFE771C4000
       call      qword ptr [7FFE775076F0]
       mov       rbx,rax
       call      qword ptr [7FFE77A459B0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE77875C50]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 201
```

