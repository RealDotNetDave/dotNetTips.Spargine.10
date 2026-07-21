## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderBenchmark.Format_ForComparison()
       push      rsi
       push      rbx
       sub       rsp,38
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       xor       eax,eax
       mov       [rsp+30],rax
       mov       rbx,rcx
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       dword ptr [rsi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,[rbx+198]
       test      r9,r9
       je        short M00_L01
       lea       rcx,[r9+10]
       mov       r9d,[r9+8]
M00_L00:
       mov       [rsp+20],rcx
       mov       [rsp+28],r9d
       lea       r9,[rsp+20]
       mov       rcx,rsi
       xor       edx,edx
       mov       r8,24312890AA0
       call      qword ptr [7FF8A823E5B0]; System.Text.StringBuilder.AppendFormat(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF8A7E02200]; System.Text.StringBuilder.ToString()
       mov       [rsp+30],rax
       mov       rbx,[rbx+88]
       mov       rdx,[rsp+30]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,38
       pop       rbx
       pop       rsi
       ret
M00_L01:
       xor       ecx,ecx
       xor       r9d,r9d
       jmp       short M00_L00
; Total bytes of code 196
```
```assembly
; System.Text.StringBuilder.AppendFormat(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,0C8
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+70],ymm4
       mov       rbx,rcx
       mov       rdi,rdx
       mov       rsi,r8
       mov       rbp,[r9]
       mov       r14d,[r9+8]
       test      rsi,rsi
       je        near ptr M01_L37
       test      rdi,rdi
       jne       near ptr M01_L38
       xor       edx,edx
M01_L00:
       mov       rcx,offset MT_System.ICustomFormatter
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastInterface(Void*, System.Object)
       mov       r15,rax
       xor       r13d,r13d
M01_L01:
       mov       r12d,[rsi+8]
       cmp       r12d,r13d
       jbe       near ptr M01_L36
       mov       r8d,r13d
       lea       rax,[rsi+r8*2+0C]
       mov       [rsp+50],rax
       mov       r10d,r12d
       sub       r10d,r13d
       mov       [rsp+0B4],r10d
       mov       r8d,7D
       mov       edx,7B
       mov       rcx,rax
       mov       r9d,r10d
       call      qword ptr [7FF8A7E3C630]; System.PackedSpanHelpers.IndexOfAny[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib],[System.PackedSpanHelpers+NopTransform, System.Private.CoreLib]](Int16 ByRef, Int16, Int16, Int32)
       mov       [rsp+0B0],eax
       test      eax,eax
       jl        near ptr M01_L81
       mov       r10d,[rsp+0B4]
       cmp       eax,r10d
       ja        near ptr M01_L92
       test      eax,eax
       je        short M01_L03
       mov       r8,[rbx+8]
       mov       r10d,[rbx+18]
       mov       r9d,r10d
       mov       [rsp+0AC],r9d
       lea       ecx,[r9+rax]
       cmp       ecx,[r8+8]
       ja        short M01_L05
       movsxd    rcx,r9d
       lea       rcx,[r8+rcx*2+10]
       cmp       eax,2
       jle       near ptr M01_L39
       mov       r8d,eax
       add       r8,r8
       mov       rdx,[rsp+50]
       call      qword ptr [7FF8A7C15818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L02:
       mov       eax,[rsp+0B0]
       mov       r9d,eax
       add       r9d,[rsp+0AC]
       mov       [rbx+18],r9d
M01_L03:
       add       r13d,eax
       cmp       r13d,r12d
       jae       near ptr M01_L96
       mov       ecx,r13d
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       inc       r13d
       cmp       r12d,r13d
       ja        near ptr M01_L15
M01_L04:
       mov       ecx,r13d
       mov       edx,4C
       call      qword ptr [7FF8A82B5A58]
       int       3
M01_L05:
       mov       r8d,r10d
       add       r8d,[rbx+1C]
       add       r8d,eax
       cmp       r8d,[rbx+20]
       jg        near ptr M01_L82
       cmp       r8d,eax
       jl        near ptr M01_L82
       mov       r8,[rbx+8]
       mov       r9d,[r8+8]
       sub       r9d,r10d
       mov       [rsp+0A8],r9d
       test      r9d,r9d
       jle       short M01_L07
       mov       r8,[rbx+8]
       test      r8,r8
       je        near ptr M01_L41
       cmp       [r8+8],r10d
       jb        near ptr M01_L92
       mov       ecx,r10d
       lea       rcx,[r8+rcx*2+10]
       mov       r8d,[r8+8]
       sub       r8d,r10d
M01_L06:
       cmp       r9d,r8d
       ja        near ptr M01_L95
       mov       r8d,r9d
       add       r8,r8
       mov       rdx,[rsp+50]
       call      qword ptr [7FF8A7C15818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
       mov       r9d,[rsp+0A8]
M01_L07:
       mov       eax,[rsp+0B0]
       mov       r8d,eax
       sub       r8d,r9d
       mov       [rsp+0A4],r8d
       mov       ecx,[rbx+1C]
       lea       edx,[r8+rcx]
       mov       r10d,[rbx+18]
       add       edx,r10d
       cmp       edx,[rbx+20]
       jg        near ptr M01_L83
       cmp       edx,r8d
       jl        near ptr M01_L83
       add       ecx,r10d
       mov       edx,ecx
       cmp       edx,1F40
       jg        short M01_L10
M01_L08:
       cmp       r8d,edx
       jl        short M01_L11
       mov       r10d,r8d
M01_L09:
       add       ecx,r10d
       cmp       ecx,r10d
       jl        near ptr M01_L84
       cmp       r10d,400
       jge       short M01_L12
       movsxd    rdx,r10d
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rsp+40],rax
       jmp       short M01_L13
M01_L10:
       mov       edx,1F40
       jmp       short M01_L08
M01_L11:
       mov       r10d,edx
       jmp       short M01_L09
M01_L12:
       mov       ecx,r10d
       xor       edx,edx
       call      qword ptr [7FF8A819F078]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       [rsp+40],rax
M01_L13:
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+48],rax
       mov       ecx,[rbx+18]
       mov       [rax+18],ecx
       mov       ecx,[rbx+1C]
       mov       [rax+1C],ecx
       mov       rdx,[rbx+8]
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbx+10]
       mov       rax,[rsp+48]
       lea       rcx,[rax+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rbx+20]
       mov       rax,[rsp+48]
       mov       [rax+20],ecx
       lea       rcx,[rbx+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rbx+18]
       add       [rbx+1C],ecx
       xor       ecx,ecx
       mov       [rbx+18],ecx
       lea       rcx,[rbx+8]
       mov       rdx,[rsp+40]
       call      CORINFO_HELP_ASSIGN_REF
       movsxd    r8,dword ptr [rsp+0A8]
       mov       rax,[rsp+50]
       lea       rdx,[rax+r8*2]
       mov       r8,[rbx+8]
       test      r8,r8
       je        near ptr M01_L42
       lea       rcx,[r8+10]
       mov       r8d,[r8+8]
M01_L14:
       mov       eax,[rsp+0A4]
       cmp       eax,r8d
       ja        near ptr M01_L95
       mov       r8d,eax
       add       r8,r8
       call      qword ptr [7FF8A7C15818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsp+0A4]
       mov       [rbx+18],ecx
       mov       eax,[rsp+0B0]
       jmp       near ptr M01_L03
M01_L15:
       mov       eax,r13d
       movzx     edx,word ptr [rsi+rax*2+0C]
       cmp       ecx,edx
       je        near ptr M01_L43
       cmp       ecx,7B
       jne       near ptr M01_L85
       xor       eax,eax
       xor       r8d,r8d
       xor       r10d,r10d
       xor       r9d,r9d
       add       edx,0FFFFFFD0
       cmp       edx,0A
       jae       near ptr M01_L86
       inc       r13d
       cmp       r12d,r13d
       jbe       near ptr M01_L04
       mov       ecx,r13d
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       mov       r11d,ecx
       cmp       r11d,7D
       jne       near ptr M01_L44
M01_L16:
       inc       r13d
       xor       r12d,r12d
       xor       r11d,r11d
       cmp       edx,r14d
       jae       near ptr M01_L89
       mov       ecx,edx
       mov       rdx,[rbp+rcx*8]
       mov       [rsp+58],rdx
       test      r15,r15
       jne       near ptr M01_L57
M01_L17:
       test      r12,r12
       jne       near ptr M01_L24
       mov       [rsp+0C0],eax
       test      eax,eax
       jne       short M01_L18
       mov       [rsp+0C4],r8d
       test      r8d,r8d
       mov       r8d,[rsp+0C4]
       jne       near ptr M01_L60
M01_L18:
       mov       rdx,[rsp+58]
       mov       rcx,rdx
       test      rcx,rcx
       je        short M01_L19
       mov       r12,offset MT_System.String
       cmp       [rcx],r12
       jne       near ptr M01_L59
       xor       ecx,ecx
M01_L19:
       test      rcx,rcx
       jne       near ptr M01_L62
M01_L20:
       mov       r12,rdx
       test      r12,r12
       je        short M01_L21
       mov       rcx,offset MT_System.String
       cmp       [r12],rcx
       jne       near ptr M01_L69
       xor       r12d,r12d
M01_L21:
       test      r12,r12
       jne       near ptr M01_L70
       test      rdx,rdx
       je        near ptr M01_L73
       mov       rcx,offset MT_System.String
       cmp       [rdx],rcx
       jne       near ptr M01_L74
M01_L22:
       mov       r12,rdx
M01_L23:
       test      r12,r12
       je        near ptr M01_L75
       mov       eax,[rsp+0C0]
M01_L24:
       mov       r10d,[r12+8]
       mov       [rsp+68],r10d
       mov       [rsp+0C4],r8d
       cmp       r10d,r8d
       jl        near ptr M01_L79
       add       r12,0C
       mov       eax,r10d
       test      eax,eax
       je        near ptr M01_L01
       mov       r8,[rbx+8]
       mov       r10d,[rbx+18]
       mov       ecx,r10d
       lea       r9d,[rcx+rax]
       mov       [rsp+6C],r9d
       cmp       r9d,[r8+8]
       ja        short M01_L26
       movsxd    rcx,ecx
       lea       rcx,[r8+rcx*2+10]
       cmp       eax,2
       jle       near ptr M01_L76
       mov       r8d,eax
       add       r8,r8
       mov       rdx,r12
       call      qword ptr [7FF8A7C15818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L25:
       mov       r9d,[rsp+6C]
       mov       [rbx+18],r9d
       jmp       near ptr M01_L01
M01_L26:
       mov       r8d,r10d
       add       r8d,[rbx+1C]
       add       r8d,eax
       cmp       r8d,[rbx+20]
       jg        near ptr M01_L91
       mov       [rsp+0A0],eax
       cmp       r8d,eax
       jl        near ptr M01_L91
       mov       r8,[rbx+8]
       mov       r9d,[r8+8]
       sub       r9d,r10d
       mov       [rsp+9C],r9d
       test      r9d,r9d
       jle       short M01_L28
       mov       r8,[rbx+8]
       test      r8,r8
       je        near ptr M01_L77
       cmp       [r8+8],r10d
       jb        near ptr M01_L92
       mov       ecx,r10d
       lea       rcx,[r8+rcx*2+10]
       mov       r8d,[r8+8]
       sub       r8d,r10d
M01_L27:
       cmp       r9d,r8d
       ja        near ptr M01_L95
       mov       r8d,r9d
       add       r8,r8
       mov       rdx,r12
       call      qword ptr [7FF8A7C15818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
       mov       r9d,[rsp+9C]
M01_L28:
       mov       eax,[rsp+0A0]
       sub       eax,r9d
       mov       [rsp+98],eax
       mov       ecx,[rbx+1C]
       lea       edx,[rax+rcx]
       mov       r8d,[rbx+18]
       add       edx,r8d
       cmp       edx,[rbx+20]
       jg        near ptr M01_L93
       cmp       edx,eax
       jl        near ptr M01_L93
       add       ecx,r8d
       mov       edx,ecx
       cmp       edx,1F40
       jg        short M01_L31
M01_L29:
       cmp       eax,edx
       jl        short M01_L32
       mov       r8d,eax
M01_L30:
       add       ecx,r8d
       cmp       ecx,r8d
       jl        near ptr M01_L94
       cmp       r8d,400
       jge       short M01_L33
       movsxd    rdx,r8d
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rsp+30],rax
       jmp       short M01_L34
M01_L31:
       mov       edx,1F40
       jmp       short M01_L29
M01_L32:
       mov       r8d,edx
       jmp       short M01_L30
M01_L33:
       mov       ecx,r8d
       xor       edx,edx
       call      qword ptr [7FF8A819F078]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       [rsp+30],rax
M01_L34:
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+38],rax
       mov       ecx,[rbx+18]
       mov       [rax+18],ecx
       mov       ecx,[rbx+1C]
       mov       [rax+1C],ecx
       mov       rdx,[rbx+8]
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbx+10]
       mov       rax,[rsp+38]
       lea       rcx,[rax+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rbx+20]
       mov       rax,[rsp+38]
       mov       [rax+20],ecx
       lea       rcx,[rbx+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rbx+18]
       add       [rbx+1C],ecx
       xor       ecx,ecx
       mov       [rbx+18],ecx
       lea       rcx,[rbx+8]
       mov       rdx,[rsp+30]
       call      CORINFO_HELP_ASSIGN_REF
       movsxd    r8,dword ptr [rsp+9C]
       lea       rdx,[r12+r8*2]
       mov       r8,[rbx+8]
       test      r8,r8
       je        near ptr M01_L78
       lea       rcx,[r8+10]
       mov       r8d,[r8+8]
M01_L35:
       mov       r12d,[rsp+98]
       cmp       r12d,r8d
       ja        near ptr M01_L95
       mov       r8d,r12d
       add       r8,r8
       call      qword ptr [7FF8A7C15818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       [rbx+18],r12d
       jmp       near ptr M01_L01
M01_L36:
       mov       rax,rbx
       add       rsp,0C8
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L37:
       mov       ecx,3B9
       mov       rdx,7FF8A7B54000
       call      qword ptr [7FF8A7E37798]
       mov       rcx,rax
       call      qword ptr [7FF8A82B4C30]
       int       3
M01_L38:
       mov       rcx,rdi
       mov       r11,7FF8A7B60AB8
       mov       rdx,24312890B10
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       near ptr M01_L00
M01_L39:
       mov       r10,[rsp+50]
       movzx     r8d,word ptr [r10]
       mov       [rcx],r8w
       cmp       eax,2
       jne       short M01_L40
       movzx     r8d,word ptr [r10+2]
       mov       [rcx+2],r8w
       jmp       near ptr M01_L02
M01_L40:
       jmp       near ptr M01_L02
M01_L41:
       test      r10d,r10d
       jne       near ptr M01_L92
       xor       ecx,ecx
       xor       r8d,r8d
       jmp       near ptr M01_L06
M01_L42:
       xor       ecx,ecx
       xor       r8d,r8d
       jmp       near ptr M01_L14
M01_L43:
       mov       rcx,rbx
       call      qword ptr [7FF8A7D8F180]; System.Text.StringBuilder.Append(Char)
       inc       r13d
       jmp       near ptr M01_L01
M01_L44:
       lea       ecx,[r11-30]
       cmp       ecx,9
       ja        short M01_L47
       jmp       short M01_L46
M01_L45:
       lea       edx,[rdx+rdx*4]
       lea       edx,[r11+rdx*2-30]
       inc       r13d
       cmp       r12d,r13d
       jbe       near ptr M01_L04
       mov       r11d,r13d
       movzx     r11d,word ptr [rsi+r11*2+0C]
       jmp       short M01_L44
M01_L46:
       cmp       edx,0F4240
       jl        short M01_L45
M01_L47:
       cmp       r11d,20
       jne       short M01_L48
       inc       r13d
       cmp       r12d,r13d
       jbe       near ptr M01_L04
       mov       r11d,r13d
       movzx     r11d,word ptr [rsi+r11*2+0C]
       jmp       short M01_L47
M01_L48:
       cmp       r11d,2C
       jne       near ptr M01_L54
M01_L49:
       inc       r13d
       cmp       r12d,r13d
       jbe       near ptr M01_L04
       mov       r11d,r13d
       movzx     r11d,word ptr [rsi+r11*2+0C]
       cmp       r11d,20
       je        short M01_L49
       cmp       r11d,2D
       jne       short M01_L50
       mov       dword ptr [rsp+0C0],1
       inc       r13d
       cmp       r12d,r13d
       jbe       near ptr M01_L04
       mov       r11d,r13d
       movzx     r11d,word ptr [rsi+r11*2+0C]
       mov       eax,[rsp+0C0]
M01_L50:
       lea       r8d,[r11-30]
       cmp       r8d,0A
       jae       near ptr M01_L86
       inc       r13d
       cmp       r12d,r13d
       ja        short M01_L52
       jmp       near ptr M01_L04
M01_L51:
       lea       r8d,[r8+r8*4]
       lea       r8d,[r11+r8*2-30]
       mov       [rsp+0C4],r8d
       inc       r13d
       cmp       r12d,r13d
       mov       r8d,[rsp+0C4]
       jbe       near ptr M01_L04
M01_L52:
       cmp       r13d,r12d
       jae       near ptr M01_L96
       mov       r11d,r13d
       movzx     r11d,word ptr [rsi+r11*2+0C]
       lea       ecx,[r11-30]
       cmp       ecx,9
       ja        short M01_L53
       cmp       r8d,0F4240
       jl        short M01_L51
M01_L53:
       cmp       r11d,20
       jne       short M01_L54
       inc       r13d
       cmp       r12d,r13d
       jbe       near ptr M01_L04
       mov       r11d,r13d
       movzx     r11d,word ptr [rsi+r11*2+0C]
       jmp       short M01_L53
M01_L54:
       cmp       r11d,7D
       je        near ptr M01_L16
       cmp       r11d,3A
       jne       near ptr M01_L87
       mov       r10d,r13d
M01_L55:
       inc       r13d
       cmp       r12d,r13d
       jbe       near ptr M01_L04
       mov       r11d,r13d
       movzx     r11d,word ptr [rsi+r11*2+0C]
       cmp       r11d,7D
       je        short M01_L56
       cmp       r11d,7B
       jne       short M01_L55
       jmp       near ptr M01_L87
M01_L56:
       inc       r10d
       mov       r9d,r13d
       sub       r9d,r10d
       mov       ecx,r10d
       mov       r11d,r9d
       add       rcx,r11
       mov       r11d,r12d
       cmp       rcx,r11
       ja        near ptr M01_L88
       mov       ecx,r10d
       lea       r10,[rsi+rcx*2+0C]
       mov       r12,r10
       mov       r10d,r9d
       mov       r9d,r10d
       mov       r10,r12
       jmp       near ptr M01_L16
M01_L57:
       test      r9d,r9d
       mov       [rsp+0C4],r8d
       mov       [rsp+0C0],eax
       je        near ptr M01_L61
       mov       [rsp+28],r10
       mov       [rsp+80],r10
       mov       [rsp+94],r9d
       mov       [rsp+88],r9d
       lea       rcx,[rsp+80]
       call      System.String.Ctor(System.ReadOnlySpan`1<Char>)
       mov       r12,rax
       mov       r11,r12
M01_L58:
       mov       rcx,r15
       mov       r9,rdi
       mov       [rsp+60],r11
       mov       rdx,r11
       mov       r8,[rsp+58]
       mov       r11,7FF8A7B60AD0
       call      qword ptr [r11]
       mov       r12,rax
       mov       eax,[rsp+0C0]
       mov       r8d,[rsp+0C4]
       mov       r9d,[rsp+94]
       mov       r10,[rsp+28]
       mov       r11,[rsp+60]
       jmp       near ptr M01_L17
M01_L59:
       mov       [rsp+0C4],r8d
       mov       [rsp+94],r9d
       mov       [rsp+28],r10
       mov       [rsp+60],r11
       mov       rcx,offset MT_System.ISpanFormattable
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rcx,rax
       mov       rdx,[rsp+58]
       mov       r8d,[rsp+0C4]
       mov       r9d,[rsp+94]
       mov       r10,[rsp+28]
       mov       r11,[rsp+60]
       jmp       near ptr M01_L19
M01_L60:
       mov       rdx,[rsp+58]
       jmp       near ptr M01_L20
M01_L61:
       mov       [rsp+94],r9d
       mov       [rsp+28],r10
       jmp       near ptr M01_L58
M01_L62:
       mov       [rsp+28],r10
       mov       [rsp+60],r11
       mov       r12,[rbx+8]
       mov       r11d,[rbx+18]
       mov       r10,[rbx+8]
       mov       r10d,[r10+8]
       sub       r10d,[rbx+18]
       test      r12,r12
       jne       short M01_L63
       or        r11d,r10d
       jne       near ptr M01_L92
       xor       r11d,r11d
       xor       r10d,r10d
       mov       [rsp+0C4],r8d
       jmp       short M01_L64
M01_L63:
       mov       [rsp+94],r9d
       mov       r9d,r11d
       mov       eax,r10d
       add       r9,rax
       mov       eax,[r12+8]
       cmp       r9,rax
       ja        near ptr M01_L92
       mov       r11d,r11d
       lea       r9,[r12+r11*2+10]
       mov       [rsp+0C4],r8d
       mov       r11,r9
       mov       r9d,[rsp+94]
M01_L64:
       mov       [rsp+70],r11
       mov       [rsp+78],r10d
       mov       r12,[rsp+28]
       mov       [rsp+80],r12
       mov       [rsp+94],r9d
       mov       [rsp+88],r9d
       mov       [rsp+20],rdi
       lea       rdx,[rsp+70]
       lea       r9,[rsp+80]
       lea       r8,[rsp+0B8]
       mov       r11,7FF8A7B60AC8
       call      qword ptr [r11]
       test      eax,eax
       mov       rdx,[rsp+58]
       mov       r9d,[rsp+94]
       mov       r10,[rsp+28]
       mov       r11,[rsp+60]
       je        short M01_L65
       mov       r8d,[rsp+0B8]
       mov       rcx,[rbx+8]
       mov       edx,[rbx+18]
       mov       rax,[rbx+8]
       mov       eax,[rax+8]
       sub       eax,[rbx+18]
       test      rcx,rcx
       jne       short M01_L67
       or        edx,eax
       je        short M01_L66
       jmp       near ptr M01_L92
M01_L65:
       mov       r8d,[rsp+0C4]
       jmp       near ptr M01_L20
M01_L66:
       xor       eax,eax
       jmp       short M01_L68
M01_L67:
       mov       edx,edx
       mov       r10d,eax
       add       rdx,r10
       mov       ecx,[rcx+8]
       cmp       rdx,rcx
       ja        near ptr M01_L92
M01_L68:
       cmp       r8d,eax
       ja        near ptr M01_L90
       mov       r8d,[rsp+0B8]
       add       [rbx+18],r8d
       cmp       dword ptr [rsp+0C0],0
       je        near ptr M01_L01
       mov       r12d,[rsp+0C4]
       cmp       r12d,[rsp+0B8]
       jle       near ptr M01_L01
       mov       r8d,r12d
       sub       r8d,[rsp+0B8]
       mov       rcx,rbx
       mov       edx,20
       call      qword ptr [7FF8A82B5A40]
       jmp       near ptr M01_L01
M01_L69:
       mov       [rsp+0C4],r8d
       mov       [rsp+94],r9d
       mov       [rsp+28],r10
       mov       [rsp+60],r11
       mov       rcx,offset MT_System.IFormattable
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       r12,rax
       mov       rdx,[rsp+58]
       mov       r8d,[rsp+0C4]
       mov       r9d,[rsp+94]
       mov       r10,[rsp+28]
       mov       r11,[rsp+60]
       jmp       near ptr M01_L21
M01_L70:
       test      r9d,r9d
       je        short M01_L72
       test      r11,r11
       mov       [rsp+0C4],r8d
       jne       short M01_L71
       mov       [rsp+80],r10
       mov       [rsp+88],r9d
       lea       rcx,[rsp+80]
       call      System.String.Ctor(System.ReadOnlySpan`1<Char>)
       mov       rdx,rax
       mov       r11,rdx
M01_L71:
       mov       rcx,r12
       mov       r8,rdi
       mov       rdx,r11
       mov       r11,7FF8A7B60AC0
       call      qword ptr [r11]
       mov       r12,rax
       mov       r8d,[rsp+0C4]
       jmp       near ptr M01_L23
M01_L72:
       mov       [rsp+0C4],r8d
       jmp       short M01_L71
M01_L73:
       xor       r12d,r12d
       jmp       near ptr M01_L23
M01_L74:
       mov       [rsp+0C4],r8d
       mov       rcx,rdx
       mov       rdx,[rdx]
       mov       rdx,[rdx+40]
       call      qword ptr [rdx+8]
       mov       rdx,rax
       mov       r8d,[rsp+0C4]
       jmp       near ptr M01_L22
M01_L75:
       mov       r12,24312880008
       mov       eax,[rsp+0C0]
       jmp       near ptr M01_L24
M01_L76:
       movzx     r8d,word ptr [r12]
       mov       [rcx],r8w
       cmp       eax,2
       jne       near ptr M01_L25
       movzx     eax,word ptr [r12+2]
       mov       [rcx+2],ax
       jmp       near ptr M01_L25
M01_L77:
       test      r10d,r10d
       jne       near ptr M01_L92
       xor       ecx,ecx
       xor       r8d,r8d
       jmp       near ptr M01_L27
M01_L78:
       xor       ecx,ecx
       xor       r8d,r8d
       jmp       near ptr M01_L35
M01_L79:
       test      eax,eax
       je        short M01_L80
       mov       rcx,rbx
       mov       rdx,r12
       call      qword ptr [7FF8A7D8F228]; System.Text.StringBuilder.Append(System.String)
       mov       r12d,[rsp+0C4]
       mov       r8d,r12d
       sub       r8d,[rsp+68]
       mov       rcx,rbx
       mov       edx,20
       call      qword ptr [7FF8A82B5A40]
       jmp       near ptr M01_L01
M01_L80:
       mov       r8d,[rsp+0C4]
       sub       r8d,r10d
       mov       rcx,rbx
       mov       edx,20
       call      qword ptr [7FF8A82B5A40]
       mov       rcx,rbx
       mov       rdx,r12
       call      qword ptr [7FF8A7D8F228]; System.Text.StringBuilder.Append(System.String)
       jmp       near ptr M01_L01
M01_L81:
       mov       rsi,[rsp+50]
       mov       [rsp+80],rsi
       mov       esi,[rsp+0B4]
       mov       [rsp+88],esi
       lea       rdx,[rsp+80]
       mov       rcx,rbx
       call      qword ptr [7FF8A8236910]; System.Text.StringBuilder.Append(System.ReadOnlySpan`1<Char>)
       jmp       near ptr M01_L36
M01_L82:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,19685
       mov       rdx,7FF8A7B54000
       call      qword ptr [7FF8A7E37798]
       mov       rsi,rax
       call      qword ptr [7FF8A82B54E8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF8A7E3D9C8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L83:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,1969B
       mov       rdx,7FF8A7B54000
       call      qword ptr [7FF8A7E37798]
       mov       rsi,rax
       call      qword ptr [7FF8A82B5530]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF8A7E3D9C8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L84:
       mov       rcx,offset MT_System.OutOfMemoryException
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,r13
       call      qword ptr [7FF8A82B5548]
       mov       rcx,r13
       call      CORINFO_HELP_THROW
       int       3
M01_L85:
       mov       ecx,r13d
       mov       edx,4B
       call      qword ptr [7FF8A82B5A58]
       int       3
M01_L86:
       mov       ecx,r13d
       mov       edx,4D
       call      qword ptr [7FF8A82B5A58]
       int       3
M01_L87:
       mov       ecx,r13d
       mov       edx,4C
       call      qword ptr [7FF8A82B5A58]
       int       3
M01_L88:
       mov       ecx,21
       call      qword ptr [7FF8A7E378D0]
       int       3
M01_L89:
       call      qword ptr [7FF8A82B5A70]
       int       3
M01_L90:
       call      qword ptr [7FF8A82B5A88]
       int       3
M01_L91:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,19685
       mov       rdx,7FF8A7B54000
       call      qword ptr [7FF8A7E37798]
       mov       rsi,rax
       call      qword ptr [7FF8A82B54E8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF8A7E3D9C8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L92:
       call      qword ptr [7FF8A7D87198]
       int       3
M01_L93:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,1969B
       mov       rdx,7FF8A7B54000
       call      qword ptr [7FF8A7E37798]
       mov       rsi,rax
       call      qword ptr [7FF8A82B5530]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF8A7E3D9C8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L94:
       mov       rcx,offset MT_System.OutOfMemoryException
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,r13
       call      qword ptr [7FF8A82B5548]
       mov       rcx,r13
       call      CORINFO_HELP_THROW
       int       3
M01_L95:
       call      qword ptr [7FF8A802CF90]
       int       3
M01_L96:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 3791
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       edx,[rbx+1C]
       add       edx,[rbx+18]
       je        short M02_L02
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FF9078A50F0
       mov       rsi,rax
M02_L00:
       mov       r8d,[rbx+18]
       test      r8d,r8d
       jle       short M02_L01
       mov       rdx,[rbx+8]
       mov       ecx,[rbx+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rsi+8]
       ja        short M02_L03
       cmp       [rdx+8],r8d
       jb        short M02_L03
       movsxd    rcx,ecx
       lea       rcx,[rsi+rcx*2+0C]
       movsxd    r8,r8d
       add       r8,r8
       add       rdx,10
       call      qword ptr [7FF8A7C15818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L01:
       mov       rbx,[rbx+10]
       test      rbx,rbx
       jne       short M02_L00
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L02:
       mov       rax,24312880008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,19655
       mov       rdx,7FF8A7B54000
       call      qword ptr [7FF8A7E37798]
       mov       rbx,rax
       call      qword ptr [7FF8A82B5638]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF8A7E3D9C8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 201
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderBenchmark.Remove_ForComparison()
       push      rsi
       push      rbx
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+30],ymm4
       xor       eax,eax
       mov       [rsp+50],rax
       mov       rbx,rcx
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,[rbx+30]
       test      rdx,rdx
       je        near ptr M00_L01
       mov       r9d,[rdx+8]
M00_L00:
       mov       dword ptr [rsp+20],10
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FF8A822E580]; System.Text.StringBuilder..ctor(System.String, Int32, Int32, Int32)
       mov       edx,[rsi+1C]
       add       edx,[rsi+18]
       mov       r8,26DA3AA0AAC
       mov       rcx,26DA3A90014
       mov       [rsp+40],r8
       mov       dword ptr [rsp+48],3
       mov       [rsp+30],rcx
       xor       r8d,r8d
       mov       [rsp+38],r8d
       mov       [rsp+20],edx
       lea       rdx,[rsp+40]
       lea       r8,[rsp+30]
       mov       rcx,rsi
       xor       r9d,r9d
       call      qword ptr [7FF8A8225A28]; System.Text.StringBuilder.Replace(System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>, Int32, Int32)
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF8A7DF2200]; System.Text.StringBuilder.ToString()
       mov       [rsp+50],rax
       mov       rbx,[rbx+88]
       mov       rdx,[rsp+50]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,58
       pop       rbx
       pop       rsi
       ret
M00_L01:
       xor       r9d,r9d
       jmp       near ptr M00_L00
; Total bytes of code 217
```
```assembly
; System.Text.StringBuilder..ctor(System.String, Int32, Int32, Int32)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rdi,rcx
       mov       rsi,rdx
       mov       ebp,r8d
       mov       ebx,r9d
       mov       r14d,[rsp+80]
       test      r14d,r14d
       jl        near ptr M01_L03
       test      ebx,ebx
       jl        near ptr M01_L04
       test      ebp,ebp
       jl        near ptr M01_L05
       mov       rcx,26DA3A90008
       test      rsi,rsi
       cmove     rsi,rcx
       mov       r15d,[rsi+8]
       mov       ecx,r15d
       sub       ecx,ebx
       cmp       ecx,ebp
       jl        near ptr M01_L06
       mov       dword ptr [rdi+20],7FFFFFFF
       mov       ecx,10
       test      r14d,r14d
       cmove     r14d,ecx
       cmp       r14d,ebx
       mov       ecx,ebx
       cmovge    ecx,r14d
       cmp       ecx,400
       jl        short M01_L00
       xor       edx,edx
       call      qword ptr [7FF8A818F060]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       jmp       short M01_L01
M01_L00:
       movsxd    rdx,ecx
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
M01_L01:
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rdi+18],ebx
       mov       r8d,ebp
       mov       ecx,ebx
       lea       rdx,[r8+rcx]
       mov       eax,r15d
       cmp       rdx,rax
       ja        near ptr M01_L07
       lea       rdx,[rsi+r8*2+0C]
       mov       r8,[rdi+8]
       test      r8,r8
       je        near ptr M01_L08
       lea       rax,[r8+10]
       mov       r8d,[r8+8]
M01_L02:
       cmp       ebx,r8d
       ja        near ptr M01_L09
       lea       r8,[rcx+rcx]
       mov       rcx,rax
       call      qword ptr [7FF8A7C05818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L03:
       mov       ecx,13CC2
       mov       rdx,7FF8A7B44000
       call      qword ptr [7FF8A7E27798]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FF8A82A4C30]
       int       3
M01_L04:
       mov       ecx,0B3
       mov       rdx,7FF8A7B44000
       call      qword ptr [7FF8A7E27798]
       mov       rdx,rax
       mov       ecx,ebx
       call      qword ptr [7FF8A82A4C30]
       int       3
M01_L05:
       mov       ecx,0B8F
       mov       rdx,7FF8A7B44000
       call      qword ptr [7FF8A7E27798]
       mov       rdx,rax
       mov       ecx,ebp
       call      qword ptr [7FF8A82A4C30]
       int       3
M01_L06:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       ecx,0B3
       mov       rdx,7FF8A7B44000
       call      qword ptr [7FF8A7E27798]
       mov       rbx,rax
       call      qword ptr [7FF8A82A5890]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rbp
       call      qword ptr [7FF8A7E2D9C8]
       mov       rcx,rbp
       call      CORINFO_HELP_THROW
       int       3
M01_L07:
       mov       ecx,21
       call      qword ptr [7FF8A7E278D0]
       int       3
M01_L08:
       xor       eax,eax
       xor       r8d,r8d
       jmp       near ptr M01_L02
M01_L09:
       call      qword ptr [7FF8A801CF90]
       int       3
; Total bytes of code 454
```
```assembly
; System.Text.StringBuilder.Replace(System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>, Int32, Int32)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,118
       lea       rbp,[rsp+30]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp+0B0],ymm4
       vmovdqa   xmmword ptr [rbp+0D0],xmm4
       xor       eax,eax
       mov       [rbp+0E0],rax
       mov       rax,538E9B5C08B1
       mov       [rbp],rax
       mov       rdi,rcx
       mov       rsi,r8
       mov       ebx,[rbp+150]
       mov       r14,[rdx]
       mov       r15d,[rdx+8]
       mov       ecx,[rdi+1C]
       mov       edx,ecx
       add       edx,[rdi+18]
       cmp       r9d,edx
       ja        near ptr M02_L54
       test      ebx,ebx
       jl        near ptr M02_L55
       sub       edx,ebx
       cmp       edx,r9d
       jl        near ptr M02_L55
       test      r15d,r15d
       je        near ptr M02_L56
       test      [rsp],esp
       sub       rsp,200
       lea       rdx,[rsp+30]
       xor       r8d,r8d
       mov       [rbp+0C8],r8
       mov       [rbp+0D0],r8d
       mov       [rbp+0D8],rdx
       mov       dword ptr [rbp+0E0],80
       mov       r13,rdi
       cmp       ecx,r9d
       jle       short M02_L01
M02_L00:
       mov       r13,[r13+10]
       cmp       [r13+1C],r9d
       jg        short M02_L00
M02_L01:
       mov       r12d,r9d
       sub       r12d,[r13+1C]
       test      ebx,ebx
       jle       near ptr M02_L31
M02_L02:
       mov       rcx,[r13+8]
       mov       eax,[r13+18]
       sub       eax,r12d
       cmp       eax,ebx
       jg        near ptr M02_L07
M02_L03:
       test      rcx,rcx
       je        near ptr M02_L57
       mov       edx,r12d
       mov       r8d,eax
       add       rdx,r8
       mov       r8d,[rcx+8]
       cmp       rdx,r8
       ja        near ptr M02_L79
       mov       edx,r12d
       lea       r10,[rcx+rdx*2+10]
       mov       r11d,eax
M02_L04:
       mov       rax,r10
       mov       r10d,r11d
       cmp       r15d,r10d
       jg        near ptr M02_L13
M02_L05:
       mov       [rbp+18],rax
       mov       rcx,rax
       mov       [rbp+68],r10d
       mov       edx,r10d
       mov       r8,r14
       mov       r9d,r15d
       call      qword ptr [7FF8A8225A40]; System.SpanHelpers.IndexOf(Char ByRef, Int32, Char ByRef, Int32)
       mov       [rbp+0C4],eax
       test      eax,eax
       jl        short M02_L08
       add       r12d,eax
       mov       ecx,[rbp+0D0]
       mov       rdx,[rbp+0D8]
       mov       r8d,[rbp+0E0]
       cmp       ecx,r8d
       jae       near ptr M02_L58
       mov       r8d,ecx
       mov       [rdx+r8*4],r12d
       inc       ecx
       mov       [rbp+0D0],ecx
M02_L06:
       mov       eax,[rbp+0C4]
       lea       ecx,[rax+r15]
       mov       edx,[rbp+68]
       cmp       ecx,edx
       ja        near ptr M02_L79
       mov       r8d,ecx
       mov       r10,[rbp+18]
       lea       r10,[r10+r8*2]
       sub       edx,ecx
       mov       rcx,r10
       add       r12d,r15d
       add       eax,r15d
       sub       ebx,eax
       je        near ptr M02_L13
       cmp       r15d,edx
       mov       rax,rcx
       mov       r10d,edx
       jle       near ptr M02_L05
       jmp       short M02_L13
M02_L07:
       mov       eax,ebx
       jmp       near ptr M02_L03
M02_L08:
       lea       ecx,[r15-1]
       mov       edx,[rbp+68]
       sub       edx,ecx
       add       r12d,edx
       sub       ebx,edx
       jmp       short M02_L13
M02_L09:
       test      ebx,ebx
       jle       short M02_L14
       mov       rdx,r13
       mov       eax,r12d
       mov       r8d,ebx
       xor       r10d,r10d
       mov       [rbp+50],r10
M02_L10:
       mov       [rbp+0C0],r8d
       test      r8d,r8d
       je        short M02_L12
       cmp       eax,[rdx+18]
       jge       near ptr M02_L59
M02_L11:
       mov       r10,[rbp+50]
       movzx     ecx,word ptr [r14+r10*2]
       mov       r9,[rdx+8]
       cmp       eax,[r9+8]
       jae       near ptr M02_L95
       mov       r11d,eax
       cmp       cx,[r9+r11*2+10]
       je        near ptr M02_L60
M02_L12:
       inc       r12d
       dec       ebx
M02_L13:
       cmp       r12d,[r13+18]
       jl        short M02_L09
M02_L14:
       add       r12d,[r13+1C]
       cmp       dword ptr [rbp+0D0],0
       je        near ptr M02_L28
       mov       eax,[rbp+0D0]
       cmp       eax,[rbp+0E0]
       ja        near ptr M02_L79
       mov       r10,[rbp+0D8]
       mov       [rbp+8],r10
       mov       [rbp+60],eax
       mov       edx,r15d
       mov       r11,[rsi]
       mov       [rbp+10],r11
       mov       r8d,[rsi+8]
       mov       [rbp+64],r8d
       mov       r9d,r8d
       sub       r9d,edx
       movsxd    rdx,r9d
       mov       r9d,eax
       imul      rdx,r9
       mov       ecx,edx
       mov       [rbp+0BC],ecx
       movsxd    r9,ecx
       cmp       r9,rdx
       jne       near ptr M02_L78
       mov       [rbp+0B0],r13
       test      eax,eax
       je        near ptr M02_L95
       mov       edx,[r10]
       mov       [rbp+0A8],edx
       test      ecx,ecx
       jg        near ptr M02_L63
M02_L15:
       xor       r9d,r9d
       mov       [rbp+48],r9
M02_L16:
       mov       r11,[rbp+10]
       mov       rdx,r11
       mov       r8d,[rbp+64]
       mov       r11d,r8d
       test      r11d,r11d
       je        near ptr M02_L21
M02_L17:
       mov       r8,[rbp+0B0]
       mov       r8d,[r8+18]
       sub       r8d,[rbp+0A8]
       cmp       r8d,r11d
       jg        near ptr M02_L37
M02_L18:
       mov       r10,[rbp+0B0]
       mov       r10,[r10+8]
       mov       eax,[rbp+0A8]
       test      r10,r10
       je        near ptr M02_L64
       cmp       [r10+8],eax
       jb        near ptr M02_L79
       mov       ecx,eax
       lea       rcx,[r10+rcx*2+10]
       mov       r10d,[r10+8]
       sub       r10d,eax
M02_L19:
       cmp       r8d,r10d
       mov       [rbp+0A0],r11d
       ja        near ptr M02_L80
       mov       [rbp+9C],r8d
       mov       eax,r8d
       lea       r8,[rax+rax]
       mov       [rbp+38],rdx
       call      qword ptr [7FF8A7C05818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       eax,[rbp+9C]
       mov       ecx,eax
       add       ecx,[rbp+0A8]
       mov       [rbp+0A8],ecx
       mov       ecx,[rbp+0A8]
       mov       rdx,[rbp+0B0]
       cmp       ecx,[rdx+18]
       jge       near ptr M02_L65
M02_L20:
       mov       r11d,[rbp+0A0]
       mov       eax,[rbp+9C]
       sub       r11d,eax
       jne       near ptr M02_L66
M02_L21:
       mov       r10,[rbp+8]
       mov       r9,[rbp+48]
       mov       r11d,r15d
       add       r11d,[r10+r9*4]
       inc       r9d
       mov       eax,[rbp+60]
       cmp       r9d,eax
       jb        near ptr M02_L38
       mov       ecx,[rbp+0BC]
       test      ecx,ecx
       jge       near ptr M02_L27
       mov       rdx,[rbp+0B0]
       mov       edx,[rdx+1C]
       add       edx,[rbp+0A8]
       neg       ecx
       lea       eax,[rdx+rcx]
       mov       [rbp+0B0],rdi
       xor       r13d,r13d
       xor       r8d,r8d
M02_L22:
       mov       r10,[rbp+0B0]
       mov       r10d,[r10+1C]
       mov       r9d,eax
       sub       r9d,r10d
       js        near ptr M02_L71
       test      r13,r13
       jne       short M02_L23
       mov       r13,[rbp+0B0]
       mov       r8d,r9d
M02_L23:
       mov       r9d,edx
       sub       r9d,r10d
       js        near ptr M02_L72
       mov       [rbp+0A8],r9d
       mov       eax,[rbp+0A8]
       mov       r10d,[r13+18]
       mov       [rbp+90],r8d
       sub       r10d,r8d
       mov       [rbp+88],r10d
       cmp       r13,[rbp+0B0]
       jne       near ptr M02_L73
M02_L24:
       mov       r8d,[rbp+90]
       mov       ecx,r8d
       sub       ecx,eax
       sub       [r13+18],ecx
       cmp       eax,r8d
       je        short M02_L27
       mov       rcx,[r13+8]
       mov       rdx,rcx
       test      rdx,rdx
       je        near ptr M02_L74
       mov       r9d,r8d
       mov       r10d,[rbp+88]
       mov       r11d,r10d
       add       r9,r11
       mov       r11d,[rdx+8]
       cmp       r9,r11
       ja        near ptr M02_L79
       mov       r8d,r8d
       lea       rdx,[rdx+r8*2+10]
M02_L25:
       test      rcx,rcx
       je        near ptr M02_L77
       cmp       [rcx+8],eax
       jb        near ptr M02_L79
       mov       r8d,eax
       lea       r8,[rcx+r8*2+10]
       mov       ecx,[rcx+8]
       sub       ecx,eax
       mov       r9,r8
M02_L26:
       cmp       r10d,ecx
       jg        near ptr M02_L80
       mov       r8d,r10d
       add       r8,r8
       mov       rcx,r9
       call      qword ptr [7FF8A7C05818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L27:
       xor       eax,eax
       mov       [rbp+0B0],rax
       mov       eax,[rsi+8]
       sub       eax,r15d
       imul      eax,[rbp+0D0]
       add       r12d,eax
       xor       eax,eax
       mov       [rbp+0D0],eax
M02_L28:
       mov       r13,rdi
       cmp       [rdi+1C],r12d
       jle       short M02_L30
M02_L29:
       mov       r13,[r13+10]
       cmp       [r13+1C],r12d
       jg        short M02_L29
M02_L30:
       sub       r12d,[r13+1C]
       test      ebx,ebx
       jg        near ptr M02_L02
M02_L31:
       mov       rbx,[rbp+0C8]
       test      rbx,rbx
       je        near ptr M02_L35
       xor       ecx,ecx
       mov       [rbp+0C8],rcx
       mov       rcx,22D0EC01D90
       mov       rsi,[rcx]
       mov       ecx,[rbx+8]
       dec       ecx
       or        ecx,0F
       xor       r14d,r14d
       lzcnt     r14d,ecx
       xor       r14d,1F
       add       r14d,0FFFFFFFD
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],7
       jle       near ptr M02_L81
       mov       rcx,[rcx+240]
       mov       rax,[rcx+38]
       test      rax,rax
       je        near ptr M02_L81
M02_L32:
       mov       rax,[rax+10]
       test      rax,rax
       je        near ptr M02_L44
M02_L33:
       xor       r15d,r15d
       mov       r13d,1
       cmp       [rax+8],r14d
       jbe       short M02_L34
       mov       r15d,1
       mov       ecx,10
       shlx      ecx,ecx,r14d
       cmp       [rbx+8],ecx
       jne       near ptr M02_L82
       cmp       r14d,[rax+8]
       jae       near ptr M02_L95
       mov       ecx,r14d
       shl       rcx,4
       lea       r12,[rax+rcx+10]
       mov       rax,[r12]
       mov       [rbp+28],rax
       mov       rcx,r12
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r12+8],ecx
       mov       r12,[rbp+28]
       test      r12,r12
       jne       near ptr M02_L45
M02_L34:
       mov       rcx,22D0EC00C90
       mov       r12,[rcx]
       cmp       byte ptr [r12+9D],0
       jne       near ptr M02_L92
M02_L35:
       mov       rax,rdi
       mov       r8,538E9B5C08B1
       cmp       [rbp],r8
       je        short M02_L36
       call      CORINFO_HELP_FAIL_FAST
M02_L36:
       nop
       lea       rsp,[rbp+0E8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L37:
       mov       [rbp+0A0],r11d
       mov       r8d,r11d
       mov       r11d,[rbp+0A0]
       jmp       near ptr M02_L18
M02_L38:
       mov       [rbp+48],r9
       mov       edx,[r10+r9*4]
       mov       [rbp+0A4],edx
       cmp       dword ptr [rbp+0BC],0
       je        near ptr M02_L70
       mov       rdx,[r13+8]
       cmp       r11d,[rdx+8]
       jae       near ptr M02_L95
       mov       r8d,r11d
       lea       rdx,[rdx+r8*2+10]
       mov       r8d,[rbp+0A4]
       sub       r8d,r11d
       mov       r11d,r8d
       test      r11d,r11d
       je        near ptr M02_L16
M02_L39:
       mov       r8,[rbp+0B0]
       mov       r8d,[r8+18]
       sub       r8d,[rbp+0A8]
       cmp       r8d,r11d
       jg        near ptr M02_L43
       mov       [rbp+94],r8d
M02_L40:
       mov       r8,[rbp+0B0]
       mov       r8,[r8+8]
       mov       r10d,[rbp+0A8]
       test      r8,r8
       je        near ptr M02_L67
       cmp       [r8+8],r10d
       jb        near ptr M02_L79
       mov       eax,r10d
       lea       rax,[r8+rax*2+10]
       mov       r8d,[r8+8]
       sub       r8d,r10d
M02_L41:
       mov       r10d,[rbp+94]
       cmp       r10d,r8d
       mov       [rbp+98],r11d
       ja        near ptr M02_L80
       mov       [rbp+94],r10d
       mov       r8d,r10d
       add       r8,r8
       mov       rcx,rax
       mov       [rbp+30],rdx
       call      qword ptr [7FF8A7C05818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       eax,[rbp+94]
       mov       ecx,eax
       add       ecx,[rbp+0A8]
       mov       [rbp+0A8],ecx
       mov       ecx,[rbp+0A8]
       mov       rdx,[rbp+0B0]
       cmp       ecx,[rdx+18]
       jge       near ptr M02_L68
M02_L42:
       mov       r11d,[rbp+98]
       mov       eax,[rbp+94]
       sub       r11d,eax
       mov       [rbp+98],r11d
       mov       [rbp+94],eax
       je        near ptr M02_L16
       jmp       near ptr M02_L69
M02_L43:
       mov       [rbp+98],r11d
       mov       [rbp+94],r11d
       mov       r11d,[rbp+98]
       jmp       near ptr M02_L40
M02_L44:
       mov       rcx,rsi
       call      qword ptr [7FF8A818F3C0]; System.Buffers.SharedArrayPool`1[[System.Int32, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
       jmp       near ptr M02_L33
M02_L45:
       mov       rcx,[rsi+10]
       cmp       r14d,[rcx+8]
       jae       near ptr M02_L95
       mov       edx,r14d
       mov       rax,[rcx+rdx*8+10]
       test      rax,rax
       je        near ptr M02_L83
M02_L46:
       mov       r13,[rax+8]
       test      byte ptr [7FF8A82F6CA0],1
       je        near ptr M02_L84
M02_L47:
       cmp       byte ptr [7FF8A7B4B17C],0
       je        near ptr M02_L85
       call      qword ptr [7FF8A82A68E0]
       mov       edx,eax
M02_L48:
       test      byte ptr [7FF8A82F6B30],1
       je        near ptr M02_L87
M02_L49:
       mov       eax,edx
       xor       edx,edx
       div       dword ptr [7FF8A7B4B170]
       mov       eax,edx
       mov       edx,[r13+8]
       mov       [rbp+5C],edx
       test      edx,edx
       jle       near ptr M02_L91
       mov       [rbp+44],edx
M02_L50:
       cmp       eax,edx
       jae       near ptr M02_L95
       mov       [rbp+7C],eax
       mov       ecx,eax
       mov       r10,[r13+rcx*8+10]
       mov       [rbp+20],r10
       cmp       [r10],r10b
       xor       r9d,r9d
       mov       [rbp+70],r9d
       mov       rcx,r10
       call      qword ptr [7FF8A811E1F0]; System.Threading.Monitor.Enter(System.Object)
       mov       rax,[rbp+20]
       mov       rcx,[rax+8]
       mov       r8d,[rax+10]
       mov       [rbp+6C],r8d
       cmp       [rcx+8],r8d
       jbe       short M02_L52
       test      r8d,r8d
       je        near ptr M02_L88
M02_L51:
       movsxd    rdx,r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rbp+6C]
       inc       ecx
       mov       rax,[rbp+20]
       mov       [rax+10],ecx
       mov       dword ptr [rbp+70],1
M02_L52:
       mov       rcx,rax
       call      qword ptr [7FF8A7C06820]; System.Threading.Monitor.Exit(System.Object)
       cmp       dword ptr [rbp+70],0
       je        near ptr M02_L89
       mov       r13d,1
M02_L53:
       jmp       near ptr M02_L34
M02_L54:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,0B8F
       mov       rdx,7FF8A7B44000
       call      qword ptr [7FF8A7E27798]
       mov       rsi,rax
       call      qword ptr [7FF8A82A5488]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF8A7E2D9C8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M02_L55:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,28F
       mov       rdx,7FF8A7B44000
       call      qword ptr [7FF8A7E27798]
       mov       rsi,rax
       call      qword ptr [7FF8A82A5488]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF8A7E2D9C8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M02_L56:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF8A82A5A10]
       mov       rsi,rax
       mov       ecx,0BF7
       mov       rdx,7FF8A7B44000
       call      qword ptr [7FF8A7E27798]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF8A7F86208]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M02_L57:
       mov       r10d,r12d
       or        r10d,eax
       jne       near ptr M02_L79
       xor       r10d,r10d
       xor       eax,eax
       xor       r11d,r11d
       mov       r10,rax
       jmp       near ptr M02_L04
M02_L58:
       lea       rcx,[rbp+0C8]
       mov       edx,r12d
       call      qword ptr [7FF8A818F300]; System.Collections.Generic.ValueListBuilder`1[[System.Int32, System.Private.CoreLib]].AddWithResize(Int32)
       jmp       near ptr M02_L06
M02_L59:
       mov       rcx,rdi
       call      qword ptr [7FF8A82A6820]
       mov       rdx,rax
       test      rdx,rdx
       je        near ptr M02_L12
       xor       eax,eax
       jmp       near ptr M02_L11
M02_L60:
       inc       eax
       mov       r8d,[rbp+0C0]
       dec       r8d
       inc       r10d
       mov       rcx,r10
       cmp       ecx,r15d
       mov       [rbp+50],rcx
       jl        near ptr M02_L10
       mov       ecx,[rbp+0D0]
       mov       rdx,[rbp+0D8]
       mov       eax,[rbp+0E0]
       cmp       ecx,eax
       jae       short M02_L61
       mov       eax,ecx
       mov       [rdx+rax*4],r12d
       inc       ecx
       mov       [rbp+0D0],ecx
       jmp       short M02_L62
M02_L61:
       lea       rcx,[rbp+0C8]
       mov       edx,r12d
       call      qword ptr [7FF8A818F300]; System.Collections.Generic.ValueListBuilder`1[[System.Int32, System.Private.CoreLib]].AddWithResize(Int32)
M02_L62:
       add       r12d,r15d
       sub       ebx,r15d
       jmp       near ptr M02_L13
M02_L63:
       lea       rdx,[rbp+0A8]
       mov       [rsp+20],rdx
       mov       dword ptr [rsp+28],1
       mov       rdx,[rbp+0B0]
       mov       edx,[rdx+1C]
       add       edx,[rbp+0A8]
       lea       r9,[rbp+0B0]
       mov       rcx,rdi
       mov       r8d,[rbp+0BC]
       call      qword ptr [7FF8A82A5A28]
       jmp       near ptr M02_L15
M02_L64:
       test      eax,eax
       jne       near ptr M02_L79
       xor       r10d,r10d
       xor       eax,eax
       mov       rcx,r10
       mov       r10d,eax
       jmp       near ptr M02_L19
M02_L65:
       mov       rcx,rdi
       mov       rdx,[rbp+0B0]
       call      qword ptr [7FF8A82A6820]
       mov       [rbp+0B0],rax
       xor       r8d,r8d
       mov       [rbp+0A8],r8d
       jmp       near ptr M02_L20
M02_L66:
       movsxd    r8,eax
       mov       rcx,[rbp+38]
       lea       rcx,[rcx+r8*2]
       mov       rdx,rcx
       jmp       near ptr M02_L17
M02_L67:
       test      r10d,r10d
       jne       near ptr M02_L79
       xor       r8d,r8d
       xor       r10d,r10d
       mov       rax,r10
       jmp       near ptr M02_L41
M02_L68:
       mov       rcx,rdi
       mov       rdx,[rbp+0B0]
       call      qword ptr [7FF8A82A6820]
       mov       [rbp+0B0],rax
       xor       ecx,ecx
       mov       [rbp+0A8],ecx
       jmp       near ptr M02_L42
M02_L69:
       movsxd    rdx,dword ptr [rbp+94]
       mov       r11,[rbp+30]
       lea       r11,[r11+rdx*2]
       mov       rdx,r11
       mov       r11d,[rbp+98]
       jmp       near ptr M02_L39
M02_L70:
       mov       edx,[rbp+0A4]
       sub       edx,r11d
       add       edx,[rbp+0A8]
       mov       [rbp+0A8],edx
       jmp       near ptr M02_L16
M02_L71:
       mov       r9,[rbp+0B0]
       sub       r10d,ecx
       mov       [r9+1C],r10d
M02_L72:
       mov       r10,[rbp+0B0]
       mov       r10,[r10+10]
       mov       [rbp+0B0],r10
       jmp       near ptr M02_L22
M02_L73:
       xor       eax,eax
       mov       [rbp+8C],eax
       mov       rcx,[rbp+0B0]
       mov       edx,[rbp+0A8]
       mov       [rcx+18],edx
       lea       rcx,[r13+10]
       mov       rdx,[rbp+0B0]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+0B0]
       mov       ecx,[rcx+1C]
       mov       rdx,[rbp+0B0]
       add       ecx,[rdx+18]
       mov       [r13+1C],ecx
       cmp       dword ptr [rbp+0A8],0
       jne       short M02_L75
       mov       rcx,[rbp+0B0]
       mov       rdx,[rcx+10]
       lea       rcx,[r13+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp+0B0],r13
       mov       eax,[rbp+8C]
       jmp       near ptr M02_L24
M02_L74:
       or        r8d,[rbp+88]
       je        short M02_L76
       jmp       short M02_L79
M02_L75:
       mov       eax,[rbp+8C]
       jmp       near ptr M02_L24
M02_L76:
       xor       edx,edx
       xor       r10d,r10d
       jmp       near ptr M02_L25
M02_L77:
       test      eax,eax
       jne       short M02_L79
       xor       r9d,r9d
       xor       ecx,ecx
       jmp       near ptr M02_L26
M02_L78:
       mov       rcx,offset MT_System.OutOfMemoryException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       call      qword ptr [7FF8A82A5608]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M02_L79:
       call      qword ptr [7FF8A7D77198]
       int       3
M02_L80:
       call      qword ptr [7FF8A801CF90]
       int       3
M02_L81:
       mov       ecx,7
       call      qword ptr [7FF8A82A4F30]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M02_L32
M02_L82:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF8A82A68B0]
       mov       rbx,rax
       mov       ecx,29B
       mov       rdx,7FF8A7B44000
       call      qword ptr [7FF8A7E27798]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FF8A7F86208]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M02_L83:
       mov       rcx,rsi
       mov       edx,r14d
       call      qword ptr [7FF8A82A68C8]
       jmp       near ptr M02_L46
M02_L84:
       mov       rcx,offset MT_System.Threading.ProcessorIdCache
       call      qword ptr [7FF8A7C05740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M02_L47
M02_L85:
       mov       ecx,0A
       call      qword ptr [7FF8A82A68F8]
       mov       eax,[rax+10]
       mov       [rbp+74],eax
       mov       ecx,0A
       call      qword ptr [7FF8A82A68F8]
       mov       edx,[rbp+74]
       lea       ecx,[rdx-1]
       mov       [rax+10],ecx
       movzx     eax,dx
       test      eax,eax
       jne       short M02_L86
       call      qword ptr [7FF8A82A6910]
       mov       edx,eax
       jmp       near ptr M02_L48
M02_L86:
       sar       edx,10
       mov       [rbp+78],edx
       mov       edx,[rbp+78]
       jmp       near ptr M02_L48
M02_L87:
       mov       [rbp+78],edx
       mov       rcx,offset MT_System.Buffers.SharedArrayPoolStatics
       call      qword ptr [7FF8A7C05740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       edx,[rbp+78]
       jmp       near ptr M02_L49
M02_L88:
       xor       edx,edx
       mov       [rax+14],edx
       jmp       near ptr M02_L51
M02_L89:
       mov       eax,[rbp+7C]
       inc       eax
       mov       ecx,eax
       mov       edx,[rbp+5C]
       cmp       edx,ecx
       jne       short M02_L90
       xor       ecx,ecx
M02_L90:
       mov       r8d,[rbp+44]
       dec       r8d
       mov       [rbp+44],r8d
       mov       eax,ecx
       jne       near ptr M02_L50
M02_L91:
       xor       r13d,r13d
       jmp       near ptr M02_L53
M02_L92:
       cmp       dword ptr [rbx+8],0
       je        near ptr M02_L35
       mov       rcx,rbx
       call      qword ptr [7FF8A801D638]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rbp+84],eax
       mov       edx,[rbx+8]
       mov       [rbp+80],edx
       mov       rcx,rsi
       call      qword ptr [7FF8A801D638]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,r12
       mov       r8d,[rbp+84]
       mov       r9d,[rbp+80]
       mov       edx,3
       call      qword ptr [7FF8A82A5728]
       test      r13d,r15d
       jne       near ptr M02_L35
       mov       rcx,rbx
       call      qword ptr [7FF8A801D638]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r13d,eax
       mov       ebx,[rbx+8]
       mov       rcx,rsi
       call      qword ptr [7FF8A801D638]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       test      r15d,r15d
       jne       short M02_L93
       mov       ecx,0FFFFFFFF
       mov       edx,1
       jmp       short M02_L94
M02_L93:
       mov       ecx,r14d
       xor       edx,edx
M02_L94:
       mov       [rsp+20],ecx
       mov       [rsp+28],edx
       mov       rcx,r12
       mov       edx,r13d
       mov       r8d,ebx
       call      qword ptr [7FF8A82A6928]
       jmp       near ptr M02_L35
M02_L95:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 3502
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       edx,[rbx+1C]
       add       edx,[rbx+18]
       je        short M03_L02
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FF9078A50F0
       mov       rsi,rax
M03_L00:
       mov       r8d,[rbx+18]
       test      r8d,r8d
       jle       short M03_L01
       mov       rdx,[rbx+8]
       mov       ecx,[rbx+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rsi+8]
       ja        short M03_L03
       cmp       [rdx+8],r8d
       jb        short M03_L03
       movsxd    rcx,ecx
       lea       rcx,[rsi+rcx*2+0C]
       movsxd    r8,r8d
       add       r8,r8
       add       rdx,10
       call      qword ptr [7FF8A7C05818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M03_L01:
       mov       rbx,[rbx+10]
       test      rbx,rbx
       jne       short M03_L00
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M03_L02:
       mov       rax,26DA3A90008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M03_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,19655
       mov       rdx,7FF8A7B44000
       call      qword ptr [7FF8A7E27798]
       mov       rbx,rax
       call      qword ptr [7FF8A82A5488]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF8A7E2D9C8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 201
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderBenchmark.Format()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0D8
       lea       rbp,[rsp+110]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-0C0],ymm4
       vmovdqu   ymmword ptr [rbp-0A0],ymm4
       vmovdqu   ymmword ptr [rbp-80],ymm4
       vmovdqu   ymmword ptr [rbp-60],ymm4
       xor       eax,eax
       mov       [rbp-40],rax
       mov       rbx,rcx
       mov       rsi,[rbx+198]
       test      rsi,rsi
       je        near ptr M00_L59
       mov       ecx,[rsi+8]
       test      ecx,ecx
       setg      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M00_L59
       mov       rcx,27F7BC021A8
       mov       rdi,[rcx]
       mov       r14,rdi
       mov       rcx,[r14+20]
       mov       [rbp-40],rcx
       cmp       qword ptr [rbp-40],0
       je        near ptr M00_L61
       lea       rcx,[r14+20]
       mov       r8,[rbp-40]
       test      rcx,rcx
       je        near ptr M00_L60
       xor       edx,edx
       call      00007FF907846040
       cmp       rax,[rbp-40]
       jne       near ptr M00_L61
M00_L00:
       mov       r14,[rbp-40]
M00_L01:
       xor       ecx,ecx
       mov       [rbp-40],rcx
       lea       rdx,[rsi+10]
       mov       eax,[rsi+8]
       test      eax,eax
       jle       short M00_L04
       xor       r8d,r8d
M00_L02:
       mov       r10,[rdx+r8]
       test      r10,r10
       je        short M00_L03
       add       ecx,[r10+8]
       jo        near ptr M00_L65
M00_L03:
       add       r8,8
       dec       eax
       jne       short M00_L02
M00_L04:
       mov       r15d,ecx
       cmp       [r14],r14b
       test      r15d,r15d
       jl        near ptr M00_L63
       mov       rcx,[r14+8]
       mov       ecx,[rcx+8]
       add       ecx,[r14+1C]
       cmp       ecx,r15d
       jl        near ptr M00_L64
M00_L05:
       mov       r8,[r14+8]
       mov       r8d,[r8+8]
       mov       [rbp-0C8],r14
       mov       r8,27F7BC00100
       mov       r15,[r8]
       lea       r14,[rsi+10]
       mov       esi,[rsi+8]
       xor       r8d,r8d
       mov       [rbp-48],r8d
       jmp       near ptr M00_L14
M00_L06:
       xor       r10d,r10d
M00_L07:
       mov       [rbp-0D8],r10
       test      r10,r10
       jne       near ptr M00_L40
M00_L08:
       mov       r10,rax
       test      r10,r10
       je        short M00_L09
       mov       rdx,offset MT_System.String
       cmp       [r10],rdx
       jne       near ptr M00_L41
       xor       r10d,r10d
M00_L09:
       mov       rdx,r10
       mov       [rbp-0E0],rdx
       test      rdx,rdx
       jne       near ptr M00_L42
       test      rax,rax
       je        near ptr M00_L20
       mov       rcx,offset MT_System.String
       cmp       [rax],rcx
       jne       near ptr M00_L44
M00_L10:
       mov       r13,rax
M00_L11:
       test      r13,r13
       je        near ptr M00_L45
M00_L12:
       cmp       [r13+8],r12d
       jl        near ptr M00_L46
M00_L13:
       mov       rcx,[rbp-0C8]
       mov       rdx,r13
       call      qword ptr [7FF8A7D9F228]; System.Text.StringBuilder.Append(System.String)
M00_L14:
       cmp       dword ptr [rbp-48],1F
       jae       near ptr M00_L21
       mov       r8d,[rbp-48]
       mov       r13,2C010CB0AA0
       mov       edx,r8d
       lea       r12,[r13+rdx*2+0C]
       mov       eax,r8d
       neg       eax
       add       eax,1F
       mov       [rbp-0AC],eax
       mov       r8d,7D
       mov       edx,7B
       mov       rcx,r12
       mov       r9d,eax
       call      qword ptr [7FF8A7E4C630]; System.PackedSpanHelpers.IndexOfAny[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib],[System.PackedSpanHelpers+NopTransform, System.Private.CoreLib]](Int16 ByRef, Int16, Int16, Int32)
       mov       [rbp-98],eax
       test      eax,eax
       jl        near ptr M00_L48
       cmp       eax,[rbp-0AC]
       ja        near ptr M00_L49
       test      eax,eax
       je        short M00_L16
       mov       rdx,[rbp-0C8]
       mov       r8,[rdx+8]
       mov       r10d,[rdx+18]
       mov       [rbp-9C],r10d
       lea       ecx,[r10+rax]
       cmp       ecx,[r8+8]
       ja        near ptr M00_L23
       movsxd    rcx,r10d
       lea       rcx,[r8+rcx*2+10]
       cmp       eax,2
       jle       near ptr M00_L19
       mov       r8d,eax
       add       r8,r8
       mov       rdx,r12
       call      qword ptr [7FF8A7C25818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L15:
       mov       eax,[rbp-98]
       mov       r10d,eax
       add       r10d,[rbp-9C]
       mov       rdx,[rbp-0C8]
       mov       [rdx+18],r10d
M00_L16:
       add       eax,[rbp-48]
       mov       [rbp-48],eax
       cmp       dword ptr [rbp-48],1F
       jae       near ptr M00_L56
       mov       edx,[rbp-48]
       movzx     edx,word ptr [r13+rdx*2+0C]
       mov       ecx,[rbp-48]
       inc       ecx
       mov       [rbp-48],ecx
       cmp       dword ptr [rbp-48],1F
       jae       near ptr M00_L52
       cmp       dword ptr [rbp-48],1F
       jae       near ptr M00_L56
       mov       ecx,[rbp-48]
       movzx     eax,word ptr [r13+rcx*2+0C]
       cmp       edx,eax
       je        near ptr M00_L24
       cmp       edx,7B
       jne       near ptr M00_L50
       xor       r12d,r12d
       xor       r8d,r8d
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-60],xmm0
       lea       r10d,[rax-30]
       cmp       r10d,0A
       jae       near ptr M00_L51
       mov       eax,[rbp-48]
       inc       eax
       mov       [rbp-48],eax
       cmp       dword ptr [rbp-48],1F
       jae       near ptr M00_L52
       cmp       dword ptr [rbp-48],1F
       jae       near ptr M00_L56
       mov       edx,[rbp-48]
       movzx     eax,word ptr [r13+rdx*2+0C]
       cmp       eax,7D
       jne       near ptr M00_L25
M00_L17:
       mov       edx,[rbp-48]
       inc       edx
       mov       [rbp-48],edx
       xor       r13d,r13d
       cmp       r10d,esi
       jae       near ptr M00_L54
       cmp       r10d,esi
       jae       near ptr M00_L56
       mov       edx,r10d
       mov       rax,[r14+rdx*8]
       mov       [rbp-0D0],rax
       mov       [rbp-4C],r8d
       test      r8d,r8d
       jne       short M00_L18
       test      r12d,r12d
       jne       near ptr M00_L08
M00_L18:
       mov       r10,rax
       test      r10,r10
       je        near ptr M00_L07
       mov       rdx,offset MT_System.String
       cmp       [r10],rdx
       je        near ptr M00_L06
       jmp       near ptr M00_L39
M00_L19:
       movzx     r8d,word ptr [r12]
       mov       [rcx],r8w
       cmp       eax,2
       je        short M00_L22
       jmp       near ptr M00_L15
M00_L20:
       xor       r13d,r13d
       jmp       near ptr M00_L11
M00_L21:
       mov       rcx,[rbp-0C8]
       call      qword ptr [7FF8A7E12200]; System.Text.StringBuilder.ToString()
       mov       rsi,rax
       jmp       near ptr M00_L57
M00_L22:
       movzx     r8d,word ptr [r12+2]
       mov       [rcx+2],r8w
       jmp       near ptr M00_L15
M00_L23:
       mov       rdx,[rbp-0C8]
       mov       rcx,rdx
       mov       rdx,r12
       mov       r8d,eax
       call      qword ptr [7FF8A7D9F1E0]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       mov       eax,[rbp-98]
       jmp       near ptr M00_L16
M00_L24:
       mov       rcx,[rbp-0C8]
       mov       edx,eax
       call      qword ptr [7FF8A7D9F180]; System.Text.StringBuilder.Append(Char)
       mov       ecx,[rbp-48]
       inc       ecx
       mov       [rbp-48],ecx
       jmp       near ptr M00_L14
M00_L25:
       lea       edx,[rax-30]
       cmp       edx,9
       ja        short M00_L28
       jmp       short M00_L27
M00_L26:
       lea       r10d,[r10+r10*4]
       lea       r10d,[rax+r10*2-30]
       mov       [rbp-64],r10d
       mov       eax,[rbp-48]
       inc       eax
       mov       [rbp-48],eax
       cmp       dword ptr [rbp-48],1F
       jae       near ptr M00_L52
       cmp       dword ptr [rbp-48],1F
       jae       near ptr M00_L56
       mov       edx,[rbp-48]
       movzx     eax,word ptr [r13+rdx*2+0C]
       mov       r10d,[rbp-64]
       jmp       short M00_L25
M00_L27:
       cmp       r10d,0F4240
       jl        short M00_L26
M00_L28:
       cmp       eax,20
       jne       short M00_L29
       mov       eax,[rbp-48]
       inc       eax
       mov       [rbp-48],eax
       cmp       dword ptr [rbp-48],1F
       jae       near ptr M00_L52
       cmp       dword ptr [rbp-48],1F
       jae       near ptr M00_L56
       mov       edx,[rbp-48]
       movzx     eax,word ptr [r13+rdx*2+0C]
       jmp       short M00_L28
M00_L29:
       cmp       eax,2C
       jne       near ptr M00_L36
M00_L30:
       mov       eax,[rbp-48]
       inc       eax
       mov       [rbp-48],eax
       cmp       dword ptr [rbp-48],1F
       jae       near ptr M00_L52
       cmp       dword ptr [rbp-48],1F
       jae       near ptr M00_L56
       mov       edx,[rbp-48]
       movzx     eax,word ptr [r13+rdx*2+0C]
       cmp       eax,20
       je        short M00_L30
       cmp       eax,2D
       jne       short M00_L31
       mov       dword ptr [rbp-4C],1
       mov       eax,[rbp-48]
       inc       eax
       mov       [rbp-48],eax
       cmp       dword ptr [rbp-48],1F
       jae       near ptr M00_L52
       cmp       dword ptr [rbp-48],1F
       jae       near ptr M00_L56
       mov       edx,[rbp-48]
       movzx     eax,word ptr [r13+rdx*2+0C]
       mov       r8d,[rbp-4C]
M00_L31:
       lea       r12d,[rax-30]
       cmp       r12d,0A
       mov       [rbp-64],r10d
       mov       [rbp-4C],r8d
       jb        short M00_L33
       jmp       near ptr M00_L51
M00_L32:
       lea       edx,[r12+r12*4]
       lea       r12d,[rax+rdx*2-30]
M00_L33:
       lea       rdx,[rbp-48]
       mov       rcx,r13
       call      qword ptr [7FF8A82C6910]
       lea       edx,[rax-30]
       cmp       edx,9
       ja        short M00_L34
       cmp       r12d,0F4240
       jl        short M00_L32
M00_L34:
       cmp       eax,20
       je        short M00_L35
       mov       r8d,[rbp-4C]
       mov       r10d,[rbp-64]
       jmp       short M00_L36
M00_L35:
       mov       eax,[rbp-48]
       inc       eax
       mov       [rbp-48],eax
       cmp       dword ptr [rbp-48],1F
       jae       near ptr M00_L52
       cmp       dword ptr [rbp-48],1F
       jae       near ptr M00_L56
       mov       edx,[rbp-48]
       movzx     eax,word ptr [r13+rdx*2+0C]
       jmp       short M00_L34
M00_L36:
       cmp       eax,7D
       je        near ptr M00_L17
       cmp       eax,3A
       jne       near ptr M00_L53
       mov       r9d,[rbp-48]
       mov       [rbp-94],r9d
       mov       [rbp-64],r10d
       mov       [rbp-4C],r8d
M00_L37:
       lea       rdx,[rbp-48]
       mov       rcx,r13
       call      qword ptr [7FF8A82C6910]
       cmp       eax,7D
       je        short M00_L38
       cmp       eax,7B
       jne       short M00_L37
       jmp       near ptr M00_L53
M00_L38:
       mov       r9d,[rbp-94]
       inc       r9d
       mov       ecx,[rbp-48]
       mov       [rbp-94],r9d
       sub       ecx,r9d
       mov       r9d,ecx
       lea       rcx,[rbp-60]
       mov       r8d,[rbp-94]
       mov       rdx,r13
       call      qword ptr [7FF8A82C6928]
       mov       r8d,[rbp-4C]
       mov       r10d,[rbp-64]
       jmp       near ptr M00_L17
M00_L39:
       mov       rdx,rax
       mov       rcx,offset MT_System.ISpanFormattable
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       r10,rax
       mov       rax,[rbp-0D0]
       jmp       near ptr M00_L07
M00_L40:
       lea       rdx,[rbp-80]
       mov       rcx,[rbp-0C8]
       call      qword ptr [7FF8A82C6940]
       vmovdqu   xmm0,xmmword ptr [rbp-60]
       vmovdqu   xmmword ptr [rbp-0C0],xmm0
       mov       [rsp+20],r15
       lea       r9,[rbp-0C0]
       lea       r8,[rbp-70]
       lea       rdx,[rbp-80]
       mov       rcx,[rbp-0D8]
       mov       r11,7FF8A7B70AC0
       call      qword ptr [r11]
       test      eax,eax
       mov       rax,[rbp-0D0]
       je        near ptr M00_L08
       mov       r13d,[rbp-70]
       lea       rdx,[rbp-90]
       mov       rcx,[rbp-0C8]
       call      qword ptr [7FF8A82C6940]
       cmp       r13d,[rbp-88]
       ja        near ptr M00_L55
       mov       r8d,[rbp-70]
       mov       rcx,[rbp-0C8]
       add       [rcx+18],r8d
       cmp       dword ptr [rbp-4C],0
       je        near ptr M00_L14
       cmp       r12d,[rbp-70]
       jle       near ptr M00_L14
       mov       r8d,r12d
       sub       r8d,[rbp-70]
       mov       rcx,[rbp-0C8]
       mov       edx,20
       call      qword ptr [7FF8A82C54D0]
       jmp       near ptr M00_L14
M00_L41:
       mov       rdx,rax
       mov       rcx,offset MT_System.IFormattable
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       r10,rax
       mov       rax,[rbp-0D0]
       jmp       near ptr M00_L09
M00_L42:
       mov       rdx,[rbp-0E0]
       cmp       dword ptr [rbp-58],0
       je        short M00_L43
       vmovdqu   xmm0,xmmword ptr [rbp-60]
       vmovdqu   xmmword ptr [rbp-0C0],xmm0
       lea       rcx,[rbp-0C0]
       call      System.String.Ctor(System.ReadOnlySpan`1<Char>)
       mov       r13,rax
       mov       rdx,[rbp-0E0]
M00_L43:
       mov       rcx,rdx
       mov       r8,r15
       mov       rdx,r13
       mov       r11,7FF8A7B70AB8
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M00_L11
M00_L44:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       jmp       near ptr M00_L10
M00_L45:
       mov       r13,2C010CA0008
       jmp       near ptr M00_L12
M00_L46:
       cmp       dword ptr [rbp-4C],0
       je        short M00_L47
       mov       rcx,[rbp-0C8]
       mov       rdx,r13
       call      qword ptr [7FF8A7D9F228]; System.Text.StringBuilder.Append(System.String)
       mov       r8d,r12d
       sub       r8d,[r13+8]
       mov       rcx,[rbp-0C8]
       mov       edx,20
       call      qword ptr [7FF8A82C54D0]
       jmp       near ptr M00_L14
M00_L47:
       mov       r8d,r12d
       sub       r8d,[r13+8]
       mov       rcx,[rbp-0C8]
       mov       edx,20
       call      qword ptr [7FF8A82C54D0]
       jmp       near ptr M00_L13
M00_L48:
       mov       [rbp-0C0],r12
       mov       esi,[rbp-0AC]
       mov       [rbp-0B8],esi
       lea       rdx,[rbp-0C0]
       mov       rcx,[rbp-0C8]
       call      qword ptr [7FF8A8246898]; System.Text.StringBuilder.Append(System.ReadOnlySpan`1<Char>)
       jmp       near ptr M00_L21
M00_L49:
       call      qword ptr [7FF8A7D97198]
       int       3
M00_L50:
       mov       ecx,[rbp-48]
       mov       edx,4B
       call      qword ptr [7FF8A82C58C0]
       int       3
M00_L51:
       mov       ecx,[rbp-48]
       mov       edx,4D
       call      qword ptr [7FF8A82C58C0]
       int       3
M00_L52:
       mov       ecx,[rbp-48]
       mov       edx,4C
       call      qword ptr [7FF8A82C58C0]
       int       3
M00_L53:
       mov       ecx,[rbp-48]
       mov       edx,4C
       call      qword ptr [7FF8A82C58C0]
       int       3
M00_L54:
       call      qword ptr [7FF8A82C58D8]
       int       3
M00_L55:
       call      qword ptr [7FF8A82C58F0]
       int       3
M00_L56:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L57:
       mov       rcx,[rbp-0C8]
       xor       edx,edx
       call      qword ptr [7FF8A8245548]; System.Text.StringBuilder.set_Length(Int32)
       mov       rcx,rdi
       mov       rdx,[rbp-0C8]
       call      qword ptr [7FF8A8245560]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].ReturnCore(System.__Canon)
M00_L58:
       mov       [rbp-0A8],rsi
       mov       rcx,[rbx+88]
       lea       r8,[rbp-0A8]
       mov       rdx,7FF8A82ABEC8
       cmp       [rcx],ecx
       call      qword ptr [7FF8A824E718]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,0D8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L59:
       mov       rsi,2C010CA0008
       jmp       short M00_L58
M00_L60:
       call      qword ptr [7FF8A82C5128]
       int       3
M00_L61:
       mov       rcx,[r14+18]
       lea       rdx,[rbp-40]
       cmp       [rcx],ecx
       call      qword ptr [7FF8A8245428]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M00_L62
       add       r14,2C
       lock dec  dword ptr [r14]
       jmp       near ptr M00_L00
M00_L62:
       mov       rax,[r14+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r14,rax
       jmp       near ptr M00_L01
M00_L63:
       mov       ecx,13CC2
       mov       rdx,7FF8A7B64000
       call      qword ptr [7FF8A7E47798]
       mov       rdx,rax
       mov       ecx,r15d
       call      qword ptr [7FF8A82C48B8]
       int       3
M00_L64:
       mov       rcx,r14
       mov       edx,r15d
       call      qword ptr [7FF8A82C55C0]
       jmp       near ptr M00_L05
M00_L65:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       mov       rcx,[rbp-0C8]
       cmp       [rcx],cl
       xor       edx,edx
       call      qword ptr [7FF8A8245548]; System.Text.StringBuilder.set_Length(Int32)
       mov       rcx,27F7BC021A8
       mov       rdi,[rcx]
       mov       rcx,rdi
       mov       rdx,[rbp-0C8]
       call      qword ptr [7FF8A8245560]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].ReturnCore(System.__Canon)
       nop
       add       rsp,28
       ret
; Total bytes of code 2322
```
```assembly
; System.Text.StringBuilder.Append(System.String)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       test      rdx,rdx
       je        short M01_L01
       lea       rax,[rdx+0C]
       mov       r8d,[rdx+8]
       test      r8d,r8d
       je        short M01_L01
       mov       rcx,[rbx+8]
       mov       edx,[rbx+18]
       lea       esi,[rdx+r8]
       cmp       esi,[rcx+8]
       ja        short M01_L03
       movsxd    rdx,edx
       lea       rcx,[rcx+rdx*2+10]
       cmp       r8d,2
       jle       short M01_L02
       mov       r8d,r8d
       add       r8,r8
       mov       rdx,rax
       call      qword ptr [7FF8A7C25818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L00:
       mov       [rbx+18],esi
M01_L01:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L02:
       movzx     edx,word ptr [rax]
       mov       [rcx],dx
       cmp       r8d,2
       jne       short M01_L00
       movzx     eax,word ptr [rax+2]
       mov       [rcx+2],ax
       jmp       short M01_L00
M01_L03:
       mov       rcx,rbx
       mov       rdx,rax
       call      qword ptr [7FF8A7D9F1E0]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M01_L01
; Total bytes of code 121
```
```assembly
; System.PackedSpanHelpers.IndexOfAny[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib],[System.PackedSpanHelpers+NopTransform, System.Private.CoreLib]](Int16 ByRef, Int16, Int16, Int32)
       push      rbx
       cmp       r9d,8
       jl        near ptr M02_L07
       mov       rax,rcx
       cmp       r9d,10
       jle       short M02_L04
       vmovd     xmm0,edx
       vpbroadcastb ymm0,xmm0
       vmovd     xmm1,r8d
       vpbroadcastb ymm1,xmm1
       cmp       r9d,20
       jg        near ptr M02_L22
M02_L00:
       add       r9d,0FFFFFFF0
       movsxd    rdx,r9d
       lea       rdx,[rcx+rdx*2]
       cmp       rax,rdx
       cmova     rax,rdx
       vmovups   ymm2,[rax]
       vpackuswb ymm2,ymm2,[rdx]
       vpcmpeqb  ymm0,ymm2,ymm0
       vpcmpeqb  ymm1,ymm2,ymm1
       vpor      ymm0,ymm1,ymm0
       vptest    ymm0,ymm0
       je        near ptr M02_L21
       vpermq    ymm0,ymm0,0D8
       vpmovmskb r8d,ymm0
       tzcnt     r8d,r8d
       cmp       r8d,10
       jge       short M02_L03
M02_L01:
       sub       rax,rcx
       shr       rax,1
       add       eax,r8d
M02_L02:
       vzeroupper
       pop       rbx
       ret
M02_L03:
       mov       rax,rdx
       add       r8d,0FFFFFFF0
       jmp       short M02_L01
M02_L04:
       vmovd     xmm0,edx
       vpbroadcastb xmm0,xmm0
       vmovd     xmm1,r8d
       vpbroadcastb xmm1,xmm1
       lea       eax,[r9-8]
       movsxd    r9,eax
       lea       rax,[rcx+r9*2]
       cmp       rcx,rax
       mov       rdx,rcx
       cmova     rdx,rax
       vmovups   xmm2,[rdx]
       vpackuswb xmm2,xmm2,[rax]
       vpcmpeqb  xmm0,xmm2,xmm0
       vpcmpeqb  xmm1,xmm2,xmm1
       vpor      xmm0,xmm1,xmm0
       vptest    xmm0,xmm0
       je        near ptr M02_L21
       vpmovmskb r8d,xmm0
       tzcnt     r8d,r8d
       cmp       r8d,8
       jge       short M02_L06
M02_L05:
       sub       rdx,rcx
       shr       rdx,1
       lea       eax,[rdx+r8]
       jmp       short M02_L02
M02_L06:
       mov       rdx,rax
       add       r8d,0FFFFFFF8
       jmp       short M02_L05
M02_L07:
       xor       eax,eax
       cmp       r9d,4
       jl        near ptr M02_L19
       add       r9d,0FFFFFFFC
       movsx     r10,word ptr [rcx]
       movsx     r11,dx
       cmp       r10d,r11d
       je        short M02_L08
       movsx     rbx,r8w
       cmp       r10d,ebx
       jne       short M02_L09
M02_L08:
       xor       eax,eax
       vzeroupper
       pop       rbx
       ret
M02_L09:
       movsx     r10,word ptr [rcx+2]
       cmp       r10d,r11d
       je        short M02_L10
       cmp       r10d,ebx
       jne       short M02_L11
M02_L10:
       mov       eax,1
       vzeroupper
       pop       rbx
       ret
M02_L11:
       movsx     r10,word ptr [rcx+4]
       cmp       r10d,r11d
       je        short M02_L12
       cmp       r10d,ebx
       jne       short M02_L13
M02_L12:
       mov       eax,2
       vzeroupper
       pop       rbx
       ret
M02_L13:
       movsx     r10,word ptr [rcx+6]
       cmp       r10d,r11d
       je        short M02_L14
       cmp       r10d,ebx
       jne       short M02_L15
M02_L14:
       mov       eax,3
       jmp       near ptr M02_L02
M02_L15:
       mov       eax,4
       jmp       short M02_L19
M02_L16:
       movsx     rbx,r8w
       cmp       r10d,ebx
       jne       short M02_L18
M02_L17:
       jmp       near ptr M02_L02
M02_L18:
       inc       rax
       test      r9d,r9d
       jg        short M02_L20
       jmp       short M02_L21
M02_L19:
       test      r9d,r9d
       jle       short M02_L21
M02_L20:
       dec       r9d
       movsx     r10,word ptr [rcx+rax*2]
       movsx     r11,dx
       cmp       r10d,r11d
       je        short M02_L17
       jmp       short M02_L16
M02_L21:
       mov       eax,0FFFFFFFF
       jmp       near ptr M02_L02
M02_L22:
       lea       edx,[r9-20]
       movsxd    r8,edx
       lea       rdx,[rax+r8*2]
M02_L23:
       vmovups   ymm2,[rax]
       vpackuswb ymm2,ymm2,[rax+20]
       vpcmpeqb  ymm3,ymm0,ymm2
       vpcmpeqb  ymm2,ymm1,ymm2
       vpor      ymm2,ymm2,ymm3
       vptest    ymm2,ymm2
       jne       short M02_L24
       add       rax,40
       cmp       rax,rdx
       jb        short M02_L23
       jmp       near ptr M02_L00
M02_L24:
       sub       rax,rcx
       shr       rax,1
       vpermq    ymm0,ymm2,0D8
       vpmovmskb ecx,ymm0
       tzcnt     ecx,ecx
       add       eax,ecx
       jmp       near ptr M02_L02
; Total bytes of code 514
```
```assembly
; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M03_L12
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M03_L12
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       jbe       near ptr M03_L07
       cmp       r8,40
       ja        short M03_L03
M03_L00:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        short M03_L06
M03_L01:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
M03_L02:
       vzeroupper
       ret
M03_L03:
       cmp       r8,800
       ja        near ptr M03_L13
       cmp       r8,100
       jae       near ptr M03_L11
M03_L04:
       mov       r9,r8
       shr       r9,6
M03_L05:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M03_L05
       and       r8,3F
       cmp       r8,10
       ja        short M03_L00
       jmp       short M03_L01
M03_L06:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M03_L01
       jmp       short M03_L08
M03_L07:
       test      r8b,18
       je        short M03_L09
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
       jmp       short M03_L02
M03_L08:
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       near ptr M03_L01
M03_L09:
       test      r8b,4
       je        short M03_L10
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
       jmp       near ptr M03_L02
M03_L10:
       test      r8,r8
       je        near ptr M03_L02
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        near ptr M03_L02
       movsx     rcx,word ptr [rax-2]
       mov       [r10-2],cx
       jmp       near ptr M03_L02
M03_L11:
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
       jmp       near ptr M03_L04
M03_L12:
       cmp       rcx,rdx
       jne       short M03_L13
       cmp       [rdx],dl
       jmp       near ptr M03_L02
M03_L13:
       cmp       [rcx],cl
       cmp       [rdx],dl
       vzeroupper
       jmp       qword ptr [7FF8A7C266E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 348
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       edx,[rbx+1C]
       add       edx,[rbx+18]
       je        short M04_L02
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FF9078A50F0
       mov       rsi,rax
M04_L00:
       mov       r8d,[rbx+18]
       test      r8d,r8d
       jle       short M04_L01
       mov       rdx,[rbx+8]
       mov       ecx,[rbx+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rsi+8]
       ja        short M04_L03
       cmp       [rdx+8],r8d
       jb        short M04_L03
       movsxd    rcx,ecx
       lea       rcx,[rsi+rcx*2+0C]
       movsxd    r8,r8d
       add       r8,r8
       add       rdx,10
       call      qword ptr [7FF8A7C25818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M04_L01:
       mov       rbx,[rbx+10]
       test      rbx,rbx
       jne       short M04_L00
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L02:
       mov       rax,2C010CA0008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,19655
       mov       rdx,7FF8A7B64000
       call      qword ptr [7FF8A7E47798]
       mov       rbx,rax
       call      qword ptr [7FF8A82C5218]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF8A7E4D9C8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 201
```
```assembly
; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rdi,rdx
       mov       esi,r8d
       mov       eax,[rbx+1C]
       mov       ecx,[rbx+18]
       add       eax,ecx
       add       eax,esi
       cmp       eax,[rbx+20]
       jg        near ptr M05_L06
       cmp       eax,esi
       jl        near ptr M05_L06
       mov       rax,[rbx+8]
       mov       ebp,[rax+8]
       sub       ebp,ecx
       test      ebp,ebp
       jg        short M05_L01
M05_L00:
       sub       esi,ebp
       mov       ecx,[rbx+1C]
       lea       edx,[rsi+rcx]
       mov       eax,[rbx+18]
       add       edx,eax
       cmp       edx,[rbx+20]
       jg        near ptr M05_L09
       cmp       edx,esi
       jl        near ptr M05_L09
       add       ecx,eax
       mov       edx,ecx
       mov       eax,1F40
       cmp       edx,1F40
       cmovg     edx,eax
       cmp       esi,edx
       mov       eax,edx
       cmovge    eax,esi
       add       ecx,eax
       cmp       ecx,eax
       jl        near ptr M05_L10
       cmp       eax,400
       jge       short M05_L03
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
       jmp       short M05_L04
M05_L01:
       mov       rax,[rbx+8]
       test      rax,rax
       je        near ptr M05_L07
       mov       edx,[rax+8]
       cmp       edx,ecx
       jb        near ptr M05_L08
       mov       r8d,ecx
       lea       rax,[rax+r8*2+10]
       sub       edx,ecx
M05_L02:
       cmp       ebp,edx
       ja        near ptr M05_L12
       mov       r8d,ebp
       add       r8,r8
       mov       rcx,rax
       mov       rdx,rdi
       call      qword ptr [7FF8A7C25818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
       jmp       near ptr M05_L00
M05_L03:
       mov       ecx,eax
       xor       edx,edx
       call      qword ptr [7FF8A81AF018]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       r14,rax
M05_L04:
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       ecx,[rbx+18]
       mov       [r15+18],ecx
       mov       ecx,[rbx+1C]
       mov       [r15+1C],ecx
       mov       rdx,[rbx+8]
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbx+10]
       lea       rcx,[r15+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rbx+20]
       mov       [r15+20],ecx
       lea       rcx,[rbx+10]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rbx+18]
       add       [rbx+1C],ecx
       xor       ecx,ecx
       mov       [rbx+18],ecx
       lea       rcx,[rbx+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       movsxd    r8,ebp
       lea       rdx,[rdi+r8*2]
       mov       r8,[rbx+8]
       test      r8,r8
       je        near ptr M05_L11
       lea       rcx,[r8+10]
       mov       r8d,[r8+8]
M05_L05:
       cmp       esi,r8d
       ja        near ptr M05_L12
       mov       r8d,esi
       add       r8,r8
       call      qword ptr [7FF8A7C25818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       [rbx+18],esi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M05_L06:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,19685
       mov       rdx,7FF8A7B64000
       call      qword ptr [7FF8A7E47798]
       mov       rsi,rax
       call      qword ptr [7FF8A82C5320]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF8A7E4D9C8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M05_L07:
       test      ecx,ecx
       jne       short M05_L08
       xor       eax,eax
       xor       edx,edx
       jmp       near ptr M05_L02
M05_L08:
       call      qword ptr [7FF8A7D97198]
       int       3
M05_L09:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,1969B
       mov       rdx,7FF8A7B64000
       call      qword ptr [7FF8A7E47798]
       mov       rsi,rax
       call      qword ptr [7FF8A82C5368]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF8A7E4D9C8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M05_L10:
       mov       rcx,offset MT_System.OutOfMemoryException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8A82C5380]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M05_L11:
       xor       ecx,ecx
       xor       r8d,r8d
       jmp       near ptr M05_L05
M05_L12:
       call      qword ptr [7FF8A803CF90]
       int       3
; Total bytes of code 626
```
```assembly
; System.Text.StringBuilder.Append(Char)
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       ecx,[rbx+18]
       mov       eax,ecx
       mov       r8,[rbx+8]
       mov       r10d,[r8+8]
       cmp       r10d,eax
       jbe       short M06_L01
       mov       [r8+rax*2+10],dx
       inc       ecx
       mov       [rbx+18],ecx
M06_L00:
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       ret
M06_L01:
       movzx     edx,dx
       mov       rcx,rbx
       call      qword ptr [7FF8A7D9F3A8]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M06_L00
; Total bytes of code 60
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rdx,rdx
       je        short M07_L04
       mov       rax,[rdx]
       movzx     r8d,word ptr [rax+0E]
       test      r8,r8
       je        short M07_L03
       mov       r10,[rax+38]
       cmp       r8,4
       jl        short M07_L01
       cmp       [r10],rcx
       je        short M07_L04
M07_L00:
       cmp       [r10+8],rcx
       je        short M07_L04
       cmp       [r10+10],rcx
       je        short M07_L04
       cmp       [r10+18],rcx
       je        short M07_L04
       add       r10,20
       add       r8,0FFFFFFFFFFFFFFFC
       cmp       r8,4
       jge       short M07_L05
       test      r8,r8
       je        short M07_L03
M07_L01:
       cmp       [r10],rcx
       je        short M07_L04
M07_L02:
       add       r10,8
       dec       r8
       test      r8,r8
       jg        short M07_L06
M07_L03:
       test      dword ptr [rax],500C0000
       jne       short M07_L07
       xor       edx,edx
M07_L04:
       mov       rax,rdx
       ret
M07_L05:
       cmp       [r10],rcx
       je        short M07_L04
       jmp       short M07_L00
M07_L06:
       cmp       [r10],rcx
       je        short M07_L04
       jmp       short M07_L02
M07_L07:
       jmp       qword ptr [7FF8A7FAD8C0]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
; Total bytes of code 121
```
```assembly
; System.String.Ctor(System.ReadOnlySpan`1<Char>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,[rcx]
       mov       esi,[rcx+8]
       test      esi,esi
       je        short M08_L00
       mov       edx,esi
       mov       rcx,offset MT_System.String
       call      00007FF9078A50F0
       mov       rdi,rax
       cmp       [rdi],dil
       lea       rcx,[rdi+0C]
       mov       r8d,esi
       add       r8,r8
       mov       rdx,rbx
       call      qword ptr [7FF8A7C25818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rdi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M08_L00:
       mov       rax,2C010CA0008
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 88
```
```assembly
; System.Text.StringBuilder.Append(System.ReadOnlySpan`1<Char>)
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rax,[rdx]
       mov       r8d,[rdx+8]
       mov       rcx,rbx
       mov       rdx,rax
       call      qword ptr [7FF8D75737A8]; Precode of System.Text.StringBuilder.Append(Char ByRef, Int32)
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 36
```
```assembly
; System.Text.StringBuilder.set_Length(Int32)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       test      esi,esi
       jl        short M10_L01
       cmp       esi,[rbx+20]
       jg        short M10_L02
       test      esi,esi
       jne       near ptr M10_L03
       cmp       qword ptr [rbx+10],0
       jne       short M10_L03
       xor       ecx,ecx
       mov       [rbx+18],rcx
M10_L00:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M10_L01:
       mov       ecx,3AD
       mov       rdx,7FF8A7B64000
       call      qword ptr [7FF8A7E47798]
       mov       rdx,rax
       mov       ecx,esi
       call      qword ptr [7FF8A82C48B8]
       int       3
M10_L02:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FF8A7B64000
       call      qword ptr [7FF8A7E47798]
       mov       rsi,rax
       call      qword ptr [7FF8A82C5368]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF8A7E4D9C8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M10_L03:
       mov       ecx,[rbx+1C]
       add       ecx,[rbx+18]
       mov       r8d,esi
       sub       r8d,ecx
       test      r8d,r8d
       jle       short M10_L04
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF8A82C54D0]
       jmp       near ptr M10_L00
M10_L04:
       mov       rcx,rbx
       mov       edx,esi
       call      qword ptr [7FF8A82C54E8]
       mov       rdi,rax
       cmp       rdi,rbx
       je        near ptr M10_L09
       mov       rax,[rbx+8]
       mov       ecx,[rax+8]
       add       ecx,[rbx+1C]
       mov       eax,[rbx+1C]
       add       eax,[rbx+18]
       lea       edx,[rax+rax*2]
       add       edx,edx
       mov       r8d,66666667
       mov       eax,r8d
       imul      edx
       mov       eax,edx
       shr       eax,1F
       sar       edx,1
       add       edx,eax
       mov       rax,[rbx+8]
       mov       eax,[rax+8]
       cmp       edx,eax
       cmovl     edx,eax
       cmp       ecx,edx
       cmovg     ecx,edx
       sub       ecx,[rdi+1C]
       mov       rdx,[rdi+8]
       cmp       [rdx+8],ecx
       jge       short M10_L07
       cmp       ecx,400
       jge       short M10_L05
       movsxd    rdx,ecx
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbp,rax
       jmp       short M10_L06
M10_L05:
       xor       edx,edx
       call      qword ptr [7FF8A81AF018]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       rbp,rax
M10_L06:
       mov       rcx,[rdi+8]
       mov       r8d,[rdi+18]
       mov       rdx,rbp
       call      qword ptr [7FF8A7D95050]; System.Array.Copy(System.Array, System.Array, Int32)
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M10_L08
M10_L07:
       mov       rdx,[rdi+8]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
M10_L08:
       mov       rdx,[rdi+10]
       lea       rcx,[rbx+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rdi+1C]
       mov       [rbx+1C],ecx
M10_L09:
       sub       esi,[rdi+1C]
       mov       [rbx+18],esi
       jmp       near ptr M10_L00
; Total bytes of code 399
```
```assembly
; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].ReturnCore(System.__Canon)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,[rsi+10]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [rdi+18],rcx
       jne       near ptr M11_L10
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       add       ecx,[rbx+1C]
       mov       rdx,[rdi+8]
       cmp       ecx,[rdx+0C]
       jg        near ptr M11_L11
       cmp       dword ptr [rbx+20],0
       jl        short M11_L02
       cmp       qword ptr [rbx+10],0
       jne       near ptr M11_L03
       xor       ecx,ecx
       mov       [rbx+18],rcx
M11_L00:
       cmp       qword ptr [rsi+20],0
       jne       near ptr M11_L13
       lea       rcx,[rsi+20]
       test      rcx,rcx
       je        near ptr M11_L12
       mov       rdx,rbx
       xor       r8d,r8d
       call      00007FF907846040
       test      rax,rax
       jne       near ptr M11_L13
M11_L01:
       mov       eax,1
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M11_L02:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FF8A7B64000
       call      qword ptr [7FF8A7E47798]
       mov       rsi,rax
       call      qword ptr [7FF8A82C5368]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF8A7E4D9C8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M11_L03:
       mov       ecx,[rbx+1C]
       add       ecx,[rbx+18]
       mov       r8d,ecx
       neg       r8d
       test      r8d,r8d
       jle       short M11_L04
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF8A82C54D0]
       jmp       near ptr M11_L00
M11_L04:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF8A82C54E8]
       mov       rdi,rax
       cmp       rdi,rbx
       je        near ptr M11_L09
       mov       rax,[rbx+8]
       mov       ecx,[rax+8]
       add       ecx,[rbx+1C]
       mov       eax,[rbx+1C]
       add       eax,[rbx+18]
       lea       edx,[rax+rax*2]
       add       edx,edx
       mov       r8d,66666667
       mov       eax,r8d
       imul      edx
       mov       eax,edx
       shr       eax,1F
       sar       edx,1
       add       edx,eax
       mov       rax,[rbx+8]
       mov       eax,[rax+8]
       cmp       edx,eax
       cmovl     edx,eax
       cmp       ecx,edx
       cmovg     ecx,edx
       sub       ecx,[rdi+1C]
       mov       rdx,[rdi+8]
       cmp       [rdx+8],ecx
       jge       short M11_L07
       cmp       ecx,400
       jge       short M11_L05
       movsxd    rdx,ecx
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbp,rax
       jmp       short M11_L06
M11_L05:
       xor       edx,edx
       call      qword ptr [7FF8A81AF018]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       rbp,rax
M11_L06:
       mov       rcx,[rdi+8]
       mov       r8d,[rdi+18]
       mov       rdx,rbp
       call      qword ptr [7FF8A7D95050]; System.Array.Copy(System.Array, System.Array, Int32)
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M11_L08
M11_L07:
       mov       rdx,[rdi+8]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
M11_L08:
       mov       rdx,[rdi+10]
       lea       rcx,[rbx+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rdi+1C]
       mov       [rbx+1C],ecx
M11_L09:
       mov       ecx,[rdi+1C]
       neg       ecx
       mov       [rbx+18],ecx
       jmp       near ptr M11_L00
M11_L10:
       mov       rdx,rbx
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       test      eax,eax
       jne       near ptr M11_L00
M11_L11:
       xor       eax,eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M11_L12:
       call      qword ptr [7FF8A82C5128]
       int       3
M11_L13:
       lea       rcx,[rsi+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[rsi+28]
       jg        short M11_L14
       mov       rcx,[rsi+18]
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FF8A82C6958]
       jmp       near ptr M11_L01
M11_L14:
       add       rsi,2C
       lock dec  dword ptr [rsi]
       jmp       short M11_L11
; Total bytes of code 543
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
; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,[rsi+18]
       mov       rcx,rdi
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FF8D757EA60]; Precode of System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       jne       short M13_L01
       cmp       qword ptr [rdi+10],0
       je        short M13_L00
       mov       rcx,rsi
       mov       rdx,rbx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax]
M13_L00:
       xor       eax,eax
       mov       [rbx],rax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M13_L01:
       mov       eax,1
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 91
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderBenchmark.FormatCurrentCulture()
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
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-70],ymm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       xor       eax,eax
       mov       [rbp-40],rax
       mov       [rbp+10],rcx
       mov       rbx,[rcx+198]
       test      rbx,rbx
       je        near ptr M00_L32
       cmp       dword ptr [rbx+8],0
       je        near ptr M00_L32
       mov       r8,1B6AF8021A8
       mov       rsi,[r8]
       mov       r8,[rsi+20]
       mov       [rbp-40],r8
       cmp       qword ptr [rbp-40],0
       je        near ptr M00_L34
       lea       r8,[rsi+20]
       mov       rdx,[rbp-40]
       test      r8,r8
       je        near ptr M00_L33
       mov       rcx,r8
       mov       r8,rdx
       xor       edx,edx
       call      00007FF907846040
       cmp       rax,[rbp-40]
       jne       near ptr M00_L34
M00_L00:
       mov       rdx,[rbp-40]
M00_L01:
       xor       ecx,ecx
       mov       [rbp-40],rcx
       mov       [rbp-68],rdx
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],2
       jle       near ptr M00_L13
       mov       rcx,[rcx+240]
       mov       rax,[rcx+10]
       test      rax,rax
       je        near ptr M00_L13
M00_L02:
       mov       rsi,[rax+10]
       test      rsi,rsi
       jne       short M00_L03
       mov       rax,1B6AF800110
       mov       rsi,[rax]
       test      rsi,rsi
       jne       short M00_L03
       mov       rax,1B6AF8000F0
       mov       rsi,[rax]
       test      rsi,rsi
       je        near ptr M00_L14
M00_L03:
       mov       rcx,1B6AF8021C0
       mov       rdi,[rcx]
       mov       rcx,1B6AF8021B0
       mov       r14,[rcx]
       test      rdi,rdi
       je        near ptr M00_L15
M00_L04:
       mov       r15,[r14+8]
       mov       rcx,[r15+8]
       cmp       byte ptr [r14+19],0
       je        near ptr M00_L16
       mov       rcx,1F744600AAC
       mov       edx,9B90445C
       mov       r11d,0CA92B6B8
       mov       eax,7
M00_L05:
       add       edx,[rcx]
       mov       r8d,[rcx+4]
       xor       r11d,edx
       rol       edx,14
       add       edx,r11d
       rol       r11d,9
       xor       r11d,edx
       rol       edx,1B
       add       edx,r11d
       rol       r11d,13
       add       r8d,edx
       mov       edx,r11d
       xor       edx,r8d
       rol       r8d,14
       add       r8d,edx
       rol       edx,9
       xor       edx,r8d
       rol       r8d,1B
       add       r8d,edx
       rol       edx,13
       mov       r11d,r8d
       add       rcx,8
       dec       eax
       mov       r8d,edx
       mov       edx,r11d
       mov       r11d,r8d
       jne       short M00_L05
       add       edx,[rcx]
       xor       r11d,edx
       rol       edx,14
       add       edx,r11d
       rol       r11d,9
       xor       r11d,edx
       rol       edx,1B
       add       edx,r11d
       rol       r11d,13
       mov       ecx,[rcx+2]
       shr       ecx,8
       or        ecx,80000000
       shr       ecx,8
       add       ecx,edx
       mov       edx,r11d
       xor       edx,ecx
       rol       ecx,14
       add       ecx,edx
       rol       edx,9
       xor       edx,ecx
       rol       ecx,1B
       add       ecx,edx
       rol       edx,13
       xor       edx,ecx
       mov       r13d,ecx
       rol       r13d,14
       add       r13d,edx
       rol       edx,9
       xor       edx,r13d
       rol       r13d,1B
       add       r13d,edx
       mov       r12d,edx
       rol       r12d,13
       xor       r13d,r12d
M00_L06:
       mov       r12,[r15+8]
       mov       r8,[r15+10]
       mov       edx,r13d
       imul      rdx,[r15+28]
       shr       rdx,20
       inc       rdx
       mov       ecx,[r8+8]
       imul      rdx,rcx
       shr       rdx,20
       cmp       edx,[r8+8]
       jae       near ptr M00_L29
       mov       edx,edx
       mov       rax,[r8+rdx*8+10]
       test      rax,rax
       je        near ptr M00_L27
       test      r12,r12
       je        near ptr M00_L11
       mov       r8,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer+OrdinalComparer
       cmp       [r12],r8
       jne       near ptr M00_L11
M00_L07:
       cmp       r13d,[rax+20]
       jne       near ptr M00_L17
       mov       [rbp-78],rax
       mov       rdx,[rax+8]
       mov       r8,1F744600AA0
       cmp       rdx,r8
       jne       near ptr M00_L18
       mov       r12d,1
M00_L08:
       test      r12d,r12d
       je        near ptr M00_L21
M00_L09:
       mov       rax,[rbp-78]
       mov       rdx,[rax+10]
       mov       [rbp-48],rdx
M00_L10:
       mov       r8,[rbp-48]
       xor       r9d,r9d
       mov       [rbp-48],r9
       mov       rdx,[rbp-68]
       cmp       [rdx],dl
       test      r8,r8
       je        near ptr M00_L28
       lea       r9,[rbx+10]
       mov       ecx,[rbx+8]
       mov       [rbp-60],r9
       mov       [rbp-58],ecx
       lea       r9,[rbp-60]
       mov       rdx,rsi
       mov       rcx,[rbp-68]
       call      qword ptr [7FF8A822E6E8]; System.Text.StringBuilder.AppendFormat(System.IFormatProvider, System.Text.CompositeFormat, System.ReadOnlySpan`1<System.Object>)
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF8A7DF2200]; System.Text.StringBuilder.ToString()
       mov       [rbp-70],rax
       jmp       near ptr M00_L30
M00_L11:
       cmp       r13d,[rax+20]
       jne       near ptr M00_L26
       mov       [rbp-78],rax
       mov       rdx,[rax+8]
       mov       r8,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer+OrdinalComparer
       cmp       [r12],r8
       jne       near ptr M00_L22
       mov       r8,1F744600AA0
       cmp       rdx,r8
       jne       near ptr M00_L23
       mov       r10d,1
M00_L12:
       test      r10d,r10d
       je        near ptr M00_L25
       jmp       near ptr M00_L09
M00_L13:
       mov       ecx,2
       call      qword ptr [7FF8A82A5140]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L02
M00_L14:
       call      qword ptr [7FF8A7E25E00]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rsi,rax
       jmp       near ptr M00_L03
M00_L15:
       mov       rcx,offset MT_System.Func<System.String, System.Text.CompositeFormat>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,1B6AF8021B8
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Core.ResourceFormatCache+<>c.<GetOrAdd>b__1_0(System.String)
       call      qword ptr [7FF8A7C06BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1B6AF8021C0
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L04
M00_L16:
       mov       rdx,1F744600AA0
       mov       r11,7FF8A7B50AB8
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       near ptr M00_L06
M00_L17:
       mov       [rbp-78],rax
       jmp       short M00_L21
M00_L18:
       test      rdx,rdx
       je        short M00_L19
       cmp       dword ptr [rdx+8],1F
       je        short M00_L20
M00_L19:
       xor       r12d,r12d
       jmp       near ptr M00_L08
M00_L20:
       lea       rcx,[rdx+0C]
       mov       r8d,[rdx+8]
       add       r8d,r8d
       mov       rdx,1F744600AAC
       call      qword ptr [7FF8A7C0FBB8]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r12d,eax
       jmp       near ptr M00_L08
M00_L21:
       mov       rax,[rbp-78]
       mov       rax,[rax+18]
       test      rax,rax
       jne       near ptr M00_L07
       jmp       short M00_L27
M00_L22:
       mov       rcx,r12
       mov       r8,1F744600AA0
       mov       r11,7FF8A7B50AC0
       call      qword ptr [r11]
       mov       r10d,eax
       jmp       near ptr M00_L12
M00_L23:
       test      rdx,rdx
       je        short M00_L24
       cmp       dword ptr [rdx+8],1F
       jne       short M00_L24
       lea       rcx,[rdx+0C]
       mov       r8d,[rdx+8]
       add       r8d,r8d
       mov       rdx,1F744600AAC
       call      qword ptr [7FF8A7C0FBB8]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r10d,eax
       jmp       near ptr M00_L12
M00_L24:
       xor       ecx,ecx
       mov       r10d,ecx
       jmp       near ptr M00_L12
M00_L25:
       mov       rax,[rbp-78]
M00_L26:
       mov       rax,[rax+18]
       test      rax,rax
       jne       near ptr M00_L11
M00_L27:
       xor       edx,edx
       mov       [rbp-48],rdx
       mov       rdx,1F744600AA0
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       xor       r9d,r9d
       mov       [rsp+28],r9d
       mov       dword ptr [rsp+30],1
       lea       r9,[rbp-48]
       mov       [rsp+38],r9
       mov       [rsp+20],rax
       mov       r9d,r13d
       shl       r9,20
       or        r9,1
       mov       rdx,r15
       mov       r8,1F744600AA0
       mov       rcx,r14
       call      qword ptr [7FF8A7F8C6D8]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryAddInternal(Tables<System.__Canon,System.__Canon>, System.__Canon, System.Nullable`1<Int32>, System.__Canon, Boolean, Boolean, System.__Canon ByRef)
       jmp       near ptr M00_L10
M00_L28:
       mov       ecx,3B9
       mov       rdx,7FF8A7B44000
       call      qword ptr [7FF8A7E27798]
       mov       rcx,rax
       call      qword ptr [7FF8A82A4E70]
       int       3
M00_L29:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L30:
       call      M00_L36
       nop
       mov       rax,[rbp-70]
M00_L31:
       mov       [rbp-50],rax
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+88]
       lea       r8,[rbp-50]
       mov       rdx,7FF8A828D790
       cmp       [rcx],ecx
       call      qword ptr [7FF8A822E7F0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
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
M00_L32:
       mov       rax,1F7445F0008
       jmp       short M00_L31
M00_L33:
       call      qword ptr [7FF8A82A56B0]
       int       3
M00_L34:
       mov       rcx,[rsi+18]
       lea       rdx,[rbp-40]
       cmp       [rcx],ecx
       call      qword ptr [7FF8A82254B8]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M00_L35
       add       rsi,2C
       lock dec  dword ptr [rsi]
       jmp       near ptr M00_L00
M00_L35:
       mov       rax,[rsi+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       rdx,rax
       jmp       near ptr M00_L01
M00_L36:
       sub       rsp,48
       mov       rdx,[rbp-68]
       cmp       [rdx],dl
       mov       rcx,rdx
       xor       edx,edx
       call      qword ptr [7FF8A8225608]; System.Text.StringBuilder.set_Length(Int32)
       mov       rdx,1B6AF8021A8
       mov       rbx,[rdx]
       mov       rax,[rbx+10]
       mov       rdx,[rbp-68]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       test      eax,eax
       jne       short M00_L38
M00_L37:
       add       rsp,48
       ret
M00_L38:
       cmp       qword ptr [rbx+20],0
       jne       short M00_L40
       lea       rcx,[rbx+20]
       test      rcx,rcx
       jne       short M00_L39
       call      qword ptr [7FF8A82A56B0]
       int       3
M00_L39:
       mov       rdx,[rbp-68]
       xor       r8d,r8d
       call      00007FF907846040
       test      rax,rax
       je        short M00_L37
M00_L40:
       lea       rcx,[rbx+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[rbx+28]
       jg        short M00_L41
       mov       rbx,[rbx+18]
       mov       rcx,[rbx+10]
       mov       rdx,[rbp-68]
       cmp       [rcx],ecx
       call      qword ptr [7FF8A82A5C98]
       test      eax,eax
       jne       short M00_L37
       mov       rcx,rbx
       mov       rdx,[rbp-68]
       call      qword ptr [7FF8A82A5CB0]
       jmp       short M00_L37
M00_L41:
       add       rbx,2C
       lock dec  dword ptr [rbx]
       jmp       short M00_L37
; Total bytes of code 1585
```
```assembly
; System.Text.StringBuilder.AppendFormat(System.IFormatProvider, System.Text.CompositeFormat, System.ReadOnlySpan`1<System.Object>)
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,50
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-20],rax
       mov       rax,r8
M01_L00:
       mov       rbx,[r9]
       mov       esi,[r9+8]
       test      rax,rax
       je        short M01_L02
       cmp       esi,[rax+20]
       jl        near ptr M01_L03
       cmp       esi,2
       jbe       near ptr M01_L04
       test      esi,esi
       je        near ptr M01_L05
       mov       r8,[rbx]
       cmp       esi,1
       jbe       near ptr M01_L05
       mov       r9,[rbx+8]
       cmp       esi,2
       jbe       near ptr M01_L05
       mov       r10,[rbx+10]
       mov       [rbp-20],rbx
       mov       [rbp-18],esi
       lea       r11,[rbp-20]
       mov       [rsp+38],r11
       mov       [rsp+20],r8
       mov       [rsp+28],r9
       mov       [rsp+30],r10
       mov       r8,rdx
       mov       r9,rax
       mov       rdx,7FF8A828CDC8
       call      qword ptr [7FF8A822E700]; System.Text.StringBuilder.AppendFormat[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.IFormatProvider, System.Text.CompositeFormat, System.__Canon, System.__Canon, System.__Canon, System.ReadOnlySpan`1<System.Object>)
M01_L01:
       nop
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M01_L02:
       mov       ecx,3B9
       mov       rdx,7FF8A7B44000
       call      qword ptr [7FF8A7E27798]
       mov       rcx,rax
       call      qword ptr [7FF8A82A4E70]
       int       3
M01_L03:
       call      qword ptr [7FF8A82A5BA8]
       int       3
M01_L04:
       mov       r9d,esi
       lea       r8,[7FF8A8303AB8]
       mov       r8d,[r8+r9*4]
       lea       r10,[M01_L00]
       add       r8,r10
       jmp       r8
       xor       r8d,r8d
       mov       [rsp+20],r8d
       mov       [rsp+28],r8d
       mov       [rbp-20],rbx
       mov       [rbp-18],r8d
       lea       r8,[rbp-20]
       mov       [rsp+30],r8
       mov       r8,rax
       xor       r9d,r9d
       call      qword ptr [7FF8A82A5B90]
       jmp       short M01_L01
       mov       r8,[rbx]
       xor       r9d,r9d
       mov       [rsp+28],r9d
       mov       [rsp+30],r9d
       mov       [rbp-20],rbx
       mov       dword ptr [rbp-18],1
       lea       r9,[rbp-20]
       mov       [rsp+38],r9
       mov       [rsp+20],r8
       mov       r8,rdx
       mov       r9,rax
       mov       rdx,7FF8A828D038
       call      qword ptr [7FF8A822E760]
       jmp       near ptr M01_L01
       mov       r9,[rbx]
       mov       r8,[rbx+8]
       xor       r10d,r10d
       mov       [rsp+30],r10d
       mov       [rbp-20],rbx
       mov       dword ptr [rbp-18],2
       lea       r10,[rbp-20]
       mov       [rsp+38],r10
       mov       [rsp+20],r9
       mov       [rsp+28],r8
       mov       r9,rax
       mov       r8,rdx
       mov       rdx,7FF8A828CF00
       call      qword ptr [7FF8A822E730]
       jmp       near ptr M01_L01
M01_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 405
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       edx,[rbx+1C]
       add       edx,[rbx+18]
       je        short M02_L02
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FF9078A50F0
       mov       rsi,rax
M02_L00:
       mov       r8d,[rbx+18]
       test      r8d,r8d
       jle       short M02_L01
       mov       rdx,[rbx+8]
       mov       ecx,[rbx+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rsi+8]
       ja        short M02_L03
       cmp       [rdx+8],r8d
       jb        short M02_L03
       movsxd    rcx,ecx
       lea       rcx,[rsi+rcx*2+0C]
       movsxd    r8,r8d
       add       r8,r8
       add       rdx,10
       call      qword ptr [7FF8A7C05818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L01:
       mov       rbx,[rbx+10]
       test      rbx,rbx
       jne       short M02_L00
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L02:
       mov       rax,1F7445F0008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,19655
       mov       rdx,7FF8A7B44000
       call      qword ptr [7FF8A7E27798]
       mov       rbx,rax
       call      qword ptr [7FF8A82A56C8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF8A7E2D9C8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 201
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FF8D7571D18]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       ecx,ebx
       and       ecx,0FFFFFF
       mov       edx,ecx
       mov       r8d,ebx
       sar       r8d,18
       jne       short M03_L01
       cmp       [rax],ecx
       jle       short M03_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M03_L03
M03_L00:
       add       rsp,20
       pop       rbx
       ret
M03_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M03_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M03_L00
M03_L02:
       cmp       [rax+4],edx
       jle       short M03_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M03_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M03_L03
       jmp       short M03_L00
M03_L03:
       mov       ecx,ebx
       lea       rax,[System.Text.StringBuilder.AppendFormat[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.IFormatProvider, System.Text.CompositeFormat, System.__Canon, System.__Canon, System.__Canon, System.ReadOnlySpan`1<System.Object>)]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax]
; Total bytes of code 130
```
```assembly
; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       push      rsi
       push      rbx
       sub       rsp,28
       call      qword ptr [7FF8D75597E8]
       mov       rbx,rax
       mov       rsi,rbx
       call      qword ptr [7FF8D7570A28]
       mov       rdx,rax
       test      rsi,rsi
       je        short M04_L00
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FF8D7571BC8]
       mov       rax,[rbx]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L00:
       call      qword ptr [7FF8D756F410]
       int       3
; Total bytes of code 61
```
```assembly
; DotNetTips.Spargine.Core.ResourceFormatCache+<>c.<GetOrAdd>b__1_0(System.String)
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
; 		return _cache.GetOrAdd(format, static value => CompositeFormat.Parse(value));
; 		                                               ^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,[rbp+18]
       call      qword ptr [7FF8A8015320]; System.Text.CompositeFormat.Parse(System.String)
       nop
       add       rsp,20
       pop       rbp
       ret
; Total bytes of code 35
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M06_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M06_L00:
       call      qword ptr [7FF8A82A5290]
       int       3
; Total bytes of code 44
```
```assembly
; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       cmp       rbx,8
       jb        near ptr M07_L14
       cmp       rsi,rdi
       je        near ptr M07_L04
       cmp       rbx,20
       jae       near ptr M07_L06
       mov       rcx,7FF8A8291100
       call      CORINFO_HELP_COUNTPROFILE32
       cmp       rbx,10
       jae       short M07_L01
       mov       rcx,7FF8A8291118
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,7FF8A829111C
       call      CORINFO_HELP_COUNTPROFILE32
       add       rbx,0FFFFFFFFFFFFFFF8
       mov       rcx,[rsi]
       sub       rcx,[rdi]
       mov       rax,[rsi+rbx]
       sub       rax,[rdi+rbx]
       or        rcx,rax
       sete      bl
       movzx     ebx,bl
M07_L00:
       mov       rcx,7FF8A82910E4
       call      CORINFO_HELP_COUNTPROFILE32
       mov       eax,ebx
       vzeroupper
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M07_L01:
       xor       ebp,ebp
       add       rbx,0FFFFFFFFFFFFFFF0
       je        short M07_L03
       vmovups   xmm0,[rsi]
       vpcmpeqb  xmm0,xmm0,[rdi]
       vpmovmskb ecx,xmm0
       cmp       ecx,0FFFF
       jne       short M07_L05
M07_L02:
       add       rbp,10
       cmp       rbx,rbp
       ja        near ptr M07_L18
       mov       rcx,7FF8A8291104
       call      CORINFO_HELP_COUNTPROFILE32
M07_L03:
       vmovups   xmm0,[rsi+rbx]
       vpcmpeqb  xmm0,xmm0,[rdi+rbx]
       vpmovmskb ecx,xmm0
       cmp       ecx,0FFFF
       jne       near ptr M07_L10
       mov       rcx,7FF8A8291108
       call      CORINFO_HELP_COUNTPROFILE32
M07_L04:
       mov       rcx,7FF8A82910E8
       call      CORINFO_HELP_COUNTPROFILE32
       mov       eax,1
       vzeroupper
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M07_L05:
       mov       rcx,7FF8A8291114
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M07_L09
M07_L06:
       xor       ebp,ebp
       add       rbx,0FFFFFFFFFFFFFFE0
       je        near ptr M07_L12
       vmovups   ymm0,[rsi]
       vpcmpeqb  ymm0,ymm0,[rdi]
       vpmovmskb ecx,ymm0
       cmp       ecx,0FFFFFFFF
       jne       short M07_L08
M07_L07:
       add       rbp,20
       cmp       rbx,rbp
       jbe       short M07_L11
       mov       rcx,7FF8A82910F8
       call      CORINFO_HELP_COUNTPROFILE32
       vmovups   ymm0,[rsi+rbp]
       vpcmpeqb  ymm0,ymm0,[rdi+rbp]
       vpmovmskb ecx,ymm0
       cmp       ecx,0FFFFFFFF
       je        short M07_L07
M07_L08:
       mov       rcx,7FF8A82910FC
       call      CORINFO_HELP_COUNTPROFILE32
M07_L09:
       mov       rcx,7FF8A8291120
       call      CORINFO_HELP_COUNTPROFILE32
       xor       eax,eax
       vzeroupper
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M07_L10:
       mov       rcx,7FF8A829110C
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M07_L09
M07_L11:
       mov       rcx,7FF8A82910EC
       call      CORINFO_HELP_COUNTPROFILE32
M07_L12:
       vmovups   ymm0,[rsi+rbx]
       vpcmpeqb  ymm0,ymm0,[rdi+rbx]
       vpmovmskb ecx,ymm0
       cmp       ecx,0FFFFFFFF
       jne       short M07_L13
       mov       rcx,7FF8A82910F0
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M07_L04
M07_L13:
       mov       rcx,7FF8A82910F4
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M07_L09
M07_L14:
       cmp       rbx,4
       jb        short M07_L15
       mov       rcx,7FF8A82910E0
       call      CORINFO_HELP_COUNTPROFILE32
       lea       rcx,[rbx-4]
       mov       eax,[rsi]
       sub       eax,[rdi]
       mov       edx,[rsi+rcx]
       sub       edx,[rdi+rcx]
       or        eax,edx
       sete      bl
       movzx     ebx,bl
       jmp       near ptr M07_L00
M07_L15:
       xor       ebp,ebp
       mov       r14,rbx
       and       r14,2
       je        short M07_L16
       mov       rcx,7FF8A82910D8
       call      CORINFO_HELP_COUNTPROFILE32
       movzx     ebp,word ptr [rsi]
       movzx     ecx,word ptr [rdi]
       sub       ebp,ecx
M07_L16:
       test      bl,1
       je        short M07_L17
       mov       rcx,7FF8A82910DC
       call      CORINFO_HELP_COUNTPROFILE32
       movzx     ecx,byte ptr [rsi+r14]
       movzx     eax,byte ptr [rdi+r14]
       sub       ecx,eax
       or        ebp,ecx
M07_L17:
       test      ebp,ebp
       sete      bl
       movzx     ebx,bl
       jmp       near ptr M07_L00
M07_L18:
       mov       rcx,7FF8A8291110
       call      CORINFO_HELP_COUNTPROFILE32
       vmovups   xmm0,[rsi+rbp]
       vpcmpeqb  xmm0,xmm0,[rdi+rbp]
       vpmovmskb ecx,xmm0
       cmp       ecx,0FFFF
       jne       near ptr M07_L05
       jmp       near ptr M07_L02
; Total bytes of code 686
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
       je        near ptr M08_L20
M08_L00:
       mov       [rbp-3C],eax
M08_L01:
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
       jae       near ptr M08_L27
       mov       ecx,r9d
       lea       rbx,[r10+rcx*8+10]
       xor       esi,esi
       xor       edi,edi
       xor       ecx,ecx
       mov       [rbp-48],ecx
       cmp       byte ptr [rbp+40],0
       je        short M08_L02
       mov       rcx,[rbp-60]
       mov       ecx,[rcx+8]
       cmp       [rbp-40],ecx
       jae       near ptr M08_L13
       mov       rcx,[rbp-60]
       mov       edx,[rbp-40]
       mov       rcx,[rcx+rdx*8+10]
       lea       rdx,[rbp-48]
       call      qword ptr [7FF935BE1D58]; Precode of System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
M08_L02:
       mov       rcx,[rbp+18]
       mov       r8,[rbp+10]
       cmp       rcx,[r8+8]
       jne       near ptr M08_L05
       xor       r14d,r14d
       mov       r15,[rbx]
       test      r15,r15
       jne       near ptr M08_L08
M08_L03:
       mov       rcx,[r8]
       call      qword ptr [7FF935BE1558]
       mov       rcx,rax
       call      qword ptr [7FF935BE1288]; CORINFO_HELP_NEWFAST
       mov       r15,rax
       mov       r13,[rbx]
       lea       rcx,[r15+8]
       mov       rdx,[rbp+20]
       call      qword ptr [7FF935BE1260]; CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+10]
       mov       rdx,[rbp+30]
       call      qword ptr [7FF935BE1260]; CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+18]
       mov       rdx,r13
       call      qword ptr [7FF935BE1260]; CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rbp-3C]
       mov       [r15+20],ecx
       mov       rcx,rbx
       mov       rdx,r15
       call      qword ptr [7FF935BE1260]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+20]
       mov       eax,[rcx+8]
       cmp       [rbp-40],eax
       jae       near ptr M08_L13
       mov       eax,[rbp-40]
       lea       rcx,[rcx+rax*4+10]
       mov       eax,[rcx]
       add       eax,1
       jo        near ptr M08_L14
       mov       [rcx],eax
       mov       r8,[rbp+10]
       cmp       eax,[r8+10]
       jg        near ptr M08_L15
M08_L04:
       cmp       r14d,64
       jbe       near ptr M08_L17
       jmp       near ptr M08_L16
M08_L05:
       mov       rcx,[r8+8]
       mov       [rbp+18],rcx
       mov       rcx,[rbp-58]
       mov       r11,[rbp+18]
       cmp       rcx,[r11+8]
       je        near ptr M08_L23
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+8]
       mov       [rbp-58],rcx
       cmp       byte ptr [r8+19],0
       jne       short M08_L06
       mov       r8,[rbp+10]
       mov       rcx,[r8]
       call      qword ptr [7FF935BE18E8]
       mov       rcx,[rbp-58]
       mov       r11,rax
       mov       rdx,[rbp+20]
       call      qword ptr [rax]
       jmp       short M08_L07
M08_L06:
       mov       rcx,[rbp+20]
       lea       r11,[System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GetOrAdd[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.Func`3<System.__Canon,System.__Canon,System.__Canon>, System.__Canon)]
       cmp       [rcx],ecx
       call      qword ptr [r11]
M08_L07:
       mov       [rbp-3C],eax
       mov       r8,[rbp+10]
       jmp       near ptr M08_L23
M08_L08:
       mov       ecx,[rbp-3C]
       cmp       ecx,[r15+20]
       jne       short M08_L09
       mov       rcx,[r8]
       call      qword ptr [7FF935BE1500]
       mov       rcx,rax
       call      qword ptr [7FF935BE1AE8]
       mov       rdx,[r15+8]
       mov       rcx,[rbp-58]
       mov       r11,rax
       mov       r8,[rbp+20]
       call      qword ptr [rax]
       test      eax,eax
       mov       r8,[rbp+10]
       jne       short M08_L10
M08_L09:
       inc       r14d
       mov       r15,[r15+18]
       test      r15,r15
       jne       short M08_L08
       jmp       near ptr M08_L03
M08_L10:
       cmp       byte ptr [rbp+38],0
       je        short M08_L11
       lea       rcx,[r15+10]
       mov       rdx,[rbp+30]
       call      qword ptr [7FF935BE1260]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+48]
       mov       rdx,[rbp+30]
       call      qword ptr [7FF935BE1268]; CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       short M08_L12
M08_L11:
       mov       rdx,[r15+10]
       mov       rcx,[rbp+48]
       call      qword ptr [7FF935BE1268]; CORINFO_HELP_CHECKED_ASSIGN_REF
M08_L12:
       xor       ecx,ecx
       mov       [rbp-4C],ecx
       jmp       near ptr M08_L24
M08_L13:
       call      qword ptr [7FF935BE1258]
       int       3
M08_L14:
       call      qword ptr [7FF935BE1250]
       int       3
M08_L15:
       mov       esi,1
       jmp       near ptr M08_L04
M08_L16:
       mov       rcx,[rbp-58]
       call      qword ptr [7FF935BE1C10]
       mov       ecx,1
       test      rax,rax
       cmovne    edi,ecx
M08_L17:
       mov       r8,[rbp+10]
       cmp       byte ptr [rbp-48],0
       je        short M08_L18
       mov       rcx,[rbp-60]
       mov       ecx,[rcx+8]
       cmp       [rbp-40],ecx
       jae       near ptr M08_L27
       mov       rcx,[rbp-60]
       mov       eax,[rbp-40]
       mov       rcx,[rcx+rax*8+10]
       call      qword ptr [7FF935BE1D60]; Precode of System.Threading.Monitor.Exit(System.Object)
       mov       r8,[rbp+10]
M08_L18:
       mov       ecx,esi
       or        ecx,edi
       jne       short M08_L25
M08_L19:
       mov       rcx,[rbp+48]
       mov       rdx,[rbp+30]
       call      qword ptr [7FF935BE1268]; CORINFO_HELP_CHECKED_ASSIGN_REF
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
M08_L20:
       cmp       byte ptr [rcx+19],0
       jne       short M08_L21
       mov       rcx,[rbp+10]
       mov       rcx,[rcx]
       call      qword ptr [7FF935BE18E8]
       mov       rcx,[rbp-58]
       mov       r11,rax
       mov       rdx,[rbp+20]
       call      qword ptr [rax]
       jmp       short M08_L22
M08_L21:
       mov       rcx,[rbp+20]
       lea       r11,[System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GetOrAdd[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.Func`3<System.__Canon,System.__Canon,System.__Canon>, System.__Canon)]
       cmp       [rcx],ecx
       call      qword ptr [r11]
M08_L22:
       mov       rcx,[rbp+10]
       jmp       near ptr M08_L00
M08_L23:
       call      M08_L28
       jmp       near ptr M08_L01
M08_L24:
       call      M08_L28
       jmp       short M08_L26
M08_L25:
       mov       rcx,r8
       mov       rdx,[rbp+18]
       mov       r8d,esi
       mov       r9d,edi
       call      qword ptr [7FF935BE2430]
       jmp       near ptr M08_L19
M08_L26:
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
M08_L27:
       call      qword ptr [7FF935BE1258]
       int       3
M08_L28:
       sub       rsp,28
       cmp       byte ptr [rbp-48],0
       je        short M08_L29
       mov       rcx,[rbp-60]
       mov       ecx,[rcx+8]
       cmp       [rbp-40],ecx
       jae       short M08_L30
       mov       rcx,[rbp-60]
       mov       eax,[rbp-40]
       mov       rcx,[rcx+rax*8+10]
       call      qword ptr [7FF935BE1D60]; Precode of System.Threading.Monitor.Exit(System.Object)
M08_L29:
       nop
       add       rsp,28
       ret
M08_L30:
       call      qword ptr [7FF935BE1258]
       int       3
; Total bytes of code 950
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
; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,[rsi+18]
       mov       rcx,rdi
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FF8D757EA60]; Precode of System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       jne       short M10_L01
       cmp       qword ptr [rdi+10],0
       je        short M10_L00
       mov       rcx,rsi
       mov       rdx,rbx
       lea       rax,[System.Text.StringBuilder.AppendFormat[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.IFormatProvider, System.Text.CompositeFormat, System.__Canon, System.__Canon, System.__Canon, System.ReadOnlySpan`1<System.Object>)]
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax]
M10_L00:
       xor       eax,eax
       mov       [rbx],rax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M10_L01:
       mov       eax,1
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 91
```
```assembly
; System.Text.StringBuilder.set_Length(Int32)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       test      esi,esi
       jl        short M11_L01
       cmp       esi,[rbx+20]
       jg        short M11_L02
       test      esi,esi
       jne       near ptr M11_L03
       cmp       qword ptr [rbx+10],0
       jne       short M11_L03
       xor       ecx,ecx
       mov       [rbx+18],rcx
M11_L00:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M11_L01:
       mov       ecx,3AD
       mov       rdx,7FF8A7B44000
       call      qword ptr [7FF8A7E27798]
       mov       rdx,rax
       mov       ecx,esi
       call      qword ptr [7FF8A82A4E40]
       int       3
M11_L02:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FF8A7B44000
       call      qword ptr [7FF8A7E27798]
       mov       rsi,rax
       call      qword ptr [7FF8A82A5890]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF8A7E2D9C8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M11_L03:
       mov       ecx,[rbx+1C]
       add       ecx,[rbx+18]
       mov       r8d,esi
       sub       r8d,ecx
       test      r8d,r8d
       jle       short M11_L04
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF8A82A5B30]
       jmp       near ptr M11_L00
M11_L04:
       mov       rcx,rbx
       mov       edx,esi
       call      qword ptr [7FF8A82A5B48]
       mov       rdi,rax
       cmp       rdi,rbx
       je        near ptr M11_L09
       mov       rax,[rbx+8]
       mov       ecx,[rax+8]
       add       ecx,[rbx+1C]
       mov       eax,[rbx+1C]
       add       eax,[rbx+18]
       lea       edx,[rax+rax*2]
       add       edx,edx
       mov       r8d,66666667
       mov       eax,r8d
       imul      edx
       mov       eax,edx
       shr       eax,1F
       sar       edx,1
       add       edx,eax
       mov       rax,[rbx+8]
       mov       eax,[rax+8]
       cmp       edx,eax
       cmovl     edx,eax
       cmp       ecx,edx
       cmovg     ecx,edx
       sub       ecx,[rdi+1C]
       mov       rdx,[rdi+8]
       cmp       [rdx+8],ecx
       jge       short M11_L07
       cmp       ecx,400
       jge       short M11_L05
       movsxd    rdx,ecx
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbp,rax
       jmp       short M11_L06
M11_L05:
       xor       edx,edx
       call      qword ptr [7FF8A818F078]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       rbp,rax
M11_L06:
       mov       rcx,[rdi+8]
       mov       r8d,[rdi+18]
       mov       rdx,rbp
       call      qword ptr [7FF8A7D75050]; System.Array.Copy(System.Array, System.Array, Int32)
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M11_L08
M11_L07:
       mov       rdx,[rdi+8]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
M11_L08:
       mov       rdx,[rdi+10]
       lea       rcx,[rbx+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rdi+1C]
       mov       [rbx+1C],ecx
M11_L09:
       sub       esi,[rdi+1C]
       mov       [rbx+18],esi
       jmp       near ptr M11_L00
; Total bytes of code 399
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderBenchmark.FormatInvariant()
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
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-70],ymm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       xor       eax,eax
       mov       [rbp-40],rax
       mov       [rbp+10],rcx
       mov       rbx,[rcx+198]
       test      rbx,rbx
       je        near ptr M00_L28
       cmp       dword ptr [rbx+8],0
       je        near ptr M00_L28
       mov       r8,174CF8001B0
       mov       rsi,[r8]
       mov       r8,[rsi+20]
       mov       [rbp-40],r8
       cmp       qword ptr [rbp-40],0
       je        near ptr M00_L30
       lea       r8,[rsi+20]
       mov       rdx,[rbp-40]
       test      r8,r8
       je        near ptr M00_L29
       mov       rcx,r8
       mov       r8,rdx
       xor       edx,edx
       call      00007FF907846040
       cmp       rax,[rbp-40]
       jne       near ptr M00_L30
M00_L00:
       mov       rdx,[rbp-40]
M00_L01:
       xor       ecx,ecx
       mov       [rbp-40],rcx
       mov       [rbp-68],rdx
       mov       rcx,174B9800100
       mov       rsi,[rcx]
       mov       rcx,174CF8001C8
       mov       rdi,[rcx]
       mov       rcx,174CF8001B8
       mov       r14,[rcx]
       test      rdi,rdi
       je        near ptr M00_L11
M00_L02:
       mov       r15,[r14+8]
       mov       rcx,[r15+8]
       cmp       byte ptr [r14+19],0
       je        near ptr M00_L12
       mov       rcx,1B54E7F0AAC
       mov       edx,99F99FE
       mov       r11d,572123F0
       mov       eax,7
M00_L03:
       add       edx,[rcx]
       mov       r8d,[rcx+4]
       xor       r11d,edx
       rol       edx,14
       add       edx,r11d
       rol       r11d,9
       xor       r11d,edx
       rol       edx,1B
       add       edx,r11d
       rol       r11d,13
       add       r8d,edx
       mov       edx,r11d
       xor       edx,r8d
       rol       r8d,14
       add       r8d,edx
       rol       edx,9
       xor       edx,r8d
       rol       r8d,1B
       add       r8d,edx
       rol       edx,13
       mov       r11d,r8d
       add       rcx,8
       dec       eax
       mov       r8d,edx
       mov       edx,r11d
       mov       r11d,r8d
       jne       short M00_L03
       add       edx,[rcx]
       xor       r11d,edx
       rol       edx,14
       add       edx,r11d
       rol       r11d,9
       xor       r11d,edx
       rol       edx,1B
       add       edx,r11d
       rol       r11d,13
       mov       ecx,[rcx+2]
       shr       ecx,8
       or        ecx,80000000
       shr       ecx,8
       add       ecx,edx
       mov       edx,r11d
       xor       edx,ecx
       rol       ecx,14
       add       ecx,edx
       rol       edx,9
       xor       edx,ecx
       rol       ecx,1B
       add       ecx,edx
       rol       edx,13
       xor       edx,ecx
       mov       r13d,ecx
       rol       r13d,14
       add       r13d,edx
       rol       edx,9
       xor       edx,r13d
       rol       r13d,1B
       add       r13d,edx
       mov       r12d,edx
       rol       r12d,13
       xor       r13d,r12d
M00_L04:
       mov       r12,[r15+8]
       mov       r8,[r15+10]
       mov       edx,r13d
       imul      rdx,[r15+28]
       shr       rdx,20
       inc       rdx
       mov       ecx,[r8+8]
       imul      rdx,rcx
       shr       rdx,20
       cmp       edx,[r8+8]
       jae       near ptr M00_L25
       mov       edx,edx
       mov       rax,[r8+rdx*8+10]
       test      rax,rax
       je        near ptr M00_L23
       test      r12,r12
       je        near ptr M00_L09
       mov       r8,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer+OrdinalComparer
       cmp       [r12],r8
       jne       near ptr M00_L09
M00_L05:
       cmp       r13d,[rax+20]
       jne       near ptr M00_L13
       mov       [rbp-78],rax
       mov       rdx,[rax+8]
       mov       r8,1B54E7F0AA0
       cmp       rdx,r8
       jne       near ptr M00_L14
       mov       r12d,1
M00_L06:
       test      r12d,r12d
       je        near ptr M00_L17
M00_L07:
       mov       rax,[rbp-78]
       mov       rdx,[rax+10]
       mov       [rbp-48],rdx
M00_L08:
       mov       r8,[rbp-48]
       xor       r9d,r9d
       mov       [rbp-48],r9
       mov       rdx,[rbp-68]
       cmp       [rdx],dl
       test      r8,r8
       je        near ptr M00_L24
       lea       r9,[rbx+10]
       mov       ecx,[rbx+8]
       mov       [rbp-60],r9
       mov       [rbp-58],ecx
       lea       r9,[rbp-60]
       mov       rdx,rsi
       mov       rcx,[rbp-68]
       call      qword ptr [7FF8A823E610]; System.Text.StringBuilder.AppendFormat(System.IFormatProvider, System.Text.CompositeFormat, System.ReadOnlySpan`1<System.Object>)
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF8A7E02200]; System.Text.StringBuilder.ToString()
       mov       [rbp-70],rax
       jmp       near ptr M00_L26
M00_L09:
       cmp       r13d,[rax+20]
       jne       near ptr M00_L22
       mov       [rbp-78],rax
       mov       rdx,[rax+8]
       mov       r8,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer+OrdinalComparer
       cmp       [r12],r8
       jne       near ptr M00_L18
       mov       r8,1B54E7F0AA0
       cmp       rdx,r8
       jne       near ptr M00_L19
       mov       r10d,1
M00_L10:
       test      r10d,r10d
       je        near ptr M00_L21
       jmp       near ptr M00_L07
M00_L11:
       mov       rcx,offset MT_System.Func<System.String, System.Text.CompositeFormat>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,174CF8001C0
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Core.ResourceFormatCache+<>c.<GetOrAdd>b__1_0(System.String)
       call      qword ptr [7FF8A7C16BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,174CF8001C8
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L02
M00_L12:
       mov       rdx,1B54E7F0AA0
       mov       r11,7FF8A7B60AB8
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       near ptr M00_L04
M00_L13:
       mov       [rbp-78],rax
       jmp       short M00_L17
M00_L14:
       test      rdx,rdx
       je        short M00_L15
       cmp       dword ptr [rdx+8],1F
       je        short M00_L16
M00_L15:
       xor       r12d,r12d
       jmp       near ptr M00_L06
M00_L16:
       lea       rcx,[rdx+0C]
       mov       r8d,[rdx+8]
       add       r8d,r8d
       mov       rdx,1B54E7F0AAC
       call      qword ptr [7FF8A7C1FBB8]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r12d,eax
       jmp       near ptr M00_L06
M00_L17:
       mov       rax,[rbp-78]
       mov       rax,[rax+18]
       test      rax,rax
       jne       near ptr M00_L05
       jmp       short M00_L23
M00_L18:
       mov       rcx,r12
       mov       r8,1B54E7F0AA0
       mov       r11,7FF8A7B60AC0
       call      qword ptr [r11]
       mov       r10d,eax
       jmp       near ptr M00_L10
M00_L19:
       test      rdx,rdx
       je        short M00_L20
       cmp       dword ptr [rdx+8],1F
       jne       short M00_L20
       lea       rcx,[rdx+0C]
       mov       r8d,[rdx+8]
       add       r8d,r8d
       mov       rdx,1B54E7F0AAC
       call      qword ptr [7FF8A7C1FBB8]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r10d,eax
       jmp       near ptr M00_L10
M00_L20:
       xor       ecx,ecx
       mov       r10d,ecx
       jmp       near ptr M00_L10
M00_L21:
       mov       rax,[rbp-78]
M00_L22:
       mov       rax,[rax+18]
       test      rax,rax
       jne       near ptr M00_L09
M00_L23:
       xor       edx,edx
       mov       [rbp-48],rdx
       mov       rdx,1B54E7F0AA0
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       xor       r9d,r9d
       mov       [rsp+28],r9d
       mov       dword ptr [rsp+30],1
       lea       r9,[rbp-48]
       mov       [rsp+38],r9
       mov       [rsp+20],rax
       mov       r9d,r13d
       shl       r9,20
       or        r9,1
       mov       rdx,r15
       mov       r8,1B54E7F0AA0
       mov       rcx,r14
       call      qword ptr [7FF8A7F9C6D8]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryAddInternal(Tables<System.__Canon,System.__Canon>, System.__Canon, System.Nullable`1<Int32>, System.__Canon, Boolean, Boolean, System.__Canon ByRef)
       jmp       near ptr M00_L08
M00_L24:
       mov       ecx,3B9
       mov       rdx,7FF8A7B54000
       call      qword ptr [7FF8A7E37798]
       mov       rcx,rax
       call      qword ptr [7FF8A82B4E88]
       int       3
M00_L25:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L26:
       call      M00_L32
       nop
       mov       rax,[rbp-70]
M00_L27:
       mov       [rbp-50],rax
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+88]
       lea       r8,[rbp-50]
       mov       rdx,7FF8A829D150
       cmp       [rcx],ecx
       call      qword ptr [7FF8A823E718]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
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
M00_L28:
       mov       rax,1B54E7E0008
       jmp       short M00_L27
M00_L29:
       call      qword ptr [7FF8A82B56C8]
       int       3
M00_L30:
       mov       rcx,[rsi+18]
       lea       rdx,[rbp-40]
       cmp       [rcx],ecx
       call      qword ptr [7FF8A82354D0]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M00_L31
       add       rsi,2C
       lock dec  dword ptr [rsi]
       jmp       near ptr M00_L00
M00_L31:
       mov       rax,[rsi+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       rdx,rax
       jmp       near ptr M00_L01
M00_L32:
       sub       rsp,48
       mov       rdx,[rbp-68]
       cmp       [rdx],dl
       mov       rcx,rdx
       xor       edx,edx
       call      qword ptr [7FF8A8235620]; System.Text.StringBuilder.set_Length(Int32)
       mov       rdx,174CF8001B0
       mov       rbx,[rdx]
       mov       rax,[rbx+10]
       mov       rdx,[rbp-68]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       test      eax,eax
       jne       short M00_L34
M00_L33:
       add       rsp,48
       ret
M00_L34:
       cmp       qword ptr [rbx+20],0
       jne       short M00_L36
       lea       rcx,[rbx+20]
       test      rcx,rcx
       jne       short M00_L35
       call      qword ptr [7FF8A82B56C8]
       int       3
M00_L35:
       mov       rdx,[rbp-68]
       xor       r8d,r8d
       call      00007FF907846040
       test      rax,rax
       je        short M00_L33
M00_L36:
       lea       rcx,[rbx+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[rbx+28]
       jg        short M00_L37
       mov       rbx,[rbx+18]
       mov       rcx,[rbx+10]
       mov       rdx,[rbp-68]
       cmp       [rcx],ecx
       call      qword ptr [7FF8A82B5CB0]
       test      eax,eax
       jne       short M00_L33
       mov       rcx,rbx
       mov       rdx,[rbp-68]
       call      qword ptr [7FF8A82B5CC8]
       jmp       short M00_L33
M00_L37:
       add       rbx,2C
       lock dec  dword ptr [rbx]
       jmp       short M00_L33
; Total bytes of code 1473
```
```assembly
; System.Text.StringBuilder.AppendFormat(System.IFormatProvider, System.Text.CompositeFormat, System.ReadOnlySpan`1<System.Object>)
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,50
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-20],rax
       mov       rax,r8
M01_L00:
       mov       rbx,[r9]
       mov       esi,[r9+8]
       test      rax,rax
       je        short M01_L02
       cmp       esi,[rax+20]
       jl        near ptr M01_L03
       cmp       esi,2
       jbe       near ptr M01_L04
       test      esi,esi
       je        near ptr M01_L05
       mov       r8,[rbx]
       cmp       esi,1
       jbe       near ptr M01_L05
       mov       r9,[rbx+8]
       cmp       esi,2
       jbe       near ptr M01_L05
       mov       r10,[rbx+10]
       mov       [rbp-20],rbx
       mov       [rbp-18],esi
       lea       r11,[rbp-20]
       mov       [rsp+38],r11
       mov       [rsp+20],r8
       mov       [rsp+28],r9
       mov       [rsp+30],r10
       mov       r8,rdx
       mov       r9,rax
       mov       rdx,7FF8A829C788
       call      qword ptr [7FF8A823E628]; System.Text.StringBuilder.AppendFormat[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.IFormatProvider, System.Text.CompositeFormat, System.__Canon, System.__Canon, System.__Canon, System.ReadOnlySpan`1<System.Object>)
M01_L01:
       nop
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M01_L02:
       mov       ecx,3B9
       mov       rdx,7FF8A7B54000
       call      qword ptr [7FF8A7E37798]
       mov       rcx,rax
       call      qword ptr [7FF8A82B4E88]
       int       3
M01_L03:
       call      qword ptr [7FF8A82B5BC0]
       int       3
M01_L04:
       mov       r9d,esi
       lea       r8,[7FF8A8313AF8]
       mov       r8d,[r8+r9*4]
       lea       r10,[M01_L00]
       add       r8,r10
       jmp       r8
       xor       r8d,r8d
       mov       [rsp+20],r8d
       mov       [rsp+28],r8d
       mov       [rbp-20],rbx
       mov       [rbp-18],r8d
       lea       r8,[rbp-20]
       mov       [rsp+30],r8
       mov       r8,rax
       xor       r9d,r9d
       call      qword ptr [7FF8A82B5BA8]
       jmp       short M01_L01
       mov       r8,[rbx]
       xor       r9d,r9d
       mov       [rsp+28],r9d
       mov       [rsp+30],r9d
       mov       [rbp-20],rbx
       mov       dword ptr [rbp-18],1
       lea       r9,[rbp-20]
       mov       [rsp+38],r9
       mov       [rsp+20],r8
       mov       r8,rdx
       mov       r9,rax
       mov       rdx,7FF8A829C9F8
       call      qword ptr [7FF8A823E688]
       jmp       near ptr M01_L01
       mov       r9,[rbx]
       mov       r8,[rbx+8]
       xor       r10d,r10d
       mov       [rsp+30],r10d
       mov       [rbp-20],rbx
       mov       dword ptr [rbp-18],2
       lea       r10,[rbp-20]
       mov       [rsp+38],r10
       mov       [rsp+20],r9
       mov       [rsp+28],r8
       mov       r9,rax
       mov       r8,rdx
       mov       rdx,7FF8A829C8C0
       call      qword ptr [7FF8A823E658]
       jmp       near ptr M01_L01
M01_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 405
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       edx,[rbx+1C]
       add       edx,[rbx+18]
       je        short M02_L02
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FF9078A50F0
       mov       rsi,rax
M02_L00:
       mov       r8d,[rbx+18]
       test      r8d,r8d
       jle       short M02_L01
       mov       rdx,[rbx+8]
       mov       ecx,[rbx+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rsi+8]
       ja        short M02_L03
       cmp       [rdx+8],r8d
       jb        short M02_L03
       movsxd    rcx,ecx
       lea       rcx,[rsi+rcx*2+0C]
       movsxd    r8,r8d
       add       r8,r8
       add       rdx,10
       call      qword ptr [7FF8A7C15818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L01:
       mov       rbx,[rbx+10]
       test      rbx,rbx
       jne       short M02_L00
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L02:
       mov       rax,1B54E7E0008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,19655
       mov       rdx,7FF8A7B54000
       call      qword ptr [7FF8A7E37798]
       mov       rbx,rax
       call      qword ptr [7FF8A82B56E0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF8A7E3D9C8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 201
```
```assembly
; DotNetTips.Spargine.Core.ResourceFormatCache+<>c.<GetOrAdd>b__1_0(System.String)
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
; 		return _cache.GetOrAdd(format, static value => CompositeFormat.Parse(value));
; 		                                               ^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,[rbp+18]
       call      qword ptr [7FF8A8025320]; System.Text.CompositeFormat.Parse(System.String)
       nop
       add       rsp,20
       pop       rbp
       ret
; Total bytes of code 35
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M04_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L00:
       call      qword ptr [7FF8A82B52A8]
       int       3
; Total bytes of code 44
```
```assembly
; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       cmp       rbx,8
       jb        near ptr M05_L14
       cmp       rsi,rdi
       je        near ptr M05_L04
       cmp       rbx,20
       jae       near ptr M05_L06
       mov       rcx,7FF8A82A1100
       call      CORINFO_HELP_COUNTPROFILE32
       cmp       rbx,10
       jae       short M05_L01
       mov       rcx,7FF8A82A1118
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,7FF8A82A111C
       call      CORINFO_HELP_COUNTPROFILE32
       add       rbx,0FFFFFFFFFFFFFFF8
       mov       rcx,[rsi]
       sub       rcx,[rdi]
       mov       rax,[rsi+rbx]
       sub       rax,[rdi+rbx]
       or        rcx,rax
       sete      bl
       movzx     ebx,bl
M05_L00:
       mov       rcx,7FF8A82A10E4
       call      CORINFO_HELP_COUNTPROFILE32
       mov       eax,ebx
       vzeroupper
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M05_L01:
       xor       ebp,ebp
       add       rbx,0FFFFFFFFFFFFFFF0
       je        short M05_L03
       vmovups   xmm0,[rsi]
       vpcmpeqb  xmm0,xmm0,[rdi]
       vpmovmskb ecx,xmm0
       cmp       ecx,0FFFF
       jne       short M05_L05
M05_L02:
       add       rbp,10
       cmp       rbx,rbp
       ja        near ptr M05_L18
       mov       rcx,7FF8A82A1104
       call      CORINFO_HELP_COUNTPROFILE32
M05_L03:
       vmovups   xmm0,[rsi+rbx]
       vpcmpeqb  xmm0,xmm0,[rdi+rbx]
       vpmovmskb ecx,xmm0
       cmp       ecx,0FFFF
       jne       near ptr M05_L10
       mov       rcx,7FF8A82A1108
       call      CORINFO_HELP_COUNTPROFILE32
M05_L04:
       mov       rcx,7FF8A82A10E8
       call      CORINFO_HELP_COUNTPROFILE32
       mov       eax,1
       vzeroupper
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M05_L05:
       mov       rcx,7FF8A82A1114
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M05_L09
M05_L06:
       xor       ebp,ebp
       add       rbx,0FFFFFFFFFFFFFFE0
       je        near ptr M05_L12
       vmovups   ymm0,[rsi]
       vpcmpeqb  ymm0,ymm0,[rdi]
       vpmovmskb ecx,ymm0
       cmp       ecx,0FFFFFFFF
       jne       short M05_L08
M05_L07:
       add       rbp,20
       cmp       rbx,rbp
       jbe       short M05_L11
       mov       rcx,7FF8A82A10F8
       call      CORINFO_HELP_COUNTPROFILE32
       vmovups   ymm0,[rsi+rbp]
       vpcmpeqb  ymm0,ymm0,[rdi+rbp]
       vpmovmskb ecx,ymm0
       cmp       ecx,0FFFFFFFF
       je        short M05_L07
M05_L08:
       mov       rcx,7FF8A82A10FC
       call      CORINFO_HELP_COUNTPROFILE32
M05_L09:
       mov       rcx,7FF8A82A1120
       call      CORINFO_HELP_COUNTPROFILE32
       xor       eax,eax
       vzeroupper
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M05_L10:
       mov       rcx,7FF8A82A110C
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M05_L09
M05_L11:
       mov       rcx,7FF8A82A10EC
       call      CORINFO_HELP_COUNTPROFILE32
M05_L12:
       vmovups   ymm0,[rsi+rbx]
       vpcmpeqb  ymm0,ymm0,[rdi+rbx]
       vpmovmskb ecx,ymm0
       cmp       ecx,0FFFFFFFF
       jne       short M05_L13
       mov       rcx,7FF8A82A10F0
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M05_L04
M05_L13:
       mov       rcx,7FF8A82A10F4
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M05_L09
M05_L14:
       cmp       rbx,4
       jb        short M05_L15
       mov       rcx,7FF8A82A10E0
       call      CORINFO_HELP_COUNTPROFILE32
       lea       rcx,[rbx-4]
       mov       eax,[rsi]
       sub       eax,[rdi]
       mov       edx,[rsi+rcx]
       sub       edx,[rdi+rcx]
       or        eax,edx
       sete      bl
       movzx     ebx,bl
       jmp       near ptr M05_L00
M05_L15:
       xor       ebp,ebp
       mov       r14,rbx
       and       r14,2
       je        short M05_L16
       mov       rcx,7FF8A82A10D8
       call      CORINFO_HELP_COUNTPROFILE32
       movzx     ebp,word ptr [rsi]
       movzx     ecx,word ptr [rdi]
       sub       ebp,ecx
M05_L16:
       test      bl,1
       je        short M05_L17
       mov       rcx,7FF8A82A10DC
       call      CORINFO_HELP_COUNTPROFILE32
       movzx     ecx,byte ptr [rsi+r14]
       movzx     eax,byte ptr [rdi+r14]
       sub       ecx,eax
       or        ebp,ecx
M05_L17:
       test      ebp,ebp
       sete      bl
       movzx     ebx,bl
       jmp       near ptr M05_L00
M05_L18:
       mov       rcx,7FF8A82A1110
       call      CORINFO_HELP_COUNTPROFILE32
       vmovups   xmm0,[rsi+rbp]
       vpcmpeqb  xmm0,xmm0,[rdi+rbp]
       vpmovmskb ecx,xmm0
       cmp       ecx,0FFFF
       jne       near ptr M05_L05
       jmp       near ptr M05_L02
; Total bytes of code 686
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
       je        near ptr M06_L20
M06_L00:
       mov       [rbp-3C],eax
M06_L01:
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
       jae       near ptr M06_L27
       mov       ecx,r9d
       lea       rbx,[r10+rcx*8+10]
       xor       esi,esi
       xor       edi,edi
       xor       ecx,ecx
       mov       [rbp-48],ecx
       cmp       byte ptr [rbp+40],0
       je        short M06_L02
       mov       rcx,[rbp-60]
       mov       ecx,[rcx+8]
       cmp       [rbp-40],ecx
       jae       near ptr M06_L13
       mov       rcx,[rbp-60]
       mov       edx,[rbp-40]
       mov       rcx,[rcx+rdx*8+10]
       lea       rdx,[rbp-48]
       call      qword ptr [7FF935BE1D58]; Precode of System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
M06_L02:
       mov       rcx,[rbp+18]
       mov       r8,[rbp+10]
       cmp       rcx,[r8+8]
       jne       near ptr M06_L05
       xor       r14d,r14d
       mov       r15,[rbx]
       test      r15,r15
       jne       near ptr M06_L08
M06_L03:
       mov       rcx,[r8]
       call      qword ptr [7FF935BE1558]
       mov       rcx,rax
       call      qword ptr [7FF935BE1288]; CORINFO_HELP_NEWFAST
       mov       r15,rax
       mov       r13,[rbx]
       lea       rcx,[r15+8]
       mov       rdx,[rbp+20]
       call      qword ptr [7FF935BE1260]; CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+10]
       mov       rdx,[rbp+30]
       call      qword ptr [7FF935BE1260]; CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+18]
       mov       rdx,r13
       call      qword ptr [7FF935BE1260]; CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rbp-3C]
       mov       [r15+20],ecx
       mov       rcx,rbx
       mov       rdx,r15
       call      qword ptr [7FF935BE1260]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+20]
       mov       eax,[rcx+8]
       cmp       [rbp-40],eax
       jae       near ptr M06_L13
       mov       eax,[rbp-40]
       lea       rcx,[rcx+rax*4+10]
       mov       eax,[rcx]
       add       eax,1
       jo        near ptr M06_L14
       mov       [rcx],eax
       mov       r8,[rbp+10]
       cmp       eax,[r8+10]
       jg        near ptr M06_L15
M06_L04:
       cmp       r14d,64
       jbe       near ptr M06_L17
       jmp       near ptr M06_L16
M06_L05:
       mov       rcx,[r8+8]
       mov       [rbp+18],rcx
       mov       rcx,[rbp-58]
       mov       r11,[rbp+18]
       cmp       rcx,[r11+8]
       je        near ptr M06_L23
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+8]
       mov       [rbp-58],rcx
       cmp       byte ptr [r8+19],0
       jne       short M06_L06
       mov       r8,[rbp+10]
       mov       rcx,[r8]
       call      qword ptr [7FF935BE18E8]
       mov       rcx,[rbp-58]
       mov       r11,rax
       mov       rdx,[rbp+20]
       call      qword ptr [rax]
       jmp       short M06_L07
M06_L06:
       mov       rcx,[rbp+20]
       lea       r11,[System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GetOrAdd[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.Func`3<System.__Canon,System.__Canon,System.__Canon>, System.__Canon)]
       cmp       [rcx],ecx
       call      qword ptr [r11]
M06_L07:
       mov       [rbp-3C],eax
       mov       r8,[rbp+10]
       jmp       near ptr M06_L23
M06_L08:
       mov       ecx,[rbp-3C]
       cmp       ecx,[r15+20]
       jne       short M06_L09
       mov       rcx,[r8]
       call      qword ptr [7FF935BE1500]
       mov       rcx,rax
       call      qword ptr [7FF935BE1AE8]
       mov       rdx,[r15+8]
       mov       rcx,[rbp-58]
       mov       r11,rax
       mov       r8,[rbp+20]
       call      qword ptr [rax]
       test      eax,eax
       mov       r8,[rbp+10]
       jne       short M06_L10
M06_L09:
       inc       r14d
       mov       r15,[r15+18]
       test      r15,r15
       jne       short M06_L08
       jmp       near ptr M06_L03
M06_L10:
       cmp       byte ptr [rbp+38],0
       je        short M06_L11
       lea       rcx,[r15+10]
       mov       rdx,[rbp+30]
       call      qword ptr [7FF935BE1260]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+48]
       mov       rdx,[rbp+30]
       call      qword ptr [7FF935BE1268]; CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       short M06_L12
M06_L11:
       mov       rdx,[r15+10]
       mov       rcx,[rbp+48]
       call      qword ptr [7FF935BE1268]; CORINFO_HELP_CHECKED_ASSIGN_REF
M06_L12:
       xor       ecx,ecx
       mov       [rbp-4C],ecx
       jmp       near ptr M06_L24
M06_L13:
       call      qword ptr [7FF935BE1258]
       int       3
M06_L14:
       call      qword ptr [7FF935BE1250]
       int       3
M06_L15:
       mov       esi,1
       jmp       near ptr M06_L04
M06_L16:
       mov       rcx,[rbp-58]
       call      qword ptr [7FF935BE1C10]
       mov       ecx,1
       test      rax,rax
       cmovne    edi,ecx
M06_L17:
       mov       r8,[rbp+10]
       cmp       byte ptr [rbp-48],0
       je        short M06_L18
       mov       rcx,[rbp-60]
       mov       ecx,[rcx+8]
       cmp       [rbp-40],ecx
       jae       near ptr M06_L27
       mov       rcx,[rbp-60]
       mov       eax,[rbp-40]
       mov       rcx,[rcx+rax*8+10]
       call      qword ptr [7FF935BE1D60]; Precode of System.Threading.Monitor.Exit(System.Object)
       mov       r8,[rbp+10]
M06_L18:
       mov       ecx,esi
       or        ecx,edi
       jne       short M06_L25
M06_L19:
       mov       rcx,[rbp+48]
       mov       rdx,[rbp+30]
       call      qword ptr [7FF935BE1268]; CORINFO_HELP_CHECKED_ASSIGN_REF
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
M06_L20:
       cmp       byte ptr [rcx+19],0
       jne       short M06_L21
       mov       rcx,[rbp+10]
       mov       rcx,[rcx]
       call      qword ptr [7FF935BE18E8]
       mov       rcx,[rbp-58]
       mov       r11,rax
       mov       rdx,[rbp+20]
       call      qword ptr [rax]
       jmp       short M06_L22
M06_L21:
       mov       rcx,[rbp+20]
       lea       r11,[System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GetOrAdd[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.Func`3<System.__Canon,System.__Canon,System.__Canon>, System.__Canon)]
       cmp       [rcx],ecx
       call      qword ptr [r11]
M06_L22:
       mov       rcx,[rbp+10]
       jmp       near ptr M06_L00
M06_L23:
       call      M06_L28
       jmp       near ptr M06_L01
M06_L24:
       call      M06_L28
       jmp       short M06_L26
M06_L25:
       mov       rcx,r8
       mov       rdx,[rbp+18]
       mov       r8d,esi
       mov       r9d,edi
       call      qword ptr [7FF935BE2430]
       jmp       near ptr M06_L19
M06_L26:
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
M06_L27:
       call      qword ptr [7FF935BE1258]
       int       3
M06_L28:
       sub       rsp,28
       cmp       byte ptr [rbp-48],0
       je        short M06_L29
       mov       rcx,[rbp-60]
       mov       ecx,[rcx+8]
       cmp       [rbp-40],ecx
       jae       short M06_L30
       mov       rcx,[rbp-60]
       mov       eax,[rbp-40]
       mov       rcx,[rcx+rax*8+10]
       call      qword ptr [7FF935BE1D60]; Precode of System.Threading.Monitor.Exit(System.Object)
M06_L29:
       nop
       add       rsp,28
       ret
M06_L30:
       call      qword ptr [7FF935BE1258]
       int       3
; Total bytes of code 950
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
; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,[rsi+18]
       mov       rcx,rdi
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FF8D757EA60]; Precode of System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       jne       short M08_L01
       cmp       qword ptr [rdi+10],0
       je        short M08_L00
       mov       rcx,rsi
       mov       rdx,rbx
       lea       rax,[System.Text.StringBuilder.AppendFormat[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.IFormatProvider, System.Text.CompositeFormat, System.__Canon, System.__Canon, System.__Canon, System.ReadOnlySpan`1<System.Object>)]
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax]
M08_L00:
       xor       eax,eax
       mov       [rbx],rax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M08_L01:
       mov       eax,1
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 91
```
```assembly
; System.Text.StringBuilder.set_Length(Int32)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       test      esi,esi
       jl        short M09_L01
       cmp       esi,[rbx+20]
       jg        short M09_L02
       test      esi,esi
       jne       near ptr M09_L03
       cmp       qword ptr [rbx+10],0
       jne       short M09_L03
       xor       ecx,ecx
       mov       [rbx+18],rcx
M09_L00:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M09_L01:
       mov       ecx,3AD
       mov       rdx,7FF8A7B54000
       call      qword ptr [7FF8A7E37798]
       mov       rdx,rax
       mov       ecx,esi
       call      qword ptr [7FF8A82B4E58]
       int       3
M09_L02:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FF8A7B54000
       call      qword ptr [7FF8A7E37798]
       mov       rsi,rax
       call      qword ptr [7FF8A82B58A8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF8A7E3D9C8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M09_L03:
       mov       ecx,[rbx+1C]
       add       ecx,[rbx+18]
       mov       r8d,esi
       sub       r8d,ecx
       test      r8d,r8d
       jle       short M09_L04
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF8A82B5B48]
       jmp       near ptr M09_L00
M09_L04:
       mov       rcx,rbx
       mov       edx,esi
       call      qword ptr [7FF8A82B5B60]
       mov       rdi,rax
       cmp       rdi,rbx
       je        near ptr M09_L09
       mov       rax,[rbx+8]
       mov       ecx,[rax+8]
       add       ecx,[rbx+1C]
       mov       eax,[rbx+1C]
       add       eax,[rbx+18]
       lea       edx,[rax+rax*2]
       add       edx,edx
       mov       r8d,66666667
       mov       eax,r8d
       imul      edx
       mov       eax,edx
       shr       eax,1F
       sar       edx,1
       add       edx,eax
       mov       rax,[rbx+8]
       mov       eax,[rax+8]
       cmp       edx,eax
       cmovl     edx,eax
       cmp       ecx,edx
       cmovg     ecx,edx
       sub       ecx,[rdi+1C]
       mov       rdx,[rdi+8]
       cmp       [rdx+8],ecx
       jge       short M09_L07
       cmp       ecx,400
       jge       short M09_L05
       movsxd    rdx,ecx
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbp,rax
       jmp       short M09_L06
M09_L05:
       xor       edx,edx
       call      qword ptr [7FF8A819F090]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       rbp,rax
M09_L06:
       mov       rcx,[rdi+8]
       mov       r8d,[rdi+18]
       mov       rdx,rbp
       call      qword ptr [7FF8A7D85050]; System.Array.Copy(System.Array, System.Array, Int32)
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M09_L08
M09_L07:
       mov       rdx,[rdi+8]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
M09_L08:
       mov       rdx,[rdi+10]
       lea       rcx,[rbx+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rdi+1C]
       mov       [rbx+1C],ecx
M09_L09:
       sub       esi,[rdi+1C]
       mov       [rbx+18],esi
       jmp       near ptr M09_L00
; Total bytes of code 399
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderBenchmark.Remove()
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
       mov       [rbp-58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp-40],rax
       mov       [rbp+10],rcx
       mov       rbx,[rcx+30]
       test      rbx,rbx
       je        near ptr M00_L24
       mov       esi,[rbx+8]
       test      esi,esi
       je        near ptr M00_L24
       mov       r8,1EFF2802188
       mov       rdi,[r8]
       mov       r8,[rdi+20]
       mov       [rbp-40],r8
       cmp       qword ptr [rbp-40],0
       je        near ptr M00_L26
       lea       r8,[rdi+20]
       mov       rdx,[rbp-40]
       test      r8,r8
       je        near ptr M00_L25
       mov       rcx,r8
       mov       r8,rdx
       xor       edx,edx
       call      00007FF907846040
       cmp       rax,[rbp-40]
       jne       near ptr M00_L26
M00_L00:
       mov       rdi,[rbp-40]
M00_L01:
       xor       ecx,ecx
       mov       [rbp-40],rcx
       mov       [rbp-50],rdi
       xor       edi,edi
       jmp       near ptr M00_L06
M00_L02:
       mov       r15d,eax
M00_L03:
       cmp       r15d,0FFFFFFFF
       je        near ptr M00_L07
       mov       r13d,r15d
       sub       r13d,edi
       jo        near ptr M00_L20
       mov       r12,[rbp-50]
       cmp       [r12],r12b
       test      edi,edi
       jl        near ptr M00_L16
       test      r13d,r13d
       jl        near ptr M00_L12
       test      r13d,r13d
       je        short M00_L05
       mov       r8d,esi
       sub       r8d,r13d
       cmp       r8d,edi
       jl        near ptr M00_L13
       mov       r8d,edi
       lea       rdx,[r14+r8*2]
       mov       r8,[r12+8]
       mov       edi,[r12+18]
       lea       ecx,[rdi+r13]
       cmp       ecx,[r8+8]
       ja        near ptr M00_L11
       movsxd    rcx,edi
       lea       rcx,[r8+rcx*2+10]
       cmp       r13d,2
       jle       near ptr M00_L10
       mov       r8d,r13d
       add       r8,r8
       call      qword ptr [7FF8A7BF5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L04:
       add       r13d,edi
       mov       [r12+18],r13d
M00_L05:
       mov       edi,r15d
       add       edi,3
       jo        near ptr M00_L20
M00_L06:
       mov       edx,esi
       sub       edx,edi
       mov       ecx,edi
       mov       r8d,edx
       add       rcx,r8
       mov       r8d,esi
       cmp       rcx,r8
       ja        near ptr M00_L14
       lea       r14,[rbx+0C]
       mov       ecx,edi
       lea       rcx,[r14+rcx*2]
       mov       r8,23087810AAC
       mov       r9d,3
       call      qword ptr [7FF8A8205188]; System.SpanHelpers.IndexOf(Char ByRef, Int32, Char ByRef, Int32)
       test      eax,eax
       jl        near ptr M00_L02
       lea       r15d,[rax+rdi]
       jmp       near ptr M00_L03
M00_L07:
       cmp       esi,edi
       jle       short M00_L09
       mov       ebx,esi
       sub       ebx,edi
       jo        near ptr M00_L20
       mov       r12,[rbp-50]
       cmp       [r12],r12b
       test      edi,edi
       jl        near ptr M00_L16
       test      ebx,ebx
       jl        near ptr M00_L17
       test      ebx,ebx
       je        short M00_L09
       sub       esi,ebx
       cmp       esi,edi
       jl        near ptr M00_L18
       mov       r8d,edi
       lea       rdx,[r14+r8*2]
       mov       r8,[r12+8]
       mov       edi,[r12+18]
       lea       ecx,[rdi+rbx]
       cmp       ecx,[r8+8]
       ja        near ptr M00_L21
       movsxd    rcx,edi
       lea       rcx,[r8+rcx*2+10]
       cmp       ebx,2
       jle       near ptr M00_L19
       mov       r8d,ebx
       add       r8,r8
       call      qword ptr [7FF8A7BF5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L08:
       add       ebx,edi
       mov       [r12+18],ebx
M00_L09:
       mov       r12,[rbp-50]
       mov       rcx,r12
       cmp       [rcx],ecx
       call      qword ptr [7FF8A7DE2200]; System.Text.StringBuilder.ToString()
       mov       [rbp-58],rax
       jmp       near ptr M00_L22
M00_L10:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       r13d,2
       jne       near ptr M00_L04
       movzx     edx,word ptr [rdx+2]
       mov       [rcx+2],dx
       jmp       near ptr M00_L04
M00_L11:
       mov       rcx,r12
       mov       r8d,r13d
       call      qword ptr [7FF8A7D6F1E0]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M00_L05
M00_L12:
       mov       ecx,28F
       mov       rdx,7FF8A7B34000
       call      qword ptr [7FF8A7E17798]
       mov       rdx,rax
       mov       ecx,r13d
       call      qword ptr [7FF8A82945B8]
       int       3
M00_L13:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       ecx,0B8F
       mov       rdx,7FF8A7B34000
       call      qword ptr [7FF8A7E17798]
       mov       rsi,rax
       call      qword ptr [7FF8A8294E40]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,r13
       call      qword ptr [7FF8A7E1D9C8]
       mov       rcx,r13
       call      CORINFO_HELP_THROW
       int       3
M00_L14:
       cmp       esi,edi
       jae       short M00_L15
       mov       ecx,8
       xor       edx,edx
       call      qword ptr [7FF8A8176508]
       int       3
M00_L15:
       mov       ecx,1B
       mov       edx,4
       call      qword ptr [7FF8A8176508]
       int       3
M00_L16:
       mov       ecx,0B8F
       mov       rdx,7FF8A7B34000
       call      qword ptr [7FF8A7E17798]
       mov       rdx,rax
       mov       ecx,edi
       call      qword ptr [7FF8A82945B8]
       int       3
M00_L17:
       mov       ecx,28F
       mov       rdx,7FF8A7B34000
       call      qword ptr [7FF8A7E17798]
       mov       rdx,rax
       mov       ecx,ebx
       call      qword ptr [7FF8A82945B8]
       int       3
M00_L18:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,0B8F
       mov       rdx,7FF8A7B34000
       call      qword ptr [7FF8A7E17798]
       mov       rsi,rax
       call      qword ptr [7FF8A8294E40]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF8A7E1D9C8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L19:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       ebx,2
       jne       near ptr M00_L08
       movzx     edx,word ptr [rdx+2]
       mov       [rcx+2],dx
       jmp       near ptr M00_L08
M00_L20:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L21:
       mov       rcx,r12
       mov       r8d,ebx
       call      qword ptr [7FF8A7D6F1E0]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M00_L09
M00_L22:
       call      M00_L28
       nop
       mov       r12,[rbp-58]
M00_L23:
       mov       [rbp-48],r12
       mov       rcx,[rbp+10]
       mov       rbx,[rcx+88]
       mov       rdx,[rbp-48]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
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
M00_L24:
       mov       rdx,23087800008
       test      rbx,rbx
       cmove     rbx,rdx
       mov       r12,rbx
       jmp       short M00_L23
M00_L25:
       call      qword ptr [7FF8A8294E28]
       int       3
M00_L26:
       mov       rcx,[rdi+18]
       lea       rdx,[rbp-40]
       cmp       [rcx],ecx
       call      qword ptr [7FF8A82050B0]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M00_L27
       add       rdi,2C
       lock dec  dword ptr [rdi]
       jmp       near ptr M00_L00
M00_L27:
       mov       rax,[rdi+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       rdi,rax
       jmp       near ptr M00_L01
M00_L28:
       sub       rsp,28
       mov       r12,[rbp-50]
       cmp       dword ptr [r12+20],0
       jge       short M00_L29
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       ecx,3AD
       mov       rdx,7FF8A7B34000
       call      qword ptr [7FF8A7E17798]
       mov       rbx,rax
       call      qword ptr [7FF8A8294F78]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,r12
       call      qword ptr [7FF8A7E1D9C8]
       mov       rcx,r12
       call      CORINFO_HELP_THROW
       int       3
M00_L29:
       cmp       qword ptr [r12+10],0
       jne       short M00_L30
       xor       ecx,ecx
       mov       [r12+18],rcx
       jmp       near ptr M00_L37
M00_L30:
       mov       ecx,[r12+1C]
       add       ecx,[r12+18]
       mov       r8d,ecx
       neg       r8d
       test      r8d,r8d
       jle       short M00_L31
       mov       rcx,r12
       xor       edx,edx
       call      qword ptr [7FF8A8295380]
       jmp       near ptr M00_L37
M00_L31:
       mov       rcx,r12
       xor       edx,edx
       call      qword ptr [7FF8A8295398]
       mov       rbx,rax
       cmp       rbx,r12
       je        near ptr M00_L36
       mov       rax,[r12+8]
       mov       ecx,[rax+8]
       add       ecx,[r12+1C]
       mov       eax,[r12+1C]
       add       eax,[r12+18]
       lea       edx,[rax+rax*2]
       add       edx,edx
       mov       r8d,66666667
       mov       eax,r8d
       imul      edx
       mov       eax,edx
       shr       eax,1F
       sar       edx,1
       add       edx,eax
       mov       rax,[r12+8]
       mov       eax,[rax+8]
       cmp       edx,eax
       cmovl     edx,eax
       cmp       ecx,edx
       cmovg     ecx,edx
       sub       ecx,[rbx+1C]
       mov       rdx,[rbx+8]
       cmp       [rdx+8],ecx
       jge       short M00_L34
       cmp       ecx,400
       jge       short M00_L32
       movsxd    rdx,ecx
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rsi,rax
       jmp       short M00_L33
M00_L32:
       xor       edx,edx
       call      qword ptr [7FF8A817E790]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       rsi,rax
M00_L33:
       mov       rcx,[rbx+8]
       mov       r8d,[rbx+18]
       mov       rdx,rsi
       call      qword ptr [7FF8A7D65050]; System.Array.Copy(System.Array, System.Array, Int32)
       lea       rcx,[r12+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M00_L35
M00_L34:
       mov       rdx,[rbx+8]
       lea       rcx,[r12+8]
       call      CORINFO_HELP_ASSIGN_REF
M00_L35:
       mov       rdx,[rbx+10]
       lea       rcx,[r12+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rbx+1C]
       mov       [r12+1C],ecx
M00_L36:
       mov       ecx,[rbx+1C]
       neg       ecx
       mov       [r12+18],ecx
M00_L37:
       mov       rdx,1EFF2802188
       mov       rbx,[rdx]
       mov       rax,[rbx+10]
       mov       rdx,r12
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       test      eax,eax
       jne       short M00_L39
M00_L38:
       add       rsp,28
       ret
M00_L39:
       cmp       qword ptr [rbx+20],0
       jne       short M00_L41
       lea       rcx,[rbx+20]
       test      rcx,rcx
       jne       short M00_L40
       call      qword ptr [7FF8A8294E28]
       int       3
M00_L40:
       mov       rdx,r12
       xor       r8d,r8d
       call      00007FF907846040
       test      rax,rax
       je        short M00_L38
M00_L41:
       lea       rcx,[rbx+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[rbx+28]
       jg        short M00_L42
       mov       rbx,[rbx+18]
       mov       rcx,[rbx+10]
       mov       rdx,r12
       cmp       [rcx],ecx
       call      qword ptr [7FF8A8295440]
       test      eax,eax
       jne       short M00_L38
       mov       rcx,rbx
       mov       rdx,r12
       call      qword ptr [7FF8A8295458]
       jmp       short M00_L38
M00_L42:
       add       rbx,2C
       lock dec  dword ptr [rbx]
       jmp       short M00_L38
; Total bytes of code 1558
```
```assembly
; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M01_L08
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M01_L08
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       jbe       near ptr M01_L05
       cmp       r8,40
       jbe       short M01_L02
       cmp       r8,800
       ja        near ptr M01_L09
       cmp       r8,100
       jb        short M01_L00
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
M01_L00:
       mov       r9,r8
       shr       r9,6
M01_L01:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M01_L01
       and       r8,3F
       cmp       r8,10
       jbe       short M01_L03
M01_L02:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       jbe       short M01_L03
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M01_L03
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
M01_L03:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
M01_L04:
       vzeroupper
       ret
M01_L05:
       test      r8b,18
       je        short M01_L06
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
       jmp       short M01_L04
M01_L06:
       test      r8b,4
       je        short M01_L07
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
       jmp       short M01_L04
M01_L07:
       test      r8,r8
       je        short M01_L04
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M01_L04
       movsx     rcx,word ptr [rax-2]
       mov       [r10-2],cx
       jmp       short M01_L04
M01_L08:
       cmp       rcx,rdx
       jne       short M01_L09
       cmp       [rdx],dl
       jmp       short M01_L04
M01_L09:
       cmp       [rcx],cl
       cmp       [rdx],dl
       vzeroupper
       jmp       qword ptr [7FF8A7BF66E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 313
```
```assembly
; System.SpanHelpers.IndexOf(Char ByRef, Int32, Char ByRef, Int32)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       vmovaps   [rsp+40],xmm6
       vmovaps   [rsp+30],xmm7
       mov       rbx,rcx
       mov       rdi,r8
       mov       r8d,edx
       mov       esi,r9d
       test      esi,esi
       je        near ptr M02_L11
       lea       ebp,[rsi-1]
       test      ebp,ebp
       je        near ptr M02_L12
       xor       r14d,r14d
       movzx     r15d,word ptr [rdi]
       sub       r8d,ebp
       mov       r13d,r8d
       cmp       r13d,8
       jl        near ptr M02_L14
       lea       ecx,[r13-10]
       test      ecx,ecx
       jl        near ptr M02_L29
       movsxd    rcx,ebp
       movzx     ecx,word ptr [rdi+rcx*2]
       movsxd    r8,ebp
M02_L00:
       cmp       ecx,r15d
       je        near ptr M02_L18
M02_L01:
       vmovd     xmm0,r15d
       vpbroadcastw ymm0,xmm0
       vmovd     xmm1,ecx
       vpbroadcastw ymm1,xmm1
       mov       r12d,r13d
       lea       rcx,[r12-10]
M02_L02:
       vpcmpeqw  ymm2,ymm0,[rbx+r14*2]
       lea       rdx,[r14+r8]
       vpcmpeqw  ymm3,ymm1,[rbx+rdx*2]
       vpand     ymm2,ymm3,ymm2
       vptest    ymm2,ymm2
       jne       short M02_L04
M02_L03:
       add       r14,10
       cmp       r14,r12
       je        near ptr M02_L10
       cmp       r14,rcx
       jle       short M02_L02
       mov       r14,rcx
       jmp       short M02_L02
M02_L04:
       vpmovmskb edx,ymm2
M02_L05:
       xor       eax,eax
       tzcnt     eax,edx
       shr       eax,1
       cmp       esi,2
       je        short M02_L08
       lea       r10,[r14+rax]
       lea       r10,[rbx+r10*2]
       mov       r9d,esi
       add       r9,r9
       cmp       r9,8
       jae       near ptr M02_L22
       cmp       r9,4
       jb        near ptr M02_L19
       add       r9,0FFFFFFFFFFFFFFFC
       mov       r11d,[r10]
       sub       r11d,[rdi]
       mov       r10d,[r10+r9]
       sub       r10d,[rdi+r9]
       or        r10d,r11d
       sete      r10b
       movzx     r10d,r10b
M02_L06:
       test      r10d,r10d
       jne       short M02_L08
M02_L07:
       blsr      edx,edx
       blsr      edx,edx
       jne       short M02_L05
       jmp       short M02_L03
M02_L08:
       add       eax,r14d
M02_L09:
       vzeroupper
       vmovaps   xmm6,[rsp+40]
       vmovaps   xmm7,[rsp+30]
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
M02_L10:
       mov       eax,0FFFFFFFF
       vzeroupper
       vmovaps   xmm6,[rsp+40]
       vmovaps   xmm7,[rsp+30]
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
M02_L11:
       xor       eax,eax
       vzeroupper
       vmovaps   xmm6,[rsp+40]
       vmovaps   xmm7,[rsp+30]
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
M02_L12:
       movsx     rdx,word ptr [rdi]
       movzx     ecx,dx
       dec       ecx
       cmp       ecx,0FE
       jae       short M02_L13
       mov       rcx,rbx
       vzeroupper
       vmovaps   xmm6,[rsp+40]
       vmovaps   xmm7,[rsp+30]
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FF8A7D67798]; System.PackedSpanHelpers.IndexOf[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib],[System.PackedSpanHelpers+NopTransform, System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
M02_L13:
       mov       rcx,rbx
       vzeroupper
       vmovaps   xmm6,[rsp+40]
       vmovaps   xmm7,[rsp+30]
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FF8A7E14B10]; System.SpanHelpers.NonPackedIndexOfValueType[[System.Int16, System.Private.CoreLib],[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
M02_L14:
       add       rdi,2
       test      r13d,r13d
       jle       near ptr M02_L10
M02_L15:
       lea       rcx,[rbx+r14*2]
       movsx     rdx,r15w
       mov       r8d,r13d
       call      qword ptr [7FF8A7E14B10]; System.SpanHelpers.NonPackedIndexOfValueType[[System.Int16, System.Private.CoreLib],[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
       test      eax,eax
       jl        near ptr M02_L10
       sub       r13d,eax
       mov       ecx,eax
       add       r14,rcx
       test      r13d,r13d
       jle       near ptr M02_L10
       lea       rcx,[rbx+r14*2+2]
       mov       r8d,ebp
       add       r8,r8
       mov       rdx,rdi
       call      qword ptr [7FF8A7BFFBB8]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       test      eax,eax
       jne       short M02_L16
       dec       r13d
       inc       r14
       test      r13d,r13d
       jg        short M02_L15
       jmp       near ptr M02_L10
M02_L16:
       mov       eax,r14d
       jmp       near ptr M02_L09
M02_L17:
       dec       r8
       movzx     ecx,word ptr [rdi+r8*2]
       jmp       near ptr M02_L00
M02_L18:
       cmp       r8,1
       jg        short M02_L17
       jmp       near ptr M02_L01
M02_L19:
       xor       r11d,r11d
       mov       rbp,r9
       and       rbp,2
       je        short M02_L20
       movzx     r11d,word ptr [r10]
       movzx     r15d,word ptr [rdi]
       sub       r11d,r15d
M02_L20:
       test      r9b,1
       je        short M02_L21
       movzx     r10d,byte ptr [r10+rbp]
       movzx     r9d,byte ptr [rdi+rbp]
       sub       r10d,r9d
       or        r11d,r10d
M02_L21:
       test      r11d,r11d
       sete      r10b
       movzx     r10d,r10b
       jmp       near ptr M02_L06
M02_L22:
       cmp       r10,rdi
       je        near ptr M02_L08
       cmp       r9,20
       jb        short M02_L25
       xor       r11d,r11d
       add       r9,0FFFFFFFFFFFFFFE0
       je        short M02_L24
M02_L23:
       vmovups   ymm2,[r10+r11]
       vpcmpeqb  ymm2,ymm2,[rdi+r11]
       vpmovmskb r13d,ymm2
       cmp       r13d,0FFFFFFFF
       jne       near ptr M02_L07
       add       r11,20
       cmp       r9,r11
       ja        short M02_L23
M02_L24:
       vmovups   ymm2,[r10+r9]
       vpcmpeqb  ymm2,ymm2,[rdi+r9]
       vpmovmskb r10d,ymm2
       cmp       r10d,0FFFFFFFF
       jne       near ptr M02_L07
       jmp       near ptr M02_L08
M02_L25:
       cmp       r9,10
       jb        short M02_L28
       xor       r11d,r11d
       add       r9,0FFFFFFFFFFFFFFF0
       je        short M02_L27
M02_L26:
       vmovups   xmm2,[r10+r11]
       vpcmpeqb  xmm2,xmm2,[rdi+r11]
       vpmovmskb ebp,xmm2
       cmp       ebp,0FFFF
       jne       near ptr M02_L07
       add       r11,10
       cmp       r9,r11
       ja        short M02_L26
M02_L27:
       vmovups   xmm2,[r10+r9]
       vpcmpeqb  xmm2,xmm2,[rdi+r9]
       vpmovmskb r10d,xmm2
       cmp       r10d,0FFFF
       jne       near ptr M02_L07
       jmp       near ptr M02_L08
M02_L28:
       add       r9,0FFFFFFFFFFFFFFF8
       mov       r11,[r10]
       sub       r11,[rdi]
       mov       r10,[r10+r9]
       sub       r10,[rdi+r9]
       or        r10,r11
       sete      r10b
       movzx     r10d,r10b
       jmp       near ptr M02_L06
M02_L29:
       movsxd    rcx,ebp
       movzx     ecx,word ptr [rdi+rcx*2]
       movsxd    rbp,ebp
       jmp       short M02_L31
M02_L30:
       dec       rbp
       movzx     ecx,word ptr [rdi+rbp*2]
M02_L31:
       cmp       ecx,r15d
       jne       short M02_L32
       cmp       rbp,1
       jg        short M02_L30
M02_L32:
       vmovd     xmm6,r15d
       vpbroadcastw xmm6,xmm6
       vmovd     xmm7,ecx
       vpbroadcastw xmm7,xmm7
       mov       r12d,r13d
       lea       r13,[r12-8]
M02_L33:
       vpcmpeqw  xmm0,xmm6,[rbx+r14*2]
       lea       rcx,[r14+rbp]
       vpcmpeqw  xmm1,xmm7,[rbx+rcx*2]
       vpand     xmm0,xmm1,xmm0
       vptest    xmm0,xmm0
       jne       short M02_L35
       jmp       short M02_L37
M02_L34:
       cmp       r14,r13
       jle       short M02_L33
       mov       r14,r13
       jmp       short M02_L33
M02_L35:
       vpmovmskb r15d,xmm0
M02_L36:
       xor       ecx,ecx
       tzcnt     ecx,r15d
       shr       ecx,1
       mov       eax,ecx
       mov       [rsp+28],rax
       cmp       esi,2
       je        short M02_L38
       lea       rcx,[r14+rax]
       lea       rcx,[rbx+rcx*2]
       mov       r8d,esi
       add       r8,r8
       mov       rdx,rdi
       call      qword ptr [7FF8A7BFFBB8]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       test      eax,eax
       mov       rax,[rsp+28]
       jne       short M02_L38
       blsr      ecx,r15d
       blsr      r15d,ecx
       jne       short M02_L36
M02_L37:
       add       r14,8
       cmp       r14,r12
       je        near ptr M02_L10
       jmp       short M02_L34
M02_L38:
       add       eax,r14d
       jmp       near ptr M02_L09
; Total bytes of code 1076
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       edx,[rbx+1C]
       add       edx,[rbx+18]
       je        short M03_L02
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FF9078A50F0
       mov       rsi,rax
M03_L00:
       mov       r8d,[rbx+18]
       test      r8d,r8d
       jle       short M03_L01
       mov       rdx,[rbx+8]
       mov       ecx,[rbx+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rsi+8]
       ja        short M03_L03
       cmp       [rdx+8],r8d
       jb        short M03_L03
       movsxd    rcx,ecx
       lea       rcx,[rsi+rcx*2+0C]
       movsxd    r8,r8d
       add       r8,r8
       add       rdx,10
       call      qword ptr [7FF8A7BF5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M03_L01:
       mov       rbx,[rbx+10]
       test      rbx,rbx
       jne       short M03_L00
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M03_L02:
       mov       rax,23087800008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M03_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,19655
       mov       rdx,7FF8A7B34000
       call      qword ptr [7FF8A7E17798]
       mov       rbx,rax
       call      qword ptr [7FF8A8294E40]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF8A7E1D9C8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 201
```
```assembly
; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rdi,rdx
       mov       esi,r8d
       mov       eax,[rbx+1C]
       mov       ecx,[rbx+18]
       add       eax,ecx
       add       eax,esi
       cmp       eax,[rbx+20]
       jg        near ptr M04_L06
       cmp       eax,esi
       jl        near ptr M04_L06
       mov       rax,[rbx+8]
       mov       ebp,[rax+8]
       sub       ebp,ecx
       test      ebp,ebp
       jg        short M04_L01
M04_L00:
       sub       esi,ebp
       mov       ecx,[rbx+1C]
       lea       edx,[rsi+rcx]
       mov       eax,[rbx+18]
       add       edx,eax
       cmp       edx,[rbx+20]
       jg        near ptr M04_L09
       cmp       edx,esi
       jl        near ptr M04_L09
       add       ecx,eax
       mov       edx,ecx
       mov       eax,1F40
       cmp       edx,1F40
       cmovg     edx,eax
       cmp       esi,edx
       mov       eax,edx
       cmovge    eax,esi
       add       ecx,eax
       cmp       ecx,eax
       jl        near ptr M04_L10
       cmp       eax,400
       jge       short M04_L03
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
       jmp       short M04_L04
M04_L01:
       mov       rax,[rbx+8]
       test      rax,rax
       je        near ptr M04_L07
       mov       edx,[rax+8]
       cmp       edx,ecx
       jb        near ptr M04_L08
       mov       r8d,ecx
       lea       rax,[rax+r8*2+10]
       sub       edx,ecx
M04_L02:
       cmp       ebp,edx
       ja        near ptr M04_L12
       mov       r8d,ebp
       add       r8,r8
       mov       rcx,rax
       mov       rdx,rdi
       call      qword ptr [7FF8A7BF5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
       jmp       near ptr M04_L00
M04_L03:
       mov       ecx,eax
       xor       edx,edx
       call      qword ptr [7FF8A817E790]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       r14,rax
M04_L04:
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       ecx,[rbx+18]
       mov       [r15+18],ecx
       mov       ecx,[rbx+1C]
       mov       [r15+1C],ecx
       mov       rdx,[rbx+8]
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbx+10]
       lea       rcx,[r15+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rbx+20]
       mov       [r15+20],ecx
       lea       rcx,[rbx+10]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rbx+18]
       add       [rbx+1C],ecx
       xor       ecx,ecx
       mov       [rbx+18],ecx
       lea       rcx,[rbx+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       movsxd    r8,ebp
       lea       rdx,[rdi+r8*2]
       mov       r8,[rbx+8]
       test      r8,r8
       je        near ptr M04_L11
       lea       rcx,[r8+10]
       mov       r8d,[r8+8]
M04_L05:
       cmp       esi,r8d
       ja        near ptr M04_L12
       mov       r8d,esi
       add       r8,r8
       call      qword ptr [7FF8A7BF5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       [rbx+18],esi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M04_L06:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,19685
       mov       rdx,7FF8A7B34000
       call      qword ptr [7FF8A7E17798]
       mov       rsi,rax
       call      qword ptr [7FF8A8294F30]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF8A7E1D9C8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M04_L07:
       test      ecx,ecx
       jne       short M04_L08
       xor       eax,eax
       xor       edx,edx
       jmp       near ptr M04_L02
M04_L08:
       call      qword ptr [7FF8A7D67198]
       int       3
M04_L09:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,1969B
       mov       rdx,7FF8A7B34000
       call      qword ptr [7FF8A7E17798]
       mov       rsi,rax
       call      qword ptr [7FF8A8294F78]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF8A7E1D9C8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M04_L10:
       mov       rcx,offset MT_System.OutOfMemoryException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8A8294F90]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M04_L11:
       xor       ecx,ecx
       xor       r8d,r8d
       jmp       near ptr M04_L05
M04_L12:
       call      qword ptr [7FF8A800CF90]
       int       3
; Total bytes of code 626
```
```assembly
; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,[rsi+18]
       mov       rcx,rdi
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FF8D757EA60]; Precode of System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       jne       short M05_L01
       cmp       qword ptr [rdi+10],0
       je        short M05_L00
       mov       rcx,rsi
       mov       rdx,rbx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax]
M05_L00:
       xor       eax,eax
       mov       [rbx],rax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M05_L01:
       mov       eax,1
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 91
```
```assembly
; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0A8
       lea       rbp,[rsp+0E0]
       xor       eax,eax
       mov       [rbp-48],rax
       mov       r8d,ecx
       mov       ecx,10
       mov       r9d,50
       test      dl,dl
       cmovne    ecx,r9d
       mov       [rbp-3C],ecx
       xor       edx,edx
       mov       [rbp-48],rdx
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       [rbp-0B0],rcx
       mov       edx,r8d
       mov       [rbp-0A4],edx
       mov       r8d,[rbp-3C]
       mov       [rbp-0A8],r8d
       lea       r9,[rbp-48]
       mov       [rbp-0B8],r9
       lea       rcx,[rbp-0A0]
       call      qword ptr [7FF8D7559030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-0B0]
       mov       edx,[rbp-0A4]
       mov       r8d,[rbp-0A8]
       mov       r9,[rbp-0B8]
       call      qword ptr [rax]
       lea       rcx,[rbp-0A0]
       call      qword ptr [7FF8D7559038]; CORINFO_HELP_JIT_PINVOKE_END
       mov       rax,[rbp-48]
       add       rsp,0A8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 193
```
```assembly
; System.Array.Copy(System.Array, System.Array, Int32)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       rsi,rcx
       mov       rbx,rdx
       mov       edi,r8d
       test      rsi,rsi
       jne       short M07_L01
       xor       ebp,ebp
       xor       r14d,r14d
M07_L00:
       test      rbx,rbx
       jne       near ptr M07_L09
       xor       ebx,ebx
       xor       r15d,r15d
       jmp       near ptr M07_L10
M07_L01:
       test      rbx,rbx
       jne       short M07_L04
       mov       rcx,7FF8A828E3D4
       call      CORINFO_HELP_COUNTPROFILE32
M07_L02:
       mov       rcx,7FF8A828E3DC
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rsi]
       mov       ecx,[rcx+4]
       add       ecx,0FFFFFFE8
       shr       ecx,3
       jne       short M07_L08
       xor       r14d,r14d
M07_L03:
       mov       rbp,rsi
       jmp       short M07_L00
M07_L04:
       mov       r15,[rsi]
       cmp       r15,[rbx]
       je        short M07_L05
       mov       rcx,7FF8A828E3D0
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M07_L02
M07_L05:
       cmp       dword ptr [r15+4],18
       je        short M07_L06
       mov       rcx,7FF8A828E3CC
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M07_L02
M07_L06:
       cmp       edi,[rsi+8]
       jbe       short M07_L07
       mov       rcx,7FF8A828E3C8
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M07_L02
M07_L07:
       cmp       edi,[rbx+8]
       jbe       near ptr M07_L13
       mov       rcx,7FF8A828E3C4
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M07_L02
M07_L08:
       movsxd    rcx,ecx
       mov       r14d,[rsi+rcx*4+10]
       jmp       short M07_L03
M07_L09:
       mov       rcx,7FF8A828E3E0
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbx]
       mov       ecx,[rcx+4]
       add       ecx,0FFFFFFE8
       shr       ecx,3
       jne       short M07_L12
       xor       r15d,r15d
M07_L10:
       mov       rcx,7FF8A828E3E4
       call      CORINFO_HELP_COUNTPROFILE32
       mov       [rsp+20],edi
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rbp
       mov       edx,r14d
       mov       r8,rbx
       mov       r9d,r15d
       call      qword ptr [7FF8A8205D28]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
M07_L11:
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M07_L12:
       movsxd    rcx,ecx
       mov       r15d,[rbx+rcx*4+10]
       jmp       short M07_L10
M07_L13:
       mov       edi,edi
       movzx     ebp,word ptr [r15]
       imul      rdi,rbp
       add       rsi,10
       add       rbx,10
       test      dword ptr [r15],1000000
       je        short M07_L15
       mov       rcx,7FF8A828E3C0
       call      CORINFO_HELP_COUNTPROFILE32
       cmp       rdi,4000
       ja        short M07_L14
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       call      00007FF90782A2B0
       cmp       dword ptr [7FF907B64A90],0
       je        short M07_L11
       call      CORINFO_HELP_POLL_GC
       jmp       short M07_L11
M07_L14:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       qword ptr [7FF8A820EFB8]
M07_L15:
       mov       rcx,7FF8A828E3D8
       call      CORINFO_HELP_COUNTPROFILE32
       cmp       rdi,19
       jne       short M07_L16
       vmovdqu   xmm0,xmmword ptr [rsi]
       vmovdqu   xmm1,xmmword ptr [rsi+9]
       vmovdqu   xmmword ptr [rbx],xmm0
       vmovdqu   xmmword ptr [rbx+9],xmm1
       jmp       near ptr M07_L11
M07_L16:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       call      qword ptr [7FF8A7BF5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M07_L11
; Total bytes of code 488
```

