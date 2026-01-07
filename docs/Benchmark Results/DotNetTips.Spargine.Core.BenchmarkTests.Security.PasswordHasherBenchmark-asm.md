## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Security.PasswordHasherBenchmark.HashPasswordPBKDF2()
       sub       rsp,28
       mov       rcx,23A455D0670
       call      qword ptr [7FF9F81C7138]; DotNetTips.Spargine.Core.Security.PasswordHasher.HashPasswordPBKDF2(System.String)
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
       mov       rbx,rcx
       mov       rsi,offset MT_System.Byte[]
       mov       rcx,rsi
       mov       edx,100
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rdi,rax
       lea       rcx,[rdi+10]
       mov       [rbp-40],rcx
       mov       edx,100
       call      qword ptr [7FF9F8147090]; System.Security.Cryptography.RandomNumberGeneratorImplementation.GetBytes(Byte*, Int32)
       xor       ecx,ecx
       mov       [rbp-40],rcx
       mov       [rbp-40],rcx
       test      rbx,rbx
       je        near ptr M01_L15
       lea       r14,[rbx+0C]
       mov       ebx,[rbx+8]
       lea       r15,[rdi+10]
       mov       rcx,23A455C8E10
       call      qword ptr [7FF9F81CFAB0]; System.Security.Cryptography.Rfc2898DeriveBytes.ValidateHashAlgorithm(System.Security.Cryptography.HashAlgorithmName)
       mov       rcx,rsi
       mov       edx,20
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r13,rax
       lea       rcx,[r13+10]
       mov       [rbp-88],r14
       mov       [rbp-80],ebx
       mov       [rbp-98],r15
       mov       dword ptr [rbp-90],100
       mov       [rbp-0A8],rcx
       mov       dword ptr [rbp-0A0],20
       mov       rcx,23A455C8E10
       mov       [rsp+20],rcx
       lea       rcx,[rbp-88]
       lea       rdx,[rbp-98]
       lea       r8,[rbp-0A8]
       mov       r9d,186A0
       call      qword ptr [7FF9F81CFAE0]; System.Security.Cryptography.Rfc2898DeriveBytes.Pbkdf2Core(System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Byte>, System.Span`1<Byte>, Int32, System.Security.Cryptography.HashAlgorithmName)
       mov       rcx,1F9B08020B8
       mov       rbx,[rcx]
       mov       r14d,121
       mov       rcx,1F9B0800C90
       mov       r15,[rcx]
       mov       rcx,gs:[58]
       mov       rcx,[rcx+38]
       cmp       dword ptr [rcx+238],9
       jle       near ptr M01_L16
       mov       rcx,[rcx+240]
       mov       rax,[rcx+48]
       test      rax,rax
       je        near ptr M01_L16
M01_L00:
       mov       rcx,[rax+10]
       test      rcx,rcx
       je        near ptr M01_L18
       mov       eax,[rcx+8]
       cmp       eax,5
       jle       near ptr M01_L18
       mov       r12,[rcx+60]
       test      r12,r12
       je        near ptr M01_L18
       xor       eax,eax
       mov       [rcx+60],rax
       cmp       byte ptr [r15+9D],0
       jne       near ptr M01_L17
M01_L01:
       mov       [rbp-0C0],r12
       mov       ebx,[r12+8]
       test      ebx,ebx
       je        near ptr M01_L13
       mov       byte ptr [r12+10],1
       mov       r14d,[rdi+8]
       mov       r15,r14
       cmp       rdi,r12
       je        short M01_L02
       mov       r15d,[r12+8]
       cmp       [r12],rsi
       jne       near ptr M01_L06
M01_L02:
       cmp       r14,100
       jb        near ptr M01_L08
       cmp       r15,101
       jb        near ptr M01_L08
       lea       rcx,[r12+11]
       lea       rdx,[rdi+10]
       mov       r8d,100
       call      qword ptr [7FF9F7AE5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       edi,[r13+8]
       mov       r14,rdi
       cmp       r13,r12
       je        short M01_L03
       mov       r14d,[r12+8]
       cmp       [r12],rsi
       jne       near ptr M01_L09
M01_L03:
       cmp       rdi,20
       jb        near ptr M01_L11
       cmp       r14,121
       jb        near ptr M01_L11
       lea       rcx,[r12+111]
       add       r13,10
       vmovdqu   ymm0,ymmword ptr [r13]
       vmovdqu   ymmword ptr [rcx],ymm0
       mov       esi,ebx
       sub       esi,121
       test      esi,esi
       jg        short M01_L04
       test      esi,esi
       jl        near ptr M01_L05
M01_L04:
       cmp       ebx,121
       jb        near ptr M01_L12
       add       r12,10
       mov       ecx,121
       xor       edx,edx
       call      qword ptr [7FF9F7FD4138]; System.Convert.ToBase64_CalculateAndValidateOutputLength(Int32, Boolean)
       movsxd    rdx,eax
       mov       rcx,offset MT_System.String
       call      00007FFA57738D20
       mov       rsi,rax
       lea       rcx,[rsi+0C]
       mov       r8d,[rsi+8]
       mov       edx,r8d
       mov       [rbp-98],r12
       mov       dword ptr [rbp-90],121
       mov       [rbp-0B8],rcx
       mov       [rbp-0B0],edx
       lea       rcx,[rbp-98]
       lea       rdx,[rbp-0B8]
       call      qword ptr [7FF9F7FD4150]; System.Convert.ToBase64CharsLargeNoLineBreaks(System.ReadOnlySpan`1<Byte>, System.Span`1<Char>, Int32)
       xor       eax,eax
       mov       [rbp-60],rax
       mov       [rbp-68],rax
       mov       [rbp-0C8],rsi
       jmp       near ptr M01_L14
M01_L05:
       mov       ecx,1149
       mov       rdx,7FF9F7A24000
       call      qword ptr [7FF9F7D67738]
       mov       r8,rax
       mov       edx,esi
       xor       ecx,ecx
       call      qword ptr [7FF9F82ED488]
       int       3
M01_L06:
       mov       rcx,r12
       call      00007FFA576B9B60
       mov       ecx,3003FFC
       bt        ecx,eax
       jb        short M01_L07
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      qword ptr [7FF9F82ECE88]
       mov       r15,rax
       mov       ecx,25F
       mov       rdx,7FF9F7A24000
       call      qword ptr [7FF9F7D67738]
       mov       r8,rax
       mov       rdx,r15
       mov       rcx,r14
       call      qword ptr [7FF9F7F35DD0]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
       int       3
M01_L07:
       mov       rcx,[r12]
       movzx     ecx,word ptr [rcx]
       imul      r15,rcx
       jmp       near ptr M01_L02
M01_L08:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9F82ECEA0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F7D6FED0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L09:
       mov       rcx,r12
       call      00007FFA576B9B60
       mov       ecx,3003FFC
       bt        ecx,eax
       jb        short M01_L10
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9F82ECE88]
       mov       r14,rax
       mov       ecx,25F
       mov       rdx,7FF9F7A24000
       call      qword ptr [7FF9F7D67738]
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,rdi
       call      qword ptr [7FF9F7F35DD0]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M01_L10:
       mov       rcx,[r12]
       movzx     ecx,word ptr [rcx]
       imul      r14,rcx
       jmp       near ptr M01_L03
M01_L11:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9F82ECEA0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F7D6FED0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L12:
       call      qword ptr [7FF9F7C87138]
       int       3
M01_L13:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M01_L14:
       call      M01_L35
       nop
       mov       rax,[rbp-0C8]
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
M01_L15:
       mov       ecx,503
       mov       rdx,7FF9F7FEE048
       call      qword ptr [7FF9F7D67738]
       mov       rcx,rax
       call      qword ptr [7FF9F82EC888]
       int       3
M01_L16:
       mov       ecx,9
       call      qword ptr [7FF9F82ECF78]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M01_L00
M01_L17:
       mov       rcx,r12
       call      qword ptr [7FF9F7FDC918]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r14d,eax
       mov       eax,[r12+8]
       mov       [rbp-50],eax
       mov       rcx,rbx
       call      qword ptr [7FF9F7FDC918]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       dword ptr [rsp+20],5
       mov       edx,r14d
       mov       r8d,[rbp-50]
       mov       rcx,r15
       call      qword ptr [7FF9F82ED3F8]
       jmp       near ptr M01_L01
M01_L18:
       mov       rcx,[rbx+10]
       cmp       dword ptr [rcx+8],5
       jle       near ptr M01_L30
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        near ptr M01_L29
       mov       r12,[rcx+8]
       mov       rcx,offset MT_System.Threading.ProcessorIdCache
       call      System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       cmp       byte ptr [7FF9F7A2B1DC],0
       je        short M01_L19
       call      qword ptr [7FF9F82ED410]
       mov       r14d,eax
       jmp       short M01_L21
M01_L19:
       mov       ecx,0A
       call      qword ptr [7FF9F82ED428]
       mov       r14d,[rax+10]
       mov       ecx,0A
       call      qword ptr [7FF9F82ED428]
       lea       ecx,[r14-1]
       mov       [rax+10],ecx
       movzx     eax,r14w
       test      eax,eax
       jne       short M01_L20
       call      qword ptr [7FF9F82ED440]
       mov       r14d,eax
       jmp       short M01_L21
M01_L20:
       sar       r14d,10
M01_L21:
       mov       rcx,offset MT_System.Buffers.SharedArrayPoolStatics
       call      System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       eax,r14d
       xor       edx,edx
       div       dword ptr [7FF9F7A2B1D0]
       mov       r14d,edx
       xor       eax,eax
       jmp       near ptr M01_L25
M01_L22:
       cmp       r14d,[r12+8]
       jae       near ptr M01_L34
       mov       ecx,r14d
       mov       rdx,[r12+rcx*8+10]
       mov       [rbp-0D8],rdx
       cmp       [rdx],dl
       xor       r8d,r8d
       mov       [rbp-0D0],r8
       mov       rcx,rdx
       call      qword ptr [7FF9F80CD5D8]; System.Threading.Monitor.Enter(System.Object)
       mov       rdx,[rbp-0D8]
       mov       rcx,[rdx+8]
       mov       eax,[rdx+10]
       dec       eax
       cmp       [rcx+8],eax
       jbe       short M01_L23
       mov       r8d,eax
       mov       r8,[rcx+r8*8+10]
       mov       [rbp-0D0],r8
       mov       r10d,eax
       xor       r9d,r9d
       mov       [rcx+r10*8+10],r9
       mov       [rdx+10],eax
M01_L23:
       mov       rcx,rdx
       call      qword ptr [7FF9F7AE6820]; System.Threading.Monitor.Exit(System.Object)
       mov       rcx,[rbp-0D0]
       test      rcx,rcx
       jne       short M01_L26
       inc       r14d
       cmp       [r12+8],r14d
       jne       short M01_L24
       xor       r14d,r14d
M01_L24:
       mov       eax,[rbp-54]
       inc       eax
M01_L25:
       mov       [rbp-54],eax
       cmp       [r12+8],eax
       jg        near ptr M01_L22
       jmp       short M01_L27
M01_L26:
       mov       r12,rcx
       jmp       short M01_L28
M01_L27:
       xor       r12d,r12d
M01_L28:
       test      r12,r12
       je        short M01_L29
       cmp       byte ptr [r15+9D],0
       je        near ptr M01_L01
       mov       rcx,r12
       call      qword ptr [7FF9F7FDC918]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r14d,eax
       mov       eax,[r12+8]
       mov       [rbp-4C],eax
       mov       rcx,rbx
       call      qword ptr [7FF9F7FDC918]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       dword ptr [rsp+20],5
       mov       edx,r14d
       mov       r8d,[rbp-4C]
       mov       rcx,r15
       call      qword ptr [7FF9F82ED3F8]
       jmp       near ptr M01_L01
M01_L29:
       mov       r14d,200
       jmp       short M01_L31
M01_L30:
       mov       ecx,121
       mov       rdx,23A455C6F28
       call      qword ptr [7FF9F7D6D770]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
M01_L31:
       cmp       r14d,800
       jge       short M01_L32
       mov       edx,r14d
       mov       rcx,rsi
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r12,rax
       jmp       short M01_L33
M01_L32:
       mov       ecx,r14d
       xor       edx,edx
       call      qword ptr [7FF9F82ED3B0]
       mov       r12,rax
M01_L33:
       cmp       byte ptr [r15+9D],0
       je        near ptr M01_L01
       cmp       [r12],r12b
       mov       rcx,r12
       call      qword ptr [7FF9F7FDC918]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r14d,eax
       mov       eax,[r12+8]
       mov       [rbp-44],eax
       mov       rcx,rbx
       call      qword ptr [7FF9F7FDC918]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       edx,r14d
       mov       r8d,[rbp-44]
       mov       rcx,r15
       call      qword ptr [7FF9F82ED3F8]
       mov       eax,[r12+8]
       mov       [rbp-48],eax
       mov       rcx,rbx
       call      qword ptr [7FF9F7FDC918]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       rcx,[rbx+10]
       mov       edx,1
       mov       r8d,2
       cmp       dword ptr [rcx+8],5
       cmovg     edx,r8d
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       [rsp+28],edx
       mov       rcx,r15
       mov       edx,r14d
       mov       r8d,[rbp-48]
       call      qword ptr [7FF9F82ED458]
       jmp       near ptr M01_L01
M01_L34:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M01_L35:
       sub       rsp,38
       mov       rcx,1F9B08020B8
       mov       rbx,[rcx]
       cmp       qword ptr [rbp-0C0],0
       je        near ptr M01_L39
       mov       rcx,[rbp-0C0]
       mov       eax,[rcx+8]
       mov       esi,eax
       lea       eax,[rsi-1]
       or        eax,0F
       xor       edi,edi
       lzcnt     edi,eax
       xor       edi,1F
       add       edi,0FFFFFFFD
       mov       rax,gs:[58]
       mov       rax,[rax+38]
       cmp       dword ptr [rax+238],9
       jle       short M01_L36
       mov       rax,[rax+240]
       mov       rax,[rax+48]
       test      rax,rax
       jne       short M01_L37
M01_L36:
       mov       ecx,9
       call      qword ptr [7FF9F82ECF78]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
M01_L37:
       mov       r14,[rax+10]
       test      r14,r14
       jne       short M01_L38
       mov       rcx,rbx
       call      qword ptr [7FF9F81CFDB0]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
       mov       r14,rax
M01_L38:
       xor       r15d,r15d
       mov       r13d,1
       cmp       [r14+8],edi
       jbe       near ptr M01_L57
       mov       r15d,1
       mov       rcx,[rbp-0C0]
       mov       rdx,[rcx]
       movzx     eax,word ptr [rdx]
       mov       r8d,[rcx+8]
       imul      r8,rax
       lea       rax,[rcx+10]
       test      dword ptr [rdx],1000000
       jne       short M01_L41
       jmp       short M01_L40
M01_L39:
       mov       ecx,2
       call      qword ptr [7FF9F7D6C1C8]
       int       3
M01_L40:
       mov       rcx,rax
       mov       rdx,r8
       call      qword ptr [7FF9F7AE57E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
       jmp       short M01_L42
M01_L41:
       mov       rdx,r8
       shr       rdx,3
       mov       rcx,rax
       call      qword ptr [7FF9F82EDC08]
M01_L42:
       mov       ecx,10
       shlx      ecx,ecx,edi
       cmp       esi,ecx
       je        short M01_L43
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9F82EDBA8]
       mov       rbx,rax
       mov       ecx,29B
       mov       rdx,7FF9F7A24000
       call      qword ptr [7FF9F7D67738]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9F7F35DD0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M01_L43:
       mov       ecx,edi
       shl       rcx,4
       lea       r14,[r14+rcx+10]
       mov       r12,[r14]
       mov       rdx,[rbp-0C0]
       mov       rcx,r14
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r14+8],ecx
       test      r12,r12
       je        near ptr M01_L57
       mov       rcx,[rbx+10]
       cmp       edi,[rcx+8]
       jae       near ptr M01_L58
       mov       edx,edi
       mov       rax,[rcx+rdx*8+10]
       test      rax,rax
       jne       short M01_L44
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FF9F82EDBC0]
M01_L44:
       mov       r13,[rax+8]
       mov       rcx,offset MT_System.Threading.ProcessorIdCache
       call      System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       cmp       byte ptr [7FF9F7A2B1DC],0
       je        short M01_L45
       call      qword ptr [7FF9F82ED410]
       mov       r14d,eax
       jmp       short M01_L47
M01_L45:
       mov       ecx,0A
       call      qword ptr [7FF9F82ED428]
       mov       r14d,[rax+10]
       mov       ecx,0A
       call      qword ptr [7FF9F82ED428]
       lea       ecx,[r14-1]
       mov       [rax+10],ecx
       movzx     eax,r14w
       test      eax,eax
       jne       short M01_L46
       call      qword ptr [7FF9F82ED440]
       mov       r14d,eax
       jmp       short M01_L47
M01_L46:
       sar       r14d,10
M01_L47:
       mov       rcx,offset MT_System.Buffers.SharedArrayPoolStatics
       call      System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       eax,r14d
       xor       edx,edx
       div       dword ptr [7FF9F7A2B1D0]
       mov       r14d,edx
       xor       eax,eax
       jmp       near ptr M01_L54
M01_L48:
       cmp       r14d,[r13+8]
       jae       near ptr M01_L58
       mov       ecx,r14d
       mov       rdx,[r13+rcx*8+10]
       mov       [rbp-0E0],rdx
       cmp       [rdx],dl
       xor       r8d,r8d
       mov       [rbp-74],r8d
       mov       rcx,rdx
       call      qword ptr [7FF9F80CD5D8]; System.Threading.Monitor.Enter(System.Object)
       mov       rax,[rbp-0E0]
       mov       rcx,[rax+8]
       mov       r8d,[rax+10]
       mov       [rbp-78],r8d
       cmp       [rcx+8],r8d
       jbe       short M01_L50
       test      r8d,r8d
       jne       short M01_L51
       xor       edx,edx
       mov       [rax+14],edx
M01_L49:
       mov       edx,r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rbp-78]
       inc       ecx
       mov       rax,[rbp-0E0]
       mov       [rax+10],ecx
       mov       dword ptr [rbp-74],1
M01_L50:
       mov       rcx,rax
       call      qword ptr [7FF9F7AE6820]; System.Threading.Monitor.Exit(System.Object)
       cmp       dword ptr [rbp-74],0
       je        short M01_L52
       jmp       short M01_L55
M01_L51:
       jmp       short M01_L49
M01_L52:
       inc       r14d
       cmp       [r13+8],r14d
       jne       short M01_L53
       xor       r14d,r14d
M01_L53:
       mov       eax,[rbp-70]
       inc       eax
M01_L54:
       mov       [rbp-70],eax
       cmp       [r13+8],eax
       jg        near ptr M01_L48
       jmp       short M01_L56
M01_L55:
       mov       r13d,1
       jmp       short M01_L57
M01_L56:
       xor       r13d,r13d
M01_L57:
       mov       rax,1F9B0800C90
       mov       r14,[rax]
       cmp       byte ptr [r14+9D],0
       je        near ptr M01_L61
       test      esi,esi
       je        near ptr M01_L61
       mov       rcx,[rbp-0C0]
       call      qword ptr [7FF9F7FDC918]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r12d,eax
       mov       [rbp-6C],esi
       mov       rcx,rbx
       call      qword ptr [7FF9F7FDC918]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,r14
       mov       r8d,r12d
       mov       r9d,[rbp-6C]
       mov       edx,3
       call      qword ptr [7FF9F82EDBD8]
       test      r13d,r15d
       jne       short M01_L61
       mov       rcx,[rbp-0C0]
       call      qword ptr [7FF9F7FDC918]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r13d,eax
       mov       rcx,rbx
       call      qword ptr [7FF9F7FDC918]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       test      r15d,r15d
       jne       short M01_L59
       mov       ecx,0FFFFFFFF
       mov       edx,1
       jmp       short M01_L60
M01_L58:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M01_L59:
       mov       ecx,edi
       xor       edx,edx
M01_L60:
       mov       [rsp+20],ecx
       mov       [rsp+28],edx
       mov       rcx,r14
       mov       edx,r13d
       mov       r8d,esi
       call      qword ptr [7FF9F82EDBF0]
M01_L61:
       nop
       add       rsp,38
       ret
; Total bytes of code 2735
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       sub       rsp,0B8
       lea       rbp,[rsp+0F0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-0B0],ymm4
       vmovdqu   ymmword ptr [rbp-90],ymm4
       vmovdqu   ymmword ptr [rbp-70],ymm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       xor       eax,eax
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
       mov       rcx,1DE300020C8
       mov       rcx,[rcx]
       mov       rdx,21EC4E98E10
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
       mov       dword ptr [rbp-68],324A7FF0
       mov       dword ptr [rbp-70],0E26C405F
       cmp       r12d,8
       jb        short M00_L03
       mov       eax,r12d
       shr       eax,3
       mov       [rbp-5C],eax
M00_L02:
       mov       ecx,[rbp-68]
       add       ecx,[r13]
       mov       [rbp-68],ecx
       mov       ecx,[r13+4]
       mov       edx,[rbp-68]
       mov       r8d,[rbp-70]
       xor       r8d,edx
       rol       edx,14
       add       edx,r8d
       rol       r8d,9
       xor       r8d,edx
       rol       edx,1B
       add       edx,r8d
       rol       r8d,13
       mov       [rbp-68],edx
       mov       [rbp-70],r8d
       add       ecx,[rbp-68]
       mov       [rbp-68],ecx
       lea       rcx,[rbp-68]
       lea       rdx,[rbp-70]
       call      qword ptr [7FF9F8295FC8]; System.Marvin.Block(UInt32 ByRef, UInt32 ByRef)
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
       lea       rdx,[rbp-70]
       call      qword ptr [7FF9F8295FC8]; System.Marvin.Block(UInt32 ByRef, UInt32 ByRef)
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
       lea       rdx,[rbp-70]
       call      qword ptr [7FF9F8295FC8]; System.Marvin.Block(UInt32 ByRef, UInt32 ByRef)
       lea       rcx,[rbp-68]
       lea       rdx,[rbp-70]
       call      qword ptr [7FF9F8295FC8]; System.Marvin.Block(UInt32 ByRef, UInt32 ByRef)
       mov       ecx,[rbp-70]
       xor       ecx,[rbp-68]
M00_L07:
       mov       edx,[rbp-48]
       call      qword ptr [7FF9F80D7BE8]; System.HashCode.Combine[[System.Int32, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](Int32, Int32)
       mov       r13d,eax
       xor       r8d,r8d
       mov       [rbp-58],r8
       mov       r8d,r13d
       mov       rdx,r15
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentDictionary<System.ValueTuple<System.String, Interop+BCrypt+BCryptOpenAlgorithmProviderFlags>, System.ValueTuple<Microsoft.Win32.SafeHandles.SafeBCryptAlgorithmHandle, System.Int32>>
       call      qword ptr [7FF9F81D7A08]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.ValueTuple`2[[System.__Canon, System.Private.CoreLib],[Interop+BCrypt+BCryptOpenAlgorithmProviderFlags, System.Security.Cryptography]], System.Private.CoreLib],[System.ValueTuple`2[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]], System.Private.CoreLib]].GetBucket(Tables<System.ValueTuple`2<System.__Canon,BCryptOpenAlgorithmProviderFlags>,System.ValueTuple`2<System.__Canon,Int32>>, Int32)
       mov       r12,rax
       test      r12,r12
       je        near ptr M00_L17
M00_L08:
       cmp       r13d,[r12+10]
       jne       near ptr M00_L16
       vmovdqu   xmm0,xmmword ptr [r12+18]
       vmovdqu   xmmword ptr [rbp-80],xmm0
       vmovdqu   xmm0,xmmword ptr [rbp-50]
       vmovdqu   xmmword ptr [rbp-90],xmm0
       lea       rdx,[rbp-80]
       lea       r8,[rbp-90]
       mov       rcx,1DE300020E0
       mov       rcx,[rcx]
       call      qword ptr [7FF9F8250A08]; System.Collections.Generic.GenericEqualityComparer`1[[System.ValueTuple`2[[System.__Canon, System.Private.CoreLib],[Interop+BCrypt+BCryptOpenAlgorithmProviderFlags, System.Security.Cryptography]], System.Private.CoreLib]].Equals(System.ValueTuple`2<System.__Canon,BCryptOpenAlgorithmProviderFlags>, System.ValueTuple`2<System.__Canon,BCryptOpenAlgorithmProviderFlags>)
       test      eax,eax
       je        near ptr M00_L16
       mov       rdx,[r12+28]
       mov       ecx,[r12+30]
M00_L09:
       mov       [r14],ecx
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+8]
       mov       [rbp-0B0],rdi
       xor       edx,edx
       mov       [rbp-0A8],edx
       mov       [rsp+28],edx
       mov       dword ptr [rsp+30],20
       lea       rdx,[rbp-0B0]
       mov       [rsp+20],rdx
       lea       rdx,[rbp-40]
       xor       r8d,r8d
       xor       r9d,r9d
       call      qword ptr [7FF9F81D7F48]; Interop+BCrypt.BCryptCreateHash(Microsoft.Win32.SafeHandles.SafeBCryptAlgorithmHandle, Microsoft.Win32.SafeHandles.SafeBCryptHashHandle ByRef, IntPtr, Int32, System.ReadOnlySpan`1<Byte>, Int32, BCryptCreateHashFlags)
       mov       edi,eax
       cmp       edi,0C000000D
       jne       short M00_L12
       mov       rcx,[rbp-40]
       cmp       [rcx],ecx
       call      qword ptr [7FF9F7C1E500]; System.Runtime.InteropServices.SafeHandle.Dispose()
       mov       rcx,rsi
       call      qword ptr [7FF9F8238CE8]; System.Security.Cryptography.HashProviderCng.Reset()
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
       mov       [rbp-0B8],rbx
       mov       rcx,21EC4EA0698
       mov       rdx,rbx
       call      qword ptr [7FF9F81D7360]; DotNetTips.Spargine.Core.Security.PasswordHasher.HashPasswordSHA(System.String, System.Security.Cryptography.HashAlgorithm)
       mov       rsi,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F8238198]; System.Security.Cryptography.HashAlgorithm.Dispose()
       mov       rax,rsi
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
       mov       rcx,21EC4E98E10
       xor       r8d,r8d
       xor       edx,edx
       call      qword ptr [7FF9F81D7A80]; Interop+BCrypt.BCryptOpenAlgorithmProvider(System.String, System.String, BCryptOpenAlgorithmProviderFlags)
       mov       r15,rax
       mov       rcx,r15
       mov       rdx,21EC4EA0758
       call      qword ptr [7FF9F81D7B58]; Interop+BCrypt.BCryptGetDWordProperty(Microsoft.Win32.SafeHandles.SafeBCryptHandle, System.String)
       mov       rdx,21EC4E98E10
       mov       [rbp-80],rdx
       xor       edx,edx
       mov       [rbp-78],edx
       mov       [rbp-0A0],r15
       mov       [rbp-98],eax
       lea       rdx,[rbp-80]
       lea       r8,[rbp-0A0]
       mov       rcx,1DE300020C8
       mov       rcx,[rcx]
       call      qword ptr [7FF9F81D7BD0]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.ValueTuple`2[[System.__Canon, System.Private.CoreLib],[Interop+BCrypt+BCryptOpenAlgorithmProviderFlags, System.Security.Cryptography]], System.Private.CoreLib],[System.ValueTuple`2[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]], System.Private.CoreLib]].TryAdd(System.ValueTuple`2<System.__Canon,BCryptOpenAlgorithmProviderFlags>, System.ValueTuple`2<System.__Canon,Int32>)
       test      eax,eax
       jne       near ptr M00_L00
       jmp       near ptr M00_L21
M00_L18:
       vmovdqu   xmm0,xmmword ptr [rbp-50]
       vmovdqu   xmmword ptr [rbp-80],xmm0
       lea       r8,[rbp-80]
       mov       rdx,r13
       call      qword ptr [7FF9F81D7A38]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.ValueTuple`2[[System.__Canon, System.Private.CoreLib],[Interop+BCrypt+BCryptOpenAlgorithmProviderFlags, System.Security.Cryptography]], System.Private.CoreLib],[System.ValueTuple`2[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]], System.Private.CoreLib]].GetHashCode(System.Collections.Generic.IEqualityComparer`1<System.ValueTuple`2<System.__Canon,BCryptOpenAlgorithmProviderFlags>>, System.ValueTuple`2<System.__Canon,BCryptOpenAlgorithmProviderFlags>)
       mov       r12d,eax
       mov       r8d,r12d
       mov       rdx,r15
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentDictionary<System.ValueTuple<System.String, Interop+BCrypt+BCryptOpenAlgorithmProviderFlags>, System.ValueTuple<Microsoft.Win32.SafeHandles.SafeBCryptAlgorithmHandle, System.Int32>>
       call      qword ptr [7FF9F81D7A08]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.ValueTuple`2[[System.__Canon, System.Private.CoreLib],[Interop+BCrypt+BCryptOpenAlgorithmProviderFlags, System.Security.Cryptography]], System.Private.CoreLib],[System.ValueTuple`2[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]], System.Private.CoreLib]].GetBucket(Tables<System.ValueTuple`2<System.__Canon,BCryptOpenAlgorithmProviderFlags>,System.ValueTuple`2<System.__Canon,Int32>>, Int32)
       mov       r15,rax
       test      r15,r15
       je        near ptr M00_L17
M00_L19:
       cmp       r12d,[r15+10]
       jne       short M00_L20
       vmovdqu   xmm0,xmmword ptr [r15+18]
       vmovdqu   xmmword ptr [rbp-80],xmm0
       vmovdqu   xmm0,xmmword ptr [rbp-50]
       vmovdqu   xmmword ptr [rbp-90],xmm0
       lea       r8,[rbp-90]
       lea       rdx,[rbp-80]
       mov       rcx,r13
       mov       r11,7FF9F7A40968
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
       call      qword ptr [7FF9F7AFC780]; System.Runtime.InteropServices.SafeHandle.InternalRelease(Boolean)
       mov       rcx,r15
       call      qword ptr [7FF9F7AF7AF8]; System.GC.SuppressFinalize(System.Object)
       jmp       near ptr M00_L00
M00_L22:
       mov       rdx,[r15+28]
       mov       ecx,[r15+30]
       jmp       near ptr M00_L09
M00_L23:
       mov       rcx,[rbp-40]
       cmp       [rcx],ecx
       call      qword ptr [7FF9F7C1E500]; System.Runtime.InteropServices.SafeHandle.Dispose()
       mov       ecx,edi
       call      qword ptr [7FF9F8294C00]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
       sub       rsp,38
       mov       rcx,[rbp-0B8]
       call      qword ptr [7FF9F8238198]; System.Security.Cryptography.HashAlgorithm.Dispose()
       nop
       add       rsp,38
       ret
; Total bytes of code 1276
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
       add       eax,0FCF43D0D
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
       mov       rdx,7FF9F8242868
       call      qword ptr [7FF9F7AFC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rcx,21EC4EA0858
       mov       rax,offset MT_Microsoft.Win32.SafeHandles.SafeBCryptHashHandle
       mov       eax,[rax]
       and       eax,0C0000
       cmp       eax,40000
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M05_L13
       call      qword ptr [7FF9F7AF7BE8]; System.RuntimeType.CreateInstanceOfT()
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
       jne       near ptr M05_L10
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
       mov       rax,7FF9F81899A0
       mov       [rbp-90],rax
       lea       rax,[M05_L02]
       mov       [rbp-80],rax
       lea       rax,[rbp-0A0]
       mov       [r15+8],rax
       mov       byte ptr [r15+4],0
       mov       rax,7FFA91FC3EB0
       call      rax
M05_L02:
       mov       byte ptr [r15+4],1
       cmp       dword ptr [7FFA57A4F778],0
       je        short M05_L03
       call      qword ptr [7FFA57A3D608]; CORINFO_HELP_STOP_FOR_GC
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
       jmp       near ptr M05_L12
M05_L04:
       mov       rcx,rbx
       call      qword ptr [7FF9F7AFC9A8]; System.Object.GetType()
       cmp       qword ptr [rax+10],0
       je        short M05_L05
       mov       rcx,[rax+10]
       mov       rbx,[rcx]
       test      rbx,rbx
       jne       short M05_L08
M05_L05:
       mov       rcx,rax
       call      qword ptr [7FF9F7AF7C48]; System.RuntimeType.InitializeCache()
       mov       rsi,rax
M05_L06:
       mov       rbx,[rsi+20]
       test      rbx,rbx
       je        short M05_L09
M05_L07:
       mov       rcx,offset MT_System.ObjectDisposedException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF9F8295398]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M05_L08:
       mov       rsi,rbx
       jmp       short M05_L06
M05_L09:
       mov       rcx,[rsi+8]
       call      qword ptr [7FF9F7C94A68]; System.RuntimeType.IsFullNameRoundtripCompatible(System.RuntimeType)
       test      eax,eax
       je        short M05_L11
       lea       rdx,[rsi+20]
       mov       rcx,rsi
       mov       r8d,3
       call      qword ptr [7FF9F7C94A80]; System.RuntimeType+RuntimeTypeCache.ConstructName(System.String ByRef, System.TypeNameFormatFlags)
       mov       rbx,rax
       jmp       short M05_L07
M05_L10:
       mov       eax,[rbx+10]
       test      al,1
       je        near ptr M05_L01
       jmp       near ptr M05_L04
M05_L11:
       xor       ebx,ebx
       jmp       short M05_L07
M05_L12:
       call      M05_L14
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
M05_L13:
       xor       edx,edx
       mov       [rbp-60],rdx
       lea       rdx,[rbp-60]
       call      qword ptr [7FF9F8295050]
       mov       rax,[rbp-60]
       jmp       near ptr M05_L00
       sub       rsp,38
       vzeroupper
       xor       ecx,ecx
       mov       [rbp-58],rcx
       add       rsp,38
       ret
M05_L14:
       sub       rsp,38
       vzeroupper
       cmp       dword ptr [rbp-3C],0
       je        near ptr M05_L26
       cmp       byte ptr [rbp-0A4],0
       jne       near ptr M05_L26
       mov       rbx,[rbp-0B0]
       mov       rax,offset MT_Microsoft.Win32.SafeHandles.SafeBCryptHashHandle
       cmp       [rbx],rax
       jne       near ptr M05_L24
       mov       rcx,rbx
       mov       eax,[rbx+10]
       test      al,2
       jne       near ptr M05_L23
M05_L15:
       test      eax,0FFFFFFFC
       jne       short M05_L17
       jmp       short M05_L21
M05_L16:
       mov       eax,[rbx+10]
       test      al,2
       jne       short M05_L23
       jmp       short M05_L15
M05_L17:
       mov       edx,eax
       and       edx,0FFFFFFFD
       cmp       edx,4
       jne       short M05_L18
       cmp       byte ptr [rbx+14],0
       je        short M05_L18
       cmp       qword ptr [rbx+8],0
       setne     dl
       movzx     edx,dl
       jmp       short M05_L19
M05_L18:
       xor       edx,edx
M05_L19:
       lea       r8d,[rax-4]
       mov       r10d,eax
       and       r10d,0FFFFFFFC
       cmp       r10d,4
       jne       short M05_L20
       or        r8d,1
M05_L20:
       lea       r10,[rbx+10]
       or        r8d,2
       mov       [rbp-68],eax
       lock cmpxchg [r10],r8d
       cmp       eax,[rbp-68]
       jne       short M05_L16
       jmp       short M05_L22
M05_L21:
       call      qword ptr [7FF9F8294858]
       int       3
M05_L22:
       test      edx,edx
       je        short M05_L23
       call      00007FFA57736260
       mov       esi,eax
       mov       rcx,[rbx+8]
       call      00007FF9F7AE8C30
       mov       ecx,esi
       call      00007FFA57736280
M05_L23:
       mov       rcx,[rbx]
       test      dword ptr [rcx],100000
       je        short M05_L26
       jmp       short M05_L25
M05_L24:
       mov       rcx,rbx
       mov       edx,1
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       jmp       short M05_L23
M05_L25:
       mov       rcx,rbx
       call      00007FFA576F8C20
M05_L26:
       cmp       byte ptr [rbp-0A8],0
       je        near ptr M05_L43
       mov       rbx,[rbp-0B8]
       mov       rcx,[rbp-0B8]
       cmp       [rcx],cl
       mov       esi,[rbx+10]
       test      esi,0FFFFFFFC
       je        near ptr M05_L35
M05_L27:
       mov       ecx,esi
       and       ecx,0FFFFFFFD
       cmp       ecx,4
       jne       short M05_L32
       jmp       short M05_L29
M05_L28:
       mov       esi,[rbx+10]
       test      esi,0FFFFFFFC
       jne       short M05_L27
       jmp       short M05_L35
M05_L29:
       cmp       byte ptr [rbx+14],0
       je        short M05_L32
       mov       rcx,offset MT_Microsoft.Win32.SafeHandles.SafeBCryptHashHandle
       cmp       [rbx],rcx
       jne       short M05_L30
       cmp       qword ptr [rbx+8],0
       sete      dil
       movzx     edi,dil
       jmp       short M05_L31
M05_L30:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       edi,eax
M05_L31:
       test      edi,edi
       sete      cl
       movzx     ecx,cl
       jmp       short M05_L33
M05_L32:
       xor       ecx,ecx
M05_L33:
       lea       edx,[rsi-4]
       mov       eax,esi
       and       eax,0FFFFFFFC
       cmp       eax,4
       jne       short M05_L34
       or        edx,1
M05_L34:
       lea       r8,[rbx+10]
       mov       eax,esi
       lock cmpxchg [r8],edx
       cmp       eax,esi
       jne       short M05_L28
       jmp       near ptr M05_L40
M05_L35:
       mov       rcx,rbx
       call      qword ptr [7FF9F7AFC9A8]; System.Object.GetType()
       mov       rcx,[rax+10]
       test      rcx,rcx
       je        short M05_L36
       mov       rbx,[rcx]
       test      rbx,rbx
       je        short M05_L36
       mov       rsi,rbx
       jmp       short M05_L37
M05_L36:
       mov       rcx,rax
       call      qword ptr [7FF9F7AF7C48]; System.RuntimeType.InitializeCache()
       mov       rsi,rax
M05_L37:
       mov       rbx,[rsi+20]
       test      rbx,rbx
       jne       short M05_L39
       mov       rcx,[rsi+8]
       call      qword ptr [7FF9F7C94A68]; System.RuntimeType.IsFullNameRoundtripCompatible(System.RuntimeType)
       test      eax,eax
       jne       short M05_L38
       xor       ebx,ebx
       jmp       short M05_L39
M05_L38:
       lea       rdx,[rsi+20]
       mov       rcx,rsi
       mov       r8d,3
       call      qword ptr [7FF9F7C94A80]; System.RuntimeType+RuntimeTypeCache.ConstructName(System.String ByRef, System.TypeNameFormatFlags)
       mov       rbx,rax
M05_L39:
       mov       rcx,offset MT_System.ObjectDisposedException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF9F8295398]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M05_L40:
       test      ecx,ecx
       je        short M05_L43
       call      00007FFA57736260
       mov       esi,eax
       mov       rcx,offset MT_Microsoft.Win32.SafeHandles.SafeBCryptHashHandle
       cmp       [rbx],rcx
       jne       short M05_L41
       mov       rcx,[rbx+8]
       call      00007FF9F7AE8C30
       jmp       short M05_L42
M05_L41:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
M05_L42:
       mov       ecx,esi
       call      00007FFA57736280
M05_L43:
       nop
       add       rsp,38
       ret
; Total bytes of code 1253
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
       call      qword ptr [7FF9F7AFC780]; System.Runtime.InteropServices.SafeHandle.InternalRelease(Boolean)
M06_L00:
       mov       rcx,rbx
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FF9F7AF7AF8]; System.GC.SuppressFinalize(System.Object)
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
       call      qword ptr [7FF9F81D7F48]; Interop+BCrypt.BCryptCreateHash(Microsoft.Win32.SafeHandles.SafeBCryptAlgorithmHandle, Microsoft.Win32.SafeHandles.SafeBCryptHashHandle ByRef, IntPtr, Int32, System.ReadOnlySpan`1<Byte>, Int32, BCryptCreateHashFlags)
       mov       esi,eax
       test      esi,esi
       je        short M07_L06
       mov       rcx,[rsp+50]
       cmp       [rcx],ecx
       call      qword ptr [7FF9F7C1E500]; System.Runtime.InteropServices.SafeHandle.Dispose()
       mov       ecx,esi
       call      qword ptr [7FF9F8294C00]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M07_L06:
       lea       rcx,[rbx+10]
       mov       rdx,[rsp+50]
       test      rcx,rcx
       jne       short M07_L07
       call      qword ptr [7FF9F8294C18]
       int       3
M07_L07:
       call      00007FFA576F58B0
       mov       rsi,rax
       test      rsi,rsi
       je        near ptr M07_L00
       mov       rcx,rsi
       mov       edx,1
       mov       rax,[7FF9F8251C48]
       call      qword ptr [rax+30]
       mov       rcx,rsi
       call      qword ptr [7FF9F7AF7AF8]; System.GC.SuppressFinalize(System.Object)
       jmp       near ptr M07_L00
; Total bytes of code 243
```
```assembly
; DotNetTips.Spargine.Core.Security.PasswordHasher.HashPasswordSHA(System.String, System.Security.Cryptography.HashAlgorithm)
; 		var hash = algorithm.ComputeHash(Encoding.UTF8.GetBytes(password));
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return Convert.ToBase64String(hash);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rbx
       sub       rsp,20
       mov       rax,rcx
       mov       rbx,rdx
       mov       rcx,1DE30000220
       mov       rcx,[rcx]
       test      rax,rax
       je        short M08_L00
       cmp       dword ptr [rax+8],20
       jle       short M08_L02
M08_L00:
       mov       rdx,rax
       call      qword ptr [7FF9F7B5E1A8]; System.Text.Encoding.GetBytes(System.String)
M08_L01:
       mov       rcx,rbx
       mov       rdx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF9F81D7FC0]; System.Security.Cryptography.HashAlgorithm.ComputeHash(Byte[])
       mov       rcx,rax
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FF9F7FE4000]; System.Convert.ToBase64String(Byte[])
M08_L02:
       mov       rdx,rax
       call      qword ptr [7FF9F80DE9D0]; System.Text.UTF8Encoding+UTF8EncodingSealed.GetBytesForSmallInput(System.String)
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
       call      qword ptr [7FF9F7AFC780]; System.Runtime.InteropServices.SafeHandle.InternalRelease(Boolean)
       mov       rcx,[rdi]
       test      dword ptr [rcx],100000
       je        short M09_L00
       mov       rcx,rdi
       call      00007FFA576F8C20
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
       jmp       qword ptr [7FF9F7AF7AF8]; System.GC.SuppressFinalize(System.Object)
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
       call      qword ptr [7FF9F82962E0]
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
       call      qword ptr [7FFA7029BD38]
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
       call      qword ptr [7FFA7029A8D0]; Precode of System.Runtime.InteropServices.SafeHandle.Dispose()
       mov       ecx,ebx
       call      qword ptr [7FFA7029BDC8]
       mov       rcx,rax
       call      qword ptr [7FFA70298348]; CORINFO_HELP_THROW
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
       call      qword ptr [7FFA7029BCF0]
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
       call      qword ptr [7FFA7029BDC8]
       mov       rcx,rax
       call      qword ptr [7FFA70298348]; CORINFO_HELP_THROW
       int       3
M11_L01:
       call      qword ptr [7FFA70298BC0]
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA7029A660]
       mov       rcx,rbx
       call      qword ptr [7FFA70298348]; CORINFO_HELP_THROW
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
       call      qword ptr [7FF9F81D7BE8]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.ValueTuple`2[[System.__Canon, System.Private.CoreLib],[Interop+BCrypt+BCryptOpenAlgorithmProviderFlags, System.Security.Cryptography]], System.Private.CoreLib],[System.ValueTuple`2[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]], System.Private.CoreLib]].TryAddInternal(Tables<System.ValueTuple`2<System.__Canon,BCryptOpenAlgorithmProviderFlags>,System.ValueTuple`2<System.__Canon,Int32>>, System.ValueTuple`2<System.__Canon,BCryptOpenAlgorithmProviderFlags>, System.Nullable`1<Int32>, System.ValueTuple`2<System.__Canon,Int32>, Boolean, Boolean, System.ValueTuple`2<System.__Canon,Int32> ByRef)
       nop
       add       rsp,80
       pop       rbp
       ret
; Total bytes of code 150
```
```assembly
; System.Collections.Concurrent.ConcurrentDictionary`2[[System.ValueTuple`2[[System.__Canon, System.Private.CoreLib],[Interop+BCrypt+BCryptOpenAlgorithmProviderFlags, System.Security.Cryptography]], System.Private.CoreLib],[System.ValueTuple`2[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]], System.Private.CoreLib]].GetHashCode(System.Collections.Generic.IEqualityComparer`1<System.ValueTuple`2<System.__Canon,BCryptOpenAlgorithmProviderFlags>>, System.ValueTuple`2<System.__Canon,BCryptOpenAlgorithmProviderFlags>)
       push      rbp
       sub       rsp,70
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-30],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       qword ptr [rbp+18],0
       je        short M13_L02
       mov       rax,[rbp+10]
       mov       rax,[rax]
       mov       [rbp-38],rax
       mov       rax,[rbp-38]
       mov       rax,[rax+30]
       mov       rax,[rax]
       mov       rax,[rax+58]
       mov       [rbp-40],rax
       cmp       qword ptr [rbp-40],0
       je        short M13_L00
       mov       rax,[rbp-40]
       mov       [rbp-20],rax
       jmp       short M13_L01
M13_L00:
       mov       rcx,[rbp-38]
       mov       rdx,7FF9F82423E0
       call      qword ptr [7FF9F7AFC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       [rbp-20],rax
M13_L01:
       mov       rax,[rbp+20]
       vmovdqu   xmm0,xmmword ptr [rax]
       vmovdqu   xmmword ptr [rbp-30],xmm0
       lea       rdx,[rbp-30]
       mov       r11,[rbp-20]
       mov       rcx,[rbp+18]
       mov       rax,[rbp-20]
       call      qword ptr [rax]
       nop
       add       rsp,70
       pop       rbp
       ret
M13_L02:
       mov       rax,[rbp+10]
       mov       rax,[rax]
       mov       [rbp-48],rax
       mov       rax,[rbp-48]
       mov       rax,[rax+30]
       mov       rax,[rax]
       mov       rax,[rax+40]
       mov       [rbp-50],rax
       cmp       qword ptr [rbp-50],0
       je        short M13_L03
       mov       rax,[rbp-50]
       mov       [rbp-10],rax
       jmp       short M13_L04
M13_L03:
       mov       rcx,[rbp-48]
       mov       rdx,7FF9F82416F0
       call      qword ptr [7FF9F7AFC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       [rbp-10],rax
M13_L04:
       mov       rax,[rbp-10]
       mov       [rbp-18],rax
       mov       rcx,[rbp+20]
       mov       rax,[rbp-18]
       call      rax
       nop
       add       rsp,70
       pop       rbp
       ret
; Total bytes of code 244
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
M14_L00:
       mov       r14d,[rbx+10]
       test      sil,sil
       je        short M14_L01
       test      r14b,2
       jne       near ptr M14_L09
M14_L01:
       mov       r15d,r14d
       and       r15d,0FFFFFFFC
       je        near ptr M14_L11
       mov       ecx,r14d
       and       ecx,0FFFFFFFD
       cmp       ecx,4
       jne       near ptr M14_L10
       cmp       byte ptr [rbx+14],0
       je        near ptr M14_L10
       mov       rcx,offset MT_Microsoft.Win32.SafeHandles.SafeBCryptHashHandle
       cmp       [rbx],rcx
       jne       near ptr M14_L16
       cmp       qword ptr [rbx+8],0
       sete      r13b
       movzx     r13d,r13b
M14_L02:
       test      r13d,r13d
       sete      cl
       movzx     ecx,cl
M14_L03:
       lea       edx,[r14-4]
       cmp       r15d,4
       jne       short M14_L04
       or        edx,1
M14_L04:
       test      sil,sil
       je        short M14_L05
       or        edx,2
M14_L05:
       lea       r8,[rbx+10]
       mov       eax,r14d
       lock cmpxchg [r8],edx
       cmp       eax,r14d
       jne       near ptr M14_L00
       test      ecx,ecx
       je        short M14_L09
       call      00007FFA57736260
       mov       esi,eax
       mov       rcx,offset MT_Microsoft.Win32.SafeHandles.SafeBCryptHashHandle
       cmp       [rbx],rcx
       jne       near ptr M14_L18
       mov       rcx,[rbx+8]
       mov       rax,7FF9F81891A0
       mov       [rbp-60],rax
       lea       rax,[M14_L06]
       mov       [rbp-50],rax
       lea       rax,[rbp-70]
       mov       [rdi+8],rax
       mov       byte ptr [rdi+4],0
       mov       rax,7FFA91FC3C80
       call      rax
M14_L06:
       mov       byte ptr [rdi+4],1
       cmp       dword ptr [7FFA57A4F778],0
       je        short M14_L07
       call      qword ptr [7FFA57A3D608]; CORINFO_HELP_STOP_FOR_GC
M14_L07:
       mov       rcx,[rbp-68]
       mov       [rdi+8],rcx
M14_L08:
       mov       ecx,esi
       call      00007FFA57736280
M14_L09:
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
M14_L10:
       xor       ecx,ecx
       jmp       near ptr M14_L03
M14_L11:
       mov       rcx,rbx
       call      qword ptr [7FF9F7AFC9A8]; System.Object.GetType()
       mov       rcx,[rax+10]
       test      rcx,rcx
       je        short M14_L14
       mov       rbx,[rcx]
       test      rbx,rbx
       je        short M14_L14
M14_L12:
       mov       rsi,[rbx+20]
       test      rsi,rsi
       je        short M14_L15
M14_L13:
       mov       rcx,offset MT_System.ObjectDisposedException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FF9F8295398]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M14_L14:
       mov       rcx,rax
       call      qword ptr [7FF9F7AF7C48]; System.RuntimeType.InitializeCache()
       mov       rbx,rax
       jmp       short M14_L12
M14_L15:
       mov       rcx,[rbx+8]
       call      qword ptr [7FF9F7C94A68]; System.RuntimeType.IsFullNameRoundtripCompatible(System.RuntimeType)
       test      eax,eax
       je        short M14_L17
       lea       rdx,[rbx+20]
       mov       rcx,rbx
       mov       r8d,3
       call      qword ptr [7FF9F7C94A80]; System.RuntimeType+RuntimeTypeCache.ConstructName(System.String ByRef, System.TypeNameFormatFlags)
       mov       rsi,rax
       jmp       short M14_L13
M14_L16:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       r13d,eax
       jmp       near ptr M14_L02
M14_L17:
       xor       esi,esi
       jmp       short M14_L13
M14_L18:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       jmp       near ptr M14_L08
; Total bytes of code 509
```
```assembly
; System.GC.SuppressFinalize(System.Object)
       sub       rsp,28
       test      rcx,rcx
       je        short M15_L01
       mov       rax,[rcx]
       test      dword ptr [rax],100000
       je        short M15_L00
       add       rsp,28
       jmp       near ptr 00007FFA576F8C20
M15_L00:
       add       rsp,28
       ret
M15_L01:
       mov       ecx,707
       mov       rdx,7FF9F7A34000
       call      qword ptr [7FF9F7D77738]
       mov       rcx,rax
       call      qword ptr [7FF9F82946A8]
       int       3
; Total bytes of code 65
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Security.PasswordHasherBenchmark.HashPasswordSHA3256()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       lea       rbp,[rsp+0C0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-60],ymm4
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
       jne       near ptr M00_L11
M00_L00:
       mov       r9d,r8d
       neg       r9d
       test      r8d,r8d
       jg        near ptr M00_L12
       test      r9d,r9d
       jl        near ptr M00_L12
       lea       r8d,[r9+rcx]
       cmp       r8d,[rdx+8]
       ja        near ptr M00_L12
       movzx     edx,word ptr [r10]
       mov       r8d,r9d
       imul      r8,rdx
       add       r8,rax
       mov       ecx,ecx
       imul      rdx,rcx
       test      dword ptr [r10],1000000
       jne       near ptr M00_L13
       mov       rcx,r8
       call      qword ptr [7FF9F7B057E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
M00_L01:
       mov       r8,[rbx+10]
       mov       r9d,[r8+8]
       mov       ecx,r9d
       test      ecx,ecx
       jle       short M00_L03
M00_L02:
       dec       ecx
       cmp       ecx,r9d
       jae       near ptr M00_L19
       mov       byte ptr [r8+rcx+10],0
       test      ecx,ecx
       jg        short M00_L02
M00_L03:
       xor       r8d,r8d
       mov       [rbx+1C],r8d
       mov       byte ptr [rbx+24],0
       mov       dword ptr [rbx+20],100
       mov       r8,249D1C00220
       mov       rsi,[r8]
       mov       r8,28A66CD06A4
       mov       [rbp-40],r8
       mov       rdi,[rbp-40]
       lea       r8,[rbp-48]
       lea       r9,[rbp-50]
       mov       rcx,rdi
       mov       edx,40
       call      qword ptr [7FF9F7B0FAB0]; System.Text.Unicode.Utf16Utility.GetPointerToFirstInvalidChar(Char*, Int32, Int64 ByRef, Int32 ByRef)
       sub       rax,rdi
       mov       r9,rax
       shr       r9,3F
       add       r9,rax
       sar       r9,1
       movsxd    r14,r9d
       add       r14,[rbp-48]
       cmp       r14,7FFFFFFF
       ja        near ptr M00_L15
       cmp       r9d,40
       jne       near ptr M00_L14
M00_L04:
       xor       edx,edx
       mov       [rbp-40],rdx
       movsxd    rdx,r14d
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rdi,rax
       mov       r14d,[rdi+8]
       test      r14d,r14d
       jl        near ptr M00_L16
       mov       rcx,28A66CD06A4
       mov       [rbp-58],rcx
       mov       r15,[rbp-58]
       mov       [rbp-60],rdi
       test      r14d,r14d
       je        near ptr M00_L17
       lea       r13,[rdi+10]
M00_L05:
       mov       r12d,r14d
       lea       rcx,[rbp-68]
       mov       [rsp+20],rcx
       lea       rcx,[rbp-70]
       mov       [rsp+28],rcx
       mov       rcx,r15
       mov       edx,40
       mov       r8,r13
       mov       r9d,r12d
       call      qword ptr [7FF9F7B0FAE0]; System.Text.Unicode.Utf8Utility.TranscodeToUtf8(Char*, Int32, Byte*, Int32, Char* ByRef, Byte* ByRef)
       mov       rcx,[rbp-68]
       sub       rcx,r15
       mov       rdx,rcx
       shr       rdx,3F
       add       rcx,rdx
       sar       rcx,1
       mov       edx,[rbp-70]
       sub       edx,r13d
       cmp       ecx,40
       jne       near ptr M00_L18
M00_L06:
       xor       ecx,ecx
       mov       [rbp-58],rcx
       mov       [rbp-60],rcx
       mov       rdx,rdi
       mov       r9d,r14d
       mov       rcx,rbx
       xor       r8d,r8d
       call      qword ptr [7FF9F81E75D0]; Org.BouncyCastle.Crypto.Digests.KeccakDigest.Absorb(Byte[], Int32, Int32)
       mov       esi,[rbx+20]
       sar       esi,3
       mov       rcx,249D1C020C0
       mov       rcx,[rcx]
       mov       edx,esi
       call      qword ptr [7FF9F8249E08]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Rent(Int32)
       mov       [rbp-78],rax
       mov       ecx,[rbx+1C]
       test      cl,7
       jne       short M00_L07
       cmp       byte ptr [rbx+24],0
       jne       near ptr M00_L08
       mov       rdx,[rbx+10]
       mov       r8d,ecx
       sar       r8d,3
       cmp       r8d,[rdx+8]
       jae       near ptr M00_L09
       mov       byte ptr [rdx+r8+10],2
       add       ecx,2
       mov       [rbx+1C],ecx
       mov       rcx,rbx
       mov       rdx,[rbp-78]
       xor       r8d,r8d
       call      qword ptr [7FF9F8248630]; Org.BouncyCastle.Crypto.Digests.KeccakDigest.DoFinal(Byte[], Int32)
       mov       rcx,[rbp-78]
       mov       r8d,esi
       xor       edx,edx
       xor       r9d,r9d
       call      qword ptr [7FF9F81EFEB8]; System.Convert.ToBase64String(Byte[], Int32, Int32, System.Base64FormattingOptions)
       mov       rbx,rax
       jmp       near ptr M00_L10
M00_L07:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,28F39
       mov       rdx,7FF9F8247C80
       call      qword ptr [7FF9F7D87738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F7F55D28]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L08:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,28F89
       mov       rdx,7FF9F8247C80
       call      qword ptr [7FF9F7D87738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F7F55D28]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       int       3
M00_L10:
       mov       rcx,249D1C020E0
       mov       rcx,[rcx]
       mov       rdx,[rbp-78]
       mov       r8d,1
       call      qword ptr [7FF9F8249E10]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Return(Byte[], Boolean)
       mov       rax,rbx
       add       rsp,88
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L11:
       mov       r9d,[r10+4]
       add       r9d,0FFFFFFE8
       shr       r9d,3
       movsxd    r8,r9d
       mov       r8d,[rax+r8*4]
       shl       r9d,3
       movsxd    r9,r9d
       add       rax,r9
       jmp       near ptr M00_L00
M00_L12:
       call      qword ptr [7FF9F837CEB8]
       int       3
M00_L13:
       shr       rdx,3
       mov       rcx,r8
       call      qword ptr [7FF9F837CED0]
       jmp       near ptr M00_L01
M00_L14:
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8d,40
       call      qword ptr [7FF9F837D380]
       add       r14d,eax
       jns       near ptr M00_L04
M00_L15:
       call      qword ptr [7FF9F837D398]
       int       3
M00_L16:
       mov       ecx,0B
       xor       edx,edx
       call      qword ptr [7FF9F8165908]
       int       3
M00_L17:
       xor       r13d,r13d
       jmp       near ptr M00_L05
M00_L18:
       mov       [rsp+20],r12d
       mov       [rsp+28],ecx
       mov       [rsp+30],edx
       mov       dword ptr [rsp+38],1
       mov       rcx,rsi
       mov       rdx,r15
       mov       r8d,40
       mov       r9,r13
       call      qword ptr [7FF9F837D4E8]
       jmp       near ptr M00_L06
M00_L19:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       sub       rsp,48
       mov       rcx,249D1C020E0
       mov       rcx,[rcx]
       mov       rdx,[rcx]
       mov       rdx,[rbp-78]
       mov       r8d,1
       call      qword ptr [7FF9F8249E10]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Return(Byte[], Boolean)
       add       rsp,48
       ret
; Total bytes of code 1086
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
       xor       edx,edx
       mov       [rcx],edx
       mov       [rbx-4],edx
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
       jmp       qword ptr [7FF9F837CDC8]
; Total bytes of code 231
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
       jae       near ptr M02_L09
       cmp       r10,10
       jae       near ptr M02_L07
M02_L00:
       cmp       r10,4
       jb        short M02_L02
M02_L01:
       mov       r11d,[rax]
       mov       ebx,[rax+4]
       mov       esi,r11d
       or        esi,ebx
       test      esi,0FF80FF80
       jne       near ptr M02_L12
       add       rax,8
       add       r10,0FFFFFFFFFFFFFFFC
       cmp       r10,4
       jae       short M02_L01
M02_L02:
       test      r10b,2
       je        short M02_L03
       mov       r11d,[rax]
       test      r11d,0FF80FF80
       jne       near ptr M02_L13
       add       rax,4
M02_L03:
       test      r10b,1
       je        short M02_L05
       cmp       word ptr [rax],7F
       ja        short M02_L05
M02_L04:
       add       rax,2
M02_L05:
       sub       rax,rcx
       shr       rax,1
       mov       r10d,eax
       lea       rcx,[rcx+r10*2]
       sub       edx,eax
       jne       near ptr M02_L15
       xor       edx,edx
       mov       [r8],rdx
       mov       [r9],edx
M02_L06:
       mov       rax,rcx
       vzeroupper
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L07:
       vbroadcastss xmm0,dword ptr [7FF9F84802A0]
       vptest    xmm0,xmmword ptr [rax]
       jne       near ptr M02_L00
       lea       rbx,[r11+r10*2-10]
       add       r11,10
       mov       rax,r11
       and       rax,0FFFFFFFFFFFFFFF0
       vpand     xmm1,xmm0,[rax]
       vptest    xmm1,xmm1
       jne       short M02_L11
M02_L08:
       add       rax,10
       cmp       rax,rbx
       ja        short M02_L11
       vpand     xmm1,xmm0,[rax]
       vptest    xmm1,xmm1
       jne       short M02_L11
       jmp       short M02_L08
M02_L09:
       vbroadcastss ymm0,dword ptr [7FF9F84802A0]
       vptest    ymm0,ymmword ptr [rax]
       jne       near ptr M02_L00
       lea       rbx,[r11+r10*2-20]
       lea       rax,[r11+20]
       and       rax,0FFFFFFFFFFFFFFE0
       vpand     ymm1,ymm0,[rax]
       vptest    ymm1,ymm1
       jne       short M02_L11
M02_L10:
       add       rax,20
       cmp       rax,rbx
       ja        short M02_L11
       vpand     ymm1,ymm0,[rax]
       vptest    ymm1,ymm1
       je        short M02_L10
M02_L11:
       mov       r11,rax
       sub       r11,rcx
       shr       r11,1
       sub       r10,r11
       jmp       near ptr M02_L00
M02_L12:
       test      r11d,0FF80FF80
       je        short M02_L14
M02_L13:
       test      r11d,0FF80
       jne       near ptr M02_L05
       jmp       near ptr M02_L04
M02_L14:
       mov       r11d,ebx
       add       rax,4
       jmp       short M02_L13
M02_L15:
       xor       eax,eax
       xor       r10d,r10d
       mov       r11d,edx
       lea       r11,[rcx+r11*2]
       cmp       edx,8
       jl        near ptr M02_L20
       vbroadcastss xmm0,dword ptr [7FF9F84802A4]
       lea       rdx,[r11-10]
M02_L16:
       vmovups   xmm1,[rcx]
       add       rcx,10
       vpaddusw  xmm2,xmm1,xmm0
       vpminuw   xmm3,xmm1,[7FF9F84802B0]
       vpor      xmm2,xmm2,xmm3
       vpmovmskb ebx,xmm2
       popcnt    ebx,ebx
       vpaddw    xmm2,xmm1,[7FF9F84802C0]
       vpcmpgtw  xmm2,xmm0,xmm2
       vpmovmskb esi,xmm2
M02_L17:
       cmp       esi,0FFFF
       je        short M02_L19
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
       jne       near ptr M02_L22
       cmp       esi,0FFFF
       jbe       short M02_L18
       movzx     esi,si
       add       rbx,0FFFFFFFFFFFFFFFE
       add       rcx,0FFFFFFFFFFFFFFFE
M02_L18:
       popcnt    esi,esi
       sub       r10d,esi
       sub       rax,rsi
       sub       rax,rsi
       mov       esi,0FFFF
       jmp       short M02_L17
M02_L19:
       add       rax,rbx
       cmp       rcx,rdx
       jbe       near ptr M02_L16
M02_L20:
       cmp       rcx,r11
       jae       short M02_L23
       movzx     edx,word ptr [rcx]
       cmp       edx,7F
       jbe       short M02_L21
       lea       ebx,[rdx+1F800]
       shr       ebx,10
       add       rax,rbx
       add       edx,0FFFF2800
       cmp       edx,7FF
       ja        short M02_L21
       add       rax,0FFFFFFFFFFFFFFFE
       mov       rdx,r11
       sub       rdx,rcx
       cmp       rdx,4
       jb        short M02_L23
       mov       edx,[rcx]
       add       edx,23FF2800
       test      edx,0FC00FC00
       jne       short M02_L23
       dec       r10d
       add       rax,2
       add       rcx,2
M02_L21:
       add       rcx,2
       jmp       short M02_L20
M02_L22:
       add       rcx,0FFFFFFFFFFFFFFF0
       jmp       short M02_L20
M02_L23:
       mov       [r8],rax
       mov       [r9],r10d
       jmp       near ptr M02_L06
; Total bytes of code 628
```
```assembly
; System.Text.Unicode.Utf8Utility.TranscodeToUtf8(Char*, Int32, Byte*, Int32, Char* ByRef, Byte* ByRef)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       mov       r10,[rsp+48]
       mov       r11,[rsp+50]
       cmp       edx,r9d
       mov       eax,r9d
       cmovle    eax,edx
       xor       ebx,ebx
       cmp       rax,20
       jb        near ptr M03_L03
       mov       rsi,[rcx]
       mov       rdi,0FF80FF80FF80FF80
       test      rdi,rsi
       mov       rdi,rsi
       jne       near ptr M03_L19
       cmp       rax,40
       jb        near ptr M03_L10
       mov       rbx,rcx
       vmovups   ymm0,[rbx]
       vbroadcastss ymm1,dword ptr [7FF9F7BE4450]
       vptest    ymm1,ymm0
       jne       near ptr M03_L08
       mov       rsi,r8
       vpackuswb ymm0,ymm0,ymm0
       vpermq    ymm0,ymm0,0D8
       vmovups   [rsi],xmm0
       mov       edi,10
       test      r8b,10
       jne       short M03_L00
       vmovups   ymm0,[rbx+20]
       vptest    ymm1,ymm0
       jne       short M03_L02
       vpackuswb ymm0,ymm0,ymm0
       vpermq    ymm0,ymm0,0D8
       vmovups   [rsi+10],xmm0
M03_L00:
       mov       rdi,r8
       and       rdi,1F
       neg       rdi
       add       rdi,20
       lea       rbp,[rax-20]
       vmovups   ymm0,[rbx+rdi*2]
       vmovups   ymm2,[rbx+rdi*2+20]
       vpor      ymm3,ymm0,ymm2
       vptest    ymm3,ymm1
       jne       near ptr M03_L09
M03_L01:
       vpackuswb ymm0,ymm0,ymm2
       vpermq    ymm2,ymm0,0D8
       vmovups   [rsi+rdi],ymm2
       add       rdi,20
       cmp       rdi,rbp
       ja        short M03_L02
       vmovups   ymm0,[rbx+rdi*2]
       vmovups   ymm2,[rbx+rdi*2+20]
       vpor      ymm3,ymm0,ymm2
       vptest    ymm3,ymm1
       jne       near ptr M03_L09
       jmp       short M03_L01
M03_L02:
       mov       rbx,rdi
M03_L03:
       sub       rax,rbx
       cmp       rax,4
       jb        short M03_L05
       lea       rsi,[rbx+rax-4]
       mov       rdi,[rcx+rbx*2]
       mov       rbp,0FF80FF80FF80FF80
       test      rbp,rdi
       jne       near ptr M03_L19
M03_L04:
       vmovq     xmm0,rdi
       vpackuswb xmm0,xmm0,xmm0
       vmovd     dword ptr [r8+rbx],xmm0
       add       rbx,4
       cmp       rbx,rsi
       ja        short M03_L05
       mov       rdi,[rcx+rbx*2]
       mov       rbp,0FF80FF80FF80FF80
       test      rbp,rdi
       jne       near ptr M03_L19
       jmp       short M03_L04
M03_L05:
       test      al,2
       jne       near ptr M03_L17
M03_L06:
       test      al,1
       jne       near ptr M03_L18
M03_L07:
       lea       rcx,[rcx+rbx*2]
       add       r8,rbx
       cmp       ebx,edx
       jne       near ptr M03_L22
       mov       [r10],rcx
       mov       [r11],r8
       xor       eax,eax
       vzeroupper
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M03_L08:
       xor       ebx,ebx
       jmp       near ptr M03_L03
M03_L09:
       vptest    ymm1,ymm0
       jne       near ptr M03_L02
       vpackuswb ymm0,ymm0,ymm0
       vpermq    ymm0,ymm0,0D8
       vmovups   [rsi+rdi],xmm0
       add       rdi,10
       jmp       near ptr M03_L02
M03_L10:
       mov       rbx,rcx
       vmovups   xmm0,[rbx]
       vbroadcastss xmm1,dword ptr [7FF9F7BE4450]
       vptest    xmm1,xmm0
       je        short M03_L11
       xor       ebx,ebx
       jmp       near ptr M03_L16
M03_L11:
       mov       rsi,r8
       vpackuswb xmm0,xmm0,xmm0
       vmovsd    qword ptr [rsi],xmm0
       mov       edi,8
       test      r8b,8
       jne       short M03_L12
       vmovups   xmm0,[rbx+10]
       vptest    xmm1,xmm0
       jne       short M03_L14
       vpackuswb xmm0,xmm0,xmm0
       vmovsd    qword ptr [rsi+8],xmm0
M03_L12:
       mov       rdi,r8
       and       rdi,0F
       neg       rdi
       add       rdi,10
       lea       rbp,[rax-10]
M03_L13:
       vmovups   xmm0,[rbx+rdi*2]
       vmovups   xmm2,[rbx+rdi*2+10]
       vpor      xmm3,xmm0,xmm2
       vptest    xmm3,xmm1
       jne       short M03_L15
       vpackuswb xmm0,xmm0,xmm2
       vmovups   [rsi+rdi],xmm0
       add       rdi,10
       cmp       rdi,rbp
       jbe       short M03_L13
M03_L14:
       mov       rbx,rdi
       jmp       short M03_L16
M03_L15:
       vptest    xmm1,xmm0
       jne       short M03_L14
       vpackuswb xmm0,xmm0,xmm0
       vmovsd    qword ptr [rsi+rdi],xmm0
       add       rdi,8
       jmp       short M03_L14
M03_L16:
       jmp       near ptr M03_L03
M03_L17:
       mov       esi,[rcx+rbx*2]
       test      esi,0FF80FF80
       jne       short M03_L20
       lea       rdi,[r8+rbx]
       mov       [rdi],sil
       shr       esi,10
       mov       [rdi+1],sil
       add       rbx,2
       jmp       near ptr M03_L06
M03_L18:
       movzx     esi,word ptr [rcx+rbx*2]
       cmp       esi,7F
       ja        near ptr M03_L07
       jmp       short M03_L21
M03_L19:
       mov       eax,edi
       test      eax,0FF80FF80
       jne       short M03_L24
       lea       rsi,[r8+rbx]
       mov       [rsi],al
       shr       eax,10
       mov       [rsi+1],al
       shr       rdi,20
       mov       eax,edi
       add       rbx,2
       mov       esi,eax
M03_L20:
       test      esi,0FF80
       jne       near ptr M03_L07
M03_L21:
       mov       [r8+rbx],sil
       inc       rbx
       jmp       near ptr M03_L07
M03_L22:
       sub       edx,ebx
       sub       r9d,ebx
       cmp       edx,2
       jl        near ptr M03_L60
       mov       eax,edx
       lea       rax,[rcx+rax*2-4]
M03_L23:
       mov       ebx,[rcx]
       jmp       near ptr M03_L49
M03_L24:
       mov       esi,eax
       jmp       short M03_L20
M03_L25:
       cmp       r9d,2
       jl        near ptr M03_L61
       mov       esi,ebx
       shr       esi,8
       or        esi,ebx
       mov       [r8],si
       add       rcx,4
       add       r8,2
       add       r9d,0FFFFFFFE
       mov       rbx,rax
       sub       rbx,rcx
       mov       rsi,rbx
       shr       rsi,3F
       add       rbx,rsi
       sar       rbx,1
       add       ebx,2
       movsxd    rsi,r9d
       cmp       rbx,rsi
       jle       short M03_L26
       jmp       short M03_L27
M03_L26:
       mov       rsi,rbx
M03_L27:
       mov       ebx,esi
       shr       ebx,3
       xor       edi,edi
       jmp       short M03_L29
M03_L28:
       vmovups   xmm0,[rcx]
       vptest    xmm0,xmmword ptr [7FF9F7BE4460]
       jne       short M03_L30
       vpackuswb xmm0,xmm0,xmm0
       vmovq     qword ptr [r8],xmm0
       add       rcx,10
       add       r8,8
       inc       edi
M03_L29:
       cmp       edi,ebx
       jb        short M03_L28
       lea       ebx,[rdi*8]
       sub       r9d,ebx
       test      sil,4
       je        near ptr M03_L57
       mov       rbx,[rcx]
       mov       rsi,0FF80FF80FF80FF80
       test      rsi,rbx
       jne       short M03_L31
       jmp       near ptr M03_L52
M03_L30:
       shl       edi,3
       sub       r9d,edi
       vmovq     rbx,xmm0
       mov       rsi,0FF80FF80FF80FF80
       test      rsi,rbx
       jne       short M03_L31
       vpackuswb xmm1,xmm0,xmm0
       vmovd     dword ptr [r8],xmm1
       add       rcx,8
       add       r8,4
       add       r9d,0FFFFFFFC
       vpextrq   rbx,xmm0,1
M03_L31:
       mov       esi,ebx
       test      esi,0FF80FF80
       jne       short M03_L32
       mov       edi,esi
       shr       edi,8
       or        edi,esi
       mov       [r8],di
       add       rcx,4
       add       r8,2
       add       r9d,0FFFFFFFE
       shr       rbx,20
       mov       esi,ebx
M03_L32:
       test      esi,0FF80
       jne       short M03_L33
       test      r9d,r9d
       je        near ptr M03_L68
       jmp       short M03_L34
M03_L33:
       test      esi,0F800
       jne       near ptr M03_L50
       jmp       near ptr M03_L38
M03_L34:
       mov       [r8],sil
       add       rcx,2
       inc       r8
       dec       r9d
       cmp       rcx,rax
       ja        near ptr M03_L59
       mov       esi,[rcx]
       jmp       short M03_L33
M03_L35:
       cmp       r9d,2
       jl        near ptr M03_L68
       jmp       short M03_L39
M03_L36:
       cmp       r9d,4
       jl        short M03_L37
       mov       ebx,esi
       shr       ebx,6
       and       ebx,1F001F
       shl       esi,8
       and       esi,3F003F00
       add       ebx,esi
       add       ebx,80C080C0
       mov       [r8],ebx
       add       rcx,4
       add       r8,4
       add       r9d,0FFFFFFFC
       cmp       rcx,rax
       ja        near ptr M03_L59
       mov       esi,[rcx]
       lea       ebx,[rsi-80]
       movzx     ebx,bx
       cmp       ebx,780
       jl        short M03_L38
       mov       ebx,esi
       jmp       near ptr M03_L49
M03_L37:
       mov       ebx,esi
       jmp       near ptr M03_L61
M03_L38:
       lea       ebx,[rsi-800000]
       cmp       ebx,77FFFFF
       jbe       short M03_L36
       jmp       short M03_L35
M03_L39:
       lea       ebx,[rsi*4]
       and       ebx,1F00
       mov       edi,esi
       and       edi,3F
       lea       ebx,[rbx+rdi+0C080]
       movbe     [r8],bx
       cmp       esi,800000
       jb        short M03_L40
       add       rcx,2
       add       r8,2
       add       r9d,0FFFFFFFE
       cmp       rcx,rax
       ja        near ptr M03_L59
       jmp       short M03_L41
M03_L40:
       cmp       r9d,3
       jl        near ptr M03_L58
       jmp       near ptr M03_L53
M03_L41:
       mov       esi,[rcx]
       jmp       near ptr M03_L50
M03_L42:
       test      esi,0F8000000
       jne       short M03_L44
       jmp       short M03_L45
M03_L43:
       lea       ebx,[rsi+23FF2800]
       test      ebx,0FC00FC00
       je        near ptr M03_L55
       jmp       near ptr M03_L54
M03_L44:
       lea       ebx,[rsi+28000000]
       cmp       ebx,8000000
       jb        short M03_L45
       cmp       r9d,6
       jge       short M03_L46
M03_L45:
       cmp       r9d,3
       jl        near ptr M03_L68
       jmp       short M03_L47
M03_L46:
       lea       ebx,[rsi*4]
       and       ebx,3F00
       mov       edi,esi
       and       edi,3F
       shl       edi,10
       or        ebx,edi
       mov       edi,esi
       shr       edi,4
       and       edi,0F000000
       mov       ebp,esi
       shr       ebp,0C
       and       ebp,0F
       or        edi,ebp
       add       ebx,edi
       add       ebx,0E08080E0
       mov       [r8],ebx
       mov       ebx,esi
       shr       ebx,16
       and       ebx,3F
       shr       esi,8
       and       esi,3F00
       add       ebx,esi
       add       ebx,8080
       mov       [r8+4],bx
       add       rcx,4
       add       r8,6
       add       r9d,0FFFFFFFA
       cmp       rcx,rax
       ja        near ptr M03_L59
       mov       esi,[rcx]
       test      esi,0F800
       jne       near ptr M03_L50
       mov       ebx,esi
       jmp       short M03_L49
M03_L47:
       lea       ebx,[rsi*4]
       and       ebx,3F00
       movzx     edi,si
       shr       edi,0C
       add       ebx,edi
       add       ebx,80E0
       mov       [r8],bx
       mov       ebx,esi
       and       ebx,3F
       or        ebx,0FFFFFF80
       mov       [r8+2],bl
       add       rcx,2
       add       r8,3
       add       r9d,0FFFFFFFD
       cmp       esi,800000
       jb        short M03_L48
       cmp       rcx,rax
       ja        near ptr M03_L59
       jmp       short M03_L51
M03_L48:
       test      r9d,r9d
       je        near ptr M03_L68
       shr       esi,10
       mov       [r8],sil
       add       rcx,2
       inc       r8
       dec       r9d
       cmp       rcx,rax
       ja        near ptr M03_L59
       mov       esi,[rcx]
       test      esi,0F800
       jne       short M03_L50
       mov       ebx,esi
M03_L49:
       test      ebx,0FF80FF80
       je        near ptr M03_L25
       mov       esi,ebx
       jmp       near ptr M03_L32
M03_L50:
       lea       ebx,[rsi-0D800]
       test      ebx,0F800
       je        near ptr M03_L43
       jmp       near ptr M03_L42
M03_L51:
       mov       esi,[rcx]
       jmp       near ptr M03_L32
M03_L52:
       vmovq     xmm0,rbx
       vpackuswb xmm0,xmm0,xmm0
       vmovd     dword ptr [r8],xmm0
       add       rcx,8
       jmp       short M03_L56
M03_L53:
       shr       esi,10
       mov       [r8+2],sil
       add       rcx,4
       add       r8,3
       add       r9d,0FFFFFFFD
       jmp       short M03_L57
M03_L54:
       mov       eax,3
       jmp       near ptr M03_L69
M03_L55:
       cmp       r9d,4
       jl        near ptr M03_L68
       add       esi,40
       mov       ebx,esi
       and       ebx,3
       shl       ebx,14
       or        ebx,808080F0
       mov       edi,esi
       and       edi,3F0700
       bswap     edi
       rol       edi,10
       or        ebx,edi
       mov       edi,esi
       shr       edi,6
       and       edi,0F0000
       or        ebx,edi
       and       esi,0FC
       shl       esi,6
       or        ebx,esi
       mov       [r8],ebx
       add       rcx,4
M03_L56:
       add       r8,4
       add       r9d,0FFFFFFFC
M03_L57:
       cmp       rcx,rax
       jbe       near ptr M03_L23
       jmp       short M03_L59
M03_L58:
       add       rcx,2
       add       r8,2
       jmp       near ptr M03_L68
M03_L59:
       sub       rax,rcx
       mov       rdx,rax
       shr       rdx,3F
       add       rdx,rax
       sar       rdx,1
       add       edx,2
M03_L60:
       test      edx,edx
       je        near ptr M03_L67
       movzx     ebx,word ptr [rcx]
       jmp       short M03_L62
M03_L61:
       movzx     ebx,bx
M03_L62:
       cmp       ebx,7F
       ja        short M03_L63
       test      r9d,r9d
       je        near ptr M03_L68
       mov       [r8],bl
       add       rcx,2
       inc       r8
       jmp       near ptr M03_L66
M03_L63:
       cmp       ebx,800
       jae       short M03_L64
       cmp       r9d,2
       jl        near ptr M03_L68
       mov       r9d,ebx
       and       r9d,3F
       or        r9d,0FFFFFF80
       mov       [r8+1],r9b
       shr       ebx,6
       or        ebx,0FFFFFFC0
       mov       [r8],bl
       add       rcx,2
       add       r8,2
       jmp       short M03_L66
M03_L64:
       lea       eax,[rbx-0D800]
       cmp       eax,7FF
       jbe       short M03_L65
       cmp       r9d,3
       jl        short M03_L68
       mov       eax,ebx
       and       eax,3F
       or        eax,0FFFFFF80
       mov       [r8+2],al
       mov       eax,ebx
       shr       eax,6
       and       eax,3F
       or        eax,0FFFFFF80
       mov       [r8+1],al
       mov       eax,ebx
       shr       eax,0C
       or        eax,0FFFFFFE0
       mov       [r8],al
       add       rcx,2
       add       r8,3
       jmp       short M03_L66
M03_L65:
       cmp       ebx,0DBFF
       ja        near ptr M03_L54
       mov       eax,2
       jmp       short M03_L69
M03_L66:
       cmp       edx,1
       jg        short M03_L68
M03_L67:
       xor       eax,eax
       jmp       short M03_L69
M03_L68:
       mov       eax,1
M03_L69:
       mov       [r10],rcx
       mov       [r11],r8
       vzeroupper
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 1983
```
```assembly
; Org.BouncyCastle.Crypto.Digests.KeccakDigest.Absorb(Byte[], Int32, Int32)
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       rdi,rdx
       mov       ebp,r8d
       mov       esi,r9d
       mov       r9d,[rbx+1C]
       test      r9b,7
       jne       near ptr M04_L06
       cmp       byte ptr [rbx+24],0
       jne       near ptr M04_L07
       sar       r9d,3
       mov       r14d,[rbx+18]
       sar       r14d,3
       mov       r15d,r14d
       sub       r15d,r9d
       cmp       esi,r15d
       jge       near ptr M04_L16
       mov       r8,[rbx+10]
       test      rdi,rdi
       je        near ptr M04_L15
       test      r8,r8
       je        near ptr M04_L15
       mov       rcx,[rdi]
       cmp       rcx,[r8]
       jne       near ptr M04_L15
       cmp       dword ptr [rcx+4],18
       jne       near ptr M04_L15
       mov       edx,esi
       or        edx,ebp
       or        edx,r9d
       jl        near ptr M04_L15
       lea       edx,[rsi+rbp]
       cmp       edx,[rdi+8]
       ja        near ptr M04_L15
       lea       edx,[r9+rsi]
       cmp       edx,[r8+8]
       ja        near ptr M04_L15
       movzx     edx,word ptr [rcx]
       mov       eax,esi
       imul      rax,rdx
       mov       r10d,ebp
       imul      r10,rdx
       lea       r10,[rdi+r10+10]
       mov       r9d,r9d
       imul      rdx,r9
       lea       r9,[r8+rdx+10]
       test      dword ptr [rcx],1000000
       jne       near ptr M04_L08
       mov       rcx,r9
       mov       rdx,r10
       mov       r8,rax
       mov       r11,rcx
       sub       r11,rdx
       cmp       r11,r8
       jb        near ptr M04_L13
       mov       r11,rdx
       sub       r11,rcx
       cmp       r11,r8
       jb        near ptr M04_L13
       lea       r11,[rdx+r8]
       lea       rdi,[rcx+r8]
       cmp       r8,10
       jbe       short M04_L04
       cmp       r8,40
       ja        near ptr M04_L10
M04_L00:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       jbe       short M04_L01
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M04_L01
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
M04_L01:
       vmovups   xmm0,[r11-10]
       vmovups   [rdi-10],xmm0
M04_L02:
       shl       esi,3
       add       [rbx+1C],esi
M04_L03:
       vzeroupper
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M04_L04:
       test      al,18
       je        short M04_L05
       mov       rax,[r10]
       mov       [r9],rax
       mov       r10,[r11-8]
       mov       [rdi-8],r10
       jmp       short M04_L02
M04_L05:
       test      al,4
       je        near ptr M04_L09
       mov       eax,[r10]
       mov       [r9],eax
       mov       r10d,[r11-4]
       mov       [rdi-4],r10d
       jmp       short M04_L02
M04_L06:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,28F39
       mov       rdx,7FF9F8247C80
       call      qword ptr [7FF9F7D87738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F7F55D28]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M04_L07:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,28F89
       mov       rdx,7FF9F8247C80
       call      qword ptr [7FF9F7D87738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F7F55D28]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M04_L08:
       mov       rcx,r9
       mov       rdx,r10
       mov       r8,rax
       call      qword ptr [7FF9F7B057A0]; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M04_L02
M04_L09:
       test      rax,rax
       je        near ptr M04_L02
       movzx     r10d,byte ptr [r10]
       mov       [r9],r10b
       test      al,2
       je        near ptr M04_L02
       movsx     r9,word ptr [r11-2]
       mov       [rdi-2],r9w
       jmp       near ptr M04_L02
M04_L10:
       cmp       r8,800
       ja        near ptr M04_L14
       cmp       r8,100
       jb        short M04_L11
       mov       rdx,r9
       and       rdx,3F
       mov       r8,rdx
       neg       r8
       add       r8,40
       vmovdqu   ymm0,ymmword ptr [r10]
       vmovdqu   ymmword ptr [r9],ymm0
       vmovdqu   ymm0,ymmword ptr [r10+20]
       vmovdqu   ymmword ptr [r9+20],ymm0
       lea       rdx,[r10+r8]
       lea       rcx,[r9+r8]
       sub       rax,r8
       mov       r8,rax
M04_L11:
       mov       r10,r8
       shr       r10,6
M04_L12:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r10
       jne       short M04_L12
       and       r8,3F
       cmp       r8,10
       ja        near ptr M04_L00
       jmp       near ptr M04_L01
M04_L13:
       cmp       r9,r10
       jne       short M04_L14
       cmp       [r10],r10b
       jmp       near ptr M04_L02
M04_L14:
       cmp       [r9],r9b
       cmp       [r10],r10b
       mov       rcx,r9
       mov       rdx,r10
       mov       r8,rax
       call      qword ptr [7FF9F7B066E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M04_L02
M04_L15:
       mov       [rsp+20],esi
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rdi
       mov       edx,ebp
       call      qword ptr [7FF9F837CE70]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M04_L02
M04_L16:
       xor       r13d,r13d
       test      r9d,r9d
       jle       short M04_L18
       mov       [rsp+20],r15d
       mov       r8,[rbx+10]
       mov       rcx,rdi
       mov       edx,ebp
       call      qword ptr [7FF9F80EC858]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       r13d,r15d
       mov       rdx,[rbx+10]
       mov       rcx,rbx
       xor       r8d,r8d
       call      qword ptr [7FF9F81E75E8]
       jmp       short M04_L18
M04_L17:
       lea       r8d,[rbp+r13]
       mov       rcx,rbx
       mov       rdx,rdi
       call      qword ptr [7FF9F81E75E8]
       add       r13d,r14d
M04_L18:
       mov       r15d,esi
       sub       r15d,r13d
       cmp       r15d,r14d
       jge       short M04_L17
       mov       [rsp+20],r15d
       lea       edx,[rbp+r13]
       mov       r8,[rbx+10]
       mov       rcx,rdi
       xor       r9d,r9d
       call      qword ptr [7FF9F80EC858]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       shl       r15d,3
       mov       [rbx+1C],r15d
       jmp       near ptr M04_L03
; Total bytes of code 882
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
       mov       rcx,249D1C00C90
       mov       rdi,[rcx]
       lea       ecx,[rbx-1]
       or        ecx,0F
       xor       ebp,ebp
       lzcnt     ebp,ecx
       xor       ebp,1F
       add       ebp,0FFFFFFFD
       mov       rcx,gs:[58]
       mov       rcx,[rcx+38]
       cmp       dword ptr [rcx+238],9
       jle       short M05_L02
       mov       rcx,[rcx+240]
       mov       rax,[rcx+48]
       test      rax,rax
       je        short M05_L02
M05_L00:
       mov       rcx,[rax+10]
       test      rcx,rcx
       je        short M05_L04
       mov       eax,[rcx+8]
       cmp       eax,ebp
       jbe       short M05_L04
       mov       eax,ebp
       shl       rax,4
       mov       r14,[rcx+rax+10]
       test      r14,r14
       je        short M05_L04
       xor       edx,edx
       mov       [rcx+rax+10],rdx
       cmp       byte ptr [rdi+9D],0
       jne       short M05_L03
M05_L01:
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
M05_L02:
       mov       ecx,9
       call      qword ptr [7FF9F837D338]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       short M05_L00
M05_L03:
       mov       rcx,r14
       call      qword ptr [7FF9F7FFC918]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       ebx,eax
       mov       r15d,[r14+8]
       cmp       [rsi],sil
       mov       rcx,rsi
       call      qword ptr [7FF9F7FFC918]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       [rsp+20],ebp
       mov       edx,ebx
       mov       r8d,r15d
       mov       rcx,rdi
       call      qword ptr [7FF9F837D638]
       jmp       short M05_L01
M05_L04:
       mov       rcx,[rsi+10]
       cmp       [rcx+8],ebp
       jbe       near ptr M05_L16
       mov       eax,ebp
       mov       rcx,[rcx+rax*8+10]
       test      rcx,rcx
       je        near ptr M05_L15
       mov       r14,[rcx+8]
       mov       rcx,offset MT_System.Threading.ProcessorIdCache
       call      System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       cmp       byte ptr [7FF9F7A4B1CC],0
       je        short M05_L05
       call      qword ptr [7FF9F837D650]
       mov       ebx,eax
       jmp       short M05_L07
M05_L05:
       mov       ecx,0A
       call      qword ptr [7FF9F837D668]
       mov       ebx,[rax+10]
       mov       ecx,0A
       call      qword ptr [7FF9F837D668]
       lea       ecx,[rbx-1]
       mov       [rax+10],ecx
       movzx     eax,bx
       test      eax,eax
       jne       short M05_L06
       call      qword ptr [7FF9F837D680]
       mov       ebx,eax
       jmp       short M05_L07
M05_L06:
       sar       ebx,10
M05_L07:
       mov       rcx,offset MT_System.Buffers.SharedArrayPoolStatics
       call      System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       eax,ebx
       xor       edx,edx
       div       dword ptr [7FF9F7A4B1C0]
       mov       ebx,edx
       xor       r15d,r15d
       jmp       short M05_L11
M05_L08:
       cmp       ebx,[r14+8]
       jae       near ptr M05_L21
       mov       ecx,ebx
       mov       r13,[r14+rcx*8+10]
       cmp       [r13],r13b
       xor       r12d,r12d
       mov       rcx,r13
       call      qword ptr [7FF9F80ED5D8]; System.Threading.Monitor.Enter(System.Object)
       mov       rcx,[r13+8]
       mov       eax,[r13+10]
       dec       eax
       cmp       [rcx+8],eax
       jbe       short M05_L09
       mov       edx,eax
       mov       r12,[rcx+rdx*8+10]
       mov       edx,eax
       xor       r8d,r8d
       mov       [rcx+rdx*8+10],r8
       mov       [r13+10],eax
M05_L09:
       mov       rcx,r13
       call      qword ptr [7FF9F7B06820]; System.Threading.Monitor.Exit(System.Object)
       test      r12,r12
       jne       short M05_L12
       inc       ebx
       cmp       [r14+8],ebx
       jne       short M05_L10
       xor       ebx,ebx
M05_L10:
       inc       r15d
M05_L11:
       cmp       [r14+8],r15d
       jg        short M05_L08
       jmp       short M05_L13
M05_L12:
       mov       r14,r12
       jmp       short M05_L14
M05_L13:
       xor       r14d,r14d
M05_L14:
       test      r14,r14
       je        short M05_L15
       cmp       byte ptr [rdi+9D],0
       je        near ptr M05_L01
       mov       rcx,r14
       call      qword ptr [7FF9F7FFC918]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       ebx,eax
       mov       r15d,[r14+8]
       mov       rcx,rsi
       call      qword ptr [7FF9F7FFC918]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       [rsp+20],ebp
       mov       edx,ebx
       mov       r8d,r15d
       mov       rcx,rdi
       call      qword ptr [7FF9F837D638]
       jmp       near ptr M05_L01
M05_L15:
       mov       ecx,10
       shlx      ebx,ecx,ebp
       jmp       short M05_L18
M05_L16:
       test      ebx,ebx
       jne       short M05_L17
       mov       rax,28A66CC62A0
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
M05_L17:
       mov       ecx,ebx
       mov       rdx,28A66CC6F28
       call      qword ptr [7FF9F7D8D770]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
M05_L18:
       cmp       ebx,800
       jge       short M05_L19
       movsxd    rdx,ebx
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
       jmp       short M05_L20
M05_L19:
       mov       ecx,ebx
       xor       edx,edx
       call      qword ptr [7FF9F837D5F0]
       mov       r14,rax
M05_L20:
       cmp       byte ptr [rdi+9D],0
       je        near ptr M05_L01
       cmp       [r14],r14b
       mov       rcx,r14
       call      qword ptr [7FF9F7FFC918]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       ebx,eax
       mov       r15d,[r14+8]
       mov       rcx,rsi
       call      qword ptr [7FF9F7FFC918]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       edx,ebx
       mov       r8d,r15d
       mov       rcx,rdi
       call      qword ptr [7FF9F837D638]
       mov       r15d,[r14+8]
       mov       rcx,rsi
       call      qword ptr [7FF9F7FFC918]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
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
       call      qword ptr [7FF9F837D698]
       jmp       near ptr M05_L01
M05_L21:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 796
```
```assembly
; Org.BouncyCastle.Crypto.Digests.KeccakDigest.DoFinal(Byte[], Int32)
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       movsxd    r9,dword ptr [rbx+20]
       mov       rcx,rbx
       call      qword ptr [7FF9F81EFD38]; Org.BouncyCastle.Crypto.Digests.KeccakDigest.Squeeze(Byte[], Int32, Int64)
       mov       rdx,offset MT_Org.BouncyCastle.Crypto.Digests.Sha3Digest
       cmp       [rbx],rdx
       jne       short M06_L00
       mov       edx,[rbx+20]
       mov       rcx,rbx
       call      qword ptr [7FF9F81E7558]; Org.BouncyCastle.Crypto.Digests.KeccakDigest.Init(Int32)
       mov       eax,[rbx+20]
       sar       eax,3
       add       rsp,20
       pop       rbx
       ret
M06_L00:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax+28]
; Total bytes of code 92
```
```assembly
; System.Convert.ToBase64String(Byte[], Int32, Int32, System.Base64FormattingOptions)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+30],ymm4
       mov       [rsp+50],rax
       mov       esi,edx
       mov       ebx,r8d
       mov       edi,r9d
       test      rcx,rcx
       je        near ptr M07_L12
       test      ebx,ebx
       jl        near ptr M07_L13
       test      esi,esi
       jl        near ptr M07_L14
       mov       eax,[rcx+8]
       mov       ebp,eax
       sub       ebp,ebx
       cmp       esi,ebp
       jl        short M07_L00
       cmp       esi,ebp
       jg        short M07_L01
M07_L00:
       mov       edx,esi
       mov       r8d,ebx
       add       r8,rdx
       mov       eax,eax
       cmp       r8,rax
       ja        near ptr M07_L15
       lea       rbp,[rcx+rdx+10]
       cmp       edi,1
       ja        near ptr M07_L16
       test      ebx,ebx
       jne       short M07_L02
       mov       rax,28A66CC0008
       jmp       near ptr M07_L10
M07_L01:
       mov       ecx,1149
       mov       rdx,7FF9F7A44000
       call      qword ptr [7FF9F7D87738]
       mov       r8,rax
       mov       edx,ebp
       mov       ecx,esi
       call      qword ptr [7FF9F837D6E0]
       int       3
M07_L02:
       cmp       edi,1
       sete      dil
       movzx     edi,dil
       lea       ecx,[rbx+2]
       mov       eax,0AAAAAAAB
       mov       edx,ecx
       imul      rax,rdx
       shr       rax,21
       shl       eax,2
       je        short M07_L04
       test      edi,edi
       je        short M07_L03
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
M07_L03:
       test      eax,eax
       jl        near ptr M07_L17
       jmp       short M07_L05
M07_L04:
       xor       eax,eax
M07_L05:
       movsxd    rdx,eax
       mov       rcx,offset MT_System.String
       call      00007FFA57738D20
       mov       rsi,rax
       test      edi,edi
       jne       short M07_L06
       cmp       ebx,10
       jge       short M07_L11
M07_L06:
       mov       [rsp+50],rbp
       mov       rdx,rbp
       test      rsi,rsi
       je        short M07_L07
       lea       rcx,[rsi+0C]
       mov       [rsp+48],rcx
       mov       rcx,[rsp+48]
       jmp       short M07_L08
M07_L07:
       xor       ecx,ecx
M07_L08:
       mov       [rsp+20],edi
       mov       r9d,ebx
       xor       r8d,r8d
       call      qword ptr [7FF9F837D788]
       xor       ecx,ecx
       mov       [rsp+48],rcx
       mov       [rsp+50],rcx
M07_L09:
       mov       rax,rsi
M07_L10:
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M07_L11:
       lea       rcx,[rsi+0C]
       mov       r8d,[rsi+8]
       mov       edx,r8d
       mov       [rsp+38],rbp
       mov       [rsp+40],ebx
       mov       [rsp+28],rcx
       mov       [rsp+30],edx
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+28]
       call      qword ptr [7FF9F7FF4150]; System.Convert.ToBase64CharsLargeNoLineBreaks(System.ReadOnlySpan`1<Byte>, System.Span`1<Char>, Int32)
       jmp       short M07_L09
M07_L12:
       mov       ecx,1139
       mov       rdx,7FF9F7A44000
       call      qword ptr [7FF9F7D87738]
       mov       rcx,rax
       call      qword ptr [7FF9F837C8D0]
       int       3
M07_L13:
       mov       ecx,0B3
       mov       rdx,7FF9F7A44000
       call      qword ptr [7FF9F7D87738]
       mov       rdx,rax
       mov       ecx,ebx
       call      qword ptr [7FF9F837D5D8]
       int       3
M07_L14:
       mov       ecx,1149
       mov       rdx,7FF9F7A44000
       call      qword ptr [7FF9F7D87738]
       mov       rdx,rax
       mov       ecx,esi
       call      qword ptr [7FF9F837D5D8]
       int       3
M07_L15:
       call      qword ptr [7FF9F7CA7138]
       int       3
M07_L16:
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9F837D7A0]
       mov       rsi,rax
       mov       [rbx+8],edi
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9F837D7B8]
       mov       rbx,rax
       mov       ecx,1157
       mov       rdx,7FF9F7A44000
       call      qword ptr [7FF9F7D87738]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FF9F7F55DD0]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M07_L17:
       mov       rcx,offset MT_System.OutOfMemoryException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       call      qword ptr [7FF9F837D770]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 649
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
       je        near ptr M08_L07
       mov       ebp,[rbx+8]
       lea       ecx,[rbp-1]
       or        ecx,0F
       xor       r14d,r14d
       lzcnt     r14d,ecx
       xor       r14d,1F
       add       r14d,0FFFFFFFD
       mov       rcx,gs:[58]
       mov       rcx,[rcx+38]
       cmp       dword ptr [rcx+238],9
       jle       near ptr M08_L05
       mov       rcx,[rcx+240]
       mov       rax,[rcx+48]
       test      rax,rax
       je        near ptr M08_L05
M08_L00:
       mov       r15,[rax+10]
       test      r15,r15
       je        near ptr M08_L06
M08_L01:
       xor       r13d,r13d
       mov       r12d,1
       cmp       [r15+8],r14d
       jbe       short M08_L03
       mov       r13d,1
       test      sil,sil
       je        short M08_L02
       mov       rcx,[rbx]
       movzx     edx,word ptr [rcx]
       mov       eax,[rbx+8]
       imul      rdx,rax
       lea       rax,[rbx+10]
       test      dword ptr [rcx],1000000
       jne       near ptr M08_L08
       mov       rcx,rax
       call      qword ptr [7FF9F7B057E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
M08_L02:
       mov       ecx,10
       shlx      ecx,ecx,r14d
       cmp       ebp,ecx
       jne       near ptr M08_L09
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
       jne       near ptr M08_L10
M08_L03:
       mov       rcx,249D1C00C90
       mov       rsi,[rcx]
       cmp       byte ptr [rsi+9D],0
       jne       near ptr M08_L25
M08_L04:
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
M08_L05:
       mov       ecx,9
       call      qword ptr [7FF9F837D338]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M08_L00
M08_L06:
       mov       rcx,rdi
       call      qword ptr [7FF9F81EFED0]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
       mov       r15,rax
       jmp       near ptr M08_L01
M08_L07:
       mov       ecx,2
       call      qword ptr [7FF9F7D8C1C8]
       int       3
M08_L08:
       shr       rdx,3
       mov       rcx,rax
       call      qword ptr [7FF9F837CED0]
       jmp       near ptr M08_L02
M08_L09:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       call      qword ptr [7FF9F837DE00]
       mov       rbx,rax
       mov       ecx,29B
       mov       rdx,7FF9F7A44000
       call      qword ptr [7FF9F7D87738]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rbp
       call      qword ptr [7FF9F7F55DD0]
       mov       rcx,rbp
       call      CORINFO_HELP_THROW
       int       3
M08_L10:
       mov       rcx,[rdi+10]
       cmp       r14d,[rcx+8]
       jae       near ptr M08_L28
       mov       edx,r14d
       mov       rax,[rcx+rdx*8+10]
       test      rax,rax
       jne       short M08_L11
       mov       rcx,rdi
       mov       edx,r14d
       call      qword ptr [7FF9F837DE18]
M08_L11:
       mov       r12,[rax+8]
       mov       rcx,offset MT_System.Threading.ProcessorIdCache
       call      System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       cmp       byte ptr [7FF9F7A4B1CC],0
       je        short M08_L12
       call      qword ptr [7FF9F837D650]
       mov       esi,eax
       jmp       short M08_L14
M08_L12:
       mov       ecx,0A
       call      qword ptr [7FF9F837D668]
       mov       esi,[rax+10]
       mov       ecx,0A
       call      qword ptr [7FF9F837D668]
       lea       ecx,[rsi-1]
       mov       [rax+10],ecx
       movzx     eax,si
       test      eax,eax
       jne       short M08_L13
       call      qword ptr [7FF9F837D680]
       mov       esi,eax
       jmp       short M08_L14
M08_L13:
       sar       esi,10
M08_L14:
       mov       rcx,offset MT_System.Buffers.SharedArrayPoolStatics
       call      System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       eax,esi
       xor       edx,edx
       div       dword ptr [7FF9F7A4B1C0]
       mov       esi,edx
       xor       eax,eax
       jmp       near ptr M08_L21
M08_L15:
       cmp       esi,[r12+8]
       jae       near ptr M08_L28
       mov       ecx,esi
       mov       rdx,[r12+rcx*8+10]
       mov       [rsp+30],rdx
       cmp       [rdx],dl
       xor       r8d,r8d
       mov       [rsp+3C],r8d
       mov       rcx,rdx
       call      qword ptr [7FF9F80ED5D8]; System.Threading.Monitor.Enter(System.Object)
       mov       rax,[rsp+30]
       mov       rcx,[rax+8]
       mov       r8d,[rax+10]
       mov       [rsp+38],r8d
       cmp       [rcx+8],r8d
       jbe       short M08_L17
       test      r8d,r8d
       jne       short M08_L18
       xor       edx,edx
       mov       [rax+14],edx
M08_L16:
       mov       edx,r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rsp+38]
       inc       ecx
       mov       rax,[rsp+30]
       mov       [rax+10],ecx
       mov       dword ptr [rsp+3C],1
M08_L17:
       mov       rcx,rax
       call      qword ptr [7FF9F7B06820]; System.Threading.Monitor.Exit(System.Object)
       cmp       dword ptr [rsp+3C],0
       je        short M08_L19
       jmp       short M08_L22
M08_L18:
       jmp       short M08_L16
M08_L19:
       inc       esi
       cmp       [r12+8],esi
       jne       short M08_L20
       xor       esi,esi
M08_L20:
       mov       eax,[rsp+40]
       inc       eax
M08_L21:
       mov       [rsp+40],eax
       cmp       [r12+8],eax
       jg        near ptr M08_L15
       jmp       short M08_L23
M08_L22:
       mov       r12d,1
       jmp       short M08_L24
M08_L23:
       xor       r12d,r12d
M08_L24:
       jmp       near ptr M08_L03
M08_L25:
       test      ebp,ebp
       je        near ptr M08_L04
       mov       rcx,rbx
       call      qword ptr [7FF9F7FFC918]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r15d,eax
       mov       [rsp+44],ebp
       cmp       [rdi],dil
       mov       rcx,rdi
       call      qword ptr [7FF9F7FFC918]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,rsi
       mov       r8d,r15d
       mov       r9d,[rsp+44]
       mov       edx,3
       call      qword ptr [7FF9F837DE30]
       test      r12d,r13d
       jne       near ptr M08_L04
       mov       rcx,rbx
       call      qword ptr [7FF9F7FFC918]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       ebx,eax
       mov       rcx,rdi
       call      qword ptr [7FF9F7FFC918]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       test      r13d,r13d
       jne       short M08_L26
       mov       ecx,0FFFFFFFF
       mov       edx,1
       jmp       short M08_L27
M08_L26:
       mov       ecx,r14d
       xor       edx,edx
M08_L27:
       mov       [rsp+20],ecx
       mov       [rsp+28],edx
       mov       rcx,rsi
       mov       edx,ebx
       mov       r8d,ebp
       call      qword ptr [7FF9F837DE48]
       jmp       near ptr M08_L04
M08_L28:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 913
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Security.PasswordHasherBenchmark.HashPasswordSHA3384()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       lea       rbp,[rsp+0C0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-60],ymm4
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
       jne       near ptr M00_L11
M00_L00:
       mov       r9d,r8d
       neg       r9d
       test      r8d,r8d
       jg        near ptr M00_L12
       test      r9d,r9d
       jl        near ptr M00_L12
       lea       r8d,[r9+rcx]
       cmp       r8d,[rdx+8]
       ja        near ptr M00_L12
       movzx     edx,word ptr [r10]
       mov       r8d,r9d
       imul      r8,rdx
       add       r8,rax
       mov       ecx,ecx
       imul      rdx,rcx
       test      dword ptr [r10],1000000
       jne       near ptr M00_L13
       mov       rcx,r8
       call      qword ptr [7FF9F7AE57E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
M00_L01:
       mov       r8,[rbx+10]
       mov       r9d,[r8+8]
       mov       ecx,r9d
       test      ecx,ecx
       jle       short M00_L03
M00_L02:
       dec       ecx
       cmp       ecx,r9d
       jae       near ptr M00_L19
       mov       byte ptr [r8+rcx+10],0
       test      ecx,ecx
       jg        short M00_L02
M00_L03:
       xor       r8d,r8d
       mov       [rbx+1C],r8d
       mov       byte ptr [rbx+24],0
       mov       dword ptr [rbx+20],180
       mov       r8,27658000220
       mov       rsi,[r8]
       mov       r8,2B6ED06067C
       mov       [rbp-40],r8
       mov       rdi,[rbp-40]
       lea       r8,[rbp-48]
       lea       r9,[rbp-50]
       mov       rcx,rdi
       mov       edx,40
       call      qword ptr [7FF9F7AEFAB0]; System.Text.Unicode.Utf16Utility.GetPointerToFirstInvalidChar(Char*, Int32, Int64 ByRef, Int32 ByRef)
       sub       rax,rdi
       mov       r9,rax
       shr       r9,3F
       add       r9,rax
       sar       r9,1
       movsxd    r14,r9d
       add       r14,[rbp-48]
       cmp       r14,7FFFFFFF
       ja        near ptr M00_L15
       cmp       r9d,40
       jne       near ptr M00_L14
M00_L04:
       xor       edx,edx
       mov       [rbp-40],rdx
       movsxd    rdx,r14d
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rdi,rax
       mov       r14d,[rdi+8]
       test      r14d,r14d
       jl        near ptr M00_L16
       mov       rcx,2B6ED06067C
       mov       [rbp-58],rcx
       mov       r15,[rbp-58]
       mov       [rbp-60],rdi
       test      r14d,r14d
       je        near ptr M00_L17
       lea       r13,[rdi+10]
M00_L05:
       mov       r12d,r14d
       lea       rcx,[rbp-68]
       mov       [rsp+20],rcx
       lea       rcx,[rbp-70]
       mov       [rsp+28],rcx
       mov       rcx,r15
       mov       edx,40
       mov       r8,r13
       mov       r9d,r12d
       call      qword ptr [7FF9F7AEFAE0]; System.Text.Unicode.Utf8Utility.TranscodeToUtf8(Char*, Int32, Byte*, Int32, Char* ByRef, Byte* ByRef)
       mov       rcx,[rbp-68]
       sub       rcx,r15
       mov       rdx,rcx
       shr       rdx,3F
       add       rcx,rdx
       sar       rcx,1
       mov       edx,[rbp-70]
       sub       edx,r13d
       cmp       ecx,40
       jne       near ptr M00_L18
M00_L06:
       xor       ecx,ecx
       mov       [rbp-58],rcx
       mov       [rbp-60],rcx
       mov       rdx,rdi
       mov       r9d,r14d
       mov       rcx,rbx
       xor       r8d,r8d
       call      qword ptr [7FF9F81C73D8]; Org.BouncyCastle.Crypto.Digests.KeccakDigest.Absorb(Byte[], Int32, Int32)
       mov       esi,[rbx+20]
       sar       esi,3
       mov       rcx,2766E0000C0
       mov       rcx,[rcx]
       mov       edx,esi
       call      qword ptr [7FF9F8225A90]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Rent(Int32)
       mov       [rbp-78],rax
       mov       ecx,[rbx+1C]
       test      cl,7
       jne       short M00_L07
       cmp       byte ptr [rbx+24],0
       jne       near ptr M00_L08
       mov       rdx,[rbx+10]
       mov       r8d,ecx
       sar       r8d,3
       cmp       r8d,[rdx+8]
       jae       near ptr M00_L09
       mov       byte ptr [rdx+r8+10],2
       add       ecx,2
       mov       [rbx+1C],ecx
       mov       rcx,rbx
       mov       rdx,[rbp-78]
       xor       r8d,r8d
       call      qword ptr [7FF9F82242B8]; Org.BouncyCastle.Crypto.Digests.KeccakDigest.DoFinal(Byte[], Int32)
       mov       rcx,[rbp-78]
       mov       r8d,esi
       xor       edx,edx
       xor       r9d,r9d
       call      qword ptr [7FF9F81CFCD8]; System.Convert.ToBase64String(Byte[], Int32, Int32, System.Base64FormattingOptions)
       mov       rbx,rax
       jmp       near ptr M00_L10
M00_L07:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,28F39
       mov       rdx,7FF9F8223908
       call      qword ptr [7FF9F7D67738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F7F35D28]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L08:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,28F89
       mov       rdx,7FF9F8223908
       call      qword ptr [7FF9F7D67738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F7F35D28]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       int       3
M00_L10:
       mov       rcx,2766E0000E0
       mov       rcx,[rcx]
       mov       rdx,[rbp-78]
       mov       r8d,1
       call      qword ptr [7FF9F8225A98]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Return(Byte[], Boolean)
       mov       rax,rbx
       add       rsp,88
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L11:
       mov       r9d,[r10+4]
       add       r9d,0FFFFFFE8
       shr       r9d,3
       movsxd    r8,r9d
       mov       r8d,[rax+r8*4]
       shl       r9d,3
       movsxd    r9,r9d
       add       rax,r9
       jmp       near ptr M00_L00
M00_L12:
       call      qword ptr [7FF9F835CD38]
       int       3
M00_L13:
       shr       rdx,3
       mov       rcx,r8
       call      qword ptr [7FF9F835CD50]
       jmp       near ptr M00_L01
M00_L14:
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8d,40
       call      qword ptr [7FF9F835D248]
       add       r14d,eax
       jns       near ptr M00_L04
M00_L15:
       call      qword ptr [7FF9F835D260]
       int       3
M00_L16:
       mov       ecx,0B
       xor       edx,edx
       call      qword ptr [7FF9F8145908]
       int       3
M00_L17:
       xor       r13d,r13d
       jmp       near ptr M00_L05
M00_L18:
       mov       [rsp+20],r12d
       mov       [rsp+28],ecx
       mov       [rsp+30],edx
       mov       dword ptr [rsp+38],1
       mov       rcx,rsi
       mov       rdx,r15
       mov       r8d,40
       mov       r9,r13
       call      qword ptr [7FF9F835D3B0]
       jmp       near ptr M00_L06
M00_L19:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       sub       rsp,48
       mov       rcx,2766E0000E0
       mov       rcx,[rcx]
       mov       rdx,[rcx]
       mov       rdx,[rbp-78]
       mov       r8d,1
       call      qword ptr [7FF9F8225A98]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Return(Byte[], Boolean)
       add       rsp,48
       ret
; Total bytes of code 1086
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
       xor       edx,edx
       mov       [rcx],edx
       mov       [rbx-4],edx
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
       jmp       qword ptr [7FF9F835CB58]
; Total bytes of code 231
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
       jae       near ptr M02_L09
       cmp       r10,10
       jae       near ptr M02_L07
M02_L00:
       cmp       r10,4
       jb        short M02_L02
M02_L01:
       mov       r11d,[rax]
       mov       ebx,[rax+4]
       mov       esi,r11d
       or        esi,ebx
       test      esi,0FF80FF80
       jne       near ptr M02_L12
       add       rax,8
       add       r10,0FFFFFFFFFFFFFFFC
       cmp       r10,4
       jae       short M02_L01
M02_L02:
       test      r10b,2
       je        short M02_L03
       mov       r11d,[rax]
       test      r11d,0FF80FF80
       jne       near ptr M02_L13
       add       rax,4
M02_L03:
       test      r10b,1
       je        short M02_L05
       cmp       word ptr [rax],7F
       ja        short M02_L05
M02_L04:
       add       rax,2
M02_L05:
       sub       rax,rcx
       shr       rax,1
       mov       r10d,eax
       lea       rcx,[rcx+r10*2]
       sub       edx,eax
       jne       near ptr M02_L15
       xor       edx,edx
       mov       [r8],rdx
       mov       [r9],edx
M02_L06:
       mov       rax,rcx
       vzeroupper
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L07:
       vbroadcastss xmm0,dword ptr [7FF9F84602A0]
       vptest    xmm0,xmmword ptr [rax]
       jne       near ptr M02_L00
       lea       rbx,[r11+r10*2-10]
       add       r11,10
       mov       rax,r11
       and       rax,0FFFFFFFFFFFFFFF0
       vpand     xmm1,xmm0,[rax]
       vptest    xmm1,xmm1
       jne       short M02_L11
M02_L08:
       add       rax,10
       cmp       rax,rbx
       ja        short M02_L11
       vpand     xmm1,xmm0,[rax]
       vptest    xmm1,xmm1
       jne       short M02_L11
       jmp       short M02_L08
M02_L09:
       vbroadcastss ymm0,dword ptr [7FF9F84602A0]
       vptest    ymm0,ymmword ptr [rax]
       jne       near ptr M02_L00
       lea       rbx,[r11+r10*2-20]
       lea       rax,[r11+20]
       and       rax,0FFFFFFFFFFFFFFE0
       vpand     ymm1,ymm0,[rax]
       vptest    ymm1,ymm1
       jne       short M02_L11
M02_L10:
       add       rax,20
       cmp       rax,rbx
       ja        short M02_L11
       vpand     ymm1,ymm0,[rax]
       vptest    ymm1,ymm1
       je        short M02_L10
M02_L11:
       mov       r11,rax
       sub       r11,rcx
       shr       r11,1
       sub       r10,r11
       jmp       near ptr M02_L00
M02_L12:
       test      r11d,0FF80FF80
       je        short M02_L14
M02_L13:
       test      r11d,0FF80
       jne       near ptr M02_L05
       jmp       near ptr M02_L04
M02_L14:
       mov       r11d,ebx
       add       rax,4
       jmp       short M02_L13
M02_L15:
       xor       eax,eax
       xor       r10d,r10d
       mov       r11d,edx
       lea       r11,[rcx+r11*2]
       cmp       edx,8
       jl        near ptr M02_L20
       vbroadcastss xmm0,dword ptr [7FF9F84602A4]
       lea       rdx,[r11-10]
M02_L16:
       vmovups   xmm1,[rcx]
       add       rcx,10
       vpaddusw  xmm2,xmm1,xmm0
       vpminuw   xmm3,xmm1,[7FF9F84602B0]
       vpor      xmm2,xmm2,xmm3
       vpmovmskb ebx,xmm2
       popcnt    ebx,ebx
       vpaddw    xmm2,xmm1,[7FF9F84602C0]
       vpcmpgtw  xmm2,xmm0,xmm2
       vpmovmskb esi,xmm2
M02_L17:
       cmp       esi,0FFFF
       je        short M02_L19
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
       jne       near ptr M02_L22
       cmp       esi,0FFFF
       jbe       short M02_L18
       movzx     esi,si
       add       rbx,0FFFFFFFFFFFFFFFE
       add       rcx,0FFFFFFFFFFFFFFFE
M02_L18:
       popcnt    esi,esi
       sub       r10d,esi
       sub       rax,rsi
       sub       rax,rsi
       mov       esi,0FFFF
       jmp       short M02_L17
M02_L19:
       add       rax,rbx
       cmp       rcx,rdx
       jbe       near ptr M02_L16
M02_L20:
       cmp       rcx,r11
       jae       short M02_L23
       movzx     edx,word ptr [rcx]
       cmp       edx,7F
       jbe       short M02_L21
       lea       ebx,[rdx+1F800]
       shr       ebx,10
       add       rax,rbx
       add       edx,0FFFF2800
       cmp       edx,7FF
       ja        short M02_L21
       add       rax,0FFFFFFFFFFFFFFFE
       mov       rdx,r11
       sub       rdx,rcx
       cmp       rdx,4
       jb        short M02_L23
       mov       edx,[rcx]
       add       edx,23FF2800
       test      edx,0FC00FC00
       jne       short M02_L23
       dec       r10d
       add       rax,2
       add       rcx,2
M02_L21:
       add       rcx,2
       jmp       short M02_L20
M02_L22:
       add       rcx,0FFFFFFFFFFFFFFF0
       jmp       short M02_L20
M02_L23:
       mov       [r8],rax
       mov       [r9],r10d
       jmp       near ptr M02_L06
; Total bytes of code 628
```
```assembly
; System.Text.Unicode.Utf8Utility.TranscodeToUtf8(Char*, Int32, Byte*, Int32, Char* ByRef, Byte* ByRef)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       mov       r10,[rsp+48]
       mov       r11,[rsp+50]
       cmp       edx,r9d
       mov       eax,r9d
       cmovle    eax,edx
       xor       ebx,ebx
       cmp       rax,20
       jb        near ptr M03_L03
       mov       rsi,[rcx]
       mov       rdi,0FF80FF80FF80FF80
       test      rdi,rsi
       mov       rdi,rsi
       jne       near ptr M03_L19
       cmp       rax,40
       jb        near ptr M03_L10
       mov       rbx,rcx
       vmovups   ymm0,[rbx]
       vbroadcastss ymm1,dword ptr [7FF9F7BC42B0]
       vptest    ymm1,ymm0
       jne       near ptr M03_L08
       mov       rsi,r8
       vpackuswb ymm0,ymm0,ymm0
       vpermq    ymm0,ymm0,0D8
       vmovups   [rsi],xmm0
       mov       edi,10
       test      r8b,10
       jne       short M03_L00
       vmovups   ymm0,[rbx+20]
       vptest    ymm1,ymm0
       jne       short M03_L02
       vpackuswb ymm0,ymm0,ymm0
       vpermq    ymm0,ymm0,0D8
       vmovups   [rsi+10],xmm0
M03_L00:
       mov       rdi,r8
       and       rdi,1F
       neg       rdi
       add       rdi,20
       lea       rbp,[rax-20]
       vmovups   ymm0,[rbx+rdi*2]
       vmovups   ymm2,[rbx+rdi*2+20]
       vpor      ymm3,ymm0,ymm2
       vptest    ymm3,ymm1
       jne       near ptr M03_L09
M03_L01:
       vpackuswb ymm0,ymm0,ymm2
       vpermq    ymm2,ymm0,0D8
       vmovups   [rsi+rdi],ymm2
       add       rdi,20
       cmp       rdi,rbp
       ja        short M03_L02
       vmovups   ymm0,[rbx+rdi*2]
       vmovups   ymm2,[rbx+rdi*2+20]
       vpor      ymm3,ymm0,ymm2
       vptest    ymm3,ymm1
       jne       near ptr M03_L09
       jmp       short M03_L01
M03_L02:
       mov       rbx,rdi
M03_L03:
       sub       rax,rbx
       cmp       rax,4
       jb        short M03_L05
       lea       rsi,[rbx+rax-4]
       mov       rdi,[rcx+rbx*2]
       mov       rbp,0FF80FF80FF80FF80
       test      rbp,rdi
       jne       near ptr M03_L19
M03_L04:
       vmovq     xmm0,rdi
       vpackuswb xmm0,xmm0,xmm0
       vmovd     dword ptr [r8+rbx],xmm0
       add       rbx,4
       cmp       rbx,rsi
       ja        short M03_L05
       mov       rdi,[rcx+rbx*2]
       mov       rbp,0FF80FF80FF80FF80
       test      rbp,rdi
       jne       near ptr M03_L19
       jmp       short M03_L04
M03_L05:
       test      al,2
       jne       near ptr M03_L17
M03_L06:
       test      al,1
       jne       near ptr M03_L18
M03_L07:
       lea       rcx,[rcx+rbx*2]
       add       r8,rbx
       cmp       ebx,edx
       jne       near ptr M03_L22
       mov       [r10],rcx
       mov       [r11],r8
       xor       eax,eax
       vzeroupper
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M03_L08:
       xor       ebx,ebx
       jmp       near ptr M03_L03
M03_L09:
       vptest    ymm1,ymm0
       jne       near ptr M03_L02
       vpackuswb ymm0,ymm0,ymm0
       vpermq    ymm0,ymm0,0D8
       vmovups   [rsi+rdi],xmm0
       add       rdi,10
       jmp       near ptr M03_L02
M03_L10:
       mov       rbx,rcx
       vmovups   xmm0,[rbx]
       vbroadcastss xmm1,dword ptr [7FF9F7BC42B0]
       vptest    xmm1,xmm0
       je        short M03_L11
       xor       ebx,ebx
       jmp       near ptr M03_L16
M03_L11:
       mov       rsi,r8
       vpackuswb xmm0,xmm0,xmm0
       vmovsd    qword ptr [rsi],xmm0
       mov       edi,8
       test      r8b,8
       jne       short M03_L12
       vmovups   xmm0,[rbx+10]
       vptest    xmm1,xmm0
       jne       short M03_L14
       vpackuswb xmm0,xmm0,xmm0
       vmovsd    qword ptr [rsi+8],xmm0
M03_L12:
       mov       rdi,r8
       and       rdi,0F
       neg       rdi
       add       rdi,10
       lea       rbp,[rax-10]
M03_L13:
       vmovups   xmm0,[rbx+rdi*2]
       vmovups   xmm2,[rbx+rdi*2+10]
       vpor      xmm3,xmm0,xmm2
       vptest    xmm3,xmm1
       jne       short M03_L15
       vpackuswb xmm0,xmm0,xmm2
       vmovups   [rsi+rdi],xmm0
       add       rdi,10
       cmp       rdi,rbp
       jbe       short M03_L13
M03_L14:
       mov       rbx,rdi
       jmp       short M03_L16
M03_L15:
       vptest    xmm1,xmm0
       jne       short M03_L14
       vpackuswb xmm0,xmm0,xmm0
       vmovsd    qword ptr [rsi+rdi],xmm0
       add       rdi,8
       jmp       short M03_L14
M03_L16:
       jmp       near ptr M03_L03
M03_L17:
       mov       esi,[rcx+rbx*2]
       test      esi,0FF80FF80
       jne       short M03_L20
       lea       rdi,[r8+rbx]
       mov       [rdi],sil
       shr       esi,10
       mov       [rdi+1],sil
       add       rbx,2
       jmp       near ptr M03_L06
M03_L18:
       movzx     esi,word ptr [rcx+rbx*2]
       cmp       esi,7F
       ja        near ptr M03_L07
       jmp       short M03_L21
M03_L19:
       mov       eax,edi
       test      eax,0FF80FF80
       jne       short M03_L24
       lea       rsi,[r8+rbx]
       mov       [rsi],al
       shr       eax,10
       mov       [rsi+1],al
       shr       rdi,20
       mov       eax,edi
       add       rbx,2
       mov       esi,eax
M03_L20:
       test      esi,0FF80
       jne       near ptr M03_L07
M03_L21:
       mov       [r8+rbx],sil
       inc       rbx
       jmp       near ptr M03_L07
M03_L22:
       sub       edx,ebx
       sub       r9d,ebx
       cmp       edx,2
       jl        near ptr M03_L60
       mov       eax,edx
       lea       rax,[rcx+rax*2-4]
M03_L23:
       mov       ebx,[rcx]
       jmp       near ptr M03_L49
M03_L24:
       mov       esi,eax
       jmp       short M03_L20
M03_L25:
       cmp       r9d,2
       jl        near ptr M03_L61
       mov       esi,ebx
       shr       esi,8
       or        esi,ebx
       mov       [r8],si
       add       rcx,4
       add       r8,2
       add       r9d,0FFFFFFFE
       mov       rbx,rax
       sub       rbx,rcx
       mov       rsi,rbx
       shr       rsi,3F
       add       rbx,rsi
       sar       rbx,1
       add       ebx,2
       movsxd    rsi,r9d
       cmp       rbx,rsi
       jle       short M03_L26
       jmp       short M03_L27
M03_L26:
       mov       rsi,rbx
M03_L27:
       mov       ebx,esi
       shr       ebx,3
       xor       edi,edi
       jmp       short M03_L29
M03_L28:
       vmovups   xmm0,[rcx]
       vptest    xmm0,xmmword ptr [7FF9F7BC42C0]
       jne       short M03_L30
       vpackuswb xmm0,xmm0,xmm0
       vmovq     qword ptr [r8],xmm0
       add       rcx,10
       add       r8,8
       inc       edi
M03_L29:
       cmp       edi,ebx
       jb        short M03_L28
       lea       ebx,[rdi*8]
       sub       r9d,ebx
       test      sil,4
       je        near ptr M03_L57
       mov       rbx,[rcx]
       mov       rsi,0FF80FF80FF80FF80
       test      rsi,rbx
       jne       short M03_L31
       jmp       near ptr M03_L52
M03_L30:
       shl       edi,3
       sub       r9d,edi
       vmovq     rbx,xmm0
       mov       rsi,0FF80FF80FF80FF80
       test      rsi,rbx
       jne       short M03_L31
       vpackuswb xmm1,xmm0,xmm0
       vmovd     dword ptr [r8],xmm1
       add       rcx,8
       add       r8,4
       add       r9d,0FFFFFFFC
       vpextrq   rbx,xmm0,1
M03_L31:
       mov       esi,ebx
       test      esi,0FF80FF80
       jne       short M03_L32
       mov       edi,esi
       shr       edi,8
       or        edi,esi
       mov       [r8],di
       add       rcx,4
       add       r8,2
       add       r9d,0FFFFFFFE
       shr       rbx,20
       mov       esi,ebx
M03_L32:
       test      esi,0FF80
       jne       short M03_L33
       test      r9d,r9d
       je        near ptr M03_L68
       jmp       short M03_L34
M03_L33:
       test      esi,0F800
       jne       near ptr M03_L50
       jmp       near ptr M03_L38
M03_L34:
       mov       [r8],sil
       add       rcx,2
       inc       r8
       dec       r9d
       cmp       rcx,rax
       ja        near ptr M03_L59
       mov       esi,[rcx]
       jmp       short M03_L33
M03_L35:
       cmp       r9d,2
       jl        near ptr M03_L68
       jmp       short M03_L39
M03_L36:
       cmp       r9d,4
       jl        short M03_L37
       mov       ebx,esi
       shr       ebx,6
       and       ebx,1F001F
       shl       esi,8
       and       esi,3F003F00
       add       ebx,esi
       add       ebx,80C080C0
       mov       [r8],ebx
       add       rcx,4
       add       r8,4
       add       r9d,0FFFFFFFC
       cmp       rcx,rax
       ja        near ptr M03_L59
       mov       esi,[rcx]
       lea       ebx,[rsi-80]
       movzx     ebx,bx
       cmp       ebx,780
       jl        short M03_L38
       mov       ebx,esi
       jmp       near ptr M03_L49
M03_L37:
       mov       ebx,esi
       jmp       near ptr M03_L61
M03_L38:
       lea       ebx,[rsi-800000]
       cmp       ebx,77FFFFF
       jbe       short M03_L36
       jmp       short M03_L35
M03_L39:
       lea       ebx,[rsi*4]
       and       ebx,1F00
       mov       edi,esi
       and       edi,3F
       lea       ebx,[rbx+rdi+0C080]
       movbe     [r8],bx
       cmp       esi,800000
       jb        short M03_L40
       add       rcx,2
       add       r8,2
       add       r9d,0FFFFFFFE
       cmp       rcx,rax
       ja        near ptr M03_L59
       jmp       short M03_L41
M03_L40:
       cmp       r9d,3
       jl        near ptr M03_L58
       jmp       near ptr M03_L53
M03_L41:
       mov       esi,[rcx]
       jmp       near ptr M03_L50
M03_L42:
       test      esi,0F8000000
       jne       short M03_L44
       jmp       short M03_L45
M03_L43:
       lea       ebx,[rsi+23FF2800]
       test      ebx,0FC00FC00
       je        near ptr M03_L55
       jmp       near ptr M03_L54
M03_L44:
       lea       ebx,[rsi+28000000]
       cmp       ebx,8000000
       jb        short M03_L45
       cmp       r9d,6
       jge       short M03_L46
M03_L45:
       cmp       r9d,3
       jl        near ptr M03_L68
       jmp       short M03_L47
M03_L46:
       lea       ebx,[rsi*4]
       and       ebx,3F00
       mov       edi,esi
       and       edi,3F
       shl       edi,10
       or        ebx,edi
       mov       edi,esi
       shr       edi,4
       and       edi,0F000000
       mov       ebp,esi
       shr       ebp,0C
       and       ebp,0F
       or        edi,ebp
       add       ebx,edi
       add       ebx,0E08080E0
       mov       [r8],ebx
       mov       ebx,esi
       shr       ebx,16
       and       ebx,3F
       shr       esi,8
       and       esi,3F00
       add       ebx,esi
       add       ebx,8080
       mov       [r8+4],bx
       add       rcx,4
       add       r8,6
       add       r9d,0FFFFFFFA
       cmp       rcx,rax
       ja        near ptr M03_L59
       mov       esi,[rcx]
       test      esi,0F800
       jne       near ptr M03_L50
       mov       ebx,esi
       jmp       short M03_L49
M03_L47:
       lea       ebx,[rsi*4]
       and       ebx,3F00
       movzx     edi,si
       shr       edi,0C
       add       ebx,edi
       add       ebx,80E0
       mov       [r8],bx
       mov       ebx,esi
       and       ebx,3F
       or        ebx,0FFFFFF80
       mov       [r8+2],bl
       add       rcx,2
       add       r8,3
       add       r9d,0FFFFFFFD
       cmp       esi,800000
       jb        short M03_L48
       cmp       rcx,rax
       ja        near ptr M03_L59
       jmp       short M03_L51
M03_L48:
       test      r9d,r9d
       je        near ptr M03_L68
       shr       esi,10
       mov       [r8],sil
       add       rcx,2
       inc       r8
       dec       r9d
       cmp       rcx,rax
       ja        near ptr M03_L59
       mov       esi,[rcx]
       test      esi,0F800
       jne       short M03_L50
       mov       ebx,esi
M03_L49:
       test      ebx,0FF80FF80
       je        near ptr M03_L25
       mov       esi,ebx
       jmp       near ptr M03_L32
M03_L50:
       lea       ebx,[rsi-0D800]
       test      ebx,0F800
       je        near ptr M03_L43
       jmp       near ptr M03_L42
M03_L51:
       mov       esi,[rcx]
       jmp       near ptr M03_L32
M03_L52:
       vmovq     xmm0,rbx
       vpackuswb xmm0,xmm0,xmm0
       vmovd     dword ptr [r8],xmm0
       add       rcx,8
       jmp       short M03_L56
M03_L53:
       shr       esi,10
       mov       [r8+2],sil
       add       rcx,4
       add       r8,3
       add       r9d,0FFFFFFFD
       jmp       short M03_L57
M03_L54:
       mov       eax,3
       jmp       near ptr M03_L69
M03_L55:
       cmp       r9d,4
       jl        near ptr M03_L68
       add       esi,40
       mov       ebx,esi
       and       ebx,3
       shl       ebx,14
       or        ebx,808080F0
       mov       edi,esi
       and       edi,3F0700
       bswap     edi
       rol       edi,10
       or        ebx,edi
       mov       edi,esi
       shr       edi,6
       and       edi,0F0000
       or        ebx,edi
       and       esi,0FC
       shl       esi,6
       or        ebx,esi
       mov       [r8],ebx
       add       rcx,4
M03_L56:
       add       r8,4
       add       r9d,0FFFFFFFC
M03_L57:
       cmp       rcx,rax
       jbe       near ptr M03_L23
       jmp       short M03_L59
M03_L58:
       add       rcx,2
       add       r8,2
       jmp       near ptr M03_L68
M03_L59:
       sub       rax,rcx
       mov       rdx,rax
       shr       rdx,3F
       add       rdx,rax
       sar       rdx,1
       add       edx,2
M03_L60:
       test      edx,edx
       je        near ptr M03_L67
       movzx     ebx,word ptr [rcx]
       jmp       short M03_L62
M03_L61:
       movzx     ebx,bx
M03_L62:
       cmp       ebx,7F
       ja        short M03_L63
       test      r9d,r9d
       je        near ptr M03_L68
       mov       [r8],bl
       add       rcx,2
       inc       r8
       jmp       near ptr M03_L66
M03_L63:
       cmp       ebx,800
       jae       short M03_L64
       cmp       r9d,2
       jl        near ptr M03_L68
       mov       r9d,ebx
       and       r9d,3F
       or        r9d,0FFFFFF80
       mov       [r8+1],r9b
       shr       ebx,6
       or        ebx,0FFFFFFC0
       mov       [r8],bl
       add       rcx,2
       add       r8,2
       jmp       short M03_L66
M03_L64:
       lea       eax,[rbx-0D800]
       cmp       eax,7FF
       jbe       short M03_L65
       cmp       r9d,3
       jl        short M03_L68
       mov       eax,ebx
       and       eax,3F
       or        eax,0FFFFFF80
       mov       [r8+2],al
       mov       eax,ebx
       shr       eax,6
       and       eax,3F
       or        eax,0FFFFFF80
       mov       [r8+1],al
       mov       eax,ebx
       shr       eax,0C
       or        eax,0FFFFFFE0
       mov       [r8],al
       add       rcx,2
       add       r8,3
       jmp       short M03_L66
M03_L65:
       cmp       ebx,0DBFF
       ja        near ptr M03_L54
       mov       eax,2
       jmp       short M03_L69
M03_L66:
       cmp       edx,1
       jg        short M03_L68
M03_L67:
       xor       eax,eax
       jmp       short M03_L69
M03_L68:
       mov       eax,1
M03_L69:
       mov       [r10],rcx
       mov       [r11],r8
       vzeroupper
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 1983
```
```assembly
; Org.BouncyCastle.Crypto.Digests.KeccakDigest.Absorb(Byte[], Int32, Int32)
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       rdi,rdx
       mov       ebp,r8d
       mov       esi,r9d
       mov       r9d,[rbx+1C]
       test      r9b,7
       jne       near ptr M04_L04
       cmp       byte ptr [rbx+24],0
       jne       near ptr M04_L05
       sar       r9d,3
       mov       r14d,[rbx+18]
       sar       r14d,3
       mov       r15d,r14d
       sub       r15d,r9d
       cmp       esi,r15d
       jge       near ptr M04_L16
       mov       r8,[rbx+10]
       test      rdi,rdi
       je        near ptr M04_L15
       test      r8,r8
       je        near ptr M04_L15
       mov       rcx,[rdi]
       cmp       rcx,[r8]
       jne       near ptr M04_L15
       cmp       dword ptr [rcx+4],18
       jne       near ptr M04_L15
       mov       edx,esi
       or        edx,ebp
       or        edx,r9d
       jl        near ptr M04_L15
       lea       edx,[rsi+rbp]
       cmp       edx,[rdi+8]
       ja        near ptr M04_L15
       lea       edx,[r9+rsi]
       cmp       edx,[r8+8]
       ja        near ptr M04_L15
       movzx     edx,word ptr [rcx]
       mov       eax,esi
       imul      rax,rdx
       mov       r10d,ebp
       imul      r10,rdx
       lea       r10,[rdi+r10+10]
       mov       r9d,r9d
       imul      rdx,r9
       lea       r9,[r8+rdx+10]
       test      dword ptr [rcx],1000000
       jne       near ptr M04_L06
       mov       rcx,r9
       mov       rdx,r10
       mov       r8,rax
       mov       r11,rcx
       sub       r11,rdx
       cmp       r11,r8
       jb        near ptr M04_L13
       mov       r11,rdx
       sub       r11,rcx
       cmp       r11,r8
       jb        near ptr M04_L13
       lea       r11,[rdx+r8]
       lea       rdi,[rcx+r8]
       cmp       r8,10
       jbe       near ptr M04_L07
       cmp       r8,40
       ja        near ptr M04_L10
M04_L00:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       jbe       short M04_L01
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M04_L01
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
M04_L01:
       vmovups   xmm0,[r11-10]
       vmovups   [rdi-10],xmm0
M04_L02:
       shl       esi,3
       add       [rbx+1C],esi
M04_L03:
       vzeroupper
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M04_L04:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,28F39
       mov       rdx,7FF9F8223908
       call      qword ptr [7FF9F7D67738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F7F35D28]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M04_L05:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,28F89
       mov       rdx,7FF9F8223908
       call      qword ptr [7FF9F7D67738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F7F35D28]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M04_L06:
       mov       rcx,r9
       mov       rdx,r10
       mov       r8,rax
       call      qword ptr [7FF9F7AE57A0]; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M04_L02
M04_L07:
       test      al,18
       je        short M04_L08
       mov       rax,[r10]
       mov       [r9],rax
       mov       r10,[r11-8]
       mov       [rdi-8],r10
       jmp       near ptr M04_L02
M04_L08:
       test      al,4
       je        short M04_L09
       mov       eax,[r10]
       mov       [r9],eax
       mov       r10d,[r11-4]
       mov       [rdi-4],r10d
       jmp       near ptr M04_L02
M04_L09:
       test      rax,rax
       je        near ptr M04_L02
       movzx     r10d,byte ptr [r10]
       mov       [r9],r10b
       test      al,2
       je        near ptr M04_L02
       movsx     r9,word ptr [r11-2]
       mov       [rdi-2],r9w
       jmp       near ptr M04_L02
M04_L10:
       cmp       r8,800
       ja        near ptr M04_L14
       cmp       r8,100
       jb        short M04_L11
       mov       rdx,r9
       and       rdx,3F
       mov       r8,rdx
       neg       r8
       add       r8,40
       vmovdqu   ymm0,ymmword ptr [r10]
       vmovdqu   ymmword ptr [r9],ymm0
       vmovdqu   ymm0,ymmword ptr [r10+20]
       vmovdqu   ymmword ptr [r9+20],ymm0
       lea       rdx,[r10+r8]
       lea       rcx,[r9+r8]
       sub       rax,r8
       mov       r8,rax
M04_L11:
       mov       r10,r8
       shr       r10,6
M04_L12:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r10
       jne       short M04_L12
       and       r8,3F
       cmp       r8,10
       ja        near ptr M04_L00
       jmp       near ptr M04_L01
M04_L13:
       cmp       r9,r10
       jne       short M04_L14
       cmp       [r10],r10b
       jmp       near ptr M04_L02
M04_L14:
       cmp       [r9],r9b
       cmp       [r10],r10b
       mov       rcx,r9
       mov       rdx,r10
       mov       r8,rax
       call      qword ptr [7FF9F7AE66E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M04_L02
M04_L15:
       mov       [rsp+20],esi
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rdi
       mov       edx,ebp
       call      qword ptr [7FF9F835CCF0]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M04_L02
M04_L16:
       xor       r13d,r13d
       test      r9d,r9d
       jle       short M04_L18
       mov       [rsp+20],r15d
       mov       r8,[rbx+10]
       mov       rcx,rdi
       mov       edx,ebp
       call      qword ptr [7FF9F80CC858]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       r13d,r15d
       mov       rdx,[rbx+10]
       mov       rcx,rbx
       xor       r8d,r8d
       call      qword ptr [7FF9F81C73F0]
       jmp       short M04_L18
M04_L17:
       lea       r8d,[rbp+r13]
       mov       rcx,rbx
       mov       rdx,rdi
       call      qword ptr [7FF9F81C73F0]
       add       r13d,r14d
M04_L18:
       mov       r15d,esi
       sub       r15d,r13d
       cmp       r15d,r14d
       jge       short M04_L17
       mov       [rsp+20],r15d
       lea       edx,[rbp+r13]
       mov       r8,[rbx+10]
       mov       rcx,rdi
       xor       r9d,r9d
       call      qword ptr [7FF9F80CC858]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       shl       r15d,3
       mov       [rbx+1C],r15d
       jmp       near ptr M04_L03
; Total bytes of code 888
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
       mov       rcx,27658000C90
       mov       rdi,[rcx]
       lea       ecx,[rbx-1]
       or        ecx,0F
       xor       ebp,ebp
       lzcnt     ebp,ecx
       xor       ebp,1F
       add       ebp,0FFFFFFFD
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+238],9
       jle       short M05_L02
       mov       rcx,[rcx+240]
       mov       rax,[rcx+48]
       test      rax,rax
       je        short M05_L02
M05_L00:
       mov       rcx,[rax+10]
       test      rcx,rcx
       je        short M05_L04
       mov       eax,[rcx+8]
       cmp       eax,ebp
       jbe       short M05_L04
       mov       eax,ebp
       shl       rax,4
       mov       r14,[rcx+rax+10]
       test      r14,r14
       je        short M05_L04
       xor       edx,edx
       mov       [rcx+rax+10],rdx
       cmp       byte ptr [rdi+9D],0
       jne       short M05_L03
M05_L01:
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
M05_L02:
       mov       ecx,9
       call      qword ptr [7FF9F835D500]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       short M05_L00
M05_L03:
       mov       rcx,r14
       call      qword ptr [7FF9F7FDC918]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       ebx,eax
       mov       r15d,[r14+8]
       cmp       [rsi],sil
       mov       rcx,rsi
       call      qword ptr [7FF9F7FDC918]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       [rsp+20],ebp
       mov       edx,ebx
       mov       r8d,r15d
       mov       rcx,rdi
       call      qword ptr [7FF9F835D518]
       jmp       short M05_L01
M05_L04:
       mov       rcx,[rsi+10]
       cmp       [rcx+8],ebp
       jbe       near ptr M05_L16
       mov       eax,ebp
       mov       rcx,[rcx+rax*8+10]
       test      rcx,rcx
       je        near ptr M05_L15
       mov       r14,[rcx+8]
       mov       rcx,offset MT_System.Threading.ProcessorIdCache
       call      System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       cmp       byte ptr [7FF9F7A2B1CC],0
       je        short M05_L05
       call      qword ptr [7FF9F835D530]
       mov       ebx,eax
       jmp       short M05_L07
M05_L05:
       mov       ecx,0A
       call      qword ptr [7FF9F835D548]
       mov       ebx,[rax+10]
       mov       ecx,0A
       call      qword ptr [7FF9F835D548]
       lea       ecx,[rbx-1]
       mov       [rax+10],ecx
       movzx     eax,bx
       test      eax,eax
       jne       short M05_L06
       call      qword ptr [7FF9F835D560]
       mov       ebx,eax
       jmp       short M05_L07
M05_L06:
       sar       ebx,10
M05_L07:
       mov       rcx,offset MT_System.Buffers.SharedArrayPoolStatics
       call      System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       eax,ebx
       xor       edx,edx
       div       dword ptr [7FF9F7A2B1C0]
       mov       ebx,edx
       xor       r15d,r15d
       jmp       short M05_L11
M05_L08:
       cmp       ebx,[r14+8]
       jae       near ptr M05_L21
       mov       ecx,ebx
       mov       r13,[r14+rcx*8+10]
       cmp       [r13],r13b
       xor       r12d,r12d
       mov       rcx,r13
       call      qword ptr [7FF9F80CD2C0]; System.Threading.Monitor.Enter(System.Object)
       mov       rcx,[r13+8]
       mov       eax,[r13+10]
       dec       eax
       cmp       [rcx+8],eax
       jbe       short M05_L09
       mov       edx,eax
       mov       r12,[rcx+rdx*8+10]
       mov       edx,eax
       xor       r8d,r8d
       mov       [rcx+rdx*8+10],r8
       mov       [r13+10],eax
M05_L09:
       mov       rcx,r13
       call      qword ptr [7FF9F7AE6820]; System.Threading.Monitor.Exit(System.Object)
       test      r12,r12
       jne       short M05_L12
       inc       ebx
       cmp       [r14+8],ebx
       jne       short M05_L10
       xor       ebx,ebx
M05_L10:
       inc       r15d
M05_L11:
       cmp       [r14+8],r15d
       jg        short M05_L08
       jmp       short M05_L13
M05_L12:
       mov       r14,r12
       jmp       short M05_L14
M05_L13:
       xor       r14d,r14d
M05_L14:
       test      r14,r14
       je        short M05_L15
       cmp       byte ptr [rdi+9D],0
       je        near ptr M05_L01
       mov       rcx,r14
       call      qword ptr [7FF9F7FDC918]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       ebx,eax
       mov       r15d,[r14+8]
       mov       rcx,rsi
       call      qword ptr [7FF9F7FDC918]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       [rsp+20],ebp
       mov       edx,ebx
       mov       r8d,r15d
       mov       rcx,rdi
       call      qword ptr [7FF9F835D518]
       jmp       near ptr M05_L01
M05_L15:
       mov       ecx,10
       shlx      ebx,ecx,ebp
       jmp       short M05_L18
M05_L16:
       test      ebx,ebx
       jne       short M05_L17
       mov       rax,2B6ED0562A0
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
M05_L17:
       mov       ecx,ebx
       mov       rdx,2B6ED056F28
       call      qword ptr [7FF9F7D6D770]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
M05_L18:
       cmp       ebx,800
       jge       short M05_L19
       movsxd    rdx,ebx
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
       jmp       short M05_L20
M05_L19:
       mov       ecx,ebx
       xor       edx,edx
       call      qword ptr [7FF9F835D4B8]
       mov       r14,rax
M05_L20:
       cmp       byte ptr [rdi+9D],0
       je        near ptr M05_L01
       cmp       [r14],r14b
       mov       rcx,r14
       call      qword ptr [7FF9F7FDC918]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       ebx,eax
       mov       r15d,[r14+8]
       mov       rcx,rsi
       call      qword ptr [7FF9F7FDC918]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       edx,ebx
       mov       r8d,r15d
       mov       rcx,rdi
       call      qword ptr [7FF9F835D518]
       mov       r15d,[r14+8]
       mov       rcx,rsi
       call      qword ptr [7FF9F7FDC918]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
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
       call      qword ptr [7FF9F835D578]
       jmp       near ptr M05_L01
M05_L21:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 796
```
```assembly
; Org.BouncyCastle.Crypto.Digests.KeccakDigest.DoFinal(Byte[], Int32)
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       movsxd    r9,dword ptr [rbx+20]
       mov       rcx,rbx
       call      qword ptr [7FF9F81CFB58]; Org.BouncyCastle.Crypto.Digests.KeccakDigest.Squeeze(Byte[], Int32, Int64)
       mov       rdx,offset MT_Org.BouncyCastle.Crypto.Digests.Sha3Digest
       cmp       [rbx],rdx
       jne       short M06_L00
       mov       edx,[rbx+20]
       mov       rcx,rbx
       call      qword ptr [7FF9F81C7360]; Org.BouncyCastle.Crypto.Digests.KeccakDigest.Init(Int32)
       mov       eax,[rbx+20]
       sar       eax,3
       add       rsp,20
       pop       rbx
       ret
M06_L00:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax+28]
; Total bytes of code 92
```
```assembly
; System.Convert.ToBase64String(Byte[], Int32, Int32, System.Base64FormattingOptions)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+30],ymm4
       mov       [rsp+50],rax
       mov       esi,edx
       mov       ebx,r8d
       mov       edi,r9d
       test      rcx,rcx
       je        near ptr M07_L12
       test      ebx,ebx
       jl        near ptr M07_L13
       test      esi,esi
       jl        near ptr M07_L14
       mov       eax,[rcx+8]
       mov       ebp,eax
       sub       ebp,ebx
       cmp       esi,ebp
       jl        short M07_L00
       cmp       esi,ebp
       jg        short M07_L01
M07_L00:
       mov       edx,esi
       mov       r8d,ebx
       add       r8,rdx
       mov       eax,eax
       cmp       r8,rax
       ja        near ptr M07_L15
       lea       rbp,[rcx+rdx+10]
       cmp       edi,1
       ja        near ptr M07_L16
       test      ebx,ebx
       jne       short M07_L02
       mov       rax,2B6ED050008
       jmp       near ptr M07_L10
M07_L01:
       mov       ecx,1149
       mov       rdx,7FF9F7A24000
       call      qword ptr [7FF9F7D67738]
       mov       r8,rax
       mov       edx,ebp
       mov       ecx,esi
       call      qword ptr [7FF9F835D5C0]
       int       3
M07_L02:
       cmp       edi,1
       sete      dil
       movzx     edi,dil
       lea       ecx,[rbx+2]
       mov       eax,0AAAAAAAB
       mov       edx,ecx
       imul      rax,rdx
       shr       rax,21
       shl       eax,2
       je        short M07_L04
       test      edi,edi
       je        short M07_L03
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
M07_L03:
       test      eax,eax
       jl        near ptr M07_L17
       jmp       short M07_L05
M07_L04:
       xor       eax,eax
M07_L05:
       movsxd    rdx,eax
       mov       rcx,offset MT_System.String
       call      00007FFA57738D20
       mov       rsi,rax
       test      edi,edi
       jne       short M07_L06
       cmp       ebx,10
       jge       short M07_L11
M07_L06:
       mov       [rsp+50],rbp
       mov       rdx,rbp
       test      rsi,rsi
       je        short M07_L07
       lea       rcx,[rsi+0C]
       mov       [rsp+48],rcx
       mov       rcx,[rsp+48]
       jmp       short M07_L08
M07_L07:
       xor       ecx,ecx
M07_L08:
       mov       [rsp+20],edi
       mov       r9d,ebx
       xor       r8d,r8d
       call      qword ptr [7FF9F835D668]
       xor       ecx,ecx
       mov       [rsp+48],rcx
       mov       [rsp+50],rcx
M07_L09:
       mov       rax,rsi
M07_L10:
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M07_L11:
       lea       rcx,[rsi+0C]
       mov       r8d,[rsi+8]
       mov       edx,r8d
       mov       [rsp+38],rbp
       mov       [rsp+40],ebx
       mov       [rsp+28],rcx
       mov       [rsp+30],edx
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+28]
       call      qword ptr [7FF9F7FD4150]; System.Convert.ToBase64CharsLargeNoLineBreaks(System.ReadOnlySpan`1<Byte>, System.Span`1<Char>, Int32)
       jmp       short M07_L09
M07_L12:
       mov       ecx,1139
       mov       rdx,7FF9F7A24000
       call      qword ptr [7FF9F7D67738]
       mov       rcx,rax
       call      qword ptr [7FF9F835C8D0]
       int       3
M07_L13:
       mov       ecx,0B3
       mov       rdx,7FF9F7A24000
       call      qword ptr [7FF9F7D67738]
       mov       rdx,rax
       mov       ecx,ebx
       call      qword ptr [7FF9F835D4A0]
       int       3
M07_L14:
       mov       ecx,1149
       mov       rdx,7FF9F7A24000
       call      qword ptr [7FF9F7D67738]
       mov       rdx,rax
       mov       ecx,esi
       call      qword ptr [7FF9F835D4A0]
       int       3
M07_L15:
       call      qword ptr [7FF9F7C87138]
       int       3
M07_L16:
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9F835D680]
       mov       rsi,rax
       mov       [rbx+8],edi
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9F835D698]
       mov       rbx,rax
       mov       ecx,1157
       mov       rdx,7FF9F7A24000
       call      qword ptr [7FF9F7D67738]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FF9F7F35DD0]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M07_L17:
       mov       rcx,offset MT_System.OutOfMemoryException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       call      qword ptr [7FF9F835D650]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 649
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
       je        near ptr M08_L07
       mov       ebp,[rbx+8]
       lea       ecx,[rbp-1]
       or        ecx,0F
       xor       r14d,r14d
       lzcnt     r14d,ecx
       xor       r14d,1F
       add       r14d,0FFFFFFFD
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+238],9
       jle       near ptr M08_L05
       mov       rcx,[rcx+240]
       mov       rax,[rcx+48]
       test      rax,rax
       je        near ptr M08_L05
M08_L00:
       mov       r15,[rax+10]
       test      r15,r15
       je        near ptr M08_L06
M08_L01:
       xor       r13d,r13d
       mov       r12d,1
       cmp       [r15+8],r14d
       jbe       short M08_L03
       mov       r13d,1
       test      sil,sil
       je        short M08_L02
       mov       rcx,[rbx]
       movzx     edx,word ptr [rcx]
       mov       eax,[rbx+8]
       imul      rdx,rax
       lea       rax,[rbx+10]
       test      dword ptr [rcx],1000000
       jne       near ptr M08_L08
       mov       rcx,rax
       call      qword ptr [7FF9F7AE57E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
M08_L02:
       mov       ecx,10
       shlx      ecx,ecx,r14d
       cmp       ebp,ecx
       jne       near ptr M08_L09
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
       jne       near ptr M08_L10
M08_L03:
       mov       rcx,27658000C90
       mov       rsi,[rcx]
       cmp       byte ptr [rsi+9D],0
       jne       near ptr M08_L25
M08_L04:
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
M08_L05:
       mov       ecx,9
       call      qword ptr [7FF9F835D500]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M08_L00
M08_L06:
       mov       rcx,rdi
       call      qword ptr [7FF9F81CFCF0]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
       mov       r15,rax
       jmp       near ptr M08_L01
M08_L07:
       mov       ecx,2
       call      qword ptr [7FF9F7D6C1C8]
       int       3
M08_L08:
       shr       rdx,3
       mov       rcx,rax
       call      qword ptr [7FF9F835CD50]
       jmp       near ptr M08_L02
M08_L09:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       call      qword ptr [7FF9F835DCE0]
       mov       rbx,rax
       mov       ecx,29B
       mov       rdx,7FF9F7A24000
       call      qword ptr [7FF9F7D67738]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rbp
       call      qword ptr [7FF9F7F35DD0]
       mov       rcx,rbp
       call      CORINFO_HELP_THROW
       int       3
M08_L10:
       mov       rcx,[rdi+10]
       cmp       r14d,[rcx+8]
       jae       near ptr M08_L28
       mov       edx,r14d
       mov       rax,[rcx+rdx*8+10]
       test      rax,rax
       jne       short M08_L11
       mov       rcx,rdi
       mov       edx,r14d
       call      qword ptr [7FF9F835DCF8]
M08_L11:
       mov       r12,[rax+8]
       mov       rcx,offset MT_System.Threading.ProcessorIdCache
       call      System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       cmp       byte ptr [7FF9F7A2B1CC],0
       je        short M08_L12
       call      qword ptr [7FF9F835D530]
       mov       esi,eax
       jmp       short M08_L14
M08_L12:
       mov       ecx,0A
       call      qword ptr [7FF9F835D548]
       mov       esi,[rax+10]
       mov       ecx,0A
       call      qword ptr [7FF9F835D548]
       lea       ecx,[rsi-1]
       mov       [rax+10],ecx
       movzx     eax,si
       test      eax,eax
       jne       short M08_L13
       call      qword ptr [7FF9F835D560]
       mov       esi,eax
       jmp       short M08_L14
M08_L13:
       sar       esi,10
M08_L14:
       mov       rcx,offset MT_System.Buffers.SharedArrayPoolStatics
       call      System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       eax,esi
       xor       edx,edx
       div       dword ptr [7FF9F7A2B1C0]
       mov       esi,edx
       xor       eax,eax
       jmp       near ptr M08_L21
M08_L15:
       cmp       esi,[r12+8]
       jae       near ptr M08_L28
       mov       ecx,esi
       mov       rdx,[r12+rcx*8+10]
       mov       [rsp+30],rdx
       cmp       [rdx],dl
       xor       r8d,r8d
       mov       [rsp+3C],r8d
       mov       rcx,rdx
       call      qword ptr [7FF9F80CD2C0]; System.Threading.Monitor.Enter(System.Object)
       mov       rax,[rsp+30]
       mov       rcx,[rax+8]
       mov       r8d,[rax+10]
       mov       [rsp+38],r8d
       cmp       [rcx+8],r8d
       jbe       short M08_L17
       test      r8d,r8d
       jne       short M08_L18
       xor       edx,edx
       mov       [rax+14],edx
M08_L16:
       mov       edx,r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rsp+38]
       inc       ecx
       mov       rax,[rsp+30]
       mov       [rax+10],ecx
       mov       dword ptr [rsp+3C],1
M08_L17:
       mov       rcx,rax
       call      qword ptr [7FF9F7AE6820]; System.Threading.Monitor.Exit(System.Object)
       cmp       dword ptr [rsp+3C],0
       je        short M08_L19
       jmp       short M08_L22
M08_L18:
       jmp       short M08_L16
M08_L19:
       inc       esi
       cmp       [r12+8],esi
       jne       short M08_L20
       xor       esi,esi
M08_L20:
       mov       eax,[rsp+40]
       inc       eax
M08_L21:
       mov       [rsp+40],eax
       cmp       [r12+8],eax
       jg        near ptr M08_L15
       jmp       short M08_L23
M08_L22:
       mov       r12d,1
       jmp       short M08_L24
M08_L23:
       xor       r12d,r12d
M08_L24:
       jmp       near ptr M08_L03
M08_L25:
       test      ebp,ebp
       je        near ptr M08_L04
       mov       rcx,rbx
       call      qword ptr [7FF9F7FDC918]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r15d,eax
       mov       [rsp+44],ebp
       cmp       [rdi],dil
       mov       rcx,rdi
       call      qword ptr [7FF9F7FDC918]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,rsi
       mov       r8d,r15d
       mov       r9d,[rsp+44]
       mov       edx,3
       call      qword ptr [7FF9F835DD10]
       test      r12d,r13d
       jne       near ptr M08_L04
       mov       rcx,rbx
       call      qword ptr [7FF9F7FDC918]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       ebx,eax
       mov       rcx,rdi
       call      qword ptr [7FF9F7FDC918]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       test      r13d,r13d
       jne       short M08_L26
       mov       ecx,0FFFFFFFF
       mov       edx,1
       jmp       short M08_L27
M08_L26:
       mov       ecx,r14d
       xor       edx,edx
M08_L27:
       mov       [rsp+20],ecx
       mov       [rsp+28],edx
       mov       rcx,rsi
       mov       edx,ebx
       mov       r8d,ebp
       call      qword ptr [7FF9F835DD28]
       jmp       near ptr M08_L04
M08_L28:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 913
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Security.PasswordHasherBenchmark.HashPasswordSHA3512()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       lea       rbp,[rsp+0C0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-60],ymm4
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
       jne       near ptr M00_L12
M00_L00:
       mov       r9d,r8d
       neg       r9d
       test      r8d,r8d
       jg        near ptr M00_L11
       test      r9d,r9d
       jl        near ptr M00_L11
       lea       r8d,[r9+rcx]
       cmp       r8d,[rdx+8]
       ja        near ptr M00_L11
       movzx     edx,word ptr [r10]
       mov       r8d,r9d
       imul      r8,rdx
       add       r8,rax
       mov       ecx,ecx
       imul      rdx,rcx
       test      dword ptr [r10],1000000
       jne       near ptr M00_L13
       mov       rcx,r8
       call      qword ptr [7FF9F7AE57E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
M00_L01:
       mov       r8,[rbx+10]
       mov       r9d,[r8+8]
       mov       ecx,r9d
       test      ecx,ecx
       jle       short M00_L03
M00_L02:
       dec       ecx
       cmp       ecx,r9d
       jae       near ptr M00_L19
       mov       byte ptr [r8+rcx+10],0
       test      ecx,ecx
       jg        short M00_L02
M00_L03:
       xor       r8d,r8d
       mov       [rbx+1C],r8d
       mov       byte ptr [rbx+24],0
       mov       dword ptr [rbx+20],200
       mov       r8,1F7D6400220
       mov       rsi,[r8]
       mov       r8,2386B41067C
       mov       [rbp-40],r8
       mov       rdi,[rbp-40]
       lea       r8,[rbp-48]
       lea       r9,[rbp-50]
       mov       rcx,rdi
       mov       edx,40
       call      qword ptr [7FF9F7AEFAB0]; System.Text.Unicode.Utf16Utility.GetPointerToFirstInvalidChar(Char*, Int32, Int64 ByRef, Int32 ByRef)
       sub       rax,rdi
       mov       r9,rax
       shr       r9,3F
       add       r9,rax
       sar       r9,1
       movsxd    r14,r9d
       add       r14,[rbp-48]
       cmp       r14,7FFFFFFF
       ja        near ptr M00_L15
       cmp       r9d,40
       jne       near ptr M00_L14
M00_L04:
       xor       edx,edx
       mov       [rbp-40],rdx
       movsxd    rdx,r14d
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rdi,rax
       mov       r14d,[rdi+8]
       test      r14d,r14d
       jl        near ptr M00_L16
       mov       rcx,2386B41067C
       mov       [rbp-58],rcx
       mov       r15,[rbp-58]
       mov       [rbp-60],rdi
       test      r14d,r14d
       je        near ptr M00_L17
       lea       r13,[rdi+10]
M00_L05:
       mov       r12d,r14d
       lea       rcx,[rbp-68]
       mov       [rsp+20],rcx
       lea       rcx,[rbp-70]
       mov       [rsp+28],rcx
       mov       rcx,r15
       mov       edx,40
       mov       r8,r13
       mov       r9d,r12d
       call      qword ptr [7FF9F7AEFAE0]; System.Text.Unicode.Utf8Utility.TranscodeToUtf8(Char*, Int32, Byte*, Int32, Char* ByRef, Byte* ByRef)
       mov       rcx,[rbp-68]
       sub       rcx,r15
       mov       rdx,rcx
       shr       rdx,3F
       add       rcx,rdx
       sar       rcx,1
       mov       edx,[rbp-70]
       sub       edx,r13d
       cmp       ecx,40
       jne       near ptr M00_L18
M00_L06:
       xor       ecx,ecx
       mov       [rbp-58],rcx
       mov       [rbp-60],rcx
       mov       rdx,rdi
       mov       r9d,r14d
       mov       rcx,rbx
       xor       r8d,r8d
       call      qword ptr [7FF9F81FF030]; Org.BouncyCastle.Crypto.Digests.KeccakDigest.Absorb(Byte[], Int32, Int32)
       mov       esi,[rbx+20]
       sar       esi,3
       mov       rcx,1F7EC4000E8
       mov       rcx,[rcx]
       mov       edx,esi
       call      qword ptr [7FF9F828DCD8]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Rent(Int32)
       mov       [rbp-78],rax
       mov       ecx,[rbx+1C]
       test      cl,7
       jne       short M00_L07
       cmp       byte ptr [rbx+24],0
       jne       near ptr M00_L08
       mov       rdx,[rbx+10]
       mov       r8d,ecx
       sar       r8d,3
       cmp       r8d,[rdx+8]
       jae       near ptr M00_L09
       mov       byte ptr [rdx+r8+10],2
       add       ecx,2
       mov       [rbx+1C],ecx
       mov       rcx,rbx
       mov       rdx,[rbp-78]
       xor       r8d,r8d
       call      qword ptr [7FF9F828C6E0]; Org.BouncyCastle.Crypto.Digests.KeccakDigest.DoFinal(Byte[], Int32)
       mov       rcx,[rbp-78]
       mov       r8d,esi
       xor       edx,edx
       xor       r9d,r9d
       call      qword ptr [7FF9F83478E8]; System.Convert.ToBase64String(Byte[], Int32, Int32, System.Base64FormattingOptions)
       mov       rbx,rax
       jmp       near ptr M00_L10
M00_L07:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,28F39
       mov       rdx,7FF9F828BD30
       call      qword ptr [7FF9F7D67738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F7F35D28]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L08:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,28F89
       mov       rdx,7FF9F828BD30
       call      qword ptr [7FF9F7D67738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F7F35D28]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       int       3
M00_L10:
       mov       rcx,1F7EC400108
       mov       rcx,[rcx]
       mov       rdx,[rbp-78]
       mov       r8d,1
       call      qword ptr [7FF9F828DCE0]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Return(Byte[], Boolean)
       mov       rax,rbx
       add       rsp,88
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L11:
       call      qword ptr [7FF9F84B4B40]
       int       3
M00_L12:
       mov       r9d,[r10+4]
       add       r9d,0FFFFFFE8
       shr       r9d,3
       movsxd    r8,r9d
       mov       r8d,[rax+r8*4]
       shl       r9d,3
       movsxd    r9,r9d
       add       rax,r9
       jmp       near ptr M00_L00
M00_L13:
       shr       rdx,3
       mov       rcx,r8
       call      qword ptr [7FF9F84B4B58]
       jmp       near ptr M00_L01
M00_L14:
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8d,40
       call      qword ptr [7FF9F84B4540]
       add       r14d,eax
       jns       near ptr M00_L04
M00_L15:
       call      qword ptr [7FF9F834D248]
       int       3
M00_L16:
       mov       ecx,0B
       xor       edx,edx
       call      qword ptr [7FF9F8145908]
       int       3
M00_L17:
       xor       r13d,r13d
       jmp       near ptr M00_L05
M00_L18:
       mov       [rsp+20],r12d
       mov       [rsp+28],ecx
       mov       [rsp+30],edx
       mov       dword ptr [rsp+38],1
       mov       rcx,rsi
       mov       rdx,r15
       mov       r8d,40
       mov       r9,r13
       call      qword ptr [7FF9F84B4660]
       jmp       near ptr M00_L06
M00_L19:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       sub       rsp,48
       mov       rcx,1F7EC400108
       mov       rcx,[rcx]
       mov       rdx,[rcx]
       mov       rdx,[rbp-78]
       mov       r8d,1
       call      qword ptr [7FF9F828DCE0]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Return(Byte[], Boolean)
       add       rsp,48
       ret
; Total bytes of code 1086
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
       jmp       qword ptr [7FF9F84B4138]
; Total bytes of code 231
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
       jae       near ptr M02_L09
       cmp       r10,10
       jae       near ptr M02_L07
M02_L00:
       cmp       r10,4
       jb        short M02_L02
M02_L01:
       mov       r11d,[rax]
       mov       ebx,[rax+4]
       mov       esi,r11d
       or        esi,ebx
       test      esi,0FF80FF80
       jne       near ptr M02_L12
       add       rax,8
       add       r10,0FFFFFFFFFFFFFFFC
       cmp       r10,4
       jae       short M02_L01
M02_L02:
       test      r10b,2
       je        short M02_L03
       mov       r11d,[rax]
       test      r11d,0FF80FF80
       jne       near ptr M02_L13
       add       rax,4
M02_L03:
       test      r10b,1
       je        short M02_L05
       cmp       word ptr [rax],7F
       ja        short M02_L05
M02_L04:
       add       rax,2
M02_L05:
       sub       rax,rcx
       shr       rax,1
       mov       r10d,eax
       lea       rcx,[rcx+r10*2]
       sub       edx,eax
       jne       near ptr M02_L15
       xor       edx,edx
       mov       [r8],rdx
       mov       [r9],edx
M02_L06:
       mov       rax,rcx
       vzeroupper
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L07:
       vbroadcastss xmm0,dword ptr [7FF9F8438360]
       vptest    xmm0,xmmword ptr [rax]
       jne       near ptr M02_L00
       lea       rbx,[r11+r10*2-10]
       add       r11,10
       mov       rax,r11
       and       rax,0FFFFFFFFFFFFFFF0
       vpand     xmm1,xmm0,[rax]
       vptest    xmm1,xmm1
       jne       short M02_L11
M02_L08:
       add       rax,10
       cmp       rax,rbx
       ja        short M02_L11
       vpand     xmm1,xmm0,[rax]
       vptest    xmm1,xmm1
       jne       short M02_L11
       jmp       short M02_L08
M02_L09:
       vbroadcastss ymm0,dword ptr [7FF9F8438360]
       vptest    ymm0,ymmword ptr [rax]
       jne       near ptr M02_L00
       lea       rbx,[r11+r10*2-20]
       lea       rax,[r11+20]
       and       rax,0FFFFFFFFFFFFFFE0
       vpand     ymm1,ymm0,[rax]
       vptest    ymm1,ymm1
       jne       short M02_L11
M02_L10:
       add       rax,20
       cmp       rax,rbx
       ja        short M02_L11
       vpand     ymm1,ymm0,[rax]
       vptest    ymm1,ymm1
       je        short M02_L10
M02_L11:
       mov       r11,rax
       sub       r11,rcx
       shr       r11,1
       sub       r10,r11
       jmp       near ptr M02_L00
M02_L12:
       test      r11d,0FF80FF80
       je        short M02_L14
M02_L13:
       test      r11d,0FF80
       jne       near ptr M02_L05
       jmp       near ptr M02_L04
M02_L14:
       mov       r11d,ebx
       add       rax,4
       jmp       short M02_L13
M02_L15:
       xor       eax,eax
       xor       r10d,r10d
       mov       r11d,edx
       lea       r11,[rcx+r11*2]
       cmp       edx,8
       jl        near ptr M02_L20
       vbroadcastss xmm0,dword ptr [7FF9F8438364]
       lea       rdx,[r11-10]
M02_L16:
       vmovups   xmm1,[rcx]
       add       rcx,10
       vpaddusw  xmm2,xmm1,xmm0
       vpminuw   xmm3,xmm1,[7FF9F8438370]
       vpor      xmm2,xmm2,xmm3
       vpmovmskb ebx,xmm2
       popcnt    ebx,ebx
       vpaddw    xmm2,xmm1,[7FF9F8438380]
       vpcmpgtw  xmm2,xmm0,xmm2
       vpmovmskb esi,xmm2
M02_L17:
       cmp       esi,0FFFF
       je        short M02_L19
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
       jne       near ptr M02_L22
       cmp       esi,0FFFF
       jbe       short M02_L18
       movzx     esi,si
       add       rbx,0FFFFFFFFFFFFFFFE
       add       rcx,0FFFFFFFFFFFFFFFE
M02_L18:
       popcnt    esi,esi
       sub       r10d,esi
       sub       rax,rsi
       sub       rax,rsi
       mov       esi,0FFFF
       jmp       short M02_L17
M02_L19:
       add       rax,rbx
       cmp       rcx,rdx
       jbe       near ptr M02_L16
M02_L20:
       cmp       rcx,r11
       jae       short M02_L23
       movzx     edx,word ptr [rcx]
       cmp       edx,7F
       jbe       short M02_L21
       lea       ebx,[rdx+1F800]
       shr       ebx,10
       add       rax,rbx
       add       edx,0FFFF2800
       cmp       edx,7FF
       ja        short M02_L21
       add       rax,0FFFFFFFFFFFFFFFE
       mov       rdx,r11
       sub       rdx,rcx
       cmp       rdx,4
       jb        short M02_L23
       mov       edx,[rcx]
       add       edx,23FF2800
       test      edx,0FC00FC00
       jne       short M02_L23
       dec       r10d
       add       rax,2
       add       rcx,2
M02_L21:
       add       rcx,2
       jmp       short M02_L20
M02_L22:
       add       rcx,0FFFFFFFFFFFFFFF0
       jmp       short M02_L20
M02_L23:
       mov       [r8],rax
       mov       [r9],r10d
       jmp       near ptr M02_L06
; Total bytes of code 628
```
```assembly
; System.Text.Unicode.Utf8Utility.TranscodeToUtf8(Char*, Int32, Byte*, Int32, Char* ByRef, Byte* ByRef)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       mov       r10,[rsp+48]
       mov       r11,[rsp+50]
       cmp       edx,r9d
       mov       eax,r9d
       cmovle    eax,edx
       xor       ebx,ebx
       cmp       rax,20
       jb        near ptr M03_L03
       mov       rsi,[rcx]
       mov       rdi,0FF80FF80FF80FF80
       test      rdi,rsi
       mov       rdi,rsi
       jne       near ptr M03_L19
       cmp       rax,40
       jb        near ptr M03_L10
       mov       rbx,rcx
       vmovups   ymm0,[rbx]
       vbroadcastss ymm1,dword ptr [7FF9F8437CF0]
       vptest    ymm1,ymm0
       jne       near ptr M03_L08
       mov       rsi,r8
       vpackuswb ymm0,ymm0,ymm0
       vpermq    ymm0,ymm0,0D8
       vmovups   [rsi],xmm0
       mov       edi,10
       test      r8b,10
       jne       short M03_L00
       vmovups   ymm0,[rbx+20]
       vptest    ymm1,ymm0
       jne       short M03_L02
       vpackuswb ymm0,ymm0,ymm0
       vpermq    ymm0,ymm0,0D8
       vmovups   [rsi+10],xmm0
M03_L00:
       mov       rdi,r8
       and       rdi,1F
       neg       rdi
       add       rdi,20
       lea       rbp,[rax-20]
       vmovups   ymm0,[rbx+rdi*2]
       vmovups   ymm2,[rbx+rdi*2+20]
       vpor      ymm3,ymm0,ymm2
       vptest    ymm3,ymm1
       jne       near ptr M03_L09
M03_L01:
       vpackuswb ymm0,ymm0,ymm2
       vpermq    ymm2,ymm0,0D8
       vmovups   [rsi+rdi],ymm2
       add       rdi,20
       cmp       rdi,rbp
       ja        short M03_L02
       vmovups   ymm0,[rbx+rdi*2]
       vmovups   ymm2,[rbx+rdi*2+20]
       vpor      ymm3,ymm0,ymm2
       vptest    ymm3,ymm1
       jne       near ptr M03_L09
       jmp       short M03_L01
M03_L02:
       mov       rbx,rdi
M03_L03:
       sub       rax,rbx
       cmp       rax,4
       jb        short M03_L05
       lea       rsi,[rbx+rax-4]
       mov       rdi,[rcx+rbx*2]
       mov       rbp,0FF80FF80FF80FF80
       test      rbp,rdi
       jne       near ptr M03_L19
M03_L04:
       vmovq     xmm0,rdi
       vpackuswb xmm0,xmm0,xmm0
       vmovd     dword ptr [r8+rbx],xmm0
       add       rbx,4
       cmp       rbx,rsi
       ja        short M03_L05
       mov       rdi,[rcx+rbx*2]
       mov       rbp,0FF80FF80FF80FF80
       test      rbp,rdi
       jne       near ptr M03_L19
       jmp       short M03_L04
M03_L05:
       test      al,2
       jne       near ptr M03_L17
M03_L06:
       test      al,1
       jne       near ptr M03_L18
M03_L07:
       lea       rcx,[rcx+rbx*2]
       add       r8,rbx
       cmp       ebx,edx
       jne       near ptr M03_L22
       mov       [r10],rcx
       mov       [r11],r8
       xor       eax,eax
       vzeroupper
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M03_L08:
       xor       ebx,ebx
       jmp       near ptr M03_L03
M03_L09:
       vptest    ymm1,ymm0
       jne       near ptr M03_L02
       vpackuswb ymm0,ymm0,ymm0
       vpermq    ymm0,ymm0,0D8
       vmovups   [rsi+rdi],xmm0
       add       rdi,10
       jmp       near ptr M03_L02
M03_L10:
       mov       rbx,rcx
       vmovups   xmm0,[rbx]
       vbroadcastss xmm1,dword ptr [7FF9F8437CF0]
       vptest    xmm1,xmm0
       je        short M03_L11
       xor       ebx,ebx
       jmp       near ptr M03_L16
M03_L11:
       mov       rsi,r8
       vpackuswb xmm0,xmm0,xmm0
       vmovsd    qword ptr [rsi],xmm0
       mov       edi,8
       test      r8b,8
       jne       short M03_L12
       vmovups   xmm0,[rbx+10]
       vptest    xmm1,xmm0
       jne       short M03_L14
       vpackuswb xmm0,xmm0,xmm0
       vmovsd    qword ptr [rsi+8],xmm0
M03_L12:
       mov       rdi,r8
       and       rdi,0F
       neg       rdi
       add       rdi,10
       lea       rbp,[rax-10]
M03_L13:
       vmovups   xmm0,[rbx+rdi*2]
       vmovups   xmm2,[rbx+rdi*2+10]
       vpor      xmm3,xmm0,xmm2
       vptest    xmm3,xmm1
       jne       short M03_L15
       vpackuswb xmm0,xmm0,xmm2
       vmovups   [rsi+rdi],xmm0
       add       rdi,10
       cmp       rdi,rbp
       jbe       short M03_L13
M03_L14:
       mov       rbx,rdi
       jmp       short M03_L16
M03_L15:
       vptest    xmm1,xmm0
       jne       short M03_L14
       vpackuswb xmm0,xmm0,xmm0
       vmovsd    qword ptr [rsi+rdi],xmm0
       add       rdi,8
       jmp       short M03_L14
M03_L16:
       jmp       near ptr M03_L03
M03_L17:
       mov       esi,[rcx+rbx*2]
       test      esi,0FF80FF80
       jne       short M03_L20
       lea       rdi,[r8+rbx]
       mov       [rdi],sil
       shr       esi,10
       mov       [rdi+1],sil
       add       rbx,2
       jmp       near ptr M03_L06
M03_L18:
       movzx     esi,word ptr [rcx+rbx*2]
       cmp       esi,7F
       ja        near ptr M03_L07
       jmp       short M03_L21
M03_L19:
       mov       eax,edi
       test      eax,0FF80FF80
       jne       short M03_L24
       lea       rsi,[r8+rbx]
       mov       [rsi],al
       shr       eax,10
       mov       [rsi+1],al
       shr       rdi,20
       mov       eax,edi
       add       rbx,2
       mov       esi,eax
M03_L20:
       test      esi,0FF80
       jne       near ptr M03_L07
M03_L21:
       mov       [r8+rbx],sil
       inc       rbx
       jmp       near ptr M03_L07
M03_L22:
       sub       edx,ebx
       sub       r9d,ebx
       cmp       edx,2
       jl        near ptr M03_L60
       mov       eax,edx
       lea       rax,[rcx+rax*2-4]
M03_L23:
       mov       ebx,[rcx]
       jmp       near ptr M03_L49
M03_L24:
       mov       esi,eax
       jmp       short M03_L20
M03_L25:
       cmp       r9d,2
       jl        near ptr M03_L61
       mov       esi,ebx
       shr       esi,8
       or        esi,ebx
       mov       [r8],si
       add       rcx,4
       add       r8,2
       add       r9d,0FFFFFFFE
       mov       rbx,rax
       sub       rbx,rcx
       mov       rsi,rbx
       shr       rsi,3F
       add       rbx,rsi
       sar       rbx,1
       add       ebx,2
       movsxd    rsi,r9d
       cmp       rbx,rsi
       jle       short M03_L26
       jmp       short M03_L27
M03_L26:
       mov       rsi,rbx
M03_L27:
       mov       ebx,esi
       shr       ebx,3
       xor       edi,edi
       jmp       short M03_L29
M03_L28:
       vmovups   xmm0,[rcx]
       vptest    xmm0,xmmword ptr [7FF9F8437D00]
       jne       short M03_L30
       vpackuswb xmm0,xmm0,xmm0
       vmovq     qword ptr [r8],xmm0
       add       rcx,10
       add       r8,8
       inc       edi
M03_L29:
       cmp       edi,ebx
       jb        short M03_L28
       lea       ebx,[rdi*8]
       sub       r9d,ebx
       test      sil,4
       je        near ptr M03_L57
       mov       rbx,[rcx]
       mov       rsi,0FF80FF80FF80FF80
       test      rsi,rbx
       jne       short M03_L31
       jmp       near ptr M03_L52
M03_L30:
       shl       edi,3
       sub       r9d,edi
       vmovq     rbx,xmm0
       mov       rsi,0FF80FF80FF80FF80
       test      rsi,rbx
       jne       short M03_L31
       vpackuswb xmm1,xmm0,xmm0
       vmovd     dword ptr [r8],xmm1
       add       rcx,8
       add       r8,4
       add       r9d,0FFFFFFFC
       vpextrq   rbx,xmm0,1
M03_L31:
       mov       esi,ebx
       test      esi,0FF80FF80
       jne       short M03_L32
       mov       edi,esi
       shr       edi,8
       or        edi,esi
       mov       [r8],di
       add       rcx,4
       add       r8,2
       add       r9d,0FFFFFFFE
       shr       rbx,20
       mov       esi,ebx
M03_L32:
       test      esi,0FF80
       jne       short M03_L33
       test      r9d,r9d
       je        near ptr M03_L68
       jmp       short M03_L34
M03_L33:
       test      esi,0F800
       jne       near ptr M03_L50
       jmp       near ptr M03_L38
M03_L34:
       mov       [r8],sil
       add       rcx,2
       inc       r8
       dec       r9d
       cmp       rcx,rax
       ja        near ptr M03_L59
       mov       esi,[rcx]
       jmp       short M03_L33
M03_L35:
       cmp       r9d,2
       jl        near ptr M03_L68
       jmp       short M03_L39
M03_L36:
       cmp       r9d,4
       jl        short M03_L37
       mov       ebx,esi
       shr       ebx,6
       and       ebx,1F001F
       shl       esi,8
       and       esi,3F003F00
       add       ebx,esi
       add       ebx,80C080C0
       mov       [r8],ebx
       add       rcx,4
       add       r8,4
       add       r9d,0FFFFFFFC
       cmp       rcx,rax
       ja        near ptr M03_L59
       mov       esi,[rcx]
       lea       ebx,[rsi-80]
       movzx     ebx,bx
       cmp       ebx,780
       jl        short M03_L38
       mov       ebx,esi
       jmp       near ptr M03_L49
M03_L37:
       mov       ebx,esi
       jmp       near ptr M03_L61
M03_L38:
       lea       ebx,[rsi-800000]
       cmp       ebx,77FFFFF
       jbe       short M03_L36
       jmp       short M03_L35
M03_L39:
       lea       ebx,[rsi*4]
       and       ebx,1F00
       mov       edi,esi
       and       edi,3F
       lea       ebx,[rbx+rdi+0C080]
       movbe     [r8],bx
       cmp       esi,800000
       jb        short M03_L40
       add       rcx,2
       add       r8,2
       add       r9d,0FFFFFFFE
       cmp       rcx,rax
       ja        near ptr M03_L59
       jmp       short M03_L41
M03_L40:
       cmp       r9d,3
       jl        near ptr M03_L58
       jmp       near ptr M03_L53
M03_L41:
       mov       esi,[rcx]
       jmp       near ptr M03_L50
M03_L42:
       test      esi,0F8000000
       jne       short M03_L44
       jmp       short M03_L45
M03_L43:
       lea       ebx,[rsi+23FF2800]
       test      ebx,0FC00FC00
       je        near ptr M03_L55
       jmp       near ptr M03_L54
M03_L44:
       lea       ebx,[rsi+28000000]
       cmp       ebx,8000000
       jb        short M03_L45
       cmp       r9d,6
       jge       short M03_L46
M03_L45:
       cmp       r9d,3
       jl        near ptr M03_L68
       jmp       short M03_L47
M03_L46:
       lea       ebx,[rsi*4]
       and       ebx,3F00
       mov       edi,esi
       and       edi,3F
       shl       edi,10
       or        ebx,edi
       mov       edi,esi
       shr       edi,4
       and       edi,0F000000
       mov       ebp,esi
       shr       ebp,0C
       and       ebp,0F
       or        edi,ebp
       add       ebx,edi
       add       ebx,0E08080E0
       mov       [r8],ebx
       mov       ebx,esi
       shr       ebx,16
       and       ebx,3F
       shr       esi,8
       and       esi,3F00
       add       ebx,esi
       add       ebx,8080
       mov       [r8+4],bx
       add       rcx,4
       add       r8,6
       add       r9d,0FFFFFFFA
       cmp       rcx,rax
       ja        near ptr M03_L59
       mov       esi,[rcx]
       test      esi,0F800
       jne       near ptr M03_L50
       mov       ebx,esi
       jmp       short M03_L49
M03_L47:
       lea       ebx,[rsi*4]
       and       ebx,3F00
       movzx     edi,si
       shr       edi,0C
       add       ebx,edi
       add       ebx,80E0
       mov       [r8],bx
       mov       ebx,esi
       and       ebx,3F
       or        ebx,0FFFFFF80
       mov       [r8+2],bl
       add       rcx,2
       add       r8,3
       add       r9d,0FFFFFFFD
       cmp       esi,800000
       jb        short M03_L48
       cmp       rcx,rax
       ja        near ptr M03_L59
       jmp       short M03_L51
M03_L48:
       test      r9d,r9d
       je        near ptr M03_L68
       shr       esi,10
       mov       [r8],sil
       add       rcx,2
       inc       r8
       dec       r9d
       cmp       rcx,rax
       ja        near ptr M03_L59
       mov       esi,[rcx]
       test      esi,0F800
       jne       short M03_L50
       mov       ebx,esi
M03_L49:
       test      ebx,0FF80FF80
       je        near ptr M03_L25
       mov       esi,ebx
       jmp       near ptr M03_L32
M03_L50:
       lea       ebx,[rsi-0D800]
       test      ebx,0F800
       je        near ptr M03_L43
       jmp       near ptr M03_L42
M03_L51:
       mov       esi,[rcx]
       jmp       near ptr M03_L32
M03_L52:
       vmovq     xmm0,rbx
       vpackuswb xmm0,xmm0,xmm0
       vmovd     dword ptr [r8],xmm0
       add       rcx,8
       jmp       short M03_L56
M03_L53:
       shr       esi,10
       mov       [r8+2],sil
       add       rcx,4
       add       r8,3
       add       r9d,0FFFFFFFD
       jmp       short M03_L57
M03_L54:
       mov       eax,3
       jmp       near ptr M03_L69
M03_L55:
       cmp       r9d,4
       jl        near ptr M03_L68
       add       esi,40
       mov       ebx,esi
       and       ebx,3
       shl       ebx,14
       or        ebx,808080F0
       mov       edi,esi
       and       edi,3F0700
       bswap     edi
       rol       edi,10
       or        ebx,edi
       mov       edi,esi
       shr       edi,6
       and       edi,0F0000
       or        ebx,edi
       and       esi,0FC
       shl       esi,6
       or        ebx,esi
       mov       [r8],ebx
       add       rcx,4
M03_L56:
       add       r8,4
       add       r9d,0FFFFFFFC
M03_L57:
       cmp       rcx,rax
       jbe       near ptr M03_L23
       jmp       short M03_L59
M03_L58:
       add       rcx,2
       add       r8,2
       jmp       near ptr M03_L68
M03_L59:
       sub       rax,rcx
       mov       rdx,rax
       shr       rdx,3F
       add       rdx,rax
       sar       rdx,1
       add       edx,2
M03_L60:
       test      edx,edx
       je        near ptr M03_L67
       movzx     ebx,word ptr [rcx]
       jmp       short M03_L62
M03_L61:
       movzx     ebx,bx
M03_L62:
       cmp       ebx,7F
       ja        short M03_L63
       test      r9d,r9d
       je        near ptr M03_L68
       mov       [r8],bl
       add       rcx,2
       inc       r8
       jmp       near ptr M03_L66
M03_L63:
       cmp       ebx,800
       jae       short M03_L64
       cmp       r9d,2
       jl        near ptr M03_L68
       mov       r9d,ebx
       and       r9d,3F
       or        r9d,0FFFFFF80
       mov       [r8+1],r9b
       shr       ebx,6
       or        ebx,0FFFFFFC0
       mov       [r8],bl
       add       rcx,2
       add       r8,2
       jmp       short M03_L66
M03_L64:
       lea       eax,[rbx-0D800]
       cmp       eax,7FF
       jbe       short M03_L65
       cmp       r9d,3
       jl        short M03_L68
       mov       eax,ebx
       and       eax,3F
       or        eax,0FFFFFF80
       mov       [r8+2],al
       mov       eax,ebx
       shr       eax,6
       and       eax,3F
       or        eax,0FFFFFF80
       mov       [r8+1],al
       mov       eax,ebx
       shr       eax,0C
       or        eax,0FFFFFFE0
       mov       [r8],al
       add       rcx,2
       add       r8,3
       jmp       short M03_L66
M03_L65:
       cmp       ebx,0DBFF
       ja        near ptr M03_L54
       mov       eax,2
       jmp       short M03_L69
M03_L66:
       cmp       edx,1
       jg        short M03_L68
M03_L67:
       xor       eax,eax
       jmp       short M03_L69
M03_L68:
       mov       eax,1
M03_L69:
       mov       [r10],rcx
       mov       [r11],r8
       vzeroupper
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 1983
```
```assembly
; Org.BouncyCastle.Crypto.Digests.KeccakDigest.Absorb(Byte[], Int32, Int32)
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       rdi,rdx
       mov       ebp,r8d
       mov       esi,r9d
       mov       r9d,[rbx+1C]
       test      r9b,7
       jne       near ptr M04_L04
       cmp       byte ptr [rbx+24],0
       jne       near ptr M04_L05
       sar       r9d,3
       mov       r14d,[rbx+18]
       sar       r14d,3
       mov       r15d,r14d
       sub       r15d,r9d
       cmp       esi,r15d
       jge       near ptr M04_L16
       mov       r8,[rbx+10]
       test      rdi,rdi
       je        near ptr M04_L15
       test      r8,r8
       je        near ptr M04_L15
       mov       rcx,[rdi]
       cmp       rcx,[r8]
       jne       near ptr M04_L15
       cmp       dword ptr [rcx+4],18
       jne       near ptr M04_L15
       mov       edx,esi
       or        edx,ebp
       or        edx,r9d
       jl        near ptr M04_L15
       lea       edx,[rsi+rbp]
       cmp       edx,[rdi+8]
       ja        near ptr M04_L15
       lea       edx,[r9+rsi]
       cmp       edx,[r8+8]
       ja        near ptr M04_L15
       movzx     edx,word ptr [rcx]
       mov       eax,esi
       imul      rax,rdx
       mov       r10d,ebp
       imul      r10,rdx
       lea       r10,[rdi+r10+10]
       mov       r9d,r9d
       imul      rdx,r9
       lea       r9,[r8+rdx+10]
       test      dword ptr [rcx],1000000
       jne       near ptr M04_L06
       mov       rcx,r9
       mov       rdx,r10
       mov       r8,rax
       mov       r11,rcx
       sub       r11,rdx
       cmp       r11,r8
       jb        near ptr M04_L13
       mov       r11,rdx
       sub       r11,rcx
       cmp       r11,r8
       jb        near ptr M04_L13
       lea       r11,[rdx+r8]
       lea       rdi,[rcx+r8]
       cmp       r8,10
       jbe       near ptr M04_L07
       cmp       r8,40
       ja        near ptr M04_L10
M04_L00:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       jbe       short M04_L01
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M04_L01
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
M04_L01:
       vmovups   xmm0,[r11-10]
       vmovups   [rdi-10],xmm0
M04_L02:
       shl       esi,3
       add       [rbx+1C],esi
M04_L03:
       vzeroupper
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M04_L04:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,28F39
       mov       rdx,7FF9F828BD30
       call      qword ptr [7FF9F7D67738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F7F35D28]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M04_L05:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,28F89
       mov       rdx,7FF9F828BD30
       call      qword ptr [7FF9F7D67738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F7F35D28]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M04_L06:
       mov       rcx,r9
       mov       rdx,r10
       mov       r8,rax
       call      qword ptr [7FF9F7AE57A0]; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M04_L02
M04_L07:
       test      al,18
       je        short M04_L08
       mov       rax,[r10]
       mov       [r9],rax
       mov       r10,[r11-8]
       mov       [rdi-8],r10
       jmp       near ptr M04_L02
M04_L08:
       test      al,4
       je        short M04_L09
       mov       eax,[r10]
       mov       [r9],eax
       mov       r10d,[r11-4]
       mov       [rdi-4],r10d
       jmp       near ptr M04_L02
M04_L09:
       test      rax,rax
       je        near ptr M04_L02
       movzx     r10d,byte ptr [r10]
       mov       [r9],r10b
       test      al,2
       je        near ptr M04_L02
       movsx     r9,word ptr [r11-2]
       mov       [rdi-2],r9w
       jmp       near ptr M04_L02
M04_L10:
       cmp       r8,800
       ja        near ptr M04_L14
       cmp       r8,100
       jb        short M04_L11
       mov       rdx,r9
       and       rdx,3F
       mov       r8,rdx
       neg       r8
       add       r8,40
       vmovdqu   ymm0,ymmword ptr [r10]
       vmovdqu   ymmword ptr [r9],ymm0
       vmovdqu   ymm0,ymmword ptr [r10+20]
       vmovdqu   ymmword ptr [r9+20],ymm0
       lea       rdx,[r10+r8]
       lea       rcx,[r9+r8]
       sub       rax,r8
       mov       r8,rax
M04_L11:
       mov       r10,r8
       shr       r10,6
M04_L12:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r10
       jne       short M04_L12
       and       r8,3F
       cmp       r8,10
       ja        near ptr M04_L00
       jmp       near ptr M04_L01
M04_L13:
       cmp       r9,r10
       jne       short M04_L14
       cmp       [r10],r10b
       jmp       near ptr M04_L02
M04_L14:
       cmp       [r9],r9b
       cmp       [r10],r10b
       mov       rcx,r9
       mov       rdx,r10
       mov       r8,rax
       call      qword ptr [7FF9F7AE66E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M04_L02
M04_L15:
       mov       [rsp+20],esi
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rdi
       mov       edx,ebp
       call      qword ptr [7FF9F834DC50]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M04_L02
M04_L16:
       xor       r13d,r13d
       test      r9d,r9d
       jle       short M04_L18
       mov       [rsp+20],r15d
       mov       r8,[rbx+10]
       mov       rcx,rdi
       mov       edx,ebp
       call      qword ptr [7FF9F80CC858]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       r13d,r15d
       mov       rdx,[rbx+10]
       mov       rcx,rbx
       xor       r8d,r8d
       call      qword ptr [7FF9F81FF048]
       jmp       short M04_L18
M04_L17:
       lea       r8d,[rbp+r13]
       mov       rcx,rbx
       mov       rdx,rdi
       call      qword ptr [7FF9F81FF048]
       add       r13d,r14d
M04_L18:
       mov       r15d,esi
       sub       r15d,r13d
       cmp       r15d,r14d
       jge       short M04_L17
       mov       [rsp+20],r15d
       lea       edx,[rbp+r13]
       mov       r8,[rbx+10]
       mov       rcx,rdi
       xor       r9d,r9d
       call      qword ptr [7FF9F80CC858]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       shl       r15d,3
       mov       [rbx+1C],r15d
       jmp       near ptr M04_L03
; Total bytes of code 888
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
       mov       rcx,1F7D6400C90
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
       jle       short M05_L02
       mov       rcx,[rcx+240]
       mov       rax,[rcx+48]
       test      rax,rax
       je        short M05_L02
M05_L00:
       mov       rcx,[rax+10]
       test      rcx,rcx
       je        short M05_L04
       mov       eax,[rcx+8]
       cmp       eax,ebp
       jbe       short M05_L04
       mov       eax,ebp
       shl       rax,4
       mov       r14,[rcx+rax+10]
       test      r14,r14
       je        short M05_L04
       xor       edx,edx
       mov       [rcx+rax+10],rdx
       cmp       byte ptr [rdi+9D],0
       jne       short M05_L03
M05_L01:
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
M05_L02:
       mov       ecx,9
       call      qword ptr [7FF9F834F288]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       short M05_L00
M05_L03:
       mov       rcx,r14
       call      qword ptr [7FF9F7FDC918]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       ebx,eax
       mov       r15d,[r14+8]
       cmp       [rsi],sil
       mov       rcx,rsi
       call      qword ptr [7FF9F7FDC918]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       [rsp+20],ebp
       mov       edx,ebx
       mov       r8d,r15d
       mov       rcx,rdi
       call      qword ptr [7FF9F84B4D08]
       jmp       short M05_L01
M05_L04:
       mov       rcx,[rsi+10]
       cmp       [rcx+8],ebp
       jbe       near ptr M05_L16
       mov       eax,ebp
       mov       rcx,[rcx+rax*8+10]
       test      rcx,rcx
       je        near ptr M05_L15
       mov       r14,[rcx+8]
       mov       rcx,offset MT_System.Threading.ProcessorIdCache
       call      System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       cmp       byte ptr [7FF9F7A2B1D4],0
       je        short M05_L05
       call      qword ptr [7FF9F84B4D20]
       mov       ebx,eax
       jmp       short M05_L07
M05_L05:
       mov       ecx,0A
       call      qword ptr [7FF9F84B4D38]
       mov       ebx,[rax+10]
       mov       ecx,0A
       call      qword ptr [7FF9F84B4D38]
       lea       ecx,[rbx-1]
       mov       [rax+10],ecx
       movzx     eax,bx
       test      eax,eax
       jne       short M05_L06
       call      qword ptr [7FF9F84B4D50]
       mov       ebx,eax
       jmp       short M05_L07
M05_L06:
       sar       ebx,10
M05_L07:
       mov       rcx,offset MT_System.Buffers.SharedArrayPoolStatics
       call      System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       eax,ebx
       xor       edx,edx
       div       dword ptr [7FF9F7A2B1C8]
       mov       ebx,edx
       xor       r15d,r15d
       jmp       short M05_L11
M05_L08:
       cmp       ebx,[r14+8]
       jae       near ptr M05_L21
       mov       ecx,ebx
       mov       r13,[r14+rcx*8+10]
       cmp       [r13],r13b
       xor       r12d,r12d
       mov       rcx,r13
       call      qword ptr [7FF9F80CD2D8]; System.Threading.Monitor.Enter(System.Object)
       mov       rcx,[r13+8]
       mov       eax,[r13+10]
       dec       eax
       cmp       [rcx+8],eax
       jbe       short M05_L09
       mov       edx,eax
       mov       r12,[rcx+rdx*8+10]
       mov       edx,eax
       xor       r8d,r8d
       mov       [rcx+rdx*8+10],r8
       mov       [r13+10],eax
M05_L09:
       mov       rcx,r13
       call      qword ptr [7FF9F7AE6820]; System.Threading.Monitor.Exit(System.Object)
       test      r12,r12
       jne       short M05_L12
       inc       ebx
       cmp       [r14+8],ebx
       jne       short M05_L10
       xor       ebx,ebx
M05_L10:
       inc       r15d
M05_L11:
       cmp       [r14+8],r15d
       jg        short M05_L08
       jmp       short M05_L13
M05_L12:
       mov       r14,r12
       jmp       short M05_L14
M05_L13:
       xor       r14d,r14d
M05_L14:
       test      r14,r14
       je        short M05_L15
       cmp       byte ptr [rdi+9D],0
       je        near ptr M05_L01
       mov       rcx,r14
       call      qword ptr [7FF9F7FDC918]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       ebx,eax
       mov       r15d,[r14+8]
       mov       rcx,rsi
       call      qword ptr [7FF9F7FDC918]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       [rsp+20],ebp
       mov       edx,ebx
       mov       r8d,r15d
       mov       rcx,rdi
       call      qword ptr [7FF9F84B4D08]
       jmp       near ptr M05_L01
M05_L15:
       mov       ecx,10
       shlx      ebx,ecx,ebp
       jmp       short M05_L18
M05_L16:
       test      ebx,ebx
       jne       short M05_L17
       mov       rax,2386B4062A0
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
M05_L17:
       mov       ecx,ebx
       mov       rdx,2386B406F28
       call      qword ptr [7FF9F7D6D770]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
M05_L18:
       cmp       ebx,800
       jge       short M05_L19
       movsxd    rdx,ebx
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
       jmp       short M05_L20
M05_L19:
       mov       ecx,ebx
       xor       edx,edx
       call      qword ptr [7FF9F84B4CF0]
       mov       r14,rax
M05_L20:
       cmp       byte ptr [rdi+9D],0
       je        near ptr M05_L01
       cmp       [r14],r14b
       mov       rcx,r14
       call      qword ptr [7FF9F7FDC918]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       ebx,eax
       mov       r15d,[r14+8]
       mov       rcx,rsi
       call      qword ptr [7FF9F7FDC918]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       edx,ebx
       mov       r8d,r15d
       mov       rcx,rdi
       call      qword ptr [7FF9F84B4D08]
       mov       r15d,[r14+8]
       mov       rcx,rsi
       call      qword ptr [7FF9F7FDC918]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
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
       call      qword ptr [7FF9F84B4D68]
       jmp       near ptr M05_L01
M05_L21:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 796
```
```assembly
; Org.BouncyCastle.Crypto.Digests.KeccakDigest.DoFinal(Byte[], Int32)
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       movsxd    r9,dword ptr [rbx+20]
       mov       rcx,rbx
       call      qword ptr [7FF9F8347768]; Org.BouncyCastle.Crypto.Digests.KeccakDigest.Squeeze(Byte[], Int32, Int64)
       mov       rdx,offset MT_Org.BouncyCastle.Crypto.Digests.Sha3Digest
       cmp       [rbx],rdx
       jne       short M06_L00
       mov       edx,[rbx+20]
       mov       rcx,rbx
       call      qword ptr [7FF9F81FEFB8]; Org.BouncyCastle.Crypto.Digests.KeccakDigest.Init(Int32)
       mov       eax,[rbx+20]
       sar       eax,3
       add       rsp,20
       pop       rbx
       ret
M06_L00:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax+28]
; Total bytes of code 92
```
```assembly
; System.Convert.ToBase64String(Byte[], Int32, Int32, System.Base64FormattingOptions)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,0A8
       vmovaps   [rsp+90],xmm6
       vmovaps   [rsp+80],xmm7
       vmovaps   [rsp+70],xmm8
       vmovaps   [rsp+60],xmm9
       vmovaps   [rsp+50],xmm10
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+30],ymm4
       mov       esi,edx
       mov       ebx,r8d
       mov       edi,r9d
       test      rcx,rcx
       je        near ptr M07_L20
       test      ebx,ebx
       jl        near ptr M07_L21
       test      esi,esi
       jl        near ptr M07_L22
       mov       ebp,[rcx+8]
       sub       ebp,ebx
       cmp       esi,ebp
       jl        short M07_L00
       cmp       esi,ebp
       jg        near ptr M07_L05
M07_L00:
       mov       eax,esi
       mov       edx,ebx
       add       rax,rdx
       mov       edx,[rcx+8]
       cmp       rax,rdx
       ja        near ptr M07_L23
       mov       eax,esi
       lea       rbp,[rcx+rax+10]
       cmp       edi,1
       ja        near ptr M07_L24
       test      ebx,ebx
       je        near ptr M07_L25
       cmp       edi,1
       sete      dil
       movzx     edi,dil
       lea       ecx,[rbx+2]
       mov       eax,0AAAAAAAB
       mov       edx,ecx
       imul      rax,rdx
       shr       rax,21
       shl       eax,2
       je        near ptr M07_L26
       test      edi,edi
       jne       near ptr M07_L27
M07_L01:
       test      eax,eax
       jl        near ptr M07_L28
M07_L02:
       movsxd    rdx,eax
       mov       rcx,offset MT_System.String
       call      00007FFA57738D20
       mov       rsi,rax
       test      edi,edi
       jne       near ptr M07_L31
       cmp       ebx,10
       jl        near ptr M07_L31
       lea       rcx,[rsi+0C]
       mov       edx,[rsi+8]
       imul      r9d,edx,2
       jo        near ptr M07_L34
       mov       [rsp+38],rbp
       mov       [rsp+30],rcx
       mov       r8,rcx
       cmp       ebx,5FFFFFFD
       jg        near ptr M07_L29
       lea       eax,[rbx+2]
       mov       r10d,0AAAAAAAB
       imul      rax,r10
       shr       rax,21
       shl       eax,2
       cmp       eax,r9d
       jg        near ptr M07_L29
       mov       eax,ebx
M07_L03:
       mov       r9,rbp
       mov       r10,r8
       mov       r11d,ebx
       add       r11,r9
       mov       edi,eax
       add       rdi,r9
       cmp       eax,10
       jl        near ptr M07_L09
       lea       rax,[rdi-20]
       cmp       rax,r9
       jb        near ptr M07_L07
       vmovups   ymm0,[7FF9F8442AC0]
       vbroadcastf128 ymm1,xmmword ptr [7FF9F8442AE0]
       vbroadcastss ymm2,dword ptr [7FF9F8442AF0]
       vbroadcastss ymm3,dword ptr [7FF9F8442AF4]
       vbroadcastss ymm4,dword ptr [7FF9F8442AF8]
       vbroadcastss ymm5,dword ptr [7FF9F8442AFC]
       vbroadcastss ymm6,dword ptr [7FF9F8442B00]
       vbroadcastss ymm7,dword ptr [7FF9F8442B04]
       vmovups   ymm8,[7FF9F8442B20]
       vpermd    ymm8,ymm8,[rbp]
       add       rbp,0FFFFFFFFFFFFFFFC
M07_L04:
       vpshufb   ymm8,ymm8,ymm0
       vpand     ymm9,ymm8,ymm2
       vpmulhuw  ymm9,ymm9,ymm4
       vpand     ymm8,ymm8,ymm3
       vpmullw   ymm8,ymm8,ymm5
       vpor      ymm8,ymm8,ymm9
       vpsubusb  ymm9,ymm8,ymm6
       vpcmpgtb  ymm10,ymm8,ymm7
       vpsubb    ymm9,ymm9,ymm10
       vpshufb   ymm9,ymm1,ymm9
       vpaddb    ymm8,ymm9,ymm8
       vmovups   [r8],ymm8
       add       rbp,18
       add       r8,20
       cmp       rbp,rax
       ja        short M07_L06
       vmovups   ymm8,[rbp]
       jmp       short M07_L04
M07_L05:
       mov       ecx,1149
       mov       rdx,7FF9F7A24000
       call      qword ptr [7FF9F7D67738]
       mov       r8,rax
       mov       edx,ebp
       mov       ecx,esi
       call      qword ptr [7FF9F84B4D98]
       int       3
M07_L06:
       lea       r9,[rbp+4]
       mov       r10,r8
       cmp       r9,r11
       je        near ptr M07_L12
M07_L07:
       lea       rax,[rdi-10]
       cmp       rax,r9
       jb        short M07_L09
M07_L08:
       vmovups   xmm0,[r9]
       vpshufb   xmm0,xmm0,[7FF9F8442B40]
       vpand     xmm1,xmm0,[7FF9F8442B50]
       vpmulhuw  xmm1,xmm1,[7FF9F8442B60]
       vpand     xmm0,xmm0,[7FF9F8442B70]
       vpmullw   xmm0,xmm0,[7FF9F8442B80]
       vpor      xmm0,xmm0,xmm1
       vpsubusb  xmm1,xmm0,[7FF9F8442B90]
       vpcmpgtb  xmm2,xmm0,[7FF9F8442BA0]
       vpsubb    xmm1,xmm1,xmm2
       vmovups   xmm2,[7FF9F8442AE0]
       vpshufb   xmm1,xmm2,xmm1
       vpaddb    xmm0,xmm1,xmm0
       vmovups   [r10],xmm0
       add       r9,0C
       add       r10,10
       cmp       r9,rax
       jbe       short M07_L08
       cmp       r9,r11
       je        near ptr M07_L12
M07_L09:
       mov       r8,7FFA568E5470
       add       rdi,0FFFFFFFFFFFFFFFE
       cmp       r9,rdi
       jae       short M07_L11
M07_L10:
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
       jb        short M07_L10
M07_L11:
       lea       rax,[rdi+2]
       cmp       rax,r11
       jne       short M07_L12
       lea       rax,[r9+1]
       cmp       rax,r11
       jne       near ptr M07_L30
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
M07_L12:
       xor       r9d,r9d
       mov       [rsp+38],r9
       mov       [rsp+30],r9
       mov       r9d,edx
       lea       r9,[rcx+r9*2]
       mov       edx,edx
       add       rdx,rcx
       lea       r8,[rcx+1F]
       cmp       rdx,r8
       jbe       short M07_L14
M07_L13:
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
       ja        short M07_L13
M07_L14:
       lea       r8,[rcx+0F]
       cmp       rdx,r8
       jbe       short M07_L16
M07_L15:
       add       rdx,0FFFFFFFFFFFFFFF0
       add       r9,0FFFFFFFFFFFFFFE0
       vmovups   xmm0,[rdx]
       vpmovzxbw xmm1,xmm0
       vpsrldq   xmm0,xmm0,8
       vpmovzxbw xmm0,xmm0
       vmovups   [r9],xmm1
       vmovups   [r9+10],xmm0
       cmp       rdx,r8
       ja        short M07_L15
M07_L16:
       add       rcx,3
       cmp       rdx,rcx
       jbe       short M07_L18
M07_L17:
       add       r9,0FFFFFFFFFFFFFFF8
       add       rdx,0FFFFFFFFFFFFFFFC
       vmovd     xmm0,dword ptr [rdx]
       vpmovzxbw xmm0,xmm0
       vmovq     qword ptr [r9],xmm0
       cmp       rdx,rcx
       ja        short M07_L17
M07_L18:
       mov       rax,rsi
M07_L19:
       vzeroupper
       vmovaps   xmm6,[rsp+90]
       vmovaps   xmm7,[rsp+80]
       vmovaps   xmm8,[rsp+70]
       vmovaps   xmm9,[rsp+60]
       vmovaps   xmm10,[rsp+50]
       add       rsp,0A8
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M07_L20:
       mov       ecx,1139
       mov       rdx,7FF9F7A24000
       call      qword ptr [7FF9F7D67738]
       mov       rcx,rax
       call      qword ptr [7FF9F834E8B0]
       int       3
M07_L21:
       mov       ecx,0B3
       mov       rdx,7FF9F7A24000
       call      qword ptr [7FF9F7D67738]
       mov       rdx,rax
       mov       ecx,ebx
       call      qword ptr [7FF9F834E880]
       int       3
M07_L22:
       mov       ecx,1149
       mov       rdx,7FF9F7A24000
       call      qword ptr [7FF9F7D67738]
       mov       rdx,rax
       mov       ecx,esi
       call      qword ptr [7FF9F834E880]
       int       3
M07_L23:
       call      qword ptr [7FF9F7C87138]
       int       3
M07_L24:
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9F84B4678]
       mov       rsi,rax
       mov       [rbx+8],edi
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9F834F798]
       mov       rbx,rax
       mov       ecx,1157
       mov       rdx,7FF9F7A24000
       call      qword ptr [7FF9F7D67738]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FF9F7F35DD0]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M07_L25:
       mov       rax,2386B400008
       jmp       near ptr M07_L19
M07_L26:
       xor       eax,eax
       jmp       near ptr M07_L02
M07_L27:
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
       jmp       near ptr M07_L01
M07_L28:
       mov       rcx,offset MT_System.OutOfMemoryException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       call      qword ptr [7FF9F84B4090]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M07_L29:
       sar       r9d,2
       lea       eax,[r9+r9*2]
       jmp       near ptr M07_L03
M07_L30:
       lea       rax,[r9+2]
       cmp       rax,r11
       jne       near ptr M07_L12
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
       jmp       near ptr M07_L12
M07_L31:
       mov       [rsp+48],rbp
       mov       rdx,rbp
       test      rsi,rsi
       jne       short M07_L32
       xor       ecx,ecx
       jmp       short M07_L33
M07_L32:
       lea       rcx,[rsi+0C]
       mov       [rsp+40],rcx
       mov       rcx,[rsp+40]
M07_L33:
       mov       [rsp+20],edi
       mov       r9d,ebx
       xor       r8d,r8d
       call      qword ptr [7FF9F84B4690]
       xor       eax,eax
       mov       [rsp+40],rax
       mov       [rsp+48],rax
       jmp       near ptr M07_L18
M07_L34:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 1605
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
       je        near ptr M08_L07
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
       jle       near ptr M08_L05
       mov       rcx,[rcx+240]
       mov       rax,[rcx+48]
       test      rax,rax
       je        near ptr M08_L05
M08_L00:
       mov       r15,[rax+10]
       test      r15,r15
       je        near ptr M08_L06
M08_L01:
       xor       r13d,r13d
       mov       r12d,1
       cmp       [r15+8],r14d
       jbe       short M08_L03
       mov       r13d,1
       test      sil,sil
       je        short M08_L02
       mov       rcx,[rbx]
       movzx     edx,word ptr [rcx]
       mov       eax,[rbx+8]
       imul      rdx,rax
       lea       rax,[rbx+10]
       test      dword ptr [rcx],1000000
       jne       near ptr M08_L08
       mov       rcx,rax
       call      qword ptr [7FF9F7AE57E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
M08_L02:
       mov       ecx,10
       shlx      ecx,ecx,r14d
       cmp       ebp,ecx
       jne       near ptr M08_L09
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
       jne       near ptr M08_L10
M08_L03:
       mov       rcx,1F7D6400C90
       mov       rsi,[rcx]
       cmp       byte ptr [rsi+9D],0
       jne       near ptr M08_L25
M08_L04:
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
M08_L05:
       mov       ecx,9
       call      qword ptr [7FF9F834F288]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M08_L00
M08_L06:
       mov       rcx,rdi
       call      qword ptr [7FF9F8347900]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
       mov       r15,rax
       jmp       near ptr M08_L01
M08_L07:
       mov       ecx,2
       call      qword ptr [7FF9F7D6C1C8]
       int       3
M08_L08:
       shr       rdx,3
       mov       rcx,rax
       call      qword ptr [7FF9F84B4B58]
       jmp       near ptr M08_L02
M08_L09:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       call      qword ptr [7FF9F84B4E40]
       mov       rbx,rax
       mov       ecx,29B
       mov       rdx,7FF9F7A24000
       call      qword ptr [7FF9F7D67738]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rbp
       call      qword ptr [7FF9F7F35DD0]
       mov       rcx,rbp
       call      CORINFO_HELP_THROW
       int       3
M08_L10:
       mov       rcx,[rdi+10]
       cmp       r14d,[rcx+8]
       jae       near ptr M08_L28
       mov       edx,r14d
       mov       rax,[rcx+rdx*8+10]
       test      rax,rax
       jne       short M08_L11
       mov       rcx,rdi
       mov       edx,r14d
       call      qword ptr [7FF9F84B4E58]
M08_L11:
       mov       r12,[rax+8]
       mov       rcx,offset MT_System.Threading.ProcessorIdCache
       call      System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       cmp       byte ptr [7FF9F7A2B1D4],0
       je        short M08_L12
       call      qword ptr [7FF9F84B4D20]
       mov       esi,eax
       jmp       short M08_L14
M08_L12:
       mov       ecx,0A
       call      qword ptr [7FF9F84B4D38]
       mov       esi,[rax+10]
       mov       ecx,0A
       call      qword ptr [7FF9F84B4D38]
       lea       ecx,[rsi-1]
       mov       [rax+10],ecx
       movzx     eax,si
       test      eax,eax
       jne       short M08_L13
       call      qword ptr [7FF9F84B4D50]
       mov       esi,eax
       jmp       short M08_L14
M08_L13:
       sar       esi,10
M08_L14:
       mov       rcx,offset MT_System.Buffers.SharedArrayPoolStatics
       call      System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       eax,esi
       xor       edx,edx
       div       dword ptr [7FF9F7A2B1C8]
       mov       esi,edx
       xor       eax,eax
       jmp       near ptr M08_L21
M08_L15:
       cmp       esi,[r12+8]
       jae       near ptr M08_L28
       mov       ecx,esi
       mov       rdx,[r12+rcx*8+10]
       mov       [rsp+30],rdx
       cmp       [rdx],dl
       xor       r8d,r8d
       mov       [rsp+3C],r8d
       mov       rcx,rdx
       call      qword ptr [7FF9F80CD2D8]; System.Threading.Monitor.Enter(System.Object)
       mov       rax,[rsp+30]
       mov       rcx,[rax+8]
       mov       r8d,[rax+10]
       mov       [rsp+38],r8d
       cmp       [rcx+8],r8d
       jbe       short M08_L17
       test      r8d,r8d
       jne       short M08_L18
       xor       edx,edx
       mov       [rax+14],edx
M08_L16:
       mov       edx,r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rsp+38]
       inc       ecx
       mov       rax,[rsp+30]
       mov       [rax+10],ecx
       mov       dword ptr [rsp+3C],1
M08_L17:
       mov       rcx,rax
       call      qword ptr [7FF9F7AE6820]; System.Threading.Monitor.Exit(System.Object)
       cmp       dword ptr [rsp+3C],0
       je        short M08_L19
       jmp       short M08_L22
M08_L18:
       jmp       short M08_L16
M08_L19:
       inc       esi
       cmp       [r12+8],esi
       jne       short M08_L20
       xor       esi,esi
M08_L20:
       mov       eax,[rsp+40]
       inc       eax
M08_L21:
       mov       [rsp+40],eax
       cmp       [r12+8],eax
       jg        near ptr M08_L15
       jmp       short M08_L23
M08_L22:
       mov       r12d,1
       jmp       short M08_L24
M08_L23:
       xor       r12d,r12d
M08_L24:
       jmp       near ptr M08_L03
M08_L25:
       test      ebp,ebp
       je        near ptr M08_L04
       mov       rcx,rbx
       call      qword ptr [7FF9F7FDC918]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r15d,eax
       mov       [rsp+44],ebp
       cmp       [rdi],dil
       mov       rcx,rdi
       call      qword ptr [7FF9F7FDC918]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,rsi
       mov       r8d,r15d
       mov       r9d,[rsp+44]
       mov       edx,3
       call      qword ptr [7FF9F84B4528]
       test      r12d,r13d
       jne       near ptr M08_L04
       mov       rcx,rbx
       call      qword ptr [7FF9F7FDC918]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       ebx,eax
       mov       rcx,rdi
       call      qword ptr [7FF9F7FDC918]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       test      r13d,r13d
       jne       short M08_L26
       mov       ecx,0FFFFFFFF
       mov       edx,1
       jmp       short M08_L27
M08_L26:
       mov       ecx,r14d
       xor       edx,edx
M08_L27:
       mov       [rsp+20],ecx
       mov       [rsp+28],edx
       mov       rcx,rsi
       mov       edx,ebx
       mov       r8d,ebp
       call      qword ptr [7FF9F84B4E70]
       jmp       near ptr M08_L04
M08_L28:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 913
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Security.PasswordHasherBenchmark.HashPasswordShake128()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       lea       rbp,[rsp+0C0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-60],ymm4
       xor       eax,eax
       mov       [rbp-40],rax
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
       jne       near ptr M00_L11
M00_L00:
       mov       r9d,r8d
       neg       r9d
       test      r8d,r8d
       jg        near ptr M00_L12
       test      r9d,r9d
       jl        near ptr M00_L12
       lea       r8d,[r9+rcx]
       cmp       r8d,[rdx+8]
       ja        near ptr M00_L12
       movzx     edx,word ptr [r10]
       mov       r8d,r9d
       imul      r8,rdx
       add       r8,rax
       mov       ecx,ecx
       imul      rdx,rcx
       test      dword ptr [r10],1000000
       jne       near ptr M00_L13
       mov       rcx,r8
       call      qword ptr [7FF9F7B157E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
M00_L01:
       mov       r8,[rbx+10]
       mov       r9d,[r8+8]
       mov       ecx,r9d
       test      ecx,ecx
       jle       short M00_L03
M00_L02:
       dec       ecx
       cmp       ecx,r9d
       jae       near ptr M00_L19
       mov       byte ptr [r8+rcx+10],0
       test      ecx,ecx
       jg        short M00_L02
M00_L03:
       xor       r8d,r8d
       mov       [rbx+1C],r8d
       mov       byte ptr [rbx+24],0
       mov       dword ptr [rbx+20],80
       mov       r8,2314C000220
       mov       rsi,[r8]
       mov       r8,271E10406A4
       mov       [rbp-40],r8
       mov       rdi,[rbp-40]
       lea       r8,[rbp-48]
       lea       r9,[rbp-50]
       mov       rcx,rdi
       mov       edx,40
       call      qword ptr [7FF9F7B1FAB0]; System.Text.Unicode.Utf16Utility.GetPointerToFirstInvalidChar(Char*, Int32, Int64 ByRef, Int32 ByRef)
       sub       rax,rdi
       mov       r9,rax
       shr       r9,3F
       add       r9,rax
       sar       r9,1
       movsxd    r14,r9d
       add       r14,[rbp-48]
       cmp       r14,7FFFFFFF
       ja        near ptr M00_L15
       cmp       r9d,40
       jne       near ptr M00_L14
M00_L04:
       xor       edx,edx
       mov       [rbp-40],rdx
       movsxd    rdx,r14d
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rdi,rax
       mov       r14d,[rdi+8]
       test      r14d,r14d
       jl        near ptr M00_L16
       mov       rcx,271E10406A4
       mov       [rbp-58],rcx
       mov       r15,[rbp-58]
       mov       [rbp-60],rdi
       test      r14d,r14d
       je        near ptr M00_L17
       lea       r13,[rdi+10]
M00_L05:
       mov       r12d,r14d
       lea       rcx,[rbp-68]
       mov       [rsp+20],rcx
       lea       rcx,[rbp-70]
       mov       [rsp+28],rcx
       mov       rcx,r15
       mov       edx,40
       mov       r8,r13
       mov       r9d,r12d
       call      qword ptr [7FF9F7B1FAE0]; System.Text.Unicode.Utf8Utility.TranscodeToUtf8(Char*, Int32, Byte*, Int32, Char* ByRef, Byte* ByRef)
       mov       rcx,[rbp-68]
       sub       rcx,r15
       mov       rdx,rcx
       shr       rdx,3F
       add       rcx,rdx
       sar       rcx,1
       mov       edx,[rbp-70]
       sub       edx,r13d
       cmp       ecx,40
       jne       near ptr M00_L18
M00_L06:
       xor       ecx,ecx
       mov       [rbp-58],rcx
       mov       [rbp-60],rcx
       mov       rdx,rdi
       mov       r9d,r14d
       mov       rcx,rbx
       xor       r8d,r8d
       call      qword ptr [7FF9F81F7570]; Org.BouncyCastle.Crypto.Digests.KeccakDigest.Absorb(Byte[], Int32, Int32)
       mov       rcx,231620000C8
       mov       rsi,[rcx]
       mov       rcx,rsi
       mov       edx,10
       call      qword ptr [7FF9F825A000]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Rent(Int32)
       mov       [rbp-78],rax
       cmp       byte ptr [rbx+24],0
       jne       short M00_L07
       mov       ecx,[rbx+1C]
       test      cl,7
       jne       short M00_L08
       mov       rax,[rbx+10]
       mov       edx,ecx
       sar       edx,3
       cmp       edx,[rax+8]
       jae       near ptr M00_L09
       mov       byte ptr [rax+rdx+10],0F
       add       ecx,4
       mov       [rbx+1C],ecx
M00_L07:
       mov       rcx,rbx
       mov       rdx,[rbp-78]
       xor       r8d,r8d
       mov       r9d,80
       call      qword ptr [7FF9F81FFD08]; Org.BouncyCastle.Crypto.Digests.KeccakDigest.Squeeze(Byte[], Int32, Int64)
       mov       rcx,rbx
       call      qword ptr [7FF9F82586C0]; Org.BouncyCastle.Crypto.Digests.KeccakDigest.Reset()
       mov       rcx,[rbp-78]
       xor       edx,edx
       mov       r8d,10
       xor       r9d,r9d
       call      qword ptr [7FF9F81FFE88]; System.Convert.ToBase64String(Byte[], Int32, Int32, System.Base64FormattingOptions)
       mov       rbx,rax
       jmp       short M00_L10
M00_L08:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,28F39
       mov       rdx,7FF9F8257D00
       call      qword ptr [7FF9F7D97738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F7F65D28]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       int       3
M00_L10:
       mov       rcx,rsi
       mov       rdx,[rbp-78]
       mov       r8d,1
       call      qword ptr [7FF9F825A008]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Return(Byte[], Boolean)
       mov       rax,rbx
       add       rsp,88
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L11:
       mov       r9d,[r10+4]
       add       r9d,0FFFFFFE8
       shr       r9d,3
       movsxd    r8,r9d
       mov       r8d,[rax+r8*4]
       shl       r9d,3
       movsxd    r9,r9d
       add       rax,r9
       jmp       near ptr M00_L00
M00_L12:
       call      qword ptr [7FF9F838CCD8]
       int       3
M00_L13:
       shr       rdx,3
       mov       rcx,r8
       call      qword ptr [7FF9F838CCF0]
       jmp       near ptr M00_L01
M00_L14:
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8d,40
       call      qword ptr [7FF9F838D1D0]
       add       r14d,eax
       jns       near ptr M00_L04
M00_L15:
       call      qword ptr [7FF9F838D1E8]
       int       3
M00_L16:
       mov       ecx,0B
       xor       edx,edx
       call      qword ptr [7FF9F8175908]
       int       3
M00_L17:
       xor       r13d,r13d
       jmp       near ptr M00_L05
M00_L18:
       mov       [rsp+20],r12d
       mov       [rsp+28],ecx
       mov       [rsp+30],edx
       mov       dword ptr [rsp+38],1
       mov       rcx,rsi
       mov       rdx,r15
       mov       r8d,40
       mov       r9,r13
       call      qword ptr [7FF9F838D338]
       jmp       near ptr M00_L06
M00_L19:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       sub       rsp,48
       mov       rcx,231620000C8
       mov       rsi,[rcx]
       mov       rcx,rsi
       mov       rdx,[rbp-78]
       mov       r8d,1
       call      qword ptr [7FF9F825A008]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Return(Byte[], Boolean)
       nop
       add       rsp,48
       ret
; Total bytes of code 1024
```
```assembly
; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
       push      rbx
       test      rdx,rdx
       je        short M01_L03
       lea       rbx,[rcx+rdx]
       cmp       rdx,10
       jbe       short M01_L04
       cmp       rdx,40
       jbe       short M01_L06
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
       ja        short M01_L06
M01_L02:
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rbx-10],xmm0
M01_L03:
       pop       rbx
       ret
M01_L04:
       test      dl,18
       je        short M01_L05
       xor       edx,edx
       mov       [rcx],rdx
       mov       [rbx-8],rdx
       jmp       short M01_L03
M01_L05:
       test      dl,4
       je        short M01_L07
       xor       edx,edx
       mov       [rcx],edx
       mov       [rbx-4],edx
       jmp       short M01_L03
M01_L06:
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
       jmp       qword ptr [7FF9F838CB10]
; Total bytes of code 231
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
       jae       near ptr M02_L09
       cmp       r10,10
       jae       near ptr M02_L07
M02_L00:
       cmp       r10,4
       jb        short M02_L02
M02_L01:
       mov       r11d,[rax]
       mov       ebx,[rax+4]
       mov       esi,r11d
       or        esi,ebx
       test      esi,0FF80FF80
       jne       near ptr M02_L12
       add       rax,8
       add       r10,0FFFFFFFFFFFFFFFC
       cmp       r10,4
       jae       short M02_L01
M02_L02:
       test      r10b,2
       je        short M02_L03
       mov       r11d,[rax]
       test      r11d,0FF80FF80
       jne       near ptr M02_L13
       add       rax,4
M02_L03:
       test      r10b,1
       je        short M02_L05
       cmp       word ptr [rax],7F
       ja        short M02_L05
M02_L04:
       add       rax,2
M02_L05:
       sub       rax,rcx
       shr       rax,1
       mov       r10d,eax
       lea       rcx,[rcx+r10*2]
       sub       edx,eax
       jne       near ptr M02_L15
       xor       edx,edx
       mov       [r8],rdx
       mov       [r9],edx
M02_L06:
       mov       rax,rcx
       vzeroupper
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L07:
       vbroadcastss xmm0,dword ptr [7FF9F7BF1880]
       vptest    xmm0,xmmword ptr [rax]
       jne       near ptr M02_L00
       lea       rbx,[r11+r10*2-10]
       add       r11,10
       mov       rax,r11
       and       rax,0FFFFFFFFFFFFFFF0
       vpand     xmm1,xmm0,[rax]
       vptest    xmm1,xmm1
       jne       short M02_L11
M02_L08:
       add       rax,10
       cmp       rax,rbx
       ja        short M02_L11
       vpand     xmm1,xmm0,[rax]
       vptest    xmm1,xmm1
       jne       short M02_L11
       jmp       short M02_L08
M02_L09:
       vbroadcastss ymm0,dword ptr [7FF9F7BF1880]
       vptest    ymm0,ymmword ptr [rax]
       jne       near ptr M02_L00
       lea       rbx,[r11+r10*2-20]
       lea       rax,[r11+20]
       and       rax,0FFFFFFFFFFFFFFE0
       vpand     ymm1,ymm0,[rax]
       vptest    ymm1,ymm1
       jne       short M02_L11
M02_L10:
       add       rax,20
       cmp       rax,rbx
       ja        short M02_L11
       vpand     ymm1,ymm0,[rax]
       vptest    ymm1,ymm1
       je        short M02_L10
M02_L11:
       mov       r11,rax
       sub       r11,rcx
       shr       r11,1
       sub       r10,r11
       jmp       near ptr M02_L00
M02_L12:
       test      r11d,0FF80FF80
       je        short M02_L14
M02_L13:
       test      r11d,0FF80
       jne       near ptr M02_L05
       jmp       near ptr M02_L04
M02_L14:
       mov       r11d,ebx
       add       rax,4
       jmp       short M02_L13
M02_L15:
       xor       eax,eax
       xor       r10d,r10d
       mov       r11d,edx
       lea       r11,[rcx+r11*2]
       cmp       edx,8
       jl        near ptr M02_L20
       vbroadcastss xmm0,dword ptr [7FF9F7BF1884]
       lea       rdx,[r11-10]
M02_L16:
       vmovups   xmm1,[rcx]
       add       rcx,10
       vpaddusw  xmm2,xmm1,xmm0
       vpminuw   xmm3,xmm1,[7FF9F7BF1890]
       vpor      xmm2,xmm2,xmm3
       vpmovmskb ebx,xmm2
       popcnt    ebx,ebx
       vpaddw    xmm2,xmm1,[7FF9F7BF18A0]
       vpcmpgtw  xmm2,xmm0,xmm2
       vpmovmskb esi,xmm2
M02_L17:
       cmp       esi,0FFFF
       je        short M02_L19
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
       jne       near ptr M02_L22
       cmp       esi,0FFFF
       jbe       short M02_L18
       movzx     esi,si
       add       rbx,0FFFFFFFFFFFFFFFE
       add       rcx,0FFFFFFFFFFFFFFFE
M02_L18:
       popcnt    esi,esi
       sub       r10d,esi
       sub       rax,rsi
       sub       rax,rsi
       mov       esi,0FFFF
       jmp       short M02_L17
M02_L19:
       add       rax,rbx
       cmp       rcx,rdx
       jbe       near ptr M02_L16
M02_L20:
       cmp       rcx,r11
       jae       short M02_L23
       movzx     edx,word ptr [rcx]
       cmp       edx,7F
       jbe       short M02_L21
       lea       ebx,[rdx+1F800]
       shr       ebx,10
       add       rax,rbx
       add       edx,0FFFF2800
       cmp       edx,7FF
       ja        short M02_L21
       add       rax,0FFFFFFFFFFFFFFFE
       mov       rdx,r11
       sub       rdx,rcx
       cmp       rdx,4
       jb        short M02_L23
       mov       edx,[rcx]
       add       edx,23FF2800
       test      edx,0FC00FC00
       jne       short M02_L23
       dec       r10d
       add       rax,2
       add       rcx,2
M02_L21:
       add       rcx,2
       jmp       short M02_L20
M02_L22:
       add       rcx,0FFFFFFFFFFFFFFF0
       jmp       short M02_L20
M02_L23:
       mov       [r8],rax
       mov       [r9],r10d
       jmp       near ptr M02_L06
; Total bytes of code 628
```
```assembly
; System.Text.Unicode.Utf8Utility.TranscodeToUtf8(Char*, Int32, Byte*, Int32, Char* ByRef, Byte* ByRef)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       mov       r10,[rsp+48]
       mov       r11,[rsp+50]
       cmp       edx,r9d
       mov       eax,r9d
       cmovle    eax,edx
       xor       ebx,ebx
       cmp       rax,20
       jb        near ptr M03_L03
       mov       rsi,[rcx]
       mov       rdi,0FF80FF80FF80FF80
       test      rdi,rsi
       mov       rdi,rsi
       jne       near ptr M03_L19
       cmp       rax,40
       jb        near ptr M03_L11
       mov       rbx,rcx
       vmovups   ymm0,[rbx]
       vbroadcastss ymm1,dword ptr [7FF9F7BECC80]
       vptest    ymm1,ymm0
       jne       near ptr M03_L09
       mov       rsi,r8
       vpackuswb ymm0,ymm0,ymm0
       vpermq    ymm0,ymm0,0D8
       vmovups   [rsi],xmm0
       mov       edi,10
       test      r8b,10
       jne       short M03_L00
       vmovups   ymm0,[rbx+20]
       vptest    ymm1,ymm0
       jne       short M03_L02
       vpackuswb ymm0,ymm0,ymm0
       vpermq    ymm0,ymm0,0D8
       vmovups   [rsi+10],xmm0
M03_L00:
       mov       rdi,r8
       and       rdi,1F
       neg       rdi
       add       rdi,20
       lea       rbp,[rax-20]
       vmovups   ymm0,[rbx+rdi*2]
       vmovups   ymm2,[rbx+rdi*2+20]
       vpor      ymm3,ymm0,ymm2
       vptest    ymm3,ymm1
       jne       near ptr M03_L10
M03_L01:
       vpackuswb ymm0,ymm0,ymm2
       vpermq    ymm2,ymm0,0D8
       vmovups   [rsi+rdi],ymm2
       add       rdi,20
       cmp       rdi,rbp
       ja        short M03_L02
       vmovups   ymm0,[rbx+rdi*2]
       vmovups   ymm2,[rbx+rdi*2+20]
       vpor      ymm3,ymm0,ymm2
       vptest    ymm3,ymm1
       jne       near ptr M03_L10
       jmp       short M03_L01
M03_L02:
       mov       rbx,rdi
M03_L03:
       sub       rax,rbx
       cmp       rax,4
       jb        near ptr M03_L06
       lea       rsi,[rbx+rax-4]
       mov       rdi,[rcx+rbx*2]
       mov       rbp,0FF80FF80FF80FF80
       test      rbp,rdi
       jne       near ptr M03_L19
M03_L04:
       vmovq     xmm0,rdi
       vpackuswb xmm0,xmm0,xmm0
       vmovd     dword ptr [r8+rbx],xmm0
       add       rbx,4
       cmp       rbx,rsi
       ja        short M03_L06
       mov       rdi,[rcx+rbx*2]
       mov       rbp,0FF80FF80FF80FF80
       test      rbp,rdi
       jne       near ptr M03_L19
       jmp       short M03_L04
M03_L05:
       vmovups   xmm0,[rbx+rdi*2]
       vmovups   xmm2,[rbx+rdi*2+10]
       vpor      xmm3,xmm0,xmm2
       vptest    xmm3,xmm1
       jne       near ptr M03_L15
       vpackuswb xmm0,xmm0,xmm2
       vmovups   [rsi+rdi],xmm0
       add       rdi,10
       cmp       rdi,rbp
       jbe       short M03_L05
       jmp       near ptr M03_L14
M03_L06:
       test      al,2
       jne       near ptr M03_L17
M03_L07:
       test      al,1
       jne       near ptr M03_L18
M03_L08:
       lea       rcx,[rcx+rbx*2]
       add       r8,rbx
       cmp       ebx,edx
       jne       near ptr M03_L22
       mov       [r10],rcx
       mov       [r11],r8
       xor       eax,eax
       vzeroupper
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M03_L09:
       xor       ebx,ebx
       jmp       near ptr M03_L03
M03_L10:
       vptest    ymm1,ymm0
       jne       near ptr M03_L02
       vpackuswb ymm0,ymm0,ymm0
       vpermq    ymm0,ymm0,0D8
       vmovups   [rsi+rdi],xmm0
       add       rdi,10
       jmp       near ptr M03_L02
M03_L11:
       mov       rbx,rcx
       vmovups   xmm0,[rbx]
       vbroadcastss xmm1,dword ptr [7FF9F7BECC80]
       vptest    xmm1,xmm0
       je        short M03_L12
       xor       ebx,ebx
       jmp       short M03_L16
M03_L12:
       mov       rsi,r8
       vpackuswb xmm0,xmm0,xmm0
       vmovsd    qword ptr [rsi],xmm0
       mov       edi,8
       test      r8b,8
       jne       short M03_L13
       vmovups   xmm0,[rbx+10]
       vptest    xmm1,xmm0
       jne       short M03_L14
       vpackuswb xmm0,xmm0,xmm0
       vmovsd    qword ptr [rsi+8],xmm0
M03_L13:
       mov       rdi,r8
       and       rdi,0F
       neg       rdi
       add       rdi,10
       lea       rbp,[rax-10]
       jmp       near ptr M03_L05
M03_L14:
       mov       rbx,rdi
       jmp       short M03_L16
M03_L15:
       vptest    xmm1,xmm0
       jne       short M03_L14
       vpackuswb xmm0,xmm0,xmm0
       vmovsd    qword ptr [rsi+rdi],xmm0
       add       rdi,8
       jmp       short M03_L14
M03_L16:
       jmp       near ptr M03_L03
M03_L17:
       mov       esi,[rcx+rbx*2]
       test      esi,0FF80FF80
       jne       short M03_L20
       lea       rdi,[r8+rbx]
       mov       [rdi],sil
       shr       esi,10
       mov       [rdi+1],sil
       add       rbx,2
       jmp       near ptr M03_L07
M03_L18:
       movzx     esi,word ptr [rcx+rbx*2]
       cmp       esi,7F
       ja        near ptr M03_L08
       jmp       short M03_L21
M03_L19:
       mov       eax,edi
       test      eax,0FF80FF80
       jne       short M03_L24
       lea       rsi,[r8+rbx]
       mov       [rsi],al
       shr       eax,10
       mov       [rsi+1],al
       shr       rdi,20
       mov       eax,edi
       add       rbx,2
       mov       esi,eax
M03_L20:
       test      esi,0FF80
       jne       near ptr M03_L08
M03_L21:
       mov       [r8+rbx],sil
       inc       rbx
       jmp       near ptr M03_L08
M03_L22:
       sub       edx,ebx
       sub       r9d,ebx
       cmp       edx,2
       jl        near ptr M03_L60
       mov       eax,edx
       lea       rax,[rcx+rax*2-4]
M03_L23:
       mov       ebx,[rcx]
       jmp       near ptr M03_L49
M03_L24:
       mov       esi,eax
       jmp       short M03_L20
M03_L25:
       cmp       r9d,2
       jl        near ptr M03_L61
       mov       esi,ebx
       shr       esi,8
       or        esi,ebx
       mov       [r8],si
       add       rcx,4
       add       r8,2
       add       r9d,0FFFFFFFE
       mov       rbx,rax
       sub       rbx,rcx
       mov       rsi,rbx
       shr       rsi,3F
       add       rbx,rsi
       sar       rbx,1
       add       ebx,2
       movsxd    rsi,r9d
       cmp       rbx,rsi
       jle       short M03_L26
       jmp       short M03_L27
M03_L26:
       mov       rsi,rbx
M03_L27:
       mov       ebx,esi
       shr       ebx,3
       xor       edi,edi
       jmp       short M03_L29
M03_L28:
       vmovups   xmm0,[rcx]
       vptest    xmm0,xmmword ptr [7FF9F7BECC90]
       jne       short M03_L30
       vpackuswb xmm0,xmm0,xmm0
       vmovq     qword ptr [r8],xmm0
       add       rcx,10
       add       r8,8
       inc       edi
M03_L29:
       cmp       edi,ebx
       jb        short M03_L28
       lea       ebx,[rdi*8]
       sub       r9d,ebx
       test      sil,4
       je        near ptr M03_L57
       mov       rbx,[rcx]
       mov       rsi,0FF80FF80FF80FF80
       test      rsi,rbx
       jne       short M03_L31
       jmp       near ptr M03_L52
M03_L30:
       shl       edi,3
       sub       r9d,edi
       vmovq     rbx,xmm0
       mov       rsi,0FF80FF80FF80FF80
       test      rsi,rbx
       jne       short M03_L31
       vpackuswb xmm1,xmm0,xmm0
       vmovd     dword ptr [r8],xmm1
       add       rcx,8
       add       r8,4
       add       r9d,0FFFFFFFC
       vpextrq   rbx,xmm0,1
M03_L31:
       mov       esi,ebx
       test      esi,0FF80FF80
       jne       short M03_L32
       mov       edi,esi
       shr       edi,8
       or        edi,esi
       mov       [r8],di
       add       rcx,4
       add       r8,2
       add       r9d,0FFFFFFFE
       shr       rbx,20
       mov       esi,ebx
M03_L32:
       test      esi,0FF80
       jne       short M03_L33
       test      r9d,r9d
       je        near ptr M03_L68
       jmp       short M03_L34
M03_L33:
       test      esi,0F800
       jne       near ptr M03_L50
       jmp       near ptr M03_L38
M03_L34:
       mov       [r8],sil
       add       rcx,2
       inc       r8
       dec       r9d
       cmp       rcx,rax
       ja        near ptr M03_L59
       mov       esi,[rcx]
       jmp       short M03_L33
M03_L35:
       cmp       r9d,2
       jl        near ptr M03_L68
       jmp       short M03_L39
M03_L36:
       cmp       r9d,4
       jl        short M03_L37
       mov       ebx,esi
       shr       ebx,6
       and       ebx,1F001F
       shl       esi,8
       and       esi,3F003F00
       add       ebx,esi
       add       ebx,80C080C0
       mov       [r8],ebx
       add       rcx,4
       add       r8,4
       add       r9d,0FFFFFFFC
       cmp       rcx,rax
       ja        near ptr M03_L59
       mov       esi,[rcx]
       lea       ebx,[rsi-80]
       movzx     ebx,bx
       cmp       ebx,780
       jl        short M03_L38
       mov       ebx,esi
       jmp       near ptr M03_L49
M03_L37:
       mov       ebx,esi
       jmp       near ptr M03_L61
M03_L38:
       lea       ebx,[rsi-800000]
       cmp       ebx,77FFFFF
       jbe       short M03_L36
       jmp       short M03_L35
M03_L39:
       lea       ebx,[rsi*4]
       and       ebx,1F00
       mov       edi,esi
       and       edi,3F
       lea       ebx,[rbx+rdi+0C080]
       movbe     [r8],bx
       cmp       esi,800000
       jb        short M03_L40
       add       rcx,2
       add       r8,2
       add       r9d,0FFFFFFFE
       cmp       rcx,rax
       ja        near ptr M03_L59
       jmp       short M03_L41
M03_L40:
       cmp       r9d,3
       jl        near ptr M03_L58
       jmp       near ptr M03_L53
M03_L41:
       mov       esi,[rcx]
       jmp       near ptr M03_L50
M03_L42:
       test      esi,0F8000000
       jne       short M03_L44
       jmp       short M03_L45
M03_L43:
       lea       ebx,[rsi+23FF2800]
       test      ebx,0FC00FC00
       je        near ptr M03_L55
       jmp       near ptr M03_L54
M03_L44:
       lea       ebx,[rsi+28000000]
       cmp       ebx,8000000
       jb        short M03_L45
       cmp       r9d,6
       jge       short M03_L46
M03_L45:
       cmp       r9d,3
       jl        near ptr M03_L68
       jmp       short M03_L47
M03_L46:
       lea       ebx,[rsi*4]
       and       ebx,3F00
       mov       edi,esi
       and       edi,3F
       shl       edi,10
       or        ebx,edi
       mov       edi,esi
       shr       edi,4
       and       edi,0F000000
       mov       ebp,esi
       shr       ebp,0C
       and       ebp,0F
       or        edi,ebp
       add       ebx,edi
       add       ebx,0E08080E0
       mov       [r8],ebx
       mov       ebx,esi
       shr       ebx,16
       and       ebx,3F
       shr       esi,8
       and       esi,3F00
       add       ebx,esi
       add       ebx,8080
       mov       [r8+4],bx
       add       rcx,4
       add       r8,6
       add       r9d,0FFFFFFFA
       cmp       rcx,rax
       ja        near ptr M03_L59
       mov       esi,[rcx]
       test      esi,0F800
       jne       near ptr M03_L50
       mov       ebx,esi
       jmp       short M03_L49
M03_L47:
       lea       ebx,[rsi*4]
       and       ebx,3F00
       movzx     edi,si
       shr       edi,0C
       add       ebx,edi
       add       ebx,80E0
       mov       [r8],bx
       mov       ebx,esi
       and       ebx,3F
       or        ebx,0FFFFFF80
       mov       [r8+2],bl
       add       rcx,2
       add       r8,3
       add       r9d,0FFFFFFFD
       cmp       esi,800000
       jb        short M03_L48
       cmp       rcx,rax
       ja        near ptr M03_L59
       jmp       short M03_L51
M03_L48:
       test      r9d,r9d
       je        near ptr M03_L68
       shr       esi,10
       mov       [r8],sil
       add       rcx,2
       inc       r8
       dec       r9d
       cmp       rcx,rax
       ja        near ptr M03_L59
       mov       esi,[rcx]
       test      esi,0F800
       jne       short M03_L50
       mov       ebx,esi
M03_L49:
       test      ebx,0FF80FF80
       je        near ptr M03_L25
       mov       esi,ebx
       jmp       near ptr M03_L32
M03_L50:
       lea       ebx,[rsi-0D800]
       test      ebx,0F800
       je        near ptr M03_L43
       jmp       near ptr M03_L42
M03_L51:
       mov       esi,[rcx]
       jmp       near ptr M03_L32
M03_L52:
       vmovq     xmm0,rbx
       vpackuswb xmm0,xmm0,xmm0
       vmovd     dword ptr [r8],xmm0
       add       rcx,8
       jmp       short M03_L56
M03_L53:
       shr       esi,10
       mov       [r8+2],sil
       add       rcx,4
       add       r8,3
       add       r9d,0FFFFFFFD
       jmp       short M03_L57
M03_L54:
       mov       eax,3
       jmp       near ptr M03_L69
M03_L55:
       cmp       r9d,4
       jl        near ptr M03_L68
       add       esi,40
       mov       ebx,esi
       and       ebx,3
       shl       ebx,14
       or        ebx,808080F0
       mov       edi,esi
       and       edi,3F0700
       bswap     edi
       rol       edi,10
       or        ebx,edi
       mov       edi,esi
       shr       edi,6
       and       edi,0F0000
       or        ebx,edi
       and       esi,0FC
       shl       esi,6
       or        ebx,esi
       mov       [r8],ebx
       add       rcx,4
M03_L56:
       add       r8,4
       add       r9d,0FFFFFFFC
M03_L57:
       cmp       rcx,rax
       jbe       near ptr M03_L23
       jmp       short M03_L59
M03_L58:
       add       rcx,2
       add       r8,2
       jmp       near ptr M03_L68
M03_L59:
       sub       rax,rcx
       mov       rdx,rax
       shr       rdx,3F
       add       rdx,rax
       sar       rdx,1
       add       edx,2
M03_L60:
       test      edx,edx
       je        near ptr M03_L67
       movzx     ebx,word ptr [rcx]
       jmp       short M03_L62
M03_L61:
       movzx     ebx,bx
M03_L62:
       cmp       ebx,7F
       ja        short M03_L63
       test      r9d,r9d
       je        near ptr M03_L68
       mov       [r8],bl
       add       rcx,2
       inc       r8
       jmp       near ptr M03_L66
M03_L63:
       cmp       ebx,800
       jae       short M03_L64
       cmp       r9d,2
       jl        near ptr M03_L68
       mov       r9d,ebx
       and       r9d,3F
       or        r9d,0FFFFFF80
       mov       [r8+1],r9b
       shr       ebx,6
       or        ebx,0FFFFFFC0
       mov       [r8],bl
       add       rcx,2
       add       r8,2
       jmp       short M03_L66
M03_L64:
       lea       eax,[rbx-0D800]
       cmp       eax,7FF
       jbe       short M03_L65
       cmp       r9d,3
       jl        short M03_L68
       mov       eax,ebx
       and       eax,3F
       or        eax,0FFFFFF80
       mov       [r8+2],al
       mov       eax,ebx
       shr       eax,6
       and       eax,3F
       or        eax,0FFFFFF80
       mov       [r8+1],al
       mov       eax,ebx
       shr       eax,0C
       or        eax,0FFFFFFE0
       mov       [r8],al
       add       rcx,2
       add       r8,3
       jmp       short M03_L66
M03_L65:
       cmp       ebx,0DBFF
       ja        near ptr M03_L54
       mov       eax,2
       jmp       short M03_L69
M03_L66:
       cmp       edx,1
       jg        short M03_L68
M03_L67:
       xor       eax,eax
       jmp       short M03_L69
M03_L68:
       mov       eax,1
M03_L69:
       mov       [r10],rcx
       mov       [r11],r8
       vzeroupper
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 1998
```
```assembly
; Org.BouncyCastle.Crypto.Digests.KeccakDigest.Absorb(Byte[], Int32, Int32)
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       rdi,rdx
       mov       ebp,r8d
       mov       esi,r9d
       mov       r9d,[rbx+1C]
       test      r9b,7
       jne       near ptr M04_L10
       cmp       byte ptr [rbx+24],0
       jne       near ptr M04_L11
       sar       r9d,3
       mov       r14d,[rbx+18]
       sar       r14d,3
       mov       r15d,r14d
       sub       r15d,r9d
       cmp       esi,r15d
       jge       near ptr M04_L17
       mov       r8,[rbx+10]
       test      rdi,rdi
       je        near ptr M04_L16
       test      r8,r8
       je        near ptr M04_L16
       mov       rcx,[rdi]
       cmp       rcx,[r8]
       jne       near ptr M04_L16
       cmp       dword ptr [rcx+4],18
       jne       near ptr M04_L16
       mov       edx,esi
       or        edx,ebp
       or        edx,r9d
       jl        near ptr M04_L16
       lea       edx,[rsi+rbp]
       cmp       edx,[rdi+8]
       ja        near ptr M04_L16
       lea       edx,[r9+rsi]
       cmp       edx,[r8+8]
       ja        near ptr M04_L16
       movzx     edx,word ptr [rcx]
       mov       eax,esi
       imul      rax,rdx
       mov       r10d,ebp
       imul      r10,rdx
       lea       r10,[rdi+r10+10]
       mov       r9d,r9d
       imul      rdx,r9
       lea       r9,[r8+rdx+10]
       test      dword ptr [rcx],1000000
       jne       near ptr M04_L12
       mov       rcx,r9
       mov       rdx,r10
       mov       r8,rax
       mov       r11,rcx
       sub       r11,rdx
       cmp       r11,r8
       jb        near ptr M04_L14
       mov       r11,rdx
       sub       r11,rcx
       cmp       r11,r8
       jb        near ptr M04_L14
       lea       r11,[rdx+r8]
       lea       rdi,[rcx+r8]
       cmp       r8,10
       ja        short M04_L02
       test      al,18
       je        short M04_L00
       mov       rax,[r10]
       mov       [r9],rax
       mov       r10,[r11-8]
       mov       [rdi-8],r10
       jmp       short M04_L05
M04_L00:
       test      al,4
       je        short M04_L01
       mov       eax,[r10]
       mov       [r9],eax
       mov       r10d,[r11-4]
       mov       [rdi-4],r10d
       jmp       short M04_L05
M04_L01:
       test      rax,rax
       je        short M04_L05
       movzx     r8d,byte ptr [r10]
       mov       [r9],r8b
       test      al,2
       je        short M04_L05
       movsx     r9,word ptr [r11-2]
       mov       [rdi-2],r9w
       jmp       short M04_L05
M04_L02:
       cmp       r8,40
       ja        short M04_L07
M04_L03:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       jbe       short M04_L04
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M04_L04
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
M04_L04:
       vmovups   xmm0,[r11-10]
       vmovups   [rdi-10],xmm0
M04_L05:
       shl       esi,3
       add       [rbx+1C],esi
M04_L06:
       vzeroupper
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M04_L07:
       cmp       r8,800
       ja        near ptr M04_L15
       cmp       r8,100
       jae       near ptr M04_L13
M04_L08:
       mov       r10,r8
       shr       r10,6
M04_L09:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r10
       jne       short M04_L09
       and       r8,3F
       cmp       r8,10
       ja        near ptr M04_L03
       jmp       short M04_L04
M04_L10:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,28F39
       mov       rdx,7FF9F8257D00
       call      qword ptr [7FF9F7D97738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F7F65D28]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M04_L11:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,28F89
       mov       rdx,7FF9F8257D00
       call      qword ptr [7FF9F7D97738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F7F65D28]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M04_L12:
       mov       rcx,r9
       mov       rdx,r10
       mov       r8,rax
       call      qword ptr [7FF9F7B157A0]; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M04_L05
M04_L13:
       mov       rdx,r9
       and       rdx,3F
       mov       r8,rdx
       neg       r8
       add       r8,40
       vmovdqu   ymm0,ymmword ptr [r10]
       vmovdqu   ymmword ptr [r9],ymm0
       vmovdqu   ymm0,ymmword ptr [r10+20]
       vmovdqu   ymmword ptr [r9+20],ymm0
       lea       rdx,[r10+r8]
       lea       rcx,[r9+r8]
       sub       rax,r8
       mov       r8,rax
       jmp       near ptr M04_L08
M04_L14:
       cmp       r9,r10
       jne       short M04_L15
       cmp       [r10],r10b
       jmp       near ptr M04_L05
M04_L15:
       cmp       [r9],r9b
       cmp       [r10],r10b
       mov       rcx,r9
       mov       rdx,r10
       mov       r8,rax
       call      qword ptr [7FF9F7B166E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M04_L05
M04_L16:
       mov       [rsp+20],esi
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rdi
       mov       edx,ebp
       call      qword ptr [7FF9F838CC90]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M04_L05
M04_L17:
       xor       r13d,r13d
       test      r9d,r9d
       jle       short M04_L19
       mov       [rsp+20],r15d
       mov       r8,[rbx+10]
       mov       rcx,rdi
       mov       edx,ebp
       call      qword ptr [7FF9F80FC858]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       r13d,r15d
       mov       rdx,[rbx+10]
       mov       rcx,rbx
       xor       r8d,r8d
       call      qword ptr [7FF9F81F7588]
       jmp       short M04_L19
M04_L18:
       lea       r8d,[rbp+r13]
       mov       rcx,rbx
       mov       rdx,rdi
       call      qword ptr [7FF9F81F7588]
       add       r13d,r14d
M04_L19:
       mov       r15d,esi
       sub       r15d,r13d
       cmp       r15d,r14d
       jge       short M04_L18
       mov       [rsp+20],r15d
       lea       edx,[rbp+r13]
       mov       r8,[rbx+10]
       mov       rcx,rdi
       xor       r9d,r9d
       call      qword ptr [7FF9F80FC858]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       shl       r15d,3
       mov       [rbx+1C],r15d
       jmp       near ptr M04_L06
; Total bytes of code 869
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
       mov       rcx,2314C000C90
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
       jle       short M05_L02
       mov       rcx,[rcx+240]
       mov       rax,[rcx+48]
       test      rax,rax
       je        short M05_L02
M05_L00:
       mov       rcx,[rax+10]
       test      rcx,rcx
       je        short M05_L04
       mov       eax,[rcx+8]
       cmp       eax,ebp
       jbe       short M05_L04
       mov       eax,ebp
       shl       rax,4
       mov       r14,[rcx+rax+10]
       test      r14,r14
       je        short M05_L04
       xor       edx,edx
       mov       [rcx+rax+10],rdx
       cmp       byte ptr [rdi+9D],0
       jne       short M05_L03
M05_L01:
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
M05_L02:
       mov       ecx,9
       call      qword ptr [7FF9F838D488]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       short M05_L00
M05_L03:
       mov       rcx,r14
       call      qword ptr [7FF9F800C918]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       ebx,eax
       mov       r15d,[r14+8]
       cmp       [rsi],sil
       mov       rcx,rsi
       call      qword ptr [7FF9F800C918]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       [rsp+20],ebp
       mov       edx,ebx
       mov       r8d,r15d
       mov       rcx,rdi
       call      qword ptr [7FF9F838D4A0]
       jmp       short M05_L01
M05_L04:
       mov       rcx,[rsi+10]
       cmp       [rcx+8],ebp
       jbe       near ptr M05_L16
       mov       eax,ebp
       mov       rcx,[rcx+rax*8+10]
       test      rcx,rcx
       je        near ptr M05_L15
       mov       r14,[rcx+8]
       mov       rcx,offset MT_System.Threading.ProcessorIdCache
       call      qword ptr [7FF9F7B15740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       cmp       byte ptr [7FF9F7A5B1CC],0
       je        short M05_L05
       call      qword ptr [7FF9F838D4B8]
       mov       ebx,eax
       jmp       short M05_L07
M05_L05:
       mov       ecx,0A
       call      qword ptr [7FF9F838D4D0]
       mov       ebx,[rax+10]
       mov       ecx,0A
       call      qword ptr [7FF9F838D4D0]
       lea       ecx,[rbx-1]
       mov       [rax+10],ecx
       movzx     eax,bx
       test      eax,eax
       jne       short M05_L06
       call      qword ptr [7FF9F838D4E8]
       mov       ebx,eax
       jmp       short M05_L07
M05_L06:
       sar       ebx,10
M05_L07:
       mov       rcx,offset MT_System.Buffers.SharedArrayPoolStatics
       call      qword ptr [7FF9F7B15740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       eax,ebx
       xor       edx,edx
       div       dword ptr [7FF9F7A5B1C0]
       mov       ebx,edx
       xor       r15d,r15d
       jmp       short M05_L11
M05_L08:
       cmp       ebx,[r14+8]
       jae       near ptr M05_L21
       mov       ecx,ebx
       mov       r13,[r14+rcx*8+10]
       cmp       [r13],r13b
       xor       r12d,r12d
       mov       rcx,r13
       call      qword ptr [7FF9F80FD5D8]; System.Threading.Monitor.Enter(System.Object)
       mov       rcx,[r13+8]
       mov       eax,[r13+10]
       dec       eax
       cmp       [rcx+8],eax
       jbe       short M05_L09
       mov       edx,eax
       mov       r12,[rcx+rdx*8+10]
       mov       edx,eax
       xor       r8d,r8d
       mov       [rcx+rdx*8+10],r8
       mov       [r13+10],eax
M05_L09:
       mov       rcx,r13
       call      qword ptr [7FF9F7B16820]; System.Threading.Monitor.Exit(System.Object)
       test      r12,r12
       jne       short M05_L12
       inc       ebx
       cmp       [r14+8],ebx
       jne       short M05_L10
       xor       ebx,ebx
M05_L10:
       inc       r15d
M05_L11:
       cmp       [r14+8],r15d
       jg        short M05_L08
       jmp       short M05_L13
M05_L12:
       mov       r14,r12
       jmp       short M05_L14
M05_L13:
       xor       r14d,r14d
M05_L14:
       test      r14,r14
       je        short M05_L15
       cmp       byte ptr [rdi+9D],0
       je        near ptr M05_L01
       mov       rcx,r14
       call      qword ptr [7FF9F800C918]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       ebx,eax
       mov       r15d,[r14+8]
       mov       rcx,rsi
       call      qword ptr [7FF9F800C918]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       [rsp+20],ebp
       mov       edx,ebx
       mov       r8d,r15d
       mov       rcx,rdi
       call      qword ptr [7FF9F838D4A0]
       jmp       near ptr M05_L01
M05_L15:
       mov       ecx,10
       shlx      ebx,ecx,ebp
       jmp       short M05_L18
M05_L16:
       test      ebx,ebx
       jne       short M05_L17
       mov       rax,271E10362A0
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
M05_L17:
       mov       ecx,ebx
       mov       rdx,271E1036F28
       call      qword ptr [7FF9F7D9D770]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
M05_L18:
       cmp       ebx,800
       jge       short M05_L19
       movsxd    rdx,ebx
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
       jmp       short M05_L20
M05_L19:
       mov       ecx,ebx
       xor       edx,edx
       call      qword ptr [7FF9F838D440]
       mov       r14,rax
M05_L20:
       cmp       byte ptr [rdi+9D],0
       je        near ptr M05_L01
       cmp       [r14],r14b
       mov       rcx,r14
       call      qword ptr [7FF9F800C918]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       ebx,eax
       mov       r15d,[r14+8]
       mov       rcx,rsi
       call      qword ptr [7FF9F800C918]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       edx,ebx
       mov       r8d,r15d
       mov       rcx,rdi
       call      qword ptr [7FF9F838D4A0]
       mov       r15d,[r14+8]
       mov       rcx,rsi
       call      qword ptr [7FF9F800C918]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
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
       call      qword ptr [7FF9F838D500]
       jmp       near ptr M05_L01
M05_L21:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 798
```
```assembly
; Org.BouncyCastle.Crypto.Digests.KeccakDigest.Squeeze(Byte[], Int32, Int64)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       rbx,rcx
       mov       rsi,rdx
       mov       ebp,r8d
       mov       rdi,r9
       cmp       byte ptr [rbx+24],0
       jne       short M06_L00
       mov       rcx,rbx
       call      qword ptr [7FF9F81FFD20]; Org.BouncyCastle.Crypto.Digests.KeccakDigest.PadAndSwitchToSqueezingPhase()
M06_L00:
       test      dil,7
       jne       near ptr M06_L17
       xor       r14d,r14d
       cmp       r14,rdi
       jge       near ptr M06_L13
M06_L01:
       cmp       dword ptr [rbx+1C],0
       jne       near ptr M06_L05
       mov       rcx,rbx
       call      qword ptr [7FF9F81FFD98]; Org.BouncyCastle.Crypto.Digests.KeccakDigest.KeccakPermutation()
       mov       rcx,[rbx+8]
       mov       edx,[rbx+18]
       sar       edx,6
       mov       r8,[rbx+10]
       xor       eax,eax
       xor       r10d,r10d
       cmp       eax,edx
       jge       near ptr M06_L04
M06_L02:
       cmp       eax,[rcx+8]
       jae       near ptr M06_L25
       mov       r9,[rcx+rax*8+10]
       mov       r11d,r9d
       mov       r15d,[r8+8]
       mov       r13d,r15d
       test      r10d,r10d
       jl        near ptr M06_L18
       lea       r12d,[r13-7]
       cmp       r10d,r12d
       jge       near ptr M06_L18
       mov       [r8+r10+10],r11b
       lea       r12d,[r10+1]
       mov       r13d,r12d
       mov       r12d,r11d
       shr       r12d,8
       mov       [r8+r13+10],r12b
       lea       r13d,[r10+2]
       mov       r15d,r13d
       mov       r13d,r11d
       shr       r13d,10
       mov       [r8+r15+10],r13b
       lea       r15d,[r10+3]
       shr       r11d,18
       mov       [r8+r15+10],r11b
       shr       r9,20
       lea       r11d,[r10+4]
       mov       r15d,r11d
       mov       [r8+r15+10],r9b
       lea       r15d,[r11+1]
       mov       r13d,r9d
       shr       r13d,8
       mov       [r8+r15+10],r13b
       lea       r15d,[r11+2]
       mov       r13d,r9d
       shr       r13d,10
       mov       [r8+r15+10],r13b
       add       r11d,3
       shr       r9d,18
       mov       [r8+r11+10],r9b
M06_L03:
       add       r10d,8
       inc       eax
       cmp       eax,edx
       jl        near ptr M06_L02
M06_L04:
       mov       ecx,[rbx+18]
       mov       [rbx+1C],ecx
M06_L05:
       mov       ecx,[rbx+1C]
       movsxd    r15,ecx
       mov       r13,rdi
       sub       r13,r14
       cmp       r15,r13
       jle       near ptr M06_L19
M06_L06:
       mov       rax,[rbx+10]
       mov       edx,[rbx+18]
       sub       edx,ecx
       sar       edx,3
       mov       r9,r14
       sar       r9,3
       add       r9d,ebp
       mov       r15d,r13d
       sar       r15d,3
       test      rax,rax
       je        near ptr M06_L24
       test      rsi,rsi
       je        near ptr M06_L24
       mov       rcx,[rax]
       cmp       rcx,[rsi]
       jne       near ptr M06_L24
       cmp       dword ptr [rcx+4],18
       jne       near ptr M06_L24
       mov       r8d,r15d
       or        r8d,edx
       or        r8d,r9d
       jl        near ptr M06_L24
       lea       r8d,[rdx+r15]
       cmp       r8d,[rax+8]
       ja        near ptr M06_L24
       lea       r8d,[r9+r15]
       cmp       r8d,[rsi+8]
       ja        near ptr M06_L24
       movzx     r8d,word ptr [rcx]
       mov       r10d,r15d
       imul      r10,r8
       imul      rdx,r8
       lea       rdx,[rax+rdx+10]
       mov       eax,r9d
       imul      r8,rax
       lea       rax,[rsi+r8+10]
       test      dword ptr [rcx],1000000
       jne       near ptr M06_L20
       mov       rcx,rax
       mov       r8,rdx
       mov       r9,r10
       mov       r11,rcx
       sub       r11,r8
       cmp       r11,r9
       jb        near ptr M06_L22
       mov       r11,r8
       sub       r11,rcx
       cmp       r11,r9
       jb        near ptr M06_L22
       lea       r11,[r8+r9]
       lea       r15,[rcx+r9]
       cmp       r9,10
       ja        short M06_L09
       test      r10b,18
       je        short M06_L07
       mov       r10,[rdx]
       mov       [rax],r10
       mov       rdx,[r11-8]
       mov       [r15-8],rdx
       jmp       short M06_L12
M06_L07:
       test      r10b,4
       je        short M06_L08
       mov       r10d,[rdx]
       mov       [rax],r10d
       mov       edx,[r11-4]
       mov       [r15-4],edx
       jmp       short M06_L12
M06_L08:
       test      r10,r10
       je        short M06_L12
       movzx     r9d,byte ptr [rdx]
       mov       [rax],r9b
       test      r10b,2
       je        short M06_L12
       movsx     rax,word ptr [r11-2]
       mov       [r15-2],ax
       jmp       short M06_L12
M06_L09:
       cmp       r9,40
       ja        short M06_L14
M06_L10:
       vmovups   xmm0,[r8]
       vmovups   [rcx],xmm0
       cmp       r9,20
       jbe       short M06_L11
       vmovups   xmm0,[r8+10]
       vmovups   [rcx+10],xmm0
       cmp       r9,30
       jbe       short M06_L11
       vmovups   xmm0,[r8+20]
       vmovups   [rcx+20],xmm0
M06_L11:
       vmovups   xmm0,[r11-10]
       vmovups   [r15-10],xmm0
M06_L12:
       sub       [rbx+1C],r13d
       movsxd    rcx,r13d
       add       r14,rcx
       cmp       r14,rdi
       jl        near ptr M06_L01
M06_L13:
       vzeroupper
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
M06_L14:
       cmp       r9,800
       ja        near ptr M06_L23
       cmp       r9,100
       jae       near ptr M06_L21
M06_L15:
       mov       rax,r9
       shr       rax,6
M06_L16:
       vmovdqu   ymm0,ymmword ptr [r8]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [r8+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       r8,40
       dec       rax
       jne       short M06_L16
       and       r9,3F
       cmp       r9,10
       ja        near ptr M06_L10
       jmp       near ptr M06_L11
M06_L17:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,2900F
       mov       rdx,7FF9F8257D00
       call      qword ptr [7FF9F7D97738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F7F65D28]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M06_L18:
       cmp       r10d,r13d
       jae       near ptr M06_L25
       mov       [r8+r10+10],r11b
       lea       r12d,[r10+1]
       cmp       r12d,r15d
       jae       near ptr M06_L25
       mov       r13d,r12d
       mov       r12d,r11d
       shr       r12d,8
       mov       [r8+r13+10],r12b
       lea       r13d,[r10+2]
       cmp       r13d,r15d
       jae       near ptr M06_L25
       mov       r12d,r11d
       shr       r12d,10
       mov       [r8+r13+10],r12b
       lea       r13d,[r10+3]
       cmp       r13d,r15d
       jae       near ptr M06_L25
       shr       r11d,18
       mov       [r8+r13+10],r11b
       shr       r9,20
       lea       r11d,[r10+4]
       cmp       r11d,r15d
       jae       near ptr M06_L25
       mov       r13d,r11d
       mov       [r8+r13+10],r9b
       lea       r13d,[r11+1]
       cmp       r13d,r15d
       jae       near ptr M06_L25
       mov       r12d,r9d
       shr       r12d,8
       mov       [r8+r13+10],r12b
       lea       r13d,[r11+2]
       cmp       r13d,r15d
       jae       near ptr M06_L25
       mov       r12d,r9d
       shr       r12d,10
       mov       [r8+r13+10],r12b
       add       r11d,3
       cmp       r11d,r15d
       jae       near ptr M06_L25
       shr       r9d,18
       mov       [r8+r11+10],r9b
       jmp       near ptr M06_L03
M06_L19:
       mov       r13,r15
       jmp       near ptr M06_L06
M06_L20:
       mov       rcx,rax
       mov       r8,r10
       call      qword ptr [7FF9F7B157A0]; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M06_L12
M06_L21:
       mov       r8,rax
       and       r8,3F
       mov       r9,r8
       neg       r9
       add       r9,40
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rax],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rax+20],ymm0
       lea       r8,[rdx+r9]
       lea       rcx,[rax+r9]
       sub       r10,r9
       mov       r9,r10
       jmp       near ptr M06_L15
M06_L22:
       cmp       rax,rdx
       jne       short M06_L23
       cmp       [rdx],dl
       jmp       near ptr M06_L12
M06_L23:
       cmp       [rax],al
       cmp       [rdx],dl
       mov       rcx,rax
       mov       r8,r10
       call      qword ptr [7FF9F7B166E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M06_L12
M06_L24:
       mov       [rsp+20],r15d
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rax
       mov       r8,rsi
       call      qword ptr [7FF9F838CC90]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M06_L12
M06_L25:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1180
```
```assembly
; Org.BouncyCastle.Crypto.Digests.KeccakDigest.Reset()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,[rbx+20]
       cmp       esi,100
       jg        near ptr M07_L07
       cmp       esi,80
       jne       near ptr M07_L05
M07_L00:
       add       esi,esi
       neg       esi
       add       esi,640
       mov       ecx,esi
       sub       ecx,1
       cmp       ecx,63E
       ja        near ptr M07_L08
       test      sil,3F
       jne       near ptr M07_L08
       mov       [rbx+18],esi
       mov       rcx,[rbx+8]
       mov       rdx,rcx
       mov       ecx,[rcx+8]
       lea       rax,[rdx+10]
       xor       r8d,r8d
       mov       r10,[rdx]
       cmp       dword ptr [r10+4],18
       jne       near ptr M07_L09
M07_L01:
       mov       r9d,r8d
       neg       r9d
       test      r8d,r8d
       jg        near ptr M07_L10
       test      r9d,r9d
       jl        near ptr M07_L10
       lea       r8d,[r9+rcx]
       cmp       r8d,[rdx+8]
       ja        near ptr M07_L10
       movzx     edx,word ptr [r10]
       mov       r8d,r9d
       imul      r8,rdx
       add       r8,rax
       mov       ecx,ecx
       imul      rdx,rcx
       test      dword ptr [r10],1000000
       jne       near ptr M07_L11
       mov       rcx,r8
       call      qword ptr [7FF9F7B157E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
M07_L02:
       mov       rax,[rbx+10]
       mov       ecx,[rax+8]
       mov       edx,ecx
       test      edx,edx
       jle       short M07_L04
M07_L03:
       dec       edx
       cmp       edx,ecx
       jae       near ptr M07_L12
       mov       byte ptr [rax+rdx+10],0
       test      edx,edx
       jg        short M07_L03
M07_L04:
       xor       eax,eax
       mov       [rbx+1C],eax
       mov       byte ptr [rbx+24],0
       mov       eax,esi
       neg       eax
       add       eax,640
       sar       eax,1
       mov       [rbx+20],eax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M07_L05:
       cmp       esi,0E0
       je        near ptr M07_L00
       cmp       esi,100
       je        near ptr M07_L00
M07_L06:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,28E9F
       mov       rdx,7FF9F8257D00
       call      qword ptr [7FF9F7D97738]
       mov       rbx,rax
       mov       ecx,28EFF
       mov       rdx,7FF9F8257D00
       call      qword ptr [7FF9F7D97738]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9F7F65DD0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M07_L07:
       cmp       esi,120
       je        near ptr M07_L00
       cmp       esi,180
       je        near ptr M07_L00
       cmp       esi,200
       jne       short M07_L06
       jmp       near ptr M07_L00
M07_L08:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,28F13
       mov       rdx,7FF9F8257D00
       call      qword ptr [7FF9F7D97738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F7F65D28]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M07_L09:
       mov       r9d,[r10+4]
       add       r9d,0FFFFFFE8
       shr       r9d,3
       movsxd    r8,r9d
       mov       r8d,[rax+r8*4]
       shl       r9d,3
       movsxd    r9,r9d
       add       rax,r9
       jmp       near ptr M07_L01
M07_L10:
       call      qword ptr [7FF9F838CCD8]
       int       3
M07_L11:
       shr       rdx,3
       mov       rcx,r8
       call      qword ptr [7FF9F838CCF0]
       jmp       near ptr M07_L02
M07_L12:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 522
```
```assembly
; System.Convert.ToBase64String(Byte[], Int32, Int32, System.Base64FormattingOptions)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+30],ymm4
       mov       [rsp+50],rax
       mov       esi,edx
       mov       ebx,r8d
       mov       edi,r9d
       test      rcx,rcx
       je        near ptr M08_L12
       test      ebx,ebx
       jl        near ptr M08_L13
       test      esi,esi
       jl        near ptr M08_L14
       mov       eax,[rcx+8]
       mov       ebp,eax
       sub       ebp,ebx
       cmp       esi,ebp
       jl        short M08_L00
       cmp       esi,ebp
       jg        short M08_L01
M08_L00:
       mov       edx,esi
       mov       r8d,ebx
       add       r8,rdx
       mov       eax,eax
       cmp       r8,rax
       ja        near ptr M08_L15
       lea       rbp,[rcx+rdx+10]
       cmp       edi,1
       ja        near ptr M08_L16
       test      ebx,ebx
       jne       short M08_L02
       mov       rax,271E1030008
       jmp       near ptr M08_L10
M08_L01:
       mov       ecx,1149
       mov       rdx,7FF9F7A54000
       call      qword ptr [7FF9F7D97738]
       mov       r8,rax
       mov       edx,ebp
       mov       ecx,esi
       call      qword ptr [7FF9F838D548]
       int       3
M08_L02:
       cmp       edi,1
       sete      dil
       movzx     edi,dil
       lea       ecx,[rbx+2]
       mov       eax,0AAAAAAAB
       mov       edx,ecx
       imul      rax,rdx
       shr       rax,21
       shl       eax,2
       je        short M08_L04
       test      edi,edi
       je        short M08_L03
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
M08_L03:
       test      eax,eax
       jl        near ptr M08_L17
       jmp       short M08_L05
M08_L04:
       xor       eax,eax
M08_L05:
       movsxd    rdx,eax
       mov       rcx,offset MT_System.String
       call      00007FFA57738D20
       mov       rsi,rax
       test      edi,edi
       jne       short M08_L06
       cmp       ebx,10
       jge       short M08_L11
M08_L06:
       mov       [rsp+50],rbp
       mov       rdx,rbp
       test      rsi,rsi
       je        short M08_L07
       lea       rcx,[rsi+0C]
       mov       [rsp+48],rcx
       mov       rcx,[rsp+48]
       jmp       short M08_L08
M08_L07:
       xor       ecx,ecx
M08_L08:
       mov       [rsp+20],edi
       mov       r9d,ebx
       xor       r8d,r8d
       call      qword ptr [7FF9F838D5F0]
       xor       ecx,ecx
       mov       [rsp+48],rcx
       mov       [rsp+50],rcx
M08_L09:
       mov       rax,rsi
M08_L10:
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M08_L11:
       lea       rcx,[rsi+0C]
       mov       r8d,[rsi+8]
       mov       edx,r8d
       mov       [rsp+38],rbp
       mov       [rsp+40],ebx
       mov       [rsp+28],rcx
       mov       [rsp+30],edx
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+28]
       call      qword ptr [7FF9F8004150]; System.Convert.ToBase64CharsLargeNoLineBreaks(System.ReadOnlySpan`1<Byte>, System.Span`1<Char>, Int32)
       jmp       short M08_L09
M08_L12:
       mov       ecx,1139
       mov       rdx,7FF9F7A54000
       call      qword ptr [7FF9F7D97738]
       mov       rcx,rax
       call      qword ptr [7FF9F838C888]
       int       3
M08_L13:
       mov       ecx,0B3
       mov       rdx,7FF9F7A54000
       call      qword ptr [7FF9F7D97738]
       mov       rdx,rax
       mov       ecx,ebx
       call      qword ptr [7FF9F838D428]
       int       3
M08_L14:
       mov       ecx,1149
       mov       rdx,7FF9F7A54000
       call      qword ptr [7FF9F7D97738]
       mov       rdx,rax
       mov       ecx,esi
       call      qword ptr [7FF9F838D428]
       int       3
M08_L15:
       call      qword ptr [7FF9F7CB7138]
       int       3
M08_L16:
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9F838D608]
       mov       rsi,rax
       mov       [rbx+8],edi
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9F838D620]
       mov       rbx,rax
       mov       ecx,1157
       mov       rdx,7FF9F7A54000
       call      qword ptr [7FF9F7D97738]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FF9F7F65DD0]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M08_L17:
       mov       rcx,offset MT_System.OutOfMemoryException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       call      qword ptr [7FF9F838D5D8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 649
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
       call      qword ptr [7FF9F7B157E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
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
       mov       rcx,2314C000C90
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
       call      qword ptr [7FF9F838D488]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M09_L00
M09_L06:
       mov       rcx,rdi
       call      qword ptr [7FF9F81FFEA0]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
       mov       r15,rax
       jmp       near ptr M09_L01
M09_L07:
       mov       ecx,2
       call      qword ptr [7FF9F7D9C1C8]
       int       3
M09_L08:
       shr       rdx,3
       mov       rcx,rax
       call      qword ptr [7FF9F838CCF0]
       jmp       near ptr M09_L02
M09_L09:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       call      qword ptr [7FF9F838DCB0]
       mov       rbx,rax
       mov       ecx,29B
       mov       rdx,7FF9F7A54000
       call      qword ptr [7FF9F7D97738]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rbp
       call      qword ptr [7FF9F7F65DD0]
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
       call      qword ptr [7FF9F838DCC8]
M09_L11:
       mov       r12,[rax+8]
       mov       rcx,offset MT_System.Threading.ProcessorIdCache
       call      qword ptr [7FF9F7B15740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       cmp       byte ptr [7FF9F7A5B1CC],0
       je        short M09_L12
       call      qword ptr [7FF9F838D4B8]
       mov       esi,eax
       jmp       short M09_L14
M09_L12:
       mov       ecx,0A
       call      qword ptr [7FF9F838D4D0]
       mov       esi,[rax+10]
       mov       ecx,0A
       call      qword ptr [7FF9F838D4D0]
       lea       ecx,[rsi-1]
       mov       [rax+10],ecx
       movzx     eax,si
       test      eax,eax
       jne       short M09_L13
       call      qword ptr [7FF9F838D4E8]
       mov       esi,eax
       jmp       short M09_L14
M09_L13:
       sar       esi,10
M09_L14:
       mov       rcx,offset MT_System.Buffers.SharedArrayPoolStatics
       call      qword ptr [7FF9F7B15740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       eax,esi
       xor       edx,edx
       div       dword ptr [7FF9F7A5B1C0]
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
       call      qword ptr [7FF9F80FD5D8]; System.Threading.Monitor.Enter(System.Object)
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
       call      qword ptr [7FF9F7B16820]; System.Threading.Monitor.Exit(System.Object)
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
       call      qword ptr [7FF9F800C918]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r15d,eax
       mov       [rsp+44],ebp
       cmp       [rdi],dil
       mov       rcx,rdi
       call      qword ptr [7FF9F800C918]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,rsi
       mov       r8d,r15d
       mov       r9d,[rsp+44]
       mov       edx,3
       call      qword ptr [7FF9F838DCE0]
       test      r12d,r13d
       jne       near ptr M09_L04
       mov       rcx,rbx
       call      qword ptr [7FF9F800C918]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       ebx,eax
       mov       rcx,rdi
       call      qword ptr [7FF9F800C918]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
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
       call      qword ptr [7FF9F838DCF8]
       jmp       near ptr M09_L04
M09_L28:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 915
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Security.PasswordHasherBenchmark.HashPasswordShake256()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       lea       rbp,[rsp+0C0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-60],ymm4
       xor       eax,eax
       mov       [rbp-40],rax
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
       jne       near ptr M00_L12
M00_L00:
       mov       r9d,r8d
       neg       r9d
       test      r8d,r8d
       jg        near ptr M00_L11
       test      r9d,r9d
       jl        near ptr M00_L11
       lea       r8d,[r9+rcx]
       cmp       r8d,[rdx+8]
       ja        near ptr M00_L11
       movzx     edx,word ptr [r10]
       mov       r8d,r9d
       imul      r8,rdx
       add       r8,rax
       mov       ecx,ecx
       imul      rdx,rcx
       test      dword ptr [r10],1000000
       jne       near ptr M00_L13
       mov       rcx,r8
       call      qword ptr [7FF9F7AE57E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
M00_L01:
       mov       r8,[rbx+10]
       mov       r9d,[r8+8]
       mov       ecx,r9d
       test      ecx,ecx
       jle       short M00_L03
M00_L02:
       dec       ecx
       cmp       ecx,r9d
       jae       near ptr M00_L19
       mov       byte ptr [r8+rcx+10],0
       test      ecx,ecx
       jg        short M00_L02
M00_L03:
       xor       r8d,r8d
       mov       [rbx+1C],r8d
       mov       byte ptr [rbx+24],0
       mov       dword ptr [rbx+20],100
       mov       r8,2025D400220
       mov       rsi,[r8]
       mov       r8,242F25806A4
       mov       [rbp-40],r8
       mov       rdi,[rbp-40]
       lea       r8,[rbp-48]
       lea       r9,[rbp-50]
       mov       rcx,rdi
       mov       edx,40
       call      qword ptr [7FF9F7AEFAB0]; System.Text.Unicode.Utf16Utility.GetPointerToFirstInvalidChar(Char*, Int32, Int64 ByRef, Int32 ByRef)
       sub       rax,rdi
       mov       r9,rax
       shr       r9,3F
       add       r9,rax
       sar       r9,1
       movsxd    r14,r9d
       add       r14,[rbp-48]
       cmp       r14,7FFFFFFF
       ja        near ptr M00_L15
       cmp       r9d,40
       jne       near ptr M00_L14
M00_L04:
       xor       edx,edx
       mov       [rbp-40],rdx
       movsxd    rdx,r14d
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rdi,rax
       mov       r14d,[rdi+8]
       test      r14d,r14d
       jl        near ptr M00_L16
       mov       rcx,242F25806A4
       mov       [rbp-58],rcx
       mov       r15,[rbp-58]
       mov       [rbp-60],rdi
       test      r14d,r14d
       je        near ptr M00_L17
       lea       r13,[rdi+10]
M00_L05:
       mov       r12d,r14d
       lea       rcx,[rbp-68]
       mov       [rsp+20],rcx
       lea       rcx,[rbp-70]
       mov       [rsp+28],rcx
       mov       rcx,r15
       mov       edx,40
       mov       r8,r13
       mov       r9d,r12d
       call      qword ptr [7FF9F7AEFAE0]; System.Text.Unicode.Utf8Utility.TranscodeToUtf8(Char*, Int32, Byte*, Int32, Char* ByRef, Byte* ByRef)
       mov       rcx,[rbp-68]
       sub       rcx,r15
       mov       rdx,rcx
       shr       rdx,3F
       add       rcx,rdx
       sar       rcx,1
       mov       edx,[rbp-70]
       sub       edx,r13d
       cmp       ecx,40
       jne       near ptr M00_L18
M00_L06:
       xor       ecx,ecx
       mov       [rbp-58],rcx
       mov       [rbp-60],rcx
       mov       rdx,rdi
       mov       r9d,r14d
       mov       rcx,rbx
       xor       r8d,r8d
       call      qword ptr [7FF9F81C7498]; Org.BouncyCastle.Crypto.Digests.KeccakDigest.Absorb(Byte[], Int32, Int32)
       mov       rcx,2025D4020C0
       mov       rsi,[rcx]
       mov       rcx,rsi
       mov       edx,20
       call      qword ptr [7FF9F8225ED0]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Rent(Int32)
       mov       [rbp-78],rax
       cmp       byte ptr [rbx+24],0
       jne       short M00_L07
       mov       ecx,[rbx+1C]
       test      cl,7
       jne       short M00_L08
       mov       rax,[rbx+10]
       mov       edx,ecx
       sar       edx,3
       cmp       edx,[rax+8]
       jae       near ptr M00_L09
       mov       byte ptr [rax+rdx+10],0F
       add       ecx,4
       mov       [rbx+1C],ecx
M00_L07:
       mov       rcx,rbx
       mov       rdx,[rbp-78]
       xor       r8d,r8d
       mov       r9d,100
       call      qword ptr [7FF9F81CFC30]; Org.BouncyCastle.Crypto.Digests.KeccakDigest.Squeeze(Byte[], Int32, Int64)
       mov       rcx,rbx
       call      qword ptr [7FF9F8224590]; Org.BouncyCastle.Crypto.Digests.KeccakDigest.Reset()
       mov       rcx,[rbp-78]
       xor       edx,edx
       mov       r8d,20
       xor       r9d,r9d
       call      qword ptr [7FF9F81CFDB0]; System.Convert.ToBase64String(Byte[], Int32, Int32, System.Base64FormattingOptions)
       mov       rbx,rax
       jmp       short M00_L10
M00_L08:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,28F39
       mov       rdx,7FF9F8223BD0
       call      qword ptr [7FF9F7D67738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F7F35D28]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       int       3
M00_L10:
       mov       rcx,rsi
       mov       rdx,[rbp-78]
       mov       r8d,1
       call      qword ptr [7FF9F8225ED8]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Return(Byte[], Boolean)
       mov       rax,rbx
       add       rsp,88
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L11:
       call      qword ptr [7FF9F835CE88]
       int       3
M00_L12:
       mov       r9d,[r10+4]
       add       r9d,0FFFFFFE8
       shr       r9d,3
       movsxd    r8,r9d
       mov       r8d,[rax+r8*4]
       shl       r9d,3
       movsxd    r9,r9d
       add       rax,r9
       jmp       near ptr M00_L00
M00_L13:
       shr       rdx,3
       mov       rcx,r8
       call      qword ptr [7FF9F835CEA0]
       jmp       near ptr M00_L01
M00_L14:
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8d,40
       call      qword ptr [7FF9F835D200]
       add       r14d,eax
       jns       near ptr M00_L04
M00_L15:
       call      qword ptr [7FF9F835D218]
       int       3
M00_L16:
       mov       ecx,0B
       xor       edx,edx
       call      qword ptr [7FF9F8145908]
       int       3
M00_L17:
       xor       r13d,r13d
       jmp       near ptr M00_L05
M00_L18:
       mov       [rsp+20],r12d
       mov       [rsp+28],ecx
       mov       [rsp+30],edx
       mov       dword ptr [rsp+38],1
       mov       rcx,rsi
       mov       rdx,r15
       mov       r8d,40
       mov       r9,r13
       call      qword ptr [7FF9F835D368]
       jmp       near ptr M00_L06
M00_L19:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       sub       rsp,48
       mov       rcx,2025D4020C0
       mov       rsi,[rcx]
       mov       rcx,rsi
       mov       rdx,[rbp-78]
       mov       r8d,1
       call      qword ptr [7FF9F8225ED8]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Return(Byte[], Boolean)
       nop
       add       rsp,48
       ret
; Total bytes of code 1024
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
       xor       edx,edx
       mov       [rcx],edx
       mov       [rbx-4],edx
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
       jmp       qword ptr [7FF9F835CB10]
; Total bytes of code 231
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
       jae       near ptr M02_L09
       cmp       r10,10
       jae       near ptr M02_L07
M02_L00:
       cmp       r10,4
       jb        short M02_L02
M02_L01:
       mov       r11d,[rax]
       mov       ebx,[rax+4]
       mov       esi,r11d
       or        esi,ebx
       test      esi,0FF80FF80
       jne       near ptr M02_L12
       add       rax,8
       add       r10,0FFFFFFFFFFFFFFFC
       cmp       r10,4
       jae       short M02_L01
M02_L02:
       test      r10b,2
       je        short M02_L03
       mov       r11d,[rax]
       test      r11d,0FF80FF80
       jne       near ptr M02_L13
       add       rax,4
M02_L03:
       test      r10b,1
       je        short M02_L05
       cmp       word ptr [rax],7F
       ja        short M02_L05
M02_L04:
       add       rax,2
M02_L05:
       sub       rax,rcx
       shr       rax,1
       mov       r10d,eax
       lea       rcx,[rcx+r10*2]
       sub       edx,eax
       jne       near ptr M02_L15
       xor       edx,edx
       mov       [r8],rdx
       mov       [r9],edx
M02_L06:
       mov       rax,rcx
       vzeroupper
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L07:
       vbroadcastss xmm0,dword ptr [7FF9F7BC5300]
       vptest    xmm0,xmmword ptr [rax]
       jne       near ptr M02_L00
       lea       rbx,[r11+r10*2-10]
       add       r11,10
       mov       rax,r11
       and       rax,0FFFFFFFFFFFFFFF0
       vpand     xmm1,xmm0,[rax]
       vptest    xmm1,xmm1
       jne       short M02_L11
M02_L08:
       add       rax,10
       cmp       rax,rbx
       ja        short M02_L11
       vpand     xmm1,xmm0,[rax]
       vptest    xmm1,xmm1
       jne       short M02_L11
       jmp       short M02_L08
M02_L09:
       vbroadcastss ymm0,dword ptr [7FF9F7BC5300]
       vptest    ymm0,ymmword ptr [rax]
       jne       near ptr M02_L00
       lea       rbx,[r11+r10*2-20]
       lea       rax,[r11+20]
       and       rax,0FFFFFFFFFFFFFFE0
       vpand     ymm1,ymm0,[rax]
       vptest    ymm1,ymm1
       jne       short M02_L11
M02_L10:
       add       rax,20
       cmp       rax,rbx
       ja        short M02_L11
       vpand     ymm1,ymm0,[rax]
       vptest    ymm1,ymm1
       je        short M02_L10
M02_L11:
       mov       r11,rax
       sub       r11,rcx
       shr       r11,1
       sub       r10,r11
       jmp       near ptr M02_L00
M02_L12:
       test      r11d,0FF80FF80
       je        short M02_L14
M02_L13:
       test      r11d,0FF80
       jne       near ptr M02_L05
       jmp       near ptr M02_L04
M02_L14:
       mov       r11d,ebx
       add       rax,4
       jmp       short M02_L13
M02_L15:
       xor       eax,eax
       xor       r10d,r10d
       mov       r11d,edx
       lea       r11,[rcx+r11*2]
       cmp       edx,8
       jl        near ptr M02_L20
       vbroadcastss xmm0,dword ptr [7FF9F7BC5304]
       lea       rdx,[r11-10]
M02_L16:
       vmovups   xmm1,[rcx]
       add       rcx,10
       vpaddusw  xmm2,xmm1,xmm0
       vpminuw   xmm3,xmm1,[7FF9F7BC5310]
       vpor      xmm2,xmm2,xmm3
       vpmovmskb ebx,xmm2
       popcnt    ebx,ebx
       vpaddw    xmm2,xmm1,[7FF9F7BC5320]
       vpcmpgtw  xmm2,xmm0,xmm2
       vpmovmskb esi,xmm2
M02_L17:
       cmp       esi,0FFFF
       je        short M02_L19
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
       jne       near ptr M02_L22
       cmp       esi,0FFFF
       jbe       short M02_L18
       movzx     esi,si
       add       rbx,0FFFFFFFFFFFFFFFE
       add       rcx,0FFFFFFFFFFFFFFFE
M02_L18:
       popcnt    esi,esi
       sub       r10d,esi
       sub       rax,rsi
       sub       rax,rsi
       mov       esi,0FFFF
       jmp       short M02_L17
M02_L19:
       add       rax,rbx
       cmp       rcx,rdx
       jbe       near ptr M02_L16
M02_L20:
       cmp       rcx,r11
       jae       short M02_L23
       movzx     edx,word ptr [rcx]
       cmp       edx,7F
       jbe       short M02_L21
       lea       ebx,[rdx+1F800]
       shr       ebx,10
       add       rax,rbx
       add       edx,0FFFF2800
       cmp       edx,7FF
       ja        short M02_L21
       add       rax,0FFFFFFFFFFFFFFFE
       mov       rdx,r11
       sub       rdx,rcx
       cmp       rdx,4
       jb        short M02_L23
       mov       edx,[rcx]
       add       edx,23FF2800
       test      edx,0FC00FC00
       jne       short M02_L23
       dec       r10d
       add       rax,2
       add       rcx,2
M02_L21:
       add       rcx,2
       jmp       short M02_L20
M02_L22:
       add       rcx,0FFFFFFFFFFFFFFF0
       jmp       short M02_L20
M02_L23:
       mov       [r8],rax
       mov       [r9],r10d
       jmp       near ptr M02_L06
; Total bytes of code 628
```
```assembly
; System.Text.Unicode.Utf8Utility.TranscodeToUtf8(Char*, Int32, Byte*, Int32, Char* ByRef, Byte* ByRef)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       mov       r10,[rsp+48]
       mov       r11,[rsp+50]
       cmp       edx,r9d
       mov       eax,r9d
       cmovle    eax,edx
       xor       ebx,ebx
       cmp       rax,20
       jb        near ptr M03_L03
       mov       rsi,[rcx]
       mov       rdi,0FF80FF80FF80FF80
       test      rdi,rsi
       mov       rdi,rsi
       jne       near ptr M03_L19
       cmp       rax,40
       jb        near ptr M03_L10
       mov       rbx,rcx
       vmovups   ymm0,[rbx]
       vbroadcastss ymm1,dword ptr [7FF9F7BC45B0]
       vptest    ymm1,ymm0
       jne       near ptr M03_L08
       mov       rsi,r8
       vpackuswb ymm0,ymm0,ymm0
       vpermq    ymm0,ymm0,0D8
       vmovups   [rsi],xmm0
       mov       edi,10
       test      r8b,10
       jne       short M03_L00
       vmovups   ymm0,[rbx+20]
       vptest    ymm1,ymm0
       jne       short M03_L02
       vpackuswb ymm0,ymm0,ymm0
       vpermq    ymm0,ymm0,0D8
       vmovups   [rsi+10],xmm0
M03_L00:
       mov       rdi,r8
       and       rdi,1F
       neg       rdi
       add       rdi,20
       lea       rbp,[rax-20]
       vmovups   ymm0,[rbx+rdi*2]
       vmovups   ymm2,[rbx+rdi*2+20]
       vpor      ymm3,ymm0,ymm2
       vptest    ymm3,ymm1
       jne       near ptr M03_L09
M03_L01:
       vpackuswb ymm0,ymm0,ymm2
       vpermq    ymm2,ymm0,0D8
       vmovups   [rsi+rdi],ymm2
       add       rdi,20
       cmp       rdi,rbp
       ja        short M03_L02
       vmovups   ymm0,[rbx+rdi*2]
       vmovups   ymm2,[rbx+rdi*2+20]
       vpor      ymm3,ymm0,ymm2
       vptest    ymm3,ymm1
       jne       near ptr M03_L09
       jmp       short M03_L01
M03_L02:
       mov       rbx,rdi
M03_L03:
       sub       rax,rbx
       cmp       rax,4
       jb        short M03_L05
       lea       rsi,[rbx+rax-4]
       mov       rdi,[rcx+rbx*2]
       mov       rbp,0FF80FF80FF80FF80
       test      rbp,rdi
       jne       near ptr M03_L19
M03_L04:
       vmovq     xmm0,rdi
       vpackuswb xmm0,xmm0,xmm0
       vmovd     dword ptr [r8+rbx],xmm0
       add       rbx,4
       cmp       rbx,rsi
       ja        short M03_L05
       mov       rdi,[rcx+rbx*2]
       mov       rbp,0FF80FF80FF80FF80
       test      rbp,rdi
       jne       near ptr M03_L19
       jmp       short M03_L04
M03_L05:
       test      al,2
       jne       near ptr M03_L17
M03_L06:
       test      al,1
       jne       near ptr M03_L18
M03_L07:
       lea       rcx,[rcx+rbx*2]
       add       r8,rbx
       cmp       ebx,edx
       jne       near ptr M03_L22
       mov       [r10],rcx
       mov       [r11],r8
       xor       eax,eax
       vzeroupper
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M03_L08:
       xor       ebx,ebx
       jmp       near ptr M03_L03
M03_L09:
       vptest    ymm1,ymm0
       jne       near ptr M03_L02
       vpackuswb ymm0,ymm0,ymm0
       vpermq    ymm0,ymm0,0D8
       vmovups   [rsi+rdi],xmm0
       add       rdi,10
       jmp       near ptr M03_L02
M03_L10:
       mov       rbx,rcx
       vmovups   xmm0,[rbx]
       vbroadcastss xmm1,dword ptr [7FF9F7BC45B0]
       vptest    xmm1,xmm0
       je        short M03_L11
       xor       ebx,ebx
       jmp       near ptr M03_L16
M03_L11:
       mov       rsi,r8
       vpackuswb xmm0,xmm0,xmm0
       vmovsd    qword ptr [rsi],xmm0
       mov       edi,8
       test      r8b,8
       jne       short M03_L12
       vmovups   xmm0,[rbx+10]
       vptest    xmm1,xmm0
       jne       short M03_L14
       vpackuswb xmm0,xmm0,xmm0
       vmovsd    qword ptr [rsi+8],xmm0
M03_L12:
       mov       rdi,r8
       and       rdi,0F
       neg       rdi
       add       rdi,10
       lea       rbp,[rax-10]
M03_L13:
       vmovups   xmm0,[rbx+rdi*2]
       vmovups   xmm2,[rbx+rdi*2+10]
       vpor      xmm3,xmm0,xmm2
       vptest    xmm3,xmm1
       jne       short M03_L15
       vpackuswb xmm0,xmm0,xmm2
       vmovups   [rsi+rdi],xmm0
       add       rdi,10
       cmp       rdi,rbp
       jbe       short M03_L13
M03_L14:
       mov       rbx,rdi
       jmp       short M03_L16
M03_L15:
       vptest    xmm1,xmm0
       jne       short M03_L14
       vpackuswb xmm0,xmm0,xmm0
       vmovsd    qword ptr [rsi+rdi],xmm0
       add       rdi,8
       jmp       short M03_L14
M03_L16:
       jmp       near ptr M03_L03
M03_L17:
       mov       esi,[rcx+rbx*2]
       test      esi,0FF80FF80
       jne       short M03_L20
       lea       rdi,[r8+rbx]
       mov       [rdi],sil
       shr       esi,10
       mov       [rdi+1],sil
       add       rbx,2
       jmp       near ptr M03_L06
M03_L18:
       movzx     esi,word ptr [rcx+rbx*2]
       cmp       esi,7F
       ja        near ptr M03_L07
       jmp       short M03_L21
M03_L19:
       mov       eax,edi
       test      eax,0FF80FF80
       jne       short M03_L24
       lea       rsi,[r8+rbx]
       mov       [rsi],al
       shr       eax,10
       mov       [rsi+1],al
       shr       rdi,20
       mov       eax,edi
       add       rbx,2
       mov       esi,eax
M03_L20:
       test      esi,0FF80
       jne       near ptr M03_L07
M03_L21:
       mov       [r8+rbx],sil
       inc       rbx
       jmp       near ptr M03_L07
M03_L22:
       sub       edx,ebx
       sub       r9d,ebx
       cmp       edx,2
       jl        near ptr M03_L60
       mov       eax,edx
       lea       rax,[rcx+rax*2-4]
M03_L23:
       mov       ebx,[rcx]
       jmp       near ptr M03_L49
M03_L24:
       mov       esi,eax
       jmp       short M03_L20
M03_L25:
       cmp       r9d,2
       jl        near ptr M03_L61
       mov       esi,ebx
       shr       esi,8
       or        esi,ebx
       mov       [r8],si
       add       rcx,4
       add       r8,2
       add       r9d,0FFFFFFFE
       mov       rbx,rax
       sub       rbx,rcx
       mov       rsi,rbx
       shr       rsi,3F
       add       rbx,rsi
       sar       rbx,1
       add       ebx,2
       movsxd    rsi,r9d
       cmp       rbx,rsi
       jle       short M03_L26
       jmp       short M03_L27
M03_L26:
       mov       rsi,rbx
M03_L27:
       mov       ebx,esi
       shr       ebx,3
       xor       edi,edi
       jmp       short M03_L29
M03_L28:
       vmovups   xmm0,[rcx]
       vptest    xmm0,xmmword ptr [7FF9F7BC45C0]
       jne       short M03_L30
       vpackuswb xmm0,xmm0,xmm0
       vmovq     qword ptr [r8],xmm0
       add       rcx,10
       add       r8,8
       inc       edi
M03_L29:
       cmp       edi,ebx
       jb        short M03_L28
       lea       ebx,[rdi*8]
       sub       r9d,ebx
       test      sil,4
       je        near ptr M03_L57
       mov       rbx,[rcx]
       mov       rsi,0FF80FF80FF80FF80
       test      rsi,rbx
       jne       short M03_L31
       jmp       near ptr M03_L52
M03_L30:
       shl       edi,3
       sub       r9d,edi
       vmovq     rbx,xmm0
       mov       rsi,0FF80FF80FF80FF80
       test      rsi,rbx
       jne       short M03_L31
       vpackuswb xmm1,xmm0,xmm0
       vmovd     dword ptr [r8],xmm1
       add       rcx,8
       add       r8,4
       add       r9d,0FFFFFFFC
       vpextrq   rbx,xmm0,1
M03_L31:
       mov       esi,ebx
       test      esi,0FF80FF80
       jne       short M03_L32
       mov       edi,esi
       shr       edi,8
       or        edi,esi
       mov       [r8],di
       add       rcx,4
       add       r8,2
       add       r9d,0FFFFFFFE
       shr       rbx,20
       mov       esi,ebx
M03_L32:
       test      esi,0FF80
       jne       short M03_L33
       test      r9d,r9d
       je        near ptr M03_L68
       jmp       short M03_L34
M03_L33:
       test      esi,0F800
       jne       near ptr M03_L50
       jmp       near ptr M03_L38
M03_L34:
       mov       [r8],sil
       add       rcx,2
       inc       r8
       dec       r9d
       cmp       rcx,rax
       ja        near ptr M03_L59
       mov       esi,[rcx]
       jmp       short M03_L33
M03_L35:
       cmp       r9d,2
       jl        near ptr M03_L68
       jmp       short M03_L39
M03_L36:
       cmp       r9d,4
       jl        short M03_L37
       mov       ebx,esi
       shr       ebx,6
       and       ebx,1F001F
       shl       esi,8
       and       esi,3F003F00
       add       ebx,esi
       add       ebx,80C080C0
       mov       [r8],ebx
       add       rcx,4
       add       r8,4
       add       r9d,0FFFFFFFC
       cmp       rcx,rax
       ja        near ptr M03_L59
       mov       esi,[rcx]
       lea       ebx,[rsi-80]
       movzx     ebx,bx
       cmp       ebx,780
       jl        short M03_L38
       mov       ebx,esi
       jmp       near ptr M03_L49
M03_L37:
       mov       ebx,esi
       jmp       near ptr M03_L61
M03_L38:
       lea       ebx,[rsi-800000]
       cmp       ebx,77FFFFF
       jbe       short M03_L36
       jmp       short M03_L35
M03_L39:
       lea       ebx,[rsi*4]
       and       ebx,1F00
       mov       edi,esi
       and       edi,3F
       lea       ebx,[rbx+rdi+0C080]
       movbe     [r8],bx
       cmp       esi,800000
       jb        short M03_L40
       add       rcx,2
       add       r8,2
       add       r9d,0FFFFFFFE
       cmp       rcx,rax
       ja        near ptr M03_L59
       jmp       short M03_L41
M03_L40:
       cmp       r9d,3
       jl        near ptr M03_L58
       jmp       near ptr M03_L53
M03_L41:
       mov       esi,[rcx]
       jmp       near ptr M03_L50
M03_L42:
       test      esi,0F8000000
       jne       short M03_L44
       jmp       short M03_L45
M03_L43:
       lea       ebx,[rsi+23FF2800]
       test      ebx,0FC00FC00
       je        near ptr M03_L55
       jmp       near ptr M03_L54
M03_L44:
       lea       ebx,[rsi+28000000]
       cmp       ebx,8000000
       jb        short M03_L45
       cmp       r9d,6
       jge       short M03_L46
M03_L45:
       cmp       r9d,3
       jl        near ptr M03_L68
       jmp       short M03_L47
M03_L46:
       lea       ebx,[rsi*4]
       and       ebx,3F00
       mov       edi,esi
       and       edi,3F
       shl       edi,10
       or        ebx,edi
       mov       edi,esi
       shr       edi,4
       and       edi,0F000000
       mov       ebp,esi
       shr       ebp,0C
       and       ebp,0F
       or        edi,ebp
       add       ebx,edi
       add       ebx,0E08080E0
       mov       [r8],ebx
       mov       ebx,esi
       shr       ebx,16
       and       ebx,3F
       shr       esi,8
       and       esi,3F00
       add       ebx,esi
       add       ebx,8080
       mov       [r8+4],bx
       add       rcx,4
       add       r8,6
       add       r9d,0FFFFFFFA
       cmp       rcx,rax
       ja        near ptr M03_L59
       mov       esi,[rcx]
       test      esi,0F800
       jne       near ptr M03_L50
       mov       ebx,esi
       jmp       short M03_L49
M03_L47:
       lea       ebx,[rsi*4]
       and       ebx,3F00
       movzx     edi,si
       shr       edi,0C
       add       ebx,edi
       add       ebx,80E0
       mov       [r8],bx
       mov       ebx,esi
       and       ebx,3F
       or        ebx,0FFFFFF80
       mov       [r8+2],bl
       add       rcx,2
       add       r8,3
       add       r9d,0FFFFFFFD
       cmp       esi,800000
       jb        short M03_L48
       cmp       rcx,rax
       ja        near ptr M03_L59
       jmp       short M03_L51
M03_L48:
       test      r9d,r9d
       je        near ptr M03_L68
       shr       esi,10
       mov       [r8],sil
       add       rcx,2
       inc       r8
       dec       r9d
       cmp       rcx,rax
       ja        near ptr M03_L59
       mov       esi,[rcx]
       test      esi,0F800
       jne       short M03_L50
       mov       ebx,esi
M03_L49:
       test      ebx,0FF80FF80
       je        near ptr M03_L25
       mov       esi,ebx
       jmp       near ptr M03_L32
M03_L50:
       lea       ebx,[rsi-0D800]
       test      ebx,0F800
       je        near ptr M03_L43
       jmp       near ptr M03_L42
M03_L51:
       mov       esi,[rcx]
       jmp       near ptr M03_L32
M03_L52:
       vmovq     xmm0,rbx
       vpackuswb xmm0,xmm0,xmm0
       vmovd     dword ptr [r8],xmm0
       add       rcx,8
       jmp       short M03_L56
M03_L53:
       shr       esi,10
       mov       [r8+2],sil
       add       rcx,4
       add       r8,3
       add       r9d,0FFFFFFFD
       jmp       short M03_L57
M03_L54:
       mov       eax,3
       jmp       near ptr M03_L69
M03_L55:
       cmp       r9d,4
       jl        near ptr M03_L68
       add       esi,40
       mov       ebx,esi
       and       ebx,3
       shl       ebx,14
       or        ebx,808080F0
       mov       edi,esi
       and       edi,3F0700
       bswap     edi
       rol       edi,10
       or        ebx,edi
       mov       edi,esi
       shr       edi,6
       and       edi,0F0000
       or        ebx,edi
       and       esi,0FC
       shl       esi,6
       or        ebx,esi
       mov       [r8],ebx
       add       rcx,4
M03_L56:
       add       r8,4
       add       r9d,0FFFFFFFC
M03_L57:
       cmp       rcx,rax
       jbe       near ptr M03_L23
       jmp       short M03_L59
M03_L58:
       add       rcx,2
       add       r8,2
       jmp       near ptr M03_L68
M03_L59:
       sub       rax,rcx
       mov       rdx,rax
       shr       rdx,3F
       add       rdx,rax
       sar       rdx,1
       add       edx,2
M03_L60:
       test      edx,edx
       je        near ptr M03_L67
       movzx     ebx,word ptr [rcx]
       jmp       short M03_L62
M03_L61:
       movzx     ebx,bx
M03_L62:
       cmp       ebx,7F
       ja        short M03_L63
       test      r9d,r9d
       je        near ptr M03_L68
       mov       [r8],bl
       add       rcx,2
       inc       r8
       jmp       near ptr M03_L66
M03_L63:
       cmp       ebx,800
       jae       short M03_L64
       cmp       r9d,2
       jl        near ptr M03_L68
       mov       r9d,ebx
       and       r9d,3F
       or        r9d,0FFFFFF80
       mov       [r8+1],r9b
       shr       ebx,6
       or        ebx,0FFFFFFC0
       mov       [r8],bl
       add       rcx,2
       add       r8,2
       jmp       short M03_L66
M03_L64:
       lea       eax,[rbx-0D800]
       cmp       eax,7FF
       jbe       short M03_L65
       cmp       r9d,3
       jl        short M03_L68
       mov       eax,ebx
       and       eax,3F
       or        eax,0FFFFFF80
       mov       [r8+2],al
       mov       eax,ebx
       shr       eax,6
       and       eax,3F
       or        eax,0FFFFFF80
       mov       [r8+1],al
       mov       eax,ebx
       shr       eax,0C
       or        eax,0FFFFFFE0
       mov       [r8],al
       add       rcx,2
       add       r8,3
       jmp       short M03_L66
M03_L65:
       cmp       ebx,0DBFF
       ja        near ptr M03_L54
       mov       eax,2
       jmp       short M03_L69
M03_L66:
       cmp       edx,1
       jg        short M03_L68
M03_L67:
       xor       eax,eax
       jmp       short M03_L69
M03_L68:
       mov       eax,1
M03_L69:
       mov       [r10],rcx
       mov       [r11],r8
       vzeroupper
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 1983
```
```assembly
; Org.BouncyCastle.Crypto.Digests.KeccakDigest.Absorb(Byte[], Int32, Int32)
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       rdi,rdx
       mov       ebp,r8d
       mov       esi,r9d
       mov       r9d,[rbx+1C]
       test      r9b,7
       jne       near ptr M04_L06
       cmp       byte ptr [rbx+24],0
       jne       near ptr M04_L07
       sar       r9d,3
       mov       r14d,[rbx+18]
       sar       r14d,3
       mov       r15d,r14d
       sub       r15d,r9d
       cmp       esi,r15d
       jge       near ptr M04_L16
       mov       r8,[rbx+10]
       test      rdi,rdi
       je        near ptr M04_L15
       test      r8,r8
       je        near ptr M04_L15
       mov       rcx,[rdi]
       cmp       rcx,[r8]
       jne       near ptr M04_L15
       cmp       dword ptr [rcx+4],18
       jne       near ptr M04_L15
       mov       edx,esi
       or        edx,ebp
       or        edx,r9d
       jl        near ptr M04_L15
       lea       edx,[rsi+rbp]
       cmp       edx,[rdi+8]
       ja        near ptr M04_L15
       lea       edx,[r9+rsi]
       cmp       edx,[r8+8]
       ja        near ptr M04_L15
       movzx     edx,word ptr [rcx]
       mov       eax,esi
       imul      rax,rdx
       mov       r10d,ebp
       imul      r10,rdx
       lea       r10,[rdi+r10+10]
       mov       r9d,r9d
       imul      rdx,r9
       lea       r9,[r8+rdx+10]
       test      dword ptr [rcx],1000000
       jne       near ptr M04_L08
       mov       rcx,r9
       mov       rdx,r10
       mov       r8,rax
       mov       r11,rcx
       sub       r11,rdx
       cmp       r11,r8
       jb        near ptr M04_L13
       mov       r11,rdx
       sub       r11,rcx
       cmp       r11,r8
       jb        near ptr M04_L13
       lea       r11,[rdx+r8]
       lea       rdi,[rcx+r8]
       cmp       r8,10
       jbe       short M04_L04
       cmp       r8,40
       ja        near ptr M04_L10
M04_L00:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       jbe       short M04_L01
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M04_L01
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
M04_L01:
       vmovups   xmm0,[r11-10]
       vmovups   [rdi-10],xmm0
M04_L02:
       shl       esi,3
       add       [rbx+1C],esi
M04_L03:
       vzeroupper
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M04_L04:
       test      al,18
       je        short M04_L05
       mov       rax,[r10]
       mov       [r9],rax
       mov       r10,[r11-8]
       mov       [rdi-8],r10
       jmp       short M04_L02
M04_L05:
       test      al,4
       je        near ptr M04_L09
       mov       eax,[r10]
       mov       [r9],eax
       mov       r10d,[r11-4]
       mov       [rdi-4],r10d
       jmp       short M04_L02
M04_L06:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,28F39
       mov       rdx,7FF9F8223BD0
       call      qword ptr [7FF9F7D67738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F7F35D28]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M04_L07:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,28F89
       mov       rdx,7FF9F8223BD0
       call      qword ptr [7FF9F7D67738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F7F35D28]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M04_L08:
       mov       rcx,r9
       mov       rdx,r10
       mov       r8,rax
       call      qword ptr [7FF9F7AE57A0]; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M04_L02
M04_L09:
       test      rax,rax
       je        near ptr M04_L02
       movzx     r10d,byte ptr [r10]
       mov       [r9],r10b
       test      al,2
       je        near ptr M04_L02
       movsx     r9,word ptr [r11-2]
       mov       [rdi-2],r9w
       jmp       near ptr M04_L02
M04_L10:
       cmp       r8,800
       ja        near ptr M04_L14
       cmp       r8,100
       jb        short M04_L11
       mov       rdx,r9
       and       rdx,3F
       mov       r8,rdx
       neg       r8
       add       r8,40
       vmovdqu   ymm0,ymmword ptr [r10]
       vmovdqu   ymmword ptr [r9],ymm0
       vmovdqu   ymm0,ymmword ptr [r10+20]
       vmovdqu   ymmword ptr [r9+20],ymm0
       lea       rdx,[r10+r8]
       lea       rcx,[r9+r8]
       sub       rax,r8
       mov       r8,rax
M04_L11:
       mov       r10,r8
       shr       r10,6
M04_L12:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r10
       jne       short M04_L12
       and       r8,3F
       cmp       r8,10
       ja        near ptr M04_L00
       jmp       near ptr M04_L01
M04_L13:
       cmp       r9,r10
       jne       short M04_L14
       cmp       [r10],r10b
       jmp       near ptr M04_L02
M04_L14:
       cmp       [r9],r9b
       cmp       [r10],r10b
       mov       rcx,r9
       mov       rdx,r10
       mov       r8,rax
       call      qword ptr [7FF9F7AE66E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M04_L02
M04_L15:
       mov       [rsp+20],esi
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rdi
       mov       edx,ebp
       call      qword ptr [7FF9F835CC60]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M04_L02
M04_L16:
       xor       r13d,r13d
       test      r9d,r9d
       jle       short M04_L18
       mov       [rsp+20],r15d
       mov       r8,[rbx+10]
       mov       rcx,rdi
       mov       edx,ebp
       call      qword ptr [7FF9F80CC858]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       r13d,r15d
       mov       rdx,[rbx+10]
       mov       rcx,rbx
       xor       r8d,r8d
       call      qword ptr [7FF9F81C74B0]
       jmp       short M04_L18
M04_L17:
       lea       r8d,[rbp+r13]
       mov       rcx,rbx
       mov       rdx,rdi
       call      qword ptr [7FF9F81C74B0]
       add       r13d,r14d
M04_L18:
       mov       r15d,esi
       sub       r15d,r13d
       cmp       r15d,r14d
       jge       short M04_L17
       mov       [rsp+20],r15d
       lea       edx,[rbp+r13]
       mov       r8,[rbx+10]
       mov       rcx,rdi
       xor       r9d,r9d
       call      qword ptr [7FF9F80CC858]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       shl       r15d,3
       mov       [rbx+1C],r15d
       jmp       near ptr M04_L03
; Total bytes of code 882
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
       mov       rcx,2025D400C90
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
       jle       short M05_L02
       mov       rcx,[rcx+240]
       mov       rax,[rcx+48]
       test      rax,rax
       je        short M05_L02
M05_L00:
       mov       rcx,[rax+10]
       test      rcx,rcx
       je        short M05_L04
       mov       eax,[rcx+8]
       cmp       eax,ebp
       jbe       short M05_L04
       mov       eax,ebp
       shl       rax,4
       mov       r14,[rcx+rax+10]
       test      r14,r14
       je        short M05_L04
       xor       edx,edx
       mov       [rcx+rax+10],rdx
       cmp       byte ptr [rdi+9D],0
       jne       short M05_L03
M05_L01:
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
M05_L02:
       mov       ecx,9
       call      qword ptr [7FF9F835DB00]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       short M05_L00
M05_L03:
       mov       rcx,r14
       call      qword ptr [7FF9F7FDC918]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       ebx,eax
       mov       r15d,[r14+8]
       cmp       [rsi],sil
       mov       rcx,rsi
       call      qword ptr [7FF9F7FDC918]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       [rsp+20],ebp
       mov       edx,ebx
       mov       r8d,r15d
       mov       rcx,rdi
       call      qword ptr [7FF9F835DCE0]
       jmp       short M05_L01
M05_L04:
       mov       rcx,[rsi+10]
       cmp       [rcx+8],ebp
       jbe       near ptr M05_L16
       mov       eax,ebp
       mov       rcx,[rcx+rax*8+10]
       test      rcx,rcx
       je        near ptr M05_L15
       mov       r14,[rcx+8]
       mov       rcx,offset MT_System.Threading.ProcessorIdCache
       call      System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       cmp       byte ptr [7FF9F7A2B1CC],0
       je        short M05_L05
       call      qword ptr [7FF9F835DB48]
       mov       ebx,eax
       jmp       short M05_L07
M05_L05:
       mov       ecx,0A
       call      qword ptr [7FF9F835DB60]
       mov       ebx,[rax+10]
       mov       ecx,0A
       call      qword ptr [7FF9F835DB60]
       lea       ecx,[rbx-1]
       mov       [rax+10],ecx
       movzx     eax,bx
       test      eax,eax
       jne       short M05_L06
       call      qword ptr [7FF9F835DB78]
       mov       ebx,eax
       jmp       short M05_L07
M05_L06:
       sar       ebx,10
M05_L07:
       mov       rcx,offset MT_System.Buffers.SharedArrayPoolStatics
       call      System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       eax,ebx
       xor       edx,edx
       div       dword ptr [7FF9F7A2B1C0]
       mov       ebx,edx
       xor       r15d,r15d
       jmp       short M05_L11
M05_L08:
       cmp       ebx,[r14+8]
       jae       near ptr M05_L21
       mov       ecx,ebx
       mov       r13,[r14+rcx*8+10]
       cmp       [r13],r13b
       xor       r12d,r12d
       mov       rcx,r13
       call      qword ptr [7FF9F80CD5D8]; System.Threading.Monitor.Enter(System.Object)
       mov       rcx,[r13+8]
       mov       eax,[r13+10]
       dec       eax
       cmp       [rcx+8],eax
       jbe       short M05_L09
       mov       edx,eax
       mov       r12,[rcx+rdx*8+10]
       mov       edx,eax
       xor       r8d,r8d
       mov       [rcx+rdx*8+10],r8
       mov       [r13+10],eax
M05_L09:
       mov       rcx,r13
       call      qword ptr [7FF9F7AE6820]; System.Threading.Monitor.Exit(System.Object)
       test      r12,r12
       jne       short M05_L12
       inc       ebx
       cmp       [r14+8],ebx
       jne       short M05_L10
       xor       ebx,ebx
M05_L10:
       inc       r15d
M05_L11:
       cmp       [r14+8],r15d
       jg        short M05_L08
       jmp       short M05_L13
M05_L12:
       mov       r14,r12
       jmp       short M05_L14
M05_L13:
       xor       r14d,r14d
M05_L14:
       test      r14,r14
       je        short M05_L15
       cmp       byte ptr [rdi+9D],0
       je        near ptr M05_L01
       mov       rcx,r14
       call      qword ptr [7FF9F7FDC918]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       ebx,eax
       mov       r15d,[r14+8]
       mov       rcx,rsi
       call      qword ptr [7FF9F7FDC918]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       [rsp+20],ebp
       mov       edx,ebx
       mov       r8d,r15d
       mov       rcx,rdi
       call      qword ptr [7FF9F835DCE0]
       jmp       near ptr M05_L01
M05_L15:
       mov       ecx,10
       shlx      ebx,ecx,ebp
       jmp       short M05_L18
M05_L16:
       test      ebx,ebx
       jne       short M05_L17
       mov       rax,242F25762A0
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
M05_L17:
       mov       ecx,ebx
       mov       rdx,242F2576F28
       call      qword ptr [7FF9F7D6D770]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
M05_L18:
       cmp       ebx,800
       jge       short M05_L19
       movsxd    rdx,ebx
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
       jmp       short M05_L20
M05_L19:
       mov       ecx,ebx
       xor       edx,edx
       call      qword ptr [7FF9F835DC98]
       mov       r14,rax
M05_L20:
       cmp       byte ptr [rdi+9D],0
       je        near ptr M05_L01
       cmp       [r14],r14b
       mov       rcx,r14
       call      qword ptr [7FF9F7FDC918]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       ebx,eax
       mov       r15d,[r14+8]
       mov       rcx,rsi
       call      qword ptr [7FF9F7FDC918]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       edx,ebx
       mov       r8d,r15d
       mov       rcx,rdi
       call      qword ptr [7FF9F835DCE0]
       mov       r15d,[r14+8]
       mov       rcx,rsi
       call      qword ptr [7FF9F7FDC918]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
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
       call      qword ptr [7FF9F835DCF8]
       jmp       near ptr M05_L01
M05_L21:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 796
```
```assembly
; Org.BouncyCastle.Crypto.Digests.KeccakDigest.Squeeze(Byte[], Int32, Int64)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       rbx,rcx
       mov       rsi,rdx
       mov       ebp,r8d
       mov       rdi,r9
       cmp       byte ptr [rbx+24],0
       jne       short M06_L00
       mov       rcx,rbx
       call      qword ptr [7FF9F81CFC48]; Org.BouncyCastle.Crypto.Digests.KeccakDigest.PadAndSwitchToSqueezingPhase()
M06_L00:
       test      dil,7
       jne       near ptr M06_L13
       xor       r14d,r14d
       cmp       r14,rdi
       jge       near ptr M06_L10
M06_L01:
       cmp       dword ptr [rbx+1C],0
       jne       near ptr M06_L05
       mov       rcx,rbx
       call      qword ptr [7FF9F81CFCC0]; Org.BouncyCastle.Crypto.Digests.KeccakDigest.KeccakPermutation()
       mov       rcx,[rbx+8]
       mov       edx,[rbx+18]
       sar       edx,6
       mov       r8,[rbx+10]
       xor       eax,eax
       xor       r10d,r10d
       cmp       eax,edx
       jge       near ptr M06_L04
M06_L02:
       cmp       eax,[rcx+8]
       jae       near ptr M06_L24
       mov       r9,[rcx+rax*8+10]
       mov       r11d,r9d
       mov       r15d,[r8+8]
       mov       r13d,r15d
       test      r10d,r10d
       jl        near ptr M06_L14
       lea       r12d,[r13-7]
       cmp       r10d,r12d
       jge       near ptr M06_L14
       mov       [r8+r10+10],r11b
       lea       r12d,[r10+1]
       mov       r13d,r12d
       mov       r12d,r11d
       shr       r12d,8
       mov       [r8+r13+10],r12b
       lea       r13d,[r10+2]
       mov       r15d,r13d
       mov       r13d,r11d
       shr       r13d,10
       mov       [r8+r15+10],r13b
       lea       r15d,[r10+3]
       shr       r11d,18
       mov       [r8+r15+10],r11b
       shr       r9,20
       lea       r11d,[r10+4]
       mov       r15d,r11d
       mov       [r8+r15+10],r9b
       lea       r15d,[r11+1]
       mov       r13d,r9d
       shr       r13d,8
       mov       [r8+r15+10],r13b
       lea       r15d,[r11+2]
       mov       r13d,r9d
       shr       r13d,10
       mov       [r8+r15+10],r13b
       add       r11d,3
       shr       r9d,18
       mov       [r8+r11+10],r9b
M06_L03:
       add       r10d,8
       inc       eax
       cmp       eax,edx
       jl        near ptr M06_L02
M06_L04:
       mov       ecx,[rbx+18]
       mov       [rbx+1C],ecx
M06_L05:
       mov       ecx,[rbx+1C]
       movsxd    r15,ecx
       mov       r13,rdi
       sub       r13,r14
       cmp       r15,r13
       jle       near ptr M06_L15
M06_L06:
       mov       rax,[rbx+10]
       mov       edx,[rbx+18]
       sub       edx,ecx
       sar       edx,3
       mov       r9,r14
       sar       r9,3
       add       r9d,ebp
       mov       r15d,r13d
       sar       r15d,3
       test      rax,rax
       je        near ptr M06_L23
       test      rsi,rsi
       je        near ptr M06_L23
       mov       rcx,[rax]
       cmp       rcx,[rsi]
       jne       near ptr M06_L23
       cmp       dword ptr [rcx+4],18
       jne       near ptr M06_L23
       mov       r8d,r15d
       or        r8d,edx
       or        r8d,r9d
       jl        near ptr M06_L23
       lea       r8d,[rdx+r15]
       cmp       r8d,[rax+8]
       ja        near ptr M06_L23
       lea       r8d,[r9+r15]
       cmp       r8d,[rsi+8]
       ja        near ptr M06_L23
       movzx     r8d,word ptr [rcx]
       mov       r10d,r15d
       imul      r10,r8
       imul      rdx,r8
       lea       rdx,[rax+rdx+10]
       mov       eax,r9d
       imul      r8,rax
       lea       rax,[rsi+r8+10]
       test      dword ptr [rcx],1000000
       jne       near ptr M06_L16
       mov       rcx,rax
       mov       r8,rdx
       mov       r9,r10
       mov       r11,rcx
       sub       r11,r8
       cmp       r11,r9
       jb        near ptr M06_L21
       mov       r11,r8
       sub       r11,rcx
       cmp       r11,r9
       jb        near ptr M06_L21
       lea       r11,[r8+r9]
       lea       r15,[rcx+r9]
       cmp       r9,10
       jbe       short M06_L11
       cmp       r9,40
       ja        near ptr M06_L18
M06_L07:
       vmovups   xmm0,[r8]
       vmovups   [rcx],xmm0
       cmp       r9,20
       jbe       short M06_L08
       vmovups   xmm0,[r8+10]
       vmovups   [rcx+10],xmm0
       cmp       r9,30
       jbe       short M06_L08
       vmovups   xmm0,[r8+20]
       vmovups   [rcx+20],xmm0
M06_L08:
       vmovups   xmm0,[r11-10]
       vmovups   [r15-10],xmm0
M06_L09:
       sub       [rbx+1C],r13d
       movsxd    rcx,r13d
       add       r14,rcx
       cmp       r14,rdi
       jl        near ptr M06_L01
M06_L10:
       vzeroupper
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
M06_L11:
       test      r10b,18
       je        short M06_L12
       mov       r10,[rdx]
       mov       [rax],r10
       mov       rdx,[r11-8]
       mov       [r15-8],rdx
       jmp       short M06_L09
M06_L12:
       test      r10b,4
       je        near ptr M06_L17
       mov       r10d,[rdx]
       mov       [rax],r10d
       mov       edx,[r11-4]
       mov       [r15-4],edx
       jmp       short M06_L09
M06_L13:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,2900F
       mov       rdx,7FF9F8223BD0
       call      qword ptr [7FF9F7D67738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F7F35D28]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M06_L14:
       cmp       r10d,r13d
       jae       near ptr M06_L24
       mov       [r8+r10+10],r11b
       lea       r12d,[r10+1]
       cmp       r12d,r15d
       jae       near ptr M06_L24
       mov       r13d,r12d
       mov       r12d,r11d
       shr       r12d,8
       mov       [r8+r13+10],r12b
       lea       r13d,[r10+2]
       cmp       r13d,r15d
       jae       near ptr M06_L24
       mov       r12d,r11d
       shr       r12d,10
       mov       [r8+r13+10],r12b
       lea       r13d,[r10+3]
       cmp       r13d,r15d
       jae       near ptr M06_L24
       shr       r11d,18
       mov       [r8+r13+10],r11b
       shr       r9,20
       lea       r11d,[r10+4]
       cmp       r11d,r15d
       jae       near ptr M06_L24
       mov       r13d,r11d
       mov       [r8+r13+10],r9b
       lea       r13d,[r11+1]
       cmp       r13d,r15d
       jae       near ptr M06_L24
       mov       r12d,r9d
       shr       r12d,8
       mov       [r8+r13+10],r12b
       lea       r13d,[r11+2]
       cmp       r13d,r15d
       jae       near ptr M06_L24
       mov       r12d,r9d
       shr       r12d,10
       mov       [r8+r13+10],r12b
       add       r11d,3
       cmp       r11d,r15d
       jae       near ptr M06_L24
       shr       r9d,18
       mov       [r8+r11+10],r9b
       jmp       near ptr M06_L03
M06_L15:
       mov       r13,r15
       jmp       near ptr M06_L06
M06_L16:
       mov       rcx,rax
       mov       r8,r10
       call      qword ptr [7FF9F7AE57A0]; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M06_L09
M06_L17:
       test      r10,r10
       je        near ptr M06_L09
       movzx     edx,byte ptr [rdx]
       mov       [rax],dl
       test      r10b,2
       je        near ptr M06_L09
       movsx     rax,word ptr [r11-2]
       mov       [r15-2],ax
       jmp       near ptr M06_L09
M06_L18:
       cmp       r9,800
       ja        near ptr M06_L22
       cmp       r9,100
       jb        short M06_L19
       mov       r8,rax
       and       r8,3F
       mov       r9,r8
       neg       r9
       add       r9,40
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rax],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rax+20],ymm0
       lea       r8,[rdx+r9]
       lea       rcx,[rax+r9]
       sub       r10,r9
       mov       r9,r10
M06_L19:
       mov       rdx,r9
       shr       rdx,6
M06_L20:
       vmovdqu   ymm0,ymmword ptr [r8]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [r8+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       r8,40
       dec       rdx
       jne       short M06_L20
       and       r9,3F
       cmp       r9,10
       ja        near ptr M06_L07
       jmp       near ptr M06_L08
M06_L21:
       cmp       rax,rdx
       jne       short M06_L22
       cmp       [rdx],dl
       jmp       near ptr M06_L09
M06_L22:
       cmp       [rax],al
       cmp       [rdx],dl
       mov       rcx,rax
       mov       r8,r10
       call      qword ptr [7FF9F7AE66E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M06_L09
M06_L23:
       mov       [rsp+20],r15d
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rax
       mov       r8,rsi
       call      qword ptr [7FF9F835CC60]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M06_L09
M06_L24:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1188
```
```assembly
; Org.BouncyCastle.Crypto.Digests.KeccakDigest.Reset()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,[rbx+20]
       cmp       esi,100
       jg        near ptr M07_L07
       cmp       esi,80
       je        short M07_L00
       cmp       esi,0E0
       je        short M07_L00
       cmp       esi,100
       jne       near ptr M07_L06
M07_L00:
       add       esi,esi
       neg       esi
       add       esi,640
       mov       ecx,esi
       sub       ecx,1
       cmp       ecx,63E
       ja        near ptr M07_L08
       test      sil,3F
       jne       near ptr M07_L08
       mov       [rbx+18],esi
       mov       rcx,[rbx+8]
       mov       rdx,rcx
       mov       ecx,[rcx+8]
       lea       rax,[rdx+10]
       xor       r8d,r8d
       mov       r10,[rdx]
       cmp       dword ptr [r10+4],18
       jne       near ptr M07_L09
M07_L01:
       mov       r9d,r8d
       neg       r9d
       test      r8d,r8d
       jg        near ptr M07_L05
       test      r9d,r9d
       jl        near ptr M07_L05
       lea       r8d,[r9+rcx]
       cmp       r8d,[rdx+8]
       ja        short M07_L05
       movzx     edx,word ptr [r10]
       mov       r8d,r9d
       imul      r8,rdx
       add       r8,rax
       mov       ecx,ecx
       imul      rdx,rcx
       test      dword ptr [r10],1000000
       jne       near ptr M07_L10
       mov       rcx,r8
       call      qword ptr [7FF9F7AE57E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
M07_L02:
       mov       rax,[rbx+10]
       mov       ecx,[rax+8]
       mov       edx,ecx
       test      edx,edx
       jle       short M07_L04
       nop       dword ptr [rax]
       nop       dword ptr [rax+rax]
M07_L03:
       dec       edx
       cmp       edx,ecx
       jae       near ptr M07_L11
       mov       byte ptr [rax+rdx+10],0
       test      edx,edx
       jg        short M07_L03
M07_L04:
       xor       eax,eax
       mov       [rbx+1C],eax
       mov       byte ptr [rbx+24],0
       mov       eax,esi
       neg       eax
       add       eax,640
       sar       eax,1
       mov       [rbx+20],eax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M07_L05:
       call      qword ptr [7FF9F835CE88]
       int       3
M07_L06:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,28E9F
       mov       rdx,7FF9F8223BD0
       call      qword ptr [7FF9F7D67738]
       mov       rbx,rax
       mov       ecx,28EFF
       mov       rdx,7FF9F8223BD0
       call      qword ptr [7FF9F7D67738]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9F7F35DD0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M07_L07:
       cmp       esi,120
       je        near ptr M07_L00
       cmp       esi,180
       je        near ptr M07_L00
       cmp       esi,200
       jne       short M07_L06
       jmp       near ptr M07_L00
M07_L08:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,28F13
       mov       rdx,7FF9F8223BD0
       call      qword ptr [7FF9F7D67738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F7F35D28]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M07_L09:
       mov       r9d,[r10+4]
       add       r9d,0FFFFFFE8
       shr       r9d,3
       movsxd    r8,r9d
       mov       r8d,[rax+r8*4]
       shl       r9d,3
       movsxd    r9,r9d
       add       rax,r9
       jmp       near ptr M07_L01
M07_L10:
       shr       rdx,3
       mov       rcx,r8
       call      qword ptr [7FF9F835CEA0]
       jmp       near ptr M07_L02
M07_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 522
```
```assembly
; System.Convert.ToBase64String(Byte[], Int32, Int32, System.Base64FormattingOptions)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,0A8
       vmovaps   [rsp+90],xmm6
       vmovaps   [rsp+80],xmm7
       vmovaps   [rsp+70],xmm8
       vmovaps   [rsp+60],xmm9
       vmovaps   [rsp+50],xmm10
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+30],ymm4
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
       call      00007FFA57738D20
       mov       rsi,rax
       test      edi,edi
       jne       near ptr M08_L31
       cmp       ebx,10
       jl        near ptr M08_L31
       lea       rcx,[rsi+0C]
       mov       edx,[rsi+8]
       imul      r9d,edx,2
       jo        near ptr M08_L34
       mov       [rsp+38],rbp
       mov       [rsp+30],rcx
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
       vmovups   ymm0,[7FF9F8466A00]
       vbroadcastf128 ymm1,xmmword ptr [7FF9F8466A20]
       vbroadcastss ymm2,dword ptr [7FF9F8466A30]
       vbroadcastss ymm3,dword ptr [7FF9F8466A34]
       vbroadcastss ymm4,dword ptr [7FF9F8466A38]
       vbroadcastss ymm5,dword ptr [7FF9F8466A3C]
       vbroadcastss ymm6,dword ptr [7FF9F8466A40]
       vbroadcastss ymm7,dword ptr [7FF9F8466A44]
       vmovups   ymm8,[7FF9F8466A60]
       vpermd    ymm8,ymm8,[rbp]
       add       rbp,0FFFFFFFFFFFFFFFC
M08_L04:
       vpshufb   ymm8,ymm8,ymm0
       vpand     ymm9,ymm8,ymm2
       vpmulhuw  ymm9,ymm9,ymm4
       vpand     ymm8,ymm8,ymm3
       vpmullw   ymm8,ymm8,ymm5
       vpor      ymm8,ymm8,ymm9
       vpsubusb  ymm9,ymm8,ymm6
       vpcmpgtb  ymm10,ymm8,ymm7
       vpsubb    ymm9,ymm9,ymm10
       vpshufb   ymm9,ymm1,ymm9
       vpaddb    ymm8,ymm9,ymm8
       vmovups   [r8],ymm8
       add       rbp,18
       add       r8,20
       cmp       rbp,rax
       ja        short M08_L06
       vmovups   ymm8,[rbp]
       jmp       short M08_L04
M08_L05:
       mov       ecx,1149
       mov       rdx,7FF9F7A24000
       call      qword ptr [7FF9F7D67738]
       mov       r8,rax
       mov       edx,ebp
       mov       ecx,esi
       call      qword ptr [7FF9F835DA28]
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
       mov       r8,7FFA568E5470
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
       mov       [rsp+38],r9
       mov       [rsp+30],r9
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
       vmovaps   xmm6,[rsp+90]
       vmovaps   xmm7,[rsp+80]
       vmovaps   xmm8,[rsp+70]
       vmovaps   xmm9,[rsp+60]
       vmovaps   xmm10,[rsp+50]
       add       rsp,0A8
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M08_L18:
       mov       ecx,1139
       mov       rdx,7FF9F7A24000
       call      qword ptr [7FF9F7D67738]
       mov       rcx,rax
       call      qword ptr [7FF9F835C8D0]
       int       3
M08_L19:
       mov       ecx,0B3
       mov       rdx,7FF9F7A24000
       call      qword ptr [7FF9F7D67738]
       mov       rdx,rax
       mov       ecx,ebx
       call      qword ptr [7FF9F835D9F8]
       int       3
M08_L20:
       mov       ecx,1149
       mov       rdx,7FF9F7A24000
       call      qword ptr [7FF9F7D67738]
       mov       rdx,rax
       mov       ecx,esi
       call      qword ptr [7FF9F835D9F8]
       int       3
M08_L21:
       call      qword ptr [7FF9F7C87138]
       int       3
M08_L22:
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9F835D380]
       mov       rsi,rax
       mov       [rbx+8],edi
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9F835D398]
       mov       rbx,rax
       mov       ecx,1157
       mov       rdx,7FF9F7A24000
       call      qword ptr [7FF9F7D67738]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FF9F7F35DD0]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M08_L23:
       mov       rax,242F2570008
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
       call      qword ptr [7FF9F835D3C8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M08_L27:
       sar       r9d,2
       lea       eax,[r9+r9*2]
       jmp       near ptr M08_L03
M08_L28:
       vmovups   xmm0,[r9]
       vpshufb   xmm0,xmm0,[7FF9F8466A80]
       vpand     xmm1,xmm0,[7FF9F8466A90]
       vpmulhuw  xmm1,xmm1,[7FF9F8466AA0]
       vpand     xmm0,xmm0,[7FF9F8466AB0]
       vpmullw   xmm0,xmm0,[7FF9F8466AC0]
       vpor      xmm0,xmm0,xmm1
       vpsubusb  xmm1,xmm0,[7FF9F8466AD0]
       vpcmpgtb  xmm2,xmm0,[7FF9F8466AE0]
       vpsubb    xmm1,xmm1,xmm2
       vmovups   xmm2,[7FF9F8466A20]
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
       mov       [rsp+48],rbp
       mov       rdx,rbp
       test      rsi,rsi
       jne       short M08_L32
       xor       ecx,ecx
       jmp       short M08_L33
M08_L32:
       lea       rcx,[rsi+0C]
       mov       [rsp+40],rcx
       mov       rcx,[rsp+40]
M08_L33:
       mov       [rsp+20],edi
       mov       r9d,ebx
       xor       r8d,r8d
       call      qword ptr [7FF9F835D3B0]
       xor       eax,eax
       mov       [rsp+40],rax
       mov       [rsp+48],rax
       jmp       near ptr M08_L16
M08_L34:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 1615
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
       call      qword ptr [7FF9F7AE57E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
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
       mov       rcx,2025D400C90
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
       call      qword ptr [7FF9F835DB00]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M09_L00
M09_L06:
       mov       rcx,rdi
       call      qword ptr [7FF9F81CFDC8]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
       mov       r15,rax
       jmp       near ptr M09_L01
M09_L07:
       mov       ecx,2
       call      qword ptr [7FF9F7D6C1C8]
       int       3
M09_L08:
       shr       rdx,3
       mov       rcx,rax
       call      qword ptr [7FF9F835CEA0]
       jmp       near ptr M09_L02
M09_L09:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       call      qword ptr [7FF9F835DB18]
       mov       rbx,rax
       mov       ecx,29B
       mov       rdx,7FF9F7A24000
       call      qword ptr [7FF9F7D67738]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rbp
       call      qword ptr [7FF9F7F35DD0]
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
       call      qword ptr [7FF9F835DB30]
M09_L11:
       mov       r12,[rax+8]
       mov       rcx,offset MT_System.Threading.ProcessorIdCache
       call      System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       cmp       byte ptr [7FF9F7A2B1CC],0
       je        short M09_L12
       call      qword ptr [7FF9F835DB48]
       mov       esi,eax
       jmp       short M09_L14
M09_L12:
       mov       ecx,0A
       call      qword ptr [7FF9F835DB60]
       mov       esi,[rax+10]
       mov       ecx,0A
       call      qword ptr [7FF9F835DB60]
       lea       ecx,[rsi-1]
       mov       [rax+10],ecx
       movzx     eax,si
       test      eax,eax
       jne       short M09_L13
       call      qword ptr [7FF9F835DB78]
       mov       esi,eax
       jmp       short M09_L14
M09_L13:
       sar       esi,10
M09_L14:
       mov       rcx,offset MT_System.Buffers.SharedArrayPoolStatics
       call      System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       eax,esi
       xor       edx,edx
       div       dword ptr [7FF9F7A2B1C0]
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
       call      qword ptr [7FF9F80CD5D8]; System.Threading.Monitor.Enter(System.Object)
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
       call      qword ptr [7FF9F7AE6820]; System.Threading.Monitor.Exit(System.Object)
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
       call      qword ptr [7FF9F7FDC918]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r15d,eax
       mov       [rsp+44],ebp
       cmp       [rdi],dil
       mov       rcx,rdi
       call      qword ptr [7FF9F7FDC918]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,rsi
       mov       r8d,r15d
       mov       r9d,[rsp+44]
       mov       edx,3
       call      qword ptr [7FF9F835DB90]
       test      r12d,r13d
       jne       near ptr M09_L04
       mov       rcx,rbx
       call      qword ptr [7FF9F7FDC918]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       ebx,eax
       mov       rcx,rdi
       call      qword ptr [7FF9F7FDC918]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
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
       call      qword ptr [7FF9F835DBA8]
       jmp       near ptr M09_L04
M09_L28:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 913
```

