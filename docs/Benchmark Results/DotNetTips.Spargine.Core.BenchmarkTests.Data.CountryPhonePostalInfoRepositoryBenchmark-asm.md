## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
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
       sub       rsp,68
       lea       rbp,[rsp+0A0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-60],ymm4
       xor       eax,eax
       mov       [rbp-40],rax
       mov       [rbp+10],rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Data.CountryPhonePostalInfoRepository+<>c__DisplayClass5_0
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,28A1AD706A0
       mov       [rbx+8],rcx
       mov       rdx,[rbx+8]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFDF4D3EE20]; DotNetTips.Spargine.Core.Data.CountryPhonePostalInfoRepository.GetCountryPhonePostalInfo()
       mov       rsi,rax
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],2
       je        near ptr M00_L65
       cmp       dword ptr [rcx+8],3
       je        near ptr M00_L66
       test      rsi,rsi
       je        near ptr M00_L67
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Data.Models.CountryPhonePostalInfo[]
       cmp       [rsi],rcx
       je        near ptr M00_L58
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Core.Data.Models.CountryPhonePostalInfo>
       cmp       [rsi],rcx
       je        near ptr M00_L57
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Core.Data.Models.CountryPhonePostalInfo>
       cmp       [rsi],rcx
       jne       near ptr M00_L73
       mov       rcx,[rsi+8]
       mov       r11,offset MT_DotNetTips.Spargine.Core.Data.Models.CountryPhonePostalInfo[]
       cmp       [rcx],r11
       jne       near ptr M00_L69
       mov       edi,[rcx+8]
       test      edi,edi
       je        near ptr M00_L72
M00_L00:
       mov       rsi,[rsi+8]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Data.Models.CountryPhonePostalInfo[]
       cmp       [rsi],rcx
       jne       near ptr M00_L71
       mov       edi,[rsi+8]
       test      edi,edi
       jne       near ptr M00_L64
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Core.Data.Models.CountryPhonePostalInfo>
       test      byte ptr [7FFDF4DE6698],1
       je        near ptr M00_L70
M00_L01:
       mov       rcx,2499BC00230
       mov       r14,[rcx]
M00_L02:
       mov       [rbp-68],r14
       cmp       qword ptr [rbp-68],0
       je        near ptr M00_L18
       mov       r14,[rbp-68]
       mov       rsi,[r14]
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Core.Data.Models.CountryPhonePostalInfo>
       cmp       rsi,rcx
       jne       near ptr M00_L18
       jmp       short M00_L05
M00_L03:
       xor       eax,eax
M00_L04:
       test      eax,eax
       jne       near ptr M00_L45
M00_L05:
       mov       eax,[r14+8]
       inc       eax
       cmp       eax,[r14+0C]
       jae       near ptr M00_L32
       mov       [r14+8],eax
       mov       r10d,[r14+8]
       cmp       r10d,[r14+0C]
       jae       near ptr M00_L43
       mov       rdi,[r14+10]
       cmp       r10d,[rdi+8]
       jae       near ptr M00_L44
       mov       ecx,r10d
       mov       r15,[rdi+rcx*8+10]
       mov       rcx,[r15+18]
       mov       r13,[rbx+8]
       cmp       rcx,r13
       je        near ptr M00_L28
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
       call      qword ptr [7FFDF4E0C318]
       jmp       near ptr M00_L13
M00_L06:
       mov       rdx,r8
       mov       r8d,r9d
       call      qword ptr [7FFDF4D3F798]; System.Globalization.Ordinal.EqualsIgnoreCase_Vector[[System.Runtime.Intrinsics.Vector128`1[[System.UInt16, System.Private.CoreLib]], System.Private.CoreLib]](Char ByRef, Char ByRef, Int32)
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
       jne       near ptr M00_L30
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
       jne       near ptr M00_L15
       add       r12,8
       add       r9d,0FFFFFFFC
       cmp       r9d,4
       jae       short M00_L08
M00_L09:
       cmp       r9d,2
       jb        short M00_L10
       mov       edx,[rcx+r12]
       mov       eax,[r8+r12]
       mov       r10d,edx
       or        r10d,eax
       test      r10d,0FF80FF80
       jne       near ptr M00_L29
       xor       eax,edx
       shl       eax,2
       add       edx,50005
       or        edx,0A000A0
       add       edx,1A001A
       or        edx,0FF7FFF7F
       test      edx,eax
       jne       short M00_L15
       add       r12,4
       add       r9d,0FFFFFFFE
M00_L10:
       test      r9d,r9d
       jne       short M00_L14
M00_L11:
       mov       r10d,1
M00_L12:
       mov       eax,r10d
M00_L13:
       jmp       near ptr M00_L04
M00_L14:
       movzx     edx,word ptr [rcx+r12]
       movzx     eax,word ptr [r8+r12]
       mov       r10d,edx
       or        r10d,eax
       cmp       r10d,7F
       ja        near ptr M00_L29
       cmp       edx,eax
       je        short M00_L11
       or        edx,20
       lea       r10d,[rdx-61]
       cmp       r10d,19
       ja        short M00_L15
       or        eax,20
       cmp       edx,eax
       sete      r10b
       movzx     r10d,r10b
       jmp       short M00_L12
M00_L15:
       xor       r10d,r10d
       jmp       short M00_L12
M00_L16:
       xor       eax,eax
M00_L17:
       test      eax,eax
       jne       near ptr M00_L45
M00_L18:
       mov       r14,[rbp-68]
       mov       rsi,[r14]
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Core.Data.Models.CountryPhonePostalInfo>
       cmp       rsi,rcx
       jne       near ptr M00_L33
       mov       eax,[r14+8]
       inc       eax
       cmp       eax,[r14+0C]
       jae       near ptr M00_L34
       mov       [r14+8],eax
       mov       ecx,[r14+8]
       cmp       ecx,[r14+0C]
       jae       near ptr M00_L43
       mov       rdi,[r14+10]
       mov       r10d,[r14+8]
       cmp       r10d,[rdi+8]
       jae       near ptr M00_L44
       mov       ecx,r10d
       mov       r15,[rdi+rcx*8+10]
       mov       rcx,[r15+18]
       mov       r13,[rbx+8]
       cmp       rcx,r13
       je        near ptr M00_L42
       test      rcx,rcx
       je        short M00_L16
       test      r13,r13
       je        short M00_L16
       mov       edx,[rcx+8]
       cmp       edx,[r13+8]
       jne       near ptr M00_L16
       add       rcx,0C
       lea       r8,[r13+0C]
       mov       r9d,[r13+8]
       cmp       r9d,8
       jl        short M00_L20
       cmp       r9d,10
       jl        short M00_L19
       mov       rdx,r8
       mov       r8d,r9d
       call      qword ptr [7FFDF4E0C318]
       jmp       near ptr M00_L26
M00_L19:
       mov       rdx,r8
       mov       r8d,r9d
       call      qword ptr [7FFDF4D3F798]; System.Globalization.Ordinal.EqualsIgnoreCase_Vector[[System.Runtime.Intrinsics.Vector128`1[[System.UInt16, System.Private.CoreLib]], System.Private.CoreLib]](Char ByRef, Char ByRef, Int32)
       jmp       near ptr M00_L26
M00_L20:
       xor       r12d,r12d
       cmp       r9d,4
       jb        short M00_L22
M00_L21:
       mov       rdx,[rcx+r12]
       mov       rax,[r8+r12]
       mov       r10,rdx
       or        r10,rax
       mov       r11,r10
       shr       r11,20
       or        r11d,r10d
       test      r11d,0FF80FF80
       jne       near ptr M00_L36
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
       jne       short M00_L27
       add       r12,8
       add       r9d,0FFFFFFFC
       cmp       r9d,4
       jae       short M00_L21
M00_L22:
       cmp       r9d,2
       jae       near ptr M00_L37
M00_L23:
       test      r9d,r9d
       jne       near ptr M00_L38
M00_L24:
       mov       r10d,1
M00_L25:
       mov       eax,r10d
M00_L26:
       jmp       near ptr M00_L17
M00_L27:
       xor       r10d,r10d
       jmp       short M00_L25
M00_L28:
       mov       eax,1
       jmp       near ptr M00_L04
M00_L29:
       test      edx,0FF80FF80
       je        near ptr M00_L15
       test      eax,0FF80FF80
       jne       short M00_L31
       jmp       near ptr M00_L15
M00_L30:
       mov       r10,0FF80FF80FF80FF80
       test      r10,rdx
       je        near ptr M00_L15
       mov       rdx,0FF80FF80FF80FF80
       test      rdx,rax
       je        near ptr M00_L15
M00_L31:
       add       rcx,r12
       add       r8,r12
       mov       edx,r9d
       call      qword ptr [7FFDF4E0C4B0]
       test      eax,eax
       sete      r10b
       movzx     r10d,r10b
       jmp       near ptr M00_L12
M00_L32:
       mov       ecx,[r14+0C]
       mov       [r14+8],ecx
       jmp       near ptr M00_L74
M00_L33:
       mov       rcx,r14
       mov       r11,7FFDF4560B88
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L35
       jmp       near ptr M00_L74
M00_L34:
       mov       ecx,[r14+0C]
       mov       [r14+8],ecx
       jmp       near ptr M00_L74
M00_L35:
       mov       rcx,r14
       mov       r11,7FFDF4560B90
       call      qword ptr [r11]
       mov       r15,rax
       mov       rcx,rbx
       mov       rdx,r15
       mov       rax,offset DotNetTips.Spargine.Core.Data.CountryPhonePostalInfoRepository+<>c__DisplayClass5_0.<GetCountryPhonePostalInfo>b__2(DotNetTips.Spargine.Core.Data.Models.CountryPhonePostalInfo)
       call      rax
       jmp       near ptr M00_L17
M00_L36:
       mov       r10,0FF80FF80FF80FF80
       test      r10,rdx
       je        near ptr M00_L27
       mov       rdx,0FF80FF80FF80FF80
       test      rdx,rax
       je        near ptr M00_L27
       jmp       short M00_L40
M00_L37:
       mov       edx,[rcx+r12]
       mov       eax,[r8+r12]
       mov       r10d,edx
       or        r10d,eax
       test      r10d,0FF80FF80
       jne       short M00_L39
       xor       eax,edx
       shl       eax,2
       add       edx,50005
       or        edx,0A000A0
       add       edx,1A001A
       or        edx,0FF7FFF7F
       test      edx,eax
       jne       near ptr M00_L27
       add       r12,4
       add       r9d,0FFFFFFFE
       jmp       near ptr M00_L23
M00_L38:
       movzx     edx,word ptr [rcx+r12]
       movzx     eax,word ptr [r8+r12]
       mov       r10d,edx
       or        r10d,eax
       cmp       r10d,7F
       jbe       short M00_L41
M00_L39:
       test      edx,0FF80FF80
       je        near ptr M00_L27
       test      eax,0FF80FF80
       je        near ptr M00_L27
M00_L40:
       add       rcx,r12
       add       r8,r12
       mov       edx,r9d
       call      qword ptr [7FFDF4E0C4B0]
       test      eax,eax
       sete      r10b
       movzx     r10d,r10b
       jmp       near ptr M00_L25
M00_L41:
       cmp       edx,eax
       je        near ptr M00_L24
       or        edx,20
       lea       r10d,[rdx-61]
       cmp       r10d,19
       ja        near ptr M00_L27
       or        eax,20
       cmp       edx,eax
       sete      r10b
       movzx     r10d,r10b
       jmp       near ptr M00_L25
M00_L42:
       mov       eax,1
       jmp       near ptr M00_L17
M00_L43:
       mov       ecx,[r14+8]
       call      qword ptr [7FFDF4E0DA88]
       int       3
M00_L44:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L45:
       mov       rsi,[r14]
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Core.Data.Models.CountryPhonePostalInfo>
       cmp       rsi,rcx
       jne       near ptr M00_L75
M00_L46:
       test      r15,r15
       je        near ptr M00_L63
       mov       rbx,[r15+30]
M00_L47:
       test      rbx,rbx
       je        near ptr M00_L76
       cmp       dword ptr [rbx+8],0
       je        near ptr M00_L76
       mov       rsi,28A1AD706D0
       xor       edi,edi
M00_L48:
       cmp       edi,0A
       jae       near ptr M00_L82
       movzx     ecx,word ptr [rsi+rdi*2+0C]
       cmp       ecx,100
       jge       near ptr M00_L77
       cmp       ecx,100
       jae       near ptr M00_L82
       mov       rax,7FFE3E8F6920
       test      byte ptr [rax+rcx],80
       jne       near ptr M00_L78
M00_L49:
       mov       rcx,rbx
       call      qword ptr [7FFDF4D3F7B0]; System.Text.RegularExpressions.RegexCache.GetOrAdd(System.String)
       mov       rbx,rax
       mov       edi,0A
       xor       ecx,ecx
       test      byte ptr [rbx+40],40
       cmove     edi,ecx
       mov       [rbp-70],rbx
       cmp       edi,0A
       ja        near ptr M00_L80
       lea       rcx,[rbx+30]
       xor       eax,eax
       mov       r14,rax
       xchg      r14,[rcx]
       test      r14,r14
       je        near ptr M00_L81
M00_L50:
       mov       [rbp-78],r14
       mov       rdx,[rbx+48]
       mov       rcx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFDF4E04CF0]; System.Text.RegularExpressions.RegexRunner.InitializeTimeout(System.TimeSpan)
       mov       [r14+8],rsi
       add       rsi,0C
       mov       [rbp-60],rsi
       mov       dword ptr [rbp-58],0A
       xor       r8d,r8d
       mov       [rsp+20],r8d
       lea       r8,[rbp-60]
       mov       rdx,rbx
       mov       rcx,r14
       mov       r9d,edi
       cmp       [rcx],ecx
       call      qword ptr [7FFDF4E04D20]; System.Text.RegularExpressions.RegexRunner.InitializeForScan(System.Text.RegularExpressions.Regex, System.ReadOnlySpan`1<Char>, Int32, System.Text.RegularExpressions.RegexRunnerMode)
       mov       [rbp-60],rsi
       mov       dword ptr [rbp-58],0A
       lea       rdx,[rbp-60]
       mov       rcx,r14
       mov       rax,[r14]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rsi,[r14+28]
       mov       rcx,[rsi+50]
       cmp       dword ptr [rcx+8],0
       jbe       short M00_L53
       cmp       dword ptr [rcx+10],0
       jg        short M00_L52
       xor       ecx,ecx
       mov       [rsi+8],rcx
       test      byte ptr [7FFDF4DFDD58],1
       je        short M00_L54
M00_L51:
       mov       rcx,2499BC00218
       mov       rdi,[rcx]
       jmp       short M00_L55
M00_L52:
       xor       ecx,ecx
       mov       [rsi+8],rcx
       xor       edi,edi
       jmp       short M00_L55
M00_L53:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L54:
       mov       rcx,offset MT_System.Text.RegularExpressions.Match
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       short M00_L51
M00_L55:
       xor       ecx,ecx
       mov       [r14+8],rcx
       lea       rcx,[rbx+30]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       jne       near ptr M00_L79
       mov       ebx,2
M00_L56:
       mov       [rbp-50],ebx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+18]
       lea       rdx,[rbp-50]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF4E04EE8]; BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Data.PostalCodeState, DotNetTips.Spargine.10.Core]](DotNetTips.Spargine.Core.Data.PostalCodeState ByRef)
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
M00_L57:
       mov       r15d,[rsi+10]
       mov       r14,[rsi+8]
       cmp       [r14+8],r15d
       jb        near ptr M00_L68
       add       r14,10
       jmp       short M00_L59
M00_L58:
       lea       r14,[rsi+10]
       mov       r15d,[rsi+8]
M00_L59:
       xor       esi,esi
       cmp       esi,r15d
       jge       short M00_L61
M00_L60:
       mov       rdi,[r14+rsi*8]
       mov       rcx,rbx
       mov       rdx,rdi
       mov       rax,offset DotNetTips.Spargine.Core.Data.CountryPhonePostalInfoRepository+<>c__DisplayClass5_0.<GetCountryPhonePostalInfo>b__2(DotNetTips.Spargine.Core.Data.Models.CountryPhonePostalInfo)
       call      rax
       test      eax,eax
       jne       short M00_L62
       inc       esi
       cmp       esi,r15d
       jl        short M00_L60
M00_L61:
       xor       r15d,r15d
       jmp       near ptr M00_L46
M00_L62:
       mov       r15,rdi
       jmp       near ptr M00_L46
M00_L63:
       xor       ebx,ebx
       jmp       near ptr M00_L47
M00_L64:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Core.Data.Models.CountryPhonePostalInfo>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       dword ptr [r14+8],0FFFFFFFF
       mov       [r14+0C],edi
       lea       rcx,[r14+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L02
M00_L65:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Core.Data.Models.CountryPhonePostalInfo, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       lea       rcx,[r15+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,7FFDF4D3ADC0
       mov       [r15+18],r9
       lea       r9,[rbp-40]
       mov       rdx,rsi
       mov       r8,r15
       mov       rcx,7FFDF4DE6468
       call      qword ptr [7FFDF4D37C78]; System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>, Boolean ByRef)
       mov       r15,rax
       jmp       near ptr M00_L46
M00_L66:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Core.Data.Models.CountryPhonePostalInfo, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       mov       rdx,rbx
       mov       r8,7FFDF4D3ADD8
       call      qword ptr [7FFDF4616BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       lea       r9,[rbp-48]
       mov       rdx,rsi
       mov       r8,r15
       mov       rcx,7FFDF4DE6468
       call      qword ptr [7FFDF4D37C78]; System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>, Boolean ByRef)
       mov       r15,rax
       jmp       near ptr M00_L46
M00_L67:
       mov       ecx,11
       call      qword ptr [7FFDF4897DF8]
       int       3
M00_L68:
       call      qword ptr [7FFDF48979A8]
       int       3
M00_L69:
       mov       r11,7FFDF4560BA0
       call      qword ptr [r11]
       mov       edi,eax
       test      edi,edi
       je        short M00_L72
       jmp       near ptr M00_L00
M00_L70:
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L01
M00_L71:
       mov       rcx,rsi
       mov       r11,7FFDF4560BA8
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L02
M00_L72:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Core.Data.Models.CountryPhonePostalInfo>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,2499BC00230
       mov       r14,[rcx]
       jmp       near ptr M00_L02
M00_L73:
       mov       rcx,rsi
       mov       r11,7FFDF4560B80
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L02
M00_L74:
       call      M00_L83
       jmp       near ptr M00_L61
M00_L75:
       mov       rcx,r14
       mov       r11,7FFDF4560B98
       call      qword ptr [r11]
       jmp       near ptr M00_L46
M00_L76:
       mov       ebx,1
       jmp       near ptr M00_L56
M00_L77:
       call      qword ptr [7FFDF4E07EE8]
       test      eax,eax
       je        near ptr M00_L49
M00_L78:
       inc       edi
       cmp       edi,0A
       jl        near ptr M00_L48
M00_L79:
       xor       ebx,ebx
       jmp       near ptr M00_L56
M00_L80:
       mov       ecx,0E
       xor       edx,edx
       call      qword ptr [7FFDF4E0E0B8]
       int       3
M00_L81:
       mov       rcx,[rbx+10]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       r14,rax
       jmp       near ptr M00_L50
M00_L82:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L83:
       sub       rsp,28
       cmp       qword ptr [rbp-68],0
       je        short M00_L84
       mov       r14,[rbp-68]
       mov       rsi,[r14]
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Core.Data.Models.CountryPhonePostalInfo>
       cmp       rsi,rcx
       je        short M00_L84
       mov       rcx,r14
       mov       r11,7FFDF4560B98
       call      qword ptr [r11]
M00_L84:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       xor       ecx,ecx
       mov       rdx,[rbp-78]
       mov       [rdx+8],rcx
       mov       rax,[rbp-70]
       lea       rcx,[rax+30]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       ret
; Total bytes of code 2653
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
       mov       rbx,28A1AD70738
       mov       rcx,rbx
       call      System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rsi,2499BC000D0
       cmp       qword ptr [rsi],0
       je        short M01_L01
M01_L00:
       mov       rsi,[rsi]
       lea       rdx,[rbp-18]
       mov       rcx,rbx
       call      System.Threading.Monitor.ExitIfLockTaken(System.Object, Boolean ByRef)
       jmp       short M01_L02
M01_L01:
       call      qword ptr [7FFDF4D3EE38]; DotNetTips.Spargine.Core.Data.CountryPhonePostalInfoRepository.DeserializeCountryPhonePostalInfo()
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
       mov       rbx,28A1AD70738
       mov       rcx,rbx
       call      System.Threading.Monitor.ExitIfLockTaken(System.Object, Boolean ByRef)
       nop
       add       rsp,28
       ret
; Total bytes of code 135
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
       vbroadcastss xmm0,dword ptr [7FFDF4E90C30]
       vbroadcastss xmm1,dword ptr [7FFDF4E90C34]
       vbroadcastss xmm2,dword ptr [7FFDF4E90C38]
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
       vbroadcastss xmm2,dword ptr [7FFDF4E90C38]
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
       vbroadcastss xmm6,dword ptr [7FFDF4E90C3C]
       vpaddw    xmm5,xmm5,xmm6
       vpcmpgtw  xmm5,xmm5,[7FFDF4E90C40]
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
       call      qword ptr [7FFDF4E0C4B0]
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
       vbroadcastss xmm6,dword ptr [7FFDF4E90C3C]
       vpaddw    xmm0,xmm0,xmm6
       vpcmpgtw  xmm0,xmm0,[7FFDF4E90C40]
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
; DotNetTips.Spargine.Core.Data.CountryPhonePostalInfoRepository+<>c__DisplayClass5_0.<GetCountryPhonePostalInfo>b__2(DotNetTips.Spargine.Core.Data.Models.CountryPhonePostalInfo)
; 			info = countryData.FirstOrDefault(p => string.Equals(p.Name, countryNameOrIso, StringComparison.OrdinalIgnoreCase));
; 			                                       ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       jmp       qword ptr [7FFDF4D3F780]; System.String.EqualsOrdinalIgnoreCaseNoLengthCheck(System.String, System.String)
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
       mov       rcx,[rcx+38]
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
       mov       rax,24985C00110
       mov       rsi,[rax]
       test      rsi,rsi
       jne       short M04_L01
       mov       rax,24985C000F0
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
       mov       rcx,2499BC00128
       mov       r14,[rcx]
       test      r14,r14
       je        near ptr M04_L18
       mov       rdx,[r14+18]
       mov       rbp,[r14+20]
       mov       r15d,[r14+28]
       mov       r13,[r14+30]
       cmp       rbx,rdx
       jne       near ptr M04_L11
M04_L03:
       cmp       [rdi],dil
       cmp       rdi,rbp
       jne       near ptr M04_L14
M04_L04:
       test      r15d,r15d
       jne       near ptr M04_L17
       cmp       r13,0FFFFFFFFFFFFD8F0
       jne       near ptr M04_L17
       mov       rbp,[r14+8]
M04_L05:
       xor       ecx,ecx
       mov       [rsp+48],rcx
       test      rbp,rbp
       je        near ptr M04_L20
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
       call      qword ptr [7FFDF4E0E088]
       int       3
M04_L08:
       mov       ecx,2
       call      qword ptr [7FFDF4E0C378]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M04_L00
M04_L09:
       call      qword ptr [7FFDF4895DA0]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
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
       je        near ptr M04_L17
       mov       ecx,[rbx+8]
       cmp       ecx,[rdx+8]
       jne       near ptr M04_L17
       lea       rcx,[rbx+0C]
       add       rdx,0C
       mov       r8d,[rbx+8]
       add       r8d,r8d
       cmp       r8,0A
       jne       short M04_L12
       mov       rax,[rcx]
       mov       rcx,[rcx+2]
       mov       r8,[rdx]
       xor       r8,rax
       xor       rcx,[rdx+2]
       or        rcx,r8
       sete      al
       movzx     eax,al
       jmp       short M04_L13
M04_L12:
       call      qword ptr [7FFDF461FB88]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
M04_L13:
       test      eax,eax
       je        short M04_L17
       jmp       near ptr M04_L03
M04_L14:
       test      rbp,rbp
       je        short M04_L17
       mov       ecx,[rdi+8]
       cmp       ecx,[rbp+8]
       jne       short M04_L17
       lea       rcx,[rdi+0C]
       lea       rdx,[rbp+0C]
       mov       r8d,[rdi+8]
       add       r8d,r8d
       cmp       r8,0A
       jne       short M04_L15
       mov       rax,[rcx]
       mov       rcx,[rcx+2]
       mov       r8,[rdx]
       xor       r8,rax
       xor       rcx,[rdx+2]
       or        rcx,r8
       sete      al
       movzx     eax,al
       jmp       short M04_L16
M04_L15:
       call      qword ptr [7FFDF461FB88]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
M04_L16:
       test      eax,eax
       jne       near ptr M04_L04
M04_L17:
       mov       rbp,[r14+10]
M04_L18:
       cmp       dword ptr [7FFDF455B170],0
       je        short M04_L19
       mov       [rsp+28],rbx
       mov       [rsp+30],rdi
       xor       edx,edx
       mov       [rsp+38],edx
       mov       qword ptr [rsp+40],0FFFFFFFFFFFFD8F0
       lea       rdx,[rsp+28]
       mov       rcx,2499BC00130
       mov       rcx,[rcx]
       lea       r8,[rsp+48]
       call      qword ptr [7FFDF4DE9390]; Precode of System.Collections.Concurrent.ConcurrentDictionary`2[[System.Text.RegularExpressions.RegexCache+Key, System.Text.RegularExpressions],[System.__Canon, System.Private.CoreLib]].TryGetValue(Key, System.__Canon ByRef)
       test      eax,eax
       je        short M04_L19
       mov       rcx,[rsp+48]
       inc       rbp
       mov       [rcx+10],rbp
       mov       rdx,[rsp+48]
       mov       rcx,2499BC00128
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsp+48]
       mov       rbp,[rcx+8]
       jmp       near ptr M04_L05
M04_L19:
       xor       ebp,ebp
       jmp       near ptr M04_L05
M04_L20:
       mov       rcx,offset MT_System.Text.RegularExpressions.Regex
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       mov       rdx,rbx
       mov       r8,rsi
       call      qword ptr [7FFDF4D3FA50]; System.Text.RegularExpressions.Regex..ctor(System.String, System.Globalization.CultureInfo)
       mov       [rsp+28],rbx
       mov       [rsp+30],rdi
       xor       ecx,ecx
       mov       [rsp+38],ecx
       mov       qword ptr [rsp+40],0FFFFFFFFFFFFD8F0
       lea       rcx,[rsp+28]
       mov       rdx,rbp
       call      qword ptr [7FFDF4E04B88]; System.Text.RegularExpressions.RegexCache.Add(Key, System.Text.RegularExpressions.Regex)
       jmp       near ptr M04_L06
; Total bytes of code 707
```
```assembly
; System.Text.RegularExpressions.RegexRunner.InitializeTimeout(System.TimeSpan)
       mov       byte ptr [rcx+68],0
       cmp       rdx,0FFFFFFFFFFFFD8F0
       jne       short M05_L00
       ret
M05_L00:
       jmp       qword ptr [7FFDF4E0E0E8]
; Total bytes of code 20
```
```assembly
; System.Text.RegularExpressions.RegexRunner.InitializeForScan(System.Text.RegularExpressions.Regex, System.ReadOnlySpan`1<Char>, Int32, System.Text.RegularExpressions.RegexRunnerMode)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       esi,r9d
       mov       edi,[r8+8]
       mov       ecx,[rsp+80]
       mov       [rbx+60],ecx
       lea       rcx,[rbx+30]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+48],esi
       xor       ecx,ecx
       mov       [rbx+40],ecx
       mov       [rbx+44],edi
       mov       [rbx+4C],esi
       mov       rsi,[rbx+28]
       test      rsi,rsi
       je        short M06_L04
       mov       rdx,[rbx+8]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+34],ecx
       mov       [rsi+5C],edi
       mov       rcx,[rsi+50]
       mov       eax,[rcx+8]
       test      eax,eax
       jle       short M06_L01
       add       rcx,10
M06_L00:
       xor       edx,edx
       mov       [rcx],edx
       add       rcx,4
       dec       eax
       jne       short M06_L00
M06_L01:
       mov       byte ptr [rsi+60],0
       mov       rcx,[rsi+38]
       test      rcx,rcx
       je        short M06_L02
       xor       eax,eax
       mov       [rcx+18],rax
M06_L02:
       mov       rcx,[rbx+20]
       test      rcx,rcx
       je        near ptr M06_L07
       mov       rax,[rbx+10]
       mov       eax,[rax+8]
       mov       [rbx+50],eax
       mov       rax,[rbx+18]
       mov       eax,[rax+8]
       mov       [rbx+54],eax
       mov       ecx,[rcx+8]
       mov       [rbx+58],ecx
M06_L03:
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M06_L04:
       mov       rsi,[rbx+30]
       mov       rbp,[rsi+18]
       test      rbp,rbp
       je        short M06_L06
       mov       rcx,offset MT_System.Text.RegularExpressions.MatchSparse
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdx,rsi
       mov       [rsp+20],edi
       mov       r8d,[rsi+44]
       mov       r9,[rbx+8]
       mov       rcx,r14
       call      qword ptr [7FFDF4E04D80]; System.Text.RegularExpressions.Match..ctor(System.Text.RegularExpressions.Regex, Int32, System.String, Int32)
       lea       rcx,[r14+68]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
M06_L05:
       lea       rcx,[rbx+28]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M06_L02
M06_L06:
       mov       rcx,offset MT_System.Text.RegularExpressions.Match
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       [rsp+20],edi
       mov       r8d,[rsi+44]
       mov       rdx,rsi
       mov       r9,[rbx+8]
       mov       rcx,r14
       call      qword ptr [7FFDF4E04D80]; System.Text.RegularExpressions.Match..ctor(System.Text.RegularExpressions.Regex, Int32, System.String, Int32)
       jmp       short M06_L05
M06_L07:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       esi,[rbx+5C]
       shl       esi,3
       mov       edi,esi
       mov       edx,20
       cmp       esi,20
       cmovl     edi,edx
       mov       edx,10
       cmp       esi,10
       cmovl     esi,edx
       movsxd    rdx,edi
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rbx+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+50],edi
       movsxd    rdx,esi
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rbx+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+54],esi
       mov       rcx,offset MT_System.Int32[]
       mov       edx,20
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rbx+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+58],20
       jmp       near ptr M06_L03
; Total bytes of code 460
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M07_L00
       ret
M07_L00:
       jmp       qword ptr [7FFDF4615C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Data.PostalCodeState, DotNetTips.Spargine.10.Core]](DotNetTips.Spargine.Core.Data.PostalCodeState ByRef)
       mov       rcx,rdx
       jmp       qword ptr [7FFDF4E04F30]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Core.Data.PostalCodeState, DotNetTips.Spargine.10.Core]](DotNetTips.Spargine.Core.Data.PostalCodeState ByRef)
; Total bytes of code 9
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
       je        near ptr M09_L70
       test      rsi,rsi
       je        near ptr M09_L71
       mov       rcx,[rbx+18]
       mov       r14,[rcx+28]
       test      r14,r14
       je        near ptr M09_L65
M09_L00:
       mov       rcx,[r14+18]
       mov       rax,[rcx+28]
       test      rax,rax
       je        near ptr M09_L66
M09_L01:
       cmp       [rdi],rax
       je        near ptr M09_L60
       mov       rcx,[r14+18]
       cmp       qword ptr [rcx+8],30
       jle       near ptr M09_L67
       mov       rax,[rcx+30]
       test      rax,rax
       je        near ptr M09_L67
M09_L02:
       cmp       [rdi],rax
       je        near ptr M09_L59
       mov       rcx,[rbx+18]
       cmp       qword ptr [rcx+8],30
       jle       near ptr M09_L68
       mov       r11,[rcx+30]
       test      r11,r11
       je        near ptr M09_L68
M09_L03:
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Core.Data.Models.CountryPhonePostalInfo>
       cmp       [rdi],rcx
       jne       near ptr M09_L77
       mov       rcx,[rdi+8]
       mov       r11,offset MT_DotNetTips.Spargine.Core.Data.Models.CountryPhonePostalInfo[]
       cmp       [rcx],r11
       jne       near ptr M09_L73
       mov       r14d,[rcx+8]
       test      r14d,r14d
       je        near ptr M09_L76
M09_L04:
       mov       rdi,[rdi+8]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Data.Models.CountryPhonePostalInfo[]
       cmp       [rdi],rcx
       jne       near ptr M09_L75
       mov       r14d,[rdi+8]
       test      r14d,r14d
       jne       near ptr M09_L69
       test      byte ptr [7FFDF4DE6698],1
       je        near ptr M09_L74
M09_L05:
       mov       rcx,2499BC00230
       mov       r15,[rcx]
M09_L06:
       mov       [rbp-48],r15
       cmp       qword ptr [rbp-48],0
       je        near ptr M09_L26
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Core.Data.Models.CountryPhonePostalInfo>
       mov       r15,[rbp-48]
       cmp       [r15],rcx
       jne       near ptr M09_L26
       mov       rcx,offset DotNetTips.Spargine.Core.Data.CountryPhonePostalInfoRepository+<>c__DisplayClass5_0.<GetCountryPhonePostalInfo>b__2(DotNetTips.Spargine.Core.Data.Models.CountryPhonePostalInfo)
       cmp       [rsi+18],rcx
       jne       near ptr M09_L26
       jmp       short M09_L10
M09_L07:
       mov       r10d,[r15+8]
       cmp       r10d,[r15+0C]
       jae       near ptr M09_L55
       mov       rdi,[r15+10]
       cmp       r10d,[rdi+8]
       jae       near ptr M09_L56
       mov       ecx,r10d
       mov       r14,[rdi+rcx*8+10]
       mov       r13,[rsi+8]
       mov       rcx,[r14+18]
       mov       r12,[r13+8]
       cmp       rcx,r12
       je        near ptr M09_L38
       test      rcx,rcx
       je        short M09_L08
       test      r12,r12
       je        short M09_L08
       mov       edx,[rcx+8]
       cmp       edx,[r12+8]
       je        short M09_L12
M09_L08:
       xor       eax,eax
M09_L09:
       test      eax,eax
       jne       short M09_L11
M09_L10:
       mov       eax,[r15+8]
       inc       eax
       cmp       eax,[r15+0C]
       jae       near ptr M09_L42
       mov       [r15+8],eax
       mov       rcx,[rbx+18]
       cmp       qword ptr [rcx+8],38
       jle       short M09_L07
       jmp       short M09_L07
M09_L11:
       mov       r9,[rbp+28]
       mov       byte ptr [r9],1
       jmp       near ptr M09_L57
M09_L12:
       add       rcx,0C
       lea       r8,[r12+0C]
       mov       r9d,[r12+8]
       cmp       r9d,8
       jl        short M09_L14
       cmp       r9d,10
       jl        short M09_L13
       mov       rdx,r8
       mov       r8d,r9d
       call      qword ptr [7FFDF4E0C318]
       jmp       near ptr M09_L20
M09_L13:
       mov       rdx,r8
       mov       r8d,r9d
       call      qword ptr [7FFDF4D3F798]; System.Globalization.Ordinal.EqualsIgnoreCase_Vector[[System.Runtime.Intrinsics.Vector128`1[[System.UInt16, System.Private.CoreLib]], System.Private.CoreLib]](Char ByRef, Char ByRef, Int32)
       jmp       near ptr M09_L20
M09_L14:
       xor       edx,edx
       cmp       r9d,4
       jb        short M09_L16
M09_L15:
       mov       rax,[rcx+rdx]
       mov       r10,[r8+rdx]
       mov       r11,rax
       or        r11,r10
       mov       rdi,r11
       shr       rdi,20
       or        edi,r11d
       test      edi,0FF80FF80
       jne       near ptr M09_L40
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
       jne       near ptr M09_L22
       add       rdx,8
       add       r9d,0FFFFFFFC
       cmp       r9d,4
       jae       short M09_L15
M09_L16:
       cmp       r9d,2
       jb        short M09_L17
       mov       edi,[rcx+rdx]
       mov       eax,[r8+rdx]
       mov       r10d,edi
       or        r10d,eax
       test      r10d,0FF80FF80
       jne       near ptr M09_L39
       xor       eax,edi
       shl       eax,2
       add       edi,50005
       or        edi,0A000A0
       add       edi,1A001A
       or        edi,0FF7FFF7F
       test      edi,eax
       jne       short M09_L22
       add       rdx,4
       add       r9d,0FFFFFFFE
M09_L17:
       test      r9d,r9d
       jne       short M09_L21
M09_L18:
       mov       r10d,1
M09_L19:
       mov       eax,r10d
M09_L20:
       jmp       near ptr M09_L09
M09_L21:
       movzx     edi,word ptr [rcx+rdx]
       movzx     eax,word ptr [r8+rdx]
       mov       r10d,edi
       or        r10d,eax
       cmp       r10d,7F
       ja        near ptr M09_L39
       cmp       edi,eax
       je        short M09_L18
       or        edi,20
       lea       r10d,[rdi-61]
       cmp       r10d,19
       ja        short M09_L22
       or        eax,20
       cmp       edi,eax
       sete      r10b
       movzx     r10d,r10b
       jmp       short M09_L19
M09_L22:
       xor       r10d,r10d
       jmp       short M09_L19
M09_L23:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Core.Data.Models.CountryPhonePostalInfo>
       cmp       [r15],rcx
       jne       near ptr M09_L45
       mov       r10d,[r15+8]
       cmp       r10d,[r15+0C]
       jae       near ptr M09_L55
       mov       rdi,[r15+10]
       cmp       r10d,[rdi+8]
       jae       near ptr M09_L56
       mov       ecx,r10d
       mov       r14,[rdi+rcx*8+10]
       mov       rcx,offset DotNetTips.Spargine.Core.Data.CountryPhonePostalInfoRepository+<>c__DisplayClass5_0.<GetCountryPhonePostalInfo>b__2(DotNetTips.Spargine.Core.Data.Models.CountryPhonePostalInfo)
       cmp       [rsi+18],rcx
       jne       near ptr M09_L46
       mov       r13,[rsi+8]
       mov       rcx,[r14+18]
       mov       r12,[r13+8]
       cmp       rcx,r12
       je        near ptr M09_L54
       test      rcx,rcx
       je        short M09_L24
       test      r12,r12
       je        short M09_L24
       mov       edx,[rcx+8]
       cmp       edx,[r12+8]
       je        short M09_L29
M09_L24:
       xor       eax,eax
M09_L25:
       test      eax,eax
       jne       near ptr M09_L11
M09_L26:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Core.Data.Models.CountryPhonePostalInfo>
       mov       r15,[rbp-48]
       cmp       [r15],rcx
       jne       near ptr M09_L43
       mov       eax,[r15+8]
       inc       eax
       cmp       eax,[r15+0C]
       jae       near ptr M09_L44
       mov       [r15+8],eax
M09_L27:
       mov       rcx,[rbx+18]
       cmp       qword ptr [rcx+8],38
       jle       short M09_L28
       mov       r11,[rcx+38]
       test      r11,r11
       jne       near ptr M09_L23
M09_L28:
       mov       rcx,rbx
       mov       rdx,7FFDF4F06F18
       call      qword ptr [7FFDF4897AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M09_L23
M09_L29:
       add       rcx,0C
       lea       r8,[r12+0C]
       mov       r9d,[r12+8]
       cmp       r9d,8
       jl        short M09_L31
       cmp       r9d,10
       jl        short M09_L30
       mov       rdx,r8
       mov       r8d,r9d
       call      qword ptr [7FFDF4E0C318]
       jmp       near ptr M09_L37
M09_L30:
       mov       rdx,r8
       mov       r8d,r9d
       call      qword ptr [7FFDF4D3F798]; System.Globalization.Ordinal.EqualsIgnoreCase_Vector[[System.Runtime.Intrinsics.Vector128`1[[System.UInt16, System.Private.CoreLib]], System.Private.CoreLib]](Char ByRef, Char ByRef, Int32)
       jmp       near ptr M09_L37
M09_L31:
       xor       edx,edx
       cmp       r9d,4
       jb        short M09_L33
M09_L32:
       mov       rax,[rcx+rdx]
       mov       r10,[r8+rdx]
       mov       r11,rax
       or        r11,r10
       mov       rdi,r11
       shr       rdi,20
       or        edi,r11d
       test      edi,0FF80FF80
       jne       near ptr M09_L47
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
       jne       near ptr M09_L53
       add       rdx,8
       add       r9d,0FFFFFFFC
       cmp       r9d,4
       jae       short M09_L32
M09_L33:
       cmp       r9d,2
       jae       near ptr M09_L48
M09_L34:
       test      r9d,r9d
       jne       near ptr M09_L49
M09_L35:
       mov       r10d,1
M09_L36:
       mov       eax,r10d
M09_L37:
       jmp       near ptr M09_L25
M09_L38:
       mov       eax,1
       jmp       near ptr M09_L09
M09_L39:
       test      edi,0FF80FF80
       je        near ptr M09_L22
       test      eax,0FF80FF80
       jne       short M09_L41
       jmp       near ptr M09_L22
M09_L40:
       mov       r11,0FF80FF80FF80FF80
       test      r11,rax
       je        near ptr M09_L22
       mov       rax,0FF80FF80FF80FF80
       test      rax,r10
       je        near ptr M09_L22
M09_L41:
       add       rcx,rdx
       add       r8,rdx
       mov       edx,r9d
       call      qword ptr [7FFDF4E0C4B0]
       test      eax,eax
       sete      r10b
       movzx     r10d,r10b
       jmp       near ptr M09_L19
M09_L42:
       mov       ecx,[r15+0C]
       mov       [r15+8],ecx
       jmp       near ptr M09_L78
M09_L43:
       mov       rcx,r15
       mov       r11,7FFDF4560C10
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M09_L27
       jmp       near ptr M09_L78
M09_L44:
       mov       ecx,[r15+0C]
       mov       [r15+8],ecx
       jmp       near ptr M09_L78
M09_L45:
       mov       rcx,r15
       call      qword ptr [r11]
       mov       r14,rax
M09_L46:
       mov       rdx,r14
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       jmp       near ptr M09_L25
M09_L47:
       mov       r11,0FF80FF80FF80FF80
       test      r11,rax
       je        near ptr M09_L53
       mov       rax,0FF80FF80FF80FF80
       test      rax,r10
       je        near ptr M09_L53
       jmp       short M09_L51
M09_L48:
       mov       edi,[rcx+rdx]
       mov       eax,[r8+rdx]
       mov       r10d,edi
       or        r10d,eax
       test      r10d,0FF80FF80
       jne       short M09_L50
       xor       eax,edi
       shl       eax,2
       lea       r10d,[rdi+50005]
       or        r10d,0A000A0
       add       r10d,1A001A
       or        r10d,0FF7FFF7F
       test      r10d,eax
       jne       short M09_L53
       add       rdx,4
       add       r9d,0FFFFFFFE
       jmp       near ptr M09_L34
M09_L49:
       movzx     edi,word ptr [rcx+rdx]
       movzx     eax,word ptr [r8+rdx]
       mov       r10d,edi
       or        r10d,eax
       cmp       r10d,7F
       jbe       short M09_L52
M09_L50:
       test      edi,0FF80FF80
       je        short M09_L53
       test      eax,0FF80FF80
       je        short M09_L53
M09_L51:
       add       rcx,rdx
       add       r8,rdx
       mov       edx,r9d
       call      qword ptr [7FFDF4E0C4B0]
       test      eax,eax
       sete      r10b
       movzx     r10d,r10b
       jmp       near ptr M09_L36
M09_L52:
       cmp       edi,eax
       je        near ptr M09_L35
       or        edi,20
       lea       r10d,[rdi-61]
       cmp       r10d,19
       ja        short M09_L53
       or        eax,20
       cmp       edi,eax
       sete      r10b
       movzx     r10d,r10b
       jmp       near ptr M09_L36
M09_L53:
       xor       r10d,r10d
       jmp       near ptr M09_L36
M09_L54:
       mov       eax,1
       jmp       near ptr M09_L25
M09_L55:
       mov       ecx,[r15+8]
       call      qword ptr [7FFDF4E0DA88]
       int       3
M09_L56:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M09_L57:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Core.Data.Models.CountryPhonePostalInfo>
       cmp       [r15],rcx
       jne       near ptr M09_L79
M09_L58:
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
M09_L59:
       mov       r15d,[rdi+10]
       mov       rbx,[rdi+8]
       cmp       [rbx+8],r15d
       jb        near ptr M09_L72
       add       rbx,10
       jmp       short M09_L61
M09_L60:
       lea       rbx,[rdi+10]
       mov       r15d,[rdi+8]
M09_L61:
       xor       edi,edi
       cmp       edi,r15d
       jge       short M09_L63
M09_L62:
       mov       r14,[rbx+rdi*8]
       mov       rdx,r14
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       jne       short M09_L64
       inc       edi
       cmp       edi,r15d
       jl        short M09_L62
M09_L63:
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
M09_L64:
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
M09_L65:
       mov       rcx,rbx
       mov       rdx,7FFDF4F06DB8
       call      qword ptr [7FFDF4897AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r14,rax
       jmp       near ptr M09_L00
M09_L66:
       mov       rcx,r14
       mov       rdx,7FFDF4F07158
       call      qword ptr [7FFDF4897AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       jmp       near ptr M09_L01
M09_L67:
       mov       rcx,r14
       mov       rdx,7FFDF4F071E8
       call      qword ptr [7FFDF4897AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       jmp       near ptr M09_L02
M09_L68:
       mov       rcx,rbx
       mov       rdx,7FFDF4F06E60
       call      qword ptr [7FFDF4897AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M09_L03
M09_L69:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Core.Data.Models.CountryPhonePostalInfo>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       dword ptr [r15+8],0FFFFFFFF
       mov       [r15+0C],r14d
       lea       rcx,[r15+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M09_L06
M09_L70:
       mov       ecx,11
       call      qword ptr [7FFDF4897DF8]
       int       3
M09_L71:
       mov       ecx,0C
       call      qword ptr [7FFDF4897DF8]
       int       3
M09_L72:
       call      qword ptr [7FFDF48979A8]
       int       3
M09_L73:
       mov       r11,7FFDF4560C20
       call      qword ptr [r11]
       mov       r14d,eax
       test      r14d,r14d
       je        short M09_L76
       jmp       near ptr M09_L04
M09_L74:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Core.Data.Models.CountryPhonePostalInfo>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M09_L05
M09_L75:
       mov       rcx,rdi
       mov       r11,7FFDF4560C28
       call      qword ptr [r11]
       mov       r15,rax
       jmp       near ptr M09_L06
M09_L76:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Core.Data.Models.CountryPhonePostalInfo>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,2499BC00230
       mov       r15,[rcx]
       jmp       near ptr M09_L06
M09_L77:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       r15,rax
       jmp       near ptr M09_L06
M09_L78:
       call      M09_L80
       jmp       near ptr M09_L63
M09_L79:
       mov       rcx,r15
       mov       r11,7FFDF4560C18
       call      qword ptr [r11]
       jmp       near ptr M09_L58
M09_L80:
       sub       rsp,28
       cmp       qword ptr [rbp-48],0
       je        short M09_L81
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Core.Data.Models.CountryPhonePostalInfo>
       mov       r15,[rbp-48]
       cmp       [r15],rcx
       je        short M09_L81
       mov       rcx,r15
       mov       r11,7FFDF4560C18
       call      qword ptr [r11]
M09_L81:
       nop
       add       rsp,28
       ret
; Total bytes of code 2221
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M10_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M10_L00:
       call      qword ptr [7FFDF4E0C4C8]
       int       3
; Total bytes of code 44
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Data.CountryPhonePostalInfoRepositoryBenchmark.GetCountryPhonePostalInfo()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       call      qword ptr [7FFDF4D1ED78]; DotNetTips.Spargine.Core.Data.CountryPhonePostalInfoRepository.GetCountryPhonePostalInfo()
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
       mov       rbx,21D7AA006A0
       mov       rcx,rbx
       call      System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rsi,1DCE5C020C8
       cmp       qword ptr [rsi],0
       je        short M01_L01
M01_L00:
       mov       rsi,[rsi]
       lea       rdx,[rbp-18]
       mov       rcx,rbx
       call      System.Threading.Monitor.ExitIfLockTaken(System.Object, Boolean ByRef)
       jmp       short M01_L02
M01_L01:
       call      qword ptr [7FFDF4D1ED90]; DotNetTips.Spargine.Core.Data.CountryPhonePostalInfoRepository.DeserializeCountryPhonePostalInfo()
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
       mov       rbx,21D7AA006A0
       mov       rcx,rbx
       call      System.Threading.Monitor.ExitIfLockTaken(System.Object, Boolean ByRef)
       nop
       add       rsp,28
       ret
; Total bytes of code 135
```

