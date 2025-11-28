## .NET 10.0.0 (10.0.0, 10.0.25.52411), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.Data.CountryRepositoryBenchmark.GetCountryByCountryName()
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
       xor       eax,eax
       mov       [rbp-78],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-70],ymm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp+10],rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Data.CountryRepository+<>c__DisplayClass5_0
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-90],rax
       mov       rcx,1E7AF2C1178
       mov       rdi,[rcx]
       test      rdi,rdi
       jne       short M00_L00
       mov       rcx,228446D0698
       call      qword ptr [7FFDE9E856C8]; System.RuntimeType.InitializeCache()
       mov       r14,rax
       jmp       short M00_L01
M00_L00:
       mov       r14,rdi
M00_L01:
       mov       rdi,[r14+20]
       test      rdi,rdi
       jne       near ptr M00_L08
       mov       [rbp-0A0],r14
       mov       rcx,[r14+8]
       cmp       [rcx],ecx
       call      qword ptr [7FFDE9E84B58]; System.Type.GetRootElementType()
       mov       rdi,rax
       mov       [rbp-0A8],rdi
       mov       rcx,offset MT_System.RuntimeType
       cmp       [rdi],rcx
       jne       near ptr M00_L18
       mov       rcx,[rdi+18]
       test      cl,2
       je        short M00_L02
       xor       eax,eax
       jmp       short M00_L03
M00_L02:
       mov       eax,[rcx]
       and       eax,80000030
       cmp       eax,30
       sete      al
       movzx     eax,al
M00_L03:
       test      eax,eax
       jne       short M00_L05
       mov       rcx,offset MT_System.RuntimeType
       cmp       [rdi],rcx
       jne       near ptr M00_L19
       mov       rcx,rdi
       call      qword ptr [7FFDE9E84B58]; System.Type.GetRootElementType()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+98]
       call      qword ptr [rax+8]
       test      rax,rax
       je        near ptr M00_L39
       mov       rcx,rax
       call      00007FFE49862E70
M00_L04:
       test      eax,eax
       jne       near ptr M00_L40
M00_L05:
       mov       rcx,offset MT_System.RuntimeType
       cmp       [rdi],rcx
       jne       near ptr M00_L20
       mov       rcx,[rdi+18]
       mov       rax,7FFE498606C0
       call      rax
       movzx     ebx,al
       cmp       dword ptr [7FFE49BBF778],0
       jne       near ptr M00_L41
M00_L06:
       cmp       ebx,1B
       je        near ptr M00_L40
M00_L07:
       mov       r14,[rbp-0A0]
       lea       rdx,[r14+20]
       mov       rcx,r14
       mov       r8d,3
       call      qword ptr [7FFDE9E8CBD0]; System.RuntimeType+RuntimeTypeCache.ConstructName(System.String ByRef, System.TypeNameFormatFlags)
       mov       rdi,rax
M00_L08:
       test      rdi,rdi
       je        near ptr M00_L40
       cmp       dword ptr [rdi+8],0
       je        near ptr M00_L40
       mov       edx,[rdi+8]
       add       edx,0C
       js        near ptr M00_L42
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFE498A8D20
       mov       r14,rax
       cmp       [r14],r14b
       lea       r8,[r14+0C]
       vmovups   xmm0,[7FFDEA4B9B80]
       vmovups   [r8],xmm0
       mov       rdx,3A00640065006E
       mov       [r8+10],rdx
       mov       r8d,[rdi+8]
       add       r8,r8
       lea       rdx,[rdi+0C]
       lea       rcx,[r14+24]
       call      qword ptr [7FFDE9C65818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L09:
       mov       rcx,1E7AF8020B8
       mov       rdi,[rcx]
       mov       r15d,[r14+8]
       test      r15d,r15d
       je        near ptr M00_L43
       movzx     ecx,word ptr [r14+0C]
       cmp       ecx,100
       jge       near ptr M00_L45
       mov       rax,7FFE48A46918
       test      byte ptr [rax+rcx],80
       jne       near ptr M00_L47
M00_L10:
       dec       r15d
       mov       ecx,r15d
       movzx     ecx,word ptr [r14+rcx*2+0C]
       cmp       ecx,100
       jge       near ptr M00_L46
       mov       rax,7FFE48A46918
       test      byte ptr [rax+rcx],80
       jne       near ptr M00_L47
M00_L11:
       mov       r15,r14
M00_L12:
       mov       rdi,[rdi+10]
       test      r15,r15
       jne       near ptr M00_L21
       xor       r13d,r13d
       xor       r12d,r12d
M00_L13:
       cmp       byte ptr [rdi+44],0
       jne       near ptr M00_L48
       mov       r15,[rdi+28]
       mov       rcx,[r15+20]
       mov       rax,[rcx+8]
       mov       [rbp-0B0],rax
       mov       rdx,[rax+8]
       mov       [rbp-0B8],rdx
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer+OrdinalComparer
       cmp       [rdx],rcx
       jne       near ptr M00_L49
       mov       [rbp-78],r13
       mov       [rbp-70],r12d
       lea       rcx,[rbp-78]
       call      qword ptr [7FFDEA285620]; System.String.GetNonRandomizedHashCode(System.ReadOnlySpan`1<Char>)
M00_L14:
       mov       [rbp-3C],eax
       mov       rcx,[rbp-0B0]
       mov       rdx,[rcx+10]
       mov       r8d,eax
       imul      r8,[rcx+28]
       shr       r8,20
       inc       r8
       mov       ecx,[rdx+8]
       imul      rcx,r8
       shr       rcx,20
       cmp       ecx,[rdx+8]
       jae       near ptr M00_L83
       mov       ecx,ecx
       mov       r10,[rdx+rcx*8+10]
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer+OrdinalComparer
       mov       r9,[rbp-0B8]
       cmp       [r9],rcx
       jne       near ptr M00_L38
M00_L15:
       test      r10,r10
       je        near ptr M00_L65
       cmp       eax,[r10+20]
       jne       near ptr M00_L51
       mov       [rbp-0C0],r10
       mov       r8,[r10+8]
       test      r12d,r12d
       je        near ptr M00_L50
M00_L16:
       test      r8,r8
       jne       near ptr M00_L22
       xor       edx,edx
       xor       r11d,r11d
M00_L17:
       cmp       r12d,r11d
       jne       near ptr M00_L37
       mov       r8d,r11d
       add       r8,r8
       cmp       r8,0A
       jne       short M00_L23
       mov       rcx,r13
       mov       r8,[rcx]
       mov       rcx,[rcx+2]
       mov       r9,[rdx]
       xor       r8,r9
       xor       rcx,[rdx+2]
       or        rcx,r8
       sete      cl
       movzx     ecx,cl
       mov       eax,ecx
       jmp       short M00_L24
M00_L18:
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+60]
       call      qword ptr [rax+10]
       jmp       near ptr M00_L03
M00_L19:
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+0B0]
       call      qword ptr [rax]
       jmp       near ptr M00_L04
M00_L20:
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+60]
       call      qword ptr [rax+30]
       test      eax,eax
       jne       near ptr M00_L40
       jmp       near ptr M00_L07
M00_L21:
       lea       r13,[r15+0C]
       mov       r12d,[r15+8]
       jmp       near ptr M00_L13
M00_L22:
       lea       rdx,[r8+0C]
       mov       r11d,[r8+8]
       jmp       near ptr M00_L17
M00_L23:
       mov       rcx,r13
       call      qword ptr [7FFDE9C6C330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
M00_L24:
       test      eax,eax
       je        near ptr M00_L52
M00_L25:
       mov       r10,[rbp-0C0]
       mov       r13,[r10+10]
M00_L26:
       mov       rax,[rdi+10]
       mov       rcx,[rax+8]
       test      rcx,rcx
       jne       near ptr M00_L66
       call      qword ptr [7FFDEA205E60]; System.DateTime.get_UtcNow()
       mov       r12,rax
M00_L27:
       test      r13,r13
       je        near ptr M00_L76
       cmp       byte ptr [r13+43],0
       jne       near ptr M00_L71
       mov       rdx,[r13+38]
       test      rdx,rdx
       jl        near ptr M00_L67
M00_L28:
       mov       rcx,3FFFFFFFFFFFFFFF
       and       rcx,r12
       cmp       rdx,rcx
       jbe       near ptr M00_L68
       cmp       qword ptr [r13+50],0
       jg        near ptr M00_L69
M00_L29:
       xor       eax,eax
M00_L30:
       test      eax,eax
       jne       near ptr M00_L71
M00_L31:
       cmp       qword ptr [r13+10],0
       jne       near ptr M00_L70
M00_L32:
       mov       [r13+58],r12
       mov       r15,[r13+20]
       cmp       byte ptr [rdi+45],0
       jne       near ptr M00_L72
M00_L33:
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+28]
       mov       rdx,[rdi+48]
       mov       rax,3FFFFFFFFFFFFFFF
       and       rax,r12
       mov       r8,3FFFFFFFFFFFFFFF
       and       rdx,r8
       sub       rax,rdx
       cmp       rcx,rax
       jl        near ptr M00_L73
M00_L34:
       cmp       qword ptr [rdi+20],0
       jne       near ptr M00_L74
M00_L35:
       mov       rdx,r15
       mov       rcx,offset MT_System.Collections.Generic.HashSet<System.Object>
       call      qword ptr [7FFDE9C66850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M00_L78
       mov       r14,r15
       test      r14,r14
       je        short M00_L36
       mov       rcx,offset MT_System.Collections.Generic.HashSet<System.Object>
       cmp       [r14],rcx
       je        short M00_L36
       mov       rdx,r15
       call      qword ptr [7FFDE9E84D20]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       mov       r14,rax
M00_L36:
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Data.CountryName
       call      CORINFO_HELP_NEWSFAST
       mov       dword ptr [rax+8],0EB
       cmp       [r14],r14b
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFDE9E87270]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       test      eax,eax
       jl        near ptr M00_L81
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Data.CountryName
       call      CORINFO_HELP_NEWSFAST
       mov       dword ptr [rax+8],0EB
       mov       rcx,rax
       call      qword ptr [7FFDEA32E808]; DotNetTips.Spargine.Core.EnumHelper.GetDescription(System.Enum)
       mov       rsi,[rbp-90]
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Data.Models.Country, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFDEA1045D0]; DotNetTips.Spargine.Tester.Data.CountryRepository.GetCountries()
       mov       r14,rax
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,offset DotNetTips.Spargine.Tester.Data.CountryRepository+<>c__DisplayClass5_0.<GetCountry>b__0(DotNetTips.Spargine.Tester.Data.Models.Country)
       mov       [rdi+18],r9
       lea       r9,[rbp-60]
       mov       rdx,r14
       mov       r8,rdi
       mov       rcx,7FFDEA421718
       call      qword ptr [7FFDEA327708]; System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>, Boolean ByRef)
       mov       [rbp-68],rax
       mov       rbx,[rbp+10]
       mov       rcx,[rbx+18]
       lea       r8,[rbp-68]
       mov       rdx,7FFDEA421B38
       cmp       [rcx],ecx
       call      qword ptr [7FFDEA3F6028]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
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
M00_L37:
       xor       ecx,ecx
       mov       eax,ecx
       jmp       near ptr M00_L24
M00_L38:
       test      r10,r10
       jne       near ptr M00_L53
       jmp       near ptr M00_L65
M00_L39:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFDEA3FE340]
       mov       r8,rax
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FFDEA3FE358]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M00_L40:
       mov       r14,228446D06C0
       jmp       near ptr M00_L09
M00_L41:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L06
M00_L42:
       call      qword ptr [7FFDEA3FE4F0]
       int       3
M00_L43:
       call      qword ptr [7FFDEA06FFC0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L44
       call      qword ptr [7FFDEA3FFAC8]
       mov       rbx,rax
M00_L44:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,228446C9C08
       call      qword ptr [7FFDEA3FE358]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L45:
       call      qword ptr [7FFDEA3FD8F0]
       test      eax,eax
       jne       short M00_L47
       jmp       near ptr M00_L10
M00_L46:
       call      qword ptr [7FFDEA3FD8F0]
       test      eax,eax
       je        near ptr M00_L11
M00_L47:
       mov       rcx,r14
       mov       edx,3
       call      qword ptr [7FFDEA3FD908]
       mov       r15,rax
       jmp       near ptr M00_L12
M00_L48:
       call      qword ptr [7FFDEA32F060]
       int       3
M00_L49:
       mov       [rbp-78],r13
       mov       [rbp-70],r12d
       lea       rdx,[rbp-78]
       mov       rcx,[rbp-0B8]
       mov       r11,7FFDE9BB0BA8
       call      qword ptr [r11]
       jmp       near ptr M00_L14
M00_L50:
       test      r8,r8
       je        short M00_L52
       jmp       near ptr M00_L16
M00_L51:
       mov       [rbp-0C0],r10
M00_L52:
       mov       r10,[rbp-0C0]
       mov       r10,[r10+18]
       mov       eax,[rbp-3C]
       jmp       near ptr M00_L15
M00_L53:
       cmp       eax,[r10+20]
       jne       short M00_L54
       mov       [rbp-0C0],r10
       mov       r8,[r10+8]
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer+OrdinalComparer
       cmp       [r9],rcx
       jne       short M00_L55
       jmp       short M00_L56
M00_L54:
       mov       [rbp-0C0],r10
       jmp       near ptr M00_L63
M00_L55:
       mov       r9,[rbp-0B8]
       mov       [rbp-78],r13
       mov       [rbp-70],r12d
       lea       rdx,[rbp-78]
       mov       rcx,r9
       mov       r11,7FFDE9BB0BB0
       call      qword ptr [r11]
       mov       r9,[rbp-0B8]
       jmp       near ptr M00_L64
M00_L56:
       mov       r9,[rbp-0B8]
       test      r12d,r12d
       jne       short M00_L57
       test      r8,r8
       je        short M00_L63
M00_L57:
       test      r8,r8
       je        short M00_L58
       lea       rdx,[r8+0C]
       mov       r11d,[r8+8]
       jmp       short M00_L59
M00_L58:
       xor       edx,edx
       xor       r11d,r11d
M00_L59:
       cmp       r12d,r11d
       je        short M00_L60
       xor       edx,edx
       mov       eax,edx
       jmp       short M00_L62
M00_L60:
       mov       r8d,r11d
       add       r8,r8
       cmp       r8,0A
       je        short M00_L61
       mov       rcx,r13
       call      qword ptr [7FFDE9C6C330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r9,[rbp-0B8]
       jmp       short M00_L62
M00_L61:
       mov       r8,r13
       mov       rcx,[r8]
       mov       r8,[r8+2]
       mov       r11,[rdx]
       xor       rcx,r11
       xor       r8,[rdx+2]
       or        r8,rcx
       sete      dl
       movzx     edx,dl
       mov       eax,edx
M00_L62:
       jmp       short M00_L64
M00_L63:
       mov       r10,[rbp-0C0]
       mov       r10,[r10+18]
       mov       eax,[rbp-3C]
       jmp       near ptr M00_L38
M00_L64:
       test      eax,eax
       je        short M00_L63
       jmp       near ptr M00_L25
M00_L65:
       xor       r13d,r13d
       jmp       near ptr M00_L26
M00_L66:
       lea       rdx,[rbp-50]
       mov       r11,7FFDE9BB0BB8
       call      qword ptr [r11]
       lea       rcx,[rbp-50]
       call      qword ptr [7FFDEA32EFD0]
       mov       r12,rax
       jmp       near ptr M00_L27
M00_L67:
       cmp       qword ptr [r13+50],0
       je        near ptr M00_L31
       jmp       near ptr M00_L28
M00_L68:
       mov       rcx,r13
       mov       edx,3
       call      qword ptr [7FFDEA32F978]
       mov       eax,1
       jmp       near ptr M00_L30
M00_L69:
       mov       rdx,[r13+58]
       mov       rcx,r12
       call      qword ptr [7FFDEA32F288]; System.DateTime.op_Subtraction(System.DateTime, System.DateTime)
       mov       rcx,rax
       mov       rdx,[r13+50]
       call      qword ptr [7FFDEA32FAB0]
       test      eax,eax
       jne       short M00_L68
       jmp       near ptr M00_L29
M00_L70:
       mov       rcx,[r13+10]
       mov       rdx,r13
       cmp       [rcx],ecx
       call      qword ptr [7FFDEA32FA68]
       test      eax,eax
       je        near ptr M00_L32
M00_L71:
       cmp       byte ptr [r13+45],2
       jne       short M00_L75
       jmp       near ptr M00_L32
M00_L72:
       mov       rcx,r13
       cmp       [rcx],ecx
       call      qword ptr [7FFDEA32F1F8]
       jmp       near ptr M00_L33
M00_L73:
       mov       rcx,rdi
       mov       rdx,r12
       call      qword ptr [7FFDEA32F2B8]
       jmp       near ptr M00_L34
M00_L74:
       mov       rcx,[rdi+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFDEA3FFBB8]
       inc       qword ptr [rax+10]
       jmp       near ptr M00_L35
M00_L75:
       mov       r8,[rdi+10]
       mov       rcx,r15
       mov       rdx,r13
       call      qword ptr [7FFDEA32F258]
M00_L76:
       mov       rdx,[rdi+10]
       mov       r15,[rdx+28]
       mov       rdx,[rdi+48]
       mov       rcx,r12
       call      qword ptr [7FFDEA32F288]; System.DateTime.op_Subtraction(System.DateTime, System.DateTime)
       cmp       r15,rax
       jge       short M00_L77
       mov       rcx,rdi
       mov       rdx,r12
       call      qword ptr [7FFDEA32F2B8]
M00_L77:
       cmp       qword ptr [rdi+20],0
       je        short M00_L78
       mov       rcx,[rdi+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFDEA3FFBB8]
       inc       qword ptr [rax+18]
M00_L78:
       mov       rcx,offset MT_System.Collections.Generic.HashSet<System.Object>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FFDE9E87138]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       rcx,228446D0698
       call      qword ptr [7FFDEA32E8C8]; System.Enum.GetValues(System.Type)
       mov       r15,rax
       cmp       [r15],r15b
       mov       rcx,offset MT_System.ArrayEnumerator
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,r13
       mov       rdx,r15
       call      qword ptr [7FFDEA3FFBD0]
       mov       [rbp-98],r13
M00_L79:
       mov       rcx,[rbp-98]
       call      qword ptr [7FFDEA03DCC0]; Precode of System.ArrayEnumerator.MoveNext()
       test      eax,eax
       je        short M00_L80
       mov       rcx,[rbp-98]
       call      qword ptr [7FFDEA03DCC8]; Precode of System.ArrayEnumerator.get_Current()
       mov       rdx,rax
       lea       r8,[rbp-58]
       mov       rcx,rdi
       call      qword ptr [7FFDE9E87228]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
       jmp       short M00_L79
M00_L80:
       mov       rcx,1E7AF8020B8
       mov       r15,[rcx]
       mov       ecx,0A
       call      qword ptr [7FFDEA32E8E0]; System.TimeSpan.FromMinutes(Int64)
       mov       r13,rax
       mov       ecx,[r14+8]
       mov       rcx,r14
       call      qword ptr [7FFDEA104018]; System.String.Trim()
       mov       r14,rax
       mov       rcx,offset MT_Microsoft.Extensions.Caching.Memory.MemoryCacheEntryOptions
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       r15,[r15+10]
       mov       dword ptr [r12+18],1
       mov       byte ptr [rbp-88],1
       mov       [rbp-80],r13
       lea       rdx,[rbp-88]
       mov       rcx,r12
       call      qword ptr [7FFDEA32F570]; Microsoft.Extensions.Caching.Memory.MemoryCacheEntryOptions.set_AbsoluteExpirationRelativeToNow(System.Nullable`1<System.TimeSpan>)
       mov       [rsp+20],r12
       mov       rdx,r15
       mov       r8,r14
       mov       r9,rdi
       mov       rcx,7FFDEA3D08A8
       call      qword ptr [7FFDEA32F4B0]; Microsoft.Extensions.Caching.Memory.CacheExtensions.Set[[System.__Canon, System.Private.CoreLib]](Microsoft.Extensions.Caching.Memory.IMemoryCache, System.Object, System.__Canon, Microsoft.Extensions.Caching.Memory.MemoryCacheEntryOptions)
       mov       r14,rdi
       jmp       near ptr M00_L36
M00_L81:
       call      qword ptr [7FFDEA32E910]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L82
       call      qword ptr [7FFDEA3FFBE8]
       mov       rbx,rax
M00_L82:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,228446D0668
       call      qword ptr [7FFDEA205F38]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L83:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       sub       rsp,28
       vzeroupper
       mov       rcx,[rbp-98]
       test      rcx,rcx
       je        short M00_L84
       mov       rcx,[rcx]
M00_L84:
       add       rsp,28
       ret
; Total bytes of code 2675
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
       call      00007FFE49861870
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
       mov       rax,7FFDE9EBC5A0
       mov       [rbp-78],rax
       lea       rax,[M01_L03]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFE497F2C30
       call      rax
M01_L03:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFE49BBF778],0
       je        short M01_L04
       call      qword ptr [7FFE49BAD608]; CORINFO_HELP_STOP_FOR_GC
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
       call      00007FFE498704E0
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
       call      qword ptr [7FFDEA3FFDF8]; System.RuntimeTypeHandle.GetGCHandle(System.Runtime.InteropServices.GCHandleType)
       mov       rdx,rax
       lea       rcx,[rbx+10]
       xor       eax,eax
       lock cmpxchg [rcx],rdx
       test      rax,rax
       je        near ptr M01_L00
       lea       rcx,[rbp-40]
       call      qword ptr [7FFDEA3FE7A8]
       jmp       near ptr M01_L00
M01_L09:
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M01_L10:
       mov       [rbp+10],rbx
       mov       rcx,rbx
       call      qword ptr [7FFDE9E85710]; System.RuntimeTypeHandle.<GetModule>g__GetModuleWorker|48_0(System.RuntimeType)
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
       mov       rax,7FFE498606C0
       call      rax
       movzx     ebx,al
       mov       rdi,[rsp+20]
       cmp       dword ptr [7FFE49BBF778],0
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
       call      qword ptr [7FFDE9E8CBE8]; System.RuntimeTypeHandle.ConstructName(System.TypeNameFormatFlags)
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
       jbe       near ptr M04_L06
       cmp       r8,40
       jbe       short M04_L02
       cmp       r8,800
       ja        near ptr M04_L11
       cmp       r8,100
       jae       near ptr M04_L09
M04_L00:
       mov       r9,r8
       shr       r9,6
M04_L01:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M04_L01
       and       r8,3F
       cmp       r8,10
       jbe       short M04_L03
M04_L02:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        short M04_L05
M04_L03:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
M04_L04:
       vzeroupper
       ret
M04_L05:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M04_L03
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M04_L03
M04_L06:
       test      r8b,18
       je        short M04_L07
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
       jmp       short M04_L04
M04_L07:
       test      r8b,4
       je        short M04_L08
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
       jmp       short M04_L04
M04_L08:
       test      r8,r8
       je        short M04_L04
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M04_L04
       movsx     rcx,word ptr [rax-2]
       mov       [r10-2],cx
       jmp       short M04_L04
M04_L09:
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
       jmp       near ptr M04_L00
M04_L10:
       cmp       rcx,rdx
       jne       short M04_L11
       cmp       [rdx],dl
       jmp       near ptr M04_L04
M04_L11:
       cmp       [rcx],cl
       cmp       [rdx],dl
       vzeroupper
       jmp       qword ptr [7FFDE9C666E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 327
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
       jbe       short M05_L03
M05_L02:
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
       jge       short M05_L02
       jmp       short M05_L01
M05_L03:
       mov       r8d,r8d
       lea       r10,[7FFDEA4B8A00]
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
M05_L04:
       xor       ecx,ecx
       mov       [rsp],rcx
       imul      ecx,edx,5D588B65
       add       eax,ecx
       add       rsp,8
       ret
       mov       r8d,edx
       rol       r8d,5
       add       r8d,edx
       mov       edx,r8d
       xor       edx,[rcx]
       jmp       short M05_L04
       mov       r8d,edx
       rol       r8d,5
       add       r8d,edx
       movzx     edx,word ptr [rcx]
       xor       edx,r8d
       jmp       short M05_L04
; Total bytes of code 188
```
```assembly
; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       r8,8
       jb        near ptr M06_L07
       cmp       rcx,rdx
       je        short M06_L03
       cmp       r8,20
       jae       short M06_L04
       cmp       r8,10
       jb        near ptr M06_L13
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFF0
       je        short M06_L02
       vmovups   xmm0,[rcx]
       vpcmpeqb  xmm0,xmm0,[rdx]
       vpmovmskb r10d,xmm0
       cmp       r10d,0FFFF
       je        short M06_L01
M06_L00:
       xor       eax,eax
       vzeroupper
       ret
M06_L01:
       add       rax,10
       cmp       r8,rax
       ja        near ptr M06_L12
M06_L02:
       vmovups   xmm0,[rcx+r8]
       vpcmpeqb  xmm0,xmm0,[rdx+r8]
       vpmovmskb ecx,xmm0
       cmp       ecx,0FFFF
       jne       short M06_L00
M06_L03:
       mov       eax,1
       vzeroupper
       ret
M06_L04:
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFE0
       je        short M06_L06
       vmovups   ymm0,[rcx]
       vpcmpeqb  ymm0,ymm0,[rdx]
       vpmovmskb r10d,ymm0
       cmp       r10d,0FFFFFFFF
       jne       short M06_L00
M06_L05:
       add       rax,20
       cmp       r8,rax
       jbe       short M06_L06
       vmovups   ymm0,[rcx+rax]
       vpcmpeqb  ymm0,ymm0,[rdx+rax]
       vpmovmskb r10d,ymm0
       cmp       r10d,0FFFFFFFF
       jne       short M06_L00
       jmp       short M06_L05
M06_L06:
       vmovups   ymm0,[rcx+r8]
       vpcmpeqb  ymm0,ymm0,[rdx+r8]
       vpmovmskb eax,ymm0
       cmp       eax,0FFFFFFFF
       jne       near ptr M06_L00
       jmp       short M06_L03
M06_L07:
       cmp       r8,4
       jae       short M06_L10
       xor       eax,eax
       mov       r10,r8
       and       r10,2
       je        short M06_L08
       movzx     eax,word ptr [rcx]
       movzx     r9d,word ptr [rdx]
       sub       eax,r9d
M06_L08:
       test      r8b,1
       je        short M06_L09
       movzx     r8d,byte ptr [rcx+r10]
       movzx     ecx,byte ptr [rdx+r10]
       sub       r8d,ecx
       or        eax,r8d
M06_L09:
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       short M06_L11
M06_L10:
       lea       rax,[r8-4]
       mov       r8d,[rcx]
       sub       r8d,[rdx]
       mov       ecx,[rcx+rax]
       sub       ecx,[rdx+rax]
       or        ecx,r8d
       sete      al
       movzx     eax,al
M06_L11:
       vzeroupper
       ret
M06_L12:
       vmovups   xmm0,[rcx+rax]
       vpcmpeqb  xmm0,xmm0,[rdx+rax]
       vpmovmskb r10d,xmm0
       cmp       r10d,0FFFF
       jne       near ptr M06_L00
       jmp       near ptr M06_L01
M06_L13:
       add       r8,0FFFFFFFFFFFFFFF8
       mov       rax,[rcx]
       sub       rax,[rdx]
       mov       rcx,[rcx+r8]
       sub       rcx,[rdx+r8]
       or        rax,rcx
       sete      al
       movzx     eax,al
       jmp       short M06_L11
; Total bytes of code 345
```
```assembly
; System.DateTime.get_UtcNow()
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+40]
       lea       rcx,[rbp-18]
       mov       rax,7FFF20A05380
       call      rax
       mov       rbx,[rbp-18]
       mov       rax,1E7AF801A90
       mov       rsi,[rax]
       sub       rbx,[rsi+8]
       cmp       dword ptr [7FFE49BBF778],0
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
       call      qword ptr [7FFDEA206088]; System.DateTime.UpdateLeapSecondCacheAndReturnUtcNow()
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 105
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rdx,rdx
       je        short M08_L00
       cmp       [rdx],rcx
       jne       short M08_L01
M08_L00:
       mov       rax,rdx
       ret
M08_L01:
       mov       rax,[rdx]
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M08_L00
M08_L02:
       test      rax,rax
       je        short M08_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M08_L00
       test      rax,rax
       je        short M08_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M08_L00
       test      rax,rax
       je        short M08_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M08_L00
       test      rax,rax
       je        short M08_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M08_L00
       jmp       short M08_L02
M08_L03:
       xor       edx,edx
       jmp       short M08_L00
; Total bytes of code 88
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,[rbx]
       mov       rdi,[rdi+10]
       cmp       rdi,rsi
       jne       short M09_L01
M09_L00:
       mov       rcx,7FFDEA481F04
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M09_L01:
       test      rdi,rdi
       je        near ptr M09_L08
       mov       rdi,[rdi+10]
       cmp       rdi,rsi
       jne       short M09_L02
       mov       rcx,7FFDEA481F00
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M09_L00
M09_L02:
       test      rdi,rdi
       je        near ptr M09_L07
       mov       rdi,[rdi+10]
       cmp       rdi,rsi
       je        short M09_L06
       test      rdi,rdi
       je        short M09_L05
       mov       rdi,[rdi+10]
       cmp       rdi,rsi
       je        short M09_L04
       test      rdi,rdi
       je        short M09_L03
       mov       rcx,7FFDEA481EEC
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rdi,[rdi+10]
       cmp       rdi,rsi
       je        short M09_L00
       jmp       short M09_L01
M09_L03:
       mov       rcx,7FFDEA481EE8
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M09_L08
M09_L04:
       mov       rcx,7FFDEA481EF0
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M09_L00
M09_L05:
       mov       rcx,7FFDEA481EF4
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M09_L08
M09_L06:
       mov       rcx,7FFDEA481EF8
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M09_L00
M09_L07:
       mov       rcx,7FFDEA481EFC
       call      CORINFO_HELP_COUNTPROFILE32
M09_L08:
       mov       rcx,7FFDEA481F08
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rsi
       mov       rdx,rbx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFDEA3FDF20]
; Total bytes of code 272
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
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+20],rax
       mov       [rsp+30],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       cmp       qword ptr [rbx+8],0
       je        near ptr M10_L26
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
       je        near ptr M10_L07
M10_L00:
       mov       rcx,offset MT_System.Collections.Generic.ObjectEqualityComparer<System.Object>
       cmp       [r14],rcx
       jne       near ptr M10_L14
       mov       [rsp+28],rsi
       xor       ecx,ecx
       mov       [rsp+20],rcx
       lea       rcx,[rsp+28]
       cmp       qword ptr [rsp+20],0
       jne       short M10_L01
       mov       rcx,[rsp+28]
       mov       [rsp+20],rcx
       lea       rcx,[rsp+20]
       cmp       qword ptr [rsp+20],0
       je        near ptr M10_L12
M10_L01:
       mov       rcx,[rcx]
       mov       rax,offset MT_DotNetTips.Spargine.Tester.Data.CountryName
       cmp       [rcx],rax
       jne       near ptr M10_L13
       call      qword ptr [7FFDE9BA60A8]; System.Enum.GetHashCode()
       mov       r15d,eax
M10_L02:
       xor       ecx,ecx
       mov       [rsp+20],rcx
M10_L03:
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
       jae       near ptr M10_L27
       mov       edx,edx
       lea       rcx,[rcx+rdx*4+10]
       mov       r13d,[rcx]
       dec       r13d
       js        near ptr M10_L26
       test      r14,r14
       je        near ptr M10_L08
       mov       rcx,offset MT_System.Collections.Generic.ObjectEqualityComparer<System.Object>
       cmp       [r14],rcx
       jne       near ptr M10_L08
M10_L04:
       cmp       r13d,[rdi+8]
       jae       near ptr M10_L27
       mov       ecx,r13d
       shl       rcx,4
       lea       r12,[rdi+rcx+10]
       cmp       [r12+8],r15d
       jne       near ptr M10_L16
       mov       rax,[r12]
       test      rax,rax
       je        near ptr M10_L17
       test      rsi,rsi
       je        near ptr M10_L16
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Data.CountryName
       cmp       [rax],rcx
       jne       near ptr M10_L15
       mov       rcx,rax
       mov       rdx,rsi
       call      qword ptr [7FFDE9BA60A0]; System.Enum.Equals(System.Object)
M10_L05:
       test      eax,eax
       je        near ptr M10_L16
M10_L06:
       mov       eax,r13d
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
M10_L07:
       mov       rdx,7FFDEA45E940
       call      qword ptr [7FFDE9C6F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M10_L00
M10_L08:
       cmp       r13d,[rdi+8]
       jae       near ptr M10_L27
       mov       ecx,r13d
       shl       rcx,4
       lea       r12,[rdi+rcx+10]
       cmp       [r12+8],r15d
       jne       near ptr M10_L22
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+88]
       test      r11,r11
       je        near ptr M10_L19
M10_L09:
       mov       rax,[r12]
       mov       rcx,offset MT_System.Collections.Generic.ObjectEqualityComparer<System.Object>
       cmp       [r14],rcx
       jne       near ptr M10_L20
       test      rax,rax
       je        near ptr M10_L21
       test      rsi,rsi
       je        near ptr M10_L22
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Data.CountryName
       cmp       [rax],rcx
       jne       near ptr M10_L23
       mov       rcx,rax
       mov       rdx,rsi
       call      qword ptr [7FFDE9BA60A0]; System.Enum.Equals(System.Object)
M10_L10:
       test      eax,eax
       je        near ptr M10_L22
       jmp       near ptr M10_L06
M10_L11:
       xor       r15d,r15d
       jmp       near ptr M10_L03
M10_L12:
       xor       r15d,r15d
       jmp       near ptr M10_L02
M10_L13:
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
       mov       r15d,eax
       jmp       near ptr M10_L02
M10_L14:
       mov       rcx,r14
       mov       rdx,rsi
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       near ptr M10_L03
M10_L15:
       mov       rcx,rax
       mov       rdx,rsi
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       jmp       near ptr M10_L05
M10_L16:
       mov       r13d,[r12+0C]
       inc       ebp
       cmp       [rdi+8],ebp
       jae       short M10_L18
       jmp       short M10_L25
M10_L17:
       test      rsi,rsi
       jne       short M10_L16
       jmp       near ptr M10_L06
M10_L18:
       test      r13d,r13d
       jge       near ptr M10_L04
       jmp       short M10_L26
M10_L19:
       mov       rdx,7FFDEA45E958
       call      qword ptr [7FFDE9C6F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M10_L09
M10_L20:
       mov       rcx,r14
       mov       rdx,rax
       mov       r8,rsi
       call      qword ptr [r11]
       jmp       near ptr M10_L10
M10_L21:
       test      rsi,rsi
       je        near ptr M10_L06
M10_L22:
       mov       r13d,[r12+0C]
       inc       ebp
       cmp       [rdi+8],ebp
       jae       short M10_L24
       jmp       short M10_L25
M10_L23:
       mov       rcx,rax
       mov       rdx,rsi
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       jmp       near ptr M10_L10
M10_L24:
       test      r13d,r13d
       jge       near ptr M10_L08
       jmp       short M10_L26
M10_L25:
       call      qword ptr [7FFDE9C6F480]
       int       3
M10_L26:
       mov       eax,0FFFFFFFF
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
M10_L27:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 812
```
```assembly
; DotNetTips.Spargine.Core.EnumHelper.GetDescription(System.Enum)
; 		input = input.ArgumentNotNull();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return _descriptionCache.GetOrAdd(input, key =>
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		{
; 		 
; 			var type = key.GetType();
; 			                         
; 
; 
; 			// Verify this is actually an enum type
; 			                                       
; 			if (!type.IsEnum)
; 			                 
; 			{
; 			 
; 				throw new ArgumentException("Type provided must be an Enum.", nameof(input));
; 				                                                                             
; 			}
; 			 
; 
; 
; 			var name = Enum.GetName(type, key);
; 			                                   
; 
; 
; 			if (name == null)
; 			                 
; 			{
; 			 
; 				return key.ToString();
; 				                      
; 			}
; 			 
; 
; 
; 			// Get field and look for Description attribute first
; 			                                                     
; 			var field = type.GetField(name);
; 			                                
; 
; 
; 			if (field == null)
; 			                  
; 			{
; 			 
; 				return name;
; 				            
; 			}
; 			 
; 
; 
; 			// First try DescriptionAttribute
; 			                                 
; 			var descriptionAttr = field.GetCustomAttribute<DescriptionAttribute>(false);
; 			                                                                            
; 			if (descriptionAttr != null && !string.IsNullOrEmpty(descriptionAttr.Description))
; 			                                                                                  
; 			{
; 			 
; 				return descriptionAttr.Description;
; 				                                   
; 			}
; 			 
; 
; 
; 			// Then try EnumMemberAttribute
; 			                               
; 			var enumMemberAttr = field.GetCustomAttribute<EnumMemberAttribute>(false);
; 			                                                                          
; 			if (enumMemberAttr != null && !string.IsNullOrEmpty(enumMemberAttr.Value))
; 			                                                                          
; 			{
; 			 
; 				return enumMemberAttr.Value;
; 				                            
; 			}
; 			 
; 
; 
; 			// Fall back to the enum name
; 			                             
; 			return name;
; 			            
; 		});
; 		   
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp-40],rax
       mov       rbx,rcx
       test      rbx,rbx
       je        near ptr M11_L09
       mov       rcx,1E7AF802118
       mov       rsi,[rcx]
       mov       rcx,1E7AF802100
       mov       rdi,[rcx]
       test      rsi,rsi
       je        near ptr M11_L10
M11_L00:
       mov       r14,[rdi+8]
       mov       rcx,[r14+8]
       cmp       byte ptr [rdi+19],0
       jne       near ptr M11_L06
       mov       rdx,rbx
       mov       r11,7FFDE9BB0CC8
       call      qword ptr [r11]
       mov       r15d,eax
M11_L01:
       mov       r13,[r14+8]
       mov       rcx,[r14+10]
       mov       edx,r15d
       imul      rdx,[r14+28]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       mov       r8d,eax
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,eax
       jae       near ptr M11_L17
       mov       edx,edx
       mov       r12,[rcx+rdx*8+10]
       test      r12,r12
       je        near ptr M11_L16
       test      r13,r13
       je        near ptr M11_L07
       mov       rcx,offset MT_System.Collections.Generic.ObjectEqualityComparer<System.Enum>
       cmp       [r13],rcx
       jne       short M11_L07
M11_L02:
       cmp       r15d,[r12+20]
       jne       near ptr M11_L12
       mov       rax,[r12+8]
       test      rax,rax
       je        near ptr M11_L12
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Data.CountryName
       cmp       [rax],rcx
       jne       near ptr M11_L11
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFDE9BA60A0]; System.Enum.Equals(System.Object)
M11_L03:
       test      eax,eax
       je        near ptr M11_L12
M11_L04:
       mov       rdx,[r12+10]
       mov       [rbp-40],rdx
M11_L05:
       mov       rax,[rbp-40]
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M11_L06:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
       mov       r15d,eax
       jmp       near ptr M11_L01
M11_L07:
       cmp       r15d,[r12+20]
       jne       near ptr M11_L14
       mov       rax,[r12+8]
       mov       rcx,offset MT_System.Collections.Generic.ObjectEqualityComparer<System.Enum>
       cmp       [r13],rcx
       jne       near ptr M11_L13
       test      rax,rax
       je        near ptr M11_L14
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Data.CountryName
       cmp       [rax],rcx
       jne       near ptr M11_L15
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFDE9BA60A0]; System.Enum.Equals(System.Object)
M11_L08:
       test      eax,eax
       je        near ptr M11_L14
       jmp       near ptr M11_L04
M11_L09:
       call      qword ptr [7FFDEA28DC50]
       mov       ecx,1CAB
       mov       rdx,7FFDE9FB5C80
       call      qword ptr [7FFDE9C6F210]
       mov       rbx,rax
       mov       ecx,1B61
       mov       rdx,7FFDE9FB5C80
       call      qword ptr [7FFDE9C6F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFDE9C6D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,110B
       mov       rdx,7FFDE9FB5C80
       call      qword ptr [7FFDE9C6F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFDE9C6D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFDEA3FFAC8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFDEA3FE358]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M11_L10:
       mov       rcx,offset MT_System.Func<System.Enum, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,1E7AF802110
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Core.EnumHelper+<>c.<GetDescription>b__5_0(System.Enum)
       call      qword ptr [7FFDE9C66BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1E7AF802118
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M11_L00
M11_L11:
       mov       rcx,rax
       mov       rdx,rbx
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       jmp       near ptr M11_L03
M11_L12:
       mov       r12,[r12+18]
       test      r12,r12
       jne       near ptr M11_L02
       jmp       short M11_L16
M11_L13:
       mov       rcx,r13
       mov       r8,rbx
       mov       rdx,rax
       mov       r11,7FFDE9BB0CD0
       call      qword ptr [r11]
       jmp       near ptr M11_L08
M11_L14:
       mov       r12,[r12+18]
       test      r12,r12
       jne       near ptr M11_L07
       jmp       short M11_L16
M11_L15:
       mov       rcx,rax
       mov       rdx,rbx
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       jmp       near ptr M11_L08
M11_L16:
       xor       edx,edx
       mov       [rbp-40],rdx
       mov       rdx,rbx
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       xor       r9d,r9d
       mov       [rsp+28],r9d
       mov       dword ptr [rsp+30],1
       lea       r9,[rbp-40]
       mov       [rsp+38],r9
       mov       [rsp+20],rax
       mov       r9d,r15d
       shl       r9,20
       or        r9,1
       mov       rdx,r14
       mov       r8,rbx
       mov       rcx,rdi
       call      qword ptr [7FFDEA06C300]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryAddInternal(Tables<System.__Canon,System.__Canon>, System.__Canon, System.Nullable`1<Int32>, System.__Canon, Boolean, Boolean, System.__Canon ByRef)
       jmp       near ptr M11_L05
M11_L17:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 811
```
```assembly
; DotNetTips.Spargine.Tester.Data.CountryRepository.GetCountries()
; 		_countries ??= DeserializeCountries();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       mov       rbx,228446CB4D0
       mov       rcx,rbx
       call      System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rsi,1E7AF801308
       cmp       qword ptr [rsi],0
       je        short M12_L01
M12_L00:
       mov       rsi,[rsi]
       lea       rdx,[rbp-18]
       mov       rcx,rbx
       call      System.Threading.Monitor.ExitIfLockTaken(System.Object, Boolean ByRef)
       jmp       short M12_L02
M12_L01:
       call      qword ptr [7FFDEA1046D8]; DotNetTips.Spargine.Tester.Data.CountryRepository.DeserializeCountries()
       mov       rdx,rax
       mov       rcx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M12_L00
M12_L02:
       mov       rax,rsi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rbp
       ret
       sub       rsp,28
       lea       rdx,[rbp-18]
       mov       rbx,228446CB4D0
       mov       rcx,rbx
       call      System.Threading.Monitor.ExitIfLockTaken(System.Object, Boolean ByRef)
       nop
       add       rsp,28
       ret
; Total bytes of code 135
```
```assembly
; DotNetTips.Spargine.Tester.Data.CountryRepository+<>c__DisplayClass5_0.<GetCountry>b__0(DotNetTips.Spargine.Tester.Data.Models.Country)
; 		return GetCountries().FirstOrDefault(p => string.Equals(p.Name, countryNameDescription, StringComparison.Ordinal));
; 		                                          ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rbx
       sub       rsp,20
       mov       rdx,[rdx+68]
       mov       rcx,[rcx+8]
       cmp       rdx,rcx
       je        short M13_L05
       test      rdx,rdx
       je        short M13_L00
       test      rcx,rcx
       je        short M13_L00
       mov       r8d,[rdx+8]
       cmp       r8d,[rcx+8]
       je        short M13_L02
M13_L00:
       xor       eax,eax
M13_L01:
       add       rsp,20
       pop       rbx
       ret
M13_L02:
       lea       rax,[rdx+0C]
       add       rcx,0C
       mov       rbx,rcx
       mov       ecx,[rdx+8]
       add       ecx,ecx
       mov       r8d,ecx
       cmp       r8,0A
       je        short M13_L03
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFDE9C6C330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M13_L04
M13_L03:
       mov       rcx,[rax]
       mov       rax,[rax+2]
       mov       rdx,[rbx]
       xor       rcx,rdx
       xor       rax,[rbx+2]
       or        rax,rcx
       sete      al
       movzx     eax,al
M13_L04:
       jmp       short M13_L01
M13_L05:
       mov       eax,1
       jmp       short M13_L01
; Total bytes of code 120
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
       je        near ptr M14_L46
       test      rsi,rsi
       je        near ptr M14_L47
       mov       rcx,[rbx+18]
       mov       r14,[rcx+28]
       test      r14,r14
       je        near ptr M14_L41
M14_L00:
       mov       rcx,[r14+18]
       mov       rax,[rcx+28]
       test      rax,rax
       je        near ptr M14_L42
M14_L01:
       cmp       [rdi],rax
       je        near ptr M14_L36
       mov       rcx,[r14+18]
       cmp       qword ptr [rcx+8],30
       jle       near ptr M14_L43
       mov       rax,[rcx+30]
       test      rax,rax
       je        near ptr M14_L43
M14_L02:
       cmp       [rdi],rax
       je        near ptr M14_L35
       mov       rcx,[rbx+18]
       cmp       qword ptr [rcx+8],30
       jle       near ptr M14_L44
       mov       r11,[rcx+30]
       test      r11,r11
       je        near ptr M14_L44
M14_L03:
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Data.Models.Country>
       cmp       [rdi],rcx
       jne       near ptr M14_L53
       mov       rcx,[rdi+8]
       mov       r11,offset MT_DotNetTips.Spargine.Tester.Data.Models.Country[]
       cmp       [rcx],r11
       jne       near ptr M14_L49
       mov       r14d,[rcx+8]
       test      r14d,r14d
       je        near ptr M14_L52
M14_L04:
       mov       rdi,[rdi+8]
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Data.Models.Country[]
       cmp       [rdi],rcx
       jne       near ptr M14_L51
       mov       r14d,[rdi+8]
       test      r14d,r14d
       jne       near ptr M14_L45
       test      byte ptr [7FFDEA421948],1
       je        near ptr M14_L50
M14_L05:
       mov       rcx,1E7AF8024F8
       mov       r15,[rcx]
M14_L06:
       mov       [rbp-48],r15
       cmp       qword ptr [rbp-48],0
       je        near ptr M14_L18
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Data.Models.Country>
       mov       r15,[rbp-48]
       cmp       [r15],rcx
       jne       near ptr M14_L18
       mov       rcx,offset DotNetTips.Spargine.Tester.Data.CountryRepository+<>c__DisplayClass5_0.<GetCountry>b__0(DotNetTips.Spargine.Tester.Data.Models.Country)
       cmp       [rsi+18],rcx
       jne       near ptr M14_L18
       jmp       short M14_L10
M14_L07:
       mov       r10d,[r15+8]
       cmp       r10d,[r15+0C]
       jae       near ptr M14_L31
       mov       rdi,[r15+10]
       cmp       r10d,[rdi+8]
       jae       near ptr M14_L32
       mov       ecx,r10d
       mov       r14,[rdi+rcx*8+10]
       mov       r13,[rsi+8]
       mov       r12,[r14+68]
       mov       rdx,[r13+8]
       cmp       r12,rdx
       je        near ptr M14_L24
       test      r12,r12
       je        short M14_L08
       test      rdx,rdx
       je        short M14_L08
       mov       ecx,[r12+8]
       cmp       ecx,[rdx+8]
       je        short M14_L12
M14_L08:
       xor       eax,eax
M14_L09:
       test      eax,eax
       jne       short M14_L11
M14_L10:
       mov       eax,[r15+8]
       inc       eax
       cmp       eax,[r15+0C]
       jae       near ptr M14_L25
       mov       [r15+8],eax
       mov       rcx,[rbx+18]
       cmp       qword ptr [rcx+8],38
       jle       short M14_L07
       jmp       short M14_L07
M14_L11:
       mov       r9,[rbp+28]
       mov       byte ptr [r9],1
       jmp       near ptr M14_L33
M14_L12:
       lea       rcx,[r12+0C]
       add       rdx,0C
       mov       r8d,[r12+8]
       add       r8d,r8d
       cmp       r8,0A
       je        short M14_L13
       call      qword ptr [7FFDE9C6C330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M14_L14
M14_L13:
       mov       rax,[rcx]
       mov       rcx,[rcx+2]
       mov       r11,[rdx]
       xor       r11,rax
       xor       rcx,[rdx+2]
       or        rcx,r11
       sete      al
       movzx     eax,al
M14_L14:
       jmp       short M14_L09
M14_L15:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Data.Models.Country>
       cmp       [r15],rcx
       jne       near ptr M14_L28
       mov       r10d,[r15+8]
       cmp       r10d,[r15+0C]
       jae       near ptr M14_L31
       mov       rdi,[r15+10]
       cmp       r10d,[rdi+8]
       jae       near ptr M14_L32
       mov       ecx,r10d
       mov       r14,[rdi+rcx*8+10]
       mov       rcx,offset DotNetTips.Spargine.Tester.Data.CountryRepository+<>c__DisplayClass5_0.<GetCountry>b__0(DotNetTips.Spargine.Tester.Data.Models.Country)
       cmp       [rsi+18],rcx
       jne       near ptr M14_L29
       mov       r13,[rsi+8]
       mov       r12,[r14+68]
       mov       rdx,[r13+8]
       cmp       r12,rdx
       je        near ptr M14_L30
       test      r12,r12
       je        short M14_L16
       test      rdx,rdx
       je        short M14_L16
       mov       ecx,[r12+8]
       cmp       ecx,[rdx+8]
       je        short M14_L21
M14_L16:
       xor       eax,eax
M14_L17:
       test      eax,eax
       jne       near ptr M14_L11
M14_L18:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Data.Models.Country>
       mov       r15,[rbp-48]
       cmp       [r15],rcx
       jne       near ptr M14_L26
       mov       eax,[r15+8]
       inc       eax
       cmp       eax,[r15+0C]
       jae       near ptr M14_L27
       mov       [r15+8],eax
M14_L19:
       mov       rcx,[rbx+18]
       cmp       qword ptr [rcx+8],38
       jle       short M14_L20
       mov       r11,[rcx+38]
       test      r11,r11
       jne       near ptr M14_L15
M14_L20:
       mov       rcx,rbx
       mov       rdx,7FFDEA4A5FA8
       call      qword ptr [7FFDE9C6F630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M14_L15
M14_L21:
       lea       rcx,[r12+0C]
       add       rdx,0C
       mov       r8d,[r12+8]
       add       r8d,r8d
       cmp       r8,0A
       je        short M14_L22
       call      qword ptr [7FFDE9C6C330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M14_L23
M14_L22:
       mov       rax,rcx
       mov       rcx,rdx
       mov       r11,[rax]
       mov       rax,[rax+2]
       mov       rdx,[rcx]
       xor       r11,rdx
       xor       rax,[rcx+2]
       or        r11,rax
       sete      al
       movzx     eax,al
M14_L23:
       jmp       near ptr M14_L17
M14_L24:
       mov       eax,1
       jmp       near ptr M14_L09
M14_L25:
       mov       ecx,[r15+0C]
       mov       [r15+8],ecx
       jmp       near ptr M14_L54
M14_L26:
       mov       rcx,r15
       mov       r11,7FFDE9BB0CD8
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M14_L19
       jmp       near ptr M14_L54
M14_L27:
       mov       ecx,[r15+0C]
       mov       [r15+8],ecx
       jmp       near ptr M14_L54
M14_L28:
       mov       rcx,r15
       call      qword ptr [r11]
       mov       r14,rax
M14_L29:
       mov       rdx,r14
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       jmp       near ptr M14_L17
M14_L30:
       mov       eax,1
       jmp       near ptr M14_L17
M14_L31:
       mov       ecx,[r15+8]
       call      qword ptr [7FFDEA3FE370]
       int       3
M14_L32:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M14_L33:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Data.Models.Country>
       cmp       [r15],rcx
       jne       near ptr M14_L55
M14_L34:
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
M14_L35:
       mov       r15d,[rdi+10]
       mov       rbx,[rdi+8]
       cmp       [rbx+8],r15d
       jb        near ptr M14_L48
       add       rbx,10
       jmp       short M14_L37
M14_L36:
       lea       rbx,[rdi+10]
       mov       r15d,[rdi+8]
M14_L37:
       xor       edi,edi
       cmp       edi,r15d
       jge       short M14_L39
M14_L38:
       mov       r14,[rbx+rdi*8]
       mov       rdx,r14
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       jne       short M14_L40
       inc       edi
       cmp       edi,r15d
       jl        short M14_L38
M14_L39:
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
M14_L40:
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
M14_L41:
       mov       rcx,rbx
       mov       rdx,7FFDEA4A5E48
       call      qword ptr [7FFDE9C6F630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r14,rax
       jmp       near ptr M14_L00
M14_L42:
       mov       rcx,r14
       mov       rdx,7FFDEA4A61E8
       call      qword ptr [7FFDE9C6F630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       jmp       near ptr M14_L01
M14_L43:
       mov       rcx,r14
       mov       rdx,7FFDEA4A6278
       call      qword ptr [7FFDE9C6F630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       jmp       near ptr M14_L02
M14_L44:
       mov       rcx,rbx
       mov       rdx,7FFDEA4A5EF0
       call      qword ptr [7FFDE9C6F630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M14_L03
M14_L45:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Data.Models.Country>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       dword ptr [r15+8],0FFFFFFFF
       mov       [r15+0C],r14d
       lea       rcx,[r15+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M14_L06
M14_L46:
       mov       ecx,11
       call      qword ptr [7FFDE9C6F930]
       int       3
M14_L47:
       mov       ecx,0C
       call      qword ptr [7FFDE9C6F930]
       int       3
M14_L48:
       call      qword ptr [7FFDE9C6F480]
       int       3
M14_L49:
       mov       r11,7FFDE9BB0CE8
       call      qword ptr [r11]
       mov       r14d,eax
       test      r14d,r14d
       je        short M14_L52
       jmp       near ptr M14_L04
M14_L50:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Data.Models.Country>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M14_L05
M14_L51:
       mov       rcx,rdi
       mov       r11,7FFDE9BB0CF0
       call      qword ptr [r11]
       mov       r15,rax
       jmp       near ptr M14_L06
M14_L52:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Data.Models.Country>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1E7AF8024F8
       mov       r15,[rcx]
       jmp       near ptr M14_L06
M14_L53:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       r15,rax
       jmp       near ptr M14_L06
M14_L54:
       call      M14_L56
       jmp       near ptr M14_L39
M14_L55:
       mov       rcx,r15
       mov       r11,7FFDE9BB0CE0
       call      qword ptr [r11]
       jmp       near ptr M14_L34
M14_L56:
       sub       rsp,28
       cmp       qword ptr [rbp-48],0
       je        short M14_L57
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Data.Models.Country>
       mov       r15,[rbp-48]
       cmp       [r15],rcx
       je        short M14_L57
       mov       rcx,r15
       mov       r11,7FFDE9BB0CE0
       call      qword ptr [r11]
M14_L57:
       nop
       add       rsp,28
       ret
; Total bytes of code 1471
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
; System.DateTime.op_Subtraction(System.DateTime, System.DateTime)
       mov       rax,3FFFFFFFFFFFFFFF
       and       rax,rcx
       mov       rcx,3FFFFFFFFFFFFFFF
       and       rcx,rdx
       sub       rax,rcx
       ret
; Total bytes of code 30
```
```assembly
; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       test      rdx,rdx
       jne       short M17_L00
       mov       rcx,[rbx]
       call      qword ptr [7FFE496BB420]
       mov       rcx,rax
       call      qword ptr [7FFE496C1388]
       mov       rcx,rax
       call      qword ptr [7FFE496B8088]; Precode of System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
M17_L00:
       lea       rcx,[rbx+18]
       call      qword ptr [7FFE496B7FD0]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbx]
       call      qword ptr [7FFE496BBA80]
       cmp       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       je        short M17_L02
M17_L01:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M17_L02:
       mov       rcx,[rbx+18]
       call      qword ptr [7FFE496D8088]; Precode of System.Collections.Generic.NonRandomizedStringEqualityComparer.GetStringComparer(System.Object)
       mov       rsi,rax
       test      rsi,rsi
       je        short M17_L01
       mov       rcx,[rbx]
       call      qword ptr [7FFE496BB4D0]
       mov       rcx,rax
       mov       rdx,rsi
       cmp       [rdx],rcx
       je        short M17_L03
       mov       rdx,rsi
       call      qword ptr [7FFE496B8078]; Precode of System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdx,rax
M17_L03:
       lea       rcx,[rbx+18]
       call      qword ptr [7FFE496B7FD0]; CORINFO_HELP_ASSIGN_REF
       jmp       short M17_L01
; Total bytes of code 146
```
```assembly
; System.Enum.GetValues(System.Type)
       sub       rsp,28
       test      rcx,rcx
       je        short M18_L00
       lea       r11,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,28
       jmp       qword ptr [r11]
M18_L00:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFE496CB270]
       int       3
; Total bytes of code 40
```
```assembly
; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       mov       [rsp+40],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       cmp       qword ptr [rbx+8],0
       je        near ptr M19_L09
M19_L00:
       mov       rbp,[rbx+10]
       mov       r14,[rbx+18]
       xor       r15d,r15d
       test      rsi,rsi
       je        near ptr M19_L17
       mov       rcx,7FFDEA483798
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r13,[rdx+80]
       test      r13,r13
       je        near ptr M19_L10
M19_L01:
       mov       rcx,r14
       mov       rdx,7FFDEA4837A0
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rcx,r14
       mov       r11,r13
       mov       rdx,rsi
       call      qword ptr [r13]
       mov       r13d,eax
M19_L02:
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
       jae       near ptr M19_L21
       mov       edx,edx
       lea       r12,[rcx+rdx*4+10]
       mov       eax,[r12]
       dec       eax
       js        short M19_L05
M19_L03:
       cmp       eax,[rbp+8]
       jae       near ptr M19_L21
       mov       [rsp+3C],eax
       mov       ecx,eax
       shl       rcx,4
       lea       r8,[rbp+rcx+10]
       mov       [rsp+20],r8
       cmp       [r8+8],r13d
       je        near ptr M19_L11
M19_L04:
       mov       r8,[rsp+20]
       mov       eax,[r8+0C]
       mov       [rsp+3C],eax
       inc       r15d
       cmp       [rbp+8],r15d
       jb        near ptr M19_L18
       mov       rcx,7FFDEA4839BC
       call      CORINFO_HELP_COUNTPROFILE32
       cmp       dword ptr [rsp+3C],0
       mov       eax,[rsp+3C]
       jge       short M19_L03
M19_L05:
       cmp       dword ptr [rbx+30],0
       jg        near ptr M19_L19
       mov       eax,[rbx+28]
       mov       [rsp+38],eax
       cmp       [rbp+8],eax
       je        near ptr M19_L15
M19_L06:
       mov       rcx,7FFDEA4839C4
       call      CORINFO_HELP_COUNTPROFILE32
       mov       ebp,[rsp+38]
       lea       ecx,[rbp+1]
       mov       [rbx+28],ecx
       mov       rcx,[rbx+10]
       mov       rax,rcx
M19_L07:
       cmp       ebp,[rax+8]
       jae       near ptr M19_L21
       mov       ecx,ebp
       shl       rcx,4
       mov       [rsp+28],rax
       lea       rcx,[rax+rcx+10]
       mov       [rcx+8],r13d
       mov       edx,[r12]
       dec       edx
       mov       [rcx+0C],edx
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       lea       ecx,[rbp+1]
       mov       [r12],ecx
       inc       dword ptr [rbx+34]
       mov       [rdi],ebp
       cmp       r15d,64
       ja        near ptr M19_L20
       mov       rcx,7FFDEA4839D0
       call      CORINFO_HELP_COUNTPROFILE32
M19_L08:
       mov       rcx,7FFDEA4839CC
       call      CORINFO_HELP_COUNTPROFILE32
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
M19_L09:
       mov       rcx,7FFDEA483790
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFDE9E871B0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       jmp       near ptr M19_L00
M19_L10:
       mov       rdx,7FFDEA45E940
       call      qword ptr [7FFDE9C6F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r13,rax
       jmp       near ptr M19_L01
M19_L11:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r10,[rdx+88]
       test      r10,r10
       je        short M19_L13
       mov       [rsp+30],r10
M19_L12:
       mov       rcx,r14
       mov       rdx,7FFDEA4838A8
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rcx,r14
       mov       rax,[rsp+20]
       mov       rdx,[rax]
       mov       r11,[rsp+30]
       mov       r8,rsi
       call      qword ptr [r11]
       test      eax,eax
       je        short M19_L14
       mov       rcx,7FFDEA4839B0
       call      CORINFO_HELP_COUNTPROFILE32
       mov       ebp,[rsp+3C]
       mov       [rdi],ebp
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
M19_L13:
       mov       rdx,7FFDEA45E958
       call      qword ptr [7FFDE9C6F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       [rsp+30],rax
       jmp       short M19_L12
M19_L14:
       mov       rcx,7FFDEA4839B4
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M19_L04
M19_L15:
       mov       rcx,7FFDEA4839C0
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rbx
       call      qword ptr [7FFDEA3FE130]
       mov       rcx,[rbx+8]
       mov       eax,r13d
       imul      rax,[rbx+20]
       shr       rax,20
       inc       rax
       mov       edx,[rcx+8]
       mov       r8d,edx
       imul      rax,r8
       shr       rax,20
       cmp       eax,edx
       jae       near ptr M19_L21
       mov       eax,eax
       lea       r12,[rcx+rax*4+10]
       jmp       near ptr M19_L06
M19_L16:
       mov       rcx,7FFDEA483794
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M19_L08
M19_L17:
       xor       r13d,r13d
       jmp       near ptr M19_L02
M19_L18:
       mov       rcx,7FFDEA4839B8
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FFDE9C6F480]
       int       3
M19_L19:
       mov       ecx,[rbx+2C]
       mov       eax,ecx
       dec       dword ptr [rbx+30]
       cmp       ecx,[rbp+8]
       jae       short M19_L21
       shl       rcx,4
       mov       ecx,[rbp+rcx+1C]
       neg       ecx
       add       ecx,0FFFFFFFD
       mov       [rbx+2C],ecx
       mov       ecx,eax
       mov       rax,rbp
       mov       ebp,ecx
       jmp       near ptr M19_L07
M19_L20:
       mov       rdx,r14
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      qword ptr [7FFDE9C66850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M19_L16
       mov       rcx,7FFDEA4839C8
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rbp,[rsp+28]
       mov       edx,[rbp+8]
       mov       rcx,rbx
       mov       r8d,1
       call      qword ptr [7FFDEA067A50]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFDE9E87270]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       mov       [rdi],eax
       jmp       near ptr M19_L08
M19_L21:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 925
```
```assembly
; System.TimeSpan.FromMinutes(Int64)
       sub       rsp,28
       mov       rax,394427B08
       cmp       rcx,rax
       jg        short M20_L00
       mov       rax,0FFFFFFFC6BBD84F8
       cmp       rcx,rax
       jl        short M20_L00
       imul      rax,rcx,23C34600
       add       rsp,28
       ret
M20_L00:
       call      qword ptr [7FFE496CE3C0]
       int       3
; Total bytes of code 53
```
```assembly
; System.String.Trim()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,[rbx+8]
       test      esi,esi
       je        short M21_L01
       movzx     ecx,word ptr [rbx+0C]
       cmp       ecx,100
       jge       short M21_L02
       mov       rax,7FFE48A46918
       test      byte ptr [rax+rcx],80
       jne       short M21_L04
M21_L00:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jge       short M21_L03
       mov       rax,7FFE48A46918
       test      byte ptr [rax+rcx],80
       jne       short M21_L04
M21_L01:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M21_L02:
       call      qword ptr [7FFDEA3FD8F0]
       test      eax,eax
       jne       short M21_L04
       jmp       short M21_L00
M21_L03:
       call      qword ptr [7FFDEA3FD8F0]
       test      eax,eax
       je        short M21_L01
M21_L04:
       mov       rcx,rbx
       mov       edx,3
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFDEA3FD908]
; Total bytes of code 129
```
```assembly
; Microsoft.Extensions.Caching.Memory.MemoryCacheEntryOptions.set_AbsoluteExpirationRelativeToNow(System.Nullable`1<System.TimeSpan>)
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
       mov       rax,[rbp+18]
       vmovups   xmm0,[rax]
       vmovups   [rbp-10],xmm0
       mov       rax,228446CA570
       mov       rax,[rax]
       mov       [rbp-18],rax
       lea       rcx,[rbp-10]
       call      qword ptr [7FFDEA32F588]; System.Nullable`1[[System.TimeSpan, System.Private.CoreLib]].get_HasValue()
       test      eax,eax
       jne       short M22_L00
       xor       eax,eax
       mov       [rbp-24],eax
       jmp       short M22_L01
M22_L00:
       lea       rcx,[rbp-10]
       call      qword ptr [7FFDEA32F5A0]; System.Nullable`1[[System.TimeSpan, System.Private.CoreLib]].GetValueOrDefault()
       mov       [rbp-20],rax
       mov       rcx,[rbp-20]
       mov       rdx,[rbp-18]
       call      qword ptr [7FFDEA32F5B8]; System.TimeSpan.op_LessThanOrEqual(System.TimeSpan, System.TimeSpan)
       mov       [rbp-24],eax
M22_L01:
       cmp       dword ptr [rbp-24],0
       je        near ptr M22_L02
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-30],rax
       mov       ecx,1
       mov       rdx,7FFDEA3A4F98
       call      qword ptr [7FFDE9C6F210]
       mov       [rbp-38],rax
       mov       rdx,[rbp+18]
       mov       rcx,offset MT_System.Nullable<System.TimeSpan>
       call      qword ptr [7FFDE9C65878]; System.Runtime.CompilerServices.CastHelpers.Box_Nullable(System.Runtime.CompilerServices.MethodTable*, Byte ByRef)
       mov       [rbp-40],rax
       mov       ecx,41
       mov       rdx,7FFDEA3A4F98
       call      qword ptr [7FFDE9C6F210]
       mov       [rbp-48],rax
       mov       rdx,[rbp-38]
       mov       r8,[rbp-40]
       mov       r9,[rbp-48]
       mov       rcx,[rbp-30]
       call      qword ptr [7FFDEA32C678]
       mov       rcx,[rbp-30]
       call      CORINFO_HELP_THROW
       int       3
M22_L02:
       mov       rax,[rbp+18]
       mov       rcx,[rbp+10]
       vmovdqu   xmm0,xmmword ptr [rax]
       vmovdqu   xmmword ptr [rcx+38],xmm0
       add       rsp,70
       pop       rbp
       ret
; Total bytes of code 278
```
```assembly
; Microsoft.Extensions.Caching.Memory.CacheExtensions.Set[[System.__Canon, System.Private.CoreLib]](Microsoft.Extensions.Caching.Memory.IMemoryCache, System.Object, System.__Canon, Microsoft.Extensions.Caching.Memory.MemoryCacheEntryOptions)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp-10],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9
       mov       rcx,[rbp+18]
       mov       rdx,[rbp+20]
       mov       r11,7FFDE9BB08D8
       call      qword ptr [r11]
       mov       [rbp-8],rax
       cmp       qword ptr [rbp+30],0
       je        short M23_L00
       mov       rcx,[rbp-8]
       mov       rdx,[rbp+30]
       call      qword ptr [7FFDEA32F5D0]; Microsoft.Extensions.Caching.Memory.CacheEntryExtensions.SetOptions(Microsoft.Extensions.Caching.Memory.ICacheEntry, Microsoft.Extensions.Caching.Memory.MemoryCacheEntryOptions)
M23_L00:
       mov       rcx,[rbp-8]
       mov       rdx,[rbp+28]
       mov       r11,7FFDE9BB08E0
       call      qword ptr [r11]
       mov       rax,[rbp+28]
       mov       [rbp-10],rax
       call      M23_L01
       nop
       mov       rax,[rbp-10]
       add       rsp,30
       pop       rbp
       ret
M23_L01:
       sub       rsp,28
       cmp       qword ptr [rbp-8],0
       je        short M23_L02
       mov       rcx,[rbp-8]
       mov       r11,7FFDE9BB08E8
       call      qword ptr [r11]
M23_L02:
       nop
       add       rsp,28
       ret
; Total bytes of code 161
```

## .NET 10.0.0 (10.0.0, 10.0.25.52411), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.Data.CountryRepositoryBenchmark.GetCountries()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       call      qword ptr [7FFDEA1145D0]; DotNetTips.Spargine.Tester.Data.CountryRepository.GetCountries()
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
; DotNetTips.Spargine.Tester.Data.CountryRepository.GetCountries()
; 		_countries ??= DeserializeCountries();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       mov       rbx,16A68A1B4D0
       mov       rcx,rbx
       call      qword ptr [7FFDE9C75998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rsi,129D3C01308
       cmp       qword ptr [rsi],0
       je        short M01_L01
M01_L00:
       mov       rsi,[rsi]
       lea       rdx,[rbp-18]
       mov       rcx,rbx
       call      System.Threading.Monitor.ExitIfLockTaken(System.Object, Boolean ByRef)
       jmp       short M01_L02
M01_L01:
       call      qword ptr [7FFDEA1146D8]; DotNetTips.Spargine.Tester.Data.CountryRepository.DeserializeCountries()
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
       mov       rbx,16A68A1B4D0
       mov       rcx,rbx
       call      System.Threading.Monitor.ExitIfLockTaken(System.Object, Boolean ByRef)
       nop
       add       rsp,28
       ret
; Total bytes of code 136
```

## .NET 10.0.0 (10.0.0, 10.0.25.52411), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.Data.CountryRepositoryBenchmark.GetCountry()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       xor       eax,eax
       mov       [rbp-40],rax
       mov       [rbp+10],rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Data.CountryRepository+<>c__DisplayClass6_0
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,1F1C52B0668
       mov       [rbx+8],rcx
       mov       rdx,[rbx+8]
       cmp       dword ptr [rdx+8],0
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       cmp       ecx,[rdx+8]
       jae       near ptr M00_L59
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFDEA1045A0]; DotNetTips.Spargine.Tester.Data.CountryRepository.GetCountries()
       mov       rsi,rax
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],2
       jne       near ptr M00_L57
       test      rsi,rsi
       je        near ptr M00_L48
       mov       rdi,offset MT_DotNetTips.Spargine.Tester.Data.Models.Country[]
       cmp       [rsi],rdi
       je        near ptr M00_L42
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Data.Models.Country>
       cmp       [rsi],rcx
       je        near ptr M00_L41
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Data.Models.Country>
       cmp       [rsi],rcx
       jne       near ptr M00_L54
       mov       rcx,[rsi+8]
       cmp       [rcx],rdi
       jne       near ptr M00_L50
       mov       r14d,[rcx+8]
       test      r14d,r14d
       je        near ptr M00_L53
M00_L00:
       mov       rsi,[rsi+8]
       cmp       [rsi],rdi
       jne       near ptr M00_L52
       mov       edi,[rsi+8]
       test      edi,edi
       jne       near ptr M00_L47
       mov       r14,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Data.Models.Country>
       mov       rcx,r14
       test      byte ptr [7FFDEA3C97E0],1
       je        near ptr M00_L51
M00_L01:
       mov       rcx,1B130002118
       mov       r15,[rcx]
M00_L02:
       mov       [rbp-58],r15
       cmp       qword ptr [rbp-58],0
       je        near ptr M00_L17
       mov       r15,[rbp-58]
       mov       rsi,[r15]
       mov       r14,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Data.Models.Country>
       cmp       rsi,r14
       jne       near ptr M00_L17
       jmp       short M00_L08
M00_L03:
       mov       rdx,r8
       mov       r8d,r9d
       call      qword ptr [7FFDEA3D68E0]
       jmp       short M00_L07
M00_L04:
       xor       r12d,r12d
       cmp       r9d,4
       jae       near ptr M00_L20
M00_L05:
       cmp       r9d,2
       jb        near ptr M00_L10
       mov       edx,[rcx+r12]
       mov       eax,[r8+r12]
       mov       r10d,edx
       or        r10d,eax
       test      r10d,0FF80FF80
       jne       near ptr M00_L22
       xor       eax,edx
       shl       eax,2
       add       edx,50005
       or        edx,0A000A0
       add       edx,1A001A
       or        edx,0FF7FFF7F
       test      edx,eax
       je        near ptr M00_L09
M00_L06:
       xor       eax,eax
M00_L07:
       test      eax,eax
       jne       near ptr M00_L39
M00_L08:
       mov       eax,[r15+8]
       inc       eax
       cmp       eax,[r15+0C]
       jae       near ptr M00_L38
       mov       [r15+8],eax
       mov       r10d,[r15+8]
       cmp       r10d,[r15+0C]
       jae       near ptr M00_L36
       mov       rdi,[r15+10]
       cmp       r10d,[rdi+8]
       jae       near ptr M00_L37
       mov       ecx,r10d
       mov       r13,[rdi+rcx*8+10]
       mov       rcx,[r13+48]
       mov       r8,[rbx+8]
       cmp       rcx,r8
       je        near ptr M00_L18
       test      rcx,rcx
       je        near ptr M00_L19
       test      r8,r8
       je        near ptr M00_L19
       mov       edx,[rcx+8]
       mov       eax,[r8+8]
       cmp       edx,eax
       jne       near ptr M00_L19
       add       rcx,0C
       add       r8,0C
       mov       r9d,eax
       cmp       r9d,8
       jl        near ptr M00_L04
       cmp       r9d,10
       jl        near ptr M00_L03
       mov       rdx,r8
       mov       r8d,r9d
       call      qword ptr [7FFDEA3D68C8]
       jmp       near ptr M00_L07
M00_L09:
       add       r12,4
       add       r9d,0FFFFFFFE
M00_L10:
       test      r9d,r9d
       jne       near ptr M00_L21
M00_L11:
       mov       eax,1
       jmp       near ptr M00_L07
M00_L12:
       mov       rdx,r8
       mov       r8d,r9d
       call      qword ptr [7FFDEA3D68E0]
       jmp       short M00_L16
M00_L13:
       xor       r12d,r12d
M00_L14:
       cmp       r9d,4
       jae       near ptr M00_L26
       cmp       r9d,2
       jb        near ptr M00_L29
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
       je        near ptr M00_L28
M00_L15:
       xor       eax,eax
M00_L16:
       test      eax,eax
       jne       near ptr M00_L39
M00_L17:
       mov       r15,[rbp-58]
       mov       rsi,[r15]
       mov       r14,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Data.Models.Country>
       cmp       rsi,r14
       jne       near ptr M00_L25
       mov       eax,[r15+8]
       inc       eax
       cmp       eax,[r15+0C]
       jae       near ptr M00_L38
       mov       [r15+8],eax
       mov       ecx,[r15+8]
       cmp       ecx,[r15+0C]
       jae       near ptr M00_L36
       mov       rdi,[r15+10]
       mov       r10d,[r15+8]
       cmp       r10d,[rdi+8]
       jae       near ptr M00_L37
       mov       ecx,r10d
       mov       r13,[rdi+rcx*8+10]
       mov       rcx,[r13+48]
       mov       r8,[rbx+8]
       cmp       rcx,r8
       je        near ptr M00_L35
       test      rcx,rcx
       je        near ptr M00_L34
       test      r8,r8
       je        near ptr M00_L34
       mov       edx,[rcx+8]
       mov       r9d,[r8+8]
       cmp       edx,r9d
       jne       near ptr M00_L34
       add       rcx,0C
       add       r8,0C
       cmp       r9d,8
       jl        near ptr M00_L13
       cmp       r9d,10
       jl        near ptr M00_L12
       mov       rdx,r8
       mov       r8d,r9d
       call      qword ptr [7FFDEA3D68C8]
       jmp       near ptr M00_L16
M00_L18:
       mov       eax,1
       jmp       near ptr M00_L07
M00_L19:
       xor       eax,eax
       jmp       near ptr M00_L07
M00_L20:
       mov       rdx,[rcx+r12]
       mov       rax,[r8+r12]
       mov       r10,rdx
       or        r10,rax
       mov       r11,r10
       shr       r11,20
       or        r11d,r10d
       test      r11d,0FF80FF80
       jne       near ptr M00_L23
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
       jne       near ptr M00_L06
       add       r12,8
       add       r9d,0FFFFFFFC
       cmp       r9d,4
       jae       short M00_L20
       jmp       near ptr M00_L05
M00_L21:
       movzx     edx,word ptr [rcx+r12]
       movzx     eax,word ptr [r8+r12]
       mov       r10d,edx
       or        r10d,eax
       cmp       r10d,7F
       ja        short M00_L22
       cmp       edx,eax
       je        near ptr M00_L11
       or        edx,20
       lea       ecx,[rdx-61]
       cmp       ecx,19
       ja        near ptr M00_L06
       or        eax,20
       cmp       edx,eax
       sete      al
       movzx     eax,al
       jmp       near ptr M00_L07
M00_L22:
       test      edx,0FF80FF80
       je        near ptr M00_L06
       test      eax,0FF80FF80
       jne       short M00_L24
       jmp       near ptr M00_L06
M00_L23:
       mov       r10,0FF80FF80FF80FF80
       test      r10,rdx
       je        near ptr M00_L06
       mov       rdx,0FF80FF80FF80FF80
       test      rdx,rax
       je        near ptr M00_L06
M00_L24:
       add       rcx,r12
       add       r8,r12
       mov       edx,r9d
       call      qword ptr [7FFDEA3D6160]
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       near ptr M00_L07
M00_L25:
       mov       rcx,r15
       mov       r11,7FFDE9BB0A78
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M00_L55
       mov       rcx,r15
       mov       r11,7FFDE9BB0A80
       call      qword ptr [r11]
       mov       r13,rax
       mov       rcx,rbx
       mov       rdx,r13
       mov       rax,offset DotNetTips.Spargine.Tester.Data.CountryRepository+<>c__DisplayClass6_0.<GetCountry>b__0(DotNetTips.Spargine.Tester.Data.Models.Country)
       call      rax
       jmp       near ptr M00_L16
M00_L26:
       mov       rdx,[rcx+r12]
       mov       rax,[r8+r12]
       mov       r10,rdx
       or        r10,rax
       mov       r11,r10
       shr       r11,20
       or        r11d,r10d
       test      r11d,0FF80FF80
       je        short M00_L27
       mov       r10,0FF80FF80FF80FF80
       test      r10,rdx
       je        near ptr M00_L15
       mov       rdx,0FF80FF80FF80FF80
       test      rdx,rax
       je        near ptr M00_L15
       jmp       near ptr M00_L31
M00_L27:
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
       jne       near ptr M00_L15
       add       r12,8
       add       r9d,0FFFFFFFC
       jmp       near ptr M00_L14
M00_L28:
       add       r12,4
       add       r9d,0FFFFFFFE
M00_L29:
       test      r9d,r9d
       je        short M00_L33
       movzx     edx,word ptr [rcx+r12]
       movzx     eax,word ptr [r8+r12]
       mov       r10d,edx
       or        r10d,eax
       cmp       r10d,7F
       jbe       short M00_L32
M00_L30:
       test      edx,0FF80FF80
       je        near ptr M00_L15
       test      eax,0FF80FF80
       je        near ptr M00_L15
M00_L31:
       add       rcx,r12
       add       r8,r12
       mov       edx,r9d
       call      qword ptr [7FFDEA3D6160]
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       near ptr M00_L16
M00_L32:
       cmp       edx,eax
       je        short M00_L33
       or        edx,20
       lea       ecx,[rdx-61]
       cmp       ecx,19
       ja        near ptr M00_L15
       or        eax,20
       cmp       edx,eax
       sete      al
       movzx     eax,al
       jmp       near ptr M00_L16
M00_L33:
       mov       eax,1
       jmp       near ptr M00_L16
M00_L34:
       xor       eax,eax
       jmp       near ptr M00_L16
M00_L35:
       mov       eax,1
       jmp       near ptr M00_L16
M00_L36:
       mov       ecx,[r15+8]
       call      qword ptr [7FFDEA3D6358]
       int       3
M00_L37:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L38:
       mov       ecx,[r15+0C]
       mov       [r15+8],ecx
       jmp       near ptr M00_L55
M00_L39:
       cmp       rsi,r14
       jne       near ptr M00_L56
M00_L40:
       mov       [rbp-50],r13
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+18]
       lea       r8,[rbp-50]
       mov       rdx,7FFDEA3C99F0
       cmp       [rcx],ecx
       call      qword ptr [7FFDEA33ED48]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L41:
       mov       r13d,[rsi+10]
       mov       r15,[rsi+8]
       cmp       [r15+8],r13d
       jb        near ptr M00_L49
       add       r15,10
       jmp       short M00_L43
M00_L42:
       lea       r15,[rsi+10]
       mov       r13d,[rsi+8]
M00_L43:
       xor       esi,esi
       cmp       esi,r13d
       jge       short M00_L45
M00_L44:
       mov       rdi,[r15+rsi*8]
       mov       rcx,rbx
       mov       rdx,rdi
       mov       rax,offset DotNetTips.Spargine.Tester.Data.CountryRepository+<>c__DisplayClass6_0.<GetCountry>b__0(DotNetTips.Spargine.Tester.Data.Models.Country)
       call      rax
       test      eax,eax
       jne       short M00_L46
       inc       esi
       cmp       esi,r13d
       jl        short M00_L44
M00_L45:
       xor       r13d,r13d
       jmp       near ptr M00_L40
M00_L46:
       mov       r13,rdi
       jmp       near ptr M00_L40
M00_L47:
       mov       r14,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Data.Models.Country>
       mov       rcx,r14
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       dword ptr [r15+8],0FFFFFFFF
       mov       [r15+0C],edi
       lea       rcx,[r15+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L02
M00_L48:
       mov       ecx,11
       call      qword ptr [7FFDE9C6F930]
       int       3
M00_L49:
       call      qword ptr [7FFDE9C6F480]
       int       3
M00_L50:
       mov       r11,7FFDE9BB0A90
       call      qword ptr [r11]
       mov       r14d,eax
       test      r14d,r14d
       je        short M00_L53
       jmp       near ptr M00_L00
M00_L51:
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L01
M00_L52:
       mov       rcx,rsi
       mov       r11,7FFDE9BB0A98
       call      qword ptr [r11]
       mov       r15,rax
       jmp       near ptr M00_L02
M00_L53:
       mov       r14,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Data.Models.Country>
       mov       rcx,r14
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1B130002118
       mov       r15,[rcx]
       jmp       near ptr M00_L02
M00_L54:
       mov       rcx,rsi
       mov       r11,7FFDE9BB0A70
       call      qword ptr [r11]
       mov       r15,rax
       jmp       near ptr M00_L02
M00_L55:
       call      M00_L60
       jmp       near ptr M00_L45
M00_L56:
       mov       rcx,r15
       mov       r11,7FFDE9BB0A88
       call      qword ptr [r11]
       jmp       near ptr M00_L40
M00_L57:
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],3
       jne       short M00_L58
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Data.Models.Country, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,r13
       mov       rdx,rbx
       mov       r8,7FFDEA33AC88
       call      qword ptr [7FFDE9C66BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       lea       r9,[rbp-40]
       mov       rdx,rsi
       mov       r8,r13
       mov       rcx,7FFDEA3C95B0
       call      qword ptr [7FFDEA337BB8]; System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>, Boolean ByRef)
       mov       r13,rax
       jmp       near ptr M00_L40
M00_L58:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Data.Models.Country, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,r13
       mov       rdx,rbx
       mov       r8,7FFDEA33ACA0
       call      qword ptr [7FFDE9C66BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       lea       r9,[rbp-48]
       mov       rdx,rsi
       mov       r8,r13
       mov       rcx,7FFDEA3C95B0
       call      qword ptr [7FFDEA337BB8]; System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>, Boolean ByRef)
       mov       r13,rax
       jmp       near ptr M00_L40
M00_L59:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L60:
       sub       rsp,28
       cmp       qword ptr [rbp-58],0
       je        short M00_L61
       mov       r15,[rbp-58]
       mov       rsi,[r15]
       mov       r14,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Data.Models.Country>
       cmp       rsi,r14
       je        short M00_L61
       mov       rcx,r15
       mov       r11,7FFDE9BB0A88
       call      qword ptr [r11]
M00_L61:
       nop
       add       rsp,28
       ret
; Total bytes of code 2202
```
```assembly
; DotNetTips.Spargine.Tester.Data.CountryRepository.GetCountries()
; 		_countries ??= DeserializeCountries();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       mov       rbx,1F1C52AB4D0
       mov       rcx,rbx
       call      qword ptr [7FFDE9C65998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rsi,1B130001308
       cmp       qword ptr [rsi],0
       je        short M01_L01
M01_L00:
       mov       rsi,[rsi]
       lea       rdx,[rbp-18]
       mov       rcx,rbx
       call      System.Threading.Monitor.ExitIfLockTaken(System.Object, Boolean ByRef)
       jmp       short M01_L02
M01_L01:
       call      qword ptr [7FFDEA1046A8]; DotNetTips.Spargine.Tester.Data.CountryRepository.DeserializeCountries()
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
       mov       rbx,1F1C52AB4D0
       mov       rcx,rbx
       call      System.Threading.Monitor.ExitIfLockTaken(System.Object, Boolean ByRef)
       nop
       add       rsp,28
       ret
; Total bytes of code 136
```
```assembly
; DotNetTips.Spargine.Tester.Data.CountryRepository+<>c__DisplayClass6_0.<GetCountry>b__0(DotNetTips.Spargine.Tester.Data.Models.Country)
; 			info = countryData.FirstOrDefault(p => string.Equals(p.Iso2, countryNameOrIso, StringComparison.OrdinalIgnoreCase));
; 			                                       ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rdx,[rdx+48]
       mov       rcx,[rcx+8]
       cmp       rdx,rcx
       je        short M02_L02
       test      rdx,rdx
       je        short M02_L03
       test      rcx,rcx
       je        short M02_L03
       mov       r8d,[rdx+8]
       mov       eax,[rcx+8]
       cmp       r8d,eax
       jne       short M02_L03
       add       rdx,0C
       add       rcx,0C
       mov       r10,rcx
       cmp       eax,8
       jl        short M02_L01
       cmp       eax,10
       jl        short M02_L00
       mov       rcx,rdx
       mov       rdx,r10
       mov       r8d,eax
       jmp       qword ptr [7FFDEA3D68C8]
M02_L00:
       mov       rcx,rdx
       mov       rdx,r10
       mov       r8d,eax
       jmp       qword ptr [7FFDEA3D68E0]
M02_L01:
       mov       rcx,rdx
       mov       rdx,r10
       mov       r8d,eax
       jmp       qword ptr [7FFDEA33ED30]; System.Globalization.Ordinal.EqualsIgnoreCase_Scalar(Char ByRef, Char ByRef, Int32)
M02_L02:
       mov       eax,1
       jmp       short M02_L04
M02_L03:
       xor       eax,eax
M02_L04:
       ret
; Total bytes of code 111
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
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M04_L00
       ret
M04_L00:
       jmp       qword ptr [7FFDE9C65C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M05_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M05_L00:
       call      qword ptr [7FFDEA3D6178]
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
       je        near ptr M06_L64
       test      rsi,rsi
       je        near ptr M06_L65
       mov       rcx,[rbx+18]
       mov       r14,[rcx+28]
       test      r14,r14
       je        near ptr M06_L59
M06_L00:
       mov       rcx,[r14+18]
       mov       rax,[rcx+28]
       test      rax,rax
       je        near ptr M06_L60
M06_L01:
       cmp       [rdi],rax
       je        near ptr M06_L54
       mov       rcx,[r14+18]
       cmp       qword ptr [rcx+8],30
       jle       near ptr M06_L61
       mov       rax,[rcx+30]
       test      rax,rax
       je        near ptr M06_L61
M06_L02:
       cmp       [rdi],rax
       je        near ptr M06_L53
       mov       rcx,[rbx+18]
       cmp       qword ptr [rcx+8],30
       jle       near ptr M06_L62
       mov       r11,[rcx+30]
       test      r11,r11
       je        near ptr M06_L62
M06_L03:
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Data.Models.Country>
       cmp       [rdi],rcx
       jne       near ptr M06_L71
       mov       rcx,[rdi+8]
       mov       r11,offset MT_DotNetTips.Spargine.Tester.Data.Models.Country[]
       cmp       [rcx],r11
       jne       near ptr M06_L67
       mov       r14d,[rcx+8]
       test      r14d,r14d
       je        near ptr M06_L70
M06_L04:
       mov       rdi,[rdi+8]
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Data.Models.Country[]
       cmp       [rdi],rcx
       jne       near ptr M06_L69
       mov       r14d,[rdi+8]
       test      r14d,r14d
       jne       near ptr M06_L63
       test      byte ptr [7FFDEA3C97E0],1
       je        near ptr M06_L68
M06_L05:
       mov       rcx,1B130002118
       mov       r15,[rcx]
M06_L06:
       mov       [rbp-48],r15
       cmp       qword ptr [rbp-48],0
       je        near ptr M06_L23
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Data.Models.Country>
       mov       r15,[rbp-48]
       cmp       [r15],rcx
       jne       near ptr M06_L23
       mov       rcx,offset DotNetTips.Spargine.Tester.Data.CountryRepository+<>c__DisplayClass6_0.<GetCountry>b__0(DotNetTips.Spargine.Tester.Data.Models.Country)
       cmp       [rsi+18],rcx
       jne       near ptr M06_L23
       jmp       short M06_L12
M06_L07:
       mov       rdx,r8
       mov       r8d,r9d
       call      qword ptr [7FFDEA3D68E0]
       jmp       short M06_L11
M06_L08:
       xor       r12d,r12d
       cmp       r9d,4
       jae       near ptr M06_L29
M06_L09:
       cmp       r9d,2
       jb        near ptr M06_L16
       mov       edx,[rcx+r12]
       mov       eax,[r8+r12]
       mov       r10d,edx
       or        r10d,eax
       test      r10d,0FF80FF80
       jne       near ptr M06_L31
       xor       eax,edx
       shl       eax,2
       add       edx,50005
       or        edx,0A000A0
       add       edx,1A001A
       or        edx,0FF7FFF7F
       test      edx,eax
       je        near ptr M06_L15
M06_L10:
       xor       eax,eax
M06_L11:
       test      eax,eax
       jne       near ptr M06_L14
M06_L12:
       mov       eax,[r15+8]
       inc       eax
       cmp       eax,[r15+0C]
       jae       near ptr M06_L34
       mov       [r15+8],eax
       mov       rcx,[rbx+18]
       cmp       qword ptr [rcx+8],38
       jle       short M06_L13
M06_L13:
       mov       r10d,[r15+8]
       cmp       r10d,[r15+0C]
       jae       near ptr M06_L49
       mov       rdi,[r15+10]
       cmp       r10d,[rdi+8]
       jae       near ptr M06_L50
       mov       ecx,r10d
       mov       r14,[rdi+rcx*8+10]
       mov       r13,[rsi+8]
       mov       rcx,[r14+48]
       mov       r8,[r13+8]
       cmp       rcx,r8
       je        near ptr M06_L27
       test      rcx,rcx
       je        near ptr M06_L28
       test      r8,r8
       je        near ptr M06_L28
       mov       edx,[rcx+8]
       mov       eax,[r8+8]
       cmp       edx,eax
       jne       near ptr M06_L28
       add       rcx,0C
       add       r8,0C
       mov       r9d,eax
       cmp       r9d,8
       jl        near ptr M06_L08
       cmp       r9d,10
       jl        near ptr M06_L07
       mov       rdx,r8
       mov       r8d,r9d
       call      qword ptr [7FFDEA3D68C8]
       jmp       near ptr M06_L11
M06_L14:
       mov       r9,[rbp+28]
       mov       byte ptr [r9],1
       jmp       near ptr M06_L51
M06_L15:
       add       r12,4
       add       r9d,0FFFFFFFE
M06_L16:
       test      r9d,r9d
       jne       near ptr M06_L30
M06_L17:
       mov       eax,1
       jmp       near ptr M06_L11
M06_L18:
       mov       rdx,r8
       mov       r8d,r9d
       call      qword ptr [7FFDEA3D68E0]
       jmp       short M06_L22
M06_L19:
       xor       r12d,r12d
M06_L20:
       cmp       r9d,4
       jae       near ptr M06_L39
       cmp       r9d,2
       jb        near ptr M06_L42
       mov       edx,[rcx+r12]
       mov       eax,[r8+r12]
       mov       r10d,edx
       or        r10d,eax
       test      r10d,0FF80FF80
       jne       near ptr M06_L43
       xor       eax,edx
       shl       eax,2
       add       edx,50005
       or        edx,0A000A0
       add       edx,1A001A
       or        edx,0FF7FFF7F
       test      edx,eax
       je        near ptr M06_L41
M06_L21:
       xor       eax,eax
M06_L22:
       test      eax,eax
       jne       near ptr M06_L14
M06_L23:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Data.Models.Country>
       mov       r15,[rbp-48]
       cmp       [r15],rcx
       jne       near ptr M06_L35
       mov       eax,[r15+8]
       inc       eax
       cmp       eax,[r15+0C]
       jae       near ptr M06_L36
       mov       [r15+8],eax
M06_L24:
       mov       rcx,[rbx+18]
       cmp       qword ptr [rcx+8],38
       jle       near ptr M06_L26
       mov       r11,[rcx+38]
       test      r11,r11
       je        near ptr M06_L26
M06_L25:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Data.Models.Country>
       cmp       [r15],rcx
       jne       near ptr M06_L37
       mov       r10d,[r15+8]
       cmp       r10d,[r15+0C]
       jae       near ptr M06_L49
       mov       rdi,[r15+10]
       cmp       r10d,[rdi+8]
       jae       near ptr M06_L50
       mov       ecx,r10d
       mov       r14,[rdi+rcx*8+10]
       mov       rcx,offset DotNetTips.Spargine.Tester.Data.CountryRepository+<>c__DisplayClass6_0.<GetCountry>b__0(DotNetTips.Spargine.Tester.Data.Models.Country)
       cmp       [rsi+18],rcx
       jne       near ptr M06_L38
       mov       r13,[rsi+8]
       mov       rcx,[r14+48]
       mov       r8,[r13+8]
       cmp       rcx,r8
       je        near ptr M06_L48
       test      rcx,rcx
       je        near ptr M06_L47
       test      r8,r8
       je        near ptr M06_L47
       mov       edx,[rcx+8]
       mov       r9d,[r8+8]
       cmp       edx,r9d
       jne       near ptr M06_L47
       add       rcx,0C
       add       r8,0C
       cmp       r9d,8
       jl        near ptr M06_L19
       cmp       r9d,10
       jl        near ptr M06_L18
       mov       rdx,r8
       mov       r8d,r9d
       call      qword ptr [7FFDEA3D68C8]
       jmp       near ptr M06_L22
M06_L26:
       mov       rcx,rbx
       mov       rdx,7FFDEA431750
       call      qword ptr [7FFDE9C6F630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M06_L25
M06_L27:
       mov       eax,1
       jmp       near ptr M06_L11
M06_L28:
       xor       eax,eax
       jmp       near ptr M06_L11
M06_L29:
       mov       rdx,[rcx+r12]
       mov       rax,[r8+r12]
       mov       r10,rdx
       or        r10,rax
       mov       r11,r10
       shr       r11,20
       or        r11d,r10d
       test      r11d,0FF80FF80
       jne       near ptr M06_L32
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
       jne       near ptr M06_L10
       add       r12,8
       add       r9d,0FFFFFFFC
       cmp       r9d,4
       jae       short M06_L29
       jmp       near ptr M06_L09
M06_L30:
       movzx     edx,word ptr [rcx+r12]
       movzx     eax,word ptr [r8+r12]
       mov       r10d,edx
       or        r10d,eax
       cmp       r10d,7F
       ja        short M06_L31
       cmp       edx,eax
       je        near ptr M06_L17
       or        edx,20
       lea       ecx,[rdx-61]
       cmp       ecx,19
       ja        near ptr M06_L10
       or        eax,20
       cmp       edx,eax
       sete      al
       movzx     eax,al
       jmp       near ptr M06_L11
M06_L31:
       test      edx,0FF80FF80
       je        near ptr M06_L10
       test      eax,0FF80FF80
       jne       short M06_L33
       jmp       near ptr M06_L10
M06_L32:
       mov       r10,0FF80FF80FF80FF80
       test      r10,rdx
       je        near ptr M06_L10
       mov       rdx,0FF80FF80FF80FF80
       test      rdx,rax
       je        near ptr M06_L10
M06_L33:
       add       rcx,r12
       add       r8,r12
       mov       edx,r9d
       call      qword ptr [7FFDEA3D6160]
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       near ptr M06_L11
M06_L34:
       mov       ecx,[r15+0C]
       mov       [r15+8],ecx
       jmp       near ptr M06_L72
M06_L35:
       mov       rcx,r15
       mov       r11,7FFDE9BB0AD8
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M06_L24
       jmp       near ptr M06_L72
M06_L36:
       mov       ecx,[r15+0C]
       mov       [r15+8],ecx
       jmp       near ptr M06_L72
M06_L37:
       mov       rcx,r15
       call      qword ptr [r11]
       mov       r14,rax
M06_L38:
       mov       rdx,r14
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       jmp       near ptr M06_L22
M06_L39:
       mov       rdx,[rcx+r12]
       mov       rax,[r8+r12]
       mov       r10,rdx
       or        r10,rax
       mov       r11,r10
       shr       r11,20
       or        r11d,r10d
       test      r11d,0FF80FF80
       je        short M06_L40
       mov       r10,0FF80FF80FF80FF80
       test      r10,rdx
       je        near ptr M06_L21
       mov       rdx,0FF80FF80FF80FF80
       test      rdx,rax
       je        near ptr M06_L21
       jmp       near ptr M06_L44
M06_L40:
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
       jne       near ptr M06_L21
       add       r12,8
       add       r9d,0FFFFFFFC
       jmp       near ptr M06_L20
M06_L41:
       add       r12,4
       add       r9d,0FFFFFFFE
M06_L42:
       test      r9d,r9d
       je        short M06_L46
       movzx     edx,word ptr [rcx+r12]
       movzx     eax,word ptr [r8+r12]
       mov       r10d,edx
       or        r10d,eax
       cmp       r10d,7F
       jbe       short M06_L45
M06_L43:
       test      edx,0FF80FF80
       je        near ptr M06_L21
       test      eax,0FF80FF80
       je        near ptr M06_L21
M06_L44:
       add       rcx,r12
       add       r8,r12
       mov       edx,r9d
       call      qword ptr [7FFDEA3D6160]
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       near ptr M06_L22
M06_L45:
       cmp       edx,eax
       je        short M06_L46
       or        edx,20
       lea       ecx,[rdx-61]
       cmp       ecx,19
       ja        near ptr M06_L21
       or        eax,20
       cmp       edx,eax
       sete      al
       movzx     eax,al
       jmp       near ptr M06_L22
M06_L46:
       mov       eax,1
       jmp       near ptr M06_L22
M06_L47:
       xor       eax,eax
       jmp       near ptr M06_L22
M06_L48:
       mov       eax,1
       jmp       near ptr M06_L22
M06_L49:
       mov       ecx,[r15+8]
       call      qword ptr [7FFDEA3D6358]
       int       3
M06_L50:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M06_L51:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Data.Models.Country>
       cmp       [r15],rcx
       jne       near ptr M06_L73
M06_L52:
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
M06_L53:
       mov       r15d,[rdi+10]
       mov       rbx,[rdi+8]
       cmp       [rbx+8],r15d
       jb        near ptr M06_L66
       add       rbx,10
       jmp       short M06_L55
M06_L54:
       lea       rbx,[rdi+10]
       mov       r15d,[rdi+8]
M06_L55:
       xor       edi,edi
       cmp       edi,r15d
       jge       short M06_L57
M06_L56:
       mov       r14,[rbx+rdi*8]
       mov       rdx,r14
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       jne       short M06_L58
       inc       edi
       cmp       edi,r15d
       jl        short M06_L56
M06_L57:
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
M06_L58:
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
M06_L59:
       mov       rcx,rbx
       mov       rdx,7FFDEA4315F0
       call      qword ptr [7FFDE9C6F630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r14,rax
       jmp       near ptr M06_L00
M06_L60:
       mov       rcx,r14
       mov       rdx,7FFDEA431990
       call      qword ptr [7FFDE9C6F630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       jmp       near ptr M06_L01
M06_L61:
       mov       rcx,r14
       mov       rdx,7FFDEA431A20
       call      qword ptr [7FFDE9C6F630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       jmp       near ptr M06_L02
M06_L62:
       mov       rcx,rbx
       mov       rdx,7FFDEA431698
       call      qword ptr [7FFDE9C6F630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M06_L03
M06_L63:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Data.Models.Country>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       dword ptr [r15+8],0FFFFFFFF
       mov       [r15+0C],r14d
       lea       rcx,[r15+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M06_L06
M06_L64:
       mov       ecx,11
       call      qword ptr [7FFDE9C6F930]
       int       3
M06_L65:
       mov       ecx,0C
       call      qword ptr [7FFDE9C6F930]
       int       3
M06_L66:
       call      qword ptr [7FFDE9C6F480]
       int       3
M06_L67:
       mov       r11,7FFDE9BB0AE8
       call      qword ptr [r11]
       mov       r14d,eax
       test      r14d,r14d
       je        short M06_L70
       jmp       near ptr M06_L04
M06_L68:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Data.Models.Country>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M06_L05
M06_L69:
       mov       rcx,rdi
       mov       r11,7FFDE9BB0AF0
       call      qword ptr [r11]
       mov       r15,rax
       jmp       near ptr M06_L06
M06_L70:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Data.Models.Country>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1B130002118
       mov       r15,[rcx]
       jmp       near ptr M06_L06
M06_L71:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       r15,rax
       jmp       near ptr M06_L06
M06_L72:
       call      M06_L74
       jmp       near ptr M06_L57
M06_L73:
       mov       rcx,r15
       mov       r11,7FFDE9BB0AE0
       call      qword ptr [r11]
       jmp       near ptr M06_L52
M06_L74:
       sub       rsp,28
       cmp       qword ptr [rbp-48],0
       je        short M06_L75
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Data.Models.Country>
       mov       r15,[rbp-48]
       cmp       [r15],rcx
       je        short M06_L75
       mov       rcx,r15
       mov       r11,7FFDE9BB0AE0
       call      qword ptr [r11]
M06_L75:
       nop
       add       rsp,28
       ret
; Total bytes of code 2276
```

