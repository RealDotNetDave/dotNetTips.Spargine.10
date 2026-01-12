## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       sub       rsp,348
       vzeroupper
       lea       rbp,[rsp+380]
       xor       eax,eax
       mov       [rbp-2B8],rax
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
       mov       [rbp-320],rdi
       mov       [rbp-280],rsi
       test      rbx,rbx
       je        near ptr M00_L56
       mov       eax,[rbx+8]
       cmp       dword ptr [rbx+8],0
       je        near ptr M00_L56
       movzx     eax,word ptr [rbx+0C]
       cmp       eax,100
       jge       near ptr M00_L58
       mov       rdx,7FFAA8D06920
       test      byte ptr [rdx+rax],80
       jne       near ptr M00_L60
M00_L03:
       mov       eax,[rbx+8]
       dec       eax
       cmp       eax,[rbx+8]
       jae       near ptr M00_L108
       movzx     eax,word ptr [rbx+rax*2+0C]
       cmp       eax,100
       jge       near ptr M00_L59
       mov       rdx,7FFAA8D06920
       test      byte ptr [rdx+rax],80
       jne       near ptr M00_L60
M00_L04:
       mov       [rbp-278],rbx
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
       mov       rsi,[rbp-280]
       mov       r8,26D80000108
       mov       r15,[r8]
       mov       [rbp-348],r15
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
       call      qword ptr [7FFA49F17AE0]; System.Text.Unicode.Utf16Utility.GetPointerToFirstInvalidChar(Char*, Int32, Int64 ByRef, Int32 ByRef)
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
       mov       rcx,26D80001E00
       mov       r12,[rcx]
       mov       [rbp-338],r12
       mov       [rbp-2D0],r12
       mov       dword ptr [rbp-0CC],0C
       mov       rcx,26D800003A8
       mov       r8,[rcx]
       mov       [rbp-340],r8
       mov       [rbp-2C8],r8
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],9
       jle       near ptr M00_L67
       mov       rcx,[rcx+240]
       mov       r9,[rcx+48]
       test      r9,r9
       je        near ptr M00_L67
M00_L06:
       mov       [rbp-330],r9
       mov       rcx,[r9+10]
       test      rcx,rcx
       je        short M00_L07
       cmp       dword ptr [rcx+8],0
       je        short M00_L07
       mov       r11,[rcx+10]
       test      r11,r11
       jne       near ptr M00_L14
M00_L07:
       mov       rax,[rbp-2D0]
       mov       rcx,[rax+10]
       mov       r11d,[rcx+8]
       test      r11d,r11d
       je        near ptr M00_L76
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        near ptr M00_L75
       mov       rdx,[rcx+8]
       mov       [rbp-2E0],rdx
       xor       ecx,ecx
       mov       [rbp-0E8],ecx
       lea       rcx,[rbp-0E8]
       mov       r11,7FFBD04F22B0
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
       cmp       dword ptr [7FFAA9E7F778],0
       jne       near ptr M00_L69
M00_L08:
       mov       rdi,[rbp-2E0]
       cmp       dword ptr [rdi+8],0
       jle       near ptr M00_L72
M00_L09:
       cmp       ebx,[rdi+8]
       jae       near ptr M00_L108
       mov       ecx,ebx
       mov       r15,[rdi+rcx*8+10]
       cmp       [r15],r15b
       xor       r12d,r12d
       mov       rcx,r15
       call      00007FFAA9A59E20
       test      eax,eax
       je        near ptr M00_L70
M00_L10:
       mov       rcx,[r15+8]
       mov       eax,[r15+10]
       dec       eax
       cmp       [rcx+8],eax
       ja        short M00_L15
M00_L11:
       mov       rcx,r15
       call      00007FFAA9B16030
       test      eax,eax
       jne       near ptr M00_L71
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
       jmp       near ptr M00_L72
M00_L14:
       xor       edx,edx
       mov       [rcx+10],rdx
       mov       r10,[rbp-2C8]
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
       je        near ptr M00_L74
       mov       rsi,[rbp-2C8]
       cmp       byte ptr [rsi+9D],0
       jne       near ptr M00_L73
       mov       rsi,[rbp-280]
M00_L19:
       mov       [rbp-288],rbx
       mov       r12,[rbp-338]
       mov       rbx,r12
       mov       eax,1
       test      r13d,r13d
       cmovne    eax,r13d
       mov       rcx,offset MT_System.Buffers.SharedArrayPool<System.Byte>
       cmp       [rbx],rcx
       jne       near ptr M00_L94
       mov       rdx,rbx
       mov       [rbp-2C0],rdx
       mov       r8,[rbp-340]
       mov       r10,r8
       mov       [rbp-2E8],r10
       lea       ecx,[rax-1]
       or        ecx,0F
       xor       r9d,r9d
       lzcnt     r9d,ecx
       xor       r9d,1F
       add       r9d,0FFFFFFFD
       mov       [rbp-0F0],r9d
       mov       r11,[rbp-330]
       mov       rcx,[r11+10]
       test      rcx,rcx
       je        short M00_L20
       cmp       [rcx+8],r9d
       jbe       short M00_L20
       cmp       r9d,[rcx+8]
       jae       near ptr M00_L108
       mov       edi,r9d
       shl       rdi,4
       mov       rdi,[rcx+rdi+10]
       test      rdi,rdi
       jne       near ptr M00_L27
M00_L20:
       mov       rcx,[rdx+10]
       mov       ebx,[rcx+8]
       cmp       ebx,r9d
       jbe       near ptr M00_L89
       cmp       r9d,ebx
       jae       near ptr M00_L108
       mov       eax,r9d
       mov       rcx,[rcx+rax*8+10]
       test      rcx,rcx
       je        near ptr M00_L88
       mov       rbx,[rcx+8]
       mov       [rbp-2F8],rbx
       xor       ecx,ecx
       mov       [rbp-110],ecx
       lea       rcx,[rbp-110]
       mov       rax,7FFBD04F22B0
       call      rax
       movzx     ebx,word ptr [rbp-110]
       shl       ebx,6
       movzx     esi,byte ptr [rbp-10E]
       or        ebx,esi
       mov       eax,0AAAAAAAB
       mov       ecx,ebx
       imul      rax,rcx
       shr       rax,23
       imul      eax,0C
       sub       ebx,eax
       xor       esi,esi
       cmp       dword ptr [7FFAA9E7F778],0
       jne       near ptr M00_L82
M00_L21:
       mov       rdi,[rbp-2F8]
       cmp       dword ptr [rdi+8],0
       jle       near ptr M00_L85
M00_L22:
       cmp       ebx,[rdi+8]
       jae       near ptr M00_L108
       mov       ecx,ebx
       mov       r15,[rdi+rcx*8+10]
       cmp       [r15],r15b
       xor       r12d,r12d
       mov       rcx,r15
       call      00007FFAA9A59E20
       test      eax,eax
       je        near ptr M00_L83
M00_L23:
       mov       rcx,[r15+8]
       mov       eax,[r15+10]
       dec       eax
       cmp       [rcx+8],eax
       ja        short M00_L28
M00_L24:
       mov       rcx,r15
       call      00007FFAA9B16030
       test      eax,eax
       jne       near ptr M00_L84
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
       jmp       near ptr M00_L85
M00_L27:
       cmp       r9d,[rcx+8]
       jae       near ptr M00_L108
       mov       eax,r9d
       shl       rax,4
       xor       edx,edx
       mov       [rcx+rax+10],rdx
       cmp       byte ptr [r10+9D],0
       je        short M00_L32
       jmp       near ptr M00_L80
M00_L28:
       cmp       eax,[rcx+8]
       jae       near ptr M00_L108
       mov       edx,eax
       mov       r12,[rcx+rdx*8+10]
       cmp       eax,[rcx+8]
       jae       near ptr M00_L108
       mov       edx,eax
       xor       r8d,r8d
       mov       [rcx+rdx*8+10],r8
       mov       [r15+10],eax
       jmp       short M00_L24
M00_L29:
       xor       ebx,ebx
       jmp       short M00_L26
M00_L30:
       mov       rdi,r12
M00_L31:
       test      rdi,rdi
       je        near ptr M00_L87
       mov       rbx,[rbp-2E8]
       cmp       byte ptr [rbx+9D],0
       jne       near ptr M00_L86
       mov       rsi,[rbp-280]
M00_L32:
       mov       rdx,rdi
M00_L33:
       mov       [rbp-290],rdx
       mov       r12,[rbp-338]
       mov       rcx,r12
       mov       edx,1
       test      r13d,r13d
       cmovne    edx,r13d
       mov       rax,offset MT_System.Buffers.SharedArrayPool<System.Byte>
       cmp       [rcx],rax
       jne       near ptr M00_L95
       call      qword ptr [7FFA4A608948]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Rent(Int32)
       mov       rdx,rax
M00_L34:
       mov       [rbp-298],rdx
       mov       [rbp-338],r12
       mov       rbx,r12
       mov       [rbp-308],rbx
       mov       rax,[rbp-340]
       mov       [rbp-300],rax
       mov       rcx,[rbp-330]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       mov       r12,[rbp-338]
       je        short M00_L35
       cmp       dword ptr [rcx+8],0
       je        short M00_L35
       cmp       dword ptr [rcx+8],0
       jbe       near ptr M00_L108
       mov       rdx,[rcx+10]
       test      rdx,rdx
       jne       near ptr M00_L42
M00_L35:
       mov       rcx,[rbx+10]
       mov       edx,[rcx+8]
       test      edx,edx
       je        near ptr M00_L106
       test      edx,edx
       je        near ptr M00_L108
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        near ptr M00_L101
       mov       [rbp-338],r12
       mov       rdx,[rcx+8]
       mov       [rbp-318],rdx
       xor       ecx,ecx
       mov       [rbp-128],ecx
       lea       rcx,[rbp-128]
       mov       r8,7FFBD04F22B0
       call      r8
       movzx     ebx,word ptr [rbp-128]
       shl       ebx,6
       movzx     esi,byte ptr [rbp-126]
       or        ebx,esi
       mov       eax,0AAAAAAAB
       mov       ecx,ebx
       imul      rax,rcx
       shr       rax,23
       imul      eax,0C
       sub       ebx,eax
       xor       esi,esi
       cmp       dword ptr [7FFAA9E7F778],0
       jne       near ptr M00_L98
M00_L36:
       mov       rdi,[rbp-318]
       cmp       dword ptr [rdi+8],0
       jle       near ptr M00_L102
M00_L37:
       cmp       ebx,[rdi+8]
       jae       near ptr M00_L108
       mov       ecx,ebx
       mov       r15,[rdi+rcx*8+10]
       cmp       [r15],r15b
       xor       r12d,r12d
       mov       rcx,r15
       call      00007FFAA9A59E20
       test      eax,eax
       je        near ptr M00_L99
M00_L38:
       mov       rcx,[r15+8]
       mov       eax,[r15+10]
       dec       eax
       cmp       [rcx+8],eax
       ja        short M00_L43
M00_L39:
       mov       rcx,r15
       call      00007FFAA9B16030
       test      eax,eax
       jne       near ptr M00_L100
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
       jmp       near ptr M00_L102
M00_L42:
       cmp       dword ptr [rcx+8],0
       jbe       near ptr M00_L108
       xor       r8d,r8d
       mov       [rcx+10],r8
       cmp       byte ptr [rax+9D],0
       jne       near ptr M00_L96
       mov       rbx,rdx
       jmp       short M00_L47
M00_L43:
       cmp       eax,[rcx+8]
       jae       near ptr M00_L108
       mov       edx,eax
       mov       r12,[rcx+rdx*8+10]
       cmp       eax,[rcx+8]
       jae       near ptr M00_L108
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
       je        near ptr M00_L104
       mov       rsi,[rbp-300]
       cmp       byte ptr [rsi+9D],0
       jne       near ptr M00_L103
       mov       rsi,[rbp-280]
       mov       r12,[rbp-338]
M00_L47:
       mov       [rbp-2A0],rbx
       xor       ecx,ecx
       mov       [rbp-3C],ecx
       cmp       qword ptr [rbp-288],0
       je        near ptr M00_L52
       mov       rdx,[rbp-288]
       cmp       dword ptr [rdx+8],0C
       jl        near ptr M00_L52
       lea       rcx,[rdx+10]
       mov       [rbp-130],rcx
       mov       edx,0C
       call      qword ptr [7FFA4A52ED60]; System.Security.Cryptography.RandomNumberGeneratorImplementation.GetBytes(Byte*, Int32)
       xor       r9d,r9d
       mov       [rbp-130],r9
       test      r13d,r13d
       jle       short M00_L49
       mov       r15,[rbp-348]
       mov       rcx,r15
       mov       r15,[rbp-278]
       lea       rdx,[r15+0C]
       mov       r8d,[r15+8]
       cmp       qword ptr [rbp-290],0
       je        near ptr M00_L53
       mov       rax,[rbp-290]
       lea       r9,[rax+10]
       mov       r10d,[rax+8]
M00_L48:
       mov       [rbp-138],rdx
       mov       [rbp-140],r9
       mov       [rsp+20],r10d
       mov       dword ptr [rsp+28],1
       call      qword ptr [7FFA4A67E880]; System.Text.UTF8Encoding.GetBytesCommon(Char*, Int32, Byte*, Int32, Boolean)
       xor       ecx,ecx
       mov       [rbp-138],rcx
       mov       [rbp-140],rcx
       mov       [rbp-3C],eax
M00_L49:
       mov       rcx,offset MT_System.Security.Cryptography.AesGcm
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       mov       rdx,rsi
       mov       r8d,10
       call      qword ptr [7FFA4A5DD038]; System.Security.Cryptography.AesGcm..ctor(Byte[], Int32)
       mov       [rbp-2A8],r15
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-150],xmm0
       lea       rcx,[rbp-150]
       mov       rdx,[rbp-288]
       xor       r8d,r8d
       mov       r9d,0C
       call      qword ptr [7FFA4A5DC768]; System.Span`1[[System.Byte, System.Private.CoreLib]]..ctor(Byte[], Int32, Int32)
       mov       rdx,[rbp-150]
       mov       r8d,[rbp-148]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-160],xmm0
       lea       rcx,[rbp-160]
       call      qword ptr [7FFA4A67E898]; System.ReadOnlySpan`1[[System.Byte, System.Private.CoreLib]]..ctor(Byte ByRef, Int32)
       mov       rsi,[rbp-160]
       mov       r13d,[rbp-158]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-170],xmm0
       lea       rcx,[rbp-170]
       mov       rdx,[rbp-290]
       mov       r9d,[rbp-3C]
       xor       r8d,r8d
       call      qword ptr [7FFA4A5DC768]; System.Span`1[[System.Byte, System.Private.CoreLib]]..ctor(Byte[], Int32, Int32)
       vmovdqu   xmm0,xmmword ptr [rbp-170]
       vmovdqu   xmmword ptr [rbp-240],xmm0
       lea       rdx,[rbp-240]
       lea       rcx,[rbp-50]
       call      qword ptr [7FFA4A3A7D08]; System.Span`1[[System.Byte, System.Private.CoreLib]].op_Implicit(System.Span`1<Byte>)
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-180],xmm0
       lea       rcx,[rbp-180]
       mov       rdx,[rbp-298]
       mov       r9d,[rbp-3C]
       xor       r8d,r8d
       call      qword ptr [7FFA4A5DC768]; System.Span`1[[System.Byte, System.Private.CoreLib]]..ctor(Byte[], Int32, Int32)
       mov       rax,[rbp-180]
       mov       [rbp-328],rax
       mov       r10d,[rbp-178]
       mov       [rbp-22C],r10d
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-190],xmm0
       lea       rcx,[rbp-190]
       mov       rdx,rbx
       xor       r8d,r8d
       mov       r9d,10
       call      qword ptr [7FFA4A5DC768]; System.Span`1[[System.Byte, System.Private.CoreLib]]..ctor(Byte[], Int32, Int32)
       mov       [rbp-250],rsi
       mov       [rbp-248],r13d
       mov       rsi,[rbp-328]
       mov       [rbp-240],rsi
       mov       esi,[rbp-22C]
       mov       [rbp-238],esi
       vmovdqu   xmm0,xmmword ptr [rbp-190]
       vmovdqu   xmmword ptr [rbp-260],xmm0
       mov       rdi,[rbp-320]
       mov       [rbp-270],rdi
       mov       [rbp-268],r14d
       lea       rdx,[rbp-250]
       lea       r9,[rbp-240]
       lea       r8,[rbp-260]
       mov       [rsp+20],r8
       lea       r8,[rbp-270]
       mov       [rsp+28],r8
       lea       r8,[rbp-50]
       mov       rcx,r15
       call      qword ptr [7FFA4A5DD050]; System.Security.Cryptography.AesGcm.Encrypt(System.ReadOnlySpan`1<Byte>, System.ReadOnlySpan`1<Byte>, System.Span`1<Byte>, System.Span`1<Byte>, System.ReadOnlySpan`1<Byte>)
       nop
       mov       rcx,[r15+8]
       cmp       [rcx],ecx
       call      qword ptr [7FFA4A0C1140]; System.Runtime.InteropServices.SafeHandle.Dispose()
       mov       esi,[rbp-3C]
       add       esi,0D
       jo        near ptr M00_L54
       mov       r9d,esi
       add       r9d,10
       jo        near ptr M00_L54
       mov       [rbp-54],r9d
       mov       rcx,r12
       mov       edx,[rbp-54]
       call      qword ptr [7FFA4A608948]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Rent(Int32)
       mov       [rbp-2B0],rax
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-1A0],xmm0
       lea       rcx,[rbp-1A0]
       mov       rdx,[rbp-2B0]
       mov       r9d,[rbp-54]
       xor       r8d,r8d
       call      qword ptr [7FFA4A5DC768]; System.Span`1[[System.Byte, System.Private.CoreLib]]..ctor(Byte[], Int32, Int32)
       vmovdqu   xmm0,xmmword ptr [rbp-1A0]
       vmovdqu   xmmword ptr [rbp-68],xmm0
       cmp       dword ptr [rbp-60],0
       jbe       near ptr M00_L50
       mov       rcx,[rbp-68]
       mov       byte ptr [rcx],1
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-1B0],xmm0
       lea       rcx,[rbp-1B0]
       mov       rdx,[rbp-288]
       xor       r8d,r8d
       mov       r9d,0C
       call      qword ptr [7FFA4A5DC768]; System.Span`1[[System.Byte, System.Private.CoreLib]]..ctor(Byte[], Int32, Int32)
       vmovdqu   xmm0,xmmword ptr [rbp-1B0]
       vmovdqu   xmmword ptr [rbp-78],xmm0
       lea       rcx,[rbp-68]
       lea       rdx,[rbp-88]
       mov       r8d,1
       mov       r9d,0C
       call      qword ptr [7FFA4A3A7CF0]; System.Span`1[[System.Byte, System.Private.CoreLib]].Slice(Int32, Int32)
       lea       rcx,[rbp-78]
       lea       rdx,[rbp-88]
       call      qword ptr [7FFA4A5D7420]; System.Span`1[[System.Byte, System.Private.CoreLib]].CopyTo(System.Span`1<Byte>)
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-1C0],xmm0
       lea       rcx,[rbp-1C0]
       mov       rdx,[rbp-298]
       mov       r9d,[rbp-3C]
       xor       r8d,r8d
       call      qword ptr [7FFA4A5DC768]; System.Span`1[[System.Byte, System.Private.CoreLib]]..ctor(Byte[], Int32, Int32)
       vmovdqu   xmm0,xmmword ptr [rbp-1C0]
       vmovdqu   xmmword ptr [rbp-78],xmm0
       lea       rcx,[rbp-68]
       lea       rdx,[rbp-98]
       mov       r9d,[rbp-3C]
       mov       r8d,0D
       call      qword ptr [7FFA4A3A7CF0]; System.Span`1[[System.Byte, System.Private.CoreLib]].Slice(Int32, Int32)
       lea       rcx,[rbp-78]
       lea       rdx,[rbp-98]
       call      qword ptr [7FFA4A5D7420]; System.Span`1[[System.Byte, System.Private.CoreLib]].CopyTo(System.Span`1<Byte>)
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-1D0],xmm0
       lea       rcx,[rbp-1D0]
       mov       rdx,rbx
       xor       r8d,r8d
       mov       r9d,10
       call      qword ptr [7FFA4A5DC768]; System.Span`1[[System.Byte, System.Private.CoreLib]]..ctor(Byte[], Int32, Int32)
       vmovdqu   xmm0,xmmword ptr [rbp-1D0]
       vmovdqu   xmmword ptr [rbp-78],xmm0
       mov       r8d,esi
       lea       rdx,[rbp-0A8]
       lea       rcx,[rbp-68]
       mov       r9d,10
       call      qword ptr [7FFA4A3A7CF0]; System.Span`1[[System.Byte, System.Private.CoreLib]].Slice(Int32, Int32)
       lea       rcx,[rbp-78]
       lea       rdx,[rbp-0A8]
       call      qword ptr [7FFA4A5D7420]; System.Span`1[[System.Byte, System.Private.CoreLib]].CopyTo(System.Span`1<Byte>)
       mov       rcx,[rbp-2B0]
       mov       r8d,[rbp-54]
       xor       edx,edx
       xor       r9d,r9d
       call      qword ptr [7FFA4A5DD1B8]; System.Convert.ToBase64String(Byte[], Int32, Int32, System.Base64FormattingOptions)
       mov       [rbp-2B8],rax
       jmp       short M00_L51
M00_L50:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L51:
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-1E0],xmm0
       lea       rcx,[rbp-1E0]
       mov       rdx,[rbp-2B0]
       mov       r9d,[rbp-54]
       xor       r8d,r8d
       call      qword ptr [7FFA4A5DC768]; System.Span`1[[System.Byte, System.Private.CoreLib]]..ctor(Byte[], Int32, Int32)
       vmovdqu   xmm0,xmmword ptr [rbp-1E0]
       vmovdqu   xmmword ptr [rbp-240],xmm0
       lea       rcx,[rbp-240]
       call      qword ptr [7FFA4A5DC780]; System.Security.Cryptography.CryptographicOperations.ZeroMemory(System.Span`1<Byte>)
       mov       rcx,r12
       mov       rdx,[rbp-2B0]
       mov       r8d,1
       call      qword ptr [7FFA4A608950]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Return(Byte[], Boolean)
       jmp       short M00_L55
M00_L52:
       call      qword ptr [7FFA4A12F1B0]
       int       3
M00_L53:
       xor       r9d,r9d
       xor       r10d,r10d
       jmp       near ptr M00_L48
M00_L54:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L55:
       call      M00_L109
       nop
       mov       rax,[rbp-2B8]
       mov       [rbp-228],rax
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+60]
       lea       r8,[rbp-228]
       mov       rdx,7FFA4A68BB28
       cmp       [rcx],ecx
       call      qword ptr [7FFA4A674CD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,348
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
       call      qword ptr [7FFA4A3A4138]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L57
       call      qword ptr [7FFA4A67DA10]
       mov       rbx,rax
M00_L57:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,26D01BEFF88
       call      qword ptr [7FFA4A67D8F0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L58:
       mov       ecx,eax
       call      qword ptr [7FFA4A67C0A8]
       test      eax,eax
       jne       short M00_L60
       jmp       near ptr M00_L03
M00_L59:
       mov       ecx,eax
       call      qword ptr [7FFA4A67C0A8]
       test      eax,eax
       je        near ptr M00_L04
M00_L60:
       mov       rcx,rbx
       mov       edx,3
       call      qword ptr [7FFA4A67C0C0]
       mov       rbx,rax
       jmp       near ptr M00_L04
M00_L61:
       call      qword ptr [7FFA4A5D7C60]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L62
       call      qword ptr [7FFA4A67DA10]
       mov       rbx,rax
M00_L62:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,26D01BE9C08
       call      qword ptr [7FFA4A67D8F0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L63:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,11CF
       mov       rdx,7FFA4A255B58
       call      qword ptr [7FFA49F1F210]
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,26D01BF0560
       call      qword ptr [7FFA4A305E60]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L64:
       mov       ecx,0E
       call      qword ptr [7FFA49F1FD38]
       int       3
M00_L65:
       mov       rcx,r13
       mov       rdx,r12
       call      qword ptr [7FFA4A67CD50]
       add       eax,[rbp-0B8]
       mov       r13d,eax
       test      r13d,r13d
       mov       [rbp-0B8],r13d
       jge       near ptr M00_L05
M00_L66:
       call      qword ptr [7FFA4A6764C0]
       int       3
M00_L67:
       mov       ecx,9
       call      qword ptr [7FFA4A67C390]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       r9,rax
       jmp       near ptr M00_L06
M00_L68:
       mov       [rbp-2D8],r11
       mov       rcx,r11
       call      qword ptr [7FFA4A3ACA20]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rbp-0DC],eax
       mov       rdx,[rbp-2D8]
       mov       r8d,[rdx+8]
       mov       [rbp-0E0],r8d
       mov       rcx,[rbp-2D0]
       call      qword ptr [7FFA4A3ACA20]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       xor       edx,edx
       mov       [rsp+20],edx
       mov       edx,[rbp-0DC]
       mov       r8d,[rbp-0E0]
       mov       rcx,[rbp-2C8]
       call      qword ptr [7FFA4A67D5A8]
       mov       rbx,[rbp-2D8]
       jmp       near ptr M00_L19
M00_L69:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L08
M00_L70:
       mov       rcx,r15
       call      qword ptr [7FFA4A2145E8]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       near ptr M00_L10
M00_L71:
       mov       ecx,eax
       mov       rdx,r15
       call      qword ptr [7FFA4A21CE70]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
       jmp       near ptr M00_L12
M00_L72:
       xor       edx,edx
       jmp       near ptr M00_L18
M00_L73:
       mov       rcx,rbx
       call      qword ptr [7FFA4A3ACA20]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       edi,eax
       mov       r15d,[rbx+8]
       mov       rcx,[rbp-2D0]
       call      qword ptr [7FFA4A3ACA20]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       xor       edx,edx
       mov       [rsp+20],edx
       mov       edx,edi
       mov       r8d,r15d
       mov       rcx,rsi
       call      qword ptr [7FFA4A67D5A8]
       mov       rsi,[rbp-280]
       jmp       near ptr M00_L19
M00_L74:
       mov       rsi,[rbp-280]
M00_L75:
       mov       dword ptr [rbp-0CC],10
       jmp       short M00_L77
M00_L76:
       mov       ecx,0C
       mov       rdx,26D01BE4128
       call      qword ptr [7FFA4A21D830]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
M00_L77:
       mov       r11d,[rbp-0CC]
       cmp       r11d,800
       jge       short M00_L78
       mov       edx,r11d
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       jmp       short M00_L79
M00_L78:
       mov       ecx,r11d
       xor       edx,edx
       call      qword ptr [7FFA4A67D590]
M00_L79:
       mov       rdx,rax
       mov       rax,[rbp-2C8]
       cmp       byte ptr [rax+9D],0
       je        near ptr M00_L81
       cmp       [rdx],dl
       mov       [rbp-2D8],rdx
       mov       rcx,rdx
       call      qword ptr [7FFA4A3ACA20]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rbp-0D0],eax
       mov       rdx,[rbp-2D8]
       mov       r8d,[rdx+8]
       mov       [rbp-0D4],r8d
       mov       rcx,[rbp-2D0]
       call      qword ptr [7FFA4A3ACA20]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       edx,[rbp-0D0]
       mov       r8d,[rbp-0D4]
       mov       rcx,[rbp-2C8]
       call      qword ptr [7FFA4A67D5A8]
       mov       rdx,[rbp-2D8]
       mov       eax,[rdx+8]
       mov       [rbp-0D8],eax
       mov       rcx,[rbp-2D0]
       call      qword ptr [7FFA4A3ACA20]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       rcx,[rbp-2D0]
       mov       rcx,[rcx+10]
       mov       edx,1
       mov       r8d,2
       cmp       dword ptr [rcx+8],0
       cmovg     edx,r8d
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       [rsp+28],edx
       mov       rcx,[rbp-2C8]
       mov       edx,[rbp-0D0]
       mov       r8d,[rbp-0D8]
       call      qword ptr [7FFA4A67D5C0]
       mov       rbx,[rbp-2D8]
       jmp       near ptr M00_L19
M00_L80:
       mov       rcx,rdi
       call      qword ptr [7FFA4A3ACA20]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rbp-100],eax
       mov       edx,[rdi+8]
       mov       [rbp-104],edx
       mov       rcx,rbx
       call      qword ptr [7FFA4A3ACA20]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       ebx,[rbp-0F0]
       mov       [rsp+20],ebx
       mov       edx,[rbp-100]
       mov       r8d,[rbp-104]
       mov       rcx,[rbp-2E8]
       call      qword ptr [7FFA4A67D5A8]
       jmp       near ptr M00_L32
M00_L81:
       mov       rbx,rdx
       jmp       near ptr M00_L19
M00_L82:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L21
M00_L83:
       mov       rcx,r15
       call      qword ptr [7FFA4A2145E8]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       near ptr M00_L23
M00_L84:
       mov       ecx,eax
       mov       rdx,r15
       call      qword ptr [7FFA4A21CE70]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
       jmp       near ptr M00_L25
M00_L85:
       xor       edi,edi
       jmp       near ptr M00_L31
M00_L86:
       mov       rcx,rdi
       call      qword ptr [7FFA4A3ACA20]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       esi,eax
       mov       r15d,[rdi+8]
       mov       rcx,[rbp-2C0]
       call      qword ptr [7FFA4A3ACA20]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       r12d,[rbp-0F0]
       mov       [rsp+20],r12d
       mov       edx,esi
       mov       r8d,r15d
       mov       rcx,rbx
       call      qword ptr [7FFA4A67D5A8]
       mov       rsi,[rbp-280]
       jmp       near ptr M00_L32
M00_L87:
       mov       rsi,[rbp-280]
       mov       r10,[rbp-2E8]
M00_L88:
       mov       ecx,10
       mov       r9d,[rbp-0F0]
       shlx      eax,ecx,r9d
       mov       ebx,eax
       jmp       short M00_L91
M00_L89:
       test      eax,eax
       jne       short M00_L90
       mov       rdx,26D01BE6EF8
       jmp       near ptr M00_L33
M00_L90:
       mov       [rbp-0EC],eax
       mov       ecx,eax
       mov       rdx,26D01BE4128
       call      qword ptr [7FFA4A21D830]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
       mov       ebx,[rbp-0EC]
       mov       r10,[rbp-2E8]
M00_L91:
       cmp       ebx,800
       jge       short M00_L92
       movsxd    rdx,ebx
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       jmp       short M00_L93
M00_L92:
       mov       ecx,ebx
       xor       edx,edx
       call      qword ptr [7FFA4A67D590]
M00_L93:
       mov       rdx,rax
       mov       rbx,[rbp-2E8]
       cmp       byte ptr [rbx+9D],0
       je        near ptr M00_L97
       cmp       [rdx],dl
       mov       [rbp-2F0],rdx
       mov       rcx,rdx
       call      qword ptr [7FFA4A3ACA20]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rbp-0F4],eax
       mov       rdx,[rbp-2F0]
       mov       r8d,[rdx+8]
       mov       [rbp-0F8],r8d
       mov       rcx,[rbp-2C0]
       call      qword ptr [7FFA4A3ACA20]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       edx,[rbp-0F4]
       mov       r8d,[rbp-0F8]
       mov       rcx,rbx
       call      qword ptr [7FFA4A67D5A8]
       mov       rdx,[rbp-2F0]
       mov       eax,[rdx+8]
       mov       [rbp-0FC],eax
       mov       rcx,[rbp-2C0]
       call      qword ptr [7FFA4A3ACA20]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       rcx,[rbp-2C0]
       mov       rcx,[rcx+10]
       mov       edx,1
       mov       r8d,2
       mov       eax,[rbp-0F0]
       cmp       [rcx+8],eax
       cmovg     edx,r8d
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       [rsp+28],edx
       mov       rcx,rbx
       mov       edx,[rbp-0F4]
       mov       r8d,[rbp-0FC]
       call      qword ptr [7FFA4A67D5C0]
       mov       rdi,[rbp-2F0]
       jmp       near ptr M00_L32
M00_L94:
       mov       rcx,rbx
       mov       edx,eax
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rdx,rax
       jmp       near ptr M00_L33
M00_L95:
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rdx,rax
       jmp       near ptr M00_L34
M00_L96:
       mov       [rbp-310],rdx
       mov       rcx,rdx
       call      qword ptr [7FFA4A3ACA20]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rbp-118],eax
       mov       rdx,[rbp-310]
       mov       r8d,[rdx+8]
       mov       [rbp-11C],r8d
       mov       rcx,rbx
       call      qword ptr [7FFA4A3ACA20]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       xor       edx,edx
       mov       [rsp+20],edx
       mov       edx,[rbp-118]
       mov       r8d,[rbp-11C]
       mov       rcx,[rbp-300]
       call      qword ptr [7FFA4A67D5A8]
       mov       rbx,[rbp-310]
       jmp       near ptr M00_L47
M00_L97:
       mov       rdi,rdx
       jmp       near ptr M00_L32
M00_L98:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L36
M00_L99:
       mov       rcx,r15
       call      qword ptr [7FFA4A2145E8]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       near ptr M00_L38
M00_L100:
       mov       ecx,eax
       mov       rdx,r15
       call      qword ptr [7FFA4A21CE70]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
       jmp       near ptr M00_L40
M00_L101:
       mov       rbx,[rbp-308]
       jmp       short M00_L105
M00_L102:
       xor       edx,edx
       jmp       near ptr M00_L46
M00_L103:
       mov       rcx,rbx
       call      qword ptr [7FFA4A3ACA20]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       edi,eax
       mov       r15d,[rbx+8]
       mov       rcx,[rbp-308]
       call      qword ptr [7FFA4A3ACA20]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       xor       edx,edx
       mov       [rsp+20],edx
       mov       edx,edi
       mov       r8d,r15d
       mov       rcx,rsi
       call      qword ptr [7FFA4A67D5A8]
       mov       rsi,[rbp-280]
       mov       r12,[rbp-338]
       jmp       near ptr M00_L47
M00_L104:
       mov       rbx,[rbp-308]
       mov       rsi,[rbp-280]
       mov       r12,[rbp-338]
M00_L105:
       mov       edx,10
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rdx,[rbp-300]
       cmp       byte ptr [rdx+9D],0
       jne       short M00_L107
       mov       rbx,rax
       jmp       near ptr M00_L47
M00_L106:
       mov       rbx,[rbp-308]
       mov       ecx,10
       mov       rdx,26D01BE4128
       call      qword ptr [7FFA4A21D830]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
       jmp       short M00_L105
M00_L107:
       mov       [rbp-310],rax
       mov       rcx,rax
       call      qword ptr [7FFA4A3ACA20]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rbp-114],eax
       mov       rcx,rbx
       call      qword ptr [7FFA4A3ACA20]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       edx,[rbp-114]
       mov       r8d,10
       mov       rcx,[rbp-300]
       call      qword ptr [7FFA4A67D5A8]
       mov       rcx,rbx
       call      qword ptr [7FFA4A3ACA20]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       rcx,[rbx+10]
       mov       edx,1
       mov       r8d,2
       cmp       dword ptr [rcx+8],0
       cmovg     edx,r8d
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       [rsp+28],edx
       mov       rcx,[rbp-300]
       mov       edx,[rbp-114]
       mov       r8d,10
       call      qword ptr [7FFA4A67D5C0]
       mov       rbx,[rbp-310]
       jmp       near ptr M00_L47
M00_L108:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       sub       rsp,38
       vzeroupper
       mov       rcx,[rbp-2A8]
       mov       rcx,[rcx+8]
       cmp       [rcx],ecx
       call      qword ptr [7FFA4A0C1140]; System.Runtime.InteropServices.SafeHandle.Dispose()
       nop
       add       rsp,38
       ret
       sub       rsp,38
       vzeroupper
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-1E0],xmm0
       lea       rcx,[rbp-1E0]
       mov       rdx,[rbp-2B0]
       mov       r9d,[rbp-54]
       xor       r8d,r8d
       call      qword ptr [7FFA4A5DC768]; System.Span`1[[System.Byte, System.Private.CoreLib]]..ctor(Byte[], Int32, Int32)
       vmovdqu   xmm0,xmmword ptr [rbp-1E0]
       vmovdqu   xmmword ptr [rbp-240],xmm0
       lea       rcx,[rbp-240]
       call      qword ptr [7FFA4A5DC780]; System.Security.Cryptography.CryptographicOperations.ZeroMemory(System.Span`1<Byte>)
       mov       rcx,26D80001E00
       mov       r12,[rcx]
       mov       rcx,r12
       mov       rdx,[rbp-2B0]
       mov       r8d,1
       call      qword ptr [7FFA4A608950]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Return(Byte[], Boolean)
       nop
       add       rsp,38
       ret
M00_L109:
       sub       rsp,38
       vzeroupper
       cmp       dword ptr [rbp-3C],0
       jle       near ptr M00_L110
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-1F0],xmm0
       lea       rcx,[rbp-1F0]
       mov       rdx,[rbp-290]
       mov       r9d,[rbp-3C]
       xor       r8d,r8d
       call      qword ptr [7FFA4A5DC768]; System.Span`1[[System.Byte, System.Private.CoreLib]]..ctor(Byte[], Int32, Int32)
       vmovdqu   xmm0,xmmword ptr [rbp-1F0]
       vmovdqu   xmmword ptr [rbp-240],xmm0
       lea       rcx,[rbp-240]
       call      qword ptr [7FFA4A5DC780]; System.Security.Cryptography.CryptographicOperations.ZeroMemory(System.Span`1<Byte>)
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-200],xmm0
       lea       rcx,[rbp-200]
       mov       rdx,[rbp-298]
       mov       r9d,[rbp-3C]
       xor       r8d,r8d
       call      qword ptr [7FFA4A5DC768]; System.Span`1[[System.Byte, System.Private.CoreLib]]..ctor(Byte[], Int32, Int32)
       vmovdqu   xmm0,xmmword ptr [rbp-200]
       vmovdqu   xmmword ptr [rbp-240],xmm0
       lea       rcx,[rbp-240]
       call      qword ptr [7FFA4A5DC780]; System.Security.Cryptography.CryptographicOperations.ZeroMemory(System.Span`1<Byte>)
M00_L110:
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-210],xmm0
       lea       rcx,[rbp-210]
       mov       rdx,[rbp-2A0]
       xor       r8d,r8d
       mov       r9d,10
       call      qword ptr [7FFA4A5DC768]; System.Span`1[[System.Byte, System.Private.CoreLib]]..ctor(Byte[], Int32, Int32)
       vmovdqu   xmm0,xmmword ptr [rbp-210]
       vmovdqu   xmmword ptr [rbp-240],xmm0
       lea       rcx,[rbp-240]
       call      qword ptr [7FFA4A5DC780]; System.Security.Cryptography.CryptographicOperations.ZeroMemory(System.Span`1<Byte>)
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-220],xmm0
       lea       rcx,[rbp-220]
       mov       rdx,[rbp-288]
       xor       r8d,r8d
       mov       r9d,0C
       call      qword ptr [7FFA4A5DC768]; System.Span`1[[System.Byte, System.Private.CoreLib]]..ctor(Byte[], Int32, Int32)
       vmovdqu   xmm0,xmmword ptr [rbp-220]
       vmovdqu   xmmword ptr [rbp-240],xmm0
       lea       rcx,[rbp-240]
       call      qword ptr [7FFA4A5DC780]; System.Security.Cryptography.CryptographicOperations.ZeroMemory(System.Span`1<Byte>)
       mov       rcx,26D80001E00
       mov       r12,[rcx]
       mov       rcx,r12
       mov       rdx,[rbp-290]
       mov       r8d,1
       call      qword ptr [7FFA4A608950]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Return(Byte[], Boolean)
       mov       rcx,r12
       mov       rdx,[rbp-298]
       mov       r8d,1
       call      qword ptr [7FFA4A608950]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Return(Byte[], Boolean)
       mov       rcx,r12
       mov       rdx,[rbp-2A0]
       mov       r8d,1
       call      qword ptr [7FFA4A608950]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Return(Byte[], Boolean)
       mov       rcx,r12
       mov       rdx,[rbp-288]
       mov       r8d,1
       call      qword ptr [7FFA4A608950]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Return(Byte[], Boolean)
       nop
       add       rsp,38
       ret
; Total bytes of code 5763
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
       vbroadcastss xmm0,dword ptr [7FFA4A719788]
       vbroadcastss xmm1,dword ptr [7FFA4A71978C]
       vbroadcastss xmm2,dword ptr [7FFA4A719790]
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
       vbroadcastss xmm0,dword ptr [7FFA4A719794]
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
       vbroadcastss ymm0,dword ptr [7FFA4A719794]
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
       mov       rcx,26D800003A8
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
       jbe       near ptr M02_L22
       mov       eax,ebp
       mov       rcx,[rcx+rax*8+10]
       test      rcx,rcx
       je        near ptr M02_L21
       mov       r14,[rcx+8]
       mov       [rsp+38],r14
       xor       ecx,ecx
       mov       [rsp+48],ecx
       lea       rcx,[rsp+48]
       mov       rax,7FFBD04F22B0
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
       cmp       dword ptr [7FFAA9E7F778],0
       jne       near ptr M02_L16
M02_L02:
       mov       r14,[rsp+38]
       mov       esi,[r14+8]
       test      esi,esi
       jle       near ptr M02_L19
       mov       edi,esi
M02_L03:
       cmp       ebx,esi
       jae       near ptr M02_L27
       mov       ecx,ebx
       mov       r15,[r14+rcx*8+10]
       cmp       [r15],r15b
       xor       r13d,r13d
       mov       rcx,r15
       call      00007FFAA9A59E20
       test      eax,eax
       je        near ptr M02_L17
M02_L04:
       mov       rcx,[r15+8]
       mov       eax,[r15+10]
       dec       eax
       cmp       [rcx+8],eax
       ja        short M02_L09
M02_L05:
       mov       rcx,r15
       call      00007FFAA9B16030
       test      eax,eax
       jne       near ptr M02_L18
M02_L06:
       test      r13,r13
       jne       short M02_L11
       inc       ebx
       cmp       esi,ebx
       je        short M02_L10
M02_L07:
       dec       edi
       jne       short M02_L03
       jmp       near ptr M02_L19
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
       je        near ptr M02_L21
       mov       rdi,[rsp+40]
       cmp       byte ptr [rdi+9D],0
       jne       near ptr M02_L20
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
       call      qword ptr [7FFA4A67C390]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M02_L00
M02_L15:
       mov       rcx,r14
       call      qword ptr [7FFA4A3ACA20]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       ebx,eax
       mov       r15d,[r14+8]
       cmp       [rsi],sil
       mov       rcx,rsi
       call      qword ptr [7FFA4A3ACA20]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       [rsp+20],ebp
       mov       edx,ebx
       mov       r8d,r15d
       mov       rcx,rdi
       call      qword ptr [7FFA4A67D5A8]
       jmp       short M02_L13
M02_L16:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M02_L02
M02_L17:
       mov       rcx,r15
       call      qword ptr [7FFA4A2145E8]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       near ptr M02_L04
M02_L18:
       mov       ecx,eax
       mov       rdx,r15
       call      qword ptr [7FFA4A21CE70]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
       jmp       near ptr M02_L06
M02_L19:
       xor       r14d,r14d
       jmp       near ptr M02_L12
M02_L20:
       mov       rcx,r14
       call      qword ptr [7FFA4A3ACA20]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       ebx,eax
       mov       esi,[r14+8]
       mov       rcx,[rsp+90]
       call      qword ptr [7FFA4A3ACA20]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       [rsp+20],ebp
       mov       edx,ebx
       mov       r8d,esi
       mov       rcx,rdi
       call      qword ptr [7FFA4A67D5A8]
       jmp       near ptr M02_L13
M02_L21:
       mov       ecx,10
       shlx      ebx,ecx,ebp
       mov       rsi,[rsp+90]
       jmp       short M02_L24
M02_L22:
       mov       rsi,[rsp+90]
       test      ebx,ebx
       jne       short M02_L23
       mov       rax,26D01BE6EF8
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M02_L23:
       mov       ecx,ebx
       mov       rdx,26D01BE4128
       call      qword ptr [7FFA4A21D830]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
       nop
M02_L24:
       cmp       ebx,800
       jge       short M02_L25
       movsxd    rdx,ebx
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
       jmp       short M02_L26
M02_L25:
       mov       ecx,ebx
       xor       edx,edx
       call      qword ptr [7FFA4A67D590]
       mov       r14,rax
M02_L26:
       mov       rdi,[rsp+40]
       cmp       byte ptr [rdi+9D],0
       je        near ptr M02_L13
       cmp       [r14],r14b
       mov       rcx,r14
       call      qword ptr [7FFA4A3ACA20]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       ebx,eax
       mov       r15d,[r14+8]
       mov       rcx,rsi
       call      qword ptr [7FFA4A3ACA20]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       edx,ebx
       mov       r8d,r15d
       mov       rcx,rdi
       call      qword ptr [7FFA4A67D5A8]
       mov       r15d,[r14+8]
       mov       rcx,rsi
       call      qword ptr [7FFA4A3ACA20]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
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
       call      qword ptr [7FFA4A67D5C0]
       jmp       near ptr M02_L13
M02_L27:
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
       mov       rax,7FFA4A5BDA08
       mov       [rbp-60],rax
       lea       rax,[M03_L00]
       mov       [rbp-50],rax
       lea       rax,[rbp-70]
       mov       [rdi+8],rax
       mov       byte ptr [rdi+4],0
       mov       rax,7FFBCDD23670
       call      rax
M03_L00:
       mov       byte ptr [rdi+4],1
       cmp       dword ptr [7FFAA9E7F778],0
       je        short M03_L01
       call      qword ptr [7FFAA9E6D608]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FFA4A67D698]
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
       call      qword ptr [7FFA49F17C00]; System.Text.Unicode.Utf8Utility.TranscodeToUtf8(Char*, Int32, Byte*, Int32, Char* ByRef, Byte* ByRef)
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
       call      qword ptr [7FFA4A67CD38]
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
       call      qword ptr [7FFA4A5DD098]; System.Security.Cryptography.AesGcm..ctor(System.ReadOnlySpan`1<Byte>, Int32)
       nop
       add       rsp,30
       pop       rbx
       ret
M05_L00:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,4BF3
       mov       rdx,7FFA4A3CE890
       call      qword ptr [7FFA49F1F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA4A305668]
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
       call      qword ptr [7FFA4A12F1B0]
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
       mov       rax,26D80001ED8
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
       mov       rdx,26D80001EE0
       mov       rdx,[rdx]
       lea       r8,[rbp-40]
       call      qword ptr [7FFA4A5D7DE0]; System.Security.Cryptography.KeySizeHelpers.IsLegalSize(Int32, System.Security.Cryptography.KeySizes, Boolean ByRef)
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
       mov       rax,7FFA4A5BE058
       mov       [rbp-0F8],rax
       lea       rax,[M09_L04]
       mov       [rbp-0E8],rax
       lea       rax,[rbp-108]
       mov       [r12+8],rax
       mov       byte ptr [r12+4],0
       mov       rax,7FFBCDD215B0
       call      rax
M09_L04:
       mov       byte ptr [r12+4],1
       cmp       dword ptr [7FFAA9E7F778],0
       je        short M09_L05
       call      qword ptr [7FFAA9E6D608]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FFA4A67C6D8]
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
       call      qword ptr [7FFA4A67D7B8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA4A21FF60]
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
       call      qword ptr [7FFA4A67D7D0]
       mov       rsi,rax
       mov       ecx,4BFB
       mov       rdx,7FFA4A3CE890
       call      qword ptr [7FFA49F1F210]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFA4A305E60]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M09_L12:
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA4A67D7E8]
       mov       rsi,rax
       mov       edi,[rbp-10C]
       mov       [rbx+8],edi
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFA4A67D800]
       mov       rbx,rax
       mov       ecx,4C31
       mov       rdx,7FFA4A3CE890
       call      qword ptr [7FFA49F1F210]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FFA4A305E60]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M09_L13:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      qword ptr [7FFA4A67D6B0]
       mov       rbx,rax
       mov       ecx,4C31
       mov       rdx,7FFA4A3CE890
       call      qword ptr [7FFA49F1F210]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,r14
       call      qword ptr [7FFA4A305E60]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
       int       3
M09_L14:
       mov       ecx,[rbp-0CC]
       call      qword ptr [7FFA4A67D698]
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
       call      qword ptr [7FFA4A67C6D8]
       int       3
M09_L25:
       test      ecx,ecx
       je        short M09_L29
       call      00007FFAA9B66260
       mov       esi,eax
       mov       rcx,offset MT_Internal.NativeCrypto.SafeKeyHandle
       cmp       [rbx],rcx
       jne       short M09_L27
       cmp       qword ptr [rbx+18],0
       je        short M09_L26
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFA4A5DCF90]; System.Runtime.InteropServices.SafeHandle.DangerousRelease()
       xor       ecx,ecx
       mov       [rbx+18],rcx
M09_L26:
       mov       rcx,[rbx+8]
       call      00007FFA49F08E40
       jmp       short M09_L28
M09_L27:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
M09_L28:
       mov       ecx,esi
       call      00007FFAA9B66280
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
       call      qword ptr [7FFA49F1DE00]; System.Runtime.InteropServices.SafeHandle.InternalRelease(Boolean)
M10_L00:
       mov       rcx,rbx
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFA4A125578]; System.GC.SuppressFinalize(System.Object)
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
       call      qword ptr [7FFA4A12F1B0]
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
       call      qword ptr [7FFA49F15818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       nop
       add       rsp,28
       ret
M12_L00:
       call      qword ptr [7FFA4A3AC378]
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
       je        near ptr M13_L20
       test      ebx,ebx
       jl        near ptr M13_L21
       test      esi,esi
       jl        near ptr M13_L22
       mov       ebp,[rcx+8]
       sub       ebp,ebx
       cmp       esi,ebp
       jl        short M13_L00
       cmp       esi,ebp
       jg        near ptr M13_L05
M13_L00:
       mov       eax,esi
       mov       edx,ebx
       add       rax,rdx
       mov       edx,[rcx+8]
       cmp       rax,rdx
       ja        near ptr M13_L23
       mov       eax,esi
       lea       rbp,[rcx+rax+10]
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
       call      00007FFAA9B68D20
       mov       rsi,rax
       test      edi,edi
       jne       near ptr M13_L31
       cmp       ebx,10
       jl        near ptr M13_L31
       lea       rcx,[rsi+0C]
       mov       edx,[rsi+8]
       mov       edx,[rsi+8]
       imul      r9d,edx,2
       jo        near ptr M13_L34
       mov       [rsp+38],rbp
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
       mov       r9,rbp
       mov       r10,r8
       mov       r11d,ebx
       add       r11,r9
       mov       edi,eax
       add       rdi,r9
       cmp       eax,10
       jl        near ptr M13_L09
       lea       rax,[rdi-20]
       cmp       rax,r9
       jb        near ptr M13_L07
       vmovups   ymm0,[7FFA4A7224E0]
       vbroadcastf128 ymm1,xmmword ptr [7FFA4A722500]
       vbroadcastss ymm2,dword ptr [7FFA4A722510]
       vbroadcastss ymm3,dword ptr [7FFA4A722514]
       vbroadcastss ymm4,dword ptr [7FFA4A722518]
       vbroadcastss ymm5,dword ptr [7FFA4A72251C]
       vbroadcastss ymm6,dword ptr [7FFA4A722520]
       vbroadcastss ymm7,dword ptr [7FFA4A722524]
       vmovups   ymm8,[7FFA4A722540]
       vpermd    ymm8,ymm8,[rbp]
       add       rbp,0FFFFFFFFFFFFFFFC
       xchg      ax,ax
M13_L04:
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
       ja        short M13_L06
       vmovups   ymm8,[rbp]
       jmp       short M13_L04
M13_L05:
       mov       ecx,1149
       mov       rdx,7FFA49E54000
       call      qword ptr [7FFA49F1F210]
       mov       r8,rax
       mov       edx,ebp
       mov       ecx,esi
       call      qword ptr [7FFA4A67D830]
       int       3
M13_L06:
       lea       r9,[rbp+4]
       mov       r10,r8
       cmp       r9,r11
       je        near ptr M13_L12
M13_L07:
       lea       rax,[rdi-10]
       cmp       rax,r9
       jb        near ptr M13_L09
       vmovups   xmm0,[7FFA4A722560]
       vmovups   xmm1,[7FFA4A722500]
       vbroadcastss xmm2,dword ptr [7FFA4A722510]
       vbroadcastss xmm3,dword ptr [7FFA4A722514]
       vbroadcastss xmm4,dword ptr [7FFA4A722518]
       vbroadcastss xmm5,dword ptr [7FFA4A72251C]
       vbroadcastss xmm6,dword ptr [7FFA4A722520]
       vbroadcastss xmm7,dword ptr [7FFA4A722524]
M13_L08:
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
       jbe       short M13_L08
       cmp       r9,r11
       je        near ptr M13_L12
M13_L09:
       mov       r8,7FFAA8D15470
       add       rdi,0FFFFFFFFFFFFFFFE
       cmp       r9,rdi
       jae       short M13_L11
M13_L10:
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
       jb        short M13_L10
M13_L11:
       lea       rax,[rdi+2]
       cmp       rax,r11
       jne       short M13_L12
       lea       rax,[r9+1]
       cmp       rax,r11
       je        near ptr M13_L30
       lea       rax,[r9+2]
       cmp       rax,r11
       jne       short M13_L12
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
M13_L12:
       xor       r9d,r9d
       mov       [rsp+38],r9
       mov       [rsp+30],r9
       mov       r9d,edx
       lea       r9,[rcx+r9*2]
       mov       edx,edx
       add       rdx,rcx
       lea       r8,[rcx+1F]
       cmp       rdx,r8
       jbe       short M13_L14
M13_L13:
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
       ja        short M13_L13
M13_L14:
       lea       r8,[rcx+0F]
       cmp       rdx,r8
       jbe       short M13_L16
M13_L15:
       add       rdx,0FFFFFFFFFFFFFFF0
       add       r9,0FFFFFFFFFFFFFFE0
       vmovups   xmm0,[rdx]
       vpmovzxbw xmm1,xmm0
       vpsrldq   xmm0,xmm0,8
       vpmovzxbw xmm0,xmm0
       vmovups   [r9],xmm1
       vmovups   [r9+10],xmm0
       cmp       rdx,r8
       ja        short M13_L15
M13_L16:
       add       rcx,3
       cmp       rdx,rcx
       jbe       short M13_L18
M13_L17:
       add       r9,0FFFFFFFFFFFFFFF8
       add       rdx,0FFFFFFFFFFFFFFFC
       vmovd     xmm0,dword ptr [rdx]
       vpmovzxbw xmm0,xmm0
       vmovq     qword ptr [r9],xmm0
       cmp       rdx,rcx
       ja        short M13_L17
M13_L18:
       mov       rax,rsi
M13_L19:
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
M13_L20:
       mov       ecx,1139
       mov       rdx,7FFA49E54000
       call      qword ptr [7FFA49F1F210]
       mov       rcx,rax
       call      qword ptr [7FFA4A677B28]
       int       3
M13_L21:
       mov       ecx,0B3
       mov       rdx,7FFA49E54000
       call      qword ptr [7FFA49F1F210]
       mov       rdx,rax
       mov       ecx,ebx
       call      qword ptr [7FFA4A677AF8]
       int       3
M13_L22:
       mov       ecx,1149
       mov       rdx,7FFA49E54000
       call      qword ptr [7FFA49F1F210]
       mov       rdx,rax
       mov       ecx,esi
       call      qword ptr [7FFA4A677AF8]
       int       3
M13_L23:
       call      qword ptr [7FFA4A12F1B0]
       int       3
M13_L24:
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA4A67CE70]
       mov       rsi,rax
       mov       [rbx+8],edi
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFA4A67CCF0]
       mov       rbx,rax
       mov       ecx,1157
       mov       rdx,7FFA49E54000
       call      qword ptr [7FFA49F1F210]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FFA4A305E60]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M13_L25:
       mov       rax,26D01BE0008
       jmp       near ptr M13_L19
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
       call      qword ptr [7FFA4A67CEA0]
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
       jmp       near ptr M13_L12
M13_L31:
       mov       [rsp+48],rbp
       mov       rdx,rbp
       test      rsi,rsi
       jne       short M13_L32
       xor       ecx,ecx
       jmp       short M13_L33
M13_L32:
       lea       rcx,[rsi+0C]
       mov       [rsp+40],rcx
       mov       rcx,[rsp+40]
M13_L33:
       mov       [rsp+20],edi
       mov       r9d,ebx
       xor       r8d,r8d
       call      qword ptr [7FFA4A67CE88]
       xor       eax,eax
       mov       [rsp+40],rax
       mov       [rsp+48],rax
       jmp       near ptr M13_L18
M13_L34:
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
       call      qword ptr [7FFAA6ABAC48]; Precode of System.Span`1[[System.Byte, System.Private.CoreLib]].Clear()
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
       mov       rcx,[rcx+30]
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
       call      qword ptr [7FFA49F157E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
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
       jae       near ptr M15_L30
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
       mov       rax,7FFBD04F22B0
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
       cmp       dword ptr [7FFAA9E7F778],0
       jne       near ptr M15_L21
M15_L04:
       mov       r13,[rsp+38]
       mov       esi,[r13+8]
       test      esi,esi
       jle       near ptr M15_L26
       mov       edi,esi
M15_L05:
       cmp       ebx,esi
       jae       near ptr M15_L30
       mov       ecx,ebx
       mov       r14,[r13+rcx*8+10]
       cmp       [r14],r14b
       xor       r12d,r12d
       mov       rcx,r14
       call      00007FFAA9A59E20
       test      eax,eax
       je        near ptr M15_L22
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
       call      00007FFAA9B16030
       test      eax,eax
       jne       near ptr M15_L23
M15_L09:
       test      r12d,r12d
       je        near ptr M15_L24
       mov       r13d,1
M15_L10:
       mov       rbx,[rsp+0A8]
       mov       rdi,[rsp+0A0]
M15_L11:
       mov       rcx,26D800003A8
       mov       rsi,[rcx]
       cmp       byte ptr [rsi+9D],0
       jne       near ptr M15_L27
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
       call      qword ptr [7FFA4A67C390]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M15_L00
M15_L16:
       mov       rcx,rdi
       call      qword ptr [7FFA4A5DC7B0]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
       mov       r14,rax
       jmp       near ptr M15_L01
M15_L17:
       mov       ecx,2
       call      qword ptr [7FFA49F1FD38]
       int       3
M15_L18:
       shr       rdx,3
       mov       rcx,rax
       call      qword ptr [7FFA4A67D668]
       jmp       near ptr M15_L02
M15_L19:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       call      qword ptr [7FFA4A67D638]
       mov       r13,rax
       mov       ecx,29B
       mov       rdx,7FFA49E54000
       call      qword ptr [7FFA49F1F210]
       mov       r8,rax
       mov       rdx,r13
       mov       rcx,r15
       call      qword ptr [7FFA4A305E60]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
       int       3
M15_L20:
       mov       [rsp+0A0],rdi
       mov       rcx,rdi
       mov       edx,ebp
       call      qword ptr [7FFA4A5DC8D0]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].CreatePerCorePartitions(Int32)
       jmp       near ptr M15_L03
M15_L21:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M15_L04
M15_L22:
       mov       rcx,r14
       call      qword ptr [7FFA4A2145E8]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       near ptr M15_L06
M15_L23:
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FFA4A21CE70]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
       jmp       near ptr M15_L09
M15_L24:
       inc       ebx
       cmp       esi,ebx
       jne       short M15_L25
       xor       ebx,ebx
M15_L25:
       dec       edi
       jne       near ptr M15_L05
M15_L26:
       xor       r13d,r13d
       jmp       near ptr M15_L10
M15_L27:
       cmp       dword ptr [rbx+8],0
       je        near ptr M15_L12
       mov       rcx,rbx
       call      qword ptr [7FFA4A3ACA20]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r14d,eax
       mov       r12d,[rbx+8]
       cmp       [rdi],dil
       mov       rcx,rdi
       call      qword ptr [7FFA4A3ACA20]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,rsi
       mov       r8d,r14d
       mov       r9d,r12d
       mov       edx,3
       call      qword ptr [7FFA4A67D530]
       test      r13d,r15d
       jne       near ptr M15_L12
       mov       rcx,rbx
       call      qword ptr [7FFA4A3ACA20]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r14d,eax
       mov       ebx,[rbx+8]
       mov       rcx,rdi
       call      qword ptr [7FFA4A3ACA20]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       test      r15d,r15d
       jne       short M15_L28
       mov       ecx,0FFFFFFFF
       mov       edx,1
       jmp       short M15_L29
M15_L28:
       mov       ecx,ebp
       xor       edx,edx
M15_L29:
       mov       [rsp+20],ecx
       mov       [rsp+28],edx
       mov       rcx,rsi
       mov       edx,r14d
       mov       r8d,ebx
       call      qword ptr [7FFA4A67D650]
       jmp       near ptr M15_L12
M15_L30:
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
       call      qword ptr [7FFAA9990D78]; Precode of System.Threading.Thread.GetThreadStaticsBase()
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
       call      qword ptr [7FFAA9993E40]
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
; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
       mov       [rbp+10],rcx
       lea       rcx,[rbp+10]
       mov       [rbp-98],rcx
       lea       rcx,[rbp-90]
       call      qword ptr [7FFAA9978018]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-98]
       call      qword ptr [rax]
       lea       rcx,[rbp-90]
       call      qword ptr [7FFAA9978020]; CORINFO_HELP_JIT_PINVOKE_END
       nop
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
; Total bytes of code 105
```
```assembly
; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
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
       mov       [rbp+18],rdx
       mov       edx,ecx
       lea       rcx,[rbp+18]
       mov       [rbp-9C],rcx
       mov       [rbp-94],edx
       lea       rcx,[rbp-90]
       call      qword ptr [7FFAA9978018]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-9C]
       mov       edx,[rbp-94]
       call      qword ptr [rax]
       lea       rcx,[rbp-90]
       call      qword ptr [7FFAA9978020]; CORINFO_HELP_JIT_PINVOKE_END
       nop
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
; Total bytes of code 119
```
```assembly
; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
       sub       rsp,28
       test      ecx,ecx
       jl        short M21_L00
       add       rsp,28
       ret
M21_L00:
       call      qword ptr [7FFAA99A09B0]
       int       3
; Total bytes of code 20
```

