## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
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
       mov       rcx,1F651C020E0
       mov       rdi,[rcx]
       mov       rcx,1F651C020C8
       mov       r14,[rcx]
       test      rdi,rdi
       je        near ptr M00_L09
M00_L00:
       mov       r15,[r14+8]
       mov       rcx,[r15+8]
       cmp       byte ptr [r14+19],0
       jne       near ptr M00_L06
       mov       rdx,rsi
       mov       r11,7FFDF4550AD8
       call      qword ptr [r11]
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
       je        near ptr M00_L07
       mov       rcx,offset MT_System.Collections.Generic.ObjectEqualityComparer<System.Enum>
       cmp       [r12],rcx
       jne       near ptr M00_L07
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
       call      qword ptr [7FFDF45460A0]; System.Enum.Equals(System.Object)
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
       mov       rbx,[rbx+18]
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
       mov       rcx,rsi
       mov       rax,[7FFDF4DBCB48]
       call      qword ptr [rax+18]
       mov       r13d,eax
       jmp       near ptr M00_L01
M00_L07:
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
       call      qword ptr [7FFDF45460A0]; System.Enum.Equals(System.Object)
M00_L08:
       test      eax,eax
       je        near ptr M00_L17
       jmp       near ptr M00_L04
M00_L09:
       mov       rcx,offset MT_System.Func<System.Enum, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,1F651C020D8
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Core.EnumHelper+<>c.<GetDescription>b__5_0(System.Enum)
       call      qword ptr [7FFDF4606BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1F651C020E0
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
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
       mov       r11,7FFDF4550AE0
       call      qword ptr [r11]
       jmp       near ptr M00_L08
M00_L14:
       mov       rax,[rbp-50]
M00_L15:
       mov       rax,[rax+18]
       test      rax,rax
       jne       near ptr M00_L07
       jmp       short M00_L18
M00_L16:
       mov       rcx,r10
       mov       rdx,rsi
       mov       r8,[r10]
       mov       r8,[r8+40]
       call      qword ptr [r8+10]
       jmp       near ptr M00_L08
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
       call      qword ptr [7FFDF4A5C270]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryAddInternal(Tables<System.__Canon,System.__Canon>, System.__Canon, System.Nullable`1<Int32>, System.__Canon, Boolean, Boolean, System.__Canon ByRef)
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
       call      00007FFE541F9050
       add       eax,0FFFFFFFE
       cmp       eax,17
       ja        short M01_L03
       lea       rcx,[7FFDF4EB2930]
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
; DotNetTips.Spargine.Core.EnumHelper+<>c.<GetDescription>b__5_0(System.Enum)
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
       call      qword ptr [7FFDF460C9A8]; System.Object.GetType()
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
       mov       ecx,4EBB
       mov       rdx,7FFDF49A5D88
       call      qword ptr [7FFDF4887738]
       mov       [rbp-40],rax
       mov       ecx,1CAB
       mov       rdx,7FFDF49A5D88
       call      qword ptr [7FFDF4887738]
       mov       [rbp-48],rax
       mov       rdx,[rbp-40]
       mov       r8,[rbp-48]
       mov       rcx,[rbp-30]
       call      qword ptr [7FFDF4A55DD0]
       mov       rcx,[rbp-30]
       call      CORINFO_HELP_THROW
       int       3
; 			var name = Enum.GetName(type, key);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M02_L00:
       mov       rcx,[rbp-8]
       mov       rdx,[rbp+18]
       call      qword ptr [7FFDF4DF50E0]; System.Enum.GetName(System.Type, System.Object)
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
       call      qword ptr [7FFDF4DF50F8]; System.Type.GetField(System.String)
       mov       [rbp-18],rax
; 			if (field == null)
; 			^^^^^^^^^^^^^^^^^^
       mov       rcx,[rbp-18]
       xor       edx,edx
       call      qword ptr [7FFDF4DF5110]; System.Reflection.FieldInfo.op_Equality(System.Reflection.FieldInfo, System.Reflection.FieldInfo)
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
       mov       rcx,7FFDF4DE9CC8
       xor       r8d,r8d
       call      qword ptr [7FFDF4BF5890]; System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.MemberInfo, Boolean)
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
       call      qword ptr [7FFDF488E0E8]; System.String.IsNullOrEmpty(System.String)
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
       mov       rcx,7FFDF4DE9D50
       xor       r8d,r8d
       call      qword ptr [7FFDF4BF5890]; System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.MemberInfo, Boolean)
       mov       [rbp-28],rax
; 			if (enumMemberAttr != null && !string.IsNullOrEmpty(enumMemberAttr.Value))
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       cmp       qword ptr [rbp-28],0
       je        short M02_L04
       mov       rcx,[rbp-28]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF4DF5140]; System.Runtime.Serialization.EnumMemberAttribute.get_Value()
       mov       rcx,rax
       call      qword ptr [7FFDF488E0E8]; System.String.IsNullOrEmpty(System.String)
       test      eax,eax
       jne       short M02_L04
; 				return enumMemberAttr.Value;
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,[rbp-28]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF4DF5140]; System.Runtime.Serialization.EnumMemberAttribute.get_Value()
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
       call      qword ptr [7FFDF4DFCAC8]
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
       mov       rbx,[rbp+30]
       movzx     r9d,r9b
       mov       r8,[rbp+18]
       mov       r8,[r8+8]
       mov       [rbp-58],r8
       mov       esi,[rbp+2C]
       test      r9d,r9d
       jne       near ptr M04_L19
       cmp       byte ptr [rcx+19],0
       jne       near ptr M04_L18
       mov       rcx,[rcx]
       call      qword ptr [7FFE636DFBD0]
       mov       rcx,[rbp-58]
       mov       r11,rax
       mov       rdx,[rbp+20]
       call      qword ptr [rax]
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
       jae       near ptr M04_L25
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
       jae       near ptr M04_L12
       mov       rcx,[rbp-60]
       mov       edx,[rbp-40]
       mov       rcx,[rcx+rdx*8+10]
       lea       rdx,[rbp-48]
       call      qword ptr [7FFE636E0080]; Precode of System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
M04_L02:
       mov       rcx,[rbp+18]
       mov       r8,[rbp+10]
       cmp       rcx,[r8+8]
       jne       near ptr M04_L09
       xor       r14d,r14d
       mov       r15,[rbx]
       test      r15,r15
       jne       near ptr M04_L05
M04_L03:
       mov       rcx,[r8]
       call      qword ptr [7FFE636DF740]
       mov       rcx,rax
       call      qword ptr [7FFE636DF2C0]; CORINFO_HELP_NEWFAST
       mov       r15,rax
       mov       r13,[rbx]
       lea       rcx,[r15+8]
       mov       rdx,[rbp+20]
       call      qword ptr [7FFE636DF298]; CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+10]
       mov       rdx,[rbp+30]
       call      qword ptr [7FFE636DF298]; CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+18]
       mov       rdx,r13
       call      qword ptr [7FFE636DF298]; CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rbp-3C]
       mov       [r15+20],ecx
       mov       rcx,rbx
       mov       rdx,r15
       call      qword ptr [7FFE636DF298]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+20]
       mov       eax,[rcx+8]
       cmp       [rbp-40],eax
       jae       near ptr M04_L12
       mov       eax,[rbp-40]
       lea       rcx,[rcx+rax*4+10]
       mov       eax,[rcx]
       add       eax,1
       jo        near ptr M04_L13
       mov       [rcx],eax
       mov       r8,[rbp+10]
       cmp       eax,[r8+10]
       jg        near ptr M04_L15
M04_L04:
       cmp       r14d,64
       jbe       near ptr M04_L20
       jmp       near ptr M04_L16
M04_L05:
       mov       ecx,[rbp-3C]
       cmp       ecx,[r15+20]
       jne       short M04_L06
       mov       rcx,[r8]
       call      qword ptr [7FFE636DF6E8]
       mov       rcx,rax
       call      qword ptr [7FFE636DFDF0]
       mov       rdx,[r15+8]
       mov       rcx,[rbp-58]
       mov       r11,rax
       mov       r8,[rbp+20]
       call      qword ptr [rax]
       test      eax,eax
       mov       r8,[rbp+10]
       jne       short M04_L07
M04_L06:
       inc       r14d
       mov       r15,[r15+18]
       test      r15,r15
       jne       short M04_L05
       jmp       near ptr M04_L03
M04_L07:
       cmp       byte ptr [rbp+38],0
       je        near ptr M04_L14
       lea       rcx,[r15+10]
       mov       rdx,[rbp+30]
       call      qword ptr [7FFE636DF298]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+48]
       mov       rdx,[rbp+30]
       call      qword ptr [7FFE636DF2A0]; CORINFO_HELP_CHECKED_ASSIGN_REF
M04_L08:
       xor       ecx,ecx
       mov       [rbp-4C],ecx
       jmp       near ptr M04_L17
M04_L09:
       mov       rcx,[r8+8]
       mov       [rbp+18],rcx
       mov       rcx,[rbp-58]
       mov       rax,[rbp+18]
       cmp       rcx,[rax+8]
       je        near ptr M04_L23
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+8]
       mov       [rbp-58],rcx
       cmp       byte ptr [r8+19],0
       jne       short M04_L10
       mov       rcx,[r8]
       call      qword ptr [7FFE636DFBD0]
       mov       rcx,[rbp-58]
       mov       r11,rax
       mov       rdx,[rbp+20]
       call      qword ptr [rax]
       jmp       short M04_L11
M04_L10:
       mov       rcx,[rbp+20]
       lea       r11,[System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GetOrAdd[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.Func`3<System.__Canon,System.__Canon,System.__Canon>, System.__Canon)]
       cmp       [rcx],ecx
       call      qword ptr [r11]
M04_L11:
       mov       [rbp-3C],eax
       mov       r8,[rbp+10]
       jmp       near ptr M04_L23
M04_L12:
       call      qword ptr [7FFE636DF290]
       int       3
M04_L13:
       call      qword ptr [7FFE636DF288]
       int       3
M04_L14:
       mov       rdx,[r15+10]
       mov       rcx,[rbp+48]
       call      qword ptr [7FFE636DF2A0]; CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       near ptr M04_L08
M04_L15:
       mov       esi,1
       jmp       near ptr M04_L04
M04_L16:
       mov       rcx,[rbp-58]
       call      qword ptr [7FFE636DFF30]
       mov       ecx,1
       test      rax,rax
       cmovne    edi,ecx
       jmp       short M04_L20
M04_L17:
       call      M04_L26
       nop
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
M04_L18:
       mov       rdx,[rbp+20]
       mov       rcx,rdx
       lea       r11,[System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GetOrAdd[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.Func`3<System.__Canon,System.__Canon,System.__Canon>, System.__Canon)]
       cmp       [rcx],ecx
       call      qword ptr [r11]
       jmp       near ptr M04_L00
M04_L19:
       mov       eax,esi
       jmp       near ptr M04_L00
M04_L20:
       mov       r8,[rbp+10]
       cmp       byte ptr [rbp-48],0
       je        short M04_L21
       mov       rcx,[rbp-60]
       mov       ecx,[rcx+8]
       cmp       [rbp-40],ecx
       jae       short M04_L25
       mov       rcx,[rbp-60]
       mov       eax,[rbp-40]
       mov       rcx,[rcx+rax*8+10]
       call      qword ptr [7FFE636E0088]; Precode of System.Threading.Monitor.Exit(System.Object)
       mov       r8,[rbp+10]
M04_L21:
       mov       ecx,esi
       or        ecx,edi
       jne       short M04_L24
M04_L22:
       mov       rcx,[rbp+48]
       mov       rdx,[rbp+30]
       call      qword ptr [7FFE636DF2A0]; CORINFO_HELP_CHECKED_ASSIGN_REF
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
M04_L23:
       call      M04_L26
       jmp       near ptr M04_L01
M04_L24:
       mov       rcx,r8
       mov       rdx,[rbp+18]
       mov       r8d,esi
       mov       r9d,edi
       call      qword ptr [7FFE636E0908]
       jmp       short M04_L22
M04_L25:
       call      qword ptr [7FFE636DF290]
       int       3
M04_L26:
       sub       rsp,28
       cmp       byte ptr [rbp-48],0
       je        short M04_L27
       mov       rcx,[rbp-60]
       mov       ecx,[rcx+8]
       cmp       [rbp-40],ecx
       jae       short M04_L28
       mov       rcx,[rbp-60]
       mov       eax,[rbp-40]
       mov       rcx,[rcx+rax*8+10]
       call      qword ptr [7FFE636E0088]; Precode of System.Threading.Monitor.Exit(System.Object)
M04_L27:
       nop
       add       rsp,28
       ret
M04_L28:
       call      qword ptr [7FFE636DF290]
       int       3
; Total bytes of code 955
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.EnumHelperBenchmark.GetDescription_NoCache()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,68
       xor       eax,eax
       mov       [rsp+38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+40],ymm4
       mov       [rsp+60],rax
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Data.CountryName
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       dword ptr [rsi+8],6D
       mov       rcx,rsi
       call      qword ptr [7FFDF460C9A8]; System.Object.GetType()
       mov       rdi,rax
       mov       rcx,[rdi+18]
       test      cl,2
       jne       near ptr M00_L27
       mov       rcx,[rcx+10]
       mov       rdx,offset MT_System.Enum
       cmp       rcx,rdx
       sete      al
       movzx     eax,al
M00_L00:
       test      eax,eax
       je        near ptr M00_L28
       mov       rcx,[rdi+18]
       test      cl,2
       jne       near ptr M00_L16
       mov       rcx,[rcx+10]
       mov       rax,offset MT_System.Enum
       cmp       rcx,rax
       sete      cl
       movzx     ecx,cl
M00_L01:
       test      ecx,ecx
       je        near ptr M00_L29
M00_L02:
       mov       rcx,rsi
       call      qword ptr [7FFDF4D2EDD8]; System.Enum.ToUInt64(System.Object)
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFDF4D2EE38]; System.Enum.GetName(System.RuntimeType, UInt64)
       mov       rbp,rax
       test      rbp,rbp
       je        near ptr M00_L30
       mov       rcx,rdi
       mov       rdx,rbp
       mov       r8d,1C
       call      qword ptr [7FFDF454A490]; System.RuntimeType.GetField(System.String, System.Reflection.BindingFlags)
       mov       rsi,rax
       test      rsi,rsi
       je        near ptr M00_L53
       mov       rdi,1CCD3270678
       mov       rcx,offset MT_System.ComponentModel.DescriptionAttribute
       mov       ecx,[rcx]
       and       ecx,0F0000
       cmp       ecx,0C0000
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M00_L31
       mov       rcx,rdi
       call      00007FFE541F2C30
       test      eax,eax
       jne       near ptr M00_L32
       mov       rcx,[7FFDF4DBCF70]
       test      rcx,rcx
       je        near ptr M00_L17
       mov       rax,[rcx+20]
       add       rax,10
       mov       rax,[rax]
       test      rax,rax
       je        near ptr M00_L38
M00_L03:
       mov       rcx,rax
M00_L04:
       test      rcx,rcx
       je        near ptr M00_L40
M00_L05:
       mov       rax,1CCD3261A60
       cmp       rcx,rax
       jne       near ptr M00_L39
       mov       rcx,offset MT_System.Reflection.MdFieldInfo
       cmp       [rsi],rcx
       jne       near ptr M00_L41
       mov       r14d,4
M00_L06:
       cmp       r14d,2
       je        near ptr M00_L43
       cmp       r14d,10
       je        near ptr M00_L42
       mov       rcx,offset MT_System.Reflection.MdFieldInfo
       cmp       [rsi],rcx
       jne       near ptr M00_L50
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+50],xmm0
       vmovdqu   xmmword ptr [rsp+58],xmm0
       mov       rcx,18C3E0001C8
       mov       rdi,[rcx]
       cmp       qword ptr [rdi+8],0
       je        near ptr M00_L11
       mov       r14,[rdi+10]
       xor       r15d,r15d
       mov       r13,[rdi+18]
       mov       rcx,offset MT_System.Collections.Generic.ObjectEqualityComparer<System.RuntimeType>
       cmp       [r13],rcx
       jne       near ptr M00_L46
       mov       rcx,1CCD3270678
       mov       [rsp+48],rcx
       xor       ecx,ecx
       mov       [rsp+40],rcx
       lea       rcx,[rsp+48]
       cmp       qword ptr [rsp+40],0
       jne       short M00_L07
       mov       rcx,[rsp+48]
       mov       [rsp+40],rcx
       lea       rcx,[rsp+40]
       cmp       qword ptr [rsp+40],0
       je        near ptr M00_L44
M00_L07:
       mov       r12,[rcx]
       mov       rcx,offset MT_System.RuntimeType
       cmp       [r12],rcx
       jne       near ptr M00_L45
       mov       rcx,r12
       call      00007FFE541E6270
       test      eax,eax
       je        near ptr M00_L18
M00_L08:
       mov       r12d,eax
M00_L09:
       xor       ecx,ecx
       mov       [rsp+40],rcx
M00_L10:
       mov       rdx,[rdi+8]
       mov       ecx,r12d
       imul      rcx,[rdi+20]
       shr       rcx,20
       inc       rcx
       mov       r8d,[rdx+8]
       mov       r11d,r8d
       imul      rcx,r11
       shr       rcx,20
       cmp       ecx,r8d
       jae       near ptr M00_L54
       mov       ecx,ecx
       lea       rdx,[rdx+rcx*4+10]
       mov       eax,[rdx]
       dec       eax
       jns       near ptr M00_L19
M00_L11:
       mov       rdi,[rsi+10]
       cmp       [rdi],dil
       mov       rcx,rdi
       call      00007FFE541F1870
       mov       rcx,rax
       test      rcx,rcx
       je        near ptr M00_L49
M00_L12:
       mov       edx,[rsi+1C]
       mov       r8d,[rsp+60]
       mov       r9,1CCD3270678
       call      qword ptr [7FFDF460E970]; System.Reflection.CustomAttribute.GetCustomAttributes(System.Reflection.RuntimeModule, Int32, Int32, System.RuntimeType)
       mov       rdi,rax
       cmp       dword ptr [rsp+60],0
       jle       short M00_L13
       mov       r9d,[rdi+8]
       sub       r9d,[rsp+60]
       cmp       dword ptr [rsp+60],1
       jne       near ptr M00_L21
       movsxd    rdx,r9d
       mov       rcx,rdi
       mov       r8,[rsp+58]
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
M00_L13:
       mov       r14,rdi
       test      r14,r14
       je        short M00_L14
       mov       rdx,offset MT_System.ComponentModel.DescriptionAttribute[]
       cmp       [r14],rdx
       je        short M00_L14
       mov       rdx,rdi
       mov       rcx,offset MT_System.Attribute[]
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       r14,rax
M00_L14:
       test      r14,r14
       je        short M00_L15
       mov       ecx,[r14+8]
       test      ecx,ecx
       jne       near ptr M00_L22
M00_L15:
       xor       edx,edx
       jmp       near ptr M00_L23
M00_L16:
       xor       ecx,ecx
       jmp       near ptr M00_L01
M00_L17:
       xor       eax,eax
       jmp       near ptr M00_L03
M00_L18:
       mov       rcx,r12
       call      qword ptr [7FFDF460E928]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       jmp       near ptr M00_L08
M00_L19:
       mov       edi,[r14+8]
       cmp       eax,edi
       jae       near ptr M00_L54
       mov       edx,eax
       shl       rdx,4
       lea       rax,[r14+rdx+10]
       mov       [rsp+30],rax
       cmp       [rax+8],r12d
       je        near ptr M00_L47
M00_L20:
       mov       eax,[rax+0C]
       inc       r15d
       cmp       edi,r15d
       jb        near ptr M00_L48
       test      eax,eax
       jge       short M00_L19
       jmp       near ptr M00_L11
M00_L21:
       mov       ecx,[rsp+60]
       mov       [rsp+20],ecx
       mov       rcx,[rsp+50]
       mov       r8,rdi
       xor       edx,edx
       call      qword ptr [7FFDF4BFC780]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       near ptr M00_L13
M00_L22:
       test      ecx,ecx
       je        near ptr M00_L54
       mov       rax,[r14+10]
       mov       rdx,rax
       cmp       ecx,1
       jne       near ptr M00_L51
M00_L23:
       mov       rdi,rdx
       test      rdi,rdi
       je        short M00_L24
       mov       rcx,offset MT_System.ComponentModel.DescriptionAttribute
       cmp       [rdi],rcx
       je        short M00_L24
       call      qword ptr [7FFDF460FCC0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       mov       rdi,rax
M00_L24:
       test      rdi,rdi
       jne       near ptr M00_L52
M00_L25:
       mov       rdx,rsi
       mov       rcx,7FFDF4DBD2E0
       xor       r8d,r8d
       call      qword ptr [7FFDF4BF5890]; System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.MemberInfo, Boolean)
       test      rax,rax
       je        near ptr M00_L53
       mov       rax,[rax+8]
       mov       rcx,rax
       test      rcx,rcx
       je        near ptr M00_L53
       cmp       dword ptr [rcx+8],0
       je        near ptr M00_L53
M00_L26:
       mov       [rsp+38],rax
       mov       rcx,[rbx+18]
       lea       r8,[rsp+38]
       mov       rdx,7FFDF4DBF058
       cmp       [rcx],ecx
       call      qword ptr [7FFDF4D2EEB0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
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
M00_L27:
       mov       rcx,rdi
       mov       rdx,1CCD3265F30
       call      qword ptr [7FFDF454A608]; System.RuntimeType.IsSubclassOf(System.Type)
       jmp       near ptr M00_L00
M00_L28:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,13
       mov       rdx,7FFDF49A43A0
       call      qword ptr [7FFDF4887738]
       mov       rsi,rax
       mov       ecx,7
       mov       rdx,7FFDF49A43A0
       call      qword ptr [7FFDF4887738]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFDF4A55DD0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L29:
       mov       rcx,rdi
       call      qword ptr [7FFDF4DD7DE0]; System.Type.IsIntegerType(System.Type)
       test      eax,eax
       jne       near ptr M00_L02
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFDF4DD7DF8]
       mov       rsi,rax
       mov       ecx,3AD
       mov       rdx,7FFDF4544000
       call      qword ptr [7FFDF4887738]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFDF4A55DD0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L30:
       mov       rcx,rsi
       mov       rax,[7FFDF4DBC700]
       call      qword ptr [rax+8]
       jmp       near ptr M00_L26
M00_L31:
       xor       ecx,ecx
       jmp       near ptr M00_L04
M00_L32:
       mov       rcx,rdi
       call      qword ptr [7FFDF454A400]
       mov       r14,rax
       mov       r15,1CCD32619B8
       xor       r13d,r13d
       jmp       short M00_L36
M00_L33:
       mov       rdx,[r14+r13*8+10]
       mov       rcx,offset MT_System.RuntimeType
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       r12,rax
       mov       rcx,r12
       cmp       [rcx],ecx
       call      qword ptr [7FFDF460D398]; System.RuntimeType.get_IsActualInterface()
       test      eax,eax
       jne       short M00_L35
       mov       rcx,r12
       call      00007FFE541F2C30
       test      eax,eax
       je        short M00_L34
       mov       rcx,r12
       call      qword ptr [7FFDF454A3F8]
       mov       ecx,eax
       and       ecx,4
       and       eax,8
       or        ecx,eax
       je        short M00_L35
M00_L34:
       mov       r15,r12
M00_L35:
       inc       r13d
M00_L36:
       cmp       [r14+8],r13d
       jg        short M00_L33
       mov       rcx,1CCD32619B8
       cmp       r15,rcx
       jne       short M00_L37
       mov       rcx,rdi
       call      qword ptr [7FFDF454A3F8]
       mov       rcx,1CCD3264B90
       test      al,8
       cmovne    r15,rcx
M00_L37:
       mov       rcx,r15
       jmp       near ptr M00_L04
M00_L38:
       call      qword ptr [7FFDF4605C80]; System.RuntimeTypeHandle.GetRuntimeTypeFromHandleSlow(IntPtr)
       jmp       near ptr M00_L03
M00_L39:
       call      qword ptr [7FFDF460DAB8]; System.RuntimeType.GetBaseType()
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M00_L05
M00_L40:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       call      qword ptr [7FFDF4DD6D48]
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FFDF488FED0]
       mov       rcx,rbp
       call      CORINFO_HELP_THROW
       int       3
M00_L41:
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       r14d,eax
       jmp       near ptr M00_L06
M00_L42:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Reflection.PropertyInfo
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       rcx,rsi
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [7FFDF4BFC168]; System.Attribute.InternalGetCustomAttributes(System.Reflection.PropertyInfo, System.Type, Boolean)
       mov       r14,rax
       jmp       near ptr M00_L14
M00_L43:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Reflection.EventInfo
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       rcx,rsi
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [7FFDF4DD6D60]
       mov       r14,rax
       jmp       near ptr M00_L14
M00_L44:
       xor       r12d,r12d
       jmp       near ptr M00_L09
M00_L45:
       mov       rcx,r12
       mov       rax,[r12]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
       mov       r12d,eax
       jmp       near ptr M00_L09
M00_L46:
       mov       rcx,r13
       mov       rdx,1CCD3270678
       mov       r11,7FFDF4550BB0
       call      qword ptr [r11]
       mov       r12d,eax
       jmp       near ptr M00_L10
M00_L47:
       mov       rdx,[rax]
       mov       rcx,r13
       mov       r8,1CCD3270678
       mov       r11,7FFDF4550BB8
       call      qword ptr [r11]
       test      eax,eax
       mov       rax,[rsp+30]
       je        near ptr M00_L20
       jmp       near ptr M00_L11
M00_L48:
       call      qword ptr [7FFDF48879A8]
       int       3
M00_L49:
       mov       rcx,rdi
       call      qword ptr [7FFDF4607C90]; System.RuntimeTypeHandle.<GetModule>g__GetModuleWorker|48_0(System.RuntimeType)
       mov       rcx,rax
       jmp       near ptr M00_L12
M00_L50:
       mov       rcx,rsi
       mov       rdx,rdi
       xor       r8d,r8d
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       mov       rdi,rax
       jmp       near ptr M00_L13
M00_L51:
       mov       rcx,rdx
       call      qword ptr [7FFDF4DD6CE8]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M00_L52:
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       test      rax,rax
       je        near ptr M00_L25
       cmp       dword ptr [rax+8],0
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M00_L25
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       jmp       near ptr M00_L26
M00_L53:
       mov       rax,rbp
       jmp       near ptr M00_L26
M00_L54:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1934
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
       call      qword ptr [7FFDF4605C80]; System.RuntimeTypeHandle.GetRuntimeTypeFromHandleSlow(IntPtr)
       jmp       short M01_L00
; Total bytes of code 41
```
```assembly
; System.Enum.ToUInt64(System.Object)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
M02_L00:
       test      rbx,rbx
       je        short M02_L05
       mov       rcx,rbx
       mov       rdx,offset MT_DotNetTips.Spargine.Tester.Data.CountryName
       cmp       [rcx],rdx
       jne       short M02_L06
M02_L01:
       test      rcx,rcx
       je        short M02_L08
       mov       rax,offset MT_DotNetTips.Spargine.Tester.Data.CountryName
       cmp       [rcx],rax
       jne       short M02_L07
       call      qword ptr [7FFDF45460D0]; System.Enum.GetTypeCode()
M02_L02:
       add       eax,0FFFFFFFC
       cmp       eax,5
       jne       short M02_L09
       mov       rcx,offset MT_System.Int32
       cmp       [rbx],rcx
       je        short M02_L03
       mov       rdx,rbx
       call      System.Runtime.CompilerServices.CastHelpers.Unbox(System.Runtime.CompilerServices.MethodTable*, System.Object)
M02_L03:
       movsxd    rax,dword ptr [rbx+8]
M02_L04:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L05:
       xor       eax,eax
       jmp       short M02_L02
M02_L06:
       mov       rdx,rbx
       mov       rcx,offset MT_System.IConvertible
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rcx,rax
       jmp       short M02_L01
M02_L07:
       mov       r11,7FFDF4550BE0
       call      qword ptr [r11]
       jmp       short M02_L02
M02_L08:
       mov       eax,1
       jmp       short M02_L02
M02_L09:
       cmp       eax,8
       ja        short M02_L10
       mov       edx,eax
       lea       rcx,[7FFDF4E5C7B0]
       mov       ecx,[rcx+rdx*4]
       lea       rax,[M02_L00]
       add       rcx,rax
       jmp       rcx
M02_L10:
       test      rbx,rbx
       je        near ptr M02_L14
       jmp       near ptr M02_L11
       mov       rdx,rbx
       mov       rcx,offset MT_System.SByte
       call      System.Runtime.CompilerServices.CastHelpers.Unbox(System.Runtime.CompilerServices.MethodTable*, System.Object)
       movsx     rax,byte ptr [rax]
       jmp       short M02_L04
       mov       rdx,rbx
       mov       rcx,offset MT_System.Byte
       call      System.Runtime.CompilerServices.CastHelpers.Unbox(System.Runtime.CompilerServices.MethodTable*, System.Object)
       movzx     eax,byte ptr [rax]
       jmp       near ptr M02_L04
       mov       rdx,rbx
       mov       rcx,offset MT_System.Int16
       call      System.Runtime.CompilerServices.CastHelpers.Unbox(System.Runtime.CompilerServices.MethodTable*, System.Object)
       movsx     rax,word ptr [rax]
       jmp       near ptr M02_L04
       mov       rdx,rbx
       mov       rcx,offset MT_System.UInt16
       call      System.Runtime.CompilerServices.CastHelpers.Unbox(System.Runtime.CompilerServices.MethodTable*, System.Object)
       movzx     eax,word ptr [rax]
       jmp       near ptr M02_L04
       mov       rdx,rbx
       mov       rcx,offset MT_System.Int64
       call      System.Runtime.CompilerServices.CastHelpers.Unbox(System.Runtime.CompilerServices.MethodTable*, System.Object)
       mov       rax,[rax]
       jmp       near ptr M02_L04
       mov       rdx,rbx
       mov       rcx,offset MT_System.UInt32
       call      System.Runtime.CompilerServices.CastHelpers.Unbox(System.Runtime.CompilerServices.MethodTable*, System.Object)
       mov       eax,[rax]
       jmp       near ptr M02_L04
       mov       rdx,rbx
       mov       rcx,offset MT_System.UInt64
       call      System.Runtime.CompilerServices.CastHelpers.Unbox(System.Runtime.CompilerServices.MethodTable*, System.Object)
       mov       rax,[rax]
       jmp       near ptr M02_L04
       mov       rdx,rbx
       mov       rcx,offset MT_System.Char
       call      System.Runtime.CompilerServices.CastHelpers.Unbox(System.Runtime.CompilerServices.MethodTable*, System.Object)
       movzx     eax,word ptr [rax]
       jmp       near ptr M02_L04
M02_L11:
       mov       rcx,rbx
       call      qword ptr [7FFDF460C9A8]; System.Object.GetType()
       mov       rsi,rax
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+70]
       call      qword ptr [rax+30]
       test      eax,eax
       je        short M02_L12
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+0A0]
       call      qword ptr [rax+18]
       mov       rsi,rax
M02_L12:
       mov       rdx,1CCD3263048
       cmp       rsi,rdx
       jne       short M02_L13
       mov       rdx,rbx
       mov       rcx,offset MT_System.IntPtr
       call      System.Runtime.CompilerServices.CastHelpers.Unbox(System.Runtime.CompilerServices.MethodTable*, System.Object)
       mov       rax,[rax]
       jmp       near ptr M02_L04
M02_L13:
       mov       rdx,1CCD3265480
       cmp       rsi,rdx
       jne       short M02_L14
       mov       rdx,rbx
       mov       rcx,offset MT_System.UIntPtr
       call      System.Runtime.CompilerServices.CastHelpers.Unbox(System.Runtime.CompilerServices.MethodTable*, System.Object)
       mov       rax,[rax]
       jmp       near ptr M02_L04
M02_L14:
       call      qword ptr [7FFDF4DD7E10]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 543
```
```assembly
; System.Enum.GetName(System.RuntimeType, UInt64)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
M03_L00:
       mov       rcx,[rbx+18]
       mov       rax,rcx
       test      al,2
       jne       short M03_L02
       mov       rax,[rax+10]
       mov       rdx,offset MT_System.Enum
       cmp       rax,rdx
       sete      al
       movzx     eax,al
M03_L01:
       test      eax,eax
       je        near ptr M03_L14
       call      00007FFE541F9050
       mov       rcx,18C3E0009D8
       mov       rcx,[rcx]
       cmp       eax,1A
       jae       near ptr M03_L113
       mov       eax,eax
       mov       rdi,[rcx+rax*8+10]
       test      rdi,rdi
       je        near ptr M03_L15
       cmp       qword ptr [rdi+10],0
       je        short M03_L03
       mov       rcx,[rdi+10]
       mov       rbp,[rcx]
       test      rbp,rbp
       je        short M03_L03
       mov       rax,rbp
       jmp       short M03_L04
M03_L02:
       xor       eax,eax
       jmp       short M03_L01
M03_L03:
       mov       rcx,rdi
       call      qword ptr [7FFDF4607C48]; System.RuntimeType.InitializeCache()
M03_L04:
       mov       ebp,[rax+98]
       test      ebp,ebp
       je        near ptr M03_L16
M03_L05:
       add       ebp,0FFFFFFFC
       cmp       ebp,5
       jne       near ptr M03_L36
       cmp       rsi,0FFFFFFFF80000000
       jl        near ptr M03_L103
       cmp       rsi,7FFFFFFF
       jg        near ptr M03_L103
       mov       rbp,[rbx+10]
       test      rbp,rbp
       je        short M03_L06
       mov       rbp,[rbp]
       test      rbp,rbp
       jne       short M03_L10
M03_L06:
       mov       rcx,rbx
       call      qword ptr [7FFDF4607C48]; System.RuntimeType.InitializeCache()
M03_L07:
       mov       rcx,[rax+80]
       test      rcx,rcx
       je        short M03_L12
       mov       rdx,offset MT_System.Enum+EnumInfo<System.UInt32>
       cmp       [rcx],rdx
       jne       short M03_L11
M03_L08:
       test      rcx,rcx
       je        short M03_L13
       cmp       qword ptr [rcx+10],0
       je        short M03_L13
M03_L09:
       mov       edx,esi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       qword ptr [7FFDF4D2EE50]; System.Enum.GetName[[System.UInt32, System.Private.CoreLib]](EnumInfo`1<UInt32>, UInt32)
M03_L10:
       mov       rax,rbp
       jmp       short M03_L07
M03_L11:
       mov       rdx,offset MT_System.RuntimeType+CompositeCacheEntry
       cmp       [rcx],rdx
       jne       short M03_L12
       mov       rcx,[rcx+28]
       jmp       short M03_L08
M03_L12:
       xor       ecx,ecx
       jmp       short M03_L08
M03_L13:
       mov       rcx,rbx
       mov       edx,1
       call      qword ptr [7FFDF488DB48]; System.Enum.<GetEnumInfo>g__InitializeEnumInfo|5_0[[System.UInt32, System.Private.CoreLib]](System.RuntimeType, Boolean)
       mov       rcx,rax
       jmp       short M03_L09
M03_L14:
       call      qword ptr [7FFDF4DDDCF8]
       int       3
M03_L15:
       xor       ebp,ebp
       jmp       near ptr M03_L05
M03_L16:
       mov       rbp,rdi
       mov       rcx,rbp
       call      qword ptr [7FFDF47AF288]; System.RuntimeType.get_IsActualEnum()
       test      eax,eax
       je        short M03_L17
       mov       rcx,rdi
       call      qword ptr [7FFDF454A588]; Precode of System.RuntimeType.GetEnumUnderlyingType()
       mov       rdx,rax
       mov       rcx,offset MT_System.RuntimeType
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       rbp,rax
M03_L17:
       mov       rcx,1CCD32653B8
       cmp       rbp,rcx
       jne       short M03_L18
       mov       ebp,5
       jmp       near ptr M03_L33
M03_L18:
       mov       rcx,1CCD3262ED0
       cmp       rbp,rcx
       jne       short M03_L19
       mov       ebp,6
       jmp       near ptr M03_L33
M03_L19:
       mov       rcx,1CCD32653E0
       cmp       rbp,rcx
       jne       short M03_L20
       mov       ebp,7
       jmp       near ptr M03_L33
M03_L20:
       mov       rcx,1CCD3263070
       cmp       rbp,rcx
       jne       short M03_L21
       mov       ebp,8
       jmp       near ptr M03_L33
M03_L21:
       mov       rcx,1CCD3263120
       cmp       rbp,rcx
       jne       short M03_L22
       mov       ebp,9
       jmp       near ptr M03_L33
M03_L22:
       mov       rcx,1CCD3262E58
       cmp       rbp,rcx
       jne       short M03_L23
       mov       ebp,0A
       jmp       near ptr M03_L33
M03_L23:
       mov       rcx,1CCD3265408
       cmp       rbp,rcx
       jne       short M03_L24
       mov       ebp,0B
       jmp       near ptr M03_L33
M03_L24:
       mov       rcx,1CCD3262C50
       cmp       rbp,rcx
       jne       short M03_L25
       mov       ebp,0C
       jmp       near ptr M03_L33
M03_L25:
       mov       rcx,1CCD3265368
       cmp       rbp,rcx
       jne       short M03_L26
       mov       ebp,3
       jmp       near ptr M03_L33
M03_L26:
       mov       rcx,1CCD3265390
       cmp       rbp,rcx
       jne       short M03_L27
       mov       ebp,4
       jmp       near ptr M03_L33
M03_L27:
       mov       rcx,1CCD3265430
       cmp       rbp,rcx
       jne       short M03_L28
       mov       ebp,0D
       jmp       short M03_L33
M03_L28:
       mov       rcx,1CCD3265458
       cmp       rbp,rcx
       jne       short M03_L29
       mov       ebp,0E
       jmp       short M03_L33
M03_L29:
       mov       rcx,1CCD32662E0
       cmp       rbp,rcx
       jne       short M03_L30
       mov       ebp,0F
       jmp       short M03_L33
M03_L30:
       mov       rcx,1CCD3262AC8
       cmp       rbp,rcx
       jne       short M03_L31
       mov       ebp,10
       jmp       short M03_L33
M03_L31:
       mov       rcx,1CCD3260020
       cmp       rbp,rcx
       jne       short M03_L32
       mov       ebp,12
       jmp       short M03_L33
M03_L32:
       mov       rcx,1CCD32706E0
       mov       eax,1
       mov       edx,2
       cmp       rbp,rcx
       cmove     eax,edx
       mov       ebp,eax
M03_L33:
       cmp       qword ptr [rdi+10],0
       je        short M03_L34
       mov       rcx,[rdi+10]
       mov       r14,[rcx]
       test      r14,r14
       je        short M03_L34
       mov       rax,r14
       jmp       short M03_L35
M03_L34:
       mov       rcx,rdi
       call      qword ptr [7FFDF4607C48]; System.RuntimeType.InitializeCache()
M03_L35:
       mov       [rax+98],ebp
       jmp       near ptr M03_L05
M03_L36:
       cmp       ebp,8
       ja        short M03_L37
       mov       ecx,ebp
       lea       rax,[7FFDF4E5D328]
       mov       eax,[rax+rcx*4]
       lea       rdx,[M03_L00]
       add       rax,rdx
       jmp       rax
M03_L37:
       mov       rcx,1CCD3263048
       cmp       rdi,rcx
       jne       near ptr M03_L102
       jmp       near ptr M03_L94
       cmp       rsi,0FFFFFFFFFFFFFF80
       jl        near ptr M03_L103
       cmp       rsi,7F
       jg        near ptr M03_L103
       mov       rbp,[rbx+10]
       test      rbp,rbp
       je        short M03_L38
       mov       rbp,[rbp]
       test      rbp,rbp
       je        short M03_L38
       mov       rax,rbp
       jmp       short M03_L39
M03_L38:
       mov       rcx,rbx
       call      qword ptr [7FFDF4607C48]; System.RuntimeType.InitializeCache()
M03_L39:
       mov       rdi,[rax+80]
       test      rdi,rdi
       je        short M03_L41
       mov       rdx,rdi
       mov       rcx,offset MT_System.Enum+EnumInfo<System.Byte>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M03_L40
       mov       rcx,rax
       jmp       short M03_L42
M03_L40:
       mov       rdx,rdi
       mov       rcx,offset MT_System.RuntimeType+CompositeCacheEntry
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M03_L41
       mov       rcx,[rax+28]
       jmp       short M03_L42
M03_L41:
       xor       ecx,ecx
M03_L42:
       test      rcx,rcx
       je        short M03_L43
       cmp       qword ptr [rcx+10],0
       jne       short M03_L44
M03_L43:
       mov       rcx,rbx
       mov       edx,1
       call      qword ptr [7FFDF4DD7F60]
       mov       rcx,rax
M03_L44:
       movzx     edx,sil
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       qword ptr [7FFDF4DD7EE8]
       cmp       rsi,0FF
       ja        near ptr M03_L103
       mov       rbp,[rbx+10]
       test      rbp,rbp
       je        short M03_L45
       mov       rbp,[rbp]
       test      rbp,rbp
       je        short M03_L45
       mov       rax,rbp
       jmp       short M03_L46
M03_L45:
       mov       rcx,rbx
       call      qword ptr [7FFDF4607C48]; System.RuntimeType.InitializeCache()
M03_L46:
       mov       rdi,[rax+80]
       test      rdi,rdi
       je        short M03_L48
       mov       rdx,rdi
       mov       rcx,offset MT_System.Enum+EnumInfo<System.Byte>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M03_L47
       mov       rcx,rax
       jmp       short M03_L49
M03_L47:
       mov       rdx,rdi
       mov       rcx,offset MT_System.RuntimeType+CompositeCacheEntry
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M03_L48
       mov       rcx,[rax+28]
       jmp       short M03_L49
M03_L48:
       xor       ecx,ecx
M03_L49:
       test      rcx,rcx
       je        short M03_L50
       cmp       qword ptr [rcx+10],0
       jne       short M03_L51
M03_L50:
       mov       rcx,rbx
       mov       edx,1
       call      qword ptr [7FFDF4DD7F60]
       mov       rcx,rax
M03_L51:
       movzx     edx,sil
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       qword ptr [7FFDF4DD7EE8]
       cmp       rsi,0FFFFFFFFFFFF8000
       jl        near ptr M03_L103
       cmp       rsi,7FFF
       jg        near ptr M03_L103
       mov       rbp,[rbx+10]
       test      rbp,rbp
       je        short M03_L52
       mov       rbp,[rbp]
       test      rbp,rbp
       je        short M03_L52
       mov       rax,rbp
       jmp       short M03_L53
M03_L52:
       mov       rcx,rbx
       call      qword ptr [7FFDF4607C48]; System.RuntimeType.InitializeCache()
M03_L53:
       mov       rdi,[rax+80]
       test      rdi,rdi
       je        short M03_L55
       mov       rdx,rdi
       mov       rcx,offset MT_System.Enum+EnumInfo<System.UInt16>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M03_L54
       mov       rcx,rax
       jmp       short M03_L56
M03_L54:
       mov       rdx,rdi
       mov       rcx,offset MT_System.RuntimeType+CompositeCacheEntry
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M03_L55
       mov       rcx,[rax+28]
       jmp       short M03_L56
M03_L55:
       xor       ecx,ecx
M03_L56:
       test      rcx,rcx
       je        short M03_L57
       cmp       qword ptr [rcx+10],0
       jne       short M03_L58
M03_L57:
       mov       rcx,rbx
       mov       edx,1
       call      qword ptr [7FFDF4DDC048]
       mov       rcx,rax
M03_L58:
       movzx     edx,si
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       qword ptr [7FFDF4DD7EB8]
       cmp       rsi,0FFFF
       ja        near ptr M03_L103
       mov       rbp,[rbx+10]
       test      rbp,rbp
       je        short M03_L59
       mov       rbp,[rbp]
       test      rbp,rbp
       je        short M03_L59
       mov       rax,rbp
       jmp       short M03_L60
M03_L59:
       mov       rcx,rbx
       call      qword ptr [7FFDF4607C48]; System.RuntimeType.InitializeCache()
M03_L60:
       mov       rdi,[rax+80]
       test      rdi,rdi
       je        short M03_L62
       mov       rdx,rdi
       mov       rcx,offset MT_System.Enum+EnumInfo<System.UInt16>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M03_L61
       mov       rcx,rax
       jmp       short M03_L63
M03_L61:
       mov       rdx,rdi
       mov       rcx,offset MT_System.RuntimeType+CompositeCacheEntry
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M03_L62
       mov       rcx,[rax+28]
       jmp       short M03_L63
M03_L62:
       xor       ecx,ecx
M03_L63:
       test      rcx,rcx
       je        short M03_L64
       cmp       qword ptr [rcx+10],0
       jne       short M03_L65
M03_L64:
       mov       rcx,rbx
       mov       edx,1
       call      qword ptr [7FFDF4DDC048]
       mov       rcx,rax
M03_L65:
       movzx     edx,si
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       qword ptr [7FFDF4DD7EB8]
       mov       rcx,rsi
       shr       rcx,20
       jne       near ptr M03_L103
       mov       rbp,[rbx+10]
       test      rbp,rbp
       je        short M03_L66
       mov       rbp,[rbp]
       test      rbp,rbp
       je        short M03_L66
       mov       rax,rbp
       jmp       short M03_L67
M03_L66:
       mov       rcx,rbx
       call      qword ptr [7FFDF4607C48]; System.RuntimeType.InitializeCache()
M03_L67:
       mov       rdi,[rax+80]
       test      rdi,rdi
       je        short M03_L69
       mov       rdx,rdi
       mov       rcx,offset MT_System.Enum+EnumInfo<System.UInt32>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M03_L68
       mov       rcx,rax
       jmp       short M03_L70
M03_L68:
       mov       rdx,rdi
       mov       rcx,offset MT_System.RuntimeType+CompositeCacheEntry
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M03_L69
       mov       rcx,[rax+28]
       jmp       short M03_L70
M03_L69:
       xor       ecx,ecx
M03_L70:
       test      rcx,rcx
       je        short M03_L71
       cmp       qword ptr [rcx+10],0
       jne       short M03_L72
M03_L71:
       mov       rcx,rbx
       mov       edx,1
       call      qword ptr [7FFDF488DB48]; System.Enum.<GetEnumInfo>g__InitializeEnumInfo|5_0[[System.UInt32, System.Private.CoreLib]](System.RuntimeType, Boolean)
       mov       rcx,rax
M03_L72:
       mov       edx,esi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       qword ptr [7FFDF4D2EE50]; System.Enum.GetName[[System.UInt32, System.Private.CoreLib]](EnumInfo`1<UInt32>, UInt32)
       mov       rbp,[rbx+10]
       test      rbp,rbp
       je        short M03_L73
       mov       rbp,[rbp]
       test      rbp,rbp
       je        short M03_L73
       mov       rax,rbp
       jmp       short M03_L74
M03_L73:
       mov       rcx,rbx
       call      qword ptr [7FFDF4607C48]; System.RuntimeType.InitializeCache()
M03_L74:
       mov       rdi,[rax+80]
       test      rdi,rdi
       je        short M03_L76
       mov       rdx,rdi
       mov       rcx,offset MT_System.Enum+EnumInfo<System.UInt64>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M03_L75
       mov       rcx,rax
       jmp       short M03_L77
M03_L75:
       mov       rdx,rdi
       mov       rcx,offset MT_System.RuntimeType+CompositeCacheEntry
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M03_L76
       mov       rcx,[rax+28]
       jmp       short M03_L77
M03_L76:
       xor       ecx,ecx
M03_L77:
       test      rcx,rcx
       je        short M03_L78
       cmp       qword ptr [rcx+10],0
       jne       short M03_L79
M03_L78:
       mov       rcx,rbx
       mov       edx,1
       call      qword ptr [7FFDF4DDC120]
       mov       rcx,rax
M03_L79:
       mov       rdx,rsi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       qword ptr [7FFDF4DD7E70]
       mov       rbp,[rbx+10]
       test      rbp,rbp
       je        short M03_L80
       mov       rbp,[rbp]
       test      rbp,rbp
       je        short M03_L80
       mov       rax,rbp
       jmp       short M03_L81
M03_L80:
       mov       rcx,rbx
       call      qword ptr [7FFDF4607C48]; System.RuntimeType.InitializeCache()
M03_L81:
       mov       rdi,[rax+80]
       test      rdi,rdi
       je        short M03_L83
       mov       rdx,rdi
       mov       rcx,offset MT_System.Enum+EnumInfo<System.UInt64>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M03_L82
       mov       rcx,rax
       jmp       short M03_L84
M03_L82:
       mov       rdx,rdi
       mov       rcx,offset MT_System.RuntimeType+CompositeCacheEntry
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M03_L83
       mov       rcx,[rax+28]
       jmp       short M03_L84
M03_L83:
       xor       ecx,ecx
M03_L84:
       test      rcx,rcx
       je        short M03_L85
       cmp       qword ptr [rcx+10],0
       jne       short M03_L86
M03_L85:
       mov       rcx,rbx
       mov       edx,1
       call      qword ptr [7FFDF4DDC120]
       mov       rcx,rax
M03_L86:
       mov       rdx,rsi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       qword ptr [7FFDF4DD7E70]
       cmp       rsi,0FFFF
       ja        near ptr M03_L103
       mov       rbp,[rbx+10]
       test      rbp,rbp
       je        short M03_L87
       mov       rbp,[rbp]
       test      rbp,rbp
       je        short M03_L87
       mov       rax,rbp
       jmp       short M03_L88
M03_L87:
       mov       rcx,rbx
       call      qword ptr [7FFDF4607C48]; System.RuntimeType.InitializeCache()
M03_L88:
       mov       rdi,[rax+80]
       test      rdi,rdi
       je        short M03_L90
       mov       rdx,rdi
       mov       rcx,offset MT_System.Enum+EnumInfo<System.Char>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M03_L89
       mov       rcx,rax
       jmp       short M03_L91
M03_L89:
       mov       rdx,rdi
       mov       rcx,offset MT_System.RuntimeType+CompositeCacheEntry
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M03_L90
       mov       rcx,[rax+28]
       jmp       short M03_L91
M03_L90:
       xor       ecx,ecx
M03_L91:
       test      rcx,rcx
       je        short M03_L92
       cmp       qword ptr [rcx+10],0
       jne       short M03_L93
M03_L92:
       mov       rcx,rbx
       mov       edx,1
       call      qword ptr [7FFDF4DDC198]
       mov       rcx,rax
M03_L93:
       movzx     edx,si
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       qword ptr [7FFDF4DD7F18]
M03_L94:
       mov       rbp,[rbx+10]
       test      rbp,rbp
       je        short M03_L95
       mov       rdi,[rbp]
       test      rdi,rdi
       je        short M03_L95
       mov       rax,rdi
       jmp       short M03_L96
M03_L95:
       mov       rcx,rbx
       call      qword ptr [7FFDF4607C48]; System.RuntimeType.InitializeCache()
M03_L96:
       mov       rbp,[rax+80]
       test      rbp,rbp
       je        short M03_L98
       mov       rdx,rbp
       mov       rcx,offset MT_System.Enum+EnumInfo<System.UIntPtr>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M03_L97
       mov       rcx,rax
       jmp       short M03_L99
M03_L97:
       mov       rdx,rbp
       mov       rcx,offset MT_System.RuntimeType+CompositeCacheEntry
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M03_L98
       mov       rcx,[rax+28]
       jmp       short M03_L99
M03_L98:
       xor       ecx,ecx
M03_L99:
       test      rcx,rcx
       je        short M03_L100
       cmp       qword ptr [rcx+10],0
       jne       short M03_L101
M03_L100:
       mov       rcx,rbx
       mov       edx,1
       call      qword ptr [7FFDF4DDC210]
       mov       rcx,rax
M03_L101:
       mov       rdx,rsi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       qword ptr [7FFDF4DD7E40]
M03_L102:
       mov       rcx,1CCD3265480
       cmp       rdi,rcx
       jne       near ptr M03_L112
       mov       rbp,[rbx+10]
       test      rbp,rbp
       je        short M03_L105
       jmp       short M03_L104
M03_L103:
       xor       eax,eax
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M03_L104:
       mov       rdi,[rbp]
       test      rdi,rdi
       je        short M03_L105
       mov       rax,rdi
       jmp       short M03_L106
M03_L105:
       mov       rcx,rbx
       call      qword ptr [7FFDF4607C48]; System.RuntimeType.InitializeCache()
M03_L106:
       mov       rdi,[rax+80]
       test      rdi,rdi
       je        short M03_L108
       mov       rdx,rdi
       mov       rcx,offset MT_System.Enum+EnumInfo<System.UIntPtr>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M03_L107
       mov       rcx,rax
       jmp       short M03_L109
M03_L107:
       mov       rdx,rdi
       mov       rcx,offset MT_System.RuntimeType+CompositeCacheEntry
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M03_L108
       mov       rcx,[rax+28]
       jmp       short M03_L109
M03_L108:
       xor       ecx,ecx
M03_L109:
       test      rcx,rcx
       je        short M03_L110
       cmp       qword ptr [rcx+10],0
       jne       short M03_L111
M03_L110:
       mov       rcx,rbx
       mov       edx,1
       call      qword ptr [7FFDF4DDC210]
       mov       rcx,rax
M03_L111:
       mov       rdx,rsi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       qword ptr [7FFDF4DD7E40]
M03_L112:
       call      qword ptr [7FFDF4DD7E10]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M03_L113:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 2532
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
       je        near ptr M04_L18
       test      bl,1
       jne       short M04_L01
       mov       ebp,1
M04_L00:
       cmp       qword ptr [rsi+10],0
       je        short M04_L02
       mov       rcx,[rsi+10]
       mov       r14,[rcx]
       test      r14,r14
       je        short M04_L02
       mov       rsi,r14
       jmp       short M04_L03
M04_L01:
       mov       rcx,18C3E001F80
       mov       rcx,[rcx]
       mov       rdx,rdi
       call      qword ptr [7FFDF4DD6FB8]
       mov       rdi,rax
       mov       ebp,2
       jmp       short M04_L00
M04_L02:
       mov       rcx,rsi
       call      qword ptr [7FFDF4607C48]; System.RuntimeType.InitializeCache()
       mov       rsi,rax
M04_L03:
       mov       r14d,ebp
       mov       r15,rdi
       cmp       [rsi],sil
       lea       r13,[rsi+50]
       mov       r12,[r13]
       test      r12,r12
       je        near ptr M04_L19
M04_L04:
       mov       rsi,r12
       cmp       [rsi],sil
       cmp       r14d,1
       jne       near ptr M04_L20
       mov       rbp,[rsi+20]
       test      rbp,rbp
       je        near ptr M04_L23
       test      r15,r15
       je        short M04_L05
       mov       rcx,r15
       call      qword ptr [7FFDF46066D0]; System.String.GetNonRandomizedHashCode()
       jmp       short M04_L06
M04_L05:
       movsx     rdx,byte ptr [0]
       mov       edx,[0]
       add       edx,edx
       movsx     rcx,byte ptr [0]
       xor       ecx,ecx
       mov       r8d,0F3FBEFB7
       mov       r9d,887BF517
       call      qword ptr [7FFDF4AFCA80]; System.Marvin.ComputeHash32(Byte ByRef, UInt32, UInt32, UInt32)
M04_L06:
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
       jae       near ptr M04_L33
       mov       ecx,r14d
       mov       rcx,[r12+rcx*8+10]
       test      rcx,rcx
       je        near ptr M04_L23
M04_L07:
       cmp       rcx,r15
       je        short M04_L10
       test      r15,r15
       je        near ptr M04_L22
       mov       edx,[rcx+8]
       cmp       edx,[r15+8]
       jne       near ptr M04_L22
       add       rcx,0C
       lea       rax,[r15+0C]
       add       edx,edx
       mov       r8d,edx
       cmp       r8,0A
       je        short M04_L08
       mov       rdx,rax
       call      qword ptr [7FFDF460FB70]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M04_L09
M04_L08:
       mov       rdx,[rcx]
       mov       rcx,[rcx+2]
       mov       r8,[rax]
       xor       rdx,r8
       xor       rcx,[rax+2]
       or        rcx,rdx
       sete      al
       movzx     eax,al
M04_L09:
       test      eax,eax
       je        near ptr M04_L22
M04_L10:
       mov       rcx,[rbp+10]
       cmp       r14d,[rcx+8]
       jae       near ptr M04_L33
       mov       edx,r14d
       mov       rdi,[rcx+rdx*8+10]
M04_L11:
       test      rdi,rdi
       je        near ptr M04_L24
M04_L12:
       xor       esi,esi
       xor       ebx,2
       xor       ebp,ebp
       mov       r14d,[rdi+8]
       mov       r15d,10
       inc       r14d
       jmp       short M04_L16
M04_L13:
       mov       r13,[rdi+r15]
       mov       ecx,[r13+18]
       mov       eax,ebx
       and       eax,ecx
       cmp       eax,ecx
       jne       short M04_L15
       test      rsi,rsi
       jne       near ptr M04_L29
M04_L14:
       mov       rsi,r13
M04_L15:
       add       r15,8
M04_L16:
       dec       r14d
       jne       short M04_L13
       test      ebp,ebp
       jne       near ptr M04_L31
M04_L17:
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
M04_L18:
       mov       ecx,3E7
       mov       rdx,7FFDF4544000
       call      qword ptr [7FFDF4887738]
       mov       rcx,rax
       call      qword ptr [7FFDF4DD5860]
       int       3
M04_L19:
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache+MemberInfoCache<System.Reflection.RuntimeFieldInfo>
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       lea       rcx,[r12+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r13
       mov       rdx,r12
       xor       r8d,r8d
       call      00007FFE541EFBA0
       mov       rsi,rax
       test      rsi,rsi
       cmove     rsi,r12
       mov       r12,rsi
       jmp       near ptr M04_L04
M04_L20:
       cmp       ebp,2
       je        short M04_L25
       cmp       byte ptr [r12+18],0
       je        near ptr M04_L28
       jmp       near ptr M04_L27
M04_L21:
       cmp       r14d,edi
       jae       near ptr M04_L33
       mov       ecx,r14d
       mov       rcx,[r12+rcx*8+10]
       test      rcx,rcx
       je        short M04_L23
       jmp       near ptr M04_L07
M04_L22:
       inc       r14d
       mov       edi,[r12+8]
       cmp       edi,r14d
       jg        short M04_L21
       sub       r14d,edi
       jmp       short M04_L21
M04_L23:
       xor       edi,edi
       jmp       near ptr M04_L11
M04_L24:
       mov       rcx,rsi
       mov       rdx,r15
       mov       r8d,1
       mov       r9d,2
       call      qword ptr [7FFDF460D2C0]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
       mov       rdi,rax
       jmp       near ptr M04_L12
M04_L25:
       lea       rcx,[r12+28]
       mov       r8,rdi
       mov       rdx,offset MT_System.Reflection.CerHashtable<System.String, System.Reflection.RuntimeFieldInfo[]>
       call      qword ptr [7FFDF460F3C0]; System.Reflection.CerHashtable`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Item(System.__Canon)
       test      rax,rax
       jne       short M04_L26
       mov       rcx,r12
       mov       rdx,rdi
       mov       r8d,2
       mov       r9d,2
       call      qword ptr [7FFDF460D2C0]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
M04_L26:
       mov       rdi,rax
       jmp       near ptr M04_L12
M04_L27:
       mov       rdi,[r12+8]
       jmp       near ptr M04_L12
M04_L28:
       mov       rcx,r12
       mov       r8d,ebp
       xor       edx,edx
       mov       r9d,2
       call      qword ptr [7FFDF460D2C0]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
       mov       rdi,rax
       jmp       near ptr M04_L12
M04_L29:
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
       je        near ptr M04_L32
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFDF460ED30]; System.Type.get_IsInterface()
       test      eax,eax
       je        short M04_L30
       mov       rcx,r13
       mov       rax,[r13]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFDF460ED30]; System.Type.get_IsInterface()
       test      eax,eax
       je        short M04_L30
       mov       ebp,1
M04_L30:
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
       jne       near ptr M04_L14
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFDF460ED30]; System.Type.get_IsInterface()
       test      eax,eax
       je        near ptr M04_L15
       jmp       near ptr M04_L14
M04_L31:
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFDF460ED30]; System.Type.get_IsInterface()
       test      eax,eax
       je        near ptr M04_L17
M04_L32:
       mov       rcx,rsi
       call      qword ptr [7FFDF4DD72B8]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M04_L33:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1042
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
       sub       rsp,108
       vzeroupper
       lea       rbp,[rsp+140]
       xor       eax,eax
       mov       [rbp-0A8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-0A0],ymm4
       vmovdqu   ymmword ptr [rbp-80],ymm4
       vmovdqu   ymmword ptr [rbp-60],ymm4
       mov       [rbp-40],rax
       mov       rsi,rcx
       mov       edi,edx
       mov       r14d,r8d
       mov       rbx,r9
       lea       rcx,[rbp-0F0]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       r15,rax
       mov       rcx,rsp
       mov       [rbp-0D8],rcx
       mov       rcx,rbp
       mov       [rbp-0C8],rcx
       xor       ecx,ecx
       mov       [rsp+20],ecx
       lea       rcx,[rbp-68]
       mov       [rsp+28],rcx
       lea       rcx,[rbp-50]
       mov       rdx,rsi
       mov       r8d,edi
       mov       r9,rbx
       call      qword ptr [7FFDF460E988]; System.Reflection.CustomAttribute.AddCustomAttributes(ListBuilder`1<System.Object> ByRef, System.Reflection.RuntimeModule, Int32, System.RuntimeType, Boolean, ListBuilder`1<System.Object>)
       add       r14d,[rbp-40]
       xor       esi,esi
       mov       rcx,1CCD3261A60
       cmp       rbx,rcx
       je        near ptr M05_L25
       mov       rcx,[rbx+18]
       test      cl,2
       jne       near ptr M05_L26
       mov       ecx,[rcx]
       and       ecx,0C0000
       cmp       ecx,40000
       sete      cl
       movzx     ecx,cl
M05_L00:
       test      ecx,ecx
       jne       near ptr M05_L34
       mov       [rbp+28],rbx
       mov       rdi,rbx
       mov       rbx,[rbp+28]
M05_L01:
       mov       rcx,offset MT_System.RuntimeType
       cmp       [rdi],rcx
       jne       near ptr M05_L30
       mov       [rbp+28],rbx
       mov       [rbp-108],rdi
       mov       rcx,[rdi+18]
       mov       rax,7FFE541F06C0
       call      rax
       movzx     ebx,al
       mov       rdi,[rbp-108]
       cmp       dword ptr [7FFE5454F778],0
       jne       near ptr M05_L28
M05_L02:
       cmp       ebx,1D
       ja        short M05_L03
       mov       ecx,1FEF7FFF
       bt        ecx,ebx
       jae       near ptr M05_L29
M05_L03:
       cmp       ebx,10
       sete      r13b
       movzx     r13d,r13b
M05_L04:
       mov       rbx,[rbp+28]
M05_L05:
       test      r13d,r13d
       jne       near ptr M05_L27
       mov       rcx,offset MT_System.RuntimeType
       cmp       [rdi],rcx
       jne       near ptr M05_L31
M05_L06:
       test      rdi,rdi
       je        near ptr M05_L32
       mov       rcx,rdi
       call      00007FFE541F2E70
       test      eax,eax
       jne       near ptr M05_L33
M05_L07:
       test      esi,esi
       jne       near ptr M05_L39
       test      r14d,r14d
       je        near ptr M05_L15
       mov       [rbp-70],r14d
       mov       r14d,[rbp-70]
       test      r14d,r14d
       jl        near ptr M05_L41
       mov       [rbp-80],rbx
       xor       ecx,ecx
       mov       [rbp-78],rcx
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rbp-90],xmm0
       lea       rcx,[rbp-80]
       mov       [rbp-90],rcx
       mov       rcx,[rbp-80]
       test      rcx,rcx
       je        near ptr M05_L42
       mov       rcx,[rcx+18]
M05_L08:
       mov       [rbp-88],rcx
       vmovups   xmm0,[rbp-90]
       vmovups   [rbp-100],xmm0
       xor       ecx,ecx
       mov       [rsp+20],ecx
       lea       rcx,[rbp-78]
       mov       [rsp+28],rcx
       lea       rcx,[rbp-100]
       lea       r8,[rbp-70]
       mov       edx,1
       xor       r9d,r9d
       mov       rax,7FFDF4611878
       mov       [rbp-0E0],rax
       lea       rax,[M05_L09]
       mov       [rbp-0D0],rax
       lea       rax,[rbp-0F0]
       mov       [r15+8],rax
       mov       byte ptr [r15+4],0
       mov       rax,7FFE541F7180
       call      rax
M05_L09:
       mov       byte ptr [r15+4],1
       cmp       dword ptr [7FFE5454F778],0
       je        short M05_L10
       call      qword ptr [7FFE5453D608]; CORINFO_HELP_STOP_FOR_GC
M05_L10:
       mov       rdx,[rbp-0E8]
       mov       [r15+8],rdx
       mov       rdx,[rbp-78]
       xor       ecx,ecx
       mov       [rbp-78],rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        short M05_L11
       mov       rcx,offset MT_System.Runtime.Serialization.EnumMemberAttribute[]
       cmp       [rbx],rcx
       jne       near ptr M05_L43
M05_L11:
       xor       esi,esi
       cmp       dword ptr [rbp-40],0
       jle       short M05_L14
M05_L12:
       cmp       qword ptr [rbp-50],0
       je        near ptr M05_L24
       mov       rdx,[rbp-50]
       cmp       esi,[rdx+8]
       jae       near ptr M05_L47
       mov       rdx,[rbp-50]
       mov       r8,[rdx+rsi*8+10]
M05_L13:
       movsxd    rdx,esi
       mov       rcx,rbx
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       inc       esi
       cmp       esi,[rbp-40]
       jl        short M05_L12
M05_L14:
       mov       rax,rbx
       add       rsp,108
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M05_L15:
       cmp       qword ptr [rbx+10],0
       je        short M05_L16
       mov       rcx,[rbx+10]
       mov       rsi,[rcx]
       test      rsi,rsi
       jne       near ptr M05_L23
M05_L16:
       mov       rcx,rbx
       call      qword ptr [7FFDF4607C48]; System.RuntimeType.InitializeCache()
       mov       rbx,rax
M05_L17:
       mov       rax,[rbx+88]
       test      rax,rax
       jne       near ptr M05_L22
       mov       [rbp-110],rbx
       mov       rcx,[rbx+8]
       xor       r8d,r8d
       mov       [rbp-98],r8d
       test      rcx,rcx
       je        near ptr M05_L44
       mov       esi,[rbp-98]
       test      esi,esi
       jl        near ptr M05_L45
       mov       [rbp-0A8],rcx
       xor       ecx,ecx
       mov       [rbp-0A0],rcx
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rbp-0B8],xmm0
       lea       rcx,[rbp-0A8]
       mov       [rbp-0B8],rcx
       mov       rcx,[rbp-0A8]
       test      rcx,rcx
       je        near ptr M05_L46
       mov       rcx,[rcx+18]
M05_L18:
       mov       [rbp-0B0],rcx
       vmovups   xmm0,[rbp-0B8]
       vmovups   [rbp-100],xmm0
       xor       ecx,ecx
       mov       [rsp+20],ecx
       lea       rcx,[rbp-0A0]
       mov       [rsp+28],rcx
       lea       rcx,[rbp-100]
       lea       r8,[rbp-98]
       mov       edx,1
       xor       r9d,r9d
       mov       rax,7FFDF4611878
       mov       [rbp-0E0],rax
       lea       rax,[M05_L19]
       mov       [rbp-0D0],rax
       lea       rax,[rbp-0F0]
       mov       [r15+8],rax
       mov       byte ptr [r15+4],0
       mov       rax,7FFE541F7180
       call      rax
M05_L19:
       mov       byte ptr [r15+4],1
       cmp       dword ptr [7FFE5454F778],0
       je        short M05_L20
       call      qword ptr [7FFE5453D608]; CORINFO_HELP_STOP_FOR_GC
M05_L20:
       mov       rdx,[rbp-0E8]
       mov       [r15+8],rdx
       mov       rdx,[rbp-0A0]
       xor       ecx,ecx
       mov       [rbp-0A0],rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        short M05_L21
       mov       rcx,offset MT_System.Object[]
       cmp       [rsi],rcx
       je        short M05_L21
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rsi,rax
M05_L21:
       mov       rbx,[rbp-110]
       lea       rcx,[rbx+88]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rbx,rsi
       mov       rax,rbx
M05_L22:
       mov       rbx,rax
       jmp       near ptr M05_L11
M05_L23:
       mov       rbx,rsi
       jmp       near ptr M05_L17
M05_L24:
       mov       r8,[rbp-48]
       jmp       near ptr M05_L13
M05_L25:
       test      r14d,r14d
       je        near ptr M05_L36
       jmp       near ptr M05_L35
M05_L26:
       xor       ecx,ecx
       jmp       near ptr M05_L00
M05_L27:
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+68]
       call      qword ptr [rax+8]
       mov       rdi,rax
       jmp       near ptr M05_L01
M05_L28:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M05_L02
M05_L29:
       mov       r13d,1
       jmp       near ptr M05_L04
M05_L30:
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+68]
       call      qword ptr [rax]
       mov       r13d,eax
       jmp       near ptr M05_L05
M05_L31:
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+98]
       call      qword ptr [rax+8]
       mov       rdi,rax
       jmp       near ptr M05_L06
M05_L32:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFDF4DD6898]
       mov       r8,rax
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFDF4DD68B0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M05_L33:
       mov       rcx,rbx
       mov       rdx,1CCD3261A60
       call      qword ptr [7FFDF454A608]; System.RuntimeType.IsSubclassOf(System.Type)
       test      eax,eax
       jne       near ptr M05_L25
M05_L34:
       mov       esi,1
       jmp       near ptr M05_L07
M05_L35:
       movsxd    rdx,r14d
       mov       rcx,offset MT_System.Attribute[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbx,rax
       jmp       short M05_L38
M05_L36:
       test      byte ptr [7FFDF4E33EC0],1
       jne       short M05_L37
       mov       rcx,offset MT_System.Array+EmptyArray<System.Attribute>
       call      qword ptr [7FFDF4605728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
M05_L37:
       mov       rdx,18C54000140
       mov       rbx,[rdx]
M05_L38:
       jmp       near ptr M05_L11
M05_L39:
       test      r14d,r14d
       je        short M05_L40
       movsxd    rdx,r14d
       mov       rcx,offset MT_System.Object[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbx,rax
       jmp       near ptr M05_L11
M05_L40:
       mov       rdx,18C3E001A80
       mov       rbx,[rdx]
       jmp       near ptr M05_L11
M05_L41:
       mov       ecx,0B3
       mov       rdx,7FFDF4544000
       call      qword ptr [7FFDF4887738]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FFDF4DD5830]
       int       3
M05_L42:
       xor       ecx,ecx
       jmp       near ptr M05_L08
M05_L43:
       mov       rcx,offset MT_System.Object[]
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rbx,rax
       jmp       near ptr M05_L11
M05_L44:
       mov       ecx,9B
       mov       rdx,7FFDF4544000
       call      qword ptr [7FFDF4887738]
       mov       rcx,rax
       call      qword ptr [7FFDF4DD5860]
       int       3
M05_L45:
       mov       ecx,0B3
       mov       rdx,7FFDF4544000
       call      qword ptr [7FFDF4887738]
       mov       rdx,rax
       mov       ecx,esi
       call      qword ptr [7FFDF4DD5830]
       int       3
M05_L46:
       xor       ecx,ecx
       jmp       near ptr M05_L18
M05_L47:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1585
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       sub       rsp,28
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M06_L01
       lea       rax,[rcx+rdx*8+10]
       mov       rdx,[rcx]
       mov       rdx,[rdx+30]
       test      r8,r8
       je        short M06_L02
       cmp       rdx,[r8]
       jne       short M06_L03
M06_L00:
       mov       rcx,rax
       mov       rdx,r8
       add       rsp,28
       jmp       near ptr 00007FFE54237B10
M06_L01:
       call      qword ptr [7FFDF4DD4228]
       int       3
M06_L02:
       xor       ecx,ecx
       mov       [rax],rcx
       add       rsp,28
       ret
M06_L03:
       mov       r10,offset MT_System.Object[]
       cmp       [rcx],r10
       je        short M06_L00
       mov       rcx,rax
       add       rsp,28
       jmp       qword ptr [7FFDF460D8F0]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
; Total bytes of code 94
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       push      rsi
       push      rbx
       test      rdx,rdx
       je        short M07_L01
       mov       rax,[rdx]
       cmp       rax,rcx
       je        short M07_L01
       mov       r8,18C3E000038
       mov       r8,[r8]
       add       r8,10
       rorx      r10,rax,20
       xor       r10,rcx
       mov       r9,9E3779B97F4A7C15
       imul      r10,r9
       mov       r9d,[r8]
       shrx      r10,r10,r9
       xor       r9d,r9d
M07_L00:
       lea       r11d,[r10+1]
       movsxd    r11,r11d
       lea       r11,[r11+r11*2]
       lea       r11,[r8+r11*8]
       mov       ebx,[r11]
       mov       rsi,[r11+8]
       and       ebx,0FFFFFFFE
       cmp       rsi,rax
       jne       short M07_L02
       mov       rsi,rcx
       xor       rsi,[r11+10]
       cmp       rsi,1
       ja        short M07_L02
       cmp       ebx,[r11]
       jne       short M07_L03
       cmp       esi,1
       jne       short M07_L03
M07_L01:
       mov       rax,rdx
       pop       rbx
       pop       rsi
       ret
M07_L02:
       test      ebx,ebx
       je        short M07_L03
       inc       r9d
       add       r10d,r9d
       and       r10d,[r8+4]
       cmp       r9d,8
       jl        short M07_L00
M07_L03:
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFDF4606340]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny_NoCacheLookup(Void*, System.Object)
; Total bytes of code 153
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
       je        short M08_L01
       lea       rcx,[rbp+10]
       mov       [rbp-98],rcx
       lea       rcx,[rbp-90]
       call      qword ptr [7FFE3F568018]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-98]
       call      qword ptr [rax]
       mov       ebx,eax
       lea       rcx,[rbp-90]
       call      qword ptr [7FFE3F568020]; CORINFO_HELP_JIT_PINVOKE_END
       mov       eax,ebx
M08_L00:
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
M08_L01:
       xor       eax,eax
       jmp       short M08_L00
; Total bytes of code 119
```
```assembly
; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       sub       rsp,38
       mov       r10d,[rsp+60]
       test      rcx,rcx
       je        near ptr M09_L04
       test      r8,r8
       je        near ptr M09_L04
       mov       rax,[rcx]
       cmp       rax,[r8]
       jne       near ptr M09_L04
       cmp       dword ptr [rax+4],18
       jne       near ptr M09_L04
       mov       r11d,r10d
       or        r11d,edx
       or        r11d,r9d
       jl        near ptr M09_L04
       lea       r11d,[rdx+r10]
       cmp       r11d,[rcx+8]
       ja        near ptr M09_L04
       lea       r11d,[r9+r10]
       cmp       r11d,[r8+8]
       ja        short M09_L04
       movzx     r11d,word ptr [rax]
       mov       r10d,r10d
       imul      r10,r11
       mov       edx,edx
       imul      rdx,r11
       lea       rdx,[rcx+rdx+10]
       mov       ecx,r9d
       imul      rcx,r11
       lea       rcx,[r8+rcx+10]
       test      dword ptr [rax],1000000
       je        short M09_L02
       cmp       r10,4000
       jbe       short M09_L00
       mov       r8,r10
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,38
       jmp       qword ptr [rax]
M09_L00:
       mov       r8,r10
       call      qword ptr [7FFE3F5796A0]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       jne       short M09_L05
M09_L01:
       add       rsp,38
       ret
M09_L02:
       cmp       r10,1
       je        short M09_L03
       mov       r8,r10
       call      qword ptr [7FFE3F57C980]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M09_L01
M09_L03:
       movzx     r8d,byte ptr [rdx]
       mov       [rcx],r8b
       jmp       short M09_L01
M09_L04:
       mov       [rsp+20],r10d
       xor       eax,eax
       mov       [rsp+28],eax
       call      qword ptr [7FFE3F579398]
       jmp       short M09_L01
M09_L05:
       call      qword ptr [7FFE3F568028]; CORINFO_HELP_POLL_GC
       jmp       short M09_L01
; Total bytes of code 235
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       mov       rax,[rdx]
       mov       rax,[rax+10]
       cmp       rax,rcx
       jne       short M10_L01
M10_L00:
       mov       rax,rdx
       ret
M10_L01:
       test      rax,rax
       je        short M10_L04
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M10_L00
       jmp       short M10_L03
M10_L02:
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M10_L00
       jmp       short M10_L01
M10_L03:
       test      rax,rax
       je        short M10_L04
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M10_L00
       test      rax,rax
       je        short M10_L04
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M10_L00
       test      rax,rax
       jne       short M10_L02
M10_L04:
       jmp       qword ptr [7FFDF4DD6490]
; Total bytes of code 82
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
       je        near ptr M11_L25
       mov       rcx,[rcx+18]
       mov       rdi,[rcx]
       mov       rcx,rdi
       call      System.RuntimeTypeHandle.GetRuntimeTypeFromHandle(IntPtr)
       mov       rbp,rax
       mov       rcx,[rbp+18]
       test      cl,2
       jne       near ptr M11_L26
       mov       ecx,[rcx]
       and       ecx,0F0000
       cmp       ecx,0C0000
       sete      cl
       movzx     ecx,cl
M11_L00:
       test      ecx,ecx
       jne       near ptr M11_L27
       mov       rcx,rbp
       call      00007FFE541F2C30
       test      eax,eax
       jne       near ptr M11_L28
       mov       rcx,[rbp+18]
       test      cl,2
       jne       near ptr M11_L15
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        near ptr M11_L15
       mov       rax,[rcx+20]
       add       rax,10
       mov       rax,[rax]
       test      rax,rax
       je        near ptr M11_L34
M11_L01:
       mov       rcx,rax
M11_L02:
       test      rcx,rcx
       je        near ptr M11_L36
M11_L03:
       mov       rax,1CCD3261A60
       cmp       rcx,rax
       jne       near ptr M11_L35
M11_L04:
       mov       rcx,offset MT_System.Reflection.MdFieldInfo
       cmp       [rbx],rcx
       jne       near ptr M11_L37
       mov       r14d,4
M11_L05:
       cmp       r14d,2
       je        near ptr M11_L39
       cmp       r14d,10
       je        near ptr M11_L38
       mov       rcx,offset MT_System.Reflection.MdFieldInfo
       cmp       [rbx],rcx
       jne       near ptr M11_L57
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+58],xmm0
       vmovdqu   xmmword ptr [rsp+60],xmm0
       mov       rcx,1CCD32619B8
       cmp       rbp,rcx
       je        near ptr M11_L40
       mov       rcx,1CCD3261A60
       cmp       rbp,rcx
       sete      sil
       movzx     esi,sil
M11_L06:
       test      esi,esi
       jne       near ptr M11_L46
       mov       rcx,18C3E0001C8
       mov       r14,[rcx]
       mov       rdx,rbp
       cmp       qword ptr [r14+8],0
       je        near ptr M11_L10
       mov       r15,[r14+10]
       xor       r13d,r13d
       mov       r12,[r14+18]
       mov       rcx,offset MT_System.Collections.Generic.ObjectEqualityComparer<System.RuntimeType>
       cmp       [r12],rcx
       jne       near ptr M11_L43
       mov       [rsp+48],rdx
       xor       ecx,ecx
       mov       [rsp+40],rcx
       lea       rcx,[rsp+48]
       cmp       qword ptr [rsp+40],0
       jne       short M11_L07
       mov       rcx,[rsp+48]
       mov       [rsp+40],rcx
       lea       rcx,[rsp+40]
       cmp       qword ptr [rsp+40],0
       je        near ptr M11_L41
M11_L07:
       mov       rax,[rcx]
       mov       [rsp+30],rax
       mov       rcx,offset MT_System.RuntimeType
       cmp       [rax],rcx
       jne       near ptr M11_L42
       mov       rcx,rax
       call      00007FFE541E6270
       test      eax,eax
       je        near ptr M11_L16
M11_L08:
       xor       ecx,ecx
       mov       [rsp+40],rcx
M11_L09:
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
       jae       near ptr M11_L59
       mov       ecx,ecx
       lea       rdx,[rdx+rcx*4+10]
       mov       r10d,[rdx]
       dec       r10d
       jns       near ptr M11_L17
M11_L10:
       mov       rsi,[rbx+10]
       cmp       [rsi],sil
       mov       rcx,rsi
       call      00007FFE541F1870
       mov       rcx,rax
       test      rcx,rcx
       je        near ptr M11_L53
M11_L11:
       mov       edx,[rbx+1C]
       mov       r8d,[rsp+68]
       mov       r9,rbp
       call      qword ptr [7FFDF460E970]; System.Reflection.CustomAttribute.GetCustomAttributes(System.Reflection.RuntimeModule, Int32, Int32, System.RuntimeType)
       mov       rbx,rax
       cmp       dword ptr [rsp+68],0
       jle       short M11_L12
       mov       r9d,[rbx+8]
       sub       r9d,[rsp+68]
       cmp       dword ptr [rsp+68],1
       jne       near ptr M11_L19
       movsxd    rdx,r9d
       mov       rcx,rbx
       mov       r8,[rsp+60]
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
M11_L12:
       mov       rbp,rbx
       test      rbp,rbp
       je        short M11_L13
       mov       rdx,offset MT_System.ComponentModel.DescriptionAttribute[]
       cmp       [rbp],rdx
       je        short M11_L13
       mov       rdx,rbx
       mov       rcx,offset MT_System.Attribute[]
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rbp,rax
M11_L13:
       test      rbp,rbp
       je        short M11_L14
       mov       ecx,[rbp+8]
       test      ecx,ecx
       jne       near ptr M11_L22
M11_L14:
       xor       edx,edx
       jmp       near ptr M11_L23
M11_L15:
       xor       eax,eax
       jmp       near ptr M11_L01
M11_L16:
       mov       rcx,[rsp+30]
       call      qword ptr [7FFDF460E928]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       jmp       near ptr M11_L08
M11_L17:
       mov       r14d,[r15+8]
       cmp       r10d,r14d
       jae       near ptr M11_L59
       mov       edx,r10d
       shl       rdx,4
       lea       r10,[r15+rdx+10]
       mov       [rsp+38],r10
       cmp       [r10+8],eax
       je        near ptr M11_L44
M11_L18:
       mov       r10d,[r10+0C]
       inc       r13d
       cmp       r14d,r13d
       jb        near ptr M11_L45
       test      r10d,r10d
       mov       eax,[rsp+54]
       jge       short M11_L17
       jmp       near ptr M11_L10
M11_L19:
       mov       rcx,[rsp+58]
       mov       esi,[rsp+68]
       test      rcx,rcx
       je        near ptr M11_L56
       mov       rdx,[rcx]
       cmp       rdx,[rbx]
       jne       near ptr M11_L56
       cmp       dword ptr [rdx+4],18
       jne       near ptr M11_L56
       test      r9d,r9d
       jl        near ptr M11_L56
       cmp       esi,[rcx+8]
       ja        near ptr M11_L56
       lea       r8d,[r9+rsi]
       cmp       r8d,[rbx+8]
       ja        near ptr M11_L56
       movzx     r8d,word ptr [rdx]
       mov       eax,esi
       imul      rax,r8
       add       rcx,10
       mov       r10,rcx
       mov       ecx,r9d
       imul      rcx,r8
       lea       rcx,[rbx+rcx+10]
       test      dword ptr [rdx],1000000
       je        short M11_L20
       cmp       rax,4000
       ja        near ptr M11_L55
       mov       rdx,r10
       mov       r8,rax
       call      00007FFE541E5D60
       cmp       dword ptr [7FFE5454F778],0
       je        near ptr M11_L12
       jmp       near ptr M11_L54
M11_L20:
       cmp       rax,1
       je        short M11_L21
       mov       rdx,r10
       mov       r8,rax
       call      qword ptr [7FFDF4605818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M11_L12
M11_L21:
       movzx     r8d,byte ptr [r10]
       mov       [rcx],r8b
       jmp       near ptr M11_L12
M11_L22:
       test      ecx,ecx
       je        near ptr M11_L59
       mov       rax,[rbp+10]
       mov       rdx,rax
       cmp       ecx,1
       jne       near ptr M11_L58
M11_L23:
       mov       rax,rdx
       test      rax,rax
       je        short M11_L24
       mov       rcx,rdi
       cmp       [rax],rcx
       je        short M11_L24
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
M11_L24:
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
M11_L25:
       mov       ecx,1A1
       mov       rdx,7FFDF4544000
       call      qword ptr [7FFDF4887738]
       mov       rcx,rax
       call      qword ptr [7FFDF4DD5860]
       int       3
M11_L26:
       xor       ecx,ecx
       jmp       near ptr M11_L00
M11_L27:
       xor       ecx,ecx
       jmp       near ptr M11_L02
M11_L28:
       mov       rcx,rbp
       call      qword ptr [7FFDF454A400]
       mov       r14,rax
       mov       r15,1CCD32619B8
       xor       r13d,r13d
       jmp       short M11_L32
M11_L29:
       mov       rdx,[r14+r13*8+10]
       mov       rcx,offset MT_System.RuntimeType
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       r12,rax
       mov       rcx,r12
       cmp       [rcx],ecx
       call      qword ptr [7FFDF460D398]; System.RuntimeType.get_IsActualInterface()
       test      eax,eax
       jne       short M11_L31
       mov       rcx,r12
       call      00007FFE541F2C30
       test      eax,eax
       je        short M11_L30
       mov       rcx,r12
       call      qword ptr [7FFDF454A3F8]
       mov       ecx,eax
       and       ecx,4
       and       eax,8
       or        ecx,eax
       je        short M11_L31
M11_L30:
       mov       r15,r12
M11_L31:
       inc       r13d
M11_L32:
       cmp       [r14+8],r13d
       jg        short M11_L29
       mov       rcx,1CCD32619B8
       cmp       r15,rcx
       jne       short M11_L33
       mov       rcx,rbp
       call      qword ptr [7FFDF454A3F8]
       mov       rcx,1CCD3264B90
       test      al,8
       cmovne    r15,rcx
M11_L33:
       mov       rcx,r15
       jmp       near ptr M11_L02
M11_L34:
       call      qword ptr [7FFDF4605C80]; System.RuntimeTypeHandle.GetRuntimeTypeFromHandleSlow(IntPtr)
       jmp       near ptr M11_L01
M11_L35:
       call      qword ptr [7FFDF460DAB8]; System.RuntimeType.GetBaseType()
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M11_L03
M11_L36:
       mov       rcx,offset MT_System.Attribute
       cmp       rdi,rcx
       je        near ptr M11_L04
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFDF4DD6D48]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFDF488FED0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M11_L37:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       r14d,eax
       jmp       near ptr M11_L05
M11_L38:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Reflection.PropertyInfo
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       rcx,rax
       mov       rdx,rbp
       movzx     r8d,sil
       call      qword ptr [7FFDF4BFC168]; System.Attribute.InternalGetCustomAttributes(System.Reflection.PropertyInfo, System.Type, Boolean)
       mov       rbp,rax
       jmp       near ptr M11_L13
M11_L39:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Reflection.EventInfo
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       rcx,rax
       mov       rdx,rbp
       movzx     r8d,sil
       call      qword ptr [7FFDF4DD6D60]
       mov       rbp,rax
       jmp       near ptr M11_L13
M11_L40:
       mov       esi,1
       jmp       near ptr M11_L06
M11_L41:
       xor       eax,eax
       jmp       near ptr M11_L08
M11_L42:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
       jmp       near ptr M11_L08
M11_L43:
       mov       rcx,r12
       mov       r11,7FFDF4550B90
       call      qword ptr [r11]
       jmp       near ptr M11_L09
M11_L44:
       mov       rdx,[r10]
       mov       rcx,r12
       mov       r8,rbp
       mov       r11,7FFDF4550B98
       call      qword ptr [r11]
       test      eax,eax
       mov       r10,[rsp+38]
       je        near ptr M11_L18
       mov       rcx,1CCD3261AF8
       cmp       rbp,rcx
       jne       short M11_L48
       jmp       short M11_L46
M11_L45:
       call      qword ptr [7FFDF48879A8]
       int       3
M11_L46:
       mov       rcx,rbx
       call      qword ptr [7FFDF4DD70D8]
       test      rax,rax
       je        short M11_L47
       lea       rcx,[rsp+58]
       mov       r8,rax
       mov       rdx,offset MT_System.RuntimeType+ListBuilder<System.Attribute>
       call      qword ptr [7FFDF460D4B8]; System.RuntimeType+ListBuilder`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
M11_L47:
       test      esi,esi
       jne       short M11_L49
M11_L48:
       mov       rcx,1CCD3261AA8
       cmp       rbp,rcx
       jne       short M11_L51
M11_L49:
       mov       rcx,rbx
       call      qword ptr [7FFDF4DD70F0]
       test      rax,rax
       je        short M11_L50
       lea       rcx,[rsp+58]
       mov       r8,rax
       mov       rdx,offset MT_System.RuntimeType+ListBuilder<System.Attribute>
       call      qword ptr [7FFDF460D4B8]; System.RuntimeType+ListBuilder`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
M11_L50:
       test      esi,esi
       jne       short M11_L52
M11_L51:
       mov       rcx,1CCD3261B48
       cmp       rbp,rcx
       jne       near ptr M11_L10
M11_L52:
       test      byte ptr [rbx+30],80
       je        near ptr M11_L10
       mov       rcx,offset MT_System.NonSerializedAttribute
       call      CORINFO_HELP_NEWSFAST
       mov       r8,rax
       lea       rcx,[rsp+58]
       mov       rdx,offset MT_System.RuntimeType+ListBuilder<System.Attribute>
       call      qword ptr [7FFDF460D4B8]; System.RuntimeType+ListBuilder`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       jmp       near ptr M11_L10
M11_L53:
       mov       rcx,rsi
       call      qword ptr [7FFDF4607C90]; System.RuntimeTypeHandle.<GetModule>g__GetModuleWorker|48_0(System.RuntimeType)
       mov       rcx,rax
       jmp       near ptr M11_L11
M11_L54:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M11_L12
M11_L55:
       mov       rdx,r10
       mov       r8,rax
       call      qword ptr [7FFDF4C7DAB8]
       jmp       near ptr M11_L12
M11_L56:
       mov       [rsp+20],esi
       xor       r8d,r8d
       mov       [rsp+28],r8d
       mov       r8,rbx
       xor       edx,edx
       call      qword ptr [7FFDF4DD4B70]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M11_L12
M11_L57:
       movzx     r8d,sil
       mov       rcx,rbx
       mov       rdx,rbp
       mov       rax,[rbx]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       mov       rbx,rax
       jmp       near ptr M11_L12
M11_L58:
       mov       rcx,rdx
       call      qword ptr [7FFDF4DD6CE8]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M11_L59:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1865
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
; System.RuntimeType.IsSubclassOf(System.Type)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       test      rdx,rdx
       je        short M13_L03
       mov       rcx,offset MT_System.RuntimeType
       cmp       [rdx],rcx
       jne       short M13_L02
       mov       rsi,rdx
       mov       rcx,rbx
       call      qword ptr [7FFDF460DAB8]; System.RuntimeType.GetBaseType()
       test      rax,rax
       je        short M13_L05
M13_L00:
       cmp       rax,rsi
       jne       short M13_L04
M13_L01:
       mov       eax,1
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M13_L02:
       xor       eax,eax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M13_L03:
       mov       ecx,37B
       mov       rdx,7FFDF4544000
       call      qword ptr [7FFDF4887738]
       mov       rcx,rax
       call      qword ptr [7FFDF4DD5860]
       int       3
M13_L04:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFDF460DAB8]; System.RuntimeType.GetBaseType()
       test      rax,rax
       jne       short M13_L00
M13_L05:
       mov       rax,1CCD32619B8
       cmp       rsi,rax
       jne       short M13_L02
       mov       rax,1CCD32619B8
       cmp       rbx,rax
       jne       short M13_L01
       jmp       short M13_L02
; Total bytes of code 151
```
```assembly
; System.Type.IsIntegerType(System.Type)
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       call      qword ptr [7FFE3F568040]; Precode of System.RuntimeTypeHandle.GetRuntimeTypeFromHandle(IntPtr)
       cmp       rax,rbx
       jne       short M14_L01
M14_L00:
       mov       eax,1
       add       rsp,20
       pop       rbx
       ret
M14_L01:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       call      qword ptr [7FFE3F568040]; Precode of System.RuntimeTypeHandle.GetRuntimeTypeFromHandle(IntPtr)
       cmp       rax,rbx
       je        short M14_L00
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       call      qword ptr [7FFE3F568040]; Precode of System.RuntimeTypeHandle.GetRuntimeTypeFromHandle(IntPtr)
       cmp       rax,rbx
       je        short M14_L00
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       call      qword ptr [7FFE3F568040]; Precode of System.RuntimeTypeHandle.GetRuntimeTypeFromHandle(IntPtr)
       cmp       rax,rbx
       je        short M14_L00
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       call      qword ptr [7FFE3F568040]; Precode of System.RuntimeTypeHandle.GetRuntimeTypeFromHandle(IntPtr)
       cmp       rax,rbx
       je        short M14_L00
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       call      qword ptr [7FFE3F568040]; Precode of System.RuntimeTypeHandle.GetRuntimeTypeFromHandle(IntPtr)
       cmp       rax,rbx
       je        short M14_L00
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       call      qword ptr [7FFE3F568040]; Precode of System.RuntimeTypeHandle.GetRuntimeTypeFromHandle(IntPtr)
       cmp       rax,rbx
       je        short M14_L00
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       call      qword ptr [7FFE3F568040]; Precode of System.RuntimeTypeHandle.GetRuntimeTypeFromHandle(IntPtr)
       cmp       rax,rbx
       je        near ptr M14_L00
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       call      qword ptr [7FFE3F568040]; Precode of System.RuntimeTypeHandle.GetRuntimeTypeFromHandle(IntPtr)
       cmp       rax,rbx
       sete      al
       movzx     eax,al
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 195
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       test      rdx,rdx
       je        short M15_L00
       cmp       [rdx],rcx
       jne       short M15_L01
M15_L00:
       mov       rax,rdx
       ret
M15_L01:
       jmp       qword ptr [7FFDF460FCC0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
; Total bytes of code 20
```
```assembly
; System.RuntimeType.get_IsActualInterface()
       mov       rax,[rcx+18]
       test      al,2
       jne       short M16_L01
       mov       eax,[rax]
       and       eax,0F0000
       cmp       eax,0C0000
       sete      al
       movzx     eax,al
M16_L00:
       ret
M16_L01:
       xor       eax,eax
       jmp       short M16_L00
; Total bytes of code 31
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
       call      qword ptr [7FFE3F568018]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-0A0]
       mov       rdx,[rbp-0A8]
       call      qword ptr [rax]
       lea       rcx,[rbp-98]
       call      qword ptr [7FFE3F568020]; CORINFO_HELP_JIT_PINVOKE_END
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
; System.RuntimeType.GetBaseType()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+18]
       test      cl,2
       jne       short M18_L03
       mov       ecx,[rcx]
       and       ecx,0F0000
       cmp       ecx,0C0000
       sete      cl
       movzx     ecx,cl
M18_L00:
       test      ecx,ecx
       jne       short M18_L04
       mov       rcx,rbx
       call      00007FFE541F2C30
       test      eax,eax
       jne       short M18_L05
       mov       rcx,[rbx+18]
       test      cl,2
       jne       short M18_L02
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M18_L02
       mov       rax,[rcx+20]
       add       rax,10
       mov       rax,[rax]
       test      rax,rax
       je        near ptr M18_L11
M18_L01:
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M18_L02:
       xor       eax,eax
       jmp       short M18_L01
M18_L03:
       xor       ecx,ecx
       jmp       short M18_L00
M18_L04:
       xor       eax,eax
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M18_L05:
       mov       rcx,rbx
       call      qword ptr [7FFDF454A400]
       mov       rsi,rax
       mov       rdi,1CCD32619B8
       xor       ebp,ebp
       jmp       short M18_L09
M18_L06:
       mov       rdx,[rsi+rbp*8+10]
       mov       rcx,offset MT_System.RuntimeType
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       r14,rax
       mov       rcx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFDF460D398]; System.RuntimeType.get_IsActualInterface()
       test      eax,eax
       jne       short M18_L08
       mov       rcx,r14
       call      00007FFE541F2C30
       test      eax,eax
       je        short M18_L07
       mov       rcx,r14
       call      qword ptr [7FFDF454A3F8]
       mov       ecx,eax
       and       ecx,4
       and       eax,8
       or        ecx,eax
       je        short M18_L08
M18_L07:
       mov       rdi,r14
M18_L08:
       inc       ebp
M18_L09:
       cmp       [rsi+8],ebp
       jg        short M18_L06
       mov       rcx,1CCD32619B8
       cmp       rdi,rcx
       jne       short M18_L10
       mov       rcx,rbx
       call      qword ptr [7FFDF454A3F8]
       mov       rcx,1CCD3264B90
       test      al,8
       cmovne    rdi,rcx
M18_L10:
       mov       rax,rdi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M18_L11:
       call      qword ptr [7FFDF4605C80]; System.RuntimeTypeHandle.GetRuntimeTypeFromHandleSlow(IntPtr)
       jmp       near ptr M18_L01
; Total bytes of code 300
```
```assembly
; System.Attribute.InternalGetCustomAttributes(System.Reflection.PropertyInfo, System.Type, Boolean)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       rcx,[rbx]
       jne       short M19_L02
       movzx     edi,r8b
       mov       r8d,edi
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFE3F584AD8]; Precode of System.Reflection.RuntimePropertyInfo.GetCustomAttributes(System.Type, Boolean)
M19_L00:
       mov       rcx,rax
       call      qword ptr [7FFE3F577E70]
       mov       rbp,rax
       test      edi,edi
       jne       short M19_L03
M19_L01:
       mov       rax,rbp
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M19_L02:
       movzx     edi,r8b
       mov       r8d,edi
       mov       rcx,rbx
       mov       rdx,rsi
       lea       r11,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       call      qword ptr [r11]
       jmp       short M19_L00
M19_L03:
       mov       rcx,rbx
       call      qword ptr [7FFE3F579588]
       mov       rdi,rax
       mov       rcx,rbx
       mov       rdx,rdi
       call      qword ptr [7FFE3F579548]
       mov       rbx,rax
       test      rbx,rbx
       je        short M19_L01
       call      qword ptr [7FFE3F573FF0]
       mov       r14,rax
       mov       rcx,r14
       mov       edx,0B
       xor       r8d,r8d
       call      qword ptr [7FFE3F58EAE0]; Precode of System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       call      qword ptr [7FFE3F573E38]
       mov       r15,rax
       mov       rcx,r15
       call      qword ptr [7FFE3F58DCD8]
       mov       rcx,r15
       mov       rdx,rbp
       mov       r8,r14
       call      qword ptr [7FFE3F579580]
M19_L04:
       mov       rcx,rbx
       mov       rdx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFE3F5795A8]; Precode of System.Attribute.GetCustomAttributes(System.Reflection.MemberInfo, System.Type, Boolean)
       mov       rdx,rax
       mov       rcx,r15
       mov       r8,r14
       call      qword ptr [7FFE3F579590]
       mov       rcx,rbx
       mov       rdx,rdi
       call      qword ptr [7FFE3F579548]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M19_L04
       mov       edx,[r15+10]
       mov       rcx,rsi
       call      qword ptr [7FFE3F5795A0]
       mov       rbx,rax
       mov       rcx,r15
       mov       rdx,rbx
       xor       r8d,r8d
       call      qword ptr [7FFE3F58DE28]
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
; Total bytes of code 294
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
       call      qword ptr [7FFE3F568018]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-0A0]
       mov       rdx,[rbp-0A8]
       call      qword ptr [rax]
       lea       rcx,[rbp-98]
       call      qword ptr [7FFE3F568020]; CORINFO_HELP_JIT_PINVOKE_END
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

