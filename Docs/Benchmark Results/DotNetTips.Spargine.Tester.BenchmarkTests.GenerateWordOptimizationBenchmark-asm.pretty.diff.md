## DotNetTips.Spargine.Tester.BenchmarkTests.GenerateWordOptimizationBenchmark-20260426-150817
**Diff for GenerateWordMinMaxChar method between:**
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-EWDLIM(EvaluateOverhead=True, Server=True, IterationCount=5, LaunchCount=1, WarmupCount=1))
```diff
; DotNetTips.Spargine.Tester.BenchmarkTests.GenerateWordOptimizationBenchmark.GenerateWordMinMaxChar()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       ecx,[rbx+140]
        mov       edx,61
        mov       r8d,7A
-       call      qword ptr [7FFD26C14858]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
+       call      qword ptr [7FFD26C444F8]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
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
        push      rbp
        push      r15
        push      r14
        push      r13
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,40
        lea       rbp,[rsp+20]
        vxorps    xmm4,xmm4,xmm4
        vmovdqu   xmmword ptr [rbp+8],xmm4
        xor       eax,eax
        mov       [rbp+18],rax
-       mov       rax,0FBF30529ADD7
+       mov       rax,7A7AB1CF2BE0
        mov       [rbp],rax
        mov       ebx,ecx
 ; 		length = length.ArgumentInRange(min: 1, defaultValue: 1);
 ; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
        test      ebx,ebx
        setg      al
        movzx     eax,al
        mov       ecx,1
        test      eax,eax
        cmove     ebx,ecx
 ; 		var range = maxCharacter - minCharacter + 1;
 ; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
        movzx     esi,r8w
        movzx     edi,dx
        sub       esi,edi
        jo        near ptr M01_L13
        add       esi,1
        jo        near ptr M01_L13
 ; 		var chars = length <= stackAllocThreshold
 ; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			? stackalloc char[length]
 ; 			                         
 ; 			: (Span<char>)new char[length];
 ; 			                               
        cmp       ebx,100
        jg        near ptr M01_L10
        mov       eax,ebx
        mov       ecx,2
        mul       rcx
        jb        near ptr M01_L13
        mov       r14,rax
        test      r14,r14
        je        short M01_L01
        add       r14,0F
        shr       r14,4
        add       rsp,20
        test      ebx,ebx
        jl        near ptr M01_L12
 M01_L05:
        test      ebx,ebx
        jle       short M01_L06
        mov       rcx,r13
        mov       [rbp+18],rcx
        mov       edx,ebx
-       call      qword ptr [7FFD26A256E0]; System.Security.Cryptography.RandomNumberGeneratorImplementation.GetBytes(Byte*, Int32)
+       call      qword ptr [7FFD26A34A20]; System.Security.Cryptography.RandomNumberGeneratorImplementation.GetBytes(Byte*, Int32)
        xor       eax,eax
        mov       [rbp+18],rax
 M01_L06:
        mov       r8d,ecx
        movzx     eax,byte ptr [r8+r13]
        cdq
        idiv      esi
        add       edx,edi
        jo        near ptr M01_L13
        cmp       edx,0FFFF
        ja        near ptr M01_L13
        mov       eax,edx
        mov       [r14+r8*2],ax
        add       ecx,1
        jo        near ptr M01_L13
        cmp       ecx,r15d
        jl        short M01_L07
 ; 		return new string(chars).Trim();
 ; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 M01_L08:
        mov       [rbp+8],r14
        mov       [rbp+10],r15d
        lea       rcx,[rbp+8]
        call      System.String.Ctor(System.ReadOnlySpan`1<Char>)
        mov       rcx,rax
-       call      qword ptr [7FFD26A25098]; System.String.Trim()
-       mov       r8,0FBF30529ADD7
+       call      qword ptr [7FFD26A343D8]; System.String.Trim()
+       mov       r8,7A7AB1CF2BE0
        cmp       [rbp],r8
        je        short M01_L09
        call      CORINFO_HELP_FAIL_FAST
        movsxd    rdx,ebx
        mov       rcx,offset MT_System.Byte[]
        call      CORINFO_HELP_NEWARR_1_VC
        lea       r13,[rax+10]
        mov       ecx,[rax+8]
        jmp       near ptr M01_L05
 M01_L12:
-       call      qword ptr [7FFD267DF228]
+       call      qword ptr [7FFD267FF228]
        int       3
 M01_L13:
        call      CORINFO_HELP_OVERFLOW
```
**Diff for GenerateWordMinMaxChar method between:**
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
; DotNetTips.Spargine.Tester.BenchmarkTests.GenerateWordOptimizationBenchmark.GenerateWordMinMaxChar()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       ecx,[rbx+140]
        mov       edx,61
        mov       r8d,7A
-       call      qword ptr [7FFD26C14858]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
+       call      qword ptr [7FFD26C343F0]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
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
        push      rbp
        push      r15
        push      r14
        push      r13
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,40
        lea       rbp,[rsp+20]
        vxorps    xmm4,xmm4,xmm4
        vmovdqu   xmmword ptr [rbp+8],xmm4
        xor       eax,eax
        mov       [rbp+18],rax
-       mov       rax,0FBF30529ADD7
+       mov       rax,1E28876753CC
        mov       [rbp],rax
        mov       ebx,ecx
 ; 		length = length.ArgumentInRange(min: 1, defaultValue: 1);
 ; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
        test      ebx,ebx
        setg      al
        movzx     eax,al
        mov       ecx,1
        test      eax,eax
        cmove     ebx,ecx
 ; 		var range = maxCharacter - minCharacter + 1;
 ; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
        movzx     esi,r8w
        movzx     edi,dx
        sub       esi,edi
        jo        near ptr M01_L13
        add       esi,1
        jo        near ptr M01_L13
 ; 		var chars = length <= stackAllocThreshold
 ; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			? stackalloc char[length]
 ; 			                         
 ; 			: (Span<char>)new char[length];
 ; 			                               
        cmp       ebx,100
        jg        near ptr M01_L10
        mov       eax,ebx
        mov       ecx,2
        mul       rcx
        jb        near ptr M01_L13
        mov       r14,rax
        test      r14,r14
        je        short M01_L01
        add       r14,0F
        shr       r14,4
        add       rsp,20
        test      ebx,ebx
        jl        near ptr M01_L12
 M01_L05:
        test      ebx,ebx
        jle       short M01_L06
        mov       rcx,r13
        mov       [rbp+18],rcx
        mov       edx,ebx
-       call      qword ptr [7FFD26A256E0]; System.Security.Cryptography.RandomNumberGeneratorImplementation.GetBytes(Byte*, Int32)
+       call      qword ptr [7FFD26A24930]; System.Security.Cryptography.RandomNumberGeneratorImplementation.GetBytes(Byte*, Int32)
        xor       eax,eax
        mov       [rbp+18],rax
 M01_L06:
        mov       r8d,ecx
        movzx     eax,byte ptr [r8+r13]
        cdq
        idiv      esi
        add       edx,edi
        jo        near ptr M01_L13
        cmp       edx,0FFFF
        ja        near ptr M01_L13
        mov       eax,edx
        mov       [r14+r8*2],ax
        add       ecx,1
        jo        near ptr M01_L13
        cmp       ecx,r15d
        jl        short M01_L07
 ; 		return new string(chars).Trim();
 ; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 M01_L08:
        mov       [rbp+8],r14
        mov       [rbp+10],r15d
        lea       rcx,[rbp+8]
        call      System.String.Ctor(System.ReadOnlySpan`1<Char>)
        mov       rcx,rax
-       call      qword ptr [7FFD26A25098]; System.String.Trim()
-       mov       r8,0FBF30529ADD7
+       call      qword ptr [7FFD26A242E8]; System.String.Trim()
+       mov       r8,1E28876753CC
        cmp       [rbp],r8
        je        short M01_L09
        call      CORINFO_HELP_FAIL_FAST
        movsxd    rdx,ebx
        mov       rcx,offset MT_System.Byte[]
        call      CORINFO_HELP_NEWARR_1_VC
        lea       r13,[rax+10]
        mov       ecx,[rax+8]
        jmp       near ptr M01_L05
 M01_L12:
-       call      qword ptr [7FFD267DF228]
+       call      qword ptr [7FFD267EF228]
        int       3
 M01_L13:
        call      CORINFO_HELP_OVERFLOW
```
**Diff for GenerateWordMinMaxChar method between:**
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-EWDLIM(EvaluateOverhead=True, Server=True, IterationCount=5, LaunchCount=1, WarmupCount=1))
```diff
; DotNetTips.Spargine.Tester.BenchmarkTests.GenerateWordOptimizationBenchmark.GenerateWordMinMaxChar()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       ecx,[rbx+140]
        mov       edx,61
        mov       r8d,7A
-       call      qword ptr [7FFD26C14858]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
+       call      qword ptr [7FFD26C544C8]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
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
        push      rbp
        push      r15
        push      r14
        push      r13
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,40
        lea       rbp,[rsp+20]
        vxorps    xmm4,xmm4,xmm4
        vmovdqu   xmmword ptr [rbp+8],xmm4
        xor       eax,eax
        mov       [rbp+18],rax
-       mov       rax,0FBF30529ADD7
+       mov       rax,92B98408FC2A
        mov       [rbp],rax
        mov       ebx,ecx
 ; 		length = length.ArgumentInRange(min: 1, defaultValue: 1);
 ; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
        test      ebx,ebx
        setg      al
        movzx     eax,al
        mov       ecx,1
        test      eax,eax
        cmove     ebx,ecx
 ; 		var range = maxCharacter - minCharacter + 1;
 ; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
        movzx     esi,r8w
        movzx     edi,dx
        sub       esi,edi
        jo        near ptr M01_L13
        add       esi,1
        jo        near ptr M01_L13
 ; 		var chars = length <= stackAllocThreshold
 ; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			? stackalloc char[length]
 ; 			                         
 ; 			: (Span<char>)new char[length];
 ; 			                               
        cmp       ebx,100
        jg        near ptr M01_L10
        mov       eax,ebx
        mov       ecx,2
        mul       rcx
        jb        near ptr M01_L13
        mov       r14,rax
        test      r14,r14
        je        short M01_L01
        add       r14,0F
        shr       r14,4
        add       rsp,20
        test      ebx,ebx
        jl        near ptr M01_L12
 M01_L05:
        test      ebx,ebx
        jle       short M01_L06
        mov       rcx,r13
        mov       [rbp+18],rcx
        mov       edx,ebx
-       call      qword ptr [7FFD26A256E0]; System.Security.Cryptography.RandomNumberGeneratorImplementation.GetBytes(Byte*, Int32)
+       call      qword ptr [7FFD26A449F0]; System.Security.Cryptography.RandomNumberGeneratorImplementation.GetBytes(Byte*, Int32)
        xor       eax,eax
        mov       [rbp+18],rax
 M01_L06:
        mov       r8d,ecx
        movzx     eax,byte ptr [r8+r13]
        cdq
        idiv      esi
        add       edx,edi
        jo        near ptr M01_L13
        cmp       edx,0FFFF
        ja        near ptr M01_L13
        mov       eax,edx
        mov       [r14+r8*2],ax
        add       ecx,1
        jo        near ptr M01_L13
        cmp       ecx,r15d
        jl        short M01_L07
 ; 		return new string(chars).Trim();
 ; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 M01_L08:
        mov       [rbp+8],r14
        mov       [rbp+10],r15d
        lea       rcx,[rbp+8]
        call      System.String.Ctor(System.ReadOnlySpan`1<Char>)
        mov       rcx,rax
-       call      qword ptr [7FFD26A25098]; System.String.Trim()
-       mov       r8,0FBF30529ADD7
+       call      qword ptr [7FFD26A443A8]; System.String.Trim()
+       mov       r8,92B98408FC2A
        cmp       [rbp],r8
        je        short M01_L09
        call      CORINFO_HELP_FAIL_FAST
        movsxd    rdx,ebx
        mov       rcx,offset MT_System.Byte[]
        call      CORINFO_HELP_NEWARR_1_VC
        lea       r13,[rax+10]
        mov       ecx,[rax+8]
        jmp       near ptr M01_L05
 M01_L12:
-       call      qword ptr [7FFD267DF228]
+       call      qword ptr [7FFD2680F228]
        int       3
 M01_L13:
        call      CORINFO_HELP_OVERFLOW
```
**Diff for GenerateWordMinMaxChar method between:**
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-EWDLIM(EvaluateOverhead=True, Server=True, IterationCount=5, LaunchCount=1, WarmupCount=1))
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
; DotNetTips.Spargine.Tester.BenchmarkTests.GenerateWordOptimizationBenchmark.GenerateWordMinMaxChar()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       ecx,[rbx+140]
        mov       edx,61
        mov       r8d,7A
-       call      qword ptr [7FFD26C444F8]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
+       call      qword ptr [7FFD26C343F0]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
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
        push      rbp
        push      r15
        push      r14
        push      r13
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,40
        lea       rbp,[rsp+20]
        vxorps    xmm4,xmm4,xmm4
        vmovdqu   xmmword ptr [rbp+8],xmm4
        xor       eax,eax
        mov       [rbp+18],rax
-       mov       rax,7A7AB1CF2BE0
+       mov       rax,1E28876753CC
        mov       [rbp],rax
        mov       ebx,ecx
 ; 		length = length.ArgumentInRange(min: 1, defaultValue: 1);
 ; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
        test      ebx,ebx
        setg      al
        movzx     eax,al
        mov       ecx,1
        test      eax,eax
        cmove     ebx,ecx
 ; 		var range = maxCharacter - minCharacter + 1;
 ; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
        movzx     esi,r8w
        movzx     edi,dx
        sub       esi,edi
        jo        near ptr M01_L13
        add       esi,1
        jo        near ptr M01_L13
 ; 		var chars = length <= stackAllocThreshold
 ; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			? stackalloc char[length]
 ; 			                         
 ; 			: (Span<char>)new char[length];
 ; 			                               
        cmp       ebx,100
        jg        near ptr M01_L10
        mov       eax,ebx
        mov       ecx,2
        mul       rcx
        jb        near ptr M01_L13
        mov       r14,rax
        test      r14,r14
        je        short M01_L01
        add       r14,0F
        shr       r14,4
        add       rsp,20
        test      ebx,ebx
        jl        near ptr M01_L12
 M01_L05:
        test      ebx,ebx
        jle       short M01_L06
        mov       rcx,r13
        mov       [rbp+18],rcx
        mov       edx,ebx
-       call      qword ptr [7FFD26A34A20]; System.Security.Cryptography.RandomNumberGeneratorImplementation.GetBytes(Byte*, Int32)
+       call      qword ptr [7FFD26A24930]; System.Security.Cryptography.RandomNumberGeneratorImplementation.GetBytes(Byte*, Int32)
        xor       eax,eax
        mov       [rbp+18],rax
 M01_L06:
        mov       r8d,ecx
        movzx     eax,byte ptr [r8+r13]
        cdq
        idiv      esi
        add       edx,edi
        jo        near ptr M01_L13
        cmp       edx,0FFFF
        ja        near ptr M01_L13
        mov       eax,edx
        mov       [r14+r8*2],ax
        add       ecx,1
        jo        near ptr M01_L13
        cmp       ecx,r15d
        jl        short M01_L07
 ; 		return new string(chars).Trim();
 ; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 M01_L08:
        mov       [rbp+8],r14
        mov       [rbp+10],r15d
        lea       rcx,[rbp+8]
        call      System.String.Ctor(System.ReadOnlySpan`1<Char>)
        mov       rcx,rax
-       call      qword ptr [7FFD26A343D8]; System.String.Trim()
-       mov       r8,7A7AB1CF2BE0
+       call      qword ptr [7FFD26A242E8]; System.String.Trim()
+       mov       r8,1E28876753CC
        cmp       [rbp],r8
        je        short M01_L09
        call      CORINFO_HELP_FAIL_FAST
        movsxd    rdx,ebx
        mov       rcx,offset MT_System.Byte[]
        call      CORINFO_HELP_NEWARR_1_VC
        lea       r13,[rax+10]
        mov       ecx,[rax+8]
        jmp       near ptr M01_L05
 M01_L12:
-       call      qword ptr [7FFD267FF228]
+       call      qword ptr [7FFD267EF228]
        int       3
 M01_L13:
        call      CORINFO_HELP_OVERFLOW
```
**Diff for GenerateWordMinMaxChar method between:**
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-EWDLIM(EvaluateOverhead=True, Server=True, IterationCount=5, LaunchCount=1, WarmupCount=1))
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-EWDLIM(EvaluateOverhead=True, Server=True, IterationCount=5, LaunchCount=1, WarmupCount=1))
```diff
; DotNetTips.Spargine.Tester.BenchmarkTests.GenerateWordOptimizationBenchmark.GenerateWordMinMaxChar()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       ecx,[rbx+140]
        mov       edx,61
        mov       r8d,7A
-       call      qword ptr [7FFD26C444F8]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
+       call      qword ptr [7FFD26C544C8]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
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
        push      rbp
        push      r15
        push      r14
        push      r13
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,40
        lea       rbp,[rsp+20]
        vxorps    xmm4,xmm4,xmm4
        vmovdqu   xmmword ptr [rbp+8],xmm4
        xor       eax,eax
        mov       [rbp+18],rax
-       mov       rax,7A7AB1CF2BE0
+       mov       rax,92B98408FC2A
        mov       [rbp],rax
        mov       ebx,ecx
 ; 		length = length.ArgumentInRange(min: 1, defaultValue: 1);
 ; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
        test      ebx,ebx
        setg      al
        movzx     eax,al
        mov       ecx,1
        test      eax,eax
        cmove     ebx,ecx
 ; 		var range = maxCharacter - minCharacter + 1;
 ; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
        movzx     esi,r8w
        movzx     edi,dx
        sub       esi,edi
        jo        near ptr M01_L13
        add       esi,1
        jo        near ptr M01_L13
 ; 		var chars = length <= stackAllocThreshold
 ; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			? stackalloc char[length]
 ; 			                         
 ; 			: (Span<char>)new char[length];
 ; 			                               
        cmp       ebx,100
        jg        near ptr M01_L10
        mov       eax,ebx
        mov       ecx,2
        mul       rcx
        jb        near ptr M01_L13
        mov       r14,rax
        test      r14,r14
        je        short M01_L01
        add       r14,0F
        shr       r14,4
        add       rsp,20
        test      ebx,ebx
        jl        near ptr M01_L12
 M01_L05:
        test      ebx,ebx
        jle       short M01_L06
        mov       rcx,r13
        mov       [rbp+18],rcx
        mov       edx,ebx
-       call      qword ptr [7FFD26A34A20]; System.Security.Cryptography.RandomNumberGeneratorImplementation.GetBytes(Byte*, Int32)
+       call      qword ptr [7FFD26A449F0]; System.Security.Cryptography.RandomNumberGeneratorImplementation.GetBytes(Byte*, Int32)
        xor       eax,eax
        mov       [rbp+18],rax
 M01_L06:
        mov       r8d,ecx
        movzx     eax,byte ptr [r8+r13]
        cdq
        idiv      esi
        add       edx,edi
        jo        near ptr M01_L13
        cmp       edx,0FFFF
        ja        near ptr M01_L13
        mov       eax,edx
        mov       [r14+r8*2],ax
        add       ecx,1
        jo        near ptr M01_L13
        cmp       ecx,r15d
        jl        short M01_L07
 ; 		return new string(chars).Trim();
 ; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 M01_L08:
        mov       [rbp+8],r14
        mov       [rbp+10],r15d
        lea       rcx,[rbp+8]
        call      System.String.Ctor(System.ReadOnlySpan`1<Char>)
        mov       rcx,rax
-       call      qword ptr [7FFD26A343D8]; System.String.Trim()
-       mov       r8,7A7AB1CF2BE0
+       call      qword ptr [7FFD26A443A8]; System.String.Trim()
+       mov       r8,92B98408FC2A
        cmp       [rbp],r8
        je        short M01_L09
        call      CORINFO_HELP_FAIL_FAST
        movsxd    rdx,ebx
        mov       rcx,offset MT_System.Byte[]
        call      CORINFO_HELP_NEWARR_1_VC
        lea       r13,[rax+10]
        mov       ecx,[rax+8]
        jmp       near ptr M01_L05
 M01_L12:
-       call      qword ptr [7FFD267FF228]
+       call      qword ptr [7FFD2680F228]
        int       3
 M01_L13:
        call      CORINFO_HELP_OVERFLOW
```
**Diff for GenerateWordMinMaxChar method between:**
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-EWDLIM(EvaluateOverhead=True, Server=True, IterationCount=5, LaunchCount=1, WarmupCount=1))
```diff
; DotNetTips.Spargine.Tester.BenchmarkTests.GenerateWordOptimizationBenchmark.GenerateWordMinMaxChar()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       ecx,[rbx+140]
        mov       edx,61
        mov       r8d,7A
-       call      qword ptr [7FFD26C343F0]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
+       call      qword ptr [7FFD26C544C8]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
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
        push      rbp
        push      r15
        push      r14
        push      r13
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,40
        lea       rbp,[rsp+20]
        vxorps    xmm4,xmm4,xmm4
        vmovdqu   xmmword ptr [rbp+8],xmm4
        xor       eax,eax
        mov       [rbp+18],rax
-       mov       rax,1E28876753CC
+       mov       rax,92B98408FC2A
        mov       [rbp],rax
        mov       ebx,ecx
 ; 		length = length.ArgumentInRange(min: 1, defaultValue: 1);
 ; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
        test      ebx,ebx
        setg      al
        movzx     eax,al
        mov       ecx,1
        test      eax,eax
        cmove     ebx,ecx
 ; 		var range = maxCharacter - minCharacter + 1;
 ; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
        movzx     esi,r8w
        movzx     edi,dx
        sub       esi,edi
        jo        near ptr M01_L13
        add       esi,1
        jo        near ptr M01_L13
 ; 		var chars = length <= stackAllocThreshold
 ; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			? stackalloc char[length]
 ; 			                         
 ; 			: (Span<char>)new char[length];
 ; 			                               
        cmp       ebx,100
        jg        near ptr M01_L10
        mov       eax,ebx
        mov       ecx,2
        mul       rcx
        jb        near ptr M01_L13
        mov       r14,rax
        test      r14,r14
        je        short M01_L01
        add       r14,0F
        shr       r14,4
        add       rsp,20
        test      ebx,ebx
        jl        near ptr M01_L12
 M01_L05:
        test      ebx,ebx
        jle       short M01_L06
        mov       rcx,r13
        mov       [rbp+18],rcx
        mov       edx,ebx
-       call      qword ptr [7FFD26A24930]; System.Security.Cryptography.RandomNumberGeneratorImplementation.GetBytes(Byte*, Int32)
+       call      qword ptr [7FFD26A449F0]; System.Security.Cryptography.RandomNumberGeneratorImplementation.GetBytes(Byte*, Int32)
        xor       eax,eax
        mov       [rbp+18],rax
 M01_L06:
        mov       r8d,ecx
        movzx     eax,byte ptr [r8+r13]
        cdq
        idiv      esi
        add       edx,edi
        jo        near ptr M01_L13
        cmp       edx,0FFFF
        ja        near ptr M01_L13
        mov       eax,edx
        mov       [r14+r8*2],ax
        add       ecx,1
        jo        near ptr M01_L13
        cmp       ecx,r15d
        jl        short M01_L07
 ; 		return new string(chars).Trim();
 ; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 M01_L08:
        mov       [rbp+8],r14
        mov       [rbp+10],r15d
        lea       rcx,[rbp+8]
        call      System.String.Ctor(System.ReadOnlySpan`1<Char>)
        mov       rcx,rax
-       call      qword ptr [7FFD26A242E8]; System.String.Trim()
-       mov       r8,1E28876753CC
+       call      qword ptr [7FFD26A443A8]; System.String.Trim()
+       mov       r8,92B98408FC2A
        cmp       [rbp],r8
        je        short M01_L09
        call      CORINFO_HELP_FAIL_FAST
        movsxd    rdx,ebx
        mov       rcx,offset MT_System.Byte[]
        call      CORINFO_HELP_NEWARR_1_VC
        lea       r13,[rax+10]
        mov       ecx,[rax+8]
        jmp       near ptr M01_L05
 M01_L12:
-       call      qword ptr [7FFD267EF228]
+       call      qword ptr [7FFD2680F228]
        int       3
 M01_L13:
        call      CORINFO_HELP_OVERFLOW
```
