## .NET 10.0.0 (10.0.25.45207), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Security.EncryptionHelperBenchmark.GenerateRandomKey()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       call      qword ptr [7FFE77A44408]; DotNetTips.Spargine.Core.Ulid.NewUlid()
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
; 		var ulidChars = new char[UlidLength].AsSpan();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var timestampBytes = GenerateTimeStamp().AsSpan(0, 6);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		EncodeBase32(timestampBytes, ulidChars, 0, TimestampLength);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var randomnessBytes = GenerateRandomBytes().AsSpan(0, 10); // Ensure only 10 bytes are used
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		EncodeBase32(randomnessBytes, ulidChars, TimestampLength, RandomLength);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return new Ulid(new string(ulidChars));
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,70
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+20],ymm4
       vmovdqu   ymmword ptr [rsp+40],ymm4
       vmovdqa   xmmword ptr [rsp+60],xmm4
       mov       rcx,offset MT_System.Char[]
       mov       edx,1A
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rbx,[rax+10]
       lea       rcx,[rsp+48]
       call      qword ptr [7FFE77994F18]; System.DateTimeOffset.get_UtcNow()
       mov       rdx,346DC5D63886594B
       mulx      rsi,rsi,[rsp+50]
       shr       rsi,0B
       mov       rdi,0FFFFC77CEDD32800
       add       rsi,rdi
       mov       rcx,offset MT_System.Byte[]
       mov       edx,8
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rdx,[rax+10]
       mov       [rdx],rsi
       add       rax,10
       mov       [rsp+60],rax
       mov       dword ptr [rsp+68],6
       mov       [rsp+30],rbx
       mov       dword ptr [rsp+38],1A
       lea       rdx,[rsp+30]
       lea       rcx,[rsp+60]
       xor       r8d,r8d
       mov       r9d,0A
       call      qword ptr [7FFE77A44468]; DotNetTips.Spargine.Core.Ulid.EncodeBase32(System.ReadOnlySpan`1<Byte> ByRef, System.Span`1<Char>, Int32, Int32)
       mov       rcx,offset MT_System.Byte[]
       mov       edx,0A
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rsi,rax
       lea       rcx,[rsi+10]
       mov       [rsp+40],rcx
       mov       edx,0A
       call      qword ptr [7FFE7790E7D8]; System.Security.Cryptography.RandomNumberGeneratorImplementation.GetBytes(Byte*, Int32)
       xor       edx,edx
       mov       [rsp+40],rdx
       mov       [rsp+40],rdx
       add       rsi,10
       mov       [rsp+60],rsi
       mov       dword ptr [rsp+68],0A
       mov       [rsp+30],rbx
       mov       dword ptr [rsp+38],1A
       lea       rdx,[rsp+30]
       lea       rcx,[rsp+60]
       mov       r8d,0A
       mov       r9d,10
       call      qword ptr [7FFE77A44468]; DotNetTips.Spargine.Core.Ulid.EncodeBase32(System.ReadOnlySpan`1<Byte> ByRef, System.Span`1<Char>, Int32, Int32)
       mov       [rsp+20],rbx
       mov       dword ptr [rsp+28],1A
       lea       rcx,[rsp+20]
       call      System.String.Ctor(System.ReadOnlySpan`1<Char>)
       mov       rdx,rax
       lea       rcx,[rsp+58]
       call      qword ptr [7FFE77A44498]; DotNetTips.Spargine.Core.Ulid..ctor(System.String)
       mov       rax,[rsp+58]
       add       rsp,70
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 343
```

