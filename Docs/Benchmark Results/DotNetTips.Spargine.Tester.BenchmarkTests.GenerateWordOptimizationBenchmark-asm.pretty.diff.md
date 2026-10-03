## DotNetTips.Spargine.Tester.BenchmarkTests.GenerateWordOptimizationBenchmark-20261001-182609
**Diff for GenerateWordMinMaxChar method between:**
.NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
; DotNetTips.Spargine.Tester.BenchmarkTests.GenerateWordOptimizationBenchmark.GenerateWordMinMaxChar()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       ecx,[rbx+1B0]
        mov       edx,61
        mov       r8d,7A
-       call      qword ptr [7FFD22FA4DF8]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
+       call      qword ptr [7FFD22F1D158]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
        mov       rbx,[rbx+1A8]
        lea       rcx,[rbx+8]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rbx+8],rax
        add       rsp,20
        pop       rbx
        ret
 ; Total bytes of code 62
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
-       push      r13
-       push      r12
        push      rdi
        push      rsi
        push      rbx
-       sub       rsp,0C8
-       vzeroupper
+       sub       rsp,78
        lea       rbp,[rsp+20]
-       vxorps    xmm4,xmm4,xmm4
-       vmovdqu   ymmword ptr [rbp+30],ymm4
-       vmovdqu   ymmword ptr [rbp+50],ymm4
-       vmovdqu   ymmword ptr [rbp+70],ymm4
-       vmovdqa   xmmword ptr [rbp+90],xmm4
        xor       eax,eax
-       mov       [rbp+0A0],rax
-       mov       rax,4F4D5B56D043
-       mov       [rbp+8],rax
+       mov       [rbp+18],rax
+       vxorps    xmm4,xmm4,xmm4
+       vmovdqu   ymmword ptr [rbp+20],ymm4
+       vmovdqa   xmmword ptr [rbp+40],xmm4
+       mov       [rbp+50],rax
+       mov       rax,94530AF8DA54
+       mov       [rbp],rax
        mov       ebx,ecx
        mov       esi,edx
        mov       edi,r8d
-       lea       rcx,[rbp+50]
-       call      CORINFO_HELP_INIT_PINVOKE_FRAME
-       mov       r14,rax
-       mov       rcx,rsp
-       mov       [rbp+68],rcx
-       mov       rcx,rbp
-       mov       [rbp+78],rcx
-       mov       byte ptr [rbp+0A0],1
-       mov       dword ptr [rbp+0A4],1
+       mov       byte ptr [rbp+50],1
+       mov       dword ptr [rbp+54],1
        test      ebx,ebx
        setg      cl
        movzx     ecx,cl
        test      ecx,ecx
-       je        near ptr M01_L13
+       je        near ptr M01_L09
 M01_L00:
-       mov       r15d,ebx
+       mov       r14d,ebx
        movzx     edi,di
        movzx     esi,si
        sub       edi,esi
-       jo        near ptr M01_L25
+       jo        near ptr M01_L21
        add       edi,1
-       jo        near ptr M01_L25
-       cmp       r15d,100
-       jg        near ptr M01_L18
+       jo        near ptr M01_L21
+       cmp       r14d,100
+       jg        near ptr M01_L13
        mov       eax,ebx
-       mov       r15,rax
-       test      r15,r15
+       mov       r14,rax
+       test      r14,r14
        je        short M01_L02
-       add       r15,0F
-       shr       r15,4
+       add       r14,0F
+       shr       r14,4
        add       rsp,20
 M01_L01:
        push      0
        push      0
-       dec       r15
+       dec       r14
        jne       short M01_L01
        sub       rsp,20
-       lea       r15,[rsp+20]
+       lea       r14,[rsp+20]
 M01_L02:
        test      ebx,ebx
-       jl        near ptr M01_L16
-       mov       [rbp+18],r15
+       jl        near ptr M01_L12
        mov       eax,ebx
-       mov       r8d,2
-       mul       r8
-       jb        near ptr M01_L25
-       mov       r13,rax
-       test      r13,r13
+       mov       ecx,2
+       mul       rcx
+       jb        near ptr M01_L21
+       mov       r15,rax
+       test      r15,r15
        je        short M01_L04
-       add       r13,0F
-       shr       r13,4
+       add       r15,0F
+       shr       r15,4
        add       rsp,20
 M01_L03:
        push      0
        push      0
-       dec       r13
+       dec       r15
        jne       short M01_L03
        sub       rsp,20
-       lea       r13,[rsp+20]
+       lea       r15,[rsp+20]
 M01_L04:
-       mov       [rbp+10],r13
        test      ebx,ebx
-       jle       short M01_L07
-       mov       rdx,r15
-       mov       [rbp+88],rdx
-       mov       r8d,ebx
-       xor       ecx,ecx
-       mov       r9d,2
-       mov       rax,7FFD22DB2C78
-       mov       [rbp+60],rax
-       lea       rax,[M01_L05]
-       mov       [rbp+70],rax
-       lea       rax,[rbp+50]
-       mov       [r14+8],rax
-       mov       byte ptr [r14+4],0
-       mov       rax,7FFDC7023670
-       call      rax
-M01_L05:
-       mov       byte ptr [r14+4],1
-       cmp       dword ptr [7FFD828D3A90],0
-       je        short M01_L06
-       call      qword ptr [7FFD828C2648]; CORINFO_HELP_STOP_FOR_GC
-M01_L06:
-       mov       rcx,[rbp+58]
-       mov       [r14+8],rcx
-       test      eax,eax
-       jne       near ptr M01_L17
+       jle       short M01_L05
+       mov       rcx,r14
+       mov       [rbp+38],rcx
+       mov       edx,ebx
+       call      qword ptr [7FFD22DA4FC0]; System.Security.Cryptography.RandomNumberGeneratorImplementation.GetBytes(Byte*, Int32)
        xor       eax,eax
-       mov       [rbp+88],rax
-       mov       r15,[rbp+18]
-M01_L07:
+       mov       [rbp+38],rax
+M01_L05:
        xor       eax,eax
-       mov       [rbp+88],rax
+       mov       [rbp+38],rax
        xor       ecx,ecx
        test      ebx,ebx
-       jle       short M01_L09
-M01_L08:
+       jle       short M01_L07
+M01_L06:
        mov       r8d,ecx
-       movzx     eax,byte ptr [r15+r8]
+       movzx     eax,byte ptr [r14+r8]
        cdq
        idiv      edi
        add       edx,esi
-       jo        near ptr M01_L25
+       jo        near ptr M01_L21
        cmp       edx,0FFFF
-       ja        near ptr M01_L25
+       ja        near ptr M01_L21
        mov       eax,edx
-       mov       r13,[rbp+10]
-       mov       [r13+r8*2],ax
+       mov       [r15+r8*2],ax
        add       ecx,1
-       jo        near ptr M01_L25
+       jo        near ptr M01_L21
        cmp       ecx,ebx
-       jge       short M01_L10
-       jmp       short M01_L08
-M01_L09:
-       mov       r13,[rbp+10]
-M01_L10:
-       mov       [rbp+30],r13
-       mov       [rbp+38],ebx
-       lea       rcx,[rbp+30]
+       jl        short M01_L06
+M01_L07:
+       mov       [rbp+18],r15
+       mov       [rbp+20],ebx
+       lea       rcx,[rbp+18]
        call      System.String.Ctor(System.ReadOnlySpan`1<Char>)
-M01_L11:
-       mov       r8,4F4D5B56D043
-       cmp       [rbp+8],r8
-       je        short M01_L12
+       mov       r8,94530AF8DA54
+       cmp       [rbp],r8
+       je        short M01_L08
        call      CORINFO_HELP_FAIL_FAST
-M01_L12:
+M01_L08:
        nop
-       lea       rsp,[rbp+0A8]
+       lea       rsp,[rbp+58]
        pop       rbx
        pop       rsi
        pop       rdi
-       pop       r12
-       pop       r13
        pop       r14
        pop       r15
        pop       rbp
        ret
-M01_L13:
-       movzx     ecx,byte ptr [rbp+0A0]
+M01_L09:
+       movzx     ecx,byte ptr [rbp+50]
        test      cl,cl
-       je        short M01_L14
-       lea       rcx,[rbp+0A0]
-       call      qword ptr [7FFD22F1FD98]
+       je        short M01_L10
+       lea       rcx,[rbp+50]
+       call      qword ptr [7FFD22F1C0C0]
        mov       ebx,eax
        jmp       near ptr M01_L00
-M01_L14:
-       call      qword ptr [7FFD22F1FDB0]
+M01_L10:
+       call      qword ptr [7FFD22F1C0D8]
        mov       rbx,rax
        test      rbx,rbx
-       jne       short M01_L15
-       call      qword ptr [7FFD23035FE0]
+       jne       short M01_L11
+       call      qword ptr [7FFD22F8ECE8]
        mov       rbx,rax
-M01_L15:
+M01_L11:
        mov       rcx,offset MT_System.ArgumentOutOfRangeException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
        mov       r8,rbx
-       mov       rdx,2AB6FCF2288
+       mov       rdx,1EDF9B62288
        call      qword ptr [7FFD22B9DA88]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
-M01_L16:
+M01_L12:
        call      qword ptr [7FFD22AE7198]
        int       3
-M01_L17:
-       mov       ecx,eax
-       call      qword ptr [7FFD23034750]
-       mov       rcx,rax
-       call      CORINFO_HELP_THROW
-       int       3
-M01_L18:
+M01_L13:
        mov       rcx,offset MT_System.Buffers.ArrayPool<System.Byte>
        call      qword ptr [7FFD22975728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,26ADAC01E50
+       mov       rcx,1AD64C01E28
        mov       rcx,[rcx]
-       mov       edx,r15d
+       mov       edx,r14d
        cmp       [rcx],ecx
-       call      qword ptr [7FFD22FB41F0]
-       mov       [rbp+28],rax
-       mov       rcx,26ADAC00C88
+       call      qword ptr [7FFD22F4E400]
+       mov       [rbp+10],rax
+       mov       rcx,1AD64C00C88
        mov       rcx,[rcx]
-       mov       edx,r15d
+       mov       edx,r14d
        call      qword ptr [7FFD22C2FB48]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
-       mov       [rbp+20],rax
-       cmp       qword ptr [rbp+28],0
-       je        short M01_L19
-       mov       r8,[rbp+28]
-       cmp       [r8+8],r15d
-       jb        short M01_L19
+       mov       [rbp+8],rax
+       cmp       qword ptr [rbp+10],0
+       je        short M01_L14
+       mov       r8,[rbp+10]
+       cmp       [r8+8],r14d
+       jb        short M01_L14
        lea       rcx,[r8+10]
-       mov       eax,r15d
-       mov       [rbp+40],rcx
-       mov       [rbp+48],eax
-       lea       rcx,[rbp+40]
+       mov       eax,r14d
+       mov       [rbp+28],rcx
+       mov       [rbp+30],eax
+       lea       rcx,[rbp+28]
        call      qword ptr [7FFD22DA4F90]; System.Security.Cryptography.RandomNumberGeneratorImplementation.FillSpan(System.Span`1<Byte>)
-       cmp       qword ptr [rbp+20],0
-       je        short M01_L19
-       mov       rax,[rbp+20]
-       cmp       [rax+8],r15d
-       jb        short M01_L19
+       cmp       qword ptr [rbp+8],0
+       je        short M01_L14
+       mov       rax,[rbp+8]
+       cmp       [rax+8],r14d
+       jb        short M01_L14
        lea       rbx,[rax+10]
-       mov       r14d,r15d
-       mov       r8,[rbp+28]
-       cmp       [r8+8],r15d
-       jae       short M01_L20
-M01_L19:
+       mov       r15d,r14d
+       mov       r8,[rbp+10]
+       cmp       [r8+8],r14d
+       jae       short M01_L15
+M01_L14:
        call      qword ptr [7FFD22AE7198]
        int       3
-M01_L20:
+M01_L15:
        lea       rdx,[r8+10]
-       mov       ecx,r15d
-       mov       [rbp+40],rdx
-       mov       [rbp+48],ecx
-       lea       rdx,[rbp+40]
-       lea       rcx,[rbp+90]
+       mov       ecx,r14d
+       mov       [rbp+28],rdx
+       mov       [rbp+30],ecx
+       lea       rdx,[rbp+28]
+       lea       rcx,[rbp+40]
        call      qword ptr [7FFD22DACA80]; System.Span`1[[System.Byte, System.Private.CoreLib]].op_Implicit(System.Span`1<Byte>)
-       mov       rcx,[rbp+90]
-       mov       r8d,[rbp+98]
+       mov       rcx,[rbp+40]
+       mov       r8d,[rbp+48]
        xor       r10d,r10d
-       jmp       short M01_L24
-M01_L21:
+       jmp       short M01_L19
+M01_L16:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
-M01_L22:
+M01_L17:
        call      CORINFO_HELP_OVERFLOW
        int       3
-M01_L23:
+M01_L18:
        cmp       r10d,r8d
-       jae       short M01_L21
+       jae       short M01_L16
        movzx     eax,byte ptr [rcx+r10]
        cdq
        idiv      edi
        add       edx,esi
-       jo        short M01_L22
+       jo        short M01_L17
        cmp       edx,0FFFF
-       ja        short M01_L22
+       ja        short M01_L17
        mov       [rbx+r10*2],dx
        add       r10d,1
-       jo        short M01_L22
-M01_L24:
-       cmp       r10d,r14d
-       jl        short M01_L23
-       mov       rcx,[rbp+20]
-       mov       r8d,r15d
+       jo        short M01_L17
+M01_L19:
+       cmp       r10d,r15d
+       jl        short M01_L18
+       mov       rcx,[rbp+8]
+       mov       r8d,r14d
        xor       edx,edx
        call      00007FFD22971548
        mov       rbx,rax
        mov       rcx,offset MT_System.Buffers.ArrayPool<System.Byte>
        call      qword ptr [7FFD22975728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,26ADAC01E50
+       mov       rcx,1AD64C01E28
        mov       rcx,[rcx]
-       mov       rdx,[rbp+28]
+       mov       rdx,[rbp+10]
        xor       r8d,r8d
        cmp       [rcx],ecx
-       call      qword ptr [7FFD22FB41F8]
-       mov       rcx,26ADAC00C88
+       call      qword ptr [7FFD22F4E408]
+       mov       rcx,1AD64C00C88
        mov       rcx,[rcx]
-       mov       rdx,[rbp+20]
+       mov       rdx,[rbp+8]
        xor       r8d,r8d
        call      qword ptr [7FFD22C2FB50]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
        mov       rax,rbx
-       jmp       near ptr M01_L11
-M01_L25:
+       mov       r8,94530AF8DA54
+       cmp       [rbp],r8
+       je        short M01_L20
+       call      CORINFO_HELP_FAIL_FAST
+M01_L20:
+       nop
+       lea       rsp,[rbp+58]
+       pop       rbx
+       pop       rsi
+       pop       rdi
+       pop       r14
+       pop       r15
+       pop       rbp
+       ret
+M01_L21:
        call      CORINFO_HELP_OVERFLOW
        int       3
        sub       rsp,28
-       vzeroupper
-       test      byte ptr [7FFD22F835D8],1
-       jne       short M01_L26
+       test      byte ptr [7FFD22F4E138],1
+       jne       short M01_L22
        mov       rcx,offset MT_System.Buffers.ArrayPool<System.Byte>
        call      qword ptr [7FFD22975728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-M01_L26:
-       mov       rcx,26ADAC01E50
+M01_L22:
+       mov       rcx,1AD64C01E28
        mov       rcx,[rcx]
-       mov       rdx,[rbp+28]
+       mov       rdx,[rbp+10]
        xor       r8d,r8d
        cmp       [rcx],ecx
-       call      qword ptr [7FFD22FB41F8]
-       mov       rcx,26ADAC00C88
+       call      qword ptr [7FFD22F4E408]
+       mov       rcx,1AD64C00C88
        mov       rcx,[rcx]
-       mov       rdx,[rbp+20]
+       mov       rdx,[rbp+8]
        xor       r8d,r8d
        call      qword ptr [7FFD22C2FB50]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
        nop
        add       rsp,28
        ret
-; Total bytes of code 1127
+; Total bytes of code 939
```
**Diff for GenerateWordMinMaxChar method between:**
.NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
; DotNetTips.Spargine.Tester.BenchmarkTests.GenerateWordOptimizationBenchmark.GenerateWordMinMaxChar()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       ecx,[rbx+1B0]
        mov       edx,61
        mov       r8d,7A
-       call      qword ptr [7FFD22FA4DF8]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
+       call      qword ptr [7FFD22FA46C0]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
        mov       rbx,[rbx+1A8]
        lea       rcx,[rbx+8]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rbx+8],rax
        add       rsp,20
        pop       rbx
        ret
 ; Total bytes of code 62
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
-       mov       rax,4F4D5B56D043
+       mov       rax,0DCCFC884299E
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
        mov       [rbp+30],r13
        mov       [rbp+38],ebx
        lea       rcx,[rbp+30]
        call      System.String.Ctor(System.ReadOnlySpan`1<Char>)
 M01_L11:
-       mov       r8,4F4D5B56D043
+       mov       r8,0DCCFC884299E
        cmp       [rbp+8],r8
        je        short M01_L12
        call      CORINFO_HELP_FAIL_FAST
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
-       call      qword ptr [7FFD22F1FD98]
+       call      qword ptr [7FFD22F1F648]
        mov       ebx,eax
        jmp       near ptr M01_L00
 M01_L14:
-       call      qword ptr [7FFD22F1FDB0]
+       call      qword ptr [7FFD22F1F660]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M01_L15
-       call      qword ptr [7FFD23035FE0]
+       call      qword ptr [7FFD23035D58]
        mov       rbx,rax
 M01_L15:
        mov       rcx,offset MT_System.ArgumentOutOfRangeException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
        mov       r8,rbx
-       mov       rdx,2AB6FCF2288
+       mov       rdx,2EFA5902288
        call      qword ptr [7FFD22B9DA88]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
        call      qword ptr [7FFD22AE7198]
        int       3
 M01_L17:
        mov       ecx,eax
-       call      qword ptr [7FFD23034750]
+       call      qword ptr [7FFD23034600]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
        int       3
 M01_L18:
        mov       rcx,offset MT_System.Buffers.ArrayPool<System.Byte>
        call      qword ptr [7FFD22975728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,26ADAC01E50
+       mov       rcx,2AF10801E38
        mov       rcx,[rcx]
        mov       edx,r15d
        cmp       [rcx],ecx
-       call      qword ptr [7FFD22FB41F0]
+       call      qword ptr [7FFD22F918D8]
        mov       [rbp+28],rax
-       mov       rcx,26ADAC00C88
+       mov       rcx,2AF10800C88
        mov       rcx,[rcx]
        mov       edx,r15d
        call      qword ptr [7FFD22C2FB48]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
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
        call      qword ptr [7FFD22DA4F90]; System.Security.Cryptography.RandomNumberGeneratorImplementation.FillSpan(System.Span`1<Byte>)
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
        call      00007FFD22971548
        mov       rbx,rax
        mov       rcx,offset MT_System.Buffers.ArrayPool<System.Byte>
        call      qword ptr [7FFD22975728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,26ADAC01E50
+       mov       rcx,2AF10801E38
        mov       rcx,[rcx]
        mov       rdx,[rbp+28]
        xor       r8d,r8d
        cmp       [rcx],ecx
-       call      qword ptr [7FFD22FB41F8]
-       mov       rcx,26ADAC00C88
+       call      qword ptr [7FFD22F918E0]
+       mov       rcx,2AF10800C88
        mov       rcx,[rcx]
        mov       rdx,[rbp+20]
        xor       r8d,r8d
        call      qword ptr [7FFD22C2FB50]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
        mov       rax,rbx
        jmp       near ptr M01_L11
 M01_L25:
        call      CORINFO_HELP_OVERFLOW
        int       3
        sub       rsp,28
        vzeroupper
-       test      byte ptr [7FFD22F835D8],1
+       test      byte ptr [7FFD22F91678],1
        jne       short M01_L26
        mov       rcx,offset MT_System.Buffers.ArrayPool<System.Byte>
        call      qword ptr [7FFD22975728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
 M01_L26:
-       mov       rcx,26ADAC01E50
+       mov       rcx,2AF10801E38
        mov       rcx,[rcx]
        mov       rdx,[rbp+28]
        xor       r8d,r8d
        cmp       [rcx],ecx
-       call      qword ptr [7FFD22FB41F8]
-       mov       rcx,26ADAC00C88
+       call      qword ptr [7FFD22F918E0]
+       mov       rcx,2AF10800C88
        mov       rcx,[rcx]
        mov       rdx,[rbp+20]
        xor       r8d,r8d
        call      qword ptr [7FFD22C2FB50]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
        nop
        add       rsp,28
        ret
 ; Total bytes of code 1127
```
**Diff for GenerateWordMinMaxChar method between:**
.NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
; DotNetTips.Spargine.Tester.BenchmarkTests.GenerateWordOptimizationBenchmark.GenerateWordMinMaxChar()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       ecx,[rbx+1B0]
        mov       edx,61
        mov       r8d,7A
-       call      qword ptr [7FFD22F1D158]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
+       call      qword ptr [7FFD22FA46C0]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
        mov       rbx,[rbx+1A8]
        lea       rcx,[rbx+8]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rbx+8],rax
        add       rsp,20
        pop       rbx
        ret
 ; Total bytes of code 62
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
+       push      r13
+       push      r12
        push      rdi
        push      rsi
        push      rbx
-       sub       rsp,78
+       sub       rsp,0C8
+       vzeroupper
        lea       rbp,[rsp+20]
-       xor       eax,eax
-       mov       [rbp+18],rax
        vxorps    xmm4,xmm4,xmm4
-       vmovdqu   ymmword ptr [rbp+20],ymm4
-       vmovdqa   xmmword ptr [rbp+40],xmm4
-       mov       [rbp+50],rax
-       mov       rax,94530AF8DA54
-       mov       [rbp],rax
+       vmovdqu   ymmword ptr [rbp+30],ymm4
+       vmovdqu   ymmword ptr [rbp+50],ymm4
+       vmovdqu   ymmword ptr [rbp+70],ymm4
+       vmovdqa   xmmword ptr [rbp+90],xmm4
+       xor       eax,eax
+       mov       [rbp+0A0],rax
+       mov       rax,0DCCFC884299E
+       mov       [rbp+8],rax
        mov       ebx,ecx
        mov       esi,edx
        mov       edi,r8d
-       mov       byte ptr [rbp+50],1
-       mov       dword ptr [rbp+54],1
+       lea       rcx,[rbp+50]
+       call      CORINFO_HELP_INIT_PINVOKE_FRAME
+       mov       r14,rax
+       mov       rcx,rsp
+       mov       [rbp+68],rcx
+       mov       rcx,rbp
+       mov       [rbp+78],rcx
+       mov       byte ptr [rbp+0A0],1
+       mov       dword ptr [rbp+0A4],1
        test      ebx,ebx
        setg      cl
        movzx     ecx,cl
        test      ecx,ecx
-       je        near ptr M01_L09
+       je        near ptr M01_L13
 M01_L00:
-       mov       r14d,ebx
+       mov       r15d,ebx
        movzx     edi,di
        movzx     esi,si
        sub       edi,esi
-       jo        near ptr M01_L21
+       jo        near ptr M01_L25
        add       edi,1
-       jo        near ptr M01_L21
-       cmp       r14d,100
-       jg        near ptr M01_L13
+       jo        near ptr M01_L25
+       cmp       r15d,100
+       jg        near ptr M01_L18
        mov       eax,ebx
-       mov       r14,rax
-       test      r14,r14
+       mov       r15,rax
+       test      r15,r15
        je        short M01_L02
-       add       r14,0F
-       shr       r14,4
+       add       r15,0F
+       shr       r15,4
        add       rsp,20
 M01_L01:
        push      0
        push      0
-       dec       r14
+       dec       r15
        jne       short M01_L01
        sub       rsp,20
-       lea       r14,[rsp+20]
+       lea       r15,[rsp+20]
 M01_L02:
        test      ebx,ebx
-       jl        near ptr M01_L12
+       jl        near ptr M01_L16
+       mov       [rbp+18],r15
        mov       eax,ebx
-       mov       ecx,2
-       mul       rcx
-       jb        near ptr M01_L21
-       mov       r15,rax
-       test      r15,r15
+       mov       r8d,2
+       mul       r8
+       jb        near ptr M01_L25
+       mov       r13,rax
+       test      r13,r13
        je        short M01_L04
-       add       r15,0F
-       shr       r15,4
+       add       r13,0F
+       shr       r13,4
        add       rsp,20
 M01_L03:
        push      0
        push      0
-       dec       r15
+       dec       r13
        jne       short M01_L03
        sub       rsp,20
-       lea       r15,[rsp+20]
+       lea       r13,[rsp+20]
 M01_L04:
+       mov       [rbp+10],r13
        test      ebx,ebx
-       jle       short M01_L05
-       mov       rcx,r14
-       mov       [rbp+38],rcx
-       mov       edx,ebx
-       call      qword ptr [7FFD22DA4FC0]; System.Security.Cryptography.RandomNumberGeneratorImplementation.GetBytes(Byte*, Int32)
-       xor       eax,eax
-       mov       [rbp+38],rax
+       jle       short M01_L07
+       mov       rdx,r15
+       mov       [rbp+88],rdx
+       mov       r8d,ebx
+       xor       ecx,ecx
+       mov       r9d,2
+       mov       rax,7FFD22DB2C78
+       mov       [rbp+60],rax
+       lea       rax,[M01_L05]
+       mov       [rbp+70],rax
+       lea       rax,[rbp+50]
+       mov       [r14+8],rax
+       mov       byte ptr [r14+4],0
+       mov       rax,7FFDC7023670
+       call      rax
 M01_L05:
+       mov       byte ptr [r14+4],1
+       cmp       dword ptr [7FFD828D3A90],0
+       je        short M01_L06
+       call      qword ptr [7FFD828C2648]; CORINFO_HELP_STOP_FOR_GC
+M01_L06:
+       mov       rcx,[rbp+58]
+       mov       [r14+8],rcx
+       test      eax,eax
+       jne       near ptr M01_L17
+       xor       eax,eax
+       mov       [rbp+88],rax
+       mov       r15,[rbp+18]
+M01_L07:
        xor       eax,eax
-       mov       [rbp+38],rax
+       mov       [rbp+88],rax
        xor       ecx,ecx
        test      ebx,ebx
-       jle       short M01_L07
-M01_L06:
+       jle       short M01_L09
+M01_L08:
        mov       r8d,ecx
-       movzx     eax,byte ptr [r14+r8]
+       movzx     eax,byte ptr [r15+r8]
        cdq
        idiv      edi
        add       edx,esi
-       jo        near ptr M01_L21
+       jo        near ptr M01_L25
        cmp       edx,0FFFF
-       ja        near ptr M01_L21
+       ja        near ptr M01_L25
        mov       eax,edx
-       mov       [r15+r8*2],ax
+       mov       r13,[rbp+10]
+       mov       [r13+r8*2],ax
        add       ecx,1
-       jo        near ptr M01_L21
+       jo        near ptr M01_L25
        cmp       ecx,ebx
-       jl        short M01_L06
-M01_L07:
-       mov       [rbp+18],r15
-       mov       [rbp+20],ebx
-       lea       rcx,[rbp+18]
+       jge       short M01_L10
+       jmp       short M01_L08
+M01_L09:
+       mov       r13,[rbp+10]
+M01_L10:
+       mov       [rbp+30],r13
+       mov       [rbp+38],ebx
+       lea       rcx,[rbp+30]
        call      System.String.Ctor(System.ReadOnlySpan`1<Char>)
-       mov       r8,94530AF8DA54
-       cmp       [rbp],r8
-       je        short M01_L08
+M01_L11:
+       mov       r8,0DCCFC884299E
+       cmp       [rbp+8],r8
+       je        short M01_L12
        call      CORINFO_HELP_FAIL_FAST
-M01_L08:
+M01_L12:
        nop
-       lea       rsp,[rbp+58]
+       lea       rsp,[rbp+0A8]
        pop       rbx
        pop       rsi
        pop       rdi
+       pop       r12
+       pop       r13
        pop       r14
        pop       r15
        pop       rbp
        ret
-M01_L09:
-       movzx     ecx,byte ptr [rbp+50]
+M01_L13:
+       movzx     ecx,byte ptr [rbp+0A0]
        test      cl,cl
-       je        short M01_L10
-       lea       rcx,[rbp+50]
-       call      qword ptr [7FFD22F1C0C0]
+       je        short M01_L14
+       lea       rcx,[rbp+0A0]
+       call      qword ptr [7FFD22F1F648]
        mov       ebx,eax
        jmp       near ptr M01_L00
-M01_L10:
-       call      qword ptr [7FFD22F1C0D8]
+M01_L14:
+       call      qword ptr [7FFD22F1F660]
        mov       rbx,rax
        test      rbx,rbx
-       jne       short M01_L11
-       call      qword ptr [7FFD22F8ECE8]
+       jne       short M01_L15
+       call      qword ptr [7FFD23035D58]
        mov       rbx,rax
-M01_L11:
+M01_L15:
        mov       rcx,offset MT_System.ArgumentOutOfRangeException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
        mov       r8,rbx
-       mov       rdx,1EDF9B62288
+       mov       rdx,2EFA5902288
        call      qword ptr [7FFD22B9DA88]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
-M01_L12:
+M01_L16:
        call      qword ptr [7FFD22AE7198]
        int       3
-M01_L13:
+M01_L17:
+       mov       ecx,eax
+       call      qword ptr [7FFD23034600]
+       mov       rcx,rax
+       call      CORINFO_HELP_THROW
+       int       3
+M01_L18:
        mov       rcx,offset MT_System.Buffers.ArrayPool<System.Byte>
        call      qword ptr [7FFD22975728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,1AD64C01E28
+       mov       rcx,2AF10801E38
        mov       rcx,[rcx]
-       mov       edx,r14d
+       mov       edx,r15d
        cmp       [rcx],ecx
-       call      qword ptr [7FFD22F4E400]
-       mov       [rbp+10],rax
-       mov       rcx,1AD64C00C88
+       call      qword ptr [7FFD22F918D8]
+       mov       [rbp+28],rax
+       mov       rcx,2AF10800C88
        mov       rcx,[rcx]
-       mov       edx,r14d
+       mov       edx,r15d
        call      qword ptr [7FFD22C2FB48]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
-       mov       [rbp+8],rax
-       cmp       qword ptr [rbp+10],0
-       je        short M01_L14
-       mov       r8,[rbp+10]
-       cmp       [r8+8],r14d
-       jb        short M01_L14
+       mov       [rbp+20],rax
+       cmp       qword ptr [rbp+28],0
+       je        short M01_L19
+       mov       r8,[rbp+28]
+       cmp       [r8+8],r15d
+       jb        short M01_L19
        lea       rcx,[r8+10]
-       mov       eax,r14d
-       mov       [rbp+28],rcx
-       mov       [rbp+30],eax
-       lea       rcx,[rbp+28]
+       mov       eax,r15d
+       mov       [rbp+40],rcx
+       mov       [rbp+48],eax
+       lea       rcx,[rbp+40]
        call      qword ptr [7FFD22DA4F90]; System.Security.Cryptography.RandomNumberGeneratorImplementation.FillSpan(System.Span`1<Byte>)
-       cmp       qword ptr [rbp+8],0
-       je        short M01_L14
-       mov       rax,[rbp+8]
-       cmp       [rax+8],r14d
-       jb        short M01_L14
+       cmp       qword ptr [rbp+20],0
+       je        short M01_L19
+       mov       rax,[rbp+20]
+       cmp       [rax+8],r15d
+       jb        short M01_L19
        lea       rbx,[rax+10]
-       mov       r15d,r14d
-       mov       r8,[rbp+10]
-       cmp       [r8+8],r14d
-       jae       short M01_L15
-M01_L14:
+       mov       r14d,r15d
+       mov       r8,[rbp+28]
+       cmp       [r8+8],r15d
+       jae       short M01_L20
+M01_L19:
        call      qword ptr [7FFD22AE7198]
        int       3
-M01_L15:
+M01_L20:
        lea       rdx,[r8+10]
-       mov       ecx,r14d
-       mov       [rbp+28],rdx
-       mov       [rbp+30],ecx
-       lea       rdx,[rbp+28]
-       lea       rcx,[rbp+40]
+       mov       ecx,r15d
+       mov       [rbp+40],rdx
+       mov       [rbp+48],ecx
+       lea       rdx,[rbp+40]
+       lea       rcx,[rbp+90]
        call      qword ptr [7FFD22DACA80]; System.Span`1[[System.Byte, System.Private.CoreLib]].op_Implicit(System.Span`1<Byte>)
-       mov       rcx,[rbp+40]
-       mov       r8d,[rbp+48]
+       mov       rcx,[rbp+90]
+       mov       r8d,[rbp+98]
        xor       r10d,r10d
-       jmp       short M01_L19
-M01_L16:
+       jmp       short M01_L24
+M01_L21:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
-M01_L17:
+M01_L22:
        call      CORINFO_HELP_OVERFLOW
        int       3
-M01_L18:
+M01_L23:
        cmp       r10d,r8d
-       jae       short M01_L16
+       jae       short M01_L21
        movzx     eax,byte ptr [rcx+r10]
        cdq
        idiv      edi
        add       edx,esi
-       jo        short M01_L17
+       jo        short M01_L22
        cmp       edx,0FFFF
-       ja        short M01_L17
+       ja        short M01_L22
        mov       [rbx+r10*2],dx
        add       r10d,1
-       jo        short M01_L17
-M01_L19:
-       cmp       r10d,r15d
-       jl        short M01_L18
-       mov       rcx,[rbp+8]
-       mov       r8d,r14d
+       jo        short M01_L22
+M01_L24:
+       cmp       r10d,r14d
+       jl        short M01_L23
+       mov       rcx,[rbp+20]
+       mov       r8d,r15d
        xor       edx,edx
        call      00007FFD22971548
        mov       rbx,rax
        mov       rcx,offset MT_System.Buffers.ArrayPool<System.Byte>
        call      qword ptr [7FFD22975728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,1AD64C01E28
+       mov       rcx,2AF10801E38
        mov       rcx,[rcx]
-       mov       rdx,[rbp+10]
+       mov       rdx,[rbp+28]
        xor       r8d,r8d
        cmp       [rcx],ecx
-       call      qword ptr [7FFD22F4E408]
-       mov       rcx,1AD64C00C88
+       call      qword ptr [7FFD22F918E0]
+       mov       rcx,2AF10800C88
        mov       rcx,[rcx]
-       mov       rdx,[rbp+8]
+       mov       rdx,[rbp+20]
        xor       r8d,r8d
        call      qword ptr [7FFD22C2FB50]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
        mov       rax,rbx
-       mov       r8,94530AF8DA54
-       cmp       [rbp],r8
-       je        short M01_L20
-       call      CORINFO_HELP_FAIL_FAST
-M01_L20:
-       nop
-       lea       rsp,[rbp+58]
-       pop       rbx
-       pop       rsi
-       pop       rdi
-       pop       r14
-       pop       r15
-       pop       rbp
-       ret
-M01_L21:
+       jmp       near ptr M01_L11
+M01_L25:
        call      CORINFO_HELP_OVERFLOW
        int       3
        sub       rsp,28
-       test      byte ptr [7FFD22F4E138],1
-       jne       short M01_L22
+       vzeroupper
+       test      byte ptr [7FFD22F91678],1
+       jne       short M01_L26
        mov       rcx,offset MT_System.Buffers.ArrayPool<System.Byte>
        call      qword ptr [7FFD22975728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-M01_L22:
-       mov       rcx,1AD64C01E28
+M01_L26:
+       mov       rcx,2AF10801E38
        mov       rcx,[rcx]
-       mov       rdx,[rbp+10]
+       mov       rdx,[rbp+28]
        xor       r8d,r8d
        cmp       [rcx],ecx
-       call      qword ptr [7FFD22F4E408]
-       mov       rcx,1AD64C00C88
+       call      qword ptr [7FFD22F918E0]
+       mov       rcx,2AF10800C88
        mov       rcx,[rcx]
-       mov       rdx,[rbp+8]
+       mov       rdx,[rbp+20]
        xor       r8d,r8d
        call      qword ptr [7FFD22C2FB50]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
        nop
        add       rsp,28
        ret
-; Total bytes of code 939
+; Total bytes of code 1127
```
