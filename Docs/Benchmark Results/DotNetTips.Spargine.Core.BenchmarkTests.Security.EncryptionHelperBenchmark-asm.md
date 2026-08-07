## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Security.EncryptionHelperBenchmark.AesGcmEncrypt()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,2B8
       vzeroupper
       lea       rbp,[rsp+2F0]
       xor       eax,eax
       mov       [rbp-238],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-230],xmm4
       mov       rax,0FFFFFFFFFFFFFE20
M00_L00:
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       vmovdqa   xmmword ptr [rbp+rax-20],xmm4
       add       rax,30
       jne       short M00_L00
       mov       [rbp+10],rcx
       mov       rbx,rcx
       lea       rcx,[rbp-190]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rcx,rsp
       mov       [rbp-178],rcx
       mov       rcx,rbp
       mov       [rbp-168],rcx
       mov       rdi,[rbx+30]
       mov       r14,[rbx+1B0]
       mov       rcx,[rbx+1A8]
       test      rcx,rcx
       je        short M00_L01
       lea       r15,[rcx+10]
       mov       r13d,[rcx+8]
       jmp       short M00_L02
M00_L01:
       xor       r15d,r15d
       xor       r13d,r13d
M00_L02:
       mov       [rbp-298],r15
       mov       [rbp-200],r14
       test      rdi,rdi
       je        near ptr M00_L52
       mov       ecx,[rdi+8]
       cmp       dword ptr [rdi+8],0
       je        near ptr M00_L52
       movzx     ecx,word ptr [rdi+0C]
       cmp       ecx,100
       jge       near ptr M00_L54
       mov       rax,7FFE8B9F6B88
       test      byte ptr [rax+rcx],80
       jne       near ptr M00_L56
M00_L03:
       mov       ecx,[rdi+8]
       dec       ecx
       cmp       ecx,[rdi+8]
       jae       near ptr M00_L100
       movzx     ecx,word ptr [rdi+rcx*2+0C]
       cmp       ecx,100
       jge       near ptr M00_L55
       mov       rax,7FFE8B9F6B88
       test      byte ptr [rax+rcx],80
       jne       near ptr M00_L56
M00_L04:
       mov       [rbp-1F8],rdi
       test      r14,r14
       je        near ptr M00_L57
       mov       r8d,[r14+8]
       test      r8d,r8d
       setg      r8b
       movzx     r8d,r8b
       test      r8d,r8d
       je        near ptr M00_L57
       cmp       dword ptr [r14+8],20
       jne       near ptr M00_L59
       mov       r8,24944800220
       mov       r12,[r8]
       mov       [rbp-2B8],r12
       mov       [rbp-208],r12
       test      rdi,rdi
       je        near ptr M00_L60
       lea       r8,[rdi+0C]
       mov       [rbp-58],r8
       mov       r10,[rbp-58]
       mov       [rbp-1A0],r10
       mov       r11d,[rdi+8]
       mov       [rbp-5C],r11d
       lea       r8,[rbp-68]
       lea       r9,[rbp-70]
       mov       rcx,r10
       mov       edx,r11d
       call      qword ptr [7FFE2CC0FAF8]; System.Text.Unicode.Utf16Utility.GetPointerToFirstInvalidChar(Char*, Int32, Int64 ByRef, Int32 ByRef)
       mov       rdx,[rbp-1A0]
       sub       rax,rdx
       mov       r9,rax
       shr       r9,3F
       add       r9,rax
       sar       r9,1
       movsxd    rax,r9d
       add       rax,[rbp-68]
       cmp       rax,7FFFFFFF
       ja        near ptr M00_L62
       mov       [rbp-60],eax
       mov       r8d,[rbp-5C]
       cmp       r9d,r8d
       jne       near ptr M00_L61
M00_L05:
       xor       ecx,ecx
       mov       [rbp-58],rcx
       mov       ecx,1
       mov       eax,[rbp-60]
       test      eax,eax
       cmovle    eax,ecx
       mov       [rbp-3C],eax
       mov       rcx,24944801EB0
       mov       rdx,[rcx]
       mov       [rbp-2A8],rdx
       mov       [rbp-248],rdx
       mov       dword ptr [rbp-74],0C
       mov       rcx,24944800C90
       mov       r9,[rcx]
       mov       [rbp-2B0],r9
       mov       [rbp-240],r9
       mov       rcx,gs:[58]
       mov       rcx,[rcx+38]
       cmp       dword ptr [rcx+238],9
       jle       near ptr M00_L63
       mov       rcx,[rcx+240]
       mov       rcx,[rcx+48]
       test      rcx,rcx
       je        near ptr M00_L63
M00_L06:
       mov       [rbp-2A0],rcx
       mov       r10,[rcx+10]
       test      r10,r10
       je        short M00_L07
       cmp       dword ptr [r10+8],0
       je        short M00_L07
       mov       r11,[r10+10]
       test      r11,r11
       jne       near ptr M00_L14
M00_L07:
       mov       r8,[rbp-248]
       mov       r10,[r8+10]
       mov       r11d,[r10+8]
       test      r11d,r11d
       je        near ptr M00_L70
       mov       r10,[r10+10]
       test      r10,r10
       je        near ptr M00_L69
       mov       r10,[r10+8]
       mov       [rbp-258],r10
       xor       r11d,r11d
       mov       [rbp-90],r11d
       lea       rcx,[rbp-90]
       mov       r11,7FFFAEBF22E0
       call      r11
       movzx     ebx,word ptr [rbp-90]
       shl       ebx,6
       movzx     edi,byte ptr [rbp-8E]
       or        ebx,edi
       mov       eax,0AAAAAAAB
       mov       ecx,ebx
       imul      rax,rcx
       shr       rax,23
       imul      eax,0C
       sub       ebx,eax
       xor       edi,edi
       cmp       dword ptr [7FFE8CB54A90],0
       jne       near ptr M00_L65
M00_L08:
       mov       r14,[rbp-258]
       cmp       dword ptr [r14+8],0
       jle       near ptr M00_L67
M00_L09:
       cmp       ebx,[r14+8]
       jae       near ptr M00_L100
       mov       ecx,ebx
       mov       r15,[r14+rcx*8+10]
       cmp       [r15],r15b
       xor       r12d,r12d
       mov       rcx,r15
       call      00007FFE8C89DF30
       test      eax,eax
       jne       short M00_L10
       mov       rcx,r15
       call      qword ptr [7FFE2D2BC450]
M00_L10:
       mov       rcx,[r15+8]
       mov       eax,[r15+10]
       dec       eax
       cmp       [rcx+8],eax
       ja        short M00_L15
M00_L11:
       mov       rcx,r15
       call      00007FFE8C89DE50
       test      eax,eax
       jne       near ptr M00_L66
M00_L12:
       test      r12,r12
       jne       short M00_L17
       inc       ebx
       cmp       [r14+8],ebx
       je        short M00_L16
M00_L13:
       inc       edi
       cmp       [r14+8],edi
       jg        short M00_L09
       jmp       near ptr M00_L67
M00_L14:
       xor       eax,eax
       mov       [r10+10],rax
       mov       rax,[rbp-240]
       cmp       byte ptr [rax+9D],0
       jne       near ptr M00_L64
       mov       rbx,r11
       jmp       short M00_L19
M00_L15:
       mov       edx,eax
       mov       r12,[rcx+rdx*8+10]
       mov       edx,eax
       xor       r8d,r8d
       mov       [rcx+rdx*8+10],r8
       mov       [r15+10],eax
       jmp       short M00_L11
M00_L16:
       xor       ebx,ebx
       jmp       short M00_L13
M00_L17:
       mov       rdx,r12
M00_L18:
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M00_L69
       mov       rdi,[rbp-240]
       cmp       byte ptr [rdi+9D],0
       jne       near ptr M00_L68
M00_L19:
       mov       [rbp-210],rbx
       mov       rbx,[rbp-2A8]
       mov       [rbp-268],rbx
       mov       edx,[rbp-3C]
       mov       r8d,edx
       mov       r10,[rbp-2B0]
       mov       r9,r10
       mov       [rbp-260],r9
       lea       ecx,[r8-1]
       or        ecx,0F
       xor       r11d,r11d
       lzcnt     r11d,ecx
       xor       r11d,1F
       add       r11d,0FFFFFFFD
       mov       [rbp-98],r11d
       mov       rcx,[rbp-2A0]
       mov       r15,[rcx+10]
       test      r15,r15
       mov       rbx,[rbp-2A8]
       je        near ptr M00_L76
       cmp       [r15+8],r11d
       jbe       near ptr M00_L75
       cmp       r11d,[r15+8]
       jae       near ptr M00_L100
       mov       r12d,r11d
       shl       r12,4
       mov       r12,[r15+r12+10]
       test      r12,r12
       jne       near ptr M00_L27
M00_L20:
       mov       rax,[rbp-268]
       mov       r15,[rax+10]
       mov       r9d,[r15+8]
       cmp       r9d,r11d
       jbe       near ptr M00_L84
       cmp       r11d,r9d
       jae       near ptr M00_L100
       mov       r8d,r11d
       mov       r8,[r15+r8*8+10]
       test      r8,r8
       je        near ptr M00_L83
       mov       [rbp-2A8],rbx
       mov       r15,[r8+8]
       mov       [rbp-270],r15
       xor       r8d,r8d
       mov       [rbp-0B0],r8d
       lea       rcx,[rbp-0B0]
       mov       r8,7FFFAEBF22E0
       call      r8
       movzx     ebx,word ptr [rbp-0B0]
       shl       ebx,6
       movzx     edi,byte ptr [rbp-0AE]
       or        ebx,edi
       mov       eax,0AAAAAAAB
       mov       ecx,ebx
       imul      rax,rcx
       shr       rax,23
       imul      eax,0C
       sub       ebx,eax
       xor       edi,edi
       cmp       dword ptr [7FFE8CB54A90],0
       jne       near ptr M00_L78
M00_L21:
       mov       r15,[rbp-270]
       cmp       dword ptr [r15+8],0
       jle       near ptr M00_L80
M00_L22:
       cmp       ebx,[r15+8]
       jae       near ptr M00_L100
       mov       ecx,ebx
       mov       r14,[r15+rcx*8+10]
       cmp       [r14],r14b
       xor       r12d,r12d
       mov       rcx,r14
       call      00007FFE8C89DF30
       test      eax,eax
       jne       short M00_L23
       mov       rcx,r14
       call      qword ptr [7FFE2D2BC450]
M00_L23:
       mov       rcx,[r14+8]
       mov       eax,[r14+10]
       dec       eax
       cmp       [rcx+8],eax
       ja        short M00_L28
M00_L24:
       mov       rcx,r14
       call      00007FFE8C89DE50
       test      eax,eax
       jne       near ptr M00_L79
M00_L25:
       test      r12,r12
       jne       short M00_L30
       inc       ebx
       cmp       [r15+8],ebx
       je        short M00_L29
M00_L26:
       inc       edi
       cmp       [r15+8],edi
       jg        short M00_L22
       jmp       near ptr M00_L80
M00_L27:
       cmp       r11d,[r15+8]
       jae       near ptr M00_L100
       mov       r8d,r11d
       shl       r8,4
       xor       edx,edx
       mov       [r15+r8+10],rdx
       cmp       byte ptr [r9+9D],0
       je        short M00_L31
       jmp       near ptr M00_L74
M00_L28:
       cmp       eax,[rcx+8]
       jae       near ptr M00_L100
       mov       edx,eax
       mov       r12,[rcx+rdx*8+10]
       cmp       eax,[rcx+8]
       jae       near ptr M00_L100
       mov       edx,eax
       xor       r8d,r8d
       mov       [rcx+rdx*8+10],r8
       mov       [r14+10],eax
       jmp       short M00_L24
M00_L29:
       xor       ebx,ebx
       jmp       short M00_L26
M00_L30:
       test      r12,r12
       je        near ptr M00_L82
       mov       rbx,[rbp-260]
       cmp       byte ptr [rbx+9D],0
       jne       near ptr M00_L81
       mov       rbx,[rbp-2A8]
M00_L31:
       mov       [rbp-218],r12
       mov       rcx,rbx
       mov       edx,[rbp-3C]
       call      qword ptr [7FFE2D242388]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Rent(Int32)
       mov       [rbp-220],rax
       mov       [rbp-280],rbx
       mov       r15,[rbp-2B0]
       mov       [rbp-278],r15
       mov       r12,[rbp-2A0]
       mov       rcx,[r12+10]
       test      rcx,rcx
       je        short M00_L32
       cmp       dword ptr [rcx+8],0
       je        short M00_L32
       cmp       dword ptr [rcx+8],0
       jbe       near ptr M00_L100
       mov       r12,[rcx+10]
       test      r12,r12
       jne       near ptr M00_L39
M00_L32:
       mov       rcx,[rbx+10]
       mov       eax,[rcx+8]
       test      eax,eax
       je        near ptr M00_L98
       test      eax,eax
       je        near ptr M00_L100
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        near ptr M00_L93
       mov       r12,[rcx+8]
       mov       [rbp-290],r12
       xor       ecx,ecx
       mov       [rbp-0C8],ecx
       lea       rcx,[rbp-0C8]
       mov       rax,7FFFAEBF22E0
       call      rax
       movzx     ebx,word ptr [rbp-0C8]
       shl       ebx,6
       movzx     edi,byte ptr [rbp-0C6]
       or        ebx,edi
       mov       eax,0AAAAAAAB
       mov       ecx,ebx
       imul      rax,rcx
       shr       rax,23
       imul      eax,0C
       sub       ebx,eax
       xor       edi,edi
       cmp       dword ptr [7FFE8CB54A90],0
       jne       near ptr M00_L91
M00_L33:
       mov       r12,[rbp-290]
       cmp       dword ptr [r12+8],0
       jle       near ptr M00_L94
M00_L34:
       cmp       ebx,[r12+8]
       jae       near ptr M00_L100
       mov       ecx,ebx
       mov       r14,[r12+rcx*8+10]
       cmp       [r14],r14b
       xor       r15d,r15d
       mov       rcx,r14
       call      00007FFE8C89DF30
       test      eax,eax
       jne       short M00_L35
       mov       rcx,r14
       call      qword ptr [7FFE2D2BC450]
M00_L35:
       mov       rcx,[r14+8]
       mov       eax,[r14+10]
       dec       eax
       cmp       [rcx+8],eax
       ja        short M00_L40
M00_L36:
       mov       rcx,r14
       call      00007FFE8C89DE50
       test      eax,eax
       jne       near ptr M00_L92
M00_L37:
       test      r15,r15
       jne       short M00_L42
       inc       ebx
       cmp       [r12+8],ebx
       je        short M00_L41
M00_L38:
       inc       edi
       cmp       [r12+8],edi
       jg        short M00_L34
       jmp       near ptr M00_L94
M00_L39:
       cmp       dword ptr [rcx+8],0
       jbe       near ptr M00_L100
       xor       eax,eax
       mov       [rcx+10],rax
       cmp       byte ptr [r15+9D],0
       je        short M00_L44
       jmp       near ptr M00_L89
M00_L40:
       cmp       eax,[rcx+8]
       jae       near ptr M00_L100
       mov       edx,eax
       mov       r15,[rcx+rdx*8+10]
       cmp       eax,[rcx+8]
       jae       near ptr M00_L100
       mov       edx,eax
       xor       r8d,r8d
       mov       [rcx+rdx*8+10],r8
       mov       [r14+10],eax
       jmp       short M00_L36
M00_L41:
       xor       ebx,ebx
       jmp       short M00_L38
M00_L42:
       mov       r12,r15
M00_L43:
       test      r12,r12
       je        near ptr M00_L96
       mov       r15,[rbp-278]
       cmp       byte ptr [r15+9D],0
       jne       near ptr M00_L95
M00_L44:
       mov       [rbp-288],r12
       mov       [rbp-228],r12
       xor       edx,edx
       mov       [rbp-40],edx
       cmp       qword ptr [rbp-210],0
       je        near ptr M00_L48
       mov       rbx,[rbp-210]
       cmp       dword ptr [rbx+8],0C
       jl        near ptr M00_L48
       lea       rdx,[rbx+10]
       mov       [rbp-0D0],rdx
       xor       ecx,ecx
       mov       r8d,0C
       mov       r9d,2
       mov       rax,7FFE2D03F758
       mov       [rbp-180],rax
       lea       rax,[M00_L45]
       mov       [rbp-170],rax
       lea       rax,[rbp-190]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFFAC8B3670
       call      rax
M00_L45:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFE8CB54A90],0
       je        short M00_L46
       call      qword ptr [7FFE8CB42648]; CORINFO_HELP_STOP_FOR_GC
M00_L46:
       mov       rdx,[rbp-188]
       mov       [rsi+8],rdx
       test      eax,eax
       jne       near ptr M00_L49
       xor       edx,edx
       mov       [rbp-0D0],rdx
       mov       r12,[rbp-2B8]
       mov       rcx,r12
       mov       rdi,[rbp-1F8]
       lea       rdx,[rdi+0C]
       mov       r8d,[rdi+8]
       cmp       qword ptr [rbp-218],0
       je        near ptr M00_L50
       mov       r12,[rbp-218]
       lea       rax,[r12+10]
       mov       r10d,[r12+8]
M00_L47:
       mov       [rbp-1B0],rdx
       mov       [rbp-1A8],r8d
       mov       [rbp-1C0],rax
       mov       [rbp-1B8],r10d
       lea       rdx,[rbp-1B0]
       lea       r8,[rbp-1C0]
       call      qword ptr [7FFE2CD5F1F8]; System.Text.UTF8Encoding.GetBytes(System.ReadOnlySpan`1<Char>, System.Span`1<Byte>)
       mov       ebx,eax
       mov       [rbp-40],ebx
       mov       rcx,offset MT_System.Security.Cryptography.AesGcm
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,[rbp-200]
       mov       r8d,10
       call      qword ptr [7FFE2D23C6F0]; System.Security.Cryptography.AesGcm..ctor(Byte[], Int32)
       mov       [rbp-230],rsi
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-0E0],xmm0
       lea       rcx,[rbp-0E0]
       mov       rdx,[rbp-210]
       xor       r8d,r8d
       mov       r9d,0C
       call      qword ptr [7FFE2D237E40]; System.Span`1[[System.Byte, System.Private.CoreLib]]..ctor(Byte[], Int32, Int32)
       mov       rdi,[rbp-0E0]
       mov       r14d,[rbp-0D8]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-0F0],xmm0
       lea       rcx,[rbp-0F0]
       mov       rdx,r12
       mov       r9d,ebx
       xor       r8d,r8d
       call      qword ptr [7FFE2D237E40]; System.Span`1[[System.Byte, System.Private.CoreLib]]..ctor(Byte[], Int32, Int32)
       vmovdqu   xmm0,xmmword ptr [rbp-0F0]
       vmovdqu   xmmword ptr [rbp-1C0],xmm0
       lea       rdx,[rbp-1C0]
       lea       rcx,[rbp-50]
       call      qword ptr [7FFE2D02C990]; System.Span`1[[System.Byte, System.Private.CoreLib]].op_Implicit(System.Span`1<Byte>)
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-100],xmm0
       lea       rcx,[rbp-100]
       mov       rdx,[rbp-220]
       mov       r9d,ebx
       xor       r8d,r8d
       call      qword ptr [7FFE2D237E40]; System.Span`1[[System.Byte, System.Private.CoreLib]]..ctor(Byte[], Int32, Int32)
       mov       r15,[rbp-100]
       mov       eax,[rbp-0F8]
       mov       [rbp-194],eax
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-110],xmm0
       lea       rcx,[rbp-110]
       mov       rdx,[rbp-288]
       xor       r8d,r8d
       mov       r9d,10
       call      qword ptr [7FFE2D237E40]; System.Span`1[[System.Byte, System.Private.CoreLib]]..ctor(Byte[], Int32, Int32)
       mov       [rbp-1D0],rdi
       mov       [rbp-1C8],r14d
       mov       [rbp-1C0],r15
       mov       edi,[rbp-194]
       mov       [rbp-1B8],edi
       vmovdqu   xmm0,xmmword ptr [rbp-110]
       vmovdqu   xmmword ptr [rbp-1E0],xmm0
       mov       r15,[rbp-298]
       mov       [rbp-1F0],r15
       mov       [rbp-1E8],r13d
       lea       rdx,[rbp-1D0]
       lea       r9,[rbp-1C0]
       lea       r8,[rbp-1E0]
       mov       [rsp+20],r8
       lea       r8,[rbp-1F0]
       mov       [rsp+28],r8
       lea       r8,[rbp-50]
       mov       rcx,rsi
       call      qword ptr [7FFE2D23C708]; System.Security.Cryptography.AesGcm.Encrypt(System.ReadOnlySpan`1<Byte>, System.ReadOnlySpan`1<Byte>, System.Span`1<Byte>, System.Span`1<Byte>, System.ReadOnlySpan`1<Byte>)
       nop
       mov       rcx,[rsi+8]
       cmp       [rcx],ecx
       call      qword ptr [7FFE2CD00298]; System.Runtime.InteropServices.SafeHandle.Dispose()
       mov       rcx,[rbp-210]
       mov       rdx,[rbp-220]
       mov       r8,[rbp-288]
       mov       r9d,ebx
       call      qword ptr [7FFE2D23C720]; DotNetTips.Spargine.Core.Security.EncryptionHelper.AssembleGcmPayload(Byte[], Byte[], Byte[], Int32)
       mov       [rbp-238],rax
       jmp       short M00_L51
M00_L48:
       call      qword ptr [7FFE2CD77198]
       int       3
M00_L49:
       mov       ecx,eax
       call      qword ptr [7FFE2D2B7F78]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M00_L50:
       mov       r12,[rbp-218]
       xor       eax,eax
       xor       r10d,r10d
       jmp       near ptr M00_L47
       int       3
M00_L51:
       call      M00_L101
       nop
       mov       rax,[rbp-238]
       mov       [rbp-158],rax
       mov       rbx,[rbp+10]
       mov       rcx,[rbx+88]
       lea       r8,[rbp-158]
       mov       rdx,7FFE2D2C4A20
       cmp       [rcx],ecx
       call      qword ptr [7FFE2D2B5068]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,2B8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L52:
       call      qword ptr [7FFE2D024858]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L53
       call      qword ptr [7FFE2D2BD8F0]
       mov       rbx,rax
M00_L53:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,289D97203A0
       call      qword ptr [7FFE2D2BD3B0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L54:
       call      qword ptr [7FFE2D2BCAE0]
       test      eax,eax
       jne       short M00_L56
       jmp       near ptr M00_L03
M00_L55:
       call      qword ptr [7FFE2D2BCAE0]
       test      eax,eax
       je        near ptr M00_L04
M00_L56:
       mov       rcx,rdi
       mov       edx,3
       call      qword ptr [7FFE2D2BCAF8]
       mov       rdi,rax
       jmp       near ptr M00_L04
M00_L57:
       call      qword ptr [7FFE2D237330]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L58
       call      qword ptr [7FFE2D2BD8F0]
       mov       rbx,rax
M00_L58:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,289D9719C08
       call      qword ptr [7FFE2D2BD3B0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L59:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,0FD4
       mov       rdx,7FFE2CED4D10
       call      qword ptr [7FFE2CE27798]
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,289D9720978
       call      qword ptr [7FFE2CF86208]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L60:
       mov       ecx,0E
       call      qword ptr [7FFE2CE2C228]
       int       3
M00_L61:
       mov       rcx,[rbp-208]
       call      qword ptr [7FFE2D2BD008]
       add       eax,[rbp-60]
       mov       ecx,eax
       test      ecx,ecx
       mov       [rbp-60],ecx
       jge       near ptr M00_L05
M00_L62:
       call      qword ptr [7FFE2D19E718]
       int       3
M00_L63:
       mov       ecx,9
       call      qword ptr [7FFE2D2BC0A8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       rcx,rax
       jmp       near ptr M00_L06
M00_L64:
       mov       [rbp-250],r11
       mov       rcx,r11
       call      qword ptr [7FFE2D02D698]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rbp-84],eax
       mov       rdx,[rbp-250]
       mov       r8d,[rdx+8]
       mov       [rbp-88],r8d
       mov       rcx,[rbp-248]
       call      qword ptr [7FFE2D02D698]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       xor       edx,edx
       mov       [rsp+20],edx
       mov       edx,[rbp-84]
       mov       r8d,[rbp-88]
       mov       rcx,[rbp-240]
       call      qword ptr [7FFE2D2BD440]
       mov       rbx,[rbp-250]
       jmp       near ptr M00_L19
M00_L65:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L08
M00_L66:
       mov       ecx,eax
       mov       rdx,r15
       call      qword ptr [7FFE2D2B7ED0]
       jmp       near ptr M00_L12
M00_L67:
       xor       edx,edx
       jmp       near ptr M00_L18
M00_L68:
       mov       rcx,rbx
       call      qword ptr [7FFE2D02D698]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r14d,eax
       mov       r15d,[rbx+8]
       mov       rcx,[rbp-248]
       call      qword ptr [7FFE2D02D698]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       xor       edx,edx
       mov       [rsp+20],edx
       mov       edx,r14d
       mov       r8d,r15d
       mov       rcx,rdi
       call      qword ptr [7FFE2D2BD440]
       jmp       near ptr M00_L19
M00_L69:
       mov       dword ptr [rbp-74],10
       jmp       short M00_L71
M00_L70:
       mov       ecx,0C
       mov       rdx,289D9716F28
       call      qword ptr [7FFE2CE2D998]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
M00_L71:
       mov       r10d,[rbp-74]
       cmp       r10d,800
       jge       short M00_L72
       mov       edx,r10d
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       jmp       short M00_L73
M00_L72:
       mov       ecx,r10d
       xor       edx,edx
       call      qword ptr [7FFE2D2BD428]
M00_L73:
       mov       rdx,[rbp-240]
       cmp       byte ptr [rdx+9D],0
       je        near ptr M00_L77
       cmp       [rax],al
       mov       [rbp-250],rax
       mov       rcx,rax
       call      qword ptr [7FFE2D02D698]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rbp-78],eax
       mov       rdx,[rbp-250]
       mov       r8d,[rdx+8]
       mov       [rbp-7C],r8d
       mov       rcx,[rbp-248]
       call      qword ptr [7FFE2D02D698]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       edx,[rbp-78]
       mov       r8d,[rbp-7C]
       mov       rcx,[rbp-240]
       call      qword ptr [7FFE2D2BD440]
       mov       rax,[rbp-250]
       mov       edx,[rax+8]
       mov       [rbp-80],edx
       mov       rcx,[rbp-248]
       call      qword ptr [7FFE2D02D698]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       rcx,[rbp-248]
       mov       rcx,[rcx+10]
       mov       edx,1
       mov       r8d,2
       cmp       dword ptr [rcx+8],0
       cmovg     edx,r8d
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       [rsp+28],edx
       mov       rcx,[rbp-240]
       mov       edx,[rbp-78]
       mov       r8d,[rbp-80]
       call      qword ptr [7FFE2D2BD458]
       mov       rbx,[rbp-250]
       jmp       near ptr M00_L19
M00_L74:
       mov       rcx,r12
       call      qword ptr [7FFE2D02D698]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r15d,eax
       mov       eax,[r12+8]
       mov       [rbp-0A8],eax
       mov       rcx,[rbp-268]
       call      qword ptr [7FFE2D02D698]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       eax,[rbp-98]
       mov       [rsp+20],eax
       mov       edx,r15d
       mov       r8d,[rbp-0A8]
       mov       rcx,[rbp-260]
       call      qword ptr [7FFE2D2BD440]
       jmp       near ptr M00_L31
M00_L75:
       jmp       near ptr M00_L20
M00_L76:
       jmp       near ptr M00_L20
M00_L77:
       mov       rbx,rax
       jmp       near ptr M00_L19
M00_L78:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L21
M00_L79:
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FFE2D2B7ED0]
       jmp       near ptr M00_L25
M00_L80:
       xor       r12d,r12d
       jmp       near ptr M00_L30
M00_L81:
       mov       rcx,r12
       call      qword ptr [7FFE2D02D698]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       edi,eax
       mov       r14d,[r12+8]
       mov       rcx,[rbp-268]
       call      qword ptr [7FFE2D02D698]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       r15d,[rbp-98]
       mov       [rsp+20],r15d
       mov       edx,edi
       mov       r8d,r14d
       mov       rcx,rbx
       call      qword ptr [7FFE2D2BD440]
       mov       rbx,[rbp-2A8]
       jmp       near ptr M00_L31
M00_L82:
       mov       rbx,[rbp-2A8]
M00_L83:
       mov       r8d,10
       mov       r11d,[rbp-98]
       shlx      r8d,r8d,r11d
       mov       r15d,r8d
       jmp       short M00_L86
M00_L84:
       test      r8d,r8d
       jne       short M00_L85
       mov       rax,289D97162A0
       mov       r12,rax
       jmp       near ptr M00_L31
M00_L85:
       mov       [rbp-94],r8d
       mov       ecx,r8d
       mov       rdx,289D9716F28
       call      qword ptr [7FFE2CE2D998]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
       mov       r15d,[rbp-94]
M00_L86:
       cmp       r15d,800
       jge       short M00_L87
       movsxd    rdx,r15d
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       jmp       short M00_L88
M00_L87:
       mov       ecx,r15d
       xor       edx,edx
       call      qword ptr [7FFE2D2BD428]
M00_L88:
       mov       r15,rax
       mov       rax,[rbp-260]
       cmp       byte ptr [rax+9D],0
       je        near ptr M00_L90
       cmp       [r15],r15b
       mov       rcx,r15
       call      qword ptr [7FFE2D02D698]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rbp-9C],eax
       mov       edx,[r15+8]
       mov       [rbp-0A0],edx
       mov       rcx,[rbp-268]
       call      qword ptr [7FFE2D02D698]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       edx,[rbp-9C]
       mov       r8d,[rbp-0A0]
       mov       rcx,[rbp-260]
       call      qword ptr [7FFE2D2BD440]
       mov       eax,[r15+8]
       mov       [rbp-0A4],eax
       mov       rcx,[rbp-268]
       call      qword ptr [7FFE2D02D698]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       rcx,[rbp-268]
       mov       rcx,[rcx+10]
       mov       edx,1
       mov       r8d,2
       mov       r11d,[rbp-98]
       cmp       [rcx+8],r11d
       cmovg     edx,r8d
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       [rsp+28],edx
       mov       rcx,[rbp-260]
       mov       edx,[rbp-9C]
       mov       r8d,[rbp-0A4]
       call      qword ptr [7FFE2D2BD458]
       mov       r12,r15
       jmp       near ptr M00_L31
M00_L89:
       mov       rcx,r12
       call      qword ptr [7FFE2D02D698]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rbp-0B8],eax
       mov       edx,[r12+8]
       mov       [rbp-0BC],edx
       mov       rcx,rbx
       call      qword ptr [7FFE2D02D698]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       xor       edx,edx
       mov       [rsp+20],edx
       mov       edx,[rbp-0B8]
       mov       r8d,[rbp-0BC]
       mov       rcx,r15
       call      qword ptr [7FFE2D2BD440]
       jmp       near ptr M00_L44
M00_L90:
       mov       r12,r15
       jmp       near ptr M00_L31
M00_L91:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L33
M00_L92:
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FFE2D2B7ED0]
       jmp       near ptr M00_L37
M00_L93:
       mov       rbx,[rbp-280]
       jmp       short M00_L97
M00_L94:
       xor       r12d,r12d
       jmp       near ptr M00_L43
M00_L95:
       mov       rcx,r12
       call      qword ptr [7FFE2D02D698]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       ebx,eax
       mov       edi,[r12+8]
       mov       rcx,[rbp-280]
       call      qword ptr [7FFE2D02D698]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       xor       edx,edx
       mov       [rsp+20],edx
       mov       edx,ebx
       mov       r8d,edi
       mov       rcx,r15
       call      qword ptr [7FFE2D2BD440]
       jmp       near ptr M00_L44
M00_L96:
       mov       rbx,[rbp-280]
       mov       r15,[rbp-278]
M00_L97:
       mov       edx,10
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r12,rax
       cmp       byte ptr [r15+9D],0
       je        near ptr M00_L44
       jmp       short M00_L99
M00_L98:
       mov       rbx,[rbp-280]
       mov       ecx,10
       mov       rdx,289D9716F28
       call      qword ptr [7FFE2CE2D998]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
       jmp       short M00_L97
M00_L99:
       mov       rcx,r12
       call      qword ptr [7FFE2D02D698]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rbp-0B4],eax
       mov       rcx,rbx
       call      qword ptr [7FFE2D02D698]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       edx,[rbp-0B4]
       mov       r8d,10
       mov       rcx,r15
       call      qword ptr [7FFE2D2BD440]
       mov       rcx,rbx
       call      qword ptr [7FFE2D02D698]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       rcx,[rbx+10]
       mov       edx,1
       mov       r8d,2
       cmp       dword ptr [rcx+8],0
       cmovg     edx,r8d
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       [rsp+28],edx
       mov       rcx,r15
       mov       edx,[rbp-0B4]
       mov       r8d,10
       call      qword ptr [7FFE2D2BD458]
       jmp       near ptr M00_L44
M00_L100:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       sub       rsp,38
       vzeroupper
       mov       rcx,[rbp-230]
       mov       rcx,[rcx+8]
       cmp       [rcx],ecx
       call      qword ptr [7FFE2CD00298]; System.Runtime.InteropServices.SafeHandle.Dispose()
       nop
       add       rsp,38
       ret
M00_L101:
       sub       rsp,38
       vzeroupper
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-120],xmm0
       lea       rcx,[rbp-120]
       mov       rdx,[rbp-218]
       mov       r9d,[rbp-40]
       xor       r8d,r8d
       call      qword ptr [7FFE2D237E40]; System.Span`1[[System.Byte, System.Private.CoreLib]]..ctor(Byte[], Int32, Int32)
       vmovdqu   xmm0,xmmword ptr [rbp-120]
       vmovdqu   xmmword ptr [rbp-1C0],xmm0
       lea       rcx,[rbp-1C0]
       call      qword ptr [7FFE2D237E58]; System.Security.Cryptography.CryptographicOperations.ZeroMemory(System.Span`1<Byte>)
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-130],xmm0
       lea       rcx,[rbp-130]
       mov       rdx,[rbp-220]
       mov       r9d,[rbp-40]
       xor       r8d,r8d
       call      qword ptr [7FFE2D237E40]; System.Span`1[[System.Byte, System.Private.CoreLib]]..ctor(Byte[], Int32, Int32)
       vmovdqu   xmm0,xmmword ptr [rbp-130]
       vmovdqu   xmmword ptr [rbp-1C0],xmm0
       lea       rcx,[rbp-1C0]
       call      qword ptr [7FFE2D237E58]; System.Security.Cryptography.CryptographicOperations.ZeroMemory(System.Span`1<Byte>)
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-140],xmm0
       lea       rcx,[rbp-140]
       mov       rdx,[rbp-228]
       xor       r8d,r8d
       mov       r9d,10
       call      qword ptr [7FFE2D237E40]; System.Span`1[[System.Byte, System.Private.CoreLib]]..ctor(Byte[], Int32, Int32)
       vmovdqu   xmm0,xmmword ptr [rbp-140]
       vmovdqu   xmmword ptr [rbp-1C0],xmm0
       lea       rcx,[rbp-1C0]
       call      qword ptr [7FFE2D237E58]; System.Security.Cryptography.CryptographicOperations.ZeroMemory(System.Span`1<Byte>)
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-150],xmm0
       lea       rcx,[rbp-150]
       mov       rdx,[rbp-210]
       xor       r8d,r8d
       mov       r9d,0C
       call      qword ptr [7FFE2D237E40]; System.Span`1[[System.Byte, System.Private.CoreLib]]..ctor(Byte[], Int32, Int32)
       vmovdqu   xmm0,xmmword ptr [rbp-150]
       vmovdqu   xmmword ptr [rbp-1C0],xmm0
       lea       rcx,[rbp-1C0]
       call      qword ptr [7FFE2D237E58]; System.Security.Cryptography.CryptographicOperations.ZeroMemory(System.Span`1<Byte>)
       mov       rcx,24944801EB0
       mov       rbx,[rcx]
       mov       rcx,rbx
       mov       rdx,[rbp-218]
       mov       r8d,1
       call      qword ptr [7FFE2D242390]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Return(Byte[], Boolean)
       mov       rcx,rbx
       mov       rdx,[rbp-220]
       mov       r8d,1
       call      qword ptr [7FFE2D242390]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Return(Byte[], Boolean)
       mov       rcx,rbx
       mov       rdx,[rbp-228]
       mov       r8d,1
       call      qword ptr [7FFE2D242390]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Return(Byte[], Boolean)
       mov       rcx,rbx
       mov       rdx,[rbp-210]
       mov       r8d,1
       call      qword ptr [7FFE2D242390]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Return(Byte[], Boolean)
       nop
       add       rsp,38
       ret
; Total bytes of code 4981
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
       jae       near ptr M01_L15
       cmp       r10,10
       jae       near ptr M01_L13
M01_L00:
       cmp       r10,4
       jb        short M01_L02
M01_L01:
       mov       r11d,[rax]
       mov       ebx,[rax+4]
       mov       esi,r11d
       or        esi,ebx
       test      esi,0FF80FF80
       jne       near ptr M01_L18
       add       rax,8
       add       r10,0FFFFFFFFFFFFFFFC
       cmp       r10,4
       jae       short M01_L01
M01_L02:
       test      r10b,2
       je        short M01_L03
       mov       r11d,[rax]
       test      r11d,0FF80FF80
       jne       near ptr M01_L19
       add       rax,4
M01_L03:
       test      r10b,1
       je        short M01_L05
       cmp       word ptr [rax],7F
       ja        short M01_L05
M01_L04:
       add       rax,2
M01_L05:
       sub       rax,rcx
       shr       rax,1
       mov       r10d,eax
       lea       rcx,[rcx+r10*2]
       sub       edx,eax
       je        near ptr M01_L21
       xor       eax,eax
       xor       r10d,r10d
       mov       r11d,edx
       lea       r11,[rcx+r11*2]
       cmp       edx,8
       jl        short M01_L08
       vbroadcastss xmm0,dword ptr [7FFE2D33C4A8]
       vbroadcastss xmm1,dword ptr [7FFE2D33C4AC]
       vbroadcastss xmm2,dword ptr [7FFE2D33C4B0]
       lea       rdx,[r11-10]
M01_L06:
       vmovups   xmm3,[rcx]
       add       rcx,10
       vpminuw   xmm4,xmm3,xmm0
       vpaddusw  xmm5,xmm3,xmm1
       vpor      xmm4,xmm5,xmm4
       vpmovmskb ebx,xmm4
       popcnt    ebx,ebx
       vpaddw    xmm4,xmm3,xmm2
       vpcmpgtw  xmm4,xmm1,xmm4
       vpmovmskb esi,xmm4
M01_L07:
       cmp       esi,0FFFF
       jne       near ptr M01_L22
       add       rax,rbx
       cmp       rcx,rdx
       jbe       short M01_L06
M01_L08:
       cmp       rcx,r11
       jae       short M01_L11
       nop       dword ptr [rax]
M01_L09:
       movzx     edx,word ptr [rcx]
       cmp       edx,7F
       ja        near ptr M01_L24
M01_L10:
       add       rcx,2
       cmp       rcx,r11
       jb        short M01_L09
M01_L11:
       mov       [r8],rax
       mov       [r9],r10d
M01_L12:
       mov       rax,rcx
       vzeroupper
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L13:
       vbroadcastss xmm0,dword ptr [7FFE2D33C4B4]
       vptest    xmm0,xmmword ptr [rax]
       jne       near ptr M01_L00
       lea       rbx,[r11+r10*2-10]
       add       r11,10
       mov       rax,r11
       and       rax,0FFFFFFFFFFFFFFF0
       vpand     xmm1,xmm0,[rax]
       vptest    xmm1,xmm1
       jne       short M01_L17
M01_L14:
       add       rax,10
       cmp       rax,rbx
       ja        short M01_L17
       vpand     xmm1,xmm0,[rax]
       vptest    xmm1,xmm1
       jne       short M01_L17
       jmp       short M01_L14
M01_L15:
       vbroadcastss ymm0,dword ptr [7FFE2D33C4B4]
       vptest    ymm0,ymmword ptr [rax]
       jne       near ptr M01_L00
       lea       rbx,[r11+r10*2-20]
       lea       rax,[r11+20]
       and       rax,0FFFFFFFFFFFFFFE0
       vpand     ymm1,ymm0,[rax]
       vptest    ymm1,ymm1
       jne       short M01_L17
M01_L16:
       add       rax,20
       cmp       rax,rbx
       ja        short M01_L17
       vpand     ymm1,ymm0,[rax]
       vptest    ymm1,ymm1
       je        short M01_L16
M01_L17:
       mov       r11,rax
       sub       r11,rcx
       shr       r11,1
       sub       r10,r11
       jmp       near ptr M01_L00
M01_L18:
       test      r11d,0FF80FF80
       je        short M01_L20
M01_L19:
       test      r11d,0FF80
       jne       near ptr M01_L05
       jmp       near ptr M01_L04
M01_L20:
       mov       r11d,ebx
       add       rax,4
       jmp       short M01_L19
M01_L21:
       xor       eax,eax
       mov       [r8],rax
       mov       [r9],eax
       jmp       near ptr M01_L12
M01_L22:
       not       esi
       vpsrlw    xmm4,xmm3,3
       vpmovmskb edi,xmm4
       mov       ebp,edi
       and       ebp,esi
       xor       edi,5555
       and       esi,edi
       shl       esi,2
       movzx     edi,si
       cmp       edi,ebp
       jne       near ptr M01_L25
       cmp       esi,0FFFF
       jbe       short M01_L23
       movzx     esi,si
       add       rbx,0FFFFFFFFFFFFFFFE
       add       rcx,0FFFFFFFFFFFFFFFE
M01_L23:
       popcnt    esi,esi
       sub       r10d,esi
       sub       rax,rsi
       sub       rax,rsi
       mov       esi,0FFFF
       jmp       near ptr M01_L07
M01_L24:
       lea       ebx,[rdx+1F800]
       shr       ebx,10
       add       rax,rbx
       add       edx,0FFFF2800
       cmp       edx,7FF
       ja        near ptr M01_L10
       add       rax,0FFFFFFFFFFFFFFFE
       mov       rdx,r11
       sub       rdx,rcx
       cmp       rdx,4
       jb        near ptr M01_L11
       mov       edx,[rcx]
       add       edx,23FF2800
       test      edx,0FC00FC00
       jne       near ptr M01_L11
       dec       r10d
       add       rax,2
       add       rcx,2
       jmp       near ptr M01_L10
M01_L25:
       add       rcx,0FFFFFFFFFFFFFFF0
       cmp       rcx,r11
       jae       near ptr M01_L11
       jmp       near ptr M01_L09
; Total bytes of code 676
```
```assembly
; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Rent(Int32)
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,50
       vzeroupper
       mov       rsi,rcx
       mov       ebx,edx
       mov       rcx,24944800C90
       mov       rdi,[rcx]
       mov       [rsp+40],rdi
       lea       ecx,[rbx-1]
       or        ecx,0F
       xor       ebp,ebp
       lzcnt     ebp,ecx
       xor       ebp,1F
       add       ebp,0FFFFFFFD
       mov       rcx,gs:[58]
       mov       rcx,[rcx+38]
       cmp       dword ptr [rcx+238],9
       jle       near ptr M02_L14
       mov       rcx,[rcx+240]
       mov       rax,[rcx+48]
       test      rax,rax
       je        near ptr M02_L14
M02_L00:
       mov       rcx,[rax+10]
       test      rcx,rcx
       je        short M02_L01
       mov       eax,[rcx+8]
       cmp       eax,ebp
       jbe       short M02_L01
       mov       eax,ebp
       shl       rax,4
       mov       r14,[rcx+rax+10]
       test      r14,r14
       jne       near ptr M02_L08
M02_L01:
       mov       [rsp+90],rsi
       mov       rcx,[rsi+10]
       mov       eax,[rcx+8]
       cmp       eax,ebp
       jbe       near ptr M02_L21
       mov       eax,ebp
       mov       rcx,[rcx+rax*8+10]
       test      rcx,rcx
       je        near ptr M02_L20
       mov       r14,[rcx+8]
       mov       [rsp+38],r14
       xor       ecx,ecx
       mov       [rsp+48],ecx
       lea       rcx,[rsp+48]
       mov       rax,7FFFAEBF22E0
       call      rax
       movzx     ebx,word ptr [rsp+48]
       shl       ebx,6
       movzx     esi,byte ptr [rsp+4A]
       or        ebx,esi
       mov       eax,0AAAAAAAB
       mov       ecx,ebx
       imul      rax,rcx
       shr       rax,23
       imul      eax,0C
       sub       ebx,eax
       cmp       dword ptr [7FFE8CB54A90],0
       jne       near ptr M02_L16
M02_L02:
       mov       r14,[rsp+38]
       mov       esi,[r14+8]
       test      esi,esi
       jle       near ptr M02_L18
       mov       edi,esi
M02_L03:
       cmp       ebx,esi
       jae       near ptr M02_L26
       mov       ecx,ebx
       mov       r15,[r14+rcx*8+10]
       cmp       [r15],r15b
       xor       r13d,r13d
       mov       rcx,r15
       call      00007FFE8C89DF30
       test      eax,eax
       jne       short M02_L04
       mov       rcx,r15
       call      qword ptr [7FFE2D2BC450]
M02_L04:
       mov       rcx,[r15+8]
       mov       eax,[r15+10]
       dec       eax
       cmp       [rcx+8],eax
       ja        short M02_L09
M02_L05:
       mov       rcx,r15
       call      00007FFE8C89DE50
       test      eax,eax
       jne       near ptr M02_L17
M02_L06:
       test      r13,r13
       jne       short M02_L11
       inc       ebx
       cmp       esi,ebx
       je        short M02_L10
M02_L07:
       dec       edi
       jne       short M02_L03
       jmp       near ptr M02_L18
M02_L08:
       mov       eax,ebp
       shl       rax,4
       xor       edx,edx
       mov       [rcx+rax+10],rdx
       cmp       byte ptr [rdi+9D],0
       je        short M02_L13
       jmp       short M02_L15
M02_L09:
       mov       edx,eax
       mov       r13,[rcx+rdx*8+10]
       mov       edx,eax
       xor       r8d,r8d
       mov       [rcx+rdx*8+10],r8
       mov       [r15+10],eax
       jmp       short M02_L05
M02_L10:
       xor       ebx,ebx
       jmp       short M02_L07
M02_L11:
       mov       r14,r13
M02_L12:
       test      r14,r14
       je        near ptr M02_L20
       mov       rdi,[rsp+40]
       cmp       byte ptr [rdi+9D],0
       jne       short M02_L19
M02_L13:
       mov       rax,r14
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M02_L14:
       mov       ecx,9
       call      qword ptr [7FFE2D2BC0A8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M02_L00
M02_L15:
       mov       rcx,r14
       call      qword ptr [7FFE2D02D698]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       ebx,eax
       mov       r15d,[r14+8]
       cmp       [rsi],sil
       mov       rcx,rsi
       call      qword ptr [7FFE2D02D698]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       [rsp+20],ebp
       mov       edx,ebx
       mov       r8d,r15d
       mov       rcx,rdi
       call      qword ptr [7FFE2D2BD440]
       jmp       short M02_L13
M02_L16:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M02_L02
M02_L17:
       mov       ecx,eax
       mov       rdx,r15
       call      qword ptr [7FFE2D2B7ED0]
       jmp       near ptr M02_L06
M02_L18:
       xor       r14d,r14d
       jmp       near ptr M02_L12
M02_L19:
       mov       rcx,r14
       call      qword ptr [7FFE2D02D698]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       ebx,eax
       mov       esi,[r14+8]
       mov       rcx,[rsp+90]
       call      qword ptr [7FFE2D02D698]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       [rsp+20],ebp
       mov       edx,ebx
       mov       r8d,esi
       mov       rcx,rdi
       call      qword ptr [7FFE2D2BD440]
       jmp       near ptr M02_L13
M02_L20:
       mov       ecx,10
       shlx      ebx,ecx,ebp
       mov       rsi,[rsp+90]
       jmp       short M02_L23
M02_L21:
       mov       rsi,[rsp+90]
       test      ebx,ebx
       jne       short M02_L22
       mov       rax,289D97162A0
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M02_L22:
       mov       ecx,ebx
       mov       rdx,289D9716F28
       call      qword ptr [7FFE2CE2D998]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
       nop
M02_L23:
       cmp       ebx,800
       jge       short M02_L24
       movsxd    rdx,ebx
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
       jmp       short M02_L25
M02_L24:
       mov       ecx,ebx
       xor       edx,edx
       call      qword ptr [7FFE2D2BD428]
       mov       r14,rax
M02_L25:
       mov       rdi,[rsp+40]
       cmp       byte ptr [rdi+9D],0
       je        near ptr M02_L13
       cmp       [r14],r14b
       mov       rcx,r14
       call      qword ptr [7FFE2D02D698]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       ebx,eax
       mov       r15d,[r14+8]
       mov       rcx,rsi
       call      qword ptr [7FFE2D02D698]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       edx,ebx
       mov       r8d,r15d
       mov       rcx,rdi
       call      qword ptr [7FFE2D2BD440]
       mov       r15d,[r14+8]
       mov       rcx,rsi
       call      qword ptr [7FFE2D02D698]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
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
       call      qword ptr [7FFE2D2BD458]
       jmp       near ptr M02_L13
M02_L26:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 887
```
```assembly
; System.Text.UTF8Encoding.GetBytes(System.ReadOnlySpan`1<Char>, System.Span`1<Byte>)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,68
       lea       rbp,[rsp+90]
       mov       rbx,rcx
       mov       rsi,[rdx]
       mov       [rbp-30],rsi
       mov       rdi,[r8]
       mov       [rbp-38],rdi
       mov       r14d,[rdx+8]
       mov       r15d,[r8+8]
       cmp       [rbx],bl
       lea       rcx,[rbp-40]
       mov       [rsp+20],rcx
       lea       rcx,[rbp-48]
       mov       [rsp+28],rcx
       mov       rcx,rsi
       mov       edx,r14d
       mov       r8,rdi
       mov       r9d,r15d
       call      qword ptr [7FFE2CC0FB28]; System.Text.Unicode.Utf8Utility.TranscodeToUtf8(Char*, Int32, Byte*, Int32, Char* ByRef, Byte* ByRef)
       mov       rcx,[rbp-40]
       sub       rcx,rsi
       mov       rdx,rcx
       shr       rdx,3F
       add       rcx,rdx
       sar       rcx,1
       mov       eax,[rbp-48]
       sub       eax,edi
       cmp       ecx,r14d
       jne       short M03_L01
M03_L00:
       add       rsp,68
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M03_L01:
       mov       [rsp+20],r15d
       mov       [rsp+28],ecx
       mov       [rsp+30],eax
       mov       dword ptr [rsp+38],1
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,r14d
       mov       r9,rdi
       call      qword ptr [7FFE2D2BCB10]
       jmp       short M03_L00
; Total bytes of code 167
```
```assembly
; System.Security.Cryptography.AesGcm..ctor(Byte[], Int32)
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+20],rax
       test      rdx,rdx
       je        short M04_L00
       lea       rax,[rdx+10]
       mov       edx,[rdx+8]
       mov       [rsp+20],rax
       mov       [rsp+28],edx
       lea       rdx,[rsp+20]
       call      qword ptr [7FFE2D23C750]; System.Security.Cryptography.AesGcm..ctor(System.ReadOnlySpan`1<Byte>, Int32)
       nop
       add       rsp,30
       pop       rbx
       ret
M04_L00:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,4BF3
       mov       rdx,7FFE2D03E5C0
       call      qword ptr [7FFE2CE27798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE2CF85A10]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 111
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
       call      qword ptr [7FFE2CD77198]
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
; System.Security.Cryptography.AesGcm.Encrypt(System.ReadOnlySpan`1<Byte>, System.ReadOnlySpan`1<Byte>, System.Span`1<Byte>, System.Span`1<Byte>, System.ReadOnlySpan`1<Byte>)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,138
       vzeroupper
       lea       rbp,[rsp+170]
       xor       eax,eax
       mov       [rbp-68],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-60],ymm4
       mov       r14,rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rdi,r9
       mov       r15,[rbp+30]
       mov       r13,[rbp+38]
       lea       rcx,[rbp-108]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       r12,rax
       mov       rax,rsp
       mov       [rbp-0F0],rax
       mov       rax,rbp
       mov       [rbp-0E0],rax
       mov       eax,[rdi+8]
       mov       ecx,[r15+8]
       mov       edx,[rsi+8]
       mov       r8d,[rbx+8]
       cmp       edx,eax
       jne       near ptr M07_L09
       mov       rax,24944801F80
       mov       r10,[rax]
       mov       r9d,[r10+10]
       test      r9d,r9d
       je        near ptr M07_L10
       mov       r11d,[r10+8]
       cmp       r8d,r11d
       jl        near ptr M07_L11
       cmp       r8d,[r10+0C]
       jg        near ptr M07_L11
       mov       edx,r8d
       sub       edx,r11d
       mov       eax,edx
       cdq
       idiv      r9d
       test      edx,edx
       jne       near ptr M07_L11
M07_L00:
       movzx     edx,byte ptr [r14+10]
       mov       eax,[r14+14]
       mov       [rbp-10C],eax
       test      edx,edx
       jne       short M07_L01
       mov       rdx,24944801F88
       mov       rdx,[rdx]
       lea       r8,[rbp-40]
       call      qword ptr [7FFE2D237528]; System.Security.Cryptography.KeySizeHelpers.IsLegalSize(Int32, System.Security.Cryptography.KeySizes, Boolean ByRef)
       test      eax,eax
       jne       short M07_L02
       jmp       near ptr M07_L13
M07_L01:
       cmp       ecx,eax
       jne       near ptr M07_L12
M07_L02:
       mov       rcx,[r14+8]
       mov       rax,[rbx]
       mov       r8d,[rbx+8]
       mov       r9,[r13]
       mov       edx,[r13+8]
       mov       r10,[rsi]
       mov       r11d,[rsi+8]
       mov       rbx,[rdi]
       mov       esi,[rdi+8]
       mov       rdi,[r15]
       mov       r14d,[r15+8]
       mov       r15d,1
       test      r11d,r11d
       cmove     r10,r15
       mov       [rbp-48],r10
       test      r8d,r8d
       cmove     rax,r15
       mov       [rbp-50],rax
       test      esi,esi
       cmove     rbx,r15
       mov       [rbp-58],rbx
       test      r14d,r14d
       cmove     rdi,r15
       mov       [rbp-60],rdi
       test      edx,edx
       cmove     r9,r15
       mov       [rbp-68],r9
       vxorps    ymm1,ymm1,ymm1
       vmovdqu   ymmword ptr [rbp-0C0],ymm1
       vmovdqu   ymmword ptr [rbp-0A0],ymm1
       vmovdqu   ymmword ptr [rbp-88],ymm1
       mov       dword ptr [rbp-0C0],58
       mov       dword ptr [rbp-0BC],1
       mov       [rbp-0B8],rax
       mov       [rbp-0B0],r8d
       mov       [rbp-98],rdi
       mov       [rbp-90],r14d
       mov       [rbp-0A8],r9
       mov       [rbp-0A0],edx
       mov       r8d,r11d
       xor       eax,eax
       mov       [rbp-0C8],eax
       mov       [rbp-0CC],eax
       mov       [rbp-118],rax
       mov       byte ptr [rbp-110],0
       mov       [rbp-118],rcx
       mov       eax,[rcx+10]
       test      al,1
       jne       near ptr M07_L07
M07_L03:
       lea       r9,[rcx+10]
       lea       edx,[rax+4]
       mov       [rbp-0D0],eax
       lock cmpxchg [r9],edx
       cmp       eax,[rbp-0D0]
       jne       near ptr M07_L06
       mov       byte ptr [rbp-110],1
       mov       rcx,[rbp-118]
       mov       rcx,[rcx+8]
       xor       r9d,r9d
       mov       [rsp+28],r9d
       mov       [rsp+30],rbx
       mov       [rsp+38],esi
       lea       r9,[rbp-0C8]
       mov       [rsp+40],r9
       xor       r9d,r9d
       mov       [rsp+48],r9d
       mov       [rsp+20],r9
       lea       r9,[rbp-0C0]
       mov       rdx,r10
       mov       rax,7FFE2D0602D0
       mov       [rbp-0F8],rax
       lea       rax,[M07_L04]
       mov       [rbp-0E8],rax
       lea       rax,[rbp-108]
       mov       [r12+8],rax
       mov       byte ptr [r12+4],0
       mov       rax,7FFFAC8B15B0
       call      rax
M07_L04:
       mov       byte ptr [r12+4],1
       cmp       dword ptr [7FFE8CB54A90],0
       je        short M07_L05
       call      qword ptr [7FFE8CB42648]; CORINFO_HELP_STOP_FOR_GC
M07_L05:
       mov       rcx,[rbp-100]
       mov       [r12+8],rcx
       mov       [rbp-0CC],eax
       jmp       short M07_L08
M07_L06:
       mov       eax,[rcx+10]
       test      al,1
       je        near ptr M07_L03
M07_L07:
       call      qword ptr [7FFE2D2BC228]
       int       3
M07_L08:
       call      M07_L15
       nop
       cmp       dword ptr [rbp-0CC],0
       jne       near ptr M07_L14
       xor       ecx,ecx
       mov       [rbp-68],rcx
       mov       [rbp-60],rcx
       mov       [rbp-58],rcx
       mov       [rbp-50],rcx
       mov       [rbp-48],rcx
       add       rsp,138
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M07_L09:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE2D2BD620]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE2CF84318]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M07_L10:
       mov       r11d,[r10+8]
       cmp       r11d,r8d
       je        near ptr M07_L00
M07_L11:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE2D2BD638]
       mov       rsi,rax
       mov       ecx,4BFB
       mov       rdx,7FFE2D03E5C0
       call      qword ptr [7FFE2CE27798]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE2CF86208]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M07_L12:
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE2D2BD650]
       mov       rsi,rax
       mov       edi,[rbp-10C]
       mov       [rbx+8],edi
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE2D2BD668]
       mov       rbx,rax
       mov       ecx,4C31
       mov       rdx,7FFE2D03E5C0
       call      qword ptr [7FFE2CE27798]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FFE2CF86208]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M07_L13:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      qword ptr [7FFE2D2BD518]
       mov       rbx,rax
       mov       ecx,4C31
       mov       rdx,7FFE2D03E5C0
       call      qword ptr [7FFE2CE27798]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,r14
       call      qword ptr [7FFE2CF86208]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
       int       3
M07_L14:
       mov       ecx,[rbp-0CC]
       call      qword ptr [7FFE2D2B7F78]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M07_L15:
       sub       rsp,58
       vzeroupper
       cmp       byte ptr [rbp-110],0
       je        near ptr M07_L29
       mov       rbx,[rbp-118]
       mov       rcx,[rbp-118]
       cmp       [rcx],cl
       mov       esi,[rbx+10]
       test      esi,0FFFFFFFC
       je        short M07_L24
M07_L16:
       mov       ecx,esi
       and       ecx,0FFFFFFFD
       cmp       ecx,4
       jne       short M07_L21
       jmp       short M07_L18
M07_L17:
       mov       esi,[rbx+10]
       test      esi,0FFFFFFFC
       jne       short M07_L16
       jmp       short M07_L24
M07_L18:
       cmp       byte ptr [rbx+14],0
       je        short M07_L21
       mov       rcx,offset MT_Internal.NativeCrypto.SafeKeyHandle
       cmp       [rbx],rcx
       jne       short M07_L19
       cmp       qword ptr [rbx+8],0
       sete      dil
       movzx     edi,dil
       jmp       short M07_L20
M07_L19:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       edi,eax
M07_L20:
       test      edi,edi
       sete      cl
       movzx     ecx,cl
       jmp       short M07_L22
M07_L21:
       xor       ecx,ecx
M07_L22:
       lea       edx,[rsi-4]
       mov       eax,esi
       and       eax,0FFFFFFFC
       cmp       eax,4
       jne       short M07_L23
       or        edx,1
M07_L23:
       lea       r8,[rbx+10]
       mov       eax,esi
       lock cmpxchg [r8],edx
       cmp       eax,esi
       jne       short M07_L17
       jmp       short M07_L25
M07_L24:
       mov       rcx,rbx
       call      qword ptr [7FFE2D2BC228]
       int       3
M07_L25:
       test      ecx,ecx
       je        short M07_L29
       call      00007FFE8C891F20
       mov       esi,eax
       mov       rcx,offset MT_Internal.NativeCrypto.SafeKeyHandle
       cmp       [rbx],rcx
       jne       short M07_L27
       cmp       qword ptr [rbx+18],0
       je        short M07_L26
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFE2D23C660]; System.Runtime.InteropServices.SafeHandle.DangerousRelease()
       xor       ecx,ecx
       mov       [rbx+18],rcx
M07_L26:
       mov       rcx,[rbx+8]
       call      00007FFE2CBF8DE0
       jmp       short M07_L28
M07_L27:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
M07_L28:
       mov       ecx,esi
       call      00007FFE8C891F40
M07_L29:
       nop
       add       rsp,58
       ret
; Total bytes of code 1370
```
```assembly
; System.Runtime.InteropServices.SafeHandle.Dispose()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,offset MT_Internal.NativeCrypto.SafeKeyHandle
       cmp       [rbx],rcx
       jne       short M08_L01
       mov       rcx,rbx
       mov       edx,1
       call      qword ptr [7FFE2CC0C768]; System.Runtime.InteropServices.SafeHandle.InternalRelease(Boolean)
M08_L00:
       mov       rcx,rbx
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFE2CC07AE0]; System.GC.SuppressFinalize(System.Object)
M08_L01:
       mov       rcx,rbx
       mov       edx,1
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       jmp       short M08_L00
; Total bytes of code 71
```
```assembly
; DotNetTips.Spargine.Core.Security.EncryptionHelper.AssembleGcmPayload(Byte[], Byte[], Byte[], Int32)
; 		var payloadLength = 1 + NonceSize + cipherLen + TagSize;
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var payload = _byteArrayPool.Rent(payloadLength);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var span = payload.AsSpan(0, payloadLength);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			span[0] = FormatVersion;
; 			^^^^^^^^^^^^^^^^^^^^^^^^
; 			nonce.AsSpan(0, NonceSize).CopyTo(span.Slice(1, NonceSize));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			cipherBuffer.AsSpan(0, cipherLen).CopyTo(span.Slice(1 + NonceSize, cipherLen));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			tag.AsSpan(0, TagSize).CopyTo(span.Slice(1 + NonceSize + cipherLen, TagSize));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			return Convert.ToBase64String(payload, 0, payloadLength);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 	}
; 	^
; 			CryptographicOperations.ZeroMemory(payload.AsSpan(0, payloadLength));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			_byteArrayPool.Return(payload, clearArray: true);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       sub       rsp,128
       vmovaps   [rsp+110],xmm6
       vmovaps   [rsp+100],xmm7
       vmovaps   [rsp+0F0],xmm8
       vmovaps   [rsp+0E0],xmm9
       vmovaps   [rsp+0D0],xmm10
       lea       rbp,[rsp+160]
       xor       eax,eax
       mov       [rbp-108],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-100],ymm4
       vmovdqu   ymmword ptr [rbp-0E0],ymm4
       vmovdqa   xmmword ptr [rbp-0C0],xmm4
       mov       [rbp-0B0],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       ebx,r9d
       mov       r15d,ebx
       add       r15d,0D
       jo        near ptr M09_L67
       mov       ecx,r15d
       add       ecx,10
       jo        near ptr M09_L67
       mov       [rbp-94],ecx
       mov       rax,24944801EB0
       mov       r13,[rax]
       mov       [rbp-118],r13
       mov       r12d,ecx
       mov       rax,24944800C90
       mov       rax,[rax]
       mov       [rbp-110],rax
       lea       edx,[r12-1]
       or        edx,0F
       lzcnt     edx,edx
       xor       edx,1F
       add       edx,0FFFFFFFD
       mov       [rbp-98],edx
       mov       r8,gs:[58]
       mov       r8,[r8+38]
       cmp       dword ptr [r8+238],9
       jle       near ptr M09_L53
       mov       r8,[r8+240]
       mov       r8,[r8+48]
       test      r8,r8
       je        near ptr M09_L53
M09_L00:
       mov       r8,[r8+10]
       test      r8,r8
       je        short M09_L01
       mov       edx,[rbp-98]
       cmp       [r8+8],edx
       jbe       near ptr M09_L55
       mov       r10d,edx
       shl       r10,4
       mov       r10,[r8+r10+10]
       test      r10,r10
       jne       near ptr M09_L08
M09_L01:
       mov       r8,[r13+10]
       mov       r10d,[r8+8]
       mov       edx,[rbp-98]
       cmp       r10d,edx
       jbe       near ptr M09_L61
       mov       r10d,edx
       mov       r8,[r8+r10*8+10]
       test      r8,r8
       je        near ptr M09_L60
       mov       r12,[r8+8]
       mov       [rbp-128],r12
       xor       r8d,r8d
       mov       [rbp-0B0],r8d
       lea       rcx,[rbp-0B0]
       mov       r8,7FFFAEBF22E0
       vzeroupper
       call      r8
       movzx     esi,word ptr [rbp-0B0]
       shl       esi,6
       movzx     edi,byte ptr [rbp-0AE]
       or        esi,edi
       mov       eax,0AAAAAAAB
       mov       ecx,esi
       imul      rax,rcx
       shr       rax,23
       imul      eax,0C
       sub       esi,eax
       xor       edi,edi
       cmp       dword ptr [7FFE8CB54A90],0
       jne       near ptr M09_L56
M09_L02:
       mov       r12,[rbp-128]
       cmp       dword ptr [r12+8],0
       jle       near ptr M09_L58
M09_L03:
       cmp       esi,[r12+8]
       jae       near ptr M09_L66
       mov       ecx,esi
       mov       r14,[r12+rcx*8+10]
       cmp       [r14],r14b
       xor       r13d,r13d
       mov       rcx,r14
       call      00007FFE8C89DF30
       test      eax,eax
       jne       short M09_L04
       mov       rcx,r14
       call      qword ptr [7FFE2D2BC450]
M09_L04:
       mov       rcx,[r14+8]
       mov       eax,[r14+10]
       dec       eax
       cmp       [rcx+8],eax
       ja        short M09_L09
M09_L05:
       mov       rcx,r14
       call      00007FFE8C89DE50
       test      eax,eax
       jne       near ptr M09_L57
M09_L06:
       test      r13,r13
       jne       short M09_L11
       inc       esi
       cmp       [r12+8],esi
       je        short M09_L10
M09_L07:
       inc       edi
       cmp       [r12+8],edi
       jg        short M09_L03
       jmp       near ptr M09_L58
M09_L08:
       mov       r9d,edx
       shl       r9,4
       xor       r11d,r11d
       mov       [r8+r9+10],r11
       mov       rax,[rbp-110]
       cmp       byte ptr [rax+9D],0
       jne       near ptr M09_L54
       mov       rsi,r10
       jmp       short M09_L13
M09_L09:
       mov       edx,eax
       mov       r13,[rcx+rdx*8+10]
       mov       edx,eax
       xor       r8d,r8d
       mov       [rcx+rdx*8+10],r8
       mov       [r14+10],eax
       jmp       short M09_L05
M09_L10:
       xor       esi,esi
       jmp       short M09_L07
M09_L11:
       mov       rax,r13
M09_L12:
       mov       rsi,rax
       test      rsi,rsi
       je        near ptr M09_L60
       mov       rdi,[rbp-110]
       cmp       byte ptr [rdi+9D],0
       jne       near ptr M09_L59
M09_L13:
       mov       [rbp-100],rsi
       test      rsi,rsi
       je        near ptr M09_L35
       mov       ecx,[rbp-94]
       cmp       [rsi+8],ecx
       jb        near ptr M09_L37
       lea       r13,[rsi+10]
       mov       r12d,ecx
M09_L14:
       test      r12d,r12d
       je        near ptr M09_L50
       mov       byte ptr [r13],1
       mov       r8,[rbp+10]
       test      r8,r8
       je        near ptr M09_L37
       cmp       dword ptr [r8+8],0C
       jl        near ptr M09_L37
       add       r8,10
       cmp       r12d,0D
       jl        near ptr M09_L37
       lea       rdx,[r13+1]
       mov       rax,[r8]
       mov       r10,[r8+4]
       mov       [rdx],rax
       mov       [rdx+4],r10
       mov       rdi,[rbp+18]
       test      rdi,rdi
       je        near ptr M09_L36
       cmp       [rdi+8],ebx
       jb        near ptr M09_L37
       lea       rdx,[rdi+10]
       mov       r8d,ebx
M09_L15:
       mov       eax,ebx
       add       rax,0D
       mov       r10d,r12d
       cmp       rax,r10
       ja        near ptr M09_L37
       lea       rax,[r13+0D]
       cmp       r8d,ebx
       ja        near ptr M09_L38
       mov       r8d,r8d
       mov       rcx,rax
       call      qword ptr [7FFE2CC05818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r14,[rbp+20]
       test      r14,r14
       je        near ptr M09_L37
       cmp       dword ptr [r14+8],10
       jl        near ptr M09_L37
       add       r14,10
       mov       ecx,r15d
       add       rcx,10
       mov       edx,r12d
       cmp       rcx,rdx
       ja        near ptr M09_L37
       mov       ecx,r15d
       add       rcx,r13
       vmovdqu   xmm0,xmmword ptr [r14]
       vmovdqu   xmmword ptr [rcx],xmm0
       test      rsi,rsi
       je        near ptr M09_L39
       cmp       dword ptr [rbp-94],0
       jl        near ptr M09_L40
       mov       ebx,[rsi+8]
       sub       ebx,[rbp-94]
       test      ebx,ebx
       jg        short M09_L16
       test      ebx,ebx
       jl        near ptr M09_L41
M09_L16:
       mov       ecx,[rbp-94]
       cmp       [rsi+8],ecx
       jb        near ptr M09_L37
       add       rsi,10
       test      ecx,ecx
       je        near ptr M09_L42
       lea       eax,[rcx+2]
       mov       edx,0AAAAAAAB
       imul      rax,rdx
       shr       rax,21
       shl       eax,2
       je        near ptr M09_L43
       test      eax,eax
       jl        near ptr M09_L44
M09_L17:
       movsxd    rdx,eax
       mov       rcx,offset MT_System.String
       call      00007FFE8C8950F0
       mov       rbx,rax
       cmp       dword ptr [rbp-94],10
       jl        near ptr M09_L47
       lea       r8,[rbx+0C]
       mov       ecx,[rbx+8]
       mov       edi,[rbx+8]
       imul      r14d,edi,2
       jo        near ptr M09_L51
       mov       [rbp-0C8],rsi
       mov       [rbp-0D0],r8
       mov       r15,r8
       cmp       dword ptr [rbp-94],5FFFFFFD
       jg        near ptr M09_L45
       cmp       dword ptr [rbp-94],5FFFFFFD
       jae       near ptr M09_L21
M09_L18:
       mov       ecx,[rbp-94]
       lea       edx,[rcx+2]
       mov       r9d,55555556
       mov       eax,r9d
       imul      edx
       mov       r9d,edx
       shr       r9d,1F
       add       edx,r9d
       shl       edx,2
       cmp       edx,r14d
       jg        near ptr M09_L45
       mov       edx,ecx
M09_L19:
       mov       r9,rsi
       mov       rax,r15
       mov       r10d,ecx
       add       r10,r9
       mov       r11d,edx
       add       r11,r9
       cmp       edx,10
       jl        near ptr M09_L25
       lea       rdx,[r11-20]
       cmp       rdx,r9
       jb        near ptr M09_L23
       vmovups   ymm0,[7FFE2D345680]
       vpermd    ymm0,ymm0,[rsi]
       add       rsi,0FFFFFFFFFFFFFFFC
M09_L20:
       vpshufb   ymm0,ymm0,[7FFE2D3456A0]
       vpand     ymm1,ymm0,[7FFE2D3456C0]
       vpmulhuw  ymm1,ymm1,[7FFE2D3456E0]
       vpand     ymm0,ymm0,[7FFE2D345700]
       vpmullw   ymm0,ymm0,[7FFE2D345720]
       vpor      ymm0,ymm0,ymm1
       vpsubusb  ymm1,ymm0,[7FFE2D345740]
       vpcmpgtb  ymm2,ymm0,[7FFE2D345760]
       vpsubb    ymm1,ymm1,ymm2
       vbroadcastf128 ymm2,xmmword ptr [7FFE2D345780]
       vpshufb   ymm1,ymm2,ymm1
       vpaddb    ymm0,ymm1,ymm0
       vmovups   [r15],ymm0
       add       rsi,18
       add       r15,20
       cmp       rsi,rdx
       ja        short M09_L22
       vmovups   ymm0,[rsi]
       jmp       short M09_L20
M09_L21:
       cmp       dword ptr [rbp-94],5FFFFFFD
       jbe       near ptr M09_L18
       mov       ecx,175DA
       mov       rdx,7FFE2CB44000
       call      qword ptr [7FFE2CE27798]
       mov       r8,rax
       mov       ecx,[rbp-94]
       mov       edx,5FFFFFFD
       call      qword ptr [7FFE2D2BCE28]
       int       3
M09_L22:
       lea       r9,[rsi+4]
       mov       rax,r15
       cmp       r9,r10
       je        near ptr M09_L28
M09_L23:
       lea       rdx,[r11-10]
       cmp       rdx,r9
       jb        near ptr M09_L25
       vmovups   xmm0,[7FFE2D345790]
       vmovups   xmm1,[7FFE2D345780]
       vbroadcastss xmm2,dword ptr [7FFE2D3456C0]
       vbroadcastss xmm3,dword ptr [7FFE2D345700]
       vbroadcastss xmm4,dword ptr [7FFE2D3456E0]
       vbroadcastss xmm5,dword ptr [7FFE2D345720]
       vbroadcastss xmm6,dword ptr [7FFE2D345740]
       vbroadcastss xmm7,dword ptr [7FFE2D345760]
M09_L24:
       vmovups   xmm8,[r9]
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
       vmovups   [rax],xmm8
       add       r9,0C
       add       rax,10
       cmp       r9,rdx
       jbe       short M09_L24
       cmp       r9,r10
       je        near ptr M09_L28
M09_L25:
       mov       rdx,7FFE8BA056E0
       add       r11,0FFFFFFFFFFFFFFFE
       cmp       r9,r11
       jae       short M09_L27
M09_L26:
       movzx     esi,byte ptr [r9]
       shl       esi,10
       movzx     r14d,byte ptr [r9+1]
       shl       r14d,8
       or        esi,r14d
       movzx     r14d,byte ptr [r9+2]
       or        esi,r14d
       mov       r14d,esi
       shr       r14d,12
       movzx     r14d,byte ptr [rdx+r14]
       mov       r15d,esi
       shr       r15d,0C
       and       r15d,3F
       movzx     r15d,byte ptr [rdx+r15]
       shl       r15d,8
       or        r14d,r15d
       mov       r15d,esi
       shr       r15d,6
       and       r15d,3F
       movzx     r15d,byte ptr [rdx+r15]
       shl       r15d,10
       or        r14d,r15d
       and       esi,3F
       movzx     esi,byte ptr [rdx+rsi]
       shl       esi,18
       or        esi,r14d
       mov       [rax],esi
       add       r9,3
       add       rax,4
       cmp       r9,r11
       jb        short M09_L26
M09_L27:
       add       r11,2
       cmp       r11,r10
       jne       short M09_L28
       lea       r11,[r9+1]
       cmp       r11,r10
       je        near ptr M09_L46
       lea       r11,[r9+2]
       cmp       r11,r10
       jne       short M09_L28
       movzx     r10d,byte ptr [r9]
       shl       r10d,10
       movzx     r9d,byte ptr [r9+1]
       shl       r9d,8
       or        r9d,r10d
       mov       r10d,r9d
       shr       r10d,12
       movzx     r10d,byte ptr [rdx+r10]
       mov       r11d,r9d
       shr       r11d,0C
       and       r11d,3F
       movzx     r11d,byte ptr [rdx+r11]
       shl       r11d,8
       or        r10d,r11d
       shr       r9d,6
       and       r9d,3F
       movzx     edx,byte ptr [rdx+r9]
       shl       edx,10
       or        edx,r10d
       or        edx,3D000000
       mov       [rax],edx
M09_L28:
       xor       edx,edx
       mov       [rbp-0C8],rdx
       mov       [rbp-0D0],rdx
       mov       edx,edi
       lea       rdx,[r8+rdx*2]
       mov       r9d,edi
       add       r9,r8
       lea       rax,[r8+1F]
       cmp       r9,rax
       jbe       short M09_L30
M09_L29:
       add       r9,0FFFFFFFFFFFFFFE0
       add       rdx,0FFFFFFFFFFFFFFC0
       vmovups   ymm0,[r9]
       vmovaps   ymm1,ymm0
       vpmovzxbw ymm1,xmm1
       vextracti128 xmm0,ymm0,1
       vpmovzxbw ymm0,xmm0
       vmovups   [rdx],ymm1
       vmovups   [rdx+20],ymm0
       cmp       r9,rax
       ja        short M09_L29
M09_L30:
       lea       rax,[r8+0F]
       cmp       r9,rax
       jbe       short M09_L32
M09_L31:
       add       r9,0FFFFFFFFFFFFFFF0
       add       rdx,0FFFFFFFFFFFFFFE0
       vmovups   xmm0,[r9]
       vpmovzxbw xmm1,xmm0
       vpsrldq   xmm0,xmm0,8
       vpmovzxbw xmm0,xmm0
       vmovups   [rdx],xmm1
       vmovups   [rdx+10],xmm0
       cmp       r9,rax
       ja        short M09_L31
M09_L32:
       add       r8,3
       cmp       r9,r8
       jbe       short M09_L34
M09_L33:
       add       rdx,0FFFFFFFFFFFFFFF8
       add       r9,0FFFFFFFFFFFFFFFC
       vmovd     xmm0,dword ptr [r9]
       vpmovzxbw xmm0,xmm0
       vmovq     qword ptr [rdx],xmm0
       cmp       r9,r8
       ja        short M09_L33
M09_L34:
       xor       edx,edx
       mov       [rbp-0B8],rdx
       mov       [rbp-0C0],rdx
       mov       [rbp-108],rbx
       jmp       near ptr M09_L52
M09_L35:
       cmp       dword ptr [rbp-94],0
       jne       short M09_L37
       xor       r13d,r13d
       xor       r12d,r12d
       mov       ecx,[rbp-94]
       jmp       near ptr M09_L14
M09_L36:
       test      ebx,ebx
       jne       short M09_L37
       xor       edx,edx
       xor       r8d,r8d
       jmp       near ptr M09_L15
M09_L37:
       call      qword ptr [7FFE2CD77198]
       int       3
M09_L38:
       call      qword ptr [7FFE2D02CFF0]
       int       3
M09_L39:
       mov       ecx,1139
       mov       rdx,7FFE2CB44000
       call      qword ptr [7FFE2CE27798]
       mov       rcx,rax
       call      qword ptr [7FFE2D2B7DC8]
       int       3
M09_L40:
       mov       ecx,0B3
       mov       rdx,7FFE2CB44000
       call      qword ptr [7FFE2CE27798]
       mov       rdx,rax
       mov       ecx,[rbp-94]
       call      qword ptr [7FFE2D2B7D98]
       int       3
M09_L41:
       mov       ecx,1149
       mov       rdx,7FFE2CB44000
       call      qword ptr [7FFE2CE27798]
       mov       r8,rax
       mov       edx,ebx
       xor       ecx,ecx
       call      qword ptr [7FFE2D2BD698]
       int       3
M09_L42:
       mov       rbx,289D9710008
       jmp       near ptr M09_L34
M09_L43:
       xor       eax,eax
       jmp       near ptr M09_L17
M09_L44:
       mov       rcx,offset MT_System.OutOfMemoryException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFE2D2BCB58]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M09_L45:
       sar       r14d,2
       lea       edx,[r14+r14*2]
       mov       ecx,[rbp-94]
       jmp       near ptr M09_L19
M09_L46:
       movzx     r9d,byte ptr [r9]
       shl       r9d,8
       mov       r10d,r9d
       shr       r10d,0A
       movzx     r10d,byte ptr [rdx+r10]
       shr       r9d,4
       and       r9d,3F
       movzx     edx,byte ptr [rdx+r9]
       shl       edx,8
       or        edx,r10d
       or        edx,3D3D0000
       mov       [rax],edx
       jmp       near ptr M09_L28
M09_L47:
       mov       [rbp-0B8],rsi
       mov       rdx,rsi
       test      rbx,rbx
       jne       short M09_L48
       xor       r9d,r9d
       jmp       short M09_L49
M09_L48:
       lea       r9,[rbx+0C]
       mov       [rbp-0C0],r9
       mov       r9,[rbp-0C0]
M09_L49:
       xor       r8d,r8d
       mov       [rsp+20],r8d
       mov       rcx,r9
       mov       r9d,[rbp-94]
       call      qword ptr [7FFE2D2BCB40]
       xor       ecx,ecx
       mov       [rbp-0C0],rcx
       mov       [rbp-0B8],rcx
       jmp       near ptr M09_L34
M09_L50:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M09_L51:
       call      CORINFO_HELP_OVERFLOW
       int       3
M09_L52:
       call      M09_L68
       nop
       mov       rax,[rbp-108]
       vzeroupper
       vmovaps   xmm6,[rsp+110]
       vmovaps   xmm7,[rsp+100]
       vmovaps   xmm8,[rsp+0F0]
       vmovaps   xmm9,[rsp+0E0]
       vmovaps   xmm10,[rsp+0D0]
       add       rsp,128
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M09_L53:
       mov       ecx,9
       call      qword ptr [7FFE2D2BC0A8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       r8,rax
       jmp       near ptr M09_L00
M09_L54:
       mov       [rbp-120],r10
       mov       rcx,r10
       call      qword ptr [7FFE2D02D698]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r12d,eax
       mov       rax,[rbp-120]
       mov       edx,[rax+8]
       mov       [rbp-0A8],edx
       mov       rcx,r13
       call      qword ptr [7FFE2D02D698]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       r13d,[rbp-98]
       mov       [rsp+20],r13d
       mov       edx,r12d
       mov       r8d,[rbp-0A8]
       mov       rcx,[rbp-110]
       call      qword ptr [7FFE2D2BD440]
       mov       rsi,[rbp-120]
       jmp       near ptr M09_L13
M09_L55:
       jmp       near ptr M09_L01
M09_L56:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M09_L02
M09_L57:
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FFE2D2B7ED0]
       jmp       near ptr M09_L06
M09_L58:
       xor       eax,eax
       jmp       near ptr M09_L12
M09_L59:
       mov       rcx,rsi
       call      qword ptr [7FFE2D02D698]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r14d,eax
       mov       r13d,[rsi+8]
       mov       rcx,[rbp-118]
       call      qword ptr [7FFE2D02D698]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       r12d,[rbp-98]
       mov       [rsp+20],r12d
       mov       edx,r14d
       mov       r8d,r13d
       mov       rcx,rdi
       call      qword ptr [7FFE2D2BD440]
       jmp       near ptr M09_L13
M09_L60:
       mov       ecx,10
       mov       r12d,[rbp-98]
       shlx      ecx,ecx,r12d
       mov       esi,ecx
       mov       r13,[rbp-118]
       jmp       short M09_L63
M09_L61:
       mov       r13,[rbp-118]
       test      r12d,r12d
       jne       short M09_L62
       mov       r8,289D97162A0
       mov       r13,r8
       mov       rsi,r13
       jmp       near ptr M09_L13
M09_L62:
       mov       ecx,r12d
       mov       rdx,289D9716F28
       call      qword ptr [7FFE2CE2D998]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
       mov       esi,r12d
M09_L63:
       cmp       esi,800
       jge       short M09_L64
       movsxd    rdx,esi
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rsi,rax
       jmp       short M09_L65
M09_L64:
       mov       ecx,esi
       xor       edx,edx
       call      qword ptr [7FFE2D2BD428]
       mov       rsi,rax
M09_L65:
       mov       rdi,[rbp-110]
       cmp       byte ptr [rdi+9D],0
       je        near ptr M09_L13
       cmp       [rsi],sil
       mov       rcx,rsi
       call      qword ptr [7FFE2D02D698]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rbp-9C],eax
       mov       edx,[rsi+8]
       mov       [rbp-0A0],edx
       mov       rcx,r13
       call      qword ptr [7FFE2D02D698]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       edx,[rbp-9C]
       mov       r8d,[rbp-0A0]
       mov       rcx,rdi
       call      qword ptr [7FFE2D2BD440]
       mov       eax,[rsi+8]
       mov       [rbp-0A4],eax
       mov       rcx,r13
       call      qword ptr [7FFE2D02D698]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       rcx,[r13+10]
       mov       edx,1
       mov       r8d,2
       mov       r12d,[rbp-98]
       cmp       [rcx+8],r12d
       cmovg     edx,r8d
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       [rsp+28],edx
       mov       rcx,rdi
       mov       edx,[rbp-9C]
       mov       r8d,[rbp-0A4]
       call      qword ptr [7FFE2D2BD458]
       jmp       near ptr M09_L13
M09_L66:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M09_L67:
       call      CORINFO_HELP_OVERFLOW
       int       3
M09_L68:
       sub       rsp,38
       cmp       qword ptr [rbp-100],0
       jne       short M09_L69
       cmp       dword ptr [rbp-94],0
       jne       short M09_L70
       mov       rcx,[rbp-100]
       xor       esi,esi
       xor       ebx,ebx
       jmp       short M09_L72
M09_L69:
       mov       rcx,[rbp-100]
       mov       ebx,[rbp-94]
       cmp       [rcx+8],ebx
       jae       short M09_L71
M09_L70:
       call      qword ptr [7FFE2CD77198]
       int       3
M09_L71:
       lea       rsi,[rcx+10]
M09_L72:
       mov       [rbp-0F0],rsi
       mov       [rbp-0E8],ebx
       lea       rcx,[rbp-0F0]
       call      qword ptr [7FFE2D237E58]; System.Security.Cryptography.CryptographicOperations.ZeroMemory(System.Span`1<Byte>)
       mov       rcx,24944801EB0
       mov       rbx,[rcx]
       cmp       qword ptr [rbp-100],0
       je        near ptr M09_L76
       mov       rcx,[rbp-100]
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
       jle       short M09_L73
       mov       rax,[rax+240]
       mov       rax,[rax+48]
       test      rax,rax
       jne       short M09_L74
M09_L73:
       mov       ecx,9
       call      qword ptr [7FFE2D2BC0A8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
M09_L74:
       mov       rdi,[rax+10]
       test      rdi,rdi
       jne       short M09_L75
       mov       rcx,rbx
       call      qword ptr [7FFE2D237E70]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
       mov       rdi,rax
M09_L75:
       xor       r14d,r14d
       mov       r15d,1
       cmp       [rdi+8],esi
       jbe       near ptr M09_L92
       mov       r14d,1
       mov       rcx,[rbp-100]
       mov       rdx,[rcx]
       movzx     eax,word ptr [rdx]
       mov       r8d,[rcx+8]
       imul      r8,rax
       lea       rax,[rcx+10]
       test      dword ptr [rdx],1000000
       jne       short M09_L78
       jmp       short M09_L77
M09_L76:
       mov       ecx,2
       call      qword ptr [7FFE2CE2C228]
       int       3
M09_L77:
       mov       rcx,rax
       mov       rdx,r8
       call      qword ptr [7FFE2CC057E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
       jmp       short M09_L79
M09_L78:
       mov       rdx,r8
       shr       rdx,3
       mov       rcx,rax
       call      qword ptr [7FFE2D2BD500]
M09_L79:
       mov       ecx,10
       shlx      ecx,ecx,esi
       mov       rax,[rbp-100]
       cmp       [rax+8],ecx
       je        short M09_L80
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE2D2BD4D0]
       mov       r14,rax
       mov       ecx,29B
       mov       rdx,7FFE2CB44000
       call      qword ptr [7FFE2CE27798]
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,rbx
       call      qword ptr [7FFE2CF86208]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M09_L80:
       cmp       esi,[rdi+8]
       jae       near ptr M09_L93
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
       je        near ptr M09_L92
       mov       rcx,[rbx+10]
       cmp       esi,[rcx+8]
       jae       near ptr M09_L93
       mov       edx,esi
       mov       rax,[rcx+rdx*8+10]
       test      rax,rax
       jne       short M09_L81
       mov       rcx,rbx
       mov       edx,esi
       call      qword ptr [7FFE2D237F90]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].CreatePerCorePartitions(Int32)
M09_L81:
       mov       r15,[rax+8]
       xor       ecx,ecx
       mov       [rbp-0D8],ecx
       lea       rcx,[rbp-0D8]
       vzeroupper
       call      00007FFE2CBF8E10
       movzx     edi,word ptr [rbp-0D8]
       shl       edi,6
       movzx     r12d,byte ptr [rbp-0D6]
       or        edi,r12d
       mov       ecx,0AAAAAAAB
       mov       eax,edi
       imul      rcx,rax
       shr       rcx,23
       imul      ecx,0C
       sub       edi,ecx
       mov       r12d,[r15+8]
       test      r12d,r12d
       jle       near ptr M09_L91
       mov       [rbp-0F4],r12d
M09_L82:
       cmp       edi,r12d
       jae       near ptr M09_L93
       mov       ecx,edi
       mov       rdx,[r15+rcx*8+10]
       mov       [rbp-130],rdx
       cmp       [rdx],dl
       xor       r8d,r8d
       mov       [rbp-0DC],r8d
       mov       rcx,rdx
       call      00007FFE8C89DF30
       test      eax,eax
       jne       short M09_L83
       mov       rcx,[rbp-130]
       call      qword ptr [7FFE2D2BC450]
M09_L83:
       mov       rax,[rbp-130]
       mov       rcx,[rax+8]
       mov       r8d,[rax+10]
       mov       [rbp-0E0],r8d
       cmp       [rcx+8],r8d
       jbe       short M09_L85
       test      r8d,r8d
       jne       short M09_L87
       xor       edx,edx
       mov       [rax+14],edx
M09_L84:
       movsxd    rdx,r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rbp-0E0]
       inc       ecx
       mov       rax,[rbp-130]
       mov       [rax+10],ecx
       mov       dword ptr [rbp-0DC],1
M09_L85:
       mov       rcx,rax
       call      00007FFE8C89DE50
       test      eax,eax
       je        short M09_L86
       mov       ecx,eax
       mov       rdx,[rbp-130]
       call      qword ptr [7FFE2D2B7ED0]
M09_L86:
       cmp       dword ptr [rbp-0DC],0
       je        short M09_L88
       jmp       short M09_L90
M09_L87:
       jmp       short M09_L84
M09_L88:
       inc       edi
       cmp       r12d,edi
       jne       short M09_L89
       xor       edi,edi
M09_L89:
       mov       eax,[rbp-0F4]
       dec       eax
       mov       [rbp-0F4],eax
       jne       near ptr M09_L82
       jmp       short M09_L91
M09_L90:
       mov       r15d,1
       jmp       short M09_L92
M09_L91:
       xor       r15d,r15d
M09_L92:
       mov       rax,24944800C90
       mov       rdi,[rax]
       cmp       byte ptr [rdi+9D],0
       je        near ptr M09_L96
       mov       rcx,[rbp-100]
       cmp       dword ptr [rcx+8],0
       je        near ptr M09_L96
       call      qword ptr [7FFE2D02D698]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r13d,eax
       mov       rcx,[rbp-100]
       mov       r12d,[rcx+8]
       mov       rcx,rbx
       call      qword ptr [7FFE2D02D698]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,rdi
       mov       r8d,r13d
       mov       r9d,r12d
       mov       edx,3
       call      qword ptr [7FFE2D2BD320]
       test      r15d,r14d
       jne       short M09_L96
       mov       rcx,[rbp-100]
       call      qword ptr [7FFE2D02D698]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r15d,eax
       mov       rcx,[rbp-100]
       mov       r13d,[rcx+8]
       mov       rcx,rbx
       call      qword ptr [7FFE2D02D698]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       test      r14d,r14d
       jne       short M09_L94
       mov       ecx,0FFFFFFFF
       mov       edx,1
       jmp       short M09_L95
M09_L93:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M09_L94:
       mov       ecx,esi
       xor       edx,edx
M09_L95:
       mov       [rsp+20],ecx
       mov       [rsp+28],edx
       mov       rcx,rdi
       mov       edx,r15d
       mov       r8d,r13d
       call      qword ptr [7FFE2D2BD4E8]
M09_L96:
       nop
       vzeroupper
       add       rsp,38
       ret
; Total bytes of code 4025
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rbx
       mov       rbx,rcx
       mov       rdx,[r8]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       pop       rbx
       ret
; Total bytes of code 24
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FFE8C681D18]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       ecx,ebx
       and       ecx,0FFFFFF
       mov       edx,ecx
       mov       r8d,ebx
       sar       r8d,18
       jne       short M11_L01
       cmp       [rax],ecx
       jle       short M11_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M11_L03
M11_L00:
       add       rsp,20
       pop       rbx
       ret
M11_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M11_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M11_L00
M11_L02:
       cmp       [rax+4],edx
       jle       short M11_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M11_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M11_L03
       jmp       short M11_L00
M11_L03:
       mov       ecx,ebx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax]
; Total bytes of code 130
```
```assembly
; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,rbx
       call      qword ptr [7FFE8C684DC8]
       test      eax,eax
       je        short M12_L00
       add       rsp,20
       pop       rbx
       ret
M12_L00:
       mov       rcx,rbx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax]
; Total bytes of code 45
```
```assembly
; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
       sub       rsp,28
       test      ecx,ecx
       jl        short M13_L00
       add       rsp,28
       ret
M13_L00:
       call      qword ptr [7FFE8C691908]
       int       3
; Total bytes of code 20
```
```assembly
; System.Security.Cryptography.CryptographicOperations.ZeroMemory(System.Span`1<Byte>)
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE8993BC30]; Precode of System.Span`1[[System.Byte, System.Private.CoreLib]].Clear()
       nop
       add       rsp,20
       pop       rbp
       ret
; Total bytes of code 31
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
       sub       rsp,58
       vzeroupper
       mov       rdi,rcx
       mov       rbx,rdx
       mov       esi,r8d
       test      rbx,rbx
       je        near ptr M15_L17
       mov       ecx,[rbx+8]
       dec       ecx
       or        ecx,0F
       xor       ebp,ebp
       lzcnt     ebp,ecx
       xor       ebp,1F
       add       ebp,0FFFFFFFD
       mov       rcx,gs:[58]
       mov       rcx,[rcx+38]
       cmp       dword ptr [rcx+238],9
       jle       near ptr M15_L15
       mov       rcx,[rcx+240]
       mov       rax,[rcx+48]
       test      rax,rax
       je        near ptr M15_L15
M15_L00:
       mov       r14,[rax+10]
       test      r14,r14
       je        near ptr M15_L16
M15_L01:
       xor       r15d,r15d
       mov       r13d,1
       cmp       [r14+8],ebp
       jbe       near ptr M15_L11
       mov       r15d,1
       test      sil,sil
       je        short M15_L02
       mov       rcx,[rbx]
       movzx     edx,word ptr [rcx]
       mov       eax,[rbx+8]
       imul      rdx,rax
       lea       rax,[rbx+10]
       test      dword ptr [rcx],1000000
       jne       near ptr M15_L18
       mov       rcx,rax
       call      qword ptr [7FFE2CC057E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
M15_L02:
       mov       ecx,10
       shlx      ecx,ecx,ebp
       cmp       [rbx+8],ecx
       jne       near ptr M15_L19
       mov       ecx,ebp
       shl       rcx,4
       lea       rsi,[r14+rcx+10]
       mov       r14,[rsi]
       mov       [rsp+40],r14
       mov       [rsp+0A8],rbx
       mov       rcx,rsi
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+8],ecx
       test      r14,r14
       je        near ptr M15_L14
       mov       rcx,[rdi+10]
       cmp       ebp,[rcx+8]
       jae       near ptr M15_L29
       mov       edx,ebp
       mov       rax,[rcx+rdx*8+10]
       test      rax,rax
       je        near ptr M15_L20
       mov       [rsp+0A0],rdi
M15_L03:
       mov       r13,[rax+8]
       mov       [rsp+38],r13
       xor       ecx,ecx
       mov       [rsp+50],ecx
       lea       rcx,[rsp+50]
       mov       rax,7FFFAEBF22E0
       call      rax
       movzx     ebx,word ptr [rsp+50]
       shl       ebx,6
       movzx     esi,byte ptr [rsp+52]
       or        ebx,esi
       mov       eax,0AAAAAAAB
       mov       ecx,ebx
       imul      rax,rcx
       shr       rax,23
       imul      eax,0C
       sub       ebx,eax
       cmp       dword ptr [7FFE8CB54A90],0
       jne       near ptr M15_L21
M15_L04:
       mov       r13,[rsp+38]
       mov       esi,[r13+8]
       test      esi,esi
       jle       near ptr M15_L25
       mov       edi,esi
M15_L05:
       cmp       ebx,esi
       jae       near ptr M15_L29
       mov       ecx,ebx
       mov       r14,[r13+rcx*8+10]
       cmp       [r14],r14b
       xor       r12d,r12d
       mov       rcx,r14
       call      00007FFE8C89DF30
       test      eax,eax
       jne       short M15_L06
       mov       rcx,r14
       call      qword ptr [7FFE2D2BC450]
M15_L06:
       mov       rcx,[r14+8]
       mov       eax,[r14+10]
       mov       [rsp+4C],eax
       cmp       [rcx+8],eax
       jbe       short M15_L08
       test      eax,eax
       je        near ptr M15_L13
M15_L07:
       mov       edx,eax
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,[rsp+40]
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12d,[rsp+4C]
       inc       r12d
       mov       [r14+10],r12d
       mov       r12d,1
M15_L08:
       mov       rcx,r14
       call      00007FFE8C89DE50
       test      eax,eax
       jne       near ptr M15_L22
M15_L09:
       test      r12d,r12d
       je        near ptr M15_L23
       mov       r13d,1
M15_L10:
       mov       rbx,[rsp+0A8]
       mov       rdi,[rsp+0A0]
M15_L11:
       mov       rcx,24944800C90
       mov       rsi,[rcx]
       cmp       byte ptr [rsi+9D],0
       jne       near ptr M15_L26
M15_L12:
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M15_L13:
       xor       edx,edx
       mov       [r14+14],edx
       jmp       near ptr M15_L07
M15_L14:
       mov       rbx,[rsp+0A8]
       jmp       short M15_L11
M15_L15:
       mov       ecx,9
       call      qword ptr [7FFE2D2BC0A8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M15_L00
M15_L16:
       mov       rcx,rdi
       call      qword ptr [7FFE2D237E70]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
       mov       r14,rax
       jmp       near ptr M15_L01
M15_L17:
       mov       ecx,2
       call      qword ptr [7FFE2CE2C228]
       int       3
M15_L18:
       shr       rdx,3
       mov       rcx,rax
       call      qword ptr [7FFE2D2BD500]
       jmp       near ptr M15_L02
M15_L19:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       call      qword ptr [7FFE2D2BD4D0]
       mov       r13,rax
       mov       ecx,29B
       mov       rdx,7FFE2CB44000
       call      qword ptr [7FFE2CE27798]
       mov       r8,rax
       mov       rdx,r13
       mov       rcx,r15
       call      qword ptr [7FFE2CF86208]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
       int       3
M15_L20:
       mov       [rsp+0A0],rdi
       mov       rcx,rdi
       mov       edx,ebp
       call      qword ptr [7FFE2D237F90]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].CreatePerCorePartitions(Int32)
       jmp       near ptr M15_L03
M15_L21:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M15_L04
M15_L22:
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FFE2D2B7ED0]
       jmp       near ptr M15_L09
M15_L23:
       inc       ebx
       cmp       esi,ebx
       jne       short M15_L24
       xor       ebx,ebx
M15_L24:
       dec       edi
       jne       near ptr M15_L05
M15_L25:
       xor       r13d,r13d
       jmp       near ptr M15_L10
M15_L26:
       cmp       dword ptr [rbx+8],0
       je        near ptr M15_L12
       mov       rcx,rbx
       call      qword ptr [7FFE2D02D698]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r14d,eax
       mov       r12d,[rbx+8]
       cmp       [rdi],dil
       mov       rcx,rdi
       call      qword ptr [7FFE2D02D698]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,rsi
       mov       r8d,r14d
       mov       r9d,r12d
       mov       edx,3
       call      qword ptr [7FFE2D2BD320]
       test      r13d,r15d
       jne       near ptr M15_L12
       mov       rcx,rbx
       call      qword ptr [7FFE2D02D698]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r14d,eax
       mov       ebx,[rbx+8]
       mov       rcx,rdi
       call      qword ptr [7FFE2D02D698]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       test      r15d,r15d
       jne       short M15_L27
       mov       ecx,0FFFFFFFF
       mov       edx,1
       jmp       short M15_L28
M15_L27:
       mov       ecx,ebp
       xor       edx,edx
M15_L28:
       mov       [rsp+20],ecx
       mov       [rsp+28],edx
       mov       rcx,rsi
       mov       edx,r14d
       mov       r8d,ebx
       call      qword ptr [7FFE2D2BD4E8]
       jmp       near ptr M15_L12
M15_L29:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 967
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Security.EncryptionHelperBenchmark.GenerateRandomKey()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       call      qword ptr [7FFE2D2951A0]; DotNetTips.Spargine.Core.Ulid.NewUlid()
       mov       [rsp+28],rax
       mov       rbx,[rbx+88]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       ret
; Total bytes of code 59
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
       mov       rax,0B77E086AF853
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
       call      qword ptr [7FFE2D215980]; System.DateTimeOffset.get_UtcNow()
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
       mov       r14,20B76A6139C
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
       call      qword ptr [7FFE2D004EE8]; System.Security.Cryptography.RandomNumberGeneratorImplementation.GetBytes(Byte*, Int32)
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
       call      qword ptr [7FFE2D295200]; DotNetTips.Spargine.Core.Ulid..ctor(System.String)
       mov       rax,[rbp+18]
       mov       r8,0B77E086AF853
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

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Security.EncryptionHelperBenchmark.VerifySHA256HashedPassword()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+1C0]
       test      rsi,rsi
       je        near ptr M00_L04
       mov       edi,[rsi+8]
       test      edi,edi
       je        near ptr M00_L04
       movzx     ecx,word ptr [rsi+0C]
       cmp       ecx,100
       jge       near ptr M00_L06
       mov       rbp,7FFE8B9F6B88
       test      byte ptr [rcx+rbp],80
       jne       near ptr M00_L08
M00_L00:
       dec       edi
       mov       ecx,edi
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jge       near ptr M00_L07
       mov       rbp,7FFE8B9F6B88
       test      byte ptr [rcx+rbp],80
       jne       near ptr M00_L08
M00_L01:
       mov       rbp,7FFE8B9F6B88
       test      rsi,rsi
       je        near ptr M00_L09
       mov       edi,[rsi+8]
       test      edi,edi
       je        near ptr M00_L09
       movzx     ecx,word ptr [rsi+0C]
       cmp       ecx,100
       jge       near ptr M00_L11
       test      byte ptr [rcx+rbp],80
       jne       near ptr M00_L13
M00_L02:
       dec       edi
       mov       ecx,edi
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jge       near ptr M00_L12
       test      byte ptr [rcx+rbp],80
       jne       near ptr M00_L13
M00_L03:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Security.HashAlgorithmType
       call      CORINFO_HELP_NEWSFAST
       mov       dword ptr [rax+8],1
       mov       rdx,rax
       mov       rcx,1E270AF13F8
       call      qword ptr [7FFE2CB3A5D0]; System.RuntimeType.IsEnumDefined(System.Object)
       test      eax,eax
       je        near ptr M00_L14
       mov       rcx,rsi
       mov       rdx,1E270AEB210
       mov       r8d,1
       call      qword ptr [7FFE2D2A5170]; DotNetTips.Spargine.Core.Security.PasswordHasher.VerifyHashedPasswordSHA(System.String, System.String, DotNetTips.Spargine.Core.Security.HashAlgorithmType)
       mov       [rsp+20],eax
       mov       rcx,[rbx+88]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE2D2A53C8]; BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Security.PasswordVerificationResult, DotNetTips.Spargine.10.Core]](DotNetTips.Spargine.Core.Security.PasswordVerificationResult ByRef)
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L04:
       call      qword ptr [7FFE2D014858]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L05
       call      qword ptr [7FFE2D2AE850]
       mov       rbx,rax
M00_L05:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,1E270AF1390
       call      qword ptr [7FFE2D2ACE88]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L06:
       call      qword ptr [7FFE2D2AC300]
       test      eax,eax
       jne       short M00_L08
       jmp       near ptr M00_L00
M00_L07:
       call      qword ptr [7FFE2D2AC300]
       test      eax,eax
       je        near ptr M00_L01
M00_L08:
       mov       rcx,rsi
       mov       edx,3
       call      qword ptr [7FFE2D2AC318]
       mov       rsi,rax
       jmp       near ptr M00_L01
M00_L09:
       call      qword ptr [7FFE2D014858]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L10
       call      qword ptr [7FFE2D2AE850]
       mov       rbx,rax
M00_L10:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,1E270AF1390
       call      qword ptr [7FFE2D2ACE88]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L11:
       call      qword ptr [7FFE2D2AC300]
       test      eax,eax
       jne       short M00_L13
       jmp       near ptr M00_L02
M00_L12:
       call      qword ptr [7FFE2D2AC300]
       test      eax,eax
       je        near ptr M00_L03
M00_L13:
       mov       rcx,rsi
       mov       edx,3
       call      qword ptr [7FFE2D2AC318]
       mov       rsi,rax
       jmp       near ptr M00_L03
M00_L14:
       call      qword ptr [7FFE2D2A51E8]
       mov       rbx,rax
       mov       rcx,1E270AE0008
       call      qword ptr [7FFE2CE1E448]; System.String.IsNullOrEmpty(System.String)
       mov       rcx,1E270AE0008
       test      eax,eax
       cmove     rbx,rcx
       mov       ecx,39A6
       mov       rdx,7FFE2CEC4D10
       call      qword ptr [7FFE2CE17798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE2D18FD50]
       int       3
; Total bytes of code 631
```
```assembly
; System.RuntimeType.IsEnumDefined(System.Object)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,rdx
M01_L00:
       test      rsi,rsi
       je        near ptr M01_L20
       mov       rcx,[rbx+18]
       test      cl,2
       jne       near ptr M01_L14
       mov       rcx,[rcx+10]
       mov       rax,offset MT_System.Enum
       cmp       rcx,rax
       sete      cl
       movzx     ecx,cl
M01_L01:
       test      ecx,ecx
       je        near ptr M01_L22
       mov       rcx,rsi
       call      qword ptr [7FFE2CBFC9A8]; System.Object.GetType()
       mov       rdi,rax
       mov       rcx,[rdi+18]
       test      cl,2
       jne       near ptr M01_L15
       mov       rcx,[rcx+10]
       mov       rdx,offset MT_System.Enum
       cmp       rcx,rdx
       sete      cl
       movzx     ecx,cl
M01_L02:
       test      ecx,ecx
       je        short M01_L05
       cmp       rbx,rdi
       jne       near ptr M01_L21
M01_L03:
       mov       rcx,[rdi+18]
       mov       rax,rcx
       test      al,2
       jne       near ptr M01_L16
       mov       rax,[rax+10]
       mov       rdx,offset MT_System.Enum
       cmp       rax,rdx
       sete      al
       movzx     eax,al
M01_L04:
       test      eax,eax
       je        near ptr M01_L22
       call      00007FFE8C84E010
       mov       rcx,1A1DBC009D8
       mov       rbp,[rcx]
       cmp       eax,1A
       jae       near ptr M01_L60
       mov       ecx,eax
       mov       rcx,[rbp+rcx*8+10]
       mov       rdi,rcx
M01_L05:
       mov       rcx,1E270AE0020
       cmp       rdi,rcx
       je        near ptr M01_L23
       mov       rcx,1E270AE3120
       cmp       rdi,rcx
       jne       near ptr M01_L24
M01_L06:
       mov       rcx,[rbx+18]
       call      00007FFE8C84E010
       mov       rcx,1A1DBC009D8
       mov       rbp,[rcx]
       cmp       eax,1A
       jae       near ptr M01_L60
       mov       ecx,eax
       mov       rbp,[rbp+rcx*8+10]
       cmp       rbp,rdi
       jne       near ptr M01_L25
       mov       rcx,[rdi+10]
       test      rcx,rcx
       je        near ptr M01_L26
       mov       rax,[rcx]
       test      rax,rax
       je        near ptr M01_L26
M01_L07:
       mov       ebp,[rax+98]
       test      ebp,ebp
       je        near ptr M01_L27
M01_L08:
       add       ebp,0FFFFFFFC
       cmp       ebp,5
       jne       near ptr M01_L47
       mov       rdx,offset MT_System.Int32
       cmp       [rsi],rdx
       je        short M01_L09
       mov       rdx,rsi
       mov       rcx,offset MT_System.Int32
       call      System.Runtime.CompilerServices.CastHelpers.Unbox(System.Runtime.CompilerServices.MethodTable*, System.Object)
M01_L09:
       mov       esi,[rsi+8]
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        near ptr M01_L49
       mov       rax,[rcx]
       test      rax,rax
       je        near ptr M01_L49
M01_L10:
       mov       rcx,[rax+80]
       test      rcx,rcx
       je        short M01_L18
       mov       rdx,offset MT_System.Enum+EnumInfo<System.UInt32>
       cmp       [rcx],rdx
       jne       short M01_L17
       mov       rax,rcx
M01_L11:
       test      rax,rax
       je        short M01_L19
M01_L12:
       mov       rcx,[rax+8]
       cmp       byte ptr [rax+19],0
       je        near ptr M01_L50
       mov       edx,esi
       mov       ecx,[rcx+8]
       cmp       rcx,rdx
       seta      al
       movzx     eax,al
M01_L13:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L14:
       xor       ecx,ecx
       jmp       near ptr M01_L01
M01_L15:
       xor       ecx,ecx
       jmp       near ptr M01_L02
M01_L16:
       xor       eax,eax
       jmp       near ptr M01_L04
M01_L17:
       mov       rdx,offset MT_System.RuntimeType+CompositeCacheEntry
       cmp       [rcx],rdx
       jne       short M01_L18
       mov       rax,[rcx+28]
       jmp       short M01_L11
M01_L18:
       xor       eax,eax
       jmp       short M01_L11
M01_L19:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFE2CE1DEA8]; System.Enum.<GetEnumInfo>g__InitializeEnumInfo|5_0[[System.UInt32, System.Private.CoreLib]](System.RuntimeType, Boolean)
       jmp       short M01_L12
M01_L20:
       mov       ecx,3AD
       mov       rdx,7FFE2CB34000
       call      qword ptr [7FFE2CE17798]
       mov       rcx,rax
       call      qword ptr [7FFE2D2A7A68]
       int       3
M01_L21:
       mov       rcx,rdi
       mov       rdx,rbx
       call      qword ptr [7FFE2D2ACD50]
       test      eax,eax
       jne       near ptr M01_L03
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       call      qword ptr [7FFE2D2AD8C0]
       mov       rcx,rax
       mov       rdx,rdi
       mov       r8,rbx
       call      qword ptr [7FFE2D2AC1C8]
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FFE2CF74318]
       mov       rcx,rbp
       call      CORINFO_HELP_THROW
       int       3
M01_L22:
       call      qword ptr [7FFE2D2AD8A8]
       int       3
M01_L23:
       mov       rcx,rbx
       call      qword ptr [7FFE2D22F2E8]; System.Enum.GetNamesNoCopy(System.RuntimeType)
       mov       rbx,rax
       mov       rdx,rsi
       mov       rcx,offset MT_System.String
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,7FFE2D2B4AD0
       call      qword ptr [7FFE2D2A5200]
       not       eax
       shr       eax,1F
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L24:
       mov       rcx,1E270AE53E0
       cmp       rdi,rcx
       je        near ptr M01_L06
       mov       rcx,1E270AE3070
       cmp       rdi,rcx
       je        near ptr M01_L06
       mov       rcx,1E270AE2ED0
       cmp       rdi,rcx
       je        near ptr M01_L06
       mov       rcx,1E270AE53B8
       cmp       rdi,rcx
       je        near ptr M01_L06
       mov       rcx,1E270AE2E58
       cmp       rdi,rcx
       je        near ptr M01_L06
       mov       rcx,1E270AE5408
       cmp       rdi,rcx
       je        near ptr M01_L06
       mov       rcx,1E270AE2C50
       cmp       rdi,rcx
       je        near ptr M01_L06
       mov       rcx,1E270AE5390
       cmp       rdi,rcx
       je        near ptr M01_L06
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE2D2AD8D8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE2CF76160]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L25:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE2D2AD8F0]
       mov       rcx,rax
       mov       rdx,rdi
       mov       r8,rbp
       call      qword ptr [7FFE2D2AC1C8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE2CF74318]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L26:
       mov       rcx,rdi
       call      qword ptr [7FFE2CBF7C30]; System.RuntimeType.InitializeCache()
       jmp       near ptr M01_L07
M01_L27:
       mov       rbp,rdi
       mov       rcx,rbp
       call      qword ptr [7FFE2CD6F2E8]; System.RuntimeType.get_IsActualEnum()
       test      eax,eax
       je        short M01_L28
       mov       rcx,rdi
       call      qword ptr [7FFE2CB3A588]; Precode of System.RuntimeType.GetEnumUnderlyingType()
       mov       rbp,rax
       test      rbp,rbp
       je        short M01_L28
       mov       rcx,offset MT_System.RuntimeType
       cmp       [rbp],rcx
       je        short M01_L28
       mov       rdx,rax
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M01_L28:
       mov       rcx,1E270AE53B8
       cmp       rbp,rcx
       jne       short M01_L29
       mov       ebp,5
       jmp       near ptr M01_L44
M01_L29:
       mov       rcx,1E270AE2ED0
       cmp       rbp,rcx
       jne       short M01_L30
       mov       ebp,6
       jmp       near ptr M01_L44
M01_L30:
       mov       rcx,1E270AE53E0
       cmp       rbp,rcx
       jne       short M01_L31
       mov       ebp,7
       jmp       near ptr M01_L44
M01_L31:
       mov       rcx,1E270AE3070
       cmp       rbp,rcx
       jne       short M01_L32
       mov       ebp,8
       jmp       near ptr M01_L44
M01_L32:
       mov       rcx,1E270AE3120
       cmp       rbp,rcx
       jne       short M01_L33
       mov       ebp,9
       jmp       near ptr M01_L44
M01_L33:
       mov       rcx,1E270AE2E58
       cmp       rbp,rcx
       jne       short M01_L34
       mov       ebp,0A
       jmp       near ptr M01_L44
M01_L34:
       mov       rcx,1E270AE5408
       cmp       rbp,rcx
       jne       short M01_L35
       mov       ebp,0B
       jmp       near ptr M01_L44
M01_L35:
       mov       rcx,1E270AE2C50
       cmp       rbp,rcx
       jne       short M01_L36
       mov       ebp,0C
       jmp       near ptr M01_L44
M01_L36:
       mov       rcx,1E270AE5368
       cmp       rbp,rcx
       jne       short M01_L37
       mov       ebp,3
       jmp       near ptr M01_L44
M01_L37:
       mov       rcx,1E270AE5390
       cmp       rbp,rcx
       jne       short M01_L38
       mov       ebp,4
       jmp       near ptr M01_L44
M01_L38:
       mov       rcx,1E270AE5430
       cmp       rbp,rcx
       jne       short M01_L39
       mov       ebp,0D
       jmp       short M01_L44
M01_L39:
       mov       rcx,1E270AE5458
       cmp       rbp,rcx
       jne       short M01_L40
       mov       ebp,0E
       jmp       short M01_L44
M01_L40:
       mov       rcx,1E270AE62E0
       cmp       rbp,rcx
       jne       short M01_L41
       mov       ebp,0F
       jmp       short M01_L44
M01_L41:
       mov       rcx,1E270AE2AC8
       cmp       rbp,rcx
       jne       short M01_L42
       mov       ebp,10
       jmp       short M01_L44
M01_L42:
       mov       rcx,1E270AE0020
       cmp       rbp,rcx
       jne       short M01_L43
       mov       ebp,12
       jmp       short M01_L44
M01_L43:
       mov       rcx,1E270AF1438
       mov       eax,1
       mov       edx,2
       cmp       rbp,rcx
       cmove     eax,edx
       mov       ebp,eax
M01_L44:
       mov       rcx,[rdi+10]
       test      rcx,rcx
       je        short M01_L45
       mov       rax,[rcx]
       test      rax,rax
       je        short M01_L45
       jmp       short M01_L46
M01_L45:
       mov       rcx,rdi
       call      qword ptr [7FFE2CBF7C30]; System.RuntimeType.InitializeCache()
M01_L46:
       mov       [rax+98],ebp
       jmp       near ptr M01_L08
M01_L47:
       cmp       ebp,0A
       ja        short M01_L48
       mov       edx,ebp
       lea       rcx,[7FFE2D3311A8]
       mov       ecx,[rcx+rdx*4]
       lea       rax,[M01_L00]
       add       rcx,rax
       jmp       rcx
M01_L48:
       mov       rdx,1E270AE3048
       cmp       rdi,rdx
       je        near ptr M01_L58
       jmp       near ptr M01_L56
       mov       rdx,rsi
       mov       rcx,offset MT_System.SByte
       call      System.Runtime.CompilerServices.CastHelpers.Unbox(System.Runtime.CompilerServices.MethodTable*, System.Object)
       movzx     edx,byte ptr [rax]
       mov       rcx,rbx
       call      qword ptr [7FFE2D2AD4E8]
       jmp       near ptr M01_L13
       mov       rdx,rsi
       mov       rcx,offset MT_System.Byte
       call      System.Runtime.CompilerServices.CastHelpers.Unbox(System.Runtime.CompilerServices.MethodTable*, System.Object)
       movzx     edx,byte ptr [rax]
       mov       rcx,rbx
       call      qword ptr [7FFE2D2AD4E8]
       jmp       near ptr M01_L13
       mov       rdx,rsi
       mov       rcx,offset MT_System.Int16
       call      System.Runtime.CompilerServices.CastHelpers.Unbox(System.Runtime.CompilerServices.MethodTable*, System.Object)
       movzx     edx,word ptr [rax]
       mov       rcx,rbx
       call      qword ptr [7FFE2D2AD4D0]
       jmp       near ptr M01_L13
       mov       rdx,rsi
       mov       rcx,offset MT_System.UInt16
       call      System.Runtime.CompilerServices.CastHelpers.Unbox(System.Runtime.CompilerServices.MethodTable*, System.Object)
       movzx     edx,word ptr [rax]
       mov       rcx,rbx
       call      qword ptr [7FFE2D2AD4D0]
       jmp       near ptr M01_L13
M01_L49:
       mov       rcx,rbx
       call      qword ptr [7FFE2CBF7C30]; System.RuntimeType.InitializeCache()
       jmp       near ptr M01_L10
M01_L50:
       test      rcx,rcx
       jne       short M01_L51
       xor       eax,eax
       xor       r8d,r8d
       jmp       short M01_L52
M01_L51:
       lea       rax,[rcx+10]
       mov       r8d,[rcx+8]
M01_L52:
       cmp       dword ptr [rcx+8],20
       jle       short M01_L53
       mov       rcx,rax
       mov       edx,r8d
       mov       r8d,esi
       call      qword ptr [7FFE2D2ADB30]
       jmp       short M01_L54
M01_L53:
       mov       rcx,rax
       mov       edx,esi
       call      qword ptr [7FFE2D2ADD40]; System.SpanHelpers.NonPackedIndexOfValueType[[System.Int32, System.Private.CoreLib],[System.SpanHelpers+DontNegate`1[[System.Int32, System.Private.CoreLib]], System.Private.CoreLib]](Int32 ByRef, Int32, Int32)
M01_L54:
       not       eax
       shr       eax,1F
       jmp       near ptr M01_L13
       mov       rdx,rsi
       mov       rcx,offset MT_System.UInt32
       call      System.Runtime.CompilerServices.CastHelpers.Unbox(System.Runtime.CompilerServices.MethodTable*, System.Object)
       mov       edx,[rax]
       mov       rcx,rbx
       call      qword ptr [7FFE2D2A5260]; System.Enum.IsDefinedPrimitive[[System.UInt32, System.Private.CoreLib]](System.RuntimeType, UInt32)
       jmp       near ptr M01_L13
       mov       rdx,rsi
       mov       rcx,offset MT_System.Int64
       call      System.Runtime.CompilerServices.CastHelpers.Unbox(System.Runtime.CompilerServices.MethodTable*, System.Object)
       mov       rdx,[rax]
       mov       rcx,rbx
       call      qword ptr [7FFE2D2AD4B8]
       jmp       near ptr M01_L13
       mov       rdx,rsi
       mov       rcx,offset MT_System.UInt64
       call      System.Runtime.CompilerServices.CastHelpers.Unbox(System.Runtime.CompilerServices.MethodTable*, System.Object)
       mov       rdx,[rax]
       mov       rcx,rbx
       call      qword ptr [7FFE2D2AD4B8]
       jmp       near ptr M01_L13
       mov       rdx,rsi
       mov       rcx,offset MT_System.Single
       call      System.Runtime.CompilerServices.CastHelpers.Unbox(System.Runtime.CompilerServices.MethodTable*, System.Object)
       vmovss    xmm1,dword ptr [rax]
       mov       rcx,rbx
       call      qword ptr [7FFE2D2AD4A0]
       jmp       near ptr M01_L13
       mov       rdx,rsi
       mov       rcx,offset MT_System.Double
       call      System.Runtime.CompilerServices.CastHelpers.Unbox(System.Runtime.CompilerServices.MethodTable*, System.Object)
       vmovsd    xmm1,qword ptr [rax]
       mov       rcx,rbx
       call      qword ptr [7FFE2D2AD488]
       jmp       near ptr M01_L13
       mov       rcx,offset MT_System.Char
       cmp       [rsi],rcx
       je        short M01_L55
       mov       rdx,rsi
       call      System.Runtime.CompilerServices.CastHelpers.Unbox(System.Runtime.CompilerServices.MethodTable*, System.Object)
M01_L55:
       movzx     edx,word ptr [rsi+8]
       mov       rcx,rbx
       call      qword ptr [7FFE2D2AD500]
       jmp       near ptr M01_L13
M01_L56:
       mov       rdx,1E270AE5480
       cmp       rdi,rdx
       je        short M01_L57
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE2D2AD8D8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE2CF76160]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M01_L57:
       mov       rdx,rsi
       mov       rcx,offset MT_System.UIntPtr
       call      System.Runtime.CompilerServices.CastHelpers.Unbox(System.Runtime.CompilerServices.MethodTable*, System.Object)
       mov       rdx,[rax]
       mov       rcx,rbx
       call      qword ptr [7FFE2D2AD470]
       jmp       short M01_L59
M01_L58:
       mov       rdx,rsi
       mov       rcx,offset MT_System.IntPtr
       call      System.Runtime.CompilerServices.CastHelpers.Unbox(System.Runtime.CompilerServices.MethodTable*, System.Object)
       mov       rdx,[rax]
       mov       rcx,rbx
       call      qword ptr [7FFE2D2AD470]
M01_L59:
       jmp       near ptr M01_L13
M01_L60:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 2100
```
```assembly
; DotNetTips.Spargine.Core.Security.PasswordHasher.VerifyHashedPasswordSHA(System.String, System.String, DotNetTips.Spargine.Core.Security.HashAlgorithmType)
; 		var hash = HashPassword(password, algorithmType);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return CryptographicOperations.FixedTimeEquals(Convert.FromBase64String(hashedPassword), Convert.FromBase64String(hash))
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			? PasswordVerificationResult.Success
; 			                                    
; 			: PasswordVerificationResult.Failed;
; 			                                    
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,88
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+30],ymm4
       vmovdqu   ymmword ptr [rsp+50],ymm4
       vmovdqa   xmmword ptr [rsp+70],xmm4
       mov       [rsp+80],rax
       mov       rbx,rcx
       mov       rcx,rdx
       mov       edx,r8d
       call      qword ptr [7FFE2CF7E460]; DotNetTips.Spargine.Core.Security.PasswordHasher.HashPassword(System.String, DotNetTips.Spargine.Core.Security.HashAlgorithmType)
       mov       rsi,rax
       test      rbx,rbx
       je        near ptr M02_L18
       lea       rcx,[rbx+0C]
       mov       [rsp+80],rcx
       mov       rdi,[rsp+80]
       mov       ebx,[rbx+8]
       test      ebx,ebx
       jle       short M02_L01
       nop       word ptr [rax+rax]
M02_L00:
       lea       ecx,[rbx-1]
       movsxd    rcx,ecx
       movzx     ecx,word ptr [rdi+rcx*2]
       cmp       ecx,20
       ja        short M02_L01
       mov       eax,0FFFFD9FF
       bt        rax,rcx
       jb        short M02_L01
       dec       ebx
       test      ebx,ebx
       jg        short M02_L00
M02_L01:
       mov       rcx,rdi
       movsxd    rax,ebx
       lea       rax,[rcx+rax*2]
       mov       edx,ebx
       xor       ebp,ebp
       cmp       rdi,rax
       jae       short M02_L04
M02_L02:
       movzx     r8d,word ptr [rcx]
       add       rcx,2
       cmp       r8d,20
       jbe       near ptr M02_L14
       cmp       r8d,3D
       je        near ptr M02_L12
M02_L03:
       cmp       rcx,rax
       jb        short M02_L02
M02_L04:
       test      ebp,ebp
       je        short M02_L05
       cmp       ebp,1
       jne       near ptr M02_L15
       mov       ebp,2
M02_L05:
       mov       ecx,edx
       sar       ecx,1F
       and       ecx,3
       add       ecx,edx
       sar       ecx,2
       lea       r14d,[rcx+rcx*2]
       add       r14d,ebp
       movsxd    rdx,r14d
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbp,rax
       test      ebx,ebx
       jl        near ptr M02_L22
       lea       rcx,[rbp+10]
       mov       edx,r14d
       mov       [rsp+58],rdi
       mov       [rsp+60],ebx
       mov       [rsp+48],rcx
       mov       [rsp+50],edx
       lea       rcx,[rsp+58]
       lea       rdx,[rsp+48]
       lea       r8,[rsp+78]
       call      qword ptr [7FFE2D2A5320]; System.Convert.TryFromBase64Chars(System.ReadOnlySpan`1<Char>, System.Span`1<Byte>, Int32 ByRef)
       test      eax,eax
       je        near ptr M02_L17
       xor       ecx,ecx
       mov       [rsp+80],rcx
       add       rbp,10
       test      rsi,rsi
       je        near ptr M02_L18
       lea       rcx,[rsi+0C]
       mov       [rsp+70],rcx
       mov       rbx,[rsp+70]
       mov       esi,[rsi+8]
       test      esi,esi
       jle       short M02_L07
       nop       dword ptr [rax]
M02_L06:
       lea       ecx,[rsi-1]
       movsxd    rcx,ecx
       movzx     ecx,word ptr [rbx+rcx*2]
       cmp       ecx,20
       ja        short M02_L07
       mov       eax,0FFFFD9FF
       bt        rax,rcx
       jb        short M02_L07
       dec       esi
       test      esi,esi
       jg        short M02_L06
M02_L07:
       mov       rcx,rbx
       movsxd    rax,esi
       lea       rax,[rcx+rax*2]
       mov       edx,esi
       xor       edi,edi
       cmp       rbx,rax
       jae       short M02_L10
M02_L08:
       movzx     r8d,word ptr [rcx]
       add       rcx,2
       cmp       r8d,20
       jbe       near ptr M02_L19
       cmp       r8d,3D
       je        near ptr M02_L13
M02_L09:
       cmp       rcx,rax
       jb        short M02_L08
M02_L10:
       test      edi,edi
       je        short M02_L11
       cmp       edi,1
       jne       near ptr M02_L20
       mov       edi,2
M02_L11:
       mov       ecx,edx
       sar       ecx,1F
       and       ecx,3
       add       ecx,edx
       sar       ecx,2
       lea       r15d,[rcx+rcx*2]
       add       r15d,edi
       movsxd    rdx,r15d
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rdi,rax
       test      esi,esi
       jl        near ptr M02_L22
       lea       rcx,[rdi+10]
       mov       edx,r15d
       mov       [rsp+58],rbx
       mov       [rsp+60],esi
       mov       [rsp+48],rcx
       mov       [rsp+50],edx
       lea       rcx,[rsp+58]
       lea       rdx,[rsp+48]
       lea       r8,[rsp+68]
       call      qword ptr [7FFE2D2A5320]; System.Convert.TryFromBase64Chars(System.ReadOnlySpan`1<Char>, System.Span`1<Byte>, Int32 ByRef)
       test      eax,eax
       je        near ptr M02_L23
       xor       ecx,ecx
       mov       [rsp+70],rcx
       add       rdi,10
       mov       [rsp+38],rbp
       mov       [rsp+40],r14d
       mov       [rsp+28],rdi
       mov       [rsp+30],r15d
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+28]
       call      qword ptr [7FFE2D2A5290]; System.Security.Cryptography.CryptographicOperations.FixedTimeEquals(System.ReadOnlySpan`1<Byte>, System.ReadOnlySpan`1<Byte>)
       test      eax,eax
       setne     al
       movzx     eax,al
       add       rsp,88
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L12:
       dec       edx
       inc       ebp
       jmp       near ptr M02_L03
M02_L13:
       dec       edx
       inc       edi
       jmp       near ptr M02_L09
M02_L14:
       dec       edx
       jmp       near ptr M02_L03
M02_L15:
       cmp       ebp,2
       jne       short M02_L16
       mov       ebp,1
       jmp       near ptr M02_L05
M02_L16:
       mov       rcx,offset MT_System.FormatException
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       call      qword ptr [7FFE2D2AD3F8]
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FFE2D2AD410]
       mov       rcx,rbp
       call      CORINFO_HELP_THROW
       int       3
M02_L17:
       mov       rcx,offset MT_System.FormatException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE2D2AD3F8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE2D2AD410]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M02_L18:
       mov       ecx,11
       call      qword ptr [7FFE2CE1C228]
       int       3
M02_L19:
       dec       edx
       jmp       near ptr M02_L09
M02_L20:
       cmp       edi,2
       jne       short M02_L21
       mov       edi,1
       jmp       near ptr M02_L11
M02_L21:
       mov       rcx,offset MT_System.FormatException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFE2D2AD3F8]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFE2D2AD410]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M02_L22:
       call      qword ptr [7FFE2CD67198]
       int       3
M02_L23:
       mov       rcx,offset MT_System.FormatException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE2D2AD3F8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE2D2AD410]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 905
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Core.Security.PasswordVerificationResult, DotNetTips.Spargine.10.Core]](DotNetTips.Spargine.Core.Security.PasswordVerificationResult ByRef)
       mov       rcx,rdx
       jmp       qword ptr [7FFE2D2A5410]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Core.Security.PasswordVerificationResult, DotNetTips.Spargine.10.Core]](DotNetTips.Spargine.Core.Security.PasswordVerificationResult ByRef)
; Total bytes of code 9
```
```assembly
; System.String.IsNullOrEmpty(System.String)
       test      rcx,rcx
       je        short M04_L00
       cmp       dword ptr [rcx+8],0
       sete      al
       movzx     eax,al
       ret
M04_L00:
       mov       eax,1
       ret
; Total bytes of code 22
```

