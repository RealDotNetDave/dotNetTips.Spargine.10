## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Security.Crockford32Benchmark.Decode()
       mov       rcx,[rcx+1A0]
       jmp       qword ptr [7FF8AC04E508]; DotNetTips.Spargine.Core.Security.Crockford32.Decode(System.String)
; Total bytes of code 13
```
```assembly
; DotNetTips.Spargine.Core.Security.Crockford32.Decode(System.String)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,68
       lea       rbp,[rsp+20]
       xor       eax,eax
       mov       [rbp+8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp+10],ymm4
       vmovdqa   xmmword ptr [rbp+30],xmm4
       mov       rax,28FB5EB976E7
       mov       [rbp],rax
       mov       rbx,rcx
; 		if (string.IsNullOrWhiteSpace(text))
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,rbx
       call      qword ptr [7FF8AC045968]; System.String.IsNullOrWhiteSpace(System.String)
       test      eax,eax
       jne       near ptr M01_L10
; 		Span<char> norm = stackalloc char[text.Length];
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       esi,[rbx+8]
       mov       eax,esi
       mov       ecx,2
       mul       rcx
       jb        near ptr M01_L21
       mov       rdi,rax
       test      rdi,rdi
       je        short M01_L01
       add       rdi,0F
       shr       rdi,4
       add       rsp,20
M01_L00:
       push      0
       push      0
       dec       rdi
       jne       short M01_L00
       sub       rsp,20
       lea       rdi,[rsp+20]
; 		var nc = NormalizeChars(text, norm);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M01_L01:
       mov       [rbp+8],rdi
       mov       [rbp+10],esi
       lea       rdx,[rbp+8]
       mov       rcx,rbx
       call      qword ptr [7FF8AC04E580]; DotNetTips.Spargine.Core.Security.Crockford32.NormalizeChars(System.String, System.Span`1<Char>)
       mov       ebx,eax
; 		int buffer = 0, bitsLeft = 0;
; 		^^^^^^^^^^^^^^
       xor       r14d,r14d
       xor       r15d,r15d
; 		var bytes = new List<byte>((int)Math.Floor(nc * 5 / 8.0));
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,offset MT_System.Collections.Generic.List<System.Byte>
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       imul      eax,ebx,5
       jo        near ptr M01_L21
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,eax
       vmulsd    xmm0,xmm0,qword ptr [7FF8ABABD900]
       vroundsd  xmm0,xmm0,xmm0,9
       call      qword ptr [7FF8ABA25938]; System.Math.ConvertToInt32Checked(Double)
       mov       edx,eax
       mov       rcx,r13
       call      qword ptr [7FF8AC04E598]; System.Collections.Generic.List`1[[System.Byte, System.Private.CoreLib]]..ctor(Int32)
; 		for (var index = 0; index < nc; index++)
; 		     ^^^^^^^^^^^^^
       xor       r12d,r12d
       cmp       r12d,ebx
       jl        short M01_L08
; 		return [.. bytes];
; 		^^^^^^^^^^^^^^^^^^
M01_L02:
       mov       rcx,r13
       call      qword ptr [7FF8AC04E5E0]; System.Collections.Generic.List`1[[System.Byte, System.Private.CoreLib]].ToArray()
       mov       r8,28FB5EB976E7
       cmp       [rbp],r8
       je        short M01_L03
       call      CORINFO_HELP_FAIL_FAST
M01_L03:
       nop
       vzeroupper
       lea       rsp,[rbp+48]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; 			var v = c < 128 ? Map[c] : -1;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M01_L04:
       test      byte ptr [7FF8ABDFD368],1
       je        near ptr M01_L12
M01_L05:
       mov       rcx,1D960C01EB0
       mov       rcx,[rcx]
       mov       eax,[rbp+44]
       cmp       eax,[rcx+8]
       jae       near ptr M01_L20
       mov       edx,eax
       movsx     rdx,byte ptr [rcx+rdx+10]
       jmp       short M01_L09
; 				bytes.Add((byte)((buffer >> (bitsLeft - 8)) & 0xFF));
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M01_L06:
       mov       rcx,r13
       call      qword ptr [7FF8AC04E5B0]
; 				bitsLeft -= 8;
; 				^^^^^^^^^^^^^^
M01_L07:
       add       r12d,1
       jo        near ptr M01_L21
       cmp       r12d,ebx
       jge       short M01_L02
; 			var c = norm[index];
; 			^^^^^^^^^^^^^^^^^^^^
M01_L08:
       cmp       r12d,esi
       jae       near ptr M01_L20
       movzx     eax,word ptr [rdi+r12*2]
       mov       [rbp+44],eax
       cmp       eax,80
       jl        short M01_L04
       mov       edx,0FFFFFFFF
; 			if (v < 0)
; 			^^^^^^^^^^
M01_L09:
       test      edx,edx
       jl        near ptr M01_L13
; 			buffer = (buffer << 5) | v;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^
       shl       r14d,5
       or        r14d,edx
; 			bitsLeft += 5;
; 			^^^^^^^^^^^^^^
       add       r15d,5
       jo        near ptr M01_L21
; 			if (bitsLeft >= 8)
; 			^^^^^^^^^^^^^^^^^^
       cmp       r15d,8
       jl        short M01_L07
       sub       r15d,8
       jo        near ptr M01_L21
       sarx      ecx,r14d,r15d
       movzx     edx,cl
       inc       dword ptr [r13+14]
       mov       rcx,[r13+8]
       mov       eax,[r13+10]
       mov       r8d,[rcx+8]
       cmp       r8d,eax
       jbe       short M01_L06
       lea       r8d,[rax+1]
       mov       [r13+10],r8d
       mov       eax,eax
       mov       [rcx+rax+10],dl
       jmp       near ptr M01_L07
; 			return [];
; 			^^^^^^^^^^
M01_L10:
       mov       rax,219F5D162A0
       mov       r8,28FB5EB976E7
       cmp       [rbp],r8
       je        short M01_L11
       call      CORINFO_HELP_FAIL_FAST
M01_L11:
       nop
       vzeroupper
       lea       rsp,[rbp+48]
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
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Security.Crockford32
       call      qword ptr [7FF8ABA25728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M01_L05
; 				throw new FormatException($"Invalid Base32 character '{c}'.");
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M01_L13:
       lea       rcx,[rbp+18]
       mov       edx,1C
       mov       r8d,1
       call      qword ptr [7FF8ABC44E70]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler..ctor(Int32, Int32)
       mov       ecx,[rbp+28]
       cmp       ecx,[rbp+38]
       ja        short M01_L16
       mov       rdx,[rbp+30]
       mov       eax,ecx
       lea       rdx,[rdx+rax*2]
       mov       eax,[rbp+38]
       sub       eax,ecx
       cmp       eax,1A
       jb        short M01_L14
       vmovups   ymm0,[7FF8ABABD920]
       vmovups   [rdx],ymm0
       vmovups   xmm0,[7FF8ABABD940]
       vmovups   [rdx+20],xmm0
       mov       dword ptr [rdx+30],270020
       mov       ecx,[rbp+28]
       add       ecx,1A
       mov       [rbp+28],ecx
       jmp       short M01_L15
M01_L14:
       lea       rcx,[rbp+18]
       mov       rdx,219F5D20AF8
       call      qword ptr [7FF8AC047F00]
M01_L15:
       lea       rcx,[rbp+18]
       mov       edx,[rbp+44]
       call      qword ptr [7FF8AC0460D0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       mov       ecx,[rbp+28]
       cmp       ecx,[rbp+38]
       jbe       short M01_L17
M01_L16:
       call      qword ptr [7FF8ABB97198]
       int       3
M01_L17:
       mov       rdx,[rbp+30]
       mov       eax,ecx
       lea       rdx,[rdx+rax*2]
       mov       eax,[rbp+38]
       sub       eax,ecx
       cmp       eax,2
       jb        short M01_L18
       mov       dword ptr [rdx],2E0027
       mov       ecx,[rbp+28]
       add       ecx,2
       mov       [rbp+28],ecx
       jmp       short M01_L19
M01_L18:
       lea       rcx,[rbp+18]
       mov       rdx,219F5D20B48
       call      qword ptr [7FF8AC047F00]
M01_L19:
       mov       rcx,offset MT_System.FormatException
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       lea       rcx,[rbp+18]
       call      qword ptr [7FF8ABC44EA0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       mov       rdx,rax
       mov       rcx,r13
       call      qword ptr [7FF8AC04E5C8]
       mov       rcx,r13
       call      CORINFO_HELP_THROW
       int       3
M01_L20:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M01_L21:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 806
```

