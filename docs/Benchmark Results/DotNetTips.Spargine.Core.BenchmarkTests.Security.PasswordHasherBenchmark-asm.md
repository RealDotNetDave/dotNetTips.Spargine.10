## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Security.PasswordHasherBenchmark.HashPasswordPBKDF2()
       sub       rsp,28
       mov       rcx,28ED7CA0708
       call      qword ptr [7FFB5E7BD740]; DotNetTips.Spargine.Core.Security.PasswordHasher.HashPasswordPBKDF2(System.String)
       nop
       add       rsp,28
       ret
; Total bytes of code 26
```
```assembly
; DotNetTips.Spargine.Core.Security.PasswordHasher.HashPasswordPBKDF2(System.String)
; 		var salt = RandomNumberGenerator.GetBytes(SaltSize);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var bytes = Rfc2898DeriveBytes.Pbkdf2(password, salt, Pbkdf2IterCount, HashAlgorithmName.SHA256, Pbkdf2SubkeyLength);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var passwordHashLength = 1 + SaltSize + Pbkdf2SubkeyLength;
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var passwordHash = _byteArrayPool.Rent(passwordHashLength);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			passwordHash[0] = Version;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Buffer.BlockCopy(salt, 0, passwordHash, 1, SaltSize);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Buffer.BlockCopy(bytes, 0, passwordHash, 1 + SaltSize, Pbkdf2SubkeyLength);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			return Convert.ToBase64String(passwordHash, 0, passwordHashLength);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 	}
; 	^
; 			_byteArrayPool.Return(passwordHash, clearArray: true);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       sub       rsp,158
       vmovaps   [rsp+140],xmm6
       vmovaps   [rsp+130],xmm7
       vmovaps   [rsp+120],xmm8
       vmovaps   [rsp+110],xmm9
       vmovaps   [rsp+100],xmm10
       lea       rbp,[rsp+190]
       xor       eax,eax
       mov       [rbp-138],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-130],ymm4
       vmovdqu   ymmword ptr [rbp-110],ymm4
       vmovdqu   ymmword ptr [rbp-0F0],ymm4
       vmovdqu   ymmword ptr [rbp-0D0],ymm4
       vmovdqu   ymmword ptr [rbp-0B0],ymm4
       mov       [rbp+10],rcx
       lea       rcx,[rbp-0F8]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rcx,rsp
       mov       [rbp-0E0],rcx
       mov       rcx,rbp
       mov       [rbp-0D0],rcx
       mov       rcx,offset MT_System.Byte[]
       mov       edx,100
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rdi,rax
       mov       [rbp-140],rdi
       lea       rdx,[rdi+10]
       mov       [rbp-98],rdx
       mov       r8d,100
       xor       ecx,ecx
       mov       r9d,2
       mov       rax,7FFB5E5BDDD0
       mov       [rbp-0E8],rax
       lea       rax,[M01_L00]
       mov       [rbp-0D8],rax
       lea       rax,[rbp-0F8]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFCFB453670
       vzeroupper
       call      rax
M01_L00:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFBBE0E3A10],0
       je        short M01_L01
       call      qword ptr [7FFBBE0D1648]; CORINFO_HELP_STOP_FOR_GC
M01_L01:
       mov       rcx,[rbp-0F0]
       mov       [rsi+8],rcx
       test      eax,eax
       jne       near ptr M01_L35
       xor       ecx,ecx
       mov       [rbp-98],rcx
       mov       [rbp-98],rcx
       mov       rdi,[rbp-140]
       mov       rbx,[rbp+10]
       test      rbx,rbx
       je        near ptr M01_L36
       lea       rsi,[rbx+0C]
       mov       ebx,[rbx+8]
       lea       r14,[rdi+10]
       mov       rcx,28ED7C98DD8
       call      qword ptr [7FFB5E886130]; System.Security.Cryptography.Rfc2898DeriveBytes.ValidateHashAlgorithm(System.Security.Cryptography.HashAlgorithmName)
       mov       rcx,offset MT_System.Byte[]
       mov       edx,20
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r15,rax
       lea       rcx,[r15+10]
       mov       [rbp-108],rsi
       mov       [rbp-100],ebx
       mov       [rbp-118],r14
       mov       dword ptr [rbp-110],100
       mov       [rbp-128],rcx
       mov       dword ptr [rbp-120],20
       mov       rcx,28ED7C98DD8
       mov       [rsp+20],rcx
       lea       rcx,[rbp-108]
       lea       rdx,[rbp-118]
       lea       r8,[rbp-128]
       mov       r9d,186A0
       call      qword ptr [7FFB5E886160]; System.Security.Cryptography.Rfc2898DeriveBytes.Pbkdf2Core(System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Byte>, System.Span`1<Byte>, Int32, System.Security.Cryptography.HashAlgorithmName)
       mov       rcx,24E58C00160
       mov       rbx,[rcx]
       mov       esi,121
       mov       rcx,24E42C00C90
       mov       r14,[rcx]
       mov       rcx,gs:[58]
       mov       rcx,[rcx+38]
       cmp       dword ptr [rcx+238],9
       jle       near ptr M01_L37
       mov       rcx,[rcx+240]
       mov       rax,[rcx+48]
       test      rax,rax
       je        near ptr M01_L37
M01_L02:
       mov       rcx,[rax+10]
       test      rcx,rcx
       je        near ptr M01_L39
       mov       eax,[rcx+8]
       cmp       eax,5
       jle       near ptr M01_L39
       mov       r13,[rcx+60]
       test      r13,r13
       je        near ptr M01_L39
       xor       eax,eax
       mov       [rcx+60],rax
       cmp       byte ptr [r14+9D],0
       jne       near ptr M01_L38
M01_L03:
       mov       [rbp-130],r13
       cmp       dword ptr [r13+8],0
       jbe       near ptr M01_L30
       mov       byte ptr [r13+10],1
       mov       ebx,[rdi+8]
       mov       rsi,rbx
       cmp       rdi,r13
       je        short M01_L04
       mov       esi,[r13+8]
       mov       rcx,offset MT_System.Byte[]
       cmp       [r13],rcx
       jne       near ptr M01_L22
M01_L04:
       cmp       rbx,100
       jb        near ptr M01_L24
       cmp       rsi,101
       jb        near ptr M01_L24
       lea       rcx,[r13+11]
       lea       rdx,[rdi+10]
       mov       r8d,100
       call      qword ptr [7FFB5E195818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ebx,[r15+8]
       mov       rsi,rbx
       cmp       r15,r13
       je        short M01_L05
       mov       esi,[r13+8]
       mov       rcx,offset MT_System.Byte[]
       cmp       [r13],rcx
       jne       near ptr M01_L25
M01_L05:
       cmp       rbx,20
       jb        near ptr M01_L27
       cmp       rsi,121
       jb        near ptr M01_L27
       lea       rdx,[r13+111]
       add       r15,10
       vmovdqu   ymm0,ymmword ptr [r15]
       vmovdqu   ymmword ptr [rdx],ymm0
       mov       ebx,[r13+8]
       sub       ebx,121
       test      ebx,ebx
       jg        short M01_L06
       test      ebx,ebx
       jl        near ptr M01_L09
M01_L06:
       cmp       dword ptr [r13+8],121
       jb        near ptr M01_L28
       add       r13,10
       mov       edx,184
       mov       rcx,offset MT_System.String
       call      00007FFBBDE29F20
       lea       rcx,[rax+0C]
       mov       edx,[rax+8]
       mov       edx,[rax+8]
       imul      r8d,edx,2
       jo        near ptr M01_L31
       mov       [rbp-0B0],r13
       mov       [rbp-0B8],rcx
       mov       r10,rcx
       cmp       r8d,184
       jl        near ptr M01_L29
       mov       r9d,121
M01_L07:
       mov       r8,r13
       mov       r11,r10
       lea       rbx,[r8+121]
       mov       esi,r9d
       add       rsi,r8
       cmp       r9d,10
       jl        near ptr M01_L13
       lea       r9,[rsi-20]
       cmp       r9,r8
       jb        near ptr M01_L11
       vmovups   ymm0,[7FFB5E933F00]
       vpermd    ymm0,ymm0,[r13]
       add       r13,0FFFFFFFFFFFFFFFC
M01_L08:
       vpshufb   ymm0,ymm0,[7FFB5E933F20]
       vpand     ymm1,ymm0,[7FFB5E933F40]
       vpmulhuw  ymm1,ymm1,[7FFB5E933F60]
       vpand     ymm0,ymm0,[7FFB5E933F80]
       vpmullw   ymm0,ymm0,[7FFB5E933FA0]
       vpor      ymm0,ymm0,ymm1
       vpsubusb  ymm1,ymm0,[7FFB5E933FC0]
       vpcmpgtb  ymm2,ymm0,[7FFB5E933FE0]
       vpsubb    ymm1,ymm1,ymm2
       vbroadcastf128 ymm2,xmmword ptr [7FFB5E934000]
       vpshufb   ymm1,ymm2,ymm1
       vpaddb    ymm0,ymm1,ymm0
       vmovups   [r10],ymm0
       add       r13,18
       add       r10,20
       cmp       r13,r9
       ja        short M01_L10
       vmovups   ymm0,[r13]
       jmp       short M01_L08
M01_L09:
       mov       ecx,1149
       mov       rdx,7FFB5E0D4000
       call      qword ptr [7FFB5E3B77B0]
       mov       r8,rax
       mov       edx,ebx
       xor       ecx,ecx
       call      qword ptr [7FFB5E88ED48]
       int       3
M01_L10:
       lea       r8,[r13+4]
       mov       r11,r10
       cmp       r8,rbx
       je        near ptr M01_L16
M01_L11:
       lea       r9,[rsi-10]
       cmp       r9,r8
       jb        near ptr M01_L13
       vmovups   xmm0,[7FFB5E934010]
       vmovups   xmm1,[7FFB5E934000]
       vbroadcastss xmm2,dword ptr [7FFB5E933F40]
       vbroadcastss xmm3,dword ptr [7FFB5E933F80]
       vbroadcastss xmm4,dword ptr [7FFB5E933F60]
       vbroadcastss xmm5,dword ptr [7FFB5E933FA0]
       vbroadcastss xmm6,dword ptr [7FFB5E933FC0]
       vbroadcastss xmm7,dword ptr [7FFB5E933FE0]
M01_L12:
       vmovups   xmm8,[r8]
       vpshufb   xmm8,xmm8,xmm0
       vpand     xmm9,xmm8,xmm2
       vpmulhuw  xmm9,xmm9,xmm4
       vpand     xmm8,xmm8,xmm3
       vpmullw   xmm8,xmm8,xmm5
       vpor      xmm8,xmm8,xmm9
       vpsubusb  xmm9,xmm8,xmm6
       vpcmpgtb  xmm10,xmm8,xmm7
       vpsubb    xmm9,xmm9,xmm10
       vpshufb   xmm9,xmm1,xmm9
       vpaddb    xmm8,xmm9,xmm8
       vmovups   [r11],xmm8
       add       r8,0C
       add       r11,10
       cmp       r8,r9
       jbe       short M01_L12
       cmp       r8,rbx
       je        near ptr M01_L16
M01_L13:
       mov       r10,7FFBBCF94BE0
       add       rsi,0FFFFFFFFFFFFFFFE
       cmp       r8,rsi
       jae       short M01_L15
M01_L14:
       movzx     r9d,byte ptr [r8]
       shl       r9d,10
       movzx     edi,byte ptr [r8+1]
       shl       edi,8
       or        r9d,edi
       movzx     edi,byte ptr [r8+2]
       or        r9d,edi
       mov       edi,r9d
       shr       edi,12
       movzx     edi,byte ptr [r10+rdi]
       mov       r14d,r9d
       shr       r14d,0C
       and       r14d,3F
       movzx     r14d,byte ptr [r10+r14]
       shl       r14d,8
       or        edi,r14d
       mov       r14d,r9d
       shr       r14d,6
       and       r14d,3F
       movzx     r14d,byte ptr [r10+r14]
       shl       r14d,10
       or        edi,r14d
       and       r9d,3F
       movzx     r9d,byte ptr [r10+r9]
       shl       r9d,18
       or        r9d,edi
       mov       [r11],r9d
       add       r8,3
       add       r11,4
       cmp       r8,rsi
       jb        short M01_L14
M01_L15:
       lea       r9,[rsi+2]
       cmp       r9,rbx
       jne       short M01_L16
       lea       r9,[r8+1]
       cmp       r9,rbx
       jne       near ptr M01_L32
       movzx     r8d,byte ptr [r8]
       shl       r8d,8
       mov       r9d,r8d
       shr       r9d,0A
       movzx     r9d,byte ptr [r10+r9]
       shr       r8d,4
       and       r8d,3F
       movzx     r10d,byte ptr [r10+r8]
       shl       r10d,8
       or        r10d,r9d
       or        r10d,3D3D0000
       mov       [r11],r10d
M01_L16:
       xor       r8d,r8d
       mov       [rbp-0B0],r8
       mov       [rbp-0B8],r8
       mov       r8d,edx
       lea       r8,[rcx+r8*2]
       mov       edx,edx
       add       rdx,rcx
       lea       r10,[rcx+1F]
       cmp       rdx,r10
       jbe       short M01_L18
M01_L17:
       add       rdx,0FFFFFFFFFFFFFFE0
       add       r8,0FFFFFFFFFFFFFFC0
       vmovups   ymm0,[rdx]
       vmovaps   ymm1,ymm0
       vpmovzxbw ymm1,xmm1
       vextracti128 xmm0,ymm0,1
       vpmovzxbw ymm0,xmm0
       vmovups   [r8],ymm1
       vmovups   [r8+20],ymm0
       cmp       rdx,r10
       ja        short M01_L17
M01_L18:
       lea       r10,[rcx+0F]
       cmp       rdx,r10
       ja        near ptr M01_L33
M01_L19:
       add       rcx,3
       cmp       rdx,rcx
       jbe       short M01_L21
M01_L20:
       add       r8,0FFFFFFFFFFFFFFF8
       add       rdx,0FFFFFFFFFFFFFFFC
       vmovd     xmm0,dword ptr [rdx]
       vpmovzxbw xmm0,xmm0
       vmovq     qword ptr [r8],xmm0
       cmp       rdx,rcx
       ja        short M01_L20
M01_L21:
       mov       rbx,rax
       xor       eax,eax
       mov       [rbp-0A0],rax
       mov       [rbp-0A8],rax
       mov       [rbp-138],rbx
       jmp       near ptr M01_L34
M01_L22:
       mov       rcx,r13
       call      00007FFBBDD1ACC0
       mov       ecx,3003FFC
       bt        ecx,eax
       jb        short M01_L23
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFB5E88E478]
       mov       rsi,rax
       mov       ecx,25F
       mov       rdx,7FFB5E0D4000
       call      qword ptr [7FFB5E3B77B0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFB5E516130]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L23:
       mov       rcx,[r13]
       movzx     ecx,word ptr [rcx]
       imul      rsi,rcx
       jmp       near ptr M01_L04
M01_L24:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFB5E88E490]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB5E514240]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L25:
       mov       rcx,r13
       call      00007FFBBDD1ACC0
       mov       ecx,3003FFC
       bt        ecx,eax
       jb        short M01_L26
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFB5E88E478]
       mov       rsi,rax
       mov       ecx,25F
       mov       rdx,7FFB5E0D4000
       call      qword ptr [7FFB5E3B77B0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFB5E516130]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L26:
       mov       rcx,[r13]
       movzx     ecx,word ptr [rcx]
       imul      rsi,rcx
       jmp       near ptr M01_L05
M01_L27:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFB5E88E490]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB5E514240]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L28:
       call      qword ptr [7FFB5E307198]
       int       3
M01_L29:
       sar       r8d,2
       lea       r9d,[r8+r8*2]
       jmp       near ptr M01_L07
M01_L30:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M01_L31:
       call      CORINFO_HELP_OVERFLOW
       int       3
M01_L32:
       lea       r9,[r8+2]
       cmp       r9,rbx
       jne       near ptr M01_L16
       movzx     r9d,byte ptr [r8]
       shl       r9d,10
       movzx     r8d,byte ptr [r8+1]
       shl       r8d,8
       or        r8d,r9d
       mov       r9d,r8d
       shr       r9d,12
       movzx     r9d,byte ptr [r10+r9]
       mov       ebx,r8d
       shr       ebx,0C
       and       ebx,3F
       movzx     ebx,byte ptr [r10+rbx]
       shl       ebx,8
       or        r9d,ebx
       shr       r8d,6
       and       r8d,3F
       movzx     r8d,byte ptr [r10+r8]
       shl       r8d,10
       or        r8d,r9d
       or        r8d,3D000000
       mov       [r11],r8d
       jmp       near ptr M01_L16
M01_L33:
       add       rdx,0FFFFFFFFFFFFFFF0
       add       r8,0FFFFFFFFFFFFFFE0
       vmovups   xmm0,[rdx]
       vpmovzxbw xmm1,xmm0
       vpsrldq   xmm0,xmm0,8
       vpmovzxbw xmm0,xmm0
       vmovups   [r8],xmm1
       vmovups   [r8+10],xmm0
       cmp       rdx,r10
       ja        short M01_L33
       jmp       near ptr M01_L19
M01_L34:
       call      M01_L56
       nop
       mov       rbx,[rbp-138]
       mov       rax,rbx
       vzeroupper
       vmovaps   xmm6,[rsp+140]
       vmovaps   xmm7,[rsp+130]
       vmovaps   xmm8,[rsp+120]
       vmovaps   xmm9,[rsp+110]
       vmovaps   xmm10,[rsp+100]
       add       rsp,158
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L35:
       mov       ecx,eax
       call      qword ptr [7FFB5E88D080]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M01_L36:
       mov       ecx,503
       mov       rdx,7FFB5E5BCC38
       call      qword ptr [7FFB5E3B77B0]
       mov       rcx,rax
       call      qword ptr [7FFB5E88CF78]
       int       3
M01_L37:
       mov       ecx,9
       call      qword ptr [7FFB5E88D188]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M01_L02
M01_L38:
       mov       rcx,r13
       call      qword ptr [7FFB5E5AD830]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       esi,eax
       mov       r12d,[r13+8]
       mov       rcx,rbx
       call      qword ptr [7FFB5E5AD830]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       dword ptr [rsp+20],5
       mov       edx,esi
       mov       r8d,r12d
       mov       rcx,r14
       call      qword ptr [7FFB5E88ECB8]
       jmp       near ptr M01_L03
M01_L39:
       mov       rcx,[rbx+10]
       cmp       dword ptr [rcx+8],5
       jle       near ptr M01_L51
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        near ptr M01_L50
       mov       r13,[rcx+8]
       mov       rcx,offset MT_System.Threading.ProcessorIdCache
       call      System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       cmp       byte ptr [7FFB5E0DB1E4],0
       je        short M01_L40
       call      qword ptr [7FFB5E88ECD0]
       mov       esi,eax
       jmp       short M01_L42
M01_L40:
       mov       ecx,0A
       call      qword ptr [7FFB5E88ECE8]
       mov       esi,[rax+10]
       mov       ecx,0A
       call      qword ptr [7FFB5E88ECE8]
       lea       ecx,[rsi-1]
       mov       [rax+10],ecx
       movzx     eax,si
       test      eax,eax
       jne       short M01_L41
       call      qword ptr [7FFB5E88ED00]
       mov       esi,eax
       jmp       short M01_L42
M01_L41:
       sar       esi,10
M01_L42:
       mov       rcx,offset MT_System.Buffers.SharedArrayPoolStatics
       call      System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       eax,esi
       xor       edx,edx
       div       dword ptr [7FFB5E0DB1D8]
       mov       esi,edx
       xor       r12d,r12d
       jmp       near ptr M01_L46
M01_L43:
       cmp       esi,[r13+8]
       jae       near ptr M01_L55
       mov       ecx,esi
       mov       rax,[r13+rcx*8+10]
       mov       [rbp-150],rax
       cmp       [rax],al
       xor       edx,edx
       mov       [rbp-148],rdx
       mov       rcx,rax
       call      qword ptr [7FFB5E6AE3B8]; System.Threading.Monitor.Enter(System.Object)
       mov       rax,[rbp-150]
       mov       rcx,[rax+8]
       mov       edx,[rax+10]
       dec       edx
       cmp       [rcx+8],edx
       jbe       short M01_L44
       mov       r8d,edx
       mov       r8,[rcx+r8*8+10]
       mov       [rbp-148],r8
       mov       r10d,edx
       xor       r9d,r9d
       mov       [rcx+r10*8+10],r9
       mov       [rax+10],edx
M01_L44:
       mov       rcx,rax
       call      qword ptr [7FFB5E196820]; System.Threading.Monitor.Exit(System.Object)
       mov       rcx,[rbp-148]
       test      rcx,rcx
       jne       short M01_L47
       inc       esi
       cmp       [r13+8],esi
       jne       short M01_L45
       xor       esi,esi
M01_L45:
       inc       r12d
M01_L46:
       cmp       [r13+8],r12d
       jg        near ptr M01_L43
       jmp       short M01_L48
M01_L47:
       mov       r13,rcx
       jmp       short M01_L49
M01_L48:
       xor       r13d,r13d
M01_L49:
       test      r13,r13
       je        short M01_L50
       cmp       byte ptr [r14+9D],0
       je        near ptr M01_L03
       mov       rcx,r13
       call      qword ptr [7FFB5E5AD830]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       esi,eax
       mov       r12d,[r13+8]
       mov       rcx,rbx
       call      qword ptr [7FFB5E5AD830]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       dword ptr [rsp+20],5
       mov       edx,esi
       mov       r8d,r12d
       mov       rcx,r14
       call      qword ptr [7FFB5E88ECB8]
       jmp       near ptr M01_L03
M01_L50:
       mov       esi,200
       jmp       short M01_L52
M01_L51:
       mov       ecx,121
       mov       rdx,28ED7C96F28
       call      qword ptr [7FFB5E3BD8C0]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
M01_L52:
       cmp       esi,800
       jge       short M01_L53
       mov       edx,esi
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r13,rax
       jmp       short M01_L54
M01_L53:
       mov       ecx,esi
       xor       edx,edx
       call      qword ptr [7FFB5E88ECA0]
       mov       r13,rax
M01_L54:
       cmp       byte ptr [r14+9D],0
       je        near ptr M01_L03
       cmp       [r13],r13b
       mov       rcx,r13
       call      qword ptr [7FFB5E5AD830]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       esi,eax
       mov       r12d,[r13+8]
       mov       rcx,rbx
       call      qword ptr [7FFB5E5AD830]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       edx,esi
       mov       r8d,r12d
       mov       rcx,r14
       call      qword ptr [7FFB5E88ECB8]
       mov       r12d,[r13+8]
       mov       rcx,rbx
       call      qword ptr [7FFB5E5AD830]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       rcx,[rbx+10]
       mov       edx,1
       mov       r8d,2
       cmp       dword ptr [rcx+8],5
       cmovg     edx,r8d
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       [rsp+28],edx
       mov       rcx,r14
       mov       edx,esi
       mov       r8d,r12d
       call      qword ptr [7FFB5E88ED18]
       jmp       near ptr M01_L03
M01_L55:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M01_L56:
       sub       rsp,38
       mov       rcx,24E58C00160
       mov       rbx,[rcx]
       cmp       qword ptr [rbp-130],0
       je        near ptr M01_L60
       mov       rcx,[rbp-130]
       mov       eax,[rcx+8]
       dec       eax
       or        eax,0F
       xor       esi,esi
       lzcnt     esi,eax
       xor       esi,1F
       add       esi,0FFFFFFFD
       mov       rax,gs:[58]
       mov       rax,[rax+38]
       cmp       dword ptr [rax+238],9
       jle       short M01_L57
       mov       rax,[rax+240]
       mov       rax,[rax+48]
       test      rax,rax
       jne       short M01_L58
M01_L57:
       mov       ecx,9
       call      qword ptr [7FFB5E88D188]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
M01_L58:
       mov       rdi,[rax+10]
       test      rdi,rdi
       jne       short M01_L59
       mov       rcx,rbx
       call      qword ptr [7FFB5E886418]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
       mov       rdi,rax
M01_L59:
       xor       r14d,r14d
       mov       r15d,1
       cmp       [rdi+8],esi
       jbe       near ptr M01_L78
       mov       r14d,1
       mov       rcx,[rbp-130]
       mov       rdx,[rcx]
       movzx     eax,word ptr [rdx]
       mov       r8d,[rcx+8]
       imul      r8,rax
       lea       rax,[rcx+10]
       test      dword ptr [rdx],1000000
       jne       short M01_L62
       jmp       short M01_L61
M01_L60:
       mov       ecx,2
       call      qword ptr [7FFB5E3BC240]
       int       3
M01_L61:
       mov       rcx,rax
       mov       rdx,r8
       call      qword ptr [7FFB5E1957E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
       jmp       short M01_L63
M01_L62:
       mov       rdx,r8
       shr       rdx,3
       mov       rcx,rax
       call      qword ptr [7FFB5E88EE38]
M01_L63:
       mov       ecx,10
       shlx      ecx,ecx,esi
       mov       rax,[rbp-130]
       cmp       [rax+8],ecx
       je        short M01_L64
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFB5E88EDF0]
       mov       r14,rax
       mov       ecx,29B
       mov       rdx,7FFB5E0D4000
       call      qword ptr [7FFB5E3B77B0]
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,rbx
       call      qword ptr [7FFB5E516130]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L64:
       cmp       esi,[rdi+8]
       jae       near ptr M01_L79
       mov       ecx,esi
       shl       rcx,4
       lea       rdi,[rdi+rcx+10]
       mov       r13,[rdi]
       mov       rcx,rdi
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rdi+8],ecx
       test      r13,r13
       je        near ptr M01_L78
       mov       rcx,[rbx+10]
       cmp       esi,[rcx+8]
       jae       near ptr M01_L79
       mov       edx,esi
       mov       rax,[rcx+rdx*8+10]
       test      rax,rax
       jne       short M01_L65
       mov       rcx,rbx
       mov       edx,esi
       call      qword ptr [7FFB5E88EE08]
M01_L65:
       mov       r15,[rax+8]
       mov       rcx,offset MT_System.Threading.ProcessorIdCache
       call      System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       cmp       byte ptr [7FFB5E0DB1E4],0
       je        short M01_L66
       call      qword ptr [7FFB5E88ECD0]
       mov       edi,eax
       jmp       short M01_L68
M01_L66:
       mov       ecx,0A
       call      qword ptr [7FFB5E88ECE8]
       mov       edi,[rax+10]
       mov       ecx,0A
       call      qword ptr [7FFB5E88ECE8]
       lea       ecx,[rdi-1]
       mov       [rax+10],ecx
       movzx     eax,di
       test      eax,eax
       jne       short M01_L67
       call      qword ptr [7FFB5E88ED00]
       mov       edi,eax
       jmp       short M01_L68
M01_L67:
       sar       edi,10
M01_L68:
       mov       rcx,offset MT_System.Buffers.SharedArrayPoolStatics
       call      System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       eax,edi
       xor       edx,edx
       div       dword ptr [7FFB5E0DB1D8]
       mov       edi,edx
       xor       r12d,r12d
       jmp       near ptr M01_L75
M01_L69:
       cmp       edi,[r15+8]
       jae       near ptr M01_L79
       mov       ecx,edi
       mov       rax,[r15+rcx*8+10]
       mov       [rbp-158],rax
       cmp       [rax],al
       xor       edx,edx
       mov       [rbp-0BC],edx
       mov       rcx,rax
       call      qword ptr [7FFB5E6AE3B8]; System.Threading.Monitor.Enter(System.Object)
       mov       rax,[rbp-158]
       mov       rcx,[rax+8]
       mov       r8d,[rax+10]
       mov       [rbp-0C0],r8d
       cmp       [rcx+8],r8d
       jbe       short M01_L71
       test      r8d,r8d
       jne       short M01_L72
       xor       edx,edx
       mov       [rax+14],edx
M01_L70:
       movsxd    rdx,r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rbp-0C0]
       inc       ecx
       mov       rax,[rbp-158]
       mov       [rax+10],ecx
       mov       dword ptr [rbp-0BC],1
M01_L71:
       mov       rcx,rax
       call      qword ptr [7FFB5E196820]; System.Threading.Monitor.Exit(System.Object)
       cmp       dword ptr [rbp-0BC],0
       je        short M01_L73
       jmp       short M01_L76
M01_L72:
       jmp       short M01_L70
M01_L73:
       inc       edi
       cmp       [r15+8],edi
       jne       short M01_L74
       xor       edi,edi
M01_L74:
       inc       r12d
M01_L75:
       cmp       [r15+8],r12d
       jg        near ptr M01_L69
       jmp       short M01_L77
M01_L76:
       mov       r15d,1
       jmp       short M01_L78
M01_L77:
       xor       r15d,r15d
M01_L78:
       mov       rax,24E42C00C90
       mov       rdi,[rax]
       cmp       byte ptr [rdi+9D],0
       je        near ptr M01_L82
       mov       rcx,[rbp-130]
       cmp       dword ptr [rcx+8],0
       je        near ptr M01_L82
       call      qword ptr [7FFB5E5AD830]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r13d,eax
       mov       rcx,[rbp-130]
       mov       r12d,[rcx+8]
       mov       rcx,rbx
       call      qword ptr [7FFB5E5AD830]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,rdi
       mov       r8d,r13d
       mov       r9d,r12d
       mov       edx,3
       call      qword ptr [7FFB5E88E598]
       test      r15d,r14d
       jne       short M01_L82
       mov       rcx,[rbp-130]
       call      qword ptr [7FFB5E5AD830]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r15d,eax
       mov       rcx,[rbp-130]
       mov       r13d,[rcx+8]
       mov       rcx,rbx
       call      qword ptr [7FFB5E5AD830]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       test      r14d,r14d
       jne       short M01_L80
       mov       ecx,0FFFFFFFF
       mov       edx,1
       jmp       short M01_L81
M01_L79:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M01_L80:
       mov       ecx,esi
       xor       edx,edx
M01_L81:
       mov       [rsp+20],ecx
       mov       [rsp+28],edx
       mov       rcx,rdi
       mov       edx,r15d
       mov       r8d,r13d
       call      qword ptr [7FFB5E88EE20]
M01_L82:
       nop
       vzeroupper
       add       rsp,38
       ret
; Total bytes of code 3877
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Security.PasswordHasherBenchmark.HashPasswordSHA256()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0D8
       lea       rbp,[rsp+110]
       xor       eax,eax
       mov       [rbp-0C8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-0C0],ymm4
       vmovdqu   ymmword ptr [rbp-0A0],ymm4
       vmovdqu   ymmword ptr [rbp-80],ymm4
       vmovdqu   ymmword ptr [rbp-60],ymm4
       mov       [rbp-40],rax
       mov       rcx,offset MT_System.Security.Cryptography.SHA256+Implementation
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       dword ptr [rbx+10],100
       mov       rcx,offset MT_System.Security.Cryptography.HashProviderCng
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       xor       edi,edi
       lea       r14,[rsi+20]
M00_L00:
       mov       rcx,1927A400168
       mov       rcx,[rcx]
       mov       rdx,1D2F9468DD8
       mov       [rbp-50],rdx
       xor       edx,edx
       mov       [rbp-48],edx
       mov       r15,[rcx+8]
       mov       r13,[r15+8]
       test      r13,r13
       jne       near ptr M00_L18
       xor       ecx,ecx
       mov       [rbp-58],rcx
       lea       rcx,[rbp-50]
       cmp       qword ptr [rbp-58],0
       jne       short M00_L01
       mov       rcx,[rbp-50]
       mov       [rbp-58],rcx
       lea       rcx,[rbp-58]
       cmp       qword ptr [rbp-58],0
       je        near ptr M00_L14
M00_L01:
       mov       rcx,[rcx]
       mov       rdx,offset MT_System.String
       cmp       [rcx],rdx
       jne       near ptr M00_L15
       lea       r13,[rcx+0C]
       mov       r12d,[rcx+8]
       add       r12d,r12d
       mov       dword ptr [rbp-68],2B60FA37
       mov       dword ptr [rbp-78],20698964
       cmp       r12d,8
       jb        short M00_L03
       mov       eax,r12d
       shr       eax,3
       mov       [rbp-5C],eax
M00_L02:
       mov       ecx,[rbp-68]
       add       ecx,[r13]
       mov       [rbp-68],ecx
       mov       r8d,[r13+4]
       mov       [rbp-6C],r8d
       lea       rcx,[rbp-68]
       lea       rdx,[rbp-78]
       call      qword ptr [7FFB5E8477F8]; System.Marvin.Block(UInt32 ByRef, UInt32 ByRef)
       mov       ecx,[rbp-6C]
       add       ecx,[rbp-68]
       mov       [rbp-68],ecx
       lea       rcx,[rbp-68]
       lea       rdx,[rbp-78]
       call      qword ptr [7FFB5E8477F8]; System.Marvin.Block(UInt32 ByRef, UInt32 ByRef)
       add       r13,8
       mov       eax,[rbp-5C]
       dec       eax
       mov       ecx,eax
       test      ecx,ecx
       mov       [rbp-5C],ecx
       jne       short M00_L02
       test      r12b,4
       je        short M00_L05
       jmp       short M00_L04
M00_L03:
       cmp       r12d,4
       jb        near ptr M00_L10
M00_L04:
       mov       ecx,[rbp-68]
       add       ecx,[r13]
       mov       [rbp-68],ecx
       lea       rcx,[rbp-68]
       lea       rdx,[rbp-78]
       call      qword ptr [7FFB5E8477F8]; System.Marvin.Block(UInt32 ByRef, UInt32 ByRef)
M00_L05:
       mov       ecx,r12d
       and       rcx,7
       mov       ecx,[r13+rcx-4]
       shr       ecx,8
       or        ecx,80000000
       mov       edx,r12d
       not       edx
       shl       edx,3
       shrx      ecx,ecx,edx
M00_L06:
       add       ecx,[rbp-68]
       mov       [rbp-68],ecx
       lea       rcx,[rbp-68]
       lea       rdx,[rbp-78]
       call      qword ptr [7FFB5E8477F8]; System.Marvin.Block(UInt32 ByRef, UInt32 ByRef)
       lea       rcx,[rbp-68]
       lea       rdx,[rbp-78]
       call      qword ptr [7FFB5E8477F8]; System.Marvin.Block(UInt32 ByRef, UInt32 ByRef)
       mov       ecx,[rbp-78]
       xor       ecx,[rbp-68]
M00_L07:
       mov       edx,[rbp-48]
       call      qword ptr [7FFB5E6ACA20]; System.HashCode.Combine[[System.Int32, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](Int32, Int32)
       mov       r13d,eax
       xor       r8d,r8d
       mov       [rbp-58],r8
       mov       r8d,r13d
       mov       rdx,r15
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentDictionary<System.ValueTuple<System.String, Interop+BCrypt+BCryptOpenAlgorithmProviderFlags>, System.ValueTuple<Microsoft.Win32.SafeHandles.SafeBCryptAlgorithmHandle, System.Int32>>
       call      qword ptr [7FFB5E7BDEA8]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.ValueTuple`2[[System.__Canon, System.Private.CoreLib],[Interop+BCrypt+BCryptOpenAlgorithmProviderFlags, System.Security.Cryptography]], System.Private.CoreLib],[System.ValueTuple`2[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]], System.Private.CoreLib]].GetBucket(Tables<System.ValueTuple`2<System.__Canon,BCryptOpenAlgorithmProviderFlags>,System.ValueTuple`2<System.__Canon,Int32>>, Int32)
       mov       r12,rax
       test      r12,r12
       je        near ptr M00_L17
M00_L08:
       cmp       r13d,[r12+10]
       jne       near ptr M00_L16
       vmovdqu   xmm0,xmmword ptr [r12+18]
       vmovdqu   xmmword ptr [rbp-98],xmm0
       vmovdqu   xmm0,xmmword ptr [rbp-50]
       vmovdqu   xmmword ptr [rbp-0A8],xmm0
       lea       rdx,[rbp-98]
       lea       r8,[rbp-0A8]
       mov       rcx,1927A400180
       mov       rcx,[rcx]
       call      qword ptr [7FFB5E81C8B8]; System.Collections.Generic.GenericEqualityComparer`1[[System.ValueTuple`2[[System.__Canon, System.Private.CoreLib],[Interop+BCrypt+BCryptOpenAlgorithmProviderFlags, System.Security.Cryptography]], System.Private.CoreLib]].Equals(System.ValueTuple`2<System.__Canon,BCryptOpenAlgorithmProviderFlags>, System.ValueTuple`2<System.__Canon,BCryptOpenAlgorithmProviderFlags>)
       test      eax,eax
       je        near ptr M00_L16
       mov       rdx,[r12+28]
       mov       ecx,[r12+30]
M00_L09:
       mov       [r14],ecx
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+8]
       mov       [rbp-0C8],rdi
       xor       edx,edx
       mov       [rbp-0C0],edx
       mov       [rsp+28],edx
       mov       dword ptr [rsp+30],20
       lea       rdx,[rbp-0C8]
       mov       [rsp+20],rdx
       lea       rdx,[rbp-40]
       xor       r8d,r8d
       xor       r9d,r9d
       call      qword ptr [7FFB5E7BE3E8]; Interop+BCrypt.BCryptCreateHash(Microsoft.Win32.SafeHandles.SafeBCryptAlgorithmHandle, Microsoft.Win32.SafeHandles.SafeBCryptHashHandle ByRef, IntPtr, Int32, System.ReadOnlySpan`1<Byte>, Int32, BCryptCreateHashFlags)
       mov       edi,eax
       cmp       edi,0C000000D
       jne       short M00_L12
       mov       rcx,[rbp-40]
       cmp       [rcx],ecx
       call      qword ptr [7FFB5E290298]; System.Runtime.InteropServices.SafeHandle.Dispose()
       mov       rcx,rsi
       call      qword ptr [7FFB5E814BA0]; System.Security.Cryptography.HashProviderCng.Reset()
       jmp       short M00_L13
M00_L10:
       mov       ecx,80
       test      r12b,1
       je        short M00_L11
       mov       ecx,r12d
       and       rcx,2
       movzx     ecx,byte ptr [rcx+r13]
       or        ecx,8000
M00_L11:
       test      r12b,2
       je        near ptr M00_L06
       shl       ecx,10
       movzx     edx,word ptr [r13]
       or        ecx,edx
       jmp       near ptr M00_L06
M00_L12:
       test      edi,edi
       jne       near ptr M00_L23
       lea       rcx,[rsi+10]
       mov       rdx,[rbp-40]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rsi+24],1
M00_L13:
       xor       ecx,ecx
       mov       [rbp-40],rcx
       lea       rcx,[rbx+20]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbx+20]
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       shl       eax,3
       mov       [rbx+10],eax
       mov       [rbp-0D0],rbx
       mov       rcx,1D2F9470708
       mov       rdx,rbx
       call      qword ptr [7FFB5E7BD800]; DotNetTips.Spargine.Core.Security.PasswordHasher.HashPasswordSHA(System.String, System.Security.Cryptography.HashAlgorithm)
       mov       rsi,rax
       mov       rcx,rbx
       call      qword ptr [7FFB5E814050]; System.Security.Cryptography.HashAlgorithm.Dispose()
       mov       rax,rsi
       add       rsp,0D8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L14:
       xor       ecx,ecx
       jmp       near ptr M00_L07
M00_L15:
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
       mov       ecx,eax
       jmp       near ptr M00_L07
M00_L16:
       mov       r12,[r12+8]
       test      r12,r12
       jne       near ptr M00_L08
M00_L17:
       mov       rcx,1D2F9468DD8
       xor       r8d,r8d
       xor       edx,edx
       call      qword ptr [7FFB5E7BDF20]; Interop+BCrypt.BCryptOpenAlgorithmProvider(System.String, System.String, BCryptOpenAlgorithmProviderFlags)
       mov       r15,rax
       mov       rcx,r15
       mov       rdx,1D2F94707C8
       call      qword ptr [7FFB5E7BDFF8]; Interop+BCrypt.BCryptGetDWordProperty(Microsoft.Win32.SafeHandles.SafeBCryptHandle, System.String)
       mov       rdx,1D2F9468DD8
       mov       [rbp-98],rdx
       xor       edx,edx
       mov       [rbp-90],edx
       mov       [rbp-0B8],r15
       mov       [rbp-0B0],eax
       lea       rdx,[rbp-98]
       lea       r8,[rbp-0B8]
       mov       rcx,1927A400168
       mov       rcx,[rcx]
       call      qword ptr [7FFB5E7BE070]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.ValueTuple`2[[System.__Canon, System.Private.CoreLib],[Interop+BCrypt+BCryptOpenAlgorithmProviderFlags, System.Security.Cryptography]], System.Private.CoreLib],[System.ValueTuple`2[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]], System.Private.CoreLib]].TryAdd(System.ValueTuple`2<System.__Canon,BCryptOpenAlgorithmProviderFlags>, System.ValueTuple`2<System.__Canon,Int32>)
       test      eax,eax
       jne       near ptr M00_L00
       jmp       near ptr M00_L21
M00_L18:
       vmovdqu   xmm0,xmmword ptr [rbp-50]
       vmovdqu   xmmword ptr [rbp-88],xmm0
       vmovdqu   xmm0,xmmword ptr [rbp-88]
       vmovdqu   xmmword ptr [rbp-98],xmm0
       lea       rdx,[rbp-98]
       mov       rcx,r13
       mov       r11,7FFB5E0E0A58
       call      qword ptr [r11]
       mov       r12d,eax
       mov       r8d,r12d
       mov       rdx,r15
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentDictionary<System.ValueTuple<System.String, Interop+BCrypt+BCryptOpenAlgorithmProviderFlags>, System.ValueTuple<Microsoft.Win32.SafeHandles.SafeBCryptAlgorithmHandle, System.Int32>>
       call      qword ptr [7FFB5E7BDEA8]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.ValueTuple`2[[System.__Canon, System.Private.CoreLib],[Interop+BCrypt+BCryptOpenAlgorithmProviderFlags, System.Security.Cryptography]], System.Private.CoreLib],[System.ValueTuple`2[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]], System.Private.CoreLib]].GetBucket(Tables<System.ValueTuple`2<System.__Canon,BCryptOpenAlgorithmProviderFlags>,System.ValueTuple`2<System.__Canon,Int32>>, Int32)
       mov       r15,rax
       test      r15,r15
       je        near ptr M00_L17
M00_L19:
       cmp       r12d,[r15+10]
       jne       short M00_L20
       vmovdqu   xmm0,xmmword ptr [r15+18]
       vmovdqu   xmmword ptr [rbp-98],xmm0
       vmovdqu   xmm0,xmmword ptr [rbp-50]
       vmovdqu   xmmword ptr [rbp-0A8],xmm0
       lea       r8,[rbp-0A8]
       lea       rdx,[rbp-98]
       mov       rcx,r13
       mov       r11,7FFB5E0E0A50
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L22
M00_L20:
       mov       r15,[r15+8]
       test      r15,r15
       jne       short M00_L19
       jmp       near ptr M00_L17
M00_L21:
       cmp       [r15],r15b
       mov       rcx,r15
       mov       edx,1
       call      qword ptr [7FFB5E19C768]; System.Runtime.InteropServices.SafeHandle.InternalRelease(Boolean)
       mov       rcx,r15
       call      qword ptr [7FFB5E197AE0]; System.GC.SuppressFinalize(System.Object)
       jmp       near ptr M00_L00
M00_L22:
       mov       rdx,[r15+28]
       mov       ecx,[r15+30]
       jmp       near ptr M00_L09
M00_L23:
       mov       rcx,[rbp-40]
       cmp       [rcx],ecx
       call      qword ptr [7FFB5E290298]; System.Runtime.InteropServices.SafeHandle.Dispose()
       mov       ecx,edi
       call      qword ptr [7FFB5E844E10]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
       sub       rsp,38
       mov       rcx,[rbp-0D0]
       call      qword ptr [7FFB5E814050]; System.Security.Cryptography.HashAlgorithm.Dispose()
       nop
       add       rsp,38
       ret
; Total bytes of code 1314
```
```assembly
; System.Marvin.Block(UInt32 ByRef, UInt32 ByRef)
       mov       eax,[rcx]
       mov       r8d,eax
       xor       r8d,[rdx]
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       mov       [rcx],eax
       mov       [rdx],r8d
       ret
; Total bytes of code 37
```
```assembly
; System.HashCode.Combine[[System.Int32, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](Int32, Int32)
       imul      eax,ecx,0C2B2AE3D
       add       eax,15B69B7B
       rol       eax,11
       imul      eax,27D4EB2F
       imul      ecx,edx,0C2B2AE3D
       add       eax,ecx
       rol       eax,11
       imul      eax,27D4EB2F
       mov       ecx,eax
       shr       ecx,0F
       xor       ecx,eax
       imul      eax,ecx,85EBCA77
       mov       ecx,eax
       shr       ecx,0D
       xor       ecx,eax
       imul      eax,ecx,0C2B2AE3D
       mov       ecx,eax
       shr       ecx,10
       xor       eax,ecx
       ret
; Total bytes of code 71
```
```assembly
; System.Collections.Concurrent.ConcurrentDictionary`2[[System.ValueTuple`2[[System.__Canon, System.Private.CoreLib],[Interop+BCrypt+BCryptOpenAlgorithmProviderFlags, System.Security.Cryptography]], System.Private.CoreLib],[System.ValueTuple`2[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]], System.Private.CoreLib]].GetBucket(Tables<System.ValueTuple`2<System.__Canon,BCryptOpenAlgorithmProviderFlags>,System.ValueTuple`2<System.__Canon,Int32>>, Int32)
       sub       rsp,28
       mov       rax,[rdx+10]
       mov       ecx,r8d
       imul      rcx,[rdx+28]
       shr       rcx,20
       inc       rcx
       mov       edx,[rax+8]
       mov       r8d,edx
       imul      rcx,r8
       shr       rcx,20
       cmp       ecx,edx
       jae       short M03_L00
       mov       ecx,ecx
       mov       rax,[rax+rcx*8+10]
       add       rsp,28
       ret
M03_L00:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 59
```
```assembly
; System.Collections.Generic.GenericEqualityComparer`1[[System.ValueTuple`2[[System.__Canon, System.Private.CoreLib],[Interop+BCrypt+BCryptOpenAlgorithmProviderFlags, System.Security.Cryptography]], System.Private.CoreLib]].Equals(System.ValueTuple`2<System.__Canon,BCryptOpenAlgorithmProviderFlags>, System.ValueTuple`2<System.__Canon,BCryptOpenAlgorithmProviderFlags>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rcx,[rdi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx+8]
       mov       rax,[rdx+10]
       test      rax,rax
       je        short M04_L01
M04_L00:
       mov       rcx,rbx
       mov       rdx,rsi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       rax
M04_L01:
       mov       rdx,7FFB5E805AD8
       call      qword ptr [7FFB5E19C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       short M04_L00
; Total bytes of code 75
```
```assembly
; Interop+BCrypt.BCryptCreateHash(Microsoft.Win32.SafeHandles.SafeBCryptAlgorithmHandle, Microsoft.Win32.SafeHandles.SafeBCryptHashHandle ByRef, IntPtr, Int32, System.ReadOnlySpan`1<Byte>, Int32, BCryptCreateHashFlags)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0B8
       vzeroupper
       lea       rbp,[rsp+0F0]
       xor       eax,eax
       mov       [rbp-58],rax
       mov       [rbp-60],rax
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       r14d,r9d
       lea       rcx,[rbp-0A0]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       r15,rax
       mov       rcx,rsp
       mov       [rbp-88],rcx
       mov       rcx,rbp
       mov       [rbp-78],rcx
       xor       ecx,ecx
       mov       [rbp-3C],ecx
       mov       [rbp+18],rsi
       mov       [rsi],rcx
       mov       [rbp-48],rcx
       mov       [rbp-4C],ecx
       mov       byte ptr [rbp-0A4],0
       mov       rcx,1D2F94708C8
       mov       rax,offset MT_Microsoft.Win32.SafeHandles.SafeBCryptHashHandle
       mov       eax,[rax]
       and       eax,0C0000
       cmp       eax,40000
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M05_L12
       call      qword ptr [7FFB5E197BD0]; System.RuntimeType.CreateInstanceOfT()
M05_L00:
       xor       ecx,ecx
       mov       [rbp-60],rcx
       mov       [rbp-0B0],rax
       mov       [rbp-0B8],rcx
       mov       byte ptr [rbp-0A8],0
       mov       [rbp-0B8],rbx
       mov       eax,[rbx+10]
       test      al,1
       jne       near ptr M05_L04
M05_L01:
       lea       rcx,[rbx+10]
       lea       edx,[rax+4]
       mov       [rbp-64],eax
       lock cmpxchg [rcx],edx
       cmp       eax,[rbp-64]
       jne       near ptr M05_L08
       mov       byte ptr [rbp-0A8],1
       mov       rbx,[rbp+30]
       mov       rdx,[rbx]
       mov       [rbp-58],rdx
       mov       rcx,[rbp-0B8]
       mov       rcx,[rcx+8]
       mov       ebx,[rbp+38]
       mov       [rsp+28],ebx
       mov       ebx,[rbp+40]
       mov       [rsp+30],ebx
       mov       [rsp+20],rdx
       lea       rdx,[rbp-48]
       mov       r8,rdi
       mov       r9d,r14d
       mov       rax,7FFB5E5BE2A0
       mov       [rbp-90],rax
       lea       rax,[M05_L02]
       mov       [rbp-80],rax
       lea       rax,[rbp-0A0]
       mov       [r15+8],rax
       mov       byte ptr [r15+4],0
       mov       rax,7FFCFB453EB0
       call      rax
M05_L02:
       mov       byte ptr [r15+4],1
       cmp       dword ptr [7FFBBE0E3A10],0
       je        short M05_L03
       call      qword ptr [7FFBBE0D1648]; CORINFO_HELP_STOP_FOR_GC
M05_L03:
       mov       rcx,[rbp-98]
       mov       [r15+8],rcx
       mov       [rbp-4C],eax
       xor       ecx,ecx
       mov       [rbp-58],rcx
       mov       dword ptr [rbp-3C],1
       mov       rcx,[rbp-48]
       mov       byte ptr [rbp-0A4],1
       mov       rbx,[rbp-0B0]
       mov       [rbx+8],rcx
       mov       rcx,[rbp+18]
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       near ptr M05_L11
M05_L04:
       mov       rcx,rbx
       call      qword ptr [7FFB5E19C9A8]; System.Object.GetType()
       mov       rcx,[rax+10]
       test      rcx,rcx
       je        short M05_L09
       mov       rbx,[rcx]
       test      rbx,rbx
       je        short M05_L09
M05_L05:
       mov       rsi,[rbx+20]
       test      rsi,rsi
       je        short M05_L07
M05_L06:
       mov       rcx,offset MT_System.ObjectDisposedException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFB5E846580]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M05_L07:
       mov       rcx,[rbx+8]
       call      qword ptr [7FFB5E304AE0]; System.RuntimeType.IsFullNameRoundtripCompatible(System.RuntimeType)
       test      eax,eax
       je        short M05_L10
       lea       rdx,[rbx+20]
       mov       rcx,rbx
       mov       r8d,3
       call      qword ptr [7FFB5E304AF8]; System.RuntimeType+RuntimeTypeCache.ConstructName(System.String ByRef, System.TypeNameFormatFlags)
       mov       rsi,rax
       jmp       short M05_L06
M05_L08:
       mov       eax,[rbx+10]
       test      al,1
       je        near ptr M05_L01
       jmp       short M05_L04
M05_L09:
       mov       rcx,rax
       call      qword ptr [7FFB5E197C30]; System.RuntimeType.InitializeCache()
       mov       rbx,rax
       jmp       short M05_L05
M05_L10:
       xor       esi,esi
       jmp       short M05_L06
M05_L11:
       call      M05_L13
       nop
       mov       eax,[rbp-4C]
       add       rsp,0B8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M05_L12:
       xor       edx,edx
       mov       [rbp-60],rdx
       lea       rdx,[rbp-60]
       call      qword ptr [7FFB5E8458A8]
       mov       rax,[rbp-60]
       jmp       near ptr M05_L00
       sub       rsp,38
       vzeroupper
       xor       ecx,ecx
       mov       [rbp-58],rcx
       add       rsp,38
       ret
M05_L13:
       sub       rsp,38
       vzeroupper
       cmp       dword ptr [rbp-3C],0
       je        near ptr M05_L25
       cmp       byte ptr [rbp-0A4],0
       jne       near ptr M05_L25
       mov       rbx,[rbp-0B0]
       mov       rax,offset MT_Microsoft.Win32.SafeHandles.SafeBCryptHashHandle
       cmp       [rbx],rax
       jne       near ptr M05_L23
       mov       rcx,rbx
       mov       eax,[rbx+10]
       test      al,2
       jne       near ptr M05_L22
M05_L14:
       test      eax,0FFFFFFFC
       jne       short M05_L16
       jmp       short M05_L20
M05_L15:
       mov       eax,[rbx+10]
       test      al,2
       jne       short M05_L22
       jmp       short M05_L14
M05_L16:
       mov       edx,eax
       and       edx,0FFFFFFFD
       cmp       edx,4
       jne       short M05_L17
       cmp       byte ptr [rbx+14],0
       je        short M05_L17
       cmp       qword ptr [rbx+8],0
       setne     dl
       movzx     edx,dl
       jmp       short M05_L18
M05_L17:
       xor       edx,edx
M05_L18:
       lea       r8d,[rax-4]
       mov       r10d,eax
       and       r10d,0FFFFFFFC
       cmp       r10d,4
       jne       short M05_L19
       or        r8d,1
M05_L19:
       lea       r10,[rbx+10]
       or        r8d,2
       mov       [rbp-68],eax
       lock cmpxchg [r10],r8d
       cmp       eax,[rbp-68]
       jne       short M05_L15
       jmp       short M05_L21
M05_L20:
       call      qword ptr [7FFB5E8454B8]
       int       3
M05_L21:
       test      edx,edx
       je        short M05_L22
       call      00007FFBBDE26D30
       mov       esi,eax
       mov       rcx,[rbx+8]
       call      00007FFB5E188BE8
       mov       ecx,esi
       call      00007FFBBDE26D50
M05_L22:
       mov       rcx,[rbx]
       test      dword ptr [rcx],100000
       je        short M05_L25
       jmp       short M05_L24
M05_L23:
       mov       rcx,rbx
       mov       edx,1
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       jmp       short M05_L22
M05_L24:
       mov       rcx,rbx
       call      00007FFBBDDD9E50
M05_L25:
       cmp       byte ptr [rbp-0A8],0
       je        near ptr M05_L42
       mov       rbx,[rbp-0B8]
       mov       rcx,[rbp-0B8]
       cmp       [rcx],cl
       mov       esi,[rbx+10]
       test      esi,0FFFFFFFC
       je        near ptr M05_L34
M05_L26:
       mov       ecx,esi
       and       ecx,0FFFFFFFD
       cmp       ecx,4
       jne       short M05_L31
       jmp       short M05_L28
M05_L27:
       mov       esi,[rbx+10]
       test      esi,0FFFFFFFC
       jne       short M05_L26
       jmp       short M05_L34
M05_L28:
       cmp       byte ptr [rbx+14],0
       je        short M05_L31
       mov       rcx,offset MT_Microsoft.Win32.SafeHandles.SafeBCryptHashHandle
       cmp       [rbx],rcx
       jne       short M05_L29
       cmp       qword ptr [rbx+8],0
       sete      dil
       movzx     edi,dil
       jmp       short M05_L30
M05_L29:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       edi,eax
M05_L30:
       test      edi,edi
       sete      cl
       movzx     ecx,cl
       jmp       short M05_L32
M05_L31:
       xor       ecx,ecx
M05_L32:
       lea       edx,[rsi-4]
       mov       eax,esi
       and       eax,0FFFFFFFC
       cmp       eax,4
       jne       short M05_L33
       or        edx,1
M05_L33:
       lea       r8,[rbx+10]
       mov       eax,esi
       lock cmpxchg [r8],edx
       cmp       eax,esi
       jne       short M05_L27
       jmp       near ptr M05_L39
M05_L34:
       mov       rcx,rbx
       call      qword ptr [7FFB5E19C9A8]; System.Object.GetType()
       mov       rcx,[rax+10]
       test      rcx,rcx
       je        short M05_L35
       mov       rbx,[rcx]
       test      rbx,rbx
       je        short M05_L35
       jmp       short M05_L36
M05_L35:
       mov       rcx,rax
       call      qword ptr [7FFB5E197C30]; System.RuntimeType.InitializeCache()
       mov       rbx,rax
M05_L36:
       mov       rsi,[rbx+20]
       test      rsi,rsi
       jne       short M05_L38
       mov       rcx,[rbx+8]
       call      qword ptr [7FFB5E304AE0]; System.RuntimeType.IsFullNameRoundtripCompatible(System.RuntimeType)
       test      eax,eax
       jne       short M05_L37
       xor       esi,esi
       jmp       short M05_L38
M05_L37:
       lea       rdx,[rbx+20]
       mov       rcx,rbx
       mov       r8d,3
       call      qword ptr [7FFB5E304AF8]; System.RuntimeType+RuntimeTypeCache.ConstructName(System.String ByRef, System.TypeNameFormatFlags)
       mov       rsi,rax
M05_L38:
       mov       rcx,offset MT_System.ObjectDisposedException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFB5E846580]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M05_L39:
       test      ecx,ecx
       je        short M05_L42
       call      00007FFBBDE26D30
       mov       esi,eax
       mov       rcx,offset MT_Microsoft.Win32.SafeHandles.SafeBCryptHashHandle
       cmp       [rbx],rcx
       jne       short M05_L40
       mov       rcx,[rbx+8]
       call      00007FFB5E188BE8
       jmp       short M05_L41
M05_L40:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
M05_L41:
       mov       ecx,esi
       call      00007FFBBDE26D50
M05_L42:
       nop
       add       rsp,38
       ret
; Total bytes of code 1242
```
```assembly
; System.Runtime.InteropServices.SafeHandle.Dispose()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,offset MT_Microsoft.Win32.SafeHandles.SafeBCryptHashHandle
       cmp       [rbx],rcx
       jne       short M06_L01
       mov       rcx,rbx
       mov       edx,1
       call      qword ptr [7FFB5E19C768]; System.Runtime.InteropServices.SafeHandle.InternalRelease(Boolean)
M06_L00:
       mov       rcx,rbx
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFB5E197AE0]; System.GC.SuppressFinalize(System.Object)
M06_L01:
       mov       rcx,rbx
       mov       edx,1
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       jmp       short M06_L00
; Total bytes of code 71
```
```assembly
; System.Security.Cryptography.HashProviderCng.Reset()
       push      rsi
       push      rbx
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       xor       eax,eax
       mov       [rsp+50],rax
       mov       rbx,rcx
       cmp       byte ptr [rbx+24],0
       je        short M07_L01
       cmp       byte ptr [rbx+25],0
       jne       short M07_L02
M07_L00:
       add       rsp,58
       pop       rbx
       pop       rsi
       ret
M07_L01:
       xor       edx,edx
       jmp       short M07_L03
M07_L02:
       mov       edx,20
M07_L03:
       mov       rcx,[rbx+8]
       mov       r8,[rbx+18]
       test      r8,r8
       jne       short M07_L04
       xor       r9d,r9d
       xor       r8d,r8d
       xor       eax,eax
       jmp       short M07_L05
M07_L04:
       lea       r9,[r8+10]
       mov       r8d,[r8+8]
       mov       rax,[rbx+18]
       mov       eax,[rax+8]
M07_L05:
       mov       [rsp+40],r9
       mov       [rsp+48],r8d
       mov       [rsp+28],eax
       mov       [rsp+30],edx
       lea       rdx,[rsp+40]
       mov       [rsp+20],rdx
       lea       rdx,[rsp+50]
       xor       r8d,r8d
       xor       r9d,r9d
       call      qword ptr [7FFB5E7BE3E8]; Interop+BCrypt.BCryptCreateHash(Microsoft.Win32.SafeHandles.SafeBCryptAlgorithmHandle, Microsoft.Win32.SafeHandles.SafeBCryptHashHandle ByRef, IntPtr, Int32, System.ReadOnlySpan`1<Byte>, Int32, BCryptCreateHashFlags)
       mov       esi,eax
       test      esi,esi
       je        short M07_L06
       mov       rcx,[rsp+50]
       cmp       [rcx],ecx
       call      qword ptr [7FFB5E290298]; System.Runtime.InteropServices.SafeHandle.Dispose()
       mov       ecx,esi
       call      qword ptr [7FFB5E844E10]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M07_L06:
       lea       rcx,[rbx+10]
       mov       rdx,[rsp+50]
       test      rcx,rcx
       jne       short M07_L07
       call      qword ptr [7FFB5E8454A0]
       int       3
M07_L07:
       call      00007FFBBDDD5920
       mov       rsi,rax
       test      rsi,rsi
       je        near ptr M07_L00
       mov       rcx,rsi
       mov       edx,1
       mov       rax,[7FFB5E81DAF8]
       call      qword ptr [rax+30]
       mov       rcx,rsi
       call      qword ptr [7FFB5E197AE0]; System.GC.SuppressFinalize(System.Object)
       jmp       near ptr M07_L00
; Total bytes of code 243
```
```assembly
; DotNetTips.Spargine.Core.Security.PasswordHasher.HashPasswordSHA(System.String, System.Security.Cryptography.HashAlgorithm)
; 		var hash = algorithm.ComputeHash(Encoding.UTF8.GetBytes(password));
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rbx
       sub       rsp,20
       mov       rax,rcx
       mov       rbx,rdx
       mov       rcx,19264400220
       mov       rcx,[rcx]
       test      rax,rax
       je        short M08_L00
       cmp       dword ptr [rax+8],20
       jle       short M08_L02
M08_L00:
       mov       rdx,rax
       call      qword ptr [7FFB5E1CF860]; System.Text.Encoding.GetBytes(System.String)
M08_L01:
       mov       rcx,rbx
       mov       rdx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFB5E7BE460]; System.Security.Cryptography.HashAlgorithm.ComputeHash(Byte[])
       mov       rcx,rax
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFB5E5A4378]; System.Convert.ToBase64String(Byte[])
M08_L02:
       mov       rdx,rax
       call      qword ptr [7FFB5E6AF7B0]; System.Text.UTF8Encoding+UTF8EncodingSealed.GetBytesForSmallInput(System.String)
       jmp       short M08_L01
; Total bytes of code 83
```
```assembly
; System.Security.Cryptography.HashAlgorithm.Dispose()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,offset MT_System.Security.Cryptography.SHA256+Implementation
       cmp       [rbx],rcx
       jne       near ptr M09_L05
       mov       rsi,[rbx+20]
       mov       rcx,offset MT_System.Security.Cryptography.HashProviderCng
       cmp       [rsi],rcx
       jne       short M09_L03
       mov       rdi,[rsi+10]
       cmp       [rdi],dil
       mov       rcx,rdi
       mov       edx,1
       call      qword ptr [7FFB5E19C768]; System.Runtime.InteropServices.SafeHandle.InternalRelease(Boolean)
       mov       rcx,[rdi]
       test      dword ptr [rcx],100000
       je        short M09_L00
       mov       rcx,rdi
       call      00007FFBBDDD9E50
M09_L00:
       cmp       qword ptr [rsi+18],0
       jne       short M09_L04
M09_L01:
       mov       byte ptr [rbx+18],1
M09_L02:
       mov       rcx,rbx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFB5E197AE0]; System.GC.SuppressFinalize(System.Object)
M09_L03:
       mov       rcx,rsi
       mov       edx,1
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       jmp       short M09_L01
M09_L04:
       mov       rcx,[rsi+18]
       xor       eax,eax
       mov       [rsi+18],rax
       call      qword ptr [7FFB5E8461A8]
       jmp       short M09_L01
M09_L05:
       mov       rcx,rbx
       mov       edx,1
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       jmp       short M09_L02
; Total bytes of code 173
```
```assembly
; Interop+BCrypt.BCryptOpenAlgorithmProvider(System.String, System.String, BCryptOpenAlgorithmProviderFlags)
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       r9,rcx
       mov       rax,rdx
       mov       r10d,r8d
       lea       rcx,[rsp+28]
       mov       rdx,r9
       mov       r8,rax
       mov       r9d,r10d
       call      qword ptr [7FFBBAE6CD28]
       mov       ebx,eax
       test      ebx,ebx
       jne       short M10_L00
       mov       rax,[rsp+28]
       add       rsp,30
       pop       rbx
       ret
M10_L00:
       mov       rcx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FFBBAE6B8B8]; Precode of System.Runtime.InteropServices.SafeHandle.Dispose()
       mov       ecx,ebx
       call      qword ptr [7FFBBAE6CDB8]
       mov       rcx,rax
       call      qword ptr [7FFBBAE69348]; CORINFO_HELP_THROW
       int       3
; Total bytes of code 89
```
```assembly
; Interop+BCrypt.BCryptGetDWordProperty(Microsoft.Win32.SafeHandles.SafeBCryptHandle, System.String)
       push      rbx
       sub       rsp,40
       xor       r8d,r8d
       mov       [rsp+38],r8d
       lea       r8,[rsp+30]
       mov       [rsp+20],r8
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+38]
       mov       r9d,4
       call      qword ptr [7FFBBAE6CCE0]
       mov       ecx,eax
       test      ecx,ecx
       jne       short M11_L00
       cmp       dword ptr [rsp+30],4
       jne       short M11_L01
       mov       eax,[rsp+38]
       add       rsp,40
       pop       rbx
       ret
M11_L00:
       call      qword ptr [7FFBBAE6CDB8]
       mov       rcx,rax
       call      qword ptr [7FFBBAE69348]; CORINFO_HELP_THROW
       int       3
M11_L01:
       call      qword ptr [7FFBBAE69BC8]
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBBAE6B648]
       mov       rcx,rbx
       call      qword ptr [7FFBBAE69348]; CORINFO_HELP_THROW
       int       3
; Total bytes of code 115
```
```assembly
; System.Collections.Concurrent.ConcurrentDictionary`2[[System.ValueTuple`2[[System.__Canon, System.Private.CoreLib],[Interop+BCrypt+BCryptOpenAlgorithmProviderFlags, System.Security.Cryptography]], System.Private.CoreLib],[System.ValueTuple`2[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]], System.Private.CoreLib]].TryAdd(System.ValueTuple`2<System.__Canon,BCryptOpenAlgorithmProviderFlags>, System.ValueTuple`2<System.__Canon,Int32>)
       push      rbp
       sub       rsp,80
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-40],ymm4
       vmovdqu   ymmword ptr [rbp-20],ymm4
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       rax,[rbp+10]
       mov       rax,[rax+8]
       mov       [rbp-20],rax
       xor       eax,eax
       mov       [rbp-18],rax
       mov       rax,[rbp+18]
       vmovdqu   xmm0,xmmword ptr [rax]
       vmovdqu   xmmword ptr [rbp-30],xmm0
       mov       rax,[rbp+20]
       vmovdqu   xmm0,xmmword ptr [rax]
       vmovdqu   xmmword ptr [rbp-40],xmm0
       xor       eax,eax
       mov       [rsp+28],eax
       mov       dword ptr [rsp+30],1
       lea       rax,[rbp-10]
       mov       [rsp+38],rax
       lea       r8,[rbp-30]
       lea       rax,[rbp-40]
       mov       [rsp+20],rax
       mov       rcx,[rbp+10]
       mov       r9,[rbp-18]
       mov       rdx,[rbp-20]
       call      qword ptr [7FFB5E7BE088]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.ValueTuple`2[[System.__Canon, System.Private.CoreLib],[Interop+BCrypt+BCryptOpenAlgorithmProviderFlags, System.Security.Cryptography]], System.Private.CoreLib],[System.ValueTuple`2[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]], System.Private.CoreLib]].TryAddInternal(Tables<System.ValueTuple`2<System.__Canon,BCryptOpenAlgorithmProviderFlags>,System.ValueTuple`2<System.__Canon,Int32>>, System.ValueTuple`2<System.__Canon,BCryptOpenAlgorithmProviderFlags>, System.Nullable`1<Int32>, System.ValueTuple`2<System.__Canon,Int32>, Boolean, Boolean, System.ValueTuple`2<System.__Canon,Int32> ByRef)
       nop
       add       rsp,80
       pop       rbp
       ret
; Total bytes of code 150
```
```assembly
; System.Runtime.InteropServices.SafeHandle.InternalRelease(Boolean)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,58
       vzeroupper
       lea       rbp,[rsp+90]
       mov       rbx,rcx
       mov       esi,edx
       lea       rcx,[rbp-70]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rdi,rax
       mov       rcx,rsp
       mov       [rbp-58],rcx
       mov       rcx,rbp
       mov       [rbp-48],rcx
M13_L00:
       mov       r14d,[rbx+10]
       test      sil,sil
       je        short M13_L01
       test      r14b,2
       jne       near ptr M13_L09
M13_L01:
       mov       r15d,r14d
       and       r15d,0FFFFFFFC
       je        near ptr M13_L11
       mov       ecx,r14d
       and       ecx,0FFFFFFFD
       cmp       ecx,4
       jne       near ptr M13_L10
       cmp       byte ptr [rbx+14],0
       je        near ptr M13_L10
       mov       rcx,offset MT_Microsoft.Win32.SafeHandles.SafeBCryptHashHandle
       cmp       [rbx],rcx
       jne       near ptr M13_L17
       cmp       qword ptr [rbx+8],0
       sete      r13b
       movzx     r13d,r13b
M13_L02:
       test      r13d,r13d
       sete      cl
       movzx     ecx,cl
M13_L03:
       lea       edx,[r14-4]
       cmp       r15d,4
       jne       short M13_L04
       or        edx,1
M13_L04:
       test      sil,sil
       je        short M13_L05
       or        edx,2
M13_L05:
       lea       r8,[rbx+10]
       mov       eax,r14d
       lock cmpxchg [r8],edx
       cmp       eax,r14d
       jne       near ptr M13_L00
       test      ecx,ecx
       je        short M13_L09
       call      00007FFBBDE26D30
       mov       esi,eax
       mov       rcx,offset MT_Microsoft.Win32.SafeHandles.SafeBCryptHashHandle
       cmp       [rbx],rcx
       jne       near ptr M13_L19
       mov       rcx,[rbx+8]
       mov       rax,7FFB5E5BDAA0
       mov       [rbp-60],rax
       lea       rax,[M13_L06]
       mov       [rbp-50],rax
       lea       rax,[rbp-70]
       mov       [rdi+8],rax
       mov       byte ptr [rdi+4],0
       mov       rax,7FFCFB453C80
       call      rax
M13_L06:
       mov       byte ptr [rdi+4],1
       cmp       dword ptr [7FFBBE0E3A10],0
       je        short M13_L07
       call      qword ptr [7FFBBE0D1648]; CORINFO_HELP_STOP_FOR_GC
M13_L07:
       mov       rcx,[rbp-68]
       mov       [rdi+8],rcx
M13_L08:
       mov       ecx,esi
       call      00007FFBBDE26D50
M13_L09:
       nop
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M13_L10:
       xor       ecx,ecx
       jmp       near ptr M13_L03
M13_L11:
       mov       rcx,rbx
       call      qword ptr [7FFB5E19C9A8]; System.Object.GetType()
       cmp       qword ptr [rax+10],0
       je        short M13_L12
       mov       rcx,[rax+10]
       mov       rbx,[rcx]
       test      rbx,rbx
       jne       short M13_L15
M13_L12:
       mov       rcx,rax
       call      qword ptr [7FFB5E197C30]; System.RuntimeType.InitializeCache()
       mov       rsi,rax
M13_L13:
       mov       rbx,[rsi+20]
       test      rbx,rbx
       je        short M13_L16
M13_L14:
       mov       rcx,offset MT_System.ObjectDisposedException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFB5E846580]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M13_L15:
       mov       rsi,rbx
       jmp       short M13_L13
M13_L16:
       mov       rcx,[rsi+8]
       call      qword ptr [7FFB5E304AE0]; System.RuntimeType.IsFullNameRoundtripCompatible(System.RuntimeType)
       test      eax,eax
       je        short M13_L18
       lea       rdx,[rsi+20]
       mov       rcx,rsi
       mov       r8d,3
       call      qword ptr [7FFB5E304AF8]; System.RuntimeType+RuntimeTypeCache.ConstructName(System.String ByRef, System.TypeNameFormatFlags)
       mov       rbx,rax
       jmp       short M13_L14
M13_L17:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       r13d,eax
       jmp       near ptr M13_L02
M13_L18:
       xor       ebx,ebx
       jmp       short M13_L14
M13_L19:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       jmp       near ptr M13_L08
; Total bytes of code 514
```
```assembly
; System.GC.SuppressFinalize(System.Object)
       sub       rsp,28
       test      rcx,rcx
       je        short M14_L01
       mov       rax,[rcx]
       test      dword ptr [rax],100000
       je        short M14_L00
       add       rsp,28
       jmp       near ptr 00007FFBBDDD9E50
M14_L00:
       add       rsp,28
       ret
M14_L01:
       mov       ecx,707
       mov       rdx,7FFB5E0D4000
       call      qword ptr [7FFB5E3B77B0]
       mov       rcx,rax
       call      qword ptr [7FFB5E844D08]
       int       3
; Total bytes of code 65
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Security.PasswordHasherBenchmark.HashPasswordSHA3256()
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       lea       rbp,[rsp+0B0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-70],ymm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       xor       eax,eax
       mov       [rbp-40],rax
       mov       rcx,offset MT_Org.BouncyCastle.Crypto.Digests.Sha3Digest
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,offset MT_System.UInt64[]
       mov       edx,19
       call      CORINFO_HELP_NEWARR_1_PTR
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Byte[]
       mov       edx,0C0
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rbx+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+18],440
       mov       rcx,[rbx+8]
       mov       rdx,rcx
       mov       ecx,[rcx+8]
       lea       rax,[rdx+10]
       xor       r8d,r8d
       mov       r10,[rdx]
       cmp       dword ptr [r10+4],18
       jne       near ptr M00_L05
M00_L00:
       mov       r9d,r8d
       neg       r9d
       test      r8d,r8d
       jg        near ptr M00_L06
       test      r9d,r9d
       jl        near ptr M00_L06
       lea       r8d,[r9+rcx]
       cmp       r8d,[rdx+8]
       ja        near ptr M00_L06
       movzx     edx,word ptr [r10]
       mov       r8d,r9d
       imul      r8,rdx
       add       r8,rax
       mov       ecx,ecx
       imul      rdx,rcx
       test      dword ptr [r10],1000000
       jne       near ptr M00_L07
       mov       rcx,r8
       call      qword ptr [7FFB5E1857E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
M00_L01:
       mov       rdx,[rbx+10]
       test      rdx,rdx
       je        near ptr M00_L08
       lea       rcx,[rdx+10]
       mov       edx,[rdx+8]
       xor       r8d,r8d
       call      qword ptr [7FFB5E7AD7D0]; System.SpanHelpers.Fill[[System.Byte, System.Private.CoreLib]](Byte ByRef, UIntPtr, Byte)
       xor       r8d,r8d
       mov       [rbx+1C],r8d
       mov       byte ptr [rbx+24],0
       mov       dword ptr [rbx+20],100
       mov       r8,19C18400220
       mov       rsi,[r8]
       mov       rdi,1DCAD5406E0
       add       rdi,0C
       mov       r14,rdi
       lea       r8,[rbp-30]
       lea       r9,[rbp-38]
       mov       rcx,r14
       mov       edx,40
       call      qword ptr [7FFB5E18FAF8]; System.Text.Unicode.Utf16Utility.GetPointerToFirstInvalidChar(Char*, Int32, Int64 ByRef, Int32 ByRef)
       sub       rax,r14
       mov       r9,rax
       shr       r9,3F
       add       r9,rax
       sar       r9,1
       movsxd    r15,r9d
       add       r15,[rbp-30]
       cmp       r15,7FFFFFFF
       ja        near ptr M00_L10
       cmp       r9d,40
       jne       near ptr M00_L09
M00_L02:
       movsxd    rdx,r15d
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
       mov       r15d,[r14+8]
       test      r15d,r15d
       jl        near ptr M00_L11
       mov       rdx,rdi
       mov       [rbp-40],r14
       test      r15d,r15d
       je        near ptr M00_L12
       lea       r9,[r14+10]
M00_L03:
       mov       [rsp+20],r15d
       mov       dword ptr [rsp+28],1
       mov       rcx,rsi
       mov       r8d,40
       call      qword ptr [7FFB5EA541E0]; System.Text.UTF8Encoding.GetBytesCommon(Char*, Int32, Byte*, Int32, Boolean)
       xor       ecx,ecx
       mov       [rbp-40],rcx
       mov       rdx,r14
       mov       r9d,r15d
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-60],xmm0
       lea       rcx,[rbp-60]
       xor       r8d,r8d
       call      qword ptr [7FFB5EA541F8]; System.Span`1[[System.Byte, System.Private.CoreLib]]..ctor(Byte[], Int32, Int32)
       vmovdqu   xmm0,xmmword ptr [rbp-60]
       vmovdqu   xmmword ptr [rbp-70],xmm0
       lea       rdx,[rbp-70]
       lea       rcx,[rbp-50]
       call      qword ptr [7FFB5E59CB28]; System.Span`1[[System.Byte, System.Private.CoreLib]].op_Implicit(System.Span`1<Byte>)
       lea       rdx,[rbp-50]
       mov       rcx,rbx
       call      qword ptr [7FFB5E7AD878]; Org.BouncyCastle.Crypto.Digests.KeccakDigest.Absorb(System.ReadOnlySpan`1<Byte>)
       mov       esi,[rbx+20]
       sar       esi,3
       mov       rcx,19C18402150
       mov       rcx,[rcx]
       mov       edx,esi
       call      qword ptr [7FFB5E7B08F0]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Rent(Int32)
       mov       [rbp-78],rax
       mov       rcx,rbx
       mov       rdx,[rbp-78]
       xor       r8d,r8d
       call      qword ptr [7FFB5E802D10]; Org.BouncyCastle.Crypto.Digests.Sha3Digest.DoFinal(Byte[], Int32)
       mov       rcx,[rbp-78]
       mov       r8d,esi
       xor       edx,edx
       xor       r9d,r9d
       call      qword ptr [7FFB5E8F6298]; System.Convert.ToBase64String(Byte[], Int32, Int32, System.Base64FormattingOptions)
       mov       rbx,rax
       jmp       short M00_L04
       int       3
M00_L04:
       mov       rcx,19C18401E28
       mov       rcx,[rcx]
       mov       rdx,[rbp-78]
       mov       r8d,1
       call      qword ptr [7FFB5E7B08F8]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Return(Byte[], Boolean)
       mov       rax,rbx
       add       rsp,88
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L05:
       mov       r9d,[r10+4]
       add       r9d,0FFFFFFE8
       shr       r9d,3
       movsxd    r8,r9d
       mov       r8d,[rax+r8*4]
       shl       r9d,3
       movsxd    r9,r9d
       add       rax,r9
       jmp       near ptr M00_L00
M00_L06:
       call      qword ptr [7FFB5E8FE808]
       int       3
M00_L07:
       shr       rdx,3
       mov       rcx,r8
       call      qword ptr [7FFB5E8FE820]
       jmp       near ptr M00_L01
M00_L08:
       mov       ecx,2
       call      qword ptr [7FFB5E3AC240]
       int       3
M00_L09:
       mov       rcx,rsi
       mov       rdx,r14
       mov       r8d,40
       call      qword ptr [7FFB5E8FDF80]
       add       r15d,eax
       jns       near ptr M00_L02
M00_L10:
       call      qword ptr [7FFB5E71E880]
       int       3
M00_L11:
       mov       ecx,0B
       xor       edx,edx
       call      qword ptr [7FFB5E7166B8]
       int       3
M00_L12:
       xor       r9d,r9d
       jmp       near ptr M00_L03
       sub       rsp,38
       mov       rcx,19C18401E28
       mov       rcx,[rcx]
       mov       rdx,[rcx]
       mov       rdx,[rbp-78]
       mov       r8d,1
       call      qword ptr [7FFB5E7B08F8]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Return(Byte[], Boolean)
       add       rsp,38
       ret
; Total bytes of code 828
```
```assembly
; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
       push      rbx
       test      rdx,rdx
       je        short M01_L03
       lea       rbx,[rcx+rdx]
       cmp       rdx,10
       jbe       short M01_L05
       cmp       rdx,40
       jbe       short M01_L04
       cmp       rdx,400
       ja        near ptr M01_L09
       cmp       rdx,100
       jae       near ptr M01_L08
M01_L00:
       mov       rax,rdx
       shr       rax,6
M01_L01:
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       dec       rax
       jne       short M01_L01
       and       rdx,3F
       cmp       rdx,10
       ja        short M01_L04
M01_L02:
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rbx-10],xmm0
M01_L03:
       pop       rbx
       ret
M01_L04:
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rcx],xmm0
       cmp       rdx,20
       jbe       short M01_L02
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rcx+10],xmm0
       cmp       rdx,30
       jbe       short M01_L02
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rcx+20],xmm0
       jmp       short M01_L02
M01_L05:
       test      dl,18
       je        short M01_L06
       xor       eax,eax
       mov       [rcx],rax
       mov       [rbx-8],rax
       jmp       short M01_L03
M01_L06:
       test      dl,4
       je        short M01_L07
       xor       eax,eax
       mov       [rcx],eax
       mov       [rbx-4],eax
       jmp       short M01_L03
M01_L07:
       mov       byte ptr [rcx],0
       test      dl,2
       je        short M01_L03
       mov       word ptr [rbx-2],0
       jmp       short M01_L03
M01_L08:
       mov       rax,rcx
       and       rax,3F
       neg       rax
       add       rax,40
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,rax
       sub       rdx,rax
       jmp       near ptr M01_L00
M01_L09:
       cmp       [rcx],cl
       pop       rbx
       jmp       qword ptr [7FFB5E8FDC50]
; Total bytes of code 231
```
```assembly
; System.SpanHelpers.Fill[[System.Byte, System.Private.CoreLib]](Byte ByRef, UIntPtr, Byte)
       cmp       rdx,20
       jb        short M02_L05
       vmovd     xmm0,r8d
       vpbroadcastb ymm0,xmm0
       mov       r8,rdx
       and       r8,0FFFFFFFFFFFFFFC0
       xor       eax,eax
       cmp       rdx,40
       jb        short M02_L01
M02_L00:
       vmovups   [rcx+rax],ymm0
       vmovups   [rcx+rax+20],ymm0
       add       rax,40
       cmp       rax,r8
       jb        short M02_L00
M02_L01:
       test      dl,20
       jne       short M02_L04
M02_L02:
       vmovups   [rcx+rdx-20],ymm0
M02_L03:
       vzeroupper
       ret
M02_L04:
       vmovups   [rcx+rax],ymm0
       jmp       short M02_L02
M02_L05:
       xor       eax,eax
       cmp       rdx,8
       jb        short M02_L07
       mov       r10,rdx
       and       r10,0FFFFFFFFFFFFFFF8
M02_L06:
       mov       [rcx+rax],r8b
       mov       [rcx+rax+1],r8b
       mov       [rcx+rax+2],r8b
       mov       [rcx+rax+3],r8b
       mov       [rcx+rax+4],r8b
       mov       [rcx+rax+5],r8b
       mov       [rcx+rax+6],r8b
       mov       [rcx+rax+7],r8b
       add       rax,8
       cmp       rax,r10
       jb        short M02_L06
M02_L07:
       test      dl,4
       je        short M02_L08
       mov       [rcx+rax],r8b
       mov       [rcx+rax+1],r8b
       mov       [rcx+rax+2],r8b
       mov       [rcx+rax+3],r8b
       add       rax,4
M02_L08:
       test      dl,2
       je        short M02_L09
       mov       [rcx+rax],r8b
       mov       [rcx+rax+1],r8b
       add       rax,2
M02_L09:
       test      dl,1
       je        short M02_L03
       mov       [rcx+rax],r8b
       jmp       near ptr M02_L03
; Total bytes of code 196
```
```assembly
; System.Text.Unicode.Utf16Utility.GetPointerToFirstInvalidChar(Char*, Int32, Int64 ByRef, Int32 ByRef)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       mov       rax,rcx
       mov       r10d,edx
       mov       r11,rax
       cmp       r10,20
       jae       near ptr M03_L09
       cmp       r10,10
       jae       near ptr M03_L07
M03_L00:
       cmp       r10,4
       jb        short M03_L02
M03_L01:
       mov       r11d,[rax]
       mov       ebx,[rax+4]
       mov       esi,r11d
       or        esi,ebx
       test      esi,0FF80FF80
       jne       near ptr M03_L12
       add       rax,8
       add       r10,0FFFFFFFFFFFFFFFC
       cmp       r10,4
       jae       short M03_L01
M03_L02:
       test      r10b,2
       je        short M03_L03
       mov       r11d,[rax]
       test      r11d,0FF80FF80
       jne       near ptr M03_L13
       add       rax,4
M03_L03:
       test      r10b,1
       je        short M03_L05
       cmp       word ptr [rax],7F
       ja        short M03_L05
M03_L04:
       add       rax,2
M03_L05:
       sub       rax,rcx
       shr       rax,1
       mov       r10d,eax
       lea       rcx,[rcx+r10*2]
       sub       edx,eax
       jne       near ptr M03_L15
       xor       edx,edx
       mov       [r8],rdx
       mov       [r9],edx
M03_L06:
       mov       rax,rcx
       vzeroupper
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M03_L07:
       vbroadcastss xmm0,dword ptr [7FFB5E9A4960]
       vptest    xmm0,xmmword ptr [rax]
       jne       near ptr M03_L00
       lea       rbx,[r11+r10*2-10]
       add       r11,10
       mov       rax,r11
       and       rax,0FFFFFFFFFFFFFFF0
       vpand     xmm1,xmm0,[rax]
       vptest    xmm1,xmm1
       jne       short M03_L11
M03_L08:
       add       rax,10
       cmp       rax,rbx
       ja        short M03_L11
       vpand     xmm1,xmm0,[rax]
       vptest    xmm1,xmm1
       jne       short M03_L11
       jmp       short M03_L08
M03_L09:
       vbroadcastss ymm0,dword ptr [7FFB5E9A4960]
       vptest    ymm0,ymmword ptr [rax]
       jne       near ptr M03_L00
       lea       rbx,[r11+r10*2-20]
       lea       rax,[r11+20]
       and       rax,0FFFFFFFFFFFFFFE0
       vpand     ymm1,ymm0,[rax]
       vptest    ymm1,ymm1
       jne       short M03_L11
M03_L10:
       add       rax,20
       cmp       rax,rbx
       ja        short M03_L11
       vpand     ymm1,ymm0,[rax]
       vptest    ymm1,ymm1
       je        short M03_L10
M03_L11:
       mov       r11,rax
       sub       r11,rcx
       shr       r11,1
       sub       r10,r11
       jmp       near ptr M03_L00
M03_L12:
       test      r11d,0FF80FF80
       je        short M03_L14
M03_L13:
       test      r11d,0FF80
       jne       near ptr M03_L05
       jmp       near ptr M03_L04
M03_L14:
       mov       r11d,ebx
       add       rax,4
       jmp       short M03_L13
M03_L15:
       xor       eax,eax
       xor       r10d,r10d
       mov       r11d,edx
       lea       r11,[rcx+r11*2]
       cmp       edx,8
       jl        near ptr M03_L20
       vbroadcastss xmm0,dword ptr [7FFB5E9A4964]
       lea       rdx,[r11-10]
M03_L16:
       vmovups   xmm1,[rcx]
       add       rcx,10
       vpaddusw  xmm2,xmm1,xmm0
       vpminuw   xmm3,xmm1,[7FFB5E9A4970]
       vpor      xmm2,xmm2,xmm3
       vpmovmskb ebx,xmm2
       popcnt    ebx,ebx
       vpaddw    xmm2,xmm1,[7FFB5E9A4980]
       vpcmpgtw  xmm2,xmm0,xmm2
       vpmovmskb esi,xmm2
M03_L17:
       cmp       esi,0FFFF
       je        short M03_L19
       not       esi
       vpsrlw    xmm2,xmm1,3
       vpmovmskb edi,xmm2
       mov       ebp,edi
       and       ebp,esi
       xor       edi,5555
       and       esi,edi
       shl       esi,2
       movzx     edi,si
       cmp       edi,ebp
       jne       near ptr M03_L22
       cmp       esi,0FFFF
       jbe       short M03_L18
       movzx     esi,si
       add       rbx,0FFFFFFFFFFFFFFFE
       add       rcx,0FFFFFFFFFFFFFFFE
M03_L18:
       popcnt    esi,esi
       sub       r10d,esi
       sub       rax,rsi
       sub       rax,rsi
       mov       esi,0FFFF
       jmp       short M03_L17
M03_L19:
       add       rax,rbx
       cmp       rcx,rdx
       jbe       near ptr M03_L16
M03_L20:
       cmp       rcx,r11
       jae       short M03_L23
       movzx     edx,word ptr [rcx]
       cmp       edx,7F
       jbe       short M03_L21
       lea       ebx,[rdx+1F800]
       shr       ebx,10
       add       rax,rbx
       add       edx,0FFFF2800
       cmp       edx,7FF
       ja        short M03_L21
       add       rax,0FFFFFFFFFFFFFFFE
       mov       rdx,r11
       sub       rdx,rcx
       cmp       rdx,4
       jb        short M03_L23
       mov       edx,[rcx]
       add       edx,23FF2800
       test      edx,0FC00FC00
       jne       short M03_L23
       dec       r10d
       add       rax,2
       add       rcx,2
M03_L21:
       add       rcx,2
       jmp       short M03_L20
M03_L22:
       add       rcx,0FFFFFFFFFFFFFFF0
       jmp       short M03_L20
M03_L23:
       mov       [r8],rax
       mov       [r9],r10d
       jmp       near ptr M03_L06
; Total bytes of code 628
```
```assembly
; System.Text.UTF8Encoding.GetBytesCommon(Char*, Int32, Byte*, Int32, Boolean)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,58
       lea       rbp,[rsp+80]
       mov       r14,rcx
       mov       rbx,rdx
       mov       esi,r8d
       mov       rdi,r9
       cmp       [r14],r14b
       lea       rcx,[rbp-30]
       mov       [rsp+20],rcx
       lea       rcx,[rbp-38]
       mov       [rsp+28],rcx
       mov       rcx,rbx
       mov       edx,esi
       mov       r8,rdi
       mov       r9d,[rbp+30]
       call      qword ptr [7FFB5E18FB28]; System.Text.Unicode.Utf8Utility.TranscodeToUtf8(Char*, Int32, Byte*, Int32, Char* ByRef, Byte* ByRef)
       mov       rcx,[rbp-30]
       sub       rcx,rbx
       mov       rdx,rcx
       shr       rdx,3F
       add       rcx,rdx
       sar       rcx,1
       mov       eax,[rbp-38]
       sub       eax,edi
       cmp       ecx,esi
       jne       short M04_L00
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M04_L00:
       mov       r15d,[rbp+30]
       mov       [rsp+20],r15d
       mov       [rsp+28],ecx
       mov       [rsp+30],eax
       movzx     ecx,byte ptr [rbp+38]
       mov       [rsp+38],ecx
       mov       rcx,r14
       mov       rdx,rbx
       mov       r8d,esi
       mov       r9,rdi
       call      qword ptr [7FFB5E8FE1D8]
       nop
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 170
```
```assembly
; System.Span`1[[System.Byte, System.Private.CoreLib]]..ctor(Byte[], Int32, Int32)
       sub       rsp,28
       test      rdx,rdx
       je        short M05_L01
       mov       r8d,r8d
       mov       eax,r9d
       add       rax,r8
       mov       r10d,[rdx+8]
       cmp       rax,r10
       ja        short M05_L02
       add       rdx,10
       add       rdx,r8
       mov       [rcx],rdx
       mov       [rcx+8],r9d
M05_L00:
       add       rsp,28
       ret
M05_L01:
       or        r8d,r9d
       jne       short M05_L02
       xor       eax,eax
       mov       [rcx],rax
       mov       [rcx+8],rax
       jmp       short M05_L00
M05_L02:
       call      qword ptr [7FFB5E2F7198]
       int       3
; Total bytes of code 69
```
```assembly
; System.Span`1[[System.Byte, System.Private.CoreLib]].op_Implicit(System.Span`1<Byte>)
       mov       rax,[rdx]
       mov       edx,[rdx+8]
       mov       [rcx],rax
       mov       [rcx+8],edx
       mov       rax,rcx
       ret
; Total bytes of code 16
```
```assembly
; Org.BouncyCastle.Crypto.Digests.KeccakDigest.Absorb(System.ReadOnlySpan`1<Byte>)
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+20],rax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rsi,rdx
       mov       eax,[rbx+1C]
       test      al,7
       jne       short M07_L02
       cmp       byte ptr [rbx+24],0
       jne       near ptr M07_L03
       sar       eax,3
       mov       edi,[rbx+18]
       sar       edi,3
       mov       ebp,[rsi+8]
       mov       r14d,ebp
       mov       r15d,edi
       sub       r15d,eax
       cmp       r14d,r15d
       jge       near ptr M07_L05
       mov       r8,[rbx+10]
       test      r8,r8
       je        near ptr M07_L04
       mov       edi,[r8+8]
       cmp       edi,eax
       jb        near ptr M07_L10
       mov       ecx,eax
       lea       rcx,[r8+rcx+10]
       sub       edi,eax
M07_L00:
       cmp       ebp,edi
       jg        near ptr M07_L14
       mov       rdx,[rsi]
       mov       r8d,ebp
       call      qword ptr [7FFB5E185818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       shl       r14d,3
       add       [rbx+1C],r14d
M07_L01:
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M07_L02:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,301BD
       mov       rdx,7FFB5E802020
       call      qword ptr [7FFB5E3A77B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB5E506088]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M07_L03:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,2F7BF
       mov       rdx,7FFB5E802020
       call      qword ptr [7FFB5E3A77B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB5E506088]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M07_L04:
       test      eax,eax
       jne       near ptr M07_L10
       xor       ecx,ecx
       xor       edi,edi
       jmp       near ptr M07_L00
M07_L05:
       xor       r13d,r13d
       test      eax,eax
       jle       near ptr M07_L09
       cmp       r15d,ebp
       ja        near ptr M07_L10
       mov       rdx,[rsi]
       mov       r8,[rbx+10]
       test      r8,r8
       je        near ptr M07_L10
       mov       ecx,[r8+8]
       cmp       ecx,eax
       jb        near ptr M07_L10
       mov       r10d,eax
       lea       r8,[r8+r10+10]
       sub       ecx,eax
       mov       rax,r8
       cmp       r15d,ecx
       ja        near ptr M07_L14
       mov       r8d,r15d
       mov       rcx,rax
       call      qword ptr [7FFB5E185818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r13d,r15d
       mov       rdx,[rbx+10]
       test      rdx,rdx
       jne       short M07_L06
       xor       ecx,ecx
       xor       edx,edx
       jmp       short M07_L07
M07_L06:
       lea       rcx,[rdx+10]
       mov       edx,[rdx+8]
M07_L07:
       mov       [rsp+20],rcx
       mov       [rsp+28],edx
       lea       rdx,[rsp+20]
       mov       rcx,rbx
       call      qword ptr [7FFB5E7AD8C0]
       jmp       short M07_L09
M07_L08:
       mov       edx,[rsi+8]
       sub       edx,r13d
       mov       ecx,r13d
       mov       eax,edx
       add       rcx,rax
       mov       eax,[rsi+8]
       cmp       rcx,rax
       ja        short M07_L10
       mov       ecx,r13d
       add       rcx,[rsi]
       mov       [rsp+20],rcx
       mov       [rsp+28],edx
       lea       rdx,[rsp+20]
       mov       rcx,rbx
       call      qword ptr [7FFB5E7AD8C0]
       add       r13d,edi
M07_L09:
       mov       ebp,r14d
       sub       ebp,r13d
       cmp       ebp,edi
       jge       short M07_L08
       mov       r8d,[rsi+8]
       sub       r8d,r13d
       mov       ecx,r13d
       mov       edx,r8d
       add       rcx,rdx
       mov       edx,[rsi+8]
       cmp       rcx,rdx
       jbe       short M07_L11
M07_L10:
       call      qword ptr [7FFB5E2F7198]
       int       3
M07_L11:
       mov       edx,r13d
       add       rdx,[rsi]
       mov       rcx,[rbx+10]
       test      rcx,rcx
       jne       short M07_L12
       xor       eax,eax
       xor       ecx,ecx
       jmp       short M07_L13
M07_L12:
       lea       rax,[rcx+10]
       mov       ecx,[rcx+8]
M07_L13:
       cmp       r8d,ecx
       ja        short M07_L14
       mov       r8d,r8d
       mov       rcx,rax
       call      qword ptr [7FFB5E185818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       shl       ebp,3
       mov       [rbx+1C],ebp
       jmp       near ptr M07_L01
M07_L14:
       call      qword ptr [7FFB5E59D188]
       int       3
; Total bytes of code 583
```
```assembly
; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Rent(Int32)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       rsi,rcx
       mov       ebx,edx
       mov       rcx,19C18400C90
       mov       rdi,[rcx]
       lea       ecx,[rbx-1]
       or        ecx,0F
       xor       ebp,ebp
       lzcnt     ebp,ecx
       xor       ebp,1F
       add       ebp,0FFFFFFFD
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],9
       jle       short M08_L02
       mov       rcx,[rcx+240]
       mov       rax,[rcx+48]
       test      rax,rax
       je        short M08_L02
M08_L00:
       mov       rcx,[rax+10]
       test      rcx,rcx
       je        short M08_L04
       mov       eax,[rcx+8]
       cmp       eax,ebp
       jbe       short M08_L04
       mov       eax,ebp
       shl       rax,4
       mov       r14,[rcx+rax+10]
       test      r14,r14
       je        short M08_L04
       xor       edx,edx
       mov       [rcx+rax+10],rdx
       cmp       byte ptr [rdi+9D],0
       jne       short M08_L03
M08_L01:
       mov       rax,r14
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
M08_L02:
       mov       ecx,9
       call      qword ptr [7FFB5E8FCC90]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       short M08_L00
M08_L03:
       mov       rcx,r14
       call      qword ptr [7FFB5E59D830]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       ebx,eax
       mov       r15d,[r14+8]
       cmp       [rsi],sil
       mov       rcx,rsi
       call      qword ptr [7FFB5E59D830]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       [rsp+20],ebp
       mov       edx,ebx
       mov       r8d,r15d
       mov       rcx,rdi
       call      qword ptr [7FFB5E8FE928]
       jmp       short M08_L01
M08_L04:
       mov       rcx,[rsi+10]
       cmp       [rcx+8],ebp
       jbe       near ptr M08_L16
       mov       eax,ebp
       mov       rcx,[rcx+rax*8+10]
       test      rcx,rcx
       je        near ptr M08_L15
       mov       r14,[rcx+8]
       mov       rcx,offset MT_System.Threading.ProcessorIdCache
       call      System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       cmp       byte ptr [7FFB5E0CB1D4],0
       je        short M08_L05
       call      qword ptr [7FFB5E8FE940]
       mov       ebx,eax
       jmp       short M08_L07
M08_L05:
       mov       ecx,0A
       call      qword ptr [7FFB5E8FE958]
       mov       ebx,[rax+10]
       mov       ecx,0A
       call      qword ptr [7FFB5E8FE958]
       lea       ecx,[rbx-1]
       mov       [rax+10],ecx
       movzx     eax,bx
       test      eax,eax
       jne       short M08_L06
       call      qword ptr [7FFB5E8FE970]
       mov       ebx,eax
       jmp       short M08_L07
M08_L06:
       sar       ebx,10
M08_L07:
       mov       rcx,offset MT_System.Buffers.SharedArrayPoolStatics
       call      System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       eax,ebx
       xor       edx,edx
       div       dword ptr [7FFB5E0CB1C8]
       mov       ebx,edx
       xor       r15d,r15d
       jmp       short M08_L11
M08_L08:
       cmp       ebx,[r14+8]
       jae       near ptr M08_L21
       mov       ecx,ebx
       mov       r13,[r14+rcx*8+10]
       cmp       [r13],r13b
       xor       r12d,r12d
       mov       rcx,r13
       call      qword ptr [7FFB5E69E3B8]; System.Threading.Monitor.Enter(System.Object)
       mov       rcx,[r13+8]
       mov       eax,[r13+10]
       dec       eax
       cmp       [rcx+8],eax
       jbe       short M08_L09
       mov       edx,eax
       mov       r12,[rcx+rdx*8+10]
       mov       edx,eax
       xor       r8d,r8d
       mov       [rcx+rdx*8+10],r8
       mov       [r13+10],eax
M08_L09:
       mov       rcx,r13
       call      qword ptr [7FFB5E186820]; System.Threading.Monitor.Exit(System.Object)
       test      r12,r12
       jne       short M08_L12
       inc       ebx
       cmp       [r14+8],ebx
       jne       short M08_L10
       xor       ebx,ebx
M08_L10:
       inc       r15d
M08_L11:
       cmp       [r14+8],r15d
       jg        short M08_L08
       jmp       short M08_L13
M08_L12:
       mov       r14,r12
       jmp       short M08_L14
M08_L13:
       xor       r14d,r14d
M08_L14:
       test      r14,r14
       je        short M08_L15
       cmp       byte ptr [rdi+9D],0
       je        near ptr M08_L01
       mov       rcx,r14
       call      qword ptr [7FFB5E59D830]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       ebx,eax
       mov       r15d,[r14+8]
       mov       rcx,rsi
       call      qword ptr [7FFB5E59D830]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       [rsp+20],ebp
       mov       edx,ebx
       mov       r8d,r15d
       mov       rcx,rdi
       call      qword ptr [7FFB5E8FE928]
       jmp       near ptr M08_L01
M08_L15:
       mov       ecx,10
       shlx      ebx,ecx,ebp
       jmp       short M08_L18
M08_L16:
       test      ebx,ebx
       jne       short M08_L17
       mov       rax,1DCAD5362A0
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
M08_L17:
       mov       ecx,ebx
       mov       rdx,1DCAD536F28
       call      qword ptr [7FFB5E3AD8C0]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
M08_L18:
       cmp       ebx,800
       jge       short M08_L19
       movsxd    rdx,ebx
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
       jmp       short M08_L20
M08_L19:
       mov       ecx,ebx
       xor       edx,edx
       call      qword ptr [7FFB5E8FE910]
       mov       r14,rax
M08_L20:
       cmp       byte ptr [rdi+9D],0
       je        near ptr M08_L01
       cmp       [r14],r14b
       mov       rcx,r14
       call      qword ptr [7FFB5E59D830]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       ebx,eax
       mov       r15d,[r14+8]
       mov       rcx,rsi
       call      qword ptr [7FFB5E59D830]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       edx,ebx
       mov       r8d,r15d
       mov       rcx,rdi
       call      qword ptr [7FFB5E8FE928]
       mov       r15d,[r14+8]
       mov       rcx,rsi
       call      qword ptr [7FFB5E59D830]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       rcx,[rsi+10]
       mov       edx,1
       mov       r8d,2
       cmp       [rcx+8],ebp
       cmovg     edx,r8d
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       [rsp+28],edx
       mov       rcx,rdi
       mov       edx,ebx
       mov       r8d,r15d
       call      qword ptr [7FFB5E8FE988]
       jmp       near ptr M08_L01
M08_L21:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 796
```
```assembly
; Org.BouncyCastle.Crypto.Digests.Sha3Digest.DoFinal(Byte[], Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       r9d,[rbx+1C]
       test      r9b,7
       jne       near ptr M09_L07
       cmp       byte ptr [rbx+24],0
       jne       near ptr M09_L08
       mov       rcx,[rbx+10]
       mov       eax,r9d
       sar       eax,3
       cmp       eax,[rcx+8]
       jae       near ptr M09_L23
       mov       byte ptr [rcx+rax+10],2
       add       r9d,2
       mov       [rbx+1C],r9d
       movsxd    r9,dword ptr [rbx+20]
       mov       rcx,rbx
       call      qword ptr [7FFB5E8F6100]; Org.BouncyCastle.Crypto.Digests.KeccakDigest.Squeeze(Byte[], Int32, Int64)
       mov       rcx,offset MT_Org.BouncyCastle.Crypto.Digests.Sha3Digest
       cmp       [rbx],rcx
       jne       near ptr M09_L22
       mov       rsi,rbx
       mov       edi,[rsi+20]
       cmp       edi,100
       jg        near ptr M09_L10
       cmp       edi,80
       je        short M09_L00
       cmp       edi,0E0
       je        short M09_L00
       cmp       edi,100
       jne       near ptr M09_L09
M09_L00:
       add       edi,edi
       neg       edi
       add       edi,640
       mov       ecx,edi
       sub       ecx,1
       cmp       ecx,63E
       ja        near ptr M09_L11
       test      dil,3F
       jne       near ptr M09_L11
       mov       [rsi+18],edi
       mov       rcx,[rsi+8]
       mov       rdx,rcx
       mov       ecx,[rcx+8]
       lea       rax,[rdx+10]
       xor       r8d,r8d
       mov       r10,[rdx]
       cmp       dword ptr [r10+4],18
       jne       near ptr M09_L12
M09_L01:
       mov       r9d,r8d
       neg       r9d
       test      r8d,r8d
       jg        near ptr M09_L13
       test      r9d,r9d
       jl        near ptr M09_L13
       lea       r8d,[r9+rcx]
       cmp       r8d,[rdx+8]
       ja        near ptr M09_L13
       movzx     edx,word ptr [r10]
       mov       r8d,r9d
       imul      r8,rdx
       add       r8,rax
       mov       ecx,ecx
       imul      rdx,rcx
       test      dword ptr [r10],1000000
       jne       near ptr M09_L14
       mov       rcx,r8
       call      qword ptr [7FFB5E1857E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
M09_L02:
       mov       rax,[rsi+10]
       test      rax,rax
       je        near ptr M09_L15
       lea       rcx,[rax+10]
       mov       eax,[rax+8]
       mov       rdx,rcx
       cmp       rax,20
       jb        near ptr M09_L17
       mov       rdx,rax
       and       rdx,0FFFFFFFFFFFFFFC0
       xor       r8d,r8d
       cmp       rax,40
       jb        short M09_L04
M09_L03:
       vxorps    ymm0,ymm0,ymm0
       vmovups   [rcx+r8],ymm0
       vmovups   [rcx+r8+20],ymm0
       add       r8,40
       cmp       r8,rdx
       jb        short M09_L03
M09_L04:
       test      al,20
       jne       near ptr M09_L16
M09_L05:
       vxorps    ymm0,ymm0,ymm0
       vmovups   [rcx+rax-20],ymm0
M09_L06:
       xor       eax,eax
       mov       [rbx+1C],eax
       mov       byte ptr [rbx+24],0
       mov       eax,edi
       neg       eax
       add       eax,640
       sar       eax,1
       mov       [rbx+20],eax
       sar       eax,3
       vzeroupper
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M09_L07:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,301BD
       mov       rdx,7FFB5E802020
       call      qword ptr [7FFB5E3A77B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB5E506088]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M09_L08:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,2F7BF
       mov       rdx,7FFB5E802020
       call      qword ptr [7FFB5E3A77B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB5E506088]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M09_L09:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       ecx,30149
       mov       rdx,7FFB5E802020
       call      qword ptr [7FFB5E3A77B0]
       mov       rsi,rax
       mov       ecx,301A9
       mov       rdx,7FFB5E802020
       call      qword ptr [7FFB5E3A77B0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFB5E506130]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M09_L10:
       cmp       edi,120
       je        near ptr M09_L00
       cmp       edi,180
       je        near ptr M09_L00
       cmp       edi,200
       jne       short M09_L09
       jmp       near ptr M09_L00
M09_L11:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,126E3
       mov       rdx,7FFB5E802020
       call      qword ptr [7FFB5E3A77B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB5E506088]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M09_L12:
       mov       r9d,[r10+4]
       add       r9d,0FFFFFFE8
       shr       r9d,3
       movsxd    r8,r9d
       mov       r8d,[rax+r8*4]
       shl       r9d,3
       movsxd    r9,r9d
       add       rax,r9
       jmp       near ptr M09_L01
M09_L13:
       call      qword ptr [7FFB5E8FE808]
       int       3
M09_L14:
       shr       rdx,3
       mov       rcx,r8
       call      qword ptr [7FFB5E8FE820]
       jmp       near ptr M09_L02
M09_L15:
       mov       ecx,2
       call      qword ptr [7FFB5E3AC240]
       int       3
M09_L16:
       vxorps    ymm0,ymm0,ymm0
       vmovups   [rcx+r8],ymm0
       jmp       near ptr M09_L05
M09_L17:
       xor       ecx,ecx
       cmp       rax,8
       jb        short M09_L19
       mov       r8,rax
       and       r8,0FFFFFFFFFFFFFFF8
M09_L18:
       xor       r10d,r10d
       mov       [rdx+rcx],r10
       add       rcx,8
       cmp       rcx,r8
       jb        short M09_L18
M09_L19:
       test      al,4
       je        short M09_L20
       xor       r8d,r8d
       mov       [rdx+rcx],r8d
       add       rcx,4
M09_L20:
       test      al,2
       je        short M09_L21
       mov       word ptr [rdx+rcx],0
       add       rcx,2
M09_L21:
       test      al,1
       je        near ptr M09_L06
       mov       byte ptr [rdx+rcx],0
       jmp       near ptr M09_L06
M09_L22:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       vzeroupper
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax+28]
M09_L23:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 935
```
```assembly
; System.Convert.ToBase64String(Byte[], Int32, Int32, System.Base64FormattingOptions)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       mov       [rsp+40],rax
       mov       esi,edx
       mov       ebx,r8d
       mov       edi,r9d
       test      rcx,rcx
       je        near ptr M10_L18
       test      ebx,ebx
       jl        near ptr M10_L19
       test      esi,esi
       jl        near ptr M10_L20
       mov       ebp,[rcx+8]
       sub       ebp,ebx
       cmp       esi,ebp
       jl        short M10_L00
       cmp       esi,ebp
       jg        near ptr M10_L05
M10_L00:
       mov       eax,esi
       mov       edx,ebx
       add       rax,rdx
       mov       edx,[rcx+8]
       cmp       rax,rdx
       ja        near ptr M10_L21
       mov       eax,esi
       lea       rbp,[rcx+rax+10]
       cmp       edi,1
       ja        near ptr M10_L22
       test      ebx,ebx
       je        near ptr M10_L23
       cmp       edi,1
       sete      dil
       movzx     edi,dil
       lea       ecx,[rbx+2]
       mov       eax,0AAAAAAAB
       mov       edx,ecx
       imul      rax,rdx
       shr       rax,21
       shl       eax,2
       je        near ptr M10_L24
       test      edi,edi
       jne       near ptr M10_L25
M10_L01:
       test      eax,eax
       jl        near ptr M10_L26
M10_L02:
       movsxd    rdx,eax
       mov       rcx,offset MT_System.String
       call      00007FFBBDE29F20
       mov       rsi,rax
       test      edi,edi
       jne       near ptr M10_L31
       cmp       ebx,10
       jl        near ptr M10_L31
       lea       rcx,[rsi+0C]
       mov       edx,[rsi+8]
       imul      r9d,edx,2
       jo        near ptr M10_L34
       mov       [rsp+30],rbp
       mov       [rsp+28],rcx
       mov       r8,rcx
       cmp       ebx,5FFFFFFD
       jg        near ptr M10_L27
       lea       eax,[rbx+2]
       mov       r10d,0AAAAAAAB
       imul      rax,r10
       shr       rax,21
       shl       eax,2
       cmp       eax,r9d
       jg        near ptr M10_L27
       mov       eax,ebx
M10_L03:
       mov       r9,rbp
       mov       r10,r8
       mov       r11d,ebx
       add       r11,r9
       mov       edi,eax
       add       rdi,r9
       cmp       eax,10
       jl        near ptr M10_L08
       lea       rax,[rdi-20]
       cmp       rax,r9
       jb        near ptr M10_L07
       vmovups   ymm0,[7FFB5E9ADEA0]
       vpermd    ymm0,ymm0,[rbp]
       add       rbp,0FFFFFFFFFFFFFFFC
M10_L04:
       vpshufb   ymm0,ymm0,[7FFB5E9ADEC0]
       vpand     ymm1,ymm0,[7FFB5E9ADEE0]
       vpmulhuw  ymm1,ymm1,[7FFB5E9ADF00]
       vpand     ymm0,ymm0,[7FFB5E9ADF20]
       vpmullw   ymm0,ymm0,[7FFB5E9ADF40]
       vpor      ymm0,ymm0,ymm1
       vpsubusb  ymm1,ymm0,[7FFB5E9ADF60]
       vpcmpgtb  ymm2,ymm0,[7FFB5E9ADF80]
       vpsubb    ymm1,ymm1,ymm2
       vbroadcastf128 ymm2,xmmword ptr [7FFB5E9ADFA0]
       vpshufb   ymm1,ymm2,ymm1
       vpaddb    ymm0,ymm1,ymm0
       vmovups   [r8],ymm0
       add       rbp,18
       add       r8,20
       cmp       rbp,rax
       ja        short M10_L06
       vmovups   ymm0,[rbp]
       jmp       short M10_L04
M10_L05:
       mov       ecx,1149
       mov       rdx,7FFB5E0C4000
       call      qword ptr [7FFB5E3A77B0]
       mov       r8,rax
       mov       edx,ebp
       mov       ecx,esi
       call      qword ptr [7FFB5E8FE9D0]
       int       3
M10_L06:
       lea       r9,[rbp+4]
       mov       r10,r8
       cmp       r9,r11
       je        near ptr M10_L11
M10_L07:
       lea       rax,[rdi-10]
       cmp       rax,r9
       jae       near ptr M10_L28
M10_L08:
       mov       r8,7FFBBCF94BE0
       add       rdi,0FFFFFFFFFFFFFFFE
       cmp       r9,rdi
       jae       short M10_L10
M10_L09:
       movzx     eax,byte ptr [r9]
       shl       eax,10
       movzx     ebx,byte ptr [r9+1]
       shl       ebx,8
       or        eax,ebx
       movzx     ebx,byte ptr [r9+2]
       or        eax,ebx
       mov       ebx,eax
       shr       ebx,12
       movzx     ebx,byte ptr [r8+rbx]
       mov       ebp,eax
       shr       ebp,0C
       and       ebp,3F
       movzx     ebp,byte ptr [r8+rbp]
       shl       ebp,8
       or        ebx,ebp
       mov       ebp,eax
       shr       ebp,6
       and       ebp,3F
       movzx     ebp,byte ptr [r8+rbp]
       shl       ebp,10
       or        ebx,ebp
       and       eax,3F
       movzx     eax,byte ptr [r8+rax]
       shl       eax,18
       or        eax,ebx
       mov       [r10],eax
       add       r9,3
       add       r10,4
       cmp       r9,rdi
       jb        short M10_L09
M10_L10:
       lea       rax,[rdi+2]
       cmp       rax,r11
       jne       short M10_L11
       lea       rax,[r9+1]
       cmp       rax,r11
       je        near ptr M10_L29
       lea       rax,[r9+2]
       cmp       rax,r11
       jne       short M10_L11
       movzx     eax,byte ptr [r9]
       shl       eax,10
       movzx     r9d,byte ptr [r9+1]
       shl       r9d,8
       or        r9d,eax
       mov       eax,r9d
       shr       eax,12
       movzx     eax,byte ptr [r8+rax]
       mov       r11d,r9d
       shr       r11d,0C
       and       r11d,3F
       movzx     r11d,byte ptr [r8+r11]
       shl       r11d,8
       or        eax,r11d
       shr       r9d,6
       and       r9d,3F
       movzx     r8d,byte ptr [r8+r9]
       shl       r8d,10
       or        r8d,eax
       or        r8d,3D000000
       mov       [r10],r8d
M10_L11:
       xor       r9d,r9d
       mov       [rsp+30],r9
       mov       [rsp+28],r9
       mov       r9d,edx
       lea       r9,[rcx+r9*2]
       mov       edx,edx
       add       rdx,rcx
       lea       r8,[rcx+1F]
       cmp       rdx,r8
       jbe       short M10_L13
M10_L12:
       add       rdx,0FFFFFFFFFFFFFFE0
       add       r9,0FFFFFFFFFFFFFFC0
       vmovups   ymm0,[rdx]
       vmovaps   ymm1,ymm0
       vpmovzxbw ymm1,xmm1
       vextracti128 xmm0,ymm0,1
       vpmovzxbw ymm0,xmm0
       vmovups   [r9],ymm1
       vmovups   [r9+20],ymm0
       cmp       rdx,r8
       ja        short M10_L12
M10_L13:
       lea       r8,[rcx+0F]
       cmp       rdx,r8
       ja        near ptr M10_L30
M10_L14:
       add       rcx,3
       cmp       rdx,rcx
       jbe       short M10_L16
M10_L15:
       add       r9,0FFFFFFFFFFFFFFF8
       add       rdx,0FFFFFFFFFFFFFFFC
       vmovd     xmm0,dword ptr [rdx]
       vpmovzxbw xmm0,xmm0
       vmovq     qword ptr [r9],xmm0
       cmp       rdx,rcx
       ja        short M10_L15
M10_L16:
       mov       rax,rsi
M10_L17:
       vzeroupper
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M10_L18:
       mov       ecx,1139
       mov       rdx,7FFB5E0C4000
       call      qword ptr [7FFB5E3A77B0]
       mov       rcx,rax
       call      qword ptr [7FFB5E8FCA98]
       int       3
M10_L19:
       mov       ecx,0B3
       mov       rdx,7FFB5E0C4000
       call      qword ptr [7FFB5E3A77B0]
       mov       rdx,rax
       mov       ecx,ebx
       call      qword ptr [7FFB5E8FCA68]
       int       3
M10_L20:
       mov       ecx,1149
       mov       rdx,7FFB5E0C4000
       call      qword ptr [7FFB5E3A77B0]
       mov       rdx,rax
       mov       ecx,esi
       call      qword ptr [7FFB5E8FCA68]
       int       3
M10_L21:
       call      qword ptr [7FFB5E2F7198]
       int       3
M10_L22:
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFB5E8FE328]
       mov       rsi,rax
       mov       [rbx+8],edi
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB5E8FD290]
       mov       rbx,rax
       mov       ecx,1157
       mov       rdx,7FFB5E0C4000
       call      qword ptr [7FFB5E3A77B0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FFB5E506130]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M10_L23:
       mov       rax,1DCAD530008
       jmp       near ptr M10_L17
M10_L24:
       xor       eax,eax
       jmp       near ptr M10_L02
M10_L25:
       mov       ecx,eax
       shr       ecx,2
       imul      rcx,1AF286BD
       shr       rcx,21
       imul      edx,ecx,4C
       mov       r8d,eax
       sub       r8d,edx
       mov       edx,ecx
       dec       ecx
       test      r8d,r8d
       cmove     edx,ecx
       lea       eax,[rax+rdx*2]
       jmp       near ptr M10_L01
M10_L26:
       mov       rcx,offset MT_System.OutOfMemoryException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       call      qword ptr [7FFB5E8FDBC0]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M10_L27:
       sar       r9d,2
       lea       eax,[r9+r9*2]
       jmp       near ptr M10_L03
M10_L28:
       vmovups   xmm0,[r9]
       vpshufb   xmm0,xmm0,[7FFB5E9ADFB0]
       vpand     xmm1,xmm0,[7FFB5E9ADEE0]
       vpmulhuw  xmm1,xmm1,[7FFB5E9ADF00]
       vpand     xmm0,xmm0,[7FFB5E9ADF20]
       vpmullw   xmm0,xmm0,[7FFB5E9ADF40]
       vpor      xmm0,xmm0,xmm1
       vpsubusb  xmm1,xmm0,[7FFB5E9ADF60]
       vpcmpgtb  xmm2,xmm0,[7FFB5E9ADF80]
       vpsubb    xmm1,xmm1,xmm2
       vmovups   xmm2,[7FFB5E9ADFA0]
       vpshufb   xmm1,xmm2,xmm1
       vpaddb    xmm0,xmm1,xmm0
       vmovups   [r10],xmm0
       add       r9,0C
       add       r10,10
       cmp       r9,rax
       jbe       short M10_L28
       cmp       r9,r11
       je        near ptr M10_L11
       jmp       near ptr M10_L08
M10_L29:
       movzx     r9d,byte ptr [r9]
       shl       r9d,8
       mov       eax,r9d
       shr       eax,0A
       movzx     eax,byte ptr [r8+rax]
       shr       r9d,4
       and       r9d,3F
       movzx     r9d,byte ptr [r8+r9]
       shl       r9d,8
       or        r9d,eax
       or        r9d,3D3D0000
       mov       [r10],r9d
       jmp       near ptr M10_L11
M10_L30:
       add       rdx,0FFFFFFFFFFFFFFF0
       add       r9,0FFFFFFFFFFFFFFE0
       vmovups   xmm0,[rdx]
       vpmovzxbw xmm1,xmm0
       vpsrldq   xmm0,xmm0,8
       vpmovzxbw xmm0,xmm0
       vmovups   [r9],xmm1
       vmovups   [r9+10],xmm0
       cmp       rdx,r8
       ja        short M10_L30
       jmp       near ptr M10_L14
M10_L31:
       mov       [rsp+40],rbp
       mov       rdx,rbp
       test      rsi,rsi
       jne       short M10_L32
       xor       ecx,ecx
       jmp       short M10_L33
M10_L32:
       lea       rcx,[rsi+0C]
       mov       [rsp+38],rcx
       mov       rcx,[rsp+38]
M10_L33:
       mov       [rsp+20],edi
       mov       r9d,ebx
       xor       r8d,r8d
       call      qword ptr [7FFB5E8FE340]
       xor       eax,eax
       mov       [rsp+38],rax
       mov       [rsp+40],rax
       jmp       near ptr M10_L16
M10_L34:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 1512
```
```assembly
; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Return(Byte[], Boolean)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       mov       rdi,rcx
       mov       rbx,rdx
       mov       esi,r8d
       test      rbx,rbx
       je        near ptr M11_L07
       mov       ebp,[rbx+8]
       lea       ecx,[rbp-1]
       or        ecx,0F
       xor       r14d,r14d
       lzcnt     r14d,ecx
       xor       r14d,1F
       add       r14d,0FFFFFFFD
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],9
       jle       near ptr M11_L05
       mov       rcx,[rcx+240]
       mov       rax,[rcx+48]
       test      rax,rax
       je        near ptr M11_L05
M11_L00:
       mov       r15,[rax+10]
       test      r15,r15
       je        near ptr M11_L06
M11_L01:
       xor       r13d,r13d
       mov       r12d,1
       cmp       [r15+8],r14d
       jbe       short M11_L03
       mov       r13d,1
       test      sil,sil
       je        short M11_L02
       mov       rcx,[rbx]
       movzx     edx,word ptr [rcx]
       mov       eax,[rbx+8]
       imul      rdx,rax
       lea       rax,[rbx+10]
       test      dword ptr [rcx],1000000
       jne       near ptr M11_L08
       mov       rcx,rax
       call      qword ptr [7FFB5E1857E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
M11_L02:
       mov       ecx,10
       shlx      ecx,ecx,r14d
       cmp       ebp,ecx
       jne       near ptr M11_L09
       mov       ecx,r14d
       shl       rcx,4
       lea       rsi,[r15+rcx+10]
       mov       r15,[rsi]
       mov       rcx,rsi
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+8],ecx
       test      r15,r15
       jne       near ptr M11_L10
M11_L03:
       mov       rcx,19C18400C90
       mov       rsi,[rcx]
       cmp       byte ptr [rsi+9D],0
       jne       near ptr M11_L25
M11_L04:
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
M11_L05:
       mov       ecx,9
       call      qword ptr [7FFB5E8FCC90]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M11_L00
M11_L06:
       mov       rcx,rdi
       call      qword ptr [7FFB5E8F62B0]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
       mov       r15,rax
       jmp       near ptr M11_L01
M11_L07:
       mov       ecx,2
       call      qword ptr [7FFB5E3AC240]
       int       3
M11_L08:
       shr       rdx,3
       mov       rcx,rax
       call      qword ptr [7FFB5E8FE820]
       jmp       near ptr M11_L02
M11_L09:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       call      qword ptr [7FFB5E8FEA78]
       mov       rbx,rax
       mov       ecx,29B
       mov       rdx,7FFB5E0C4000
       call      qword ptr [7FFB5E3A77B0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rbp
       call      qword ptr [7FFB5E506130]
       mov       rcx,rbp
       call      CORINFO_HELP_THROW
       int       3
M11_L10:
       mov       rcx,[rdi+10]
       cmp       r14d,[rcx+8]
       jae       near ptr M11_L28
       mov       edx,r14d
       mov       rax,[rcx+rdx*8+10]
       test      rax,rax
       jne       short M11_L11
       mov       rcx,rdi
       mov       edx,r14d
       call      qword ptr [7FFB5E8FEA90]
M11_L11:
       mov       r12,[rax+8]
       mov       rcx,offset MT_System.Threading.ProcessorIdCache
       call      System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       cmp       byte ptr [7FFB5E0CB1D4],0
       je        short M11_L12
       call      qword ptr [7FFB5E8FE940]
       mov       esi,eax
       jmp       short M11_L14
M11_L12:
       mov       ecx,0A
       call      qword ptr [7FFB5E8FE958]
       mov       esi,[rax+10]
       mov       ecx,0A
       call      qword ptr [7FFB5E8FE958]
       lea       ecx,[rsi-1]
       mov       [rax+10],ecx
       movzx     eax,si
       test      eax,eax
       jne       short M11_L13
       call      qword ptr [7FFB5E8FE970]
       mov       esi,eax
       jmp       short M11_L14
M11_L13:
       sar       esi,10
M11_L14:
       mov       rcx,offset MT_System.Buffers.SharedArrayPoolStatics
       call      System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       eax,esi
       xor       edx,edx
       div       dword ptr [7FFB5E0CB1C8]
       mov       esi,edx
       xor       eax,eax
       jmp       near ptr M11_L21
M11_L15:
       cmp       esi,[r12+8]
       jae       near ptr M11_L28
       mov       ecx,esi
       mov       rdx,[r12+rcx*8+10]
       mov       [rsp+30],rdx
       cmp       [rdx],dl
       xor       r8d,r8d
       mov       [rsp+3C],r8d
       mov       rcx,rdx
       call      qword ptr [7FFB5E69E3B8]; System.Threading.Monitor.Enter(System.Object)
       mov       rax,[rsp+30]
       mov       rcx,[rax+8]
       mov       r8d,[rax+10]
       mov       [rsp+38],r8d
       cmp       [rcx+8],r8d
       jbe       short M11_L17
       test      r8d,r8d
       jne       short M11_L18
       xor       edx,edx
       mov       [rax+14],edx
M11_L16:
       mov       edx,r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rsp+38]
       inc       ecx
       mov       rax,[rsp+30]
       mov       [rax+10],ecx
       mov       dword ptr [rsp+3C],1
M11_L17:
       mov       rcx,rax
       call      qword ptr [7FFB5E186820]; System.Threading.Monitor.Exit(System.Object)
       cmp       dword ptr [rsp+3C],0
       je        short M11_L19
       jmp       short M11_L22
M11_L18:
       jmp       short M11_L16
M11_L19:
       inc       esi
       cmp       [r12+8],esi
       jne       short M11_L20
       xor       esi,esi
M11_L20:
       mov       eax,[rsp+40]
       inc       eax
M11_L21:
       mov       [rsp+40],eax
       cmp       [r12+8],eax
       jg        near ptr M11_L15
       jmp       short M11_L23
M11_L22:
       mov       r12d,1
       jmp       short M11_L24
M11_L23:
       xor       r12d,r12d
M11_L24:
       jmp       near ptr M11_L03
M11_L25:
       test      ebp,ebp
       je        near ptr M11_L04
       mov       rcx,rbx
       call      qword ptr [7FFB5E59D830]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r15d,eax
       mov       [rsp+44],ebp
       cmp       [rdi],dil
       mov       rcx,rdi
       call      qword ptr [7FFB5E59D830]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,rsi
       mov       r8d,r15d
       mov       r9d,[rsp+44]
       mov       edx,3
       call      qword ptr [7FFB5E8FE1A8]
       test      r12d,r13d
       jne       near ptr M11_L04
       mov       rcx,rbx
       call      qword ptr [7FFB5E59D830]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       ebx,eax
       mov       rcx,rdi
       call      qword ptr [7FFB5E59D830]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       test      r13d,r13d
       jne       short M11_L26
       mov       ecx,0FFFFFFFF
       mov       edx,1
       jmp       short M11_L27
M11_L26:
       mov       ecx,r14d
       xor       edx,edx
M11_L27:
       mov       [rsp+20],ecx
       mov       [rsp+28],edx
       mov       rcx,rsi
       mov       edx,ebx
       mov       r8d,ebp
       call      qword ptr [7FFB5E8FEAA8]
       jmp       near ptr M11_L04
M11_L28:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 913
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Security.PasswordHasherBenchmark.HashPasswordSHA3384()
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       lea       rbp,[rsp+0B0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-70],ymm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       xor       eax,eax
       mov       [rbp-40],rax
       mov       rcx,offset MT_Org.BouncyCastle.Crypto.Digests.Sha3Digest
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,offset MT_System.UInt64[]
       mov       edx,19
       call      CORINFO_HELP_NEWARR_1_PTR
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Byte[]
       mov       edx,0C0
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rbx+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+18],340
       mov       rcx,[rbx+8]
       mov       rdx,rcx
       mov       ecx,[rcx+8]
       lea       rax,[rdx+10]
       xor       r8d,r8d
       mov       r10,[rdx]
       cmp       dword ptr [r10+4],18
       jne       near ptr M00_L05
M00_L00:
       mov       r9d,r8d
       neg       r9d
       test      r8d,r8d
       jg        near ptr M00_L06
       test      r9d,r9d
       jl        near ptr M00_L06
       lea       r8d,[r9+rcx]
       cmp       r8d,[rdx+8]
       ja        near ptr M00_L06
       movzx     edx,word ptr [r10]
       mov       r8d,r9d
       imul      r8,rdx
       add       r8,rax
       mov       ecx,ecx
       imul      rdx,rcx
       test      dword ptr [r10],1000000
       jne       near ptr M00_L07
       mov       rcx,r8
       call      qword ptr [7FFB5E1857E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
M00_L01:
       mov       rdx,[rbx+10]
       test      rdx,rdx
       je        near ptr M00_L08
       lea       rcx,[rdx+10]
       mov       edx,[rdx+8]
       xor       r8d,r8d
       call      qword ptr [7FFB5E7AD980]; System.SpanHelpers.Fill[[System.Byte, System.Private.CoreLib]](Byte ByRef, UIntPtr, Byte)
       xor       r8d,r8d
       mov       [rbx+1C],r8d
       mov       byte ptr [rbx+24],0
       mov       dword ptr [rbx+20],180
       mov       r8,15862000220
       mov       rsi,[r8]
       mov       rdi,198F7030708
       add       rdi,0C
       mov       r14,rdi
       lea       r8,[rbp-30]
       lea       r9,[rbp-38]
       mov       rcx,r14
       mov       edx,40
       call      qword ptr [7FFB5E18FAF8]; System.Text.Unicode.Utf16Utility.GetPointerToFirstInvalidChar(Char*, Int32, Int64 ByRef, Int32 ByRef)
       sub       rax,r14
       mov       r9,rax
       shr       r9,3F
       add       r9,rax
       sar       r9,1
       movsxd    r15,r9d
       add       r15,[rbp-30]
       cmp       r15,7FFFFFFF
       ja        near ptr M00_L10
       cmp       r9d,40
       jne       near ptr M00_L09
M00_L02:
       movsxd    rdx,r15d
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
       mov       r15d,[r14+8]
       test      r15d,r15d
       jl        near ptr M00_L11
       mov       rdx,rdi
       mov       [rbp-40],r14
       test      r15d,r15d
       je        near ptr M00_L12
       lea       r9,[r14+10]
M00_L03:
       mov       [rsp+20],r15d
       mov       dword ptr [rsp+28],1
       mov       rcx,rsi
       mov       r8d,40
       call      qword ptr [7FFB5EA54798]; System.Text.UTF8Encoding.GetBytesCommon(Char*, Int32, Byte*, Int32, Boolean)
       xor       ecx,ecx
       mov       [rbp-40],rcx
       mov       rdx,r14
       mov       r9d,r15d
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-60],xmm0
       lea       rcx,[rbp-60]
       xor       r8d,r8d
       call      qword ptr [7FFB5EA547B0]; System.Span`1[[System.Byte, System.Private.CoreLib]]..ctor(Byte[], Int32, Int32)
       vmovdqu   xmm0,xmmword ptr [rbp-60]
       vmovdqu   xmmword ptr [rbp-70],xmm0
       lea       rdx,[rbp-70]
       lea       rcx,[rbp-50]
       call      qword ptr [7FFB5E59CB28]; System.Span`1[[System.Byte, System.Private.CoreLib]].op_Implicit(System.Span`1<Byte>)
       lea       rdx,[rbp-50]
       mov       rcx,rbx
       call      qword ptr [7FFB5E7ADA28]; Org.BouncyCastle.Crypto.Digests.KeccakDigest.Absorb(System.ReadOnlySpan`1<Byte>)
       mov       esi,[rbx+20]
       sar       esi,3
       mov       rcx,15878000160
       mov       rcx,[rcx]
       mov       edx,esi
       call      qword ptr [7FFB5E7B1190]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Rent(Int32)
       mov       [rbp-78],rax
       mov       rcx,rbx
       mov       rdx,[rbp-78]
       xor       r8d,r8d
       call      qword ptr [7FFB5E804080]; Org.BouncyCastle.Crypto.Digests.Sha3Digest.DoFinal(Byte[], Int32)
       mov       rcx,[rbp-78]
       mov       r8d,esi
       xor       edx,edx
       xor       r9d,r9d
       call      qword ptr [7FFB5E8F6448]; System.Convert.ToBase64String(Byte[], Int32, Int32, System.Base64FormattingOptions)
       mov       rbx,rax
       jmp       short M00_L04
       int       3
M00_L04:
       mov       rcx,15862001E28
       mov       rcx,[rcx]
       mov       rdx,[rbp-78]
       mov       r8d,1
       call      qword ptr [7FFB5E7B1198]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Return(Byte[], Boolean)
       mov       rax,rbx
       add       rsp,88
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L05:
       mov       r9d,[r10+4]
       add       r9d,0FFFFFFE8
       shr       r9d,3
       movsxd    r8,r9d
       mov       r8d,[rax+r8*4]
       shl       r9d,3
       movsxd    r9,r9d
       add       rax,r9
       jmp       near ptr M00_L00
M00_L06:
       call      qword ptr [7FFB5E8FEDF0]
       int       3
M00_L07:
       shr       rdx,3
       mov       rcx,r8
       call      qword ptr [7FFB5E8FEE08]
       jmp       near ptr M00_L01
M00_L08:
       mov       ecx,2
       call      qword ptr [7FFB5E3AC240]
       int       3
M00_L09:
       mov       rcx,rsi
       mov       rdx,r14
       mov       r8d,40
       call      qword ptr [7FFB5E8FE7A8]
       add       r15d,eax
       jns       near ptr M00_L02
M00_L10:
       call      qword ptr [7FFB5E71E880]
       int       3
M00_L11:
       mov       ecx,0B
       xor       edx,edx
       call      qword ptr [7FFB5E7166B8]
       int       3
M00_L12:
       xor       r9d,r9d
       jmp       near ptr M00_L03
       sub       rsp,38
       mov       rcx,15862001E28
       mov       rcx,[rcx]
       mov       rdx,[rcx]
       mov       rdx,[rbp-78]
       mov       r8d,1
       call      qword ptr [7FFB5E7B1198]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Return(Byte[], Boolean)
       add       rsp,38
       ret
; Total bytes of code 828
```
```assembly
; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
       push      rbx
       test      rdx,rdx
       je        short M01_L03
       lea       rbx,[rcx+rdx]
       cmp       rdx,10
       jbe       short M01_L05
       cmp       rdx,40
       jbe       short M01_L04
       cmp       rdx,400
       ja        near ptr M01_L09
       cmp       rdx,100
       jae       near ptr M01_L08
M01_L00:
       mov       rax,rdx
       shr       rax,6
M01_L01:
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       dec       rax
       jne       short M01_L01
       and       rdx,3F
       cmp       rdx,10
       ja        short M01_L04
M01_L02:
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rbx-10],xmm0
M01_L03:
       pop       rbx
       ret
M01_L04:
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rcx],xmm0
       cmp       rdx,20
       jbe       short M01_L02
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rcx+10],xmm0
       cmp       rdx,30
       jbe       short M01_L02
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rcx+20],xmm0
       jmp       short M01_L02
M01_L05:
       test      dl,18
       je        short M01_L06
       xor       eax,eax
       mov       [rcx],rax
       mov       [rbx-8],rax
       jmp       short M01_L03
M01_L06:
       test      dl,4
       je        short M01_L07
       xor       eax,eax
       mov       [rcx],eax
       mov       [rbx-4],eax
       jmp       short M01_L03
M01_L07:
       mov       byte ptr [rcx],0
       test      dl,2
       je        short M01_L03
       mov       word ptr [rbx-2],0
       jmp       short M01_L03
M01_L08:
       mov       rax,rcx
       and       rax,3F
       neg       rax
       add       rax,40
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,rax
       sub       rdx,rax
       jmp       near ptr M01_L00
M01_L09:
       cmp       [rcx],cl
       pop       rbx
       jmp       qword ptr [7FFB5E8FE370]
; Total bytes of code 231
```
```assembly
; System.SpanHelpers.Fill[[System.Byte, System.Private.CoreLib]](Byte ByRef, UIntPtr, Byte)
       cmp       rdx,20
       jb        short M02_L05
       vmovd     xmm0,r8d
       vpbroadcastb ymm0,xmm0
       mov       r8,rdx
       and       r8,0FFFFFFFFFFFFFFC0
       xor       eax,eax
       cmp       rdx,40
       jb        short M02_L01
M02_L00:
       vmovups   [rcx+rax],ymm0
       vmovups   [rcx+rax+20],ymm0
       add       rax,40
       cmp       rax,r8
       jb        short M02_L00
M02_L01:
       test      dl,20
       jne       short M02_L04
M02_L02:
       vmovups   [rcx+rdx-20],ymm0
M02_L03:
       vzeroupper
       ret
M02_L04:
       vmovups   [rcx+rax],ymm0
       jmp       short M02_L02
M02_L05:
       xor       eax,eax
       cmp       rdx,8
       jb        short M02_L07
       mov       r10,rdx
       and       r10,0FFFFFFFFFFFFFFF8
M02_L06:
       mov       [rcx+rax],r8b
       mov       [rcx+rax+1],r8b
       mov       [rcx+rax+2],r8b
       mov       [rcx+rax+3],r8b
       mov       [rcx+rax+4],r8b
       mov       [rcx+rax+5],r8b
       mov       [rcx+rax+6],r8b
       mov       [rcx+rax+7],r8b
       add       rax,8
       cmp       rax,r10
       jb        short M02_L06
M02_L07:
       test      dl,4
       je        short M02_L08
       mov       [rcx+rax],r8b
       mov       [rcx+rax+1],r8b
       mov       [rcx+rax+2],r8b
       mov       [rcx+rax+3],r8b
       add       rax,4
M02_L08:
       test      dl,2
       je        short M02_L09
       mov       [rcx+rax],r8b
       mov       [rcx+rax+1],r8b
       add       rax,2
M02_L09:
       test      dl,1
       je        short M02_L03
       mov       [rcx+rax],r8b
       jmp       near ptr M02_L03
; Total bytes of code 196
```
```assembly
; System.Text.Unicode.Utf16Utility.GetPointerToFirstInvalidChar(Char*, Int32, Int64 ByRef, Int32 ByRef)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       mov       rax,rcx
       mov       r10d,edx
       mov       r11,rax
       cmp       r10,20
       jae       near ptr M03_L09
       cmp       r10,10
       jae       near ptr M03_L07
M03_L00:
       cmp       r10,4
       jb        short M03_L02
M03_L01:
       mov       r11d,[rax]
       mov       ebx,[rax+4]
       mov       esi,r11d
       or        esi,ebx
       test      esi,0FF80FF80
       jne       near ptr M03_L12
       add       rax,8
       add       r10,0FFFFFFFFFFFFFFFC
       cmp       r10,4
       jae       short M03_L01
M03_L02:
       test      r10b,2
       je        short M03_L03
       mov       r11d,[rax]
       test      r11d,0FF80FF80
       jne       near ptr M03_L13
       add       rax,4
M03_L03:
       test      r10b,1
       je        short M03_L05
       cmp       word ptr [rax],7F
       ja        short M03_L05
M03_L04:
       add       rax,2
M03_L05:
       sub       rax,rcx
       shr       rax,1
       mov       r10d,eax
       lea       rcx,[rcx+r10*2]
       sub       edx,eax
       jne       near ptr M03_L15
       xor       edx,edx
       mov       [r8],rdx
       mov       [r9],edx
M03_L06:
       mov       rax,rcx
       vzeroupper
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M03_L07:
       vbroadcastss xmm0,dword ptr [7FFB5E9A8FA0]
       vptest    xmm0,xmmword ptr [rax]
       jne       near ptr M03_L00
       lea       rbx,[r11+r10*2-10]
       add       r11,10
       mov       rax,r11
       and       rax,0FFFFFFFFFFFFFFF0
       vpand     xmm1,xmm0,[rax]
       vptest    xmm1,xmm1
       jne       short M03_L11
M03_L08:
       add       rax,10
       cmp       rax,rbx
       ja        short M03_L11
       vpand     xmm1,xmm0,[rax]
       vptest    xmm1,xmm1
       jne       short M03_L11
       jmp       short M03_L08
M03_L09:
       vbroadcastss ymm0,dword ptr [7FFB5E9A8FA0]
       vptest    ymm0,ymmword ptr [rax]
       jne       near ptr M03_L00
       lea       rbx,[r11+r10*2-20]
       lea       rax,[r11+20]
       and       rax,0FFFFFFFFFFFFFFE0
       vpand     ymm1,ymm0,[rax]
       vptest    ymm1,ymm1
       jne       short M03_L11
M03_L10:
       add       rax,20
       cmp       rax,rbx
       ja        short M03_L11
       vpand     ymm1,ymm0,[rax]
       vptest    ymm1,ymm1
       je        short M03_L10
M03_L11:
       mov       r11,rax
       sub       r11,rcx
       shr       r11,1
       sub       r10,r11
       jmp       near ptr M03_L00
M03_L12:
       test      r11d,0FF80FF80
       je        short M03_L14
M03_L13:
       test      r11d,0FF80
       jne       near ptr M03_L05
       jmp       near ptr M03_L04
M03_L14:
       mov       r11d,ebx
       add       rax,4
       jmp       short M03_L13
M03_L15:
       xor       eax,eax
       xor       r10d,r10d
       mov       r11d,edx
       lea       r11,[rcx+r11*2]
       cmp       edx,8
       jl        near ptr M03_L20
       vbroadcastss xmm0,dword ptr [7FFB5E9A8FA4]
       lea       rdx,[r11-10]
M03_L16:
       vmovups   xmm1,[rcx]
       add       rcx,10
       vpaddusw  xmm2,xmm1,xmm0
       vpminuw   xmm3,xmm1,[7FFB5E9A8FB0]
       vpor      xmm2,xmm2,xmm3
       vpmovmskb ebx,xmm2
       popcnt    ebx,ebx
       vpaddw    xmm2,xmm1,[7FFB5E9A8FC0]
       vpcmpgtw  xmm2,xmm0,xmm2
       vpmovmskb esi,xmm2
M03_L17:
       cmp       esi,0FFFF
       je        short M03_L19
       not       esi
       vpsrlw    xmm2,xmm1,3
       vpmovmskb edi,xmm2
       mov       ebp,edi
       and       ebp,esi
       xor       edi,5555
       and       esi,edi
       shl       esi,2
       movzx     edi,si
       cmp       edi,ebp
       jne       near ptr M03_L22
       cmp       esi,0FFFF
       jbe       short M03_L18
       movzx     esi,si
       add       rbx,0FFFFFFFFFFFFFFFE
       add       rcx,0FFFFFFFFFFFFFFFE
M03_L18:
       popcnt    esi,esi
       sub       r10d,esi
       sub       rax,rsi
       sub       rax,rsi
       mov       esi,0FFFF
       jmp       short M03_L17
M03_L19:
       add       rax,rbx
       cmp       rcx,rdx
       jbe       near ptr M03_L16
M03_L20:
       cmp       rcx,r11
       jae       short M03_L23
       movzx     edx,word ptr [rcx]
       cmp       edx,7F
       jbe       short M03_L21
       lea       ebx,[rdx+1F800]
       shr       ebx,10
       add       rax,rbx
       add       edx,0FFFF2800
       cmp       edx,7FF
       ja        short M03_L21
       add       rax,0FFFFFFFFFFFFFFFE
       mov       rdx,r11
       sub       rdx,rcx
       cmp       rdx,4
       jb        short M03_L23
       mov       edx,[rcx]
       add       edx,23FF2800
       test      edx,0FC00FC00
       jne       short M03_L23
       dec       r10d
       add       rax,2
       add       rcx,2
M03_L21:
       add       rcx,2
       jmp       short M03_L20
M03_L22:
       add       rcx,0FFFFFFFFFFFFFFF0
       jmp       short M03_L20
M03_L23:
       mov       [r8],rax
       mov       [r9],r10d
       jmp       near ptr M03_L06
; Total bytes of code 628
```
```assembly
; System.Text.UTF8Encoding.GetBytesCommon(Char*, Int32, Byte*, Int32, Boolean)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,58
       lea       rbp,[rsp+80]
       mov       r14,rcx
       mov       rbx,rdx
       mov       esi,r8d
       mov       rdi,r9
       cmp       [r14],r14b
       lea       rcx,[rbp-30]
       mov       [rsp+20],rcx
       lea       rcx,[rbp-38]
       mov       [rsp+28],rcx
       mov       rcx,rbx
       mov       edx,esi
       mov       r8,rdi
       mov       r9d,[rbp+30]
       call      qword ptr [7FFB5E18FB28]; System.Text.Unicode.Utf8Utility.TranscodeToUtf8(Char*, Int32, Byte*, Int32, Char* ByRef, Byte* ByRef)
       mov       rcx,[rbp-30]
       sub       rcx,rbx
       mov       rdx,rcx
       shr       rdx,3F
       add       rcx,rdx
       sar       rcx,1
       mov       eax,[rbp-38]
       sub       eax,edi
       cmp       ecx,esi
       jne       short M04_L00
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M04_L00:
       mov       r15d,[rbp+30]
       mov       [rsp+20],r15d
       mov       [rsp+28],ecx
       mov       [rsp+30],eax
       movzx     ecx,byte ptr [rbp+38]
       mov       [rsp+38],ecx
       mov       rcx,r14
       mov       rdx,rbx
       mov       r8d,esi
       mov       r9,rdi
       call      qword ptr [7FFB5E8FE8E0]
       nop
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 170
```
```assembly
; System.Span`1[[System.Byte, System.Private.CoreLib]]..ctor(Byte[], Int32, Int32)
       sub       rsp,28
       test      rdx,rdx
       je        short M05_L01
       mov       r8d,r8d
       mov       eax,r9d
       add       rax,r8
       mov       r10d,[rdx+8]
       cmp       rax,r10
       ja        short M05_L02
       add       rdx,10
       add       rdx,r8
       mov       [rcx],rdx
       mov       [rcx+8],r9d
M05_L00:
       add       rsp,28
       ret
M05_L01:
       or        r8d,r9d
       jne       short M05_L02
       xor       eax,eax
       mov       [rcx],rax
       mov       [rcx+8],rax
       jmp       short M05_L00
M05_L02:
       call      qword ptr [7FFB5E2F7198]
       int       3
; Total bytes of code 69
```
```assembly
; System.Span`1[[System.Byte, System.Private.CoreLib]].op_Implicit(System.Span`1<Byte>)
       mov       rax,[rdx]
       mov       edx,[rdx+8]
       mov       [rcx],rax
       mov       [rcx+8],edx
       mov       rax,rcx
       ret
; Total bytes of code 16
```
```assembly
; Org.BouncyCastle.Crypto.Digests.KeccakDigest.Absorb(System.ReadOnlySpan`1<Byte>)
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+20],rax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rsi,rdx
       mov       eax,[rbx+1C]
       test      al,7
       jne       short M07_L02
       cmp       byte ptr [rbx+24],0
       jne       near ptr M07_L03
       sar       eax,3
       mov       edi,[rbx+18]
       sar       edi,3
       mov       ebp,[rsi+8]
       mov       r14d,ebp
       mov       r15d,edi
       sub       r15d,eax
       cmp       r14d,r15d
       jge       near ptr M07_L05
       mov       r8,[rbx+10]
       test      r8,r8
       je        near ptr M07_L04
       mov       edi,[r8+8]
       cmp       edi,eax
       jb        near ptr M07_L10
       mov       ecx,eax
       lea       rcx,[r8+rcx+10]
       sub       edi,eax
M07_L00:
       cmp       ebp,edi
       jg        near ptr M07_L14
       mov       rdx,[rsi]
       mov       r8d,ebp
       call      qword ptr [7FFB5E185818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       shl       r14d,3
       add       [rbx+1C],r14d
M07_L01:
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M07_L02:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,301BD
       mov       rdx,7FFB5E803390
       call      qword ptr [7FFB5E3A77B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB5E506088]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M07_L03:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,2F7BF
       mov       rdx,7FFB5E803390
       call      qword ptr [7FFB5E3A77B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB5E506088]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M07_L04:
       test      eax,eax
       jne       near ptr M07_L10
       xor       ecx,ecx
       xor       edi,edi
       jmp       near ptr M07_L00
M07_L05:
       xor       r13d,r13d
       test      eax,eax
       jle       near ptr M07_L09
       cmp       r15d,ebp
       ja        near ptr M07_L10
       mov       rdx,[rsi]
       mov       r8,[rbx+10]
       test      r8,r8
       je        near ptr M07_L10
       mov       ecx,[r8+8]
       cmp       ecx,eax
       jb        near ptr M07_L10
       mov       r10d,eax
       lea       r8,[r8+r10+10]
       sub       ecx,eax
       mov       rax,r8
       cmp       r15d,ecx
       ja        near ptr M07_L14
       mov       r8d,r15d
       mov       rcx,rax
       call      qword ptr [7FFB5E185818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r13d,r15d
       mov       rdx,[rbx+10]
       test      rdx,rdx
       jne       short M07_L06
       xor       ecx,ecx
       xor       edx,edx
       jmp       short M07_L07
M07_L06:
       lea       rcx,[rdx+10]
       mov       edx,[rdx+8]
M07_L07:
       mov       [rsp+20],rcx
       mov       [rsp+28],edx
       lea       rdx,[rsp+20]
       mov       rcx,rbx
       call      qword ptr [7FFB5E7ADA70]
       jmp       short M07_L09
M07_L08:
       mov       edx,[rsi+8]
       sub       edx,r13d
       mov       ecx,r13d
       mov       eax,edx
       add       rcx,rax
       mov       eax,[rsi+8]
       cmp       rcx,rax
       ja        short M07_L10
       mov       ecx,r13d
       add       rcx,[rsi]
       mov       [rsp+20],rcx
       mov       [rsp+28],edx
       lea       rdx,[rsp+20]
       mov       rcx,rbx
       call      qword ptr [7FFB5E7ADA70]
       add       r13d,edi
M07_L09:
       mov       ebp,r14d
       sub       ebp,r13d
       cmp       ebp,edi
       jge       short M07_L08
       mov       r8d,[rsi+8]
       sub       r8d,r13d
       mov       ecx,r13d
       mov       edx,r8d
       add       rcx,rdx
       mov       edx,[rsi+8]
       cmp       rcx,rdx
       jbe       short M07_L11
M07_L10:
       call      qword ptr [7FFB5E2F7198]
       int       3
M07_L11:
       mov       edx,r13d
       add       rdx,[rsi]
       mov       rcx,[rbx+10]
       test      rcx,rcx
       jne       short M07_L12
       xor       eax,eax
       xor       ecx,ecx
       jmp       short M07_L13
M07_L12:
       lea       rax,[rcx+10]
       mov       ecx,[rcx+8]
M07_L13:
       cmp       r8d,ecx
       ja        short M07_L14
       mov       r8d,r8d
       mov       rcx,rax
       call      qword ptr [7FFB5E185818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       shl       ebp,3
       mov       [rbx+1C],ebp
       jmp       near ptr M07_L01
M07_L14:
       call      qword ptr [7FFB5E59D188]
       int       3
; Total bytes of code 583
```
```assembly
; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Rent(Int32)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       rsi,rcx
       mov       ebx,edx
       mov       rcx,15862000C90
       mov       rdi,[rcx]
       lea       ecx,[rbx-1]
       or        ecx,0F
       xor       ebp,ebp
       lzcnt     ebp,ecx
       xor       ebp,1F
       add       ebp,0FFFFFFFD
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],9
       jle       short M08_L02
       mov       rcx,[rcx+240]
       mov       rax,[rcx+48]
       test      rax,rax
       je        short M08_L02
M08_L00:
       mov       rcx,[rax+10]
       test      rcx,rcx
       je        short M08_L04
       mov       eax,[rcx+8]
       cmp       eax,ebp
       jbe       short M08_L04
       mov       eax,ebp
       shl       rax,4
       mov       r14,[rcx+rax+10]
       test      r14,r14
       je        short M08_L04
       xor       edx,edx
       mov       [rcx+rax+10],rdx
       cmp       byte ptr [rdi+9D],0
       jne       short M08_L03
M08_L01:
       mov       rax,r14
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
M08_L02:
       mov       ecx,9
       call      qword ptr [7FFB5E8FD2A8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       short M08_L00
M08_L03:
       mov       rcx,r14
       call      qword ptr [7FFB5E59D830]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       ebx,eax
       mov       r15d,[r14+8]
       cmp       [rsi],sil
       mov       rcx,rsi
       call      qword ptr [7FFB5E59D830]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       [rsp+20],ebp
       mov       edx,ebx
       mov       r8d,r15d
       mov       rcx,rdi
       call      qword ptr [7FFB5E8FEEF8]
       jmp       short M08_L01
M08_L04:
       mov       rcx,[rsi+10]
       cmp       [rcx+8],ebp
       jbe       near ptr M08_L16
       mov       eax,ebp
       mov       rcx,[rcx+rax*8+10]
       test      rcx,rcx
       je        near ptr M08_L15
       mov       r14,[rcx+8]
       mov       rcx,offset MT_System.Threading.ProcessorIdCache
       call      System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       cmp       byte ptr [7FFB5E0CB1D4],0
       je        short M08_L05
       call      qword ptr [7FFB5E8FEF10]
       mov       ebx,eax
       jmp       short M08_L07
M08_L05:
       mov       ecx,0A
       call      qword ptr [7FFB5E8FEF28]
       mov       ebx,[rax+10]
       mov       ecx,0A
       call      qword ptr [7FFB5E8FEF28]
       lea       ecx,[rbx-1]
       mov       [rax+10],ecx
       movzx     eax,bx
       test      eax,eax
       jne       short M08_L06
       call      qword ptr [7FFB5E8FEF40]
       mov       ebx,eax
       jmp       short M08_L07
M08_L06:
       sar       ebx,10
M08_L07:
       mov       rcx,offset MT_System.Buffers.SharedArrayPoolStatics
       call      System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       eax,ebx
       xor       edx,edx
       div       dword ptr [7FFB5E0CB1C8]
       mov       ebx,edx
       xor       r15d,r15d
       jmp       short M08_L11
M08_L08:
       cmp       ebx,[r14+8]
       jae       near ptr M08_L21
       mov       ecx,ebx
       mov       r13,[r14+rcx*8+10]
       cmp       [r13],r13b
       xor       r12d,r12d
       mov       rcx,r13
       call      qword ptr [7FFB5E69E3B8]; System.Threading.Monitor.Enter(System.Object)
       mov       rcx,[r13+8]
       mov       eax,[r13+10]
       dec       eax
       cmp       [rcx+8],eax
       jbe       short M08_L09
       mov       edx,eax
       mov       r12,[rcx+rdx*8+10]
       mov       edx,eax
       xor       r8d,r8d
       mov       [rcx+rdx*8+10],r8
       mov       [r13+10],eax
M08_L09:
       mov       rcx,r13
       call      qword ptr [7FFB5E186820]; System.Threading.Monitor.Exit(System.Object)
       test      r12,r12
       jne       short M08_L12
       inc       ebx
       cmp       [r14+8],ebx
       jne       short M08_L10
       xor       ebx,ebx
M08_L10:
       inc       r15d
M08_L11:
       cmp       [r14+8],r15d
       jg        short M08_L08
       jmp       short M08_L13
M08_L12:
       mov       r14,r12
       jmp       short M08_L14
M08_L13:
       xor       r14d,r14d
M08_L14:
       test      r14,r14
       je        short M08_L15
       cmp       byte ptr [rdi+9D],0
       je        near ptr M08_L01
       mov       rcx,r14
       call      qword ptr [7FFB5E59D830]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       ebx,eax
       mov       r15d,[r14+8]
       mov       rcx,rsi
       call      qword ptr [7FFB5E59D830]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       [rsp+20],ebp
       mov       edx,ebx
       mov       r8d,r15d
       mov       rcx,rdi
       call      qword ptr [7FFB5E8FEEF8]
       jmp       near ptr M08_L01
M08_L15:
       mov       ecx,10
       shlx      ebx,ecx,ebp
       jmp       short M08_L18
M08_L16:
       test      ebx,ebx
       jne       short M08_L17
       mov       rax,198F70262A0
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
M08_L17:
       mov       ecx,ebx
       mov       rdx,198F7026F28
       call      qword ptr [7FFB5E3AD8C0]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
M08_L18:
       cmp       ebx,800
       jge       short M08_L19
       movsxd    rdx,ebx
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
       jmp       short M08_L20
M08_L19:
       mov       ecx,ebx
       xor       edx,edx
       call      qword ptr [7FFB5E8FEEE0]
       mov       r14,rax
M08_L20:
       cmp       byte ptr [rdi+9D],0
       je        near ptr M08_L01
       cmp       [r14],r14b
       mov       rcx,r14
       call      qword ptr [7FFB5E59D830]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       ebx,eax
       mov       r15d,[r14+8]
       mov       rcx,rsi
       call      qword ptr [7FFB5E59D830]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       edx,ebx
       mov       r8d,r15d
       mov       rcx,rdi
       call      qword ptr [7FFB5E8FEEF8]
       mov       r15d,[r14+8]
       mov       rcx,rsi
       call      qword ptr [7FFB5E59D830]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       rcx,[rsi+10]
       mov       edx,1
       mov       r8d,2
       cmp       [rcx+8],ebp
       cmovg     edx,r8d
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       [rsp+28],edx
       mov       rcx,rdi
       mov       edx,ebx
       mov       r8d,r15d
       call      qword ptr [7FFB5E8FEF58]
       jmp       near ptr M08_L01
M08_L21:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 796
```
```assembly
; Org.BouncyCastle.Crypto.Digests.Sha3Digest.DoFinal(Byte[], Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       r9d,[rbx+1C]
       test      r9b,7
       jne       near ptr M09_L07
       cmp       byte ptr [rbx+24],0
       jne       near ptr M09_L08
       mov       rcx,[rbx+10]
       mov       eax,r9d
       sar       eax,3
       cmp       eax,[rcx+8]
       jae       near ptr M09_L24
       mov       byte ptr [rcx+rax+10],2
       add       r9d,2
       mov       [rbx+1C],r9d
       movsxd    r9,dword ptr [rbx+20]
       mov       rcx,rbx
       call      qword ptr [7FFB5E8F62B0]; Org.BouncyCastle.Crypto.Digests.KeccakDigest.Squeeze(Byte[], Int32, Int64)
       mov       rcx,offset MT_Org.BouncyCastle.Crypto.Digests.Sha3Digest
       cmp       [rbx],rcx
       jne       near ptr M09_L23
       mov       rsi,rbx
       mov       edi,[rsi+20]
       cmp       edi,100
       jle       near ptr M09_L09
       cmp       edi,120
       je        short M09_L00
       cmp       edi,180
       jne       near ptr M09_L11
M09_L00:
       add       edi,edi
       neg       edi
       add       edi,640
       mov       ecx,edi
       sub       ecx,1
       cmp       ecx,63E
       ja        near ptr M09_L12
       test      dil,3F
       jne       near ptr M09_L12
       mov       [rsi+18],edi
       mov       rcx,[rsi+8]
       mov       rdx,rcx
       mov       ecx,[rcx+8]
       lea       rax,[rdx+10]
       xor       r8d,r8d
       mov       r10,[rdx]
       cmp       dword ptr [r10+4],18
       jne       near ptr M09_L13
M09_L01:
       mov       r9d,r8d
       neg       r9d
       test      r8d,r8d
       jg        near ptr M09_L14
       test      r9d,r9d
       jl        near ptr M09_L14
       lea       r8d,[r9+rcx]
       cmp       r8d,[rdx+8]
       ja        near ptr M09_L14
       movzx     edx,word ptr [r10]
       mov       r8d,r9d
       imul      r8,rdx
       add       r8,rax
       mov       ecx,ecx
       imul      rdx,rcx
       test      dword ptr [r10],1000000
       jne       near ptr M09_L15
       mov       rcx,r8
       call      qword ptr [7FFB5E1857E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
M09_L02:
       mov       rax,[rsi+10]
       test      rax,rax
       je        near ptr M09_L16
       lea       rcx,[rax+10]
       mov       eax,[rax+8]
       mov       rdx,rcx
       cmp       rax,20
       jb        near ptr M09_L18
       mov       rdx,rax
       and       rdx,0FFFFFFFFFFFFFFC0
       xor       r8d,r8d
       cmp       rax,40
       jb        short M09_L04
M09_L03:
       vxorps    ymm0,ymm0,ymm0
       vmovups   [rcx+r8],ymm0
       vmovups   [rcx+r8+20],ymm0
       add       r8,40
       cmp       r8,rdx
       jb        short M09_L03
M09_L04:
       test      al,20
       jne       near ptr M09_L17
M09_L05:
       vxorps    ymm0,ymm0,ymm0
       vmovups   [rcx+rax-20],ymm0
M09_L06:
       xor       eax,eax
       mov       [rbx+1C],eax
       mov       byte ptr [rbx+24],0
       mov       eax,edi
       neg       eax
       add       eax,640
       sar       eax,1
       mov       [rbx+20],eax
       sar       eax,3
       vzeroupper
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M09_L07:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,301BD
       mov       rdx,7FFB5E803390
       call      qword ptr [7FFB5E3A77B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB5E506088]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M09_L08:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,2F7BF
       mov       rdx,7FFB5E803390
       call      qword ptr [7FFB5E3A77B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB5E506088]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M09_L09:
       cmp       edi,80
       je        near ptr M09_L00
       cmp       edi,0E0
       je        near ptr M09_L00
       cmp       edi,100
       je        near ptr M09_L00
M09_L10:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       ecx,30149
       mov       rdx,7FFB5E803390
       call      qword ptr [7FFB5E3A77B0]
       mov       rsi,rax
       mov       ecx,301A9
       mov       rdx,7FFB5E803390
       call      qword ptr [7FFB5E3A77B0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFB5E506130]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M09_L11:
       cmp       edi,200
       jne       short M09_L10
       jmp       near ptr M09_L00
M09_L12:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,126E3
       mov       rdx,7FFB5E803390
       call      qword ptr [7FFB5E3A77B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB5E506088]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M09_L13:
       mov       r9d,[r10+4]
       add       r9d,0FFFFFFE8
       shr       r9d,3
       movsxd    r8,r9d
       mov       r8d,[rax+r8*4]
       shl       r9d,3
       movsxd    r9,r9d
       add       rax,r9
       jmp       near ptr M09_L01
M09_L14:
       call      qword ptr [7FFB5E8FEDF0]
       int       3
M09_L15:
       shr       rdx,3
       mov       rcx,r8
       call      qword ptr [7FFB5E8FEE08]
       jmp       near ptr M09_L02
M09_L16:
       mov       ecx,2
       call      qword ptr [7FFB5E3AC240]
       int       3
M09_L17:
       vxorps    ymm0,ymm0,ymm0
       vmovups   [rcx+r8],ymm0
       jmp       near ptr M09_L05
M09_L18:
       xor       ecx,ecx
       cmp       rax,8
       jb        short M09_L20
       mov       r8,rax
       and       r8,0FFFFFFFFFFFFFFF8
M09_L19:
       xor       r10d,r10d
       mov       [rdx+rcx],r10
       add       rcx,8
       cmp       rcx,r8
       jb        short M09_L19
M09_L20:
       test      al,4
       je        short M09_L21
       xor       r8d,r8d
       mov       [rdx+rcx],r8d
       add       rcx,4
M09_L21:
       test      al,2
       je        short M09_L22
       mov       word ptr [rdx+rcx],0
       add       rcx,2
M09_L22:
       test      al,1
       je        near ptr M09_L06
       mov       byte ptr [rdx+rcx],0
       jmp       near ptr M09_L06
M09_L23:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       vzeroupper
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax+28]
M09_L24:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 939
```
```assembly
; System.Convert.ToBase64String(Byte[], Int32, Int32, System.Base64FormattingOptions)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       mov       [rsp+40],rax
       mov       esi,edx
       mov       ebx,r8d
       mov       edi,r9d
       test      rcx,rcx
       je        near ptr M10_L18
       test      ebx,ebx
       jl        near ptr M10_L19
       test      esi,esi
       jl        near ptr M10_L20
       mov       ebp,[rcx+8]
       sub       ebp,ebx
       cmp       esi,ebp
       jl        short M10_L00
       cmp       esi,ebp
       jg        near ptr M10_L05
M10_L00:
       mov       eax,esi
       mov       edx,ebx
       add       rax,rdx
       mov       edx,[rcx+8]
       cmp       rax,rdx
       ja        near ptr M10_L21
       mov       eax,esi
       lea       rbp,[rcx+rax+10]
       cmp       edi,1
       ja        near ptr M10_L22
       test      ebx,ebx
       je        near ptr M10_L23
       cmp       edi,1
       sete      dil
       movzx     edi,dil
       lea       ecx,[rbx+2]
       mov       eax,0AAAAAAAB
       mov       edx,ecx
       imul      rax,rdx
       shr       rax,21
       shl       eax,2
       je        near ptr M10_L24
       test      edi,edi
       jne       near ptr M10_L25
M10_L01:
       test      eax,eax
       jl        near ptr M10_L26
M10_L02:
       movsxd    rdx,eax
       mov       rcx,offset MT_System.String
       call      00007FFBBDE29F20
       mov       rsi,rax
       test      edi,edi
       jne       near ptr M10_L32
       cmp       ebx,10
       jl        near ptr M10_L32
       lea       rcx,[rsi+0C]
       mov       edx,[rsi+8]
       imul      r9d,edx,2
       jo        near ptr M10_L35
       mov       [rsp+30],rbp
       mov       [rsp+28],rcx
       mov       r8,rcx
       cmp       ebx,5FFFFFFD
       jg        near ptr M10_L27
       lea       eax,[rbx+2]
       mov       r10d,0AAAAAAAB
       imul      rax,r10
       shr       rax,21
       shl       eax,2
       cmp       eax,r9d
       jg        near ptr M10_L27
       mov       eax,ebx
M10_L03:
       mov       r9,rbp
       mov       r10,r8
       mov       r11d,ebx
       add       r11,r9
       mov       edi,eax
       add       rdi,r9
       cmp       eax,10
       jl        near ptr M10_L09
       lea       rax,[rdi-20]
       cmp       rax,r9
       jb        near ptr M10_L07
       vmovups   ymm0,[7FFB5E9B25C0]
       vpermd    ymm0,ymm0,[rbp]
       add       rbp,0FFFFFFFFFFFFFFFC
M10_L04:
       vpshufb   ymm0,ymm0,[7FFB5E9B25E0]
       vpand     ymm1,ymm0,[7FFB5E9B2600]
       vpmulhuw  ymm1,ymm1,[7FFB5E9B2620]
       vpand     ymm0,ymm0,[7FFB5E9B2640]
       vpmullw   ymm0,ymm0,[7FFB5E9B2660]
       vpor      ymm0,ymm0,ymm1
       vpsubusb  ymm1,ymm0,[7FFB5E9B2680]
       vpcmpgtb  ymm2,ymm0,[7FFB5E9B26A0]
       vpsubb    ymm1,ymm1,ymm2
       vbroadcastf128 ymm2,xmmword ptr [7FFB5E9B26C0]
       vpshufb   ymm1,ymm2,ymm1
       vpaddb    ymm0,ymm1,ymm0
       vmovups   [r8],ymm0
       add       rbp,18
       add       r8,20
       cmp       rbp,rax
       ja        short M10_L06
       vmovups   ymm0,[rbp]
       jmp       short M10_L04
M10_L05:
       mov       ecx,1149
       mov       rdx,7FFB5E0C4000
       call      qword ptr [7FFB5E3A77B0]
       mov       r8,rax
       mov       edx,ebp
       mov       ecx,esi
       call      qword ptr [7FFB5E8FEFA0]
       int       3
M10_L06:
       lea       r9,[rbp+4]
       mov       r10,r8
       cmp       r9,r11
       je        near ptr M10_L12
M10_L07:
       lea       rax,[rdi-10]
       cmp       rax,r9
       jb        short M10_L09
M10_L08:
       vmovups   xmm0,[r9]
       vpshufb   xmm0,xmm0,[7FFB5E9B26D0]
       vpand     xmm1,xmm0,[7FFB5E9B2600]
       vpmulhuw  xmm1,xmm1,[7FFB5E9B2620]
       vpand     xmm0,xmm0,[7FFB5E9B2640]
       vpmullw   xmm0,xmm0,[7FFB5E9B2660]
       vpor      xmm0,xmm0,xmm1
       vpsubusb  xmm1,xmm0,[7FFB5E9B2680]
       vpcmpgtb  xmm2,xmm0,[7FFB5E9B26A0]
       vpsubb    xmm1,xmm1,xmm2
       vmovups   xmm2,[7FFB5E9B26C0]
       vpshufb   xmm1,xmm2,xmm1
       vpaddb    xmm0,xmm1,xmm0
       vmovups   [r10],xmm0
       add       r9,0C
       add       r10,10
       cmp       r9,rax
       jbe       short M10_L08
       cmp       r9,r11
       je        near ptr M10_L12
M10_L09:
       mov       r8,7FFBBCF94BE0
       add       rdi,0FFFFFFFFFFFFFFFE
       cmp       r9,rdi
       jae       short M10_L11
M10_L10:
       movzx     eax,byte ptr [r9]
       shl       eax,10
       movzx     ebx,byte ptr [r9+1]
       shl       ebx,8
       or        eax,ebx
       movzx     ebx,byte ptr [r9+2]
       or        eax,ebx
       mov       ebx,eax
       shr       ebx,12
       movzx     ebx,byte ptr [r8+rbx]
       mov       ebp,eax
       shr       ebp,0C
       and       ebp,3F
       movzx     ebp,byte ptr [r8+rbp]
       shl       ebp,8
       or        ebx,ebp
       mov       ebp,eax
       shr       ebp,6
       and       ebp,3F
       movzx     ebp,byte ptr [r8+rbp]
       shl       ebp,10
       or        ebx,ebp
       and       eax,3F
       movzx     eax,byte ptr [r8+rax]
       shl       eax,18
       or        eax,ebx
       mov       [r10],eax
       add       r9,3
       add       r10,4
       cmp       r9,rdi
       jb        short M10_L10
M10_L11:
       lea       rax,[rdi+2]
       cmp       rax,r11
       jne       short M10_L12
       lea       rax,[r9+1]
       cmp       rax,r11
       je        near ptr M10_L28
       lea       rax,[r9+2]
       cmp       rax,r11
       je        near ptr M10_L29
M10_L12:
       xor       r9d,r9d
       mov       [rsp+30],r9
       mov       [rsp+28],r9
       mov       r9d,edx
       lea       r9,[rcx+r9*2]
       mov       edx,edx
       add       rdx,rcx
       lea       r8,[rcx+1F]
       cmp       rdx,r8
       jbe       short M10_L14
M10_L13:
       add       rdx,0FFFFFFFFFFFFFFE0
       add       r9,0FFFFFFFFFFFFFFC0
       vmovups   ymm0,[rdx]
       vmovaps   ymm1,ymm0
       vpmovzxbw ymm1,xmm1
       vextracti128 xmm0,ymm0,1
       vpmovzxbw ymm0,xmm0
       vmovups   [r9],ymm1
       vmovups   [r9+20],ymm0
       cmp       rdx,r8
       ja        short M10_L13
M10_L14:
       lea       r8,[rcx+0F]
       cmp       rdx,r8
       ja        near ptr M10_L30
M10_L15:
       add       rcx,3
       cmp       rdx,rcx
       ja        near ptr M10_L31
M10_L16:
       mov       rax,rsi
M10_L17:
       vzeroupper
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M10_L18:
       mov       ecx,1139
       mov       rdx,7FFB5E0C4000
       call      qword ptr [7FFB5E3A77B0]
       mov       rcx,rax
       call      qword ptr [7FFB5E8FD098]
       int       3
M10_L19:
       mov       ecx,0B3
       mov       rdx,7FFB5E0C4000
       call      qword ptr [7FFB5E3A77B0]
       mov       rdx,rax
       mov       ecx,ebx
       call      qword ptr [7FFB5E8FD068]
       int       3
M10_L20:
       mov       ecx,1149
       mov       rdx,7FFB5E0C4000
       call      qword ptr [7FFB5E3A77B0]
       mov       rdx,rax
       mov       ecx,esi
       call      qword ptr [7FFB5E8FD068]
       int       3
M10_L21:
       call      qword ptr [7FFB5E2F7198]
       int       3
M10_L22:
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFB5E8FE8F8]
       mov       rsi,rax
       mov       [rbx+8],edi
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB5E8FD8A8]
       mov       rbx,rax
       mov       ecx,1157
       mov       rdx,7FFB5E0C4000
       call      qword ptr [7FFB5E3A77B0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FFB5E506130]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M10_L23:
       mov       rax,198F7020008
       jmp       near ptr M10_L17
M10_L24:
       xor       eax,eax
       jmp       near ptr M10_L02
M10_L25:
       mov       ecx,eax
       shr       ecx,2
       imul      rcx,1AF286BD
       shr       rcx,21
       imul      edx,ecx,4C
       mov       r8d,eax
       sub       r8d,edx
       mov       edx,ecx
       dec       ecx
       test      r8d,r8d
       cmove     edx,ecx
       lea       eax,[rax+rdx*2]
       jmp       near ptr M10_L01
M10_L26:
       mov       rcx,offset MT_System.OutOfMemoryException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       call      qword ptr [7FFB5E8FE1D8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M10_L27:
       sar       r9d,2
       lea       eax,[r9+r9*2]
       jmp       near ptr M10_L03
M10_L28:
       movzx     r9d,byte ptr [r9]
       shl       r9d,8
       mov       eax,r9d
       shr       eax,0A
       movzx     eax,byte ptr [r8+rax]
       shr       r9d,4
       and       r9d,3F
       movzx     r9d,byte ptr [r8+r9]
       shl       r9d,8
       or        r9d,eax
       or        r9d,3D3D0000
       mov       [r10],r9d
       jmp       near ptr M10_L12
M10_L29:
       movzx     eax,byte ptr [r9]
       shl       eax,10
       movzx     r9d,byte ptr [r9+1]
       shl       r9d,8
       or        r9d,eax
       mov       eax,r9d
       shr       eax,12
       movzx     eax,byte ptr [r8+rax]
       mov       r11d,r9d
       shr       r11d,0C
       and       r11d,3F
       movzx     r11d,byte ptr [r8+r11]
       shl       r11d,8
       or        eax,r11d
       shr       r9d,6
       and       r9d,3F
       movzx     r8d,byte ptr [r8+r9]
       shl       r8d,10
       or        r8d,eax
       or        r8d,3D000000
       mov       [r10],r8d
       jmp       near ptr M10_L12
M10_L30:
       add       rdx,0FFFFFFFFFFFFFFF0
       add       r9,0FFFFFFFFFFFFFFE0
       vmovups   xmm0,[rdx]
       vpmovzxbw xmm1,xmm0
       vpsrldq   xmm0,xmm0,8
       vpmovzxbw xmm0,xmm0
       vmovups   [r9],xmm1
       vmovups   [r9+10],xmm0
       cmp       rdx,r8
       ja        short M10_L30
       jmp       near ptr M10_L15
M10_L31:
       add       r9,0FFFFFFFFFFFFFFF8
       add       rdx,0FFFFFFFFFFFFFFFC
       vmovd     xmm0,dword ptr [rdx]
       vpmovzxbw xmm0,xmm0
       vmovq     qword ptr [r9],xmm0
       cmp       rdx,rcx
       ja        short M10_L31
       jmp       near ptr M10_L16
M10_L32:
       mov       [rsp+40],rbp
       mov       rdx,rbp
       test      rsi,rsi
       jne       short M10_L33
       xor       ecx,ecx
       jmp       short M10_L34
M10_L33:
       lea       rcx,[rsi+0C]
       mov       [rsp+38],rcx
       mov       rcx,[rsp+38]
M10_L34:
       mov       [rsp+20],edi
       mov       r9d,ebx
       xor       r8d,r8d
       call      qword ptr [7FFB5E8FE910]
       xor       eax,eax
       mov       [rsp+38],rax
       mov       [rsp+40],rax
       jmp       near ptr M10_L16
M10_L35:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 1521
```
```assembly
; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Return(Byte[], Boolean)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       mov       rdi,rcx
       mov       rbx,rdx
       mov       esi,r8d
       test      rbx,rbx
       je        near ptr M11_L07
       mov       ebp,[rbx+8]
       lea       ecx,[rbp-1]
       or        ecx,0F
       xor       r14d,r14d
       lzcnt     r14d,ecx
       xor       r14d,1F
       add       r14d,0FFFFFFFD
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],9
       jle       near ptr M11_L05
       mov       rcx,[rcx+240]
       mov       rax,[rcx+48]
       test      rax,rax
       je        near ptr M11_L05
M11_L00:
       mov       r15,[rax+10]
       test      r15,r15
       je        near ptr M11_L06
M11_L01:
       xor       r13d,r13d
       mov       r12d,1
       cmp       [r15+8],r14d
       jbe       short M11_L03
       mov       r13d,1
       test      sil,sil
       je        short M11_L02
       mov       rcx,[rbx]
       movzx     edx,word ptr [rcx]
       mov       eax,[rbx+8]
       imul      rdx,rax
       lea       rax,[rbx+10]
       test      dword ptr [rcx],1000000
       jne       near ptr M11_L08
       mov       rcx,rax
       call      qword ptr [7FFB5E1857E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
M11_L02:
       mov       ecx,10
       shlx      ecx,ecx,r14d
       cmp       ebp,ecx
       jne       near ptr M11_L09
       mov       ecx,r14d
       shl       rcx,4
       lea       rsi,[r15+rcx+10]
       mov       r15,[rsi]
       mov       rcx,rsi
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+8],ecx
       test      r15,r15
       jne       near ptr M11_L10
M11_L03:
       mov       rcx,15862000C90
       mov       rsi,[rcx]
       cmp       byte ptr [rsi+9D],0
       jne       near ptr M11_L25
M11_L04:
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
M11_L05:
       mov       ecx,9
       call      qword ptr [7FFB5E8FD2A8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M11_L00
M11_L06:
       mov       rcx,rdi
       call      qword ptr [7FFB5E8F6460]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
       mov       r15,rax
       jmp       near ptr M11_L01
M11_L07:
       mov       ecx,2
       call      qword ptr [7FFB5E3AC240]
       int       3
M11_L08:
       shr       rdx,3
       mov       rcx,rax
       call      qword ptr [7FFB5E8FEE08]
       jmp       near ptr M11_L02
M11_L09:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       call      qword ptr [7FFB5E8FF048]
       mov       rbx,rax
       mov       ecx,29B
       mov       rdx,7FFB5E0C4000
       call      qword ptr [7FFB5E3A77B0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rbp
       call      qword ptr [7FFB5E506130]
       mov       rcx,rbp
       call      CORINFO_HELP_THROW
       int       3
M11_L10:
       mov       rcx,[rdi+10]
       cmp       r14d,[rcx+8]
       jae       near ptr M11_L28
       mov       edx,r14d
       mov       rax,[rcx+rdx*8+10]
       test      rax,rax
       jne       short M11_L11
       mov       rcx,rdi
       mov       edx,r14d
       call      qword ptr [7FFB5E8FF060]
M11_L11:
       mov       r12,[rax+8]
       mov       rcx,offset MT_System.Threading.ProcessorIdCache
       call      System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       cmp       byte ptr [7FFB5E0CB1D4],0
       je        short M11_L12
       call      qword ptr [7FFB5E8FEF10]
       mov       esi,eax
       jmp       short M11_L14
M11_L12:
       mov       ecx,0A
       call      qword ptr [7FFB5E8FEF28]
       mov       esi,[rax+10]
       mov       ecx,0A
       call      qword ptr [7FFB5E8FEF28]
       lea       ecx,[rsi-1]
       mov       [rax+10],ecx
       movzx     eax,si
       test      eax,eax
       jne       short M11_L13
       call      qword ptr [7FFB5E8FEF40]
       mov       esi,eax
       jmp       short M11_L14
M11_L13:
       sar       esi,10
M11_L14:
       mov       rcx,offset MT_System.Buffers.SharedArrayPoolStatics
       call      System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       eax,esi
       xor       edx,edx
       div       dword ptr [7FFB5E0CB1C8]
       mov       esi,edx
       xor       eax,eax
       jmp       near ptr M11_L21
M11_L15:
       cmp       esi,[r12+8]
       jae       near ptr M11_L28
       mov       ecx,esi
       mov       rdx,[r12+rcx*8+10]
       mov       [rsp+30],rdx
       cmp       [rdx],dl
       xor       r8d,r8d
       mov       [rsp+3C],r8d
       mov       rcx,rdx
       call      qword ptr [7FFB5E69E3B8]; System.Threading.Monitor.Enter(System.Object)
       mov       rax,[rsp+30]
       mov       rcx,[rax+8]
       mov       r8d,[rax+10]
       mov       [rsp+38],r8d
       cmp       [rcx+8],r8d
       jbe       short M11_L17
       test      r8d,r8d
       jne       short M11_L18
       xor       edx,edx
       mov       [rax+14],edx
M11_L16:
       mov       edx,r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rsp+38]
       inc       ecx
       mov       rax,[rsp+30]
       mov       [rax+10],ecx
       mov       dword ptr [rsp+3C],1
M11_L17:
       mov       rcx,rax
       call      qword ptr [7FFB5E186820]; System.Threading.Monitor.Exit(System.Object)
       cmp       dword ptr [rsp+3C],0
       je        short M11_L19
       jmp       short M11_L22
M11_L18:
       jmp       short M11_L16
M11_L19:
       inc       esi
       cmp       [r12+8],esi
       jne       short M11_L20
       xor       esi,esi
M11_L20:
       mov       eax,[rsp+40]
       inc       eax
M11_L21:
       mov       [rsp+40],eax
       cmp       [r12+8],eax
       jg        near ptr M11_L15
       jmp       short M11_L23
M11_L22:
       mov       r12d,1
       jmp       short M11_L24
M11_L23:
       xor       r12d,r12d
M11_L24:
       jmp       near ptr M11_L03
M11_L25:
       test      ebp,ebp
       je        near ptr M11_L04
       mov       rcx,rbx
       call      qword ptr [7FFB5E59D830]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r15d,eax
       mov       [rsp+44],ebp
       cmp       [rdi],dil
       mov       rcx,rdi
       call      qword ptr [7FFB5E59D830]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,rsi
       mov       r8d,r15d
       mov       r9d,[rsp+44]
       mov       edx,3
       call      qword ptr [7FFB5E8FE790]
       test      r12d,r13d
       jne       near ptr M11_L04
       mov       rcx,rbx
       call      qword ptr [7FFB5E59D830]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       ebx,eax
       mov       rcx,rdi
       call      qword ptr [7FFB5E59D830]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       test      r13d,r13d
       jne       short M11_L26
       mov       ecx,0FFFFFFFF
       mov       edx,1
       jmp       short M11_L27
M11_L26:
       mov       ecx,r14d
       xor       edx,edx
M11_L27:
       mov       [rsp+20],ecx
       mov       [rsp+28],edx
       mov       rcx,rsi
       mov       edx,ebx
       mov       r8d,ebp
       call      qword ptr [7FFB5E8FF078]
       jmp       near ptr M11_L04
M11_L28:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 913
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Security.PasswordHasherBenchmark.HashPasswordSHA3512()
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       lea       rbp,[rsp+0B0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-70],ymm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       xor       eax,eax
       mov       [rbp-40],rax
       mov       rcx,offset MT_Org.BouncyCastle.Crypto.Digests.Sha3Digest
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,offset MT_System.UInt64[]
       mov       edx,19
       call      CORINFO_HELP_NEWARR_1_PTR
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Byte[]
       mov       edx,0C0
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rbx+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+18],240
       mov       rcx,[rbx+8]
       mov       rdx,rcx
       mov       ecx,[rcx+8]
       lea       rax,[rdx+10]
       xor       r8d,r8d
       mov       r10,[rdx]
       cmp       dword ptr [r10+4],18
       jne       near ptr M00_L05
M00_L00:
       mov       r9d,r8d
       neg       r9d
       test      r8d,r8d
       jg        near ptr M00_L06
       test      r9d,r9d
       jl        near ptr M00_L06
       lea       r8d,[r9+rcx]
       cmp       r8d,[rdx+8]
       ja        near ptr M00_L06
       movzx     edx,word ptr [r10]
       mov       r8d,r9d
       imul      r8,rdx
       add       r8,rax
       mov       ecx,ecx
       imul      rdx,rcx
       test      dword ptr [r10],1000000
       jne       near ptr M00_L07
       mov       rcx,r8
       call      qword ptr [7FFB5E1A57E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
M00_L01:
       mov       rdx,[rbx+10]
       test      rdx,rdx
       je        near ptr M00_L08
       lea       rcx,[rdx+10]
       mov       edx,[rdx+8]
       xor       r8d,r8d
       call      qword ptr [7FFB5E7CD980]; System.SpanHelpers.Fill[[System.Byte, System.Private.CoreLib]](Byte ByRef, UIntPtr, Byte)
       xor       r8d,r8d
       mov       [rbx+1C],r8d
       mov       byte ptr [rbx+24],0
       mov       dword ptr [rbx+20],200
       mov       r8,20BC2800220
       mov       rsi,[r8]
       mov       rdi,24C577A06E0
       add       rdi,0C
       mov       r14,rdi
       lea       r8,[rbp-30]
       lea       r9,[rbp-38]
       mov       rcx,r14
       mov       edx,40
       call      qword ptr [7FFB5E1AFAF8]; System.Text.Unicode.Utf16Utility.GetPointerToFirstInvalidChar(Char*, Int32, Int64 ByRef, Int32 ByRef)
       sub       rax,r14
       mov       r9,rax
       shr       r9,3F
       add       r9,rax
       sar       r9,1
       movsxd    r15,r9d
       add       r15,[rbp-30]
       cmp       r15,7FFFFFFF
       ja        near ptr M00_L10
       cmp       r9d,40
       jne       near ptr M00_L09
M00_L02:
       movsxd    rdx,r15d
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
       mov       r15d,[r14+8]
       test      r15d,r15d
       jl        near ptr M00_L11
       mov       rdx,rdi
       mov       [rbp-40],r14
       test      r15d,r15d
       je        near ptr M00_L12
       lea       r9,[r14+10]
M00_L03:
       mov       [rsp+20],r15d
       mov       dword ptr [rsp+28],1
       mov       rcx,rsi
       mov       r8d,40
       call      qword ptr [7FFB5EA74750]; System.Text.UTF8Encoding.GetBytesCommon(Char*, Int32, Byte*, Int32, Boolean)
       xor       ecx,ecx
       mov       [rbp-40],rcx
       mov       rdx,r14
       mov       r9d,r15d
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-60],xmm0
       lea       rcx,[rbp-60]
       xor       r8d,r8d
       call      qword ptr [7FFB5EA74768]; System.Span`1[[System.Byte, System.Private.CoreLib]]..ctor(Byte[], Int32, Int32)
       vmovdqu   xmm0,xmmword ptr [rbp-60]
       vmovdqu   xmmword ptr [rbp-70],xmm0
       lea       rdx,[rbp-70]
       lea       rcx,[rbp-50]
       call      qword ptr [7FFB5E5BCB28]; System.Span`1[[System.Byte, System.Private.CoreLib]].op_Implicit(System.Span`1<Byte>)
       lea       rdx,[rbp-50]
       mov       rcx,rbx
       call      qword ptr [7FFB5E7CDA28]; Org.BouncyCastle.Crypto.Digests.KeccakDigest.Absorb(System.ReadOnlySpan`1<Byte>)
       mov       esi,[rbx+20]
       sar       esi,3
       mov       rcx,20BD8800158
       mov       rcx,[rcx]
       mov       edx,esi
       call      qword ptr [7FFB5E7D1190]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Rent(Int32)
       mov       [rbp-78],rax
       mov       rcx,rbx
       mov       rdx,[rbp-78]
       xor       r8d,r8d
       call      qword ptr [7FFB5E824210]; Org.BouncyCastle.Crypto.Digests.Sha3Digest.DoFinal(Byte[], Int32)
       mov       rcx,[rbp-78]
       mov       r8d,esi
       xor       edx,edx
       xor       r9d,r9d
       call      qword ptr [7FFB5E916448]; System.Convert.ToBase64String(Byte[], Int32, Int32, System.Base64FormattingOptions)
       mov       rbx,rax
       jmp       short M00_L04
       int       3
M00_L04:
       mov       rcx,20BC2801E28
       mov       rcx,[rcx]
       mov       rdx,[rbp-78]
       mov       r8d,1
       call      qword ptr [7FFB5E7D1198]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Return(Byte[], Boolean)
       mov       rax,rbx
       add       rsp,88
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L05:
       mov       r9d,[r10+4]
       add       r9d,0FFFFFFE8
       shr       r9d,3
       movsxd    r8,r9d
       mov       r8d,[rax+r8*4]
       shl       r9d,3
       movsxd    r9,r9d
       add       rax,r9
       jmp       near ptr M00_L00
M00_L06:
       call      qword ptr [7FFB5E91EC88]
       int       3
M00_L07:
       shr       rdx,3
       mov       rcx,r8
       call      qword ptr [7FFB5E91ECA0]
       jmp       near ptr M00_L01
M00_L08:
       mov       ecx,2
       call      qword ptr [7FFB5E3CC240]
       int       3
M00_L09:
       mov       rcx,rsi
       mov       rdx,r14
       mov       r8d,40
       call      qword ptr [7FFB5E91E640]
       add       r15d,eax
       jns       near ptr M00_L02
M00_L10:
       call      qword ptr [7FFB5E73E880]
       int       3
M00_L11:
       mov       ecx,0B
       xor       edx,edx
       call      qword ptr [7FFB5E7366B8]
       int       3
M00_L12:
       xor       r9d,r9d
       jmp       near ptr M00_L03
       sub       rsp,38
       mov       rcx,20BC2801E28
       mov       rcx,[rcx]
       mov       rdx,[rcx]
       mov       rdx,[rbp-78]
       mov       r8d,1
       call      qword ptr [7FFB5E7D1198]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Return(Byte[], Boolean)
       add       rsp,38
       ret
; Total bytes of code 828
```
```assembly
; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
       push      rbx
       test      rdx,rdx
       je        short M01_L03
       lea       rbx,[rcx+rdx]
       cmp       rdx,10
       jbe       short M01_L05
       cmp       rdx,40
       jbe       short M01_L04
       cmp       rdx,400
       ja        near ptr M01_L09
       cmp       rdx,100
       jae       near ptr M01_L08
M01_L00:
       mov       rax,rdx
       shr       rax,6
M01_L01:
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       dec       rax
       jne       short M01_L01
       and       rdx,3F
       cmp       rdx,10
       ja        short M01_L04
M01_L02:
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rbx-10],xmm0
M01_L03:
       pop       rbx
       ret
M01_L04:
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rcx],xmm0
       cmp       rdx,20
       jbe       short M01_L02
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rcx+10],xmm0
       cmp       rdx,30
       jbe       short M01_L02
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rcx+20],xmm0
       jmp       short M01_L02
M01_L05:
       test      dl,18
       je        short M01_L06
       xor       eax,eax
       mov       [rcx],rax
       mov       [rbx-8],rax
       jmp       short M01_L03
M01_L06:
       test      dl,4
       je        short M01_L07
       xor       eax,eax
       mov       [rcx],eax
       mov       [rbx-4],eax
       jmp       short M01_L03
M01_L07:
       mov       byte ptr [rcx],0
       test      dl,2
       je        short M01_L03
       mov       word ptr [rbx-2],0
       jmp       short M01_L03
M01_L08:
       mov       rax,rcx
       and       rax,3F
       neg       rax
       add       rax,40
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,rax
       sub       rdx,rax
       jmp       near ptr M01_L00
M01_L09:
       cmp       [rcx],cl
       pop       rbx
       jmp       qword ptr [7FFB5E91E220]
; Total bytes of code 231
```
```assembly
; System.SpanHelpers.Fill[[System.Byte, System.Private.CoreLib]](Byte ByRef, UIntPtr, Byte)
       cmp       rdx,20
       jb        short M02_L05
       vmovd     xmm0,r8d
       vpbroadcastb ymm0,xmm0
       mov       r8,rdx
       and       r8,0FFFFFFFFFFFFFFC0
       xor       eax,eax
       cmp       rdx,40
       jb        short M02_L01
M02_L00:
       vmovups   [rcx+rax],ymm0
       vmovups   [rcx+rax+20],ymm0
       add       rax,40
       cmp       rax,r8
       jb        short M02_L00
M02_L01:
       test      dl,20
       jne       short M02_L04
M02_L02:
       vmovups   [rcx+rdx-20],ymm0
M02_L03:
       vzeroupper
       ret
M02_L04:
       vmovups   [rcx+rax],ymm0
       jmp       short M02_L02
M02_L05:
       xor       eax,eax
       cmp       rdx,8
       jb        short M02_L07
       mov       r10,rdx
       and       r10,0FFFFFFFFFFFFFFF8
M02_L06:
       mov       [rcx+rax],r8b
       mov       [rcx+rax+1],r8b
       mov       [rcx+rax+2],r8b
       mov       [rcx+rax+3],r8b
       mov       [rcx+rax+4],r8b
       mov       [rcx+rax+5],r8b
       mov       [rcx+rax+6],r8b
       mov       [rcx+rax+7],r8b
       add       rax,8
       cmp       rax,r10
       jb        short M02_L06
M02_L07:
       test      dl,4
       je        short M02_L08
       mov       [rcx+rax],r8b
       mov       [rcx+rax+1],r8b
       mov       [rcx+rax+2],r8b
       mov       [rcx+rax+3],r8b
       add       rax,4
M02_L08:
       test      dl,2
       je        short M02_L09
       mov       [rcx+rax],r8b
       mov       [rcx+rax+1],r8b
       add       rax,2
M02_L09:
       test      dl,1
       je        short M02_L03
       mov       [rcx+rax],r8b
       jmp       near ptr M02_L03
; Total bytes of code 196
```
```assembly
; System.Text.Unicode.Utf16Utility.GetPointerToFirstInvalidChar(Char*, Int32, Int64 ByRef, Int32 ByRef)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       mov       rax,rcx
       mov       r10d,edx
       mov       r11,rax
       cmp       r10,20
       jae       near ptr M03_L09
       cmp       r10,10
       jae       near ptr M03_L07
M03_L00:
       cmp       r10,4
       jb        short M03_L02
M03_L01:
       mov       r11d,[rax]
       mov       ebx,[rax+4]
       mov       esi,r11d
       or        esi,ebx
       test      esi,0FF80FF80
       jne       near ptr M03_L12
       add       rax,8
       add       r10,0FFFFFFFFFFFFFFFC
       cmp       r10,4
       jae       short M03_L01
M03_L02:
       test      r10b,2
       je        short M03_L03
       mov       r11d,[rax]
       test      r11d,0FF80FF80
       jne       near ptr M03_L13
       add       rax,4
M03_L03:
       test      r10b,1
       je        short M03_L05
       cmp       word ptr [rax],7F
       ja        short M03_L05
M03_L04:
       add       rax,2
M03_L05:
       sub       rax,rcx
       shr       rax,1
       mov       r10d,eax
       lea       rcx,[rcx+r10*2]
       sub       edx,eax
       jne       near ptr M03_L15
       xor       edx,edx
       mov       [r8],rdx
       mov       [r9],edx
M03_L06:
       mov       rax,rcx
       vzeroupper
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M03_L07:
       vbroadcastss xmm0,dword ptr [7FFB5E9C8F40]
       vptest    xmm0,xmmword ptr [rax]
       jne       near ptr M03_L00
       lea       rbx,[r11+r10*2-10]
       add       r11,10
       mov       rax,r11
       and       rax,0FFFFFFFFFFFFFFF0
       vpand     xmm1,xmm0,[rax]
       vptest    xmm1,xmm1
       jne       short M03_L11
M03_L08:
       add       rax,10
       cmp       rax,rbx
       ja        short M03_L11
       vpand     xmm1,xmm0,[rax]
       vptest    xmm1,xmm1
       jne       short M03_L11
       jmp       short M03_L08
M03_L09:
       vbroadcastss ymm0,dword ptr [7FFB5E9C8F40]
       vptest    ymm0,ymmword ptr [rax]
       jne       near ptr M03_L00
       lea       rbx,[r11+r10*2-20]
       lea       rax,[r11+20]
       and       rax,0FFFFFFFFFFFFFFE0
       vpand     ymm1,ymm0,[rax]
       vptest    ymm1,ymm1
       jne       short M03_L11
M03_L10:
       add       rax,20
       cmp       rax,rbx
       ja        short M03_L11
       vpand     ymm1,ymm0,[rax]
       vptest    ymm1,ymm1
       je        short M03_L10
M03_L11:
       mov       r11,rax
       sub       r11,rcx
       shr       r11,1
       sub       r10,r11
       jmp       near ptr M03_L00
M03_L12:
       test      r11d,0FF80FF80
       je        short M03_L14
M03_L13:
       test      r11d,0FF80
       jne       near ptr M03_L05
       jmp       near ptr M03_L04
M03_L14:
       mov       r11d,ebx
       add       rax,4
       jmp       short M03_L13
M03_L15:
       xor       eax,eax
       xor       r10d,r10d
       mov       r11d,edx
       lea       r11,[rcx+r11*2]
       cmp       edx,8
       jl        near ptr M03_L20
       vbroadcastss xmm0,dword ptr [7FFB5E9C8F44]
       lea       rdx,[r11-10]
M03_L16:
       vmovups   xmm1,[rcx]
       add       rcx,10
       vpaddusw  xmm2,xmm1,xmm0
       vpminuw   xmm3,xmm1,[7FFB5E9C8F50]
       vpor      xmm2,xmm2,xmm3
       vpmovmskb ebx,xmm2
       popcnt    ebx,ebx
       vpaddw    xmm2,xmm1,[7FFB5E9C8F60]
       vpcmpgtw  xmm2,xmm0,xmm2
       vpmovmskb esi,xmm2
M03_L17:
       cmp       esi,0FFFF
       je        short M03_L19
       not       esi
       vpsrlw    xmm2,xmm1,3
       vpmovmskb edi,xmm2
       mov       ebp,edi
       and       ebp,esi
       xor       edi,5555
       and       esi,edi
       shl       esi,2
       movzx     edi,si
       cmp       edi,ebp
       jne       near ptr M03_L22
       cmp       esi,0FFFF
       jbe       short M03_L18
       movzx     esi,si
       add       rbx,0FFFFFFFFFFFFFFFE
       add       rcx,0FFFFFFFFFFFFFFFE
M03_L18:
       popcnt    esi,esi
       sub       r10d,esi
       sub       rax,rsi
       sub       rax,rsi
       mov       esi,0FFFF
       jmp       short M03_L17
M03_L19:
       add       rax,rbx
       cmp       rcx,rdx
       jbe       near ptr M03_L16
M03_L20:
       cmp       rcx,r11
       jae       short M03_L23
       movzx     edx,word ptr [rcx]
       cmp       edx,7F
       jbe       short M03_L21
       lea       ebx,[rdx+1F800]
       shr       ebx,10
       add       rax,rbx
       add       edx,0FFFF2800
       cmp       edx,7FF
       ja        short M03_L21
       add       rax,0FFFFFFFFFFFFFFFE
       mov       rdx,r11
       sub       rdx,rcx
       cmp       rdx,4
       jb        short M03_L23
       mov       edx,[rcx]
       add       edx,23FF2800
       test      edx,0FC00FC00
       jne       short M03_L23
       dec       r10d
       add       rax,2
       add       rcx,2
M03_L21:
       add       rcx,2
       jmp       short M03_L20
M03_L22:
       add       rcx,0FFFFFFFFFFFFFFF0
       jmp       short M03_L20
M03_L23:
       mov       [r8],rax
       mov       [r9],r10d
       jmp       near ptr M03_L06
; Total bytes of code 628
```
```assembly
; System.Text.UTF8Encoding.GetBytesCommon(Char*, Int32, Byte*, Int32, Boolean)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,58
       lea       rbp,[rsp+80]
       mov       r14,rcx
       mov       rbx,rdx
       mov       esi,r8d
       mov       rdi,r9
       cmp       [r14],r14b
       lea       rcx,[rbp-30]
       mov       [rsp+20],rcx
       lea       rcx,[rbp-38]
       mov       [rsp+28],rcx
       mov       rcx,rbx
       mov       edx,esi
       mov       r8,rdi
       mov       r9d,[rbp+30]
       call      qword ptr [7FFB5E1AFB28]; System.Text.Unicode.Utf8Utility.TranscodeToUtf8(Char*, Int32, Byte*, Int32, Char* ByRef, Byte* ByRef)
       mov       rcx,[rbp-30]
       sub       rcx,rbx
       mov       rdx,rcx
       shr       rdx,3F
       add       rcx,rdx
       sar       rcx,1
       mov       eax,[rbp-38]
       sub       eax,edi
       cmp       ecx,esi
       jne       short M04_L00
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M04_L00:
       mov       r15d,[rbp+30]
       mov       [rsp+20],r15d
       mov       [rsp+28],ecx
       mov       [rsp+30],eax
       movzx     ecx,byte ptr [rbp+38]
       mov       [rsp+38],ecx
       mov       rcx,r14
       mov       rdx,rbx
       mov       r8d,esi
       mov       r9,rdi
       call      qword ptr [7FFB5E91E778]
       nop
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 170
```
```assembly
; System.Span`1[[System.Byte, System.Private.CoreLib]]..ctor(Byte[], Int32, Int32)
       sub       rsp,28
       test      rdx,rdx
       je        short M05_L01
       mov       r8d,r8d
       mov       eax,r9d
       add       rax,r8
       mov       r10d,[rdx+8]
       cmp       rax,r10
       ja        short M05_L02
       add       rdx,10
       add       rdx,r8
       mov       [rcx],rdx
       mov       [rcx+8],r9d
M05_L00:
       add       rsp,28
       ret
M05_L01:
       or        r8d,r9d
       jne       short M05_L02
       xor       eax,eax
       mov       [rcx],rax
       mov       [rcx+8],rax
       jmp       short M05_L00
M05_L02:
       call      qword ptr [7FFB5E317198]
       int       3
; Total bytes of code 69
```
```assembly
; System.Span`1[[System.Byte, System.Private.CoreLib]].op_Implicit(System.Span`1<Byte>)
       mov       rax,[rdx]
       mov       edx,[rdx+8]
       mov       [rcx],rax
       mov       [rcx+8],edx
       mov       rax,rcx
       ret
; Total bytes of code 16
```
```assembly
; Org.BouncyCastle.Crypto.Digests.KeccakDigest.Absorb(System.ReadOnlySpan`1<Byte>)
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+20],rax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rsi,rdx
       mov       eax,[rbx+1C]
       test      al,7
       jne       short M07_L02
       cmp       byte ptr [rbx+24],0
       jne       near ptr M07_L03
       sar       eax,3
       mov       edi,[rbx+18]
       sar       edi,3
       mov       ebp,[rsi+8]
       mov       r14d,ebp
       mov       r15d,edi
       sub       r15d,eax
       cmp       r14d,r15d
       jge       near ptr M07_L05
       mov       r8,[rbx+10]
       test      r8,r8
       je        near ptr M07_L04
       mov       edi,[r8+8]
       cmp       edi,eax
       jb        near ptr M07_L10
       mov       ecx,eax
       lea       rcx,[r8+rcx+10]
       sub       edi,eax
M07_L00:
       cmp       ebp,edi
       jg        near ptr M07_L14
       mov       rdx,[rsi]
       mov       r8d,ebp
       call      qword ptr [7FFB5E1A5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       shl       r14d,3
       add       [rbx+1C],r14d
M07_L01:
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M07_L02:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,301BD
       mov       rdx,7FFB5E823520
       call      qword ptr [7FFB5E3C77B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB5E526088]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M07_L03:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,2F7BF
       mov       rdx,7FFB5E823520
       call      qword ptr [7FFB5E3C77B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB5E526088]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M07_L04:
       test      eax,eax
       jne       near ptr M07_L10
       xor       ecx,ecx
       xor       edi,edi
       jmp       near ptr M07_L00
M07_L05:
       xor       r13d,r13d
       test      eax,eax
       jle       near ptr M07_L09
       cmp       r15d,ebp
       ja        near ptr M07_L10
       mov       rdx,[rsi]
       mov       r8,[rbx+10]
       test      r8,r8
       je        near ptr M07_L10
       mov       ecx,[r8+8]
       cmp       ecx,eax
       jb        near ptr M07_L10
       mov       r10d,eax
       lea       r8,[r8+r10+10]
       sub       ecx,eax
       mov       rax,r8
       cmp       r15d,ecx
       ja        near ptr M07_L14
       mov       r8d,r15d
       mov       rcx,rax
       call      qword ptr [7FFB5E1A5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r13d,r15d
       mov       rdx,[rbx+10]
       test      rdx,rdx
       jne       short M07_L06
       xor       ecx,ecx
       xor       edx,edx
       jmp       short M07_L07
M07_L06:
       lea       rcx,[rdx+10]
       mov       edx,[rdx+8]
M07_L07:
       mov       [rsp+20],rcx
       mov       [rsp+28],edx
       lea       rdx,[rsp+20]
       mov       rcx,rbx
       call      qword ptr [7FFB5E7CDA70]
       jmp       short M07_L09
M07_L08:
       mov       edx,[rsi+8]
       sub       edx,r13d
       mov       ecx,r13d
       mov       eax,edx
       add       rcx,rax
       mov       eax,[rsi+8]
       cmp       rcx,rax
       ja        short M07_L10
       mov       ecx,r13d
       add       rcx,[rsi]
       mov       [rsp+20],rcx
       mov       [rsp+28],edx
       lea       rdx,[rsp+20]
       mov       rcx,rbx
       call      qword ptr [7FFB5E7CDA70]
       add       r13d,edi
M07_L09:
       mov       ebp,r14d
       sub       ebp,r13d
       cmp       ebp,edi
       jge       short M07_L08
       mov       r8d,[rsi+8]
       sub       r8d,r13d
       mov       ecx,r13d
       mov       edx,r8d
       add       rcx,rdx
       mov       edx,[rsi+8]
       cmp       rcx,rdx
       jbe       short M07_L11
M07_L10:
       call      qword ptr [7FFB5E317198]
       int       3
M07_L11:
       mov       edx,r13d
       add       rdx,[rsi]
       mov       rcx,[rbx+10]
       test      rcx,rcx
       jne       short M07_L12
       xor       eax,eax
       xor       ecx,ecx
       jmp       short M07_L13
M07_L12:
       lea       rax,[rcx+10]
       mov       ecx,[rcx+8]
M07_L13:
       cmp       r8d,ecx
       ja        short M07_L14
       mov       r8d,r8d
       mov       rcx,rax
       call      qword ptr [7FFB5E1A5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       shl       ebp,3
       mov       [rbx+1C],ebp
       jmp       near ptr M07_L01
M07_L14:
       call      qword ptr [7FFB5E5BD188]
       int       3
; Total bytes of code 583
```
```assembly
; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Rent(Int32)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       rsi,rcx
       mov       ebx,edx
       mov       rcx,20BC2800C90
       mov       rdi,[rcx]
       lea       ecx,[rbx-1]
       or        ecx,0F
       xor       ebp,ebp
       lzcnt     ebp,ecx
       xor       ebp,1F
       add       ebp,0FFFFFFFD
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],9
       jle       short M08_L02
       mov       rcx,[rcx+240]
       mov       rax,[rcx+48]
       test      rax,rax
       je        short M08_L02
M08_L00:
       mov       rcx,[rax+10]
       test      rcx,rcx
       je        short M08_L04
       mov       eax,[rcx+8]
       cmp       eax,ebp
       jbe       short M08_L04
       mov       eax,ebp
       shl       rax,4
       mov       r14,[rcx+rax+10]
       test      r14,r14
       je        short M08_L04
       xor       edx,edx
       mov       [rcx+rax+10],rdx
       cmp       byte ptr [rdi+9D],0
       jne       short M08_L03
M08_L01:
       mov       rax,r14
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
M08_L02:
       mov       ecx,9
       call      qword ptr [7FFB5E91D260]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       short M08_L00
M08_L03:
       mov       rcx,r14
       call      qword ptr [7FFB5E5BD830]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       ebx,eax
       mov       r15d,[r14+8]
       cmp       [rsi],sil
       mov       rcx,rsi
       call      qword ptr [7FFB5E5BD830]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       [rsp+20],ebp
       mov       edx,ebx
       mov       r8d,r15d
       mov       rcx,rdi
       call      qword ptr [7FFB5E91ED90]
       jmp       short M08_L01
M08_L04:
       mov       rcx,[rsi+10]
       cmp       [rcx+8],ebp
       jbe       near ptr M08_L16
       mov       eax,ebp
       mov       rcx,[rcx+rax*8+10]
       test      rcx,rcx
       je        near ptr M08_L15
       mov       r14,[rcx+8]
       mov       rcx,offset MT_System.Threading.ProcessorIdCache
       call      System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       cmp       byte ptr [7FFB5E0EB1D4],0
       je        short M08_L05
       call      qword ptr [7FFB5E91EDA8]
       mov       ebx,eax
       jmp       short M08_L07
M08_L05:
       mov       ecx,0A
       call      qword ptr [7FFB5E91EDC0]
       mov       ebx,[rax+10]
       mov       ecx,0A
       call      qword ptr [7FFB5E91EDC0]
       lea       ecx,[rbx-1]
       mov       [rax+10],ecx
       movzx     eax,bx
       test      eax,eax
       jne       short M08_L06
       call      qword ptr [7FFB5E91EDD8]
       mov       ebx,eax
       jmp       short M08_L07
M08_L06:
       sar       ebx,10
M08_L07:
       mov       rcx,offset MT_System.Buffers.SharedArrayPoolStatics
       call      System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       eax,ebx
       xor       edx,edx
       div       dword ptr [7FFB5E0EB1C8]
       mov       ebx,edx
       xor       r15d,r15d
       jmp       short M08_L11
M08_L08:
       cmp       ebx,[r14+8]
       jae       near ptr M08_L21
       mov       ecx,ebx
       mov       r13,[r14+rcx*8+10]
       cmp       [r13],r13b
       xor       r12d,r12d
       mov       rcx,r13
       call      qword ptr [7FFB5E6BE0D0]; System.Threading.Monitor.Enter(System.Object)
       mov       rcx,[r13+8]
       mov       eax,[r13+10]
       dec       eax
       cmp       [rcx+8],eax
       jbe       short M08_L09
       mov       edx,eax
       mov       r12,[rcx+rdx*8+10]
       mov       edx,eax
       xor       r8d,r8d
       mov       [rcx+rdx*8+10],r8
       mov       [r13+10],eax
M08_L09:
       mov       rcx,r13
       call      qword ptr [7FFB5E1A6820]; System.Threading.Monitor.Exit(System.Object)
       test      r12,r12
       jne       short M08_L12
       inc       ebx
       cmp       [r14+8],ebx
       jne       short M08_L10
       xor       ebx,ebx
M08_L10:
       inc       r15d
M08_L11:
       cmp       [r14+8],r15d
       jg        short M08_L08
       jmp       short M08_L13
M08_L12:
       mov       r14,r12
       jmp       short M08_L14
M08_L13:
       xor       r14d,r14d
M08_L14:
       test      r14,r14
       je        short M08_L15
       cmp       byte ptr [rdi+9D],0
       je        near ptr M08_L01
       mov       rcx,r14
       call      qword ptr [7FFB5E5BD830]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       ebx,eax
       mov       r15d,[r14+8]
       mov       rcx,rsi
       call      qword ptr [7FFB5E5BD830]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       [rsp+20],ebp
       mov       edx,ebx
       mov       r8d,r15d
       mov       rcx,rdi
       call      qword ptr [7FFB5E91ED90]
       jmp       near ptr M08_L01
M08_L15:
       mov       ecx,10
       shlx      ebx,ecx,ebp
       jmp       short M08_L18
M08_L16:
       test      ebx,ebx
       jne       short M08_L17
       mov       rax,24C577962A0
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
M08_L17:
       mov       ecx,ebx
       mov       rdx,24C57796F28
       call      qword ptr [7FFB5E3CD8C0]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
M08_L18:
       cmp       ebx,800
       jge       short M08_L19
       movsxd    rdx,ebx
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
       jmp       short M08_L20
M08_L19:
       mov       ecx,ebx
       xor       edx,edx
       call      qword ptr [7FFB5E91ED78]
       mov       r14,rax
M08_L20:
       cmp       byte ptr [rdi+9D],0
       je        near ptr M08_L01
       cmp       [r14],r14b
       mov       rcx,r14
       call      qword ptr [7FFB5E5BD830]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       ebx,eax
       mov       r15d,[r14+8]
       mov       rcx,rsi
       call      qword ptr [7FFB5E5BD830]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       edx,ebx
       mov       r8d,r15d
       mov       rcx,rdi
       call      qword ptr [7FFB5E91ED90]
       mov       r15d,[r14+8]
       mov       rcx,rsi
       call      qword ptr [7FFB5E5BD830]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       rcx,[rsi+10]
       mov       edx,1
       mov       r8d,2
       cmp       [rcx+8],ebp
       cmovg     edx,r8d
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       [rsp+28],edx
       mov       rcx,rdi
       mov       edx,ebx
       mov       r8d,r15d
       call      qword ptr [7FFB5E91EDF0]
       jmp       near ptr M08_L01
M08_L21:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 796
```
```assembly
; Org.BouncyCastle.Crypto.Digests.Sha3Digest.DoFinal(Byte[], Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       r9d,[rbx+1C]
       test      r9b,7
       jne       near ptr M09_L07
       cmp       byte ptr [rbx+24],0
       jne       near ptr M09_L08
       mov       rcx,[rbx+10]
       mov       eax,r9d
       sar       eax,3
       cmp       eax,[rcx+8]
       jae       near ptr M09_L23
       mov       byte ptr [rcx+rax+10],2
       add       r9d,2
       mov       [rbx+1C],r9d
       movsxd    r9,dword ptr [rbx+20]
       mov       rcx,rbx
       call      qword ptr [7FFB5E9162B0]; Org.BouncyCastle.Crypto.Digests.KeccakDigest.Squeeze(Byte[], Int32, Int64)
       mov       rcx,offset MT_Org.BouncyCastle.Crypto.Digests.Sha3Digest
       cmp       [rbx],rcx
       jne       near ptr M09_L22
       mov       rsi,rbx
       mov       edi,[rsi+20]
       cmp       edi,100
       jle       near ptr M09_L09
       cmp       edi,120
       je        short M09_L00
       cmp       edi,180
       je        short M09_L00
       cmp       edi,200
       jne       near ptr M09_L10
M09_L00:
       add       edi,edi
       neg       edi
       add       edi,640
       mov       ecx,edi
       sub       ecx,1
       cmp       ecx,63E
       ja        near ptr M09_L11
       test      dil,3F
       jne       near ptr M09_L11
       mov       [rsi+18],edi
       mov       rcx,[rsi+8]
       mov       rdx,rcx
       mov       ecx,[rcx+8]
       lea       rax,[rdx+10]
       xor       r8d,r8d
       mov       r10,[rdx]
       cmp       dword ptr [r10+4],18
       jne       near ptr M09_L12
M09_L01:
       mov       r9d,r8d
       neg       r9d
       test      r8d,r8d
       jg        near ptr M09_L13
       test      r9d,r9d
       jl        near ptr M09_L13
       lea       r8d,[r9+rcx]
       cmp       r8d,[rdx+8]
       ja        near ptr M09_L13
       movzx     edx,word ptr [r10]
       mov       r8d,r9d
       imul      r8,rdx
       add       r8,rax
       mov       ecx,ecx
       imul      rdx,rcx
       test      dword ptr [r10],1000000
       jne       near ptr M09_L14
       mov       rcx,r8
       call      qword ptr [7FFB5E1A57E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
M09_L02:
       mov       rax,[rsi+10]
       test      rax,rax
       je        near ptr M09_L15
       lea       rcx,[rax+10]
       mov       eax,[rax+8]
       mov       rdx,rcx
       cmp       rax,20
       jb        near ptr M09_L17
       mov       rdx,rax
       and       rdx,0FFFFFFFFFFFFFFC0
       xor       r8d,r8d
       cmp       rax,40
       jb        short M09_L04
M09_L03:
       vxorps    ymm0,ymm0,ymm0
       vmovups   [rcx+r8],ymm0
       vmovups   [rcx+r8+20],ymm0
       add       r8,40
       cmp       r8,rdx
       jb        short M09_L03
M09_L04:
       test      al,20
       jne       near ptr M09_L16
M09_L05:
       vxorps    ymm0,ymm0,ymm0
       vmovups   [rcx+rax-20],ymm0
M09_L06:
       xor       eax,eax
       mov       [rbx+1C],eax
       mov       byte ptr [rbx+24],0
       mov       eax,edi
       neg       eax
       add       eax,640
       sar       eax,1
       mov       [rbx+20],eax
       sar       eax,3
       vzeroupper
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M09_L07:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,301BD
       mov       rdx,7FFB5E823520
       call      qword ptr [7FFB5E3C77B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB5E526088]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M09_L08:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,2F7BF
       mov       rdx,7FFB5E823520
       call      qword ptr [7FFB5E3C77B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB5E526088]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M09_L09:
       cmp       edi,80
       je        near ptr M09_L00
       cmp       edi,0E0
       je        near ptr M09_L00
       cmp       edi,100
       je        near ptr M09_L00
M09_L10:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       ecx,30149
       mov       rdx,7FFB5E823520
       call      qword ptr [7FFB5E3C77B0]
       mov       rsi,rax
       mov       ecx,301A9
       mov       rdx,7FFB5E823520
       call      qword ptr [7FFB5E3C77B0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFB5E526130]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M09_L11:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,126E3
       mov       rdx,7FFB5E823520
       call      qword ptr [7FFB5E3C77B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB5E526088]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M09_L12:
       mov       r9d,[r10+4]
       add       r9d,0FFFFFFE8
       shr       r9d,3
       movsxd    r8,r9d
       mov       r8d,[rax+r8*4]
       shl       r9d,3
       movsxd    r9,r9d
       add       rax,r9
       jmp       near ptr M09_L01
M09_L13:
       call      qword ptr [7FFB5E91EC88]
       int       3
M09_L14:
       shr       rdx,3
       mov       rcx,r8
       call      qword ptr [7FFB5E91ECA0]
       jmp       near ptr M09_L02
M09_L15:
       mov       ecx,2
       call      qword ptr [7FFB5E3CC240]
       int       3
M09_L16:
       vxorps    ymm0,ymm0,ymm0
       vmovups   [rcx+r8],ymm0
       jmp       near ptr M09_L05
M09_L17:
       xor       ecx,ecx
       cmp       rax,8
       jb        short M09_L19
       mov       r8,rax
       and       r8,0FFFFFFFFFFFFFFF8
M09_L18:
       xor       r10d,r10d
       mov       [rdx+rcx],r10
       add       rcx,8
       cmp       rcx,r8
       jb        short M09_L18
M09_L19:
       test      al,4
       je        short M09_L20
       xor       r8d,r8d
       mov       [rdx+rcx],r8d
       add       rcx,4
M09_L20:
       test      al,2
       je        short M09_L21
       mov       word ptr [rdx+rcx],0
       add       rcx,2
M09_L21:
       test      al,1
       je        near ptr M09_L06
       mov       byte ptr [rdx+rcx],0
       jmp       near ptr M09_L06
M09_L22:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       vzeroupper
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax+28]
M09_L23:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 934
```
```assembly
; System.Convert.ToBase64String(Byte[], Int32, Int32, System.Base64FormattingOptions)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       mov       [rsp+40],rax
       mov       esi,edx
       mov       ebx,r8d
       mov       edi,r9d
       test      rcx,rcx
       je        near ptr M10_L20
       test      ebx,ebx
       jl        near ptr M10_L21
       test      esi,esi
       jl        near ptr M10_L22
       mov       ebp,[rcx+8]
       sub       ebp,ebx
       cmp       esi,ebp
       jl        short M10_L00
       cmp       esi,ebp
       jg        near ptr M10_L05
M10_L00:
       mov       eax,esi
       mov       edx,ebx
       add       rax,rdx
       mov       edx,[rcx+8]
       cmp       rax,rdx
       ja        near ptr M10_L23
       mov       eax,esi
       lea       rbp,[rcx+rax+10]
       cmp       edi,1
       ja        near ptr M10_L24
       test      ebx,ebx
       je        near ptr M10_L25
       cmp       edi,1
       sete      dil
       movzx     edi,dil
       lea       ecx,[rbx+2]
       mov       eax,0AAAAAAAB
       mov       edx,ecx
       imul      rax,rdx
       shr       rax,21
       shl       eax,2
       je        near ptr M10_L26
       test      edi,edi
       jne       near ptr M10_L27
M10_L01:
       test      eax,eax
       jl        near ptr M10_L28
M10_L02:
       movsxd    rdx,eax
       mov       rcx,offset MT_System.String
       call      00007FFBBDE29F20
       mov       rsi,rax
       test      edi,edi
       jne       near ptr M10_L31
       cmp       ebx,10
       jl        near ptr M10_L31
       lea       rcx,[rsi+0C]
       mov       edx,[rsi+8]
       imul      r9d,edx,2
       jo        near ptr M10_L34
       mov       [rsp+30],rbp
       mov       [rsp+28],rcx
       mov       r8,rcx
       cmp       ebx,5FFFFFFD
       jg        near ptr M10_L29
       lea       eax,[rbx+2]
       mov       r10d,0AAAAAAAB
       imul      rax,r10
       shr       rax,21
       shl       eax,2
       cmp       eax,r9d
       jg        near ptr M10_L29
       mov       eax,ebx
M10_L03:
       mov       r9,rbp
       mov       r10,r8
       mov       r11d,ebx
       add       r11,r9
       mov       edi,eax
       add       rdi,r9
       cmp       eax,10
       jl        near ptr M10_L09
       lea       rax,[rdi-20]
       cmp       rax,r9
       jb        near ptr M10_L07
       vmovups   ymm0,[7FFB5E9D2440]
       vpermd    ymm0,ymm0,[rbp]
       add       rbp,0FFFFFFFFFFFFFFFC
M10_L04:
       vpshufb   ymm0,ymm0,[7FFB5E9D2460]
       vpand     ymm1,ymm0,[7FFB5E9D2480]
       vpmulhuw  ymm1,ymm1,[7FFB5E9D24A0]
       vpand     ymm0,ymm0,[7FFB5E9D24C0]
       vpmullw   ymm0,ymm0,[7FFB5E9D24E0]
       vpor      ymm0,ymm0,ymm1
       vpsubusb  ymm1,ymm0,[7FFB5E9D2500]
       vpcmpgtb  ymm2,ymm0,[7FFB5E9D2520]
       vpsubb    ymm1,ymm1,ymm2
       vbroadcastf128 ymm2,xmmword ptr [7FFB5E9D2540]
       vpshufb   ymm1,ymm2,ymm1
       vpaddb    ymm0,ymm1,ymm0
       vmovups   [r8],ymm0
       add       rbp,18
       add       r8,20
       cmp       rbp,rax
       ja        short M10_L06
       vmovups   ymm0,[rbp]
       jmp       short M10_L04
M10_L05:
       mov       ecx,1149
       mov       rdx,7FFB5E0E4000
       call      qword ptr [7FFB5E3C77B0]
       mov       r8,rax
       mov       edx,ebp
       mov       ecx,esi
       call      qword ptr [7FFB5E91EE38]
       int       3
M10_L06:
       lea       r9,[rbp+4]
       mov       r10,r8
       cmp       r9,r11
       je        near ptr M10_L12
M10_L07:
       lea       rax,[rdi-10]
       cmp       rax,r9
       jb        short M10_L09
M10_L08:
       vmovups   xmm0,[r9]
       vpshufb   xmm0,xmm0,[7FFB5E9D2550]
       vpand     xmm1,xmm0,[7FFB5E9D2480]
       vpmulhuw  xmm1,xmm1,[7FFB5E9D24A0]
       vpand     xmm0,xmm0,[7FFB5E9D24C0]
       vpmullw   xmm0,xmm0,[7FFB5E9D24E0]
       vpor      xmm0,xmm0,xmm1
       vpsubusb  xmm1,xmm0,[7FFB5E9D2500]
       vpcmpgtb  xmm2,xmm0,[7FFB5E9D2520]
       vpsubb    xmm1,xmm1,xmm2
       vmovups   xmm2,[7FFB5E9D2540]
       vpshufb   xmm1,xmm2,xmm1
       vpaddb    xmm0,xmm1,xmm0
       vmovups   [r10],xmm0
       add       r9,0C
       add       r10,10
       cmp       r9,rax
       jbe       short M10_L08
       cmp       r9,r11
       je        near ptr M10_L12
M10_L09:
       mov       r8,7FFBBCF94BE0
       add       rdi,0FFFFFFFFFFFFFFFE
       cmp       r9,rdi
       jae       short M10_L11
M10_L10:
       movzx     eax,byte ptr [r9]
       shl       eax,10
       movzx     ebx,byte ptr [r9+1]
       shl       ebx,8
       or        eax,ebx
       movzx     ebx,byte ptr [r9+2]
       or        eax,ebx
       mov       ebx,eax
       shr       ebx,12
       movzx     ebx,byte ptr [r8+rbx]
       mov       ebp,eax
       shr       ebp,0C
       and       ebp,3F
       movzx     ebp,byte ptr [r8+rbp]
       shl       ebp,8
       or        ebx,ebp
       mov       ebp,eax
       shr       ebp,6
       and       ebp,3F
       movzx     ebp,byte ptr [r8+rbp]
       shl       ebp,10
       or        ebx,ebp
       and       eax,3F
       movzx     eax,byte ptr [r8+rax]
       shl       eax,18
       or        eax,ebx
       mov       [r10],eax
       add       r9,3
       add       r10,4
       cmp       r9,rdi
       jb        short M10_L10
M10_L11:
       lea       rax,[rdi+2]
       cmp       rax,r11
       jne       short M10_L12
       lea       rax,[r9+1]
       cmp       rax,r11
       jne       near ptr M10_L30
       movzx     r9d,byte ptr [r9]
       shl       r9d,8
       mov       r11d,r9d
       shr       r11d,0A
       mov       eax,r11d
       movzx     eax,byte ptr [r8+rax]
       shr       r9d,4
       and       r9d,3F
       movzx     r8d,byte ptr [r8+r9]
       shl       r8d,8
       or        r8d,eax
       or        r8d,3D3D0000
       mov       [r10],r8d
M10_L12:
       xor       r9d,r9d
       mov       [rsp+30],r9
       mov       [rsp+28],r9
       mov       r9d,edx
       lea       r9,[rcx+r9*2]
       mov       edx,edx
       add       rdx,rcx
       lea       r8,[rcx+1F]
       cmp       rdx,r8
       jbe       short M10_L14
M10_L13:
       add       rdx,0FFFFFFFFFFFFFFE0
       add       r9,0FFFFFFFFFFFFFFC0
       vmovups   ymm0,[rdx]
       vmovaps   ymm1,ymm0
       vpmovzxbw ymm1,xmm1
       vextracti128 xmm0,ymm0,1
       vpmovzxbw ymm0,xmm0
       vmovups   [r9],ymm1
       vmovups   [r9+20],ymm0
       cmp       rdx,r8
       ja        short M10_L13
M10_L14:
       lea       r8,[rcx+0F]
       cmp       rdx,r8
       jbe       short M10_L16
M10_L15:
       add       rdx,0FFFFFFFFFFFFFFF0
       add       r9,0FFFFFFFFFFFFFFE0
       vmovups   xmm0,[rdx]
       vpmovzxbw xmm1,xmm0
       vpsrldq   xmm0,xmm0,8
       vpmovzxbw xmm0,xmm0
       vmovups   [r9],xmm1
       vmovups   [r9+10],xmm0
       cmp       rdx,r8
       ja        short M10_L15
M10_L16:
       add       rcx,3
       cmp       rdx,rcx
       jbe       short M10_L18
M10_L17:
       add       r9,0FFFFFFFFFFFFFFF8
       add       rdx,0FFFFFFFFFFFFFFFC
       vmovd     xmm0,dword ptr [rdx]
       vpmovzxbw xmm0,xmm0
       vmovq     qword ptr [r9],xmm0
       cmp       rdx,rcx
       ja        short M10_L17
M10_L18:
       mov       rax,rsi
M10_L19:
       vzeroupper
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M10_L20:
       mov       ecx,1139
       mov       rdx,7FFB5E0E4000
       call      qword ptr [7FFB5E3C77B0]
       mov       rcx,rax
       call      qword ptr [7FFB5E91D050]
       int       3
M10_L21:
       mov       ecx,0B3
       mov       rdx,7FFB5E0E4000
       call      qword ptr [7FFB5E3C77B0]
       mov       rdx,rax
       mov       ecx,ebx
       call      qword ptr [7FFB5E91D020]
       int       3
M10_L22:
       mov       ecx,1149
       mov       rdx,7FFB5E0E4000
       call      qword ptr [7FFB5E3C77B0]
       mov       rdx,rax
       mov       ecx,esi
       call      qword ptr [7FFB5E91D020]
       int       3
M10_L23:
       call      qword ptr [7FFB5E317198]
       int       3
M10_L24:
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFB5E91E790]
       mov       rsi,rax
       mov       [rbx+8],edi
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB5E91D848]
       mov       rbx,rax
       mov       ecx,1157
       mov       rdx,7FFB5E0E4000
       call      qword ptr [7FFB5E3C77B0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FFB5E526130]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M10_L25:
       mov       rax,24C57790008
       jmp       near ptr M10_L19
M10_L26:
       xor       eax,eax
       jmp       near ptr M10_L02
M10_L27:
       mov       ecx,eax
       shr       ecx,2
       imul      rcx,1AF286BD
       shr       rcx,21
       imul      edx,ecx,4C
       mov       r8d,eax
       sub       r8d,edx
       mov       edx,ecx
       dec       ecx
       test      r8d,r8d
       cmove     edx,ecx
       lea       eax,[rax+rdx*2]
       jmp       near ptr M10_L01
M10_L28:
       mov       rcx,offset MT_System.OutOfMemoryException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       call      qword ptr [7FFB5E91E178]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M10_L29:
       sar       r9d,2
       lea       eax,[r9+r9*2]
       jmp       near ptr M10_L03
M10_L30:
       lea       rax,[r9+2]
       cmp       rax,r11
       jne       near ptr M10_L12
       movzx     eax,byte ptr [r9]
       shl       eax,10
       movzx     r9d,byte ptr [r9+1]
       shl       r9d,8
       or        r9d,eax
       mov       eax,r9d
       shr       eax,12
       movzx     eax,byte ptr [r8+rax]
       mov       r11d,r9d
       shr       r11d,0C
       and       r11d,3F
       movzx     r11d,byte ptr [r8+r11]
       shl       r11d,8
       or        eax,r11d
       shr       r9d,6
       and       r9d,3F
       movzx     r9d,byte ptr [r8+r9]
       shl       r9d,10
       or        r9d,eax
       or        r9d,3D000000
       mov       [r10],r9d
       jmp       near ptr M10_L12
M10_L31:
       mov       [rsp+40],rbp
       mov       rdx,rbp
       test      rsi,rsi
       jne       short M10_L32
       xor       ecx,ecx
       jmp       short M10_L33
M10_L32:
       lea       rcx,[rsi+0C]
       mov       [rsp+38],rcx
       mov       rcx,[rsp+38]
M10_L33:
       mov       [rsp+20],edi
       mov       r9d,ebx
       xor       r8d,r8d
       call      qword ptr [7FFB5E91E7A8]
       xor       eax,eax
       mov       [rsp+38],rax
       mov       [rsp+40],rax
       jmp       near ptr M10_L18
M10_L34:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 1502
```
```assembly
; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Return(Byte[], Boolean)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       mov       rdi,rcx
       mov       rbx,rdx
       mov       esi,r8d
       test      rbx,rbx
       je        near ptr M11_L07
       mov       ebp,[rbx+8]
       lea       ecx,[rbp-1]
       or        ecx,0F
       xor       r14d,r14d
       lzcnt     r14d,ecx
       xor       r14d,1F
       add       r14d,0FFFFFFFD
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],9
       jle       near ptr M11_L05
       mov       rcx,[rcx+240]
       mov       rax,[rcx+48]
       test      rax,rax
       je        near ptr M11_L05
M11_L00:
       mov       r15,[rax+10]
       test      r15,r15
       je        near ptr M11_L06
M11_L01:
       xor       r13d,r13d
       mov       r12d,1
       cmp       [r15+8],r14d
       jbe       short M11_L03
       mov       r13d,1
       test      sil,sil
       je        short M11_L02
       mov       rcx,[rbx]
       movzx     edx,word ptr [rcx]
       mov       eax,[rbx+8]
       imul      rdx,rax
       lea       rax,[rbx+10]
       test      dword ptr [rcx],1000000
       jne       near ptr M11_L08
       mov       rcx,rax
       call      qword ptr [7FFB5E1A57E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
M11_L02:
       mov       ecx,10
       shlx      ecx,ecx,r14d
       cmp       ebp,ecx
       jne       near ptr M11_L09
       mov       ecx,r14d
       shl       rcx,4
       lea       rsi,[r15+rcx+10]
       mov       r15,[rsi]
       mov       rcx,rsi
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+8],ecx
       test      r15,r15
       jne       near ptr M11_L10
M11_L03:
       mov       rcx,20BC2800C90
       mov       rsi,[rcx]
       cmp       byte ptr [rsi+9D],0
       jne       near ptr M11_L25
M11_L04:
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
M11_L05:
       mov       ecx,9
       call      qword ptr [7FFB5E91D260]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M11_L00
M11_L06:
       mov       rcx,rdi
       call      qword ptr [7FFB5E916460]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
       mov       r15,rax
       jmp       near ptr M11_L01
M11_L07:
       mov       ecx,2
       call      qword ptr [7FFB5E3CC240]
       int       3
M11_L08:
       shr       rdx,3
       mov       rcx,rax
       call      qword ptr [7FFB5E91ECA0]
       jmp       near ptr M11_L02
M11_L09:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       call      qword ptr [7FFB5E91EEE0]
       mov       rbx,rax
       mov       ecx,29B
       mov       rdx,7FFB5E0E4000
       call      qword ptr [7FFB5E3C77B0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rbp
       call      qword ptr [7FFB5E526130]
       mov       rcx,rbp
       call      CORINFO_HELP_THROW
       int       3
M11_L10:
       mov       rcx,[rdi+10]
       cmp       r14d,[rcx+8]
       jae       near ptr M11_L28
       mov       edx,r14d
       mov       rax,[rcx+rdx*8+10]
       test      rax,rax
       jne       short M11_L11
       mov       rcx,rdi
       mov       edx,r14d
       call      qword ptr [7FFB5E91EEF8]
M11_L11:
       mov       r12,[rax+8]
       mov       rcx,offset MT_System.Threading.ProcessorIdCache
       call      System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       cmp       byte ptr [7FFB5E0EB1D4],0
       je        short M11_L12
       call      qword ptr [7FFB5E91EDA8]
       mov       esi,eax
       jmp       short M11_L14
M11_L12:
       mov       ecx,0A
       call      qword ptr [7FFB5E91EDC0]
       mov       esi,[rax+10]
       mov       ecx,0A
       call      qword ptr [7FFB5E91EDC0]
       lea       ecx,[rsi-1]
       mov       [rax+10],ecx
       movzx     eax,si
       test      eax,eax
       jne       short M11_L13
       call      qword ptr [7FFB5E91EDD8]
       mov       esi,eax
       jmp       short M11_L14
M11_L13:
       sar       esi,10
M11_L14:
       mov       rcx,offset MT_System.Buffers.SharedArrayPoolStatics
       call      System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       eax,esi
       xor       edx,edx
       div       dword ptr [7FFB5E0EB1C8]
       mov       esi,edx
       xor       eax,eax
       jmp       near ptr M11_L21
M11_L15:
       cmp       esi,[r12+8]
       jae       near ptr M11_L28
       mov       ecx,esi
       mov       rdx,[r12+rcx*8+10]
       mov       [rsp+30],rdx
       cmp       [rdx],dl
       xor       r8d,r8d
       mov       [rsp+3C],r8d
       mov       rcx,rdx
       call      qword ptr [7FFB5E6BE0D0]; System.Threading.Monitor.Enter(System.Object)
       mov       rax,[rsp+30]
       mov       rcx,[rax+8]
       mov       r8d,[rax+10]
       mov       [rsp+38],r8d
       cmp       [rcx+8],r8d
       jbe       short M11_L17
       test      r8d,r8d
       jne       short M11_L18
       xor       edx,edx
       mov       [rax+14],edx
M11_L16:
       mov       edx,r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rsp+38]
       inc       ecx
       mov       rax,[rsp+30]
       mov       [rax+10],ecx
       mov       dword ptr [rsp+3C],1
M11_L17:
       mov       rcx,rax
       call      qword ptr [7FFB5E1A6820]; System.Threading.Monitor.Exit(System.Object)
       cmp       dword ptr [rsp+3C],0
       je        short M11_L19
       jmp       short M11_L22
M11_L18:
       jmp       short M11_L16
M11_L19:
       inc       esi
       cmp       [r12+8],esi
       jne       short M11_L20
       xor       esi,esi
M11_L20:
       mov       eax,[rsp+40]
       inc       eax
M11_L21:
       mov       [rsp+40],eax
       cmp       [r12+8],eax
       jg        near ptr M11_L15
       jmp       short M11_L23
M11_L22:
       mov       r12d,1
       jmp       short M11_L24
M11_L23:
       xor       r12d,r12d
M11_L24:
       jmp       near ptr M11_L03
M11_L25:
       test      ebp,ebp
       je        near ptr M11_L04
       mov       rcx,rbx
       call      qword ptr [7FFB5E5BD830]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r15d,eax
       mov       [rsp+44],ebp
       cmp       [rdi],dil
       mov       rcx,rdi
       call      qword ptr [7FFB5E5BD830]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,rsi
       mov       r8d,r15d
       mov       r9d,[rsp+44]
       mov       edx,3
       call      qword ptr [7FFB5E91E628]
       test      r12d,r13d
       jne       near ptr M11_L04
       mov       rcx,rbx
       call      qword ptr [7FFB5E5BD830]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       ebx,eax
       mov       rcx,rdi
       call      qword ptr [7FFB5E5BD830]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       test      r13d,r13d
       jne       short M11_L26
       mov       ecx,0FFFFFFFF
       mov       edx,1
       jmp       short M11_L27
M11_L26:
       mov       ecx,r14d
       xor       edx,edx
M11_L27:
       mov       [rsp+20],ecx
       mov       [rsp+28],edx
       mov       rcx,rsi
       mov       edx,ebx
       mov       r8d,ebp
       call      qword ptr [7FFB5E91EF10]
       jmp       near ptr M11_L04
M11_L28:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 913
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Security.PasswordHasherBenchmark.HashPasswordShake128()
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,60
       lea       rbp,[rsp+80]
       mov       rcx,offset MT_Org.BouncyCastle.Crypto.Digests.ShakeDigest
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,offset MT_System.UInt64[]
       mov       edx,19
       call      CORINFO_HELP_NEWARR_1_PTR
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Byte[]
       mov       edx,0C0
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rbx+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+18],540
       mov       rcx,[rbx+8]
       mov       rdx,rcx
       mov       ecx,[rcx+8]
       lea       rax,[rdx+10]
       xor       r8d,r8d
       mov       r10,[rdx]
       cmp       dword ptr [r10+4],18
       jne       near ptr M00_L07
M00_L00:
       mov       r9d,r8d
       neg       r9d
       test      r8d,r8d
       jg        near ptr M00_L08
       test      r9d,r9d
       jl        near ptr M00_L08
       lea       r8d,[r9+rcx]
       cmp       r8d,[rdx+8]
       ja        near ptr M00_L08
       movzx     edx,word ptr [r10]
       mov       r8d,r9d
       imul      r8,rdx
       add       r8,rax
       mov       ecx,ecx
       imul      rdx,rcx
       test      dword ptr [r10],1000000
       jne       near ptr M00_L09
       mov       rcx,r8
       call      qword ptr [7FFB5E1757E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
M00_L01:
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        near ptr M00_L10
       lea       rsi,[rcx+10]
       mov       ecx,[rcx+8]
       mov       rdi,rsi
       mov       r14d,ecx
       mov       ecx,1
       call      qword ptr [7FFB5E58C2A0]; System.Numerics.BitOperations.IsPow2(Int32)
       test      eax,eax
       je        near ptr M00_L12
       cmp       r14,20
       jb        near ptr M00_L12
       lea       rcx,[rbp-50]
       xor       edx,edx
       call      qword ptr [7FFB5E79D9C8]; System.Numerics.Vector`1[[System.Byte, System.Private.CoreLib]]..ctor(Byte)
       mov       rcx,r14
       and       rcx,0FFFFFFFFFFFFFFC0
       xor       edx,edx
       cmp       r14,40
       jb        short M00_L03
       nop       dword ptr [rax]
M00_L02:
       vmovups   ymm0,[rbp-50]
       vmovups   [rsi+rdx],ymm0
       vmovups   ymm0,[rbp-50]
       vmovups   [rsi+rdx+20],ymm0
       add       rdx,40
       cmp       rdx,rcx
       jb        short M00_L02
M00_L03:
       test      r14b,20
       jne       near ptr M00_L11
M00_L04:
       vmovups   ymm0,[rbp-50]
       vmovups   [rsi+r14-20],ymm0
M00_L05:
       xor       ecx,ecx
       mov       [rbx+1C],ecx
       mov       byte ptr [rbx+24],0
       mov       dword ptr [rbx+20],80
       mov       rcx,16B93400220
       mov       rcx,[rcx]
       mov       rdx,1AC283F06E0
       call      qword ptr [7FFB5E2CF960]; System.Text.UTF8Encoding+UTF8EncodingSealed.GetBytes(System.String)
       mov       r9d,[rax+8]
       mov       rcx,rbx
       mov       rdx,rax
       xor       r8d,r8d
       call      qword ptr [7FFB5E79DA10]; Org.BouncyCastle.Crypto.Digests.KeccakDigest.Absorb(Byte[], Int32, Int32)
       mov       esi,[rbx+20]
       sar       esi,2
       mov       rcx,16BA9400158
       mov       rdi,[rcx]
       mov       rcx,rdi
       mov       edx,esi
       call      qword ptr [7FFB5E7A1190]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Rent(Int32)
       mov       [rbp-58],rax
       mov       rcx,rbx
       mov       rdx,[rbp-58]
       xor       r8d,r8d
       call      qword ptr [7FFB5E7F43B8]; Org.BouncyCastle.Crypto.Digests.ShakeDigest.DoFinal(Byte[], Int32)
       mov       rcx,[rbp-58]
       mov       r8d,esi
       xor       edx,edx
       xor       r9d,r9d
       call      qword ptr [7FFB5E8E65F8]; System.Convert.ToBase64String(Byte[], Int32, Int32, System.Base64FormattingOptions)
       mov       rbx,rax
       jmp       short M00_L06
       int       3
M00_L06:
       mov       rcx,rdi
       mov       rdx,[rbp-58]
       mov       r8d,1
       call      qword ptr [7FFB5E7A1198]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Return(Byte[], Boolean)
       mov       rax,rbx
       vzeroupper
       add       rsp,60
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M00_L07:
       mov       r9d,[r10+4]
       add       r9d,0FFFFFFE8
       shr       r9d,3
       movsxd    r8,r9d
       mov       r8d,[rax+r8*4]
       shl       r9d,3
       movsxd    r9,r9d
       add       rax,r9
       jmp       near ptr M00_L00
M00_L08:
       call      qword ptr [7FFB5E8EF000]
       int       3
M00_L09:
       shr       rdx,3
       mov       rcx,r8
       call      qword ptr [7FFB5E8EF018]
       jmp       near ptr M00_L01
M00_L10:
       mov       ecx,2
       call      qword ptr [7FFB5E39C240]
       int       3
M00_L11:
       vmovups   ymm0,[rbp-50]
       vmovups   [rsi+rdx],ymm0
       jmp       near ptr M00_L04
M00_L12:
       xor       ecx,ecx
       cmp       r14,8
       jb        short M00_L14
       mov       rdx,r14
       and       rdx,0FFFFFFFFFFFFFFF8
M00_L13:
       xor       eax,eax
       mov       [rdi+rcx],rax
       add       rcx,8
       cmp       rcx,rdx
       jb        short M00_L13
M00_L14:
       test      r14b,4
       je        short M00_L15
       xor       edx,edx
       mov       [rdi+rcx],edx
       add       rcx,4
M00_L15:
       test      r14b,2
       je        short M00_L16
       mov       word ptr [rdi+rcx],0
       add       rcx,2
M00_L16:
       test      r14b,1
       je        near ptr M00_L05
       mov       byte ptr [rdi+rcx],0
       jmp       near ptr M00_L05
       sub       rsp,28
       mov       rcx,16BA9400158
       mov       rdi,[rcx]
       mov       rcx,rdi
       mov       rdx,[rbp-58]
       mov       r8d,1
       call      qword ptr [7FFB5E7A1198]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Return(Byte[], Boolean)
       nop
       vzeroupper
       add       rsp,28
       ret
; Total bytes of code 741
```
```assembly
; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
       push      rbx
       test      rdx,rdx
       je        short M01_L03
       lea       rbx,[rcx+rdx]
       cmp       rdx,10
       jbe       short M01_L05
       cmp       rdx,40
       jbe       short M01_L04
       cmp       rdx,400
       ja        near ptr M01_L09
       cmp       rdx,100
       jae       near ptr M01_L08
M01_L00:
       mov       rax,rdx
       shr       rax,6
M01_L01:
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       dec       rax
       jne       short M01_L01
       and       rdx,3F
       cmp       rdx,10
       ja        short M01_L04
M01_L02:
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rbx-10],xmm0
M01_L03:
       pop       rbx
       ret
M01_L04:
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rcx],xmm0
       cmp       rdx,20
       jbe       short M01_L02
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rcx+10],xmm0
       cmp       rdx,30
       jbe       short M01_L02
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rcx+20],xmm0
       jmp       short M01_L02
M01_L05:
       test      dl,18
       je        short M01_L06
       xor       eax,eax
       mov       [rcx],rax
       mov       [rbx-8],rax
       jmp       short M01_L03
M01_L06:
       test      dl,4
       je        short M01_L07
       xor       eax,eax
       mov       [rcx],eax
       mov       [rbx-4],eax
       jmp       short M01_L03
M01_L07:
       mov       byte ptr [rcx],0
       test      dl,2
       je        short M01_L03
       mov       word ptr [rbx-2],0
       jmp       short M01_L03
M01_L08:
       mov       rax,rcx
       and       rax,3F
       neg       rax
       add       rax,40
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,rax
       sub       rdx,rax
       jmp       near ptr M01_L00
M01_L09:
       cmp       [rcx],cl
       pop       rbx
       jmp       qword ptr [7FFB5E8EE448]
; Total bytes of code 231
```
```assembly
; System.Numerics.BitOperations.IsPow2(Int32)
       xor       eax,eax
       test      ecx,ecx
       setg      dl
       movzx     edx,dl
       blsr      ecx,ecx
       cmove     eax,edx
       ret
; Total bytes of code 19
```
```assembly
; System.Numerics.Vector`1[[System.Byte, System.Private.CoreLib]]..ctor(Byte)
       vmovd     xmm0,edx
       vpbroadcastb ymm0,xmm0
       vmovups   [rcx],ymm0
       vzeroupper
       ret
; Total bytes of code 17
```
```assembly
; System.Text.UTF8Encoding+UTF8EncodingSealed.GetBytes(System.String)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,80
       lea       rbp,[rsp+0B0]
       xor       eax,eax
       mov       [rbp-58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-50],ymm4
       mov       rsi,rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M04_L04
       mov       edi,[rbx+8]
       cmp       edi,20
       jle       near ptr M04_L03
       cmp       [rsi],sil
       lea       r8,[rbx+0C]
       mov       [rbp-38],r8
       mov       r14,[rbp-38]
       mov       r15d,edi
       lea       r8,[rbp-40]
       lea       r9,[rbp-48]
       mov       rcx,r14
       mov       edx,r15d
       call      qword ptr [7FFB5E17FAF8]; System.Text.Unicode.Utf16Utility.GetPointerToFirstInvalidChar(Char*, Int32, Int64 ByRef, Int32 ByRef)
       sub       rax,r14
       mov       r9,rax
       shr       r9,3F
       add       r9,rax
       sar       r9,1
       movsxd    r13,r9d
       add       r13,[rbp-40]
       cmp       r13,7FFFFFFF
       ja        near ptr M04_L06
       cmp       r9d,r15d
       jne       near ptr M04_L05
M04_L00:
       xor       edx,edx
       mov       [rbp-38],rdx
       movsxd    rdx,r13d
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
       mov       r15d,[r14+8]
       test      r15d,r15d
       jl        near ptr M04_L07
       add       rbx,0C
       mov       [rbp-50],rbx
       mov       rbx,[rbp-50]
       mov       [rbp-58],r14
       test      r15d,r15d
       je        near ptr M04_L08
       lea       r13,[r14+10]
M04_L01:
       lea       rcx,[rbp-60]
       mov       [rsp+20],rcx
       lea       rcx,[rbp-68]
       mov       [rsp+28],rcx
       mov       rcx,rbx
       mov       edx,edi
       mov       r8,r13
       mov       r9d,r15d
       call      qword ptr [7FFB5E17FB28]; System.Text.Unicode.Utf8Utility.TranscodeToUtf8(Char*, Int32, Byte*, Int32, Char* ByRef, Byte* ByRef)
       mov       rcx,[rbp-60]
       sub       rcx,rbx
       mov       rdx,rcx
       shr       rdx,3F
       add       rcx,rdx
       sar       rcx,1
       mov       edx,[rbp-68]
       sub       edx,r13d
       cmp       ecx,edi
       jne       near ptr M04_L09
M04_L02:
       xor       eax,eax
       mov       [rbp-50],rax
       mov       [rbp-58],rax
       mov       rax,r14
       add       rsp,80
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M04_L03:
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFB5E68F7B0]; System.Text.UTF8Encoding+UTF8EncodingSealed.GetBytesForSmallInput(System.String)
       nop
       add       rsp,80
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M04_L04:
       mov       ecx,0BC5
       mov       rdx,7FFB5E0B4000
       call      qword ptr [7FFB5E3977B0]
       mov       rcx,rax
       call      qword ptr [7FFB5E8ED2A8]
       int       3
M04_L05:
       mov       rcx,rsi
       mov       rdx,r14
       mov       r8d,r15d
       call      qword ptr [7FFB5E8EE9B8]
       add       r13d,eax
       jns       near ptr M04_L00
M04_L06:
       call      qword ptr [7FFB5E70E880]
       int       3
M04_L07:
       mov       ecx,0B
       xor       edx,edx
       call      qword ptr [7FFB5E7066B8]
       int       3
M04_L08:
       xor       r13d,r13d
       jmp       near ptr M04_L01
M04_L09:
       mov       [rsp+20],r15d
       mov       [rsp+28],ecx
       mov       [rsp+30],edx
       mov       dword ptr [rsp+38],1
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r8d,edi
       mov       r9,r13
       call      qword ptr [7FFB5E8EEAF0]
       jmp       near ptr M04_L02
; Total bytes of code 478
```
```assembly
; Org.BouncyCastle.Crypto.Digests.KeccakDigest.Absorb(Byte[], Int32, Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,40
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+20],ymm4
       mov       rbx,rcx
       test      rdx,rdx
       je        near ptr M05_L03
       mov       ecx,r8d
       mov       eax,r9d
       add       rcx,rax
       mov       eax,[rdx+8]
       cmp       rcx,rax
       ja        near ptr M05_L12
       mov       r8d,r8d
       lea       r8,[rdx+r8+10]
M05_L00:
       mov       [rsp+30],r8
       mov       [rsp+38],r9d
       mov       eax,[rbx+1C]
       test      al,7
       jne       near ptr M05_L04
       cmp       byte ptr [rbx+24],0
       jne       near ptr M05_L05
       sar       eax,3
       mov       esi,[rbx+18]
       sar       esi,3
       mov       edi,[rsp+38]
       mov       ebp,esi
       sub       ebp,eax
       cmp       edi,ebp
       jge       near ptr M05_L07
       mov       r8,[rbx+10]
       test      r8,r8
       je        near ptr M05_L06
       mov       esi,[r8+8]
       cmp       esi,eax
       jb        near ptr M05_L12
       mov       ecx,eax
       lea       rcx,[r8+rcx+10]
       sub       esi,eax
M05_L01:
       cmp       [rsp+38],esi
       jg        near ptr M05_L16
       mov       rdx,[rsp+30]
       mov       r8d,[rsp+38]
       call      qword ptr [7FFB5E175818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       shl       edi,3
       add       [rbx+1C],edi
M05_L02:
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M05_L03:
       or        r8d,r9d
       jne       near ptr M05_L12
       xor       r8d,r8d
       xor       r9d,r9d
       jmp       near ptr M05_L00
M05_L04:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,301BD
       mov       rdx,7FFB5E7F3520
       call      qword ptr [7FFB5E3977B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB5E4F6088]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M05_L05:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,2F7BF
       mov       rdx,7FFB5E7F3520
       call      qword ptr [7FFB5E3977B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB5E4F6088]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M05_L06:
       test      eax,eax
       jne       near ptr M05_L12
       xor       ecx,ecx
       xor       esi,esi
       jmp       near ptr M05_L01
M05_L07:
       xor       r14d,r14d
       test      eax,eax
       jle       near ptr M05_L11
       cmp       ebp,[rsp+38]
       ja        near ptr M05_L12
       mov       rdx,[rsp+30]
       mov       r8,[rbx+10]
       test      r8,r8
       je        near ptr M05_L12
       mov       ecx,[r8+8]
       cmp       ecx,eax
       jb        near ptr M05_L12
       mov       r10d,eax
       lea       r8,[r8+r10+10]
       sub       ecx,eax
       mov       rax,r8
       cmp       ebp,ecx
       ja        near ptr M05_L16
       mov       r8d,ebp
       mov       rcx,rax
       call      qword ptr [7FFB5E175818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r14d,ebp
       mov       rdx,[rbx+10]
       test      rdx,rdx
       jne       short M05_L08
       xor       ecx,ecx
       xor       edx,edx
       jmp       short M05_L09
M05_L08:
       lea       rcx,[rdx+10]
       mov       edx,[rdx+8]
M05_L09:
       mov       [rsp+20],rcx
       mov       [rsp+28],edx
       lea       rdx,[rsp+20]
       mov       rcx,rbx
       call      qword ptr [7FFB5E79DA70]
       jmp       short M05_L11
M05_L10:
       mov       edx,[rsp+38]
       sub       edx,r14d
       mov       ecx,r14d
       mov       eax,edx
       add       rcx,rax
       mov       eax,[rsp+38]
       cmp       rcx,rax
       ja        short M05_L12
       mov       ecx,r14d
       add       rcx,[rsp+30]
       mov       [rsp+20],rcx
       mov       [rsp+28],edx
       lea       rdx,[rsp+20]
       mov       rcx,rbx
       call      qword ptr [7FFB5E79DA70]
       add       r14d,esi
M05_L11:
       mov       ebp,edi
       sub       ebp,r14d
       cmp       ebp,esi
       jge       short M05_L10
       mov       r8d,[rsp+38]
       sub       r8d,r14d
       mov       ecx,r14d
       mov       edx,r8d
       add       rcx,rdx
       mov       edx,[rsp+38]
       cmp       rcx,rdx
       jbe       short M05_L13
M05_L12:
       call      qword ptr [7FFB5E2E7198]
       int       3
M05_L13:
       mov       edx,r14d
       add       rdx,[rsp+30]
       mov       rcx,[rbx+10]
       test      rcx,rcx
       jne       short M05_L14
       xor       eax,eax
       xor       ecx,ecx
       jmp       short M05_L15
M05_L14:
       lea       rax,[rcx+10]
       mov       ecx,[rcx+8]
M05_L15:
       cmp       r8d,ecx
       ja        short M05_L16
       mov       r8d,r8d
       mov       rcx,rax
       call      qword ptr [7FFB5E175818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       shl       ebp,3
       mov       [rbx+1C],ebp
       jmp       near ptr M05_L02
M05_L16:
       call      qword ptr [7FFB5E58D188]
       int       3
; Total bytes of code 650
```
```assembly
; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Rent(Int32)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       rsi,rcx
       mov       ebx,edx
       mov       rcx,16B93400C90
       mov       rdi,[rcx]
       lea       ecx,[rbx-1]
       or        ecx,0F
       xor       ebp,ebp
       lzcnt     ebp,ecx
       xor       ebp,1F
       add       ebp,0FFFFFFFD
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],9
       jle       short M06_L02
       mov       rcx,[rcx+240]
       mov       rax,[rcx+48]
       test      rax,rax
       je        short M06_L02
M06_L00:
       mov       rcx,[rax+10]
       test      rcx,rcx
       je        short M06_L04
       mov       eax,[rcx+8]
       cmp       eax,ebp
       jbe       short M06_L04
       mov       eax,ebp
       shl       rax,4
       mov       r14,[rcx+rax+10]
       test      r14,r14
       je        short M06_L04
       xor       edx,edx
       mov       [rcx+rax+10],rdx
       cmp       byte ptr [rdi+9D],0
       jne       short M06_L03
M06_L01:
       mov       rax,r14
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
M06_L02:
       mov       ecx,9
       call      qword ptr [7FFB5E8ED4B8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       short M06_L00
M06_L03:
       mov       rcx,r14
       call      qword ptr [7FFB5E58D830]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       ebx,eax
       mov       r15d,[r14+8]
       cmp       [rsi],sil
       mov       rcx,rsi
       call      qword ptr [7FFB5E58D830]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       [rsp+20],ebp
       mov       edx,ebx
       mov       r8d,r15d
       mov       rcx,rdi
       call      qword ptr [7FFB5E8EF108]
       jmp       short M06_L01
M06_L04:
       mov       rcx,[rsi+10]
       cmp       [rcx+8],ebp
       jbe       near ptr M06_L16
       mov       eax,ebp
       mov       rcx,[rcx+rax*8+10]
       test      rcx,rcx
       je        near ptr M06_L15
       mov       r14,[rcx+8]
       mov       rcx,offset MT_System.Threading.ProcessorIdCache
       call      System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       cmp       byte ptr [7FFB5E0BB1D4],0
       je        short M06_L05
       call      qword ptr [7FFB5E8EF120]
       mov       ebx,eax
       jmp       short M06_L07
M06_L05:
       mov       ecx,0A
       call      qword ptr [7FFB5E8EF138]
       mov       ebx,[rax+10]
       mov       ecx,0A
       call      qword ptr [7FFB5E8EF138]
       lea       ecx,[rbx-1]
       mov       [rax+10],ecx
       movzx     eax,bx
       test      eax,eax
       jne       short M06_L06
       call      qword ptr [7FFB5E8EF150]
       mov       ebx,eax
       jmp       short M06_L07
M06_L06:
       sar       ebx,10
M06_L07:
       mov       rcx,offset MT_System.Buffers.SharedArrayPoolStatics
       call      System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       eax,ebx
       xor       edx,edx
       div       dword ptr [7FFB5E0BB1C8]
       mov       ebx,edx
       xor       r15d,r15d
       jmp       short M06_L11
M06_L08:
       cmp       ebx,[r14+8]
       jae       near ptr M06_L21
       mov       ecx,ebx
       mov       r13,[r14+rcx*8+10]
       cmp       [r13],r13b
       xor       r12d,r12d
       mov       rcx,r13
       call      qword ptr [7FFB5E68E0D0]; System.Threading.Monitor.Enter(System.Object)
       mov       rcx,[r13+8]
       mov       eax,[r13+10]
       dec       eax
       cmp       [rcx+8],eax
       jbe       short M06_L09
       mov       edx,eax
       mov       r12,[rcx+rdx*8+10]
       mov       edx,eax
       xor       r8d,r8d
       mov       [rcx+rdx*8+10],r8
       mov       [r13+10],eax
M06_L09:
       mov       rcx,r13
       call      qword ptr [7FFB5E176820]; System.Threading.Monitor.Exit(System.Object)
       test      r12,r12
       jne       short M06_L12
       inc       ebx
       cmp       [r14+8],ebx
       jne       short M06_L10
       xor       ebx,ebx
M06_L10:
       inc       r15d
M06_L11:
       cmp       [r14+8],r15d
       jg        short M06_L08
       jmp       short M06_L13
M06_L12:
       mov       r14,r12
       jmp       short M06_L14
M06_L13:
       xor       r14d,r14d
M06_L14:
       test      r14,r14
       je        short M06_L15
       cmp       byte ptr [rdi+9D],0
       je        near ptr M06_L01
       mov       rcx,r14
       call      qword ptr [7FFB5E58D830]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       ebx,eax
       mov       r15d,[r14+8]
       mov       rcx,rsi
       call      qword ptr [7FFB5E58D830]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       [rsp+20],ebp
       mov       edx,ebx
       mov       r8d,r15d
       mov       rcx,rdi
       call      qword ptr [7FFB5E8EF108]
       jmp       near ptr M06_L01
M06_L15:
       mov       ecx,10
       shlx      ebx,ecx,ebp
       jmp       short M06_L18
M06_L16:
       test      ebx,ebx
       jne       short M06_L17
       mov       rax,1AC283E62A0
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
M06_L17:
       mov       ecx,ebx
       mov       rdx,1AC283E6F28
       call      qword ptr [7FFB5E39D8C0]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
M06_L18:
       cmp       ebx,800
       jge       short M06_L19
       movsxd    rdx,ebx
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
       jmp       short M06_L20
M06_L19:
       mov       ecx,ebx
       xor       edx,edx
       call      qword ptr [7FFB5E8EF0F0]
       mov       r14,rax
M06_L20:
       cmp       byte ptr [rdi+9D],0
       je        near ptr M06_L01
       cmp       [r14],r14b
       mov       rcx,r14
       call      qword ptr [7FFB5E58D830]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       ebx,eax
       mov       r15d,[r14+8]
       mov       rcx,rsi
       call      qword ptr [7FFB5E58D830]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       edx,ebx
       mov       r8d,r15d
       mov       rcx,rdi
       call      qword ptr [7FFB5E8EF108]
       mov       r15d,[r14+8]
       mov       rcx,rsi
       call      qword ptr [7FFB5E58D830]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       rcx,[rsi+10]
       mov       edx,1
       mov       r8d,2
       cmp       [rcx+8],ebp
       cmovg     edx,r8d
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       [rsp+28],edx
       mov       rcx,rdi
       mov       edx,ebx
       mov       r8d,r15d
       call      qword ptr [7FFB5E8EF168]
       jmp       near ptr M06_L01
M06_L21:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 796
```
```assembly
; Org.BouncyCastle.Crypto.Digests.ShakeDigest.DoFinal(Byte[], Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,r8d
       mov       rcx,offset MT_Org.BouncyCastle.Crypto.Digests.ShakeDigest
       cmp       [rbx],rcx
       jne       short M07_L00
       mov       r9d,[rbx+20]
       sar       r9d,2
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,edi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFB5E7F43F0]; Org.BouncyCastle.Crypto.Digests.ShakeDigest.OutputFinal(Byte[], Int32, Int32)
M07_L00:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       r9d,eax
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,edi
       mov       rax,[rbx]
       mov       rax,[rax+50]
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax]
; Total bytes of code 103
```
```assembly
; System.Convert.ToBase64String(Byte[], Int32, Int32, System.Base64FormattingOptions)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       mov       [rsp+40],rax
       mov       esi,edx
       mov       ebx,r8d
       mov       edi,r9d
       test      rcx,rcx
       je        near ptr M08_L18
       test      ebx,ebx
       jl        near ptr M08_L19
       test      esi,esi
       jl        near ptr M08_L20
       mov       ebp,[rcx+8]
       sub       ebp,ebx
       cmp       esi,ebp
       jl        short M08_L00
       cmp       esi,ebp
       jg        near ptr M08_L05
M08_L00:
       mov       eax,esi
       mov       edx,ebx
       add       rax,rdx
       mov       edx,[rcx+8]
       cmp       rax,rdx
       ja        near ptr M08_L21
       mov       eax,esi
       lea       rbp,[rcx+rax+10]
       cmp       edi,1
       ja        near ptr M08_L22
       test      ebx,ebx
       je        near ptr M08_L23
       cmp       edi,1
       sete      dil
       movzx     edi,dil
       lea       ecx,[rbx+2]
       mov       eax,0AAAAAAAB
       mov       edx,ecx
       imul      rax,rdx
       shr       rax,21
       shl       eax,2
       je        near ptr M08_L24
       test      edi,edi
       jne       near ptr M08_L25
M08_L01:
       test      eax,eax
       jl        near ptr M08_L26
M08_L02:
       movsxd    rdx,eax
       mov       rcx,offset MT_System.String
       call      00007FFBBDE29F20
       mov       rsi,rax
       test      edi,edi
       jne       near ptr M08_L31
       cmp       ebx,10
       jl        near ptr M08_L31
       lea       rcx,[rsi+0C]
       mov       edx,[rsi+8]
       imul      r9d,edx,2
       jo        near ptr M08_L34
       mov       [rsp+30],rbp
       mov       [rsp+28],rcx
       mov       r8,rcx
       cmp       ebx,5FFFFFFD
       jg        near ptr M08_L27
       lea       eax,[rbx+2]
       mov       r10d,0AAAAAAAB
       imul      rax,r10
       shr       rax,21
       shl       eax,2
       cmp       eax,r9d
       jg        near ptr M08_L27
       mov       eax,ebx
M08_L03:
       mov       r9,rbp
       mov       r10,r8
       mov       r11d,ebx
       add       r11,r9
       mov       edi,eax
       add       rdi,r9
       cmp       eax,10
       jl        near ptr M08_L08
       lea       rax,[rdi-20]
       cmp       rax,r9
       jb        near ptr M08_L07
       vmovups   ymm0,[7FFB5E9A24E0]
       vpermd    ymm0,ymm0,[rbp]
       add       rbp,0FFFFFFFFFFFFFFFC
M08_L04:
       vpshufb   ymm0,ymm0,[7FFB5E9A2500]
       vpand     ymm1,ymm0,[7FFB5E9A2520]
       vpmulhuw  ymm1,ymm1,[7FFB5E9A2540]
       vpand     ymm0,ymm0,[7FFB5E9A2560]
       vpmullw   ymm0,ymm0,[7FFB5E9A2580]
       vpor      ymm0,ymm0,ymm1
       vpsubusb  ymm1,ymm0,[7FFB5E9A25A0]
       vpcmpgtb  ymm2,ymm0,[7FFB5E9A25C0]
       vpsubb    ymm1,ymm1,ymm2
       vbroadcastf128 ymm2,xmmword ptr [7FFB5E9A25E0]
       vpshufb   ymm1,ymm2,ymm1
       vpaddb    ymm0,ymm1,ymm0
       vmovups   [r8],ymm0
       add       rbp,18
       add       r8,20
       cmp       rbp,rax
       ja        short M08_L06
       vmovups   ymm0,[rbp]
       jmp       short M08_L04
M08_L05:
       mov       ecx,1149
       mov       rdx,7FFB5E0B4000
       call      qword ptr [7FFB5E3977B0]
       mov       r8,rax
       mov       edx,ebp
       mov       ecx,esi
       call      qword ptr [7FFB5E8EF1B0]
       int       3
M08_L06:
       lea       r9,[rbp+4]
       mov       r10,r8
       cmp       r9,r11
       je        near ptr M08_L11
M08_L07:
       lea       rax,[rdi-10]
       cmp       rax,r9
       jae       near ptr M08_L28
M08_L08:
       mov       r8,7FFBBCF94BE0
       add       rdi,0FFFFFFFFFFFFFFFE
       cmp       r9,rdi
       jae       short M08_L10
M08_L09:
       movzx     eax,byte ptr [r9]
       shl       eax,10
       movzx     ebx,byte ptr [r9+1]
       shl       ebx,8
       or        eax,ebx
       movzx     ebx,byte ptr [r9+2]
       or        eax,ebx
       mov       ebx,eax
       shr       ebx,12
       movzx     ebx,byte ptr [r8+rbx]
       mov       ebp,eax
       shr       ebp,0C
       and       ebp,3F
       movzx     ebp,byte ptr [r8+rbp]
       shl       ebp,8
       or        ebx,ebp
       mov       ebp,eax
       shr       ebp,6
       and       ebp,3F
       movzx     ebp,byte ptr [r8+rbp]
       shl       ebp,10
       or        ebx,ebp
       and       eax,3F
       movzx     eax,byte ptr [r8+rax]
       shl       eax,18
       or        eax,ebx
       mov       [r10],eax
       add       r9,3
       add       r10,4
       cmp       r9,rdi
       jb        short M08_L09
M08_L10:
       lea       rax,[rdi+2]
       cmp       rax,r11
       jne       short M08_L11
       lea       rax,[r9+1]
       cmp       rax,r11
       je        near ptr M08_L29
       lea       rax,[r9+2]
       cmp       rax,r11
       jne       short M08_L11
       movzx     eax,byte ptr [r9]
       shl       eax,10
       movzx     r9d,byte ptr [r9+1]
       shl       r9d,8
       or        r9d,eax
       mov       eax,r9d
       shr       eax,12
       movzx     eax,byte ptr [r8+rax]
       mov       r11d,r9d
       shr       r11d,0C
       and       r11d,3F
       movzx     r11d,byte ptr [r8+r11]
       shl       r11d,8
       or        eax,r11d
       shr       r9d,6
       and       r9d,3F
       movzx     r8d,byte ptr [r8+r9]
       shl       r8d,10
       or        r8d,eax
       or        r8d,3D000000
       mov       [r10],r8d
M08_L11:
       xor       r9d,r9d
       mov       [rsp+30],r9
       mov       [rsp+28],r9
       mov       r9d,edx
       lea       r9,[rcx+r9*2]
       mov       edx,edx
       add       rdx,rcx
       lea       r8,[rcx+1F]
       cmp       rdx,r8
       jbe       short M08_L13
M08_L12:
       add       rdx,0FFFFFFFFFFFFFFE0
       add       r9,0FFFFFFFFFFFFFFC0
       vmovups   ymm0,[rdx]
       vmovaps   ymm1,ymm0
       vpmovzxbw ymm1,xmm1
       vextracti128 xmm0,ymm0,1
       vpmovzxbw ymm0,xmm0
       vmovups   [r9],ymm1
       vmovups   [r9+20],ymm0
       cmp       rdx,r8
       ja        short M08_L12
M08_L13:
       lea       r8,[rcx+0F]
       cmp       rdx,r8
       ja        near ptr M08_L30
M08_L14:
       add       rcx,3
       cmp       rdx,rcx
       jbe       short M08_L16
M08_L15:
       add       r9,0FFFFFFFFFFFFFFF8
       add       rdx,0FFFFFFFFFFFFFFFC
       vmovd     xmm0,dword ptr [rdx]
       vpmovzxbw xmm0,xmm0
       vmovq     qword ptr [r9],xmm0
       cmp       rdx,rcx
       ja        short M08_L15
M08_L16:
       mov       rax,rsi
M08_L17:
       vzeroupper
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M08_L18:
       mov       ecx,1139
       mov       rdx,7FFB5E0B4000
       call      qword ptr [7FFB5E3977B0]
       mov       rcx,rax
       call      qword ptr [7FFB5E8ED2A8]
       int       3
M08_L19:
       mov       ecx,0B3
       mov       rdx,7FFB5E0B4000
       call      qword ptr [7FFB5E3977B0]
       mov       rdx,rax
       mov       ecx,ebx
       call      qword ptr [7FFB5E8ED278]
       int       3
M08_L20:
       mov       ecx,1149
       mov       rdx,7FFB5E0B4000
       call      qword ptr [7FFB5E3977B0]
       mov       rdx,rax
       mov       ecx,esi
       call      qword ptr [7FFB5E8ED278]
       int       3
M08_L21:
       call      qword ptr [7FFB5E2E7198]
       int       3
M08_L22:
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFB5E8EEB20]
       mov       rsi,rax
       mov       [rbx+8],edi
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB5E8EDAA0]
       mov       rbx,rax
       mov       ecx,1157
       mov       rdx,7FFB5E0B4000
       call      qword ptr [7FFB5E3977B0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FFB5E4F6130]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M08_L23:
       mov       rax,1AC283E0008
       jmp       near ptr M08_L17
M08_L24:
       xor       eax,eax
       jmp       near ptr M08_L02
M08_L25:
       mov       ecx,eax
       shr       ecx,2
       imul      rcx,1AF286BD
       shr       rcx,21
       imul      edx,ecx,4C
       mov       r8d,eax
       sub       r8d,edx
       mov       edx,ecx
       dec       ecx
       test      r8d,r8d
       cmove     edx,ecx
       lea       eax,[rax+rdx*2]
       jmp       near ptr M08_L01
M08_L26:
       mov       rcx,offset MT_System.OutOfMemoryException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       call      qword ptr [7FFB5E8EE3D0]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M08_L27:
       sar       r9d,2
       lea       eax,[r9+r9*2]
       jmp       near ptr M08_L03
M08_L28:
       vmovups   xmm0,[r9]
       vpshufb   xmm0,xmm0,[7FFB5E9A25F0]
       vpand     xmm1,xmm0,[7FFB5E9A2520]
       vpmulhuw  xmm1,xmm1,[7FFB5E9A2540]
       vpand     xmm0,xmm0,[7FFB5E9A2560]
       vpmullw   xmm0,xmm0,[7FFB5E9A2580]
       vpor      xmm0,xmm0,xmm1
       vpsubusb  xmm1,xmm0,[7FFB5E9A25A0]
       vpcmpgtb  xmm2,xmm0,[7FFB5E9A25C0]
       vpsubb    xmm1,xmm1,xmm2
       vmovups   xmm2,[7FFB5E9A25E0]
       vpshufb   xmm1,xmm2,xmm1
       vpaddb    xmm0,xmm1,xmm0
       vmovups   [r10],xmm0
       add       r9,0C
       add       r10,10
       cmp       r9,rax
       jbe       short M08_L28
       cmp       r9,r11
       je        near ptr M08_L11
       jmp       near ptr M08_L08
M08_L29:
       movzx     r9d,byte ptr [r9]
       shl       r9d,8
       mov       eax,r9d
       shr       eax,0A
       movzx     eax,byte ptr [r8+rax]
       shr       r9d,4
       and       r9d,3F
       movzx     r9d,byte ptr [r8+r9]
       shl       r9d,8
       or        r9d,eax
       or        r9d,3D3D0000
       mov       [r10],r9d
       jmp       near ptr M08_L11
M08_L30:
       add       rdx,0FFFFFFFFFFFFFFF0
       add       r9,0FFFFFFFFFFFFFFE0
       vmovups   xmm0,[rdx]
       vpmovzxbw xmm1,xmm0
       vpsrldq   xmm0,xmm0,8
       vpmovzxbw xmm0,xmm0
       vmovups   [r9],xmm1
       vmovups   [r9+10],xmm0
       cmp       rdx,r8
       ja        short M08_L30
       jmp       near ptr M08_L14
M08_L31:
       mov       [rsp+40],rbp
       mov       rdx,rbp
       test      rsi,rsi
       jne       short M08_L32
       xor       ecx,ecx
       jmp       short M08_L33
M08_L32:
       lea       rcx,[rsi+0C]
       mov       [rsp+38],rcx
       mov       rcx,[rsp+38]
M08_L33:
       mov       [rsp+20],edi
       mov       r9d,ebx
       xor       r8d,r8d
       call      qword ptr [7FFB5E8EEB38]
       xor       eax,eax
       mov       [rsp+38],rax
       mov       [rsp+40],rax
       jmp       near ptr M08_L16
M08_L34:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 1512
```
```assembly
; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Return(Byte[], Boolean)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       mov       rdi,rcx
       mov       rbx,rdx
       mov       esi,r8d
       test      rbx,rbx
       je        near ptr M09_L07
       mov       ebp,[rbx+8]
       lea       ecx,[rbp-1]
       or        ecx,0F
       xor       r14d,r14d
       lzcnt     r14d,ecx
       xor       r14d,1F
       add       r14d,0FFFFFFFD
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],9
       jle       near ptr M09_L05
       mov       rcx,[rcx+240]
       mov       rax,[rcx+48]
       test      rax,rax
       je        near ptr M09_L05
M09_L00:
       mov       r15,[rax+10]
       test      r15,r15
       je        near ptr M09_L06
M09_L01:
       xor       r13d,r13d
       mov       r12d,1
       cmp       [r15+8],r14d
       jbe       short M09_L03
       mov       r13d,1
       test      sil,sil
       je        short M09_L02
       mov       rcx,[rbx]
       movzx     edx,word ptr [rcx]
       mov       eax,[rbx+8]
       imul      rdx,rax
       lea       rax,[rbx+10]
       test      dword ptr [rcx],1000000
       jne       near ptr M09_L08
       mov       rcx,rax
       call      qword ptr [7FFB5E1757E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
M09_L02:
       mov       ecx,10
       shlx      ecx,ecx,r14d
       cmp       ebp,ecx
       jne       near ptr M09_L09
       mov       ecx,r14d
       shl       rcx,4
       lea       rsi,[r15+rcx+10]
       mov       r15,[rsi]
       mov       rcx,rsi
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+8],ecx
       test      r15,r15
       jne       near ptr M09_L10
M09_L03:
       mov       rcx,16B93400C90
       mov       rsi,[rcx]
       cmp       byte ptr [rsi+9D],0
       jne       near ptr M09_L25
M09_L04:
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
M09_L05:
       mov       ecx,9
       call      qword ptr [7FFB5E8ED4B8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M09_L00
M09_L06:
       mov       rcx,rdi
       call      qword ptr [7FFB5E8E6610]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
       mov       r15,rax
       jmp       near ptr M09_L01
M09_L07:
       mov       ecx,2
       call      qword ptr [7FFB5E39C240]
       int       3
M09_L08:
       shr       rdx,3
       mov       rcx,rax
       call      qword ptr [7FFB5E8EF018]
       jmp       near ptr M09_L02
M09_L09:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       call      qword ptr [7FFB5E8EF258]
       mov       rbx,rax
       mov       ecx,29B
       mov       rdx,7FFB5E0B4000
       call      qword ptr [7FFB5E3977B0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rbp
       call      qword ptr [7FFB5E4F6130]
       mov       rcx,rbp
       call      CORINFO_HELP_THROW
       int       3
M09_L10:
       mov       rcx,[rdi+10]
       cmp       r14d,[rcx+8]
       jae       near ptr M09_L28
       mov       edx,r14d
       mov       rax,[rcx+rdx*8+10]
       test      rax,rax
       jne       short M09_L11
       mov       rcx,rdi
       mov       edx,r14d
       call      qword ptr [7FFB5E8EF270]
M09_L11:
       mov       r12,[rax+8]
       mov       rcx,offset MT_System.Threading.ProcessorIdCache
       call      System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       cmp       byte ptr [7FFB5E0BB1D4],0
       je        short M09_L12
       call      qword ptr [7FFB5E8EF120]
       mov       esi,eax
       jmp       short M09_L14
M09_L12:
       mov       ecx,0A
       call      qword ptr [7FFB5E8EF138]
       mov       esi,[rax+10]
       mov       ecx,0A
       call      qword ptr [7FFB5E8EF138]
       lea       ecx,[rsi-1]
       mov       [rax+10],ecx
       movzx     eax,si
       test      eax,eax
       jne       short M09_L13
       call      qword ptr [7FFB5E8EF150]
       mov       esi,eax
       jmp       short M09_L14
M09_L13:
       sar       esi,10
M09_L14:
       mov       rcx,offset MT_System.Buffers.SharedArrayPoolStatics
       call      System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       eax,esi
       xor       edx,edx
       div       dword ptr [7FFB5E0BB1C8]
       mov       esi,edx
       xor       eax,eax
       jmp       near ptr M09_L21
M09_L15:
       cmp       esi,[r12+8]
       jae       near ptr M09_L28
       mov       ecx,esi
       mov       rdx,[r12+rcx*8+10]
       mov       [rsp+30],rdx
       cmp       [rdx],dl
       xor       r8d,r8d
       mov       [rsp+3C],r8d
       mov       rcx,rdx
       call      qword ptr [7FFB5E68E0D0]; System.Threading.Monitor.Enter(System.Object)
       mov       rax,[rsp+30]
       mov       rcx,[rax+8]
       mov       r8d,[rax+10]
       mov       [rsp+38],r8d
       cmp       [rcx+8],r8d
       jbe       short M09_L17
       test      r8d,r8d
       jne       short M09_L18
       xor       edx,edx
       mov       [rax+14],edx
M09_L16:
       mov       edx,r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rsp+38]
       inc       ecx
       mov       rax,[rsp+30]
       mov       [rax+10],ecx
       mov       dword ptr [rsp+3C],1
M09_L17:
       mov       rcx,rax
       call      qword ptr [7FFB5E176820]; System.Threading.Monitor.Exit(System.Object)
       cmp       dword ptr [rsp+3C],0
       je        short M09_L19
       jmp       short M09_L22
M09_L18:
       jmp       short M09_L16
M09_L19:
       inc       esi
       cmp       [r12+8],esi
       jne       short M09_L20
       xor       esi,esi
M09_L20:
       mov       eax,[rsp+40]
       inc       eax
M09_L21:
       mov       [rsp+40],eax
       cmp       [r12+8],eax
       jg        near ptr M09_L15
       jmp       short M09_L23
M09_L22:
       mov       r12d,1
       jmp       short M09_L24
M09_L23:
       xor       r12d,r12d
M09_L24:
       jmp       near ptr M09_L03
M09_L25:
       test      ebp,ebp
       je        near ptr M09_L04
       mov       rcx,rbx
       call      qword ptr [7FFB5E58D830]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r15d,eax
       mov       [rsp+44],ebp
       cmp       [rdi],dil
       mov       rcx,rdi
       call      qword ptr [7FFB5E58D830]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,rsi
       mov       r8d,r15d
       mov       r9d,[rsp+44]
       mov       edx,3
       call      qword ptr [7FFB5E8EE9A0]
       test      r12d,r13d
       jne       near ptr M09_L04
       mov       rcx,rbx
       call      qword ptr [7FFB5E58D830]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       ebx,eax
       mov       rcx,rdi
       call      qword ptr [7FFB5E58D830]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       test      r13d,r13d
       jne       short M09_L26
       mov       ecx,0FFFFFFFF
       mov       edx,1
       jmp       short M09_L27
M09_L26:
       mov       ecx,r14d
       xor       edx,edx
M09_L27:
       mov       [rsp+20],ecx
       mov       [rsp+28],edx
       mov       rcx,rsi
       mov       edx,ebx
       mov       r8d,ebp
       call      qword ptr [7FFB5E8EF288]
       jmp       near ptr M09_L04
M09_L28:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 913
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Security.PasswordHasherBenchmark.HashPasswordShake256()
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,60
       lea       rbp,[rsp+80]
       mov       rcx,offset MT_Org.BouncyCastle.Crypto.Digests.ShakeDigest
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,offset MT_System.UInt64[]
       mov       edx,19
       call      CORINFO_HELP_NEWARR_1_PTR
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Byte[]
       mov       edx,0C0
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rbx+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+18],440
       mov       rcx,[rbx+8]
       mov       rdx,rcx
       mov       ecx,[rcx+8]
       lea       rax,[rdx+10]
       xor       r8d,r8d
       mov       r10,[rdx]
       cmp       dword ptr [r10+4],18
       jne       near ptr M00_L07
M00_L00:
       mov       r9d,r8d
       neg       r9d
       test      r8d,r8d
       jg        near ptr M00_L08
       test      r9d,r9d
       jl        near ptr M00_L08
       lea       r8d,[r9+rcx]
       cmp       r8d,[rdx+8]
       ja        near ptr M00_L08
       movzx     edx,word ptr [r10]
       mov       r8d,r9d
       imul      r8,rdx
       add       r8,rax
       mov       ecx,ecx
       imul      rdx,rcx
       test      dword ptr [r10],1000000
       jne       near ptr M00_L09
       mov       rcx,r8
       call      qword ptr [7FFB5E1A57E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
M00_L01:
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        near ptr M00_L10
       lea       rsi,[rcx+10]
       mov       ecx,[rcx+8]
       mov       rdi,rsi
       mov       r14d,ecx
       mov       ecx,1
       call      qword ptr [7FFB5E5BC2A0]; System.Numerics.BitOperations.IsPow2(Int32)
       test      eax,eax
       je        near ptr M00_L12
       cmp       r14,20
       jb        near ptr M00_L12
       lea       rcx,[rbp-50]
       xor       edx,edx
       call      qword ptr [7FFB5E7CDA10]; System.Numerics.Vector`1[[System.Byte, System.Private.CoreLib]]..ctor(Byte)
       mov       rcx,r14
       and       rcx,0FFFFFFFFFFFFFFC0
       xor       edx,edx
       cmp       r14,40
       jb        short M00_L03
M00_L02:
       vmovups   ymm0,[rbp-50]
       vmovups   [rsi+rdx],ymm0
       vmovups   ymm0,[rbp-50]
       vmovups   [rsi+rdx+20],ymm0
       add       rdx,40
       cmp       rdx,rcx
       jb        short M00_L02
M00_L03:
       test      r14b,20
       jne       near ptr M00_L11
M00_L04:
       vmovups   ymm0,[rbp-50]
       vmovups   [rsi+r14-20],ymm0
M00_L05:
       xor       ecx,ecx
       mov       [rbx+1C],ecx
       mov       byte ptr [rbx+24],0
       mov       dword ptr [rbx+20],100
       mov       rcx,27070000220
       mov       rcx,[rcx]
       mov       rdx,2B105140708
       call      qword ptr [7FFB5E2FF960]; System.Text.UTF8Encoding+UTF8EncodingSealed.GetBytes(System.String)
       mov       r9d,[rax+8]
       mov       rcx,rbx
       mov       rdx,rax
       xor       r8d,r8d
       call      qword ptr [7FFB5E7CDA58]; Org.BouncyCastle.Crypto.Digests.KeccakDigest.Absorb(Byte[], Int32, Int32)
       mov       esi,[rbx+20]
       sar       esi,2
       mov       rcx,27086000160
       mov       rdi,[rcx]
       mov       rcx,rdi
       mov       edx,esi
       call      qword ptr [7FFB5E7D1208]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Rent(Int32)
       mov       [rbp-58],rax
       mov       rcx,rbx
       mov       rdx,[rbp-58]
       xor       r8d,r8d
       call      qword ptr [7FFB5E824228]; Org.BouncyCastle.Crypto.Digests.ShakeDigest.DoFinal(Byte[], Int32)
       mov       rcx,[rbp-58]
       mov       r8d,esi
       xor       edx,edx
       xor       r9d,r9d
       call      qword ptr [7FFB5E916640]; System.Convert.ToBase64String(Byte[], Int32, Int32, System.Base64FormattingOptions)
       mov       rbx,rax
       jmp       short M00_L06
       int       3
M00_L06:
       mov       rcx,rdi
       mov       rdx,[rbp-58]
       mov       r8d,1
       call      qword ptr [7FFB5E7D1210]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Return(Byte[], Boolean)
       mov       rax,rbx
       vzeroupper
       add       rsp,60
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M00_L07:
       mov       r9d,[r10+4]
       add       r9d,0FFFFFFE8
       shr       r9d,3
       movsxd    r8,r9d
       mov       r8d,[rax+r8*4]
       shl       r9d,3
       movsxd    r9,r9d
       add       rax,r9
       jmp       near ptr M00_L00
M00_L08:
       call      qword ptr [7FFB5E91F018]
       int       3
M00_L09:
       shr       rdx,3
       mov       rcx,r8
       call      qword ptr [7FFB5E91F030]
       jmp       near ptr M00_L01
M00_L10:
       mov       ecx,2
       call      qword ptr [7FFB5E3CC240]
       int       3
M00_L11:
       vmovups   ymm0,[rbp-50]
       vmovups   [rsi+rdx],ymm0
       jmp       near ptr M00_L04
M00_L12:
       xor       ecx,ecx
       cmp       r14,8
       jb        short M00_L14
       mov       rdx,r14
       and       rdx,0FFFFFFFFFFFFFFF8
M00_L13:
       xor       eax,eax
       mov       [rdi+rcx],rax
       add       rcx,8
       cmp       rcx,rdx
       jb        short M00_L13
M00_L14:
       test      r14b,4
       je        short M00_L15
       xor       edx,edx
       mov       [rdi+rcx],edx
       add       rcx,4
M00_L15:
       test      r14b,2
       je        short M00_L16
       mov       word ptr [rdi+rcx],0
       add       rcx,2
M00_L16:
       test      r14b,1
       je        near ptr M00_L05
       mov       byte ptr [rdi+rcx],0
       jmp       near ptr M00_L05
       sub       rsp,28
       mov       rcx,27086000160
       mov       rdi,[rcx]
       mov       rcx,rdi
       mov       rdx,[rbp-58]
       mov       r8d,1
       call      qword ptr [7FFB5E7D1210]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Return(Byte[], Boolean)
       nop
       vzeroupper
       add       rsp,28
       ret
; Total bytes of code 737
```
```assembly
; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
       push      rbx
       test      rdx,rdx
       je        short M01_L03
       lea       rbx,[rcx+rdx]
       cmp       rdx,10
       jbe       short M01_L05
       cmp       rdx,40
       jbe       short M01_L04
       cmp       rdx,400
       ja        near ptr M01_L09
       cmp       rdx,100
       jae       near ptr M01_L08
M01_L00:
       mov       rax,rdx
       shr       rax,6
M01_L01:
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       dec       rax
       jne       short M01_L01
       and       rdx,3F
       cmp       rdx,10
       ja        short M01_L04
M01_L02:
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rbx-10],xmm0
M01_L03:
       pop       rbx
       ret
M01_L04:
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rcx],xmm0
       cmp       rdx,20
       jbe       short M01_L02
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rcx+10],xmm0
       cmp       rdx,30
       jbe       short M01_L02
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rcx+20],xmm0
       jmp       short M01_L02
M01_L05:
       test      dl,18
       je        short M01_L06
       xor       eax,eax
       mov       [rcx],rax
       mov       [rbx-8],rax
       jmp       short M01_L03
M01_L06:
       test      dl,4
       je        short M01_L07
       xor       eax,eax
       mov       [rcx],eax
       mov       [rbx-4],eax
       jmp       short M01_L03
M01_L07:
       mov       byte ptr [rcx],0
       test      dl,2
       je        short M01_L03
       mov       word ptr [rbx-2],0
       jmp       short M01_L03
M01_L08:
       mov       rax,rcx
       and       rax,3F
       neg       rax
       add       rax,40
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,rax
       sub       rdx,rax
       jmp       near ptr M01_L00
M01_L09:
       cmp       [rcx],cl
       pop       rbx
       jmp       qword ptr [7FFB5E91E4A8]
; Total bytes of code 231
```
```assembly
; System.Numerics.BitOperations.IsPow2(Int32)
       xor       eax,eax
       test      ecx,ecx
       setg      dl
       movzx     edx,dl
       blsr      ecx,ecx
       cmove     eax,edx
       ret
; Total bytes of code 19
```
```assembly
; System.Numerics.Vector`1[[System.Byte, System.Private.CoreLib]]..ctor(Byte)
       vmovd     xmm0,edx
       vpbroadcastb ymm0,xmm0
       vmovups   [rcx],ymm0
       vzeroupper
       ret
; Total bytes of code 17
```
```assembly
; System.Text.UTF8Encoding+UTF8EncodingSealed.GetBytes(System.String)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,80
       lea       rbp,[rsp+0B0]
       xor       eax,eax
       mov       [rbp-58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-50],ymm4
       mov       rsi,rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M04_L04
       mov       edi,[rbx+8]
       cmp       edi,20
       jle       near ptr M04_L03
       cmp       [rsi],sil
       lea       r8,[rbx+0C]
       mov       [rbp-38],r8
       mov       r14,[rbp-38]
       mov       r15d,edi
       lea       r8,[rbp-40]
       lea       r9,[rbp-48]
       mov       rcx,r14
       mov       edx,r15d
       call      qword ptr [7FFB5E1AFAF8]; System.Text.Unicode.Utf16Utility.GetPointerToFirstInvalidChar(Char*, Int32, Int64 ByRef, Int32 ByRef)
       sub       rax,r14
       mov       r9,rax
       shr       r9,3F
       add       r9,rax
       sar       r9,1
       movsxd    r13,r9d
       add       r13,[rbp-40]
       cmp       r13,7FFFFFFF
       ja        near ptr M04_L06
       cmp       r9d,r15d
       jne       near ptr M04_L05
M04_L00:
       xor       edx,edx
       mov       [rbp-38],rdx
       movsxd    rdx,r13d
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
       mov       r15d,[r14+8]
       test      r15d,r15d
       jl        near ptr M04_L07
       add       rbx,0C
       mov       [rbp-50],rbx
       mov       rbx,[rbp-50]
       mov       [rbp-58],r14
       test      r15d,r15d
       je        near ptr M04_L08
       lea       r13,[r14+10]
M04_L01:
       lea       rcx,[rbp-60]
       mov       [rsp+20],rcx
       lea       rcx,[rbp-68]
       mov       [rsp+28],rcx
       mov       rcx,rbx
       mov       edx,edi
       mov       r8,r13
       mov       r9d,r15d
       call      qword ptr [7FFB5E1AFB28]; System.Text.Unicode.Utf8Utility.TranscodeToUtf8(Char*, Int32, Byte*, Int32, Char* ByRef, Byte* ByRef)
       mov       rcx,[rbp-60]
       sub       rcx,rbx
       mov       rdx,rcx
       shr       rdx,3F
       add       rcx,rdx
       sar       rcx,1
       mov       edx,[rbp-68]
       sub       edx,r13d
       cmp       ecx,edi
       jne       near ptr M04_L09
M04_L02:
       xor       eax,eax
       mov       [rbp-50],rax
       mov       [rbp-58],rax
       mov       rax,r14
       add       rsp,80
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M04_L03:
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFB5E6BF7B0]; System.Text.UTF8Encoding+UTF8EncodingSealed.GetBytesForSmallInput(System.String)
       nop
       add       rsp,80
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M04_L04:
       mov       ecx,0BC5
       mov       rdx,7FFB5E0E4000
       call      qword ptr [7FFB5E3C77B0]
       mov       rcx,rax
       call      qword ptr [7FFB5E91D2C0]
       int       3
M04_L05:
       mov       rcx,rsi
       mov       rdx,r14
       mov       r8d,r15d
       call      qword ptr [7FFB5E91E8B0]
       add       r13d,eax
       jns       near ptr M04_L00
M04_L06:
       call      qword ptr [7FFB5E73E880]
       int       3
M04_L07:
       mov       ecx,0B
       xor       edx,edx
       call      qword ptr [7FFB5E7366B8]
       int       3
M04_L08:
       xor       r13d,r13d
       jmp       near ptr M04_L01
M04_L09:
       mov       [rsp+20],r15d
       mov       [rsp+28],ecx
       mov       [rsp+30],edx
       mov       dword ptr [rsp+38],1
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r8d,edi
       mov       r9,r13
       call      qword ptr [7FFB5E91E9E8]
       jmp       near ptr M04_L02
; Total bytes of code 478
```
```assembly
; Org.BouncyCastle.Crypto.Digests.KeccakDigest.Absorb(Byte[], Int32, Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,40
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+20],ymm4
       mov       rbx,rcx
       test      rdx,rdx
       je        near ptr M05_L03
       mov       ecx,r8d
       mov       eax,r9d
       add       rcx,rax
       mov       eax,[rdx+8]
       cmp       rcx,rax
       ja        near ptr M05_L12
       mov       r8d,r8d
       lea       r8,[rdx+r8+10]
M05_L00:
       mov       [rsp+30],r8
       mov       [rsp+38],r9d
       mov       eax,[rbx+1C]
       test      al,7
       jne       near ptr M05_L04
       cmp       byte ptr [rbx+24],0
       jne       near ptr M05_L05
       sar       eax,3
       mov       esi,[rbx+18]
       sar       esi,3
       mov       edi,[rsp+38]
       mov       ebp,esi
       sub       ebp,eax
       cmp       edi,ebp
       jge       near ptr M05_L07
       mov       r8,[rbx+10]
       test      r8,r8
       je        near ptr M05_L06
       mov       esi,[r8+8]
       cmp       esi,eax
       jb        near ptr M05_L12
       mov       ecx,eax
       lea       rcx,[r8+rcx+10]
       sub       esi,eax
M05_L01:
       cmp       [rsp+38],esi
       jg        near ptr M05_L16
       mov       rdx,[rsp+30]
       mov       r8d,[rsp+38]
       call      qword ptr [7FFB5E1A5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       shl       edi,3
       add       [rbx+1C],edi
M05_L02:
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M05_L03:
       or        r8d,r9d
       jne       near ptr M05_L12
       xor       r8d,r8d
       xor       r9d,r9d
       jmp       near ptr M05_L00
M05_L04:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,301BD
       mov       rdx,7FFB5E823390
       call      qword ptr [7FFB5E3C77B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB5E526088]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M05_L05:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,2F7BF
       mov       rdx,7FFB5E823390
       call      qword ptr [7FFB5E3C77B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB5E526088]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M05_L06:
       test      eax,eax
       jne       near ptr M05_L12
       xor       ecx,ecx
       xor       esi,esi
       jmp       near ptr M05_L01
M05_L07:
       xor       r14d,r14d
       test      eax,eax
       jle       near ptr M05_L11
       cmp       ebp,[rsp+38]
       ja        near ptr M05_L12
       mov       rdx,[rsp+30]
       mov       r8,[rbx+10]
       test      r8,r8
       je        near ptr M05_L12
       mov       ecx,[r8+8]
       cmp       ecx,eax
       jb        near ptr M05_L12
       mov       r10d,eax
       lea       r8,[r8+r10+10]
       sub       ecx,eax
       mov       rax,r8
       cmp       ebp,ecx
       ja        near ptr M05_L16
       mov       r8d,ebp
       mov       rcx,rax
       call      qword ptr [7FFB5E1A5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r14d,ebp
       mov       rdx,[rbx+10]
       test      rdx,rdx
       jne       short M05_L08
       xor       ecx,ecx
       xor       edx,edx
       jmp       short M05_L09
M05_L08:
       lea       rcx,[rdx+10]
       mov       edx,[rdx+8]
M05_L09:
       mov       [rsp+20],rcx
       mov       [rsp+28],edx
       lea       rdx,[rsp+20]
       mov       rcx,rbx
       call      qword ptr [7FFB5E7CDAB8]
       jmp       short M05_L11
M05_L10:
       mov       edx,[rsp+38]
       sub       edx,r14d
       mov       ecx,r14d
       mov       eax,edx
       add       rcx,rax
       mov       eax,[rsp+38]
       cmp       rcx,rax
       ja        short M05_L12
       mov       ecx,r14d
       add       rcx,[rsp+30]
       mov       [rsp+20],rcx
       mov       [rsp+28],edx
       lea       rdx,[rsp+20]
       mov       rcx,rbx
       call      qword ptr [7FFB5E7CDAB8]
       add       r14d,esi
M05_L11:
       mov       ebp,edi
       sub       ebp,r14d
       cmp       ebp,esi
       jge       short M05_L10
       mov       r8d,[rsp+38]
       sub       r8d,r14d
       mov       ecx,r14d
       mov       edx,r8d
       add       rcx,rdx
       mov       edx,[rsp+38]
       cmp       rcx,rdx
       jbe       short M05_L13
M05_L12:
       call      qword ptr [7FFB5E317198]
       int       3
M05_L13:
       mov       edx,r14d
       add       rdx,[rsp+30]
       mov       rcx,[rbx+10]
       test      rcx,rcx
       jne       short M05_L14
       xor       eax,eax
       xor       ecx,ecx
       jmp       short M05_L15
M05_L14:
       lea       rax,[rcx+10]
       mov       ecx,[rcx+8]
M05_L15:
       cmp       r8d,ecx
       ja        short M05_L16
       mov       r8d,r8d
       mov       rcx,rax
       call      qword ptr [7FFB5E1A5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       shl       ebp,3
       mov       [rbx+1C],ebp
       jmp       near ptr M05_L02
M05_L16:
       call      qword ptr [7FFB5E5BD188]
       int       3
; Total bytes of code 650
```
```assembly
; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Rent(Int32)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       rsi,rcx
       mov       ebx,edx
       mov       rcx,27070000C90
       mov       rdi,[rcx]
       lea       ecx,[rbx-1]
       or        ecx,0F
       xor       ebp,ebp
       lzcnt     ebp,ecx
       xor       ebp,1F
       add       ebp,0FFFFFFFD
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],9
       jle       short M06_L02
       mov       rcx,[rcx+240]
       mov       rax,[rcx+48]
       test      rax,rax
       je        short M06_L02
M06_L00:
       mov       rcx,[rax+10]
       test      rcx,rcx
       je        short M06_L04
       mov       eax,[rcx+8]
       cmp       eax,ebp
       jbe       short M06_L04
       mov       eax,ebp
       shl       rax,4
       mov       r14,[rcx+rax+10]
       test      r14,r14
       je        short M06_L04
       xor       edx,edx
       mov       [rcx+rax+10],rdx
       cmp       byte ptr [rdi+9D],0
       jne       short M06_L03
M06_L01:
       mov       rax,r14
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
M06_L02:
       mov       ecx,9
       call      qword ptr [7FFB5E91D4D0]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       short M06_L00
M06_L03:
       mov       rcx,r14
       call      qword ptr [7FFB5E5BD830]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       ebx,eax
       mov       r15d,[r14+8]
       cmp       [rsi],sil
       mov       rcx,rsi
       call      qword ptr [7FFB5E5BD830]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       [rsp+20],ebp
       mov       edx,ebx
       mov       r8d,r15d
       mov       rcx,rdi
       call      qword ptr [7FFB5E91F120]
       jmp       short M06_L01
M06_L04:
       mov       rcx,[rsi+10]
       cmp       [rcx+8],ebp
       jbe       near ptr M06_L16
       mov       eax,ebp
       mov       rcx,[rcx+rax*8+10]
       test      rcx,rcx
       je        near ptr M06_L15
       mov       r14,[rcx+8]
       mov       rcx,offset MT_System.Threading.ProcessorIdCache
       call      System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       cmp       byte ptr [7FFB5E0EB1D4],0
       je        short M06_L05
       call      qword ptr [7FFB5E91F138]
       mov       ebx,eax
       jmp       short M06_L07
M06_L05:
       mov       ecx,0A
       call      qword ptr [7FFB5E91F150]
       mov       ebx,[rax+10]
       mov       ecx,0A
       call      qword ptr [7FFB5E91F150]
       lea       ecx,[rbx-1]
       mov       [rax+10],ecx
       movzx     eax,bx
       test      eax,eax
       jne       short M06_L06
       call      qword ptr [7FFB5E91F168]
       mov       ebx,eax
       jmp       short M06_L07
M06_L06:
       sar       ebx,10
M06_L07:
       mov       rcx,offset MT_System.Buffers.SharedArrayPoolStatics
       call      System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       eax,ebx
       xor       edx,edx
       div       dword ptr [7FFB5E0EB1C8]
       mov       ebx,edx
       xor       r15d,r15d
       jmp       short M06_L11
M06_L08:
       cmp       ebx,[r14+8]
       jae       near ptr M06_L21
       mov       ecx,ebx
       mov       r13,[r14+rcx*8+10]
       cmp       [r13],r13b
       xor       r12d,r12d
       mov       rcx,r13
       call      qword ptr [7FFB5E6BE3B8]; System.Threading.Monitor.Enter(System.Object)
       mov       rcx,[r13+8]
       mov       eax,[r13+10]
       dec       eax
       cmp       [rcx+8],eax
       jbe       short M06_L09
       mov       edx,eax
       mov       r12,[rcx+rdx*8+10]
       mov       edx,eax
       xor       r8d,r8d
       mov       [rcx+rdx*8+10],r8
       mov       [r13+10],eax
M06_L09:
       mov       rcx,r13
       call      qword ptr [7FFB5E1A6820]; System.Threading.Monitor.Exit(System.Object)
       test      r12,r12
       jne       short M06_L12
       inc       ebx
       cmp       [r14+8],ebx
       jne       short M06_L10
       xor       ebx,ebx
M06_L10:
       inc       r15d
M06_L11:
       cmp       [r14+8],r15d
       jg        short M06_L08
       jmp       short M06_L13
M06_L12:
       mov       r14,r12
       jmp       short M06_L14
M06_L13:
       xor       r14d,r14d
M06_L14:
       test      r14,r14
       je        short M06_L15
       cmp       byte ptr [rdi+9D],0
       je        near ptr M06_L01
       mov       rcx,r14
       call      qword ptr [7FFB5E5BD830]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       ebx,eax
       mov       r15d,[r14+8]
       mov       rcx,rsi
       call      qword ptr [7FFB5E5BD830]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       [rsp+20],ebp
       mov       edx,ebx
       mov       r8d,r15d
       mov       rcx,rdi
       call      qword ptr [7FFB5E91F120]
       jmp       near ptr M06_L01
M06_L15:
       mov       ecx,10
       shlx      ebx,ecx,ebp
       jmp       short M06_L18
M06_L16:
       test      ebx,ebx
       jne       short M06_L17
       mov       rax,2B1051362A0
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
M06_L17:
       mov       ecx,ebx
       mov       rdx,2B105136F28
       call      qword ptr [7FFB5E3CD8C0]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
M06_L18:
       cmp       ebx,800
       jge       short M06_L19
       movsxd    rdx,ebx
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
       jmp       short M06_L20
M06_L19:
       mov       ecx,ebx
       xor       edx,edx
       call      qword ptr [7FFB5E91F108]
       mov       r14,rax
M06_L20:
       cmp       byte ptr [rdi+9D],0
       je        near ptr M06_L01
       cmp       [r14],r14b
       mov       rcx,r14
       call      qword ptr [7FFB5E5BD830]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       ebx,eax
       mov       r15d,[r14+8]
       mov       rcx,rsi
       call      qword ptr [7FFB5E5BD830]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       edx,ebx
       mov       r8d,r15d
       mov       rcx,rdi
       call      qword ptr [7FFB5E91F120]
       mov       r15d,[r14+8]
       mov       rcx,rsi
       call      qword ptr [7FFB5E5BD830]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       rcx,[rsi+10]
       mov       edx,1
       mov       r8d,2
       cmp       [rcx+8],ebp
       cmovg     edx,r8d
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       [rsp+28],edx
       mov       rcx,rdi
       mov       edx,ebx
       mov       r8d,r15d
       call      qword ptr [7FFB5E91F180]
       jmp       near ptr M06_L01
M06_L21:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 796
```
```assembly
; Org.BouncyCastle.Crypto.Digests.ShakeDigest.DoFinal(Byte[], Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,r8d
       mov       rcx,offset MT_Org.BouncyCastle.Crypto.Digests.ShakeDigest
       cmp       [rbx],rcx
       jne       short M07_L00
       mov       r9d,[rbx+20]
       sar       r9d,2
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,edi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFB5E824260]; Org.BouncyCastle.Crypto.Digests.ShakeDigest.OutputFinal(Byte[], Int32, Int32)
M07_L00:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       r9d,eax
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,edi
       mov       rax,[rbx]
       mov       rax,[rax+50]
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax]
; Total bytes of code 103
```
```assembly
; System.Convert.ToBase64String(Byte[], Int32, Int32, System.Base64FormattingOptions)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       mov       [rsp+40],rax
       mov       esi,edx
       mov       ebx,r8d
       mov       edi,r9d
       test      rcx,rcx
       je        near ptr M08_L20
       test      ebx,ebx
       jl        near ptr M08_L21
       test      esi,esi
       jl        near ptr M08_L22
       mov       ebp,[rcx+8]
       sub       ebp,ebx
       cmp       esi,ebp
       jl        short M08_L00
       cmp       esi,ebp
       jg        near ptr M08_L05
M08_L00:
       mov       eax,esi
       mov       edx,ebx
       add       rax,rdx
       mov       edx,[rcx+8]
       cmp       rax,rdx
       ja        near ptr M08_L23
       mov       eax,esi
       lea       rbp,[rcx+rax+10]
       cmp       edi,1
       ja        near ptr M08_L24
       test      ebx,ebx
       je        near ptr M08_L25
       cmp       edi,1
       sete      dil
       movzx     edi,dil
       lea       ecx,[rbx+2]
       mov       eax,0AAAAAAAB
       mov       edx,ecx
       imul      rax,rdx
       shr       rax,21
       shl       eax,2
       je        near ptr M08_L26
       test      edi,edi
       jne       near ptr M08_L27
M08_L01:
       test      eax,eax
       jl        near ptr M08_L28
M08_L02:
       movsxd    rdx,eax
       mov       rcx,offset MT_System.String
       call      00007FFBBDE29F20
       mov       rsi,rax
       test      edi,edi
       jne       near ptr M08_L31
       cmp       ebx,10
       jl        near ptr M08_L31
       lea       rcx,[rsi+0C]
       mov       edx,[rsi+8]
       imul      r9d,edx,2
       jo        near ptr M08_L34
       mov       [rsp+30],rbp
       mov       [rsp+28],rcx
       mov       r8,rcx
       cmp       ebx,5FFFFFFD
       jg        near ptr M08_L29
       lea       eax,[rbx+2]
       mov       r10d,0AAAAAAAB
       imul      rax,r10
       shr       rax,21
       shl       eax,2
       cmp       eax,r9d
       jg        near ptr M08_L29
       mov       eax,ebx
M08_L03:
       mov       r9,rbp
       mov       r10,r8
       mov       r11d,ebx
       add       r11,r9
       mov       edi,eax
       add       rdi,r9
       cmp       eax,10
       jl        near ptr M08_L09
       lea       rax,[rdi-20]
       cmp       rax,r9
       jb        near ptr M08_L07
       vmovups   ymm0,[7FFB5E9D21C0]
       vpermd    ymm0,ymm0,[rbp]
       add       rbp,0FFFFFFFFFFFFFFFC
M08_L04:
       vpshufb   ymm0,ymm0,[7FFB5E9D21E0]
       vpand     ymm1,ymm0,[7FFB5E9D2200]
       vpmulhuw  ymm1,ymm1,[7FFB5E9D2220]
       vpand     ymm0,ymm0,[7FFB5E9D2240]
       vpmullw   ymm0,ymm0,[7FFB5E9D2260]
       vpor      ymm0,ymm0,ymm1
       vpsubusb  ymm1,ymm0,[7FFB5E9D2280]
       vpcmpgtb  ymm2,ymm0,[7FFB5E9D22A0]
       vpsubb    ymm1,ymm1,ymm2
       vbroadcastf128 ymm2,xmmword ptr [7FFB5E9D22C0]
       vpshufb   ymm1,ymm2,ymm1
       vpaddb    ymm0,ymm1,ymm0
       vmovups   [r8],ymm0
       add       rbp,18
       add       r8,20
       cmp       rbp,rax
       ja        short M08_L06
       vmovups   ymm0,[rbp]
       jmp       short M08_L04
M08_L05:
       mov       ecx,1149
       mov       rdx,7FFB5E0E4000
       call      qword ptr [7FFB5E3C77B0]
       mov       r8,rax
       mov       edx,ebp
       mov       ecx,esi
       call      qword ptr [7FFB5E91F1C8]
       int       3
M08_L06:
       lea       r9,[rbp+4]
       mov       r10,r8
       cmp       r9,r11
       je        near ptr M08_L12
M08_L07:
       lea       rax,[rdi-10]
       cmp       rax,r9
       jb        short M08_L09
M08_L08:
       vmovups   xmm0,[r9]
       vpshufb   xmm0,xmm0,[7FFB5E9D22D0]
       vpand     xmm1,xmm0,[7FFB5E9D2200]
       vpmulhuw  xmm1,xmm1,[7FFB5E9D2220]
       vpand     xmm0,xmm0,[7FFB5E9D2240]
       vpmullw   xmm0,xmm0,[7FFB5E9D2260]
       vpor      xmm0,xmm0,xmm1
       vpsubusb  xmm1,xmm0,[7FFB5E9D2280]
       vpcmpgtb  xmm2,xmm0,[7FFB5E9D22A0]
       vpsubb    xmm1,xmm1,xmm2
       vmovups   xmm2,[7FFB5E9D22C0]
       vpshufb   xmm1,xmm2,xmm1
       vpaddb    xmm0,xmm1,xmm0
       vmovups   [r10],xmm0
       add       r9,0C
       add       r10,10
       cmp       r9,rax
       jbe       short M08_L08
       cmp       r9,r11
       je        near ptr M08_L12
M08_L09:
       mov       r8,7FFBBCF94BE0
       add       rdi,0FFFFFFFFFFFFFFFE
       cmp       r9,rdi
       jae       short M08_L11
M08_L10:
       movzx     eax,byte ptr [r9]
       shl       eax,10
       movzx     ebx,byte ptr [r9+1]
       shl       ebx,8
       or        eax,ebx
       movzx     ebx,byte ptr [r9+2]
       or        eax,ebx
       mov       ebx,eax
       shr       ebx,12
       movzx     ebx,byte ptr [r8+rbx]
       mov       ebp,eax
       shr       ebp,0C
       and       ebp,3F
       movzx     ebp,byte ptr [r8+rbp]
       shl       ebp,8
       or        ebx,ebp
       mov       ebp,eax
       shr       ebp,6
       and       ebp,3F
       movzx     ebp,byte ptr [r8+rbp]
       shl       ebp,10
       or        ebx,ebp
       and       eax,3F
       movzx     eax,byte ptr [r8+rax]
       shl       eax,18
       or        eax,ebx
       mov       [r10],eax
       add       r9,3
       add       r10,4
       cmp       r9,rdi
       jb        short M08_L10
M08_L11:
       lea       rax,[rdi+2]
       cmp       rax,r11
       jne       short M08_L12
       lea       rax,[r9+1]
       cmp       rax,r11
       jne       near ptr M08_L30
       movzx     r9d,byte ptr [r9]
       shl       r9d,8
       mov       r11d,r9d
       shr       r11d,0A
       mov       eax,r11d
       movzx     eax,byte ptr [r8+rax]
       shr       r9d,4
       and       r9d,3F
       movzx     r8d,byte ptr [r8+r9]
       shl       r8d,8
       or        r8d,eax
       or        r8d,3D3D0000
       mov       [r10],r8d
M08_L12:
       xor       r9d,r9d
       mov       [rsp+30],r9
       mov       [rsp+28],r9
       mov       r9d,edx
       lea       r9,[rcx+r9*2]
       mov       edx,edx
       add       rdx,rcx
       lea       r8,[rcx+1F]
       cmp       rdx,r8
       jbe       short M08_L14
M08_L13:
       add       rdx,0FFFFFFFFFFFFFFE0
       add       r9,0FFFFFFFFFFFFFFC0
       vmovups   ymm0,[rdx]
       vmovaps   ymm1,ymm0
       vpmovzxbw ymm1,xmm1
       vextracti128 xmm0,ymm0,1
       vpmovzxbw ymm0,xmm0
       vmovups   [r9],ymm1
       vmovups   [r9+20],ymm0
       cmp       rdx,r8
       ja        short M08_L13
M08_L14:
       lea       r8,[rcx+0F]
       cmp       rdx,r8
       jbe       short M08_L16
M08_L15:
       add       rdx,0FFFFFFFFFFFFFFF0
       add       r9,0FFFFFFFFFFFFFFE0
       vmovups   xmm0,[rdx]
       vpmovzxbw xmm1,xmm0
       vpsrldq   xmm0,xmm0,8
       vpmovzxbw xmm0,xmm0
       vmovups   [r9],xmm1
       vmovups   [r9+10],xmm0
       cmp       rdx,r8
       ja        short M08_L15
M08_L16:
       add       rcx,3
       cmp       rdx,rcx
       jbe       short M08_L18
M08_L17:
       add       r9,0FFFFFFFFFFFFFFF8
       add       rdx,0FFFFFFFFFFFFFFFC
       vmovd     xmm0,dword ptr [rdx]
       vpmovzxbw xmm0,xmm0
       vmovq     qword ptr [r9],xmm0
       cmp       rdx,rcx
       ja        short M08_L17
M08_L18:
       mov       rax,rsi
M08_L19:
       vzeroupper
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M08_L20:
       mov       ecx,1139
       mov       rdx,7FFB5E0E4000
       call      qword ptr [7FFB5E3C77B0]
       mov       rcx,rax
       call      qword ptr [7FFB5E91D2C0]
       int       3
M08_L21:
       mov       ecx,0B3
       mov       rdx,7FFB5E0E4000
       call      qword ptr [7FFB5E3C77B0]
       mov       rdx,rax
       mov       ecx,ebx
       call      qword ptr [7FFB5E91D290]
       int       3
M08_L22:
       mov       ecx,1149
       mov       rdx,7FFB5E0E4000
       call      qword ptr [7FFB5E3C77B0]
       mov       rdx,rax
       mov       ecx,esi
       call      qword ptr [7FFB5E91D290]
       int       3
M08_L23:
       call      qword ptr [7FFB5E317198]
       int       3
M08_L24:
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFB5E91EA18]
       mov       rsi,rax
       mov       [rbx+8],edi
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB5E91DAD0]
       mov       rbx,rax
       mov       ecx,1157
       mov       rdx,7FFB5E0E4000
       call      qword ptr [7FFB5E3C77B0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FFB5E526130]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M08_L25:
       mov       rax,2B105130008
       jmp       near ptr M08_L19
M08_L26:
       xor       eax,eax
       jmp       near ptr M08_L02
M08_L27:
       mov       ecx,eax
       shr       ecx,2
       imul      rcx,1AF286BD
       shr       rcx,21
       imul      edx,ecx,4C
       mov       r8d,eax
       sub       r8d,edx
       mov       edx,ecx
       dec       ecx
       test      r8d,r8d
       cmove     edx,ecx
       lea       eax,[rax+rdx*2]
       jmp       near ptr M08_L01
M08_L28:
       mov       rcx,offset MT_System.OutOfMemoryException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       call      qword ptr [7FFB5E91E3E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M08_L29:
       sar       r9d,2
       lea       eax,[r9+r9*2]
       jmp       near ptr M08_L03
M08_L30:
       lea       rax,[r9+2]
       cmp       rax,r11
       jne       near ptr M08_L12
       movzx     eax,byte ptr [r9]
       shl       eax,10
       movzx     r9d,byte ptr [r9+1]
       shl       r9d,8
       or        r9d,eax
       mov       eax,r9d
       shr       eax,12
       movzx     eax,byte ptr [r8+rax]
       mov       r11d,r9d
       shr       r11d,0C
       and       r11d,3F
       movzx     r11d,byte ptr [r8+r11]
       shl       r11d,8
       or        eax,r11d
       shr       r9d,6
       and       r9d,3F
       movzx     r9d,byte ptr [r8+r9]
       shl       r9d,10
       or        r9d,eax
       or        r9d,3D000000
       mov       [r10],r9d
       jmp       near ptr M08_L12
M08_L31:
       mov       [rsp+40],rbp
       mov       rdx,rbp
       test      rsi,rsi
       jne       short M08_L32
       xor       ecx,ecx
       jmp       short M08_L33
M08_L32:
       lea       rcx,[rsi+0C]
       mov       [rsp+38],rcx
       mov       rcx,[rsp+38]
M08_L33:
       mov       [rsp+20],edi
       mov       r9d,ebx
       xor       r8d,r8d
       call      qword ptr [7FFB5E91EA30]
       xor       eax,eax
       mov       [rsp+38],rax
       mov       [rsp+40],rax
       jmp       near ptr M08_L18
M08_L34:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 1502
```
```assembly
; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Return(Byte[], Boolean)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       mov       rdi,rcx
       mov       rbx,rdx
       mov       esi,r8d
       test      rbx,rbx
       je        near ptr M09_L07
       mov       ebp,[rbx+8]
       lea       ecx,[rbp-1]
       or        ecx,0F
       xor       r14d,r14d
       lzcnt     r14d,ecx
       xor       r14d,1F
       add       r14d,0FFFFFFFD
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],9
       jle       near ptr M09_L05
       mov       rcx,[rcx+240]
       mov       rax,[rcx+48]
       test      rax,rax
       je        near ptr M09_L05
M09_L00:
       mov       r15,[rax+10]
       test      r15,r15
       je        near ptr M09_L06
M09_L01:
       xor       r13d,r13d
       mov       r12d,1
       cmp       [r15+8],r14d
       jbe       short M09_L03
       mov       r13d,1
       test      sil,sil
       je        short M09_L02
       mov       rcx,[rbx]
       movzx     edx,word ptr [rcx]
       mov       eax,[rbx+8]
       imul      rdx,rax
       lea       rax,[rbx+10]
       test      dword ptr [rcx],1000000
       jne       near ptr M09_L08
       mov       rcx,rax
       call      qword ptr [7FFB5E1A57E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
M09_L02:
       mov       ecx,10
       shlx      ecx,ecx,r14d
       cmp       ebp,ecx
       jne       near ptr M09_L09
       mov       ecx,r14d
       shl       rcx,4
       lea       rsi,[r15+rcx+10]
       mov       r15,[rsi]
       mov       rcx,rsi
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+8],ecx
       test      r15,r15
       jne       near ptr M09_L10
M09_L03:
       mov       rcx,27070000C90
       mov       rsi,[rcx]
       cmp       byte ptr [rsi+9D],0
       jne       near ptr M09_L25
M09_L04:
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
M09_L05:
       mov       ecx,9
       call      qword ptr [7FFB5E91D4D0]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M09_L00
M09_L06:
       mov       rcx,rdi
       call      qword ptr [7FFB5E916658]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
       mov       r15,rax
       jmp       near ptr M09_L01
M09_L07:
       mov       ecx,2
       call      qword ptr [7FFB5E3CC240]
       int       3
M09_L08:
       shr       rdx,3
       mov       rcx,rax
       call      qword ptr [7FFB5E91F030]
       jmp       near ptr M09_L02
M09_L09:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       call      qword ptr [7FFB5E91F270]
       mov       rbx,rax
       mov       ecx,29B
       mov       rdx,7FFB5E0E4000
       call      qword ptr [7FFB5E3C77B0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rbp
       call      qword ptr [7FFB5E526130]
       mov       rcx,rbp
       call      CORINFO_HELP_THROW
       int       3
M09_L10:
       mov       rcx,[rdi+10]
       cmp       r14d,[rcx+8]
       jae       near ptr M09_L28
       mov       edx,r14d
       mov       rax,[rcx+rdx*8+10]
       test      rax,rax
       jne       short M09_L11
       mov       rcx,rdi
       mov       edx,r14d
       call      qword ptr [7FFB5E91F288]
M09_L11:
       mov       r12,[rax+8]
       mov       rcx,offset MT_System.Threading.ProcessorIdCache
       call      System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       cmp       byte ptr [7FFB5E0EB1D4],0
       je        short M09_L12
       call      qword ptr [7FFB5E91F138]
       mov       esi,eax
       jmp       short M09_L14
M09_L12:
       mov       ecx,0A
       call      qword ptr [7FFB5E91F150]
       mov       esi,[rax+10]
       mov       ecx,0A
       call      qword ptr [7FFB5E91F150]
       lea       ecx,[rsi-1]
       mov       [rax+10],ecx
       movzx     eax,si
       test      eax,eax
       jne       short M09_L13
       call      qword ptr [7FFB5E91F168]
       mov       esi,eax
       jmp       short M09_L14
M09_L13:
       sar       esi,10
M09_L14:
       mov       rcx,offset MT_System.Buffers.SharedArrayPoolStatics
       call      System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       eax,esi
       xor       edx,edx
       div       dword ptr [7FFB5E0EB1C8]
       mov       esi,edx
       xor       eax,eax
       jmp       near ptr M09_L21
M09_L15:
       cmp       esi,[r12+8]
       jae       near ptr M09_L28
       mov       ecx,esi
       mov       rdx,[r12+rcx*8+10]
       mov       [rsp+30],rdx
       cmp       [rdx],dl
       xor       r8d,r8d
       mov       [rsp+3C],r8d
       mov       rcx,rdx
       call      qword ptr [7FFB5E6BE3B8]; System.Threading.Monitor.Enter(System.Object)
       mov       rax,[rsp+30]
       mov       rcx,[rax+8]
       mov       r8d,[rax+10]
       mov       [rsp+38],r8d
       cmp       [rcx+8],r8d
       jbe       short M09_L17
       test      r8d,r8d
       jne       short M09_L18
       xor       edx,edx
       mov       [rax+14],edx
M09_L16:
       mov       edx,r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rsp+38]
       inc       ecx
       mov       rax,[rsp+30]
       mov       [rax+10],ecx
       mov       dword ptr [rsp+3C],1
M09_L17:
       mov       rcx,rax
       call      qword ptr [7FFB5E1A6820]; System.Threading.Monitor.Exit(System.Object)
       cmp       dword ptr [rsp+3C],0
       je        short M09_L19
       jmp       short M09_L22
M09_L18:
       jmp       short M09_L16
M09_L19:
       inc       esi
       cmp       [r12+8],esi
       jne       short M09_L20
       xor       esi,esi
M09_L20:
       mov       eax,[rsp+40]
       inc       eax
M09_L21:
       mov       [rsp+40],eax
       cmp       [r12+8],eax
       jg        near ptr M09_L15
       jmp       short M09_L23
M09_L22:
       mov       r12d,1
       jmp       short M09_L24
M09_L23:
       xor       r12d,r12d
M09_L24:
       jmp       near ptr M09_L03
M09_L25:
       test      ebp,ebp
       je        near ptr M09_L04
       mov       rcx,rbx
       call      qword ptr [7FFB5E5BD830]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r15d,eax
       mov       [rsp+44],ebp
       cmp       [rdi],dil
       mov       rcx,rdi
       call      qword ptr [7FFB5E5BD830]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,rsi
       mov       r8d,r15d
       mov       r9d,[rsp+44]
       mov       edx,3
       call      qword ptr [7FFB5E91E898]
       test      r12d,r13d
       jne       near ptr M09_L04
       mov       rcx,rbx
       call      qword ptr [7FFB5E5BD830]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       ebx,eax
       mov       rcx,rdi
       call      qword ptr [7FFB5E5BD830]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       test      r13d,r13d
       jne       short M09_L26
       mov       ecx,0FFFFFFFF
       mov       edx,1
       jmp       short M09_L27
M09_L26:
       mov       ecx,r14d
       xor       edx,edx
M09_L27:
       mov       [rsp+20],ecx
       mov       [rsp+28],edx
       mov       rcx,rsi
       mov       edx,ebx
       mov       r8d,ebp
       call      qword ptr [7FFB5E91F2A0]
       jmp       near ptr M09_L04
M09_L28:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 913
```

