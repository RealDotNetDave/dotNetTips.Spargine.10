## .NET 10.0.0 (10.0.0, 10.0.25.52411), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark.GetAttributeFieldInfo()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,70
       lea       rbp,[rsp+0A0]
       xor       eax,eax
       mov       [rbp-78],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-70],ymm4
       vmovdqu   ymmword ptr [rbp-50],ymm4
       mov       [rbp+10],rcx
       mov       rcx,1CB7A480668
       mov       rdx,1CB7A480690
       mov       r8d,1C
       call      qword ptr [7FFB0EC1A490]; System.RuntimeType.GetField(System.String, System.Reflection.BindingFlags)
       mov       rbx,rax
       test      rbx,rbx
       je        near ptr M00_L17
       mov       rcx,offset MT_System.Reflection.RtFieldInfo
       cmp       [rbx],rcx
       jne       near ptr M00_L26
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-48],xmm0
       vmovdqu   xmmword ptr [rbp-40],xmm0
       mov       rcx,18AE54001C8
       mov       rsi,[rcx]
       cmp       qword ptr [rsi+8],0
       je        near ptr M00_L06
       mov       rdi,[rsi+10]
       xor       r14d,r14d
       mov       r15,[rsi+18]
       mov       rcx,offset MT_System.Collections.Generic.ObjectEqualityComparer<System.RuntimeType>
       cmp       [r15],rcx
       jne       near ptr M00_L20
       mov       rcx,1CB7A4806E8
       mov       [rbp-50],rcx
       xor       ecx,ecx
       mov       [rbp-58],rcx
       lea       rcx,[rbp-50]
       cmp       qword ptr [rbp-58],0
       jne       short M00_L00
       mov       rcx,[rbp-50]
       mov       [rbp-58],rcx
       lea       rcx,[rbp-58]
       cmp       qword ptr [rbp-58],0
       je        near ptr M00_L18
M00_L00:
       mov       r13,[rcx]
       mov       rcx,offset MT_System.RuntimeType
       cmp       [r13],rcx
       jne       near ptr M00_L19
       mov       rcx,r13
       call      00007FFB6E8B6270
       test      eax,eax
       je        near ptr M00_L10
M00_L01:
       mov       r13d,eax
M00_L02:
       xor       ecx,ecx
       mov       [rbp-58],rcx
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
       cmp       eax,[rdi+8]
       jae       near ptr M00_L35
       mov       edx,eax
       shl       rdx,4
       lea       rsi,[rdi+rdx+10]
       cmp       [rsi+8],r13d
       je        near ptr M00_L21
M00_L05:
       mov       eax,[rsi+0C]
       inc       r14d
       cmp       [rdi+8],r14d
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
       call      00007FFB6E8C1870
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M00_L24
M00_L08:
       mov       rcx,[rbx+38]
       call      00007FFB6E8F6DE0
       mov       edx,eax
       mov       rcx,rdi
       mov       r8d,[rbp-38]
       mov       r9,1CB7A4806E8
       call      qword ptr [7FFB0ECDE970]; System.Reflection.CustomAttribute.GetCustomAttributes(System.Reflection.RuntimeModule, Int32, Int32, System.RuntimeType)
       mov       rbx,rax
       cmp       dword ptr [rbp-38],0
       jg        near ptr M00_L25
M00_L09:
       test      rbx,rbx
       jne       short M00_L11
       mov       ecx,11
       call      qword ptr [7FFB0EF57DF8]
       int       3
M00_L10:
       mov       rcx,r13
       call      qword ptr [7FFB0ECDE928]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       jmp       near ptr M00_L01
M00_L11:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<System.Object>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M00_L12
       lea       rdx,[rbp-60]
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax+20]
       jmp       short M00_L14
M00_L12:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.IList<System.Object>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
       mov       dword ptr [rbp-60],1
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
       mov       [rbp-68],rax
       jmp       short M00_L16
M00_L15:
       xor       ecx,ecx
       mov       [rbp-68],rcx
M00_L16:
       mov       rcx,[rbp+10]
       mov       rbx,[rcx+18]
       mov       rdx,[rbp-68]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       add       rsp,70
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L17:
       call      qword ptr [7FFB0F2EE268]
       mov       ecx,25DB
       mov       rdx,7FFB0F025D88
       call      qword ptr [7FFB0EF57738]
       mov       rbx,rax
       mov       ecx,1B61
       mov       rdx,7FFB0F025D88
       call      qword ptr [7FFB0EF57738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB0ECD7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,110B
       mov       rdx,7FFB0F025D88
       call      qword ptr [7FFB0EF57738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB0ECD7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB0F44CA08]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB0F446E80]
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
       mov       rdx,1CB7A4806E8
       mov       r11,7FFB0EC20B60
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       near ptr M00_L03
M00_L21:
       mov       rdx,[rsi]
       mov       rcx,r15
       mov       r8,1CB7A4806E8
       mov       r11,7FFB0EC20B68
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M00_L05
       jmp       near ptr M00_L06
M00_L22:
       call      qword ptr [7FFB0EF579A8]
       int       3
M00_L23:
       mov       rcx,rax
       call      qword ptr [7FFB0ECD5C80]; System.RuntimeTypeHandle.GetRuntimeTypeFromHandleSlow(IntPtr)
       mov       rsi,rax
       jmp       near ptr M00_L07
M00_L24:
       mov       rcx,rsi
       call      qword ptr [7FFB0ECD7C90]; System.RuntimeTypeHandle.<GetModule>g__GetModuleWorker|48_0(System.RuntimeType)
       mov       rdi,rax
       jmp       near ptr M00_L08
M00_L25:
       mov       r9d,[rbx+8]
       sub       r9d,[rbp-38]
       lea       rcx,[rbp-48]
       mov       r8,rbx
       mov       rdx,offset MT_System.RuntimeType+ListBuilder<System.Attribute>
       call      qword ptr [7FFB0F4477B0]
       jmp       near ptr M00_L09
M00_L26:
       mov       rcx,rbx
       mov       rdx,1CB7A4806E8
       xor       r8d,r8d
       mov       rax,[rbx]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       mov       rbx,rax
       jmp       near ptr M00_L09
M00_L27:
       mov       rcx,rsi
       mov       r11,7FFB0EC20B98
       call      qword ptr [r11]
       mov       edi,eax
       test      edi,edi
       jle       near ptr M00_L33
       jmp       near ptr M00_L13
M00_L28:
       call      qword ptr [7FFB0F39F828]
       int       3
M00_L29:
       mov       rcx,rsi
       mov       r11,7FFB0EC20BA0
       xor       edx,edx
       call      qword ptr [r11]
       jmp       near ptr M00_L14
M00_L30:
       mov       rcx,rbx
       mov       r11,7FFB0EC20B78
       call      qword ptr [r11]
       mov       [rbp-70],rax
       mov       rcx,[rbp-70]
       mov       r11,7FFB0EC20B80
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L31
       mov       dword ptr [rbp-60],1
       mov       rcx,[rbp-70]
       mov       r11,7FFB0EC20B88
       call      qword ptr [r11]
       mov       [rbp-78],rax
       jmp       short M00_L32
M00_L31:
       mov       rcx,[rbp-70]
       mov       r11,7FFB0EC20B90
       call      qword ptr [r11]
       jmp       short M00_L33
M00_L32:
       call      M00_L36
       jmp       short M00_L34
M00_L33:
       xor       ecx,ecx
       mov       [rbp-60],ecx
       xor       eax,eax
       jmp       near ptr M00_L14
M00_L34:
       mov       rax,[rbp-78]
       jmp       near ptr M00_L14
M00_L35:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L36:
       sub       rsp,28
       cmp       qword ptr [rbp-70],0
       je        short M00_L37
       mov       rcx,[rbp-70]
       mov       r11,7FFB0EC20B90
       call      qword ptr [r11]
M00_L37:
       nop
       add       rsp,28
       ret
; Total bytes of code 1317
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
       mov       rsi,rcx
       mov       rdi,rdx
       mov       ebx,r8d
       test      rdi,rdi
       je        near ptr M01_L18
       test      bl,1
       jne       near ptr M01_L19
       mov       ebp,1
M01_L00:
       cmp       qword ptr [rsi+10],0
       je        short M01_L01
       mov       rcx,[rsi+10]
       mov       r14,[rcx]
       test      r14,r14
       jne       near ptr M01_L17
M01_L01:
       mov       rcx,rsi
       call      qword ptr [7FFB0ECD7C48]; System.RuntimeType.InitializeCache()
       mov       rsi,rax
M01_L02:
       mov       r14d,ebp
       mov       r15,rdi
       cmp       [rsi],sil
       lea       r13,[rsi+50]
       mov       r12,[r13]
       test      r12,r12
       je        near ptr M01_L20
M01_L03:
       mov       rsi,r12
       cmp       [rsi],sil
       cmp       r14d,1
       jne       near ptr M01_L21
       mov       rbp,[rsi+20]
       test      rbp,rbp
       je        near ptr M01_L31
       test      r15,r15
       je        near ptr M01_L22
       lea       rdx,[r15+0C]
       mov       [rsp+20],rdx
       mov       edx,15051505
       mov       ecx,15051505
       mov       r8,[rsp+20]
       mov       r9d,[r15+8]
       cmp       r9d,2
       jle       short M01_L05
M01_L04:
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
       jg        short M01_L04
M01_L05:
       test      r9d,r9d
       jg        near ptr M01_L23
M01_L06:
       imul      eax,ecx,5D588B65
       add       eax,edx
       xor       edx,edx
       mov       [rsp+20],rdx
M01_L07:
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
       jae       near ptr M01_L41
       mov       ecx,r14d
       mov       r13,[r12+rcx*8+10]
       test      r13,r13
       je        near ptr M01_L31
M01_L08:
       cmp       r13,r15
       jne       near ptr M01_L25
M01_L09:
       mov       rcx,[rbp+10]
       cmp       r14d,[rcx+8]
       jae       near ptr M01_L41
       mov       edx,r14d
       mov       rdi,[rcx+rdx*8+10]
M01_L10:
       test      rdi,rdi
       je        near ptr M01_L32
M01_L11:
       xor       esi,esi
       xor       ebx,2
       xor       ebp,ebp
       mov       r14d,[rdi+8]
       mov       r15d,10
       inc       r14d
M01_L12:
       dec       r14d
       je        short M01_L15
       mov       r13,[rdi+r15]
       mov       ecx,[r13+18]
       mov       eax,ebx
       and       eax,ecx
       cmp       eax,ecx
       jne       short M01_L14
       test      rsi,rsi
       jne       near ptr M01_L37
M01_L13:
       mov       rsi,r13
M01_L14:
       add       r15,8
       jmp       short M01_L12
M01_L15:
       test      ebp,ebp
       jne       near ptr M01_L39
M01_L16:
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
M01_L17:
       mov       rsi,r14
       jmp       near ptr M01_L02
M01_L18:
       mov       ecx,3E7
       mov       rdx,7FFB0EC14000
       call      qword ptr [7FFB0EF57738]
       mov       rcx,rax
       call      qword ptr [7FFB0F445788]
       int       3
M01_L19:
       mov       rcx,18AE5401F78
       mov       rcx,[rcx]
       mov       rdx,rdi
       call      qword ptr [7FFB0F4472D0]
       mov       rdi,rax
       mov       ebp,2
       jmp       near ptr M01_L00
M01_L20:
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache+MemberInfoCache<System.Reflection.RuntimeFieldInfo>
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       lea       rcx,[r12+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r13
       mov       rdx,r12
       xor       r8d,r8d
       call      00007FFB6E8BFBA0
       mov       rsi,rax
       test      rsi,rsi
       cmove     rsi,r12
       mov       r12,rsi
       jmp       near ptr M01_L03
M01_L21:
       cmp       ebp,2
       je        near ptr M01_L33
       cmp       byte ptr [r12+18],0
       je        near ptr M01_L36
       jmp       near ptr M01_L35
M01_L22:
       movsx     rdx,byte ptr [0]
       mov       edx,[0]
       add       edx,edx
       movsx     rcx,byte ptr [0]
       xor       ecx,ecx
       mov       r8d,0BFEAD572
       mov       r9d,159868B7
       call      qword ptr [7FFB0F17CB40]; System.Marvin.ComputeHash32(Byte ByRef, UInt32, UInt32, UInt32)
       jmp       near ptr M01_L07
M01_L23:
       mov       r9d,ecx
       rol       r9d,5
       add       r9d,ecx
       mov       ecx,r9d
       xor       ecx,[r8]
       jmp       near ptr M01_L06
M01_L24:
       cmp       r14d,edi
       jae       near ptr M01_L41
       mov       ecx,r14d
       mov       r13,[r12+rcx*8+10]
       test      r13,r13
       je        short M01_L31
       jmp       near ptr M01_L08
M01_L25:
       test      r15,r15
       jne       short M01_L27
M01_L26:
       inc       r14d
       mov       edi,[r12+8]
       cmp       edi,r14d
       jg        short M01_L24
       jmp       short M01_L30
M01_L27:
       mov       ecx,[r13+8]
       cmp       ecx,[r15+8]
       jne       short M01_L26
       lea       rcx,[r13+0C]
       lea       rdx,[r15+0C]
       mov       r8d,[r13+8]
       add       r8d,r8d
       cmp       r8,0A
       jne       short M01_L28
       mov       rax,[rcx]
       mov       rcx,[rcx+2]
       mov       r8,[rdx]
       xor       r8,rax
       xor       rcx,[rdx+2]
       or        rcx,r8
       sete      al
       movzx     eax,al
       jmp       short M01_L29
M01_L28:
       call      qword ptr [7FFB0ECDFB70]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
M01_L29:
       test      eax,eax
       je        short M01_L26
       jmp       near ptr M01_L09
M01_L30:
       sub       r14d,edi
       jmp       short M01_L24
M01_L31:
       xor       edi,edi
       jmp       near ptr M01_L10
M01_L32:
       mov       rcx,rsi
       mov       rdx,r15
       mov       r8d,1
       mov       r9d,2
       call      qword ptr [7FFB0ECDD2C0]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
       mov       rdi,rax
       jmp       near ptr M01_L11
M01_L33:
       lea       rcx,[r12+28]
       mov       r8,rdi
       mov       rdx,offset MT_System.Reflection.CerHashtable<System.String, System.Reflection.RuntimeFieldInfo[]>
       call      qword ptr [7FFB0ECDF3C0]; System.Reflection.CerHashtable`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Item(System.__Canon)
       test      rax,rax
       jne       short M01_L34
       mov       rcx,r12
       mov       rdx,rdi
       mov       r8d,2
       mov       r9d,2
       call      qword ptr [7FFB0ECDD2C0]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
M01_L34:
       mov       rdi,rax
       jmp       near ptr M01_L11
M01_L35:
       mov       rdi,[r12+8]
       jmp       near ptr M01_L11
M01_L36:
       mov       rcx,r12
       mov       r8d,ebp
       xor       edx,edx
       mov       r9d,2
       call      qword ptr [7FFB0ECDD2C0]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
       mov       rdi,rax
       jmp       near ptr M01_L11
M01_L37:
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
       je        near ptr M01_L40
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFB0ECDED30]; System.Type.get_IsInterface()
       test      eax,eax
       je        short M01_L38
       mov       rcx,r13
       mov       rax,[r13]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFB0ECDED30]; System.Type.get_IsInterface()
       test      eax,eax
       je        short M01_L38
       mov       ebp,1
M01_L38:
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
       jne       near ptr M01_L13
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFB0ECDED30]; System.Type.get_IsInterface()
       test      eax,eax
       je        near ptr M01_L14
       jmp       near ptr M01_L13
M01_L39:
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFB0ECDED30]; System.Type.get_IsInterface()
       test      eax,eax
       je        near ptr M01_L16
M01_L40:
       mov       rcx,rsi
       call      qword ptr [7FFB0F447780]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M01_L41:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1178
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
       call      qword ptr [7FFB0ECDE988]; System.Reflection.CustomAttribute.AddCustomAttributes(ListBuilder`1<System.Object> ByRef, System.Reflection.RuntimeModule, Int32, System.RuntimeType, Boolean, ListBuilder`1<System.Object>)
       add       r14d,[rbp-40]
       xor       esi,esi
       mov       rcx,1CB7A471A60
       cmp       rbx,rcx
       je        near ptr M02_L17
       mov       rcx,[rbx+18]
       test      cl,2
       jne       near ptr M02_L18
       mov       ecx,[rcx]
       and       ecx,0C0000
       cmp       ecx,40000
       sete      cl
       movzx     ecx,cl
M02_L00:
       test      ecx,ecx
       jne       near ptr M02_L26
       mov       [rbp+28],rbx
       mov       rdi,rbx
       mov       rbx,[rbp+28]
M02_L01:
       mov       rcx,offset MT_System.RuntimeType
       cmp       [rdi],rcx
       jne       near ptr M02_L22
       mov       [rbp+28],rbx
       mov       [rbp-0E0],rdi
       mov       rcx,[rdi+18]
       mov       rax,7FFB6E8C06C0
       call      rax
       movzx     ebx,al
       mov       rdi,[rbp-0E0]
       cmp       dword ptr [7FFB6EC1F778],0
       jne       near ptr M02_L20
M02_L02:
       cmp       ebx,1D
       ja        short M02_L03
       mov       ecx,1FEF7FFF
       bt        ecx,ebx
       jae       near ptr M02_L21
M02_L03:
       cmp       ebx,10
       sete      r13b
       movzx     r13d,r13b
M02_L04:
       mov       rbx,[rbp+28]
M02_L05:
       test      r13d,r13d
       jne       near ptr M02_L19
       mov       rcx,offset MT_System.RuntimeType
       cmp       [rdi],rcx
       jne       near ptr M02_L23
M02_L06:
       test      rdi,rdi
       je        near ptr M02_L24
       mov       rcx,rdi
       call      00007FFB6E8C2E70
       test      eax,eax
       jne       near ptr M02_L25
M02_L07:
       test      esi,esi
       jne       near ptr M02_L31
       test      r14d,r14d
       je        near ptr M02_L35
       mov       [rbp-70],r14d
       mov       r14d,[rbp-70]
       test      r14d,r14d
       jl        near ptr M02_L33
       mov       [rbp-80],rbx
       xor       ecx,ecx
       mov       [rbp-78],rcx
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rbp-90],xmm0
       lea       rcx,[rbp-80]
       mov       [rbp-90],rcx
       mov       rcx,[rbp-80]
       test      rcx,rcx
       je        near ptr M02_L15
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
       mov       rax,7FFB0ECE1878
       mov       [rbp-0B8],rax
       lea       rax,[M02_L09]
       mov       [rbp-0A8],rax
       lea       rax,[rbp-0C8]
       mov       [r15+8],rax
       mov       byte ptr [r15+4],0
       mov       rax,7FFB6E8C7180
       call      rax
M02_L09:
       mov       byte ptr [r15+4],1
       cmp       dword ptr [7FFB6EC1F778],0
       je        short M02_L10
       call      qword ptr [7FFB6EC0D608]; CORINFO_HELP_STOP_FOR_GC
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
       je        short M02_L16
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
       xor       ecx,ecx
       jmp       near ptr M02_L08
M02_L16:
       mov       r8,[rbp-48]
       jmp       short M02_L13
M02_L17:
       test      r14d,r14d
       je        near ptr M02_L28
       jmp       near ptr M02_L27
M02_L18:
       xor       ecx,ecx
       jmp       near ptr M02_L00
M02_L19:
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+68]
       call      qword ptr [rax+8]
       mov       rdi,rax
       jmp       near ptr M02_L01
M02_L20:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M02_L02
M02_L21:
       mov       r13d,1
       jmp       near ptr M02_L04
M02_L22:
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+68]
       call      qword ptr [rax]
       mov       r13d,eax
       jmp       near ptr M02_L05
M02_L23:
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+98]
       call      qword ptr [rax+8]
       mov       rdi,rax
       jmp       near ptr M02_L06
M02_L24:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB0F446E68]
       mov       r8,rax
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFB0F446E80]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M02_L25:
       mov       rcx,rbx
       mov       rdx,1CB7A471A60
       call      qword ptr [7FFB0EC1A608]; Precode of System.RuntimeType.IsSubclassOf(System.Type)
       test      eax,eax
       jne       near ptr M02_L17
M02_L26:
       mov       esi,1
       jmp       near ptr M02_L07
M02_L27:
       movsxd    rdx,r14d
       mov       rcx,offset MT_System.Attribute[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbx,rax
       jmp       short M02_L30
M02_L28:
       test      byte ptr [7FFB0F4B2C08],1
       jne       short M02_L29
       mov       rcx,offset MT_System.Array+EmptyArray<System.Attribute>
       call      qword ptr [7FFB0ECD5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
M02_L29:
       mov       rdx,18AE5402158
       mov       rbx,[rdx]
M02_L30:
       jmp       near ptr M02_L11
M02_L31:
       test      r14d,r14d
       je        short M02_L32
       movsxd    rdx,r14d
       mov       rcx,offset MT_System.Object[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbx,rax
       jmp       near ptr M02_L11
M02_L32:
       mov       rdx,18AE5401A78
       mov       rbx,[rdx]
       jmp       near ptr M02_L11
M02_L33:
       mov       ecx,0B3
       mov       rdx,7FFB0EC14000
       call      qword ptr [7FFB0EF57738]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FFB0F445758]
       int       3
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
       call      qword ptr [7FFB0ECD7C48]; System.RuntimeType.InitializeCache()
M02_L37:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFB0EE751B8]; System.RuntimeType+RuntimeTypeCache.GetEmptyArray()
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
       mov       rcx,7FFB0F498ECC
       call      CORINFO_HELP_COUNTPROFILE32
       lea       rcx,[rbp+10]
       mov       rax,7FFB0EE5F400
       mov       [rbp-60],rax
       lea       rax,[M03_L00]
       mov       [rbp-50],rax
       lea       rax,[rbp-70]
       mov       [rbx+8],rax
       mov       byte ptr [rbx+4],0
       mov       rax,7FFB6E868DF0
       call      rax
M03_L00:
       mov       byte ptr [rbx+4],1
       cmp       dword ptr [7FFB6EC1F778],0
       je        short M03_L01
       call      qword ptr [7FFB6EC0D608]; CORINFO_HELP_STOP_FOR_GC
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
       mov       rcx,7FFB0F498EC8
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
       je        short M05_L06
       mov       rax,[rdx]
       movzx     r8d,word ptr [rax+0E]
       test      r8,r8
       je        short M05_L03
       mov       r10,[rax+38]
       cmp       r8,4
       jl        short M05_L01
       cmp       [r10],rcx
       je        short M05_L06
M05_L00:
       cmp       [r10+8],rcx
       je        short M05_L06
       cmp       [r10+10],rcx
       je        short M05_L06
       cmp       [r10+18],rcx
       je        short M05_L06
       add       r10,20
       add       r8,0FFFFFFFFFFFFFFFC
       cmp       r8,4
       jge       short M05_L04
       test      r8,r8
       je        short M05_L03
M05_L01:
       cmp       [r10],rcx
       je        short M05_L06
M05_L02:
       add       r10,8
       dec       r8
       test      r8,r8
       jle       short M05_L03
       cmp       [r10],rcx
       je        short M05_L06
       jmp       short M05_L02
M05_L03:
       test      dword ptr [rax],500C0000
       je        short M05_L05
       jmp       qword ptr [7FFB0F0DD4B8]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
M05_L04:
       cmp       [r10],rcx
       je        short M05_L06
       jmp       short M05_L00
M05_L05:
       xor       edx,edx
M05_L06:
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
       call      00007FFB6E908D20
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFB0ECD5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFB0ECD5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1CB7A470008
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
       call      qword ptr [7FFB0F4463B8]
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
       call      qword ptr [7FFB6E718018]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-0A0]
       mov       rdx,[rbp-0A8]
       call      qword ptr [rax]
       lea       rcx,[rbp-98]
       call      qword ptr [7FFB6E718020]; CORINFO_HELP_JIT_PINVOKE_END
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
       call      qword ptr [7FFB6E718018]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-0A0]
       mov       rdx,[rbp-0A8]
       call      qword ptr [rax]
       lea       rcx,[rbp-98]
       call      qword ptr [7FFB6E718020]; CORINFO_HELP_JIT_PINVOKE_END
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

## .NET 10.0.0 (10.0.0, 10.0.25.52411), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark.GetImplementedInterfacesInterfaceNames()
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
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-50],rax
       mov       rbx,rcx
       mov       rcx,offset MT_System.Collections.Generic.List<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,179F8B406C8
       mov       [rsi+8],rcx
       mov       rcx,offset MT_System.Collections.Generic.List<System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,13963C00230
       mov       r14,[rcx]
       lea       rcx,[rdi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rdi+14]
       mov       rcx,rdi
       mov       rdx,179F8B40668
       call      qword ptr [7FFB0EE7E370]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       edx,[rdi+10]
       cmp       [rcx+8],edx
       jbe       short M00_L01
       lea       eax,[rdx+1]
       mov       [rdi+10],eax
       mov       edx,edx
       mov       rax,179F8B40698
       mov       [rcx+rdx*8+10],rax
M00_L00:
       mov       rcx,rdi
       call      qword ptr [7FFB0F395AA0]; DotNetTips.Spargine.Core.Extensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setg      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M00_L79
       mov       rcx,rsi
       call      qword ptr [7FFB0ECDC9A8]; System.Object.GetType()
       cmp       qword ptr [rax+10],0
       je        short M00_L02
       mov       rcx,[rax+10]
       mov       rsi,[rcx]
       test      rsi,rsi
       je        short M00_L02
       mov       r15,rsi
       jmp       short M00_L03
M00_L01:
       mov       rcx,rdi
       mov       rdx,179F8B40698
       call      qword ptr [7FFB0EE7E370]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M00_L00
M00_L02:
       mov       rcx,rax
       call      qword ptr [7FFB0ECD7C48]; System.RuntimeType.InitializeCache()
       mov       r15,rax
M00_L03:
       cmp       [r15],r15b
       lea       rsi,[r15+58]
       mov       rcx,[rsi]
       test      rcx,rcx
       je        near ptr M00_L81
M00_L04:
       cmp       byte ptr [rcx+18],0
       je        near ptr M00_L82
       mov       rsi,[rcx+8]
M00_L05:
       test      rsi,rsi
       je        near ptr M00_L76
       lea       r15,[rsi+10]
       mov       esi,[rsi+8]
M00_L06:
       test      esi,esi
       jne       near ptr M00_L77
       mov       rdx,13963C00208
       mov       r13,[rdx]
M00_L07:
       mov       rcx,13979C00118
       mov       rsi,[rcx]
       test      rsi,rsi
       je        near ptr M00_L85
M00_L08:
       mov       rdx,r13
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<System.Type>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r15,rax
       test      r15,r15
       jne       near ptr M00_L86
       mov       r15,r13
       test      r15,r15
       je        near ptr M00_L90
       mov       r12,r13
       test      r12,r12
       je        near ptr M00_L88
       cmp       dword ptr [r12+8],0
       je        near ptr M00_L87
       mov       r15,offset MT_System.Linq.Enumerable+ArraySelectIterator<System.Type, System.String>
       mov       rcx,r15
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [r15+10],eax
       lea       rcx,[r15+18]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+20]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M00_L09:
       test      r15,r15
       je        near ptr M00_L91
       mov       rcx,offset MT_System.Linq.Enumerable+<IntersectIterator>d__121<System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       dword ptr [rsi+50],0FFFFFFFE
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rsi+54],eax
       lea       rcx,[rsi+38]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+28],rcx
       mov       rcx,offset MT_System.Collections.Generic.List<System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       cmp       dword ptr [rsi+50],0FFFFFFFE
       jne       near ptr M00_L92
       mov       r14d,[rsi+54]
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       cmp       r14d,eax
       jne       near ptr M00_L92
       xor       ecx,ecx
       mov       [rsi+50],ecx
       mov       r14,rsi
M00_L10:
       mov       rdx,[rsi+38]
       lea       rcx,[r14+30]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rsi+18]
       lea       rcx,[r14+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rsi+28]
       lea       rcx,[r14+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp-58],r14
M00_L11:
       mov       rcx,[rbp-58]
       mov       [rbp-60],rcx
       mov       esi,[rcx+50]
       test      esi,esi
       jne       near ptr M00_L52
       mov       dword ptr [rcx+50],0FFFFFFFF
       mov       rcx,offset MT_System.Collections.Generic.HashSet<System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,[rbp-58]
       mov       r14,[rcx+10]
       mov       rdx,[rcx+20]
       test      rdx,rdx
       jne       short M00_L12
       mov       rdx,13963C00048
       mov       rdx,[rdx]
M00_L12:
       lea       rcx,[rsi+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+18]
       mov       rdx,13963C00048
       cmp       rcx,[rdx]
       jne       near ptr M00_L56
       mov       rcx,13963C00050
       mov       rdx,[rcx]
M00_L13:
       test      rdx,rdx
       je        short M00_L14
       lea       rcx,[rsi+18]
       call      CORINFO_HELP_ASSIGN_REF
M00_L14:
       test      r14,r14
       je        near ptr M00_L59
       mov       rdx,r14
       mov       rcx,offset MT_System.Collections.Generic.HashSet<System.String>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r15,rax
       test      r15,r15
       jne       near ptr M00_L60
M00_L15:
       mov       rdx,r14
       mov       rcx,offset MT_System.Collections.Generic.ICollection<System.String>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        near ptr M00_L17
       mov       rcx,offset MT_System.Collections.Generic.List<System.String>
       cmp       [rax],rcx
       jne       near ptr M00_L61
       mov       ecx,[rax+10]
M00_L16:
       test      ecx,ecx
       jle       short M00_L17
       call      qword ptr [7FFB0ECD5A88]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       r15d,eax
       movsxd    rdx,r15d
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r13,rax
       movsxd    rdx,r15d
       mov       rcx,offset MT_System.Collections.Generic.HashSet<System.String>+Entry[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r12,rax
       mov       dword ptr [rsi+2C],0FFFFFFFF
       lea       rcx,[rsi+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,r15d
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rsi+20],rax
M00_L17:
       mov       rcx,offset MT_System.Collections.Generic.List<System.String>
       cmp       [r14],rcx
       jne       near ptr M00_L63
       cmp       dword ptr [r14+10],0
       je        near ptr M00_L62
       mov       rcx,offset MT_System.Collections.Generic.List<System.String>+Enumerator
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       r13d,[r14+14]
       lea       rcx,[r15+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r15+10],rcx
       mov       [r15+18],r13d
       mov       [r15+1C],ecx
M00_L18:
       mov       [rbp-68],r15
M00_L19:
       mov       rcx,[rbp-68]
       mov       rdx,offset MT_System.Collections.Generic.List<System.String>+Enumerator
       cmp       [rcx],rdx
       jne       near ptr M00_L39
       mov       r14,[rbp-68]
       add       r14,8
       mov       rcx,[r14]
       mov       rdx,rcx
       mov       eax,[r14+10]
       cmp       eax,[rcx+14]
       jne       near ptr M00_L41
       mov       ecx,[r14+14]
       cmp       ecx,[rdx+10]
       jae       near ptr M00_L31
       mov       rcx,[rdx+8]
       mov       edx,[r14+14]
       cmp       edx,[rcx+8]
       jae       near ptr M00_L42
       mov       rdx,[rcx+rdx*8+10]
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [r14+14]
       mov       rcx,[rbp-68]
       mov       r14,[rcx+10]
M00_L20:
       cmp       qword ptr [rsi+8],0
       je        near ptr M00_L33
M00_L21:
       mov       r15,[rsi+10]
       mov       r13,[rsi+18]
       xor       r12d,r12d
       test      r14,r14
       je        near ptr M00_L29
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer+OrdinalComparer
       cmp       [r13],rcx
       jne       near ptr M00_L34
       lea       rcx,[r14+0C]
       mov       [rbp-48],rcx
       mov       ecx,15051505
       mov       edx,15051505
       mov       r11,[rbp-48]
       mov       eax,[r14+8]
       cmp       eax,2
       jle       short M00_L23
M00_L22:
       add       eax,0FFFFFFFC
       mov       r8d,ecx
       rol       r8d,5
       add       ecx,r8d
       xor       ecx,[r11]
       mov       r8d,edx
       rol       r8d,5
       add       edx,r8d
       xor       edx,[r11+4]
       add       r11,8
       cmp       eax,2
       jg        short M00_L22
M00_L23:
       test      eax,eax
       jle       short M00_L24
       mov       eax,edx
       rol       eax,5
       add       eax,edx
       mov       edx,eax
       xor       edx,[r11]
M00_L24:
       imul      eax,edx,5D588B65
       add       eax,ecx
       xor       ecx,ecx
       mov       [rbp-48],rcx
M00_L25:
       mov       [rbp-3C],eax
       mov       rdx,[rsi+8]
       mov       ecx,eax
       imul      rcx,[rsi+20]
       shr       rcx,20
       inc       rcx
       mov       r8d,[rdx+8]
       imul      rcx,r8
       shr       rcx,20
       cmp       ecx,[rdx+8]
       jae       near ptr M00_L42
       mov       ecx,ecx
       lea       r10,[rdx+rcx*4+10]
       mov       [rbp-78],r10
       mov       r9d,[r10]
       dec       r9d
       jns       near ptr M00_L35
M00_L26:
       cmp       dword ptr [rsi+30],0
       jg        short M00_L30
       mov       edx,[rsi+28]
       mov       [rbp-40],edx
       cmp       [r15+8],edx
       je        near ptr M00_L37
M00_L27:
       mov       edx,[rbp-40]
       mov       r15d,edx
       lea       ecx,[r15+1]
       mov       [rsi+28],ecx
       mov       rcx,[rsi+10]
       mov       r8,rcx
M00_L28:
       cmp       r15d,[r8+8]
       jae       near ptr M00_L42
       mov       ecx,r15d
       shl       rcx,4
       mov       [rbp-70],r8
       lea       rcx,[r8+rcx+10]
       mov       [rcx+8],eax
       mov       r10,[rbp-78]
       mov       edx,[r10]
       dec       edx
       mov       [rcx+0C],edx
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       inc       r15d
       mov       rdx,[rbp-78]
       mov       [rdx],r15d
       inc       dword ptr [rsi+34]
       cmp       r12d,64
       jbe       near ptr M00_L19
       jmp       near ptr M00_L38
M00_L29:
       xor       eax,eax
       jmp       near ptr M00_L25
M00_L30:
       mov       ecx,[rsi+2C]
       mov       r8d,ecx
       dec       dword ptr [rsi+30]
       cmp       ecx,[r15+8]
       jae       near ptr M00_L42
       shl       rcx,4
       mov       ecx,[r15+rcx+1C]
       neg       ecx
       add       ecx,0FFFFFFFD
       mov       [rsi+2C],ecx
       mov       ecx,r8d
       mov       r8,r15
       mov       r15d,ecx
       jmp       near ptr M00_L28
M00_L31:
       xor       ecx,ecx
       mov       [r14+8],rcx
       mov       dword ptr [r14+14],0FFFFFFFF
       jmp       near ptr M00_L43
M00_L32:
       mov       rcx,[rbp-68]
       mov       r11,7FFB0EC20C40
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L20
M00_L33:
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFB0ECDE880]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       jmp       near ptr M00_L21
M00_L34:
       mov       rcx,r13
       mov       rdx,r14
       mov       r11,7FFB0EC20C50
       call      qword ptr [r11]
       jmp       near ptr M00_L25
M00_L35:
       cmp       r9d,[r15+8]
       jae       near ptr M00_L42
       mov       edx,r9d
       shl       rdx,4
       lea       r9,[r15+rdx+10]
       mov       [rbp-80],r9
       cmp       [r9+8],eax
       jne       short M00_L36
       mov       rdx,[r9]
       mov       rcx,r13
       mov       r8,r14
       mov       r11,7FFB0EC20C58
       call      qword ptr [r11]
       test      eax,eax
       mov       r9,[rbp-80]
       jne       near ptr M00_L19
M00_L36:
       mov       r9d,[r9+0C]
       inc       r12d
       cmp       [r15+8],r12d
       jb        near ptr M00_L40
       test      r9d,r9d
       mov       eax,[rbp-3C]
       jge       short M00_L35
       jmp       near ptr M00_L26
M00_L37:
       mov       rcx,rsi
       call      qword ptr [7FFB0F4470A8]
       mov       rcx,[rsi+8]
       mov       r15d,[rbp-3C]
       mov       edx,r15d
       imul      rdx,[rsi+20]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       imul      rdx,rax
       shr       rdx,20
       cmp       edx,[rcx+8]
       jae       near ptr M00_L42
       mov       edx,edx
       lea       r10,[rcx+rdx*4+10]
       mov       rax,r10
       mov       [rbp-78],rax
       mov       eax,r15d
       jmp       near ptr M00_L27
M00_L38:
       mov       r15,[rbp-70]
       mov       rdx,r13
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M00_L19
       mov       edx,[r15+8]
       mov       rcx,rsi
       mov       r8d,1
       call      qword ptr [7FFB0F0D7A20]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,rsi
       mov       rdx,r14
       call      qword ptr [7FFB0ECDE940]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       jmp       near ptr M00_L19
M00_L39:
       mov       rcx,[rbp-68]
       mov       r11,7FFB0EC20C38
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L32
       jmp       near ptr M00_L64
M00_L40:
       call      qword ptr [7FFB0EF579A8]
       int       3
M00_L41:
       call      qword ptr [7FFB0EF5C0D8]
       int       3
M00_L42:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L43:
       mov       ecx,[rsi+28]
       test      ecx,ecx
       jle       short M00_L44
       mov       rax,[rsi+10]
       mov       eax,[rax+8]
       cdq
       idiv      ecx
       cmp       eax,3
       jg        near ptr M00_L65
M00_L44:
       mov       rcx,[rbp-60]
       lea       rcx,[rcx+40]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-60]
       mov       rsi,[rax+30]
       mov       r15,offset MT_System.Linq.Enumerable+ArraySelectIterator<System.Type, System.String>
       cmp       [rsi],r15
       jne       near ptr M00_L67
       cmp       dword ptr [rsi+14],0
       jne       near ptr M00_L66
       mov       r15d,[rsi+10]
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       cmp       r15d,eax
       jne       near ptr M00_L66
       mov       rdx,rsi
M00_L45:
       mov       dword ptr [rdx+14],1
M00_L46:
       mov       rcx,[rbp-60]
       lea       rcx,[rcx+48]
       call      CORINFO_HELP_ASSIGN_REF
M00_L47:
       mov       rax,[rbp-60]
       mov       dword ptr [rax+50],0FFFFFFFD
M00_L48:
       mov       rax,[rbp-60]
       mov       rsi,[rax+48]
       mov       r15,offset MT_System.Linq.Enumerable+ArraySelectIterator<System.Type, System.String>
       cmp       [rsi],r15
       jne       near ptr M00_L71
       mov       rax,[rsi+18]
       mov       edx,[rsi+14]
       lea       r8d,[rdx-1]
       mov       r10d,[rax+8]
       cmp       r10d,r8d
       jbe       near ptr M00_L53
       inc       edx
       mov       [rsi+14],edx
       mov       r14,[rsi+20]
       cmp       r8d,r10d
       jae       near ptr M00_L72
       mov       edx,r8d
       mov       rdx,[rax+rdx*8+10]
       mov       rax,offset DotNetTips.Spargine.Core.TypeHelper+<>c.<GetImplementedInterfaces>b__33_0(System.Type)
       cmp       [r14+18],rax
       jne       near ptr M00_L70
       mov       rax,offset MT_System.RuntimeType
       cmp       [rdx],rax
       jne       near ptr M00_L69
       mov       rcx,rdx
       call      qword ptr [7FFB0ECDC588]; System.RuntimeType.get_Cache()
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFB0F44C7B0]; System.RuntimeType+RuntimeTypeCache.GetName()
       mov       rdx,rax
M00_L49:
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
M00_L50:
       mov       rcx,[rbp-60]
       mov       rcx,[rcx+48]
       cmp       [rcx],r15
       jne       near ptr M00_L68
       mov       r14,[rcx+8]
M00_L51:
       mov       rcx,[rbp-60]
       mov       rcx,[rcx+40]
       mov       rdx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFB0EE5B568]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
       test      eax,eax
       je        near ptr M00_L48
       mov       rdx,[rbp-60]
       lea       rcx,[rdx+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-60]
       mov       dword ptr [rcx+50],1
       mov       esi,1
       jmp       near ptr M00_L73
M00_L52:
       cmp       esi,1
       je        near ptr M00_L47
       jmp       short M00_L55
M00_L53:
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFB0F00E878]; System.Linq.Enumerable+Iterator`1[[System.__Canon, System.Private.CoreLib]].Dispose()
M00_L54:
       mov       rcx,[rbp-60]
       call      qword ptr [7FFB0F44C6C0]; System.Linq.Enumerable+<IntersectIterator>d__121`1[[System.__Canon, System.Private.CoreLib]].<>m__Finally1()
       mov       rcx,[rbp-60]
       xor       edx,edx
       mov       [rcx+48],rdx
       mov       rcx,[rbp-58]
M00_L55:
       xor       esi,esi
       jmp       near ptr M00_L73
M00_L56:
       mov       rdx,13963C00068
       cmp       rcx,[rdx]
       jne       short M00_L57
       mov       rdx,13963C00058
       mov       rdx,[rdx]
       jmp       near ptr M00_L13
M00_L57:
       mov       rdx,13963C00070
       cmp       rcx,[rdx]
       jne       short M00_L58
       mov       rcx,13963C00060
       mov       rdx,[rcx]
       jmp       near ptr M00_L13
M00_L58:
       xor       edx,edx
       jmp       near ptr M00_L13
M00_L59:
       mov       ecx,17
       call      qword ptr [7FFB0EF5C1C8]
       int       3
M00_L60:
       mov       r8,r15
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Generic.HashSet<System.String>
       call      qword ptr [7FFB0F44C660]
       test      eax,eax
       je        near ptr M00_L15
       mov       rcx,rsi
       mov       rdx,r15
       call      qword ptr [7FFB0F4473A8]
       jmp       near ptr M00_L44
M00_L61:
       mov       rcx,rax
       mov       r11,7FFB0EC20C28
       call      qword ptr [r11]
       mov       ecx,eax
       jmp       near ptr M00_L16
M00_L62:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<System.String>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,13979C00198
       mov       r15,[rcx]
       jmp       near ptr M00_L18
M00_L63:
       mov       rcx,r14
       mov       r11,7FFB0EC20C30
       call      qword ptr [r11]
       mov       r15,rax
       jmp       near ptr M00_L18
M00_L64:
       mov       rcx,[rbp-68]
       mov       r11,7FFB0EC20C48
       call      qword ptr [r11]
       jmp       near ptr M00_L43
M00_L65:
       mov       edx,ecx
       sub       edx,[rsi+30]
       mov       rcx,rsi
       call      qword ptr [7FFB0F4473C0]
       jmp       near ptr M00_L44
M00_L66:
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFB0F0CF7F8]
       mov       rdx,rax
       jmp       near ptr M00_L45
M00_L67:
       mov       rcx,rsi
       mov       r11,7FFB0EC20C10
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       near ptr M00_L46
M00_L68:
       mov       r11,7FFB0EC20C20
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L51
M00_L69:
       mov       rcx,rdx
       mov       rax,[rdx]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       rdx,rax
       jmp       near ptr M00_L49
M00_L70:
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       mov       rdx,rax
       jmp       near ptr M00_L49
M00_L71:
       mov       rcx,rsi
       mov       r11,7FFB0EC20C18
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L50
       jmp       near ptr M00_L54
M00_L72:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L73:
       test      esi,esi
       je        short M00_L75
       mov       rcx,[rbp-58]
       mov       rdx,[rcx+8]
       inc       dword ptr [rdi+14]
       mov       rax,[rdi+8]
       mov       r8d,[rdi+10]
       cmp       [rax+8],r8d
       jbe       short M00_L74
       lea       r10d,[r8+1]
       mov       [rdi+10],r10d
       mov       r8d,r8d
       lea       rcx,[rax+r8*8+10]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L11
M00_L74:
       mov       rcx,rdi
       call      qword ptr [7FFB0EE7E370]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M00_L11
M00_L75:
       mov       rcx,[rbp-58]
       call      qword ptr [7FFB0F12DE38]; System.Linq.Enumerable+<IntersectIterator>d__121`1[[System.__Canon, System.Private.CoreLib]].System.IDisposable.Dispose()
       mov       rcx,rdi
       call      qword ptr [7FFB0F0D6478]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       mov       rdx,rax
       mov       rcx,7FFB0F428920
       call      qword ptr [7FFB0F26C510]; System.Array.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       mov       [rbp-50],rax
       mov       rcx,[rbx+18]
       lea       r8,[rbp-50]
       mov       rdx,7FFB0F429818
       cmp       [rcx],ecx
       call      qword ptr [7FFB0F39EF40]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
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
M00_L76:
       xor       r15d,r15d
       xor       esi,esi
       jmp       near ptr M00_L06
M00_L77:
       mov       edx,esi
       mov       rcx,offset MT_System.Type[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r13,rax
       lea       rcx,[r13+10]
       mov       r8d,esi
       shl       r8,3
       cmp       r8,4000
       ja        near ptr M00_L84
       mov       rdx,r15
       call      00007FFB6E8B5D60
       cmp       dword ptr [7FFB6EC1F778],0
       jne       near ptr M00_L83
M00_L78:
       jmp       near ptr M00_L07
M00_L79:
       call      qword ptr [7FFB0F395A28]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L80
       call      qword ptr [7FFB0F44C798]
       mov       rbx,rax
M00_L80:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,179F8B406E0
       call      qword ptr [7FFB0F447150]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L81:
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache+MemberInfoCache<System.RuntimeType>
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       lea       rcx,[r13+10]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       mov       rdx,r13
       xor       r8d,r8d
       call      00007FFB6E8BFBA0
       mov       rcx,rax
       test      rcx,rcx
       cmove     rcx,r13
       jmp       near ptr M00_L04
M00_L82:
       xor       edx,edx
       xor       r8d,r8d
       mov       r9d,5
       call      qword ptr [7FFB0ECDD2C0]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
       mov       rsi,rax
       jmp       near ptr M00_L05
M00_L83:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L78
M00_L84:
       mov       rdx,r15
       call      qword ptr [7FFB0F2EDB60]
       jmp       near ptr M00_L78
M00_L85:
       mov       rcx,offset MT_System.Func<System.Type, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,13979C000D0
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Core.TypeHelper+<>c.<GetImplementedInterfaces>b__33_0(System.Type)
       call      qword ptr [7FFB0ECD6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,13979C00118
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L08
M00_L86:
       mov       rcx,r15
       mov       rdx,offset MT_System.Linq.Enumerable+Iterator<System.Type>
       mov       r8,7FFB0F56FA20
       call      qword ptr [7FFB0ECD5920]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       mov       rcx,r15
       mov       rdx,rsi
       call      rax
       mov       r15,rax
       jmp       near ptr M00_L09
M00_L87:
       mov       rcx,offset MT_System.Array+EmptyArray<System.String>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,13979C001B0
       mov       r15,[rdx]
       jmp       near ptr M00_L09
M00_L88:
       mov       rdx,r13
       mov       rcx,offset MT_System.Collections.Generic.List<System.Type>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r13,rax
       test      r13,r13
       je        short M00_L89
       mov       rcx,offset MT_System.Linq.Enumerable+ListSelectIterator<System.Type, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       mov       rdx,r13
       mov       r8,rsi
       call      qword ptr [7FFB0F44C618]
       jmp       near ptr M00_L09
M00_L89:
       mov       rcx,offset MT_System.Linq.Enumerable+IListSelectIterator<System.Type, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,r13
       mov       rdx,r15
       mov       r8,rsi
       call      qword ptr [7FFB0F44C630]
       mov       r15,r13
       jmp       near ptr M00_L09
M00_L90:
       mov       rcx,offset MT_System.Linq.Enumerable+IEnumerableSelectIterator<System.Type, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       mov       rdx,r13
       mov       r8,rsi
       call      qword ptr [7FFB0F44C648]
       jmp       near ptr M00_L09
M00_L91:
       mov       ecx,4
       call      qword ptr [7FFB0EF57DF8]
       int       3
M00_L92:
       mov       rcx,offset MT_System.Linq.Enumerable+<IntersectIterator>d__121<System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       xor       eax,eax
       mov       [r14+50],eax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [r14+54],eax
       jmp       near ptr M00_L10
       sub       rsp,28
       cmp       qword ptr [rbp-68],0
       je        short M00_L93
       mov       rcx,[rbp-68]
       mov       r11,offset MT_System.Collections.Generic.List<System.String>+Enumerator
       cmp       [rcx],r11
       je        short M00_L93
       mov       rcx,[rbp-68]
       mov       r11,7FFB0EC20C48
       call      qword ptr [r11]
M00_L93:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       mov       rcx,[rbp-60]
       call      qword ptr [7FFB0F12DE38]; System.Linq.Enumerable+<IntersectIterator>d__121`1[[System.__Canon, System.Private.CoreLib]].System.IDisposable.Dispose()
       nop
       add       rsp,28
       ret
       sub       rsp,28
       mov       rcx,[rbp-58]
       call      qword ptr [7FFB0F12DE38]; System.Linq.Enumerable+<IntersectIterator>d__121`1[[System.__Canon, System.Private.CoreLib]].System.IDisposable.Dispose()
       nop
       add       rsp,28
       ret
; Total bytes of code 3597
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,[rbx+10]
       mov       ebp,edi
       lea       ecx,[rbp+1]
       mov       r14,[rbx+8]
       cmp       dword ptr [r14+8],0
       jne       near ptr M01_L04
       mov       r15d,4
M01_L00:
       mov       edx,7FFFFFC7
       cmp       r15d,7FFFFFC7
       cmova     r15d,edx
       cmp       r15d,ecx
       cmovl     r15d,ecx
       cmp       r15d,edi
       jl        near ptr M01_L06
       cmp       [r14+8],r15d
       je        short M01_L03
       test      r15d,r15d
       jle       near ptr M01_L08
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+0B0]
       test      rax,rax
       je        short M01_L05
       mov       rcx,rax
M01_L01:
       mov       edx,r15d
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r15,rax
       test      edi,edi
       jg        short M01_L07
M01_L02:
       lea       rcx,[rbx+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
M01_L03:
       lea       ecx,[rbp+1]
       mov       [rbx+10],ecx
       mov       rcx,[rbx+8]
       movsxd    rdx,ebp
       mov       r8,rsi
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L04:
       mov       r15d,[r14+8]
       add       r15d,r15d
       jmp       near ptr M01_L00
M01_L05:
       mov       rdx,7FFB0F41B638
       call      qword ptr [7FFB0ECDC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M01_L01
M01_L06:
       mov       ecx,7
       mov       edx,0F
       call      qword ptr [7FFB0F2E58C0]
       int       3
M01_L07:
       mov       rcx,r14
       mov       r8d,edi
       mov       rdx,r15
       call      qword ptr [7FFB0EE74FD8]; System.Array.Copy(System.Array, System.Array, Int32)
       jmp       short M01_L02
M01_L08:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+0B8]
       test      rdx,rdx
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rdx,7FFB0F4A1038
       call      qword ptr [7FFB0ECDC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M01_L10:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L03
; Total bytes of code 321
```
```assembly
; DotNetTips.Spargine.Core.Extensions.Count(System.Collections.IEnumerable)
; 		if (collection is null)
; 		^^^^^^^^^^^^^^^^^^^^^^^
; 			return 0;
; 			^^^^^^^^^
; 		if (collection is ICollection col)
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			return col.Count;
; 			^^^^^^^^^^^^^^^^^
; 		else if (collection is ICollection<object> colT)
; 		     ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			return colT.Count;
; 			^^^^^^^^^^^^^^^^^^
; 		var count = 0;
; 		^^^^^^^^^^^^^^
; 		var enumerator = collection.GetEnumerator();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			count++;
; 			^^^^^^^^
; 		while (enumerator.MoveNext())
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return count;
; 		^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       test      rbx,rbx
       je        short M02_L01
       mov       rcx,rbx
       mov       rdx,offset MT_System.Collections.Generic.List<System.String>
       cmp       [rcx],rdx
       jne       short M02_L02
M02_L00:
       test      rcx,rcx
       je        short M02_L04
       mov       rax,offset MT_System.Collections.Generic.List<System.String>
       cmp       [rcx],rax
       jne       short M02_L03
       mov       eax,[rcx+10]
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L01:
       xor       eax,eax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.ICollection
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rcx,rax
       jmp       short M02_L00
M02_L03:
       mov       r11,7FFB0EC20D18
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [r11]
M02_L04:
       mov       rcx,rbx
       mov       rdx,offset MT_System.Linq.Enumerable+IEnumerableWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Address>
       cmp       [rcx],rdx
       je        short M02_L05
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.ICollection<System.Object>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rcx,rax
       jmp       short M02_L06
M02_L05:
       xor       ecx,ecx
M02_L06:
       test      rcx,rcx
       je        short M02_L07
       mov       r11,7FFB0EC20D10
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [r11]
M02_L07:
       xor       esi,esi
       mov       rcx,offset MT_System.Linq.Enumerable+IEnumerableWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Address>
       cmp       [rbx],rcx
       jne       short M02_L08
       mov       rcx,rbx
       call      qword ptr [7FFB0EF5F648]; System.Linq.Enumerable+Iterator`1[[System.__Canon, System.Private.CoreLib]].GetEnumerator()
       mov       rdi,rax
       jmp       short M02_L09
M02_L08:
       mov       rcx,rbx
       mov       r11,7FFB0EC20D00
       call      qword ptr [r11]
       mov       rdi,rax
M02_L09:
       jmp       short M02_L11
M02_L10:
       add       esi,1
       jo        short M02_L14
M02_L11:
       mov       rcx,offset MT_System.Linq.Enumerable+IEnumerableWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Address>
       cmp       [rdi],rcx
       jne       short M02_L12
       mov       rcx,rdi
       call      qword ptr [7FFB0F0CE7A8]; Precode of System.Linq.Enumerable+IEnumerableWhereIterator`1[[System.__Canon, System.Private.CoreLib]].MoveNext()
       jmp       short M02_L13
M02_L12:
       mov       rcx,rdi
       mov       r11,7FFB0EC20D08
       call      qword ptr [r11]
M02_L13:
       test      eax,eax
       jne       short M02_L10
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L14:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 304
```
```assembly
; System.Object.GetType()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx]
       mov       rax,[rcx+20]
       add       rax,10
       mov       rax,[rax]
       test      rax,rax
       je        short M03_L01
M03_L00:
       add       rsp,20
       pop       rbx
       ret
M03_L01:
       call      qword ptr [7FFB0ECD5C80]; System.RuntimeTypeHandle.GetRuntimeTypeFromHandleSlow(IntPtr)
       jmp       short M03_L00
; Total bytes of code 41
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
       call      00007FFB6E8C1870
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
       mov       rax,7FFB0EE36D90
       mov       [rbp-78],rax
       lea       rax,[M04_L03]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFB6E852C30
       call      rax
M04_L03:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFB6EC1F778],0
       je        short M04_L04
       call      qword ptr [7FFB6EC0D608]; CORINFO_HELP_STOP_FOR_GC
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
       call      00007FFB6E8D04E0
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
       call      qword ptr [7FFB0F44C7F8]; System.RuntimeTypeHandle.GetGCHandle(System.Runtime.InteropServices.GCHandleType)
       mov       rdx,rax
       lea       rcx,[rbx+10]
       xor       eax,eax
       lock cmpxchg [rcx],rdx
       test      rax,rax
       je        near ptr M04_L00
       lea       rcx,[rbp-40]
       call      qword ptr [7FFB0F447168]
       jmp       near ptr M04_L00
M04_L09:
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M04_L10:
       mov       [rbp+10],rbx
       mov       rcx,rbx
       call      qword ptr [7FFB0ECD7C90]; System.RuntimeTypeHandle.<GetModule>g__GetModuleWorker|48_0(System.RuntimeType)
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
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rdx,rdx
       je        short M05_L02
       mov       rax,[rdx]
       cmp       rax,rcx
       je        short M05_L02
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M05_L02
M05_L00:
       test      rax,rax
       je        short M05_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M05_L02
       test      rax,rax
       je        short M05_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M05_L02
       test      rax,rax
       jne       short M05_L03
M05_L01:
       xor       edx,edx
M05_L02:
       mov       rax,rdx
       ret
M05_L03:
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M05_L02
       test      rax,rax
       je        short M05_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M05_L02
       jmp       short M05_L00
; Total bytes of code 86
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rdx,rdx
       je        short M06_L07
       mov       rax,[rdx]
       movzx     r8d,word ptr [rax+0E]
       test      r8,r8
       je        short M06_L04
       mov       r10,[rax+38]
       cmp       r8,4
       jl        short M06_L02
       cmp       [r10],rcx
       je        short M06_L07
M06_L00:
       cmp       [r10+8],rcx
       je        short M06_L07
       cmp       [r10+10],rcx
       je        short M06_L07
       cmp       [r10+18],rcx
       je        short M06_L07
       add       r10,20
       add       r8,0FFFFFFFFFFFFFFFC
       cmp       r8,4
       jl        short M06_L01
       cmp       [r10],rcx
       je        short M06_L07
       jmp       short M06_L00
M06_L01:
       test      r8,r8
       je        short M06_L04
M06_L02:
       cmp       [r10],rcx
       je        short M06_L07
M06_L03:
       add       r10,8
       dec       r8
       test      r8,r8
       jg        short M06_L05
M06_L04:
       test      dword ptr [rax],500C0000
       je        short M06_L06
       jmp       qword ptr [7FFB0F0DD4B8]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
M06_L05:
       cmp       [r10],rcx
       je        short M06_L07
       jmp       short M06_L03
M06_L06:
       xor       edx,edx
M06_L07:
       mov       rax,rdx
       ret
; Total bytes of code 121
```
```assembly
; System.Collections.HashHelpers.GetPrime(Int32)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       ebx,ecx
       test      ebx,ebx
       jl        short M07_L01
       mov       rax,7FFB6DAB1388
       xor       ecx,ecx
       mov       edx,48
M07_L00:
       mov       r8d,[rax+rcx]
       cmp       r8d,ebx
       jl        short M07_L02
       mov       eax,r8d
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M07_L01:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFB0F446D60]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB0EF5FF30]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M07_L02:
       add       rcx,4
       dec       edx
       jne       short M07_L00
       mov       esi,ebx
       or        esi,1
       jmp       short M07_L05
M07_L03:
       mov       ecx,esi
       call      qword ptr [7FFB0F446D78]
       test      eax,eax
       je        short M07_L04
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
       jne       short M07_L06
M07_L04:
       add       esi,2
M07_L05:
       cmp       esi,7FFFFFFF
       jl        short M07_L03
       jmp       short M07_L07
M07_L06:
       mov       eax,esi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M07_L07:
       mov       eax,ebx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 180
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
       call      qword ptr [7FFB0ECD5A88]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       esi,eax
       movsxd    rdx,esi
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rdi,rax
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+0B8]
       test      rax,rax
       je        short M08_L01
       mov       rcx,rax
M08_L00:
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
M08_L01:
       mov       rdx,7FFB0F4A6D60
       call      qword ptr [7FFB0ECDC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M08_L00
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
       call      qword ptr [7FFB6E71BEB0]
       mov       rcx,rax
       movsxd    rdx,esi
       call      qword ptr [7FFB6E718070]; CORINFO_HELP_NEWARR_1_DIRECT
       mov       rbp,rax
       mov       r14d,[rbx+28]
       mov       rcx,[rbx+10]
       mov       rdx,rbp
       mov       r8d,r14d
       call      qword ptr [7FFB6E729378]; Precode of System.Array.Copy(System.Array, System.Array, Int32)
       movzx     ecx,dil
       test      cl,1
       jne       near ptr M09_L06
M09_L00:
       movsxd    rcx,esi
       call      qword ptr [7FFB6E725BF0]
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      qword ptr [7FFB6E717FD0]; CORINFO_HELP_ASSIGN_REF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,esi
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rbx+20],rax
       xor       ecx,ecx
       test      r14d,r14d
       jle       short M09_L03
       cmp       [rbp+8],r14d
       jl        near ptr M09_L04
M09_L01:
       mov       edx,ecx
       shl       rdx,4
       lea       rdx,[rbp+rdx+10]
       cmp       dword ptr [rdx+0C],0FFFFFFFF
       jl        short M09_L02
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
       jae       near ptr M09_L11
       mov       r10d,r10d
       lea       rax,[r8+r10*4+10]
       mov       r8d,[rax]
       dec       r8d
       mov       [rdx+0C],r8d
       lea       edx,[rcx+1]
       mov       [rax],edx
M09_L02:
       inc       ecx
       cmp       ecx,r14d
       jl        short M09_L01
M09_L03:
       lea       rcx,[rbx+10]
       mov       rdx,rbp
       call      qword ptr [7FFB6E717FD0]; CORINFO_HELP_ASSIGN_REF
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
M09_L04:
       cmp       ecx,[rbp+8]
       jae       near ptr M09_L11
       mov       eax,ecx
       shl       rax,4
       lea       rdx,[rbp+rax+10]
       cmp       dword ptr [rdx+0C],0FFFFFFFF
       jl        short M09_L05
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
       jae       near ptr M09_L11
       mov       eax,r10d
       lea       rax,[r8+rax*4+10]
       mov       r8d,[rax]
       dec       r8d
       mov       [rdx+0C],r8d
       lea       edx,[rcx+1]
       mov       [rax],edx
M09_L05:
       inc       ecx
       cmp       ecx,r14d
       jl        short M09_L04
       jmp       near ptr M09_L03
M09_L06:
       mov       rcx,[rbx]
       call      qword ptr [7FFB6E71B4F0]
       mov       rdi,rax
       mov       rcx,[rbx+18]
       call      qword ptr [7FFB6E7277D0]
       mov       rcx,rax
       lea       r11,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       [rcx],ecx
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFB6E718078]; Precode of System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdi,rax
       lea       rcx,[rbx+18]
       mov       rdx,rdi
       call      qword ptr [7FFB6E717FD0]; CORINFO_HELP_ASSIGN_REF
       xor       r15d,r15d
       cmp       r15d,r14d
       jge       near ptr M09_L00
M09_L07:
       cmp       r15d,[rbp+8]
       jae       short M09_L11
       mov       rcx,r15
       shl       rcx,4
       lea       r13,[rbp+rcx+10]
       cmp       dword ptr [r13+0C],0FFFFFFFF
       jl        short M09_L10
       cmp       qword ptr [r13],0
       jne       short M09_L08
       xor       r12d,r12d
       jmp       short M09_L09
M09_L08:
       mov       rcx,[rbx]
       call      qword ptr [7FFB6E71D148]
       mov       rdx,[r13]
       mov       rcx,rdi
       mov       r11,rax
       call      qword ptr [rax]
       mov       r12d,eax
M09_L09:
       mov       [r13+8],r12d
M09_L10:
       inc       r15d
       cmp       r15d,r14d
       jl        short M09_L07
       jmp       near ptr M09_L00
M09_L11:
       call      qword ptr [7FFB6E717FC0]
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
       je        near ptr M10_L07
       mov       rdi,[rbx+10]
       xor       ebp,ebp
       mov       r14,[rbx+18]
       test      rsi,rsi
       je        near ptr M10_L11
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+80]
       test      r11,r11
       je        near ptr M10_L08
M10_L00:
       mov       rcx,offset MT_System.Collections.Generic.ObjectEqualityComparer<System.RuntimeType>
       cmp       [r14],rcx
       jne       near ptr M10_L13
       mov       [rsp+38],rsi
       xor       ecx,ecx
       mov       [rsp+30],rcx
       lea       rcx,[rsp+38]
       cmp       qword ptr [rsp+30],0
       jne       short M10_L01
       mov       rcx,[rsp+38]
       mov       [rsp+30],rcx
       lea       rcx,[rsp+30]
       cmp       qword ptr [rsp+30],0
       je        near ptr M10_L12
M10_L01:
       mov       r15,[rcx]
       mov       rcx,offset MT_System.RuntimeType
       cmp       [r15],rcx
       jne       near ptr M10_L10
       mov       rcx,r15
       call      00007FFB6E8B6270
       test      eax,eax
       je        near ptr M10_L09
M10_L02:
       mov       r15d,eax
M10_L03:
       xor       ecx,ecx
       mov       [rsp+30],rcx
M10_L04:
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
       jae       near ptr M10_L18
       mov       edx,edx
       lea       rcx,[rcx+rdx*4+10]
       mov       r13d,[rcx]
       dec       r13d
       js        short M10_L07
M10_L05:
       mov       r12d,[rdi+8]
       cmp       r13d,r12d
       jae       near ptr M10_L18
       mov       ecx,r13d
       shl       rcx,4
       lea       rax,[rdi+rcx+10]
       mov       [rsp+28],rax
       cmp       [rax+8],r15d
       je        near ptr M10_L14
M10_L06:
       mov       rax,[rsp+28]
       mov       r13d,[rax+0C]
       inc       ebp
       cmp       r12d,ebp
       jb        near ptr M10_L17
       test      r13d,r13d
       jge       short M10_L05
M10_L07:
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
M10_L08:
       mov       rdx,7FFB0F4A5358
       call      qword ptr [7FFB0ECDC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M10_L00
M10_L09:
       mov       rcx,r15
       call      qword ptr [7FFB0ECDE928]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       jmp       near ptr M10_L02
M10_L10:
       mov       rcx,r15
       mov       rax,[r15]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
       mov       r15d,eax
       jmp       near ptr M10_L03
M10_L11:
       xor       r15d,r15d
       jmp       near ptr M10_L04
M10_L12:
       xor       r15d,r15d
       jmp       near ptr M10_L03
M10_L13:
       mov       rcx,r14
       mov       rdx,rsi
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       near ptr M10_L04
M10_L14:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+88]
       test      r11,r11
       je        short M10_L15
       jmp       short M10_L16
M10_L15:
       mov       rdx,7FFB0F4A5370
       call      qword ptr [7FFB0ECDC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M10_L16:
       mov       rax,[rsp+28]
       mov       rdx,[rax]
       mov       rcx,r14
       mov       r8,rsi
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M10_L06
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
M10_L17:
       call      qword ptr [7FFB0EF579A8]
       int       3
M10_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 550
```
```assembly
; DotNetTips.Spargine.Core.TypeHelper+<>c.<GetImplementedInterfaces>b__33_0(System.Type)
; 		var interfaces = input.GetType().GetInterfaces().Select(p => p.Name);
; 		                                                             ^^^^^^
       push      rbx
       sub       rsp,20
       mov       rcx,rdx
       mov       rax,offset MT_System.RuntimeType
       cmp       [rcx],rax
       jne       short M11_L04
       cmp       qword ptr [rcx+10],0
       je        short M11_L00
       mov       rax,[rcx+10]
       mov       rbx,[rax]
       test      rbx,rbx
       jne       short M11_L02
M11_L00:
       call      qword ptr [7FFB0ECD7C48]; System.RuntimeType.InitializeCache()
       mov       rcx,rax
M11_L01:
       mov       rax,[rcx+18]
       test      rax,rax
       je        short M11_L03
       add       rsp,20
       pop       rbx
       ret
M11_L02:
       mov       rcx,rbx
       jmp       short M11_L01
M11_L03:
       lea       rdx,[rcx+18]
       xor       r8d,r8d
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFB0EE74A80]; System.RuntimeType+RuntimeTypeCache.ConstructName(System.String ByRef, System.TypeNameFormatFlags)
M11_L04:
       mov       rax,[rcx]
       mov       rax,[rax+40]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax+30]
; Total bytes of code 105
```
```assembly
; System.RuntimeType.get_Cache()
       mov       rax,[rcx+10]
       test      rax,rax
       je        short M12_L00
       mov       rax,[rax]
       test      rax,rax
       je        short M12_L00
       ret
M12_L00:
       jmp       qword ptr [7FFB0ECD7C48]; System.RuntimeType.InitializeCache()
; Total bytes of code 24
```
```assembly
; System.RuntimeType+RuntimeTypeCache.GetName()
       mov       rax,[rcx+18]
       test      rax,rax
       je        short M13_L00
       ret
M13_L00:
       lea       rdx,[rcx+18]
       xor       r8d,r8d
       jmp       qword ptr [7FFB0EE74A80]; System.RuntimeType+RuntimeTypeCache.ConstructName(System.String ByRef, System.TypeNameFormatFlags)
; Total bytes of code 23
```
```assembly
; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
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
       mov       [rsp+30],rax
       mov       [rsp+40],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       cmp       qword ptr [rbx+8],0
       je        near ptr M14_L07
       mov       rdi,[rbx+10]
       xor       ebp,ebp
       mov       r14d,0FFFFFFFF
       mov       r15,[rbx+18]
       test      rsi,rsi
       je        near ptr M14_L15
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+80]
       test      r11,r11
       je        near ptr M14_L14
M14_L00:
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer+OrdinalComparer
       cmp       [r15],rcx
       jne       near ptr M14_L16
       lea       rcx,[rsi+0C]
       mov       [rsp+30],rcx
       mov       ecx,15051505
       mov       r11d,15051505
       mov       rdx,[rsp+30]
       mov       eax,[rsi+8]
       cmp       eax,2
       jle       short M14_L02
M14_L01:
       add       eax,0FFFFFFFC
       mov       r8d,ecx
       rol       r8d,5
       add       ecx,r8d
       xor       ecx,[rdx]
       mov       r8d,r11d
       rol       r8d,5
       add       r11d,r8d
       xor       r11d,[rdx+4]
       add       rdx,8
       cmp       eax,2
       jg        short M14_L01
M14_L02:
       test      eax,eax
       jle       short M14_L03
       mov       eax,r11d
       rol       eax,5
       add       eax,r11d
       mov       r11d,eax
       xor       r11d,[rdx]
M14_L03:
       imul      r13d,r11d,5D588B65
       add       r13d,ecx
       xor       ecx,ecx
       mov       [rsp+30],rcx
M14_L04:
       mov       rcx,[rbx+8]
       mov       edx,r13d
       imul      rdx,[rbx+20]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       mov       r8d,eax
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,eax
       jae       near ptr M14_L25
       mov       edx,edx
       lea       r12,[rcx+rdx*4+10]
       mov       eax,[r12]
       dec       eax
       js        short M14_L07
M14_L05:
       mov       r8d,[rdi+8]
       mov       [rsp+2C],r8d
       cmp       eax,r8d
       jae       near ptr M14_L25
       mov       [rsp+3C],eax
       mov       ecx,eax
       shl       rcx,4
       lea       r10,[rdi+rcx+10]
       mov       [rsp+20],r10
       cmp       [r10+8],r13d
       je        short M14_L08
M14_L06:
       mov       eax,[rsp+3C]
       mov       r14d,eax
       mov       r10,[rsp+20]
       mov       eax,[r10+0C]
       inc       ebp
       cmp       [rsp+2C],ebp
       jb        near ptr M14_L24
       test      eax,eax
       jge       short M14_L05
M14_L07:
       xor       eax,eax
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
M14_L08:
       test      r15,r15
       je        near ptr M14_L17
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+88]
       test      r11,r11
       je        short M14_L10
M14_L09:
       mov       r10,[rsp+20]
       mov       rdx,[r10]
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer+OrdinalComparer
       cmp       [r15],rcx
       jne       near ptr M14_L22
       cmp       rdx,rsi
       je        near ptr M14_L20
       test      rdx,rdx
       je        near ptr M14_L21
       test      rsi,rsi
       je        near ptr M14_L21
       mov       ecx,[rdx+8]
       cmp       ecx,[rsi+8]
       jne       near ptr M14_L21
       add       rdx,0C
       lea       r9,[rsi+0C]
       add       ecx,ecx
       mov       r11d,ecx
       cmp       r11,0A
       jne       short M14_L11
       mov       rcx,[rdx]
       mov       r11,[rdx+2]
       mov       rdx,[r9]
       xor       rcx,rdx
       xor       r11,[r9+2]
       or        rcx,r11
       sete      cl
       movzx     ecx,cl
       mov       eax,ecx
       jmp       short M14_L12
M14_L10:
       mov       rdx,7FFB0F4A5370
       call      qword ptr [7FFB0ECDC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M14_L09
M14_L11:
       mov       rcx,rdx
       mov       rdx,r9
       mov       r8,r11
       call      qword ptr [7FFB0ECDFB70]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
M14_L12:
       test      eax,eax
       je        near ptr M14_L06
       test      r14d,r14d
       jge       near ptr M14_L23
       mov       r10,[rsp+20]
       mov       r8d,[r10+0C]
       inc       r8d
       mov       [r12],r8d
M14_L13:
       mov       ecx,[rbx+2C]
       neg       ecx
       add       ecx,0FFFFFFFD
       mov       [r10+0C],ecx
       xor       ecx,ecx
       mov       [r10],rcx
       mov       eax,[rsp+3C]
       mov       [rbx+2C],eax
       inc       dword ptr [rbx+30]
       mov       eax,1
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
M14_L14:
       mov       rdx,7FFB0F4A5358
       call      qword ptr [7FFB0ECDC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M14_L00
M14_L15:
       xor       r13d,r13d
       jmp       near ptr M14_L04
M14_L16:
       mov       rcx,r15
       mov       rdx,rsi
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       near ptr M14_L04
M14_L17:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+90]
       test      rdx,rdx
       je        short M14_L18
       jmp       short M14_L19
M14_L18:
       mov       rdx,7FFB0F4A5418
       call      qword ptr [7FFB0ECDC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M14_L19:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,[rax]
       mov       rax,[rsp+20]
       mov       rdx,[rax]
       mov       r8,rsi
       mov       r10,[rcx]
       mov       r10,[r10+40]
       call      qword ptr [r10+20]
       jmp       near ptr M14_L12
M14_L20:
       mov       ecx,1
       mov       eax,ecx
       jmp       near ptr M14_L12
M14_L21:
       xor       ecx,ecx
       mov       eax,ecx
       jmp       near ptr M14_L12
M14_L22:
       mov       rcx,r15
       mov       r8,rsi
       call      qword ptr [r11]
       jmp       near ptr M14_L12
M14_L23:
       cmp       r14d,[rsp+2C]
       jae       short M14_L25
       mov       ecx,r14d
       shl       rcx,4
       mov       r10,[rsp+20]
       mov       edx,[r10+0C]
       mov       [rdi+rcx+1C],edx
       jmp       near ptr M14_L13
M14_L24:
       call      qword ptr [7FFB0EF579A8]
       int       3
M14_L25:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 850
```
```assembly
; System.Linq.Enumerable+Iterator`1[[System.__Canon, System.Private.CoreLib]].Dispose()
       xor       eax,eax
       mov       [rcx+8],rax
       mov       dword ptr [rcx+14],0FFFFFFFF
       ret
; Total bytes of code 14
```
```assembly
; System.Linq.Enumerable+<IntersectIterator>d__121`1[[System.__Canon, System.Private.CoreLib]].<>m__Finally1()
       mov       dword ptr [rcx+50],0FFFFFFFF
       mov       rcx,[rcx+48]
       test      rcx,rcx
       je        short M16_L00
       mov       r11,offset MT_System.Linq.Enumerable+ArraySelectIterator<System.Type, System.String>
       cmp       [rcx],r11
       jne       short M16_L01
       xor       r11d,r11d
       mov       [rcx+8],r11
       mov       dword ptr [rcx+14],0FFFFFFFF
M16_L00:
       ret
M16_L01:
       mov       r11,7FFB0EC20D38
       jmp       qword ptr [r11]
; Total bytes of code 59
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M17_L00
       ret
M17_L00:
       jmp       qword ptr [7FFB0ECD5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```
```assembly
; System.Linq.Enumerable+<IntersectIterator>d__121`1[[System.__Canon, System.Private.CoreLib]].System.IDisposable.Dispose()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       ecx,[rbx+50]
       cmp       ecx,0FFFFFFFD
       je        short M18_L01
       cmp       ecx,1
       je        short M18_L01
M18_L00:
       xor       eax,eax
       mov       [rbx+40],rax
       mov       [rbx+48],rax
       mov       dword ptr [rbx+50],0FFFFFFFE
       add       rsp,20
       pop       rbx
       ret
M18_L01:
       mov       rcx,rbx
       call      qword ptr [7FFB0F44C6C0]; System.Linq.Enumerable+<IntersectIterator>d__121`1[[System.__Canon, System.Private.CoreLib]].<>m__Finally1()
       jmp       short M18_L00
; Total bytes of code 55
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,40
       mov       [rsp+38],rcx
       mov       rbx,rcx
       mov       esi,[rbx+10]
       test      esi,esi
       je        near ptr M19_L03
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+0B0]
       test      rax,rax
       je        near ptr M19_L02
       mov       rcx,rax
M19_L00:
       movsxd    rdx,esi
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       mov       rbp,[rbx+8]
       test      rbp,rbp
       je        near ptr M19_L09
       mov       rcx,[rbp]
       cmp       rcx,[rdi]
       jne       near ptr M19_L10
       cmp       dword ptr [rcx+4],18
       jne       near ptr M19_L10
       cmp       esi,[rbp+8]
       ja        near ptr M19_L10
       cmp       esi,[rdi+8]
       ja        near ptr M19_L10
       mov       r8d,esi
       movzx     edx,word ptr [rcx]
       imul      r8,rdx
       lea       rdx,[rbp+10]
       lea       rax,[rdi+10]
       test      dword ptr [rcx],1000000
       je        near ptr M19_L08
       cmp       r8,4000
       ja        near ptr M19_L07
       mov       rcx,rax
       call      00007FFB6E8B5D60
       cmp       dword ptr [7FFB6EC1F778],0
       jne       short M19_L06
M19_L01:
       mov       rax,rdi
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M19_L02:
       mov       rdx,7FFB0F41B638
       call      qword ptr [7FFB0ECDC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M19_L00
M19_L03:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+0B8]
       test      rdx,rdx
       je        short M19_L04
       jmp       short M19_L05
M19_L04:
       mov       rdx,7FFB0F4A1038
       call      qword ptr [7FFB0ECDC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M19_L05:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rax]
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M19_L06:
       call      CORINFO_HELP_POLL_GC
       jmp       short M19_L01
M19_L07:
       mov       rcx,rax
       call      qword ptr [7FFB0F2EDB60]
       jmp       short M19_L01
M19_L08:
       mov       rcx,rax
       call      qword ptr [7FFB0ECD5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M19_L01
M19_L09:
       xor       r14d,r14d
       jmp       short M19_L11
M19_L10:
       mov       rcx,rbp
       xor       edx,edx
       call      qword ptr [7FFB0F447978]; System.Array.GetLowerBound(Int32)
       mov       r14d,eax
M19_L11:
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FFB0F447978]; System.Array.GetLowerBound(Int32)
       mov       r9d,eax
       mov       [rsp+20],esi
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rbp
       mov       edx,r14d
       mov       r8,rdi
       call      qword ptr [7FFB0F444EB8]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M19_L01
; Total bytes of code 381
```
```assembly
; System.Array.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       push      rsi
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        short M20_L02
       cmp       dword ptr [rbx+8],0
       je        short M20_L03
       mov       rdx,[rcx+18]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M20_L01
M20_L00:
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
M20_L01:
       mov       rdx,7FFB0F4A7418
       call      qword ptr [7FFB0EF57AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       short M20_L00
M20_L02:
       mov       ecx,2
       call      qword ptr [7FFB0EF5C1C8]
       int       3
M20_L03:
       mov       rdx,[rcx+18]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M20_L04
       jmp       short M20_L05
M20_L04:
       mov       rdx,7FFB0F4A7418
       call      qword ptr [7FFB0EF57AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdx,rax
M20_L05:
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
       mov       rax,980876BE3B07
       mov       [rbp],rax
       mov       rsi,rcx
       mov       rbx,rdx
       mov       edi,r8d
       mov       r14d,r9d
       test      rbx,rbx
       je        short M22_L00
       cmp       dword ptr [rbx+8],0
       jne       short M22_L03
M22_L00:
       xor       r8d,r8d
       mov       [rbp+8],r8
       mov       [rbp+10],r8d
       mov       [rsp+20],r14d
       lea       r8,[rbp+8]
       mov       rcx,rsi
       mov       r9d,edi
       mov       rdx,179F8B30008
       call      qword ptr [7FFB0ECDD320]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].GetListByName(System.String, System.Span`1<Byte>, MemberListType, CacheType)
       mov       [rbp+18],rax
M22_L01:
       lea       rdx,[rbp+18]
       mov       rcx,rsi
       mov       r8,rbx
       mov       r9d,edi
       call      qword ptr [7FFB0ECDD578]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Insert(System.__Canon[] ByRef, System.String, MemberListType)
       mov       rax,[rbp+18]
       mov       r8,980876BE3B07
       cmp       [rbp],r8
       je        short M22_L02
       call      CORINFO_HELP_FAIL_FAST
M22_L02:
       nop
       lea       rsp,[rbp+20]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M22_L03:
       cmp       r14d,1
       jne       short M22_L04
       cmp       word ptr [rbx+0C],2E
       je        short M22_L04
       cmp       word ptr [rbx+0C],2A
       jne       short M22_L00
M22_L04:
       mov       rcx,13963C00220
       mov       rcx,[rcx]
       mov       rdx,rbx
       call      qword ptr [7FFB0EE64930]; Precode of System.Text.UTF8Encoding.GetByteCount(System.String)
       cmp       eax,400
       jbe       short M22_L05
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       r8,[rax+10]
       mov       eax,[rax+8]
       jmp       short M22_L07
M22_L05:
       mov       r8d,eax
       test      r8,r8
       je        short M22_L07
       mov       rdx,r8
       add       rdx,0F
       and       rdx,0FFFFFFFFFFFFFFF0
       add       rsp,30
       neg       rdx
       add       rdx,rsp
       jb        short M22_L06
       xor       edx,edx
M22_L06:
       test      [rsp],esp
       sub       rsp,1000
       cmp       rsp,rdx
       jae       short M22_L06
       mov       rsp,rdx
       test      [rsp],esp
       sub       rsp,30
       lea       r8,[rsp+30]
M22_L07:
       mov       [rbp+8],r8
       mov       [rbp+10],eax
       mov       [rsp+20],r14d
       lea       r8,[rbp+8]
       mov       rdx,rbx
       mov       rcx,rsi
       mov       r9d,edi
       call      qword ptr [7FFB0ECDD320]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].GetListByName(System.String, System.Span`1<Byte>, MemberListType, CacheType)
       mov       [rbp+18],rax
       jmp       near ptr M22_L01
; Total bytes of code 348
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M23_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M23_L00:
       call      qword ptr [7FFB0F446D00]
       int       3
; Total bytes of code 44
```
```assembly
; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rcx,[rdi]
       mov       eax,ebx
       rol       eax,5
       add       eax,ecx
       mov       edx,esi
       ror       edx,5
       add       eax,edx
       mov       rdx,13963C00A10
       mov       rdx,[rdx]
       mov       rdx,[rdx+8]
       movsxd    r8,eax
       mov       r10,9E3779B97F4A7C15
       imul      r8,r10
       movzx     r10d,byte ptr [rdx+10]
       shrx      r8,r8,r10
       xor       r10d,r10d
M24_L00:
       lea       r9d,[r8+1]
       movsxd    r9,r9d
       imul      r9,30
       lea       r9,[rdx+r9+10]
       mov       r11d,[r9]
       mov       ebp,[r9+8]
       mov       r14,[r9+10]
       mov       r15,[r9+18]
       mov       r13,[r9+20]
       cmp       eax,ebp
       jne       short M24_L01
       mov       rbp,rcx
       sub       rbp,r14
       mov       r14,rbx
       sub       r14,r15
       or        rbp,r14
       mov       r14,rsi
       sub       r14,r13
       or        rbp,r14
       jne       short M24_L01
       mov       rbp,[r9+28]
       and       r11d,0FFFFFFFE
       cmp       r11d,[r9]
       jne       short M24_L02
       mov       rcx,7FFB0F49D708
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,rbp
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M24_L01:
       test      r11d,r11d
       je        short M24_L02
       inc       r10d
       add       r8d,r10d
       mov       r9d,[rdx+8]
       add       r9d,0FFFFFFFE
       and       r8d,r9d
       cmp       r10d,8
       jl        near ptr M24_L00
M24_L02:
       mov       rcx,7FFB0F49D70C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r8,rsi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FFB0EE7FF48]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointerSlow(System.Object, IntPtr, IntPtr)
; Total bytes of code 274
```

## .NET 10.0.0 (10.0.0, 10.0.25.52411), X64 RyuJIT x86-64-v3
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
       jmp       near ptr M00_L47
M00_L00:
       movzx     r8d,word ptr [r15]
       mov       [rcx],r8w
       cmp       r12d,2
       jne       near ptr M00_L49
       jmp       near ptr M00_L68
M00_L01:
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
       jle       short M00_L03
       mov       r8,[rsi+8]
       mov       ecx,[rsi+18]
       test      r8,r8
       je        near ptr M00_L69
       cmp       [r8+8],ecx
       jb        near ptr M00_L103
       mov       edx,ecx
       lea       rdx,[r8+rdx*2+10]
       mov       r8d,[r8+8]
       sub       r8d,ecx
M00_L02:
       cmp       r13d,r8d
       ja        near ptr M00_L96
       mov       r8d,r13d
       add       r8,r8
       mov       rcx,rdx
       mov       rdx,r15
       call      qword ptr [7FFB0ECB5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rsi+8]
       mov       ecx,[rcx+8]
       mov       [rsi+18],ecx
M00_L03:
       mov       eax,r12d
       sub       eax,r13d
       mov       [rsp+84],eax
       mov       ecx,[rsi+1C]
       lea       edx,[rax+rcx]
       mov       r8d,[rsi+18]
       add       edx,r8d
       cmp       edx,[rsi+20]
       jg        near ptr M00_L94
       cmp       edx,eax
       jl        near ptr M00_L94
       add       ecx,r8d
       mov       edx,ecx
       cmp       edx,1F40
       jg        short M00_L06
M00_L04:
       cmp       eax,edx
       jl        short M00_L07
       mov       r8d,eax
M00_L05:
       add       ecx,r8d
       cmp       ecx,r8d
       jl        near ptr M00_L95
       cmp       r8d,400
       jge       short M00_L08
       movsxd    rdx,r8d
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rsp+30],rax
       jmp       short M00_L09
M00_L06:
       mov       edx,1F40
       jmp       short M00_L04
M00_L07:
       mov       r8d,edx
       jmp       short M00_L05
M00_L08:
       mov       ecx,r8d
       xor       edx,edx
       call      qword ptr [7FFB0F2CE298]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       [rsp+30],rax
M00_L09:
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
       je        near ptr M00_L70
       lea       rcx,[r8+10]
       mov       r8d,[r8+8]
M00_L10:
       mov       r15d,[rsp+84]
       cmp       r15d,r8d
       ja        near ptr M00_L96
       mov       r8d,r15d
       add       r8,r8
       call      qword ptr [7FFB0ECB5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       [rsi+18],r15d
       jmp       near ptr M00_L50
M00_L11:
       cmp       edx,7B
       jne       near ptr M00_L66
       xor       r15d,r15d
       xor       r13d,r13d
       xor       r12d,r12d
       xor       r8d,r8d
       add       eax,0FFFFFFD0
       cmp       eax,0A
       jae       near ptr M00_L65
       inc       ebp
       cmp       ebp,7
       jae       near ptr M00_L97
       cmp       ebp,7
       jae       near ptr M00_L104
       mov       edx,ebp
       movzx     edx,word ptr [r14+rdx*2+0C]
       cmp       edx,7D
       je        near ptr M00_L26
       lea       ecx,[rdx-30]
       cmp       ecx,9
       ja        short M00_L13
M00_L12:
       cmp       eax,0F4240
       jge       short M00_L13
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
       jbe       short M00_L12
M00_L13:
       cmp       edx,20
       jne       short M00_L15
M00_L14:
       inc       ebp
       cmp       ebp,7
       jae       near ptr M00_L97
       cmp       ebp,7
       jae       near ptr M00_L104
       mov       edx,ebp
       movzx     edx,word ptr [r14+rdx*2+0C]
       cmp       edx,20
       je        short M00_L14
M00_L15:
       cmp       edx,2C
       jne       near ptr M00_L22
       inc       ebp
       cmp       ebp,7
       jae       near ptr M00_L97
M00_L16:
       mov       edx,ebp
       movzx     edx,word ptr [r14+rdx*2+0C]
       cmp       edx,20
       jne       short M00_L17
       inc       ebp
       cmp       ebp,7
       jb        short M00_L16
       jmp       near ptr M00_L97
M00_L17:
       cmp       edx,2D
       jne       short M00_L18
       mov       r13d,1
       inc       ebp
       cmp       ebp,7
       jae       near ptr M00_L97
       cmp       ebp,7
       jae       near ptr M00_L104
       mov       edx,ebp
       movzx     edx,word ptr [r14+rdx*2+0C]
M00_L18:
       lea       r15d,[rdx-30]
       cmp       r15d,0A
       jae       near ptr M00_L65
       inc       ebp
       cmp       ebp,7
       jae       near ptr M00_L97
M00_L19:
       cmp       ebp,7
       jae       near ptr M00_L104
       mov       edx,ebp
       movzx     edx,word ptr [r14+rdx*2+0C]
       lea       ecx,[rdx-30]
       cmp       ecx,9
       ja        short M00_L20
       cmp       r15d,0F4240
       jge       short M00_L20
       lea       ecx,[r15+r15*4]
       lea       r15d,[rdx+rcx*2-30]
       inc       ebp
       cmp       ebp,7
       jb        short M00_L19
       jmp       near ptr M00_L97
M00_L20:
       cmp       edx,20
       jne       short M00_L22
M00_L21:
       inc       ebp
       cmp       ebp,7
       jae       near ptr M00_L97
       cmp       ebp,7
       jae       near ptr M00_L104
       mov       edx,ebp
       movzx     edx,word ptr [r14+rdx*2+0C]
       cmp       edx,20
       je        short M00_L21
M00_L22:
       cmp       edx,7D
       je        short M00_L26
       cmp       edx,3A
       jne       short M00_L24
       mov       r8d,ebp
       lea       ebp,[r8+1]
       cmp       ebp,7
       jae       near ptr M00_L97
M00_L23:
       cmp       ebp,7
       jae       near ptr M00_L104
       mov       edx,ebp
       movzx     edx,word ptr [r14+rdx*2+0C]
       cmp       edx,7D
       je        short M00_L25
       cmp       edx,7B
       jne       near ptr M00_L72
M00_L24:
       mov       ecx,ebp
       mov       edx,4C
       call      qword ptr [7FFB0F4175A0]
       int       3
M00_L25:
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
M00_L26:
       inc       ebp
       xor       r14d,r14d
       cmp       eax,2
       jae       near ptr M00_L64
       cmp       eax,2
       jae       near ptr M00_L104
       lea       rdx,[rsp+90]
       mov       ecx,eax
       mov       rax,[rdx+rcx*8]
       mov       [rsp+48],rax
       test      r13d,r13d
       je        near ptr M00_L30
       mov       [rsp+74],r8d
M00_L27:
       mov       rdx,rax
       mov       rcx,offset MT_System.ISpanFormattable
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        near ptr M00_L31
       mov       rdx,[rsi+8]
       mov       r9,rdx
       mov       r8d,[rsi+18]
       mov       ecx,r8d
       mov       edx,[rdx+8]
       sub       edx,r8d
       test      r9,r9
       je        near ptr M00_L73
       mov       r8d,edx
       add       r8,rcx
       mov       r11d,[r9+8]
       cmp       r8,r11
       ja        near ptr M00_L103
       lea       r9,[r9+rcx*2+10]
M00_L28:
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
       mov       r11,7FFB0EC00AC0
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L31
       mov       edx,[rsp+88]
       mov       rcx,[rsi+8]
       mov       r8,rcx
       mov       eax,[rsi+18]
       mov       r10d,eax
       mov       r9d,[rcx+8]
       sub       r9d,eax
       test      r8,r8
       je        near ptr M00_L74
       mov       r11d,r9d
       add       r10,r11
       mov       r8d,[r8+8]
       cmp       r10,r8
       ja        near ptr M00_L103
M00_L29:
       cmp       edx,r9d
       jbe       near ptr M00_L75
       jmp       near ptr M00_L99
M00_L30:
       test      r15d,r15d
       mov       [rsp+74],r8d
       je        near ptr M00_L27
M00_L31:
       mov       rdx,[rsp+48]
       mov       rcx,offset MT_System.IFormattable
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       [rsp+40],rax
       test      rax,rax
       jne       short M00_L34
       mov       r12,[rsp+48]
       test      r12,r12
       je        short M00_L32
       mov       rcx,r12
       mov       rax,[r12]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       r12,rax
       jmp       short M00_L33
M00_L32:
       xor       r12d,r12d
M00_L33:
       jmp       short M00_L36
M00_L34:
       mov       rax,[rsp+40]
       mov       ecx,[rsp+74]
       test      ecx,ecx
       je        short M00_L35
       mov       [rsp+60],r12
       mov       [rsp+68],ecx
       lea       rcx,[rsp+60]
       call      System.String.Ctor(System.ReadOnlySpan`1<Char>)
       mov       r14,rax
       mov       rax,[rsp+40]
M00_L35:
       mov       rcx,rax
       mov       r8,rdi
       mov       rdx,r14
       mov       r11,7FFB0EC00AB8
       call      qword ptr [r11]
       mov       r12,rax
M00_L36:
       test      r12,r12
       jne       short M00_L37
       mov       r12,1E8BC270008
M00_L37:
       cmp       [r12+8],r15d
       jge       near ptr M00_L43
       test      r13d,r13d
       jne       short M00_L40
       sub       r15d,[r12+8]
       js        near ptr M00_L102
       test      r15d,r15d
       jne       near ptr M00_L83
M00_L38:
       lea       rdx,[r12+0C]
       mov       r8d,[r12+8]
       test      r8d,r8d
       je        near ptr M00_L52
       mov       rcx,[rsi+8]
       mov       eax,[rsi+18]
       lea       r12d,[rax+r8]
       cmp       r12d,[rcx+8]
       ja        near ptr M00_L86
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jle       near ptr M00_L85
       mov       r8d,r8d
       call      qword ptr [7FFB0F37C5B8]
M00_L39:
       mov       [rsi+18],r12d
       jmp       near ptr M00_L52
M00_L40:
       lea       rdx,[r12+0C]
       mov       r8d,[r12+8]
       test      r8d,r8d
       je        short M00_L42
       mov       rcx,[rsi+8]
       mov       eax,[rsi+18]
       lea       r13d,[rax+r8]
       cmp       r13d,[rcx+8]
       ja        near ptr M00_L80
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jle       near ptr M00_L79
       mov       r8d,r8d
       add       r8,r8
       call      qword ptr [7FFB0ECB5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L41:
       mov       [rsi+18],r13d
M00_L42:
       mov       r14d,r15d
       sub       r14d,[r12+8]
       js        near ptr M00_L101
       test      r14d,r14d
       je        near ptr M00_L52
       jmp       near ptr M00_L81
M00_L43:
       lea       rdx,[r12+0C]
       mov       r8d,[r12+8]
       test      r8d,r8d
       je        near ptr M00_L52
       mov       rcx,[rsi+8]
       mov       eax,[rsi+18]
       lea       r13d,[rax+r8]
       cmp       r13d,[rcx+8]
       ja        near ptr M00_L78
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jle       near ptr M00_L77
       mov       r8d,r8d
       add       r8,r8
       call      qword ptr [7FFB0ECB5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L44:
       mov       [rsi+18],r13d
       jmp       near ptr M00_L52
M00_L45:
       test      r13d,r13d
       je        short M00_L47
       mov       r8,[rsi+8]
       mov       r14d,[rsi+18]
       lea       ecx,[r14+r13]
       cmp       ecx,[r8+8]
       ja        near ptr M00_L54
       movsxd    rcx,r14d
       lea       rcx,[r8+rcx*2+10]
       cmp       r13d,2
       jle       near ptr M00_L53
       mov       r8d,r13d
       add       r8,r8
       mov       rdx,r15
       call      qword ptr [7FFB0ECB5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L46:
       add       r13d,r14d
       mov       [rsi+18],r13d
M00_L47:
       lea       rcx,[rsp+0A0]
       mov       rdx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       call      qword ptr [7FFB0EF34480]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       je        near ptr M00_L67
       mov       r8,[rsp+0A8]
       mov       rdx,1A827400100
       mov       rdi,[rdx]
       mov       rdx,[r8+18]
       mov       r8,[r8+28]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+90],xmm0
       mov       [rsp+90],rdx
       mov       [rsp+98],r8
       xor       ebp,ebp
M00_L48:
       cmp       ebp,7
       ja        near ptr M00_L98
       mov       r14,1E8BC280668
       mov       r8d,ebp
       lea       r15,[r14+r8*2+0C]
       mov       r13d,ebp
       neg       r13d
       add       r13d,7
       mov       r8d,7D
       mov       edx,7B
       mov       rcx,r15
       mov       r9d,r13d
       call      qword ptr [7FFB0EF3C5D0]; System.PackedSpanHelpers.IndexOfAny[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib],[System.PackedSpanHelpers+NopTransform, System.Private.CoreLib]](Int16 ByRef, Int16, Int16, Int32)
       mov       r12d,eax
       test      r12d,r12d
       jl        near ptr M00_L45
       cmp       r12d,r13d
       ja        near ptr M00_L103
       test      r12d,r12d
       je        short M00_L50
       mov       r8,[rsi+8]
       mov       r13d,[rsi+18]
       lea       ecx,[r12+r13]
       cmp       ecx,[r8+8]
       ja        near ptr M00_L01
       movsxd    rcx,r13d
       lea       rcx,[r8+rcx*2+10]
       cmp       r12d,2
       jle       near ptr M00_L00
       mov       r8d,r12d
       add       r8,r8
       mov       rdx,r15
       call      qword ptr [7FFB0ECB5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L49:
       add       r13d,r12d
       mov       [rsi+18],r13d
M00_L50:
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
       jne       near ptr M00_L11
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       r8,[rsi+8]
       cmp       [r8+8],edx
       jbe       near ptr M00_L71
       mov       [r8+rdx*2+10],ax
       inc       ecx
       mov       [rsi+18],ecx
M00_L51:
       inc       ebp
M00_L52:
       cmp       ebp,7
       jae       near ptr M00_L47
       jmp       near ptr M00_L48
M00_L53:
       movzx     r8d,word ptr [r15]
       mov       [rcx],r8w
       cmp       r13d,2
       jne       near ptr M00_L46
       jmp       near ptr M00_L87
M00_L54:
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
       jle       short M00_L56
       mov       r8,[rsi+8]
       mov       ecx,[rsi+18]
       test      r8,r8
       je        near ptr M00_L88
       cmp       [r8+8],ecx
       jb        near ptr M00_L103
       mov       edx,ecx
       lea       rdx,[r8+rdx*2+10]
       mov       r8d,[r8+8]
       sub       r8d,ecx
M00_L55:
       cmp       ebp,r8d
       ja        near ptr M00_L96
       mov       r8d,ebp
       add       r8,r8
       mov       rcx,rdx
       mov       rdx,r15
       call      qword ptr [7FFB0ECB5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rsi+8]
       mov       ecx,[rcx+8]
       mov       [rsi+18],ecx
M00_L56:
       mov       edi,r13d
       sub       edi,ebp
       mov       ecx,[rsi+1C]
       lea       edx,[rdi+rcx]
       mov       eax,[rsi+18]
       add       edx,eax
       cmp       edx,[rsi+20]
       jg        near ptr M00_L91
       cmp       edx,edi
       jl        near ptr M00_L91
       add       ecx,eax
       mov       edx,ecx
       cmp       edx,1F40
       jg        short M00_L59
M00_L57:
       cmp       edi,edx
       jl        short M00_L60
       mov       eax,edi
M00_L58:
       add       ecx,eax
       cmp       ecx,eax
       jl        near ptr M00_L92
       cmp       eax,400
       jge       short M00_L61
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
       jmp       short M00_L62
M00_L59:
       mov       edx,1F40
       jmp       short M00_L57
M00_L60:
       mov       eax,edx
       jmp       short M00_L58
M00_L61:
       mov       ecx,eax
       xor       edx,edx
       call      qword ptr [7FFB0F2CE298]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       r14,rax
M00_L62:
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
M00_L63:
       cmp       edi,r8d
       ja        near ptr M00_L96
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFB0ECB5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       [rsi+18],edi
       jmp       near ptr M00_L47
M00_L64:
       call      qword ptr [7FFB0F4175B8]
       int       3
M00_L65:
       mov       ecx,ebp
       mov       edx,4D
       call      qword ptr [7FFB0F4175A0]
       int       3
M00_L66:
       mov       ecx,ebp
       mov       edx,4B
       call      qword ptr [7FFB0F4175A0]
       int       3
M00_L67:
       mov       rcx,rsi
       call      qword ptr [7FFB0EF10210]; System.Text.StringBuilder.ToString()
       mov       [rsp+78],rax
       mov       rcx,[rbx+18]
       lea       r8,[rsp+78]
       mov       rdx,7FFB0F4074F8
       cmp       [rcx],ecx
       call      qword ptr [7FFB0F37ECD0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
M00_L68:
       movzx     r8d,word ptr [r15+2]
       mov       [rcx+2],r8w
       jmp       near ptr M00_L49
M00_L69:
       test      ecx,ecx
       jne       near ptr M00_L103
       xor       edx,edx
       xor       r8d,r8d
       jmp       near ptr M00_L02
M00_L70:
       xor       ecx,ecx
       xor       r8d,r8d
       jmp       near ptr M00_L10
M00_L71:
       mov       rcx,rsi
       mov       edx,eax
       call      qword ptr [7FFB0EE5F348]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L51
M00_L72:
       inc       ebp
       cmp       ebp,7
       jb        near ptr M00_L23
       jmp       near ptr M00_L97
M00_L73:
       or        ecx,edx
       jne       near ptr M00_L103
       xor       r9d,r9d
       xor       edx,edx
       jmp       near ptr M00_L28
M00_L74:
       or        r10d,r9d
       jne       near ptr M00_L103
       xor       r9d,r9d
       jmp       near ptr M00_L29
M00_L75:
       add       eax,[rsp+88]
       mov       [rsi+18],eax
       test      r13d,r13d
       je        near ptr M00_L52
       cmp       r15d,[rsp+88]
       jle       near ptr M00_L52
       sub       r15d,[rsp+88]
       js        near ptr M00_L100
       test      r15d,r15d
       je        near ptr M00_L52
       mov       edx,eax
       mov       r8d,r15d
       lea       rax,[rdx+r8]
       mov       r10d,[rcx+8]
       cmp       rax,r10
       ja        short M00_L76
       lea       rcx,[rcx+rdx*2+10]
       mov       rdx,r8
       mov       r8d,20
       call      qword ptr [7FFB0F157210]; System.SpanHelpers.Fill[[System.Char, System.Private.CoreLib]](Char ByRef, UIntPtr, Char)
       add       [rsi+18],r15d
       jmp       near ptr M00_L52
M00_L76:
       mov       rcx,rsi
       mov       r8d,r15d
       mov       edx,20
       call      qword ptr [7FFB0F417690]
       jmp       near ptr M00_L52
M00_L77:
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       jne       near ptr M00_L44
       movzx     edx,word ptr [rdx+2]
       mov       [rcx+2],dx
       jmp       near ptr M00_L44
M00_L78:
       mov       rcx,rsi
       call      qword ptr [7FFB0EE5F180]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M00_L52
M00_L79:
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       jne       near ptr M00_L41
       movzx     edx,word ptr [rdx+2]
       mov       [rcx+2],dx
       jmp       near ptr M00_L41
M00_L80:
       mov       rcx,rsi
       call      qword ptr [7FFB0EE5F180]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M00_L42
M00_L81:
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+18]
       mov       eax,r14d
       lea       r8,[rcx+rax]
       mov       r10d,[rdx+8]
       cmp       r8,r10
       ja        short M00_L82
       lea       rcx,[rdx+rcx*2+10]
       mov       rdx,rax
       mov       r8d,20
       call      qword ptr [7FFB0F157210]; System.SpanHelpers.Fill[[System.Char, System.Private.CoreLib]](Char ByRef, UIntPtr, Char)
       add       [rsi+18],r14d
       jmp       near ptr M00_L52
M00_L82:
       mov       rcx,rsi
       mov       r8d,r14d
       mov       edx,20
       call      qword ptr [7FFB0F417690]
       jmp       near ptr M00_L52
M00_L83:
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+18]
       mov       eax,r15d
       lea       r8,[rcx+rax]
       mov       r10d,[rdx+8]
       cmp       r8,r10
       ja        short M00_L84
       lea       rcx,[rdx+rcx*2+10]
       mov       rdx,rax
       mov       r8d,20
       call      qword ptr [7FFB0F157210]; System.SpanHelpers.Fill[[System.Char, System.Private.CoreLib]](Char ByRef, UIntPtr, Char)
       add       [rsi+18],r15d
       jmp       near ptr M00_L38
M00_L84:
       mov       rcx,rsi
       mov       r8d,r15d
       mov       edx,20
       call      qword ptr [7FFB0F417690]
       jmp       near ptr M00_L38
M00_L85:
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       jne       near ptr M00_L39
       movzx     edx,word ptr [rdx+2]
       mov       [rcx+2],dx
       jmp       near ptr M00_L39
M00_L86:
       mov       rcx,rsi
       call      qword ptr [7FFB0EE5F180]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M00_L52
M00_L87:
       movzx     r8d,word ptr [r15+2]
       mov       [rcx+2],r8w
       jmp       near ptr M00_L46
M00_L88:
       test      ecx,ecx
       jne       near ptr M00_L103
       xor       edx,edx
       xor       r8d,r8d
       jmp       near ptr M00_L55
M00_L89:
       xor       ecx,ecx
       xor       r8d,r8d
       jmp       near ptr M00_L63
M00_L90:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,19685
       mov       rdx,7FFB0EBF4000
       call      qword ptr [7FFB0EF37738]
       mov       rsi,rax
       call      qword ptr [7FFB0F416F58]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFB0F245F68]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L91:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,1969B
       mov       rdx,7FFB0EBF4000
       call      qword ptr [7FFB0EF37738]
       mov       rsi,rax
       call      qword ptr [7FFB0F416F70]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFB0F245F68]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L92:
       mov       rcx,offset MT_System.OutOfMemoryException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB0F416F88]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L93:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,19685
       mov       rdx,7FFB0EBF4000
       call      qword ptr [7FFB0EF37738]
       mov       rsi,rax
       call      qword ptr [7FFB0F416F58]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFB0F245F68]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L94:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,1969B
       mov       rdx,7FFB0EBF4000
       call      qword ptr [7FFB0EF37738]
       mov       rsi,rax
       call      qword ptr [7FFB0F416F70]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFB0F245F68]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L95:
       mov       rcx,offset MT_System.OutOfMemoryException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFB0F416F88]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L96:
       call      qword ptr [7FFB0F15C258]
       int       3
M00_L97:
       mov       ecx,ebp
       mov       edx,4C
       call      qword ptr [7FFB0F4175A0]
       int       3
M00_L98:
       mov       ecx,21
       call      qword ptr [7FFB0EF37870]
       int       3
M00_L99:
       call      qword ptr [7FFB0F4175D0]
       int       3
M00_L100:
       mov       ecx,1966D
       mov       rdx,7FFB0EBF4000
       call      qword ptr [7FFB0EF37738]
       mov       rdx,rax
       mov       ecx,r15d
       call      qword ptr [7FFB0F415740]
       int       3
M00_L101:
       mov       ecx,1966D
       mov       rdx,7FFB0EBF4000
       call      qword ptr [7FFB0EF37738]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FFB0F415740]
       int       3
M00_L102:
       mov       ecx,1966D
       mov       rdx,7FFB0EBF4000
       call      qword ptr [7FFB0EF37738]
       mov       rdx,rax
       mov       ecx,r15d
       call      qword ptr [7FFB0F415740]
       int       3
M00_L103:
       call      qword ptr [7FFB0EE57138]
       int       3
M00_L104:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 3811
```
```assembly
; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M01_L10
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M01_L10
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       jbe       near ptr M01_L06
       cmp       r8,40
       ja        short M01_L03
M01_L00:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       jbe       short M01_L01
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M01_L01
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
M01_L01:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
M01_L02:
       vzeroupper
       ret
M01_L03:
       cmp       r8,800
       ja        near ptr M01_L11
       cmp       r8,100
       jae       short M01_L08
M01_L04:
       mov       r9,r8
       shr       r9,6
M01_L05:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M01_L05
       and       r8,3F
       cmp       r8,10
       ja        short M01_L00
       jmp       short M01_L01
M01_L06:
       test      r8b,18
       jne       short M01_L07
       test      r8b,4
       jne       short M01_L09
       test      r8,r8
       je        short M01_L02
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M01_L02
       movsx     rcx,word ptr [rax-2]
       mov       [r10-2],cx
       jmp       short M01_L02
M01_L07:
       mov       rdx,[rdx]
       mov       [rcx],rdx
       mov       rcx,[rax-8]
       mov       [r10-8],rcx
       jmp       near ptr M01_L02
M01_L08:
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
       jmp       near ptr M01_L04
M01_L09:
       mov       edx,[rdx]
       mov       [rcx],edx
       mov       ecx,[rax-4]
       mov       [r10-4],ecx
       jmp       near ptr M01_L02
M01_L10:
       cmp       rcx,rdx
       jne       short M01_L11
       cmp       [rdx],dl
       jmp       near ptr M01_L02
M01_L11:
       cmp       [rcx],cl
       cmp       [rdx],dl
       vzeroupper
       jmp       qword ptr [7FFB0ECB66E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 327
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
       mov       rax,7FFB0EE10AF8
       mov       [rbp-68],rax
       lea       rax,[M02_L00]
       mov       [rbp-58],rax
       lea       rax,[rbp-78]
       mov       [rdi+8],rax
       mov       byte ptr [rdi+4],0
       mov       rax,7FFB6E8D0510
       call      rax
M02_L00:
       mov       byte ptr [rdi+4],1
       cmp       dword ptr [7FFB6EC1F778],0
       je        short M02_L01
       call      qword ptr [7FFB6EC0D608]; CORINFO_HELP_STOP_FOR_GC
M02_L01:
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
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rdx,rdx
       je        short M03_L05
       mov       rax,[rdx]
       movzx     r8d,word ptr [rax+0E]
       test      r8,r8
       je        short M03_L04
       mov       r10,[rax+38]
       cmp       r8,4
       jl        short M03_L02
       cmp       [r10],rcx
       je        short M03_L05
M03_L00:
       cmp       [r10+8],rcx
       je        short M03_L05
       cmp       [r10+10],rcx
       je        short M03_L05
       cmp       [r10+18],rcx
       je        short M03_L05
       add       r10,20
       add       r8,0FFFFFFFFFFFFFFFC
       cmp       r8,4
       jl        short M03_L01
       cmp       [r10],rcx
       je        short M03_L05
       jmp       short M03_L00
M03_L01:
       test      r8,r8
       je        short M03_L04
M03_L02:
       cmp       [r10],rcx
       je        short M03_L05
M03_L03:
       add       r10,8
       dec       r8
       test      r8,r8
       jg        short M03_L06
M03_L04:
       test      dword ptr [rax],500C0000
       jne       short M03_L07
       xor       edx,edx
M03_L05:
       mov       rax,rdx
       ret
M03_L06:
       cmp       [r10],rcx
       je        short M03_L05
       jmp       short M03_L03
M03_L07:
       jmp       qword ptr [7FFB0F0BD4B8]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
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
       je        short M04_L00
       mov       edx,esi
       mov       rcx,offset MT_System.String
       call      00007FFB6E908D20
       mov       rdi,rax
       cmp       [rdi],dil
       lea       rcx,[rdi+0C]
       mov       r8d,esi
       add       r8,r8
       mov       rdx,rbx
       call      qword ptr [7FFB0ECB5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rdi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M04_L00:
       mov       rax,1E8BC270008
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 88
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
       jne       short M05_L01
       mov       ecx,[rbx+14]
       cmp       ecx,[rdx+10]
       jae       short M05_L00
       mov       rdx,[rdx+8]
       cmp       ecx,[rdx+8]
       jae       short M05_L02
       mov       ecx,ecx
       mov       rdx,[rdx+rcx*8+10]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       dword ptr [rbx+14]
       mov       eax,1
       add       rsp,20
       pop       rbx
       ret
M05_L00:
       xor       eax,eax
       mov       [rbx+8],rax
       mov       dword ptr [rbx+14],0FFFFFFFF
       add       rsp,20
       pop       rbx
       ret
M05_L01:
       call      qword ptr [7FFB0EF3C0D8]
       int       3
M05_L02:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 101
```
```assembly
; System.PackedSpanHelpers.IndexOfAny[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib],[System.PackedSpanHelpers+NopTransform, System.Private.CoreLib]](Int16 ByRef, Int16, Int16, Int32)
       cmp       r9d,8
       jge       near ptr M06_L13
       xor       r10d,r10d
       cmp       r9d,4
       jl        near ptr M06_L11
       add       r9d,0FFFFFFFC
       movsx     r11,word ptr [rcx]
       movsx     rax,dx
       cmp       r11d,eax
       jne       short M06_L01
M06_L00:
       xor       eax,eax
       vzeroupper
       ret
M06_L01:
       movsx     rax,r8w
       cmp       r11d,eax
       je        short M06_L00
       movsx     r11,word ptr [rcx+2]
       movsx     rax,dx
       cmp       r11d,eax
       jne       short M06_L03
M06_L02:
       mov       eax,1
       vzeroupper
       ret
M06_L03:
       movsx     rax,r8w
       cmp       r11d,eax
       je        short M06_L02
       movsx     r11,word ptr [rcx+4]
       movsx     r10,dx
       cmp       r11d,r10d
       je        short M06_L04
       movsx     rax,r8w
       cmp       r11d,eax
       sete      r11b
       movzx     r11d,r11b
       test      r11d,r11d
       je        short M06_L05
M06_L04:
       mov       eax,2
       vzeroupper
       ret
M06_L05:
       movsx     r11,word ptr [rcx+6]
       movsx     rax,dx
       cmp       r11d,eax
       je        short M06_L06
       movsx     rax,r8w
       cmp       r11d,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M06_L07
M06_L06:
       mov       eax,3
       jmp       near ptr M06_L20
M06_L07:
       mov       r10d,4
       test      r9d,r9d
       jle       short M06_L12
M06_L08:
       dec       r9d
       movsx     r11,word ptr [rcx+r10*2]
       movsx     rax,dx
       cmp       r11d,eax
       je        short M06_L09
       movsx     rax,r8w
       cmp       r11d,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M06_L10
M06_L09:
       mov       eax,r10d
       jmp       near ptr M06_L20
M06_L10:
       inc       r10
M06_L11:
       test      r9d,r9d
       jg        short M06_L08
M06_L12:
       mov       eax,0FFFFFFFF
       jmp       near ptr M06_L20
M06_L13:
       mov       rax,rcx
       cmp       r9d,10
       jle       near ptr M06_L18
       vmovd     xmm0,edx
       vpbroadcastb ymm0,xmm0
       vmovd     xmm1,r8d
       vpbroadcastb ymm1,xmm1
       cmp       r9d,20
       jle       short M06_L16
       lea       edx,[r9-20]
       movsxd    r8,edx
       lea       rdx,[rax+r8*2]
M06_L14:
       vmovups   ymm2,[rax]
       vpackuswb ymm2,ymm2,[rax+20]
       vpcmpeqb  ymm3,ymm0,ymm2
       vpcmpeqb  ymm2,ymm1,ymm2
       vpor      ymm2,ymm2,ymm3
       vptest    ymm2,ymm2
       jne       short M06_L15
       add       rax,40
       cmp       rax,rdx
       jb        short M06_L14
       jmp       short M06_L16
M06_L15:
       sub       rax,rcx
       shr       rax,1
       vpermq    ymm0,ymm2,0D8
       vpmovmskb r9d,ymm0
       xor       ecx,ecx
       tzcnt     ecx,r9d
       add       eax,ecx
       jmp       near ptr M06_L20
M06_L16:
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
       je        near ptr M06_L12
       vpermq    ymm0,ymm0,0D8
       vpmovmskb r8d,ymm0
       tzcnt     r8d,r8d
       cmp       r8d,10
       jl        short M06_L17
       mov       rax,rdx
       add       r8d,0FFFFFFF0
M06_L17:
       sub       rax,rcx
       shr       rax,1
       add       eax,r8d
       jmp       short M06_L20
M06_L18:
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
       je        near ptr M06_L12
       vpmovmskb r8d,xmm0
       tzcnt     r8d,r8d
       cmp       r8d,8
       jl        short M06_L19
       mov       rdx,rax
       add       r8d,0FFFFFFF8
M06_L19:
       sub       rdx,rcx
       shr       rdx,1
       lea       eax,[rdx+r8]
M06_L20:
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
       je        short M07_L02
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFB6E908D20
       mov       rsi,rax
M07_L00:
       mov       r8d,[rbx+18]
       test      r8d,r8d
       jle       short M07_L01
       mov       rdx,[rbx+8]
       mov       ecx,[rbx+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rsi+8]
       ja        short M07_L03
       cmp       [rdx+8],r8d
       jb        short M07_L03
       movsxd    rcx,ecx
       lea       rcx,[rsi+rcx*2+0C]
       movsxd    r8,r8d
       add       r8,r8
       add       rdx,10
       call      qword ptr [7FFB0ECB5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M07_L01:
       mov       rbx,[rbx+10]
       test      rbx,rbx
       jne       short M07_L00
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M07_L02:
       mov       rax,1E8BC270008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M07_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,19655
       mov       rdx,7FFB0EBF4000
       call      qword ptr [7FFB0EF37738]
       mov       rbx,rax
       call      qword ptr [7FFB0F415CC8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB0F245F68]
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
; System.Text.StringBuilder.AppendWithExpansion(Char)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       mov       rcx,rbx
       mov       edx,1
       call      qword ptr [7FFB6E732850]; Precode of System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFB6E717FC0]
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
       jg        near ptr M11_L05
       cmp       eax,esi
       jl        near ptr M11_L05
       mov       rax,[rbx+8]
       mov       ebp,[rax+8]
       sub       ebp,ecx
       test      ebp,ebp
       jle       short M11_L01
       test      rax,rax
       je        near ptr M11_L06
       mov       edx,[rax+8]
       cmp       edx,ecx
       jb        near ptr M11_L07
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
       call      qword ptr [7FFB0ECB5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M11_L01:
       sub       esi,ebp
       mov       ecx,[rbx+1C]
       lea       edx,[rsi+rcx]
       mov       eax,[rbx+18]
       add       edx,eax
       cmp       edx,[rbx+20]
       jg        near ptr M11_L08
       cmp       edx,esi
       jl        near ptr M11_L08
       add       ecx,eax
       mov       edx,ecx
       mov       eax,1F40
       cmp       edx,1F40
       cmovg     edx,eax
       cmp       esi,edx
       mov       eax,edx
       cmovge    eax,esi
       add       ecx,eax
       cmp       ecx,eax
       jl        near ptr M11_L09
       cmp       eax,400
       jl        short M11_L02
       mov       ecx,eax
       xor       edx,edx
       call      qword ptr [7FFB0F2CE298]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       r14,rax
       jmp       short M11_L03
M11_L02:
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
M11_L03:
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
M11_L04:
       cmp       esi,r8d
       ja        near ptr M11_L11
       mov       r8d,esi
       add       r8,r8
       call      qword ptr [7FFB0ECB5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       [rbx+18],esi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M11_L05:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,19685
       mov       rdx,7FFB0EBF4000
       call      qword ptr [7FFB0EF37738]
       mov       rsi,rax
       call      qword ptr [7FFB0F416F58]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFB0F245F68]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M11_L06:
       test      ecx,ecx
       jne       short M11_L07
       xor       eax,eax
       xor       edx,edx
       jmp       near ptr M11_L00
M11_L07:
       call      qword ptr [7FFB0EE57138]
       int       3
M11_L08:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,1969B
       mov       rdx,7FFB0EBF4000
       call      qword ptr [7FFB0EF37738]
       mov       rsi,rax
       call      qword ptr [7FFB0F416F70]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFB0F245F68]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M11_L09:
       mov       rcx,offset MT_System.OutOfMemoryException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB0F416F88]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M11_L10:
       xor       ecx,ecx
       xor       r8d,r8d
       jmp       near ptr M11_L04
M11_L11:
       call      qword ptr [7FFB0F15C258]
       int       3
; Total bytes of code 617
```

## .NET 10.0.0 (10.0.0, 10.0.25.52411), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark.BuiltInTypes()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       call      qword ptr [7FFB0F39ED60]; DotNetTips.Spargine.Core.TypeHelper.get_BuiltInTypes()
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
       mov       rbx,2313A4020C8
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
       call      qword ptr [7FFB0FABDF98]
       int       3
M01_L07:
       call      qword ptr [7FFB0F39ED90]; DotNetTips.Spargine.Core.TypeHelper.ComputeBuiltInTypes()
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
       mov       r11,7FFB0EC30C08
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       near ptr M01_L01
M01_L10:
       mov       rcx,2313A401AE8
       mov       rdx,[rcx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L05
M01_L11:
       mov       ecx,28F
       mov       rdx,7FFB0EC24000
       call      qword ptr [7FFB0EF677B0]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FFB0F725D88]
       int       3
M01_L12:
       mov       rcx,rbx
       mov       rdx,r13
       mov       r11,7FFB0EC30C10
       xor       r8d,r8d
       call      qword ptr [r11]
       jmp       near ptr M01_L04
M01_L13:
       mov       rcx,offset MT_System.Collections.Generic.List<System.Type>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB0F0F64A8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<System.Type>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFB0F195AB8]; System.Collections.ObjectModel.ReadOnlyCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IList`1<System.__Canon>)
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

## .NET 10.0.0 (10.0.0, 10.0.25.52411), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark.CreateNormal()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rcx,195ACAF0668
       mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person
       mov       eax,[rax]
       and       eax,0C0000
       cmp       eax,40000
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M00_L01
       call      qword ptr [7FFB0ECC7BE8]; System.RuntimeType.CreateInstanceOfT()
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
       call      qword ptr [7FFB0F426F70]
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
       call      qword ptr [7FFB0ECCC510]; System.RuntimeType+IGenericCacheEntry`1[[System.__Canon, System.Private.CoreLib]].CreateAndCache(System.RuntimeType)
       mov       rsi,rax
       jmp       short M01_L02
M01_L04:
       mov       rcx,rbx
       call      qword ptr [7FFB0ECC7C48]; System.RuntimeType.InitializeCache()
       jmp       near ptr M01_L00
M01_L05:
       mov       rcx,offset MT_System.MissingMethodException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB0F426FB8]
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFB0F426FD0]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFB0F426FE8]
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
       call      qword ptr [7FFB0F427000]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 282
```

## .NET 10.0.0 (10.0.0, 10.0.25.52411), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark.FindDerivedTypes()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       call      qword ptr [7FFB0F3AEE50]; System.AppDomain.get_CurrentDomain()
       mov       rdx,rax
       mov       rcx,rbx
       mov       r8,1B577810668
       mov       r9d,1
       call      qword ptr [7FFB0F3AEE68]; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark.FindDerivedTypesNoCache(System.AppDomain, System.Type, Boolean)
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
; Total bytes of code 84
```
```assembly
; System.AppDomain.get_CurrentDomain()
       push      rbx
       sub       rsp,20
       mov       rbx,174E28020C0
       cmp       qword ptr [rbx],0
       je        short M01_L01
M01_L00:
       mov       rax,[rbx]
       add       rsp,20
       pop       rbx
       ret
M01_L01:
       mov       rcx,offset MT_System.AppDomain
       call      CORINFO_HELP_NEWSFAST
       mov       dword ptr [rax+28],1
       mov       rdx,rax
       mov       rcx,174E28020C0
       xor       r8d,r8d
       call      00007FFB6E8BFBA0
       jmp       short M01_L00
; Total bytes of code 75
```
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark.FindDerivedTypesNoCache(System.AppDomain, System.Type, Boolean)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0B8
       vzeroupper
       lea       rbp,[rsp+0F0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-60],ymm4
       mov       [rbp+20],r8
       mov       [rbp+28],r9d
       mov       rbx,rdx
       lea       rcx,[rbp-98]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rcx,rsp
       mov       [rbp-80],rcx
       mov       rcx,rbp
       mov       [rbp-70],rcx
       test      rbx,rbx
       je        near ptr M02_L18
       cmp       qword ptr [rbp+20],0
       je        near ptr M02_L19
       mov       rcx,[rbp+20]
       mov       [rbp+20],rcx
       xor       ecx,ecx
       mov       [rbp-50],rcx
       lea       rcx,[rbp-50]
       mov       rax,7FFB0EF77EF0
       mov       [rbp-88],rax
       lea       rax,[M02_L00]
       mov       [rbp-78],rax
       lea       rax,[rbp-98]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFB6EA80350
       call      rax
M02_L00:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFB6EC1F778],0
       je        short M02_L01
       call      qword ptr [7FFB6EC0D608]; CORINFO_HELP_STOP_FOR_GC
M02_L01:
       mov       rcx,[rbp-90]
       mov       [rsi+8],rcx
       mov       rbx,[rbp-50]
       xor       ecx,ecx
       mov       [rbp-50],rcx
       mov       rcx,offset MT_System.Collections.Generic.List<System.Type>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,174E2801AE8
       mov       rdx,[rcx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp-0B0],rsi
       mov       [rbp-0B8],rbx
       xor       ecx,ecx
       mov       [rbp-3C],ecx
       jmp       short M02_L03
M02_L02:
       mov       edx,[rbp-3C]
       inc       edx
       mov       [rbp-3C],edx
       mov       rbx,[rbp-0B8]
M02_L03:
       mov       ecx,[rbx+8]
       cmp       ecx,[rbp-3C]
       jle       near ptr M02_L15
       mov       ecx,[rbp-3C]
       mov       rsi,[rbx+rcx*8+10]
       mov       rcx,offset MT_System.Reflection.RuntimeAssembly
       cmp       [rsi],rcx
       jne       near ptr M02_L12
       mov       rcx,rsi
       call      00007FFB6E8DCC30
       test      rax,rax
       je        near ptr M02_L11
M02_L04:
       cmp       [rax],al
       xor       ecx,ecx
       mov       [rbp-58],rcx
       mov       [rbp-60],rax
       mov       rcx,[rbp-60]
       mov       rcx,[rcx+18]
       lea       rdx,[rbp-60]
       mov       [rbp-0A8],rdx
       mov       [rbp-0A0],rcx
       lea       rcx,[rbp-0A8]
       lea       rdx,[rbp-58]
       call      00007FFB0FB98AF8
       mov       rdi,[rbp-58]
       xor       ecx,ecx
       mov       [rbp-58],rcx
       mov       [rbp-60],rcx
M02_L05:
       mov       rsi,offset MT_DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark+<LoadDerivedTypes>d__3
       mov       rcx,rsi
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       dword ptr [r14+38],0FFFFFFFE
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [r14+3C],eax
       lea       rcx,[r14+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+28]
       mov       rdx,[rbp+20]
       call      CORINFO_HELP_ASSIGN_REF
       movzx     edi,byte ptr [rbp+28]
       mov       [r14+41],dil
       cmp       dword ptr [r14+38],0FFFFFFFE
       jne       near ptr M02_L13
       mov       r15d,[r14+3C]
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       cmp       r15d,eax
       jne       near ptr M02_L13
       xor       ecx,ecx
       mov       [r14+38],ecx
       mov       r15,r14
M02_L06:
       mov       rdx,[r14+18]
       lea       rcx,[r15+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[r14+28]
       lea       rcx,[r15+20]
       call      CORINFO_HELP_ASSIGN_REF
       movzx     ecx,byte ptr [r14+41]
       mov       [r15+40],cl
       mov       [rbp-0C0],r15
M02_L07:
       mov       rcx,[rbp-0C0]
       call      qword ptr [7FFB0F5EF3F8]; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark+<LoadDerivedTypes>d__3.MoveNext()
       test      eax,eax
       je        short M02_L09
       mov       rcx,[rbp-0C0]
       mov       r8,[rcx+8]
       mov       rsi,[rbp-0B0]
       inc       dword ptr [rsi+14]
       mov       rcx,[rsi+8]
       mov       r14d,[rsi+10]
       cmp       [rcx+8],r14d
       ja        short M02_L08
       mov       rcx,rsi
       mov       rdx,r8
       call      qword ptr [7FFB0EE8E370]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M02_L07
M02_L08:
       lea       edx,[r14+1]
       mov       [rsi+10],edx
       mov       edx,r14d
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       short M02_L07
M02_L09:
       mov       rcx,[rbp-0C0]
       mov       ecx,[rcx+38]
       cmp       ecx,0FFFFFFFD
       je        short M02_L14
       dec       ecx
       cmp       ecx,1
       jbe       short M02_L14
M02_L10:
       mov       rcx,[rbp-0C0]
       xor       edx,edx
       mov       [rcx+30],rdx
       mov       rcx,[rbp-0C0]
       mov       dword ptr [rcx+38],0FFFFFFFE
       jmp       near ptr M02_L02
M02_L11:
       mov       rcx,rsi
       call      qword ptr [7FFB0F185B30]; System.Reflection.RuntimeAssembly.<GetManifestModule>g__GetManifestModuleWorker|93_0(System.Reflection.RuntimeAssembly)
       jmp       near ptr M02_L04
M02_L12:
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rdi,rax
       jmp       near ptr M02_L05
M02_L13:
       mov       rcx,rsi
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       xor       eax,eax
       mov       [r15+38],eax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [r15+3C],eax
       jmp       near ptr M02_L06
M02_L14:
       mov       rcx,[rbp-0C0]
       call      qword ptr [7FFB0F5A7CA8]; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark+<LoadDerivedTypes>d__3.<>m__Finally1()
       jmp       short M02_L10
M02_L15:
       mov       rsi,[rbp-0B0]
       mov       ebx,[rsi+10]
       test      ebx,ebx
       je        near ptr M02_L20
       movsxd    rdx,ebx
       mov       rcx,offset MT_System.Type[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       mov       rsi,[rsi+8]
       test      rsi,rsi
       je        near ptr M02_L24
       mov       rcx,[rsi]
       cmp       rcx,[rdi]
       jne       near ptr M02_L25
       cmp       dword ptr [rcx+4],18
       jne       near ptr M02_L25
       cmp       ebx,[rsi+8]
       ja        near ptr M02_L25
       cmp       ebx,[rdi+8]
       ja        near ptr M02_L25
       mov       r8d,ebx
       movzx     edx,word ptr [rcx]
       imul      r8,rdx
       lea       rdx,[rsi+10]
       lea       rax,[rdi+10]
       test      dword ptr [rcx],1000000
       je        near ptr M02_L23
       cmp       r8,4000
       ja        near ptr M02_L22
       mov       rcx,rax
       call      00007FFB6E8B5D60
       cmp       dword ptr [7FFB6EC1F778],0
       jne       near ptr M02_L21
M02_L16:
       cmp       dword ptr [rdi+8],0
       je        near ptr M02_L27
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<System.Type>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
M02_L17:
       mov       rax,rbx
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
M02_L18:
       call      qword ptr [7FFB0F2FE268]
       mov       ecx,111
       mov       rdx,7FFB0F0343A0
       call      qword ptr [7FFB0EF67738]
       mov       rbx,rax
       mov       ecx,1B61
       mov       rdx,7FFB0F035D88
       call      qword ptr [7FFB0EF67738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB0ECE7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,10F
       mov       rdx,7FFB0F0343A0
       call      qword ptr [7FFB0EF67738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB0ECE7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB102A45D0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB1013F8A0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M02_L19:
       call      qword ptr [7FFB0F2FE268]
       mov       ecx,12D
       mov       rdx,7FFB0F0343A0
       call      qword ptr [7FFB0EF67738]
       mov       rbx,rax
       mov       ecx,1B61
       mov       rdx,7FFB0F035D88
       call      qword ptr [7FFB0EF67738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB0ECE7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,10F
       mov       rdx,7FFB0F0343A0
       call      qword ptr [7FFB0EF67738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB0ECE7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB102A45D0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB1013F8A0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M02_L20:
       mov       rcx,174E2801AE8
       mov       rdi,[rcx]
       jmp       near ptr M02_L16
M02_L21:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M02_L16
M02_L22:
       mov       rcx,rax
       call      qword ptr [7FFB0F2FDB60]
       jmp       near ptr M02_L16
M02_L23:
       mov       rcx,rax
       call      qword ptr [7FFB0ECE5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M02_L16
M02_L24:
       xor       r14d,r14d
       jmp       short M02_L26
M02_L25:
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFB1013EF88]; System.Array.GetLowerBound(Int32)
       mov       r14d,eax
M02_L26:
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FFB1013EF88]; System.Array.GetLowerBound(Int32)
       mov       r9d,eax
       mov       [rsp+20],ebx
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rsi
       mov       edx,r14d
       mov       r8,rdi
       call      qword ptr [7FFB1013D5D8]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M02_L16
M02_L27:
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<System.Type>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,174E28024F0
       mov       rbx,[rax]
       jmp       near ptr M02_L17
       sub       rsp,38
       vzeroupper
       mov       rcx,[rbp-0C0]
       mov       ebx,[rcx+38]
       cmp       ebx,0FFFFFFFD
       je        short M02_L28
       dec       ebx
       cmp       ebx,1
       ja        short M02_L29
M02_L28:
       mov       rcx,[rbp-0C0]
       call      qword ptr [7FFB0F5A7CA8]; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark+<LoadDerivedTypes>d__3.<>m__Finally1()
M02_L29:
       mov       rcx,[rbp-0C0]
       xor       eax,eax
       mov       [rcx+30],rax
       mov       rcx,[rbp-0C0]
       mov       dword ptr [rcx+38],0FFFFFFFE
       add       rsp,38
       ret
       sub       rsp,38
       vzeroupper
       mov       dword ptr [rbp-48],2C
       lea       rdx,[rbp-48]
       call      qword ptr [7FFB0F3AEF40]
       mov       rcx,rax
       call      qword ptr [7FFB0F3AEF58]
       lea       rax,[M02_L02]
       add       rsp,38
       ret
; Total bytes of code 1572
```

## .NET 10.0.0 (10.0.0, 10.0.25.52411), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark.GetAllAbstractMethods()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,2CDC7B57028
       call      qword ptr [7FFB0F38E778]; DotNetTips.Spargine.Core.TypeHelper.GetAllAbstractMethods(System.Type)
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
; 		if (_commonCache.TryGetValue<MethodInfo[]>(cacheKey, out var cachedMethods))
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			return Array.AsReadOnly(cachedMethods!);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var methods = type.GetTypeInfo().DeclaredMethods.Where(m => m.IsAbstract).ToArray();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		_commonCache.AddCacheItem(cacheKey, methods, TimeSpan.FromMinutes(5));
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
       sub       rsp,78
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+50],ymm4
       mov       rbx,rcx
       test      rbx,rbx
       je        near ptr M01_L45
       mov       rcx,offset MT_System.RuntimeType
       cmp       [rbx],rcx
       jne       near ptr M01_L50
       cmp       qword ptr [rbx+10],0
       je        short M01_L00
       mov       rcx,[rbx+10]
       mov       rsi,[rcx]
       test      rsi,rsi
       jne       short M01_L02
M01_L00:
       mov       [rsp+0C0],rbx
       mov       rcx,rbx
       call      qword ptr [7FFB0ECD7C48]; System.RuntimeType.InitializeCache()
       mov       rdi,rax
       mov       rbx,[rsp+0C0]
M01_L01:
       mov       rsi,[rdi+20]
       test      rsi,rsi
       jne       near ptr M01_L10
       mov       [rsp+38],rdi
       mov       rcx,[rdi+8]
       cmp       [rcx],ecx
       call      qword ptr [7FFB0ECDC6C0]; System.Type.GetRootElementType()
       mov       rsi,rax
       mov       [rsp+30],rsi
       mov       rcx,offset MT_System.RuntimeType
       cmp       [rsi],rcx
       jne       near ptr M01_L21
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
       jne       short M01_L07
       mov       rcx,offset MT_System.RuntimeType
       cmp       [rsi],rcx
       jne       near ptr M01_L22
       mov       rcx,rsi
       call      qword ptr [7FFB0ECDC6C0]; System.Type.GetRootElementType()
       mov       rcx,rax
       mov       rax,offset MT_System.RuntimeType
       cmp       [rcx],rax
       jne       near ptr M01_L46
M01_L05:
       test      rcx,rcx
       je        near ptr M01_L47
       call      00007FFB6E8C2E70
M01_L06:
       test      eax,eax
       jne       near ptr M01_L48
M01_L07:
       mov       rcx,offset MT_System.RuntimeType
       cmp       [rsi],rcx
       jne       near ptr M01_L23
       mov       [rsp+0C0],rbx
       mov       rcx,[rsi+18]
       mov       rax,7FFB6E8C06C0
       vzeroupper
       call      rax
       movzx     ebx,al
       cmp       dword ptr [7FFB6EC1F778],0
       jne       near ptr M01_L49
M01_L08:
       cmp       ebx,1B
       mov       rbx,[rsp+0C0]
       je        near ptr M01_L48
M01_L09:
       mov       rdi,[rsp+38]
       lea       rdx,[rdi+20]
       mov       rcx,rdi
       mov       r8d,3
       call      qword ptr [7FFB0EE74A80]; System.RuntimeType+RuntimeTypeCache.ConstructName(System.String ByRef, System.TypeNameFormatFlags)
       mov       rsi,rax
M01_L10:
       test      rsi,rsi
       je        near ptr M01_L51
       mov       edi,[rsi+8]
       test      edi,edi
       je        near ptr M01_L51
       mov       ebp,edi
       lea       edx,[rbp+16]
       test      edx,edx
       jl        near ptr M01_L52
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFB6E908D20
       mov       r14,rax
       cmp       [r14],r14b
       lea       rcx,[r14+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFB0ECD5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       eax,ebp
       lea       rax,[r14+rax*2+0C]
       vmovups   ymm0,[7FFB0F4F78E0]
       vmovups   [rax],ymm0
       mov       rcx,6F006800740065
       mov       [rax+20],rcx
       mov       dword ptr [rax+28],730064
M01_L11:
       mov       rcx,28D32C020D0
       mov       rsi,[rcx]
       mov       edi,[r14+8]
       test      edi,edi
       je        near ptr M01_L53
       movzx     ecx,word ptr [r14+0C]
       cmp       ecx,100
       jge       near ptr M01_L55
       mov       rax,7FFB6DAA6918
       test      byte ptr [rax+rcx],80
       jne       near ptr M01_L57
M01_L12:
       dec       edi
       mov       ecx,edi
       movzx     ecx,word ptr [r14+rcx*2+0C]
       cmp       ecx,100
       jge       near ptr M01_L56
       mov       rax,7FFB6DAA6918
       test      byte ptr [rax+rcx],80
       jne       near ptr M01_L57
M01_L13:
       mov       rdi,r14
M01_L14:
       mov       rsi,[rsi+10]
       test      rdi,rdi
       jne       near ptr M01_L24
       xor       ebp,ebp
       xor       r15d,r15d
M01_L15:
       cmp       byte ptr [rsi+44],0
       jne       near ptr M01_L58
       mov       rdi,[rsi+28]
       mov       rcx,[rdi+20]
       mov       r13,[rcx+8]
       mov       r12,[r13+8]
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer+OrdinalComparer
       cmp       [r12],rcx
       jne       near ptr M01_L59
       mov       [rsp+50],rbp
       mov       [rsp+58],r15d
       lea       rcx,[rsp+50]
       call      qword ptr [7FFB0F2E5638]; System.String.GetNonRandomizedHashCode(System.ReadOnlySpan`1<Char>)
M01_L16:
       mov       [rsp+74],eax
       mov       rdx,[r13+10]
       mov       r8d,eax
       imul      r8,[r13+28]
       shr       r8,20
       inc       r8
       mov       ecx,[rdx+8]
       imul      r8,rcx
       shr       r8,20
       cmp       r8d,[rdx+8]
       jae       near ptr M01_L113
       mov       r8d,r8d
       mov       r13,[rdx+r8*8+10]
       mov       rdx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer+OrdinalComparer
       cmp       [r12],rdx
       jne       near ptr M01_L43
M01_L17:
       test      r13,r13
       je        near ptr M01_L92
       cmp       eax,[r13+20]
       jne       near ptr M01_L71
       mov       r8,[r13+8]
       test      r15d,r15d
       je        near ptr M01_L60
M01_L18:
       test      r8,r8
       jne       near ptr M01_L25
       xor       edx,edx
       xor       ecx,ecx
M01_L19:
       cmp       r15d,ecx
       jne       near ptr M01_L42
       mov       r11,rbp
       mov       r10,rdx
       mov       r9d,ecx
       add       r9,r9
       cmp       r9,8
       jb        near ptr M01_L61
       cmp       r11,r10
       je        near ptr M01_L27
       cmp       r9,20
       jb        near ptr M01_L66
       xor       edx,edx
       add       r9,0FFFFFFFFFFFFFFE0
       je        near ptr M01_L26
       vmovups   ymm0,[rbp]
       vpcmpeqb  ymm0,ymm0,[r10]
       vpmovmskb r8d,ymm0
       cmp       r8d,0FFFFFFFF
       jne       near ptr M01_L70
M01_L20:
       add       rdx,20
       cmp       r9,rdx
       jbe       short M01_L26
       vmovups   ymm0,[rdx+rbp]
       vpcmpeqb  ymm0,ymm0,[r10+rdx]
       vpmovmskb ecx,ymm0
       cmp       ecx,0FFFFFFFF
       jne       near ptr M01_L70
       jmp       short M01_L20
M01_L21:
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+60]
       call      qword ptr [rax+10]
       jmp       near ptr M01_L04
M01_L22:
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+0B0]
       call      qword ptr [rax]
       jmp       near ptr M01_L06
M01_L23:
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+60]
       call      qword ptr [rax+30]
       test      eax,eax
       jne       near ptr M01_L48
       jmp       near ptr M01_L09
M01_L24:
       lea       rbp,[rdi+0C]
       mov       r15d,[rdi+8]
       jmp       near ptr M01_L15
M01_L25:
       lea       rdx,[r8+0C]
       mov       ecx,[r8+8]
       jmp       near ptr M01_L19
M01_L26:
       vmovups   ymm0,[r9+rbp]
       vpcmpeqb  ymm0,ymm0,[r10+r9]
       vpmovmskb r10d,ymm0
       cmp       r10d,0FFFFFFFF
       jne       near ptr M01_L70
M01_L27:
       mov       r9d,1
M01_L28:
       test      r9d,r9d
       je        near ptr M01_L71
M01_L29:
       mov       rbp,[r13+10]
M01_L30:
       mov       rax,[rsi+10]
       mov       rcx,[rax+8]
       test      rcx,rcx
       jne       near ptr M01_L93
       call      qword ptr [7FFB0F265E78]; System.DateTime.get_UtcNow()
       mov       r15,rax
M01_L31:
       test      rbp,rbp
       je        near ptr M01_L103
       cmp       byte ptr [rbp+43],0
       jne       near ptr M01_L98
       mov       rdx,[rbp+38]
       test      rdx,rdx
       jl        near ptr M01_L94
M01_L32:
       mov       rcx,3FFFFFFFFFFFFFFF
       and       rcx,r15
       cmp       rdx,rcx
       jbe       near ptr M01_L95
       cmp       qword ptr [rbp+50],0
       jg        near ptr M01_L96
M01_L33:
       xor       r13d,r13d
M01_L34:
       test      r13d,r13d
       jne       near ptr M01_L98
M01_L35:
       cmp       qword ptr [rbp+10],0
       jne       near ptr M01_L97
M01_L36:
       mov       [rbp+58],r15
       mov       rdi,[rbp+20]
       cmp       byte ptr [rsi+45],0
       jne       near ptr M01_L99
M01_L37:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+28]
       mov       rdx,[rsi+48]
       mov       rax,3FFFFFFFFFFFFFFF
       and       rax,r15
       mov       r8,3FFFFFFFFFFFFFFF
       and       rdx,r8
       sub       rax,rdx
       cmp       rcx,rax
       jl        near ptr M01_L100
M01_L38:
       cmp       qword ptr [rsi+20],0
       jne       near ptr M01_L101
M01_L39:
       mov       rdx,rdi
       mov       rcx,offset MT_System.Reflection.MethodInfo[]
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
       test      rax,rax
       je        near ptr M01_L105
       mov       rsi,rdi
       test      rsi,rsi
       je        short M01_L40
       mov       rcx,offset MT_System.Reflection.MethodInfo[]
       cmp       [rsi],rcx
       je        short M01_L40
       mov       rdx,rdi
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rsi,rax
M01_L40:
       test      rsi,rsi
       je        near ptr M01_L106
       cmp       dword ptr [rsi+8],0
       jne       near ptr M01_L107
       mov       rcx,28D32C02198
       mov       rax,[rcx]
M01_L41:
       vzeroupper
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
M01_L42:
       xor       r9d,r9d
       jmp       near ptr M01_L28
M01_L43:
       test      r13,r13
       jne       near ptr M01_L72
       jmp       near ptr M01_L92
M01_L44:
       add       rdx,20
       cmp       r9,rdx
       jbe       near ptr M01_L82
       vmovups   ymm0,[rdx+rbp]
       vpcmpeqb  ymm0,ymm0,[r10+rdx]
       vpmovmskb r8d,ymm0
       cmp       r8d,0FFFFFFFF
       jne       near ptr M01_L84
       jmp       short M01_L44
M01_L45:
       call      qword ptr [7FFB0F2EDC80]
       mov       ecx,213D
       mov       rdx,7FFB0F025D88
       call      qword ptr [7FFB0EF57738]
       mov       rbx,rax
       mov       ecx,1B61
       mov       rdx,7FFB0F025D88
       call      qword ptr [7FFB0EF57738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB0ECD7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,110B
       mov       rdx,7FFB0F025D88
       call      qword ptr [7FFB0EF57738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB0ECD7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB0F44D338]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB0F44C588]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M01_L46:
       mov       rax,[rcx]
       mov       rax,[rax+98]
       call      qword ptr [rax+8]
       mov       rcx,rax
       jmp       near ptr M01_L05
M01_L47:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB0F44C570]
       mov       r8,rax
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFB0F44C588]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M01_L48:
       xor       esi,esi
       jmp       near ptr M01_L10
M01_L49:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M01_L08
M01_L50:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+50]
       call      qword ptr [rax+20]
       mov       rsi,rax
       jmp       near ptr M01_L10
M01_L51:
       mov       r14,2CDC7B60668
       jmp       near ptr M01_L11
M01_L52:
       call      qword ptr [7FFB0F447708]
       int       3
M01_L53:
       call      qword ptr [7FFB0F174030]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L54
       call      qword ptr [7FFB0F44D338]
       mov       rbx,rax
M01_L54:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,2CDC7B59C08
       call      qword ptr [7FFB0F44C588]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M01_L55:
       call      qword ptr [7FFB0F447030]
       test      eax,eax
       jne       short M01_L57
       jmp       near ptr M01_L12
M01_L56:
       call      qword ptr [7FFB0F447030]
       test      eax,eax
       je        near ptr M01_L13
M01_L57:
       mov       rcx,r14
       mov       edx,3
       call      qword ptr [7FFB0F447048]
       mov       rdi,rax
       jmp       near ptr M01_L14
M01_L58:
       call      qword ptr [7FFB0F38EFE8]
       int       3
M01_L59:
       mov       [rsp+50],rbp
       mov       [rsp+58],r15d
       lea       rdx,[rsp+50]
       mov       rcx,r12
       mov       r11,7FFB0EC20B48
       call      qword ptr [r11]
       jmp       near ptr M01_L16
M01_L60:
       test      r8,r8
       je        near ptr M01_L71
       jmp       near ptr M01_L18
M01_L61:
       cmp       r9,4
       jae       short M01_L64
       xor       r11d,r11d
       mov       rcx,r9
       and       rcx,2
       je        short M01_L62
       movzx     r11d,word ptr [rbp]
       movzx     r10d,word ptr [rdx]
       sub       r11d,r10d
M01_L62:
       test      r9b,1
       je        short M01_L63
       movzx     r9d,byte ptr [rcx+rbp]
       movzx     edx,byte ptr [rdx+rcx]
       sub       r9d,edx
       or        r11d,r9d
M01_L63:
       test      r11d,r11d
       sete      r9b
       movzx     r9d,r9b
       jmp       short M01_L65
M01_L64:
       lea       r10,[r9-4]
       mov       r9d,[rbp]
       sub       r9d,[rdx]
       mov       r8d,[r10+rbp]
       sub       r8d,[rdx+r10]
       or        r8d,r9d
       sete      r9b
       movzx     r9d,r9b
M01_L65:
       jmp       near ptr M01_L28
M01_L66:
       cmp       r9,10
       jb        short M01_L69
       xor       r8d,r8d
       lea       rcx,[r9-10]
       test      rcx,rcx
       je        short M01_L68
M01_L67:
       vmovups   xmm0,[r8+rbp]
       vpcmpeqb  xmm0,xmm0,[r10+r8]
       vpmovmskb r9d,xmm0
       cmp       r9d,0FFFF
       jne       short M01_L70
       add       r8,10
       cmp       rcx,r8
       ja        short M01_L67
M01_L68:
       vmovups   xmm0,[rcx+rbp]
       vpcmpeqb  xmm0,xmm0,[r10+rcx]
       vpmovmskb edx,xmm0
       cmp       edx,0FFFF
       jne       short M01_L70
       jmp       near ptr M01_L27
M01_L69:
       lea       rcx,[r9-8]
       mov       r9,[rbp]
       sub       r9,[rdx]
       mov       r11,[rcx+rbp]
       sub       r11,[rdx+rcx]
       or        r11,r9
       sete      r9b
       movzx     r9d,r9b
       jmp       short M01_L65
M01_L70:
       xor       r9d,r9d
       jmp       near ptr M01_L28
M01_L71:
       mov       r13,[r13+18]
       jmp       near ptr M01_L17
M01_L72:
       cmp       eax,[r13+20]
       jne       near ptr M01_L90
       mov       r8,[r13+8]
       mov       rdx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer+OrdinalComparer
       cmp       [r12],rdx
       je        short M01_L73
       mov       [rsp+50],rbp
       mov       [rsp+58],r15d
       lea       rdx,[rsp+50]
       mov       rcx,r12
       mov       r11,7FFB0EC20B50
       call      qword ptr [r11]
       mov       r9d,eax
       jmp       near ptr M01_L91
M01_L73:
       test      r15d,r15d
       jne       short M01_L74
       test      r8,r8
       je        near ptr M01_L90
M01_L74:
       test      r8,r8
       je        short M01_L75
       lea       rdx,[r8+0C]
       mov       ecx,[r8+8]
       jmp       short M01_L76
M01_L75:
       xor       edx,edx
       xor       ecx,ecx
M01_L76:
       cmp       r15d,ecx
       je        short M01_L77
       xor       r9d,r9d
       jmp       near ptr M01_L89
M01_L77:
       mov       r11,rbp
       mov       r10,rdx
       mov       r9d,ecx
       add       r9,r9
       cmp       r9,8
       jb        near ptr M01_L85
       cmp       r11,r10
       je        near ptr M01_L83
       cmp       r9,20
       jae       short M01_L81
       cmp       r9,10
       jae       short M01_L78
       lea       rcx,[r9-8]
       mov       r9,[rbp]
       sub       r9,[rdx]
       mov       r8,[rcx+rbp]
       sub       r8,[rdx+rcx]
       or        r8,r9
       sete      r9b
       movzx     r9d,r9b
       jmp       near ptr M01_L89
M01_L78:
       xor       r8d,r8d
       lea       rcx,[r9-10]
       test      rcx,rcx
       je        short M01_L80
M01_L79:
       vmovups   xmm0,[r8+rbp]
       vpcmpeqb  xmm0,xmm0,[r10+r8]
       vpmovmskb r9d,xmm0
       cmp       r9d,0FFFF
       jne       short M01_L84
       add       r8,10
       cmp       rcx,r8
       ja        short M01_L79
M01_L80:
       vmovups   xmm0,[rcx+rbp]
       vpcmpeqb  xmm0,xmm0,[r10+rcx]
       vpmovmskb edx,xmm0
       cmp       edx,0FFFF
       jne       short M01_L84
       jmp       short M01_L83
M01_L81:
       xor       edx,edx
       add       r9,0FFFFFFFFFFFFFFE0
       je        short M01_L82
       vmovups   ymm0,[rbp]
       vpcmpeqb  ymm0,ymm0,[r10]
       vpmovmskb r8d,ymm0
       cmp       r8d,0FFFFFFFF
       je        near ptr M01_L44
       jmp       short M01_L84
M01_L82:
       vmovups   ymm0,[r9+rbp]
       vpcmpeqb  ymm0,ymm0,[r10+r9]
       vpmovmskb r10d,ymm0
       cmp       r10d,0FFFFFFFF
       jne       short M01_L84
M01_L83:
       mov       r9d,1
       jmp       short M01_L89
M01_L84:
       xor       r9d,r9d
       jmp       short M01_L89
M01_L85:
       cmp       r9,4
       jb        short M01_L86
       lea       r10,[r9-4]
       mov       r8d,[rbp]
       sub       r8d,[rdx]
       mov       ecx,[r10+rbp]
       sub       ecx,[rdx+r10]
       or        r8d,ecx
       sete      r9b
       movzx     r9d,r9b
       jmp       short M01_L89
M01_L86:
       xor       r11d,r11d
       mov       rcx,r9
       and       rcx,2
       je        short M01_L87
       movzx     r11d,word ptr [rbp]
       movzx     r8d,word ptr [rdx]
       sub       r11d,r8d
M01_L87:
       test      r9b,1
       je        short M01_L88
       movzx     r9d,byte ptr [rcx+rbp]
       movzx     edx,byte ptr [rdx+rcx]
       sub       r9d,edx
       or        r9d,r11d
       mov       r11d,r9d
M01_L88:
       test      r11d,r11d
       sete      r9b
       movzx     r9d,r9b
M01_L89:
       jmp       short M01_L91
M01_L90:
       mov       r13,[r13+18]
       mov       eax,[rsp+74]
       jmp       near ptr M01_L43
M01_L91:
       test      r9d,r9d
       je        short M01_L90
       jmp       near ptr M01_L29
M01_L92:
       xor       ebp,ebp
       jmp       near ptr M01_L30
M01_L93:
       lea       rdx,[rsp+60]
       mov       r11,7FFB0EC20B58
       call      qword ptr [r11]
       lea       rcx,[rsp+60]
       call      qword ptr [7FFB0F38EF58]
       mov       r15,rax
       jmp       near ptr M01_L31
M01_L94:
       cmp       qword ptr [rbp+50],0
       je        near ptr M01_L35
       jmp       near ptr M01_L32
M01_L95:
       mov       rcx,rbp
       mov       edx,3
       call      qword ptr [7FFB0F38F888]
       mov       r13d,1
       jmp       near ptr M01_L34
M01_L96:
       mov       rdx,[rbp+58]
       mov       rcx,r15
       call      qword ptr [7FFB0F38F210]; System.DateTime.op_Subtraction(System.DateTime, System.DateTime)
       mov       rcx,rax
       mov       rdx,[rbp+50]
       call      qword ptr [7FFB0F38F9C0]
       test      eax,eax
       jne       short M01_L95
       jmp       near ptr M01_L33
M01_L97:
       mov       rcx,[rbp+10]
       mov       rdx,rbp
       cmp       [rcx],ecx
       call      qword ptr [7FFB0F38F978]
       test      eax,eax
       je        near ptr M01_L36
M01_L98:
       cmp       byte ptr [rbp+45],2
       jne       short M01_L102
       jmp       near ptr M01_L36
M01_L99:
       mov       rcx,rbp
       cmp       [rcx],ecx
       call      qword ptr [7FFB0F38F180]
       jmp       near ptr M01_L37
M01_L100:
       mov       rcx,rsi
       mov       rdx,r15
       call      qword ptr [7FFB0F38F240]
       jmp       near ptr M01_L38
M01_L101:
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFB0F44D470]
       inc       qword ptr [rax+10]
       jmp       near ptr M01_L39
M01_L102:
       mov       r8,[rsi+10]
       mov       rcx,rdi
       mov       rdx,rbp
       call      qword ptr [7FFB0F38F1E0]
M01_L103:
       mov       rdx,[rsi+10]
       mov       rdi,[rdx+28]
       mov       rdx,[rsi+48]
       mov       rcx,r15
       call      qword ptr [7FFB0F38F210]; System.DateTime.op_Subtraction(System.DateTime, System.DateTime)
       cmp       rdi,rax
       jge       short M01_L104
       mov       rcx,rsi
       mov       rdx,r15
       call      qword ptr [7FFB0F38F240]
M01_L104:
       cmp       qword ptr [rsi+20],0
       je        short M01_L105
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFB0F44D470]
       inc       qword ptr [rax+18]
M01_L105:
       mov       rcx,rbx
       call      qword ptr [7FFB0EF5E2B0]; System.Reflection.IntrospectionExtensions.GetTypeInfo(System.Type)
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+0C0]
       call      qword ptr [rax+10]
       mov       rbx,rax
       mov       rcx,28D32C02100
       mov       r8,[rcx]
       test      r8,r8
       jne       short M01_L109
       jmp       short M01_L108
M01_L106:
       mov       ecx,2
       call      qword ptr [7FFB0EF5C1C8]
       int       3
M01_L107:
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<System.Reflection.MethodInfo>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       mov       rdx,rsi
       call      qword ptr [7FFB0F175A40]; System.Collections.ObjectModel.ReadOnlyCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IList`1<System.__Canon>)
       mov       rax,rbp
       jmp       near ptr M01_L41
M01_L108:
       mov       rcx,offset MT_System.Func<System.Reflection.MethodInfo, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,28D32C020E0
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Core.TypeHelper+<>c.<GetAllAbstractMethods>b__16_0(System.Reflection.MethodInfo)
       call      qword ptr [7FFB0ECD6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,28D32C02100
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rsi
M01_L109:
       mov       rdx,rbx
       mov       rcx,7FFB0F401410
       call      qword ptr [7FFB0F0D42E8]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rdx,rax
       mov       rcx,7FFB0F401498
       call      qword ptr [7FFB0F0D6658]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rbx,rax
       mov       ecx,5
       call      qword ptr [7FFB0F38E868]; System.TimeSpan.FromMinutes(Int64)
       mov       rsi,rax
       mov       rcx,28D32C020D0
       mov       rdi,[rcx]
       mov       ecx,[r14+8]
       xor       ecx,ecx
       je        short M01_L111
       call      qword ptr [7FFB0F174030]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L110
       call      qword ptr [7FFB0F44D338]
       mov       rbx,rax
M01_L110:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,2CDC7B59C08
       call      qword ptr [7FFB0F44C588]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M01_L111:
       mov       rcx,r14
       call      qword ptr [7FFB0F174078]; System.String.Trim()
       mov       rbp,rax
       test      rbx,rbx
       jne       near ptr M01_L112
       call      qword ptr [7FFB0F2EDC80]
       mov       ecx,1FFF
       mov       rdx,7FFB0F025D88
       call      qword ptr [7FFB0EF57738]
       mov       rbx,rax
       mov       ecx,1B61
       mov       rdx,7FFB0F025D88
       call      qword ptr [7FFB0EF57738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB0ECD7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,110B
       mov       rdx,7FFB0F025D88
       call      qword ptr [7FFB0EF57738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB0ECD7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB0F44D338]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB0F44C588]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M01_L112:
       mov       rcx,offset MT_Microsoft.Extensions.Caching.Memory.MemoryCacheEntryOptions
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdi,[rdi+10]
       mov       dword ptr [r14+18],1
       mov       byte ptr [rsp+40],1
       mov       [rsp+48],rsi
       lea       rdx,[rsp+40]
       mov       rcx,r14
       call      qword ptr [7FFB0F38F480]; Microsoft.Extensions.Caching.Memory.MemoryCacheEntryOptions.set_AbsoluteExpirationRelativeToNow(System.Nullable`1<System.TimeSpan>)
       mov       [rsp+20],r14
       mov       rdx,rdi
       mov       r8,rbp
       mov       r9,rbx
       mov       rcx,7FFB0F40EEE0
       call      qword ptr [7FFB0F38F3C0]; Microsoft.Extensions.Caching.Memory.CacheExtensions.Set[[System.__Canon, System.Private.CoreLib]](Microsoft.Extensions.Caching.Memory.IMemoryCache, System.Object, System.__Canon, Microsoft.Extensions.Caching.Memory.MemoryCacheEntryOptions)
       mov       rdx,rbx
       mov       rcx,7FFB0F401638
       call      qword ptr [7FFB0F26C510]; System.Array.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       nop
       vzeroupper
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
M01_L113:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 3471
```

## .NET 10.0.0 (10.0.0, 10.0.25.52411), X64 RyuJIT x86-64-v3
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
       mov       rcx,1EF1A1A7028
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

## .NET 10.0.0 (10.0.0, 10.0.25.52411), X64 RyuJIT x86-64-v3
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
       mov       rcx,242F4EA7028
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

## .NET 10.0.0 (10.0.0, 10.0.25.52411), X64 RyuJIT x86-64-v3
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
       mov       rcx,2EEDB657028
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

## .NET 10.0.0 (10.0.0, 10.0.25.52411), X64 RyuJIT x86-64-v3
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
       mov       rcx,21869F97028
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

## .NET 10.0.0 (10.0.0, 10.0.25.52411), X64 RyuJIT x86-64-v3
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
       mov       rcx,14A83E71160
       mov       rsi,[rcx]
       test      rsi,rsi
       jne       short M00_L01
       mov       rcx,18B1A98F350
       call      qword ptr [7FFB0ECD7C48]; System.RuntimeType.InitializeCache()
       mov       rdi,rax
       jmp       short M00_L02
M00_L01:
       mov       rdi,rsi
M00_L02:
       cmp       [rdi],dil
       lea       rsi,[rdi+40]
       mov       rcx,[rsi]
       test      rcx,rcx
       je        near ptr M00_L25
M00_L03:
       cmp       byte ptr [rcx+18],0
       je        near ptr M00_L26
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
       je        short M00_L10
       mov       r14,[rsi+rbp]
       mov       edx,[r14+58]
       mov       r8d,edx
       and       r8d,3C
       cmp       r8d,edx
       jne       short M00_L08
       cmp       dword ptr [rsp+190],0
       je        short M00_L09
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
       jmp       short M00_L05
M00_L09:
       mov       [rsp+188],r14
       jmp       short M00_L07
M00_L10:
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
       je        short M00_L12
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
       call      00007FFB6E8B5D60
       cmp       dword ptr [7FFB6EC1F778],0
       jne       near ptr M00_L34
M00_L11:
       mov       rsi,rdi
M00_L12:
       mov       rcx,14A858020E8
       mov       rdi,[rcx]
       test      rdi,rdi
       je        near ptr M00_L36
M00_L13:
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
M00_L14:
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
       je        near ptr M00_L19
       lea       r14,[rdx+10]
       mov       esi,[rdx+8]
M00_L15:
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
       jle       short M00_L18
       xor       ebp,ebp
M00_L16:
       mov       r15,[r14+rbp]
       mov       rdx,r15
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       test      eax,eax
       je        short M00_L17
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
M00_L17:
       add       rbp,8
       dec       esi
       jne       short M00_L16
M00_L18:
       mov       esi,[rsp+3C]
       add       esi,[rsp+40]
       jo        near ptr M00_L48
       mov       eax,esi
       test      eax,eax
       je        short M00_L20
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
       call      qword ptr [7FFB0F44CAC8]; System.Collections.Generic.SegmentedArrayBuilder`1[[System.__Canon, System.Private.CoreLib]].ToSpanInlined(System.Span`1<System.__Canon>)
       jmp       short M00_L22
M00_L19:
       xor       r14d,r14d
       xor       esi,esi
       jmp       near ptr M00_L15
M00_L20:
       test      byte ptr [7FFB0F4B19C0],1
       je        near ptr M00_L44
M00_L21:
       mov       rdx,14A85802198
       mov       rdi,[rdx]
M00_L22:
       mov       r8d,[rsp+38]
       test      r8d,r8d
       jne       short M00_L24
M00_L23:
       mov       rdx,rdi
       mov       rcx,7FFB0F428300
       call      qword ptr [7FFB0F26C510]; System.Array.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       mov       [rsp+30],rax
       mov       rcx,[rbx+18]
       lea       r8,[rsp+30]
       mov       rdx,7FFB0F42A7D8
       cmp       [rcx],ecx
       call      qword ptr [7FFB0F39F120]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,198
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M00_L24:
       lea       rcx,[rsp+38]
       mov       rdx,offset MT_System.Collections.Generic.SegmentedArrayBuilder<System.Reflection.MethodInfo>
       call      qword ptr [7FFB0F39EF88]; System.Collections.Generic.SegmentedArrayBuilder`1[[System.__Canon, System.Private.CoreLib]].ReturnArrays(Int32)
       jmp       short M00_L23
M00_L25:
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache+MemberInfoCache<System.Reflection.RuntimeMethodInfo>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       mov       rdx,rbp
       xor       r8d,r8d
       call      00007FFB6E8BFBA0
       mov       rcx,rax
       test      rcx,rcx
       cmove     rcx,rbp
       jmp       near ptr M00_L03
M00_L26:
       xor       edx,edx
       xor       r8d,r8d
       xor       r9d,r9d
       call      qword ptr [7FFB0ECDD2C0]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
       mov       rsi,rax
       jmp       near ptr M00_L04
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
       mov       rcx,7FFB0EE57750
       call      qword ptr [7FFB0ECDD4E8]; System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
       mov       [rsp+194],r15d
       jmp       near ptr M00_L06
M00_L30:
       mov       rcx,offset MT_System.Array+EmptyArray<System.Reflection.MethodInfo>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,14A85802198
       mov       rsi,[rcx]
       jmp       near ptr M00_L12
M00_L31:
       mov       rcx,offset MT_System.Reflection.MethodInfo[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rdi
       xor       edx,edx
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       near ptr M00_L12
M00_L32:
       mov       ecx,45
       mov       edx,0D
       call      qword ptr [7FFB0F2E58C0]
       int       3
M00_L33:
       mov       edx,ebp
       mov       rcx,offset MT_System.Reflection.MethodInfo[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rsi,rax
       jmp       near ptr M00_L12
M00_L34:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L11
M00_L35:
       call      qword ptr [7FFB0F2EE010]
       jmp       near ptr M00_L11
M00_L36:
       mov       rcx,offset MT_System.Func<System.Reflection.MethodInfo, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,14A858020C0
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Core.TypeHelper+<>c.<GetAllGenericMethods>b__21_0(System.Reflection.MethodInfo)
       call      qword ptr [7FFB0ECD6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,14A858020E8
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L13
M00_L37:
       mov       ecx,11
       call      qword ptr [7FFB0EF57DF8]
       int       3
M00_L38:
       mov       rcx,rax
       mov       rdx,rdi
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+8]
       mov       r14,rax
       jmp       near ptr M00_L14
M00_L39:
       mov       rcx,offset MT_System.Array+EmptyArray<System.Reflection.MethodInfo>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,14A85802198
       mov       r14,[rdx]
       jmp       near ptr M00_L14
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
       call      qword ptr [7FFB0F44C948]
       mov       r14,rsi
       jmp       near ptr M00_L14
M00_L41:
       mov       rcx,offset MT_System.Linq.Enumerable+IEnumerableWhereIterator<System.Reflection.MethodInfo>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       rdx,rsi
       mov       r8,rdi
       call      qword ptr [7FFB0F44C960]
       jmp       near ptr M00_L14
M00_L42:
       lea       rcx,[rsp+38]
       mov       r8,r15
       mov       rdx,offset MT_System.Collections.Generic.SegmentedArrayBuilder<System.Reflection.MethodInfo>
       call      qword ptr [7FFB0F39ED60]; System.Collections.Generic.SegmentedArrayBuilder`1[[System.__Canon, System.Private.CoreLib]].AddSlow(System.__Canon)
       jmp       near ptr M00_L17
M00_L43:
       call      qword ptr [7FFB0F447438]
       int       3
M00_L44:
       mov       rcx,offset MT_System.Array+EmptyArray<System.Reflection.MethodInfo>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L21
M00_L45:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rdi,rax
       jmp       near ptr M00_L23
M00_L46:
       mov       rdx,r14
       mov       rcx,offset MT_System.Collections.Generic.ICollection<System.Reflection.MethodInfo>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M00_L47
       mov       rdx,rax
       mov       rcx,7FFB0F56D658
       call      qword ptr [7FFB0F0D7A38]; System.Linq.Enumerable.ICollectionToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>)
       mov       rdi,rax
       jmp       near ptr M00_L23
M00_L47:
       mov       rdx,r14
       mov       rcx,7FFB0F56D6E0
       call      qword ptr [7FFB0F447690]
       mov       rdi,rax
       jmp       near ptr M00_L23
M00_L48:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 1919
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
       call      00007FFB6E8C1870
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
       mov       rax,7FFB0EE36D90
       mov       [rbp-78],rax
       lea       rax,[M01_L03]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFB6E852C30
       call      rax
M01_L03:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFB6EC1F778],0
       je        short M01_L04
       call      qword ptr [7FFB6EC0D608]; CORINFO_HELP_STOP_FOR_GC
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
       call      00007FFB6E8D04E0
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
       call      qword ptr [7FFB0F44E268]; System.RuntimeTypeHandle.GetGCHandle(System.Runtime.InteropServices.GCHandleType)
       mov       rdx,rax
       lea       rcx,[rbx+10]
       xor       eax,eax
       lock cmpxchg [rcx],rdx
       test      rax,rax
       je        near ptr M01_L00
       lea       rcx,[rbp-40]
       call      qword ptr [7FFB0F447930]
       jmp       near ptr M01_L00
M01_L09:
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M01_L10:
       mov       [rbp+10],rbx
       mov       rcx,rbx
       call      qword ptr [7FFB0ECD7C90]; System.RuntimeTypeHandle.<GetModule>g__GetModuleWorker|48_0(System.RuntimeType)
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
       jmp       qword ptr [7FFB0ECDD8F0]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
M02_L00:
       call      qword ptr [7FFB0F444630]
       int       3
M02_L01:
       mov       rcx,rax
       mov       rdx,r8
       add       rsp,28
       jmp       near ptr 00007FFB6E907B10
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
       mov       r8,14A85800038
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
       jne       short M04_L03
       mov       rsi,rcx
       xor       rsi,[r11+10]
       cmp       rsi,1
       ja        short M04_L03
       cmp       ebx,[r11]
       jne       short M04_L05
M04_L01:
       cmp       esi,1
       jne       short M04_L04
M04_L02:
       mov       rax,rdx
       pop       rbx
       pop       rsi
       ret
M04_L03:
       test      ebx,ebx
       je        short M04_L05
       inc       r9d
       add       r10d,r9d
       and       r10d,[r8+4]
       cmp       r9d,8
       jl        short M04_L00
       jmp       short M04_L05
M04_L04:
       test      esi,esi
       jne       short M04_L06
       xor       edx,edx
       jmp       short M04_L02
M04_L05:
       mov       esi,2
       jmp       short M04_L01
M04_L06:
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFB0ECDD908]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny_NoCacheLookup(Void*, System.Object)
; Total bytes of code 170
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
       call      00007FFB6E8B5D60
       cmp       dword ptr [7FFB6EC1F778],0
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
       call      00007FFB6E8B5D60
       cmp       dword ptr [7FFB6EC1F778],0
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
       call      qword ptr [7FFB0F2EE010]
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
       mov       rdx,7FFB0F498FF0
       call      qword ptr [7FFB0ECDC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M05_L07:
       lea       r8,[rbx+10]
       lea       rcx,[rsp+28]
       mov       r9d,1B
       call      qword ptr [7FFB0F39EFA0]; <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan[[System.Collections.Generic.SegmentedArrayBuilder`1+Arrays[[System.__Canon, System.Private.CoreLib]], System.Linq],[System.__Canon, System.Private.CoreLib]](Arrays<System.__Canon> ByRef, Int32)
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
       call      qword ptr [7FFB0ECD57A0]; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r13d
       lea       rdi,[rdi+rcx*8]
       sub       ebp,r13d
       inc       r15d
M05_L11:
       cmp       r15d,r14d
       jl        short M05_L08
       jmp       near ptr M05_L01
M05_L12:
       call      qword ptr [7FFB0EE77138]
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
       jmp       qword ptr [7FFB0F2EE010]
M05_L15:
       call      qword ptr [7FFB0F17C258]
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
       mov       rdx,7FFB0F497998
       call      qword ptr [7FFB0EF57AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       short M06_L00
M06_L02:
       mov       ecx,2
       call      qword ptr [7FFB0EF5C1C8]
       int       3
M06_L03:
       mov       rdx,[rcx+18]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M06_L04
       jmp       short M06_L05
M06_L04:
       mov       rdx,7FFB0F497998
       call      qword ptr [7FFB0EF57AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       ja        near ptr M08_L09
       xor       r14d,r14d
       cmp       r14d,ebx
       jl        near ptr M08_L10
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
       jne       near ptr M08_L13
M08_L01:
       mov       r10d,eax
       neg       r10d
       test      eax,eax
       jg        near ptr M08_L14
       mov       eax,r10d
       or        eax,edx
       jl        near ptr M08_L14
       lea       eax,[r10+rdx]
       cmp       eax,[rbx+8]
       ja        near ptr M08_L14
       movzx     eax,word ptr [r8]
       mov       r10d,r10d
       imul      r10,rax
       add       rcx,r10
       mov       edx,edx
       imul      rdx,rax
       test      dword ptr [r8],1000000
       je        near ptr M08_L15
       shr       rdx,3
       call      qword ptr [7FFB0F39F0A8]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
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
       mov       rcx,14A85800C90
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
       mov       rdx,7FFB0F49B6D0
       call      qword ptr [7FFB0ECDC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M08_L03
M08_L09:
       call      qword ptr [7FFB0EE77138]
       int       3
M08_L10:
       mov       r15,[rbp+r14*8]
       mov       rcx,r15
       call      qword ptr [7FFB0F446D60]
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0B8
       jle       short M08_L11
       mov       rcx,[rcx+0B8]
       test      rcx,rcx
       je        short M08_L11
       jmp       short M08_L12
M08_L11:
       mov       rcx,rdi
       mov       rdx,7FFB0F49B6D0
       call      qword ptr [7FFB0ECDC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M08_L12:
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,[rax]
       mov       rdx,r15
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFB0F429888]; System.Buffers.SharedArrayPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon[], Boolean)
       inc       r14d
       cmp       r14d,ebx
       jl        short M08_L10
       jmp       near ptr M08_L00
M08_L13:
       mov       r10d,[r8+4]
       add       r10d,0FFFFFFE8
       shr       r10d,3
       movsxd    rax,r10d
       mov       eax,[rcx+rax*4]
       shl       r10d,3
       movsxd    r10,r10d
       add       rcx,r10
       jmp       near ptr M08_L01
M08_L14:
       call      qword ptr [7FFB0F447BA0]
       int       3
M08_L15:
       call      qword ptr [7FFB0ECD57E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
       jmp       near ptr M08_L02
M08_L16:
       mov       ecx,0A
       call      qword ptr [7FFB0F174708]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M08_L04
M08_L17:
       mov       ecx,2
       call      qword ptr [7FFB0EF5C1C8]
       int       3
M08_L18:
       mov       rcx,rsi
       call      qword ptr [7FFB0F39F0D8]; System.Buffers.SharedArrayPool`1[[System.__Canon, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
       jmp       near ptr M08_L05
M08_L19:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFB0F446D00]
       mov       rsi,rax
       mov       ecx,29B
       mov       rdx,7FFB0EC14000
       call      qword ptr [7FFB0EF57738]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFB0F0D5E30]
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
       call      qword ptr [7FFB0F447BE8]
M08_L21:
       mov       r14,[rax+8]
       mov       rcx,offset MT_System.Threading.ProcessorIdCache
       call      qword ptr [7FFB0ECD5740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       cmp       byte ptr [7FFB0EC1B184],0
       je        short M08_L22
       call      qword ptr [7FFB0F446AF0]
       mov       r15d,eax
       jmp       short M08_L24
M08_L22:
       mov       ecx,0B
       call      qword ptr [7FFB0F446B08]
       mov       r15d,[rax+10]
       mov       ecx,0B
       call      qword ptr [7FFB0F446B08]
       lea       ecx,[r15-1]
       mov       [rax+10],ecx
       movzx     eax,r15w
       test      eax,eax
       jne       short M08_L23
       call      qword ptr [7FFB0F446B20]
       mov       r15d,eax
       jmp       short M08_L24
M08_L23:
       sar       r15d,10
M08_L24:
       mov       rcx,offset MT_System.Buffers.SharedArrayPoolStatics
       call      qword ptr [7FFB0ECD5740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       eax,r15d
       xor       edx,edx
       div       dword ptr [7FFB0EC1B178]
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
       call      qword ptr [7FFB0F26D590]; System.Threading.Monitor.Enter(System.Object)
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
       call      qword ptr [7FFB0ECD6820]; System.Threading.Monitor.Exit(System.Object)
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
       call      qword ptr [7FFB0F17C900]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r13d,eax
       mov       r12d,[rbx+8]
       mov       rcx,rsi
       call      qword ptr [7FFB0F17C900]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,r15
       mov       r8d,r13d
       mov       r9d,r12d
       mov       edx,3
       call      qword ptr [7FFB0F446D30]
       test      r14d,ebp
       jne       near ptr M08_L07
       mov       rcx,rbx
       call      qword ptr [7FFB0F17C900]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r14d,eax
       mov       ebx,[rbx+8]
       mov       rcx,rsi
       call      qword ptr [7FFB0F17C900]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
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
       call      qword ptr [7FFB0F446D48]
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
       jmp       qword ptr [7FFB0F429888]; System.Buffers.SharedArrayPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon[], Boolean)
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
       mov       rax,0DD29994D15B6
       mov       [rbp],rax
       mov       rsi,rcx
       mov       rbx,rdx
       mov       edi,r8d
       mov       r14d,r9d
       test      rbx,rbx
       je        near ptr M09_L06
       cmp       dword ptr [rbx+8],0
       je        near ptr M09_L06
       cmp       r14d,1
       jne       short M09_L00
       movzx     r15d,word ptr [rbx+0C]
       cmp       r15d,2E
       jne       short M09_L01
       mov       rcx,7FFB0F5F4430
       call      CORINFO_HELP_COUNTPROFILE32
M09_L00:
       mov       rcx,14A85800220
       mov       r15,[rcx]
       mov       rcx,r15
       mov       rdx,7FFB0F5F4438
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rcx,r15
       mov       rdx,rbx
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+18]
       mov       r15d,eax
       cmp       r15d,400
       jbe       short M09_L02
       movsxd    rdx,r15d
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       r13,[rax+10]
       mov       r15d,[rax+8]
       jmp       short M09_L04
M09_L01:
       cmp       r15d,2A
       jne       near ptr M09_L05
       mov       rcx,7FFB0F5F442C
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M09_L00
M09_L02:
       mov       rcx,7FFB0F5F4540
       call      CORINFO_HELP_COUNTPROFILE32
       mov       edx,r15d
       mov       r13,rdx
       test      r13,r13
       je        short M09_L04
       mov       rcx,r13
       add       rcx,0F
       and       rcx,0FFFFFFFFFFFFFFF0
       add       rsp,30
       neg       rcx
       add       rcx,rsp
       jb        short M09_L03
       xor       ecx,ecx
M09_L03:
       test      [rsp],esp
       sub       rsp,1000
       cmp       rsp,rcx
       jae       short M09_L03
       mov       rsp,rcx
       test      [rsp],esp
       sub       rsp,30
       lea       r13,[rsp+30]
M09_L04:
       mov       rcx,7FFB0F5F4544
       call      CORINFO_HELP_COUNTPROFILE32
       mov       [rbp+8],r13
       mov       [rbp+10],r15d
       mov       [rsp+20],r14d
       lea       r8,[rbp+8]
       mov       rdx,rbx
       mov       rcx,rsi
       mov       r9d,edi
       call      qword ptr [7FFB0ECDD320]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].GetListByName(System.String, System.Span`1<Byte>, MemberListType, CacheType)
       mov       [rbp+18],rax
       jmp       short M09_L07
M09_L05:
       mov       rcx,7FFB0F5F4428
       call      CORINFO_HELP_COUNTPROFILE32
M09_L06:
       xor       r8d,r8d
       mov       [rbp+8],r8
       mov       [rbp+10],r8d
       mov       [rsp+20],r14d
       lea       r8,[rbp+8]
       mov       rcx,rsi
       mov       r9d,edi
       mov       rdx,18B1A980008
       call      qword ptr [7FFB0ECDD320]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].GetListByName(System.String, System.Span`1<Byte>, MemberListType, CacheType)
       mov       [rbp+18],rax
M09_L07:
       mov       rcx,7FFB0F5F4548
       call      CORINFO_HELP_COUNTPROFILE32
       lea       rdx,[rbp+18]
       mov       rcx,rsi
       mov       r8,rbx
       mov       r9d,edi
       call      qword ptr [7FFB0ECDD578]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Insert(System.__Canon[] ByRef, System.String, MemberListType)
       mov       rax,[rbp+18]
       mov       r8,0DD29994D15B6
       cmp       [rbp],r8
       je        short M09_L08
       call      CORINFO_HELP_FAIL_FAST
M09_L08:
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
       call      00007FFB6E8B5D60
       cmp       dword ptr [7FFB6EC1F778],0
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
       mov       rdx,7FFB0F4962F0
       call      qword ptr [7FFB0EF57AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M10_L00
M10_L04:
       mov       ecx,45
       mov       edx,0D
       call      qword ptr [7FFB0F2E58C0]
       int       3
M10_L05:
       mov       rdx,[rcx+18]
       mov       rax,[rdx+18]
       test      rax,rax
       je        short M10_L06
       mov       rcx,rax
       jmp       short M10_L07
M10_L06:
       mov       rdx,7FFB0F4962F0
       call      qword ptr [7FFB0EF57AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       call      qword ptr [7FFB0F2EE010]
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
       jmp       qword ptr [7FFB0ECD5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
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
       call      00007FFB6E8394A0
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
       call      qword ptr [7FFB0F447000]
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
       jo        near ptr M14_L58
       mov       [rbx+4],edx
       cmp       dword ptr [rbx+4],7FFFFFC7
       jg        near ptr M14_L46
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
       jle       near ptr M14_L06
       mov       rcx,[rcx+0B8]
       test      rcx,rcx
       je        near ptr M14_L06
M14_L03:
       cmp       r15d,1B
       jae       near ptr M14_L57
       mov       eax,r15d
       lea       rbp,[rbp+rax*8]
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r15,[rax]
       mov       r13d,r14d
       mov       rcx,14A85800C90
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
       je        near ptr M14_L07
       mov       r8d,[rsp+5C]
       cmp       [rax+8],r8d
       jbe       near ptr M14_L07
       mov       ecx,r8d
       shl       rcx,4
       mov       r10,[rax+rcx+10]
       test      r10,r10
       je        near ptr M14_L07
       mov       r14,r10
       mov       r13d,[rsp+5C]
       mov       ecx,r13d
       shl       rcx,4
       xor       edx,edx
       mov       [rax+rcx+10],rdx
       cmp       byte ptr [r12+9D],0
       je        near ptr M14_L35
       mov       rcx,r14
       call      qword ptr [7FFB0F17C900]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+4C],eax
       mov       edx,[r14+8]
       mov       [rsp+48],edx
       mov       rcx,r15
       call      00007FFB6E8B6270
       mov       r9d,eax
       test      r9d,r9d
       je        near ptr M14_L47
M14_L04:
       mov       [rsp+20],r13d
       mov       rcx,r12
       mov       edx,[rsp+4C]
       mov       r8d,[rsp+48]
       call      qword ptr [7FFB0F446AD8]
       jmp       near ptr M14_L35
M14_L05:
       mov       rcx,r15
       call      qword ptr [7FFB0ECDE928]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       mov       r9d,eax
       jmp       near ptr M14_L34
M14_L06:
       mov       rcx,rdi
       mov       rdx,7FFB0F49B6D0
       call      qword ptr [7FFB0ECDC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M14_L03
M14_L07:
       mov       rax,[r15+10]
       mov       r8d,[rsp+5C]
       cmp       [rax+8],r8d
       ja        short M14_L13
       test      r13d,r13d
       je        short M14_L08
       test      r13d,r13d
       jge       near ptr M14_L29
       jmp       near ptr M14_L54
M14_L08:
       mov       rcx,[r15]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx+8]
       cmp       qword ptr [rdx+8],40
       jle       short M14_L11
       mov       rax,[rdx+40]
       test      rax,rax
       je        short M14_L11
       mov       rcx,rax
M14_L09:
       mov       rdx,[rcx+18]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M14_L12
M14_L10:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r14,[rax]
       jmp       near ptr M14_L35
M14_L11:
       mov       rdx,7FFB0F49B7D8
       call      qword ptr [7FFB0ECDC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M14_L09
M14_L12:
       mov       rdx,7FFB0F493388
       call      qword ptr [7FFB0EF57AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       short M14_L10
M14_L13:
       mov       ecx,r8d
       mov       rcx,[rax+rcx*8+10]
       test      rcx,rcx
       je        near ptr M14_L28
       mov       r13,[rcx+8]
       test      byte ptr [7FFB0F4A9FC8],1
       je        near ptr M14_L48
M14_L14:
       cmp       byte ptr [7FFB0EC1B184],0
       jne       short M14_L17
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+238],0B
       jle       near ptr M14_L49
       mov       rcx,[rcx+240]
       mov       rax,[rcx+58]
       test      rax,rax
       je        near ptr M14_L49
M14_L15:
       mov       r14d,[rax+10]
       lea       ecx,[r14-1]
       mov       [rax+10],ecx
       movzx     eax,r14w
       test      eax,eax
       je        short M14_L16
       sar       r14d,10
       jmp       short M14_L18
M14_L16:
       call      qword ptr [7FFB0F446B20]
       mov       r14d,eax
       jmp       short M14_L18
M14_L17:
       call      qword ptr [7FFB0F446AF0]
       mov       r14d,eax
M14_L18:
       test      byte ptr [7FFB0F4A9E58],1
       je        near ptr M14_L50
M14_L19:
       mov       eax,r14d
       xor       edx,edx
       div       dword ptr [7FFB0EC1B178]
       mov       r14d,edx
       mov       eax,[r13+8]
       mov       [rsp+44],eax
       test      eax,eax
       jle       near ptr M14_L53
       mov       [rsp+40],eax
M14_L20:
       cmp       r14d,eax
       jae       near ptr M14_L57
       mov       ecx,r14d
       mov       r8,[r13+rcx*8+10]
       mov       [rsp+30],r8
       cmp       [r8],r8b
       xor       r10d,r10d
       mov       [rsp+38],r10
       mov       rcx,r8
       call      00007FFB6E7F9E20
       test      eax,eax
       je        near ptr M14_L51
M14_L21:
       mov       rax,[rsp+30]
       mov       rcx,[rax+8]
       mov       edx,[rax+10]
       dec       edx
       cmp       [rcx+8],edx
       ja        short M14_L25
M14_L22:
       mov       rcx,rax
       call      00007FFB6E8B6030
       test      eax,eax
       jne       near ptr M14_L52
M14_L23:
       mov       r10,[rsp+38]
       test      r10,r10
       jne       short M14_L27
       inc       r14d
       mov       r10d,[rsp+44]
       cmp       r10d,r14d
       je        short M14_L26
M14_L24:
       mov       edx,[rsp+40]
       dec       edx
       mov       [rsp+40],edx
       mov       eax,r10d
       jne       short M14_L20
       jmp       near ptr M14_L53
M14_L25:
       mov       r8d,edx
       mov       r10,[rcx+r8*8+10]
       mov       [rsp+38],r10
       xor       r9d,r9d
       mov       [rcx+r8*8+10],r9
       mov       [rax+10],edx
       jmp       short M14_L22
M14_L26:
       xor       r14d,r14d
       jmp       short M14_L24
M14_L27:
       mov       r14,r10
       test      r14,r14
       jne       near ptr M14_L43
M14_L28:
       mov       ecx,10
       mov       r8d,[rsp+5C]
       shlx      r13d,ecx,r8d
M14_L29:
       mov       rcx,[r15]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx+8]
       cmp       qword ptr [rdx+8],38
       jle       near ptr M14_L39
       mov       rax,[rdx+38]
       test      rax,rax
       je        near ptr M14_L39
       mov       rcx,rax
M14_L30:
       mov       rdx,[rcx+18]
       mov       rax,[rdx+18]
       test      rax,rax
       je        near ptr M14_L40
       mov       rcx,rax
M14_L31:
       movsxd    rdx,r13d
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       cmp       byte ptr [r12+9D],0
       je        near ptr M14_L35
       mov       rcx,r14
       call      00007FFB6E8B6270
       mov       r13d,eax
       test      r13d,r13d
       je        near ptr M14_L41
M14_L32:
       mov       eax,[r14+8]
       mov       [rsp+58],eax
       mov       rcx,r15
       call      00007FFB6E8B6270
       mov       r9d,eax
       test      r9d,r9d
       je        near ptr M14_L42
M14_L33:
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       rcx,r12
       mov       edx,r13d
       mov       r8d,[rsp+58]
       call      qword ptr [7FFB0F446AD8]
       mov       eax,[r14+8]
       mov       [rsp+54],eax
       mov       rcx,r15
       call      00007FFB6E8B6270
       mov       r9d,eax
       test      r9d,r9d
       je        near ptr M14_L05
M14_L34:
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
       call      qword ptr [7FFB0F446B68]
M14_L35:
       mov       rcx,rbp
       mov       rdx,r14
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],90
       jle       near ptr M14_L44
       mov       rcx,[rcx+90]
       test      rcx,rcx
       je        near ptr M14_L44
M14_L36:
       test      r14,r14
       je        near ptr M14_L55
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+20]
       test      rax,rax
       je        near ptr M14_L45
M14_L37:
       cmp       [r14],rax
       jne       near ptr M14_L56
       lea       rdi,[r14+10]
       mov       ebp,[r14+8]
M14_L38:
       mov       [rbx+0F8],rdi
       mov       [rbx+100],ebp
       inc       dword ptr [rbx]
       lea       rcx,[rbx+0F8]
       cmp       dword ptr [rcx+8],0
       jbe       near ptr M14_L57
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
M14_L39:
       mov       rdx,7FFB0F49B7B8
       call      qword ptr [7FFB0ECDC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M14_L30
M14_L40:
       mov       rdx,7FFB0F498FC0
       call      qword ptr [7FFB0EF57AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M14_L31
M14_L41:
       mov       rcx,r14
       call      qword ptr [7FFB0ECDE928]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       mov       r13d,eax
       jmp       near ptr M14_L32
M14_L42:
       mov       rcx,r15
       call      qword ptr [7FFB0ECDE928]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       mov       r9d,eax
       jmp       near ptr M14_L33
M14_L43:
       cmp       byte ptr [r12+9D],0
       je        near ptr M14_L35
       mov       rcx,r14
       call      qword ptr [7FFB0F17C900]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r13d,eax
       mov       eax,[r14+8]
       mov       [rsp+50],eax
       mov       rcx,r15
       call      qword ptr [7FFB0F17C900]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       r15d,[rsp+5C]
       mov       [rsp+20],r15d
       mov       edx,r13d
       mov       r8d,[rsp+50]
       mov       rcx,r12
       call      qword ptr [7FFB0F446AD8]
       jmp       near ptr M14_L35
M14_L44:
       mov       rcx,rdi
       mov       rdx,7FFB0F498F38
       call      qword ptr [7FFB0ECDC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M14_L36
M14_L45:
       mov       rdx,7FFB0F496508
       call      qword ptr [7FFB0ECDC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M14_L37
M14_L46:
       mov       rcx,offset MT_System.OutOfMemoryException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB0F4477F8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M14_L47:
       mov       rcx,r15
       call      qword ptr [7FFB0ECDE928]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       mov       r9d,eax
       jmp       near ptr M14_L04
M14_L48:
       mov       rcx,offset MT_System.Threading.ProcessorIdCache
       call      qword ptr [7FFB0ECD5740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M14_L14
M14_L49:
       mov       ecx,0B
       call      qword ptr [7FFB0F446B08]
       jmp       near ptr M14_L15
M14_L50:
       mov       rcx,offset MT_System.Buffers.SharedArrayPoolStatics
       call      qword ptr [7FFB0ECD5740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M14_L19
M14_L51:
       mov       rcx,[rsp+30]
       call      qword ptr [7FFB0F446B38]
       jmp       near ptr M14_L21
M14_L52:
       mov       ecx,eax
       mov       rdx,[rsp+30]
       call      qword ptr [7FFB0F446B50]
       jmp       near ptr M14_L23
M14_L53:
       xor       r10d,r10d
       jmp       near ptr M14_L27
M14_L54:
       mov       ecx,172EC
       mov       rdx,7FFB0EC14000
       call      qword ptr [7FFB0EF57738]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FFB0F445BF0]
       int       3
M14_L55:
       xor       edi,edi
       xor       ebp,ebp
       jmp       near ptr M14_L38
M14_L56:
       call      qword ptr [7FFB0F447438]
       int       3
M14_L57:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M14_L58:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 1744
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
       jmp       qword ptr [7FFB0F0DD4B8]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
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
       call      qword ptr [7FFB6CC18600]
       mov       rcx,rsi
       mov       r11,rax
       call      qword ptr [rax]
       mov       edi,eax
       test      edi,edi
       je        short M16_L00
       mov       rcx,rbx
       call      qword ptr [7FFB6CC17A48]
       mov       rcx,rax
       movsxd    rdx,edi
       call      qword ptr [7FFB6CC156D8]; CORINFO_HELP_NEWARR_1_DIRECT
       mov       rdi,rax
       mov       rcx,rbx
       call      qword ptr [7FFB6CC18608]
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
       call      qword ptr [7FFB6CC18228]
       mov       rcx,rax
       lea       rax,[System.Linq.Enumerable.Select[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>)]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax]
; Total bytes of code 128
```

## .NET 10.0.0 (10.0.0, 10.0.25.52411), X64 RyuJIT x86-64-v3
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
       mov       rcx,1B42508F350
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

## .NET 10.0.0 (10.0.0, 10.0.25.52411), X64 RyuJIT x86-64-v3
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
       mov       rcx,2AD074E0668
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

## .NET 10.0.0 (10.0.0, 10.0.25.52411), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark.GetAllPublicMethods()
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,218
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFE20
M00_L00:
       vmovdqa   xmmword ptr [rsp+rax+210],xmm4
       vmovdqa   xmmword ptr [rsp+rax+220],xmm4
       vmovdqa   xmmword ptr [rsp+rax+230],xmm4
       add       rax,30
       jne       short M00_L00
       mov       [rsp+210],rax
       mov       rbx,rcx
       mov       rcx,2CD7E341160
       mov       rsi,[rcx]
       test      rsi,rsi
       je        near ptr M00_L27
M00_L01:
       cmp       [rsi],sil
       lea       rdi,[rsi+40]
       mov       rcx,[rdi]
       test      rcx,rcx
       je        near ptr M00_L28
M00_L02:
       cmp       byte ptr [rcx+18],0
       je        near ptr M00_L29
       mov       rsi,[rcx+8]
M00_L03:
       mov       edi,[rsi+8]
       mov       edx,edi
       xor       r8d,r8d
       mov       [rsp+200],r8
       mov       [rsp+208],r8
       mov       [rsp+210],r8d
       mov       [rsp+214],edx
       test      edi,edi
       jle       near ptr M00_L15
       add       rsi,10
       jmp       short M00_L08
M00_L04:
       mov       edx,[rsp+214]
       cmp       edx,[rsp+210]
       je        near ptr M00_L31
M00_L05:
       movsxd    rdx,dword ptr [rsp+210]
       mov       rcx,[rsp+200]
       mov       r8,rbp
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
M00_L06:
       mov       edx,[rsp+210]
       inc       edx
       mov       [rsp+210],edx
M00_L07:
       add       rsi,8
       dec       edi
       je        near ptr M00_L15
M00_L08:
       mov       rbp,[rsi]
       mov       edx,[rbp+58]
       mov       r8d,edx
       and       r8d,3C
       cmp       r8d,edx
       jne       short M00_L07
       cmp       dword ptr [rsp+210],0
       je        short M00_L10
       cmp       dword ptr [rsp+210],1
       jne       short M00_L04
       cmp       dword ptr [rsp+214],2
       jl        near ptr M00_L30
M00_L09:
       movsxd    rdx,dword ptr [rsp+214]
       mov       rcx,offset MT_System.Reflection.MethodInfo[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       [rsp+200],rax
       mov       rcx,[rsp+200]
       mov       r8,[rsp+208]
       xor       edx,edx
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       near ptr M00_L05
M00_L10:
       mov       [rsp+208],rbp
       jmp       near ptr M00_L06
M00_L11:
       xor       r14d,r14d
       xor       esi,esi
       jmp       near ptr M00_L20
M00_L12:
       test      byte ptr [7FFB0F492110],1
       je        near ptr M00_L48
M00_L13:
       mov       rdx,2CD80002198
       mov       rdi,[rdx]
       jmp       near ptr M00_L25
M00_L14:
       vmovdqu   xmm0,xmmword ptr [rsp+1A0]
       vmovdqu   xmmword ptr [rsp+30],xmm0
       lea       r8,[rsp+30]
       lea       rcx,[rsp+88]
       mov       rdx,offset MT_System.Span<System.Reflection.MethodInfo>
       call      qword ptr [7FFB0F37EF58]; System.Span`1[[System.__Canon, System.Private.CoreLib]].op_Implicit(System.Span`1<System.__Canon>)
       vmovdqu   xmm0,xmmword ptr [rsp+98]
       vmovdqu   xmmword ptr [rsp+30],xmm0
       lea       r8,[rsp+30]
       lea       rcx,[rsp+88]
       mov       rbp,offset MT_System.ReadOnlySpan<System.Reflection.MethodInfo>
       mov       rdx,rbp
       call      qword ptr [7FFB0F37EF70]; System.ReadOnlySpan`1[[System.__Canon, System.Private.CoreLib]].CopyTo(System.Span`1<System.__Canon>)
       lea       rcx,[rsp+98]
       lea       rdx,[rsp+98]
       mov       r9d,[rsp+90]
       mov       r8,offset MT_System.Span<System.Reflection.MethodInfo>
       call      qword ptr [7FFB0F37EF88]; System.Span`1[[System.__Canon, System.Private.CoreLib]].Slice(Int32)
       dec       esi
       je        near ptr M00_L24
       jmp       near ptr M00_L46
M00_L15:
       mov       rsi,[rsp+200]
       mov       rdi,[rsp+208]
       mov       ebp,[rsp+210]
       test      ebp,ebp
       je        near ptr M00_L32
       cmp       ebp,1
       je        near ptr M00_L33
       test      ebp,ebp
       jl        near ptr M00_L34
       test      rsi,rsi
       je        near ptr M00_L35
       cmp       [rsi+8],ebp
       je        short M00_L17
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
       ja        near ptr M00_L37
       call      00007FFB6E8B5D60
       cmp       dword ptr [7FFB6EC1F778],0
       jne       near ptr M00_L36
M00_L16:
       mov       rsi,rdi
M00_L17:
       mov       rcx,2CD800020F0
       mov       rdi,[rcx]
       test      rdi,rdi
       je        near ptr M00_L38
M00_L18:
       test      rsi,rsi
       je        near ptr M00_L39
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<System.Reflection.MethodInfo>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L40
       mov       rdx,rsi
       mov       rcx,offset MT_System.Reflection.MethodInfo[]
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
       mov       rbp,rax
       test      rbp,rbp
       je        near ptr M00_L42
       cmp       dword ptr [rbp+8],0
       je        near ptr M00_L41
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
M00_L19:
       mov       rdx,r14
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<System.Reflection.MethodInfo>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M00_L50
       mov       rdx,offset MT_System.Linq.Enumerable+ArrayWhereIterator<System.Reflection.MethodInfo>
       cmp       [rax],rdx
       jne       near ptr M00_L49
       mov       rdx,[rax+18]
       test      rdx,rdx
       je        near ptr M00_L11
       lea       r14,[rdx+10]
       mov       esi,[rdx+8]
M00_L20:
       mov       rdi,[rax+20]
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rsp+1C0],ymm0
       vmovdqu   ymmword ptr [rsp+1E0],ymm0
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rsp+0C8],ymm0
       vmovdqu   ymmword ptr [rsp+0E8],ymm0
       vmovdqu   ymmword ptr [rsp+108],ymm0
       vmovdqu   ymmword ptr [rsp+128],ymm0
       vmovdqu   ymmword ptr [rsp+148],ymm0
       vmovdqu   ymmword ptr [rsp+168],ymm0
       vmovdqu   ymmword ptr [rsp+180],ymm0
       xor       edx,edx
       mov       [rsp+0B8],edx
       mov       [rsp+0BC],edx
       mov       [rsp+0C0],edx
       lea       rdx,[rsp+1C0]
       mov       [rsp+1A0],rdx
       mov       dword ptr [rsp+1A8],8
       lea       rdx,[rsp+1C0]
       mov       [rsp+1B0],rdx
       mov       dword ptr [rsp+1B8],8
       test      esi,esi
       jle       short M00_L23
       xor       ebp,ebp
M00_L21:
       mov       r15,[r14+rbp]
       mov       rdx,r15
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       test      eax,eax
       je        short M00_L22
       mov       rcx,[rsp+1B0]
       mov       edx,[rsp+1B8]
       mov       eax,[rsp+0C0]
       cmp       eax,edx
       jae       near ptr M00_L44
       mov       edx,eax
       lea       rcx,[rcx+rdx*8]
       mov       rdx,r15
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       ecx,[rsp+0C0]
       inc       ecx
       mov       [rsp+0C0],ecx
M00_L22:
       add       rbp,8
       dec       esi
       jne       short M00_L21
M00_L23:
       mov       esi,[rsp+0BC]
       add       esi,[rsp+0C0]
       jo        near ptr M00_L52
       mov       eax,esi
       test      eax,eax
       je        near ptr M00_L12
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Reflection.MethodInfo[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       mov       r8,offset MT_System.Reflection.MethodInfo[]
       cmp       [rdi],r8
       jne       near ptr M00_L45
       lea       r8,[rdi+10]
       mov       [rsp+98],r8
       mov       [rsp+0A0],esi
       mov       esi,[rsp+0B8]
       test      esi,esi
       jne       near ptr M00_L14
M00_L24:
       mov       ecx,[rsp+0C0]
       mov       [rsp+20],ecx
       lea       rcx,[rsp+1B0]
       lea       rdx,[rsp+0A8]
       mov       r8,offset MT_System.Span<System.Reflection.MethodInfo>
       xor       r9d,r9d
       call      qword ptr [7FFB0F37F090]; System.Span`1[[System.__Canon, System.Private.CoreLib]].Slice(Int32, Int32)
       vmovdqu   xmm0,xmmword ptr [rsp+98]
       vmovdqu   xmmword ptr [rsp+30],xmm0
       lea       r8,[rsp+30]
       lea       rcx,[rsp+0A8]
       mov       rdx,offset MT_System.Span<System.Reflection.MethodInfo>
       call      qword ptr [7FFB0F37F0A8]; System.Span`1[[System.__Canon, System.Private.CoreLib]].CopyTo(System.Span`1<System.__Canon>)
M00_L25:
       lea       rcx,[rsp+0B8]
       mov       rdx,offset MT_System.Collections.Generic.SegmentedArrayBuilder<System.Reflection.MethodInfo>
       call      qword ptr [7FFB0F42CB28]; System.Collections.Generic.SegmentedArrayBuilder`1[[System.__Canon, System.Private.CoreLib]].Dispose()
M00_L26:
       mov       rdx,rdi
       mov       rcx,7FFB0F408300
       call      qword ptr [7FFB0F24C528]; System.Array.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       mov       [rsp+40],rax
       mov       rcx,[rbx+18]
       lea       r8,[rsp+40]
       mov       rdx,7FFB0F40A7E8
       cmp       [rcx],ecx
       call      qword ptr [7FFB0F37F180]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,218
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M00_L27:
       mov       rcx,30E14FF0668
       call      qword ptr [7FFB0ECB7C48]; System.RuntimeType.InitializeCache()
       mov       rsi,rax
       jmp       near ptr M00_L01
M00_L28:
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache+MemberInfoCache<System.Reflection.RuntimeMethodInfo>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       rdx,rbp
       xor       r8d,r8d
       call      00007FFB6E8BFBA0
       mov       rcx,rax
       test      rcx,rcx
       cmove     rcx,rbp
       jmp       near ptr M00_L02
M00_L29:
       xor       edx,edx
       xor       r8d,r8d
       xor       r9d,r9d
       call      qword ptr [7FFB0ECBD2C0]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
       mov       rsi,rax
       jmp       near ptr M00_L03
M00_L30:
       mov       dword ptr [rsp+214],4
       jmp       near ptr M00_L09
M00_L31:
       mov       r14d,[rsp+214]
       add       r14d,r14d
       lea       rdx,[rsp+200]
       mov       r8d,r14d
       mov       rcx,7FFB0EE37750
       call      qword ptr [7FFB0ECBD4E8]; System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
       mov       [rsp+214],r14d
       jmp       near ptr M00_L05
M00_L32:
       mov       rcx,offset MT_System.Array+EmptyArray<System.Reflection.MethodInfo>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,2CD80002198
       mov       rsi,[rcx]
       jmp       near ptr M00_L17
M00_L33:
       mov       rcx,offset MT_System.Reflection.MethodInfo[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rdi
       xor       edx,edx
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       near ptr M00_L17
M00_L34:
       mov       ecx,45
       mov       edx,0D
       call      qword ptr [7FFB0F2C58D8]
       int       3
M00_L35:
       mov       edx,ebp
       mov       rcx,offset MT_System.Reflection.MethodInfo[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rsi,rax
       jmp       near ptr M00_L17
M00_L36:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L16
M00_L37:
       call      qword ptr [7FFB0F2CDB78]
       jmp       near ptr M00_L16
M00_L38:
       mov       rcx,offset MT_System.Func<System.Reflection.MethodInfo, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,2CD800020C0
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Core.TypeHelper+<>c.<GetAllPublicMethods>b__24_0(System.Reflection.MethodInfo)
       call      qword ptr [7FFB0ECB6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,2CD800020F0
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L18
M00_L39:
       mov       ecx,11
       call      qword ptr [7FFB0EF37DF8]
       int       3
M00_L40:
       mov       rcx,rax
       mov       rdx,rdi
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+8]
       mov       r14,rax
       jmp       near ptr M00_L19
M00_L41:
       mov       rcx,offset MT_System.Array+EmptyArray<System.Reflection.MethodInfo>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,2CD80002198
       mov       r14,[rdx]
       jmp       near ptr M00_L19
M00_L42:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Generic.List<System.Reflection.MethodInfo>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r14,rax
       test      r14,r14
       je        short M00_L43
       mov       rcx,offset MT_System.Linq.Enumerable+ListWhereIterator<System.Reflection.MethodInfo>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,r14
       mov       r8,rdi
       call      qword ptr [7FFB0F42C978]
       mov       r14,rsi
       jmp       near ptr M00_L19
M00_L43:
       mov       rcx,offset MT_System.Linq.Enumerable+IEnumerableWhereIterator<System.Reflection.MethodInfo>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       rdx,rsi
       mov       r8,rdi
       call      qword ptr [7FFB0F42C990]
       jmp       near ptr M00_L19
M00_L44:
       lea       rcx,[rsp+0B8]
       mov       r8,r15
       mov       rdx,offset MT_System.Collections.Generic.SegmentedArrayBuilder<System.Reflection.MethodInfo>
       call      qword ptr [7FFB0F37EDA8]; System.Collections.Generic.SegmentedArrayBuilder`1[[System.__Canon, System.Private.CoreLib]].AddSlow(System.__Canon)
       jmp       near ptr M00_L22
M00_L45:
       call      qword ptr [7FFB0F427408]
       int       3
M00_L46:
       lea       rcx,[rsp+78]
       lea       r8,[rsp+0C8]
       mov       rdx,7FFB0F409D88
       mov       r9d,1B
       call      qword ptr [7FFB0F37EFA0]; <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan[[System.Collections.Generic.SegmentedArrayBuilder`1+Arrays[[System.__Canon, System.Private.CoreLib]], System.Linq],[System.__Canon, System.Private.CoreLib]](Arrays<System.__Canon> ByRef, Int32)
       mov       [rsp+20],esi
       lea       rcx,[rsp+78]
       lea       rdx,[rsp+68]
       mov       r8,offset MT_System.ReadOnlySpan<System.Reflection.MethodInfo[]>
       xor       r9d,r9d
       call      qword ptr [7FFB0F37E718]; System.ReadOnlySpan`1[[System.__Canon, System.Private.CoreLib]].Slice(Int32, Int32)
       mov       esi,[rsp+70]
       test      esi,esi
       jle       near ptr M00_L24
       xor       r14d,r14d
M00_L47:
       mov       rcx,[rsp+68]
       mov       r8,[rcx+r14]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+48],xmm0
       lea       rcx,[rsp+48]
       mov       rdx,rbp
       call      qword ptr [7FFB0F42CB10]; System.ReadOnlySpan`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.__Canon[])
       vmovdqu   xmm0,xmmword ptr [rsp+48]
       vmovdqu   xmmword ptr [rsp+58],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+98]
       vmovdqu   xmmword ptr [rsp+30],xmm0
       lea       r8,[rsp+30]
       lea       rcx,[rsp+58]
       mov       rdx,rbp
       call      qword ptr [7FFB0F37EF70]; System.ReadOnlySpan`1[[System.__Canon, System.Private.CoreLib]].CopyTo(System.Span`1<System.__Canon>)
       lea       rcx,[rsp+98]
       lea       rdx,[rsp+98]
       mov       r9d,[rsp+60]
       mov       r8,offset MT_System.Span<System.Reflection.MethodInfo>
       call      qword ptr [7FFB0F37EF88]; System.Span`1[[System.__Canon, System.Private.CoreLib]].Slice(Int32)
       add       r14,8
       dec       esi
       jne       short M00_L47
       jmp       near ptr M00_L24
M00_L48:
       mov       rcx,offset MT_System.Array+EmptyArray<System.Reflection.MethodInfo>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L13
M00_L49:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rdi,rax
       jmp       near ptr M00_L26
M00_L50:
       mov       rdx,r14
       mov       rcx,offset MT_System.Collections.Generic.ICollection<System.Reflection.MethodInfo>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M00_L51
       mov       rdx,rax
       mov       rcx,7FFB0F54FE78
       call      qword ptr [7FFB0F0B7A38]; System.Linq.Enumerable.ICollectionToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>)
       mov       rdi,rax
       jmp       near ptr M00_L26
M00_L51:
       mov       rdx,r14
       mov       rcx,7FFB0F54FF00
       call      qword ptr [7FFB0F4276C0]
       mov       rdi,rax
       jmp       near ptr M00_L26
M00_L52:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 2398
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       sub       rsp,28
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M01_L00
       lea       rax,[rcx+rdx*8+10]
       mov       rcx,[rcx]
       mov       rdx,[rcx+30]
       test      r8,r8
       je        short M01_L02
       cmp       rdx,[r8]
       je        short M01_L01
       mov       r10,offset MT_System.Object[]
       cmp       rcx,r10
       je        short M01_L01
       mov       rcx,rax
       add       rsp,28
       jmp       qword ptr [7FFB0ECBD8F0]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
M01_L00:
       call      qword ptr [7FFB0F424630]
       int       3
M01_L01:
       mov       rcx,rax
       mov       rdx,r8
       add       rsp,28
       jmp       near ptr 00007FFB6E907B10
M01_L02:
       xor       ecx,ecx
       mov       [rax],rcx
       add       rsp,28
       ret
; Total bytes of code 94
```
```assembly
; System.Span`1[[System.__Canon, System.Private.CoreLib]].op_Implicit(System.Span`1<System.__Canon>)
       mov       rax,[r8]
       mov       edx,[r8+8]
       mov       [rcx],rax
       mov       [rcx+8],edx
       mov       rax,rcx
       ret
; Total bytes of code 17
```
```assembly
; System.ReadOnlySpan`1[[System.__Canon, System.Private.CoreLib]].CopyTo(System.Span`1<System.__Canon>)
       sub       rsp,28
       mov       edx,[rcx+8]
       cmp       edx,[r8+8]
       ja        short M03_L03
       mov       rax,[r8]
       mov       r10,[rcx]
       mov       r8d,edx
       shl       r8,3
       cmp       r8,4000
       ja        short M03_L02
       mov       rcx,rax
       mov       rdx,r10
       call      00007FFB6E8B5D60
       cmp       dword ptr [7FFB6EC1F778],0
       jne       short M03_L01
M03_L00:
       add       rsp,28
       ret
M03_L01:
       call      CORINFO_HELP_POLL_GC
       jmp       short M03_L00
M03_L02:
       mov       rcx,rax
       mov       rdx,r10
       add       rsp,28
       jmp       qword ptr [7FFB0F2CDB78]
M03_L03:
       call      qword ptr [7FFB0F15C258]
       int       3
; Total bytes of code 90
```
```assembly
; System.Span`1[[System.__Canon, System.Private.CoreLib]].Slice(Int32)
       sub       rsp,28
       mov       eax,[rcx+8]
       cmp       r9d,eax
       ja        short M04_L00
       mov       rcx,[rcx]
       mov       r8d,r9d
       lea       rcx,[rcx+r8*8]
       sub       eax,r9d
       mov       [rdx],rcx
       mov       [rdx+8],eax
       mov       rax,rdx
       add       rsp,28
       ret
M04_L00:
       call      qword ptr [7FFB0EE57138]
       int       3
; Total bytes of code 46
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rdx,rdx
       je        short M05_L02
       mov       rax,[rdx]
       cmp       rax,rcx
       je        short M05_L02
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M05_L02
M05_L00:
       test      rax,rax
       je        short M05_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M05_L02
       test      rax,rax
       je        short M05_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M05_L02
       test      rax,rax
       jne       short M05_L03
M05_L01:
       xor       edx,edx
M05_L02:
       mov       rax,rdx
       ret
M05_L03:
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M05_L02
       test      rax,rax
       je        short M05_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M05_L02
       jmp       short M05_L00
; Total bytes of code 86
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
       push      rsi
       push      rbx
       test      rdx,rdx
       je        short M06_L02
       mov       rax,[rdx]
       cmp       rax,rcx
       je        short M06_L02
       mov       r8,2CD80000038
       mov       r8,[r8]
       add       r8,10
       rorx      r10,rax,20
       xor       r10,rcx
       mov       r9,9E3779B97F4A7C15
       imul      r10,r9
       mov       r9d,[r8]
       shrx      r10,r10,r9
       xor       r9d,r9d
M06_L00:
       lea       r11d,[r10+1]
       movsxd    r11,r11d
       lea       r11,[r11+r11*2]
       lea       r11,[r8+r11*8]
       mov       ebx,[r11]
       mov       rsi,[r11+8]
       and       ebx,0FFFFFFFE
       cmp       rsi,rax
       jne       short M06_L03
       mov       rsi,rcx
       xor       rsi,[r11+10]
       cmp       rsi,1
       ja        short M06_L03
       cmp       ebx,[r11]
       jne       short M06_L05
M06_L01:
       cmp       esi,1
       jne       short M06_L04
M06_L02:
       mov       rax,rdx
       pop       rbx
       pop       rsi
       ret
M06_L03:
       test      ebx,ebx
       je        short M06_L05
       inc       r9d
       add       r10d,r9d
       and       r10d,[r8+4]
       cmp       r9d,8
       jl        short M06_L00
       jmp       short M06_L05
M06_L04:
       test      esi,esi
       jne       short M06_L06
       xor       edx,edx
       jmp       short M06_L02
M06_L05:
       mov       esi,2
       jmp       short M06_L01
M06_L06:
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFB0ECBD908]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny_NoCacheLookup(Void*, System.Object)
; Total bytes of code 170
```
```assembly
; System.Span`1[[System.__Canon, System.Private.CoreLib]].Slice(Int32, Int32)
       sub       rsp,28
       mov       eax,[rsp+50]
       mov       r8d,r9d
       mov       r10d,eax
       add       r10,r8
       mov       r9d,[rcx+8]
       cmp       r10,r9
       ja        short M07_L00
       mov       rcx,[rcx]
       lea       rcx,[rcx+r8*8]
       mov       [rdx],rcx
       mov       [rdx+8],eax
       mov       rax,rdx
       add       rsp,28
       ret
M07_L00:
       call      qword ptr [7FFB0EE57138]
       int       3
; Total bytes of code 54
```
```assembly
; System.Span`1[[System.__Canon, System.Private.CoreLib]].CopyTo(System.Span`1<System.__Canon>)
       sub       rsp,28
       mov       edx,[rcx+8]
       cmp       edx,[r8+8]
       ja        short M08_L03
       mov       rax,[r8]
       mov       r10,[rcx]
       mov       r8d,edx
       shl       r8,3
       cmp       r8,4000
       ja        short M08_L02
       mov       rcx,rax
       mov       rdx,r10
       call      00007FFB6E8B5D60
       cmp       dword ptr [7FFB6EC1F778],0
       jne       short M08_L01
M08_L00:
       add       rsp,28
       ret
M08_L01:
       call      CORINFO_HELP_POLL_GC
       jmp       short M08_L00
M08_L02:
       mov       rcx,rax
       mov       rdx,r10
       add       rsp,28
       jmp       qword ptr [7FFB0F2CDB78]
M08_L03:
       call      qword ptr [7FFB0F15C258]
       int       3
; Total bytes of code 90
```
```assembly
; System.Collections.Generic.SegmentedArrayBuilder`1[[System.__Canon, System.Private.CoreLib]].Dispose()
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
       mov       rbx,rcx
       mov       esi,[rbx]
       test      esi,esi
       je        near ptr M09_L14
       mov       rdi,rdx
       lea       rbp,[rbx+10]
       dec       esi
       cmp       esi,1B
       ja        near ptr M09_L17
       xor       r14d,r14d
       cmp       r14d,esi
       jge       near ptr M09_L07
M09_L00:
       mov       r15,[rbp+r14*8]
       test      r15,r15
       je        near ptr M09_L45
       mov       rdx,[r15]
       movzx     ecx,word ptr [rdx]
       mov       eax,[r15+8]
       imul      rax,rcx
       lea       rcx,[r15+10]
       test      dword ptr [rdx],1000000
       je        near ptr M09_L18
       mov       rdx,rax
       shr       rdx,3
       call      qword ptr [7FFB0F37F0F0]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
M09_L01:
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],98
       jle       near ptr M09_L15
       mov       rcx,[rcx+98]
       test      rcx,rcx
       je        near ptr M09_L15
M09_L02:
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,[rax]
       mov       r13,rcx
       mov       rcx,offset MT_System.Buffers.SharedArrayPool<System.Reflection.MethodInfo>
       cmp       [r13],rcx
       jne       near ptr M09_L39
       mov       ecx,[r15+8]
       dec       ecx
       or        ecx,0F
       xor       r12d,r12d
       lzcnt     r12d,ecx
       xor       r12d,1F
       add       r12d,0FFFFFFFD
       mov       rcx,gs:[58]
       mov       rcx,[rcx+38]
       cmp       dword ptr [rcx+238],0A
       jle       near ptr M09_L19
       mov       rcx,[rcx+240]
       mov       rax,[rcx+50]
       test      rax,rax
       je        near ptr M09_L19
M09_L03:
       mov       rax,[rax+10]
       test      rax,rax
       je        near ptr M09_L20
M09_L04:
       xor       r8d,r8d
       mov       dword ptr [rsp+98],1
       mov       ecx,[rax+8]
       cmp       ecx,r12d
       jbe       short M09_L05
       mov       dword ptr [rsp+9C],1
       mov       ecx,10
       shlx      ecx,ecx,r12d
       cmp       [r15+8],ecx
       jne       near ptr M09_L40
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
       jne       near ptr M09_L21
       mov       r8d,[rsp+9C]
M09_L05:
       mov       rcx,2CD80000C90
       mov       rax,[rcx]
       mov       [rsp+60],rax
       cmp       byte ptr [rax+9D],0
       jne       near ptr M09_L36
M09_L06:
       inc       r14d
       cmp       r14d,esi
       jl        near ptr M09_L00
M09_L07:
       cmp       esi,1B
       jae       near ptr M09_L67
       mov       edx,esi
       mov       rsi,[rbp+rdx*8]
       mov       edx,[rbx+8]
       test      rsi,rsi
       je        near ptr M09_L45
       lea       rcx,[rsi+10]
       xor       eax,eax
       mov       r8,[rsi]
       cmp       dword ptr [r8+4],18
       jne       near ptr M09_L41
M09_L08:
       mov       r10d,eax
       neg       r10d
       test      eax,eax
       jg        near ptr M09_L42
       mov       eax,r10d
       or        eax,edx
       jl        near ptr M09_L42
       lea       eax,[r10+rdx]
       cmp       eax,[rsi+8]
       ja        near ptr M09_L42
       movzx     eax,word ptr [r8]
       mov       r10d,r10d
       imul      r10,rax
       add       rcx,r10
       mov       edx,edx
       imul      rdx,rax
       test      dword ptr [r8],1000000
       je        near ptr M09_L43
       shr       rdx,3
       call      qword ptr [7FFB0F37F0F0]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
M09_L09:
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],98
       jle       near ptr M09_L16
       mov       rcx,[rcx+98]
       test      rcx,rcx
       je        near ptr M09_L16
M09_L10:
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,[rax]
       mov       rbx,rcx
       mov       rcx,offset MT_System.Buffers.SharedArrayPool<System.Reflection.MethodInfo>
       cmp       [rbx],rcx
       jne       near ptr M09_L66
       mov       ecx,[rsi+8]
       dec       ecx
       or        ecx,0F
       xor       edi,edi
       lzcnt     edi,ecx
       xor       edi,1F
       add       edi,0FFFFFFFD
       mov       rcx,gs:[58]
       mov       rcx,[rcx+38]
       cmp       dword ptr [rcx+238],0A
       jle       near ptr M09_L44
       mov       rcx,[rcx+240]
       mov       rax,[rcx+50]
       test      rax,rax
       je        near ptr M09_L44
M09_L11:
       mov       rax,[rax+10]
       test      rax,rax
       je        near ptr M09_L46
M09_L12:
       xor       ebp,ebp
       mov       r14d,1
       mov       ecx,[rax+8]
       cmp       ecx,edi
       jbe       short M09_L13
       mov       ebp,1
       mov       ecx,10
       shlx      ecx,ecx,edi
       cmp       [rsi+8],ecx
       jne       near ptr M09_L47
       mov       ecx,edi
       shl       rcx,4
       lea       r15,[rax+rcx+10]
       mov       r13,[r15]
       mov       rcx,r15
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r15+8],ecx
       test      r13,r13
       jne       near ptr M09_L48
M09_L13:
       mov       rcx,2CD80000C90
       mov       r15,[rcx]
       cmp       byte ptr [r15+9D],0
       jne       near ptr M09_L63
M09_L14:
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
M09_L15:
       mov       rcx,rdi
       mov       rdx,7FFB0F478FA8
       call      qword ptr [7FFB0ECBC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M09_L02
M09_L16:
       mov       rcx,rdi
       mov       rdx,7FFB0F478FA8
       call      qword ptr [7FFB0ECBC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M09_L10
M09_L17:
       call      qword ptr [7FFB0EE57138]
       int       3
M09_L18:
       mov       rdx,rax
       call      qword ptr [7FFB0ECB57E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
       jmp       near ptr M09_L01
M09_L19:
       mov       ecx,0A
       call      qword ptr [7FFB0F154708]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M09_L03
M09_L20:
       mov       rcx,r13
       call      qword ptr [7FFB0F37F120]; System.Buffers.SharedArrayPool`1[[System.__Canon, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
       jmp       near ptr M09_L04
M09_L21:
       mov       rcx,[r13+10]
       cmp       r12d,[rcx+8]
       jae       near ptr M09_L67
       mov       edx,r12d
       mov       r8,[rcx+rdx*8+10]
       test      r8,r8
       jne       short M09_L22
       mov       rcx,r13
       mov       edx,r12d
       call      qword ptr [7FFB0F427B28]
       mov       r8,rax
M09_L22:
       mov       rdx,[r8+8]
       mov       [rsp+48],rdx
       mov       rcx,offset MT_System.Threading.ProcessorIdCache
       call      qword ptr [7FFB0ECB5740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       cmp       byte ptr [7FFB0EBFB184],0
       je        short M09_L23
       call      qword ptr [7FFB0F426B38]
       mov       [rsp+80],eax
       jmp       short M09_L25
M09_L23:
       mov       ecx,0B
       call      qword ptr [7FFB0F426B50]
       mov       eax,[rax+10]
       mov       [rsp+7C],eax
       mov       ecx,0B
       call      qword ptr [7FFB0F426B50]
       mov       ecx,[rsp+7C]
       lea       edx,[rcx-1]
       mov       [rax+10],edx
       movzx     eax,cx
       test      eax,eax
       jne       short M09_L24
       call      qword ptr [7FFB0F426B68]
       mov       edx,eax
       mov       [rsp+80],edx
       jmp       short M09_L25
M09_L24:
       mov       eax,ecx
       sar       eax,10
       mov       edx,eax
       mov       [rsp+80],edx
M09_L25:
       mov       rcx,offset MT_System.Buffers.SharedArrayPoolStatics
       call      qword ptr [7FFB0ECB5740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       eax,[rsp+80]
       xor       edx,edx
       div       dword ptr [7FFB0EBFB178]
       mov       eax,edx
       xor       edx,edx
       jmp       near ptr M09_L32
M09_L26:
       cmp       eax,[r8+8]
       jae       near ptr M09_L67
       mov       [rsp+88],eax
       mov       ecx,eax
       mov       r10,[r8+rcx*8+10]
       mov       [rsp+40],r10
       cmp       [r10],r10b
       xor       r9d,r9d
       mov       [rsp+78],r9d
       mov       rcx,r10
       call      qword ptr [7FFB0F24D5A8]; System.Threading.Monitor.Enter(System.Object)
       mov       rax,[rsp+40]
       mov       rcx,[rax+8]
       mov       r8d,[rax+10]
       mov       [rsp+74],r8d
       cmp       [rcx+8],r8d
       jbe       short M09_L28
       test      r8d,r8d
       jne       short M09_L29
       xor       edx,edx
       mov       [rax+14],edx
M09_L27:
       mov       edx,r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,[rsp+50]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rsp+74]
       inc       ecx
       mov       rax,[rsp+40]
       mov       [rax+10],ecx
       mov       dword ptr [rsp+78],1
M09_L28:
       mov       rcx,rax
       call      qword ptr [7FFB0ECB6820]; System.Threading.Monitor.Exit(System.Object)
       cmp       dword ptr [rsp+78],0
       je        short M09_L30
       jmp       short M09_L33
M09_L29:
       jmp       short M09_L27
M09_L30:
       mov       eax,[rsp+88]
       inc       eax
       mov       ecx,eax
       mov       r8,[rsp+48]
       cmp       [r8+8],ecx
       jne       short M09_L31
       xor       ecx,ecx
M09_L31:
       mov       edx,[rsp+84]
       inc       edx
       mov       eax,ecx
M09_L32:
       mov       r8,[rsp+48]
       mov       [rsp+84],edx
       cmp       [r8+8],edx
       jg        near ptr M09_L26
       jmp       short M09_L34
M09_L33:
       mov       r10d,1
       jmp       short M09_L35
M09_L34:
       xor       r10d,r10d
M09_L35:
       mov       [rsp+98],r10d
       mov       r8d,[rsp+9C]
       jmp       near ptr M09_L05
M09_L36:
       cmp       dword ptr [r15+8],0
       mov       [rsp+9C],r8d
       je        near ptr M09_L06
       mov       rcx,r15
       call      qword ptr [7FFB0F15C900]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+94],eax
       mov       edx,[r15+8]
       mov       [rsp+90],edx
       mov       rcx,r13
       call      qword ptr [7FFB0F15C900]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,[rsp+60]
       mov       r8d,[rsp+94]
       mov       r9d,[rsp+90]
       mov       edx,3
       call      qword ptr [7FFB0F426D78]
       mov       eax,[rsp+9C]
       test      [rsp+98],eax
       jne       near ptr M09_L06
       mov       rcx,r15
       call      qword ptr [7FFB0F15C900]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+8C],eax
       mov       r15d,[r15+8]
       mov       rcx,r13
       call      qword ptr [7FFB0F15C900]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       cmp       dword ptr [rsp+9C],0
       jne       short M09_L37
       mov       ecx,0FFFFFFFF
       mov       edx,1
       jmp       short M09_L38
M09_L37:
       mov       ecx,r12d
       xor       edx,edx
M09_L38:
       mov       [rsp+20],ecx
       mov       [rsp+28],edx
       mov       rcx,[rsp+60]
       mov       edx,[rsp+8C]
       mov       r8d,r15d
       call      qword ptr [7FFB0F426D90]
       jmp       near ptr M09_L06
M09_L39:
       mov       rcx,r13
       mov       rdx,r15
       xor       r8d,r8d
       call      qword ptr [7FFB0F409888]; System.Buffers.SharedArrayPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon[], Boolean)
       jmp       near ptr M09_L06
M09_L40:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB0F426D48]
       mov       rbp,rax
       mov       ecx,29B
       mov       rdx,7FFB0EBF4000
       call      qword ptr [7FFB0EF37738]
       mov       r8,rax
       mov       rdx,rbp
       mov       rcx,rsi
       call      qword ptr [7FFB0F0B5E30]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M09_L41:
       mov       r10d,[r8+4]
       add       r10d,0FFFFFFE8
       shr       r10d,3
       movsxd    rax,r10d
       mov       eax,[rcx+rax*4]
       shl       r10d,3
       movsxd    r10,r10d
       add       rcx,r10
       jmp       near ptr M09_L08
M09_L42:
       call      qword ptr [7FFB0F427C00]
       int       3
M09_L43:
       call      qword ptr [7FFB0ECB57E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
       jmp       near ptr M09_L09
M09_L44:
       mov       ecx,0A
       call      qword ptr [7FFB0F154708]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M09_L11
M09_L45:
       mov       ecx,2
       call      qword ptr [7FFB0EF3C1C8]
       int       3
M09_L46:
       mov       rcx,rbx
       call      qword ptr [7FFB0F37F120]; System.Buffers.SharedArrayPool`1[[System.__Canon, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
       jmp       near ptr M09_L12
M09_L47:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB0F426D48]
       mov       rbx,rax
       mov       ecx,29B
       mov       rdx,7FFB0EBF4000
       call      qword ptr [7FFB0EF37738]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB0F0B5E30]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M09_L48:
       mov       rcx,[rbx+10]
       cmp       edi,[rcx+8]
       jae       near ptr M09_L67
       mov       edx,edi
       mov       rax,[rcx+rdx*8+10]
       test      rax,rax
       jne       short M09_L49
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFB0F427B28]
M09_L49:
       mov       r14,[rax+8]
       mov       rcx,offset MT_System.Threading.ProcessorIdCache
       call      qword ptr [7FFB0ECB5740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       cmp       byte ptr [7FFB0EBFB184],0
       je        short M09_L50
       call      qword ptr [7FFB0F426B38]
       mov       r15d,eax
       jmp       short M09_L52
M09_L50:
       mov       ecx,0B
       call      qword ptr [7FFB0F426B50]
       mov       r15d,[rax+10]
       mov       ecx,0B
       call      qword ptr [7FFB0F426B50]
       lea       ecx,[r15-1]
       mov       [rax+10],ecx
       movzx     eax,r15w
       test      eax,eax
       jne       short M09_L51
       call      qword ptr [7FFB0F426B68]
       mov       r15d,eax
       jmp       short M09_L52
M09_L51:
       sar       r15d,10
M09_L52:
       mov       rcx,offset MT_System.Buffers.SharedArrayPoolStatics
       call      qword ptr [7FFB0ECB5740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       eax,r15d
       xor       edx,edx
       div       dword ptr [7FFB0EBFB178]
       mov       r15d,edx
       xor       r12d,r12d
       jmp       near ptr M09_L59
M09_L53:
       cmp       r15d,[r14+8]
       jae       near ptr M09_L67
       mov       ecx,r15d
       mov       rax,[r14+rcx*8+10]
       mov       [rsp+38],rax
       cmp       [rax],al
       xor       edx,edx
       mov       [rsp+70],edx
       mov       rcx,rax
       call      qword ptr [7FFB0F24D5A8]; System.Threading.Monitor.Enter(System.Object)
       mov       rax,[rsp+38]
       mov       rcx,[rax+8]
       mov       r8d,[rax+10]
       mov       [rsp+6C],r8d
       cmp       [rcx+8],r8d
       jbe       short M09_L55
       test      r8d,r8d
       jne       short M09_L56
       xor       edx,edx
       mov       [rax+14],edx
M09_L54:
       movsxd    rdx,r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rsp+6C]
       inc       ecx
       mov       rax,[rsp+38]
       mov       [rax+10],ecx
       mov       dword ptr [rsp+70],1
M09_L55:
       mov       rcx,rax
       call      qword ptr [7FFB0ECB6820]; System.Threading.Monitor.Exit(System.Object)
       cmp       dword ptr [rsp+70],0
       je        short M09_L57
       jmp       short M09_L60
M09_L56:
       jmp       short M09_L54
M09_L57:
       inc       r15d
       cmp       [r14+8],r15d
       jne       short M09_L58
       xor       r15d,r15d
M09_L58:
       inc       r12d
M09_L59:
       cmp       [r14+8],r12d
       jg        near ptr M09_L53
       jmp       short M09_L61
M09_L60:
       mov       r14d,1
       jmp       short M09_L62
M09_L61:
       xor       r14d,r14d
M09_L62:
       jmp       near ptr M09_L13
M09_L63:
       cmp       dword ptr [rsi+8],0
       je        near ptr M09_L14
       mov       rcx,rsi
       call      qword ptr [7FFB0F15C900]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r13d,eax
       mov       r12d,[rsi+8]
       mov       rcx,rbx
       call      qword ptr [7FFB0F15C900]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,r15
       mov       r8d,r13d
       mov       r9d,r12d
       mov       edx,3
       call      qword ptr [7FFB0F426D78]
       test      r14d,ebp
       jne       near ptr M09_L14
       mov       rcx,rsi
       call      qword ptr [7FFB0F15C900]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r14d,eax
       mov       esi,[rsi+8]
       mov       rcx,rbx
       call      qword ptr [7FFB0F15C900]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       test      ebp,ebp
       jne       short M09_L64
       mov       ecx,0FFFFFFFF
       mov       edx,1
       jmp       short M09_L65
M09_L64:
       mov       ecx,edi
       xor       edx,edx
M09_L65:
       mov       [rsp+20],ecx
       mov       [rsp+28],edx
       mov       rcx,r15
       mov       edx,r14d
       mov       r8d,esi
       call      qword ptr [7FFB0F426D90]
       jmp       near ptr M09_L14
M09_L66:
       mov       rcx,rbx
       mov       rdx,rsi
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
       jmp       qword ptr [7FFB0F409888]; System.Buffers.SharedArrayPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon[], Boolean)
M09_L67:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 2378
```
```assembly
; System.Array.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       push      rsi
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        short M10_L02
       cmp       dword ptr [rbx+8],0
       je        short M10_L03
       mov       rdx,[rcx+18]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M10_L01
M10_L00:
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
M10_L01:
       mov       rdx,7FFB0F477BA8
       call      qword ptr [7FFB0EF37AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       short M10_L00
M10_L02:
       mov       ecx,2
       call      qword ptr [7FFB0EF3C1C8]
       int       3
M10_L03:
       mov       rdx,[rcx+18]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M10_L04
       jmp       short M10_L05
M10_L04:
       mov       rdx,7FFB0F477BA8
       call      qword ptr [7FFB0EF37AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdx,rax
M10_L05:
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
       je        near ptr M12_L08
M12_L00:
       mov       rcx,[rbx+10]
       mov       rdx,[rcx]
       mov       rdi,rdx
       test      rdi,rdi
       je        short M12_L01
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache
       cmp       [rdi],rcx
       jne       near ptr M12_L09
M12_L01:
       test      rdi,rdi
       jne       near ptr M12_L07
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
       call      00007FFB6E8C1870
       mov       r14,rax
       test      r14,r14
       je        near ptr M12_L10
M12_L02:
       mov       rax,[r14+8]
       test      rax,rax
       jne       near ptr M12_L05
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
       mov       rax,7FFB0EE16D90
       mov       [rbp-78],rax
       lea       rax,[M12_L03]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFB6E852C30
       call      rax
M12_L03:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFB6EC1F778],0
       je        short M12_L04
       call      qword ptr [7FFB6EC0D608]; CORINFO_HELP_STOP_FOR_GC
M12_L04:
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
M12_L05:
       cmp       rax,rbx
       sete      cl
       mov       rdi,[rbp-0A0]
       mov       [rdi+9C],cl
       mov       rcx,[rbx+10]
       mov       rdx,rdi
       xor       r8d,r8d
       call      00007FFB6E8D04E0
       mov       rdx,rax
       test      rdx,rdx
       je        short M12_L06
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache
       cmp       [rdx],rcx
       jne       short M12_L11
M12_L06:
       test      rdx,rdx
       cmovne    rdi,rdx
M12_L07:
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
M12_L08:
       mov       [rbp-40],rbx
       lea       rcx,[rbp-40]
       mov       edx,1
       call      qword ptr [7FFB0F42E388]; System.RuntimeTypeHandle.GetGCHandle(System.Runtime.InteropServices.GCHandleType)
       mov       rdx,rax
       lea       rcx,[rbx+10]
       xor       eax,eax
       lock cmpxchg [rcx],rdx
       test      rax,rax
       je        near ptr M12_L00
       lea       rcx,[rbp-40]
       call      qword ptr [7FFB0F427960]
       jmp       near ptr M12_L00
M12_L09:
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M12_L10:
       mov       [rbp+10],rbx
       mov       rcx,rbx
       call      qword ptr [7FFB0ECB7C90]; System.RuntimeTypeHandle.<GetModule>g__GetModuleWorker|48_0(System.RuntimeType)
       mov       r14,rax
       mov       rbx,[rbp+10]
       jmp       near ptr M12_L02
M12_L11:
       mov       rdx,rax
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
; Total bytes of code 566
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
       mov       rax,0FE61F5BFD5D
       mov       [rbp],rax
       mov       rsi,rcx
       mov       rbx,rdx
       mov       edi,r8d
       mov       r14d,r9d
       test      rbx,rbx
       je        near ptr M13_L06
       cmp       dword ptr [rbx+8],0
       je        near ptr M13_L06
       cmp       r14d,1
       jne       short M13_L00
       movzx     r15d,word ptr [rbx+0C]
       cmp       r15d,2E
       jne       short M13_L01
       mov       rcx,7FFB0F5D4150
       call      CORINFO_HELP_COUNTPROFILE32
M13_L00:
       mov       rcx,2CD80000220
       mov       r15,[rcx]
       mov       rcx,r15
       mov       rdx,7FFB0F5D4158
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rcx,r15
       mov       rdx,rbx
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+18]
       mov       r15d,eax
       cmp       r15d,400
       jbe       short M13_L02
       movsxd    rdx,r15d
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       r13,[rax+10]
       mov       r15d,[rax+8]
       jmp       short M13_L04
M13_L01:
       cmp       r15d,2A
       jne       near ptr M13_L05
       mov       rcx,7FFB0F5D414C
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M13_L00
M13_L02:
       mov       rcx,7FFB0F5D4260
       call      CORINFO_HELP_COUNTPROFILE32
       mov       edx,r15d
       mov       r13,rdx
       test      r13,r13
       je        short M13_L04
       mov       rcx,r13
       add       rcx,0F
       and       rcx,0FFFFFFFFFFFFFFF0
       add       rsp,30
       neg       rcx
       add       rcx,rsp
       jb        short M13_L03
       xor       ecx,ecx
M13_L03:
       test      [rsp],esp
       sub       rsp,1000
       cmp       rsp,rcx
       jae       short M13_L03
       mov       rsp,rcx
       test      [rsp],esp
       sub       rsp,30
       lea       r13,[rsp+30]
M13_L04:
       mov       rcx,7FFB0F5D4264
       call      CORINFO_HELP_COUNTPROFILE32
       mov       [rbp+8],r13
       mov       [rbp+10],r15d
       mov       [rsp+20],r14d
       lea       r8,[rbp+8]
       mov       rdx,rbx
       mov       rcx,rsi
       mov       r9d,edi
       call      qword ptr [7FFB0ECBD320]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].GetListByName(System.String, System.Span`1<Byte>, MemberListType, CacheType)
       mov       [rbp+18],rax
       jmp       short M13_L07
M13_L05:
       mov       rcx,7FFB0F5D4148
       call      CORINFO_HELP_COUNTPROFILE32
M13_L06:
       xor       r8d,r8d
       mov       [rbp+8],r8
       mov       [rbp+10],r8d
       mov       [rsp+20],r14d
       lea       r8,[rbp+8]
       mov       rcx,rsi
       mov       r9d,edi
       mov       rdx,30E14FE0008
       call      qword ptr [7FFB0ECBD320]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].GetListByName(System.String, System.Span`1<Byte>, MemberListType, CacheType)
       mov       [rbp+18],rax
M13_L07:
       mov       rcx,7FFB0F5D4268
       call      CORINFO_HELP_COUNTPROFILE32
       lea       rdx,[rbp+18]
       mov       rcx,rsi
       mov       r8,rbx
       mov       r9d,edi
       call      qword ptr [7FFB0ECBD578]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Insert(System.__Canon[] ByRef, System.String, MemberListType)
       mov       rax,[rbp+18]
       mov       r8,0FE61F5BFD5D
       cmp       [rbp],r8
       je        short M13_L08
       call      CORINFO_HELP_FAIL_FAST
M13_L08:
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
       jl        near ptr M14_L04
       mov       rdi,[rsi]
       test      rdi,rdi
       je        near ptr M14_L05
       mov       ebp,[rdi+8]
       cmp       ebp,ebx
       je        short M14_L02
       mov       rdx,[rcx+18]
       mov       rax,[rdx+18]
       test      rax,rax
       je        short M14_L03
       mov       rcx,rax
M14_L00:
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
       ja        near ptr M14_L09
       call      00007FFB6E8B5D60
       cmp       dword ptr [7FFB6EC1F778],0
       jne       short M14_L08
M14_L01:
       mov       rcx,rsi
       mov       rdx,r14
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M14_L02:
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M14_L03:
       mov       rdx,7FFB0F4765B8
       call      qword ptr [7FFB0EF37AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M14_L00
M14_L04:
       mov       ecx,45
       mov       edx,0D
       call      qword ptr [7FFB0F2C58D8]
       int       3
M14_L05:
       mov       rdx,[rcx+18]
       mov       rax,[rdx+18]
       test      rax,rax
       je        short M14_L06
       mov       rcx,rax
       jmp       short M14_L07
M14_L06:
       mov       rdx,7FFB0F4765B8
       call      qword ptr [7FFB0EF37AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M14_L07:
       mov       edx,ebx
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdx,rax
       mov       rcx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       short M14_L02
M14_L08:
       call      CORINFO_HELP_POLL_GC
       jmp       short M14_L01
M14_L09:
       call      qword ptr [7FFB0F2CDB78]
       jmp       near ptr M14_L01
; Total bytes of code 257
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M15_L00
       ret
M15_L00:
       jmp       qword ptr [7FFB0ECB5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
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
       jne       short M16_L01
       mov       ebx,[rdx+5C]
M16_L00:
       and       ebx,7
       cmp       ebx,6
       sete      al
       movzx     eax,al
       add       rsp,20
       pop       rbx
       ret
M16_L01:
       mov       rcx,rdx
       mov       rax,[rdx]
       mov       rax,[rax+50]
       call      qword ptr [rax+20]
       mov       ebx,eax
       jmp       short M16_L00
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
       je        short M17_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M17_L00:
       call      qword ptr [7FFB0F427030]
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
       jo        near ptr M18_L57
       mov       [rbx+4],edx
       cmp       dword ptr [rbx+4],7FFFFFC7
       jg        near ptr M18_L46
       movsxd    rbp,ecx
       add       rbp,rbp
       cmp       rbp,10
       jle       short M18_L00
       cmp       rbp,7FFFFFC7
       jle       short M18_L01
       mov       r14d,7FFFFFC7
       jmp       short M18_L02
M18_L00:
       mov       ebp,10
M18_L01:
       mov       r14,rbp
M18_L02:
       lea       rbp,[rbx+10]
       mov       r15d,[rbx]
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],98
       jle       near ptr M18_L06
       mov       rcx,[rcx+98]
       test      rcx,rcx
       je        near ptr M18_L06
M18_L03:
       cmp       r15d,1B
       jae       near ptr M18_L56
       mov       eax,r15d
       lea       rbp,[rbp+rax*8]
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r15,[rax]
       mov       r13d,r14d
       mov       rcx,2CD80000C90
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
       je        near ptr M18_L07
       mov       r8d,[rsp+5C]
       cmp       [rax+8],r8d
       jbe       near ptr M18_L07
       mov       ecx,r8d
       shl       rcx,4
       mov       r10,[rax+rcx+10]
       test      r10,r10
       je        near ptr M18_L07
       mov       r14,r10
       mov       r13d,[rsp+5C]
       mov       ecx,r13d
       shl       rcx,4
       xor       edx,edx
       mov       [rax+rcx+10],rdx
       cmp       byte ptr [r12+9D],0
       je        near ptr M18_L35
       mov       rcx,r14
       call      qword ptr [7FFB0F15C900]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+4C],eax
       mov       edx,[r14+8]
       mov       [rsp+48],edx
       mov       rcx,r15
       call      00007FFB6E8B6270
       mov       r9d,eax
       test      r9d,r9d
       je        near ptr M18_L47
M18_L04:
       mov       [rsp+20],r13d
       mov       rcx,r12
       mov       edx,[rsp+4C]
       mov       r8d,[rsp+48]
       call      qword ptr [7FFB0F426B20]
       jmp       near ptr M18_L35
M18_L05:
       mov       rcx,r15
       call      qword ptr [7FFB0ECBE928]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       mov       r9d,eax
       jmp       near ptr M18_L34
M18_L06:
       mov       rcx,rdi
       mov       rdx,7FFB0F478FA8
       call      qword ptr [7FFB0ECBC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M18_L03
M18_L07:
       mov       rax,[r15+10]
       mov       r8d,[rsp+5C]
       cmp       [rax+8],r8d
       ja        short M18_L13
       test      r13d,r13d
       je        short M18_L08
       test      r13d,r13d
       jge       near ptr M18_L29
       jmp       near ptr M18_L53
M18_L08:
       mov       rcx,[r15]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx+8]
       cmp       qword ptr [rdx+8],40
       jle       short M18_L11
       mov       rax,[rdx+40]
       test      rax,rax
       je        short M18_L11
       mov       rcx,rax
M18_L09:
       mov       rdx,[rcx+18]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M18_L12
M18_L10:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r14,[rax]
       jmp       near ptr M18_L35
M18_L11:
       mov       rdx,7FFB0F4790F0
       call      qword ptr [7FFB0ECBC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M18_L09
M18_L12:
       mov       rdx,7FFB0F473380
       call      qword ptr [7FFB0EF37AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       short M18_L10
M18_L13:
       mov       ecx,r8d
       mov       rcx,[rax+rcx*8+10]
       test      rcx,rcx
       je        near ptr M18_L28
       mov       r13,[rcx+8]
       test      byte ptr [7FFB0F48A000],1
       je        near ptr M18_L48
M18_L14:
       cmp       byte ptr [7FFB0EBFB184],0
       jne       short M18_L17
       mov       rcx,gs:[58]
       mov       rcx,[rcx+38]
       cmp       dword ptr [rcx+238],0B
       jle       near ptr M18_L49
       mov       rcx,[rcx+240]
       mov       rax,[rcx+58]
       test      rax,rax
       je        near ptr M18_L49
M18_L15:
       mov       r14d,[rax+10]
       lea       ecx,[r14-1]
       mov       [rax+10],ecx
       movzx     eax,r14w
       test      eax,eax
       je        short M18_L16
       sar       r14d,10
       jmp       short M18_L18
M18_L16:
       call      qword ptr [7FFB0F426B68]
       mov       r14d,eax
       jmp       short M18_L18
M18_L17:
       call      qword ptr [7FFB0F426B38]
       mov       r14d,eax
M18_L18:
       test      byte ptr [7FFB0F489E90],1
       je        near ptr M18_L50
M18_L19:
       mov       eax,r14d
       xor       edx,edx
       div       dword ptr [7FFB0EBFB178]
       mov       r14d,edx
       mov       eax,[r13+8]
       mov       [rsp+44],eax
       test      eax,eax
       jle       near ptr M18_L52
       mov       [rsp+40],eax
M18_L20:
       cmp       r14d,eax
       jae       near ptr M18_L56
       mov       ecx,r14d
       mov       r8,[r13+rcx*8+10]
       mov       [rsp+30],r8
       cmp       [r8],r8b
       xor       r10d,r10d
       mov       [rsp+38],r10
       mov       rcx,r8
       call      00007FFB6E7F9E20
       test      eax,eax
       je        near ptr M18_L51
M18_L21:
       mov       rax,[rsp+30]
       mov       rcx,[rax+8]
       mov       edx,[rax+10]
       dec       edx
       cmp       [rcx+8],edx
       ja        short M18_L25
M18_L22:
       mov       rcx,rax
       call      00007FFB6E8B6030
       test      eax,eax
       je        short M18_L23
       mov       ecx,eax
       mov       rdx,[rsp+30]
       call      qword ptr [7FFB0F426B98]
M18_L23:
       mov       r10,[rsp+38]
       test      r10,r10
       jne       short M18_L27
       inc       r14d
       mov       r10d,[rsp+44]
       cmp       r10d,r14d
       je        short M18_L26
M18_L24:
       mov       edx,[rsp+40]
       dec       edx
       mov       [rsp+40],edx
       mov       eax,r10d
       jne       near ptr M18_L20
       jmp       near ptr M18_L52
M18_L25:
       mov       r8d,edx
       mov       r10,[rcx+r8*8+10]
       mov       [rsp+38],r10
       xor       r9d,r9d
       mov       [rcx+r8*8+10],r9
       mov       [rax+10],edx
       jmp       short M18_L22
M18_L26:
       xor       r14d,r14d
       jmp       short M18_L24
M18_L27:
       mov       r14,r10
       test      r14,r14
       jne       near ptr M18_L43
M18_L28:
       mov       ecx,10
       mov       r8d,[rsp+5C]
       shlx      r13d,ecx,r8d
M18_L29:
       mov       rcx,[r15]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx+8]
       cmp       qword ptr [rdx+8],38
       jle       near ptr M18_L39
       mov       rax,[rdx+38]
       test      rax,rax
       je        near ptr M18_L39
       mov       rcx,rax
M18_L30:
       mov       rdx,[rcx+18]
       mov       rax,[rdx+18]
       test      rax,rax
       je        near ptr M18_L40
       mov       rcx,rax
M18_L31:
       movsxd    rdx,r13d
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       cmp       byte ptr [r12+9D],0
       je        near ptr M18_L35
       mov       rcx,r14
       call      00007FFB6E8B6270
       mov       r13d,eax
       test      r13d,r13d
       je        near ptr M18_L41
M18_L32:
       mov       eax,[r14+8]
       mov       [rsp+58],eax
       mov       rcx,r15
       call      00007FFB6E8B6270
       mov       r9d,eax
       test      r9d,r9d
       je        near ptr M18_L42
M18_L33:
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       rcx,r12
       mov       edx,r13d
       mov       r8d,[rsp+58]
       call      qword ptr [7FFB0F426B20]
       mov       eax,[r14+8]
       mov       [rsp+54],eax
       mov       rcx,r15
       call      00007FFB6E8B6270
       mov       r9d,eax
       test      r9d,r9d
       je        near ptr M18_L05
M18_L34:
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
       call      qword ptr [7FFB0F426BB0]
M18_L35:
       mov       rcx,rbp
       mov       rdx,r14
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0A0
       jle       near ptr M18_L44
       mov       rcx,[rcx+0A0]
       test      rcx,rcx
       je        near ptr M18_L44
M18_L36:
       test      r14,r14
       je        near ptr M18_L54
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+20]
       test      rax,rax
       je        near ptr M18_L45
M18_L37:
       cmp       [r14],rax
       jne       near ptr M18_L55
       lea       rdi,[r14+10]
       mov       ebp,[r14+8]
M18_L38:
       mov       [rbx+0F8],rdi
       mov       [rbx+100],ebp
       inc       dword ptr [rbx]
       lea       rcx,[rbx+0F8]
       cmp       dword ptr [rcx+8],0
       jbe       near ptr M18_L56
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
M18_L39:
       mov       rdx,7FFB0F4790D0
       call      qword ptr [7FFB0ECBC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M18_L30
M18_L40:
       mov       rdx,7FFB0F479188
       call      qword ptr [7FFB0EF37AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M18_L31
M18_L41:
       mov       rcx,r14
       call      qword ptr [7FFB0ECBE928]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       mov       r13d,eax
       jmp       near ptr M18_L32
M18_L42:
       mov       rcx,r15
       call      qword ptr [7FFB0ECBE928]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       mov       r9d,eax
       jmp       near ptr M18_L33
M18_L43:
       cmp       byte ptr [r12+9D],0
       je        near ptr M18_L35
       mov       rcx,r14
       call      qword ptr [7FFB0F15C900]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r13d,eax
       mov       eax,[r14+8]
       mov       [rsp+50],eax
       mov       rcx,r15
       call      qword ptr [7FFB0F15C900]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       r15d,[rsp+5C]
       mov       [rsp+20],r15d
       mov       edx,r13d
       mov       r8d,[rsp+50]
       mov       rcx,r12
       call      qword ptr [7FFB0F426B20]
       jmp       near ptr M18_L35
M18_L44:
       mov       rcx,rdi
       mov       rdx,7FFB0F478FB8
       call      qword ptr [7FFB0ECBC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M18_L36
M18_L45:
       mov       rdx,7FFB0F476548
       call      qword ptr [7FFB0ECBC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M18_L37
M18_L46:
       mov       rcx,offset MT_System.OutOfMemoryException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB0F427828]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M18_L47:
       mov       rcx,r15
       call      qword ptr [7FFB0ECBE928]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       mov       r9d,eax
       jmp       near ptr M18_L04
M18_L48:
       mov       rcx,offset MT_System.Threading.ProcessorIdCache
       call      qword ptr [7FFB0ECB5740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M18_L14
M18_L49:
       mov       ecx,0B
       call      qword ptr [7FFB0F426B50]
       jmp       near ptr M18_L15
M18_L50:
       mov       rcx,offset MT_System.Buffers.SharedArrayPoolStatics
       call      qword ptr [7FFB0ECB5740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M18_L19
M18_L51:
       mov       rcx,[rsp+30]
       call      qword ptr [7FFB0F426B80]
       jmp       near ptr M18_L21
M18_L52:
       xor       r10d,r10d
       jmp       near ptr M18_L27
M18_L53:
       mov       ecx,172EC
       mov       rdx,7FFB0EBF4000
       call      qword ptr [7FFB0EF37738]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FFB0F425C38]
       int       3
M18_L54:
       xor       edi,edi
       xor       ebp,ebp
       jmp       near ptr M18_L38
M18_L55:
       call      qword ptr [7FFB0F427408]
       int       3
M18_L56:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M18_L57:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 1739
```
```assembly
; <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan[[System.Collections.Generic.SegmentedArrayBuilder`1+Arrays[[System.__Canon, System.Private.CoreLib]], System.Linq],[System.__Canon, System.Private.CoreLib]](Arrays<System.__Canon> ByRef, Int32)
       mov       [rcx],r8
       mov       [rcx+8],r9d
       mov       rax,rcx
       ret
; Total bytes of code 11
```
```assembly
; System.ReadOnlySpan`1[[System.__Canon, System.Private.CoreLib]].Slice(Int32, Int32)
       sub       rsp,28
       mov       eax,[rsp+50]
       mov       r8d,r9d
       mov       r10d,eax
       add       r10,r8
       mov       r9d,[rcx+8]
       cmp       r10,r9
       ja        short M20_L00
       mov       rcx,[rcx]
       lea       rcx,[rcx+r8*8]
       mov       [rdx],rcx
       mov       [rdx+8],eax
       mov       rax,rdx
       add       rsp,28
       ret
M20_L00:
       call      qword ptr [7FFB0EE57138]
       int       3
; Total bytes of code 54
```
```assembly
; System.ReadOnlySpan`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.__Canon[])
       test      r8,r8
       je        short M21_L01
       lea       rax,[r8+10]
       mov       [rcx],rax
       mov       eax,[r8+8]
       mov       [rcx+8],eax
M21_L00:
       ret
M21_L01:
       xor       eax,eax
       mov       [rcx],rax
       mov       [rcx+8],rax
       jmp       short M21_L00
; Total bytes of code 31
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rdx,rdx
       je        short M22_L01
       mov       rax,[rdx]
       movzx     r8d,word ptr [rax+0E]
       test      r8,r8
       je        short M22_L05
       mov       r10,[rax+38]
       cmp       r8,4
       jl        short M22_L04
       cmp       [r10],rcx
       je        short M22_L01
M22_L00:
       cmp       [r10+8],rcx
       je        short M22_L01
       cmp       [r10+10],rcx
       jne       short M22_L03
M22_L01:
       mov       rax,rdx
       ret
M22_L02:
       cmp       [r10],rcx
       je        short M22_L01
       jmp       short M22_L00
M22_L03:
       cmp       [r10+18],rcx
       je        short M22_L01
       add       r10,20
       add       r8,0FFFFFFFFFFFFFFFC
       cmp       r8,4
       jge       short M22_L02
       test      r8,r8
       je        short M22_L05
M22_L04:
       cmp       [r10],rcx
       je        short M22_L01
       add       r10,8
       dec       r8
       test      r8,r8
       jg        short M22_L04
M22_L05:
       test      dword ptr [rax],500C0000
       jne       short M22_L06
       xor       edx,edx
       jmp       short M22_L01
M22_L06:
       jmp       qword ptr [7FFB0F0BD4B8]
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
       call      qword ptr [7FFB6CC18600]
       mov       rcx,rsi
       mov       r11,rax
       call      qword ptr [rax]
       mov       edi,eax
       test      edi,edi
       je        short M23_L00
       mov       rcx,rbx
       call      qword ptr [7FFB6CC17A48]
       mov       rcx,rax
       movsxd    rdx,edi
       call      qword ptr [7FFB6CC156D8]; CORINFO_HELP_NEWARR_1_DIRECT
       mov       rdi,rax
       mov       rcx,rbx
       call      qword ptr [7FFB6CC18608]
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
M23_L00:
       mov       rcx,rbx
       call      qword ptr [7FFB6CC18228]
       mov       rcx,rax
       lea       rax,[System.Linq.Enumerable.Select[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>)]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax]
; Total bytes of code 128
```

## .NET 10.0.0 (10.0.0, 10.0.25.52411), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark.GetAllStaticMethods()
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+30],ymm4
       mov       [rsp+50],rax
       mov       rbx,rcx
       mov       rcx,2513E831160
       mov       rsi,[rcx]
       test      rsi,rsi
       je        short M00_L02
M00_L00:
       cmp       [rsi],sil
       lea       rdi,[rsi+40]
       mov       rcx,[rdi]
       test      rcx,rcx
       jne       short M00_L01
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache+MemberInfoCache<System.Reflection.RuntimeMethodInfo>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       rdx,rbp
       xor       r8d,r8d
       call      00007FFB6E8BFBA0
       mov       rcx,rax
       test      rcx,rcx
       cmove     rcx,rbp
M00_L01:
       cmp       byte ptr [rcx+18],0
       je        short M00_L03
       mov       rsi,[rcx+8]
       jmp       short M00_L04
M00_L02:
       mov       rcx,291D3E00668
       call      qword ptr [7FFB0ECD7C48]; System.RuntimeType.InitializeCache()
       mov       rsi,rax
       jmp       short M00_L00
M00_L03:
       xor       edx,edx
       xor       r8d,r8d
       xor       r9d,r9d
       call      qword ptr [7FFB0ECDD2C0]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
       mov       rsi,rax
M00_L04:
       mov       edi,[rsi+8]
       mov       edx,edi
       xor       r8d,r8d
       mov       [rsp+40],r8
       mov       [rsp+48],r8
       mov       [rsp+50],r8d
       mov       [rsp+54],edx
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
       cmp       dword ptr [rsp+50],0
       je        short M00_L11
       cmp       dword ptr [rsp+50],1
       je        short M00_L09
       mov       edx,[rsp+54]
       cmp       edx,[rsp+50]
       je        near ptr M00_L23
M00_L06:
       movsxd    rdx,dword ptr [rsp+50]
       mov       rcx,[rsp+40]
       mov       r8,r14
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
M00_L07:
       mov       edx,[rsp+50]
       inc       edx
       mov       [rsp+50],edx
M00_L08:
       add       rbp,8
       jmp       short M00_L05
M00_L09:
       cmp       dword ptr [rsp+54],2
       jl        near ptr M00_L22
M00_L10:
       movsxd    rdx,dword ptr [rsp+54]
       mov       rcx,offset MT_System.Reflection.MethodInfo[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       [rsp+40],rax
       mov       rcx,[rsp+40]
       mov       r8,[rsp+48]
       xor       edx,edx
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       short M00_L06
M00_L11:
       mov       [rsp+48],r14
       jmp       short M00_L07
M00_L12:
       mov       rsi,[rsp+40]
       mov       rdi,[rsp+48]
       mov       ebp,[rsp+50]
       test      ebp,ebp
       je        near ptr M00_L24
       cmp       ebp,1
       je        near ptr M00_L25
       test      ebp,ebp
       jl        near ptr M00_L26
       test      rsi,rsi
       je        near ptr M00_L27
       cmp       [rsi+8],ebp
       je        short M00_L15
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
       jbe       short M00_L13
       call      qword ptr [7FFB0F424168]
       jmp       short M00_L14
M00_L13:
       call      00007FFB6E8B5D60
       cmp       dword ptr [7FFB6EC1F778],0
       jne       near ptr M00_L28
M00_L14:
       mov       rsi,rdi
M00_L15:
       mov       rcx,251550000D0
       mov       rdi,[rcx]
       test      rdi,rdi
       je        near ptr M00_L29
M00_L16:
       test      rsi,rsi
       je        near ptr M00_L30
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<System.Reflection.MethodInfo>
       call      qword ptr [7FFB0ECD6850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L31
       mov       rdx,rsi
       mov       rcx,offset MT_System.Reflection.MethodInfo[]
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
       mov       rbp,rax
       test      rbp,rbp
       je        near ptr M00_L33
       cmp       dword ptr [rbp+8],0
       je        near ptr M00_L32
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
M00_L17:
       mov       rdx,r14
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<System.Reflection.MethodInfo>
       call      qword ptr [7FFB0ECD6850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M00_L36
       mov       rdx,offset MT_System.Linq.Enumerable+ArrayWhereIterator<System.Reflection.MethodInfo>
       cmp       [rax],rdx
       jne       near ptr M00_L35
       mov       rdx,[rax+18]
       test      rdx,rdx
       je        near ptr M00_L21
       lea       r8,[rdx+10]
       mov       edx,[rdx+8]
M00_L18:
       mov       [rsp+28],r8
       mov       [rsp+30],edx
       lea       rdx,[rsp+28]
       mov       r8,[rax+20]
       mov       rcx,offset MT_System.Linq.Enumerable+ArrayWhereIterator<System.Reflection.MethodInfo>
       call      qword ptr [7FFB0F357138]; System.Linq.Enumerable+ArrayWhereIterator`1[[System.__Canon, System.Private.CoreLib]].ToArray(System.ReadOnlySpan`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rsi,rax
M00_L19:
       test      rsi,rsi
       je        near ptr M00_L38
       cmp       dword ptr [rsi+8],0
       je        near ptr M00_L39
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<System.Reflection.MethodInfo>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M00_L20:
       mov       [rsp+38],rdi
       mov       rcx,[rbx+18]
       lea       r8,[rsp+38]
       mov       rdx,7FFB0F3C6420
       cmp       [rcx],ecx
       call      qword ptr [7FFB0F357588]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M00_L21:
       xor       r8d,r8d
       xor       edx,edx
       jmp       near ptr M00_L18
M00_L22:
       mov       dword ptr [rsp+54],4
       jmp       near ptr M00_L10
M00_L23:
       mov       r15d,[rsp+54]
       add       r15d,r15d
       lea       rdx,[rsp+40]
       mov       r8d,r15d
       mov       rcx,7FFB0EE57750
       call      qword ptr [7FFB0ECDD4E8]; System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
       mov       [rsp+54],r15d
       jmp       near ptr M00_L06
M00_L24:
       mov       rcx,offset MT_System.Array+EmptyArray<System.Reflection.MethodInfo>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,25155000160
       mov       rsi,[rcx]
       jmp       near ptr M00_L15
M00_L25:
       mov       rcx,offset MT_System.Reflection.MethodInfo[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rdi
       xor       edx,edx
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       near ptr M00_L15
M00_L26:
       mov       ecx,45
       mov       edx,0D
       call      qword ptr [7FFB0F2E58C0]
       int       3
M00_L27:
       mov       edx,ebp
       mov       rcx,offset MT_System.Reflection.MethodInfo[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rsi,rax
       jmp       near ptr M00_L15
M00_L28:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L14
M00_L29:
       mov       rcx,offset MT_System.Func<System.Reflection.MethodInfo, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,251550000A0
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Core.TypeHelper+<>c.<GetAllPublicMethods>b__24_0(System.Reflection.MethodInfo)
       call      qword ptr [7FFB0ECD6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,251550000D0
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L16
M00_L30:
       mov       ecx,11
       call      qword ptr [7FFB0EF57DF8]
       int       3
M00_L31:
       mov       rcx,rax
       mov       rdx,rdi
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+8]
       mov       r14,rax
       jmp       near ptr M00_L17
M00_L32:
       mov       rcx,offset MT_System.Array+EmptyArray<System.Reflection.MethodInfo>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,25155000160
       mov       r14,[rdx]
       jmp       near ptr M00_L17
M00_L33:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Generic.List<System.Reflection.MethodInfo>
       call      qword ptr [7FFB0ECD6850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r14,rax
       test      r14,r14
       je        short M00_L34
       mov       rcx,offset MT_System.Linq.Enumerable+ListWhereIterator<System.Reflection.MethodInfo>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,r14
       mov       r8,rdi
       call      qword ptr [7FFB0F424C48]
       mov       r14,rsi
       jmp       near ptr M00_L17
M00_L34:
       mov       rcx,offset MT_System.Linq.Enumerable+IEnumerableWhereIterator<System.Reflection.MethodInfo>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       rdx,rsi
       mov       r8,rdi
       call      qword ptr [7FFB0F424C60]
       jmp       near ptr M00_L17
M00_L35:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rsi,rax
       jmp       near ptr M00_L19
M00_L36:
       mov       rdx,r14
       mov       rcx,offset MT_System.Collections.Generic.ICollection<System.Reflection.MethodInfo>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M00_L37
       mov       rdx,rax
       mov       rcx,7FFB0F4335C8
       call      qword ptr [7FFB0F0D7A38]; System.Linq.Enumerable.ICollectionToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>)
       mov       rsi,rax
       jmp       near ptr M00_L19
M00_L37:
       mov       rdx,r14
       mov       rcx,7FFB0F433650
       call      qword ptr [7FFB0F4245E8]
       mov       rsi,rax
       jmp       near ptr M00_L19
M00_L38:
       mov       ecx,2
       call      qword ptr [7FFB0EF5C1C8]
       int       3
M00_L39:
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<System.Reflection.MethodInfo>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,25155000178
       mov       rdi,[rcx]
       jmp       near ptr M00_L20
; Total bytes of code 1428
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
       call      00007FFB6E8C1870
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
       mov       rax,7FFB0EE36D90
       mov       [rbp-78],rax
       lea       rax,[M01_L03]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFB6E852C30
       call      rax
M01_L03:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFB6EC1F778],0
       je        short M01_L04
       call      qword ptr [7FFB6EC0D608]; CORINFO_HELP_STOP_FOR_GC
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
       call      00007FFB6E8D04E0
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
       call      qword ptr [7FFB0F4274F8]; System.RuntimeTypeHandle.GetGCHandle(System.Runtime.InteropServices.GCHandleType)
       mov       rdx,rax
       lea       rcx,[rbx+10]
       xor       eax,eax
       lock cmpxchg [rcx],rdx
       test      rax,rax
       je        near ptr M01_L00
       lea       rcx,[rbp-40]
       call      qword ptr [7FFB0F424F60]
       jmp       near ptr M01_L00
M01_L09:
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M01_L10:
       mov       [rbp+10],rbx
       mov       rcx,rbx
       call      qword ptr [7FFB0ECD7C90]; System.RuntimeTypeHandle.<GetModule>g__GetModuleWorker|48_0(System.RuntimeType)
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
       mov       rax,5F08E78556AA
       mov       [rbp],rax
       mov       rsi,rcx
       mov       rbx,rdx
       mov       edi,r8d
       mov       r14d,r9d
       test      rbx,rbx
       je        near ptr M02_L06
       cmp       dword ptr [rbx+8],0
       je        near ptr M02_L06
       cmp       r14d,1
       jne       short M02_L00
       movzx     r15d,word ptr [rbx+0C]
       cmp       r15d,2E
       jne       short M02_L01
       mov       rcx,7FFB0F5A48F8
       call      CORINFO_HELP_COUNTPROFILE32
M02_L00:
       mov       rcx,2513F000220
       mov       r15,[rcx]
       mov       rcx,r15
       mov       rdx,7FFB0F5A4900
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rcx,r15
       mov       rdx,rbx
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+18]
       mov       r15d,eax
       cmp       r15d,400
       jbe       short M02_L02
       movsxd    rdx,r15d
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       r13,[rax+10]
       mov       r15d,[rax+8]
       jmp       short M02_L04
M02_L01:
       cmp       r15d,2A
       jne       near ptr M02_L05
       mov       rcx,7FFB0F5A48F4
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M02_L00
M02_L02:
       mov       rcx,7FFB0F5A4A08
       call      CORINFO_HELP_COUNTPROFILE32
       mov       edx,r15d
       mov       r13,rdx
       test      r13,r13
       je        short M02_L04
       mov       rcx,r13
       add       rcx,0F
       and       rcx,0FFFFFFFFFFFFFFF0
       add       rsp,30
       neg       rcx
       add       rcx,rsp
       jb        short M02_L03
       xor       ecx,ecx
M02_L03:
       test      [rsp],esp
       sub       rsp,1000
       cmp       rsp,rcx
       jae       short M02_L03
       mov       rsp,rcx
       test      [rsp],esp
       sub       rsp,30
       lea       r13,[rsp+30]
M02_L04:
       mov       rcx,7FFB0F5A4A0C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       [rbp+8],r13
       mov       [rbp+10],r15d
       mov       [rsp+20],r14d
       lea       r8,[rbp+8]
       mov       rdx,rbx
       mov       rcx,rsi
       mov       r9d,edi
       call      qword ptr [7FFB0ECDD320]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].GetListByName(System.String, System.Span`1<Byte>, MemberListType, CacheType)
       mov       [rbp+18],rax
       jmp       short M02_L07
M02_L05:
       mov       rcx,7FFB0F5A48F0
       call      CORINFO_HELP_COUNTPROFILE32
M02_L06:
       xor       r8d,r8d
       mov       [rbp+8],r8
       mov       [rbp+10],r8d
       mov       [rsp+20],r14d
       lea       r8,[rbp+8]
       mov       rcx,rsi
       mov       r9d,edi
       mov       rdx,291D3DF0008
       call      qword ptr [7FFB0ECDD320]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].GetListByName(System.String, System.Span`1<Byte>, MemberListType, CacheType)
       mov       [rbp+18],rax
M02_L07:
       mov       rcx,7FFB0F5A4A10
       call      CORINFO_HELP_COUNTPROFILE32
       lea       rdx,[rbp+18]
       mov       rcx,rsi
       mov       r8,rbx
       mov       r9d,edi
       call      qword ptr [7FFB0ECDD578]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Insert(System.__Canon[] ByRef, System.String, MemberListType)
       mov       rax,[rbp+18]
       mov       r8,5F08E78556AA
       cmp       [rbp],r8
       je        short M02_L08
       call      CORINFO_HELP_FAIL_FAST
M02_L08:
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
       jmp       qword ptr [7FFB0ECDD8F0]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
M03_L00:
       call      qword ptr [7FFB0F35FBD0]
       int       3
M03_L01:
       mov       rcx,rax
       mov       rdx,r8
       add       rsp,28
       jmp       near ptr 00007FFB6E907B10
M03_L02:
       xor       ecx,ecx
       mov       [rax],rcx
       add       rsp,28
       ret
; Total bytes of code 94
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rdx,rdx
       je        short M04_L02
       mov       rax,[rdx]
       cmp       rax,rcx
       je        short M04_L02
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M04_L02
M04_L00:
       test      rax,rax
       je        short M04_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M04_L02
       test      rax,rax
       je        short M04_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M04_L02
       test      rax,rax
       jne       short M04_L03
M04_L01:
       xor       edx,edx
M04_L02:
       mov       rax,rdx
       ret
M04_L03:
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M04_L02
       test      rax,rax
       je        short M04_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M04_L02
       jmp       short M04_L00
; Total bytes of code 86
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
       push      rsi
       push      rbx
       test      rdx,rdx
       je        short M05_L02
       mov       rax,[rdx]
       cmp       rax,rcx
       je        short M05_L02
       mov       r8,2513F000038
       mov       r8,[r8]
       add       r8,10
       rorx      r10,rax,20
       xor       r10,rcx
       mov       r9,9E3779B97F4A7C15
       imul      r10,r9
       mov       r9d,[r8]
       shrx      r10,r10,r9
       xor       r9d,r9d
M05_L00:
       lea       r11d,[r10+1]
       movsxd    r11,r11d
       lea       r11,[r11+r11*2]
       lea       r11,[r8+r11*8]
       mov       ebx,[r11]
       mov       rsi,[r11+8]
       and       ebx,0FFFFFFFE
       cmp       rsi,rax
       jne       short M05_L03
       mov       rsi,rcx
       xor       rsi,[r11+10]
       cmp       rsi,1
       ja        short M05_L03
       cmp       ebx,[r11]
       jne       short M05_L04
M05_L01:
       cmp       esi,1
       je        short M05_L02
       test      esi,esi
       jne       short M05_L05
       xor       edx,edx
M05_L02:
       mov       rax,rdx
       pop       rbx
       pop       rsi
       ret
M05_L03:
       test      ebx,ebx
       je        short M05_L04
       inc       r9d
       add       r10d,r9d
       and       r10d,[r8+4]
       cmp       r9d,8
       jl        short M05_L00
M05_L04:
       mov       esi,2
       jmp       short M05_L01
M05_L05:
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFB0ECDD908]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny_NoCacheLookup(Void*, System.Object)
; Total bytes of code 166
```
```assembly
; System.Linq.Enumerable+ArrayWhereIterator`1[[System.__Canon, System.Private.CoreLib]].ToArray(System.ReadOnlySpan`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFEB0
M06_L00:
       vmovdqa   xmmword ptr [rsp+rax+180],xmm4
       vmovdqa   xmmword ptr [rsp+rax+190],xmm4
       vmovdqa   xmmword ptr [rsp+rax+1A0],xmm4
       add       rax,30
       jne       short M06_L00
       mov       [rsp+180],rcx
       mov       rbx,rcx
       mov       rsi,r8
       lea       rcx,[rsp+140]
       mov       [rsp+120],rcx
       mov       dword ptr [rsp+128],8
       lea       rcx,[rsp+140]
       mov       [rsp+130],rcx
       mov       dword ptr [rsp+138],8
       mov       rdi,[rdx]
       mov       ebp,[rdx+8]
       test      ebp,ebp
       jle       near ptr M06_L29
       test      rsi,rsi
       je        near ptr M06_L06
       mov       rcx,offset DotNetTips.Spargine.Core.TypeHelper+<>c.<GetAllPublicMethods>b__24_0(System.Reflection.MethodInfo)
       cmp       [rsi+18],rcx
       jne       near ptr M06_L06
       xor       esi,esi
       jmp       short M06_L03
M06_L01:
       mov       r15,[rsp+130]
       mov       r13d,[rsp+138]
       mov       r12d,[rsp+40]
       cmp       r12d,r13d
       jae       short M06_L05
       mov       ecx,r12d
       lea       rcx,[r15+rcx*8]
       mov       rdx,r14
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       ecx,[rsp+40]
       inc       ecx
       mov       [rsp+40],ecx
M06_L02:
       add       rsi,8
       dec       ebp
       je        near ptr M06_L29
M06_L03:
       mov       r14,[rdi+rsi]
       mov       rcx,offset MT_System.Reflection.RuntimeMethodInfo
       cmp       [r14],rcx
       jne       near ptr M06_L37
       mov       r15d,[r14+5C]
M06_L04:
       and       r15d,7
       cmp       r15d,6
       jne       short M06_L02
       mov       rcx,[rbx+30]
       mov       rcx,[rcx+8]
       mov       rdx,[rcx+50]
       test      rdx,rdx
       jne       short M06_L01
       mov       rcx,rbx
       mov       rdx,7FFB0F3D5E38
       call      qword ptr [7FFB0ECDC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M06_L01
M06_L05:
       lea       rcx,[rsp+38]
       mov       r8,r14
       call      qword ptr [7FFB0F3571B0]; System.Collections.Generic.SegmentedArrayBuilder`1[[System.__Canon, System.Private.CoreLib]].AddSlow(System.__Canon)
       jmp       short M06_L02
M06_L06:
       xor       r14d,r14d
       jmp       short M06_L09
M06_L07:
       mov       r15,[rsp+130]
       mov       r13d,[rsp+138]
       mov       ecx,[rsp+40]
       cmp       ecx,r13d
       jae       near ptr M06_L40
       mov       ecx,ecx
       lea       rcx,[r15+rcx*8]
       mov       rdx,r12
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       ecx,[rsp+40]
       inc       ecx
       mov       [rsp+40],ecx
M06_L08:
       add       r14,8
       dec       ebp
       je        near ptr M06_L29
M06_L09:
       mov       rcx,[rdi+r14]
       mov       r12,rcx
       mov       rcx,offset DotNetTips.Spargine.Core.TypeHelper+<>c.<GetAllPublicMethods>b__24_0(System.Reflection.MethodInfo)
       cmp       [rsi+18],rcx
       jne       near ptr M06_L38
       mov       rcx,offset MT_System.Reflection.RuntimeMethodInfo
       cmp       [r12],rcx
       jne       near ptr M06_L39
       mov       r15d,[r12+5C]
M06_L10:
       mov       edx,r15d
       and       edx,7
       cmp       edx,6
       jne       short M06_L08
M06_L11:
       mov       rcx,[rbx+30]
       mov       rcx,[rcx+8]
       mov       rdx,[rcx+50]
       test      rdx,rdx
       jne       near ptr M06_L07
       mov       rcx,rbx
       mov       rdx,7FFB0F3D5E38
       call      qword ptr [7FFB0ECDC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M06_L07
M06_L12:
       mov       rcx,rbx
       mov       rdx,7FFB0F3D5E38
       call      qword ptr [7FFB0ECDC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M06_L30
M06_L13:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0A8
       jle       short M06_L19
       mov       rcx,[rcx+0A8]
       test      rcx,rcx
       je        short M06_L19
M06_L14:
       mov       rdx,[rcx+18]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M06_L20
M06_L15:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r14,[rax]
M06_L16:
       mov       rcx,[rbx+30]
       mov       rcx,[rcx+8]
       mov       rdx,[rcx+50]
       test      rdx,rdx
       je        near ptr M06_L27
M06_L17:
       mov       r8d,[rsp+38]
       test      r8d,r8d
       jne       near ptr M06_L50
M06_L18:
       mov       rax,r14
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
M06_L19:
       mov       rcx,rsi
       mov       rdx,7FFB0F3D5EF8
       call      qword ptr [7FFB0ECDC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M06_L14
M06_L20:
       mov       rdx,7FFB0F3D39E8
       call      qword ptr [7FFB0EF57AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       short M06_L15
M06_L21:
       mov       rcx,rsi
       mov       rdx,7FFB0F3D61B8
       call      qword ptr [7FFB0ECDC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M06_L31
M06_L22:
       mov       rdx,7FFB0F3D3B18
       call      qword ptr [7FFB0EF57AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M06_L32
M06_L23:
       mov       rcx,rsi
       mov       rdx,7FFB0F3D3660
       call      qword ptr [7FFB0ECDC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M06_L33
M06_L24:
       mov       rdx,7FFB0F3D3380
       call      qword ptr [7FFB0ECDC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M06_L34
M06_L25:
       mov       rdx,[rsp+120]
       mov       r15d,[rsp+128]
       cmp       r15d,edi
       jg        near ptr M06_L28
       mov       r13d,r15d
       shl       r13,3
       mov       r8,r13
       mov       rcx,rbp
       call      qword ptr [7FFB0ECD57A0]; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       add       rbp,r13
       sub       edi,r15d
       mov       r13d,edi
       mov       r15,rbp
       dec       r12d
       je        near ptr M06_L35
       jmp       near ptr M06_L42
M06_L26:
       mov       rdx,[rsp+130]
       cmp       ecx,r13d
       ja        short M06_L28
       mov       r8d,ecx
       shl       r8,3
       cmp       r8,4000
       ja        near ptr M06_L49
       mov       rcx,r15
       call      00007FFB6E8B5D60
       cmp       dword ptr [7FFB6EC1F778],0
       je        near ptr M06_L16
       jmp       near ptr M06_L48
M06_L27:
       mov       rcx,rbx
       mov       rdx,7FFB0F3D5E38
       call      qword ptr [7FFB0ECDC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M06_L17
M06_L28:
       call      qword ptr [7FFB0F17C258]
       int       3
M06_L29:
       mov       rcx,[rbx+30]
       mov       rcx,[rcx+8]
       mov       rsi,[rcx+50]
       test      rsi,rsi
       je        near ptr M06_L12
M06_L30:
       mov       edi,[rsp+3C]
       add       edi,[rsp+40]
       jo        near ptr M06_L51
       mov       ebp,edi
       test      ebp,ebp
       je        near ptr M06_L13
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0B0
       jle       near ptr M06_L21
       mov       rcx,[rcx+0B0]
       test      rcx,rcx
       je        near ptr M06_L21
M06_L31:
       mov       rdx,[rcx+18]
       mov       rax,[rdx+18]
       test      rax,rax
       je        near ptr M06_L22
       mov       rcx,rax
M06_L32:
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0A0
       jle       near ptr M06_L23
       mov       rcx,[rcx+0A0]
       test      rcx,rcx
       je        near ptr M06_L23
M06_L33:
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+20]
       test      rax,rax
       je        near ptr M06_L24
M06_L34:
       cmp       [r14],rax
       jne       near ptr M06_L41
       lea       rbp,[r14+10]
       mov       r15,rbp
       mov       r13d,edi
       mov       r12d,[rsp+38]
       test      r12d,r12d
       jne       near ptr M06_L25
M06_L35:
       mov       ecx,[rsp+40]
       cmp       ecx,[rsp+138]
       jbe       near ptr M06_L26
M06_L36:
       call      qword ptr [7FFB0EE77138]
       int       3
M06_L37:
       mov       rcx,r14
       mov       rax,[r14]
       mov       rax,[rax+50]
       call      qword ptr [rax+20]
       mov       r15d,eax
       jmp       near ptr M06_L04
M06_L38:
       mov       rdx,r12
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       je        near ptr M06_L08
       jmp       near ptr M06_L11
M06_L39:
       mov       rcx,r12
       mov       rax,[r12]
       mov       rax,[rax+50]
       call      qword ptr [rax+20]
       mov       r15d,eax
       jmp       near ptr M06_L10
M06_L40:
       lea       rcx,[rsp+38]
       mov       r8,r12
       call      qword ptr [7FFB0F3571B0]; System.Collections.Generic.SegmentedArrayBuilder`1[[System.__Canon, System.Private.CoreLib]].AddSlow(System.__Canon)
       jmp       near ptr M06_L08
M06_L41:
       call      qword ptr [7FFB0F35FE70]
       int       3
M06_L42:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0C0
       jle       short M06_L43
       mov       rdx,[rcx+0C0]
       test      rdx,rdx
       je        short M06_L43
       jmp       short M06_L44
M06_L43:
       mov       rcx,rsi
       mov       rdx,7FFB0F3D6200
       call      qword ptr [7FFB0ECDC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M06_L44:
       lea       rcx,[rsp+28]
       lea       r8,[rsp+48]
       mov       r9d,1B
       call      qword ptr [7FFB0F3573A8]; <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan[[System.Collections.Generic.SegmentedArrayBuilder`1+Arrays[[System.__Canon, System.Private.CoreLib]], System.Linq],[System.__Canon, System.Private.CoreLib]](Arrays<System.__Canon> ByRef, Int32)
       cmp       r12d,[rsp+30]
       ja        near ptr M06_L36
       mov       rsi,[rsp+28]
       mov       edi,r12d
       xor       ebp,ebp
M06_L45:
       mov       r8,[rsi+rbp*8]
       test      r8,r8
       jne       short M06_L46
       xor       edx,edx
       xor       r12d,r12d
       jmp       short M06_L47
M06_L46:
       lea       rdx,[r8+10]
       mov       r12d,[r8+8]
M06_L47:
       cmp       r12d,r13d
       jg        near ptr M06_L28
       mov       eax,r12d
       shl       rax,3
       mov       [rsp+20],rax
       mov       r8,rax
       mov       rcx,r15
       call      qword ptr [7FFB0ECD57A0]; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rsp+20]
       add       r15,rcx
       sub       r13d,r12d
       inc       ebp
       cmp       ebp,edi
       jl        short M06_L45
       jmp       near ptr M06_L35
M06_L48:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M06_L16
M06_L49:
       mov       rcx,r15
       call      qword ptr [7FFB0F424168]
       jmp       near ptr M06_L16
M06_L50:
       lea       rcx,[rsp+38]
       call      qword ptr [7FFB0F3574C8]; System.Collections.Generic.SegmentedArrayBuilder`1[[System.__Canon, System.Private.CoreLib]].ReturnArrays(Int32)
       jmp       near ptr M06_L18
M06_L51:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 1514
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
       jl        near ptr M08_L05
       mov       rdi,[rsi]
       test      rdi,rdi
       je        near ptr M08_L06
       mov       ebp,[rdi+8]
       cmp       ebp,ebx
       je        short M08_L04
       mov       rdx,[rcx+18]
       mov       rax,[rdx+18]
       test      rax,rax
       je        short M08_L01
       mov       rcx,rax
M08_L00:
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
       ja        short M08_L02
       call      00007FFB6E8B5D60
       cmp       dword ptr [7FFB6EC1F778],0
       je        short M08_L03
       jmp       short M08_L09
M08_L01:
       mov       rdx,7FFB0F3D4680
       call      qword ptr [7FFB0EF57AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M08_L00
M08_L02:
       call      qword ptr [7FFB0F424168]
M08_L03:
       mov       rcx,rsi
       mov       rdx,r14
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M08_L04:
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M08_L05:
       mov       ecx,45
       mov       edx,0D
       call      qword ptr [7FFB0F2E58C0]
       int       3
M08_L06:
       mov       rdx,[rcx+18]
       mov       rax,[rdx+18]
       test      rax,rax
       je        short M08_L07
       mov       rcx,rax
       jmp       short M08_L08
M08_L07:
       mov       rdx,7FFB0F3D4680
       call      qword ptr [7FFB0EF57AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M08_L08:
       mov       edx,ebx
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdx,rax
       mov       rcx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       short M08_L04
M08_L09:
       call      CORINFO_HELP_POLL_GC
       jmp       short M08_L03
; Total bytes of code 250
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M09_L00
       ret
M09_L00:
       jmp       qword ptr [7FFB0ECD5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
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
       jne       short M10_L01
       mov       ebx,[rdx+5C]
M10_L00:
       and       ebx,7
       cmp       ebx,6
       sete      al
       movzx     eax,al
       add       rsp,20
       pop       rbx
       ret
M10_L01:
       mov       rcx,rdx
       mov       rax,[rdx]
       mov       rax,[rax+50]
       call      qword ptr [rax+20]
       mov       ebx,eax
       jmp       short M10_L00
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
       je        short M11_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M11_L00:
       call      qword ptr [7FFB0F427450]
       int       3
; Total bytes of code 44
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rdx,rdx
       je        short M12_L01
       mov       rax,[rdx]
       movzx     r8d,word ptr [rax+0E]
       test      r8,r8
       je        short M12_L05
       mov       r10,[rax+38]
       cmp       r8,4
       jl        short M12_L04
       cmp       [r10],rcx
       je        short M12_L01
M12_L00:
       cmp       [r10+8],rcx
       je        short M12_L01
       cmp       [r10+10],rcx
       jne       short M12_L03
M12_L01:
       mov       rax,rdx
       ret
M12_L02:
       cmp       [r10],rcx
       je        short M12_L01
       jmp       short M12_L00
M12_L03:
       cmp       [r10+18],rcx
       je        short M12_L01
       add       r10,20
       add       r8,0FFFFFFFFFFFFFFFC
       cmp       r8,4
       jge       short M12_L02
       test      r8,r8
       je        short M12_L05
M12_L04:
       cmp       [r10],rcx
       je        short M12_L01
       add       r10,8
       dec       r8
       test      r8,r8
       jg        short M12_L04
M12_L05:
       test      dword ptr [rax],500C0000
       jne       short M12_L06
       xor       edx,edx
       jmp       short M12_L01
M12_L06:
       jmp       qword ptr [7FFB0F0DD4B8]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
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
       call      qword ptr [7FFB6CC18600]
       mov       rcx,rsi
       mov       r11,rax
       call      qword ptr [rax]
       mov       edi,eax
       test      edi,edi
       je        short M13_L00
       mov       rcx,rbx
       call      qword ptr [7FFB6CC17A48]
       mov       rcx,rax
       movsxd    rdx,edi
       call      qword ptr [7FFB6CC156D8]; CORINFO_HELP_NEWARR_1_DIRECT
       mov       rdi,rax
       mov       rcx,rbx
       call      qword ptr [7FFB6CC18608]
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
M13_L00:
       mov       rcx,rbx
       call      qword ptr [7FFB6CC18228]
       mov       rcx,rax
       lea       rax,[System.Linq.Enumerable.Select[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>)]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax]
; Total bytes of code 128
```

## .NET 10.0.0 (10.0.0, 10.0.25.52411), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark.GetGenericArguments()
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
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       xor       eax,eax
       mov       [rbp-40],rax
       mov       [rbp+10],rcx
       lea       rcx,[rbp-88]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rcx,rsp
       mov       [rbp-70],rcx
       mov       rcx,rbp
       mov       [rbp-60],rcx
       mov       rdi,2B7C0DA0668
       mov       r14,offset MT_System.RuntimeType
M00_L00:
       cmp       [rdi],r14
       jne       near ptr M00_L12
       mov       [rbp-0A0],rdi
       mov       rcx,[rdi+18]
       mov       rax,7FFB6E8C06C0
       call      rax
       movzx     ebx,al
       mov       rdi,[rbp-0A0]
       cmp       dword ptr [7FFB6EC1F778],0
       jne       near ptr M00_L10
M00_L01:
       cmp       ebx,1D
       ja        short M00_L02
       mov       ecx,1FEF7FFF
       bt        ecx,ebx
       jae       near ptr M00_L11
M00_L02:
       cmp       ebx,10
       sete      r15b
       movzx     r15d,r15b
M00_L03:
       test      r15d,r15d
       jne       near ptr M00_L09
       cmp       [rdi],r14
       jne       near ptr M00_L13
M00_L04:
       xor       ecx,ecx
       mov       [rbp-40],rcx
       test      rdi,rdi
       je        near ptr M00_L14
       mov       [rbp-48],rdi
       mov       rcx,[rbp-48]
       test      rcx,rcx
       je        near ptr M00_L08
       mov       rcx,[rcx+18]
M00_L05:
       lea       rdx,[rbp-48]
       mov       [rbp-98],rdx
       mov       [rbp-90],rcx
       lea       rcx,[rbp-98]
       lea       rdx,[rbp-40]
       xor       r8d,r8d
       mov       rax,7FFB0ED44DE8
       mov       [rbp-78],rax
       lea       rax,[M00_L06]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFB6E88DC80
       call      rax
M00_L06:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFB6EC1F778],0
       je        short M00_L07
       call      qword ptr [7FFB6EC0D608]; CORINFO_HELP_STOP_FOR_GC
M00_L07:
       mov       rcx,[rbp-80]
       mov       [rsi+8],rcx
       mov       rcx,[rbp-40]
       xor       edx,edx
       mov       [rbp-40],rdx
       mov       rdx,2772BC001E0
       test      rcx,rcx
       cmove     rcx,[rdx]
       mov       [rbp-50],rcx
       mov       rbx,[rbp+10]
       mov       rbx,[rbx+18]
       mov       rdx,[rbp-50]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
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
       xor       ecx,ecx
       jmp       near ptr M00_L05
M00_L09:
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+68]
       call      qword ptr [rax+8]
       mov       rdi,rax
       jmp       near ptr M00_L00
M00_L10:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L01
M00_L11:
       mov       r15d,1
       jmp       near ptr M00_L03
M00_L12:
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+68]
       call      qword ptr [rax]
       mov       r15d,eax
       jmp       near ptr M00_L03
M00_L13:
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+98]
       call      qword ptr [rax+8]
       mov       rdi,rax
       jmp       near ptr M00_L04
M00_L14:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFB0F446DF0]
       mov       r8,rax
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFB0F446E08]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 566
```

## .NET 10.0.0 (10.0.0, 10.0.25.52411), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark.GetImplementedInterfaces()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+30],rax
       mov       rbx,rcx
       mov       rcx,offset MT_System.Collections.Generic.List<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       rcx,283E6140668
       mov       [rax+8],rcx
       mov       rcx,rax
       call      qword ptr [7FFB0ECCC9A8]; System.Object.GetType()
       cmp       qword ptr [rax+10],0
       je        short M00_L00
       mov       rcx,[rax+10]
       mov       rsi,[rcx]
       test      rsi,rsi
       jne       near ptr M00_L11
M00_L00:
       mov       rcx,rax
       call      qword ptr [7FFB0ECC7C48]; System.RuntimeType.InitializeCache()
       mov       rdi,rax
M00_L01:
       cmp       [rdi],dil
       lea       rsi,[rdi+58]
       mov       rcx,[rsi]
       test      rcx,rcx
       je        near ptr M00_L15
M00_L02:
       cmp       byte ptr [rcx+18],0
       je        near ptr M00_L16
       mov       rsi,[rcx+8]
M00_L03:
       test      rsi,rsi
       je        near ptr M00_L12
       lea       rdi,[rsi+10]
       mov       esi,[rsi+8]
M00_L04:
       test      esi,esi
       jne       near ptr M00_L13
       mov       rdx,24351000208
       mov       rbp,[rdx]
M00_L05:
       mov       rcx,24351002108
       mov       rsi,[rcx]
       test      rsi,rsi
       je        near ptr M00_L19
M00_L06:
       mov       rdx,rbp
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<System.Type>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       jne       near ptr M00_L20
       mov       rdi,rbp
       test      rdi,rdi
       je        near ptr M00_L24
       mov       r14,rbp
       test      r14,r14
       je        near ptr M00_L22
       cmp       dword ptr [r14+8],0
       je        near ptr M00_L21
       mov       rcx,offset MT_System.Linq.Enumerable+ArraySelectIterator<System.Type, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [r15+10],eax
       lea       rcx,[r15+18]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+20]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M00_L07:
       mov       rdx,r15
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<System.String>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rsi,rax
       test      rsi,rsi
       je        near ptr M00_L27
       mov       rdx,offset MT_System.Linq.Enumerable+ArraySelectIterator<System.Type, System.String>
       cmp       [rsi],rdx
       jne       near ptr M00_L26
       mov       r15,[rsi+18]
       mov       edx,[r15+8]
       mov       rcx,offset MT_System.String[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       lea       rbp,[r15+10]
       mov       r14d,[r15+8]
       lea       r15,[rdi+10]
       mov       r13d,[rdi+8]
       mov       rsi,[rsi+20]
       xor       r12d,r12d
       test      r13d,r13d
       jle       short M00_L09
       cmp       r13d,r14d
       jg        near ptr M00_L25
       xor       r12d,r12d
M00_L08:
       lea       rcx,[r15+r12]
       mov       [rsp+30],rcx
       mov       rdx,[r12+rbp]
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       mov       rcx,[rsp+30]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       add       r12,8
       dec       r13d
       jne       short M00_L08
M00_L09:
       test      rdi,rdi
       je        near ptr M00_L29
       cmp       dword ptr [rdi+8],0
       je        near ptr M00_L30
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
M00_L10:
       mov       [rsp+28],rsi
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
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
M00_L11:
       mov       rdi,rsi
       jmp       near ptr M00_L01
M00_L12:
       xor       edi,edi
       xor       esi,esi
       jmp       near ptr M00_L04
M00_L13:
       mov       edx,esi
       mov       rcx,offset MT_System.Type[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbp,rax
       lea       rcx,[rbp+10]
       mov       r8d,esi
       shl       r8,3
       cmp       r8,4000
       ja        short M00_L18
       mov       rdx,rdi
       call      00007FFB6E8B5D60
       cmp       dword ptr [7FFB6EC1F778],0
       jne       short M00_L17
M00_L14:
       jmp       near ptr M00_L05
M00_L15:
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache+MemberInfoCache<System.RuntimeType>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       mov       rdx,rbp
       xor       r8d,r8d
       call      00007FFB6E8BFBA0
       mov       rcx,rax
       test      rcx,rcx
       cmove     rcx,rbp
       jmp       near ptr M00_L02
M00_L16:
       xor       edx,edx
       xor       r8d,r8d
       mov       r9d,5
       call      qword ptr [7FFB0ECCD2C0]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
       mov       rsi,rax
       jmp       near ptr M00_L03
M00_L17:
       call      CORINFO_HELP_POLL_GC
       jmp       short M00_L14
M00_L18:
       mov       rdx,rdi
       call      qword ptr [7FFB0F2DDB78]
       jmp       short M00_L14
M00_L19:
       mov       rcx,offset MT_System.Func<System.Type, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,243510020C8
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Core.TypeHelper+<>c.<GetImplementedInterfaces>b__32_0(System.Type)
       call      qword ptr [7FFB0ECC6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,24351002108
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L06
M00_L20:
       mov       rcx,rdi
       mov       rdx,offset MT_System.Linq.Enumerable+Iterator<System.Type>
       mov       r8,7FFB0F4DA058
       call      qword ptr [7FFB0ECC5920]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       mov       rcx,rdi
       mov       rdx,rsi
       call      rax
       mov       r15,rax
       jmp       near ptr M00_L07
M00_L21:
       mov       rcx,offset MT_System.Array+EmptyArray<System.String>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,243510021A0
       mov       r15,[rdx]
       jmp       near ptr M00_L07
M00_L22:
       mov       rdx,rbp
       mov       rcx,offset MT_System.Collections.Generic.List<System.Type>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r15,rax
       test      r15,r15
       je        short M00_L23
       mov       rcx,offset MT_System.Linq.Enumerable+ListSelectIterator<System.Type, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,r15
       mov       r8,rsi
       call      qword ptr [7FFB0F43C270]
       mov       r15,rdi
       jmp       near ptr M00_L07
M00_L23:
       mov       rcx,offset MT_System.Linq.Enumerable+IListSelectIterator<System.Type, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       mov       rdx,rdi
       mov       r8,rsi
       call      qword ptr [7FFB0F43C288]
       jmp       near ptr M00_L07
M00_L24:
       mov       rcx,offset MT_System.Linq.Enumerable+IEnumerableSelectIterator<System.Type, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       mov       rdx,rbp
       mov       r8,rsi
       call      qword ptr [7FFB0F43C2A0]
       jmp       near ptr M00_L07
M00_L25:
       mov       edx,r12d
       lea       rcx,[r15+rdx*8]
       mov       [rsp+30],rcx
       cmp       r12d,r14d
       jae       near ptr M00_L31
       mov       edx,r12d
       mov       rdx,[rbp+rdx*8]
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       mov       rcx,[rsp+30]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       r12d
       cmp       r12d,r13d
       jl        short M00_L25
       jmp       near ptr M00_L09
M00_L26:
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rdi,rax
       jmp       near ptr M00_L09
M00_L27:
       mov       rdx,r15
       mov       rcx,offset MT_System.Collections.Generic.ICollection<System.String>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M00_L28
       mov       rdx,rax
       mov       rcx,7FFB0F4DA798
       call      qword ptr [7FFB0F0C7A38]; System.Linq.Enumerable.ICollectionToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>)
       mov       rdi,rax
       jmp       near ptr M00_L09
M00_L28:
       mov       rdx,r15
       mov       rcx,7FFB0F4DA820
       call      qword ptr [7FFB0F4371B0]
       mov       rdi,rax
       jmp       near ptr M00_L09
M00_L29:
       mov       ecx,2
       call      qword ptr [7FFB0EF4C1C8]
       int       3
M00_L30:
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<System.String>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,243510021A8
       mov       rsi,[rcx]
       jmp       near ptr M00_L10
M00_L31:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1250
```
```assembly
; System.Object.GetType()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx]
       mov       rax,[rcx+20]
       add       rax,10
       mov       rax,[rax]
       test      rax,rax
       je        short M01_L01
M01_L00:
       add       rsp,20
       pop       rbx
       ret
M01_L01:
       call      qword ptr [7FFB0ECC5C80]; System.RuntimeTypeHandle.GetRuntimeTypeFromHandleSlow(IntPtr)
       jmp       short M01_L00
; Total bytes of code 41
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
       call      00007FFB6E8C1870
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
       mov       rax,7FFB0EE26D90
       mov       [rbp-78],rax
       lea       rax,[M02_L03]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFB6E852C30
       call      rax
M02_L03:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFB6EC1F778],0
       je        short M02_L04
       call      qword ptr [7FFB6EC0D608]; CORINFO_HELP_STOP_FOR_GC
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
       call      00007FFB6E8D04E0
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
       call      qword ptr [7FFB0F43C390]; System.RuntimeTypeHandle.GetGCHandle(System.Runtime.InteropServices.GCHandleType)
       mov       rdx,rax
       lea       rcx,[rbx+10]
       xor       eax,eax
       lock cmpxchg [rcx],rdx
       test      rax,rax
       je        near ptr M02_L00
       lea       rcx,[rbp-40]
       call      qword ptr [7FFB0F436FD0]
       jmp       near ptr M02_L00
M02_L09:
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M02_L10:
       mov       [rbp+10],rbx
       mov       rcx,rbx
       call      qword ptr [7FFB0ECC7C90]; System.RuntimeTypeHandle.<GetModule>g__GetModuleWorker|48_0(System.RuntimeType)
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
       mov       rax,0D16E9E6C47F7
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
       mov       rdx,283E6130008
       call      qword ptr [7FFB0ECCD320]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].GetListByName(System.String, System.Span`1<Byte>, MemberListType, CacheType)
       mov       [rbp+18],rax
M04_L01:
       lea       rdx,[rbp+18]
       mov       rcx,rsi
       mov       r8,rbx
       mov       r9d,edi
       call      qword ptr [7FFB0ECCD578]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Insert(System.__Canon[] ByRef, System.String, MemberListType)
       mov       rax,[rbp+18]
       mov       r8,0D16E9E6C47F7
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
       mov       rcx,24351000220
       mov       rcx,[rcx]
       mov       rdx,rbx
       call      qword ptr [7FFB0EE54930]; Precode of System.Text.UTF8Encoding.GetByteCount(System.String)
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
       call      qword ptr [7FFB0ECCD320]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].GetListByName(System.String, System.Span`1<Byte>, MemberListType, CacheType)
       mov       [rbp+18],rax
       jmp       near ptr M04_L01
; Total bytes of code 348
```
```assembly
; DotNetTips.Spargine.Core.TypeHelper+<>c.<GetImplementedInterfaces>b__32_0(System.Type)
; 		return Array.AsReadOnly(input.GetType().GetInterfaces().Select(p => p.Name).ToArray());
; 		                                                                    ^^^^^^
       push      rbx
       sub       rsp,20
       mov       rcx,rdx
       mov       rax,offset MT_System.RuntimeType
       cmp       [rcx],rax
       jne       short M05_L04
       cmp       qword ptr [rcx+10],0
       je        short M05_L00
       mov       rax,[rcx+10]
       mov       rbx,[rax]
       test      rbx,rbx
       jne       short M05_L02
M05_L00:
       call      qword ptr [7FFB0ECC7C48]; System.RuntimeType.InitializeCache()
       mov       rcx,rax
M05_L01:
       mov       rax,[rcx+18]
       test      rax,rax
       je        short M05_L03
       add       rsp,20
       pop       rbx
       ret
M05_L02:
       mov       rcx,rbx
       jmp       short M05_L01
M05_L03:
       lea       rdx,[rcx+18]
       xor       r8d,r8d
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFB0EE64A80]; System.RuntimeType+RuntimeTypeCache.ConstructName(System.String ByRef, System.TypeNameFormatFlags)
M05_L04:
       mov       rax,[rcx]
       mov       rax,[rax+40]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax+30]
; Total bytes of code 105
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M06_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M06_L00:
       call      qword ptr [7FFB0F436C40]
       int       3
; Total bytes of code 44
```
```assembly
; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rcx,[rdi]
       mov       eax,ebx
       rol       eax,5
       add       eax,ecx
       mov       edx,esi
       ror       edx,5
       add       eax,edx
       mov       rdx,24351000A10
       mov       rdx,[rdx]
       mov       rdx,[rdx+8]
       movsxd    r8,eax
       mov       r10,9E3779B97F4A7C15
       imul      r8,r10
       movzx     r10d,byte ptr [rdx+10]
       shrx      r8,r8,r10
       xor       r10d,r10d
M07_L00:
       lea       r9d,[r8+1]
       movsxd    r9,r9d
       imul      r9,30
       lea       r9,[rdx+r9+10]
       mov       r11d,[r9]
       mov       ebp,[r9+8]
       mov       r14,[r9+10]
       mov       r15,[r9+18]
       mov       r13,[r9+20]
       cmp       eax,ebp
       jne       short M07_L01
       mov       rbp,rcx
       sub       rbp,r14
       mov       r14,rbx
       sub       r14,r15
       or        rbp,r14
       mov       r14,rsi
       sub       r14,r13
       or        rbp,r14
       jne       short M07_L01
       mov       rbp,[r9+28]
       and       r11d,0FFFFFFFE
       cmp       r11d,[r9]
       jne       short M07_L02
       mov       rcx,7FFB0F48C6A0
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,rbp
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M07_L01:
       test      r11d,r11d
       je        short M07_L02
       inc       r10d
       add       r8d,r10d
       mov       r9d,[rdx+8]
       add       r9d,0FFFFFFFE
       and       r8d,r9d
       cmp       r10d,8
       jl        near ptr M07_L00
M07_L02:
       mov       rcx,7FFB0F48C6A4
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r8,rsi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FFB0EE6FF48]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointerSlow(System.Object, IntPtr, IntPtr)
; Total bytes of code 274
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M08_L00
       ret
M08_L00:
       jmp       qword ptr [7FFB0ECC5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rdx,rdx
       je        short M09_L06
       mov       rax,[rdx]
       movzx     r8d,word ptr [rax+0E]
       test      r8,r8
       je        short M09_L03
       mov       r10,[rax+38]
       cmp       r8,4
       jl        short M09_L01
       cmp       [r10],rcx
       je        short M09_L06
M09_L00:
       cmp       [r10+8],rcx
       je        short M09_L06
       cmp       [r10+10],rcx
       je        short M09_L06
       cmp       [r10+18],rcx
       je        short M09_L06
       add       r10,20
       add       r8,0FFFFFFFFFFFFFFFC
       cmp       r8,4
       jge       short M09_L04
       test      r8,r8
       je        short M09_L03
M09_L01:
       cmp       [r10],rcx
       je        short M09_L06
M09_L02:
       add       r10,8
       dec       r8
       test      r8,r8
       jle       short M09_L03
       cmp       [r10],rcx
       je        short M09_L06
       jmp       short M09_L02
M09_L03:
       test      dword ptr [rax],500C0000
       je        short M09_L05
       jmp       qword ptr [7FFB0F0CD4B8]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
M09_L04:
       cmp       [r10],rcx
       je        short M09_L06
       jmp       short M09_L00
M09_L05:
       xor       edx,edx
M09_L06:
       mov       rax,rdx
       ret
; Total bytes of code 121
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
       call      qword ptr [7FFB6CC18600]
       mov       rcx,rsi
       mov       r11,rax
       call      qword ptr [rax]
       mov       edi,eax
       test      edi,edi
       je        short M10_L00
       mov       rcx,rbx
       call      qword ptr [7FFB6CC17A48]
       mov       rcx,rax
       movsxd    rdx,edi
       call      qword ptr [7FFB6CC156D8]; CORINFO_HELP_NEWARR_1_DIRECT
       mov       rdi,rax
       mov       rcx,rbx
       call      qword ptr [7FFB6CC18608]
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
M10_L00:
       mov       rcx,rbx
       call      qword ptr [7FFB6CC18228]
       mov       rcx,rax
       lea       rax,[System.Linq.Enumerable.Select[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>)]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax]
; Total bytes of code 128
```

## .NET 10.0.0 (10.0.0, 10.0.25.52411), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark.GetImplementedInterfaceTypes()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rcx,offset MT_System.Collections.Generic.List<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       rcx,216A47C0668
       mov       [rax+8],rcx
       mov       rcx,rax
       call      qword ptr [7FFB0ECEC9A8]; System.Object.GetType()
       mov       rcx,[rax+10]
       test      rcx,rcx
       je        near ptr M00_L09
       mov       rsi,[rcx]
       test      rsi,rsi
       je        near ptr M00_L09
M00_L00:
       cmp       [rsi],sil
       lea       rdi,[rsi+58]
       mov       rcx,[rdi]
       test      rcx,rcx
       je        near ptr M00_L10
M00_L01:
       cmp       byte ptr [rcx+18],0
       je        near ptr M00_L11
       mov       rsi,[rcx+8]
M00_L02:
       test      rsi,rsi
       je        short M00_L06
       lea       rdi,[rsi+10]
       mov       esi,[rsi+8]
M00_L03:
       test      esi,esi
       jne       short M00_L07
       mov       rdx,1D60F800208
       mov       rbp,[rdx]
M00_L04:
       cmp       dword ptr [rbp+8],0
       je        near ptr M00_L14
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<System.Type>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
M00_L05:
       mov       [rsp+20],rsi
       mov       rbx,[rbx+18]
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
       xor       edi,edi
       xor       esi,esi
       jmp       short M00_L03
M00_L07:
       mov       edx,esi
       mov       rcx,offset MT_System.Type[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbp,rax
       lea       rcx,[rbp+10]
       mov       r8d,esi
       shl       r8,3
       cmp       r8,4000
       ja        near ptr M00_L13
       mov       rdx,rdi
       call      00007FFB6E8B5D60
       cmp       dword ptr [7FFB6EC1F778],0
       jne       short M00_L12
M00_L08:
       jmp       near ptr M00_L04
M00_L09:
       mov       rcx,rax
       call      qword ptr [7FFB0ECE7C48]; System.RuntimeType.InitializeCache()
       mov       rsi,rax
       jmp       near ptr M00_L00
M00_L10:
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache+MemberInfoCache<System.RuntimeType>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       rdx,rbp
       xor       r8d,r8d
       call      00007FFB6E8BFBA0
       mov       rcx,rax
       test      rcx,rcx
       cmove     rcx,rbp
       jmp       near ptr M00_L01
M00_L11:
       xor       edx,edx
       xor       r8d,r8d
       mov       r9d,5
       call      qword ptr [7FFB0ECED2C0]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
       mov       rsi,rax
       jmp       near ptr M00_L02
M00_L12:
       call      CORINFO_HELP_POLL_GC
       jmp       short M00_L08
M00_L13:
       mov       rdx,rdi
       call      qword ptr [7FFB0F2FDB48]
       jmp       short M00_L08
M00_L14:
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<System.Type>
       call      qword ptr [7FFB0ECE5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1D625800150
       mov       rsi,[rcx]
       jmp       near ptr M00_L05
; Total bytes of code 446
```
```assembly
; System.Object.GetType()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx]
       mov       rax,[rcx+20]
       add       rax,10
       mov       rax,[rax]
       test      rax,rax
       je        short M01_L01
M01_L00:
       add       rsp,20
       pop       rbx
       ret
M01_L01:
       call      qword ptr [7FFB0ECE5C80]; System.RuntimeTypeHandle.GetRuntimeTypeFromHandleSlow(IntPtr)
       jmp       short M01_L00
; Total bytes of code 41
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
       call      00007FFB6E8C1870
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
       mov       rax,7FFB0EE46D90
       mov       [rbp-78],rax
       lea       rax,[M02_L03]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFB6E852C30
       call      rax
M02_L03:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFB6EC1F778],0
       je        short M02_L04
       call      qword ptr [7FFB6EC0D608]; CORINFO_HELP_STOP_FOR_GC
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
       call      00007FFB6E8D04E0
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
       call      qword ptr [7FFB0F44C540]; System.RuntimeTypeHandle.GetGCHandle(System.Runtime.InteropServices.GCHandleType)
       mov       rdx,rax
       lea       rcx,[rbx+10]
       xor       eax,eax
       lock cmpxchg [rcx],rdx
       test      rax,rax
       je        near ptr M02_L00
       lea       rcx,[rbp-40]
       call      qword ptr [7FFB0F447228]
       jmp       near ptr M02_L00
M02_L09:
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M02_L10:
       mov       [rbp+10],rbx
       mov       rcx,rbx
       call      qword ptr [7FFB0ECE7C90]; System.RuntimeTypeHandle.<GetModule>g__GetModuleWorker|48_0(System.RuntimeType)
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
       mov       rax,0DB2425C0273A
       mov       [rbp],rax
       mov       rsi,rcx
       mov       rbx,rdx
       mov       edi,r8d
       mov       r14d,r9d
       test      rbx,rbx
       je        short M03_L00
       cmp       dword ptr [rbx+8],0
       jne       short M03_L03
M03_L00:
       xor       r8d,r8d
       mov       [rbp+8],r8
       mov       [rbp+10],r8d
       mov       [rsp+20],r14d
       lea       r8,[rbp+8]
       mov       rcx,rsi
       mov       r9d,edi
       mov       rdx,216A47B0008
       call      qword ptr [7FFB0ECED320]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].GetListByName(System.String, System.Span`1<Byte>, MemberListType, CacheType)
       mov       [rbp+18],rax
M03_L01:
       lea       rdx,[rbp+18]
       mov       rcx,rsi
       mov       r8,rbx
       mov       r9d,edi
       call      qword ptr [7FFB0ECED578]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Insert(System.__Canon[] ByRef, System.String, MemberListType)
       mov       rax,[rbp+18]
       mov       r8,0DB2425C0273A
       cmp       [rbp],r8
       je        short M03_L02
       call      CORINFO_HELP_FAIL_FAST
M03_L02:
       nop
       lea       rsp,[rbp+20]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M03_L03:
       cmp       r14d,1
       jne       short M03_L04
       cmp       word ptr [rbx+0C],2E
       je        short M03_L04
       cmp       word ptr [rbx+0C],2A
       jne       short M03_L00
M03_L04:
       mov       rcx,1D60F800220
       mov       rcx,[rcx]
       mov       rdx,rbx
       call      qword ptr [7FFB0EE74930]; Precode of System.Text.UTF8Encoding.GetByteCount(System.String)
       cmp       eax,400
       jbe       short M03_L05
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       r8,[rax+10]
       mov       eax,[rax+8]
       jmp       short M03_L07
M03_L05:
       mov       r8d,eax
       test      r8,r8
       je        short M03_L07
       mov       rdx,r8
       add       rdx,0F
       and       rdx,0FFFFFFFFFFFFFFF0
       add       rsp,30
       neg       rdx
       add       rdx,rsp
       jb        short M03_L06
       xor       edx,edx
M03_L06:
       test      [rsp],esp
       sub       rsp,1000
       cmp       rsp,rdx
       jae       short M03_L06
       mov       rsp,rdx
       test      [rsp],esp
       sub       rsp,30
       lea       r8,[rsp+30]
M03_L07:
       mov       [rbp+8],r8
       mov       [rbp+10],eax
       mov       [rsp+20],r14d
       lea       r8,[rbp+8]
       mov       rdx,rbx
       mov       rcx,rsi
       mov       r9d,edi
       call      qword ptr [7FFB0ECED320]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].GetListByName(System.String, System.Span`1<Byte>, MemberListType, CacheType)
       mov       [rbp+18],rax
       jmp       near ptr M03_L01
; Total bytes of code 348
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M04_L00
       ret
M04_L00:
       jmp       qword ptr [7FFB0ECE5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.0 (10.0.0, 10.0.25.52411), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark.GetTypeDisplayName()
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,70
       vzeroupper
       lea       rbp,[rsp+90]
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
       mov       rcx,294E28020D8
       mov       rbx,[rcx]
       mov       rcx,[rbx+20]
       mov       [rbp-38],rcx
       cmp       qword ptr [rbp-38],0
       je        near ptr M00_L31
       lea       rcx,[rbx+20]
       mov       r8,[rbp-38]
       test      rcx,rcx
       je        near ptr M00_L30
       xor       edx,edx
       call      00007FFB6E8BFBA0
       cmp       rax,[rbp-38]
       jne       near ptr M00_L31
M00_L00:
       mov       rbx,[rbp-38]
M00_L01:
       xor       ecx,ecx
       mov       [rbp-38],rcx
       mov       [rbp-30],rbx
       mov       rbx,2D5776B0668
       mov       [rbp-60],rbx
       mov       rcx,offset MT_System.Int32[]
       test      dword ptr [rcx],80000000
       je        short M00_L02
       xor       eax,eax
       jmp       short M00_L03
M00_L02:
       test      byte ptr [rcx],30
       setne     al
       movzx     eax,al
M00_L03:
       movzx     ecx,al
       test      ecx,ecx
       jne       near ptr M00_L18
       mov       rcx,offset MT_System.Int32[]
       mov       rax,7FFB6E8C06C0
       call      rax
       movzx     ebx,al
       mov       rsi,[rbp-60]
       cmp       dword ptr [7FFB6EC1F778],0
       jne       near ptr M00_L19
M00_L04:
       cmp       ebx,14
       je        near ptr M00_L20
       cmp       ebx,1D
       sete      cl
       movzx     ecx,cl
M00_L05:
       test      ecx,ecx
       jne       near ptr M00_L15
       mov       rcx,rsi
       call      00007FFB6E8C2C30
       test      eax,eax
       jne       near ptr M00_L25
       cmp       byte ptr [rbp-28],0
       je        near ptr M00_L10
       mov       rcx,rsi
       call      qword ptr [7FFB0ECB7C48]; System.RuntimeType.InitializeCache()
       mov       rbx,rax
       mov       rax,[rbx+20]
       test      rax,rax
       jne       short M00_L06
       mov       rcx,[rbx+8]
       call      qword ptr [7FFB0EE54A68]; System.RuntimeType.IsFullNameRoundtripCompatible(System.RuntimeType)
       test      eax,eax
       je        short M00_L07
       lea       rdx,[rbx+20]
       mov       rcx,rbx
       mov       r8d,3
       call      qword ptr [7FFB0EE54A80]; System.RuntimeType+RuntimeTypeCache.ConstructName(System.String ByRef, System.TypeNameFormatFlags)
M00_L06:
       test      rax,rax
       je        near ptr M00_L10
       mov       rcx,rsi
       call      qword ptr [7FFB0ECB7C48]; System.RuntimeType.InitializeCache()
       mov       rsi,rax
       mov       rbx,[rsi+20]
       test      rbx,rbx
       jne       short M00_L09
       mov       rcx,[rsi+8]
       call      qword ptr [7FFB0EE54A68]; System.RuntimeType.IsFullNameRoundtripCompatible(System.RuntimeType)
       test      eax,eax
       jne       short M00_L08
       xor       ebx,ebx
       jmp       short M00_L09
M00_L07:
       xor       eax,eax
       jmp       short M00_L06
M00_L08:
       lea       rdx,[rsi+20]
       mov       rcx,rsi
       mov       r8d,3
       call      qword ptr [7FFB0EE54A80]; System.RuntimeType+RuntimeTypeCache.ConstructName(System.String ByRef, System.TypeNameFormatFlags)
       mov       rbx,rax
M00_L09:
       mov       rsi,[rbp-30]
       cmp       [rsi],sil
       test      rbx,rbx
       je        short M00_L13
       lea       rdx,[rbx+0C]
       mov       r8d,[rbx+8]
       test      r8d,r8d
       je        short M00_L13
       mov       rcx,[rsi+8]
       mov       eax,[rsi+18]
       lea       edi,[rax+r8]
       cmp       edi,[rcx+8]
       ja        near ptr M00_L27
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jg        short M00_L11
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       jne       short M00_L12
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M00_L12
M00_L10:
       mov       rcx,2D5776B0668
       mov       rax,[7FFB0EBFA1C0]
       call      qword ptr [rax+30]
       mov       rbx,rax
       jmp       short M00_L09
M00_L11:
       mov       r8d,r8d
       add       r8,r8
       call      qword ptr [7FFB0ECB5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L12:
       mov       [rsi+18],edi
M00_L13:
       movzx     r9d,word ptr [rbp-24]
       cmp       r9d,2B
       jne       near ptr M00_L28
M00_L14:
       xor       ecx,ecx
       mov       [rbp-40],rcx
       mov       rcx,[rbp-30]
       cmp       [rcx],ecx
       call      qword ptr [7FFB0EF10210]; System.Text.StringBuilder.ToString()
       mov       [rbp-58],rax
       jmp       near ptr M00_L29
M00_L15:
       mov       rcx,offset MT_System.Int32[]
       call      00007FFB6E84A930
       test      rax,rax
       je        near ptr M00_L21
       test      al,2
       jne       near ptr M00_L22
       mov       rcx,[rax+20]
       add       rcx,10
       mov       rdx,[rcx]
M00_L16:
       test      rdx,rdx
       je        near ptr M00_L23
M00_L17:
       mov       [rbp-40],rdx
       lea       rcx,[rbp-30]
       lea       rdx,[rbp-40]
       lea       r8,[rbp-28]
       call      qword ptr [7FFB0F37EE08]; DotNetTips.Spargine.Core.TypeHelper.ProcessType(System.Text.StringBuilder ByRef, System.Type ByRef, DotNetTips.Spargine.Core.DisplayNameOptions ByRef)
       mov       rcx,[rbp-30]
       mov       rdx,2D5776B09A4
       mov       r8,[rcx+8]
       mov       eax,[rcx+18]
       lea       r10d,[rax+2]
       cmp       [r8+8],r10d
       jb        near ptr M00_L24
       movsxd    rdx,eax
       lea       rdx,[r8+rdx*2+10]
       mov       word ptr [rdx],5B
       mov       word ptr [rdx+2],5D
       mov       [rcx+18],r10d
       jmp       near ptr M00_L14
M00_L18:
       mov       rbx,[rbp-60]
       mov       rcx,2D5776B0668
       mov       rax,[7FFB0EBFA1E8]
       call      qword ptr [rax+28]
       mov       rcx,[rbp-30]
       mov       r9d,[rax+8]
       mov       r8d,[rbp-28]
       mov       [rbp-50],r8d
       mov       r8w,[rbp-24]
       mov       [rbp-4C],r8w
       lea       r8,[rbp-50]
       mov       [rsp+20],r8
       mov       r8,rax
       mov       rdx,rbx
       call      qword ptr [7FFB0F37F528]
       jmp       near ptr M00_L14
M00_L19:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L04
M00_L20:
       mov       ecx,1
       jmp       near ptr M00_L05
M00_L21:
       xor       edx,edx
       jmp       near ptr M00_L17
M00_L22:
       mov       rdx,rax
       and       rdx,0FFFFFFFFFFFFFFFD
       add       rdx,8
       mov       rdx,[rdx]
       jmp       near ptr M00_L16
M00_L23:
       mov       rcx,rax
       call      qword ptr [7FFB0ECB5C80]; System.RuntimeTypeHandle.GetRuntimeTypeFromHandleSlow(IntPtr)
       mov       rdx,rax
       jmp       near ptr M00_L17
M00_L24:
       mov       r8d,2
       call      qword ptr [7FFB0EE5F180]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M00_L14
M00_L25:
       cmp       byte ptr [rbp-27],0
       je        near ptr M00_L14
       mov       rbx,[rbp-30]
       mov       rcx,2D5776B0668
       mov       rax,[7FFB0EBFA1C0]
       call      qword ptr [rax+30]
       mov       rdx,rax
       mov       rcx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FFB0EE5F1C8]; System.Text.StringBuilder.Append(System.String)
       jmp       near ptr M00_L14
M00_L26:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L27:
       mov       rcx,rsi
       call      qword ptr [7FFB0EE5F180]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M00_L13
M00_L28:
       mov       rcx,[rbp-30]
       movzx     r8d,word ptr [rbp-24]
       mov       r9,[rbp-30]
       mov       edx,[r9+1C]
       add       edx,[r9+18]
       mov       r9d,edx
       sub       r9d,[rbx+8]
       jo        short M00_L26
       mov       edx,[rbx+8]
       mov       [rsp+20],edx
       mov       edx,2B
       cmp       [rcx],ecx
       call      qword ptr [7FFB0F37F288]
       jmp       near ptr M00_L14
M00_L29:
       call      M00_L33
       nop
       xor       ecx,ecx
       mov       [rbp-30],rcx
       mov       r10,[rbp-58]
       mov       [rbp-48],r10
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+18]
       lea       r8,[rbp-48]
       mov       rdx,7FFB0F432B90
       cmp       [rcx],ecx
       call      qword ptr [7FFB0F37F588]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,70
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M00_L30:
       call      qword ptr [7FFB0F4464A8]
       int       3
M00_L31:
       mov       rcx,[rbx+18]
       lea       rdx,[rbp-38]
       cmp       [rcx],ecx
       call      qword ptr [7FFB0F374858]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M00_L32
       add       rbx,2C
       lock dec  dword ptr [rbx]
       jmp       near ptr M00_L00
M00_L32:
       mov       rax,[rbx+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       rbx,rax
       jmp       near ptr M00_L01
M00_L33:
       sub       rsp,28
       vzeroupper
       mov       rbx,[rbp-30]
       cmp       dword ptr [rbx+20],0
       jge       short M00_L34
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FFB0EBF4000
       call      qword ptr [7FFB0EF37738]
       mov       rsi,rax
       call      qword ptr [7FFB0F447780]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFB0F245F68]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L34:
       cmp       qword ptr [rbx+10],0
       jne       short M00_L35
       xor       eax,eax
       mov       [rbx+18],rax
       jmp       near ptr M00_L45
M00_L35:
       mov       eax,[rbx+1C]
       add       eax,[rbx+18]
       mov       esi,eax
       neg       esi
       test      esi,esi
       jle       short M00_L37
       mov       rdx,[rbx+8]
       mov       ecx,[rbx+18]
       mov       r8d,ecx
       mov       eax,esi
       add       r8,rax
       mov       eax,[rdx+8]
       cmp       r8,rax
       ja        short M00_L36
       mov       ecx,ecx
       lea       rcx,[rdx+rcx*2+10]
       mov       edx,esi
       xor       r8d,r8d
       call      qword ptr [7FFB0F157210]; System.SpanHelpers.Fill[[System.Char, System.Private.CoreLib]](Char ByRef, UIntPtr, Char)
       add       [rbx+18],esi
       jmp       near ptr M00_L45
M00_L36:
       mov       rcx,rbx
       mov       r8d,esi
       xor       edx,edx
       call      qword ptr [7FFB0F44C948]
       jmp       near ptr M00_L45
M00_L37:
       mov       rsi,rbx
       cmp       dword ptr [rbx+1C],0
       jle       short M00_L39
M00_L38:
       mov       rsi,[rsi+10]
       cmp       dword ptr [rsi+1C],0
       jg        short M00_L38
M00_L39:
       cmp       rsi,rbx
       je        near ptr M00_L44
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
       jge       short M00_L42
       cmp       ecx,400
       jge       short M00_L40
       movsxd    rdx,ecx
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rdi,rax
       jmp       short M00_L41
M00_L40:
       xor       edx,edx
       call      qword ptr [7FFB0F2CE3D0]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       rdi,rax
M00_L41:
       mov       rcx,[rsi+8]
       mov       r8d,[rsi+18]
       mov       rdx,rdi
       call      qword ptr [7FFB0EE54FD8]; System.Array.Copy(System.Array, System.Array, Int32)
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M00_L43
M00_L42:
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
M00_L43:
       mov       rdx,[rsi+10]
       lea       rcx,[rbx+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       edx,[rsi+1C]
       mov       [rbx+1C],edx
M00_L44:
       mov       edx,[rsi+1C]
       neg       edx
       mov       [rbx+18],edx
M00_L45:
       mov       rax,294E28020D8
       mov       rsi,[rax]
       mov       rdi,[rsi+10]
       mov       rax,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [rdi+18],rax
       jne       near ptr M00_L57
       mov       rax,[rbx+8]
       mov       eax,[rax+8]
       add       eax,[rbx+1C]
       mov       rdx,[rdi+8]
       cmp       eax,[rdx+0C]
       jg        near ptr M00_L62
       cmp       dword ptr [rbx+20],0
       jge       short M00_L46
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FFB0EBF4000
       call      qword ptr [7FFB0EF37738]
       mov       rsi,rax
       call      qword ptr [7FFB0F447780]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFB0F245F68]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L46:
       cmp       qword ptr [rbx+10],0
       jne       short M00_L47
       xor       ecx,ecx
       mov       [rbx+18],rcx
       jmp       near ptr M00_L58
M00_L47:
       mov       eax,[rbx+1C]
       add       eax,[rbx+18]
       mov       edi,eax
       neg       edi
       test      edi,edi
       jle       short M00_L49
       mov       rdx,[rbx+8]
       mov       ecx,[rbx+18]
       mov       r8d,ecx
       mov       eax,edi
       add       r8,rax
       mov       eax,[rdx+8]
       cmp       r8,rax
       ja        short M00_L48
       mov       ecx,ecx
       lea       rcx,[rdx+rcx*2+10]
       mov       edx,edi
       xor       r8d,r8d
       call      qword ptr [7FFB0F157210]; System.SpanHelpers.Fill[[System.Char, System.Private.CoreLib]](Char ByRef, UIntPtr, Char)
       add       [rbx+18],edi
       jmp       near ptr M00_L58
M00_L48:
       mov       rcx,rbx
       mov       r8d,edi
       xor       edx,edx
       call      qword ptr [7FFB0F44C948]
       jmp       near ptr M00_L58
M00_L49:
       mov       rdi,rbx
       cmp       dword ptr [rbx+1C],0
       jle       short M00_L51
M00_L50:
       mov       rdi,[rdi+10]
       cmp       dword ptr [rdi+1C],0
       jg        short M00_L50
M00_L51:
       cmp       rdi,rbx
       je        near ptr M00_L56
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
       sub       ecx,[rdi+1C]
       mov       rdx,[rdi+8]
       cmp       [rdx+8],ecx
       jge       short M00_L54
       cmp       ecx,400
       jge       short M00_L52
       movsxd    rdx,ecx
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
       jmp       short M00_L53
M00_L52:
       xor       edx,edx
       call      qword ptr [7FFB0F2CE3D0]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       r14,rax
M00_L53:
       mov       rcx,[rdi+8]
       mov       r8d,[rdi+18]
       mov       rdx,r14
       call      qword ptr [7FFB0EE54FD8]; System.Array.Copy(System.Array, System.Array, Int32)
       lea       rcx,[rbx+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M00_L55
M00_L54:
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
M00_L55:
       mov       rdx,[rdi+10]
       lea       rcx,[rbx+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       edx,[rdi+1C]
       mov       [rbx+1C],edx
M00_L56:
       mov       edx,[rdi+1C]
       neg       edx
       mov       [rbx+18],edx
       jmp       short M00_L58
M00_L57:
       mov       rdx,rbx
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       test      eax,eax
       je        short M00_L62
M00_L58:
       cmp       qword ptr [rsi+20],0
       jne       short M00_L60
       lea       rcx,[rsi+20]
       test      rcx,rcx
       jne       short M00_L59
       call      qword ptr [7FFB0F4464A8]
       int       3
M00_L59:
       mov       rdx,rbx
       xor       r8d,r8d
       call      00007FFB6E8BFBA0
       test      rax,rax
       je        short M00_L62
M00_L60:
       lea       rcx,[rsi+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[rsi+28]
       jg        short M00_L61
       mov       rcx,[rsi+18]
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FFB0F374948]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
       jmp       short M00_L62
M00_L61:
       add       rsi,2C
       lock dec  dword ptr [rsi]
M00_L62:
       add       rsp,28
       ret
; Total bytes of code 2059
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
       call      00007FFB6E8C1870
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
       mov       rax,7FFB0EE16D90
       mov       [rbp-78],rax
       lea       rax,[M01_L03]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFB6E852C30
       call      rax
M01_L03:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFB6EC1F778],0
       je        short M01_L04
       call      qword ptr [7FFB6EC0D608]; CORINFO_HELP_STOP_FOR_GC
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
       call      00007FFB6E8D04E0
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
       call      qword ptr [7FFB0F44D008]; System.RuntimeTypeHandle.GetGCHandle(System.Runtime.InteropServices.GCHandleType)
       mov       rdx,rax
       lea       rcx,[rbx+10]
       xor       eax,eax
       lock cmpxchg [rcx],rdx
       test      rax,rax
       je        near ptr M01_L00
       lea       rcx,[rbp-40]
       call      qword ptr [7FFB0F4478D0]
       jmp       near ptr M01_L00
M01_L09:
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M01_L10:
       mov       [rbp+10],rbx
       mov       rcx,rbx
       call      qword ptr [7FFB0ECB7C90]; System.RuntimeTypeHandle.<GetModule>g__GetModuleWorker|48_0(System.RuntimeType)
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
M02_L00:
       mov       rdi,[rbx]
       cmp       rdi,rsi
       jne       near ptr M02_L17
       mov       [rsp+30],rbx
       mov       rcx,[rbx+18]
       mov       rax,7FFB6E8C06C0
       call      rax
       movzx     ebx,al
       mov       rbp,[rsp+30]
       cmp       dword ptr [7FFB6EC1F778],0
       jne       near ptr M02_L15
M02_L01:
       cmp       ebx,1D
       ja        short M02_L02
       mov       ecx,1FEF7FFF
       bt        ecx,ebx
       jae       near ptr M02_L16
M02_L02:
       cmp       ebx,10
       sete      r14b
       movzx     r14d,r14b
M02_L03:
       test      r14d,r14d
       jne       near ptr M02_L14
       mov       [rsp+38],rbp
       cmp       rdi,rsi
       jne       near ptr M02_L19
       mov       rcx,[rbp+18]
       test      cl,2
       jne       near ptr M02_L18
       mov       ecx,[rcx]
       and       ecx,80000030
       cmp       ecx,30
       sete      al
       movzx     eax,al
M02_L04:
       test      eax,eax
       jne       near ptr M02_L11
       cmp       rdi,rsi
       jne       near ptr M02_L26
       mov       rbx,rbp
       mov       rbp,[rsp+38]
M02_L05:
       cmp       [rbx],rsi
       jne       near ptr M02_L23
       mov       [rsp+28],rbx
       mov       rcx,[rbx+18]
       mov       rax,7FFB6E8C06C0
       call      rax
       movzx     ebx,al
       cmp       dword ptr [7FFB6EC1F778],0
       jne       near ptr M02_L21
       mov       rcx,[rsp+28]
M02_L06:
       cmp       ebx,1D
       ja        short M02_L07
       mov       eax,1FEF7FFF
       bt        eax,ebx
       jae       near ptr M02_L22
M02_L07:
       cmp       ebx,10
       sete      bpl
       movzx     ebp,bpl
M02_L08:
       test      ebp,ebp
       jne       near ptr M02_L20
       cmp       [rcx],rsi
       jne       near ptr M02_L24
M02_L09:
       test      rcx,rcx
       je        near ptr M02_L25
       call      00007FFB6E8C2E70
M02_L10:
       test      eax,eax
       mov       rbp,[rsp+38]
       jne       near ptr M02_L27
M02_L11:
       cmp       rdi,rsi
       jne       near ptr M02_L29
       mov       rcx,[rbp+18]
       mov       rax,7FFB6E8C06C0
       call      rax
       movzx     edi,al
       cmp       dword ptr [7FFB6EC1F778],0
       jne       near ptr M02_L28
M02_L12:
       cmp       edi,1B
       je        near ptr M02_L27
M02_L13:
       mov       eax,1
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L14:
       mov       rcx,rbp
       mov       rax,[rdi+68]
       call      qword ptr [rax+8]
       mov       rbp,rax
       mov       rbx,rbp
       jmp       near ptr M02_L00
M02_L15:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M02_L01
M02_L16:
       mov       r14d,1
       jmp       near ptr M02_L03
M02_L17:
       mov       rcx,rbx
       mov       rax,[rdi+68]
       call      qword ptr [rax]
       mov       r14d,eax
       mov       rbp,rbx
       jmp       near ptr M02_L03
M02_L18:
       xor       eax,eax
       jmp       near ptr M02_L04
M02_L19:
       mov       rcx,rbp
       mov       rax,[rdi+60]
       call      qword ptr [rax+10]
       jmp       near ptr M02_L04
M02_L20:
       mov       rax,[rcx]
       mov       rax,[rax+68]
       call      qword ptr [rax+8]
       mov       rbx,rax
       mov       rbp,[rsp+38]
       jmp       near ptr M02_L05
M02_L21:
       call      CORINFO_HELP_POLL_GC
       mov       rcx,[rsp+28]
       jmp       near ptr M02_L06
M02_L22:
       mov       ebp,1
       jmp       near ptr M02_L08
M02_L23:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+68]
       call      qword ptr [rax]
       mov       rcx,rbx
       mov       ebp,eax
       jmp       near ptr M02_L08
M02_L24:
       mov       rax,[rcx]
       mov       rax,[rax+98]
       call      qword ptr [rax+8]
       mov       rcx,rax
       jmp       near ptr M02_L09
M02_L25:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFB0F4478A0]
       mov       r8,rax
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FFB0F4478B8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M02_L26:
       mov       rcx,rbp
       mov       rax,[rdi+0B0]
       call      qword ptr [rax]
       jmp       near ptr M02_L10
M02_L27:
       xor       eax,eax
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L28:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M02_L12
M02_L29:
       mov       rcx,rbp
       mov       rax,[rdi+60]
       call      qword ptr [rax+30]
       test      eax,eax
       jne       short M02_L27
       jmp       near ptr M02_L13
; Total bytes of code 663
```
```assembly
; System.RuntimeType+RuntimeTypeCache.ConstructName(System.String ByRef, System.TypeNameFormatFlags)
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rdx
       mov       rcx,[rcx+8]
       mov       [rsp+20],rcx
       lea       rcx,[rsp+20]
       mov       edx,r8d
       call      qword ptr [7FFB0EE54A98]; System.RuntimeTypeHandle.ConstructName(System.TypeNameFormatFlags)
       mov       rsi,rax
       mov       rcx,rbx
       mov       rdx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 63
```
```assembly
; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M04_L10
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M04_L10
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       jbe       short M04_L04
       cmp       r8,40
       ja        near ptr M04_L07
M04_L00:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        short M04_L03
M04_L01:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
M04_L02:
       vzeroupper
       ret
M04_L03:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M04_L01
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M04_L01
M04_L04:
       test      r8b,18
       je        short M04_L05
       mov       rdx,[rdx]
       mov       [rcx],rdx
       mov       rcx,[rax-8]
       mov       [r10-8],rcx
       jmp       short M04_L02
M04_L05:
       test      r8b,4
       je        short M04_L06
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
       jmp       short M04_L02
M04_L06:
       test      r8,r8
       je        short M04_L02
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M04_L02
       movsx     rcx,word ptr [rax-2]
       mov       [r10-2],cx
       jmp       short M04_L02
M04_L07:
       cmp       r8,800
       ja        short M04_L11
       cmp       r8,100
       jb        short M04_L08
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
M04_L08:
       mov       r9,r8
       shr       r9,6
M04_L09:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M04_L09
       and       r8,3F
       cmp       r8,10
       ja        near ptr M04_L00
       jmp       near ptr M04_L01
M04_L10:
       cmp       rcx,rdx
       jne       short M04_L11
       cmp       [rdx],dl
       jmp       near ptr M04_L02
M04_L11:
       cmp       [rcx],cl
       cmp       [rdx],dl
       vzeroupper
       jmp       qword ptr [7FFB0ECB66E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 323
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       edx,[rbx+1C]
       add       edx,[rbx+18]
       je        short M05_L02
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFB6E908D20
       mov       rsi,rax
M05_L00:
       mov       r8d,[rbx+18]
       test      r8d,r8d
       jle       short M05_L01
       mov       rdx,[rbx+8]
       mov       ecx,[rbx+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rsi+8]
       ja        short M05_L03
       cmp       [rdx+8],r8d
       jb        short M05_L03
       movsxd    rcx,ecx
       lea       rcx,[rsi+rcx*2+0C]
       movsxd    r8,r8d
       add       r8,r8
       add       rdx,10
       call      qword ptr [7FFB0ECB5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M05_L01:
       mov       rbx,[rbx+10]
       test      rbx,rbx
       jne       short M05_L00
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M05_L02:
       mov       rax,2D5776A0008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M05_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,19655
       mov       rdx,7FFB0EBF4000
       call      qword ptr [7FFB0EF37738]
       mov       rbx,rax
       call      qword ptr [7FFB0F4464C0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB0F245F68]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 201
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
M06_L00:
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       vzeroupper
       xor       eax,eax
       mov       [rsp+40],rax
       mov       [rsp+80],rcx
       mov       [rsp+90],r8
       mov       rbx,rdx
       mov       rcx,[rbx]
       mov       rbp,offset MT_System.RuntimeType
       cmp       [rcx],rbp
       jne       near ptr M06_L45
       mov       rax,[rcx+18]
       test      al,2
       jne       near ptr M06_L44
       test      dword ptr [rax],80000000
       je        short M06_L01
       xor       edx,edx
       jmp       short M06_L02
M06_L01:
       test      byte ptr [rax],30
       setne     dl
       movzx     edx,dl
M06_L02:
       movzx     r14d,dl
M06_L03:
       test      r14d,r14d
       jne       near ptr M06_L46
       mov       [rsp+88],rbx
       mov       r14,[rbx]
       mov       [rsp+28],r14
       cmp       [r14],rbp
       jne       near ptr M06_L49
       mov       rcx,[r14+18]
       mov       rax,7FFB6E8C06C0
       call      rax
       movzx     ebx,al
       cmp       dword ptr [7FFB6EC1F778],0
       jne       near ptr M06_L47
M06_L04:
       cmp       ebx,14
       je        near ptr M06_L48
       cmp       ebx,1D
       sete      al
       movzx     eax,al
M06_L05:
       test      eax,eax
       jne       near ptr M06_L21
       mov       rbx,[rsp+88]
       mov       rcx,[rbx]
       cmp       [rcx],rbp
       jne       near ptr M06_L71
       call      00007FFB6E8C2C30
M06_L06:
       test      eax,eax
       jne       near ptr M06_L72
       mov       rsi,[rsp+90]
       cmp       byte ptr [rsi],0
       je        near ptr M06_L74
       mov       rcx,[rbx]
       cmp       [rcx],rbp
       jne       near ptr M06_L73
       cmp       qword ptr [rcx+10],0
       je        short M06_L07
       mov       rax,[rcx+10]
       mov       r14,[rax]
       test      r14,r14
       jne       short M06_L09
M06_L07:
       call      qword ptr [7FFB0ECB7C48]; System.RuntimeType.InitializeCache()
       mov       r15,rax
M06_L08:
       mov       rax,[r15+20]
       test      rax,rax
       jne       short M06_L11
       mov       rcx,[r15+8]
       call      qword ptr [7FFB0EE54A68]; System.RuntimeType.IsFullNameRoundtripCompatible(System.RuntimeType)
       test      eax,eax
       jne       short M06_L10
       xor       eax,eax
       jmp       short M06_L11
M06_L09:
       mov       r15,r14
       jmp       short M06_L08
M06_L10:
       lea       rdx,[r15+20]
       mov       rcx,r15
       mov       r8d,3
       call      qword ptr [7FFB0EE54A80]; System.RuntimeType+RuntimeTypeCache.ConstructName(System.String ByRef, System.TypeNameFormatFlags)
M06_L11:
       test      rax,rax
       je        near ptr M06_L74
       mov       rcx,[rbx]
       cmp       [rcx],rbp
       jne       near ptr M06_L75
       cmp       qword ptr [rcx+10],0
       je        short M06_L12
       mov       rax,[rcx+10]
       mov       rbx,[rax]
       test      rbx,rbx
       jne       short M06_L14
M06_L12:
       call      qword ptr [7FFB0ECB7C48]; System.RuntimeType.InitializeCache()
       mov       rbp,rax
M06_L13:
       mov       rbx,[rbp+20]
       test      rbx,rbx
       jne       short M06_L16
       mov       rcx,[rbp+8]
       call      qword ptr [7FFB0EE54A68]; System.RuntimeType.IsFullNameRoundtripCompatible(System.RuntimeType)
       test      eax,eax
       jne       short M06_L15
       xor       ebx,ebx
       jmp       short M06_L16
M06_L14:
       mov       rbp,rbx
       jmp       short M06_L13
M06_L15:
       lea       rdx,[rbp+20]
       mov       rcx,rbp
       mov       r8d,3
       call      qword ptr [7FFB0EE54A80]; System.RuntimeType+RuntimeTypeCache.ConstructName(System.String ByRef, System.TypeNameFormatFlags)
       mov       rbx,rax
M06_L16:
       mov       rdi,[rsp+80]
       mov       rbp,[rdi]
       cmp       [rbp],bpl
       test      rbx,rbx
       je        short M06_L19
       lea       rdx,[rbx+0C]
       mov       r8d,[rbx+8]
       test      r8d,r8d
       je        short M06_L19
       mov       rcx,[rbp+8]
       mov       eax,[rbp+18]
       lea       r14d,[rax+r8]
       cmp       r14d,[rcx+8]
       ja        near ptr M06_L76
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jg        short M06_L17
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       jne       short M06_L18
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M06_L18
M06_L17:
       mov       r8d,r8d
       add       r8,r8
       call      qword ptr [7FFB0ECB5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M06_L18:
       mov       [rbp+18],r14d
M06_L19:
       cmp       word ptr [rsi+4],2B
       jne       near ptr M06_L77
M06_L20:
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M06_L21:
       mov       rbx,[rsp+88]
       mov       rbx,[rbx]
       cmp       [rbx],rbp
       jne       near ptr M06_L53
       mov       rcx,[rbx+18]
       call      00007FFB6E84A930
       test      rax,rax
       je        near ptr M06_L50
       test      al,2
       jne       near ptr M06_L51
       mov       rcx,[rax+20]
       add       rcx,10
       mov       r14,[rcx]
M06_L22:
       test      r14,r14
       je        near ptr M06_L52
M06_L23:
       cmp       [r14],rbp
       jne       near ptr M06_L55
       mov       rcx,[r14+18]
       test      cl,2
       jne       near ptr M06_L54
       mov       ecx,[rcx]
       test      ecx,80000000
       je        short M06_L24
       xor       eax,eax
       jmp       short M06_L25
M06_L24:
       test      cl,30
       setne     al
       movzx     eax,al
M06_L25:
       movzx     ebx,al
M06_L26:
       test      ebx,ebx
       jne       near ptr M06_L56
       cmp       [r14],rbp
       jne       near ptr M06_L59
       mov       [rsp+30],r14
       mov       rcx,[r14+18]
       mov       rax,7FFB6E8C06C0
       call      rax
       movzx     ebx,al
       mov       r14,[rsp+30]
       cmp       dword ptr [7FFB6EC1F778],0
       jne       near ptr M06_L57
M06_L27:
       cmp       ebx,14
       je        near ptr M06_L58
       cmp       ebx,1D
       sete      al
       movzx     eax,al
M06_L28:
       test      eax,eax
       jne       near ptr M06_L42
       cmp       [r14],rbp
       jne       near ptr M06_L63
       mov       rcx,r14
       call      00007FFB6E8C2C30
M06_L29:
       test      eax,eax
       jne       near ptr M06_L64
       mov       rsi,[rsp+90]
       cmp       byte ptr [rsi],0
       je        near ptr M06_L67
       cmp       [r14],rbp
       jne       near ptr M06_L66
       cmp       qword ptr [r14+10],0
       je        short M06_L30
       mov       rcx,[r14+10]
       mov       rbx,[rcx]
       test      rbx,rbx
       jne       short M06_L32
M06_L30:
       mov       rcx,r14
       call      qword ptr [7FFB0ECB7C48]; System.RuntimeType.InitializeCache()
       mov       r15,rax
M06_L31:
       mov       rax,[r15+20]
       test      rax,rax
       jne       short M06_L34
       mov       rcx,[r15+8]
       call      qword ptr [7FFB0EE54A68]; System.RuntimeType.IsFullNameRoundtripCompatible(System.RuntimeType)
       test      eax,eax
       jne       short M06_L33
       xor       eax,eax
       jmp       short M06_L34
M06_L32:
       mov       r15,rbx
       jmp       short M06_L31
M06_L33:
       lea       rdx,[r15+20]
       mov       rcx,r15
       mov       r8d,3
       call      qword ptr [7FFB0EE54A80]; System.RuntimeType+RuntimeTypeCache.ConstructName(System.String ByRef, System.TypeNameFormatFlags)
M06_L34:
       test      rax,rax
       je        near ptr M06_L67
       cmp       [r14],rbp
       jne       near ptr M06_L68
       cmp       qword ptr [r14+10],0
       je        short M06_L35
       mov       rcx,[r14+10]
       mov       rbp,[rcx]
       test      rbp,rbp
       jne       short M06_L37
M06_L35:
       mov       rcx,r14
       call      qword ptr [7FFB0ECB7C48]; System.RuntimeType.InitializeCache()
       mov       r14,rax
M06_L36:
       mov       rbx,[r14+20]
       test      rbx,rbx
       jne       short M06_L39
       mov       rcx,[r14+8]
       call      qword ptr [7FFB0EE54A68]; System.RuntimeType.IsFullNameRoundtripCompatible(System.RuntimeType)
       test      eax,eax
       jne       short M06_L38
       xor       ebx,ebx
       jmp       short M06_L39
M06_L37:
       mov       r14,rbp
       jmp       short M06_L36
M06_L38:
       lea       rdx,[r14+20]
       mov       rcx,r14
       mov       r8d,3
       call      qword ptr [7FFB0EE54A80]; System.RuntimeType+RuntimeTypeCache.ConstructName(System.String ByRef, System.TypeNameFormatFlags)
       mov       rbx,rax
M06_L39:
       mov       rdi,[rsp+80]
       mov       rcx,[rdi]
       cmp       [rcx],cl
       test      rbx,rbx
       je        short M06_L40
       mov       r8d,[rbx+8]
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFB0EE5F0F0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M06_L40:
       cmp       word ptr [rsi+4],2B
       jne       near ptr M06_L69
M06_L41:
       xor       ecx,ecx
       mov       [rsp+40],rcx
       mov       rcx,[rdi]
       mov       rdx,2D5776B09A4
       mov       r8,[rcx+8]
       mov       eax,[rcx+18]
       lea       r10d,[rax+2]
       cmp       [r8+8],r10d
       jb        near ptr M06_L70
       movsxd    rdx,eax
       lea       rdx,[r8+rdx*2+10]
       mov       word ptr [rdx],5B
       mov       word ptr [rdx+2],5D
       mov       [rcx+18],r10d
       jmp       near ptr M06_L20
M06_L42:
       mov       rsi,[rsp+90]
       mov       rdi,[rsp+80]
       cmp       [r14],rbp
       jne       near ptr M06_L61
       mov       rcx,[r14+18]
       call      00007FFB6E84A930
       test      rax,rax
       je        near ptr M06_L60
       mov       rcx,rax
       call      qword ptr [7FFB0ECB5860]; System.RuntimeTypeHandle.GetRuntimeTypeFromHandle(IntPtr)
       nop
M06_L43:
       mov       [rsp+40],rax
       lea       rdx,[rsp+40]
       mov       rcx,rdi
       mov       r8,rsi
       call      qword ptr [7FFB0F37EE08]
       mov       rcx,[rdi]
       mov       rdx,2D5776B09A4
       mov       r8,[rcx+8]
       mov       eax,[rcx+18]
       lea       r10d,[rax+2]
       cmp       [r8+8],r10d
       jb        near ptr M06_L62
       movsxd    rdx,eax
       lea       rdx,[r8+rdx*2+10]
       mov       word ptr [rdx],5B
       mov       word ptr [rdx+2],5D
       mov       [rcx+18],r10d
       jmp       near ptr M06_L41
M06_L44:
       xor       edx,edx
       jmp       near ptr M06_L02
M06_L45:
       mov       rax,[rcx]
       mov       rax,[rax+60]
       call      qword ptr [rax+8]
       mov       r14d,eax
       jmp       near ptr M06_L03
M06_L46:
       mov       rcx,[rbx]
       mov       rax,[rcx]
       mov       rax,[rax+68]
       call      qword ptr [rax+28]
       mov       rdi,[rsp+80]
       mov       rcx,[rdi]
       mov       rdx,[rbx]
       mov       r9d,[rax+8]
       mov       rsi,[rsp+90]
       mov       r8d,[rsi]
       mov       [rsp+38],r8d
       mov       r8w,[rsi+4]
       mov       [rsp+3C],r8w
       lea       r8,[rsp+38]
       mov       [rsp+20],r8
       mov       r8,rax
       call      qword ptr [7FFB0F37F528]
       jmp       near ptr M06_L20
M06_L47:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M06_L04
M06_L48:
       mov       eax,1
       jmp       near ptr M06_L05
M06_L49:
       mov       rcx,r14
       mov       rax,[r14]
       mov       rax,[rax+58]
       call      qword ptr [rax+10]
       jmp       near ptr M06_L05
M06_L50:
       xor       r14d,r14d
       jmp       near ptr M06_L23
M06_L51:
       mov       rcx,rax
       and       rcx,0FFFFFFFFFFFFFFFD
       add       rcx,8
       mov       r14,[rcx]
       jmp       near ptr M06_L22
M06_L52:
       mov       rcx,rax
       call      qword ptr [7FFB0ECB5C80]; System.RuntimeTypeHandle.GetRuntimeTypeFromHandleSlow(IntPtr)
       mov       r14,rax
       jmp       near ptr M06_L23
M06_L53:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+68]
       call      qword ptr [rax+8]
       mov       r14,rax
       jmp       near ptr M06_L23
M06_L54:
       xor       eax,eax
       jmp       near ptr M06_L25
M06_L55:
       mov       rcx,r14
       mov       rax,[r14]
       mov       rax,[rax+60]
       call      qword ptr [rax+8]
       mov       ebx,eax
       jmp       near ptr M06_L26
M06_L56:
       mov       rcx,r14
       mov       rax,[r14]
       mov       rax,[rax+68]
       call      qword ptr [rax+28]
       mov       rdi,[rsp+80]
       mov       rcx,[rdi]
       mov       r9d,[rax+8]
       mov       rsi,[rsp+90]
       mov       edx,[rsi]
       mov       [rsp+38],edx
       mov       dx,[rsi+4]
       mov       [rsp+3C],dx
       lea       rdx,[rsp+38]
       mov       [rsp+20],rdx
       mov       rdx,r14
       mov       r8,rax
       call      qword ptr [7FFB0F37F528]
       jmp       near ptr M06_L41
M06_L57:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M06_L27
M06_L58:
       mov       eax,1
       jmp       near ptr M06_L28
M06_L59:
       mov       rcx,r14
       mov       rax,[r14]
       mov       rax,[rax+58]
       call      qword ptr [rax+10]
       jmp       near ptr M06_L28
M06_L60:
       xor       eax,eax
       jmp       near ptr M06_L43
M06_L61:
       mov       rcx,r14
       mov       rax,[r14]
       mov       rax,[rax+68]
       call      qword ptr [rax+8]
       jmp       near ptr M06_L43
M06_L62:
       mov       r8d,2
       call      qword ptr [7FFB0EE5F180]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M06_L41
M06_L63:
       mov       rcx,r14
       mov       rax,[r14]
       mov       rax,[rax+58]
       call      qword ptr [rax+30]
       jmp       near ptr M06_L29
M06_L64:
       mov       rsi,[rsp+90]
       cmp       byte ptr [rsi+1],0
       je        short M06_L65
       mov       rdi,[rsp+80]
       mov       rsi,[rdi]
       mov       rcx,r14
       mov       rax,[r14]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       rdx,rax
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFB0EE5F1C8]; System.Text.StringBuilder.Append(System.String)
       jmp       near ptr M06_L41
M06_L65:
       mov       rdi,[rsp+80]
       jmp       near ptr M06_L41
M06_L66:
       mov       rcx,r14
       mov       rax,[r14]
       mov       rax,[rax+50]
       call      qword ptr [rax+20]
       jmp       near ptr M06_L34
M06_L67:
       mov       rcx,r14
       mov       rax,[r14]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       rbx,rax
       jmp       near ptr M06_L39
M06_L68:
       mov       rcx,r14
       mov       rax,[r14]
       mov       rax,[rax+50]
       call      qword ptr [rax+20]
       mov       rbx,rax
       jmp       near ptr M06_L39
M06_L69:
       mov       rcx,[rdi]
       movzx     r8d,word ptr [rsi+4]
       mov       r9,[rdi]
       mov       edx,[r9+1C]
       add       edx,[r9+18]
       mov       r9d,edx
       sub       r9d,[rbx+8]
       jo        near ptr M06_L78
       mov       edx,[rbx+8]
       mov       [rsp+20],edx
       mov       edx,2B
       cmp       [rcx],ecx
       call      qword ptr [7FFB0F37F288]
       jmp       near ptr M06_L41
M06_L70:
       mov       r8d,2
       call      qword ptr [7FFB0EE5F180]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M06_L20
M06_L71:
       mov       rax,[rcx]
       mov       rax,[rax+58]
       call      qword ptr [rax+30]
       jmp       near ptr M06_L06
M06_L72:
       mov       rsi,[rsp+90]
       cmp       byte ptr [rsi+1],0
       je        near ptr M06_L20
       mov       rdi,[rsp+80]
       mov       rsi,[rdi]
       mov       rcx,[rbx]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       rdx,rax
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFB0EE5F1C8]; System.Text.StringBuilder.Append(System.String)
       jmp       near ptr M06_L20
M06_L73:
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+20]
       jmp       near ptr M06_L11
M06_L74:
       mov       rcx,[rbx]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       rbx,rax
       jmp       near ptr M06_L16
M06_L75:
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+20]
       mov       rbx,rax
       jmp       near ptr M06_L16
M06_L76:
       mov       rcx,rbp
       call      qword ptr [7FFB0EE5F180]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M06_L19
M06_L77:
       mov       rcx,[rdi]
       movzx     r8d,word ptr [rsi+4]
       mov       r9,[rdi]
       mov       edx,[r9+1C]
       add       edx,[r9+18]
       mov       r9d,edx
       sub       r9d,[rbx+8]
       jo        short M06_L78
       mov       edx,[rbx+8]
       mov       [rsp+20],edx
       mov       edx,2B
       cmp       [rcx],ecx
       call      qword ptr [7FFB0F37F288]
       jmp       near ptr M06_L20
M06_L78:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 2071
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
       call      qword ptr [7FFB6E718018]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-0A0]
       mov       rdx,[rbp-0A8]
       call      qword ptr [rax]
       lea       rcx,[rbp-98]
       call      qword ptr [7FFB6E718020]; CORINFO_HELP_JIT_PINVOKE_END
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
       jg        near ptr M08_L05
       cmp       eax,esi
       jl        near ptr M08_L05
       mov       rax,[rbx+8]
       mov       ebp,[rax+8]
       sub       ebp,ecx
       test      ebp,ebp
       jle       short M08_L01
       mov       rax,[rbx+8]
       test      rax,rax
       je        near ptr M08_L06
       mov       edx,[rax+8]
       cmp       edx,ecx
       jb        near ptr M08_L07
       mov       r8d,ecx
       lea       rax,[rax+r8*2+10]
       sub       edx,ecx
M08_L00:
       cmp       ebp,edx
       ja        near ptr M08_L11
       mov       r8d,ebp
       add       r8,r8
       mov       rcx,rax
       mov       rdx,rdi
       call      qword ptr [7FFB0ECB5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M08_L01:
       sub       esi,ebp
       mov       ecx,[rbx+1C]
       lea       edx,[rsi+rcx]
       mov       eax,[rbx+18]
       add       edx,eax
       cmp       edx,[rbx+20]
       jg        near ptr M08_L08
       cmp       edx,esi
       jl        near ptr M08_L08
       add       ecx,eax
       mov       edx,ecx
       mov       eax,1F40
       cmp       edx,1F40
       cmovg     edx,eax
       cmp       esi,edx
       mov       eax,edx
       cmovge    eax,esi
       add       ecx,eax
       cmp       ecx,eax
       jl        near ptr M08_L09
       cmp       eax,400
       jge       short M08_L02
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
       jmp       short M08_L03
M08_L02:
       mov       ecx,eax
       xor       edx,edx
       call      qword ptr [7FFB0F2CE3D0]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       r14,rax
M08_L03:
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
       je        near ptr M08_L10
       lea       rcx,[r8+10]
       mov       r8d,[r8+8]
M08_L04:
       cmp       esi,r8d
       ja        near ptr M08_L11
       mov       r8d,esi
       add       r8,r8
       call      qword ptr [7FFB0ECB5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       [rbx+18],esi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M08_L05:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,19685
       mov       rdx,7FFB0EBF4000
       call      qword ptr [7FFB0EF37738]
       mov       rsi,rax
       call      qword ptr [7FFB0F447768]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFB0F245F68]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M08_L06:
       test      ecx,ecx
       jne       short M08_L07
       xor       eax,eax
       xor       edx,edx
       jmp       near ptr M08_L00
M08_L07:
       call      qword ptr [7FFB0EE57138]
       int       3
M08_L08:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,1969B
       mov       rdx,7FFB0EBF4000
       call      qword ptr [7FFB0EF37738]
       mov       rsi,rax
       call      qword ptr [7FFB0F447780]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFB0F245F68]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M08_L09:
       mov       rcx,offset MT_System.OutOfMemoryException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB0F447798]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M08_L10:
       xor       ecx,ecx
       xor       r8d,r8d
       jmp       near ptr M08_L04
M08_L11:
       call      qword ptr [7FFB0F15C258]
       int       3
; Total bytes of code 621
```
```assembly
; System.Text.StringBuilder.Append(System.String)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       test      rdx,rdx
       je        short M09_L02
       lea       rax,[rdx+0C]
       mov       r8d,[rdx+8]
       test      r8d,r8d
       je        short M09_L02
       mov       rcx,[rbx+8]
       mov       edx,[rbx+18]
       lea       esi,[rdx+r8]
       cmp       esi,[rcx+8]
       ja        short M09_L03
       movsxd    rdx,edx
       lea       rcx,[rcx+rdx*2+10]
       cmp       r8d,2
       jg        short M09_L00
       movzx     edx,word ptr [rax]
       mov       [rcx],dx
       cmp       r8d,2
       jne       short M09_L01
       movzx     r8d,word ptr [rax+2]
       mov       [rcx+2],r8w
       jmp       short M09_L01
M09_L00:
       mov       r8d,r8d
       add       r8,r8
       mov       rdx,rax
       call      qword ptr [7FFB0ECB5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M09_L01:
       mov       [rbx+18],esi
M09_L02:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M09_L03:
       mov       rcx,rbx
       mov       rdx,rax
       call      qword ptr [7FFB0EE5F180]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M09_L02
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
       call      qword ptr [7FFB6E73DAC8]; Precode of System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M11_L00
       mov       eax,1
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M11_L00:
       cmp       qword ptr [rdi+10],0
       jne       short M11_L01
       xor       eax,eax
       mov       [rbx],rax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M11_L01:
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
; System.SpanHelpers.Fill[[System.Char, System.Private.CoreLib]](Char ByRef, UIntPtr, Char)
       cmp       rdx,10
       jae       short M12_L05
       xor       eax,eax
       cmp       rdx,8
       jae       short M12_L10
M12_L00:
       test      dl,4
       jne       near ptr M12_L12
M12_L01:
       test      dl,2
       jne       short M12_L04
M12_L02:
       test      dl,1
       je        short M12_L03
       mov       [rcx+rax*2],r8w
M12_L03:
       vzeroupper
       ret
M12_L04:
       mov       [rcx+rax*2],r8w
       mov       [rcx+rax*2+2],r8w
       add       rax,2
       jmp       short M12_L02
M12_L05:
       vmovd     xmm0,r8d
       vpbroadcastw ymm0,xmm0
       lea       rax,[rdx+rdx]
       mov       r8,rax
       and       r8,0FFFFFFFFFFFFFFC0
       xor       r10d,r10d
       cmp       rdx,20
       jb        short M12_L07
M12_L06:
       vmovups   [rcx+r10],ymm0
       vmovups   [rcx+r10+20],ymm0
       add       r10,40
       cmp       r10,r8
       jb        short M12_L06
M12_L07:
       test      al,20
       jne       short M12_L09
M12_L08:
       vmovups   [rcx+rax-20],ymm0
       jmp       short M12_L03
M12_L09:
       vmovups   [rcx+r10],ymm0
       jmp       short M12_L08
M12_L10:
       mov       r10,rdx
       and       r10,0FFFFFFFFFFFFFFF8
M12_L11:
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
       jb        short M12_L11
       jmp       near ptr M12_L00
M12_L12:
       mov       [rcx+rax*2],r8w
       mov       [rcx+rax*2+2],r8w
       mov       [rcx+rax*2+4],r8w
       mov       [rcx+rax*2+6],r8w
       add       rax,4
       jmp       near ptr M12_L01
; Total bytes of code 231
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
       call      qword ptr [7FFB6E718018]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-0B0]
       mov       edx,[rbp-0A4]
       mov       r8d,[rbp-0A8]
       mov       r9,[rbp-0B8]
       call      qword ptr [rax]
       lea       rcx,[rbp-0A0]
       call      qword ptr [7FFB6E718020]; CORINFO_HELP_JIT_PINVOKE_END
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
; System.Array.Copy(System.Array, System.Array, Int32)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       rsi,rcx
       mov       rbx,rdx
       mov       edi,r8d
       test      rsi,rsi
       jne       short M14_L01
       xor       ebp,ebp
       xor       r14d,r14d
M14_L00:
       test      rbx,rbx
       jne       near ptr M14_L09
       xor       ebx,ebx
       xor       r15d,r15d
       jmp       near ptr M14_L10
M14_L01:
       test      rbx,rbx
       jne       short M14_L04
       mov       rcx,7FFB0F45CE84
       call      CORINFO_HELP_COUNTPROFILE32
M14_L02:
       mov       rcx,7FFB0F45CE8C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rsi]
       mov       ecx,[rcx+4]
       add       ecx,0FFFFFFE8
       shr       ecx,3
       jne       short M14_L08
       xor       r14d,r14d
M14_L03:
       mov       rbp,rsi
       jmp       short M14_L00
M14_L04:
       mov       r15,[rsi]
       cmp       r15,[rbx]
       je        short M14_L05
       mov       rcx,7FFB0F45CE80
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M14_L02
M14_L05:
       cmp       dword ptr [r15+4],18
       je        short M14_L06
       mov       rcx,7FFB0F45CE7C
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M14_L02
M14_L06:
       cmp       edi,[rsi+8]
       jbe       short M14_L07
       mov       rcx,7FFB0F45CE78
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M14_L02
M14_L07:
       cmp       edi,[rbx+8]
       jbe       near ptr M14_L13
       mov       rcx,7FFB0F45CE74
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M14_L02
M14_L08:
       movsxd    rcx,ecx
       mov       r14d,[rsi+rcx*4+10]
       jmp       short M14_L03
M14_L09:
       mov       rcx,7FFB0F45CE90
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbx]
       mov       ecx,[rcx+4]
       add       ecx,0FFFFFFE8
       shr       ecx,3
       jne       short M14_L12
       xor       r15d,r15d
M14_L10:
       mov       rcx,7FFB0F45CE94
       call      CORINFO_HELP_COUNTPROFILE32
       mov       [rsp+20],edi
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rbp
       mov       edx,r14d
       mov       r8,rbx
       mov       r9d,r15d
       call      qword ptr [7FFB0F445200]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
M14_L11:
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M14_L12:
       movsxd    rcx,ecx
       mov       r15d,[rbx+rcx*4+10]
       jmp       short M14_L10
M14_L13:
       mov       edi,edi
       movzx     ebp,word ptr [r15]
       imul      rdi,rbp
       add       rsi,10
       add       rbx,10
       test      dword ptr [r15],1000000
       je        short M14_L15
       mov       rcx,7FFB0F45CE70
       call      CORINFO_HELP_COUNTPROFILE32
       cmp       rdi,4000
       ja        short M14_L14
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       call      00007FFB6E8B5D60
       cmp       dword ptr [7FFB6EC1F778],0
       je        short M14_L11
       call      CORINFO_HELP_POLL_GC
       jmp       short M14_L11
M14_L14:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       qword ptr [7FFB0F2CDB78]
M14_L15:
       mov       rcx,7FFB0F45CE88
       call      CORINFO_HELP_COUNTPROFILE32
       cmp       rdi,19
       jne       short M14_L16
       vmovdqu   xmm0,xmmword ptr [rsi]
       vmovdqu   xmm1,xmmword ptr [rsi+9]
       vmovdqu   xmmword ptr [rbx],xmm0
       vmovdqu   xmmword ptr [rbx+9],xmm1
       jmp       near ptr M14_L11
M14_L16:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       call      qword ptr [7FFB0ECB5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M14_L11
; Total bytes of code 488
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
       jg        near ptr M15_L10
       cmp       dword ptr [rbx+20],0
       jl        near ptr M15_L11
       cmp       qword ptr [rbx+10],0
       je        near ptr M15_L08
       mov       eax,r8d
       add       eax,[rbx+18]
       mov       edi,eax
       neg       edi
       test      edi,edi
       jg        near ptr M15_L07
       mov       rdi,rbx
       test      r8d,r8d
       jle       short M15_L01
M15_L00:
       mov       rdi,[rdi+10]
       cmp       dword ptr [rdi+1C],0
       jg        short M15_L00
M15_L01:
       cmp       rdi,rbx
       je        near ptr M15_L06
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
       jge       short M15_L02
       cmp       ecx,400
       jge       short M15_L03
       movsxd    rdx,ecx
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rsi,rax
       jmp       short M15_L04
M15_L02:
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M15_L05
M15_L03:
       xor       edx,edx
       call      qword ptr [7FFB0F2CE3D0]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       rsi,rax
M15_L04:
       mov       rcx,[rdi+8]
       mov       r8d,[rdi+18]
       mov       rdx,rsi
       call      qword ptr [7FFB0EE54FD8]; System.Array.Copy(System.Array, System.Array, Int32)
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M15_L05:
       mov       rdx,[rdi+10]
       lea       rcx,[rbx+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       edx,[rdi+1C]
       mov       [rbx+1C],edx
M15_L06:
       mov       edx,[rdi+1C]
       neg       edx
       mov       [rbx+18],edx
       jmp       short M15_L09
M15_L07:
       mov       edx,[rbx+18]
       mov       ecx,edx
       mov       r8d,edi
       add       rcx,r8
       mov       r8d,[rsi+8]
       cmp       rcx,r8
       ja        near ptr M15_L12
       mov       edx,edx
       lea       rcx,[rsi+rdx*2+10]
       mov       edx,edi
       xor       r8d,r8d
       call      qword ptr [7FFB0F157210]; System.SpanHelpers.Fill[[System.Char, System.Private.CoreLib]](Char ByRef, UIntPtr, Char)
       add       [rbx+18],edi
       jmp       short M15_L09
M15_L08:
       xor       eax,eax
       mov       [rbx+18],rax
M15_L09:
       mov       eax,1
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M15_L10:
       xor       eax,eax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M15_L11:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FFB0EBF4000
       call      qword ptr [7FFB0EF37738]
       mov       rsi,rax
       call      qword ptr [7FFB0F447780]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFB0F245F68]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M15_L12:
       mov       rcx,rbx
       mov       r8d,edi
       xor       edx,edx
       call      qword ptr [7FFB0F44C948]
       jmp       short M15_L09
; Total bytes of code 431
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
       call      qword ptr [7FFB6E73DAD8]; Precode of System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryEnqueue(System.__Canon)
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

## .NET 10.0.0 (10.0.0, 10.0.25.52411), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark.GetTypeMembersWithAttribute()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.TypeHelper+<GetMembersWithAttribute>d__36<DotNetTips.Spargine.Core.InformationAttribute>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       dword ptr [rsi+28],0FFFFFFFE
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rsi+2C],eax
       mov       rdx,20FF23E0668
       mov       [rsi+18],rdx
       mov       rdx,rsi
       mov       rcx,7FFB0F43E250
       call      qword ptr [7FFB0F3AEF40]; System.Linq.Enumerable.<ToArray>g__EnumerableToArray|324_0[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rsi,rax
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<System.Reflection.MemberInfo>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       test      rsi,rsi
       je        short M00_L00
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rsp+28],rdi
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L00:
       mov       ecx,14
       call      qword ptr [7FFB0EF6C1C8]
       int       3
; Total bytes of code 170
```
```assembly
; System.Linq.Enumerable.<ToArray>g__EnumerableToArray|324_0[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,1A8
       lea       rbp,[rsp+1E0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-1A0],xmm4
       mov       rax,0FFFFFFFFFFFFFEB0
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       vmovdqa   xmmword ptr [rbp+rax-20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-40],rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M01_L31
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rbp-80],ymm0
       vmovdqu   ymmword ptr [rbp-60],ymm0
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rbp-178],ymm0
       vmovdqu   ymmword ptr [rbp-158],ymm0
       vmovdqu   ymmword ptr [rbp-138],ymm0
       vmovdqu   ymmword ptr [rbp-118],ymm0
       vmovdqu   ymmword ptr [rbp-0F8],ymm0
       vmovdqu   ymmword ptr [rbp-0D8],ymm0
       vmovdqu   ymmword ptr [rbp-0C0],ymm0
       xor       edx,edx
       mov       [rbp-188],edx
       mov       [rbp-184],edx
       mov       [rbp-180],edx
       lea       rdx,[rbp-80]
       mov       [rbp-0A0],rdx
       mov       dword ptr [rbp-98],8
       lea       rdx,[rbp-80]
       mov       [rbp-90],rdx
       mov       dword ptr [rbp-88],8
       mov       rdx,[rcx+18]
       mov       rsi,[rdx+28]
       test      rsi,rsi
       je        near ptr M01_L29
M01_L01:
       mov       rdi,rsi
       mov       r14,[rbp-90]
       mov       r15d,[rbp-88]
       mov       r13d,[rbp-180]
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0B0
       jle       near ptr M01_L30
       mov       r11,[rcx+0B0]
       test      r11,r11
       je        near ptr M01_L30
M01_L02:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp-1B8],rax
M01_L03:
       mov       rcx,rax
       mov       r11,7FFB0EC30BF0
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M01_L08
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0B8
       jle       short M01_L05
       mov       r11,[rcx+0B8]
       test      r11,r11
       je        short M01_L05
M01_L04:
       mov       rcx,[rbp-1B8]
       call      qword ptr [r11]
       mov       rbx,rax
       cmp       r13d,r15d
       jae       short M01_L06
       mov       ecx,r13d
       lea       rcx,[r14+rcx*8]
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       r13d
       mov       rax,[rbp-1B8]
       jmp       short M01_L03
M01_L05:
       mov       rcx,rdi
       mov       rdx,7FFB0F4F9908
       call      qword ptr [7FFB0ECEC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       short M01_L04
M01_L06:
       lea       rcx,[rbp-188]
       mov       rdx,rdi
       mov       r8d,10
       call      qword ptr [7FFB0F484660]; System.Collections.Generic.SegmentedArrayBuilder`1[[System.__Canon, System.Private.CoreLib]].Expand(Int32)
       mov       r14,[rbp-90]
       mov       r15d,[rbp-88]
       test      r15d,r15d
       je        short M01_L07
       mov       rcx,r14
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r13d,1
       mov       rax,[rbp-1B8]
       jmp       near ptr M01_L03
M01_L07:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M01_L08:
       mov       rcx,[rbp-1B8]
       mov       r11,7FFB0EC30BF8
       call      qword ptr [r11]
       mov       [rbp-180],r13d
       mov       rbx,rsi
       mov       edi,[rbp-184]
       add       edi,[rbp-180]
       jo        near ptr M01_L42
       mov       r14d,edi
       test      r14d,r14d
       jne       near ptr M01_L15
       mov       rcx,[rbx+30]
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0C0
       jle       short M01_L13
       mov       rcx,[rcx+0C0]
       test      rcx,rcx
       je        short M01_L13
M01_L09:
       mov       rdx,[rcx+18]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M01_L14
M01_L10:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r15,[rax]
M01_L11:
       mov       rdx,rsi
       mov       r8d,[rbp-188]
       test      r8d,r8d
       jne       near ptr M01_L41
M01_L12:
       mov       rax,r15
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
M01_L13:
       mov       rcx,rbx
       mov       rdx,7FFB0F4F99D8
       call      qword ptr [7FFB0ECEC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M01_L09
M01_L14:
       mov       rdx,7FFB0F4AFBD8
       call      qword ptr [7FFB0EF67AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       short M01_L10
M01_L15:
       mov       rcx,[rbx+30]
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0C8
       jle       near ptr M01_L22
       mov       rcx,[rcx+0C8]
       test      rcx,rcx
       je        near ptr M01_L22
M01_L16:
       mov       rdx,[rcx+18]
       mov       rax,[rdx+18]
       test      rax,rax
       je        near ptr M01_L23
       mov       rcx,rax
M01_L17:
       movsxd    rdx,r14d
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r15,rax
       mov       rcx,[rbx+30]
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0A8
       jle       near ptr M01_L24
       mov       rcx,[rcx+0A8]
       test      rcx,rcx
       je        near ptr M01_L24
M01_L18:
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+20]
       test      rax,rax
       je        near ptr M01_L25
M01_L19:
       cmp       [r15],rax
       jne       near ptr M01_L32
       lea       r14,[r15+10]
       mov       r13,r14
       mov       r12d,edi
       mov       eax,[rbp-188]
       mov       [rbp-18C],eax
       test      eax,eax
       jne       near ptr M01_L26
M01_L20:
       mov       ecx,[rbp-180]
       cmp       ecx,[rbp-88]
       jbe       near ptr M01_L27
M01_L21:
       call      qword ptr [7FFB0EE87138]
       int       3
M01_L22:
       mov       rcx,rbx
       mov       rdx,7FFB0F4F9A10
       call      qword ptr [7FFB0ECEC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L16
M01_L23:
       mov       rdx,7FFB0F4F8818
       call      qword ptr [7FFB0EF67AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L17
M01_L24:
       mov       rcx,rbx
       mov       rdx,7FFB0F4F84A0
       call      qword ptr [7FFB0ECEC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L18
M01_L25:
       mov       rdx,7FFB0F4F6478
       call      qword ptr [7FFB0ECEC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M01_L19
M01_L26:
       mov       rdx,[rbp-0A0]
       mov       r13d,[rbp-98]
       cmp       r13d,edi
       jg        short M01_L28
       mov       r12d,r13d
       shl       r12,3
       mov       r8,r12
       mov       rcx,r14
       call      qword ptr [7FFB0ECE57A0]; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       add       r14,r12
       sub       edi,r13d
       mov       r12d,edi
       mov       r13,r14
       mov       edi,[rbp-18C]
       dec       edi
       je        near ptr M01_L20
       jmp       near ptr M01_L33
M01_L27:
       mov       rdx,[rbp-90]
       cmp       ecx,r12d
       ja        short M01_L28
       mov       r8d,ecx
       shl       r8,3
       cmp       r8,4000
       ja        near ptr M01_L40
       mov       rcx,r13
       call      00007FFB6E8B5D60
       cmp       dword ptr [7FFB6EC1F778],0
       je        near ptr M01_L11
       jmp       near ptr M01_L39
M01_L28:
       call      qword ptr [7FFB0F18C258]
       int       3
M01_L29:
       mov       rdx,7FFB0F4F92D8
       call      qword ptr [7FFB0EF67AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M01_L01
M01_L30:
       mov       rcx,rdi
       mov       rdx,7FFB0F4F98F0
       call      qword ptr [7FFB0ECEC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M01_L02
M01_L31:
       mov       ecx,11
       call      qword ptr [7FFB0EF67DF8]
       int       3
M01_L32:
       call      qword ptr [7FFB0F48D158]
       int       3
M01_L33:
       mov       rcx,[rbx+30]
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0D8
       jle       short M01_L34
       mov       rdx,[rcx+0D8]
       test      rdx,rdx
       je        short M01_L34
       jmp       short M01_L35
M01_L34:
       mov       rcx,rbx
       mov       rdx,7FFB0F4F9A58
       call      qword ptr [7FFB0ECEC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M01_L35:
       lea       rcx,[rbp-1A0]
       lea       r8,[rbp-178]
       mov       r9d,1B
       call      qword ptr [7FFB0F484858]; <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan[[System.Collections.Generic.SegmentedArrayBuilder`1+Arrays[[System.__Canon, System.Private.CoreLib]], System.Linq],[System.__Canon, System.Private.CoreLib]](Arrays<System.__Canon> ByRef, Int32)
       cmp       edi,[rbp-198]
       ja        near ptr M01_L21
       mov       rbx,[rbp-1A0]
       xor       r14d,r14d
M01_L36:
       mov       r8,[rbx+r14*8]
       test      r8,r8
       jne       short M01_L37
       xor       edx,edx
       xor       eax,eax
       jmp       short M01_L38
M01_L37:
       lea       rdx,[r8+10]
       mov       eax,[r8+8]
M01_L38:
       cmp       eax,r12d
       jg        near ptr M01_L28
       mov       [rbp-1A4],eax
       mov       r10d,eax
       shl       r10,3
       mov       [rbp-1B0],r10
       mov       r8,r10
       mov       rcx,r13
       call      qword ptr [7FFB0ECE57A0]; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbp-1B0]
       add       r13,rcx
       sub       r12d,[rbp-1A4]
       inc       r14d
       cmp       r14d,edi
       jl        short M01_L36
       jmp       near ptr M01_L20
M01_L39:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M01_L11
M01_L40:
       mov       rcx,r13
       call      qword ptr [7FFB0F2FDB60]
       jmp       near ptr M01_L11
M01_L41:
       lea       rcx,[rbp-188]
       call      qword ptr [7FFB0F484978]; System.Collections.Generic.SegmentedArrayBuilder`1[[System.__Canon, System.Private.CoreLib]].ReturnArrays(Int32)
       jmp       near ptr M01_L12
M01_L42:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       mov       rcx,[rbp-1B8]
       test      rcx,rcx
       je        short M01_L43
       mov       r11,7FFB0EC30BF8
       call      qword ptr [r11]
M01_L43:
       nop
       add       rsp,28
       ret
; Total bytes of code 1484
```

## .NET 10.0.0 (10.0.0, 10.0.25.52411), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark.HasBaseClass()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+30],ymm4
       mov       rbx,rcx
       mov       rcx,1681E851160
       mov       rsi,[rcx]
       test      rsi,rsi
       jne       short M00_L00
       mov       rcx,1A8B3C30668
       call      qword ptr [7FFB0ECC7C48]; System.RuntimeType.InitializeCache()
       mov       rdi,rax
       jmp       short M00_L01
M00_L00:
       mov       rdi,rsi
M00_L01:
       mov       rsi,[rdi+20]
       test      rsi,rsi
       jne       short M00_L03
       mov       rcx,[rdi+8]
       cmp       [rcx],ecx
       call      qword ptr [7FFB0ECCC6C0]; System.Type.GetRootElementType()
       mov       rsi,rax
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rbp,[rax+60]
       call      qword ptr [rbp+10]
       test      eax,eax
       jne       short M00_L02
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+0B0]
       call      qword ptr [rax]
       test      eax,eax
       jne       short M00_L04
M00_L02:
       mov       rcx,rsi
       call      qword ptr [rbp+30]
       test      eax,eax
       jne       short M00_L04
       lea       rdx,[rdi+20]
       mov       rcx,rdi
       mov       r8d,3
       call      qword ptr [7FFB0EE64A80]; System.RuntimeType+RuntimeTypeCache.ConstructName(System.String ByRef, System.TypeNameFormatFlags)
       mov       rsi,rax
M00_L03:
       mov       rcx,1681E8411A0
       mov       rdi,[rcx]
       test      rdi,rdi
       je        short M00_L05
       mov       rbp,rdi
       jmp       short M00_L06
M00_L04:
       xor       esi,esi
       jmp       short M00_L03
M00_L05:
       mov       rcx,1A8B3C219B8
       call      qword ptr [7FFB0ECC7C48]; System.RuntimeType.InitializeCache()
       mov       rbp,rax
M00_L06:
       mov       rdi,[rbp+20]
       test      rdi,rdi
       jne       short M00_L08
       mov       rcx,[rbp+8]
       cmp       [rcx],ecx
       call      qword ptr [7FFB0ECCC6C0]; System.Type.GetRootElementType()
       mov       rdi,rax
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       r14,[rax+60]
       call      qword ptr [r14+10]
       test      eax,eax
       jne       short M00_L07
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+0B0]
       call      qword ptr [rax]
       test      eax,eax
       jne       near ptr M00_L18
M00_L07:
       mov       rcx,rdi
       call      qword ptr [r14+30]
       test      eax,eax
       jne       near ptr M00_L18
       lea       rdx,[rbp+20]
       mov       rcx,rbp
       mov       r8d,3
       call      qword ptr [7FFB0EE64A80]; System.RuntimeType+RuntimeTypeCache.ConstructName(System.String ByRef, System.TypeNameFormatFlags)
       mov       rdi,rax
M00_L08:
       test      rsi,rsi
       je        near ptr M00_L44
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        near ptr M00_L44
       test      rdi,rdi
       je        near ptr M00_L45
       cmp       dword ptr [rdi+8],0
       je        near ptr M00_L45
       mov       edx,ebp
       mov       ecx,[rdi+8]
       lea       rdx,[rdx+rcx+0E]
       cmp       rdx,7FFFFFFF
       jg        near ptr M00_L46
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFB6E908D20
       mov       r14,rax
       cmp       [r14],r14b
       lea       rcx,[r14+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFB0ECC5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,ebp
       lea       rcx,[r14+rcx*2+0C]
       vmovups   xmm0,[7FFB0F4D7190]
       vmovups   [rcx],xmm0
       mov       r8,730061006C0043
       mov       [rcx+10],r8
       mov       dword ptr [rcx+18],2E0073
       add       ebp,0E
       movsxd    rcx,ebp
       lea       rcx,[r14+rcx*2+0C]
       mov       r8d,[rdi+8]
       add       r8,r8
       lea       rdx,[rdi+0C]
       call      qword ptr [7FFB0ECC5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L09:
       mov       rcx,16834C000D8
       mov       rsi,[rcx]
       test      r14,r14
       je        near ptr M00_L47
       mov       edi,[r14+8]
       test      edi,edi
       je        near ptr M00_L47
       movzx     ecx,word ptr [r14+0C]
       cmp       ecx,100
       jge       near ptr M00_L49
       mov       rax,7FFB6DAA6918
       test      byte ptr [rax+rcx],80
       jne       near ptr M00_L51
M00_L10:
       dec       edi
       mov       ecx,edi
       movzx     ecx,word ptr [r14+rcx*2+0C]
       cmp       ecx,100
       jge       near ptr M00_L50
       mov       rax,7FFB6DAA6918
       test      byte ptr [rax+rcx],80
       jne       near ptr M00_L51
M00_L11:
       mov       rdi,r14
M00_L12:
       mov       rsi,[rsi+10]
       test      rdi,rdi
       jne       near ptr M00_L19
       xor       ebp,ebp
       xor       r15d,r15d
M00_L13:
       cmp       byte ptr [rsi+44],0
       jne       near ptr M00_L52
       mov       rdi,[rsi+28]
       mov       rcx,[rdi+20]
       mov       r13,[rcx+8]
       mov       r12,[r13+8]
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer+OrdinalComparer
       cmp       [r12],rcx
       jne       near ptr M00_L53
       mov       [rsp+28],rbp
       mov       [rsp+30],r15d
       lea       rcx,[rsp+28]
       call      qword ptr [7FFB0F2D5650]; System.String.GetNonRandomizedHashCode(System.ReadOnlySpan`1<Char>)
M00_L14:
       mov       [rsp+54],eax
       mov       rcx,[r13+10]
       mov       edx,eax
       imul      rdx,[r13+28]
       shr       rdx,20
       inc       rdx
       mov       r8d,[rcx+8]
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,[rcx+8]
       jae       near ptr M00_L82
       mov       edx,edx
       mov       r13,[rcx+rdx*8+10]
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer+OrdinalComparer
       cmp       [r12],rcx
       jne       near ptr M00_L40
M00_L15:
       test      r13,r13
       je        near ptr M00_L66
       cmp       eax,[r13+20]
       jne       near ptr M00_L55
       mov       r8,[r13+8]
       test      r15d,r15d
       je        near ptr M00_L54
M00_L16:
       test      r8,r8
       jne       short M00_L20
       xor       edx,edx
       xor       r10d,r10d
M00_L17:
       cmp       r15d,r10d
       jne       near ptr M00_L39
       mov       r8d,r10d
       add       r8,r8
       cmp       r8,0A
       jne       short M00_L21
       mov       rcx,rbp
       mov       r8,[rcx]
       mov       rcx,[rcx+2]
       mov       r10,[rdx]
       xor       r8,r10
       xor       rcx,[rdx+2]
       or        rcx,r8
       sete      cl
       movzx     ecx,cl
       mov       eax,ecx
       jmp       short M00_L22
M00_L18:
       xor       edi,edi
       jmp       near ptr M00_L08
M00_L19:
       lea       rbp,[rdi+0C]
       mov       r15d,[rdi+8]
       jmp       near ptr M00_L13
M00_L20:
       lea       rdx,[r8+0C]
       mov       r10d,[r8+8]
       jmp       short M00_L17
M00_L21:
       mov       rcx,rbp
       call      qword ptr [7FFB0ECCFB70]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
M00_L22:
       test      eax,eax
       je        near ptr M00_L55
M00_L23:
       mov       rbp,[r13+10]
M00_L24:
       mov       rax,[rsi+10]
       mov       rcx,[rax+8]
       test      rcx,rcx
       jne       near ptr M00_L67
       call      qword ptr [7FFB0F255E90]; System.DateTime.get_UtcNow()
       mov       r15,rax
M00_L25:
       test      rbp,rbp
       je        near ptr M00_L77
       cmp       byte ptr [rbp+43],0
       jne       near ptr M00_L72
       mov       rdx,[rbp+38]
       test      rdx,rdx
       jl        near ptr M00_L68
M00_L26:
       mov       rcx,3FFFFFFFFFFFFFFF
       and       rcx,r15
       cmp       rdx,rcx
       jbe       near ptr M00_L69
       cmp       qword ptr [rbp+50],0
       jg        near ptr M00_L70
M00_L27:
       xor       r13d,r13d
M00_L28:
       test      r13d,r13d
       jne       near ptr M00_L72
M00_L29:
       cmp       qword ptr [rbp+10],0
       jne       near ptr M00_L71
M00_L30:
       mov       [rbp+58],r15
       mov       rdi,[rbp+20]
       cmp       byte ptr [rsi+45],0
       jne       near ptr M00_L73
M00_L31:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+28]
       mov       rdx,[rsi+48]
       mov       rax,3FFFFFFFFFFFFFFF
       and       rax,r15
       mov       r8,3FFFFFFFFFFFFFFF
       and       rdx,r8
       sub       rax,rdx
       cmp       rcx,rax
       jl        near ptr M00_L74
M00_L32:
       cmp       qword ptr [rsi+20],0
       jne       near ptr M00_L75
M00_L33:
       test      rdi,rdi
       jne       near ptr M00_L41
M00_L34:
       xor       esi,esi
       mov       rcx,1A8B3C30668
M00_L35:
       mov       rax,1A8B3C219B8
       cmp       rcx,rax
       jne       near ptr M00_L42
       mov       esi,1
M00_L36:
       mov       ecx,5
       call      qword ptr [7FFB0F38EDC0]; System.TimeSpan.FromMinutes(Int64)
       mov       rdi,rax
       mov       rcx,16834C000D8
       mov       rbp,[rcx]
       mov       rcx,r14
       call      qword ptr [7FFB0EF4E148]; System.String.IsNullOrEmpty(System.String)
       test      eax,eax
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M00_L80
M00_L37:
       mov       rcx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFB0F164078]; System.String.Trim()
       mov       r14,rax
       mov       ecx,esi
       xor       edx,edx
       mov       r8,1A8B3C20008
       mov       r9,1A8B3C2B778
       call      qword ptr [7FFB0F38F7B0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Boolean, System.Private.CoreLib]](Boolean, Boolean, System.String, System.String)
       mov       r15d,eax
       mov       rcx,offset MT_Microsoft.Extensions.Caching.Memory.MemoryCacheEntryOptions
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rbp,[rbp+10]
       mov       rcx,r13
       call      qword ptr [7FFB0F38F858]; Microsoft.Extensions.Caching.Memory.MemoryCacheEntryOptions..ctor()
       mov       rcx,r13
       mov       rdx,rdi
       call      qword ptr [7FFB0F38F870]; Microsoft.Extensions.Caching.Memory.MemoryCacheEntryExtensions.SetAbsoluteExpiration(Microsoft.Extensions.Caching.Memory.MemoryCacheEntryOptions, System.TimeSpan)
       mov       r9,rax
       mov       rdx,r14
       mov       r8d,r15d
       mov       rcx,rbp
       call      qword ptr [7FFB0F38F828]; Microsoft.Extensions.Caching.Memory.CacheExtensions.Set[[System.Boolean, System.Private.CoreLib]](Microsoft.Extensions.Caching.Memory.IMemoryCache, System.Object, Boolean, Microsoft.Extensions.Caching.Memory.MemoryCacheEntryOptions)
       mov       eax,esi
M00_L38:
       mov       [rsp+38],al
       mov       rcx,[rbx+18]
       lea       rdx,[rsp+38]
       cmp       [rcx],ecx
       call      qword ptr [7FFB0F38FE58]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L39:
       xor       ecx,ecx
       mov       eax,ecx
       jmp       near ptr M00_L22
M00_L40:
       test      r13,r13
       jne       near ptr M00_L56
       jmp       near ptr M00_L66
M00_L41:
       mov       r8,offset MT_System.Boolean
       cmp       [rdi],r8
       jne       near ptr M00_L34
       movzx     eax,byte ptr [rdi+8]
       jmp       short M00_L38
M00_L42:
       mov       rax,offset MT_System.RuntimeType
       cmp       [rcx],rax
       jne       near ptr M00_L79
       call      qword ptr [7FFB0ECCDAB8]; System.RuntimeType.GetBaseType()
M00_L43:
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M00_L35
       jmp       near ptr M00_L36
M00_L44:
       mov       rdx,rdi
       mov       rcx,1A8B3C30690
       call      qword ptr [7FFB0ECC7858]; System.String.Concat(System.String, System.String)
       mov       r14,rax
       jmp       near ptr M00_L09
M00_L45:
       mov       rcx,rsi
       mov       rdx,1A8B3C30690
       call      qword ptr [7FFB0ECC7858]; System.String.Concat(System.String, System.String)
       mov       r14,rax
       jmp       near ptr M00_L09
M00_L46:
       call      qword ptr [7FFB0F457468]
       int       3
M00_L47:
       call      qword ptr [7FFB0F164030]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L48
       call      qword ptr [7FFB0F45CFC0]
       mov       rbx,rax
M00_L48:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,1A8B3C29C08
       call      qword ptr [7FFB0F45C198]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L49:
       call      qword ptr [7FFB0F456D90]
       test      eax,eax
       jne       short M00_L51
       jmp       near ptr M00_L10
M00_L50:
       call      qword ptr [7FFB0F456D90]
       test      eax,eax
       je        near ptr M00_L11
M00_L51:
       mov       rcx,r14
       mov       edx,3
       call      qword ptr [7FFB0F456DA8]
       mov       rdi,rax
       jmp       near ptr M00_L12
M00_L52:
       call      qword ptr [7FFB0F38F540]
       int       3
M00_L53:
       mov       [rsp+28],rbp
       mov       [rsp+30],r15d
       lea       rdx,[rsp+28]
       mov       rcx,r12
       mov       r11,7FFB0EC10B58
       call      qword ptr [r11]
       jmp       near ptr M00_L14
M00_L54:
       test      r8,r8
       jne       near ptr M00_L16
M00_L55:
       mov       r13,[r13+18]
       mov       eax,[rsp+54]
       jmp       near ptr M00_L15
M00_L56:
       cmp       eax,[r13+20]
       jne       near ptr M00_L64
       mov       r8,[r13+8]
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer+OrdinalComparer
       cmp       [r12],rcx
       je        short M00_L57
       mov       [rsp+28],rbp
       mov       [rsp+30],r15d
       lea       rdx,[rsp+28]
       mov       rcx,r12
       mov       r11,7FFB0EC10B60
       call      qword ptr [r11]
       jmp       short M00_L65
M00_L57:
       test      r15d,r15d
       jne       short M00_L58
       test      r8,r8
       je        short M00_L64
M00_L58:
       test      r8,r8
       je        short M00_L59
       lea       rdx,[r8+0C]
       mov       r10d,[r8+8]
       jmp       short M00_L60
M00_L59:
       xor       edx,edx
       xor       r10d,r10d
M00_L60:
       cmp       r15d,r10d
       je        short M00_L61
       xor       edx,edx
       mov       eax,edx
       jmp       short M00_L63
M00_L61:
       mov       r8d,r10d
       add       r8,r8
       cmp       r8,0A
       je        short M00_L62
       mov       rcx,rbp
       call      qword ptr [7FFB0ECCFB70]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M00_L63
M00_L62:
       mov       r8,rbp
       mov       rcx,[r8]
       mov       r8,[r8+2]
       mov       r11,[rdx]
       xor       rcx,r11
       xor       r8,[rdx+2]
       or        r8,rcx
       sete      dl
       movzx     edx,dl
       mov       eax,edx
M00_L63:
       jmp       short M00_L65
M00_L64:
       mov       r13,[r13+18]
       mov       eax,[rsp+54]
       jmp       near ptr M00_L40
M00_L65:
       test      eax,eax
       je        short M00_L64
       jmp       near ptr M00_L23
M00_L66:
       xor       ebp,ebp
       jmp       near ptr M00_L24
M00_L67:
       lea       rdx,[rsp+40]
       mov       r11,7FFB0EC10B68
       call      qword ptr [r11]
       lea       rcx,[rsp+40]
       call      qword ptr [7FFB0F38F4B0]
       mov       r15,rax
       jmp       near ptr M00_L25
M00_L68:
       cmp       qword ptr [rbp+50],0
       je        near ptr M00_L29
       jmp       near ptr M00_L26
M00_L69:
       mov       rcx,rbp
       mov       edx,3
       call      qword ptr [7FFB0F38FCA8]
       mov       r13d,1
       jmp       near ptr M00_L28
M00_L70:
       mov       rdx,[rbp+58]
       mov       rcx,r15
       call      qword ptr [7FFB0F38F768]; System.DateTime.op_Subtraction(System.DateTime, System.DateTime)
       mov       rcx,rax
       mov       rdx,[rbp+50]
       call      qword ptr [7FFB0F38FDE0]
       test      eax,eax
       jne       short M00_L69
       jmp       near ptr M00_L27
M00_L71:
       mov       rcx,[rbp+10]
       mov       rdx,rbp
       cmp       [rcx],ecx
       call      qword ptr [7FFB0F38FD98]
       test      eax,eax
       je        near ptr M00_L30
M00_L72:
       cmp       byte ptr [rbp+45],2
       jne       short M00_L76
       jmp       near ptr M00_L30
M00_L73:
       mov       rcx,rbp
       cmp       [rcx],ecx
       call      qword ptr [7FFB0F38F6D8]
       jmp       near ptr M00_L31
M00_L74:
       mov       rcx,rsi
       mov       rdx,r15
       call      qword ptr [7FFB0F38F798]
       jmp       near ptr M00_L32
M00_L75:
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFB0F45D0B0]
       inc       qword ptr [rax+10]
       jmp       near ptr M00_L33
M00_L76:
       mov       r8,[rsi+10]
       mov       rcx,rdi
       mov       rdx,rbp
       call      qword ptr [7FFB0F38F738]
M00_L77:
       mov       rdx,[rsi+10]
       mov       rdi,[rdx+28]
       mov       rdx,[rsi+48]
       mov       rcx,r15
       call      qword ptr [7FFB0F38F768]; System.DateTime.op_Subtraction(System.DateTime, System.DateTime)
       cmp       rdi,rax
       jge       short M00_L78
       mov       rcx,rsi
       mov       rdx,r15
       call      qword ptr [7FFB0F38F798]
M00_L78:
       cmp       qword ptr [rsi+20],0
       je        near ptr M00_L34
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFB0F45D0B0]
       inc       qword ptr [rax+18]
       jmp       near ptr M00_L34
M00_L79:
       mov       rax,[rcx]
       mov       rax,[rax+98]
       call      qword ptr [rax+20]
       jmp       near ptr M00_L43
M00_L80:
       xor       ecx,ecx
       call      qword ptr [7FFB0EF4E148]; System.String.IsNullOrEmpty(System.String)
       test      eax,eax
       jne       short M00_L81
       xor       r14d,r14d
       jmp       near ptr M00_L37
M00_L81:
       call      qword ptr [7FFB0F164030]
       mov       rbx,rax
       mov       rcx,1A8B3C20008
       call      qword ptr [7FFB0EF4E148]; System.String.IsNullOrEmpty(System.String)
       mov       rcx,1A8B3C20008
       test      eax,eax
       cmove     rbx,rcx
       mov       ecx,11E7
       mov       rdx,7FFB0F015D88
       call      qword ptr [7FFB0EF47738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB0F164060]
       int       3
M00_L82:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 2283
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
       call      00007FFB6E8C1870
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
       mov       rax,7FFB0EE26D90
       mov       [rbp-78],rax
       lea       rax,[M01_L03]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFB6E852C30
       call      rax
M01_L03:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFB6EC1F778],0
       je        short M01_L04
       call      qword ptr [7FFB6EC0D608]; CORINFO_HELP_STOP_FOR_GC
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
       call      00007FFB6E8D04E0
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
       call      qword ptr [7FFB0F45D0E0]; System.RuntimeTypeHandle.GetGCHandle(System.Runtime.InteropServices.GCHandleType)
       mov       rdx,rax
       lea       rcx,[rbx+10]
       xor       eax,eax
       lock cmpxchg [rcx],rdx
       test      rax,rax
       je        near ptr M01_L00
       lea       rcx,[rbp-40]
       call      qword ptr [7FFB0F45C1B0]
       jmp       near ptr M01_L00
M01_L09:
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M01_L10:
       mov       [rbp+10],rbx
       mov       rcx,rbx
       call      qword ptr [7FFB0ECC7C90]; System.RuntimeTypeHandle.<GetModule>g__GetModuleWorker|48_0(System.RuntimeType)
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
; System.Type.GetRootElementType()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       vzeroupper
       mov       rbx,rcx
       mov       rsi,offset MT_System.RuntimeType
M02_L00:
       cmp       [rbx],rsi
       jne       short M02_L07
       mov       [rsp+20],rbx
       mov       rcx,[rbx+18]
       mov       rax,7FFB6E8C06C0
       call      rax
       movzx     ebx,al
       mov       rdi,[rsp+20]
       cmp       dword ptr [7FFB6EC1F778],0
       jne       short M02_L05
M02_L01:
       cmp       ebx,1D
       ja        short M02_L02
       mov       ecx,1FEF7FFF
       bt        ecx,ebx
       jae       short M02_L06
M02_L02:
       cmp       ebx,10
       sete      bpl
       movzx     ebp,bpl
M02_L03:
       test      ebp,ebp
       jne       short M02_L04
       mov       rax,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L04:
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+68]
       call      qword ptr [rax+8]
       mov       rdi,rax
       mov       rbx,rdi
       jmp       short M02_L00
M02_L05:
       call      CORINFO_HELP_POLL_GC
       jmp       short M02_L01
M02_L06:
       mov       ebp,1
       jmp       short M02_L03
M02_L07:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+68]
       call      qword ptr [rax]
       mov       ebp,eax
       mov       rdi,rbx
       jmp       short M02_L03
; Total bytes of code 163
```
```assembly
; System.RuntimeType+RuntimeTypeCache.ConstructName(System.String ByRef, System.TypeNameFormatFlags)
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rdx
       mov       rcx,[rcx+8]
       mov       [rsp+20],rcx
       lea       rcx,[rsp+20]
       mov       edx,r8d
       call      qword ptr [7FFB0EE64A98]; System.RuntimeTypeHandle.ConstructName(System.TypeNameFormatFlags)
       mov       rsi,rax
       mov       rcx,rbx
       mov       rdx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 63
```
```assembly
; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M04_L10
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M04_L10
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       jbe       short M04_L04
       cmp       r8,40
       ja        near ptr M04_L07
M04_L00:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        short M04_L03
M04_L01:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
M04_L02:
       vzeroupper
       ret
M04_L03:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M04_L01
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M04_L01
M04_L04:
       test      r8b,18
       je        short M04_L05
       mov       rdx,[rdx]
       mov       [rcx],rdx
       mov       rcx,[rax-8]
       mov       [r10-8],rcx
       jmp       short M04_L02
M04_L05:
       test      r8b,4
       je        short M04_L06
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
       jmp       short M04_L02
M04_L06:
       test      r8,r8
       je        short M04_L02
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M04_L02
       movsx     rcx,word ptr [rax-2]
       mov       [r10-2],cx
       jmp       short M04_L02
M04_L07:
       cmp       r8,800
       ja        short M04_L11
       cmp       r8,100
       jb        short M04_L08
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
M04_L08:
       mov       r9,r8
       shr       r9,6
M04_L09:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M04_L09
       and       r8,3F
       cmp       r8,10
       ja        near ptr M04_L00
       jmp       near ptr M04_L01
M04_L10:
       cmp       rcx,rdx
       jne       short M04_L11
       cmp       [rdx],dl
       jmp       near ptr M04_L02
M04_L11:
       cmp       [rcx],cl
       cmp       [rdx],dl
       vzeroupper
       jmp       qword ptr [7FFB0ECC66E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 323
```
```assembly
; System.String.GetNonRandomizedHashCode(System.ReadOnlySpan`1<Char>)
       push      rax
       xor       eax,eax
       mov       [rsp],rax
M05_L00:
       mov       eax,15051505
       mov       edx,15051505
       mov       r8d,[rcx+8]
       mov       rcx,[rcx]
       mov       [rsp],rcx
M05_L01:
       cmp       r8d,3
       ja        short M05_L03
       mov       r8d,r8d
       lea       r10,[7FFB0F4D66A0]
       mov       r10d,[r10+r8*4]
       lea       r9,[M05_L00]
       add       r10,r9
       jmp       r10
       mov       r8d,eax
       rol       r8d,5
       add       r8d,eax
       mov       eax,r8d
       xor       eax,[rcx]
       mov       r8d,edx
       rol       r8d,5
       add       r8d,edx
       movzx     edx,word ptr [rcx+4]
       xor       edx,r8d
M05_L02:
       xor       ecx,ecx
       mov       [rsp],rcx
       imul      ecx,edx,5D588B65
       add       eax,ecx
       add       rsp,8
       ret
M05_L03:
       add       r8d,0FFFFFFFC
       mov       r10d,eax
       rol       r10d,5
       add       eax,r10d
       xor       eax,[rcx]
       mov       r10d,edx
       rol       r10d,5
       add       edx,r10d
       xor       edx,[rcx+4]
       add       rcx,8
       cmp       r8d,4
       jge       short M05_L03
       jmp       short M05_L01
       mov       r8d,edx
       rol       r8d,5
       add       r8d,edx
       mov       edx,r8d
       xor       edx,[rcx]
       jmp       short M05_L02
       mov       r8d,edx
       rol       r8d,5
       add       r8d,edx
       movzx     edx,word ptr [rcx]
       xor       edx,r8d
       jmp       short M05_L02
; Total bytes of code 188
```
```assembly
; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       r8,8
       jb        short M06_L04
       cmp       rcx,rdx
       je        short M06_L02
       cmp       r8,20
       jb        near ptr M06_L09
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFE0
       je        short M06_L01
       vmovups   ymm0,[rcx]
       vpcmpeqb  ymm0,ymm0,[rdx]
       vpmovmskb r10d,ymm0
       cmp       r10d,0FFFFFFFF
       jne       near ptr M06_L13
M06_L00:
       add       rax,20
       cmp       r8,rax
       ja        short M06_L03
M06_L01:
       vmovups   ymm0,[rcx+r8]
       vpcmpeqb  ymm0,ymm0,[rdx+r8]
       vpmovmskb ecx,ymm0
       cmp       ecx,0FFFFFFFF
       jne       near ptr M06_L13
M06_L02:
       mov       eax,1
       vzeroupper
       ret
M06_L03:
       vmovups   ymm0,[rcx+rax]
       vpcmpeqb  ymm0,ymm0,[rdx+rax]
       vpmovmskb r10d,ymm0
       cmp       r10d,0FFFFFFFF
       jne       near ptr M06_L13
       jmp       short M06_L00
M06_L04:
       cmp       r8,4
       jae       short M06_L07
       xor       eax,eax
       mov       r10,r8
       and       r10,2
       je        short M06_L05
       movzx     eax,word ptr [rcx]
       movzx     r9d,word ptr [rdx]
       sub       eax,r9d
M06_L05:
       test      r8b,1
       je        short M06_L06
       movzx     r8d,byte ptr [rcx+r10]
       movzx     ecx,byte ptr [rdx+r10]
       sub       r8d,ecx
       or        eax,r8d
M06_L06:
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       short M06_L08
M06_L07:
       lea       rax,[r8-4]
       mov       r8d,[rcx]
       sub       r8d,[rdx]
       mov       ecx,[rcx+rax]
       sub       ecx,[rdx+rax]
       or        ecx,r8d
       sete      al
       movzx     eax,al
M06_L08:
       vzeroupper
       ret
M06_L09:
       cmp       r8,10
       jb        short M06_L12
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFF0
       je        short M06_L11
M06_L10:
       vmovups   xmm0,[rcx+rax]
       vpcmpeqb  xmm0,xmm0,[rdx+rax]
       vpmovmskb r10d,xmm0
       cmp       r10d,0FFFF
       jne       short M06_L13
       add       rax,10
       cmp       r8,rax
       ja        short M06_L10
M06_L11:
       vmovups   xmm0,[rcx+r8]
       vpcmpeqb  xmm0,xmm0,[rdx+r8]
       vpmovmskb eax,xmm0
       cmp       eax,0FFFF
       jne       short M06_L13
       jmp       near ptr M06_L02
M06_L12:
       lea       rax,[r8-8]
       mov       r8,[rcx]
       sub       r8,[rdx]
       mov       rcx,[rcx+rax]
       sub       rcx,[rdx+rax]
       or        rcx,r8
       sete      al
       movzx     eax,al
       jmp       short M06_L08
M06_L13:
       xor       eax,eax
       vzeroupper
       ret
; Total bytes of code 317
```
```assembly
; System.DateTime.get_UtcNow()
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+40]
       lea       rcx,[rbp-18]
       mov       rax,7FFC7BE75380
       call      rax
       mov       rbx,[rbp-18]
       mov       rax,1681EC01A90
       mov       rsi,[rax]
       sub       rbx,[rsi+8]
       cmp       dword ptr [7FFB6EC1F778],0
       jne       short M07_L01
M07_L00:
       mov       eax,0B2D05E00
       cmp       rbx,rax
       jae       short M07_L02
       mov       rax,rbx
       add       rax,[rsi+10]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M07_L01:
       call      CORINFO_HELP_POLL_GC
       jmp       short M07_L00
M07_L02:
       call      qword ptr [7FFB0F2560B8]; System.DateTime.UpdateLeapSecondCacheAndReturnUtcNow()
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 105
```
```assembly
; System.TimeSpan.FromMinutes(Int64)
       sub       rsp,28
       mov       rax,394427B08
       cmp       rcx,rax
       jg        short M08_L00
       mov       rax,0FFFFFFFC6BBD84F8
       cmp       rcx,rax
       jl        short M08_L00
       imul      rax,rcx,23C34600
       add       rsp,28
       ret
M08_L00:
       call      qword ptr [7FFB6E72E3C0]
       int       3
; Total bytes of code 53
```
```assembly
; System.String.IsNullOrEmpty(System.String)
       test      rcx,rcx
       je        short M09_L00
       cmp       dword ptr [rcx+8],0
       sete      al
       movzx     eax,al
       ret
M09_L00:
       mov       eax,1
       ret
; Total bytes of code 22
```
```assembly
; System.String.Trim()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,[rbx+8]
       test      esi,esi
       je        short M10_L01
       movzx     ecx,word ptr [rbx+0C]
       cmp       ecx,100
       jge       short M10_L02
       mov       rax,7FFB6DAA6918
       test      byte ptr [rax+rcx],80
       jne       short M10_L04
M10_L00:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jge       short M10_L03
       mov       rax,7FFB6DAA6918
       test      byte ptr [rax+rcx],80
       jne       short M10_L04
M10_L01:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M10_L02:
       call      qword ptr [7FFB0F456D90]
       test      eax,eax
       jne       short M10_L04
       jmp       short M10_L00
M10_L03:
       call      qword ptr [7FFB0F456D90]
       test      eax,eax
       je        short M10_L01
M10_L04:
       mov       rcx,rbx
       mov       edx,3
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFB0F456DA8]
; Total bytes of code 129
```
```assembly
; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Boolean, System.Private.CoreLib]](Boolean, Boolean, System.String, System.String)
; 		var isValid = input is not null;
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		if (isValid is false && defaultValue is not null)
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			input = defaultValue;
; 			^^^^^^^^^^^^^^^^^^^^^
; 		else if (isValid is false)
; 		     ^^^^^^^^^^^^^^^^^^^^^
; 			ExceptionThrower.ThrowArgumentNullException(CreateParamExceptionMessage(errorMessage, paramName, Resources.ErrorObjectCannotBeNull));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return input!;
; 		^^^^^^^^^^^^^^
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rbp-18],xmm4
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],ecx
       mov       [rbp+18],edx
       mov       [rbp+20],r8
       mov       [rbp+28],r9
       mov       rcx,offset MT_System.Boolean
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-10],rax
       mov       rax,[rbp-10]
       mov       ecx,[rbp+10]
       mov       [rax+8],cl
       cmp       qword ptr [rbp-10],0
       setne     al
       movzx     eax,al
       mov       [rbp-4],eax
       cmp       dword ptr [rbp-4],0
       jne       short M11_L00
       movzx     eax,byte ptr [rbp+18]
       mov       [rbp+10],al
       jmp       short M11_L01
M11_L00:
       cmp       dword ptr [rbp-4],0
       jne       short M11_L01
       call      qword ptr [7FFB0F2DE280]
       mov       [rbp-18],rax
       mov       r8,[rbp-18]
       mov       rdx,[rbp+28]
       mov       rcx,[rbp+20]
       call      qword ptr [7FFB0F2DE298]
       mov       rcx,rax
       call      qword ptr [7FFB0F2DE2B0]
M11_L01:
       movzx     eax,byte ptr [rbp+10]
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 150
```
```assembly
; Microsoft.Extensions.Caching.Memory.MemoryCacheEntryOptions..ctor()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       dword ptr [rax+18],1
       mov       rcx,[rbp+10]
       call      qword ptr [7FFB0EF45680]; System.Object..ctor()
       nop
       add       rsp,20
       pop       rbp
       ret
; Total bytes of code 42
```
```assembly
; Microsoft.Extensions.Caching.Memory.MemoryCacheEntryExtensions.SetAbsoluteExpiration(Microsoft.Extensions.Caching.Memory.MemoryCacheEntryOptions, System.TimeSpan)
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rbp-10],xmm0
       lea       rcx,[rbp-10]
       mov       rdx,[rbp+18]
       call      qword ptr [7FFB0F38F888]; System.Nullable`1[[System.TimeSpan, System.Private.CoreLib]]..ctor(System.TimeSpan)
       vmovups   xmm0,[rbp-10]
       vmovups   [rbp-20],xmm0
       lea       rdx,[rbp-20]
       mov       rcx,[rbp+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFB0F38F8A0]; Microsoft.Extensions.Caching.Memory.MemoryCacheEntryOptions.set_AbsoluteExpirationRelativeToNow(System.Nullable`1<System.TimeSpan>)
       mov       rax,[rbp+10]
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 77
```
```assembly
; Microsoft.Extensions.Caching.Memory.CacheExtensions.Set[[System.Boolean, System.Private.CoreLib]](Microsoft.Extensions.Caching.Memory.IMemoryCache, System.Object, Boolean, Microsoft.Extensions.Caching.Memory.MemoryCacheEntryOptions)
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rbp-18],xmm4
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8d
       mov       [rbp+28],r9
       mov       rcx,[rbp+10]
       mov       rdx,[rbp+18]
       mov       r11,7FFB0EC108E8
       call      qword ptr [r11]
       mov       [rbp-8],rax
       cmp       qword ptr [rbp+28],0
       je        short M14_L00
       mov       rcx,[rbp-8]
       mov       rdx,[rbp+28]
       call      qword ptr [7FFB0F38F900]; Microsoft.Extensions.Caching.Memory.CacheEntryExtensions.SetOptions(Microsoft.Extensions.Caching.Memory.ICacheEntry, Microsoft.Extensions.Caching.Memory.MemoryCacheEntryOptions)
M14_L00:
       mov       rcx,offset MT_System.Boolean
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-18],rax
       mov       rax,[rbp-18]
       mov       ecx,[rbp+20]
       mov       [rax+8],cl
       mov       rdx,[rbp-18]
       mov       rcx,[rbp-8]
       mov       r11,7FFB0EC108F0
       call      qword ptr [r11]
       movzx     eax,byte ptr [rbp+20]
       mov       [rbp-0C],eax
       call      M14_L01
       nop
       mov       eax,[rbp-0C]
       add       rsp,40
       pop       rbp
       ret
M14_L01:
       sub       rsp,28
       cmp       qword ptr [rbp-8],0
       je        short M14_L02
       mov       rcx,[rbp-8]
       mov       r11,7FFB0EC108F8
       call      qword ptr [r11]
M14_L02:
       nop
       add       rsp,28
       ret
; Total bytes of code 193
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```
```assembly
; System.RuntimeType.GetBaseType()
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+18]
       test      cl,2
       jne       near ptr M16_L04
       mov       ecx,[rcx]
       and       ecx,0F0000
       cmp       ecx,0C0000
       sete      cl
       movzx     ecx,cl
M16_L00:
       test      ecx,ecx
       jne       short M16_L03
       mov       rcx,rbx
       call      00007FFB6E8C2C30
       test      eax,eax
       jne       short M16_L05
       mov       rcx,7FFB0F4B99D4
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbx+18]
       test      cl,2
       jne       short M16_L02
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M16_L02
       mov       rax,[rcx+20]
       add       rax,10
       mov       rax,[rax]
       test      rax,rax
       je        near ptr M16_L14
M16_L01:
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M16_L02:
       xor       eax,eax
       jmp       short M16_L01
M16_L03:
       mov       rcx,7FFB0F4B9588
       call      CORINFO_HELP_COUNTPROFILE32
       xor       eax,eax
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M16_L04:
       xor       ecx,ecx
       jmp       short M16_L00
M16_L05:
       mov       rcx,rbx
       mov       rdx,7FFB0F4B9590
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rsi,[rax+70]
       call      qword ptr [rsi+10]
       mov       rdi,rax
       mov       rbp,1A8B3C219B8
       mov       r14,rbp
       xor       r15d,r15d
       cmp       [rdi+8],r15d
       jle       near ptr M16_L11
M16_L06:
       mov       rdx,[rdi+r15*8+10]
       mov       rcx,offset MT_System.RuntimeType
       call      qword ptr [7FFB0ECC6328]; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       r13,rax
       mov       rcx,r13
       cmp       [rcx],ecx
       call      qword ptr [7FFB0ECCD398]; System.RuntimeType.get_IsActualInterface()
       test      eax,eax
       jne       short M16_L08
       mov       rcx,r13
       mov       rdx,7FFB0F4B9698
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rcx,r13
       mov       rax,[r13]
       mov       rax,[rax+58]
       call      qword ptr [rax+30]
       test      eax,eax
       je        short M16_L07
       mov       rcx,r13
       mov       rdx,7FFB0F4B97A0
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rcx,r13
       mov       rax,[r13]
       mov       rax,[rax+70]
       call      qword ptr [rax+8]
       test      al,4
       jne       short M16_L10
       test      al,8
       je        short M16_L09
       mov       rcx,7FFB0F4B98A8
       call      CORINFO_HELP_COUNTPROFILE32
M16_L07:
       mov       rcx,7FFB0F4B98AC
       call      CORINFO_HELP_COUNTPROFILE32
       mov       r14,r13
M16_L08:
       mov       rcx,7FFB0F4B98B0
       call      CORINFO_HELP_COUNTPROFILE32
       inc       r15d
       cmp       [rdi+8],r15d
       jg        near ptr M16_L06
       jmp       short M16_L11
M16_L09:
       mov       rcx,7FFB0F4B99CC
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M16_L08
M16_L10:
       mov       rcx,7FFB0F4B99D0
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M16_L07
M16_L11:
       cmp       r14,rbp
       jne       short M16_L12
       mov       rcx,rbx
       mov       rdx,7FFB0F4B98B8
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rcx,rbx
       call      qword ptr [rsi+8]
       test      al,8
       je        short M16_L13
       mov       rcx,7FFB0F4B99C0
       call      CORINFO_HELP_COUNTPROFILE32
       mov       r14,1A8B3C24B90
M16_L12:
       mov       rcx,7FFB0F4B99C4
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,r14
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M16_L13:
       mov       rcx,7FFB0F4B99C8
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M16_L12
M16_L14:
       call      qword ptr [7FFB0ECC5C80]; System.RuntimeTypeHandle.GetRuntimeTypeFromHandleSlow(IntPtr)
       jmp       near ptr M16_L01
; Total bytes of code 565
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
       je        near ptr M17_L00
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M17_L00
       test      rbx,rbx
       je        near ptr M17_L03
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        near ptr M17_L03
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M17_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFB6E908D20
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFB0ECC5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFB0ECC5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M17_L00:
       test      rbx,rbx
       je        short M17_L01
       mov       ebp,[rbx+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M17_L02
M17_L01:
       mov       rax,1A8B3C20008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M17_L02:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M17_L03:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M17_L04:
       call      qword ptr [7FFB0F457468]
       int       3
; Total bytes of code 235
```
```assembly
; System.DateTime.op_Subtraction(System.DateTime, System.DateTime)
       mov       rax,3FFFFFFFFFFFFFFF
       and       rax,rcx
       mov       rcx,3FFFFFFFFFFFFFFF
       and       rcx,rdx
       sub       rax,rcx
       ret
; Total bytes of code 30
```

## .NET 10.0.0 (10.0.0, 10.0.25.52411), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark.HasMethod()
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,50
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+20],ymm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       rbx,rcx
       mov       rsi,2847E0C0690
       mov       rcx,243E74D1160
       mov       rdi,[rcx]
       test      rdi,rdi
       jne       short M00_L00
       mov       rcx,2847E0C0668
       call      qword ptr [7FFB0ECD7C48]; System.RuntimeType.InitializeCache()
       mov       rbp,rax
       jmp       short M00_L01
M00_L00:
       mov       rbp,rdi
M00_L01:
       cmp       [rbp],bpl
       lea       rdi,[rbp+40]
       mov       r14,[rdi]
       test      r14,r14
       je        near ptr M00_L16
M00_L02:
       mov       rdi,r14
       mov       rbp,[rdi+20]
       test      rbp,rbp
       je        near ptr M00_L25
       add       rsi,0C
       mov       eax,15051505
       mov       edx,15051505
       mov       ecx,8
M00_L03:
       add       ecx,0FFFFFFFC
       mov       r8d,eax
       rol       r8d,5
       add       eax,r8d
       xor       eax,[rsi]
       mov       r8d,edx
       rol       r8d,5
       add       edx,r8d
       xor       edx,[rsi+4]
       add       rsi,8
       cmp       ecx,2
       jg        short M00_L03
       test      ecx,ecx
       jg        near ptr M00_L17
M00_L04:
       imul      edx,5D588B65
       add       edx,eax
       mov       eax,edx
       not       edx
       test      eax,eax
       cmovl     eax,edx
       mov       rsi,[rbp+8]
       mov       r14d,[rsi+8]
       cdq
       idiv      r14d
       mov       r15d,edx
       cmp       r15d,r14d
       jae       near ptr M00_L39
       mov       ecx,r15d
       mov       r13,[rsi+rcx*8+10]
       test      r13,r13
       je        near ptr M00_L25
M00_L05:
       mov       rcx,2847E0C0690
       cmp       r13,rcx
       jne       near ptr M00_L19
M00_L06:
       mov       rcx,[rbp+10]
       cmp       r15d,[rcx+8]
       jae       near ptr M00_L39
       mov       edx,r15d
       mov       rsi,[rcx+rdx*8+10]
M00_L07:
       test      rsi,rsi
       je        near ptr M00_L26
M00_L08:
       mov       edi,[rsi+8]
       mov       edx,edi
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       [rsp+28],rcx
       mov       [rsp+30],ecx
       mov       [rsp+34],edx
       mov       ebp,10
       inc       edi
M00_L09:
       dec       edi
       je        short M00_L12
       mov       r14,[rsi+rbp]
       mov       edx,[r14+58]
       mov       ecx,edx
       and       ecx,16
       cmp       ecx,edx
       jne       short M00_L11
       cmp       dword ptr [rsp+30],0
       jne       near ptr M00_L27
       mov       [rsp+28],r14
M00_L10:
       mov       ecx,[rsp+30]
       inc       ecx
       mov       [rsp+30],ecx
M00_L11:
       add       rbp,8
       jmp       short M00_L09
M00_L12:
       vmovdqu   xmm0,xmmword ptr [rsp+20]
       vmovdqu   xmmword ptr [rsp+38],xmm0
       mov       rcx,[rsp+30]
       mov       [rsp+48],rcx
       cmp       dword ptr [rsp+48],0
       je        near ptr M00_L31
       cmp       qword ptr [rsp+38],0
       je        short M00_L15
       mov       rcx,[rsp+38]
       cmp       dword ptr [rcx+8],0
       jbe       near ptr M00_L39
       mov       rcx,[rsp+38]
       mov       rax,[rcx+10]
M00_L13:
       mov       rsi,rax
       cmp       dword ptr [rsp+48],1
       jne       near ptr M00_L32
M00_L14:
       test      rax,rax
       setne     al
       movzx     eax,al
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L15:
       mov       rax,[rsp+40]
       jmp       short M00_L13
M00_L16:
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache+MemberInfoCache<System.Reflection.RuntimeMethodInfo>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       lea       rcx,[r15+10]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       rdx,r15
       xor       r8d,r8d
       call      00007FFB6E8BFBA0
       mov       r14,rax
       test      r14,r14
       cmove     r14,r15
       jmp       near ptr M00_L02
M00_L17:
       mov       ecx,edx
       rol       ecx,5
       add       ecx,edx
       mov       edx,ecx
       xor       edx,[rsi]
       jmp       near ptr M00_L04
M00_L18:
       cmp       r15d,r14d
       jae       near ptr M00_L39
       mov       ecx,r15d
       mov       r13,[rsi+rcx*8+10]
       test      r13,r13
       je        short M00_L25
       jmp       near ptr M00_L05
M00_L19:
       cmp       dword ptr [r13+8],8
       je        short M00_L21
M00_L20:
       inc       r15d
       mov       r14d,[rsi+8]
       cmp       r14d,r15d
       jg        short M00_L18
       jmp       short M00_L24
M00_L21:
       lea       rcx,[r13+0C]
       mov       rdx,2847E0C069C
       mov       r8d,[r13+8]
       add       r8d,r8d
       cmp       r8,0A
       jne       short M00_L22
       mov       rax,[rcx]
       mov       rcx,[rcx+2]
       mov       r8,[rdx]
       xor       r8,rax
       xor       rcx,[rdx+2]
       or        rcx,r8
       sete      al
       movzx     eax,al
       jmp       short M00_L23
M00_L22:
       call      qword ptr [7FFB0ECDFB70]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
M00_L23:
       test      eax,eax
       je        short M00_L20
       jmp       near ptr M00_L06
M00_L24:
       sub       r15d,r14d
       jmp       short M00_L18
M00_L25:
       xor       esi,esi
       jmp       near ptr M00_L07
M00_L26:
       mov       rcx,rdi
       mov       rdx,2847E0C0690
       mov       r8d,1
       xor       r9d,r9d
       call      qword ptr [7FFB0ECDD2C0]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
       mov       rsi,rax
       jmp       near ptr M00_L08
M00_L27:
       cmp       dword ptr [rsp+30],1
       jne       short M00_L29
       cmp       dword ptr [rsp+34],2
       jge       short M00_L28
       mov       dword ptr [rsp+34],4
M00_L28:
       movsxd    rdx,dword ptr [rsp+34]
       mov       rcx,offset MT_System.Reflection.MethodInfo[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       [rsp+20],rax
       mov       rcx,[rsp+20]
       mov       r8,[rsp+28]
       xor       edx,edx
       call      qword ptr [7FFB0ECD57B8]; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       short M00_L30
M00_L29:
       mov       edx,[rsp+34]
       cmp       edx,[rsp+30]
       jne       short M00_L30
       mov       r15d,[rsp+34]
       add       r15d,r15d
       lea       rdx,[rsp+20]
       mov       r8d,r15d
       mov       rcx,7FFB0EE57750
       call      qword ptr [7FFB0ECDD4E8]; System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
       mov       [rsp+34],r15d
M00_L30:
       movsxd    rdx,dword ptr [rsp+30]
       mov       rcx,[rsp+20]
       mov       r8,r14
       call      qword ptr [7FFB0ECD57B8]; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       near ptr M00_L10
M00_L31:
       xor       eax,eax
       jmp       near ptr M00_L14
M00_L32:
       mov       edi,1
       jmp       short M00_L36
M00_L33:
       cmp       qword ptr [rsp+38],0
       jne       short M00_L34
       mov       rcx,[rsp+40]
       jmp       short M00_L35
M00_L34:
       mov       rcx,[rsp+38]
       cmp       edi,[rcx+8]
       jae       short M00_L39
       mov       rcx,[rsp+38]
       mov       rcx,[rcx+rdi*8+10]
M00_L35:
       mov       rdx,rsi
       call      qword ptr [7FFB0F447078]
       test      eax,eax
       je        short M00_L37
       inc       edi
M00_L36:
       cmp       edi,[rsp+48]
       jl        short M00_L33
       jmp       short M00_L38
M00_L37:
       mov       rcx,rsi
       call      qword ptr [7FFB0F447090]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M00_L38:
       lea       rcx,[rsp+38]
       mov       rdx,offset MT_System.RuntimeType+ListBuilder<System.Reflection.MethodInfo>
       call      qword ptr [7FFB0ECDD560]; System.RuntimeType+ListBuilder`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       mov       rcx,rax
       mov       edx,[rsp+48]
       call      qword ptr [7FFB0F4470A8]
       mov       rdx,rax
       mov       rcx,offset MT_System.Reflection.MethodInfo
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       jmp       near ptr M00_L14
M00_L39:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1027
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
       call      00007FFB6E8C1870
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
       mov       rax,7FFB0EE36D90
       mov       [rbp-78],rax
       lea       rax,[M01_L03]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFB6E852C30
       call      rax
M01_L03:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFB6EC1F778],0
       je        short M01_L04
       call      qword ptr [7FFB6EC0D608]; CORINFO_HELP_STOP_FOR_GC
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
       call      00007FFB6E8D04E0
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
       call      qword ptr [7FFB0F44D938]; System.RuntimeTypeHandle.GetGCHandle(System.Runtime.InteropServices.GCHandleType)
       mov       rdx,rax
       lea       rcx,[rbx+10]
       xor       eax,eax
       lock cmpxchg [rcx],rdx
       test      rax,rax
       je        near ptr M01_L00
       lea       rcx,[rbp-40]
       call      qword ptr [7FFB0F447378]
       jmp       near ptr M01_L00
M01_L09:
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M01_L10:
       mov       [rbp+10],rbx
       mov       rcx,rbx
       call      qword ptr [7FFB0ECD7C90]; System.RuntimeTypeHandle.<GetModule>g__GetModuleWorker|48_0(System.RuntimeType)
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
; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       r8,8
       jb        short M02_L01
       cmp       rcx,rdx
       je        near ptr M02_L11
       cmp       r8,20
       jae       near ptr M02_L05
       cmp       r8,10
       jae       near ptr M02_L08
       add       r8,0FFFFFFFFFFFFFFF8
       mov       rax,[rcx]
       sub       rax,[rdx]
       mov       rcx,[rcx+r8]
       sub       rcx,[rdx+r8]
       or        rax,rcx
       sete      al
       movzx     eax,al
M02_L00:
       vzeroupper
       ret
M02_L01:
       cmp       r8,4
       jae       short M02_L04
       xor       eax,eax
       mov       r10,r8
       and       r10,2
       je        short M02_L02
       movzx     eax,word ptr [rcx]
       movzx     r9d,word ptr [rdx]
       sub       eax,r9d
M02_L02:
       test      r8b,1
       je        short M02_L03
       movzx     r8d,byte ptr [rcx+r10]
       movzx     ecx,byte ptr [rdx+r10]
       sub       r8d,ecx
       or        eax,r8d
M02_L03:
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       short M02_L00
M02_L04:
       lea       rax,[r8-4]
       mov       r8d,[rcx]
       sub       r8d,[rdx]
       mov       ecx,[rcx+rax]
       sub       ecx,[rdx+rax]
       or        ecx,r8d
       sete      al
       movzx     eax,al
       jmp       short M02_L00
M02_L05:
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFE0
       je        short M02_L07
M02_L06:
       vmovups   ymm0,[rcx+rax]
       vpcmpeqb  ymm0,ymm0,[rdx+rax]
       vpmovmskb r10d,ymm0
       cmp       r10d,0FFFFFFFF
       jne       short M02_L12
       add       rax,20
       cmp       r8,rax
       ja        short M02_L06
M02_L07:
       vmovups   ymm0,[rcx+r8]
       vpcmpeqb  ymm0,ymm0,[rdx+r8]
       vpmovmskb eax,ymm0
       cmp       eax,0FFFFFFFF
       jne       short M02_L12
       jmp       short M02_L11
M02_L08:
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFF0
       je        short M02_L10
M02_L09:
       vmovups   xmm0,[rcx+rax]
       vpcmpeqb  xmm0,xmm0,[rdx+rax]
       vpmovmskb r10d,xmm0
       cmp       r10d,0FFFF
       jne       short M02_L12
       add       rax,10
       cmp       r8,rax
       ja        short M02_L09
M02_L10:
       vmovups   xmm0,[rcx+r8]
       vpcmpeqb  xmm0,xmm0,[rdx+r8]
       vpmovmskb ecx,xmm0
       cmp       ecx,0FFFF
       jne       short M02_L12
M02_L11:
       mov       eax,1
       vzeroupper
       ret
M02_L12:
       xor       eax,eax
       vzeroupper
       ret
; Total bytes of code 291
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
       mov       rax,71EA9450A311
       mov       [rbp],rax
       mov       rsi,rcx
       mov       rbx,rdx
       mov       edi,r8d
       mov       r14d,r9d
       test      rbx,rbx
       je        near ptr M03_L06
       cmp       dword ptr [rbx+8],0
       je        near ptr M03_L06
       cmp       r14d,1
       jne       short M03_L00
       movzx     r15d,word ptr [rbx+0C]
       cmp       r15d,2E
       jne       short M03_L01
       mov       rcx,7FFB0F5F5F00
       call      CORINFO_HELP_COUNTPROFILE32
M03_L00:
       mov       rcx,243E9000220
       mov       r15,[rcx]
       mov       rcx,r15
       mov       rdx,7FFB0F5F5F08
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rcx,r15
       mov       rdx,rbx
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+18]
       mov       r15d,eax
       cmp       r15d,400
       jbe       short M03_L02
       movsxd    rdx,r15d
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       r13,[rax+10]
       mov       r15d,[rax+8]
       jmp       short M03_L04
M03_L01:
       cmp       r15d,2A
       jne       near ptr M03_L05
       mov       rcx,7FFB0F5F5EFC
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M03_L00
M03_L02:
       mov       rcx,7FFB0F5F6010
       call      CORINFO_HELP_COUNTPROFILE32
       mov       edx,r15d
       mov       r13,rdx
       test      r13,r13
       je        short M03_L04
       mov       rcx,r13
       add       rcx,0F
       and       rcx,0FFFFFFFFFFFFFFF0
       add       rsp,30
       neg       rcx
       add       rcx,rsp
       jb        short M03_L03
       xor       ecx,ecx
M03_L03:
       test      [rsp],esp
       sub       rsp,1000
       cmp       rsp,rcx
       jae       short M03_L03
       mov       rsp,rcx
       test      [rsp],esp
       sub       rsp,30
       lea       r13,[rsp+30]
M03_L04:
       mov       rcx,7FFB0F5F6014
       call      CORINFO_HELP_COUNTPROFILE32
       mov       [rbp+8],r13
       mov       [rbp+10],r15d
       mov       [rsp+20],r14d
       lea       r8,[rbp+8]
       mov       rdx,rbx
       mov       rcx,rsi
       mov       r9d,edi
       call      qword ptr [7FFB0ECDD320]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].GetListByName(System.String, System.Span`1<Byte>, MemberListType, CacheType)
       mov       [rbp+18],rax
       jmp       short M03_L07
M03_L05:
       mov       rcx,7FFB0F5F5EF8
       call      CORINFO_HELP_COUNTPROFILE32
M03_L06:
       xor       r8d,r8d
       mov       [rbp+8],r8
       mov       [rbp+10],r8d
       mov       [rsp+20],r14d
       lea       r8,[rbp+8]
       mov       rcx,rsi
       mov       r9d,edi
       mov       rdx,2847E0B0008
       call      qword ptr [7FFB0ECDD320]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].GetListByName(System.String, System.Span`1<Byte>, MemberListType, CacheType)
       mov       [rbp+18],rax
M03_L07:
       mov       rcx,7FFB0F5F6018
       call      CORINFO_HELP_COUNTPROFILE32
       lea       rdx,[rbp+18]
       mov       rcx,rsi
       mov       r8,rbx
       mov       r9d,edi
       call      qword ptr [7FFB0ECDD578]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Insert(System.__Canon[] ByRef, System.String, MemberListType)
       mov       rax,[rbp+18]
       mov       r8,71EA9450A311
       cmp       [rbp],r8
       je        short M03_L08
       call      CORINFO_HELP_FAIL_FAST
M03_L08:
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
; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       sub       rsp,28
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M04_L01
       lea       rax,[rcx+rdx*8+10]
       mov       rdx,[rcx]
       mov       rdx,[rdx+30]
       test      r8,r8
       je        short M04_L02
       cmp       rdx,[r8]
       jne       short M04_L03
M04_L00:
       mov       rcx,rax
       mov       rdx,r8
       add       rsp,28
       jmp       near ptr 00007FFB6E907B10
M04_L01:
       call      qword ptr [7FFB0F39FFD8]
       int       3
M04_L02:
       xor       ecx,ecx
       mov       [rax],rcx
       add       rsp,28
       ret
M04_L03:
       mov       r10,offset MT_System.Object[]
       cmp       [rcx],r10
       je        short M04_L00
       mov       rcx,rax
       add       rsp,28
       jmp       qword ptr [7FFB0ECDD8F0]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
; Total bytes of code 94
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
       jl        short M05_L03
       mov       rdi,[rsi]
       test      rdi,rdi
       je        short M05_L04
       mov       ebp,[rdi+8]
       cmp       ebp,ebx
       je        short M05_L02
       call      qword ptr [7FFB6E71DD60]
       mov       rcx,rax
       mov       edx,ebx
       call      qword ptr [7FFB6E718070]; CORINFO_HELP_NEWARR_1_DIRECT
       mov       r14,rax
       lea       rcx,[r14+10]
       lea       rdx,[rdi+10]
       cmp       ebx,ebp
       cmovg     ebx,ebp
       mov       r8d,ebx
       shl       r8,3
       cmp       r8,4000
       jbe       short M05_L00
       call      qword ptr [7FFB6E7296D8]
       jmp       short M05_L01
M05_L00:
       call      qword ptr [7FFB6E7296A0]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       jne       short M05_L05
M05_L01:
       mov       rcx,rsi
       mov       rdx,r14
       call      qword ptr [7FFB6E717FD8]; CORINFO_HELP_CHECKED_ASSIGN_REF
M05_L02:
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M05_L03:
       mov       ecx,45
       mov       edx,0D
       call      qword ptr [7FFB6E72E440]
       int       3
M05_L04:
       call      qword ptr [7FFB6E71DD60]
       mov       rcx,rax
       mov       edx,ebx
       call      qword ptr [7FFB6E718070]; CORINFO_HELP_NEWARR_1_DIRECT
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFB6E717FD8]; CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       short M05_L02
M05_L05:
       call      qword ptr [7FFB6E718028]; CORINFO_HELP_POLL_GC
       jmp       short M05_L01
; Total bytes of code 195
```
```assembly
; System.RuntimeType+ListBuilder`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rdx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       ecx,[rbx+10]
       test      ecx,ecx
       je        near ptr M06_L05
       cmp       ecx,1
       jne       short M06_L02
       mov       rcx,7FFB0F5F75EC
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],40
       jle       short M06_L01
       mov       rcx,[rcx+40]
       test      rcx,rcx
       je        short M06_L01
M06_L00:
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
       pop       rsi
       ret
M06_L01:
       mov       rcx,rsi
       mov       rdx,7FFB0F4A4F48
       call      qword ptr [7FFB0ECDC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M06_L00
M06_L02:
       mov       rcx,7FFB0F5F75F0
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],38
       jle       short M06_L04
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M06_L04
M06_L03:
       mov       r8d,[rbx+10]
       mov       rdx,rbx
       call      qword ptr [7FFB0ECDD4E8]; System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
       mov       eax,[rbx+10]
       mov       [rbx+14],eax
       mov       rax,[rbx]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M06_L04:
       mov       rcx,rsi
       mov       rdx,7FFB0F4A4F28
       call      qword ptr [7FFB0ECDC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M06_L03
M06_L05:
       mov       rcx,7FFB0F5F75E8
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],48
       jle       short M06_L08
       mov       rcx,[rcx+48]
       test      rcx,rcx
       je        short M06_L08
M06_L06:
       mov       rdx,[rcx+18]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M06_L09
M06_L07:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rax]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M06_L08:
       mov       rcx,rsi
       mov       rdx,7FFB0F5D9B10
       call      qword ptr [7FFB0ECDC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M06_L06
M06_L09:
       mov       rdx,7FFB0F4A23B0
       call      qword ptr [7FFB0EF57AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       short M06_L07
; Total bytes of code 337
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rdx,rdx
       je        short M07_L00
       cmp       [rdx],rcx
       jne       short M07_L01
M07_L00:
       mov       rax,rdx
       ret
M07_L01:
       mov       rax,[rdx]
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M07_L00
M07_L02:
       test      rax,rax
       je        short M07_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M07_L00
       test      rax,rax
       je        short M07_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M07_L00
       test      rax,rax
       je        short M07_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M07_L00
       test      rax,rax
       je        short M07_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M07_L00
       jmp       short M07_L02
M07_L03:
       xor       edx,edx
       jmp       short M07_L00
; Total bytes of code 88
```

## .NET 10.0.0 (10.0.0, 10.0.25.52411), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark.HasParameterlessConstructor()
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       rcx,25C38C001E0
       mov       rcx,[rcx]
       mov       [rsp+20],rcx
       xor       ecx,ecx
       mov       [rsp+28],rcx
       mov       rcx,29CCDD6F350
       mov       edx,34
       xor       r8d,r8d
       mov       r9d,3
       mov       rax,[7FFB0EBFA1F8]
       call      qword ptr [rax+38]
       test      rax,rax
       setne     al
       movzx     eax,al
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,30
       pop       rbx
       ret
; Total bytes of code 89
```

## .NET 10.0.0 (10.0.0, 10.0.25.52411), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark.HasProperty()
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,40
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rsp+28],xmm4
       xor       eax,eax
       mov       [rsp+38],rax
       mov       rbx,rcx
       mov       rsi,31D75F70668
       mov       rcx,2DCE09C1190
       mov       rdi,[rcx]
       test      rdi,rdi
       jne       short M00_L00
       mov       rcx,31D75F60020
       call      qword ptr [7FFB0ECE7C48]; System.RuntimeType.InitializeCache()
       mov       rbp,rax
       jmp       short M00_L01
M00_L00:
       mov       rbp,rdi
M00_L01:
       cmp       [rbp],bpl
       lea       rdi,[rbp+68]
       mov       r14,[rdi]
       test      r14,r14
       je        near ptr M00_L14
M00_L02:
       mov       rdi,r14
       mov       rbp,[rdi+20]
       test      rbp,rbp
       je        near ptr M00_L22
       mov       rcx,rsi
       call      qword ptr [7FFB0ECE66D0]; System.String.GetNonRandomizedHashCode()
       mov       edx,eax
       not       eax
       test      edx,edx
       cmovl     edx,eax
       mov       rsi,[rbp+8]
       mov       r14d,[rsi+8]
       mov       eax,edx
       cdq
       idiv      r14d
       mov       r15d,edx
       cmp       r15d,r14d
       jae       near ptr M00_L29
       mov       ecx,r15d
       mov       r13,[rsi+rcx*8+10]
       test      r13,r13
       je        near ptr M00_L22
M00_L03:
       mov       rcx,31D75F70668
       cmp       r13,rcx
       jne       near ptr M00_L16
M00_L04:
       mov       rcx,[rbp+10]
       cmp       r15d,[rcx+8]
       jae       near ptr M00_L29
       mov       edx,r15d
       mov       rsi,[rcx+rdx*8+10]
M00_L05:
       test      rsi,rsi
       jne       short M00_L06
       mov       rcx,rdi
       mov       rdx,31D75F70668
       mov       r8d,1
       mov       r9d,3
       call      qword ptr [7FFB0ECED2C0]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
       mov       rsi,rax
M00_L06:
       mov       edi,[rsi+8]
       mov       edx,edi
       xor       ecx,ecx
       mov       [rsp+28],rcx
       mov       [rsp+30],rcx
       mov       [rsp+38],ecx
       mov       [rsp+3C],edx
       test      edi,edi
       jle       short M00_L10
       add       rsi,10
M00_L07:
       mov       rbp,[rsi]
       mov       edx,[rbp+58]
       mov       ecx,edx
       and       ecx,1E
       cmp       ecx,edx
       jne       short M00_L09
       cmp       dword ptr [rsp+38],0
       jne       near ptr M00_L23
       mov       [rsp+30],rbp
M00_L08:
       mov       ecx,[rsp+38]
       inc       ecx
       mov       [rsp+38],ecx
M00_L09:
       add       rsi,8
       dec       edi
       jne       short M00_L07
M00_L10:
       mov       rcx,[rsp+28]
       mov       rax,[rsp+30]
       mov       edx,[rsp+38]
       test      edx,edx
       je        near ptr M00_L27
       test      rcx,rcx
       je        short M00_L13
       cmp       dword ptr [rcx+8],0
       jbe       near ptr M00_L29
       mov       rcx,[rcx+10]
M00_L11:
       cmp       edx,1
       jne       near ptr M00_L28
M00_L12:
       test      rcx,rcx
       setne     al
       movzx     eax,al
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L13:
       mov       rcx,rax
       jmp       short M00_L11
M00_L14:
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache+MemberInfoCache<System.Reflection.RuntimePropertyInfo>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       lea       rcx,[r15+10]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       rdx,r15
       xor       r8d,r8d
       call      00007FFB6E8BFBA0
       mov       r14,rax
       test      r14,r14
       cmove     r14,r15
       jmp       near ptr M00_L02
M00_L15:
       cmp       r15d,r14d
       jae       near ptr M00_L29
       mov       ecx,r15d
       mov       r13,[rsi+rcx*8+10]
       test      r13,r13
       je        short M00_L22
       jmp       near ptr M00_L03
M00_L16:
       cmp       dword ptr [r13+8],6
       je        short M00_L18
M00_L17:
       inc       r15d
       mov       r14d,[rsi+8]
       cmp       r14d,r15d
       jg        short M00_L15
       jmp       short M00_L21
M00_L18:
       lea       rcx,[r13+0C]
       mov       rdx,31D75F70674
       mov       r8d,[r13+8]
       add       r8d,r8d
       cmp       r8,0A
       jne       short M00_L19
       mov       rax,[rcx]
       mov       rcx,[rcx+2]
       mov       r8,[rdx]
       xor       r8,rax
       xor       rcx,[rdx+2]
       or        rcx,r8
       sete      al
       movzx     eax,al
       jmp       short M00_L20
M00_L19:
       call      qword ptr [7FFB0ECEFB70]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
M00_L20:
       test      eax,eax
       je        short M00_L17
       jmp       near ptr M00_L04
M00_L21:
       sub       r15d,r14d
       jmp       short M00_L15
M00_L22:
       xor       esi,esi
       jmp       near ptr M00_L05
M00_L23:
       cmp       dword ptr [rsp+38],1
       jne       short M00_L25
       cmp       dword ptr [rsp+3C],2
       jge       short M00_L24
       mov       dword ptr [rsp+3C],4
M00_L24:
       movsxd    rdx,dword ptr [rsp+3C]
       mov       rcx,offset MT_System.Reflection.PropertyInfo[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       [rsp+28],rax
       mov       rcx,[rsp+28]
       mov       r8,[rsp+30]
       xor       edx,edx
       call      qword ptr [7FFB0ECE57B8]; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       short M00_L26
M00_L25:
       mov       edx,[rsp+3C]
       cmp       edx,[rsp+38]
       jne       short M00_L26
       mov       r14d,[rsp+3C]
       add       r14d,r14d
       lea       rdx,[rsp+28]
       mov       r8d,r14d
       mov       rcx,7FFB0EE73430
       call      qword ptr [7FFB0ECED4E8]; System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
       mov       [rsp+3C],r14d
M00_L26:
       movsxd    rdx,dword ptr [rsp+38]
       mov       rcx,[rsp+28]
       mov       r8,rbp
       call      qword ptr [7FFB0ECE57B8]; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       near ptr M00_L08
M00_L27:
       xor       ecx,ecx
       jmp       near ptr M00_L12
M00_L28:
       call      qword ptr [7FFB0F456EE0]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M00_L29:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 786
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
       call      00007FFB6E8C1870
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
       mov       rax,7FFB0EE46D90
       mov       [rbp-78],rax
       lea       rax,[M01_L03]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFB6E852C30
       call      rax
M01_L03:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFB6EC1F778],0
       je        short M01_L04
       call      qword ptr [7FFB6EC0D608]; CORINFO_HELP_STOP_FOR_GC
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
       call      00007FFB6E8D04E0
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
       call      qword ptr [7FFB0F45CED0]; System.RuntimeTypeHandle.GetGCHandle(System.Runtime.InteropServices.GCHandleType)
       mov       rdx,rax
       lea       rcx,[rbx+10]
       xor       eax,eax
       lock cmpxchg [rcx],rdx
       test      rax,rax
       je        near ptr M01_L00
       lea       rcx,[rbp-40]
       call      qword ptr [7FFB0F457258]
       jmp       near ptr M01_L00
M01_L09:
       call      qword ptr [7FFB0ECE6328]; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M01_L10:
       mov       [rbp+10],rbx
       mov       rcx,rbx
       call      qword ptr [7FFB0ECE7C90]; System.RuntimeTypeHandle.<GetModule>g__GetModuleWorker|48_0(System.RuntimeType)
       mov       r14,rax
       mov       rbx,[rbp+10]
       jmp       near ptr M01_L02
M01_L11:
       mov       rdx,rax
       call      qword ptr [7FFB0ECE6328]; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
; Total bytes of code 568
```
```assembly
; System.String.GetNonRandomizedHashCode()
       push      rax
       xor       eax,eax
       mov       [rsp],rax
       cmp       [rcx],cl
       lea       rax,[rcx+0C]
       mov       [rsp],rax
       mov       eax,15051505
       mov       edx,15051505
       mov       r8,[rsp]
       mov       ecx,[rcx+8]
       cmp       ecx,2
       jle       short M02_L01
M02_L00:
       add       ecx,0FFFFFFFC
       mov       r10d,eax
       rol       r10d,5
       add       eax,r10d
       xor       eax,[r8]
       mov       r10d,edx
       rol       r10d,5
       add       edx,r10d
       xor       edx,[r8+4]
       add       r8,8
       cmp       ecx,2
       jg        short M02_L00
M02_L01:
       test      ecx,ecx
       jle       short M02_L02
       mov       ecx,edx
       rol       ecx,5
       add       ecx,edx
       mov       edx,ecx
       xor       edx,[r8]
M02_L02:
       imul      ecx,edx,5D588B65
       add       eax,ecx
       add       rsp,8
       ret
; Total bytes of code 107
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
       mov       rax,0EB6B699D6F3A
       mov       [rbp],rax
       mov       rsi,rcx
       mov       rbx,rdx
       mov       edi,r8d
       mov       r14d,r9d
       test      rbx,rbx
       je        near ptr M03_L06
       cmp       dword ptr [rbx+8],0
       je        near ptr M03_L06
       cmp       r14d,1
       jne       short M03_L00
       movzx     r15d,word ptr [rbx+0C]
       cmp       r15d,2E
       jne       short M03_L01
       mov       rcx,7FFB0F607A50
       call      CORINFO_HELP_COUNTPROFILE32
M03_L00:
       mov       rcx,2DCE0C00220
       mov       r15,[rcx]
       mov       rcx,r15
       mov       rdx,7FFB0F607A58
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rcx,r15
       mov       rdx,rbx
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+18]
       mov       r15d,eax
       cmp       r15d,400
       jbe       short M03_L02
       movsxd    rdx,r15d
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       r13,[rax+10]
       mov       r15d,[rax+8]
       jmp       short M03_L04
M03_L01:
       cmp       r15d,2A
       jne       near ptr M03_L05
       mov       rcx,7FFB0F607A4C
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M03_L00
M03_L02:
       mov       rcx,7FFB0F607B60
       call      CORINFO_HELP_COUNTPROFILE32
       mov       edx,r15d
       mov       r13,rdx
       test      r13,r13
       je        short M03_L04
       mov       rcx,r13
       add       rcx,0F
       and       rcx,0FFFFFFFFFFFFFFF0
       add       rsp,30
       neg       rcx
       add       rcx,rsp
       jb        short M03_L03
       xor       ecx,ecx
M03_L03:
       test      [rsp],esp
       sub       rsp,1000
       cmp       rsp,rcx
       jae       short M03_L03
       mov       rsp,rcx
       test      [rsp],esp
       sub       rsp,30
       lea       r13,[rsp+30]
M03_L04:
       mov       rcx,7FFB0F607B64
       call      CORINFO_HELP_COUNTPROFILE32
       mov       [rbp+8],r13
       mov       [rbp+10],r15d
       mov       [rsp+20],r14d
       lea       r8,[rbp+8]
       mov       rdx,rbx
       mov       rcx,rsi
       mov       r9d,edi
       call      qword ptr [7FFB0ECED320]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].GetListByName(System.String, System.Span`1<Byte>, MemberListType, CacheType)
       mov       [rbp+18],rax
       jmp       short M03_L07
M03_L05:
       mov       rcx,7FFB0F607A48
       call      CORINFO_HELP_COUNTPROFILE32
M03_L06:
       xor       r8d,r8d
       mov       [rbp+8],r8
       mov       [rbp+10],r8d
       mov       [rsp+20],r14d
       lea       r8,[rbp+8]
       mov       rcx,rsi
       mov       r9d,edi
       mov       rdx,31D75F60008
       call      qword ptr [7FFB0ECED320]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].GetListByName(System.String, System.Span`1<Byte>, MemberListType, CacheType)
       mov       [rbp+18],rax
M03_L07:
       mov       rcx,7FFB0F607B68
       call      CORINFO_HELP_COUNTPROFILE32
       lea       rdx,[rbp+18]
       mov       rcx,rsi
       mov       r8,rbx
       mov       r9d,edi
       call      qword ptr [7FFB0ECED578]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Insert(System.__Canon[] ByRef, System.String, MemberListType)
       mov       rax,[rbp+18]
       mov       r8,0EB6B699D6F3A
       cmp       [rbp],r8
       je        short M03_L08
       call      CORINFO_HELP_FAIL_FAST
M03_L08:
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
; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       r8,8
       jae       short M04_L01
       cmp       r8,4
       jb        near ptr M04_L05
       add       r8,0FFFFFFFFFFFFFFFC
       mov       eax,[rcx]
       sub       eax,[rdx]
       mov       ecx,[rcx+r8]
       sub       ecx,[rdx+r8]
       or        eax,ecx
       sete      al
       movzx     eax,al
M04_L00:
       vzeroupper
       ret
M04_L01:
       cmp       rcx,rdx
       je        short M04_L04
       cmp       r8,20
       jae       near ptr M04_L08
       cmp       r8,10
       jb        near ptr M04_L12
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFF0
       je        short M04_L03
       vmovups   xmm0,[rcx]
       vpcmpeqb  xmm0,xmm0,[rdx]
       vpmovmskb r10d,xmm0
       cmp       r10d,0FFFF
       jne       near ptr M04_L13
M04_L02:
       add       rax,10
       cmp       r8,rax
       ja        near ptr M04_L11
M04_L03:
       vmovups   xmm0,[rcx+r8]
       vpcmpeqb  xmm0,xmm0,[rdx+r8]
       vpmovmskb ecx,xmm0
       cmp       ecx,0FFFF
       jne       near ptr M04_L13
M04_L04:
       mov       eax,1
       vzeroupper
       ret
M04_L05:
       xor       eax,eax
       mov       r10,r8
       and       r10,2
       je        short M04_L06
       movzx     eax,word ptr [rcx]
       movzx     r9d,word ptr [rdx]
       sub       eax,r9d
M04_L06:
       test      r8b,1
       je        short M04_L07
       movzx     ecx,byte ptr [rcx+r10]
       movzx     edx,byte ptr [rdx+r10]
       sub       ecx,edx
       or        eax,ecx
M04_L07:
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       near ptr M04_L00
M04_L08:
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFE0
       je        short M04_L10
M04_L09:
       vmovups   ymm0,[rcx+rax]
       vpcmpeqb  ymm0,ymm0,[rdx+rax]
       vpmovmskb r10d,ymm0
       cmp       r10d,0FFFFFFFF
       jne       short M04_L13
       add       rax,20
       cmp       r8,rax
       ja        short M04_L09
M04_L10:
       vmovups   ymm0,[rcx+r8]
       vpcmpeqb  ymm0,ymm0,[rdx+r8]
       vpmovmskb eax,ymm0
       cmp       eax,0FFFFFFFF
       jne       short M04_L13
       jmp       short M04_L04
M04_L11:
       vmovups   xmm0,[rcx+rax]
       vpcmpeqb  xmm0,xmm0,[rdx+rax]
       vpmovmskb r10d,xmm0
       cmp       r10d,0FFFF
       jne       short M04_L13
       jmp       near ptr M04_L02
M04_L12:
       lea       rax,[r8-8]
       mov       r8,[rcx]
       sub       r8,[rdx]
       mov       rcx,[rcx+rax]
       sub       rcx,[rdx+rax]
       or        rcx,r8
       sete      al
       movzx     eax,al
       jmp       near ptr M04_L00
M04_L13:
       xor       eax,eax
       vzeroupper
       ret
; Total bytes of code 332
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       sub       rsp,28
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M05_L01
       lea       rax,[rcx+rdx*8+10]
       mov       rdx,[rcx]
       mov       rdx,[rdx+30]
       test      r8,r8
       je        short M05_L02
       cmp       rdx,[r8]
       jne       short M05_L03
M05_L00:
       mov       rcx,rax
       mov       rdx,r8
       add       rsp,28
       jmp       near ptr 00007FFB6E907B10
M05_L01:
       call      qword ptr [7FFB0F454060]
       int       3
M05_L02:
       xor       ecx,ecx
       mov       [rax],rcx
       add       rsp,28
       ret
M05_L03:
       mov       r10,offset MT_System.Object[]
       cmp       [rcx],r10
       je        short M05_L00
       mov       rcx,rax
       add       rsp,28
       jmp       qword ptr [7FFB0ECED8F0]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
; Total bytes of code 94
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
       jl        short M06_L03
       mov       rdi,[rsi]
       test      rdi,rdi
       je        short M06_L04
       mov       ebp,[rdi+8]
       cmp       ebp,ebx
       je        short M06_L02
       call      qword ptr [7FFB6E71DD60]
       mov       rcx,rax
       mov       edx,ebx
       call      qword ptr [7FFB6E718070]; CORINFO_HELP_NEWARR_1_DIRECT
       mov       r14,rax
       lea       rcx,[r14+10]
       lea       rdx,[rdi+10]
       cmp       ebx,ebp
       cmovg     ebx,ebp
       mov       r8d,ebx
       shl       r8,3
       cmp       r8,4000
       jbe       short M06_L00
       call      qword ptr [7FFB6E7296D8]
       jmp       short M06_L01
M06_L00:
       call      qword ptr [7FFB6E7296A0]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       jne       short M06_L05
M06_L01:
       mov       rcx,rsi
       mov       rdx,r14
       call      qword ptr [7FFB6E717FD8]; CORINFO_HELP_CHECKED_ASSIGN_REF
M06_L02:
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M06_L03:
       mov       ecx,45
       mov       edx,0D
       call      qword ptr [7FFB6E72E440]
       int       3
M06_L04:
       call      qword ptr [7FFB6E71DD60]
       mov       rcx,rax
       mov       edx,ebx
       call      qword ptr [7FFB6E718070]; CORINFO_HELP_NEWARR_1_DIRECT
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFB6E717FD8]; CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       short M06_L02
M06_L05:
       call      qword ptr [7FFB6E718028]; CORINFO_HELP_POLL_GC
       jmp       short M06_L01
; Total bytes of code 195
```

## .NET 10.0.0 (10.0.0, 10.0.25.52411), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark.IsAssignableTo()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,2519FB319B8
       mov       rdx,2519FB30020
       call      qword ptr [7FFB0EC1A610]; System.RuntimeType.IsAssignableFrom(System.Type)
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 47
```
```assembly
; System.RuntimeType.IsAssignableFrom(System.Type)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M01_L12
       cmp       rbx,rsi
       je        near ptr M01_L10
       mov       rdi,[rbx]
       mov       rcx,offset MT_System.RuntimeType
       cmp       rdi,rcx
       jne       near ptr M01_L13
       mov       rbp,rbx
M01_L00:
       test      rbp,rbp
       je        near ptr M01_L08
       mov       rcx,offset MT_System.RuntimeType
       cmp       [rbp],rcx
       jne       near ptr M01_L08
       mov       rcx,[rbp+18]
       mov       rdx,rcx
       mov       r8,[rsi+18]
       mov       rax,r8
       cmp       rdx,rax
       je        near ptr M01_L14
       test      cl,2
       jne       short M01_L01
       test      r8b,2
       jne       near ptr M01_L15
M01_L01:
       mov       rcx,2110A800038
       mov       rcx,[rcx]
       mov       r8,rdx
       mov       r10,rax
       add       rcx,10
       rol       r8,20
       xor       r8,r10
       mov       r10,9E3779B97F4A7C15
       imul      r8,r10
       mov       r10d,[rcx]
       shrx      r8,r8,r10
       xor       r10d,r10d
M01_L02:
       lea       r9d,[r8+1]
       movsxd    r9,r9d
       lea       r9,[r9+r9*2]
       lea       r9,[rcx+r9*8]
       mov       r11d,[r9]
       mov       rbx,[r9+8]
       and       r11d,0FFFFFFFE
       cmp       rbx,rdx
       jne       short M01_L05
       mov       rdi,rax
       xor       rdi,[r9+10]
       cmp       rdi,1
       ja        short M01_L05
       cmp       r11d,[r9]
       jne       near ptr M01_L16
       mov       ecx,edi
M01_L03:
       test      ecx,ecx
       jne       short M01_L06
       xor       ebx,ebx
M01_L04:
       movzx     eax,bl
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L05:
       test      r11d,r11d
       je        near ptr M01_L16
       inc       r10d
       add       r8d,r10d
       and       r8d,[rcx+4]
       cmp       r10d,8
       jl        short M01_L02
       jmp       near ptr M01_L16
M01_L06:
       cmp       ecx,1
       jne       short M01_L07
       mov       ebx,1
       jmp       short M01_L04
M01_L07:
       mov       rcx,rdx
       mov       rdx,rax
       mov       r8d,1
       call      qword ptr [7FFB0ECDE820]; System.Runtime.CompilerServices.TypeHandle.CanCastToWorker(System.Runtime.CompilerServices.TypeHandle, System.Runtime.CompilerServices.TypeHandle, Boolean)
       mov       ebx,eax
       jmp       short M01_L04
M01_L08:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Reflection.Emit.TypeBuilder
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M01_L12
       mov       rcx,rbx
       mov       rdx,rsi
       mov       rax,[rdi+0B0]
       call      qword ptr [rax+18]
       test      eax,eax
       jne       short M01_L10
       mov       rcx,rsi
       call      qword ptr [7FFB0ECDD398]; System.RuntimeType.get_IsActualInterface()
       test      eax,eax
       jne       short M01_L11
       cmp       [rsi],sil
       mov       rcx,rsi
       call      00007FFB6E8C2C30
       test      eax,eax
       je        short M01_L12
       mov       rcx,rsi
       call      qword ptr [7FFB0EC1A400]
       mov       esi,[rax+8]
       test      esi,esi
       jle       short M01_L10
       lea       rdi,[rax+10]
M01_L09:
       mov       rcx,[rdi]
       mov       rdx,rbx
       mov       rax,[rcx]
       mov       rax,[rax+0B0]
       call      qword ptr [rax+20]
       test      eax,eax
       je        short M01_L12
       add       rdi,8
       dec       esi
       jne       short M01_L09
M01_L10:
       mov       eax,1
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L11:
       mov       rcx,rbx
       mov       rdx,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFB0F446D00]
M01_L12:
       xor       eax,eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L13:
       mov       rcx,rbx
       mov       rax,[rdi+58]
       call      qword ptr [rax]
       mov       rbp,rax
       jmp       near ptr M01_L00
M01_L14:
       mov       ecx,1
       jmp       near ptr M01_L03
M01_L15:
       xor       ecx,ecx
       jmp       near ptr M01_L03
M01_L16:
       mov       ecx,2
       jmp       near ptr M01_L03
; Total bytes of code 531
```

## .NET 10.0.0 (10.0.0, 10.0.25.52411), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark.IsClosedGeneric()
       mov       rax,1D069B90668
       mov       rdx,offset MT_System.Collections.Generic.List<System.Int32>
       test      dword ptr [rdx],80000000
       je        short M00_L00
       xor       r8d,r8d
       jmp       short M00_L01
M00_L00:
       test      byte ptr [rdx],30
       setne     r8b
       movzx     r8d,r8b
M00_L01:
       movzx     edx,r8b
       test      edx,edx
       je        short M00_L03
       mov       rdx,offset MT_System.Collections.Generic.List<System.Int32>
       mov       edx,[rdx]
       and       edx,80000030
       cmp       edx,30
       sete      dl
       movzx     edx,dl
       test      edx,edx
       sete      al
       movzx     eax,al
M00_L02:
       mov       rcx,[rcx+18]
       mov       [rcx+4C],al
       ret
M00_L03:
       xor       eax,eax
       jmp       short M00_L02
; Total bytes of code 99
```

## .NET 10.0.0 (10.0.0, 10.0.25.52411), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark.IsEnumerable()
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-24],eax
       mov       [rbp+10],rcx
       mov       rcx,29681BD1160
       mov       rbx,[rcx]
       test      rbx,rbx
       jne       short M00_L00
       mov       rcx,2D718A30668
       call      qword ptr [7FFB0ECE7C48]; System.RuntimeType.InitializeCache()
       mov       rsi,rax
       jmp       short M00_L01
M00_L00:
       mov       rsi,rbx
M00_L01:
       cmp       [rsi],sil
       lea       rbx,[rsi+58]
       mov       rcx,[rbx]
       test      rcx,rcx
       je        near ptr M00_L19
M00_L02:
       cmp       byte ptr [rcx+18],0
       je        near ptr M00_L20
       mov       rbx,[rcx+8]
M00_L03:
       test      rbx,rbx
       je        near ptr M00_L16
       lea       rsi,[rbx+10]
       mov       ebx,[rbx+8]
M00_L04:
       test      ebx,ebx
       jne       near ptr M00_L17
       mov       rdx,29683C00208
       mov       rdi,[rdx]
M00_L05:
       mov       rcx,29683C02110
       mov       rbx,[rcx]
       test      rbx,rbx
       je        near ptr M00_L23
M00_L06:
       mov       rcx,offset MT_System.Type[]
       cmp       [rdi],rcx
       je        near ptr M00_L11
       mov       rcx,offset MT_System.Collections.Generic.List<System.Type>
       cmp       [rdi],rcx
       je        short M00_L10
       mov       rcx,rdi
       mov       r11,7FFB0EC30AC0
       call      qword ptr [r11]
       mov       [rbp-30],rax
M00_L07:
       mov       rcx,[rbp-30]
       mov       r11,7FFB0EC30AC8
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L08
       mov       rcx,[rbp-30]
       mov       r11,7FFB0EC30AD0
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,[rbx+8]
       call      qword ptr [rbx+18]
       test      eax,eax
       je        short M00_L07
       mov       dword ptr [rbp-24],1
       call      M00_L29
       nop
       mov       esi,[rbp-24]
       jmp       short M00_L15
M00_L08:
       mov       rcx,[rbp-30]
       mov       r11,7FFB0EC30AD8
       call      qword ptr [r11]
M00_L09:
       xor       esi,esi
       jmp       short M00_L15
M00_L10:
       mov       eax,[rdi+10]
       mov       rsi,[rdi+8]
       cmp       [rsi+8],eax
       jb        near ptr M00_L24
       add       rsi,10
       jmp       short M00_L12
M00_L11:
       lea       rsi,[rdi+10]
       mov       eax,[rdi+8]
M00_L12:
       test      eax,eax
       jle       short M00_L09
       mov       rdx,offset DotNetTips.Spargine.Core.TypeHelper+<>c.<IsEnumerable>b__51_0(System.Type)
       cmp       [rbx+18],rdx
       jne       near ptr M00_L25
       xor       edx,edx
M00_L13:
       mov       rcx,[rsi+rdx]
       mov       r8,2D718A2C8D8
       cmp       rcx,r8
       je        short M00_L14
       add       rdx,8
       dec       eax
       jne       short M00_L13
       jmp       short M00_L09
M00_L14:
       mov       esi,1
M00_L15:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+18]
       mov       [rax+4C],sil
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M00_L16:
       xor       esi,esi
       xor       ebx,ebx
       jmp       near ptr M00_L04
M00_L17:
       mov       edx,ebx
       mov       rcx,offset MT_System.Type[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       lea       rcx,[rdi+10]
       mov       r8d,ebx
       shl       r8,3
       cmp       r8,4000
       ja        short M00_L22
       mov       rdx,rsi
       call      00007FFB6E8B5D60
       cmp       dword ptr [7FFB6EC1F778],0
       jne       short M00_L21
M00_L18:
       jmp       near ptr M00_L05
M00_L19:
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache+MemberInfoCache<System.RuntimeType>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbx
       mov       rdx,rdi
       xor       r8d,r8d
       call      00007FFB6E8BFBA0
       mov       rcx,rax
       test      rcx,rcx
       cmove     rcx,rdi
       jmp       near ptr M00_L02
M00_L20:
       xor       edx,edx
       xor       r8d,r8d
       mov       r9d,5
       call      qword ptr [7FFB0ECED2C0]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
       mov       rbx,rax
       jmp       near ptr M00_L03
M00_L21:
       call      CORINFO_HELP_POLL_GC
       jmp       short M00_L18
M00_L22:
       mov       rdx,rsi
       call      qword ptr [7FFB0F2FE010]
       jmp       short M00_L18
M00_L23:
       mov       rcx,offset MT_System.Func<System.Type, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,29683C020C0
       mov       rdx,[rdx]
       mov       rcx,rbx
       mov       r8,offset DotNetTips.Spargine.Core.TypeHelper+<>c.<IsEnumerable>b__51_0(System.Type)
       call      qword ptr [7FFB0ECE6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,29683C02110
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L06
M00_L24:
       call      qword ptr [7FFB0EF679A8]
       int       3
M00_L25:
       xor       edi,edi
       mov       r14d,eax
M00_L26:
       mov       rcx,[rsi+rdi]
       mov       rdx,offset DotNetTips.Spargine.Core.TypeHelper+<>c.<IsEnumerable>b__51_0(System.Type)
       cmp       [rbx+18],rdx
       je        short M00_L27
       mov       rdx,rcx
       mov       rcx,[rbx+8]
       call      qword ptr [rbx+18]
       test      eax,eax
       je        short M00_L28
       jmp       near ptr M00_L14
M00_L27:
       mov       rdx,2D718A2C8D8
       cmp       rcx,rdx
       je        near ptr M00_L14
M00_L28:
       add       rdi,8
       dec       r14d
       jne       short M00_L26
       jmp       near ptr M00_L09
M00_L29:
       sub       rsp,28
       cmp       qword ptr [rbp-30],0
       je        short M00_L30
       mov       rcx,[rbp-30]
       mov       r11,7FFB0EC30AD8
       call      qword ptr [r11]
M00_L30:
       nop
       add       rsp,28
       ret
; Total bytes of code 779
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
       call      00007FFB6E8C1870
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
       mov       rax,7FFB0EE46D90
       mov       [rbp-78],rax
       lea       rax,[M01_L03]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFB6E852C30
       call      rax
M01_L03:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFB6EC1F778],0
       je        short M01_L04
       call      qword ptr [7FFB6EC0D608]; CORINFO_HELP_STOP_FOR_GC
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
       call      00007FFB6E8D04E0
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
       call      qword ptr [7FFB0F45C5D0]; System.RuntimeTypeHandle.GetGCHandle(System.Runtime.InteropServices.GCHandleType)
       mov       rdx,rax
       lea       rcx,[rbx+10]
       xor       eax,eax
       lock cmpxchg [rcx],rdx
       test      rax,rax
       je        near ptr M01_L00
       lea       rcx,[rbp-40]
       call      qword ptr [7FFB0F4571B0]
       jmp       near ptr M01_L00
M01_L09:
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M01_L10:
       mov       [rbp+10],rbx
       mov       rcx,rbx
       call      qword ptr [7FFB0ECE7C90]; System.RuntimeTypeHandle.<GetModule>g__GetModuleWorker|48_0(System.RuntimeType)
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
; DotNetTips.Spargine.Core.TypeHelper+<>c.<IsEnumerable>b__51_0(System.Type)
; 		return type.GetInterfaces().Any(t => t == typeof(IEnumerable));
; 		                                     ^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rax,2D718A2C8D8
       cmp       rdx,rax
       sete      al
       movzx     eax,al
       ret
; Total bytes of code 20
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
       mov       rax,8476BA9D3BD4
       mov       [rbp],rax
       mov       rsi,rcx
       mov       rbx,rdx
       mov       edi,r8d
       mov       r14d,r9d
       test      rbx,rbx
       je        short M03_L00
       cmp       dword ptr [rbx+8],0
       jne       short M03_L03
M03_L00:
       xor       r8d,r8d
       mov       [rbp+8],r8
       mov       [rbp+10],r8d
       mov       [rsp+20],r14d
       lea       r8,[rbp+8]
       mov       rcx,rsi
       mov       r9d,edi
       mov       rdx,2D718A20008
       call      qword ptr [7FFB0ECED320]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].GetListByName(System.String, System.Span`1<Byte>, MemberListType, CacheType)
       mov       [rbp+18],rax
M03_L01:
       lea       rdx,[rbp+18]
       mov       rcx,rsi
       mov       r8,rbx
       mov       r9d,edi
       call      qword ptr [7FFB0ECED578]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Insert(System.__Canon[] ByRef, System.String, MemberListType)
       mov       rax,[rbp+18]
       mov       r8,8476BA9D3BD4
       cmp       [rbp],r8
       je        short M03_L02
       call      CORINFO_HELP_FAIL_FAST
M03_L02:
       nop
       lea       rsp,[rbp+20]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M03_L03:
       cmp       r14d,1
       jne       short M03_L04
       cmp       word ptr [rbx+0C],2E
       je        short M03_L04
       cmp       word ptr [rbx+0C],2A
       jne       short M03_L00
M03_L04:
       mov       rcx,29683C00220
       mov       rcx,[rcx]
       mov       rdx,rbx
       call      qword ptr [7FFB0EE74930]; Precode of System.Text.UTF8Encoding.GetByteCount(System.String)
       cmp       eax,400
       jbe       short M03_L05
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       r8,[rax+10]
       mov       eax,[rax+8]
       jmp       short M03_L07
M03_L05:
       mov       r8d,eax
       test      r8,r8
       je        short M03_L07
       mov       rdx,r8
       add       rdx,0F
       and       rdx,0FFFFFFFFFFFFFFF0
       add       rsp,30
       neg       rdx
       add       rdx,rsp
       jb        short M03_L06
       xor       edx,edx
M03_L06:
       test      [rsp],esp
       sub       rsp,1000
       cmp       rsp,rdx
       jae       short M03_L06
       mov       rsp,rdx
       test      [rsp],esp
       sub       rsp,30
       lea       r8,[rsp+30]
M03_L07:
       mov       [rbp+8],r8
       mov       [rbp+10],eax
       mov       [rsp+20],r14d
       lea       r8,[rbp+8]
       mov       rdx,rbx
       mov       rcx,rsi
       mov       r9d,edi
       call      qword ptr [7FFB0ECED320]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].GetListByName(System.String, System.Span`1<Byte>, MemberListType, CacheType)
       mov       [rbp+18],rax
       jmp       near ptr M03_L01
; Total bytes of code 348
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M04_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L00:
       call      qword ptr [7FFB0F456A60]
       int       3
; Total bytes of code 44
```

## .NET 10.0.0 (10.0.0, 10.0.25.52411), X64 RyuJIT x86-64-v3
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
       mov       r9,1EE18C00208
       mov       r8,[r9]
       mov       byte ptr [rsp+28],1
       mov       byte ptr [rsp+29],0
       mov       byte ptr [rsp+2A],1
       mov       word ptr [rsp+2C],2E
       lea       r9,[rsp+28]
       mov       [rsp+20],r9
       xor       r9d,r9d
       mov       rcx,rsi
       mov       rdx,22EADBBE190
       call      qword ptr [7FFB0F37EDA8]; DotNetTips.Spargine.Core.TypeHelper.ProcessGenericType(System.Text.StringBuilder, System.Type, System.Type[], Int32, DotNetTips.Spargine.Core.DisplayNameOptions)
       mov       rcx,rsi
       call      qword ptr [7FFB0EF10210]; System.Text.StringBuilder.ToString()
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
       call      qword ptr [7FFB0ECB7C48]; System.RuntimeType.InitializeCache()
       mov       r12,rax
M01_L02:
       cmp       qword ptr [r12+10],0
       je        near ptr M01_L42
M01_L03:
       mov       rcx,22EADBB1440
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
       call      qword ptr [7FFB0ECB7C48]; System.RuntimeType.InitializeCache()
       mov       r12,rax
M01_L08:
       cmp       qword ptr [r12+10],0
       je        near ptr M01_L46
M01_L09:
       mov       rcx,22EADBB1440
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
       call      qword ptr [7FFB0ECB7C48]; System.RuntimeType.InitializeCache()
M01_L12:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFB0F24C978]; System.RuntimeType+RuntimeTypeCache.GetNamespace()
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
       call      qword ptr [7FFB0ECB7C48]; System.RuntimeType.InitializeCache()
M01_L16:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFB0F24C978]; System.RuntimeType+RuntimeTypeCache.GetNamespace()
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
       call      qword ptr [7FFB0ECB5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFB0EE5F180]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M01_L19
M01_L22:
       mov       edx,2E
       call      qword ptr [7FFB0EE5F348]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M01_L20
M01_L23:
       mov       rcx,rbx
       call      qword ptr [7FFB0ECB7C48]; System.RuntimeType.InitializeCache()
M01_L24:
       mov       r10,[rax+18]
       test      r10,r10
       je        short M01_L26
M01_L25:
       lea       rcx,[r10+0C]
       mov       r8d,[r10+8]
       mov       edx,60
       call      qword ptr [7FFB0EE57738]; System.PackedSpanHelpers.IndexOf[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib],[System.PackedSpanHelpers+NopTransform, System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
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
       call      qword ptr [7FFB0EE54A80]; System.RuntimeType+RuntimeTypeCache.ConstructName(System.String ByRef, System.TypeNameFormatFlags)
       mov       r10,rax
       jmp       short M01_L25
M01_L27:
       mov       rcx,rbx
       call      qword ptr [7FFB0ECB7C48]; System.RuntimeType.InitializeCache()
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
       call      qword ptr [7FFB0ECB5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L30:
       add       r12d,r15d
       mov       [rbx+18],r12d
M01_L31:
       cmp       byte ptr [rbp+2],0
       je        short M01_L34
       mov       rcx,[rsp+90]
       mov       edx,[rcx+18]
       mov       rax,[rcx+8]
       cmp       [rax+8],edx
       jbe       near ptr M01_L37
       cmp       edx,[rax+8]
       jae       near ptr M01_L65
       mov       edx,edx
       mov       word ptr [rax+rdx*2+10],3C
       inc       dword ptr [rcx+18]
M01_L32:
       cmp       r14d,edi
       jl        near ptr M01_L62
M01_L33:
       mov       rcx,[rsp+90]
       mov       edx,[rcx+18]
       mov       rax,[rcx+8]
       cmp       [rax+8],edx
       jbe       short M01_L38
       cmp       edx,[rax+8]
       jae       near ptr M01_L65
       mov       edx,edx
       mov       word ptr [rax+rdx*2+10],3E
       inc       dword ptr [rcx+18]
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
       call      qword ptr [7FFB0EE54A80]; System.RuntimeType+RuntimeTypeCache.ConstructName(System.String ByRef, System.TypeNameFormatFlags)
       mov       rdx,rax
       jmp       near ptr M01_L29
M01_L36:
       mov       rcx,rbx
       mov       r8d,r12d
       call      qword ptr [7FFB0EE5F180]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M01_L31
M01_L37:
       mov       edx,3C
       call      qword ptr [7FFB0EE5F348]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M01_L32
M01_L38:
       mov       edx,3E
       call      qword ptr [7FFB0EE5F348]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M01_L34
M01_L39:
       call      qword ptr [7FFB0F2CE148]
       mov       ecx,26EB
       mov       rdx,7FFB0F005D88
       call      qword ptr [7FFB0EF37738]
       mov       rbx,rax
       mov       ecx,1B61
       mov       rdx,7FFB0F005D88
       call      qword ptr [7FFB0EF37738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB0ECB7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,110B
       mov       rdx,7FFB0F005D88
       call      qword ptr [7FFB0EF37738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB0ECB7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB0F42C0C0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB0F4271E0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M01_L40:
       call      qword ptr [7FFB0F2CE148]
       mov       ecx,213D
       mov       rdx,7FFB0F005D88
       call      qword ptr [7FFB0EF37738]
       mov       rbx,rax
       mov       ecx,1B61
       mov       rdx,7FFB0F005D88
       call      qword ptr [7FFB0EF37738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB0ECB7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,110B
       mov       rdx,7FFB0F005D88
       call      qword ptr [7FFB0EF37738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB0ECB7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB0F42C0C0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB0F4271E0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M01_L41:
       call      qword ptr [7FFB0F2CE148]
       mov       ecx,26FB
       mov       rdx,7FFB0F005D88
       call      qword ptr [7FFB0EF37738]
       mov       rbx,rax
       mov       ecx,1B61
       mov       rdx,7FFB0F005D88
       call      qword ptr [7FFB0EF37738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB0ECB7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,110B
       mov       rdx,7FFB0F005D88
       call      qword ptr [7FFB0EF37738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB0ECB7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB0F42C0C0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB0F4271E0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M01_L42:
       mov       rcx,[r12+8]
       call      qword ptr [7FFB0EE54528]; System.RuntimeTypeHandle.GetDeclaringType(System.RuntimeType)
       mov       rdx,rax
       mov       rcx,22EADBB1440
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
       call      qword ptr [7FFB0EE54528]; System.RuntimeTypeHandle.GetDeclaringType(System.RuntimeType)
       mov       rdx,rax
       mov       rcx,22EADBB1440
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
       call      qword ptr [7FFB0F37EDA8]
       mov       rcx,[rsp+90]
       movzx     edx,word ptr [rbp+4]
       cmp       [rcx],ecx
       call      qword ptr [7FFB0EE5F120]; System.Text.StringBuilder.Append(Char)
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
       call      qword ptr [7FFB0EE5F1C8]; System.Text.StringBuilder.Append(System.String)
       jmp       near ptr M01_L34
M01_L58:
       mov       rcx,rbx
       mov       rdx,[r15+40]
       call      qword ptr [rdx+30]
       mov       rdx,rax
       jmp       near ptr M01_L29
M01_L59:
       mov       ecx,3AD
       mov       rdx,7FFB0EBF4000
       call      qword ptr [7FFB0EF37738]
       mov       rcx,rax
       call      qword ptr [7FFB0F425848]
       int       3
M01_L60:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,0B8F
       mov       rdx,7FFB0EBF4000
       call      qword ptr [7FFB0EF37738]
       mov       rsi,rax
       call      qword ptr [7FFB0F425DA0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFB0F245F68]
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
       call      qword ptr [7FFB0F37EE68]
       mov       ecx,r14d
       add       ecx,1
       jo        short M01_L66
       cmp       ecx,edi
       je        short M01_L64
       mov       rcx,[rsp+90]
       mov       edx,2C
       cmp       [rcx],ecx
       call      qword ptr [7FFB0EE5F120]; System.Text.StringBuilder.Append(Char)
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
       call      qword ptr [7FFB0EE5F120]; System.Text.StringBuilder.Append(Char)
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
; Total bytes of code 2221
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
       call      00007FFB6E908D20
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
       call      qword ptr [7FFB0ECB5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,22EADBB0008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,19655
       mov       rdx,7FFB0EBF4000
       call      qword ptr [7FFB0EF37738]
       mov       rbx,rax
       call      qword ptr [7FFB0F425DA0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB0F245F68]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 201
```

