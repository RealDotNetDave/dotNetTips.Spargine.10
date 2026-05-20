## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.NumericExtensionsBenchmark.FormatTimeDoubleHours()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       vmovsd    xmm0,qword ptr [rbx+138]
       call      qword ptr [7FFC68C5D6B0]; DotNetTips.Spargine.Extensions.NumericExtensions.FormatTime(Double)
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
       vmovsd    xmm1,qword ptr [7FFC68D32360]
       vucomisd  xmm1,xmm0
       ja        near ptr M01_L55
       vucomisd  xmm0,xmm0
       jp        near ptr M01_L59
       jne       near ptr M01_L59
       vmulsd    xmm0,xmm0,qword ptr [7FFC68D32368]
       call      qword ptr [7FFC689BCD98]; System.TimeSpan.IntervalFromDoubleTicks(Double)
       mov       rbx,rax
       mov       rcx,18810C01DE8
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
       call      00007FFCC8253270
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
       mov       r9,7FFCC741B880
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
       mov       rsi,1C8A5CB1234
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
       mov       rsi,1C8A5CB1234
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
       mov       r8,1C8A5CC0760
       mov       rcx,1C8A5CC0738
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
       call      qword ptr [7FFC68635818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       r9,7FFCC741B880
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
       mov       r8,1C8A5CB1234
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
       mov       r8,1C8A5CB1234
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
       mov       r8,1C8A5CC07A8
       mov       rcx,1C8A5CC0780
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
       call      qword ptr [7FFC68635818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFCC741B880
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
       mov       r8,1C8A5CB1234
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
       mov       r8,1C8A5CB1234
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
       mov       r8,1C8A5CC07F8
       mov       rcx,1C8A5CC07D0
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
       call      qword ptr [7FFC68635818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L34:
       add       ebx,r14d
       mov       [rdi+18],ebx
M01_L35:
       mov       rcx,rsi
       call      qword ptr [7FFC68822100]; System.Text.StringBuilder.ToString()
       mov       [rbp-0C0],rax
       jmp       near ptr M01_L54
M01_L36:
       mov       rsi,[rbp-0B8]
       call      qword ptr [7FFC687AF210]; System.Number.Int32ToDecStr(Int32)
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFC687AF228]; System.Text.StringBuilder.Append(System.String)
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
       call      qword ptr [7FFC687AF1E0]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M01_L12
M01_L39:
       mov       rcx,rsi
       mov       edx,20
       call      qword ptr [7FFC687AF3A8]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M01_L13
M01_L40:
       call      qword ptr [7FFC687AF210]; System.Number.Int32ToDecStr(Int32)
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFC687AF228]; System.Text.StringBuilder.Append(System.String)
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
       call      qword ptr [7FFC687AF1E0]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       call      qword ptr [7FFC687AF3A8]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M01_L24
M01_L45:
       or        r8d,edi
       jne       short M01_L46
       xor       r14d,r14d
       xor       edi,edi
       jmp       near ptr M01_L25
M01_L46:
       mov       rsi,[rbp-0B8]
       call      qword ptr [7FFC687A7198]
       int       3
M01_L47:
       call      qword ptr [7FFC68855DD0]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
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
       call      qword ptr [7FFC68CE4F30]
       mov       ecx,eax
       jmp       near ptr M01_L32
M01_L50:
       mov       ecx,[rbp-7C]
       call      qword ptr [7FFC687AF210]; System.Number.Int32ToDecStr(Int32)
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFC687AF228]; System.Text.StringBuilder.Append(System.String)
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
       call      qword ptr [7FFC687AF1E0]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       vroundsd  xmm0,xmm0,xmm0,4
       call      qword ptr [7FFC68635938]
       mov       ebx,eax
       lea       rcx,[rbp-50]
       mov       edx,0C
       mov       r8d,2
       call      qword ptr [7FFC68854E70]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler..ctor(Int32, Int32)
       lea       rcx,[rbp-50]
       mov       edx,ebx
       call      qword ptr [7FFC68854DB0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Int32, System.Private.CoreLib]](Int32)
       mov       ecx,[rbp-40]
       cmp       ecx,[rbp-30]
       jbe       short M01_L56
       call      qword ptr [7FFC687A7198]
       int       3
M01_L56:
       mov       rdx,[rbp-38]
       mov       eax,ecx
       lea       rdx,[rdx+rax*2]
       mov       eax,[rbp-30]
       sub       eax,ecx
       cmp       eax,0C
       jb        short M01_L57
       vmovups   xmm0,[7FFC68D32370]
       vmovups   [rdx],xmm0
       mov       rcx,64006E006F0063
       mov       [rdx+10],rcx
       mov       ecx,[rbp-40]
       add       ecx,0C
       mov       [rbp-40],ecx
       jmp       short M01_L58
M01_L57:
       lea       rcx,[rbp-50]
       mov       rdx,1C8A5CC0708
       call      qword ptr [7FFC68C56FE8]
M01_L58:
       mov       rdx,1C8A5CB0008
       mov       rcx,1C8A5CBB4B8
       cmp       ebx,1
       cmovne    rdx,rcx
       lea       rcx,[rbp-50]
       call      qword ptr [7FFC6885E2B0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted(System.String)
       lea       rcx,[rbp-50]
       call      qword ptr [7FFC68854EA0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
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
       call      qword ptr [7FFC68CE5518]
       int       3
M01_L60:
       call      qword ptr [7FFC6885FF48]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rsi,rax
       jmp       near ptr M01_L00
M01_L61:
       call      qword ptr [7FFC68CE4ED0]
       int       3
M01_L62:
       mov       rcx,[rsi+18]
       lea       rdx,[rbp-58]
       cmp       [rcx],ecx
       call      qword ptr [7FFC68C55338]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
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
       mov       rcx,18810C01DE8
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0
       je        short M01_L66
       call      qword ptr [7FFC6885FF48]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
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
       mov       rdx,7FFC68574000
       call      qword ptr [7FFC688577B0]
       mov       rbx,rax
       call      qword ptr [7FFC68CE5380]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFC6885D8F0]
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
       call      qword ptr [7FFC68CE54E8]
       jmp       near ptr M01_L76
M01_L70:
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFC68CE5500]
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
       call      qword ptr [7FFC68BBEC10]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       r14,rax
M01_L72:
       mov       rcx,[rdi+8]
       mov       r8d,[rdi+18]
       mov       rdx,r14
       call      qword ptr [7FFC687A5050]; System.Array.Copy(System.Array, System.Array, Int32)
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
       call      qword ptr [7FFC68CE4ED0]
       int       3
M01_L77:
       mov       rdx,rsi
       xor       r8d,r8d
       call      00007FFCC8253270
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
       call      qword ptr [7FFC68CE55C0]
       test      eax,eax
       jne       short M01_L81
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFC68CE55D8]
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
; Total bytes of code 3026
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
       call      qword ptr [7FFC68C45A10]; DotNetTips.Spargine.Extensions.NumericExtensions.FormatTime(Double)
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
       vmovsd    xmm1,qword ptr [7FFC686CE1F0]
       vucomisd  xmm1,xmm0
       jbe       near ptr M01_L67
       vroundsd  xmm0,xmm0,xmm0,4
       call      qword ptr [7FFC68635938]; System.Math.ConvertToInt32Checked(Double)
       mov       ebx,eax
       xor       ecx,ecx
       mov       [rbp-68],rcx
       mov       rcx,2F291C00C88
       mov       rsi,[rcx]
       mov       rdi,rsi
       mov       rcx,2F291C00C90
       mov       r14,[rcx]
       mov       r15,r14
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
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
       mov       rdx,7FFCC741B880
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
       mov       rdx,33326B71234
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
       mov       rdx,33326B71234
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
       vmovups   xmm0,[7FFC686CE200]
       vmovups   [rax],xmm0
       mov       rcx,64006E006F0063
       mov       [rax+10],rcx
       mov       ecx,[rbp-58]
       add       ecx,0C
       mov       [rbp-58],ecx
M01_L10:
       mov       rdi,33326B70008
       mov       r8,33326B7B4B8
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
       call      qword ptr [7FFC68635818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFC6885CEA0]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
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
       call      qword ptr [7FFC68C4E4F0]
       mov       r8,rax
M01_L13:
       mov       r12,[r8+8]
       test      byte ptr [7FFC68C732B8],1
       je        near ptr M01_L58
M01_L14:
       cmp       byte ptr [7FFC6857B174],0
       je        near ptr M01_L59
       call      qword ptr [7FFC68C4E148]
       mov       edx,eax
M01_L15:
       test      byte ptr [7FFC68C73148],1
       je        near ptr M01_L61
M01_L16:
       mov       eax,edx
       xor       edx,edx
       div       dword ptr [7FFC6857B168]
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
       call      00007FFCC82C2B50
       test      eax,eax
       jne       short M01_L18
       mov       rcx,[rbp-118]
       call      qword ptr [7FFC68C4E190]
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
       call      00007FFCC82C2A70
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
       call      qword ptr [7FFC68A4D260]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rbp-0A4],eax
       mov       edx,[rdi+8]
       mov       [rbp-0A8],edx
       mov       rcx,rsi
       call      00007FFCC8249590
       test      eax,eax
       je        near ptr M01_L28
M01_L23:
       mov       [rsp+20],eax
       mov       rcx,r14
       mov       r8d,[rbp-0A4]
       mov       r9d,[rbp-0A8]
       mov       edx,3
       call      qword ptr [7FFC68C4E508]
       test      r12d,r13d
       jne       near ptr M01_L31
       mov       rcx,rdi
       call      qword ptr [7FFC68A4D260]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r12d,eax
       mov       edi,[rdi+8]
       mov       rcx,rsi
       call      00007FFCC8249590
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
       mov       rdx,33326B80708
       call      qword ptr [7FFC68BBF360]
       jmp       near ptr M01_L10
M01_L26:
       lea       rcx,[rbp-68]
       mov       rdx,rdi
       call      qword ptr [7FFC68C4E460]
       jmp       near ptr M01_L11
M01_L27:
       xor       edx,edx
       mov       [rax+14],edx
       jmp       near ptr M01_L19
M01_L28:
       mov       rcx,rsi
       call      qword ptr [7FFC6863EEB0]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       jmp       near ptr M01_L23
M01_L29:
       xor       ecx,ecx
M01_L30:
       mov       [rsp+20],r15d
       mov       [rsp+28],ecx
       mov       rcx,r14
       mov       edx,r12d
       mov       r8d,edi
       call      qword ptr [7FFC68C4E520]
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
       call      qword ptr [7FFC68C4E118]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       r13,rax
       jmp       near ptr M01_L00
M01_L33:
       mov       rcx,r12
       call      qword ptr [7FFC68A4D260]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rbp-78],eax
       mov       edx,[r12+8]
       mov       [rbp-7C],edx
       mov       rcx,rdi
       call      qword ptr [7FFC68A4D260]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       dword ptr [rsp+20],4
       mov       edx,[rbp-78]
       mov       r8d,[rbp-7C]
       mov       rcx,r15
       call      qword ptr [7FFC68C4E130]
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
       call      qword ptr [7FFC68635740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       cmp       byte ptr [7FFC6857B174],0
       je        short M01_L35
       call      qword ptr [7FFC68C4E148]
       mov       edx,eax
       mov       [rbp-88],edx
       jmp       short M01_L37
M01_L35:
       mov       ecx,9
       call      qword ptr [7FFC68C4E160]
       mov       eax,[rax+10]
       mov       [rbp-8C],eax
       mov       ecx,9
       call      qword ptr [7FFC68C4E160]
       mov       edx,[rbp-8C]
       lea       ecx,[rdx-1]
       mov       [rax+10],ecx
       movzx     eax,dx
       test      eax,eax
       jne       short M01_L36
       call      qword ptr [7FFC68C4E178]
       mov       edx,eax
       mov       [rbp-88],edx
       jmp       short M01_L37
M01_L36:
       sar       edx,10
       mov       [rbp-88],edx
M01_L37:
       mov       rcx,offset MT_System.Buffers.SharedArrayPoolStatics
       call      qword ptr [7FFC68635740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       eax,[rbp-88]
       xor       edx,edx
       div       dword ptr [7FFC6857B168]
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
       call      qword ptr [7FFC68B4DE18]; System.Threading.Monitor.Enter(System.Object)
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
       call      qword ptr [7FFC68636820]; System.Threading.Monitor.Exit(System.Object)
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
       call      qword ptr [7FFC68A4D260]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rbp-70],eax
       mov       edx,[r12+8]
       mov       [rbp-74],edx
       mov       rcx,rdi
       call      qword ptr [7FFC68A4D260]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       dword ptr [rsp+20],4
       mov       edx,[rbp-70]
       mov       r8d,[rbp-74]
       mov       rcx,r15
       call      qword ptr [7FFC68C4E130]
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
       mov       rdx,33326B76F28
       call      qword ptr [7FFC6885D8C0]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
       jmp       short M01_L45
M01_L47:
       mov       rcx,r12
       call      qword ptr [7FFC68A4D260]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rbp-6C],eax
       mov       rcx,rdi
       call      qword ptr [7FFC68A4D260]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       edx,[rbp-6C]
       mov       r8d,100
       mov       rcx,r15
       call      qword ptr [7FFC68C4E130]
       mov       rcx,rdi
       call      qword ptr [7FFC68A4D260]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
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
       call      qword ptr [7FFC68C4E1A8]
       jmp       near ptr M01_L01
M01_L48:
       lea       rcx,[rbp-68]
       mov       edx,ebx
       xor       r8d,r8d
       call      qword ptr [7FFC68C4E1C0]
       jmp       near ptr M01_L09
M01_L49:
       lea       rcx,[rbp-68]
       call      qword ptr [7FFC68C4E1F0]
       jmp       near ptr M01_L02
M01_L50:
       test      rcx,rcx
       je        short M01_L51
       call      qword ptr [7FFC68BB5140]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider)
       jmp       short M01_L52
M01_L51:
       call      qword ptr [7FFC68855DD0]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
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
       call      qword ptr [7FFC68C4E970]
       mov       r15d,eax
       jmp       near ptr M01_L08
M01_L55:
       xor       eax,eax
       mov       [rbp-98],eax
       xor       r15d,r15d
       jmp       near ptr M01_L07
M01_L56:
       call      qword ptr [7FFC687A7198]
       int       3
M01_L57:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFC68C4E4D8]
       mov       rsi,rax
       mov       ecx,29B
       mov       rdx,7FFC68574000
       call      qword ptr [7FFC688577B0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFC689B6130]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L58:
       mov       rcx,offset MT_System.Threading.ProcessorIdCache
       call      qword ptr [7FFC68635740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M01_L14
M01_L59:
       mov       ecx,9
       call      qword ptr [7FFC68C4E160]
       mov       eax,[rax+10]
       mov       [rbp-0B4],eax
       mov       ecx,9
       call      qword ptr [7FFC68C4E160]
       mov       edx,[rbp-0B4]
       lea       ecx,[rdx-1]
       mov       [rax+10],ecx
       movzx     eax,dx
       test      eax,eax
       jne       short M01_L60
       call      qword ptr [7FFC68C4E178]
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
       call      qword ptr [7FFC68635740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       edx,[rbp-0B0]
       jmp       near ptr M01_L16
M01_L62:
       mov       ecx,eax
       mov       rdx,[rbp-118]
       call      qword ptr [7FFC68C4DD40]
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
       call      qword ptr [7FFC6863EEB0]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       mov       r9d,eax
       jmp       near ptr M01_L24
M01_L67:
       vmovsd    xmm1,qword ptr [7FFC686CE210]
       call      qword ptr [7FFC68C4EB20]
       mov       [rbp-40],rax
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.NumericExtensions
       call      qword ptr [7FFC68635728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,2F291C01DC0
       mov       rcx,[rcx]
       cmp       [rcx],ecx
       call      qword ptr [7FFC6885FEE8]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].get_Value()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp-0F0],rax
       lea       rcx,[rbp-40]
       call      qword ptr [7FFC68C45A40]
       test      eax,eax
       jle       short M01_L68
       lea       rcx,[rbp-40]
       call      qword ptr [7FFC68C45A40]
       mov       edx,eax
       mov       rcx,[rbp-0F0]
       cmp       [rcx],cl
       call      qword ptr [7FFC687AF198]; System.Text.StringBuilder.AppendSpanFormattable[[System.Int32, System.Private.CoreLib]](Int32)
       mov       rbx,rax
       lea       rcx,[rbp-40]
       call      qword ptr [7FFC68C45A40]
       mov       rdx,33326B80760
       mov       rcx,33326B80738
       cmp       eax,1
       cmovne    rdx,rcx
       mov       rcx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FFC687AF228]; System.Text.StringBuilder.Append(System.String)
M01_L68:
       lea       rcx,[rbp-40]
       call      qword ptr [7FFC68C45A70]
       test      eax,eax
       jle       short M01_L70
       mov       rcx,[rbp-0F0]
       mov       edx,[rcx+1C]
       add       edx,[rcx+18]
       test      edx,edx
       jle       short M01_L69
       mov       edx,20
       call      qword ptr [7FFC687AF180]; System.Text.StringBuilder.Append(Char)
M01_L69:
       lea       rcx,[rbp-40]
       call      qword ptr [7FFC68C45A70]
       mov       edx,eax
       mov       rcx,[rbp-0F0]
       call      qword ptr [7FFC687AF198]; System.Text.StringBuilder.AppendSpanFormattable[[System.Int32, System.Private.CoreLib]](Int32)
       mov       rbx,rax
       lea       rcx,[rbp-40]
       call      qword ptr [7FFC68C45A70]
       mov       rdx,33326B807A8
       mov       rcx,33326B80780
       cmp       eax,1
       cmovne    rdx,rcx
       mov       rcx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FFC687AF228]; System.Text.StringBuilder.Append(System.String)
M01_L70:
       lea       rcx,[rbp-40]
       call      qword ptr [7FFC68C45AA0]
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
       call      qword ptr [7FFC687AF180]; System.Text.StringBuilder.Append(Char)
M01_L72:
       lea       rcx,[rbp-40]
       call      qword ptr [7FFC68C45AA0]
       mov       edx,eax
       mov       rcx,[rbp-0F0]
       call      qword ptr [7FFC687AF198]; System.Text.StringBuilder.AppendSpanFormattable[[System.Int32, System.Private.CoreLib]](Int32)
       mov       rbx,rax
       lea       rcx,[rbp-40]
       call      qword ptr [7FFC68C45AA0]
       mov       rdx,33326B807F8
       mov       rcx,33326B807D0
       cmp       eax,1
       cmovne    rdx,rcx
       mov       rcx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FFC687AF228]; System.Text.StringBuilder.Append(System.String)
       mov       rcx,[rbp-0F0]
M01_L73:
       call      qword ptr [7FFC68822100]; Precode of System.Text.StringBuilder.ToString()
       mov       rbx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.NumericExtensions
       call      qword ptr [7FFC68635728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,2F291C01DC0
       mov       rcx,[rcx]
       cmp       [rcx],ecx
       call      qword ptr [7FFC6885FEE8]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].get_Value()
       mov       rsi,rax
       mov       rcx,[rbp-0F0]
       xor       edx,edx
       call      qword ptr [7FFC68BBD458]; System.Text.StringBuilder.set_Length(Int32)
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
       test      byte ptr [7FFC68BF70A0],1
       jne       short M01_L75
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.NumericExtensions
       call      qword ptr [7FFC68635728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
M01_L75:
       mov       rcx,2F291C01DC0
       mov       rcx,[rcx]
       cmp       [rcx],ecx
       call      qword ptr [7FFC6885FEE8]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].get_Value()
       mov       rbx,rax
       mov       rcx,[rbp-0F0]
       cmp       [rcx],cl
       xor       edx,edx
       call      qword ptr [7FFC68BBD458]; System.Text.StringBuilder.set_Length(Int32)
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
       call      qword ptr [7FFC68C2CDF8]; DotNetTips.Spargine.Extensions.NumericExtensions.FormatTime(Int64)
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
       mov       rcx,17135801DC0
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
       call      00007FFCC8253270
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
       mov       r9,7FFCC741B880
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
       mov       rsi,1B1CA931234
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
       mov       rsi,1B1CA931234
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
       mov       r8,1B1CA940760
       mov       rcx,1B1CA940738
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
       call      qword ptr [7FFC68615818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       r9,7FFCC741B880
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
       mov       r8,1B1CA931234
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
       mov       r8,1B1CA931234
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
       mov       r8,1B1CA9407A8
       mov       rcx,1B1CA940780
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
       call      qword ptr [7FFC68615818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFCC741B880
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
       mov       r8,1B1CA931234
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
       mov       r8,1B1CA931234
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
       mov       r8,1B1CA9407F8
       mov       rcx,1B1CA9407D0
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
       call      qword ptr [7FFC68615818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L34:
       add       ebx,r14d
       mov       [rdi+18],ebx
M01_L35:
       mov       rcx,rsi
       call      qword ptr [7FFC68802100]; System.Text.StringBuilder.ToString()
       mov       [rbp-0C0],rax
       jmp       near ptr M01_L54
M01_L36:
       mov       rsi,[rbp-0B8]
       call      qword ptr [7FFC6878F210]; System.Number.Int32ToDecStr(Int32)
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFC6878F228]; System.Text.StringBuilder.Append(System.String)
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
       call      qword ptr [7FFC6878F1E0]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M01_L12
M01_L39:
       mov       rcx,rsi
       mov       edx,20
       call      qword ptr [7FFC6878F3A8]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M01_L13
M01_L40:
       call      qword ptr [7FFC6878F210]; System.Number.Int32ToDecStr(Int32)
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFC6878F228]; System.Text.StringBuilder.Append(System.String)
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
       call      qword ptr [7FFC6878F1E0]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       call      qword ptr [7FFC6878F3A8]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M01_L24
M01_L45:
       or        r8d,edi
       jne       short M01_L46
       xor       r14d,r14d
       xor       edi,edi
       jmp       near ptr M01_L25
M01_L46:
       mov       rsi,[rbp-0B8]
       call      qword ptr [7FFC68787198]
       int       3
M01_L47:
       call      qword ptr [7FFC68835DD0]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
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
       call      qword ptr [7FFC68CB4948]
       mov       ecx,eax
       jmp       near ptr M01_L32
M01_L50:
       mov       ecx,[rbp-7C]
       call      qword ptr [7FFC6878F210]; System.Number.Int32ToDecStr(Int32)
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFC6878F228]; System.Text.StringBuilder.Append(System.String)
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
       call      qword ptr [7FFC6878F1E0]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       call      qword ptr [7FFC68834E70]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler..ctor(Int32, Int32)
       lea       rcx,[rbp-50]
       mov       rdx,rbx
       call      qword ptr [7FFC68C266B8]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Int64, System.Private.CoreLib]](Int64)
       mov       ecx,[rbp-40]
       cmp       ecx,[rbp-30]
       jbe       short M01_L56
       call      qword ptr [7FFC68787198]
       int       3
M01_L56:
       mov       rdx,[rbp-38]
       mov       eax,ecx
       lea       rdx,[rdx+rax*2]
       mov       eax,[rbp-30]
       sub       eax,ecx
       cmp       eax,0C
       jb        short M01_L57
       vmovups   xmm0,[7FFC686C7360]
       vmovups   [rdx],xmm0
       mov       rcx,64006E006F0063
       mov       [rdx+10],rcx
       mov       ecx,[rbp-40]
       add       ecx,0C
       mov       [rbp-40],ecx
       jmp       short M01_L58
M01_L57:
       lea       rcx,[rbp-50]
       mov       rdx,1B1CA940708
       call      qword ptr [7FFC68C26730]
M01_L58:
       mov       rdx,1B1CA930008
       mov       rcx,1B1CA93B4B8
       cmp       rbx,1
       cmovne    rdx,rcx
       lea       rcx,[rbp-50]
       call      qword ptr [7FFC6883E2B0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted(System.String)
       lea       rcx,[rbp-50]
       call      qword ptr [7FFC68834EA0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
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
       call      qword ptr [7FFC68CB4C78]
       int       3
M01_L60:
       call      qword ptr [7FFC6883FF48]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rsi,rax
       jmp       near ptr M01_L00
M01_L61:
       call      qword ptr [7FFC68CB48E8]
       int       3
M01_L62:
       mov       rcx,[rsi+18]
       lea       rdx,[rbp-58]
       cmp       [rcx],ecx
       call      qword ptr [7FFC68C24BA0]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
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
       mov       rcx,17135801DC0
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0
       je        short M01_L66
       call      qword ptr [7FFC6883FF48]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
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
       mov       rdx,7FFC68554000
       call      qword ptr [7FFC688377B0]
       mov       rbx,rax
       call      qword ptr [7FFC68CB4D98]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFC6883D8F0]
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
       call      qword ptr [7FFC68CB4F00]
       jmp       near ptr M01_L76
M01_L70:
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFC68CB4F18]
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
       call      qword ptr [7FFC68B9E340]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       r14,rax
M01_L72:
       mov       rcx,[rdi+8]
       mov       r8d,[rdi+18]
       mov       rdx,r14
       call      qword ptr [7FFC68785050]; System.Array.Copy(System.Array, System.Array, Int32)
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
       call      qword ptr [7FFC68CB48E8]
       int       3
M01_L77:
       mov       rdx,rsi
       xor       r8d,r8d
       call      00007FFCC8253270
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
       call      qword ptr [7FFC68CB4FC0]
       test      eax,eax
       jne       short M01_L81
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFC68CB4FD8]
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
       call      qword ptr [7FFC68C3CCA8]; DotNetTips.Spargine.Extensions.NumericExtensions.FormatTime(Int64)
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
       sub       rsp,108
       lea       rbp,[rsp+140]
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
       jge       near ptr M01_L63
       xor       ecx,ecx
       mov       [rbp-68],rcx
       mov       rcx,1307D800C88
       mov       rsi,[rcx]
       mov       rdi,rsi
       mov       rcx,1307D800C90
       mov       r14,[rcx]
       mov       r15,r14
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],3
       jle       near ptr M01_L18
       mov       rcx,[rcx+240]
       mov       r13,[rcx+18]
       test      r13,r13
       je        near ptr M01_L18
M01_L00:
       mov       rcx,[r13+10]
       test      rcx,rcx
       je        near ptr M01_L20
       mov       eax,[rcx+8]
       cmp       eax,4
       jle       near ptr M01_L20
       mov       r12,[rcx+50]
       test      r12,r12
       je        near ptr M01_L20
       xor       eax,eax
       mov       [rcx+50],rax
       cmp       byte ptr [r15+9D],0
       jne       near ptr M01_L19
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
       jne       near ptr M01_L34
M01_L02:
       mov       edx,[rbp-58]
       mov       edi,[rbp-48]
       cmp       edx,edi
       ja        near ptr M01_L42
       mov       rax,[rbp-50]
       mov       ecx,edx
       lea       r15,[rax+rcx*2]
       sub       edi,edx
       mov       rcx,[rbp-68]
       test      rbx,rbx
       jl        near ptr M01_L36
       mov       rdx,rbx
       or        rdx,1
       lzcnt     rdx,rdx
       xor       edx,3F
       mov       rcx,7FFCC74164F8
       movzx     edx,byte ptr [rcx+rdx]
       mov       rax,7FFCC741C2E0
       cmp       rbx,[rax+rdx*8]
       setb      al
       movzx     eax,al
       sub       edx,eax
       cmp       edx,edi
       jg        near ptr M01_L41
       mov       [rbp-98],edx
       mov       [rbp-0A0],r15
       movsxd    rdx,edx
       lea       rax,[r15+rdx*2]
       mov       rcx,rbx
       cmp       rbx,0A
       jae       near ptr M01_L13
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
       je        near ptr M01_L35
       mov       ecx,[rbp-58]
       add       ecx,[rbp-98]
       mov       [rbp-58],ecx
M01_L07:
       mov       ecx,[rbp-58]
       mov       edx,[rbp-48]
       cmp       ecx,edx
       ja        near ptr M01_L42
       mov       rax,[rbp-50]
       mov       r8d,ecx
       lea       rax,[rax+r8*2]
       sub       edx,ecx
       cmp       edx,0C
       jb        near ptr M01_L16
       vmovups   xmm0,[7FFC686DD620]
       vmovups   [rax],xmm0
       mov       rcx,64006E006F0063
       mov       [rax+10],rcx
       mov       ecx,[rbp-58]
       add       ecx,0C
       mov       [rbp-58],ecx
M01_L08:
       mov       rdi,17112860008
       mov       r8,1711286B4B8
       cmp       rbx,1
       cmovne    rdi,r8
       cmp       byte ptr [rbp-54],0
       jne       near ptr M01_L17
       mov       r8d,[rbp-58]
       mov       edx,[rbp-48]
       cmp       r8d,edx
       ja        near ptr M01_L42
       mov       rcx,[rbp-50]
       mov       eax,r8d
       lea       rcx,[rcx+rax*2]
       sub       edx,r8d
       cmp       [rdi+8],edx
       ja        near ptr M01_L17
       mov       r8d,[rdi+8]
       add       r8,r8
       lea       rdx,[rdi+0C]
       call      qword ptr [7FFC68635818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbp-58]
       add       ecx,[rdi+8]
       mov       [rbp-58],ecx
M01_L09:
       mov       ecx,[rbp-58]
       cmp       ecx,[rbp-48]
       ja        near ptr M01_L42
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
       je        near ptr M01_L12
       mov       ecx,[rdi+8]
       dec       ecx
       or        ecx,0F
       xor       r15d,r15d
       lzcnt     r15d,ecx
       xor       r15d,1F
       add       r15d,0FFFFFFFD
       mov       rax,[r13+10]
       test      rax,rax
       je        near ptr M01_L43
M01_L10:
       xor       r13d,r13d
       mov       r12d,1
       cmp       [rax+8],r15d
       jbe       short M01_L11
       mov       r13d,1
       mov       ecx,10
       shlx      ecx,ecx,r15d
       cmp       [rdi+8],ecx
       jne       near ptr M01_L44
       mov       ecx,r15d
       shl       rcx,4
       lea       rax,[rax+rcx+10]
       mov       [rbp-100],rax
       mov       r8,[rax]
       mov       [rbp-108],r8
       mov       rcx,rax
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       rdx,[rbp-100]
       mov       [rdx+8],ecx
       cmp       qword ptr [rbp-108],0
       jne       near ptr M01_L45
M01_L11:
       cmp       byte ptr [r14+9D],0
       jne       near ptr M01_L60
M01_L12:
       mov       rax,rbx
       add       rsp,108
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
       cmp       rbx,64
       jb        short M01_L15
       mov       r8,17112861234
M01_L14:
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
       jae       short M01_L14
M01_L15:
       cmp       rcx,0A
       jb        near ptr M01_L03
       add       rax,0FFFFFFFFFFFFFFFC
       mov       r8,17112861234
       shl       ecx,2
       mov       ecx,[r8+rcx]
       mov       [rax],ecx
       jmp       near ptr M01_L04
M01_L16:
       lea       rcx,[rbp-68]
       mov       rdx,17112870708
       call      qword ptr [7FFC68C366B8]
       jmp       near ptr M01_L08
M01_L17:
       lea       rcx,[rbp-68]
       mov       rdx,rdi
       call      qword ptr [7FFC68C3F270]
       jmp       near ptr M01_L09
M01_L18:
       mov       ecx,3
       call      qword ptr [7FFC68C3ECD0]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       r13,rax
       jmp       near ptr M01_L00
M01_L19:
       mov       rcx,r12
       call      qword ptr [7FFC68A4D260]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rbp-78],eax
       mov       edx,[r12+8]
       mov       [rbp-7C],edx
       mov       rcx,rdi
       call      qword ptr [7FFC68A4D260]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       dword ptr [rsp+20],4
       mov       edx,[rbp-78]
       mov       r8d,[rbp-7C]
       mov       rcx,r15
       call      qword ptr [7FFC68C3F390]
       jmp       near ptr M01_L01
M01_L20:
       mov       rcx,[rdi+10]
       cmp       dword ptr [rcx+8],4
       jle       near ptr M01_L32
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        near ptr M01_L31
       mov       r12,[rcx+8]
       mov       rcx,offset MT_System.Threading.ProcessorIdCache
       call      qword ptr [7FFC68635740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       cmp       byte ptr [7FFC6857B17C],0
       je        short M01_L21
       call      qword ptr [7FFC68C3F3A8]
       mov       edx,eax
       mov       [rbp-88],edx
       jmp       short M01_L23
M01_L21:
       mov       ecx,9
       call      qword ptr [7FFC68C3F3C0]
       mov       eax,[rax+10]
       mov       [rbp-8C],eax
       mov       ecx,9
       call      qword ptr [7FFC68C3F3C0]
       mov       edx,[rbp-8C]
       lea       ecx,[rdx-1]
       mov       [rax+10],ecx
       movzx     eax,dx
       test      eax,eax
       jne       short M01_L22
       call      qword ptr [7FFC68C3F3D8]
       mov       edx,eax
       mov       [rbp-88],edx
       jmp       short M01_L23
M01_L22:
       sar       edx,10
       mov       [rbp-88],edx
M01_L23:
       mov       rcx,offset MT_System.Buffers.SharedArrayPoolStatics
       call      qword ptr [7FFC68635740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       eax,[rbp-88]
       xor       edx,edx
       div       dword ptr [7FFC6857B170]
       mov       eax,edx
       xor       edx,edx
       jmp       near ptr M01_L27
M01_L24:
       cmp       eax,[r12+8]
       jae       near ptr M01_L70
       mov       [rbp-80],eax
       mov       ecx,eax
       mov       r8,[r12+rcx*8+10]
       mov       [rbp-0F8],r8
       cmp       [r8],r8b
       xor       r10d,r10d
       mov       [rbp-0F0],r10
       mov       rcx,r8
       call      qword ptr [7FFC68B4DE18]; System.Threading.Monitor.Enter(System.Object)
       mov       r8,[rbp-0F8]
       mov       rcx,[r8+8]
       mov       eax,[r8+10]
       dec       eax
       cmp       [rcx+8],eax
       jbe       short M01_L25
       mov       edx,eax
       mov       r10,[rcx+rdx*8+10]
       mov       [rbp-0F0],r10
       mov       r10d,eax
       xor       r9d,r9d
       mov       [rcx+r10*8+10],r9
       mov       [r8+10],eax
M01_L25:
       mov       rcx,r8
       call      qword ptr [7FFC68636820]; System.Threading.Monitor.Exit(System.Object)
       mov       rcx,[rbp-0F0]
       test      rcx,rcx
       jne       short M01_L28
       mov       eax,[rbp-80]
       inc       eax
       mov       ecx,eax
       cmp       [r12+8],ecx
       jne       short M01_L26
       xor       ecx,ecx
M01_L26:
       mov       edx,[rbp-84]
       inc       edx
       mov       eax,ecx
M01_L27:
       mov       [rbp-84],edx
       cmp       [r12+8],edx
       jg        near ptr M01_L24
       jmp       short M01_L29
M01_L28:
       mov       r12,rcx
       jmp       short M01_L30
M01_L29:
       xor       r12d,r12d
M01_L30:
       test      r12,r12
       je        short M01_L31
       cmp       byte ptr [r15+9D],0
       je        near ptr M01_L01
       mov       rcx,r12
       call      qword ptr [7FFC68A4D260]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rbp-70],eax
       mov       edx,[r12+8]
       mov       [rbp-74],edx
       mov       rcx,rdi
       call      qword ptr [7FFC68A4D260]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       dword ptr [rsp+20],4
       mov       edx,[rbp-70]
       mov       r8d,[rbp-74]
       mov       rcx,r15
       call      qword ptr [7FFC68C3F390]
       jmp       near ptr M01_L01
M01_L31:
       mov       edx,100
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r12,rax
       cmp       byte ptr [r15+9D],0
       je        near ptr M01_L01
       jmp       short M01_L33
M01_L32:
       mov       ecx,100
       mov       rdx,17112866F28
       call      qword ptr [7FFC6885D8C0]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
       jmp       short M01_L31
M01_L33:
       mov       rcx,r12
       call      qword ptr [7FFC68A4D260]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rbp-6C],eax
       mov       rcx,rdi
       call      qword ptr [7FFC68A4D260]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       edx,[rbp-6C]
       mov       r8d,100
       mov       rcx,r15
       call      qword ptr [7FFC68C3F390]
       mov       rcx,rdi
       call      qword ptr [7FFC68A4D260]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
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
       call      qword ptr [7FFC68C3F3F0]
       jmp       near ptr M01_L01
M01_L34:
       lea       rcx,[rbp-68]
       mov       rdx,rbx
       xor       r8d,r8d
       call      qword ptr [7FFC68C3F6D8]
       jmp       near ptr M01_L07
M01_L35:
       lea       rcx,[rbp-68]
       call      qword ptr [7FFC68C3F708]
       jmp       near ptr M01_L02
M01_L36:
       test      rcx,rcx
       je        short M01_L37
       call      qword ptr [7FFC68BB5140]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider)
       jmp       short M01_L38
M01_L37:
       call      qword ptr [7FFC68855DD0]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
M01_L38:
       mov       r8,[rax+28]
       test      r8,r8
       jne       short M01_L39
       xor       r9d,r9d
       xor       ecx,ecx
       jmp       short M01_L40
M01_L39:
       lea       r9,[r8+0C]
       mov       ecx,[r8+8]
M01_L40:
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
       call      qword ptr [7FFC68CF4D08]
       mov       r15d,eax
       jmp       near ptr M01_L06
M01_L41:
       xor       eax,eax
       mov       [rbp-98],eax
       xor       r15d,r15d
       jmp       near ptr M01_L05
M01_L42:
       call      qword ptr [7FFC687A7198]
       int       3
M01_L43:
       mov       rcx,rsi
       call      qword ptr [7FFC6885CEA0]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
       jmp       near ptr M01_L10
M01_L44:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      qword ptr [7FFC68C3F498]
       mov       rdi,rax
       mov       ecx,29B
       mov       rdx,7FFC68574000
       call      qword ptr [7FFC688577B0]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,r14
       call      qword ptr [7FFC689B6130]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
       int       3
M01_L45:
       mov       rcx,[rsi+10]
       cmp       r15d,[rcx+8]
       jae       near ptr M01_L70
       mov       edx,r15d
       mov       r8,[rcx+rdx*8+10]
       test      r8,r8
       jne       short M01_L46
       mov       rcx,rsi
       mov       edx,r15d
       call      qword ptr [7FFC68C3F4B0]
       mov       r8,rax
M01_L46:
       mov       r12,[r8+8]
       mov       rcx,offset MT_System.Threading.ProcessorIdCache
       call      qword ptr [7FFC68635740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       cmp       byte ptr [7FFC6857B17C],0
       je        short M01_L47
       call      qword ptr [7FFC68C3F3A8]
       mov       edx,eax
       mov       [rbp-0B4],edx
       jmp       short M01_L49
M01_L47:
       mov       ecx,9
       call      qword ptr [7FFC68C3F3C0]
       mov       eax,[rax+10]
       mov       [rbp-0B8],eax
       mov       ecx,9
       call      qword ptr [7FFC68C3F3C0]
       mov       edx,[rbp-0B8]
       lea       ecx,[rdx-1]
       mov       [rax+10],ecx
       movzx     eax,dx
       test      eax,eax
       jne       short M01_L48
       call      qword ptr [7FFC68C3F3D8]
       mov       edx,eax
       mov       [rbp-0B4],edx
       jmp       short M01_L49
M01_L48:
       sar       edx,10
       mov       [rbp-0B4],edx
M01_L49:
       mov       rcx,offset MT_System.Buffers.SharedArrayPoolStatics
       call      qword ptr [7FFC68635740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       eax,[rbp-0B4]
       xor       edx,edx
       div       dword ptr [7FFC6857B170]
       mov       eax,edx
       xor       edx,edx
       jmp       near ptr M01_L56
M01_L50:
       cmp       eax,[r12+8]
       jae       near ptr M01_L70
       mov       [rbp-0AC],eax
       mov       ecx,eax
       mov       r8,[r12+rcx*8+10]
       mov       [rbp-110],r8
       cmp       [r8],r8b
       xor       r10d,r10d
       mov       [rbp-0BC],r10d
       mov       rcx,r8
       call      qword ptr [7FFC68B4DE18]; System.Threading.Monitor.Enter(System.Object)
       mov       rax,[rbp-110]
       mov       rcx,[rax+8]
       mov       r8d,[rax+10]
       mov       [rbp-0C0],r8d
       cmp       [rcx+8],r8d
       jbe       short M01_L52
       test      r8d,r8d
       jne       short M01_L53
       xor       edx,edx
       mov       [rax+14],edx
M01_L51:
       mov       edx,r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,[rbp-108]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rbp-0C0]
       inc       ecx
       mov       rax,[rbp-110]
       mov       [rax+10],ecx
       mov       dword ptr [rbp-0BC],1
M01_L52:
       mov       rcx,rax
       call      qword ptr [7FFC68636820]; System.Threading.Monitor.Exit(System.Object)
       cmp       dword ptr [rbp-0BC],0
       je        short M01_L54
       jmp       short M01_L57
M01_L53:
       jmp       short M01_L51
M01_L54:
       mov       eax,[rbp-0AC]
       inc       eax
       mov       ecx,eax
       cmp       [r12+8],ecx
       jne       short M01_L55
       xor       ecx,ecx
M01_L55:
       mov       edx,[rbp-0B0]
       inc       edx
       mov       eax,ecx
M01_L56:
       mov       [rbp-0B0],edx
       cmp       [r12+8],edx
       jg        near ptr M01_L50
       jmp       short M01_L58
M01_L57:
       mov       r12d,1
       jmp       short M01_L59
M01_L58:
       xor       r12d,r12d
M01_L59:
       jmp       near ptr M01_L11
M01_L60:
       cmp       dword ptr [rdi+8],0
       je        near ptr M01_L12
       mov       rcx,rdi
       call      qword ptr [7FFC68A4D260]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rbp-0A4],eax
       mov       edx,[rdi+8]
       mov       [rbp-0A8],edx
       mov       rcx,rsi
       call      qword ptr [7FFC68A4D260]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,r14
       mov       r8d,[rbp-0A4]
       mov       r9d,[rbp-0A8]
       mov       edx,3
       call      qword ptr [7FFC68C3F4C8]
       test      r12d,r13d
       jne       near ptr M01_L12
       mov       rcx,rdi
       call      qword ptr [7FFC68A4D260]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r12d,eax
       mov       edi,[rdi+8]
       mov       rcx,rsi
       call      qword ptr [7FFC68A4D260]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       test      r13d,r13d
       jne       short M01_L61
       mov       ecx,0FFFFFFFF
       mov       edx,1
       jmp       short M01_L62
M01_L61:
       mov       ecx,r15d
       xor       edx,edx
M01_L62:
       mov       [rsp+20],ecx
       mov       [rsp+28],edx
       mov       rcx,r14
       mov       edx,r12d
       mov       r8d,edi
       call      qword ptr [7FFC68C3F4E0]
       jmp       near ptr M01_L12
M01_L63:
       mov       rcx,rbx
       call      qword ptr [7FFC68B46718]; System.TimeSpan.FromMilliseconds(Int64)
       mov       [rbp-40],rax
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.NumericExtensions
       call      qword ptr [7FFC68635728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1307D801DC0
       mov       rcx,[rcx]
       cmp       [rcx],ecx
       call      qword ptr [7FFC6885FEE8]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].get_Value()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp-0E8],rax
       lea       rcx,[rbp-40]
       call      qword ptr [7FFC68C3CCC0]
       test      eax,eax
       jle       short M01_L64
       lea       rcx,[rbp-40]
       call      qword ptr [7FFC68C3CCC0]
       mov       edx,eax
       mov       rcx,[rbp-0E8]
       cmp       [rcx],cl
       call      qword ptr [7FFC687AF198]; System.Text.StringBuilder.AppendSpanFormattable[[System.Int32, System.Private.CoreLib]](Int32)
       mov       rbx,rax
       lea       rcx,[rbp-40]
       call      qword ptr [7FFC68C3CCC0]
       mov       rdx,17112870760
       mov       rcx,17112870738
       cmp       eax,1
       cmovne    rdx,rcx
       mov       rcx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FFC687AF228]; System.Text.StringBuilder.Append(System.String)
M01_L64:
       lea       rcx,[rbp-40]
       call      qword ptr [7FFC68C3CCF0]
       test      eax,eax
       jle       short M01_L66
       mov       rcx,[rbp-0E8]
       mov       edx,[rcx+1C]
       add       edx,[rcx+18]
       test      edx,edx
       jle       short M01_L65
       mov       edx,20
       call      qword ptr [7FFC687AF180]; System.Text.StringBuilder.Append(Char)
M01_L65:
       lea       rcx,[rbp-40]
       call      qword ptr [7FFC68C3CCF0]
       mov       edx,eax
       mov       rcx,[rbp-0E8]
       call      qword ptr [7FFC687AF198]; System.Text.StringBuilder.AppendSpanFormattable[[System.Int32, System.Private.CoreLib]](Int32)
       mov       rbx,rax
       lea       rcx,[rbp-40]
       call      qword ptr [7FFC68C3CCF0]
       mov       rdx,171128707A8
       mov       rcx,17112870780
       cmp       eax,1
       cmovne    rdx,rcx
       mov       rcx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FFC687AF228]; System.Text.StringBuilder.Append(System.String)
M01_L66:
       lea       rcx,[rbp-40]
       call      qword ptr [7FFC68C3CD20]
       test      eax,eax
       jg        short M01_L67
       mov       rcx,[rbp-0E8]
       mov       edx,[rcx+1C]
       add       edx,[rcx+18]
       jne       short M01_L69
M01_L67:
       mov       rcx,[rbp-0E8]
       mov       edx,[rcx+1C]
       add       edx,[rcx+18]
       test      edx,edx
       jle       short M01_L68
       mov       edx,20
       call      qword ptr [7FFC687AF180]; System.Text.StringBuilder.Append(Char)
M01_L68:
       lea       rcx,[rbp-40]
       call      qword ptr [7FFC68C3CD20]
       mov       edx,eax
       mov       rcx,[rbp-0E8]
       call      qword ptr [7FFC687AF198]; System.Text.StringBuilder.AppendSpanFormattable[[System.Int32, System.Private.CoreLib]](Int32)
       mov       rbx,rax
       lea       rcx,[rbp-40]
       call      qword ptr [7FFC68C3CD20]
       mov       rdx,171128707F8
       mov       rcx,171128707D0
       cmp       eax,1
       cmovne    rdx,rcx
       mov       rcx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FFC687AF228]; System.Text.StringBuilder.Append(System.String)
       mov       rcx,[rbp-0E8]
M01_L69:
       call      qword ptr [7FFC68822100]; System.Text.StringBuilder.ToString()
       mov       rbx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.NumericExtensions
       call      qword ptr [7FFC68635728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1307D801DC0
       mov       rcx,[rcx]
       cmp       [rcx],ecx
       call      qword ptr [7FFC6885FEE8]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].get_Value()
       mov       rsi,rax
       mov       rcx,[rbp-0E8]
       xor       edx,edx
       call      qword ptr [7FFC68C34798]; System.Text.StringBuilder.set_Length(Int32)
       mov       rcx,rsi
       mov       rdx,[rbp-0E8]
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       rax,rbx
       add       rsp,108
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
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       sub       rsp,38
       test      byte ptr [7FFC68C270A0],1
       jne       short M01_L71
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.NumericExtensions
       call      qword ptr [7FFC68635728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
M01_L71:
       mov       rcx,1307D801DC0
       mov       rcx,[rcx]
       cmp       [rcx],ecx
       call      qword ptr [7FFC6885FEE8]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].get_Value()
       mov       rbx,rax
       mov       rcx,[rbp-0E8]
       cmp       [rcx],cl
       xor       edx,edx
       call      qword ptr [7FFC68C34798]; System.Text.StringBuilder.set_Length(Int32)
       mov       rcx,rbx
       mov       rdx,[rbp-0E8]
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       add       rsp,38
       ret
; Total bytes of code 3217
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
       je        near ptr M00_L60
       test      esi,esi
       jl        near ptr M00_L61
       mov       rcx,12DDF401DC0
       mov       rdi,[rcx]
       mov       rcx,rdi
       cmp       qword ptr [rcx+8],0
       jne       near ptr M00_L63
       mov       r14,[rcx+18]
M00_L00:
       mov       rcx,offset MT_Microsoft.Extensions.ObjectPool.DefaultObjectPool<System.Text.StringBuilder>
       cmp       [r14],rcx
       jne       near ptr M00_L65
       mov       rcx,[r14+20]
       mov       [rbp-38],rcx
       cmp       qword ptr [rbp-38],0
       je        near ptr M00_L56
       lea       rcx,[r14+20]
       mov       r8,[rbp-38]
       test      rcx,rcx
       je        near ptr M00_L64
       xor       edx,edx
       call      00007FFCC8253270
       cmp       rax,[rbp-38]
       jne       near ptr M00_L56
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
       jg        near ptr M00_L31
M00_L04:
       mov       edx,10624DD3
       mov       eax,edx
       imul      esi
       mov       r15d,edx
       shr       r15d,1F
       sar       edx,6
       add       r15d,edx
       test      r15d,r15d
       jg        near ptr M00_L15
M00_L05:
       mov       edx,51EB851F
       mov       eax,edx
       imul      esi
       mov       r15d,edx
       shr       r15d,1F
       sar       edx,5
       add       r15d,edx
       test      r15d,r15d
       jg        near ptr M00_L22
M00_L06:
       test      esi,esi
       jle       near ptr M00_L13
       mov       eax,[r14+1C]
       add       eax,[r14+18]
       test      eax,eax
       jle       near ptr M00_L09
       call      qword ptr [7FFC68C35A28]; DotNetTips.Spargine.Extensions.Properties.Resources.get_AndLowerCase()
       test      rax,rax
       je        short M00_L08
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
       test      r8d,r8d
       je        short M00_L08
       mov       rcx,[r14+8]
       mov       eax,[r14+18]
       lea       r15d,[rax+r8]
       cmp       r15d,[rcx+8]
       ja        near ptr M00_L45
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jle       near ptr M00_L44
       mov       r8d,r8d
       add       r8,r8
       call      qword ptr [7FFC68625818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L07:
       mov       [r14+18],r15d
M00_L08:
       mov       ecx,[r14+18]
       mov       edx,ecx
       mov       rax,[r14+8]
       mov       r8d,[rax+8]
       cmp       r8d,edx
       jbe       near ptr M00_L46
       cmp       edx,r8d
       jae       near ptr M00_L50
       mov       word ptr [rax+rdx*2+10],20
       inc       ecx
       mov       [r14+18],ecx
M00_L09:
       cmp       esi,14
       jl        near ptr M00_L29
       mov       edx,66666667
       mov       eax,edx
       imul      esi
       mov       r15d,edx
       shr       r15d,1F
       sar       edx,2
       add       r15d,edx
       mov       r8,12DDF401DC8
       mov       r8,[r8]
       cmp       r15d,0A
       jae       near ptr M00_L50
       mov       ecx,r15d
       mov       r8,[r8+rcx*8+10]
       test      r8,r8
       je        short M00_L11
       lea       rdx,[r8+0C]
       mov       r8d,[r8+8]
       test      r8d,r8d
       je        short M00_L11
       mov       rcx,[r14+8]
       mov       eax,[r14+18]
       lea       r13d,[rax+r8]
       cmp       r13d,[rcx+8]
       ja        near ptr M00_L51
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jle       near ptr M00_L49
       mov       r8d,r8d
       add       r8,r8
       call      qword ptr [7FFC68625818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L10:
       mov       [r14+18],r13d
M00_L11:
       lea       ecx,[r15+r15*4]
       add       ecx,ecx
       sub       esi,ecx
       test      esi,esi
       jle       short M00_L13
       mov       ecx,[r14+18]
       mov       edx,ecx
       mov       rax,[r14+8]
       mov       r8d,[rax+8]
       cmp       r8d,edx
       jbe       near ptr M00_L52
       cmp       edx,r8d
       jae       near ptr M00_L50
       mov       word ptr [rax+rdx*2+10],2D
       inc       ecx
       mov       [r14+18],ecx
M00_L12:
       mov       r8,12DDF401DD0
       mov       r15,[r8]
       cmp       esi,14
       jae       near ptr M00_L50
       mov       r8d,esi
       mov       rdx,[r15+r8*8+10]
       test      rdx,rdx
       je        short M00_L13
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,r14
       call      qword ptr [7FFC6879F150]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M00_L13:
       mov       rcx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFC68812100]; System.Text.StringBuilder.ToString()
       mov       rsi,rax
       mov       r15d,[rsi+8]
       test      r15d,r15d
       je        short M00_L14
       movzx     ecx,word ptr [rsi+0C]
       call      qword ptr [7FFC68BA7510]; System.Char.IsWhiteSpace(Char)
       test      eax,eax
       jne       near ptr M00_L53
       lea       ecx,[r15-1]
       cmp       ecx,r15d
       jae       near ptr M00_L50
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       call      qword ptr [7FFC68BA7510]; System.Char.IsWhiteSpace(Char)
       test      eax,eax
       jne       near ptr M00_L53
M00_L14:
       mov       r15,rsi
       jmp       near ptr M00_L54
M00_L15:
       mov       ecx,r15d
       call      qword ptr [7FFC68C35950]; DotNetTips.Spargine.Extensions.NumericExtensions.ToWords(Int32)
       cmp       [r14],r14b
       test      rax,rax
       je        short M00_L17
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
       test      r8d,r8d
       je        short M00_L17
       mov       rcx,[r14+8]
       mov       eax,[r14+18]
       lea       r13d,[rax+r8]
       cmp       r13d,[rcx+8]
       ja        near ptr M00_L33
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jle       near ptr M00_L32
       mov       r8d,r8d
       add       r8,r8
       call      qword ptr [7FFC68625818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L16:
       mov       [r14+18],r13d
M00_L17:
       mov       ecx,[r14+18]
       mov       edx,ecx
       mov       rax,[r14+8]
       mov       r8d,[rax+8]
       cmp       r8d,edx
       jbe       near ptr M00_L34
       mov       word ptr [rax+rdx*2+10],20
       inc       ecx
       mov       [r14+18],ecx
M00_L18:
       call      qword ptr [7FFC68C359E0]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Thousand()
       test      rax,rax
       je        short M00_L20
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
       test      r8d,r8d
       je        short M00_L20
       mov       rcx,[r14+8]
       mov       eax,[r14+18]
       lea       r13d,[rax+r8]
       cmp       r13d,[rcx+8]
       ja        near ptr M00_L36
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jle       near ptr M00_L35
       mov       r8d,r8d
       add       r8,r8
       call      qword ptr [7FFC68625818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L19:
       mov       [r14+18],r13d
M00_L20:
       mov       ecx,[r14+18]
       mov       edx,ecx
       mov       rax,[r14+8]
       mov       r8d,[rax+8]
       cmp       r8d,edx
       jbe       near ptr M00_L37
       mov       word ptr [rax+rdx*2+10],20
       inc       ecx
       mov       [r14+18],ecx
M00_L21:
       imul      eax,r15d,3E8
       sub       esi,eax
       jmp       near ptr M00_L05
M00_L22:
       mov       ecx,r15d
       call      qword ptr [7FFC68C35950]; DotNetTips.Spargine.Extensions.NumericExtensions.ToWords(Int32)
       cmp       [r14],r14b
       test      rax,rax
       je        short M00_L24
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
       test      r8d,r8d
       je        short M00_L24
       mov       rcx,[r14+8]
       mov       eax,[r14+18]
       lea       r13d,[rax+r8]
       cmp       r13d,[rcx+8]
       ja        near ptr M00_L39
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jle       near ptr M00_L38
       mov       r8d,r8d
       add       r8,r8
       call      qword ptr [7FFC68625818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L23:
       mov       [r14+18],r13d
M00_L24:
       mov       ecx,[r14+18]
       mov       edx,ecx
       mov       rax,[r14+8]
       mov       r8d,[rax+8]
       cmp       r8d,edx
       jbe       near ptr M00_L40
       cmp       edx,r8d
       jae       near ptr M00_L50
       mov       word ptr [rax+rdx*2+10],20
       inc       ecx
       mov       [r14+18],ecx
M00_L25:
       call      qword ptr [7FFC68C359F8]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Hundred()
       test      rax,rax
       je        short M00_L27
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
       test      r8d,r8d
       je        short M00_L27
       mov       rcx,[r14+8]
       mov       eax,[r14+18]
       lea       r13d,[rax+r8]
       cmp       r13d,[rcx+8]
       ja        near ptr M00_L42
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jle       near ptr M00_L41
       mov       r8d,r8d
       add       r8,r8
       call      qword ptr [7FFC68625818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L26:
       mov       [r14+18],r13d
M00_L27:
       mov       ecx,[r14+18]
       mov       edx,ecx
       mov       rax,[r14+8]
       mov       r8d,[rax+8]
       cmp       r8d,edx
       jbe       near ptr M00_L43
       cmp       edx,r8d
       jae       near ptr M00_L50
       mov       word ptr [rax+rdx*2+10],20
       inc       ecx
       mov       [r14+18],ecx
M00_L28:
       imul      eax,r15d,64
       sub       esi,eax
       jmp       near ptr M00_L06
M00_L29:
       mov       r8,12DDF401DD0
       mov       r15,[r8]
       cmp       esi,14
       jae       near ptr M00_L50
       mov       r8d,esi
       mov       r8,[r15+r8*8+10]
       test      r8,r8
       je        near ptr M00_L13
       lea       rdx,[r8+0C]
       mov       r8d,[r8+8]
       test      r8d,r8d
       je        near ptr M00_L13
       mov       rcx,[r14+8]
       mov       eax,[r14+18]
       lea       esi,[rax+r8]
       cmp       esi,[rcx+8]
       ja        near ptr M00_L48
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jle       near ptr M00_L47
       mov       r8d,r8d
       add       r8,r8
       call      qword ptr [7FFC68625818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L30:
       mov       [r14+18],esi
       jmp       near ptr M00_L13
M00_L31:
       mov       ecx,esi
       imul      rcx,431BDE83
       shr       rcx,32
       call      qword ptr [7FFC68C35950]; DotNetTips.Spargine.Extensions.NumericExtensions.ToWords(Int32)
       mov       rdx,rax
       mov       rcx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFC6879F228]; System.Text.StringBuilder.Append(System.String)
       mov       rcx,rax
       mov       edx,20
       cmp       [rcx],ecx
       call      qword ptr [7FFC6879F180]; System.Text.StringBuilder.Append(Char)
       mov       r15,rax
       call      qword ptr [7FFC68C359C8]
       mov       rdx,rax
       mov       rcx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFC6879F228]; System.Text.StringBuilder.Append(System.String)
       mov       rcx,rax
       mov       edx,20
       cmp       [rcx],ecx
       call      qword ptr [7FFC6879F180]; System.Text.StringBuilder.Append(Char)
       mov       eax,esi
       imul      rax,431BDE83
       shr       rax,32
       imul      eax,0F4240
       sub       esi,eax
       jmp       near ptr M00_L04
M00_L32:
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       jne       near ptr M00_L16
       movzx     edx,word ptr [rdx+2]
       mov       [rcx+2],dx
       jmp       near ptr M00_L16
M00_L33:
       mov       rcx,r14
       call      qword ptr [7FFC6879F1E0]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M00_L17
M00_L34:
       mov       rcx,r14
       mov       edx,20
       call      qword ptr [7FFC6879F3A8]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L18
M00_L35:
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       jne       near ptr M00_L19
       movzx     edx,word ptr [rdx+2]
       mov       [rcx+2],dx
       jmp       near ptr M00_L19
M00_L36:
       mov       rcx,r14
       call      qword ptr [7FFC6879F1E0]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M00_L20
M00_L37:
       mov       rcx,r14
       mov       edx,20
       call      qword ptr [7FFC6879F3A8]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L21
M00_L38:
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       jne       near ptr M00_L23
       movzx     edx,word ptr [rdx+2]
       mov       [rcx+2],dx
       jmp       near ptr M00_L23
M00_L39:
       mov       rcx,r14
       call      qword ptr [7FFC6879F1E0]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M00_L24
M00_L40:
       mov       rcx,r14
       mov       edx,20
       call      qword ptr [7FFC6879F3A8]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L25
M00_L41:
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       jne       near ptr M00_L26
       movzx     edx,word ptr [rdx+2]
       mov       [rcx+2],dx
       jmp       near ptr M00_L26
M00_L42:
       mov       rcx,r14
       call      qword ptr [7FFC6879F1E0]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M00_L27
M00_L43:
       mov       rcx,r14
       mov       edx,20
       call      qword ptr [7FFC6879F3A8]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L28
M00_L44:
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       jne       near ptr M00_L07
       movzx     edx,word ptr [rdx+2]
       mov       [rcx+2],dx
       jmp       near ptr M00_L07
M00_L45:
       mov       rcx,r14
       call      qword ptr [7FFC6879F1E0]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M00_L08
M00_L46:
       mov       rcx,r14
       mov       edx,20
       call      qword ptr [7FFC6879F3A8]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L09
M00_L47:
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       jne       near ptr M00_L30
       movzx     edx,word ptr [rdx+2]
       mov       [rcx+2],dx
       jmp       near ptr M00_L30
M00_L48:
       mov       rcx,r14
       call      qword ptr [7FFC6879F1E0]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M00_L13
M00_L49:
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       jne       near ptr M00_L10
       movzx     edx,word ptr [rdx+2]
       mov       [rcx+2],dx
       jmp       near ptr M00_L10
M00_L50:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L51:
       mov       rcx,r14
       call      qword ptr [7FFC6879F1E0]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M00_L11
M00_L52:
       mov       rcx,r14
       mov       edx,2D
       call      qword ptr [7FFC6879F3A8]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L12
M00_L53:
       mov       rcx,rsi
       mov       edx,3
       call      qword ptr [7FFC68C3E8C8]
       mov       r15,rax
M00_L54:
       mov       rcx,rdi
       call      qword ptr [7FFC6884FEE8]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].get_Value()
       mov       rsi,rax
       mov       rcx,r14
       xor       edx,edx
       call      qword ptr [7FFC68BAD7D0]; System.Text.StringBuilder.set_Length(Int32)
       mov       rcx,offset MT_Microsoft.Extensions.ObjectPool.DefaultObjectPool<System.Text.StringBuilder>
       cmp       [rsi],rcx
       jne       near ptr M00_L66
       mov       rcx,rsi
       mov       rdx,r14
       call      qword ptr [7FFC68BAD7E8]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].ReturnCore(System.__Canon)
M00_L55:
       mov       [rbp-40],r15
       mov       rcx,[rbx+60]
       lea       r8,[rbp-40]
       mov       rdx,7FFC68C4E050
       cmp       [rcx],ecx
       call      qword ptr [7FFC68C35F08]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
M00_L56:
       mov       r15,[r14+18]
       mov       r13,[r15+18]
       lea       rdx,[rbp-38]
       mov       rcx,r13
       cmp       [rcx],ecx
       call      qword ptr [7FFC68BAD6C8]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       jne       short M00_L57
       cmp       qword ptr [r13+10],0
       je        short M00_L58
       lea       rdx,[rbp-38]
       mov       rcx,r15
       call      qword ptr [7FFC68C3E688]
       test      eax,eax
       je        short M00_L59
M00_L57:
       add       r14,2C
       lock dec  dword ptr [r14]
       jmp       near ptr M00_L01
M00_L58:
       xor       ecx,ecx
       mov       [rbp-38],rcx
M00_L59:
       mov       rax,[r14+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r14,rax
       jmp       near ptr M00_L02
M00_L60:
       call      qword ptr [7FFC68C35968]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Zero()
       mov       r15,rax
       jmp       near ptr M00_L55
M00_L61:
       call      qword ptr [7FFC68C35980]
       mov       r15,rax
       mov       ecx,1
       call      qword ptr [7FFC68626670]; System.String.FastAllocateString(IntPtr)
       mov       rdi,rax
       mov       word ptr [rdi+0C],20
       mov       ecx,esi
       neg       ecx
       jns       short M00_L62
       call      qword ptr [7FFC68C3EC58]
       int       3
M00_L62:
       call      qword ptr [7FFC68C35950]; DotNetTips.Spargine.Extensions.NumericExtensions.ToWords(Int32)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,r15
       call      qword ptr [7FFC68627828]; System.String.Concat(System.String, System.String, System.String)
       mov       r15,rax
       jmp       near ptr M00_L55
M00_L63:
       call      qword ptr [7FFC6884FF48]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       r14,rax
       jmp       near ptr M00_L00
M00_L64:
       call      qword ptr [7FFC68C3E550]
       int       3
M00_L65:
       mov       rcx,r14
       mov       rax,[r14]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       r14,rax
       jmp       near ptr M00_L03
M00_L66:
       mov       rcx,rsi
       mov       rdx,r14
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       jmp       near ptr M00_L55
       sub       rsp,28
       mov       rcx,12DDF401DC0
       mov       rdi,[rcx]
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFC6884FEE8]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].get_Value()
       mov       r15,rax
       mov       rdx,[rbp-48]
       cmp       [rdx],dl
       mov       rcx,rdx
       xor       edx,edx
       call      qword ptr [7FFC68BAD7D0]; System.Text.StringBuilder.set_Length(Int32)
       mov       rcx,offset MT_Microsoft.Extensions.ObjectPool.DefaultObjectPool<System.Text.StringBuilder>
       cmp       [r15],rcx
       jne       short M00_L67
       mov       rcx,r15
       mov       rdx,[rbp-48]
       call      qword ptr [7FFC68BAD7E8]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].ReturnCore(System.__Canon)
       jmp       short M00_L68
M00_L67:
       mov       rcx,r15
       mov       rdx,[rbp-48]
       mov       rax,[r15]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
M00_L68:
       nop
       add       rsp,28
       ret
; Total bytes of code 2347
```
```assembly
; DotNetTips.Spargine.Extensions.Properties.Resources.get_AndLowerCase()
;                 return ResourceManager.GetString("AndLowerCase", resourceCulture);
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,28
       call      qword ptr [7FFC68C35DD0]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,12DF5400168
       mov       r8,[r8]
       mov       rdx,16E742B0E18
       mov       rax,[rax]
       mov       rax,[rax+48]
       add       rsp,28
       jmp       qword ptr [rax+28]
; Total bytes of code 51
```
```assembly
; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M02_L11
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M02_L11
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
       je        near ptr M02_L09
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
       jmp       short M02_L00
M02_L02:
       cmp       r8,40
       ja        short M02_L05
M02_L03:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        short M02_L08
M02_L04:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
       jmp       short M02_L00
M02_L05:
       cmp       r8,800
       ja        near ptr M02_L12
       cmp       r8,100
       jae       short M02_L10
M02_L06:
       mov       r9,r8
       shr       r9,6
M02_L07:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M02_L07
       and       r8,3F
       cmp       r8,10
       ja        short M02_L03
       jmp       short M02_L04
M02_L08:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M02_L04
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M02_L04
M02_L09:
       test      r8,r8
       je        near ptr M02_L00
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        near ptr M02_L00
       movsx     r8,word ptr [rax-2]
       mov       [r10-2],r8w
       jmp       near ptr M02_L00
M02_L10:
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
       jmp       near ptr M02_L06
M02_L11:
       cmp       rcx,rdx
       jne       short M02_L12
       cmp       [rdx],dl
       jmp       near ptr M02_L00
M02_L12:
       cmp       [rcx],cl
       cmp       [rdx],dl
       vzeroupper
       jmp       qword ptr [7FFC686266E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 336
```
```assembly
; System.Text.StringBuilder.Append(Char ByRef, Int32)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       test      r8d,r8d
       je        short M03_L01
       mov       rcx,[rbx+8]
       mov       eax,[rbx+18]
       lea       esi,[rax+r8]
       cmp       esi,[rcx+8]
       ja        short M03_L03
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jle       short M03_L02
       mov       r8d,r8d
       add       r8,r8
       call      qword ptr [7FFC68625818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M03_L00:
       mov       [rbx+18],esi
M03_L01:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M03_L02:
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       jne       short M03_L00
       movzx     edx,word ptr [rdx+2]
       mov       [rcx+2],dx
       jmp       short M03_L00
M03_L03:
       mov       rcx,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFC6879F1E0]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       je        short M04_L02
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFCC82B9D30
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
       call      qword ptr [7FFC68625818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,16E742A0008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,19655
       mov       rdx,7FFC68564000
       call      qword ptr [7FFC688477B0]
       mov       rbx,rax
       call      qword ptr [7FFC68C3E6A0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFC6884D8F0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 201
```
```assembly
; System.Char.IsWhiteSpace(Char)
       movzx     ecx,cx
       cmp       ecx,100
       jge       short M05_L00
       mov       eax,ecx
       mov       rcx,7FFCC7416098
       test      byte ptr [rcx+rax],80
       setne     al
       movzx     eax,al
       ret
M05_L00:
       jmp       qword ptr [7FFC68C3E8B0]
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
M06_L00:
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
       je        near ptr M06_L128
       cmp       dword ptr [rbp+10],0
       jl        near ptr M06_L129
       mov       rcx,12DDF401DC0
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0
       jne       near ptr M06_L142
       mov       rbx,[rcx+18]
M06_L01:
       mov       rcx,offset MT_Microsoft.Extensions.ObjectPool.DefaultObjectPool<System.Text.StringBuilder>
       cmp       [rbx],rcx
       jne       near ptr M06_L144
       mov       rcx,[rbx+20]
       mov       [rbp-30],rcx
       cmp       qword ptr [rbp-30],0
       je        near ptr M06_L124
       lea       rcx,[rbx+20]
       mov       r8,[rbp-30]
       test      rcx,rcx
       je        near ptr M06_L143
       xor       edx,edx
       call      00007FFCC8253270
       cmp       rax,[rbp-30]
       jne       near ptr M06_L124
M06_L02:
       mov       rbx,[rbp-30]
M06_L03:
       xor       ecx,ecx
       mov       [rbp-30],rcx
M06_L04:
       mov       [rbp-38],rbx
       mov       ecx,[rbp+10]
       imul      rcx,431BDE83
       shr       rcx,32
       test      ecx,ecx
       jg        near ptr M06_L101
M06_L05:
       mov       edx,10624DD3
       mov       eax,edx
       imul      dword ptr [rbp+10]
       mov       ebx,edx
       shr       ebx,1F
       sar       edx,6
       add       ebx,edx
       test      ebx,ebx
       jg        near ptr M06_L09
M06_L06:
       mov       edx,51EB851F
       mov       eax,edx
       imul      dword ptr [rbp+10]
       mov       esi,edx
       shr       esi,1F
       sar       edx,5
       add       esi,edx
       test      esi,esi
       jg        near ptr M06_L52
M06_L07:
       cmp       dword ptr [rbp+10],0
       jle       near ptr M06_L97
       mov       rbx,[rbp-38]
       mov       eax,[rbx+1C]
       add       eax,[rbx+18]
       test      eax,eax
       jg        near ptr M06_L86
M06_L08:
       cmp       dword ptr [rbp+10],14
       jl        near ptr M06_L96
       mov       edx,66666667
       mov       eax,edx
       imul      dword ptr [rbp+10]
       mov       eax,edx
       shr       eax,1F
       sar       edx,2
       add       eax,edx
       mov       rdx,12DDF401DC8
       mov       r8,[rdx]
       cmp       eax,0A
       jae       near ptr M06_L114
       mov       edx,66666667
       mov       eax,edx
       imul      dword ptr [rbp+10]
       mov       ecx,edx
       shr       ecx,1F
       sar       edx,2
       add       ecx,edx
       mov       rcx,[r8+rcx*8+10]
       test      rcx,rcx
       je        near ptr M06_L91
       lea       rdx,[rcx+0C]
       mov       esi,[rcx+8]
       test      esi,esi
       je        near ptr M06_L91
       mov       rdi,[rbx+8]
       mov       r14d,[rbx+18]
       lea       ecx,[r14+rsi]
       cmp       ecx,[rdi+8]
       ja        near ptr M06_L88
       movsxd    r8,r14d
       lea       rcx,[rdi+r8*2+10]
       cmp       esi,2
       jg        near ptr M06_L89
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       esi,2
       jne       near ptr M06_L90
       movzx     eax,word ptr [rdx+2]
       mov       [rcx+2],ax
       jmp       near ptr M06_L90
M06_L09:
       mov       rcx,12DDF401DC0
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0
       jne       near ptr M06_L109
       mov       rcx,[rcx+18]
M06_L10:
       mov       rax,offset MT_Microsoft.Extensions.ObjectPool.DefaultObjectPool<System.Text.StringBuilder>
       cmp       [rcx],rax
       jne       near ptr M06_L110
       cmp       [rcx],ecx
       call      qword ptr [7FFC68BD8848]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Get()
       mov       rsi,rax
M06_L11:
       mov       [rbp-58],rsi
       mov       edx,431BDE83
       mov       eax,edx
       imul      ebx
       mov       eax,edx
       shr       eax,1F
       sar       edx,12
       add       eax,edx
       test      eax,eax
       jg        near ptr M06_L30
M06_L12:
       mov       edx,10624DD3
       mov       eax,edx
       imul      ebx
       mov       edi,edx
       shr       edi,1F
       sar       edx,6
       add       edi,edx
       test      edi,edi
       jg        near ptr M06_L22
M06_L13:
       mov       edx,51EB851F
       mov       eax,edx
       imul      ebx
       mov       edi,edx
       shr       edi,1F
       sar       edx,5
       add       edi,edx
       test      edi,edi
       jg        near ptr M06_L25
M06_L14:
       test      ebx,ebx
       jle       near ptr M06_L18
       mov       eax,[rsi+1C]
       add       eax,[rsi+18]
       test      eax,eax
       jg        near ptr M06_L28
M06_L15:
       cmp       ebx,14
       jl        near ptr M06_L29
       mov       edx,66666667
       mov       eax,edx
       imul      ebx
       mov       edi,edx
       shr       edi,1F
       sar       edx,2
       add       edi,edx
       mov       r8,12DDF401DC8
       mov       r8,[r8]
       cmp       edi,0A
       jae       near ptr M06_L39
       mov       edx,edi
       mov       rdx,[r8+rdx*8+10]
       test      rdx,rdx
       je        short M06_L16
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,rsi
       call      qword ptr [7FFC6879F150]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M06_L16:
       lea       ecx,[rdi+rdi*4]
       add       ecx,ecx
       sub       ebx,ecx
       test      ebx,ebx
       jle       short M06_L18
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       rax,[rsi+8]
       mov       r8d,[rax+8]
       cmp       r8d,edx
       jbe       near ptr M06_L36
       cmp       edx,r8d
       jae       near ptr M06_L39
       mov       word ptr [rax+rdx*2+10],2D
       inc       ecx
       mov       [rsi+18],ecx
M06_L17:
       mov       r8,12DDF401DD0
       mov       r14,[r8]
       cmp       ebx,14
       jae       near ptr M06_L39
       mov       r8d,ebx
       mov       rdx,[r14+r8*8+10]
       test      rdx,rdx
       je        short M06_L18
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,rsi
       call      qword ptr [7FFC6879F150]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M06_L18:
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFC68812100]; System.Text.StringBuilder.ToString()
       mov       r14,rax
       cmp       dword ptr [r14+8],0
       je        short M06_L20
       movzx     ecx,word ptr [r14+0C]
       cmp       ecx,100
       jge       near ptr M06_L37
       cmp       ecx,100
       jae       near ptr M06_L39
       mov       rax,7FFCC7416098
       test      byte ptr [rax+rcx],80
       jne       near ptr M06_L40
M06_L19:
       mov       ecx,[r14+8]
       dec       ecx
       cmp       ecx,[r14+8]
       jae       near ptr M06_L39
       movzx     ecx,word ptr [r14+rcx*2+0C]
       cmp       ecx,100
       jge       near ptr M06_L38
       cmp       ecx,100
       jae       near ptr M06_L39
       mov       rax,7FFCC7416098
       test      byte ptr [rax+rcx],80
       jne       near ptr M06_L40
M06_L20:
       mov       r8,r14
M06_L21:
       mov       [rbp-60],r8
       jmp       near ptr M06_L41
M06_L22:
       mov       ecx,edi
       call      qword ptr [7FFC68C35950]
       mov       rdx,rax
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFC6879F228]; System.Text.StringBuilder.Append(System.String)
       mov       r14,rax
       mov       ecx,[r14+18]
       mov       edx,ecx
       mov       rax,[r14+8]
       mov       r8d,[rax+8]
       cmp       r8d,edx
       jbe       near ptr M06_L31
       cmp       edx,r8d
       jae       near ptr M06_L39
       mov       word ptr [rax+rdx*2+10],20
       inc       ecx
       mov       [r14+18],ecx
M06_L23:
       call      qword ptr [7FFC68C359E0]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Thousand()
       mov       rdx,rax
       mov       rcx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFC6879F228]; System.Text.StringBuilder.Append(System.String)
       mov       ecx,[rax+18]
       mov       edx,ecx
       mov       r8,[rax+8]
       mov       r10d,[r8+8]
       cmp       r10d,edx
       jbe       near ptr M06_L32
       cmp       edx,r10d
       jae       near ptr M06_L39
       mov       word ptr [r8+rdx*2+10],20
       inc       ecx
       mov       [rax+18],ecx
M06_L24:
       imul      eax,edi,3E8
       sub       ebx,eax
       jmp       near ptr M06_L13
M06_L25:
       mov       ecx,edi
       call      qword ptr [7FFC68C35950]
       mov       rdx,rax
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFC6879F228]; System.Text.StringBuilder.Append(System.String)
       mov       r14,rax
       mov       ecx,[r14+18]
       mov       edx,ecx
       mov       rax,[r14+8]
       mov       r8d,[rax+8]
       cmp       r8d,edx
       jbe       near ptr M06_L33
       cmp       edx,r8d
       jae       near ptr M06_L39
       mov       word ptr [rax+rdx*2+10],20
       inc       ecx
       mov       [r14+18],ecx
M06_L26:
       call      qword ptr [7FFC68C359F8]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Hundred()
       mov       rdx,rax
       mov       rcx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFC6879F228]; System.Text.StringBuilder.Append(System.String)
       mov       ecx,[rax+18]
       mov       edx,ecx
       mov       r8,[rax+8]
       mov       r10d,[r8+8]
       cmp       r10d,edx
       jbe       near ptr M06_L34
       cmp       edx,r10d
       jae       near ptr M06_L39
       mov       word ptr [r8+rdx*2+10],20
       inc       ecx
       mov       [rax+18],ecx
M06_L27:
       imul      eax,edi,64
       sub       ebx,eax
       jmp       near ptr M06_L14
M06_L28:
       call      qword ptr [7FFC68C35A28]; DotNetTips.Spargine.Extensions.Properties.Resources.get_AndLowerCase()
       mov       rdx,rax
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFC6879F228]; System.Text.StringBuilder.Append(System.String)
       mov       ecx,[rax+18]
       mov       edx,ecx
       mov       r8,[rax+8]
       mov       r10d,[r8+8]
       cmp       r10d,edx
       jbe       near ptr M06_L35
       cmp       edx,r10d
       jae       near ptr M06_L39
       mov       word ptr [r8+rdx*2+10],20
       inc       ecx
       mov       [rax+18],ecx
       jmp       near ptr M06_L15
M06_L29:
       mov       rdx,12DDF401DD0
       mov       r14,[rdx]
       cmp       ebx,14
       jae       near ptr M06_L39
       mov       edx,ebx
       mov       rdx,[r14+rdx*8+10]
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFC6879F228]; System.Text.StringBuilder.Append(System.String)
       jmp       near ptr M06_L18
M06_L30:
       mov       edx,431BDE83
       mov       eax,edx
       imul      ebx
       mov       ecx,edx
       shr       ecx,1F
       sar       edx,12
       add       ecx,edx
       call      qword ptr [7FFC68C35950]
       mov       rdx,rax
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFC6879F228]; System.Text.StringBuilder.Append(System.String)
       mov       rcx,rax
       mov       edx,20
       cmp       [rcx],ecx
       call      qword ptr [7FFC6879F180]; System.Text.StringBuilder.Append(Char)
       mov       rdi,rax
       call      qword ptr [7FFC68C359C8]
       mov       rdx,rax
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFC6879F228]; System.Text.StringBuilder.Append(System.String)
       mov       rcx,rax
       mov       edx,20
       cmp       [rcx],ecx
       call      qword ptr [7FFC6879F180]; System.Text.StringBuilder.Append(Char)
       mov       edx,431BDE83
       mov       eax,edx
       imul      ebx
       mov       eax,edx
       shr       eax,1F
       sar       edx,12
       add       eax,edx
       imul      eax,0F4240
       sub       ebx,eax
       jmp       near ptr M06_L12
M06_L31:
       mov       rcx,r14
       mov       edx,20
       call      qword ptr [7FFC6879F3A8]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M06_L23
M06_L32:
       mov       rcx,rax
       mov       edx,20
       call      qword ptr [7FFC6879F3A8]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M06_L24
M06_L33:
       mov       rcx,r14
       mov       edx,20
       call      qword ptr [7FFC6879F3A8]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M06_L26
M06_L34:
       mov       rcx,rax
       mov       edx,20
       call      qword ptr [7FFC6879F3A8]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M06_L27
M06_L35:
       mov       rcx,rax
       mov       edx,20
       call      qword ptr [7FFC6879F3A8]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M06_L15
M06_L36:
       mov       rcx,rsi
       mov       edx,2D
       call      qword ptr [7FFC6879F3A8]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M06_L17
M06_L37:
       call      qword ptr [7FFC68C3E8B0]
       test      eax,eax
       jne       short M06_L40
       jmp       near ptr M06_L19
M06_L38:
       call      qword ptr [7FFC68C3E8B0]
       test      eax,eax
       jne       short M06_L40
       jmp       near ptr M06_L20
M06_L39:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M06_L40:
       mov       rcx,r14
       mov       edx,3
       call      qword ptr [7FFC68C3E8C8]
       mov       r8,rax
       jmp       near ptr M06_L21
M06_L41:
       call      M06_L145
       nop
       mov       r8,[rbp-60]
       mov       rbx,[rbp-38]
       cmp       [rbx],bl
       test      r8,r8
       je        short M06_L44
       lea       rdx,[r8+0C]
       mov       r8d,[r8+8]
       test      r8d,r8d
       je        short M06_L44
       mov       rsi,[rbx+8]
       mov       edi,[rbx+18]
       lea       r14d,[rdi+r8]
       cmp       r14d,[rsi+8]
       jbe       short M06_L42
       mov       rcx,rbx
       call      qword ptr [7FFC6879F1E0]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M06_L44
M06_L42:
       movsxd    rcx,edi
       lea       rcx,[rsi+rcx*2+10]
       cmp       r8d,2
       jle       near ptr M06_L46
       mov       r8d,r8d
       add       r8,r8
       call      qword ptr [7FFC68625818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M06_L43:
       mov       [rbx+18],r14d
M06_L44:
       mov       ecx,[rbx+18]
       mov       edx,ecx
       mov       rax,[rbx+8]
       mov       r8d,[rax+8]
       cmp       r8d,edx
       jbe       near ptr M06_L111
       cmp       edx,r8d
       jae       near ptr M06_L114
       mov       word ptr [rax+rdx*2+10],20
       inc       ecx
       mov       [rbx+18],ecx
M06_L45:
       call      qword ptr [7FFC68C359E0]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Thousand()
       test      rax,rax
       je        short M06_L50
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
       test      r8d,r8d
       je        short M06_L50
       mov       rsi,[rbx+8]
       mov       edi,[rbx+18]
       lea       r14d,[rdi+r8]
       cmp       r14d,[rsi+8]
       ja        short M06_L47
       movsxd    rcx,edi
       lea       rcx,[rsi+rcx*2+10]
       cmp       r8d,2
       jg        short M06_L48
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       jne       short M06_L49
       movzx     edx,word ptr [rdx+2]
       mov       [rcx+2],dx
       jmp       short M06_L49
M06_L46:
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       jne       near ptr M06_L43
       movzx     edx,word ptr [rdx+2]
       mov       [rcx+2],dx
       jmp       near ptr M06_L43
M06_L47:
       mov       rcx,rbx
       call      qword ptr [7FFC6879F1E0]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M06_L50
M06_L48:
       mov       r8d,r8d
       add       r8,r8
       call      qword ptr [7FFC68625818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M06_L49:
       mov       [rbx+18],r14d
M06_L50:
       mov       ecx,[rbx+18]
       mov       edx,ecx
       mov       rax,[rbx+8]
       mov       r8d,[rax+8]
       cmp       r8d,edx
       jbe       near ptr M06_L112
       cmp       edx,r8d
       jae       near ptr M06_L114
       mov       word ptr [rax+rdx*2+10],20
       inc       ecx
       mov       [rbx+18],ecx
M06_L51:
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
       jmp       near ptr M06_L06
M06_L52:
       mov       rcx,12DDF401DC0
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0
       jne       near ptr M06_L113
       mov       rcx,[rcx+18]
M06_L53:
       mov       rax,offset MT_Microsoft.Extensions.ObjectPool.DefaultObjectPool<System.Text.StringBuilder>
       cmp       [rcx],rax
       jne       near ptr M06_L115
       cmp       [rcx],ecx
       call      qword ptr [7FFC68BD8848]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Get()
       mov       rdi,rax
M06_L54:
       mov       [rbp-68],rdi
       mov       edx,431BDE83
       mov       eax,edx
       imul      esi
       mov       eax,edx
       shr       eax,1F
       sar       edx,12
       add       eax,edx
       test      eax,eax
       jg        near ptr M06_L69
M06_L55:
       mov       edx,10624DD3
       mov       eax,edx
       imul      esi
       mov       r14d,edx
       shr       r14d,1F
       sar       edx,6
       add       r14d,edx
       test      r14d,r14d
       jg        near ptr M06_L65
M06_L56:
       mov       edx,51EB851F
       mov       eax,edx
       imul      esi
       mov       r14d,edx
       shr       r14d,1F
       sar       edx,5
       add       r14d,edx
       test      r14d,r14d
       jg        near ptr M06_L66
M06_L57:
       test      esi,esi
       jle       near ptr M06_L61
       mov       eax,[rdi+1C]
       add       eax,[rdi+18]
       test      eax,eax
       jg        near ptr M06_L67
M06_L58:
       cmp       esi,14
       jl        near ptr M06_L68
       mov       edx,66666667
       mov       eax,edx
       imul      esi
       mov       r14d,edx
       shr       r14d,1F
       sar       edx,2
       add       r14d,edx
       mov       r8,12DDF401DC8
       mov       r8,[r8]
       cmp       r14d,0A
       jae       near ptr M06_L73
       mov       edx,r14d
       mov       rdx,[r8+rdx*8+10]
       test      rdx,rdx
       je        short M06_L59
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,rdi
       call      qword ptr [7FFC6879F150]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M06_L59:
       lea       ecx,[r14+r14*4]
       add       ecx,ecx
       sub       esi,ecx
       test      esi,esi
       jle       short M06_L61
       mov       ecx,[rdi+18]
       mov       edx,ecx
       mov       rax,[rdi+8]
       mov       r8d,[rax+8]
       cmp       r8d,edx
       jbe       near ptr M06_L70
       cmp       edx,r8d
       jae       near ptr M06_L73
       mov       word ptr [rax+rdx*2+10],2D
       inc       ecx
       mov       [rdi+18],ecx
M06_L60:
       mov       r8,12DDF401DD0
       mov       r14,[r8]
       cmp       esi,14
       jae       near ptr M06_L73
       mov       r8d,esi
       mov       rdx,[r14+r8*8+10]
       test      rdx,rdx
       je        short M06_L61
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,rdi
       call      qword ptr [7FFC6879F150]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M06_L61:
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFC68812100]; System.Text.StringBuilder.ToString()
       mov       r14,rax
       cmp       dword ptr [r14+8],0
       je        short M06_L63
       movzx     ecx,word ptr [r14+0C]
       cmp       ecx,100
       jge       near ptr M06_L71
       cmp       ecx,100
       jae       near ptr M06_L73
       mov       rax,7FFCC7416098
       test      byte ptr [rax+rcx],80
       jne       near ptr M06_L74
M06_L62:
       mov       ecx,[r14+8]
       dec       ecx
       cmp       ecx,[r14+8]
       jae       near ptr M06_L73
       mov       ecx,[r14+8]
       dec       ecx
       movzx     ecx,word ptr [r14+rcx*2+0C]
       cmp       ecx,100
       jge       near ptr M06_L72
       cmp       ecx,100
       jae       near ptr M06_L73
       mov       rax,7FFCC7416098
       test      byte ptr [rax+rcx],80
       jne       near ptr M06_L74
M06_L63:
       mov       r8,r14
M06_L64:
       mov       [rbp-70],r8
       jmp       near ptr M06_L75
M06_L65:
       mov       ecx,r14d
       call      qword ptr [7FFC68C35950]
       mov       rdx,rax
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFC6879F228]; System.Text.StringBuilder.Append(System.String)
       mov       rcx,rax
       mov       edx,20
       cmp       [rcx],ecx
       call      qword ptr [7FFC6879F180]; System.Text.StringBuilder.Append(Char)
       mov       r15,rax
       call      qword ptr [7FFC68C359E0]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Thousand()
       mov       rdx,rax
       mov       rcx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFC6879F228]; System.Text.StringBuilder.Append(System.String)
       mov       rcx,rax
       mov       edx,20
       cmp       [rcx],ecx
       call      qword ptr [7FFC6879F180]; System.Text.StringBuilder.Append(Char)
       imul      eax,r14d,3E8
       sub       esi,eax
       jmp       near ptr M06_L56
M06_L66:
       mov       ecx,r14d
       call      qword ptr [7FFC68C35950]
       mov       rdx,rax
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFC6879F228]; System.Text.StringBuilder.Append(System.String)
       mov       rcx,rax
       mov       edx,20
       cmp       [rcx],ecx
       call      qword ptr [7FFC6879F180]; System.Text.StringBuilder.Append(Char)
       mov       r15,rax
       call      qword ptr [7FFC68C359F8]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Hundred()
       mov       rdx,rax
       mov       rcx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFC6879F228]; System.Text.StringBuilder.Append(System.String)
       mov       rcx,rax
       mov       edx,20
       cmp       [rcx],ecx
       call      qword ptr [7FFC6879F180]; System.Text.StringBuilder.Append(Char)
       imul      eax,r14d,64
       sub       esi,eax
       jmp       near ptr M06_L57
M06_L67:
       call      qword ptr [7FFC68C35A28]; DotNetTips.Spargine.Extensions.Properties.Resources.get_AndLowerCase()
       mov       rdx,rax
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFC6879F228]; System.Text.StringBuilder.Append(System.String)
       mov       rcx,rax
       mov       edx,20
       cmp       [rcx],ecx
       call      qword ptr [7FFC6879F180]; System.Text.StringBuilder.Append(Char)
       jmp       near ptr M06_L58
M06_L68:
       mov       rdx,12DDF401DD0
       mov       r14,[rdx]
       cmp       esi,14
       jae       near ptr M06_L73
       mov       edx,esi
       mov       rdx,[r14+rdx*8+10]
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFC6879F228]; System.Text.StringBuilder.Append(System.String)
       jmp       near ptr M06_L61
M06_L69:
       mov       edx,431BDE83
       mov       eax,edx
       imul      esi
       mov       ecx,edx
       shr       ecx,1F
       sar       edx,12
       add       ecx,edx
       call      qword ptr [7FFC68C35950]
       mov       rdx,rax
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFC6879F228]; System.Text.StringBuilder.Append(System.String)
       mov       rcx,rax
       mov       edx,20
       cmp       [rcx],ecx
       call      qword ptr [7FFC6879F180]; System.Text.StringBuilder.Append(Char)
       mov       r14,rax
       call      qword ptr [7FFC68C359C8]
       mov       rdx,rax
       mov       rcx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFC6879F228]; System.Text.StringBuilder.Append(System.String)
       mov       rcx,rax
       mov       edx,20
       cmp       [rcx],ecx
       call      qword ptr [7FFC6879F180]; System.Text.StringBuilder.Append(Char)
       mov       edx,431BDE83
       mov       eax,edx
       imul      esi
       mov       eax,edx
       shr       eax,1F
       sar       edx,12
       add       eax,edx
       imul      eax,0F4240
       sub       esi,eax
       jmp       near ptr M06_L55
M06_L70:
       mov       rcx,rdi
       mov       edx,2D
       call      qword ptr [7FFC6879F3A8]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M06_L60
M06_L71:
       call      qword ptr [7FFC68C3E8B0]
       test      eax,eax
       jne       short M06_L74
       jmp       near ptr M06_L62
M06_L72:
       call      qword ptr [7FFC68C3E8B0]
       test      eax,eax
       jne       short M06_L74
       jmp       near ptr M06_L63
M06_L73:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M06_L74:
       mov       rcx,r14
       mov       edx,3
       call      qword ptr [7FFC68C3E8C8]
       mov       r8,rax
       jmp       near ptr M06_L64
M06_L75:
       call      M06_L153
       nop
       mov       r8,[rbp-70]
       mov       rbx,[rbp-38]
       cmp       [rbx],bl
       test      r8,r8
       je        short M06_L78
       lea       rdx,[r8+0C]
       mov       esi,[r8+8]
       test      esi,esi
       je        short M06_L78
       mov       rdi,[rbx+8]
       mov       r14d,[rbx+18]
       lea       ecx,[r14+rsi]
       cmp       ecx,[rdi+8]
       jbe       short M06_L76
       mov       rcx,rbx
       mov       r8d,esi
       call      qword ptr [7FFC6879F1E0]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M06_L78
M06_L76:
       movsxd    r8,r14d
       lea       rcx,[rdi+r8*2+10]
       cmp       esi,2
       jle       near ptr M06_L80
       mov       r8d,esi
       add       r8,r8
       call      qword ptr [7FFC68625818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M06_L77:
       add       esi,r14d
       mov       [rbx+18],esi
M06_L78:
       mov       ecx,[rbx+18]
       mov       rdx,[rbx+8]
       cmp       [rdx+8],ecx
       jbe       near ptr M06_L116
       cmp       ecx,[rdx+8]
       jae       near ptr M06_L114
       mov       word ptr [rdx+rcx*2+10],20
       inc       dword ptr [rbx+18]
M06_L79:
       call      qword ptr [7FFC68C359F8]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Hundred()
       test      rax,rax
       je        short M06_L84
       lea       rdx,[rax+0C]
       mov       esi,[rax+8]
       test      esi,esi
       je        short M06_L84
       mov       rdi,[rbx+8]
       mov       r14d,[rbx+18]
       lea       ecx,[r14+rsi]
       cmp       ecx,[rdi+8]
       ja        short M06_L81
       movsxd    r8,r14d
       lea       rcx,[rdi+r8*2+10]
       cmp       esi,2
       jg        short M06_L82
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       esi,2
       jne       short M06_L83
       movzx     edx,word ptr [rdx+2]
       mov       [rcx+2],dx
       jmp       short M06_L83
M06_L80:
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       esi,2
       jne       short M06_L77
       movzx     edx,word ptr [rdx+2]
       mov       [rcx+2],dx
       jmp       near ptr M06_L77
M06_L81:
       mov       rcx,rbx
       mov       r8d,esi
       call      qword ptr [7FFC6879F1E0]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M06_L84
M06_L82:
       mov       r8d,esi
       add       r8,r8
       call      qword ptr [7FFC68625818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M06_L83:
       add       esi,r14d
       mov       [rbx+18],esi
M06_L84:
       mov       ecx,[rbx+18]
       mov       rdx,[rbx+8]
       cmp       [rdx+8],ecx
       jbe       near ptr M06_L117
       cmp       ecx,[rdx+8]
       jae       near ptr M06_L114
       mov       word ptr [rdx+rcx*2+10],20
       inc       dword ptr [rbx+18]
M06_L85:
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
       jmp       near ptr M06_L07
M06_L86:
       call      qword ptr [7FFC68C35A28]; DotNetTips.Spargine.Extensions.Properties.Resources.get_AndLowerCase()
       mov       rdx,rax
       test      rdx,rdx
       je        short M06_L87
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,rbx
       call      qword ptr [7FFC6879F150]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M06_L87:
       mov       ecx,[rbx+18]
       mov       rdx,[rbx+8]
       cmp       [rdx+8],ecx
       jbe       near ptr M06_L118
       cmp       ecx,[rdx+8]
       jae       near ptr M06_L114
       mov       word ptr [rdx+rcx*2+10],20
       inc       dword ptr [rbx+18]
       jmp       near ptr M06_L08
M06_L88:
       mov       rcx,rbx
       mov       r8d,esi
       call      qword ptr [7FFC6879F1E0]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M06_L91
M06_L89:
       mov       r8d,esi
       add       r8,r8
       call      qword ptr [7FFC68625818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M06_L90:
       add       esi,r14d
       mov       [rbx+18],esi
M06_L91:
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
       jle       near ptr M06_L97
       mov       ecx,[rbx+18]
       mov       rdx,[rbx+8]
       cmp       [rdx+8],ecx
       jbe       near ptr M06_L119
       cmp       ecx,[rdx+8]
       jae       near ptr M06_L114
       mov       word ptr [rdx+rcx*2+10],2D
       inc       dword ptr [rbx+18]
M06_L92:
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
       mov       rax,12DDF401DD0
       mov       r14,[rax]
       cmp       edx,14
       jae       near ptr M06_L114
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
       mov       ecx,edx
       mov       rcx,[r14+rcx*8+10]
       test      rcx,rcx
       je        near ptr M06_L97
       lea       rdx,[rcx+0C]
       mov       r14d,[rcx+8]
       test      r14d,r14d
       je        near ptr M06_L97
       mov       rsi,[rbx+8]
       mov       edi,[rbx+18]
       lea       ecx,[rdi+r14]
       cmp       ecx,[rsi+8]
       jbe       short M06_L93
       mov       rcx,rbx
       mov       r8d,r14d
       call      qword ptr [7FFC6879F1E0]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M06_L97
M06_L93:
       movsxd    r8,edi
       lea       rcx,[rsi+r8*2+10]
       cmp       r14d,2
       jle       short M06_L95
       mov       r8d,r14d
       add       r8,r8
       call      qword ptr [7FFC68625818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M06_L94:
       add       edi,r14d
       mov       [rbx+18],edi
       jmp       short M06_L97
M06_L95:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       r14d,2
       jne       short M06_L94
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M06_L94
M06_L96:
       mov       r8,12DDF401DD0
       mov       r14,[r8]
       cmp       dword ptr [rbp+10],14
       jae       near ptr M06_L114
       mov       r8d,[rbp+10]
       mov       rdx,[r14+r8*8+10]
       test      rdx,rdx
       je        short M06_L97
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,rbx
       call      qword ptr [7FFC6879F150]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       nop
M06_L97:
       mov       rbx,[rbp-38]
       mov       rcx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FFC68812100]; System.Text.StringBuilder.ToString()
       mov       r14,rax
       cmp       dword ptr [r14+8],0
       je        short M06_L99
       movzx     ecx,word ptr [r14+0C]
       cmp       ecx,100
       jge       near ptr M06_L120
       cmp       ecx,100
       jae       near ptr M06_L114
       mov       rax,7FFCC7416098
       test      byte ptr [rax+rcx],80
       jne       near ptr M06_L122
M06_L98:
       mov       ecx,[r14+8]
       dec       ecx
       cmp       ecx,[r14+8]
       jae       near ptr M06_L114
       mov       ecx,[r14+8]
       dec       ecx
       movzx     ecx,word ptr [r14+rcx*2+0C]
       cmp       ecx,100
       jge       near ptr M06_L121
       cmp       ecx,100
       jae       near ptr M06_L114
       mov       rax,7FFCC7416098
       test      byte ptr [rax+rcx],80
       jne       near ptr M06_L122
M06_L99:
       mov       rcx,r14
M06_L100:
       mov       [rbp-40],rcx
       jmp       near ptr M06_L123
M06_L101:
       mov       ecx,[rbp+10]
       imul      rsi,rcx,431BDE83
       shr       rsi,32
       mov       rcx,12DDF401DC0
       mov       rcx,[rcx]
       call      qword ptr [7FFC6884FEE8]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].get_Value()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp-50],rax
       mov       ecx,esi
       imul      rcx,431BDE83
       shr       rcx,32
       test      ecx,ecx
       jle       short M06_L102
       mov       ecx,esi
       imul      rcx,431BDE83
       shr       rcx,32
       call      qword ptr [7FFC68C35950]
       mov       rdx,rax
       mov       rcx,[rbp-50]
       cmp       [rcx],ecx
       call      qword ptr [7FFC6879F228]; System.Text.StringBuilder.Append(System.String)
       mov       rcx,rax
       mov       edx,20
       cmp       [rcx],ecx
       call      qword ptr [7FFC6879F180]; System.Text.StringBuilder.Append(Char)
       mov       rdi,rax
       call      qword ptr [7FFC68C359C8]
       mov       rdx,rax
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFC6879F228]; System.Text.StringBuilder.Append(System.String)
       mov       rcx,rax
       mov       edx,20
       cmp       [rcx],ecx
       call      qword ptr [7FFC6879F180]; System.Text.StringBuilder.Append(Char)
       mov       eax,esi
       imul      rax,431BDE83
       shr       rax,32
       imul      eax,0F4240
       sub       esi,eax
M06_L102:
       mov       edx,10624DD3
       mov       eax,edx
       imul      esi
       mov       eax,edx
       shr       eax,1F
       sar       edx,6
       add       eax,edx
       test      eax,eax
       jle       short M06_L103
       mov       edx,10624DD3
       mov       eax,edx
       imul      esi
       mov       ecx,edx
       shr       ecx,1F
       sar       edx,6
       add       ecx,edx
       call      qword ptr [7FFC68C35950]
       mov       rdx,rax
       mov       rcx,[rbp-50]
       cmp       [rcx],ecx
       call      qword ptr [7FFC6879F228]; System.Text.StringBuilder.Append(System.String)
       mov       rcx,rax
       mov       edx,20
       cmp       [rcx],ecx
       call      qword ptr [7FFC6879F180]; System.Text.StringBuilder.Append(Char)
       mov       rdi,rax
       call      qword ptr [7FFC68C359E0]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Thousand()
       mov       rdx,rax
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFC6879F228]; System.Text.StringBuilder.Append(System.String)
       mov       rcx,rax
       mov       edx,20
       cmp       [rcx],ecx
       call      qword ptr [7FFC6879F180]; System.Text.StringBuilder.Append(Char)
       mov       edx,10624DD3
       mov       eax,edx
       imul      esi
       mov       eax,edx
       shr       eax,1F
       sar       edx,6
       add       eax,edx
       imul      eax,3E8
       sub       esi,eax
M06_L103:
       mov       edx,51EB851F
       mov       eax,edx
       imul      esi
       mov       eax,edx
       shr       eax,1F
       sar       edx,5
       add       eax,edx
       test      eax,eax
       jle       short M06_L104
       mov       edx,51EB851F
       mov       eax,edx
       imul      esi
       mov       ecx,edx
       shr       ecx,1F
       sar       edx,5
       add       ecx,edx
       call      qword ptr [7FFC68C35950]
       mov       rdx,rax
       mov       rcx,[rbp-50]
       cmp       [rcx],ecx
       call      qword ptr [7FFC6879F228]; System.Text.StringBuilder.Append(System.String)
       mov       rcx,rax
       mov       edx,20
       cmp       [rcx],ecx
       call      qword ptr [7FFC6879F180]; System.Text.StringBuilder.Append(Char)
       mov       rdi,rax
       call      qword ptr [7FFC68C359F8]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Hundred()
       mov       rdx,rax
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFC6879F228]; System.Text.StringBuilder.Append(System.String)
       mov       rcx,rax
       mov       edx,20
       cmp       [rcx],ecx
       call      qword ptr [7FFC6879F180]; System.Text.StringBuilder.Append(Char)
       mov       edx,51EB851F
       mov       eax,edx
       imul      esi
       mov       eax,edx
       shr       eax,1F
       sar       edx,5
       add       eax,edx
       imul      eax,64
       sub       esi,eax
M06_L104:
       test      esi,esi
       jle       near ptr M06_L108
       mov       rcx,[rbp-50]
       mov       eax,[rcx+1C]
       add       eax,[rcx+18]
       test      eax,eax
       jle       short M06_L105
       call      qword ptr [7FFC68C35A28]; DotNetTips.Spargine.Extensions.Properties.Resources.get_AndLowerCase()
       mov       rdx,rax
       mov       rcx,[rbp-50]
       call      qword ptr [7FFC6879F228]; System.Text.StringBuilder.Append(System.String)
       mov       rcx,rax
       mov       edx,20
       cmp       [rcx],ecx
       call      qword ptr [7FFC6879F180]; System.Text.StringBuilder.Append(Char)
M06_L105:
       cmp       esi,14
       jge       short M06_L107
       mov       rdx,12DDF401DD0
       mov       r14,[rdx]
       cmp       esi,14
       jae       short M06_L106
       mov       edx,esi
       mov       rdx,[r14+rdx*8+10]
       mov       rcx,[rbp-50]
       call      qword ptr [7FFC6879F228]; System.Text.StringBuilder.Append(System.String)
       jmp       near ptr M06_L108
M06_L106:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M06_L107:
       mov       edx,66666667
       mov       eax,edx
       imul      esi
       mov       eax,edx
       shr       eax,1F
       sar       edx,2
       add       eax,edx
       mov       rdx,12DDF401DC8
       mov       rdi,[rdx]
       cmp       eax,0A
       jae       short M06_L106
       mov       edx,66666667
       mov       eax,edx
       imul      esi
       mov       eax,edx
       shr       eax,1F
       sar       edx,2
       add       edx,eax
       mov       rdx,[rdi+rdx*8+10]
       mov       rcx,[rbp-50]
       call      qword ptr [7FFC6879F228]; System.Text.StringBuilder.Append(System.String)
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
       jle       short M06_L108
       mov       rcx,[rbp-50]
       mov       edx,2D
       call      qword ptr [7FFC6879F180]; System.Text.StringBuilder.Append(Char)
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
       mov       rax,12DDF401DD0
       mov       r14,[rax]
       cmp       edx,14
       jae       near ptr M06_L106
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
       call      qword ptr [7FFC6879F228]; System.Text.StringBuilder.Append(System.String)
M06_L108:
       mov       rcx,[rbp-50]
       cmp       [rcx],ecx
       call      qword ptr [7FFC68812100]; System.Text.StringBuilder.ToString()
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFC68A343D8]; System.String.Trim()
       mov       rdi,rax
       mov       rcx,12DDF401DC0
       mov       rcx,[rcx]
       call      qword ptr [7FFC6884FEE8]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].get_Value()
       mov       r14,rax
       mov       rcx,[rbp-50]
       xor       edx,edx
       call      qword ptr [7FFC68BAD7D0]; System.Text.StringBuilder.set_Length(Int32)
       mov       rcx,r14
       mov       rdx,[rbp-50]
       mov       rax,[r14]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       rdx,rdi
       mov       rcx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FFC6879F228]; System.Text.StringBuilder.Append(System.String)
       mov       rcx,rax
       mov       edx,20
       cmp       [rcx],ecx
       call      qword ptr [7FFC6879F180]; System.Text.StringBuilder.Append(Char)
       mov       rbx,rax
       call      qword ptr [7FFC68C359C8]
       mov       rdx,rax
       mov       rcx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FFC6879F228]; System.Text.StringBuilder.Append(System.String)
       mov       rcx,rax
       mov       edx,20
       cmp       [rcx],ecx
       call      qword ptr [7FFC6879F180]; System.Text.StringBuilder.Append(Char)
       mov       eax,[rbp+10]
       imul      rax,431BDE83
       shr       rax,32
       imul      eax,0F4240
       mov       edx,[rbp+10]
       sub       edx,eax
       mov       [rbp+10],edx
       jmp       near ptr M06_L05
M06_L109:
       call      qword ptr [7FFC6884FF48]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rcx,rax
       jmp       near ptr M06_L10
M06_L110:
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rsi,rax
       jmp       near ptr M06_L11
M06_L111:
       mov       rcx,rbx
       mov       edx,20
       call      qword ptr [7FFC6879F3A8]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M06_L45
M06_L112:
       mov       rcx,rbx
       mov       edx,20
       call      qword ptr [7FFC6879F3A8]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M06_L51
M06_L113:
       call      qword ptr [7FFC6884FF48]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rcx,rax
       jmp       near ptr M06_L53
M06_L114:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M06_L115:
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rdi,rax
       jmp       near ptr M06_L54
M06_L116:
       mov       rcx,rbx
       mov       edx,20
       call      qword ptr [7FFC6879F3A8]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M06_L79
M06_L117:
       mov       rcx,rbx
       mov       edx,20
       call      qword ptr [7FFC6879F3A8]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M06_L85
M06_L118:
       mov       rcx,rbx
       mov       edx,20
       call      qword ptr [7FFC6879F3A8]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M06_L08
M06_L119:
       mov       rcx,rbx
       mov       edx,2D
       call      qword ptr [7FFC6879F3A8]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M06_L92
M06_L120:
       call      qword ptr [7FFC68C3E8B0]
       test      eax,eax
       jne       short M06_L122
       jmp       near ptr M06_L98
M06_L121:
       call      qword ptr [7FFC68C3E8B0]
       test      eax,eax
       je        near ptr M06_L99
M06_L122:
       mov       rcx,r14
       mov       edx,3
       call      qword ptr [7FFC68C3E8C8]
       mov       rcx,rax
       jmp       near ptr M06_L100
M06_L123:
       call      M06_L161
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
M06_L124:
       mov       rsi,[rbx+18]
       mov       rdi,[rsi+18]
       lea       rdx,[rbp-30]
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFC68BAD6C8]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       jne       short M06_L125
       cmp       qword ptr [rdi+10],0
       je        short M06_L126
       lea       rdx,[rbp-30]
       mov       rcx,rsi
       call      qword ptr [7FFC68C3E688]
       test      eax,eax
       je        short M06_L127
M06_L125:
       add       rbx,2C
       lock dec  dword ptr [rbx]
       jmp       near ptr M06_L02
M06_L126:
       xor       ecx,ecx
       mov       [rbp-30],rcx
M06_L127:
       mov       rax,[rbx+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       rbx,rax
       jmp       near ptr M06_L03
M06_L128:
       call      qword ptr [7FFC68C35968]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Zero()
       nop
       add       rsp,68
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M06_L129:
       call      qword ptr [7FFC68C35980]
       mov       rbx,rax
       mov       ecx,1
       call      qword ptr [7FFC68626670]; System.String.FastAllocateString(IntPtr)
       mov       rsi,rax
       mov       word ptr [rsi+0C],20
       mov       ecx,[rbp+10]
       mov       edi,ecx
       neg       edi
       js        short M06_L131
       mov       r14d,edi
       test      r14d,r14d
       jne       short M06_L130
       call      qword ptr [7FFC68C35968]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Zero()
       mov       rdi,rax
       jmp       near ptr M06_L141
M06_L130:
       test      r14d,r14d
       jge       short M06_L133
       call      qword ptr [7FFC68C35980]
       mov       r14,rax
       mov       ecx,1
       call      qword ptr [7FFC68626670]; System.String.FastAllocateString(IntPtr)
       mov       r15,rax
       mov       word ptr [r15+0C],20
       mov       ecx,edi
       neg       ecx
       jns       short M06_L132
M06_L131:
       call      qword ptr [7FFC68C3EC58]
       int       3
M06_L132:
       call      qword ptr [7FFC68C35950]
       mov       r8,rax
       mov       rdx,r15
       mov       rcx,r14
       call      qword ptr [7FFC68627828]; System.String.Concat(System.String, System.String, System.String)
       mov       rdi,rax
       jmp       near ptr M06_L141
M06_L133:
       mov       rcx,12DDF401DC0
       mov       rcx,[rcx]
       call      qword ptr [7FFC6884FEE8]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].get_Value()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp-48],rax
       mov       ecx,r14d
       imul      rcx,431BDE83
       shr       rcx,32
       test      ecx,ecx
       jle       short M06_L134
       mov       ecx,edi
       imul      rcx,431BDE83
       shr       rcx,32
       call      qword ptr [7FFC68C35950]
       mov       rdx,rax
       mov       rcx,[rbp-48]
       cmp       [rcx],ecx
       call      qword ptr [7FFC6879F228]; System.Text.StringBuilder.Append(System.String)
       mov       rcx,rax
       mov       edx,20
       cmp       [rcx],ecx
       call      qword ptr [7FFC6879F180]; System.Text.StringBuilder.Append(Char)
       mov       r14,rax
       call      qword ptr [7FFC68C359C8]
       mov       rdx,rax
       mov       rcx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFC6879F228]; System.Text.StringBuilder.Append(System.String)
       mov       rcx,rax
       mov       edx,20
       cmp       [rcx],ecx
       call      qword ptr [7FFC6879F180]; System.Text.StringBuilder.Append(Char)
       mov       eax,edi
       imul      rax,431BDE83
       shr       rax,32
       imul      eax,0F4240
       mov       r14d,edi
       sub       r14d,eax
M06_L134:
       mov       edx,10624DD3
       mov       eax,edx
       imul      r14d
       mov       eax,edx
       shr       eax,1F
       sar       edx,6
       add       eax,edx
       test      eax,eax
       jle       near ptr M06_L135
       mov       edx,10624DD3
       mov       eax,edx
       imul      r14d
       mov       ecx,edx
       shr       ecx,1F
       sar       edx,6
       add       ecx,edx
       call      qword ptr [7FFC68C35950]
       mov       rdx,rax
       mov       rcx,[rbp-48]
       cmp       [rcx],ecx
       call      qword ptr [7FFC6879F228]; System.Text.StringBuilder.Append(System.String)
       mov       rcx,rax
       mov       edx,20
       cmp       [rcx],ecx
       call      qword ptr [7FFC6879F180]; System.Text.StringBuilder.Append(Char)
       mov       rdi,rax
       call      qword ptr [7FFC68C359E0]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Thousand()
       mov       rdx,rax
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFC6879F228]; System.Text.StringBuilder.Append(System.String)
       mov       rcx,rax
       mov       edx,20
       cmp       [rcx],ecx
       call      qword ptr [7FFC6879F180]; System.Text.StringBuilder.Append(Char)
       mov       edx,10624DD3
       mov       eax,edx
       imul      r14d
       mov       eax,edx
       shr       eax,1F
       sar       edx,6
       add       eax,edx
       imul      eax,3E8
       sub       r14d,eax
M06_L135:
       mov       edx,51EB851F
       mov       eax,edx
       imul      r14d
       mov       eax,edx
       shr       eax,1F
       sar       edx,5
       add       eax,edx
       test      eax,eax
       jle       short M06_L136
       mov       edx,51EB851F
       mov       eax,edx
       imul      r14d
       mov       ecx,edx
       shr       ecx,1F
       sar       edx,5
       add       ecx,edx
       call      qword ptr [7FFC68C35950]
       mov       rdx,rax
       mov       rcx,[rbp-48]
       cmp       [rcx],ecx
       call      qword ptr [7FFC6879F228]; System.Text.StringBuilder.Append(System.String)
       mov       rcx,rax
       mov       edx,20
       cmp       [rcx],ecx
       call      qword ptr [7FFC6879F180]; System.Text.StringBuilder.Append(Char)
       mov       rdi,rax
       call      qword ptr [7FFC68C359F8]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Hundred()
       mov       rdx,rax
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFC6879F228]; System.Text.StringBuilder.Append(System.String)
       mov       rcx,rax
       mov       edx,20
       cmp       [rcx],ecx
       call      qword ptr [7FFC6879F180]; System.Text.StringBuilder.Append(Char)
       mov       edx,51EB851F
       mov       eax,edx
       imul      r14d
       mov       eax,edx
       shr       eax,1F
       sar       edx,5
       add       eax,edx
       imul      eax,64
       sub       r14d,eax
M06_L136:
       test      r14d,r14d
       jle       near ptr M06_L140
       mov       rcx,[rbp-48]
       mov       eax,[rcx+1C]
       add       eax,[rcx+18]
       test      eax,eax
       jle       short M06_L137
       call      qword ptr [7FFC68C35A28]; DotNetTips.Spargine.Extensions.Properties.Resources.get_AndLowerCase()
       mov       rdx,rax
       mov       rcx,[rbp-48]
       call      qword ptr [7FFC6879F228]; System.Text.StringBuilder.Append(System.String)
       mov       rcx,rax
       mov       edx,20
       cmp       [rcx],ecx
       call      qword ptr [7FFC6879F180]; System.Text.StringBuilder.Append(Char)
M06_L137:
       cmp       r14d,14
       jge       short M06_L139
       mov       rdx,12DDF401DD0
       mov       r8,[rdx]
       mov       edx,r14d
       mov       rdx,[r8+rdx*8+10]
       mov       rcx,[rbp-48]
       call      qword ptr [7FFC6879F228]; System.Text.StringBuilder.Append(System.String)
       jmp       near ptr M06_L140
M06_L138:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M06_L139:
       mov       edx,0CCCCCCCD
       mov       eax,r14d
       imul      rdx,rax
       shr       rdx,23
       mov       rax,12DDF401DC8
       mov       r8,[rax]
       cmp       edx,0A
       jae       short M06_L138
       mov       edx,0CCCCCCCD
       mov       eax,r14d
       imul      rdx,rax
       shr       rdx,23
       mov       edx,edx
       mov       rdx,[r8+rdx*8+10]
       mov       rcx,[rbp-48]
       call      qword ptr [7FFC6879F228]; System.Text.StringBuilder.Append(System.String)
       mov       ecx,0CCCCCCCD
       mov       edx,r14d
       imul      rcx,rdx
       shr       rcx,23
       lea       ecx,[rcx+rcx*4]
       add       ecx,ecx
       mov       edx,r14d
       sub       edx,ecx
       test      edx,edx
       jle       short M06_L140
       mov       rcx,[rbp-48]
       mov       edx,2D
       call      qword ptr [7FFC6879F180]; System.Text.StringBuilder.Append(Char)
       mov       rcx,rax
       mov       edx,0CCCCCCCD
       mov       eax,r14d
       imul      rdx,rax
       shr       rdx,23
       lea       edx,[rdx+rdx*4]
       add       edx,edx
       mov       eax,r14d
       sub       eax,edx
       mov       rdx,12DDF401DD0
       mov       rdx,[rdx]
       mov       r8,rdx
       cmp       eax,14
       jae       near ptr M06_L138
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
       call      qword ptr [7FFC6879F228]; System.Text.StringBuilder.Append(System.String)
M06_L140:
       mov       rcx,[rbp-48]
       cmp       [rcx],ecx
       call      qword ptr [7FFC68812100]; System.Text.StringBuilder.ToString()
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFC68A343D8]; System.String.Trim()
       mov       rdi,rax
       mov       rcx,12DDF401DC0
       mov       rcx,[rcx]
       call      qword ptr [7FFC6884FEE8]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].get_Value()
       mov       r14,rax
       mov       rcx,[rbp-48]
       xor       edx,edx
       call      qword ptr [7FFC68BAD7D0]; System.Text.StringBuilder.set_Length(Int32)
       mov       rcx,r14
       mov       rdx,[rbp-48]
       mov       rax,[r14]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
M06_L141:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       call      qword ptr [7FFC68627828]; System.String.Concat(System.String, System.String, System.String)
       nop
       add       rsp,68
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M06_L142:
       call      qword ptr [7FFC6884FF48]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rbx,rax
       jmp       near ptr M06_L01
M06_L143:
       call      qword ptr [7FFC68C3E550]
       int       3
M06_L144:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rbx,rax
       jmp       near ptr M06_L04
       sub       rsp,28
       mov       rcx,12DDF401DC0
       mov       rcx,[rcx]
       cmp       [rcx],ecx
       call      qword ptr [7FFC6884FEE8]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].get_Value()
       mov       rdi,rax
       mov       rcx,[rbp-50]
       cmp       [rcx],cl
       xor       edx,edx
       call      qword ptr [7FFC68BAD7D0]; System.Text.StringBuilder.set_Length(Int32)
       mov       rcx,rdi
       mov       rdx,[rbp-50]
       mov       rax,[rdi]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       add       rsp,28
       ret
M06_L145:
       sub       rsp,28
       mov       rcx,12DDF401DC0
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0
       je        short M06_L146
       call      qword ptr [7FFC6884FF48]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rbx,rax
       jmp       short M06_L147
M06_L146:
       mov       rbx,[rcx+18]
M06_L147:
       mov       rdx,[rbp-58]
       cmp       [rdx],dl
       mov       rcx,rdx
       xor       edx,edx
       call      qword ptr [7FFC68BAD7D0]; System.Text.StringBuilder.set_Length(Int32)
       mov       rdx,offset MT_Microsoft.Extensions.ObjectPool.DefaultObjectPool<System.Text.StringBuilder>
       cmp       [rbx],rdx
       jne       near ptr M06_L151
       mov       rax,[rbx+10]
       mov       rdx,[rbp-58]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       test      eax,eax
       je        near ptr M06_L152
       cmp       qword ptr [rbx+20],0
       jne       short M06_L149
       lea       rcx,[rbx+20]
       test      rcx,rcx
       jne       short M06_L148
       call      qword ptr [7FFC68C3E550]
       int       3
M06_L148:
       mov       rdx,[rbp-58]
       xor       r8d,r8d
       call      00007FFCC8253270
       test      rax,rax
       je        short M06_L152
M06_L149:
       lea       rcx,[rbx+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[rbx+28]
       jg        short M06_L150
       mov       rbx,[rbx+18]
       mov       rcx,[rbx+10]
       mov       rdx,[rbp-58]
       cmp       [rcx],ecx
       call      qword ptr [7FFC68C35EF0]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryEnqueue(System.__Canon)
       test      eax,eax
       jne       short M06_L152
       mov       rcx,rbx
       mov       rdx,[rbp-58]
       call      qword ptr [7FFC68C3E940]
       jmp       short M06_L152
M06_L150:
       add       rbx,2C
       lock dec  dword ptr [rbx]
       jmp       short M06_L152
M06_L151:
       mov       rcx,rbx
       mov       rdx,[rbp-58]
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
M06_L152:
       nop
       add       rsp,28
       ret
M06_L153:
       sub       rsp,28
       mov       rcx,12DDF401DC0
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0
       je        short M06_L154
       call      qword ptr [7FFC6884FF48]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rbx,rax
       jmp       short M06_L155
M06_L154:
       mov       rbx,[rcx+18]
M06_L155:
       mov       rdx,[rbp-68]
       cmp       [rdx],dl
       mov       rcx,rdx
       xor       edx,edx
       call      qword ptr [7FFC68BAD7D0]; System.Text.StringBuilder.set_Length(Int32)
       mov       rdx,offset MT_Microsoft.Extensions.ObjectPool.DefaultObjectPool<System.Text.StringBuilder>
       cmp       [rbx],rdx
       jne       near ptr M06_L159
       mov       rax,[rbx+10]
       mov       rdx,[rbp-68]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       test      eax,eax
       je        near ptr M06_L160
       cmp       qword ptr [rbx+20],0
       jne       short M06_L157
       lea       rcx,[rbx+20]
       test      rcx,rcx
       jne       short M06_L156
       call      qword ptr [7FFC68C3E550]
       int       3
M06_L156:
       mov       rdx,[rbp-68]
       xor       r8d,r8d
       call      00007FFCC8253270
       test      rax,rax
       je        short M06_L160
M06_L157:
       lea       rcx,[rbx+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[rbx+28]
       jg        short M06_L158
       mov       rbx,[rbx+18]
       mov       rcx,[rbx+10]
       mov       rdx,[rbp-68]
       cmp       [rcx],ecx
       call      qword ptr [7FFC68C35EF0]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryEnqueue(System.__Canon)
       test      eax,eax
       jne       short M06_L160
       mov       rcx,rbx
       mov       rdx,[rbp-68]
       call      qword ptr [7FFC68C3E940]
       jmp       short M06_L160
M06_L158:
       add       rbx,2C
       lock dec  dword ptr [rbx]
       jmp       short M06_L160
M06_L159:
       mov       rcx,rbx
       mov       rdx,[rbp-68]
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
M06_L160:
       nop
       add       rsp,28
       ret
M06_L161:
       sub       rsp,28
       mov       rcx,12DDF401DC0
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0
       je        short M06_L162
       call      qword ptr [7FFC6884FF48]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rbx,rax
       jmp       short M06_L163
M06_L162:
       mov       rbx,[rcx+18]
M06_L163:
       mov       rsi,[rbp-38]
       cmp       dword ptr [rsi+20],0
       jge       short M06_L164
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,3AD
       mov       rdx,7FFC68564000
       call      qword ptr [7FFC688477B0]
       mov       rbx,rax
       call      qword ptr [7FFC68C3E4C0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFC6884D8F0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M06_L164:
       cmp       qword ptr [rsi+10],0
       jne       short M06_L165
       xor       ecx,ecx
       mov       [rsi+18],rcx
       jmp       near ptr M06_L172
M06_L165:
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       mov       r8d,ecx
       neg       r8d
       test      r8d,r8d
       jle       short M06_L166
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFC68C3E4D8]
       jmp       near ptr M06_L172
M06_L166:
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFC68C3E4F0]
       mov       rdi,rax
       cmp       rdi,rsi
       je        near ptr M06_L171
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
       jge       short M06_L169
       cmp       ecx,400
       jge       short M06_L167
       movsxd    rdx,ecx
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
       jmp       short M06_L168
M06_L167:
       xor       edx,edx
       call      qword ptr [7FFC68BA6F40]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       r14,rax
M06_L168:
       mov       rcx,[rdi+8]
       mov       r8d,[rdi+18]
       mov       rdx,r14
       call      qword ptr [7FFC68795050]; System.Array.Copy(System.Array, System.Array, Int32)
       lea       rcx,[rsi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M06_L170
M06_L169:
       mov       rdx,[rdi+8]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
M06_L170:
       mov       rdx,[rdi+10]
       lea       rcx,[rsi+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rdi+1C]
       mov       [rsi+1C],ecx
M06_L171:
       mov       ecx,[rdi+1C]
       neg       ecx
       mov       [rsi+18],ecx
M06_L172:
       mov       rdx,offset MT_Microsoft.Extensions.ObjectPool.DefaultObjectPool<System.Text.StringBuilder>
       cmp       [rbx],rdx
       jne       short M06_L176
       mov       rax,[rbx+10]
       mov       rdx,rsi
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       test      eax,eax
       je        short M06_L177
       cmp       qword ptr [rbx+20],0
       jne       short M06_L174
       lea       rcx,[rbx+20]
       test      rcx,rcx
       jne       short M06_L173
       call      qword ptr [7FFC68C3E550]
       int       3
M06_L173:
       mov       rdx,rsi
       xor       r8d,r8d
       call      00007FFCC8253270
       test      rax,rax
       je        short M06_L177
M06_L174:
       lea       rcx,[rbx+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[rbx+28]
       jg        short M06_L175
       mov       rbx,[rbx+18]
       mov       rcx,[rbx+10]
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFC68C35EF0]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryEnqueue(System.__Canon)
       test      eax,eax
       jne       short M06_L177
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFC68C3E940]
       jmp       short M06_L177
M06_L175:
       add       rbx,2C
       lock dec  dword ptr [rbx]
       jmp       short M06_L177
M06_L176:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
M06_L177:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       mov       rcx,12DDF401DC0
       mov       rcx,[rcx]
       cmp       [rcx],ecx
       call      qword ptr [7FFC6884FEE8]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].get_Value()
       mov       rdi,rax
       mov       rcx,[rbp-48]
       cmp       [rcx],cl
       xor       edx,edx
       call      qword ptr [7FFC68BAD7D0]; System.Text.StringBuilder.set_Length(Int32)
       mov       rcx,rdi
       mov       rdx,[rbp-48]
       mov       rax,[rdi]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       add       rsp,28
       ret
; Total bytes of code 7443
```
```assembly
; DotNetTips.Spargine.Extensions.Properties.Resources.get_Thousand()
;                 return ResourceManager.GetString("Thousand", resourceCulture);
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,28
       call      qword ptr [7FFC68C35DD0]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,12DF5400168
       mov       r8,[r8]
       mov       rdx,16E742B0DC8
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
       call      qword ptr [7FFC68C35DD0]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,12DF5400168
       mov       r8,[r8]
       mov       rdx,16E742B0DF0
       mov       rax,[rax]
       mov       rax,[rax+48]
       add       rsp,28
       jmp       qword ptr [rax+28]
; Total bytes of code 51
```
```assembly
; System.Text.StringBuilder.Append(System.String)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       test      rdx,rdx
       je        short M09_L02
       lea       rax,[rdx+0C]
       mov       esi,[rdx+8]
       test      esi,esi
       je        short M09_L02
       mov       rdi,[rbx+8]
       mov       ebp,[rbx+18]
       lea       ecx,[rsi+rbp]
       cmp       ecx,[rdi+8]
       jbe       short M09_L00
       mov       rcx,rbx
       mov       rdx,rax
       mov       r8d,esi
       call      qword ptr [7FFC6879F1E0]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M09_L02
M09_L00:
       movsxd    r8,ebp
       lea       rcx,[rdi+r8*2+10]
       cmp       esi,2
       jle       short M09_L03
       mov       r8d,esi
       add       r8,r8
       mov       rdx,rax
       call      qword ptr [7FFC68625818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M09_L01:
       add       esi,ebp
       mov       [rbx+18],esi
M09_L02:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M09_L03:
       movzx     edx,word ptr [rax]
       mov       [rcx],dx
       cmp       esi,2
       jne       short M09_L01
       movzx     eax,word ptr [rax+2]
       mov       [rcx+2],ax
       jmp       short M09_L01
; Total bytes of code 125
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
       call      qword ptr [7FFC6879F3A8]; System.Text.StringBuilder.AppendWithExpansion(Char)
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
       jg        near ptr M11_L03
       cmp       eax,esi
       jl        near ptr M11_L03
       mov       rax,[rbx+8]
       mov       ebp,[rax+8]
       sub       ebp,ecx
       test      ebp,ebp
       jg        near ptr M11_L04
M11_L00:
       sub       esi,ebp
       mov       edx,[rbx+1C]
       lea       ecx,[rsi+rdx]
       mov       eax,[rbx+18]
       add       ecx,eax
       cmp       ecx,[rbx+20]
       jg        near ptr M11_L09
       cmp       ecx,esi
       jl        near ptr M11_L09
       add       edx,eax
       mov       ecx,edx
       mov       eax,1F40
       cmp       ecx,1F40
       cmovg     ecx,eax
       cmp       esi,ecx
       cmovge    ecx,esi
       add       edx,ecx
       cmp       edx,ecx
       jl        near ptr M11_L10
       cmp       ecx,400
       jge       near ptr M11_L11
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
       je        near ptr M11_L12
       lea       rcx,[r8+10]
       mov       r8d,[r8+8]
M11_L02:
       cmp       esi,r8d
       ja        near ptr M11_L13
       mov       r8d,esi
       add       r8,r8
       call      qword ptr [7FFC68625818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,19685
       mov       rdx,7FFC68564000
       call      qword ptr [7FFC688477B0]
       mov       rsi,rax
       call      qword ptr [7FFC68CC4B10]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFC6884D8F0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M11_L04:
       mov       rax,[rbx+8]
       test      rax,rax
       jne       short M11_L05
       test      ecx,ecx
       jne       short M11_L06
       xor       edx,edx
       xor       eax,eax
       jmp       short M11_L08
M11_L05:
       cmp       [rax+8],ecx
       jae       short M11_L07
M11_L06:
       call      qword ptr [7FFC68797198]
       int       3
M11_L07:
       mov       edx,ecx
       lea       rdx,[rax+rdx*2+10]
       mov       eax,[rax+8]
       sub       eax,ecx
M11_L08:
       cmp       ebp,eax
       ja        near ptr M11_L13
       mov       r8d,ebp
       add       r8,r8
       mov       rcx,rdx
       mov       rdx,rdi
       call      qword ptr [7FFC68625818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rdx,[rbx+8]
       mov       edx,[rdx+8]
       mov       [rbx+18],edx
       jmp       near ptr M11_L00
M11_L09:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,1969B
       mov       rdx,7FFC68564000
       call      qword ptr [7FFC688477B0]
       mov       rsi,rax
       call      qword ptr [7FFC68C3E4C0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFC6884D8F0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M11_L10:
       mov       rcx,offset MT_System.OutOfMemoryException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC68CC4B28]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M11_L11:
       xor       edx,edx
       call      qword ptr [7FFC68BA6F40]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       r14,rax
       jmp       near ptr M11_L01
M11_L12:
       xor       ecx,ecx
       xor       r8d,r8d
       jmp       near ptr M11_L02
M11_L13:
       call      qword ptr [7FFC68A3CBB8]
       int       3
; Total bytes of code 623
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
       call      qword ptr [7FFCC809E7B0]; Precode of System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFCC8083FD8]
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
       jmp       qword ptr [7FFC6884FF48]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
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
       mov       rdx,7FFC68564000
       call      qword ptr [7FFC688477B0]
       mov       rdx,rax
       mov       ecx,esi
       call      qword ptr [7FFC68C3E460]
       int       3
M14_L02:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FFC68564000
       call      qword ptr [7FFC688477B0]
       mov       rsi,rax
       call      qword ptr [7FFC68C3E4C0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFC6884D8F0]
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
       call      qword ptr [7FFC68C3E4D8]
       jmp       near ptr M14_L00
M14_L04:
       mov       rcx,rbx
       mov       edx,esi
       call      qword ptr [7FFC68C3E4F0]
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
       call      qword ptr [7FFC68BA6F40]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       rbp,rax
M14_L06:
       mov       rcx,[rdi+8]
       mov       r8d,[rdi+18]
       mov       rdx,rbp
       call      qword ptr [7FFC68795050]; System.Array.Copy(System.Array, System.Array, Int32)
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
       mov       rdx,7FFC68564000
       call      qword ptr [7FFC688477B0]
       mov       rsi,rax
       call      qword ptr [7FFC68C3E4C0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFC6884D8F0]
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
       call      qword ptr [7FFC68C3E4D8]
       jmp       near ptr M15_L00
M15_L06:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFC68C3E4F0]
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
       call      qword ptr [7FFC68BA6F40]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       rbp,rax
M15_L08:
       mov       rcx,[rdi+8]
       mov       r8d,[rdi+18]
       mov       rdx,rbp
       call      qword ptr [7FFC68795050]; System.Array.Copy(System.Array, System.Array, Int32)
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
       call      qword ptr [7FFC68C3E550]
       int       3
M15_L15:
       mov       rdx,rbx
       xor       r8d,r8d
       call      00007FFCC8253270
       test      rax,rax
       je        near ptr M15_L03
       jmp       near ptr M15_L01
M15_L16:
       test      r10d,r10d
       jge       near ptr M15_L02
       mov       rdx,rbx
       call      qword ptr [7FFC68C3E940]
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
       call      qword ptr [7FFC68C3E9B8]
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
       call      qword ptr [7FFC68C35DD0]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       mov       rax,12DF5400168
       mov       r8,[rax]
       mov       rdx,16E742B09D8
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
       jmp       near ptr 00007FFCC82B9D30
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
       call      qword ptr [7FFCC80969D8]; Precode of System.String.FastAllocateString(IntPtr)
       mov       r12,rax
       cmp       [r12],r12b
       lea       rax,[r12+0C]
       mov       [rsp+20],rax
       mov       rcx,rax
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFCC80988E8]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rbx,[rsp+20]
       lea       rcx,[rbx+r13*2]
       mov       r8d,r14d
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFCC80988E8]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       ebp,r14d
       movsxd    rcx,ebp
       lea       rcx,[rbx+rcx*2]
       mov       r8d,r15d
       add       r8,r8
       lea       rdx,[rdi+0C]
       call      qword ptr [7FFCC80988E8]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFCC809A448]
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
       call      qword ptr [7FFCC80A91B0]; Precode of System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ExecutionAndPublication(System.LazyHelper, Boolean)
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
       call      qword ptr [7FFCC809FC50]
       int       3
       mov       rcx,rbx
       call      qword ptr [7FFCC80A91A0]
       jmp       short M21_L01
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFCC80A91A8]; Precode of System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ViaFactory(System.Threading.LazyThreadSafetyMode)
       jmp       short M21_L01
       mov       rcx,[rbx]
       call      qword ptr [7FFCC8086838]
       mov       rcx,rax
       call      qword ptr [7FFCC808DE88]
       mov       rcx,rax
       call      qword ptr [7FFCC80AEFF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFCC80A91B8]
       jmp       near ptr M21_L01
       mov       rax,[rbx+10]
       test      rax,rax
       je        short M21_L05
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFCC80A91B8]
       jmp       near ptr M21_L01
M21_L05:
       mov       rcx,rbx
       call      qword ptr [7FFCC80A91C8]
       jmp       near ptr M21_L01
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,1
       call      qword ptr [7FFCC80A91B0]; Precode of System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ExecutionAndPublication(System.LazyHelper, Boolean)
       jmp       near ptr M21_L01
; Total bytes of code 269
```

