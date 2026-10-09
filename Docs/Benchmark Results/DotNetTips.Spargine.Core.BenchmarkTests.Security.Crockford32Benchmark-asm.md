## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Security.Crockford32Benchmark.Decode()
       sub       rsp,28
       mov       rcx,[rcx+1B0]
       call      qword ptr [7FFD577AE100]; DotNetTips.Spargine.Core.Security.Crockford32.Decode(System.String)
       mov       eax,[rax+8]
       add       rsp,28
       ret
; Total bytes of code 25
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
       sub       rsp,78
       lea       rbp,[rsp+20]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp+10],ymm4
       vmovdqa   xmmword ptr [rbp+30],xmm4
       xor       eax,eax
       mov       [rbp+40],rax
       mov       rax,0B42689629C1C
       mov       [rbp+8],rax
       mov       rbx,rcx
; 		if (string.IsNullOrWhiteSpace(text))
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,rbx
       call      qword ptr [7FFD577A5590]; System.String.IsNullOrWhiteSpace(System.String)
       test      eax,eax
       jne       near ptr M01_L12
; 		Span<char> norm = stackalloc char[text.Length];
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       esi,[rbx+8]
       mov       eax,esi
       mov       ecx,2
       mul       rcx
       jb        near ptr M01_L27
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
       mov       [rbp+10],rdi
       mov       [rbp+18],esi
       lea       rdx,[rbp+10]
       mov       rcx,rbx
       call      qword ptr [7FFD577AE178]; DotNetTips.Spargine.Core.Security.Crockford32.NormalizeChars(System.String, System.Span`1<Char>)
       mov       ebx,eax
; 		int buffer = 0, bitsLeft = 0;
; 		^^^^^^^^^^^^^^
       xor       r14d,r14d
       xor       r15d,r15d
       imul      r13d,ebx,5
       jo        near ptr M01_L27
       sar       r13d,3
       movsxd    rdx,r13d
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r12,rax
; 		var byteIndex = 0;
; 		^^^^^^^^^^^^^^^^^^
       xor       eax,eax
       mov       [rbp+54],eax
; 		for (var index = 0; index < nc; index++)
; 		     ^^^^^^^^^^^^^
       xor       edx,edx
       test      ebx,ebx
       jle       near ptr M01_L14
       cmp       ebx,esi
       jg        near ptr M01_L10
       jmp       short M01_L05
; 			var v = c < 128 ? Map[c] : -1;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M01_L02:
       mov       r8d,0FFFFFFFF
; 			if (v < 0)
; 			^^^^^^^^^^
M01_L03:
       test      r8d,r8d
       jl        near ptr M01_L19
; 			buffer = (buffer << 5) | v;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^
       shl       r14d,5
       or        r14d,r8d
; 			bitsLeft += 5;
; 			^^^^^^^^^^^^^^
       add       r15d,5
       jo        near ptr M01_L27
; 			if (bitsLeft >= 8)
; 			^^^^^^^^^^^^^^^^^^
       cmp       r15d,8
       jl        short M01_L04
; 				bytes[byteIndex++] = (byte)((buffer >> (bitsLeft - 8)) & 0xFF);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       eax,[rbp+54]
       mov       r8d,eax
       add       r8d,1
       jo        near ptr M01_L27
       mov       [rbp+54],r8d
       sub       r15d,8
       jo        near ptr M01_L27
       sarx      ecx,r14d,r15d
       movzx     r8d,cl
       cmp       eax,r13d
       jae       near ptr M01_L26
       mov       ecx,eax
       mov       [r12+rcx+10],r8b
M01_L04:
       mov       edx,[rbp+50]
       add       edx,1
       jo        near ptr M01_L27
       cmp       edx,ebx
       jge       near ptr M01_L14
; 			var c = norm[index];
; 			^^^^^^^^^^^^^^^^^^^^
M01_L05:
       mov       [rbp+50],edx
       mov       ecx,edx
       movzx     esi,word ptr [rdi+rcx*2]
       cmp       esi,80
       jge       near ptr M01_L02
       test      byte ptr [7FFD57582248],1
       je        near ptr M01_L16
M01_L06:
       mov       rcx,2ADE7801EB0
       mov       r8,[rcx]
       cmp       esi,[r8+8]
       jae       near ptr M01_L26
       mov       ecx,esi
       movsx     r8,byte ptr [r8+rcx+10]
       jmp       near ptr M01_L03
M01_L07:
       mov       r8d,0FFFFFFFF
       mov       r10d,[rbp+4C]
M01_L08:
       test      r8d,r8d
       jl        near ptr M01_L18
       shl       r14d,5
       or        r14d,r8d
       add       r15d,5
       jo        near ptr M01_L27
       cmp       r15d,8
       jl        short M01_L09
       mov       eax,[rbp+54]
       mov       ecx,eax
       add       ecx,1
       jo        near ptr M01_L27
       sub       r15d,8
       jo        near ptr M01_L27
       sarx      r8d,r14d,r15d
       movzx     r8d,r8b
       cmp       eax,r13d
       jae       near ptr M01_L26
       mov       [r12+rax+10],r8b
; 				bitsLeft -= 8;
; 				^^^^^^^^^^^^^^
       mov       [rbp+54],ecx
M01_L09:
       mov       edx,[rbp+50]
       add       edx,1
       jo        near ptr M01_L27
       cmp       edx,ebx
       jge       near ptr M01_L14
M01_L10:
       cmp       edx,esi
       jae       near ptr M01_L26
       mov       [rbp+50],edx
       mov       ecx,edx
       movzx     ecx,word ptr [rdi+rcx*2]
       mov       r10d,ecx
       mov       [rbp+4C],r10d
       cmp       r10d,80
       jge       near ptr M01_L07
       test      byte ptr [7FFD57582248],1
       je        near ptr M01_L17
M01_L11:
       mov       rcx,2ADE7801EB0
       mov       r8,[rcx]
       mov       r10d,[rbp+4C]
       cmp       r10d,[r8+8]
       jae       near ptr M01_L26
       mov       ecx,r10d
       movsx     r8,byte ptr [r8+rcx+10]
       jmp       near ptr M01_L08
; 			return [];
; 			^^^^^^^^^^
M01_L12:
       mov       rax,2EE7C9562A0
       mov       r8,0B42689629C1C
       cmp       [rbp+8],r8
       je        short M01_L13
       call      CORINFO_HELP_FAIL_FAST
M01_L13:
       nop
       vzeroupper
       lea       rsp,[rbp+58]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; 		return bytes;
; 		^^^^^^^^^^^^^
M01_L14:
       mov       rax,r12
       mov       r8,0B42689629C1C
       cmp       [rbp+8],r8
       je        short M01_L15
       call      CORINFO_HELP_FAIL_FAST
M01_L15:
       nop
       vzeroupper
       lea       rsp,[rbp+58]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L16:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Security.Crockford32
       call      qword ptr [7FFD57195728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M01_L06
M01_L17:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Security.Crockford32
       call      qword ptr [7FFD57195728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M01_L11
M01_L18:
       mov       esi,r10d
; 				throw new FormatException($"Invalid Base32 character '{c}'.");
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M01_L19:
       lea       rcx,[rbp+20]
       mov       edx,1C
       mov       r8d,1
       call      qword ptr [7FFD573B4E70]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler..ctor(Int32, Int32)
       mov       ecx,[rbp+30]
       cmp       ecx,[rbp+40]
       ja        short M01_L22
       mov       rdx,[rbp+38]
       mov       eax,ecx
       lea       rdx,[rdx+rax*2]
       mov       eax,[rbp+40]
       sub       eax,ecx
       cmp       eax,1A
       jb        short M01_L20
       vmovups   ymm0,[7FFD5722AD80]
       vmovups   [rdx],ymm0
       vmovups   xmm0,[7FFD5722ADA0]
       vmovups   [rdx+20],xmm0
       mov       dword ptr [rdx+30],270020
       mov       ecx,[rbp+30]
       add       ecx,1A
       mov       [rbp+30],ecx
       jmp       short M01_L21
M01_L20:
       lea       rcx,[rbp+20]
       mov       rdx,2EE7C960BC8
       call      qword ptr [7FFD577A7B10]
M01_L21:
       lea       rcx,[rbp+20]
       mov       edx,esi
       call      qword ptr [7FFD577A5C98]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       mov       ecx,[rbp+30]
       cmp       ecx,[rbp+40]
       jbe       short M01_L23
M01_L22:
       call      qword ptr [7FFD57307198]
       int       3
M01_L23:
       mov       rdx,[rbp+38]
       mov       eax,ecx
       lea       rdx,[rdx+rax*2]
       mov       eax,[rbp+40]
       sub       eax,ecx
       cmp       eax,2
       jb        short M01_L24
       mov       dword ptr [rdx],2E0027
       mov       ecx,[rbp+30]
       add       ecx,2
       mov       [rbp+30],ecx
       jmp       short M01_L25
M01_L24:
       lea       rcx,[rbp+20]
       mov       rdx,2EE7C960C18
       call      qword ptr [7FFD577A7B10]
M01_L25:
       mov       rcx,offset MT_System.FormatException
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       lea       rcx,[rbp+20]
       call      qword ptr [7FFD573B4EA0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       mov       rdx,rax
       mov       rcx,r12
       call      qword ptr [7FFD577AE190]
       mov       rcx,r12
       call      CORINFO_HELP_THROW
       int       3
M01_L26:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M01_L27:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 1005
```

