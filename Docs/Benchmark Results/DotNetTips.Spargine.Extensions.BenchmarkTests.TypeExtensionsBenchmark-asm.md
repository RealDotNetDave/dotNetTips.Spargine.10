## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.TypeExtensionsBenchmark.GetAllDeclaredFields()
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
       xor       eax,eax
       mov       [rbp-40],rax
       mov       [rbp-48],rax
       mov       rbx,rcx
       mov       rcx,2821419B598
       call      qword ptr [7FFF7892CEE8]; DotNetTips.Spargine.Core.TypeHelper.GetAllDeclaredFields(System.Type)
       mov       rsi,rax
       test      rsi,rsi
       je        near ptr M00_L06
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Generic.IReadOnlyList<System.Reflection.FieldInfo>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M00_L10
       xor       esi,esi
       mov       r14,offset MT_System.Reflection.FieldInfo[]
       cmp       [rdi],r14
       jne       near ptr M00_L03
M00_L00:
       mov       r15d,[rdi+8]
       mov       eax,r15d
       cmp       esi,eax
       jge       near ptr M00_L05
       cmp       r15d,esi
       jbe       near ptr M00_L09
       mov       ecx,esi
       mov       r13,[rdi+rcx*8+10]
       mov       [rbp-40],r13
       mov       r12,[rbx+60]
       mov       rdx,[rbp-40]
       lea       rcx,[r12+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r12+8],rcx
       add       esi,1
       jo        near ptr M00_L13
       jmp       short M00_L00
M00_L01:
       cmp       [rdi],r14
       jne       near ptr M00_L08
       mov       r15d,[rdi+8]
       cmp       r15d,esi
       jbe       near ptr M00_L09
       mov       ecx,esi
       mov       r13,[rdi+rcx*8+10]
M00_L02:
       mov       [rbp-40],r13
       mov       r12,[rbx+60]
       mov       rdx,[rbp-40]
       lea       rcx,[r12+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [r12+8],rax
       add       esi,1
       jo        near ptr M00_L13
M00_L03:
       cmp       [rdi],r14
       jne       near ptr M00_L07
       mov       r15d,[rdi+8]
M00_L04:
       cmp       esi,r15d
       jl        short M00_L01
M00_L05:
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
M00_L06:
       call      qword ptr [7FFF788BE940]
       mov       ecx,7C4
       mov       rdx,7FFF785F3DE8
       call      qword ptr [7FFF785477B0]
       mov       rbx,rax
       mov       ecx,1B69
       mov       rdx,7FFF785F5550
       call      qword ptr [7FFF785477B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF78327840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,7C2
       mov       rdx,7FFF785F3DE8
       call      qword ptr [7FFF785477B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF78327840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF78A1D488]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF7892F7E0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       mov       rcx,rdi
       mov       r11,7FFF78270B28
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       near ptr M00_L04
M00_L08:
       mov       rcx,rdi
       mov       edx,esi
       mov       r11,7FFF78270B30
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M00_L02
M00_L09:
       call      qword ptr [7FFF7892E928]
       int       3
M00_L10:
       mov       rcx,rsi
       mov       r11,7FFF78270B08
       call      qword ptr [r11]
       mov       [rbp-50],rax
M00_L11:
       mov       rcx,[rbp-50]
       mov       r11,7FFF78270B10
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L12
       mov       rcx,[rbp-50]
       mov       r11,7FFF78270B18
       call      qword ptr [r11]
       mov       [rbp-48],rax
       mov       rsi,[rbx+60]
       mov       rdx,[rbp-48]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+8],rcx
       jmp       short M00_L11
M00_L12:
       mov       rcx,[rbp-50]
       mov       r11,7FFF78270B20
       call      qword ptr [r11]
       jmp       near ptr M00_L05
M00_L13:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       qword ptr [rbp-50],0
       je        short M00_L14
       mov       rcx,[rbp-50]
       mov       r11,7FFF78270B20
       call      qword ptr [r11]
M00_L14:
       nop
       add       rsp,28
       ret
; Total bytes of code 642
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
       sub       rsp,0F8
       lea       rbp,[rsp+30]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp+60],ymm4
       vmovdqu   ymmword ptr [rbp+80],ymm4
       vmovdqu   ymmword ptr [rbp+0A0],ymm4
       xor       eax,eax
       mov       [rbp+0C0],rax
       mov       rax,73F5BF2CF3F7
       mov       [rbp+8],rax
       mov       rbx,rcx
       test      rbx,rbx
       je        near ptr M01_L74
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
       mov       [rbp+0A0],rax
       mov       [rbp+0B8],rcx
       mov       dword ptr [rbp+0C0],80
       mov       [rbp+0A8],rax
       mov       [rbp+0B0],eax
       mov       byte ptr [rbp+0B4],0
       mov       rcx,offset MT_System.RuntimeType
       cmp       [rbx],rcx
       jne       near ptr M01_L78
       cmp       qword ptr [rbx+10],0
       je        short M01_L00
       mov       rcx,[rbx+10]
       mov       rsi,[rcx]
       test      rsi,rsi
       jne       short M01_L02
M01_L00:
       mov       [rbp+110],rbx
       mov       rcx,rbx
       call      qword ptr [7FFF78327C30]; System.RuntimeType.InitializeCache()
       mov       rdi,rax
       mov       rbx,[rbp+110]
M01_L01:
       mov       rsi,[rdi+20]
       test      rsi,rsi
       jne       near ptr M01_L09
       mov       [rbp+40],rdi
       mov       rcx,[rdi+8]
       cmp       [rcx],ecx
       call      qword ptr [7FFF7832C6A8]; System.Type.GetRootElementType()
       mov       rsi,rax
       mov       [rbp+38],rsi
       mov       rcx,offset MT_System.RuntimeType
       cmp       [rsi],rcx
       jne       near ptr M01_L26
       mov       rcx,[rsi+18]
       test      cl,2
       jne       short M01_L03
       mov       eax,[rcx]
       and       eax,80000030
       cmp       eax,30
       sete      al
       movzx     eax,al
       jmp       short M01_L04
       nop       dword ptr [rax]
M01_L02:
       mov       rdi,rsi
       jmp       short M01_L01
M01_L03:
       xor       eax,eax
M01_L04:
       test      eax,eax
       jne       short M01_L06
       mov       rcx,offset MT_System.RuntimeType
       cmp       [rsi],rcx
       jne       near ptr M01_L27
       mov       rcx,rsi
       call      qword ptr [7FFF7832C6A8]; System.Type.GetRootElementType()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+98]
       call      qword ptr [rax+8]
       test      rax,rax
       je        near ptr M01_L75
       mov       rcx,rax
       call      00007FFFD7F43260
M01_L05:
       test      eax,eax
       jne       near ptr M01_L76
M01_L06:
       mov       rcx,offset MT_System.RuntimeType
       cmp       [rsi],rcx
       jne       near ptr M01_L28
       mov       [rbp+110],rbx
       mov       rcx,[rsi+18]
       mov       rax,7FFFD7F3F0F0
       vzeroupper
       call      rax
       movzx     ebx,al
       cmp       dword ptr [7FFFD8253A10],0
       jne       near ptr M01_L77
M01_L07:
       cmp       ebx,1B
       mov       rbx,[rbp+110]
       je        near ptr M01_L76
M01_L08:
       mov       rdi,[rbp+40]
       lea       rdx,[rdi+20]
       mov       rcx,rdi
       mov       r8d,3
       call      qword ptr [7FFF78494AF8]; System.RuntimeType+RuntimeTypeCache.ConstructName(System.String ByRef, System.TypeNameFormatFlags)
       mov       rsi,rax
M01_L09:
       cmp       byte ptr [rbp+0B4],0
       jne       near ptr M01_L29
       test      rsi,rsi
       je        near ptr M01_L29
       mov       r8d,[rbp+0B0]
       cmp       r8d,[rbp+0C0]
       ja        near ptr M01_L79
       mov       rdx,[rbp+0B8]
       mov       ecx,r8d
       lea       rcx,[rdx+rcx*2]
       mov       edx,[rbp+0C0]
       sub       edx,r8d
       cmp       [rsi+8],edx
       ja        near ptr M01_L29
       mov       r8d,[rsi+8]
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFF78325818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbp+0B0]
       add       ecx,[rsi+8]
       mov       [rbp+0B0],ecx
M01_L10:
       mov       ecx,[rbp+0B0]
       cmp       ecx,[rbp+0C0]
       ja        near ptr M01_L79
       mov       rdx,[rbp+0B8]
       mov       eax,ecx
       lea       rdx,[rdx+rax*2]
       mov       eax,[rbp+0C0]
       sub       eax,ecx
       je        near ptr M01_L30
       mov       word ptr [rdx],2E
       mov       ecx,[rbp+0B0]
       inc       ecx
       mov       [rbp+0B0],ecx
M01_L11:
       cmp       byte ptr [rbp+0B4],0
       jne       near ptr M01_L31
       mov       ecx,[rbp+0B0]
       cmp       ecx,[rbp+0C0]
       ja        near ptr M01_L79
       mov       rdx,[rbp+0B8]
       mov       eax,ecx
       lea       rdx,[rdx+rax*2]
       mov       eax,[rbp+0C0]
       sub       eax,ecx
       cmp       eax,14
       jb        near ptr M01_L31
       vmovups   ymm0,[7FFF78A74CE0]
       vmovups   [rdx],ymm0
       mov       rcx,730064006C0065
       mov       [rdx+20],rcx
       mov       ecx,[rbp+0B0]
       add       ecx,14
       mov       [rbp+0B0],ecx
M01_L12:
       mov       ecx,[rbp+0B0]
       cmp       ecx,[rbp+0C0]
       ja        near ptr M01_L79
       mov       rax,[rbp+0B8]
       mov       [rbp+60],rax
       mov       [rbp+68],ecx
       lea       rcx,[rbp+60]
       call      System.String.Ctor(System.ReadOnlySpan`1<Char>)
       mov       rsi,rax
       mov       rdi,[rbp+0A8]
       xor       ecx,ecx
       mov       [rbp+0A8],rcx
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp+0B8],xmm0
       mov       [rbp+0B0],ecx
       test      rdi,rdi
       je        near ptr M01_L16
       mov       rcx,2417F000C88
       mov       r14,[rcx]
       mov       ecx,[rdi+8]
       dec       ecx
       or        ecx,0F
       xor       r15d,r15d
       lzcnt     r15d,ecx
       xor       r15d,1F
       add       r15d,0FFFFFFFD
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],3
       jle       near ptr M01_L80
       mov       rcx,[rcx+240]
       mov       rax,[rcx+18]
       test      rax,rax
       je        near ptr M01_L80
M01_L13:
       mov       rax,[rax+10]
       test      rax,rax
       je        near ptr M01_L81
M01_L14:
       xor       r13d,r13d
       mov       r12d,1
       cmp       [rax+8],r15d
       jbe       short M01_L15
       mov       r13d,1
       mov       ecx,10
       shlx      ecx,ecx,r15d
       cmp       [rdi+8],ecx
       jne       near ptr M01_L82
       mov       ecx,r15d
       shl       rcx,4
       lea       rax,[rax+rcx+10]
       mov       [rbp+28],rax
       mov       r8,[rax]
       mov       [rbp+20],r8
       mov       rcx,rax
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       rdx,[rbp+28]
       mov       [rdx+8],ecx
       cmp       qword ptr [rbp+20],0
       jne       near ptr M01_L32
M01_L15:
       mov       rcx,2417F000C90
       mov       rax,[rcx]
       mov       [rbp+30],rax
       cmp       byte ptr [rax+9D],0
       jne       near ptr M01_L92
M01_L16:
       mov       rcx,24195000138
       mov       rdi,[rcx]
       test      rsi,rsi
       je        near ptr M01_L95
       mov       ecx,[rsi+8]
       cmp       dword ptr [rsi+8],0
       je        near ptr M01_L95
       movzx     ecx,word ptr [rsi+0C]
       cmp       ecx,100
       jge       near ptr M01_L97
       cmp       ecx,100
       jae       near ptr M01_L136
       mov       rax,7FFFC8AF6090
       test      byte ptr [rax+rcx],80
       jne       near ptr M01_L99
M01_L17:
       mov       ecx,[rsi+8]
       dec       ecx
       cmp       ecx,[rsi+8]
       jae       near ptr M01_L136
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jge       near ptr M01_L98
       cmp       ecx,100
       jae       near ptr M01_L136
       mov       rax,7FFFC8AF6090
       test      byte ptr [rax+rcx],80
       jne       near ptr M01_L99
M01_L18:
       mov       r14,rsi
M01_L19:
       mov       rdi,[rdi+10]
       test      r14,r14
       jne       near ptr M01_L44
       xor       r15d,r15d
       xor       r13d,r13d
M01_L20:
       cmp       byte ptr [rdi+44],0
       jne       near ptr M01_L100
       mov       r14,[rdi+28]
       mov       rcx,[r14+20]
       mov       r12,[rcx+8]
       mov       rax,[r12+8]
       mov       [rbp+10],rax
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer+OrdinalComparer
       cmp       [rax],rcx
       jne       near ptr M01_L101
       mov       [rbp+60],r15
       mov       [rbp+68],r13d
       lea       rcx,[rbp+60]
       call      qword ptr [7FFF788B71E0]; System.String.GetNonRandomizedHashCode(System.ReadOnlySpan`1<Char>)
M01_L21:
       mov       [rbp+80],eax
       mov       rdx,[r12+10]
       mov       r8d,eax
       imul      r8,[r12+28]
       shr       r8,20
       inc       r8
       mov       ecx,[rdx+8]
       imul      r8,rcx
       shr       r8,20
       cmp       r8d,[rdx+8]
       jae       near ptr M01_L136
       mov       r8d,r8d
       mov       r12,[rdx+r8*8+10]
       mov       r10,[rbp+10]
       test      r10,r10
       je        near ptr M01_L52
       mov       rdx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer+OrdinalComparer
       cmp       [r10],rdx
       jne       near ptr M01_L52
M01_L22:
       test      r12,r12
       je        near ptr M01_L129
       cmp       eax,[r12+20]
       jne       near ptr M01_L113
       mov       r8,[r12+8]
       test      r13d,r13d
       je        near ptr M01_L102
M01_L23:
       test      r8,r8
       jne       near ptr M01_L45
       xor       edx,edx
       xor       ecx,ecx
M01_L24:
       cmp       r13d,ecx
       jne       near ptr M01_L51
       mov       r11,r15
       mov       r9,rdx
       mov       ecx,ecx
       add       rcx,rcx
       cmp       rcx,8
       jb        near ptr M01_L103
       cmp       r11,r9
       je        near ptr M01_L47
       cmp       rcx,20
       jb        near ptr M01_L108
       xor       edx,edx
       add       rcx,0FFFFFFFFFFFFFFE0
       je        near ptr M01_L46
       vmovups   ymm0,[r15]
       vpcmpeqb  ymm0,ymm0,[r9]
       vpmovmskb r8d,ymm0
       cmp       r8d,0FFFFFFFF
       jne       near ptr M01_L112
M01_L25:
       add       rdx,20
       cmp       rcx,rdx
       jbe       near ptr M01_L46
       vmovups   ymm0,[r15+rdx]
       vpcmpeqb  ymm0,ymm0,[r9+rdx]
       vpmovmskb r10d,ymm0
       cmp       r10d,0FFFFFFFF
       jne       near ptr M01_L112
       jmp       short M01_L25
M01_L26:
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+60]
       call      qword ptr [rax+10]
       jmp       near ptr M01_L04
M01_L27:
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+0B0]
       call      qword ptr [rax]
       jmp       near ptr M01_L05
M01_L28:
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+60]
       call      qword ptr [rax+30]
       test      eax,eax
       jne       near ptr M01_L76
       jmp       near ptr M01_L08
M01_L29:
       lea       rcx,[rbp+0A0]
       mov       rdx,rsi
       call      qword ptr [7FFF78A1C2E8]
       jmp       near ptr M01_L10
M01_L30:
       lea       rcx,[rbp+0A0]
       mov       rdx,28214190658
       call      qword ptr [7FFF789268B0]
       jmp       near ptr M01_L11
M01_L31:
       lea       rcx,[rbp+0A0]
       mov       rdx,282141A0708
       call      qword ptr [7FFF78A1C2E8]
       jmp       near ptr M01_L12
M01_L32:
       mov       rcx,[r14+10]
       cmp       r15d,[rcx+8]
       jae       near ptr M01_L136
       mov       edx,r15d
       mov       r8,[rcx+rdx*8+10]
       test      r8,r8
       je        near ptr M01_L83
M01_L33:
       mov       r12,[r8+8]
       test      byte ptr [7FFF78AFD720],1
       je        near ptr M01_L84
M01_L34:
       cmp       byte ptr [7FFF7826B19C],0
       je        near ptr M01_L85
       call      qword ptr [7FFF78A1C408]
       mov       edx,eax
M01_L35:
       test      byte ptr [7FFF78AFD5B0],1
       je        near ptr M01_L87
M01_L36:
       mov       eax,edx
       xor       edx,edx
       div       dword ptr [7FFF7826B190]
       mov       eax,edx
       mov       edx,[r12+8]
       mov       [rbp+4C],edx
       test      edx,edx
       jle       near ptr M01_L91
       mov       [rbp+48],edx
M01_L37:
       cmp       eax,edx
       jae       near ptr M01_L136
       mov       [rbp+94],eax
       mov       ecx,eax
       mov       r10,[r12+rcx*8+10]
       mov       [rbp+18],r10
       cmp       [r10],r10b
       xor       r9d,r9d
       mov       [rbp+88],r9d
       mov       rcx,r10
       call      00007FFFD7FA2D60
       test      eax,eax
       jne       short M01_L38
       mov       rcx,[rbp+18]
       call      qword ptr [7FFF7892F6C0]
M01_L38:
       mov       rax,[rbp+18]
       mov       rcx,[rax+8]
       mov       r8d,[rax+10]
       mov       [rbp+84],r8d
       cmp       [rcx+8],r8d
       jbe       short M01_L40
       test      r8d,r8d
       je        short M01_L43
M01_L39:
       mov       edx,r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,[rbp+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rbp+84]
       inc       ecx
       mov       rax,[rbp+18]
       mov       [rax+10],ecx
       mov       dword ptr [rbp+88],1
M01_L40:
       mov       rcx,rax
       call      00007FFFD7FA2C80
       test      eax,eax
       jne       near ptr M01_L88
M01_L41:
       cmp       dword ptr [rbp+88],0
       je        near ptr M01_L89
       mov       r12d,1
M01_L42:
       jmp       near ptr M01_L15
M01_L43:
       xor       edx,edx
       mov       [rax+14],edx
       jmp       short M01_L39
M01_L44:
       lea       r15,[r14+0C]
       mov       r13d,[r14+8]
       jmp       near ptr M01_L20
M01_L45:
       lea       rdx,[r8+0C]
       mov       ecx,[r8+8]
       jmp       near ptr M01_L24
M01_L46:
       vmovups   ymm0,[r15+rcx]
       vpcmpeqb  ymm0,ymm0,[r9+rcx]
       vpmovmskb r9d,ymm0
       cmp       r9d,0FFFFFFFF
       jne       near ptr M01_L112
M01_L47:
       mov       ecx,1
M01_L48:
       test      ecx,ecx
       je        near ptr M01_L113
M01_L49:
       mov       r15,[r12+10]
M01_L50:
       mov       rdx,[rdi+10]
       mov       rcx,[rdx+8]
       test      rcx,rcx
       jne       near ptr M01_L59
       call      qword ptr [7FFF78847B28]; System.DateTime.get_UtcNow()
       mov       r13,rax
       jmp       near ptr M01_L60
M01_L51:
       xor       ecx,ecx
       jmp       short M01_L48
M01_L52:
       test      r12,r12
       je        near ptr M01_L129
       cmp       eax,[r12+20]
       jne       near ptr M01_L128
       mov       r8,[r12+8]
       mov       rdx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer+OrdinalComparer
       cmp       [r10],rdx
       jne       near ptr M01_L114
       test      r13d,r13d
       je        near ptr M01_L115
M01_L53:
       test      r8,r8
       jne       near ptr M01_L116
       xor       edx,edx
       xor       ecx,ecx
M01_L54:
       cmp       r13d,ecx
       jne       near ptr M01_L117
       mov       r11,r15
       mov       r9,rdx
       mov       ecx,ecx
       add       rcx,rcx
       cmp       rcx,8
       jb        near ptr M01_L123
       cmp       r11,r9
       je        short M01_L57
       cmp       rcx,20
       jb        near ptr M01_L118
       xor       edx,edx
       add       rcx,0FFFFFFFFFFFFFFE0
       je        short M01_L56
       vmovups   ymm0,[r15]
       vpcmpeqb  ymm0,ymm0,[r9]
       vpmovmskb r8d,ymm0
       cmp       r8d,0FFFFFFFF
       jne       near ptr M01_L122
M01_L55:
       add       rdx,20
       cmp       rcx,rdx
       jbe       short M01_L56
       vmovups   ymm0,[r15+rdx]
       vpcmpeqb  ymm0,ymm0,[r9+rdx]
       vpmovmskb r8d,ymm0
       cmp       r8d,0FFFFFFFF
       jne       near ptr M01_L122
       jmp       short M01_L55
M01_L56:
       vmovups   ymm0,[r15+rcx]
       vpcmpeqb  ymm0,ymm0,[r9+rcx]
       vpmovmskb r9d,ymm0
       cmp       r9d,0FFFFFFFF
       jne       near ptr M01_L122
M01_L57:
       mov       ecx,1
M01_L58:
       test      ecx,ecx
       je        near ptr M01_L128
       jmp       near ptr M01_L49
M01_L59:
       lea       rdx,[rbp+70]
       mov       r11,7FFF78270B50
       call      qword ptr [r11]
       mov       r13,4000000000000000
       or        r13,[rbp+78]
M01_L60:
       test      r15,r15
       je        near ptr M01_L70
       cmp       byte ptr [r15+43],0
       jne       near ptr M01_L69
       cmp       qword ptr [r15+38],0
       jge       short M01_L61
       cmp       qword ptr [r15+50],0
       je        short M01_L62
M01_L61:
       mov       rcx,r15
       mov       rdx,r13
       call      qword ptr [7FFF7892DE30]; Microsoft.Extensions.Caching.Memory.CacheEntry.<CheckForExpiredTime>g__FullCheck|64_0(System.DateTime)
       test      eax,eax
       jne       near ptr M01_L69
M01_L62:
       cmp       qword ptr [r15+10],0
       je        short M01_L63
       mov       rcx,[r15+10]
       mov       rdx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFF78A1C7C8]
       test      eax,eax
       jne       near ptr M01_L69
M01_L63:
       mov       [r15+58],r13
       mov       r14,[r15+20]
       cmp       byte ptr [rdi+45],0
       jne       near ptr M01_L130
M01_L64:
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+28]
       mov       rdx,[rdi+48]
       mov       rax,3FFFFFFFFFFFFFFF
       and       rax,r13
       mov       r8,3FFFFFFFFFFFFFFF
       and       rdx,r8
       sub       rax,rdx
       cmp       rcx,rax
       jge       short M01_L65
       mov       rcx,rdi
       mov       rdx,r13
       call      qword ptr [7FFF78A1C7F8]
M01_L65:
       cmp       qword ptr [rdi+20],0
       jne       near ptr M01_L131
M01_L66:
       test      r14,r14
       je        near ptr M01_L132
       mov       rdx,r14
       mov       rcx,offset MT_System.Reflection.FieldInfo[]
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
       test      rax,rax
       je        near ptr M01_L72
       mov       rax,r14
       test      rax,rax
       je        short M01_L67
       mov       rcx,offset MT_System.Reflection.FieldInfo[]
       cmp       [rax],rcx
       je        short M01_L67
       mov       rdx,r14
       call      qword ptr [7FFF783258D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
M01_L67:
       mov       r8,73F5BF2CF3F7
       cmp       [rbp+8],r8
       je        short M01_L68
       call      CORINFO_HELP_FAIL_FAST
M01_L68:
       nop
       vzeroupper
       lea       rsp,[rbp+0C8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L69:
       cmp       byte ptr [r15+45],2
       je        near ptr M01_L63
       mov       r8,[rdi+10]
       mov       rcx,r14
       mov       rdx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFF78A1C828]
M01_L70:
       mov       rdx,[rdi+10]
       mov       r14,[rdx+28]
       mov       rdx,[rdi+48]
       mov       rcx,r13
       call      qword ptr [7FFF7892DBA8]; System.DateTime.op_Subtraction(System.DateTime, System.DateTime)
       cmp       r14,rax
       jge       short M01_L71
       mov       rcx,rdi
       mov       rdx,r13
       call      qword ptr [7FFF78A1C7F8]
M01_L71:
       cmp       qword ptr [rdi+20],0
       je        short M01_L72
       mov       rcx,[rdi+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFF78A1C810]
       inc       qword ptr [rax+18]
M01_L72:
       mov       rcx,rbx
       mov       edx,3E
       mov       rax,[rbx]
       mov       rax,[rax+80]
       call      qword ptr [rax+28]
       mov       rbx,rax
       mov       ecx,5
       call      qword ptr [7FFF7892CF78]; System.TimeSpan.FromMinutes(Int64)
       mov       rdi,rax
       mov       rcx,24195000138
       mov       r14,[rcx]
       cmp       dword ptr [rsi+8],0
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M01_L133
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFF78745188]; System.String.Trim()
       mov       rsi,rax
       test      rbx,rbx
       je        near ptr M01_L135
       mov       rcx,offset MT_Microsoft.Extensions.Caching.Memory.MemoryCacheEntryOptions
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       r14,[r14+10]
       mov       dword ptr [r15+18],1
       mov       byte ptr [rbp+50],1
       mov       [rbp+58],rdi
       lea       rdx,[rbp+50]
       mov       rcx,r15
       call      qword ptr [7FFF7892DCE0]; Microsoft.Extensions.Caching.Memory.MemoryCacheEntryOptions.set_AbsoluteExpirationRelativeToNow(System.Nullable`1<System.TimeSpan>)
       mov       [rsp+20],r15
       mov       rdx,r14
       mov       r8,rsi
       mov       r9,rbx
       mov       rcx,7FFF789CFD90
       call      qword ptr [7FFF7892DC38]; Microsoft.Extensions.Caching.Memory.CacheExtensions.Set[[System.__Canon, System.Private.CoreLib]](Microsoft.Extensions.Caching.Memory.IMemoryCache, System.Object, System.__Canon, Microsoft.Extensions.Caching.Memory.MemoryCacheEntryOptions)
       mov       rax,rbx
       mov       r8,73F5BF2CF3F7
       cmp       [rbp+8],r8
       je        short M01_L73
       call      CORINFO_HELP_FAIL_FAST
M01_L73:
       nop
       vzeroupper
       lea       rsp,[rbp+0C8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L74:
       call      qword ptr [7FFF788BE940]
       mov       ecx,2257
       mov       rdx,7FFF785F5550
       call      qword ptr [7FFF785477B0]
       mov       rbx,rax
       mov       ecx,1B69
       mov       rdx,7FFF785F5550
       call      qword ptr [7FFF785477B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF78327840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,111F
       mov       rdx,7FFF785F5550
       call      qword ptr [7FFF785477B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF78327840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF78A1D488]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF7892F7E0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M01_L75:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF7892F7C8]
       mov       r8,rax
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFF7892F7E0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M01_L76:
       xor       esi,esi
       jmp       near ptr M01_L09
M01_L77:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M01_L07
M01_L78:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+50]
       call      qword ptr [rax+20]
       mov       rsi,rax
       jmp       near ptr M01_L09
M01_L79:
       call      qword ptr [7FFF78497198]
       int       3
M01_L80:
       mov       ecx,3
       call      qword ptr [7FFF78A17F30]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M01_L13
M01_L81:
       mov       rcx,r14
       call      qword ptr [7FFF7854CEA0]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
       jmp       near ptr M01_L14
M01_L82:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF78A1C3D8]
       mov       r14,rax
       mov       ecx,29B
       mov       rdx,7FFF78264000
       call      qword ptr [7FFF785477B0]
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,rdi
       call      qword ptr [7FFF786A6EE0]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M01_L83:
       mov       rcx,r14
       mov       edx,r15d
       call      qword ptr [7FFF78A1C3F0]
       mov       r8,rax
       jmp       near ptr M01_L33
M01_L84:
       mov       rcx,offset MT_System.Threading.ProcessorIdCache
       call      qword ptr [7FFF78325740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M01_L34
M01_L85:
       mov       ecx,9
       call      qword ptr [7FFF78A1C420]
       mov       eax,[rax+10]
       mov       [rbp+8C],eax
       mov       ecx,9
       call      qword ptr [7FFF78A1C420]
       mov       edx,[rbp+8C]
       lea       ecx,[rdx-1]
       mov       [rax+10],ecx
       movzx     eax,dx
       test      eax,eax
       jne       short M01_L86
       call      qword ptr [7FFF78A1C438]
       mov       edx,eax
       jmp       near ptr M01_L35
M01_L86:
       sar       edx,10
       mov       [rbp+90],edx
       mov       edx,[rbp+90]
       jmp       near ptr M01_L35
M01_L87:
       mov       [rbp+90],edx
       mov       rcx,offset MT_System.Buffers.SharedArrayPoolStatics
       call      qword ptr [7FFF78325740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       edx,[rbp+90]
       jmp       near ptr M01_L36
M01_L88:
       mov       ecx,eax
       mov       rdx,[rbp+18]
       call      qword ptr [7FFF7892F3C0]
       jmp       near ptr M01_L41
M01_L89:
       mov       eax,[rbp+94]
       inc       eax
       mov       ecx,eax
       mov       edx,[rbp+4C]
       cmp       edx,ecx
       jne       short M01_L90
       xor       ecx,ecx
M01_L90:
       mov       r8d,[rbp+48]
       dec       r8d
       mov       [rbp+48],r8d
       mov       eax,ecx
       jne       near ptr M01_L37
M01_L91:
       xor       r12d,r12d
       jmp       near ptr M01_L42
M01_L92:
       cmp       dword ptr [rdi+8],0
       je        near ptr M01_L16
       mov       rcx,rdi
       call      qword ptr [7FFF7874E5E0]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rbp+9C],eax
       mov       edx,[rdi+8]
       mov       [rbp+98],edx
       mov       rcx,r14
       call      qword ptr [7FFF7874E5E0]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,[rbp+30]
       mov       r8d,[rbp+9C]
       mov       r9d,[rbp+98]
       mov       edx,3
       call      qword ptr [7FFF78A1C450]
       test      r12d,r13d
       jne       near ptr M01_L16
       mov       rcx,rdi
       call      qword ptr [7FFF7874E5E0]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r12d,eax
       mov       edi,[rdi+8]
       mov       rcx,r14
       call      qword ptr [7FFF7874E5E0]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       test      r13d,r13d
       jne       short M01_L93
       mov       ecx,0FFFFFFFF
       mov       edx,1
       jmp       short M01_L94
M01_L93:
       mov       ecx,r15d
       xor       edx,edx
M01_L94:
       mov       [rsp+20],ecx
       mov       [rsp+28],edx
       mov       rcx,[rbp+30]
       mov       edx,r12d
       mov       r8d,edi
       call      qword ptr [7FFF78A1C468]
       jmp       near ptr M01_L16
M01_L95:
       call      qword ptr [7FFF78745140]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L96
       call      qword ptr [7FFF78A1D488]
       mov       rbx,rax
M01_L96:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,28214199C08
       call      qword ptr [7FFF7892F7E0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M01_L97:
       call      qword ptr [7FFF78A163E8]
       test      eax,eax
       jne       short M01_L99
       jmp       near ptr M01_L17
M01_L98:
       call      qword ptr [7FFF78A163E8]
       test      eax,eax
       je        near ptr M01_L18
M01_L99:
       mov       rcx,rsi
       mov       edx,3
       call      qword ptr [7FFF78A1C498]
       mov       r14,rax
       jmp       near ptr M01_L19
M01_L100:
       call      qword ptr [7FFF78A1C708]
       int       3
M01_L101:
       mov       rax,[rbp+10]
       mov       [rbp+60],r15
       mov       [rbp+68],r13d
       lea       rdx,[rbp+60]
       mov       rcx,rax
       mov       r11,7FFF78270B40
       call      qword ptr [r11]
       jmp       near ptr M01_L21
M01_L102:
       test      r8,r8
       je        near ptr M01_L113
       jmp       near ptr M01_L23
M01_L103:
       cmp       rcx,4
       jae       short M01_L106
       xor       r11d,r11d
       mov       r10,rcx
       and       r10,2
       je        short M01_L104
       movzx     r11d,word ptr [r15]
       movzx     r9d,word ptr [rdx]
       sub       r11d,r9d
M01_L104:
       test      cl,1
       je        short M01_L105
       movzx     ecx,byte ptr [r15+r10]
       movzx     edx,byte ptr [rdx+r10]
       sub       ecx,edx
       or        r11d,ecx
M01_L105:
       test      r11d,r11d
       sete      cl
       movzx     ecx,cl
       jmp       short M01_L107
M01_L106:
       lea       r9,[rcx-4]
       mov       ecx,[r15]
       sub       ecx,[rdx]
       mov       r8d,[r15+r9]
       sub       r8d,[rdx+r9]
       or        r8d,ecx
       sete      cl
       movzx     ecx,cl
M01_L107:
       jmp       near ptr M01_L48
M01_L108:
       cmp       rcx,10
       jb        short M01_L111
       xor       r8d,r8d
       lea       r10,[rcx-10]
       test      r10,r10
       je        short M01_L110
M01_L109:
       vmovups   xmm0,[r15+r8]
       vpcmpeqb  xmm0,xmm0,[r9+r8]
       vpmovmskb ecx,xmm0
       cmp       ecx,0FFFF
       jne       short M01_L112
       add       r8,10
       cmp       r10,r8
       ja        short M01_L109
M01_L110:
       vmovups   xmm0,[r15+r10]
       vpcmpeqb  xmm0,xmm0,[r9+r10]
       vpmovmskb edx,xmm0
       cmp       edx,0FFFF
       jne       short M01_L112
       jmp       near ptr M01_L47
M01_L111:
       lea       r10,[rcx-8]
       mov       rcx,[r15]
       sub       rcx,[rdx]
       mov       r11,[r15+r10]
       sub       r11,[rdx+r10]
       or        rcx,r11
       sete      cl
       movzx     ecx,cl
       jmp       short M01_L107
M01_L112:
       xor       ecx,ecx
       jmp       near ptr M01_L48
M01_L113:
       mov       r12,[r12+18]
       jmp       near ptr M01_L22
M01_L114:
       mov       [rbp+60],r15
       mov       [rbp+68],r13d
       lea       rdx,[rbp+60]
       mov       rcx,r10
       mov       r11,7FFF78270B48
       call      qword ptr [r11]
       mov       ecx,eax
       mov       r10,[rbp+10]
       jmp       near ptr M01_L58
M01_L115:
       test      r8,r8
       jne       near ptr M01_L53
       jmp       near ptr M01_L128
M01_L116:
       lea       rdx,[r8+0C]
       mov       ecx,[r8+8]
       jmp       near ptr M01_L54
M01_L117:
       xor       ecx,ecx
       jmp       near ptr M01_L58
M01_L118:
       cmp       rcx,10
       jae       short M01_L119
       add       rcx,0FFFFFFFFFFFFFFF8
       mov       r8,[r15]
       sub       r8,[rdx]
       mov       r11,[r15+rcx]
       sub       r11,[rdx+rcx]
       or        r8,r11
       sete      cl
       movzx     ecx,cl
       jmp       near ptr M01_L127
M01_L119:
       xor       r8d,r8d
       add       rcx,0FFFFFFFFFFFFFFF0
       je        short M01_L121
M01_L120:
       vmovups   xmm0,[r15+r8]
       vpcmpeqb  xmm0,xmm0,[r9+r8]
       vpmovmskb edx,xmm0
       cmp       edx,0FFFF
       jne       short M01_L122
       add       r8,10
       cmp       rcx,r8
       ja        short M01_L120
M01_L121:
       vmovups   xmm0,[r15+rcx]
       vpcmpeqb  xmm0,xmm0,[r9+rcx]
       vpmovmskb edx,xmm0
       cmp       edx,0FFFF
       je        near ptr M01_L57
M01_L122:
       xor       ecx,ecx
       jmp       near ptr M01_L58
M01_L123:
       cmp       rcx,4
       jb        short M01_L124
       lea       r9,[rcx-4]
       mov       r8d,[r15]
       sub       r8d,[rdx]
       mov       ecx,[r15+r9]
       sub       ecx,[rdx+r9]
       or        r8d,ecx
       sete      cl
       movzx     ecx,cl
       jmp       short M01_L127
M01_L124:
       xor       r11d,r11d
       mov       r8,rcx
       and       r8,2
       je        short M01_L125
       movzx     r11d,word ptr [r15]
       movzx     r9d,word ptr [rdx]
       sub       r11d,r9d
M01_L125:
       test      cl,1
       je        short M01_L126
       movzx     ecx,byte ptr [r15+r8]
       movzx     edx,byte ptr [rdx+r8]
       sub       ecx,edx
       or        ecx,r11d
       mov       r11d,ecx
M01_L126:
       test      r11d,r11d
       sete      cl
       movzx     ecx,cl
M01_L127:
       jmp       near ptr M01_L58
M01_L128:
       mov       r12,[r12+18]
       mov       eax,[rbp+80]
       jmp       near ptr M01_L52
M01_L129:
       xor       r15d,r15d
       jmp       near ptr M01_L50
M01_L130:
       mov       rcx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFF78A1C7E0]
       jmp       near ptr M01_L64
M01_L131:
       mov       rcx,[rdi+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFF78A1C810]
       inc       qword ptr [rax+10]
       jmp       near ptr M01_L66
M01_L132:
       xor       eax,eax
       jmp       near ptr M01_L67
M01_L133:
       call      qword ptr [7FFF78745140]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L134
       call      qword ptr [7FFF78A1D488]
       mov       rbx,rax
M01_L134:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,28214199C08
       call      qword ptr [7FFF7892F7E0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M01_L135:
       call      qword ptr [7FFF788BE940]
       mov       ecx,20BF
       mov       rdx,7FFF785F5550
       call      qword ptr [7FFF785477B0]
       mov       rbx,rax
       mov       ecx,1B69
       mov       rdx,7FFF785F5550
       call      qword ptr [7FFF785477B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF78327840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,111F
       mov       rdx,7FFF785F5550
       call      qword ptr [7FFF785477B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF78327840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF78A1D488]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF7892F7E0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M01_L136:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 4701
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
       push      rsi
       push      rbx
       test      rdx,rdx
       je        short M02_L02
       mov       rax,[rdx]
       cmp       rax,rcx
       je        short M02_L02
       mov       r8,2417F000038
       mov       r8,[r8]
       add       r8,10
       rorx      r10,rax,20
       xor       r10,rcx
       mov       r9,9E3779B97F4A7C15
       imul      r10,r9
       mov       r9d,[r8]
       shrx      r10,r10,r9
       xor       r9d,r9d
M02_L00:
       lea       r11d,[r10+1]
       movsxd    r11,r11d
       lea       r11,[r11+r11*2]
       lea       r11,[r8+r11*8]
       mov       ebx,[r11]
       mov       rsi,[r11+8]
       and       ebx,0FFFFFFFE
       cmp       rsi,rax
       jne       short M02_L03
       mov       rsi,rcx
       xor       rsi,[r11+10]
       cmp       rsi,1
       ja        short M02_L03
       cmp       ebx,[r11]
       jne       short M02_L04
M02_L01:
       cmp       esi,1
       jne       short M02_L05
M02_L02:
       mov       rax,rdx
       pop       rbx
       pop       rsi
       ret
M02_L03:
       test      ebx,ebx
       je        short M02_L04
       inc       r9d
       add       r10d,r9d
       and       r10d,[r8+4]
       cmp       r9d,8
       jl        short M02_L00
M02_L04:
       mov       esi,2
       jmp       short M02_L01
M02_L05:
       test      esi,esi
       jne       short M02_L06
       xor       edx,edx
       jmp       short M02_L02
M02_L06:
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFF7832D908]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny_NoCacheLookup(Void*, System.Object)
; Total bytes of code 168
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
       je        near ptr M03_L00
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M03_L00
       test      rbx,rbx
       je        near ptr M03_L03
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        near ptr M03_L03
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M03_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFFD7F99F20
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFF78325818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFF78325818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L00:
       test      rbx,rbx
       je        short M03_L01
       mov       ebp,[rbx+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M03_L02
M03_L01:
       mov       rax,28214190008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L02:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L03:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L04:
       call      qword ptr [7FFF78A15038]
       int       3
; Total bytes of code 235
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
       mov       rdx,29FBF15B598
       mov       [rsi+18],rdx
       mov       rdx,rsi
       mov       rcx,7FFF7893FD10
       call      qword ptr [7FFF78925C08]; System.Linq.Enumerable.<ToArray>g__EnumerableToArray|324_0[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FFF7853C240]
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
       mov       r11,7FFF78260918
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
       mov       rdx,7FFF78A09FB0
       call      qword ptr [7FFF7831C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       short M01_L04
M01_L06:
       lea       rcx,[rbp-188]
       mov       rdx,rdi
       mov       r8d,10
       call      qword ptr [7FFF7892FD20]
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
       mov       r11,7FFF78260920
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
       call      qword ptr [7FFF78315728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
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
       mov       rdx,7FFF78A09FF8
       call      qword ptr [7FFF7831C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M01_L09
M01_L14:
       mov       rdx,7FFF78A09A40
       call      qword ptr [7FFF78537B70]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       call      qword ptr [7FFF78487198]
       int       3
M01_L22:
       mov       rcx,rbx
       mov       rdx,7FFF78A0A030
       call      qword ptr [7FFF7831C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L16
M01_L23:
       mov       rdx,7FFF78A0A2B0
       call      qword ptr [7FFF78537B70]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L17
M01_L24:
       mov       rcx,rbx
       mov       rdx,7FFF78A0A198
       call      qword ptr [7FFF7831C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L18
M01_L25:
       mov       rdx,7FFF78A0A330
       call      qword ptr [7FFF7831C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFF783157A0]; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      00007FFFD7F31380
       cmp       dword ptr [7FFFD8253A10],0
       je        near ptr M01_L11
       jmp       near ptr M01_L40
M01_L28:
       lea       rcx,[rbp-188]
       call      qword ptr [7FFF7892FD68]
       jmp       near ptr M01_L12
M01_L29:
       call      qword ptr [7FFF7872D188]
       int       3
M01_L30:
       mov       rdx,7FFF78A09B68
       call      qword ptr [7FFF78537B70]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M01_L01
M01_L31:
       mov       rcx,rdi
       mov       rdx,7FFF78A09F98
       call      qword ptr [7FFF7831C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M01_L02
M01_L32:
       mov       ecx,11
       call      qword ptr [7FFF78537E70]
       int       3
M01_L33:
       call      qword ptr [7FFF7892FD38]
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
       mov       rdx,7FFF78A0A3C0
       call      qword ptr [7FFF7831C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M01_L36:
       lea       rcx,[rbp-1A0]
       lea       r8,[rbp-178]
       mov       r9d,1B
       call      qword ptr [7FFF7892FAF8]
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
       call      qword ptr [7FFF783157A0]; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFF7892FD50]
       jmp       near ptr M01_L11
M01_L42:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       mov       rbx,[rbp-1B8]
       test      rbx,rbx
       je        short M01_L43
       mov       rcx,rbx
       mov       r11,7FFF78260920
       call      qword ptr [r11]
M01_L43:
       nop
       add       rsp,28
       ret
; Total bytes of code 1401
```

