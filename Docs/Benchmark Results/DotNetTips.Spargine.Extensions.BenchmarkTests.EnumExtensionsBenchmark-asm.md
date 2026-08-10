## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumExtensionsBenchmark.GetItems()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       ecx,[rbx+198]
       call      qword ptr [7FF8E479E088]; DotNetTips.Spargine.Extensions.EnumExtensions.GetItems[[System.StringComparison, System.Private.CoreLib]](System.StringComparison)
       mov       [rsp+28],rax
       mov       rbx,[rbx+88]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       ret
; Total bytes of code 65
```
```assembly
; DotNetTips.Spargine.Extensions.EnumExtensions.GetItems[[System.StringComparison, System.Private.CoreLib]](System.StringComparison)
; 			var enumValues = Enum.GetValues<TEnum>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var enumNames = Enum.GetNames<TEnum>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var items = new List<(string Description, int Value)>(enumValues.Length);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			for (var index = 0; index < enumValues.Length; index++)
; 			     ^^^^^^^^^^^^^
; 				items.Add((
; 				^^^^^^^^^^^
; 					Description: enumNames[index],
; 					                              
; 					Value: Convert.ToInt32(enumValues[index], CultureInfo.InvariantCulture)));
; 					                                                                          
; 			return items.ToReadOnlyCollection();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+38],rax
       mov       [rsp+40],rax
M01_L00:
       mov       rbx,268E0EF0AA0
       mov       rcx,offset MT_System.StringComparison
       call      00007FF943DAE010
       add       eax,0FFFFFFFD
       cmp       eax,5
       jne       near ptr M01_L25
       mov       rcx,2284BA71158
       mov       rax,[rcx]
       test      rax,rax
       je        near ptr M01_L51
M01_L01:
       mov       rcx,[rax+80]
       test      rcx,rcx
       je        near ptr M01_L24
       mov       rdx,offset MT_System.Enum+EnumInfo<System.UInt32>
       cmp       [rcx],rdx
       je        short M01_L02
       mov       rdx,offset MT_System.RuntimeType+CompositeCacheEntry
       cmp       [rcx],rdx
       jne       near ptr M01_L24
       mov       rax,[rcx+28]
       jmp       short M01_L03
M01_L02:
       mov       rax,rcx
M01_L03:
       test      rax,rax
       je        near ptr M01_L52
M01_L04:
       mov       rsi,[rax+8]
M01_L05:
       mov       edx,[rsi+8]
       test      edx,edx
       jl        near ptr M01_L114
       mov       ebx,edx
       mov       edx,ebx
       mov       rcx,offset MT_System.StringComparison[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rdi,rax
       mov       rbp,[rsi]
       mov       rcx,rbp
       cmp       rcx,[rdi]
       je        near ptr M01_L101
M01_L06:
       mov       rcx,rbp
       mov       eax,[rcx+4]
       add       eax,0FFFFFFE8
       shr       eax,3
       mov       ecx,eax
       test      ecx,ecx
       jne       near ptr M01_L16
       xor       r14d,r14d
M01_L07:
       mov       rcx,[rdi]
       mov       edx,[rcx+4]
       add       edx,0FFFFFFE8
       shr       edx,3
       mov       ecx,edx
       test      ecx,ecx
       jne       near ptr M01_L17
       xor       r15d,r15d
M01_L08:
       cmp       rbp,[rdi]
       je        short M01_L09
       mov       ecx,eax
       mov       r8d,1
       test      ecx,ecx
       cmove     ecx,r8d
       mov       r8d,edx
       mov       r10d,1
       test      r8d,r8d
       cmove     r8d,r10d
       cmp       ecx,r8d
       jne       near ptr M01_L103
M01_L09:
       test      ebx,ebx
       jl        near ptr M01_L104
       test      eax,eax
       jne       near ptr M01_L18
       xor       r13d,r13d
M01_L10:
       cmp       r14d,r13d
       jl        near ptr M01_L105
       sub       r14d,r13d
       js        near ptr M01_L106
       lea       ecx,[r14+rbx]
       cmp       ecx,[rsi+8]
       ja        near ptr M01_L106
       test      edx,edx
       jne       near ptr M01_L19
       xor       r13d,r13d
M01_L11:
       cmp       r15d,r13d
       jl        near ptr M01_L107
       sub       r15d,r13d
       js        near ptr M01_L108
       lea       ecx,[r15+rbx]
       cmp       ecx,[rdi+8]
       ja        near ptr M01_L108
       cmp       rbp,[rdi]
       je        short M01_L12
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FF8E4796220]; System.Array.CanAssignArrayType(System.Array, System.Array)
       test      eax,eax
       jne       near ptr M01_L110
M01_L12:
       mov       rcx,rbp
       movzx     edx,word ptr [rcx]
       mov       r8d,ebx
       imul      r8,rdx
       lea       rax,[rsi+8]
       mov       r10d,[rbp+4]
       add       r10,0FFFFFFFFFFFFFFF0
       add       rax,r10
       mov       r10d,r14d
       imul      r10,rdx
       add       r10,rax
       lea       rax,[rdi+8]
       mov       r9,[rdi]
       mov       r9d,[r9+4]
       add       r9,0FFFFFFFFFFFFFFF0
       add       rax,r9
       mov       r9d,r15d
       imul      rdx,r9
       add       rdx,rax
       test      dword ptr [rcx],1000000
       jne       near ptr M01_L109
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FF8E4165818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L13:
       call      qword ptr [7FF8E479E160]; System.Enum.GetNames[[System.StringComparison, System.Private.CoreLib]]()
       mov       r13,rax
       mov       rcx,offset MT_System.Collections.Generic.List<System.ValueTuple<System.String, System.Int32>>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       esi,[rdi+8]
       mov       edx,esi
       test      edx,edx
       je        near ptr M01_L111
       movsxd    rdx,edx
       mov       rcx,offset MT_System.ValueTuple<System.String, System.Int32>[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M01_L14:
       xor       ebp,ebp
       cmp       esi,ebp
       jg        near ptr M01_L23
M01_L15:
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<System.ValueTuple<System.String, System.Int32>>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rsi
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
M01_L16:
       movsxd    rcx,ecx
       mov       r14d,[rsi+rcx*4+10]
       jmp       near ptr M01_L07
M01_L17:
       movsxd    rcx,ecx
       mov       r15d,[rdi+rcx*4+10]
       jmp       near ptr M01_L08
M01_L18:
       movsxd    rcx,eax
       mov       r13d,[rsi+rcx*4+10]
       jmp       near ptr M01_L10
M01_L19:
       movsxd    rcx,edx
       mov       r13d,[rdi+rcx*4+10]
       jmp       near ptr M01_L11
M01_L20:
       xor       r15d,r15d
M01_L21:
       inc       dword ptr [rbx+14]
       mov       rcx,[rbx+8]
       mov       edx,[rbx+10]
       mov       eax,[rcx+8]
       cmp       eax,edx
       jbe       near ptr M01_L112
       lea       r8d,[rdx+1]
       mov       [rbx+10],r8d
       cmp       edx,eax
       jae       near ptr M01_L113
       shl       rdx,4
       lea       r12,[rcx+rdx+10]
       mov       rcx,r12
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       [r12+8],r15d
M01_L22:
       add       ebp,1
       jo        near ptr M01_L114
       cmp       esi,ebp
       jle       near ptr M01_L15
M01_L23:
       mov       rcx,offset MT_System.StringComparison
       call      CORINFO_HELP_NEWSFAST
       mov       rcx,rax
       cmp       ebp,[r13+8]
       jae       near ptr M01_L113
       mov       r14,[r13+rbp*8+10]
       cmp       ebp,esi
       jae       near ptr M01_L113
       mov       eax,[rdi+rbp*4+10]
       mov       [rcx+8],eax
       call      qword ptr [7FF8E479E388]; System.Enum.GetValue()
       test      rax,rax
       je        near ptr M01_L20
       mov       rdx,rax
       mov       rcx,offset MT_System.IConvertible
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastInterface(Void*, System.Object)
       mov       rcx,rax
       mov       r11,7FF8E40B0AC8
       xor       edx,edx
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       near ptr M01_L21
M01_L24:
       xor       eax,eax
       jmp       near ptr M01_L03
M01_L25:
       cmp       eax,16
       ja        short M01_L26
       mov       ecx,eax
       lea       rax,[7FF8E4874590]
       mov       eax,[rax+rcx*4]
       lea       rdx,[M01_L00]
       add       rax,rdx
       jmp       rax
M01_L26:
       call      qword ptr [7FF8E479E2C8]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
       mov       rcx,2284BA71158
       mov       rax,[rcx]
       test      rax,rax
       je        short M01_L27
       jmp       short M01_L28
M01_L27:
       mov       rcx,rbx
       call      qword ptr [7FF8E4167C30]; System.RuntimeType.InitializeCache()
M01_L28:
       mov       rsi,[rax+80]
       test      rsi,rsi
       je        short M01_L30
       mov       rdx,rsi
       mov       rcx,offset MT_System.Enum+EnumInfo<System.Byte>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M01_L29
       jmp       short M01_L31
M01_L29:
       mov       rdx,rsi
       mov       rcx,offset MT_System.RuntimeType+CompositeCacheEntry
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M01_L30
       mov       rax,[rax+28]
       jmp       short M01_L31
M01_L30:
       xor       eax,eax
M01_L31:
       test      rax,rax
       jne       short M01_L32
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF8E481CA20]
M01_L32:
       mov       rsi,[rax+8]
       jmp       near ptr M01_L05
       mov       rcx,2284BA71158
       mov       rax,[rcx]
       test      rax,rax
       je        short M01_L33
       jmp       short M01_L34
M01_L33:
       mov       rcx,rbx
       call      qword ptr [7FF8E4167C30]; System.RuntimeType.InitializeCache()
M01_L34:
       mov       rsi,[rax+80]
       test      rsi,rsi
       je        short M01_L36
       mov       rdx,rsi
       mov       rcx,offset MT_System.Enum+EnumInfo<System.Byte>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M01_L35
       jmp       short M01_L37
M01_L35:
       mov       rdx,rsi
       mov       rcx,offset MT_System.RuntimeType+CompositeCacheEntry
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M01_L36
       mov       rax,[rax+28]
       jmp       short M01_L37
M01_L36:
       xor       eax,eax
M01_L37:
       test      rax,rax
       jne       short M01_L38
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF8E481CA20]
M01_L38:
       mov       rsi,[rax+8]
       jmp       near ptr M01_L05
       mov       rcx,2284BA71158
       mov       rax,[rcx]
       test      rax,rax
       je        short M01_L39
       jmp       short M01_L40
M01_L39:
       mov       rcx,rbx
       call      qword ptr [7FF8E4167C30]; System.RuntimeType.InitializeCache()
M01_L40:
       mov       rsi,[rax+80]
       test      rsi,rsi
       je        short M01_L42
       mov       rdx,rsi
       mov       rcx,offset MT_System.Enum+EnumInfo<System.UInt16>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M01_L41
       jmp       short M01_L43
M01_L41:
       mov       rdx,rsi
       mov       rcx,offset MT_System.RuntimeType+CompositeCacheEntry
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M01_L42
       mov       rax,[rax+28]
       jmp       short M01_L43
M01_L42:
       xor       eax,eax
M01_L43:
       test      rax,rax
       jne       short M01_L44
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF8E481CAB0]
M01_L44:
       mov       rsi,[rax+8]
       jmp       near ptr M01_L05
       mov       rcx,2284BA71158
       mov       rax,[rcx]
       test      rax,rax
       je        short M01_L45
       jmp       short M01_L46
M01_L45:
       mov       rcx,rbx
       call      qword ptr [7FF8E4167C30]; System.RuntimeType.InitializeCache()
M01_L46:
       mov       rsi,[rax+80]
       test      rsi,rsi
       je        short M01_L48
       mov       rdx,rsi
       mov       rcx,offset MT_System.Enum+EnumInfo<System.UInt16>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M01_L47
       jmp       short M01_L49
M01_L47:
       mov       rdx,rsi
       mov       rcx,offset MT_System.RuntimeType+CompositeCacheEntry
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M01_L48
       mov       rax,[rax+28]
       jmp       short M01_L49
M01_L48:
       xor       eax,eax
M01_L49:
       test      rax,rax
       jne       short M01_L50
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF8E481CAB0]
M01_L50:
       mov       rsi,[rax+8]
       jmp       near ptr M01_L05
M01_L51:
       mov       rcx,rbx
       call      qword ptr [7FF8E4167C30]; System.RuntimeType.InitializeCache()
       jmp       near ptr M01_L01
M01_L52:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF8E438EAF0]; System.Enum.<GetEnumInfo>g__InitializeEnumInfo|5_0[[System.UInt32, System.Private.CoreLib]](System.RuntimeType, Boolean)
       jmp       near ptr M01_L04
       mov       rcx,2284BA71158
       mov       rax,[rcx]
       test      rax,rax
       je        short M01_L53
       jmp       short M01_L54
M01_L53:
       mov       rcx,rbx
       call      qword ptr [7FF8E4167C30]; System.RuntimeType.InitializeCache()
M01_L54:
       mov       rsi,[rax+80]
       test      rsi,rsi
       je        short M01_L56
       mov       rdx,rsi
       mov       rcx,offset MT_System.Enum+EnumInfo<System.UInt32>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M01_L55
       jmp       short M01_L57
M01_L55:
       mov       rdx,rsi
       mov       rcx,offset MT_System.RuntimeType+CompositeCacheEntry
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M01_L56
       mov       rax,[rax+28]
       jmp       short M01_L57
M01_L56:
       xor       eax,eax
M01_L57:
       test      rax,rax
       jne       short M01_L58
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF8E438EAF0]; System.Enum.<GetEnumInfo>g__InitializeEnumInfo|5_0[[System.UInt32, System.Private.CoreLib]](System.RuntimeType, Boolean)
M01_L58:
       mov       rsi,[rax+8]
       jmp       near ptr M01_L05
       mov       rcx,2284BA71158
       mov       rax,[rcx]
       test      rax,rax
       je        short M01_L59
       jmp       short M01_L60
M01_L59:
       mov       rcx,rbx
       call      qword ptr [7FF8E4167C30]; System.RuntimeType.InitializeCache()
M01_L60:
       mov       rsi,[rax+80]
       test      rsi,rsi
       je        short M01_L62
       mov       rdx,rsi
       mov       rcx,offset MT_System.Enum+EnumInfo<System.UInt64>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M01_L61
       jmp       short M01_L63
M01_L61:
       mov       rdx,rsi
       mov       rcx,offset MT_System.RuntimeType+CompositeCacheEntry
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M01_L62
       mov       rax,[rax+28]
       jmp       short M01_L63
M01_L62:
       xor       eax,eax
M01_L63:
       test      rax,rax
       jne       short M01_L64
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF8E481CB28]
M01_L64:
       mov       rsi,[rax+8]
       jmp       near ptr M01_L05
       mov       rcx,2284BA71158
       mov       rax,[rcx]
       test      rax,rax
       je        short M01_L65
       jmp       short M01_L66
M01_L65:
       mov       rcx,rbx
       call      qword ptr [7FF8E4167C30]; System.RuntimeType.InitializeCache()
M01_L66:
       mov       rsi,[rax+80]
       test      rsi,rsi
       je        short M01_L68
       mov       rdx,rsi
       mov       rcx,offset MT_System.Enum+EnumInfo<System.UInt64>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M01_L67
       jmp       short M01_L69
M01_L67:
       mov       rdx,rsi
       mov       rcx,offset MT_System.RuntimeType+CompositeCacheEntry
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M01_L68
       mov       rax,[rax+28]
       jmp       short M01_L69
M01_L68:
       xor       eax,eax
M01_L69:
       test      rax,rax
       jne       short M01_L70
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF8E481CB28]
M01_L70:
       mov       rsi,[rax+8]
       jmp       near ptr M01_L05
       mov       rcx,2284BA71158
       mov       rax,[rcx]
       test      rax,rax
       je        short M01_L71
       jmp       short M01_L72
M01_L71:
       mov       rcx,rbx
       call      qword ptr [7FF8E4167C30]; System.RuntimeType.InitializeCache()
M01_L72:
       mov       rsi,[rax+80]
       test      rsi,rsi
       je        short M01_L74
       mov       rdx,rsi
       mov       rcx,offset MT_System.Enum+EnumInfo<System.UIntPtr>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M01_L73
       jmp       short M01_L75
M01_L73:
       mov       rdx,rsi
       mov       rcx,offset MT_System.RuntimeType+CompositeCacheEntry
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M01_L74
       mov       rax,[rax+28]
       jmp       short M01_L75
M01_L74:
       xor       eax,eax
M01_L75:
       test      rax,rax
       jne       short M01_L76
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF8E481CB88]
M01_L76:
       mov       rsi,[rax+8]
       jmp       near ptr M01_L05
       mov       rcx,2284BA71158
       mov       rax,[rcx]
       test      rax,rax
       je        short M01_L77
       jmp       short M01_L78
M01_L77:
       mov       rcx,rbx
       call      qword ptr [7FF8E4167C30]; System.RuntimeType.InitializeCache()
M01_L78:
       mov       rsi,[rax+80]
       test      rsi,rsi
       je        short M01_L80
       mov       rdx,rsi
       mov       rcx,offset MT_System.Enum+EnumInfo<System.UIntPtr>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M01_L79
       jmp       short M01_L81
M01_L79:
       mov       rdx,rsi
       mov       rcx,offset MT_System.RuntimeType+CompositeCacheEntry
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M01_L80
       mov       rax,[rax+28]
       jmp       short M01_L81
M01_L80:
       xor       eax,eax
M01_L81:
       test      rax,rax
       jne       short M01_L82
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF8E481CB88]
M01_L82:
       mov       rsi,[rax+8]
       jmp       near ptr M01_L05
       mov       rcx,2284BA71158
       mov       rax,[rcx]
       test      rax,rax
       je        short M01_L83
       jmp       short M01_L84
M01_L83:
       mov       rcx,rbx
       call      qword ptr [7FF8E4167C30]; System.RuntimeType.InitializeCache()
M01_L84:
       mov       rsi,[rax+80]
       test      rsi,rsi
       je        short M01_L86
       mov       rdx,rsi
       mov       rcx,offset MT_System.Enum+EnumInfo<System.Single>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M01_L85
       jmp       short M01_L87
M01_L85:
       mov       rdx,rsi
       mov       rcx,offset MT_System.RuntimeType+CompositeCacheEntry
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M01_L86
       mov       rax,[rax+28]
       jmp       short M01_L87
M01_L86:
       xor       eax,eax
M01_L87:
       test      rax,rax
       jne       short M01_L88
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF8E481CBE8]
M01_L88:
       mov       rsi,[rax+8]
       jmp       near ptr M01_L05
       mov       rcx,2284BA71158
       mov       rax,[rcx]
       test      rax,rax
       je        short M01_L89
       jmp       short M01_L90
M01_L89:
       mov       rcx,rbx
       call      qword ptr [7FF8E4167C30]; System.RuntimeType.InitializeCache()
M01_L90:
       mov       rsi,[rax+80]
       test      rsi,rsi
       je        short M01_L92
       mov       rdx,rsi
       mov       rcx,offset MT_System.Enum+EnumInfo<System.Double>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M01_L91
       jmp       short M01_L93
M01_L91:
       mov       rdx,rsi
       mov       rcx,offset MT_System.RuntimeType+CompositeCacheEntry
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M01_L92
       mov       rax,[rax+28]
       jmp       short M01_L93
M01_L92:
       xor       eax,eax
M01_L93:
       test      rax,rax
       jne       short M01_L94
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF8E481CC48]
M01_L94:
       mov       rsi,[rax+8]
       jmp       near ptr M01_L05
       mov       rcx,2284BA71158
       mov       rax,[rcx]
       test      rax,rax
       je        short M01_L95
       jmp       short M01_L96
M01_L95:
       mov       rcx,rbx
       call      qword ptr [7FF8E4167C30]; System.RuntimeType.InitializeCache()
M01_L96:
       mov       rcx,[rax+80]
       test      rcx,rcx
       je        short M01_L98
       mov       rdx,[rcx]
       mov       rax,offset MT_System.Enum+EnumInfo<System.Char>
       cmp       rdx,rax
       jne       short M01_L97
       mov       rax,rcx
       jmp       short M01_L99
M01_L97:
       mov       rax,offset MT_System.RuntimeType+CompositeCacheEntry
       cmp       rdx,rax
       jne       short M01_L98
       mov       rax,[rcx+28]
       jmp       short M01_L99
M01_L98:
       xor       eax,eax
M01_L99:
       test      rax,rax
       jne       short M01_L100
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF8E481CCA8]
M01_L100:
       mov       rsi,[rax+8]
       jmp       near ptr M01_L05
M01_L101:
       cmp       dword ptr [rcx+4],18
       jne       near ptr M01_L06
       cmp       ebx,[rsi+8]
       ja        near ptr M01_L06
       cmp       ebx,[rdi+8]
       ja        near ptr M01_L06
       mov       r8d,ebx
       movzx     edx,word ptr [rcx]
       imul      r8,rdx
       lea       rdx,[rsi+10]
       lea       rax,[rdi+10]
       test      dword ptr [rcx],1000000
       je        short M01_L102
       mov       rcx,rax
       call      qword ptr [7FF8E41657A0]; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L13
M01_L102:
       mov       rcx,rax
       call      qword ptr [7FF8E4165818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L13
M01_L103:
       mov       rcx,offset MT_System.RankException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF8E481CD50]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8E481CD68]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L104:
       mov       ecx,0B3
       mov       rdx,7FF8E40A4000
       call      qword ptr [7FF8E4387798]
       mov       rdx,rax
       mov       ecx,ebx
       call      qword ptr [7FF8E4814E40]
       int       3
M01_L105:
       mov       ecx,167
       mov       rdx,7FF8E40A4000
       call      qword ptr [7FF8E4387798]
       mov       r8,rax
       mov       edx,r13d
       mov       ecx,r14d
       call      qword ptr [7FF8E481CD08]
       int       3
M01_L106:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF8E481CD80]
       mov       rsi,rax
       mov       ecx,12D
       mov       rdx,7FF8E40A4000
       call      qword ptr [7FF8E4387798]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF8E44F6E50]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L107:
       mov       ecx,17F
       mov       rdx,7FF8E40A4000
       call      qword ptr [7FF8E4387798]
       mov       r8,rax
       mov       edx,r13d
       mov       ecx,r15d
       call      qword ptr [7FF8E481CD08]
       int       3
M01_L108:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF8E481CD98]
       mov       rsi,rax
       mov       ecx,145
       mov       rdx,7FF8E40A4000
       call      qword ptr [7FF8E4387798]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF8E44F6E50]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L109:
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FF8E41657A0]; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L13
M01_L110:
       mov       [rsp+20],ebx
       mov       [rsp+28],eax
       mov       rcx,rsi
       mov       edx,r14d
       mov       r8,rdi
       mov       r9d,r15d
       call      qword ptr [7FF8E481CDE0]
       jmp       near ptr M01_L13
M01_L111:
       mov       rcx,offset MT_System.Collections.Generic.List<System.ValueTuple<System.String, System.Int32>>
       call      qword ptr [7FF8E4165728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,22862000278
       mov       rdx,[rcx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L14
M01_L112:
       mov       [rsp+38],r14
       mov       [rsp+40],r15d
       lea       rdx,[rsp+38]
       mov       rcx,rbx
       call      qword ptr [7FF8E481C888]
       jmp       near ptr M01_L22
M01_L113:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M01_L114:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 2924
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumExtensionsBenchmark.GetItemsGeneric()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+30],ymm4
       xor       eax,eax
       mov       [rsp+50],rax
       mov       rbx,rcx
M00_L00:
       mov       rsi,1A88B560AA0
       mov       rcx,offset MT_System.StringComparison
       call      00007FF943DAE010
       add       eax,0FFFFFFFD
       cmp       eax,5
       jne       near ptr M00_L10
       mov       rcx,167F6041158
       mov       rax,[rcx]
       test      rax,rax
       je        near ptr M00_L36
M00_L01:
       mov       rcx,[rax+80]
       test      rcx,rcx
       je        near ptr M00_L08
       mov       rdx,offset MT_System.Enum+EnumInfo<System.UInt32>
       cmp       [rcx],rdx
       je        short M00_L02
       mov       rdx,offset MT_System.RuntimeType+CompositeCacheEntry
       cmp       [rcx],rdx
       jne       near ptr M00_L08
       mov       rax,[rcx+28]
       jmp       short M00_L03
M00_L02:
       mov       rax,rcx
M00_L03:
       test      rax,rax
       je        near ptr M00_L37
M00_L04:
       mov       rdi,[rax+8]
M00_L05:
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FF8E4796490]; System.Array.get_Length()
       movsxd    rdx,eax
       mov       rcx,offset MT_System.StringComparison[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rsi,rax
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FF8E4796490]; System.Array.get_Length()
       mov       r8d,eax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF8E42D5050]; System.Array.Copy(System.Array, System.Array, Int32)
       call      qword ptr [7FF8E479E418]; System.Enum.GetNames[[System.StringComparison, System.Private.CoreLib]]()
       mov       rdi,rax
       mov       rcx,offset MT_System.Collections.Generic.List<System.ValueTuple<System.String, System.Int32>>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       r14d,[rsi+8]
       mov       edx,r14d
       mov       rcx,rbp
       call      qword ptr [7FF8E479E478]; System.Collections.Generic.List`1[[System.ValueTuple`2[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]], System.Private.CoreLib]]..ctor(Int32)
       xor       r15d,r15d
       test      r14d,r14d
       jle       near ptr M00_L07
       test      rdi,rdi
       je        near ptr M00_L09
       cmp       [rdi+8],r14d
       jl        near ptr M00_L09
       mov       r13,offset MT_System.StringComparison
       mov       rcx,167F6400100
       mov       r12,[rcx]
       mov       rax,offset MT_System.ValueTuple<System.String, System.Int32>
       mov       [rsp+28],rax
M00_L06:
       mov       rcx,r13
       call      CORINFO_HELP_NEWSFAST
       mov       ecx,r15d
       mov       r8,[rdi+rcx*8+10]
       mov       [rsp+20],r8
       mov       ecx,[rsi+rcx*4+10]
       mov       [rax+8],ecx
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+48],xmm0
       mov       rcx,rax
       mov       rdx,r12
       call      qword ptr [7FF8E479E490]; System.Convert.ToInt32(System.Object, System.IFormatProvider)
       mov       r9d,eax
       lea       rcx,[rsp+48]
       mov       r8,[rsp+20]
       mov       rdx,[rsp+28]
       call      qword ptr [7FF8E468DC20]; System.ValueTuple`2[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]]..ctor(System.__Canon, Int32)
       vmovdqu   xmm0,xmmword ptr [rsp+48]
       vmovdqu   xmmword ptr [rsp+30],xmm0
       lea       rdx,[rsp+30]
       mov       rcx,rbp
       call      qword ptr [7FF8E47FC578]; System.Collections.Generic.List`1[[System.ValueTuple`2[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]], System.Private.CoreLib]].Add(System.ValueTuple`2<System.__Canon,Int32>)
       add       r15d,1
       jo        near ptr M00_L50
       cmp       r14d,r15d
       jg        short M00_L06
M00_L07:
       mov       rdx,rbp
       mov       rcx,7FF8E47FCD20
       call      qword ptr [7FF8E479E448]; DotNetTips.Spargine.Extensions.EnumerableExtensions.ToReadOnlyCollection[[System.ValueTuple`2[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.ValueTuple`2<System.__Canon,Int32>>)
       mov       [rsp+40],rax
       mov       rcx,[rbx+88]
       lea       r8,[rsp+40]
       mov       rdx,7FF8E47FF5C0
       cmp       [rcx],ecx
       call      qword ptr [7FF8E479E6E8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L08:
       xor       eax,eax
       jmp       near ptr M00_L03
M00_L09:
       mov       r13,offset MT_System.StringComparison
       mov       rcx,r13
       call      CORINFO_HELP_NEWSFAST
       cmp       r15d,[rdi+8]
       jae       near ptr M00_L49
       mov       ecx,r15d
       mov       r8,[rdi+rcx*8+10]
       mov       r13,r8
       cmp       r15d,r14d
       jae       near ptr M00_L49
       mov       ecx,r15d
       mov       ecx,[rsi+rcx*4+10]
       mov       [rax+8],ecx
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+48],xmm0
       mov       rcx,rax
       mov       rdx,167F6400100
       mov       r12,[rdx]
       mov       rdx,r12
       call      qword ptr [7FF8E479E490]; System.Convert.ToInt32(System.Object, System.IFormatProvider)
       mov       r9d,eax
       lea       rcx,[rsp+48]
       mov       r8,r13
       mov       rdx,offset MT_System.ValueTuple<System.String, System.Int32>
       mov       r13,rdx
       call      qword ptr [7FF8E468DC20]; System.ValueTuple`2[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]]..ctor(System.__Canon, Int32)
       vmovdqu   xmm0,xmmword ptr [rsp+48]
       vmovdqu   xmmword ptr [rsp+30],xmm0
       lea       rdx,[rsp+30]
       mov       rcx,rbp
       call      qword ptr [7FF8E47FC578]; System.Collections.Generic.List`1[[System.ValueTuple`2[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]], System.Private.CoreLib]].Add(System.ValueTuple`2<System.__Canon,Int32>)
       add       r15d,1
       jo        near ptr M00_L50
       cmp       r14d,r15d
       jg        near ptr M00_L09
       jmp       near ptr M00_L07
M00_L10:
       cmp       eax,16
       ja        short M00_L11
       mov       ecx,eax
       lea       rdx,[7FF8E4219600]
       mov       edx,[rdx+rcx*4]
       lea       rax,[M00_L00]
       add       rdx,rax
       jmp       rdx
M00_L11:
       call      qword ptr [7FF8E479E580]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
       mov       rcx,167F6041158
       mov       rax,[rcx]
       test      rax,rax
       je        short M00_L12
       jmp       short M00_L13
M00_L12:
       mov       rcx,rsi
       call      qword ptr [7FF8E4167C30]; System.RuntimeType.InitializeCache()
M00_L13:
       mov       rdi,[rax+80]
       test      rdi,rdi
       je        short M00_L15
       mov       rdx,rdi
       mov       rcx,offset MT_System.Enum+EnumInfo<System.Byte>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M00_L14
       jmp       short M00_L16
M00_L14:
       mov       rdx,rdi
       mov       rcx,offset MT_System.RuntimeType+CompositeCacheEntry
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M00_L15
       mov       rax,[rax+28]
       jmp       short M00_L16
M00_L15:
       xor       eax,eax
M00_L16:
       test      rax,rax
       jne       short M00_L17
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FF8E4825AD0]
M00_L17:
       mov       rdi,[rax+8]
       jmp       near ptr M00_L05
       mov       rcx,167F6041158
       mov       rax,[rcx]
       test      rax,rax
       je        short M00_L18
       jmp       short M00_L19
M00_L18:
       mov       rcx,rsi
       call      qword ptr [7FF8E4167C30]; System.RuntimeType.InitializeCache()
M00_L19:
       mov       rdi,[rax+80]
       test      rdi,rdi
       je        short M00_L21
       mov       rdx,rdi
       mov       rcx,offset MT_System.Enum+EnumInfo<System.Byte>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M00_L20
       jmp       short M00_L22
M00_L20:
       mov       rdx,rdi
       mov       rcx,offset MT_System.RuntimeType+CompositeCacheEntry
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M00_L21
       mov       rax,[rax+28]
       jmp       short M00_L22
M00_L21:
       xor       eax,eax
M00_L22:
       test      rax,rax
       jne       short M00_L23
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FF8E4825AD0]
M00_L23:
       mov       rdi,[rax+8]
       jmp       near ptr M00_L05
       mov       rcx,167F6041158
       mov       rax,[rcx]
       test      rax,rax
       je        short M00_L24
       jmp       short M00_L25
M00_L24:
       mov       rcx,rsi
       call      qword ptr [7FF8E4167C30]; System.RuntimeType.InitializeCache()
M00_L25:
       mov       rdi,[rax+80]
       test      rdi,rdi
       je        short M00_L27
       mov       rdx,rdi
       mov       rcx,offset MT_System.Enum+EnumInfo<System.UInt16>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M00_L26
       jmp       short M00_L28
M00_L26:
       mov       rdx,rdi
       mov       rcx,offset MT_System.RuntimeType+CompositeCacheEntry
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M00_L27
       mov       rax,[rax+28]
       jmp       short M00_L28
M00_L27:
       xor       eax,eax
M00_L28:
       test      rax,rax
       jne       short M00_L29
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FF8E4825B60]
M00_L29:
       mov       rdi,[rax+8]
       jmp       near ptr M00_L05
       mov       rcx,167F6041158
       mov       rax,[rcx]
       test      rax,rax
       je        short M00_L30
       jmp       short M00_L31
M00_L30:
       mov       rcx,rsi
       call      qword ptr [7FF8E4167C30]; System.RuntimeType.InitializeCache()
M00_L31:
       mov       rdi,[rax+80]
       test      rdi,rdi
       je        short M00_L33
       mov       rdx,rdi
       mov       rcx,offset MT_System.Enum+EnumInfo<System.UInt16>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M00_L32
       jmp       short M00_L34
M00_L32:
       mov       rdx,rdi
       mov       rcx,offset MT_System.RuntimeType+CompositeCacheEntry
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M00_L33
       mov       rax,[rax+28]
       jmp       short M00_L34
M00_L33:
       xor       eax,eax
M00_L34:
       test      rax,rax
       jne       short M00_L35
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FF8E4825B60]
M00_L35:
       mov       rdi,[rax+8]
       jmp       near ptr M00_L05
M00_L36:
       mov       rcx,rsi
       call      qword ptr [7FF8E4167C30]; System.RuntimeType.InitializeCache()
       jmp       near ptr M00_L01
M00_L37:
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FF8E438DE48]; System.Enum.<GetEnumInfo>g__InitializeEnumInfo|5_0[[System.UInt32, System.Private.CoreLib]](System.RuntimeType, Boolean)
       jmp       near ptr M00_L04
       mov       rcx,167F6041158
       mov       rax,[rcx]
       test      rax,rax
       je        short M00_L38
       jmp       short M00_L39
M00_L38:
       mov       rcx,rsi
       call      qword ptr [7FF8E4167C30]; System.RuntimeType.InitializeCache()
M00_L39:
       mov       rdi,[rax+80]
       test      rdi,rdi
       je        short M00_L41
       mov       rdx,rdi
       mov       rcx,offset MT_System.Enum+EnumInfo<System.UInt32>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M00_L40
       jmp       short M00_L42
M00_L40:
       mov       rdx,rdi
       mov       rcx,offset MT_System.RuntimeType+CompositeCacheEntry
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M00_L41
       mov       rax,[rax+28]
       jmp       short M00_L42
M00_L41:
       xor       eax,eax
M00_L42:
       test      rax,rax
       jne       short M00_L43
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FF8E438DE48]; System.Enum.<GetEnumInfo>g__InitializeEnumInfo|5_0[[System.UInt32, System.Private.CoreLib]](System.RuntimeType, Boolean)
M00_L43:
       mov       rdi,[rax+8]
       jmp       near ptr M00_L05
       mov       rcx,rsi
       call      qword ptr [7FF8E416C570]; System.RuntimeType.get_Cache()
       mov       rdi,[rax+80]
       test      rdi,rdi
       je        short M00_L45
       mov       rdx,rdi
       mov       rcx,offset MT_System.Enum+EnumInfo<System.UInt64>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M00_L44
       jmp       short M00_L46
M00_L44:
       mov       rdx,rdi
       mov       rcx,offset MT_System.RuntimeType+CompositeCacheEntry
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M00_L45
       mov       rax,[rax+28]
       jmp       short M00_L46
M00_L45:
       xor       eax,eax
M00_L46:
       test      rax,rax
       jne       short M00_L47
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FF8E4825BD8]
M00_L47:
       mov       rdi,[rax+8]
       jmp       near ptr M00_L05
       mov       rcx,offset MT_System.RuntimeType+IGenericCacheEntry<System.Enum+EnumInfo<System.UInt64>>
       mov       rdx,rsi
       call      qword ptr [7FF8E4826850]
       test      rax,rax
       jne       short M00_L48
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FF8E4825BD8]
M00_L48:
       mov       rdi,[rax+8]
       jmp       near ptr M00_L05
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FF8E479E520]
       mov       rdi,[rax+8]
       jmp       near ptr M00_L05
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FF8E479E568]
       mov       rdi,[rax+8]
       jmp       near ptr M00_L05
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FF8E479E550]
       mov       rdi,[rax+8]
       jmp       near ptr M00_L05
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FF8E479E538]
       mov       rdi,[rax+8]
       jmp       near ptr M00_L05
M00_L49:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L50:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 1626
```
```assembly
; System.Array.get_Length()
       sub       rsp,28
       mov       eax,[rcx+8]
       test      eax,eax
       jl        short M01_L00
       add       rsp,28
       ret
M01_L00:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 22
```
```assembly
; System.Array.Copy(System.Array, System.Array, Int32)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       ebx,r8d
       test      rcx,rcx
       je        near ptr M02_L13
       test      rdx,rdx
       je        short M02_L00
       mov       r8,[rcx]
       cmp       r8,[rdx]
       je        near ptr M02_L18
M02_L00:
       mov       rax,[rcx]
       mov       eax,[rax+4]
       add       eax,0FFFFFFE8
       shr       eax,3
       jne       near ptr M02_L12
       xor       esi,esi
M02_L01:
       mov       rdi,rcx
M02_L02:
       test      rdx,rdx
       je        near ptr M02_L15
       mov       rcx,[rdx]
       mov       ecx,[rcx+4]
       add       ecx,0FFFFFFE8
       shr       ecx,3
       jne       near ptr M02_L14
       xor       ebp,ebp
M02_L03:
       mov       r14,rdx
M02_L04:
       test      rdi,rdi
       je        near ptr M02_L20
       test      r14,r14
       je        near ptr M02_L21
       mov       r15,[rdi]
       mov       r13,[r14]
       cmp       r15,r13
       je        short M02_L05
       mov       rcx,r15
       mov       ecx,[rcx+4]
       add       ecx,0FFFFFFE8
       shr       ecx,3
       mov       eax,1
       test      ecx,ecx
       cmove     ecx,eax
       mov       rax,r13
       mov       eax,[rax+4]
       add       eax,0FFFFFFE8
       shr       eax,3
       mov       edx,1
       test      eax,eax
       cmove     eax,edx
       cmp       ecx,eax
       jne       near ptr M02_L22
M02_L05:
       test      ebx,ebx
       jl        near ptr M02_L23
       mov       rcx,r15
       mov       ecx,[rcx+4]
       add       ecx,0FFFFFFE8
       shr       ecx,3
       jne       near ptr M02_L16
       xor       r12d,r12d
M02_L06:
       cmp       esi,r12d
       jl        near ptr M02_L24
       sub       esi,r12d
       js        near ptr M02_L25
       lea       ecx,[rsi+rbx]
       cmp       ecx,[rdi+8]
       ja        near ptr M02_L25
       mov       rcx,r13
       mov       ecx,[rcx+4]
       add       ecx,0FFFFFFE8
       shr       ecx,3
       jne       near ptr M02_L17
       xor       r12d,r12d
M02_L07:
       cmp       ebp,r12d
       jl        near ptr M02_L26
       sub       ebp,r12d
       js        near ptr M02_L27
       lea       ecx,[rbx+rbp]
       cmp       ecx,[r14+8]
       ja        near ptr M02_L27
       cmp       r15,r13
       je        short M02_L08
       mov       rcx,rdi
       mov       rdx,r14
       call      qword ptr [7FF8E4796508]; System.Array.CanAssignArrayType(System.Array, System.Array)
       test      eax,eax
       jne       near ptr M02_L38
M02_L08:
       mov       rcx,r15
       movzx     edx,word ptr [rcx]
       mov       r8d,ebx
       imul      r8,rdx
       add       rdi,8
       mov       eax,[r15+4]
       add       rax,0FFFFFFFFFFFFFFF0
       add       rax,rdi
       mov       r10d,esi
       imul      r10,rdx
       add       r10,rax
       add       r14,8
       mov       eax,[r13+4]
       add       rax,0FFFFFFFFFFFFFFF0
       add       rax,r14
       mov       r9d,ebp
       imul      rdx,r9
       add       rdx,rax
       test      dword ptr [rcx],1000000
       jne       near ptr M02_L28
       mov       rcx,rdx
       mov       rax,r10
       mov       r9,r8
       mov       r11,rcx
       sub       r11,rax
       cmp       r11,r9
       jb        near ptr M02_L36
       mov       r11,rax
       sub       r11,rcx
       cmp       r11,r9
       jb        near ptr M02_L36
       lea       r11,[rax+r9]
       lea       r12,[rcx+r9]
       cmp       r9,10
       jbe       near ptr M02_L30
       cmp       r9,40
       ja        near ptr M02_L33
M02_L09:
       vmovups   xmm0,[rax]
       vmovups   [rcx],xmm0
       cmp       r9,20
       ja        near ptr M02_L29
M02_L10:
       vmovups   xmm0,[r11-10]
       vmovups   [r12-10],xmm0
M02_L11:
       vzeroupper
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
M02_L12:
       cdqe
       mov       esi,[rcx+rax*4+10]
       jmp       near ptr M02_L01
M02_L13:
       xor       edi,edi
       xor       esi,esi
       jmp       near ptr M02_L02
M02_L14:
       movsxd    rcx,ecx
       mov       ebp,[rdx+rcx*4+10]
       jmp       near ptr M02_L03
M02_L15:
       xor       r14d,r14d
       xor       ebp,ebp
       jmp       near ptr M02_L04
M02_L16:
       movsxd    rcx,ecx
       mov       r12d,[rdi+rcx*4+10]
       jmp       near ptr M02_L06
M02_L17:
       movsxd    rcx,ecx
       mov       r12d,[r14+rcx*4+10]
       jmp       near ptr M02_L07
M02_L18:
       cmp       dword ptr [r8+4],18
       jne       near ptr M02_L00
       cmp       ebx,[rcx+8]
       ja        near ptr M02_L00
       cmp       ebx,[rdx+8]
       ja        near ptr M02_L00
       mov       eax,ebx
       movzx     r10d,word ptr [r8]
       imul      r10,rax
       add       rcx,10
       mov       rax,rcx
       lea       rcx,[rdx+10]
       test      dword ptr [r8],1000000
       je        short M02_L19
       mov       rdx,rax
       mov       r8,r10
       vzeroupper
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FF8E41657A0]; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
M02_L19:
       mov       rdx,rax
       mov       r8,r10
       call      qword ptr [7FF8E4165818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M02_L11
M02_L20:
       mov       ecx,12D
       mov       rdx,7FF8E40A4000
       call      qword ptr [7FF8E4387798]
       mov       rcx,rax
       call      qword ptr [7FF8E48247C8]
       int       3
M02_L21:
       mov       ecx,145
       mov       rdx,7FF8E40A4000
       call      qword ptr [7FF8E4387798]
       mov       rcx,rax
       call      qword ptr [7FF8E48247C8]
       int       3
M02_L22:
       mov       rcx,offset MT_System.RankException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF8E4825E00]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8E4825E18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M02_L23:
       mov       ecx,0B3
       mov       rdx,7FF8E40A4000
       call      qword ptr [7FF8E4387798]
       mov       rdx,rax
       mov       ecx,ebx
       call      qword ptr [7FF8E4824798]
       int       3
M02_L24:
       mov       ecx,167
       mov       rdx,7FF8E40A4000
       call      qword ptr [7FF8E4387798]
       mov       r8,rax
       mov       edx,r12d
       mov       ecx,esi
       call      qword ptr [7FF8E4825DB8]
       int       3
M02_L25:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF8E4825E30]
       mov       rsi,rax
       mov       ecx,12D
       mov       rdx,7FF8E40A4000
       call      qword ptr [7FF8E4387798]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF8E44E61A8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M02_L26:
       mov       ecx,17F
       mov       rdx,7FF8E40A4000
       call      qword ptr [7FF8E4387798]
       mov       r8,rax
       mov       edx,r12d
       mov       ecx,ebp
       call      qword ptr [7FF8E4825DB8]
       int       3
M02_L27:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF8E4825E48]
       mov       rsi,rax
       mov       ecx,145
       mov       rdx,7FF8E40A4000
       call      qword ptr [7FF8E4387798]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF8E44E61A8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M02_L28:
       mov       rcx,rdx
       mov       rdx,r10
       vzeroupper
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FF8E41657A0]; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
M02_L29:
       vmovups   xmm0,[rax+10]
       vmovups   [rcx+10],xmm0
       cmp       r9,30
       jbe       near ptr M02_L10
       vmovups   xmm0,[rax+20]
       vmovups   [rcx+20],xmm0
       jmp       near ptr M02_L10
M02_L30:
       test      r8b,18
       je        short M02_L31
       mov       r10,[r10]
       mov       [rdx],r10
       mov       rdx,[r11-8]
       mov       [r12-8],rdx
       jmp       near ptr M02_L11
M02_L31:
       test      r8b,4
       je        short M02_L32
       mov       r10d,[r10]
       mov       [rdx],r10d
       mov       edx,[r11-4]
       mov       [r12-4],edx
       jmp       near ptr M02_L11
M02_L32:
       test      r8,r8
       je        near ptr M02_L11
       movzx     r10d,byte ptr [r10]
       mov       [rdx],r10b
       test      r8b,2
       je        near ptr M02_L11
       movsx     rdx,word ptr [r11-2]
       mov       [r12-2],dx
       jmp       near ptr M02_L11
M02_L33:
       cmp       r9,800
       ja        near ptr M02_L37
       cmp       r9,100
       jb        short M02_L34
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
M02_L34:
       mov       r10,r9
       shr       r10,6
M02_L35:
       vmovdqu   ymm0,ymmword ptr [rax]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rax+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rax,40
       dec       r10
       jne       short M02_L35
       and       r9,3F
       cmp       r9,10
       ja        near ptr M02_L09
       jmp       near ptr M02_L10
M02_L36:
       cmp       rdx,r10
       jne       short M02_L37
       cmp       [r10],r10b
       jmp       near ptr M02_L11
M02_L37:
       cmp       [rdx],dl
       cmp       [r10],r10b
       mov       rcx,rdx
       mov       rdx,r10
       vzeroupper
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FF8E41666E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
M02_L38:
       mov       [rsp+20],ebx
       mov       [rsp+28],eax
       mov       rcx,rdi
       mov       edx,esi
       mov       r8,r14
       mov       r9d,ebp
       call      qword ptr [7FF8E4825E90]
       jmp       near ptr M02_L11
; Total bytes of code 1410
```
```assembly
; System.Enum.GetNames[[System.StringComparison, System.Private.CoreLib]]()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rcx,167F6041158
       mov       rax,[rcx]
       test      rax,rax
       je        near ptr M03_L07
M03_L00:
       mov       rcx,[rax+80]
       test      rcx,rcx
       je        near ptr M03_L06
       mov       rdx,offset MT_System.Enum+EnumInfo<System.UInt32>
       cmp       [rcx],rdx
       je        short M03_L01
       mov       rdx,offset MT_System.RuntimeType+CompositeCacheEntry
       cmp       [rcx],rdx
       jne       near ptr M03_L06
       mov       rax,[rcx+28]
       jmp       short M03_L02
M03_L01:
       mov       rax,rcx
M03_L02:
       test      rax,rax
       je        near ptr M03_L08
       cmp       qword ptr [rax+10],0
       je        near ptr M03_L08
M03_L03:
       mov       rdx,[rax+10]
       test      rdx,rdx
       je        near ptr M03_L09
       lea       rbx,[rdx+10]
       mov       esi,[rdx+8]
M03_L04:
       test      esi,esi
       je        near ptr M03_L10
       mov       edx,esi
       mov       rcx,offset MT_System.String[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       lea       rcx,[rdi+10]
       mov       r8d,esi
       shl       r8,3
       cmp       r8,4000
       ja        near ptr M03_L12
       mov       rdx,rbx
       call      00007FF943D7A2B0
       cmp       dword ptr [7FF9440B4A90],0
       jne       short M03_L11
M03_L05:
       mov       rax,rdi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M03_L06:
       xor       eax,eax
       jmp       short M03_L02
M03_L07:
       mov       rcx,1A88B560AA0
       call      qword ptr [7FF8E4167C30]; System.RuntimeType.InitializeCache()
       jmp       near ptr M03_L00
M03_L08:
       mov       rcx,1A88B560AA0
       mov       edx,1
       call      qword ptr [7FF8E438DE48]; System.Enum.<GetEnumInfo>g__InitializeEnumInfo|5_0[[System.UInt32, System.Private.CoreLib]](System.RuntimeType, Boolean)
       jmp       near ptr M03_L03
M03_L09:
       xor       ebx,ebx
       xor       esi,esi
       jmp       near ptr M03_L04
M03_L10:
       mov       rcx,offset MT_System.Array+EmptyArray<System.String>
       call      qword ptr [7FF8E4165728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,167F64021F0
       mov       rdi,[rax]
       jmp       short M03_L05
M03_L11:
       call      CORINFO_HELP_POLL_GC
       jmp       short M03_L05
M03_L12:
       mov       rdx,rbx
       call      qword ptr [7FF8E46FECE8]
       jmp       short M03_L05
; Total bytes of code 317
```
```assembly
; System.Collections.Generic.List`1[[System.ValueTuple`2[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]], System.Private.CoreLib]]..ctor(Int32)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       ebx,edx
       test      ebx,ebx
       jl        short M04_L03
       test      ebx,ebx
       je        short M04_L04
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+18]
       test      rax,rax
       je        short M04_L02
       mov       rcx,rax
M04_L00:
       mov       edx,ebx
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M04_L01:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L02:
       mov       rdx,7FF8E483DAE0
       call      qword ptr [7FF8E416C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M04_L00
M04_L03:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FF8E46F6478]
       int       3
M04_L04:
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+20]
       test      rdx,rdx
       je        short M04_L05
       jmp       short M04_L06
M04_L05:
       mov       rdx,7FF8E483DAE8
       call      qword ptr [7FF8E416C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M04_L06:
       mov       rcx,rdx
       call      qword ptr [7FF8E4165728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M04_L01
; Total bytes of code 174
```
```assembly
; System.Convert.ToInt32(System.Object, System.IFormatProvider)
       push      rbx
       sub       rsp,20
       mov       rbx,rdx
       test      rcx,rcx
       je        short M05_L01
       mov       rax,rcx
       mov       rdx,offset MT_System.StringComparison
       cmp       [rax],rdx
       jne       short M05_L02
M05_L00:
       mov       rcx,offset MT_System.StringComparison
       cmp       [rax],rcx
       jne       short M05_L03
       mov       rcx,rax
       call      qword ptr [7FF8E479E640]; System.Enum.GetValue()
       test      rax,rax
       je        short M05_L01
       mov       rdx,rax
       mov       rcx,offset MT_System.IConvertible
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastInterface(Void*, System.Object)
       mov       rcx,rax
       mov       r11,7FF8E40B0A00
       xor       edx,edx
       add       rsp,20
       pop       rbx
       jmp       qword ptr [r11]
M05_L01:
       xor       eax,eax
       add       rsp,20
       pop       rbx
       ret
M05_L02:
       mov       rdx,rcx
       mov       rcx,offset MT_System.IConvertible
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastInterface(Void*, System.Object)
       jmp       short M05_L00
M05_L03:
       mov       rcx,rax
       mov       rdx,rbx
       mov       r11,7FF8E40B09F8
       add       rsp,20
       pop       rbx
       jmp       qword ptr [r11]
; Total bytes of code 153
```
```assembly
; System.ValueTuple`2[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]]..ctor(System.__Canon, Int32)
       push      rsi
       push      rbx
       mov       rbx,rcx
       mov       esi,r9d
       mov       rcx,rbx
       mov       rdx,r8
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       [rbx+8],esi
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 25
```
```assembly
; System.Collections.Generic.List`1[[System.ValueTuple`2[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]], System.Private.CoreLib]].Add(System.ValueTuple`2<System.__Canon,Int32>)
       push      rdi
       push      rsi
       inc       dword ptr [rcx+14]
       mov       rax,[rcx+8]
       mov       r8d,[rcx+10]
       mov       r10d,[rax+8]
       cmp       r10d,r8d
       jbe       short M07_L00
       lea       r10d,[r8+1]
       mov       [rcx+10],r10d
       mov       ecx,r8d
       shl       rcx,4
       lea       rdi,[rax+rcx+10]
       mov       rsi,rdx
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       pop       rsi
       pop       rdi
       ret
M07_L00:
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FF8E4825938]
; Total bytes of code 63
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.ToReadOnlyCollection[[System.ValueTuple`2[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.ValueTuple`2<System.__Canon,Int32>>)
; 			if (collection is IList<T> list)
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 				return new ReadOnlyCollection<T>(list);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			if (collection is ICollection<T> col)
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 				var sized = new List<T>(col.Count);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 				sized.AddRange(col);
; 				^^^^^^^^^^^^^^^^^^^^
; 				return new ReadOnlyCollection<T>(sized);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			return new ReadOnlyCollection<T>([.. collection]);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M08_L02
M08_L00:
       mov       rdx,rsi
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        short M08_L04
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       je        short M08_L03
M08_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M08_L02:
       mov       rcx,rbx
       mov       rdx,7FF8E47E6068
       call      qword ptr [7FF8E4387B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M08_L00
M08_L03:
       mov       rcx,rbx
       mov       rdx,7FF8E47E6098
       call      qword ptr [7FF8E4387B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M08_L01
M08_L04:
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M08_L05
       jmp       short M08_L06
M08_L05:
       mov       rcx,rbx
       mov       rdx,7FF8E47E6078
       call      qword ptr [7FF8E4387B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M08_L06:
       mov       rdx,rsi
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M08_L13
       mov       rcx,[rbx+18]
       cmp       qword ptr [rcx+8],30
       jle       short M08_L07
       mov       rsi,[rcx+30]
       test      rsi,rsi
       je        short M08_L07
       jmp       short M08_L08
M08_L07:
       mov       rcx,rbx
       mov       rdx,7FF8E47E6130
       call      qword ptr [7FF8E4387B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rsi,rax
M08_L08:
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M08_L09
       jmp       short M08_L10
M08_L09:
       mov       rcx,rbx
       mov       rdx,7FF8E47E6088
       call      qword ptr [7FF8E4387B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M08_L10:
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rdi
       mov       r11,rsi
       call      qword ptr [rsi]
       mov       edx,eax
       mov       rcx,rbp
       call      qword ptr [7FF8E479E478]; System.Collections.Generic.List`1[[System.ValueTuple`2[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]], System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,rbp
       mov       rdx,rdi
       call      qword ptr [7FF8E479E6B8]
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       je        short M08_L11
       jmp       short M08_L12
M08_L11:
       mov       rcx,rbx
       mov       rdx,7FF8E47E6098
       call      qword ptr [7FF8E4387B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M08_L12:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,rbp
       call      qword ptr [7FF8E479E6A0]; System.Collections.ObjectModel.ReadOnlyCollection`1[[System.ValueTuple`2[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]], System.Private.CoreLib]]..ctor(System.Collections.Generic.IList`1<System.ValueTuple`2<System.__Canon,Int32>>)
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M08_L13:
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M08_L14
       jmp       short M08_L15
M08_L14:
       mov       rcx,rbx
       mov       rdx,7FF8E47E6088
       call      qword ptr [7FF8E4387B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M08_L15:
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       call      qword ptr [7FF8E479E6D0]
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FF8E479E6B8]
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       je        short M08_L16
       jmp       short M08_L17
M08_L16:
       mov       rcx,rbx
       mov       rdx,7FF8E47E6098
       call      qword ptr [7FF8E4387B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M08_L17:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,rdi
       call      qword ptr [7FF8E479E6A0]; System.Collections.ObjectModel.ReadOnlyCollection`1[[System.ValueTuple`2[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]], System.Private.CoreLib]]..ctor(System.Collections.Generic.IList`1<System.ValueTuple`2<System.__Canon,Int32>>)
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 522
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
       je        near ptr M10_L08
M10_L00:
       mov       rcx,[rbx+10]
       mov       rdx,[rcx]
       mov       rdi,rdx
       test      rdi,rdi
       je        short M10_L01
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache
       cmp       [rdi],rcx
       jne       near ptr M10_L09
M10_L01:
       test      rdi,rdi
       jne       near ptr M10_L07
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
       call      00007FF943DA53D0
       mov       r14,rax
       test      r14,r14
       je        near ptr M10_L10
M10_L02:
       mov       rax,[r14+8]
       test      rax,rax
       jne       near ptr M10_L05
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
       mov       rax,7FF8E42A1B50
       mov       [rbp-78],rax
       lea       rax,[M10_L03]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FF943C823D0
       call      rax
M10_L03:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FF9440B4A90],0
       je        short M10_L04
       call      qword ptr [7FF9440A2648]; CORINFO_HELP_STOP_FOR_GC
M10_L04:
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
M10_L05:
       cmp       rax,rbx
       sete      cl
       mov       rdi,[rbp-0A0]
       mov       [rdi+9C],cl
       mov       rcx,[rbx+10]
       mov       rdx,rdi
       xor       r8d,r8d
       call      00007FF943DBBEF0
       mov       rdx,rax
       test      rdx,rdx
       je        short M10_L06
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache
       cmp       [rdx],rcx
       jne       short M10_L11
M10_L06:
       test      rdx,rdx
       cmovne    rdi,rdx
M10_L07:
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
M10_L08:
       mov       [rbp-40],rbx
       lea       rcx,[rbp-40]
       mov       edx,1
       call      qword ptr [7FF8E4826B98]; System.RuntimeTypeHandle.GetGCHandle(System.Runtime.InteropServices.GCHandleType)
       mov       rdx,rax
       lea       rcx,[rbx+10]
       xor       eax,eax
       lock cmpxchg [rcx],rdx
       test      rax,rax
       je        near ptr M10_L00
       lea       rcx,[rbp-40]
       call      qword ptr [7FF8E4826028]
       jmp       near ptr M10_L00
M10_L09:
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M10_L10:
       mov       [rbp+10],rbx
       mov       rcx,rbx
       call      qword ptr [7FF8E4167C78]; System.RuntimeTypeHandle.<GetModule>g__GetModuleWorker|48_0(System.RuntimeType)
       mov       r14,rax
       mov       rbx,[rbp+10]
       jmp       near ptr M10_L02
M10_L11:
       mov       rdx,rax
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
; Total bytes of code 566
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rdx,rdx
       je        short M11_L00
       cmp       [rdx],rcx
       jne       short M11_L01
M11_L00:
       mov       rax,rdx
       ret
M11_L01:
       mov       rax,[rdx]
       mov       rax,[rax+10]
M11_L02:
       cmp       rax,rcx
       je        short M11_L00
       test      rax,rax
       je        short M11_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M11_L00
       test      rax,rax
       je        short M11_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M11_L00
       test      rax,rax
       je        short M11_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M11_L00
       test      rax,rax
       je        short M11_L03
       mov       rax,[rax+10]
       jmp       short M11_L02
M11_L03:
       xor       edx,edx
       jmp       short M11_L00
; Total bytes of code 83
```
```assembly
; System.Enum.<GetEnumInfo>g__InitializeEnumInfo|5_0[[System.UInt32, System.Private.CoreLib]](System.RuntimeType, Boolean)
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
       mov       [rbp-0C8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-0C0],ymm4
       vmovdqu   ymmword ptr [rbp-0A0],ymm4
       vmovdqu   ymmword ptr [rbp-80],ymm4
       vmovdqu   ymmword ptr [rbp-60],ymm4
       mov       [rbp-40],rax
       mov       rbx,rcx
       mov       esi,edx
       lea       rcx,[rbp-98]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rdi,rax
       mov       rcx,rsp
       mov       [rbp-80],rcx
       mov       rcx,rbp
       mov       [rbp-70],rcx
       test      sil,sil
       je        near ptr M12_L12
       mov       [rbp+10],rbx
       mov       [rbp-50],rbx
       xor       ecx,ecx
       mov       [rbp-40],rcx
       mov       [rbp-48],rcx
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rbp-60],xmm0
       lea       rcx,[rbp-50]
       mov       [rbp-60],rcx
       mov       rcx,[rbp-50]
       test      rcx,rcx
       je        near ptr M12_L18
       mov       rcx,[rcx+18]
M12_L00:
       mov       [rbp-58],rcx
       vmovups   xmm0,[rbp-60]
       vmovups   [rbp-0A8],xmm0
       lea       rcx,[rbp-0A8]
       lea       rdx,[rbp-40]
       lea       r8,[rbp-48]
       mov       r9d,1
       mov       rax,7FF8E40A4EE8
       mov       [rbp-88],rax
       lea       rax,[M12_L01]
       mov       [rbp-78],rax
       lea       rax,[rbp-98]
       mov       [rdi+8],rax
       mov       byte ptr [rdi+4],0
       mov       rax,7FF943CDE150
       call      rax
M12_L01:
       mov       byte ptr [rdi+4],1
       cmp       dword ptr [7FF9440B4A90],0
       je        short M12_L02
       call      qword ptr [7FF9440A2648]; CORINFO_HELP_STOP_FOR_GC
M12_L02:
       mov       rcx,[rbp-90]
       mov       [rdi+8],rcx
       mov       rbx,[rbp-50]
       cmp       [rbx],bl
       mov       rcx,[rbx+18]
       call      00007FF943DABEA0
       test      rax,rax
       jne       near ptr M12_L19
M12_L03:
       mov       rcx,167F64001C8
       mov       rcx,[rcx]
       mov       rdx,1A88B555F08
       call      qword ptr [7FF8E416E988]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       mov       rcx,rbx
       call      00007FF943DA53D0
       mov       rsi,rax
       test      rsi,rsi
       je        near ptr M12_L21
M12_L04:
       mov       rcx,rbx
       call      00007FF943DA8680
       mov       edx,eax
       xor       ecx,ecx
       mov       [rsp+20],ecx
       mov       rcx,rsi
       mov       r8,1A88B555F08
       xor       r9d,r9d
       call      qword ptr [7FF8E42D52C0]; System.Reflection.CustomAttribute.IsCustomAttributeDefined(System.Reflection.RuntimeModule, Int32, System.RuntimeType, Int32, Boolean)
       test      eax,eax
       jne       near ptr M12_L20
M12_L05:
       xor       ebx,ebx
M12_L06:
       mov       rcx,offset MT_System.Enum+EnumInfo<System.UInt32>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdi,[rbp-40]
       mov       r14,[rbp-48]
       mov       [rsi+18],bl
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       call      qword ptr [7FF8E438DF38]; System.Enum.AreSorted[[System.UInt32, System.Private.CoreLib]](UInt32[])
       test      eax,eax
       jne       near ptr M12_L09
       test      rdi,rdi
       je        near ptr M12_L22
       mov       ebx,[rdi+8]
       mov       ecx,[rdi+8]
       test      r14,r14
       je        short M12_L07
       mov       ecx,[r14+8]
       sub       ecx,ebx
       js        near ptr M12_L23
M12_L07:
       cmp       ebx,1
       jle       short M12_L09
       test      r14,r14
       je        near ptr M12_L11
       lea       r15,[rdi+10]
       add       r14,10
       test      byte ptr [7FF8E48454F8],1
       je        near ptr M12_L24
M12_L08:
       mov       rcx,167F64021F8
       mov       rcx,[rcx]
       mov       [rbp-0B8],r15
       mov       [rbp-0B0],ebx
       mov       [rbp-0C8],r14
       mov       [rbp-0C0],ebx
       lea       r8,[rbp-0C8]
       lea       rdx,[rbp-0B8]
       mov       r11,7FF8E40B0A38
       xor       r9d,r9d
       call      qword ptr [r11]
M12_L09:
       mov       rcx,rdi
       call      qword ptr [7FF8E438DF50]; System.Enum.AreSequentialFromZero[[System.UInt32, System.Private.CoreLib]](UInt32[])
       mov       [rsi+19],al
       xor       r8d,r8d
       mov       [rbp-40],r8
       mov       [rbp-48],r8
       mov       rbx,[rbp+10]
       cmp       [rbx],bl
       mov       r8,rsi
       mov       rdx,rbx
       mov       rcx,offset MT_System.RuntimeType+IGenericCacheEntry<System.Enum+EnumInfo<System.UInt32>>
       call      qword ptr [7FF8E438DF68]; System.RuntimeType+IGenericCacheEntry`1[[System.__Canon, System.Private.CoreLib]].Replace(System.RuntimeType, System.__Canon)
M12_L10:
       mov       rax,rsi
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
M12_L11:
       mov       rcx,rdi
       mov       r8d,ebx
       xor       edx,edx
       xor       r9d,r9d
       call      qword ptr [7FF8E48255C0]
       jmp       short M12_L09
M12_L12:
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M12_L17
       mov       rax,[rcx]
       test      rax,rax
       je        short M12_L17
M12_L13:
       mov       rdx,[rax+80]
       test      rdx,rdx
       je        short M12_L16
       mov       rcx,[rdx]
       mov       rax,offset MT_System.Enum+EnumInfo<System.UInt32>
       cmp       rcx,rax
       je        short M12_L14
       mov       rax,offset MT_System.RuntimeType+CompositeCacheEntry
       cmp       rcx,rax
       jne       short M12_L16
       mov       rsi,[rdx+28]
       test      rsi,rsi
       je        short M12_L16
       jmp       short M12_L15
M12_L14:
       mov       rsi,rdx
M12_L15:
       jmp       short M12_L10
M12_L16:
       mov       rdx,rbx
       mov       rcx,offset MT_System.RuntimeType+IGenericCacheEntry<System.Enum+EnumInfo<System.UInt32>>
       call      qword ptr [7FF8E416C4F8]; System.RuntimeType+IGenericCacheEntry`1[[System.__Canon, System.Private.CoreLib]].CreateAndCache(System.RuntimeType)
       mov       rsi,rax
       jmp       short M12_L15
M12_L17:
       mov       rcx,rbx
       call      qword ptr [7FF8E4167C30]; System.RuntimeType.InitializeCache()
       jmp       short M12_L13
M12_L18:
       xor       ecx,ecx
       jmp       near ptr M12_L00
M12_L19:
       mov       rcx,rax
       call      qword ptr [7FF8E4165860]; System.RuntimeTypeHandle.GetRuntimeTypeFromHandle(IntPtr)
       test      rax,rax
       jne       near ptr M12_L05
       jmp       near ptr M12_L03
M12_L20:
       mov       ebx,1
       jmp       near ptr M12_L06
M12_L21:
       mov       rcx,rbx
       call      qword ptr [7FF8E4167C78]; System.RuntimeTypeHandle.<GetModule>g__GetModuleWorker|48_0(System.RuntimeType)
       mov       rsi,rax
       jmp       near ptr M12_L04
M12_L22:
       mov       ecx,48
       call      qword ptr [7FF8E438C228]
       int       3
M12_L23:
       mov       ecx,10
       call      qword ptr [7FF8E4826AF0]
       int       3
M12_L24:
       mov       rcx,offset MT_System.Collections.Generic.ArraySortHelper<System.UInt32, System.String>
       call      qword ptr [7FF8E4165728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M12_L08
; Total bytes of code 926
```
```assembly
; System.RuntimeType.get_Cache()
       mov       rax,[rcx+10]
       test      rax,rax
       je        short M13_L00
       mov       rax,[rax]
       test      rax,rax
       je        short M13_L00
       ret
M13_L00:
       jmp       qword ptr [7FF8E4167C30]; System.RuntimeType.InitializeCache()
; Total bytes of code 24
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumExtensionsBenchmark.GetDescription()
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       esi,[rbx+198]
       mov       [rsp+34],esi
       mov       rdi,203F2660AA0
       mov       rcx,1C35B981158
       mov       rbp,[rcx]
       test      rbp,rbp
       jne       short M00_L00
       mov       rcx,rdi
       call      qword ptr [7FF8E4177C30]; System.RuntimeType.InitializeCache()
       jmp       short M00_L01
M00_L00:
       mov       rax,rbp
M00_L01:
       mov       rcx,[rax+80]
       test      rcx,rcx
       je        near ptr M00_L09
       mov       rdx,offset MT_System.Enum+EnumInfo<System.UInt32>
       cmp       [rcx],rdx
       je        short M00_L02
       mov       rdx,offset MT_System.RuntimeType+CompositeCacheEntry
       cmp       [rcx],rdx
       jne       near ptr M00_L09
       mov       rax,[rcx+28]
       jmp       short M00_L03
M00_L02:
       mov       rax,rcx
M00_L03:
       test      rax,rax
       je        near ptr M00_L10
       cmp       qword ptr [rax+10],0
       je        near ptr M00_L10
M00_L04:
       mov       edx,[rsp+34]
       mov       rbp,[rax+10]
       cmp       byte ptr [rax+19],0
       je        near ptr M00_L11
       mov       ecx,edx
       call      qword ptr [7FF8E4835B00]; System.UInt32.CreateTruncating[[System.UInt32, System.Private.CoreLib]](UInt32)
       mov       r14d,[rbp+8]
       cmp       r14d,eax
       jbe       near ptr M00_L12
       mov       ecx,eax
       mov       r15,[rbp+rcx*8+10]
M00_L05:
       test      r15,r15
       je        near ptr M00_L13
       mov       rdx,r15
       mov       rcx,rdi
       mov       r8d,1C
       call      qword ptr [7FF8E40BA490]; System.RuntimeType.GetField(System.String, System.Reflection.BindingFlags)
       mov       rsi,rax
       test      rsi,rsi
       je        short M00_L07
       mov       rdx,rsi
       mov       rcx,7FF8E480B1E0
       xor       r8d,r8d
       call      qword ptr [7FF8E46965E0]; System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.MemberInfo, Boolean)
       mov       rdi,rax
       test      rdi,rdi
       jne       near ptr M00_L14
M00_L06:
       mov       rdx,rsi
       mov       rcx,7FF8E480B268
       xor       r8d,r8d
       call      qword ptr [7FF8E46965E0]; System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.MemberInfo, Boolean)
       mov       rdi,rax
       test      rdi,rdi
       jne       near ptr M00_L15
M00_L07:
       mov       rsi,r15
M00_L08:
       mov       [rsp+28],rsi
       mov       rcx,[rbx+88]
       lea       r8,[rsp+28]
       mov       rdx,7FF8E480DCB8
       cmp       [rcx],ecx
       call      qword ptr [7FF8E47AE670]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M00_L09:
       xor       eax,eax
       jmp       near ptr M00_L03
M00_L10:
       mov       rcx,rdi
       mov       edx,1
       call      qword ptr [7FF8E439DE48]; System.Enum.<GetEnumInfo>g__InitializeEnumInfo|5_0[[System.UInt32, System.Private.CoreLib]](System.RuntimeType, Boolean)
       jmp       near ptr M00_L04
M00_L11:
       mov       rcx,[rax+8]
       call      qword ptr [7FF8E4835AD0]
       mov       r14d,[rbp+8]
       cmp       r14d,eax
       jbe       short M00_L12
       mov       edx,eax
       mov       r15,[rbp+rdx*8+10]
       jmp       near ptr M00_L05
M00_L12:
       xor       r15d,r15d
       jmp       near ptr M00_L05
M00_L13:
       mov       rcx,offset MT_System.StringComparison
       call      CORINFO_HELP_NEWSFAST
       mov       [rax+8],esi
       mov       rcx,rax
       call      qword ptr [7FF8E40B6098]; System.Enum.ToString()
       mov       rsi,rax
       jmp       near ptr M00_L08
M00_L14:
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       rcx,rax
       call      qword ptr [7FF8E439E3E8]; System.String.IsNullOrEmpty(System.String)
       test      eax,eax
       jne       near ptr M00_L06
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       rsi,rax
       jmp       near ptr M00_L08
M00_L15:
       mov       rcx,[rdi+8]
       call      qword ptr [7FF8E439E3E8]; System.String.IsNullOrEmpty(System.String)
       test      eax,eax
       jne       near ptr M00_L07
       mov       rsi,[rdi+8]
       jmp       near ptr M00_L08
; Total bytes of code 532
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
       call      00007FF943DA53D0
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
       mov       rax,7FF8E42B1B50
       mov       [rbp-78],rax
       lea       rax,[M01_L03]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FF943C823D0
       call      rax
M01_L03:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FF9440B4A90],0
       je        short M01_L04
       call      qword ptr [7FF9440A2648]; CORINFO_HELP_STOP_FOR_GC
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
       call      00007FF943DBBEF0
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
       call      qword ptr [7FF8E483CFD8]; System.RuntimeTypeHandle.GetGCHandle(System.Runtime.InteropServices.GCHandleType)
       mov       rdx,rax
       lea       rcx,[rbx+10]
       xor       eax,eax
       lock cmpxchg [rcx],rdx
       test      rax,rax
       je        near ptr M01_L00
       lea       rcx,[rbp-40]
       call      qword ptr [7FF8E4835788]
       jmp       near ptr M01_L00
M01_L09:
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M01_L10:
       mov       [rbp+10],rbx
       mov       rcx,rbx
       call      qword ptr [7FF8E4177C78]; System.RuntimeTypeHandle.<GetModule>g__GetModuleWorker|48_0(System.RuntimeType)
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
; System.UInt32.CreateTruncating[[System.UInt32, System.Private.CoreLib]](UInt32)
       mov       eax,ecx
       ret
; Total bytes of code 3
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
       je        near ptr M03_L16
       test      bl,1
       jne       near ptr M03_L17
       mov       ebp,1
M03_L00:
       cmp       qword ptr [rsi+10],0
       je        short M03_L01
       mov       rcx,[rsi+10]
       mov       r14,[rcx]
       test      r14,r14
       jne       short M03_L04
M03_L01:
       mov       rcx,rsi
       call      qword ptr [7FF8E4177C30]; System.RuntimeType.InitializeCache()
       mov       rsi,rax
M03_L02:
       mov       r14d,ebp
       mov       r15,rdi
       cmp       [rsi],sil
       lea       r13,[rsi+50]
       mov       r12,[r13]
       test      r12,r12
       je        near ptr M03_L18
M03_L03:
       mov       rsi,r12
       cmp       [rsi],sil
       cmp       r14d,1
       jne       near ptr M03_L19
       mov       rbp,[rsi+20]
       test      rbp,rbp
       je        near ptr M03_L25
       test      r15,r15
       jne       short M03_L05
       movsx     rdx,byte ptr [0]
       mov       edx,[0]
       add       edx,edx
       movsx     rcx,byte ptr [0]
       xor       ecx,ecx
       mov       r8d,4525906
       mov       r9d,0BD6FA1FF
       call      qword ptr [7FF8E459D7E8]; System.Marvin.ComputeHash32(Byte ByRef, UInt32, UInt32, UInt32)
       jmp       short M03_L06
M03_L04:
       mov       rsi,r14
       jmp       short M03_L02
M03_L05:
       mov       rcx,r15
       call      qword ptr [7FF8E41766D0]; System.String.GetNonRandomizedHashCode()
M03_L06:
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
       jae       near ptr M03_L35
       mov       r8d,r14d
       mov       r13,[r12+r8*8+10]
       test      r13,r13
       je        near ptr M03_L25
M03_L07:
       cmp       r13,r15
       jne       near ptr M03_L21
M03_L08:
       mov       rcx,[rbp+10]
       cmp       r14d,[rcx+8]
       jae       near ptr M03_L35
       mov       edx,r14d
       mov       rdi,[rcx+rdx*8+10]
M03_L09:
       test      rdi,rdi
       je        near ptr M03_L26
M03_L10:
       xor       esi,esi
       xor       ebx,2
       xor       ebp,ebp
       mov       r14d,[rdi+8]
       mov       r15d,10
       inc       r14d
M03_L11:
       dec       r14d
       je        short M03_L14
       mov       r13,[rdi+r15]
       mov       ecx,[r13+18]
       mov       eax,ebx
       and       eax,ecx
       cmp       eax,ecx
       jne       short M03_L13
       test      rsi,rsi
       jne       near ptr M03_L31
M03_L12:
       mov       rsi,r13
M03_L13:
       add       r15,8
       jmp       short M03_L11
M03_L14:
       test      ebp,ebp
       jne       near ptr M03_L33
M03_L15:
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
M03_L16:
       mov       ecx,3E7
       mov       rdx,7FF8E40B4000
       call      qword ptr [7FF8E4397798]
       mov       rcx,rax
       call      qword ptr [7FF8E4834708]
       int       3
M03_L17:
       mov       rcx,1C35D802068
       mov       rcx,[rcx]
       mov       rdx,rdi
       call      qword ptr [7FF8E48354B8]
       mov       rdi,rax
       mov       ebp,2
       jmp       near ptr M03_L00
M03_L18:
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache+MemberInfoCache<System.Reflection.RuntimeFieldInfo>
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       lea       rcx,[r12+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r13
       mov       rdx,r12
       xor       r8d,r8d
       call      00007FF943D96040
       mov       rsi,rax
       test      rsi,rsi
       cmove     rsi,r12
       mov       r12,rsi
       jmp       near ptr M03_L03
M03_L19:
       cmp       ebp,2
       je        near ptr M03_L27
       cmp       byte ptr [r12+18],0
       je        near ptr M03_L30
       jmp       near ptr M03_L29
M03_L20:
       cmp       r14d,edi
       jae       near ptr M03_L35
       mov       ecx,r14d
       mov       r13,[r12+rcx*8+10]
       test      r13,r13
       je        short M03_L25
       jmp       near ptr M03_L07
M03_L21:
       test      r15,r15
       jne       short M03_L23
M03_L22:
       inc       r14d
       mov       edi,[r12+8]
       cmp       edi,r14d
       jg        short M03_L20
       jmp       short M03_L24
M03_L23:
       mov       r8d,[r13+8]
       cmp       r8d,[r15+8]
       jne       short M03_L22
       lea       rcx,[r13+0C]
       mov       r8d,[r13+8]
       add       r8d,r8d
       lea       rdx,[r15+0C]
       call      qword ptr [7FF8E417FBB8]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       test      eax,eax
       je        short M03_L22
       jmp       near ptr M03_L08
M03_L24:
       sub       r14d,edi
       jmp       short M03_L20
M03_L25:
       xor       edi,edi
       jmp       near ptr M03_L09
M03_L26:
       mov       rcx,rsi
       mov       rdx,r15
       mov       r8d,1
       mov       r9d,2
       call      qword ptr [7FF8E417D2C0]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
       mov       rdi,rax
       jmp       near ptr M03_L10
M03_L27:
       lea       rcx,[r12+28]
       mov       r8,rdi
       mov       rdx,offset MT_System.Reflection.CerHashtable<System.String, System.Reflection.RuntimeFieldInfo[]>
       call      qword ptr [7FF8E417F408]; System.Reflection.CerHashtable`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Item(System.__Canon)
       test      rax,rax
       jne       short M03_L28
       mov       rcx,r12
       mov       rdx,rdi
       mov       r8d,2
       mov       r9d,2
       call      qword ptr [7FF8E417D2C0]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
M03_L28:
       mov       rdi,rax
       jmp       near ptr M03_L10
M03_L29:
       mov       rdi,[r12+8]
       jmp       near ptr M03_L10
M03_L30:
       mov       rcx,r12
       mov       r8d,ebp
       xor       edx,edx
       mov       r9d,2
       call      qword ptr [7FF8E417D2C0]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
       mov       rdi,rax
       jmp       near ptr M03_L10
M03_L31:
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
       je        near ptr M03_L34
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF8E417ED78]; System.Type.get_IsInterface()
       test      eax,eax
       je        short M03_L32
       mov       rcx,r13
       mov       rax,[r13]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF8E417ED78]; System.Type.get_IsInterface()
       test      eax,eax
       je        short M03_L32
       mov       ebp,1
M03_L32:
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
       jne       near ptr M03_L12
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF8E417ED78]; System.Type.get_IsInterface()
       test      eax,eax
       je        near ptr M03_L13
       jmp       near ptr M03_L12
M03_L33:
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF8E417ED78]; System.Type.get_IsInterface()
       test      eax,eax
       je        near ptr M03_L15
M03_L34:
       mov       rcx,rsi
       call      qword ptr [7FF8E4835590]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M03_L35:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1018
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
       je        near ptr M04_L23
       mov       rcx,[rcx+18]
       mov       rdi,[rcx]
       mov       rcx,rdi
       call      System.RuntimeTypeHandle.GetRuntimeTypeFromHandle(IntPtr)
       mov       rbp,rax
       mov       rcx,[rbp+18]
       test      cl,2
       je        short M04_L00
       xor       eax,eax
       jmp       short M04_L01
M04_L00:
       mov       eax,[rcx]
       and       eax,0F0000
       cmp       eax,0C0000
       sete      al
       movzx     eax,al
M04_L01:
       test      eax,eax
       jne       near ptr M04_L24
       mov       rcx,rbp
       call      00007FF943DA7850
       test      eax,eax
       jne       near ptr M04_L25
       mov       rcx,[rbp+18]
       test      cl,2
       jne       near ptr M04_L20
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        near ptr M04_L20
       mov       rax,[rcx+20]
       add       rax,10
       mov       rax,[rax]
       test      rax,rax
       je        near ptr M04_L31
M04_L02:
       mov       rcx,rax
M04_L03:
       test      rcx,rcx
       je        near ptr M04_L33
M04_L04:
       mov       rax,203F2651A60
       cmp       rcx,rax
       jne       near ptr M04_L32
M04_L05:
       mov       rcx,offset MT_System.Reflection.MdFieldInfo
       cmp       [rbx],rcx
       jne       near ptr M04_L34
       mov       r14d,4
M04_L06:
       cmp       r14d,2
       je        near ptr M04_L36
       cmp       r14d,10
       je        near ptr M04_L35
       mov       rcx,offset MT_System.Reflection.MdFieldInfo
       cmp       [rbx],rcx
       jne       near ptr M04_L56
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+58],xmm0
       vmovdqu   xmmword ptr [rsp+60],xmm0
       mov       rcx,203F26519B8
       cmp       rbp,rcx
       je        near ptr M04_L37
       mov       rcx,203F2651A60
       cmp       rbp,rcx
       sete      sil
       movzx     esi,sil
M04_L07:
       test      esi,esi
       jne       near ptr M04_L43
       mov       rcx,1C35D8001C8
       mov       r14,[rcx]
       mov       rdx,rbp
       cmp       qword ptr [r14+8],0
       je        near ptr M04_L13
       mov       r15,[r14+10]
       xor       r13d,r13d
       mov       r12,[r14+18]
       mov       rcx,offset MT_System.Collections.Generic.ObjectEqualityComparer<System.RuntimeType>
       cmp       [r12],rcx
       jne       near ptr M04_L40
       mov       [rsp+48],rdx
       xor       ecx,ecx
       mov       [rsp+40],rcx
       lea       rcx,[rsp+48]
       cmp       qword ptr [rsp+40],0
       jne       short M04_L08
       mov       rcx,[rsp+48]
       mov       [rsp+40],rcx
       lea       rcx,[rsp+40]
       cmp       qword ptr [rsp+40],0
       je        near ptr M04_L38
M04_L08:
       mov       rax,[rcx]
       mov       [rsp+30],rax
       mov       rcx,offset MT_System.RuntimeType
       cmp       [rax],rcx
       jne       near ptr M04_L39
       mov       rcx,rax
       call      00007FF943D7A6D0
       test      eax,eax
       je        near ptr M04_L21
M04_L09:
       xor       ecx,ecx
       mov       [rsp+40],rcx
M04_L10:
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
       jae       near ptr M04_L59
       mov       ecx,ecx
       lea       rdx,[rdx+rcx*4+10]
       mov       r10d,[rdx]
       dec       r10d
       js        short M04_L13
M04_L11:
       mov       r14d,[r15+8]
       cmp       r10d,r14d
       jae       near ptr M04_L59
       mov       edx,r10d
       shl       rdx,4
       lea       r10,[r15+rdx+10]
       mov       [rsp+38],r10
       cmp       [r10+8],eax
       je        near ptr M04_L41
M04_L12:
       mov       r10d,[r10+0C]
       inc       r13d
       cmp       r14d,r13d
       jb        near ptr M04_L42
       test      r10d,r10d
       mov       eax,[rsp+54]
       jge       short M04_L11
M04_L13:
       mov       rsi,[rbx+10]
       cmp       [rsi],sil
       mov       rcx,rsi
       call      00007FF943DA53D0
       mov       rcx,rax
       test      rcx,rcx
       je        near ptr M04_L50
M04_L14:
       mov       edx,[rbx+1C]
       mov       r8d,[rsp+68]
       mov       r9,rbp
       call      qword ptr [7FF8E417E9B8]; System.Reflection.CustomAttribute.GetCustomAttributes(System.Reflection.RuntimeModule, Int32, Int32, System.RuntimeType)
       mov       rbx,rax
       cmp       dword ptr [rsp+68],0
       jle       short M04_L15
       mov       r9d,[rbx+8]
       sub       r9d,[rsp+68]
       cmp       dword ptr [rsp+68],1
       jne       near ptr M04_L22
       movsxd    rdx,r9d
       mov       rcx,rbx
       mov       r8,[rsp+60]
       call      qword ptr [7FF8E41757B8]; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
M04_L15:
       mov       rbp,rbx
       test      rbp,rbp
       je        short M04_L16
       mov       rdx,offset MT_System.Runtime.Serialization.EnumMemberAttribute[]
       cmp       [rbp],rdx
       je        short M04_L16
       mov       rdx,rbx
       mov       rcx,offset MT_System.Attribute[]
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rbp,rax
M04_L16:
       test      rbp,rbp
       je        short M04_L17
       cmp       dword ptr [rbp+8],0
       jne       near ptr M04_L57
M04_L17:
       xor       edx,edx
M04_L18:
       mov       rax,rdx
       test      rax,rax
       je        short M04_L19
       mov       rcx,rdi
       cmp       [rax],rcx
       je        short M04_L19
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
M04_L19:
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
M04_L20:
       xor       eax,eax
       jmp       near ptr M04_L02
M04_L21:
       mov       rcx,[rsp+30]
       call      qword ptr [7FF8E417E970]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       jmp       near ptr M04_L09
M04_L22:
       mov       rcx,[rsp+58]
       mov       esi,[rsp+68]
       test      rcx,rcx
       je        near ptr M04_L55
       mov       rdx,[rcx]
       cmp       rdx,[rbx]
       jne       near ptr M04_L55
       cmp       dword ptr [rdx+4],18
       jne       near ptr M04_L55
       test      r9d,r9d
       jl        near ptr M04_L55
       cmp       esi,[rcx+8]
       ja        near ptr M04_L55
       lea       r8d,[r9+rsi]
       cmp       r8d,[rbx+8]
       ja        near ptr M04_L55
       movzx     r8d,word ptr [rdx]
       mov       eax,esi
       imul      rax,r8
       add       rcx,10
       mov       r10,rcx
       mov       ecx,r9d
       imul      rcx,r8
       lea       rcx,[rbx+rcx+10]
       test      dword ptr [rdx],1000000
       je        near ptr M04_L53
       cmp       rax,4000
       ja        near ptr M04_L52
       mov       rdx,r10
       mov       r8,rax
       call      00007FF943D7A2B0
       cmp       dword ptr [7FF9440B4A90],0
       je        near ptr M04_L15
       jmp       near ptr M04_L51
M04_L23:
       mov       ecx,1A1
       mov       rdx,7FF8E40B4000
       call      qword ptr [7FF8E4397798]
       mov       rcx,rax
       call      qword ptr [7FF8E4834708]
       int       3
M04_L24:
       xor       ecx,ecx
       jmp       near ptr M04_L03
M04_L25:
       mov       rcx,rbp
       call      qword ptr [7FF8E40BA400]
       mov       r14,rax
       mov       r15,203F26519B8
       xor       r13d,r13d
       jmp       short M04_L29
M04_L26:
       mov       rdx,[r14+r13*8+10]
       mov       rcx,offset MT_System.RuntimeType
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       r12,rax
       mov       rcx,r12
       cmp       [rcx],ecx
       call      qword ptr [7FF8E417D398]; System.RuntimeType.get_IsActualInterface()
       test      eax,eax
       jne       short M04_L28
       mov       rcx,r12
       call      00007FF943DA7850
       test      eax,eax
       je        short M04_L27
       mov       rcx,r12
       call      qword ptr [7FF8E40BA3F8]
       mov       ecx,eax
       and       ecx,4
       and       eax,8
       or        ecx,eax
       je        short M04_L28
M04_L27:
       mov       r15,r12
M04_L28:
       inc       r13d
M04_L29:
       cmp       [r14+8],r13d
       jg        short M04_L26
       mov       rcx,203F26519B8
       cmp       r15,rcx
       jne       short M04_L30
       mov       rcx,rbp
       call      qword ptr [7FF8E40BA3F8]
       mov       rcx,203F2654B90
       test      al,8
       cmovne    r15,rcx
M04_L30:
       mov       rcx,r15
       jmp       near ptr M04_L03
M04_L31:
       call      qword ptr [7FF8E4175C80]; System.RuntimeTypeHandle.GetRuntimeTypeFromHandleSlow(IntPtr)
       jmp       near ptr M04_L02
M04_L32:
       call      qword ptr [7FF8E417DB00]; System.RuntimeType.GetBaseType()
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M04_L04
M04_L33:
       mov       rcx,offset MT_System.Attribute
       cmp       rdi,rcx
       je        near ptr M04_L05
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF8E4835068]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8E44F42B8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M04_L34:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       r14d,eax
       jmp       near ptr M04_L06
M04_L35:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Reflection.PropertyInfo
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       rcx,rax
       mov       rdx,rbp
       movzx     r8d,sil
       call      qword ptr [7FF8E469CDE0]; System.Attribute.InternalGetCustomAttributes(System.Reflection.PropertyInfo, System.Type, Boolean)
       mov       rbp,rax
       jmp       near ptr M04_L16
M04_L36:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Reflection.EventInfo
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       rcx,rax
       mov       rdx,rbp
       movzx     r8d,sil
       call      qword ptr [7FF8E4835080]
       mov       rbp,rax
       jmp       near ptr M04_L16
M04_L37:
       mov       esi,1
       jmp       near ptr M04_L07
M04_L38:
       xor       eax,eax
       jmp       near ptr M04_L09
M04_L39:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
       jmp       near ptr M04_L09
M04_L40:
       mov       rcx,r12
       mov       r11,7FF8E40C0A08
       call      qword ptr [r11]
       jmp       near ptr M04_L10
M04_L41:
       mov       rdx,[r10]
       mov       rcx,r12
       mov       r8,rbp
       mov       r11,7FF8E40C0A10
       call      qword ptr [r11]
       test      eax,eax
       mov       r10,[rsp+38]
       je        near ptr M04_L12
       mov       rcx,203F2651AF8
       cmp       rbp,rcx
       jne       short M04_L45
       jmp       short M04_L43
M04_L42:
       call      qword ptr [7FF8E4397A08]
       int       3
M04_L43:
       mov       rcx,rbx
       call      qword ptr [7FF8E4835398]
       test      rax,rax
       je        short M04_L44
       lea       rcx,[rsp+58]
       mov       r8,rax
       mov       rdx,offset MT_System.RuntimeType+ListBuilder<System.Attribute>
       call      qword ptr [7FF8E417D4B8]; System.RuntimeType+ListBuilder`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
M04_L44:
       test      esi,esi
       jne       short M04_L46
M04_L45:
       mov       rcx,203F2651AA8
       cmp       rbp,rcx
       jne       short M04_L48
M04_L46:
       mov       rcx,rbx
       call      qword ptr [7FF8E48353B0]
       test      rax,rax
       je        short M04_L47
       lea       rcx,[rsp+58]
       mov       r8,rax
       mov       rdx,offset MT_System.RuntimeType+ListBuilder<System.Attribute>
       call      qword ptr [7FF8E417D4B8]; System.RuntimeType+ListBuilder`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
M04_L47:
       test      esi,esi
       jne       short M04_L49
M04_L48:
       mov       rcx,203F2651B48
       cmp       rbp,rcx
       jne       near ptr M04_L13
M04_L49:
       test      byte ptr [rbx+30],80
       je        near ptr M04_L13
       mov       rcx,offset MT_System.NonSerializedAttribute
       call      CORINFO_HELP_NEWSFAST
       mov       r8,rax
       lea       rcx,[rsp+58]
       mov       rdx,offset MT_System.RuntimeType+ListBuilder<System.Attribute>
       call      qword ptr [7FF8E417D4B8]; System.RuntimeType+ListBuilder`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       jmp       near ptr M04_L13
M04_L50:
       mov       rcx,rsi
       call      qword ptr [7FF8E4177C78]; System.RuntimeTypeHandle.<GetModule>g__GetModuleWorker|48_0(System.RuntimeType)
       mov       rcx,rax
       jmp       near ptr M04_L14
M04_L51:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M04_L15
M04_L52:
       mov       rdx,r10
       mov       r8,rax
       call      qword ptr [7FF8E470E850]
       jmp       near ptr M04_L15
M04_L53:
       cmp       rax,10
       jne       short M04_L54
       vmovdqu   xmm0,xmmword ptr [r10]
       vmovdqu   xmmword ptr [rcx],xmm0
       jmp       near ptr M04_L15
M04_L54:
       mov       rdx,r10
       mov       r8,rax
       call      qword ptr [7FF8E4175818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M04_L15
M04_L55:
       mov       [rsp+20],esi
       xor       r8d,r8d
       mov       [rsp+28],r8d
       mov       r8,rbx
       xor       edx,edx
       call      qword ptr [7FF8E47A64F0]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M04_L15
M04_L56:
       movzx     r8d,sil
       mov       rcx,rbx
       mov       rdx,rbp
       mov       rax,[rbx]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       mov       rbx,rax
       jmp       near ptr M04_L15
M04_L57:
       cmp       dword ptr [rbp+8],0
       jbe       short M04_L59
       mov       rcx,[rbp+10]
       cmp       dword ptr [rbp+8],1
       jne       short M04_L58
       mov       rdx,rcx
       jmp       near ptr M04_L18
M04_L58:
       call      qword ptr [7FF8E4835008]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M04_L59:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1845
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
; System.Enum.<GetEnumInfo>g__InitializeEnumInfo|5_0[[System.UInt32, System.Private.CoreLib]](System.RuntimeType, Boolean)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,1A8
       vzeroupper
       lea       rbp,[rsp+1E0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-180],xmm4
       vmovdqa   xmmword ptr [rbp-170],xmm4
       mov       rax,0FFFFFFFFFFFFFEE0
M06_L00:
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       vmovdqa   xmmword ptr [rbp+rax-20],xmm4
       add       rax,30
       jne       short M06_L00
       mov       [rbp-40],rax
       mov       rbx,rcx
       mov       esi,edx
       lea       rcx,[rbp-150]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rdi,rax
       mov       rcx,rsp
       mov       [rbp-138],rcx
       mov       rcx,rbp
       mov       [rbp-128],rcx
       test      sil,sil
       je        near ptr M06_L33
       mov       [rbp+10],rbx
       mov       [rbp-50],rbx
       xor       ecx,ecx
       mov       [rbp-40],rcx
       mov       [rbp-48],rcx
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rbp-60],xmm0
       lea       rcx,[rbp-50]
       mov       [rbp-60],rcx
       mov       rcx,[rbp-50]
       test      rcx,rcx
       je        near ptr M06_L39
       mov       rcx,[rcx+18]
M06_L01:
       mov       [rbp-58],rcx
       vmovups   xmm0,[rbp-60]
       vmovups   [rbp-160],xmm0
       lea       rcx,[rbp-160]
       lea       rdx,[rbp-40]
       lea       r8,[rbp-48]
       mov       r9d,1
       mov       rax,7FF8E40B4EE8
       mov       [rbp-140],rax
       lea       rax,[M06_L02]
       mov       [rbp-130],rax
       lea       rax,[rbp-150]
       mov       [rdi+8],rax
       mov       byte ptr [rdi+4],0
       mov       rax,7FF943CDE150
       call      rax
M06_L02:
       mov       byte ptr [rdi+4],1
       cmp       dword ptr [7FF9440B4A90],0
       je        short M06_L03
       call      qword ptr [7FF9440A2648]; CORINFO_HELP_STOP_FOR_GC
M06_L03:
       mov       rcx,[rbp-148]
       mov       [rdi+8],rcx
       mov       rbx,[rbp-50]
       cmp       [rbx],bl
       mov       rcx,[rbx+18]
       call      00007FF943DABEA0
       test      rax,rax
       jne       near ptr M06_L40
M06_L04:
       mov       rcx,1C35D8001C8
       mov       rsi,[rcx]
       cmp       qword ptr [rsi+8],0
       je        near ptr M06_L11
       mov       r14,[rsi+10]
       xor       r15d,r15d
       mov       r13,[rsi+18]
       mov       rcx,offset MT_System.Collections.Generic.ObjectEqualityComparer<System.RuntimeType>
       cmp       [r13],rcx
       jne       near ptr M06_L43
       mov       rcx,203F2655F08
       mov       [rbp-68],rcx
       xor       ecx,ecx
       mov       [rbp-70],rcx
       lea       rcx,[rbp-68]
       cmp       qword ptr [rbp-70],0
       jne       short M06_L05
       mov       rcx,[rbp-68]
       mov       [rbp-70],rcx
       lea       rcx,[rbp-70]
       cmp       qword ptr [rbp-70],0
       je        near ptr M06_L41
M06_L05:
       mov       r12,[rcx]
       mov       rcx,offset MT_System.RuntimeType
       cmp       [r12],rcx
       jne       near ptr M06_L42
       mov       rcx,r12
       call      00007FF943D7A6D0
       test      eax,eax
       je        near ptr M06_L28
M06_L06:
       mov       r12d,eax
M06_L07:
       xor       ecx,ecx
       mov       [rbp-70],rcx
M06_L08:
       mov       rdx,[rsi+8]
       mov       ecx,r12d
       imul      rcx,[rsi+20]
       shr       rcx,20
       inc       rcx
       mov       r8d,[rdx+8]
       mov       r11d,r8d
       imul      rcx,r11
       shr       rcx,20
       cmp       ecx,r8d
       jae       near ptr M06_L61
       mov       ecx,ecx
       lea       rdx,[rdx+rcx*4+10]
       mov       eax,[rdx]
       dec       eax
       js        short M06_L11
M06_L09:
       cmp       eax,[r14+8]
       jae       near ptr M06_L61
       mov       edx,eax
       shl       rdx,4
       lea       rsi,[r14+rdx+10]
       cmp       [rsi+8],r12d
       je        near ptr M06_L44
M06_L10:
       mov       eax,[rsi+0C]
       inc       r15d
       cmp       [r14+8],r15d
       jb        near ptr M06_L45
       test      eax,eax
       jge       short M06_L09
M06_L11:
       mov       rcx,rbx
       call      00007FF943DA53D0
       mov       rsi,rax
       test      rsi,rsi
       je        near ptr M06_L47
M06_L12:
       mov       [rbp-188],rsi
       mov       rcx,rbx
       call      00007FF943DA8680
       mov       ebx,eax
       cmp       [rsi],sil
       mov       rcx,rsi
       call      00007FF943DF1F10
       mov       [rbp-78],rax
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rbp-0C8],ymm0
       vmovdqu   ymmword ptr [rbp-0A8],ymm0
       vmovdqu   xmmword ptr [rbp-88],xmm0
       mov       dword ptr [rbp-118],10
       mov       rcx,[rbp-78]
       lea       r9,[rbp-0BC]
       mov       [rsp+20],r9
       lea       r9,[rbp-0C8]
       mov       [rsp+28],r9
       lea       r9,[rbp-118]
       mov       r8d,ebx
       mov       edx,0C000000
       mov       rax,7FF8E42BB248
       mov       [rbp-140],rax
       lea       rax,[M06_L13]
       mov       [rbp-130],rax
       lea       rax,[rbp-150]
       mov       [rdi+8],rax
       mov       byte ptr [rdi+4],0
       mov       rax,7FF943CDEA40
       call      rax
M06_L13:
       mov       byte ptr [rdi+4],1
       cmp       dword ptr [7FF9440B4A90],0
       je        short M06_L14
       call      qword ptr [7FF9440A2648]; CORINFO_HELP_STOP_FOR_GC
M06_L14:
       mov       rcx,[rbp-148]
       mov       [rdi+8],rcx
       mov       ecx,[rbp-118]
       mov       [rbp-0C0],ecx
       cmp       dword ptr [rbp-0C0],0
       jne       near ptr M06_L48
M06_L15:
       xor       ebx,ebx
M06_L16:
       xor       ecx,ecx
       mov       [rbp-100],rcx
       mov       [rbp-108],rcx
       test      ebx,ebx
       jne       near ptr M06_L46
M06_L17:
       xor       ebx,ebx
M06_L18:
       mov       rcx,offset MT_System.Enum+EnumInfo<System.UInt32>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdi,[rbp-40]
       mov       r14,[rbp-48]
       mov       [rsi+18],bl
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,1
       mov       ebx,[rdi+8]
       cmp       ebx,1
       jle       short M06_L21
M06_L19:
       lea       eax,[rcx-1]
       cmp       eax,ebx
       jae       near ptr M06_L61
       lea       rax,[rdi+rax*4+10]
       mov       edx,[rdi+rcx*4+10]
       cmp       [rax],edx
       jae       near ptr M06_L29
M06_L20:
       inc       ecx
       cmp       ebx,ecx
       jg        short M06_L19
M06_L21:
       xor       ecx,ecx
       test      ebx,ebx
       jle       short M06_L23
       nop       word ptr [rax+rax]
M06_L22:
       mov       eax,[rdi+rcx*4+10]
       movsxd    rdx,ecx
       cmp       rax,rdx
       jne       near ptr M06_L56
       inc       ecx
       cmp       ebx,ecx
       jg        short M06_L22
M06_L23:
       mov       ecx,1
M06_L24:
       mov       [rsi+19],cl
       xor       ecx,ecx
       mov       [rbp-40],rcx
       mov       [rbp-48],rcx
       mov       rbx,[rbp+10]
       cmp       [rbx],bl
       mov       rcx,rbx
       call      qword ptr [7FF8E417C570]; System.RuntimeType.get_Cache()
       cmp       [rax],al
       lea       rbx,[rax+80]
M06_L25:
       mov       rdi,[rbx]
       test      rdi,rdi
       jne       near ptr M06_L57
M06_L26:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       call      00007FF943D96040
       cmp       rax,rdi
       jne       short M06_L25
M06_L27:
       mov       rax,rsi
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
M06_L28:
       mov       rcx,r12
       call      qword ptr [7FF8E417E970]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       jmp       near ptr M06_L06
M06_L29:
       cmp       [rax],edx
       jbe       near ptr M06_L20
       mov       r15d,ebx
       test      r14,r14
       je        short M06_L30
       mov       ecx,[r14+8]
       sub       ecx,r15d
       js        near ptr M06_L54
M06_L30:
       test      r14,r14
       je        short M06_L32
       lea       r13,[rdi+10]
       add       r14,10
       test      byte ptr [7FF8E485D730],1
       je        near ptr M06_L55
M06_L31:
       mov       rcx,1C35D8022C8
       mov       rcx,[rcx]
       mov       [rbp-170],r13
       mov       [rbp-168],r15d
       mov       [rbp-180],r14
       mov       [rbp-178],r15d
       lea       r8,[rbp-180]
       lea       rdx,[rbp-170]
       mov       r11,7FF8E40C0BA8
       xor       r9d,r9d
       call      qword ptr [r11]
       jmp       near ptr M06_L21
M06_L32:
       mov       rcx,rdi
       mov       r8d,r15d
       xor       edx,edx
       xor       r9d,r9d
       call      qword ptr [7FF8E4836058]
       jmp       near ptr M06_L21
M06_L33:
       cmp       qword ptr [rbx+10],0
       je        short M06_L34
       mov       rcx,[rbx+10]
       mov       rax,[rcx]
       test      rax,rax
       je        short M06_L34
       jmp       short M06_L35
M06_L34:
       mov       rcx,rbx
       call      qword ptr [7FF8E4177C30]; System.RuntimeType.InitializeCache()
M06_L35:
       mov       rsi,[rax+80]
       test      rsi,rsi
       je        short M06_L37
       mov       rdx,rsi
       mov       rcx,offset MT_System.Enum+EnumInfo<System.UInt32>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M06_L36
       mov       rsi,rax
       jmp       short M06_L38
M06_L36:
       mov       rdx,rsi
       mov       rcx,offset MT_System.RuntimeType+CompositeCacheEntry
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M06_L37
       mov       rsi,[rax+28]
       test      rsi,rsi
       je        short M06_L37
       jmp       short M06_L38
M06_L37:
       mov       rdx,rbx
       mov       rcx,offset MT_System.RuntimeType+IGenericCacheEntry<System.Enum+EnumInfo<System.UInt32>>
       call      qword ptr [7FF8E417C4F8]; System.RuntimeType+IGenericCacheEntry`1[[System.__Canon, System.Private.CoreLib]].CreateAndCache(System.RuntimeType)
       mov       rsi,rax
M06_L38:
       jmp       near ptr M06_L27
M06_L39:
       xor       ecx,ecx
       jmp       near ptr M06_L01
M06_L40:
       mov       rcx,rax
       call      qword ptr [7FF8E4175860]; System.RuntimeTypeHandle.GetRuntimeTypeFromHandle(IntPtr)
       test      rax,rax
       jne       near ptr M06_L17
       jmp       near ptr M06_L04
M06_L41:
       xor       r12d,r12d
       jmp       near ptr M06_L07
M06_L42:
       mov       rcx,r12
       mov       rax,[r12]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
       mov       r12d,eax
       jmp       near ptr M06_L07
M06_L43:
       mov       rcx,r13
       mov       rdx,203F2655F08
       mov       r11,7FF8E40C0B98
       call      qword ptr [r11]
       mov       r12d,eax
       jmp       near ptr M06_L08
M06_L44:
       mov       rdx,[rsi]
       mov       rcx,r13
       mov       r8,203F2655F08
       mov       r11,7FF8E40C0BA0
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M06_L10
       jmp       near ptr M06_L11
M06_L45:
       call      qword ptr [7FF8E4397A08]
       int       3
M06_L46:
       mov       ebx,1
       jmp       near ptr M06_L18
M06_L47:
       mov       rcx,rbx
       call      qword ptr [7FF8E4177C78]; System.RuntimeTypeHandle.<GetModule>g__GetModuleWorker|48_0(System.RuntimeType)
       mov       rsi,rax
       jmp       near ptr M06_L12
M06_L48:
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-0E0],xmm0
       vmovdqu   xmmword ptr [rbp-0D8],xmm0
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-0F8],xmm0
       vmovdqu   xmmword ptr [rbp-0F0],xmm0
       xor       esi,esi
       jmp       near ptr M06_L50
M06_L49:
       lea       rcx,[rbp-0C8]
       mov       edx,esi
       call      qword ptr [7FF8E48360B8]
       mov       edx,eax
       lea       r8,[rbp-0D0]
       lea       r9,[rbp-0E0]
       mov       rcx,[rbp-78]
       call      00007FF943DA9180
       test      eax,eax
       jl        short M06_L51
       mov       ecx,[rbp-0D0]
       mov       rdx,203F2655F08
       mov       [rsp+20],rdx
       xor       edx,edx
       mov       [rsp+28],edx
       lea       rdx,[rbp-0F8]
       mov       [rsp+30],rdx
       lea       rdx,[rbp-100]
       mov       [rsp+38],rdx
       lea       rdx,[rbp-108]
       mov       [rsp+40],rdx
       lea       rdx,[rbp-110]
       mov       [rsp+48],rdx
       lea       rdx,[rbp-78]
       mov       r8,[rbp-188]
       mov       r9d,ebx
       call      qword ptr [7FF8E417EBB0]; System.Reflection.CustomAttribute.FilterCustomAttributeRecord(System.Reflection.MetadataToken, System.Reflection.MetadataImport ByRef, System.Reflection.RuntimeModule, System.Reflection.MetadataToken, System.RuntimeType, Boolean, ListBuilder`1<System.Object> ByRef, System.RuntimeType ByRef, System.IRuntimeMethodInfo ByRef, Boolean ByRef)
       test      eax,eax
       jne       short M06_L52
       inc       esi
M06_L50:
       cmp       esi,[rbp-0C0]
       jl        near ptr M06_L49
       jmp       short M06_L53
M06_L51:
       mov       rcx,offset MT_System.BadImageFormatException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8E48352F0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M06_L52:
       mov       ebx,1
       jmp       near ptr M06_L16
M06_L53:
       jmp       near ptr M06_L15
M06_L54:
       mov       ecx,10
       call      qword ptr [7FF8E483C7C8]
       int       3
M06_L55:
       mov       rcx,offset MT_System.Collections.Generic.ArraySortHelper<System.UInt32, System.String>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M06_L31
M06_L56:
       xor       ecx,ecx
       jmp       near ptr M06_L24
M06_L57:
       mov       rdx,rdi
       mov       rcx,offset MT_System.Enum+EnumInfo<System.UInt32>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M06_L26
M06_L58:
       mov       rdi,[rbx]
       mov       rdx,rdi
       mov       rcx,offset MT_System.RuntimeType+CompositeCacheEntry
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r14,rax
       test      r14,r14
       jne       short M06_L59
       mov       rcx,offset MT_System.RuntimeType+CompositeCacheEntry
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,rdi
       mov       rdx,r14
       mov       r11,7FF8E40C0BB0
       call      qword ptr [r11]
       mov       rcx,rbx
       mov       rdx,r14
       mov       r8,rdi
       call      00007FF943D96040
       cmp       rax,rdi
       jne       short M06_L58
M06_L59:
       mov       rdi,[r14+28]
       lea       rcx,[r14+28]
       test      rcx,rcx
       je        short M06_L60
       mov       rdx,rsi
       mov       r8,rdi
       call      00007FF943D96040
       cmp       rax,rdi
       jne       short M06_L58
       jmp       near ptr M06_L27
M06_L60:
       call      qword ptr [7FF8E48357A0]
       int       3
M06_L61:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 2033
```
```assembly
; System.Enum.ToString()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
M07_L00:
       mov       rcx,rbx
       call      qword ptr [7FF8E417C9A8]; System.Object.GetType()
       mov       rsi,rax
       lea       rdi,[rbx+8]
       mov       rcx,[rbx]
       call      00007FF943DAE010
       add       eax,0FFFFFFFC
       cmp       eax,4
       jne       near ptr M07_L07
       mov       edi,[rdi]
       mov       rbx,[rsi+10]
       test      rbx,rbx
       je        near ptr M07_L26
       mov       rax,[rbx]
       test      rax,rax
       je        near ptr M07_L26
M07_L01:
       mov       rcx,[rax+80]
       test      rcx,rcx
       je        short M07_L06
       mov       rdx,offset MT_System.Enum+EnumInfo<System.UInt32>
       cmp       [rcx],rdx
       je        short M07_L02
       mov       rdx,offset MT_System.RuntimeType+CompositeCacheEntry
       cmp       [rcx],rdx
       jne       short M07_L06
       mov       rcx,[rcx+28]
M07_L02:
       test      rcx,rcx
       je        near ptr M07_L27
       cmp       qword ptr [rcx+10],0
       je        near ptr M07_L27
M07_L03:
       cmp       byte ptr [rcx+18],0
       jne       near ptr M07_L34
       mov       rsi,[rcx+10]
       cmp       byte ptr [rcx+19],0
       je        near ptr M07_L28
       mov       ebx,[rsi+8]
       cmp       ebx,edi
       jbe       near ptr M07_L33
       mov       ecx,edi
       mov       rax,[rsi+rcx*8+10]
M07_L04:
       test      rax,rax
       je        near ptr M07_L35
M07_L05:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M07_L06:
       xor       ecx,ecx
       jmp       short M07_L02
M07_L07:
       cmp       eax,7
       ja        short M07_L08
       mov       ecx,eax
       lea       rdx,[7FF8E4896188]
       mov       edx,[rdx+rcx*4]
       lea       rax,[M07_L00]
       add       rdx,rax
       jmp       rdx
M07_L08:
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FF8E4836808]
       jmp       short M07_L05
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FF8E4836580]
       jmp       short M07_L05
       movzx     edi,byte ptr [rdi]
       mov       rbx,[rsi+10]
       test      rbx,rbx
       je        short M07_L09
       mov       rax,[rbx]
       test      rax,rax
       je        short M07_L09
       jmp       short M07_L10
M07_L09:
       mov       rcx,rsi
       call      qword ptr [7FF8E4177C30]; System.RuntimeType.InitializeCache()
M07_L10:
       mov       rbx,[rax+80]
       test      rbx,rbx
       je        short M07_L12
       mov       rdx,rbx
       mov       rcx,offset MT_System.Enum+EnumInfo<System.Byte>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M07_L11
       mov       rcx,rax
       jmp       short M07_L13
M07_L11:
       mov       rdx,rbx
       mov       rcx,offset MT_System.RuntimeType+CompositeCacheEntry
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M07_L12
       mov       rcx,[rax+28]
       jmp       short M07_L13
M07_L12:
       xor       ecx,ecx
M07_L13:
       test      rcx,rcx
       je        short M07_L14
       cmp       qword ptr [rcx+10],0
       jne       short M07_L15
M07_L14:
       mov       rcx,rsi
       mov       edx,1
       call      qword ptr [7FF8E4836640]
       mov       rcx,rax
M07_L15:
       cmp       byte ptr [rcx+18],0
       jne       short M07_L23
       mov       rsi,[rcx+10]
       cmp       byte ptr [rcx+19],0
       je        short M07_L16
       cmp       [rsi+8],edi
       jbe       short M07_L21
       mov       eax,edi
       mov       rax,[rsi+rax*8+10]
       jmp       short M07_L22
M07_L16:
       mov       rcx,[rcx+8]
       test      rcx,rcx
       jne       short M07_L17
       xor       eax,eax
       xor       r8d,r8d
       jmp       short M07_L18
M07_L17:
       lea       rax,[rcx+10]
       mov       r8d,[rcx+8]
M07_L18:
       cmp       dword ptr [rcx+8],20
       jle       short M07_L19
       mov       rcx,rax
       mov       edx,r8d
       mov       r8d,edi
       call      qword ptr [7FF8E4836760]
       jmp       short M07_L20
M07_L19:
       mov       rcx,rax
       mov       edx,edi
       call      qword ptr [7FF8E4706508]; System.SpanHelpers.NonPackedIndexOfValueType[[System.Byte, System.Private.CoreLib],[System.SpanHelpers+DontNegate`1[[System.Byte, System.Private.CoreLib]], System.Private.CoreLib]](Byte ByRef, Byte, Int32)
M07_L20:
       cmp       [rsi+8],eax
       jbe       short M07_L21
       mov       ecx,eax
       mov       rax,[rsi+rcx*8+10]
       jmp       short M07_L22
M07_L21:
       xor       eax,eax
M07_L22:
       jmp       short M07_L24
M07_L23:
       mov       edx,edi
       call      qword ptr [7FF8E4836598]
M07_L24:
       test      rax,rax
       jne       short M07_L25
       mov       ecx,edi
       call      qword ptr [7FF8E41779F0]; System.Number.UInt32ToDecStr(UInt32)
M07_L25:
       jmp       near ptr M07_L05
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FF8E4836550]
       jmp       near ptr M07_L05
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FF8E4836538]
       jmp       near ptr M07_L05
M07_L26:
       mov       rcx,rsi
       call      qword ptr [7FF8E4177C30]; System.RuntimeType.InitializeCache()
       jmp       near ptr M07_L01
M07_L27:
       mov       rcx,rsi
       mov       edx,1
       call      qword ptr [7FF8E439DE48]; System.Enum.<GetEnumInfo>g__InitializeEnumInfo|5_0[[System.UInt32, System.Private.CoreLib]](System.RuntimeType, Boolean)
       mov       rcx,rax
       jmp       near ptr M07_L03
M07_L28:
       mov       rcx,[rcx+8]
       test      rcx,rcx
       jne       short M07_L29
       xor       eax,eax
       xor       r8d,r8d
       jmp       short M07_L30
M07_L29:
       lea       rax,[rcx+10]
       mov       r8d,[rcx+8]
M07_L30:
       cmp       dword ptr [rcx+8],20
       jle       short M07_L31
       mov       rcx,rax
       mov       edx,r8d
       mov       r8d,edi
       call      qword ptr [7FF8E4835C20]
       jmp       short M07_L32
M07_L31:
       mov       rcx,rax
       mov       edx,edi
       call      qword ptr [7FF8E4835E30]; System.SpanHelpers.NonPackedIndexOfValueType[[System.Int32, System.Private.CoreLib],[System.SpanHelpers+DontNegate`1[[System.Int32, System.Private.CoreLib]], System.Private.CoreLib]](Int32 ByRef, Int32, Int32)
M07_L32:
       mov       ebx,[rsi+8]
       cmp       ebx,eax
       jbe       short M07_L33
       mov       ecx,eax
       mov       rax,[rsi+rcx*8+10]
       jmp       near ptr M07_L04
M07_L33:
       xor       eax,eax
       jmp       near ptr M07_L04
M07_L34:
       mov       edx,edi
       call      qword ptr [7FF8E48367C0]
       jmp       near ptr M07_L04
M07_L35:
       mov       ecx,edi
       call      qword ptr [7FF8E42EF210]; System.Number.Int32ToDecStr(Int32)
       jmp       near ptr M07_L05
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FF8E4836508]
       jmp       near ptr M07_L05
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FF8E48364F0]
       jmp       near ptr M07_L05
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FF8E48364D8]
       jmp       near ptr M07_L05
; Total bytes of code 754
```
```assembly
; System.String.IsNullOrEmpty(System.String)
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       test      rbx,rbx
       je        short M08_L00
       mov       rcx,7FF8E482A020
       call      CORINFO_HELP_COUNTPROFILE32
       cmp       dword ptr [rbx+8],0
       sete      al
       movzx     eax,al
       add       rsp,20
       pop       rbx
       ret
M08_L00:
       mov       rcx,7FF8E482A024
       call      CORINFO_HELP_COUNTPROFILE32
       mov       eax,1
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 70
```

