## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rsi,1E30F8C0708
       mov       rdx,rsi
       call      qword ptr [7FF80C5AD788]; System.RuntimeType+IGenericCacheEntry`1[[System.__Canon, System.Private.CoreLib]].Find(System.RuntimeType)
       mov       rcx,rax
       test      rcx,rcx
       je        near ptr M00_L03
       cmp       qword ptr [rcx+10],0
       je        near ptr M00_L03
M00_L00:
       mov       edx,[rsp+34]
       call      qword ptr [7FF80C52DD28]; System.Enum.GetNameInlined[[System.UInt32, System.Private.CoreLib]](EnumInfo`1<UInt32>, UInt32)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M00_L04
       mov       rdx,rdi
       mov       rcx,rsi
       mov       r8d,1C
       call      qword ptr [7FF80BE4A490]; System.RuntimeType.GetField(System.String, System.Reflection.BindingFlags)
       mov       rsi,rax
       test      rsi,rsi
       je        near ptr M00_L06
       mov       rdx,rsi
       mov       rcx,7FF80C57B5C8
       xor       r8d,r8d
       call      qword ptr [7FF80C417078]; System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.MemberInfo, Boolean)
       mov       rbp,rax
       test      rbp,rbp
       jne       near ptr M00_L05
M00_L01:
       mov       rdx,rsi
       mov       rcx,7FF80C57B650
       xor       r8d,r8d
       call      qword ptr [7FF80C417078]; System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.MemberInfo, Boolean)
       mov       rbp,rax
       test      rbp,rbp
       je        near ptr M00_L06
       mov       rcx,[rbp+8]
       call      qword ptr [7FF80C19F180]; System.String.IsNullOrEmpty(System.String)
       test      eax,eax
       jne       near ptr M00_L06
       mov       rsi,[rbp+8]
M00_L02:
       mov       [rsp+28],rsi
       mov       rcx,[rbx+60]
       lea       r8,[rsp+28]
       mov       rdx,7FF80C57E0C0
       cmp       [rcx],ecx
       call      qword ptr [7FF80C52DE90]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FF80C19EBE0]; System.Enum.<GetEnumInfo>g__InitializeEnumInfo|5_0[[System.UInt32, System.Private.CoreLib]](System.RuntimeType, Boolean)
       mov       rcx,rax
       jmp       near ptr M00_L00
M00_L04:
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Data.CountryName
       call      CORINFO_HELP_NEWSFAST
       mov       dword ptr [rax+8],6D
       mov       rcx,rax
       call      qword ptr [7FF80BE46098]; System.Enum.ToString()
       mov       rsi,rax
       jmp       short M00_L02
M00_L05:
       mov       rcx,rbp
       mov       rax,[rbp]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       rcx,rax
       call      qword ptr [7FF80C19F180]; System.String.IsNullOrEmpty(System.String)
       test      eax,eax
       jne       near ptr M00_L01
       mov       rcx,rbp
       mov       rax,[rbp]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       rsi,rax
       jmp       near ptr M00_L02
M00_L06:
       mov       rsi,rdi
       jmp       near ptr M00_L02
; Total bytes of code 381
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
       call      qword ptr [7FF80C0D56E0]; System.RuntimeType.InitializeCache()
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
       mov       rdx,7FF80C0BC6C0
       call      qword ptr [7FF80BF0F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF80C5AC570]
       jmp       short M02_L04
M02_L03:
       mov       rcx,rax
       mov       edx,r8d
       mov       r8d,r10d
       call      qword ptr [7FF80C5AC780]; System.SpanHelpers.NonPackedIndexOfValueType[[System.Int32, System.Private.CoreLib],[System.SpanHelpers+DontNegate`1[[System.Int32, System.Private.CoreLib]], System.Private.CoreLib]](Int32 ByRef, Int32, Int32)
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
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rdi,rcx
       mov       rsi,rdx
       mov       ebx,r8d
       test      rsi,rsi
       je        near ptr M03_L18
       test      bl,1
       jne       near ptr M03_L19
       mov       ebp,1
M03_L00:
       mov       rcx,[rdi+10]
       test      rcx,rcx
       je        near ptr M03_L20
       mov       r14,[rcx]
       test      r14,r14
       je        near ptr M03_L20
M03_L01:
       mov       edi,ebp
       mov       r15,rsi
       cmp       [r14],r14b
       lea       r13,[r14+50]
       mov       r12,[r13]
       test      r12,r12
       je        near ptr M03_L21
M03_L02:
       mov       r14,r12
       cmp       [r14],r14b
       cmp       edi,1
       jne       near ptr M03_L22
       mov       rbp,[r14+20]
       test      rbp,rbp
       je        near ptr M03_L26
       test      r15,r15
       je        near ptr M03_L23
       lea       rdx,[r15+0C]
       mov       [rsp+20],rdx
       mov       edx,15051505
       mov       ecx,15051505
       mov       r8,[rsp+20]
       mov       r9d,[r15+8]
       cmp       r9d,2
       jle       short M03_L04
M03_L03:
       add       r9d,0FFFFFFFC
       mov       eax,edx
       rol       eax,5
       add       edx,eax
       xor       edx,[r8]
       mov       eax,ecx
       rol       eax,5
       add       ecx,eax
       xor       ecx,[r8+4]
       add       r8,8
       cmp       r9d,2
       jg        short M03_L03
M03_L04:
       test      r9d,r9d
       jle       short M03_L05
       mov       r9d,ecx
       rol       r9d,5
       add       r9d,ecx
       mov       ecx,r9d
       xor       ecx,[r8]
M03_L05:
       imul      eax,ecx,5D588B65
       add       eax,edx
       xor       edx,edx
       mov       [rsp+20],rdx
M03_L06:
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
       jae       near ptr M03_L36
       mov       ecx,edi
       mov       r13,[r12+rcx*8+10]
       test      r13,r13
       je        near ptr M03_L26
M03_L07:
       cmp       r13,r15
       je        short M03_L10
       test      r15,r15
       je        near ptr M03_L25
       mov       ecx,[r13+8]
       cmp       ecx,[r15+8]
       jne       near ptr M03_L25
       lea       rcx,[r13+0C]
       lea       rdx,[r15+0C]
       mov       r8d,[r13+8]
       add       r8d,r8d
       cmp       r8,0A
       jne       short M03_L08
       mov       rax,[rcx]
       mov       rcx,[rcx+2]
       mov       r8,[rdx]
       xor       r8,rax
       xor       rcx,[rdx+2]
       or        rcx,r8
       sete      al
       movzx     eax,al
       jmp       short M03_L09
M03_L08:
       call      qword ptr [7FF80BF0C330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
M03_L09:
       test      eax,eax
       je        near ptr M03_L25
M03_L10:
       mov       rcx,[rbp+10]
       cmp       edi,[rcx+8]
       jae       near ptr M03_L36
       mov       edx,edi
       mov       rsi,[rcx+rdx*8+10]
M03_L11:
       test      rsi,rsi
       je        near ptr M03_L27
M03_L12:
       xor       edi,edi
       xor       ebx,2
       xor       ebp,ebp
       mov       r14d,[rsi+8]
       mov       r15d,10
       inc       r14d
M03_L13:
       dec       r14d
       jne       short M03_L15
       test      ebp,ebp
       jne       near ptr M03_L34
M03_L14:
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
M03_L15:
       mov       r13,[rsi+r15]
       mov       ecx,[r13+18]
       mov       eax,ebx
       and       eax,ecx
       cmp       eax,ecx
       jne       short M03_L17
       test      rdi,rdi
       jne       near ptr M03_L32
M03_L16:
       mov       rdi,r13
M03_L17:
       add       r15,8
       jmp       short M03_L13
M03_L18:
       mov       ecx,3E7
       mov       rdx,7FF80BE44000
       call      qword ptr [7FF80BF0F228]
       mov       rcx,rax
       call      qword ptr [7FF80C49E580]
       int       3
M03_L19:
       mov       rcx,1A290800068
       mov       rcx,[rcx]
       mov       rdx,rsi
       call      qword ptr [7FF80C52FB58]
       mov       rsi,rax
       mov       ebp,2
       jmp       near ptr M03_L00
M03_L20:
       mov       rcx,rdi
       call      qword ptr [7FF80C0D56E0]; System.RuntimeType.InitializeCache()
       mov       r14,rax
       jmp       near ptr M03_L01
M03_L21:
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache+MemberInfoCache<System.Reflection.RuntimeFieldInfo>
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       lea       rcx,[r12+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r13
       mov       rdx,r12
       xor       r8d,r8d
       call      00007FF86BB43270
       mov       r14,rax
       test      r14,r14
       cmove     r14,r12
       mov       r12,r14
       jmp       near ptr M03_L02
M03_L22:
       cmp       ebp,2
       je        near ptr M03_L28
       cmp       byte ptr [r12+18],0
       je        near ptr M03_L31
       jmp       near ptr M03_L30
M03_L23:
       movsx     rdx,byte ptr [0]
       mov       edx,[0]
       add       edx,edx
       movsx     rcx,byte ptr [0]
       xor       ecx,ecx
       mov       r8d,138F7B20
       mov       r9d,420BBBEF
       call      qword ptr [7FF80C32E280]; System.Marvin.ComputeHash32(Byte ByRef, UInt32, UInt32, UInt32)
       jmp       near ptr M03_L06
M03_L24:
       cmp       edi,esi
       jae       near ptr M03_L36
       mov       ecx,edi
       mov       r13,[r12+rcx*8+10]
       test      r13,r13
       je        short M03_L26
       jmp       near ptr M03_L07
M03_L25:
       inc       edi
       mov       esi,[r12+8]
       cmp       esi,edi
       jg        short M03_L24
       sub       edi,esi
       jmp       short M03_L24
M03_L26:
       xor       esi,esi
       jmp       near ptr M03_L11
M03_L27:
       mov       rcx,r14
       mov       rdx,r15
       mov       r8d,1
       mov       r9d,2
       call      qword ptr [7FF80C0D6928]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
       mov       rsi,rax
       jmp       near ptr M03_L12
M03_L28:
       lea       rcx,[r12+28]
       mov       r8,rsi
       mov       rdx,offset MT_System.Reflection.CerHashtable<System.String, System.Reflection.RuntimeFieldInfo[]>
       call      qword ptr [7FF80C0D7CF0]; System.Reflection.CerHashtable`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Item(System.__Canon)
       test      rax,rax
       jne       short M03_L29
       mov       rcx,r12
       mov       rdx,rsi
       mov       r8d,2
       mov       r9d,2
       call      qword ptr [7FF80C0D6928]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
M03_L29:
       mov       rsi,rax
       jmp       near ptr M03_L12
M03_L30:
       mov       rsi,[r12+8]
       jmp       near ptr M03_L12
M03_L31:
       mov       rcx,r12
       mov       r8d,ebp
       xor       edx,edx
       mov       r9d,2
       call      qword ptr [7FF80C0D6928]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
       mov       rsi,rax
       jmp       near ptr M03_L12
M03_L32:
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
       je        near ptr M03_L35
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF80C0D7BA0]; System.Type.get_IsInterface()
       test      eax,eax
       je        short M03_L33
       mov       rcx,r13
       mov       rax,[r13]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF80C0D7BA0]; System.Type.get_IsInterface()
       test      eax,eax
       je        short M03_L33
       mov       ebp,1
M03_L33:
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
       jne       near ptr M03_L16
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF80C0D7BA0]; System.Type.get_IsInterface()
       test      eax,eax
       je        near ptr M03_L17
       jmp       near ptr M03_L16
M03_L34:
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF80C0D7BA0]; System.Type.get_IsInterface()
       test      eax,eax
       je        near ptr M03_L14
M03_L35:
       mov       rcx,rdi
       call      qword ptr [7FF80C5A7C60]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M03_L36:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1157
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
       je        near ptr M04_L24
       mov       rcx,[rcx+18]
       mov       rdi,[rcx]
       mov       rcx,rdi
       call      System.RuntimeTypeHandle.GetRuntimeTypeFromHandle(IntPtr)
       mov       rbp,rax
       mov       rcx,[rbp+18]
       test      cl,2
       jne       near ptr M04_L25
       mov       ecx,[rcx]
       and       ecx,0F0000
       cmp       ecx,0C0000
       sete      cl
       movzx     ecx,cl
M04_L00:
       test      ecx,ecx
       jne       near ptr M04_L26
       mov       rcx,rbp
       call      00007FF86BB541D0
       test      eax,eax
       jne       near ptr M04_L27
       mov       rcx,[rbp+18]
       test      cl,2
       jne       near ptr M04_L18
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        near ptr M04_L18
       mov       rax,[rcx+20]
       add       rax,10
       mov       rax,[rax]
       test      rax,rax
       je        near ptr M04_L33
M04_L01:
       mov       rcx,rax
M04_L02:
       test      rcx,rcx
       je        near ptr M04_L35
M04_L03:
       mov       rax,1E30F8B2888
       cmp       rcx,rax
       jne       near ptr M04_L34
M04_L04:
       mov       rcx,offset MT_System.Reflection.MdFieldInfo
       cmp       [rbx],rcx
       jne       near ptr M04_L36
       mov       r14d,4
M04_L05:
       cmp       r14d,2
       je        near ptr M04_L38
       cmp       r14d,10
       je        near ptr M04_L37
       mov       rcx,offset MT_System.Reflection.MdFieldInfo
       cmp       [rbx],rcx
       jne       near ptr M04_L53
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+58],xmm0
       vmovdqu   xmmword ptr [rsp+60],xmm0
       mov       rcx,1E30F8B27E0
       cmp       rbp,rcx
       je        near ptr M04_L39
       mov       rcx,1E30F8B2888
       cmp       rbp,rcx
       sete      sil
       movzx     esi,sil
M04_L06:
       test      esi,esi
       jne       near ptr M04_L45
       mov       rcx,1A27A800308
       mov       r14,[rcx]
       mov       rdx,rbp
       cmp       qword ptr [r14+8],0
       je        near ptr M04_L12
       mov       r15,[r14+10]
       xor       r13d,r13d
       mov       r12,[r14+18]
       mov       rcx,offset MT_System.Collections.Generic.ObjectEqualityComparer<System.RuntimeType>
       cmp       [r12],rcx
       jne       near ptr M04_L42
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
       je        near ptr M04_L40
M04_L07:
       mov       rax,[rcx]
       mov       [rsp+30],rax
       mov       rcx,offset MT_System.RuntimeType
       cmp       [rax],rcx
       jne       near ptr M04_L41
       mov       rcx,rax
       call      00007FF86BB39590
       test      eax,eax
       je        near ptr M04_L19
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
       jae       near ptr M04_L55
       mov       ecx,ecx
       lea       rdx,[rdx+rcx*4+10]
       mov       r10d,[rdx]
       dec       r10d
       js        short M04_L12
M04_L10:
       mov       r14d,[r15+8]
       cmp       r10d,r14d
       jae       near ptr M04_L55
       mov       edx,r10d
       shl       rdx,4
       lea       r10,[r15+rdx+10]
       mov       [rsp+38],r10
       cmp       [r10+8],eax
       je        near ptr M04_L43
M04_L11:
       mov       r10d,[r10+0C]
       inc       r13d
       cmp       r14d,r13d
       jb        near ptr M04_L44
       test      r10d,r10d
       mov       eax,[rsp+54]
       jge       short M04_L10
M04_L12:
       mov       rsi,[rbx+10]
       cmp       [rsi],sil
       mov       rcx,rsi
       call      00007FF86BA37C30
       mov       rcx,rax
       test      rcx,rcx
       je        near ptr M04_L52
M04_L13:
       mov       edx,[rbx+1C]
       mov       r8d,[rsp+68]
       mov       r9,rbp
       call      qword ptr [7FF80C0D7840]; System.Reflection.CustomAttribute.GetCustomAttributes(System.Reflection.RuntimeModule, Int32, Int32, System.RuntimeType)
       mov       rbx,rax
       cmp       dword ptr [rsp+68],0
       jle       short M04_L14
       mov       r9d,[rbx+8]
       sub       r9d,[rsp+68]
       cmp       dword ptr [rsp+68],1
       jne       near ptr M04_L20
       movsxd    rdx,r9d
       mov       rcx,rbx
       mov       r8,[rsp+60]
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
M04_L14:
       mov       rbp,rbx
       test      rbp,rbp
       je        short M04_L15
       mov       rdx,offset MT_System.Runtime.Serialization.EnumMemberAttribute[]
       cmp       [rbp],rdx
       je        short M04_L15
       mov       rdx,rbx
       mov       rcx,offset MT_System.Attribute[]
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rbp,rax
M04_L15:
       test      rbp,rbp
       je        near ptr M04_L23
       cmp       dword ptr [rbp+8],0
       je        near ptr M04_L23
       cmp       dword ptr [rbp+8],0
       jbe       near ptr M04_L55
       mov       rcx,[rbp+10]
       cmp       dword ptr [rbp+8],1
       jne       near ptr M04_L54
       mov       rdx,rcx
M04_L16:
       mov       rax,rdx
       test      rax,rax
       je        short M04_L17
       mov       rcx,rdi
       cmp       [rax],rcx
       je        short M04_L17
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
M04_L17:
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
M04_L18:
       xor       eax,eax
       jmp       near ptr M04_L01
M04_L19:
       mov       rcx,[rsp+30]
       call      qword ptr [7FF80C0D77F8]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       jmp       near ptr M04_L08
M04_L20:
       mov       rcx,[rsp+58]
       mov       esi,[rsp+68]
       test      rcx,rcx
       je        short M04_L22
       mov       rdx,[rcx]
       cmp       rdx,[rbx]
       jne       short M04_L22
       cmp       dword ptr [rdx+4],18
       jne       short M04_L22
       test      r9d,r9d
       jl        short M04_L22
       cmp       esi,[rcx+8]
       ja        short M04_L22
       lea       r8d,[r9+rsi]
       cmp       r8d,[rbx+8]
       ja        short M04_L22
       movzx     r8d,word ptr [rdx]
       mov       eax,esi
       imul      rax,r8
       add       rcx,10
       mov       r10,rcx
       mov       ecx,r9d
       imul      rcx,r8
       lea       rcx,[rbx+rcx+10]
       test      dword ptr [rdx],1000000
       je        short M04_L21
       mov       rdx,r10
       mov       r8,rax
       call      qword ptr [7FF80BF057A0]; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M04_L14
M04_L21:
       mov       rdx,r10
       mov       r8,rax
       call      qword ptr [7FF80BF05818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M04_L14
M04_L22:
       mov       [rsp+20],esi
       xor       r8d,r8d
       mov       [rsp+28],r8d
       mov       r8,rbx
       xor       edx,edx
       call      qword ptr [7FF80C52F2A0]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M04_L14
M04_L23:
       xor       edx,edx
       jmp       near ptr M04_L16
M04_L24:
       mov       ecx,1A1
       mov       rdx,7FF80BE44000
       call      qword ptr [7FF80BF0F228]
       mov       rcx,rax
       call      qword ptr [7FF80C49E580]
       int       3
M04_L25:
       xor       ecx,ecx
       jmp       near ptr M04_L00
M04_L26:
       xor       ecx,ecx
       jmp       near ptr M04_L02
M04_L27:
       mov       rcx,rbp
       call      qword ptr [7FF80BE4A400]
       mov       r14,rax
       mov       r15,1E30F8B27E0
       xor       r13d,r13d
       jmp       short M04_L31
M04_L28:
       mov       rdx,[r14+r13*8+10]
       mov       rcx,offset MT_System.RuntimeType
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       r12,rax
       mov       rcx,r12
       cmp       [rcx],ecx
       call      qword ptr [7FF80C0D69B8]; System.RuntimeType.get_IsActualInterface()
       test      eax,eax
       jne       short M04_L30
       mov       rcx,r12
       call      00007FF86BB541D0
       test      eax,eax
       je        short M04_L29
       mov       rcx,r12
       call      qword ptr [7FF80BE4A3F8]
       mov       ecx,eax
       and       ecx,4
       and       eax,8
       or        ecx,eax
       je        short M04_L30
M04_L29:
       mov       r15,r12
M04_L30:
       inc       r13d
M04_L31:
       cmp       [r14+8],r13d
       jg        short M04_L28
       mov       rcx,1E30F8B27E0
       cmp       r15,rcx
       jne       short M04_L32
       mov       rcx,rbp
       call      qword ptr [7FF80BE4A3F8]
       mov       rcx,1E30F8B5890
       test      al,8
       cmovne    r15,rcx
M04_L32:
       mov       rcx,r15
       jmp       near ptr M04_L02
M04_L33:
       call      qword ptr [7FF80BF05C80]; System.RuntimeTypeHandle.GetRuntimeTypeFromHandleSlow(IntPtr)
       jmp       near ptr M04_L01
M04_L34:
       call      qword ptr [7FF80C0D7618]; System.RuntimeType.GetBaseType()
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M04_L03
M04_L35:
       mov       rcx,offset MT_System.Attribute
       cmp       rdi,rcx
       je        near ptr M04_L04
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF80C52FE10]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80C285020]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M04_L36:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       r14d,eax
       jmp       near ptr M04_L05
M04_L37:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Reflection.PropertyInfo
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       rcx,rax
       mov       rdx,rbp
       movzx     r8d,sil
       call      qword ptr [7FF80C41D878]; System.Attribute.InternalGetCustomAttributes(System.Reflection.PropertyInfo, System.Type, Boolean)
       mov       rbp,rax
       jmp       near ptr M04_L15
M04_L38:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Reflection.EventInfo
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       rcx,rax
       mov       rdx,rbp
       movzx     r8d,sil
       call      qword ptr [7FF80C52FE28]
       mov       rbp,rax
       jmp       near ptr M04_L15
M04_L39:
       mov       esi,1
       jmp       near ptr M04_L06
M04_L40:
       xor       eax,eax
       jmp       near ptr M04_L08
M04_L41:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
       jmp       near ptr M04_L08
M04_L42:
       mov       rcx,r12
       mov       r11,7FF80BE50AD0
       call      qword ptr [r11]
       jmp       near ptr M04_L09
M04_L43:
       mov       rdx,[r10]
       mov       rcx,r12
       mov       r8,rbp
       mov       r11,7FF80BE50AD8
       call      qword ptr [r11]
       test      eax,eax
       mov       r10,[rsp+38]
       je        near ptr M04_L11
       mov       rcx,1E30F8B2920
       cmp       rbp,rcx
       jne       short M04_L47
       jmp       short M04_L45
M04_L44:
       call      qword ptr [7FF80BF0F498]
       int       3
M04_L45:
       mov       rcx,rbx
       call      qword ptr [7FF80C5A7DE0]
       test      rax,rax
       je        short M04_L46
       lea       rcx,[rsp+58]
       mov       r8,rax
       mov       rdx,offset MT_System.RuntimeType+ListBuilder<System.Attribute>
       call      qword ptr [7FF80C0D6AD8]; System.RuntimeType+ListBuilder`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
M04_L46:
       test      esi,esi
       jne       short M04_L48
M04_L47:
       mov       rcx,1E30F8B28D0
       cmp       rbp,rcx
       jne       short M04_L50
M04_L48:
       mov       rcx,rbx
       call      qword ptr [7FF80C5A7DF8]
       test      rax,rax
       je        short M04_L49
       lea       rcx,[rsp+58]
       mov       r8,rax
       mov       rdx,offset MT_System.RuntimeType+ListBuilder<System.Attribute>
       call      qword ptr [7FF80C0D6AD8]; System.RuntimeType+ListBuilder`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
M04_L49:
       test      esi,esi
       jne       short M04_L51
M04_L50:
       mov       rcx,1E30F8B2970
       cmp       rbp,rcx
       jne       near ptr M04_L12
M04_L51:
       test      byte ptr [rbx+30],80
       je        near ptr M04_L12
       mov       rcx,offset MT_System.NonSerializedAttribute
       call      CORINFO_HELP_NEWSFAST
       mov       r8,rax
       lea       rcx,[rsp+58]
       mov       rdx,offset MT_System.RuntimeType+ListBuilder<System.Attribute>
       call      qword ptr [7FF80C0D6AD8]; System.RuntimeType+ListBuilder`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       jmp       near ptr M04_L12
M04_L52:
       mov       rcx,rsi
       call      qword ptr [7FF80C0D5728]; System.RuntimeTypeHandle.<GetModule>g__GetModuleWorker|48_0(System.RuntimeType)
       mov       rcx,rax
       jmp       near ptr M04_L13
M04_L53:
       movzx     r8d,sil
       mov       rcx,rbx
       mov       rdx,rbp
       mov       rax,[rbx]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       mov       rbx,rax
       jmp       near ptr M04_L14
M04_L54:
       call      qword ptr [7FF80C52FE40]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M04_L55:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1766
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
       mov       rax,7FF80BE44EE8
       mov       [rbp-148],rax
       lea       rax,[M07_L02]
       mov       [rbp-138],rax
       lea       rax,[rbp-158]
       mov       [rdi+8],rax
       mov       byte ptr [rdi+4],0
       mov       rax,7FF86BB15820
       call      rax
M07_L02:
       mov       byte ptr [rdi+4],1
       cmp       dword ptr [7FF86BE639A0],0
       je        short M07_L03
       call      qword ptr [7FF86BE51648]; CORINFO_HELP_STOP_FOR_GC
M07_L03:
       mov       rcx,[rbp-150]
       mov       [rdi+8],rcx
       mov       rbx,[rbp-50]
       cmp       [rbx],bl
       mov       rcx,[rbx+18]
       call      00007FF86BA366A0
       test      rax,rax
       jne       near ptr M07_L21
M07_L04:
       mov       rcx,1A27A800308
       mov       rsi,[rcx]
       cmp       qword ptr [rsi+8],0
       je        near ptr M07_L11
       mov       r14,[rsi+10]
       xor       r15d,r15d
       mov       r13,[rsi+18]
       mov       rcx,offset MT_System.Collections.Generic.ObjectEqualityComparer<System.RuntimeType>
       cmp       [r13],rcx
       jne       near ptr M07_L46
       mov       rcx,1E30F8B6D68
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
       call      00007FF86BB39590
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
       jae       near ptr M07_L59
       mov       ecx,ecx
       lea       rdx,[rdx+rcx*4+10]
       mov       eax,[rdx]
       dec       eax
       js        short M07_L11
M07_L09:
       mov       esi,[r14+8]
       cmp       eax,esi
       jae       near ptr M07_L59
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
       call      00007FF86BA37C30
       mov       rsi,rax
       test      rsi,rsi
       je        near ptr M07_L50
M07_L12:
       mov       [rbp-190],rsi
       mov       rcx,rbx
       call      00007FF86BB54900
       mov       ebx,eax
       cmp       [rsi],sil
       mov       rcx,rsi
       call      00007FF86BBA6B10
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
       mov       rax,7FF80C0FF6D0
       mov       [rbp-148],rax
       lea       rax,[M07_L13]
       mov       [rbp-138],rax
       lea       rax,[rbp-158]
       mov       [rdi+8],rax
       mov       byte ptr [rdi+4],0
       mov       rax,7FF86BB17C30
       call      rax
M07_L13:
       mov       byte ptr [rdi+4],1
       cmp       dword ptr [7FF86BE639A0],0
       je        short M07_L14
       call      qword ptr [7FF86BE51648]; CORINFO_HELP_STOP_FOR_GC
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
       jae       near ptr M07_L59
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
       call      qword ptr [7FF80BF05860]; System.RuntimeTypeHandle.GetRuntimeTypeFromHandle(IntPtr)
       test      rax,rax
       jne       short M07_L17
       jmp       near ptr M07_L04
M07_L22:
       mov       rcx,r12
       call      qword ptr [7FF80C0D77F8]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
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
       jae       near ptr M07_L59
       lea       r8,[rbp-0BC]
       mov       edx,[r8+rsi*4]
M07_L25:
       lea       r8,[rbp-0D0]
       lea       r9,[rbp-0E0]
       mov       rcx,[rbp-78]
       call      00007FF86BB55730
       test      eax,eax
       jl        near ptr M07_L51
       mov       ecx,[rbp-0D0]
       mov       rdx,1E30F8B6D68
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
       call      qword ptr [7FF80C0D7A38]; System.Reflection.CustomAttribute.FilterCustomAttributeRecord(System.Reflection.MetadataToken, System.Reflection.MetadataImport ByRef, System.Reflection.RuntimeModule, System.Reflection.MetadataToken, System.RuntimeType, Boolean, ListBuilder`1<System.Object> ByRef, System.RuntimeType ByRef, System.IRuntimeMethodInfo ByRef, Boolean ByRef)
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
       jae       near ptr M07_L59
       mov       edx,[rdx+rsi*4+10]
       jmp       near ptr M07_L25
M07_L28:
       cmp       [rax],edx
       jbe       near ptr M07_L20
       mov       r15d,ebx
       test      r14,r14
       jne       near ptr M07_L53
M07_L29:
       test      r14,r14
       jne       near ptr M07_L56
       lea       r14,[rdi+10]
       test      byte ptr [7FF80C6EE2C0],1
       je        near ptr M07_L54
M07_L30:
       mov       rcx,1A290800338
       mov       rcx,[rcx]
       mov       [rbp-178],r14
       mov       [rbp-170],r15d
       lea       rdx,[rbp-178]
       mov       r11,7FF80BE50C68
       xor       r8d,r8d
       call      qword ptr [r11]
M07_L31:
       xor       r14d,r14d
       test      ebx,ebx
       jle       short M07_L34
M07_L32:
       mov       r15d,[rdi+r14*4+10]
       lea       rdx,[rbp-120]
       mov       ecx,r15d
       call      qword ptr [7FF80C5ACA08]; System.UInt64.TryConvertFromTruncating[[System.UInt32, System.Private.CoreLib]](UInt32, UInt64 ByRef)
       test      eax,eax
       je        near ptr M07_L57
M07_L33:
       movsxd    rax,r14d
       cmp       [rbp-120],rax
       jne       near ptr M07_L58
       inc       r14d
       cmp       ebx,r14d
       jg        short M07_L32
M07_L34:
       mov       r8d,1
M07_L35:
       mov       [rsi+19],r8b
       xor       r8d,r8d
       mov       [rbp-40],r8
       mov       [rbp-48],r8
       mov       rbx,[rbp+10]
       cmp       [rbx],bl
       mov       r8,rsi
       mov       rdx,rbx
       mov       rcx,offset MT_System.RuntimeType+IGenericCacheEntry<System.Enum+EnumInfo<System.UInt32>>
       call      qword ptr [7FF80C19ED00]; System.RuntimeType+IGenericCacheEntry`1[[System.__Canon, System.Private.CoreLib]].Replace(System.RuntimeType, System.__Canon)
M07_L36:
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
       call      qword ptr [7FF80C0D56E0]; System.RuntimeType.InitializeCache()
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
       call      qword ptr [7FF80C0D5F38]; System.RuntimeType+IGenericCacheEntry`1[[System.__Canon, System.Private.CoreLib]].CreateAndCache(System.RuntimeType)
       mov       rsi,rax
M07_L42:
       jmp       near ptr M07_L36
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
       mov       rdx,1E30F8B6D68
       mov       r11,7FF80BE50C50
       call      qword ptr [r11]
       mov       r12d,eax
       jmp       near ptr M07_L08
M07_L47:
       mov       rdx,[rax]
       mov       rcx,r13
       mov       r8,1E30F8B6D68
       mov       r11,7FF80BE50C58
       call      qword ptr [r11]
       test      eax,eax
       mov       rax,[rbp-198]
       je        near ptr M07_L10
       jmp       near ptr M07_L11
M07_L48:
       call      qword ptr [7FF80BF0F498]
       int       3
M07_L49:
       mov       ebx,1
       jmp       near ptr M07_L18
M07_L50:
       mov       rcx,rbx
       call      qword ptr [7FF80C0D5728]; System.RuntimeTypeHandle.<GetModule>g__GetModuleWorker|48_0(System.RuntimeType)
       mov       rsi,rax
       jmp       near ptr M07_L12
M07_L51:
       mov       rcx,offset MT_System.BadImageFormatException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80C49E2C8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M07_L52:
       mov       ecx,1
       jmp       near ptr M07_L16
M07_L53:
       mov       ecx,[r14+8]
       sub       ecx,r15d
       jns       near ptr M07_L29
       jmp       short M07_L55
M07_L54:
       mov       rcx,offset MT_System.Collections.Generic.ArraySortHelper<System.UInt32>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M07_L30
M07_L55:
       mov       ecx,10
       call      qword ptr [7FF80C5AEA18]
       int       3
M07_L56:
       lea       r13,[rdi+10]
       add       r14,10
       mov       rcx,offset MT_System.Collections.Generic.ArraySortHelper<System.UInt32, System.String>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1A290800330
       mov       rcx,[rcx]
       mov       [rbp-178],r13
       mov       [rbp-170],r15d
       mov       [rbp-188],r14
       mov       [rbp-180],r15d
       lea       r8,[rbp-188]
       lea       rdx,[rbp-178]
       mov       r11,7FF80BE50C60
       xor       r9d,r9d
       call      qword ptr [r11]
       jmp       near ptr M07_L31
M07_L57:
       lea       rdx,[rbp-120]
       mov       ecx,r15d
       call      qword ptr [7FF80C5ACA50]
       test      eax,eax
       jne       near ptr M07_L33
       call      qword ptr [7FF80C5AF978]
       int       3
M07_L58:
       xor       r8d,r8d
       jmp       near ptr M07_L35
M07_L59:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 2055
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
       call      qword ptr [7FF80C0D61D8]; System.Object.GetType()
       mov       rsi,rax
       lea       rdi,[rbx+8]
       mov       rcx,[rbx]
       call      00007FF86BB65960
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
       lea       rdx,[7FF80C629560]
       mov       edx,[rdx+rcx*4]
       lea       rax,[M08_L00]
       add       rdx,rax
       jmp       rdx
M08_L09:
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FF80C5ACFC0]
       jmp       short M08_L06
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FF80C5ACD38]
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
       call      qword ptr [7FF80C0D56E0]; System.RuntimeType.InitializeCache()
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
       call      qword ptr [7FF80C5ACDF8]
       mov       rcx,rax
M08_L16:
       cmp       byte ptr [rcx+18],0
       jne       short M08_L24
       mov       rsi,[rcx+10]
       cmp       byte ptr [rcx+19],0
       je        short M08_L17
       cmp       [rsi+8],edi
       jbe       short M08_L22
       mov       ecx,edi
       mov       rax,[rsi+rcx*8+10]
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
       call      qword ptr [7FF80C5ACF18]
       jmp       short M08_L21
M08_L20:
       mov       rcx,rax
       mov       edx,edi
       call      qword ptr [7FF80C496F28]; System.SpanHelpers.NonPackedIndexOfValueType[[System.Byte, System.Private.CoreLib],[System.SpanHelpers+DontNegate`1[[System.Byte, System.Private.CoreLib]], System.Private.CoreLib]](Byte ByRef, Byte, Int32)
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
       call      qword ptr [7FF80C5ACD50]
M08_L25:
       test      rax,rax
       jne       short M08_L26
       mov       ecx,edi
       call      qword ptr [7FF80C0D54A0]; System.Number.UInt32ToDecStr(UInt32)
M08_L26:
       jmp       near ptr M08_L06
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FF80C5ACD08]
       jmp       near ptr M08_L06
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FF80C5ACCF0]
       jmp       near ptr M08_L06
M08_L27:
       mov       rcx,rsi
       call      qword ptr [7FF80C0D56E0]; System.RuntimeType.InitializeCache()
       jmp       near ptr M08_L01
M08_L28:
       mov       rcx,rsi
       mov       edx,1
       call      qword ptr [7FF80C19EBE0]; System.Enum.<GetEnumInfo>g__InitializeEnumInfo|5_0[[System.UInt32, System.Private.CoreLib]](System.RuntimeType, Boolean)
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
       call      qword ptr [7FF80C5AC570]
       jmp       short M08_L33
M08_L32:
       mov       rcx,rax
       mov       edx,edi
       call      qword ptr [7FF80C5AC780]; System.SpanHelpers.NonPackedIndexOfValueType[[System.Int32, System.Private.CoreLib],[System.SpanHelpers+DontNegate`1[[System.Int32, System.Private.CoreLib]], System.Private.CoreLib]](Int32 ByRef, Int32, Int32)
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
       call      qword ptr [7FF80C5ACF78]
       jmp       near ptr M08_L05
M08_L36:
       mov       ecx,edi
       call      qword ptr [7FF80C197210]; System.Number.Int32ToDecStr(Int32)
       jmp       near ptr M08_L06
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FF80C5ACCC0]
       jmp       near ptr M08_L06
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FF80C5ACCA8]
       jmp       near ptr M08_L06
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FF80C5ACC90]
       jmp       near ptr M08_L06
; Total bytes of code 761
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.EnumHelperBenchmark.GetDescription_NoCache()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Data.CountryName
       call      CORINFO_HELP_NEWSFAST
       mov       dword ptr [rax+8],6D
       mov       rcx,rax
       call      qword ptr [7FF80C51D728]; DotNetTips.Spargine.Core.BenchmarkTests.EnumHelperBenchmark.GetDescriptionNoCache(System.Enum)
       mov       [rsp+28],rax
       mov       rbx,[rbx+60]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       ret
; Total bytes of code 81
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
       je        near ptr M01_L51
       mov       rcx,rbx
       call      qword ptr [7FF80BEFC9A8]; System.Object.GetType()
       mov       rsi,rax
       mov       rcx,[rsi+18]
       test      cl,2
       jne       near ptr M01_L52
       mov       rcx,[rcx+10]
       mov       rdx,offset MT_System.Enum
       cmp       rcx,rdx
       sete      al
       movzx     eax,al
M01_L00:
       test      eax,eax
       je        near ptr M01_L53
       mov       rcx,[rsi+18]
       test      cl,2
       jne       near ptr M01_L17
       mov       rcx,[rcx+10]
       mov       rax,offset MT_System.Enum
       cmp       rcx,rax
       sete      cl
       movzx     ecx,cl
M01_L01:
       test      ecx,ecx
       je        near ptr M01_L54
M01_L02:
       mov       rcx,rbx
       call      qword ptr [7FF80C51D830]; System.Enum.ToUInt64(System.Object)
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF80C51D890]; System.Enum.GetName(System.RuntimeType, UInt64)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M01_L55
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8d,1C
       call      qword ptr [7FF80BE3A490]; System.RuntimeType.GetField(System.String, System.Reflection.BindingFlags)
       mov       rbx,rax
       test      rbx,rbx
       je        near ptr M01_L99
       mov       rsi,1874ADA0730
       mov       rcx,offset MT_System.ComponentModel.DescriptionAttribute
       mov       ecx,[rcx]
       and       ecx,0F0000
       cmp       ecx,0C0000
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M01_L56
       mov       rcx,rsi
       call      00007FF86BB541D0
       test      eax,eax
       jne       near ptr M01_L57
       mov       rcx,[7FF80C573600]
       test      rcx,rcx
       je        near ptr M01_L18
       mov       rax,[rcx+20]
       add       rax,10
       mov       rax,[rax]
       test      rax,rax
       je        near ptr M01_L63
M01_L03:
       mov       rcx,rax
M01_L04:
       test      rcx,rcx
       je        near ptr M01_L65
M01_L05:
       mov       rax,1874AD91A60
       cmp       rcx,rax
       jne       near ptr M01_L64
       mov       rbp,[rbx]
       mov       r14,offset MT_System.Reflection.MdFieldInfo
       cmp       rbp,r14
       jne       near ptr M01_L66
       mov       r15d,4
M01_L06:
       cmp       r15d,2
       je        near ptr M01_L68
       cmp       r15d,10
       je        near ptr M01_L67
       cmp       rbp,r14
       jne       near ptr M01_L74
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+90],xmm0
       vmovdqu   xmmword ptr [rsp+98],xmm0
       mov       rcx,146B5C001C8
       mov       rsi,[rcx]
       cmp       qword ptr [rsi+8],0
       je        near ptr M01_L12
       mov       r15,[rsi+10]
       xor       r13d,r13d
       mov       r12,[rsi+18]
       mov       rcx,offset MT_System.Collections.Generic.ObjectEqualityComparer<System.RuntimeType>
       cmp       [r12],rcx
       jne       near ptr M01_L71
       mov       rcx,1874ADA0730
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
       je        near ptr M01_L69
M01_L07:
       mov       rax,[rcx]
       mov       [rsp+40],rax
       mov       rcx,offset MT_System.RuntimeType
       cmp       [rax],rcx
       jne       near ptr M01_L70
       mov       rcx,rax
       call      00007FF86BB39590
       test      eax,eax
       je        near ptr M01_L19
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
       jae       near ptr M01_L100
       mov       ecx,ecx
       lea       rdx,[rdx+rcx*4+10]
       mov       r10d,[rdx]
       dec       r10d
       js        short M01_L12
M01_L10:
       mov       esi,[r15+8]
       cmp       r10d,esi
       jae       near ptr M01_L100
       mov       edx,r10d
       shl       rdx,4
       lea       r10,[r15+rdx+10]
       mov       [rsp+48],r10
       cmp       [r10+8],eax
       je        near ptr M01_L72
M01_L11:
       mov       r10d,[r10+0C]
       inc       r13d
       cmp       esi,r13d
       jb        near ptr M01_L94
       test      r10d,r10d
       mov       eax,[rsp+8C]
       jge       short M01_L10
M01_L12:
       mov       rsi,[rbx+10]
       cmp       [rsi],sil
       mov       rcx,rsi
       call      00007FF86BA37C30
       mov       rcx,rax
       test      rcx,rcx
       je        near ptr M01_L73
M01_L13:
       mov       edx,[rbx+1C]
       mov       r8d,[rsp+0A0]
       mov       r9,1874ADA0730
       call      qword ptr [7FF80BEFEEF8]; System.Reflection.CustomAttribute.GetCustomAttributes(System.Reflection.RuntimeModule, Int32, Int32, System.RuntimeType)
       mov       rsi,rax
       cmp       dword ptr [rsp+0A0],0
       jle       short M01_L14
       mov       r9d,[rsi+8]
       sub       r9d,[rsp+0A0]
       cmp       dword ptr [rsp+0A0],1
       jne       short M01_L20
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
       je        short M01_L16
       mov       ecx,[r15+8]
       test      ecx,ecx
       jne       near ptr M01_L23
M01_L16:
       xor       edx,edx
       jmp       near ptr M01_L24
M01_L17:
       xor       ecx,ecx
       jmp       near ptr M01_L01
M01_L18:
       xor       eax,eax
       jmp       near ptr M01_L03
M01_L19:
       mov       rcx,[rsp+40]
       call      qword ptr [7FF80BEFEEB0]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       jmp       near ptr M01_L08
M01_L20:
       mov       rcx,[rsp+90]
       mov       r15d,[rsp+0A0]
       test      rcx,rcx
       je        short M01_L22
       mov       rdx,[rcx]
       cmp       rdx,[rsi]
       jne       short M01_L22
       cmp       dword ptr [rdx+4],18
       jne       short M01_L22
       test      r9d,r9d
       jl        short M01_L22
       cmp       r15d,[rcx+8]
       ja        short M01_L22
       lea       r8d,[r9+r15]
       cmp       r8d,[rsi+8]
       ja        short M01_L22
       movzx     r8d,word ptr [rdx]
       mov       eax,r15d
       imul      rax,r8
       add       rcx,10
       mov       r10,rcx
       mov       ecx,r9d
       imul      rcx,r8
       lea       rcx,[rsi+rcx+10]
       test      dword ptr [rdx],1000000
       je        short M01_L21
       mov       rdx,r10
       mov       r8,rax
       call      qword ptr [7FF80BEF57A0]; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L14
M01_L21:
       mov       rdx,r10
       mov       r8,rax
       call      qword ptr [7FF80BEF5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L14
M01_L22:
       mov       [rsp+20],r15d
       xor       r8d,r8d
       mov       [rsp+28],r8d
       mov       r8,rsi
       xor       edx,edx
       call      qword ptr [7FF80C51F2E8]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M01_L14
M01_L23:
       test      ecx,ecx
       je        near ptr M01_L100
       mov       rax,[r15+10]
       mov       rdx,rax
       cmp       ecx,1
       jne       near ptr M01_L75
M01_L24:
       mov       rsi,rdx
       test      rsi,rsi
       je        short M01_L25
       mov       rcx,offset MT_System.ComponentModel.DescriptionAttribute
       cmp       [rsi],rcx
       je        short M01_L25
       call      qword ptr [7FF80BEFFD08]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       mov       rsi,rax
M01_L25:
       test      rsi,rsi
       jne       near ptr M01_L76
M01_L26:
       mov       rsi,1874ADA0758
       mov       rcx,offset MT_System.Runtime.Serialization.EnumMemberAttribute
       mov       ecx,[rcx]
       and       ecx,0F0000
       cmp       ecx,0C0000
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M01_L77
       mov       rcx,rsi
       call      00007FF86BB541D0
       test      eax,eax
       jne       near ptr M01_L78
       mov       rcx,[7FF80C5737C0]
       test      rcx,rcx
       je        near ptr M01_L42
       mov       rax,[rcx+20]
       add       rax,10
       mov       rax,[rax]
       test      rax,rax
       je        near ptr M01_L84
M01_L27:
       mov       rcx,rax
M01_L28:
       test      rcx,rcx
       je        near ptr M01_L86
M01_L29:
       mov       rax,1874AD91A60
       cmp       rcx,rax
       jne       near ptr M01_L85
       cmp       rbp,r14
       jne       near ptr M01_L87
       mov       r15d,4
M01_L30:
       cmp       r15d,2
       je        near ptr M01_L89
       cmp       r15d,10
       je        near ptr M01_L88
       cmp       rbp,r14
       jne       near ptr M01_L96
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+60],xmm0
       vmovdqu   xmmword ptr [rsp+68],xmm0
       mov       rcx,146B5C001C8
       mov       rsi,[rcx]
       cmp       qword ptr [rsi+8],0
       je        near ptr M01_L37
       mov       rbp,[rsi+10]
       xor       r14d,r14d
       mov       r15,[rsi+18]
       mov       rcx,offset MT_System.Collections.Generic.ObjectEqualityComparer<System.RuntimeType>
       cmp       [r15],rcx
       jne       near ptr M01_L92
       mov       rcx,1874ADA0758
       mov       [rsp+58],rcx
       xor       ecx,ecx
       mov       [rsp+50],rcx
       lea       rcx,[rsp+58]
       cmp       qword ptr [rsp+50],0
       jne       short M01_L31
       mov       rcx,[rsp+58]
       mov       [rsp+50],rcx
       lea       rcx,[rsp+50]
       cmp       qword ptr [rsp+50],0
       je        near ptr M01_L90
M01_L31:
       mov       r13,[rcx]
       mov       rcx,offset MT_System.RuntimeType
       cmp       [r13],rcx
       jne       near ptr M01_L91
       mov       rcx,r13
       call      00007FF86BB39590
       test      eax,eax
       je        near ptr M01_L43
M01_L32:
       mov       r13d,eax
M01_L33:
       xor       ecx,ecx
       mov       [rsp+50],rcx
M01_L34:
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
       jae       near ptr M01_L100
       mov       ecx,ecx
       lea       rdx,[rdx+rcx*4+10]
       mov       eax,[rdx]
       dec       eax
       js        short M01_L37
M01_L35:
       mov       esi,[rbp+8]
       cmp       eax,esi
       jae       near ptr M01_L100
       mov       edx,eax
       shl       rdx,4
       lea       r12,[rbp+rdx+10]
       cmp       [r12+8],r13d
       je        near ptr M01_L93
M01_L36:
       mov       eax,[r12+0C]
       inc       r14d
       cmp       esi,r14d
       jb        near ptr M01_L94
       test      eax,eax
       jge       short M01_L35
M01_L37:
       mov       rsi,[rbx+10]
       cmp       [rsi],sil
       mov       rcx,rsi
       call      00007FF86BA37C30
       mov       rcx,rax
       test      rcx,rcx
       je        near ptr M01_L95
M01_L38:
       mov       edx,[rbx+1C]
       mov       r8d,[rsp+70]
       mov       r9,1874ADA0758
       call      qword ptr [7FF80BEFEEF8]; System.Reflection.CustomAttribute.GetCustomAttributes(System.Reflection.RuntimeModule, Int32, Int32, System.RuntimeType)
       mov       rbx,rax
       cmp       dword ptr [rsp+70],0
       jle       short M01_L39
       mov       r9d,[rbx+8]
       sub       r9d,[rsp+70]
       cmp       dword ptr [rsp+70],1
       jne       short M01_L44
       movsxd    rdx,r9d
       mov       rcx,rbx
       mov       r8,[rsp+68]
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
M01_L39:
       mov       rbp,rbx
       test      rbp,rbp
       je        short M01_L40
       mov       rdx,offset MT_System.ComponentModel.DescriptionAttribute[]
       cmp       [rbp],rdx
       je        short M01_L40
       mov       rdx,rbx
       mov       rcx,offset MT_System.Attribute[]
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rbp,rax
M01_L40:
       test      rbp,rbp
       je        short M01_L41
       mov       ecx,[rbp+8]
       test      ecx,ecx
       jne       near ptr M01_L47
M01_L41:
       xor       edx,edx
       jmp       near ptr M01_L48
M01_L42:
       xor       eax,eax
       jmp       near ptr M01_L27
M01_L43:
       mov       rcx,r13
       call      qword ptr [7FF80BEFEEB0]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       jmp       near ptr M01_L32
M01_L44:
       mov       rcx,[rsp+60]
       mov       esi,[rsp+70]
       test      rcx,rcx
       je        short M01_L46
       mov       rdx,[rcx]
       cmp       rdx,[rbx]
       jne       short M01_L46
       cmp       dword ptr [rdx+4],18
       jne       short M01_L46
       test      r9d,r9d
       jl        short M01_L46
       cmp       esi,[rcx+8]
       ja        short M01_L46
       lea       r8d,[r9+rsi]
       cmp       r8d,[rbx+8]
       ja        short M01_L46
       movzx     r8d,word ptr [rdx]
       mov       eax,esi
       imul      rax,r8
       add       rcx,10
       mov       r10,rcx
       mov       ecx,r9d
       imul      rcx,r8
       lea       rcx,[rbx+rcx+10]
       test      dword ptr [rdx],1000000
       je        short M01_L45
       mov       rdx,r10
       mov       r8,rax
       call      qword ptr [7FF80BEF57A0]; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L39
M01_L45:
       mov       rdx,r10
       mov       r8,rax
       call      qword ptr [7FF80BEF5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L39
M01_L46:
       mov       [rsp+20],esi
       xor       r8d,r8d
       mov       [rsp+28],r8d
       mov       r8,rbx
       xor       edx,edx
       call      qword ptr [7FF80C51F2E8]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M01_L39
M01_L47:
       test      ecx,ecx
       je        near ptr M01_L100
       mov       rax,[rbp+10]
       mov       rdx,rax
       cmp       ecx,1
       jne       near ptr M01_L97
M01_L48:
       mov       rcx,rdx
       test      rcx,rcx
       je        short M01_L49
       mov       rax,offset MT_System.Runtime.Serialization.EnumMemberAttribute
       cmp       [rcx],rax
       jne       near ptr M01_L98
M01_L49:
       test      rcx,rcx
       je        near ptr M01_L99
       mov       rax,[rcx+8]
       mov       rdx,rax
       test      rdx,rdx
       je        near ptr M01_L99
       cmp       dword ptr [rdx+8],0
       je        near ptr M01_L99
M01_L50:
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
M01_L51:
       call      qword ptr [7FF80C47EAF0]
       mov       ecx,7
       mov       rdx,7FF80C1C3A48
       call      qword ptr [7FF80C1177B0]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF80C1C5548
       call      qword ptr [7FF80C1177B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80BEF7840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,5
       mov       rdx,7FF80C1C3A48
       call      qword ptr [7FF80C1177B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80BEF7840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF80C5B7EA0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF80C5B4960]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M01_L52:
       mov       rcx,rsi
       mov       rdx,1874AD95F30
       call      qword ptr [7FF80BE3A608]; System.RuntimeType.IsSubclassOf(System.Type)
       jmp       near ptr M01_L00
M01_L53:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,13
       mov       rdx,7FF80C1C3A48
       call      qword ptr [7FF80C1177B0]
       mov       rsi,rax
       mov       ecx,7
       mov       rdx,7FF80C1C3A48
       call      qword ptr [7FF80C1177B0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF80C276130]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L54:
       mov       rcx,rsi
       call      qword ptr [7FF80C5B5EF0]; System.Type.IsIntegerType(System.Type)
       test      eax,eax
       jne       near ptr M01_L02
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF80C5B5F08]
       mov       rsi,rax
       mov       ecx,3AD
       mov       rdx,7FF80BE34000
       call      qword ptr [7FF80C1177B0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF80C276130]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L55:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       jmp       near ptr M01_L50
M01_L56:
       xor       ecx,ecx
       jmp       near ptr M01_L04
M01_L57:
       mov       rcx,rsi
       call      qword ptr [7FF80BE3A400]
       mov       rbp,rax
       mov       r14,1874AD919B8
       xor       r15d,r15d
       jmp       short M01_L61
M01_L58:
       mov       rdx,[rbp+r15*8+10]
       mov       rcx,offset MT_System.RuntimeType
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       r13,rax
       mov       rcx,r13
       cmp       [rcx],ecx
       call      qword ptr [7FF80BEFD398]; System.RuntimeType.get_IsActualInterface()
       test      eax,eax
       jne       short M01_L60
       mov       rcx,r13
       call      00007FF86BB541D0
       test      eax,eax
       je        short M01_L59
       mov       rcx,r13
       call      qword ptr [7FF80BE3A3F8]
       mov       ecx,eax
       and       ecx,4
       and       eax,8
       or        ecx,eax
       je        short M01_L60
M01_L59:
       mov       r14,r13
M01_L60:
       inc       r15d
M01_L61:
       cmp       [rbp+8],r15d
       jg        short M01_L58
       mov       rcx,1874AD919B8
       cmp       r14,rcx
       jne       short M01_L62
       mov       rcx,rsi
       call      qword ptr [7FF80BE3A3F8]
       mov       rcx,1874AD94B90
       test      al,8
       cmovne    r14,rcx
M01_L62:
       mov       rcx,r14
       jmp       near ptr M01_L04
M01_L63:
       call      qword ptr [7FF80BEF5C80]; System.RuntimeTypeHandle.GetRuntimeTypeFromHandleSlow(IntPtr)
       jmp       near ptr M01_L03
M01_L64:
       call      qword ptr [7FF80BEFE040]; System.RuntimeType.GetBaseType()
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M01_L05
M01_L65:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF80C5B4E28]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80C274240]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L66:
       mov       rcx,rbx
       mov       rax,[rbp+40]
       call      qword ptr [rax+28]
       mov       r15d,eax
       jmp       near ptr M01_L06
M01_L67:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Reflection.PropertyInfo
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       rcx,rbx
       mov       rdx,rsi
       xor       r8d,r8d
       call      qword ptr [7FF80C40CA98]; System.Attribute.InternalGetCustomAttributes(System.Reflection.PropertyInfo, System.Type, Boolean)
       mov       r15,rax
       jmp       near ptr M01_L15
M01_L68:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Reflection.EventInfo
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       rcx,rbx
       mov       rdx,rsi
       xor       r8d,r8d
       call      qword ptr [7FF80C5B4E40]
       mov       r15,rax
       jmp       near ptr M01_L15
M01_L69:
       xor       eax,eax
       jmp       near ptr M01_L08
M01_L70:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
       jmp       near ptr M01_L08
M01_L71:
       mov       rcx,r12
       mov       rdx,1874ADA0730
       mov       r11,7FF80BE40AD0
       call      qword ptr [r11]
       jmp       near ptr M01_L09
M01_L72:
       mov       rdx,[r10]
       mov       rcx,r12
       mov       r8,1874ADA0730
       mov       r11,7FF80BE40AD8
       call      qword ptr [r11]
       test      eax,eax
       mov       r10,[rsp+48]
       je        near ptr M01_L11
       jmp       near ptr M01_L12
M01_L73:
       mov       rcx,rsi
       call      qword ptr [7FF80BEF7C78]; System.RuntimeTypeHandle.<GetModule>g__GetModuleWorker|48_0(System.RuntimeType)
       mov       rcx,rax
       jmp       near ptr M01_L13
M01_L74:
       mov       rcx,rbx
       mov       rdx,rsi
       xor       r8d,r8d
       mov       rax,[rbp+48]
       call      qword ptr [rax+28]
       mov       rsi,rax
       jmp       near ptr M01_L14
M01_L75:
       mov       rcx,rdx
       call      qword ptr [7FF80C5B4DC8]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M01_L76:
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       test      rax,rax
       je        near ptr M01_L26
       cmp       dword ptr [rax+8],0
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M01_L26
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       jmp       near ptr M01_L50
M01_L77:
       xor       ecx,ecx
       jmp       near ptr M01_L28
M01_L78:
       mov       rcx,rsi
       call      qword ptr [7FF80BE3A400]
       mov       r15,rax
       mov       r13,1874AD919B8
       xor       r12d,r12d
       jmp       short M01_L82
M01_L79:
       cmp       r12d,[r15+8]
       jae       near ptr M01_L100
       mov       rdx,[r15+r12*8+10]
       mov       rcx,offset MT_System.RuntimeType
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       [rsp+38],rax
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF80BEFD398]; System.RuntimeType.get_IsActualInterface()
       test      eax,eax
       jne       short M01_L81
       mov       rcx,[rsp+38]
       call      00007FF86BB541D0
       test      eax,eax
       je        short M01_L80
       mov       rcx,[rsp+38]
       call      qword ptr [7FF80BE3A3F8]
       mov       ecx,eax
       and       ecx,4
       and       eax,8
       or        ecx,eax
       je        short M01_L81
M01_L80:
       mov       r13,[rsp+38]
M01_L81:
       inc       r12d
M01_L82:
       cmp       [r15+8],r12d
       jg        short M01_L79
       mov       rcx,1874AD919B8
       cmp       r13,rcx
       jne       short M01_L83
       mov       rcx,rsi
       call      qword ptr [7FF80BE3A3F8]
       mov       rcx,1874AD94B90
       test      al,8
       cmovne    r13,rcx
M01_L83:
       mov       rcx,r13
       jmp       near ptr M01_L28
M01_L84:
       call      qword ptr [7FF80BEF5C80]; System.RuntimeTypeHandle.GetRuntimeTypeFromHandleSlow(IntPtr)
       jmp       near ptr M01_L27
M01_L85:
       call      qword ptr [7FF80BEFE040]; System.RuntimeType.GetBaseType()
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M01_L29
M01_L86:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF80C5B4E28]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF80C274240]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M01_L87:
       mov       rcx,rbx
       mov       rax,[rbp+40]
       call      qword ptr [rax+28]
       mov       r15d,eax
       jmp       near ptr M01_L30
M01_L88:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Reflection.PropertyInfo
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       rcx,rax
       mov       rdx,rsi
       xor       r8d,r8d
       call      qword ptr [7FF80C40CA98]; System.Attribute.InternalGetCustomAttributes(System.Reflection.PropertyInfo, System.Type, Boolean)
       mov       rbp,rax
       jmp       near ptr M01_L40
M01_L89:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Reflection.EventInfo
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       rcx,rax
       mov       rdx,rsi
       xor       r8d,r8d
       call      qword ptr [7FF80C5B4E40]
       mov       rbp,rax
       jmp       near ptr M01_L40
M01_L90:
       xor       r13d,r13d
       jmp       near ptr M01_L33
M01_L91:
       mov       rcx,r13
       mov       rax,[r13]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
       mov       r13d,eax
       jmp       near ptr M01_L33
M01_L92:
       mov       rcx,r15
       mov       rdx,1874ADA0758
       mov       r11,7FF80BE40AE0
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       near ptr M01_L34
M01_L93:
       mov       rdx,[r12]
       mov       rcx,r15
       mov       r8,1874ADA0758
       mov       r11,7FF80BE40AE8
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M01_L36
       jmp       near ptr M01_L37
M01_L94:
       call      qword ptr [7FF80C117A20]
       int       3
M01_L95:
       mov       rcx,rsi
       call      qword ptr [7FF80BEF7C78]; System.RuntimeTypeHandle.<GetModule>g__GetModuleWorker|48_0(System.RuntimeType)
       mov       rcx,rax
       jmp       near ptr M01_L38
M01_L96:
       mov       rcx,rbx
       mov       rdx,rsi
       xor       r8d,r8d
       mov       rax,[rbp+48]
       call      qword ptr [rax+28]
       mov       rbx,rax
       jmp       near ptr M01_L39
M01_L97:
       mov       rcx,rdx
       call      qword ptr [7FF80C5B4DC8]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M01_L98:
       mov       rcx,rax
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M01_L99:
       mov       rax,rdi
       jmp       near ptr M01_L50
M01_L100:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 3556
```

