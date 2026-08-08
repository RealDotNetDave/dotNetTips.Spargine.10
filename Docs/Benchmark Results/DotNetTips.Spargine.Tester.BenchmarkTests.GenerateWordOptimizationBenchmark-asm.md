## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.GenerateWordOptimizationBenchmark.GenerateWordMinMaxChar()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       ecx,[rbx+1A0]
       mov       edx,61
       mov       r8d,7A
       call      qword ptr [7FFB37325500]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
       mov       rbx,[rbx+198]
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 62
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
; 		length = length.ArgumentInRange(min: 1, defaultValue: 1);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var range = maxCharacter - minCharacter + 1;
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		if (length <= stackAllocThreshold)
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Span<byte> randomBytes = stackalloc byte[length];
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Span<char> chars = stackalloc char[length];
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			RandomNumberGenerator.Fill(randomBytes);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			FillWordChars(chars, randomBytes, minCharacter, range);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			return new string(chars);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var rentedBytes = ArrayPool<byte>.Shared.Rent(length);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var rentedChars = ArrayPool<char>.Shared.Rent(length);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			RandomNumberGenerator.Fill(rentedBytes.AsSpan(0, length));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			FillWordChars(rentedChars.AsSpan(0, length), rentedBytes.AsSpan(0, length), minCharacter, range);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			return new string(rentedChars, 0, length);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 	}
; 	^
; 			ArrayPool<byte>.Shared.Return(rentedBytes);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			ArrayPool<char>.Shared.Return(rentedChars);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       sub       rsp,0C8
       vzeroupper
       lea       rbp,[rsp+20]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp+30],ymm4
       vmovdqu   ymmword ptr [rbp+50],ymm4
       vmovdqu   ymmword ptr [rbp+70],ymm4
       vmovdqa   xmmword ptr [rbp+90],xmm4
       xor       eax,eax
       mov       [rbp+0A0],rax
       mov       rax,39BF540D1751
       mov       [rbp+8],rax
       mov       ebx,ecx
       mov       esi,edx
       mov       edi,r8d
       lea       rcx,[rbp+50]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       r14,rax
       mov       rcx,rsp
       mov       [rbp+68],rcx
       mov       rcx,rbp
       mov       [rbp+78],rcx
       mov       byte ptr [rbp+0A0],1
       mov       dword ptr [rbp+0A4],1
       test      ebx,ebx
       setg      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M01_L13
M01_L00:
       mov       r15d,ebx
       movzx     edi,di
       movzx     esi,si
       sub       edi,esi
       jo        near ptr M01_L25
       add       edi,1
       jo        near ptr M01_L25
       cmp       r15d,100
       jg        near ptr M01_L18
       mov       eax,ebx
       mov       r15,rax
       test      r15,r15
       je        short M01_L02
       add       r15,0F
       shr       r15,4
       add       rsp,20
M01_L01:
       push      0
       push      0
       dec       r15
       jne       short M01_L01
       sub       rsp,20
       lea       r15,[rsp+20]
M01_L02:
       test      ebx,ebx
       jl        near ptr M01_L16
       mov       [rbp+18],r15
       mov       eax,ebx
       mov       r8d,2
       mul       r8
       jb        near ptr M01_L25
       mov       r13,rax
       test      r13,r13
       je        short M01_L04
       add       r13,0F
       shr       r13,4
       add       rsp,20
M01_L03:
       push      0
       push      0
       dec       r13
       jne       short M01_L03
       sub       rsp,20
       lea       r13,[rsp+20]
M01_L04:
       mov       [rbp+10],r13
       test      ebx,ebx
       jle       short M01_L07
       mov       rdx,r15
       mov       [rbp+88],rdx
       mov       r8d,ebx
       xor       ecx,ecx
       mov       r9d,2
       mov       rax,7FFB3713F360
       mov       [rbp+60],rax
       lea       rax,[M01_L05]
       mov       [rbp+70],rax
       lea       rax,[rbp+50]
       mov       [r14+8],rax
       mov       byte ptr [r14+4],0
       mov       rax,7FFBCD483670
       call      rax
M01_L05:
       mov       byte ptr [r14+4],1
       cmp       dword ptr [7FFB96C64A90],0
       je        short M01_L06
       call      qword ptr [7FFB96C52648]; CORINFO_HELP_STOP_FOR_GC
M01_L06:
       mov       rcx,[rbp+58]
       mov       [r14+8],rcx
       test      eax,eax
       jne       near ptr M01_L17
       xor       eax,eax
       mov       [rbp+88],rax
       mov       r15,[rbp+18]
M01_L07:
       xor       eax,eax
       mov       [rbp+88],rax
       xor       ecx,ecx
       test      ebx,ebx
       jle       short M01_L09
M01_L08:
       mov       r8d,ecx
       movzx     eax,byte ptr [r15+r8]
       cdq
       idiv      edi
       add       edx,esi
       jo        near ptr M01_L25
       cmp       edx,0FFFF
       ja        near ptr M01_L25
       mov       eax,edx
       mov       r13,[rbp+10]
       mov       [r13+r8*2],ax
       add       ecx,1
       jo        near ptr M01_L25
       cmp       ecx,ebx
       jge       short M01_L10
       jmp       short M01_L08
M01_L09:
       mov       r13,[rbp+10]
M01_L10:
       mov       [rbp+30],r13
       mov       [rbp+38],ebx
       lea       rcx,[rbp+30]
       call      System.String.Ctor(System.ReadOnlySpan`1<Char>)
M01_L11:
       mov       r8,39BF540D1751
       cmp       [rbp+8],r8
       je        short M01_L12
       call      CORINFO_HELP_FAIL_FAST
M01_L12:
       nop
       lea       rsp,[rbp+0A8]
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
       movzx     ecx,byte ptr [rbp+0A0]
       test      cl,cl
       je        short M01_L14
       lea       rcx,[rbp+0A0]
       call      qword ptr [7FFB37324420]
       mov       ebx,eax
       jmp       near ptr M01_L00
M01_L14:
       call      qword ptr [7FFB37324438]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L15
       call      qword ptr [7FFB373AD140]
       mov       rbx,rax
M01_L15:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,27945462FC0
       call      qword ptr [7FFB36F8E598]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M01_L16:
       call      qword ptr [7FFB36ECF210]
       int       3
M01_L17:
       mov       ecx,eax
       call      qword ptr [7FFB373A7E58]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M01_L18:
       mov       rcx,offset MT_System.Buffers.ArrayPool<System.Byte>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,238B0401E68
       mov       rcx,[rcx]
       mov       edx,r15d
       cmp       [rcx],ecx
       call      qword ptr [7FFB37336D38]
       mov       [rbp+28],rax
       mov       rcx,238B0400C88
       mov       rcx,[rcx]
       mov       edx,r15d
       call      qword ptr [7FFB36FBFAC8]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
       mov       [rbp+20],rax
       cmp       qword ptr [rbp+28],0
       je        short M01_L19
       mov       r8,[rbp+28]
       cmp       [r8+8],r15d
       jb        short M01_L19
       lea       rcx,[r8+10]
       mov       eax,r15d
       mov       [rbp+40],rcx
       mov       [rbp+48],eax
       lea       rcx,[rbp+40]
       call      qword ptr [7FFB371259E0]; System.Security.Cryptography.RandomNumberGeneratorImplementation.FillSpan(System.Span`1<Byte>)
       cmp       qword ptr [rbp+20],0
       je        short M01_L19
       mov       rax,[rbp+20]
       cmp       [rax+8],r15d
       jb        short M01_L19
       lea       rbx,[rax+10]
       mov       r14d,r15d
       mov       r8,[rbp+28]
       cmp       [r8+8],r15d
       jae       short M01_L20
M01_L19:
       call      qword ptr [7FFB36ECF210]
       int       3
M01_L20:
       lea       rdx,[r8+10]
       mov       ecx,r15d
       mov       [rbp+40],rdx
       mov       [rbp+48],ecx
       lea       rdx,[rbp+40]
       lea       rcx,[rbp+90]
       call      qword ptr [7FFB3712D4D0]; System.Span`1[[System.Byte, System.Private.CoreLib]].op_Implicit(System.Span`1<Byte>)
       mov       rcx,[rbp+90]
       mov       r8d,[rbp+98]
       xor       r10d,r10d
       jmp       short M01_L24
M01_L21:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M01_L22:
       call      CORINFO_HELP_OVERFLOW
       int       3
M01_L23:
       cmp       r10d,r8d
       jae       short M01_L21
       movzx     eax,byte ptr [rcx+r10]
       cdq
       idiv      edi
       add       edx,esi
       jo        short M01_L22
       cmp       edx,0FFFF
       ja        short M01_L22
       mov       [rbx+r10*2],dx
       add       r10d,1
       jo        short M01_L22
M01_L24:
       cmp       r10d,r14d
       jl        short M01_L23
       mov       rcx,[rbp+20]
       mov       r8d,r15d
       xor       edx,edx
       call      00007FFB36CF1548
       mov       rbx,rax
       mov       rcx,offset MT_System.Buffers.ArrayPool<System.Byte>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,238B0401E68
       mov       rcx,[rcx]
       mov       rdx,[rbp+28]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFB37336D40]
       mov       rcx,238B0400C88
       mov       rcx,[rcx]
       mov       rdx,[rbp+20]
       xor       r8d,r8d
       call      qword ptr [7FFB36FBFAD0]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
       mov       rax,rbx
       jmp       near ptr M01_L11
M01_L25:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       vzeroupper
       test      byte ptr [7FFB37336A70],1
       jne       short M01_L26
       mov       rcx,offset MT_System.Buffers.ArrayPool<System.Byte>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
M01_L26:
       mov       rcx,238B0401E68
       mov       rcx,[rcx]
       mov       rdx,[rbp+28]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFB37336D40]
       mov       rcx,238B0400C88
       mov       rcx,[rcx]
       mov       rdx,[rbp+20]
       xor       r8d,r8d
       call      qword ptr [7FFB36FBFAD0]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
       nop
       add       rsp,28
       ret
; Total bytes of code 1124
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.GenerateWordOptimizationBenchmark.GenerateWordMinMaxChar()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       ecx,[rbx+1A0]
       mov       edx,61
       mov       r8d,7A
       call      qword ptr [7FFB37344D50]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
       mov       rbx,[rbx+198]
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 62
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
; 		length = length.ArgumentInRange(min: 1, defaultValue: 1);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var range = maxCharacter - minCharacter + 1;
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		if (length <= stackAllocThreshold)
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Span<byte> randomBytes = stackalloc byte[length];
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Span<char> chars = stackalloc char[length];
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			RandomNumberGenerator.Fill(randomBytes);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			FillWordChars(chars, randomBytes, minCharacter, range);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			return new string(chars);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var rentedBytes = ArrayPool<byte>.Shared.Rent(length);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var rentedChars = ArrayPool<char>.Shared.Rent(length);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			RandomNumberGenerator.Fill(rentedBytes.AsSpan(0, length));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			FillWordChars(rentedChars.AsSpan(0, length), rentedBytes.AsSpan(0, length), minCharacter, range);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			return new string(rentedChars, 0, length);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 	}
; 	^
; 			ArrayPool<byte>.Shared.Return(rentedBytes);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			ArrayPool<char>.Shared.Return(rentedChars);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       sub       rsp,0C8
       vzeroupper
       lea       rbp,[rsp+20]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp+30],ymm4
       vmovdqu   ymmword ptr [rbp+50],ymm4
       vmovdqu   ymmword ptr [rbp+70],ymm4
       vmovdqa   xmmword ptr [rbp+90],xmm4
       xor       eax,eax
       mov       [rbp+0A0],rax
       mov       rax,0FC17875EF332
       mov       [rbp+8],rax
       mov       ebx,ecx
       mov       esi,edx
       mov       edi,r8d
       lea       rcx,[rbp+50]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       r14,rax
       mov       rcx,rsp
       mov       [rbp+68],rcx
       mov       rcx,rbp
       mov       [rbp+78],rcx
       mov       byte ptr [rbp+0A0],1
       mov       dword ptr [rbp+0A4],1
       test      ebx,ebx
       setg      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M01_L13
M01_L00:
       mov       r15d,ebx
       movzx     edi,di
       movzx     esi,si
       sub       edi,esi
       jo        near ptr M01_L25
       add       edi,1
       jo        near ptr M01_L25
       cmp       r15d,100
       jg        near ptr M01_L18
       mov       eax,ebx
       mov       r15,rax
       test      r15,r15
       je        short M01_L02
       add       r15,0F
       shr       r15,4
       add       rsp,20
M01_L01:
       push      0
       push      0
       dec       r15
       jne       short M01_L01
       sub       rsp,20
       lea       r15,[rsp+20]
M01_L02:
       test      ebx,ebx
       jl        near ptr M01_L16
       mov       [rbp+18],r15
       mov       eax,ebx
       mov       r8d,2
       mul       r8
       jb        near ptr M01_L25
       mov       r13,rax
       test      r13,r13
       je        short M01_L04
       add       r13,0F
       shr       r13,4
       add       rsp,20
M01_L03:
       push      0
       push      0
       dec       r13
       jne       short M01_L03
       sub       rsp,20
       lea       r13,[rsp+20]
M01_L04:
       mov       [rbp+10],r13
       test      ebx,ebx
       jle       short M01_L07
       mov       rdx,r15
       mov       [rbp+88],rdx
       mov       r8d,ebx
       xor       ecx,ecx
       mov       r9d,2
       mov       rax,7FFB3714F360
       mov       [rbp+60],rax
       lea       rax,[M01_L05]
       mov       [rbp+70],rax
       lea       rax,[rbp+50]
       mov       [r14+8],rax
       mov       byte ptr [r14+4],0
       mov       rax,7FFBCD483670
       call      rax
M01_L05:
       mov       byte ptr [r14+4],1
       cmp       dword ptr [7FFB96C64A90],0
       je        short M01_L06
       call      qword ptr [7FFB96C52648]; CORINFO_HELP_STOP_FOR_GC
M01_L06:
       mov       rcx,[rbp+58]
       mov       [r14+8],rcx
       test      eax,eax
       jne       near ptr M01_L17
       xor       eax,eax
       mov       [rbp+88],rax
       mov       r15,[rbp+18]
M01_L07:
       xor       eax,eax
       mov       [rbp+88],rax
       xor       ecx,ecx
       test      ebx,ebx
       jle       short M01_L09
M01_L08:
       mov       r8d,ecx
       movzx     eax,byte ptr [r15+r8]
       cdq
       idiv      edi
       add       edx,esi
       jo        near ptr M01_L25
       cmp       edx,0FFFF
       ja        near ptr M01_L25
       mov       eax,edx
       mov       r13,[rbp+10]
       mov       [r13+r8*2],ax
       add       ecx,1
       jo        near ptr M01_L25
       cmp       ecx,ebx
       jge       short M01_L10
       jmp       short M01_L08
M01_L09:
       mov       r13,[rbp+10]
M01_L10:
       mov       [rbp+30],r13
       mov       [rbp+38],ebx
       lea       rcx,[rbp+30]
       call      System.String.Ctor(System.ReadOnlySpan`1<Char>)
M01_L11:
       mov       r8,0FC17875EF332
       cmp       [rbp+8],r8
       je        short M01_L12
       call      CORINFO_HELP_FAIL_FAST
M01_L12:
       nop
       lea       rsp,[rbp+0A8]
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
       movzx     ecx,byte ptr [rbp+0A0]
       test      cl,cl
       je        short M01_L14
       lea       rcx,[rbp+0A0]
       call      qword ptr [7FFB372AFCA8]
       mov       ebx,eax
       jmp       near ptr M01_L00
M01_L14:
       call      qword ptr [7FFB372AFCC0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L15
       call      qword ptr [7FFB373C6388]
       mov       rbx,rax
M01_L15:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,22D79E42FC0
       call      qword ptr [7FFB36FAD9C8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M01_L16:
       call      qword ptr [7FFB36EEF210]
       int       3
M01_L17:
       mov       ecx,eax
       call      qword ptr [7FFB373C4B28]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M01_L18:
       mov       rcx,offset MT_System.Buffers.ArrayPool<System.Byte>
       call      qword ptr [7FFB36D15728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1ECE5001E50
       mov       rcx,[rcx]
       mov       edx,r15d
       cmp       [rcx],ecx
       call      qword ptr [7FFB37351AD0]
       mov       [rbp+28],rax
       mov       rcx,1ECE5000C88
       mov       rcx,[rcx]
       mov       edx,r15d
       call      qword ptr [7FFB36FDFAC8]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
       mov       [rbp+20],rax
       cmp       qword ptr [rbp+28],0
       je        short M01_L19
       mov       r8,[rbp+28]
       cmp       [r8+8],r15d
       jb        short M01_L19
       lea       rcx,[r8+10]
       mov       eax,r15d
       mov       [rbp+40],rcx
       mov       [rbp+48],eax
       lea       rcx,[rbp+40]
       call      qword ptr [7FFB37134E10]; System.Security.Cryptography.RandomNumberGeneratorImplementation.FillSpan(System.Span`1<Byte>)
       cmp       qword ptr [rbp+20],0
       je        short M01_L19
       mov       rax,[rbp+20]
       cmp       [rax+8],r15d
       jb        short M01_L19
       lea       rbx,[rax+10]
       mov       r14d,r15d
       mov       r8,[rbp+28]
       cmp       [r8+8],r15d
       jae       short M01_L20
M01_L19:
       call      qword ptr [7FFB36EEF210]
       int       3
M01_L20:
       lea       rdx,[r8+10]
       mov       ecx,r15d
       mov       [rbp+40],rdx
       mov       [rbp+48],ecx
       lea       rdx,[rbp+40]
       lea       rcx,[rbp+90]
       call      qword ptr [7FFB3713C900]; System.Span`1[[System.Byte, System.Private.CoreLib]].op_Implicit(System.Span`1<Byte>)
       mov       rcx,[rbp+90]
       mov       r8d,[rbp+98]
       xor       r10d,r10d
       jmp       short M01_L24
M01_L21:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M01_L22:
       call      CORINFO_HELP_OVERFLOW
       int       3
M01_L23:
       cmp       r10d,r8d
       jae       short M01_L21
       movzx     eax,byte ptr [rcx+r10]
       cdq
       idiv      edi
       add       edx,esi
       jo        short M01_L22
       cmp       edx,0FFFF
       ja        short M01_L22
       mov       [rbx+r10*2],dx
       add       r10d,1
       jo        short M01_L22
M01_L24:
       cmp       r10d,r14d
       jl        short M01_L23
       mov       rcx,[rbp+20]
       mov       r8d,r15d
       xor       edx,edx
       call      00007FFB36D11548
       mov       rbx,rax
       mov       rcx,offset MT_System.Buffers.ArrayPool<System.Byte>
       call      qword ptr [7FFB36D15728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1ECE5001E50
       mov       rcx,[rcx]
       mov       rdx,[rbp+28]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFB37351AD8]
       mov       rcx,1ECE5000C88
       mov       rcx,[rcx]
       mov       rdx,[rbp+20]
       xor       r8d,r8d
       call      qword ptr [7FFB36FDFAD0]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
       mov       rax,rbx
       jmp       near ptr M01_L11
M01_L25:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       vzeroupper
       test      byte ptr [7FFB3731F9B8],1
       jne       short M01_L26
       mov       rcx,offset MT_System.Buffers.ArrayPool<System.Byte>
       call      qword ptr [7FFB36D15728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
M01_L26:
       mov       rcx,1ECE5001E50
       mov       rcx,[rcx]
       mov       rdx,[rbp+28]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFB37351AD8]
       mov       rcx,1ECE5000C88
       mov       rcx,[rcx]
       mov       rdx,[rbp+20]
       xor       r8d,r8d
       call      qword ptr [7FFB36FDFAD0]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
       nop
       add       rsp,28
       ret
; Total bytes of code 1127
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.GenerateWordOptimizationBenchmark.GenerateWordMinMaxChar()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       ecx,[rbx+1A0]
       mov       edx,61
       mov       r8d,7A
       call      qword ptr [7FFB37344D20]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
       mov       rbx,[rbx+198]
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 62
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
; 		length = length.ArgumentInRange(min: 1, defaultValue: 1);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var range = maxCharacter - minCharacter + 1;
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		if (length <= stackAllocThreshold)
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Span<byte> randomBytes = stackalloc byte[length];
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Span<char> chars = stackalloc char[length];
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			RandomNumberGenerator.Fill(randomBytes);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			FillWordChars(chars, randomBytes, minCharacter, range);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			return new string(chars);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var rentedBytes = ArrayPool<byte>.Shared.Rent(length);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var rentedChars = ArrayPool<char>.Shared.Rent(length);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			RandomNumberGenerator.Fill(rentedBytes.AsSpan(0, length));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			FillWordChars(rentedChars.AsSpan(0, length), rentedBytes.AsSpan(0, length), minCharacter, range);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			return new string(rentedChars, 0, length);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 	}
; 	^
; 			ArrayPool<byte>.Shared.Return(rentedBytes);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			ArrayPool<char>.Shared.Return(rentedChars);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       sub       rsp,0C8
       vzeroupper
       lea       rbp,[rsp+20]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp+30],ymm4
       vmovdqu   ymmword ptr [rbp+50],ymm4
       vmovdqu   ymmword ptr [rbp+70],ymm4
       vmovdqa   xmmword ptr [rbp+90],xmm4
       xor       eax,eax
       mov       [rbp+0A0],rax
       mov       rax,5FCB875EFAB2
       mov       [rbp+8],rax
       mov       ebx,ecx
       mov       esi,edx
       mov       edi,r8d
       lea       rcx,[rbp+50]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       r14,rax
       mov       rcx,rsp
       mov       [rbp+68],rcx
       mov       rcx,rbp
       mov       [rbp+78],rcx
       mov       byte ptr [rbp+0A0],1
       mov       dword ptr [rbp+0A4],1
       test      ebx,ebx
       setg      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M01_L13
M01_L00:
       mov       r15d,ebx
       movzx     edi,di
       movzx     esi,si
       sub       edi,esi
       jo        near ptr M01_L25
       add       edi,1
       jo        near ptr M01_L25
       cmp       r15d,100
       jg        near ptr M01_L18
       mov       eax,ebx
       mov       r15,rax
       test      r15,r15
       je        short M01_L02
       add       r15,0F
       shr       r15,4
       add       rsp,20
M01_L01:
       push      0
       push      0
       dec       r15
       jne       short M01_L01
       sub       rsp,20
       lea       r15,[rsp+20]
M01_L02:
       test      ebx,ebx
       jl        near ptr M01_L16
       mov       [rbp+18],r15
       mov       eax,ebx
       mov       r8d,2
       mul       r8
       jb        near ptr M01_L25
       mov       r13,rax
       test      r13,r13
       je        short M01_L04
       add       r13,0F
       shr       r13,4
       add       rsp,20
M01_L03:
       push      0
       push      0
       dec       r13
       jne       short M01_L03
       sub       rsp,20
       lea       r13,[rsp+20]
M01_L04:
       mov       [rbp+10],r13
       test      ebx,ebx
       jle       short M01_L07
       mov       rdx,r15
       mov       [rbp+88],rdx
       mov       r8d,ebx
       xor       ecx,ecx
       mov       r9d,2
       mov       rax,7FFB3714F360
       mov       [rbp+60],rax
       lea       rax,[M01_L05]
       mov       [rbp+70],rax
       lea       rax,[rbp+50]
       mov       [r14+8],rax
       mov       byte ptr [r14+4],0
       mov       rax,7FFBCD483670
       call      rax
M01_L05:
       mov       byte ptr [r14+4],1
       cmp       dword ptr [7FFB96C64A90],0
       je        short M01_L06
       call      qword ptr [7FFB96C52648]; CORINFO_HELP_STOP_FOR_GC
M01_L06:
       mov       rcx,[rbp+58]
       mov       [r14+8],rcx
       test      eax,eax
       jne       near ptr M01_L17
       xor       eax,eax
       mov       [rbp+88],rax
       mov       r15,[rbp+18]
M01_L07:
       xor       eax,eax
       mov       [rbp+88],rax
       xor       ecx,ecx
       test      ebx,ebx
       jle       short M01_L09
M01_L08:
       mov       r8d,ecx
       movzx     eax,byte ptr [r15+r8]
       cdq
       idiv      edi
       add       edx,esi
       jo        near ptr M01_L25
       cmp       edx,0FFFF
       ja        near ptr M01_L25
       mov       eax,edx
       mov       r13,[rbp+10]
       mov       [r13+r8*2],ax
       add       ecx,1
       jo        near ptr M01_L25
       cmp       ecx,ebx
       jge       short M01_L10
       jmp       short M01_L08
M01_L09:
       mov       r13,[rbp+10]
M01_L10:
       mov       [rbp+30],r13
       mov       [rbp+38],ebx
       lea       rcx,[rbp+30]
       call      System.String.Ctor(System.ReadOnlySpan`1<Char>)
M01_L11:
       mov       r8,5FCB875EFAB2
       cmp       [rbp+8],r8
       je        short M01_L12
       call      CORINFO_HELP_FAIL_FAST
M01_L12:
       nop
       lea       rsp,[rbp+0A8]
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
       movzx     ecx,byte ptr [rbp+0A0]
       test      cl,cl
       je        short M01_L14
       lea       rcx,[rbp+0A0]
       call      qword ptr [7FFB372AFC78]
       mov       ebx,eax
       jmp       near ptr M01_L00
M01_L14:
       call      qword ptr [7FFB372AFC90]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L15
       call      qword ptr [7FFB373C6268]
       mov       rbx,rax
M01_L15:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,1B383BB2FC0
       call      qword ptr [7FFB36FAD9C8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M01_L16:
       call      qword ptr [7FFB36EEF210]
       int       3
M01_L17:
       mov       ecx,eax
       call      qword ptr [7FFB373C4B40]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M01_L18:
       mov       rcx,offset MT_System.Buffers.ArrayPool<System.Byte>
       call      qword ptr [7FFB36D15728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,172EEC01E50
       mov       rcx,[rcx]
       mov       edx,r15d
       cmp       [rcx],ecx
       call      qword ptr [7FFB37351A40]
       mov       [rbp+28],rax
       mov       rcx,172EEC00C88
       mov       rcx,[rcx]
       mov       edx,r15d
       call      qword ptr [7FFB36FDFAC8]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
       mov       [rbp+20],rax
       cmp       qword ptr [rbp+28],0
       je        short M01_L19
       mov       r8,[rbp+28]
       cmp       [r8+8],r15d
       jb        short M01_L19
       lea       rcx,[r8+10]
       mov       eax,r15d
       mov       [rbp+40],rcx
       mov       [rbp+48],eax
       lea       rcx,[rbp+40]
       call      qword ptr [7FFB37134E10]; System.Security.Cryptography.RandomNumberGeneratorImplementation.FillSpan(System.Span`1<Byte>)
       cmp       qword ptr [rbp+20],0
       je        short M01_L19
       mov       rax,[rbp+20]
       cmp       [rax+8],r15d
       jb        short M01_L19
       lea       rbx,[rax+10]
       mov       r14d,r15d
       mov       r8,[rbp+28]
       cmp       [r8+8],r15d
       jae       short M01_L20
M01_L19:
       call      qword ptr [7FFB36EEF210]
       int       3
M01_L20:
       lea       rdx,[r8+10]
       mov       ecx,r15d
       mov       [rbp+40],rdx
       mov       [rbp+48],ecx
       lea       rdx,[rbp+40]
       lea       rcx,[rbp+90]
       call      qword ptr [7FFB3713C900]; System.Span`1[[System.Byte, System.Private.CoreLib]].op_Implicit(System.Span`1<Byte>)
       mov       rcx,[rbp+90]
       mov       r8d,[rbp+98]
       xor       r10d,r10d
       jmp       short M01_L24
M01_L21:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M01_L22:
       call      CORINFO_HELP_OVERFLOW
       int       3
M01_L23:
       cmp       r10d,r8d
       jae       short M01_L21
       movzx     eax,byte ptr [rcx+r10]
       cdq
       idiv      edi
       add       edx,esi
       jo        short M01_L22
       cmp       edx,0FFFF
       ja        short M01_L22
       mov       [rbx+r10*2],dx
       add       r10d,1
       jo        short M01_L22
M01_L24:
       cmp       r10d,r14d
       jl        short M01_L23
       mov       rcx,[rbp+20]
       mov       r8d,r15d
       xor       edx,edx
       call      00007FFB36D11548
       mov       rbx,rax
       mov       rcx,offset MT_System.Buffers.ArrayPool<System.Byte>
       call      qword ptr [7FFB36D15728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,172EEC01E50
       mov       rcx,[rcx]
       mov       rdx,[rbp+28]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFB37351A48]
       mov       rcx,172EEC00C88
       mov       rcx,[rcx]
       mov       rdx,[rbp+20]
       xor       r8d,r8d
       call      qword ptr [7FFB36FDFAD0]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
       mov       rax,rbx
       jmp       near ptr M01_L11
M01_L25:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       vzeroupper
       test      byte ptr [7FFB3731FD40],1
       jne       short M01_L26
       mov       rcx,offset MT_System.Buffers.ArrayPool<System.Byte>
       call      qword ptr [7FFB36D15728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
M01_L26:
       mov       rcx,172EEC01E50
       mov       rcx,[rcx]
       mov       rdx,[rbp+28]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFB37351A48]
       mov       rcx,172EEC00C88
       mov       rcx,[rcx]
       mov       rdx,[rbp+20]
       xor       r8d,r8d
       call      qword ptr [7FFB36FDFAD0]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
       nop
       add       rsp,28
       ret
; Total bytes of code 1127
```

