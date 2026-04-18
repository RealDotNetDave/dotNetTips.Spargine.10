## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumExtensionsBenchmark.GetDescription()
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
       mov       rcx,offset MT_System.StringComparison
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,[rbx+138]
       mov       [rsi+8],ecx
       mov       rcx,2004E002108
       mov       rdi,[rcx]
       mov       rcx,2004E0020E8
       mov       r14,[rcx]
       test      rdi,rdi
       je        near ptr M00_L08
M00_L00:
       mov       r15,[r14+8]
       mov       rcx,[r15+8]
       cmp       byte ptr [r14+19],0
       je        near ptr M00_L09
       mov       rcx,rsi
       mov       rax,[7FFB6D45CC48]
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
       mov       rcx,offset MT_System.StringComparison
       cmp       [r10],rcx
       jne       near ptr M00_L11
       mov       rcx,r10
       mov       rdx,rsi
       call      qword ptr [7FFB6D2360A0]; System.Enum.Equals(System.Object)
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
       mov       rcx,offset MT_System.StringComparison
       cmp       [r10],rcx
       jne       near ptr M00_L16
       mov       rcx,r10
       mov       rdx,rsi
       call      qword ptr [7FFB6D2360A0]; System.Enum.Equals(System.Object)
M00_L07:
       test      eax,eax
       je        near ptr M00_L17
       jmp       near ptr M00_L04
M00_L08:
       mov       rcx,offset MT_System.Func<System.Enum, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,2004E002100
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Core.EnumHelper+<>c.<GetDescription>b__3_0(System.Enum)
       call      qword ptr [7FFB6D2F6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,2004E002108
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L09:
       mov       rdx,rsi
       mov       r11,7FFB6D240AB8
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
       mov       r11,7FFB6D240AC0
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
       call      qword ptr [7FFB6D67C4B0]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryAddInternal(Tables<System.__Canon,System.__Canon>, System.__Canon, System.Nullable`1<Int32>, System.__Canon, Boolean, Boolean, System.__Canon ByRef)
       jmp       near ptr M00_L05
M00_L19:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 748
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
       call      00007FFBCCF4EFD0
       add       eax,0FFFFFFFE
       cmp       eax,17
       ja        short M01_L03
       lea       rcx,[7FFBE42B1ED0]
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
       call      qword ptr [7FFB6D2FC9A8]; System.Object.GetType()
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
       mov       rdx,7FFB6D5C4878
       call      qword ptr [7FFB6D517798]
       mov       [rbp-40],rax
       mov       ecx,1C97
       mov       rdx,7FFB6D5C4878
       call      qword ptr [7FFB6D517798]
       mov       [rbp-48],rax
       mov       rdx,[rbp-40]
       mov       r8,[rbp-48]
       mov       rcx,[rbp-30]
       call      qword ptr [7FFB6D676010]
       mov       rcx,[rbp-30]
       call      CORINFO_HELP_THROW
       int       3
; 			var name = Enum.GetName(type, key);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M02_L00:
       mov       rcx,[rbp-8]
       mov       rdx,[rbp+18]
       call      qword ptr [7FFB6D9D5170]; System.Enum.GetName(System.Type, System.Object)
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
       call      qword ptr [7FFB6D9D5188]; System.Type.GetField(System.String)
       mov       [rbp-18],rax
; 			if (field == null)
; 			^^^^^^^^^^^^^^^^^^
       mov       rcx,[rbp-18]
       xor       edx,edx
       call      qword ptr [7FFB6D9D51A0]; System.Reflection.FieldInfo.op_Equality(System.Reflection.FieldInfo, System.Reflection.FieldInfo)
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
       mov       rcx,7FFB6D9C9BA0
       xor       r8d,r8d
       call      qword ptr [7FFB6D7F5B90]; System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.MemberInfo, Boolean)
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
       call      qword ptr [7FFB6D51E250]; System.String.IsNullOrEmpty(System.String)
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
       mov       rcx,7FFB6D9C9C28
       xor       r8d,r8d
       call      qword ptr [7FFB6D7F5B90]; System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.MemberInfo, Boolean)
       mov       [rbp-28],rax
; 			if (enumMemberAttr != null && !string.IsNullOrEmpty(enumMemberAttr.Value))
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       cmp       qword ptr [rbp-28],0
       je        short M02_L04
       mov       rcx,[rbp-28]
       cmp       [rcx],ecx
       call      qword ptr [7FFB6D9D51D0]
       mov       rcx,rax
       call      qword ptr [7FFB6D51E250]; System.String.IsNullOrEmpty(System.String)
       test      eax,eax
       jne       short M02_L04
; 				return enumMemberAttr.Value;
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,[rbp-28]
       cmp       [rcx],ecx
       call      qword ptr [7FFB6D9D51D0]
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
       call      qword ptr [7FFB6D9DCCC0]
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
       call      qword ptr [7FFBEB061D58]; Precode of System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
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
       call      qword ptr [7FFBEB061558]
       mov       rcx,rax
       call      qword ptr [7FFBEB061288]; CORINFO_HELP_NEWFAST
       mov       r15,rax
       mov       r13,[rbx]
       lea       rcx,[r15+8]
       mov       rdx,[rbp+20]
       call      qword ptr [7FFBEB061260]; CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+10]
       mov       rdx,[rbp+30]
       call      qword ptr [7FFBEB061260]; CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+18]
       mov       rdx,r13
       call      qword ptr [7FFBEB061260]; CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rbp-3C]
       mov       [r15+20],ecx
       mov       rcx,rbx
       mov       rdx,r15
       call      qword ptr [7FFBEB061260]; CORINFO_HELP_ASSIGN_REF
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
       call      qword ptr [7FFBEB0618E8]
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
       call      qword ptr [7FFBEB061500]
       mov       rcx,rax
       call      qword ptr [7FFBEB061AE8]
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
       call      qword ptr [7FFBEB061260]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+48]
       mov       rdx,[rbp+30]
       call      qword ptr [7FFBEB061268]; CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       short M04_L12
M04_L11:
       mov       rdx,[r15+10]
       mov       rcx,[rbp+48]
       call      qword ptr [7FFBEB061268]; CORINFO_HELP_CHECKED_ASSIGN_REF
M04_L12:
       xor       ecx,ecx
       mov       [rbp-4C],ecx
       jmp       near ptr M04_L24
M04_L13:
       call      qword ptr [7FFBEB061258]
       int       3
M04_L14:
       call      qword ptr [7FFBEB061250]
       int       3
M04_L15:
       mov       esi,1
       jmp       near ptr M04_L04
M04_L16:
       mov       rcx,[rbp-58]
       call      qword ptr [7FFBEB061C10]
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
       call      qword ptr [7FFBEB061D60]; Precode of System.Threading.Monitor.Exit(System.Object)
       mov       r8,[rbp+10]
M04_L18:
       mov       ecx,esi
       or        ecx,edi
       jne       short M04_L25
M04_L19:
       mov       rcx,[rbp+48]
       mov       rdx,[rbp+30]
       call      qword ptr [7FFBEB061268]; CORINFO_HELP_CHECKED_ASSIGN_REF
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
       call      qword ptr [7FFBEB0618E8]
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
       call      qword ptr [7FFBEB062430]
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
       call      qword ptr [7FFBEB061258]
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
       call      qword ptr [7FFBEB061D60]; Precode of System.Threading.Monitor.Exit(System.Object)
M04_L29:
       nop
       add       rsp,28
       ret
M04_L30:
       call      qword ptr [7FFBEB061258]
       int       3
; Total bytes of code 950
```

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumExtensionsBenchmark.GetItems()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,offset MT_System.StringComparison
       call      CORINFO_HELP_NEWSFAST
       mov       ecx,[rbx+138]
       mov       [rax+8],ecx
       mov       rcx,rax
       call      qword ptr [7FFB6D93F108]; DotNetTips.Spargine.Extensions.EnumExtensions.GetItems(System.Enum)
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
; Total bytes of code 83
```
```assembly
; DotNetTips.Spargine.Extensions.EnumExtensions.GetItems(System.Enum)
; 			var enumType = input.GetType();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var enumValues = Enum.GetValues(enumType);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var enumNames = Enum.GetNames(enumType);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var items = new List<(string Description, int Value)>(enumValues.Length);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			for (var index = 0; index < enumValues.Length; index++)
; 			     ^^^^^^^^^^^^^
; 				items.Add((Description: enumNames[index], Value: Convert.ToInt32(enumValues.GetValue(index), CultureInfo.InvariantCulture)));
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			return items.ToReadOnlyCollection();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0E8
       lea       rbp,[rsp+120]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-0C0],ymm4
       vmovdqu   ymmword ptr [rbp-0A0],ymm4
       vmovdqu   ymmword ptr [rbp-80],ymm4
       vmovdqu   ymmword ptr [rbp-60],ymm4
       mov       rbx,rcx
       lea       rcx,[rbp-0A0]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rcx,rsp
       mov       [rbp-88],rcx
       mov       rcx,rbp
       mov       [rbp-78],rcx
       mov       rcx,rbx
       call      qword ptr [7FFB6D2EC9A8]; System.Object.GetType()
       mov       rbx,rax
       mov       [rbp-0C8],rbx
       mov       rcx,[rbx+18]
       test      cl,2
       jne       near ptr M01_L21
       mov       rcx,[rcx+10]
       mov       rax,offset MT_System.Enum
       cmp       rcx,rax
       sete      cl
       movzx     ecx,cl
M01_L00:
       test      ecx,ecx
       je        near ptr M01_L75
       mov       rcx,rbx
       call      qword ptr [7FFB6D93F1E0]; System.Enum.GetValuesAsUnderlyingTypeNoCopy(System.RuntimeType)
       mov       rdi,rax
       mov       [rbp-0D0],rdi
       mov       ecx,[rdi+8]
       test      ecx,ecx
       jl        near ptr M01_L106
       mov       [rbp-40],ecx
       mov       r14d,[rbp-40]
       test      r14d,r14d
       jl        near ptr M01_L54
       mov       [rbp-50],rbx
       xor       ecx,ecx
       mov       [rbp-48],rcx
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rbp-60],xmm0
       lea       rcx,[rbp-50]
       mov       [rbp-60],rcx
       mov       rcx,[rbp-50]
       test      rcx,rcx
       je        near ptr M01_L55
       mov       rcx,[rcx+18]
M01_L01:
       mov       [rbp-58],rcx
       vmovups   xmm0,[rbp-60]
       vmovups   [rbp-0B0],xmm0
       xor       ecx,ecx
       mov       [rsp+20],ecx
       lea       rcx,[rbp-48]
       mov       [rsp+28],rcx
       lea       rcx,[rbp-0B0]
       lea       r8,[rbp-40]
       mov       edx,1
       xor       r9d,r9d
       mov       rax,7FFB6D2F1878
       mov       [rbp-90],rax
       lea       rax,[M01_L02]
       mov       [rbp-80],rax
       lea       rax,[rbp-0A0]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFBCCF0EB80
       vzeroupper
       call      rax
M01_L02:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFBCD253B10],0
       je        short M01_L03
       call      qword ptr [7FFBCD241648]; CORINFO_HELP_STOP_FOR_GC
M01_L03:
       mov       rcx,[rbp-98]
       mov       [rsi+8],rcx
       mov       r14,[rbp-48]
       xor       ecx,ecx
       mov       [rbp-48],rcx
       mov       rdi,[rbp-0D0]
       mov       ebx,[rdi+8]
       test      ebx,ebx
       jl        near ptr M01_L106
       mov       esi,ebx
       test      r14,r14
       je        short M01_L04
       mov       r15,[rdi]
       cmp       r15,[r14]
       je        near ptr M01_L56
M01_L04:
       mov       r15,[rdi]
       mov       rcx,r15
       mov       eax,[rcx+4]
       add       eax,0FFFFFFE8
       shr       eax,3
       mov       ecx,eax
       test      ecx,ecx
       jne       near ptr M01_L22
       xor       r13d,r13d
M01_L05:
       test      r14,r14
       je        near ptr M01_L24
       mov       rcx,[r14]
       mov       ecx,[rcx+4]
       add       ecx,0FFFFFFE8
       shr       ecx,3
       jne       near ptr M01_L23
       xor       r12d,r12d
M01_L06:
       mov       rdx,r14
M01_L07:
       test      rdx,rdx
       je        near ptr M01_L58
       cmp       r15,[rdx]
       je        short M01_L08
       mov       ecx,eax
       mov       r8d,1
       test      ecx,ecx
       cmove     ecx,r8d
       mov       r8,[rdx]
       mov       r8d,[r8+4]
       add       r8d,0FFFFFFE8
       shr       r8d,3
       mov       r10d,1
       test      r8d,r8d
       cmove     r8d,r10d
       cmp       ecx,r8d
       jne       near ptr M01_L59
M01_L08:
       test      esi,esi
       jl        near ptr M01_L60
       test      eax,eax
       jne       near ptr M01_L25
       xor       r8d,r8d
M01_L09:
       cmp       r13d,r8d
       jl        near ptr M01_L61
       sub       r13d,r8d
       js        near ptr M01_L62
       lea       ecx,[rsi+r13]
       cmp       ecx,ebx
       ja        near ptr M01_L62
       mov       rcx,[rdx]
       mov       ecx,[rcx+4]
       add       ecx,0FFFFFFE8
       shr       ecx,3
       jne       near ptr M01_L26
       xor       ebx,ebx
M01_L10:
       cmp       r12d,ebx
       jl        near ptr M01_L63
       sub       r12d,ebx
       js        near ptr M01_L64
       lea       ecx,[r12+rsi]
       cmp       ecx,[rdx+8]
       ja        near ptr M01_L64
       cmp       r15,[rdx]
       je        short M01_L11
       mov       rcx,rdi
       mov       [rbp-0D8],rdx
       call      qword ptr [7FFB6D93F2B8]; System.Array.CanAssignArrayType(System.Array, System.Array)
       test      eax,eax
       jne       near ptr M01_L74
       mov       rdx,[rbp-0D8]
M01_L11:
       mov       rcx,r15
       movzx     r8d,word ptr [rcx]
       mov       eax,esi
       imul      rax,r8
       lea       r10,[rdi+8]
       mov       r9d,[r15+4]
       add       r9,0FFFFFFFFFFFFFFF0
       add       r10,r9
       mov       r9d,r13d
       imul      r9,r8
       add       r9,r10
       lea       r10,[rdx+8]
       mov       rdx,[rdx]
       mov       edx,[rdx+4]
       add       rdx,0FFFFFFFFFFFFFFF0
       add       rdx,r10
       mov       r10d,r12d
       imul      r8,r10
       add       r8,rdx
       test      dword ptr [rcx],1000000
       jne       near ptr M01_L65
       mov       rcx,r8
       mov       rdx,r9
       mov       r10,rax
       mov       r11,rcx
       sub       r11,rdx
       cmp       r11,r10
       jb        near ptr M01_L72
       mov       r11,rdx
       sub       r11,rcx
       cmp       r11,r10
       jb        near ptr M01_L72
       lea       r11,[rdx+r10]
       lea       rbx,[rcx+r10]
       cmp       r10,10
       ja        near ptr M01_L27
       test      al,18
       jne       near ptr M01_L67
       test      al,4
       je        near ptr M01_L68
       mov       eax,[r9]
       mov       [r8],eax
       mov       r9d,[r11-4]
       mov       [rbx-4],r9d
M01_L12:
       mov       rbx,[rbp-0C8]
       mov       rcx,[rbx+18]
       test      cl,2
       jne       near ptr M01_L30
       mov       rcx,[rcx+10]
       mov       rax,offset MT_System.Enum
       cmp       rcx,rax
       sete      cl
       movzx     ecx,cl
M01_L13:
       test      ecx,ecx
       je        near ptr M01_L75
       mov       rcx,rbx
       call      qword ptr [7FFB6D93D248]; System.Enum.GetNamesNoCopy(System.RuntimeType)
       test      rax,rax
       je        near ptr M01_L31
       lea       rsi,[rax+10]
       mov       ebx,[rax+8]
M01_L14:
       test      ebx,ebx
       jne       near ptr M01_L32
       test      byte ptr [7FFB6DA0BEE8],1
       je        near ptr M01_L76
M01_L15:
       mov       rdx,15880400148
       mov       rdi,[rdx]
M01_L16:
       mov       rcx,offset MT_System.Collections.Generic.List<System.ValueTuple<System.String, System.Int32>>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       edx,[r14+8]
       test      edx,edx
       jl        near ptr M01_L106
       test      edx,edx
       jl        near ptr M01_L79
       test      edx,edx
       je        near ptr M01_L80
       mov       rcx,offset MT_System.ValueTuple<System.String, System.Int32>[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M01_L17:
       xor       esi,esi
M01_L18:
       mov       ecx,[r14+8]
       test      ecx,ecx
       jl        near ptr M01_L106
       cmp       esi,ecx
       jge       near ptr M01_L46
       cmp       esi,[rdi+8]
       jae       near ptr M01_L105
       mov       r15,[rdi+rsi*8+10]
       mov       rcx,[r14]
       mov       ecx,[rcx+4]
       lea       eax,[rcx-18]
       shr       eax,3
       jne       near ptr M01_L81
M01_L19:
       mov       eax,esi
       cmp       ecx,18
       je        short M01_L20
       mov       eax,esi
       sub       eax,[r14+14]
M01_L20:
       cmp       eax,[r14+8]
       jb        near ptr M01_L34
       call      qword ptr [7FFB6D9B7528]
       int       3
M01_L21:
       xor       ecx,ecx
       jmp       near ptr M01_L00
M01_L22:
       movsxd    rcx,ecx
       mov       r13d,[rdi+rcx*4+10]
       jmp       near ptr M01_L05
M01_L23:
       movsxd    rcx,ecx
       mov       r12d,[r14+rcx*4+10]
       jmp       near ptr M01_L06
M01_L24:
       xor       edx,edx
       xor       r12d,r12d
       mov       ecx,edx
       mov       rdx,r12
       mov       r12d,ecx
       jmp       near ptr M01_L07
M01_L25:
       movsxd    r8,eax
       mov       r8d,[rdi+r8*4+10]
       mov       eax,r8d
       mov       r8d,eax
       jmp       near ptr M01_L09
M01_L26:
       movsxd    rcx,ecx
       mov       ebx,[rdx+rcx*4+10]
       jmp       near ptr M01_L10
M01_L27:
       cmp       r10,40
       ja        near ptr M01_L69
M01_L28:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r10,20
       ja        near ptr M01_L66
M01_L29:
       vmovups   xmm0,[r11-10]
       vmovups   [rbx-10],xmm0
       jmp       near ptr M01_L12
M01_L30:
       xor       ecx,ecx
       jmp       near ptr M01_L13
M01_L31:
       xor       esi,esi
       xor       ebx,ebx
       jmp       near ptr M01_L14
M01_L32:
       mov       edx,ebx
       mov       rcx,offset MT_System.String[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       lea       rcx,[rdi+10]
       mov       r8d,ebx
       shl       r8,3
       cmp       r8,4000
       ja        near ptr M01_L78
       mov       rdx,rsi
       call      00007FFBCCEFDC70
       cmp       dword ptr [7FFBCD253B10],0
       jne       near ptr M01_L77
M01_L33:
       jmp       near ptr M01_L16
M01_L34:
       movsxd    r13,eax
       mov       rcx,[r14]
       mov       r12,[rcx+30]
       test      r12b,2
       jne       near ptr M01_L99
       mov       rax,[r14]
       mov       eax,[rax+4]
       lea       rax,[r14+rax-8]
       mov       edx,[r12]
       and       edx,0C0000
       cmp       edx,40000
       jne       near ptr M01_L93
       movzx     edx,word ptr [rcx]
       imul      r13,rdx
       add       r13,rax
       mov       ecx,[r12]
       and       ecx,0F0000
       cmp       ecx,50000
       je        near ptr M01_L92
       cmp       [r13],r13b
       mov       rcx,r12
       call      00007FFBCCF5A880
       test      rax,rax
       je        near ptr M01_L82
M01_L35:
       mov       rdx,rax
       mov       [rbp-0E0],rdx
       test      dword ptr [r12],1000000
       jne       near ptr M01_L83
       cmp       [rdx],dl
       lea       rax,[rdx+8]
       mov       [rbp-0F0],rax
       mov       [rbp-0E8],r13
       mov       rcx,r12
       call      00007FFBCCF6A940
       mov       r8d,eax
       mov       r12,[rbp-0F0]
       mov       rcx,[rbp-0E8]
       mov       rdx,r12
       sub       rdx,rcx
       cmp       rdx,r8
       jb        near ptr M01_L90
       mov       rdx,rcx
       sub       rdx,r12
       cmp       rdx,r8
       jb        near ptr M01_L90
       lea       rdx,[rcx+r8]
       lea       rax,[r12+r8]
       cmp       r8,10
       ja        near ptr M01_L40
       test      r8b,18
       jne       near ptr M01_L85
       test      r8b,4
       je        near ptr M01_L86
       mov       r8d,[r13]
       mov       [r12],r8d
       mov       edx,[rdx-4]
       mov       [rax-4],edx
M01_L36:
       mov       r13,[rbp-0E0]
M01_L37:
       mov       rdx,r13
M01_L38:
       mov       rcx,1586A400100
       mov       r13,[rcx]
       test      rdx,rdx
       je        near ptr M01_L96
       mov       rcx,rdx
       test      rcx,rcx
       je        short M01_L39
       mov       rax,offset MT_System.StringComparison
       cmp       [rcx],rax
       jne       near ptr M01_L94
M01_L39:
       mov       rax,offset MT_System.StringComparison
       cmp       [rcx],rax
       jne       near ptr M01_L95
       call      qword ptr [7FFB6D93F378]; System.Enum.GetValue()
       test      rax,rax
       je        short M01_L43
       mov       rdx,rax
       mov       rcx,offset MT_System.IConvertible
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastInterface(Void*, System.Object)
       mov       rcx,rax
       mov       r11,7FFB6D230A98
       xor       edx,edx
       call      qword ptr [r11]
       mov       r12d,eax
       jmp       short M01_L44
M01_L40:
       cmp       r8,40
       ja        near ptr M01_L87
M01_L41:
       vmovups   xmm0,[rcx]
       vmovups   [r12],xmm0
       cmp       r8,20
       ja        near ptr M01_L84
M01_L42:
       vmovups   xmm0,[rdx-10]
       vmovups   [rax-10],xmm0
       jmp       near ptr M01_L36
M01_L43:
       xor       r12d,r12d
M01_L44:
       inc       dword ptr [rbx+14]
       mov       rcx,[rbx+8]
       mov       edx,[rbx+10]
       cmp       [rcx+8],edx
       jbe       near ptr M01_L97
       lea       eax,[rdx+1]
       mov       [rbx+10],eax
       cmp       edx,[rcx+8]
       jae       near ptr M01_L105
       shl       rdx,4
       lea       r13,[rcx+rdx+10]
       mov       rcx,r13
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       [r13+8],r12d
M01_L45:
       add       esi,1
       jo        near ptr M01_L106
       jmp       near ptr M01_L18
M01_L46:
       mov       rcx,offset MT_System.Collections.Generic.List<System.ValueTuple<System.String, System.Int32>>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,158804000F0
       mov       rcx,[rcx]
       mov       rdi,rcx
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r14d,[rbx+10]
       test      r14d,r14d
       jle       near ptr M01_L50
       mov       ecx,[rdi+8]
       mov       r15d,[rsi+10]
       sub       ecx,r15d
       cmp       ecx,r14d
       jge       short M01_L48
       mov       ecx,r15d
       add       ecx,r14d
       jo        near ptr M01_L106
       cmp       dword ptr [rdi+8],0
       je        near ptr M01_L100
       mov       edx,[rdi+8]
       add       edx,edx
M01_L47:
       mov       eax,7FFFFFC7
       cmp       edx,7FFFFFC7
       cmova     edx,eax
       cmp       edx,ecx
       cmovl     edx,ecx
       cmp       edx,r15d
       jl        near ptr M01_L53
       cmp       [rdi+8],edx
       je        short M01_L48
       test      edx,edx
       jg        near ptr M01_L51
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
M01_L48:
       mov       r8,[rsi+8]
       mov       r9d,[rsi+10]
       mov       rcx,[rbx+8]
       mov       ebx,[rbx+10]
       test      rcx,rcx
       je        near ptr M01_L104
       test      r8,r8
       je        near ptr M01_L104
       mov       rdx,[rcx]
       cmp       rdx,[r8]
       jne       near ptr M01_L104
       cmp       dword ptr [rdx+4],18
       jne       near ptr M01_L104
       mov       eax,ebx
       or        eax,r9d
       jl        near ptr M01_L104
       cmp       ebx,[rcx+8]
       ja        near ptr M01_L104
       lea       eax,[r9+rbx]
       cmp       eax,[r8+8]
       ja        near ptr M01_L104
       movzx     eax,word ptr [rdx]
       mov       r10d,ebx
       imul      r10,rax
       add       rcx,10
       mov       r11,rcx
       mov       ecx,r9d
       imul      rcx,rax
       lea       rcx,[r8+rcx+10]
       test      dword ptr [rdx],1000000
       je        near ptr M01_L103
       cmp       r10,4000
       ja        near ptr M01_L102
       mov       rdx,r11
       mov       r8,r10
       call      00007FFBCCEFDC70
       cmp       dword ptr [7FFBCD253B10],0
       jne       near ptr M01_L101
M01_L49:
       add       [rsi+10],r14d
       inc       dword ptr [rsi+14]
M01_L50:
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<System.ValueTuple<System.String, System.Int32>>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
       vzeroupper
       add       rsp,0E8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L51:
       movsxd    rdx,edx
       mov       rcx,offset MT_System.ValueTuple<System.String, System.Int32>[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r13,rax
       test      r15d,r15d
       jle       short M01_L52
       mov       rcx,rdi
       mov       r8d,r15d
       mov       rdx,r13
       call      qword ptr [7FFB6D455050]; System.Array.Copy(System.Array, System.Array, Int32)
M01_L52:
       lea       rcx,[rsi+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L48
M01_L53:
       mov       ecx,7
       mov       edx,0F
       call      qword ptr [7FFB6D865AA0]
       int       3
M01_L54:
       mov       ecx,0B3
       mov       rdx,7FFB6D224000
       call      qword ptr [7FFB6D507798]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FFB6D9B5DA0]
       int       3
M01_L55:
       xor       ecx,ecx
       jmp       near ptr M01_L01
M01_L56:
       cmp       dword ptr [r15+4],18
       jne       near ptr M01_L04
       cmp       esi,ebx
       ja        near ptr M01_L04
       cmp       esi,[r14+8]
       ja        near ptr M01_L04
       mov       r8d,esi
       movzx     ecx,word ptr [r15]
       imul      r8,rcx
       lea       rdx,[rdi+10]
       lea       rcx,[r14+10]
       test      dword ptr [r15],1000000
       je        short M01_L57
       call      qword ptr [7FFB6D2E57A0]; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L12
M01_L57:
       call      qword ptr [7FFB6D2E5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L12
M01_L58:
       mov       ecx,145
       mov       rdx,7FFB6D224000
       call      qword ptr [7FFB6D507798]
       mov       rcx,rax
       call      qword ptr [7FFB6D9B5DD0]
       int       3
M01_L59:
       mov       rcx,offset MT_System.RankException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB6D9B7BB8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFB6D9B7BD0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M01_L60:
       mov       ecx,0B3
       mov       rdx,7FFB6D224000
       call      qword ptr [7FFB6D507798]
       mov       rdx,rax
       mov       ecx,esi
       call      qword ptr [7FFB6D9B5DA0]
       int       3
M01_L61:
       mov       [rbp-64],r8d
       mov       ecx,167
       mov       rdx,7FFB6D224000
       call      qword ptr [7FFB6D507798]
       mov       r8,rax
       mov       edx,[rbp-64]
       mov       ecx,r13d
       call      qword ptr [7FFB6D9B7B70]
       int       3
M01_L62:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFB6D9B7BE8]
       mov       rsi,rax
       mov       ecx,12D
       mov       rdx,7FFB6D224000
       call      qword ptr [7FFB6D507798]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFB6D666010]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L63:
       mov       ecx,17F
       mov       rdx,7FFB6D224000
       call      qword ptr [7FFB6D507798]
       mov       r8,rax
       mov       edx,ebx
       mov       ecx,r12d
       call      qword ptr [7FFB6D9B7B70]
       int       3
M01_L64:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFB6D9B7C00]
       mov       rsi,rax
       mov       ecx,145
       mov       rdx,7FFB6D224000
       call      qword ptr [7FFB6D507798]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFB6D666010]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L65:
       mov       rcx,r8
       mov       rdx,r9
       mov       r8,rax
       call      qword ptr [7FFB6D2E57A0]; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L12
M01_L66:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r10,30
       jbe       near ptr M01_L29
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       near ptr M01_L29
M01_L67:
       mov       r10,[r9]
       mov       [r8],r10
       mov       r8,[r11-8]
       mov       [rbx-8],r8
       jmp       near ptr M01_L12
M01_L68:
       test      rax,rax
       je        near ptr M01_L12
       movzx     r9d,byte ptr [r9]
       mov       [r8],r9b
       test      al,2
       je        near ptr M01_L12
       movsx     r8,word ptr [r11-2]
       mov       [rbx-2],r8w
       jmp       near ptr M01_L12
M01_L69:
       cmp       r10,800
       ja        near ptr M01_L73
       cmp       r10,100
       jb        short M01_L70
       mov       rdx,r8
       and       rdx,3F
       mov       r10,rdx
       neg       r10
       add       r10,40
       vmovdqu   ymm0,ymmword ptr [r9]
       vmovdqu   ymmword ptr [r8],ymm0
       vmovdqu   ymm0,ymmword ptr [r9+20]
       vmovdqu   ymmword ptr [r8+20],ymm0
       lea       rdx,[r9+r10]
       lea       rcx,[r8+r10]
       sub       rax,r10
       mov       r10,rax
M01_L70:
       mov       r8,r10
       shr       r8,6
M01_L71:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r8
       jne       short M01_L71
       and       r10,3F
       cmp       r10,10
       ja        near ptr M01_L28
       jmp       near ptr M01_L29
M01_L72:
       cmp       r8,r9
       jne       short M01_L73
       cmp       [r9],r9b
       jmp       near ptr M01_L12
M01_L73:
       cmp       [r8],r8b
       cmp       [r9],r9b
       mov       rcx,r8
       mov       rdx,r9
       mov       r8,rax
       call      qword ptr [7FFB6D2E66E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L12
M01_L74:
       mov       [rsp+20],esi
       mov       [rsp+28],eax
       mov       rcx,rdi
       mov       edx,r13d
       mov       r8,[rbp-0D8]
       mov       r9d,r12d
       call      qword ptr [7FFB6D9B7C48]
       jmp       near ptr M01_L12
M01_L75:
       call      qword ptr [7FFB6D9B7660]
       int       3
M01_L76:
       mov       rcx,offset MT_System.Array+EmptyArray<System.String>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M01_L15
M01_L77:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M01_L33
M01_L78:
       mov       rdx,rsi
       call      qword ptr [7FFB6D86DE30]
       jmp       near ptr M01_L33
M01_L79:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FFB6D865AA0]
       int       3
M01_L80:
       mov       rcx,158804000F0
       mov       rsi,[rcx]
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L17
M01_L81:
       cmp       eax,1
       je        near ptr M01_L19
       jmp       near ptr M01_L98
M01_L82:
       mov       rcx,r12
       call      qword ptr [7FFB6D93FE40]; System.RuntimeTypeHandle.<InternalAllocNoChecks>g__InternalAllocNoChecksWorker|37_0(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M01_L35
M01_L83:
       cmp       [rdx],dl
       lea       rcx,[rdx+8]
       mov       r8d,[r12+4]
       add       r8d,0FFFFFFF0
       mov       rdx,r13
       call      qword ptr [7FFB6D2E57A0]; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L36
M01_L84:
       vmovups   xmm0,[rcx+10]
       vmovups   [r12+10],xmm0
       cmp       r8,30
       jbe       near ptr M01_L42
       vmovups   xmm0,[rcx+20]
       vmovups   [r12+20],xmm0
       jmp       near ptr M01_L42
M01_L85:
       mov       r8,[r13]
       mov       [r12],r8
       mov       rdx,[rdx-8]
       mov       [rax-8],rdx
       jmp       near ptr M01_L36
M01_L86:
       test      r8,r8
       je        near ptr M01_L36
       movzx     ecx,byte ptr [r13]
       mov       [r12],cl
       test      r8b,2
       je        near ptr M01_L36
       movsx     rdx,word ptr [rdx-2]
       mov       [rax-2],dx
       jmp       near ptr M01_L36
M01_L87:
       cmp       r8,800
       ja        near ptr M01_L91
       cmp       r8,100
       jb        short M01_L88
       mov       rcx,r12
       and       rcx,3F
       neg       rcx
       add       rcx,40
       vmovdqu   ymm0,ymmword ptr [r13]
       vmovdqu   ymmword ptr [r12],ymm0
       vmovdqu   ymm0,ymmword ptr [r13+20]
       vmovdqu   ymmword ptr [r12+20],ymm0
       add       r13,rcx
       add       r12,rcx
       sub       r8,rcx
       mov       rcx,r13
M01_L88:
       mov       r10,r8
       shr       r10,6
M01_L89:
       vmovdqu   ymm0,ymmword ptr [rcx]
       vmovdqu   ymmword ptr [r12],ymm0
       vmovdqu   ymm0,ymmword ptr [rcx+20]
       vmovdqu   ymmword ptr [r12+20],ymm0
       add       r12,40
       add       rcx,40
       dec       r10
       jne       short M01_L89
       and       r8,3F
       cmp       r8,10
       ja        near ptr M01_L41
       jmp       near ptr M01_L42
M01_L90:
       cmp       r12,r13
       je        near ptr M01_L36
M01_L91:
       cmp       [r12],r12b
       mov       rcx,r12
       mov       rdx,r13
       call      qword ptr [7FFB6D2E66E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L36
M01_L92:
       mov       rcx,r12
       mov       rdx,r13
       call      qword ptr [7FFB6D2E5878]; System.Runtime.CompilerServices.CastHelpers.Box_Nullable(System.Runtime.CompilerServices.MethodTable*, Byte ByRef)
       mov       rdx,rax
       mov       r13,rdx
       jmp       near ptr M01_L37
M01_L93:
       mov       rdx,[rax+r13*8]
       jmp       near ptr M01_L38
M01_L94:
       mov       rcx,offset MT_System.IConvertible
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastInterface(Void*, System.Object)
       mov       rcx,rax
       jmp       near ptr M01_L39
M01_L95:
       mov       rdx,r13
       mov       r11,7FFB6D230A90
       call      qword ptr [r11]
       mov       r12d,eax
       jmp       near ptr M01_L44
M01_L96:
       xor       r12d,r12d
       jmp       near ptr M01_L44
M01_L97:
       mov       [rbp-0C0],r15
       mov       [rbp-0B8],r12d
       lea       rdx,[rbp-0C0]
       mov       rcx,rbx
       call      qword ptr [7FFB6D9B7618]
       jmp       near ptr M01_L45
M01_L98:
       mov       ecx,3A
       call      qword ptr [7FFB6D9B7510]
       int       3
M01_L99:
       mov       ecx,43
       call      qword ptr [7FFB6D936208]
       int       3
M01_L100:
       mov       edx,4
       jmp       near ptr M01_L47
M01_L101:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M01_L49
M01_L102:
       mov       rdx,r11
       mov       r8,r10
       call      qword ptr [7FFB6D86DE30]
       jmp       near ptr M01_L49
M01_L103:
       mov       rdx,r11
       mov       r8,r10
       call      qword ptr [7FFB6D2E5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L49
M01_L104:
       mov       [rsp+20],ebx
       xor       edx,edx
       mov       [rsp+28],edx
       call      qword ptr [7FFB6D93F2A0]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M01_L49
M01_L105:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M01_L106:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 3725
```

