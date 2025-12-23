## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Security.EncryptionHelperBenchmark.GenerateRandomKey()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       call      qword ptr [7FFEA9ED4C30]; DotNetTips.Spargine.Core.Ulid.NewUlid()
       mov       [rsp+28],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       ret
; Total bytes of code 56
```
```assembly
; DotNetTips.Spargine.Core.Ulid.NewUlid()
; 		Span<char> ulidChars = stackalloc char[UlidLength];
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		Span<byte> timestampBytes = stackalloc byte[8];
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		Span<byte> randomBytes = stackalloc byte[10];
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var timestamp = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		_ = BitConverter.TryWriteBytes(timestampBytes, timestamp);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		EncodeBase32(timestampBytes[..6], ulidChars, 0, TimestampLength);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		RandomNumberGenerator.Fill(randomBytes);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		EncodeBase32(randomBytes, ulidChars, TimestampLength, RandomLength);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return new Ulid(new string(ulidChars));
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,70
       lea       rbp,[rsp+20]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp],ymm4
       vmovdqu   ymmword ptr [rbp+20],ymm4
       xor       eax,eax
       mov       [rbp+40],rax
       mov       rax,9014A86681C3
       mov       [rbp+48],rax
       test      [rsp],esp
       sub       rsp,40
       lea       rcx,[rsp+20]
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymmword ptr [rcx+20],ymm0
       mov       rbx,rcx
       lea       rsi,[rbp+40]
       lea       rdi,[rbp+30]
       lea       rcx,[rbp+20]
       call      qword ptr [7FFEA9E353C8]; System.DateTimeOffset.get_UtcNow()
       mov       rdx,346DC5D63886594B
       mulx      rcx,rcx,[rbp+28]
       shr       rcx,0B
       mov       rdx,0FFFFC77CEDD32800
       add       rcx,rdx
       mov       [rsi],rcx
       xor       ecx,ecx
       xor       edx,edx
       xor       eax,eax
M01_L00:
       cmp       ecx,6
       jae       near ptr M01_L11
       mov       r8d,ecx
       movzx     r8d,byte ptr [rsi+r8]
       mov       r10d,3
       sub       r10d,edx
       jo        near ptr M01_L12
       sarx      r8d,r8d,r10d
       and       r8d,1F
       add       edx,5
       jo        near ptr M01_L12
       cmp       edx,8
       jl        near ptr M01_L07
       sub       edx,8
       jo        near ptr M01_L12
       add       ecx,1
       jo        near ptr M01_L12
       jmp       near ptr M01_L07
M01_L01:
       mov       [rbp+10],rdi
       mov       rcx,rdi
       mov       edx,0A
       call      qword ptr [7FFEA9D8EC70]; System.Security.Cryptography.RandomNumberGeneratorImplementation.GetBytes(Byte*, Int32)
       xor       ecx,ecx
       mov       [rbp+10],rcx
       mov       [rbp+10],rcx
       xor       eax,eax
       xor       edx,edx
M01_L02:
       cmp       ecx,0A
       jae       near ptr M01_L11
       mov       r8d,ecx
       movzx     r8d,byte ptr [rdi+r8]
       mov       r10d,3
       sub       r10d,eax
       jo        near ptr M01_L12
       sarx      r8d,r8d,r10d
       and       r8d,1F
       add       eax,5
       jo        near ptr M01_L12
       cmp       eax,8
       jl        near ptr M01_L10
       sub       eax,8
       jo        near ptr M01_L12
       add       ecx,1
       jo        near ptr M01_L12
       jmp       near ptr M01_L10
M01_L03:
       mov       [rbp],rbx
       mov       dword ptr [rbp+8],1A
       lea       rcx,[rbp]
       call      System.String.Ctor(System.ReadOnlySpan`1<Char>)
       mov       rdx,rax
       lea       rcx,[rbp+18]
       call      qword ptr [7FFEA9ED4CA8]; DotNetTips.Spargine.Core.Ulid..ctor(System.String)
       mov       rax,[rbp+18]
       mov       r8,9014A86681C3
       cmp       [rbp+48],r8
       je        short M01_L04
       call      CORINFO_HELP_FAIL_FAST
M01_L04:
       nop
       lea       rsp,[rbp+50]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M01_L05:
       xor       r10d,r10d
M01_L06:
       shl       r8d,8
       or        r8d,r10d
       mov       r10d,10
       sub       r10d,edx
       jo        near ptr M01_L12
       sub       r10d,5
       jo        near ptr M01_L12
       sarx      r8d,r8d,r10d
       and       r8d,1F
       add       edx,5
       jo        near ptr M01_L12
       and       edx,7
M01_L07:
       cmp       eax,1A
       jae       near ptr M01_L11
       mov       r10d,eax
       mov       r9,21BCB8021D0
       mov       r14,[r9]
       mov       r8d,r8d
       movzx     r8d,word ptr [r14+r8*2+10]
       mov       [rbx+r10*2],r8w
       add       eax,1
       jo        near ptr M01_L12
       cmp       eax,0A
       jge       near ptr M01_L01
       cmp       edx,3
       jle       near ptr M01_L00
       cmp       ecx,6
       jae       near ptr M01_L11
       mov       r8d,ecx
       movzx     r8d,byte ptr [rsi+r8]
       add       ecx,1
       jo        near ptr M01_L12
       cmp       ecx,6
       jge       near ptr M01_L05
       mov       r10d,ecx
       cmp       r10d,6
       jae       near ptr M01_L11
       movzx     r10d,byte ptr [rsi+r10]
       jmp       near ptr M01_L06
M01_L08:
       xor       r10d,r10d
M01_L09:
       shl       r8d,8
       or        r8d,r10d
       mov       r10d,10
       sub       r10d,eax
       jo        short M01_L12
       sub       r10d,5
       jo        short M01_L12
       sarx      r8d,r8d,r10d
       and       r8d,1F
       add       eax,5
       jo        short M01_L12
       and       eax,7
M01_L10:
       mov       r10d,edx
       add       r10d,0A
       jo        short M01_L12
       cmp       r10d,1A
       jae       short M01_L11
       mov       r8d,r8d
       movzx     r8d,word ptr [r14+r8*2+10]
       mov       [rbx+r10*2],r8w
       add       edx,1
       jo        short M01_L12
       cmp       edx,10
       jge       near ptr M01_L03
       cmp       eax,3
       jle       near ptr M01_L02
       cmp       ecx,0A
       jae       short M01_L11
       mov       r8d,ecx
       movzx     r8d,byte ptr [rdi+r8]
       add       ecx,1
       jo        short M01_L12
       cmp       ecx,0A
       jge       short M01_L08
       mov       r10d,ecx
       cmp       r10d,0A
       jae       short M01_L11
       movzx     r10d,byte ptr [rdi+r10]
       jmp       near ptr M01_L09
M01_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M01_L12:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 733
```

