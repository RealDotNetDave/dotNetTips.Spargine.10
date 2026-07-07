## .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rsi,1AAF4770708
       mov       rdx,rsi
       call      qword ptr [7FF91C9ED7A0]; System.RuntimeType+IGenericCacheEntry`1[[System.__Canon, System.Private.CoreLib]].Find(System.RuntimeType)
       mov       rcx,rax
       test      rcx,rcx
       je        near ptr M00_L03
       cmp       qword ptr [rcx+10],0
       je        near ptr M00_L03
M00_L00:
       mov       edx,[rsp+34]
       call      qword ptr [7FF91C96D980]; System.Enum.GetNameInlined[[System.UInt32, System.Private.CoreLib]](EnumInfo`1<UInt32>, UInt32)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M00_L04
       mov       rdx,rdi
       mov       rcx,rsi
       mov       r8d,1C
       call      qword ptr [7FF91C28A490]; System.RuntimeType.GetField(System.String, System.Reflection.BindingFlags)
       mov       rsi,rax
       test      rsi,rsi
       je        near ptr M00_L05
       mov       rdx,rsi
       mov       rcx,7FF91C9B9A70
       xor       r8d,r8d
       call      qword ptr [7FF91C867F30]; System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.MemberInfo, Boolean)
       mov       rbp,rax
       test      rbp,rbp
       jne       near ptr M00_L06
M00_L01:
       mov       rdx,rsi
       mov       rcx,7FF91C9B9AF8
       xor       r8d,r8d
       call      qword ptr [7FF91C867F30]; System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.MemberInfo, Boolean)
       mov       rbp,rax
       test      rbp,rbp
       je        short M00_L05
       mov       rcx,[rbp+8]
       call      qword ptr [7FF91C56E370]; System.String.IsNullOrEmpty(System.String)
       test      eax,eax
       jne       short M00_L05
       mov       rsi,[rbp+8]
M00_L02:
       mov       [rsp+28],rsi
       mov       rcx,[rbx+60]
       lea       r8,[rsp+28]
       mov       rdx,7FF91C9BC568
       cmp       [rcx],ecx
       call      qword ptr [7FF91C96DAE8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FF91C56DDD0]; System.Enum.<GetEnumInfo>g__InitializeEnumInfo|5_0[[System.UInt32, System.Private.CoreLib]](System.RuntimeType, Boolean)
       mov       rcx,rax
       jmp       near ptr M00_L00
M00_L04:
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Data.CountryName
       call      CORINFO_HELP_NEWSFAST
       mov       dword ptr [rax+8],6D
       mov       rcx,rax
       call      qword ptr [7FF91C286098]; System.Enum.ToString()
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
       call      qword ptr [7FF91C56E370]; System.String.IsNullOrEmpty(System.String)
       test      eax,eax
       jne       near ptr M00_L01
       mov       rcx,rbp
       mov       rax,[rbp]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       rsi,rax
       jmp       near ptr M00_L02
; Total bytes of code 370
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
       call      qword ptr [7FF91C347C30]; System.RuntimeType.InitializeCache()
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
       mov       rdx,7FF91C470C98
       call      qword ptr [7FF91C34C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FF91C9EC3C0]
       jmp       short M02_L04
M02_L03:
       mov       rcx,rax
       mov       edx,r8d
       mov       r8d,r10d
       call      qword ptr [7FF91C9EC5D0]; System.SpanHelpers.NonPackedIndexOfValueType[[System.Int32, System.Private.CoreLib],[System.SpanHelpers+DontNegate`1[[System.Int32, System.Private.CoreLib]], System.Private.CoreLib]](Int32 ByRef, Int32, Int32)
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
       mov       rsi,rcx
       mov       rdi,rdx
       mov       ebx,r8d
       test      rdi,rdi
       je        near ptr M03_L18
       test      bl,1
       jne       near ptr M03_L19
       mov       ebp,1
M03_L00:
       cmp       qword ptr [rsi+10],0
       je        short M03_L01
       mov       rcx,[rsi+10]
       mov       r14,[rcx]
       test      r14,r14
       jne       short M03_L04
M03_L01:
       mov       rcx,rsi
       call      qword ptr [7FF91C347C30]; System.RuntimeType.InitializeCache()
       mov       rsi,rax
M03_L02:
       mov       r14d,ebp
       mov       r15,rdi
       cmp       [rsi],sil
       lea       r13,[rsi+50]
       mov       r12,[r13]
       test      r12,r12
       je        near ptr M03_L20
M03_L03:
       mov       rsi,r12
       cmp       [rsi],sil
       cmp       r14d,1
       jne       near ptr M03_L21
       mov       rbp,[rsi+20]
       test      rbp,rbp
       je        near ptr M03_L24
       test      r15,r15
       jne       short M03_L05
       movsx     rdx,byte ptr [0]
       mov       edx,[0]
       add       edx,edx
       movsx     rcx,byte ptr [0]
       xor       ecx,ecx
       mov       r8d,84082F06
       mov       r9d,1824C5F6
       call      qword ptr [7FF91C75F138]; System.Marvin.ComputeHash32(Byte ByRef, UInt32, UInt32, UInt32)
       jmp       short M03_L06
M03_L04:
       mov       rsi,r14
       jmp       short M03_L02
M03_L05:
       mov       rcx,r15
       call      qword ptr [7FF91C3466D0]; System.String.GetNonRandomizedHashCode()
M03_L06:
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
       jae       near ptr M03_L34
       mov       ecx,r14d
       mov       rcx,[r12+rcx*8+10]
       test      rcx,rcx
       je        near ptr M03_L24
M03_L07:
       cmp       rcx,r15
       je        short M03_L10
       test      r15,r15
       je        near ptr M03_L23
       mov       edx,[rcx+8]
       cmp       edx,[r15+8]
       jne       near ptr M03_L23
       add       rcx,0C
       lea       rax,[r15+0C]
       add       edx,edx
       mov       r8d,edx
       cmp       r8,0A
       je        short M03_L08
       mov       rdx,rax
       call      qword ptr [7FF91C34FBB8]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M03_L09
M03_L08:
       mov       rdx,[rcx]
       mov       rcx,[rcx+2]
       mov       r8,[rax]
       xor       rdx,r8
       xor       rcx,[rax+2]
       or        rcx,rdx
       sete      al
       movzx     eax,al
M03_L09:
       test      eax,eax
       je        near ptr M03_L23
M03_L10:
       mov       rcx,[rbp+10]
       cmp       r14d,[rcx+8]
       jae       near ptr M03_L34
       mov       edx,r14d
       mov       rdi,[rcx+rdx*8+10]
M03_L11:
       test      rdi,rdi
       je        near ptr M03_L25
M03_L12:
       xor       esi,esi
       xor       ebx,2
       xor       ebp,ebp
       mov       r14d,[rdi+8]
       mov       r15d,10
       inc       r14d
M03_L13:
       dec       r14d
       jne       short M03_L15
       test      ebp,ebp
       jne       near ptr M03_L32
M03_L14:
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
M03_L15:
       mov       r13,[rdi+r15]
       mov       ecx,[r13+18]
       mov       eax,ebx
       and       eax,ecx
       cmp       eax,ecx
       jne       short M03_L17
       test      rsi,rsi
       jne       near ptr M03_L30
M03_L16:
       mov       rsi,r13
M03_L17:
       add       r15,8
       jmp       short M03_L13
M03_L18:
       mov       ecx,3E7
       mov       rdx,7FF91C284000
       call      qword ptr [7FF91C5677B0]
       mov       rcx,rax
       call      qword ptr [7FF91C8CE550]
       int       3
M03_L19:
       mov       rcx,16A5F802050
       mov       rcx,[rcx]
       mov       rdx,rdi
       call      qword ptr [7FF91C96F2A0]
       mov       rdi,rax
       mov       ebp,2
       jmp       near ptr M03_L00
M03_L20:
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache+MemberInfoCache<System.Reflection.RuntimeFieldInfo>
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       lea       rcx,[r12+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r13
       mov       rdx,r12
       xor       r8d,r8d
       call      00007FF97BF99BA0
       mov       rsi,rax
       test      rsi,rsi
       cmove     rsi,r12
       mov       r12,rsi
       jmp       near ptr M03_L03
M03_L21:
       cmp       ebp,2
       je        short M03_L26
       cmp       byte ptr [r12+18],0
       je        near ptr M03_L29
       jmp       near ptr M03_L28
M03_L22:
       cmp       r14d,edi
       jae       near ptr M03_L34
       mov       ecx,r14d
       mov       rcx,[r12+rcx*8+10]
       test      rcx,rcx
       je        short M03_L24
       jmp       near ptr M03_L07
M03_L23:
       inc       r14d
       mov       edi,[r12+8]
       cmp       edi,r14d
       jg        short M03_L22
       sub       r14d,edi
       jmp       short M03_L22
M03_L24:
       xor       edi,edi
       jmp       near ptr M03_L11
M03_L25:
       mov       rcx,rsi
       mov       rdx,r15
       mov       r8d,1
       mov       r9d,2
       call      qword ptr [7FF91C34D2C0]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
       mov       rdi,rax
       jmp       near ptr M03_L12
M03_L26:
       lea       rcx,[r12+28]
       mov       r8,rdi
       mov       rdx,offset MT_System.Reflection.CerHashtable<System.String, System.Reflection.RuntimeFieldInfo[]>
       call      qword ptr [7FF91C34F408]; System.Reflection.CerHashtable`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Item(System.__Canon)
       test      rax,rax
       jne       short M03_L27
       mov       rcx,r12
       mov       rdx,rdi
       mov       r8d,2
       mov       r9d,2
       call      qword ptr [7FF91C34D2C0]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
M03_L27:
       mov       rdi,rax
       jmp       near ptr M03_L12
M03_L28:
       mov       rdi,[r12+8]
       jmp       near ptr M03_L12
M03_L29:
       mov       rcx,r12
       mov       r8d,ebp
       xor       edx,edx
       mov       r9d,2
       call      qword ptr [7FF91C34D2C0]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
       mov       rdi,rax
       jmp       near ptr M03_L12
M03_L30:
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
       je        near ptr M03_L33
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF91C34F2B8]; System.Type.get_IsInterface()
       test      eax,eax
       je        short M03_L31
       mov       rcx,r13
       mov       rax,[r13]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF91C34F2B8]; System.Type.get_IsInterface()
       test      eax,eax
       je        short M03_L31
       mov       ebp,1
M03_L31:
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
       jne       near ptr M03_L16
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF91C34F2B8]; System.Type.get_IsInterface()
       test      eax,eax
       je        near ptr M03_L17
       jmp       near ptr M03_L16
M03_L32:
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF91C34F2B8]; System.Type.get_IsInterface()
       test      eax,eax
       je        near ptr M03_L14
M03_L33:
       mov       rcx,rsi
       call      qword ptr [7FF91C9E7D20]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M03_L34:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1049
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
       call      00007FF97BFAAB00
       test      eax,eax
       jne       near ptr M04_L27
       mov       rcx,[rbp+18]
       test      cl,2
       jne       near ptr M04_L33
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        near ptr M04_L33
       mov       rax,[rcx+20]
       add       rax,10
       mov       rax,[rax]
       test      rax,rax
       je        near ptr M04_L34
M04_L01:
       mov       rcx,rax
M04_L02:
       test      rcx,rcx
       je        near ptr M04_L36
M04_L03:
       mov       rax,1AAF4761A60
       cmp       rcx,rax
       jne       near ptr M04_L35
M04_L04:
       mov       rcx,offset MT_System.Reflection.MdFieldInfo
       cmp       [rbx],rcx
       jne       near ptr M04_L37
       mov       r14d,4
M04_L05:
       cmp       r14d,2
       je        near ptr M04_L39
       cmp       r14d,10
       je        near ptr M04_L38
       mov       rcx,offset MT_System.Reflection.MdFieldInfo
       cmp       [rbx],rcx
       jne       near ptr M04_L54
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+58],xmm0
       vmovdqu   xmmword ptr [rsp+60],xmm0
       mov       rcx,1AAF47619B8
       cmp       rbp,rcx
       je        near ptr M04_L40
       mov       rcx,1AAF4761A60
       cmp       rbp,rcx
       sete      sil
       movzx     esi,sil
M04_L06:
       test      esi,esi
       jne       near ptr M04_L46
       mov       rcx,16A5F8001C8
       mov       r14,[rcx]
       mov       rdx,rbp
       cmp       qword ptr [r14+8],0
       je        near ptr M04_L12
       mov       r15,[r14+10]
       xor       r13d,r13d
       mov       r12,[r14+18]
       mov       rcx,offset MT_System.Collections.Generic.ObjectEqualityComparer<System.RuntimeType>
       cmp       [r12],rcx
       jne       near ptr M04_L43
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
       je        near ptr M04_L41
M04_L07:
       mov       rax,[rcx]
       mov       [rsp+38],rax
       mov       rcx,offset MT_System.RuntimeType
       cmp       [rax],rcx
       jne       near ptr M04_L42
       mov       rcx,rax
       call      00007FF97BF8FEC0
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
       jae       near ptr M04_L56
       mov       ecx,ecx
       lea       rdx,[rdx+rcx*4+10]
       mov       r10d,[rdx]
       dec       r10d
       js        short M04_L12
M04_L10:
       cmp       r10d,[r15+8]
       jae       near ptr M04_L56
       mov       edx,r10d
       shl       rdx,4
       lea       r14,[r15+rdx+10]
       cmp       [r14+8],eax
       je        near ptr M04_L44
M04_L11:
       mov       r10d,[r14+0C]
       inc       r13d
       cmp       [r15+8],r13d
       jb        near ptr M04_L45
       test      r10d,r10d
       mov       eax,[rsp+54]
       jge       short M04_L10
M04_L12:
       mov       rsi,[rbx+10]
       cmp       [rsi],sil
       mov       rcx,rsi
       call      00007FF97BE87BF0
       mov       rcx,rax
       test      rcx,rcx
       je        near ptr M04_L53
M04_L13:
       mov       edx,[rbx+1C]
       mov       r8d,[rsp+68]
       mov       r9,rbp
       call      qword ptr [7FF91C34EEF8]; System.Reflection.CustomAttribute.GetCustomAttributes(System.Reflection.RuntimeModule, Int32, Int32, System.RuntimeType)
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
       je        short M04_L16
       cmp       dword ptr [rbp+8],0
       jne       near ptr M04_L23
M04_L16:
       xor       edx,edx
M04_L17:
       mov       rax,rdx
       test      rax,rax
       je        short M04_L18
       mov       rcx,rdi
       cmp       [rax],rcx
       je        short M04_L18
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
M04_L18:
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
M04_L19:
       mov       rcx,[rsp+38]
       call      qword ptr [7FF91C34EEB0]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
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
       call      qword ptr [7FF91C3457A0]; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M04_L14
M04_L21:
       mov       rdx,r10
       mov       r8,rax
       call      qword ptr [7FF91C345818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M04_L14
M04_L22:
       mov       [rsp+20],esi
       xor       r8d,r8d
       mov       [rsp+28],r8d
       mov       r8,rbx
       xor       edx,edx
       call      qword ptr [7FF91C96F978]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M04_L14
M04_L23:
       cmp       dword ptr [rbp+8],0
       jbe       near ptr M04_L56
       mov       rcx,[rbp+10]
       cmp       dword ptr [rbp+8],1
       jne       near ptr M04_L55
       mov       rdx,rcx
       jmp       near ptr M04_L17
M04_L24:
       mov       ecx,1A1
       mov       rdx,7FF91C284000
       call      qword ptr [7FF91C5677B0]
       mov       rcx,rax
       call      qword ptr [7FF91C8CE550]
       int       3
M04_L25:
       xor       ecx,ecx
       jmp       near ptr M04_L00
M04_L26:
       xor       ecx,ecx
       jmp       near ptr M04_L02
M04_L27:
       mov       rcx,rbp
       call      qword ptr [7FF91C28A400]
       mov       r14,rax
       mov       r15,1AAF47619B8
       xor       r13d,r13d
       jmp       short M04_L31
M04_L28:
       mov       rdx,[r14+r13*8+10]
       mov       rcx,offset MT_System.RuntimeType
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       r12,rax
       mov       rcx,r12
       cmp       [rcx],ecx
       call      qword ptr [7FF91C34D398]; System.RuntimeType.get_IsActualInterface()
       test      eax,eax
       jne       short M04_L30
       mov       rcx,r12
       call      00007FF97BFAAB00
       test      eax,eax
       je        short M04_L29
       mov       rcx,r12
       call      qword ptr [7FF91C28A3F8]
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
       mov       rcx,1AAF47619B8
       cmp       r15,rcx
       jne       short M04_L32
       mov       rcx,rbp
       call      qword ptr [7FF91C28A3F8]
       mov       rcx,1AAF4764B90
       test      al,8
       cmovne    r15,rcx
M04_L32:
       mov       rcx,r15
       jmp       near ptr M04_L02
M04_L33:
       xor       eax,eax
       jmp       near ptr M04_L01
M04_L34:
       call      qword ptr [7FF91C345C80]; System.RuntimeTypeHandle.GetRuntimeTypeFromHandleSlow(IntPtr)
       jmp       near ptr M04_L01
M04_L35:
       call      qword ptr [7FF91C34E040]; System.RuntimeType.GetBaseType()
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M04_L03
M04_L36:
       mov       rcx,offset MT_System.Attribute
       cmp       rdi,rcx
       je        near ptr M04_L04
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF91C96F588]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF91C6C4240]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M04_L37:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       r14d,eax
       jmp       near ptr M04_L05
M04_L38:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Reflection.PropertyInfo
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       rcx,rax
       mov       rdx,rbp
       movzx     r8d,sil
       call      qword ptr [7FF91C86E730]; System.Attribute.InternalGetCustomAttributes(System.Reflection.PropertyInfo, System.Type, Boolean)
       mov       rbp,rax
       jmp       near ptr M04_L15
M04_L39:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Reflection.EventInfo
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       rcx,rax
       mov       rdx,rbp
       movzx     r8d,sil
       call      qword ptr [7FF91C96F5A0]
       mov       rbp,rax
       jmp       near ptr M04_L15
M04_L40:
       mov       esi,1
       jmp       near ptr M04_L06
M04_L41:
       xor       eax,eax
       jmp       near ptr M04_L08
M04_L42:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
       jmp       near ptr M04_L08
M04_L43:
       mov       rcx,r12
       mov       r11,7FF91C290AD0
       call      qword ptr [r11]
       jmp       near ptr M04_L09
M04_L44:
       mov       rdx,[r14]
       mov       rcx,r12
       mov       r8,rbp
       mov       r11,7FF91C290AD8
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M04_L11
       mov       rcx,1AAF4761AF8
       cmp       rbp,rcx
       jne       short M04_L48
       jmp       short M04_L46
M04_L45:
       call      qword ptr [7FF91C567A20]
       int       3
M04_L46:
       mov       rcx,rbx
       call      qword ptr [7FF91C9E7CC0]
       test      rax,rax
       je        short M04_L47
       lea       rcx,[rsp+58]
       mov       r8,rax
       mov       rdx,offset MT_System.RuntimeType+ListBuilder<System.Attribute>
       call      qword ptr [7FF91C34D4B8]; System.RuntimeType+ListBuilder`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
M04_L47:
       test      esi,esi
       jne       short M04_L49
M04_L48:
       mov       rcx,1AAF4761AA8
       cmp       rbp,rcx
       jne       short M04_L51
M04_L49:
       mov       rcx,rbx
       call      qword ptr [7FF91C9E7CD8]
       test      rax,rax
       je        short M04_L50
       lea       rcx,[rsp+58]
       mov       r8,rax
       mov       rdx,offset MT_System.RuntimeType+ListBuilder<System.Attribute>
       call      qword ptr [7FF91C34D4B8]; System.RuntimeType+ListBuilder`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
M04_L50:
       test      esi,esi
       jne       short M04_L52
M04_L51:
       mov       rcx,1AAF4761B48
       cmp       rbp,rcx
       jne       near ptr M04_L12
M04_L52:
       test      byte ptr [rbx+30],80
       je        near ptr M04_L12
       mov       rcx,offset MT_System.NonSerializedAttribute
       call      CORINFO_HELP_NEWSFAST
       mov       r8,rax
       lea       rcx,[rsp+58]
       mov       rdx,offset MT_System.RuntimeType+ListBuilder<System.Attribute>
       call      qword ptr [7FF91C34D4B8]; System.RuntimeType+ListBuilder`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       jmp       near ptr M04_L12
M04_L53:
       mov       rcx,rsi
       call      qword ptr [7FF91C347C78]; System.RuntimeTypeHandle.<GetModule>g__GetModuleWorker|48_0(System.RuntimeType)
       mov       rcx,rax
       jmp       near ptr M04_L13
M04_L54:
       movzx     r8d,sil
       mov       rcx,rbx
       mov       rdx,rbp
       mov       rax,[rbx]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       mov       rbx,rax
       jmp       near ptr M04_L14
M04_L55:
       call      qword ptr [7FF91C96F5B8]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M04_L56:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1750
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
       sub       rsp,1A8
       vzeroupper
       lea       rbp,[rsp+1E0]
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
       mov       rax,7FF91C284EE8
       mov       [rbp-148],rax
       lea       rax,[M07_L02]
       mov       [rbp-138],rax
       lea       rax,[rbp-158]
       mov       [rdi+8],rax
       mov       byte ptr [rdi+4],0
       mov       rax,7FF97BF6C140
       call      rax
M07_L02:
       mov       byte ptr [rdi+4],1
       cmp       dword ptr [7FF97C2B39A0],0
       je        short M07_L03
       call      qword ptr [7FF97C2A1648]; CORINFO_HELP_STOP_FOR_GC
M07_L03:
       mov       rcx,[rbp-150]
       mov       [rdi+8],rcx
       mov       rbx,[rbp-50]
       cmp       [rbx],bl
       mov       rcx,[rbx+18]
       call      00007FF97BE86650
       test      rax,rax
       jne       near ptr M07_L21
M07_L04:
       mov       rcx,16A5F8001C8
       mov       rsi,[rcx]
       cmp       qword ptr [rsi+8],0
       je        near ptr M07_L11
       mov       r14,[rsi+10]
       xor       r15d,r15d
       mov       r13,[rsi+18]
       mov       rcx,offset MT_System.Collections.Generic.ObjectEqualityComparer<System.RuntimeType>
       cmp       [r13],rcx
       jne       near ptr M07_L46
       mov       rcx,1AAF4765F08
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
       call      00007FF97BF8FEC0
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
       cmp       eax,[r14+8]
       jae       near ptr M07_L59
       mov       edx,eax
       shl       rdx,4
       lea       rsi,[r14+rdx+10]
       cmp       [rsi+8],r12d
       je        near ptr M07_L47
M07_L10:
       mov       eax,[rsi+0C]
       inc       r15d
       cmp       [r14+8],r15d
       jb        near ptr M07_L48
       test      eax,eax
       jge       short M07_L09
M07_L11:
       mov       rcx,rbx
       call      00007FF97BE87BF0
       mov       rsi,rax
       test      rsi,rsi
       je        near ptr M07_L50
M07_L12:
       mov       [rbp-190],rsi
       mov       rcx,rbx
       call      00007FF97BFAB230
       mov       ebx,eax
       cmp       [rsi],sil
       mov       rcx,rsi
       call      00007FF97BFF6FB0
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
       mov       rax,7FF91C48B248
       mov       [rbp-148],rax
       lea       rax,[M07_L13]
       mov       [rbp-138],rax
       lea       rax,[rbp-158]
       mov       [rdi+8],rax
       mov       byte ptr [rdi+4],0
       mov       rax,7FF97BF6E550
       call      rax
M07_L13:
       mov       byte ptr [rdi+4],1
       cmp       dword ptr [7FF97C2B39A0],0
       je        short M07_L14
       call      qword ptr [7FF97C2A1648]; CORINFO_HELP_STOP_FOR_GC
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
       xchg      ax,ax
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
       call      qword ptr [7FF91C345860]; System.RuntimeTypeHandle.GetRuntimeTypeFromHandle(IntPtr)
       test      rax,rax
       jne       short M07_L17
       jmp       near ptr M07_L04
M07_L22:
       mov       rcx,r12
       call      qword ptr [7FF91C34EEB0]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
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
       call      00007FF97BFAC060
       test      eax,eax
       jl        near ptr M07_L51
       mov       ecx,[rbp-0D0]
       mov       rdx,1AAF4765F08
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
       call      qword ptr [7FF91C34F0F0]; System.Reflection.CustomAttribute.FilterCustomAttributeRecord(System.Reflection.MetadataToken, System.Reflection.MetadataImport ByRef, System.Reflection.RuntimeModule, System.Reflection.MetadataToken, System.RuntimeType, Boolean, ListBuilder`1<System.Object> ByRef, System.RuntimeType ByRef, System.IRuntimeMethodInfo ByRef, Boolean ByRef)
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
       test      byte ptr [7FF91CB30698],1
       je        near ptr M07_L54
M07_L30:
       mov       rcx,16A5F802338
       mov       rcx,[rcx]
       mov       [rbp-178],r14
       mov       [rbp-170],r15d
       lea       rdx,[rbp-178]
       mov       r11,7FF91C290C68
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
       call      qword ptr [7FF91C9EC888]; System.UInt64.TryConvertFromTruncating[[System.UInt32, System.Private.CoreLib]](UInt32, UInt64 ByRef)
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
       call      qword ptr [7FF91C56DEF0]; System.RuntimeType+IGenericCacheEntry`1[[System.__Canon, System.Private.CoreLib]].Replace(System.RuntimeType, System.__Canon)
M07_L36:
       mov       rax,rsi
       add       rsp,1A8
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
       call      qword ptr [7FF91C347C30]; System.RuntimeType.InitializeCache()
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
       call      qword ptr [7FF91C34C4F8]; System.RuntimeType+IGenericCacheEntry`1[[System.__Canon, System.Private.CoreLib]].CreateAndCache(System.RuntimeType)
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
       mov       rdx,1AAF4765F08
       mov       r11,7FF91C290C50
       call      qword ptr [r11]
       mov       r12d,eax
       jmp       near ptr M07_L08
M07_L47:
       mov       rdx,[rsi]
       mov       rcx,r13
       mov       r8,1AAF4765F08
       mov       r11,7FF91C290C58
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M07_L10
       jmp       near ptr M07_L11
M07_L48:
       call      qword ptr [7FF91C567A20]
       int       3
M07_L49:
       mov       ebx,1
       jmp       near ptr M07_L18
M07_L50:
       mov       rcx,rbx
       call      qword ptr [7FF91C347C78]; System.RuntimeTypeHandle.<GetModule>g__GetModuleWorker|48_0(System.RuntimeType)
       mov       rsi,rax
       jmp       near ptr M07_L12
M07_L51:
       mov       rcx,offset MT_System.BadImageFormatException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FF91C8CE838]
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
       call      qword ptr [7FF91C9EE940]
       int       3
M07_L56:
       lea       r13,[rdi+10]
       add       r14,10
       mov       rcx,offset MT_System.Collections.Generic.ArraySortHelper<System.UInt32, System.String>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,16A5F802330
       mov       rcx,[rcx]
       mov       [rbp-178],r13
       mov       [rbp-170],r15d
       mov       [rbp-188],r14
       mov       [rbp-180],r15d
       lea       r8,[rbp-188]
       lea       rdx,[rbp-178]
       mov       r11,7FF91C290C60
       xor       r9d,r9d
       call      qword ptr [r11]
       jmp       near ptr M07_L31
M07_L57:
       lea       rdx,[rbp-120]
       mov       ecx,r15d
       call      qword ptr [7FF91C9EC8D0]
       test      eax,eax
       jne       near ptr M07_L33
       call      qword ptr [7FF91C9EFAC8]
       int       3
M07_L58:
       xor       r8d,r8d
       jmp       near ptr M07_L35
M07_L59:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 2042
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
       call      qword ptr [7FF91C34C9A8]; System.Object.GetType()
       mov       rsi,rax
       lea       rdi,[rbx+8]
       mov       rcx,[rbx]
       call      00007FF97BFB6350
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
       lea       rdx,[7FF91CA67390]
       mov       edx,[rdx+rcx*4]
       lea       rax,[M08_L00]
       add       rdx,rax
       jmp       rdx
M08_L09:
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FF91C9ECF78]
       jmp       short M08_L06
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FF91C9ECCF0]
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
       call      qword ptr [7FF91C347C30]; System.RuntimeType.InitializeCache()
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
       call      qword ptr [7FF91C9ECDB0]
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
       call      qword ptr [7FF91C9ECED0]
       jmp       short M08_L21
M08_L20:
       mov       rcx,rax
       mov       edx,edi
       call      qword ptr [7FF91C8C7E40]; System.SpanHelpers.NonPackedIndexOfValueType[[System.Byte, System.Private.CoreLib],[System.SpanHelpers+DontNegate`1[[System.Byte, System.Private.CoreLib]], System.Private.CoreLib]](Byte ByRef, Byte, Int32)
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
       call      qword ptr [7FF91C9ECD08]
M08_L25:
       test      rax,rax
       jne       short M08_L26
       mov       ecx,edi
       call      qword ptr [7FF91C3479F0]; System.Number.UInt32ToDecStr(UInt32)
M08_L26:
       jmp       near ptr M08_L06
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FF91C9ECCC0]
       jmp       near ptr M08_L06
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FF91C9ECCA8]
       jmp       near ptr M08_L06
M08_L27:
       mov       rcx,rsi
       call      qword ptr [7FF91C347C30]; System.RuntimeType.InitializeCache()
       jmp       near ptr M08_L01
M08_L28:
       mov       rcx,rsi
       mov       edx,1
       call      qword ptr [7FF91C56DDD0]; System.Enum.<GetEnumInfo>g__InitializeEnumInfo|5_0[[System.UInt32, System.Private.CoreLib]](System.RuntimeType, Boolean)
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
       call      qword ptr [7FF91C9EC3C0]
       jmp       short M08_L33
M08_L32:
       mov       rcx,rax
       mov       edx,edi
       call      qword ptr [7FF91C9EC5D0]; System.SpanHelpers.NonPackedIndexOfValueType[[System.Int32, System.Private.CoreLib],[System.SpanHelpers+DontNegate`1[[System.Int32, System.Private.CoreLib]], System.Private.CoreLib]](Int32 ByRef, Int32, Int32)
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
       call      qword ptr [7FF91C9ECF30]
       jmp       near ptr M08_L05
M08_L36:
       mov       ecx,edi
       call      qword ptr [7FF91C4BF210]; System.Number.Int32ToDecStr(Int32)
       jmp       near ptr M08_L06
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FF91C9ECC78]
       jmp       near ptr M08_L06
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FF91C9ECC60]
       jmp       near ptr M08_L06
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FF91C9ECC48]
       jmp       near ptr M08_L06
; Total bytes of code 761
```

## .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       call      qword ptr [7FF91C955AD0]; DotNetTips.Spargine.Core.BenchmarkTests.EnumHelperBenchmark.GetDescriptionNoCache(System.Enum)
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
       sub       rsp,78
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+30],ymm4
       vmovdqu   ymmword ptr [rsp+50],ymm4
       mov       [rsp+70],rax
       mov       rbx,rcx
       test      rbx,rbx
       je        near ptr M01_L44
       mov       rcx,rbx
       call      qword ptr [7FF91C34C9A8]; System.Object.GetType()
       mov       rsi,rax
       mov       rcx,[rsi+18]
       test      cl,2
       jne       near ptr M01_L45
       mov       rcx,[rcx+10]
       mov       rdx,offset MT_System.Enum
       cmp       rcx,rdx
       sete      al
       movzx     eax,al
M01_L00:
       test      eax,eax
       je        near ptr M01_L46
       mov       rcx,[rsi+18]
       test      cl,2
       jne       near ptr M01_L39
       mov       rcx,[rcx+10]
       mov       rax,offset MT_System.Enum
       cmp       rcx,rax
       sete      cl
       movzx     ecx,cl
M01_L01:
       test      ecx,ecx
       je        near ptr M01_L47
M01_L02:
       mov       rcx,rbx
       call      qword ptr [7FF91C955BD8]; System.Enum.ToUInt64(System.Object)
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF91C955C38]; System.Enum.GetName(System.RuntimeType, UInt64)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M01_L48
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8d,1C
       call      qword ptr [7FF91C28A490]; System.RuntimeType.GetField(System.String, System.Reflection.BindingFlags)
       mov       rbx,rax
       test      rbx,rbx
       je        near ptr M01_L96
       mov       rsi,22E3C460730
       mov       rcx,offset MT_System.ComponentModel.DescriptionAttribute
       mov       ecx,[rcx]
       and       ecx,0F0000
       cmp       ecx,0C0000
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M01_L49
       mov       rcx,rsi
       call      00007FF97BFAAB00
       test      eax,eax
       jne       near ptr M01_L50
       mov       rcx,[7FF91C96DD70]
       test      rcx,rcx
       je        near ptr M01_L56
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
       mov       rax,22E3C451A60
       cmp       rcx,rax
       jne       near ptr M01_L58
       mov       rcx,offset MT_System.Reflection.MdFieldInfo
       cmp       [rbx],rcx
       jne       near ptr M01_L60
       mov       ebp,4
M01_L06:
       cmp       ebp,2
       je        near ptr M01_L62
       cmp       ebp,10
       je        near ptr M01_L61
       mov       rcx,offset MT_System.Reflection.MdFieldInfo
       cmp       [rbx],rcx
       jne       near ptr M01_L69
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+60],xmm0
       vmovdqu   xmmword ptr [rsp+68],xmm0
       mov       rcx,1EDA74001C8
       mov       rsi,[rcx]
       cmp       qword ptr [rsi+8],0
       je        near ptr M01_L13
       mov       rbp,[rsi+10]
       xor       r14d,r14d
       mov       r15,[rsi+18]
       mov       rcx,offset MT_System.Collections.Generic.ObjectEqualityComparer<System.RuntimeType>
       cmp       [r15],rcx
       jne       near ptr M01_L65
       mov       rcx,22E3C460730
       mov       [rsp+58],rcx
       xor       ecx,ecx
       mov       [rsp+50],rcx
       lea       rcx,[rsp+58]
       cmp       qword ptr [rsp+50],0
       jne       short M01_L07
       mov       rcx,[rsp+58]
       mov       [rsp+50],rcx
       lea       rcx,[rsp+50]
       cmp       qword ptr [rsp+50],0
       je        near ptr M01_L63
M01_L07:
       mov       r13,[rcx]
       mov       rcx,offset MT_System.RuntimeType
       cmp       [r13],rcx
       jne       near ptr M01_L64
       mov       rcx,r13
       call      00007FF97BF8FEC0
       test      eax,eax
       je        near ptr M01_L40
M01_L08:
       mov       r13d,eax
M01_L09:
       xor       ecx,ecx
       mov       [rsp+50],rcx
M01_L10:
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
       jae       near ptr M01_L97
       mov       ecx,ecx
       lea       rdx,[rdx+rcx*4+10]
       mov       eax,[rdx]
       dec       eax
       js        short M01_L13
M01_L11:
       mov       esi,[rbp+8]
       cmp       eax,esi
       jae       near ptr M01_L97
       mov       edx,eax
       shl       rdx,4
       lea       r12,[rbp+rdx+10]
       cmp       [r12+8],r13d
       je        near ptr M01_L66
M01_L12:
       mov       eax,[r12+0C]
       inc       r14d
       cmp       esi,r14d
       jb        near ptr M01_L90
       test      eax,eax
       jge       short M01_L11
M01_L13:
       mov       rsi,[rbx+10]
       cmp       [rsi],sil
       mov       rcx,rsi
       call      00007FF97BE87BF0
       mov       rcx,rax
       test      rcx,rcx
       je        near ptr M01_L67
M01_L14:
       mov       edx,[rbx+1C]
       mov       r8d,[rsp+70]
       mov       r9,22E3C460730
       call      qword ptr [7FF91C34EEF8]; System.Reflection.CustomAttribute.GetCustomAttributes(System.Reflection.RuntimeModule, Int32, Int32, System.RuntimeType)
       mov       rsi,rax
       cmp       dword ptr [rsp+70],0
       jg        near ptr M01_L68
M01_L15:
       mov       rbp,rsi
       test      rbp,rbp
       je        short M01_L16
       mov       rdx,offset MT_System.Runtime.Serialization.EnumMemberAttribute[]
       cmp       [rbp],rdx
       je        short M01_L16
       mov       rdx,rsi
       mov       rcx,offset MT_System.Attribute[]
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rbp,rax
M01_L16:
       test      rbp,rbp
       je        short M01_L17
       mov       ecx,[rbp+8]
       test      ecx,ecx
       jne       near ptr M01_L41
M01_L17:
       xor       edx,edx
M01_L18:
       mov       rsi,rdx
       test      rsi,rsi
       je        short M01_L19
       mov       rcx,offset MT_System.ComponentModel.DescriptionAttribute
       cmp       [rsi],rcx
       je        short M01_L19
       call      qword ptr [7FF91C34FD08]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       mov       rsi,rax
M01_L19:
       test      rsi,rsi
       jne       near ptr M01_L71
M01_L20:
       mov       rsi,22E3C460758
       mov       rcx,offset MT_System.Runtime.Serialization.EnumMemberAttribute
       mov       ecx,[rcx]
       and       ecx,0F0000
       cmp       ecx,0C0000
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M01_L72
       mov       rcx,rsi
       call      00007FF97BFAAB00
       test      eax,eax
       jne       near ptr M01_L73
       mov       rcx,[7FF91C96DF30]
       test      rcx,rcx
       je        near ptr M01_L79
       mov       rax,[rcx+20]
       add       rax,10
       mov       rax,[rax]
       test      rax,rax
       je        near ptr M01_L80
M01_L21:
       mov       rcx,rax
M01_L22:
       test      rcx,rcx
       je        near ptr M01_L82
M01_L23:
       mov       rax,22E3C451A60
       cmp       rcx,rax
       jne       near ptr M01_L81
       mov       rcx,offset MT_System.Reflection.MdFieldInfo
       cmp       [rbx],rcx
       jne       near ptr M01_L83
       mov       ebp,4
M01_L24:
       cmp       ebp,2
       je        near ptr M01_L85
       cmp       ebp,10
       je        near ptr M01_L84
       mov       rcx,offset MT_System.Reflection.MdFieldInfo
       cmp       [rbx],rcx
       jne       near ptr M01_L93
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+38],xmm0
       vmovdqu   xmmword ptr [rsp+40],xmm0
       mov       rcx,1EDA74001C8
       mov       rsi,[rcx]
       cmp       qword ptr [rsi+8],0
       je        near ptr M01_L31
       mov       rbp,[rsi+10]
       xor       r14d,r14d
       mov       r15,[rsi+18]
       mov       rcx,offset MT_System.Collections.Generic.ObjectEqualityComparer<System.RuntimeType>
       cmp       [r15],rcx
       jne       near ptr M01_L88
       mov       rcx,22E3C460758
       mov       [rsp+30],rcx
       xor       ecx,ecx
       mov       [rsp+28],rcx
       lea       rcx,[rsp+30]
       cmp       qword ptr [rsp+28],0
       jne       short M01_L25
       mov       rcx,[rsp+30]
       mov       [rsp+28],rcx
       lea       rcx,[rsp+28]
       cmp       qword ptr [rsp+28],0
       je        near ptr M01_L86
M01_L25:
       mov       r13,[rcx]
       mov       rcx,offset MT_System.RuntimeType
       cmp       [r13],rcx
       jne       near ptr M01_L87
       mov       rcx,r13
       call      00007FF97BF8FEC0
       test      eax,eax
       je        near ptr M01_L42
M01_L26:
       mov       r13d,eax
M01_L27:
       xor       ecx,ecx
       mov       [rsp+28],rcx
M01_L28:
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
       jae       near ptr M01_L97
       mov       ecx,ecx
       lea       rdx,[rdx+rcx*4+10]
       mov       eax,[rdx]
       dec       eax
       js        short M01_L31
M01_L29:
       mov       esi,[rbp+8]
       cmp       eax,esi
       jae       near ptr M01_L97
       mov       edx,eax
       shl       rdx,4
       lea       r12,[rbp+rdx+10]
       cmp       [r12+8],r13d
       je        near ptr M01_L89
M01_L30:
       mov       eax,[r12+0C]
       inc       r14d
       cmp       esi,r14d
       jb        near ptr M01_L90
       test      eax,eax
       jge       short M01_L29
M01_L31:
       mov       rsi,[rbx+10]
       cmp       [rsi],sil
       mov       rcx,rsi
       call      00007FF97BE87BF0
       mov       rcx,rax
       test      rcx,rcx
       je        near ptr M01_L91
M01_L32:
       mov       edx,[rbx+1C]
       mov       r8d,[rsp+48]
       mov       r9,22E3C460758
       call      qword ptr [7FF91C34EEF8]; System.Reflection.CustomAttribute.GetCustomAttributes(System.Reflection.RuntimeModule, Int32, Int32, System.RuntimeType)
       mov       rbx,rax
       cmp       dword ptr [rsp+48],0
       jg        near ptr M01_L92
M01_L33:
       mov       rbp,rbx
       test      rbp,rbp
       je        short M01_L34
       mov       rdx,offset MT_System.Runtime.Serialization.EnumMemberAttribute[]
       cmp       [rbp],rdx
       je        short M01_L34
       mov       rdx,rbx
       mov       rcx,offset MT_System.Attribute[]
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rbp,rax
M01_L34:
       test      rbp,rbp
       je        short M01_L35
       mov       ecx,[rbp+8]
       test      ecx,ecx
       jne       near ptr M01_L43
M01_L35:
       xor       edx,edx
M01_L36:
       mov       rcx,rdx
       test      rcx,rcx
       je        short M01_L37
       mov       rax,offset MT_System.Runtime.Serialization.EnumMemberAttribute
       cmp       [rcx],rax
       jne       near ptr M01_L95
M01_L37:
       test      rcx,rcx
       je        near ptr M01_L96
       mov       rax,[rcx+8]
       mov       rdx,rax
       test      rdx,rdx
       je        near ptr M01_L96
       cmp       dword ptr [rdx+8],0
       je        near ptr M01_L96
M01_L38:
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
M01_L39:
       xor       ecx,ecx
       jmp       near ptr M01_L01
M01_L40:
       mov       rcx,r13
       call      qword ptr [7FF91C34EEB0]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       jmp       near ptr M01_L08
M01_L41:
       test      ecx,ecx
       je        near ptr M01_L97
       mov       rax,[rbp+10]
       mov       rdx,rax
       cmp       ecx,1
       jne       near ptr M01_L70
       jmp       near ptr M01_L18
M01_L42:
       mov       rcx,r13
       call      qword ptr [7FF91C34EEB0]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       jmp       near ptr M01_L26
M01_L43:
       test      ecx,ecx
       je        near ptr M01_L97
       mov       rax,[rbp+10]
       mov       rdx,rax
       cmp       ecx,1
       jne       near ptr M01_L94
       jmp       near ptr M01_L36
M01_L44:
       call      qword ptr [7FF91C8C6E20]
       mov       ecx,7
       mov       rdx,7FF91C613A48
       call      qword ptr [7FF91C5677B0]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF91C615548
       call      qword ptr [7FF91C5677B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF91C347840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,5
       mov       rdx,7FF91C613A48
       call      qword ptr [7FF91C5677B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF91C347840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF91C9E4990]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF91C95E268]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M01_L45:
       mov       rcx,rsi
       mov       rdx,22E3C455F30
       call      qword ptr [7FF91C28A608]; System.RuntimeType.IsSubclassOf(System.Type)
       jmp       near ptr M01_L00
M01_L46:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,13
       mov       rdx,7FF91C613A48
       call      qword ptr [7FF91C5677B0]
       mov       rsi,rax
       mov       ecx,7
       mov       rdx,7FF91C613A48
       call      qword ptr [7FF91C5677B0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF91C6C6130]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L47:
       mov       rcx,rsi
       call      qword ptr [7FF91C95EC28]; System.Type.IsIntegerType(System.Type)
       test      eax,eax
       jne       near ptr M01_L02
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF91C95EC40]
       mov       rsi,rax
       mov       ecx,3AD
       mov       rdx,7FF91C284000
       call      qword ptr [7FF91C5677B0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF91C6C6130]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L48:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       jmp       near ptr M01_L38
M01_L49:
       xor       ecx,ecx
       jmp       near ptr M01_L04
M01_L50:
       mov       rcx,rsi
       call      qword ptr [7FF91C28A400]
       mov       rbp,rax
       mov       r14,22E3C4519B8
       xor       r15d,r15d
       jmp       short M01_L54
M01_L51:
       mov       rdx,[rbp+r15*8+10]
       mov       rcx,offset MT_System.RuntimeType
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       r13,rax
       mov       rcx,r13
       cmp       [rcx],ecx
       call      qword ptr [7FF91C34D398]; System.RuntimeType.get_IsActualInterface()
       test      eax,eax
       jne       short M01_L53
       mov       rcx,r13
       call      00007FF97BFAAB00
       test      eax,eax
       je        short M01_L52
       mov       rcx,r13
       call      qword ptr [7FF91C28A3F8]
       mov       ecx,eax
       and       ecx,4
       and       eax,8
       or        ecx,eax
       je        short M01_L53
M01_L52:
       mov       r14,r13
M01_L53:
       inc       r15d
M01_L54:
       cmp       [rbp+8],r15d
       jg        short M01_L51
       mov       rcx,22E3C4519B8
       cmp       r14,rcx
       jne       short M01_L55
       mov       rcx,rsi
       call      qword ptr [7FF91C28A3F8]
       mov       rcx,22E3C454B90
       test      al,8
       cmovne    r14,rcx
M01_L55:
       mov       rcx,r14
       jmp       near ptr M01_L04
M01_L56:
       xor       eax,eax
       jmp       near ptr M01_L03
M01_L57:
       call      qword ptr [7FF91C345C80]; System.RuntimeTypeHandle.GetRuntimeTypeFromHandleSlow(IntPtr)
       jmp       near ptr M01_L03
M01_L58:
       call      qword ptr [7FF91C34E040]; System.RuntimeType.GetBaseType()
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M01_L05
M01_L59:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF91C95E7F0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF91C6C4240]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L60:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       ebp,eax
       jmp       near ptr M01_L06
M01_L61:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Reflection.PropertyInfo
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       rcx,rbx
       mov       rdx,rsi
       xor       r8d,r8d
       call      qword ptr [7FF91C85CA98]; System.Attribute.InternalGetCustomAttributes(System.Reflection.PropertyInfo, System.Type, Boolean)
       mov       rbp,rax
       jmp       near ptr M01_L16
M01_L62:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Reflection.EventInfo
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       rcx,rbx
       mov       rdx,rsi
       xor       r8d,r8d
       call      qword ptr [7FF91C95E808]
       mov       rbp,rax
       jmp       near ptr M01_L16
M01_L63:
       xor       r13d,r13d
       jmp       near ptr M01_L09
M01_L64:
       mov       rcx,r13
       mov       rax,[r13]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
       mov       r13d,eax
       jmp       near ptr M01_L09
M01_L65:
       mov       rcx,r15
       mov       rdx,22E3C460730
       mov       r11,7FF91C290A40
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       near ptr M01_L10
M01_L66:
       mov       rdx,[r12]
       mov       rcx,r15
       mov       r8,22E3C460730
       mov       r11,7FF91C290A48
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M01_L12
       jmp       near ptr M01_L13
M01_L67:
       mov       rcx,rsi
       call      qword ptr [7FF91C347C78]; System.RuntimeTypeHandle.<GetModule>g__GetModuleWorker|48_0(System.RuntimeType)
       mov       rcx,rax
       jmp       near ptr M01_L14
M01_L68:
       mov       r9d,[rsi+8]
       sub       r9d,[rsp+70]
       lea       rcx,[rsp+60]
       mov       r8,rsi
       mov       rdx,offset MT_System.RuntimeType+ListBuilder<System.Attribute>
       call      qword ptr [7FF91C95E838]
       jmp       near ptr M01_L15
M01_L69:
       mov       rcx,rbx
       mov       rdx,rsi
       xor       r8d,r8d
       mov       rax,[rbx]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       mov       rsi,rax
       jmp       near ptr M01_L15
M01_L70:
       mov       rcx,rdx
       call      qword ptr [7FF91C95E790]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M01_L71:
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       test      rax,rax
       je        near ptr M01_L20
       cmp       dword ptr [rax+8],0
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M01_L20
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       jmp       near ptr M01_L38
M01_L72:
       xor       ecx,ecx
       jmp       near ptr M01_L22
M01_L73:
       mov       rcx,rsi
       call      qword ptr [7FF91C28A400]
       mov       rbp,rax
       mov       r14,22E3C4519B8
       xor       r15d,r15d
       jmp       short M01_L77
M01_L74:
       cmp       r15d,[rbp+8]
       jae       near ptr M01_L97
       mov       rdx,[rbp+r15*8+10]
       mov       rcx,offset MT_System.RuntimeType
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       r13,rax
       mov       rcx,r13
       cmp       [rcx],ecx
       call      qword ptr [7FF91C34D398]; System.RuntimeType.get_IsActualInterface()
       test      eax,eax
       jne       short M01_L76
       mov       rcx,r13
       call      00007FF97BFAAB00
       test      eax,eax
       je        short M01_L75
       mov       rcx,r13
       call      qword ptr [7FF91C28A3F8]
       mov       ecx,eax
       and       ecx,4
       and       eax,8
       or        ecx,eax
       je        short M01_L76
M01_L75:
       mov       r14,r13
M01_L76:
       inc       r15d
M01_L77:
       cmp       [rbp+8],r15d
       jg        short M01_L74
       mov       rcx,22E3C4519B8
       cmp       r14,rcx
       jne       short M01_L78
       mov       rcx,rsi
       call      qword ptr [7FF91C28A3F8]
       mov       rcx,22E3C454B90
       test      al,8
       cmovne    r14,rcx
M01_L78:
       mov       rcx,r14
       jmp       near ptr M01_L22
M01_L79:
       xor       eax,eax
       jmp       near ptr M01_L21
M01_L80:
       call      qword ptr [7FF91C345C80]; System.RuntimeTypeHandle.GetRuntimeTypeFromHandleSlow(IntPtr)
       jmp       near ptr M01_L21
M01_L81:
       call      qword ptr [7FF91C34E040]; System.RuntimeType.GetBaseType()
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M01_L23
M01_L82:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF91C95E7F0]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF91C6C4240]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M01_L83:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       ebp,eax
       jmp       near ptr M01_L24
M01_L84:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Reflection.PropertyInfo
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       rcx,rax
       mov       rdx,rsi
       xor       r8d,r8d
       call      qword ptr [7FF91C85CA98]; System.Attribute.InternalGetCustomAttributes(System.Reflection.PropertyInfo, System.Type, Boolean)
       mov       rbp,rax
       jmp       near ptr M01_L34
M01_L85:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Reflection.EventInfo
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       rcx,rax
       mov       rdx,rsi
       xor       r8d,r8d
       call      qword ptr [7FF91C95E808]
       mov       rbp,rax
       jmp       near ptr M01_L34
M01_L86:
       xor       r13d,r13d
       jmp       near ptr M01_L27
M01_L87:
       mov       rcx,r13
       mov       rax,[r13]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
       mov       r13d,eax
       jmp       near ptr M01_L27
M01_L88:
       mov       rcx,r15
       mov       rdx,22E3C460758
       mov       r11,7FF91C290A50
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       near ptr M01_L28
M01_L89:
       mov       rdx,[r12]
       mov       rcx,r15
       mov       r8,22E3C460758
       mov       r11,7FF91C290A58
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M01_L30
       jmp       near ptr M01_L31
M01_L90:
       call      qword ptr [7FF91C567A20]
       int       3
M01_L91:
       mov       rcx,rsi
       call      qword ptr [7FF91C347C78]; System.RuntimeTypeHandle.<GetModule>g__GetModuleWorker|48_0(System.RuntimeType)
       mov       rcx,rax
       jmp       near ptr M01_L32
M01_L92:
       mov       r9d,[rbx+8]
       sub       r9d,[rsp+48]
       lea       rcx,[rsp+38]
       mov       r8,rbx
       mov       rdx,offset MT_System.RuntimeType+ListBuilder<System.Attribute>
       call      qword ptr [7FF91C95E838]
       jmp       near ptr M01_L33
M01_L93:
       mov       rcx,rbx
       mov       rdx,rsi
       xor       r8d,r8d
       mov       rax,[rbx]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       mov       rbx,rax
       jmp       near ptr M01_L33
M01_L94:
       mov       rcx,rdx
       call      qword ptr [7FF91C95E790]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M01_L95:
       mov       rcx,rax
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M01_L96:
       mov       rax,rdi
       jmp       near ptr M01_L38
M01_L97:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 3230
```

