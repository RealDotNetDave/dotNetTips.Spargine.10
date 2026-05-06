## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderBenchmark.FormatComparison()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,88
       xor       eax,eax
       mov       [rsp+48],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+50],ymm4
       vmovdqa   xmmword ptr [rsp+70],xmm4
       mov       [rsp+80],rax
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
       mov       r8,[rbx+138]
       test      r8,r8
       je        near ptr M00_L04
       lea       rdi,[r8+10]
       mov       ebp,[r8+8]
M00_L00:
       xor       r14d,r14d
M00_L01:
       cmp       r14d,1F
       ja        near ptr M00_L63
       mov       r15,17E24810708
       mov       r8d,r14d
       lea       r13,[r15+r8*2+0C]
       mov       r12d,r14d
       neg       r12d
       add       r12d,1F
       mov       r8d,7D
       mov       edx,7B
       mov       rcx,r13
       mov       r9d,r12d
       call      qword ptr [7FFB5E42C648]; System.PackedSpanHelpers.IndexOfAny[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib],[System.PackedSpanHelpers+NopTransform, System.Private.CoreLib]](Int16 ByRef, Int16, Int16, Int32)
       mov       [rsp+7C],eax
       test      eax,eax
       jge       near ptr M00_L05
       test      r12d,r12d
       je        short M00_L03
       mov       r8,[rsi+8]
       mov       edi,[rsi+18]
       lea       ecx,[rdi+r12]
       cmp       ecx,[r8+8]
       ja        near ptr M00_L34
       movsxd    rcx,edi
       lea       rcx,[r8+rcx*2+10]
       cmp       r12d,2
       jle       near ptr M00_L60
       mov       r8d,r12d
       add       r8,r8
       mov       rdx,r13
       call      qword ptr [7FFB5E195818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L02:
       add       r12d,edi
       mov       [rsi+18],r12d
M00_L03:
       mov       [rsp+70],rsi
       mov       rcx,[rbx+60]
       lea       r8,[rsp+70]
       mov       rdx,7FFB5E8139A8
       cmp       [rcx],ecx
       call      qword ptr [7FFB5E7BD848]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,88
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L04:
       xor       edi,edi
       xor       ebp,ebp
       jmp       near ptr M00_L00
M00_L05:
       cmp       eax,r12d
       ja        near ptr M00_L64
       test      eax,eax
       je        short M00_L07
       mov       r8,[rsi+8]
       mov       ecx,[rsi+18]
       lea       r12d,[rcx+rax]
       cmp       r12d,[r8+8]
       ja        near ptr M00_L10
       movsxd    rcx,ecx
       lea       rcx,[r8+rcx*2+10]
       cmp       eax,2
       jle       near ptr M00_L36
       mov       r8d,eax
       add       r8,r8
       mov       rdx,r13
       call      qword ptr [7FFB5E195818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       eax,[rsp+7C]
M00_L06:
       mov       [rsi+18],r12d
M00_L07:
       add       r14d,eax
       cmp       r14d,1F
       jae       near ptr M00_L66
       mov       edx,r14d
       movzx     edx,word ptr [r15+rdx*2+0C]
       inc       r14d
       cmp       r14d,1F
       jae       near ptr M00_L61
       cmp       r14d,1F
       jae       near ptr M00_L66
       mov       ecx,r14d
       movzx     eax,word ptr [r15+rcx*2+0C]
       cmp       edx,eax
       jne       short M00_L11
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       r8,[rsi+8]
       mov       r10d,[r8+8]
       cmp       r10d,edx
       jbe       near ptr M00_L37
       mov       [r8+rdx*2+10],ax
       inc       ecx
       mov       [rsi+18],ecx
M00_L08:
       inc       r14d
M00_L09:
       cmp       r14d,1F
       jae       near ptr M00_L03
       jmp       near ptr M00_L01
M00_L10:
       mov       rcx,rsi
       mov       rdx,r13
       mov       r8d,eax
       call      qword ptr [7FFB5E4271E0]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       mov       eax,[rsp+7C]
       jmp       near ptr M00_L07
M00_L11:
       cmp       edx,7B
       jne       near ptr M00_L33
       xor       r13d,r13d
       xor       r12d,r12d
       xor       r8d,r8d
       xor       r10d,r10d
       add       eax,0FFFFFFD0
       cmp       eax,0A
       jae       near ptr M00_L19
       inc       r14d
       cmp       r14d,1F
       jae       near ptr M00_L61
       cmp       r14d,1F
       jae       near ptr M00_L66
       mov       edx,r14d
       movzx     edx,word ptr [r15+rdx*2+0C]
       cmp       edx,7D
       je        near ptr M00_L22
       lea       ecx,[rdx-30]
       cmp       ecx,9
       ja        short M00_L13
M00_L12:
       cmp       eax,0F4240
       jge       short M00_L13
       lea       eax,[rax+rax*4]
       lea       eax,[rdx+rax*2-30]
       inc       r14d
       cmp       r14d,1F
       jae       near ptr M00_L61
       cmp       r14d,1F
       jae       near ptr M00_L66
       mov       edx,r14d
       movzx     edx,word ptr [r15+rdx*2+0C]
       lea       ecx,[rdx-30]
       cmp       ecx,9
       jbe       short M00_L12
M00_L13:
       cmp       edx,20
       jne       short M00_L15
M00_L14:
       inc       r14d
       cmp       r14d,1F
       jae       near ptr M00_L61
       cmp       r14d,1F
       jae       near ptr M00_L66
       mov       edx,r14d
       movzx     edx,word ptr [r15+rdx*2+0C]
       cmp       edx,20
       je        short M00_L14
M00_L15:
       cmp       edx,2C
       jne       short M00_L21
       inc       r14d
       cmp       r14d,1F
       jae       near ptr M00_L61
M00_L16:
       mov       edx,r14d
       movzx     edx,word ptr [r15+rdx*2+0C]
       cmp       edx,20
       jne       short M00_L17
       inc       r14d
       cmp       r14d,1F
       jb        short M00_L16
       jmp       near ptr M00_L61
M00_L17:
       cmp       edx,2D
       je        near ptr M00_L38
M00_L18:
       lea       r13d,[rdx-30]
       cmp       r13d,0A
       jb        near ptr M00_L39
M00_L19:
       mov       ecx,r14d
       mov       edx,4D
       call      qword ptr [7FFB5E844D08]
       int       3
M00_L20:
       cmp       r14d,1F
       jae       near ptr M00_L66
       mov       edx,r14d
       movzx     edx,word ptr [r15+rdx*2+0C]
       lea       ecx,[rdx-30]
       cmp       ecx,9
       ja        near ptr M00_L42
       jmp       near ptr M00_L41
M00_L21:
       cmp       edx,7D
       je        short M00_L22
       cmp       edx,3A
       je        near ptr M00_L44
       jmp       near ptr M00_L62
M00_L22:
       inc       r14d
       xor       r15d,r15d
       cmp       eax,ebp
       jae       near ptr M00_L32
       cmp       eax,ebp
       jae       near ptr M00_L66
       mov       edx,eax
       mov       rax,[rdi+rdx*8]
       mov       [rsp+38],rax
       test      r12d,r12d
       je        near ptr M00_L35
       mov       [rsp+6C],r10d
       mov       [rsp+28],r8
M00_L23:
       mov       rdx,rax
       mov       rcx,offset MT_System.ISpanFormattable
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        near ptr M00_L25
       mov       r9,[rsi+8]
       mov       rdx,r9
       mov       r8d,[rsi+18]
       mov       ecx,r8d
       mov       r9d,[r9+8]
       sub       r9d,r8d
       test      rdx,rdx
       je        near ptr M00_L49
       mov       r8d,r9d
       add       r8,rcx
       mov       r11d,[rdx+8]
       cmp       r8,r11
       ja        near ptr M00_L64
       lea       rdx,[rdx+rcx*2+10]
M00_L24:
       mov       [rsp+48],rdx
       mov       [rsp+50],r9d
       mov       r10,[rsp+28]
       mov       [rsp+58],r10
       mov       r11d,[rsp+6C]
       mov       [rsp+60],r11d
       xor       r9d,r9d
       mov       [rsp+20],r9
       lea       r9,[rsp+58]
       lea       rdx,[rsp+48]
       lea       r8,[rsp+80]
       mov       rcx,rax
       mov       r11,7FFB5E0E0AB8
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L52
M00_L25:
       mov       rdx,[rsp+38]
       mov       rcx,offset MT_System.IFormattable
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       [rsp+30],rax
       test      rax,rax
       jne       short M00_L27
       mov       r15,[rsp+38]
       test      r15,r15
       jne       near ptr M00_L57
       jmp       near ptr M00_L56
M00_L26:
       jmp       short M00_L29
M00_L27:
       mov       rax,[rsp+30]
       mov       ecx,[rsp+6C]
       test      ecx,ecx
       jne       near ptr M00_L55
M00_L28:
       mov       rcx,rax
       mov       rdx,r15
       mov       r11,7FFB5E0E0AB0
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       r15,rax
M00_L29:
       test      r15,r15
       jne       short M00_L30
       mov       r15,17E24800008
M00_L30:
       mov       eax,[r15+8]
       mov       [rsp+44],eax
       cmp       eax,r13d
       jge       short M00_L31
       test      r12d,r12d
       je        near ptr M00_L59
       jmp       near ptr M00_L58
M00_L31:
       mov       rcx,rsi
       mov       rdx,r15
       call      qword ptr [7FFB5E427228]; System.Text.StringBuilder.Append(System.String)
       jmp       near ptr M00_L09
M00_L32:
       call      qword ptr [7FFB5E844D20]
       int       3
M00_L33:
       mov       ecx,r14d
       mov       edx,4B
       call      qword ptr [7FFB5E844D08]
       int       3
M00_L34:
       mov       rcx,rsi
       mov       rdx,r13
       mov       r8d,r12d
       call      qword ptr [7FFB5E4271E0]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M00_L03
M00_L35:
       test      r13d,r13d
       mov       [rsp+6C],r10d
       mov       [rsp+28],r8
       jne       near ptr M00_L50
       jmp       near ptr M00_L23
M00_L36:
       movzx     edx,word ptr [r13]
       mov       [rcx],dx
       cmp       eax,2
       jne       near ptr M00_L06
       movzx     edx,word ptr [r13+2]
       mov       [rcx+2],dx
       jmp       near ptr M00_L06
M00_L37:
       mov       rcx,rsi
       mov       edx,eax
       call      qword ptr [7FFB5E4273A8]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L08
M00_L38:
       mov       r12d,1
       inc       r14d
       cmp       r14d,1F
       jae       near ptr M00_L61
       cmp       r14d,1F
       jae       near ptr M00_L66
       mov       edx,r14d
       movzx     edx,word ptr [r15+rdx*2+0C]
       jmp       near ptr M00_L18
M00_L39:
       inc       r14d
       cmp       r14d,1F
       jb        near ptr M00_L20
       jmp       near ptr M00_L61
M00_L40:
       lea       ecx,[r13+r13*4]
       lea       r13d,[rdx+rcx*2-30]
       inc       r14d
       cmp       r14d,1F
       jb        near ptr M00_L20
       jmp       near ptr M00_L61
M00_L41:
       cmp       r13d,0F4240
       jl        short M00_L40
M00_L42:
       cmp       edx,20
       jne       near ptr M00_L21
M00_L43:
       inc       r14d
       cmp       r14d,1F
       jae       near ptr M00_L61
       cmp       r14d,1F
       jae       near ptr M00_L66
       mov       edx,r14d
       movzx     edx,word ptr [r15+rdx*2+0C]
       cmp       edx,20
       je        short M00_L43
       jmp       near ptr M00_L21
M00_L44:
       mov       r8d,r14d
       inc       r8d
       mov       r14d,r8d
       cmp       r14d,1F
       jae       near ptr M00_L61
M00_L45:
       cmp       r14d,1F
       jae       near ptr M00_L66
       mov       edx,r14d
       movzx     edx,word ptr [r15+rdx*2+0C]
       cmp       edx,7D
       je        short M00_L48
       jmp       short M00_L47
M00_L46:
       inc       r14d
       cmp       r14d,1F
       jb        short M00_L45
       jmp       near ptr M00_L61
M00_L47:
       cmp       edx,7B
       jne       short M00_L46
       jmp       near ptr M00_L62
M00_L48:
       mov       r10d,r14d
       sub       r10d,r8d
       mov       edx,r8d
       mov       ecx,r10d
       add       rcx,rdx
       cmp       rcx,1F
       ja        near ptr M00_L63
       lea       r8,[r15+rdx*2+0C]
       mov       [rsp+28],r8
       mov       [rsp+6C],r10d
       mov       r8,[rsp+28]
       mov       r10d,[rsp+6C]
       jmp       near ptr M00_L22
M00_L49:
       or        ecx,r9d
       je        short M00_L51
       jmp       near ptr M00_L64
M00_L50:
       jmp       near ptr M00_L25
M00_L51:
       xor       edx,edx
       xor       r9d,r9d
       jmp       near ptr M00_L24
M00_L52:
       mov       r8d,[rsp+80]
       mov       rcx,[rsi+8]
       mov       rdx,rcx
       mov       eax,[rsi+18]
       mov       r10d,eax
       mov       ecx,[rcx+8]
       sub       ecx,eax
       test      rdx,rdx
       jne       short M00_L53
       or        r10d,ecx
       jne       near ptr M00_L64
       xor       ecx,ecx
       jmp       short M00_L54
M00_L53:
       mov       r10d,r10d
       mov       r9d,ecx
       add       r10,r9
       mov       edx,[rdx+8]
       cmp       r10,rdx
       ja        near ptr M00_L64
M00_L54:
       cmp       r8d,ecx
       ja        near ptr M00_L65
       add       eax,[rsp+80]
       mov       [rsi+18],eax
       test      r12d,r12d
       je        near ptr M00_L09
       cmp       r13d,[rsp+80]
       jle       near ptr M00_L09
       mov       r8d,r13d
       sub       r8d,[rsp+80]
       mov       rcx,rsi
       mov       edx,20
       call      qword ptr [7FFB5E844CF0]
       jmp       near ptr M00_L09
M00_L55:
       mov       r15,[rsp+28]
       mov       [rsp+58],r15
       mov       [rsp+60],ecx
       lea       rcx,[rsp+58]
       call      System.String.Ctor(System.ReadOnlySpan`1<Char>)
       mov       r15,rax
       mov       rax,[rsp+30]
       jmp       near ptr M00_L28
M00_L56:
       xor       r15d,r15d
       jmp       near ptr M00_L26
M00_L57:
       mov       rcx,r15
       mov       rax,[r15]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       r15,rax
       jmp       near ptr M00_L26
M00_L58:
       mov       rcx,rsi
       mov       rdx,r15
       call      qword ptr [7FFB5E427228]; System.Text.StringBuilder.Append(System.String)
       mov       r8d,r13d
       sub       r8d,[rsp+44]
       mov       rcx,rsi
       mov       edx,20
       call      qword ptr [7FFB5E844CF0]
       jmp       near ptr M00_L09
M00_L59:
       sub       r13d,eax
       mov       r8d,r13d
       mov       rcx,rsi
       mov       edx,20
       call      qword ptr [7FFB5E844CF0]
       jmp       near ptr M00_L31
M00_L60:
       movzx     edx,word ptr [r13]
       mov       [rcx],dx
       cmp       r12d,2
       jne       near ptr M00_L02
       movzx     edx,word ptr [r13+2]
       mov       [rcx+2],dx
       jmp       near ptr M00_L02
M00_L61:
       mov       ecx,r14d
       mov       edx,4C
       call      qword ptr [7FFB5E844D08]
       int       3
M00_L62:
       mov       ecx,r14d
       mov       edx,4C
       call      qword ptr [7FFB5E844D08]
       int       3
M00_L63:
       mov       ecx,21
       call      qword ptr [7FFB5E19F360]
       int       3
M00_L64:
       call      qword ptr [7FFB5E36F228]
       int       3
M00_L65:
       call      qword ptr [7FFB5E844D38]
       int       3
M00_L66:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1999
```
```assembly
; System.PackedSpanHelpers.IndexOfAny[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib],[System.PackedSpanHelpers+NopTransform, System.Private.CoreLib]](Int16 ByRef, Int16, Int16, Int32)
       push      rbx
       cmp       r9d,8
       jl        near ptr M01_L07
       mov       rax,rcx
       cmp       r9d,10
       jle       short M01_L04
       vmovd     xmm0,edx
       vpbroadcastb ymm0,xmm0
       vmovd     xmm1,r8d
       vpbroadcastb ymm1,xmm1
       cmp       r9d,20
       jg        near ptr M01_L22
M01_L00:
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
       je        near ptr M01_L21
       vpermq    ymm0,ymm0,0D8
       vpmovmskb r8d,ymm0
       tzcnt     r8d,r8d
       cmp       r8d,10
       jge       short M01_L03
M01_L01:
       sub       rax,rcx
       shr       rax,1
       add       eax,r8d
M01_L02:
       vzeroupper
       pop       rbx
       ret
M01_L03:
       mov       rax,rdx
       add       r8d,0FFFFFFF0
       jmp       short M01_L01
M01_L04:
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
       je        near ptr M01_L21
       vpmovmskb r8d,xmm0
       tzcnt     r8d,r8d
       cmp       r8d,8
       jge       short M01_L06
M01_L05:
       sub       rdx,rcx
       shr       rdx,1
       lea       eax,[rdx+r8]
       jmp       short M01_L02
M01_L06:
       mov       rdx,rax
       add       r8d,0FFFFFFF8
       jmp       short M01_L05
M01_L07:
       xor       eax,eax
       cmp       r9d,4
       jl        near ptr M01_L19
       add       r9d,0FFFFFFFC
       movsx     r10,word ptr [rcx]
       movsx     r11,dx
       cmp       r10d,r11d
       je        short M01_L08
       movsx     rbx,r8w
       cmp       r10d,ebx
       jne       short M01_L09
M01_L08:
       xor       eax,eax
       vzeroupper
       pop       rbx
       ret
M01_L09:
       movsx     r10,word ptr [rcx+2]
       cmp       r10d,r11d
       je        short M01_L10
       cmp       r10d,ebx
       jne       short M01_L11
M01_L10:
       mov       eax,1
       vzeroupper
       pop       rbx
       ret
M01_L11:
       movsx     r10,word ptr [rcx+4]
       cmp       r10d,r11d
       je        short M01_L12
       cmp       r10d,ebx
       jne       short M01_L13
M01_L12:
       mov       eax,2
       vzeroupper
       pop       rbx
       ret
M01_L13:
       movsx     r10,word ptr [rcx+6]
       cmp       r10d,r11d
       je        short M01_L14
       cmp       r10d,ebx
       jne       short M01_L15
M01_L14:
       mov       eax,3
       jmp       near ptr M01_L02
M01_L15:
       mov       eax,4
       jmp       short M01_L19
M01_L16:
       movsx     rbx,r8w
       cmp       r10d,ebx
       jne       short M01_L18
M01_L17:
       jmp       near ptr M01_L02
M01_L18:
       inc       rax
       test      r9d,r9d
       jg        short M01_L20
       jmp       short M01_L21
M01_L19:
       test      r9d,r9d
       jle       short M01_L21
M01_L20:
       dec       r9d
       movsx     r10,word ptr [rcx+rax*2]
       movsx     r11,dx
       cmp       r10d,r11d
       je        short M01_L17
       jmp       short M01_L16
M01_L21:
       mov       eax,0FFFFFFFF
       jmp       near ptr M01_L02
M01_L22:
       lea       edx,[r9-20]
       movsxd    r8,edx
       lea       rdx,[rax+r8*2]
M01_L23:
       vmovups   ymm2,[rax]
       vpackuswb ymm2,ymm2,[rax+20]
       vpcmpeqb  ymm3,ymm0,ymm2
       vpcmpeqb  ymm2,ymm1,ymm2
       vpor      ymm2,ymm2,ymm3
       vptest    ymm2,ymm2
       jne       short M01_L24
       add       rax,40
       cmp       rax,rdx
       jb        short M01_L23
       jmp       near ptr M01_L00
M01_L24:
       sub       rax,rcx
       shr       rax,1
       vpermq    ymm0,ymm2,0D8
       vpmovmskb ecx,ymm0
       tzcnt     ecx,ecx
       add       eax,ecx
       jmp       near ptr M01_L02
; Total bytes of code 514
```
```assembly
; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M02_L10
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M02_L10
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       ja        short M02_L02
       test      r8b,18
       je        short M02_L01
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
M02_L00:
       vzeroupper
       ret
M02_L01:
       test      r8b,4
       je        short M02_L06
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
       jmp       short M02_L00
M02_L02:
       cmp       r8,40
       ja        short M02_L07
M02_L03:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        short M02_L05
M02_L04:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
       jmp       short M02_L00
M02_L05:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M02_L04
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M02_L04
M02_L06:
       test      r8,r8
       je        short M02_L00
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M02_L00
       movsx     r8,word ptr [rax-2]
       mov       [r10-2],r8w
       jmp       short M02_L00
M02_L07:
       cmp       r8,800
       ja        short M02_L11
       cmp       r8,100
       jb        short M02_L08
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
M02_L08:
       mov       r9,r8
       shr       r9,6
M02_L09:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M02_L09
       and       r8,3F
       cmp       r8,10
       ja        near ptr M02_L03
       jmp       near ptr M02_L04
M02_L10:
       cmp       rcx,rdx
       jne       short M02_L11
       cmp       [rdx],dl
       jmp       near ptr M02_L00
M02_L11:
       cmp       [rcx],cl
       cmp       [rdx],dl
       vzeroupper
       jmp       qword ptr [7FFB5E1966E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 319
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
       jg        near ptr M04_L04
       cmp       eax,esi
       jl        near ptr M04_L04
       mov       rax,[rbx+8]
       mov       ebp,[rax+8]
       sub       ebp,ecx
       test      ebp,ebp
       jle       short M04_L01
       mov       rax,[rbx+8]
       test      rax,rax
       je        near ptr M04_L05
       mov       edx,[rax+8]
       cmp       edx,ecx
       jb        near ptr M04_L06
       mov       r8d,ecx
       lea       rax,[rax+r8*2+10]
       sub       edx,ecx
M04_L00:
       cmp       ebp,edx
       ja        near ptr M04_L11
       mov       r8d,ebp
       add       r8,r8
       mov       rcx,rax
       mov       rdx,rdi
       call      qword ptr [7FFB5E195818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rdx,[rbx+8]
       mov       edx,[rdx+8]
       mov       [rbx+18],edx
M04_L01:
       sub       esi,ebp
       mov       edx,[rbx+1C]
       lea       ecx,[rsi+rdx]
       mov       eax,[rbx+18]
       add       ecx,eax
       cmp       ecx,[rbx+20]
       jg        near ptr M04_L07
       cmp       ecx,esi
       jl        near ptr M04_L07
       add       edx,eax
       mov       ecx,edx
       mov       eax,1F40
       cmp       ecx,1F40
       cmovg     ecx,eax
       cmp       esi,ecx
       cmovge    ecx,esi
       add       edx,ecx
       cmp       edx,ecx
       jl        near ptr M04_L08
       cmp       ecx,400
       jge       near ptr M04_L09
       movsxd    rdx,ecx
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
M04_L02:
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
       je        near ptr M04_L10
       lea       rcx,[r8+10]
       mov       r8d,[r8+8]
M04_L03:
       cmp       esi,r8d
       ja        near ptr M04_L11
       mov       r8d,esi
       add       r8,r8
       call      qword ptr [7FFB5E195818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       [rbx+18],esi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M04_L04:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,19685
       mov       rdx,7FFB5E0D4000
       call      qword ptr [7FFB5E19F228]
       mov       rsi,rax
       call      qword ptr [7FFB5E8446F0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFB5E42D950]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M04_L05:
       test      ecx,ecx
       jne       short M04_L06
       xor       eax,eax
       xor       edx,edx
       jmp       near ptr M04_L00
M04_L06:
       call      qword ptr [7FFB5E36F228]
       int       3
M04_L07:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,1969B
       mov       rdx,7FFB5E0D4000
       call      qword ptr [7FFB5E19F228]
       mov       rsi,rax
       call      qword ptr [7FFB5E844738]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFB5E42D950]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M04_L08:
       mov       rcx,offset MT_System.OutOfMemoryException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB5E844750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M04_L09:
       xor       edx,edx
       call      qword ptr [7FFB5E72F228]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       r14,rax
       jmp       near ptr M04_L02
M04_L10:
       xor       ecx,ecx
       xor       r8d,r8d
       jmp       near ptr M04_L03
M04_L11:
       call      qword ptr [7FFB5E5AD218]
       int       3
; Total bytes of code 625
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rdx,rdx
       je        short M05_L05
       mov       rax,[rdx]
       movzx     r8d,word ptr [rax+0E]
       test      r8,r8
       je        short M05_L04
       mov       r10,[rax+38]
       cmp       r8,4
       jl        short M05_L02
       cmp       [r10],rcx
       je        short M05_L05
M05_L00:
       cmp       [r10+8],rcx
       je        short M05_L05
       cmp       [r10+10],rcx
       je        short M05_L05
       cmp       [r10+18],rcx
       je        short M05_L05
       add       r10,20
       add       r8,0FFFFFFFFFFFFFFFC
       cmp       r8,4
       jl        short M05_L01
       cmp       [r10],rcx
       je        short M05_L05
       jmp       short M05_L00
M05_L01:
       test      r8,r8
       je        short M05_L04
M05_L02:
       cmp       [r10],rcx
       je        short M05_L05
M05_L03:
       add       r10,8
       dec       r8
       test      r8,r8
       jg        short M05_L06
M05_L04:
       test      dword ptr [rax],500C0000
       jne       short M05_L07
       xor       edx,edx
M05_L05:
       mov       rax,rdx
       ret
M05_L06:
       cmp       [r10],rcx
       je        short M05_L05
       jmp       short M05_L03
M05_L07:
       jmp       qword ptr [7FFB5E51D848]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
; Total bytes of code 121
```
```assembly
; System.Text.StringBuilder.Append(System.String)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       test      rdx,rdx
       je        short M06_L01
       lea       rax,[rdx+0C]
       mov       esi,[rdx+8]
       test      esi,esi
       je        short M06_L01
       mov       r8,[rbx+8]
       mov       edi,[rbx+18]
       lea       ecx,[rdi+rsi]
       cmp       ecx,[r8+8]
       ja        short M06_L02
       movsxd    rcx,edi
       lea       rcx,[r8+rcx*2+10]
       cmp       esi,2
       jle       short M06_L03
       mov       r8d,esi
       add       r8,r8
       mov       rdx,rax
       call      qword ptr [7FFB5E195818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M06_L00:
       add       esi,edi
       mov       [rbx+18],esi
M06_L01:
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M06_L02:
       mov       rcx,rbx
       mov       rdx,rax
       mov       r8d,esi
       call      qword ptr [7FFB5E4271E0]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M06_L01
M06_L03:
       movzx     edx,word ptr [rax]
       mov       [rcx],dx
       cmp       esi,2
       jne       short M06_L00
       movzx     eax,word ptr [rax+2]
       mov       [rcx+2],ax
       jmp       short M06_L00
; Total bytes of code 124
```
```assembly
; System.Text.StringBuilder.AppendWithExpansion(Char)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       mov       rcx,rbx
       mov       edx,1
       call      qword ptr [7FFBBDC0E7B0]; Precode of System.Text.StringBuilder.ExpandByABlock(Int32)
       mov       rax,[rbx+8]
       cmp       dword ptr [rax+8],0
       jbe       short M07_L00
       mov       [rax+10],si
       inc       dword ptr [rbx+18]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M07_L00:
       call      qword ptr [7FFBBDBF3FD8]
       int       3
; Total bytes of code 56
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
       call      00007FFBBDE29F20
       mov       rdi,rax
       cmp       [rdi],dil
       lea       rcx,[rdi+0C]
       mov       r8d,esi
       add       r8,r8
       mov       rdx,rbx
       call      qword ptr [7FFB5E195818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rdi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M08_L00:
       mov       rax,17E24800008
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 88
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderBenchmark.RemoveComparison()
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
       call      qword ptr [7FFB5E7DD818]; System.Text.StringBuilder..ctor(System.String, Int32, Int32, Int32)
       mov       edx,[rsi+1C]
       add       edx,[rsi+18]
       mov       r8,27FF97406C4
       mov       rcx,27FF9730014
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
       call      qword ptr [7FFB5E7D50E0]; System.Text.StringBuilder.Replace(System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>, Int32, Int32)
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFB5E456DE8]; System.Text.StringBuilder.ToString()
       mov       [rsp+50],rax
       mov       rbx,[rbx+60]
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
; Total bytes of code 214
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
       jl        near ptr M01_L02
       test      ebx,ebx
       jl        near ptr M01_L03
       test      ebp,ebp
       jl        near ptr M01_L04
       mov       rdx,27FF9730008
       test      rsi,rsi
       cmove     rsi,rdx
       mov       r15d,[rsi+8]
       mov       edx,r15d
       sub       edx,ebx
       cmp       edx,ebp
       jl        near ptr M01_L05
       mov       dword ptr [rdi+20],7FFFFFFF
       mov       edx,10
       test      r14d,r14d
       cmove     r14d,edx
       cmp       r14d,ebx
       mov       ecx,ebx
       cmovge    ecx,r14d
       cmp       ecx,400
       jge       near ptr M01_L06
       movsxd    rdx,ecx
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
M01_L00:
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
M01_L01:
       cmp       ebx,r8d
       ja        near ptr M01_L09
       lea       r8,[rcx+rcx]
       mov       rcx,rax
       call      qword ptr [7FFB5E1B5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L02:
       mov       ecx,13CC2
       mov       rdx,7FFB5E0F4000
       call      qword ptr [7FFB5E1BF228]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FFB5E7DFE88]
       int       3
M01_L03:
       mov       ecx,0B3
       mov       rdx,7FFB5E0F4000
       call      qword ptr [7FFB5E1BF228]
       mov       rdx,rax
       mov       ecx,ebx
       call      qword ptr [7FFB5E7DFE88]
       int       3
M01_L04:
       mov       ecx,0B8F
       mov       rdx,7FFB5E0F4000
       call      qword ptr [7FFB5E1BF228]
       mov       rdx,rax
       mov       ecx,ebp
       call      qword ptr [7FFB5E7DFE88]
       int       3
M01_L05:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       ecx,0B3
       mov       rdx,7FFB5E0F4000
       call      qword ptr [7FFB5E1BF228]
       mov       rbx,rax
       call      qword ptr [7FFB5E864A20]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rbp
       call      qword ptr [7FFB5E44D9B0]
       mov       rcx,rbp
       call      CORINFO_HELP_THROW
       int       3
M01_L06:
       xor       edx,edx
       call      qword ptr [7FFB5E74F258]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       jmp       near ptr M01_L00
M01_L07:
       mov       ecx,21
       call      qword ptr [7FFB5E1BF360]
       int       3
M01_L08:
       xor       eax,eax
       xor       r8d,r8d
       jmp       near ptr M01_L01
M01_L09:
       call      qword ptr [7FFB5E5CD248]
       int       3
; Total bytes of code 461
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
       mov       rax,0C309D003F711
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
       call      qword ptr [7FFB5E7D50F8]; System.SpanHelpers.IndexOf(Char ByRef, Int32, Char ByRef, Int32)
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
       call      qword ptr [7FFB5E1B5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFB5E1B5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rcx,23F64801D80
       mov       rsi,[rcx]
       mov       ecx,[rbx+8]
       dec       ecx
       or        ecx,0F
       xor       r14d,r14d
       lzcnt     r14d,ecx
       xor       r14d,1F
       add       r14d,0FFFFFFFD
       mov       rcx,gs:[58]
       mov       rcx,[rcx+38]
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
       mov       rcx,23F64800B60
       mov       r12,[rcx]
       cmp       byte ptr [r12+9D],0
       jne       near ptr M02_L92
M02_L35:
       mov       rax,rdi
       mov       r8,0C309D003F711
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
       call      qword ptr [7FFB5E1B5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFB5E74F5B8]; System.Buffers.SharedArrayPool`1[[System.Int32, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
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
       test      byte ptr [7FFB5E891500],1
       je        near ptr M02_L84
M02_L47:
       cmp       byte ptr [7FFB5E0FB17C],0
       je        near ptr M02_L85
       call      qword ptr [7FFB5E865AA0]
       mov       edx,eax
M02_L48:
       test      byte ptr [7FFB5E891390],1
       je        near ptr M02_L87
M02_L49:
       mov       eax,edx
       xor       edx,edx
       div       dword ptr [7FFB5E0FB170]
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
       call      qword ptr [7FFB5E6CE478]; System.Threading.Monitor.Enter(System.Object)
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
       call      qword ptr [7FFB5E1B6820]; System.Threading.Monitor.Exit(System.Object)
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
       mov       rdx,7FFB5E0F4000
       call      qword ptr [7FFB5E1BF228]
       mov       rsi,rax
       call      qword ptr [7FFB5E864648]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFB5E44D9B0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M02_L55:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,28F
       mov       rdx,7FFB5E0F4000
       call      qword ptr [7FFB5E1BF228]
       mov       rsi,rax
       call      qword ptr [7FFB5E864648]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFB5E44D9B0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M02_L56:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFB5E864BA0]
       mov       rsi,rax
       mov       ecx,0BF7
       mov       rdx,7FFB5E0F4000
       call      qword ptr [7FFB5E1BF228]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFB5E5361C0]
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
       call      qword ptr [7FFB5E74F4F8]; System.Collections.Generic.ValueListBuilder`1[[System.Int32, System.Private.CoreLib]].AddWithResize(Int32)
       jmp       near ptr M02_L06
M02_L59:
       mov       rcx,rdi
       call      qword ptr [7FFB5E8659E0]
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
       call      qword ptr [7FFB5E74F4F8]; System.Collections.Generic.ValueListBuilder`1[[System.Int32, System.Private.CoreLib]].AddWithResize(Int32)
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
       call      qword ptr [7FFB5E864BB8]
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
       call      qword ptr [7FFB5E8659E0]
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
       call      qword ptr [7FFB5E8659E0]
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
       call      qword ptr [7FFB5E864780]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M02_L79:
       call      qword ptr [7FFB5E38F228]
       int       3
M02_L80:
       call      qword ptr [7FFB5E5CD248]
       int       3
M02_L81:
       mov       ecx,7
       call      qword ptr [7FFB5E8640C0]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M02_L32
M02_L82:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFB5E865A70]
       mov       rbx,rax
       mov       ecx,29B
       mov       rdx,7FFB5E0F4000
       call      qword ptr [7FFB5E1BF228]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FFB5E5361C0]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M02_L83:
       mov       rcx,rsi
       mov       edx,r14d
       call      qword ptr [7FFB5E865A88]
       jmp       near ptr M02_L46
M02_L84:
       mov       rcx,offset MT_System.Threading.ProcessorIdCache
       call      qword ptr [7FFB5E1B5740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M02_L47
M02_L85:
       mov       ecx,0A
       call      qword ptr [7FFB5E865AB8]
       mov       eax,[rax+10]
       mov       [rbp+74],eax
       mov       ecx,0A
       call      qword ptr [7FFB5E865AB8]
       mov       edx,[rbp+74]
       lea       ecx,[rdx-1]
       mov       [rax+10],ecx
       movzx     eax,dx
       test      eax,eax
       jne       short M02_L86
       call      qword ptr [7FFB5E865AD0]
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
       call      qword ptr [7FFB5E1B5740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
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
       call      qword ptr [7FFB5E5CD8F0]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rbp+84],eax
       mov       edx,[rbx+8]
       mov       [rbp+80],edx
       mov       rcx,rsi
       call      qword ptr [7FFB5E5CD8F0]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,r12
       mov       r8d,[rbp+84]
       mov       r9d,[rbp+80]
       mov       edx,3
       call      qword ptr [7FFB5E8648A0]
       test      r13d,r15d
       jne       near ptr M02_L35
       mov       rcx,rbx
       call      qword ptr [7FFB5E5CD8F0]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r13d,eax
       mov       ebx,[rbx+8]
       mov       rcx,rsi
       call      qword ptr [7FFB5E5CD8F0]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
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
       call      qword ptr [7FFB5E865AE8]
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
       call      00007FFBBDE29F20
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
       call      qword ptr [7FFB5E1B5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,27FF9730008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M03_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,19655
       mov       rdx,7FFB5E0F4000
       call      qword ptr [7FFB5E1BF228]
       mov       rbx,rax
       call      qword ptr [7FFB5E864648]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB5E44D9B0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 201
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rsi,[rbx+138]
       test      rsi,rsi
       je        near ptr M00_L60
       mov       ecx,[rsi+8]
       test      ecx,ecx
       setg      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M00_L60
       mov       rcx,25604C00188
       mov       rdi,[rcx]
       mov       r14,rdi
       mov       rcx,[r14+20]
       mov       [rbp-40],rcx
       cmp       qword ptr [rbp-40],0
       je        near ptr M00_L62
       lea       rcx,[r14+20]
       mov       r8,[rbp-40]
       test      rcx,rcx
       je        near ptr M00_L61
       xor       edx,edx
       call      00007FFBBDDCCC60
       cmp       rax,[rbp-40]
       jne       near ptr M00_L62
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
       jo        near ptr M00_L66
M00_L03:
       add       r8,8
       dec       eax
       jne       short M00_L02
M00_L04:
       mov       r15d,ecx
       cmp       [r14],r14b
       test      r15d,r15d
       jl        near ptr M00_L64
       mov       rcx,[r14+8]
       mov       ecx,[rcx+8]
       add       ecx,[r14+1C]
       cmp       ecx,r15d
       jl        near ptr M00_L65
M00_L05:
       mov       r8,[r14+8]
       mov       r8d,[r8+8]
       mov       [rbp-0C8],r14
       mov       r8,255EEC00180
       mov       r15,[r8]
       lea       r14,[rsi+10]
       mov       esi,[rsi+8]
       xor       r8d,r8d
       mov       [rbp-48],r8d
       jmp       near ptr M00_L14
M00_L06:
       mov       rdx,offset MT_System.String
       cmp       [r10],rdx
       jne       near ptr M00_L40
       xor       r10d,r10d
M00_L07:
       mov       [rbp-0D8],r10
       test      r10,r10
       jne       near ptr M00_L41
M00_L08:
       mov       r10,rax
       test      r10,r10
       je        short M00_L09
       mov       rdx,offset MT_System.String
       cmp       [r10],rdx
       jne       near ptr M00_L42
       xor       r10d,r10d
M00_L09:
       mov       rdx,r10
       mov       [rbp-0E0],rdx
       test      rdx,rdx
       jne       near ptr M00_L19
       test      rax,rax
       je        near ptr M00_L44
       mov       rcx,offset MT_System.String
       cmp       [rax],rcx
       jne       near ptr M00_L45
M00_L10:
       mov       r13,rax
M00_L11:
       test      r13,r13
       je        near ptr M00_L46
M00_L12:
       cmp       [r13+8],r12d
       jl        near ptr M00_L47
M00_L13:
       mov       rcx,[rbp-0C8]
       mov       rdx,r13
       call      qword ptr [7FFB5E427228]; System.Text.StringBuilder.Append(System.String)
M00_L14:
       cmp       dword ptr [rbp-48],1F
       jae       near ptr M00_L21
       mov       r8d,[rbp-48]
       mov       r13,29683CE0708
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
       call      qword ptr [7FFB5E42C648]; System.PackedSpanHelpers.IndexOfAny[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib],[System.PackedSpanHelpers+NopTransform, System.Private.CoreLib]](Int16 ByRef, Int16, Int16, Int32)
       mov       [rbp-98],eax
       test      eax,eax
       jl        near ptr M00_L49
       cmp       eax,[rbp-0AC]
       ja        near ptr M00_L50
       test      eax,eax
       je        short M00_L16
       mov       rdx,[rbp-0C8]
       mov       r8,[rdx+8]
       mov       r10d,[rdx+18]
       mov       [rbp-9C],r10d
       lea       ecx,[r10+rax]
       cmp       ecx,[r8+8]
       ja        near ptr M00_L24
       movsxd    rcx,r10d
       lea       rcx,[r8+rcx*2+10]
       cmp       eax,2
       jle       near ptr M00_L22
       mov       r8d,eax
       add       r8,r8
       mov       rdx,r12
       call      qword ptr [7FFB5E195818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       jae       near ptr M00_L57
       mov       edx,[rbp-48]
       movzx     edx,word ptr [r13+rdx*2+0C]
       mov       ecx,[rbp-48]
       inc       ecx
       mov       [rbp-48],ecx
       cmp       dword ptr [rbp-48],1F
       jae       near ptr M00_L53
       cmp       dword ptr [rbp-48],1F
       jae       near ptr M00_L57
       mov       ecx,[rbp-48]
       movzx     eax,word ptr [r13+rcx*2+0C]
       cmp       edx,eax
       je        near ptr M00_L25
       cmp       edx,7B
       jne       near ptr M00_L51
       xor       r12d,r12d
       xor       r8d,r8d
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-60],xmm0
       lea       r10d,[rax-30]
       cmp       r10d,0A
       jae       near ptr M00_L52
       mov       eax,[rbp-48]
       inc       eax
       mov       [rbp-48],eax
       cmp       dword ptr [rbp-48],1F
       jae       near ptr M00_L53
       cmp       dword ptr [rbp-48],1F
       jae       near ptr M00_L57
       mov       edx,[rbp-48]
       movzx     eax,word ptr [r13+rdx*2+0C]
       cmp       eax,7D
       jne       near ptr M00_L26
M00_L17:
       mov       edx,[rbp-48]
       inc       edx
       mov       [rbp-48],edx
       xor       r13d,r13d
       cmp       r10d,esi
       jae       near ptr M00_L55
       cmp       r10d,esi
       jae       near ptr M00_L57
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
       jmp       near ptr M00_L06
M00_L19:
       mov       rdx,[rbp-0E0]
       cmp       dword ptr [rbp-58],0
       jne       near ptr M00_L43
M00_L20:
       mov       rcx,rdx
       mov       r8,r15
       mov       rdx,r13
       mov       r11,7FFB5E0E0B68
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M00_L11
M00_L21:
       mov       rcx,[rbp-0C8]
       call      qword ptr [7FFB5E436DE8]; System.Text.StringBuilder.ToString()
       mov       rsi,rax
       jmp       near ptr M00_L58
M00_L22:
       movzx     r8d,word ptr [r12]
       mov       [rcx],r8w
       cmp       eax,2
       jne       short M00_L23
       movzx     r8d,word ptr [r12+2]
       mov       [rcx+2],r8w
       jmp       near ptr M00_L15
M00_L23:
       jmp       near ptr M00_L15
M00_L24:
       mov       rdx,[rbp-0C8]
       mov       rcx,rdx
       mov       rdx,r12
       mov       r8d,eax
       call      qword ptr [7FFB5E4271E0]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       mov       eax,[rbp-98]
       jmp       near ptr M00_L16
M00_L25:
       mov       rcx,[rbp-0C8]
       mov       edx,eax
       call      qword ptr [7FFB5E427180]; System.Text.StringBuilder.Append(Char)
       mov       ecx,[rbp-48]
       inc       ecx
       mov       [rbp-48],ecx
       jmp       near ptr M00_L14
M00_L26:
       lea       edx,[rax-30]
       cmp       edx,9
       ja        short M00_L29
       jmp       short M00_L28
M00_L27:
       lea       r10d,[r10+r10*4]
       lea       r10d,[rax+r10*2-30]
       mov       [rbp-64],r10d
       mov       eax,[rbp-48]
       inc       eax
       mov       [rbp-48],eax
       cmp       dword ptr [rbp-48],1F
       jae       near ptr M00_L53
       cmp       dword ptr [rbp-48],1F
       jae       near ptr M00_L57
       mov       edx,[rbp-48]
       movzx     eax,word ptr [r13+rdx*2+0C]
       mov       r10d,[rbp-64]
       jmp       short M00_L26
M00_L28:
       cmp       r10d,0F4240
       jl        short M00_L27
M00_L29:
       cmp       eax,20
       jne       short M00_L30
       mov       eax,[rbp-48]
       inc       eax
       mov       [rbp-48],eax
       cmp       dword ptr [rbp-48],1F
       jae       near ptr M00_L53
       cmp       dword ptr [rbp-48],1F
       jae       near ptr M00_L57
       mov       edx,[rbp-48]
       movzx     eax,word ptr [r13+rdx*2+0C]
       jmp       short M00_L29
M00_L30:
       cmp       eax,2C
       jne       near ptr M00_L37
M00_L31:
       mov       eax,[rbp-48]
       inc       eax
       mov       [rbp-48],eax
       cmp       dword ptr [rbp-48],1F
       jae       near ptr M00_L53
       cmp       dword ptr [rbp-48],1F
       jae       near ptr M00_L57
       mov       edx,[rbp-48]
       movzx     eax,word ptr [r13+rdx*2+0C]
       cmp       eax,20
       je        short M00_L31
       cmp       eax,2D
       jne       short M00_L32
       mov       dword ptr [rbp-4C],1
       mov       eax,[rbp-48]
       inc       eax
       mov       [rbp-48],eax
       cmp       dword ptr [rbp-48],1F
       jae       near ptr M00_L53
       cmp       dword ptr [rbp-48],1F
       jae       near ptr M00_L57
       mov       edx,[rbp-48]
       movzx     eax,word ptr [r13+rdx*2+0C]
       mov       r8d,[rbp-4C]
M00_L32:
       lea       r12d,[rax-30]
       cmp       r12d,0A
       mov       [rbp-64],r10d
       mov       [rbp-4C],r8d
       jb        short M00_L34
       jmp       near ptr M00_L52
M00_L33:
       lea       edx,[r12+r12*4]
       lea       r12d,[rax+rdx*2-30]
M00_L34:
       lea       rdx,[rbp-48]
       mov       rcx,r13
       call      qword ptr [7FFB5E83D5C0]
       lea       edx,[rax-30]
       cmp       edx,9
       ja        short M00_L35
       cmp       r12d,0F4240
       jl        short M00_L33
M00_L35:
       cmp       eax,20
       je        short M00_L36
       mov       r8d,[rbp-4C]
       mov       r10d,[rbp-64]
       jmp       short M00_L37
M00_L36:
       mov       eax,[rbp-48]
       inc       eax
       mov       [rbp-48],eax
       cmp       dword ptr [rbp-48],1F
       jae       near ptr M00_L53
       cmp       dword ptr [rbp-48],1F
       jae       near ptr M00_L57
       mov       edx,[rbp-48]
       movzx     eax,word ptr [r13+rdx*2+0C]
       jmp       short M00_L35
M00_L37:
       cmp       eax,7D
       je        near ptr M00_L17
       cmp       eax,3A
       jne       near ptr M00_L54
       mov       r9d,[rbp-48]
       mov       [rbp-94],r9d
       mov       [rbp-64],r10d
       mov       [rbp-4C],r8d
M00_L38:
       lea       rdx,[rbp-48]
       mov       rcx,r13
       call      qword ptr [7FFB5E83D5C0]
       cmp       eax,7D
       je        short M00_L39
       cmp       eax,7B
       jne       short M00_L38
       jmp       near ptr M00_L54
M00_L39:
       mov       r9d,[rbp-94]
       inc       r9d
       mov       ecx,[rbp-48]
       mov       [rbp-94],r9d
       sub       ecx,r9d
       mov       r9d,ecx
       lea       rcx,[rbp-60]
       mov       r8d,[rbp-94]
       mov       rdx,r13
       call      qword ptr [7FFB5E83D5D8]
       mov       r8d,[rbp-4C]
       mov       r10d,[rbp-64]
       jmp       near ptr M00_L17
M00_L40:
       mov       rdx,rax
       mov       rcx,offset MT_System.ISpanFormattable
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       r10,rax
       mov       rax,[rbp-0D0]
       jmp       near ptr M00_L07
M00_L41:
       lea       rdx,[rbp-80]
       mov       rcx,[rbp-0C8]
       call      qword ptr [7FFB5E83D5F0]
       vmovdqu   xmm0,xmmword ptr [rbp-60]
       vmovdqu   xmmword ptr [rbp-0C0],xmm0
       mov       [rsp+20],r15
       lea       r9,[rbp-0C0]
       lea       r8,[rbp-70]
       lea       rdx,[rbp-80]
       mov       rcx,[rbp-0D8]
       mov       r11,7FFB5E0E0B70
       call      qword ptr [r11]
       test      eax,eax
       mov       rax,[rbp-0D0]
       je        near ptr M00_L08
       mov       r13d,[rbp-70]
       lea       rdx,[rbp-90]
       mov       rcx,[rbp-0C8]
       call      qword ptr [7FFB5E83D5F0]
       cmp       r13d,[rbp-88]
       ja        near ptr M00_L56
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
       call      qword ptr [7FFB5E837C00]
       jmp       near ptr M00_L14
M00_L42:
       mov       rdx,rax
       mov       rcx,offset MT_System.IFormattable
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       r10,rax
       mov       rax,[rbp-0D0]
       jmp       near ptr M00_L09
M00_L43:
       vmovdqu   xmm0,xmmword ptr [rbp-60]
       vmovdqu   xmmword ptr [rbp-0C0],xmm0
       lea       rcx,[rbp-0C0]
       call      System.String.Ctor(System.ReadOnlySpan`1<Char>)
       mov       r13,rax
       mov       rdx,[rbp-0E0]
       jmp       near ptr M00_L20
M00_L44:
       xor       r13d,r13d
       jmp       near ptr M00_L11
M00_L45:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       jmp       near ptr M00_L10
M00_L46:
       mov       r13,29683CD0008
       jmp       near ptr M00_L12
M00_L47:
       cmp       dword ptr [rbp-4C],0
       je        short M00_L48
       mov       rcx,[rbp-0C8]
       mov       rdx,r13
       call      qword ptr [7FFB5E427228]; System.Text.StringBuilder.Append(System.String)
       mov       r8d,r12d
       sub       r8d,[r13+8]
       mov       rcx,[rbp-0C8]
       mov       edx,20
       call      qword ptr [7FFB5E837C00]
       jmp       near ptr M00_L14
M00_L48:
       mov       r8d,r12d
       sub       r8d,[r13+8]
       mov       rcx,[rbp-0C8]
       mov       edx,20
       call      qword ptr [7FFB5E837C00]
       jmp       near ptr M00_L13
M00_L49:
       mov       [rbp-0C0],r12
       mov       esi,[rbp-0AC]
       mov       [rbp-0B8],esi
       lea       rdx,[rbp-0C0]
       mov       rcx,[rbp-0C8]
       call      qword ptr [7FFB5E83D608]
       jmp       near ptr M00_L21
M00_L50:
       call      qword ptr [7FFB5E36F228]
       int       3
M00_L51:
       mov       ecx,[rbp-48]
       mov       edx,4B
       call      qword ptr [7FFB5E837F60]
       int       3
M00_L52:
       mov       ecx,[rbp-48]
       mov       edx,4D
       call      qword ptr [7FFB5E837F60]
       int       3
M00_L53:
       mov       ecx,[rbp-48]
       mov       edx,4C
       call      qword ptr [7FFB5E837F60]
       int       3
M00_L54:
       mov       ecx,[rbp-48]
       mov       edx,4C
       call      qword ptr [7FFB5E837F60]
       int       3
M00_L55:
       call      qword ptr [7FFB5E837F78]
       int       3
M00_L56:
       call      qword ptr [7FFB5E837F90]
       int       3
M00_L57:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L58:
       mov       rcx,[rbp-0C8]
       xor       edx,edx
       call      qword ptr [7FFB5E7B59B0]; System.Text.StringBuilder.set_Length(Int32)
       mov       rcx,rdi
       mov       rdx,[rbp-0C8]
       call      qword ptr [7FFB5E7B59C8]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].ReturnCore(System.__Canon)
M00_L59:
       mov       [rbp-0A8],rsi
       mov       rcx,[rbx+60]
       lea       r8,[rbp-0A8]
       mov       rdx,7FFB5E80C3A0
       cmp       [rcx],ecx
       call      qword ptr [7FFB5E7BDE90]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
M00_L60:
       mov       rsi,29683CD0008
       jmp       short M00_L59
M00_L61:
       call      qword ptr [7FFB5E8376C0]
       int       3
M00_L62:
       mov       rcx,[r14+18]
       lea       rdx,[rbp-40]
       cmp       [rcx],ecx
       call      qword ptr [7FFB5E7B5890]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M00_L63
       add       r14,2C
       lock dec  dword ptr [r14]
       jmp       near ptr M00_L00
M00_L63:
       mov       rax,[r14+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r14,rax
       jmp       near ptr M00_L01
M00_L64:
       mov       ecx,13CC2
       mov       rdx,7FFB5E0D4000
       call      qword ptr [7FFB5E19F228]
       mov       rdx,rax
       mov       ecx,r15d
       call      qword ptr [7FFB5E834210]
       int       3
M00_L65:
       mov       rcx,r14
       mov       edx,r15d
       call      qword ptr [7FFB5E837D08]
       jmp       near ptr M00_L05
M00_L66:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       mov       rcx,[rbp-0C8]
       cmp       [rcx],cl
       xor       edx,edx
       call      qword ptr [7FFB5E7B59B0]; System.Text.StringBuilder.set_Length(Int32)
       mov       rcx,25604C00188
       mov       rdi,[rcx]
       mov       rcx,rdi
       mov       rdx,[rbp-0C8]
       call      qword ptr [7FFB5E7B59C8]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].ReturnCore(System.__Canon)
       nop
       add       rsp,28
       ret
; Total bytes of code 2328
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
       call      qword ptr [7FFB5E195818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFB5E4271E0]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       jmp       qword ptr [7FFB5E1966E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      00007FFBBDE29F20
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
       call      qword ptr [7FFB5E195818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,29683CD0008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,19655
       mov       rdx,7FFB5E0D4000
       call      qword ptr [7FFB5E19F228]
       mov       rbx,rax
       call      qword ptr [7FFB5E837AF8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB5E42E700]
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
       jg        near ptr M05_L05
       cmp       eax,esi
       jl        near ptr M05_L05
       mov       rax,[rbx+8]
       mov       ebp,[rax+8]
       sub       ebp,ecx
       test      ebp,ebp
       jg        near ptr M05_L03
M05_L00:
       sub       esi,ebp
       mov       edx,[rbx+1C]
       lea       ecx,[rsi+rdx]
       mov       eax,[rbx+18]
       add       ecx,eax
       cmp       ecx,[rbx+20]
       jg        near ptr M05_L08
       cmp       ecx,esi
       jl        near ptr M05_L08
       add       edx,eax
       mov       ecx,edx
       mov       eax,1F40
       cmp       ecx,1F40
       cmovg     ecx,eax
       cmp       esi,ecx
       cmovge    ecx,esi
       add       edx,ecx
       cmp       edx,ecx
       jl        near ptr M05_L09
       cmp       ecx,400
       jge       near ptr M05_L10
       movsxd    rdx,ecx
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
M05_L01:
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
M05_L02:
       cmp       esi,r8d
       ja        near ptr M05_L12
       mov       r8d,esi
       add       r8,r8
       call      qword ptr [7FFB5E195818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       [rbx+18],esi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M05_L03:
       mov       rax,[rbx+8]
       test      rax,rax
       je        near ptr M05_L06
       mov       edx,[rax+8]
       cmp       edx,ecx
       jb        near ptr M05_L07
       mov       r8d,ecx
       lea       rax,[rax+r8*2+10]
       sub       edx,ecx
M05_L04:
       cmp       ebp,edx
       ja        near ptr M05_L12
       mov       r8d,ebp
       add       r8,r8
       mov       rcx,rax
       mov       rdx,rdi
       call      qword ptr [7FFB5E195818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rdx,[rbx+8]
       mov       edx,[rdx+8]
       mov       [rbx+18],edx
       jmp       near ptr M05_L00
M05_L05:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,19685
       mov       rdx,7FFB5E0D4000
       call      qword ptr [7FFB5E19F228]
       mov       rsi,rax
       call      qword ptr [7FFB5E83C078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFB5E42E700]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M05_L06:
       test      ecx,ecx
       jne       short M05_L07
       xor       eax,eax
       xor       edx,edx
       jmp       short M05_L04
M05_L07:
       call      qword ptr [7FFB5E36F228]
       int       3
M05_L08:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,1969B
       mov       rdx,7FFB5E0D4000
       call      qword ptr [7FFB5E19F228]
       mov       rsi,rax
       call      qword ptr [7FFB5E837BE8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFB5E42E700]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M05_L09:
       mov       rcx,offset MT_System.OutOfMemoryException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB5E83C090]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M05_L10:
       xor       edx,edx
       call      qword ptr [7FFB5E72F6C0]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       r14,rax
       jmp       near ptr M05_L01
M05_L11:
       xor       ecx,ecx
       xor       r8d,r8d
       jmp       near ptr M05_L02
M05_L12:
       call      qword ptr [7FFB5E5BDFC8]
       int       3
; Total bytes of code 631
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
       call      qword ptr [7FFB5E4273A8]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M06_L00
; Total bytes of code 60
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rdx,rdx
       je        short M07_L05
       mov       rax,[rdx]
       movzx     r8d,word ptr [rax+0E]
       test      r8,r8
       je        short M07_L04
       mov       r10,[rax+38]
       cmp       r8,4
       jl        short M07_L02
       cmp       [r10],rcx
       je        short M07_L05
M07_L00:
       cmp       [r10+8],rcx
       je        short M07_L05
       cmp       [r10+10],rcx
       je        short M07_L05
       cmp       [r10+18],rcx
       je        short M07_L05
       add       r10,20
       add       r8,0FFFFFFFFFFFFFFFC
       cmp       r8,4
       jl        short M07_L01
       cmp       [r10],rcx
       je        short M07_L05
       jmp       short M07_L00
M07_L01:
       test      r8,r8
       je        short M07_L04
M07_L02:
       cmp       [r10],rcx
       je        short M07_L05
M07_L03:
       add       r10,8
       dec       r8
       test      r8,r8
       jg        short M07_L06
M07_L04:
       test      dword ptr [rax],500C0000
       jne       short M07_L07
       xor       edx,edx
M07_L05:
       mov       rax,rdx
       ret
M07_L06:
       cmp       [r10],rcx
       je        short M07_L05
       jmp       short M07_L03
M07_L07:
       jmp       qword ptr [7FFB5E51E5F8]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
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
       call      00007FFBBDE29F20
       mov       rdi,rax
       cmp       [rdi],dil
       lea       rcx,[rdi+0C]
       mov       r8d,esi
       add       r8,r8
       mov       rdx,rbx
       call      qword ptr [7FFB5E195818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rdi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M08_L00:
       mov       rax,29683CD0008
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 88
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
       mov       rdx,7FFB5E0D4000
       call      qword ptr [7FFB5E19F228]
       mov       rdx,rax
       mov       ecx,esi
       call      qword ptr [7FFB5E834210]
       int       3
M09_L02:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FFB5E0D4000
       call      qword ptr [7FFB5E19F228]
       mov       rsi,rax
       call      qword ptr [7FFB5E837BE8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFB5E42E700]
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
       call      qword ptr [7FFB5E837C00]
       jmp       near ptr M09_L00
M09_L04:
       mov       rcx,rbx
       mov       edx,esi
       call      qword ptr [7FFB5E837C18]
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
       call      qword ptr [7FFB5E72F6C0]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       rbp,rax
M09_L06:
       mov       rcx,[rdi+8]
       mov       r8d,[rdi+18]
       mov       rdx,rbp
       call      qword ptr [7FFB5E19F5A0]; System.Array.Copy(System.Array, System.Array, Int32)
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
       jne       near ptr M10_L10
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       add       ecx,[rbx+1C]
       mov       rdx,[rdi+8]
       cmp       ecx,[rdx+0C]
       jg        near ptr M10_L11
       cmp       dword ptr [rbx+20],0
       jl        short M10_L02
       cmp       qword ptr [rbx+10],0
       jne       near ptr M10_L03
       xor       ecx,ecx
       mov       [rbx+18],rcx
M10_L00:
       cmp       qword ptr [rsi+20],0
       jne       near ptr M10_L13
       lea       rcx,[rsi+20]
       test      rcx,rcx
       je        near ptr M10_L12
       mov       rdx,rbx
       xor       r8d,r8d
       call      00007FFBBDDCCC60
       test      rax,rax
       jne       near ptr M10_L13
M10_L01:
       mov       eax,1
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M10_L02:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FFB5E0D4000
       call      qword ptr [7FFB5E19F228]
       mov       rsi,rax
       call      qword ptr [7FFB5E837BE8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFB5E42E700]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M10_L03:
       mov       ecx,[rbx+1C]
       add       ecx,[rbx+18]
       mov       r8d,ecx
       neg       r8d
       test      r8d,r8d
       jle       short M10_L04
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFB5E837C00]
       jmp       near ptr M10_L00
M10_L04:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFB5E837C18]
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
       call      qword ptr [7FFB5E72F6C0]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       rbp,rax
M10_L06:
       mov       rcx,[rdi+8]
       mov       r8d,[rdi+18]
       mov       rdx,rbp
       call      qword ptr [7FFB5E19F5A0]; System.Array.Copy(System.Array, System.Array, Int32)
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
       mov       ecx,[rdi+1C]
       neg       ecx
       mov       [rbx+18],ecx
       jmp       near ptr M10_L00
M10_L10:
       mov       rdx,rbx
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       test      eax,eax
       jne       near ptr M10_L00
M10_L11:
       xor       eax,eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M10_L12:
       call      qword ptr [7FFB5E8376C0]
       int       3
M10_L13:
       lea       rcx,[rsi+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[rsi+28]
       jg        short M10_L14
       mov       rcx,[rsi+18]
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FFB5E83D620]
       jmp       near ptr M10_L01
M10_L14:
       add       rsi,2C
       lock dec  dword ptr [rsi]
       jmp       short M10_L11
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
       call      qword ptr [7FFBBDC19A58]; Precode of System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M12_L00
       mov       eax,1
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M12_L00:
       cmp       qword ptr [rdi+10],0
       jne       short M12_L01
       xor       eax,eax
       mov       [rbx],rax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M12_L01:
       mov       rcx,rsi
       mov       rdx,rbx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax]
; Total bytes of code 91
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderBenchmark.Remove()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+70]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-50],ymm4
       mov       [rbp+10],rcx
       mov       rbx,[rcx+30]
       test      rbx,rbx
       je        near ptr M00_L24
       mov       esi,[rbx+8]
       test      esi,esi
       je        near ptr M00_L24
       mov       r8,26439400170
       mov       rdi,[r8]
       mov       r8,[rdi+20]
       mov       [rbp-38],r8
       cmp       qword ptr [rbp-38],0
       je        near ptr M00_L26
       lea       r8,[rdi+20]
       mov       rdx,[rbp-38]
       test      r8,r8
       je        near ptr M00_L25
       mov       rcx,r8
       mov       r8,rdx
       xor       edx,edx
       call      00007FFBBDDCCC60
       cmp       rax,[rbp-38]
       jne       near ptr M00_L26
M00_L00:
       mov       rdi,[rbp-38]
M00_L01:
       xor       ecx,ecx
       mov       [rbp-38],rcx
       mov       [rbp-48],rdi
       xor       edi,edi
       jmp       near ptr M00_L06
M00_L02:
       mov       r14d,eax
M00_L03:
       cmp       r14d,0FFFFFFFF
       je        near ptr M00_L07
       mov       r15d,r14d
       sub       r15d,edi
       jo        near ptr M00_L20
       mov       r13,[rbp-48]
       cmp       [r13],r13b
       test      edi,edi
       jl        near ptr M00_L16
       test      r15d,r15d
       jl        near ptr M00_L12
       test      r15d,r15d
       je        short M00_L05
       mov       r8d,esi
       sub       r8d,r15d
       cmp       r8d,edi
       jl        near ptr M00_L13
       mov       r8d,edi
       lea       rdx,[rbx+r8*2+0C]
       mov       r8,[r13+8]
       mov       edi,[r13+18]
       lea       ecx,[rdi+r15]
       cmp       ecx,[r8+8]
       ja        near ptr M00_L11
       movsxd    rcx,edi
       lea       rcx,[r8+rcx*2+10]
       cmp       r15d,2
       jle       near ptr M00_L10
       mov       r8d,r15d
       add       r8,r8
       call      qword ptr [7FFB5E195818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L04:
       add       r15d,edi
       mov       [r13+18],r15d
M00_L05:
       mov       edi,r14d
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
       mov       ecx,edi
       lea       rcx,[rbx+rcx*2+0C]
       mov       r8,2A4B84E0714
       mov       r9d,3
       call      qword ptr [7FFB5E7B50F8]; System.SpanHelpers.IndexOf(Char ByRef, Int32, Char ByRef, Int32)
       test      eax,eax
       jl        near ptr M00_L02
       lea       r14d,[rax+rdi]
       jmp       near ptr M00_L03
M00_L07:
       cmp       esi,edi
       jle       short M00_L09
       mov       r14d,esi
       sub       r14d,edi
       jo        near ptr M00_L20
       mov       r13,[rbp-48]
       cmp       [r13],r13b
       test      edi,edi
       jl        near ptr M00_L16
       test      r14d,r14d
       jl        near ptr M00_L17
       test      r14d,r14d
       je        short M00_L09
       sub       esi,r14d
       cmp       esi,edi
       jl        near ptr M00_L18
       mov       r8d,edi
       lea       rdx,[rbx+r8*2+0C]
       mov       r8,[r13+8]
       mov       edi,[r13+18]
       lea       ecx,[rdi+r14]
       cmp       ecx,[r8+8]
       ja        near ptr M00_L21
       movsxd    rcx,edi
       lea       rcx,[r8+rcx*2+10]
       cmp       r14d,2
       jle       near ptr M00_L19
       mov       r8d,r14d
       add       r8,r8
       call      qword ptr [7FFB5E195818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L08:
       add       r14d,edi
       mov       [r13+18],r14d
M00_L09:
       mov       r13,[rbp-48]
       mov       rcx,r13
       cmp       [rcx],ecx
       call      qword ptr [7FFB5E43CA60]; System.Text.StringBuilder.ToString()
       mov       [rbp-50],rax
       jmp       near ptr M00_L22
M00_L10:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       r15d,2
       jne       near ptr M00_L04
       movzx     edx,word ptr [rdx+2]
       mov       [rcx+2],dx
       jmp       near ptr M00_L04
M00_L11:
       mov       rcx,r13
       mov       r8d,r15d
       call      qword ptr [7FFB5E427AB0]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M00_L05
M00_L12:
       mov       ecx,28F
       mov       rdx,7FFB5E0D4000
       call      qword ptr [7FFB5E19F228]
       mov       rdx,rax
       mov       ecx,r15d
       call      qword ptr [7FFB5E7BFEA0]
       int       3
M00_L13:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       ecx,0B8F
       mov       rdx,7FFB5E0D4000
       call      qword ptr [7FFB5E19F228]
       mov       rsi,rax
       call      qword ptr [7FFB5E844678]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,r15
       call      qword ptr [7FFB5E42D9B0]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
       int       3
M00_L14:
       cmp       esi,edi
       jae       short M00_L15
       mov       ecx,8
       xor       edx,edx
       call      qword ptr [7FFB5E726718]
       int       3
M00_L15:
       mov       ecx,1B
       mov       edx,4
       call      qword ptr [7FFB5E726718]
       int       3
M00_L16:
       mov       ecx,0B8F
       mov       rdx,7FFB5E0D4000
       call      qword ptr [7FFB5E19F228]
       mov       rdx,rax
       mov       ecx,edi
       call      qword ptr [7FFB5E7BFEA0]
       int       3
M00_L17:
       mov       ecx,28F
       mov       rdx,7FFB5E0D4000
       call      qword ptr [7FFB5E19F228]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FFB5E7BFEA0]
       int       3
M00_L18:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       ecx,0B8F
       mov       rdx,7FFB5E0D4000
       call      qword ptr [7FFB5E19F228]
       mov       rbx,rax
       call      qword ptr [7FFB5E844678]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,r14
       call      qword ptr [7FFB5E42D9B0]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
       int       3
M00_L19:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       r14d,2
       jne       near ptr M00_L08
       movzx     edx,word ptr [rdx+2]
       mov       [rcx+2],dx
       jmp       near ptr M00_L08
M00_L20:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L21:
       mov       rcx,r13
       mov       r8d,r14d
       call      qword ptr [7FFB5E427AB0]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M00_L09
M00_L22:
       call      M00_L28
       nop
       mov       r13,[rbp-50]
M00_L23:
       mov       [rbp-40],r13
       mov       rcx,[rbp+10]
       mov       rbx,[rcx+60]
       mov       rdx,[rbp-40]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L24:
       mov       rdx,2A4B84D0008
       test      rbx,rbx
       cmove     rbx,rdx
       mov       r13,rbx
       jmp       short M00_L23
M00_L25:
       call      qword ptr [7FFB5E844660]
       int       3
M00_L26:
       mov       rcx,[rdi+18]
       lea       rdx,[rbp-38]
       cmp       [rcx],ecx
       call      qword ptr [7FFB5E7B5020]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
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
       mov       r13,[rbp-48]
       cmp       dword ptr [r13+20],0
       jge       short M00_L29
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       ecx,3AD
       mov       rdx,7FFB5E0D4000
       call      qword ptr [7FFB5E19F228]
       mov       rbx,rax
       call      qword ptr [7FFB5E8447B0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,r13
       call      qword ptr [7FFB5E42D9B0]
       mov       rcx,r13
       call      CORINFO_HELP_THROW
       int       3
M00_L29:
       cmp       qword ptr [r13+10],0
       jne       short M00_L30
       xor       ecx,ecx
       mov       [r13+18],rcx
       jmp       near ptr M00_L37
M00_L30:
       mov       ecx,[r13+1C]
       add       ecx,[r13+18]
       mov       r8d,ecx
       neg       r8d
       test      r8d,r8d
       jle       short M00_L31
       mov       rcx,r13
       xor       edx,edx
       call      qword ptr [7FFB5E844BA0]
       jmp       near ptr M00_L37
M00_L31:
       mov       rcx,r13
       xor       edx,edx
       call      qword ptr [7FFB5E844BB8]
       mov       rbx,rax
       cmp       rbx,r13
       je        near ptr M00_L36
       mov       rax,[r13+8]
       mov       ecx,[rax+8]
       add       ecx,[r13+1C]
       mov       eax,[r13+1C]
       add       eax,[r13+18]
       lea       edx,[rax+rax*2]
       add       edx,edx
       mov       r8d,66666667
       mov       eax,r8d
       imul      edx
       mov       eax,edx
       shr       eax,1F
       sar       edx,1
       add       edx,eax
       mov       rax,[r13+8]
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
       call      qword ptr [7FFB5E72F258]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       rsi,rax
M00_L33:
       mov       rcx,[rbx+8]
       mov       r8d,[rbx+18]
       mov       rdx,rsi
       call      qword ptr [7FFB5E19F5A0]; System.Array.Copy(System.Array, System.Array, Int32)
       lea       rcx,[r13+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M00_L35
M00_L34:
       mov       rdx,[rbx+8]
       lea       rcx,[r13+8]
       call      CORINFO_HELP_ASSIGN_REF
M00_L35:
       mov       rdx,[rbx+10]
       lea       rcx,[r13+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rbx+1C]
       mov       [r13+1C],ecx
M00_L36:
       mov       ecx,[rbx+1C]
       neg       ecx
       mov       [r13+18],ecx
M00_L37:
       mov       rdx,26439400170
       mov       rbx,[rdx]
       mov       rax,[rbx+10]
       mov       rdx,r13
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
       call      qword ptr [7FFB5E844660]
       int       3
M00_L40:
       mov       rdx,r13
       xor       r8d,r8d
       call      00007FFBBDDCCC60
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
       mov       rdx,r13
       cmp       [rcx],ecx
       call      qword ptr [7FFB5E844C60]
       test      eax,eax
       jne       short M00_L38
       mov       rcx,rbx
       mov       rdx,r13
       call      qword ptr [7FFB5E844C78]
       jmp       short M00_L38
M00_L42:
       add       rbx,2C
       lock dec  dword ptr [rbx]
       jmp       short M00_L38
; Total bytes of code 1526
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
       jmp       qword ptr [7FFB5E1966E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
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
       jmp       qword ptr [7FFB5E424108]; System.PackedSpanHelpers.IndexOf[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib],[System.PackedSpanHelpers+NopTransform, System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
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
       jmp       qword ptr [7FFB5E197288]; System.SpanHelpers.NonPackedIndexOfValueType[[System.Int16, System.Private.CoreLib],[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
M02_L14:
       add       rdi,2
       test      r13d,r13d
       jle       near ptr M02_L10
M02_L15:
       lea       rcx,[rbx+r14*2]
       movsx     rdx,r15w
       mov       r8d,r13d
       call      qword ptr [7FFB5E197288]; System.SpanHelpers.NonPackedIndexOfValueType[[System.Int16, System.Private.CoreLib],[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
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
       call      qword ptr [7FFB5E19C330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFB5E19C330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      00007FFBBDE29F20
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
       call      qword ptr [7FFB5E195818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,2A4B84D0008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M03_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,19655
       mov       rdx,7FFB5E0D4000
       call      qword ptr [7FFB5E19F228]
       mov       rbx,rax
       call      qword ptr [7FFB5E844678]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB5E42D9B0]
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
       jg        near ptr M04_L05
       cmp       eax,esi
       jl        near ptr M04_L05
       mov       rax,[rbx+8]
       mov       ebp,[rax+8]
       sub       ebp,ecx
       test      ebp,ebp
       jg        near ptr M04_L03
M04_L00:
       sub       esi,ebp
       mov       edx,[rbx+1C]
       lea       ecx,[rsi+rdx]
       mov       eax,[rbx+18]
       add       ecx,eax
       cmp       ecx,[rbx+20]
       jg        near ptr M04_L08
       cmp       ecx,esi
       jl        near ptr M04_L08
       add       edx,eax
       mov       ecx,edx
       mov       eax,1F40
       cmp       ecx,1F40
       cmovg     ecx,eax
       cmp       esi,ecx
       cmovge    ecx,esi
       add       edx,ecx
       cmp       edx,ecx
       jl        near ptr M04_L09
       cmp       ecx,400
       jge       near ptr M04_L10
       movsxd    rdx,ecx
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
M04_L01:
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
M04_L02:
       cmp       esi,r8d
       ja        near ptr M04_L12
       mov       r8d,esi
       add       r8,r8
       call      qword ptr [7FFB5E195818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       [rbx+18],esi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M04_L03:
       mov       rax,[rbx+8]
       test      rax,rax
       je        near ptr M04_L06
       mov       edx,[rax+8]
       cmp       edx,ecx
       jb        near ptr M04_L07
       mov       r8d,ecx
       lea       rax,[rax+r8*2+10]
       sub       edx,ecx
M04_L04:
       cmp       ebp,edx
       ja        near ptr M04_L12
       mov       r8d,ebp
       add       r8,r8
       mov       rcx,rax
       mov       rdx,rdi
       call      qword ptr [7FFB5E195818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rdx,[rbx+8]
       mov       edx,[rdx+8]
       mov       [rbx+18],edx
       jmp       near ptr M04_L00
M04_L05:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,19685
       mov       rdx,7FFB5E0D4000
       call      qword ptr [7FFB5E19F228]
       mov       rsi,rax
       call      qword ptr [7FFB5E844768]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFB5E42D9B0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M04_L06:
       test      ecx,ecx
       jne       short M04_L07
       xor       eax,eax
       xor       edx,edx
       jmp       short M04_L04
M04_L07:
       call      qword ptr [7FFB5E36F228]
       int       3
M04_L08:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,1969B
       mov       rdx,7FFB5E0D4000
       call      qword ptr [7FFB5E19F228]
       mov       rsi,rax
       call      qword ptr [7FFB5E8447B0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFB5E42D9B0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M04_L09:
       mov       rcx,offset MT_System.OutOfMemoryException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB5E8447C8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M04_L10:
       xor       edx,edx
       call      qword ptr [7FFB5E72F258]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       r14,rax
       jmp       near ptr M04_L01
M04_L11:
       xor       ecx,ecx
       xor       r8d,r8d
       jmp       near ptr M04_L02
M04_L12:
       call      qword ptr [7FFB5E5AD248]
       int       3
; Total bytes of code 631
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
       call      qword ptr [7FFBBDC19A58]; Precode of System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M05_L00
       mov       eax,1
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M05_L00:
       cmp       qword ptr [rdi+10],0
       jne       short M05_L01
       xor       eax,eax
       mov       [rbx],rax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M05_L01:
       mov       rcx,rsi
       mov       rdx,rbx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax]
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
       call      qword ptr [7FFBBDBF4030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-0B0]
       mov       edx,[rbp-0A4]
       mov       r8d,[rbp-0A8]
       mov       r9,[rbp-0B8]
       call      qword ptr [rax]
       lea       rcx,[rbp-0A0]
       call      qword ptr [7FFBBDBF4038]; CORINFO_HELP_JIT_PINVOKE_END
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
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rsi,rcx
       mov       rbx,rdx
       mov       edi,r8d
       test      rsi,rsi
       je        near ptr M07_L10
       test      rbx,rbx
       je        near ptr M07_L09
       mov       rcx,[rsi]
       cmp       rcx,[rbx]
       jne       near ptr M07_L08
       cmp       dword ptr [rcx+4],18
       jne       near ptr M07_L07
       cmp       edi,[rsi+8]
       ja        near ptr M07_L06
       cmp       edi,[rbx+8]
       ja        near ptr M07_L05
       mov       edi,edi
       movzx     ebp,word ptr [rcx]
       imul      rdi,rbp
       add       rsi,10
       add       rbx,10
       test      dword ptr [rcx],1000000
       je        short M07_L01
       mov       rcx,7FFB5E828520
       call      CORINFO_HELP_COUNTPROFILE32
       cmp       rdi,4000
       ja        short M07_L04
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       call      00007FFBBDDC1380
       cmp       dword ptr [7FFBBE0E3A10],0
       jne       short M07_L03
M07_L00:
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M07_L01:
       mov       rcx,7FFB5E828538
       call      CORINFO_HELP_COUNTPROFILE32
       cmp       rdi,19
       je        short M07_L02
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       call      qword ptr [7FFB5E195818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M07_L00
M07_L02:
       vmovdqu   xmm0,xmmword ptr [rsi]
       vmovdqu   xmm1,xmmword ptr [rsi+9]
       vmovdqu   xmmword ptr [rbx],xmm0
       vmovdqu   xmmword ptr [rbx+9],xmm1
       jmp       short M07_L00
M07_L03:
       call      CORINFO_HELP_POLL_GC
       jmp       short M07_L00
M07_L04:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       qword ptr [7FFB5E72EB38]
M07_L05:
       mov       rcx,7FFB5E828524
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M07_L11
M07_L06:
       mov       rcx,7FFB5E828528
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M07_L11
M07_L07:
       mov       rcx,7FFB5E82852C
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M07_L11
M07_L08:
       mov       rcx,7FFB5E828530
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M07_L11
M07_L09:
       mov       rcx,7FFB5E828534
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M07_L11
M07_L10:
       xor       esi,esi
       xor       ebp,ebp
       jmp       short M07_L12
M07_L11:
       mov       rcx,7FFB5E82853C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFB5E7BF210]; System.Array.GetLowerBound(Int32)
       mov       ebp,eax
M07_L12:
       test      rbx,rbx
       jne       short M07_L13
       xor       ebx,ebx
       xor       r14d,r14d
       jmp       short M07_L14
M07_L13:
       mov       rcx,7FFB5E828540
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFB5E7BF210]; System.Array.GetLowerBound(Int32)
       mov       r14d,eax
M07_L14:
       mov       rcx,7FFB5E828544
       call      CORINFO_HELP_COUNTPROFILE32
       mov       [rsp+20],edi
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rsi
       mov       edx,ebp
       mov       r8,rbx
       mov       r9d,r14d
       call      qword ptr [7FFB5E7BF228]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M07_L00
; Total bytes of code 457
```

