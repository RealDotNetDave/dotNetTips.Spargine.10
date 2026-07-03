## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.TypeExtensionsBenchmark.GetAllDeclaredFields()
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
       vmovdqu   xmmword ptr [rsp+48],xmm4
       xor       eax,eax
       mov       [rsp+58],rax
       mov       [rsp+0C0],rcx
       mov       rcx,1BA3BBD1178
       mov       rsi,[rcx]
       test      rsi,rsi
       je        near ptr M00_L45
M00_L00:
       mov       rdi,[rsi+20]
       test      rdi,rdi
       jne       near ptr M00_L07
       mov       [rsp+40],rsi
       mov       rcx,[rsi+8]
       cmp       [rcx],ecx
       call      qword ptr [7FF7D52C4B70]; System.Type.GetRootElementType()
       mov       rdi,rax
       mov       [rsp+38],rdi
       mov       rcx,offset MT_System.RuntimeType
       cmp       [rdi],rcx
       jne       near ptr M00_L17
       mov       rcx,[rdi+18]
       test      cl,2
       jne       near ptr M00_L46
       mov       ecx,[rcx]
       and       ecx,80000030
       cmp       ecx,30
       sete      al
       movzx     eax,al
M00_L01:
       test      eax,eax
       jne       short M00_L04
       mov       rcx,offset MT_System.RuntimeType
       cmp       [rdi],rcx
       jne       near ptr M00_L18
       mov       rcx,rdi
       call      qword ptr [7FF7D52C4B70]; System.Type.GetRootElementType()
       mov       rcx,rax
       mov       rax,offset MT_System.RuntimeType
       cmp       [rcx],rax
       jne       near ptr M00_L47
M00_L02:
       test      rcx,rcx
       je        near ptr M00_L48
       call      00007FF834D34580
M00_L03:
       test      eax,eax
       jne       near ptr M00_L49
M00_L04:
       mov       rcx,offset MT_System.RuntimeType
       cmp       [rdi],rcx
       jne       near ptr M00_L19
       mov       rcx,[rdi+18]
       mov       rax,7FF834D23B20
       vzeroupper
       call      rax
       movzx     ebx,al
       cmp       dword ptr [7FF8350439A0],0
       jne       near ptr M00_L50
M00_L05:
       cmp       ebx,1B
       je        near ptr M00_L49
M00_L06:
       mov       rsi,[rsp+40]
       lea       rdx,[rsi+20]
       mov       rcx,rsi
       mov       r8d,3
       call      qword ptr [7FF7D52CCC60]; System.RuntimeType+RuntimeTypeCache.ConstructName(System.String ByRef, System.TypeNameFormatFlags)
       mov       rdi,rax
M00_L07:
       test      rdi,rdi
       je        near ptr M00_L51
       cmp       dword ptr [rdi+8],0
       je        near ptr M00_L51
       mov       esi,[rdi+8]
       lea       edx,[rsi+15]
       test      edx,edx
       jl        near ptr M00_L52
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FF834D89D30
       mov       rbp,rax
       cmp       [rbp],bpl
       lea       rcx,[rbp+0C]
       mov       r8d,[rdi+8]
       add       r8,r8
       lea       rdx,[rdi+0C]
       call      qword ptr [7FF7D50F5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       eax,esi
       lea       rax,[rbp+rax*2+0C]
       vmovups   ymm0,[7FF7D51AA600]
       vmovups   [rax],ymm0
       mov       rcx,64006C00650069
       mov       [rax+20],rcx
       mov       word ptr [rax+28],73
M00_L08:
       mov       rcx,1BA52000180
       mov       rsi,[rcx]
       mov       edi,[rbp+8]
       test      edi,edi
       je        near ptr M00_L53
       movzx     ecx,word ptr [rbp+0C]
       cmp       ecx,100
       jge       near ptr M00_L55
       mov       rax,7FF833EE6098
       test      byte ptr [rax+rcx],80
       jne       near ptr M00_L57
M00_L09:
       dec       edi
       mov       ecx,edi
       movzx     ecx,word ptr [rbp+rcx*2+0C]
       cmp       ecx,100
       jge       near ptr M00_L56
       mov       rax,7FF833EE6098
       test      byte ptr [rax+rcx],80
       jne       near ptr M00_L57
M00_L10:
       mov       rdi,rbp
M00_L11:
       mov       rsi,[rsi+10]
       test      rdi,rdi
       jne       near ptr M00_L20
       xor       r14d,r14d
       xor       r15d,r15d
M00_L12:
       cmp       byte ptr [rsi+44],0
       jne       near ptr M00_L58
       mov       rdi,[rsi+28]
       mov       rcx,[rdi+20]
       mov       r13,[rcx+8]
       mov       r12,[r13+8]
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer+OrdinalComparer
       cmp       [r12],rcx
       jne       near ptr M00_L59
       mov       [rsp+48],r14
       mov       [rsp+50],r15d
       lea       rcx,[rsp+48]
       call      qword ptr [7FF7D5675E90]; System.String.GetNonRandomizedHashCode(System.ReadOnlySpan`1<Char>)
M00_L13:
       mov       [rsp+74],eax
       mov       rcx,[r13+10]
       mov       edx,eax
       imul      rdx,[r13+28]
       shr       rdx,20
       inc       rdx
       mov       r8d,[rcx+8]
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,[rcx+8]
       jae       near ptr M00_L83
       mov       edx,edx
       mov       r13,[rcx+rdx*8+10]
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer+OrdinalComparer
       cmp       [r12],rcx
       jne       near ptr M00_L27
M00_L14:
       test      r13,r13
       je        near ptr M00_L72
       cmp       eax,[r13+20]
       jne       near ptr M00_L61
       mov       r8,[r13+8]
       test      r15d,r15d
       je        near ptr M00_L60
M00_L15:
       test      r8,r8
       jne       near ptr M00_L21
       xor       edx,edx
       xor       r10d,r10d
M00_L16:
       cmp       r15d,r10d
       jne       near ptr M00_L26
       mov       r8d,r10d
       add       r8,r8
       cmp       r8,0A
       jne       short M00_L22
       mov       rcx,r14
       mov       r8,[rcx]
       mov       rcx,[rcx+2]
       mov       r10,[rdx]
       xor       r8,r10
       xor       rcx,[rdx+2]
       or        rcx,r8
       sete      cl
       movzx     ecx,cl
       mov       eax,ecx
       jmp       short M00_L23
M00_L17:
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+60]
       call      qword ptr [rax+10]
       jmp       near ptr M00_L01
M00_L18:
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+0B0]
       call      qword ptr [rax]
       jmp       near ptr M00_L03
M00_L19:
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+60]
       call      qword ptr [rax+30]
       test      eax,eax
       jne       near ptr M00_L49
       jmp       near ptr M00_L06
M00_L20:
       lea       r14,[rdi+0C]
       mov       r15d,[rdi+8]
       jmp       near ptr M00_L12
M00_L21:
       lea       rdx,[r8+0C]
       mov       r10d,[r8+8]
       jmp       near ptr M00_L16
M00_L22:
       mov       rcx,r14
       call      qword ptr [7FF7D50FC330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
M00_L23:
       test      eax,eax
       je        near ptr M00_L61
M00_L24:
       mov       r14,[r13+10]
M00_L25:
       mov       rdx,[rsi+10]
       mov       rcx,[rdx+8]
       test      rcx,rcx
       jne       short M00_L28
       call      qword ptr [7FF7D5606808]; System.DateTime.get_UtcNow()
       mov       r15,rax
       jmp       short M00_L29
M00_L26:
       xor       ecx,ecx
       mov       eax,ecx
       jmp       short M00_L23
M00_L27:
       test      r13,r13
       jne       near ptr M00_L62
       jmp       near ptr M00_L72
M00_L28:
       lea       rdx,[rsp+60]
       mov       r11,7FF7D5040A28
       call      qword ptr [r11]
       mov       r15,4000000000000000
       or        r15,[rsp+68]
M00_L29:
       test      r14,r14
       je        near ptr M00_L43
       cmp       byte ptr [r14+43],0
       jne       near ptr M00_L42
       cmp       qword ptr [r14+38],0
       jge       short M00_L30
       cmp       qword ptr [r14+50],0
       je        short M00_L33
M00_L30:
       mov       rdx,3FFFFFFFFFFFFFFF
       and       rdx,r15
       cmp       [r14+38],rdx
       jbe       near ptr M00_L73
       cmp       qword ptr [r14+50],0
       jg        near ptr M00_L74
M00_L31:
       xor       r13d,r13d
M00_L32:
       test      r13d,r13d
       jne       near ptr M00_L42
M00_L33:
       cmp       qword ptr [r14+10],0
       je        short M00_L34
       mov       rcx,[r14+10]
       mov       rdx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FF7D57F5AA0]
       test      eax,eax
       jne       near ptr M00_L42
M00_L34:
       mov       [r14+58],r15
       mov       rdi,[r14+20]
       cmp       byte ptr [rsi+45],0
       jne       near ptr M00_L75
M00_L35:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+28]
       mov       rax,[rsi+48]
       mov       rdx,3FFFFFFFFFFFFFFF
       and       rdx,r15
       mov       r8,3FFFFFFFFFFFFFFF
       and       rax,r8
       sub       rdx,rax
       cmp       rcx,rdx
       jge       near ptr M00_L39
       mov       [rsi+48],r15
       test      byte ptr [7FF7D58352B0],1
       je        near ptr M00_L76
M00_L36:
       mov       rcx,1BA52000288
       mov       r14,[rcx]
       test      r14,r14
       jne       short M00_L37
       mov       rcx,offset MT_System.Action<System.Object>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,1BA52000280
       mov       rdx,[rcx]
       test      rdx,rdx
       je        near ptr M00_L77
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FF7D57F2AD8
       mov       [r14+18],rcx
       mov       rcx,1BA52000288
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
M00_L37:
       test      byte ptr [7FF7D5821458],1
       je        near ptr M00_L78
M00_L38:
       mov       rcx,1BA520002B8
       mov       r15,[rcx]
       test      r15,r15
       je        near ptr M00_L79
       mov       rcx,offset MT_System.Threading.Tasks.Task
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       test      r14,r14
       je        near ptr M00_L80
       mov       dword ptr [rsp+20],8
       mov       dword ptr [rsp+28],2000
       mov       [rsp+30],r15
       mov       rcx,r13
       mov       rdx,r14
       mov       r8,rsi
       xor       r9d,r9d
       call      qword ptr [7FF7D57F6B20]
       call      qword ptr [7FF7D57F6B38]
       mov       rdx,rax
       mov       rcx,r13
       call      qword ptr [7FF7D57F6B50]
       mov       rcx,r13
       xor       edx,edx
       call      qword ptr [7FF7D57F6B68]
M00_L39:
       cmp       qword ptr [rsi+20],0
       jne       near ptr M00_L81
M00_L40:
       test      rdi,rdi
       je        near ptr M00_L82
       mov       rdx,rdi
       mov       rcx,offset MT_System.Reflection.FieldInfo[]
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
       test      rax,rax
       je        near ptr M00_L44
       mov       r14,rdi
       test      r14,r14
       je        short M00_L41
       mov       rcx,offset MT_System.Reflection.FieldInfo[]
       cmp       [r14],rcx
       je        short M00_L41
       mov       rdx,rdi
       call      qword ptr [7FF7D50F58D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       r14,rax
M00_L41:
       mov       [rsp+58],r14
       mov       rbx,[rsp+0C0]
       mov       rcx,[rbx+60]
       lea       r8,[rsp+58]
       mov       rdx,7FF7D57D4938
       cmp       [rcx],ecx
       call      qword ptr [7FF7D571E6A0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
M00_L42:
       cmp       byte ptr [r14+45],2
       je        near ptr M00_L34
       mov       r8,[rsi+10]
       mov       rcx,rdi
       mov       rdx,r14
       call      qword ptr [7FF7D57F5B00]
M00_L43:
       mov       rcx,rsi
       mov       rdx,r15
       call      qword ptr [7FF7D57F6B80]
       cmp       qword ptr [rsi+20],0
       je        short M00_L44
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       call      qword ptr [7FF7D57F5AE8]
       inc       qword ptr [rax+18]
M00_L44:
       mov       rcx,1FAD0EBB598
       mov       edx,3E
       mov       rax,[7FF7D503A200]
       call      qword ptr [rax+28]
       mov       r14,rax
       mov       ecx,5
       call      qword ptr [7FF7D571D758]; System.TimeSpan.FromMinutes(Int64)
       mov       [rsp+20],rax
       mov       rcx,1BA52000180
       mov       rcx,[rcx]
       mov       r8,rbp
       mov       r9,r14
       mov       rdx,7FF7D5773908
       call      qword ptr [7FF7D571D728]; DotNetTips.Spargine.Core.Cache.InMemoryCache.AddCacheItem[[System.__Canon, System.Private.CoreLib]](System.String, System.__Canon, System.TimeSpan)
       jmp       near ptr M00_L41
M00_L45:
       mov       rcx,1FAD0EBB598
       call      qword ptr [7FF7D52C56E0]; System.RuntimeType.InitializeCache()
       mov       rsi,rax
       jmp       near ptr M00_L00
M00_L46:
       xor       eax,eax
       jmp       near ptr M00_L01
M00_L47:
       mov       rax,[rcx]
       mov       rax,[rax+98]
       call      qword ptr [rax+8]
       mov       rcx,rax
       jmp       near ptr M00_L02
M00_L48:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF7D57F5B90]
       mov       r8,rax
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FF7D57F5BA8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M00_L49:
       xor       edi,edi
       jmp       near ptr M00_L07
M00_L50:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L05
M00_L51:
       mov       rbp,1FAD0EC0708
       jmp       near ptr M00_L08
M00_L52:
       call      qword ptr [7FF7D57F56E0]
       int       3
M00_L53:
       call      qword ptr [7FF7D55043F0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L54
       call      qword ptr [7FF7D57F6A48]
       mov       rbx,rax
M00_L54:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,1FAD0EB9C08
       call      qword ptr [7FF7D57F5BA8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L55:
       call      qword ptr [7FF7D57F5728]
       test      eax,eax
       jne       short M00_L57
       jmp       near ptr M00_L09
M00_L56:
       call      qword ptr [7FF7D57F5728]
       test      eax,eax
       je        near ptr M00_L10
M00_L57:
       mov       rcx,rbp
       mov       edx,3
       call      qword ptr [7FF7D57F5740]
       mov       rdi,rax
       jmp       near ptr M00_L11
M00_L58:
       call      qword ptr [7FF7D57F59E0]
       int       3
M00_L59:
       mov       [rsp+48],r14
       mov       [rsp+50],r15d
       lea       rdx,[rsp+48]
       mov       rcx,r12
       mov       r11,7FF7D5040A18
       call      qword ptr [r11]
       jmp       near ptr M00_L13
M00_L60:
       test      r8,r8
       jne       near ptr M00_L15
M00_L61:
       mov       r13,[r13+18]
       mov       eax,[rsp+74]
       jmp       near ptr M00_L14
M00_L62:
       cmp       eax,[r13+20]
       jne       near ptr M00_L70
       mov       r8,[r13+8]
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer+OrdinalComparer
       cmp       [r12],rcx
       je        short M00_L63
       mov       [rsp+48],r14
       mov       [rsp+50],r15d
       lea       rdx,[rsp+48]
       mov       rcx,r12
       mov       r11,7FF7D5040A20
       call      qword ptr [r11]
       jmp       short M00_L71
M00_L63:
       test      r15d,r15d
       jne       short M00_L64
       test      r8,r8
       je        short M00_L70
M00_L64:
       test      r8,r8
       je        short M00_L65
       lea       rdx,[r8+0C]
       mov       r10d,[r8+8]
       jmp       short M00_L66
M00_L65:
       xor       edx,edx
       xor       r10d,r10d
M00_L66:
       cmp       r15d,r10d
       je        short M00_L67
       xor       edx,edx
       mov       eax,edx
       jmp       short M00_L69
M00_L67:
       mov       r8d,r10d
       add       r8,r8
       cmp       r8,0A
       je        short M00_L68
       mov       rcx,r14
       call      qword ptr [7FF7D50FC330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M00_L69
M00_L68:
       mov       r8,r14
       mov       rcx,[r8]
       mov       r8,[r8+2]
       mov       r11,[rdx]
       xor       rcx,r11
       xor       r8,[rdx+2]
       or        r8,rcx
       sete      dl
       movzx     edx,dl
       mov       eax,edx
M00_L69:
       jmp       short M00_L71
M00_L70:
       mov       r13,[r13+18]
       mov       eax,[rsp+74]
       jmp       near ptr M00_L27
M00_L71:
       test      eax,eax
       je        short M00_L70
       jmp       near ptr M00_L24
M00_L72:
       xor       r14d,r14d
       jmp       near ptr M00_L25
M00_L73:
       mov       rcx,r14
       mov       edx,3
       call      qword ptr [7FF7D57F6AF0]
       mov       r13d,1
       jmp       near ptr M00_L32
M00_L74:
       mov       rdx,[r14+58]
       mov       rcx,r15
       call      qword ptr [7FF7D571E3B8]; System.DateTime.op_Subtraction(System.DateTime, System.DateTime)
       mov       rcx,rax
       mov       rdx,[r14+50]
       call      qword ptr [7FF7D57F6B08]
       test      eax,eax
       jne       short M00_L73
       jmp       near ptr M00_L31
M00_L75:
       mov       rcx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FF7D57F5AB8]
       jmp       near ptr M00_L35
M00_L76:
       mov       rcx,offset MT_Microsoft.Extensions.Caching.Memory.MemoryCache+<>c
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L36
M00_L77:
       call      qword ptr [7FF7D57F52C0]
       int       3
M00_L78:
       mov       rcx,offset MT_System.Threading.Tasks.TaskScheduler
       call      qword ptr [7FF7D50F5740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L38
M00_L79:
       mov       ecx,2F
       call      qword ptr [7FF7D50FFD50]
       int       3
M00_L80:
       mov       ecx,1C
       call      qword ptr [7FF7D50FFD50]
       int       3
M00_L81:
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       call      qword ptr [7FF7D57F5AE8]
       inc       qword ptr [rax+10]
       jmp       near ptr M00_L40
M00_L82:
       xor       r14d,r14d
       jmp       near ptr M00_L41
M00_L83:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 2394
```
```assembly
; System.Type.GetRootElementType()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
M01_L00:
       cmp       rsi,[rbx]
       jne       short M01_L05
       mov       rcx,rbx
       call      qword ptr [7FF834B66788]; Precode of System.RuntimeType.GetCorElementType()
       cmp       eax,1D
       ja        short M01_L01
       mov       ecx,1FEF7FFF
       bt        ecx,eax
       jae       short M01_L04
M01_L01:
       cmp       eax,10
       sete      dil
       movzx     edi,dil
M01_L02:
       test      edi,edi
       jne       short M01_L03
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L03:
       mov       rcx,rbx
       lea       r11,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       call      qword ptr [r11]
       mov       rbx,rax
       jmp       short M01_L00
M01_L04:
       mov       edi,1
       jmp       short M01_L02
M01_L05:
       mov       rcx,rbx
       lea       r11,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       call      qword ptr [r11]
       mov       edi,eax
       jmp       short M01_L02
; Total bytes of code 114
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
       call      qword ptr [7FF834B661B0]; Precode of System.RuntimeTypeHandle.ConstructName(System.TypeNameFormatFlags)
       mov       rsi,rax
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FF834B53FF0]; CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 64
```
```assembly
; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M03_L10
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M03_L10
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       jbe       near ptr M03_L06
       cmp       r8,40
       jbe       short M03_L02
       cmp       r8,800
       ja        near ptr M03_L11
       cmp       r8,100
       jae       near ptr M03_L09
M03_L00:
       mov       r9,r8
       shr       r9,6
M03_L01:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M03_L01
       and       r8,3F
       cmp       r8,10
       jbe       short M03_L03
M03_L02:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       jbe       short M03_L03
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       ja        short M03_L05
M03_L03:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
M03_L04:
       vzeroupper
       ret
M03_L05:
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M03_L03
M03_L06:
       test      r8b,18
       je        short M03_L07
       mov       rdx,[rdx]
       mov       [rcx],rdx
       mov       rcx,[rax-8]
       mov       [r10-8],rcx
       jmp       short M03_L04
M03_L07:
       test      r8b,4
       je        short M03_L08
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
       jmp       short M03_L04
M03_L08:
       test      r8,r8
       je        short M03_L04
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M03_L04
       movsx     rcx,word ptr [rax-2]
       mov       [r10-2],cx
       jmp       short M03_L04
M03_L09:
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
       jmp       near ptr M03_L00
M03_L10:
       cmp       rcx,rdx
       jne       short M03_L11
       cmp       [rdx],dl
       jmp       near ptr M03_L04
M03_L11:
       cmp       [rcx],cl
       cmp       [rdx],dl
       vzeroupper
       jmp       qword ptr [7FF7D50F66E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 327
```
```assembly
; System.String.GetNonRandomizedHashCode(System.ReadOnlySpan`1<Char>)
       push      rax
       xor       eax,eax
       mov       [rsp],rax
M04_L00:
       mov       eax,15051505
       mov       edx,15051505
       mov       r8d,[rcx+8]
       mov       rcx,[rcx]
       mov       [rsp],rcx
M04_L01:
       cmp       r8d,3
       ja        short M04_L03
       mov       r8d,r8d
       lea       r10,[7FF7D51A9A80]
       mov       r10d,[r10+r8*4]
       lea       r9,[M04_L00]
       add       r10,r9
       jmp       r10
       mov       r8d,edx
       rol       r8d,5
       add       r8d,edx
       mov       edx,r8d
       xor       edx,[rcx]
M04_L02:
       xor       ecx,ecx
       mov       [rsp],rcx
       imul      ecx,edx,5D588B65
       add       eax,ecx
       add       rsp,8
       ret
       nop
M04_L03:
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
       jge       short M04_L03
       jmp       short M04_L01
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
       jmp       short M04_L02
       mov       r8d,edx
       rol       r8d,5
       add       r8d,edx
       movzx     edx,word ptr [rcx]
       xor       edx,r8d
       jmp       short M04_L02
; Total bytes of code 189
```
```assembly
; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       r8,8
       jb        short M05_L03
       cmp       rcx,rdx
       je        short M05_L02
       cmp       r8,20
       jb        near ptr M05_L08
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFE0
       je        short M05_L01
       vmovups   ymm0,[rcx]
       vpcmpeqb  ymm0,ymm0,[rdx]
       vpmovmskb r10d,ymm0
       cmp       r10d,0FFFFFFFF
       jne       near ptr M05_L12
M05_L00:
       add       rax,20
       cmp       r8,rax
       jbe       short M05_L01
       vmovups   ymm0,[rcx+rax]
       vpcmpeqb  ymm0,ymm0,[rdx+rax]
       vpmovmskb r10d,ymm0
       cmp       r10d,0FFFFFFFF
       jne       near ptr M05_L12
       jmp       short M05_L00
M05_L01:
       vmovups   ymm0,[rcx+r8]
       vpcmpeqb  ymm0,ymm0,[rdx+r8]
       vpmovmskb ecx,ymm0
       cmp       ecx,0FFFFFFFF
       jne       near ptr M05_L12
M05_L02:
       mov       eax,1
       vzeroupper
       ret
M05_L03:
       cmp       r8,4
       jae       short M05_L06
       xor       eax,eax
       mov       r10,r8
       and       r10,2
       je        short M05_L04
       movzx     eax,word ptr [rcx]
       movzx     r9d,word ptr [rdx]
       sub       eax,r9d
M05_L04:
       test      r8b,1
       je        short M05_L05
       movzx     r8d,byte ptr [rcx+r10]
       movzx     ecx,byte ptr [rdx+r10]
       sub       r8d,ecx
       or        eax,r8d
M05_L05:
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       short M05_L07
M05_L06:
       lea       rax,[r8-4]
       mov       r8d,[rcx]
       sub       r8d,[rdx]
       mov       ecx,[rcx+rax]
       sub       ecx,[rdx+rax]
       or        ecx,r8d
       sete      al
       movzx     eax,al
M05_L07:
       vzeroupper
       ret
M05_L08:
       cmp       r8,10
       jb        short M05_L11
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFF0
       je        short M05_L10
M05_L09:
       vmovups   xmm0,[rcx+rax]
       vpcmpeqb  xmm0,xmm0,[rdx+rax]
       vpmovmskb r10d,xmm0
       cmp       r10d,0FFFF
       jne       short M05_L12
       add       rax,10
       cmp       r8,rax
       ja        short M05_L09
M05_L10:
       vmovups   xmm0,[rcx+r8]
       vpcmpeqb  xmm0,xmm0,[rdx+r8]
       vpmovmskb eax,xmm0
       cmp       eax,0FFFF
       jne       short M05_L12
       jmp       near ptr M05_L02
M05_L11:
       lea       rax,[r8-8]
       mov       r8,[rcx]
       sub       r8,[rdx]
       mov       rcx,[rcx+rax]
       sub       rcx,[rdx+rax]
       or        rcx,r8
       sete      al
       movzx     eax,al
       jmp       short M05_L07
M05_L12:
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
       mov       rax,7FF9523C5380
       call      rax
       mov       rbx,[rbp-18]
       mov       rax,1BA3C001B00
       mov       rsi,[rax]
       sub       rbx,[rsi+8]
       cmp       dword ptr [7FF8350439A0],0
       jne       short M06_L01
M06_L00:
       mov       eax,0B2D05E00
       cmp       rbx,rax
       jae       short M06_L02
       mov       rax,rbx
       add       rax,[rsi+10]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M06_L01:
       call      CORINFO_HELP_POLL_GC
       jmp       short M06_L00
M06_L02:
       call      qword ptr [7FF7D56069D0]; System.DateTime.UpdateLeapSecondCacheAndReturnUtcNow()
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 105
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
       push      rsi
       push      rbx
       test      rdx,rdx
       je        short M07_L00
       mov       rax,[rdx]
       cmp       rax,rcx
       jne       short M07_L01
M07_L00:
       mov       rax,rdx
       pop       rbx
       pop       rsi
       ret
M07_L01:
       mov       r8,1BA3C000038
       mov       r8,[r8]
       add       r8,10
       rorx      r10,rax,20
       xor       r10,rcx
       mov       r9,9E3779B97F4A7C15
       imul      r10,r9
       mov       r9d,[r8]
       shrx      r10,r10,r9
       xor       r9d,r9d
M07_L02:
       lea       r11d,[r10+1]
       movsxd    r11,r11d
       lea       r11,[r11+r11*2]
       lea       r11,[r8+r11*8]
       mov       ebx,[r11]
       mov       rsi,[r11+8]
       and       ebx,0FFFFFFFE
       cmp       rsi,rax
       jne       short M07_L03
       mov       rsi,rcx
       xor       rsi,[r11+10]
       cmp       rsi,1
       jbe       short M07_L04
M07_L03:
       test      ebx,ebx
       je        short M07_L05
       inc       r9d
       add       r10d,r9d
       and       r10d,[r8+4]
       cmp       r9d,8
       jl        short M07_L02
       jmp       short M07_L05
M07_L04:
       cmp       ebx,[r11]
       jne       short M07_L05
       jmp       short M07_L06
M07_L05:
       mov       esi,2
M07_L06:
       cmp       esi,1
       je        near ptr M07_L00
       test      esi,esi
       jne       short M07_L07
       xor       edx,edx
       jmp       near ptr M07_L00
M07_L07:
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FF7D50FFAB0]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny_NoCacheLookup(Void*, System.Object)
; Total bytes of code 177
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       push      rsi
       push      rbx
       test      rdx,rdx
       je        short M08_L00
       mov       rax,[rdx]
       cmp       rax,rcx
       jne       short M08_L01
M08_L00:
       mov       rax,rdx
       pop       rbx
       pop       rsi
       ret
M08_L01:
       mov       r8,1BA3C000038
       mov       r8,[r8]
       add       r8,10
       rorx      r10,rax,20
       xor       r10,rcx
       mov       r9,9E3779B97F4A7C15
       imul      r10,r9
       mov       r9d,[r8]
       shrx      r10,r10,r9
       xor       r9d,r9d
       cmp       r9d,8
       jge       short M08_L05
M08_L02:
       lea       r11d,[r10+1]
       movsxd    r11,r11d
       lea       r11,[r11+r11*2]
       lea       r11,[r8+r11*8]
       mov       ebx,[r11]
       mov       rsi,[r11+8]
       and       ebx,0FFFFFFFE
       cmp       rsi,rax
       jne       short M08_L03
       mov       rsi,rcx
       xor       rsi,[r11+10]
       cmp       rsi,1
       jbe       short M08_L04
M08_L03:
       test      ebx,ebx
       je        short M08_L05
       inc       r9d
       add       r10d,r9d
       and       r10d,[r8+4]
       cmp       r9d,8
       jl        short M08_L02
       jmp       short M08_L05
M08_L04:
       cmp       ebx,[r11]
       jne       short M08_L05
       cmp       esi,1
       je        near ptr M08_L00
M08_L05:
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FF7D50F6340]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny_NoCacheLookup(Void*, System.Object)
; Total bytes of code 165
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
; System.TimeSpan.FromMinutes(Int64)
       sub       rsp,28
       mov       rax,394427B08
       cmp       rcx,rax
       jg        short M10_L00
       mov       rax,0FFFFFFFC6BBD84F8
       cmp       rcx,rax
       jl        short M10_L00
       imul      rax,rcx,23C34600
       add       rsp,28
       ret
M10_L00:
       call      qword ptr [7FF834B6A320]
       int       3
; Total bytes of code 53
```
```assembly
; DotNetTips.Spargine.Core.Cache.InMemoryCache.AddCacheItem[[System.__Canon, System.Private.CoreLib]](System.String, System.__Canon, System.TimeSpan)
       push      rbp
       sub       rsp,70
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-30],ymm4
       mov       [rbp-10],rax
       mov       [rbp-8],rdx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9
; 		key = key.ArgumentNotNullOrEmpty();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rax,1FAD0EB9C08
       mov       [rsp+20],rax
       mov       rcx,[rbp+20]
       mov       edx,1
       xor       r8d,r8d
       mov       r9,1FAD0EB0008
       call      qword ptr [7FF7D55043C0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       [rbp+20],rax
; 		item = item.ArgumentNotNull();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       xor       eax,eax
       mov       [rbp-10],rax
       mov       rax,[rbp+18]
       mov       rax,[rax+18]
       mov       rax,[rax+10]
       mov       [rbp-40],rax
       cmp       qword ptr [rbp-40],0
       je        short M11_L00
       mov       rax,[rbp-40]
       mov       [rbp-18],rax
       jmp       short M11_L01
M11_L00:
       mov       rcx,[rbp+18]
       mov       rdx,7FF7D57C2F08
       call      qword ptr [7FF7D50FF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-18],rax
M11_L01:
       mov       rax,1FAD0EBBA80
       mov       [rsp+20],rax
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+28]
       mov       r8,[rbp-10]
       mov       r9,1FAD0EB0008
       call      qword ptr [7FF7D567EA78]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp+28],rax
; 		_ = this.Cache.Set(key, item, new MemoryCacheEntryOptions().SetAbsoluteExpiration(timeout));
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,offset MT_Microsoft.Extensions.Caching.Memory.MemoryCacheEntryOptions
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-20],rax
       mov       rcx,[rbp+10]
       call      qword ptr [7FF7D571E208]; DotNetTips.Spargine.Core.Cache.InMemoryCache.get_Cache()
       mov       [rbp-28],rax
       mov       rcx,[rbp-20]
       call      qword ptr [7FF7D571E490]; Microsoft.Extensions.Caching.Memory.MemoryCacheEntryOptions..ctor()
       mov       rax,[rbp+18]
       mov       rax,[rax+18]
       mov       rax,[rax+18]
       mov       [rbp-48],rax
       cmp       qword ptr [rbp-48],0
       je        short M11_L02
       mov       rax,[rbp-48]
       mov       [rbp-30],rax
       jmp       short M11_L03
M11_L02:
       mov       rcx,[rbp+18]
       mov       rdx,7FF7D57C3400
       call      qword ptr [7FF7D50FF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-30],rax
M11_L03:
       mov       rcx,[rbp-20]
       mov       rdx,[rbp+30]
       call      qword ptr [7FF7D571E4A8]; Microsoft.Extensions.Caching.Memory.MemoryCacheEntryExtensions.SetAbsoluteExpiration(Microsoft.Extensions.Caching.Memory.MemoryCacheEntryOptions, System.TimeSpan)
       mov       [rbp-38],rax
       mov       rax,[rbp-38]
       mov       [rsp+20],rax
       mov       rdx,[rbp-28]
       mov       r8,[rbp+20]
       mov       r9,[rbp+28]
       mov       rcx,[rbp-30]
       call      qword ptr [7FF7D571E448]; Microsoft.Extensions.Caching.Memory.CacheExtensions.Set[[System.__Canon, System.Private.CoreLib]](Microsoft.Extensions.Caching.Memory.IMemoryCache, System.Object, System.__Canon, Microsoft.Extensions.Caching.Memory.MemoryCacheEntryOptions)
       nop
       add       rsp,70
       pop       rbp
       ret
; Total bytes of code 362
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
       call      00007FF834C17C30
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
       mov       rax,7FF7D52E8C30
       mov       [rbp-78],rax
       lea       rax,[M12_L03]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FF834C63470
       call      rax
M12_L03:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FF8350439A0],0
       je        short M12_L04
       call      qword ptr [7FF835031648]; CORINFO_HELP_STOP_FOR_GC
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
       call      00007FF834D4E870
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
       call      qword ptr [7FF7D57FC5D0]; System.RuntimeTypeHandle.GetGCHandle(System.Runtime.InteropServices.GCHandleType)
       mov       rdx,rax
       lea       rcx,[rbx+10]
       xor       eax,eax
       lock cmpxchg [rcx],rdx
       test      rax,rax
       je        near ptr M12_L00
       lea       rcx,[rbp-40]
       call      qword ptr [7FF7D57F5BC0]
       jmp       near ptr M12_L00
M12_L09:
       call      qword ptr [7FF7D50F6328]; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M12_L10:
       mov       [rbp+10],rbx
       mov       rcx,rbx
       call      qword ptr [7FF7D52C5728]; System.RuntimeTypeHandle.<GetModule>g__GetModuleWorker|48_0(System.RuntimeType)
       mov       r14,rax
       mov       rbx,[rbp+10]
       jmp       near ptr M12_L02
M12_L11:
       mov       rdx,rax
       call      qword ptr [7FF7D50F6328]; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
; Total bytes of code 568
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
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M14_L00
       ret
M14_L00:
       jmp       qword ptr [7FF7D50F5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-10]
       mov       rdx,rax
       test      dl,1
       jne       short M15_L00
       ret
M15_L00:
       jmp       qword ptr [7FF7D538E0A0]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.TypeExtensionsBenchmark.GetAllDeclaredMethods()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.TypeHelper+<GetAllDeclaredMethods>d__24
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       dword ptr [rsi+28],0FFFFFFFE
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rsi+2C],eax
       mov       rcx,2565FA7B598
       mov       [rsi+18],rcx
       mov       [rsp+20],rsi
       mov       rbx,[rbx+60]
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

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.TypeExtensionsBenchmark.GetAllFields()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.TypeHelper+<GetAllFields>d__25
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       dword ptr [rsi+28],0FFFFFFFE
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rsi+2C],eax
       mov       rcx,308A89EB598
       mov       [rsi+18],rcx
       mov       [rsp+20],rsi
       mov       rbx,[rbx+60]
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

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.TypeExtensionsBenchmark.GetAllMethods()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.TypeHelper+<GetAllMethods>d__27
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       dword ptr [rsi+28],0FFFFFFFE
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rsi+2C],eax
       mov       rcx,26E6638B598
       mov       [rsi+18],rcx
       mov       [rsp+20],rsi
       mov       rbx,[rbx+60]
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

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.TypeExtensionsBenchmark.GetAllProperties()
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-30],rax
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.TypeHelper+<GetAllProperties>d__28
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       dword ptr [rsi+28],0FFFFFFFE
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rsi+2C],eax
       mov       rcx,22C20D3B598
       mov       [rsi+18],rcx
       mov       [rbp-30],rsi
       mov       rbx,[rbx+60]
       mov       rdx,[rbp-30]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
       sub       rsp,28
       mov       rbx,rcx
       mov       ecx,430
       mov       rdx,7FF7D53E3FC0
       call      qword ptr [7FF7D511F228]
       mov       rsi,rax
       mov       rcx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FF7D573D818]
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       rdi,rax
       mov       ecx,448
       mov       rdx,7FF7D53E3FC0
       call      qword ptr [7FF7D511F228]
       mov       r14,rax
       mov       rcx,rbx
       mov       r15,[rbx]
       mov       rax,[r15+40]
       call      qword ptr [rax+20]
       mov       r9,rax
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8,r14
       call      qword ptr [7FF7D53AFE88]; System.String.Concat(System.String, System.String, System.String, System.String)
       mov       rcx,rax
       call      qword ptr [7FF7D573D830]
       mov       ecx,450
       mov       rdx,7FF7D53E3FC0
       call      qword ptr [7FF7D511F228]
       mov       rsi,rax
       mov       rcx,rbx
       mov       rax,[r15+48]
       call      qword ptr [rax+20]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF7D511D9C8]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       call      qword ptr [7FF7D573D830]
       call      CORINFO_HELP_RETHROW
       int       3
; Total bytes of code 296
```
```assembly
; System.String.Concat(System.String, System.String, System.String, System.String)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rdi,rcx
       mov       rbp,rdx
       mov       rbx,r8
       mov       rsi,r9
       test      rdi,rdi
       je        near ptr M01_L03
       mov       r14d,[rdi+8]
       test      r14d,r14d
       je        near ptr M01_L03
       test      rbp,rbp
       je        near ptr M01_L02
       mov       r15d,[rbp+8]
       test      r15d,r15d
       je        near ptr M01_L02
       test      rbx,rbx
       je        near ptr M01_L01
       cmp       dword ptr [rbx+8],0
       je        near ptr M01_L01
       test      rsi,rsi
       je        near ptr M01_L00
       cmp       dword ptr [rsi+8],0
       je        near ptr M01_L00
       mov       r13d,r14d
       mov       ecx,r15d
       add       rcx,r13
       mov       eax,[rbx+8]
       add       rcx,rax
       mov       eax,[rsi+8]
       add       rcx,rax
       cmp       rcx,7FFFFFFF
       jg        near ptr M01_L04
       movsxd    rcx,ecx
       call      qword ptr [7FF834B669D8]; Precode of System.String.FastAllocateString(IntPtr)
       mov       r12,rax
       cmp       [r12],r12b
       lea       rax,[r12+0C]
       mov       [rsp+20],rax
       mov       rcx,rax
       mov       r8d,r14d
       add       r8,r8
       lea       rdx,[rdi+0C]
       call      qword ptr [7FF834B688E8]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rdi,[rsp+20]
       lea       rcx,[rdi+r13*2]
       mov       r8d,r15d
       add       r8,r8
       lea       rdx,[rbp+0C]
       call      qword ptr [7FF834B688E8]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       r14d,r15d
       movsxd    rcx,r14d
       lea       rcx,[rdi+rcx*2]
       mov       r8d,[rbx+8]
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF834B688E8]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       r14d,[rbx+8]
       movsxd    rcx,r14d
       lea       rcx,[rdi+rcx*2]
       mov       r8d,[rsi+8]
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF834B688E8]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r12
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
M01_L00:
       mov       r8,rbx
       mov       rcx,rdi
       mov       rdx,rbp
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [rax]
M01_L01:
       mov       r8,rsi
       mov       rcx,rdi
       mov       rdx,rbp
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [rax]
M01_L02:
       mov       r8,rsi
       mov       rcx,rdi
       mov       rdx,rbx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [rax]
M01_L03:
       mov       r8,rsi
       mov       rcx,rbp
       mov       rdx,rbx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [rax]
M01_L04:
       call      qword ptr [7FF834B6A448]
       int       3
; Total bytes of code 436
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
       je        near ptr M02_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M02_L01
       test      rsi,rsi
       je        short M02_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M02_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M02_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FF834D89D30
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF7D5115818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF7D5115818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
M02_L00:
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
M02_L01:
       test      rsi,rsi
       je        short M02_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M02_L03
M02_L02:
       mov       rax,22C20D30008
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M02_L03:
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
M02_L04:
       call      qword ptr [7FF7D57D4990]
       int       3
; Total bytes of code 244
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.TypeExtensionsBenchmark.GetTypeMembersWithAttribute()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.TypeHelper+<GetMembersWithAttribute>d__41<System.Text.Json.Serialization.JsonPropertyNameAttribute>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       dword ptr [rsi+28],0FFFFFFFE
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rsi+2C],eax
       mov       rdx,2E1BEDDB598
       mov       [rsi+18],rdx
       mov       rdx,rsi
       mov       rcx,7FF7D57756C8
       call      qword ptr [7FF7D571D968]; System.Linq.Enumerable.<ToArray>g__EnumerableToArray|324_0[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       mov       rbx,[rbx+60]
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
       call      qword ptr [7FF7D50FFD50]
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
       je        near ptr M01_L32
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
       je        near ptr M01_L30
M01_L01:
       mov       rdi,rsi
       mov       r14,[rbp-90]
       mov       r15d,[rbp-88]
       mov       r13d,[rbp-180]
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+40]
       test      r11,r11
       je        near ptr M01_L31
M01_L02:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp-1B8],rbx
M01_L03:
       mov       rcx,rbx
       mov       r11,7FF7D5040A48
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M01_L08
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+48]
       test      r11,r11
       je        short M01_L05
M01_L04:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       r12,rax
       cmp       r13d,r15d
       jae       short M01_L06
       mov       ecx,r13d
       lea       rcx,[r14+rcx*8]
       mov       rdx,r12
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       r13d
       jmp       short M01_L03
M01_L05:
       mov       rcx,rdi
       mov       rdx,7FF7D586AB60
       call      qword ptr [7FF7D50FF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       short M01_L04
M01_L06:
       lea       rcx,[rbp-188]
       mov       rdx,rdi
       mov       r8d,10
       call      qword ptr [7FF7D5846D18]
       mov       r14,[rbp-90]
       mov       r15d,[rbp-88]
       test      r15d,r15d
       je        short M01_L07
       mov       rcx,r14
       mov       rdx,r12
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r13d,1
       jmp       near ptr M01_L03
M01_L07:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M01_L08:
       mov       rcx,rbx
       mov       r11,7FF7D5040A50
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
       mov       rcx,[rcx+50]
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
       jne       near ptr M01_L28
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
       mov       rdx,7FF7D586ABA8
       call      qword ptr [7FF7D50FF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M01_L09
M01_L14:
       mov       rdx,7FF7D5869160
       call      qword ptr [7FF7D50FF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       short M01_L10
M01_L15:
       mov       rcx,[rbx+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+58]
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
       cmp       qword ptr [rcx+8],60
       jle       near ptr M01_L24
       mov       rcx,[rcx+60]
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
       jne       near ptr M01_L33
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
       call      qword ptr [7FF7D52CF228]
       int       3
M01_L22:
       mov       rcx,rbx
       mov       rdx,7FF7D586ABE0
       call      qword ptr [7FF7D50FF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L16
M01_L23:
       mov       rdx,7FF7D586AE48
       call      qword ptr [7FF7D50FF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L17
M01_L24:
       mov       rcx,rbx
       mov       rdx,7FF7D586AD48
       call      qword ptr [7FF7D50FF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L18
M01_L25:
       mov       rdx,7FF7D58693C0
       call      qword ptr [7FF7D50FF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M01_L19
M01_L26:
       mov       rdx,[rbp-0A0]
       mov       r13d,[rbp-98]
       cmp       r13d,edi
       jg        near ptr M01_L29
       mov       r12d,r13d
       shl       r12,3
       mov       r8,r12
       mov       rcx,r14
       call      qword ptr [7FF7D50F57A0]; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       add       r14,r12
       sub       edi,r13d
       mov       r12d,edi
       mov       r13,r14
       mov       edi,[rbp-18C]
       dec       edi
       je        near ptr M01_L20
       jmp       near ptr M01_L34
M01_L27:
       mov       rdx,[rbp-90]
       cmp       ecx,r12d
       ja        short M01_L29
       mov       r8d,ecx
       shl       r8,3
       cmp       r8,4000
       ja        near ptr M01_L41
       mov       rcx,r13
       call      00007FF834D19170
       cmp       dword ptr [7FF8350439A0],0
       je        near ptr M01_L11
       jmp       near ptr M01_L40
M01_L28:
       lea       rcx,[rbp-188]
       call      qword ptr [7FF7D5846D30]
       jmp       near ptr M01_L12
M01_L29:
       call      qword ptr [7FF7D550CC18]
       int       3
M01_L30:
       mov       rdx,7FF7D586A718
       call      qword ptr [7FF7D50FF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M01_L01
M01_L31:
       mov       rcx,rdi
       mov       rdx,7FF7D586AB48
       call      qword ptr [7FF7D50FF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M01_L02
M01_L32:
       mov       ecx,11
       call      qword ptr [7FF7D50FF948]
       int       3
M01_L33:
       call      qword ptr [7FF7D5846790]
       int       3
M01_L34:
       mov       rcx,[rbx+30]
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],70
       jle       short M01_L35
       mov       rdx,[rcx+70]
       test      rdx,rdx
       je        short M01_L35
       jmp       short M01_L36
M01_L35:
       mov       rcx,rbx
       mov       rdx,7FF7D586AED8
       call      qword ptr [7FF7D50FF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M01_L36:
       lea       rcx,[rbp-1A0]
       lea       r8,[rbp-178]
       mov       r9d,1B
       call      qword ptr [7FF7D5846B50]
       cmp       edi,[rbp-198]
       ja        near ptr M01_L21
       mov       rbx,[rbp-1A0]
       xor       r14d,r14d
M01_L37:
       mov       r8,[rbx+r14*8]
       test      r8,r8
       jne       short M01_L38
       xor       edx,edx
       xor       eax,eax
       jmp       short M01_L39
M01_L38:
       lea       rdx,[r8+10]
       mov       eax,[r8+8]
M01_L39:
       cmp       eax,r12d
       jg        near ptr M01_L29
       mov       [rbp-1A4],eax
       mov       r10d,eax
       shl       r10,3
       mov       [rbp-1B0],r10
       mov       r8,r10
       mov       rcx,r13
       call      qword ptr [7FF7D50F57A0]; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbp-1B0]
       add       r13,rcx
       sub       r12d,[rbp-1A4]
       inc       r14d
       cmp       r14d,edi
       jl        short M01_L37
       jmp       near ptr M01_L20
M01_L40:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M01_L11
M01_L41:
       mov       rcx,r13
       call      qword ptr [7FF7D567E520]
       jmp       near ptr M01_L11
M01_L42:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       mov       rbx,[rbp-1B8]
       test      rbx,rbx
       je        short M01_L43
       mov       rcx,rbx
       mov       r11,7FF7D5040A50
       call      qword ptr [r11]
M01_L43:
       nop
       add       rsp,28
       ret
; Total bytes of code 1400
```

