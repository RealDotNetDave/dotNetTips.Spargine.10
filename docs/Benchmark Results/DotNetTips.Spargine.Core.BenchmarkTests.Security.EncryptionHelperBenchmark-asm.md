## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
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
       sub       rsp,368
       vzeroupper
       lea       rbp,[rsp+3A0]
       xor       eax,eax
       mov       [rbp-2D8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-2D0],xmm4
       vmovdqa   xmmword ptr [rbp-2C0],xmm4
       mov       rax,0FFFFFFFFFFFFFD90
M00_L00:
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       vmovdqa   xmmword ptr [rbp+rax-20],xmm4
       add       rax,30
       jne       short M00_L00
       mov       [rbp+10],rcx
       mov       rbx,[rcx+38]
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
       mov       [rbp-340],rdi
       mov       [rbp-2A0],rsi
       test      rbx,rbx
       je        near ptr M00_L59
       mov       eax,[rbx+8]
       cmp       dword ptr [rbx+8],0
       je        near ptr M00_L59
       movzx     eax,word ptr [rbx+0C]
       cmp       eax,100
       jge       near ptr M00_L61
       mov       rdx,7FFE3E8F6920
       test      byte ptr [rdx+rax],80
       jne       near ptr M00_L63
M00_L03:
       mov       eax,[rbx+8]
       dec       eax
       cmp       eax,[rbx+8]
       jae       near ptr M00_L112
       movzx     eax,word ptr [rbx+rax*2+0C]
       cmp       eax,100
       jge       near ptr M00_L62
       mov       rdx,7FFE3E8F6920
       test      byte ptr [rdx+rax],80
       jne       near ptr M00_L63
M00_L04:
       mov       [rbp-298],rbx
       test      rsi,rsi
       je        near ptr M00_L64
       mov       rcx,rsi
       call      qword ptr [7FFDF4D35B90]; DotNetTips.Spargine.Core.Extensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setg      r8b
       movzx     r8d,r8b
M00_L05:
       test      r8d,r8d
       je        near ptr M00_L65
       cmp       dword ptr [rsi+8],20
       jne       near ptr M00_L67
       mov       rsi,[rbp-2A0]
       mov       r8,1B22A000220
       mov       r15,[r8]
       mov       [rbp-360],r15
       mov       r13,r15
       test      rbx,rbx
       je        near ptr M00_L68
       lea       r8,[rbx+0C]
       mov       [rbp-0C0],r8
       mov       r12,[rbp-0C0]
       mov       eax,[rbx+8]
       mov       [rbp-0C4],eax
       lea       r8,[rbp-0D0]
       lea       r9,[rbp-0D8]
       mov       rcx,r12
       mov       edx,eax
       call      qword ptr [7FFDF461FAC8]; System.Text.Unicode.Utf16Utility.GetPointerToFirstInvalidChar(Char*, Int32, Int64 ByRef, Int32 ByRef)
       sub       rax,r12
       mov       r9,rax
       shr       r9,3F
       add       r9,rax
       sar       r9,1
       movsxd    rax,r9d
       add       rax,[rbp-0D0]
       cmp       rax,7FFFFFFF
       ja        near ptr M00_L70
       mov       [rbp-0C8],eax
       mov       r8d,[rbp-0C4]
       cmp       r9d,r8d
       jne       near ptr M00_L69
M00_L06:
       xor       ecx,ecx
       mov       [rbp-0C0],rcx
       mov       eax,[rbp-0C8]
       mov       r13d,eax
       mov       rcx,1B22A001DE0
       mov       r12,[rcx]
       mov       [rbp-350],r12
       mov       [rbp-2F0],r12
       mov       dword ptr [rbp-0DC],0C
       mov       rcx,1B22A000C90
       mov       r8,[rcx]
       mov       [rbp-358],r8
       mov       [rbp-2E8],r8
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],9
       jle       near ptr M00_L71
       mov       rcx,[rcx+240]
       mov       r9,[rcx+48]
       test      r9,r9
       je        near ptr M00_L71
M00_L07:
       mov       [rbp-348],r9
       mov       rcx,[r9+10]
       test      rcx,rcx
       je        short M00_L08
       cmp       dword ptr [rcx+8],0
       je        short M00_L08
       mov       r11,[rcx+10]
       test      r11,r11
       jne       near ptr M00_L15
M00_L08:
       mov       rax,[rbp-2F0]
       mov       rcx,[rax+10]
       mov       r11d,[rcx+8]
       test      r11d,r11d
       je        near ptr M00_L80
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        near ptr M00_L79
       mov       rdx,[rcx+8]
       mov       [rbp-300],rdx
       xor       ecx,ecx
       mov       [rbp-0F8],ecx
       lea       rcx,[rbp-0F8]
       mov       r11,7FFE866B22B0
       call      r11
       movzx     ebx,word ptr [rbp-0F8]
       shl       ebx,6
       movzx     esi,byte ptr [rbp-0F6]
       or        ebx,esi
       mov       eax,0AAAAAAAB
       mov       ecx,ebx
       imul      rax,rcx
       shr       rax,23
       imul      eax,0C
       sub       ebx,eax
       xor       esi,esi
       cmp       dword ptr [7FFE5454F778],0
       jne       near ptr M00_L73
M00_L09:
       mov       rdi,[rbp-300]
       cmp       dword ptr [rdi+8],0
       jle       near ptr M00_L76
M00_L10:
       cmp       ebx,[rdi+8]
       jae       near ptr M00_L112
       mov       ecx,ebx
       mov       r15,[rdi+rcx*8+10]
       cmp       [r15],r15b
       xor       r12d,r12d
       mov       rcx,r15
       call      00007FFE54129E20
       test      eax,eax
       je        near ptr M00_L74
M00_L11:
       mov       rcx,[r15+8]
       mov       eax,[r15+10]
       dec       eax
       cmp       [rcx+8],eax
       ja        short M00_L16
M00_L12:
       mov       rcx,r15
       call      00007FFE541E6030
       test      eax,eax
       jne       near ptr M00_L75
M00_L13:
       test      r12,r12
       jne       short M00_L18
       inc       ebx
       cmp       [rdi+8],ebx
       je        short M00_L17
M00_L14:
       inc       esi
       cmp       [rdi+8],esi
       jg        short M00_L10
       jmp       near ptr M00_L76
M00_L15:
       xor       edx,edx
       mov       [rcx+10],rdx
       mov       r10,[rbp-2E8]
       cmp       byte ptr [r10+9D],0
       jne       near ptr M00_L72
       mov       rbx,r11
       jmp       short M00_L20
M00_L16:
       mov       edx,eax
       mov       r12,[rcx+rdx*8+10]
       mov       edx,eax
       xor       r8d,r8d
       mov       [rcx+rdx*8+10],r8
       mov       [r15+10],eax
       jmp       short M00_L12
M00_L17:
       xor       ebx,ebx
       jmp       short M00_L14
M00_L18:
       mov       rdx,r12
M00_L19:
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M00_L78
       mov       rsi,[rbp-2E8]
       cmp       byte ptr [rsi+9D],0
       jne       near ptr M00_L77
       mov       rsi,[rbp-2A0]
M00_L20:
       mov       [rbp-2A8],rbx
       mov       r12,[rbp-350]
       mov       rbx,r12
       mov       eax,1
       test      r13d,r13d
       cmovne    eax,r13d
       mov       rcx,offset MT_System.Buffers.SharedArrayPool<System.Byte>
       cmp       [rbx],rcx
       jne       near ptr M00_L98
       mov       rdx,rbx
       mov       [rbp-2E0],rdx
       mov       r8,[rbp-358]
       mov       r10,r8
       mov       [rbp-308],r10
       lea       ecx,[rax-1]
       or        ecx,0F
       xor       r9d,r9d
       lzcnt     r9d,ecx
       xor       r9d,1F
       add       r9d,0FFFFFFFD
       mov       [rbp-100],r9d
       mov       r11,[rbp-348]
       mov       rcx,[r11+10]
       test      rcx,rcx
       je        short M00_L21
       cmp       [rcx+8],r9d
       jbe       short M00_L21
       cmp       r9d,[rcx+8]
       jae       near ptr M00_L112
       mov       edi,r9d
       shl       rdi,4
       mov       rdi,[rcx+rdi+10]
       test      rdi,rdi
       jne       near ptr M00_L28
M00_L21:
       mov       rcx,[rdx+10]
       mov       ebx,[rcx+8]
       cmp       ebx,r9d
       jbe       near ptr M00_L93
       cmp       r9d,ebx
       jae       near ptr M00_L112
       mov       eax,r9d
       mov       rcx,[rcx+rax*8+10]
       test      rcx,rcx
       je        near ptr M00_L92
       mov       rbx,[rcx+8]
       mov       [rbp-318],rbx
       xor       ecx,ecx
       mov       [rbp-120],ecx
       lea       rcx,[rbp-120]
       mov       rax,7FFE866B22B0
       call      rax
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
       cmp       dword ptr [7FFE5454F778],0
       jne       near ptr M00_L86
M00_L22:
       mov       rdi,[rbp-318]
       cmp       dword ptr [rdi+8],0
       jle       near ptr M00_L89
M00_L23:
       cmp       ebx,[rdi+8]
       jae       near ptr M00_L112
       mov       ecx,ebx
       mov       r15,[rdi+rcx*8+10]
       cmp       [r15],r15b
       xor       r12d,r12d
       mov       rcx,r15
       call      00007FFE54129E20
       test      eax,eax
       je        near ptr M00_L87
M00_L24:
       mov       rcx,[r15+8]
       mov       eax,[r15+10]
       dec       eax
       cmp       [rcx+8],eax
       ja        short M00_L29
M00_L25:
       mov       rcx,r15
       call      00007FFE541E6030
       test      eax,eax
       jne       near ptr M00_L88
M00_L26:
       test      r12,r12
       jne       short M00_L31
       inc       ebx
       cmp       [rdi+8],ebx
       je        short M00_L30
M00_L27:
       inc       esi
       cmp       [rdi+8],esi
       jg        short M00_L23
       jmp       near ptr M00_L89
M00_L28:
       cmp       r9d,[rcx+8]
       jae       near ptr M00_L112
       mov       eax,r9d
       shl       rax,4
       xor       edx,edx
       mov       [rcx+rax+10],rdx
       cmp       byte ptr [r10+9D],0
       je        short M00_L33
       jmp       near ptr M00_L84
M00_L29:
       cmp       eax,[rcx+8]
       jae       near ptr M00_L112
       mov       edx,eax
       mov       r12,[rcx+rdx*8+10]
       cmp       eax,[rcx+8]
       jae       near ptr M00_L112
       mov       edx,eax
       xor       r8d,r8d
       mov       [rcx+rdx*8+10],r8
       mov       [r15+10],eax
       jmp       short M00_L25
M00_L30:
       xor       ebx,ebx
       jmp       short M00_L27
M00_L31:
       mov       rdi,r12
M00_L32:
       test      rdi,rdi
       je        near ptr M00_L91
       mov       rbx,[rbp-308]
       cmp       byte ptr [rbx+9D],0
       jne       near ptr M00_L90
       mov       rsi,[rbp-2A0]
M00_L33:
       mov       rdx,rdi
M00_L34:
       mov       [rbp-2B0],rdx
       mov       r12,[rbp-350]
       mov       rcx,r12
       mov       edx,1
       test      r13d,r13d
       cmovne    edx,r13d
       mov       rax,offset MT_System.Buffers.SharedArrayPool<System.Byte>
       cmp       [rcx],rax
       jne       near ptr M00_L99
       call      qword ptr [7FFDF4D68C00]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Rent(Int32)
       mov       rdx,rax
M00_L35:
       mov       [rbp-2B8],rdx
       mov       [rbp-350],r12
       mov       rbx,r12
       mov       [rbp-328],rbx
       mov       rax,[rbp-358]
       mov       [rbp-320],rax
       mov       rcx,[rbp-348]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       mov       r12,[rbp-350]
       je        short M00_L36
       cmp       dword ptr [rcx+8],0
       je        short M00_L36
       cmp       dword ptr [rcx+8],0
       jbe       near ptr M00_L112
       mov       rdx,[rcx+10]
       test      rdx,rdx
       jne       near ptr M00_L43
M00_L36:
       mov       rcx,[rbx+10]
       mov       edx,[rcx+8]
       test      edx,edx
       je        near ptr M00_L110
       test      edx,edx
       je        near ptr M00_L112
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        near ptr M00_L105
       mov       [rbp-350],r12
       mov       rdx,[rcx+8]
       mov       [rbp-338],rdx
       xor       ecx,ecx
       mov       [rbp-138],ecx
       lea       rcx,[rbp-138]
       mov       r8,7FFE866B22B0
       call      r8
       movzx     ebx,word ptr [rbp-138]
       shl       ebx,6
       movzx     esi,byte ptr [rbp-136]
       or        ebx,esi
       mov       eax,0AAAAAAAB
       mov       ecx,ebx
       imul      rax,rcx
       shr       rax,23
       imul      eax,0C
       sub       ebx,eax
       xor       esi,esi
       cmp       dword ptr [7FFE5454F778],0
       jne       near ptr M00_L102
M00_L37:
       mov       rdi,[rbp-338]
       cmp       dword ptr [rdi+8],0
       jle       near ptr M00_L106
M00_L38:
       cmp       ebx,[rdi+8]
       jae       near ptr M00_L112
       mov       ecx,ebx
       mov       r15,[rdi+rcx*8+10]
       cmp       [r15],r15b
       xor       r12d,r12d
       mov       rcx,r15
       call      00007FFE54129E20
       test      eax,eax
       je        near ptr M00_L103
M00_L39:
       mov       rcx,[r15+8]
       mov       eax,[r15+10]
       dec       eax
       cmp       [rcx+8],eax
       ja        short M00_L44
M00_L40:
       mov       rcx,r15
       call      00007FFE541E6030
       test      eax,eax
       jne       near ptr M00_L104
M00_L41:
       test      r12,r12
       jne       short M00_L46
       inc       ebx
       cmp       [rdi+8],ebx
       je        short M00_L45
M00_L42:
       inc       esi
       cmp       [rdi+8],esi
       jg        short M00_L38
       jmp       near ptr M00_L106
M00_L43:
       cmp       dword ptr [rcx+8],0
       jbe       near ptr M00_L112
       xor       r8d,r8d
       mov       [rcx+10],r8
       cmp       byte ptr [rax+9D],0
       jne       near ptr M00_L100
       mov       rbx,rdx
       jmp       short M00_L48
M00_L44:
       cmp       eax,[rcx+8]
       jae       near ptr M00_L112
       mov       edx,eax
       mov       r12,[rcx+rdx*8+10]
       cmp       eax,[rcx+8]
       jae       near ptr M00_L112
       mov       edx,eax
       xor       r8d,r8d
       mov       [rcx+rdx*8+10],r8
       mov       [r15+10],eax
       jmp       short M00_L40
M00_L45:
       xor       ebx,ebx
       jmp       short M00_L42
M00_L46:
       mov       rdx,r12
M00_L47:
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M00_L108
       mov       rsi,[rbp-320]
       cmp       byte ptr [rsi+9D],0
       jne       near ptr M00_L107
       mov       rsi,[rbp-2A0]
       mov       r12,[rbp-350]
M00_L48:
       mov       [rbp-2C0],rbx
       xor       ecx,ecx
       mov       [rbp-3C],ecx
       cmp       qword ptr [rbp-2A8],0
       je        near ptr M00_L54
       mov       rdx,[rbp-2A8]
       cmp       dword ptr [rdx+8],0C
       jl        near ptr M00_L54
       lea       rcx,[rdx+10]
       mov       [rbp-140],rcx
       mov       edx,0C
       call      qword ptr [7FFDF4C8ECB8]; System.Security.Cryptography.RandomNumberGeneratorImplementation.GetBytes(Byte*, Int32)
       xor       ecx,ecx
       mov       [rbp-140],rcx
       test      r13d,r13d
       jle       near ptr M00_L51
       mov       r15,[rbp-360]
       mov       r13,[rbp-298]
       lea       rax,[r13+0C]
       mov       r13d,[r13+8]
       cmp       qword ptr [rbp-2B0],0
       je        near ptr M00_L55
       mov       rdx,[rbp-2B0]
       lea       r10,[rdx+10]
       mov       r11d,[rdx+8]
M00_L49:
       mov       [rbp-148],rax
       mov       [rbp-258],rax
       mov       [rbp-150],r10
       mov       [rbp-260],r10
       lea       rcx,[rbp-158]
       mov       [rsp+20],rcx
       lea       rcx,[rbp-160]
       mov       [rsp+28],rcx
       mov       rcx,rax
       mov       edx,r13d
       mov       r8,r10
       mov       [rbp-24C],r11d
       mov       r9d,r11d
       call      qword ptr [7FFDF461FAF8]; System.Text.Unicode.Utf8Utility.TranscodeToUtf8(Char*, Int32, Byte*, Int32, Char* ByRef, Byte* ByRef)
       mov       rcx,[rbp-158]
       mov       rdx,[rbp-258]
       sub       rcx,rdx
       mov       r8,rcx
       shr       r8,3F
       add       rcx,r8
       sar       rcx,1
       mov       eax,[rbp-160]
       mov       r9,[rbp-260]
       sub       eax,r9d
       cmp       ecx,r13d
       jne       near ptr M00_L57
M00_L50:
       xor       ecx,ecx
       mov       [rbp-148],rcx
       mov       [rbp-150],rcx
       mov       [rbp-3C],eax
M00_L51:
       mov       rcx,offset MT_System.Security.Cryptography.AesGcm
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-170],xmm0
       lea       rcx,[rbp-170]
       mov       rdx,rsi
       call      qword ptr [7FFDF4D373F0]; System.ReadOnlySpan`1[[System.Byte, System.Private.CoreLib]]..ctor(Byte[])
       vmovdqu   xmm0,xmmword ptr [rbp-170]
       vmovdqu   xmmword ptr [rbp-270],xmm0
       lea       rdx,[rbp-270]
       mov       rcx,r15
       mov       r8d,10
       call      qword ptr [7FFDF4D3CFD8]; System.Security.Cryptography.AesGcm..ctor(System.ReadOnlySpan`1<Byte>, Int32)
       mov       [rbp-2C8],r15
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-180],xmm0
       lea       rcx,[rbp-180]
       mov       rdx,[rbp-2A8]
       xor       r8d,r8d
       mov       r9d,0C
       call      qword ptr [7FFDF4D3C6A8]; System.Span`1[[System.Byte, System.Private.CoreLib]]..ctor(Byte[], Int32, Int32)
       vmovdqu   xmm0,xmmword ptr [rbp-180]
       vmovdqu   xmmword ptr [rbp-280],xmm0
       lea       rdx,[rbp-280]
       lea       rcx,[rbp-50]
       call      qword ptr [7FFDF4B07C30]; System.Span`1[[System.Byte, System.Private.CoreLib]].op_Implicit(System.Span`1<Byte>)
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-190],xmm0
       lea       rcx,[rbp-190]
       mov       rdx,[rbp-2B0]
       mov       r9d,[rbp-3C]
       xor       r8d,r8d
       call      qword ptr [7FFDF4D3C6A8]; System.Span`1[[System.Byte, System.Private.CoreLib]]..ctor(Byte[], Int32, Int32)
       vmovdqu   xmm0,xmmword ptr [rbp-190]
       vmovdqu   xmmword ptr [rbp-280],xmm0
       lea       rdx,[rbp-280]
       lea       rcx,[rbp-60]
       call      qword ptr [7FFDF4B07C30]; System.Span`1[[System.Byte, System.Private.CoreLib]].op_Implicit(System.Span`1<Byte>)
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-1A0],xmm0
       lea       rcx,[rbp-1A0]
       mov       rdx,[rbp-2B8]
       mov       r9d,[rbp-3C]
       xor       r8d,r8d
       call      qword ptr [7FFDF4D3C6A8]; System.Span`1[[System.Byte, System.Private.CoreLib]]..ctor(Byte[], Int32, Int32)
       mov       rsi,[rbp-1A0]
       mov       r13d,[rbp-198]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-1B0],xmm0
       lea       rcx,[rbp-1B0]
       mov       rdx,rbx
       xor       r8d,r8d
       mov       r9d,10
       call      qword ptr [7FFDF4D3C6A8]; System.Span`1[[System.Byte, System.Private.CoreLib]]..ctor(Byte[], Int32, Int32)
       mov       [rbp-280],rsi
       mov       [rbp-278],r13d
       vmovdqu   xmm0,xmmword ptr [rbp-1B0]
       vmovdqu   xmmword ptr [rbp-290],xmm0
       mov       rdi,[rbp-340]
       mov       [rbp-270],rdi
       mov       [rbp-268],r14d
       lea       r9,[rbp-280]
       lea       r8,[rbp-290]
       mov       [rsp+20],r8
       lea       r8,[rbp-270]
       mov       [rsp+28],r8
       lea       r8,[rbp-60]
       lea       rdx,[rbp-50]
       mov       rcx,r15
       call      qword ptr [7FFDF4D3CF90]; System.Security.Cryptography.AesGcm.Encrypt(System.ReadOnlySpan`1<Byte>, System.ReadOnlySpan`1<Byte>, System.Span`1<Byte>, System.Span`1<Byte>, System.ReadOnlySpan`1<Byte>)
       nop
       mov       rcx,[r15+8]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF473E510]; System.Runtime.InteropServices.SafeHandle.Dispose()
       mov       esi,[rbp-3C]
       add       esi,0D
       jo        near ptr M00_L56
       mov       r9d,esi
       add       r9d,10
       jo        near ptr M00_L56
       mov       [rbp-64],r9d
       mov       rcx,r12
       mov       edx,[rbp-64]
       call      qword ptr [7FFDF4D68C00]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Rent(Int32)
       mov       [rbp-2D0],rax
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-1C0],xmm0
       lea       rcx,[rbp-1C0]
       mov       rdx,[rbp-2D0]
       mov       r9d,[rbp-64]
       xor       r8d,r8d
       call      qword ptr [7FFDF4D3C6A8]; System.Span`1[[System.Byte, System.Private.CoreLib]]..ctor(Byte[], Int32, Int32)
       vmovdqu   xmm0,xmmword ptr [rbp-1C0]
       vmovdqu   xmmword ptr [rbp-78],xmm0
       cmp       dword ptr [rbp-70],0
       jbe       near ptr M00_L52
       mov       rcx,[rbp-78]
       mov       byte ptr [rcx],1
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-1D0],xmm0
       lea       rcx,[rbp-1D0]
       mov       rdx,[rbp-2A8]
       xor       r8d,r8d
       mov       r9d,0C
       call      qword ptr [7FFDF4D3C6A8]; System.Span`1[[System.Byte, System.Private.CoreLib]]..ctor(Byte[], Int32, Int32)
       vmovdqu   xmm0,xmmword ptr [rbp-1D0]
       vmovdqu   xmmword ptr [rbp-88],xmm0
       lea       rcx,[rbp-78]
       lea       rdx,[rbp-98]
       mov       r8d,1
       mov       r9d,0C
       call      qword ptr [7FFDF4B07C18]; System.Span`1[[System.Byte, System.Private.CoreLib]].Slice(Int32, Int32)
       lea       rcx,[rbp-88]
       lea       rdx,[rbp-98]
       call      qword ptr [7FFDF4D373A8]; System.Span`1[[System.Byte, System.Private.CoreLib]].CopyTo(System.Span`1<Byte>)
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-1E0],xmm0
       lea       rcx,[rbp-1E0]
       mov       rdx,[rbp-2B8]
       mov       r9d,[rbp-3C]
       xor       r8d,r8d
       call      qword ptr [7FFDF4D3C6A8]; System.Span`1[[System.Byte, System.Private.CoreLib]]..ctor(Byte[], Int32, Int32)
       vmovdqu   xmm0,xmmword ptr [rbp-1E0]
       vmovdqu   xmmword ptr [rbp-88],xmm0
       lea       rcx,[rbp-78]
       lea       rdx,[rbp-0A8]
       mov       r9d,[rbp-3C]
       mov       r8d,0D
       call      qword ptr [7FFDF4B07C18]; System.Span`1[[System.Byte, System.Private.CoreLib]].Slice(Int32, Int32)
       lea       rcx,[rbp-88]
       lea       rdx,[rbp-0A8]
       call      qword ptr [7FFDF4D373A8]; System.Span`1[[System.Byte, System.Private.CoreLib]].CopyTo(System.Span`1<Byte>)
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-1F0],xmm0
       lea       rcx,[rbp-1F0]
       mov       rdx,rbx
       xor       r8d,r8d
       mov       r9d,10
       call      qword ptr [7FFDF4D3C6A8]; System.Span`1[[System.Byte, System.Private.CoreLib]]..ctor(Byte[], Int32, Int32)
       vmovdqu   xmm0,xmmword ptr [rbp-1F0]
       vmovdqu   xmmword ptr [rbp-88],xmm0
       mov       r8d,esi
       lea       rdx,[rbp-0B8]
       lea       rcx,[rbp-78]
       mov       r9d,10
       call      qword ptr [7FFDF4B07C18]; System.Span`1[[System.Byte, System.Private.CoreLib]].Slice(Int32, Int32)
       lea       rcx,[rbp-88]
       lea       rdx,[rbp-0B8]
       call      qword ptr [7FFDF4D373A8]; System.Span`1[[System.Byte, System.Private.CoreLib]].CopyTo(System.Span`1<Byte>)
       mov       rcx,[rbp-2D0]
       mov       r8d,[rbp-64]
       xor       edx,edx
       xor       r9d,r9d
       call      qword ptr [7FFDF4D3D0F8]; System.Convert.ToBase64String(Byte[], Int32, Int32, System.Base64FormattingOptions)
       mov       [rbp-2D8],rax
       jmp       short M00_L53
M00_L52:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L53:
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-200],xmm0
       lea       rcx,[rbp-200]
       mov       rdx,[rbp-2D0]
       mov       r9d,[rbp-64]
       xor       r8d,r8d
       call      qword ptr [7FFDF4D3C6A8]; System.Span`1[[System.Byte, System.Private.CoreLib]]..ctor(Byte[], Int32, Int32)
       vmovdqu   xmm0,xmmword ptr [rbp-200]
       vmovdqu   xmmword ptr [rbp-280],xmm0
       lea       rcx,[rbp-280]
       call      qword ptr [7FFDF4D3C6C0]; System.Security.Cryptography.CryptographicOperations.ZeroMemory(System.Span`1<Byte>)
       mov       rcx,r12
       mov       rdx,[rbp-2D0]
       mov       r8d,1
       call      qword ptr [7FFDF4D68C08]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Return(Byte[], Boolean)
       jmp       short M00_L58
M00_L54:
       call      qword ptr [7FFDF47B7138]
       int       3
M00_L55:
       xor       r10d,r10d
       xor       r11d,r11d
       jmp       near ptr M00_L49
M00_L56:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L57:
       mov       r8d,[rbp-24C]
       mov       [rsp+20],r8d
       mov       [rsp+28],ecx
       mov       [rsp+30],eax
       mov       dword ptr [rsp+38],1
       mov       rcx,r15
       mov       r8d,r13d
       call      qword ptr [7FFDF4DDCED0]
       jmp       near ptr M00_L50
M00_L58:
       call      M00_L113
       nop
       mov       rax,[rbp-2D8]
       mov       [rbp-248],rax
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+18]
       lea       r8,[rbp-248]
       mov       rdx,7FFDF4DEC130
       cmp       [rcx],ecx
       call      qword ptr [7FFDF4DD4C60]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,368
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L59:
       call      qword ptr [7FFDF4B04060]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L60
       call      qword ptr [7FFDF4DDE928]
       mov       rbx,rax
M00_L60:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,1F2BF18FF68
       call      qword ptr [7FFDF4DDD8A8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L61:
       mov       ecx,eax
       call      qword ptr [7FFDF4DDC090]
       test      eax,eax
       jne       short M00_L63
       jmp       near ptr M00_L03
M00_L62:
       mov       ecx,eax
       call      qword ptr [7FFDF4DDC090]
       test      eax,eax
       je        near ptr M00_L04
M00_L63:
       mov       rcx,rbx
       mov       edx,3
       call      qword ptr [7FFDF4DDC0A8]
       mov       rbx,rax
       jmp       near ptr M00_L04
M00_L64:
       xor       r8d,r8d
       jmp       near ptr M00_L05
M00_L65:
       call      qword ptr [7FFDF4D37BE8]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L66
       call      qword ptr [7FFDF4DDE928]
       mov       rbx,rax
M00_L66:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,1F2BF189C08
       call      qword ptr [7FFDF4DDD8A8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L67:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,11E7
       mov       rdx,7FFDF49B5D88
       call      qword ptr [7FFDF4897738]
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,1F2BF190540
       call      qword ptr [7FFDF4A65E60]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L68:
       mov       ecx,0E
       call      qword ptr [7FFDF489C1C8]
       int       3
M00_L69:
       mov       rcx,r13
       mov       rdx,r12
       call      qword ptr [7FFDF4DDCEE8]
       add       eax,[rbp-0C8]
       mov       r13d,eax
       test      r13d,r13d
       mov       [rbp-0C8],r13d
       jge       near ptr M00_L06
M00_L70:
       call      qword ptr [7FFDF4DD64A8]
       int       3
M00_L71:
       mov       ecx,9
       call      qword ptr [7FFDF4DDC528]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       r9,rax
       jmp       near ptr M00_L07
M00_L72:
       mov       [rbp-2F8],r11
       mov       rcx,r11
       call      qword ptr [7FFDF4B0C948]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rbp-0EC],eax
       mov       rdx,[rbp-2F8]
       mov       r8d,[rdx+8]
       mov       [rbp-0F0],r8d
       mov       rcx,[rbp-2F0]
       call      qword ptr [7FFDF4B0C948]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       xor       edx,edx
       mov       [rsp+20],edx
       mov       edx,[rbp-0EC]
       mov       r8d,[rbp-0F0]
       mov       rcx,[rbp-2E8]
       call      qword ptr [7FFDF4DDD950]
       mov       rbx,[rbp-2F8]
       jmp       near ptr M00_L20
M00_L73:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L09
M00_L74:
       mov       rcx,r15
       call      qword ptr [7FFDF4DDC888]
       jmp       near ptr M00_L11
M00_L75:
       mov       ecx,eax
       mov       rdx,r15
       call      qword ptr [7FFDF4DDC678]
       jmp       near ptr M00_L13
M00_L76:
       xor       edx,edx
       jmp       near ptr M00_L19
M00_L77:
       mov       rcx,rbx
       call      qword ptr [7FFDF4B0C948]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       edi,eax
       mov       r15d,[rbx+8]
       mov       rcx,[rbp-2F0]
       call      qword ptr [7FFDF4B0C948]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       xor       edx,edx
       mov       [rsp+20],edx
       mov       edx,edi
       mov       r8d,r15d
       mov       rcx,rsi
       call      qword ptr [7FFDF4DDD950]
       mov       rsi,[rbp-2A0]
       jmp       near ptr M00_L20
M00_L78:
       mov       rsi,[rbp-2A0]
M00_L79:
       mov       dword ptr [rbp-0DC],10
       jmp       short M00_L81
M00_L80:
       mov       ecx,0C
       mov       rdx,1F2BF186F28
       call      qword ptr [7FFDF489D800]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
M00_L81:
       mov       r11d,[rbp-0DC]
       cmp       r11d,800
       jge       short M00_L82
       mov       edx,r11d
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       jmp       short M00_L83
M00_L82:
       mov       ecx,r11d
       xor       edx,edx
       call      qword ptr [7FFDF4DDD938]
M00_L83:
       mov       rdx,rax
       mov       rax,[rbp-2E8]
       cmp       byte ptr [rax+9D],0
       je        near ptr M00_L85
       cmp       [rdx],dl
       mov       [rbp-2F8],rdx
       mov       rcx,rdx
       call      qword ptr [7FFDF4B0C948]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rbp-0E0],eax
       mov       rdx,[rbp-2F8]
       mov       r8d,[rdx+8]
       mov       [rbp-0E4],r8d
       mov       rcx,[rbp-2F0]
       call      qword ptr [7FFDF4B0C948]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       edx,[rbp-0E0]
       mov       r8d,[rbp-0E4]
       mov       rcx,[rbp-2E8]
       call      qword ptr [7FFDF4DDD950]
       mov       rdx,[rbp-2F8]
       mov       eax,[rdx+8]
       mov       [rbp-0E8],eax
       mov       rcx,[rbp-2F0]
       call      qword ptr [7FFDF4B0C948]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       rcx,[rbp-2F0]
       mov       rcx,[rcx+10]
       mov       edx,1
       mov       r8d,2
       cmp       dword ptr [rcx+8],0
       cmovg     edx,r8d
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       [rsp+28],edx
       mov       rcx,[rbp-2E8]
       mov       edx,[rbp-0E0]
       mov       r8d,[rbp-0E8]
       call      qword ptr [7FFDF4DDD968]
       mov       rbx,[rbp-2F8]
       jmp       near ptr M00_L20
M00_L84:
       mov       rcx,rdi
       call      qword ptr [7FFDF4B0C948]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rbp-110],eax
       mov       edx,[rdi+8]
       mov       [rbp-114],edx
       mov       rcx,rbx
       call      qword ptr [7FFDF4B0C948]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       ebx,[rbp-100]
       mov       [rsp+20],ebx
       mov       edx,[rbp-110]
       mov       r8d,[rbp-114]
       mov       rcx,[rbp-308]
       call      qword ptr [7FFDF4DDD950]
       jmp       near ptr M00_L33
M00_L85:
       mov       rbx,rdx
       jmp       near ptr M00_L20
M00_L86:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L22
M00_L87:
       mov       rcx,r15
       call      qword ptr [7FFDF4DDC888]
       jmp       near ptr M00_L24
M00_L88:
       mov       ecx,eax
       mov       rdx,r15
       call      qword ptr [7FFDF4DDC678]
       jmp       near ptr M00_L26
M00_L89:
       xor       edi,edi
       jmp       near ptr M00_L32
M00_L90:
       mov       rcx,rdi
       call      qword ptr [7FFDF4B0C948]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       esi,eax
       mov       r15d,[rdi+8]
       mov       rcx,[rbp-2E0]
       call      qword ptr [7FFDF4B0C948]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       r12d,[rbp-100]
       mov       [rsp+20],r12d
       mov       edx,esi
       mov       r8d,r15d
       mov       rcx,rbx
       call      qword ptr [7FFDF4DDD950]
       mov       rsi,[rbp-2A0]
       jmp       near ptr M00_L33
M00_L91:
       mov       rsi,[rbp-2A0]
       mov       r10,[rbp-308]
M00_L92:
       mov       ecx,10
       mov       r9d,[rbp-100]
       shlx      eax,ecx,r9d
       mov       ebx,eax
       jmp       short M00_L95
M00_L93:
       test      eax,eax
       jne       short M00_L94
       mov       rdx,1F2BF1862A0
       jmp       near ptr M00_L34
M00_L94:
       mov       [rbp-0FC],eax
       mov       ecx,eax
       mov       rdx,1F2BF186F28
       call      qword ptr [7FFDF489D800]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
       mov       ebx,[rbp-0FC]
       mov       r10,[rbp-308]
M00_L95:
       cmp       ebx,800
       jge       short M00_L96
       movsxd    rdx,ebx
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       jmp       short M00_L97
M00_L96:
       mov       ecx,ebx
       xor       edx,edx
       call      qword ptr [7FFDF4DDD938]
M00_L97:
       mov       rdx,rax
       mov       rbx,[rbp-308]
       cmp       byte ptr [rbx+9D],0
       je        near ptr M00_L101
       cmp       [rdx],dl
       mov       [rbp-310],rdx
       mov       rcx,rdx
       call      qword ptr [7FFDF4B0C948]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rbp-104],eax
       mov       rdx,[rbp-310]
       mov       r8d,[rdx+8]
       mov       [rbp-108],r8d
       mov       rcx,[rbp-2E0]
       call      qword ptr [7FFDF4B0C948]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       edx,[rbp-104]
       mov       r8d,[rbp-108]
       mov       rcx,rbx
       call      qword ptr [7FFDF4DDD950]
       mov       rdx,[rbp-310]
       mov       eax,[rdx+8]
       mov       [rbp-10C],eax
       mov       rcx,[rbp-2E0]
       call      qword ptr [7FFDF4B0C948]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       rcx,[rbp-2E0]
       mov       rcx,[rcx+10]
       mov       edx,1
       mov       r8d,2
       mov       eax,[rbp-100]
       cmp       [rcx+8],eax
       cmovg     edx,r8d
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       [rsp+28],edx
       mov       rcx,rbx
       mov       edx,[rbp-104]
       mov       r8d,[rbp-10C]
       call      qword ptr [7FFDF4DDD968]
       mov       rdi,[rbp-310]
       jmp       near ptr M00_L33
M00_L98:
       mov       rcx,rbx
       mov       edx,eax
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rdx,rax
       jmp       near ptr M00_L34
M00_L99:
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rdx,rax
       jmp       near ptr M00_L35
M00_L100:
       mov       [rbp-330],rdx
       mov       rcx,rdx
       call      qword ptr [7FFDF4B0C948]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rbp-128],eax
       mov       rdx,[rbp-330]
       mov       r8d,[rdx+8]
       mov       [rbp-12C],r8d
       mov       rcx,rbx
       call      qword ptr [7FFDF4B0C948]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       xor       edx,edx
       mov       [rsp+20],edx
       mov       edx,[rbp-128]
       mov       r8d,[rbp-12C]
       mov       rcx,[rbp-320]
       call      qword ptr [7FFDF4DDD950]
       mov       rbx,[rbp-330]
       jmp       near ptr M00_L48
M00_L101:
       mov       rdi,rdx
       jmp       near ptr M00_L33
M00_L102:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L37
M00_L103:
       mov       rcx,r15
       call      qword ptr [7FFDF4DDC888]
       jmp       near ptr M00_L39
M00_L104:
       mov       ecx,eax
       mov       rdx,r15
       call      qword ptr [7FFDF4DDC678]
       jmp       near ptr M00_L41
M00_L105:
       mov       rbx,[rbp-328]
       jmp       short M00_L109
M00_L106:
       xor       edx,edx
       jmp       near ptr M00_L47
M00_L107:
       mov       rcx,rbx
       call      qword ptr [7FFDF4B0C948]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       edi,eax
       mov       r15d,[rbx+8]
       mov       rcx,[rbp-328]
       call      qword ptr [7FFDF4B0C948]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       xor       edx,edx
       mov       [rsp+20],edx
       mov       edx,edi
       mov       r8d,r15d
       mov       rcx,rsi
       call      qword ptr [7FFDF4DDD950]
       mov       rsi,[rbp-2A0]
       mov       r12,[rbp-350]
       jmp       near ptr M00_L48
M00_L108:
       mov       rbx,[rbp-328]
       mov       rsi,[rbp-2A0]
       mov       r12,[rbp-350]
M00_L109:
       mov       edx,10
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rdx,[rbp-320]
       cmp       byte ptr [rdx+9D],0
       jne       short M00_L111
       mov       rbx,rax
       jmp       near ptr M00_L48
M00_L110:
       mov       rbx,[rbp-328]
       mov       ecx,10
       mov       rdx,1F2BF186F28
       call      qword ptr [7FFDF489D800]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
       jmp       short M00_L109
M00_L111:
       mov       [rbp-330],rax
       mov       rcx,rax
       call      qword ptr [7FFDF4B0C948]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rbp-124],eax
       mov       rcx,rbx
       call      qword ptr [7FFDF4B0C948]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       edx,[rbp-124]
       mov       r8d,10
       mov       rcx,[rbp-320]
       call      qword ptr [7FFDF4DDD950]
       mov       rcx,rbx
       call      qword ptr [7FFDF4B0C948]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       rcx,[rbx+10]
       mov       edx,1
       mov       r8d,2
       cmp       dword ptr [rcx+8],0
       cmovg     edx,r8d
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       [rsp+28],edx
       mov       rcx,[rbp-320]
       mov       edx,[rbp-124]
       mov       r8d,10
       call      qword ptr [7FFDF4DDD968]
       mov       rbx,[rbp-330]
       jmp       near ptr M00_L48
M00_L112:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       sub       rsp,48
       vzeroupper
       mov       rcx,[rbp-2C8]
       mov       rcx,[rcx+8]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF473E510]; System.Runtime.InteropServices.SafeHandle.Dispose()
       nop
       add       rsp,48
       ret
       sub       rsp,48
       vzeroupper
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-200],xmm0
       lea       rcx,[rbp-200]
       mov       rdx,[rbp-2D0]
       mov       r9d,[rbp-64]
       xor       r8d,r8d
       call      qword ptr [7FFDF4D3C6A8]; System.Span`1[[System.Byte, System.Private.CoreLib]]..ctor(Byte[], Int32, Int32)
       vmovdqu   xmm0,xmmword ptr [rbp-200]
       vmovdqu   xmmword ptr [rbp-280],xmm0
       lea       rcx,[rbp-280]
       call      qword ptr [7FFDF4D3C6C0]; System.Security.Cryptography.CryptographicOperations.ZeroMemory(System.Span`1<Byte>)
       mov       rcx,1B22A001DE0
       mov       r12,[rcx]
       mov       rcx,r12
       mov       rdx,[rbp-2D0]
       mov       r8d,1
       call      qword ptr [7FFDF4D68C08]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Return(Byte[], Boolean)
       nop
       add       rsp,48
       ret
M00_L113:
       sub       rsp,48
       vzeroupper
       cmp       dword ptr [rbp-3C],0
       jle       near ptr M00_L114
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-210],xmm0
       lea       rcx,[rbp-210]
       mov       rdx,[rbp-2B0]
       mov       r9d,[rbp-3C]
       xor       r8d,r8d
       call      qword ptr [7FFDF4D3C6A8]; System.Span`1[[System.Byte, System.Private.CoreLib]]..ctor(Byte[], Int32, Int32)
       vmovdqu   xmm0,xmmword ptr [rbp-210]
       vmovdqu   xmmword ptr [rbp-280],xmm0
       lea       rcx,[rbp-280]
       call      qword ptr [7FFDF4D3C6C0]; System.Security.Cryptography.CryptographicOperations.ZeroMemory(System.Span`1<Byte>)
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-220],xmm0
       lea       rcx,[rbp-220]
       mov       rdx,[rbp-2B8]
       mov       r9d,[rbp-3C]
       xor       r8d,r8d
       call      qword ptr [7FFDF4D3C6A8]; System.Span`1[[System.Byte, System.Private.CoreLib]]..ctor(Byte[], Int32, Int32)
       vmovdqu   xmm0,xmmword ptr [rbp-220]
       vmovdqu   xmmword ptr [rbp-280],xmm0
       lea       rcx,[rbp-280]
       call      qword ptr [7FFDF4D3C6C0]; System.Security.Cryptography.CryptographicOperations.ZeroMemory(System.Span`1<Byte>)
M00_L114:
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-230],xmm0
       lea       rcx,[rbp-230]
       mov       rdx,[rbp-2C0]
       xor       r8d,r8d
       mov       r9d,10
       call      qword ptr [7FFDF4D3C6A8]; System.Span`1[[System.Byte, System.Private.CoreLib]]..ctor(Byte[], Int32, Int32)
       vmovdqu   xmm0,xmmword ptr [rbp-230]
       vmovdqu   xmmword ptr [rbp-280],xmm0
       lea       rcx,[rbp-280]
       call      qword ptr [7FFDF4D3C6C0]; System.Security.Cryptography.CryptographicOperations.ZeroMemory(System.Span`1<Byte>)
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-240],xmm0
       lea       rcx,[rbp-240]
       mov       rdx,[rbp-2A8]
       xor       r8d,r8d
       mov       r9d,0C
       call      qword ptr [7FFDF4D3C6A8]; System.Span`1[[System.Byte, System.Private.CoreLib]]..ctor(Byte[], Int32, Int32)
       vmovdqu   xmm0,xmmword ptr [rbp-240]
       vmovdqu   xmmword ptr [rbp-280],xmm0
       lea       rcx,[rbp-280]
       call      qword ptr [7FFDF4D3C6C0]; System.Security.Cryptography.CryptographicOperations.ZeroMemory(System.Span`1<Byte>)
       mov       rcx,1B22A001DE0
       mov       r12,[rcx]
       mov       rcx,r12
       mov       rdx,[rbp-2B0]
       mov       r8d,1
       call      qword ptr [7FFDF4D68C08]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Return(Byte[], Boolean)
       mov       rcx,r12
       mov       rdx,[rbp-2B8]
       mov       r8d,1
       call      qword ptr [7FFDF4D68C08]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Return(Byte[], Boolean)
       mov       rcx,r12
       mov       rdx,[rbp-2C0]
       mov       r8d,1
       call      qword ptr [7FFDF4D68C08]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Return(Byte[], Boolean)
       mov       rcx,r12
       mov       rdx,[rbp-2A8]
       mov       r8d,1
       call      qword ptr [7FFDF4D68C08]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Return(Byte[], Boolean)
       nop
       add       rsp,48
       ret
; Total bytes of code 5938
```
```assembly
; DotNetTips.Spargine.Core.Extensions.Count(System.Collections.IEnumerable)
; 		if (collection is null)
; 		^^^^^^^^^^^^^^^^^^^^^^^
; 			return 0;
; 			^^^^^^^^^
; 		if (collection is ICollection col)
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			return col.Count;
; 			^^^^^^^^^^^^^^^^^
; 		else if (collection is ICollection<object> colT)
; 		     ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			return colT.Count;
; 			^^^^^^^^^^^^^^^^^^
; 		var count = 0;
; 		^^^^^^^^^^^^^^
; 		var enumerator = collection.GetEnumerator();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			count++;
; 			^^^^^^^^
; 		while (enumerator.MoveNext())
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return count;
; 		^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       test      rbx,rbx
       je        short M01_L01
       mov       rcx,rbx
       mov       rdx,offset MT_System.Byte[]
       cmp       [rcx],rdx
       jne       short M01_L02
M01_L00:
       test      rcx,rcx
       je        short M01_L04
       mov       rax,offset MT_System.Byte[]
       cmp       [rcx],rax
       jne       short M01_L03
       mov       eax,[rcx+8]
       test      eax,eax
       jl        near ptr M01_L14
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L01:
       xor       eax,eax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L02:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.ICollection
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rcx,rax
       jmp       short M01_L00
M01_L03:
       mov       r11,7FFDF4560AE8
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [r11]
M01_L04:
       mov       rcx,rbx
       mov       rdx,offset MT_System.Linq.Enumerable+IEnumerableWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Address>
       cmp       [rcx],rdx
       je        short M01_L05
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.ICollection<System.Object>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rcx,rax
       jmp       short M01_L06
M01_L05:
       xor       ecx,ecx
M01_L06:
       test      rcx,rcx
       je        short M01_L07
       mov       r11,7FFDF4560AE0
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [r11]
M01_L07:
       xor       esi,esi
       mov       rcx,offset MT_System.Linq.Enumerable+IEnumerableWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Address>
       cmp       [rbx],rcx
       jne       short M01_L08
       mov       rcx,rbx
       call      qword ptr [7FFDF489F678]; System.Linq.Enumerable+Iterator`1[[System.__Canon, System.Private.CoreLib]].GetEnumerator()
       mov       rdi,rax
       jmp       short M01_L09
M01_L08:
       mov       rcx,rbx
       mov       r11,7FFDF4560AD0
       call      qword ptr [r11]
       mov       rdi,rax
M01_L09:
       jmp       short M01_L11
M01_L10:
       add       esi,1
       jo        short M01_L14
M01_L11:
       mov       rcx,offset MT_System.Linq.Enumerable+IEnumerableWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Address>
       cmp       [rdi],rcx
       jne       short M01_L12
       mov       rcx,rdi
       call      qword ptr [7FFDF4A5D778]; Precode of System.Linq.Enumerable+IEnumerableWhereIterator`1[[System.__Canon, System.Private.CoreLib]].MoveNext()
       jmp       short M01_L13
M01_L12:
       mov       rcx,rdi
       mov       r11,7FFDF4560AD8
       call      qword ptr [r11]
M01_L13:
       test      eax,eax
       jne       short M01_L10
       mov       eax,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L14:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 312
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
       jae       near ptr M02_L15
       cmp       r10,10
       jae       near ptr M02_L13
M02_L00:
       cmp       r10,4
       jb        short M02_L02
M02_L01:
       mov       r11d,[rax]
       mov       ebx,[rax+4]
       mov       esi,r11d
       or        esi,ebx
       test      esi,0FF80FF80
       jne       near ptr M02_L18
       add       rax,8
       add       r10,0FFFFFFFFFFFFFFFC
       cmp       r10,4
       jae       short M02_L01
M02_L02:
       test      r10b,2
       je        short M02_L03
       mov       r11d,[rax]
       test      r11d,0FF80FF80
       jne       near ptr M02_L19
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
       je        near ptr M02_L21
       xor       eax,eax
       xor       r10d,r10d
       mov       r11d,edx
       lea       r11,[rcx+r11*2]
       cmp       edx,8
       jl        short M02_L08
       vbroadcastss xmm0,dword ptr [7FFDF4E78A28]
       vbroadcastss xmm1,dword ptr [7FFDF4E78A2C]
       vbroadcastss xmm2,dword ptr [7FFDF4E78A30]
       lea       rdx,[r11-10]
M02_L06:
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
M02_L07:
       cmp       esi,0FFFF
       jne       near ptr M02_L22
       add       rax,rbx
       cmp       rcx,rdx
       jbe       short M02_L06
M02_L08:
       cmp       rcx,r11
       jae       short M02_L11
       nop       dword ptr [rax]
M02_L09:
       movzx     edx,word ptr [rcx]
       cmp       edx,7F
       ja        near ptr M02_L24
M02_L10:
       add       rcx,2
       cmp       rcx,r11
       jb        short M02_L09
M02_L11:
       mov       [r8],rax
       mov       [r9],r10d
M02_L12:
       mov       rax,rcx
       vzeroupper
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L13:
       vbroadcastss xmm0,dword ptr [7FFDF4E78A34]
       vptest    xmm0,xmmword ptr [rax]
       jne       near ptr M02_L00
       lea       rbx,[r11+r10*2-10]
       add       r11,10
       mov       rax,r11
       and       rax,0FFFFFFFFFFFFFFF0
       vpand     xmm1,xmm0,[rax]
       vptest    xmm1,xmm1
       jne       short M02_L17
M02_L14:
       add       rax,10
       cmp       rax,rbx
       ja        short M02_L17
       vpand     xmm1,xmm0,[rax]
       vptest    xmm1,xmm1
       jne       short M02_L17
       jmp       short M02_L14
M02_L15:
       vbroadcastss ymm0,dword ptr [7FFDF4E78A34]
       vptest    ymm0,ymmword ptr [rax]
       jne       near ptr M02_L00
       lea       rbx,[r11+r10*2-20]
       lea       rax,[r11+20]
       and       rax,0FFFFFFFFFFFFFFE0
       vpand     ymm1,ymm0,[rax]
       vptest    ymm1,ymm1
       jne       short M02_L17
M02_L16:
       add       rax,20
       cmp       rax,rbx
       ja        short M02_L17
       vpand     ymm1,ymm0,[rax]
       vptest    ymm1,ymm1
       je        short M02_L16
M02_L17:
       mov       r11,rax
       sub       r11,rcx
       shr       r11,1
       sub       r10,r11
       jmp       near ptr M02_L00
M02_L18:
       test      r11d,0FF80FF80
       je        short M02_L20
M02_L19:
       test      r11d,0FF80
       jne       near ptr M02_L05
       jmp       near ptr M02_L04
M02_L20:
       mov       r11d,ebx
       add       rax,4
       jmp       short M02_L19
M02_L21:
       xor       eax,eax
       mov       [r8],rax
       mov       [r9],eax
       jmp       near ptr M02_L12
M02_L22:
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
       jne       near ptr M02_L25
       cmp       esi,0FFFF
       jbe       short M02_L23
       movzx     esi,si
       add       rbx,0FFFFFFFFFFFFFFFE
       add       rcx,0FFFFFFFFFFFFFFFE
M02_L23:
       popcnt    esi,esi
       sub       r10d,esi
       sub       rax,rsi
       sub       rax,rsi
       mov       esi,0FFFF
       jmp       near ptr M02_L07
M02_L24:
       lea       ebx,[rdx+1F800]
       shr       ebx,10
       add       rax,rbx
       add       edx,0FFFF2800
       cmp       edx,7FF
       ja        near ptr M02_L10
       add       rax,0FFFFFFFFFFFFFFFE
       mov       rdx,r11
       sub       rdx,rcx
       cmp       rdx,4
       jb        near ptr M02_L11
       mov       edx,[rcx]
       add       edx,23FF2800
       test      edx,0FC00FC00
       jne       near ptr M02_L11
       dec       r10d
       add       rax,2
       add       rcx,2
       jmp       near ptr M02_L10
M02_L25:
       add       rcx,0FFFFFFFFFFFFFFF0
       cmp       rcx,r11
       jae       near ptr M02_L11
       jmp       near ptr M02_L09
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
       mov       rcx,1B22A000C90
       mov       rdi,[rcx]
       mov       [rsp+40],rdi
       lea       ecx,[rbx-1]
       or        ecx,0F
       xor       ebp,ebp
       lzcnt     ebp,ecx
       xor       ebp,1F
       add       ebp,0FFFFFFFD
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],9
       jle       near ptr M03_L14
       mov       rcx,[rcx+240]
       mov       rax,[rcx+48]
       test      rax,rax
       je        near ptr M03_L14
M03_L00:
       mov       rcx,[rax+10]
       test      rcx,rcx
       je        short M03_L01
       mov       eax,[rcx+8]
       cmp       eax,ebp
       jbe       short M03_L01
       mov       eax,ebp
       shl       rax,4
       mov       r14,[rcx+rax+10]
       test      r14,r14
       jne       near ptr M03_L08
M03_L01:
       mov       [rsp+90],rsi
       mov       rcx,[rsi+10]
       mov       eax,[rcx+8]
       cmp       eax,ebp
       jbe       near ptr M03_L22
       mov       eax,ebp
       mov       rcx,[rcx+rax*8+10]
       test      rcx,rcx
       je        near ptr M03_L21
       mov       r14,[rcx+8]
       mov       [rsp+38],r14
       xor       ecx,ecx
       mov       [rsp+48],ecx
       lea       rcx,[rsp+48]
       mov       rax,7FFE866B22B0
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
       cmp       dword ptr [7FFE5454F778],0
       jne       near ptr M03_L16
M03_L02:
       mov       r14,[rsp+38]
       mov       esi,[r14+8]
       test      esi,esi
       jle       near ptr M03_L19
       mov       edi,esi
M03_L03:
       cmp       ebx,esi
       jae       near ptr M03_L27
       mov       ecx,ebx
       mov       r15,[r14+rcx*8+10]
       cmp       [r15],r15b
       xor       r13d,r13d
       mov       rcx,r15
       call      00007FFE54129E20
       test      eax,eax
       je        near ptr M03_L17
M03_L04:
       mov       rcx,[r15+8]
       mov       eax,[r15+10]
       dec       eax
       cmp       [rcx+8],eax
       ja        short M03_L09
M03_L05:
       mov       rcx,r15
       call      00007FFE541E6030
       test      eax,eax
       jne       near ptr M03_L18
M03_L06:
       test      r13,r13
       jne       short M03_L11
       inc       ebx
       cmp       esi,ebx
       je        short M03_L10
M03_L07:
       dec       edi
       jne       short M03_L03
       jmp       near ptr M03_L19
M03_L08:
       mov       eax,ebp
       shl       rax,4
       xor       edx,edx
       mov       [rcx+rax+10],rdx
       cmp       byte ptr [rdi+9D],0
       je        short M03_L13
       jmp       short M03_L15
M03_L09:
       mov       edx,eax
       mov       r13,[rcx+rdx*8+10]
       mov       edx,eax
       xor       r8d,r8d
       mov       [rcx+rdx*8+10],r8
       mov       [r15+10],eax
       jmp       short M03_L05
M03_L10:
       xor       ebx,ebx
       jmp       short M03_L07
M03_L11:
       mov       r14,r13
M03_L12:
       test      r14,r14
       je        near ptr M03_L21
       mov       rdi,[rsp+40]
       cmp       byte ptr [rdi+9D],0
       jne       near ptr M03_L20
M03_L13:
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
M03_L14:
       mov       ecx,9
       call      qword ptr [7FFDF4DDC528]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M03_L00
M03_L15:
       mov       rcx,r14
       call      qword ptr [7FFDF4B0C948]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       ebx,eax
       mov       r15d,[r14+8]
       cmp       [rsi],sil
       mov       rcx,rsi
       call      qword ptr [7FFDF4B0C948]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       [rsp+20],ebp
       mov       edx,ebx
       mov       r8d,r15d
       mov       rcx,rdi
       call      qword ptr [7FFDF4DDD950]
       jmp       short M03_L13
M03_L16:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M03_L02
M03_L17:
       mov       rcx,r15
       call      qword ptr [7FFDF4DDC888]
       jmp       near ptr M03_L04
M03_L18:
       mov       ecx,eax
       mov       rdx,r15
       call      qword ptr [7FFDF4DDC678]
       jmp       near ptr M03_L06
M03_L19:
       xor       r14d,r14d
       jmp       near ptr M03_L12
M03_L20:
       mov       rcx,r14
       call      qword ptr [7FFDF4B0C948]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       ebx,eax
       mov       esi,[r14+8]
       mov       rcx,[rsp+90]
       call      qword ptr [7FFDF4B0C948]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       [rsp+20],ebp
       mov       edx,ebx
       mov       r8d,esi
       mov       rcx,rdi
       call      qword ptr [7FFDF4DDD950]
       jmp       near ptr M03_L13
M03_L21:
       mov       ecx,10
       shlx      ebx,ecx,ebp
       mov       rsi,[rsp+90]
       jmp       short M03_L24
M03_L22:
       mov       rsi,[rsp+90]
       test      ebx,ebx
       jne       short M03_L23
       mov       rax,1F2BF1862A0
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L23:
       mov       ecx,ebx
       mov       rdx,1F2BF186F28
       call      qword ptr [7FFDF489D800]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
       nop
M03_L24:
       cmp       ebx,800
       jge       short M03_L25
       movsxd    rdx,ebx
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
       jmp       short M03_L26
M03_L25:
       mov       ecx,ebx
       xor       edx,edx
       call      qword ptr [7FFDF4DDD938]
       mov       r14,rax
M03_L26:
       mov       rdi,[rsp+40]
       cmp       byte ptr [rdi+9D],0
       je        near ptr M03_L13
       cmp       [r14],r14b
       mov       rcx,r14
       call      qword ptr [7FFDF4B0C948]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       ebx,eax
       mov       r15d,[r14+8]
       mov       rcx,rsi
       call      qword ptr [7FFDF4B0C948]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       edx,ebx
       mov       r8d,r15d
       mov       rcx,rdi
       call      qword ptr [7FFDF4DDD950]
       mov       r15d,[r14+8]
       mov       rcx,rsi
       call      qword ptr [7FFDF4B0C948]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
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
       call      qword ptr [7FFDF4DDD968]
       jmp       near ptr M03_L13
M03_L27:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 900
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
       mov       rax,7FFDF4D1DC08
       mov       [rbp-60],rax
       lea       rax,[M04_L00]
       mov       [rbp-50],rax
       lea       rax,[rbp-70]
       mov       [rdi+8],rax
       mov       byte ptr [rdi+4],0
       mov       rax,7FFE84603670
       call      rax
M04_L00:
       mov       byte ptr [rdi+4],1
       cmp       dword ptr [7FFE5454F778],0
       je        short M04_L01
       call      qword ptr [7FFE5453D608]; CORINFO_HELP_STOP_FOR_GC
M04_L01:
       mov       rcx,[rbp-68]
       mov       [rdi+8],rcx
       test      eax,eax
       jne       short M04_L02
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
M04_L02:
       mov       ecx,eax
       call      qword ptr [7FFDF4DDDA40]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 186
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
       jb        near ptr M05_L03
       mov       rsi,[rcx]
       mov       rdi,0FF80FF80FF80FF80
       test      rdi,rsi
       mov       rdi,rsi
       jne       near ptr M05_L05
       cmp       rax,40
       jb        near ptr M05_L32
       mov       rbx,rcx
       vmovups   ymm0,[rbx]
       vbroadcastss ymm1,dword ptr [7FFDF4E78240]
       vptest    ymm1,ymm0
       jne       near ptr M05_L30
       mov       rsi,r8
       vpackuswb ymm0,ymm0,ymm0
       vpermq    ymm0,ymm0,0D8
       vmovups   [rsi],xmm0
       mov       edi,10
       test      r8b,10
       jne       short M05_L00
       vmovups   ymm0,[rbx+20]
       vptest    ymm1,ymm0
       jne       short M05_L02
       vpackuswb ymm0,ymm0,ymm0
       vpermq    ymm0,ymm0,0D8
       vmovups   [rsi+10],xmm0
M05_L00:
       mov       rdi,r8
       and       rdi,1F
       neg       rdi
       add       rdi,20
       lea       rbp,[rax-20]
       vmovups   ymm0,[rbx+rdi*2]
       vmovups   ymm2,[rbx+rdi*2+20]
       vpor      ymm3,ymm0,ymm2
       vptest    ymm3,ymm1
       jne       near ptr M05_L31
M05_L01:
       vpackuswb ymm0,ymm0,ymm2
       vpermq    ymm2,ymm0,0D8
       vmovups   [rsi+rdi],ymm2
       add       rdi,20
       cmp       rdi,rbp
       ja        short M05_L02
       vmovups   ymm0,[rbx+rdi*2]
       vmovups   ymm2,[rbx+rdi*2+20]
       vpor      ymm3,ymm0,ymm2
       vptest    ymm3,ymm1
       jne       near ptr M05_L31
       jmp       short M05_L01
M05_L02:
       mov       rbx,rdi
M05_L03:
       sub       rax,rbx
       cmp       rax,4
       jb        near ptr M05_L39
       lea       rsi,[rbx+rax-4]
       mov       rdi,[rcx+rbx*2]
       mov       rbp,0FF80FF80FF80FF80
       test      rbp,rdi
       jne       short M05_L05
M05_L04:
       vmovq     xmm0,rdi
       vpackuswb xmm0,xmm0,xmm0
       vmovd     dword ptr [r8+rbx],xmm0
       add       rbx,4
       cmp       rbx,rsi
       ja        near ptr M05_L39
       mov       rdi,[rcx+rbx*2]
       mov       rbp,0FF80FF80FF80FF80
       test      rbp,rdi
       je        short M05_L04
M05_L05:
       mov       eax,edi
       test      eax,0FF80FF80
       je        near ptr M05_L42
M05_L06:
       test      eax,0FF80
       je        near ptr M05_L43
M05_L07:
       lea       rcx,[rcx+rbx*2]
       add       r8,rbx
       cmp       ebx,edx
       je        near ptr M05_L44
       sub       edx,ebx
       sub       r9d,ebx
       cmp       edx,2
       jl        near ptr M05_L22
       mov       eax,edx
       lea       rax,[rcx+rax*2-4]
       vbroadcastss xmm0,dword ptr [7FFDF4E78240]
M05_L08:
       mov       ebx,[rcx]
M05_L09:
       test      ebx,0FF80FF80
       jne       near ptr M05_L18
       cmp       r9d,2
       jl        near ptr M05_L53
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
       jle       short M05_L15
M05_L10:
       mov       ebx,esi
       shr       ebx,3
       xor       edi,edi
       test      ebx,ebx
       je        short M05_L12
M05_L11:
       vmovups   xmm1,[rcx]
       vptest    xmm1,xmm0
       jne       short M05_L16
       vpackuswb xmm1,xmm1,xmm1
       vmovq     qword ptr [r8],xmm1
       add       rcx,10
       add       r8,8
       inc       edi
       cmp       edi,ebx
       jb        short M05_L11
M05_L12:
       lea       ebx,[rdi*8]
       sub       r9d,ebx
       test      sil,4
       je        short M05_L14
       mov       rbx,[rcx]
       mov       rsi,0FF80FF80FF80FF80
       test      rsi,rbx
       jne       short M05_L17
       vmovq     xmm1,rbx
       vpackuswb xmm1,xmm1,xmm1
       vmovd     dword ptr [r8],xmm1
       add       rcx,8
M05_L13:
       add       r8,4
       add       r9d,0FFFFFFFC
M05_L14:
       cmp       rcx,rax
       jbe       near ptr M05_L08
       jmp       near ptr M05_L21
M05_L15:
       mov       rsi,rbx
       jmp       short M05_L10
M05_L16:
       shl       edi,3
       sub       r9d,edi
       vmovq     rbx,xmm1
       mov       rsi,0FF80FF80FF80FF80
       test      rsi,rbx
       jne       short M05_L17
       vpackuswb xmm2,xmm1,xmm1
       vmovd     dword ptr [r8],xmm2
       add       rcx,8
       add       r8,4
       add       r9d,0FFFFFFFC
       vpextrq   rbx,xmm1,1
M05_L17:
       mov       esi,ebx
       test      esi,0FF80FF80
       je        near ptr M05_L45
       mov       ebx,esi
M05_L18:
       test      ebx,0FF80
       jne       short M05_L19
       test      r9d,r9d
       je        near ptr M05_L57
       mov       [r8],bl
       add       rcx,2
       inc       r8
       dec       r9d
       cmp       rcx,rax
       ja        short M05_L21
       mov       ebx,[rcx]
M05_L19:
       test      ebx,0F800
       jne       near ptr M05_L29
       lea       esi,[rbx-800000]
       cmp       esi,77FFFFF
       ja        near ptr M05_L27
M05_L20:
       cmp       r9d,4
       jl        near ptr M05_L53
       mov       esi,ebx
       shr       esi,6
       and       esi,1F001F
       shl       ebx,8
       and       ebx,3F003F00
       add       ebx,esi
       add       ebx,80C080C0
       mov       [r8],ebx
       add       rcx,4
       add       r8,4
       add       r9d,0FFFFFFFC
       cmp       rcx,rax
       jbe       near ptr M05_L46
M05_L21:
       sub       rax,rcx
       mov       rdx,rax
       shr       rdx,3F
       add       rdx,rax
       sar       rdx,1
       add       edx,2
M05_L22:
       test      edx,edx
       je        short M05_L25
       movzx     eax,word ptr [rcx]
M05_L23:
       cmp       eax,7F
       ja        near ptr M05_L54
       test      r9d,r9d
       je        near ptr M05_L57
       mov       [r8],al
       add       rcx,2
       inc       r8
M05_L24:
       cmp       edx,1
       jg        near ptr M05_L57
M05_L25:
       xor       eax,eax
M05_L26:
       mov       [r10],rcx
       mov       [r11],r8
       vzeroupper
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M05_L27:
       cmp       r9d,2
       jl        near ptr M05_L57
       lea       esi,[rbx*4]
       and       esi,1F00
       mov       edi,ebx
       and       edi,3F
       lea       esi,[rsi+rdi+0C080]
       movbe     [r8],si
       cmp       ebx,800000
       jae       near ptr M05_L47
       cmp       r9d,3
       jl        near ptr M05_L52
       shr       ebx,10
       mov       [r8+2],bl
       add       rcx,4
       add       r8,3
       add       r9d,0FFFFFFFD
       jmp       near ptr M05_L14
M05_L28:
       cmp       r9d,3
       jl        near ptr M05_L57
       lea       esi,[rbx*4]
       and       esi,3F00
       movzx     edi,bx
       shr       edi,0C
       add       esi,edi
       add       esi,80E0
       mov       [r8],si
       mov       esi,ebx
       and       esi,3F
       or        esi,0FFFFFF80
       mov       [r8+2],sil
       add       rcx,2
       add       r8,3
       add       r9d,0FFFFFFFD
       cmp       ebx,800000
       jae       near ptr M05_L48
       test      r9d,r9d
       je        near ptr M05_L57
       shr       ebx,10
       mov       [r8],bl
       add       rcx,2
       inc       r8
       dec       r9d
       cmp       rcx,rax
       ja        near ptr M05_L21
       mov       ebx,[rcx]
       test      ebx,0F800
       je        near ptr M05_L09
M05_L29:
       lea       esi,[rbx-0D800]
       test      esi,0F800
       je        near ptr M05_L49
       test      ebx,0F8000000
       je        near ptr M05_L28
       lea       esi,[rbx+28000000]
       cmp       esi,8000000
       jb        near ptr M05_L28
       cmp       r9d,6
       jl        near ptr M05_L28
       lea       esi,[rbx*4]
       and       esi,3F00
       mov       edi,ebx
       and       edi,3F
       shl       edi,10
       or        esi,edi
       mov       edi,ebx
       shr       edi,4
       and       edi,0F000000
       mov       ebp,ebx
       shr       ebp,0C
       and       ebp,0F
       or        edi,ebp
       add       esi,edi
       add       esi,0E08080E0
       mov       [r8],esi
       mov       esi,ebx
       shr       esi,16
       and       esi,3F
       shr       ebx,8
       and       ebx,3F00
       add       ebx,esi
       add       ebx,8080
       mov       [r8+4],bx
       add       rcx,4
       add       r8,6
       add       r9d,0FFFFFFFA
       cmp       rcx,rax
       ja        near ptr M05_L21
       mov       ebx,[rcx]
       test      ebx,0F800
       jne       near ptr M05_L29
       jmp       near ptr M05_L09
M05_L30:
       xor       ebx,ebx
       jmp       near ptr M05_L03
M05_L31:
       vptest    ymm1,ymm0
       jne       near ptr M05_L02
       vpackuswb ymm0,ymm0,ymm0
       vpermq    ymm0,ymm0,0D8
       vmovups   [rsi+rdi],xmm0
       add       rdi,10
       jmp       near ptr M05_L02
M05_L32:
       mov       rbx,rcx
       vmovups   xmm0,[rbx]
       vptest    xmm0,xmmword ptr [7FFDF4E78250]
       je        short M05_L33
       xor       ebx,ebx
       jmp       near ptr M05_L38
M05_L33:
       mov       rsi,r8
       vpackuswb xmm0,xmm0,xmm0
       vmovsd    qword ptr [rsi],xmm0
       mov       edi,8
       test      r8b,8
       jne       short M05_L34
       vmovups   xmm0,[rbx+10]
       vptest    xmm0,xmmword ptr [7FFDF4E78250]
       jne       short M05_L36
       vpackuswb xmm0,xmm0,xmm0
       vmovsd    qword ptr [rsi+8],xmm0
M05_L34:
       mov       rdi,r8
       and       rdi,0F
       neg       rdi
       add       rdi,10
       lea       rbp,[rax-10]
M05_L35:
       vmovups   xmm0,[rbx+rdi*2]
       vmovups   xmm1,[rbx+rdi*2+10]
       vpor      xmm2,xmm0,xmm1
       vptest    xmm2,xmmword ptr [7FFDF4E78250]
       jne       short M05_L37
       vpackuswb xmm0,xmm0,xmm1
       vmovups   [rsi+rdi],xmm0
       add       rdi,10
       cmp       rdi,rbp
       jbe       short M05_L35
M05_L36:
       mov       rbx,rdi
       jmp       short M05_L38
M05_L37:
       vptest    xmm0,xmmword ptr [7FFDF4E78250]
       jne       short M05_L36
       vpackuswb xmm0,xmm0,xmm0
       vmovsd    qword ptr [rsi+rdi],xmm0
       add       rdi,8
       jmp       short M05_L36
M05_L38:
       jmp       near ptr M05_L03
M05_L39:
       test      al,2
       je        short M05_L40
       mov       esi,[rcx+rbx*2]
       test      esi,0FF80FF80
       jne       short M05_L41
       mov       rbp,rax
       mov       eax,esi
       mov       rsi,rbp
       lea       rdi,[r8+rbx]
       mov       [rdi],al
       shr       eax,10
       mov       [rdi+1],al
       add       rbx,2
       mov       rax,rsi
M05_L40:
       test      al,1
       je        near ptr M05_L07
       movzx     eax,word ptr [rcx+rbx*2]
       cmp       eax,7F
       ja        near ptr M05_L07
       jmp       short M05_L43
M05_L41:
       mov       eax,esi
       jmp       near ptr M05_L06
M05_L42:
       lea       rsi,[r8+rbx]
       mov       [rsi],al
       shr       eax,10
       mov       [rsi+1],al
       shr       rdi,20
       mov       eax,edi
       add       rbx,2
       jmp       near ptr M05_L06
M05_L43:
       mov       [r8+rbx],al
       inc       rbx
       jmp       near ptr M05_L07
M05_L44:
       mov       [r10],rcx
       mov       [r11],r8
       xor       eax,eax
       vzeroupper
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M05_L45:
       mov       edi,esi
       shr       edi,8
       or        edi,esi
       mov       [r8],di
       add       rcx,4
       add       r8,2
       add       r9d,0FFFFFFFE
       shr       rbx,20
       mov       esi,ebx
       mov       ebx,esi
       jmp       near ptr M05_L18
M05_L46:
       mov       ebx,[rcx]
       lea       esi,[rbx-80]
       movzx     esi,si
       cmp       esi,780
       jge       near ptr M05_L09
       lea       esi,[rbx-800000]
       cmp       esi,77FFFFF
       jbe       near ptr M05_L20
       jmp       near ptr M05_L27
M05_L47:
       add       rcx,2
       add       r8,2
       add       r9d,0FFFFFFFE
       cmp       rcx,rax
       ja        near ptr M05_L21
       mov       ebx,[rcx]
       jmp       near ptr M05_L29
M05_L48:
       cmp       rcx,rax
       ja        near ptr M05_L21
       mov       ebx,[rcx]
       jmp       near ptr M05_L18
M05_L49:
       lea       esi,[rbx+23FF2800]
       test      esi,0FC00FC00
       jne       short M05_L50
       cmp       r9d,4
       jl        near ptr M05_L57
       jmp       short M05_L51
M05_L50:
       mov       eax,3
       jmp       near ptr M05_L26
M05_L51:
       add       ebx,40
       mov       esi,ebx
       and       esi,3
       shl       esi,14
       or        esi,808080F0
       mov       edi,ebx
       and       edi,3F0700
       bswap     edi
       rol       edi,10
       or        esi,edi
       mov       edi,ebx
       shr       edi,6
       and       edi,0F0000
       or        esi,edi
       and       ebx,0FC
       shl       ebx,6
       or        ebx,esi
       mov       [r8],ebx
       add       rcx,4
       jmp       near ptr M05_L13
M05_L52:
       add       rcx,2
       add       r8,2
       jmp       near ptr M05_L57
M05_L53:
       movzx     eax,bx
       jmp       near ptr M05_L23
M05_L54:
       cmp       eax,800
       jae       short M05_L55
       cmp       r9d,2
       jl        near ptr M05_L57
       mov       r9d,eax
       and       r9d,3F
       or        r9d,0FFFFFF80
       mov       [r8+1],r9b
       shr       eax,6
       or        eax,0FFFFFFC0
       mov       [r8],al
       add       rcx,2
       add       r8,2
       jmp       near ptr M05_L24
M05_L55:
       lea       ebx,[rax-0D800]
       cmp       ebx,7FF
       jbe       short M05_L56
       cmp       r9d,3
       jl        short M05_L57
       mov       r9d,eax
       and       r9d,3F
       or        r9d,0FFFFFF80
       mov       [r8+2],r9b
       mov       r9d,eax
       shr       r9d,6
       and       r9d,3F
       or        r9d,0FFFFFF80
       mov       [r8+1],r9b
       shr       eax,0C
       or        eax,0FFFFFFE0
       mov       [r8],al
       add       rcx,2
       add       r8,3
       jmp       near ptr M05_L24
M05_L56:
       cmp       eax,0DBFF
       ja        near ptr M05_L50
       mov       eax,2
       jmp       near ptr M05_L26
M05_L57:
       mov       eax,1
       jmp       near ptr M05_L26
; Total bytes of code 2025
```
```assembly
; System.ReadOnlySpan`1[[System.Byte, System.Private.CoreLib]]..ctor(Byte[])
       test      rdx,rdx
       je        short M06_L01
       lea       rax,[rdx+10]
       mov       [rcx],rax
       mov       eax,[rdx+8]
       mov       [rcx+8],eax
M06_L00:
       ret
M06_L01:
       xor       eax,eax
       mov       [rcx],rax
       mov       [rcx+8],rax
       jmp       short M06_L00
; Total bytes of code 30
```
```assembly
; System.Security.Cryptography.AesGcm..ctor(System.ReadOnlySpan`1<Byte>, Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rsi,rcx
       mov       rbx,rdx
       mov       edi,r8d
       mov       ecx,[rbx+8]
       call      qword ptr [7FFDF4D3CFF0]; System.Security.Cryptography.AesAEAD.CheckKeySize(Int32)
       mov       rdx,1B22A001EC0
       mov       rdx,[rdx]
       lea       r8,[rsp+28]
       mov       ecx,edi
       call      qword ptr [7FFDF4D37D20]; System.Security.Cryptography.KeySizeHelpers.IsLegalSize(Int32, System.Security.Cryptography.KeySizes, Boolean ByRef)
       test      eax,eax
       je        short M07_L00
       mov       byte ptr [rsi+10],1
       mov       [rsi+14],edi
       call      qword ptr [7FFDF4D3D020]; Internal.Cryptography.BCryptAeadHandleCache.get_AesGcm()
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFDF4D3C0A8]; Interop+BCrypt.BCryptImportKey(Internal.NativeCrypto.SafeAlgorithmHandle, System.ReadOnlySpan`1<Byte>)
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M07_L00:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFDF4DDDA58]
       mov       rsi,rax
       mov       ecx,4BD5
       mov       rdx,7FFDF4B1DB10
       call      qword ptr [7FFDF4897738]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFDF4A65E60]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 173
```
```assembly
; System.Span`1[[System.Byte, System.Private.CoreLib]]..ctor(Byte[], Int32, Int32)
       sub       rsp,28
       test      rdx,rdx
       je        short M08_L01
       mov       r8d,r8d
       mov       eax,r9d
       add       rax,r8
       mov       r10d,[rdx+8]
       cmp       rax,r10
       ja        short M08_L02
       add       rdx,10
       add       rdx,r8
       mov       [rcx],rdx
       mov       [rcx+8],r9d
M08_L00:
       add       rsp,28
       ret
M08_L01:
       or        r8d,r9d
       jne       short M08_L02
       xor       eax,eax
       mov       [rcx],rax
       mov       [rcx+8],rax
       jmp       short M08_L00
M08_L02:
       call      qword ptr [7FFDF47B7138]
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
       jne       near ptr M10_L09
       mov       rax,1B22A001EB8
       mov       r10,[rax]
       mov       r9d,[r10+10]
       test      r9d,r9d
       je        near ptr M10_L10
       mov       r11d,[r10+8]
       cmp       r8d,r11d
       jl        near ptr M10_L11
       cmp       r8d,[r10+0C]
       jg        near ptr M10_L11
       mov       edx,r8d
       sub       edx,r11d
       mov       eax,edx
       cdq
       idiv      r9d
       test      edx,edx
       jne       near ptr M10_L11
M10_L00:
       movzx     edx,byte ptr [r14+10]
       mov       eax,[r14+14]
       mov       [rbp-10C],eax
       test      edx,edx
       jne       short M10_L01
       mov       rdx,1B22A001EC0
       mov       rdx,[rdx]
       lea       r8,[rbp-40]
       call      qword ptr [7FFDF4D37D20]; System.Security.Cryptography.KeySizeHelpers.IsLegalSize(Int32, System.Security.Cryptography.KeySizes, Boolean ByRef)
       test      eax,eax
       jne       short M10_L02
       jmp       near ptr M10_L13
M10_L01:
       cmp       ecx,eax
       jne       near ptr M10_L12
M10_L02:
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
       jne       near ptr M10_L07
M10_L03:
       lea       r9,[rcx+10]
       lea       edx,[rax+4]
       mov       [rbp-0D0],eax
       lock cmpxchg [r9],edx
       cmp       eax,[rbp-0D0]
       jne       near ptr M10_L06
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
       mov       rax,7FFDF4D1E258
       mov       [rbp-0F8],rax
       lea       rax,[M10_L04]
       mov       [rbp-0E8],rax
       lea       rax,[rbp-108]
       mov       [r12+8],rax
       mov       byte ptr [r12+4],0
       mov       rax,7FFE846015B0
       call      rax
M10_L04:
       mov       byte ptr [r12+4],1
       cmp       dword ptr [7FFE5454F778],0
       je        short M10_L05
       call      qword ptr [7FFE5453D608]; CORINFO_HELP_STOP_FOR_GC
M10_L05:
       mov       rcx,[rbp-100]
       mov       [r12+8],rcx
       mov       [rbp-0CC],eax
       jmp       short M10_L08
M10_L06:
       mov       eax,[rcx+10]
       test      al,1
       je        near ptr M10_L03
M10_L07:
       call      qword ptr [7FFDF4DDC8A0]
       int       3
M10_L08:
       call      M10_L15
       nop
       cmp       dword ptr [rbp-0CC],0
       jne       near ptr M10_L14
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
M10_L09:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFDF4DDDB60]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFDF489FF60]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M10_L10:
       mov       r11d,[r10+8]
       cmp       r11d,r8d
       je        near ptr M10_L00
M10_L11:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFDF4DDDB78]
       mov       rsi,rax
       mov       ecx,4BFB
       mov       rdx,7FFDF4B1DB10
       call      qword ptr [7FFDF4897738]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFDF4A65E60]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M10_L12:
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFDF4DDDB90]
       mov       rsi,rax
       mov       edi,[rbp-10C]
       mov       [rbx+8],edi
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFDF4DDDBA8]
       mov       rbx,rax
       mov       ecx,4C31
       mov       rdx,7FFDF4B1DB10
       call      qword ptr [7FFDF4897738]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FFDF4A65E60]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M10_L13:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      qword ptr [7FFDF4DDDA58]
       mov       rbx,rax
       mov       ecx,4C31
       mov       rdx,7FFDF4B1DB10
       call      qword ptr [7FFDF4897738]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,r14
       call      qword ptr [7FFDF4A65E60]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
       int       3
M10_L14:
       mov       ecx,[rbp-0CC]
       call      qword ptr [7FFDF4DDDA40]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M10_L15:
       sub       rsp,58
       vzeroupper
       cmp       byte ptr [rbp-110],0
       je        near ptr M10_L29
       mov       rbx,[rbp-118]
       mov       rcx,[rbp-118]
       cmp       [rcx],cl
       mov       esi,[rbx+10]
       test      esi,0FFFFFFFC
       je        short M10_L24
M10_L16:
       mov       ecx,esi
       and       ecx,0FFFFFFFD
       cmp       ecx,4
       jne       short M10_L21
       jmp       short M10_L18
M10_L17:
       mov       esi,[rbx+10]
       test      esi,0FFFFFFFC
       jne       short M10_L16
       jmp       short M10_L24
M10_L18:
       cmp       byte ptr [rbx+14],0
       je        short M10_L21
       mov       rcx,offset MT_Internal.NativeCrypto.SafeKeyHandle
       cmp       [rbx],rcx
       jne       short M10_L19
       cmp       qword ptr [rbx+8],0
       sete      dil
       movzx     edi,dil
       jmp       short M10_L20
M10_L19:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       edi,eax
M10_L20:
       test      edi,edi
       sete      cl
       movzx     ecx,cl
       jmp       short M10_L22
M10_L21:
       xor       ecx,ecx
M10_L22:
       lea       edx,[rsi-4]
       mov       eax,esi
       and       eax,0FFFFFFFC
       cmp       eax,4
       jne       short M10_L23
       or        edx,1
M10_L23:
       lea       r8,[rbx+10]
       mov       eax,esi
       lock cmpxchg [r8],edx
       cmp       eax,esi
       jne       short M10_L17
       jmp       short M10_L25
M10_L24:
       mov       rcx,rbx
       call      qword ptr [7FFDF4DDC8A0]
       int       3
M10_L25:
       test      ecx,ecx
       je        short M10_L29
       call      00007FFE54236260
       mov       esi,eax
       mov       rcx,offset MT_Internal.NativeCrypto.SafeKeyHandle
       cmp       [rbx],rcx
       jne       short M10_L27
       cmp       qword ptr [rbx+18],0
       je        short M10_L26
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF4D3CED0]; System.Runtime.InteropServices.SafeHandle.DangerousRelease()
       xor       ecx,ecx
       mov       [rbx+18],rcx
M10_L26:
       mov       rcx,[rbx+8]
       call      00007FFDF4608E10
       jmp       short M10_L28
M10_L27:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
M10_L28:
       mov       ecx,esi
       call      00007FFE54236280
M10_L29:
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
       jne       short M11_L01
       mov       rcx,rbx
       mov       edx,1
       call      qword ptr [7FFDF461C798]; System.Runtime.InteropServices.SafeHandle.InternalRelease(Boolean)
M11_L00:
       mov       rcx,rbx
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFDF4617B10]; System.GC.SuppressFinalize(System.Object)
M11_L01:
       mov       rcx,rbx
       mov       edx,1
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       jmp       short M11_L00
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
       ja        short M12_L00
       add       rax,[rcx]
       mov       [rdx],rax
       mov       [rdx+8],r9d
       mov       rax,rdx
       add       rsp,28
       ret
M12_L00:
       call      qword ptr [7FFDF47B7138]
       int       3
; Total bytes of code 47
```
```assembly
; System.Span`1[[System.Byte, System.Private.CoreLib]].CopyTo(System.Span`1<Byte>)
       sub       rsp,28
       mov       rax,rdx
       mov       r8d,[rcx+8]
       cmp       r8d,[rax+8]
       ja        short M13_L00
       mov       rdx,[rcx]
       mov       rcx,[rax]
       call      qword ptr [7FFDF4615818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       nop
       add       rsp,28
       ret
M13_L00:
       call      qword ptr [7FFDF4B0C2A0]
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
       je        near ptr M14_L20
       test      ebx,ebx
       jl        near ptr M14_L21
       test      esi,esi
       jl        near ptr M14_L22
       mov       ebp,[rcx+8]
       sub       ebp,ebx
       cmp       esi,ebp
       jl        short M14_L00
       cmp       esi,ebp
       jg        near ptr M14_L05
M14_L00:
       mov       eax,esi
       mov       edx,ebx
       add       rax,rdx
       mov       edx,[rcx+8]
       cmp       rax,rdx
       ja        near ptr M14_L23
       mov       eax,esi
       lea       rbp,[rcx+rax+10]
       cmp       edi,1
       ja        near ptr M14_L24
       test      ebx,ebx
       je        near ptr M14_L25
       cmp       edi,1
       sete      dil
       movzx     edi,dil
       lea       ecx,[rbx+2]
       mov       eax,0AAAAAAAB
       mov       edx,ecx
       imul      rax,rdx
       shr       rax,21
       shl       eax,2
       je        near ptr M14_L26
       test      edi,edi
       jne       near ptr M14_L27
M14_L01:
       test      eax,eax
       jl        near ptr M14_L28
M14_L02:
       movsxd    rdx,eax
       mov       rcx,offset MT_System.String
       call      00007FFE54238D20
       mov       rsi,rax
       test      edi,edi
       jne       near ptr M14_L31
       cmp       ebx,10
       jl        near ptr M14_L31
       lea       rcx,[rsi+0C]
       mov       edx,[rsi+8]
       mov       edx,[rsi+8]
       imul      r9d,edx,2
       jo        near ptr M14_L34
       mov       [rsp+38],rbp
       mov       [rsp+30],rcx
       mov       r8,rcx
       cmp       ebx,5FFFFFFD
       jg        near ptr M14_L29
       lea       eax,[rbx+2]
       mov       r10d,0AAAAAAAB
       imul      rax,r10
       shr       rax,21
       shl       eax,2
       cmp       eax,r9d
       jg        near ptr M14_L29
       mov       eax,ebx
M14_L03:
       mov       r9,rbp
       mov       r10,r8
       mov       r11d,ebx
       add       r11,r9
       mov       edi,eax
       add       rdi,r9
       cmp       eax,10
       jl        near ptr M14_L09
       lea       rax,[rdi-20]
       cmp       rax,r9
       jb        near ptr M14_L07
       vmovups   ymm0,[7FFDF4E82B60]
       vbroadcastf128 ymm1,xmmword ptr [7FFDF4E82B80]
       vbroadcastss ymm2,dword ptr [7FFDF4E82B90]
       vbroadcastss ymm3,dword ptr [7FFDF4E82B94]
       vbroadcastss ymm4,dword ptr [7FFDF4E82B98]
       vbroadcastss ymm5,dword ptr [7FFDF4E82B9C]
       vbroadcastss ymm6,dword ptr [7FFDF4E82BA0]
       vbroadcastss ymm7,dword ptr [7FFDF4E82BA4]
       vmovups   ymm8,[7FFDF4E82BC0]
       vpermd    ymm8,ymm8,[rbp]
       add       rbp,0FFFFFFFFFFFFFFFC
       xchg      ax,ax
M14_L04:
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
       ja        short M14_L06
       vmovups   ymm8,[rbp]
       jmp       short M14_L04
M14_L05:
       mov       ecx,1149
       mov       rdx,7FFDF4554000
       call      qword ptr [7FFDF4897738]
       mov       r8,rax
       mov       edx,ebp
       mov       ecx,esi
       call      qword ptr [7FFDF4DDDBD8]
       int       3
M14_L06:
       lea       r9,[rbp+4]
       mov       r10,r8
       cmp       r9,r11
       je        near ptr M14_L12
M14_L07:
       lea       rax,[rdi-10]
       cmp       rax,r9
       jb        near ptr M14_L09
       vmovups   xmm0,[7FFDF4E82BE0]
       vmovups   xmm1,[7FFDF4E82B80]
       vbroadcastss xmm2,dword ptr [7FFDF4E82B90]
       vbroadcastss xmm3,dword ptr [7FFDF4E82B94]
       vbroadcastss xmm4,dword ptr [7FFDF4E82B98]
       vbroadcastss xmm5,dword ptr [7FFDF4E82B9C]
       vbroadcastss xmm6,dword ptr [7FFDF4E82BA0]
       vbroadcastss xmm7,dword ptr [7FFDF4E82BA4]
M14_L08:
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
       jbe       short M14_L08
       cmp       r9,r11
       je        near ptr M14_L12
M14_L09:
       mov       r8,7FFE3E905470
       add       rdi,0FFFFFFFFFFFFFFFE
       cmp       r9,rdi
       jae       short M14_L11
M14_L10:
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
       jb        short M14_L10
M14_L11:
       lea       rax,[rdi+2]
       cmp       rax,r11
       jne       short M14_L12
       lea       rax,[r9+1]
       cmp       rax,r11
       je        near ptr M14_L30
       lea       rax,[r9+2]
       cmp       rax,r11
       jne       short M14_L12
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
M14_L12:
       xor       r9d,r9d
       mov       [rsp+38],r9
       mov       [rsp+30],r9
       mov       r9d,edx
       lea       r9,[rcx+r9*2]
       mov       edx,edx
       add       rdx,rcx
       lea       r8,[rcx+1F]
       cmp       rdx,r8
       jbe       short M14_L14
M14_L13:
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
       ja        short M14_L13
M14_L14:
       lea       r8,[rcx+0F]
       cmp       rdx,r8
       jbe       short M14_L16
M14_L15:
       add       rdx,0FFFFFFFFFFFFFFF0
       add       r9,0FFFFFFFFFFFFFFE0
       vmovups   xmm0,[rdx]
       vpmovzxbw xmm1,xmm0
       vpsrldq   xmm0,xmm0,8
       vpmovzxbw xmm0,xmm0
       vmovups   [r9],xmm1
       vmovups   [r9+10],xmm0
       cmp       rdx,r8
       ja        short M14_L15
M14_L16:
       add       rcx,3
       cmp       rdx,rcx
       jbe       short M14_L18
M14_L17:
       add       r9,0FFFFFFFFFFFFFFF8
       add       rdx,0FFFFFFFFFFFFFFFC
       vmovd     xmm0,dword ptr [rdx]
       vpmovzxbw xmm0,xmm0
       vmovq     qword ptr [r9],xmm0
       cmp       rdx,rcx
       ja        short M14_L17
M14_L18:
       mov       rax,rsi
M14_L19:
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
M14_L20:
       mov       ecx,1139
       mov       rdx,7FFDF4554000
       call      qword ptr [7FFDF4897738]
       mov       rcx,rax
       call      qword ptr [7FFDF4DD7B10]
       int       3
M14_L21:
       mov       ecx,0B3
       mov       rdx,7FFDF4554000
       call      qword ptr [7FFDF4897738]
       mov       rdx,rax
       mov       ecx,ebx
       call      qword ptr [7FFDF4DD7AE0]
       int       3
M14_L22:
       mov       ecx,1149
       mov       rdx,7FFDF4554000
       call      qword ptr [7FFDF4897738]
       mov       rdx,rax
       mov       ecx,esi
       call      qword ptr [7FFDF4DD7AE0]
       int       3
M14_L23:
       call      qword ptr [7FFDF47B7138]
       int       3
M14_L24:
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFDF4DDD008]
       mov       rsi,rax
       mov       [rbx+8],edi
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFDF4DDCE88]
       mov       rbx,rax
       mov       ecx,1157
       mov       rdx,7FFDF4554000
       call      qword ptr [7FFDF4897738]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FFDF4A65E60]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M14_L25:
       mov       rax,1F2BF180008
       jmp       near ptr M14_L19
M14_L26:
       xor       eax,eax
       jmp       near ptr M14_L02
M14_L27:
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
       jmp       near ptr M14_L01
M14_L28:
       mov       rcx,offset MT_System.OutOfMemoryException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       call      qword ptr [7FFDF4DDD038]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M14_L29:
       sar       r9d,2
       lea       eax,[r9+r9*2]
       jmp       near ptr M14_L03
M14_L30:
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
       jmp       near ptr M14_L12
M14_L31:
       mov       [rsp+48],rbp
       mov       rdx,rbp
       test      rsi,rsi
       jne       short M14_L32
       xor       ecx,ecx
       jmp       short M14_L33
M14_L32:
       lea       rcx,[rsi+0C]
       mov       [rsp+40],rcx
       mov       rcx,[rsp+40]
M14_L33:
       mov       [rsp+20],edi
       mov       r9d,ebx
       xor       r8d,r8d
       call      qword ptr [7FFDF4DDD020]
       xor       eax,eax
       mov       [rsp+40],rax
       mov       [rsp+48],rax
       jmp       near ptr M14_L18
M14_L34:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 1643
```
```assembly
; System.Security.Cryptography.CryptographicOperations.ZeroMemory(System.Span`1<Byte>)
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE5240AC48]; Precode of System.Span`1[[System.Byte, System.Private.CoreLib]].Clear()
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
       je        near ptr M16_L17
       mov       ecx,[rbx+8]
       dec       ecx
       or        ecx,0F
       xor       ebp,ebp
       lzcnt     ebp,ecx
       xor       ebp,1F
       add       ebp,0FFFFFFFD
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],9
       jle       near ptr M16_L15
       mov       rcx,[rcx+240]
       mov       rax,[rcx+48]
       test      rax,rax
       je        near ptr M16_L15
M16_L00:
       mov       r14,[rax+10]
       test      r14,r14
       je        near ptr M16_L16
M16_L01:
       xor       r15d,r15d
       mov       r13d,1
       cmp       [r14+8],ebp
       jbe       near ptr M16_L11
       mov       r15d,1
       test      sil,sil
       je        short M16_L02
       mov       rcx,[rbx]
       movzx     edx,word ptr [rcx]
       mov       eax,[rbx+8]
       imul      rdx,rax
       lea       rax,[rbx+10]
       test      dword ptr [rcx],1000000
       jne       near ptr M16_L18
       mov       rcx,rax
       call      qword ptr [7FFDF46157E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
M16_L02:
       mov       ecx,10
       shlx      ecx,ecx,ebp
       cmp       [rbx+8],ecx
       jne       near ptr M16_L19
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
       je        near ptr M16_L14
       mov       rcx,[rdi+10]
       cmp       ebp,[rcx+8]
       jae       near ptr M16_L30
       mov       edx,ebp
       mov       rax,[rcx+rdx*8+10]
       test      rax,rax
       je        near ptr M16_L20
       mov       [rsp+0A0],rdi
M16_L03:
       mov       r13,[rax+8]
       mov       [rsp+38],r13
       xor       ecx,ecx
       mov       [rsp+50],ecx
       lea       rcx,[rsp+50]
       mov       rax,7FFE866B22B0
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
       cmp       dword ptr [7FFE5454F778],0
       jne       near ptr M16_L21
M16_L04:
       mov       r13,[rsp+38]
       mov       esi,[r13+8]
       test      esi,esi
       jle       near ptr M16_L26
       mov       edi,esi
M16_L05:
       cmp       ebx,esi
       jae       near ptr M16_L30
       mov       ecx,ebx
       mov       r14,[r13+rcx*8+10]
       cmp       [r14],r14b
       xor       r12d,r12d
       mov       rcx,r14
       call      00007FFE54129E20
       test      eax,eax
       je        near ptr M16_L22
M16_L06:
       mov       rcx,[r14+8]
       mov       eax,[r14+10]
       mov       [rsp+4C],eax
       cmp       [rcx+8],eax
       jbe       short M16_L08
       test      eax,eax
       je        near ptr M16_L13
M16_L07:
       mov       edx,eax
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,[rsp+40]
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12d,[rsp+4C]
       inc       r12d
       mov       [r14+10],r12d
       mov       r12d,1
M16_L08:
       mov       rcx,r14
       call      00007FFE541E6030
       test      eax,eax
       jne       near ptr M16_L23
M16_L09:
       test      r12d,r12d
       je        near ptr M16_L24
       mov       r13d,1
M16_L10:
       mov       rbx,[rsp+0A8]
       mov       rdi,[rsp+0A0]
M16_L11:
       mov       rcx,1B22A000C90
       mov       rsi,[rcx]
       cmp       byte ptr [rsi+9D],0
       jne       near ptr M16_L27
M16_L12:
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
M16_L13:
       xor       edx,edx
       mov       [r14+14],edx
       jmp       near ptr M16_L07
M16_L14:
       mov       rbx,[rsp+0A8]
       jmp       short M16_L11
M16_L15:
       mov       ecx,9
       call      qword ptr [7FFDF4DDC528]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M16_L00
M16_L16:
       mov       rcx,rdi
       call      qword ptr [7FFDF4D3C6F0]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
       mov       r14,rax
       jmp       near ptr M16_L01
M16_L17:
       mov       ecx,2
       call      qword ptr [7FFDF489C1C8]
       int       3
M16_L18:
       shr       rdx,3
       mov       rcx,rax
       call      qword ptr [7FFDF4DDDA10]
       jmp       near ptr M16_L02
M16_L19:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       call      qword ptr [7FFDF4DDD9E0]
       mov       r13,rax
       mov       ecx,29B
       mov       rdx,7FFDF4554000
       call      qword ptr [7FFDF4897738]
       mov       r8,rax
       mov       rdx,r13
       mov       rcx,r15
       call      qword ptr [7FFDF4A65E60]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
       int       3
M16_L20:
       mov       [rsp+0A0],rdi
       mov       rcx,rdi
       mov       edx,ebp
       call      qword ptr [7FFDF4D3C810]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].CreatePerCorePartitions(Int32)
       jmp       near ptr M16_L03
M16_L21:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M16_L04
M16_L22:
       mov       rcx,r14
       call      qword ptr [7FFDF4DDC888]
       jmp       near ptr M16_L06
M16_L23:
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FFDF4DDC678]
       jmp       near ptr M16_L09
M16_L24:
       inc       ebx
       cmp       esi,ebx
       jne       short M16_L25
       xor       ebx,ebx
M16_L25:
       dec       edi
       jne       near ptr M16_L05
M16_L26:
       xor       r13d,r13d
       jmp       near ptr M16_L10
M16_L27:
       cmp       dword ptr [rbx+8],0
       je        near ptr M16_L12
       mov       rcx,rbx
       call      qword ptr [7FFDF4B0C948]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r14d,eax
       mov       r12d,[rbx+8]
       cmp       [rdi],dil
       mov       rcx,rdi
       call      qword ptr [7FFDF4B0C948]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,rsi
       mov       r8d,r14d
       mov       r9d,r12d
       mov       edx,3
       call      qword ptr [7FFDF4DDD6F8]
       test      r13d,r15d
       jne       near ptr M16_L12
       mov       rcx,rbx
       call      qword ptr [7FFDF4B0C948]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r14d,eax
       mov       ebx,[rbx+8]
       mov       rcx,rdi
       call      qword ptr [7FFDF4B0C948]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       test      r15d,r15d
       jne       short M16_L28
       mov       ecx,0FFFFFFFF
       mov       edx,1
       jmp       short M16_L29
M16_L28:
       mov       ecx,ebp
       xor       edx,edx
M16_L29:
       mov       [rsp+20],ecx
       mov       [rsp+28],edx
       mov       rcx,rsi
       mov       edx,r14d
       mov       r8d,ebx
       call      qword ptr [7FFDF4DDD9F8]
       jmp       near ptr M16_L12
M16_L30:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 976
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
       call      qword ptr [7FFE3F580D78]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       ecx,ebx
       and       ecx,0FFFFFF
       mov       edx,ecx
       mov       r8d,ebx
       sar       r8d,18
       jne       short M18_L01
       cmp       [rax],ecx
       jle       short M18_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M18_L03
M18_L00:
       add       rsp,20
       pop       rbx
       ret
M18_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M18_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M18_L00
M18_L02:
       cmp       [rax+4],edx
       jle       short M18_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M18_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M18_L03
       jmp       short M18_L00
M18_L03:
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
       call      qword ptr [7FFE3F583E40]
       test      eax,eax
       je        short M19_L00
       add       rsp,20
       pop       rbx
       ret
M19_L00:
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
       jl        short M20_L00
       add       rsp,28
       ret
M20_L00:
       call      qword ptr [7FFE3F5909B0]
       int       3
; Total bytes of code 20
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Security.EncryptionHelperBenchmark.GenerateRandomKey()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       call      qword ptr [7FFDF4DB4B70]; DotNetTips.Spargine.Core.Ulid.NewUlid()
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
       mov       rax,0A85C313E3317
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
       call      qword ptr [7FFDF4D153E0]; System.DateTimeOffset.get_UtcNow()
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
       call      qword ptr [7FFDF4C6EC88]; System.Security.Cryptography.RandomNumberGeneratorImplementation.GetBytes(Byte*, Int32)
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
       call      qword ptr [7FFDF4DB4BE8]; DotNetTips.Spargine.Core.Ulid..ctor(System.String)
       mov       rax,[rbp+18]
       mov       r8,0A85C313E3317
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
       mov       r9,202A64021C8
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
; Total bytes of code 749
```

