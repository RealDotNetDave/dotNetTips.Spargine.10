## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Data.CountryPhonePostalInfoRepositoryBenchmark.ValidatePostalCode()
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
       mov       [rbp+10],rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Data.CountryPhonePostalInfoRepository+<>c__DisplayClass3_0
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,1F138F906C0
       mov       [rbx+8],rcx
       mov       rdx,[rbx+8]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FF997E37540]; DotNetTips.Spargine.Core.Data.CountryPhonePostalInfoRepository.GetCountryPhonePostalInfo()
       mov       rsi,rax
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       cmp       ecx,2
       je        near ptr M00_L59
       cmp       ecx,3
       je        near ptr M00_L60
       test      rsi,rsi
       je        near ptr M00_L61
       mov       rdi,offset MT_DotNetTips.Spargine.Core.Data.Models.CountryPhonePostalInfo[]
       cmp       [rsi],rdi
       je        near ptr M00_L53
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Core.Data.Models.CountryPhonePostalInfo>
       cmp       [rsi],rcx
       je        near ptr M00_L52
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Core.Data.Models.CountryPhonePostalInfo>
       cmp       [rsi],rcx
       jne       near ptr M00_L67
       mov       rcx,[rsi+8]
       cmp       [rcx],rdi
       jne       near ptr M00_L63
       mov       r14d,[rcx+8]
       test      r14d,r14d
       je        near ptr M00_L66
M00_L00:
       mov       rsi,[rsi+8]
       cmp       [rsi],rdi
       jne       near ptr M00_L65
       mov       edi,[rsi+8]
       test      edi,edi
       jne       near ptr M00_L58
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Core.Data.Models.CountryPhonePostalInfo>
       test      byte ptr [7FF997E84100],1
       je        near ptr M00_L64
M00_L01:
       mov       rcx,1B0BA0001D0
       mov       r14,[rcx]
M00_L02:
       mov       [rbp-58],r14
       cmp       qword ptr [rbp-58],0
       je        near ptr M00_L19
       mov       r14,[rbp-58]
       mov       rsi,[r14]
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Core.Data.Models.CountryPhonePostalInfo>
       cmp       rsi,rcx
       jne       near ptr M00_L19
       jmp       short M00_L05
M00_L03:
       xor       eax,eax
M00_L04:
       test      eax,eax
       jne       near ptr M00_L46
M00_L05:
       mov       eax,[r14+8]
       inc       eax
       cmp       eax,[r14+0C]
       jae       near ptr M00_L33
       mov       [r14+8],eax
       mov       r10d,[r14+8]
       cmp       r10d,[r14+0C]
       jae       near ptr M00_L44
       mov       rdi,[r14+10]
       cmp       r10d,[rdi+8]
       jae       near ptr M00_L45
       mov       ecx,r10d
       mov       r15,[rdi+rcx*8+10]
       mov       rcx,[r15+18]
       mov       r13,[rbx+8]
       cmp       rcx,r13
       je        near ptr M00_L29
       test      rcx,rcx
       je        short M00_L03
       test      r13,r13
       je        short M00_L03
       mov       edx,[rcx+8]
       cmp       edx,[r13+8]
       jne       short M00_L03
       add       rcx,0C
       lea       r8,[r13+0C]
       mov       r9d,[r13+8]
       cmp       r9d,8
       jl        short M00_L07
       cmp       r9d,10
       jl        short M00_L06
       mov       rdx,r8
       mov       r8d,r9d
       call      qword ptr [7FF997ED5C20]
       jmp       near ptr M00_L13
M00_L06:
       mov       rdx,r8
       mov       r8d,r9d
       call      qword ptr [7FF997E37EB8]; System.Globalization.Ordinal.EqualsIgnoreCase_Vector[[System.Runtime.Intrinsics.Vector128`1[[System.UInt16, System.Private.CoreLib]], System.Private.CoreLib]](Char ByRef, Char ByRef, Int32)
       jmp       near ptr M00_L13
M00_L07:
       xor       r12d,r12d
       cmp       r9d,4
       jb        short M00_L09
M00_L08:
       mov       rdx,[rcx+r12]
       mov       rax,[r8+r12]
       mov       r10,rdx
       or        r10,rax
       mov       r11,r10
       shr       r11,20
       or        r11d,r10d
       test      r11d,0FF80FF80
       jne       near ptr M00_L31
       xor       rax,rdx
       shl       rax,2
       mov       r10,5000500050005
       add       rdx,r10
       mov       r10,0A000A000A000A0
       or        rdx,r10
       mov       r10,1A001A001A001A
       add       rdx,r10
       mov       r10,0FF7FFF7FFF7FFF7F
       or        rdx,r10
       test      rdx,rax
       jne       near ptr M00_L16
       add       r12,8
       add       r9d,0FFFFFFFC
       cmp       r9d,4
       jae       short M00_L08
M00_L09:
       cmp       r9d,2
       jae       short M00_L14
M00_L10:
       test      r9d,r9d
       jne       short M00_L15
M00_L11:
       mov       r10d,1
M00_L12:
       mov       eax,r10d
M00_L13:
       jmp       near ptr M00_L04
M00_L14:
       mov       edx,[rcx+r12]
       mov       eax,[r8+r12]
       mov       r10d,edx
       or        r10d,eax
       test      r10d,0FF80FF80
       jne       near ptr M00_L30
       xor       eax,edx
       shl       eax,2
       add       edx,50005
       or        edx,0A000A0
       add       edx,1A001A
       or        edx,0FF7FFF7F
       test      edx,eax
       jne       short M00_L16
       add       r12,4
       add       r9d,0FFFFFFFE
       jmp       short M00_L10
M00_L15:
       movzx     edx,word ptr [rcx+r12]
       movzx     eax,word ptr [r8+r12]
       mov       r10d,edx
       or        r10d,eax
       cmp       r10d,7F
       ja        near ptr M00_L30
       cmp       edx,eax
       je        short M00_L11
       or        edx,20
       lea       r10d,[rdx-61]
       cmp       r10d,19
       ja        short M00_L16
       or        eax,20
       cmp       edx,eax
       sete      r10b
       movzx     r10d,r10b
       jmp       near ptr M00_L12
M00_L16:
       xor       r10d,r10d
       jmp       near ptr M00_L12
M00_L17:
       xor       eax,eax
M00_L18:
       test      eax,eax
       jne       near ptr M00_L46
M00_L19:
       mov       r14,[rbp-58]
       mov       rsi,[r14]
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Core.Data.Models.CountryPhonePostalInfo>
       cmp       rsi,rcx
       jne       near ptr M00_L34
       mov       eax,[r14+8]
       inc       eax
       cmp       eax,[r14+0C]
       jae       near ptr M00_L35
       mov       [r14+8],eax
       mov       ecx,[r14+8]
       cmp       ecx,[r14+0C]
       jae       near ptr M00_L44
       mov       rdi,[r14+10]
       mov       r10d,[r14+8]
       cmp       r10d,[rdi+8]
       jae       near ptr M00_L45
       mov       ecx,r10d
       mov       r15,[rdi+rcx*8+10]
       mov       rcx,[r15+18]
       mov       r13,[rbx+8]
       cmp       rcx,r13
       je        near ptr M00_L43
       test      rcx,rcx
       je        short M00_L17
       test      r13,r13
       je        short M00_L17
       mov       edx,[rcx+8]
       cmp       edx,[r13+8]
       jne       near ptr M00_L17
       add       rcx,0C
       lea       r8,[r13+0C]
       mov       r9d,[r13+8]
       cmp       r9d,8
       jl        short M00_L21
       cmp       r9d,10
       jl        short M00_L20
       mov       rdx,r8
       mov       r8d,r9d
       call      qword ptr [7FF997ED5C20]
       jmp       near ptr M00_L27
M00_L20:
       mov       rdx,r8
       mov       r8d,r9d
       call      qword ptr [7FF997E37EB8]; System.Globalization.Ordinal.EqualsIgnoreCase_Vector[[System.Runtime.Intrinsics.Vector128`1[[System.UInt16, System.Private.CoreLib]], System.Private.CoreLib]](Char ByRef, Char ByRef, Int32)
       jmp       near ptr M00_L27
M00_L21:
       xor       r12d,r12d
       cmp       r9d,4
       jb        short M00_L23
M00_L22:
       mov       rdx,[rcx+r12]
       mov       rax,[r8+r12]
       mov       r10,rdx
       or        r10,rax
       mov       r11,r10
       shr       r11,20
       or        r11d,r10d
       test      r11d,0FF80FF80
       jne       near ptr M00_L37
       xor       rax,rdx
       shl       rax,2
       mov       r10,5000500050005
       add       r10,rdx
       mov       rdx,0A000A000A000A0
       or        rdx,r10
       mov       r10,1A001A001A001A
       add       rdx,r10
       mov       r10,0FF7FFF7FFF7FFF7F
       or        rdx,r10
       test      rdx,rax
       jne       short M00_L28
       add       r12,8
       add       r9d,0FFFFFFFC
       cmp       r9d,4
       jae       short M00_L22
M00_L23:
       cmp       r9d,2
       jae       near ptr M00_L38
M00_L24:
       test      r9d,r9d
       jne       near ptr M00_L39
M00_L25:
       mov       r10d,1
M00_L26:
       mov       eax,r10d
M00_L27:
       jmp       near ptr M00_L18
M00_L28:
       xor       r10d,r10d
       jmp       short M00_L26
M00_L29:
       mov       eax,1
       jmp       near ptr M00_L04
M00_L30:
       test      edx,0FF80FF80
       je        near ptr M00_L16
       test      eax,0FF80FF80
       jne       short M00_L32
       jmp       near ptr M00_L16
M00_L31:
       mov       r10,0FF80FF80FF80FF80
       test      r10,rdx
       je        near ptr M00_L16
       mov       rdx,0FF80FF80FF80FF80
       test      rdx,rax
       je        near ptr M00_L16
M00_L32:
       add       rcx,r12
       add       r8,r12
       mov       edx,r9d
       call      qword ptr [7FF997ED5DB8]
       test      eax,eax
       sete      r10b
       movzx     r10d,r10b
       jmp       near ptr M00_L12
M00_L33:
       mov       ecx,[r14+0C]
       mov       [r14+8],ecx
       jmp       near ptr M00_L68
M00_L34:
       mov       rcx,r14
       mov       r11,7FF9977609D0
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L36
       jmp       near ptr M00_L68
M00_L35:
       mov       ecx,[r14+0C]
       mov       [r14+8],ecx
       jmp       near ptr M00_L68
M00_L36:
       mov       rcx,r14
       mov       r11,7FF9977609D8
       call      qword ptr [r11]
       mov       r15,rax
       mov       rcx,rbx
       mov       rdx,r15
       mov       rax,offset DotNetTips.Spargine.Core.Data.CountryPhonePostalInfoRepository+<>c__DisplayClass3_0.<GetCountryPhonePostalInfo>b__2(DotNetTips.Spargine.Core.Data.Models.CountryPhonePostalInfo)
       call      rax
       jmp       near ptr M00_L18
M00_L37:
       mov       r10,0FF80FF80FF80FF80
       test      r10,rdx
       je        near ptr M00_L28
       mov       rdx,0FF80FF80FF80FF80
       test      rdx,rax
       je        near ptr M00_L28
       jmp       short M00_L41
M00_L38:
       mov       edx,[rcx+r12]
       mov       eax,[r8+r12]
       mov       r10d,edx
       or        r10d,eax
       test      r10d,0FF80FF80
       jne       short M00_L40
       xor       eax,edx
       shl       eax,2
       add       edx,50005
       or        edx,0A000A0
       add       edx,1A001A
       or        edx,0FF7FFF7F
       test      edx,eax
       jne       near ptr M00_L28
       add       r12,4
       add       r9d,0FFFFFFFE
       jmp       near ptr M00_L24
M00_L39:
       movzx     edx,word ptr [rcx+r12]
       movzx     eax,word ptr [r8+r12]
       mov       r10d,edx
       or        r10d,eax
       cmp       r10d,7F
       jbe       short M00_L42
M00_L40:
       test      edx,0FF80FF80
       je        near ptr M00_L28
       test      eax,0FF80FF80
       je        near ptr M00_L28
M00_L41:
       add       rcx,r12
       add       r8,r12
       mov       edx,r9d
       call      qword ptr [7FF997ED5DB8]
       test      eax,eax
       sete      r10b
       movzx     r10d,r10b
       jmp       near ptr M00_L26
M00_L42:
       cmp       edx,eax
       je        near ptr M00_L25
       or        edx,20
       lea       r10d,[rdx-61]
       cmp       r10d,19
       ja        near ptr M00_L28
       or        eax,20
       cmp       edx,eax
       sete      r10b
       movzx     r10d,r10b
       jmp       near ptr M00_L26
M00_L43:
       mov       eax,1
       jmp       near ptr M00_L18
M00_L44:
       mov       ecx,[r14+8]
       call      qword ptr [7FF997ED5B78]
       int       3
M00_L45:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L46:
       mov       rsi,[r14]
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Core.Data.Models.CountryPhonePostalInfo>
       cmp       rsi,rcx
       jne       near ptr M00_L69
M00_L47:
       test      r15,r15
       je        near ptr M00_L70
       mov       rbx,[r15+30]
M00_L48:
       test      rbx,rbx
       je        near ptr M00_L71
       cmp       dword ptr [rbx+8],0
       je        near ptr M00_L71
       xor       esi,esi
M00_L49:
       cmp       esi,0A
       jae       near ptr M00_L75
       mov       rcx,1F138F906F0
       movzx     ecx,word ptr [rcx+rsi*2+0C]
       cmp       ecx,100
       jge       near ptr M00_L72
       cmp       ecx,100
       jae       near ptr M00_L75
       mov       rax,7FF9EED06998
       test      byte ptr [rax+rcx],80
       jne       near ptr M00_L73
M00_L50:
       mov       rcx,rbx
       call      qword ptr [7FF997E37ED0]; System.Text.RegularExpressions.RegexCache.GetOrAdd(System.String)
       mov       ecx,0A
       xor       edx,edx
       test      byte ptr [rax+40],40
       cmove     ecx,edx
       mov       [rsp+20],edx
       mov       dword ptr [rsp+28],0A
       mov       [rsp+30],ecx
       mov       rcx,rax
       mov       r8d,0FFFFFFFF
       mov       r9,1F138F906F0
       call      qword ptr [7FF997E3D380]; System.Text.RegularExpressions.Regex.RunSingleMatch(System.Text.RegularExpressions.RegexRunnerMode, Int32, System.String, Int32, Int32, Int32)
       test      rax,rax
       jne       near ptr M00_L74
       mov       ecx,2
M00_L51:
       mov       [rbp-50],ecx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+60]
       lea       rdx,[rbp-50]
       cmp       [rcx],ecx
       call      qword ptr [7FF997E3D608]; BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Data.PostalCodeState, DotNetTips.Spargine.10.Core]](DotNetTips.Spargine.Core.Data.PostalCodeState ByRef)
       nop
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
M00_L52:
       mov       r15d,[rsi+10]
       mov       r14,[rsi+8]
       cmp       [r14+8],r15d
       jb        near ptr M00_L62
       add       r14,10
       jmp       short M00_L54
M00_L53:
       lea       r14,[rsi+10]
       mov       r15d,[rsi+8]
M00_L54:
       xor       esi,esi
       cmp       esi,r15d
       jge       short M00_L56
M00_L55:
       mov       rdi,[r14+rsi*8]
       mov       rcx,rbx
       mov       rdx,rdi
       mov       rax,offset DotNetTips.Spargine.Core.Data.CountryPhonePostalInfoRepository+<>c__DisplayClass3_0.<GetCountryPhonePostalInfo>b__2(DotNetTips.Spargine.Core.Data.Models.CountryPhonePostalInfo)
       call      rax
       test      eax,eax
       jne       short M00_L57
       inc       esi
       cmp       esi,r15d
       jl        short M00_L55
M00_L56:
       xor       r15d,r15d
       jmp       near ptr M00_L47
M00_L57:
       mov       r15,rdi
       jmp       near ptr M00_L47
M00_L58:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Core.Data.Models.CountryPhonePostalInfo>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       dword ptr [r14+8],0FFFFFFFF
       mov       [r14+0C],edi
       lea       rcx,[r14+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L02
M00_L59:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Core.Data.Models.CountryPhonePostalInfo, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       mov       rdx,rbx
       mov       r8,7FF997E334E0
       call      qword ptr [7FF997816BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       lea       r9,[rbp-40]
       mov       rdx,rsi
       mov       r8,r15
       mov       rcx,7FF997E83ED0
       call      qword ptr [7FF997E343C0]; System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>, Boolean ByRef)
       mov       r15,rax
       jmp       near ptr M00_L47
M00_L60:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Core.Data.Models.CountryPhonePostalInfo, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       mov       rdx,rbx
       mov       r8,7FF997E334F8
       call      qword ptr [7FF997816BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       lea       r9,[rbp-48]
       mov       rdx,rsi
       mov       r8,r15
       mov       rcx,7FF997E83ED0
       call      qword ptr [7FF997E343C0]; System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>, Boolean ByRef)
       mov       r15,rax
       jmp       near ptr M00_L47
M00_L61:
       mov       ecx,11
       call      qword ptr [7FF997A37E58]
       int       3
M00_L62:
       call      qword ptr [7FF997A37A08]
       int       3
M00_L63:
       mov       r11,7FF9977609E8
       call      qword ptr [r11]
       mov       r14d,eax
       test      r14d,r14d
       je        short M00_L66
       jmp       near ptr M00_L00
M00_L64:
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L01
M00_L65:
       mov       rcx,rsi
       mov       r11,7FF9977609F0
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L02
M00_L66:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Core.Data.Models.CountryPhonePostalInfo>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1B0BA0001D0
       mov       r14,[rcx]
       jmp       near ptr M00_L02
M00_L67:
       mov       rcx,rsi
       mov       r11,7FF9977609C8
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L02
M00_L68:
       call      M00_L76
       jmp       near ptr M00_L56
M00_L69:
       mov       rcx,r14
       mov       r11,7FF9977609E0
       call      qword ptr [r11]
       jmp       near ptr M00_L47
M00_L70:
       xor       ebx,ebx
       jmp       near ptr M00_L48
M00_L71:
       mov       ecx,1
       jmp       near ptr M00_L51
M00_L72:
       call      qword ptr [7FF997ED6220]
       test      eax,eax
       je        near ptr M00_L50
M00_L73:
       inc       esi
       cmp       esi,0A
       jl        near ptr M00_L49
M00_L74:
       xor       ecx,ecx
       jmp       near ptr M00_L51
M00_L75:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L76:
       sub       rsp,38
       cmp       qword ptr [rbp-58],0
       je        short M00_L77
       mov       r14,[rbp-58]
       mov       rsi,[r14]
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Core.Data.Models.CountryPhonePostalInfo>
       cmp       rsi,rcx
       je        short M00_L77
       mov       rcx,r14
       mov       r11,7FF9977609E0
       call      qword ptr [r11]
M00_L77:
       nop
       add       rsp,38
       ret
; Total bytes of code 2376
```
```assembly
; DotNetTips.Spargine.Core.Data.CountryPhonePostalInfoRepository.GetCountryPhonePostalInfo()
; 		_countries ??= DeserializeCountryPhonePostalInfo();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return _countries;
; 		^^^^^^^^^^^^^^^^^^
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+40]
       xor       edx,edx
       mov       [rbp-18],rdx
       lea       rdx,[rbp-18]
       mov       rbx,1F138F90758
       mov       rcx,rbx
       call      qword ptr [7FF997815998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rsi,1B0BA0000C8
       cmp       qword ptr [rsi],0
       je        short M01_L01
M01_L00:
       mov       rsi,[rsi]
       lea       rdx,[rbp-18]
       mov       rcx,rbx
       call      qword ptr [7FF9978159B0]; System.Threading.Monitor.ExitIfLockTaken(System.Object, Boolean ByRef)
       jmp       short M01_L02
M01_L01:
       call      qword ptr [7FF997E37558]; DotNetTips.Spargine.Core.Data.CountryPhonePostalInfoRepository.DeserializeCountryPhonePostalInfo()
       mov       rdx,rax
       mov       rcx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M01_L00
M01_L02:
       mov       rax,rsi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rbp
       ret
       sub       rsp,28
       lea       rdx,[rbp-18]
       mov       rbx,1F138F90758
       mov       rcx,rbx
       call      qword ptr [7FF9978159B0]; System.Threading.Monitor.ExitIfLockTaken(System.Object, Boolean ByRef)
       nop
       add       rsp,28
       ret
; Total bytes of code 138
```
```assembly
; System.Globalization.Ordinal.EqualsIgnoreCase_Vector[[System.Runtime.Intrinsics.Vector128`1[[System.UInt16, System.Private.CoreLib]], System.Private.CoreLib]](Char ByRef, Char ByRef, Int32)
       push      rsi
       push      rbx
       sub       rsp,178
       vmovaps   [rsp+160],xmm6
       movsxd    r9,r8d
       lea       rax,[r9-8]
       xor       r10d,r10d
       vbroadcastss xmm0,dword ptr [7FF9978B4470]
       vbroadcastss xmm1,dword ptr [7FF9978B4474]
       vbroadcastss xmm2,dword ptr [7FF9978B4478]
M02_L00:
       vmovups   xmm3,[rcx+r10*2]
       vmovups   xmm4,[rdx+r10*2]
       vpor      xmm5,xmm3,xmm4
       vpand     xmm5,xmm5,xmm2
       vmovaps   [rsp+150],xmm5
       vxorps    xmm5,xmm5,xmm5
       vmovaps   [rsp+140],xmm5
       mov       r8,[rsp+150]
       mov       [rsp+128],r8
       mov       r8,[rsp+140]
       mov       [rsp+120],r8
       xor       r8d,r8d
       movzx     r11d,word ptr [rsp+128]
       cmp       r11w,[rsp+120]
       jne       short M02_L02
M02_L01:
       inc       r8d
       cmp       r8d,4
       jge       near ptr M02_L07
       lea       r11,[rsp+128]
       movsxd    rbx,r8d
       movzx     r11d,word ptr [r11+rbx*2]
       lea       rsi,[rsp+120]
       cmp       r11w,[rsi+rbx*2]
       je        short M02_L01
M02_L02:
       vpand     xmm2,xmm2,xmm3
       vmovaps   [rsp+0B0],xmm2
       vxorps    xmm0,xmm0,xmm0
       vmovaps   [rsp+0A0],xmm0
       mov       rax,[rsp+0B0]
       mov       [rsp+88],rax
       mov       rax,[rsp+0A0]
       mov       [rsp+80],rax
       xor       eax,eax
       movzx     r8d,word ptr [rsp+88]
       cmp       r8w,[rsp+80]
       jne       short M02_L04
M02_L03:
       inc       eax
       cmp       eax,4
       jge       near ptr M02_L20
       lea       r8,[rsp+88]
       movsxd    r11,eax
       movzx     r8d,word ptr [r8+r11*2]
       lea       rbx,[rsp+80]
       cmp       r8w,[rbx+r11*2]
       je        short M02_L03
M02_L04:
       vbroadcastss xmm2,dword ptr [7FF9978B4478]
       vpand     xmm0,xmm2,xmm4
       vmovaps   [rsp+60],xmm0
       vxorps    xmm0,xmm0,xmm0
       vmovaps   [rsp+50],xmm0
       mov       rax,[rsp+60]
       mov       [rsp+38],rax
       mov       rax,[rsp+50]
       mov       [rsp+30],rax
       movzx     eax,word ptr [rsp+38]
       cmp       ax,[rsp+30]
       jne       near ptr M02_L24
       movzx     eax,word ptr [rsp+3A]
       cmp       ax,[rsp+32]
       jne       near ptr M02_L24
       movzx     eax,word ptr [rsp+3C]
       cmp       ax,[rsp+34]
       jne       near ptr M02_L24
       movzx     eax,word ptr [rsp+3E]
       cmp       ax,[rsp+36]
       jne       near ptr M02_L24
       vxorps    xmm0,xmm0,xmm0
       vmovaps   [rsp+40],xmm0
       mov       rax,[rsp+68]
       mov       [rsp+28],rax
       mov       rax,[rsp+48]
       mov       [rsp+20],rax
       movzx     eax,word ptr [rsp+28]
       cmp       ax,[rsp+20]
       jne       near ptr M02_L23
       movzx     eax,word ptr [rsp+2A]
       cmp       ax,[rsp+22]
       jne       near ptr M02_L23
       movzx     eax,word ptr [rsp+2C]
       cmp       ax,[rsp+24]
       jne       near ptr M02_L23
       movzx     eax,word ptr [rsp+2E]
       cmp       ax,[rsp+26]
       jne       near ptr M02_L23
       mov       eax,1
M02_L05:
       test      eax,eax
       je        near ptr M02_L24
M02_L06:
       xor       eax,eax
       vmovaps   xmm6,[rsp+160]
       add       rsp,178
       pop       rbx
       pop       rsi
       ret
M02_L07:
       vxorps    xmm5,xmm5,xmm5
       vmovaps   [rsp+130],xmm5
       mov       r8,[rsp+158]
       mov       [rsp+118],r8
       mov       r8,[rsp+138]
       mov       [rsp+110],r8
       xor       r8d,r8d
       movzx     r11d,word ptr [rsp+118]
       cmp       r11w,[rsp+110]
       jne       short M02_L09
M02_L08:
       inc       r8d
       cmp       r8d,4
       jge       near ptr M02_L13
       lea       r11,[rsp+118]
       movsxd    rbx,r8d
       movzx     r11d,word ptr [r11+rbx*2]
       lea       rsi,[rsp+110]
       cmp       r11w,[rsi+rbx*2]
       je        short M02_L08
M02_L09:
       xor       r8d,r8d
M02_L10:
       test      r8d,r8d
       je        near ptr M02_L02
       vpcmpeqw  xmm5,xmm3,xmm4
       vpcmpeqd  xmm6,xmm6,xmm6
       vpxor     xmm5,xmm6,xmm5
       vptest    xmm5,xmm5
       je        short M02_L11
       vpor      xmm3,xmm3,xmm0
       vpor      xmm4,xmm4,xmm0
       vpsubw    xmm6,xmm3,xmm1
       vpand     xmm5,xmm6,xmm5
       vbroadcastss xmm6,dword ptr [7FF9978B447C]
       vpaddw    xmm5,xmm5,xmm6
       vpcmpgtw  xmm5,xmm5,[7FF9978B4480]
       vptest    xmm5,xmm5
       jne       near ptr M02_L06
       vpcmpeqw  xmm3,xmm3,xmm4
       vpmovmskb r8d,xmm3
       cmp       r8d,0FFFF
       jne       near ptr M02_L06
M02_L11:
       add       r10,8
       cmp       r10,rax
       jbe       near ptr M02_L00
       cmp       r10,r9
       je        near ptr M02_L18
       lea       r10,[r9-8]
       vmovups   xmm3,[rcx+r10*2]
       vmovups   xmm4,[rdx+r10*2]
       vpor      xmm5,xmm3,xmm4
       vpand     xmm5,xmm5,xmm2
       vmovaps   [rsp+100],xmm5
       vxorps    xmm5,xmm5,xmm5
       vmovaps   [rsp+0F0],xmm5
       mov       rax,[rsp+100]
       mov       [rsp+0D8],rax
       mov       rax,[rsp+0F0]
       mov       [rsp+0D0],rax
       xor       eax,eax
       movzx     r8d,word ptr [rsp+0D8]
       cmp       r8w,[rsp+0D0]
       jne       near ptr M02_L02
M02_L12:
       inc       eax
       cmp       eax,4
       jge       short M02_L14
       lea       r8,[rsp+0D8]
       movsxd    r11,eax
       movzx     r8d,word ptr [r8+r11*2]
       lea       rbx,[rsp+0D0]
       cmp       r8w,[rbx+r11*2]
       je        short M02_L12
       jmp       near ptr M02_L02
M02_L13:
       mov       r8d,1
       jmp       near ptr M02_L10
M02_L14:
       vxorps    xmm5,xmm5,xmm5
       vmovaps   [rsp+0E0],xmm5
       mov       rax,[rsp+108]
       mov       [rsp+0C8],rax
       mov       rax,[rsp+0E8]
       mov       [rsp+0C0],rax
       xor       eax,eax
       movzx     r8d,word ptr [rsp+0C8]
       cmp       r8w,[rsp+0C0]
       jne       short M02_L16
M02_L15:
       inc       eax
       cmp       eax,4
       jge       short M02_L19
       lea       r8,[rsp+0C8]
       movsxd    r11,eax
       movzx     r8d,word ptr [r8+r11*2]
       lea       rbx,[rsp+0C0]
       cmp       r8w,[rbx+r11*2]
       je        short M02_L15
M02_L16:
       xor       eax,eax
M02_L17:
       test      eax,eax
       je        near ptr M02_L02
       vpcmpeqw  xmm2,xmm3,xmm4
       vpcmpeqd  xmm5,xmm5,xmm5
       vpxor     xmm2,xmm5,xmm2
       vptest    xmm2,xmm2
       jne       near ptr M02_L25
M02_L18:
       mov       eax,1
       vmovaps   xmm6,[rsp+160]
       add       rsp,178
       pop       rbx
       pop       rsi
       ret
M02_L19:
       mov       eax,1
       jmp       short M02_L17
M02_L20:
       vxorps    xmm0,xmm0,xmm0
       vmovaps   [rsp+90],xmm0
       mov       rax,[rsp+0B8]
       mov       [rsp+78],rax
       mov       rax,[rsp+98]
       mov       [rsp+70],rax
       movzx     eax,word ptr [rsp+78]
       cmp       ax,[rsp+70]
       jne       short M02_L22
       movzx     eax,word ptr [rsp+7A]
       cmp       ax,[rsp+72]
       jne       short M02_L22
       movzx     eax,word ptr [rsp+7C]
       cmp       ax,[rsp+74]
       jne       short M02_L22
       movzx     eax,word ptr [rsp+7E]
       cmp       ax,[rsp+76]
       jne       short M02_L22
       mov       eax,1
M02_L21:
       test      eax,eax
       jne       near ptr M02_L06
       jmp       near ptr M02_L04
M02_L22:
       xor       eax,eax
       jmp       short M02_L21
M02_L23:
       xor       eax,eax
       jmp       near ptr M02_L05
M02_L24:
       lea       r8,[r10+r10]
       add       rcx,r8
       add       r8,rdx
       sub       r9d,r10d
       mov       edx,r9d
       call      qword ptr [7FF997ED5DB8]
       test      eax,eax
       sete      al
       movzx     eax,al
       vmovaps   xmm6,[rsp+160]
       add       rsp,178
       pop       rbx
       pop       rsi
       ret
M02_L25:
       vpor      xmm3,xmm3,xmm0
       vpor      xmm4,xmm4,xmm0
       vpsubw    xmm0,xmm3,xmm1
       vpand     xmm0,xmm0,xmm2
       vbroadcastss xmm6,dword ptr [7FF9978B447C]
       vpaddw    xmm0,xmm0,xmm6
       vpcmpgtw  xmm0,xmm0,[7FF9978B4480]
       vptest    xmm0,xmm0
       jne       near ptr M02_L06
       vpcmpeqw  xmm3,xmm3,xmm4
       vpmovmskb eax,xmm3
       cmp       eax,0FFFF
       jne       near ptr M02_L06
       jmp       near ptr M02_L18
; Total bytes of code 1357
```
```assembly
; DotNetTips.Spargine.Core.Data.CountryPhonePostalInfoRepository+<>c__DisplayClass3_0.<GetCountryPhonePostalInfo>b__2(DotNetTips.Spargine.Core.Data.Models.CountryPhonePostalInfo)
; 			_ => countryData.FirstOrDefault(p => string.Equals(p.Name, countryNameOrIso, StringComparison.OrdinalIgnoreCase))
; 			                                     ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rdx,[rdx+18]
       mov       rax,[rcx+8]
       cmp       rdx,rax
       je        short M03_L03
       test      rdx,rdx
       je        short M03_L00
       test      rax,rax
       je        short M03_L00
       mov       ecx,[rdx+8]
       cmp       ecx,[rax+8]
       je        short M03_L02
M03_L00:
       xor       eax,eax
M03_L01:
       ret
M03_L02:
       mov       rcx,rdx
       mov       rdx,rax
       jmp       qword ptr [7FF997E37EA0]; System.String.EqualsOrdinalIgnoreCaseNoLengthCheck(System.String, System.String)
M03_L03:
       mov       eax,1
       jmp       short M03_L01
; Total bytes of code 53
```
```assembly
; System.Text.RegularExpressions.RegexCache.GetOrAdd(System.String)
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,50
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+30],ymm4
       mov       rbx,rcx
       test      rbx,rbx
       je        near ptr M04_L07
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+238],2
       jle       near ptr M04_L08
       mov       rcx,[rcx+240]
       mov       rax,[rcx+10]
       test      rax,rax
       je        near ptr M04_L08
M04_L00:
       mov       rsi,[rax+10]
       test      rsi,rsi
       jne       short M04_L01
       mov       rax,1B0A4000110
       mov       rsi,[rax]
       test      rsi,rsi
       jne       short M04_L01
       mov       rax,1B0A40000F0
       mov       rsi,[rax]
       test      rsi,rsi
       je        near ptr M04_L09
M04_L01:
       mov       rcx,offset MT_System.Globalization.CultureInfo
       cmp       [rsi],rcx
       jne       near ptr M04_L10
       mov       rdi,[rsi+40]
M04_L02:
       xor       ebp,ebp
       mov       r8,1B0BA000120
       mov       r14,[r8]
       test      r14,r14
       je        near ptr M04_L14
       mov       rdx,[r14+18]
       mov       rbp,[r14+20]
       mov       r15d,[r14+28]
       mov       r13,[r14+30]
       cmp       rbx,rdx
       jne       near ptr M04_L11
M04_L03:
       cmp       [rdi],dil
       cmp       rdi,rbp
       jne       near ptr M04_L12
M04_L04:
       test      r15d,r15d
       jne       near ptr M04_L13
       cmp       r13,0FFFFFFFFFFFFD8F0
       jne       near ptr M04_L13
       mov       rbp,[r14+8]
M04_L05:
       xor       ecx,ecx
       mov       [rsp+48],rcx
       test      rbp,rbp
       je        near ptr M04_L16
M04_L06:
       mov       rax,rbp
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M04_L07:
       mov       ecx,0C
       call      qword ptr [7FF997ED6238]
       int       3
M04_L08:
       mov       ecx,2
       call      qword ptr [7FF997ED6268]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M04_L00
M04_L09:
       call      qword ptr [7FF997A35E00]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rsi,rax
       jmp       near ptr M04_L01
M04_L10:
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       rdi,rax
       jmp       near ptr M04_L02
M04_L11:
       test      rdx,rdx
       je        short M04_L13
       mov       r8d,[rbx+8]
       cmp       r8d,[rdx+8]
       jne       short M04_L13
       lea       rcx,[rbx+0C]
       mov       r8d,[rbx+8]
       add       r8d,r8d
       add       rdx,0C
       call      qword ptr [7FF99781FBB8]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       test      eax,eax
       je        short M04_L13
       jmp       near ptr M04_L03
M04_L12:
       test      rbp,rbp
       je        short M04_L13
       mov       r8d,[rdi+8]
       cmp       r8d,[rbp+8]
       jne       short M04_L13
       lea       rcx,[rdi+0C]
       mov       r8d,[rdi+8]
       add       r8d,r8d
       lea       rdx,[rbp+0C]
       call      qword ptr [7FF99781FBB8]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       test      eax,eax
       jne       near ptr M04_L04
M04_L13:
       mov       rbp,[r14+10]
M04_L14:
       cmp       dword ptr [7FF99775B168],0
       je        short M04_L15
       mov       [rsp+28],rbx
       mov       [rsp+30],rdi
       xor       edx,edx
       mov       [rsp+38],edx
       mov       qword ptr [rsp+40],0FFFFFFFFFFFFD8F0
       lea       rdx,[rsp+28]
       mov       rcx,1B0BA000128
       mov       rcx,[rcx]
       lea       r8,[rsp+48]
       call      qword ptr [7FF997E85698]; Precode of System.Collections.Concurrent.ConcurrentDictionary`2[[System.Text.RegularExpressions.RegexCache+Key, System.Text.RegularExpressions],[System.__Canon, System.Private.CoreLib]].TryGetValue(Key, System.__Canon ByRef)
       test      eax,eax
       je        short M04_L15
       mov       rcx,[rsp+48]
       inc       rbp
       mov       [rcx+10],rbp
       mov       rdx,[rsp+48]
       mov       rcx,1B0BA000120
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsp+48]
       mov       rbp,[rcx+8]
       jmp       near ptr M04_L05
M04_L15:
       xor       ebp,ebp
       jmp       near ptr M04_L05
M04_L16:
       mov       rcx,offset MT_System.Text.RegularExpressions.Regex
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       mov       rdx,rbx
       mov       r8,rsi
       call      qword ptr [7FF997E3C180]; System.Text.RegularExpressions.Regex..ctor(System.String, System.Globalization.CultureInfo)
       mov       [rsp+28],rbx
       mov       [rsp+30],rdi
       xor       ecx,ecx
       mov       [rsp+38],ecx
       mov       qword ptr [rsp+40],0FFFFFFFFFFFFD8F0
       lea       rcx,[rsp+28]
       mov       rdx,rbp
       call      qword ptr [7FF997E3D2A8]; System.Text.RegularExpressions.RegexCache.Add(Key, System.Text.RegularExpressions.Regex)
       jmp       near ptr M04_L06
; Total bytes of code 635
```
```assembly
; System.Text.RegularExpressions.Regex.RunSingleMatch(System.Text.RegularExpressions.RegexRunnerMode, Int32, System.String, Int32, Int32, Int32)
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
       mov       [rbp-50],rax
       mov       [rbp+10],rcx
       mov       esi,edx
       mov       edi,r8d
       mov       rbx,r9
       mov       r15d,[rbp+30]
       mov       r14d,[rbp+38]
       mov       r13d,[rbp+40]
       mov       r12d,[rbx+8]
       cmp       r12d,r13d
       jb        near ptr M05_L21
       cmp       r12d,r14d
       jb        near ptr M05_L22
       lea       rax,[rcx+30]
       xor       edx,edx
       xchg      rdx,[rax]
       mov       rax,rdx
       test      rax,rax
       je        near ptr M05_L23
M05_L00:
       mov       [rbp-58],rax
       mov       rdx,[rcx+48]
       mov       [rbp-60],rax
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF997E3D410]; System.Text.RegularExpressions.RegexRunner.InitializeTimeout(System.TimeSpan)
       mov       rax,[rbp-60]
       lea       rcx,[rax+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,r15d
       mov       edx,r14d
       add       rcx,rdx
       mov       edx,r12d
       cmp       rcx,rdx
       ja        near ptr M05_L08
       mov       ecx,r15d
       lea       r12,[rbx+rcx*2+0C]
       sub       r13d,r15d
       mov       rax,[rbp-60]
       mov       [rax+60],esi
       mov       [rbp-60],rax
       lea       rcx,[rax+30]
       mov       rdx,[rbp+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-60]
       mov       [rax+48],r13d
       xor       ecx,ecx
       mov       [rax+40],ecx
       mov       [rax+44],r14d
       mov       [rax+4C],r13d
       mov       r13,[rax+28]
       test      r13,r13
       je        near ptr M05_L11
       mov       rdx,[rax+8]
       lea       rcx,[r13+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r13+34],ecx
       mov       [r13+5C],r14d
       mov       rcx,[r13+50]
       mov       eax,[rcx+8]
       test      eax,eax
       jle       short M05_L02
       add       rcx,10
M05_L01:
       xor       edx,edx
       mov       [rcx],edx
       add       rcx,4
       dec       eax
       jne       short M05_L01
M05_L02:
       mov       byte ptr [r13+60],0
       mov       rcx,[r13+38]
       test      rcx,rcx
       je        short M05_L03
       xor       eax,eax
       mov       [rcx+18],rax
M05_L03:
       mov       rdx,[rbp-58]
       mov       rcx,[rdx+20]
       test      rcx,rcx
       je        near ptr M05_L14
       mov       rax,[rdx+10]
       mov       eax,[rax+8]
       mov       [rdx+50],eax
       mov       rax,[rdx+18]
       mov       eax,[rax+8]
       mov       [rdx+54],eax
       mov       ecx,[rcx+8]
       mov       [rdx+58],ecx
M05_L04:
       test      edi,edi
       je        near ptr M05_L15
M05_L05:
       mov       [rbp-50],r12
       mov       [rbp-48],r14d
       lea       rdx,[rbp-50]
       mov       rcx,[rbp-58]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,[rbp-58]
       mov       rdi,[rcx+28]
       mov       rax,[rdi+50]
       cmp       dword ptr [rax+8],0
       jbe       near ptr M05_L17
       cmp       dword ptr [rax+10],0
       jg        short M05_L09
       xor       eax,eax
       mov       [rdi+8],rax
       test      byte ptr [7FF997EA9FA0],1
       je        near ptr M05_L19
M05_L06:
       mov       rdx,1B0BA0001B8
       mov       rdi,[rdx]
M05_L07:
       jmp       near ptr M05_L20
M05_L08:
       mov       ecx,21
       call      qword ptr [7FF997A378D0]
       int       3
M05_L09:
       test      esi,esi
       jne       short M05_L10
       xor       edx,edx
       mov       [rdi+8],rdx
       xor       edi,edi
       jmp       short M05_L07
M05_L10:
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       xor       edx,edx
       mov       rcx,[rbp-58]
       mov       [rcx+28],rdx
       mov       edx,[rcx+4C]
       mov       rcx,rdi
       mov       r8d,r15d
       mov       r9d,esi
       call      qword ptr [7FF997ED62C8]
       jmp       short M05_L07
M05_L11:
       mov       [rbp-60],rax
       mov       rcx,[rax+30]
       cmp       qword ptr [rcx+18],0
       je        short M05_L12
       mov       rcx,offset MT_System.Text.RegularExpressions.MatchSparse
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rax,[rbp-60]
       mov       r8,[rax+8]
       mov       [rsp+20],r8
       mov       [rsp+28],r14d
       mov       r8,[rax+30]
       mov       r8,[r8+18]
       mov       r9,[rax+30]
       mov       r9d,[r9+44]
       mov       [rbp-60],rax
       mov       rdx,[rax+30]
       mov       rcx,r13
       call      qword ptr [7FF997ED62F8]
       jmp       short M05_L13
M05_L12:
       mov       rcx,offset MT_System.Text.RegularExpressions.Match
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       [rsp+20],r14d
       mov       rax,[rbp-60]
       mov       r8,[rax+30]
       mov       r8d,[r8+44]
       mov       rdx,[rax+30]
       mov       [rbp-60],rax
       mov       r9,[rax+8]
       mov       rcx,r13
       call      qword ptr [7FF997E3D4A0]; System.Text.RegularExpressions.Match..ctor(System.Text.RegularExpressions.Regex, Int32, System.String, Int32)
M05_L13:
       mov       rcx,[rbp-60]
       lea       rcx,[rcx+28]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M05_L03
M05_L14:
       mov       rcx,rdx
       mov       rax,[rdx]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       rcx,[rbp-58]
       mov       r13d,[rcx+5C]
       shl       r13d,3
       mov       edx,r13d
       mov       eax,20
       cmp       r13d,20
       cmovl     edx,eax
       mov       eax,10
       cmp       r13d,10
       cmovl     r13d,eax
       mov       [rbp-3C],edx
       movsxd    rdx,edx
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rcx,[rbp-58]
       lea       rcx,[rcx+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-58]
       mov       edx,[rbp-3C]
       mov       [rcx+50],edx
       movsxd    rdx,r13d
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rcx,[rbp-58]
       lea       rcx,[rcx+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-58]
       mov       [rcx+54],r13d
       mov       rcx,offset MT_System.Int32[]
       mov       edx,20
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rcx,[rbp-58]
       lea       rcx,[rcx+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-58]
       mov       dword ptr [rcx+58],20
       mov       rdx,rcx
       jmp       near ptr M05_L04
M05_L15:
       mov       ecx,r14d
       mov       eax,1
       mov       r8,[rbp+10]
       test      byte ptr [r8+40],40
       je        short M05_L16
       xor       ecx,ecx
       mov       eax,0FFFFFFFF
M05_L16:
       cmp       [rdx+48],ecx
       jne       short M05_L18
       mov       rcx,offset MT_System.Text.RegularExpressions.Match
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,1B0BA0001B8
       mov       rdi,[rdx]
       jmp       short M05_L20
M05_L17:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M05_L18:
       mov       rdx,[rbp-58]
       add       [rdx+4C],eax
       jmp       near ptr M05_L05
M05_L19:
       mov       rcx,offset MT_System.Text.RegularExpressions.Match
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M05_L06
M05_L20:
       xor       edx,edx
       mov       rcx,[rbp-58]
       mov       [rcx+8],rdx
       mov       rdx,[rbp+10]
       lea       rcx,[rdx+30]
       mov       rdx,[rbp-58]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rdi
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
M05_L21:
       mov       ecx,0E
       xor       edx,edx
       call      qword ptr [7FF997ED62B0]
       int       3
M05_L22:
       mov       ecx,8
       mov       edx,2
       call      qword ptr [7FF997ED62B0]
       int       3
M05_L23:
       mov       rax,[rcx+10]
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,[rbp+10]
       jmp       near ptr M05_L00
       sub       rsp,38
       xor       ecx,ecx
       mov       rdx,[rbp-58]
       mov       [rdx+8],rcx
       mov       rax,[rbp+10]
       lea       rcx,[rax+30]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,38
       ret
; Total bytes of code 1102
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Data.PostalCodeState, DotNetTips.Spargine.10.Core]](DotNetTips.Spargine.Core.Data.PostalCodeState ByRef)
       mov       rcx,rdx
       jmp       qword ptr [7FF997E3D650]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Core.Data.PostalCodeState, DotNetTips.Spargine.10.Core]](DotNetTips.Spargine.Core.Data.PostalCodeState ByRef)
; Total bytes of code 9
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M07_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M07_L00:
       call      qword ptr [7FF997ED5FC8]
       int       3
; Total bytes of code 44
```
```assembly
; System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>, Boolean ByRef)
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
       mov       [rbp-40],rcx
       mov       [rbp+28],r9
       mov       rbx,rcx
       mov       rdi,rdx
       mov       rsi,r8
       test      rdi,rdi
       je        near ptr M08_L70
       test      rsi,rsi
       je        near ptr M08_L71
       mov       rcx,[rbx+18]
       mov       r14,[rcx+28]
       test      r14,r14
       je        near ptr M08_L65
M08_L00:
       mov       rcx,[r14+18]
       mov       rax,[rcx+28]
       test      rax,rax
       je        near ptr M08_L66
M08_L01:
       cmp       [rdi],rax
       je        near ptr M08_L60
       mov       rcx,[r14+18]
       cmp       qword ptr [rcx+8],30
       jle       near ptr M08_L67
       mov       rax,[rcx+30]
       test      rax,rax
       je        near ptr M08_L67
M08_L02:
       cmp       [rdi],rax
       je        near ptr M08_L59
       mov       rcx,[rbx+18]
       cmp       qword ptr [rcx+8],30
       jle       near ptr M08_L68
       mov       r11,[rcx+30]
       test      r11,r11
       je        near ptr M08_L68
M08_L03:
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Core.Data.Models.CountryPhonePostalInfo>
       cmp       [rdi],rcx
       jne       near ptr M08_L77
       mov       rcx,[rdi+8]
       mov       r11,offset MT_DotNetTips.Spargine.Core.Data.Models.CountryPhonePostalInfo[]
       cmp       [rcx],r11
       jne       near ptr M08_L73
       mov       r14d,[rcx+8]
       test      r14d,r14d
       je        near ptr M08_L76
M08_L04:
       mov       rdi,[rdi+8]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Data.Models.CountryPhonePostalInfo[]
       cmp       [rdi],rcx
       jne       near ptr M08_L75
       mov       r14d,[rdi+8]
       test      r14d,r14d
       jne       near ptr M08_L69
       test      byte ptr [7FF997E84100],1
       je        near ptr M08_L74
M08_L05:
       mov       rcx,1B0BA0001D0
       mov       r15,[rcx]
M08_L06:
       mov       [rbp-48],r15
       cmp       qword ptr [rbp-48],0
       je        near ptr M08_L27
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Core.Data.Models.CountryPhonePostalInfo>
       mov       r15,[rbp-48]
       cmp       [r15],rcx
       jne       near ptr M08_L27
       mov       rcx,offset DotNetTips.Spargine.Core.Data.CountryPhonePostalInfoRepository+<>c__DisplayClass3_0.<GetCountryPhonePostalInfo>b__2(DotNetTips.Spargine.Core.Data.Models.CountryPhonePostalInfo)
       cmp       [rsi+18],rcx
       jne       near ptr M08_L27
       jmp       short M08_L10
M08_L07:
       mov       r10d,[r15+8]
       cmp       r10d,[r15+0C]
       jae       near ptr M08_L54
       mov       rdi,[r15+10]
       cmp       r10d,[rdi+8]
       jae       near ptr M08_L55
       mov       ecx,r10d
       mov       r14,[rdi+rcx*8+10]
       mov       r13,[rsi+8]
       mov       rcx,[r14+18]
       mov       r12,[r13+8]
       cmp       rcx,r12
       je        near ptr M08_L39
       test      rcx,rcx
       je        short M08_L08
       test      r12,r12
       je        short M08_L08
       mov       edx,[rcx+8]
       cmp       edx,[r12+8]
       je        short M08_L12
M08_L08:
       xor       eax,eax
M08_L09:
       test      eax,eax
       jne       short M08_L11
M08_L10:
       mov       eax,[r15+8]
       inc       eax
       cmp       eax,[r15+0C]
       jae       near ptr M08_L56
       mov       [r15+8],eax
       mov       rcx,[rbx+18]
       cmp       qword ptr [rcx+8],38
       jle       short M08_L07
       jmp       short M08_L07
M08_L11:
       mov       r9,[rbp+28]
       mov       byte ptr [r9],1
       jmp       near ptr M08_L57
M08_L12:
       add       rcx,0C
       lea       r8,[r12+0C]
       mov       r9d,[r12+8]
       cmp       r9d,8
       jl        short M08_L14
       cmp       r9d,10
       jl        short M08_L13
       mov       rdx,r8
       mov       r8d,r9d
       call      qword ptr [7FF997ED5C20]
       jmp       near ptr M08_L20
M08_L13:
       mov       rdx,r8
       mov       r8d,r9d
       call      qword ptr [7FF997E37EB8]; System.Globalization.Ordinal.EqualsIgnoreCase_Vector[[System.Runtime.Intrinsics.Vector128`1[[System.UInt16, System.Private.CoreLib]], System.Private.CoreLib]](Char ByRef, Char ByRef, Int32)
       jmp       near ptr M08_L20
M08_L14:
       xor       edx,edx
       cmp       r9d,4
       jb        short M08_L16
M08_L15:
       mov       rax,[rcx+rdx]
       mov       r10,[r8+rdx]
       mov       r11,rax
       or        r11,r10
       mov       rdi,r11
       shr       rdi,20
       or        edi,r11d
       test      edi,0FF80FF80
       jne       near ptr M08_L41
       xor       r10,rax
       shl       r10,2
       mov       r11,5000500050005
       add       rax,r11
       mov       r11,0A000A000A000A0
       or        rax,r11
       mov       r11,1A001A001A001A
       add       rax,r11
       mov       r11,0FF7FFF7FFF7FFF7F
       or        rax,r11
       test      rax,r10
       jne       near ptr M08_L23
       add       rdx,8
       add       r9d,0FFFFFFFC
       cmp       r9d,4
       jae       short M08_L15
M08_L16:
       cmp       r9d,2
       jae       short M08_L21
M08_L17:
       test      r9d,r9d
       jne       short M08_L22
M08_L18:
       mov       r10d,1
M08_L19:
       mov       eax,r10d
M08_L20:
       jmp       near ptr M08_L09
M08_L21:
       mov       edi,[rcx+rdx]
       mov       eax,[r8+rdx]
       mov       r10d,edi
       or        r10d,eax
       test      r10d,0FF80FF80
       jne       near ptr M08_L40
       xor       eax,edi
       shl       eax,2
       add       edi,50005
       or        edi,0A000A0
       add       edi,1A001A
       or        edi,0FF7FFF7F
       test      edi,eax
       jne       short M08_L23
       add       rdx,4
       add       r9d,0FFFFFFFE
       jmp       short M08_L17
M08_L22:
       movzx     edi,word ptr [rcx+rdx]
       movzx     eax,word ptr [r8+rdx]
       mov       r10d,edi
       or        r10d,eax
       cmp       r10d,7F
       ja        near ptr M08_L40
       cmp       edi,eax
       je        short M08_L18
       or        edi,20
       lea       r10d,[rdi-61]
       cmp       r10d,19
       ja        short M08_L23
       or        eax,20
       cmp       edi,eax
       sete      r10b
       movzx     r10d,r10b
       jmp       near ptr M08_L19
M08_L23:
       xor       r10d,r10d
       jmp       near ptr M08_L19
M08_L24:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Core.Data.Models.CountryPhonePostalInfo>
       cmp       [r15],rcx
       jne       near ptr M08_L44
       mov       r10d,[r15+8]
       cmp       r10d,[r15+0C]
       jae       near ptr M08_L54
       mov       rdi,[r15+10]
       cmp       r10d,[rdi+8]
       jae       near ptr M08_L55
       mov       ecx,r10d
       mov       r14,[rdi+rcx*8+10]
       mov       rcx,offset DotNetTips.Spargine.Core.Data.CountryPhonePostalInfoRepository+<>c__DisplayClass3_0.<GetCountryPhonePostalInfo>b__2(DotNetTips.Spargine.Core.Data.Models.CountryPhonePostalInfo)
       cmp       [rsi+18],rcx
       jne       near ptr M08_L45
       mov       r13,[rsi+8]
       mov       rcx,[r14+18]
       mov       r12,[r13+8]
       cmp       rcx,r12
       je        near ptr M08_L53
       test      rcx,rcx
       je        short M08_L25
       test      r12,r12
       je        short M08_L25
       mov       edx,[rcx+8]
       cmp       edx,[r12+8]
       je        short M08_L30
M08_L25:
       xor       eax,eax
M08_L26:
       test      eax,eax
       jne       near ptr M08_L11
M08_L27:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Core.Data.Models.CountryPhonePostalInfo>
       mov       r15,[rbp-48]
       cmp       [r15],rcx
       jne       near ptr M08_L43
       mov       eax,[r15+8]
       inc       eax
       cmp       eax,[r15+0C]
       jae       near ptr M08_L56
       mov       [r15+8],eax
M08_L28:
       mov       rcx,[rbx+18]
       cmp       qword ptr [rcx+8],38
       jle       short M08_L29
       mov       r11,[rcx+38]
       test      r11,r11
       jne       near ptr M08_L24
M08_L29:
       mov       rcx,rbx
       mov       rdx,7FF997F115B0
       call      qword ptr [7FF997A37B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M08_L24
M08_L30:
       add       rcx,0C
       lea       r8,[r12+0C]
       mov       r9d,[r12+8]
       cmp       r9d,8
       jl        short M08_L32
       cmp       r9d,10
       jl        short M08_L31
       mov       rdx,r8
       mov       r8d,r9d
       call      qword ptr [7FF997ED5C20]
       jmp       near ptr M08_L38
M08_L31:
       mov       rdx,r8
       mov       r8d,r9d
       call      qword ptr [7FF997E37EB8]; System.Globalization.Ordinal.EqualsIgnoreCase_Vector[[System.Runtime.Intrinsics.Vector128`1[[System.UInt16, System.Private.CoreLib]], System.Private.CoreLib]](Char ByRef, Char ByRef, Int32)
       jmp       near ptr M08_L38
M08_L32:
       xor       edx,edx
       cmp       r9d,4
       jb        short M08_L34
M08_L33:
       mov       rax,[rcx+rdx]
       mov       r10,[r8+rdx]
       mov       r11,rax
       or        r11,r10
       mov       rdi,r11
       shr       rdi,20
       or        edi,r11d
       test      edi,0FF80FF80
       jne       near ptr M08_L46
       xor       r10,rax
       shl       r10,2
       mov       r11,5000500050005
       add       r11,rax
       mov       rax,0A000A000A000A0
       or        rax,r11
       mov       r11,1A001A001A001A
       add       rax,r11
       mov       r11,0FF7FFF7FFF7FFF7F
       or        rax,r11
       test      rax,r10
       jne       near ptr M08_L52
       add       rdx,8
       add       r9d,0FFFFFFFC
       cmp       r9d,4
       jae       short M08_L33
M08_L34:
       cmp       r9d,2
       jae       near ptr M08_L47
M08_L35:
       test      r9d,r9d
       jne       near ptr M08_L48
M08_L36:
       mov       r10d,1
M08_L37:
       mov       eax,r10d
M08_L38:
       jmp       near ptr M08_L26
M08_L39:
       mov       eax,1
       jmp       near ptr M08_L09
M08_L40:
       test      edi,0FF80FF80
       je        near ptr M08_L23
       test      eax,0FF80FF80
       jne       short M08_L42
       jmp       near ptr M08_L23
M08_L41:
       mov       r11,0FF80FF80FF80FF80
       test      r11,rax
       je        near ptr M08_L23
       mov       rax,0FF80FF80FF80FF80
       test      rax,r10
       je        near ptr M08_L23
M08_L42:
       add       rcx,rdx
       add       r8,rdx
       mov       edx,r9d
       call      qword ptr [7FF997ED5DB8]
       test      eax,eax
       sete      r10b
       movzx     r10d,r10b
       jmp       near ptr M08_L19
M08_L43:
       mov       rcx,r15
       mov       r11,7FF997760A28
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M08_L28
       jmp       near ptr M08_L78
M08_L44:
       mov       rcx,r15
       call      qword ptr [r11]
       mov       r14,rax
M08_L45:
       mov       rdx,r14
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       jmp       near ptr M08_L26
M08_L46:
       mov       r11,0FF80FF80FF80FF80
       test      r11,rax
       je        near ptr M08_L52
       mov       rax,0FF80FF80FF80FF80
       test      rax,r10
       je        near ptr M08_L52
       jmp       short M08_L50
M08_L47:
       mov       edi,[rcx+rdx]
       mov       eax,[r8+rdx]
       mov       r10d,edi
       or        r10d,eax
       test      r10d,0FF80FF80
       jne       short M08_L49
       xor       eax,edi
       shl       eax,2
       lea       r10d,[rdi+50005]
       or        r10d,0A000A0
       add       r10d,1A001A
       or        r10d,0FF7FFF7F
       test      r10d,eax
       jne       short M08_L52
       add       rdx,4
       add       r9d,0FFFFFFFE
       jmp       near ptr M08_L35
M08_L48:
       movzx     edi,word ptr [rcx+rdx]
       movzx     eax,word ptr [r8+rdx]
       mov       r10d,edi
       or        r10d,eax
       cmp       r10d,7F
       jbe       short M08_L51
M08_L49:
       test      edi,0FF80FF80
       je        short M08_L52
       test      eax,0FF80FF80
       je        short M08_L52
M08_L50:
       add       rcx,rdx
       add       r8,rdx
       mov       edx,r9d
       call      qword ptr [7FF997ED5DB8]
       test      eax,eax
       sete      r10b
       movzx     r10d,r10b
       jmp       near ptr M08_L37
M08_L51:
       cmp       edi,eax
       je        near ptr M08_L36
       or        edi,20
       lea       r10d,[rdi-61]
       cmp       r10d,19
       ja        short M08_L52
       or        eax,20
       cmp       edi,eax
       sete      r10b
       movzx     r10d,r10b
       jmp       near ptr M08_L37
M08_L52:
       xor       r10d,r10d
       jmp       near ptr M08_L37
M08_L53:
       mov       eax,1
       jmp       near ptr M08_L26
M08_L54:
       mov       ecx,[r15+8]
       call      qword ptr [7FF997ED5B78]
       int       3
M08_L55:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M08_L56:
       mov       ecx,[r15+0C]
       mov       [r15+8],ecx
       jmp       near ptr M08_L78
M08_L57:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Core.Data.Models.CountryPhonePostalInfo>
       cmp       [r15],rcx
       jne       near ptr M08_L79
M08_L58:
       mov       rax,r14
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
M08_L59:
       mov       r15d,[rdi+10]
       mov       rbx,[rdi+8]
       cmp       [rbx+8],r15d
       jb        near ptr M08_L72
       add       rbx,10
       jmp       short M08_L61
M08_L60:
       lea       rbx,[rdi+10]
       mov       r15d,[rdi+8]
M08_L61:
       xor       edi,edi
       cmp       edi,r15d
       jge       short M08_L63
M08_L62:
       mov       r14,[rbx+rdi*8]
       mov       rdx,r14
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       jne       short M08_L64
       inc       edi
       cmp       edi,r15d
       jl        short M08_L62
M08_L63:
       mov       r9,[rbp+28]
       mov       byte ptr [r9],0
       xor       eax,eax
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
M08_L64:
       mov       r9,[rbp+28]
       mov       byte ptr [r9],1
       mov       rax,r14
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
M08_L65:
       mov       rcx,rbx
       mov       rdx,7FF997F11450
       call      qword ptr [7FF997A37B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r14,rax
       jmp       near ptr M08_L00
M08_L66:
       mov       rcx,r14
       mov       rdx,7FF997F117F0
       call      qword ptr [7FF997A37B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       jmp       near ptr M08_L01
M08_L67:
       mov       rcx,r14
       mov       rdx,7FF997F11880
       call      qword ptr [7FF997A37B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       jmp       near ptr M08_L02
M08_L68:
       mov       rcx,rbx
       mov       rdx,7FF997F114F8
       call      qword ptr [7FF997A37B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M08_L03
M08_L69:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Core.Data.Models.CountryPhonePostalInfo>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       dword ptr [r15+8],0FFFFFFFF
       mov       [r15+0C],r14d
       lea       rcx,[r15+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M08_L06
M08_L70:
       mov       ecx,11
       call      qword ptr [7FF997A37E58]
       int       3
M08_L71:
       mov       ecx,0C
       call      qword ptr [7FF997A37E58]
       int       3
M08_L72:
       call      qword ptr [7FF997A37A08]
       int       3
M08_L73:
       mov       r11,7FF997760A38
       call      qword ptr [r11]
       mov       r14d,eax
       test      r14d,r14d
       je        short M08_L76
       jmp       near ptr M08_L04
M08_L74:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Core.Data.Models.CountryPhonePostalInfo>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M08_L05
M08_L75:
       mov       rcx,rdi
       mov       r11,7FF997760A40
       call      qword ptr [r11]
       mov       r15,rax
       jmp       near ptr M08_L06
M08_L76:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Core.Data.Models.CountryPhonePostalInfo>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1B0BA0001D0
       mov       r15,[rcx]
       jmp       near ptr M08_L06
M08_L77:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       r15,rax
       jmp       near ptr M08_L06
M08_L78:
       call      M08_L80
       jmp       near ptr M08_L63
M08_L79:
       mov       rcx,r15
       mov       r11,7FF997760A30
       call      qword ptr [r11]
       jmp       near ptr M08_L58
M08_L80:
       sub       rsp,28
       cmp       qword ptr [rbp-48],0
       je        short M08_L81
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Core.Data.Models.CountryPhonePostalInfo>
       mov       r15,[rbp-48]
       cmp       [r15],rcx
       je        short M08_L81
       mov       rcx,r15
       mov       r11,7FF997760A30
       call      qword ptr [r11]
M08_L81:
       nop
       add       rsp,28
       ret
; Total bytes of code 2216
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
       jmp       qword ptr [7FF997815C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Data.CountryPhonePostalInfoRepositoryBenchmark.GetCountryPhonePostalInfo()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       call      qword ptr [7FF997E5F108]; DotNetTips.Spargine.Core.Data.CountryPhonePostalInfoRepository.GetCountryPhonePostalInfo()
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
; Total bytes of code 56
```
```assembly
; DotNetTips.Spargine.Core.Data.CountryPhonePostalInfoRepository.GetCountryPhonePostalInfo()
; 		_countries ??= DeserializeCountryPhonePostalInfo();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return _countries;
; 		^^^^^^^^^^^^^^^^^^
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+40]
       xor       edx,edx
       mov       [rbp-18],rdx
       lea       rdx,[rbp-18]
       mov       rbx,151A1D106C0
       mov       rcx,rbx
       call      System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rsi,11122C000F0
       cmp       qword ptr [rsi],0
       je        short M01_L01
M01_L00:
       mov       rsi,[rsi]
       lea       rdx,[rbp-18]
       mov       rcx,rbx
       call      System.Threading.Monitor.ExitIfLockTaken(System.Object, Boolean ByRef)
       jmp       short M01_L02
M01_L01:
       call      qword ptr [7FF997E5F120]; DotNetTips.Spargine.Core.Data.CountryPhonePostalInfoRepository.DeserializeCountryPhonePostalInfo()
       mov       rdx,rax
       mov       rcx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M01_L00
M01_L02:
       mov       rax,rsi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rbp
       ret
       sub       rsp,28
       lea       rdx,[rbp-18]
       mov       rbx,151A1D106C0
       mov       rcx,rbx
       call      System.Threading.Monitor.ExitIfLockTaken(System.Object, Boolean ByRef)
       nop
       add       rsp,28
       ret
; Total bytes of code 135
```

