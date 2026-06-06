## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Security.UlidBenchmark.UlidGetHashCode()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,2A7A68021B8
       mov       rcx,[rcx]
       test      rcx,rcx
       je        short M00_L01
M00_L00:
       cmp       [rcx],ecx
       call      qword ptr [7FF80BF4AAC0]; System.MulticastDelegate.GetHashCode()
       mov       rcx,[rbx+60]
       mov       [rcx+38],eax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L01:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Core.Ulid>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       xor       edx,edx
       mov       r8,7FF80C54B690
       mov       r9,7FF80BE5D010
       call      qword ptr [7FF80BF17180]; System.MulticastDelegate.CtorOpened(System.Object, IntPtr, IntPtr)
       mov       rcx,2A7A68021B8
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       jmp       short M00_L00
; Total bytes of code 121
```
```assembly
; System.MulticastDelegate.GetHashCode()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rdx,[rbx+30]
       cmp       rdx,0FFFFFFFFFFFFFFFF
       je        short M01_L03
       test      rdx,rdx
       jne       short M01_L04
M01_L00:
       mov       rdx,[rbx+28]
       mov       rcx,offset MT_System.Object[]
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
       mov       rsi,rax
       test      rsi,rsi
       jne       near ptr M01_L08
       cmp       qword ptr [rbx+20],0
       je        short M01_L05
       mov       rcx,rbx
       call      qword ptr [7FF80C0E61D8]; System.Object.GetType()
       mov       rbx,rax
       mov       rcx,rbx
       call      00007FF86BB39590
       test      eax,eax
       je        short M01_L02
M01_L01:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L02:
       mov       rcx,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FF80C0E77F8]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
M01_L03:
       mov       rcx,[rbx+18]
       mov       rdx,[rbx+20]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FF80C5D7CA8]
M01_L04:
       mov       rdx,[rbx+28]
       mov       rcx,offset MT_System.Delegate
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M01_L00
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+40]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax+18]
M01_L05:
       cmp       qword ptr [rbx+8],0
       jne       short M01_L06
       xor       esi,esi
       jmp       short M01_L07
M01_L06:
       mov       rcx,[rbx+8]
       call      qword ptr [7FF80C414558]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       esi,eax
       shl       esi,5
       add       esi,eax
M01_L07:
       mov       rcx,rbx
       call      qword ptr [7FF80C0E61D8]; System.Object.GetType()
       mov       rcx,rax
       call      qword ptr [7FF80C414558]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       add       eax,esi
       jmp       near ptr M01_L01
M01_L08:
       xor       edi,edi
       xor       ebp,ebp
       jmp       short M01_L10
M01_L09:
       cmp       ebp,[rsi+8]
       jae       short M01_L11
       mov       rcx,[rsi+rbp*8+10]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
       mov       ecx,edi
       shl       ecx,5
       add       ecx,edi
       lea       edi,[rax+rcx]
       inc       ebp
M01_L10:
       cmp       ebp,[rbx+30]
       jl        short M01_L09
       mov       eax,edi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 299
```
```assembly
; System.MulticastDelegate.CtorOpened(System.Object, IntPtr, IntPtr)
       push      rdi
       push      rsi
       push      rbx
       mov       rbx,rcx
       mov       rsi,r8
       mov       rdi,r9
       lea       rcx,[rbx+8]
       mov       rdx,rbx
       call      qword ptr [7FF86B973FE8]; CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rdi
       mov       [rbx+20],rsi
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 37
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Security.UlidBenchmark.GetTimeStamp()
       push      rsi
       push      rbx
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+30],ymm4
       xor       eax,eax
       mov       [rsp+50],rax
       mov       rbx,rcx
       call      qword ptr [7FF80C55D7A0]; DotNetTips.Spargine.Core.Ulid.NewUlid()
       test      rax,rax
       je        near ptr M00_L03
       cmp       dword ptr [rax+8],0A
       jl        near ptr M00_L03
       add       rax,0C
       xor       ecx,ecx
       xor       edx,edx
M00_L00:
       movzx     esi,word ptr [rax+rdx*2]
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rsp+30],ymm0
       vmovdqu   xmmword ptr [rsp+48],xmm0
       cmp       esi,100
       jge       near ptr M00_L02
       mov       r8,2836EC00180
       mov       r8,[r8]
       mov       r10d,esi
       mov       r8d,[r8+r10*4+10]
M00_L01:
       test      r8d,r8d
       jl        near ptr M00_L04
       shl       rcx,5
       test      r8d,r8d
       jl        near ptr M00_L13
       mov       r8d,r8d
       or        rcx,r8
       add       edx,1
       jo        near ptr M00_L13
       cmp       edx,0A
       jl        short M00_L00
       mov       rsi,rcx
       sar       rsi,2
       mov       rcx,0FFFFC77CEDD32800
       cmp       rsi,rcx
       jl        near ptr M00_L12
       mov       rcx,0E677D21FDBFF
       cmp       rsi,rcx
       jg        near ptr M00_L12
       imul      rcx,rsi,2710
       mov       rax,89F7FF5F7B58000
       add       rcx,rax
       xor       eax,eax
       mov       [rsp+20],eax
       mov       [rsp+28],rcx
       mov       rcx,[rbx+60]
       cmp       [rcx],cl
       lea       rcx,[rsp+20]
       call      qword ptr [7FF80C55DA40]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[System.DateTimeOffset, System.Private.CoreLib]](System.DateTimeOffset ByRef)
       nop
       vzeroupper
       add       rsp,58
       pop       rbx
       pop       rsi
       ret
M00_L02:
       mov       r8d,0FFFFFFFF
       jmp       near ptr M00_L01
M00_L03:
       mov       ecx,21
       call      qword ptr [7FF80BF3F360]
       int       3
M00_L04:
       lea       rcx,[rsp+30]
       mov       edx,1D
       mov       r8d,1
       call      qword ptr [7FF80BF3C270]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler..ctor(Int32, Int32)
       mov       ecx,[rsp+40]
       cmp       ecx,[rsp+50]
       ja        short M00_L07
       mov       rdx,[rsp+48]
       mov       eax,ecx
       lea       rdx,[rdx+rax*2]
       mov       eax,[rsp+50]
       sub       eax,ecx
       cmp       eax,13
       jb        short M00_L05
       vmovups   ymm0,[7FF80BFE8140]
       vmovups   [rdx],ymm0
       mov       dword ptr [rdx+20],200072
       mov       word ptr [rdx+24],27
       mov       ecx,[rsp+40]
       add       ecx,13
       mov       [rsp+40],ecx
       jmp       short M00_L06
M00_L05:
       lea       rcx,[rsp+30]
       mov       rdx,2C3EDDD07F8
       call      qword ptr [7FF80C5570A8]
M00_L06:
       lea       rcx,[rsp+30]
       mov       edx,esi
       call      qword ptr [7FF80C5575B8]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       mov       ecx,[rsp+40]
       cmp       ecx,[rsp+50]
       jbe       short M00_L08
M00_L07:
       call      qword ptr [7FF80C10F228]
       int       3
M00_L08:
       mov       rdx,[rsp+48]
       mov       eax,ecx
       lea       rdx,[rdx+rax*2]
       mov       eax,[rsp+50]
       sub       eax,ecx
       cmp       eax,0A
       jb        short M00_L09
       vmovups   xmm0,[7FF80BFE8160]
       vmovups   [rdx],xmm0
       mov       dword ptr [rdx+10],2E0044
       mov       ecx,[rsp+40]
       add       ecx,0A
       mov       [rsp+40],ecx
       jmp       short M00_L10
M00_L09:
       lea       rcx,[rsp+30]
       mov       rdx,2C3EDDD0838
       call      qword ptr [7FF80C5570A8]
M00_L10:
       lea       rcx,[rsp+30]
       call      qword ptr [7FF80BF3C2A0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L11
       call      qword ptr [7FF80C5F5A28]
       mov       rbx,rax
M00_L11:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,2DF1
       mov       rdx,7FF80C204FD8
       call      qword ptr [7FF80BF3F228]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF80C2B6190]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L12:
       mov       ecx,139F
       mov       rdx,7FF80BE74000
       call      qword ptr [7FF80BF3F228]
       mov       rcx,rax
       mov       rdx,rsi
       mov       r8,0FFFFC77CEDD32800
       mov       r9,0E677D21FDBFF
       call      qword ptr [7FF80C5F4AE0]
       int       3
M00_L13:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 650
```
```assembly
; DotNetTips.Spargine.Core.Ulid.NewUlid()
; 		Span<char> ulidChars = stackalloc char[UlidLength];
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		Span<byte> timestampBytes = stackalloc byte[6];
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		Span<byte> randomBytes = stackalloc byte[10];
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var timestamp = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       mov       rax,0AE5368124993
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
       call      qword ptr [7FF80C555488]; System.DateTimeOffset.get_UtcNow()
       mov       rdx,346DC5D63886594B
       mulx      rcx,rcx,[rbp+28]
       shr       rcx,0B
       mov       rdx,0FFFFC77CEDD32800
       add       rcx,rdx
       mov       rdx,rcx
       sar       rdx,28
       mov       [rsi],dl
       mov       rdx,rcx
       sar       rdx,20
       mov       [rsi+1],dl
       mov       rdx,rcx
       sar       rdx,18
       mov       [rsi+2],dl
       mov       rdx,rcx
       sar       rdx,10
       mov       [rsi+3],dl
       mov       rdx,rcx
       sar       rdx,8
       mov       [rsi+4],dl
       mov       [rsi+5],cl
       xor       ecx,ecx
       xor       edx,edx
       xor       eax,eax
M01_L00:
       cmp       ecx,6
       jae       near ptr M01_L13
       mov       r8d,ecx
       movzx     r8d,byte ptr [rsi+r8]
       mov       r10d,3
       sub       r10d,edx
       jo        near ptr M01_L14
       sarx      r8d,r8d,r10d
       and       r8d,1F
       add       edx,5
       jo        near ptr M01_L14
       cmp       edx,8
       jge       near ptr M01_L03
M01_L01:
       mov       r10d,eax
       lea       r10,[rbx+r10*2]
       mov       r14,2C3EDDD0714
       mov       r9,r14
       mov       r8d,r8d
       movzx     r8d,word ptr [r9+r8*2]
       mov       [r10],r8w
       add       eax,1
       jo        near ptr M01_L14
       cmp       eax,0A
       jge       near ptr M01_L05
       cmp       edx,3
       jle       short M01_L00
       mov       r8d,ecx
       add       r8d,1
       jo        near ptr M01_L14
       cmp       r8d,6
       jge       short M01_L04
       mov       r10d,r8d
       cmp       r10d,6
       jae       near ptr M01_L13
       movzx     r10d,byte ptr [rsi+r10]
M01_L02:
       cmp       ecx,6
       jae       near ptr M01_L13
       mov       ecx,ecx
       movzx     ecx,byte ptr [rsi+rcx]
       shl       ecx,8
       or        ecx,r10d
       mov       r10d,10
       sub       r10d,edx
       jo        near ptr M01_L14
       sub       r10d,5
       jo        near ptr M01_L14
       sarx      ecx,ecx,r10d
       and       ecx,1F
       add       edx,5
       jo        near ptr M01_L14
       and       edx,7
       mov       r9d,ecx
       mov       ecx,r8d
       mov       r8d,r9d
       jmp       near ptr M01_L01
M01_L03:
       sub       edx,8
       jo        near ptr M01_L14
       add       ecx,1
       jo        near ptr M01_L14
       jmp       near ptr M01_L01
M01_L04:
       xor       r10d,r10d
       jmp       short M01_L02
M01_L05:
       mov       [rbp+10],rdi
       mov       rcx,rdi
       mov       edx,0A
       call      qword ptr [7FF80C344A80]; System.Security.Cryptography.RandomNumberGeneratorImplementation.GetBytes(Byte*, Int32)
       xor       ecx,ecx
       mov       [rbp+10],rcx
       mov       [rbp+10],rcx
       xor       eax,eax
       xor       edx,edx
M01_L06:
       cmp       ecx,0A
       jae       near ptr M01_L13
       mov       r8d,ecx
       movzx     r8d,byte ptr [rdi+r8]
       mov       r10d,3
       sub       r10d,eax
       jo        near ptr M01_L14
       sarx      r8d,r8d,r10d
       and       r8d,1F
       add       eax,5
       jo        near ptr M01_L14
       cmp       eax,8
       jge       near ptr M01_L09
M01_L07:
       mov       r10d,edx
       add       r10d,0A
       jo        near ptr M01_L14
       lea       r10,[rbx+r10*2]
       mov       r9,r14
       mov       r8d,r8d
       movzx     r8d,word ptr [r9+r8*2]
       mov       [r10],r8w
       add       edx,1
       jo        near ptr M01_L14
       cmp       edx,10
       jge       near ptr M01_L11
       cmp       eax,3
       jle       short M01_L06
       mov       r8d,ecx
       add       r8d,1
       jo        near ptr M01_L14
       cmp       r8d,0A
       jge       short M01_L10
       mov       r10d,r8d
       cmp       r10d,0A
       jae       near ptr M01_L13
       movzx     r10d,byte ptr [rdi+r10]
M01_L08:
       cmp       ecx,0A
       jae       near ptr M01_L13
       mov       ecx,ecx
       movzx     ecx,byte ptr [rdi+rcx]
       shl       ecx,8
       or        ecx,r10d
       mov       r10d,10
       sub       r10d,eax
       jo        near ptr M01_L14
       sub       r10d,5
       jo        near ptr M01_L14
       sarx      ecx,ecx,r10d
       and       ecx,1F
       add       eax,5
       jo        short M01_L14
       and       eax,7
       mov       r9d,ecx
       mov       ecx,r8d
       mov       r8d,r9d
       jmp       near ptr M01_L07
M01_L09:
       sub       eax,8
       jo        short M01_L14
       add       ecx,1
       jo        short M01_L14
       jmp       near ptr M01_L07
M01_L10:
       xor       r10d,r10d
       jmp       short M01_L08
M01_L11:
       mov       [rbp],rbx
       mov       dword ptr [rbp+8],1A
       lea       rcx,[rbp]
       call      System.String.Ctor(System.ReadOnlySpan`1<Char>)
       mov       rdx,rax
       lea       rcx,[rbp+18]
       call      qword ptr [7FF80C55D800]; DotNetTips.Spargine.Core.Ulid..ctor(System.String)
       mov       rax,[rbp+18]
       mov       r8,0AE5368124993
       cmp       [rbp+48],r8
       je        short M01_L12
       call      CORINFO_HELP_FAIL_FAST
M01_L12:
       nop
       lea       rsp,[rbp+50]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M01_L13:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M01_L14:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 806
```
```assembly
; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[System.DateTimeOffset, System.Private.CoreLib]](System.DateTimeOffset ByRef)
       ret
; Total bytes of code 1
```
```assembly
; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler..ctor(Int32, Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       esi,edx
       mov       edi,r8d
       xor       eax,eax
       mov       [rbx],rax
       call      qword ptr [7FF86B975098]
       mov       rcx,[rax]
       imul      edx,edi,0B
       add       edx,esi
       mov       eax,100
       cmp       edx,100
       cmovle    edx,eax
       cmp       [rcx],ecx
       call      qword ptr [7FF86B994888]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
       mov       [rbx+8],rax
       test      rax,rax
       je        short M03_L01
       lea       rcx,[rax+10]
       mov       eax,[rax+8]
M03_L00:
       mov       [rbx+18],rcx
       mov       [rbx+20],eax
       xor       eax,eax
       mov       [rbx+10],eax
       mov       byte ptr [rbx+14],0
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M03_L01:
       xor       ecx,ecx
       xor       eax,eax
       jmp       short M03_L00
; Total bytes of code 102
```
```assembly
; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       cmp       byte ptr [rbx+14],0
       jne       short M04_L01
M04_L00:
       movzx     edi,si
       lea       rcx,[rbx+18]
       mov       eax,[rbx+10]
       mov       edx,[rcx+8]
       cmp       eax,edx
       ja        short M04_L03
       mov       rcx,[rcx]
       mov       r8d,eax
       lea       rbp,[rcx+r8*2]
       sub       edx,eax
       je        short M04_L02
       mov       [rbp],di
       inc       dword ptr [rbx+10]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M04_L01:
       movzx     edx,si
       mov       rcx,rbx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       xor       r8d,r8d
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax]
M04_L02:
       mov       rcx,rbx
       call      qword ptr [7FF86B98FFD8]
       jmp       short M04_L00
M04_L03:
       call      qword ptr [7FF86B98A278]
       int       3
; Total bytes of code 111
```
```assembly
; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       lea       rsi,[rbx+18]
       mov       rcx,rsi
       mov       eax,[rbx+10]
       cmp       eax,[rcx+8]
       ja        short M05_L01
       mov       rcx,[rcx]
       mov       [rsp+28],rcx
       mov       [rsp+30],eax
       lea       rcx,[rsp+28]
       call      qword ptr [7FF86B986B10]; Precode of System.String.Ctor(System.ReadOnlySpan`1<Char>)
       mov       rdi,rax
       mov       rbp,[rbx+8]
       xor       eax,eax
       mov       [rbx+8],rax
       mov       [rsi],rax
       mov       [rsi+8],rax
       mov       [rbx+10],eax
       test      rbp,rbp
       je        short M05_L00
       call      qword ptr [7FF86B975098]
       mov       rcx,[rax]
       mov       rdx,rbp
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FF86B994890]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
M05_L00:
       mov       rax,rdi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M05_L01:
       call      qword ptr [7FF86B98A278]
       int       3
; Total bytes of code 126
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Security.UlidBenchmark.NewUlid()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rcx,17F38C00180
       mov       rax,[rcx]
       test      rax,rax
       je        short M00_L01
M00_L00:
       mov       [rsp+20],rax
       mov       rbx,[rbx+60]
       mov       rdx,[rsp+20]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L01:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Core.Ulid>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       xor       edx,edx
       mov       r8,7FF80C5196F8
       mov       r9,7FF80BE3D010
       call      qword ptr [7FF80BEF7180]; System.MulticastDelegate.CtorOpened(System.Object, IntPtr, IntPtr)
       mov       rcx,17F38C00180
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rsi
       jmp       short M00_L00
; Total bytes of code 142
```
```assembly
; System.MulticastDelegate.CtorOpened(System.Object, IntPtr, IntPtr)
       push      rdi
       push      rsi
       push      rbx
       mov       rbx,rcx
       mov       rsi,r8
       mov       rdi,r9
       lea       rcx,[rbx+8]
       mov       rdx,rbx
       call      qword ptr [7FF86B973FE8]; CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rdi
       mov       [rbx+20],rsi
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 37
```

