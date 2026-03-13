## .NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       sub       rsp,338
       vzeroupper
       lea       rbp,[rsp+370]
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFD90
M00_L00:
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       vmovdqa   xmmword ptr [rbp+rax-20],xmm4
       add       rax,30
       jne       short M00_L00
       mov       [rbp+10],rcx
       mov       rbx,[rcx+30]
       mov       rsi,[rcx+150]
       mov       rax,[rcx+148]
       test      rax,rax
       je        short M00_L01
       lea       rdi,[rax+10]
       mov       r14d,[rax+8]
       jmp       short M00_L02
M00_L01:
       xor       edi,edi
       xor       r14d,r14d
M00_L02:
       mov       [rbp-318],rdi
       mov       [rbp-278],rsi
       test      rbx,rbx
       je        near ptr M00_L56
       mov       eax,[rbx+8]
       cmp       dword ptr [rbx+8],0
       je        near ptr M00_L56
       movzx     eax,word ptr [rbx+0C]
       cmp       eax,100
       jge       near ptr M00_L58
       mov       rdx,7FF882CF6998
       test      byte ptr [rdx+rax],80
       jne       near ptr M00_L60
M00_L03:
       mov       eax,[rbx+8]
       dec       eax
       cmp       eax,[rbx+8]
       jae       near ptr M00_L101
       movzx     eax,word ptr [rbx+rax*2+0C]
       cmp       eax,100
       jge       near ptr M00_L59
       mov       rdx,7FF882CF6998
       test      byte ptr [rdx+rax],80
       jne       near ptr M00_L60
M00_L04:
       mov       [rbp-270],rbx
       test      rsi,rsi
       je        near ptr M00_L61
       mov       r8d,[rsi+8]
       test      r8d,r8d
       setg      r8b
       movzx     r8d,r8b
       test      r8d,r8d
       je        near ptr M00_L61
       cmp       dword ptr [rsi+8],20
       jne       near ptr M00_L63
       mov       r8,1279C000220
       mov       r15,[r8]
       mov       [rbp-340],r15
       mov       r13,r15
       test      rbx,rbx
       je        near ptr M00_L64
       lea       r8,[rbx+0C]
       mov       [rbp-0B0],r8
       mov       r12,[rbp-0B0]
       mov       eax,[rbx+8]
       mov       [rbp-0B4],eax
       lea       r8,[rbp-0C0]
       lea       r9,[rbp-0C8]
       mov       rcx,r12
       mov       edx,eax
       call      qword ptr [7FF823F0FAF8]; System.Text.Unicode.Utf16Utility.GetPointerToFirstInvalidChar(Char*, Int32, Int64 ByRef, Int32 ByRef)
       sub       rax,r12
       mov       r9,rax
       shr       r9,3F
       add       r9,rax
       sar       r9,1
       movsxd    rax,r9d
       add       rax,[rbp-0C0]
       cmp       rax,7FFFFFFF
       ja        near ptr M00_L66
       mov       [rbp-0B8],eax
       mov       r8d,[rbp-0B4]
       cmp       r9d,r8d
       jne       near ptr M00_L65
M00_L05:
       xor       ecx,ecx
       mov       [rbp-0B0],rcx
       mov       eax,[rbp-0B8]
       mov       r13d,eax
       mov       rcx,1279C001E00
       mov       r12,[rcx]
       mov       [rbp-330],r12
       mov       [rbp-2C8],r12
       mov       dword ptr [rbp-0CC],0C
       mov       rcx,1279C000C90
       mov       r8,[rcx]
       mov       [rbp-338],r8
       mov       [rbp-2C0],r8
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+238],9
       jle       near ptr M00_L67
       mov       rcx,[rcx+240]
       mov       r9,[rcx+48]
       test      r9,r9
       je        near ptr M00_L67
M00_L06:
       mov       [rbp-328],r9
       mov       rcx,[r9+10]
       test      rcx,rcx
       je        short M00_L07
       cmp       dword ptr [rcx+8],0
       je        short M00_L07
       mov       r11,[rcx+10]
       test      r11,r11
       jne       near ptr M00_L14
M00_L07:
       mov       rax,[rbp-2C8]
       mov       rcx,[rax+10]
       mov       r11d,[rcx+8]
       test      r11d,r11d
       je        near ptr M00_L74
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        near ptr M00_L73
       mov       rdx,[rcx+8]
       mov       [rbp-2D8],rdx
       xor       ecx,ecx
       mov       [rbp-0E8],ecx
       lea       rcx,[rbp-0E8]
       mov       r11,7FF98C8F22E0
       call      r11
       movzx     ebx,word ptr [rbp-0E8]
       shl       ebx,6
       movzx     esi,byte ptr [rbp-0E6]
       or        ebx,esi
       mov       eax,0AAAAAAAB
       mov       ecx,ebx
       imul      rax,rcx
       shr       rax,23
       imul      eax,0C
       sub       ebx,eax
       xor       esi,esi
       cmp       dword ptr [7FF883E53B10],0
       jne       near ptr M00_L69
M00_L08:
       mov       rdi,[rbp-2D8]
       cmp       dword ptr [rdi+8],0
       jle       near ptr M00_L71
M00_L09:
       cmp       ebx,[rdi+8]
       jae       near ptr M00_L101
       mov       ecx,ebx
       mov       r15,[rdi+rcx*8+10]
       cmp       [r15],r15b
       xor       r12d,r12d
       mov       rcx,r15
       call      00007FF883B9DAF0
       test      eax,eax
       jne       short M00_L10
       mov       rcx,r15
       call      qword ptr [7FF82466C990]
M00_L10:
       mov       rcx,[r15+8]
       mov       eax,[r15+10]
       dec       eax
       cmp       [rcx+8],eax
       ja        short M00_L15
M00_L11:
       mov       rcx,r15
       call      00007FF883B9DA10
       test      eax,eax
       jne       near ptr M00_L70
M00_L12:
       test      r12,r12
       jne       short M00_L17
       inc       ebx
       cmp       [rdi+8],ebx
       je        short M00_L16
M00_L13:
       inc       esi
       cmp       [rdi+8],esi
       jg        short M00_L09
       jmp       near ptr M00_L71
M00_L14:
       xor       edx,edx
       mov       [rcx+10],rdx
       mov       r10,[rbp-2C0]
       cmp       byte ptr [r10+9D],0
       jne       near ptr M00_L68
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
       je        near ptr M00_L73
       mov       rsi,[rbp-2C0]
       cmp       byte ptr [rsi+9D],0
       jne       near ptr M00_L72
M00_L19:
       mov       [rbp-280],rbx
       mov       r12,[rbp-330]
       mov       rbx,r12
       mov       esi,1
       test      r13d,r13d
       cmovne    esi,r13d
       mov       rcx,offset MT_System.Buffers.SharedArrayPool<System.Byte>
       cmp       [rbx],rcx
       jne       near ptr M00_L89
       mov       rax,rbx
       mov       [rbp-2B8],rax
       mov       rdx,[rbp-338]
       mov       r8,rdx
       mov       [rbp-2E0],r8
       lea       ecx,[rsi-1]
       or        ecx,0F
       xor       r10d,r10d
       lzcnt     r10d,ecx
       xor       r10d,1F
       add       r10d,0FFFFFFFD
       mov       [rbp-0EC],r10d
       mov       r9,[rbp-328]
       mov       rcx,[r9+10]
       test      rcx,rcx
       je        short M00_L20
       cmp       [rcx+8],r10d
       jbe       short M00_L20
       cmp       r10d,[rcx+8]
       jae       near ptr M00_L101
       mov       r11d,r10d
       shl       r11,4
       mov       r11,[rcx+r11+10]
       test      r11,r11
       jne       near ptr M00_L27
M00_L20:
       mov       rcx,[rax+10]
       mov       r11d,[rcx+8]
       cmp       r11d,r10d
       jbe       near ptr M00_L84
       cmp       r10d,r11d
       jae       near ptr M00_L101
       mov       r11d,r10d
       mov       rcx,[rcx+r11*8+10]
       test      rcx,rcx
       je        near ptr M00_L83
       mov       rsi,[rcx+8]
       mov       [rbp-2F0],rsi
       xor       ecx,ecx
       mov       [rbp-108],ecx
       lea       rcx,[rbp-108]
       mov       r11,7FF98C8F22E0
       call      r11
       movzx     ebx,word ptr [rbp-108]
       shl       ebx,6
       movzx     esi,byte ptr [rbp-106]
       or        ebx,esi
       mov       eax,0AAAAAAAB
       mov       ecx,ebx
       imul      rax,rcx
       shr       rax,23
       imul      eax,0C
       sub       ebx,eax
       xor       esi,esi
       cmp       dword ptr [7FF883E53B10],0
       jne       near ptr M00_L79
M00_L21:
       mov       rdi,[rbp-2F0]
       cmp       dword ptr [rdi+8],0
       jle       near ptr M00_L81
M00_L22:
       cmp       ebx,[rdi+8]
       jae       near ptr M00_L101
       mov       ecx,ebx
       mov       r15,[rdi+rcx*8+10]
       cmp       [r15],r15b
       xor       r12d,r12d
       mov       rcx,r15
       call      00007FF883B9DAF0
       test      eax,eax
       jne       short M00_L23
       mov       rcx,r15
       call      qword ptr [7FF82466C990]
M00_L23:
       mov       rcx,[r15+8]
       mov       eax,[r15+10]
       dec       eax
       cmp       [rcx+8],eax
       ja        short M00_L28
M00_L24:
       mov       rcx,r15
       call      00007FF883B9DA10
       test      eax,eax
       jne       near ptr M00_L80
M00_L25:
       test      r12,r12
       jne       short M00_L30
       inc       ebx
       cmp       [rdi+8],ebx
       je        short M00_L29
M00_L26:
       inc       esi
       cmp       [rdi+8],esi
       jg        short M00_L22
       jmp       near ptr M00_L81
M00_L27:
       cmp       r10d,[rcx+8]
       jae       near ptr M00_L101
       mov       eax,r10d
       shl       rax,4
       xor       esi,esi
       mov       [rcx+rax+10],rsi
       cmp       byte ptr [r8+9D],0
       jne       near ptr M00_L78
       mov       rbx,r11
       jmp       short M00_L32
M00_L28:
       cmp       eax,[rcx+8]
       jae       near ptr M00_L101
       mov       edx,eax
       mov       r12,[rcx+rdx*8+10]
       cmp       eax,[rcx+8]
       jae       near ptr M00_L101
       mov       edx,eax
       xor       r8d,r8d
       mov       [rcx+rdx*8+10],r8
       mov       [r15+10],eax
       jmp       short M00_L24
M00_L29:
       xor       ebx,ebx
       jmp       short M00_L26
M00_L30:
       mov       rdx,r12
M00_L31:
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M00_L83
       mov       rsi,[rbp-2E0]
       cmp       byte ptr [rsi+9D],0
       jne       near ptr M00_L82
M00_L32:
       mov       rdx,rbx
M00_L33:
       mov       [rbp-288],rdx
       mov       r12,[rbp-330]
       mov       rcx,r12
       mov       edx,1
       test      r13d,r13d
       cmovne    edx,r13d
       mov       rax,offset MT_System.Buffers.SharedArrayPool<System.Byte>
       cmp       [rcx],rax
       jne       near ptr M00_L90
       call      qword ptr [7FF82462BF50]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Rent(Int32)
       mov       rdx,rax
M00_L34:
       mov       [rbp-290],rdx
       mov       [rbp-330],r12
       mov       rbx,r12
       mov       [rbp-300],rbx
       mov       rsi,[rbp-338]
       mov       [rbp-2F8],rsi
       mov       rcx,[rbp-328]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       mov       r12,[rbp-330]
       je        short M00_L35
       cmp       dword ptr [rcx+8],0
       je        short M00_L35
       cmp       dword ptr [rcx+8],0
       jbe       near ptr M00_L101
       mov       rax,[rcx+10]
       test      rax,rax
       jne       near ptr M00_L42
M00_L35:
       mov       rcx,[rbx+10]
       mov       eax,[rcx+8]
       test      eax,eax
       je        near ptr M00_L99
       test      eax,eax
       je        near ptr M00_L101
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        near ptr M00_L94
       mov       [rbp-330],r12
       mov       rax,[rcx+8]
       mov       [rbp-310],rax
       xor       ecx,ecx
       mov       [rbp-120],ecx
       lea       rcx,[rbp-120]
       mov       rdx,7FF98C8F22E0
       call      rdx
       movzx     ebx,word ptr [rbp-120]
       shl       ebx,6
       movzx     esi,byte ptr [rbp-11E]
       or        ebx,esi
       mov       eax,0AAAAAAAB
       mov       ecx,ebx
       imul      rax,rcx
       shr       rax,23
       imul      eax,0C
       sub       ebx,eax
       xor       esi,esi
       cmp       dword ptr [7FF883E53B10],0
       jne       near ptr M00_L92
M00_L36:
       mov       rdi,[rbp-310]
       cmp       dword ptr [rdi+8],0
       jle       near ptr M00_L95
M00_L37:
       cmp       ebx,[rdi+8]
       jae       near ptr M00_L101
       mov       ecx,ebx
       mov       r15,[rdi+rcx*8+10]
       cmp       [r15],r15b
       xor       r12d,r12d
       mov       rcx,r15
       call      00007FF883B9DAF0
       test      eax,eax
       jne       short M00_L38
       mov       rcx,r15
       call      qword ptr [7FF82466C990]
M00_L38:
       mov       rcx,[r15+8]
       mov       eax,[r15+10]
       dec       eax
       cmp       [rcx+8],eax
       ja        short M00_L43
M00_L39:
       mov       rcx,r15
       call      00007FF883B9DA10
       test      eax,eax
       jne       near ptr M00_L93
M00_L40:
       test      r12,r12
       jne       short M00_L45
       inc       ebx
       cmp       [rdi+8],ebx
       je        short M00_L44
M00_L41:
       inc       esi
       cmp       [rdi+8],esi
       jg        short M00_L37
       jmp       near ptr M00_L95
M00_L42:
       cmp       dword ptr [rcx+8],0
       jbe       near ptr M00_L101
       xor       edx,edx
       mov       [rcx+10],rdx
       cmp       byte ptr [rsi+9D],0
       jne       near ptr M00_L91
       mov       rbx,rax
       jmp       short M00_L47
M00_L43:
       cmp       eax,[rcx+8]
       jae       near ptr M00_L101
       mov       edx,eax
       mov       r12,[rcx+rdx*8+10]
       cmp       eax,[rcx+8]
       jae       near ptr M00_L101
       mov       edx,eax
       xor       r8d,r8d
       mov       [rcx+rdx*8+10],r8
       mov       [r15+10],eax
       jmp       short M00_L39
M00_L44:
       xor       ebx,ebx
       jmp       short M00_L41
M00_L45:
       mov       rdx,r12
M00_L46:
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M00_L97
       mov       rsi,[rbp-2F8]
       cmp       byte ptr [rsi+9D],0
       jne       near ptr M00_L96
       mov       r12,[rbp-330]
M00_L47:
       mov       [rbp-298],rbx
       xor       ecx,ecx
       mov       [rbp-3C],ecx
       cmp       qword ptr [rbp-280],0
       je        near ptr M00_L52
       mov       rdx,[rbp-280]
       cmp       dword ptr [rdx+8],0C
       jl        near ptr M00_L52
       lea       rcx,[rdx+10]
       mov       [rbp-128],rcx
       mov       edx,0C
       call      qword ptr [7FF82452F048]; System.Security.Cryptography.RandomNumberGeneratorImplementation.GetBytes(Byte*, Int32)
       xor       r9d,r9d
       mov       [rbp-128],r9
       test      r13d,r13d
       jle       short M00_L49
       mov       r15,[rbp-340]
       mov       rcx,r15
       mov       rsi,[rbp-270]
       lea       rdx,[rsi+0C]
       mov       r8d,[rsi+8]
       cmp       qword ptr [rbp-288],0
       je        near ptr M00_L53
       mov       rax,[rbp-288]
       lea       r9,[rax+10]
       mov       r10d,[rax+8]
M00_L48:
       mov       [rbp-130],rdx
       mov       [rbp-138],r9
       mov       [rsp+20],r10d
       mov       dword ptr [rsp+28],1
       call      qword ptr [7FF82466EB08]; System.Text.UTF8Encoding.GetBytesCommon(Char*, Int32, Byte*, Int32, Boolean)
       xor       ecx,ecx
       mov       [rbp-130],rcx
       mov       [rbp-138],rcx
       mov       [rbp-3C],eax
M00_L49:
       mov       rcx,offset MT_System.Security.Cryptography.AesGcm
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,[rbp-278]
       mov       r8d,10
       call      qword ptr [7FF8245FD3B0]; System.Security.Cryptography.AesGcm..ctor(Byte[], Int32)
       mov       [rbp-2A0],rsi
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-148],xmm0
       lea       rcx,[rbp-148]
       mov       rdx,[rbp-280]
       xor       r8d,r8d
       mov       r9d,0C
       call      qword ptr [7FF8245FCAE0]; System.Span`1[[System.Byte, System.Private.CoreLib]]..ctor(Byte[], Int32, Int32)
       mov       rdx,[rbp-148]
       mov       r8d,[rbp-140]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-158],xmm0
       lea       rcx,[rbp-158]
       call      qword ptr [7FF82466EB20]; System.ReadOnlySpan`1[[System.Byte, System.Private.CoreLib]]..ctor(Byte ByRef, Int32)
       mov       r15,[rbp-158]
       mov       r13d,[rbp-150]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-168],xmm0
       lea       rcx,[rbp-168]
       mov       rdx,[rbp-288]
       mov       r9d,[rbp-3C]
       xor       r8d,r8d
       call      qword ptr [7FF8245FCAE0]; System.Span`1[[System.Byte, System.Private.CoreLib]]..ctor(Byte[], Int32, Int32)
       vmovdqu   xmm0,xmmword ptr [rbp-168]
       vmovdqu   xmmword ptr [rbp-238],xmm0
       lea       rdx,[rbp-238]
       lea       rcx,[rbp-50]
       call      qword ptr [7FF8243B7F18]; System.Span`1[[System.Byte, System.Private.CoreLib]].op_Implicit(System.Span`1<Byte>)
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-178],xmm0
       lea       rcx,[rbp-178]
       mov       rdx,[rbp-290]
       mov       r9d,[rbp-3C]
       xor       r8d,r8d
       call      qword ptr [7FF8245FCAE0]; System.Span`1[[System.Byte, System.Private.CoreLib]]..ctor(Byte[], Int32, Int32)
       mov       rax,[rbp-178]
       mov       [rbp-320],rax
       mov       r10d,[rbp-170]
       mov       [rbp-224],r10d
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-188],xmm0
       lea       rcx,[rbp-188]
       mov       rdx,rbx
       xor       r8d,r8d
       mov       r9d,10
       call      qword ptr [7FF8245FCAE0]; System.Span`1[[System.Byte, System.Private.CoreLib]]..ctor(Byte[], Int32, Int32)
       mov       [rbp-248],r15
       mov       [rbp-240],r13d
       mov       r15,[rbp-320]
       mov       [rbp-238],r15
       mov       r15d,[rbp-224]
       mov       [rbp-230],r15d
       vmovdqu   xmm0,xmmword ptr [rbp-188]
       vmovdqu   xmmword ptr [rbp-258],xmm0
       mov       rdi,[rbp-318]
       mov       [rbp-268],rdi
       mov       [rbp-260],r14d
       lea       rdx,[rbp-248]
       lea       r9,[rbp-238]
       lea       r8,[rbp-258]
       mov       [rsp+20],r8
       lea       r8,[rbp-268]
       mov       [rsp+28],r8
       lea       r8,[rbp-50]
       mov       rcx,rsi
       call      qword ptr [7FF8245FD3C8]; System.Security.Cryptography.AesGcm.Encrypt(System.ReadOnlySpan`1<Byte>, System.ReadOnlySpan`1<Byte>, System.Span`1<Byte>, System.Span`1<Byte>, System.ReadOnlySpan`1<Byte>)
       nop
       mov       rcx,[rsi+8]
       cmp       [rcx],ecx
       call      qword ptr [7FF824000298]; System.Runtime.InteropServices.SafeHandle.Dispose()
       mov       esi,[rbp-3C]
       add       esi,0D
       jo        near ptr M00_L54
       mov       r9d,esi
       add       r9d,10
       jo        near ptr M00_L54
       mov       [rbp-54],r9d
       mov       rcx,r12
       mov       edx,[rbp-54]
       call      qword ptr [7FF82462BF50]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Rent(Int32)
       mov       [rbp-2A8],rax
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-198],xmm0
       lea       rcx,[rbp-198]
       mov       rdx,[rbp-2A8]
       mov       r9d,[rbp-54]
       xor       r8d,r8d
       call      qword ptr [7FF8245FCAE0]; System.Span`1[[System.Byte, System.Private.CoreLib]]..ctor(Byte[], Int32, Int32)
       vmovdqu   xmm0,xmmword ptr [rbp-198]
       vmovdqu   xmmword ptr [rbp-68],xmm0
       cmp       dword ptr [rbp-60],0
       jbe       near ptr M00_L50
       mov       rcx,[rbp-68]
       mov       byte ptr [rcx],1
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-1A8],xmm0
       lea       rcx,[rbp-1A8]
       mov       rdx,[rbp-280]
       xor       r8d,r8d
       mov       r9d,0C
       call      qword ptr [7FF8245FCAE0]; System.Span`1[[System.Byte, System.Private.CoreLib]]..ctor(Byte[], Int32, Int32)
       vmovdqu   xmm0,xmmword ptr [rbp-1A8]
       vmovdqu   xmmword ptr [rbp-78],xmm0
       lea       rcx,[rbp-68]
       lea       rdx,[rbp-88]
       mov       r8d,1
       mov       r9d,0C
       call      qword ptr [7FF8243B7F00]; System.Span`1[[System.Byte, System.Private.CoreLib]].Slice(Int32, Int32)
       lea       rcx,[rbp-78]
       lea       rdx,[rbp-88]
       call      qword ptr [7FF8245F7720]; System.Span`1[[System.Byte, System.Private.CoreLib]].CopyTo(System.Span`1<Byte>)
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-1B8],xmm0
       lea       rcx,[rbp-1B8]
       mov       rdx,[rbp-290]
       mov       r9d,[rbp-3C]
       xor       r8d,r8d
       call      qword ptr [7FF8245FCAE0]; System.Span`1[[System.Byte, System.Private.CoreLib]]..ctor(Byte[], Int32, Int32)
       vmovdqu   xmm0,xmmword ptr [rbp-1B8]
       vmovdqu   xmmword ptr [rbp-78],xmm0
       lea       rcx,[rbp-68]
       lea       rdx,[rbp-98]
       mov       r9d,[rbp-3C]
       mov       r8d,0D
       call      qword ptr [7FF8243B7F00]; System.Span`1[[System.Byte, System.Private.CoreLib]].Slice(Int32, Int32)
       lea       rcx,[rbp-78]
       lea       rdx,[rbp-98]
       call      qword ptr [7FF8245F7720]; System.Span`1[[System.Byte, System.Private.CoreLib]].CopyTo(System.Span`1<Byte>)
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-1C8],xmm0
       lea       rcx,[rbp-1C8]
       mov       rdx,rbx
       xor       r8d,r8d
       mov       r9d,10
       call      qword ptr [7FF8245FCAE0]; System.Span`1[[System.Byte, System.Private.CoreLib]]..ctor(Byte[], Int32, Int32)
       vmovdqu   xmm0,xmmword ptr [rbp-1C8]
       vmovdqu   xmmword ptr [rbp-78],xmm0
       mov       r8d,esi
       lea       rdx,[rbp-0A8]
       lea       rcx,[rbp-68]
       mov       r9d,10
       call      qword ptr [7FF8243B7F00]; System.Span`1[[System.Byte, System.Private.CoreLib]].Slice(Int32, Int32)
       lea       rcx,[rbp-78]
       lea       rdx,[rbp-0A8]
       call      qword ptr [7FF8245F7720]; System.Span`1[[System.Byte, System.Private.CoreLib]].CopyTo(System.Span`1<Byte>)
       mov       rcx,[rbp-2A8]
       mov       r8d,[rbp-54]
       xor       edx,edx
       xor       r9d,r9d
       call      qword ptr [7FF8245FD530]; System.Convert.ToBase64String(Byte[], Int32, Int32, System.Base64FormattingOptions)
       mov       [rbp-2B0],rax
       jmp       short M00_L51
M00_L50:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L51:
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-1D8],xmm0
       lea       rcx,[rbp-1D8]
       mov       rdx,[rbp-2A8]
       mov       r9d,[rbp-54]
       xor       r8d,r8d
       call      qword ptr [7FF8245FCAE0]; System.Span`1[[System.Byte, System.Private.CoreLib]]..ctor(Byte[], Int32, Int32)
       vmovdqu   xmm0,xmmword ptr [rbp-1D8]
       vmovdqu   xmmword ptr [rbp-238],xmm0
       lea       rcx,[rbp-238]
       call      qword ptr [7FF8245FCAF8]; System.Security.Cryptography.CryptographicOperations.ZeroMemory(System.Span`1<Byte>)
       mov       rcx,r12
       mov       rdx,[rbp-2A8]
       mov       r8d,1
       call      qword ptr [7FF82462BF58]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Return(Byte[], Boolean)
       jmp       short M00_L55
M00_L52:
       call      qword ptr [7FF824077198]
       int       3
M00_L53:
       xor       r9d,r9d
       xor       r10d,r10d
       jmp       near ptr M00_L48
M00_L54:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L55:
       call      M00_L102
       nop
       mov       rax,[rbp-2B0]
       mov       [rbp-220],rax
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+60]
       lea       r8,[rbp-220]
       mov       rdx,7FF82467A400
       cmp       [rcx],ecx
       call      qword ptr [7FF824665068]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,338
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L56:
       call      qword ptr [7FF8243B4348]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L57
       call      qword ptr [7FF82466DE00]
       mov       rbx,rax
M00_L57:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,16830F0FF88
       call      qword ptr [7FF82466DBC0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L58:
       mov       ecx,eax
       call      qword ptr [7FF82466C348]
       test      eax,eax
       jne       short M00_L60
       jmp       near ptr M00_L03
M00_L59:
       mov       ecx,eax
       call      qword ptr [7FF82466C348]
       test      eax,eax
       je        near ptr M00_L04
M00_L60:
       mov       rcx,rbx
       mov       edx,3
       call      qword ptr [7FF82466C360]
       mov       rbx,rax
       jmp       near ptr M00_L04
M00_L61:
       call      qword ptr [7FF8245F7F60]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L62
       call      qword ptr [7FF82466DE00]
       mov       rbx,rax
M00_L62:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,16830F09C08
       call      qword ptr [7FF82466DBC0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L63:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,11AD
       mov       rdx,7FF824274870
       call      qword ptr [7FF824127798]
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,16830F10560
       call      qword ptr [7FF824326070]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L64:
       mov       ecx,0E
       call      qword ptr [7FF82412C228]
       int       3
M00_L65:
       mov       rcx,r13
       mov       rdx,r12
       call      qword ptr [7FF82466CFF0]
       add       eax,[rbp-0B8]
       mov       r13d,eax
       test      r13d,r13d
       mov       [rbp-0B8],r13d
       jge       near ptr M00_L05
M00_L66:
       call      qword ptr [7FF82452DCE0]
       int       3
M00_L67:
       mov       ecx,9
       call      qword ptr [7FF82466C630]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       r9,rax
       jmp       near ptr M00_L06
M00_L68:
       mov       [rbp-2D0],r11
       mov       rcx,r11
       call      qword ptr [7FF8243BCC30]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rbp-0DC],eax
       mov       rdx,[rbp-2D0]
       mov       r8d,[rdx+8]
       mov       [rbp-0E0],r8d
       mov       rcx,[rbp-2C8]
       call      qword ptr [7FF8243BCC30]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       xor       edx,edx
       mov       [rsp+20],edx
       mov       edx,[rbp-0DC]
       mov       r8d,[rbp-0E0]
       mov       rcx,[rbp-2C0]
       call      qword ptr [7FF82466D878]
       mov       rbx,[rbp-2D0]
       jmp       near ptr M00_L19
M00_L69:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L08
M00_L70:
       mov       ecx,eax
       mov       rdx,r15
       call      qword ptr [7FF82466C780]
       jmp       near ptr M00_L12
M00_L71:
       xor       edx,edx
       jmp       near ptr M00_L18
M00_L72:
       mov       rcx,rbx
       call      qword ptr [7FF8243BCC30]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       edi,eax
       mov       r15d,[rbx+8]
       mov       rcx,[rbp-2C8]
       call      qword ptr [7FF8243BCC30]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       xor       edx,edx
       mov       [rsp+20],edx
       mov       edx,edi
       mov       r8d,r15d
       mov       rcx,rsi
       call      qword ptr [7FF82466D878]
       jmp       near ptr M00_L19
M00_L73:
       mov       dword ptr [rbp-0CC],10
       jmp       short M00_L75
M00_L74:
       mov       ecx,0C
       mov       rdx,16830F06F28
       call      qword ptr [7FF82412D8A8]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
M00_L75:
       mov       ebx,[rbp-0CC]
       cmp       ebx,800
       jge       short M00_L76
       mov       edx,ebx
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbx,rax
       jmp       short M00_L77
M00_L76:
       mov       ecx,ebx
       xor       edx,edx
       call      qword ptr [7FF82466D860]
       mov       rbx,rax
M00_L77:
       mov       rsi,[rbp-2C0]
       cmp       byte ptr [rsi+9D],0
       je        near ptr M00_L19
       cmp       [rbx],bl
       mov       rcx,rbx
       call      qword ptr [7FF8243BCC30]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rbp-0D0],eax
       mov       edx,[rbx+8]
       mov       [rbp-0D4],edx
       mov       rcx,[rbp-2C8]
       call      qword ptr [7FF8243BCC30]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       edx,[rbp-0D0]
       mov       r8d,[rbp-0D4]
       mov       rcx,rsi
       call      qword ptr [7FF82466D878]
       mov       eax,[rbx+8]
       mov       [rbp-0D8],eax
       mov       rcx,[rbp-2C8]
       call      qword ptr [7FF8243BCC30]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       rcx,[rbp-2C8]
       mov       rcx,[rcx+10]
       mov       edx,1
       mov       r8d,2
       cmp       dword ptr [rcx+8],0
       cmovg     edx,r8d
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       [rsp+28],edx
       mov       rcx,rsi
       mov       edx,[rbp-0D0]
       mov       r8d,[rbp-0D8]
       call      qword ptr [7FF82466D890]
       jmp       near ptr M00_L19
M00_L78:
       mov       [rbp-2E8],r11
       mov       rcx,r11
       call      qword ptr [7FF8243BCC30]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       esi,eax
       mov       rdx,[rbp-2E8]
       mov       eax,[rdx+8]
       mov       [rbp-0FC],eax
       mov       rcx,rbx
       call      qword ptr [7FF8243BCC30]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       ebx,[rbp-0EC]
       mov       [rsp+20],ebx
       mov       edx,esi
       mov       r8d,[rbp-0FC]
       mov       rcx,[rbp-2E0]
       call      qword ptr [7FF82466D878]
       mov       rbx,[rbp-2E8]
       jmp       near ptr M00_L32
M00_L79:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L21
M00_L80:
       mov       ecx,eax
       mov       rdx,r15
       call      qword ptr [7FF82466C780]
       jmp       near ptr M00_L25
M00_L81:
       xor       edx,edx
       jmp       near ptr M00_L31
M00_L82:
       mov       rcx,rbx
       call      qword ptr [7FF8243BCC30]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       edi,eax
       mov       r15d,[rbx+8]
       mov       rcx,[rbp-2B8]
       call      qword ptr [7FF8243BCC30]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       r12d,[rbp-0EC]
       mov       [rsp+20],r12d
       mov       edx,edi
       mov       r8d,r15d
       mov       rcx,rsi
       call      qword ptr [7FF82466D878]
       jmp       near ptr M00_L32
M00_L83:
       mov       ecx,10
       mov       r12d,[rbp-0EC]
       shlx      ecx,ecx,r12d
       mov       ebx,ecx
       jmp       short M00_L86
M00_L84:
       test      esi,esi
       jne       short M00_L85
       mov       rcx,16830F062A0
       mov       rdx,rcx
       jmp       near ptr M00_L33
M00_L85:
       mov       ecx,esi
       mov       rdx,16830F06F28
       call      qword ptr [7FF82412D8A8]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
       mov       ebx,esi
M00_L86:
       cmp       ebx,800
       jge       short M00_L87
       movsxd    rdx,ebx
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbx,rax
       jmp       short M00_L88
M00_L87:
       mov       ecx,ebx
       xor       edx,edx
       call      qword ptr [7FF82466D860]
       mov       rbx,rax
M00_L88:
       mov       rsi,[rbp-2E0]
       cmp       byte ptr [rsi+9D],0
       je        near ptr M00_L32
       cmp       [rbx],bl
       mov       rcx,rbx
       call      qword ptr [7FF8243BCC30]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rbp-0F0],eax
       mov       edx,[rbx+8]
       mov       [rbp-0F4],edx
       mov       rcx,[rbp-2B8]
       call      qword ptr [7FF8243BCC30]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       edx,[rbp-0F0]
       mov       r8d,[rbp-0F4]
       mov       rcx,rsi
       call      qword ptr [7FF82466D878]
       mov       eax,[rbx+8]
       mov       [rbp-0F8],eax
       mov       rcx,[rbp-2B8]
       call      qword ptr [7FF8243BCC30]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       rcx,[rbp-2B8]
       mov       rcx,[rcx+10]
       mov       edx,1
       mov       r8d,2
       mov       r12d,[rbp-0EC]
       cmp       [rcx+8],r12d
       cmovg     edx,r8d
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       [rsp+28],edx
       mov       rcx,rsi
       mov       edx,[rbp-0F0]
       mov       r8d,[rbp-0F8]
       call      qword ptr [7FF82466D890]
       jmp       near ptr M00_L32
M00_L89:
       mov       rcx,rbx
       mov       edx,esi
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rdx,rax
       jmp       near ptr M00_L33
M00_L90:
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rdx,rax
       jmp       near ptr M00_L34
M00_L91:
       mov       [rbp-308],rax
       mov       rcx,rax
       call      qword ptr [7FF8243BCC30]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rbp-110],eax
       mov       rdx,[rbp-308]
       mov       r8d,[rdx+8]
       mov       [rbp-114],r8d
       mov       rcx,rbx
       call      qword ptr [7FF8243BCC30]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       xor       edx,edx
       mov       [rsp+20],edx
       mov       edx,[rbp-110]
       mov       r8d,[rbp-114]
       mov       rcx,rsi
       call      qword ptr [7FF82466D878]
       mov       rbx,[rbp-308]
       jmp       near ptr M00_L47
M00_L92:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L36
M00_L93:
       mov       ecx,eax
       mov       rdx,r15
       call      qword ptr [7FF82466C780]
       jmp       near ptr M00_L40
M00_L94:
       mov       rbx,[rbp-300]
       jmp       short M00_L98
M00_L95:
       xor       edx,edx
       jmp       near ptr M00_L46
M00_L96:
       mov       rcx,rbx
       call      qword ptr [7FF8243BCC30]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       edi,eax
       mov       r15d,[rbx+8]
       mov       rcx,[rbp-300]
       call      qword ptr [7FF8243BCC30]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       xor       edx,edx
       mov       [rsp+20],edx
       mov       edx,edi
       mov       r8d,r15d
       mov       rcx,rsi
       call      qword ptr [7FF82466D878]
       mov       r12,[rbp-330]
       jmp       near ptr M00_L47
M00_L97:
       mov       rbx,[rbp-300]
       mov       r12,[rbp-330]
M00_L98:
       mov       edx,10
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rsi,[rbp-2F8]
       cmp       byte ptr [rsi+9D],0
       jne       short M00_L100
       mov       rbx,rax
       jmp       near ptr M00_L47
M00_L99:
       mov       rbx,[rbp-300]
       mov       ecx,10
       mov       rdx,16830F06F28
       call      qword ptr [7FF82412D8A8]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
       jmp       short M00_L98
M00_L100:
       mov       [rbp-308],rax
       mov       rcx,rax
       call      qword ptr [7FF8243BCC30]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rbp-10C],eax
       mov       rcx,rbx
       call      qword ptr [7FF8243BCC30]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       edx,[rbp-10C]
       mov       r8d,10
       mov       rcx,rsi
       call      qword ptr [7FF82466D878]
       mov       rcx,rbx
       call      qword ptr [7FF8243BCC30]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       rcx,[rbx+10]
       mov       edx,1
       mov       r8d,2
       cmp       dword ptr [rcx+8],0
       cmovg     edx,r8d
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       [rsp+28],edx
       mov       rcx,rsi
       mov       edx,[rbp-10C]
       mov       r8d,10
       call      qword ptr [7FF82466D890]
       mov       rbx,[rbp-308]
       jmp       near ptr M00_L47
M00_L101:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       sub       rsp,38
       vzeroupper
       mov       rcx,[rbp-2A0]
       mov       rcx,[rcx+8]
       cmp       [rcx],ecx
       call      qword ptr [7FF824000298]; System.Runtime.InteropServices.SafeHandle.Dispose()
       nop
       add       rsp,38
       ret
       sub       rsp,38
       vzeroupper
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-1D8],xmm0
       lea       rcx,[rbp-1D8]
       mov       rdx,[rbp-2A8]
       mov       r9d,[rbp-54]
       xor       r8d,r8d
       call      qword ptr [7FF8245FCAE0]; System.Span`1[[System.Byte, System.Private.CoreLib]]..ctor(Byte[], Int32, Int32)
       vmovdqu   xmm0,xmmword ptr [rbp-1D8]
       vmovdqu   xmmword ptr [rbp-238],xmm0
       lea       rcx,[rbp-238]
       call      qword ptr [7FF8245FCAF8]; System.Security.Cryptography.CryptographicOperations.ZeroMemory(System.Span`1<Byte>)
       mov       rcx,1279C001E00
       mov       r12,[rcx]
       mov       rcx,r12
       mov       rdx,[rbp-2A8]
       mov       r8d,1
       call      qword ptr [7FF82462BF58]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Return(Byte[], Boolean)
       nop
       add       rsp,38
       ret
M00_L102:
       sub       rsp,38
       vzeroupper
       cmp       dword ptr [rbp-3C],0
       jle       near ptr M00_L103
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-1E8],xmm0
       lea       rcx,[rbp-1E8]
       mov       rdx,[rbp-288]
       mov       r9d,[rbp-3C]
       xor       r8d,r8d
       call      qword ptr [7FF8245FCAE0]; System.Span`1[[System.Byte, System.Private.CoreLib]]..ctor(Byte[], Int32, Int32)
       vmovdqu   xmm0,xmmword ptr [rbp-1E8]
       vmovdqu   xmmword ptr [rbp-238],xmm0
       lea       rcx,[rbp-238]
       call      qword ptr [7FF8245FCAF8]; System.Security.Cryptography.CryptographicOperations.ZeroMemory(System.Span`1<Byte>)
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-1F8],xmm0
       lea       rcx,[rbp-1F8]
       mov       rdx,[rbp-290]
       mov       r9d,[rbp-3C]
       xor       r8d,r8d
       call      qword ptr [7FF8245FCAE0]; System.Span`1[[System.Byte, System.Private.CoreLib]]..ctor(Byte[], Int32, Int32)
       vmovdqu   xmm0,xmmword ptr [rbp-1F8]
       vmovdqu   xmmword ptr [rbp-238],xmm0
       lea       rcx,[rbp-238]
       call      qword ptr [7FF8245FCAF8]; System.Security.Cryptography.CryptographicOperations.ZeroMemory(System.Span`1<Byte>)
M00_L103:
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-208],xmm0
       lea       rcx,[rbp-208]
       mov       rdx,[rbp-298]
       xor       r8d,r8d
       mov       r9d,10
       call      qword ptr [7FF8245FCAE0]; System.Span`1[[System.Byte, System.Private.CoreLib]]..ctor(Byte[], Int32, Int32)
       vmovdqu   xmm0,xmmword ptr [rbp-208]
       vmovdqu   xmmword ptr [rbp-238],xmm0
       lea       rcx,[rbp-238]
       call      qword ptr [7FF8245FCAF8]; System.Security.Cryptography.CryptographicOperations.ZeroMemory(System.Span`1<Byte>)
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-218],xmm0
       lea       rcx,[rbp-218]
       mov       rdx,[rbp-280]
       xor       r8d,r8d
       mov       r9d,0C
       call      qword ptr [7FF8245FCAE0]; System.Span`1[[System.Byte, System.Private.CoreLib]]..ctor(Byte[], Int32, Int32)
       vmovdqu   xmm0,xmmword ptr [rbp-218]
       vmovdqu   xmmword ptr [rbp-238],xmm0
       lea       rcx,[rbp-238]
       call      qword ptr [7FF8245FCAF8]; System.Security.Cryptography.CryptographicOperations.ZeroMemory(System.Span`1<Byte>)
       mov       rcx,1279C001E00
       mov       r12,[rcx]
       mov       rcx,r12
       mov       rdx,[rbp-288]
       mov       r8d,1
       call      qword ptr [7FF82462BF58]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Return(Byte[], Boolean)
       mov       rcx,r12
       mov       rdx,[rbp-290]
       mov       r8d,1
       call      qword ptr [7FF82462BF58]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Return(Byte[], Boolean)
       mov       rcx,r12
       mov       rdx,[rbp-298]
       mov       r8d,1
       call      qword ptr [7FF82462BF58]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Return(Byte[], Boolean)
       mov       rcx,r12
       mov       rdx,[rbp-280]
       mov       r8d,1
       call      qword ptr [7FF82462BF58]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Return(Byte[], Boolean)
       nop
       add       rsp,38
       ret
; Total bytes of code 5570
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
       vbroadcastss xmm0,dword ptr [7FF8246F8588]
       vbroadcastss xmm1,dword ptr [7FF8246F858C]
       vbroadcastss xmm2,dword ptr [7FF8246F8590]
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
       vbroadcastss xmm0,dword ptr [7FF8246F8594]
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
       vbroadcastss ymm0,dword ptr [7FF8246F8594]
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
       mov       rcx,1279C000C90
       mov       rdi,[rcx]
       mov       [rsp+40],rdi
       lea       ecx,[rbx-1]
       or        ecx,0F
       xor       ebp,ebp
       lzcnt     ebp,ecx
       xor       ebp,1F
       add       ebp,0FFFFFFFD
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
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
       mov       rax,7FF98C8F22E0
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
       cmp       dword ptr [7FF883E53B10],0
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
       call      00007FF883B9DAF0
       test      eax,eax
       jne       short M02_L04
       mov       rcx,r15
       call      qword ptr [7FF82466C990]
M02_L04:
       mov       rcx,[r15+8]
       mov       eax,[r15+10]
       dec       eax
       cmp       [rcx+8],eax
       ja        short M02_L09
M02_L05:
       mov       rcx,r15
       call      00007FF883B9DA10
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
       call      qword ptr [7FF82466C630]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M02_L00
M02_L15:
       mov       rcx,r14
       call      qword ptr [7FF8243BCC30]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       ebx,eax
       mov       r15d,[r14+8]
       cmp       [rsi],sil
       mov       rcx,rsi
       call      qword ptr [7FF8243BCC30]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       [rsp+20],ebp
       mov       edx,ebx
       mov       r8d,r15d
       mov       rcx,rdi
       call      qword ptr [7FF82466D878]
       jmp       short M02_L13
M02_L16:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M02_L02
M02_L17:
       mov       ecx,eax
       mov       rdx,r15
       call      qword ptr [7FF82466C780]
       jmp       near ptr M02_L06
M02_L18:
       xor       r14d,r14d
       jmp       near ptr M02_L12
M02_L19:
       mov       rcx,r14
       call      qword ptr [7FF8243BCC30]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       ebx,eax
       mov       esi,[r14+8]
       mov       rcx,[rsp+90]
       call      qword ptr [7FF8243BCC30]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       [rsp+20],ebp
       mov       edx,ebx
       mov       r8d,esi
       mov       rcx,rdi
       call      qword ptr [7FF82466D878]
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
       mov       rax,16830F062A0
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
       mov       rdx,16830F06F28
       call      qword ptr [7FF82412D8A8]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
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
       call      qword ptr [7FF82466D860]
       mov       r14,rax
M02_L25:
       mov       rdi,[rsp+40]
       cmp       byte ptr [rdi+9D],0
       je        near ptr M02_L13
       cmp       [r14],r14b
       mov       rcx,r14
       call      qword ptr [7FF8243BCC30]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       ebx,eax
       mov       r15d,[r14+8]
       mov       rcx,rsi
       call      qword ptr [7FF8243BCC30]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       edx,ebx
       mov       r8d,r15d
       mov       rcx,rdi
       call      qword ptr [7FF82466D878]
       mov       r15d,[r14+8]
       mov       rcx,rsi
       call      qword ptr [7FF8243BCC30]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
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
       call      qword ptr [7FF82466D890]
       jmp       near ptr M02_L13
M02_L26:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 887
```
```assembly
; System.Security.Cryptography.RandomNumberGeneratorImplementation.GetBytes(Byte*, Int32)
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
       mov       r8,rsp
       mov       [rbp-58],r8
       mov       r8,rbp
       mov       [rbp-48],r8
       mov       r8d,esi
       mov       rdx,rbx
       xor       ecx,ecx
       mov       r9d,2
       mov       rax,7FF8245B14C0
       mov       [rbp-60],rax
       lea       rax,[M03_L00]
       mov       [rbp-50],rax
       lea       rax,[rbp-70]
       mov       [rdi+8],rax
       mov       byte ptr [rdi+4],0
       mov       rax,7FF989F23670
       call      rax
M03_L00:
       mov       byte ptr [rdi+4],1
       cmp       dword ptr [7FF883E53B10],0
       je        short M03_L01
       call      qword ptr [7FF883E41648]; CORINFO_HELP_STOP_FOR_GC
M03_L01:
       mov       rcx,[rbp-68]
       mov       [rdi+8],rcx
       test      eax,eax
       jne       short M03_L02
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
M03_L02:
       mov       ecx,eax
       call      qword ptr [7FF82466D968]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 186
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
       call      qword ptr [7FF823F0FB28]; System.Text.Unicode.Utf8Utility.TranscodeToUtf8(Char*, Int32, Byte*, Int32, Char* ByRef, Byte* ByRef)
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
       call      qword ptr [7FF82466CFD8]
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
; System.Security.Cryptography.AesGcm..ctor(Byte[], Int32)
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+20],rax
       test      rdx,rdx
       je        short M05_L00
       lea       rax,[rdx+10]
       mov       edx,[rdx+8]
       mov       [rsp+20],rax
       mov       [rsp+28],edx
       lea       rdx,[rsp+20]
       call      qword ptr [7FF8245FD410]; System.Security.Cryptography.AesGcm..ctor(System.ReadOnlySpan`1<Byte>, Int32)
       nop
       add       rsp,30
       pop       rbx
       ret
M05_L00:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,4BF3
       mov       rdx,7FF8243CE308
       call      qword ptr [7FF824127798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF824325878]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 111
```
```assembly
; System.Span`1[[System.Byte, System.Private.CoreLib]]..ctor(Byte[], Int32, Int32)
       sub       rsp,28
       test      rdx,rdx
       je        short M06_L01
       mov       r8d,r8d
       mov       eax,r9d
       add       rax,r8
       mov       r10d,[rdx+8]
       cmp       rax,r10
       ja        short M06_L02
       add       rdx,10
       add       rdx,r8
       mov       [rcx],rdx
       mov       [rcx+8],r9d
M06_L00:
       add       rsp,28
       ret
M06_L01:
       or        r8d,r9d
       jne       short M06_L02
       xor       eax,eax
       mov       [rcx],rax
       mov       [rcx+8],rax
       jmp       short M06_L00
M06_L02:
       call      qword ptr [7FF824077198]
       int       3
; Total bytes of code 69
```
```assembly
; System.ReadOnlySpan`1[[System.Byte, System.Private.CoreLib]]..ctor(Byte ByRef, Int32)
       mov       [rcx],rdx
       mov       [rcx+8],r8d
       ret
; Total bytes of code 8
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
       jne       near ptr M09_L09
       mov       rax,1279C001ED8
       mov       r10,[rax]
       mov       r9d,[r10+10]
       test      r9d,r9d
       je        near ptr M09_L10
       mov       r11d,[r10+8]
       cmp       r8d,r11d
       jl        near ptr M09_L11
       cmp       r8d,[r10+0C]
       jg        near ptr M09_L11
       mov       edx,r8d
       sub       edx,r11d
       mov       eax,edx
       cdq
       idiv      r9d
       test      edx,edx
       jne       near ptr M09_L11
M09_L00:
       movzx     edx,byte ptr [r14+10]
       mov       eax,[r14+14]
       mov       [rbp-10C],eax
       test      edx,edx
       jne       short M09_L01
       mov       rdx,1279C001EE0
       mov       rdx,[rdx]
       lea       r8,[rbp-40]
       call      qword ptr [7FF8245FC168]; System.Security.Cryptography.KeySizeHelpers.IsLegalSize(Int32, System.Security.Cryptography.KeySizes, Boolean ByRef)
       test      eax,eax
       jne       short M09_L02
       jmp       near ptr M09_L13
M09_L01:
       cmp       ecx,eax
       jne       near ptr M09_L12
M09_L02:
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
       jne       near ptr M09_L07
M09_L03:
       lea       r9,[rcx+10]
       lea       edx,[rax+4]
       mov       [rbp-0D0],eax
       lock cmpxchg [r9],edx
       cmp       eax,[rbp-0D0]
       jne       near ptr M09_L06
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
       mov       rax,7FF8245B1B10
       mov       [rbp-0F8],rax
       lea       rax,[M09_L04]
       mov       [rbp-0E8],rax
       lea       rax,[rbp-108]
       mov       [r12+8],rax
       mov       byte ptr [r12+4],0
       mov       rax,7FF989F215B0
       call      rax
M09_L04:
       mov       byte ptr [r12+4],1
       cmp       dword ptr [7FF883E53B10],0
       je        short M09_L05
       call      qword ptr [7FF883E41648]; CORINFO_HELP_STOP_FOR_GC
M09_L05:
       mov       rcx,[rbp-100]
       mov       [r12+8],rcx
       mov       [rbp-0CC],eax
       jmp       short M09_L08
M09_L06:
       mov       eax,[rcx+10]
       test      al,1
       je        near ptr M09_L03
M09_L07:
       call      qword ptr [7FF82466C9A8]
       int       3
M09_L08:
       call      M09_L15
       nop
       cmp       dword ptr [rbp-0CC],0
       jne       near ptr M09_L14
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
M09_L09:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF82466DA88]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF824324180]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M09_L10:
       mov       r11d,[r10+8]
       cmp       r11d,r8d
       je        near ptr M09_L00
M09_L11:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF82466DAA0]
       mov       rsi,rax
       mov       ecx,4BFB
       mov       rdx,7FF8243CE308
       call      qword ptr [7FF824127798]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF824326070]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M09_L12:
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF82466DAB8]
       mov       rsi,rax
       mov       edi,[rbp-10C]
       mov       [rbx+8],edi
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF82466DAD0]
       mov       rbx,rax
       mov       ecx,4C31
       mov       rdx,7FF8243CE308
       call      qword ptr [7FF824127798]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FF824326070]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M09_L13:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      qword ptr [7FF82466D980]
       mov       rbx,rax
       mov       ecx,4C31
       mov       rdx,7FF8243CE308
       call      qword ptr [7FF824127798]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,r14
       call      qword ptr [7FF824326070]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
       int       3
M09_L14:
       mov       ecx,[rbp-0CC]
       call      qword ptr [7FF82466D968]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M09_L15:
       sub       rsp,58
       vzeroupper
       cmp       byte ptr [rbp-110],0
       je        near ptr M09_L29
       mov       rbx,[rbp-118]
       mov       rcx,[rbp-118]
       cmp       [rcx],cl
       mov       esi,[rbx+10]
       test      esi,0FFFFFFFC
       je        short M09_L24
M09_L16:
       mov       ecx,esi
       and       ecx,0FFFFFFFD
       cmp       ecx,4
       jne       short M09_L21
       jmp       short M09_L18
M09_L17:
       mov       esi,[rbx+10]
       test      esi,0FFFFFFFC
       jne       short M09_L16
       jmp       short M09_L24
M09_L18:
       cmp       byte ptr [rbx+14],0
       je        short M09_L21
       mov       rcx,offset MT_Internal.NativeCrypto.SafeKeyHandle
       cmp       [rbx],rcx
       jne       short M09_L19
       cmp       qword ptr [rbx+8],0
       sete      dil
       movzx     edi,dil
       jmp       short M09_L20
M09_L19:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       edi,eax
M09_L20:
       test      edi,edi
       sete      cl
       movzx     ecx,cl
       jmp       short M09_L22
M09_L21:
       xor       ecx,ecx
M09_L22:
       lea       edx,[rsi-4]
       mov       eax,esi
       and       eax,0FFFFFFFC
       cmp       eax,4
       jne       short M09_L23
       or        edx,1
M09_L23:
       lea       r8,[rbx+10]
       mov       eax,esi
       lock cmpxchg [r8],edx
       cmp       eax,esi
       jne       short M09_L17
       jmp       short M09_L25
M09_L24:
       mov       rcx,rbx
       call      qword ptr [7FF82466C9A8]
       int       3
M09_L25:
       test      ecx,ecx
       je        short M09_L29
       call      00007FF883B91AE0
       mov       esi,eax
       mov       rcx,offset MT_Internal.NativeCrypto.SafeKeyHandle
       cmp       [rbx],rcx
       jne       short M09_L27
       cmp       qword ptr [rbx+18],0
       je        short M09_L26
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF8245FD308]; System.Runtime.InteropServices.SafeHandle.DangerousRelease()
       xor       ecx,ecx
       mov       [rbx+18],rcx
M09_L26:
       mov       rcx,[rbx+8]
       call      00007FF823EF93E0
       jmp       short M09_L28
M09_L27:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
M09_L28:
       mov       ecx,esi
       call      00007FF883B91B00
M09_L29:
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
       jne       short M10_L01
       mov       rcx,rbx
       mov       edx,1
       call      qword ptr [7FF823F0C768]; System.Runtime.InteropServices.SafeHandle.InternalRelease(Boolean)
M10_L00:
       mov       rcx,rbx
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FF823F07AE0]; System.GC.SuppressFinalize(System.Object)
M10_L01:
       mov       rcx,rbx
       mov       edx,1
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       jmp       short M10_L00
; Total bytes of code 71
```
```assembly
; System.Span`1[[System.Byte, System.Private.CoreLib]].Slice(Int32, Int32)
       sub       rsp,28
       mov       eax,r8d
       mov       r8d,r9d
       add       r8,rax
       mov       r10d,[rcx+8]
       cmp       r8,r10
       ja        short M11_L00
       add       rax,[rcx]
       mov       [rdx],rax
       mov       [rdx+8],r9d
       mov       rax,rdx
       add       rsp,28
       ret
M11_L00:
       call      qword ptr [7FF824077198]
       int       3
; Total bytes of code 47
```
```assembly
; System.Span`1[[System.Byte, System.Private.CoreLib]].CopyTo(System.Span`1<Byte>)
       sub       rsp,28
       mov       rax,rdx
       mov       r8d,[rcx+8]
       cmp       r8d,[rax+8]
       ja        short M12_L00
       mov       rdx,[rcx]
       mov       rcx,[rax]
       call      qword ptr [7FF823F05818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       nop
       add       rsp,28
       ret
M12_L00:
       call      qword ptr [7FF8243BC588]
       int       3
; Total bytes of code 42
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
       je        near ptr M13_L19
       test      ebx,ebx
       jl        near ptr M13_L20
       test      esi,esi
       jl        near ptr M13_L21
       mov       ebp,[rcx+8]
       sub       ebp,ebx
       cmp       esi,ebp
       jl        short M13_L00
       cmp       esi,ebp
       jg        near ptr M13_L22
M13_L00:
       mov       eax,esi
       mov       edx,ebx
       add       rax,rdx
       mov       edx,[rcx+8]
       cmp       rax,rdx
       ja        near ptr M13_L23
       mov       eax,esi
       lea       rsi,[rcx+rax+10]
       cmp       edi,1
       ja        near ptr M13_L24
       test      ebx,ebx
       je        near ptr M13_L25
       cmp       edi,1
       sete      dil
       movzx     edi,dil
       lea       ecx,[rbx+2]
       mov       eax,0AAAAAAAB
       mov       edx,ecx
       imul      rax,rdx
       shr       rax,21
       shl       eax,2
       je        near ptr M13_L26
       test      edi,edi
       jne       near ptr M13_L27
M13_L01:
       test      eax,eax
       jl        near ptr M13_L28
M13_L02:
       movsxd    rdx,eax
       mov       rcx,offset MT_System.String
       call      00007FF883B94CB0
       mov       rbp,rax
       test      edi,edi
       jne       near ptr M13_L31
       cmp       ebx,10
       jl        near ptr M13_L31
       lea       rcx,[rbp+0C]
       mov       edx,[rbp+8]
       mov       edx,[rbp+8]
       imul      r9d,edx,2
       jo        near ptr M13_L34
       mov       [rsp+38],rsi
       mov       [rsp+30],rcx
       mov       r8,rcx
       cmp       ebx,5FFFFFFD
       jg        near ptr M13_L29
       lea       eax,[rbx+2]
       mov       r10d,0AAAAAAAB
       imul      rax,r10
       shr       rax,21
       shl       eax,2
       cmp       eax,r9d
       jg        near ptr M13_L29
       mov       eax,ebx
M13_L03:
       mov       r9,rsi
       mov       r10,r8
       mov       r11d,ebx
       add       r11,r9
       mov       edi,eax
       add       rdi,r9
       cmp       eax,10
       jl        near ptr M13_L08
       lea       rax,[rdi-20]
       cmp       rax,r9
       jb        near ptr M13_L06
       vmovups   ymm0,[7FF824703360]
       vpermd    ymm0,ymm0,[rsi]
       add       rsi,0FFFFFFFFFFFFFFFC
M13_L04:
       vpshufb   ymm0,ymm0,[7FF824703380]
       vpand     ymm1,ymm0,[7FF8247033A0]
       vpmulhuw  ymm1,ymm1,[7FF8247033C0]
       vpand     ymm0,ymm0,[7FF8247033E0]
       vpmullw   ymm0,ymm0,[7FF824703400]
       vpor      ymm0,ymm0,ymm1
       vpsubusb  ymm1,ymm0,[7FF824703420]
       vpcmpgtb  ymm2,ymm0,[7FF824703440]
       vpsubb    ymm1,ymm1,ymm2
       vbroadcastf128 ymm2,xmmword ptr [7FF824703460]
       vpshufb   ymm1,ymm2,ymm1
       vpaddb    ymm0,ymm1,ymm0
       vmovups   [r8],ymm0
       add       rsi,18
       add       r8,20
       cmp       rsi,rax
       ja        short M13_L05
       vmovups   ymm0,[rsi]
       jmp       short M13_L04
M13_L05:
       lea       r9,[rsi+4]
       mov       r10,r8
       cmp       r9,r11
       je        near ptr M13_L11
M13_L06:
       lea       rax,[rdi-10]
       cmp       rax,r9
       jb        near ptr M13_L08
       vmovups   xmm0,[7FF824703470]
       vmovups   xmm1,[7FF824703460]
       vbroadcastss xmm2,dword ptr [7FF8247033A0]
       vbroadcastss xmm3,dword ptr [7FF8247033E0]
       vbroadcastss xmm4,dword ptr [7FF8247033C0]
       vbroadcastss xmm5,dword ptr [7FF824703400]
       vbroadcastss xmm6,dword ptr [7FF824703420]
       vbroadcastss xmm7,dword ptr [7FF824703440]
M13_L07:
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
       vmovups   [r10],xmm8
       add       r9,0C
       add       r10,10
       cmp       r9,rax
       jbe       short M13_L07
       cmp       r9,r11
       je        near ptr M13_L11
M13_L08:
       mov       r8,7FF882D054E8
       add       rdi,0FFFFFFFFFFFFFFFE
       cmp       r9,rdi
       jae       short M13_L10
M13_L09:
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
       mov       esi,eax
       shr       esi,0C
       and       esi,3F
       movzx     esi,byte ptr [r8+rsi]
       shl       esi,8
       or        ebx,esi
       mov       esi,eax
       shr       esi,6
       and       esi,3F
       movzx     esi,byte ptr [r8+rsi]
       shl       esi,10
       or        ebx,esi
       and       eax,3F
       movzx     eax,byte ptr [r8+rax]
       shl       eax,18
       or        eax,ebx
       mov       [r10],eax
       add       r9,3
       add       r10,4
       cmp       r9,rdi
       jb        short M13_L09
M13_L10:
       lea       rax,[rdi+2]
       cmp       rax,r11
       jne       short M13_L11
       lea       rax,[r9+1]
       cmp       rax,r11
       je        near ptr M13_L30
       lea       rax,[r9+2]
       cmp       rax,r11
       jne       short M13_L11
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
M13_L11:
       xor       r9d,r9d
       mov       [rsp+38],r9
       mov       [rsp+30],r9
       mov       r9d,edx
       lea       r9,[rcx+r9*2]
       mov       edx,edx
       add       rdx,rcx
       lea       r8,[rcx+1F]
       cmp       rdx,r8
       jbe       short M13_L13
       nop
M13_L12:
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
       ja        short M13_L12
M13_L13:
       lea       r8,[rcx+0F]
       cmp       rdx,r8
       jbe       short M13_L15
M13_L14:
       add       rdx,0FFFFFFFFFFFFFFF0
       add       r9,0FFFFFFFFFFFFFFE0
       vmovups   xmm0,[rdx]
       vpmovzxbw xmm1,xmm0
       vpsrldq   xmm0,xmm0,8
       vpmovzxbw xmm0,xmm0
       vmovups   [r9],xmm1
       vmovups   [r9+10],xmm0
       cmp       rdx,r8
       ja        short M13_L14
M13_L15:
       add       rcx,3
       cmp       rdx,rcx
       jbe       short M13_L17
       nop       dword ptr [rax]
M13_L16:
       add       r9,0FFFFFFFFFFFFFFF8
       add       rdx,0FFFFFFFFFFFFFFFC
       vmovd     xmm0,dword ptr [rdx]
       vpmovzxbw xmm0,xmm0
       vmovq     qword ptr [r9],xmm0
       cmp       rdx,rcx
       ja        short M13_L16
M13_L17:
       mov       rax,rbp
M13_L18:
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
M13_L19:
       mov       ecx,1139
       mov       rdx,7FF823E44000
       call      qword ptr [7FF824127798]
       mov       rcx,rax
       call      qword ptr [7FF824667DC8]
       int       3
M13_L20:
       mov       ecx,0B3
       mov       rdx,7FF823E44000
       call      qword ptr [7FF824127798]
       mov       rdx,rax
       mov       ecx,ebx
       call      qword ptr [7FF824667D98]
       int       3
M13_L21:
       mov       ecx,1149
       mov       rdx,7FF823E44000
       call      qword ptr [7FF824127798]
       mov       rdx,rax
       mov       ecx,esi
       call      qword ptr [7FF824667D98]
       int       3
M13_L22:
       mov       ecx,1149
       mov       rdx,7FF823E44000
       call      qword ptr [7FF824127798]
       mov       r8,rax
       mov       edx,ebp
       mov       ecx,esi
       call      qword ptr [7FF82466DB00]
       int       3
M13_L23:
       call      qword ptr [7FF824077198]
       int       3
M13_L24:
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF82466D110]
       mov       rsi,rax
       mov       [rbx+8],edi
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF82466CF90]
       mov       rbx,rax
       mov       ecx,1157
       mov       rdx,7FF823E44000
       call      qword ptr [7FF824127798]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FF824326070]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M13_L25:
       mov       rax,16830F00008
       jmp       near ptr M13_L18
M13_L26:
       xor       eax,eax
       jmp       near ptr M13_L02
M13_L27:
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
       jmp       near ptr M13_L01
M13_L28:
       mov       rcx,offset MT_System.OutOfMemoryException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       call      qword ptr [7FF82466D140]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M13_L29:
       sar       r9d,2
       lea       eax,[r9+r9*2]
       jmp       near ptr M13_L03
M13_L30:
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
       jmp       near ptr M13_L11
M13_L31:
       mov       [rsp+48],rsi
       mov       rdx,rsi
       test      rbp,rbp
       jne       short M13_L32
       xor       ecx,ecx
       jmp       short M13_L33
M13_L32:
       lea       rcx,[rbp+0C]
       mov       [rsp+40],rcx
       mov       rcx,[rsp+40]
M13_L33:
       mov       [rsp+20],edi
       mov       r9d,ebx
       xor       r8d,r8d
       call      qword ptr [7FF82466D128]
       xor       eax,eax
       mov       [rsp+40],rax
       mov       [rsp+48],rax
       jmp       near ptr M13_L17
M13_L34:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 1606
```
```assembly
; System.Security.Cryptography.CryptographicOperations.ZeroMemory(System.Span`1<Byte>)
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       call      qword ptr [7FF880ABAC48]; Precode of System.Span`1[[System.Byte, System.Private.CoreLib]].Clear()
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
       mov       rcx,[rcx+40]
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
       call      qword ptr [7FF823F057E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
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
       mov       rax,7FF98C8F22E0
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
       cmp       dword ptr [7FF883E53B10],0
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
       call      00007FF883B9DAF0
       test      eax,eax
       jne       short M15_L06
       mov       rcx,r14
       call      qword ptr [7FF82466C990]
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
       call      00007FF883B9DA10
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
       mov       rcx,1279C000C90
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
       call      qword ptr [7FF82466C630]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M15_L00
M15_L16:
       mov       rcx,rdi
       call      qword ptr [7FF8245FCB28]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
       mov       r14,rax
       jmp       near ptr M15_L01
M15_L17:
       mov       ecx,2
       call      qword ptr [7FF82412C228]
       int       3
M15_L18:
       shr       rdx,3
       mov       rcx,rax
       call      qword ptr [7FF82466D938]
       jmp       near ptr M15_L02
M15_L19:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       call      qword ptr [7FF82466D908]
       mov       r13,rax
       mov       ecx,29B
       mov       rdx,7FF823E44000
       call      qword ptr [7FF824127798]
       mov       r8,rax
       mov       rdx,r13
       mov       rcx,r15
       call      qword ptr [7FF824326070]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
       int       3
M15_L20:
       mov       [rsp+0A0],rdi
       mov       rcx,rdi
       mov       edx,ebp
       call      qword ptr [7FF8245FCC48]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].CreatePerCorePartitions(Int32)
       jmp       near ptr M15_L03
M15_L21:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M15_L04
M15_L22:
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FF82466C780]
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
       call      qword ptr [7FF8243BCC30]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r14d,eax
       mov       r12d,[rbx+8]
       cmp       [rdi],dil
       mov       rcx,rdi
       call      qword ptr [7FF8243BCC30]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,rsi
       mov       r8d,r14d
       mov       r9d,r12d
       mov       edx,3
       call      qword ptr [7FF82466D800]
       test      r13d,r15d
       jne       near ptr M15_L12
       mov       rcx,rbx
       call      qword ptr [7FF8243BCC30]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r14d,eax
       mov       ebx,[rbx+8]
       mov       rcx,rdi
       call      qword ptr [7FF8243BCC30]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
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
       call      qword ptr [7FF82466D920]
       jmp       near ptr M15_L12
M15_L29:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 967
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
       call      qword ptr [7FF883980CF0]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       ecx,ebx
       and       ecx,0FFFFFF
       mov       edx,ecx
       mov       r8d,ebx
       sar       r8d,18
       jne       short M17_L01
       cmp       [rax],ecx
       jle       short M17_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M17_L03
M17_L00:
       add       rsp,20
       pop       rbx
       ret
M17_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M17_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M17_L00
M17_L02:
       cmp       [rax+4],edx
       jle       short M17_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M17_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M17_L03
       jmp       short M17_L00
M17_L03:
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
       call      qword ptr [7FF883983D90]
       test      eax,eax
       je        short M18_L00
       add       rsp,20
       pop       rbx
       ret
M18_L00:
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
       jl        short M19_L00
       add       rsp,28
       ret
M19_L00:
       call      qword ptr [7FF8839908B8]
       int       3
; Total bytes of code 20
```

## .NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Security.EncryptionHelperBenchmark.GenerateRandomKey()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       call      qword ptr [7FF8245AD470]; DotNetTips.Spargine.Core.Ulid.NewUlid()
       mov       [rsp+28],rax
       mov       rbx,[rbx+60]
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
; 		Span<byte> timestampBytes = stackalloc byte[6];
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		Span<byte> randomBytes = stackalloc byte[10];
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var timestamp = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			timestampBytes[0] = (byte)(timestamp >> 40);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			timestampBytes[1] = (byte)(timestamp >> 32);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			timestampBytes[2] = (byte)(timestamp >> 24);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			timestampBytes[3] = (byte)(timestamp >> 16);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			timestampBytes[4] = (byte)(timestamp >> 8);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			timestampBytes[5] = (byte)timestamp;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		EncodeBase32(timestampBytes, ulidChars, 0, TimestampLength);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       mov       rax,608B5E97E8FD
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
       call      qword ptr [7FF82450DCB0]; System.DateTimeOffset.get_UtcNow()
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
       jl        near ptr M01_L10
       sub       edx,8
       jo        near ptr M01_L12
       add       ecx,1
       jo        near ptr M01_L12
       jmp       near ptr M01_L10
M01_L01:
       mov       [rbp+10],rdi
       mov       rcx,rdi
       mov       edx,0A
       call      qword ptr [7FF824507348]; System.Security.Cryptography.RandomNumberGeneratorImplementation.GetBytes(Byte*, Int32)
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
       jl        near ptr M01_L07
       sub       eax,8
       jo        near ptr M01_L12
       add       ecx,1
       jo        near ptr M01_L12
       jmp       near ptr M01_L07
M01_L03:
       mov       [rbp],rbx
       mov       dword ptr [rbp+8],1A
       lea       rcx,[rbp]
       call      System.String.Ctor(System.ReadOnlySpan`1<Char>)
       mov       rdx,rax
       lea       rcx,[rbp+18]
       call      qword ptr [7FF8245AD4D0]; DotNetTips.Spargine.Core.Ulid..ctor(System.String)
       mov       rax,[rbp+18]
       mov       r8,608B5E97E8FD
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
       sub       r10d,eax
       jo        near ptr M01_L12
       sub       r10d,5
       jo        near ptr M01_L12
       sarx      r8d,r8d,r10d
       and       r8d,1F
       add       eax,5
       jo        near ptr M01_L12
       and       eax,7
M01_L07:
       mov       r10d,edx
       add       r10d,0A
       jo        near ptr M01_L12
       cmp       r10d,1A
       jae       near ptr M01_L11
       mov       r8d,r8d
       movzx     r8d,word ptr [r14+r8*2+10]
       mov       [rbx+r10*2],r8w
       add       edx,1
       jo        near ptr M01_L12
       cmp       edx,10
       jge       near ptr M01_L03
       cmp       eax,3
       jle       near ptr M01_L02
       cmp       ecx,0A
       jae       near ptr M01_L11
       mov       r8d,ecx
       movzx     r8d,byte ptr [rdi+r8]
       add       ecx,1
       jo        near ptr M01_L12
       cmp       ecx,0A
       jge       near ptr M01_L05
       mov       r10d,ecx
       cmp       r10d,0A
       jae       near ptr M01_L11
       movzx     r10d,byte ptr [rdi+r10]
       jmp       near ptr M01_L06
M01_L08:
       xor       r10d,r10d
M01_L09:
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
       jo        short M01_L12
       and       edx,7
M01_L10:
       cmp       eax,1A
       jae       short M01_L11
       mov       r10d,eax
       mov       r9,1AE25C001C8
       mov       r14,[r9]
       mov       r8d,r8d
       movzx     r8d,word ptr [r14+r8*2+10]
       mov       [rbx+r10*2],r8w
       add       eax,1
       jo        short M01_L12
       cmp       eax,0A
       jge       near ptr M01_L01
       cmp       edx,3
       jle       near ptr M01_L00
       cmp       ecx,6
       jae       short M01_L11
       mov       r8d,ecx
       movzx     r8d,byte ptr [rsi+r8]
       add       ecx,1
       jo        short M01_L12
       cmp       ecx,6
       jge       near ptr M01_L08
       mov       r10d,ecx
       cmp       r10d,6
       jae       short M01_L11
       movzx     r10d,byte ptr [rsi+r10]
       jmp       near ptr M01_L09
M01_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M01_L12:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 798
```

