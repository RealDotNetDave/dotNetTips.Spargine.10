## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rcx,26960C00118
       mov       rdi,[rcx]
       mov       rcx,26960C000F8
       mov       r14,[rcx]
       test      rdi,rdi
       je        near ptr M00_L09
M00_L00:
       mov       r15,[r14+8]
       mov       rcx,[r15+8]
       cmp       byte ptr [r14+19],0
       jne       near ptr M00_L06
       mov       rdx,rsi
       mov       r11,7FFA068E0AB8
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
       mov       rcx,offset MT_System.StringComparison
       cmp       [r10],rcx
       jne       near ptr M00_L11
       mov       rcx,r10
       mov       rdx,rsi
       call      qword ptr [7FFA068D60A0]; System.Enum.Equals(System.Object)
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
       mov       rcx,rsi
       mov       rax,[7FFA06AFCC48]
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
       mov       rcx,offset MT_System.StringComparison
       cmp       [r10],rcx
       jne       near ptr M00_L16
       mov       rcx,r10
       mov       rdx,rsi
       call      qword ptr [7FFA068D60A0]; System.Enum.Equals(System.Object)
M00_L08:
       test      eax,eax
       je        near ptr M00_L17
       jmp       near ptr M00_L04
M00_L09:
       mov       rcx,offset MT_System.Func<System.Enum, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,26960C00110
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Core.EnumHelper+<>c.<GetDescription>b__3_0(System.Enum)
       call      qword ptr [7FFA06996BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,26960C00118
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
       mov       r11,7FFA068E0AC0
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
       call      qword ptr [7FFA06D1C4C8]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryAddInternal(Tables<System.__Canon,System.__Canon>, System.__Canon, System.Nullable`1<Int32>, System.__Canon, Boolean, Boolean, System.__Canon ByRef)
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
       call      00007FFA665DF240
       add       eax,0FFFFFFFE
       cmp       eax,17
       ja        short M01_L03
       lea       rcx,[7FFA070F00C0]
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
       call      qword ptr [7FFA0699C9A8]; System.Object.GetType()
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
       mov       ecx,5379
       mov       rdx,7FFA06C65488
       call      qword ptr [7FFA06BB77B0]
       mov       [rbp-40],rax
       mov       ecx,1C97
       mov       rdx,7FFA06C65488
       call      qword ptr [7FFA06BB77B0]
       mov       [rbp-48],rax
       mov       rdx,[rbp-40]
       mov       r8,[rbp-48]
       mov       rcx,[rbp-30]
       call      qword ptr [7FFA06D16028]
       mov       rcx,[rbp-30]
       call      CORINFO_HELP_THROW
       int       3
; 			var name = Enum.GetName(type, key);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M02_L00:
       mov       rcx,[rbp-8]
       mov       rdx,[rbp+18]
       call      qword ptr [7FFA070754B8]; System.Enum.GetName(System.Type, System.Object)
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
       call      qword ptr [7FFA070754D0]; System.Type.GetField(System.String)
       mov       [rbp-18],rax
; 			if (field == null)
; 			^^^^^^^^^^^^^^^^^^
       mov       rcx,[rbp-18]
       xor       edx,edx
       call      qword ptr [7FFA070754E8]; System.Reflection.FieldInfo.op_Equality(System.Reflection.FieldInfo, System.Reflection.FieldInfo)
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
       mov       rcx,7FFA07089350
       xor       r8d,r8d
       call      qword ptr [7FFA06E95E60]; System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.MemberInfo, Boolean)
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
       call      qword ptr [7FFA06BBE268]; System.String.IsNullOrEmpty(System.String)
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
       mov       rcx,7FFA070893D8
       xor       r8d,r8d
       call      qword ptr [7FFA06E95E60]; System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.MemberInfo, Boolean)
       mov       [rbp-28],rax
; 			if (enumMemberAttr != null && !string.IsNullOrEmpty(enumMemberAttr.Value))
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       cmp       qword ptr [rbp-28],0
       je        short M02_L04
       mov       rcx,[rbp-28]
       cmp       [rcx],ecx
       call      qword ptr [7FFA07075518]
       mov       rcx,rax
       call      qword ptr [7FFA06BBE268]; System.String.IsNullOrEmpty(System.String)
       test      eax,eax
       jne       short M02_L04
; 				return enumMemberAttr.Value;
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,[rbp-28]
       cmp       [rcx],ecx
       call      qword ptr [7FFA07075518]
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
       call      qword ptr [7FFA0707C738]
       int       3
; Total bytes of code 44
```
```assembly
; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryAddInternal(Tables<System.__Canon,System.__Canon>, System.__Canon, System.Nullable`1<Int32>, System.__Canon, Boolean, Boolean, System.__Canon ByRef)
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
       mov       [rbp-60],rax
       mov       [rbp-40],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9
       mov       rdx,r8
       mov       rbx,[rbp+30]
       movzx     r9d,r9b
       mov       r11,[rbp+18]
       mov       r11,[r11+8]
       mov       [rbp-60],r11
       mov       r8d,[rbp+2C]
       test      r9d,r9d
       je        short M04_L00
       jmp       short M04_L03
M04_L00:
       cmp       byte ptr [rcx+19],0
       je        short M04_L01
       mov       rcx,rdx
       lea       r11,[System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GetOrAdd[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.Func`3<System.__Canon,System.__Canon,System.__Canon>, System.__Canon)]
       cmp       [rcx],ecx
       call      qword ptr [r11]
       mov       r8d,eax
       jmp       short M04_L02
M04_L01:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx]
       call      qword ptr [7FFADB3CA738]
       mov       rcx,[rbp-60]
       mov       r11,rax
       mov       rdx,[rbp+20]
       call      qword ptr [rax]
       mov       r8d,eax
M04_L02:
       mov       rcx,[rbp+10]
       mov       rdx,[rbp+20]
M04_L03:
       mov       [rbp-44],r8d
       jmp       short M04_L06
M04_L04:
       call      M04_L24
       nop
       mov       eax,[rbp-54]
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
M04_L05:
       call      M04_L24
       nop
M04_L06:
       mov       rax,[rbp+18]
       mov       rcx,[rax+18]
       mov       [rbp-68],rcx
       mov       rbx,[rbp+10]
       cmp       [rbx],ebx
       mov       rax,[rbp+18]
       mov       r8,[rax+10]
       mov       rax,[rbp+18]
       mov       r10d,[rbp-44]
       imul      r10,[rax+28]
       shr       r10,20
       inc       r10
       mov       r9d,[r8+8]
       mov       r11d,r9d
       imul      r10,r11
       shr       r10,20
       mov       eax,r10d
       xor       edx,edx
       div       dword ptr [rcx+8]
       mov       [rbp-48],edx
       cmp       r10d,r9d
       jae       near ptr M04_L23
       mov       ecx,r10d
       lea       rsi,[r8+rcx*8+10]
       xor       edi,edi
       xor       r14d,r14d
       xor       ecx,ecx
       mov       [rbp-50],ecx
       cmp       byte ptr [rbp+40],0
       je        short M04_L07
       mov       rcx,[rbp-68]
       mov       ecx,[rcx+8]
       cmp       [rbp-48],ecx
       jae       near ptr M04_L18
       mov       rcx,[rbp-68]
       mov       edx,[rbp-48]
       mov       rcx,[rcx+rdx*8+10]
       lea       rdx,[rbp-50]
       call      qword ptr [7FFADB3CAB78]; Precode of System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
M04_L07:
       mov       rcx,[rbp+18]
       cmp       rcx,[rbx+8]
       jne       near ptr M04_L15
       xor       r15d,r15d
       mov       r13,[rsi]
       test      r13,r13
       je        short M04_L10
M04_L08:
       mov       ecx,[rbp-44]
       cmp       ecx,[r13+20]
       jne       short M04_L09
       mov       rcx,[rbx]
       call      qword ptr [7FFADB3CA3D8]
       mov       rcx,rax
       call      qword ptr [7FFADB3CA910]
       mov       rdx,[r13+8]
       mov       rcx,[rbp-60]
       mov       r11,rax
       mov       r8,[rbp+20]
       call      qword ptr [rax]
       test      eax,eax
       jne       near ptr M04_L12
M04_L09:
       inc       r15d
       mov       r13,[r13+18]
       test      r13,r13
       jne       short M04_L08
M04_L10:
       mov       rcx,[rbx]
       call      qword ptr [7FFADB3CA430]
       mov       rcx,rax
       call      qword ptr [7FFADB3CA280]; CORINFO_HELP_NEWFAST
       mov       r13,rax
       mov       r12,[rsi]
       lea       rcx,[r13+8]
       mov       rdx,[rbp+20]
       call      qword ptr [7FFADB3CA258]; CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r13+10]
       mov       rdx,[rbp+30]
       call      qword ptr [7FFADB3CA258]; CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r13+18]
       mov       rdx,r12
       call      qword ptr [7FFADB3CA258]; CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rbp-44]
       mov       [r13+20],ecx
       mov       rcx,rsi
       mov       rdx,r13
       call      qword ptr [7FFADB3CA258]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+20]
       mov       eax,[rcx+8]
       cmp       [rbp-48],eax
       jae       near ptr M04_L18
       mov       eax,[rbp-48]
       lea       rcx,[rcx+rax*4+10]
       mov       eax,[rcx]
       add       eax,1
       jo        near ptr M04_L19
       mov       [rcx],eax
       cmp       eax,[rbx+10]
       jle       short M04_L11
       mov       edi,1
M04_L11:
       cmp       r15d,64
       jbe       near ptr M04_L20
       mov       rcx,[rbp-60]
       call      qword ptr [7FFADB3CAA38]
       test      rax,rax
       je        near ptr M04_L20
       mov       r14d,1
       jmp       near ptr M04_L20
M04_L12:
       cmp       byte ptr [rbp+38],0
       jne       short M04_L13
       mov       rdx,[r13+10]
       mov       rcx,[rbp+48]
       call      qword ptr [7FFADB3CA260]; CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       short M04_L14
M04_L13:
       lea       rcx,[r13+10]
       mov       rdx,[rbp+30]
       call      qword ptr [7FFADB3CA258]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+48]
       mov       rdx,[rbp+30]
       call      qword ptr [7FFADB3CA260]; CORINFO_HELP_CHECKED_ASSIGN_REF
M04_L14:
       xor       ecx,ecx
       mov       [rbp-54],ecx
       jmp       near ptr M04_L04
M04_L15:
       mov       rcx,[rbx+8]
       mov       [rbp+18],rcx
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+8]
       cmp       [rbp-60],rcx
       je        near ptr M04_L05
       mov       [rbp-60],rcx
       cmp       byte ptr [rbx+19],0
       je        short M04_L16
       mov       rcx,[rbp+20]
       lea       r11,[System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GetOrAdd[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.Func`3<System.__Canon,System.__Canon,System.__Canon>, System.__Canon)]
       cmp       [rcx],ecx
       call      qword ptr [r11]
       jmp       short M04_L17
M04_L16:
       mov       rcx,[rbx]
       call      qword ptr [7FFADB3CA738]
       mov       rcx,[rbp-60]
       mov       r11,rax
       mov       rdx,[rbp+20]
       call      qword ptr [rax]
M04_L17:
       mov       [rbp-44],eax
       jmp       near ptr M04_L05
M04_L18:
       call      qword ptr [7FFADB3CA250]
       int       3
M04_L19:
       call      qword ptr [7FFADB3CA248]
       int       3
M04_L20:
       cmp       byte ptr [rbp-50],0
       je        short M04_L21
       mov       rcx,[rbp-68]
       mov       ecx,[rcx+8]
       cmp       [rbp-48],ecx
       jae       short M04_L23
       mov       rcx,[rbp-68]
       mov       eax,[rbp-48]
       mov       rcx,[rcx+rax*8+10]
       call      qword ptr [7FFADB3CAB80]; Precode of System.Threading.Monitor.Exit(System.Object)
M04_L21:
       mov       ecx,edi
       or        ecx,r14d
       je        short M04_L22
       mov       rcx,rbx
       mov       rdx,[rbp+18]
       mov       r8d,edi
       mov       r9d,r14d
       call      qword ptr [7FFADB3CB168]
M04_L22:
       mov       rcx,[rbp+48]
       mov       rdx,[rbp+30]
       call      qword ptr [7FFADB3CA260]; CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       eax,1
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
M04_L23:
       call      qword ptr [7FFADB3CA250]
       int       3
M04_L24:
       sub       rsp,28
       cmp       byte ptr [rbp-50],0
       je        short M04_L25
       mov       rcx,[rbp-68]
       mov       ecx,[rcx+8]
       cmp       [rbp-48],ecx
       jae       short M04_L26
       mov       rcx,[rbp-68]
       mov       eax,[rbp-48]
       mov       rcx,[rcx+rax*8+10]
       call      qword ptr [7FFADB3CAB80]; Precode of System.Threading.Monitor.Exit(System.Object)
M04_L25:
       nop
       add       rsp,28
       ret
M04_L26:
       call      qword ptr [7FFADB3CA250]
       int       3
; Total bytes of code 908
```

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       call      qword ptr [7FFA06FC7198]; DotNetTips.Spargine.Extensions.EnumExtensions.GetItems(System.Enum)
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
       call      qword ptr [7FFA069AC9A8]; System.Object.GetType()
       mov       rbx,rax
       mov       [rbp-0C8],rbx
       mov       rcx,[rbx+18]
       test      cl,2
       jne       near ptr M01_L10
       mov       rcx,[rcx+10]
       mov       rax,offset MT_System.Enum
       cmp       rcx,rax
       sete      cl
       movzx     ecx,cl
M01_L00:
       test      ecx,ecx
       je        near ptr M01_L73
       mov       rcx,rbx
       call      qword ptr [7FFA06FC7270]; System.Enum.GetValuesAsUnderlyingTypeNoCopy(System.RuntimeType)
       mov       rdi,rax
       mov       [rbp-0D0],rdi
       mov       ecx,[rdi+8]
       test      ecx,ecx
       jl        near ptr M01_L107
       mov       [rbp-40],ecx
       mov       r14d,[rbp-40]
       test      r14d,r14d
       jl        near ptr M01_L53
       mov       [rbp-50],rbx
       xor       ecx,ecx
       mov       [rbp-48],rcx
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rbp-60],xmm0
       lea       rcx,[rbp-50]
       mov       [rbp-60],rcx
       mov       rcx,[rbp-50]
       test      rcx,rcx
       je        near ptr M01_L54
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
       mov       rax,7FFA069B1878
       mov       [rbp-90],rax
       lea       rax,[M01_L02]
       mov       [rbp-80],rax
       lea       rax,[rbp-0A0]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFA6650DB50
       vzeroupper
       call      rax
M01_L02:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFA668E3A10],0
       je        short M01_L03
       call      qword ptr [7FFA668D1648]; CORINFO_HELP_STOP_FOR_GC
M01_L03:
       mov       rcx,[rbp-98]
       mov       [rsi+8],rcx
       mov       r14,[rbp-48]
       xor       ecx,ecx
       mov       [rbp-48],rcx
       mov       rdi,[rbp-0D0]
       mov       ecx,[rdi+8]
       test      ecx,ecx
       jl        near ptr M01_L107
       mov       ebx,ecx
       test      r14,r14
       je        short M01_L04
       mov       rsi,[rdi]
       cmp       rsi,[r14]
       je        near ptr M01_L55
M01_L04:
       mov       rsi,[rdi]
       mov       rcx,rsi
       mov       eax,[rcx+4]
       add       eax,0FFFFFFE8
       shr       eax,3
       mov       ecx,eax
       test      ecx,ecx
       jne       near ptr M01_L11
       xor       r15d,r15d
M01_L05:
       test      r14,r14
       je        near ptr M01_L57
       mov       rcx,[r14]
       mov       ecx,[rcx+4]
       add       ecx,0FFFFFFE8
       shr       ecx,3
       jne       near ptr M01_L12
       xor       r13d,r13d
M01_L06:
       mov       r12,r14
M01_L07:
       test      r12,r12
       je        near ptr M01_L58
       cmp       rsi,[r12]
       je        short M01_L08
       mov       ecx,eax
       mov       edx,1
       test      ecx,ecx
       cmove     ecx,edx
       mov       rdx,[r12]
       mov       edx,[rdx+4]
       add       edx,0FFFFFFE8
       shr       edx,3
       mov       r8d,1
       test      edx,edx
       cmove     edx,r8d
       cmp       ecx,edx
       jne       near ptr M01_L59
M01_L08:
       test      ebx,ebx
       jl        near ptr M01_L60
       test      eax,eax
       jne       short M01_L13
       xor       r8d,r8d
M01_L09:
       mov       [rbp-64],r8d
       cmp       r15d,r8d
       jge       short M01_L14
       mov       ecx,167
       mov       rdx,7FFA068E4000
       call      qword ptr [7FFA06BC77B0]
       mov       r8,rax
       mov       edx,[rbp-64]
       mov       ecx,r15d
       call      qword ptr [7FFA07054558]
       int       3
M01_L10:
       xor       ecx,ecx
       jmp       near ptr M01_L00
M01_L11:
       movsxd    rcx,ecx
       mov       r15d,[rdi+rcx*4+10]
       jmp       near ptr M01_L05
M01_L12:
       movsxd    rcx,ecx
       mov       r13d,[r14+rcx*4+10]
       jmp       near ptr M01_L06
M01_L13:
       movsxd    r8,eax
       mov       r8d,[rdi+r8*4+10]
       mov       eax,r8d
       mov       r8d,eax
       jmp       short M01_L09
M01_L14:
       sub       r15d,[rbp-64]
       js        near ptr M01_L61
       lea       ecx,[r15+rbx]
       cmp       ecx,[rdi+8]
       ja        near ptr M01_L61
       mov       rcx,[r12]
       mov       ecx,[rcx+4]
       add       ecx,0FFFFFFE8
       shr       ecx,3
       jne       short M01_L16
       xor       eax,eax
M01_L15:
       mov       [rbp-68],eax
       cmp       r13d,eax
       jge       short M01_L17
       mov       ecx,17F
       mov       rdx,7FFA068E4000
       call      qword ptr [7FFA06BC77B0]
       mov       r8,rax
       mov       edx,[rbp-68]
       mov       ecx,r13d
       call      qword ptr [7FFA07054558]
       int       3
M01_L16:
       movsxd    rax,ecx
       mov       eax,[r12+rax*4+10]
       jmp       short M01_L15
M01_L17:
       sub       r13d,[rbp-68]
       js        near ptr M01_L62
       lea       ecx,[rbx+r13]
       cmp       ecx,[r12+8]
       ja        near ptr M01_L62
       cmp       rsi,[r12]
       je        short M01_L18
       mov       rcx,rdi
       mov       rdx,r12
       call      qword ptr [7FFA06FC7348]; System.Array.CanAssignArrayType(System.Array, System.Array)
       test      eax,eax
       jne       near ptr M01_L72
M01_L18:
       mov       rcx,rsi
       movzx     edx,word ptr [rcx]
       mov       r8d,ebx
       imul      r8,rdx
       lea       rax,[rdi+8]
       mov       r10d,[rsi+4]
       add       r10,0FFFFFFFFFFFFFFF0
       add       rax,r10
       mov       r10d,r15d
       imul      r10,rdx
       add       r10,rax
       lea       rax,[r12+8]
       mov       r9,[r12]
       mov       r9d,[r9+4]
       add       r9,0FFFFFFFFFFFFFFF0
       add       rax,r9
       mov       r9d,r13d
       imul      rdx,r9
       add       rdx,rax
       test      dword ptr [rcx],1000000
       jne       near ptr M01_L63
       mov       rcx,rdx
       mov       rax,r10
       mov       r9,r8
       mov       r11,rcx
       sub       r11,rax
       cmp       r11,r9
       jb        near ptr M01_L70
       mov       r11,rax
       sub       r11,rcx
       cmp       r11,r9
       jb        near ptr M01_L70
       lea       r11,[rax+r9]
       lea       rbx,[rcx+r9]
       cmp       r9,10
       ja        near ptr M01_L28
       test      r8b,18
       jne       near ptr M01_L65
       test      r8b,4
       je        near ptr M01_L66
       mov       r8d,[r10]
       mov       [rdx],r8d
       mov       r10d,[r11-4]
       mov       [rbx-4],r10d
M01_L19:
       mov       rbx,[rbp-0C8]
       mov       rcx,[rbx+18]
       test      cl,2
       jne       near ptr M01_L31
       mov       rcx,[rcx+10]
       mov       rax,offset MT_System.Enum
       cmp       rcx,rax
       sete      cl
       movzx     ecx,cl
M01_L20:
       test      ecx,ecx
       je        near ptr M01_L73
       mov       rcx,rbx
       call      qword ptr [7FFA06FC53C8]; System.Enum.GetNamesNoCopy(System.RuntimeType)
       test      rax,rax
       je        near ptr M01_L32
       lea       rbx,[rax+10]
       mov       esi,[rax+8]
M01_L21:
       test      esi,esi
       jne       near ptr M01_L33
       test      byte ptr [7FFA07061EE8],1
       je        near ptr M01_L74
M01_L22:
       mov       rdx,24537C020F8
       mov       rdi,[rdx]
M01_L23:
       mov       rcx,offset MT_System.Collections.Generic.List<System.ValueTuple<System.String, System.Int32>>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       edx,[r14+8]
       test      edx,edx
       jl        near ptr M01_L107
       test      edx,edx
       jl        near ptr M01_L77
       test      edx,edx
       je        near ptr M01_L78
       mov       rcx,offset MT_System.ValueTuple<System.String, System.Int32>[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M01_L24:
       xor       esi,esi
M01_L25:
       mov       ecx,[r14+8]
       test      ecx,ecx
       jl        near ptr M01_L107
       mov       eax,ecx
       cmp       esi,eax
       jge       near ptr M01_L47
       cmp       esi,[rdi+8]
       jae       near ptr M01_L106
       mov       r15,[rdi+rsi*8+10]
       mov       rax,[r14]
       mov       eax,[rax+4]
       lea       edx,[rax-18]
       shr       edx,3
       jne       near ptr M01_L79
M01_L26:
       mov       edx,esi
       cmp       eax,18
       je        short M01_L27
       mov       edx,esi
       sub       edx,[r14+14]
M01_L27:
       cmp       edx,ecx
       jb        near ptr M01_L35
       call      qword ptr [7FFA06FCFE28]
       int       3
M01_L28:
       cmp       r9,40
       ja        near ptr M01_L67
M01_L29:
       vmovups   xmm0,[rax]
       vmovups   [rcx],xmm0
       cmp       r9,20
       ja        near ptr M01_L64
M01_L30:
       vmovups   xmm0,[r11-10]
       vmovups   [rbx-10],xmm0
       jmp       near ptr M01_L19
M01_L31:
       xor       ecx,ecx
       jmp       near ptr M01_L20
M01_L32:
       xor       ebx,ebx
       xor       esi,esi
       jmp       near ptr M01_L21
M01_L33:
       mov       edx,esi
       mov       rcx,offset MT_System.String[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       lea       rcx,[rdi+10]
       mov       r8d,esi
       shl       r8,3
       cmp       r8,4000
       ja        near ptr M01_L76
       mov       rdx,rbx
       call      00007FFA665C1380
       cmp       dword ptr [7FFA668E3A10],0
       jne       near ptr M01_L75
M01_L34:
       jmp       near ptr M01_L23
M01_L35:
       movsxd    r13,edx
       mov       rcx,[r14]
       mov       r12,[rcx+30]
       test      r12b,2
       jne       near ptr M01_L97
       mov       rax,[r14]
       mov       eax,[rax+4]
       lea       rax,[r14+rax-8]
       mov       edx,[r12]
       mov       r8d,edx
       and       r8d,0C0000
       cmp       r8d,40000
       jne       near ptr M01_L91
       movzx     r8d,word ptr [rcx]
       imul      r13,r8
       add       r13,rax
       and       edx,0F0000
       cmp       edx,50000
       je        near ptr M01_L90
       cmp       [r13],r13b
       mov       rcx,r12
       call      00007FFA665E8E30
       test      rax,rax
       je        near ptr M01_L80
M01_L36:
       mov       rdx,rax
       mov       [rbp-0D8],rdx
       test      dword ptr [r12],1000000
       jne       near ptr M01_L81
       cmp       [rdx],dl
       lea       rax,[rdx+8]
       mov       [rbp-0E8],rax
       mov       [rbp-0E0],r13
       mov       rcx,r12
       call      00007FFA66602AC0
       mov       r8d,eax
       mov       r12,[rbp-0E8]
       mov       rcx,[rbp-0E0]
       mov       rdx,r12
       sub       rdx,rcx
       cmp       rdx,r8
       jb        near ptr M01_L88
       mov       rdx,rcx
       sub       rdx,r12
       cmp       rdx,r8
       jb        near ptr M01_L88
       lea       rdx,[rcx+r8]
       lea       rax,[r12+r8]
       cmp       r8,10
       ja        near ptr M01_L41
       test      r8b,18
       jne       near ptr M01_L83
       test      r8b,4
       je        near ptr M01_L84
       mov       r8d,[r13]
       mov       [r12],r8d
       mov       edx,[rdx-4]
       mov       [rax-4],edx
M01_L37:
       mov       r13,[rbp-0D8]
M01_L38:
       mov       rdx,r13
M01_L39:
       mov       rcx,24537C00100
       mov       r13,[rcx]
       test      rdx,rdx
       je        near ptr M01_L94
       mov       rcx,rdx
       test      rcx,rcx
       je        short M01_L40
       mov       rax,offset MT_System.StringComparison
       cmp       [rcx],rax
       jne       near ptr M01_L92
M01_L40:
       mov       rax,offset MT_System.StringComparison
       cmp       [rcx],rax
       jne       near ptr M01_L93
       call      qword ptr [7FFA06FC7408]; System.Enum.GetValue()
       test      rax,rax
       je        short M01_L44
       mov       rdx,rax
       mov       rcx,offset MT_System.IConvertible
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastInterface(Void*, System.Object)
       mov       rcx,rax
       mov       r11,7FFA068F09C8
       xor       edx,edx
       call      qword ptr [r11]
       mov       r12d,eax
       jmp       short M01_L45
M01_L41:
       cmp       r8,40
       ja        near ptr M01_L85
M01_L42:
       vmovups   xmm0,[rcx]
       vmovups   [r12],xmm0
       cmp       r8,20
       ja        near ptr M01_L82
M01_L43:
       vmovups   xmm0,[rdx-10]
       vmovups   [rax-10],xmm0
       jmp       near ptr M01_L37
M01_L44:
       xor       r12d,r12d
M01_L45:
       inc       dword ptr [rbx+14]
       mov       rcx,[rbx+8]
       mov       edx,[rbx+10]
       mov       eax,[rcx+8]
       cmp       eax,edx
       jbe       near ptr M01_L95
       lea       r8d,[rdx+1]
       mov       [rbx+10],r8d
       cmp       edx,eax
       jae       near ptr M01_L106
       shl       rdx,4
       lea       r13,[rcx+rdx+10]
       mov       rcx,r13
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       [r13+8],r12d
M01_L46:
       add       esi,1
       jo        near ptr M01_L107
       jmp       near ptr M01_L25
M01_L47:
       mov       rcx,offset MT_System.Collections.Generic.List<System.ValueTuple<System.String, System.Int32>>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,24537C020C8
       mov       rcx,[rcx]
       mov       rdi,rcx
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r14d,[rbx+10]
       test      r14d,r14d
       jle       near ptr M01_L52
       mov       ecx,[rdi+8]
       mov       r15d,[rsi+10]
       sub       ecx,r15d
       cmp       ecx,r14d
       jge       short M01_L50
       mov       ecx,r15d
       add       ecx,r14d
       jo        near ptr M01_L107
       cmp       dword ptr [rdi+8],0
       je        near ptr M01_L98
       mov       edx,[rdi+8]
       add       edx,edx
M01_L48:
       mov       eax,7FFFFFC7
       cmp       edx,7FFFFFC7
       cmova     edx,eax
       cmp       edx,ecx
       cmovl     edx,ecx
       cmp       edx,r15d
       jl        short M01_L49
       cmp       [rdi+8],edx
       je        short M01_L50
       test      edx,edx
       jle       near ptr M01_L101
       jmp       near ptr M01_L99
M01_L49:
       mov       ecx,7
       mov       edx,0F
       call      qword ptr [7FFA06F25D40]
       int       3
M01_L50:
       mov       r8,[rsi+8]
       mov       r9d,[rsi+10]
       mov       rcx,[rbx+8]
       mov       ebx,[rbx+10]
       test      rcx,rcx
       je        near ptr M01_L105
       test      r8,r8
       je        near ptr M01_L105
       mov       rdx,[rcx]
       cmp       rdx,[r8]
       jne       near ptr M01_L105
       cmp       dword ptr [rdx+4],18
       jne       near ptr M01_L105
       mov       eax,ebx
       or        eax,r9d
       jl        near ptr M01_L105
       cmp       ebx,[rcx+8]
       ja        near ptr M01_L105
       lea       eax,[r9+rbx]
       cmp       eax,[r8+8]
       ja        near ptr M01_L105
       movzx     eax,word ptr [rdx]
       mov       r10d,ebx
       imul      r10,rax
       add       rcx,10
       mov       r11,rcx
       mov       ecx,r9d
       imul      rcx,rax
       lea       rcx,[r8+rcx+10]
       test      dword ptr [rdx],1000000
       je        near ptr M01_L104
       cmp       r10,4000
       ja        near ptr M01_L103
       mov       rdx,r11
       mov       r8,r10
       call      00007FFA665C1380
       cmp       dword ptr [7FFA668E3A10],0
       jne       near ptr M01_L102
M01_L51:
       add       [rsi+10],r14d
       inc       dword ptr [rsi+14]
M01_L52:
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
M01_L53:
       mov       ecx,0B3
       mov       rdx,7FFA068E4000
       call      qword ptr [7FFA06BC77B0]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FFA06FCFEA0]
       int       3
M01_L54:
       xor       ecx,ecx
       jmp       near ptr M01_L01
M01_L55:
       cmp       dword ptr [rsi+4],18
       jne       near ptr M01_L04
       cmp       ebx,[rdi+8]
       ja        near ptr M01_L04
       cmp       ebx,[r14+8]
       ja        near ptr M01_L04
       mov       r8d,ebx
       movzx     ecx,word ptr [rsi]
       imul      r8,rcx
       lea       rdx,[rdi+10]
       lea       rcx,[r14+10]
       test      dword ptr [rsi],1000000
       je        short M01_L56
       call      qword ptr [7FFA069A57A0]; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L19
M01_L56:
       call      qword ptr [7FFA069A5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L19
M01_L57:
       xor       r12d,r12d
       xor       r13d,r13d
       jmp       near ptr M01_L07
M01_L58:
       mov       ecx,145
       mov       rdx,7FFA068E4000
       call      qword ptr [7FFA06BC77B0]
       mov       rcx,rax
       call      qword ptr [7FFA06FCFF60]
       int       3
M01_L59:
       mov       rcx,offset MT_System.RankException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA070545A0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA070545B8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L60:
       mov       ecx,0B3
       mov       rdx,7FFA068E4000
       call      qword ptr [7FFA06BC77B0]
       mov       rdx,rax
       mov       ecx,ebx
       call      qword ptr [7FFA06FCFEA0]
       int       3
M01_L61:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA070545D0]
       mov       rsi,rax
       mov       ecx,12D
       mov       rdx,7FFA068E4000
       call      qword ptr [7FFA06BC77B0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFA06D26028]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L62:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA070545E8]
       mov       rsi,rax
       mov       ecx,145
       mov       rdx,7FFA068E4000
       call      qword ptr [7FFA06BC77B0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFA06D26028]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L63:
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FFA069A57A0]; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L19
M01_L64:
       vmovups   xmm0,[rax+10]
       vmovups   [rcx+10],xmm0
       cmp       r9,30
       jbe       near ptr M01_L30
       vmovups   xmm0,[rax+20]
       vmovups   [rcx+20],xmm0
       jmp       near ptr M01_L30
M01_L65:
       mov       r9,[r10]
       mov       [rdx],r9
       mov       rdx,[r11-8]
       mov       [rbx-8],rdx
       jmp       near ptr M01_L19
M01_L66:
       test      r8,r8
       je        near ptr M01_L19
       movzx     r10d,byte ptr [r10]
       mov       [rdx],r10b
       test      r8b,2
       je        near ptr M01_L19
       movsx     rdx,word ptr [r11-2]
       mov       [rbx-2],dx
       jmp       near ptr M01_L19
M01_L67:
       cmp       r9,800
       ja        near ptr M01_L71
       cmp       r9,100
       jb        short M01_L68
       mov       rax,rdx
       and       rax,3F
       mov       r9,rax
       neg       r9
       add       r9,40
       vmovdqu   ymm0,ymmword ptr [r10]
       vmovdqu   ymmword ptr [rdx],ymm0
       vmovdqu   ymm0,ymmword ptr [r10+20]
       vmovdqu   ymmword ptr [rdx+20],ymm0
       lea       rax,[r10+r9]
       lea       rcx,[rdx+r9]
       sub       r8,r9
       mov       r9,r8
M01_L68:
       mov       rdx,r9
       shr       rdx,6
M01_L69:
       vmovdqu   ymm0,ymmword ptr [rax]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rax+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rax,40
       dec       rdx
       jne       short M01_L69
       and       r9,3F
       cmp       r9,10
       ja        near ptr M01_L29
       jmp       near ptr M01_L30
M01_L70:
       cmp       rdx,r10
       jne       short M01_L71
       cmp       [r10],r10b
       jmp       near ptr M01_L19
M01_L71:
       cmp       [rdx],dl
       cmp       [r10],r10b
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FFA069A66E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L19
M01_L72:
       mov       [rsp+20],ebx
       mov       [rsp+28],eax
       mov       rcx,rdi
       mov       edx,r15d
       mov       r8,r12
       mov       r9d,r13d
       call      qword ptr [7FFA07054630]
       jmp       near ptr M01_L19
M01_L73:
       call      qword ptr [7FFA06FCFFC0]
       int       3
M01_L74:
       mov       rcx,offset MT_System.Array+EmptyArray<System.String>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M01_L22
M01_L75:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M01_L34
M01_L76:
       mov       rdx,rbx
       call      qword ptr [7FFA06FCFAE0]
       jmp       near ptr M01_L34
M01_L77:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FFA06F25D40]
       int       3
M01_L78:
       mov       rcx,24537C020C8
       mov       rsi,[rcx]
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L24
M01_L79:
       cmp       edx,1
       je        near ptr M01_L26
       jmp       near ptr M01_L96
M01_L80:
       mov       rcx,r12
       call      qword ptr [7FFA06FC7FA8]; System.RuntimeTypeHandle.<InternalAllocNoChecks>g__InternalAllocNoChecksWorker|37_0(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M01_L36
M01_L81:
       cmp       [rdx],dl
       lea       rcx,[rdx+8]
       mov       r8d,[r12+4]
       add       r8d,0FFFFFFF0
       mov       rdx,r13
       call      qword ptr [7FFA069A57A0]; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L37
M01_L82:
       vmovups   xmm0,[rcx+10]
       vmovups   [r12+10],xmm0
       cmp       r8,30
       jbe       near ptr M01_L43
       vmovups   xmm0,[rcx+20]
       vmovups   [r12+20],xmm0
       jmp       near ptr M01_L43
M01_L83:
       mov       r8,[r13]
       mov       [r12],r8
       mov       rdx,[rdx-8]
       mov       [rax-8],rdx
       jmp       near ptr M01_L37
M01_L84:
       test      r8,r8
       je        near ptr M01_L37
       movzx     ecx,byte ptr [r13]
       mov       [r12],cl
       test      r8b,2
       je        near ptr M01_L37
       movsx     rdx,word ptr [rdx-2]
       mov       [rax-2],dx
       jmp       near ptr M01_L37
M01_L85:
       cmp       r8,800
       ja        near ptr M01_L89
       cmp       r8,100
       jb        short M01_L86
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
M01_L86:
       mov       r10,r8
       shr       r10,6
M01_L87:
       vmovdqu   ymm0,ymmword ptr [rcx]
       vmovdqu   ymmword ptr [r12],ymm0
       vmovdqu   ymm0,ymmword ptr [rcx+20]
       vmovdqu   ymmword ptr [r12+20],ymm0
       add       r12,40
       add       rcx,40
       dec       r10
       jne       short M01_L87
       and       r8,3F
       cmp       r8,10
       ja        near ptr M01_L42
       jmp       near ptr M01_L43
M01_L88:
       cmp       r12,r13
       je        near ptr M01_L37
M01_L89:
       cmp       [r12],r12b
       mov       rcx,r12
       mov       rdx,r13
       call      qword ptr [7FFA069A66E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L37
M01_L90:
       mov       rcx,r12
       mov       rdx,r13
       call      qword ptr [7FFA069A5878]; System.Runtime.CompilerServices.CastHelpers.Box_Nullable(System.Runtime.CompilerServices.MethodTable*, Byte ByRef)
       mov       rdx,rax
       mov       r13,rdx
       jmp       near ptr M01_L38
M01_L91:
       mov       rdx,[rax+r13*8]
       jmp       near ptr M01_L39
M01_L92:
       mov       rcx,offset MT_System.IConvertible
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastInterface(Void*, System.Object)
       mov       rcx,rax
       jmp       near ptr M01_L40
M01_L93:
       mov       rdx,r13
       mov       r11,7FFA068F09C0
       call      qword ptr [r11]
       mov       r12d,eax
       jmp       near ptr M01_L45
M01_L94:
       xor       r12d,r12d
       jmp       near ptr M01_L45
M01_L95:
       mov       [rbp-0C0],r15
       mov       [rbp-0B8],r12d
       lea       rdx,[rbp-0C0]
       mov       rcx,rbx
       call      qword ptr [7FFA06FCFDF8]
       jmp       near ptr M01_L46
M01_L96:
       mov       ecx,3A
       call      qword ptr [7FFA06FCFE10]
       int       3
M01_L97:
       mov       ecx,43
       call      qword ptr [7FFA06F2E370]
       int       3
M01_L98:
       mov       edx,4
       jmp       near ptr M01_L48
M01_L99:
       movsxd    rdx,edx
       mov       rcx,offset MT_System.ValueTuple<System.String, System.Int32>[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r13,rax
       test      r15d,r15d
       jle       short M01_L100
       mov       rcx,rdi
       mov       r8d,r15d
       mov       rdx,r13
       call      qword ptr [7FFA06B15050]; System.Array.Copy(System.Array, System.Array, Int32)
M01_L100:
       lea       rcx,[rsi+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L50
M01_L101:
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L50
M01_L102:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M01_L51
M01_L103:
       mov       rdx,r11
       mov       r8,r10
       call      qword ptr [7FFA06FCFAE0]
       jmp       near ptr M01_L51
M01_L104:
       mov       rdx,r11
       mov       r8,r10
       call      qword ptr [7FFA069A5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L51
M01_L105:
       mov       [rsp+20],ebx
       xor       edx,edx
       mov       [rsp+28],edx
       call      qword ptr [7FFA06FC7330]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M01_L51
M01_L106:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M01_L107:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 3696
```

