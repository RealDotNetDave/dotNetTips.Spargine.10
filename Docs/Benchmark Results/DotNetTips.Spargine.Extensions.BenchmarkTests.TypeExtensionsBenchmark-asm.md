## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.TypeExtensionsBenchmark.GetAllDeclaredFields()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,297AD7FB598
       call      qword ptr [7FFB840AD788]; DotNetTips.Spargine.Core.TypeHelper.GetAllDeclaredFields(System.Type)
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
; Total bytes of code 66
```
```assembly
; DotNetTips.Spargine.Core.TypeHelper.GetAllDeclaredFields(System.Type)
; 		type = type.ArgumentNotNull();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var cacheKey = string.Create(null, stackalloc char[128], $"{type.FullName}.{nameof(GetAllDeclaredFields)}");
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		if (_commonCache.TryGetValue<FieldInfo[]>(cacheKey, out var cachedFields))
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			return cachedFields!;
; 			^^^^^^^^^^^^^^^^^^^^^
; 		var fields = type.GetFields(
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			BindingFlags.Instance |
; 			                       
; 			BindingFlags.Static |
; 			                     
; 			BindingFlags.Public |
; 			                     
; 			BindingFlags.NonPublic |
; 			                        
; 			BindingFlags.DeclaredOnly);
; 			                           
; 		_commonCache.AddCacheItem(cacheKey, fields, TimeSpan.FromMinutes(TimeOutMinutes));
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return fields;
; 		^^^^^^^^^^^^^^
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,108
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp+68],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp+70],ymm4
       vmovdqu   ymmword ptr [rbp+90],ymm4
       vmovdqu   ymmword ptr [rbp+0B0],ymm4
       mov       [rbp+0D0],rax
       mov       rax,0D9CAEDCD9B6A
       mov       [rbp],rax
       mov       rbx,rcx
       test      rbx,rbx
       je        near ptr M01_L70
       test      [rsp],esp
       sub       rsp,100
       lea       rcx,[rsp+30]
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymmword ptr [rcx+20],ymm0
       vmovdqu   ymmword ptr [rcx+40],ymm0
       vmovdqu   ymmword ptr [rcx+60],ymm0
       vmovdqu   ymmword ptr [rcx+80],ymm0
       vmovdqu   ymmword ptr [rcx+0A0],ymm0
       vmovdqu   ymmword ptr [rcx+0C0],ymm0
       vmovdqu   ymmword ptr [rcx+0E0],ymm0
       xor       eax,eax
       mov       [rbp+0B0],rax
       mov       [rbp+0C8],rcx
       mov       dword ptr [rbp+0D0],80
       mov       [rbp+0B8],rax
       mov       [rbp+0C0],eax
       mov       byte ptr [rbp+0C4],0
       mov       rsi,offset MT_System.RuntimeType
       cmp       [rbx],rsi
       jne       near ptr M01_L76
       cmp       qword ptr [rbx+10],0
       je        short M01_L00
       mov       rcx,[rbx+10]
       mov       rdi,[rcx]
       test      rdi,rdi
       jne       near ptr M01_L13
M01_L00:
       mov       [rbp+120],rbx
       mov       rcx,rbx
       call      qword ptr [7FFB83C556E0]; System.RuntimeType.InitializeCache()
       mov       r14,rax
       mov       rbx,[rbp+120]
M01_L01:
       mov       rdi,[r14+20]
       test      rdi,rdi
       jne       near ptr M01_L08
       mov       [rbp+40],r14
       mov       rcx,[r14+8]
       cmp       [rcx],ecx
       call      qword ptr [7FFB83C54B70]; System.Type.GetRootElementType()
       mov       rdi,rax
       mov       [rbp+38],rdi
       cmp       [rdi],rsi
       jne       near ptr M01_L14
       mov       rcx,[rdi+18]
       test      cl,2
       jne       near ptr M01_L71
       mov       ecx,[rcx]
       and       ecx,80000030
       cmp       ecx,30
       sete      al
       movzx     eax,al
M01_L02:
       test      eax,eax
       jne       short M01_L05
       cmp       [rdi],rsi
       jne       near ptr M01_L15
       mov       rcx,rdi
       call      qword ptr [7FFB83C54B70]; System.Type.GetRootElementType()
       mov       rcx,rax
       cmp       [rcx],rsi
       jne       near ptr M01_L72
M01_L03:
       test      rcx,rcx
       je        near ptr M01_L73
       call      00007FFBE36C3260
M01_L04:
       test      eax,eax
       jne       near ptr M01_L74
M01_L05:
       cmp       [rdi],rsi
       jne       near ptr M01_L16
       mov       [rbp+120],rbx
       mov       rcx,[rdi+18]
       mov       rax,7FFBE36BF0F0
       vzeroupper
       call      rax
       movzx     ebx,al
       cmp       dword ptr [7FFBE39D3A10],0
       jne       near ptr M01_L75
M01_L06:
       cmp       ebx,1B
       mov       rbx,[rbp+120]
       je        near ptr M01_L74
M01_L07:
       mov       r14,[rbp+40]
       lea       rdx,[r14+20]
       mov       rcx,r14
       mov       r8d,3
       call      qword ptr [7FFB83C5CC60]; System.RuntimeType+RuntimeTypeCache.ConstructName(System.String ByRef, System.TypeNameFormatFlags)
       mov       rdi,rax
M01_L08:
       cmp       byte ptr [rbp+0C4],0
       jne       near ptr M01_L17
       test      rdi,rdi
       je        near ptr M01_L17
       mov       r8d,[rbp+0C0]
       cmp       r8d,[rbp+0D0]
       ja        near ptr M01_L12
       mov       rdx,[rbp+0C8]
       mov       ecx,r8d
       lea       rcx,[rdx+rcx*2]
       mov       edx,[rbp+0D0]
       sub       edx,r8d
       cmp       [rdi+8],edx
       ja        near ptr M01_L17
       mov       r8d,[rdi+8]
       add       r8,r8
       lea       rdx,[rdi+0C]
       call      qword ptr [7FFB83A85818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbp+0C0]
       add       ecx,[rdi+8]
       mov       [rbp+0C0],ecx
M01_L09:
       mov       ecx,[rbp+0C0]
       cmp       ecx,[rbp+0D0]
       ja        near ptr M01_L12
       mov       rdx,[rbp+0C8]
       mov       eax,ecx
       lea       rdx,[rdx+rax*2]
       mov       eax,[rbp+0D0]
       sub       eax,ecx
       je        near ptr M01_L18
       mov       word ptr [rdx],2E
       mov       ecx,[rbp+0C0]
       inc       ecx
       mov       [rbp+0C0],ecx
M01_L10:
       cmp       byte ptr [rbp+0C4],0
       jne       near ptr M01_L19
       mov       ecx,[rbp+0C0]
       cmp       ecx,[rbp+0D0]
       ja        short M01_L12
       mov       rdx,[rbp+0C8]
       mov       eax,ecx
       lea       rdx,[rdx+rax*2]
       mov       eax,[rbp+0D0]
       sub       eax,ecx
       cmp       eax,14
       jb        near ptr M01_L19
       vmovups   ymm0,[7FFB841D7FA0]
       vmovups   [rdx],ymm0
       mov       rcx,730064006C0065
       mov       [rdx+20],rcx
       mov       ecx,[rbp+0C0]
       add       ecx,14
       mov       [rbp+0C0],ecx
M01_L11:
       mov       ecx,[rbp+0C0]
       cmp       ecx,[rbp+0D0]
       jbe       near ptr M01_L20
M01_L12:
       call      qword ptr [7FFB83C5F228]
       int       3
M01_L13:
       mov       r14,rdi
       jmp       near ptr M01_L01
M01_L14:
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+60]
       call      qword ptr [rax+10]
       jmp       near ptr M01_L02
M01_L15:
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+0B0]
       call      qword ptr [rax]
       jmp       near ptr M01_L04
M01_L16:
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+60]
       call      qword ptr [rax+30]
       test      eax,eax
       jne       near ptr M01_L74
       jmp       near ptr M01_L07
M01_L17:
       lea       rcx,[rbp+0B0]
       mov       rdx,rdi
       call      qword ptr [7FFB8417C840]
       jmp       near ptr M01_L09
M01_L18:
       lea       rcx,[rbp+0B0]
       mov       rdx,297AD7F0C80
       call      qword ptr [7FFB840A70A8]
       jmp       near ptr M01_L10
M01_L19:
       lea       rcx,[rbp+0B0]
       mov       rdx,297AD800708
       call      qword ptr [7FFB8417C840]
       jmp       near ptr M01_L11
M01_L20:
       mov       rax,[rbp+0C8]
       mov       [rbp+68],rax
       mov       [rbp+70],ecx
       lea       rcx,[rbp+68]
       call      System.String.Ctor(System.ReadOnlySpan`1<Char>)
       mov       rsi,rax
       mov       rdi,[rbp+0B8]
       xor       ecx,ecx
       mov       [rbp+0B8],rcx
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp+0C8],xmm0
       mov       [rbp+0C0],ecx
       test      rdi,rdi
       je        near ptr M01_L24
       mov       rcx,25718800B30
       mov       r14,[rcx]
       mov       r15d,[rdi+8]
       lea       ecx,[r15-1]
       or        ecx,0F
       xor       r13d,r13d
       lzcnt     r13d,ecx
       xor       r13d,1F
       add       r13d,0FFFFFFFD
       mov       rcx,gs:[58]
       mov       rcx,[rcx+38]
       cmp       dword ptr [rcx+238],4
       jle       near ptr M01_L77
       mov       rcx,[rcx+240]
       mov       rax,[rcx+20]
       test      rax,rax
       je        near ptr M01_L77
M01_L21:
       mov       rax,[rax+10]
       test      rax,rax
       je        near ptr M01_L78
M01_L22:
       xor       r12d,r12d
       mov       dword ptr [rbp+0AC],1
       mov       ecx,[rax+8]
       cmp       ecx,r13d
       jbe       short M01_L23
       mov       r12d,1
       mov       ecx,10
       shlx      ecx,ecx,r13d
       cmp       r15d,ecx
       jne       near ptr M01_L79
       mov       ecx,r13d
       shl       rcx,4
       lea       rax,[rax+rcx+10]
       mov       [rbp+28],rax
       mov       r10,[rax]
       mov       [rbp+20],r10
       mov       rcx,rax
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       rdx,[rbp+28]
       mov       [rdx+8],ecx
       cmp       qword ptr [rbp+20],0
       jne       near ptr M01_L34
M01_L23:
       mov       rcx,25718800B40
       mov       rax,[rcx]
       mov       [rbp+30],rax
       cmp       byte ptr [rax+9D],0
       jne       near ptr M01_L89
M01_L24:
       mov       rcx,2572E800168
       mov       rdi,[rcx]
       test      rsi,rsi
       je        near ptr M01_L92
       mov       ecx,[rsi+8]
       cmp       dword ptr [rsi+8],0
       je        near ptr M01_L92
       movzx     ecx,word ptr [rsi+0C]
       cmp       ecx,100
       jge       near ptr M01_L94
       cmp       ecx,100
       jae       near ptr M01_L138
       mov       rax,7FFBE2876090
       test      byte ptr [rax+rcx],80
       jne       near ptr M01_L96
M01_L25:
       mov       ecx,[rsi+8]
       dec       ecx
       cmp       ecx,[rsi+8]
       jae       near ptr M01_L138
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jge       near ptr M01_L95
       cmp       ecx,100
       jae       near ptr M01_L138
       mov       rax,7FFBE2876090
       test      byte ptr [rax+rcx],80
       jne       near ptr M01_L96
M01_L26:
       mov       r14,rsi
M01_L27:
       mov       rdi,[rdi+10]
       test      r14,r14
       jne       near ptr M01_L46
       xor       r15d,r15d
       xor       r13d,r13d
M01_L28:
       cmp       byte ptr [rdi+44],0
       jne       near ptr M01_L97
       mov       r14,[rdi+28]
       mov       rcx,[r14+20]
       mov       r12,[rcx+8]
       mov       rax,[r12+8]
       mov       [rbp+8],rax
       mov       rdx,[rax]
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer+OrdinalComparer
       mov       [rbp+50],rdx
       cmp       rdx,rcx
       jne       near ptr M01_L98
       mov       [rbp+68],r15
       mov       [rbp+70],r13d
       lea       rcx,[rbp+68]
       call      qword ptr [7FFB8400C0F0]; System.String.GetNonRandomizedHashCode(System.ReadOnlySpan`1<Char>)
M01_L29:
       mov       [rbp+8C],eax
       mov       rdx,[r12+10]
       mov       r8d,eax
       imul      r8,[r12+28]
       shr       r8,20
       inc       r8
       mov       ecx,[rdx+8]
       mov       r11d,ecx
       imul      r8,r11
       shr       r8,20
       cmp       r8d,ecx
       jae       near ptr M01_L138
       mov       r8d,r8d
       mov       r12,[rdx+r8*8+10]
       mov       r10,[rbp+8]
       test      r10,r10
       je        near ptr M01_L111
       mov       rdx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer+OrdinalComparer
       cmp       [rbp+50],rdx
       jne       near ptr M01_L111
M01_L30:
       test      r12,r12
       je        near ptr M01_L131
       cmp       eax,[r12+20]
       jne       near ptr M01_L110
       mov       r8,[r12+8]
       test      r13d,r13d
       je        near ptr M01_L99
M01_L31:
       test      r8,r8
       jne       near ptr M01_L47
       xor       edx,edx
       xor       ecx,ecx
M01_L32:
       cmp       r13d,ecx
       jne       near ptr M01_L53
       mov       r11,r15
       mov       r9,rdx
       mov       ecx,ecx
       add       rcx,rcx
       cmp       rcx,8
       jb        near ptr M01_L100
       cmp       r11,r9
       je        near ptr M01_L49
       cmp       rcx,20
       jb        near ptr M01_L105
       xor       edx,edx
       add       rcx,0FFFFFFFFFFFFFFE0
       je        near ptr M01_L48
       vmovups   ymm0,[r15]
       vpcmpeqb  ymm0,ymm0,[r9]
       vpmovmskb r8d,ymm0
       cmp       r8d,0FFFFFFFF
       jne       near ptr M01_L109
M01_L33:
       add       rdx,20
       cmp       rcx,rdx
       jbe       near ptr M01_L48
       vmovups   ymm0,[r15+rdx]
       vpcmpeqb  ymm0,ymm0,[r9+rdx]
       vpmovmskb r10d,ymm0
       cmp       r10d,0FFFFFFFF
       jne       near ptr M01_L109
       jmp       short M01_L33
M01_L34:
       mov       rcx,[r14+10]
       cmp       r13d,[rcx+8]
       jae       near ptr M01_L138
       mov       edx,r13d
       mov       r8,[rcx+rdx*8+10]
       test      r8,r8
       je        near ptr M01_L80
M01_L35:
       mov       rdx,[r8+8]
       mov       [rbp+18],rdx
       test      byte ptr [7FFB842550C0],1
       je        near ptr M01_L81
M01_L36:
       cmp       byte ptr [7FFB839CB19C],0
       je        near ptr M01_L82
       call      qword ptr [7FFB8417C978]
       mov       edx,eax
M01_L37:
       test      byte ptr [7FFB84254F50],1
       je        near ptr M01_L84
M01_L38:
       mov       eax,edx
       xor       edx,edx
       div       dword ptr [7FFB839CB190]
       mov       eax,edx
       mov       rdx,[rbp+18]
       mov       r8d,[rdx+8]
       mov       [rbp+4C],r8d
       test      r8d,r8d
       jle       near ptr M01_L88
       mov       [rbp+48],r8d
M01_L39:
       cmp       eax,r8d
       jae       near ptr M01_L138
       mov       [rbp+0A0],eax
       mov       ecx,eax
       mov       r9,[rdx+rcx*8+10]
       mov       [rbp+10],r9
       cmp       [r9],r9b
       xor       r11d,r11d
       mov       [rbp+94],r11d
       mov       rcx,r9
       call      00007FFBE3722D60
       test      eax,eax
       jne       short M01_L40
       mov       rcx,[rbp+10]
       call      qword ptr [7FFB83D1C030]; System.Threading.Monitor.Enter_Slowpath(System.Object)
M01_L40:
       mov       rax,[rbp+10]
       mov       rcx,[rax+8]
       mov       r8d,[rax+10]
       mov       [rbp+90],r8d
       cmp       [rcx+8],r8d
       jbe       short M01_L42
       test      r8d,r8d
       je        short M01_L45
M01_L41:
       mov       edx,r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,[rbp+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rbp+90]
       inc       ecx
       mov       rax,[rbp+10]
       mov       [rax+10],ecx
       mov       dword ptr [rbp+94],1
M01_L42:
       mov       rcx,rax
       call      00007FFBE3722C80
       test      eax,eax
       jne       near ptr M01_L85
M01_L43:
       cmp       dword ptr [rbp+94],0
       je        near ptr M01_L86
       mov       r8d,1
M01_L44:
       mov       [rbp+0AC],r8d
       jmp       near ptr M01_L23
M01_L45:
       xor       edx,edx
       mov       [rax+14],edx
       jmp       short M01_L41
M01_L46:
       lea       r15,[r14+0C]
       mov       r13d,[r14+8]
       jmp       near ptr M01_L28
M01_L47:
       lea       rdx,[r8+0C]
       mov       ecx,[r8+8]
       jmp       near ptr M01_L32
M01_L48:
       vmovups   ymm0,[r15+rcx]
       vpcmpeqb  ymm0,ymm0,[r9+rcx]
       vpmovmskb r9d,ymm0
       cmp       r9d,0FFFFFFFF
       jne       near ptr M01_L109
M01_L49:
       mov       ecx,1
M01_L50:
       test      ecx,ecx
       je        near ptr M01_L110
M01_L51:
       mov       r15,[r12+10]
M01_L52:
       mov       rdx,[rdi+10]
       mov       rcx,[rdx+8]
       test      rcx,rcx
       jne       short M01_L55
       call      qword ptr [7FFB83FACA98]; System.DateTime.get_UtcNow()
       mov       r13,rax
       jmp       short M01_L56
M01_L53:
       xor       ecx,ecx
       jmp       short M01_L50
M01_L54:
       add       rdx,20
       cmp       rcx,rdx
       jbe       near ptr M01_L121
       vmovups   ymm0,[r15+rdx]
       vpcmpeqb  ymm0,ymm0,[r9+rdx]
       vpmovmskb r8d,ymm0
       cmp       r8d,0FFFFFFFF
       jne       near ptr M01_L123
       jmp       short M01_L54
M01_L55:
       lea       rdx,[rbp+78]
       mov       r11,7FFB839D0AE8
       call      qword ptr [r11]
       mov       r13,4000000000000000
       or        r13,[rbp+80]
M01_L56:
       test      r15,r15
       je        near ptr M01_L66
       cmp       byte ptr [r15+43],0
       jne       near ptr M01_L65
       cmp       qword ptr [r15+38],0
       jge       short M01_L57
       cmp       qword ptr [r15+50],0
       je        short M01_L58
M01_L57:
       mov       rcx,r15
       mov       rdx,r13
       call      qword ptr [7FFB840AE6D0]; Microsoft.Extensions.Caching.Memory.CacheEntry.<CheckForExpiredTime>g__FullCheck|64_0(System.DateTime)
       test      eax,eax
       jne       near ptr M01_L65
M01_L58:
       cmp       qword ptr [r15+10],0
       je        short M01_L59
       mov       rcx,[r15+10]
       mov       rdx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFB8417CC60]
       test      eax,eax
       jne       near ptr M01_L65
M01_L59:
       mov       [r15+58],r13
       mov       r14,[r15+20]
       cmp       byte ptr [rdi+45],0
       jne       near ptr M01_L132
M01_L60:
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+28]
       mov       rdx,[rdi+48]
       mov       rax,3FFFFFFFFFFFFFFF
       and       rax,r13
       mov       r8,3FFFFFFFFFFFFFFF
       and       rdx,r8
       sub       rax,rdx
       cmp       rcx,rax
       jge       short M01_L61
       mov       rcx,rdi
       mov       rdx,r13
       call      qword ptr [7FFB8417CC90]
M01_L61:
       cmp       qword ptr [rdi+20],0
       jne       near ptr M01_L133
M01_L62:
       test      r14,r14
       je        near ptr M01_L134
       mov       rdx,r14
       mov       rcx,offset MT_System.Reflection.FieldInfo[]
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
       test      rax,rax
       je        near ptr M01_L68
       mov       rax,r14
       test      rax,rax
       je        short M01_L63
       mov       rcx,offset MT_System.Reflection.FieldInfo[]
       cmp       [rax],rcx
       je        short M01_L63
       mov       rdx,r14
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
M01_L63:
       mov       r8,0D9CAEDCD9B6A
       cmp       [rbp],r8
       je        short M01_L64
       call      CORINFO_HELP_FAIL_FAST
M01_L64:
       nop
       vzeroupper
       lea       rsp,[rbp+0D8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L65:
       cmp       byte ptr [r15+45],2
       je        near ptr M01_L59
       mov       r8,[rdi+10]
       mov       rcx,r14
       mov       rdx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFB8417CCC0]
M01_L66:
       mov       rdx,[rdi+10]
       mov       r14,[rdx+28]
       mov       rdx,[rdi+48]
       mov       rcx,r13
       call      qword ptr [7FFB840AE448]; System.DateTime.op_Subtraction(System.DateTime, System.DateTime)
       cmp       r14,rax
       jge       short M01_L67
       mov       rcx,rdi
       mov       rdx,r13
       call      qword ptr [7FFB8417CC90]
M01_L67:
       mov       rcx,[rdi+20]
       test      rcx,rcx
       je        short M01_L68
       cmp       [rcx],ecx
       call      qword ptr [7FFB8417CCA8]
       inc       qword ptr [rax+18]
M01_L68:
       mov       rcx,rbx
       mov       edx,3E
       mov       rax,[rbx]
       mov       rax,[rax+80]
       call      qword ptr [rax+28]
       mov       rbx,rax
       mov       ecx,5
       call      qword ptr [7FFB840AD818]; System.TimeSpan.FromMinutes(Int64)
       mov       rdi,rax
       mov       rcx,2572E800168
       mov       r14,[rcx]
       cmp       dword ptr [rsi+8],0
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M01_L135
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFB83E94408]; System.String.Trim()
       mov       rsi,rax
       test      rbx,rbx
       je        near ptr M01_L137
       mov       rcx,offset MT_Microsoft.Extensions.Caching.Memory.MemoryCacheEntryOptions
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       r14,[r14+10]
       mov       dword ptr [r15+18],1
       mov       byte ptr [rbp+58],1
       mov       [rbp+60],rdi
       lea       rdx,[rbp+58]
       mov       rcx,r15
       call      qword ptr [7FFB840AE580]; Microsoft.Extensions.Caching.Memory.MemoryCacheEntryOptions.set_AbsoluteExpirationRelativeToNow(System.Nullable`1<System.TimeSpan>)
       mov       [rsp+20],r15
       mov       rdx,r14
       mov       r8,rsi
       mov       r9,rbx
       mov       rcx,7FFB8414AB78
       call      qword ptr [7FFB840AE4D8]; Microsoft.Extensions.Caching.Memory.CacheExtensions.Set[[System.__Canon, System.Private.CoreLib]](Microsoft.Extensions.Caching.Memory.IMemoryCache, System.Object, System.__Canon, Microsoft.Extensions.Caching.Memory.MemoryCacheEntryOptions)
       mov       rax,rbx
       mov       r8,0D9CAEDCD9B6A
       cmp       [rbp],r8
       je        short M01_L69
       call      CORINFO_HELP_FAIL_FAST
M01_L69:
       nop
       vzeroupper
       lea       rsp,[rbp+0D8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L70:
       call      qword ptr [7FFB8400F0C0]
       mov       ecx,22D9
       mov       rdx,7FFB83D55370
       call      qword ptr [7FFB83A8F228]
       mov       rbx,rax
       mov       ecx,1BEB
       mov       rdx,7FFB83D55370
       call      qword ptr [7FFB83A8F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB83A8D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,111F
       mov       rdx,7FFB83D55370
       call      qword ptr [7FFB83A8F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB83A8D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB8417D968]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB8400E958]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M01_L71:
       xor       eax,eax
       jmp       near ptr M01_L02
M01_L72:
       mov       rax,[rcx]
       mov       rax,[rax+98]
       call      qword ptr [rax+8]
       mov       rcx,rax
       jmp       near ptr M01_L03
M01_L73:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFB8400E940]
       mov       r8,rax
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FFB8400E958]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M01_L74:
       xor       edi,edi
       jmp       near ptr M01_L08
M01_L75:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M01_L06
M01_L76:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+50]
       call      qword ptr [rax+20]
       mov       rdi,rax
       jmp       near ptr M01_L08
M01_L77:
       mov       ecx,4
       call      qword ptr [7FFB8417C528]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M01_L21
M01_L78:
       mov       rcx,r14
       call      qword ptr [7FFB83D1CF00]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
       jmp       near ptr M01_L22
M01_L79:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       call      qword ptr [7FFB8417C948]
       mov       rdi,rax
       mov       ecx,29B
       mov       rdx,7FFB839C4000
       call      qword ptr [7FFB83A8F228]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,r15
       call      qword ptr [7FFB83E06160]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
       int       3
M01_L80:
       mov       rcx,r14
       mov       edx,r13d
       call      qword ptr [7FFB8417C960]
       mov       r8,rax
       jmp       near ptr M01_L35
M01_L81:
       mov       rcx,offset MT_System.Threading.ProcessorIdCache
       call      qword ptr [7FFB83A85740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M01_L36
M01_L82:
       mov       ecx,9
       call      qword ptr [7FFB8417C990]
       mov       eax,[rax+10]
       mov       [rbp+98],eax
       mov       ecx,9
       call      qword ptr [7FFB8417C990]
       mov       edx,[rbp+98]
       lea       ecx,[rdx-1]
       mov       [rax+10],ecx
       movzx     eax,dx
       test      eax,eax
       jne       short M01_L83
       call      qword ptr [7FFB8417C9A8]
       mov       edx,eax
       jmp       near ptr M01_L37
M01_L83:
       sar       edx,10
       mov       [rbp+9C],edx
       mov       edx,[rbp+9C]
       jmp       near ptr M01_L37
M01_L84:
       mov       [rbp+9C],edx
       mov       rcx,offset MT_System.Buffers.SharedArrayPoolStatics
       call      qword ptr [7FFB83A85740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       edx,[rbp+9C]
       jmp       near ptr M01_L38
M01_L85:
       mov       ecx,eax
       mov       rdx,[rbp+10]
       call      qword ptr [7FFB83D1CEE8]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
       jmp       near ptr M01_L43
M01_L86:
       mov       eax,[rbp+0A0]
       inc       eax
       mov       ecx,eax
       mov       r8d,[rbp+4C]
       cmp       r8d,ecx
       jne       short M01_L87
       xor       ecx,ecx
M01_L87:
       mov       r10d,[rbp+48]
       dec       r10d
       mov       [rbp+48],r10d
       mov       eax,ecx
       mov       rdx,[rbp+18]
       jne       near ptr M01_L39
M01_L88:
       xor       r8d,r8d
       jmp       near ptr M01_L44
M01_L89:
       test      r15d,r15d
       je        near ptr M01_L24
       mov       rcx,rdi
       call      qword ptr [7FFB83E9F540]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rbp+0A8],eax
       mov       [rbp+0A4],r15d
       mov       rcx,r14
       call      qword ptr [7FFB83E9F540]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,[rbp+30]
       mov       r8d,[rbp+0A8]
       mov       r9d,[rbp+0A4]
       mov       edx,3
       call      qword ptr [7FFB8417C9C0]
       test      [rbp+0AC],r12d
       jne       near ptr M01_L24
       mov       rcx,rdi
       call      qword ptr [7FFB83E9F540]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       edi,eax
       mov       rcx,r14
       call      qword ptr [7FFB83E9F540]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       test      r12d,r12d
       jne       short M01_L90
       mov       ecx,0FFFFFFFF
       mov       edx,1
       jmp       short M01_L91
M01_L90:
       mov       ecx,r13d
       xor       edx,edx
M01_L91:
       mov       [rsp+20],ecx
       mov       [rsp+28],edx
       mov       rcx,[rbp+30]
       mov       edx,edi
       mov       r8d,r15d
       call      qword ptr [7FFB8417C9D8]
       jmp       near ptr M01_L24
M01_L92:
       call      qword ptr [7FFB83E943C0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L93
       call      qword ptr [7FFB8417D968]
       mov       rbx,rax
M01_L93:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,297AD7F9C08
       call      qword ptr [7FFB8400E958]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M01_L94:
       call      qword ptr [7FFB841762E0]
       test      eax,eax
       jne       short M01_L96
       jmp       near ptr M01_L25
M01_L95:
       call      qword ptr [7FFB841762E0]
       test      eax,eax
       je        near ptr M01_L26
M01_L96:
       mov       rcx,rsi
       mov       edx,3
       call      qword ptr [7FFB8417C9F0]
       mov       r14,rax
       jmp       near ptr M01_L27
M01_L97:
       call      qword ptr [7FFB8417CBA0]
       int       3
M01_L98:
       mov       rax,[rbp+8]
       mov       [rbp+68],r15
       mov       [rbp+70],r13d
       lea       rdx,[rbp+68]
       mov       rcx,rax
       mov       r11,7FFB839D0AD8
       call      qword ptr [r11]
       jmp       near ptr M01_L29
M01_L99:
       test      r8,r8
       je        near ptr M01_L110
       jmp       near ptr M01_L31
M01_L100:
       cmp       rcx,4
       jae       short M01_L103
       xor       r11d,r11d
       mov       r10,rcx
       and       r10,2
       je        short M01_L101
       movzx     r11d,word ptr [r15]
       movzx     r9d,word ptr [rdx]
       sub       r11d,r9d
M01_L101:
       test      cl,1
       je        short M01_L102
       movzx     ecx,byte ptr [r15+r10]
       movzx     edx,byte ptr [rdx+r10]
       sub       ecx,edx
       or        r11d,ecx
M01_L102:
       test      r11d,r11d
       sete      cl
       movzx     ecx,cl
       jmp       short M01_L104
M01_L103:
       lea       r9,[rcx-4]
       mov       ecx,[r15]
       sub       ecx,[rdx]
       mov       r8d,[r15+r9]
       sub       r8d,[rdx+r9]
       or        r8d,ecx
       sete      cl
       movzx     ecx,cl
M01_L104:
       jmp       near ptr M01_L50
M01_L105:
       cmp       rcx,10
       jb        short M01_L108
       xor       r8d,r8d
       lea       r10,[rcx-10]
       test      r10,r10
       je        short M01_L107
M01_L106:
       vmovups   xmm0,[r15+r8]
       vpcmpeqb  xmm0,xmm0,[r9+r8]
       vpmovmskb ecx,xmm0
       cmp       ecx,0FFFF
       jne       short M01_L109
       add       r8,10
       cmp       r10,r8
       ja        short M01_L106
M01_L107:
       vmovups   xmm0,[r15+r10]
       vpcmpeqb  xmm0,xmm0,[r9+r10]
       vpmovmskb edx,xmm0
       cmp       edx,0FFFF
       jne       short M01_L109
       jmp       near ptr M01_L49
M01_L108:
       lea       r10,[rcx-8]
       mov       rcx,[r15]
       sub       rcx,[rdx]
       mov       r11,[r15+r10]
       sub       r11,[rdx+r10]
       or        rcx,r11
       sete      cl
       movzx     ecx,cl
       jmp       short M01_L104
M01_L109:
       xor       ecx,ecx
       jmp       near ptr M01_L50
M01_L110:
       mov       r12,[r12+18]
       jmp       near ptr M01_L30
M01_L111:
       test      r12,r12
       je        near ptr M01_L131
       cmp       eax,[r12+20]
       jne       near ptr M01_L129
       mov       r8,[r12+8]
       mov       rdx,[r10]
       mov       r11,rdx
       mov       r9,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer+OrdinalComparer
       cmp       r11,r9
       je        short M01_L112
       mov       [rbp+68],r15
       mov       [rbp+70],r13d
       lea       rdx,[rbp+68]
       mov       rcx,r10
       mov       r11,7FFB839D0AE0
       call      qword ptr [r11]
       mov       ecx,eax
       mov       r10,[rbp+8]
       jmp       near ptr M01_L130
M01_L112:
       test      r13d,r13d
       jne       short M01_L113
       test      r8,r8
       je        near ptr M01_L129
M01_L113:
       test      r8,r8
       je        short M01_L114
       lea       rdx,[r8+0C]
       mov       ecx,[r8+8]
       jmp       short M01_L115
M01_L114:
       xor       edx,edx
       xor       ecx,ecx
M01_L115:
       cmp       r13d,ecx
       je        short M01_L116
       xor       ecx,ecx
       jmp       near ptr M01_L128
M01_L116:
       mov       r11,r15
       mov       r9,rdx
       mov       ecx,ecx
       add       rcx,rcx
       cmp       rcx,8
       jb        near ptr M01_L124
       cmp       r11,r9
       je        near ptr M01_L122
       cmp       rcx,20
       jae       short M01_L120
       cmp       rcx,10
       jae       short M01_L117
       add       rcx,0FFFFFFFFFFFFFFF8
       mov       r8,[r15]
       sub       r8,[rdx]
       mov       r11,[r15+rcx]
       sub       r11,[rdx+rcx]
       or        r8,r11
       sete      cl
       movzx     ecx,cl
       jmp       near ptr M01_L128
M01_L117:
       xor       r8d,r8d
       add       rcx,0FFFFFFFFFFFFFFF0
       je        short M01_L119
M01_L118:
       vmovups   xmm0,[r15+r8]
       vpcmpeqb  xmm0,xmm0,[r9+r8]
       vpmovmskb edx,xmm0
       cmp       edx,0FFFF
       jne       short M01_L123
       add       r8,10
       cmp       rcx,r8
       ja        short M01_L118
M01_L119:
       vmovups   xmm0,[r15+rcx]
       vpcmpeqb  xmm0,xmm0,[r9+rcx]
       vpmovmskb edx,xmm0
       cmp       edx,0FFFF
       jne       short M01_L123
       jmp       short M01_L122
M01_L120:
       xor       edx,edx
       add       rcx,0FFFFFFFFFFFFFFE0
       je        short M01_L121
       vmovups   ymm0,[r15]
       vpcmpeqb  ymm0,ymm0,[r9]
       vpmovmskb r8d,ymm0
       cmp       r8d,0FFFFFFFF
       je        near ptr M01_L54
       jmp       short M01_L123
M01_L121:
       vmovups   ymm0,[r15+rcx]
       vpcmpeqb  ymm0,ymm0,[r9+rcx]
       vpmovmskb r9d,ymm0
       cmp       r9d,0FFFFFFFF
       jne       short M01_L123
M01_L122:
       mov       ecx,1
       jmp       short M01_L128
M01_L123:
       xor       ecx,ecx
       jmp       short M01_L128
M01_L124:
       cmp       rcx,4
       jb        short M01_L125
       lea       r9,[rcx-4]
       mov       r8d,[r15]
       sub       r8d,[rdx]
       mov       ecx,[r15+r9]
       sub       ecx,[rdx+r9]
       or        r8d,ecx
       sete      cl
       movzx     ecx,cl
       jmp       short M01_L128
M01_L125:
       xor       r11d,r11d
       mov       r8,rcx
       and       r8,2
       je        short M01_L126
       movzx     r11d,word ptr [r15]
       movzx     r9d,word ptr [rdx]
       sub       r11d,r9d
M01_L126:
       test      cl,1
       je        short M01_L127
       movzx     ecx,byte ptr [r15+r8]
       movzx     edx,byte ptr [rdx+r8]
       sub       ecx,edx
       or        ecx,r11d
       mov       r11d,ecx
M01_L127:
       test      r11d,r11d
       sete      cl
       movzx     ecx,cl
M01_L128:
       jmp       short M01_L130
M01_L129:
       mov       r12,[r12+18]
       mov       eax,[rbp+8C]
       jmp       near ptr M01_L111
M01_L130:
       test      ecx,ecx
       je        short M01_L129
       jmp       near ptr M01_L51
M01_L131:
       xor       r15d,r15d
       jmp       near ptr M01_L52
M01_L132:
       mov       rcx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFB8417CC78]
       jmp       near ptr M01_L60
M01_L133:
       mov       rcx,[rdi+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFB8417CCA8]
       inc       qword ptr [rax+10]
       jmp       near ptr M01_L62
M01_L134:
       xor       eax,eax
       jmp       near ptr M01_L63
M01_L135:
       call      qword ptr [7FFB83E943C0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L136
       call      qword ptr [7FFB8417D968]
       mov       rbx,rax
M01_L136:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,297AD7F9C08
       call      qword ptr [7FFB8400E958]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M01_L137:
       call      qword ptr [7FFB8400F0C0]
       mov       ecx,2141
       mov       rdx,7FFB83D55370
       call      qword ptr [7FFB83A8F228]
       mov       rbx,rax
       mov       ecx,1BEB
       mov       rdx,7FFB83D55370
       call      qword ptr [7FFB83A8F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB83A8D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,111F
       mov       rdx,7FFB83D55370
       call      qword ptr [7FFB83A8F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB83A8D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB8417D968]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB8400E958]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M01_L138:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 4702
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.TypeExtensionsBenchmark.GetAllDeclaredMethods()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.TypeHelper+<GetAllDeclaredMethods>d__23
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       dword ptr [rsi+28],0FFFFFFFE
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rsi+2C],eax
       mov       rcx,2A1127DB598
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

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.TypeExtensionsBenchmark.GetAllFields()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.TypeHelper+<GetAllFields>d__24
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       dword ptr [rsi+28],0FFFFFFFE
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rsi+2C],eax
       mov       rcx,262E18BB598
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

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.TypeExtensionsBenchmark.GetAllMethods()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.TypeHelper+<GetAllMethods>d__26
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       dword ptr [rsi+28],0FFFFFFFE
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rsi+2C],eax
       mov       rcx,30F8B90B598
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

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rcx,offset MT_DotNetTips.Spargine.Core.TypeHelper+<GetAllProperties>d__27
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       dword ptr [rsi+28],0FFFFFFFE
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rsi+2C],eax
       mov       rcx,2ABBBC2B598
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
       mov       rdx,7FFB83D33508
       call      qword ptr [7FFB83A6F228]
       mov       rsi,rax
       mov       rcx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FFB8408D6F8]
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       rdi,rax
       mov       ecx,448
       mov       rdx,7FFB83D33508
       call      qword ptr [7FFB83A6F228]
       mov       r14,rax
       mov       rcx,rbx
       mov       r15,[rbx]
       mov       rax,[r15+40]
       call      qword ptr [rax+20]
       mov       r9,rax
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8,r14
       call      qword ptr [7FFB83CFFE28]; System.String.Concat(System.String, System.String, System.String, System.String)
       mov       rcx,rax
       call      qword ptr [7FFB8408D710]
       mov       ecx,450
       mov       rdx,7FFB83D33508
       call      qword ptr [7FFB83A6F228]
       mov       rsi,rax
       mov       rcx,rbx
       mov       rax,[r15+48]
       call      qword ptr [rax+20]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFB83A6D9C8]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       call      qword ptr [7FFB8408D710]
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
       call      qword ptr [7FFBE34F69D8]; Precode of System.String.FastAllocateString(IntPtr)
       mov       r12,rax
       cmp       [r12],r12b
       lea       rax,[r12+0C]
       mov       [rsp+20],rax
       mov       rcx,rax
       mov       r8d,r14d
       add       r8,r8
       lea       rdx,[rdi+0C]
       call      qword ptr [7FFBE34F88E8]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rdi,[rsp+20]
       lea       rcx,[rdi+r13*2]
       mov       r8d,r15d
       add       r8,r8
       lea       rdx,[rbp+0C]
       call      qword ptr [7FFBE34F88E8]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       r14d,r15d
       movsxd    rcx,r14d
       lea       rcx,[rdi+rcx*2]
       mov       r8d,[rbx+8]
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFBE34F88E8]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       r14d,[rbx+8]
       movsxd    rcx,r14d
       lea       rcx,[rdi+rcx*2]
       mov       r8d,[rsi+8]
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFBE34F88E8]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFBE34FA448]
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
       call      00007FFBE3719F20
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFB83A65818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFB83A65818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,2ABBBC20008
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
       call      qword ptr [7FFB841147E0]
       int       3
; Total bytes of code 244
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.TypeExtensionsBenchmark.GetTypeMembersWithAttribute()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.TypeHelper+<GetMembersWithAttribute>d__40<System.Text.Json.Serialization.JsonPropertyNameAttribute>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       dword ptr [rsi+28],0FFFFFFFE
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rsi+2C],eax
       mov       rdx,214EF3BB598
       mov       [rsi+18],rdx
       mov       rdx,rsi
       mov       rcx,7FFB84115588
       call      qword ptr [7FFB840BD728]; System.Linq.Enumerable.<ToArray>g__EnumerableToArray|324_0[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FFB83A9FD50]
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
       mov       r11,7FFB839E0A60
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
       mov       rdx,7FFB8420ADA8
       call      qword ptr [7FFB83A9F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       short M01_L04
M01_L06:
       lea       rcx,[rbp-188]
       mov       rdx,rdi
       mov       r8d,10
       call      qword ptr [7FFB841E6B38]
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
       mov       r11,7FFB839E0A68
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
       mov       rdx,7FFB8420ADF0
       call      qword ptr [7FFB83A9F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M01_L09
M01_L14:
       mov       rdx,7FFB842093A8
       call      qword ptr [7FFB83A9F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       call      qword ptr [7FFB83C6F228]
       int       3
M01_L22:
       mov       rcx,rbx
       mov       rdx,7FFB8420AE28
       call      qword ptr [7FFB83A9F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L16
M01_L23:
       mov       rdx,7FFB8420B090
       call      qword ptr [7FFB83A9F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L17
M01_L24:
       mov       rcx,rbx
       mov       rdx,7FFB8420AF90
       call      qword ptr [7FFB83A9F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L18
M01_L25:
       mov       rdx,7FFB84209608
       call      qword ptr [7FFB83A9F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFB83A957A0]; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      00007FFBE36B1380
       cmp       dword ptr [7FFBE39D3A10],0
       je        near ptr M01_L11
       jmp       near ptr M01_L40
M01_L28:
       lea       rcx,[rbp-188]
       call      qword ptr [7FFB841E6B50]
       jmp       near ptr M01_L12
M01_L29:
       call      qword ptr [7FFB83EAD1B8]
       int       3
M01_L30:
       mov       rdx,7FFB8420A960
       call      qword ptr [7FFB83A9F648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M01_L01
M01_L31:
       mov       rcx,rdi
       mov       rdx,7FFB8420AD90
       call      qword ptr [7FFB83A9F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M01_L02
M01_L32:
       mov       ecx,11
       call      qword ptr [7FFB83A9F948]
       int       3
M01_L33:
       call      qword ptr [7FFB841E65B0]
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
       mov       rdx,7FFB8420B120
       call      qword ptr [7FFB83A9F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M01_L36:
       lea       rcx,[rbp-1A0]
       lea       r8,[rbp-178]
       mov       r9d,1B
       call      qword ptr [7FFB841E6970]
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
       call      qword ptr [7FFB83A957A0]; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFB8402EF10]
       jmp       near ptr M01_L11
M01_L42:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       mov       rbx,[rbp-1B8]
       test      rbx,rbx
       je        short M01_L43
       mov       rcx,rbx
       mov       r11,7FFB839E0A68
       call      qword ptr [r11]
M01_L43:
       nop
       add       rsp,28
       ret
; Total bytes of code 1400
```

