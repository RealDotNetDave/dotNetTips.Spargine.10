## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.NumericExtensionsBenchmark.ClampAboveMaximum()
       mov       rax,[rcx+90]
       mov       dword ptr [rax+38],64
       ret
; Total bytes of code 15
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.NumericExtensionsBenchmark.ClampBelowMinimum()
       mov       rax,[rcx+90]
       xor       ecx,ecx
       mov       [rax+38],ecx
       ret
; Total bytes of code 13
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.NumericExtensionsBenchmark.ClampWithinRange()
       mov       rax,[rcx+90]
       mov       dword ptr [rax+38],2A
       ret
; Total bytes of code 15
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.NumericExtensionsBenchmark.FormatTimeDoubleHours()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       vmovsd    xmm0,qword ptr [rbx+1A8]
       call      qword ptr [7FFC03C6DBF0]; DotNetTips.Spargine.Extensions.NumericExtensions.FormatTime(Double)
       mov       [rsp+28],rax
       mov       rbx,[rbx+90]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       ret
; Total bytes of code 67
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
; 		var stringBuilderPool = _stringBuilderPool.Value;
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var sb = stringBuilderPool.Get();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			if (timeSpan.Hours > 0)
; 			^^^^^^^^^^^^^^^^^^^^^^^
; 				_ = sb.Append(timeSpan.Hours).Append(timeSpan.Hours == 1 ? " hour" : " hours");
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			if (timeSpan.Minutes > 0)
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
; 				if (sb.Length > 0)
; 				^^^^^^^^^^^^^^^^^^
; 					_ = sb.Append(ControlChars.Space);
; 					^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 				_ = sb.Append(timeSpan.Minutes).Append(timeSpan.Minutes == 1 ? " minute" : " minutes");
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			if (timeSpan.Seconds > 0 || sb.Length == 0)
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 				if (sb.Length > 0)
; 				^^^^^^^^^^^^^^^^^^
; 					_ = sb.Append(ControlChars.Space);
; 					^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 				_ = sb.Append(timeSpan.Seconds).Append(timeSpan.Seconds == 1 ? " second" : " seconds");
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			return sb.ToString();
; 			^^^^^^^^^^^^^^^^^^^^^
; 	}
; 	^
; 			stringBuilderPool.Return(sb.Clear());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       xor       eax,eax
       mov       [rbp-0C8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-0C0],ymm4
       vmovdqu   ymmword ptr [rbp-0A0],ymm4
       vmovdqu   ymmword ptr [rbp-80],ymm4
       vmovdqu   ymmword ptr [rbp-60],ymm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       mov       [rbp-30],rax
       vmovsd    xmm1,qword ptr [7FFC03708FD0]
       vucomisd  xmm1,xmm0
       ja        near ptr M01_L58
       vucomisd  xmm0,xmm0
       jp        near ptr M01_L62
       jne       near ptr M01_L62
       vmulsd    xmm0,xmm0,qword ptr [7FFC03708FD8]
       call      qword ptr [7FFC039DCF00]; System.TimeSpan.IntervalFromDoubleTicks(Double)
       mov       rbx,rax
       mov       rcx,27B08801DC8
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0
       jne       near ptr M01_L63
       mov       rsi,[rcx+18]
M01_L00:
       mov       [rbp-0B8],rsi
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
       call      00007FFC632821C0
       cmp       rax,[rbp-58]
       jne       near ptr M01_L65
M01_L01:
       mov       rsi,[rbp-58]
M01_L02:
       xor       ecx,ecx
       mov       [rbp-58],rcx
M01_L03:
       mov       [rbp-0C0],rsi
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
       jle       near ptr M01_L10
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
       mov       r9,7FFC5F9FC3D8
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
       jb        near ptr M01_L30
       cmp       ecx,64
       jb        short M01_L05
       mov       rsi,2BB9D7B1234
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
       jb        near ptr M01_L30
       add       rax,0FFFFFFFFFFFFFFFC
       mov       rsi,2BB9D7B1234
       shl       edx,2
       mov       edx,[rsi+rdx]
       mov       [rax],edx
M01_L06:
       xor       eax,eax
       mov       [rbp-68],rax
       mov       eax,1
M01_L07:
       xor       edx,edx
       mov       [rbp-68],rdx
       test      eax,eax
       je        near ptr M01_L37
       mov       ecx,[rbp-60]
       mov       rsi,[rbp-0C0]
       add       [rsi+18],ecx
       mov       r14,rsi
M01_L08:
       mov       r8,2BB9D7C0BC8
       mov       rcx,2BB9D7C0BA0
       cmp       edi,1
       cmovne    r8,rcx
       cmp       [r14],r14b
       lea       rdx,[r8+0C]
       mov       edi,[r8+8]
       test      edi,edi
       je        short M01_L10
       mov       r8,[r14+8]
       mov       r15d,[r14+18]
       lea       ecx,[r15+rdi]
       cmp       ecx,[r8+8]
       ja        near ptr M01_L39
       movsxd    rcx,r15d
       lea       rcx,[r8+rcx*2+10]
       cmp       edi,2
       jle       near ptr M01_L31
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFC03655818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L09:
       add       edi,r15d
       mov       [r14+18],edi
M01_L10:
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
       jle       near ptr M01_L18
       mov       rsi,[rbp-0C0]
       mov       ecx,[rsi+1C]
       mov       edx,[rsi+18]
       add       ecx,edx
       test      ecx,ecx
       jle       short M01_L11
       mov       ecx,edx
       mov       rax,[rsi+8]
       cmp       [rax+8],ecx
       jbe       near ptr M01_L40
       mov       word ptr [rax+rcx*2+10],20
       inc       edx
       mov       [rsi+18],edx
M01_L11:
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
       mov       r9,7FFC5F9FC3D8
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
       jb        near ptr M01_L32
       cmp       ecx,64
       jb        short M01_L13
       mov       r8,2BB9D7B1234
M01_L12:
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
       jae       short M01_L12
M01_L13:
       cmp       edx,0A
       jb        near ptr M01_L32
       add       rax,0FFFFFFFFFFFFFFFC
       mov       r8,2BB9D7B1234
       shl       edx,2
       mov       edx,[r8+rdx]
       mov       [rax],edx
M01_L14:
       xor       eax,eax
       mov       [rbp-78],rax
       mov       eax,1
M01_L15:
       xor       edx,edx
       mov       [rbp-78],rdx
       test      eax,eax
       je        near ptr M01_L42
       mov       ecx,[rbp-70]
       add       [rsi+18],ecx
       mov       r14,rsi
M01_L16:
       mov       r8,2BB9D7C0C10
       mov       rcx,2BB9D7C0BE8
       cmp       edi,1
       cmovne    r8,rcx
       cmp       [r14],r14b
       lea       rdx,[r8+0C]
       mov       edi,[r8+8]
       test      edi,edi
       je        short M01_L18
       mov       r8,[r14+8]
       mov       r15d,[r14+18]
       lea       ecx,[r15+rdi]
       cmp       ecx,[r8+8]
       ja        near ptr M01_L44
       movsxd    rcx,r15d
       lea       rcx,[r8+rcx*2+10]
       cmp       edi,2
       jle       near ptr M01_L33
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFC03655818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L17:
       add       edi,r15d
       mov       [r14+18],edi
M01_L18:
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
M01_L19:
       mov       rsi,[rbp-0C0]
       mov       ecx,[rsi+1C]
       mov       edx,[rsi+18]
       add       ecx,edx
       test      ecx,ecx
       jle       short M01_L20
       mov       ecx,edx
       mov       rax,[rsi+8]
       cmp       [rax+8],ecx
       jbe       near ptr M01_L46
       cmp       ecx,[rax+8]
       jae       near ptr M01_L55
       mov       word ptr [rax+rcx*2+10],20
       lea       ecx,[rdx+1]
       mov       [rsi+18],ecx
M01_L20:
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
M01_L21:
       mov       r15d,[rbp-7C]
       test      r15d,r15d
       jl        near ptr M01_L49
       mov       eax,r15d
       or        eax,1
       lzcnt     eax,eax
       xor       eax,1F
       mov       ecx,r15d
       mov       rdx,7FFC5F9FC3D8
       add       rcx,[rdx+rax*8]
       sar       rcx,20
       cmp       ecx,edi
       jg        near ptr M01_L52
       mov       [rbp-88],ecx
       mov       [rbp-90],r14
       movsxd    rax,ecx
       lea       rax,[r14+rax*2]
       cmp       r15d,0A
       jb        near ptr M01_L34
       cmp       r15d,64
       jb        short M01_L23
       mov       r8,2BB9D7B1234
M01_L22:
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
       jae       short M01_L22
M01_L23:
       cmp       r15d,0A
       jb        near ptr M01_L34
       add       rax,0FFFFFFFFFFFFFFFC
       mov       r8,2BB9D7B1234
       mov       rcx,r8
       lea       edx,[r15*4]
       mov       ecx,[rcx+rdx]
       mov       [rax],ecx
M01_L24:
       xor       eax,eax
       mov       [rbp-90],rax
       mov       r14d,1
M01_L25:
       xor       eax,eax
       mov       [rbp-90],rax
M01_L26:
       test      r14d,r14d
       je        near ptr M01_L53
       mov       ecx,[rbp-88]
       add       [rsi+18],ecx
       mov       rdi,rsi
M01_L27:
       mov       r8,2BB9D7C0C60
       mov       rcx,2BB9D7C0C38
       cmp       ebx,1
       cmovne    r8,rcx
       cmp       [rdi],dil
       lea       rdx,[r8+0C]
       mov       ebx,[r8+8]
       test      ebx,ebx
       je        short M01_L29
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
       call      qword ptr [7FFC03655818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L28:
       add       ebx,r14d
       mov       [rdi+18],ebx
M01_L29:
       mov       rcx,rsi
       call      qword ptr [7FFC03842200]; System.Text.StringBuilder.ToString()
       mov       [rbp-0C8],rax
       jmp       near ptr M01_L57
M01_L30:
       add       edx,30
       mov       [rax-2],dx
       jmp       near ptr M01_L06
M01_L31:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       edi,2
       jne       near ptr M01_L09
       jmp       short M01_L38
M01_L32:
       add       edx,30
       mov       [rax-2],dx
       jmp       near ptr M01_L14
M01_L33:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       edi,2
       jne       near ptr M01_L17
       jmp       near ptr M01_L43
M01_L34:
       lea       ecx,[r15+30]
       mov       [rax-2],cx
       jmp       near ptr M01_L24
M01_L35:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       ebx,2
       jne       short M01_L28
       jmp       near ptr M01_L54
M01_L36:
       xor       eax,eax
       mov       [rbp-60],eax
       jmp       near ptr M01_L07
M01_L37:
       mov       rsi,[rbp-0C0]
       call      qword ptr [7FFC037CF210]; System.Number.Int32ToDecStr(Int32)
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFC037CF228]; System.Text.StringBuilder.Append(System.String)
       mov       r14,rax
       jmp       near ptr M01_L08
M01_L38:
       movzx     edx,word ptr [rdx+2]
       mov       [rcx+2],dx
       jmp       near ptr M01_L09
M01_L39:
       mov       rcx,r14
       mov       r8d,edi
       call      qword ptr [7FFC037CF1E0]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M01_L10
M01_L40:
       mov       rcx,rsi
       mov       edx,20
       call      qword ptr [7FFC037CF3A8]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M01_L11
M01_L41:
       xor       eax,eax
       mov       [rbp-70],eax
       jmp       near ptr M01_L15
M01_L42:
       call      qword ptr [7FFC037CF210]; System.Number.Int32ToDecStr(Int32)
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFC037CF228]; System.Text.StringBuilder.Append(System.String)
       mov       r14,rax
       jmp       near ptr M01_L16
M01_L43:
       movzx     edx,word ptr [rdx+2]
       mov       [rcx+2],dx
       jmp       near ptr M01_L17
M01_L44:
       mov       rcx,r14
       mov       r8d,edi
       call      qword ptr [7FFC037CF1E0]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M01_L18
M01_L45:
       mov       rsi,[rbp-0C0]
       mov       ecx,[rsi+1C]
       mov       edx,[rsi+18]
       add       edx,ecx
       jne       near ptr M01_L29
       jmp       near ptr M01_L19
M01_L46:
       mov       rcx,rsi
       mov       edx,20
       call      qword ptr [7FFC037CF3A8]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M01_L20
M01_L47:
       or        r8d,edi
       jne       short M01_L48
       xor       r14d,r14d
       xor       edi,edi
       jmp       near ptr M01_L21
M01_L48:
       mov       rsi,[rbp-0C0]
       call      qword ptr [7FFC037C7198]
       int       3
M01_L49:
       call      qword ptr [7FFC03875DD0]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
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
       call      qword ptr [7FFC03D05860]
       mov       r14d,eax
       jmp       near ptr M01_L26
M01_L52:
       xor       eax,eax
       mov       [rbp-88],eax
       xor       r14d,r14d
       jmp       near ptr M01_L25
M01_L53:
       mov       ecx,[rbp-7C]
       call      qword ptr [7FFC037CF210]; System.Number.Int32ToDecStr(Int32)
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFC037CF228]; System.Text.StringBuilder.Append(System.String)
       mov       rdi,rax
       jmp       near ptr M01_L27
M01_L54:
       movzx     edx,word ptr [rdx+2]
       mov       [rcx+2],dx
       jmp       near ptr M01_L28
M01_L55:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M01_L56:
       mov       rcx,rdi
       mov       r8d,ebx
       call      qword ptr [7FFC037CF1E0]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M01_L29
M01_L57:
       call      M01_L68
       nop
       mov       rax,[rbp-0C8]
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
       call      qword ptr [7FFC03655938]
       mov       ebx,eax
       lea       rcx,[rbp-50]
       mov       edx,0C
       mov       r8d,2
       call      qword ptr [7FFC03874E70]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler..ctor(Int32, Int32)
       lea       rcx,[rbp-50]
       mov       edx,ebx
       call      qword ptr [7FFC03874DB0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Int32, System.Private.CoreLib]](Int32)
       mov       ecx,[rbp-40]
       cmp       ecx,[rbp-30]
       jbe       short M01_L59
       call      qword ptr [7FFC037C7198]
       int       3
M01_L59:
       mov       rdx,[rbp-38]
       mov       eax,ecx
       lea       rdx,[rdx+rax*2]
       mov       eax,[rbp-30]
       sub       eax,ecx
       cmp       eax,0C
       jb        short M01_L60
       vmovups   xmm0,[7FFC03708FE0]
       vmovups   [rdx],xmm0
       mov       rcx,64006E006F0063
       mov       [rdx+10],rcx
       mov       ecx,[rbp-40]
       add       ecx,0C
       mov       [rbp-40],ecx
       jmp       short M01_L61
M01_L60:
       lea       rcx,[rbp-50]
       mov       rdx,2BB9D7C0B70
       call      qword ptr [7FFC03C675D0]
M01_L61:
       mov       rdx,2BB9D7B0008
       mov       rcx,2BB9D7BB588
       cmp       ebx,1
       cmovne    rdx,rcx
       lea       rcx,[rbp-50]
       call      qword ptr [7FFC0387E430]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted(System.String)
       lea       rcx,[rbp-50]
       call      qword ptr [7FFC03874EA0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
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
       call      qword ptr [7FFC03D05C80]
       int       3
M01_L63:
       call      qword ptr [7FFC039D40D8]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rsi,rax
       jmp       near ptr M01_L00
M01_L64:
       call      qword ptr [7FFC03D05620]
       int       3
M01_L65:
       mov       rcx,[rsi+18]
       lea       rdx,[rbp-58]
       cmp       [rcx],ecx
       call      qword ptr [7FFC03C64BB8]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
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
       mov       rsi,[rbp-0C0]
       cmp       dword ptr [rsi+20],0
       jge       short M01_L69
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,3AD
       mov       rdx,7FFC03594000
       call      qword ptr [7FFC03877798]
       mov       rbx,rax
       call      qword ptr [7FFC03D05AD0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFC0387DA70]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M01_L69:
       cmp       qword ptr [rsi+10],0
       jne       short M01_L70
       xor       ecx,ecx
       mov       [rsi+18],rcx
       jmp       near ptr M01_L77
M01_L70:
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       mov       r8d,ecx
       neg       r8d
       test      r8d,r8d
       jle       short M01_L71
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFC03D05C50]
       jmp       near ptr M01_L77
M01_L71:
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFC03D05C68]
       mov       rbx,rax
       cmp       rbx,rsi
       je        near ptr M01_L76
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
       sub       ecx,[rbx+1C]
       mov       rdx,[rbx+8]
       cmp       [rdx+8],ecx
       jge       short M01_L74
       cmp       ecx,400
       jge       short M01_L72
       movsxd    rdx,ecx
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rdi,rax
       jmp       short M01_L73
M01_L72:
       xor       edx,edx
       call      qword ptr [7FFC03BFE808]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       rdi,rax
M01_L73:
       mov       rcx,[rbx+8]
       mov       r8d,[rbx+18]
       mov       rdx,rdi
       call      qword ptr [7FFC037C5050]; System.Array.Copy(System.Array, System.Array, Int32)
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M01_L75
M01_L74:
       mov       rdx,[rbx+8]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
M01_L75:
       mov       rdx,[rbx+10]
       lea       rcx,[rsi+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rbx+1C]
       mov       [rsi+1C],ecx
M01_L76:
       mov       ecx,[rbx+1C]
       neg       ecx
       mov       [rsi+18],ecx
M01_L77:
       mov       rdx,offset MT_Microsoft.Extensions.ObjectPool.DefaultObjectPool<System.Text.StringBuilder>
       mov       rcx,[rbp-0B8]
       cmp       [rcx],rdx
       jne       near ptr M01_L81
       mov       rax,[rcx+10]
       mov       rdx,rsi
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       test      eax,eax
       je        near ptr M01_L82
       mov       rcx,[rbp-0B8]
       cmp       qword ptr [rcx+20],0
       jne       short M01_L79
       lea       rdx,[rcx+20]
       test      rdx,rdx
       jne       short M01_L78
       call      qword ptr [7FFC03D05620]
       int       3
M01_L78:
       mov       rcx,rdx
       mov       rdx,rsi
       xor       r8d,r8d
       call      00007FFC632821C0
       test      rax,rax
       mov       rcx,[rbp-0B8]
       je        short M01_L82
M01_L79:
       lea       rdx,[rcx+2C]
       mov       eax,1
       lock xadd [rdx],eax
       inc       eax
       cmp       eax,[rcx+28]
       jg        short M01_L80
       mov       rbx,[rcx+18]
       mov       rcx,[rbx+10]
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFC03D05D28]
       test      eax,eax
       jne       short M01_L82
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFC03D05D40]
       jmp       short M01_L82
M01_L80:
       add       rcx,2C
       lock dec  dword ptr [rcx]
       jmp       short M01_L82
M01_L81:
       mov       rdx,rsi
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
M01_L82:
       nop
       add       rsp,28
       ret
; Total bytes of code 3081
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.NumericExtensionsBenchmark.FormatTimeDoubleMilliseconds()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       vmovsd    xmm0,qword ptr [rbx+1B8]
       call      qword ptr [7FFC03C56760]; DotNetTips.Spargine.Extensions.NumericExtensions.FormatTime(Double)
       mov       [rsp+28],rax
       mov       rbx,[rbx+90]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       ret
; Total bytes of code 67
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
; 		var stringBuilderPool = _stringBuilderPool.Value;
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var sb = stringBuilderPool.Get();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			if (timeSpan.Hours > 0)
; 			^^^^^^^^^^^^^^^^^^^^^^^
; 				_ = sb.Append(timeSpan.Hours).Append(timeSpan.Hours == 1 ? " hour" : " hours");
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			if (timeSpan.Minutes > 0)
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
; 				if (sb.Length > 0)
; 				^^^^^^^^^^^^^^^^^^
; 					_ = sb.Append(ControlChars.Space);
; 					^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 				_ = sb.Append(timeSpan.Minutes).Append(timeSpan.Minutes == 1 ? " minute" : " minutes");
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			if (timeSpan.Seconds > 0 || sb.Length == 0)
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 				if (sb.Length > 0)
; 				^^^^^^^^^^^^^^^^^^
; 					_ = sb.Append(ControlChars.Space);
; 					^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 				_ = sb.Append(timeSpan.Seconds).Append(timeSpan.Seconds == 1 ? " second" : " seconds");
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			return sb.ToString();
; 			^^^^^^^^^^^^^^^^^^^^^
; 	}
; 	^
; 			stringBuilderPool.Return(sb.Clear());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       sub       rsp,0A8
       lea       rbp,[rsp+0E0]
       xor       eax,eax
       mov       [rbp-98],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-90],ymm4
       vmovdqu   ymmword ptr [rbp-70],ymm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp-40],rax
       vmovsd    xmm1,qword ptr [7FFC036E01B0]
       vucomisd  xmm1,xmm0
       jbe       near ptr M01_L40
       vroundsd  xmm0,xmm0,xmm0,4
       call      qword ptr [7FFC03645938]; System.Math.ConvertToInt32Checked(Double)
       mov       ebx,eax
       xor       ecx,ecx
       mov       [rbp-68],rcx
       mov       rcx,1C4C0000C88
       mov       rsi,[rcx]
       mov       rcx,1C4C0000C90
       mov       rdi,[rcx]
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+238],3
       jle       near ptr M01_L13
       mov       rcx,[rcx+240]
       mov       rax,[rcx+18]
       test      rax,rax
       je        near ptr M01_L13
M01_L00:
       mov       rcx,[rax+10]
       test      rcx,rcx
       je        near ptr M01_L15
       mov       eax,[rcx+8]
       cmp       eax,4
       jle       near ptr M01_L15
       mov       r14,[rcx+50]
       test      r14,r14
       je        near ptr M01_L15
       xor       eax,eax
       mov       [rcx+50],rax
       cmp       byte ptr [rdi+9D],0
       jne       near ptr M01_L14
M01_L01:
       mov       [rbp-60],r14
       lea       rax,[r14+10]
       mov       ecx,[r14+8]
       mov       [rbp-50],rax
       mov       [rbp-48],ecx
       xor       eax,eax
       mov       [rbp-58],eax
       mov       byte ptr [rbp-54],0
       cmp       byte ptr [rbp-54],0
       jne       near ptr M01_L29
M01_L02:
       mov       eax,[rbp-58]
       mov       esi,[rbp-48]
       cmp       eax,esi
       ja        near ptr M01_L39
       mov       rcx,[rbp-50]
       mov       edx,eax
       lea       rdi,[rcx+rdx*2]
       sub       esi,eax
       mov       rcx,[rbp-68]
       test      ebx,ebx
       jl        near ptr M01_L31
       mov       ecx,ebx
       or        ecx,1
       xor       eax,eax
       lzcnt     eax,ecx
       xor       eax,1F
       mov       ecx,ebx
       mov       rdx,7FFC5F9FC3D8
       add       rcx,[rdx+rax*8]
       sar       rcx,20
       cmp       ecx,esi
       jg        near ptr M01_L36
       mov       [rbp-70],ecx
       mov       [rbp-78],rdi
       movsxd    rax,ecx
       lea       rax,[rdi+rax*2]
       mov       ecx,ebx
       cmp       ebx,0A
       jb        near ptr M01_L12
       cmp       ebx,64
       jb        short M01_L04
       mov       rdx,20554F71234
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
       jb        near ptr M01_L12
       add       rax,0FFFFFFFFFFFFFFFC
       mov       rdx,20554F71234
       shl       ecx,2
       mov       ecx,[rdx+rcx]
       mov       [rax],ecx
M01_L05:
       xor       eax,eax
       mov       [rbp-78],rax
       mov       edi,1
M01_L06:
       xor       eax,eax
       mov       [rbp-78],rax
M01_L07:
       test      edi,edi
       je        near ptr M01_L30
       mov       ecx,[rbp-58]
       add       ecx,[rbp-70]
       mov       [rbp-58],ecx
M01_L08:
       mov       ecx,[rbp-58]
       mov       edx,[rbp-48]
       cmp       ecx,edx
       ja        near ptr M01_L39
       mov       rax,[rbp-50]
       mov       r8d,ecx
       lea       rax,[rax+r8*2]
       sub       edx,ecx
       cmp       edx,0C
       jb        near ptr M01_L37
       vmovups   xmm0,[7FFC036E01C0]
       vmovups   [rax],xmm0
       mov       rcx,64006E006F0063
       mov       [rax+10],rcx
       mov       ecx,[rbp-58]
       add       ecx,0C
       mov       [rbp-58],ecx
M01_L09:
       mov       rdx,20554F70008
       mov       r8,20554F7B588
       cmp       ebx,1
       cmovne    rdx,r8
       cmp       byte ptr [rbp-54],0
       jne       near ptr M01_L38
       mov       r8d,[rbp-58]
       mov       ecx,[rbp-48]
       cmp       r8d,ecx
       ja        near ptr M01_L39
       mov       rax,[rbp-50]
       mov       r10d,r8d
       lea       rax,[rax+r10*2]
       sub       ecx,r8d
       mov       ebx,[rdx+8]
       cmp       ebx,ecx
       ja        near ptr M01_L38
       mov       r8d,ebx
       add       r8,r8
       add       rdx,0C
       mov       rcx,rax
       call      qword ptr [7FFC03645818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       ebx,[rbp-58]
       mov       [rbp-58],ebx
M01_L10:
       mov       ecx,[rbp-58]
       cmp       ecx,[rbp-48]
       ja        near ptr M01_L39
       mov       rax,[rbp-50]
       mov       [rbp-88],rax
       mov       [rbp-80],ecx
       lea       rcx,[rbp-88]
       call      System.String.Ctor(System.ReadOnlySpan`1<Char>)
       mov       rbx,rax
       mov       rdx,[rbp-60]
       xor       ecx,ecx
       mov       [rbp-60],rcx
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-50],xmm0
       mov       [rbp-58],ecx
       test      rdx,rdx
       je        short M01_L11
       mov       rcx,1C4C0000C88
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FFC038FFB50]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
M01_L11:
       mov       rax,rbx
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
M01_L12:
       add       ecx,30
       mov       [rax-2],cx
       jmp       near ptr M01_L05
M01_L13:
       mov       ecx,3
       call      qword ptr [7FFC03C5EF58]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M01_L00
M01_L14:
       mov       rcx,r14
       call      qword ptr [7FFC03A7D770]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r15d,eax
       mov       r13d,[r14+8]
       mov       rcx,rsi
       call      qword ptr [7FFC03A7D770]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       dword ptr [rsp+20],4
       mov       edx,r15d
       mov       r8d,r13d
       mov       rcx,rdi
       call      qword ptr [7FFC03C5EF70]
       jmp       near ptr M01_L01
M01_L15:
       mov       rcx,[rsi+10]
       cmp       dword ptr [rcx+8],4
       jle       near ptr M01_L27
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        near ptr M01_L26
       mov       r14,[rcx+8]
       mov       rcx,offset MT_System.Threading.ProcessorIdCache
       call      qword ptr [7FFC03645740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       cmp       byte ptr [7FFC0358B174],0
       je        short M01_L16
       call      qword ptr [7FFC03C5EF88]
       mov       r15d,eax
       jmp       short M01_L18
M01_L16:
       mov       ecx,9
       call      qword ptr [7FFC03C5EFA0]
       mov       r15d,[rax+10]
       mov       ecx,9
       call      qword ptr [7FFC03C5EFA0]
       lea       ecx,[r15-1]
       mov       [rax+10],ecx
       movzx     eax,r15w
       test      eax,eax
       jne       short M01_L17
       call      qword ptr [7FFC03C5EFB8]
       mov       r15d,eax
       jmp       short M01_L18
M01_L17:
       sar       r15d,10
M01_L18:
       mov       rcx,offset MT_System.Buffers.SharedArrayPoolStatics
       call      qword ptr [7FFC03645740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       eax,r15d
       xor       edx,edx
       div       dword ptr [7FFC0358B168]
       mov       r15d,edx
       xor       r13d,r13d
       jmp       short M01_L22
M01_L19:
       cmp       r15d,[r14+8]
       jae       near ptr M01_L47
       mov       ecx,r15d
       mov       r12,[r14+rcx*8+10]
       cmp       [r12],r12b
       xor       eax,eax
       mov       [rbp-0B0],rax
       mov       rcx,r12
       call      qword ptr [7FFC03B6E028]; System.Threading.Monitor.Enter(System.Object)
       mov       rcx,[r12+8]
       mov       eax,[r12+10]
       dec       eax
       cmp       [rcx+8],eax
       jbe       short M01_L20
       mov       edx,eax
       mov       rdx,[rcx+rdx*8+10]
       mov       [rbp-0B0],rdx
       mov       r8d,eax
       xor       r10d,r10d
       mov       [rcx+r8*8+10],r10
       mov       [r12+10],eax
M01_L20:
       mov       rcx,r12
       call      qword ptr [7FFC03646820]; System.Threading.Monitor.Exit(System.Object)
       mov       r12,[rbp-0B0]
       test      r12,r12
       jne       short M01_L23
       inc       r15d
       cmp       [r14+8],r15d
       jne       short M01_L21
       xor       r15d,r15d
M01_L21:
       inc       r13d
M01_L22:
       cmp       [r14+8],r13d
       jg        near ptr M01_L19
       jmp       short M01_L24
M01_L23:
       mov       r14,r12
       jmp       short M01_L25
M01_L24:
       xor       r14d,r14d
M01_L25:
       test      r14,r14
       je        short M01_L26
       cmp       byte ptr [rdi+9D],0
       je        near ptr M01_L01
       mov       rcx,r14
       call      qword ptr [7FFC03A7D770]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r15d,eax
       mov       r13d,[r14+8]
       mov       rcx,rsi
       call      qword ptr [7FFC03A7D770]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       dword ptr [rsp+20],4
       mov       edx,r15d
       mov       r8d,r13d
       mov       rcx,rdi
       call      qword ptr [7FFC03C5EF70]
       jmp       near ptr M01_L01
M01_L26:
       mov       edx,100
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
       cmp       byte ptr [rdi+9D],0
       je        near ptr M01_L01
       jmp       short M01_L28
M01_L27:
       mov       ecx,100
       mov       rdx,20554F76F28
       call      qword ptr [7FFC0386DA40]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
       jmp       short M01_L26
M01_L28:
       mov       rcx,r14
       call      qword ptr [7FFC03A7D770]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r15d,eax
       mov       rcx,rsi
       call      qword ptr [7FFC03A7D770]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       edx,r15d
       mov       r8d,100
       mov       rcx,rdi
       call      qword ptr [7FFC03C5EF70]
       mov       rcx,rsi
       call      qword ptr [7FFC03A7D770]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       rcx,[rsi+10]
       mov       edx,1
       mov       r8d,2
       cmp       dword ptr [rcx+8],4
       cmovg     edx,r8d
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       [rsp+28],edx
       mov       rcx,rdi
       mov       edx,r15d
       mov       r8d,100
       call      qword ptr [7FFC03C5EFE8]
       jmp       near ptr M01_L01
M01_L29:
       lea       rcx,[rbp-68]
       mov       edx,ebx
       xor       r8d,r8d
       call      qword ptr [7FFC03C5F000]
       jmp       near ptr M01_L08
M01_L30:
       lea       rcx,[rbp-68]
       call      qword ptr [7FFC03BEEBE0]
       jmp       near ptr M01_L02
M01_L31:
       test      rcx,rcx
       je        short M01_L32
       call      qword ptr [7FFC03BE5668]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider)
       jmp       short M01_L33
M01_L32:
       call      qword ptr [7FFC03865DD0]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
M01_L33:
       mov       r8,[rax+28]
       test      r8,r8
       jne       short M01_L34
       xor       r9d,r9d
       xor       ecx,ecx
       jmp       short M01_L35
M01_L34:
       lea       r9,[r8+0C]
       mov       ecx,[r8+8]
M01_L35:
       mov       [rbp-88],r9
       mov       [rbp-80],ecx
       mov       [rbp-98],rdi
       mov       [rbp-90],esi
       lea       r8,[rbp-70]
       mov       [rsp+20],r8
       lea       r8,[rbp-88]
       lea       r9,[rbp-98]
       mov       ecx,ebx
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFC03C5F780]
       mov       edi,eax
       jmp       near ptr M01_L07
M01_L36:
       xor       eax,eax
       mov       [rbp-70],eax
       xor       edi,edi
       jmp       near ptr M01_L06
M01_L37:
       lea       rcx,[rbp-68]
       mov       rdx,20554F80B70
       call      qword ptr [7FFC03C54240]
       jmp       near ptr M01_L09
M01_L38:
       lea       rcx,[rbp-68]
       call      qword ptr [7FFC03C5F270]
       jmp       near ptr M01_L10
M01_L39:
       call      qword ptr [7FFC037B7198]
       int       3
M01_L40:
       vmovsd    xmm1,qword ptr [7FFC036E01D0]
       call      qword ptr [7FFC03C5F918]
       mov       [rbp-40],rax
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.NumericExtensions
       call      qword ptr [7FFC03645728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1C4C0001DC8
       mov       rcx,[rcx]
       cmp       [rcx],ecx
       call      qword ptr [7FFC039C4078]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].get_Value()
       mov       [rbp-0A0],rax
       mov       rcx,[rbp-0A0]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp-0A8],rax
       lea       rcx,[rbp-40]
       call      qword ptr [7FFC03C56790]
       test      eax,eax
       jle       short M01_L41
       lea       rcx,[rbp-40]
       call      qword ptr [7FFC03C56790]
       mov       edx,eax
       mov       rcx,[rbp-0A8]
       cmp       [rcx],cl
       call      qword ptr [7FFC037BF198]; System.Text.StringBuilder.AppendSpanFormattable[[System.Int32, System.Private.CoreLib]](Int32)
       mov       rbx,rax
       lea       rcx,[rbp-40]
       call      qword ptr [7FFC03C56790]
       mov       rdx,20554F80BC8
       mov       rcx,20554F80BA0
       cmp       eax,1
       cmovne    rdx,rcx
       mov       rcx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FFC037BF228]; System.Text.StringBuilder.Append(System.String)
M01_L41:
       lea       rcx,[rbp-40]
       call      qword ptr [7FFC03C567C0]
       test      eax,eax
       jle       short M01_L43
       mov       rcx,[rbp-0A8]
       mov       edx,[rcx+1C]
       add       edx,[rcx+18]
       test      edx,edx
       jle       short M01_L42
       mov       edx,20
       call      qword ptr [7FFC037BF180]; System.Text.StringBuilder.Append(Char)
M01_L42:
       lea       rcx,[rbp-40]
       call      qword ptr [7FFC03C567C0]
       mov       edx,eax
       mov       rcx,[rbp-0A8]
       call      qword ptr [7FFC037BF198]; System.Text.StringBuilder.AppendSpanFormattable[[System.Int32, System.Private.CoreLib]](Int32)
       mov       rbx,rax
       lea       rcx,[rbp-40]
       call      qword ptr [7FFC03C567C0]
       mov       rdx,20554F80C10
       mov       rcx,20554F80BE8
       cmp       eax,1
       cmovne    rdx,rcx
       mov       rcx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FFC037BF228]; System.Text.StringBuilder.Append(System.String)
M01_L43:
       lea       rcx,[rbp-40]
       call      qword ptr [7FFC03C567F0]
       test      eax,eax
       jg        short M01_L44
       mov       rcx,[rbp-0A8]
       mov       edx,[rcx+1C]
       add       edx,[rcx+18]
       jne       short M01_L46
M01_L44:
       mov       rcx,[rbp-0A8]
       mov       edx,[rcx+1C]
       add       edx,[rcx+18]
       test      edx,edx
       jle       short M01_L45
       mov       edx,20
       call      qword ptr [7FFC037BF180]; System.Text.StringBuilder.Append(Char)
M01_L45:
       lea       rcx,[rbp-40]
       call      qword ptr [7FFC03C567F0]
       mov       edx,eax
       mov       rcx,[rbp-0A8]
       call      qword ptr [7FFC037BF198]; System.Text.StringBuilder.AppendSpanFormattable[[System.Int32, System.Private.CoreLib]](Int32)
       mov       rbx,rax
       lea       rcx,[rbp-40]
       call      qword ptr [7FFC03C567F0]
       mov       rdx,20554F80C60
       mov       rcx,20554F80C38
       cmp       eax,1
       cmovne    rdx,rcx
       mov       rcx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FFC037BF228]; System.Text.StringBuilder.Append(System.String)
       mov       rcx,[rbp-0A8]
M01_L46:
       call      qword ptr [7FFC03832200]; System.Text.StringBuilder.ToString()
       mov       rbx,rax
       mov       rcx,[rbp-0A8]
       xor       edx,edx
       call      qword ptr [7FFC03BED980]; System.Text.StringBuilder.set_Length(Int32)
       mov       rcx,[rbp-0A0]
       mov       rdx,[rbp-0A8]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       rax,rbx
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
M01_L47:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       sub       rsp,38
       mov       rcx,[rbp-0A8]
       cmp       [rcx],cl
       xor       edx,edx
       call      qword ptr [7FFC03BED980]; System.Text.StringBuilder.set_Length(Int32)
       mov       rcx,[rbp-0A0]
       mov       rdx,[rbp-0A8]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       add       rsp,38
       ret
; Total bytes of code 2192
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.NumericExtensionsBenchmark.FormatTimeLongHours()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+1B0]
       call      qword ptr [7FFC03C56760]; DotNetTips.Spargine.Extensions.NumericExtensions.FormatTime(Int64)
       mov       [rsp+28],rax
       mov       rbx,[rbx+90]
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
; DotNetTips.Spargine.Extensions.NumericExtensions.FormatTime(Int64)
; 		if (milliseconds < 1000)
; 		^^^^^^^^^^^^^^^^^^^^^^^^
; 			return $"{milliseconds} millisecond{(milliseconds == 1 ? string.Empty : "s")}";
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var timeSpan = TimeSpan.FromMilliseconds(milliseconds);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var stringBuilderPool = _stringBuilderPool.Value;
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var sb = stringBuilderPool.Get();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
; 			stringBuilderPool.Return(sb.Clear());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		}
; 		^
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0D0
       lea       rbp,[rsp+100]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-0D0],ymm4
       vmovdqu   ymmword ptr [rbp-0B0],ymm4
       vmovdqu   ymmword ptr [rbp-90],ymm4
       vmovdqu   ymmword ptr [rbp-70],ymm4
       vmovdqu   ymmword ptr [rbp-50],ymm4
       mov       rbx,rcx
       cmp       rbx,3E8
       jl        near ptr M01_L55
       mov       rcx,346DC5D638865
       cmp       rbx,rcx
       jg        near ptr M01_L59
       imul      rbx,2710
       mov       rcx,1C10BC01DC8
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0
       jne       near ptr M01_L60
       mov       rsi,[rcx+18]
M01_L00:
       mov       [rbp-0C0],rsi
       mov       rcx,offset MT_Microsoft.Extensions.ObjectPool.DefaultObjectPool<System.Text.StringBuilder>
       cmp       [rsi],rcx
       jne       near ptr M01_L64
       mov       rcx,[rsi+20]
       mov       [rbp-60],rcx
       cmp       qword ptr [rbp-60],0
       je        near ptr M01_L62
       lea       rcx,[rsi+20]
       mov       r8,[rbp-60]
       test      rcx,rcx
       je        near ptr M01_L61
       xor       edx,edx
       call      00007FFC632821C0
       cmp       rax,[rbp-60]
       jne       near ptr M01_L62
M01_L01:
       mov       rsi,[rbp-60]
M01_L02:
       xor       ecx,ecx
       mov       [rbp-60],rcx
M01_L03:
       mov       [rbp-0C8],rsi
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
       jle       near ptr M01_L14
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
       mov       r9,7FFC5F9FC3D8
       add       r10,[r9+r8*8]
       sar       r10,20
       cmp       r10d,eax
       jle       near ptr M01_L06
       xor       r10d,r10d
       mov       [rbp-68],r10d
M01_L04:
       xor       eax,eax
       mov       [rbp-70],rax
       test      r10d,r10d
       je        near ptr M01_L42
       mov       ecx,[rbp-68]
       mov       rsi,[rbp-0C8]
       add       [rsi+18],ecx
       mov       r14,rsi
M01_L05:
       mov       rcx,201A0D40BC8
       mov       rdx,201A0D40BA0
       cmp       edi,1
       cmovne    rcx,rdx
       cmp       [r14],r14b
       lea       rdx,[rcx+0C]
       mov       edi,[rcx+8]
       test      edi,edi
       je        near ptr M01_L14
       mov       r15,[r14+8]
       mov       r13d,[r14+18]
       lea       ecx,[rdi+r13]
       cmp       ecx,[r15+8]
       ja        near ptr M01_L11
       movsxd    r8,r13d
       lea       rcx,[r15+r8*2+10]
       cmp       edi,2
       jg        near ptr M01_L12
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       edi,2
       jne       near ptr M01_L13
       movzx     eax,word ptr [rdx+2]
       mov       [rcx+2],ax
       jmp       near ptr M01_L13
M01_L06:
       mov       [rbp-68],r10d
       mov       [rbp-70],rdx
       movsxd    rax,r10d
       lea       rax,[rdx+rax*2]
       mov       edx,ecx
       cmp       edx,0A
       jb        short M01_L10
       cmp       ecx,64
       jb        short M01_L08
       mov       rsi,201A0D31234
M01_L07:
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
       jae       short M01_L07
M01_L08:
       cmp       edx,0A
       jb        short M01_L10
       add       rax,0FFFFFFFFFFFFFFFC
       mov       rsi,201A0D31234
       shl       edx,2
       mov       edx,[rsi+rdx]
       mov       [rax],edx
M01_L09:
       xor       eax,eax
       mov       [rbp-70],rax
       mov       r10d,1
       jmp       near ptr M01_L04
M01_L10:
       add       edx,30
       mov       [rax-2],dx
       jmp       short M01_L09
M01_L11:
       mov       rcx,r14
       mov       r8d,edi
       call      qword ptr [7FFC037BF1E0]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M01_L14
M01_L12:
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFC03645818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L13:
       add       edi,r13d
       mov       [r14+18],edi
M01_L14:
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
       jle       near ptr M01_L26
       mov       rsi,[rbp-0C8]
       mov       ecx,[rsi+1C]
       mov       edx,[rsi+18]
       add       ecx,edx
       test      ecx,ecx
       jle       short M01_L15
       mov       ecx,edx
       mov       rax,[rsi+8]
       cmp       [rax+8],ecx
       jbe       near ptr M01_L43
       mov       word ptr [rax+rcx*2+10],20
       inc       edx
       mov       [rsi+18],edx
M01_L15:
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
       mov       r9,7FFC5F9FC3D8
       add       r10,[r9+r8*8]
       sar       r10,20
       cmp       r10d,eax
       jle       short M01_L16
       xor       r10d,r10d
       mov       [rbp-78],r10d
       jmp       near ptr M01_L20
M01_L16:
       mov       [rbp-78],r10d
       mov       [rbp-80],rdx
       movsxd    rax,r10d
       lea       rax,[rdx+rax*2]
       mov       edx,ecx
       cmp       ecx,0A
       jb        near ptr M01_L22
       cmp       ecx,64
       jb        short M01_L18
       mov       r8,201A0D31234
M01_L17:
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
       jae       short M01_L17
M01_L18:
       cmp       edx,0A
       jb        near ptr M01_L22
       add       rax,0FFFFFFFFFFFFFFFC
       mov       r8,201A0D31234
       shl       edx,2
       mov       edx,[r8+rdx]
       mov       [rax],edx
M01_L19:
       xor       eax,eax
       mov       [rbp-80],rax
       mov       r10d,1
M01_L20:
       xor       eax,eax
       mov       [rbp-80],rax
       test      r10d,r10d
       je        near ptr M01_L44
       mov       ecx,[rbp-78]
       add       [rsi+18],ecx
       mov       r14,rsi
M01_L21:
       mov       rcx,201A0D40C10
       mov       rdx,201A0D40BE8
       cmp       edi,1
       cmovne    rcx,rdx
       cmp       [r14],r14b
       lea       rdx,[rcx+0C]
       mov       edi,[rcx+8]
       test      edi,edi
       je        short M01_L26
       mov       r15,[r14+8]
       mov       r13d,[r14+18]
       lea       ecx,[rdi+r13]
       cmp       ecx,[r15+8]
       ja        short M01_L23
       movsxd    r8,r13d
       lea       rcx,[r15+r8*2+10]
       cmp       edi,2
       jg        short M01_L24
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       edi,2
       jne       short M01_L25
       movzx     eax,word ptr [rdx+2]
       mov       [rcx+2],ax
       jmp       short M01_L25
M01_L22:
       add       edx,30
       mov       [rax-2],dx
       jmp       near ptr M01_L19
M01_L23:
       mov       rcx,r14
       mov       r8d,edi
       call      qword ptr [7FFC037BF1E0]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M01_L26
M01_L24:
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFC03645818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L25:
       add       edi,r13d
       mov       [r14+18],edi
M01_L26:
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
M01_L27:
       mov       rsi,[rbp-0C8]
       mov       ecx,[rsi+1C]
       mov       edx,[rsi+18]
       add       ecx,edx
       test      ecx,ecx
       jle       short M01_L28
       mov       ecx,edx
       mov       rax,[rsi+8]
       cmp       [rax+8],ecx
       jbe       near ptr M01_L46
       cmp       ecx,[rax+8]
       jae       near ptr M01_L52
       mov       word ptr [rax+rcx*2+10],20
       lea       ecx,[rdx+1]
       mov       [rsi+18],ecx
M01_L28:
       mov       eax,ebx
       mov       [rbp-84],eax
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
M01_L29:
       mov       r15d,[rbp-84]
       test      r15d,r15d
       jl        near ptr M01_L49
       mov       eax,r15d
       or        eax,1
       lzcnt     eax,eax
       xor       eax,1F
       mov       ecx,r15d
       mov       rdx,7FFC5F9FC3D8
       add       rcx,[rdx+rax*8]
       sar       rcx,20
       cmp       ecx,edi
       jle       short M01_L30
       xor       ecx,ecx
       mov       [rbp-90],ecx
       jmp       near ptr M01_L34
M01_L30:
       mov       [rbp-90],ecx
       mov       [rbp-98],r14
       movsxd    rax,ecx
       lea       rax,[r14+rax*2]
       cmp       r15d,0A
       jb        near ptr M01_L37
       cmp       r15d,64
       jb        short M01_L32
       mov       r8,201A0D31234
M01_L31:
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
       jae       short M01_L31
M01_L32:
       cmp       r15d,0A
       jb        near ptr M01_L37
       add       rax,0FFFFFFFFFFFFFFFC
       mov       r8,201A0D31234
       mov       rcx,r8
       lea       edx,[r15*4]
       mov       ecx,[rcx+rdx]
       mov       [rax],ecx
M01_L33:
       xor       eax,eax
       mov       [rbp-98],rax
       mov       ecx,1
M01_L34:
       xor       eax,eax
       mov       [rbp-98],rax
M01_L35:
       test      ecx,ecx
       je        near ptr M01_L53
       mov       ecx,[rbp-90]
       add       [rsi+18],ecx
       mov       rdi,rsi
M01_L36:
       mov       rcx,201A0D40C60
       mov       rdx,201A0D40C38
       cmp       ebx,1
       cmovne    rcx,rdx
       cmp       [rdi],dil
       lea       rdx,[rcx+0C]
       mov       ebx,[rcx+8]
       test      ebx,ebx
       je        short M01_L41
       mov       r14,[rdi+8]
       mov       r15d,[rdi+18]
       lea       ecx,[r15+rbx]
       cmp       ecx,[r14+8]
       ja        short M01_L38
       movsxd    r8,r15d
       lea       rcx,[r14+r8*2+10]
       cmp       ebx,2
       jg        short M01_L39
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       ebx,2
       jne       short M01_L40
       movzx     eax,word ptr [rdx+2]
       mov       [rcx+2],ax
       jmp       short M01_L40
M01_L37:
       lea       ecx,[r15+30]
       mov       [rax-2],cx
       jmp       near ptr M01_L33
M01_L38:
       mov       rcx,rdi
       mov       r8d,ebx
       call      qword ptr [7FFC037BF1E0]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M01_L41
M01_L39:
       mov       r8d,ebx
       add       r8,r8
       call      qword ptr [7FFC03645818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L40:
       add       ebx,r15d
       mov       [rdi+18],ebx
M01_L41:
       mov       rcx,rsi
       call      qword ptr [7FFC03832200]; System.Text.StringBuilder.ToString()
       mov       [rbp-0D0],rax
       jmp       near ptr M01_L54
M01_L42:
       mov       rsi,[rbp-0C8]
       call      qword ptr [7FFC037BF210]; System.Number.Int32ToDecStr(Int32)
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFC037BF228]; System.Text.StringBuilder.Append(System.String)
       mov       r14,rax
       jmp       near ptr M01_L05
M01_L43:
       mov       rcx,rsi
       mov       edx,20
       call      qword ptr [7FFC037BF3A8]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M01_L15
M01_L44:
       call      qword ptr [7FFC037BF210]; System.Number.Int32ToDecStr(Int32)
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFC037BF228]; System.Text.StringBuilder.Append(System.String)
       mov       r14,rax
       jmp       near ptr M01_L21
M01_L45:
       mov       rsi,[rbp-0C8]
       mov       ecx,[rsi+1C]
       mov       edx,[rsi+18]
       add       edx,ecx
       jne       short M01_L41
       jmp       near ptr M01_L27
M01_L46:
       mov       rcx,rsi
       mov       edx,20
       call      qword ptr [7FFC037BF3A8]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M01_L28
M01_L47:
       or        r8d,edi
       jne       short M01_L48
       xor       r14d,r14d
       xor       edi,edi
       jmp       near ptr M01_L29
M01_L48:
       mov       rsi,[rbp-0C8]
       call      qword ptr [7FFC037B7198]
       int       3
M01_L49:
       call      qword ptr [7FFC03865DD0]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
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
       mov       [rbp-0A8],r9
       mov       [rbp-0A0],ecx
       mov       [rbp-0B8],r14
       mov       [rbp-0B0],edi
       lea       r8,[rbp-90]
       mov       [rsp+20],r8
       lea       r8,[rbp-0A8]
       lea       r9,[rbp-0B8]
       mov       ecx,r15d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFC03C5F1C8]
       mov       ecx,eax
       jmp       near ptr M01_L35
M01_L52:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M01_L53:
       mov       ecx,[rbp-84]
       call      qword ptr [7FFC037BF210]; System.Number.Int32ToDecStr(Int32)
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFC037BF228]; System.Text.StringBuilder.Append(System.String)
       mov       rdi,rax
       jmp       near ptr M01_L36
M01_L54:
       call      M01_L65
       nop
       mov       rax,[rbp-0D0]
       add       rsp,0D0
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L55:
       lea       rcx,[rbp-58]
       mov       edx,0C
       mov       r8d,2
       call      qword ptr [7FFC03864E70]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler..ctor(Int32, Int32)
       lea       rcx,[rbp-58]
       mov       rdx,rbx
       call      qword ptr [7FFC03C541C8]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Int64, System.Private.CoreLib]](Int64)
       mov       ecx,[rbp-48]
       cmp       ecx,[rbp-38]
       jbe       short M01_L56
       call      qword ptr [7FFC037B7198]
       int       3
M01_L56:
       mov       rdx,[rbp-40]
       mov       eax,ecx
       lea       rdx,[rdx+rax*2]
       mov       eax,[rbp-38]
       sub       eax,ecx
       cmp       eax,0C
       jb        short M01_L57
       vmovups   xmm0,[7FFC036E2260]
       vmovups   [rdx],xmm0
       mov       rcx,64006E006F0063
       mov       [rdx+10],rcx
       mov       ecx,[rbp-48]
       add       ecx,0C
       mov       [rbp-48],ecx
       jmp       short M01_L58
M01_L57:
       lea       rcx,[rbp-58]
       mov       rdx,201A0D40B70
       call      qword ptr [7FFC03C54240]
M01_L58:
       mov       rdx,201A0D30008
       mov       rcx,201A0D3B588
       cmp       rbx,1
       cmovne    rdx,rcx
       lea       rcx,[rbp-58]
       call      qword ptr [7FFC0386E430]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted(System.String)
       lea       rcx,[rbp-58]
       call      qword ptr [7FFC03864EA0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       nop
       add       rsp,0D0
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L59:
       call      qword ptr [7FFC03C5F720]
       int       3
M01_L60:
       call      qword ptr [7FFC039C40D8]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rsi,rax
       jmp       near ptr M01_L00
M01_L61:
       call      qword ptr [7FFC03C5F540]
       int       3
M01_L62:
       mov       rcx,[rsi+18]
       lea       rdx,[rbp-60]
       cmp       [rcx],ecx
       call      qword ptr [7FFC03BED830]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
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
       mov       rsi,[rbp-0C8]
       cmp       dword ptr [rsi+20],0
       jge       short M01_L66
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,3AD
       mov       rdx,7FFC03584000
       call      qword ptr [7FFC03867798]
       mov       rbx,rax
       call      qword ptr [7FFC03C5F5B8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFC0386DA70]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M01_L66:
       cmp       qword ptr [rsi+10],0
       jne       short M01_L67
       xor       ecx,ecx
       mov       [rsi+18],rcx
       jmp       near ptr M01_L74
M01_L67:
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       mov       r8d,ecx
       neg       r8d
       test      r8d,r8d
       jle       short M01_L68
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFC03C5F5D0]
       jmp       near ptr M01_L74
M01_L68:
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFC03C5F5E8]
       mov       rbx,rax
       cmp       rbx,rsi
       je        near ptr M01_L73
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
       sub       ecx,[rbx+1C]
       mov       rdx,[rbx+8]
       cmp       [rdx+8],ecx
       jge       short M01_L71
       cmp       ecx,400
       jge       short M01_L69
       movsxd    rdx,ecx
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rdi,rax
       jmp       short M01_L70
M01_L69:
       xor       edx,edx
       call      qword ptr [7FFC03BE7438]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       rdi,rax
M01_L70:
       mov       rcx,[rbx+8]
       mov       r8d,[rbx+18]
       mov       rdx,rdi
       call      qword ptr [7FFC037B5050]; System.Array.Copy(System.Array, System.Array, Int32)
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M01_L72
M01_L71:
       mov       rdx,[rbx+8]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
M01_L72:
       mov       rdx,[rbx+10]
       lea       rcx,[rsi+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rbx+1C]
       mov       [rsi+1C],ecx
M01_L73:
       mov       ecx,[rbx+1C]
       neg       ecx
       mov       [rsi+18],ecx
M01_L74:
       mov       rdx,offset MT_Microsoft.Extensions.ObjectPool.DefaultObjectPool<System.Text.StringBuilder>
       mov       rcx,[rbp-0C0]
       cmp       [rcx],rdx
       jne       near ptr M01_L78
       mov       rax,[rcx+10]
       mov       rdx,rsi
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       test      eax,eax
       je        near ptr M01_L79
       mov       rcx,[rbp-0C0]
       cmp       qword ptr [rcx+20],0
       jne       short M01_L76
       lea       rdx,[rcx+20]
       test      rdx,rdx
       jne       short M01_L75
       call      qword ptr [7FFC03C5F540]
       int       3
M01_L75:
       mov       rcx,rdx
       mov       rdx,rsi
       xor       r8d,r8d
       call      00007FFC632821C0
       test      rax,rax
       mov       rcx,[rbp-0C0]
       je        short M01_L79
M01_L76:
       lea       rdx,[rcx+2C]
       mov       eax,1
       lock xadd [rdx],eax
       inc       eax
       cmp       eax,[rcx+28]
       jg        short M01_L77
       mov       rbx,[rcx+18]
       mov       rcx,[rbx+10]
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFC03C5F6F0]
       test      eax,eax
       jne       short M01_L79
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFC03C5F708]
       jmp       short M01_L79
M01_L77:
       add       rcx,2C
       lock dec  dword ptr [rcx]
       jmp       short M01_L79
M01_L78:
       mov       rdx,rsi
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
M01_L79:
       nop
       add       rsp,28
       ret
; Total bytes of code 2996
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.NumericExtensionsBenchmark.FormatTimeLongMilliseconds()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       ecx,1F4
       call      qword ptr [7FFC03C6DBC0]; DotNetTips.Spargine.Extensions.NumericExtensions.FormatTime(Int64)
       mov       [rsp+28],rax
       mov       rbx,[rbx+90]
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
; DotNetTips.Spargine.Extensions.NumericExtensions.FormatTime(Int64)
; 		if (milliseconds < 1000)
; 		^^^^^^^^^^^^^^^^^^^^^^^^
; 			return $"{milliseconds} millisecond{(milliseconds == 1 ? string.Empty : "s")}";
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var timeSpan = TimeSpan.FromMilliseconds(milliseconds);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var stringBuilderPool = _stringBuilderPool.Value;
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var sb = stringBuilderPool.Get();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
; 			stringBuilderPool.Return(sb.Clear());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       sub       rsp,0A8
       lea       rbp,[rsp+0E0]
       xor       eax,eax
       mov       [rbp-98],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-90],ymm4
       vmovdqu   ymmword ptr [rbp-70],ymm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp-40],rax
       mov       rbx,rcx
       cmp       rbx,3E8
       jge       near ptr M01_L42
       xor       ecx,ecx
       mov       [rbp-68],rcx
       mov       rcx,20AAD000C88
       mov       rsi,[rcx]
       mov       rcx,20AAD000C90
       mov       rdi,[rcx]
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],3
       jle       near ptr M01_L15
       mov       rcx,[rcx+240]
       mov       rax,[rcx+18]
       test      rax,rax
       je        near ptr M01_L15
M01_L00:
       mov       rcx,[rax+10]
       test      rcx,rcx
       je        near ptr M01_L17
       mov       eax,[rcx+8]
       cmp       eax,4
       jle       near ptr M01_L17
       mov       r14,[rcx+50]
       test      r14,r14
       je        near ptr M01_L17
       xor       eax,eax
       mov       [rcx+50],rax
       cmp       byte ptr [rdi+9D],0
       jne       near ptr M01_L16
M01_L01:
       mov       [rbp-60],r14
       lea       rdx,[r14+10]
       mov       eax,[r14+8]
       mov       [rbp-50],rdx
       mov       [rbp-48],eax
       xor       edx,edx
       mov       [rbp-58],edx
       mov       byte ptr [rbp-54],0
       cmp       byte ptr [rbp-54],0
       jne       near ptr M01_L31
M01_L02:
       mov       edx,[rbp-58]
       mov       esi,[rbp-48]
       cmp       edx,esi
       ja        near ptr M01_L41
       mov       rax,[rbp-50]
       mov       ecx,edx
       lea       rdi,[rax+rcx*2]
       sub       esi,edx
       mov       rcx,[rbp-68]
       test      rbx,rbx
       jl        near ptr M01_L33
       mov       rdx,rbx
       or        rdx,1
       lzcnt     rdx,rdx
       xor       edx,3F
       mov       rcx,7FFC5F9F7050
       movzx     edx,byte ptr [rcx+rdx]
       mov       rax,7FFC5F9FCE38
       cmp       rbx,[rax+rdx*8]
       setb      al
       movzx     eax,al
       sub       edx,eax
       cmp       edx,esi
       jg        near ptr M01_L38
       mov       [rbp-70],edx
       mov       [rbp-78],rdi
       movsxd    rdx,edx
       lea       rax,[rdi+rdx*2]
       mov       rcx,rbx
       cmp       rbx,0A
       jb        short M01_L07
       cmp       rbx,64
       jb        short M01_L04
       mov       r8,24B41E11234
M01_L03:
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
       jb        short M01_L05
       mov       rcx,rdx
       jmp       short M01_L03
M01_L04:
       mov       rdx,rcx
M01_L05:
       cmp       rdx,0A
       jb        short M01_L06
       add       rax,0FFFFFFFFFFFFFFFC
       mov       r8,24B41E11234
       shl       edx,2
       mov       ecx,edx
       mov       ecx,[r8+rcx]
       mov       [rax],ecx
       jmp       short M01_L08
M01_L06:
       mov       rcx,rdx
M01_L07:
       add       ecx,30
       mov       [rax-2],cx
M01_L08:
       xor       eax,eax
       mov       [rbp-78],rax
       mov       edi,1
M01_L09:
       xor       eax,eax
       mov       [rbp-78],rax
M01_L10:
       test      edi,edi
       je        near ptr M01_L32
       mov       ecx,[rbp-58]
       add       ecx,[rbp-70]
       mov       [rbp-58],ecx
M01_L11:
       mov       ecx,[rbp-58]
       mov       edx,[rbp-48]
       cmp       ecx,edx
       ja        near ptr M01_L41
       mov       rax,[rbp-50]
       mov       r8d,ecx
       lea       rax,[rax+r8*2]
       sub       edx,ecx
       cmp       edx,0C
       jb        near ptr M01_L39
       vmovups   xmm0,[7FFC037043A0]
       vmovups   [rax],xmm0
       mov       rcx,64006E006F0063
       mov       [rax+10],rcx
       mov       ecx,[rbp-58]
       add       ecx,0C
       mov       [rbp-58],ecx
M01_L12:
       mov       rdx,24B41E10008
       mov       r8,24B41E1B588
       cmp       rbx,1
       cmovne    rdx,r8
       cmp       byte ptr [rbp-54],0
       jne       near ptr M01_L40
       mov       r8d,[rbp-58]
       cmp       r8d,[rbp-48]
       ja        near ptr M01_L41
       mov       rcx,[rbp-50]
       mov       eax,r8d
       lea       rcx,[rcx+rax*2]
       mov       eax,[rbp-48]
       sub       eax,r8d
       mov       ebx,[rdx+8]
       cmp       ebx,eax
       ja        near ptr M01_L40
       mov       r8d,ebx
       add       r8,r8
       add       rdx,0C
       call      qword ptr [7FFC03655818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       ebx,[rbp-58]
       mov       [rbp-58],ebx
M01_L13:
       mov       ecx,[rbp-58]
       cmp       ecx,[rbp-48]
       ja        near ptr M01_L41
       mov       rax,[rbp-50]
       mov       [rbp-88],rax
       mov       [rbp-80],ecx
       lea       rcx,[rbp-88]
       call      System.String.Ctor(System.ReadOnlySpan`1<Char>)
       mov       rbx,rax
       mov       rdx,[rbp-60]
       xor       ecx,ecx
       mov       [rbp-60],rcx
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-50],xmm0
       mov       [rbp-58],ecx
       test      rdx,rdx
       je        short M01_L14
       mov       rcx,20AAD000C88
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FFC0390FB50]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
M01_L14:
       mov       rax,rbx
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
M01_L15:
       mov       ecx,3
       call      qword ptr [7FFC03D147B0]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M01_L00
M01_L16:
       mov       rcx,r14
       call      qword ptr [7FFC03A8D770]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r15d,eax
       mov       r13d,[r14+8]
       mov       rcx,rsi
       call      qword ptr [7FFC03A8D770]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       dword ptr [rsp+20],4
       mov       edx,r15d
       mov       r8d,r13d
       mov       rcx,rdi
       call      qword ptr [7FFC03D14E28]
       jmp       near ptr M01_L01
M01_L17:
       mov       rcx,[rsi+10]
       cmp       dword ptr [rcx+8],4
       jle       near ptr M01_L29
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        near ptr M01_L28
       mov       r14,[rcx+8]
       mov       rcx,offset MT_System.Threading.ProcessorIdCache
       call      qword ptr [7FFC03655740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       cmp       byte ptr [7FFC0359B17C],0
       je        short M01_L18
       call      qword ptr [7FFC03D14E40]
       mov       r15d,eax
       jmp       short M01_L20
M01_L18:
       mov       ecx,9
       call      qword ptr [7FFC03D14E58]
       mov       r15d,[rax+10]
       mov       ecx,9
       call      qword ptr [7FFC03D14E58]
       lea       ecx,[r15-1]
       mov       [rax+10],ecx
       movzx     eax,r15w
       test      eax,eax
       jne       short M01_L19
       call      qword ptr [7FFC03D14E70]
       mov       r15d,eax
       jmp       short M01_L20
M01_L19:
       sar       r15d,10
M01_L20:
       mov       rcx,offset MT_System.Buffers.SharedArrayPoolStatics
       call      qword ptr [7FFC03655740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       eax,r15d
       xor       edx,edx
       div       dword ptr [7FFC0359B170]
       mov       r15d,edx
       xor       r13d,r13d
       jmp       short M01_L24
M01_L21:
       cmp       r15d,[r14+8]
       jae       near ptr M01_L49
       mov       ecx,r15d
       mov       r12,[r14+rcx*8+10]
       cmp       [r12],r12b
       xor       eax,eax
       mov       [rbp-0B0],rax
       mov       rcx,r12
       call      qword ptr [7FFC03B7E328]; System.Threading.Monitor.Enter(System.Object)
       mov       rcx,[r12+8]
       mov       eax,[r12+10]
       dec       eax
       cmp       [rcx+8],eax
       jbe       short M01_L22
       mov       edx,eax
       mov       rdx,[rcx+rdx*8+10]
       mov       [rbp-0B0],rdx
       mov       r8d,eax
       xor       r10d,r10d
       mov       [rcx+r8*8+10],r10
       mov       [r12+10],eax
M01_L22:
       mov       rcx,r12
       call      qword ptr [7FFC03656820]; System.Threading.Monitor.Exit(System.Object)
       mov       r12,[rbp-0B0]
       test      r12,r12
       jne       short M01_L25
       inc       r15d
       cmp       [r14+8],r15d
       jne       short M01_L23
       xor       r15d,r15d
M01_L23:
       inc       r13d
M01_L24:
       cmp       [r14+8],r13d
       jg        near ptr M01_L21
       jmp       short M01_L26
M01_L25:
       mov       r14,r12
       jmp       short M01_L27
M01_L26:
       xor       r14d,r14d
M01_L27:
       test      r14,r14
       je        short M01_L28
       cmp       byte ptr [rdi+9D],0
       je        near ptr M01_L01
       mov       rcx,r14
       call      qword ptr [7FFC03A8D770]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r15d,eax
       mov       r13d,[r14+8]
       mov       rcx,rsi
       call      qword ptr [7FFC03A8D770]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       dword ptr [rsp+20],4
       mov       edx,r15d
       mov       r8d,r13d
       mov       rcx,rdi
       call      qword ptr [7FFC03D14E28]
       jmp       near ptr M01_L01
M01_L28:
       mov       edx,100
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
       cmp       byte ptr [rdi+9D],0
       je        near ptr M01_L01
       jmp       short M01_L30
M01_L29:
       mov       ecx,100
       mov       rdx,24B41E16F28
       call      qword ptr [7FFC0387DA40]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
       jmp       short M01_L28
M01_L30:
       mov       rcx,r14
       call      qword ptr [7FFC03A8D770]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r15d,eax
       mov       rcx,rsi
       call      qword ptr [7FFC03A8D770]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       edx,r15d
       mov       r8d,100
       mov       rcx,rdi
       call      qword ptr [7FFC03D14E28]
       mov       rcx,rsi
       call      qword ptr [7FFC03A8D770]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       rcx,[rsi+10]
       mov       edx,1
       mov       r8d,2
       cmp       dword ptr [rcx+8],4
       cmovg     edx,r8d
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       [rsp+28],edx
       mov       rcx,rdi
       mov       edx,r15d
       mov       r8d,100
       call      qword ptr [7FFC03D14E88]
       jmp       near ptr M01_L01
M01_L31:
       lea       rcx,[rbp-68]
       mov       rdx,rbx
       xor       r8d,r8d
       call      qword ptr [7FFC03D15158]
       jmp       near ptr M01_L11
M01_L32:
       lea       rcx,[rbp-68]
       call      qword ptr [7FFC03C65F50]
       jmp       near ptr M01_L02
M01_L33:
       test      rcx,rcx
       je        short M01_L34
       call      qword ptr [7FFC03BF5668]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider)
       jmp       short M01_L35
M01_L34:
       call      qword ptr [7FFC03875DD0]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
M01_L35:
       mov       r8,[rax+28]
       test      r8,r8
       jne       short M01_L36
       xor       r9d,r9d
       xor       ecx,ecx
       jmp       short M01_L37
M01_L36:
       lea       r9,[r8+0C]
       mov       ecx,[r8+8]
M01_L37:
       mov       [rbp-88],r9
       mov       [rbp-80],ecx
       mov       [rbp-98],rdi
       mov       [rbp-90],esi
       lea       r8,[rbp-70]
       mov       [rsp+20],r8
       lea       r8,[rbp-88]
       lea       r9,[rbp-98]
       mov       rcx,rbx
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFC03D162E0]
       mov       edi,eax
       jmp       near ptr M01_L10
M01_L38:
       xor       eax,eax
       mov       [rbp-70],eax
       xor       edi,edi
       jmp       near ptr M01_L09
M01_L39:
       lea       rcx,[rbp-68]
       mov       rdx,24B41E20B70
       call      qword ptr [7FFC03C675A0]
       jmp       near ptr M01_L12
M01_L40:
       lea       rcx,[rbp-68]
       call      qword ptr [7FFC03D14D20]
       jmp       near ptr M01_L13
M01_L41:
       call      qword ptr [7FFC037C7198]
       int       3
M01_L42:
       mov       rcx,rbx
       call      qword ptr [7FFC03B76C28]; System.TimeSpan.FromMilliseconds(Int64)
       mov       [rbp-40],rax
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.NumericExtensions
       call      qword ptr [7FFC03655728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,20AAD001DC8
       mov       rcx,[rcx]
       cmp       [rcx],ecx
       call      qword ptr [7FFC039D4078]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].get_Value()
       mov       [rbp-0A0],rax
       mov       rcx,[rbp-0A0]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp-0A8],rax
       lea       rcx,[rbp-40]
       call      qword ptr [7FFC03C6DBD8]
       test      eax,eax
       jle       short M01_L43
       lea       rcx,[rbp-40]
       call      qword ptr [7FFC03C6DBD8]
       mov       edx,eax
       mov       rcx,[rbp-0A8]
       cmp       [rcx],cl
       call      qword ptr [7FFC037CF198]; System.Text.StringBuilder.AppendSpanFormattable[[System.Int32, System.Private.CoreLib]](Int32)
       mov       rbx,rax
       lea       rcx,[rbp-40]
       call      qword ptr [7FFC03C6DBD8]
       mov       rdx,24B41E20BC8
       mov       rcx,24B41E20BA0
       cmp       eax,1
       cmovne    rdx,rcx
       mov       rcx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FFC037CF228]; System.Text.StringBuilder.Append(System.String)
M01_L43:
       lea       rcx,[rbp-40]
       call      qword ptr [7FFC03C6DC08]
       test      eax,eax
       jle       short M01_L45
       mov       rcx,[rbp-0A8]
       mov       edx,[rcx+1C]
       add       edx,[rcx+18]
       test      edx,edx
       jle       short M01_L44
       mov       edx,20
       call      qword ptr [7FFC037CF180]; System.Text.StringBuilder.Append(Char)
M01_L44:
       lea       rcx,[rbp-40]
       call      qword ptr [7FFC03C6DC08]
       mov       edx,eax
       mov       rcx,[rbp-0A8]
       call      qword ptr [7FFC037CF198]; System.Text.StringBuilder.AppendSpanFormattable[[System.Int32, System.Private.CoreLib]](Int32)
       mov       rbx,rax
       lea       rcx,[rbp-40]
       call      qword ptr [7FFC03C6DC08]
       mov       rdx,24B41E20C10
       mov       rcx,24B41E20BE8
       cmp       eax,1
       cmovne    rdx,rcx
       mov       rcx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FFC037CF228]; System.Text.StringBuilder.Append(System.String)
M01_L45:
       lea       rcx,[rbp-40]
       call      qword ptr [7FFC03C6DC38]
       test      eax,eax
       jg        short M01_L46
       mov       rcx,[rbp-0A8]
       mov       edx,[rcx+1C]
       add       edx,[rcx+18]
       jne       short M01_L48
M01_L46:
       mov       rcx,[rbp-0A8]
       mov       edx,[rcx+1C]
       add       edx,[rcx+18]
       test      edx,edx
       jle       short M01_L47
       mov       edx,20
       call      qword ptr [7FFC037CF180]; System.Text.StringBuilder.Append(Char)
M01_L47:
       lea       rcx,[rbp-40]
       call      qword ptr [7FFC03C6DC38]
       mov       edx,eax
       mov       rcx,[rbp-0A8]
       call      qword ptr [7FFC037CF198]; System.Text.StringBuilder.AppendSpanFormattable[[System.Int32, System.Private.CoreLib]](Int32)
       mov       rbx,rax
       lea       rcx,[rbp-40]
       call      qword ptr [7FFC03C6DC38]
       mov       rdx,24B41E20C60
       mov       rcx,24B41E20C38
       cmp       eax,1
       cmovne    rdx,rcx
       mov       rcx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FFC037CF228]; System.Text.StringBuilder.Append(System.String)
       mov       rcx,[rbp-0A8]
M01_L48:
       call      qword ptr [7FFC03842200]; System.Text.StringBuilder.ToString()
       mov       rbx,rax
       mov       rcx,[rbp-0A8]
       xor       edx,edx
       call      qword ptr [7FFC03C64CD8]; System.Text.StringBuilder.set_Length(Int32)
       mov       rcx,[rbp-0A0]
       mov       rdx,[rbp-0A8]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       rax,rbx
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
M01_L49:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       sub       rsp,38
       mov       rcx,[rbp-0A8]
       cmp       [rcx],cl
       xor       edx,edx
       call      qword ptr [7FFC03C64CD8]; System.Text.StringBuilder.set_Length(Int32)
       mov       rcx,[rbp-0A0]
       mov       rdx,[rbp-0A8]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       add       rsp,38
       ret
; Total bytes of code 2206
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.NumericExtensionsBenchmark.TryParseInvariantDecimalInvalid()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0C0
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+30],ymm4
       vmovdqu   ymmword ptr [rsp+50],ymm4
       vmovdqu   ymmword ptr [rsp+70],ymm4
       vmovdqu   ymmword ptr [rsp+90],ymm4
       xor       eax,eax
       mov       [rsp+0B0],rax
       mov       rax,1237624DA8F4
       mov       [rsp+0B8],rax
       mov       rbx,rcx
       mov       rsi,2BDD0190B7C
       mov       rcx,27D3B000100
       mov       rcx,[rcx]
       call      qword ptr [7FFC03BE5668]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider)
       lea       rdx,[rsp+30]
       xor       ecx,ecx
       mov       [rsp+88],ecx
       mov       [rsp+8C],ecx
       mov       byte ptr [rsp+90],0
       mov       byte ptr [rsp+91],0
       mov       byte ptr [rsp+92],2
       mov       [rsp+98],rdx
       mov       dword ptr [rsp+0A0],1F
       cmp       dword ptr [rsp+0A0],0
       jbe       near ptr M00_L06
       mov       rdx,[rsp+98]
       mov       byte ptr [rdx],0
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rsp+0A8],xmm0
       mov       [rsp+78],rsi
       mov       rdi,rsi
       mov       [rsp+70],rdi
       mov       [rsp+20],rax
       mov       rdx,[rsp+70]
       add       rdx,0E
       lea       rcx,[rsp+70]
       lea       r9,[rsp+88]
       mov       r8d,6F
       call      qword ptr [7FFC03C567A8]; System.Number.TryParseNumber[[System.Char, System.Private.CoreLib]](Char* ByRef, Char*, System.Globalization.NumberStyles, NumberBuffer ByRef, System.Globalization.NumberFormatInfo)
       test      eax,eax
       je        short M00_L01
       mov       rcx,[rsp+70]
       sub       rcx,rdi
       mov       rdx,rcx
       shr       rdx,3F
       add       rcx,rdx
       sar       rcx,1
       cmp       ecx,7
       jge       short M00_L00
       mov       [rsp+50],rsi
       mov       dword ptr [rsp+58],7
       lea       rcx,[rsp+50]
       mov       rdx,[rsp+70]
       sub       rdx,rdi
       mov       rax,rdx
       shr       rax,3F
       add       rdx,rax
       sar       rdx,1
       call      qword ptr [7FFC03C5EB80]
       test      eax,eax
       je        short M00_L01
M00_L00:
       xor       ecx,ecx
       mov       [rsp+78],rcx
       mov       ecx,1
       jmp       short M00_L02
M00_L01:
       xor       ecx,ecx
M00_L02:
       xor       edx,edx
       mov       [rsp+78],rdx
       test      ecx,ecx
       je        short M00_L03
       lea       rcx,[rsp+88]
       lea       rdx,[rsp+0A8]
       call      qword ptr [7FFC03C5EC58]
       xor       ecx,ecx
       mov       edx,2
       test      eax,eax
       cmove     ecx,edx
       jmp       short M00_L04
M00_L03:
       mov       ecx,1
M00_L04:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       mov       rax,[rbx+90]
       mov       [rax+4C],cl
       vmovups   xmm0,[rsp+0A8]
       vmovups   [rsp+60],xmm0
       mov       rcx,[rbx+90]
       cmp       [rcx],cl
       lea       rcx,[rsp+60]
       call      qword ptr [7FFC03C56838]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[System.Decimal, System.Private.CoreLib]](System.Decimal ByRef)
       mov       r8,1237624DA8F4
       cmp       [rsp+0B8],r8
       je        short M00_L05
       call      CORINFO_HELP_FAIL_FAST
M00_L05:
       nop
       add       rsp,0C0
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L06:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 498
```
```assembly
; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider)
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rax,offset MT_System.Globalization.CultureInfo
       cmp       [rbx],rax
       jne       short M01_L00
       mov       rax,[rbx+18]
       test      rax,rax
       je        short M01_L00
       add       rsp,20
       pop       rbx
       ret
M01_L00:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Globalization.NumberFormatInfo
       call      qword ptr [7FFC03646850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       short M01_L01
       mov       rcx,rbx
       mov       r11,7FFC035908A0
       mov       rdx,2BDD0186A68
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,offset MT_System.Globalization.NumberFormatInfo
       call      qword ptr [7FFC03646850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       short M01_L01
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFC03865DD0]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
M01_L01:
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 129
```
```assembly
; System.Number.TryParseNumber[[System.Char, System.Private.CoreLib]](Char* ByRef, Char*, System.Globalization.NumberStyles, NumberBuffer ByRef, System.Globalization.NumberFormatInfo)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,98
       xor       eax,eax
       mov       [rsp+38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+40],ymm4
       vmovdqu   ymmword ptr [rsp+60],ymm4
       vmovdqa   xmmword ptr [rsp+80],xmm4
       mov       [rsp+90],rax
       mov       rbp,rcx
       mov       rsi,rdx
       mov       ebx,r8d
       mov       rdi,r9
       mov       r14,[rsp+100]
       xor       r15d,r15d
       xor       r13d,r13d
       xor       r12d,r12d
       cmp       [r14],r14b
       test      ebx,100
       jne       near ptr M02_L31
       mov       r8,[r14+30]
       test      r8,r8
       jne       near ptr M02_L26
       xor       eax,eax
M02_L00:
       mov       r8,[r14+38]
       test      r8,r8
       jne       near ptr M02_L27
       xor       r10d,r10d
       xor       r9d,r9d
M02_L01:
       xor       r8d,r8d
       mov       r11,[rbp]
       cmp       r11,rsi
       jae       near ptr M02_L28
       movzx     ecx,word ptr [r11]
M02_L02:
       cmp       ecx,20
       je        near ptr M02_L38
       lea       edx,[rcx-9]
       cmp       edx,4
       jbe       near ptr M02_L38
M02_L03:
       test      bl,4
       je        near ptr M02_L15
       test      r8b,1
       jne       near ptr M02_L15
       mov       rdx,[r14+20]
       test      rdx,rdx
       jne       near ptr M02_L29
       xor       edx,edx
       mov       [rsp+48],r9d
M02_L04:
       mov       r9,r11
       mov       [rsp+60],rdx
       cmp       word ptr [rdx],0
       je        short M02_L07
M02_L05:
       cmp       r9,rsi
       jae       near ptr M02_L39
       mov       [rsp+28],r10
       movzx     r10d,word ptr [r9]
       mov       [rsp+20],r15
M02_L06:
       movzx     r15d,word ptr [rdx]
       cmp       r10d,r15d
       je        near ptr M02_L41
       cmp       r15d,0A0
       je        near ptr M02_L40
       cmp       r15d,202F
       je        near ptr M02_L40
       mov       r10,[rsp+28]
       mov       r15,[rsp+20]
M02_L07:
       xor       r9d,r9d
       mov       [rsp+60],r9
M02_L08:
       xor       edx,edx
       mov       [rsp+60],rdx
       test      r9,r9
       jne       near ptr M02_L49
       mov       r9,[r14+28]
       test      r9,r9
       jne       near ptr M02_L30
       xor       edx,edx
M02_L09:
       mov       r9,r11
       mov       [rsp+58],rdx
       cmp       word ptr [rdx],0
       je        short M02_L12
M02_L10:
       cmp       r9,rsi
       jae       near ptr M02_L43
       mov       [rsp+28],r10
       movzx     r10d,word ptr [r9]
       mov       [rsp+20],r15
M02_L11:
       movzx     r15d,word ptr [rdx]
       cmp       r10d,r15d
       je        near ptr M02_L45
       cmp       r15d,0A0
       je        near ptr M02_L44
       cmp       r15d,202F
       je        near ptr M02_L44
       mov       r10,[rsp+28]
       mov       r15,[rsp+20]
M02_L12:
       xor       r9d,r9d
       mov       [rsp+58],r9
M02_L13:
       xor       edx,edx
       mov       [rsp+58],rdx
       test      r9,r9
       jne       short M02_L14
       cmp       byte ptr [r14+12E],0
       jne       near ptr M02_L47
M02_L14:
       test      r9,r9
       jne       near ptr M02_L48
       mov       r9d,[rsp+48]
M02_L15:
       mov       [rsp+7C],ecx
       cmp       ecx,28
       je        near ptr M02_L50
M02_L16:
       test      r13d,r13d
       mov       [rsp+28],r10
       mov       [rsp+48],r9d
       jne       near ptr M02_L51
       mov       [rsp+20],r15
M02_L17:
       xor       edx,edx
       mov       [rsp+78],edx
       xor       r9d,r9d
       mov       [rsp+74],r9d
       mov       r10d,[rdi+18]
       dec       r10d
       mov       [rsp+70],r10d
       xor       r15d,r15d
       mov       [rsp+6C],r15d
M02_L18:
       mov       ecx,[rsp+7C]
       lea       r15d,[rcx-30]
       cmp       r15d,9
       jbe       near ptr M02_L57
       test      bl,20
       je        short M02_L23
       test      r8b,10
       jne       short M02_L23
       mov       r15,r11
       mov       [rsp+50],rax
       mov       [rsp+30],rax
       mov       r10,rax
       cmp       word ptr [r10],0
       je        short M02_L21
M02_L19:
       cmp       r15,rsi
       jae       near ptr M02_L68
       movzx     edx,word ptr [r15]
       mov       [rsp+4C],edx
M02_L20:
       movzx     edx,word ptr [r10]
       cmp       [rsp+4C],edx
       je        near ptr M02_L70
       cmp       edx,0A0
       je        near ptr M02_L69
       cmp       edx,202F
       je        near ptr M02_L69
M02_L21:
       xor       r10d,r10d
       mov       [rsp+50],r10
M02_L22:
       xor       r15d,r15d
       mov       [rsp+50],r15
       test      r10,r10
       jne       near ptr M02_L75
       test      r12d,r12d
       jne       near ptr M02_L71
       mov       rax,[rsp+30]
M02_L23:
       test      bl,40
       je        short M02_L24
       test      r8b,4
       jne       near ptr M02_L77
M02_L24:
       xor       r15d,r15d
       mov       r9d,[rsp+74]
       mov       [rdi],r9d
       lea       rdx,[rdi+10]
       cmp       r9d,[rdx+8]
       jae       near ptr M02_L145
       mov       rdx,[rdx]
       mov       [rsp+74],r9d
       mov       eax,r9d
       mov       byte ptr [rdx+rax],0
       mov       [rsp+8C],r8d
       test      r8b,4
       jne       near ptr M02_L88
M02_L25:
       mov       [rbp],r11
       xor       eax,eax
       add       rsp,98
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M02_L26:
       lea       rax,[r8+0C]
       mov       r8d,[r8+8]
       jmp       near ptr M02_L00
M02_L27:
       lea       r10,[r8+0C]
       mov       r9d,[r8+8]
       jmp       near ptr M02_L01
M02_L28:
       xor       ecx,ecx
       jmp       near ptr M02_L02
M02_L29:
       mov       [rsp+48],r9d
       lea       r9,[rdx+0C]
       mov       edx,[rdx+8]
       mov       rdx,r9
       jmp       near ptr M02_L04
M02_L30:
       lea       rdx,[r9+0C]
       mov       r9d,[r9+8]
       jmp       near ptr M02_L09
M02_L31:
       mov       rax,[r14+50]
       test      rax,rax
       jne       short M02_L32
       xor       r15d,r15d
       xor       r13d,r13d
       jmp       short M02_L33
M02_L32:
       lea       r15,[rax+0C]
       mov       r13d,[rax+8]
M02_L33:
       mov       [rsp+20],r15
       mov       r10,[r14+48]
       test      r10,r10
       jne       short M02_L34
       xor       eax,eax
       jmp       short M02_L35
M02_L34:
       lea       rax,[r10+0C]
       mov       r9d,[r10+8]
M02_L35:
       mov       [rsp+30],rax
       mov       r8,[r14+40]
       test      r8,r8
       jne       short M02_L36
       xor       r10d,r10d
       xor       r9d,r9d
       jmp       short M02_L37
M02_L36:
       lea       r10,[r8+0C]
       mov       r9d,[r8+8]
M02_L37:
       mov       [rsp+28],r10
       mov       [rsp+48],r9d
       mov       r9d,1
       mov       r12d,r9d
       mov       rax,[rsp+30]
       mov       r9d,[rsp+48]
       mov       r10,[rsp+28]
       mov       r15,[rsp+20]
       jmp       near ptr M02_L01
M02_L38:
       test      bl,1
       je        near ptr M02_L03
       test      r8b,1
       je        near ptr M02_L53
       test      r8b,20
       jne       near ptr M02_L53
       cmp       dword ptr [r14+118],2
       je        near ptr M02_L53
       jmp       near ptr M02_L03
M02_L39:
       mov       [rsp+28],r10
       xor       r10d,r10d
       mov       [rsp+20],r15
       jmp       near ptr M02_L06
M02_L40:
       cmp       r10d,20
       jne       short M02_L42
M02_L41:
       add       r9,2
       add       rdx,2
       cmp       word ptr [rdx],0
       mov       r10,[rsp+28]
       mov       r15,[rsp+20]
       jne       near ptr M02_L05
       jmp       near ptr M02_L08
M02_L42:
       mov       r10,[rsp+28]
       mov       r15,[rsp+20]
       jmp       near ptr M02_L07
M02_L43:
       mov       [rsp+28],r10
       xor       r10d,r10d
       mov       [rsp+20],r15
       jmp       near ptr M02_L11
M02_L44:
       cmp       r10d,20
       jne       short M02_L46
M02_L45:
       add       r9,2
       add       rdx,2
       cmp       word ptr [rdx],0
       mov       r10,[rsp+28]
       mov       r15,[rsp+20]
       jne       near ptr M02_L10
       jmp       near ptr M02_L13
M02_L46:
       mov       r10,[rsp+28]
       mov       r15,[rsp+20]
       jmp       near ptr M02_L12
M02_L47:
       cmp       r11,rsi
       jae       near ptr M02_L14
       cmp       word ptr [r11],2D
       jne       near ptr M02_L14
       lea       r9,[r11+2]
       jmp       near ptr M02_L14
M02_L48:
       mov       byte ptr [rdi+8],1
M02_L49:
       or        r8d,1
       jmp       near ptr M02_L52
M02_L50:
       test      bl,10
       je        near ptr M02_L16
       test      r8b,1
       jne       near ptr M02_L16
       or        r8d,3
       mov       [rsp+8C],r8d
       mov       byte ptr [rdi+8],1
       mov       r8d,[rsp+8C]
       jmp       near ptr M02_L53
M02_L51:
       mov       [rsp+8C],r8d
       mov       [rsp+30],rax
       mov       [rsp+38],r15
       mov       [rsp+40],r13d
       lea       r8,[rsp+38]
       mov       rdx,rsi
       mov       [rsp+80],r11
       mov       rcx,r11
       call      qword ptr [7FFC03C567C0]; System.Number.MatchChars[[System.Char, System.Private.CoreLib]](Char*, Char*, System.ReadOnlySpan`1<Char>)
       mov       r9,rax
       test      r9,r9
       mov       [rsp+20],r15
       mov       r11,[rsp+80]
       je        short M02_L54
       mov       r13d,[rsp+8C]
       or        r13d,20
       xor       r15d,r15d
       mov       [rsp+20],r15
       xor       r8d,r8d
       xor       eax,eax
       mov       r8d,r13d
       mov       r13d,eax
       mov       rax,[rsp+30]
       mov       r10,[rsp+28]
       mov       r15,[rsp+20]
M02_L52:
       lea       r11,[r9-2]
       mov       r9,r11
       mov       r9d,[rsp+48]
M02_L53:
       add       r11,2
       cmp       r11,rsi
       jb        short M02_L55
       xor       ecx,ecx
       jmp       short M02_L56
M02_L54:
       mov       rax,[rsp+30]
       mov       r8d,[rsp+8C]
       jmp       near ptr M02_L17
M02_L55:
       movzx     ecx,word ptr [r11]
M02_L56:
       jmp       near ptr M02_L02
M02_L57:
       or        r8d,4
       mov       ecx,[rsp+7C]
       cmp       ecx,30
       jne       short M02_L58
       test      r8b,8
       je        near ptr M02_L66
M02_L58:
       mov       edx,[rsp+78]
       mov       r10d,[rsp+70]
       cmp       edx,r10d
       jge       short M02_L60
       lea       r15,[rdi+10]
       cmp       edx,[r15+8]
       jae       near ptr M02_L145
       mov       r15,[r15]
       mov       [rsp+90],r15
       mov       [rsp+78],edx
       mov       r15d,edx
       mov       rdx,[rsp+90]
       mov       [rdx+r15],cl
       cmp       ecx,30
       jne       short M02_L59
       cmp       byte ptr [rdi+0A],1
       je        short M02_L61
M02_L59:
       mov       r15d,[rsp+78]
       lea       r9d,[r15+1]
       mov       [rsp+74],r9d
       mov       [rsp+78],r15d
       jmp       short M02_L61
M02_L60:
       cmp       ecx,30
       je        short M02_L63
       mov       byte ptr [rdi+9],1
       mov       [rsp+78],edx
M02_L61:
       test      r8b,10
       jne       short M02_L62
       lea       r15,[rdi+4]
       inc       dword ptr [r15]
M02_L62:
       mov       edx,[rsp+78]
       cmp       edx,r10d
       jge       short M02_L65
       cmp       ecx,30
       jne       short M02_L64
       mov       ecx,[rsp+6C]
       inc       ecx
       mov       [rsp+6C],ecx
       jmp       short M02_L65
M02_L63:
       mov       [rsp+78],edx
       jmp       short M02_L61
M02_L64:
       xor       ecx,ecx
       mov       [rsp+6C],ecx
M02_L65:
       inc       edx
       or        r8d,8
       jmp       near ptr M02_L85
M02_L66:
       test      r8b,10
       je        short M02_L67
       lea       rcx,[rdi+4]
       dec       dword ptr [rcx]
       mov       edx,[rsp+78]
       mov       r10d,[rsp+70]
       jmp       near ptr M02_L85
M02_L67:
       mov       edx,[rsp+78]
       mov       r10d,[rsp+70]
       jmp       near ptr M02_L85
M02_L68:
       xor       edx,edx
       mov       [rsp+4C],edx
       jmp       near ptr M02_L20
M02_L69:
       cmp       dword ptr [rsp+4C],20
       jne       near ptr M02_L21
M02_L70:
       add       r15,2
       add       r10,2
       cmp       word ptr [r10],0
       jne       near ptr M02_L19
       mov       r10,r15
       jmp       near ptr M02_L22
M02_L71:
       mov       [rsp+8C],r8d
       test      r8b,20
       jne       short M02_L72
       mov       r10,[r14+30]
       test      r10,r10
       jne       short M02_L73
       xor       r15d,r15d
       xor       r10d,r10d
       jmp       short M02_L74
M02_L72:
       mov       rax,[rsp+30]
       mov       r8d,[rsp+8C]
       jmp       near ptr M02_L23
M02_L73:
       lea       r15,[r10+0C]
       mov       r10d,[r10+8]
M02_L74:
       mov       [rsp+38],r15
       mov       [rsp+40],r10d
       lea       r8,[rsp+38]
       mov       rdx,rsi
       mov       [rsp+80],r11
       mov       rcx,r11
       call      qword ptr [7FFC03C567C0]; System.Number.MatchChars[[System.Char, System.Private.CoreLib]](Char*, Char*, System.ReadOnlySpan`1<Char>)
       mov       r10,rax
       test      r10,r10
       mov       r8d,[rsp+8C]
       mov       r11,[rsp+80]
       je        short M02_L76
M02_L75:
       or        r8d,10
       jmp       near ptr M02_L84
M02_L76:
       mov       rax,[rsp+30]
       jmp       near ptr M02_L23
M02_L77:
       mov       [rsp+8C],r8d
       test      r8b,10
       mov       [rsp+30],rax
       jne       near ptr M02_L81
       mov       r15,[rsp+28]
       mov       [rsp+38],r15
       mov       r15d,[rsp+48]
       mov       [rsp+40],r15d
       lea       r8,[rsp+38]
       mov       rdx,rsi
       mov       [rsp+80],r11
       mov       rcx,r11
       call      qword ptr [7FFC03C567C0]; System.Number.MatchChars[[System.Char, System.Private.CoreLib]](Char*, Char*, System.ReadOnlySpan`1<Char>)
       mov       r10,rax
       test      r10,r10
       jne       short M02_L80
       test      r12d,r12d
       je        short M02_L79
       test      byte ptr [rsp+8C],20
       jne       short M02_L78
       mov       r8,[r14+38]
       test      r8,r8
       jne       short M02_L82
       xor       edx,edx
       xor       ecx,ecx
       jmp       short M02_L83
M02_L78:
       mov       r8d,[rsp+8C]
       mov       r11,[rsp+80]
       jmp       near ptr M02_L24
M02_L79:
       mov       r8d,[rsp+8C]
       mov       r11,[rsp+80]
       jmp       near ptr M02_L24
M02_L80:
       mov       r8d,[rsp+8C]
       jmp       short M02_L84
M02_L81:
       mov       r8d,[rsp+8C]
       jmp       near ptr M02_L24
M02_L82:
       lea       rdx,[r8+0C]
       mov       ecx,[r8+8]
M02_L83:
       mov       [rsp+38],rdx
       mov       [rsp+40],ecx
       lea       r8,[rsp+38]
       mov       rdx,rsi
       mov       rcx,[rsp+80]
       call      qword ptr [7FFC03C567C0]; System.Number.MatchChars[[System.Char, System.Private.CoreLib]](Char*, Char*, System.ReadOnlySpan`1<Char>)
       mov       r10,rax
       test      r10,r10
       mov       r8d,[rsp+8C]
       mov       r11,[rsp+80]
       je        near ptr M02_L24
M02_L84:
       lea       rcx,[r10-2]
       mov       r11,rcx
       mov       rax,[rsp+30]
       mov       edx,[rsp+78]
       mov       r10d,[rsp+70]
M02_L85:
       add       r11,2
       cmp       r11,rsi
       jb        short M02_L86
       xor       r15d,r15d
       jmp       short M02_L87
M02_L86:
       movzx     r15d,word ptr [r11]
M02_L87:
       mov       [rsp+7C],r15d
       mov       [rsp+78],edx
       jmp       near ptr M02_L18
M02_L88:
       mov       ecx,[rsp+7C]
       cmp       ecx,45
       je        short M02_L89
       cmp       ecx,65
       jne       near ptr M02_L117
M02_L89:
       test      bl,80
       je        near ptr M02_L117
       mov       r12,r11
       lea       r11,[r12+2]
       mov       rax,r11
       cmp       rax,rsi
       jb        short M02_L90
       xor       ecx,ecx
       jmp       short M02_L91
M02_L90:
       movzx     ecx,word ptr [rax]
M02_L91:
       mov       [rsp+7C],ecx
       mov       rdx,[r14+20]
       test      rdx,rdx
       jne       short M02_L92
       xor       ecx,ecx
       xor       r11d,r11d
       jmp       short M02_L93
M02_L92:
       lea       rcx,[rdx+0C]
       mov       r11d,[rdx+8]
M02_L93:
       mov       [rsp+38],rcx
       mov       [rsp+40],r11d
       lea       r8,[rsp+38]
       mov       rdx,rsi
       mov       [rsp+80],rax
       mov       rcx,rax
       call      qword ptr [7FFC03C567C0]; System.Number.MatchChars[[System.Char, System.Private.CoreLib]](Char*, Char*, System.ReadOnlySpan`1<Char>)
       test      rax,rax
       je        short M02_L96
       cmp       rax,rsi
       jb        short M02_L94
       xor       r10d,r10d
       jmp       short M02_L95
M02_L94:
       movzx     r10d,word ptr [rax]
M02_L95:
       mov       [rsp+7C],r10d
       jmp       near ptr M02_L104
M02_L96:
       mov       rax,[rsp+80]
       mov       r8,[r14+28]
       test      r8,r8
       jne       short M02_L97
       xor       edx,edx
       xor       ecx,ecx
       jmp       short M02_L98
M02_L97:
       lea       rdx,[r8+0C]
       mov       ecx,[r8+8]
M02_L98:
       mov       [rsp+38],rdx
       mov       [rsp+40],ecx
       lea       r8,[rsp+38]
       mov       rdx,rsi
       mov       [rsp+80],rax
       mov       rcx,rax
       call      qword ptr [7FFC03C567C0]; System.Number.MatchChars[[System.Char, System.Private.CoreLib]](Char*, Char*, System.ReadOnlySpan`1<Char>)
       test      rax,rax
       jne       short M02_L99
       cmp       byte ptr [r14+12E],0
       je        short M02_L99
       mov       rdx,[rsp+80]
       cmp       rdx,rsi
       jae       short M02_L101
       lea       rcx,[rdx+2]
       cmp       word ptr [rdx],2D
       cmove     rax,rcx
       mov       [rsp+80],rdx
M02_L99:
       test      rax,rax
       je        short M02_L100
       mov       rdx,rax
       cmp       rdx,rsi
       jb        short M02_L102
       xor       r10d,r10d
       jmp       short M02_L103
M02_L100:
       mov       rax,[rsp+80]
       jmp       short M02_L104
M02_L101:
       mov       [rsp+80],rdx
       jmp       short M02_L99
M02_L102:
       movzx     r10d,word ptr [rdx]
M02_L103:
       mov       r15d,r10d
       mov       ecx,1
       mov       [rsp+7C],r15d
       mov       rax,rdx
       mov       r15d,ecx
M02_L104:
       mov       r10d,[rsp+7C]
       lea       ecx,[r10-30]
       cmp       ecx,9
       ja        near ptr M02_L114
       xor       ecx,ecx
M02_L105:
       cmp       ecx,5F5E100
       jge       short M02_L108
       lea       ecx,[rcx+rcx*4]
       lea       ecx,[r10+rcx*2-30]
       add       rax,2
       mov       r12,rax
       cmp       r12,rsi
       jb        short M02_L106
       xor       r10d,r10d
       jmp       short M02_L107
M02_L106:
       movzx     r10d,word ptr [r12]
M02_L107:
       mov       eax,r10d
       lea       edx,[rax-30]
       cmp       edx,9
       mov       r10d,eax
       mov       rax,r12
       jbe       short M02_L105
       jmp       short M02_L113
M02_L108:
       mov       ecx,7FFFFFFF
       xor       edx,edx
       mov       [rdi+4],edx
       jmp       short M02_L112
M02_L109:
       add       rax,2
       mov       r12,rax
       cmp       r12,rsi
       jb        short M02_L110
       xor       r10d,r10d
       jmp       short M02_L111
M02_L110:
       movzx     r10d,word ptr [r12]
M02_L111:
       mov       eax,r10d
       mov       r10d,eax
       mov       rax,r12
M02_L112:
       lea       edx,[r10-30]
       cmp       edx,9
       jbe       short M02_L109
M02_L113:
       mov       edx,ecx
       neg       edx
       test      r15d,r15d
       cmovne    ecx,edx
       lea       rdx,[rdi+4]
       add       [rdx],ecx
       mov       ecx,r10d
       mov       r11,rax
       jmp       short M02_L117
M02_L114:
       mov       rax,r12
       cmp       rax,rsi
       jb        short M02_L115
       xor       r10d,r10d
       jmp       short M02_L116
M02_L115:
       mov       [rsp+80],rax
       movzx     r10d,word ptr [rax]
       mov       rax,[rsp+80]
M02_L116:
       mov       r15d,r10d
       mov       ecx,r15d
       mov       r11,rax
M02_L117:
       cmp       byte ptr [rdi+0A],3
       jne       near ptr M02_L124
       cmp       byte ptr [rdi+9],0
       jne       near ptr M02_L123
       mov       r9d,[rsp+74]
       mov       eax,r9d
       sub       eax,[rdi+4]
       test      eax,eax
       jle       near ptr M02_L122
       mov       r15d,[rsp+6C]
       cmp       r15d,eax
       cmovle    eax,r15d
       sub       r9d,eax
       mov       [rdi],r9d
       mov       eax,[rdi]
       lea       rdx,[rdi+10]
       cmp       eax,[rdx+8]
       jae       near ptr M02_L145
       mov       rdx,[rdx]
       mov       byte ptr [rdx+rax],0
       mov       [rsp+80],r11
M02_L118:
       mov       [rsp+7C],ecx
       call      qword ptr [7FFC03866058]; System.Number.IsWhite(UInt32)
       test      eax,eax
       je        short M02_L119
       test      bl,2
       jne       near ptr M02_L138
M02_L119:
       test      bl,8
       je        short M02_L121
       mov       r15d,[rsp+8C]
       test      r15b,1
       jne       short M02_L120
       mov       r8,[r14+20]
       test      r8,r8
       jne       short M02_L125
       xor       edx,edx
       xor       ecx,ecx
       jmp       short M02_L126
M02_L120:
       mov       [rsp+8C],r15d
       mov       r12,[rsp+80]
       jmp       near ptr M02_L134
M02_L121:
       mov       r12,[rsp+80]
       jmp       near ptr M02_L134
M02_L122:
       mov       [rsp+80],r11
       jmp       short M02_L118
M02_L123:
       mov       [rsp+80],r11
       jmp       short M02_L118
M02_L124:
       mov       [rsp+80],r11
       jmp       short M02_L118
M02_L125:
       lea       rdx,[r8+0C]
       mov       ecx,[r8+8]
M02_L126:
       mov       [rsp+38],rdx
       mov       [rsp+40],ecx
       lea       r8,[rsp+38]
       mov       rdx,rsi
       mov       rcx,[rsp+80]
       call      qword ptr [7FFC03C567C0]; System.Number.MatchChars[[System.Char, System.Private.CoreLib]](Char*, Char*, System.ReadOnlySpan`1<Char>)
       mov       r10,rax
       test      r10,r10
       jne       short M02_L130
       mov       r8,[r14+28]
       test      r8,r8
       jne       short M02_L127
       xor       edx,edx
       xor       ecx,ecx
       jmp       short M02_L128
M02_L127:
       lea       rdx,[r8+0C]
       mov       ecx,[r8+8]
M02_L128:
       mov       [rsp+38],rdx
       mov       [rsp+40],ecx
       lea       r8,[rsp+38]
       mov       rdx,rsi
       mov       rcx,[rsp+80]
       call      qword ptr [7FFC03C567C0]; System.Number.MatchChars[[System.Char, System.Private.CoreLib]](Char*, Char*, System.ReadOnlySpan`1<Char>)
       mov       r10,rax
       test      r10,r10
       jne       short M02_L133
       cmp       byte ptr [r14+12E],0
       je        short M02_L132
       mov       r12,[rsp+80]
       cmp       r12,rsi
       jae       short M02_L129
       cmp       word ptr [r12],2D
       jne       short M02_L129
       lea       r10,[r12+2]
M02_L129:
       test      r10,r10
       je        short M02_L131
       mov       byte ptr [rdi+8],1
M02_L130:
       or        r15d,1
       jmp       near ptr M02_L137
M02_L131:
       mov       [rsp+8C],r15d
       jmp       short M02_L134
M02_L132:
       mov       r12,[rsp+80]
       jmp       short M02_L129
M02_L133:
       mov       r12,[rsp+80]
       jmp       short M02_L129
M02_L134:
       cmp       dword ptr [rsp+7C],29
       jne       short M02_L136
       mov       r15d,[rsp+8C]
       test      r15b,2
       je        short M02_L135
       and       r15d,0FFFFFFFD
       mov       [rsp+80],r12
       mov       [rsp+8C],r15d
       jmp       short M02_L138
M02_L135:
       mov       [rsp+8C],r15d
M02_L136:
       test      r13d,r13d
       je        short M02_L141
       mov       rax,[rsp+20]
       mov       [rsp+38],rax
       mov       [rsp+40],r13d
       lea       r8,[rsp+38]
       mov       rdx,rsi
       mov       rcx,r12
       call      qword ptr [7FFC03C567C0]; System.Number.MatchChars[[System.Char, System.Private.CoreLib]](Char*, Char*, System.ReadOnlySpan`1<Char>)
       mov       r10,rax
       test      r10,r10
       je        short M02_L141
       xor       eax,eax
       mov       r12,rax
       xor       r13d,r13d
       mov       [rsp+20],r12
       mov       r15d,[rsp+8C]
M02_L137:
       lea       rax,[r10-2]
       mov       rcx,rax
       mov       [rsp+80],rcx
       mov       [rsp+8C],r15d
M02_L138:
       mov       rcx,[rsp+80]
       add       rcx,2
       cmp       rcx,rsi
       jb        short M02_L139
       xor       eax,eax
       jmp       short M02_L140
M02_L139:
       movzx     eax,word ptr [rcx]
M02_L140:
       mov       [rsp+80],rcx
       mov       ecx,eax
       jmp       near ptr M02_L118
M02_L141:
       mov       r15d,[rsp+8C]
       test      r15b,2
       jne       short M02_L144
       test      r15b,8
       jne       short M02_L143
       cmp       byte ptr [rdi+0A],2
       je        short M02_L142
       xor       eax,eax
       mov       [rdi+4],eax
M02_L142:
       cmp       byte ptr [rdi+0A],1
       jne       short M02_L143
       test      r15b,10
       jne       short M02_L143
       mov       byte ptr [rdi+8],0
M02_L143:
       mov       [rbp],r12
       mov       eax,1
       add       rsp,98
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M02_L144:
       mov       r11,r12
       jmp       near ptr M02_L25
M02_L145:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 3316
```
```assembly
; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[System.Decimal, System.Private.CoreLib]](System.Decimal ByRef)
       ret
; Total bytes of code 1
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.NumericExtensionsBenchmark.TryParseInvariantDecimalValid()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0C0
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+30],ymm4
       vmovdqu   ymmword ptr [rsp+50],ymm4
       vmovdqu   ymmword ptr [rsp+70],ymm4
       vmovdqu   ymmword ptr [rsp+90],ymm4
       xor       eax,eax
       mov       [rsp+0B0],rax
       mov       rax,71A7F1AC677D
       mov       [rsp+0B8],rax
       mov       rbx,rcx
       mov       rsi,1D194430B7C
       mov       rcx,190FF400100
       mov       rcx,[rcx]
       call      qword ptr [7FFC03BE5668]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider)
       lea       rdx,[rsp+30]
       xor       ecx,ecx
       mov       [rsp+88],ecx
       mov       [rsp+8C],ecx
       mov       byte ptr [rsp+90],0
       mov       byte ptr [rsp+91],0
       mov       byte ptr [rsp+92],2
       mov       [rsp+98],rdx
       mov       dword ptr [rsp+0A0],1F
       cmp       dword ptr [rsp+0A0],0
       jbe       near ptr M00_L06
       mov       rdx,[rsp+98]
       mov       byte ptr [rdx],0
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rsp+0A8],xmm0
       mov       [rsp+78],rsi
       mov       rdi,rsi
       mov       [rsp+70],rdi
       mov       [rsp+20],rax
       mov       rdx,[rsp+70]
       add       rdx,12
       lea       rcx,[rsp+70]
       lea       r9,[rsp+88]
       mov       r8d,6F
       call      qword ptr [7FFC03C568E0]; System.Number.TryParseNumber[[System.Char, System.Private.CoreLib]](Char* ByRef, Char*, System.Globalization.NumberStyles, NumberBuffer ByRef, System.Globalization.NumberFormatInfo)
       test      eax,eax
       je        short M00_L01
       mov       rcx,[rsp+70]
       sub       rcx,rdi
       mov       rdx,rcx
       shr       rdx,3F
       add       rcx,rdx
       sar       rcx,1
       cmp       ecx,9
       jge       short M00_L00
       mov       [rsp+50],rsi
       mov       dword ptr [rsp+58],9
       lea       rcx,[rsp+50]
       mov       rdx,[rsp+70]
       sub       rdx,rdi
       mov       rax,rdx
       shr       rax,3F
       add       rdx,rax
       sar       rdx,1
       call      qword ptr [7FFC03C5EBE0]
       test      eax,eax
       je        short M00_L01
M00_L00:
       xor       ecx,ecx
       mov       [rsp+78],rcx
       mov       ecx,1
       jmp       short M00_L02
M00_L01:
       xor       ecx,ecx
M00_L02:
       xor       edx,edx
       mov       [rsp+78],rdx
       test      ecx,ecx
       je        short M00_L03
       lea       rcx,[rsp+88]
       lea       rdx,[rsp+0A8]
       call      qword ptr [7FFC03C56910]; System.Number.TryNumberToDecimal(NumberBuffer ByRef, System.Decimal ByRef)
       xor       ecx,ecx
       mov       edx,2
       test      eax,eax
       cmove     ecx,edx
       jmp       short M00_L04
M00_L03:
       mov       ecx,1
M00_L04:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       mov       rax,[rbx+90]
       mov       [rax+4C],cl
       vmovups   xmm0,[rsp+0A8]
       vmovups   [rsp+60],xmm0
       mov       rcx,[rbx+90]
       cmp       [rcx],cl
       lea       rcx,[rsp+60]
       call      qword ptr [7FFC03C56988]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[System.Decimal, System.Private.CoreLib]](System.Decimal ByRef)
       mov       r8,71A7F1AC677D
       cmp       [rsp+0B8],r8
       je        short M00_L05
       call      CORINFO_HELP_FAIL_FAST
M00_L05:
       nop
       add       rsp,0C0
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L06:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 498
```
```assembly
; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider)
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rax,offset MT_System.Globalization.CultureInfo
       cmp       [rbx],rax
       jne       short M01_L00
       mov       rax,[rbx+18]
       test      rax,rax
       je        short M01_L00
       add       rsp,20
       pop       rbx
       ret
M01_L00:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Globalization.NumberFormatInfo
       call      qword ptr [7FFC03646850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       short M01_L01
       mov       rcx,rbx
       mov       r11,7FFC035908A0
       mov       rdx,1D194426A68
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,offset MT_System.Globalization.NumberFormatInfo
       call      qword ptr [7FFC03646850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       short M01_L01
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFC03865DD0]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
M01_L01:
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 129
```
```assembly
; System.Number.TryParseNumber[[System.Char, System.Private.CoreLib]](Char* ByRef, Char*, System.Globalization.NumberStyles, NumberBuffer ByRef, System.Globalization.NumberFormatInfo)
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
       vmovdqu   ymmword ptr [rsp+50],ymm4
       vmovdqu   ymmword ptr [rsp+70],ymm4
       vmovdqa   xmmword ptr [rsp+90],xmm4
       mov       r14,rcx
       mov       rsi,rdx
       mov       edi,r8d
       mov       rbx,r9
       mov       rbp,[rsp+130]
       xor       r15d,r15d
       xor       r13d,r13d
       xor       r12d,r12d
       cmp       [rbp],bpl
       test      edi,100
       jne       near ptr M02_L73
       mov       r8,[rbp+30]
       test      r8,r8
       jne       near ptr M02_L28
       xor       eax,eax
M02_L00:
       mov       r8,[rbp+38]
       test      r8,r8
       jne       near ptr M02_L29
       xor       r10d,r10d
       xor       r9d,r9d
M02_L01:
       xor       r8d,r8d
       mov       r11,[r14]
       cmp       r11,rsi
       jae       near ptr M02_L30
       movzx     ecx,word ptr [r11]
M02_L02:
       cmp       ecx,20
       je        near ptr M02_L80
       lea       edx,[rcx-9]
       cmp       edx,4
       jbe       near ptr M02_L80
M02_L03:
       test      dil,4
       je        near ptr M02_L15
       test      r8b,1
       jne       near ptr M02_L15
       mov       rdx,[rbp+20]
       test      rdx,rdx
       jne       near ptr M02_L31
       xor       edx,edx
       mov       [rsp+6C],r9d
M02_L04:
       mov       r9,r11
       mov       [rsp+98],rdx
       cmp       word ptr [rdx],0
       je        short M02_L07
M02_L05:
       cmp       r9,rsi
       jae       near ptr M02_L32
       mov       [rsp+30],r10
       movzx     r10d,word ptr [r9]
       mov       [rsp+0C4],r12d
M02_L06:
       movzx     r12d,word ptr [rdx]
       cmp       r10d,r12d
       je        near ptr M02_L33
       cmp       r12d,0A0
       je        near ptr M02_L81
       cmp       r12d,202F
       je        near ptr M02_L81
       mov       r10,[rsp+30]
       mov       r12d,[rsp+0C4]
M02_L07:
       xor       r9d,r9d
       mov       [rsp+98],r9
M02_L08:
       xor       edx,edx
       mov       [rsp+98],rdx
       test      r9,r9
       jne       near ptr M02_L85
       mov       r9,[rbp+28]
       test      r9,r9
       jne       near ptr M02_L34
       xor       edx,edx
M02_L09:
       mov       r9,r11
       mov       [rsp+90],rdx
       cmp       word ptr [rdx],0
       je        short M02_L12
M02_L10:
       cmp       r9,rsi
       jae       near ptr M02_L35
       mov       [rsp+30],r10
       movzx     r10d,word ptr [r9]
       mov       [rsp+0C4],r12d
M02_L11:
       movzx     r12d,word ptr [rdx]
       cmp       r10d,r12d
       je        near ptr M02_L36
       cmp       r12d,0A0
       je        near ptr M02_L82
       cmp       r12d,202F
       je        near ptr M02_L82
       mov       r10,[rsp+30]
       mov       r12d,[rsp+0C4]
M02_L12:
       xor       r9d,r9d
       mov       [rsp+90],r9
M02_L13:
       xor       edx,edx
       mov       [rsp+90],rdx
       test      r9,r9
       jne       short M02_L14
       cmp       byte ptr [rbp+12E],0
       jne       near ptr M02_L83
M02_L14:
       test      r9,r9
       jne       near ptr M02_L84
       mov       r9d,[rsp+6C]
M02_L15:
       mov       [rsp+0B4],ecx
       cmp       ecx,28
       je        near ptr M02_L87
M02_L16:
       test      r13d,r13d
       mov       [rsp+30],r10
       mov       [rsp+6C],r9d
       jne       near ptr M02_L88
       mov       [rsp+0C4],r12d
M02_L17:
       xor       edx,edx
       xor       r9d,r9d
       mov       r10d,[rbx+18]
       dec       r10d
       mov       [rsp+0A8],r10d
       xor       r12d,r12d
       mov       [rsp+28],r15
       jmp       short M02_L24
M02_L18:
       xor       ecx,ecx
       jmp       short M02_L23
M02_L19:
       lea       r9,[rbx+4]
       inc       dword ptr [r9]
M02_L20:
       cmp       edx,r10d
       jge       short M02_L21
       cmp       ecx,30
       je        near ptr M02_L97
       xor       r12d,r12d
M02_L21:
       inc       edx
       mov       [rsp+0B0],edx
       or        r8d,8
M02_L22:
       add       r11,2
       mov       r9,r11
       cmp       r9,rsi
       jae       short M02_L18
       movzx     ecx,word ptr [r9]
M02_L23:
       mov       r11d,ecx
       mov       [rsp+0B4],r11d
       mov       r11,r9
       mov       rax,[rsp+38]
       mov       edx,[rsp+0B0]
       mov       r9d,[rsp+0AC]
       mov       r10d,[rsp+0A8]
M02_L24:
       mov       ecx,[rsp+0B4]
       lea       r15d,[rcx-30]
       cmp       r15d,9
       ja        near ptr M02_L37
       or        r8d,4
       cmp       ecx,30
       je        near ptr M02_L94
M02_L25:
       cmp       edx,r10d
       jge       near ptr M02_L96
       mov       [rsp+38],rax
       lea       r15,[rbx+10]
       cmp       edx,[r15+8]
       jae       near ptr M02_L160
       mov       r15,[r15]
       mov       eax,edx
       mov       [r15+rax],cl
       cmp       ecx,30
       je        near ptr M02_L95
M02_L26:
       lea       r9d,[rdx+1]
       mov       [rsp+0AC],r9d
M02_L27:
       test      r8b,10
       jne       near ptr M02_L20
       jmp       near ptr M02_L19
M02_L28:
       lea       rax,[r8+0C]
       mov       r8d,[r8+8]
       jmp       near ptr M02_L00
M02_L29:
       lea       r10,[r8+0C]
       mov       r9d,[r8+8]
       jmp       near ptr M02_L01
M02_L30:
       xor       ecx,ecx
       jmp       near ptr M02_L02
M02_L31:
       mov       [rsp+6C],r9d
       lea       r9,[rdx+0C]
       mov       edx,[rdx+8]
       mov       rdx,r9
       jmp       near ptr M02_L04
M02_L32:
       mov       [rsp+30],r10
       xor       r10d,r10d
       mov       [rsp+0C4],r12d
       jmp       near ptr M02_L06
M02_L33:
       add       r9,2
       add       rdx,2
       cmp       word ptr [rdx],0
       mov       r10,[rsp+30]
       mov       r12d,[rsp+0C4]
       jne       near ptr M02_L05
       jmp       near ptr M02_L08
M02_L34:
       lea       rdx,[r9+0C]
       mov       r9d,[r9+8]
       jmp       near ptr M02_L09
M02_L35:
       mov       [rsp+30],r10
       xor       r10d,r10d
       mov       [rsp+0C4],r12d
       jmp       near ptr M02_L11
M02_L36:
       add       r9,2
       add       rdx,2
       cmp       word ptr [rdx],0
       mov       r10,[rsp+30]
       mov       r12d,[rsp+0C4]
       jne       near ptr M02_L10
       jmp       near ptr M02_L13
M02_L37:
       test      dil,20
       je        short M02_L38
       test      r8b,10
       je        near ptr M02_L58
M02_L38:
       test      dil,40
       je        short M02_L39
       test      r8b,4
       je        short M02_L39
       mov       [rsp+0C0],r8d
       test      r8b,10
       mov       [rsp+0B0],edx
       mov       [rsp+38],rax
       je        near ptr M02_L108
       mov       r8d,[rsp+0C0]
M02_L39:
       xor       r15d,r15d
       mov       [rbx],r9d
       lea       rdx,[rbx+10]
       cmp       r9d,[rdx+8]
       jae       near ptr M02_L160
       mov       rdx,[rdx]
       mov       [rsp+0AC],r9d
       mov       eax,r9d
       mov       byte ptr [rdx+rax],0
       mov       [rsp+0C0],r8d
       test      r8b,4
       je        near ptr M02_L159
       cmp       ecx,45
       je        near ptr M02_L115
       cmp       ecx,65
       je        near ptr M02_L115
M02_L40:
       cmp       byte ptr [rbx+0A],3
       je        near ptr M02_L142
M02_L41:
       cmp       ecx,20
       je        near ptr M02_L143
       lea       edx,[rcx-9]
       cmp       edx,4
       jbe       near ptr M02_L143
M02_L42:
       test      dil,8
       je        near ptr M02_L54
       mov       r8d,[rsp+0C0]
       test      r8b,1
       jne       near ptr M02_L144
       mov       rdx,[rbp+20]
       test      rdx,rdx
       jne       near ptr M02_L67
       xor       eax,eax
M02_L43:
       mov       rdx,r11
       mov       [rsp+78],rax
       cmp       word ptr [rax],0
       je        short M02_L46
M02_L44:
       cmp       rdx,rsi
       jae       near ptr M02_L68
       movzx     r10d,word ptr [rdx]
M02_L45:
       movzx     r9d,word ptr [rax]
       cmp       r10d,r9d
       je        near ptr M02_L69
       cmp       r9d,0A0
       je        near ptr M02_L145
       cmp       r9d,202F
       je        near ptr M02_L145
M02_L46:
       xor       eax,eax
       mov       [rsp+78],rax
M02_L47:
       xor       edx,edx
       mov       [rsp+78],rdx
       test      rax,rax
       jne       near ptr M02_L149
       mov       rax,[rbp+28]
       test      rax,rax
       jne       near ptr M02_L70
       xor       edx,edx
M02_L48:
       mov       rax,r11
       mov       [rsp+70],rdx
       cmp       word ptr [rdx],0
       je        short M02_L51
M02_L49:
       cmp       rax,rsi
       jae       near ptr M02_L71
       movzx     r10d,word ptr [rax]
M02_L50:
       movzx     r9d,word ptr [rdx]
       cmp       r10d,r9d
       je        near ptr M02_L72
       cmp       r9d,0A0
       je        near ptr M02_L146
       cmp       r9d,202F
       je        near ptr M02_L146
M02_L51:
       xor       eax,eax
       mov       [rsp+70],rax
M02_L52:
       xor       edx,edx
       mov       [rsp+70],rdx
       test      rax,rax
       jne       short M02_L53
       cmp       byte ptr [rbp+12E],0
       jne       near ptr M02_L147
M02_L53:
       test      rax,rax
       jne       near ptr M02_L148
       mov       [rsp+0C0],r8d
M02_L54:
       cmp       ecx,29
       je        near ptr M02_L150
M02_L55:
       test      r13d,r13d
       jne       near ptr M02_L152
M02_L56:
       mov       r8d,[rsp+0C0]
       test      r8b,2
       jne       near ptr M02_L159
       test      r8b,8
       je        near ptr M02_L157
M02_L57:
       mov       [r14],r11
       mov       eax,1
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
M02_L58:
       mov       r15,r11
       mov       [rsp+88],rax
       mov       [rsp+38],rax
       cmp       word ptr [rax],0
       je        short M02_L61
M02_L59:
       cmp       r15,rsi
       jae       short M02_L65
       mov       [rsp+68],r13d
       movzx     r13d,word ptr [r15]
       mov       [rsp+84],r13d
M02_L60:
       movzx     r13d,word ptr [rax]
       cmp       [rsp+84],r13d
       je        short M02_L66
       cmp       r13d,0A0
       je        near ptr M02_L101
       cmp       r13d,202F
       je        near ptr M02_L101
       mov       r13d,[rsp+68]
M02_L61:
       xor       eax,eax
       mov       [rsp+88],rax
M02_L62:
       xor       r15d,r15d
       mov       [rsp+88],r15
       test      rax,rax
       je        near ptr M02_L102
M02_L63:
       or        r8d,10
M02_L64:
       lea       rcx,[rax-2]
       mov       r11,rcx
       mov       [rsp+0B0],edx
       mov       [rsp+0AC],r9d
       jmp       near ptr M02_L22
M02_L65:
       mov       [rsp+68],r13d
       xor       r13d,r13d
       mov       [rsp+84],r13d
       jmp       short M02_L60
M02_L66:
       add       r15,2
       add       rax,2
       cmp       word ptr [rax],0
       mov       r13d,[rsp+68]
       jne       near ptr M02_L59
       mov       rax,r15
       jmp       short M02_L62
M02_L67:
       lea       rax,[rdx+0C]
       mov       edx,[rdx+8]
       jmp       near ptr M02_L43
M02_L68:
       xor       r10d,r10d
       jmp       near ptr M02_L45
M02_L69:
       add       rdx,2
       add       rax,2
       cmp       word ptr [rax],0
       jne       near ptr M02_L44
       mov       rax,rdx
       jmp       near ptr M02_L47
M02_L70:
       lea       rdx,[rax+0C]
       mov       eax,[rax+8]
       jmp       near ptr M02_L48
M02_L71:
       xor       r10d,r10d
       jmp       near ptr M02_L50
M02_L72:
       add       rax,2
       add       rdx,2
       cmp       word ptr [rdx],0
       jne       near ptr M02_L49
       jmp       near ptr M02_L52
M02_L73:
       mov       rax,[rbp+50]
       test      rax,rax
       jne       short M02_L74
       xor       r15d,r15d
       xor       r13d,r13d
       jmp       short M02_L75
M02_L74:
       lea       r15,[rax+0C]
       mov       r13d,[rax+8]
M02_L75:
       mov       r10,[rbp+48]
       test      r10,r10
       jne       short M02_L76
       xor       eax,eax
       jmp       short M02_L77
M02_L76:
       lea       rax,[r10+0C]
       mov       r9d,[r10+8]
M02_L77:
       mov       [rsp+38],rax
       mov       r8,[rbp+40]
       test      r8,r8
       jne       short M02_L78
       xor       r10d,r10d
       xor       r9d,r9d
       jmp       short M02_L79
M02_L78:
       lea       r10,[r8+0C]
       mov       r9d,[r8+8]
M02_L79:
       mov       [rsp+30],r10
       mov       [rsp+6C],r9d
       mov       dword ptr [rsp+0C4],1
       mov       rax,[rsp+38]
       mov       r9d,[rsp+6C]
       mov       r10,[rsp+30]
       mov       r12d,[rsp+0C4]
       jmp       near ptr M02_L01
M02_L80:
       test      dil,1
       je        near ptr M02_L03
       test      r8b,1
       je        near ptr M02_L90
       test      r8b,20
       jne       near ptr M02_L90
       cmp       dword ptr [rbp+118],2
       je        near ptr M02_L90
       jmp       near ptr M02_L03
M02_L81:
       cmp       r10d,20
       je        near ptr M02_L33
       mov       r10,[rsp+30]
       mov       r12d,[rsp+0C4]
       jmp       near ptr M02_L07
M02_L82:
       cmp       r10d,20
       jne       short M02_L86
       jmp       near ptr M02_L36
M02_L83:
       cmp       r11,rsi
       jae       near ptr M02_L14
       cmp       word ptr [r11],2D
       jne       near ptr M02_L14
       lea       r9,[r11+2]
       jmp       near ptr M02_L14
M02_L84:
       mov       byte ptr [rbx+8],1
M02_L85:
       or        r8d,1
       jmp       near ptr M02_L89
M02_L86:
       mov       r10,[rsp+30]
       mov       r12d,[rsp+0C4]
       jmp       near ptr M02_L12
M02_L87:
       test      dil,10
       je        near ptr M02_L16
       test      r8b,1
       jne       near ptr M02_L16
       or        r8d,3
       mov       [rsp+0C0],r8d
       mov       byte ptr [rbx+8],1
       mov       r8d,[rsp+0C0]
       jmp       near ptr M02_L90
M02_L88:
       mov       [rsp+0C0],r8d
       mov       [rsp+38],rax
       mov       [rsp+50],r15
       mov       [rsp+58],r13d
       lea       r8,[rsp+50]
       mov       rdx,rsi
       mov       [rsp+0B8],r11
       mov       rcx,r11
       call      qword ptr [7FFC03C568F8]; System.Number.MatchChars[[System.Char, System.Private.CoreLib]](Char*, Char*, System.ReadOnlySpan`1<Char>)
       mov       r9,rax
       test      r9,r9
       mov       r11,[rsp+0B8]
       je        short M02_L91
       mov       r13d,[rsp+0C0]
       or        r13d,20
       xor       r15d,r15d
       mov       [rsp+28],r15
       xor       r8d,r8d
       mov       [rsp+68],r8d
       mov       r8d,r13d
       mov       rax,[rsp+38]
       mov       r10,[rsp+30]
       mov       r13d,[rsp+68]
       mov       r15,[rsp+28]
M02_L89:
       lea       r11,[r9-2]
       mov       r9,r11
       mov       r9d,[rsp+6C]
M02_L90:
       add       r11,2
       cmp       r11,rsi
       jb        short M02_L92
       xor       ecx,ecx
       jmp       short M02_L93
M02_L91:
       mov       [rsp+0C4],r12d
       mov       rax,[rsp+38]
       mov       r8d,[rsp+0C0]
       jmp       near ptr M02_L17
M02_L92:
       movzx     ecx,word ptr [r11]
M02_L93:
       jmp       near ptr M02_L02
M02_L94:
       test      r8b,8
       je        short M02_L99
       jmp       near ptr M02_L25
M02_L95:
       cmp       byte ptr [rbx+0A],1
       mov       [rsp+0AC],r9d
       je        near ptr M02_L27
       jmp       near ptr M02_L26
M02_L96:
       cmp       ecx,30
       je        short M02_L98
       mov       byte ptr [rbx+9],1
       mov       [rsp+0AC],r9d
       mov       [rsp+38],rax
       jmp       near ptr M02_L27
M02_L97:
       inc       r12d
       jmp       near ptr M02_L21
M02_L98:
       mov       [rsp+0AC],r9d
       mov       [rsp+38],rax
       jmp       near ptr M02_L27
M02_L99:
       test      r8b,10
       je        short M02_L100
       lea       rcx,[rbx+4]
       dec       dword ptr [rcx]
       mov       [rsp+0B0],edx
       mov       [rsp+0AC],r9d
       mov       [rsp+38],rax
       jmp       near ptr M02_L22
M02_L100:
       mov       [rsp+0B0],edx
       mov       [rsp+0AC],r9d
       mov       [rsp+38],rax
       jmp       near ptr M02_L22
M02_L101:
       cmp       dword ptr [rsp+84],20
       jne       short M02_L105
       jmp       near ptr M02_L66
M02_L102:
       cmp       dword ptr [rsp+0C4],0
       je        short M02_L104
       mov       [rsp+0C0],r8d
       test      r8b,20
       jne       short M02_L103
       mov       rax,[rbp+30]
       mov       [rsp+48],rax
       test      rax,rax
       jne       short M02_L106
       xor       eax,eax
       mov       [rsp+20],rax
       xor       eax,eax
       mov       [rsp+0B4],ecx
       mov       [rsp+0B0],edx
       mov       [rsp+0AC],r9d
       mov       [rsp+64],eax
       jmp       short M02_L107
M02_L103:
       mov       rax,[rsp+38]
       mov       r8d,[rsp+0C0]
       jmp       near ptr M02_L38
M02_L104:
       mov       rax,[rsp+38]
       jmp       near ptr M02_L38
M02_L105:
       mov       r13d,[rsp+68]
       jmp       near ptr M02_L61
M02_L106:
       add       rax,0C
       mov       [rsp+40],rax
       mov       rax,[rsp+48]
       mov       eax,[rax+8]
       mov       [rsp+80],eax
       mov       rax,[rsp+40]
       mov       [rsp+20],rax
       mov       eax,[rsp+80]
       mov       [rsp+64],eax
       mov       [rsp+0B4],ecx
       mov       [rsp+0B0],edx
       mov       [rsp+0AC],r9d
M02_L107:
       mov       rax,[rsp+20]
       mov       [rsp+50],rax
       mov       eax,[rsp+64]
       mov       [rsp+58],eax
       lea       r8,[rsp+50]
       mov       rdx,rsi
       mov       [rsp+0B8],r11
       mov       rcx,r11
       call      qword ptr [7FFC03C568F8]; System.Number.MatchChars[[System.Char, System.Private.CoreLib]](Char*, Char*, System.ReadOnlySpan`1<Char>)
       test      rax,rax
       mov       ecx,[rsp+0B4]
       mov       edx,[rsp+0B0]
       mov       r8d,[rsp+0C0]
       mov       r9d,[rsp+0AC]
       mov       r10d,[rsp+0A8]
       mov       r11,[rsp+0B8]
       je        near ptr M02_L112
       jmp       near ptr M02_L63
M02_L108:
       mov       [rsp+0B4],ecx
       mov       [rsp+0AC],r9d
       mov       r15,[rsp+30]
       mov       [rsp+50],r15
       mov       r15d,[rsp+6C]
       mov       [rsp+58],r15d
       lea       r8,[rsp+50]
       mov       rdx,rsi
       mov       [rsp+0B8],r11
       mov       rcx,r11
       call      qword ptr [7FFC03C568F8]; System.Number.MatchChars[[System.Char, System.Private.CoreLib]](Char*, Char*, System.ReadOnlySpan`1<Char>)
       test      rax,rax
       jne       short M02_L111
       cmp       dword ptr [rsp+0C4],0
       je        short M02_L110
       test      byte ptr [rsp+0C0],20
       jne       short M02_L109
       mov       r8,[rbp+38]
       test      r8,r8
       jne       near ptr M02_L113
       xor       edx,edx
       xor       ecx,ecx
       jmp       near ptr M02_L114
M02_L109:
       mov       ecx,[rsp+0B4]
       mov       r8d,[rsp+0C0]
       mov       r9d,[rsp+0AC]
       mov       r11,[rsp+0B8]
       jmp       near ptr M02_L39
M02_L110:
       mov       ecx,[rsp+0B4]
       mov       r8d,[rsp+0C0]
       mov       r9d,[rsp+0AC]
       mov       r11,[rsp+0B8]
       jmp       near ptr M02_L39
M02_L111:
       mov       [rsp+6C],r15d
       mov       edx,[rsp+0B0]
       mov       r8d,[rsp+0C0]
       mov       r9d,[rsp+0AC]
       mov       r10d,[rsp+0A8]
       jmp       near ptr M02_L64
M02_L112:
       mov       rax,[rsp+38]
       jmp       near ptr M02_L38
M02_L113:
       lea       rdx,[r8+0C]
       mov       ecx,[r8+8]
M02_L114:
       mov       [rsp+50],rdx
       mov       [rsp+58],ecx
       lea       r8,[rsp+50]
       mov       rdx,rsi
       mov       rcx,[rsp+0B8]
       call      qword ptr [7FFC03C568F8]; System.Number.MatchChars[[System.Char, System.Private.CoreLib]](Char*, Char*, System.ReadOnlySpan`1<Char>)
       test      rax,rax
       mov       [rsp+6C],r15d
       mov       ecx,[rsp+0B4]
       mov       edx,[rsp+0B0]
       mov       r8d,[rsp+0C0]
       mov       r9d,[rsp+0AC]
       mov       r10d,[rsp+0A8]
       mov       r11,[rsp+0B8]
       je        near ptr M02_L39
       jmp       near ptr M02_L64
M02_L115:
       test      dil,80
       je        near ptr M02_L40
       mov       [rsp+0A0],r11
       lea       rcx,[r11+2]
       mov       rax,rcx
       cmp       rax,rsi
       jb        short M02_L116
       xor       ecx,ecx
       jmp       short M02_L117
M02_L116:
       movzx     ecx,word ptr [rax]
M02_L117:
       mov       [rsp+0B4],ecx
       mov       rdx,[rbp+20]
       test      rdx,rdx
       jne       short M02_L118
       xor       ecx,ecx
       xor       edx,edx
       jmp       short M02_L119
M02_L118:
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
M02_L119:
       mov       [rsp+50],rcx
       mov       [rsp+58],edx
       lea       r8,[rsp+50]
       mov       rdx,rsi
       mov       [rsp+0B8],rax
       mov       rcx,rax
       call      qword ptr [7FFC03C568F8]; System.Number.MatchChars[[System.Char, System.Private.CoreLib]](Char*, Char*, System.ReadOnlySpan`1<Char>)
       test      rax,rax
       je        short M02_L122
       cmp       rax,rsi
       jb        short M02_L120
       xor       r10d,r10d
       jmp       short M02_L121
M02_L120:
       movzx     r10d,word ptr [rax]
M02_L121:
       mov       [rsp+0B4],r10d
       jmp       near ptr M02_L130
M02_L122:
       mov       rax,[rsp+0B8]
       mov       r8,[rbp+28]
       test      r8,r8
       jne       short M02_L123
       xor       edx,edx
       xor       ecx,ecx
       jmp       short M02_L124
M02_L123:
       lea       rdx,[r8+0C]
       mov       ecx,[r8+8]
M02_L124:
       mov       [rsp+50],rdx
       mov       [rsp+58],ecx
       lea       r8,[rsp+50]
       mov       rdx,rsi
       mov       [rsp+0B8],rax
       mov       rcx,rax
       call      qword ptr [7FFC03C568F8]; System.Number.MatchChars[[System.Char, System.Private.CoreLib]](Char*, Char*, System.ReadOnlySpan`1<Char>)
       test      rax,rax
       jne       short M02_L125
       cmp       byte ptr [rbp+12E],0
       je        short M02_L125
       mov       r10,[rsp+0B8]
       cmp       r10,rsi
       jae       short M02_L127
       lea       r8,[r10+2]
       cmp       word ptr [r10],2D
       cmove     rax,r8
       mov       [rsp+0B8],r10
M02_L125:
       test      rax,rax
       je        short M02_L126
       mov       r10,rax
       cmp       r10,rsi
       jb        short M02_L128
       xor       r8d,r8d
       jmp       short M02_L129
M02_L126:
       mov       rax,[rsp+0B8]
       jmp       short M02_L130
M02_L127:
       mov       [rsp+0B8],r10
       jmp       short M02_L125
M02_L128:
       movzx     r8d,word ptr [r10]
M02_L129:
       mov       r15d,r8d
       mov       r8d,1
       mov       [rsp+0B4],r15d
       mov       rax,r10
       mov       r15d,r8d
M02_L130:
       mov       r10d,[rsp+0B4]
       lea       r8d,[r10-30]
       cmp       r8d,9
       ja        short M02_L139
       xor       r8d,r8d
M02_L131:
       cmp       r8d,5F5E100
       jge       short M02_L134
       lea       r8d,[r8+r8*4]
       lea       r8d,[r10+r8*2-30]
       add       rax,2
       cmp       rax,rsi
       jb        short M02_L132
       xor       r10d,r10d
       jmp       short M02_L133
M02_L132:
       movzx     r10d,word ptr [rax]
M02_L133:
       lea       edx,[r10-30]
       cmp       edx,9
       jbe       short M02_L131
       jmp       short M02_L138
M02_L134:
       mov       r8d,7FFFFFFF
       xor       edx,edx
       mov       [rbx+4],edx
       jmp       short M02_L137
M02_L135:
       add       rax,2
       cmp       rax,rsi
       jb        short M02_L136
       xor       r10d,r10d
       jmp       short M02_L137
M02_L136:
       movzx     r10d,word ptr [rax]
M02_L137:
       lea       edx,[r10-30]
       cmp       edx,9
       jbe       short M02_L135
M02_L138:
       mov       edx,r8d
       neg       edx
       test      r15d,r15d
       cmovne    r8d,edx
       lea       rdx,[rbx+4]
       add       [rdx],r8d
       mov       ecx,r10d
       mov       r11,rax
       jmp       near ptr M02_L40
M02_L139:
       mov       r15,[rsp+0A0]
       mov       rax,r15
       cmp       rax,rsi
       jb        short M02_L140
       xor       r10d,r10d
       jmp       short M02_L141
M02_L140:
       movzx     r10d,word ptr [rax]
M02_L141:
       mov       r15d,r10d
       mov       ecx,r15d
       mov       r11,rax
       jmp       near ptr M02_L40
M02_L142:
       cmp       byte ptr [rbx+9],0
       jne       near ptr M02_L41
       mov       r9d,[rsp+0AC]
       mov       edx,r9d
       sub       edx,[rbx+4]
       test      edx,edx
       jle       near ptr M02_L41
       cmp       r12d,edx
       cmovle    edx,r12d
       sub       r9d,edx
       mov       [rbx],r9d
       mov       edx,[rbx]
       lea       rax,[rbx+10]
       cmp       edx,[rax+8]
       jae       near ptr M02_L160
       mov       rax,[rax]
       mov       byte ptr [rax+rdx],0
       jmp       near ptr M02_L41
M02_L143:
       test      dil,2
       jne       near ptr M02_L154
       jmp       near ptr M02_L42
M02_L144:
       mov       [rsp+0C0],r8d
       jmp       near ptr M02_L54
M02_L145:
       cmp       r10d,20
       jne       near ptr M02_L46
       jmp       near ptr M02_L69
M02_L146:
       cmp       r10d,20
       jne       near ptr M02_L51
       jmp       near ptr M02_L72
M02_L147:
       cmp       r11,rsi
       jae       near ptr M02_L53
       cmp       word ptr [r11],2D
       jne       near ptr M02_L53
       lea       rax,[r11+2]
       jmp       near ptr M02_L53
M02_L148:
       mov       byte ptr [rbx+8],1
M02_L149:
       or        r8d,1
       jmp       short M02_L153
M02_L150:
       mov       r8d,[rsp+0C0]
       test      r8b,2
       je        short M02_L151
       and       r8d,0FFFFFFFD
       mov       [rsp+0C0],r8d
       jmp       short M02_L154
M02_L151:
       mov       [rsp+0C0],r8d
       jmp       near ptr M02_L55
M02_L152:
       mov       r15,[rsp+28]
       mov       [rsp+50],r15
       mov       [rsp+58],r13d
       lea       r8,[rsp+50]
       mov       rdx,rsi
       mov       [rsp+0B8],r11
       mov       rcx,r11
       call      qword ptr [7FFC03C568F8]; System.Number.MatchChars[[System.Char, System.Private.CoreLib]](Char*, Char*, System.ReadOnlySpan`1<Char>)
       test      rax,rax
       mov       r11,[rsp+0B8]
       je        near ptr M02_L56
       xor       r15d,r15d
       xor       r13d,r13d
       mov       [rsp+28],r15
       mov       r8d,[rsp+0C0]
M02_L153:
       lea       r11,[rax-2]
       mov       r12,r11
       mov       [rsp+0C0],r8d
       mov       r11,r12
M02_L154:
       add       r11,2
       mov       r12,r11
       cmp       r12,rsi
       jb        short M02_L155
       xor       ecx,ecx
       jmp       short M02_L156
M02_L155:
       movzx     ecx,word ptr [r12]
M02_L156:
       mov       eax,ecx
       mov       ecx,eax
       mov       r11,r12
       jmp       near ptr M02_L41
M02_L157:
       cmp       byte ptr [rbx+0A],2
       je        short M02_L158
       xor       eax,eax
       mov       [rbx+4],eax
M02_L158:
       cmp       byte ptr [rbx+0A],1
       jne       near ptr M02_L57
       test      r8b,10
       jne       near ptr M02_L57
       mov       byte ptr [rbx+8],0
       jmp       near ptr M02_L57
M02_L159:
       mov       [r14],r11
       xor       eax,eax
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
M02_L160:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 3914
```
```assembly
; System.Number.TryNumberToDecimal(NumberBuffer ByRef, System.Decimal ByRef)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       mov       rbx,rdx
       mov       rdx,[rcx+10]
       mov       esi,[rcx+4]
       movzx     edi,byte ptr [rcx+8]
       movzx     eax,byte ptr [rdx]
       test      eax,eax
       je        near ptr M03_L09
       cmp       esi,1D
       jg        near ptr M03_L22
       xor       ebp,ebp
       cmp       esi,0FFFFFFE4
       jle       short M03_L02
M03_L00:
       dec       esi
       lea       r8,[rbp+rbp*4]
       add       eax,0FFFFFFD0
       lea       rbp,[rax+r8*2]
       inc       rdx
       movzx     eax,byte ptr [rdx]
       mov       r8,1999999999999999
       cmp       rbp,r8
       jae       short M03_L02
       test      eax,eax
       je        short M03_L01
       cmp       esi,0FFFFFFE4
       jg        short M03_L00
       jmp       short M03_L02
M03_L01:
       test      esi,esi
       jg        near ptr M03_L12
M03_L02:
       xor       r14d,r14d
M03_L03:
       test      esi,esi
       jg        short M03_L08
       test      eax,eax
       jne       near ptr M03_L16
M03_L04:
       cmp       eax,35
       jae       near ptr M03_L18
M03_L05:
       test      esi,esi
       jg        near ptr M03_L22
       cmp       esi,0FFFFFFE3
       jle       near ptr M03_L23
       mov       ecx,esi
       neg       ecx
       movzx     esi,cl
       mov       r15d,esi
       cmp       esi,1C
       jl        short M03_L06
       cmp       esi,1C
       jg        near ptr M03_L24
M03_L06:
       mov       ecx,ebp
       mov       rdx,rbp
       shr       rdx,20
       mov       edx,edx
       shl       rdx,20
       add       rcx,rdx
       shl       esi,10
       mov       edx,esi
       or        edx,80000000
       test      edi,edi
       cmovne    esi,edx
       mov       [rbx],esi
       mov       [rbx+4],r14d
       mov       [rbx+8],rcx
M03_L07:
       mov       eax,1
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L08:
       cmp       r14d,19999999
       jb        near ptr M03_L13
       cmp       r14d,19999999
       jne       near ptr M03_L04
       jmp       near ptr M03_L17
M03_L09:
       mov       ecx,esi
       neg       ecx
       jns       short M03_L10
       xor       ecx,ecx
       jmp       short M03_L11
M03_L10:
       mov       edx,1C
       cmp       ecx,1C
       cmovg     ecx,edx
M03_L11:
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rsp+38],xmm0
       mov       [rsp+20],edi
       movzx     ecx,cl
       mov       [rsp+28],ecx
       lea       rcx,[rsp+38]
       xor       edx,edx
       xor       r8d,r8d
       xor       r9d,r9d
       call      qword ptr [7FFC039CE9D0]; System.Decimal..ctor(Int32, Int32, Int32, Boolean, Byte)
       vmovups   xmm0,[rsp+38]
       vmovups   [rbx],xmm0
       jmp       short M03_L07
M03_L12:
       dec       esi
       lea       rbp,[rbp+rbp*4]
       add       rbp,rbp
       mov       r8,1999999999999999
       cmp       rbp,r8
       jae       near ptr M03_L02
       jmp       near ptr M03_L01
M03_L13:
       mov       r8d,ebp
       lea       r8,[r8+r8*4]
       add       r8,r8
       shr       rbp,20
       mov       r10d,ebp
       lea       r10,[r10+r10*4]
       mov       r9,r8
       shr       r9,20
       lea       r10,[r9+r10*2]
       mov       ebp,r8d
       mov       r8,r10
       shl       r8,20
       add       rbp,r8
       shr       r10,20
       lea       r8d,[r14+r14*4]
       lea       r14d,[r10+r8*2]
       test      eax,eax
       je        short M03_L15
       add       eax,0FFFFFFD0
       mov       r8d,eax
       add       rbp,r8
       cmp       rbp,rax
       jae       short M03_L14
       inc       r14d
M03_L14:
       inc       rdx
       movzx     eax,byte ptr [rdx]
M03_L15:
       dec       esi
       jmp       near ptr M03_L03
M03_L16:
       cmp       esi,0FFFFFFE4
       jle       near ptr M03_L04
       jmp       near ptr M03_L08
M03_L17:
       mov       r8,9999999999999999
       cmp       rbp,r8
       jb        short M03_L13
       mov       r8,9999999999999999
       cmp       rbp,r8
       jne       near ptr M03_L04
       cmp       eax,35
       jbe       near ptr M03_L13
       jmp       near ptr M03_L04
M03_L18:
       cmp       eax,35
       jne       short M03_L21
       test      bpl,1
       jne       short M03_L21
       inc       rdx
       movzx     eax,byte ptr [rdx]
       cmp       byte ptr [rcx+9],0
       sete      cl
       movzx     ecx,cl
       jmp       short M03_L20
M03_L19:
       cmp       eax,30
       sete      al
       movzx     eax,al
       and       ecx,eax
       inc       rdx
       movzx     eax,byte ptr [rdx]
M03_L20:
       test      eax,eax
       setne     r8b
       movzx     r8d,r8b
       test      ecx,r8d
       jne       short M03_L19
       test      ecx,ecx
       jne       near ptr M03_L05
M03_L21:
       inc       rbp
       jne       near ptr M03_L05
       inc       r14d
       jne       near ptr M03_L05
       mov       rbp,999999999999999A
       mov       r14d,19999999
       inc       esi
       jmp       near ptr M03_L05
M03_L22:
       xor       eax,eax
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L23:
       mov       ecx,1C
       mov       edx,1C
       mov       r8,1D194430240
       call      qword ptr [7FFC03C5F1F8]
       mov       eax,1C0000
       mov       ecx,801C0000
       test      edi,edi
       cmovne    eax,ecx
       mov       [rbx],eax
       xor       eax,eax
       mov       [rbx+4],eax
       mov       [rbx+8],rax
       jmp       near ptr M03_L07
M03_L24:
       mov       ecx,2DB
       mov       rdx,7FFC03584000
       call      qword ptr [7FFC03867798]
       mov       r8,rax
       mov       ecx,r15d
       mov       edx,1C
       call      qword ptr [7FFC03C5F210]
       int       3
; Total bytes of code 748
```
```assembly
; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[System.Decimal, System.Private.CoreLib]](System.Decimal ByRef)
       ret
; Total bytes of code 1
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.NumericExtensionsBenchmark.TryParseInvariantDoubleInvalid()
       push      rsi
       push      rbx
       sub       rsp,38
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       xor       eax,eax
       mov       [rsp+30],rax
       mov       rbx,rcx
       mov       rsi,2E8E6B50B7C
       mov       rcx,2A851C00100
       mov       rcx,[rcx]
       call      qword ptr [7FFC03BE5668]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider)
       mov       r8,rax
       mov       [rsp+20],rsi
       mov       dword ptr [rsp+28],7
       lea       rcx,[rsp+20]
       lea       r9,[rsp+30]
       mov       edx,0E7
       call      qword ptr [7FFC03C56868]; System.Number.TryParseFloat[[System.Char, System.Private.CoreLib],[System.Double, System.Private.CoreLib]](System.ReadOnlySpan`1<Char>, System.Globalization.NumberStyles, System.Globalization.NumberFormatInfo, Double ByRef)
       mov       rcx,[rbx+90]
       mov       [rcx+4C],al
       vmovsd    xmm0,qword ptr [rsp+30]
       mov       rax,[rbx+90]
       vmovsd    qword ptr [rax+10],xmm0
       add       rsp,38
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 127
```
```assembly
; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider)
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rax,offset MT_System.Globalization.CultureInfo
       cmp       [rbx],rax
       jne       short M01_L00
       mov       rax,[rbx+18]
       test      rax,rax
       je        short M01_L00
       add       rsp,20
       pop       rbx
       ret
M01_L00:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Globalization.NumberFormatInfo
       call      qword ptr [7FFC03646850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       short M01_L01
       mov       rcx,rbx
       mov       r11,7FFC035908A0
       mov       rdx,2E8E6B46A68
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,offset MT_System.Globalization.NumberFormatInfo
       call      qword ptr [7FFC03646850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       short M01_L01
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFC03865DD0]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
M01_L01:
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 129
```
```assembly
; System.Number.TryParseFloat[[System.Char, System.Private.CoreLib],[System.Double, System.Private.CoreLib]](System.ReadOnlySpan`1<Char>, System.Globalization.NumberStyles, System.Globalization.NumberFormatInfo, Double ByRef)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,98
       lea       rbp,[rsp+30]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp+10],ymm4
       vmovdqu   ymmword ptr [rbp+30],ymm4
       vmovdqa   xmmword ptr [rbp+50],xmm4
       xor       eax,eax
       mov       [rbp+60],rax
       mov       rax,1D497D7996C
       mov       [rbp+8],rax
       mov       rbx,rcx
       mov       rsi,r8
       mov       r8d,edx
       mov       rdi,r9
       test      [rsp],esp
       sub       rsp,310
       lea       rdx,[rsp+30]
       mov       byte ptr [rbp+52],3
       mov       [rbp+58],rdx
       mov       dword ptr [rbp+60],301
       cmp       dword ptr [rbp+60],0
       jbe       near ptr M02_L62
       mov       rdx,[rbp+58]
       mov       byte ptr [rdx],0
       mov       r14,[rbx]
       mov       r15d,[rbx+8]
       mov       [rbp+40],r14
       mov       r13,r14
       mov       [rbp+38],r13
       mov       [rsp+20],rsi
       mov       rdx,[rbp+38]
       mov       ecx,r15d
       lea       rdx,[rdx+rcx*2]
       lea       rcx,[rbp+38]
       lea       r9,[rbp+48]
       call      qword ptr [7FFC03C56898]; System.Number.TryParseNumber[[System.Char, System.Private.CoreLib]](Char* ByRef, Char*, System.Globalization.NumberStyles, NumberBuffer ByRef, System.Globalization.NumberFormatInfo)
       test      eax,eax
       je        short M02_L01
       mov       rcx,[rbp+38]
       sub       rcx,r13
       mov       rdx,rcx
       shr       rdx,3F
       add       rcx,rdx
       sar       rcx,1
       cmp       ecx,r15d
       jge       short M02_L00
       mov       [rbp+10],r14
       mov       [rbp+18],r15d
       lea       rcx,[rbp+10]
       mov       rdx,[rbp+38]
       sub       rdx,r13
       mov       rax,rdx
       shr       rax,3F
       add       rdx,rax
       sar       rdx,1
       call      qword ptr [7FFC03C5F018]
       test      eax,eax
       je        short M02_L01
M02_L00:
       xor       ecx,ecx
       mov       [rbp+40],rcx
       mov       ecx,1
       jmp       short M02_L02
M02_L01:
       xor       ecx,ecx
M02_L02:
       xor       eax,eax
       mov       [rbp+40],rax
       test      ecx,ecx
       jne       near ptr M02_L59
       mov       r14,[rbx]
       mov       ebx,[rbx+8]
       test      ebx,ebx
       je        short M02_L04
       movzx     ecx,word ptr [r14]
       cmp       ecx,100
       jge       near ptr M02_L36
       mov       rax,7FFC5F9F6BF0
       test      byte ptr [rax+rcx],80
       jne       near ptr M02_L38
M02_L03:
       lea       ecx,[rbx-1]
       movzx     ecx,word ptr [r14+rcx*2]
       cmp       ecx,100
       jge       near ptr M02_L37
       mov       rax,7FFC5F9F6BF0
       test      byte ptr [rax+rcx],80
       jne       near ptr M02_L38
M02_L04:
       mov       rcx,[rsi+60]
       test      rcx,rcx
       jne       near ptr M02_L21
       xor       r15d,r15d
       xor       r13d,r13d
M02_L05:
       cmp       ebx,r13d
       jne       short M02_L09
       test      r13d,r13d
       je        near ptr M02_L39
       cmp       r13d,8
       jl        short M02_L07
       cmp       r13d,10
       jl        short M02_L06
       mov       rcx,r14
       mov       rdx,r15
       mov       r8d,r13d
       call      qword ptr [7FFC03C5ED18]
       jmp       short M02_L08
M02_L06:
       mov       rcx,r14
       mov       rdx,r15
       mov       r8d,r13d
       call      qword ptr [7FFC03C5ED30]
       jmp       short M02_L08
M02_L07:
       mov       rcx,r14
       mov       rdx,r15
       mov       r8d,r13d
       call      qword ptr [7FFC03C568F8]; System.Globalization.Ordinal.EqualsIgnoreCase_Scalar(Char ByRef, Char ByRef, Int32)
M02_L08:
       test      eax,eax
       jne       near ptr M02_L39
M02_L09:
       mov       rcx,[rsi+68]
       test      rcx,rcx
       jne       near ptr M02_L22
       xor       edx,edx
       xor       r8d,r8d
M02_L10:
       cmp       ebx,r8d
       jne       short M02_L14
       test      r8d,r8d
       je        near ptr M02_L40
       cmp       r8d,8
       jl        short M02_L12
       cmp       r8d,10
       jl        short M02_L11
       mov       rcx,r14
       call      qword ptr [7FFC03C5ED18]
       jmp       short M02_L13
M02_L11:
       mov       rcx,r14
       call      qword ptr [7FFC03C5ED30]
       jmp       short M02_L13
M02_L12:
       mov       rcx,r14
       call      qword ptr [7FFC03C568F8]; System.Globalization.Ordinal.EqualsIgnoreCase_Scalar(Char ByRef, Char ByRef, Int32)
M02_L13:
       test      eax,eax
       jne       near ptr M02_L40
M02_L14:
       mov       rcx,[rsi+58]
       test      rcx,rcx
       jne       near ptr M02_L23
       xor       r12d,r12d
       xor       eax,eax
M02_L15:
       cmp       ebx,eax
       jne       short M02_L19
       test      eax,eax
       je        near ptr M02_L58
       cmp       eax,8
       jl        short M02_L17
       cmp       eax,10
       jl        short M02_L16
       mov       rcx,r14
       mov       rdx,r12
       mov       [rbp+24],eax
       mov       r8d,eax
       call      qword ptr [7FFC03C5ED18]
       jmp       short M02_L18
M02_L16:
       mov       rcx,r14
       mov       rdx,r12
       mov       [rbp+24],eax
       mov       r8d,eax
       call      qword ptr [7FFC03C5ED30]
       jmp       short M02_L18
M02_L17:
       mov       rcx,r14
       mov       rdx,r12
       mov       [rbp+24],eax
       mov       r8d,eax
       call      qword ptr [7FFC03C568F8]; System.Globalization.Ordinal.EqualsIgnoreCase_Scalar(Char ByRef, Char ByRef, Int32)
M02_L18:
       test      eax,eax
       mov       eax,[rbp+24]
       jne       near ptr M02_L58
M02_L19:
       mov       rcx,[rsi+20]
       test      rcx,rcx
       jne       short M02_L24
       xor       edx,edx
       xor       r10d,r10d
M02_L20:
       cmp       r10d,ebx
       jg        near ptr M02_L28
       cmp       r10d,8
       jl        short M02_L26
       cmp       r10d,10
       jl        short M02_L25
       mov       [rbp+24],eax
       mov       rcx,r14
       mov       [rbp+20],r10d
       mov       r8d,r10d
       call      qword ptr [7FFC03C5ED18]
       jmp       short M02_L27
M02_L21:
       lea       r15,[rcx+0C]
       mov       r13d,[rcx+8]
       jmp       near ptr M02_L05
M02_L22:
       lea       rdx,[rcx+0C]
       mov       r8d,[rcx+8]
       jmp       near ptr M02_L10
M02_L23:
       lea       r12,[rcx+0C]
       mov       eax,[rcx+8]
       jmp       near ptr M02_L15
M02_L24:
       lea       rdx,[rcx+0C]
       mov       r10d,[rcx+8]
       jmp       short M02_L20
M02_L25:
       mov       [rbp+24],eax
       mov       rcx,r14
       mov       [rbp+20],r10d
       mov       r8d,r10d
       call      qword ptr [7FFC03C5ED30]
       jmp       short M02_L27
M02_L26:
       mov       [rbp+24],eax
       mov       rcx,r14
       mov       [rbp+20],r10d
       mov       r8d,r10d
       call      qword ptr [7FFC03C568F8]; System.Globalization.Ordinal.EqualsIgnoreCase_Scalar(Char ByRef, Char ByRef, Int32)
M02_L27:
       test      eax,eax
       jne       near ptr M02_L41
       mov       eax,[rbp+24]
M02_L28:
       mov       rcx,[rsi+28]
       test      rcx,rcx
       jne       short M02_L30
       xor       edx,edx
       xor       r15d,r15d
M02_L29:
       cmp       r15d,ebx
       jg        short M02_L34
       cmp       r15d,8
       jl        short M02_L32
       cmp       r15d,10
       jl        short M02_L31
       mov       [rbp+24],eax
       mov       rcx,r14
       mov       r8d,r15d
       call      qword ptr [7FFC03C5ED18]
       jmp       short M02_L33
M02_L30:
       lea       rdx,[rcx+0C]
       mov       r15d,[rcx+8]
       jmp       short M02_L29
M02_L31:
       mov       [rbp+24],eax
       mov       rcx,r14
       mov       r8d,r15d
       call      qword ptr [7FFC03C5ED30]
       jmp       short M02_L33
M02_L32:
       mov       [rbp+24],eax
       mov       rcx,r14
       mov       r8d,r15d
       call      qword ptr [7FFC03C568F8]; System.Globalization.Ordinal.EqualsIgnoreCase_Scalar(Char ByRef, Char ByRef, Int32)
M02_L33:
       test      eax,eax
       jne       near ptr M02_L49
M02_L34:
       xor       eax,eax
       mov       [rdi],rax
       mov       r8,1D497D7996C
       cmp       [rbp+8],r8
       je        short M02_L35
       call      CORINFO_HELP_FAIL_FAST
M02_L35:
       nop
       lea       rsp,[rbp+68]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L36:
       call      qword ptr [7FFC03C5F3F0]
       test      eax,eax
       jne       short M02_L38
       jmp       near ptr M02_L03
M02_L37:
       call      qword ptr [7FFC03C5F3F0]
       test      eax,eax
       je        near ptr M02_L04
M02_L38:
       mov       [rbp+10],r14
       mov       [rbp+18],ebx
       lea       rdx,[rbp+10]
       lea       rcx,[rbp+28]
       call      qword ptr [7FFC03A776F0]; System.MemoryExtensions.<Trim>g__TrimFallback|273_0(System.ReadOnlySpan`1<Char>)
       mov       r14,[rbp+28]
       mov       ebx,[rbp+30]
       jmp       near ptr M02_L04
M02_L39:
       mov       rcx,7FF0000000000000
       mov       [rdi],rcx
       jmp       near ptr M02_L60
M02_L40:
       mov       rcx,0FFF0000000000000
       mov       [rdi],rcx
       jmp       near ptr M02_L60
M02_L41:
       mov       esi,[rbp+20]
       mov       ecx,esi
       lea       r14,[r14+rcx*2]
       sub       ebx,esi
       cmp       ebx,r13d
       jne       short M02_L45
       test      r13d,r13d
       je        short M02_L39
       cmp       r13d,8
       jge       short M02_L42
       mov       rcx,r14
       mov       rdx,r15
       mov       r8d,r13d
       call      qword ptr [7FFC03C568F8]; System.Globalization.Ordinal.EqualsIgnoreCase_Scalar(Char ByRef, Char ByRef, Int32)
       jmp       short M02_L44
M02_L42:
       cmp       r13d,10
       jl        short M02_L43
       mov       rcx,r14
       mov       rdx,r15
       mov       r8d,r13d
       call      qword ptr [7FFC03C5ED18]
       jmp       short M02_L44
M02_L43:
       mov       rcx,r14
       mov       rdx,r15
       mov       r8d,r13d
       call      qword ptr [7FFC03C5ED30]
M02_L44:
       test      eax,eax
       jne       short M02_L39
M02_L45:
       mov       esi,[rbp+24]
       cmp       ebx,esi
       jne       near ptr M02_L34
       test      esi,esi
       je        near ptr M02_L58
       cmp       esi,8
       jge       short M02_L46
       mov       rcx,r14
       mov       rdx,r12
       mov       r8d,esi
       call      qword ptr [7FFC03C568F8]; System.Globalization.Ordinal.EqualsIgnoreCase_Scalar(Char ByRef, Char ByRef, Int32)
       jmp       short M02_L48
M02_L46:
       cmp       esi,10
       jl        short M02_L47
       mov       rcx,r14
       mov       rdx,r12
       mov       r8d,esi
       call      qword ptr [7FFC03C5ED18]
       jmp       short M02_L48
M02_L47:
       mov       rcx,r14
       mov       rdx,r12
       mov       r8d,esi
       call      qword ptr [7FFC03C5ED30]
M02_L48:
       test      eax,eax
       je        near ptr M02_L34
       jmp       near ptr M02_L58
M02_L49:
       mov       ecx,r15d
       lea       rcx,[r14+rcx*2]
       mov       edx,ebx
       sub       edx,r15d
       mov       r15d,[rbp+24]
       cmp       edx,r15d
       jne       short M02_L53
       test      r15d,r15d
       je        near ptr M02_L58
       cmp       r15d,8
       jge       short M02_L50
       mov       rdx,r12
       mov       r8d,r15d
       call      qword ptr [7FFC03C568F8]; System.Globalization.Ordinal.EqualsIgnoreCase_Scalar(Char ByRef, Char ByRef, Int32)
       jmp       short M02_L52
M02_L50:
       cmp       r15d,10
       jl        short M02_L51
       mov       rdx,r12
       mov       r8d,r15d
       call      qword ptr [7FFC03C5ED18]
       jmp       short M02_L52
M02_L51:
       mov       rdx,r12
       mov       r8d,r15d
       call      qword ptr [7FFC03C5ED30]
M02_L52:
       test      eax,eax
       jne       near ptr M02_L58
M02_L53:
       cmp       byte ptr [rsi+12E],0
       je        near ptr M02_L34
       mov       [rbp+10],r14
       mov       [rbp+18],ebx
       lea       rcx,[rbp+10]
       mov       edx,2D
       call      qword ptr [7FFC03C5EE68]
       test      eax,eax
       je        near ptr M02_L34
       test      ebx,ebx
       jne       short M02_L54
       call      qword ptr [7FFC037B7198]
       int       3
M02_L54:
       lea       rcx,[r14+2]
       lea       edx,[rbx-1]
       cmp       edx,r15d
       jne       near ptr M02_L34
       test      r15d,r15d
       je        short M02_L58
       cmp       r15d,8
       jge       short M02_L55
       mov       rdx,r12
       mov       r8d,r15d
       call      qword ptr [7FFC03C568F8]; System.Globalization.Ordinal.EqualsIgnoreCase_Scalar(Char ByRef, Char ByRef, Int32)
       jmp       short M02_L57
M02_L55:
       cmp       r15d,10
       jl        short M02_L56
       mov       rdx,r12
       mov       r8d,r15d
       call      qword ptr [7FFC03C5ED18]
       jmp       short M02_L57
M02_L56:
       mov       rdx,r12
       mov       r8d,r15d
       call      qword ptr [7FFC03C5ED30]
M02_L57:
       test      eax,eax
       je        near ptr M02_L34
M02_L58:
       mov       rcx,0FFF8000000000000
       mov       [rdi],rcx
       jmp       short M02_L60
M02_L59:
       lea       rcx,[rbp+48]
       call      qword ptr [7FFC03C5EE80]
       vmovsd    qword ptr [rdi],xmm0
M02_L60:
       mov       eax,1
       mov       r8,1D497D7996C
       cmp       [rbp+8],r8
       je        short M02_L61
       call      CORINFO_HELP_FAIL_FAST
M02_L61:
       nop
       lea       rsp,[rbp+68]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L62:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1526
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.NumericExtensionsBenchmark.TryParseInvariantDoubleValid()
       push      rsi
       push      rbx
       sub       rsp,38
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       xor       eax,eax
       mov       [rsp+30],rax
       mov       rbx,rcx
       mov       rsi,28D6DA50B7C
       mov       rcx,24CD8C00100
       mov       rcx,[rcx]
       call      qword ptr [7FFC03C05668]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider)
       mov       r8,rax
       mov       [rsp+20],rsi
       mov       dword ptr [rsp+28],9
       lea       rcx,[rsp+20]
       lea       r9,[rsp+30]
       mov       edx,0E7
       call      qword ptr [7FFC03C76790]; System.Number.TryParseFloat[[System.Char, System.Private.CoreLib],[System.Double, System.Private.CoreLib]](System.ReadOnlySpan`1<Char>, System.Globalization.NumberStyles, System.Globalization.NumberFormatInfo, Double ByRef)
       mov       rcx,[rbx+90]
       mov       [rcx+4C],al
       vmovsd    xmm0,qword ptr [rsp+30]
       mov       rax,[rbx+90]
       vmovsd    qword ptr [rax+10],xmm0
       add       rsp,38
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 127
```
```assembly
; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider)
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rax,offset MT_System.Globalization.CultureInfo
       cmp       [rbx],rax
       jne       short M01_L00
       mov       rax,[rbx+18]
       test      rax,rax
       je        short M01_L00
       add       rsp,20
       pop       rbx
       ret
M01_L00:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Globalization.NumberFormatInfo
       call      qword ptr [7FFC03666850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       short M01_L01
       mov       rcx,rbx
       mov       r11,7FFC035B08A0
       mov       rdx,28D6DA46A68
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,offset MT_System.Globalization.NumberFormatInfo
       call      qword ptr [7FFC03666850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       short M01_L01
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFC03885DD0]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
M01_L01:
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 129
```
```assembly
; System.Number.TryParseFloat[[System.Char, System.Private.CoreLib],[System.Double, System.Private.CoreLib]](System.ReadOnlySpan`1<Char>, System.Globalization.NumberStyles, System.Globalization.NumberFormatInfo, Double ByRef)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0A8
       lea       rbp,[rsp+30]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp+10],ymm4
       vmovdqu   ymmword ptr [rbp+30],ymm4
       vmovdqu   ymmword ptr [rbp+50],ymm4
       xor       eax,eax
       mov       [rbp+70],rax
       mov       rax,34BCA45BF5F3
       mov       [rbp+8],rax
       mov       rbx,rcx
       mov       rsi,r8
       mov       r8d,edx
       mov       rdi,r9
       test      [rsp],esp
       sub       rsp,310
       lea       rdx,[rsp+30]
       mov       byte ptr [rbp+62],3
       mov       [rbp+68],rdx
       mov       dword ptr [rbp+70],301
       cmp       dword ptr [rbp+70],0
       jbe       near ptr M02_L58
       mov       rdx,[rbp+68]
       mov       byte ptr [rdx],0
       mov       r14,[rbx]
       mov       r15d,[rbx+8]
       mov       [rbp+50],r14
       mov       r13,r14
       mov       [rbp+48],r13
       mov       [rsp+20],rsi
       mov       rdx,[rbp+48]
       mov       ecx,r15d
       lea       rdx,[rdx+rcx*2]
       lea       rcx,[rbp+48]
       lea       r9,[rbp+58]
       call      qword ptr [7FFC03C767C0]; System.Number.TryParseNumber[[System.Char, System.Private.CoreLib]](Char* ByRef, Char*, System.Globalization.NumberStyles, NumberBuffer ByRef, System.Globalization.NumberFormatInfo)
       test      eax,eax
       je        short M02_L01
       mov       rcx,[rbp+48]
       sub       rcx,r13
       mov       rdx,rcx
       shr       rdx,3F
       add       rcx,rdx
       sar       rcx,1
       cmp       ecx,r15d
       jge       short M02_L00
       mov       [rbp+20],r14
       mov       [rbp+28],r15d
       lea       rcx,[rbp+20]
       mov       rdx,[rbp+48]
       sub       rdx,r13
       mov       rax,rdx
       shr       rax,3F
       add       rdx,rax
       sar       rdx,1
       call      qword ptr [7FFC03C7EE38]
       test      eax,eax
       je        short M02_L01
M02_L00:
       xor       ecx,ecx
       mov       [rbp+50],rcx
       mov       ecx,1
       jmp       short M02_L02
M02_L01:
       xor       ecx,ecx
M02_L02:
       xor       eax,eax
       mov       [rbp+50],rax
       test      ecx,ecx
       je        short M02_L07
       cmp       dword ptr [rbp+58],0
       je        near ptr M02_L55
       mov       ecx,[rbp+5C]
       cmp       ecx,0FFFFFEBC
       jl        near ptr M02_L55
       cmp       ecx,135
       jg        near ptr M02_L56
       lea       rcx,[rbp+58]
       call      qword ptr [7FFC03C76808]; System.Number.NumberToFloatingPointBits[[System.Double, System.Private.CoreLib]](NumberBuffer ByRef)
       vmovq     xmm0,rax
M02_L03:
       cmp       byte ptr [rbp+60],0
       jne       near ptr M02_L57
M02_L04:
       vmovsd    qword ptr [rdi],xmm0
M02_L05:
       mov       eax,1
       mov       r8,34BCA45BF5F3
       cmp       [rbp+8],r8
       je        short M02_L06
       call      CORINFO_HELP_FAIL_FAST
M02_L06:
       nop
       lea       rsp,[rbp+78]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L07:
       mov       r14,[rbx]
       mov       ebx,[rbx+8]
       test      ebx,ebx
       je        short M02_L08
       movzx     ecx,word ptr [r14]
       call      qword ptr [7FFC03C079C0]; System.Char.IsWhiteSpace(Char)
       test      eax,eax
       jne       short M02_L09
       lea       ecx,[rbx-1]
       movzx     ecx,word ptr [r14+rcx*2]
       call      qword ptr [7FFC03C079C0]; System.Char.IsWhiteSpace(Char)
       test      eax,eax
       jne       short M02_L09
M02_L08:
       mov       [rbp+38],r14
       mov       [rbp+40],ebx
       jmp       short M02_L10
M02_L09:
       mov       [rbp+20],r14
       mov       [rbp+28],ebx
       lea       rdx,[rbp+20]
       lea       rcx,[rbp+38]
       call      qword ptr [7FFC03A976F0]; System.MemoryExtensions.<Trim>g__TrimFallback|273_0(System.ReadOnlySpan`1<Char>)
M02_L10:
       mov       rbx,[rbp+38]
       mov       r14d,[rbp+40]
       mov       rcx,[rsi+60]
       test      rcx,rcx
       jne       short M02_L11
       xor       r15d,r15d
       xor       r13d,r13d
       jmp       short M02_L12
M02_L11:
       lea       r15,[rcx+0C]
       mov       r13d,[rcx+8]
M02_L12:
       cmp       r14d,r13d
       jne       short M02_L17
       test      r13d,r13d
       je        short M02_L16
       cmp       r13d,8
       jge       short M02_L13
       mov       rcx,rbx
       mov       rdx,r15
       mov       r8d,r13d
       call      qword ptr [7FFC03C7F330]
       jmp       short M02_L15
M02_L13:
       cmp       r13d,10
       jl        short M02_L14
       mov       rcx,rbx
       mov       rdx,r15
       mov       r8d,r13d
       call      qword ptr [7FFC03C7F0D8]
       jmp       short M02_L15
M02_L14:
       mov       rcx,rbx
       mov       rdx,r15
       mov       r8d,r13d
       call      qword ptr [7FFC03C7F0F0]
M02_L15:
       test      eax,eax
       je        short M02_L17
M02_L16:
       mov       rax,7FF0000000000000
       mov       [rdi],rax
       jmp       near ptr M02_L05
M02_L17:
       mov       rcx,[rsi+68]
       test      rcx,rcx
       jne       short M02_L18
       xor       edx,edx
       xor       r8d,r8d
       jmp       short M02_L19
M02_L18:
       lea       rdx,[rcx+0C]
       mov       r8d,[rcx+8]
M02_L19:
       cmp       r14d,r8d
       jne       short M02_L24
       test      r8d,r8d
       je        short M02_L23
       cmp       r8d,8
       jge       short M02_L20
       mov       rcx,rbx
       call      qword ptr [7FFC03C7F330]
       jmp       short M02_L22
M02_L20:
       cmp       r8d,10
       jl        short M02_L21
       mov       rcx,rbx
       call      qword ptr [7FFC03C7F0D8]
       jmp       short M02_L22
M02_L21:
       mov       rcx,rbx
       call      qword ptr [7FFC03C7F0F0]
M02_L22:
       test      eax,eax
       je        short M02_L24
M02_L23:
       mov       rax,0FFF0000000000000
       mov       [rdi],rax
       jmp       near ptr M02_L05
M02_L24:
       mov       rcx,[rsi+58]
       test      rcx,rcx
       jne       short M02_L25
       xor       r12d,r12d
       xor       eax,eax
       jmp       short M02_L26
M02_L25:
       lea       r12,[rcx+0C]
       mov       eax,[rcx+8]
M02_L26:
       cmp       r14d,eax
       jne       short M02_L30
       test      eax,eax
       je        near ptr M02_L52
       cmp       eax,8
       jge       short M02_L27
       mov       rcx,rbx
       mov       rdx,r12
       mov       [rbp+34],eax
       mov       r8d,eax
       call      qword ptr [7FFC03C7F330]
       jmp       short M02_L29
M02_L27:
       cmp       eax,10
       jl        short M02_L28
       mov       rcx,rbx
       mov       rdx,r12
       mov       [rbp+34],eax
       mov       r8d,eax
       call      qword ptr [7FFC03C7F0D8]
       jmp       short M02_L29
M02_L28:
       mov       rcx,rbx
       mov       rdx,r12
       mov       [rbp+34],eax
       mov       r8d,eax
       call      qword ptr [7FFC03C7F0F0]
M02_L29:
       test      eax,eax
       mov       eax,[rbp+34]
       jne       near ptr M02_L52
M02_L30:
       mov       rcx,[rsi+20]
       test      rcx,rcx
       jne       short M02_L31
       xor       edx,edx
       xor       r10d,r10d
       mov       [rbp+34],eax
       jmp       short M02_L32
M02_L31:
       lea       rdx,[rcx+0C]
       mov       r10d,[rcx+8]
       mov       [rbp+34],eax
M02_L32:
       vmovdqu   xmm0,xmmword ptr [rbp+38]
       vmovdqu   xmmword ptr [rbp+20],xmm0
       mov       [rbp+10],rdx
       mov       [rbp+30],r10d
       mov       [rbp+18],r10d
       lea       rcx,[rbp+20]
       lea       rdx,[rbp+10]
       mov       r8d,5
       call      qword ptr [7FFC03C7EC70]
       test      eax,eax
       je        near ptr M02_L40
       mov       esi,[rbp+30]
       cmp       esi,r14d
       jg        near ptr M02_L47
       mov       ecx,esi
       lea       rbx,[rbx+rcx*2]
       sub       r14d,esi
       cmp       r14d,r13d
       jne       short M02_L36
       test      r13d,r13d
       je        near ptr M02_L16
       cmp       r13d,8
       jge       short M02_L33
       mov       rcx,rbx
       mov       rdx,r15
       mov       r8d,r13d
       call      qword ptr [7FFC03C7F330]
       jmp       short M02_L35
M02_L33:
       cmp       r13d,10
       jl        short M02_L34
       mov       rcx,rbx
       mov       rdx,r15
       mov       r8d,r13d
       call      qword ptr [7FFC03C7F0D8]
       jmp       short M02_L35
M02_L34:
       mov       rcx,rbx
       mov       rdx,r15
       mov       r8d,r13d
       call      qword ptr [7FFC03C7F0F0]
M02_L35:
       test      eax,eax
       jne       near ptr M02_L16
M02_L36:
       mov       esi,[rbp+34]
       cmp       r14d,esi
       jne       near ptr M02_L53
       test      esi,esi
       je        near ptr M02_L52
       cmp       esi,8
       jge       short M02_L37
       mov       rcx,rbx
       mov       rdx,r12
       mov       r8d,esi
       call      qword ptr [7FFC03C7F330]
       jmp       short M02_L39
M02_L37:
       cmp       esi,10
       jl        short M02_L38
       mov       rcx,rbx
       mov       rdx,r12
       mov       r8d,esi
       call      qword ptr [7FFC03C7F0D8]
       jmp       short M02_L39
M02_L38:
       mov       rcx,rbx
       mov       rdx,r12
       mov       r8d,esi
       call      qword ptr [7FFC03C7F0F0]
M02_L39:
       test      eax,eax
       je        near ptr M02_L53
       jmp       near ptr M02_L52
M02_L40:
       mov       rcx,[rsi+28]
       test      rcx,rcx
       jne       short M02_L41
       xor       edx,edx
       xor       r15d,r15d
       jmp       short M02_L42
M02_L41:
       lea       rdx,[rcx+0C]
       mov       r15d,[rcx+8]
M02_L42:
       vmovdqu   xmm0,xmmword ptr [rbp+38]
       vmovdqu   xmmword ptr [rbp+20],xmm0
       mov       [rbp+10],rdx
       mov       [rbp+18],r15d
       lea       rcx,[rbp+20]
       lea       rdx,[rbp+10]
       mov       r8d,5
       call      qword ptr [7FFC03C7EC70]
       test      eax,eax
       je        near ptr M02_L53
       cmp       r15d,r14d
       jg        near ptr M02_L47
       mov       ecx,r15d
       lea       rcx,[rbx+rcx*2]
       mov       edx,r14d
       sub       edx,r15d
       mov       r15d,[rbp+34]
       cmp       edx,r15d
       jne       short M02_L46
       test      r15d,r15d
       je        near ptr M02_L52
       cmp       r15d,8
       jge       short M02_L43
       mov       rdx,r12
       mov       r8d,r15d
       call      qword ptr [7FFC03C7F330]
       jmp       short M02_L45
M02_L43:
       cmp       r15d,10
       jl        short M02_L44
       mov       rdx,r12
       mov       r8d,r15d
       call      qword ptr [7FFC03C7F0D8]
       jmp       short M02_L45
M02_L44:
       mov       rdx,r12
       mov       r8d,r15d
       call      qword ptr [7FFC03C7F0F0]
M02_L45:
       test      eax,eax
       jne       near ptr M02_L52
M02_L46:
       cmp       byte ptr [rsi+12E],0
       je        near ptr M02_L53
       vmovdqu   xmm0,xmmword ptr [rbp+38]
       vmovdqu   xmmword ptr [rbp+20],xmm0
       lea       rcx,[rbp+20]
       mov       edx,2D
       call      qword ptr [7FFC03C7ECA0]
       test      eax,eax
       je        short M02_L53
       test      r14d,r14d
       jne       short M02_L48
M02_L47:
       call      qword ptr [7FFC037D7198]
       int       3
M02_L48:
       lea       rcx,[rbx+2]
       lea       edx,[r14-1]
       cmp       edx,r15d
       jne       short M02_L53
       test      r15d,r15d
       je        short M02_L52
       cmp       r15d,8
       jge       short M02_L49
       mov       rdx,r12
       mov       r8d,r15d
       call      qword ptr [7FFC03C7F330]
       jmp       short M02_L51
M02_L49:
       cmp       r15d,10
       jl        short M02_L50
       mov       rdx,r12
       mov       r8d,r15d
       call      qword ptr [7FFC03C7F0D8]
       jmp       short M02_L51
M02_L50:
       mov       rdx,r12
       mov       r8d,r15d
       call      qword ptr [7FFC03C7F0F0]
M02_L51:
       test      eax,eax
       je        short M02_L53
M02_L52:
       mov       rax,0FFF8000000000000
       mov       [rdi],rax
       jmp       near ptr M02_L05
M02_L53:
       xor       eax,eax
       mov       [rdi],rax
       mov       r8,34BCA45BF5F3
       cmp       [rbp+8],r8
       je        short M02_L54
       call      CORINFO_HELP_FAIL_FAST
M02_L54:
       nop
       lea       rsp,[rbp+78]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L55:
       vxorps    xmm0,xmm0,xmm0
       jmp       near ptr M02_L03
M02_L56:
       vmovsd    xmm0,qword ptr [7FFC03700660]
       jmp       near ptr M02_L03
M02_L57:
       vxorps    xmm0,xmm0,[7FFC03700670]
       jmp       near ptr M02_L04
M02_L58:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1465
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.NumericExtensionsBenchmark.TryParseInvariantIntInvalid()
       push      rsi
       push      rbx
       sub       rsp,38
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       xor       eax,eax
       mov       [rsp+30],rax
       mov       rbx,rcx
       mov       rsi,1D8CF040B7C
       mov       rcx,1983A000100
       mov       rcx,[rcx]
       call      qword ptr [7FFC03BD5668]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider)
       mov       r8,rax
       mov       [rsp+20],rsi
       mov       dword ptr [rsp+28],7
       lea       rcx,[rsp+20]
       lea       r9,[rsp+30]
       mov       edx,7
       call      qword ptr [7FFC03856040]; System.Number.TryParseBinaryIntegerStyle[[System.Char, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.ReadOnlySpan`1<Char>, System.Globalization.NumberStyles, System.Globalization.NumberFormatInfo, Int32 ByRef)
       test      eax,eax
       sete      al
       movzx     eax,al
       mov       rcx,[rbx+90]
       mov       [rcx+4C],al
       mov       eax,[rsp+30]
       mov       rcx,[rbx+90]
       mov       [rcx+38],eax
       add       rsp,38
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 131
```
```assembly
; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider)
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rax,offset MT_System.Globalization.CultureInfo
       cmp       [rbx],rax
       jne       short M01_L00
       mov       rax,[rbx+18]
       test      rax,rax
       je        short M01_L00
       add       rsp,20
       pop       rbx
       ret
M01_L00:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Globalization.NumberFormatInfo
       call      qword ptr [7FFC03636850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       short M01_L01
       mov       rcx,rbx
       mov       r11,7FFC035809E0
       mov       rdx,1D8CF036A68
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,offset MT_System.Globalization.NumberFormatInfo
       call      qword ptr [7FFC03636850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       short M01_L01
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFC03855DD0]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
M01_L01:
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 129
```
```assembly
; System.Number.TryParseBinaryIntegerStyle[[System.Char, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.ReadOnlySpan`1<Char>, System.Globalization.NumberStyles, System.Globalization.NumberFormatInfo, Int32 ByRef)
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
       mov       [rsp+28],rax
       mov       ebx,edx
       mov       rdi,r8
       mov       rsi,r9
       mov       rbp,[rcx]
       mov       r14d,[rcx+8]
       test      r14d,r14d
       je        short M02_L02
       xor       r15d,r15d
       movzx     r13d,word ptr [rbp]
       test      bl,1
       je        short M02_L00
       cmp       r13d,20
       je        short M02_L04
       lea       ecx,[r13-9]
       cmp       ecx,4
       jbe       short M02_L04
M02_L00:
       xor       r12d,r12d
       test      bl,4
       je        short M02_L01
       cmp       byte ptr [rdi+12D],0
       je        short M02_L07
       cmp       r13d,2D
       je        short M02_L05
       cmp       r13d,2B
       je        short M02_L06
M02_L01:
       xor       edi,edi
       xor       ecx,ecx
       lea       eax,[r13-30]
       cmp       eax,9
       jbe       near ptr M02_L18
M02_L02:
       xor       eax,eax
       mov       [rsi],eax
       mov       eax,1
M02_L03:
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
M02_L04:
       inc       r15d
       cmp       r15d,r14d
       jae       short M02_L02
       mov       ecx,r15d
       movzx     r13d,word ptr [rbp+rcx*2]
       mov       ecx,r13d
       call      qword ptr [7FFC03856058]; System.Number.IsWhite(UInt32)
       test      eax,eax
       jne       short M02_L04
       jmp       short M02_L00
M02_L05:
       mov       r12d,1
       inc       r15d
       cmp       r15d,r14d
       jae       short M02_L02
       jmp       short M02_L08
M02_L06:
       inc       r15d
       cmp       r15d,r14d
       jae       short M02_L02
       jmp       short M02_L08
M02_L07:
       cmp       byte ptr [rdi+12E],0
       je        short M02_L09
       cmp       r13d,2D
       jne       short M02_L09
       mov       r12d,1
       inc       r15d
       cmp       r15d,r14d
       jae       short M02_L02
M02_L08:
       mov       r8d,r15d
       movzx     r13d,word ptr [rbp+r8*2]
       jmp       near ptr M02_L01
M02_L09:
       cmp       r15d,r14d
       jbe       short M02_L10
       call      qword ptr [7FFC037A7198]
       int       3
M02_L10:
       mov       r8d,r15d
       lea       rbp,[rbp+r8*2]
       sub       r14d,r15d
       xor       r15d,r15d
       mov       r8,[rdi+20]
       test      r8,r8
       jne       short M02_L11
       xor       edx,edx
       xor       eax,eax
       jmp       short M02_L12
M02_L11:
       lea       rdx,[r8+0C]
       mov       eax,[r8+8]
M02_L12:
       mov       r8,[rdi+28]
       test      r8,r8
       jne       short M02_L13
       xor       edi,edi
       xor       r10d,r10d
       jmp       short M02_L14
M02_L13:
       lea       rdi,[r8+0C]
       mov       r10d,[r8+8]
       mov       [rsp+3C],r10d
       mov       r10d,[rsp+3C]
M02_L14:
       test      eax,eax
       je        short M02_L15
       cmp       eax,r14d
       jg        short M02_L15
       mov       [rsp+3C],r10d
       mov       [rsp+40],eax
       mov       r8d,eax
       add       r8,r8
       mov       rcx,rbp
       call      qword ptr [7FFC0363FBB8]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       test      eax,eax
       mov       r10d,[rsp+3C]
       jne       short M02_L16
M02_L15:
       test      r10d,r10d
       je        near ptr M02_L01
       jmp       short M02_L17
M02_L16:
       mov       r15d,[rsp+40]
       cmp       r15d,r14d
       jae       near ptr M02_L02
       mov       r8d,r15d
       movzx     r13d,word ptr [rbp+r8*2]
       jmp       near ptr M02_L01
M02_L17:
       cmp       r10d,r14d
       jg        near ptr M02_L01
       mov       [rsp+3C],r10d
       mov       r8d,r10d
       add       r8,r8
       mov       rcx,rbp
       mov       rdx,rdi
       call      qword ptr [7FFC0363FBB8]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       test      eax,eax
       je        near ptr M02_L01
       mov       r12d,1
       mov       r15d,[rsp+3C]
       cmp       r15d,r14d
       jae       near ptr M02_L02
       mov       eax,r15d
       movzx     r13d,word ptr [rbp+rax*2]
       jmp       near ptr M02_L01
M02_L18:
       cmp       r13d,30
       jne       short M02_L20
M02_L19:
       inc       r15d
       cmp       r15d,r14d
       jae       short M02_L21
       mov       eax,r15d
       movzx     r13d,word ptr [rbp+rax*2]
       cmp       r13d,30
       je        short M02_L19
       lea       eax,[r13-30]
       cmp       eax,9
       mov       [rsp+44],ecx
       ja        near ptr M02_L29
M02_L20:
       add       r13d,0FFFFFFD0
       mov       ecx,r13d
       mov       r13d,ecx
       inc       r15d
       mov       ecx,9
       jmp       short M02_L23
M02_L21:
       mov       r13d,ecx
       jmp       near ptr M02_L31
M02_L22:
       cmp       r15d,r14d
       jae       near ptr M02_L31
       mov       eax,r15d
       movzx     eax,word ptr [rbp+rax*2]
       lea       edx,[rax-30]
       cmp       edx,9
       ja        near ptr M02_L26
       inc       r15d
       lea       r13d,[r13+r13*4]
       add       r13d,r13d
       add       eax,0FFFFFFD0
       add       r13d,eax
M02_L23:
       dec       ecx
       jne       short M02_L22
       cmp       r15d,r14d
       jae       near ptr M02_L31
       mov       ecx,r15d
       movzx     eax,word ptr [rbp+rcx*2]
       lea       ecx,[rax-30]
       cmp       ecx,9
       ja        short M02_L25
       inc       r15d
       cmp       r13d,0CCCCCCC
       setg      dil
       movzx     edi,dil
       lea       r13d,[r13+r13*4]
       add       r13d,r13d
       add       eax,0FFFFFFD0
       add       r13d,eax
       test      r12d,r12d
       setne     cl
       movzx     ecx,cl
       add       ecx,7FFFFFFF
       mov       [rsp+44],r13d
       cmp       r13d,ecx
       seta      cl
       movzx     ecx,cl
       or        ecx,edi
       movzx     edi,cl
       cmp       r15d,r14d
       jae       short M02_L30
M02_L24:
       cmp       r15d,r14d
       jae       near ptr M02_L36
       mov       ecx,r15d
       movzx     eax,word ptr [rbp+rcx*2]
       lea       ecx,[rax-30]
       cmp       ecx,9
       mov       r13d,eax
       jbe       short M02_L27
       jmp       short M02_L29
M02_L25:
       mov       [rsp+44],r13d
       mov       r13d,eax
       jmp       short M02_L29
M02_L26:
       mov       [rsp+44],r13d
       mov       r13d,eax
       jmp       short M02_L29
M02_L27:
       mov       edi,1
       inc       r15d
       cmp       r15d,r14d
       jb        short M02_L24
M02_L28:
       xor       eax,eax
       mov       [rsi],eax
       mov       eax,2
       jmp       near ptr M02_L03
M02_L29:
       mov       ecx,r13d
       call      qword ptr [7FFC03856058]; System.Number.IsWhite(UInt32)
       test      eax,eax
       je        short M02_L35
       jmp       short M02_L32
M02_L30:
       test      edi,edi
       mov       r13d,[rsp+44]
       jne       short M02_L28
M02_L31:
       mov       eax,r13d
       neg       eax
       test      r12d,r12d
       cmove     eax,r13d
       mov       [rsi],eax
       xor       eax,eax
       jmp       near ptr M02_L03
M02_L32:
       test      bl,2
       je        near ptr M02_L02
M02_L33:
       inc       r15d
       cmp       r15d,r14d
       jge       short M02_L34
       cmp       r15d,r14d
       jae       short M02_L36
       mov       ecx,r15d
       movzx     ecx,word ptr [rbp+rcx*2]
       call      qword ptr [7FFC03856058]; System.Number.IsWhite(UInt32)
       test      eax,eax
       jne       short M02_L33
M02_L34:
       cmp       r15d,r14d
       jae       short M02_L30
M02_L35:
       mov       [rsp+28],rbp
       mov       [rsp+30],r14d
       lea       rcx,[rsp+28]
       mov       edx,r15d
       call      qword ptr [7FFC03CF48D0]
       test      eax,eax
       jne       short M02_L30
       jmp       near ptr M02_L02
M02_L36:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 909
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.NumericExtensionsBenchmark.TryParseInvariantIntValid()
       push      rsi
       push      rbx
       sub       rsp,38
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       xor       eax,eax
       mov       [rsp+30],rax
       mov       rbx,rcx
       mov       rsi,152FA450B7C
       mov       rcx,11265400100
       mov       rcx,[rcx]
       call      qword ptr [7FFC03BC5668]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider)
       mov       r8,rax
       mov       [rsp+20],rsi
       mov       dword ptr [rsp+28],5
       lea       rcx,[rsp+20]
       lea       r9,[rsp+30]
       mov       edx,7
       call      qword ptr [7FFC03846040]; System.Number.TryParseBinaryIntegerStyle[[System.Char, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.ReadOnlySpan`1<Char>, System.Globalization.NumberStyles, System.Globalization.NumberFormatInfo, Int32 ByRef)
       test      eax,eax
       sete      al
       movzx     eax,al
       mov       rcx,[rbx+90]
       mov       [rcx+4C],al
       mov       eax,[rsp+30]
       mov       rcx,[rbx+90]
       mov       [rcx+38],eax
       add       rsp,38
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 131
```
```assembly
; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider)
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rax,offset MT_System.Globalization.CultureInfo
       cmp       [rbx],rax
       jne       short M01_L00
       mov       rax,[rbx+18]
       test      rax,rax
       je        short M01_L00
       add       rsp,20
       pop       rbx
       ret
M01_L00:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Globalization.NumberFormatInfo
       call      qword ptr [7FFC03626850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       short M01_L01
       mov       rcx,rbx
       mov       r11,7FFC035708A0
       mov       rdx,152FA446A68
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,offset MT_System.Globalization.NumberFormatInfo
       call      qword ptr [7FFC03626850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       short M01_L01
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFC03845DD0]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
M01_L01:
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 129
```
```assembly
; System.Number.TryParseBinaryIntegerStyle[[System.Char, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.ReadOnlySpan`1<Char>, System.Globalization.NumberStyles, System.Globalization.NumberFormatInfo, Int32 ByRef)
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
       mov       [rsp+20],rax
       mov       ebx,edx
       mov       rdi,r8
       mov       rsi,r9
       mov       rbp,[rcx]
       mov       r14d,[rcx+8]
       test      r14d,r14d
       je        near ptr M02_L08
       xor       r15d,r15d
       movzx     r13d,word ptr [rbp]
       test      bl,1
       je        short M02_L00
       cmp       r13d,20
       je        near ptr M02_L06
       lea       ecx,[r13-9]
       cmp       ecx,4
       jbe       near ptr M02_L06
M02_L00:
       xor       r12d,r12d
       test      bl,4
       je        short M02_L01
       cmp       byte ptr [rdi+12D],0
       je        near ptr M02_L11
       cmp       r13d,2D
       je        near ptr M02_L09
       cmp       r13d,2B
       je        near ptr M02_L10
M02_L01:
       xor       edi,edi
       xor       ecx,ecx
       lea       eax,[r13-30]
       cmp       eax,9
       ja        near ptr M02_L08
       cmp       r13d,30
       je        near ptr M02_L07
M02_L02:
       add       r13d,0FFFFFFD0
       mov       ecx,r13d
       mov       r13d,ecx
       inc       r15d
       cmp       r15d,r14d
       jae       short M02_L04
       mov       ecx,8
M02_L03:
       cmp       r15d,r14d
       jae       near ptr M02_L34
       mov       eax,r15d
       movzx     eax,word ptr [rbp+rax*2]
       lea       edx,[rax-30]
       cmp       edx,9
       ja        near ptr M02_L28
       inc       r15d
       lea       r13d,[r13+r13*4]
       add       r13d,r13d
       add       r13d,edx
       dec       ecx
       je        near ptr M02_L23
       cmp       r15d,r14d
       jb        short M02_L03
M02_L04:
       mov       eax,r13d
       neg       eax
       test      r12d,r12d
       cmove     eax,r13d
       mov       [rsi],eax
       xor       eax,eax
M02_L05:
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
M02_L06:
       inc       r15d
       cmp       r15d,r14d
       jae       short M02_L08
       mov       ecx,r15d
       movzx     r13d,word ptr [rbp+rcx*2]
       mov       ecx,r13d
       call      qword ptr [7FFC03846058]; System.Number.IsWhite(UInt32)
       test      eax,eax
       jne       short M02_L06
       jmp       near ptr M02_L00
M02_L07:
       inc       r15d
       cmp       r15d,r14d
       jb        near ptr M02_L22
       mov       r13d,ecx
       jmp       short M02_L04
M02_L08:
       xor       eax,eax
       mov       [rsi],eax
       mov       eax,1
       jmp       short M02_L05
M02_L09:
       mov       r12d,1
       inc       r15d
       cmp       r15d,r14d
       jae       short M02_L08
       jmp       short M02_L12
M02_L10:
       inc       r15d
       cmp       r15d,r14d
       jae       short M02_L08
       jmp       short M02_L12
M02_L11:
       cmp       byte ptr [rdi+12E],0
       je        short M02_L13
       cmp       r13d,2D
       jne       short M02_L13
       mov       r12d,1
       inc       r15d
       cmp       r15d,r14d
       jae       short M02_L08
M02_L12:
       mov       r8d,r15d
       movzx     r13d,word ptr [rbp+r8*2]
       jmp       near ptr M02_L01
M02_L13:
       cmp       r15d,r14d
       jbe       short M02_L14
       call      qword ptr [7FFC03797198]
       int       3
M02_L14:
       mov       r8d,r15d
       lea       rbp,[rbp+r8*2]
       sub       r14d,r15d
       xor       r15d,r15d
       mov       r8,[rdi+20]
       test      r8,r8
       jne       short M02_L15
       xor       edx,edx
       xor       eax,eax
       jmp       short M02_L16
M02_L15:
       lea       rdx,[r8+0C]
       mov       eax,[r8+8]
M02_L16:
       mov       r8,[rdi+28]
       test      r8,r8
       jne       short M02_L17
       xor       edi,edi
       xor       r10d,r10d
       jmp       short M02_L18
M02_L17:
       lea       rdi,[r8+0C]
       mov       r10d,[r8+8]
       mov       [rsp+30],r10d
       mov       r10d,[rsp+30]
M02_L18:
       test      eax,eax
       je        short M02_L19
       cmp       eax,r14d
       jg        short M02_L19
       mov       [rsp+30],r10d
       mov       [rsp+34],eax
       mov       r8d,eax
       add       r8,r8
       mov       rcx,rbp
       call      qword ptr [7FFC0362FBB8]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       test      eax,eax
       mov       r10d,[rsp+30]
       jne       short M02_L20
M02_L19:
       test      r10d,r10d
       je        near ptr M02_L01
       jmp       short M02_L21
M02_L20:
       mov       r15d,[rsp+34]
       cmp       r15d,r14d
       jae       near ptr M02_L08
       mov       r8d,r15d
       movzx     r13d,word ptr [rbp+r8*2]
       jmp       near ptr M02_L01
M02_L21:
       cmp       r10d,r14d
       jg        near ptr M02_L01
       mov       [rsp+30],r10d
       mov       r8d,r10d
       add       r8,r8
       mov       rcx,rbp
       mov       rdx,rdi
       call      qword ptr [7FFC0362FBB8]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       test      eax,eax
       je        near ptr M02_L01
       mov       r12d,1
       mov       r15d,[rsp+30]
       cmp       r15d,r14d
       jae       near ptr M02_L08
       mov       eax,r15d
       movzx     r13d,word ptr [rbp+rax*2]
       jmp       near ptr M02_L01
M02_L22:
       mov       eax,r15d
       movzx     r13d,word ptr [rbp+rax*2]
       cmp       r13d,30
       je        near ptr M02_L07
       lea       eax,[r13-30]
       cmp       eax,9
       ja        near ptr M02_L25
       jmp       near ptr M02_L02
M02_L23:
       cmp       r15d,r14d
       jae       near ptr M02_L04
       mov       eax,r15d
       movzx     eax,word ptr [rbp+rax*2]
       lea       ecx,[rax-30]
       cmp       ecx,9
       ja        near ptr M02_L28
       inc       r15d
       cmp       r13d,0CCCCCCC
       setg      dil
       movzx     edi,dil
       lea       r13d,[r13+r13*4]
       add       r13d,r13d
       add       eax,0FFFFFFD0
       add       r13d,eax
       test      r12d,r12d
       setne     cl
       movzx     ecx,cl
       add       ecx,7FFFFFFF
       cmp       r13d,ecx
       seta      cl
       movzx     ecx,cl
       or        ecx,edi
       movzx     edi,cl
       cmp       r15d,r14d
       jae       short M02_L29
M02_L24:
       cmp       r15d,r14d
       jae       near ptr M02_L34
       mov       ecx,r15d
       movzx     eax,word ptr [rbp+rcx*2]
       lea       ecx,[rax-30]
       cmp       ecx,9
       jbe       short M02_L26
       jmp       short M02_L28
M02_L25:
       mov       eax,r13d
       mov       r13d,ecx
       jmp       short M02_L28
M02_L26:
       mov       edi,1
       inc       r15d
       cmp       r15d,r14d
       jb        short M02_L24
M02_L27:
       xor       eax,eax
       mov       [rsi],eax
       mov       eax,2
       jmp       near ptr M02_L05
M02_L28:
       mov       ecx,eax
       call      qword ptr [7FFC03846058]; System.Number.IsWhite(UInt32)
       test      eax,eax
       je        short M02_L33
       jmp       short M02_L30
M02_L29:
       test      edi,edi
       jne       short M02_L27
       jmp       near ptr M02_L04
M02_L30:
       test      bl,2
       je        near ptr M02_L08
M02_L31:
       inc       r15d
       cmp       r15d,r14d
       jge       short M02_L32
       cmp       r15d,r14d
       jae       short M02_L34
       mov       ecx,r15d
       movzx     ecx,word ptr [rbp+rcx*2]
       call      qword ptr [7FFC03846058]; System.Number.IsWhite(UInt32)
       test      eax,eax
       jne       short M02_L31
M02_L32:
       cmp       r15d,r14d
       jae       short M02_L29
M02_L33:
       mov       [rsp+20],rbp
       mov       [rsp+28],r14d
       lea       rcx,[rsp+20]
       mov       edx,r15d
       call      qword ptr [7FFC03C3EBC8]
       test      eax,eax
       jne       short M02_L29
       jmp       near ptr M02_L08
M02_L34:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 935
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.NumericExtensionsBenchmark.RoundToNearestMultiple()
       mov       rax,[rcx+90]
       mov       dword ptr [rax+38],30
       ret
; Total bytes of code 15
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       esi,[rbx+1C0]
       test      esi,esi
       je        near ptr M00_L60
       test      esi,esi
       jl        near ptr M00_L61
       mov       rcx,1228E401DC8
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
       call      00007FFC632821C0
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
       jle       near ptr M00_L11
       mov       ecx,r15d
       call      qword ptr [7FFC03C76820]; DotNetTips.Spargine.Extensions.NumericExtensions.ToWords(Int32)
       cmp       [r14],r14b
       test      rax,rax
       je        short M00_L06
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
       test      r8d,r8d
       je        short M00_L06
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
       call      qword ptr [7FFC03665818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L05:
       mov       [r14+18],r13d
M00_L06:
       mov       ecx,[r14+18]
       mov       edx,ecx
       mov       rax,[r14+8]
       mov       r8d,[rax+8]
       cmp       r8d,edx
       jbe       near ptr M00_L34
       mov       word ptr [rax+rdx*2+10],20
       inc       ecx
       mov       [r14+18],ecx
M00_L07:
       call      qword ptr [7FFC03C768B0]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Thousand()
       test      rax,rax
       je        short M00_L09
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
       test      r8d,r8d
       je        short M00_L09
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
       call      qword ptr [7FFC03665818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L08:
       mov       [r14+18],r13d
M00_L09:
       mov       ecx,[r14+18]
       mov       edx,ecx
       mov       rax,[r14+8]
       mov       r8d,[rax+8]
       cmp       r8d,edx
       jbe       near ptr M00_L37
       mov       word ptr [rax+rdx*2+10],20
       inc       ecx
       mov       [r14+18],ecx
M00_L10:
       imul      eax,r15d,3E8
       sub       esi,eax
M00_L11:
       mov       edx,51EB851F
       mov       eax,edx
       imul      esi
       mov       r15d,edx
       shr       r15d,1F
       sar       edx,5
       add       r15d,edx
       test      r15d,r15d
       jg        near ptr M00_L19
M00_L12:
       test      esi,esi
       jle       near ptr M00_L17
       mov       eax,[r14+1C]
       add       eax,[r14+18]
       test      eax,eax
       jg        near ptr M00_L26
M00_L13:
       cmp       esi,14
       jl        near ptr M00_L29
       mov       edx,66666667
       mov       eax,edx
       imul      esi
       mov       r15d,edx
       shr       r15d,1F
       sar       edx,2
       add       r15d,edx
       mov       r8,1228E401DD0
       mov       r8,[r8]
       cmp       r15d,0A
       jae       near ptr M00_L50
       mov       ecx,r15d
       mov       r8,[r8+rcx*8+10]
       test      r8,r8
       je        short M00_L15
       lea       rdx,[r8+0C]
       mov       r8d,[r8+8]
       test      r8d,r8d
       je        short M00_L15
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
       call      qword ptr [7FFC03665818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L14:
       mov       [r14+18],r13d
M00_L15:
       lea       ecx,[r15+r15*4]
       add       ecx,ecx
       sub       esi,ecx
       test      esi,esi
       jle       short M00_L17
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
M00_L16:
       mov       r8,1228E401DD8
       mov       r15,[r8]
       cmp       esi,14
       jae       near ptr M00_L50
       mov       r8d,esi
       mov       rdx,[r15+r8*8+10]
       test      rdx,rdx
       je        short M00_L17
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,r14
       call      qword ptr [7FFC037DF150]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M00_L17:
       mov       rcx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFC03852200]; System.Text.StringBuilder.ToString()
       mov       rsi,rax
       mov       r15d,[rsi+8]
       test      r15d,r15d
       je        short M00_L18
       movzx     ecx,word ptr [rsi+0C]
       call      qword ptr [7FFC03C079C0]; System.Char.IsWhiteSpace(Char)
       test      eax,eax
       jne       near ptr M00_L53
       lea       ecx,[r15-1]
       cmp       ecx,r15d
       jae       near ptr M00_L50
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       call      qword ptr [7FFC03C079C0]; System.Char.IsWhiteSpace(Char)
       test      eax,eax
       jne       near ptr M00_L53
M00_L18:
       mov       r15,rsi
       jmp       near ptr M00_L54
M00_L19:
       mov       ecx,r15d
       call      qword ptr [7FFC03C76820]; DotNetTips.Spargine.Extensions.NumericExtensions.ToWords(Int32)
       cmp       [r14],r14b
       test      rax,rax
       je        short M00_L21
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
       test      r8d,r8d
       je        short M00_L21
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
       call      qword ptr [7FFC03665818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L20:
       mov       [r14+18],r13d
M00_L21:
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
M00_L22:
       call      qword ptr [7FFC03C768C8]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Hundred()
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
       ja        near ptr M00_L42
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jle       near ptr M00_L41
       mov       r8d,r8d
       add       r8,r8
       call      qword ptr [7FFC03665818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L23:
       mov       [r14+18],r13d
M00_L24:
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
M00_L25:
       imul      eax,r15d,64
       sub       esi,eax
       jmp       near ptr M00_L12
M00_L26:
       call      qword ptr [7FFC03C768F8]; DotNetTips.Spargine.Extensions.Properties.Resources.get_AndLowerCase()
       test      rax,rax
       je        short M00_L28
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
       test      r8d,r8d
       je        short M00_L28
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
       call      qword ptr [7FFC03665818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L27:
       mov       [r14+18],r15d
M00_L28:
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
       jmp       near ptr M00_L13
M00_L29:
       mov       r8,1228E401DD8
       mov       r15,[r8]
       cmp       esi,14
       jae       near ptr M00_L50
       mov       r8d,esi
       mov       r8,[r15+r8*8+10]
       test      r8,r8
       je        near ptr M00_L17
       lea       rdx,[r8+0C]
       mov       r8d,[r8+8]
       test      r8d,r8d
       je        near ptr M00_L17
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
       call      qword ptr [7FFC03665818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L30:
       mov       [r14+18],esi
       jmp       near ptr M00_L17
M00_L31:
       mov       ecx,esi
       imul      rcx,431BDE83
       shr       rcx,32
       call      qword ptr [7FFC03C76820]; DotNetTips.Spargine.Extensions.NumericExtensions.ToWords(Int32)
       mov       rdx,rax
       mov       rcx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFC037DF228]; System.Text.StringBuilder.Append(System.String)
       mov       rcx,rax
       mov       edx,20
       cmp       [rcx],ecx
       call      qword ptr [7FFC037DF180]; System.Text.StringBuilder.Append(Char)
       mov       r15,rax
       call      qword ptr [7FFC03C76898]
       mov       rdx,rax
       mov       rcx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFC037DF228]; System.Text.StringBuilder.Append(System.String)
       mov       rcx,rax
       mov       edx,20
       cmp       [rcx],ecx
       call      qword ptr [7FFC037DF180]; System.Text.StringBuilder.Append(Char)
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
       jne       near ptr M00_L05
       movzx     edx,word ptr [rdx+2]
       mov       [rcx+2],dx
       jmp       near ptr M00_L05
M00_L33:
       mov       rcx,r14
       call      qword ptr [7FFC037DF1E0]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M00_L06
M00_L34:
       mov       rcx,r14
       mov       edx,20
       call      qword ptr [7FFC037DF3A8]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L07
M00_L35:
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       jne       near ptr M00_L08
       movzx     edx,word ptr [rdx+2]
       mov       [rcx+2],dx
       jmp       near ptr M00_L08
M00_L36:
       mov       rcx,r14
       call      qword ptr [7FFC037DF1E0]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M00_L09
M00_L37:
       mov       rcx,r14
       mov       edx,20
       call      qword ptr [7FFC037DF3A8]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L10
M00_L38:
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       jne       near ptr M00_L20
       movzx     edx,word ptr [rdx+2]
       mov       [rcx+2],dx
       jmp       near ptr M00_L20
M00_L39:
       mov       rcx,r14
       call      qword ptr [7FFC037DF1E0]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M00_L21
M00_L40:
       mov       rcx,r14
       mov       edx,20
       call      qword ptr [7FFC037DF3A8]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L22
M00_L41:
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       jne       near ptr M00_L23
       movzx     edx,word ptr [rdx+2]
       mov       [rcx+2],dx
       jmp       near ptr M00_L23
M00_L42:
       mov       rcx,r14
       call      qword ptr [7FFC037DF1E0]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M00_L24
M00_L43:
       mov       rcx,r14
       mov       edx,20
       call      qword ptr [7FFC037DF3A8]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L25
M00_L44:
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       jne       near ptr M00_L27
       movzx     edx,word ptr [rdx+2]
       mov       [rcx+2],dx
       jmp       near ptr M00_L27
M00_L45:
       mov       rcx,r14
       call      qword ptr [7FFC037DF1E0]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M00_L28
M00_L46:
       mov       rcx,r14
       mov       edx,20
       call      qword ptr [7FFC037DF3A8]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L13
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
       call      qword ptr [7FFC037DF1E0]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M00_L17
M00_L49:
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       jne       near ptr M00_L14
       movzx     edx,word ptr [rdx+2]
       mov       [rcx+2],dx
       jmp       near ptr M00_L14
M00_L50:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L51:
       mov       rcx,r14
       call      qword ptr [7FFC037DF1E0]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M00_L15
M00_L52:
       mov       rcx,r14
       mov       edx,2D
       call      qword ptr [7FFC037DF3A8]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L16
M00_L53:
       mov       rcx,rsi
       mov       edx,3
       call      qword ptr [7FFC03C7F750]
       mov       r15,rax
M00_L54:
       mov       rcx,rdi
       call      qword ptr [7FFC039E4078]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].get_Value()
       mov       rsi,rax
       mov       rcx,r14
       xor       edx,edx
       call      qword ptr [7FFC03C0DD40]; System.Text.StringBuilder.set_Length(Int32)
       mov       rcx,offset MT_Microsoft.Extensions.ObjectPool.DefaultObjectPool<System.Text.StringBuilder>
       cmp       [rsi],rcx
       jne       near ptr M00_L66
       mov       rcx,rsi
       mov       rdx,r14
       call      qword ptr [7FFC03C0DD58]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].ReturnCore(System.__Canon)
M00_L55:
       mov       [rbp-40],r15
       mov       rcx,[rbx+90]
       lea       r8,[rbp-40]
       mov       rdx,7FFC03CA8760
       cmp       [rcx],ecx
       call      qword ptr [7FFC03C76DD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFC03C0DC08]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       jne       short M00_L57
       cmp       qword ptr [r13+10],0
       je        short M00_L58
       lea       rdx,[rbp-38]
       mov       rcx,r15
       call      qword ptr [7FFC03C7F4B0]
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
       call      qword ptr [7FFC03C76838]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Zero()
       mov       r15,rax
       jmp       near ptr M00_L55
M00_L61:
       call      qword ptr [7FFC03C76850]
       mov       r15,rax
       mov       ecx,1
       call      qword ptr [7FFC03666670]; System.String.FastAllocateString(IntPtr)
       mov       rdi,rax
       mov       word ptr [rdi+0C],20
       mov       ecx,esi
       neg       ecx
       jns       short M00_L62
       call      qword ptr [7FFC03C7FAE0]
       int       3
M00_L62:
       call      qword ptr [7FFC03C76820]; DotNetTips.Spargine.Extensions.NumericExtensions.ToWords(Int32)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,r15
       call      qword ptr [7FFC03667828]; System.String.Concat(System.String, System.String, System.String)
       mov       r15,rax
       jmp       near ptr M00_L55
M00_L63:
       call      qword ptr [7FFC039E40D8]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       r14,rax
       jmp       near ptr M00_L00
M00_L64:
       call      qword ptr [7FFC03C7F378]
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
       mov       rcx,1228E401DC8
       mov       rdi,[rcx]
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFC039E4078]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].get_Value()
       mov       r15,rax
       mov       rdx,[rbp-48]
       cmp       [rdx],dl
       mov       rcx,rdx
       xor       edx,edx
       call      qword ptr [7FFC03C0DD40]; System.Text.StringBuilder.set_Length(Int32)
       mov       rcx,offset MT_Microsoft.Extensions.ObjectPool.DefaultObjectPool<System.Text.StringBuilder>
       cmp       [r15],rcx
       jne       short M00_L67
       mov       rcx,r15
       mov       rdx,[rbp-48]
       call      qword ptr [7FFC03C0DD58]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].ReturnCore(System.__Canon)
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
; Total bytes of code 2350
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
M01_L00:
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
       je        near ptr M01_L125
       cmp       dword ptr [rbp+10],0
       jl        near ptr M01_L126
       mov       rcx,1228E401DC8
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0
       jne       near ptr M01_L139
       mov       rbx,[rcx+18]
M01_L01:
       mov       rcx,offset MT_Microsoft.Extensions.ObjectPool.DefaultObjectPool<System.Text.StringBuilder>
       cmp       [rbx],rcx
       jne       near ptr M01_L141
       mov       rcx,[rbx+20]
       mov       [rbp-30],rcx
       cmp       qword ptr [rbp-30],0
       je        near ptr M01_L121
       lea       rcx,[rbx+20]
       mov       r8,[rbp-30]
       test      rcx,rcx
       je        near ptr M01_L140
       xor       edx,edx
       call      00007FFC632821C0
       cmp       rax,[rbp-30]
       jne       near ptr M01_L121
M01_L02:
       mov       rbx,[rbp-30]
M01_L03:
       xor       ecx,ecx
       mov       [rbp-30],rcx
M01_L04:
       mov       [rbp-38],rbx
       mov       ecx,[rbp+10]
       imul      rcx,431BDE83
       shr       rcx,32
       test      ecx,ecx
       jg        near ptr M01_L98
M01_L05:
       mov       edx,10624DD3
       mov       eax,edx
       imul      dword ptr [rbp+10]
       mov       ebx,edx
       shr       ebx,1F
       sar       edx,6
       add       ebx,edx
       test      ebx,ebx
       jle       near ptr M01_L47
       mov       rcx,1228E401DC8
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0
       jne       near ptr M01_L106
       mov       rcx,[rcx+18]
M01_L06:
       mov       rax,offset MT_Microsoft.Extensions.ObjectPool.DefaultObjectPool<System.Text.StringBuilder>
       cmp       [rcx],rax
       jne       near ptr M01_L107
       cmp       [rcx],ecx
       call      qword ptr [7FFC03C2BF18]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Get()
       mov       rsi,rax
M01_L07:
       mov       [rbp-58],rsi
       mov       edx,431BDE83
       mov       eax,edx
       imul      ebx
       mov       eax,edx
       shr       eax,1F
       sar       edx,12
       add       eax,edx
       test      eax,eax
       jg        near ptr M01_L25
M01_L08:
       mov       edx,10624DD3
       mov       eax,edx
       imul      ebx
       mov       edi,edx
       shr       edi,1F
       sar       edx,6
       add       edi,edx
       test      edi,edi
       jle       near ptr M01_L11
       mov       ecx,edi
       call      qword ptr [7FFC03C76820]
       mov       rdx,rax
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFC037DF228]; System.Text.StringBuilder.Append(System.String)
       mov       r14,rax
       mov       ecx,[r14+18]
       mov       edx,ecx
       mov       rax,[r14+8]
       mov       r8d,[rax+8]
       cmp       r8d,edx
       jbe       near ptr M01_L26
       cmp       edx,r8d
       jae       near ptr M01_L34
       mov       word ptr [rax+rdx*2+10],20
       inc       ecx
       mov       [r14+18],ecx
M01_L09:
       call      qword ptr [7FFC03C768B0]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Thousand()
       mov       rdx,rax
       mov       rcx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFC037DF228]; System.Text.StringBuilder.Append(System.String)
       mov       ecx,[rax+18]
       mov       edx,ecx
       mov       r8,[rax+8]
       mov       r10d,[r8+8]
       cmp       r10d,edx
       jbe       near ptr M01_L27
       cmp       edx,r10d
       jae       near ptr M01_L34
       mov       word ptr [r8+rdx*2+10],20
       inc       ecx
       mov       [rax+18],ecx
M01_L10:
       imul      eax,edi,3E8
       sub       ebx,eax
M01_L11:
       mov       edx,51EB851F
       mov       eax,edx
       imul      ebx
       mov       edi,edx
       shr       edi,1F
       sar       edx,5
       add       edi,edx
       test      edi,edi
       jg        near ptr M01_L20
M01_L12:
       test      ebx,ebx
       jle       near ptr M01_L16
       mov       eax,[rsi+1C]
       add       eax,[rsi+18]
       test      eax,eax
       jg        near ptr M01_L23
M01_L13:
       cmp       ebx,14
       jl        near ptr M01_L24
       mov       edx,66666667
       mov       eax,edx
       imul      ebx
       mov       edi,edx
       shr       edi,1F
       sar       edx,2
       add       edi,edx
       mov       r8,1228E401DD0
       mov       r8,[r8]
       cmp       edi,0A
       jae       near ptr M01_L34
       mov       edx,edi
       mov       rdx,[r8+rdx*8+10]
       test      rdx,rdx
       je        short M01_L14
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,rsi
       call      qword ptr [7FFC037DF150]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M01_L14:
       lea       ecx,[rdi+rdi*4]
       add       ecx,ecx
       sub       ebx,ecx
       test      ebx,ebx
       jle       short M01_L16
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       rax,[rsi+8]
       mov       r8d,[rax+8]
       cmp       r8d,edx
       jbe       near ptr M01_L31
       cmp       edx,r8d
       jae       near ptr M01_L34
       mov       word ptr [rax+rdx*2+10],2D
       inc       ecx
       mov       [rsi+18],ecx
M01_L15:
       mov       r8,1228E401DD8
       mov       r14,[r8]
       cmp       ebx,14
       jae       near ptr M01_L34
       mov       r8d,ebx
       mov       rdx,[r14+r8*8+10]
       test      rdx,rdx
       je        short M01_L16
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,rsi
       call      qword ptr [7FFC037DF150]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M01_L16:
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFC03852200]; System.Text.StringBuilder.ToString()
       mov       r14,rax
       cmp       dword ptr [r14+8],0
       je        short M01_L18
       movzx     ecx,word ptr [r14+0C]
       cmp       ecx,100
       jge       near ptr M01_L32
       cmp       ecx,100
       jae       near ptr M01_L34
       mov       rax,7FFC5F9F6BF0
       test      byte ptr [rax+rcx],80
       jne       near ptr M01_L35
M01_L17:
       mov       ecx,[r14+8]
       dec       ecx
       cmp       ecx,[r14+8]
       jae       near ptr M01_L34
       movzx     ecx,word ptr [r14+rcx*2+0C]
       cmp       ecx,100
       jge       near ptr M01_L33
       cmp       ecx,100
       jae       near ptr M01_L34
       mov       rax,7FFC5F9F6BF0
       test      byte ptr [rax+rcx],80
       jne       near ptr M01_L35
M01_L18:
       mov       r8,r14
M01_L19:
       mov       [rbp-60],r8
       jmp       near ptr M01_L36
M01_L20:
       mov       ecx,edi
       call      qword ptr [7FFC03C76820]
       mov       rdx,rax
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFC037DF228]; System.Text.StringBuilder.Append(System.String)
       mov       r14,rax
       mov       ecx,[r14+18]
       mov       edx,ecx
       mov       rax,[r14+8]
       mov       r8d,[rax+8]
       cmp       r8d,edx
       jbe       near ptr M01_L28
       cmp       edx,r8d
       jae       near ptr M01_L34
       mov       word ptr [rax+rdx*2+10],20
       inc       ecx
       mov       [r14+18],ecx
M01_L21:
       call      qword ptr [7FFC03C768C8]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Hundred()
       mov       rdx,rax
       mov       rcx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFC037DF228]; System.Text.StringBuilder.Append(System.String)
       mov       ecx,[rax+18]
       mov       edx,ecx
       mov       r8,[rax+8]
       mov       r10d,[r8+8]
       cmp       r10d,edx
       jbe       near ptr M01_L29
       cmp       edx,r10d
       jae       near ptr M01_L34
       mov       word ptr [r8+rdx*2+10],20
       inc       ecx
       mov       [rax+18],ecx
M01_L22:
       imul      eax,edi,64
       sub       ebx,eax
       jmp       near ptr M01_L12
M01_L23:
       call      qword ptr [7FFC03C768F8]; DotNetTips.Spargine.Extensions.Properties.Resources.get_AndLowerCase()
       mov       rdx,rax
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFC037DF228]; System.Text.StringBuilder.Append(System.String)
       mov       ecx,[rax+18]
       mov       edx,ecx
       mov       r8,[rax+8]
       mov       r10d,[r8+8]
       cmp       r10d,edx
       jbe       near ptr M01_L30
       cmp       edx,r10d
       jae       near ptr M01_L34
       mov       word ptr [r8+rdx*2+10],20
       inc       ecx
       mov       [rax+18],ecx
       jmp       near ptr M01_L13
M01_L24:
       mov       rdx,1228E401DD8
       mov       r14,[rdx]
       cmp       ebx,14
       jae       near ptr M01_L34
       mov       edx,ebx
       mov       rdx,[r14+rdx*8+10]
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFC037DF228]; System.Text.StringBuilder.Append(System.String)
       jmp       near ptr M01_L16
M01_L25:
       mov       edx,431BDE83
       mov       eax,edx
       imul      ebx
       mov       ecx,edx
       shr       ecx,1F
       sar       edx,12
       add       ecx,edx
       call      qword ptr [7FFC03C76820]
       mov       rdx,rax
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFC037DF228]; System.Text.StringBuilder.Append(System.String)
       mov       rcx,rax
       mov       edx,20
       cmp       [rcx],ecx
       call      qword ptr [7FFC037DF180]; System.Text.StringBuilder.Append(Char)
       mov       rdi,rax
       call      qword ptr [7FFC03C76898]
       mov       rdx,rax
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFC037DF228]; System.Text.StringBuilder.Append(System.String)
       mov       rcx,rax
       mov       edx,20
       cmp       [rcx],ecx
       call      qword ptr [7FFC037DF180]; System.Text.StringBuilder.Append(Char)
       mov       edx,431BDE83
       mov       eax,edx
       imul      ebx
       mov       eax,edx
       shr       eax,1F
       sar       edx,12
       add       eax,edx
       imul      eax,0F4240
       sub       ebx,eax
       jmp       near ptr M01_L08
M01_L26:
       mov       rcx,r14
       mov       edx,20
       call      qword ptr [7FFC037DF3A8]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M01_L09
M01_L27:
       mov       rcx,rax
       mov       edx,20
       call      qword ptr [7FFC037DF3A8]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M01_L10
M01_L28:
       mov       rcx,r14
       mov       edx,20
       call      qword ptr [7FFC037DF3A8]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M01_L21
M01_L29:
       mov       rcx,rax
       mov       edx,20
       call      qword ptr [7FFC037DF3A8]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M01_L22
M01_L30:
       mov       rcx,rax
       mov       edx,20
       call      qword ptr [7FFC037DF3A8]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M01_L13
M01_L31:
       mov       rcx,rsi
       mov       edx,2D
       call      qword ptr [7FFC037DF3A8]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M01_L15
M01_L32:
       call      qword ptr [7FFC03C7F738]
       test      eax,eax
       jne       short M01_L35
       jmp       near ptr M01_L17
M01_L33:
       call      qword ptr [7FFC03C7F738]
       test      eax,eax
       jne       short M01_L35
       jmp       near ptr M01_L18
M01_L34:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M01_L35:
       mov       rcx,r14
       mov       edx,3
       call      qword ptr [7FFC03C7F750]
       mov       r8,rax
       jmp       near ptr M01_L19
M01_L36:
       call      M01_L142
       nop
       mov       r8,[rbp-60]
       mov       rbx,[rbp-38]
       cmp       [rbx],bl
       test      r8,r8
       je        short M01_L39
       lea       rdx,[r8+0C]
       mov       r8d,[r8+8]
       test      r8d,r8d
       je        short M01_L39
       mov       rsi,[rbx+8]
       mov       edi,[rbx+18]
       lea       r14d,[rdi+r8]
       cmp       r14d,[rsi+8]
       jbe       short M01_L37
       mov       rcx,rbx
       call      qword ptr [7FFC037DF1E0]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M01_L39
M01_L37:
       movsxd    rcx,edi
       lea       rcx,[rsi+rcx*2+10]
       cmp       r8d,2
       jle       near ptr M01_L41
       mov       r8d,r8d
       add       r8,r8
       call      qword ptr [7FFC03665818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L38:
       mov       [rbx+18],r14d
M01_L39:
       mov       ecx,[rbx+18]
       mov       edx,ecx
       mov       rax,[rbx+8]
       mov       r8d,[rax+8]
       cmp       r8d,edx
       jbe       near ptr M01_L108
       cmp       edx,r8d
       jae       near ptr M01_L111
       mov       word ptr [rax+rdx*2+10],20
       inc       ecx
       mov       [rbx+18],ecx
M01_L40:
       call      qword ptr [7FFC03C768B0]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Thousand()
       test      rax,rax
       je        short M01_L45
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
       test      r8d,r8d
       je        short M01_L45
       mov       rsi,[rbx+8]
       mov       edi,[rbx+18]
       lea       r14d,[rdi+r8]
       cmp       r14d,[rsi+8]
       ja        short M01_L42
       movsxd    rcx,edi
       lea       rcx,[rsi+rcx*2+10]
       cmp       r8d,2
       jg        short M01_L43
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       jne       short M01_L44
       movzx     edx,word ptr [rdx+2]
       mov       [rcx+2],dx
       jmp       short M01_L44
M01_L41:
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       jne       near ptr M01_L38
       movzx     edx,word ptr [rdx+2]
       mov       [rcx+2],dx
       jmp       near ptr M01_L38
M01_L42:
       mov       rcx,rbx
       call      qword ptr [7FFC037DF1E0]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M01_L45
M01_L43:
       mov       r8d,r8d
       add       r8,r8
       call      qword ptr [7FFC03665818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L44:
       mov       [rbx+18],r14d
M01_L45:
       mov       ecx,[rbx+18]
       mov       edx,ecx
       mov       rax,[rbx+8]
       mov       r8d,[rax+8]
       cmp       r8d,edx
       jbe       near ptr M01_L109
       cmp       edx,r8d
       jae       near ptr M01_L111
       mov       word ptr [rax+rdx*2+10],20
       inc       ecx
       mov       [rbx+18],ecx
M01_L46:
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
M01_L47:
       mov       edx,51EB851F
       mov       eax,edx
       imul      dword ptr [rbp+10]
       mov       esi,edx
       shr       esi,1F
       sar       edx,5
       add       esi,edx
       test      esi,esi
       jg        near ptr M01_L50
M01_L48:
       cmp       dword ptr [rbp+10],0
       jle       near ptr M01_L94
       mov       rbx,[rbp-38]
       mov       eax,[rbx+1C]
       add       eax,[rbx+18]
       test      eax,eax
       jg        near ptr M01_L83
M01_L49:
       cmp       dword ptr [rbp+10],14
       jl        near ptr M01_L93
       mov       edx,66666667
       mov       eax,edx
       imul      dword ptr [rbp+10]
       mov       eax,edx
       shr       eax,1F
       sar       edx,2
       add       eax,edx
       mov       rdx,1228E401DD0
       mov       r8,[rdx]
       cmp       eax,0A
       jae       near ptr M01_L111
       mov       edx,66666667
       mov       eax,edx
       imul      dword ptr [rbp+10]
       mov       ecx,edx
       shr       ecx,1F
       sar       edx,2
       add       ecx,edx
       mov       rcx,[r8+rcx*8+10]
       test      rcx,rcx
       je        near ptr M01_L88
       lea       rdx,[rcx+0C]
       mov       esi,[rcx+8]
       test      esi,esi
       je        near ptr M01_L88
       mov       rdi,[rbx+8]
       mov       r14d,[rbx+18]
       lea       ecx,[r14+rsi]
       cmp       ecx,[rdi+8]
       ja        near ptr M01_L85
       movsxd    r8,r14d
       lea       rcx,[rdi+r8*2+10]
       cmp       esi,2
       jg        near ptr M01_L86
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       esi,2
       jne       near ptr M01_L87
       movzx     eax,word ptr [rdx+2]
       mov       [rcx+2],ax
       jmp       near ptr M01_L87
M01_L50:
       mov       rcx,1228E401DC8
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0
       jne       near ptr M01_L110
       mov       rcx,[rcx+18]
M01_L51:
       mov       rax,offset MT_Microsoft.Extensions.ObjectPool.DefaultObjectPool<System.Text.StringBuilder>
       cmp       [rcx],rax
       jne       near ptr M01_L112
       cmp       [rcx],ecx
       call      qword ptr [7FFC03C2BF18]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Get()
       mov       rdi,rax
M01_L52:
       mov       [rbp-68],rdi
       mov       edx,431BDE83
       mov       eax,edx
       imul      esi
       mov       eax,edx
       shr       eax,1F
       sar       edx,12
       add       eax,edx
       test      eax,eax
       jg        near ptr M01_L66
M01_L53:
       mov       edx,10624DD3
       mov       eax,edx
       imul      esi
       mov       r14d,edx
       shr       r14d,1F
       sar       edx,6
       add       r14d,edx
       test      r14d,r14d
       jle       short M01_L54
       mov       ecx,r14d
       call      qword ptr [7FFC03C76820]
       mov       rdx,rax
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFC037DF228]; System.Text.StringBuilder.Append(System.String)
       mov       rcx,rax
       mov       edx,20
       cmp       [rcx],ecx
       call      qword ptr [7FFC037DF180]; System.Text.StringBuilder.Append(Char)
       mov       r15,rax
       call      qword ptr [7FFC03C768B0]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Thousand()
       mov       rdx,rax
       mov       rcx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFC037DF228]; System.Text.StringBuilder.Append(System.String)
       mov       rcx,rax
       mov       edx,20
       cmp       [rcx],ecx
       call      qword ptr [7FFC037DF180]; System.Text.StringBuilder.Append(Char)
       imul      eax,r14d,3E8
       sub       esi,eax
M01_L54:
       mov       edx,51EB851F
       mov       eax,edx
       imul      esi
       mov       r14d,edx
       shr       r14d,1F
       sar       edx,5
       add       r14d,edx
       test      r14d,r14d
       jg        near ptr M01_L63
M01_L55:
       test      esi,esi
       jle       near ptr M01_L59
       mov       eax,[rdi+1C]
       add       eax,[rdi+18]
       test      eax,eax
       jg        near ptr M01_L64
M01_L56:
       cmp       esi,14
       jl        near ptr M01_L65
       mov       edx,66666667
       mov       eax,edx
       imul      esi
       mov       r14d,edx
       shr       r14d,1F
       sar       edx,2
       add       r14d,edx
       mov       r8,1228E401DD0
       mov       r8,[r8]
       cmp       r14d,0A
       jae       near ptr M01_L70
       mov       edx,r14d
       mov       rdx,[r8+rdx*8+10]
       test      rdx,rdx
       je        short M01_L57
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,rdi
       call      qword ptr [7FFC037DF150]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M01_L57:
       lea       ecx,[r14+r14*4]
       add       ecx,ecx
       sub       esi,ecx
       test      esi,esi
       jle       short M01_L59
       mov       ecx,[rdi+18]
       mov       edx,ecx
       mov       rax,[rdi+8]
       mov       r8d,[rax+8]
       cmp       r8d,edx
       jbe       near ptr M01_L67
       cmp       edx,r8d
       jae       near ptr M01_L70
       mov       word ptr [rax+rdx*2+10],2D
       inc       ecx
       mov       [rdi+18],ecx
M01_L58:
       mov       r8,1228E401DD8
       mov       r14,[r8]
       cmp       esi,14
       jae       near ptr M01_L70
       mov       r8d,esi
       mov       rdx,[r14+r8*8+10]
       test      rdx,rdx
       je        short M01_L59
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,rdi
       call      qword ptr [7FFC037DF150]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M01_L59:
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFC03852200]; System.Text.StringBuilder.ToString()
       mov       r14,rax
       cmp       dword ptr [r14+8],0
       je        short M01_L61
       movzx     ecx,word ptr [r14+0C]
       cmp       ecx,100
       jge       near ptr M01_L68
       cmp       ecx,100
       jae       near ptr M01_L70
       mov       rax,7FFC5F9F6BF0
       test      byte ptr [rax+rcx],80
       jne       near ptr M01_L71
M01_L60:
       mov       ecx,[r14+8]
       dec       ecx
       cmp       ecx,[r14+8]
       jae       near ptr M01_L70
       mov       ecx,[r14+8]
       dec       ecx
       movzx     ecx,word ptr [r14+rcx*2+0C]
       cmp       ecx,100
       jge       near ptr M01_L69
       cmp       ecx,100
       jae       near ptr M01_L70
       mov       rax,7FFC5F9F6BF0
       test      byte ptr [rax+rcx],80
       jne       near ptr M01_L71
M01_L61:
       mov       r8,r14
M01_L62:
       mov       [rbp-70],r8
       jmp       near ptr M01_L72
M01_L63:
       mov       ecx,r14d
       call      qword ptr [7FFC03C76820]
       mov       rdx,rax
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFC037DF228]; System.Text.StringBuilder.Append(System.String)
       mov       rcx,rax
       mov       edx,20
       cmp       [rcx],ecx
       call      qword ptr [7FFC037DF180]; System.Text.StringBuilder.Append(Char)
       mov       r15,rax
       call      qword ptr [7FFC03C768C8]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Hundred()
       mov       rdx,rax
       mov       rcx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFC037DF228]; System.Text.StringBuilder.Append(System.String)
       mov       rcx,rax
       mov       edx,20
       cmp       [rcx],ecx
       call      qword ptr [7FFC037DF180]; System.Text.StringBuilder.Append(Char)
       imul      eax,r14d,64
       sub       esi,eax
       jmp       near ptr M01_L55
M01_L64:
       call      qword ptr [7FFC03C768F8]; DotNetTips.Spargine.Extensions.Properties.Resources.get_AndLowerCase()
       mov       rdx,rax
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFC037DF228]; System.Text.StringBuilder.Append(System.String)
       mov       rcx,rax
       mov       edx,20
       cmp       [rcx],ecx
       call      qword ptr [7FFC037DF180]; System.Text.StringBuilder.Append(Char)
       jmp       near ptr M01_L56
M01_L65:
       mov       rdx,1228E401DD8
       mov       r14,[rdx]
       cmp       esi,14
       jae       near ptr M01_L70
       mov       edx,esi
       mov       rdx,[r14+rdx*8+10]
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFC037DF228]; System.Text.StringBuilder.Append(System.String)
       jmp       near ptr M01_L59
M01_L66:
       mov       edx,431BDE83
       mov       eax,edx
       imul      esi
       mov       ecx,edx
       shr       ecx,1F
       sar       edx,12
       add       ecx,edx
       call      qword ptr [7FFC03C76820]
       mov       rdx,rax
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFC037DF228]; System.Text.StringBuilder.Append(System.String)
       mov       rcx,rax
       mov       edx,20
       cmp       [rcx],ecx
       call      qword ptr [7FFC037DF180]; System.Text.StringBuilder.Append(Char)
       mov       r14,rax
       call      qword ptr [7FFC03C76898]
       mov       rdx,rax
       mov       rcx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFC037DF228]; System.Text.StringBuilder.Append(System.String)
       mov       rcx,rax
       mov       edx,20
       cmp       [rcx],ecx
       call      qword ptr [7FFC037DF180]; System.Text.StringBuilder.Append(Char)
       mov       edx,431BDE83
       mov       eax,edx
       imul      esi
       mov       eax,edx
       shr       eax,1F
       sar       edx,12
       add       eax,edx
       imul      eax,0F4240
       sub       esi,eax
       jmp       near ptr M01_L53
M01_L67:
       mov       rcx,rdi
       mov       edx,2D
       call      qword ptr [7FFC037DF3A8]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M01_L58
M01_L68:
       call      qword ptr [7FFC03C7F738]
       test      eax,eax
       jne       short M01_L71
       jmp       near ptr M01_L60
M01_L69:
       call      qword ptr [7FFC03C7F738]
       test      eax,eax
       jne       short M01_L71
       jmp       near ptr M01_L61
M01_L70:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M01_L71:
       mov       rcx,r14
       mov       edx,3
       call      qword ptr [7FFC03C7F750]
       mov       r8,rax
       jmp       near ptr M01_L62
M01_L72:
       call      M01_L150
       nop
       mov       r8,[rbp-70]
       mov       rbx,[rbp-38]
       cmp       [rbx],bl
       test      r8,r8
       je        short M01_L75
       lea       rdx,[r8+0C]
       mov       esi,[r8+8]
       test      esi,esi
       je        short M01_L75
       mov       rdi,[rbx+8]
       mov       r14d,[rbx+18]
       lea       ecx,[r14+rsi]
       cmp       ecx,[rdi+8]
       jbe       short M01_L73
       mov       rcx,rbx
       mov       r8d,esi
       call      qword ptr [7FFC037DF1E0]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M01_L75
M01_L73:
       movsxd    r8,r14d
       lea       rcx,[rdi+r8*2+10]
       cmp       esi,2
       jle       near ptr M01_L77
       mov       r8d,esi
       add       r8,r8
       call      qword ptr [7FFC03665818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L74:
       add       esi,r14d
       mov       [rbx+18],esi
M01_L75:
       mov       ecx,[rbx+18]
       mov       rdx,[rbx+8]
       cmp       [rdx+8],ecx
       jbe       near ptr M01_L113
       cmp       ecx,[rdx+8]
       jae       near ptr M01_L111
       mov       word ptr [rdx+rcx*2+10],20
       inc       dword ptr [rbx+18]
M01_L76:
       call      qword ptr [7FFC03C768C8]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Hundred()
       test      rax,rax
       je        short M01_L81
       lea       rdx,[rax+0C]
       mov       esi,[rax+8]
       test      esi,esi
       je        short M01_L81
       mov       rdi,[rbx+8]
       mov       r14d,[rbx+18]
       lea       ecx,[r14+rsi]
       cmp       ecx,[rdi+8]
       ja        short M01_L78
       movsxd    r8,r14d
       lea       rcx,[rdi+r8*2+10]
       cmp       esi,2
       jg        short M01_L79
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       esi,2
       jne       short M01_L80
       movzx     edx,word ptr [rdx+2]
       mov       [rcx+2],dx
       jmp       short M01_L80
M01_L77:
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       esi,2
       jne       short M01_L74
       movzx     edx,word ptr [rdx+2]
       mov       [rcx+2],dx
       jmp       near ptr M01_L74
M01_L78:
       mov       rcx,rbx
       mov       r8d,esi
       call      qword ptr [7FFC037DF1E0]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M01_L81
M01_L79:
       mov       r8d,esi
       add       r8,r8
       call      qword ptr [7FFC03665818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L80:
       add       esi,r14d
       mov       [rbx+18],esi
M01_L81:
       mov       ecx,[rbx+18]
       mov       rdx,[rbx+8]
       cmp       [rdx+8],ecx
       jbe       near ptr M01_L114
       cmp       ecx,[rdx+8]
       jae       near ptr M01_L111
       mov       word ptr [rdx+rcx*2+10],20
       inc       dword ptr [rbx+18]
M01_L82:
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
       jmp       near ptr M01_L48
M01_L83:
       call      qword ptr [7FFC03C768F8]; DotNetTips.Spargine.Extensions.Properties.Resources.get_AndLowerCase()
       mov       rdx,rax
       test      rdx,rdx
       je        short M01_L84
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,rbx
       call      qword ptr [7FFC037DF150]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M01_L84:
       mov       ecx,[rbx+18]
       mov       rdx,[rbx+8]
       cmp       [rdx+8],ecx
       jbe       near ptr M01_L115
       cmp       ecx,[rdx+8]
       jae       near ptr M01_L111
       mov       word ptr [rdx+rcx*2+10],20
       inc       dword ptr [rbx+18]
       jmp       near ptr M01_L49
M01_L85:
       mov       rcx,rbx
       mov       r8d,esi
       call      qword ptr [7FFC037DF1E0]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M01_L88
M01_L86:
       mov       r8d,esi
       add       r8,r8
       call      qword ptr [7FFC03665818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L87:
       add       esi,r14d
       mov       [rbx+18],esi
M01_L88:
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
       jle       near ptr M01_L94
       mov       ecx,[rbx+18]
       mov       rdx,[rbx+8]
       cmp       [rdx+8],ecx
       jbe       near ptr M01_L116
       cmp       ecx,[rdx+8]
       jae       near ptr M01_L111
       mov       word ptr [rdx+rcx*2+10],2D
       inc       dword ptr [rbx+18]
M01_L89:
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
       mov       rax,1228E401DD8
       mov       r14,[rax]
       cmp       edx,14
       jae       near ptr M01_L111
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
       je        near ptr M01_L94
       lea       rdx,[rcx+0C]
       mov       r14d,[rcx+8]
       test      r14d,r14d
       je        near ptr M01_L94
       mov       rsi,[rbx+8]
       mov       edi,[rbx+18]
       lea       ecx,[rdi+r14]
       cmp       ecx,[rsi+8]
       jbe       short M01_L90
       mov       rcx,rbx
       mov       r8d,r14d
       call      qword ptr [7FFC037DF1E0]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M01_L94
M01_L90:
       movsxd    r8,edi
       lea       rcx,[rsi+r8*2+10]
       cmp       r14d,2
       jle       short M01_L92
       mov       r8d,r14d
       add       r8,r8
       call      qword ptr [7FFC03665818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L91:
       add       edi,r14d
       mov       [rbx+18],edi
       jmp       short M01_L94
M01_L92:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       r14d,2
       jne       short M01_L91
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M01_L91
M01_L93:
       mov       r8,1228E401DD8
       mov       r14,[r8]
       cmp       dword ptr [rbp+10],14
       jae       near ptr M01_L111
       mov       r8d,[rbp+10]
       mov       rdx,[r14+r8*8+10]
       test      rdx,rdx
       je        short M01_L94
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,rbx
       call      qword ptr [7FFC037DF150]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       nop
M01_L94:
       mov       rbx,[rbp-38]
       mov       rcx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FFC03852200]; System.Text.StringBuilder.ToString()
       mov       r14,rax
       cmp       dword ptr [r14+8],0
       je        short M01_L96
       movzx     ecx,word ptr [r14+0C]
       cmp       ecx,100
       jge       near ptr M01_L117
       cmp       ecx,100
       jae       near ptr M01_L111
       mov       rax,7FFC5F9F6BF0
       test      byte ptr [rax+rcx],80
       jne       near ptr M01_L119
M01_L95:
       mov       ecx,[r14+8]
       dec       ecx
       cmp       ecx,[r14+8]
       jae       near ptr M01_L111
       mov       ecx,[r14+8]
       dec       ecx
       movzx     ecx,word ptr [r14+rcx*2+0C]
       cmp       ecx,100
       jge       near ptr M01_L118
       cmp       ecx,100
       jae       near ptr M01_L111
       mov       rax,7FFC5F9F6BF0
       test      byte ptr [rax+rcx],80
       jne       near ptr M01_L119
M01_L96:
       mov       rcx,r14
M01_L97:
       mov       [rbp-40],rcx
       jmp       near ptr M01_L120
M01_L98:
       mov       ecx,[rbp+10]
       imul      rsi,rcx,431BDE83
       shr       rsi,32
       mov       rcx,1228E401DC8
       mov       rcx,[rcx]
       call      qword ptr [7FFC039E4078]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].get_Value()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp-50],rax
       mov       ecx,esi
       imul      rcx,431BDE83
       shr       rcx,32
       test      ecx,ecx
       jle       short M01_L99
       mov       ecx,esi
       imul      rcx,431BDE83
       shr       rcx,32
       call      qword ptr [7FFC03C76820]
       mov       rdx,rax
       mov       rcx,[rbp-50]
       cmp       [rcx],ecx
       call      qword ptr [7FFC037DF228]; System.Text.StringBuilder.Append(System.String)
       mov       rcx,rax
       mov       edx,20
       cmp       [rcx],ecx
       call      qword ptr [7FFC037DF180]; System.Text.StringBuilder.Append(Char)
       mov       rdi,rax
       call      qword ptr [7FFC03C76898]
       mov       rdx,rax
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFC037DF228]; System.Text.StringBuilder.Append(System.String)
       mov       rcx,rax
       mov       edx,20
       cmp       [rcx],ecx
       call      qword ptr [7FFC037DF180]; System.Text.StringBuilder.Append(Char)
       mov       eax,esi
       imul      rax,431BDE83
       shr       rax,32
       imul      eax,0F4240
       sub       esi,eax
M01_L99:
       mov       edx,10624DD3
       mov       eax,edx
       imul      esi
       mov       eax,edx
       shr       eax,1F
       sar       edx,6
       add       eax,edx
       test      eax,eax
       jle       short M01_L100
       mov       edx,10624DD3
       mov       eax,edx
       imul      esi
       mov       ecx,edx
       shr       ecx,1F
       sar       edx,6
       add       ecx,edx
       call      qword ptr [7FFC03C76820]
       mov       rdx,rax
       mov       rcx,[rbp-50]
       cmp       [rcx],ecx
       call      qword ptr [7FFC037DF228]; System.Text.StringBuilder.Append(System.String)
       mov       rcx,rax
       mov       edx,20
       cmp       [rcx],ecx
       call      qword ptr [7FFC037DF180]; System.Text.StringBuilder.Append(Char)
       mov       rdi,rax
       call      qword ptr [7FFC03C768B0]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Thousand()
       mov       rdx,rax
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFC037DF228]; System.Text.StringBuilder.Append(System.String)
       mov       rcx,rax
       mov       edx,20
       cmp       [rcx],ecx
       call      qword ptr [7FFC037DF180]; System.Text.StringBuilder.Append(Char)
       mov       edx,10624DD3
       mov       eax,edx
       imul      esi
       mov       eax,edx
       shr       eax,1F
       sar       edx,6
       add       eax,edx
       imul      eax,3E8
       sub       esi,eax
M01_L100:
       mov       edx,51EB851F
       mov       eax,edx
       imul      esi
       mov       eax,edx
       shr       eax,1F
       sar       edx,5
       add       eax,edx
       test      eax,eax
       jle       short M01_L101
       mov       edx,51EB851F
       mov       eax,edx
       imul      esi
       mov       ecx,edx
       shr       ecx,1F
       sar       edx,5
       add       ecx,edx
       call      qword ptr [7FFC03C76820]
       mov       rdx,rax
       mov       rcx,[rbp-50]
       cmp       [rcx],ecx
       call      qword ptr [7FFC037DF228]; System.Text.StringBuilder.Append(System.String)
       mov       rcx,rax
       mov       edx,20
       cmp       [rcx],ecx
       call      qword ptr [7FFC037DF180]; System.Text.StringBuilder.Append(Char)
       mov       rdi,rax
       call      qword ptr [7FFC03C768C8]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Hundred()
       mov       rdx,rax
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFC037DF228]; System.Text.StringBuilder.Append(System.String)
       mov       rcx,rax
       mov       edx,20
       cmp       [rcx],ecx
       call      qword ptr [7FFC037DF180]; System.Text.StringBuilder.Append(Char)
       mov       edx,51EB851F
       mov       eax,edx
       imul      esi
       mov       eax,edx
       shr       eax,1F
       sar       edx,5
       add       eax,edx
       imul      eax,64
       sub       esi,eax
M01_L101:
       test      esi,esi
       jle       near ptr M01_L105
       mov       rcx,[rbp-50]
       mov       eax,[rcx+1C]
       add       eax,[rcx+18]
       test      eax,eax
       jle       short M01_L102
       call      qword ptr [7FFC03C768F8]; DotNetTips.Spargine.Extensions.Properties.Resources.get_AndLowerCase()
       mov       rdx,rax
       mov       rcx,[rbp-50]
       call      qword ptr [7FFC037DF228]; System.Text.StringBuilder.Append(System.String)
       mov       rcx,rax
       mov       edx,20
       cmp       [rcx],ecx
       call      qword ptr [7FFC037DF180]; System.Text.StringBuilder.Append(Char)
M01_L102:
       cmp       esi,14
       jge       short M01_L104
       mov       rdx,1228E401DD8
       mov       r14,[rdx]
       cmp       esi,14
       jae       short M01_L103
       mov       edx,esi
       mov       rdx,[r14+rdx*8+10]
       mov       rcx,[rbp-50]
       call      qword ptr [7FFC037DF228]; System.Text.StringBuilder.Append(System.String)
       jmp       near ptr M01_L105
M01_L103:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M01_L104:
       mov       edx,66666667
       mov       eax,edx
       imul      esi
       mov       eax,edx
       shr       eax,1F
       sar       edx,2
       add       eax,edx
       mov       rdx,1228E401DD0
       mov       rdi,[rdx]
       cmp       eax,0A
       jae       short M01_L103
       mov       edx,66666667
       mov       eax,edx
       imul      esi
       mov       eax,edx
       shr       eax,1F
       sar       edx,2
       add       edx,eax
       mov       rdx,[rdi+rdx*8+10]
       mov       rcx,[rbp-50]
       call      qword ptr [7FFC037DF228]; System.Text.StringBuilder.Append(System.String)
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
       jle       short M01_L105
       mov       rcx,[rbp-50]
       mov       edx,2D
       call      qword ptr [7FFC037DF180]; System.Text.StringBuilder.Append(Char)
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
       mov       rax,1228E401DD8
       mov       r14,[rax]
       cmp       edx,14
       jae       near ptr M01_L103
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
       call      qword ptr [7FFC037DF228]; System.Text.StringBuilder.Append(System.String)
M01_L105:
       mov       rcx,[rbp-50]
       cmp       [rcx],ecx
       call      qword ptr [7FFC03852200]; System.Text.StringBuilder.ToString()
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFC03A94960]; System.String.Trim()
       mov       rdi,rax
       mov       rcx,1228E401DC8
       mov       rcx,[rcx]
       call      qword ptr [7FFC039E4078]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].get_Value()
       mov       r14,rax
       mov       rcx,[rbp-50]
       xor       edx,edx
       call      qword ptr [7FFC03C0DD40]; System.Text.StringBuilder.set_Length(Int32)
       mov       rcx,r14
       mov       rdx,[rbp-50]
       mov       rax,[r14]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       rdx,rdi
       mov       rcx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FFC037DF228]; System.Text.StringBuilder.Append(System.String)
       mov       rcx,rax
       mov       edx,20
       cmp       [rcx],ecx
       call      qword ptr [7FFC037DF180]; System.Text.StringBuilder.Append(Char)
       mov       rbx,rax
       call      qword ptr [7FFC03C76898]
       mov       rdx,rax
       mov       rcx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FFC037DF228]; System.Text.StringBuilder.Append(System.String)
       mov       rcx,rax
       mov       edx,20
       cmp       [rcx],ecx
       call      qword ptr [7FFC037DF180]; System.Text.StringBuilder.Append(Char)
       mov       eax,[rbp+10]
       imul      rax,431BDE83
       shr       rax,32
       imul      eax,0F4240
       mov       edx,[rbp+10]
       sub       edx,eax
       mov       [rbp+10],edx
       jmp       near ptr M01_L05
M01_L106:
       call      qword ptr [7FFC039E40D8]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rcx,rax
       jmp       near ptr M01_L06
M01_L107:
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rsi,rax
       jmp       near ptr M01_L07
M01_L108:
       mov       rcx,rbx
       mov       edx,20
       call      qword ptr [7FFC037DF3A8]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M01_L40
M01_L109:
       mov       rcx,rbx
       mov       edx,20
       call      qword ptr [7FFC037DF3A8]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M01_L46
M01_L110:
       call      qword ptr [7FFC039E40D8]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rcx,rax
       jmp       near ptr M01_L51
M01_L111:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M01_L112:
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rdi,rax
       jmp       near ptr M01_L52
M01_L113:
       mov       rcx,rbx
       mov       edx,20
       call      qword ptr [7FFC037DF3A8]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M01_L76
M01_L114:
       mov       rcx,rbx
       mov       edx,20
       call      qword ptr [7FFC037DF3A8]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M01_L82
M01_L115:
       mov       rcx,rbx
       mov       edx,20
       call      qword ptr [7FFC037DF3A8]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M01_L49
M01_L116:
       mov       rcx,rbx
       mov       edx,2D
       call      qword ptr [7FFC037DF3A8]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M01_L89
M01_L117:
       call      qword ptr [7FFC03C7F738]
       test      eax,eax
       jne       short M01_L119
       jmp       near ptr M01_L95
M01_L118:
       call      qword ptr [7FFC03C7F738]
       test      eax,eax
       je        near ptr M01_L96
M01_L119:
       mov       rcx,r14
       mov       edx,3
       call      qword ptr [7FFC03C7F750]
       mov       rcx,rax
       jmp       near ptr M01_L97
M01_L120:
       call      M01_L158
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
M01_L121:
       mov       rsi,[rbx+18]
       mov       rdi,[rsi+18]
       lea       rdx,[rbp-30]
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFC03C0DC08]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       jne       short M01_L122
       cmp       qword ptr [rdi+10],0
       je        short M01_L123
       lea       rdx,[rbp-30]
       mov       rcx,rsi
       call      qword ptr [7FFC03C7F4B0]
       test      eax,eax
       je        short M01_L124
M01_L122:
       add       rbx,2C
       lock dec  dword ptr [rbx]
       jmp       near ptr M01_L02
M01_L123:
       xor       ecx,ecx
       mov       [rbp-30],rcx
M01_L124:
       mov       rax,[rbx+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       rbx,rax
       jmp       near ptr M01_L03
M01_L125:
       call      qword ptr [7FFC03C76838]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Zero()
       nop
       add       rsp,68
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L126:
       call      qword ptr [7FFC03C76850]
       mov       rbx,rax
       mov       ecx,1
       call      qword ptr [7FFC03666670]; System.String.FastAllocateString(IntPtr)
       mov       rsi,rax
       mov       word ptr [rsi+0C],20
       mov       ecx,[rbp+10]
       mov       edi,ecx
       neg       edi
       js        short M01_L128
       mov       r14d,edi
       test      r14d,r14d
       jne       short M01_L127
       call      qword ptr [7FFC03C76838]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Zero()
       mov       rdi,rax
       jmp       near ptr M01_L138
M01_L127:
       test      r14d,r14d
       jge       short M01_L130
       call      qword ptr [7FFC03C76850]
       mov       r14,rax
       mov       ecx,1
       call      qword ptr [7FFC03666670]; System.String.FastAllocateString(IntPtr)
       mov       r15,rax
       mov       word ptr [r15+0C],20
       mov       ecx,edi
       neg       ecx
       jns       short M01_L129
M01_L128:
       call      qword ptr [7FFC03C7FAE0]
       int       3
M01_L129:
       call      qword ptr [7FFC03C76820]
       mov       r8,rax
       mov       rdx,r15
       mov       rcx,r14
       call      qword ptr [7FFC03667828]; System.String.Concat(System.String, System.String, System.String)
       mov       rdi,rax
       jmp       near ptr M01_L138
M01_L130:
       mov       rcx,1228E401DC8
       mov       rcx,[rcx]
       call      qword ptr [7FFC039E4078]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].get_Value()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp-48],rax
       mov       ecx,r14d
       imul      rcx,431BDE83
       shr       rcx,32
       test      ecx,ecx
       jle       short M01_L131
       mov       ecx,edi
       imul      rcx,431BDE83
       shr       rcx,32
       call      qword ptr [7FFC03C76820]
       mov       rdx,rax
       mov       rcx,[rbp-48]
       cmp       [rcx],ecx
       call      qword ptr [7FFC037DF228]; System.Text.StringBuilder.Append(System.String)
       mov       rcx,rax
       mov       edx,20
       cmp       [rcx],ecx
       call      qword ptr [7FFC037DF180]; System.Text.StringBuilder.Append(Char)
       mov       r14,rax
       call      qword ptr [7FFC03C76898]
       mov       rdx,rax
       mov       rcx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFC037DF228]; System.Text.StringBuilder.Append(System.String)
       mov       rcx,rax
       mov       edx,20
       cmp       [rcx],ecx
       call      qword ptr [7FFC037DF180]; System.Text.StringBuilder.Append(Char)
       mov       eax,edi
       imul      rax,431BDE83
       shr       rax,32
       imul      eax,0F4240
       mov       r14d,edi
       sub       r14d,eax
M01_L131:
       mov       edx,10624DD3
       mov       eax,edx
       imul      r14d
       mov       eax,edx
       shr       eax,1F
       sar       edx,6
       add       eax,edx
       test      eax,eax
       jle       near ptr M01_L132
       mov       edx,10624DD3
       mov       eax,edx
       imul      r14d
       mov       ecx,edx
       shr       ecx,1F
       sar       edx,6
       add       ecx,edx
       call      qword ptr [7FFC03C76820]
       mov       rdx,rax
       mov       rcx,[rbp-48]
       cmp       [rcx],ecx
       call      qword ptr [7FFC037DF228]; System.Text.StringBuilder.Append(System.String)
       mov       rcx,rax
       mov       edx,20
       cmp       [rcx],ecx
       call      qword ptr [7FFC037DF180]; System.Text.StringBuilder.Append(Char)
       mov       rdi,rax
       call      qword ptr [7FFC03C768B0]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Thousand()
       mov       rdx,rax
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFC037DF228]; System.Text.StringBuilder.Append(System.String)
       mov       rcx,rax
       mov       edx,20
       cmp       [rcx],ecx
       call      qword ptr [7FFC037DF180]; System.Text.StringBuilder.Append(Char)
       mov       edx,10624DD3
       mov       eax,edx
       imul      r14d
       mov       eax,edx
       shr       eax,1F
       sar       edx,6
       add       eax,edx
       imul      eax,3E8
       sub       r14d,eax
M01_L132:
       mov       edx,51EB851F
       mov       eax,edx
       imul      r14d
       mov       eax,edx
       shr       eax,1F
       sar       edx,5
       add       eax,edx
       test      eax,eax
       jle       short M01_L133
       mov       edx,51EB851F
       mov       eax,edx
       imul      r14d
       mov       ecx,edx
       shr       ecx,1F
       sar       edx,5
       add       ecx,edx
       call      qword ptr [7FFC03C76820]
       mov       rdx,rax
       mov       rcx,[rbp-48]
       cmp       [rcx],ecx
       call      qword ptr [7FFC037DF228]; System.Text.StringBuilder.Append(System.String)
       mov       rcx,rax
       mov       edx,20
       cmp       [rcx],ecx
       call      qword ptr [7FFC037DF180]; System.Text.StringBuilder.Append(Char)
       mov       rdi,rax
       call      qword ptr [7FFC03C768C8]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Hundred()
       mov       rdx,rax
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFC037DF228]; System.Text.StringBuilder.Append(System.String)
       mov       rcx,rax
       mov       edx,20
       cmp       [rcx],ecx
       call      qword ptr [7FFC037DF180]; System.Text.StringBuilder.Append(Char)
       mov       edx,51EB851F
       mov       eax,edx
       imul      r14d
       mov       eax,edx
       shr       eax,1F
       sar       edx,5
       add       eax,edx
       imul      eax,64
       sub       r14d,eax
M01_L133:
       test      r14d,r14d
       jle       near ptr M01_L137
       mov       rcx,[rbp-48]
       mov       eax,[rcx+1C]
       add       eax,[rcx+18]
       test      eax,eax
       jle       short M01_L134
       call      qword ptr [7FFC03C768F8]; DotNetTips.Spargine.Extensions.Properties.Resources.get_AndLowerCase()
       mov       rdx,rax
       mov       rcx,[rbp-48]
       call      qword ptr [7FFC037DF228]; System.Text.StringBuilder.Append(System.String)
       mov       rcx,rax
       mov       edx,20
       cmp       [rcx],ecx
       call      qword ptr [7FFC037DF180]; System.Text.StringBuilder.Append(Char)
M01_L134:
       cmp       r14d,14
       jge       short M01_L136
       mov       rdx,1228E401DD8
       mov       r8,[rdx]
       mov       edx,r14d
       mov       rdx,[r8+rdx*8+10]
       mov       rcx,[rbp-48]
       call      qword ptr [7FFC037DF228]; System.Text.StringBuilder.Append(System.String)
       jmp       near ptr M01_L137
M01_L135:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M01_L136:
       mov       edx,0CCCCCCCD
       mov       eax,r14d
       imul      rdx,rax
       shr       rdx,23
       mov       rax,1228E401DD0
       mov       r8,[rax]
       cmp       edx,0A
       jae       short M01_L135
       mov       edx,0CCCCCCCD
       mov       eax,r14d
       imul      rdx,rax
       shr       rdx,23
       mov       edx,edx
       mov       rdx,[r8+rdx*8+10]
       mov       rcx,[rbp-48]
       call      qword ptr [7FFC037DF228]; System.Text.StringBuilder.Append(System.String)
       mov       ecx,0CCCCCCCD
       mov       edx,r14d
       imul      rcx,rdx
       shr       rcx,23
       lea       ecx,[rcx+rcx*4]
       add       ecx,ecx
       mov       edx,r14d
       sub       edx,ecx
       test      edx,edx
       jle       short M01_L137
       mov       rcx,[rbp-48]
       mov       edx,2D
       call      qword ptr [7FFC037DF180]; System.Text.StringBuilder.Append(Char)
       mov       rcx,rax
       mov       edx,0CCCCCCCD
       mov       eax,r14d
       imul      rdx,rax
       shr       rdx,23
       lea       edx,[rdx+rdx*4]
       add       edx,edx
       mov       eax,r14d
       sub       eax,edx
       mov       rdx,1228E401DD8
       mov       rdx,[rdx]
       mov       r8,rdx
       cmp       eax,14
       jae       near ptr M01_L135
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
       call      qword ptr [7FFC037DF228]; System.Text.StringBuilder.Append(System.String)
M01_L137:
       mov       rcx,[rbp-48]
       cmp       [rcx],ecx
       call      qword ptr [7FFC03852200]; System.Text.StringBuilder.ToString()
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFC03A94960]; System.String.Trim()
       mov       rdi,rax
       mov       rcx,1228E401DC8
       mov       rcx,[rcx]
       call      qword ptr [7FFC039E4078]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].get_Value()
       mov       r14,rax
       mov       rcx,[rbp-48]
       xor       edx,edx
       call      qword ptr [7FFC03C0DD40]; System.Text.StringBuilder.set_Length(Int32)
       mov       rcx,r14
       mov       rdx,[rbp-48]
       mov       rax,[r14]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
M01_L138:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       call      qword ptr [7FFC03667828]; System.String.Concat(System.String, System.String, System.String)
       nop
       add       rsp,68
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L139:
       call      qword ptr [7FFC039E40D8]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rbx,rax
       jmp       near ptr M01_L01
M01_L140:
       call      qword ptr [7FFC03C7F378]
       int       3
M01_L141:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rbx,rax
       jmp       near ptr M01_L04
       sub       rsp,28
       mov       rcx,1228E401DC8
       mov       rcx,[rcx]
       cmp       [rcx],ecx
       call      qword ptr [7FFC039E4078]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].get_Value()
       mov       rdi,rax
       mov       rcx,[rbp-50]
       cmp       [rcx],cl
       xor       edx,edx
       call      qword ptr [7FFC03C0DD40]; System.Text.StringBuilder.set_Length(Int32)
       mov       rcx,rdi
       mov       rdx,[rbp-50]
       mov       rax,[rdi]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       add       rsp,28
       ret
M01_L142:
       sub       rsp,28
       mov       rcx,1228E401DC8
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0
       je        short M01_L143
       call      qword ptr [7FFC039E40D8]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rbx,rax
       jmp       short M01_L144
M01_L143:
       mov       rbx,[rcx+18]
M01_L144:
       mov       rdx,[rbp-58]
       cmp       [rdx],dl
       mov       rcx,rdx
       xor       edx,edx
       call      qword ptr [7FFC03C0DD40]; System.Text.StringBuilder.set_Length(Int32)
       mov       rdx,offset MT_Microsoft.Extensions.ObjectPool.DefaultObjectPool<System.Text.StringBuilder>
       cmp       [rbx],rdx
       jne       near ptr M01_L148
       mov       rax,[rbx+10]
       mov       rdx,[rbp-58]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       test      eax,eax
       je        near ptr M01_L149
       cmp       qword ptr [rbx+20],0
       jne       short M01_L146
       lea       rcx,[rbx+20]
       test      rcx,rcx
       jne       short M01_L145
       call      qword ptr [7FFC03C7F378]
       int       3
M01_L145:
       mov       rdx,[rbp-58]
       xor       r8d,r8d
       call      00007FFC632821C0
       test      rax,rax
       je        short M01_L149
M01_L146:
       lea       rcx,[rbx+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[rbx+28]
       jg        short M01_L147
       mov       rbx,[rbx+18]
       mov       rcx,[rbx+10]
       mov       rdx,[rbp-58]
       cmp       [rcx],ecx
       call      qword ptr [7FFC03C76DC0]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryEnqueue(System.__Canon)
       test      eax,eax
       jne       short M01_L149
       mov       rcx,rbx
       mov       rdx,[rbp-58]
       call      qword ptr [7FFC03C7F7C8]
       jmp       short M01_L149
M01_L147:
       add       rbx,2C
       lock dec  dword ptr [rbx]
       jmp       short M01_L149
M01_L148:
       mov       rcx,rbx
       mov       rdx,[rbp-58]
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
M01_L149:
       nop
       add       rsp,28
       ret
M01_L150:
       sub       rsp,28
       mov       rcx,1228E401DC8
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0
       je        short M01_L151
       call      qword ptr [7FFC039E40D8]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rbx,rax
       jmp       short M01_L152
M01_L151:
       mov       rbx,[rcx+18]
M01_L152:
       mov       rdx,[rbp-68]
       cmp       [rdx],dl
       mov       rcx,rdx
       xor       edx,edx
       call      qword ptr [7FFC03C0DD40]; System.Text.StringBuilder.set_Length(Int32)
       mov       rdx,offset MT_Microsoft.Extensions.ObjectPool.DefaultObjectPool<System.Text.StringBuilder>
       cmp       [rbx],rdx
       jne       near ptr M01_L156
       mov       rax,[rbx+10]
       mov       rdx,[rbp-68]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       test      eax,eax
       je        near ptr M01_L157
       cmp       qword ptr [rbx+20],0
       jne       short M01_L154
       lea       rcx,[rbx+20]
       test      rcx,rcx
       jne       short M01_L153
       call      qword ptr [7FFC03C7F378]
       int       3
M01_L153:
       mov       rdx,[rbp-68]
       xor       r8d,r8d
       call      00007FFC632821C0
       test      rax,rax
       je        short M01_L157
M01_L154:
       lea       rcx,[rbx+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[rbx+28]
       jg        short M01_L155
       mov       rbx,[rbx+18]
       mov       rcx,[rbx+10]
       mov       rdx,[rbp-68]
       cmp       [rcx],ecx
       call      qword ptr [7FFC03C76DC0]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryEnqueue(System.__Canon)
       test      eax,eax
       jne       short M01_L157
       mov       rcx,rbx
       mov       rdx,[rbp-68]
       call      qword ptr [7FFC03C7F7C8]
       jmp       short M01_L157
M01_L155:
       add       rbx,2C
       lock dec  dword ptr [rbx]
       jmp       short M01_L157
M01_L156:
       mov       rcx,rbx
       mov       rdx,[rbp-68]
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
M01_L157:
       nop
       add       rsp,28
       ret
M01_L158:
       sub       rsp,28
       mov       rcx,1228E401DC8
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0
       je        short M01_L159
       call      qword ptr [7FFC039E40D8]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rbx,rax
       jmp       short M01_L160
M01_L159:
       mov       rbx,[rcx+18]
M01_L160:
       mov       rsi,[rbp-38]
       cmp       dword ptr [rsi+20],0
       jge       short M01_L161
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,3AD
       mov       rdx,7FFC035A4000
       call      qword ptr [7FFC03887798]
       mov       rbx,rax
       call      qword ptr [7FFC03C7F2E8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFC0388DA70]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M01_L161:
       cmp       qword ptr [rsi+10],0
       jne       short M01_L162
       xor       ecx,ecx
       mov       [rsi+18],rcx
       jmp       near ptr M01_L169
M01_L162:
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       mov       r8d,ecx
       neg       r8d
       test      r8d,r8d
       jle       short M01_L163
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFC03C7F300]
       jmp       near ptr M01_L169
M01_L163:
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFC03C7F318]
       mov       rdi,rax
       cmp       rdi,rsi
       je        near ptr M01_L168
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
       jge       short M01_L166
       cmp       ecx,400
       jge       short M01_L164
       movsxd    rdx,ecx
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
       jmp       short M01_L165
M01_L164:
       xor       edx,edx
       call      qword ptr [7FFC03C07438]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       r14,rax
M01_L165:
       mov       rcx,[rdi+8]
       mov       r8d,[rdi+18]
       mov       rdx,r14
       call      qword ptr [7FFC037D5050]; System.Array.Copy(System.Array, System.Array, Int32)
       lea       rcx,[rsi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M01_L167
M01_L166:
       mov       rdx,[rdi+8]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
M01_L167:
       mov       rdx,[rdi+10]
       lea       rcx,[rsi+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rdi+1C]
       mov       [rsi+1C],ecx
M01_L168:
       mov       ecx,[rdi+1C]
       neg       ecx
       mov       [rsi+18],ecx
M01_L169:
       mov       rdx,offset MT_Microsoft.Extensions.ObjectPool.DefaultObjectPool<System.Text.StringBuilder>
       cmp       [rbx],rdx
       jne       short M01_L173
       mov       rax,[rbx+10]
       mov       rdx,rsi
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       test      eax,eax
       je        short M01_L174
       cmp       qword ptr [rbx+20],0
       jne       short M01_L171
       lea       rcx,[rbx+20]
       test      rcx,rcx
       jne       short M01_L170
       call      qword ptr [7FFC03C7F378]
       int       3
M01_L170:
       mov       rdx,rsi
       xor       r8d,r8d
       call      00007FFC632821C0
       test      rax,rax
       je        short M01_L174
M01_L171:
       lea       rcx,[rbx+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[rbx+28]
       jg        short M01_L172
       mov       rbx,[rbx+18]
       mov       rcx,[rbx+10]
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFC03C76DC0]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryEnqueue(System.__Canon)
       test      eax,eax
       jne       short M01_L174
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFC03C7F7C8]
       jmp       short M01_L174
M01_L172:
       add       rbx,2C
       lock dec  dword ptr [rbx]
       jmp       short M01_L174
M01_L173:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
M01_L174:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       mov       rcx,1228E401DC8
       mov       rcx,[rcx]
       cmp       [rcx],ecx
       call      qword ptr [7FFC039E4078]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].get_Value()
       mov       rdi,rax
       mov       rcx,[rbp-48]
       cmp       [rcx],cl
       xor       edx,edx
       call      qword ptr [7FFC03C0DD40]; System.Text.StringBuilder.set_Length(Int32)
       mov       rcx,rdi
       mov       rdx,[rbp-48]
       mov       rax,[rdi]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       add       rsp,28
       ret
; Total bytes of code 7424
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
       jmp       qword ptr [7FFC036666E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 336
```
```assembly
; DotNetTips.Spargine.Extensions.Properties.Resources.get_Thousand()
;                 return ResourceManager.GetString("Thousand", resourceCulture);
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,28
       call      qword ptr [7FFC03C76CA0]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,122A4400188
       mov       r8,[r8]
       mov       rdx,163233B1230
       mov       rax,[rax]
       mov       rax,[rax+48]
       add       rsp,28
       jmp       qword ptr [rax+28]
; Total bytes of code 51
```
```assembly
; System.Text.StringBuilder.Append(Char ByRef, Int32)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       test      r8d,r8d
       je        short M04_L01
       mov       rcx,[rbx+8]
       mov       eax,[rbx+18]
       lea       esi,[rax+r8]
       cmp       esi,[rcx+8]
       ja        short M04_L03
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jle       short M04_L02
       mov       r8d,r8d
       add       r8,r8
       call      qword ptr [7FFC03665818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M04_L00:
       mov       [rbx+18],esi
M04_L01:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L02:
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       jne       short M04_L00
       movzx     edx,word ptr [rdx+2]
       mov       [rcx+2],dx
       jmp       short M04_L00
M04_L03:
       mov       rcx,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFC037DF1E0]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       je        short M05_L02
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFC632D52E0
       mov       rsi,rax
M05_L00:
       mov       r8d,[rbx+18]
       test      r8d,r8d
       jle       short M05_L01
       mov       rdx,[rbx+8]
       mov       ecx,[rbx+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rsi+8]
       ja        short M05_L03
       cmp       [rdx+8],r8d
       jb        short M05_L03
       movsxd    rcx,ecx
       lea       rcx,[rsi+rcx*2+0C]
       movsxd    r8,r8d
       add       r8,r8
       add       rdx,10
       call      qword ptr [7FFC03665818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M05_L01:
       mov       rbx,[rbx+10]
       test      rbx,rbx
       jne       short M05_L00
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M05_L02:
       mov       rax,163233A0008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M05_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,19655
       mov       rdx,7FFC035A4000
       call      qword ptr [7FFC03887798]
       mov       rbx,rax
       call      qword ptr [7FFC03C7F4C8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFC0388DA70]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 201
```
```assembly
; System.Char.IsWhiteSpace(Char)
       movzx     ecx,cx
       cmp       ecx,100
       jge       short M06_L00
       mov       eax,ecx
       mov       rcx,7FFC5F9F6BF0
       test      byte ptr [rcx+rax],80
       setne     al
       movzx     eax,al
       ret
M06_L00:
       jmp       qword ptr [7FFC03C7F738]
; Total bytes of code 40
```
```assembly
; DotNetTips.Spargine.Extensions.Properties.Resources.get_Hundred()
;                 return ResourceManager.GetString("Hundred", resourceCulture);
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,28
       call      qword ptr [7FFC03C76CA0]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,122A4400188
       mov       r8,[r8]
       mov       rdx,163233B1258
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
       call      qword ptr [7FFC03C76CA0]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,122A4400188
       mov       r8,[r8]
       mov       rdx,163233B1280
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
       call      qword ptr [7FFC037DF1E0]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M09_L02
M09_L00:
       movsxd    r8,ebp
       lea       rcx,[rdi+r8*2+10]
       cmp       esi,2
       jle       short M09_L03
       mov       r8d,esi
       add       r8,r8
       mov       rdx,rax
       call      qword ptr [7FFC03665818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFC037DF3A8]; System.Text.StringBuilder.AppendWithExpansion(Char)
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
       jg        near ptr M11_L04
       cmp       eax,esi
       jl        near ptr M11_L04
       mov       rax,[rbx+8]
       mov       ebp,[rax+8]
       sub       ebp,ecx
       test      ebp,ebp
       jg        near ptr M11_L05
M11_L00:
       sub       esi,ebp
       mov       ecx,[rbx+1C]
       lea       edx,[rsi+rcx]
       mov       eax,[rbx+18]
       add       edx,eax
       cmp       edx,[rbx+20]
       jg        near ptr M11_L10
       cmp       edx,esi
       jl        near ptr M11_L10
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
       jl        near ptr M11_L11
       cmp       eax,400
       jl        short M11_L01
       mov       ecx,eax
       xor       edx,edx
       call      qword ptr [7FFC03C07438]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       r14,rax
       jmp       short M11_L02
M11_L01:
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
M11_L02:
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
M11_L03:
       cmp       esi,r8d
       ja        near ptr M11_L13
       mov       r8d,esi
       add       r8,r8
       call      qword ptr [7FFC03665818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       [rbx+18],esi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M11_L04:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,19685
       mov       rdx,7FFC035A4000
       call      qword ptr [7FFC03887798]
       mov       rsi,rax
       call      qword ptr [7FFC03D05998]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFC0388DA70]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M11_L05:
       mov       rax,[rbx+8]
       test      rax,rax
       jne       short M11_L06
       test      ecx,ecx
       jne       short M11_L07
       xor       edx,edx
       xor       eax,eax
       jmp       short M11_L09
M11_L06:
       cmp       [rax+8],ecx
       jae       short M11_L08
M11_L07:
       call      qword ptr [7FFC037D7198]
       int       3
M11_L08:
       mov       edx,ecx
       lea       rdx,[rax+rdx*2+10]
       mov       eax,[rax+8]
       sub       eax,ecx
M11_L09:
       cmp       ebp,eax
       ja        near ptr M11_L13
       mov       r8d,ebp
       add       r8,r8
       mov       rcx,rdx
       mov       rdx,rdi
       call      qword ptr [7FFC03665818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
       jmp       near ptr M11_L00
M11_L10:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,1969B
       mov       rdx,7FFC035A4000
       call      qword ptr [7FFC03887798]
       mov       rsi,rax
       call      qword ptr [7FFC03C7F2E8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFC0388DA70]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M11_L11:
       mov       rcx,offset MT_System.OutOfMemoryException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC03D059B0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M11_L12:
       xor       ecx,ecx
       xor       r8d,r8d
       jmp       near ptr M11_L03
M11_L13:
       call      qword ptr [7FFC03A9D0C8]
       int       3
; Total bytes of code 619
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
       call      qword ptr [7FFC606837D8]; Precode of System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFC60668FD8]
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
       jmp       qword ptr [7FFC039E40D8]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
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
       mov       rdx,7FFC035A4000
       call      qword ptr [7FFC03887798]
       mov       rdx,rax
       mov       ecx,esi
       call      qword ptr [7FFC03C7F288]
       int       3
M14_L02:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FFC035A4000
       call      qword ptr [7FFC03887798]
       mov       rsi,rax
       call      qword ptr [7FFC03C7F2E8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFC0388DA70]
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
       call      qword ptr [7FFC03C7F300]
       jmp       near ptr M14_L00
M14_L04:
       mov       rcx,rbx
       mov       edx,esi
       call      qword ptr [7FFC03C7F318]
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
       call      qword ptr [7FFC03C07438]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       rbp,rax
M14_L06:
       mov       rcx,[rdi+8]
       mov       r8d,[rdi+18]
       mov       rdx,rbp
       call      qword ptr [7FFC037D5050]; System.Array.Copy(System.Array, System.Array, Int32)
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
       mov       rdx,7FFC035A4000
       call      qword ptr [7FFC03887798]
       mov       rsi,rax
       call      qword ptr [7FFC03C7F2E8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFC0388DA70]
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
       call      qword ptr [7FFC03C7F300]
       jmp       near ptr M15_L00
M15_L06:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFC03C7F318]
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
       call      qword ptr [7FFC03C07438]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       rbp,rax
M15_L08:
       mov       rcx,[rdi+8]
       mov       r8d,[rdi+18]
       mov       rdx,rbp
       call      qword ptr [7FFC037D5050]; System.Array.Copy(System.Array, System.Array, Int32)
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
       call      qword ptr [7FFC03C7F378]
       int       3
M15_L15:
       mov       rdx,rbx
       xor       r8d,r8d
       call      00007FFC632821C0
       test      rax,rax
       je        near ptr M15_L03
       jmp       near ptr M15_L01
M15_L16:
       test      r10d,r10d
       jge       near ptr M15_L02
       mov       rdx,rbx
       call      qword ptr [7FFC03C7F7C8]
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
       call      qword ptr [7FFC03C7F840]
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
       call      qword ptr [7FFC03C76CA0]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       mov       rax,122A4400188
       mov       r8,[rax]
       mov       rdx,163233B0E40
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
       jmp       near ptr 00007FFC632D52E0
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
       mov       rdi,rdx
       mov       rsi,r8
       test      rbx,rbx
       je        near ptr M20_L02
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        near ptr M20_L02
       test      rdi,rdi
       je        near ptr M20_L01
       mov       r14d,[rdi+8]
       test      r14d,r14d
       je        near ptr M20_L01
       test      rsi,rsi
       je        near ptr M20_L00
       cmp       dword ptr [rsi+8],0
       je        near ptr M20_L00
       mov       r15d,ebp
       mov       ecx,r14d
       add       rcx,r15
       mov       eax,[rsi+8]
       add       rcx,rax
       cmp       rcx,7FFFFFFF
       jg        near ptr M20_L03
       movsxd    rcx,ecx
       call      qword ptr [7FFC6067B9F0]; Precode of System.String.FastAllocateString(IntPtr)
       mov       r13,rax
       cmp       [r13],r13b
       lea       r12,[r13+0C]
       mov       rcx,r12
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFC6067D928]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       lea       rcx,[r12+r15*2]
       mov       r8d,r14d
       add       r8,r8
       lea       rdx,[rdi+0C]
       call      qword ptr [7FFC6067D928]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       ebp,r14d
       movsxd    rcx,ebp
       lea       rcx,[r12+rcx*2]
       mov       r8d,[rsi+8]
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFC6067D928]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r13
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
M20_L01:
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
M20_L02:
       mov       rdx,rsi
       mov       rcx,rdi
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
       call      qword ptr [7FFC6067F488]
       int       3
; Total bytes of code 323
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
       call      qword ptr [7FFC6068E1B0]; Precode of System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ExecutionAndPublication(System.LazyHelper, Boolean)
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
       call      qword ptr [7FFC60684C78]
       int       3
       mov       rcx,rbx
       call      qword ptr [7FFC6068E1A0]
       jmp       short M21_L01
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFC6068E1A8]; Precode of System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ViaFactory(System.Threading.LazyThreadSafetyMode)
       jmp       short M21_L01
       mov       rcx,[rbx]
       call      qword ptr [7FFC6066B838]
       mov       rcx,rax
       call      qword ptr [7FFC60672EA0]
       mov       rcx,rax
       call      qword ptr [7FFC60694008]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFC6068E1B8]
       jmp       near ptr M21_L01
       mov       rax,[rbx+10]
       test      rax,rax
       je        short M21_L05
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFC6068E1B8]
       jmp       near ptr M21_L01
M21_L05:
       mov       rcx,rbx
       call      qword ptr [7FFC6068E1C8]
       jmp       near ptr M21_L01
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,1
       call      qword ptr [7FFC6068E1B0]; Precode of System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ExecutionAndPublication(System.LazyHelper, Boolean)
       jmp       near ptr M21_L01
; Total bytes of code 269
```

