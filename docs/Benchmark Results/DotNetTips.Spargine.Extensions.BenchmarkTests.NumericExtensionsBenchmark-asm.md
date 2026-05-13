## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.NumericExtensionsBenchmark.FormatTimeDoubleHours()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       vmovsd    xmm0,qword ptr [rbx+138]
       call      qword ptr [7FFBEC19F048]; DotNetTips.Spargine.Extensions.NumericExtensions.FormatTime(Double)
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
; Total bytes of code 64
```
```assembly
; DotNetTips.Spargine.Extensions.NumericExtensions.FormatTime(Double)
; 		if (milliseconds < 1000)
; 		^^^^^^^^^^^^^^^^^^^^^^^^
; 			var ms = (int)Math.Round(milliseconds);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			return $"{ms} millisecond{(ms == 1 ? string.Empty : "s")}";
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var timeSpan = TimeSpan.FromMilliseconds(milliseconds);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var sb = _stringBuilderPool.Value.Get();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			if (timeSpan.Hours > 0)
; 			^^^^^^^^^^^^^^^^^^^^^^^
; 				_ = sb.Append(timeSpan.Hours).Append(timeSpan.Hours == 1 ? " hour" : " hours");
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			if (timeSpan.Minutes > 0)
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
; 				if (sb.Length > 0)
; 				^^^^^^^^^^^^^^^^^^
; 				{ _ = sb.Append(ControlChars.Space); }
; 				  ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 				_ = sb.Append(timeSpan.Minutes).Append(timeSpan.Minutes == 1 ? " minute" : " minutes");
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			if (timeSpan.Seconds > 0 || sb.Length == 0)
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 				if (sb.Length > 0)
; 				^^^^^^^^^^^^^^^^^^
; 				{ _ = sb.Append(ControlChars.Space); }
; 				  ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 				_ = sb.Append(timeSpan.Seconds).Append(timeSpan.Seconds == 1 ? " second" : " seconds");
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			return sb.ToString();
; 			^^^^^^^^^^^^^^^^^^^^^
; 	}
; 	^
; 			_stringBuilderPool.Value.Return(sb.Clear());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		}
; 		^
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0C8
       lea       rbp,[rsp+0F0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-0C0],ymm4
       vmovdqu   ymmword ptr [rbp-0A0],ymm4
       vmovdqu   ymmword ptr [rbp-80],ymm4
       vmovdqu   ymmword ptr [rbp-60],ymm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       xor       eax,eax
       mov       [rbp-30],rax
       vmovsd    xmm1,qword ptr [7FFBEC254570]
       vucomisd  xmm1,xmm0
       ja        near ptr M01_L58
       vucomisd  xmm0,xmm0
       jp        near ptr M01_L62
       jne       near ptr M01_L62
       vmulsd    xmm0,xmm0,qword ptr [7FFBEC254578]
       call      qword ptr [7FFBEBEEDB78]; System.TimeSpan.IntervalFromDoubleTicks(Double)
       mov       rbx,rax
       mov       rcx,2D2FBC01DF8
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0
       jne       near ptr M01_L63
       mov       rsi,[rcx+18]
M01_L00:
       mov       rcx,offset MT_Microsoft.Extensions.ObjectPool.DefaultObjectPool<System.Text.StringBuilder>
       cmp       [rsi],rcx
       jne       near ptr M01_L67
       mov       rcx,[rsi+20]
       mov       [rbp-58],rcx
       cmp       qword ptr [rbp-58],0
       je        near ptr M01_L65
       lea       rcx,[rsi+20]
       mov       r8,[rbp-58]
       test      rcx,rcx
       je        near ptr M01_L64
       xor       edx,edx
       call      00007FFC4B793270
       cmp       rax,[rbp-58]
       jne       near ptr M01_L65
M01_L01:
       mov       rsi,[rbp-58]
M01_L02:
       xor       ecx,ecx
       mov       [rbp-58],rcx
M01_L03:
       mov       [rbp-0B8],rsi
       mov       rdx,3D157FAB34C210B5
       mov       rax,rdx
       imul      rbx
       mov       rdi,rdx
       shr       rdi,3F
       sar       rdx,21
       add       rdi,rdx
       mov       rdx,2AAAAAAAAAAAAAAB
       mov       rax,rdx
       imul      rdi
       mov       rcx,rdx
       shr       rcx,3F
       sar       rdx,2
       add       rcx,rdx
       lea       rcx,[rcx+rcx*2]
       shl       rcx,3
       sub       rdi,rcx
       test      edi,edi
       jle       near ptr M01_L11
       mov       ecx,edi
       mov       rax,[rsi+8]
       mov       rdx,rax
       mov       r8d,[rsi+18]
       mov       r10d,r8d
       mov       eax,[rax+8]
       sub       eax,r8d
       mov       r8d,r10d
       mov       r9d,eax
       add       r8,r9
       mov       r9d,[rdx+8]
       cmp       r8,r9
       ja        near ptr M01_L48
       mov       r8d,r10d
       lea       rdx,[rdx+r8*2+10]
       mov       r8d,ecx
       or        r8d,1
       lzcnt     r8d,r8d
       xor       r8d,1F
       mov       r10d,ecx
       mov       r9,7FFC4967B880
       add       r10,[r9+r8*8]
       sar       r10,20
       cmp       r10d,eax
       jg        near ptr M01_L36
       mov       [rbp-60],r10d
       mov       [rbp-68],rdx
       movsxd    rax,r10d
       lea       rax,[rdx+rax*2]
       mov       edx,ecx
       cmp       edx,0A
       jb        short M01_L06
       cmp       ecx,64
       jb        short M01_L05
       mov       rsi,313909F20A4
M01_L04:
       add       rax,0FFFFFFFFFFFFFFFC
       mov       r8d,edx
       imul      r8,51EB851F
       shr       r8,25
       imul      r10d,r8d,64
       sub       edx,r10d
       mov       r10,rsi
       shl       edx,2
       mov       edx,[r10+rdx]
       mov       [rax],edx
       cmp       r8d,64
       mov       edx,r8d
       jae       short M01_L04
M01_L05:
       cmp       edx,0A
       jb        short M01_L06
       add       rax,0FFFFFFFFFFFFFFFC
       mov       rsi,313909F20A4
       shl       edx,2
       mov       edx,[rsi+rdx]
       mov       [rax],edx
       jmp       short M01_L07
M01_L06:
       add       edx,30
       mov       [rax-2],dx
M01_L07:
       xor       eax,eax
       mov       [rbp-68],rax
       mov       eax,1
M01_L08:
       xor       edx,edx
       mov       [rbp-68],rdx
       test      eax,eax
       je        near ptr M01_L37
       mov       ecx,[rbp-60]
       mov       rsi,[rbp-0B8]
       add       [rsi+18],ecx
       mov       r14,rsi
M01_L09:
       mov       r8,31390A00760
       mov       rcx,31390A00738
       cmp       edi,1
       cmovne    r8,rcx
       cmp       [r14],r14b
       lea       rdx,[r8+0C]
       mov       edi,[r8+8]
       test      edi,edi
       je        short M01_L11
       mov       r8,[r14+8]
       mov       r15d,[r14+18]
       lea       ecx,[r15+rdi]
       cmp       ecx,[r8+8]
       ja        near ptr M01_L39
       movsxd    rcx,r15d
       lea       rcx,[r8+rcx*2+10]
       cmp       edi,2
       jle       near ptr M01_L15
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFBEBB65818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L10:
       add       edi,r15d
       mov       [r14+18],edi
M01_L11:
       mov       rdx,1CA213D840BAF7D5
       mov       rax,rdx
       imul      rbx
       mov       rdi,rdx
       shr       rdi,3F
       sar       rdx,1A
       add       rdi,rdx
       mov       rdx,8888888888888889
       mov       rax,rdx
       imul      rdi
       add       rdx,rdi
       mov       rcx,rdx
       shr       rcx,3F
       sar       rdx,5
       add       rcx,rdx
       imul      rcx,3C
       sub       rdi,rcx
       test      edi,edi
       jle       near ptr M01_L21
       mov       rsi,[rbp-0B8]
       mov       ecx,[rsi+1C]
       mov       edx,[rsi+18]
       add       ecx,edx
       test      ecx,ecx
       jle       short M01_L12
       mov       ecx,edx
       mov       rax,[rsi+8]
       cmp       [rax+8],ecx
       jbe       near ptr M01_L40
       mov       word ptr [rax+rcx*2+10],20
       inc       edx
       mov       [rsi+18],edx
M01_L12:
       mov       ecx,edi
       mov       rax,[rsi+8]
       mov       rdx,rax
       mov       r8d,[rsi+18]
       mov       r10d,r8d
       mov       eax,[rax+8]
       sub       eax,r8d
       mov       r8d,r10d
       mov       r9d,eax
       add       r8,r9
       mov       r9d,[rdx+8]
       cmp       r8,r9
       ja        near ptr M01_L48
       mov       r8d,r10d
       lea       rdx,[rdx+r8*2+10]
       mov       r8d,ecx
       or        r8d,1
       lzcnt     r8d,r8d
       xor       r8d,1F
       mov       r10d,ecx
       mov       r9,7FFC4967B880
       add       r10,[r9+r8*8]
       sar       r10,20
       cmp       r10d,eax
       jg        near ptr M01_L41
       mov       [rbp-70],r10d
       mov       [rbp-78],rdx
       movsxd    rax,r10d
       lea       rax,[rdx+rax*2]
       mov       edx,ecx
       cmp       ecx,0A
       jb        short M01_L16
       cmp       ecx,64
       jb        short M01_L14
       mov       r8,313909F20A4
M01_L13:
       add       rax,0FFFFFFFFFFFFFFFC
       mov       r10d,edx
       imul      r10,51EB851F
       shr       r10,25
       imul      r9d,r10d,64
       sub       edx,r9d
       mov       r9,r8
       shl       edx,2
       mov       edx,[r9+rdx]
       mov       [rax],edx
       cmp       r10d,64
       mov       edx,r10d
       jae       short M01_L13
M01_L14:
       cmp       edx,0A
       jb        short M01_L16
       add       rax,0FFFFFFFFFFFFFFFC
       mov       r8,313909F20A4
       shl       edx,2
       mov       edx,[r8+rdx]
       mov       [rax],edx
       jmp       short M01_L17
M01_L15:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       edi,2
       jne       near ptr M01_L10
       jmp       near ptr M01_L38
M01_L16:
       add       edx,30
       mov       [rax-2],dx
M01_L17:
       xor       eax,eax
       mov       [rbp-78],rax
       mov       eax,1
M01_L18:
       xor       edx,edx
       mov       [rbp-78],rdx
       test      eax,eax
       je        near ptr M01_L42
       mov       ecx,[rbp-70]
       add       [rsi+18],ecx
       mov       r14,rsi
M01_L19:
       mov       r8,31390A007A8
       mov       rcx,31390A00780
       cmp       edi,1
       cmovne    r8,rcx
       cmp       [r14],r14b
       lea       rdx,[r8+0C]
       mov       edi,[r8+8]
       test      edi,edi
       je        short M01_L21
       mov       r8,[r14+8]
       mov       r15d,[r14+18]
       lea       ecx,[r15+rdi]
       cmp       ecx,[r8+8]
       ja        near ptr M01_L44
       movsxd    rcx,r15d
       lea       rcx,[r8+rcx*2+10]
       cmp       edi,2
       jle       near ptr M01_L27
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFBEBB65818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L20:
       add       edi,r15d
       mov       [r14+18],edi
M01_L21:
       mov       rdx,0D6BF94D5E57A42BD
       mov       rax,rdx
       imul      rbx
       add       rbx,rdx
       mov       rdi,rbx
       shr       rdi,3F
       sar       rbx,17
       add       rbx,rdi
       mov       rdx,8888888888888889
       mov       rax,rdx
       imul      rbx
       add       rdx,rbx
       mov       rcx,rdx
       shr       rcx,3F
       sar       rdx,5
       add       rcx,rdx
       imul      rcx,3C
       sub       rbx,rcx
       test      ebx,ebx
       jle       near ptr M01_L45
M01_L22:
       mov       rsi,[rbp-0B8]
       mov       ecx,[rsi+1C]
       mov       edx,[rsi+18]
       add       ecx,edx
       test      ecx,ecx
       jle       short M01_L23
       mov       ecx,edx
       mov       rax,[rsi+8]
       cmp       [rax+8],ecx
       jbe       near ptr M01_L46
       cmp       ecx,[rax+8]
       jae       near ptr M01_L52
       mov       word ptr [rax+rcx*2+10],20
       lea       ecx,[rdx+1]
       mov       [rsi+18],ecx
M01_L23:
       mov       eax,ebx
       mov       [rbp-7C],eax
       mov       rax,[rsi+8]
       mov       rcx,rax
       mov       edx,[rsi+18]
       mov       r8d,edx
       mov       edi,[rax+8]
       sub       edi,edx
       test      rcx,rcx
       je        near ptr M01_L47
       mov       eax,r8d
       mov       edx,edi
       add       rax,rdx
       mov       edx,[rcx+8]
       cmp       rax,rdx
       ja        near ptr M01_L48
       lea       r14,[rcx+r8*2+10]
M01_L24:
       mov       r15d,[rbp-7C]
       test      r15d,r15d
       jl        near ptr M01_L49
       mov       eax,r15d
       or        eax,1
       lzcnt     eax,eax
       xor       eax,1F
       mov       ecx,r15d
       mov       rdx,7FFC4967B880
       add       rcx,[rdx+rax*8]
       sar       rcx,20
       cmp       ecx,edi
       jg        near ptr M01_L53
       mov       [rbp-88],ecx
       mov       [rbp-90],r14
       movsxd    rax,ecx
       lea       rax,[r14+rax*2]
       cmp       r15d,0A
       jb        near ptr M01_L28
       cmp       r15d,64
       jb        short M01_L26
       mov       r8,313909F20A4
M01_L25:
       add       rax,0FFFFFFFFFFFFFFFC
       mov       ecx,r15d
       imul      rcx,51EB851F
       shr       rcx,25
       imul      edx,ecx,64
       sub       r15d,edx
       mov       rdx,r8
       shl       r15d,2
       mov       r10d,r15d
       mov       edx,[rdx+r10]
       mov       [rax],edx
       cmp       ecx,64
       mov       r15d,ecx
       jae       short M01_L25
M01_L26:
       cmp       r15d,0A
       jb        short M01_L28
       add       rax,0FFFFFFFFFFFFFFFC
       mov       r8,313909F20A4
       mov       rcx,r8
       lea       edx,[r15*4]
       mov       ecx,[rcx+rdx]
       mov       [rax],ecx
       jmp       short M01_L29
M01_L27:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       edi,2
       jne       near ptr M01_L20
       jmp       near ptr M01_L43
M01_L28:
       lea       ecx,[r15+30]
       mov       [rax-2],cx
M01_L29:
       xor       eax,eax
       mov       [rbp-90],rax
       mov       r14d,1
M01_L30:
       xor       eax,eax
       mov       [rbp-90],rax
M01_L31:
       test      r14d,r14d
       je        near ptr M01_L54
       mov       ecx,[rbp-88]
       add       [rsi+18],ecx
       mov       rdi,rsi
M01_L32:
       mov       r8,31390A007F8
       mov       rcx,31390A007D0
       cmp       ebx,1
       cmovne    r8,rcx
       cmp       [rdi],dil
       lea       rdx,[r8+0C]
       mov       ebx,[r8+8]
       test      ebx,ebx
       je        short M01_L34
       mov       r8,[rdi+8]
       mov       r14d,[rdi+18]
       lea       ecx,[r14+rbx]
       cmp       ecx,[r8+8]
       ja        near ptr M01_L56
       movsxd    rcx,r14d
       lea       rcx,[r8+rcx*2+10]
       cmp       ebx,2
       jle       short M01_L35
       mov       r8d,ebx
       add       r8,r8
       call      qword ptr [7FFBEBB65818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L33:
       add       ebx,r14d
       mov       [rdi+18],ebx
M01_L34:
       mov       rcx,rsi
       call      qword ptr [7FFBEBE0CC00]; System.Text.StringBuilder.ToString()
       mov       [rbp-0C0],rax
       jmp       near ptr M01_L57
M01_L35:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       ebx,2
       jne       short M01_L33
       jmp       near ptr M01_L55
M01_L36:
       xor       eax,eax
       mov       [rbp-60],eax
       jmp       near ptr M01_L08
M01_L37:
       mov       rsi,[rbp-0B8]
       call      qword ptr [7FFBEBDF7AE0]; System.Number.Int32ToDecStr(Int32)
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFBEBDF7AF8]; System.Text.StringBuilder.Append(System.String)
       mov       r14,rax
       jmp       near ptr M01_L09
M01_L38:
       movzx     edx,word ptr [rdx+2]
       mov       [rcx+2],dx
       jmp       near ptr M01_L10
M01_L39:
       mov       rcx,r14
       mov       r8d,edi
       call      qword ptr [7FFBEBDF7AB0]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M01_L11
M01_L40:
       mov       rcx,rsi
       mov       edx,20
       call      qword ptr [7FFBEBDF7C78]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M01_L12
M01_L41:
       xor       eax,eax
       mov       [rbp-70],eax
       jmp       near ptr M01_L18
M01_L42:
       call      qword ptr [7FFBEBDF7AE0]; System.Number.Int32ToDecStr(Int32)
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFBEBDF7AF8]; System.Text.StringBuilder.Append(System.String)
       mov       r14,rax
       jmp       near ptr M01_L19
M01_L43:
       movzx     edx,word ptr [rdx+2]
       mov       [rcx+2],dx
       jmp       near ptr M01_L20
M01_L44:
       mov       rcx,r14
       mov       r8d,edi
       call      qword ptr [7FFBEBDF7AB0]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M01_L21
M01_L45:
       mov       rsi,[rbp-0B8]
       mov       ecx,[rsi+1C]
       mov       edx,[rsi+18]
       add       edx,ecx
       jne       near ptr M01_L34
       jmp       near ptr M01_L22
M01_L46:
       mov       rcx,rsi
       mov       edx,20
       call      qword ptr [7FFBEBDF7C78]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M01_L23
M01_L47:
       or        r8d,edi
       jne       short M01_L48
       xor       r14d,r14d
       xor       edi,edi
       jmp       near ptr M01_L24
M01_L48:
       mov       rsi,[rbp-0B8]
       call      qword ptr [7FFBEBD3F228]
       int       3
M01_L49:
       call      qword ptr [7FFBEBB6D2A8]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
       mov       r8,[rax+28]
       test      r8,r8
       jne       short M01_L50
       xor       r9d,r9d
       xor       ecx,ecx
       jmp       short M01_L51
M01_L50:
       lea       r9,[r8+0C]
       mov       ecx,[r8+8]
M01_L51:
       mov       [rbp-0A0],r9
       mov       [rbp-98],ecx
       mov       [rbp-0B0],r14
       mov       [rbp-0A8],edi
       lea       r8,[rbp-88]
       mov       [rsp+20],r8
       lea       r8,[rbp-0A0]
       lea       r9,[rbp-0B0]
       mov       ecx,r15d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFBEC21C4F8]
       mov       r14d,eax
       jmp       near ptr M01_L31
M01_L52:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M01_L53:
       xor       eax,eax
       mov       [rbp-88],eax
       xor       r14d,r14d
       jmp       near ptr M01_L30
M01_L54:
       mov       ecx,[rbp-7C]
       call      qword ptr [7FFBEBDF7AE0]; System.Number.Int32ToDecStr(Int32)
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFBEBDF7AF8]; System.Text.StringBuilder.Append(System.String)
       mov       rdi,rax
       jmp       near ptr M01_L32
M01_L55:
       movzx     edx,word ptr [rdx+2]
       mov       [rcx+2],dx
       jmp       near ptr M01_L33
M01_L56:
       mov       rcx,rdi
       mov       r8d,ebx
       call      qword ptr [7FFBEBDF7AB0]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M01_L34
M01_L57:
       call      M01_L68
       nop
       mov       rax,[rbp-0C0]
       add       rsp,0C8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L58:
       vroundsd  xmm0,xmm0,xmm0,4
       call      qword ptr [7FFBEBB65938]
       mov       ebx,eax
       lea       rcx,[rbp-50]
       mov       edx,0C
       mov       r8d,2
       call      qword ptr [7FFBEBB6C270]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler..ctor(Int32, Int32)
       lea       rcx,[rbp-50]
       mov       edx,ebx
       call      qword ptr [7FFBEBB67FD8]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Int32, System.Private.CoreLib]](Int32)
       mov       ecx,[rbp-40]
       cmp       ecx,[rbp-30]
       jbe       short M01_L59
       call      qword ptr [7FFBEBD3F228]
       int       3
M01_L59:
       mov       rdx,[rbp-38]
       mov       eax,ecx
       lea       rdx,[rdx+rax*2]
       mov       eax,[rbp-30]
       sub       eax,ecx
       cmp       eax,0C
       jb        short M01_L60
       vmovups   xmm0,[7FFBEC254580]
       vmovups   [rdx],xmm0
       mov       rcx,64006E006F0063
       mov       [rdx+10],rcx
       mov       ecx,[rbp-40]
       add       ecx,0C
       mov       [rbp-40],ecx
       jmp       short M01_L61
M01_L60:
       lea       rcx,[rbp-50]
       mov       rdx,31390A00708
       call      qword ptr [7FFBEBF8E610]
M01_L61:
       mov       rdx,313909F0008
       mov       rcx,313909FB4B8
       cmp       ebx,1
       cmovne    rdx,rcx
       lea       rcx,[rbp-50]
       call      qword ptr [7FFBEBDFF0C0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted(System.String)
       lea       rcx,[rbp-50]
       call      qword ptr [7FFBEBB6C2A0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       nop
       add       rsp,0C8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L62:
       call      qword ptr [7FFBEC21C888]
       int       3
M01_L63:
       call      qword ptr [7FFBEBEE4D38]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rsi,rax
       jmp       near ptr M01_L00
M01_L64:
       call      qword ptr [7FFBEC217AF8]
       int       3
M01_L65:
       mov       rcx,[rsi+18]
       lea       rdx,[rbp-58]
       cmp       [rcx],ecx
       call      qword ptr [7FFBEC196D60]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M01_L66
       add       rsi,2C
       lock dec  dword ptr [rsi]
       jmp       near ptr M01_L01
M01_L66:
       mov       rax,[rsi+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       rsi,rax
       jmp       near ptr M01_L02
M01_L67:
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rsi,rax
       jmp       near ptr M01_L03
M01_L68:
       sub       rsp,28
       mov       rcx,2D2FBC01DF8
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0
       je        short M01_L69
       call      qword ptr [7FFBEBEE4D38]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rbx,rax
       jmp       short M01_L70
M01_L69:
       mov       rbx,[rcx+18]
M01_L70:
       mov       rsi,[rbp-0B8]
       cmp       dword ptr [rsi+20],0
       jge       short M01_L71
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,3AD
       mov       rdx,7FFBEBAA4000
       call      qword ptr [7FFBEBB6F228]
       mov       rbx,rax
       call      qword ptr [7FFBEC21C738]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFBEBDFE700]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M01_L71:
       cmp       qword ptr [rsi+10],0
       jne       short M01_L72
       xor       ecx,ecx
       mov       [rsi+18],rcx
       jmp       near ptr M01_L79
M01_L72:
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       mov       r8d,ecx
       neg       r8d
       test      r8d,r8d
       jle       short M01_L73
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFBEC21C858]
       jmp       near ptr M01_L79
M01_L73:
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFBEC21C870]
       mov       rdi,rax
       cmp       rdi,rsi
       je        near ptr M01_L78
       mov       rax,[rsi+8]
       mov       ecx,[rax+8]
       add       ecx,[rsi+1C]
       mov       eax,[rsi+1C]
       add       eax,[rsi+18]
       lea       edx,[rax+rax*2]
       add       edx,edx
       mov       r8d,66666667
       mov       eax,r8d
       imul      edx
       mov       eax,edx
       shr       eax,1F
       sar       edx,1
       add       edx,eax
       mov       rax,[rsi+8]
       mov       eax,[rax+8]
       cmp       edx,eax
       cmovl     edx,eax
       cmp       ecx,edx
       cmovg     ecx,edx
       sub       ecx,[rdi+1C]
       mov       rdx,[rdi+8]
       cmp       [rdx+8],ecx
       jge       short M01_L76
       cmp       ecx,400
       jge       short M01_L74
       movsxd    rdx,ecx
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
       jmp       short M01_L75
M01_L74:
       xor       edx,edx
       call      qword ptr [7FFBEC194BB8]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       r14,rax
M01_L75:
       mov       rcx,[rdi+8]
       mov       r8d,[rdi+18]
       mov       rdx,r14
       call      qword ptr [7FFBEBB6F5A0]; System.Array.Copy(System.Array, System.Array, Int32)
       lea       rcx,[rsi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M01_L77
M01_L76:
       mov       rdx,[rdi+8]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
M01_L77:
       mov       rdx,[rdi+10]
       lea       rcx,[rsi+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rdi+1C]
       mov       [rsi+1C],ecx
M01_L78:
       mov       ecx,[rdi+1C]
       neg       ecx
       mov       [rsi+18],ecx
M01_L79:
       mov       rdx,offset MT_Microsoft.Extensions.ObjectPool.DefaultObjectPool<System.Text.StringBuilder>
       cmp       [rbx],rdx
       jne       short M01_L83
       mov       rax,[rbx+10]
       mov       rdx,rsi
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       test      eax,eax
       je        short M01_L84
       cmp       qword ptr [rbx+20],0
       jne       short M01_L81
       lea       rcx,[rbx+20]
       test      rcx,rcx
       jne       short M01_L80
       call      qword ptr [7FFBEC217AF8]
       int       3
M01_L80:
       mov       rdx,rsi
       xor       r8d,r8d
       call      00007FFC4B793270
       test      rax,rax
       je        short M01_L84
M01_L81:
       lea       rcx,[rbx+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[rbx+28]
       jg        short M01_L82
       mov       rbx,[rbx+18]
       mov       rcx,[rbx+10]
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFBEC21C930]
       test      eax,eax
       jne       short M01_L84
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFBEC21C948]
       jmp       short M01_L84
M01_L82:
       add       rbx,2C
       lock dec  dword ptr [rbx]
       jmp       short M01_L84
M01_L83:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
M01_L84:
       nop
       add       rsp,28
       ret
; Total bytes of code 3047
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.NumericExtensionsBenchmark.FormatTimeDoubleMilliseconds()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       vmovsd    xmm0,qword ptr [rbx+148]
       call      qword ptr [7FFBEC17D1A0]; DotNetTips.Spargine.Extensions.NumericExtensions.FormatTime(Double)
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
; Total bytes of code 64
```
```assembly
; DotNetTips.Spargine.Extensions.NumericExtensions.FormatTime(Double)
; 		if (milliseconds < 1000)
; 		^^^^^^^^^^^^^^^^^^^^^^^^
; 			var ms = (int)Math.Round(milliseconds);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			return $"{ms} millisecond{(ms == 1 ? string.Empty : "s")}";
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var timeSpan = TimeSpan.FromMilliseconds(milliseconds);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var sb = _stringBuilderPool.Value.Get();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			if (timeSpan.Hours > 0)
; 			^^^^^^^^^^^^^^^^^^^^^^^
; 				_ = sb.Append(timeSpan.Hours).Append(timeSpan.Hours == 1 ? " hour" : " hours");
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			if (timeSpan.Minutes > 0)
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
; 				if (sb.Length > 0)
; 				^^^^^^^^^^^^^^^^^^
; 				{ _ = sb.Append(ControlChars.Space); }
; 				  ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 				_ = sb.Append(timeSpan.Minutes).Append(timeSpan.Minutes == 1 ? " minute" : " minutes");
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			if (timeSpan.Seconds > 0 || sb.Length == 0)
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 				if (sb.Length > 0)
; 				^^^^^^^^^^^^^^^^^^
; 				{ _ = sb.Append(ControlChars.Space); }
; 				  ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 				_ = sb.Append(timeSpan.Seconds).Append(timeSpan.Seconds == 1 ? " second" : " seconds");
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			return sb.ToString();
; 			^^^^^^^^^^^^^^^^^^^^^
; 	}
; 	^
; 			_stringBuilderPool.Value.Return(sb.Clear());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		}
; 		^
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,118
       lea       rbp,[rsp+150]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-0E0],ymm4
       vmovdqu   ymmword ptr [rbp-0C0],ymm4
       vmovdqu   ymmword ptr [rbp-0A0],ymm4
       vmovdqu   ymmword ptr [rbp-80],ymm4
       vmovdqu   ymmword ptr [rbp-60],ymm4
       xor       eax,eax
       mov       [rbp-40],rax
       vmovsd    xmm1,qword ptr [7FFBEBC29510]
       vucomisd  xmm1,xmm0
       jbe       near ptr M01_L67
       vroundsd  xmm0,xmm0,xmm0,4
       call      qword ptr [7FFBEBB75938]; System.Math.ConvertToInt32Checked(Double)
       mov       ebx,eax
       xor       ecx,ecx
       mov       [rbp-68],rcx
       mov       rcx,1D996000C88
       mov       rsi,[rcx]
       mov       rdi,rsi
       mov       rcx,1D996000C90
       mov       r14,[rcx]
       mov       r15,r14
       mov       rcx,gs:[58]
       mov       rcx,[rcx+38]
       cmp       dword ptr [rcx+238],3
       jle       near ptr M01_L32
       mov       rcx,[rcx+240]
       mov       r13,[rcx+18]
       test      r13,r13
       je        near ptr M01_L32
M01_L00:
       mov       rcx,[r13+10]
       test      rcx,rcx
       je        near ptr M01_L34
       mov       eax,[rcx+8]
       cmp       eax,4
       jle       near ptr M01_L34
       mov       r12,[rcx+50]
       test      r12,r12
       je        near ptr M01_L34
       xor       eax,eax
       mov       [rcx+50],rax
       cmp       byte ptr [r15+9D],0
       jne       near ptr M01_L33
M01_L01:
       mov       [rbp-60],r12
       lea       rax,[r12+10]
       mov       ecx,[r12+8]
       mov       [rbp-50],rax
       mov       [rbp-48],ecx
       xor       eax,eax
       mov       [rbp-58],eax
       mov       byte ptr [rbp-54],0
       cmp       byte ptr [rbp-54],0
       jne       near ptr M01_L48
M01_L02:
       mov       eax,[rbp-58]
       mov       edi,[rbp-48]
       cmp       eax,edi
       ja        near ptr M01_L56
       mov       rcx,[rbp-50]
       mov       edx,eax
       lea       r15,[rcx+rdx*2]
       sub       edi,eax
       mov       rcx,[rbp-68]
       test      ebx,ebx
       jl        near ptr M01_L50
       mov       ecx,ebx
       or        ecx,1
       xor       eax,eax
       lzcnt     eax,ecx
       xor       eax,1F
       mov       ecx,ebx
       mov       rdx,7FFC4967B880
       add       rcx,[rdx+rax*8]
       sar       rcx,20
       cmp       ecx,edi
       jg        near ptr M01_L55
       mov       [rbp-98],ecx
       mov       [rbp-0A0],r15
       movsxd    rax,ecx
       lea       rax,[r15+rax*2]
       mov       ecx,ebx
       cmp       ebx,0A
       jb        short M01_L05
       cmp       ebx,64
       jb        short M01_L04
       mov       rdx,21A2AE320A4
M01_L03:
       add       rax,0FFFFFFFFFFFFFFFC
       mov       r8d,ecx
       imul      r8,51EB851F
       shr       r8,25
       imul      r10d,r8d,64
       sub       ecx,r10d
       mov       r10,rdx
       shl       ecx,2
       mov       ecx,[r10+rcx]
       mov       [rax],ecx
       cmp       r8d,64
       mov       ecx,r8d
       jae       short M01_L03
M01_L04:
       cmp       ecx,0A
       jb        short M01_L05
       add       rax,0FFFFFFFFFFFFFFFC
       mov       rdx,21A2AE320A4
       shl       ecx,2
       mov       ecx,[rdx+rcx]
       mov       [rax],ecx
       jmp       short M01_L06
M01_L05:
       add       ecx,30
       mov       [rax-2],cx
M01_L06:
       xor       eax,eax
       mov       [rbp-0A0],rax
       mov       r15d,1
M01_L07:
       xor       eax,eax
       mov       [rbp-0A0],rax
M01_L08:
       test      r15d,r15d
       je        near ptr M01_L49
       mov       ecx,[rbp-58]
       add       ecx,[rbp-98]
       mov       [rbp-58],ecx
M01_L09:
       mov       ecx,[rbp-58]
       mov       edx,[rbp-48]
       cmp       ecx,edx
       ja        near ptr M01_L56
       mov       rax,[rbp-50]
       mov       r8d,ecx
       lea       rax,[rax+r8*2]
       sub       edx,ecx
       cmp       edx,0C
       jb        near ptr M01_L25
       vmovups   xmm0,[7FFBEBC29520]
       vmovups   [rax],xmm0
       mov       rcx,64006E006F0063
       mov       [rax+10],rcx
       mov       ecx,[rbp-58]
       add       ecx,0C
       mov       [rbp-58],ecx
M01_L10:
       mov       rdi,21A2AE30008
       mov       r8,21A2AE3B4B8
       cmp       ebx,1
       cmovne    rdi,r8
       cmp       byte ptr [rbp-54],0
       jne       near ptr M01_L26
       mov       r8d,[rbp-58]
       mov       edx,[rbp-48]
       cmp       r8d,edx
       ja        near ptr M01_L56
       mov       rcx,[rbp-50]
       mov       eax,r8d
       lea       rcx,[rcx+rax*2]
       sub       edx,r8d
       cmp       [rdi+8],edx
       ja        near ptr M01_L26
       mov       r8d,[rdi+8]
       add       r8,r8
       lea       rdx,[rdi+0C]
       call      qword ptr [7FFBEBB75818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbp-58]
       add       ecx,[rdi+8]
       mov       [rbp-58],ecx
M01_L11:
       mov       ecx,[rbp-58]
       cmp       ecx,[rbp-48]
       ja        near ptr M01_L56
       mov       rax,[rbp-50]
       mov       [rbp-0D0],rax
       mov       [rbp-0C8],ecx
       lea       rcx,[rbp-0D0]
       call      System.String.Ctor(System.ReadOnlySpan`1<Char>)
       mov       rbx,rax
       mov       rdi,[rbp-60]
       xor       ecx,ecx
       mov       [rbp-60],rcx
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-50],xmm0
       mov       [rbp-58],ecx
       test      rdi,rdi
       je        near ptr M01_L31
       mov       ecx,[rdi+8]
       dec       ecx
       or        ecx,0F
       xor       r15d,r15d
       lzcnt     r15d,ecx
       xor       r15d,1F
       add       r15d,0FFFFFFFD
       mov       rax,[r13+10]
       test      rax,rax
       jne       short M01_L12
       mov       rcx,rsi
       call      qword ptr [7FFBEBE0CEA0]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
M01_L12:
       xor       r13d,r13d
       mov       r12d,1
       cmp       [rax+8],r15d
       jbe       near ptr M01_L22
       mov       r13d,1
       mov       ecx,10
       shlx      ecx,ecx,r15d
       cmp       [rdi+8],ecx
       jne       near ptr M01_L57
       mov       ecx,r15d
       shl       rcx,4
       lea       rax,[rax+rcx+10]
       mov       [rbp-108],rax
       mov       r8,[rax]
       mov       [rbp-110],r8
       mov       rcx,rax
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       rdx,[rbp-108]
       mov       [rdx+8],ecx
       cmp       qword ptr [rbp-110],0
       je        near ptr M01_L22
       mov       rcx,[rsi+10]
       cmp       r15d,[rcx+8]
       jae       near ptr M01_L74
       mov       edx,r15d
       mov       r8,[rcx+rdx*8+10]
       test      r8,r8
       jne       short M01_L13
       mov       rcx,rsi
       mov       edx,r15d
       call      qword ptr [7FFBEC224768]
       mov       r8,rax
M01_L13:
       mov       r12,[r8+8]
       test      byte ptr [7FFBEC21A2C0],1
       je        near ptr M01_L58
M01_L14:
       cmp       byte ptr [7FFBEBABB17C],0
       je        near ptr M01_L59
       call      qword ptr [7FFBEC224690]
       mov       edx,eax
M01_L15:
       test      byte ptr [7FFBEC21A150],1
       je        near ptr M01_L61
M01_L16:
       mov       eax,edx
       xor       edx,edx
       div       dword ptr [7FFBEBABB170]
       mov       eax,edx
       mov       edx,[r12+8]
       mov       [rbp-0E4],edx
       test      edx,edx
       jle       near ptr M01_L65
       mov       [rbp-0E8],edx
M01_L17:
       cmp       eax,edx
       jae       near ptr M01_L74
       mov       [rbp-0AC],eax
       mov       ecx,eax
       mov       r10,[r12+rcx*8+10]
       mov       [rbp-118],r10
       cmp       [r10],r10b
       xor       r9d,r9d
       mov       [rbp-0B8],r9d
       mov       rcx,r10
       call      00007FFC4B802B50
       test      eax,eax
       jne       short M01_L18
       mov       rcx,[rbp-118]
       call      qword ptr [7FFBEC224348]
M01_L18:
       mov       rax,[rbp-118]
       mov       rcx,[rax+8]
       mov       r8d,[rax+10]
       mov       [rbp-0BC],r8d
       cmp       [rcx+8],r8d
       jbe       short M01_L20
       test      r8d,r8d
       je        near ptr M01_L27
M01_L19:
       movsxd    rdx,r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,[rbp-110]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rbp-0BC]
       inc       ecx
       mov       rax,[rbp-118]
       mov       [rax+10],ecx
       mov       dword ptr [rbp-0B8],1
M01_L20:
       mov       rcx,rax
       call      00007FFC4B802A70
       test      eax,eax
       jne       near ptr M01_L62
M01_L21:
       cmp       dword ptr [rbp-0B8],0
       je        near ptr M01_L63
       mov       r12d,1
M01_L22:
       cmp       byte ptr [r14+9D],0
       je        near ptr M01_L31
       cmp       dword ptr [rdi+8],0
       je        near ptr M01_L31
       mov       rcx,rdi
       call      qword ptr [7FFBEBF8D830]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rbp-0A4],eax
       mov       edx,[rdi+8]
       mov       [rbp-0A8],edx
       mov       rcx,rsi
       call      00007FFC4B789590
       test      eax,eax
       je        near ptr M01_L28
M01_L23:
       mov       [rsp+20],eax
       mov       rcx,r14
       mov       r8d,[rbp-0A4]
       mov       r9d,[rbp-0A8]
       mov       edx,3
       call      qword ptr [7FFBEC224780]
       test      r12d,r13d
       jne       near ptr M01_L31
       mov       rcx,rdi
       call      qword ptr [7FFBEBF8D830]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r12d,eax
       mov       edi,[rdi+8]
       mov       rcx,rsi
       call      00007FFC4B789590
       mov       r9d,eax
       test      r9d,r9d
       je        near ptr M01_L66
M01_L24:
       test      r13d,r13d
       jne       short M01_L29
       mov       r15d,0FFFFFFFF
       mov       ecx,1
       jmp       short M01_L30
M01_L25:
       lea       rcx,[rbp-68]
       mov       rdx,21A2AE40708
       call      qword ptr [7FFBEC176AD8]
       jmp       near ptr M01_L10
M01_L26:
       lea       rcx,[rbp-68]
       mov       rdx,rdi
       call      qword ptr [7FFBEC224558]
       jmp       near ptr M01_L11
M01_L27:
       xor       edx,edx
       mov       [rax+14],edx
       jmp       near ptr M01_L19
M01_L28:
       mov       rcx,rsi
       call      qword ptr [7FFBEBD477F8]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       jmp       near ptr M01_L23
M01_L29:
       xor       ecx,ecx
M01_L30:
       mov       [rsp+20],r15d
       mov       [rsp+28],ecx
       mov       rcx,r14
       mov       edx,r12d
       mov       r8d,edi
       call      qword ptr [7FFBEC224798]
M01_L31:
       mov       rax,rbx
       add       rsp,118
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L32:
       mov       ecx,3
       call      qword ptr [7FFBEC17FFA8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       r13,rax
       jmp       near ptr M01_L00
M01_L33:
       mov       rcx,r12
       call      qword ptr [7FFBEBF8D830]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rbp-78],eax
       mov       edx,[r12+8]
       mov       [rbp-7C],edx
       mov       rcx,rdi
       call      qword ptr [7FFBEBF8D830]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       dword ptr [rsp+20],4
       mov       edx,[rbp-78]
       mov       r8d,[rbp-7C]
       mov       rcx,r15
       call      qword ptr [7FFBEC224678]
       jmp       near ptr M01_L01
M01_L34:
       mov       rcx,[rdi+10]
       cmp       dword ptr [rcx+8],4
       jle       near ptr M01_L46
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        near ptr M01_L45
       mov       r12,[rcx+8]
       mov       rcx,offset MT_System.Threading.ProcessorIdCache
       call      qword ptr [7FFBEBB75740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       cmp       byte ptr [7FFBEBABB17C],0
       je        short M01_L35
       call      qword ptr [7FFBEC224690]
       mov       edx,eax
       mov       [rbp-88],edx
       jmp       short M01_L37
M01_L35:
       mov       ecx,9
       call      qword ptr [7FFBEC2246A8]
       mov       eax,[rax+10]
       mov       [rbp-8C],eax
       mov       ecx,9
       call      qword ptr [7FFBEC2246A8]
       mov       edx,[rbp-8C]
       lea       ecx,[rdx-1]
       mov       [rax+10],ecx
       movzx     eax,dx
       test      eax,eax
       jne       short M01_L36
       call      qword ptr [7FFBEC2246C0]
       mov       edx,eax
       mov       [rbp-88],edx
       jmp       short M01_L37
M01_L36:
       sar       edx,10
       mov       [rbp-88],edx
M01_L37:
       mov       rcx,offset MT_System.Buffers.SharedArrayPoolStatics
       call      qword ptr [7FFBEBB75740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       eax,[rbp-88]
       xor       edx,edx
       div       dword ptr [7FFBEBABB170]
       mov       eax,edx
       xor       edx,edx
       jmp       near ptr M01_L41
M01_L38:
       cmp       eax,[r12+8]
       jae       near ptr M01_L74
       mov       [rbp-80],eax
       mov       ecx,eax
       mov       r8,[r12+rcx*8+10]
       mov       [rbp-100],r8
       cmp       [r8],r8b
       xor       r10d,r10d
       mov       [rbp-0F8],r10
       mov       rcx,r8
       call      qword ptr [7FFBEC08E3B8]; System.Threading.Monitor.Enter(System.Object)
       mov       r8,[rbp-100]
       mov       rcx,[r8+8]
       mov       eax,[r8+10]
       dec       eax
       cmp       [rcx+8],eax
       jbe       short M01_L39
       mov       edx,eax
       mov       r10,[rcx+rdx*8+10]
       mov       [rbp-0F8],r10
       mov       r10d,eax
       xor       r9d,r9d
       mov       [rcx+r10*8+10],r9
       mov       [r8+10],eax
M01_L39:
       mov       rcx,r8
       call      qword ptr [7FFBEBB76820]; System.Threading.Monitor.Exit(System.Object)
       mov       rcx,[rbp-0F8]
       test      rcx,rcx
       jne       short M01_L42
       mov       eax,[rbp-80]
       inc       eax
       mov       ecx,eax
       cmp       [r12+8],ecx
       jne       short M01_L40
       xor       ecx,ecx
M01_L40:
       mov       edx,[rbp-84]
       inc       edx
       mov       eax,ecx
M01_L41:
       mov       [rbp-84],edx
       cmp       [r12+8],edx
       jg        near ptr M01_L38
       jmp       short M01_L43
M01_L42:
       mov       r12,rcx
       jmp       short M01_L44
M01_L43:
       xor       r12d,r12d
M01_L44:
       test      r12,r12
       je        short M01_L45
       cmp       byte ptr [r15+9D],0
       je        near ptr M01_L01
       mov       rcx,r12
       call      qword ptr [7FFBEBF8D830]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rbp-70],eax
       mov       edx,[r12+8]
       mov       [rbp-74],edx
       mov       rcx,rdi
       call      qword ptr [7FFBEBF8D830]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       dword ptr [rsp+20],4
       mov       edx,[rbp-70]
       mov       r8d,[rbp-74]
       mov       rcx,r15
       call      qword ptr [7FFBEC224678]
       jmp       near ptr M01_L01
M01_L45:
       mov       edx,100
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r12,rax
       cmp       byte ptr [r15+9D],0
       je        near ptr M01_L01
       jmp       short M01_L47
M01_L46:
       mov       ecx,100
       mov       rdx,21A2AE36F28
       call      qword ptr [7FFBEBE0D8C0]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
       jmp       short M01_L45
M01_L47:
       mov       rcx,r12
       call      qword ptr [7FFBEBF8D830]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rbp-6C],eax
       mov       rcx,rdi
       call      qword ptr [7FFBEBF8D830]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       edx,[rbp-6C]
       mov       r8d,100
       mov       rcx,r15
       call      qword ptr [7FFBEC224678]
       mov       rcx,rdi
       call      qword ptr [7FFBEBF8D830]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       rcx,[rdi+10]
       mov       edx,1
       mov       r8d,2
       cmp       dword ptr [rcx+8],4
       cmovg     edx,r8d
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       [rsp+28],edx
       mov       rcx,r15
       mov       edx,[rbp-6C]
       mov       r8d,100
       call      qword ptr [7FFBEC2246D8]
       jmp       near ptr M01_L01
M01_L48:
       lea       rcx,[rbp-68]
       mov       edx,ebx
       xor       r8d,r8d
       call      qword ptr [7FFBEC2247C8]
       jmp       near ptr M01_L09
M01_L49:
       lea       rcx,[rbp-68]
       call      qword ptr [7FFBEC2247F8]
       jmp       near ptr M01_L02
M01_L50:
       test      rcx,rcx
       je        short M01_L51
       call      qword ptr [7FFBEC105680]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider)
       jmp       short M01_L52
M01_L51:
       call      qword ptr [7FFBEBB7D2A8]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
M01_L52:
       mov       r8,[rax+28]
       test      r8,r8
       jne       short M01_L53
       xor       r9d,r9d
       xor       ecx,ecx
       jmp       short M01_L54
M01_L53:
       lea       r9,[r8+0C]
       mov       ecx,[r8+8]
M01_L54:
       mov       [rbp-0D0],r9
       mov       [rbp-0C8],ecx
       mov       [rbp-0E0],r15
       mov       [rbp-0D8],edi
       lea       r8,[rbp-98]
       mov       [rsp+20],r8
       lea       r8,[rbp-0D0]
       lea       r9,[rbp-0E0]
       mov       ecx,ebx
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFBEC225A88]
       mov       r15d,eax
       jmp       near ptr M01_L08
M01_L55:
       xor       eax,eax
       mov       [rbp-98],eax
       xor       r15d,r15d
       jmp       near ptr M01_L07
M01_L56:
       call      qword ptr [7FFBEBD4F228]
       int       3
M01_L57:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFBEC224750]
       mov       rsi,rax
       mov       ecx,29B
       mov       rdx,7FFBEBAB4000
       call      qword ptr [7FFBEBB7F228]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFBEBEF6130]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L58:
       mov       rcx,offset MT_System.Threading.ProcessorIdCache
       call      qword ptr [7FFBEBB75740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M01_L14
M01_L59:
       mov       ecx,9
       call      qword ptr [7FFBEC2246A8]
       mov       eax,[rax+10]
       mov       [rbp-0B4],eax
       mov       ecx,9
       call      qword ptr [7FFBEC2246A8]
       mov       edx,[rbp-0B4]
       lea       ecx,[rdx-1]
       mov       [rax+10],ecx
       movzx     eax,dx
       test      eax,eax
       jne       short M01_L60
       call      qword ptr [7FFBEC2246C0]
       mov       edx,eax
       jmp       near ptr M01_L15
M01_L60:
       sar       edx,10
       mov       [rbp-0B0],edx
       mov       edx,[rbp-0B0]
       jmp       near ptr M01_L15
M01_L61:
       mov       [rbp-0B0],edx
       mov       rcx,offset MT_System.Buffers.SharedArrayPoolStatics
       call      qword ptr [7FFBEBB75740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       edx,[rbp-0B0]
       jmp       near ptr M01_L16
M01_L62:
       mov       ecx,eax
       mov       rdx,[rbp-118]
       call      qword ptr [7FFBEC224108]
       jmp       near ptr M01_L21
M01_L63:
       mov       eax,[rbp-0AC]
       inc       eax
       mov       ecx,eax
       mov       edx,[rbp-0E4]
       cmp       edx,ecx
       jne       short M01_L64
       xor       ecx,ecx
M01_L64:
       mov       r8d,[rbp-0E8]
       dec       r8d
       mov       [rbp-0E8],r8d
       mov       eax,ecx
       jne       near ptr M01_L17
M01_L65:
       xor       r12d,r12d
       jmp       near ptr M01_L22
M01_L66:
       mov       rcx,rsi
       call      qword ptr [7FFBEBD477F8]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       mov       r9d,eax
       jmp       near ptr M01_L24
M01_L67:
       vmovsd    xmm1,qword ptr [7FFBEBC29530]
       call      qword ptr [7FFBEC225C68]
       mov       [rbp-40],rax
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.NumericExtensions
       call      qword ptr [7FFBEBB75728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1D996001DC8
       mov       rcx,[rcx]
       cmp       [rcx],ecx
       call      qword ptr [7FFBEBE0FEE8]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].get_Value()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp-0F0],rax
       lea       rcx,[rbp-40]
       call      qword ptr [7FFBEC17D1D0]
       test      eax,eax
       jle       short M01_L68
       lea       rcx,[rbp-40]
       call      qword ptr [7FFBEC17D1D0]
       mov       edx,eax
       mov       rcx,[rbp-0F0]
       cmp       [rcx],cl
       call      qword ptr [7FFBEBE07198]; System.Text.StringBuilder.AppendSpanFormattable[[System.Int32, System.Private.CoreLib]](Int32)
       mov       rbx,rax
       lea       rcx,[rbp-40]
       call      qword ptr [7FFBEC17D1D0]
       mov       rdx,21A2AE40760
       mov       rcx,21A2AE40738
       cmp       eax,1
       cmovne    rdx,rcx
       mov       rcx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FFBEBE07228]; System.Text.StringBuilder.Append(System.String)
M01_L68:
       lea       rcx,[rbp-40]
       call      qword ptr [7FFBEC17D200]
       test      eax,eax
       jle       short M01_L70
       mov       rcx,[rbp-0F0]
       mov       edx,[rcx+1C]
       add       edx,[rcx+18]
       test      edx,edx
       jle       short M01_L69
       mov       edx,20
       call      qword ptr [7FFBEBE07180]; System.Text.StringBuilder.Append(Char)
M01_L69:
       lea       rcx,[rbp-40]
       call      qword ptr [7FFBEC17D200]
       mov       edx,eax
       mov       rcx,[rbp-0F0]
       call      qword ptr [7FFBEBE07198]; System.Text.StringBuilder.AppendSpanFormattable[[System.Int32, System.Private.CoreLib]](Int32)
       mov       rbx,rax
       lea       rcx,[rbp-40]
       call      qword ptr [7FFBEC17D200]
       mov       rdx,21A2AE407A8
       mov       rcx,21A2AE40780
       cmp       eax,1
       cmovne    rdx,rcx
       mov       rcx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FFBEBE07228]; System.Text.StringBuilder.Append(System.String)
M01_L70:
       lea       rcx,[rbp-40]
       call      qword ptr [7FFBEC17D230]
       test      eax,eax
       jg        short M01_L71
       mov       rcx,[rbp-0F0]
       mov       edx,[rcx+1C]
       add       edx,[rcx+18]
       jne       short M01_L73
M01_L71:
       mov       rcx,[rbp-0F0]
       mov       edx,[rcx+1C]
       add       edx,[rcx+18]
       test      edx,edx
       jle       short M01_L72
       mov       edx,20
       call      qword ptr [7FFBEBE07180]; System.Text.StringBuilder.Append(Char)
M01_L72:
       lea       rcx,[rbp-40]
       call      qword ptr [7FFBEC17D230]
       mov       edx,eax
       mov       rcx,[rbp-0F0]
       call      qword ptr [7FFBEBE07198]; System.Text.StringBuilder.AppendSpanFormattable[[System.Int32, System.Private.CoreLib]](Int32)
       mov       rbx,rax
       lea       rcx,[rbp-40]
       call      qword ptr [7FFBEC17D230]
       mov       rdx,21A2AE407F8
       mov       rcx,21A2AE407D0
       cmp       eax,1
       cmovne    rdx,rcx
       mov       rcx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FFBEBE07228]; System.Text.StringBuilder.Append(System.String)
       mov       rcx,[rbp-0F0]
M01_L73:
       call      qword ptr [7FFBEBE16DE8]; System.Text.StringBuilder.ToString()
       mov       rbx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.NumericExtensions
       call      qword ptr [7FFBEBB75728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1D996001DC8
       mov       rcx,[rcx]
       cmp       [rcx],ecx
       call      qword ptr [7FFBEBE0FEE8]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].get_Value()
       mov       rsi,rax
       mov       rcx,[rbp-0F0]
       xor       edx,edx
       call      qword ptr [7FFBEC1753B0]; System.Text.StringBuilder.set_Length(Int32)
       mov       rcx,rsi
       mov       rdx,[rbp-0F0]
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       rax,rbx
       add       rsp,118
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
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       sub       rsp,38
       test      byte ptr [7FFBEC16AF80],1
       jne       short M01_L75
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.NumericExtensions
       call      qword ptr [7FFBEBB75728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
M01_L75:
       mov       rcx,1D996001DC8
       mov       rcx,[rcx]
       cmp       [rcx],ecx
       call      qword ptr [7FFBEBE0FEE8]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].get_Value()
       mov       rbx,rax
       mov       rcx,[rbp-0F0]
       cmp       [rcx],cl
       xor       edx,edx
       call      qword ptr [7FFBEC1753B0]; System.Text.StringBuilder.set_Length(Int32)
       mov       rcx,rbx
       mov       rdx,[rbp-0F0]
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       add       rsp,38
       ret
; Total bytes of code 3336
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.NumericExtensionsBenchmark.FormatTimeLongHours()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+140]
       call      qword ptr [7FFBEC1AD650]; DotNetTips.Spargine.Extensions.NumericExtensions.FormatTime(Int64)
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
; Total bytes of code 63
```
```assembly
; DotNetTips.Spargine.Extensions.NumericExtensions.FormatTime(Int64)
; 		if (milliseconds < 1000)
; 		^^^^^^^^^^^^^^^^^^^^^^^^
; 			return $"{milliseconds} millisecond{(milliseconds == 1 ? string.Empty : "s")}";
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var timeSpan = TimeSpan.FromMilliseconds(milliseconds);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var sb = _stringBuilderPool.Value.Get();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			if (timeSpan.Hours > 0)
; 			^^^^^^^^^^^^^^^^^^^^^^^
; 				_ = sb.Append(timeSpan.Hours).Append(timeSpan.Hours == 1 ? " hour" : " hours");
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			if (timeSpan.Minutes > 0)
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
; 				if (sb.Length > 0)
; 				^^^^^^^^^^^^^^^^^^
; 				{ _ = sb.Append(ControlChars.Space); }
; 				  ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 				_ = sb.Append(timeSpan.Minutes).Append(timeSpan.Minutes == 1 ? " minute" : " minutes");
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			if (timeSpan.Seconds > 0 || sb.Length == 0)
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 				if (sb.Length > 0)
; 				^^^^^^^^^^^^^^^^^^
; 				{ _ = sb.Append(ControlChars.Space); }
; 				  ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 				_ = sb.Append(timeSpan.Seconds).Append(timeSpan.Seconds == 1 ? " second" : " seconds");
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			return sb.ToString();
; 			^^^^^^^^^^^^^^^^^^^^^
; 	}
; 	^
; 			_stringBuilderPool.Value.Return(sb.Clear());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		}
; 		^
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0C8
       lea       rbp,[rsp+0F0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-0C0],ymm4
       vmovdqu   ymmword ptr [rbp-0A0],ymm4
       vmovdqu   ymmword ptr [rbp-80],ymm4
       vmovdqu   ymmword ptr [rbp-60],ymm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       xor       eax,eax
       mov       [rbp-30],rax
       mov       rbx,rcx
       cmp       rbx,3E8
       jl        near ptr M01_L55
       mov       rcx,346DC5D638865
       cmp       rbx,rcx
       jg        near ptr M01_L59
       imul      rbx,2710
       mov       rcx,21B7D401DC8
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0
       jne       near ptr M01_L60
       mov       rsi,[rcx+18]
M01_L00:
       mov       rcx,offset MT_Microsoft.Extensions.ObjectPool.DefaultObjectPool<System.Text.StringBuilder>
       cmp       [rsi],rcx
       jne       near ptr M01_L64
       mov       rcx,[rsi+20]
       mov       [rbp-58],rcx
       cmp       qword ptr [rbp-58],0
       je        near ptr M01_L62
       lea       rcx,[rsi+20]
       mov       r8,[rbp-58]
       test      rcx,rcx
       je        near ptr M01_L61
       xor       edx,edx
       call      00007FFC4B793270
       cmp       rax,[rbp-58]
       jne       near ptr M01_L62
M01_L01:
       mov       rsi,[rbp-58]
M01_L02:
       xor       ecx,ecx
       mov       [rbp-58],rcx
M01_L03:
       mov       [rbp-0B8],rsi
       mov       rdx,3D157FAB34C210B5
       mov       rax,rdx
       imul      rbx
       mov       rdi,rdx
       shr       rdi,3F
       sar       rdx,21
       add       rdi,rdx
       mov       rdx,2AAAAAAAAAAAAAAB
       mov       rax,rdx
       imul      rdi
       mov       rcx,rdx
       shr       rcx,3F
       sar       rdx,2
       add       rcx,rdx
       lea       rcx,[rcx+rcx*2]
       shl       rcx,3
       sub       rdi,rcx
       test      edi,edi
       jle       near ptr M01_L12
       mov       ecx,edi
       mov       rax,[rsi+8]
       mov       rdx,rax
       mov       r8d,[rsi+18]
       mov       r10d,r8d
       mov       eax,[rax+8]
       sub       eax,r8d
       mov       r8d,r10d
       mov       r9d,eax
       add       r8,r9
       mov       r9d,[rdx+8]
       cmp       r8,r9
       ja        near ptr M01_L46
       mov       r8d,r10d
       lea       rdx,[rdx+r8*2+10]
       mov       r8d,ecx
       or        r8d,1
       lzcnt     r8d,r8d
       xor       r8d,1F
       mov       r10d,ecx
       mov       r9,7FFC4967B880
       add       r10,[r9+r8*8]
       sar       r10,20
       cmp       r10d,eax
       jle       short M01_L04
       xor       r10d,r10d
       mov       [rbp-60],r10d
       jmp       near ptr M01_L09
M01_L04:
       mov       [rbp-60],r10d
       mov       [rbp-68],rdx
       movsxd    rax,r10d
       lea       rax,[rdx+rax*2]
       mov       edx,ecx
       cmp       edx,0A
       jb        short M01_L07
       cmp       ecx,64
       jb        short M01_L06
       mov       rsi,25C124220A4
M01_L05:
       add       rax,0FFFFFFFFFFFFFFFC
       mov       r8d,edx
       imul      r8,51EB851F
       shr       r8,25
       imul      r10d,r8d,64
       sub       edx,r10d
       mov       r10,rsi
       shl       edx,2
       mov       edx,[r10+rdx]
       mov       [rax],edx
       cmp       r8d,64
       mov       edx,r8d
       jae       short M01_L05
M01_L06:
       cmp       edx,0A
       jb        short M01_L07
       add       rax,0FFFFFFFFFFFFFFFC
       mov       rsi,25C124220A4
       shl       edx,2
       mov       edx,[rsi+rdx]
       mov       [rax],edx
       jmp       short M01_L08
M01_L07:
       add       edx,30
       mov       [rax-2],dx
M01_L08:
       xor       eax,eax
       mov       [rbp-68],rax
       mov       r10d,1
M01_L09:
       xor       eax,eax
       mov       [rbp-68],rax
       test      r10d,r10d
       je        near ptr M01_L36
       mov       ecx,[rbp-60]
       mov       rsi,[rbp-0B8]
       add       [rsi+18],ecx
       mov       r14,rsi
M01_L10:
       mov       r8,25C12430760
       mov       rcx,25C12430738
       cmp       edi,1
       cmovne    r8,rcx
       cmp       [r14],r14b
       lea       rdx,[r8+0C]
       mov       edi,[r8+8]
       test      edi,edi
       je        short M01_L12
       mov       r8,[r14+8]
       mov       r15d,[r14+18]
       lea       ecx,[r15+rdi]
       cmp       ecx,[r8+8]
       ja        near ptr M01_L38
       movsxd    rcx,r15d
       lea       rcx,[r8+rcx*2+10]
       cmp       edi,2
       jle       near ptr M01_L37
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFBEBB85818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L11:
       add       edi,r15d
       mov       [r14+18],edi
M01_L12:
       mov       rdx,1CA213D840BAF7D5
       mov       rax,rdx
       imul      rbx
       mov       rdi,rdx
       shr       rdi,3F
       sar       rdx,1A
       add       rdi,rdx
       mov       rdx,8888888888888889
       mov       rax,rdx
       imul      rdi
       add       rdx,rdi
       mov       rcx,rdx
       shr       rcx,3F
       sar       rdx,5
       add       rcx,rdx
       imul      rcx,3C
       sub       rdi,rcx
       test      edi,edi
       jle       near ptr M01_L22
       mov       rsi,[rbp-0B8]
       mov       ecx,[rsi+1C]
       mov       edx,[rsi+18]
       add       ecx,edx
       test      ecx,ecx
       jle       short M01_L13
       mov       ecx,edx
       mov       rax,[rsi+8]
       cmp       [rax+8],ecx
       jbe       near ptr M01_L39
       mov       word ptr [rax+rcx*2+10],20
       inc       edx
       mov       [rsi+18],edx
M01_L13:
       mov       ecx,edi
       mov       rax,[rsi+8]
       mov       rdx,rax
       mov       r8d,[rsi+18]
       mov       r10d,r8d
       mov       eax,[rax+8]
       sub       eax,r8d
       mov       r8d,r10d
       mov       r9d,eax
       add       r8,r9
       mov       r9d,[rdx+8]
       cmp       r8,r9
       ja        near ptr M01_L46
       mov       r8d,r10d
       lea       rdx,[rdx+r8*2+10]
       mov       r8d,ecx
       or        r8d,1
       lzcnt     r8d,r8d
       xor       r8d,1F
       mov       r10d,ecx
       mov       r9,7FFC4967B880
       add       r10,[r9+r8*8]
       sar       r10,20
       cmp       r10d,eax
       jle       short M01_L14
       xor       r10d,r10d
       mov       [rbp-70],r10d
       jmp       near ptr M01_L19
M01_L14:
       mov       [rbp-70],r10d
       mov       [rbp-78],rdx
       movsxd    rax,r10d
       lea       rax,[rdx+rax*2]
       mov       edx,ecx
       cmp       ecx,0A
       jb        short M01_L17
       cmp       ecx,64
       jb        short M01_L16
       mov       r8,25C124220A4
M01_L15:
       add       rax,0FFFFFFFFFFFFFFFC
       mov       r10d,edx
       imul      r10,51EB851F
       shr       r10,25
       imul      r9d,r10d,64
       sub       edx,r9d
       mov       r9,r8
       shl       edx,2
       mov       edx,[r9+rdx]
       mov       [rax],edx
       cmp       r10d,64
       mov       edx,r10d
       jae       short M01_L15
M01_L16:
       cmp       edx,0A
       jb        short M01_L17
       add       rax,0FFFFFFFFFFFFFFFC
       mov       r8,25C124220A4
       shl       edx,2
       mov       edx,[r8+rdx]
       mov       [rax],edx
       jmp       short M01_L18
M01_L17:
       add       edx,30
       mov       [rax-2],dx
M01_L18:
       xor       eax,eax
       mov       [rbp-78],rax
       mov       r10d,1
M01_L19:
       xor       eax,eax
       mov       [rbp-78],rax
       test      r10d,r10d
       je        near ptr M01_L40
       mov       ecx,[rbp-70]
       add       [rsi+18],ecx
       mov       r14,rsi
M01_L20:
       mov       r8,25C124307A8
       mov       rcx,25C12430780
       cmp       edi,1
       cmovne    r8,rcx
       cmp       [r14],r14b
       lea       rdx,[r8+0C]
       mov       edi,[r8+8]
       test      edi,edi
       je        short M01_L22
       mov       r8,[r14+8]
       mov       r15d,[r14+18]
       lea       ecx,[r15+rdi]
       cmp       ecx,[r8+8]
       ja        near ptr M01_L42
       movsxd    rcx,r15d
       lea       rcx,[r8+rcx*2+10]
       cmp       edi,2
       jle       near ptr M01_L41
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFBEBB85818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L21:
       add       edi,r15d
       mov       [r14+18],edi
M01_L22:
       mov       rdx,0D6BF94D5E57A42BD
       mov       rax,rdx
       imul      rbx
       add       rbx,rdx
       mov       rdi,rbx
       shr       rdi,3F
       sar       rbx,17
       add       rbx,rdi
       mov       rdx,8888888888888889
       mov       rax,rdx
       imul      rbx
       add       rdx,rbx
       mov       rcx,rdx
       shr       rcx,3F
       sar       rdx,5
       add       rcx,rdx
       imul      rcx,3C
       sub       rbx,rcx
       test      ebx,ebx
       jle       near ptr M01_L43
M01_L23:
       mov       rsi,[rbp-0B8]
       mov       ecx,[rsi+1C]
       mov       edx,[rsi+18]
       add       ecx,edx
       test      ecx,ecx
       jle       short M01_L24
       mov       ecx,edx
       mov       rax,[rsi+8]
       cmp       [rax+8],ecx
       jbe       near ptr M01_L44
       cmp       ecx,[rax+8]
       jae       near ptr M01_L52
       mov       word ptr [rax+rcx*2+10],20
       lea       ecx,[rdx+1]
       mov       [rsi+18],ecx
M01_L24:
       mov       eax,ebx
       mov       [rbp-7C],eax
       mov       rax,[rsi+8]
       mov       rcx,rax
       mov       edx,[rsi+18]
       mov       r8d,edx
       mov       edi,[rax+8]
       sub       edi,edx
       test      rcx,rcx
       je        near ptr M01_L45
       mov       eax,r8d
       mov       edx,edi
       add       rax,rdx
       mov       edx,[rcx+8]
       cmp       rax,rdx
       ja        near ptr M01_L46
       lea       r14,[rcx+r8*2+10]
M01_L25:
       mov       r15d,[rbp-7C]
       test      r15d,r15d
       jl        near ptr M01_L47
       mov       eax,r15d
       or        eax,1
       lzcnt     eax,eax
       xor       eax,1F
       mov       ecx,r15d
       mov       rdx,7FFC4967B880
       add       rcx,[rdx+rax*8]
       sar       rcx,20
       cmp       ecx,edi
       jle       short M01_L26
       xor       ecx,ecx
       mov       [rbp-88],ecx
       jmp       near ptr M01_L31
M01_L26:
       mov       [rbp-88],ecx
       mov       [rbp-90],r14
       movsxd    rax,ecx
       lea       rax,[r14+rax*2]
       cmp       r15d,0A
       jb        short M01_L29
       cmp       r15d,64
       jb        short M01_L28
       mov       r8,25C124220A4
M01_L27:
       add       rax,0FFFFFFFFFFFFFFFC
       mov       ecx,r15d
       imul      rcx,51EB851F
       shr       rcx,25
       imul      edx,ecx,64
       sub       r15d,edx
       mov       rdx,r8
       shl       r15d,2
       mov       r10d,r15d
       mov       edx,[rdx+r10]
       mov       [rax],edx
       cmp       ecx,64
       mov       r15d,ecx
       jae       short M01_L27
M01_L28:
       cmp       r15d,0A
       jb        short M01_L29
       add       rax,0FFFFFFFFFFFFFFFC
       mov       r8,25C124220A4
       mov       rcx,r8
       lea       edx,[r15*4]
       mov       ecx,[rcx+rdx]
       mov       [rax],ecx
       jmp       short M01_L30
M01_L29:
       lea       ecx,[r15+30]
       mov       [rax-2],cx
M01_L30:
       xor       eax,eax
       mov       [rbp-90],rax
       mov       ecx,1
M01_L31:
       xor       eax,eax
       mov       [rbp-90],rax
M01_L32:
       test      ecx,ecx
       je        near ptr M01_L50
       mov       ecx,[rbp-88]
       add       [rsi+18],ecx
       mov       rdi,rsi
M01_L33:
       mov       r8,25C124307F8
       mov       rcx,25C124307D0
       cmp       ebx,1
       cmovne    r8,rcx
       cmp       [rdi],dil
       lea       rdx,[r8+0C]
       mov       ebx,[r8+8]
       test      ebx,ebx
       je        short M01_L35
       mov       r8,[rdi+8]
       mov       r14d,[rdi+18]
       lea       ecx,[r14+rbx]
       cmp       ecx,[r8+8]
       ja        near ptr M01_L53
       movsxd    rcx,r14d
       lea       rcx,[r8+rcx*2+10]
       cmp       ebx,2
       jle       near ptr M01_L51
       mov       r8d,ebx
       add       r8,r8
       call      qword ptr [7FFBEBB85818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L34:
       add       ebx,r14d
       mov       [rdi+18],ebx
M01_L35:
       mov       rcx,rsi
       call      qword ptr [7FFBEBE2CC00]; System.Text.StringBuilder.ToString()
       mov       [rbp-0C0],rax
       jmp       near ptr M01_L54
M01_L36:
       mov       rsi,[rbp-0B8]
       call      qword ptr [7FFBEBE17AE0]; System.Number.Int32ToDecStr(Int32)
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFBEBE17AF8]; System.Text.StringBuilder.Append(System.String)
       mov       r14,rax
       jmp       near ptr M01_L10
M01_L37:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       edi,2
       jne       near ptr M01_L11
       movzx     edx,word ptr [rdx+2]
       mov       [rcx+2],dx
       jmp       near ptr M01_L11
M01_L38:
       mov       rcx,r14
       mov       r8d,edi
       call      qword ptr [7FFBEBE17AB0]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M01_L12
M01_L39:
       mov       rcx,rsi
       mov       edx,20
       call      qword ptr [7FFBEBE17C78]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M01_L13
M01_L40:
       call      qword ptr [7FFBEBE17AE0]; System.Number.Int32ToDecStr(Int32)
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFBEBE17AF8]; System.Text.StringBuilder.Append(System.String)
       mov       r14,rax
       jmp       near ptr M01_L20
M01_L41:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       edi,2
       jne       near ptr M01_L21
       movzx     edx,word ptr [rdx+2]
       mov       [rcx+2],dx
       jmp       near ptr M01_L21
M01_L42:
       mov       rcx,r14
       mov       r8d,edi
       call      qword ptr [7FFBEBE17AB0]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M01_L22
M01_L43:
       mov       rsi,[rbp-0B8]
       mov       ecx,[rsi+1C]
       mov       edx,[rsi+18]
       add       edx,ecx
       jne       near ptr M01_L35
       jmp       near ptr M01_L23
M01_L44:
       mov       rcx,rsi
       mov       edx,20
       call      qword ptr [7FFBEBE17C78]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M01_L24
M01_L45:
       or        r8d,edi
       jne       short M01_L46
       xor       r14d,r14d
       xor       edi,edi
       jmp       near ptr M01_L25
M01_L46:
       mov       rsi,[rbp-0B8]
       call      qword ptr [7FFBEBD5F228]
       int       3
M01_L47:
       call      qword ptr [7FFBEBB8D2A8]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
       mov       r8,[rax+28]
       test      r8,r8
       jne       short M01_L48
       xor       r9d,r9d
       xor       ecx,ecx
       jmp       short M01_L49
M01_L48:
       lea       r9,[r8+0C]
       mov       ecx,[r8+8]
M01_L49:
       mov       [rbp-0A0],r9
       mov       [rbp-98],ecx
       mov       [rbp-0B0],r14
       mov       [rbp-0A8],edi
       lea       r8,[rbp-88]
       mov       [rsp+20],r8
       lea       r8,[rbp-0A0]
       lea       r9,[rbp-0B0]
       mov       ecx,r15d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFBEC234F60]
       mov       ecx,eax
       jmp       near ptr M01_L32
M01_L50:
       mov       ecx,[rbp-7C]
       call      qword ptr [7FFBEBE17AE0]; System.Number.Int32ToDecStr(Int32)
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFBEBE17AF8]; System.Text.StringBuilder.Append(System.String)
       mov       rdi,rax
       jmp       near ptr M01_L33
M01_L51:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       ebx,2
       jne       near ptr M01_L34
       movzx     edx,word ptr [rdx+2]
       mov       [rcx+2],dx
       jmp       near ptr M01_L34
M01_L52:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M01_L53:
       mov       rcx,rdi
       mov       r8d,ebx
       call      qword ptr [7FFBEBE17AB0]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M01_L35
M01_L54:
       call      M01_L65
       nop
       mov       rax,[rbp-0C0]
       add       rsp,0C8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L55:
       lea       rcx,[rbp-50]
       mov       edx,0C
       mov       r8d,2
       call      qword ptr [7FFBEBB8C270]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler..ctor(Int32, Int32)
       lea       rcx,[rbp-50]
       mov       rdx,rbx
       call      qword ptr [7FFBEC1A6FE8]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Int64, System.Private.CoreLib]](Int64)
       mov       ecx,[rbp-40]
       cmp       ecx,[rbp-30]
       jbe       short M01_L56
       call      qword ptr [7FFBEBD5F228]
       int       3
M01_L56:
       mov       rdx,[rbp-38]
       mov       eax,ecx
       lea       rdx,[rdx+rax*2]
       mov       eax,[rbp-30]
       sub       eax,ecx
       cmp       eax,0C
       jb        short M01_L57
       vmovups   xmm0,[7FFBEC282540]
       vmovups   [rdx],xmm0
       mov       rcx,64006E006F0063
       mov       [rdx+10],rcx
       mov       ecx,[rbp-40]
       add       ecx,0C
       mov       [rbp-40],ecx
       jmp       short M01_L58
M01_L57:
       lea       rcx,[rbp-50]
       mov       rdx,25C12430708
       call      qword ptr [7FFBEC1A7060]
M01_L58:
       mov       rdx,25C12420008
       mov       rcx,25C1242B4B8
       cmp       rbx,1
       cmovne    rdx,rcx
       lea       rcx,[rbp-50]
       call      qword ptr [7FFBEBE1E310]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted(System.String)
       lea       rcx,[rbp-50]
       call      qword ptr [7FFBEBB8C2A0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       nop
       add       rsp,0C8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L59:
       call      qword ptr [7FFBEC235290]
       int       3
M01_L60:
       call      qword ptr [7FFBEBE1FF78]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rsi,rax
       jmp       near ptr M01_L00
M01_L61:
       call      qword ptr [7FFBEC234F00]
       int       3
M01_L62:
       mov       rcx,[rsi+18]
       lea       rdx,[rbp-58]
       cmp       [rcx],ecx
       call      qword ptr [7FFBEC1A5368]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M01_L63
       add       rsi,2C
       lock dec  dword ptr [rsi]
       jmp       near ptr M01_L01
M01_L63:
       mov       rax,[rsi+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       rsi,rax
       jmp       near ptr M01_L02
M01_L64:
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rsi,rax
       jmp       near ptr M01_L03
M01_L65:
       sub       rsp,28
       mov       rcx,21B7D401DC8
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0
       je        short M01_L66
       call      qword ptr [7FFBEBE1FF78]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rbx,rax
       jmp       short M01_L67
M01_L66:
       mov       rbx,[rcx+18]
M01_L67:
       mov       rsi,[rbp-0B8]
       cmp       dword ptr [rsi+20],0
       jge       short M01_L68
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,3AD
       mov       rdx,7FFBEBAC4000
       call      qword ptr [7FFBEBB8F228]
       mov       rbx,rax
       call      qword ptr [7FFBEC2353B0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFBEBE1D950]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M01_L68:
       cmp       qword ptr [rsi+10],0
       jne       short M01_L69
       xor       ecx,ecx
       mov       [rsi+18],rcx
       jmp       near ptr M01_L76
M01_L69:
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       mov       r8d,ecx
       neg       r8d
       test      r8d,r8d
       jle       short M01_L70
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFBEC235518]
       jmp       near ptr M01_L76
M01_L70:
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFBEC235530]
       mov       rdi,rax
       cmp       rdi,rsi
       je        near ptr M01_L75
       mov       rax,[rsi+8]
       mov       ecx,[rax+8]
       add       ecx,[rsi+1C]
       mov       eax,[rsi+1C]
       add       eax,[rsi+18]
       lea       edx,[rax+rax*2]
       add       edx,edx
       mov       r8d,66666667
       mov       eax,r8d
       imul      edx
       mov       eax,edx
       shr       eax,1F
       sar       edx,1
       add       edx,eax
       mov       rax,[rsi+8]
       mov       eax,[rax+8]
       cmp       edx,eax
       cmovl     edx,eax
       cmp       ecx,edx
       cmovg     ecx,edx
       sub       ecx,[rdi+1C]
       mov       rdx,[rdi+8]
       cmp       [rdx+8],ecx
       jge       short M01_L73
       cmp       ecx,400
       jge       short M01_L71
       movsxd    rdx,ecx
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
       jmp       short M01_L72
M01_L71:
       xor       edx,edx
       call      qword ptr [7FFBEC11F180]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       r14,rax
M01_L72:
       mov       rcx,[rdi+8]
       mov       r8d,[rdi+18]
       mov       rdx,r14
       call      qword ptr [7FFBEBB8F5A0]; System.Array.Copy(System.Array, System.Array, Int32)
       lea       rcx,[rsi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M01_L74
M01_L73:
       mov       rdx,[rdi+8]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
M01_L74:
       mov       rdx,[rdi+10]
       lea       rcx,[rsi+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rdi+1C]
       mov       [rsi+1C],ecx
M01_L75:
       mov       ecx,[rdi+1C]
       neg       ecx
       mov       [rsi+18],ecx
M01_L76:
       mov       rdx,offset MT_Microsoft.Extensions.ObjectPool.DefaultObjectPool<System.Text.StringBuilder>
       cmp       [rbx],rdx
       jne       short M01_L80
       mov       rax,[rbx+10]
       mov       rdx,rsi
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       test      eax,eax
       je        short M01_L81
       cmp       qword ptr [rbx+20],0
       jne       short M01_L78
       lea       rcx,[rbx+20]
       test      rcx,rcx
       jne       short M01_L77
       call      qword ptr [7FFBEC234F00]
       int       3
M01_L77:
       mov       rdx,rsi
       xor       r8d,r8d
       call      00007FFC4B793270
       test      rax,rax
       je        short M01_L81
M01_L78:
       lea       rcx,[rbx+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[rbx+28]
       jg        short M01_L79
       mov       rbx,[rbx+18]
       mov       rcx,[rbx+10]
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFBEC2355D8]
       test      eax,eax
       jne       short M01_L81
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFBEC2355F0]
       jmp       short M01_L81
M01_L79:
       add       rbx,2C
       lock dec  dword ptr [rbx]
       jmp       short M01_L81
M01_L80:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
M01_L81:
       nop
       add       rsp,28
       ret
; Total bytes of code 3005
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.NumericExtensionsBenchmark.FormatTimeLongMilliseconds()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       ecx,1F4
       call      qword ptr [7FFBEC15D1A0]; DotNetTips.Spargine.Extensions.NumericExtensions.FormatTime(Int64)
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
; Total bytes of code 61
```
```assembly
; DotNetTips.Spargine.Extensions.NumericExtensions.FormatTime(Int64)
; 		if (milliseconds < 1000)
; 		^^^^^^^^^^^^^^^^^^^^^^^^
; 			return $"{milliseconds} millisecond{(milliseconds == 1 ? string.Empty : "s")}";
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var timeSpan = TimeSpan.FromMilliseconds(milliseconds);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var sb = _stringBuilderPool.Value.Get();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			if (timeSpan.Hours > 0)
; 			^^^^^^^^^^^^^^^^^^^^^^^
; 				_ = sb.Append(timeSpan.Hours).Append(timeSpan.Hours == 1 ? " hour" : " hours");
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			if (timeSpan.Minutes > 0)
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
; 				if (sb.Length > 0)
; 				^^^^^^^^^^^^^^^^^^
; 				{ _ = sb.Append(ControlChars.Space); }
; 				  ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 				_ = sb.Append(timeSpan.Minutes).Append(timeSpan.Minutes == 1 ? " minute" : " minutes");
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			if (timeSpan.Seconds > 0 || sb.Length == 0)
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 				if (sb.Length > 0)
; 				^^^^^^^^^^^^^^^^^^
; 				{ _ = sb.Append(ControlChars.Space); }
; 				  ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 				_ = sb.Append(timeSpan.Seconds).Append(timeSpan.Seconds == 1 ? " second" : " seconds");
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			return sb.ToString();
; 			^^^^^^^^^^^^^^^^^^^^^
; 	}
; 	^
; 			_stringBuilderPool.Value.Return(sb.Clear());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		}
; 		^
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,118
       lea       rbp,[rsp+150]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-0E0],ymm4
       vmovdqu   ymmword ptr [rbp-0C0],ymm4
       vmovdqu   ymmword ptr [rbp-0A0],ymm4
       vmovdqu   ymmword ptr [rbp-80],ymm4
       vmovdqu   ymmword ptr [rbp-60],ymm4
       xor       eax,eax
       mov       [rbp-40],rax
       mov       rbx,rcx
       cmp       rbx,3E8
       jge       near ptr M01_L69
       xor       ecx,ecx
       mov       [rbp-68],rcx
       mov       rcx,1C172C00C88
       mov       rsi,[rcx]
       mov       rdi,rsi
       mov       rcx,1C172C00C90
       mov       r14,[rcx]
       mov       r15,r14
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],3
       jle       near ptr M01_L35
       mov       rcx,[rcx+240]
       mov       r13,[rcx+18]
       test      r13,r13
       je        near ptr M01_L35
M01_L00:
       mov       rcx,[r13+10]
       test      rcx,rcx
       je        near ptr M01_L37
       mov       eax,[rcx+8]
       cmp       eax,4
       jle       near ptr M01_L37
       mov       r12,[rcx+50]
       test      r12,r12
       je        near ptr M01_L37
       xor       eax,eax
       mov       [rcx+50],rax
       cmp       byte ptr [r15+9D],0
       jne       near ptr M01_L36
M01_L01:
       mov       [rbp-60],r12
       lea       rdx,[r12+10]
       mov       eax,[r12+8]
       mov       [rbp-50],rdx
       mov       [rbp-48],eax
       xor       edx,edx
       mov       [rbp-58],edx
       mov       byte ptr [rbp-54],0
       cmp       byte ptr [rbp-54],0
       jne       near ptr M01_L51
M01_L02:
       mov       edx,[rbp-58]
       mov       edi,[rbp-48]
       cmp       edx,edi
       ja        near ptr M01_L59
       mov       rax,[rbp-50]
       mov       ecx,edx
       lea       r15,[rax+rcx*2]
       sub       edi,edx
       mov       rcx,[rbp-68]
       test      rbx,rbx
       jl        near ptr M01_L53
       mov       rdx,rbx
       or        rdx,1
       lzcnt     rdx,rdx
       xor       edx,3F
       mov       rcx,7FFC496764F8
       movzx     edx,byte ptr [rcx+rdx]
       mov       rax,7FFC4967C2E0
       cmp       rbx,[rax+rdx*8]
       setb      al
       movzx     eax,al
       sub       edx,eax
       cmp       edx,edi
       jg        near ptr M01_L58
       mov       [rbp-98],edx
       mov       [rbp-0A0],r15
       movsxd    rdx,edx
       lea       rax,[r15+rdx*2]
       mov       rcx,rbx
       cmp       rbx,0A
       jae       near ptr M01_L24
M01_L03:
       add       ecx,30
       mov       [rax-2],cx
M01_L04:
       xor       eax,eax
       mov       [rbp-0A0],rax
       mov       r15d,1
M01_L05:
       xor       eax,eax
       mov       [rbp-0A0],rax
M01_L06:
       test      r15d,r15d
       je        near ptr M01_L52
       mov       ecx,[rbp-58]
       add       ecx,[rbp-98]
       mov       [rbp-58],ecx
M01_L07:
       mov       ecx,[rbp-58]
       mov       edx,[rbp-48]
       cmp       ecx,edx
       ja        near ptr M01_L59
       mov       rax,[rbp-50]
       mov       r8d,ecx
       lea       rax,[rax+r8*2]
       sub       edx,ecx
       cmp       edx,0C
       jb        near ptr M01_L27
       vmovups   xmm0,[7FFBEBC091A0]
       vmovups   [rax],xmm0
       mov       rcx,64006E006F0063
       mov       [rax+10],rcx
       mov       ecx,[rbp-58]
       add       ecx,0C
       mov       [rbp-58],ecx
M01_L08:
       mov       rdi,20207BE0008
       mov       r8,20207BEB4B8
       cmp       rbx,1
       cmovne    rdi,r8
       cmp       byte ptr [rbp-54],0
       jne       near ptr M01_L28
       mov       r8d,[rbp-58]
       mov       edx,[rbp-48]
       cmp       r8d,edx
       ja        near ptr M01_L59
       mov       rcx,[rbp-50]
       mov       eax,r8d
       lea       rcx,[rcx+rax*2]
       sub       edx,r8d
       cmp       [rdi+8],edx
       ja        near ptr M01_L28
       mov       r8d,[rdi+8]
       add       r8,r8
       lea       rdx,[rdi+0C]
       call      qword ptr [7FFBEBB55818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbp-58]
       add       ecx,[rdi+8]
       mov       [rbp-58],ecx
M01_L09:
       mov       ecx,[rbp-58]
       cmp       ecx,[rbp-48]
       ja        near ptr M01_L59
       mov       rax,[rbp-50]
       mov       [rbp-0D0],rax
       mov       [rbp-0C8],ecx
       lea       rcx,[rbp-0D0]
       call      System.String.Ctor(System.ReadOnlySpan`1<Char>)
       mov       rbx,rax
       mov       rdi,[rbp-60]
       xor       ecx,ecx
       mov       [rbp-60],rcx
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-50],xmm0
       mov       [rbp-58],ecx
       test      rdi,rdi
       je        near ptr M01_L34
       mov       ecx,[rdi+8]
       dec       ecx
       or        ecx,0F
       xor       r15d,r15d
       lzcnt     r15d,ecx
       xor       r15d,1F
       add       r15d,0FFFFFFFD
       mov       rax,[r13+10]
       test      rax,rax
       jne       short M01_L10
       mov       rcx,rsi
       call      qword ptr [7FFBEBDECEA0]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
M01_L10:
       xor       r13d,r13d
       mov       r12d,1
       cmp       [rax+8],r15d
       jbe       near ptr M01_L20
       mov       r13d,1
       mov       ecx,10
       shlx      ecx,ecx,r15d
       cmp       [rdi+8],ecx
       jne       near ptr M01_L60
       mov       ecx,r15d
       shl       rcx,4
       lea       rax,[rax+rcx+10]
       mov       [rbp-108],rax
       mov       r8,[rax]
       mov       [rbp-110],r8
       mov       rcx,rax
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       rdx,[rbp-108]
       mov       [rdx+8],ecx
       cmp       qword ptr [rbp-110],0
       je        near ptr M01_L20
       mov       rcx,[rsi+10]
       cmp       r15d,[rcx+8]
       jae       near ptr M01_L76
       mov       edx,r15d
       mov       r8,[rcx+rdx*8+10]
       test      r8,r8
       jne       short M01_L11
       mov       rcx,rsi
       mov       edx,r15d
       call      qword ptr [7FFBEC204768]
       mov       r8,rax
M01_L11:
       mov       r12,[r8+8]
       test      byte ptr [7FFBEC1FA8A0],1
       je        near ptr M01_L61
M01_L12:
       cmp       byte ptr [7FFBEBA9B17C],0
       je        near ptr M01_L62
       call      qword ptr [7FFBEC204690]
       mov       edx,eax
M01_L13:
       test      byte ptr [7FFBEC1FA730],1
       je        near ptr M01_L64
M01_L14:
       mov       eax,edx
       xor       edx,edx
       div       dword ptr [7FFBEBA9B170]
       mov       eax,edx
       mov       edx,[r12+8]
       mov       [rbp-0E4],edx
       test      edx,edx
       jle       near ptr M01_L67
       mov       [rbp-0E8],edx
M01_L15:
       cmp       eax,edx
       jae       near ptr M01_L76
       mov       [rbp-0A8],eax
       mov       ecx,eax
       mov       r10,[r12+rcx*8+10]
       mov       [rbp-118],r10
       cmp       [r10],r10b
       xor       r9d,r9d
       mov       [rbp-0B4],r9d
       mov       rcx,r10
       call      00007FFC4B802B50
       test      eax,eax
       jne       short M01_L16
       mov       rcx,[rbp-118]
       call      qword ptr [7FFBEC204348]
M01_L16:
       mov       rax,[rbp-118]
       mov       rcx,[rax+8]
       mov       r8d,[rax+10]
       mov       [rbp-0B8],r8d
       cmp       [rcx+8],r8d
       jbe       short M01_L18
       test      r8d,r8d
       je        near ptr M01_L29
M01_L17:
       movsxd    rdx,r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,[rbp-110]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rbp-0B8]
       inc       ecx
       mov       rax,[rbp-118]
       mov       [rax+10],ecx
       mov       dword ptr [rbp-0B4],1
M01_L18:
       mov       rcx,rax
       call      00007FFC4B802A70
       test      eax,eax
       je        short M01_L19
       mov       ecx,eax
       mov       rdx,[rbp-118]
       call      qword ptr [7FFBEC15FED0]
M01_L19:
       cmp       dword ptr [rbp-0B4],0
       je        near ptr M01_L65
       mov       r12d,1
M01_L20:
       cmp       byte ptr [r14+9D],0
       je        near ptr M01_L34
       cmp       dword ptr [rdi+8],0
       je        near ptr M01_L34
       mov       rcx,rdi
       call      00007FFC4B789590
       test      eax,eax
       je        near ptr M01_L30
       mov       [rbp-0BC],eax
M01_L21:
       mov       edx,[rdi+8]
       mov       [rbp-0A4],edx
       mov       rcx,rsi
       call      00007FFC4B789590
       test      eax,eax
       je        near ptr M01_L31
M01_L22:
       mov       [rsp+20],eax
       mov       rcx,r14
       mov       r8d,[rbp-0BC]
       mov       r9d,[rbp-0A4]
       mov       edx,3
       call      qword ptr [7FFBEC204780]
       test      r12d,r13d
       jne       near ptr M01_L34
       mov       rcx,rdi
       call      qword ptr [7FFBEBF6D830]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r12d,eax
       mov       edi,[rdi+8]
       mov       rcx,rsi
       call      00007FFC4B789590
       mov       r9d,eax
       test      r9d,r9d
       je        near ptr M01_L68
M01_L23:
       test      r13d,r13d
       jne       near ptr M01_L32
       mov       r15d,0FFFFFFFF
       mov       ecx,1
       jmp       near ptr M01_L33
M01_L24:
       cmp       rbx,64
       jb        short M01_L26
       mov       r8,20207BE20A4
M01_L25:
       add       rax,0FFFFFFFFFFFFFFFC
       mov       r10,28F5C28F5C28F5C3
       mov       rdx,rcx
       shr       rdx,2
       mulx      rdx,rdx,r10
       shr       rdx,2
       imul      r10,rdx,64
       sub       rcx,r10
       mov       r10,r8
       shl       ecx,2
       mov       ecx,[r10+rcx]
       mov       [rax],ecx
       cmp       rdx,64
       mov       rcx,rdx
       jae       short M01_L25
M01_L26:
       cmp       rcx,0A
       jb        near ptr M01_L03
       add       rax,0FFFFFFFFFFFFFFFC
       mov       r8,20207BE20A4
       shl       ecx,2
       mov       ecx,[r8+rcx]
       mov       [rax],ecx
       jmp       near ptr M01_L04
M01_L27:
       lea       rcx,[rbp-68]
       mov       rdx,20207BF0708
       call      qword ptr [7FFBEC156AF0]
       jmp       near ptr M01_L08
M01_L28:
       lea       rcx,[rbp-68]
       mov       rdx,rdi
       call      qword ptr [7FFBEC204558]
       jmp       near ptr M01_L09
M01_L29:
       xor       edx,edx
       mov       [rax+14],edx
       jmp       near ptr M01_L17
M01_L30:
       mov       rcx,rdi
       call      qword ptr [7FFBEBD277F8]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       mov       [rbp-0BC],eax
       jmp       near ptr M01_L21
M01_L31:
       mov       rcx,rsi
       call      qword ptr [7FFBEBD277F8]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       jmp       near ptr M01_L22
M01_L32:
       xor       ecx,ecx
M01_L33:
       mov       [rsp+20],r15d
       mov       [rsp+28],ecx
       mov       rcx,r14
       mov       edx,r12d
       mov       r8d,edi
       call      qword ptr [7FFBEC204798]
M01_L34:
       mov       rax,rbx
       add       rsp,118
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L35:
       mov       ecx,3
       call      qword ptr [7FFBEC15FFC0]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       r13,rax
       jmp       near ptr M01_L00
M01_L36:
       mov       rcx,r12
       call      qword ptr [7FFBEBF6D830]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rbp-78],eax
       mov       edx,[r12+8]
       mov       [rbp-7C],edx
       mov       rcx,rdi
       call      qword ptr [7FFBEBF6D830]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       dword ptr [rsp+20],4
       mov       edx,[rbp-78]
       mov       r8d,[rbp-7C]
       mov       rcx,r15
       call      qword ptr [7FFBEC204678]
       jmp       near ptr M01_L01
M01_L37:
       mov       rcx,[rdi+10]
       cmp       dword ptr [rcx+8],4
       jle       near ptr M01_L49
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        near ptr M01_L48
       mov       r12,[rcx+8]
       mov       rcx,offset MT_System.Threading.ProcessorIdCache
       call      qword ptr [7FFBEBB55740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       cmp       byte ptr [7FFBEBA9B17C],0
       je        short M01_L38
       call      qword ptr [7FFBEC204690]
       mov       edx,eax
       mov       [rbp-88],edx
       jmp       short M01_L40
M01_L38:
       mov       ecx,9
       call      qword ptr [7FFBEC2046A8]
       mov       eax,[rax+10]
       mov       [rbp-8C],eax
       mov       ecx,9
       call      qword ptr [7FFBEC2046A8]
       mov       edx,[rbp-8C]
       lea       ecx,[rdx-1]
       mov       [rax+10],ecx
       movzx     eax,dx
       test      eax,eax
       jne       short M01_L39
       call      qword ptr [7FFBEC2046C0]
       mov       edx,eax
       mov       [rbp-88],edx
       jmp       short M01_L40
M01_L39:
       sar       edx,10
       mov       [rbp-88],edx
M01_L40:
       mov       rcx,offset MT_System.Buffers.SharedArrayPoolStatics
       call      qword ptr [7FFBEBB55740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       eax,[rbp-88]
       xor       edx,edx
       div       dword ptr [7FFBEBA9B170]
       mov       eax,edx
       xor       edx,edx
       jmp       near ptr M01_L44
M01_L41:
       cmp       eax,[r12+8]
       jae       near ptr M01_L76
       mov       [rbp-80],eax
       mov       ecx,eax
       mov       r8,[r12+rcx*8+10]
       mov       [rbp-100],r8
       cmp       [r8],r8b
       xor       r10d,r10d
       mov       [rbp-0F8],r10
       mov       rcx,r8
       call      qword ptr [7FFBEC06E3B8]; System.Threading.Monitor.Enter(System.Object)
       mov       r8,[rbp-100]
       mov       rcx,[r8+8]
       mov       eax,[r8+10]
       dec       eax
       cmp       [rcx+8],eax
       jbe       short M01_L42
       mov       edx,eax
       mov       r10,[rcx+rdx*8+10]
       mov       [rbp-0F8],r10
       mov       r10d,eax
       xor       r9d,r9d
       mov       [rcx+r10*8+10],r9
       mov       [r8+10],eax
M01_L42:
       mov       rcx,r8
       call      qword ptr [7FFBEBB56820]; System.Threading.Monitor.Exit(System.Object)
       mov       rcx,[rbp-0F8]
       test      rcx,rcx
       jne       short M01_L45
       mov       eax,[rbp-80]
       inc       eax
       mov       ecx,eax
       cmp       [r12+8],ecx
       jne       short M01_L43
       xor       ecx,ecx
M01_L43:
       mov       edx,[rbp-84]
       inc       edx
       mov       eax,ecx
M01_L44:
       mov       [rbp-84],edx
       cmp       [r12+8],edx
       jg        near ptr M01_L41
       jmp       short M01_L46
M01_L45:
       mov       r12,rcx
       jmp       short M01_L47
M01_L46:
       xor       r12d,r12d
M01_L47:
       test      r12,r12
       je        short M01_L48
       cmp       byte ptr [r15+9D],0
       je        near ptr M01_L01
       mov       rcx,r12
       call      qword ptr [7FFBEBF6D830]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rbp-70],eax
       mov       edx,[r12+8]
       mov       [rbp-74],edx
       mov       rcx,rdi
       call      qword ptr [7FFBEBF6D830]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       dword ptr [rsp+20],4
       mov       edx,[rbp-70]
       mov       r8d,[rbp-74]
       mov       rcx,r15
       call      qword ptr [7FFBEC204678]
       jmp       near ptr M01_L01
M01_L48:
       mov       edx,100
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r12,rax
       cmp       byte ptr [r15+9D],0
       je        near ptr M01_L01
       jmp       short M01_L50
M01_L49:
       mov       ecx,100
       mov       rdx,20207BE6F28
       call      qword ptr [7FFBEBDED8C0]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
       jmp       short M01_L48
M01_L50:
       mov       rcx,r12
       call      qword ptr [7FFBEBF6D830]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rbp-6C],eax
       mov       rcx,rdi
       call      qword ptr [7FFBEBF6D830]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       edx,[rbp-6C]
       mov       r8d,100
       mov       rcx,r15
       call      qword ptr [7FFBEC204678]
       mov       rcx,rdi
       call      qword ptr [7FFBEBF6D830]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       rcx,[rdi+10]
       mov       edx,1
       mov       r8d,2
       cmp       dword ptr [rcx+8],4
       cmovg     edx,r8d
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       [rsp+28],edx
       mov       rcx,r15
       mov       edx,[rbp-6C]
       mov       r8d,100
       call      qword ptr [7FFBEC2046D8]
       jmp       near ptr M01_L01
M01_L51:
       lea       rcx,[rbp-68]
       mov       rdx,rbx
       xor       r8d,r8d
       call      qword ptr [7FFBEC204AC8]
       jmp       near ptr M01_L07
M01_L52:
       lea       rcx,[rbp-68]
       call      qword ptr [7FFBEC204AF8]
       jmp       near ptr M01_L02
M01_L53:
       test      rcx,rcx
       je        short M01_L54
       call      qword ptr [7FFBEC0E5680]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider)
       jmp       short M01_L55
M01_L54:
       call      qword ptr [7FFBEBB5D2A8]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
M01_L55:
       mov       r8,[rax+28]
       test      r8,r8
       jne       short M01_L56
       xor       r9d,r9d
       xor       ecx,ecx
       jmp       short M01_L57
M01_L56:
       lea       r9,[r8+0C]
       mov       ecx,[r8+8]
M01_L57:
       mov       [rbp-0D0],r9
       mov       [rbp-0C8],ecx
       mov       [rbp-0E0],r15
       mov       [rbp-0D8],edi
       lea       r8,[rbp-98]
       mov       [rsp+20],r8
       lea       r8,[rbp-0D0]
       lea       r9,[rbp-0E0]
       mov       rcx,rbx
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFBEC205BD8]
       mov       r15d,eax
       jmp       near ptr M01_L06
M01_L58:
       xor       eax,eax
       mov       [rbp-98],eax
       xor       r15d,r15d
       jmp       near ptr M01_L05
M01_L59:
       call      qword ptr [7FFBEBD2F228]
       int       3
M01_L60:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFBEC204750]
       mov       rsi,rax
       mov       ecx,29B
       mov       rdx,7FFBEBA94000
       call      qword ptr [7FFBEBB5F228]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFBEBED6130]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L61:
       mov       rcx,offset MT_System.Threading.ProcessorIdCache
       call      qword ptr [7FFBEBB55740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M01_L12
M01_L62:
       mov       ecx,9
       call      qword ptr [7FFBEC2046A8]
       mov       eax,[rax+10]
       mov       [rbp-0B0],eax
       mov       ecx,9
       call      qword ptr [7FFBEC2046A8]
       mov       edx,[rbp-0B0]
       lea       ecx,[rdx-1]
       mov       [rax+10],ecx
       movzx     eax,dx
       test      eax,eax
       jne       short M01_L63
       call      qword ptr [7FFBEC2046C0]
       mov       edx,eax
       jmp       near ptr M01_L13
M01_L63:
       sar       edx,10
       mov       [rbp-0AC],edx
       mov       edx,[rbp-0AC]
       jmp       near ptr M01_L13
M01_L64:
       mov       [rbp-0AC],edx
       mov       rcx,offset MT_System.Buffers.SharedArrayPoolStatics
       call      qword ptr [7FFBEBB55740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       edx,[rbp-0AC]
       jmp       near ptr M01_L14
M01_L65:
       mov       eax,[rbp-0A8]
       inc       eax
       mov       ecx,eax
       mov       edx,[rbp-0E4]
       cmp       edx,ecx
       jne       short M01_L66
       xor       ecx,ecx
M01_L66:
       mov       r8d,[rbp-0E8]
       dec       r8d
       mov       [rbp-0E8],r8d
       mov       eax,ecx
       jne       near ptr M01_L15
M01_L67:
       xor       r12d,r12d
       jmp       near ptr M01_L20
M01_L68:
       mov       rcx,rsi
       call      qword ptr [7FFBEBD277F8]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       mov       r9d,eax
       jmp       near ptr M01_L23
M01_L69:
       mov       rcx,rbx
       call      qword ptr [7FFBEC066CE8]; System.TimeSpan.FromMilliseconds(Int64)
       mov       [rbp-40],rax
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.NumericExtensions
       call      qword ptr [7FFBEBB55728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1C172C01DC8
       mov       rcx,[rcx]
       cmp       [rcx],ecx
       call      qword ptr [7FFBEBDEFEE8]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].get_Value()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp-0F0],rax
       lea       rcx,[rbp-40]
       call      qword ptr [7FFBEC15D1B8]
       test      eax,eax
       jle       short M01_L70
       lea       rcx,[rbp-40]
       call      qword ptr [7FFBEC15D1B8]
       mov       edx,eax
       mov       rcx,[rbp-0F0]
       cmp       [rcx],cl
       call      qword ptr [7FFBEBDE7198]; System.Text.StringBuilder.AppendSpanFormattable[[System.Int32, System.Private.CoreLib]](Int32)
       mov       rbx,rax
       lea       rcx,[rbp-40]
       call      qword ptr [7FFBEC15D1B8]
       mov       rdx,20207BF0760
       mov       rcx,20207BF0738
       cmp       eax,1
       cmovne    rdx,rcx
       mov       rcx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FFBEBDE7228]; System.Text.StringBuilder.Append(System.String)
M01_L70:
       lea       rcx,[rbp-40]
       call      qword ptr [7FFBEC15D1E8]
       test      eax,eax
       jle       short M01_L72
       mov       rcx,[rbp-0F0]
       mov       edx,[rcx+1C]
       add       edx,[rcx+18]
       test      edx,edx
       jle       short M01_L71
       mov       edx,20
       call      qword ptr [7FFBEBDE7180]; System.Text.StringBuilder.Append(Char)
M01_L71:
       lea       rcx,[rbp-40]
       call      qword ptr [7FFBEC15D1E8]
       mov       edx,eax
       mov       rcx,[rbp-0F0]
       call      qword ptr [7FFBEBDE7198]; System.Text.StringBuilder.AppendSpanFormattable[[System.Int32, System.Private.CoreLib]](Int32)
       mov       rbx,rax
       lea       rcx,[rbp-40]
       call      qword ptr [7FFBEC15D1E8]
       mov       rdx,20207BF07A8
       mov       rcx,20207BF0780
       cmp       eax,1
       cmovne    rdx,rcx
       mov       rcx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FFBEBDE7228]; System.Text.StringBuilder.Append(System.String)
M01_L72:
       lea       rcx,[rbp-40]
       call      qword ptr [7FFBEC15D218]
       test      eax,eax
       jg        short M01_L73
       mov       rcx,[rbp-0F0]
       mov       edx,[rcx+1C]
       add       edx,[rcx+18]
       jne       short M01_L75
M01_L73:
       mov       rcx,[rbp-0F0]
       mov       edx,[rcx+1C]
       add       edx,[rcx+18]
       test      edx,edx
       jle       short M01_L74
       mov       edx,20
       call      qword ptr [7FFBEBDE7180]; System.Text.StringBuilder.Append(Char)
M01_L74:
       lea       rcx,[rbp-40]
       call      qword ptr [7FFBEC15D218]
       mov       edx,eax
       mov       rcx,[rbp-0F0]
       call      qword ptr [7FFBEBDE7198]; System.Text.StringBuilder.AppendSpanFormattable[[System.Int32, System.Private.CoreLib]](Int32)
       mov       rbx,rax
       lea       rcx,[rbp-40]
       call      qword ptr [7FFBEC15D218]
       mov       rdx,20207BF07F8
       mov       rcx,20207BF07D0
       cmp       eax,1
       cmovne    rdx,rcx
       mov       rcx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FFBEBDE7228]; System.Text.StringBuilder.Append(System.String)
       mov       rcx,[rbp-0F0]
M01_L75:
       call      qword ptr [7FFBEBDF6DE8]; System.Text.StringBuilder.ToString()
       mov       rbx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.NumericExtensions
       call      qword ptr [7FFBEBB55728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1C172C01DC8
       mov       rcx,[rcx]
       cmp       [rcx],ecx
       call      qword ptr [7FFBEBDEFEE8]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].get_Value()
       mov       rsi,rax
       mov       rcx,[rbp-0F0]
       xor       edx,edx
       call      qword ptr [7FFBEC154BE8]; System.Text.StringBuilder.set_Length(Int32)
       mov       rcx,rsi
       mov       rdx,[rbp-0F0]
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       rax,rbx
       add       rsp,118
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L76:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       sub       rsp,38
       test      byte ptr [7FFBEC14AFC8],1
       jne       short M01_L77
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.NumericExtensions
       call      qword ptr [7FFBEBB55728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
M01_L77:
       mov       rcx,1C172C01DC8
       mov       rcx,[rcx]
       cmp       [rcx],ecx
       call      qword ptr [7FFBEBDEFEE8]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].get_Value()
       mov       rbx,rax
       mov       rcx,[rbp-0F0]
       cmp       [rcx],cl
       xor       edx,edx
       call      qword ptr [7FFBEC154BE8]; System.Text.StringBuilder.set_Length(Int32)
       mov       rcx,rbx
       mov       rdx,[rbp-0F0]
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       add       rsp,38
       ret
; Total bytes of code 3389
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.NumericExtensionsBenchmark.ToWords()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-38],rax
       mov       [rbp-40],rax
       mov       rbx,rcx
       mov       esi,[rbx+150]
       test      esi,esi
       je        near ptr M00_L61
       test      esi,esi
       jl        near ptr M00_L62
       mov       rcx,1E6AC401DC8
       mov       rdi,[rcx]
       mov       rcx,rdi
       cmp       qword ptr [rcx+8],0
       jne       near ptr M00_L64
       mov       r14,[rcx+18]
M00_L00:
       mov       rcx,offset MT_Microsoft.Extensions.ObjectPool.DefaultObjectPool<System.Text.StringBuilder>
       cmp       [r14],rcx
       jne       near ptr M00_L66
       mov       rcx,[r14+20]
       mov       [rbp-38],rcx
       cmp       qword ptr [rbp-38],0
       je        near ptr M00_L57
       lea       rcx,[r14+20]
       mov       r8,[rbp-38]
       test      rcx,rcx
       je        near ptr M00_L65
       xor       edx,edx
       call      00007FFC4B793270
       cmp       rax,[rbp-38]
       jne       near ptr M00_L57
M00_L01:
       mov       r14,[rbp-38]
M00_L02:
       xor       ecx,ecx
       mov       [rbp-38],rcx
M00_L03:
       mov       [rbp-48],r14
       mov       ecx,esi
       imul      rcx,431BDE83
       shr       rcx,32
       test      ecx,ecx
       jg        near ptr M00_L32
M00_L04:
       mov       edx,10624DD3
       mov       eax,edx
       imul      esi
       mov       r15d,edx
       shr       r15d,1F
       sar       edx,6
       add       r15d,edx
       test      r15d,r15d
       jg        near ptr M00_L13
M00_L05:
       mov       edx,51EB851F
       mov       eax,edx
       imul      esi
       mov       r15d,edx
       shr       r15d,1F
       sar       edx,5
       add       r15d,edx
       test      r15d,r15d
       jg        near ptr M00_L20
M00_L06:
       test      esi,esi
       jle       near ptr M00_L11
       mov       eax,[r14+1C]
       add       eax,[r14+18]
       test      eax,eax
       jg        near ptr M00_L27
M00_L07:
       cmp       esi,14
       jl        near ptr M00_L30
       mov       edx,66666667
       mov       eax,edx
       imul      esi
       mov       r15d,edx
       shr       r15d,1F
       sar       edx,2
       add       r15d,edx
       mov       r8,1E6AC401DD0
       mov       r8,[r8]
       cmp       r15d,0A
       jae       near ptr M00_L51
       mov       ecx,r15d
       mov       r8,[r8+rcx*8+10]
       test      r8,r8
       je        short M00_L09
       lea       rdx,[r8+0C]
       mov       r8d,[r8+8]
       test      r8d,r8d
       je        short M00_L09
       mov       rcx,[r14+8]
       mov       eax,[r14+18]
       lea       r13d,[rax+r8]
       cmp       r13d,[rcx+8]
       ja        near ptr M00_L52
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jle       near ptr M00_L50
       mov       r8d,r8d
       add       r8,r8
       call      qword ptr [7FFBEBB65818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L08:
       mov       [r14+18],r13d
M00_L09:
       lea       ecx,[r15+r15*4]
       add       ecx,ecx
       sub       esi,ecx
       test      esi,esi
       jle       short M00_L11
       mov       ecx,[r14+18]
       mov       edx,ecx
       mov       rax,[r14+8]
       mov       r8d,[rax+8]
       cmp       r8d,edx
       jbe       near ptr M00_L53
       cmp       edx,r8d
       jae       near ptr M00_L51
       mov       word ptr [rax+rdx*2+10],2D
       inc       ecx
       mov       [r14+18],ecx
M00_L10:
       mov       r8,1E6AC401DD8
       mov       r15,[r8]
       cmp       esi,14
       jae       near ptr M00_L51
       mov       r8d,esi
       mov       rdx,[r15+r8*8+10]
       test      rdx,rdx
       je        short M00_L11
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,r14
       call      qword ptr [7FFBEBDF7150]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M00_L11:
       mov       rcx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFBEBE06DE8]; System.Text.StringBuilder.ToString()
       mov       rsi,rax
       mov       r15d,[rsi+8]
       test      r15d,r15d
       je        short M00_L12
       movzx     ecx,word ptr [rsi+0C]
       call      qword ptr [7FFBEC0FF090]; System.Char.IsWhiteSpace(Char)
       test      eax,eax
       jne       near ptr M00_L54
       lea       ecx,[r15-1]
       cmp       ecx,r15d
       jae       near ptr M00_L51
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       call      qword ptr [7FFBEC0FF090]; System.Char.IsWhiteSpace(Char)
       test      eax,eax
       jne       near ptr M00_L54
M00_L12:
       mov       r15,rsi
       jmp       near ptr M00_L55
M00_L13:
       mov       ecx,r15d
       call      qword ptr [7FFBEC16D0F8]; DotNetTips.Spargine.Extensions.NumericExtensions.ToWords(Int32)
       cmp       [r14],r14b
       test      rax,rax
       je        short M00_L15
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
       test      r8d,r8d
       je        short M00_L15
       mov       rcx,[r14+8]
       mov       eax,[r14+18]
       lea       r13d,[rax+r8]
       cmp       r13d,[rcx+8]
       ja        near ptr M00_L34
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jle       near ptr M00_L33
       mov       r8d,r8d
       add       r8,r8
       call      qword ptr [7FFBEBB65818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L14:
       mov       [r14+18],r13d
M00_L15:
       mov       ecx,[r14+18]
       mov       edx,ecx
       mov       rax,[r14+8]
       mov       r8d,[rax+8]
       cmp       r8d,edx
       jbe       near ptr M00_L35
       mov       word ptr [rax+rdx*2+10],20
       inc       ecx
       mov       [r14+18],ecx
M00_L16:
       call      qword ptr [7FFBEC16D188]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Thousand()
       test      rax,rax
       je        short M00_L18
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
       test      r8d,r8d
       je        short M00_L18
       mov       rcx,[r14+8]
       mov       eax,[r14+18]
       lea       r13d,[rax+r8]
       cmp       r13d,[rcx+8]
       ja        near ptr M00_L37
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jle       near ptr M00_L36
       mov       r8d,r8d
       add       r8,r8
       call      qword ptr [7FFBEBB65818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L17:
       mov       [r14+18],r13d
M00_L18:
       mov       ecx,[r14+18]
       mov       edx,ecx
       mov       rax,[r14+8]
       mov       r8d,[rax+8]
       cmp       r8d,edx
       jbe       near ptr M00_L38
       mov       word ptr [rax+rdx*2+10],20
       inc       ecx
       mov       [r14+18],ecx
M00_L19:
       imul      eax,r15d,3E8
       sub       esi,eax
       jmp       near ptr M00_L05
M00_L20:
       mov       ecx,r15d
       call      qword ptr [7FFBEC16D0F8]; DotNetTips.Spargine.Extensions.NumericExtensions.ToWords(Int32)
       cmp       [r14],r14b
       test      rax,rax
       je        short M00_L22
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
       test      r8d,r8d
       je        short M00_L22
       mov       rcx,[r14+8]
       mov       eax,[r14+18]
       lea       r13d,[rax+r8]
       cmp       r13d,[rcx+8]
       ja        near ptr M00_L40
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jle       near ptr M00_L39
       mov       r8d,r8d
       add       r8,r8
       call      qword ptr [7FFBEBB65818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L21:
       mov       [r14+18],r13d
M00_L22:
       mov       ecx,[r14+18]
       mov       edx,ecx
       mov       rax,[r14+8]
       mov       r8d,[rax+8]
       cmp       r8d,edx
       jbe       near ptr M00_L41
       cmp       edx,r8d
       jae       near ptr M00_L51
       mov       word ptr [rax+rdx*2+10],20
       inc       ecx
       mov       [r14+18],ecx
M00_L23:
       call      qword ptr [7FFBEC16D1A0]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Hundred()
       test      rax,rax
       je        short M00_L25
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
       test      r8d,r8d
       je        short M00_L25
       mov       rcx,[r14+8]
       mov       eax,[r14+18]
       lea       r13d,[rax+r8]
       cmp       r13d,[rcx+8]
       ja        near ptr M00_L43
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jle       near ptr M00_L42
       mov       r8d,r8d
       add       r8,r8
       call      qword ptr [7FFBEBB65818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L24:
       mov       [r14+18],r13d
M00_L25:
       mov       ecx,[r14+18]
       mov       edx,ecx
       mov       rax,[r14+8]
       mov       r8d,[rax+8]
       cmp       r8d,edx
       jbe       near ptr M00_L44
       cmp       edx,r8d
       jae       near ptr M00_L51
       mov       word ptr [rax+rdx*2+10],20
       inc       ecx
       mov       [r14+18],ecx
M00_L26:
       imul      eax,r15d,64
       sub       esi,eax
       jmp       near ptr M00_L06
M00_L27:
       call      qword ptr [7FFBEC16D1D0]; DotNetTips.Spargine.Extensions.Properties.Resources.get_AndLowerCase()
       test      rax,rax
       je        short M00_L29
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
       test      r8d,r8d
       je        short M00_L29
       mov       rcx,[r14+8]
       mov       eax,[r14+18]
       lea       r15d,[rax+r8]
       cmp       r15d,[rcx+8]
       ja        near ptr M00_L46
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jle       near ptr M00_L45
       mov       r8d,r8d
       add       r8,r8
       call      qword ptr [7FFBEBB65818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L28:
       mov       [r14+18],r15d
M00_L29:
       mov       ecx,[r14+18]
       mov       edx,ecx
       mov       rax,[r14+8]
       mov       r8d,[rax+8]
       cmp       r8d,edx
       jbe       near ptr M00_L47
       cmp       edx,r8d
       jae       near ptr M00_L51
       mov       word ptr [rax+rdx*2+10],20
       inc       ecx
       mov       [r14+18],ecx
       jmp       near ptr M00_L07
M00_L30:
       mov       r8,1E6AC401DD8
       mov       r15,[r8]
       cmp       esi,14
       jae       near ptr M00_L51
       mov       r8d,esi
       mov       r8,[r15+r8*8+10]
       test      r8,r8
       je        near ptr M00_L11
       lea       rdx,[r8+0C]
       mov       r8d,[r8+8]
       test      r8d,r8d
       je        near ptr M00_L11
       mov       rcx,[r14+8]
       mov       eax,[r14+18]
       lea       esi,[rax+r8]
       cmp       esi,[rcx+8]
       ja        near ptr M00_L49
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jle       near ptr M00_L48
       mov       r8d,r8d
       add       r8,r8
       call      qword ptr [7FFBEBB65818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L31:
       mov       [r14+18],esi
       jmp       near ptr M00_L11
M00_L32:
       mov       ecx,esi
       imul      rcx,431BDE83
       shr       rcx,32
       call      qword ptr [7FFBEC16D0F8]; DotNetTips.Spargine.Extensions.NumericExtensions.ToWords(Int32)
       mov       rdx,rax
       mov       rcx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFBEBDF7228]; System.Text.StringBuilder.Append(System.String)
       mov       rcx,rax
       mov       edx,20
       cmp       [rcx],ecx
       call      qword ptr [7FFBEBDF7180]; System.Text.StringBuilder.Append(Char)
       mov       r15,rax
       call      qword ptr [7FFBEC16D170]
       mov       rdx,rax
       mov       rcx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFBEBDF7228]; System.Text.StringBuilder.Append(System.String)
       mov       rcx,rax
       mov       edx,20
       cmp       [rcx],ecx
       call      qword ptr [7FFBEBDF7180]; System.Text.StringBuilder.Append(Char)
       mov       eax,esi
       imul      rax,431BDE83
       shr       rax,32
       imul      eax,0F4240
       sub       esi,eax
       jmp       near ptr M00_L04
M00_L33:
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       jne       near ptr M00_L14
       movzx     edx,word ptr [rdx+2]
       mov       [rcx+2],dx
       jmp       near ptr M00_L14
M00_L34:
       mov       rcx,r14
       call      qword ptr [7FFBEBDF71E0]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M00_L15
M00_L35:
       mov       rcx,r14
       mov       edx,20
       call      qword ptr [7FFBEBDF73A8]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L16
M00_L36:
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       jne       near ptr M00_L17
       movzx     edx,word ptr [rdx+2]
       mov       [rcx+2],dx
       jmp       near ptr M00_L17
M00_L37:
       mov       rcx,r14
       call      qword ptr [7FFBEBDF71E0]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M00_L18
M00_L38:
       mov       rcx,r14
       mov       edx,20
       call      qword ptr [7FFBEBDF73A8]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L19
M00_L39:
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       jne       near ptr M00_L21
       movzx     edx,word ptr [rdx+2]
       mov       [rcx+2],dx
       jmp       near ptr M00_L21
M00_L40:
       mov       rcx,r14
       call      qword ptr [7FFBEBDF71E0]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M00_L22
M00_L41:
       mov       rcx,r14
       mov       edx,20
       call      qword ptr [7FFBEBDF73A8]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L23
M00_L42:
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       jne       near ptr M00_L24
       movzx     edx,word ptr [rdx+2]
       mov       [rcx+2],dx
       jmp       near ptr M00_L24
M00_L43:
       mov       rcx,r14
       call      qword ptr [7FFBEBDF71E0]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M00_L25
M00_L44:
       mov       rcx,r14
       mov       edx,20
       call      qword ptr [7FFBEBDF73A8]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L26
M00_L45:
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       jne       near ptr M00_L28
       movzx     edx,word ptr [rdx+2]
       mov       [rcx+2],dx
       jmp       near ptr M00_L28
M00_L46:
       mov       rcx,r14
       call      qword ptr [7FFBEBDF71E0]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M00_L29
M00_L47:
       mov       rcx,r14
       mov       edx,20
       call      qword ptr [7FFBEBDF73A8]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L07
M00_L48:
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       jne       near ptr M00_L31
       movzx     edx,word ptr [rdx+2]
       mov       [rcx+2],dx
       jmp       near ptr M00_L31
M00_L49:
       mov       rcx,r14
       call      qword ptr [7FFBEBDF71E0]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M00_L11
M00_L50:
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       jne       near ptr M00_L08
       movzx     edx,word ptr [rdx+2]
       mov       [rcx+2],dx
       jmp       near ptr M00_L08
M00_L51:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L52:
       mov       rcx,r14
       call      qword ptr [7FFBEBDF71E0]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M00_L09
M00_L53:
       mov       rcx,r14
       mov       edx,2D
       call      qword ptr [7FFBEBDF73A8]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L10
M00_L54:
       mov       rcx,rsi
       mov       edx,3
       call      qword ptr [7FFBEC204F78]
       mov       r15,rax
M00_L55:
       mov       rcx,rdi
       call      qword ptr [7FFBEBDFFEE8]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].get_Value()
       mov       rsi,rax
       mov       rcx,r14
       xor       edx,edx
       call      qword ptr [7FFBEC164BE8]; System.Text.StringBuilder.set_Length(Int32)
       mov       rcx,offset MT_Microsoft.Extensions.ObjectPool.DefaultObjectPool<System.Text.StringBuilder>
       cmp       [rsi],rcx
       jne       near ptr M00_L67
       mov       rcx,rsi
       mov       rdx,r14
       call      qword ptr [7FFBEC164C00]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].ReturnCore(System.__Canon)
M00_L56:
       mov       [rbp-40],r15
       mov       rcx,[rbx+60]
       lea       r8,[rbp-40]
       mov       rdx,7FFBEC1C21F8
       cmp       [rcx],ecx
       call      qword ptr [7FFBEC16D698]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L57:
       mov       r15,[r14+18]
       mov       r13,[r15+18]
       lea       rdx,[rbp-38]
       mov       rcx,r13
       cmp       [rcx],ecx
       call      qword ptr [7FFBEC164AB0]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       jne       short M00_L58
       cmp       qword ptr [r13+10],0
       je        short M00_L59
       lea       rdx,[rbp-38]
       mov       rcx,r15
       call      qword ptr [7FFBEC205260]
       test      eax,eax
       je        short M00_L60
M00_L58:
       add       r14,2C
       lock dec  dword ptr [r14]
       jmp       near ptr M00_L01
M00_L59:
       xor       ecx,ecx
       mov       [rbp-38],rcx
M00_L60:
       mov       rax,[r14+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r14,rax
       jmp       near ptr M00_L02
M00_L61:
       call      qword ptr [7FFBEC16D110]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Zero()
       mov       r15,rax
       jmp       near ptr M00_L56
M00_L62:
       call      qword ptr [7FFBEC16D128]
       mov       r15,rax
       mov       ecx,1
       call      qword ptr [7FFBEBB66670]; System.String.FastAllocateString(IntPtr)
       mov       rdi,rax
       mov       word ptr [rdi+0C],20
       mov       ecx,esi
       neg       ecx
       jns       short M00_L63
       call      qword ptr [7FFBEC206298]
       int       3
M00_L63:
       call      qword ptr [7FFBEC16D0F8]; DotNetTips.Spargine.Extensions.NumericExtensions.ToWords(Int32)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,r15
       call      qword ptr [7FFBEBD35488]; System.String.Concat(System.String, System.String, System.String)
       mov       r15,rax
       jmp       near ptr M00_L56
M00_L64:
       call      qword ptr [7FFBEBDFFF48]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       r14,rax
       jmp       near ptr M00_L00
M00_L65:
       call      qword ptr [7FFBEC204F30]
       int       3
M00_L66:
       mov       rcx,r14
       mov       rax,[r14]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       r14,rax
       jmp       near ptr M00_L03
M00_L67:
       mov       rcx,rsi
       mov       rdx,r14
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       jmp       near ptr M00_L56
       sub       rsp,28
       mov       rcx,1E6AC401DC8
       mov       rdi,[rcx]
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFBEBDFFEE8]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].get_Value()
       mov       r15,rax
       mov       rdx,[rbp-48]
       cmp       [rdx],dl
       mov       rcx,rdx
       xor       edx,edx
       call      qword ptr [7FFBEC164BE8]; System.Text.StringBuilder.set_Length(Int32)
       mov       rcx,offset MT_Microsoft.Extensions.ObjectPool.DefaultObjectPool<System.Text.StringBuilder>
       cmp       [r15],rcx
       jne       short M00_L68
       mov       rcx,r15
       mov       rdx,[rbp-48]
       call      qword ptr [7FFBEC164C00]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].ReturnCore(System.__Canon)
       jmp       short M00_L69
M00_L68:
       mov       rcx,r15
       mov       rdx,[rbp-48]
       mov       rax,[r15]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
M00_L69:
       nop
       add       rsp,28
       ret
; Total bytes of code 2352
```
```assembly
; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M01_L11
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M01_L11
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       ja        short M01_L02
       test      r8b,18
       je        short M01_L01
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
M01_L00:
       vzeroupper
       ret
M01_L01:
       test      r8b,4
       je        near ptr M01_L09
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
       jmp       short M01_L00
M01_L02:
       cmp       r8,40
       ja        short M01_L05
M01_L03:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       jbe       short M01_L04
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       ja        short M01_L08
M01_L04:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
       jmp       short M01_L00
M01_L05:
       cmp       r8,800
       ja        near ptr M01_L12
       cmp       r8,100
       jae       short M01_L10
M01_L06:
       mov       r9,r8
       shr       r9,6
M01_L07:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M01_L07
       and       r8,3F
       cmp       r8,10
       ja        short M01_L03
       jmp       short M01_L04
M01_L08:
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M01_L04
M01_L09:
       test      r8,r8
       je        near ptr M01_L00
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        near ptr M01_L00
       movsx     r8,word ptr [rax-2]
       mov       [r10-2],r8w
       jmp       near ptr M01_L00
M01_L10:
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
       jmp       near ptr M01_L06
M01_L11:
       cmp       rcx,rdx
       jne       short M01_L12
       cmp       [rdx],dl
       jmp       near ptr M01_L00
M01_L12:
       cmp       [rcx],cl
       cmp       [rdx],dl
       vzeroupper
       jmp       qword ptr [7FFBEBB666E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 336
```
```assembly
; System.Text.StringBuilder.Append(Char ByRef, Int32)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       test      r8d,r8d
       je        short M02_L01
       mov       rcx,[rbx+8]
       mov       eax,[rbx+18]
       lea       esi,[rax+r8]
       cmp       esi,[rcx+8]
       ja        short M02_L03
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jle       short M02_L02
       mov       r8d,r8d
       add       r8,r8
       call      qword ptr [7FFBEBB65818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L00:
       mov       [rbx+18],esi
M02_L01:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L02:
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       jne       short M02_L00
       movzx     edx,word ptr [rdx+2]
       mov       [rcx+2],dx
       jmp       short M02_L00
M02_L03:
       mov       rcx,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFBEBDF71E0]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
; Total bytes of code 102
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
       call      00007FFC4B7F9D30
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
       call      qword ptr [7FFBEBB65818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,22741490008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M03_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,19655
       mov       rdx,7FFBEBAA4000
       call      qword ptr [7FFBEBB6F228]
       mov       rbx,rax
       call      qword ptr [7FFBEC204F48]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFBEBDFD8F0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 201
```
```assembly
; System.Char.IsWhiteSpace(Char)
       movzx     ecx,cx
       cmp       ecx,100
       jge       short M04_L00
       mov       eax,ecx
       mov       rcx,7FFC49676098
       test      byte ptr [rcx+rax],80
       setne     al
       movzx     eax,al
       ret
M04_L00:
       jmp       qword ptr [7FFBEC204F60]
; Total bytes of code 40
```
```assembly
; DotNetTips.Spargine.Extensions.NumericExtensions.ToWords(Int32)
; 		if (value == 0)
; 		^^^^^^^^^^^^^^^
; 			return Resources.Zero;
; 			^^^^^^^^^^^^^^^^^^^^^^
; 		if (value < 0)
; 		^^^^^^^^^^^^^^
; 			return string.Concat(Resources.Minus, ControlChars.Space.ToString(), ToWords(Math.Abs(value)));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var sb = _stringBuilderPool.Value.Get();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			if ((value / 1000000) > 0)
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^
; 				_ = sb.Append(ToWords(value / 1000000)).Append(ControlChars.Space).Append(Resources.Million).Append(ControlChars.Space);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 				value %= 1000000;
; 				^^^^^^^^^^^^^^^^^
; 			if ((value / 1000) > 0)
; 			^^^^^^^^^^^^^^^^^^^^^^^
; 				_ = sb.Append(ToWords(value / 1000)).Append(ControlChars.Space).Append(Resources.Thousand).Append(ControlChars.Space);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 				value %= 1000;
; 				^^^^^^^^^^^^^^
; 			if ((value / 100) > 0)
; 			^^^^^^^^^^^^^^^^^^^^^^
; 				_ = sb.Append(ToWords(value / 100)).Append(ControlChars.Space).Append(Resources.Hundred).Append(ControlChars.Space);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 				value %= 100;
; 				^^^^^^^^^^^^^
; 			if (value > 0)
; 			^^^^^^^^^^^^^^
; 				if (sb.Length > 0)
; 				^^^^^^^^^^^^^^^^^^
; 					_ = sb.Append(Resources.AndLowerCase).Append(ControlChars.Space);
; 					^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 				if (value < 20)
; 				^^^^^^^^^^^^^^^
; 					_ = sb.Append(_toWordsUnits[value]);
; 					^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 					_ = sb.Append(_toWordsTens[value / 10]);
; 					^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 					if ((value % 10) > 0)
; 					^^^^^^^^^^^^^^^^^^^^^
; 						_ = sb.Append(ControlChars.Dash).Append(_toWordsUnits[value % 10]);
; 						^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			return sb.ToString().Trim();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 	}
; 	^
; 			_stringBuilderPool.Value.Return(sb.Clear());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		}
; 		^
M05_L00:
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,68
       lea       rbp,[rsp+90]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-70],ymm4
       vmovdqu   ymmword ptr [rbp-50],ymm4
       xor       eax,eax
       mov       [rbp-30],rax
       mov       [rbp+10],ecx
       cmp       dword ptr [rbp+10],0
       je        near ptr M05_L125
       cmp       dword ptr [rbp+10],0
       jl        near ptr M05_L126
       mov       rcx,1E6AC401DC8
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0
       jne       near ptr M05_L139
       mov       rbx,[rcx+18]
M05_L01:
       mov       rcx,offset MT_Microsoft.Extensions.ObjectPool.DefaultObjectPool<System.Text.StringBuilder>
       cmp       [rbx],rcx
       jne       near ptr M05_L141
       mov       rcx,[rbx+20]
       mov       [rbp-30],rcx
       cmp       qword ptr [rbp-30],0
       je        near ptr M05_L121
       lea       rcx,[rbx+20]
       mov       r8,[rbp-30]
       test      rcx,rcx
       je        near ptr M05_L140
       xor       edx,edx
       call      00007FFC4B793270
       cmp       rax,[rbp-30]
       jne       near ptr M05_L121
M05_L02:
       mov       rbx,[rbp-30]
M05_L03:
       xor       ecx,ecx
       mov       [rbp-30],rcx
M05_L04:
       mov       [rbp-38],rbx
       mov       ecx,[rbp+10]
       imul      rcx,431BDE83
       shr       rcx,32
       test      ecx,ecx
       jg        near ptr M05_L86
M05_L05:
       mov       edx,10624DD3
       mov       eax,edx
       imul      dword ptr [rbp+10]
       mov       ebx,edx
       shr       ebx,1F
       sar       edx,6
       add       ebx,edx
       test      ebx,ebx
       jg        near ptr M05_L45
M05_L06:
       mov       edx,51EB851F
       mov       eax,edx
       imul      dword ptr [rbp+10]
       mov       esi,edx
       shr       esi,1F
       sar       edx,5
       add       esi,edx
       test      esi,esi
       jle       near ptr M05_L35
       mov       rcx,1E6AC401DC8
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0
       jne       near ptr M05_L102
       mov       rcx,[rcx+18]
M05_L07:
       mov       rax,offset MT_Microsoft.Extensions.ObjectPool.DefaultObjectPool<System.Text.StringBuilder>
       cmp       [rcx],rax
       jne       near ptr M05_L103
       cmp       [rcx],ecx
       call      qword ptr [7FFBEBFC2B00]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Get()
       mov       rdi,rax
M05_L08:
       mov       [rbp-68],rdi
       mov       edx,431BDE83
       mov       eax,edx
       imul      esi
       mov       eax,edx
       shr       eax,1F
       sar       edx,12
       add       eax,edx
       test      eax,eax
       jg        near ptr M05_L22
M05_L09:
       mov       edx,10624DD3
       mov       eax,edx
       imul      esi
       mov       r14d,edx
       shr       r14d,1F
       sar       edx,6
       add       r14d,edx
       test      r14d,r14d
       jg        near ptr M05_L19
M05_L10:
       mov       edx,51EB851F
       mov       eax,edx
       imul      esi
       mov       r14d,edx
       shr       r14d,1F
       sar       edx,5
       add       r14d,edx
       test      r14d,r14d
       jle       short M05_L11
       mov       ecx,r14d
       call      qword ptr [7FFBEC16D0F8]
       mov       rdx,rax
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFBEBDF7228]; System.Text.StringBuilder.Append(System.String)
       mov       rcx,rax
       mov       edx,20
       cmp       [rcx],ecx
       call      qword ptr [7FFBEBDF7180]; System.Text.StringBuilder.Append(Char)
       mov       r15,rax
       call      qword ptr [7FFBEC16D1A0]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Hundred()
       mov       rdx,rax
       mov       rcx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFBEBDF7228]; System.Text.StringBuilder.Append(System.String)
       mov       rcx,rax
       mov       edx,20
       cmp       [rcx],ecx
       call      qword ptr [7FFBEBDF7180]; System.Text.StringBuilder.Append(Char)
       imul      eax,r14d,64
       sub       esi,eax
M05_L11:
       test      esi,esi
       jle       near ptr M05_L15
       mov       eax,[rdi+1C]
       add       eax,[rdi+18]
       test      eax,eax
       jg        near ptr M05_L20
M05_L12:
       cmp       esi,14
       jl        near ptr M05_L21
       mov       edx,66666667
       mov       eax,edx
       imul      esi
       mov       r14d,edx
       shr       r14d,1F
       sar       edx,2
       add       r14d,edx
       mov       r8,1E6AC401DD0
       mov       r8,[r8]
       cmp       r14d,0A
       jae       near ptr M05_L26
       mov       edx,r14d
       mov       rdx,[r8+rdx*8+10]
       test      rdx,rdx
       je        short M05_L13
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,rdi
       call      qword ptr [7FFBEBDF7150]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M05_L13:
       lea       ecx,[r14+r14*4]
       add       ecx,ecx
       sub       esi,ecx
       test      esi,esi
       jle       short M05_L15
       mov       ecx,[rdi+18]
       mov       edx,ecx
       mov       rax,[rdi+8]
       mov       r8d,[rax+8]
       cmp       r8d,edx
       jbe       near ptr M05_L23
       cmp       edx,r8d
       jae       near ptr M05_L26
       mov       word ptr [rax+rdx*2+10],2D
       inc       ecx
       mov       [rdi+18],ecx
M05_L14:
       mov       r8,1E6AC401DD8
       mov       r14,[r8]
       cmp       esi,14
       jae       near ptr M05_L26
       mov       r8d,esi
       mov       rdx,[r14+r8*8+10]
       test      rdx,rdx
       je        short M05_L15
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,rdi
       call      qword ptr [7FFBEBDF7150]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M05_L15:
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFBEBE06DE8]; System.Text.StringBuilder.ToString()
       mov       r14,rax
       cmp       dword ptr [r14+8],0
       je        short M05_L17
       movzx     ecx,word ptr [r14+0C]
       cmp       ecx,100
       jge       near ptr M05_L24
       cmp       ecx,100
       jae       near ptr M05_L26
       mov       rax,7FFC49676098
       test      byte ptr [rax+rcx],80
       jne       near ptr M05_L27
M05_L16:
       mov       ecx,[r14+8]
       dec       ecx
       cmp       ecx,[r14+8]
       jae       near ptr M05_L26
       mov       ecx,[r14+8]
       dec       ecx
       movzx     ecx,word ptr [r14+rcx*2+0C]
       cmp       ecx,100
       jge       near ptr M05_L25
       cmp       ecx,100
       jae       near ptr M05_L26
       mov       rax,7FFC49676098
       test      byte ptr [rax+rcx],80
       jne       near ptr M05_L27
M05_L17:
       mov       r8,r14
M05_L18:
       mov       [rbp-70],r8
       jmp       near ptr M05_L28
M05_L19:
       mov       ecx,r14d
       call      qword ptr [7FFBEC16D0F8]
       mov       rdx,rax
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFBEBDF7228]; System.Text.StringBuilder.Append(System.String)
       mov       rcx,rax
       mov       edx,20
       cmp       [rcx],ecx
       call      qword ptr [7FFBEBDF7180]; System.Text.StringBuilder.Append(Char)
       mov       r15,rax
       call      qword ptr [7FFBEC16D188]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Thousand()
       mov       rdx,rax
       mov       rcx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFBEBDF7228]; System.Text.StringBuilder.Append(System.String)
       mov       rcx,rax
       mov       edx,20
       cmp       [rcx],ecx
       call      qword ptr [7FFBEBDF7180]; System.Text.StringBuilder.Append(Char)
       imul      eax,r14d,3E8
       sub       esi,eax
       jmp       near ptr M05_L10
M05_L20:
       call      qword ptr [7FFBEC16D1D0]; DotNetTips.Spargine.Extensions.Properties.Resources.get_AndLowerCase()
       mov       rdx,rax
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFBEBDF7228]; System.Text.StringBuilder.Append(System.String)
       mov       rcx,rax
       mov       edx,20
       cmp       [rcx],ecx
       call      qword ptr [7FFBEBDF7180]; System.Text.StringBuilder.Append(Char)
       jmp       near ptr M05_L12
M05_L21:
       mov       rdx,1E6AC401DD8
       mov       r14,[rdx]
       cmp       esi,14
       jae       near ptr M05_L26
       mov       edx,esi
       mov       rdx,[r14+rdx*8+10]
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFBEBDF7228]; System.Text.StringBuilder.Append(System.String)
       jmp       near ptr M05_L15
M05_L22:
       mov       edx,431BDE83
       mov       eax,edx
       imul      esi
       mov       ecx,edx
       shr       ecx,1F
       sar       edx,12
       add       ecx,edx
       call      qword ptr [7FFBEC16D0F8]
       mov       rdx,rax
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFBEBDF7228]; System.Text.StringBuilder.Append(System.String)
       mov       rcx,rax
       mov       edx,20
       cmp       [rcx],ecx
       call      qword ptr [7FFBEBDF7180]; System.Text.StringBuilder.Append(Char)
       mov       r14,rax
       call      qword ptr [7FFBEC16D170]
       mov       rdx,rax
       mov       rcx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFBEBDF7228]; System.Text.StringBuilder.Append(System.String)
       mov       rcx,rax
       mov       edx,20
       cmp       [rcx],ecx
       call      qword ptr [7FFBEBDF7180]; System.Text.StringBuilder.Append(Char)
       mov       edx,431BDE83
       mov       eax,edx
       imul      esi
       mov       eax,edx
       shr       eax,1F
       sar       edx,12
       add       eax,edx
       imul      eax,0F4240
       sub       esi,eax
       jmp       near ptr M05_L09
M05_L23:
       mov       rcx,rdi
       mov       edx,2D
       call      qword ptr [7FFBEBDF73A8]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M05_L14
M05_L24:
       call      qword ptr [7FFBEC204F60]
       test      eax,eax
       jne       short M05_L27
       jmp       near ptr M05_L16
M05_L25:
       call      qword ptr [7FFBEC204F60]
       test      eax,eax
       jne       short M05_L27
       jmp       near ptr M05_L17
M05_L26:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M05_L27:
       mov       rcx,r14
       mov       edx,3
       call      qword ptr [7FFBEC204F78]
       mov       r8,rax
       jmp       near ptr M05_L18
M05_L28:
       call      M05_L150
       nop
       mov       r8,[rbp-70]
       mov       rbx,[rbp-38]
       cmp       [rbx],bl
       test      r8,r8
       je        short M05_L30
       lea       rdx,[r8+0C]
       mov       esi,[r8+8]
       test      esi,esi
       je        short M05_L30
       mov       r8,[rbx+8]
       mov       edi,[rbx+18]
       lea       ecx,[rdi+rsi]
       cmp       ecx,[r8+8]
       ja        near ptr M05_L105
       movsxd    rcx,edi
       lea       rcx,[r8+rcx*2+10]
       cmp       esi,2
       jle       near ptr M05_L104
       mov       r8d,esi
       add       r8,r8
       call      qword ptr [7FFBEBB65818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M05_L29:
       add       esi,edi
       mov       [rbx+18],esi
M05_L30:
       mov       ecx,[rbx+18]
       mov       rdx,[rbx+8]
       cmp       [rdx+8],ecx
       jbe       near ptr M05_L106
       cmp       ecx,[rdx+8]
       jae       near ptr M05_L116
       mov       word ptr [rdx+rcx*2+10],20
       inc       dword ptr [rbx+18]
M05_L31:
       call      qword ptr [7FFBEC16D1A0]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Hundred()
       test      rax,rax
       je        short M05_L33
       lea       rdx,[rax+0C]
       mov       esi,[rax+8]
       test      esi,esi
       je        short M05_L33
       mov       r8,[rbx+8]
       mov       edi,[rbx+18]
       lea       ecx,[rdi+rsi]
       cmp       ecx,[r8+8]
       ja        near ptr M05_L108
       movsxd    rcx,edi
       lea       rcx,[r8+rcx*2+10]
       cmp       esi,2
       jle       near ptr M05_L107
       mov       r8d,esi
       add       r8,r8
       call      qword ptr [7FFBEBB65818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M05_L32:
       add       esi,edi
       mov       [rbx+18],esi
M05_L33:
       mov       ecx,[rbx+18]
       mov       rdx,[rbx+8]
       cmp       [rdx+8],ecx
       jbe       near ptr M05_L109
       cmp       ecx,[rdx+8]
       jae       near ptr M05_L116
       mov       word ptr [rdx+rcx*2+10],20
       inc       dword ptr [rbx+18]
M05_L34:
       mov       edx,51EB851F
       mov       eax,edx
       imul      dword ptr [rbp+10]
       mov       esi,edx
       shr       esi,1F
       sar       edx,5
       add       esi,edx
       imul      eax,esi,64
       mov       ecx,[rbp+10]
       sub       ecx,eax
       mov       [rbp+10],ecx
M05_L35:
       cmp       dword ptr [rbp+10],0
       jle       near ptr M05_L41
       mov       rbx,[rbp-38]
       mov       eax,[rbx+1C]
       add       eax,[rbx+18]
       test      eax,eax
       jg        near ptr M05_L83
M05_L36:
       cmp       dword ptr [rbp+10],14
       jl        near ptr M05_L85
       mov       edx,66666667
       mov       eax,edx
       imul      dword ptr [rbp+10]
       mov       eax,edx
       shr       eax,1F
       sar       edx,2
       add       eax,edx
       mov       rdx,1E6AC401DD0
       mov       r8,[rdx]
       cmp       eax,0A
       jae       near ptr M05_L116
       mov       edx,66666667
       mov       eax,edx
       imul      dword ptr [rbp+10]
       mov       ecx,edx
       shr       ecx,1F
       sar       edx,2
       add       ecx,edx
       mov       r8,[r8+rcx*8+10]
       test      r8,r8
       je        short M05_L38
       lea       rdx,[r8+0C]
       mov       esi,[r8+8]
       test      esi,esi
       je        short M05_L38
       mov       r8,[rbx+8]
       mov       edi,[rbx+18]
       lea       ecx,[rdi+rsi]
       cmp       ecx,[r8+8]
       ja        near ptr M05_L112
       movsxd    rcx,edi
       lea       rcx,[r8+rcx*2+10]
       cmp       esi,2
       jle       near ptr M05_L111
       mov       r8d,esi
       add       r8,r8
       call      qword ptr [7FFBEBB65818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M05_L37:
       add       esi,edi
       mov       [rbx+18],esi
M05_L38:
       mov       edx,66666667
       mov       eax,edx
       imul      dword ptr [rbp+10]
       mov       ecx,edx
       shr       ecx,1F
       sar       edx,2
       add       ecx,edx
       lea       ecx,[rcx+rcx*4]
       add       ecx,ecx
       mov       edx,[rbp+10]
       sub       edx,ecx
       test      edx,edx
       jle       near ptr M05_L41
       mov       ecx,[rbx+18]
       mov       rdx,[rbx+8]
       cmp       [rdx+8],ecx
       jbe       near ptr M05_L113
       cmp       ecx,[rdx+8]
       jae       near ptr M05_L116
       mov       word ptr [rdx+rcx*2+10],2D
       inc       dword ptr [rbx+18]
M05_L39:
       mov       edx,66666667
       mov       eax,edx
       imul      dword ptr [rbp+10]
       mov       eax,edx
       shr       eax,1F
       sar       edx,2
       add       eax,edx
       lea       eax,[rax+rax*4]
       add       eax,eax
       mov       edx,[rbp+10]
       sub       edx,eax
       mov       rax,1E6AC401DD8
       mov       r14,[rax]
       cmp       edx,14
       jae       near ptr M05_L116
       mov       edx,66666667
       mov       eax,edx
       imul      dword ptr [rbp+10]
       mov       r8d,edx
       shr       r8d,1F
       sar       edx,2
       add       r8d,edx
       lea       r8d,[r8+r8*4]
       add       r8d,r8d
       mov       ecx,[rbp+10]
       sub       ecx,r8d
       mov       r8d,ecx
       mov       r8,[r14+r8*8+10]
       test      r8,r8
       je        short M05_L41
       lea       rdx,[r8+0C]
       mov       r14d,[r8+8]
       test      r14d,r14d
       je        short M05_L41
       mov       r8,[rbx+8]
       mov       esi,[rbx+18]
       lea       ecx,[rsi+r14]
       cmp       ecx,[r8+8]
       ja        near ptr M05_L115
       movsxd    rcx,esi
       lea       rcx,[r8+rcx*2+10]
       cmp       r14d,2
       jle       near ptr M05_L114
       mov       r8d,r14d
       add       r8,r8
       call      qword ptr [7FFBEBB65818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M05_L40:
       add       r14d,esi
       mov       [rbx+18],r14d
M05_L41:
       mov       rbx,[rbp-38]
       mov       rcx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FFBEBE06DE8]; System.Text.StringBuilder.ToString()
       mov       r14,rax
       cmp       dword ptr [r14+8],0
       je        short M05_L43
       movzx     ecx,word ptr [r14+0C]
       cmp       ecx,100
       jge       near ptr M05_L117
       cmp       ecx,100
       jae       near ptr M05_L116
       mov       rax,7FFC49676098
       test      byte ptr [rax+rcx],80
       jne       near ptr M05_L119
M05_L42:
       mov       ecx,[r14+8]
       dec       ecx
       cmp       ecx,[r14+8]
       jae       near ptr M05_L116
       mov       ecx,[r14+8]
       dec       ecx
       movzx     ecx,word ptr [r14+rcx*2+0C]
       cmp       ecx,100
       jge       near ptr M05_L118
       cmp       ecx,100
       jae       near ptr M05_L116
       mov       rax,7FFC49676098
       test      byte ptr [rax+rcx],80
       jne       near ptr M05_L119
M05_L43:
       mov       rcx,r14
M05_L44:
       mov       [rbp-40],rcx
       jmp       near ptr M05_L120
M05_L45:
       mov       rcx,1E6AC401DC8
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0
       jne       near ptr M05_L94
       mov       rcx,[rcx+18]
M05_L46:
       mov       rax,offset MT_Microsoft.Extensions.ObjectPool.DefaultObjectPool<System.Text.StringBuilder>
       cmp       [rcx],rax
       jne       near ptr M05_L95
       cmp       [rcx],ecx
       call      qword ptr [7FFBEBFC2B00]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Get()
       mov       rsi,rax
M05_L47:
       mov       [rbp-58],rsi
       mov       edx,431BDE83
       mov       eax,edx
       imul      ebx
       mov       eax,edx
       shr       eax,1F
       sar       edx,12
       add       eax,edx
       test      eax,eax
       jg        near ptr M05_L65
M05_L48:
       mov       edx,10624DD3
       mov       eax,edx
       imul      ebx
       mov       edi,edx
       shr       edi,1F
       sar       edx,6
       add       edi,edx
       test      edi,edi
       jg        near ptr M05_L60
M05_L49:
       mov       edx,51EB851F
       mov       eax,edx
       imul      ebx
       mov       edi,edx
       shr       edi,1F
       sar       edx,5
       add       edi,edx
       test      edi,edi
       jle       near ptr M05_L52
       mov       ecx,edi
       call      qword ptr [7FFBEC16D0F8]
       mov       rdx,rax
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFBEBDF7228]; System.Text.StringBuilder.Append(System.String)
       mov       r14,rax
       mov       ecx,[r14+18]
       mov       edx,ecx
       mov       rax,[r14+8]
       mov       r8d,[rax+8]
       cmp       r8d,edx
       jbe       near ptr M05_L68
       cmp       edx,r8d
       jae       near ptr M05_L74
       mov       word ptr [rax+rdx*2+10],20
       inc       ecx
       mov       [r14+18],ecx
M05_L50:
       call      qword ptr [7FFBEC16D1A0]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Hundred()
       mov       rdx,rax
       mov       rcx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFBEBDF7228]; System.Text.StringBuilder.Append(System.String)
       mov       ecx,[rax+18]
       mov       edx,ecx
       mov       r8,[rax+8]
       mov       r10d,[r8+8]
       cmp       r10d,edx
       jbe       near ptr M05_L69
       cmp       edx,r10d
       jae       near ptr M05_L74
       mov       word ptr [r8+rdx*2+10],20
       inc       ecx
       mov       [rax+18],ecx
M05_L51:
       imul      eax,edi,64
       sub       ebx,eax
M05_L52:
       test      ebx,ebx
       jle       near ptr M05_L56
       mov       eax,[rsi+1C]
       add       eax,[rsi+18]
       test      eax,eax
       jg        near ptr M05_L63
M05_L53:
       cmp       ebx,14
       jl        near ptr M05_L64
       mov       edx,66666667
       mov       eax,edx
       imul      ebx
       mov       edi,edx
       shr       edi,1F
       sar       edx,2
       add       edi,edx
       mov       r8,1E6AC401DD0
       mov       r8,[r8]
       cmp       edi,0A
       jae       near ptr M05_L74
       mov       edx,edi
       mov       rdx,[r8+rdx*8+10]
       test      rdx,rdx
       je        short M05_L54
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,rsi
       call      qword ptr [7FFBEBDF7150]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M05_L54:
       lea       ecx,[rdi+rdi*4]
       add       ecx,ecx
       sub       ebx,ecx
       test      ebx,ebx
       jle       short M05_L56
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       rax,[rsi+8]
       mov       r8d,[rax+8]
       cmp       r8d,edx
       jbe       near ptr M05_L71
       cmp       edx,r8d
       jae       near ptr M05_L74
       mov       word ptr [rax+rdx*2+10],2D
       inc       ecx
       mov       [rsi+18],ecx
M05_L55:
       mov       r8,1E6AC401DD8
       mov       r14,[r8]
       cmp       ebx,14
       jae       near ptr M05_L74
       mov       r8d,ebx
       mov       rdx,[r14+r8*8+10]
       test      rdx,rdx
       je        short M05_L56
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,rsi
       call      qword ptr [7FFBEBDF7150]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M05_L56:
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFBEBE06DE8]; System.Text.StringBuilder.ToString()
       mov       r14,rax
       cmp       dword ptr [r14+8],0
       je        short M05_L58
       movzx     ecx,word ptr [r14+0C]
       cmp       ecx,100
       jge       near ptr M05_L72
       cmp       ecx,100
       jae       near ptr M05_L74
       mov       rax,7FFC49676098
       test      byte ptr [rax+rcx],80
       jne       near ptr M05_L75
M05_L57:
       mov       ecx,[r14+8]
       dec       ecx
       cmp       ecx,[r14+8]
       jae       near ptr M05_L74
       movzx     ecx,word ptr [r14+rcx*2+0C]
       cmp       ecx,100
       jge       near ptr M05_L73
       cmp       ecx,100
       jae       near ptr M05_L74
       mov       rax,7FFC49676098
       test      byte ptr [rax+rcx],80
       jne       near ptr M05_L75
M05_L58:
       mov       r8,r14
M05_L59:
       mov       [rbp-60],r8
       jmp       near ptr M05_L76
M05_L60:
       mov       ecx,edi
       call      qword ptr [7FFBEC16D0F8]
       mov       rdx,rax
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFBEBDF7228]; System.Text.StringBuilder.Append(System.String)
       mov       r14,rax
       mov       ecx,[r14+18]
       mov       edx,ecx
       mov       rax,[r14+8]
       mov       r8d,[rax+8]
       cmp       r8d,edx
       jbe       near ptr M05_L66
       cmp       edx,r8d
       jae       near ptr M05_L74
       mov       word ptr [rax+rdx*2+10],20
       inc       ecx
       mov       [r14+18],ecx
M05_L61:
       call      qword ptr [7FFBEC16D188]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Thousand()
       mov       rdx,rax
       mov       rcx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFBEBDF7228]; System.Text.StringBuilder.Append(System.String)
       mov       ecx,[rax+18]
       mov       edx,ecx
       mov       r8,[rax+8]
       mov       r10d,[r8+8]
       cmp       r10d,edx
       jbe       near ptr M05_L67
       cmp       edx,r10d
       jae       near ptr M05_L74
       mov       word ptr [r8+rdx*2+10],20
       inc       ecx
       mov       [rax+18],ecx
M05_L62:
       imul      eax,edi,3E8
       sub       ebx,eax
       jmp       near ptr M05_L49
M05_L63:
       call      qword ptr [7FFBEC16D1D0]; DotNetTips.Spargine.Extensions.Properties.Resources.get_AndLowerCase()
       mov       rdx,rax
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFBEBDF7228]; System.Text.StringBuilder.Append(System.String)
       mov       ecx,[rax+18]
       mov       edx,ecx
       mov       r8,[rax+8]
       mov       r10d,[r8+8]
       cmp       r10d,edx
       jbe       near ptr M05_L70
       cmp       edx,r10d
       jae       near ptr M05_L74
       mov       word ptr [r8+rdx*2+10],20
       inc       ecx
       mov       [rax+18],ecx
       jmp       near ptr M05_L53
M05_L64:
       mov       rdx,1E6AC401DD8
       mov       r14,[rdx]
       cmp       ebx,14
       jae       near ptr M05_L74
       mov       edx,ebx
       mov       rdx,[r14+rdx*8+10]
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFBEBDF7228]; System.Text.StringBuilder.Append(System.String)
       jmp       near ptr M05_L56
M05_L65:
       mov       edx,431BDE83
       mov       eax,edx
       imul      ebx
       mov       ecx,edx
       shr       ecx,1F
       sar       edx,12
       add       ecx,edx
       call      qword ptr [7FFBEC16D0F8]
       mov       rdx,rax
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFBEBDF7228]; System.Text.StringBuilder.Append(System.String)
       mov       rcx,rax
       mov       edx,20
       cmp       [rcx],ecx
       call      qword ptr [7FFBEBDF7180]; System.Text.StringBuilder.Append(Char)
       mov       rdi,rax
       call      qword ptr [7FFBEC16D170]
       mov       rdx,rax
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFBEBDF7228]; System.Text.StringBuilder.Append(System.String)
       mov       rcx,rax
       mov       edx,20
       cmp       [rcx],ecx
       call      qword ptr [7FFBEBDF7180]; System.Text.StringBuilder.Append(Char)
       mov       edx,431BDE83
       mov       eax,edx
       imul      ebx
       mov       eax,edx
       shr       eax,1F
       sar       edx,12
       add       eax,edx
       imul      eax,0F4240
       sub       ebx,eax
       jmp       near ptr M05_L48
M05_L66:
       mov       rcx,r14
       mov       edx,20
       call      qword ptr [7FFBEBDF73A8]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M05_L61
M05_L67:
       mov       rcx,rax
       mov       edx,20
       call      qword ptr [7FFBEBDF73A8]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M05_L62
M05_L68:
       mov       rcx,r14
       mov       edx,20
       call      qword ptr [7FFBEBDF73A8]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M05_L50
M05_L69:
       mov       rcx,rax
       mov       edx,20
       call      qword ptr [7FFBEBDF73A8]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M05_L51
M05_L70:
       mov       rcx,rax
       mov       edx,20
       call      qword ptr [7FFBEBDF73A8]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M05_L53
M05_L71:
       mov       rcx,rsi
       mov       edx,2D
       call      qword ptr [7FFBEBDF73A8]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M05_L55
M05_L72:
       call      qword ptr [7FFBEC204F60]
       test      eax,eax
       jne       short M05_L75
       jmp       near ptr M05_L57
M05_L73:
       call      qword ptr [7FFBEC204F60]
       test      eax,eax
       jne       short M05_L75
       jmp       near ptr M05_L58
M05_L74:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M05_L75:
       mov       rcx,r14
       mov       edx,3
       call      qword ptr [7FFBEC204F78]
       mov       r8,rax
       jmp       near ptr M05_L59
M05_L76:
       call      M05_L142
       nop
       mov       r8,[rbp-60]
       mov       rbx,[rbp-38]
       cmp       [rbx],bl
       test      r8,r8
       je        short M05_L78
       lea       rdx,[r8+0C]
       mov       r8d,[r8+8]
       test      r8d,r8d
       je        short M05_L78
       mov       rcx,[rbx+8]
       mov       eax,[rbx+18]
       lea       esi,[rax+r8]
       cmp       esi,[rcx+8]
       ja        near ptr M05_L97
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jle       near ptr M05_L96
       mov       r8d,r8d
       add       r8,r8
       call      qword ptr [7FFBEBB65818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M05_L77:
       mov       [rbx+18],esi
M05_L78:
       mov       ecx,[rbx+18]
       mov       edx,ecx
       mov       rax,[rbx+8]
       mov       r8d,[rax+8]
       cmp       r8d,edx
       jbe       near ptr M05_L98
       cmp       edx,r8d
       jae       near ptr M05_L116
       mov       word ptr [rax+rdx*2+10],20
       inc       ecx
       mov       [rbx+18],ecx
M05_L79:
       call      qword ptr [7FFBEC16D188]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Thousand()
       test      rax,rax
       je        short M05_L81
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
       test      r8d,r8d
       je        short M05_L81
       mov       rcx,[rbx+8]
       mov       eax,[rbx+18]
       lea       esi,[rax+r8]
       cmp       esi,[rcx+8]
       ja        near ptr M05_L100
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jle       near ptr M05_L99
       mov       r8d,r8d
       add       r8,r8
       call      qword ptr [7FFBEBB65818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M05_L80:
       mov       [rbx+18],esi
M05_L81:
       mov       ecx,[rbx+18]
       mov       edx,ecx
       mov       rax,[rbx+8]
       mov       r8d,[rax+8]
       cmp       r8d,edx
       jbe       near ptr M05_L101
       cmp       edx,r8d
       jae       near ptr M05_L116
       mov       word ptr [rax+rdx*2+10],20
       inc       ecx
       mov       [rbx+18],ecx
M05_L82:
       mov       edx,10624DD3
       mov       eax,edx
       imul      dword ptr [rbp+10]
       mov       eax,edx
       shr       eax,1F
       sar       edx,6
       add       eax,edx
       imul      eax,3E8
       mov       edx,[rbp+10]
       sub       edx,eax
       mov       [rbp+10],edx
       jmp       near ptr M05_L06
M05_L83:
       call      qword ptr [7FFBEC16D1D0]; DotNetTips.Spargine.Extensions.Properties.Resources.get_AndLowerCase()
       mov       rdx,rax
       test      rdx,rdx
       je        short M05_L84
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,rbx
       call      qword ptr [7FFBEBDF7150]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M05_L84:
       mov       ecx,[rbx+18]
       mov       rdx,[rbx+8]
       cmp       [rdx+8],ecx
       jbe       near ptr M05_L110
       cmp       ecx,[rdx+8]
       jae       near ptr M05_L116
       mov       word ptr [rdx+rcx*2+10],20
       inc       dword ptr [rbx+18]
       jmp       near ptr M05_L36
M05_L85:
       mov       r8,1E6AC401DD8
       mov       r14,[r8]
       cmp       dword ptr [rbp+10],14
       jae       near ptr M05_L116
       mov       r8d,[rbp+10]
       mov       rdx,[r14+r8*8+10]
       test      rdx,rdx
       je        near ptr M05_L41
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,rbx
       call      qword ptr [7FFBEBDF7150]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       jmp       near ptr M05_L41
M05_L86:
       mov       ecx,[rbp+10]
       imul      rsi,rcx,431BDE83
       shr       rsi,32
       mov       rcx,1E6AC401DC8
       mov       rcx,[rcx]
       call      qword ptr [7FFBEBDFFEE8]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].get_Value()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp-50],rax
       mov       ecx,esi
       imul      rcx,431BDE83
       shr       rcx,32
       test      ecx,ecx
       jle       short M05_L87
       mov       ecx,esi
       imul      rcx,431BDE83
       shr       rcx,32
       call      qword ptr [7FFBEC16D0F8]
       mov       rdx,rax
       mov       rcx,[rbp-50]
       cmp       [rcx],ecx
       call      qword ptr [7FFBEBDF7228]; System.Text.StringBuilder.Append(System.String)
       mov       rcx,rax
       mov       edx,20
       cmp       [rcx],ecx
       call      qword ptr [7FFBEBDF7180]; System.Text.StringBuilder.Append(Char)
       mov       rdi,rax
       call      qword ptr [7FFBEC16D170]
       mov       rdx,rax
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFBEBDF7228]; System.Text.StringBuilder.Append(System.String)
       mov       rcx,rax
       mov       edx,20
       cmp       [rcx],ecx
       call      qword ptr [7FFBEBDF7180]; System.Text.StringBuilder.Append(Char)
       mov       eax,esi
       imul      rax,431BDE83
       shr       rax,32
       imul      eax,0F4240
       sub       esi,eax
M05_L87:
       mov       edx,10624DD3
       mov       eax,edx
       imul      esi
       mov       eax,edx
       shr       eax,1F
       sar       edx,6
       add       eax,edx
       test      eax,eax
       jle       short M05_L88
       mov       edx,10624DD3
       mov       eax,edx
       imul      esi
       mov       ecx,edx
       shr       ecx,1F
       sar       edx,6
       add       ecx,edx
       call      qword ptr [7FFBEC16D0F8]
       mov       rdx,rax
       mov       rcx,[rbp-50]
       cmp       [rcx],ecx
       call      qword ptr [7FFBEBDF7228]; System.Text.StringBuilder.Append(System.String)
       mov       rcx,rax
       mov       edx,20
       cmp       [rcx],ecx
       call      qword ptr [7FFBEBDF7180]; System.Text.StringBuilder.Append(Char)
       mov       rdi,rax
       call      qword ptr [7FFBEC16D188]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Thousand()
       mov       rdx,rax
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFBEBDF7228]; System.Text.StringBuilder.Append(System.String)
       mov       rcx,rax
       mov       edx,20
       cmp       [rcx],ecx
       call      qword ptr [7FFBEBDF7180]; System.Text.StringBuilder.Append(Char)
       mov       edx,10624DD3
       mov       eax,edx
       imul      esi
       mov       eax,edx
       shr       eax,1F
       sar       edx,6
       add       eax,edx
       imul      eax,3E8
       sub       esi,eax
M05_L88:
       mov       edx,51EB851F
       mov       eax,edx
       imul      esi
       mov       eax,edx
       shr       eax,1F
       sar       edx,5
       add       eax,edx
       test      eax,eax
       jle       short M05_L89
       mov       edx,51EB851F
       mov       eax,edx
       imul      esi
       mov       ecx,edx
       shr       ecx,1F
       sar       edx,5
       add       ecx,edx
       call      qword ptr [7FFBEC16D0F8]
       mov       rdx,rax
       mov       rcx,[rbp-50]
       cmp       [rcx],ecx
       call      qword ptr [7FFBEBDF7228]; System.Text.StringBuilder.Append(System.String)
       mov       rcx,rax
       mov       edx,20
       cmp       [rcx],ecx
       call      qword ptr [7FFBEBDF7180]; System.Text.StringBuilder.Append(Char)
       mov       rdi,rax
       call      qword ptr [7FFBEC16D1A0]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Hundred()
       mov       rdx,rax
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFBEBDF7228]; System.Text.StringBuilder.Append(System.String)
       mov       rcx,rax
       mov       edx,20
       cmp       [rcx],ecx
       call      qword ptr [7FFBEBDF7180]; System.Text.StringBuilder.Append(Char)
       mov       edx,51EB851F
       mov       eax,edx
       imul      esi
       mov       eax,edx
       shr       eax,1F
       sar       edx,5
       add       eax,edx
       imul      eax,64
       sub       esi,eax
M05_L89:
       test      esi,esi
       jle       near ptr M05_L93
       mov       rcx,[rbp-50]
       mov       eax,[rcx+1C]
       add       eax,[rcx+18]
       test      eax,eax
       jle       short M05_L90
       call      qword ptr [7FFBEC16D1D0]; DotNetTips.Spargine.Extensions.Properties.Resources.get_AndLowerCase()
       mov       rdx,rax
       mov       rcx,[rbp-50]
       call      qword ptr [7FFBEBDF7228]; System.Text.StringBuilder.Append(System.String)
       mov       rcx,rax
       mov       edx,20
       cmp       [rcx],ecx
       call      qword ptr [7FFBEBDF7180]; System.Text.StringBuilder.Append(Char)
M05_L90:
       cmp       esi,14
       jge       short M05_L92
       mov       rdx,1E6AC401DD8
       mov       r14,[rdx]
       cmp       esi,14
       jae       short M05_L91
       mov       edx,esi
       mov       rdx,[r14+rdx*8+10]
       mov       rcx,[rbp-50]
       call      qword ptr [7FFBEBDF7228]; System.Text.StringBuilder.Append(System.String)
       jmp       near ptr M05_L93
M05_L91:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M05_L92:
       mov       edx,66666667
       mov       eax,edx
       imul      esi
       mov       eax,edx
       shr       eax,1F
       sar       edx,2
       add       eax,edx
       mov       rdx,1E6AC401DD0
       mov       rdi,[rdx]
       cmp       eax,0A
       jae       short M05_L91
       mov       edx,66666667
       mov       eax,edx
       imul      esi
       mov       eax,edx
       shr       eax,1F
       sar       edx,2
       add       edx,eax
       mov       rdx,[rdi+rdx*8+10]
       mov       rcx,[rbp-50]
       call      qword ptr [7FFBEBDF7228]; System.Text.StringBuilder.Append(System.String)
       mov       edx,66666667
       mov       eax,edx
       imul      esi
       mov       ecx,edx
       shr       ecx,1F
       sar       edx,2
       add       ecx,edx
       lea       ecx,[rcx+rcx*4]
       add       ecx,ecx
       mov       edx,esi
       sub       edx,ecx
       test      edx,edx
       jle       short M05_L93
       mov       rcx,[rbp-50]
       mov       edx,2D
       call      qword ptr [7FFBEBDF7180]; System.Text.StringBuilder.Append(Char)
       mov       rcx,rax
       mov       edx,66666667
       mov       eax,edx
       imul      esi
       mov       eax,edx
       shr       eax,1F
       sar       edx,2
       add       eax,edx
       lea       eax,[rax+rax*4]
       add       eax,eax
       mov       edx,esi
       sub       edx,eax
       mov       rax,1E6AC401DD8
       mov       r14,[rax]
       cmp       edx,14
       jae       near ptr M05_L91
       mov       edx,66666667
       mov       eax,edx
       imul      esi
       mov       eax,edx
       shr       eax,1F
       sar       edx,2
       add       edx,eax
       lea       edx,[rdx+rdx*4]
       add       edx,edx
       mov       eax,esi
       sub       eax,edx
       mov       edx,eax
       mov       rdx,[r14+rdx*8+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFBEBDF7228]; System.Text.StringBuilder.Append(System.String)
M05_L93:
       mov       rcx,[rbp-50]
       cmp       [rcx],ecx
       call      qword ptr [7FFBEBE06DE8]; System.Text.StringBuilder.ToString()
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFBEBF743D8]; System.String.Trim()
       mov       rdi,rax
       mov       rcx,1E6AC401DC8
       mov       rcx,[rcx]
       call      qword ptr [7FFBEBDFFEE8]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].get_Value()
       mov       r14,rax
       mov       rcx,[rbp-50]
       xor       edx,edx
       call      qword ptr [7FFBEC164BE8]; System.Text.StringBuilder.set_Length(Int32)
       mov       rcx,r14
       mov       rdx,[rbp-50]
       mov       rax,[r14]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       rdx,rdi
       mov       rcx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FFBEBDF7228]; System.Text.StringBuilder.Append(System.String)
       mov       rcx,rax
       mov       edx,20
       cmp       [rcx],ecx
       call      qword ptr [7FFBEBDF7180]; System.Text.StringBuilder.Append(Char)
       mov       rbx,rax
       call      qword ptr [7FFBEC16D170]
       mov       rdx,rax
       mov       rcx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FFBEBDF7228]; System.Text.StringBuilder.Append(System.String)
       mov       rcx,rax
       mov       edx,20
       cmp       [rcx],ecx
       call      qword ptr [7FFBEBDF7180]; System.Text.StringBuilder.Append(Char)
       mov       eax,[rbp+10]
       imul      rax,431BDE83
       shr       rax,32
       imul      eax,0F4240
       mov       edx,[rbp+10]
       sub       edx,eax
       mov       [rbp+10],edx
       jmp       near ptr M05_L05
M05_L94:
       call      qword ptr [7FFBEBDFFF48]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rcx,rax
       jmp       near ptr M05_L46
M05_L95:
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rsi,rax
       jmp       near ptr M05_L47
M05_L96:
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       jne       near ptr M05_L77
       movzx     edx,word ptr [rdx+2]
       mov       [rcx+2],dx
       jmp       near ptr M05_L77
M05_L97:
       mov       rcx,rbx
       call      qword ptr [7FFBEBDF71E0]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M05_L78
M05_L98:
       mov       rcx,rbx
       mov       edx,20
       call      qword ptr [7FFBEBDF73A8]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M05_L79
M05_L99:
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       jne       near ptr M05_L80
       movzx     edx,word ptr [rdx+2]
       mov       [rcx+2],dx
       jmp       near ptr M05_L80
M05_L100:
       mov       rcx,rbx
       call      qword ptr [7FFBEBDF71E0]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M05_L81
M05_L101:
       mov       rcx,rbx
       mov       edx,20
       call      qword ptr [7FFBEBDF73A8]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M05_L82
M05_L102:
       call      qword ptr [7FFBEBDFFF48]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rcx,rax
       jmp       near ptr M05_L07
M05_L103:
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rdi,rax
       jmp       near ptr M05_L08
M05_L104:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       esi,2
       jne       near ptr M05_L29
       movzx     edx,word ptr [rdx+2]
       mov       [rcx+2],dx
       jmp       near ptr M05_L29
M05_L105:
       mov       rcx,rbx
       mov       r8d,esi
       call      qword ptr [7FFBEBDF71E0]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M05_L30
M05_L106:
       mov       rcx,rbx
       mov       edx,20
       call      qword ptr [7FFBEBDF73A8]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M05_L31
M05_L107:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       esi,2
       jne       near ptr M05_L32
       movzx     edx,word ptr [rdx+2]
       mov       [rcx+2],dx
       jmp       near ptr M05_L32
M05_L108:
       mov       rcx,rbx
       mov       r8d,esi
       call      qword ptr [7FFBEBDF71E0]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M05_L33
M05_L109:
       mov       rcx,rbx
       mov       edx,20
       call      qword ptr [7FFBEBDF73A8]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M05_L34
M05_L110:
       mov       rcx,rbx
       mov       edx,20
       call      qword ptr [7FFBEBDF73A8]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M05_L36
M05_L111:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       esi,2
       jne       near ptr M05_L37
       movzx     edx,word ptr [rdx+2]
       mov       [rcx+2],dx
       jmp       near ptr M05_L37
M05_L112:
       mov       rcx,rbx
       mov       r8d,esi
       call      qword ptr [7FFBEBDF71E0]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M05_L38
M05_L113:
       mov       rcx,rbx
       mov       edx,2D
       call      qword ptr [7FFBEBDF73A8]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M05_L39
M05_L114:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       r14d,2
       jne       near ptr M05_L40
       movzx     edx,word ptr [rdx+2]
       mov       [rcx+2],dx
       jmp       near ptr M05_L40
M05_L115:
       mov       rcx,rbx
       mov       r8d,r14d
       call      qword ptr [7FFBEBDF71E0]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M05_L41
M05_L116:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M05_L117:
       call      qword ptr [7FFBEC204F60]
       test      eax,eax
       jne       short M05_L119
       jmp       near ptr M05_L42
M05_L118:
       call      qword ptr [7FFBEC204F60]
       test      eax,eax
       je        near ptr M05_L43
M05_L119:
       mov       rcx,r14
       mov       edx,3
       call      qword ptr [7FFBEC204F78]
       mov       rcx,rax
       jmp       near ptr M05_L44
M05_L120:
       call      M05_L158
       nop
       mov       rax,[rbp-40]
       add       rsp,68
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M05_L121:
       mov       rsi,[rbx+18]
       mov       rdi,[rsi+18]
       lea       rdx,[rbp-30]
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFBEC164AB0]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       jne       short M05_L122
       cmp       qword ptr [rdi+10],0
       je        short M05_L123
       lea       rdx,[rbp-30]
       mov       rcx,rsi
       call      qword ptr [7FFBEC205260]
       test      eax,eax
       je        short M05_L124
M05_L122:
       add       rbx,2C
       lock dec  dword ptr [rbx]
       jmp       near ptr M05_L02
M05_L123:
       xor       ecx,ecx
       mov       [rbp-30],rcx
M05_L124:
       mov       rax,[rbx+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       rbx,rax
       jmp       near ptr M05_L03
M05_L125:
       call      qword ptr [7FFBEC16D110]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Zero()
       nop
       add       rsp,68
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M05_L126:
       call      qword ptr [7FFBEC16D128]
       mov       rbx,rax
       mov       ecx,1
       call      qword ptr [7FFBEBB66670]; System.String.FastAllocateString(IntPtr)
       mov       rsi,rax
       mov       word ptr [rsi+0C],20
       mov       ecx,[rbp+10]
       mov       edi,ecx
       neg       edi
       js        short M05_L128
       mov       r14d,edi
       test      r14d,r14d
       jne       short M05_L127
       call      qword ptr [7FFBEC16D110]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Zero()
       mov       rdi,rax
       jmp       near ptr M05_L138
M05_L127:
       test      r14d,r14d
       jge       short M05_L130
       call      qword ptr [7FFBEC16D128]
       mov       r14,rax
       mov       ecx,1
       call      qword ptr [7FFBEBB66670]; System.String.FastAllocateString(IntPtr)
       mov       r15,rax
       mov       word ptr [r15+0C],20
       mov       ecx,edi
       neg       ecx
       jns       short M05_L129
M05_L128:
       call      qword ptr [7FFBEC206298]
       int       3
M05_L129:
       call      qword ptr [7FFBEC16D0F8]
       mov       r8,rax
       mov       rdx,r15
       mov       rcx,r14
       call      qword ptr [7FFBEBD35488]; System.String.Concat(System.String, System.String, System.String)
       mov       rdi,rax
       jmp       near ptr M05_L138
M05_L130:
       mov       rcx,1E6AC401DC8
       mov       rcx,[rcx]
       call      qword ptr [7FFBEBDFFEE8]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].get_Value()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp-48],rax
       mov       ecx,r14d
       imul      rcx,431BDE83
       shr       rcx,32
       test      ecx,ecx
       jle       short M05_L131
       mov       ecx,edi
       imul      rcx,431BDE83
       shr       rcx,32
       call      qword ptr [7FFBEC16D0F8]
       mov       rdx,rax
       mov       rcx,[rbp-48]
       cmp       [rcx],ecx
       call      qword ptr [7FFBEBDF7228]; System.Text.StringBuilder.Append(System.String)
       mov       rcx,rax
       mov       edx,20
       cmp       [rcx],ecx
       call      qword ptr [7FFBEBDF7180]; System.Text.StringBuilder.Append(Char)
       mov       r14,rax
       call      qword ptr [7FFBEC16D170]
       mov       rdx,rax
       mov       rcx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFBEBDF7228]; System.Text.StringBuilder.Append(System.String)
       mov       rcx,rax
       mov       edx,20
       cmp       [rcx],ecx
       call      qword ptr [7FFBEBDF7180]; System.Text.StringBuilder.Append(Char)
       mov       eax,edi
       imul      rax,431BDE83
       shr       rax,32
       imul      eax,0F4240
       mov       r14d,edi
       sub       r14d,eax
M05_L131:
       mov       edx,10624DD3
       mov       eax,edx
       imul      r14d
       mov       eax,edx
       shr       eax,1F
       sar       edx,6
       add       eax,edx
       test      eax,eax
       jle       near ptr M05_L132
       mov       edx,10624DD3
       mov       eax,edx
       imul      r14d
       mov       ecx,edx
       shr       ecx,1F
       sar       edx,6
       add       ecx,edx
       call      qword ptr [7FFBEC16D0F8]
       mov       rdx,rax
       mov       rcx,[rbp-48]
       cmp       [rcx],ecx
       call      qword ptr [7FFBEBDF7228]; System.Text.StringBuilder.Append(System.String)
       mov       rcx,rax
       mov       edx,20
       cmp       [rcx],ecx
       call      qword ptr [7FFBEBDF7180]; System.Text.StringBuilder.Append(Char)
       mov       rdi,rax
       call      qword ptr [7FFBEC16D188]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Thousand()
       mov       rdx,rax
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFBEBDF7228]; System.Text.StringBuilder.Append(System.String)
       mov       rcx,rax
       mov       edx,20
       cmp       [rcx],ecx
       call      qword ptr [7FFBEBDF7180]; System.Text.StringBuilder.Append(Char)
       mov       edx,10624DD3
       mov       eax,edx
       imul      r14d
       mov       eax,edx
       shr       eax,1F
       sar       edx,6
       add       eax,edx
       imul      eax,3E8
       sub       r14d,eax
M05_L132:
       mov       edx,51EB851F
       mov       eax,edx
       imul      r14d
       mov       eax,edx
       shr       eax,1F
       sar       edx,5
       add       eax,edx
       test      eax,eax
       jle       short M05_L133
       mov       edx,51EB851F
       mov       eax,edx
       imul      r14d
       mov       ecx,edx
       shr       ecx,1F
       sar       edx,5
       add       ecx,edx
       call      qword ptr [7FFBEC16D0F8]
       mov       rdx,rax
       mov       rcx,[rbp-48]
       cmp       [rcx],ecx
       call      qword ptr [7FFBEBDF7228]; System.Text.StringBuilder.Append(System.String)
       mov       rcx,rax
       mov       edx,20
       cmp       [rcx],ecx
       call      qword ptr [7FFBEBDF7180]; System.Text.StringBuilder.Append(Char)
       mov       rdi,rax
       call      qword ptr [7FFBEC16D1A0]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Hundred()
       mov       rdx,rax
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFBEBDF7228]; System.Text.StringBuilder.Append(System.String)
       mov       rcx,rax
       mov       edx,20
       cmp       [rcx],ecx
       call      qword ptr [7FFBEBDF7180]; System.Text.StringBuilder.Append(Char)
       mov       edx,51EB851F
       mov       eax,edx
       imul      r14d
       mov       eax,edx
       shr       eax,1F
       sar       edx,5
       add       eax,edx
       imul      eax,64
       sub       r14d,eax
M05_L133:
       test      r14d,r14d
       jle       near ptr M05_L137
       mov       rcx,[rbp-48]
       mov       eax,[rcx+1C]
       add       eax,[rcx+18]
       test      eax,eax
       jle       short M05_L134
       call      qword ptr [7FFBEC16D1D0]; DotNetTips.Spargine.Extensions.Properties.Resources.get_AndLowerCase()
       mov       rdx,rax
       mov       rcx,[rbp-48]
       call      qword ptr [7FFBEBDF7228]; System.Text.StringBuilder.Append(System.String)
       mov       rcx,rax
       mov       edx,20
       cmp       [rcx],ecx
       call      qword ptr [7FFBEBDF7180]; System.Text.StringBuilder.Append(Char)
M05_L134:
       cmp       r14d,14
       jge       short M05_L136
       mov       rdx,1E6AC401DD8
       mov       r8,[rdx]
       mov       edx,r14d
       mov       rdx,[r8+rdx*8+10]
       mov       rcx,[rbp-48]
       call      qword ptr [7FFBEBDF7228]; System.Text.StringBuilder.Append(System.String)
       jmp       near ptr M05_L137
M05_L135:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M05_L136:
       mov       edx,0CCCCCCCD
       mov       eax,r14d
       imul      rdx,rax
       shr       rdx,23
       mov       rax,1E6AC401DD0
       mov       r8,[rax]
       cmp       edx,0A
       jae       short M05_L135
       mov       edx,0CCCCCCCD
       mov       eax,r14d
       imul      rdx,rax
       shr       rdx,23
       mov       edx,edx
       mov       rdx,[r8+rdx*8+10]
       mov       rcx,[rbp-48]
       call      qword ptr [7FFBEBDF7228]; System.Text.StringBuilder.Append(System.String)
       mov       ecx,0CCCCCCCD
       mov       edx,r14d
       imul      rcx,rdx
       shr       rcx,23
       lea       ecx,[rcx+rcx*4]
       add       ecx,ecx
       mov       edx,r14d
       sub       edx,ecx
       test      edx,edx
       jle       short M05_L137
       mov       rcx,[rbp-48]
       mov       edx,2D
       call      qword ptr [7FFBEBDF7180]; System.Text.StringBuilder.Append(Char)
       mov       rcx,rax
       mov       edx,0CCCCCCCD
       mov       eax,r14d
       imul      rdx,rax
       shr       rdx,23
       lea       edx,[rdx+rdx*4]
       add       edx,edx
       mov       eax,r14d
       sub       eax,edx
       mov       rdx,1E6AC401DD8
       mov       rdx,[rdx]
       mov       r8,rdx
       cmp       eax,14
       jae       near ptr M05_L135
       mov       edx,0CCCCCCCD
       mov       eax,r14d
       imul      rdx,rax
       shr       rdx,23
       lea       edx,[rdx+rdx*4]
       add       edx,edx
       mov       eax,r14d
       sub       eax,edx
       mov       edx,eax
       mov       rdx,[r8+rdx*8+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFBEBDF7228]; System.Text.StringBuilder.Append(System.String)
M05_L137:
       mov       rcx,[rbp-48]
       cmp       [rcx],ecx
       call      qword ptr [7FFBEBE06DE8]; System.Text.StringBuilder.ToString()
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFBEBF743D8]; System.String.Trim()
       mov       rdi,rax
       mov       rcx,1E6AC401DC8
       mov       rcx,[rcx]
       call      qword ptr [7FFBEBDFFEE8]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].get_Value()
       mov       r14,rax
       mov       rcx,[rbp-48]
       xor       edx,edx
       call      qword ptr [7FFBEC164BE8]; System.Text.StringBuilder.set_Length(Int32)
       mov       rcx,r14
       mov       rdx,[rbp-48]
       mov       rax,[r14]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
M05_L138:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       call      qword ptr [7FFBEBD35488]; System.String.Concat(System.String, System.String, System.String)
       nop
       add       rsp,68
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M05_L139:
       call      qword ptr [7FFBEBDFFF48]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rbx,rax
       jmp       near ptr M05_L01
M05_L140:
       call      qword ptr [7FFBEC204F30]
       int       3
M05_L141:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rbx,rax
       jmp       near ptr M05_L04
       sub       rsp,28
       mov       rcx,1E6AC401DC8
       mov       rcx,[rcx]
       cmp       [rcx],ecx
       call      qword ptr [7FFBEBDFFEE8]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].get_Value()
       mov       rdi,rax
       mov       rcx,[rbp-50]
       cmp       [rcx],cl
       xor       edx,edx
       call      qword ptr [7FFBEC164BE8]; System.Text.StringBuilder.set_Length(Int32)
       mov       rcx,rdi
       mov       rdx,[rbp-50]
       mov       rax,[rdi]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       add       rsp,28
       ret
M05_L142:
       sub       rsp,28
       mov       rcx,1E6AC401DC8
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0
       je        short M05_L143
       call      qword ptr [7FFBEBDFFF48]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rbx,rax
       jmp       short M05_L144
M05_L143:
       mov       rbx,[rcx+18]
M05_L144:
       mov       rdx,[rbp-58]
       cmp       [rdx],dl
       mov       rcx,rdx
       xor       edx,edx
       call      qword ptr [7FFBEC164BE8]; System.Text.StringBuilder.set_Length(Int32)
       mov       rdx,offset MT_Microsoft.Extensions.ObjectPool.DefaultObjectPool<System.Text.StringBuilder>
       cmp       [rbx],rdx
       jne       near ptr M05_L148
       mov       rax,[rbx+10]
       mov       rdx,[rbp-58]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       test      eax,eax
       je        near ptr M05_L149
       cmp       qword ptr [rbx+20],0
       jne       short M05_L146
       lea       rcx,[rbx+20]
       test      rcx,rcx
       jne       short M05_L145
       call      qword ptr [7FFBEC204F30]
       int       3
M05_L145:
       mov       rdx,[rbp-58]
       xor       r8d,r8d
       call      00007FFC4B793270
       test      rax,rax
       je        short M05_L149
M05_L146:
       lea       rcx,[rbx+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[rbx+28]
       jg        short M05_L147
       mov       rbx,[rbx+18]
       mov       rcx,[rbx+10]
       mov       rdx,[rbp-58]
       cmp       [rcx],ecx
       call      qword ptr [7FFBEC16D680]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryEnqueue(System.__Canon)
       test      eax,eax
       jne       short M05_L149
       mov       rcx,rbx
       mov       rdx,[rbp-58]
       call      qword ptr [7FFBEC2052D8]
       jmp       short M05_L149
M05_L147:
       add       rbx,2C
       lock dec  dword ptr [rbx]
       jmp       short M05_L149
M05_L148:
       mov       rcx,rbx
       mov       rdx,[rbp-58]
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
M05_L149:
       nop
       add       rsp,28
       ret
M05_L150:
       sub       rsp,28
       mov       rcx,1E6AC401DC8
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0
       je        short M05_L151
       call      qword ptr [7FFBEBDFFF48]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rbx,rax
       jmp       short M05_L152
M05_L151:
       mov       rbx,[rcx+18]
M05_L152:
       mov       rdx,[rbp-68]
       cmp       [rdx],dl
       mov       rcx,rdx
       xor       edx,edx
       call      qword ptr [7FFBEC164BE8]; System.Text.StringBuilder.set_Length(Int32)
       mov       rdx,offset MT_Microsoft.Extensions.ObjectPool.DefaultObjectPool<System.Text.StringBuilder>
       cmp       [rbx],rdx
       jne       near ptr M05_L156
       mov       rax,[rbx+10]
       mov       rdx,[rbp-68]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       test      eax,eax
       je        near ptr M05_L157
       cmp       qword ptr [rbx+20],0
       jne       short M05_L154
       lea       rcx,[rbx+20]
       test      rcx,rcx
       jne       short M05_L153
       call      qword ptr [7FFBEC204F30]
       int       3
M05_L153:
       mov       rdx,[rbp-68]
       xor       r8d,r8d
       call      00007FFC4B793270
       test      rax,rax
       je        short M05_L157
M05_L154:
       lea       rcx,[rbx+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[rbx+28]
       jg        short M05_L155
       mov       rbx,[rbx+18]
       mov       rcx,[rbx+10]
       mov       rdx,[rbp-68]
       cmp       [rcx],ecx
       call      qword ptr [7FFBEC16D680]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryEnqueue(System.__Canon)
       test      eax,eax
       jne       short M05_L157
       mov       rcx,rbx
       mov       rdx,[rbp-68]
       call      qword ptr [7FFBEC2052D8]
       jmp       short M05_L157
M05_L155:
       add       rbx,2C
       lock dec  dword ptr [rbx]
       jmp       short M05_L157
M05_L156:
       mov       rcx,rbx
       mov       rdx,[rbp-68]
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
M05_L157:
       nop
       add       rsp,28
       ret
M05_L158:
       sub       rsp,28
       mov       rcx,1E6AC401DC8
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0
       je        short M05_L159
       call      qword ptr [7FFBEBDFFF48]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rbx,rax
       jmp       short M05_L160
M05_L159:
       mov       rbx,[rcx+18]
M05_L160:
       mov       rsi,[rbp-38]
       cmp       dword ptr [rsi+20],0
       jge       short M05_L161
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,3AD
       mov       rdx,7FFBEBAA4000
       call      qword ptr [7FFBEBB6F228]
       mov       rbx,rax
       call      qword ptr [7FFBEC2050B0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFBEBDFD8F0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M05_L161:
       cmp       qword ptr [rsi+10],0
       jne       short M05_L162
       xor       ecx,ecx
       mov       [rsi+18],rcx
       jmp       near ptr M05_L169
M05_L162:
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       mov       r8d,ecx
       neg       r8d
       test      r8d,r8d
       jle       short M05_L163
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFBEC205218]
       jmp       near ptr M05_L169
M05_L163:
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFBEC205230]
       mov       rdi,rax
       cmp       rdi,rsi
       je        near ptr M05_L168
       mov       rax,[rsi+8]
       mov       ecx,[rax+8]
       add       ecx,[rsi+1C]
       mov       eax,[rsi+1C]
       add       eax,[rsi+18]
       lea       edx,[rax+rax*2]
       add       edx,edx
       mov       r8d,66666667
       mov       eax,r8d
       imul      edx
       mov       eax,edx
       shr       eax,1F
       sar       edx,1
       add       edx,eax
       mov       rax,[rsi+8]
       mov       eax,[rax+8]
       cmp       edx,eax
       cmovl     edx,eax
       cmp       ecx,edx
       cmovg     ecx,edx
       sub       ecx,[rdi+1C]
       mov       rdx,[rdi+8]
       cmp       [rdx+8],ecx
       jge       short M05_L166
       cmp       ecx,400
       jge       short M05_L164
       movsxd    rdx,ecx
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
       jmp       short M05_L165
M05_L164:
       xor       edx,edx
       call      qword ptr [7FFBEC0FEC70]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       r14,rax
M05_L165:
       mov       rcx,[rdi+8]
       mov       r8d,[rdi+18]
       mov       rdx,r14
       call      qword ptr [7FFBEBB6F5A0]; System.Array.Copy(System.Array, System.Array, Int32)
       lea       rcx,[rsi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M05_L167
M05_L166:
       mov       rdx,[rdi+8]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
M05_L167:
       mov       rdx,[rdi+10]
       lea       rcx,[rsi+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rdi+1C]
       mov       [rsi+1C],ecx
M05_L168:
       mov       ecx,[rdi+1C]
       neg       ecx
       mov       [rsi+18],ecx
M05_L169:
       mov       rdx,offset MT_Microsoft.Extensions.ObjectPool.DefaultObjectPool<System.Text.StringBuilder>
       cmp       [rbx],rdx
       jne       short M05_L173
       mov       rax,[rbx+10]
       mov       rdx,rsi
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       test      eax,eax
       je        short M05_L174
       cmp       qword ptr [rbx+20],0
       jne       short M05_L171
       lea       rcx,[rbx+20]
       test      rcx,rcx
       jne       short M05_L170
       call      qword ptr [7FFBEC204F30]
       int       3
M05_L170:
       mov       rdx,rsi
       xor       r8d,r8d
       call      00007FFC4B793270
       test      rax,rax
       je        short M05_L174
M05_L171:
       lea       rcx,[rbx+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[rbx+28]
       jg        short M05_L172
       mov       rbx,[rbx+18]
       mov       rcx,[rbx+10]
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFBEC16D680]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryEnqueue(System.__Canon)
       test      eax,eax
       jne       short M05_L174
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFBEC2052D8]
       jmp       short M05_L174
M05_L172:
       add       rbx,2C
       lock dec  dword ptr [rbx]
       jmp       short M05_L174
M05_L173:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
M05_L174:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       mov       rcx,1E6AC401DC8
       mov       rcx,[rcx]
       cmp       [rcx],ecx
       call      qword ptr [7FFBEBDFFEE8]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].get_Value()
       mov       rdi,rax
       mov       rcx,[rbp-48]
       cmp       [rcx],cl
       xor       edx,edx
       call      qword ptr [7FFBEC164BE8]; System.Text.StringBuilder.set_Length(Int32)
       mov       rcx,rdi
       mov       rdx,[rbp-48]
       mov       rax,[rdi]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       add       rsp,28
       ret
; Total bytes of code 7491
```
```assembly
; DotNetTips.Spargine.Extensions.Properties.Resources.get_Thousand()
;                 return ResourceManager.GetString("Thousand", resourceCulture);
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,28
       call      qword ptr [7FFBEC16D578]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,1E6C2400170
       mov       r8,[r8]
       mov       rdx,227414A0DC8
       mov       rax,[rax]
       mov       rax,[rax+48]
       add       rsp,28
       jmp       qword ptr [rax+28]
; Total bytes of code 51
```
```assembly
; DotNetTips.Spargine.Extensions.Properties.Resources.get_Hundred()
;                 return ResourceManager.GetString("Hundred", resourceCulture);
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,28
       call      qword ptr [7FFBEC16D578]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,1E6C2400170
       mov       r8,[r8]
       mov       rdx,227414A0DF0
       mov       rax,[rax]
       mov       rax,[rax+48]
       add       rsp,28
       jmp       qword ptr [rax+28]
; Total bytes of code 51
```
```assembly
; DotNetTips.Spargine.Extensions.Properties.Resources.get_AndLowerCase()
;                 return ResourceManager.GetString("AndLowerCase", resourceCulture);
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,28
       call      qword ptr [7FFBEC16D578]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,1E6C2400170
       mov       r8,[r8]
       mov       rdx,227414A0E18
       mov       rax,[rax]
       mov       rax,[rax+48]
       add       rsp,28
       jmp       qword ptr [rax+28]
; Total bytes of code 51
```
```assembly
; System.Text.StringBuilder.Append(System.String)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       test      rdx,rdx
       je        short M09_L01
       lea       rax,[rdx+0C]
       mov       r8d,[rdx+8]
       test      r8d,r8d
       je        short M09_L01
       mov       rcx,[rbx+8]
       mov       edx,[rbx+18]
       lea       esi,[rdx+r8]
       cmp       esi,[rcx+8]
       ja        short M09_L03
       movsxd    rdx,edx
       lea       rcx,[rcx+rdx*2+10]
       cmp       r8d,2
       jle       short M09_L02
       mov       r8d,r8d
       add       r8,r8
       mov       rdx,rax
       call      qword ptr [7FFBEBB65818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M09_L00:
       mov       [rbx+18],esi
M09_L01:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M09_L02:
       movzx     edx,word ptr [rax]
       mov       [rcx],dx
       cmp       r8d,2
       jne       short M09_L00
       movzx     eax,word ptr [rax+2]
       mov       [rcx+2],ax
       jmp       short M09_L00
M09_L03:
       mov       rcx,rbx
       mov       rdx,rax
       call      qword ptr [7FFBEBDF71E0]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M09_L01
; Total bytes of code 121
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
       jbe       short M10_L01
       mov       [r8+rax*2+10],dx
       inc       ecx
       mov       [rbx+18],ecx
M10_L00:
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       ret
M10_L01:
       movzx     edx,dx
       mov       rcx,rbx
       call      qword ptr [7FFBEBDF73A8]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M10_L00
; Total bytes of code 60
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
       jg        near ptr M11_L05
       cmp       eax,esi
       jl        near ptr M11_L05
       mov       rax,[rbx+8]
       mov       ebp,[rax+8]
       sub       ebp,ecx
       test      ebp,ebp
       jg        near ptr M11_L03
M11_L00:
       sub       esi,ebp
       mov       edx,[rbx+1C]
       lea       ecx,[rsi+rdx]
       mov       eax,[rbx+18]
       add       ecx,eax
       cmp       ecx,[rbx+20]
       jg        near ptr M11_L08
       cmp       ecx,esi
       jl        near ptr M11_L08
       add       edx,eax
       mov       ecx,edx
       mov       eax,1F40
       cmp       ecx,1F40
       cmovg     ecx,eax
       cmp       esi,ecx
       cmovge    ecx,esi
       add       edx,ecx
       cmp       edx,ecx
       jl        near ptr M11_L09
       cmp       ecx,400
       jge       near ptr M11_L10
       movsxd    rdx,ecx
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
M11_L01:
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
       je        near ptr M11_L11
       lea       rcx,[r8+10]
       mov       r8d,[r8+8]
M11_L02:
       cmp       esi,r8d
       ja        near ptr M11_L12
       mov       r8d,esi
       add       r8,r8
       call      qword ptr [7FFBEBB65818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       [rbx+18],esi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M11_L03:
       mov       rax,[rbx+8]
       test      rax,rax
       je        near ptr M11_L06
       mov       edx,[rax+8]
       cmp       edx,ecx
       jb        near ptr M11_L07
       mov       r8d,ecx
       lea       rax,[rax+r8*2+10]
       sub       edx,ecx
M11_L04:
       cmp       ebp,edx
       ja        near ptr M11_L12
       mov       r8d,ebp
       add       r8,r8
       mov       rcx,rax
       mov       rdx,rdi
       call      qword ptr [7FFBEBB65818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rdx,[rbx+8]
       mov       edx,[rdx+8]
       mov       [rbx+18],edx
       jmp       near ptr M11_L00
M11_L05:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,19685
       mov       rdx,7FFBEBAA4000
       call      qword ptr [7FFBEBB6F228]
       mov       rsi,rax
       call      qword ptr [7FFBEC205068]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFBEBDFD8F0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M11_L06:
       test      ecx,ecx
       jne       short M11_L07
       xor       eax,eax
       xor       edx,edx
       jmp       short M11_L04
M11_L07:
       call      qword ptr [7FFBEBD3F228]
       int       3
M11_L08:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,1969B
       mov       rdx,7FFBEBAA4000
       call      qword ptr [7FFBEBB6F228]
       mov       rsi,rax
       call      qword ptr [7FFBEC2050B0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFBEBDFD8F0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M11_L09:
       mov       rcx,offset MT_System.OutOfMemoryException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBEC2050C8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M11_L10:
       xor       edx,edx
       call      qword ptr [7FFBEC0FEC70]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       r14,rax
       jmp       near ptr M11_L01
M11_L11:
       xor       ecx,ecx
       xor       r8d,r8d
       jmp       near ptr M11_L02
M11_L12:
       call      qword ptr [7FFBEBF7D188]
       int       3
; Total bytes of code 631
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
       call      qword ptr [7FFC4A2FE7B0]; Precode of System.Text.StringBuilder.ExpandByABlock(Int32)
       mov       rax,[rbx+8]
       cmp       dword ptr [rax+8],0
       jbe       short M12_L00
       mov       [rax+10],si
       inc       dword ptr [rbx+18]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M12_L00:
       call      qword ptr [7FFC4A2E3FD8]
       int       3
; Total bytes of code 56
```
```assembly
; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].get_Value()
       cmp       qword ptr [rcx+8],0
       jne       short M13_L00
       mov       rax,[rcx+18]
       ret
M13_L00:
       jmp       qword ptr [7FFBEBDFFF48]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
; Total bytes of code 18
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
       jl        short M14_L01
       cmp       esi,[rbx+20]
       jg        short M14_L02
       test      esi,esi
       jne       near ptr M14_L03
       cmp       qword ptr [rbx+10],0
       jne       short M14_L03
       xor       ecx,ecx
       mov       [rbx+18],rcx
M14_L00:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M14_L01:
       mov       ecx,3AD
       mov       rdx,7FFBEBAA4000
       call      qword ptr [7FFBEBB6F228]
       mov       rdx,rax
       mov       ecx,esi
       call      qword ptr [7FFBEC204258]
       int       3
M14_L02:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FFBEBAA4000
       call      qword ptr [7FFBEBB6F228]
       mov       rsi,rax
       call      qword ptr [7FFBEC2050B0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFBEBDFD8F0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M14_L03:
       mov       ecx,[rbx+1C]
       add       ecx,[rbx+18]
       mov       r8d,esi
       sub       r8d,ecx
       test      r8d,r8d
       jle       short M14_L04
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFBEC205218]
       jmp       near ptr M14_L00
M14_L04:
       mov       rcx,rbx
       mov       edx,esi
       call      qword ptr [7FFBEC205230]
       mov       rdi,rax
       cmp       rdi,rbx
       je        near ptr M14_L09
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
       jge       short M14_L07
       cmp       ecx,400
       jge       short M14_L05
       movsxd    rdx,ecx
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbp,rax
       jmp       short M14_L06
M14_L05:
       xor       edx,edx
       call      qword ptr [7FFBEC0FEC70]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       rbp,rax
M14_L06:
       mov       rcx,[rdi+8]
       mov       r8d,[rdi+18]
       mov       rdx,rbp
       call      qword ptr [7FFBEBB6F5A0]; System.Array.Copy(System.Array, System.Array, Int32)
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M14_L08
M14_L07:
       mov       rdx,[rdi+8]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
M14_L08:
       mov       rdx,[rdi+10]
       lea       rcx,[rbx+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rdi+1C]
       mov       [rbx+1C],ecx
M14_L09:
       sub       esi,[rdi+1C]
       mov       [rbx+18],esi
       jmp       near ptr M14_L00
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
       jne       near ptr M15_L12
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       add       ecx,[rbx+1C]
       mov       rdx,[rdi+8]
       cmp       ecx,[rdx+0C]
       jg        near ptr M15_L13
       cmp       dword ptr [rbx+20],0
       jl        near ptr M15_L04
       cmp       qword ptr [rbx+10],0
       jne       near ptr M15_L05
       xor       ecx,ecx
       mov       [rbx+18],rcx
M15_L00:
       cmp       qword ptr [rsi+20],0
       je        near ptr M15_L14
M15_L01:
       lea       rax,[rsi+2C]
       mov       ecx,1
       lock xadd [rax],ecx
       inc       ecx
       cmp       ecx,[rsi+28]
       jg        near ptr M15_L17
       mov       rcx,[rsi+18]
       mov       rdx,[rcx+10]
       mov       r8,[rdx+8]
M15_L02:
       mov       eax,[rdx+0A0]
       mov       [rsp+24],eax
       mov       r10d,eax
       and       r10d,[rdx+18]
       cmp       r10d,[r8+8]
       jae       near ptr M15_L18
       shl       r10,4
       lea       rsi,[r8+r10+10]
       mov       r10d,[rsi+8]
       sub       r10d,eax
       jne       near ptr M15_L16
       lea       r10,[rdx+0A0]
       lea       edi,[rax+1]
       lock cmpxchg [r10],edi
       cmp       eax,[rsp+24]
       jne       short M15_L02
       mov       rcx,rsi
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rsi+8],edi
M15_L03:
       mov       eax,1
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M15_L04:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FFBEBAA4000
       call      qword ptr [7FFBEBB6F228]
       mov       rsi,rax
       call      qword ptr [7FFBEC2050B0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFBEBDFD8F0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M15_L05:
       mov       ecx,[rbx+1C]
       add       ecx,[rbx+18]
       mov       r8d,ecx
       neg       r8d
       test      r8d,r8d
       jle       short M15_L06
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFBEC205218]
       jmp       near ptr M15_L00
M15_L06:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFBEC205230]
       mov       rdi,rax
       cmp       rdi,rbx
       je        near ptr M15_L11
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
       jge       short M15_L09
       cmp       ecx,400
       jge       short M15_L07
       movsxd    rdx,ecx
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbp,rax
       jmp       short M15_L08
M15_L07:
       xor       edx,edx
       call      qword ptr [7FFBEC0FEC70]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       rbp,rax
M15_L08:
       mov       rcx,[rdi+8]
       mov       r8d,[rdi+18]
       mov       rdx,rbp
       call      qword ptr [7FFBEBB6F5A0]; System.Array.Copy(System.Array, System.Array, Int32)
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M15_L10
M15_L09:
       mov       rdx,[rdi+8]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
M15_L10:
       mov       rdx,[rdi+10]
       lea       rcx,[rbx+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rdi+1C]
       mov       [rbx+1C],ecx
M15_L11:
       mov       ecx,[rdi+1C]
       neg       ecx
       mov       [rbx+18],ecx
       jmp       near ptr M15_L00
M15_L12:
       mov       rdx,rbx
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       test      eax,eax
       jne       near ptr M15_L00
M15_L13:
       xor       eax,eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M15_L14:
       lea       rcx,[rsi+20]
       test      rcx,rcx
       jne       short M15_L15
       call      qword ptr [7FFBEC204F30]
       int       3
M15_L15:
       mov       rdx,rbx
       xor       r8d,r8d
       call      00007FFC4B793270
       test      rax,rax
       je        near ptr M15_L03
       jmp       near ptr M15_L01
M15_L16:
       test      r10d,r10d
       jge       near ptr M15_L02
       mov       rdx,rbx
       call      qword ptr [7FFBEC2052D8]
       jmp       near ptr M15_L03
M15_L17:
       add       rsi,2C
       lock dec  dword ptr [rsi]
       jmp       short M15_L13
M15_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 657
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
; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,[rbx+8]
       xor       eax,eax
       mov       [rsp+28],eax
M17_L00:
       mov       ebp,[rbx+60]
       mov       eax,ebp
       and       eax,[rbx+18]
       mov       r14d,[rdi+8]
       cmp       eax,r14d
       jae       near ptr M17_L05
       mov       r15d,eax
       shl       r15,4
       lea       r13,[rdi+r15+10]
       mov       ecx,[r13+8]
       lea       edx,[rbp+1]
       sub       ecx,edx
       jne       short M17_L02
       lea       rcx,[rbx+60]
       mov       eax,ebp
       lock cmpxchg [rcx],edx
       cmp       eax,ebp
       jne       short M17_L00
       mov       rdx,[rdi+r15+10]
       mov       rcx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       cmp       byte ptr [rbx+1C],0
       jne       short M17_L01
       xor       eax,eax
       mov       [rdi+r15+10],rax
       add       ebp,r14d
       mov       [r13+8],ebp
M17_L01:
       mov       eax,1
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M17_L02:
       test      ecx,ecx
       jge       short M17_L00
       movzx     ecx,byte ptr [rbx+1D]
       mov       edx,[rbx+0A0]
       mov       eax,edx
       sub       eax,ebp
       test      eax,eax
       jle       short M17_L04
       test      ecx,ecx
       je        short M17_L03
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       add       ecx,ecx
       sub       edx,ecx
       sub       edx,ebp
       test      edx,edx
       jle       short M17_L04
M17_L03:
       lea       rcx,[rsp+28]
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFBEC205350]
       jmp       near ptr M17_L00
M17_L04:
       xor       eax,eax
       mov       [rsi],rax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M17_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 231
```
```assembly
; DotNetTips.Spargine.Extensions.Properties.Resources.get_Zero()
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
;                 return ResourceManager.GetString("Zero", resourceCulture);
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       call      qword ptr [7FFBEC16D578]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       mov       rax,1E6C2400170
       mov       r8,[rax]
       mov       rdx,227414A09D8
       mov       rax,[rbp-8]
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 74
```
```assembly
; System.String.FastAllocateString(IntPtr)
       mov       rdx,rcx
       mov       rcx,offset MT_System.String
       jmp       near ptr 00007FFC4B7F9D30
; Total bytes of code 18
```
```assembly
; System.String.Concat(System.String, System.String, System.String)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       test      rbx,rbx
       je        near ptr M20_L02
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        near ptr M20_L02
       test      rsi,rsi
       je        near ptr M20_L01
       mov       r14d,[rsi+8]
       test      r14d,r14d
       je        near ptr M20_L01
       test      rdi,rdi
       je        near ptr M20_L00
       mov       r15d,[rdi+8]
       test      r15d,r15d
       je        near ptr M20_L00
       mov       r13d,ebp
       mov       ecx,r14d
       add       rcx,r13
       mov       eax,r15d
       add       rcx,rax
       cmp       rcx,7FFFFFFF
       jg        near ptr M20_L03
       movsxd    rcx,ecx
       call      qword ptr [7FFC4A2F69D8]; Precode of System.String.FastAllocateString(IntPtr)
       mov       r12,rax
       cmp       [r12],r12b
       lea       rax,[r12+0C]
       mov       [rsp+20],rax
       mov       rcx,rax
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFC4A2F88E8]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rbx,[rsp+20]
       lea       rcx,[rbx+r13*2]
       mov       r8d,r14d
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFC4A2F88E8]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       ebp,r14d
       movsxd    rcx,ebp
       lea       rcx,[rbx+rcx*2]
       mov       r8d,r15d
       add       r8,r8
       lea       rdx,[rdi+0C]
       call      qword ptr [7FFC4A2F88E8]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
M20_L00:
       mov       rdx,rsi
       mov       rcx,rbx
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
M20_L01:
       mov       rdx,rdi
       mov       rcx,rbx
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
M20_L02:
       mov       rdx,rdi
       mov       rcx,rsi
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
M20_L03:
       call      qword ptr [7FFC4A2FA448]
       int       3
; Total bytes of code 336
```
```assembly
; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
M21_L00:
       mov       rsi,[rbx+8]
       test      rsi,rsi
       je        short M21_L01
       mov       ecx,[rsi+10]
       cmp       ecx,8
       jne       short M21_L03
       mov       rcx,rbx
       mov       rdx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFC4A3091B0]; Precode of System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ExecutionAndPublication(System.LazyHelper, Boolean)
M21_L01:
       cmp       qword ptr [rbx+8],0
       jne       short M21_L02
       mov       rax,[rbx+18]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M21_L02:
       mov       rcx,rbx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [rax]
M21_L03:
       cmp       ecx,8
       ja        short M21_L04
       mov       ecx,ecx
       lea       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       edx,[rdx+rcx*4]
       lea       r8,[M21_L00]
       add       rdx,r8
       jmp       rdx
M21_L04:
       mov       rcx,[rsi+8]
       cmp       [rcx],ecx
       call      qword ptr [7FFC4A2FFC50]
       int       3
       mov       rcx,rbx
       call      qword ptr [7FFC4A3091A0]
       jmp       short M21_L01
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFC4A3091A8]; Precode of System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ViaFactory(System.Threading.LazyThreadSafetyMode)
       jmp       short M21_L01
       mov       rcx,[rbx]
       call      qword ptr [7FFC4A2E6838]
       mov       rcx,rax
       call      qword ptr [7FFC4A2EDE88]
       mov       rcx,rax
       call      qword ptr [7FFC4A30EFF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFC4A3091B8]
       jmp       near ptr M21_L01
       mov       rax,[rbx+10]
       test      rax,rax
       je        short M21_L05
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFC4A3091B8]
       jmp       near ptr M21_L01
M21_L05:
       mov       rcx,rbx
       call      qword ptr [7FFC4A3091C8]
       jmp       near ptr M21_L01
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,1
       call      qword ptr [7FFC4A3091B0]; Precode of System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ExecutionAndPublication(System.LazyHelper, Boolean)
       jmp       near ptr M21_L01
; Total bytes of code 269
```

