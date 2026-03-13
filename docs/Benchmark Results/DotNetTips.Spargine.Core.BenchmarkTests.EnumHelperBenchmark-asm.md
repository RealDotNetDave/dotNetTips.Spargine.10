## .NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.EnumHelperBenchmark.GetDescription()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,58
       lea       rbp,[rsp+90]
       xor       eax,eax
       mov       [rbp-40],rax
       mov       [rbp-48],rax
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Data.CountryName
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       dword ptr [rsi+8],6D
       mov       rcx,21ECA002108
       mov       rdi,[rcx]
       mov       rcx,21ECA0020E8
       mov       r14,[rcx]
       test      rdi,rdi
       je        near ptr M00_L08
M00_L00:
       mov       r15,[r14+8]
       mov       rcx,[r15+8]
       cmp       byte ptr [r14+19],0
       je        near ptr M00_L09
       mov       rcx,rsi
       mov       rax,[7FF8246693D0]
       call      qword ptr [rax+18]
       mov       r13d,eax
M00_L01:
       mov       r12,[r15+8]
       mov       rcx,[r15+10]
       mov       edx,r13d
       imul      rdx,[r15+28]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       mov       r8d,eax
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,eax
       jae       near ptr M00_L19
       mov       edx,edx
       mov       rax,[rcx+rdx*8+10]
       test      rax,rax
       je        near ptr M00_L18
       test      r12,r12
       je        near ptr M00_L06
       mov       rcx,offset MT_System.Collections.Generic.ObjectEqualityComparer<System.Enum>
       cmp       [r12],rcx
       jne       near ptr M00_L06
M00_L02:
       cmp       r13d,[rax+20]
       jne       near ptr M00_L10
       mov       [rbp-50],rax
       mov       r10,[rax+8]
       test      r10,r10
       je        near ptr M00_L12
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Data.CountryName
       cmp       [r10],rcx
       jne       near ptr M00_L11
       mov       rcx,r10
       mov       rdx,rsi
       call      qword ptr [7FF823E560A0]; System.Enum.Equals(System.Object)
M00_L03:
       test      eax,eax
       je        near ptr M00_L12
M00_L04:
       mov       rax,[rbp-50]
       mov       rdx,[rax+10]
       mov       [rbp-40],rdx
M00_L05:
       mov       rcx,[rbp-40]
       xor       edx,edx
       mov       [rbp-40],rdx
       mov       [rbp-48],rcx
       mov       rbx,[rbx+60]
       mov       rdx,[rbp-48]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
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
M00_L06:
       cmp       r13d,[rax+20]
       jne       near ptr M00_L15
       mov       [rbp-50],rax
       mov       r10,[rax+8]
       mov       rcx,offset MT_System.Collections.Generic.ObjectEqualityComparer<System.Enum>
       cmp       [r12],rcx
       jne       near ptr M00_L13
       test      r10,r10
       je        near ptr M00_L14
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Data.CountryName
       cmp       [r10],rcx
       jne       near ptr M00_L16
       mov       rcx,r10
       mov       rdx,rsi
       call      qword ptr [7FF823E560A0]; System.Enum.Equals(System.Object)
M00_L07:
       test      eax,eax
       je        near ptr M00_L17
       jmp       near ptr M00_L04
M00_L08:
       mov       rcx,offset MT_System.Func<System.Enum, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,21ECA002100
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Core.EnumHelper+<>c.<GetDescription>b__3_0(System.Enum)
       call      qword ptr [7FF823F16BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,21ECA002108
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L09:
       mov       rdx,rsi
       mov       r11,7FF823E60AB8
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       near ptr M00_L01
M00_L10:
       mov       [rbp-50],rax
       jmp       short M00_L12
M00_L11:
       mov       rcx,r10
       mov       rdx,rsi
       mov       r8,[r10]
       mov       r8,[r8+40]
       call      qword ptr [r8+10]
       jmp       near ptr M00_L03
M00_L12:
       mov       rax,[rbp-50]
       mov       rax,[rax+18]
       test      rax,rax
       jne       near ptr M00_L02
       jmp       short M00_L18
M00_L13:
       mov       rcx,r12
       mov       r8,rsi
       mov       rdx,r10
       mov       r11,7FF823E60AC0
       call      qword ptr [r11]
       jmp       near ptr M00_L07
M00_L14:
       mov       rax,[rbp-50]
M00_L15:
       mov       rax,[rax+18]
       test      rax,rax
       jne       near ptr M00_L06
       jmp       short M00_L18
M00_L16:
       mov       rcx,r10
       mov       rdx,rsi
       mov       r8,[r10]
       mov       r8,[r8+40]
       call      qword ptr [r8+10]
       jmp       near ptr M00_L07
M00_L17:
       mov       rax,[rbp-50]
       jmp       short M00_L15
M00_L18:
       xor       edx,edx
       mov       [rbp-40],rdx
       mov       rdx,rsi
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       xor       r9d,r9d
       mov       [rsp+28],r9d
       mov       dword ptr [rsp+30],1
       lea       r9,[rbp-40]
       mov       [rsp+38],r9
       mov       [rsp+20],rax
       mov       r9d,r13d
       shl       r9,20
       or        r9,1
       mov       rdx,r15
       mov       r8,rsi
       mov       rcx,r14
       call      qword ptr [7FF82433C4B0]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryAddInternal(Tables<System.__Canon,System.__Canon>, System.__Canon, System.Nullable`1<Int32>, System.__Canon, Boolean, Boolean, System.__Canon ByRef)
       jmp       near ptr M00_L05
M00_L19:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 746
```
```assembly
; System.Enum.Equals(System.Object)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
M01_L00:
       test      rdx,rdx
       je        short M01_L03
       cmp       rbx,rdx
       je        short M01_L02
       mov       rcx,[rbx]
       cmp       rcx,[rdx]
       jne       short M01_L03
       lea       rsi,[rbx+8]
       lea       rdi,[rdx+8]
       call      00007FF883B4EFD0
       add       eax,0FFFFFFFE
       cmp       eax,17
       ja        short M01_L03
       lea       rcx,[7FF8247327F0]
       mov       ecx,[rcx+rax*4]
       lea       rdx,[M01_L00]
       add       rcx,rdx
       jmp       rcx
       mov       eax,[rsi]
       cmp       eax,[rdi]
       sete      al
       movzx     eax,al
M01_L01:
       movzx     eax,al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L02:
       mov       eax,1
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L03:
       xor       eax,eax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
       movzx     eax,byte ptr [rsi]
       cmp       al,[rdi]
       sete      al
       movzx     eax,al
       jmp       short M01_L01
       movzx     eax,word ptr [rsi]
       cmp       ax,[rdi]
       sete      al
       movzx     eax,al
       jmp       short M01_L01
       mov       rax,[rsi]
       cmp       rax,[rdi]
       sete      al
       movzx     eax,al
       jmp       short M01_L01
; Total bytes of code 156
```
```assembly
; DotNetTips.Spargine.Core.EnumHelper+<>c.<GetDescription>b__3_0(System.Enum)
       push      rbp
       sub       rsp,70
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-48],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-40],ymm4
       vmovdqu   ymmword ptr [rbp-20],ymm4
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
; 			var type = key.GetType();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF823F1C9A8]; System.Object.GetType()
       mov       [rbp-8],rax
; 			if (!type.IsEnum)
; 			^^^^^^^^^^^^^^^^^
       mov       rcx,[rbp-8]
       mov       rax,[rbp-8]
       mov       rax,[rax]
       mov       rax,[rax+70]
       call      qword ptr [rax+30]
       test      eax,eax
       jne       short M02_L00
; 				throw new ArgumentException("Type provided must be an Enum.", nameof(input));
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-30],rax
       mov       ecx,528D
       mov       rdx,7FF824284870
       call      qword ptr [7FF824137798]
       mov       [rbp-40],rax
       mov       ecx,1C97
       mov       rdx,7FF824284870
       call      qword ptr [7FF824137798]
       mov       [rbp-48],rax
       mov       rdx,[rbp-40]
       mov       r8,[rbp-48]
       mov       rcx,[rbp-30]
       call      qword ptr [7FF824336010]
       mov       rcx,[rbp-30]
       call      CORINFO_HELP_THROW
       int       3
; 			var name = Enum.GetName(type, key);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M02_L00:
       mov       rcx,[rbp-8]
       mov       rdx,[rbp+18]
       call      qword ptr [7FF8246A5548]; System.Enum.GetName(System.Type, System.Object)
       mov       [rbp-10],rax
; 			if (name == null)
; 			^^^^^^^^^^^^^^^^^
       cmp       qword ptr [rbp-10],0
       jne       short M02_L01
; 				return key.ToString();
; 				^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,[rbp+18]
       mov       rax,[rbp+18]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       [rbp-38],rax
       jmp       near ptr M02_L05
; 			var field = type.GetField(name);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M02_L01:
       mov       rcx,[rbp-8]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF8246A5560]; System.Type.GetField(System.String)
       mov       [rbp-18],rax
; 			if (field == null)
; 			^^^^^^^^^^^^^^^^^^
       mov       rcx,[rbp-18]
       xor       edx,edx
       call      qword ptr [7FF8246A5578]; System.Reflection.FieldInfo.op_Equality(System.Reflection.FieldInfo, System.Reflection.FieldInfo)
       test      eax,eax
       je        short M02_L02
; 				return name;
; 				^^^^^^^^^^^^
       mov       rax,[rbp-10]
       mov       [rbp-38],rax
       jmp       near ptr M02_L05
; 			var descriptionAttr = field.GetCustomAttribute<DescriptionAttribute>(false);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M02_L02:
       mov       rdx,[rbp-18]
       mov       rcx,7FF8246B9CD8
       xor       r8d,r8d
       call      qword ptr [7FF8244B5B90]; System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.MemberInfo, Boolean)
       mov       [rbp-20],rax
; 			if (descriptionAttr != null && !string.IsNullOrEmpty(descriptionAttr.Description))
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       cmp       qword ptr [rbp-20],0
       je        short M02_L03
       mov       rcx,[rbp-20]
       mov       rax,[rbp-20]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       rcx,rax
       call      qword ptr [7FF82413E250]; System.String.IsNullOrEmpty(System.String)
       test      eax,eax
       jne       short M02_L03
; 				return descriptionAttr.Description;
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,[rbp-20]
       mov       rax,[rbp-20]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       [rbp-38],rax
       jmp       short M02_L05
; 			var enumMemberAttr = field.GetCustomAttribute<EnumMemberAttribute>(false);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M02_L03:
       mov       rdx,[rbp-18]
       mov       rcx,7FF8246B9D60
       xor       r8d,r8d
       call      qword ptr [7FF8244B5B90]; System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.MemberInfo, Boolean)
       mov       [rbp-28],rax
; 			if (enumMemberAttr != null && !string.IsNullOrEmpty(enumMemberAttr.Value))
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       cmp       qword ptr [rbp-28],0
       je        short M02_L04
       mov       rcx,[rbp-28]
       cmp       [rcx],ecx
       call      qword ptr [7FF8246A55A8]; System.Runtime.Serialization.EnumMemberAttribute.get_Value()
       mov       rcx,rax
       call      qword ptr [7FF82413E250]; System.String.IsNullOrEmpty(System.String)
       test      eax,eax
       jne       short M02_L04
; 				return enumMemberAttr.Value;
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,[rbp-28]
       cmp       [rcx],ecx
       call      qword ptr [7FF8246A55A8]; System.Runtime.Serialization.EnumMemberAttribute.get_Value()
       mov       [rbp-38],rax
       jmp       short M02_L05
; 			return name;
; 			^^^^^^^^^^^^
M02_L04:
       mov       rax,[rbp-10]
       mov       [rbp-38],rax
M02_L05:
       mov       rax,[rbp-38]
       add       rsp,70
       pop       rbp
       ret
; Total bytes of code 458
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
       call      qword ptr [7FF8246ACD20]
       int       3
; Total bytes of code 44
```
```assembly
; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryAddInternal(Tables<System.__Canon,System.__Canon>, System.__Canon, System.Nullable`1<Int32>, System.__Canon, Boolean, Boolean, System.__Canon ByRef)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,50
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp-58],rax
       mov       [rbp-38],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9
       movzx     r9d,r9b
       mov       r11,[rbp+18]
       mov       r11,[r11+8]
       mov       [rbp-58],r11
       mov       eax,[rbp+2C]
       test      r9d,r9d
       je        near ptr M04_L20
M04_L00:
       mov       [rbp-3C],eax
M04_L01:
       mov       rax,[rbp+18]
       mov       rcx,[rax+18]
       mov       [rbp-60],rcx
       mov       r8,[rbp+10]
       cmp       [r8],r8d
       mov       rax,[rbp+18]
       mov       r10,[rax+10]
       mov       rax,[rbp+18]
       mov       r9d,[rbp-3C]
       imul      r9,[rax+28]
       shr       r9,20
       inc       r9
       mov       r11d,[r10+8]
       mov       ebx,r11d
       imul      r9,rbx
       shr       r9,20
       mov       eax,r9d
       xor       edx,edx
       div       dword ptr [rcx+8]
       mov       [rbp-40],edx
       cmp       r9d,r11d
       jae       near ptr M04_L27
       mov       ecx,r9d
       lea       rbx,[r10+rcx*8+10]
       xor       esi,esi
       xor       edi,edi
       xor       ecx,ecx
       mov       [rbp-48],ecx
       cmp       byte ptr [rbp+40],0
       je        short M04_L02
       mov       rcx,[rbp-60]
       mov       ecx,[rcx+8]
       cmp       [rbp-40],ecx
       jae       near ptr M04_L13
       mov       rcx,[rbp-60]
       mov       edx,[rbp-40]
       mov       rcx,[rcx+rdx*8+10]
       lea       rdx,[rbp-48]
       call      qword ptr [7FF881EB1D58]; Precode of System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
M04_L02:
       mov       rcx,[rbp+18]
       mov       r8,[rbp+10]
       cmp       rcx,[r8+8]
       jne       near ptr M04_L05
       xor       r14d,r14d
       mov       r15,[rbx]
       test      r15,r15
       jne       near ptr M04_L08
M04_L03:
       mov       rcx,[r8]
       call      qword ptr [7FF881EB1558]
       mov       rcx,rax
       call      qword ptr [7FF881EB1288]; CORINFO_HELP_NEWFAST
       mov       r15,rax
       mov       r13,[rbx]
       lea       rcx,[r15+8]
       mov       rdx,[rbp+20]
       call      qword ptr [7FF881EB1260]; CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+10]
       mov       rdx,[rbp+30]
       call      qword ptr [7FF881EB1260]; CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+18]
       mov       rdx,r13
       call      qword ptr [7FF881EB1260]; CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rbp-3C]
       mov       [r15+20],ecx
       mov       rcx,rbx
       mov       rdx,r15
       call      qword ptr [7FF881EB1260]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+20]
       mov       eax,[rcx+8]
       cmp       [rbp-40],eax
       jae       near ptr M04_L13
       mov       eax,[rbp-40]
       lea       rcx,[rcx+rax*4+10]
       mov       eax,[rcx]
       add       eax,1
       jo        near ptr M04_L14
       mov       [rcx],eax
       mov       r8,[rbp+10]
       cmp       eax,[r8+10]
       jg        near ptr M04_L15
M04_L04:
       cmp       r14d,64
       jbe       near ptr M04_L17
       jmp       near ptr M04_L16
M04_L05:
       mov       rcx,[r8+8]
       mov       [rbp+18],rcx
       mov       rcx,[rbp-58]
       mov       r11,[rbp+18]
       cmp       rcx,[r11+8]
       je        near ptr M04_L23
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+8]
       mov       [rbp-58],rcx
       cmp       byte ptr [r8+19],0
       jne       short M04_L06
       mov       r8,[rbp+10]
       mov       rcx,[r8]
       call      qword ptr [7FF881EB18E8]
       mov       rcx,[rbp-58]
       mov       r11,rax
       mov       rdx,[rbp+20]
       call      qword ptr [rax]
       jmp       short M04_L07
M04_L06:
       mov       rcx,[rbp+20]
       lea       r11,[System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GetOrAdd[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.Func`3<System.__Canon,System.__Canon,System.__Canon>, System.__Canon)]
       cmp       [rcx],ecx
       call      qword ptr [r11]
M04_L07:
       mov       [rbp-3C],eax
       mov       r8,[rbp+10]
       jmp       near ptr M04_L23
M04_L08:
       mov       ecx,[rbp-3C]
       cmp       ecx,[r15+20]
       jne       short M04_L09
       mov       rcx,[r8]
       call      qword ptr [7FF881EB1500]
       mov       rcx,rax
       call      qword ptr [7FF881EB1AE8]
       mov       rdx,[r15+8]
       mov       rcx,[rbp-58]
       mov       r11,rax
       mov       r8,[rbp+20]
       call      qword ptr [rax]
       test      eax,eax
       mov       r8,[rbp+10]
       jne       short M04_L10
M04_L09:
       inc       r14d
       mov       r15,[r15+18]
       test      r15,r15
       jne       short M04_L08
       jmp       near ptr M04_L03
M04_L10:
       cmp       byte ptr [rbp+38],0
       je        short M04_L11
       lea       rcx,[r15+10]
       mov       rdx,[rbp+30]
       call      qword ptr [7FF881EB1260]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+48]
       mov       rdx,[rbp+30]
       call      qword ptr [7FF881EB1268]; CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       short M04_L12
M04_L11:
       mov       rdx,[r15+10]
       mov       rcx,[rbp+48]
       call      qword ptr [7FF881EB1268]; CORINFO_HELP_CHECKED_ASSIGN_REF
M04_L12:
       xor       ecx,ecx
       mov       [rbp-4C],ecx
       jmp       near ptr M04_L24
M04_L13:
       call      qword ptr [7FF881EB1258]
       int       3
M04_L14:
       call      qword ptr [7FF881EB1250]
       int       3
M04_L15:
       mov       esi,1
       jmp       near ptr M04_L04
M04_L16:
       mov       rcx,[rbp-58]
       call      qword ptr [7FF881EB1C10]
       mov       ecx,1
       test      rax,rax
       cmovne    edi,ecx
M04_L17:
       mov       r8,[rbp+10]
       cmp       byte ptr [rbp-48],0
       je        short M04_L18
       mov       rcx,[rbp-60]
       mov       ecx,[rcx+8]
       cmp       [rbp-40],ecx
       jae       near ptr M04_L27
       mov       rcx,[rbp-60]
       mov       eax,[rbp-40]
       mov       rcx,[rcx+rax*8+10]
       call      qword ptr [7FF881EB1D60]
       mov       r8,[rbp+10]
M04_L18:
       mov       ecx,esi
       or        ecx,edi
       jne       short M04_L25
M04_L19:
       mov       rcx,[rbp+48]
       mov       rdx,[rbp+30]
       call      qword ptr [7FF881EB1268]; CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       eax,1
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M04_L20:
       cmp       byte ptr [rcx+19],0
       jne       short M04_L21
       mov       rcx,[rbp+10]
       mov       rcx,[rcx]
       call      qword ptr [7FF881EB18E8]
       mov       rcx,[rbp-58]
       mov       r11,rax
       mov       rdx,[rbp+20]
       call      qword ptr [rax]
       jmp       short M04_L22
M04_L21:
       mov       rcx,[rbp+20]
       lea       r11,[System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GetOrAdd[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.Func`3<System.__Canon,System.__Canon,System.__Canon>, System.__Canon)]
       cmp       [rcx],ecx
       call      qword ptr [r11]
M04_L22:
       mov       rcx,[rbp+10]
       jmp       near ptr M04_L00
M04_L23:
       call      M04_L28
       jmp       near ptr M04_L01
M04_L24:
       call      M04_L28
       jmp       short M04_L26
M04_L25:
       mov       rcx,r8
       mov       rdx,[rbp+18]
       mov       r8d,esi
       mov       r9d,edi
       call      qword ptr [7FF881EB2430]
       jmp       near ptr M04_L19
M04_L26:
       mov       eax,[rbp-4C]
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M04_L27:
       call      qword ptr [7FF881EB1258]
       int       3
M04_L28:
       sub       rsp,28
       cmp       byte ptr [rbp-48],0
       je        short M04_L29
       mov       rcx,[rbp-60]
       mov       ecx,[rcx+8]
       cmp       [rbp-40],ecx
       jae       short M04_L30
       mov       rcx,[rbp-60]
       mov       eax,[rbp-40]
       mov       rcx,[rcx+rax*8+10]
       call      qword ptr [7FF881EB1D60]
M04_L29:
       nop
       add       rsp,28
       ret
M04_L30:
       call      qword ptr [7FF881EB1258]
       int       3
; Total bytes of code 950
```

## .NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       call      qword ptr [7FF8245DF0C0]; DotNetTips.Spargine.Core.BenchmarkTests.EnumHelperBenchmark.GetDescriptionNoCache(System.Enum)
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
       je        near ptr M01_L47
       mov       rcx,rbx
       call      qword ptr [7FF8241561C0]; System.Object.GetType()
       mov       rsi,rax
       mov       rcx,[rsi+18]
       test      cl,2
       jne       near ptr M01_L48
       mov       rcx,[rcx+10]
       mov       rdx,offset MT_System.Enum
       cmp       rcx,rdx
       sete      al
       movzx     eax,al
M01_L00:
       test      eax,eax
       je        near ptr M01_L49
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
       je        near ptr M01_L50
M01_L02:
       mov       rcx,rbx
       call      qword ptr [7FF8245DF1C8]; System.Enum.ToUInt64(System.Object)
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF8245DF228]; System.Enum.GetName(System.RuntimeType, UInt64)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M01_L51
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8d,1C
       call      qword ptr [7FF823E3A490]; System.RuntimeType.GetField(System.String, System.Reflection.BindingFlags)
       mov       rbx,rax
       test      rbx,rbx
       je        near ptr M01_L99
       mov       rsi,2686C2306E8
       mov       rcx,offset MT_System.ComponentModel.DescriptionAttribute
       mov       ecx,[rcx]
       and       ecx,0F0000
       cmp       ecx,0C0000
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M01_L52
       mov       rcx,rsi
       call      00007FF883B39010
       test      eax,eax
       jne       near ptr M01_L53
       mov       rcx,[7FF824638F88]
       test      rcx,rcx
       je        near ptr M01_L37
       mov       rax,[rcx+20]
       add       rax,10
       mov       rax,[rax]
       test      rax,rax
       je        near ptr M01_L59
M01_L03:
       mov       rcx,rax
M01_L04:
       test      rcx,rcx
       je        near ptr M01_L61
M01_L05:
       mov       rax,2686C222888
       cmp       rcx,rax
       jne       near ptr M01_L60
       mov       rbp,[rbx]
       mov       r14,offset MT_System.Reflection.MdFieldInfo
       cmp       rbp,r14
       jne       near ptr M01_L62
       mov       r15d,4
M01_L06:
       cmp       r15d,2
       je        near ptr M01_L64
       cmp       r15d,10
       je        near ptr M01_L63
       cmp       rbp,r14
       jne       near ptr M01_L72
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+90],xmm0
       vmovdqu   xmmword ptr [rsp+98],xmm0
       mov       rcx,227D7400308
       mov       rsi,[rcx]
       cmp       qword ptr [rsi+8],0
       je        near ptr M01_L12
       mov       r15,[rsi+10]
       xor       r13d,r13d
       mov       r12,[rsi+18]
       mov       rcx,offset MT_System.Collections.Generic.ObjectEqualityComparer<System.RuntimeType>
       cmp       [r12],rcx
       jne       near ptr M01_L67
       mov       rcx,2686C2306E8
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
       je        near ptr M01_L65
M01_L07:
       mov       rax,[rcx]
       mov       [rsp+40],rax
       mov       rcx,offset MT_System.RuntimeType
       cmp       [rax],rcx
       jne       near ptr M01_L66
       mov       rcx,rax
       call      00007FF883AFE4B0
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
       je        near ptr M01_L68
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
       call      00007FF883B35510
       mov       rcx,rax
       test      rcx,rcx
       je        near ptr M01_L69
M01_L13:
       mov       edx,[rbx+1C]
       mov       r8d,[rsp+0A0]
       mov       r9,2686C2306E8
       call      qword ptr [7FF8241572E8]; System.Reflection.CustomAttribute.GetCustomAttributes(System.Reflection.RuntimeModule, Int32, Int32, System.RuntimeType)
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
       je        near ptr M01_L41
       mov       ecx,[r15+8]
       test      ecx,ecx
       je        near ptr M01_L41
       test      ecx,ecx
       je        near ptr M01_L100
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
       call      qword ptr [7FF824154D20]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       mov       rsi,rax
M01_L17:
       test      rsi,rsi
       jne       near ptr M01_L74
M01_L18:
       mov       rsi,2686C230710
       mov       rcx,offset MT_System.Runtime.Serialization.EnumMemberAttribute
       mov       ecx,[rcx]
       and       ecx,0F0000
       cmp       ecx,0C0000
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M01_L75
       mov       rcx,rsi
       call      00007FF883B39010
       test      eax,eax
       jne       near ptr M01_L76
       mov       rcx,[7FF824639148]
       test      rcx,rcx
       je        near ptr M01_L42
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
       mov       rax,2686C222888
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
       jne       near ptr M01_L96
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+60],xmm0
       vmovdqu   xmmword ptr [rsp+68],xmm0
       mov       rcx,227D7400308
       mov       rsi,[rcx]
       cmp       qword ptr [rsi+8],0
       je        near ptr M01_L29
       mov       rbp,[rsi+10]
       xor       r14d,r14d
       mov       r15,[rsi+18]
       mov       rcx,offset MT_System.Collections.Generic.ObjectEqualityComparer<System.RuntimeType>
       cmp       [r15],rcx
       jne       near ptr M01_L90
       mov       rcx,2686C230710
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
       call      00007FF883AFE4B0
       test      eax,eax
       je        near ptr M01_L43
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
       jae       near ptr M01_L100
       mov       ecx,ecx
       lea       rdx,[rdx+rcx*4+10]
       mov       eax,[rdx]
       dec       eax
       js        short M01_L29
M01_L27:
       mov       esi,[rbp+8]
       cmp       eax,esi
       jae       near ptr M01_L100
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
       call      00007FF883B35510
       mov       rcx,rax
       test      rcx,rcx
       je        near ptr M01_L93
M01_L30:
       mov       edx,[rbx+1C]
       mov       r8d,[rsp+70]
       mov       r9,2686C230710
       call      qword ptr [7FF8241572E8]; System.Reflection.CustomAttribute.GetCustomAttributes(System.Reflection.RuntimeModule, Int32, Int32, System.RuntimeType)
       mov       rbx,rax
       cmp       dword ptr [rsp+70],0
       jle       short M01_L31
       mov       r9d,[rbx+8]
       sub       r9d,[rsp+70]
       cmp       dword ptr [rsp+70],1
       jne       near ptr M01_L44
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
       je        near ptr M01_L46
       mov       ecx,[rbp+8]
       test      ecx,ecx
       je        near ptr M01_L46
       test      ecx,ecx
       je        near ptr M01_L100
       mov       rax,[rbp+10]
       mov       rdx,rax
       cmp       ecx,1
       jne       near ptr M01_L97
M01_L33:
       mov       rcx,rdx
       test      rcx,rcx
       je        short M01_L34
       mov       rax,offset MT_System.Runtime.Serialization.EnumMemberAttribute
       cmp       [rcx],rax
       jne       near ptr M01_L98
M01_L34:
       test      rcx,rcx
       je        near ptr M01_L99
       mov       rax,[rcx+8]
       mov       rdx,rax
       test      rdx,rdx
       je        near ptr M01_L99
       cmp       dword ptr [rdx+8],0
       je        near ptr M01_L99
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
       call      qword ptr [7FF8241572A0]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       jmp       near ptr M01_L08
M01_L39:
       mov       rcx,[rsp+90]
       mov       r15d,[rsp+0A0]
       test      rcx,rcx
       je        short M01_L40
       mov       r13,[rcx]
       cmp       r13,[rsi]
       jne       short M01_L40
       cmp       dword ptr [r13+4],18
       jne       short M01_L40
       test      r9d,r9d
       jl        short M01_L40
       cmp       r15d,[rcx+8]
       jbe       near ptr M01_L70
M01_L40:
       mov       [rsp+20],r15d
       xor       r8d,r8d
       mov       [rsp+28],r8d
       mov       r8,rsi
       xor       edx,edx
       call      qword ptr [7FF824644DC8]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M01_L14
M01_L41:
       xor       edx,edx
       jmp       near ptr M01_L16
M01_L42:
       xor       eax,eax
       jmp       near ptr M01_L19
M01_L43:
       mov       rcx,r13
       call      qword ptr [7FF8241572A0]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       jmp       near ptr M01_L24
M01_L44:
       mov       rcx,[rsp+60]
       mov       esi,[rsp+70]
       test      rcx,rcx
       je        short M01_L45
       mov       rbp,[rcx]
       cmp       rbp,[rbx]
       jne       short M01_L45
       cmp       dword ptr [rbp+4],18
       jne       short M01_L45
       test      r9d,r9d
       jl        short M01_L45
       cmp       esi,[rcx+8]
       jbe       near ptr M01_L94
M01_L45:
       mov       [rsp+20],esi
       xor       r8d,r8d
       mov       [rsp+28],r8d
       mov       r8,rbx
       xor       edx,edx
       call      qword ptr [7FF824644DC8]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M01_L31
M01_L46:
       xor       edx,edx
       jmp       near ptr M01_L33
M01_L47:
       call      qword ptr [7FF82450E4A8]
       mov       ecx,7
       mov       rdx,7FF824252660
       call      qword ptr [7FF823EFF210]
       mov       rbx,rax
       mov       ecx,1B55
       mov       rdx,7FF824254098
       call      qword ptr [7FF823EFF210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF823EFD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,5
       mov       rdx,7FF824252660
       call      qword ptr [7FF823EFF210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF823EFD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF82464DDE8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF824646958]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M01_L48:
       mov       rcx,rsi
       mov       rdx,2686C226D00
       call      qword ptr [7FF823E3A608]; System.RuntimeType.IsSubclassOf(System.Type)
       jmp       near ptr M01_L00
M01_L49:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,13
       mov       rdx,7FF824252660
       call      qword ptr [7FF823EFF210]
       mov       rsi,rax
       mov       ecx,7
       mov       rdx,7FF824252660
       call      qword ptr [7FF823EFF210]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF824306040]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L50:
       mov       rcx,rsi
       call      qword ptr [7FF824647EA0]; System.Type.IsIntegerType(System.Type)
       test      eax,eax
       jne       near ptr M01_L02
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF824647EB8]
       mov       rsi,rax
       mov       ecx,3AD
       mov       rdx,7FF823E34000
       call      qword ptr [7FF823EFF210]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF824306040]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L51:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       jmp       near ptr M01_L35
M01_L52:
       xor       ecx,ecx
       jmp       near ptr M01_L04
M01_L53:
       mov       rcx,rsi
       call      qword ptr [7FF823E3A400]
       mov       rbp,rax
       mov       r14,2686C2227E0
       xor       r15d,r15d
       jmp       short M01_L57
M01_L54:
       mov       rdx,[rbp+r15*8+10]
       mov       rcx,offset MT_System.RuntimeType
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       r13,rax
       mov       rcx,r13
       cmp       [rcx],ecx
       call      qword ptr [7FF8241569A0]; System.RuntimeType.get_IsActualInterface()
       test      eax,eax
       jne       short M01_L56
       mov       rcx,r13
       call      00007FF883B39010
       test      eax,eax
       je        short M01_L55
       mov       rcx,r13
       call      qword ptr [7FF823E3A3F8]
       mov       ecx,eax
       and       ecx,4
       and       eax,8
       or        ecx,eax
       je        short M01_L56
M01_L55:
       mov       r14,r13
M01_L56:
       inc       r15d
M01_L57:
       cmp       [rbp+8],r15d
       jg        short M01_L54
       mov       rcx,2686C2227E0
       cmp       r14,rcx
       jne       short M01_L58
       mov       rcx,rsi
       call      qword ptr [7FF823E3A3F8]
       mov       rcx,2686C225890
       test      al,8
       cmovne    r14,rcx
M01_L58:
       mov       rcx,r14
       jmp       near ptr M01_L04
M01_L59:
       call      qword ptr [7FF823EF5C80]; System.RuntimeTypeHandle.GetRuntimeTypeFromHandleSlow(IntPtr)
       jmp       near ptr M01_L03
M01_L60:
       call      qword ptr [7FF8241570C0]; System.RuntimeType.GetBaseType()
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M01_L05
M01_L61:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF824646DF0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF824304150]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L62:
       mov       rcx,rbx
       mov       rax,[rbp+40]
       call      qword ptr [rax+28]
       mov       r15d,eax
       jmp       near ptr M01_L06
M01_L63:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Reflection.PropertyInfo
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       rcx,rbx
       mov       rdx,rsi
       xor       r8d,r8d
       call      qword ptr [7FF82448C420]; System.Attribute.InternalGetCustomAttributes(System.Reflection.PropertyInfo, System.Type, Boolean)
       mov       r15,rax
       jmp       near ptr M01_L15
M01_L64:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Reflection.EventInfo
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       rcx,rbx
       mov       rdx,rsi
       xor       r8d,r8d
       call      qword ptr [7FF824646E08]
       mov       r15,rax
       jmp       near ptr M01_L15
M01_L65:
       xor       eax,eax
       jmp       near ptr M01_L08
M01_L66:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
       jmp       near ptr M01_L08
M01_L67:
       mov       rcx,r12
       mov       rdx,2686C2306E8
       mov       r11,7FF823E40B80
       call      qword ptr [r11]
       jmp       near ptr M01_L09
M01_L68:
       mov       rdx,[r10]
       mov       rcx,r12
       mov       r8,2686C2306E8
       mov       r11,7FF823E40B88
       call      qword ptr [r11]
       test      eax,eax
       mov       r10,[rsp+48]
       je        near ptr M01_L11
       jmp       near ptr M01_L12
M01_L69:
       mov       rcx,rsi
       call      qword ptr [7FF824155710]; System.RuntimeTypeHandle.<GetModule>g__GetModuleWorker|48_0(System.RuntimeType)
       mov       rcx,rax
       jmp       near ptr M01_L13
M01_L70:
       lea       r8d,[r9+r15]
       cmp       r8d,[rsi+8]
       ja        near ptr M01_L40
       movzx     edx,word ptr [r13]
       mov       r8d,r15d
       imul      r8,rdx
       add       rcx,10
       mov       rax,rcx
       mov       ecx,r9d
       imul      rcx,rdx
       lea       rcx,[rsi+rcx+10]
       test      dword ptr [r13],1000000
       je        short M01_L71
       mov       rdx,rax
       call      qword ptr [7FF823EF57A0]; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L14
M01_L71:
       mov       rdx,rax
       call      qword ptr [7FF823EF5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF824646D90]
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
       call      qword ptr [7FF823E3A400]
       mov       r15,rax
       mov       r13,2686C2227E0
       xor       r12d,r12d
       jmp       short M01_L80
M01_L77:
       cmp       r12d,[r15+8]
       jae       near ptr M01_L100
       mov       rdx,[r15+r12*8+10]
       mov       rcx,offset MT_System.RuntimeType
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       [rsp+38],rax
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF8241569A0]; System.RuntimeType.get_IsActualInterface()
       test      eax,eax
       jne       short M01_L79
       mov       rcx,[rsp+38]
       call      00007FF883B39010
       test      eax,eax
       je        short M01_L78
       mov       rcx,[rsp+38]
       call      qword ptr [7FF823E3A3F8]
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
       mov       rcx,2686C2227E0
       cmp       r13,rcx
       jne       short M01_L81
       mov       rcx,rsi
       call      qword ptr [7FF823E3A3F8]
       mov       rcx,2686C225890
       test      al,8
       cmovne    r13,rcx
M01_L81:
       mov       rcx,r13
       jmp       near ptr M01_L20
M01_L82:
       call      qword ptr [7FF823EF5C80]; System.RuntimeTypeHandle.GetRuntimeTypeFromHandleSlow(IntPtr)
       jmp       near ptr M01_L19
M01_L83:
       call      qword ptr [7FF8241570C0]; System.RuntimeType.GetBaseType()
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M01_L21
M01_L84:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF824646DF0]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF824304150]
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
       call      qword ptr [7FF82448C420]; System.Attribute.InternalGetCustomAttributes(System.Reflection.PropertyInfo, System.Type, Boolean)
       mov       rbp,rax
       jmp       near ptr M01_L32
M01_L87:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Reflection.EventInfo
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       rcx,rax
       mov       rdx,rsi
       xor       r8d,r8d
       call      qword ptr [7FF824646E08]
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
       mov       rdx,2686C230710
       mov       r11,7FF823E40B90
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       near ptr M01_L26
M01_L91:
       mov       rdx,[r12]
       mov       rcx,r15
       mov       r8,2686C230710
       mov       r11,7FF823E40B98
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M01_L28
       jmp       near ptr M01_L29
M01_L92:
       call      qword ptr [7FF823EFF480]
       int       3
M01_L93:
       mov       rcx,rsi
       call      qword ptr [7FF824155710]; System.RuntimeTypeHandle.<GetModule>g__GetModuleWorker|48_0(System.RuntimeType)
       mov       rcx,rax
       jmp       near ptr M01_L30
M01_L94:
       lea       r8d,[r9+rsi]
       cmp       r8d,[rbx+8]
       ja        near ptr M01_L45
       movzx     edx,word ptr [rbp]
       mov       r8d,esi
       imul      r8,rdx
       add       rcx,10
       mov       rax,rcx
       mov       ecx,r9d
       imul      rcx,rdx
       lea       rcx,[rbx+rcx+10]
       test      dword ptr [rbp],1000000
       je        short M01_L95
       mov       rdx,rax
       call      qword ptr [7FF823EF57A0]; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L31
M01_L95:
       mov       rdx,rax
       call      qword ptr [7FF823EF5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L31
M01_L96:
       mov       rcx,rbx
       mov       rdx,rsi
       xor       r8d,r8d
       mov       rax,[rbp+48]
       call      qword ptr [rax+28]
       mov       rbx,rax
       jmp       near ptr M01_L31
M01_L97:
       mov       rcx,rdx
       call      qword ptr [7FF824646D90]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M01_L98:
       mov       rcx,rax
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M01_L99:
       mov       rax,rdi
       jmp       near ptr M01_L35
M01_L100:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 3582
```

