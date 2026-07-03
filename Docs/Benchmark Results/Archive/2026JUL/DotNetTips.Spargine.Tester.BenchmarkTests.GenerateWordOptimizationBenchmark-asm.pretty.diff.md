## DotNetTips.Spargine.Tester.BenchmarkTests.GenerateWordOptimizationBenchmark-20260606-163100
**Diff for GenerateWordMinMaxChar method between:**
.NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
; DotNetTips.Spargine.Tester.BenchmarkTests.GenerateWordOptimizationBenchmark.GenerateWordMinMaxChar()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       ecx,[rbx+140]
        mov       edx,61
        mov       r8d,7A
-       call      qword ptr [7FF9F7744EA0]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
+       call      qword ptr [7FF9F7734A08]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
        mov       rbx,[rbx+138]
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
-       mov       rax,1CF07CAD7A6B
+       mov       rax,7112E2E578FD
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
-       mov       rax,7FF9F755DDD0
+       mov       rax,7FF9F753DDD0
        mov       [rbp+60],rax
        lea       rax,[M01_L05]
        mov       [rbp+70],rax
        lea       rax,[rbp+50]
        mov       [r14+8],rax
        mov       byte ptr [r14+4],0
        mov       rax,7FFA91B83670
        call      rax
        mov       [rbp+30],r13
        mov       [rbp+38],ebx
        lea       rcx,[rbp+30]
        call      System.String.Ctor(System.ReadOnlySpan`1<Char>)
 M01_L11:
-       mov       r8,1CF07CAD7A6B
+       mov       r8,7112E2E578FD
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
-       call      qword ptr [7FF9F76BFDB0]
+       call      qword ptr [7FF9F769F960]
        mov       ebx,eax
        jmp       near ptr M01_L00
 M01_L14:
-       call      qword ptr [7FF9F76BFDC8]
+       call      qword ptr [7FF9F769F978]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M01_L15
-       call      qword ptr [7FF9F77CC678]
+       call      qword ptr [7FF9F77D5788]
        mov       rbx,rax
 M01_L15:
        mov       rcx,offset MT_System.ArgumentOutOfRangeException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
        mov       r8,rbx
-       mov       rdx,25B66A12FC0
-       call      qword ptr [7FF9F73BE748]
+       mov       rdx,29B29F42FC0
+       call      qword ptr [7FF9F73AD968]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 M01_L16:
-       call      qword ptr [7FF9F72FF228]
+       call      qword ptr [7FF9F72EF228]
        int       3
 M01_L17:
        mov       ecx,eax
-       call      qword ptr [7FF9F77C73A8]
+       call      qword ptr [7FF9F773FF30]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
        int       3
 M01_L18:
        mov       rcx,offset MT_System.Buffers.ArrayPool<System.Byte>
-       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,21AD1C01E60
+       call      qword ptr [7FF9F7115728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
+       mov       rcx,25A95001E48
        mov       rcx,[rcx]
        mov       edx,r15d
        cmp       [rcx],ecx
-       call      qword ptr [7FF9F7739428]
+       call      qword ptr [7FF9F77417A0]
        mov       [rbp+28],rax
-       mov       rcx,21AD1C00C88
+       mov       rcx,25A95000C88
        mov       rcx,[rcx]
        mov       edx,r15d
-       call      qword ptr [7FF9F73F0D08]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
+       call      qword ptr [7FF9F73E0D08]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
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
-       call      qword ptr [7FF9F7545848]; System.Security.Cryptography.RandomNumberGeneratorImplementation.FillSpan(System.Span`1<Byte>)
+       call      qword ptr [7FF9F7524A68]; System.Security.Cryptography.RandomNumberGeneratorImplementation.FillSpan(System.Span`1<Byte>)
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
-       call      qword ptr [7FF9F72FF228]
+       call      qword ptr [7FF9F72EF228]
        int       3
 M01_L20:
        lea       rdx,[r8+10]
        mov       ecx,r15d
        mov       [rbp+40],rdx
        mov       [rbp+48],ecx
        lea       rdx,[rbp+40]
        lea       rcx,[rbp+90]
-       call      qword ptr [7FF9F754D3B0]; System.Span`1[[System.Byte, System.Private.CoreLib]].op_Implicit(System.Span`1<Byte>)
+       call      qword ptr [7FF9F752C5D0]; System.Span`1[[System.Byte, System.Private.CoreLib]].op_Implicit(System.Span`1<Byte>)
        mov       rcx,[rbp+90]
        mov       r8d,[rbp+98]
        xor       r10d,r10d
        jmp       short M01_L24
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
-       call      00007FF9F7121548
+       call      00007FF9F7111548
        mov       rbx,rax
        mov       rcx,offset MT_System.Buffers.ArrayPool<System.Byte>
-       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,21AD1C01E60
+       call      qword ptr [7FF9F7115728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
+       mov       rcx,25A95001E48
        mov       rcx,[rcx]
        mov       rdx,[rbp+28]
        xor       r8d,r8d
        cmp       [rcx],ecx
-       call      qword ptr [7FF9F7739430]
-       mov       rcx,21AD1C00C88
+       call      qword ptr [7FF9F77417A8]
+       mov       rcx,25A95000C88
        mov       rcx,[rcx]
        mov       rdx,[rbp+20]
        xor       r8d,r8d
-       call      qword ptr [7FF9F73F0D10]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
+       call      qword ptr [7FF9F73E0D10]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
        mov       rax,rbx
        jmp       near ptr M01_L11
 M01_L25:
        call      CORINFO_HELP_OVERFLOW
        int       3
        sub       rsp,28
        vzeroupper
-       test      byte ptr [7FF9F7739160],1
+       test      byte ptr [7FF9F770F1A0],1
        jne       short M01_L26
        mov       rcx,offset MT_System.Buffers.ArrayPool<System.Byte>
-       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
+       call      qword ptr [7FF9F7115728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
 M01_L26:
-       mov       rcx,21AD1C01E60
+       mov       rcx,25A95001E48
        mov       rcx,[rcx]
        mov       rdx,[rbp+28]
        xor       r8d,r8d
        cmp       [rcx],ecx
-       call      qword ptr [7FF9F7739430]
-       mov       rcx,21AD1C00C88
+       call      qword ptr [7FF9F77417A8]
+       mov       rcx,25A95000C88
        mov       rcx,[rcx]
        mov       rdx,[rbp+20]
        xor       r8d,r8d
-       call      qword ptr [7FF9F73F0D10]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
+       call      qword ptr [7FF9F73E0D10]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
        nop
        add       rsp,28
        ret
-; Total bytes of code 1124
+; Total bytes of code 1127
```
**Diff for GenerateWordMinMaxChar method between:**
.NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
; DotNetTips.Spargine.Tester.BenchmarkTests.GenerateWordOptimizationBenchmark.GenerateWordMinMaxChar()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       ecx,[rbx+140]
        mov       edx,61
        mov       r8d,7A
-       call      qword ptr [7FF9F7744EA0]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
+       call      qword ptr [7FF9F7744A08]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
        mov       rbx,[rbx+138]
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
-       mov       rax,1CF07CAD7A6B
+       mov       rax,139CA5B9FACE
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
-       mov       rax,7FF9F755DDD0
+       mov       rax,7FF9F754DDD0
        mov       [rbp+60],rax
        lea       rax,[M01_L05]
        mov       [rbp+70],rax
        lea       rax,[rbp+50]
        mov       [r14+8],rax
        mov       byte ptr [r14+4],0
        mov       rax,7FFA91B83670
        call      rax
        mov       [rbp+30],r13
        mov       [rbp+38],ebx
        lea       rcx,[rbp+30]
        call      System.String.Ctor(System.ReadOnlySpan`1<Char>)
 M01_L11:
-       mov       r8,1CF07CAD7A6B
+       mov       r8,139CA5B9FACE
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
-       call      qword ptr [7FF9F76BFDB0]
+       call      qword ptr [7FF9F76AF960]
        mov       ebx,eax
        jmp       near ptr M01_L00
 M01_L14:
-       call      qword ptr [7FF9F76BFDC8]
+       call      qword ptr [7FF9F76AF978]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M01_L15
-       call      qword ptr [7FF9F77CC678]
+       call      qword ptr [7FF9F77E57A0]
        mov       rbx,rax
 M01_L15:
        mov       rcx,offset MT_System.ArgumentOutOfRangeException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
        mov       r8,rbx
-       mov       rdx,25B66A12FC0
-       call      qword ptr [7FF9F73BE748]
+       mov       rdx,24DBC062FC0
+       call      qword ptr [7FF9F73BD968]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
        call      qword ptr [7FF9F72FF228]
        int       3
 M01_L17:
        mov       ecx,eax
-       call      qword ptr [7FF9F77C73A8]
+       call      qword ptr [7FF9F774FF48]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
        int       3
 M01_L18:
        mov       rcx,offset MT_System.Buffers.ArrayPool<System.Byte>
-       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,21AD1C01E60
+       call      qword ptr [7FF9F7125728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
+       mov       rcx,20D27001E48
        mov       rcx,[rcx]
        mov       edx,r15d
        cmp       [rcx],ecx
-       call      qword ptr [7FF9F7739428]
+       call      qword ptr [7FF9F77517A0]
        mov       [rbp+28],rax
-       mov       rcx,21AD1C00C88
+       mov       rcx,20D27000C88
        mov       rcx,[rcx]
        mov       edx,r15d
        call      qword ptr [7FF9F73F0D08]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
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
-       call      qword ptr [7FF9F7545848]; System.Security.Cryptography.RandomNumberGeneratorImplementation.FillSpan(System.Span`1<Byte>)
+       call      qword ptr [7FF9F7534A68]; System.Security.Cryptography.RandomNumberGeneratorImplementation.FillSpan(System.Span`1<Byte>)
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
        call      qword ptr [7FF9F72FF228]
        int       3
 M01_L20:
        lea       rdx,[r8+10]
        mov       ecx,r15d
        mov       [rbp+40],rdx
        mov       [rbp+48],ecx
        lea       rdx,[rbp+40]
        lea       rcx,[rbp+90]
-       call      qword ptr [7FF9F754D3B0]; System.Span`1[[System.Byte, System.Private.CoreLib]].op_Implicit(System.Span`1<Byte>)
+       call      qword ptr [7FF9F753C5D0]; System.Span`1[[System.Byte, System.Private.CoreLib]].op_Implicit(System.Span`1<Byte>)
        mov       rcx,[rbp+90]
        mov       r8d,[rbp+98]
        xor       r10d,r10d
        jmp       short M01_L24
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
        call      00007FF9F7121548
        mov       rbx,rax
        mov       rcx,offset MT_System.Buffers.ArrayPool<System.Byte>
-       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,21AD1C01E60
+       call      qword ptr [7FF9F7125728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
+       mov       rcx,20D27001E48
        mov       rcx,[rcx]
        mov       rdx,[rbp+28]
        xor       r8d,r8d
        cmp       [rcx],ecx
-       call      qword ptr [7FF9F7739430]
-       mov       rcx,21AD1C00C88
+       call      qword ptr [7FF9F77517A8]
+       mov       rcx,20D27000C88
        mov       rcx,[rcx]
        mov       rdx,[rbp+20]
        xor       r8d,r8d
        call      qword ptr [7FF9F73F0D10]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
        mov       rax,rbx
        jmp       near ptr M01_L11
 M01_L25:
        call      CORINFO_HELP_OVERFLOW
        int       3
        sub       rsp,28
        vzeroupper
-       test      byte ptr [7FF9F7739160],1
+       test      byte ptr [7FF9F771F1A0],1
        jne       short M01_L26
        mov       rcx,offset MT_System.Buffers.ArrayPool<System.Byte>
-       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
+       call      qword ptr [7FF9F7125728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
 M01_L26:
-       mov       rcx,21AD1C01E60
+       mov       rcx,20D27001E48
        mov       rcx,[rcx]
        mov       rdx,[rbp+28]
        xor       r8d,r8d
        cmp       [rcx],ecx
-       call      qword ptr [7FF9F7739430]
-       mov       rcx,21AD1C00C88
+       call      qword ptr [7FF9F77517A8]
+       mov       rcx,20D27000C88
        mov       rcx,[rcx]
        mov       rdx,[rbp+20]
        xor       r8d,r8d
        call      qword ptr [7FF9F73F0D10]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
        nop
        add       rsp,28
        ret
-; Total bytes of code 1124
+; Total bytes of code 1127
```
**Diff for GenerateWordMinMaxChar method between:**
.NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
; DotNetTips.Spargine.Tester.BenchmarkTests.GenerateWordOptimizationBenchmark.GenerateWordMinMaxChar()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       ecx,[rbx+140]
        mov       edx,61
        mov       r8d,7A
-       call      qword ptr [7FF9F7734A08]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
+       call      qword ptr [7FF9F7744A08]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
        mov       rbx,[rbx+138]
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
-       mov       rax,7112E2E578FD
+       mov       rax,139CA5B9FACE
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
-       mov       rax,7FF9F753DDD0
+       mov       rax,7FF9F754DDD0
        mov       [rbp+60],rax
        lea       rax,[M01_L05]
        mov       [rbp+70],rax
        lea       rax,[rbp+50]
        mov       [r14+8],rax
        mov       byte ptr [r14+4],0
        mov       rax,7FFA91B83670
        call      rax
        mov       [rbp+30],r13
        mov       [rbp+38],ebx
        lea       rcx,[rbp+30]
        call      System.String.Ctor(System.ReadOnlySpan`1<Char>)
 M01_L11:
-       mov       r8,7112E2E578FD
+       mov       r8,139CA5B9FACE
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
-       call      qword ptr [7FF9F769F960]
+       call      qword ptr [7FF9F76AF960]
        mov       ebx,eax
        jmp       near ptr M01_L00
 M01_L14:
-       call      qword ptr [7FF9F769F978]
+       call      qword ptr [7FF9F76AF978]
        mov       rbx,rax
        test      rbx,rbx
        jne       short M01_L15
-       call      qword ptr [7FF9F77D5788]
+       call      qword ptr [7FF9F77E57A0]
        mov       rbx,rax
 M01_L15:
        mov       rcx,offset MT_System.ArgumentOutOfRangeException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
        mov       r8,rbx
-       mov       rdx,29B29F42FC0
-       call      qword ptr [7FF9F73AD968]
+       mov       rdx,24DBC062FC0
+       call      qword ptr [7FF9F73BD968]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 M01_L16:
-       call      qword ptr [7FF9F72EF228]
+       call      qword ptr [7FF9F72FF228]
        int       3
 M01_L17:
        mov       ecx,eax
-       call      qword ptr [7FF9F773FF30]
+       call      qword ptr [7FF9F774FF48]
        mov       rcx,rax
        call      CORINFO_HELP_THROW
        int       3
 M01_L18:
        mov       rcx,offset MT_System.Buffers.ArrayPool<System.Byte>
-       call      qword ptr [7FF9F7115728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,25A95001E48
+       call      qword ptr [7FF9F7125728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
+       mov       rcx,20D27001E48
        mov       rcx,[rcx]
        mov       edx,r15d
        cmp       [rcx],ecx
-       call      qword ptr [7FF9F77417A0]
+       call      qword ptr [7FF9F77517A0]
        mov       [rbp+28],rax
-       mov       rcx,25A95000C88
+       mov       rcx,20D27000C88
        mov       rcx,[rcx]
        mov       edx,r15d
-       call      qword ptr [7FF9F73E0D08]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
+       call      qword ptr [7FF9F73F0D08]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
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
-       call      qword ptr [7FF9F7524A68]; System.Security.Cryptography.RandomNumberGeneratorImplementation.FillSpan(System.Span`1<Byte>)
+       call      qword ptr [7FF9F7534A68]; System.Security.Cryptography.RandomNumberGeneratorImplementation.FillSpan(System.Span`1<Byte>)
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
-       call      qword ptr [7FF9F72EF228]
+       call      qword ptr [7FF9F72FF228]
        int       3
 M01_L20:
        lea       rdx,[r8+10]
        mov       ecx,r15d
        mov       [rbp+40],rdx
        mov       [rbp+48],ecx
        lea       rdx,[rbp+40]
        lea       rcx,[rbp+90]
-       call      qword ptr [7FF9F752C5D0]; System.Span`1[[System.Byte, System.Private.CoreLib]].op_Implicit(System.Span`1<Byte>)
+       call      qword ptr [7FF9F753C5D0]; System.Span`1[[System.Byte, System.Private.CoreLib]].op_Implicit(System.Span`1<Byte>)
        mov       rcx,[rbp+90]
        mov       r8d,[rbp+98]
        xor       r10d,r10d
        jmp       short M01_L24
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
-       call      00007FF9F7111548
+       call      00007FF9F7121548
        mov       rbx,rax
        mov       rcx,offset MT_System.Buffers.ArrayPool<System.Byte>
-       call      qword ptr [7FF9F7115728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,25A95001E48
+       call      qword ptr [7FF9F7125728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
+       mov       rcx,20D27001E48
        mov       rcx,[rcx]
        mov       rdx,[rbp+28]
        xor       r8d,r8d
        cmp       [rcx],ecx
-       call      qword ptr [7FF9F77417A8]
-       mov       rcx,25A95000C88
+       call      qword ptr [7FF9F77517A8]
+       mov       rcx,20D27000C88
        mov       rcx,[rcx]
        mov       rdx,[rbp+20]
        xor       r8d,r8d
-       call      qword ptr [7FF9F73E0D10]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
+       call      qword ptr [7FF9F73F0D10]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
        mov       rax,rbx
        jmp       near ptr M01_L11
 M01_L25:
        call      CORINFO_HELP_OVERFLOW
        int       3
        sub       rsp,28
        vzeroupper
-       test      byte ptr [7FF9F770F1A0],1
+       test      byte ptr [7FF9F771F1A0],1
        jne       short M01_L26
        mov       rcx,offset MT_System.Buffers.ArrayPool<System.Byte>
-       call      qword ptr [7FF9F7115728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
+       call      qword ptr [7FF9F7125728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
 M01_L26:
-       mov       rcx,25A95001E48
+       mov       rcx,20D27001E48
        mov       rcx,[rcx]
        mov       rdx,[rbp+28]
        xor       r8d,r8d
        cmp       [rcx],ecx
-       call      qword ptr [7FF9F77417A8]
-       mov       rcx,25A95000C88
+       call      qword ptr [7FF9F77517A8]
+       mov       rcx,20D27000C88
        mov       rcx,[rcx]
        mov       rdx,[rbp+20]
        xor       r8d,r8d
-       call      qword ptr [7FF9F73E0D10]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
+       call      qword ptr [7FF9F73F0D10]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
        nop
        add       rsp,28
        ret
 ; Total bytes of code 1127
```
